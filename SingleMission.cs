using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /*
     * Class of single mission which could hold a function
     * and calculate the result with a given value.
     */
    public class SingleMission : IMission
    {
        String Name { get; }
        String Type { get { return "Single"; } }
        private Func function;

        // Constructor of single mission.
        public SingleMission(Func function, string Name)
        {
            this.function = function;
            this.Name = Name;
        }

        /* This method calculates the new value using the function
         * and returns it. Also it invokes calculation event.
         */
        public double Calculate(double value)
        {
            double newValue = function(value);
            OnCalculate.Invoke(this, newValue);
            return function(newValue);
        }

    }
}
