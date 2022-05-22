using Cinema.Domain.Domain;
using Cinema.Domain.identity;
using Cinema.Domain.Identity;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Web.Controllers
{
    [Authorize(Roles = RoleName.Admin)]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ImportUsersAsync(IFormFile file)
        {

            //make a copy
            string pathToUpload = $"{Directory.GetCurrentDirectory()}\\files\\{file.FileName}";

            using (FileStream fileStream = System.IO.File.Create(pathToUpload))
            {
                file.CopyTo(fileStream);

                fileStream.Flush();
            }

            //read data from copy file

            List<UserDto> users = getAllUsersFromFile(file.FileName);
            bool result = await this.ImportAllUsersAsync(users);
            
            return RedirectToAction("Index", "Tickets");
        }

        private List<UserDto> getAllUsersFromFile(string fileName)
        {

            List<UserDto> users = new List<UserDto>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\files\\{fileName}";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        users.Add(new UserDto
                        {
                            Email = reader.GetValue(0).ToString(),
                            Password = reader.GetValue(1).ToString(),
                            RoleName = reader.GetValue(2).ToString()
                        });
                    }
                }
            }

            return users;
        }

        private async Task<bool> ImportAllUsersAsync(List<UserDto> users)
        {
            bool status = true;

            foreach (var item in users)
            {
                var userCheck = userManager.FindByEmailAsync(item.Email).Result;

                if (userCheck == null)
                {
                    var user = new ApplicationUser
                    {
                        UserName = item.Email,
                        NormalizedUserName = item.Email,
                        Email = item.Email,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        UserCart = new ShoppingCart()
                    };
                    var result = userManager.CreateAsync(user, item.Password).Result;
                    if(result.Succeeded)
                    {
                        if (item.RoleName == RoleName.Admin)
                        {
                            await userManager.AddToRoleAsync(user, RoleName.Admin);
                        }
                        else
                        {
                            await userManager.AddToRoleAsync(user, RoleName.Standard_User);
                        }
                    }
                    status = status && result.Succeeded;
                }
                else
                {
                    continue;
                }
            }

            return status;
        }





    }
}