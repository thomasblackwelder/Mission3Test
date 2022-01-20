using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3Test.Models
{
    public class CalculatorModel
    {
        [Required]
        [Range(0, 100)]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public int Project { get; set; }
        [Required]
        [Range(0, 100)]
        public int Quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public int Exams { get; set; }
        [Required]
        [Range(0, 100)]
        public int Intex { get; set; }


    }
}
