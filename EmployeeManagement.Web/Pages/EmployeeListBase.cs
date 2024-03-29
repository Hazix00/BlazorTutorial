﻿using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]

        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected bool ShowFooter { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        public int SelectedEmployeesCount { get; set; } = 0;
        protected void EmployeeSelectionChanged(bool isSelected)
        {
            SelectedEmployeesCount = isSelected ? ++SelectedEmployeesCount : --SelectedEmployeesCount;
        }
    }
}
