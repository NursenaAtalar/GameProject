using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class UserValidateManager : IUserValidateService
    {
        public bool UserValidate(User user)
        {
            return true;
        }
    }
}
