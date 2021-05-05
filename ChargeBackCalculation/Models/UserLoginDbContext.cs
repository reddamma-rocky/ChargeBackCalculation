﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChargeBackCalculation.Models
{
    public class UserLoginDbContext:DbContext
    {
        public System.Data.Entity.DbSet<ChargeBackCalculation.Models.AdminRegister> AdminRegisters { get; set; }
        public DbSet<CustomerRegister> CustomerRegisters { get; set; }
        public DbSet<EmployeeRegister> EmployeeRegisters { get; set; }
        public DbSet<Employee> Employees { get; set; }

        //public System.Data.Entity.DbSet<ChargeBackCalculation.Models.Customer> Customers { get; set; }
        public DbSet<ComplaintRegister> ComplaintRegisters { get; set; }
        public UserLoginDbContext() : base("UserLoginDbContext")
        
        {
            //Calling Custom DB Initializer
            Database.SetInitializer<UserLoginDbContext>(new CustomerDbInitializer<UserLoginDbContext>());
        }
        public class CustomerDbInitializer<T> : DropCreateDatabaseIfModelChanges<UserLoginDbContext>
        {
            protected override void Seed(UserLoginDbContext context)

            {
                var Employees = new List<Employee>
         {
           new Employee() { CustomerId=1, BankAccountNumber="98765430002" , BankBranchName="Rajampeta",BankAddress="Rajampeta",AvailableBalance=10000},
           new Employee() { CustomerId=2, BankAccountNumber="87654321809" , BankBranchName="Dharmavaram",BankAddress="Dharmavaram",AvailableBalance=20000},
           new Employee() { CustomerId=3, BankAccountNumber="86543217008" , BankBranchName="Kadapa",BankAddress="Kadapa",AvailableBalance=40000},
           new Employee() { CustomerId=4, BankAccountNumber="76543218907" , BankBranchName="Tadipatri",BankAddress="Tadipatri",AvailableBalance=10000},
           new Employee() { CustomerId=5, BankAccountNumber="65432178906" , BankBranchName="Tadipatri",BankAddress="Tadipatri",AvailableBalance=15000},
           new Employee() { CustomerId=6, BankAccountNumber="67890123415" , BankBranchName="Dharmavaram",BankAddress="Dharmavaram",AvailableBalance=24000},
           new Employee() { CustomerId=7, BankAccountNumber="90123456864" , BankBranchName="Ananthapur",BankAddress="Ananthapur",AvailableBalance=80000},
           new Employee() { CustomerId=8, BankAccountNumber="70000123453" , BankBranchName="Proddutur",BankAddress="Proddutur",AvailableBalance=23000},
           new Employee() { CustomerId=9, BankAccountNumber="50000123451" , BankBranchName="Tirupathi",BankAddress="Tirupathi",AvailableBalance=45000},
           new Employee() { CustomerId=10,BankAccountNumber="90000234556" , BankBranchName="Kurnool",BankAddress="Kurnool",AvailableBalance=50000},


                    };

                Employees.ForEach(e => context.Employees.Add(e));
                context.SaveChanges();

            }
        }
    }
}