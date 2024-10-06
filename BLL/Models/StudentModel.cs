using BLL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Record { get; set; }

        public string Name => Record.Name;
        public string Surname => Record.Surname;
        public DateTime BirthDate => (DateTime)Record.BirthDate;
        public decimal GPA => (decimal)Record.Gpa;

        public string FullName => $"{Record.Name} {Record.Surname}";

    }
}
