﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesContext.Entities
{
    public class Score
    {
        public  int ScoreId { get; set; }
        public  int DayScore { get; set; }
        public int WeekScore { get; set; }
        public int MonthScore { get; set; }
        public int TotalScore { get; set; }
        public int EmployeeId { get; set; }
    }
}
