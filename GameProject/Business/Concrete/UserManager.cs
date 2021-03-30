using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class UserManager : IUserService


    {
        IUserValidateService _userValidateService;
        public UserManager(IUserValidateService userValidateService)
        {
            _userValidateService = userValidateService;

        }
        public void Add(User user)
        {
            if (_userValidateService.UserValidate(user) == true)
            {
                Console.WriteLine(user.FirstName + user.LastName + "   : is added");
            }
            else
            {
                Console.WriteLine("This user is not validate ");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + user.LastName + "   : is deleted");
        }

        public void Update(User user)
        {
            if (_userValidateService.UserValidate(user) == true)
            {
                Console.WriteLine(user.FirstName + user.LastName + "   : is updated");
            }
            else
            {
                Console.WriteLine("This user is not validate ");
            }
        }
    }
}
