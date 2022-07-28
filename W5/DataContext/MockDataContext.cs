using System.Collections.Generic;
using System;
using System.Linq;
using W5.Models;

namespace W5.DataContext
{
    
    public class MockDataContext : IDataContext
    {
        List<StudentViewModel> stud = new List<StudentViewModel>() {
        new StudentViewModel(123456,"Jackson",Gender.Male,true,2,new DateTime()),
        new StudentViewModel(123457,"Perry",Gender.Female,false,1,new DateTime(2000,3,22))
        };

        public void AddStudent(StudentViewModel student)
        {
            int nextNumber = stud.Max(s => s.Id) + 1;
            student.Id = nextNumber;
            stud.Add(student);
        }
        public StudentViewModel GetStudent(int id)
        {
            return stud.FirstOrDefault(s => s.Id == id);
        }
        public List<StudentViewModel> GetStudents()
        {
            return stud;
        }
        public void RemoveStudent(int id)
        {
            StudentViewModel studToRemove = stud.FirstOrDefault(s => s.Id == id);
            if (studToRemove != null)
                stud.Remove(studToRemove);
        }
        public void UpdateStudent(StudentViewModel person)
        {
            StudentViewModel studToUpdate = stud.FirstOrDefault(s => s.Id == person.Id);
            stud = stud.Select(s => (s.Id == person.Id) ? person : s).ToList();
        }
    }

}
