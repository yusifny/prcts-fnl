using System;
using System.Collections.Generic;
using System.Text;

namespace practiceday2.Models
{
    class Group
    {
        private int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit 
        {
            get => _studentLimit;
            set
            {
                if (value>=5 && value<=18)
                {
                    _studentLimit = value;
                }
            } 
        }

        private Student[] _students = new Student[0];
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsLower(groupNo[1]))
            {
                for (int i = 2; i < 5; i++)
                {
                    if (char.IsDigit(groupNo[i]) == false)
                    {
                        return false;
                    }
                }
            }return true;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public Student GetStudent(int? Id)
        {
            foreach (var student in _students)
            {
                if (student.Id == Id)
                {
                    return student;
                }
                
            }
            return null;
        }
    }
}
