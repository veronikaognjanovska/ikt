// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const numOfpopcorn = 91;
let popcorn = [];
let bucketHeight = $('.bucket').height();
let size = $('.popcorn').height() * 1.5;

class Popcorn {
    constructor(y, x, weight, index, time, allDone) {
        this.y = y;
        this.x = x;
        this.weight = weight;
        this.index = index;
        this.time = time;
        this.allDone = allDone;
    }

    draw = () => {
        $(`#${this.index}`).css({
            top: `${this.y}px`,
            left: `${this.x}px`,
            'animation-duration': `${this.time}s`,
        });
        $(window).on('resize', function () {
            this.x = 50 + Math.floor(Math.random() * (window.innerWidth - 155));
        });
    };

    motion = () => {
        this.y += this.weight;
        if (this.x > window.innerWidth / 2.8 && this.x < window.innerWidth / 1.6) {
            if (this.y > window.innerHeight - (bucketHeight + size)) {
                this.weight = 0;
                this.allDone = true;
                $(`#${this.index}`).css('z-index', '0');
                $(`#${this.index}`).addClass('paused');
                $(window).on('resize', function () {
                    this.x = 50 + Math.floor(Math.random() * (window.innerWidth - 155));
                });
            }
        }
        if (this.y > window.innerHeight - size) {
            this.weight = 0;
            this.allDone = true;
            $(`#${this.index}`).addClass('paused');
            $(window).on('resize', function () {
                this.x = 50 + Math.floor(Math.random() * (window.innerWidth - 155));
            });
        }
    };
}

init = () => {
    popcorn = [];
    for (let i = 0; i < numOfpopcorn; i++) {
        let y = -200;
        let x = 50 + Math.floor(Math.random() * (window.innerWidth - 155));
        let weight = Math.floor(Math.random() * 15 + 8);
        let index = i;
        let time = Math.floor(Math.random() * 3 + 1);
        let allDone = false;
        popcorn.push(new Popcorn(y, x, weight, index, time, allDone));
    }
};

animate = () => {
    let int = 0;
    for (let i = 0; i < numOfpopcorn; i++) {
        popcorn[i].motion();
        popcorn[i].draw();
        // if (popcorn[i].allDone == true) {
        //   ++int;
        // }
        // if (int == numOfpopcorn) {
        //   return;
        // }
    }
    requestAnimationFrame(animate);
};

// for (let i = 0; i < 91; i++) {
//   $(`#${i}`).draggable({
//
//     start: (event, ui) => {},
//     stop: (event, ui) => {},
//   });
// }

init();
animate();

$(window).resize(function () {
    bucketHeight = $('.bucket').height();
    size = $('.popcorn').height() * 1.5;
    for (let i = 0; i < numOfpopcorn; i++) {
        $(`#${i}`).removeClass('paused');
        $(`#${i}`).css('z-index', '1');
    }
    init();
    // animate();
});

const canvas = document.getElementById('3dglass');
const ctx = canvas.getContext('2d');

ctx.beginPath();
ctx.moveTo(17, 5);
ctx.lineTo(280, 5);
ctx.quadraticCurveTo(292, 5, 292, 15);
ctx.lineTo(292, 132);
ctx.quadraticCurveTo(292, 142, 280, 142);
ctx.lineTo(180, 142);
ctx.quadraticCurveTo(177, 142, 175, 137);
ctx.lineTo(163, 72);
ctx.quadraticCurveTo(160, 67, 157, 67);
ctx.lineTo(137, 67);
ctx.quadraticCurveTo(135, 67, 132, 72);
ctx.lineTo(120, 137);
ctx.quadraticCurveTo(118, 142, 115, 142);
ctx.lineTo(17, 142);
ctx.quadraticCurveTo(7, 142, 7, 132);
ctx.lineTo(7, 15);
ctx.quadraticCurveTo(7, 5, 17, 5);

ctx.lineWidth = 2;
ctx.strokeStyle = '#FFFBFF';
ctx.fillStyle = '#FFFBFF';
ctx.shadowBlur = 10;
ctx.shadowColor = 'black';
ctx.fill();
ctx.stroke();