using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    public class MySQL
    {
        // MySQL
        public void OuterConnect(string connectionString) {

            int outerNumber = 4;

            void Connect(string connectionString)
            {
                
                Console.WriteLine(connectionString);
                Console.WriteLine("Creating new MySQL for the fifth commit.");
            }

            Connect("Hello");
        }
    }
}
