﻿using System.ComponentModel.DataAnnotations;

namespace Bootcamp_CKres_Minor.Model
{
    public class TrScore
    {
        [Key] public int id { get; set; }
        public int studentId { get; set; }
        public int subjectId { get; set; }
        public int semester { get; set; }
        public decimal score { get; set; }
        public string grade { get; set; }
    }
}
