using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public delegate double Func(double num); // delegate function which receives and returns double.

    /*
     * Class of functions container which consists of a
     * dictionary that holds string-Func (delegate) pairs.
     */
    class FunctionsContainer
    {
        private Dictionary<string, Func> functionsDict = new Dictionary<string, Func>();

        public Func this[string str] // indexer function for the container.
        {
            get
            {
                if (this.functionsDict.ContainsKey(str))
                {
                    return this.functionsDict[str];
                }
                else // if no existing function - adds it as identity function.
                {
                    this.functionsDict[str] = val => val;
                    return this.functionsDict[str];
                }
            }
            set
            {
                this.functionsDict[str] = value;
            }
        }

        // This method loops through all the function keys and returns a list of them all.
        public IList<string> getAllMissions()
        {
            List<string> keyStringsList = new List<string>();
            foreach (string keyString in this.functionsDict.Keys) {
                keyStringsList.Add(keyString);
            }
            return keyStringsList;
        }

    }
}
