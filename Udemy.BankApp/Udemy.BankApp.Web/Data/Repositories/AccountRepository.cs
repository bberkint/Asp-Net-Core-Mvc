﻿using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Data.Interfaces;

namespace Udemy.BankApp.Web.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext bankContext)
        {
            _context = bankContext;
        }

        public void Create(Account account) {
            _context.Set<Account>().Add(account);
            _context.SaveChanges();
        }

        public void Remove(Account account)
        {
            _context.Set<Account>().Remove(account);
            _context.SaveChanges();
        }

        public List<Account> GetAll()
        {

            return _context.Set<Account>().ToList();
        }
    }
}
