﻿using DatabaseAccess.Models;
using System.Collections.Generic;

namespace DatabaseAccess.Repository
{
    public class UserRepository : IRepository<UserModel>
    {
        private EFDBEntitiesContext context;
        public UserRepository(EFDBEntitiesContext context)
        {
            this.context = context;
        }

        public void Create(UserModel item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(UserModel id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(UserModel itemOld, UserModel itemNew)
        {
            throw new System.NotImplementedException();
        }
    }
}
