using Microsoft.EntityFrameworkCore;
using MyTimeAway.BusinessLayer.ViewModels;
using MyTimeAway.DataLayer;
using MyTimeAway.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
namespace MyTimeAway.BusinessLayer.Services.Repository
{
    public class EmployeeLeaveRepository : IEmployeeLeaveRepository
    {
        private readonly MyTimeAwayDbContext _dbContext;
        public EmployeeLeaveRepository(MyTimeAwayDbContext dbContext)
        {
            _dbContext = dbContext;
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

        public async Task<EmployeeLeave> CreateLeave(EmployeeLeave leaveModel)
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