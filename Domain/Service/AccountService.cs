﻿using System;
using System.Collections.Generic;
using Domain.Model.PizzaShop;
using Domain.Repository;
using Domain.Rule.Validator;
using Infrastructure.Data;

namespace Domain.Service {
    public class AccountService {
        public static AccountService Instance { get; set; }
        private static AccountRepository Repository { get; set; }

        static AccountService() {
            Instance = new AccountService();
            Repository = new AccountRepository();
        }

        public Account GetAccount(string guid) {
            return Repository.Get(guid);
        }

        public ICollection<Account> FetchAccounts(int pageSize, int offset) {
            return Repository.Fetch(pageSize, offset);
        }

        public ICollection<Account> FindByFilters(ICollection<Filter> filters) {
            return Repository.Filter(filters);
        }

        public ICollection<Account> FindAccountsByName(string name) {
            return Repository.FindAccountsByName(name);
        }

        public Account SaveAccount(Account account) {
            new AccountValidator(account).Validate();
            return Repository.Save(account);
        }

        public Account CreateAccount(Account account) {
            return SaveAccount(account);
        }

        public Account UpdateAccount(Account account) {
            return SaveAccount(account);
        }

        public void DeleteAccount(Account account) {
            Repository.Delete(account);
        }
    }
}
