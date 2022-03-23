﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class Employee : BaseEntity {


        public string Name { get; set; }

        public string Surname { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public decimal SalaryPerMonth { get; set; }

        //1Trasnaction eksartate apo 1employee
        public Transaction Transaction { get; set; }
 

        public Employee() {

        }
    }
}