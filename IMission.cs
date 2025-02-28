﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /*
     * Interface of a mission, which could calculate and
     * has an event handler for the calculation.
     */
    public interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get;}
        String Type { get; }

        double Calculate(double value);
    }
}
