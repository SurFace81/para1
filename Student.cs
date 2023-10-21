using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    internal class Student
    {
        private string? firstname, lastname, group;
        private int exam;
        private string? photo;

        public void createStudent(string name, string surname, string gr, int ex, string ph)
        {
            firstname = name;
            lastname = surname;
            group = gr;
            exam = ex;
            photo = ph;
        }

        public string getInfo()
        {
            return firstname + '\t' + lastname + '\t' + group + '\t' + exam.ToString() + '\t' + photo;
        }

        public string getName()
        {
            return firstname;
        }

        public string getSurname()
        {
            return lastname;
        }

        public string getGroup()
        {
            return group;
        }

        public int getExamScore()
        {
            return exam;
        }
    }
}
