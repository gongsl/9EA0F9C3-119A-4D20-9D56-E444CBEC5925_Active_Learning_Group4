﻿using ActiveLearning.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveLearning.Repository.Interface
{
    public interface IUserRepository : IRepository<UserViewModel>
    {

        void AddUserAccount(UserViewModel user);

    }
}