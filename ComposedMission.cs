using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /*
     * Class of composed mission which could hold some functions
     * and calculate the result with a given value.
     */
    public class ComposedMission : IMission
    {
        String Name { get; }
        String Type { get { return "Composed"; } }
        private List<Func> functionsList = new List<Func>();

        // Constructor of composed mission.
        public ComposedMission(string Name)
        {
            this.Name = Name;
        }

        // This method adds a function to the list of functionality.
        public Add(Func function)
        {
            this.functionsList.Add(function);
        }

        /* This method applies all of the functions in the list on a
         * value and returns the new value. Also it invokes onCalculate event.
         */
        double Calculate(double value)
        {
            // updates the value by applying the functions on it.
            foreach (Func f in this.functionsList)
            {
                value = f(value);
            }
            this.OnCalculate.Invoke(this, value); // invoke calculation event.
            return value;
        }

    }
}
