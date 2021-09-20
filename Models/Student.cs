using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string StudentBirthday { get; set; }
    }
}