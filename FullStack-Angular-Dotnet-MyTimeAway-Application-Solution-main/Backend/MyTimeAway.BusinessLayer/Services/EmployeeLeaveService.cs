using MyTimeAway.BusinessLayer.Interfaces;
using MyTimeAway.BusinessLayer.Services.Repository;
using MyTimeAway.BusinessLayer.ViewModels;
using MyTimeAway.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;
namespace MyTimeAway.BusinessLayer.Services
{
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        private readonly IEmployeeLeaveRepository _employeeLeaveRepository;

        public EmployeeLeaveService(IEmployeeLeaveRepository employeeLeaveRepository)
        {
            _employeeLeaveRepository = employeeLeaveRepository;
        }

        public async Task<EmployeeLeave> ApproveLeaveRequest(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> CancelLeaveRequest(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> CreateLeave(EmployeeLeave employeeLeave)
        {
           //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteLeaveById(long id)
        {
           //write your code here
            throw new NotImplementedException();
        }

        public List<EmployeeLeave> GetAllLeaves()
        {
           //write your code here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> GetLeaveById(long id)
        {
           //write your code here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> RejectLeaveRequest(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeLeave>> SearchLeaves(string employeeId, string employeeName, int totalDays)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<EmployeeLeave> UpdateLeave(EmployeeLeaveViewModel model)
        {
           //write your code here
            throw new NotImplementedException();
        }
    }
}
