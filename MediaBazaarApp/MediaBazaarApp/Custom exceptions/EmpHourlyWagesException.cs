﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpHourlyWagesException:Exception
    {
        public EmpHourlyWagesException(int hourlyWages) : base($"The chosen hourlyWages:{hourlyWages} exceeds the limit(20)")
        {

        }
    }
}
