﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public interface IWorkDayCalculator
    {
        DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds);

        int IndexOfNextWeekEnd(DateTime start, WeekEnd[] weekEnds);

        int WeekEndDays(DateTime start, DateTime end, WeekEnd[] weekEnds);
    }
}
