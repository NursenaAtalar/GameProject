using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface IUserValidateService
    {
        bool UserValidate(User user);
    }
}
