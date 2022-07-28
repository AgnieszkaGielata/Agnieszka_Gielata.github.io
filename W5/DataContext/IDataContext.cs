using System.Collections.Generic;
using W5.Models;
using W5.Models;

namespace W5.DataContext
{
    public interface IDataContext
    {
        List<StudentViewModel> GetStudents();
        StudentViewModel GetStudent(int id);
        void AddStudent(StudentViewModel person);
        void RemoveStudent(int id);
        void UpdateStudent(StudentViewModel person);
    }

}
