using CQRSDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDomain.Repositories
{
    public interface IStudentRepository
    {
        public Task<List<StudentDetails>> GetStudentListAsync();
        public Task<StudentDetails> GetStudentByIdAsync(int Id);
        public Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails);
        public Task<int> UpdateStudentAsync(StudentDetails studentDetails);
        public Task<int> DeleteStudentAsync(int Id);
    }
}
