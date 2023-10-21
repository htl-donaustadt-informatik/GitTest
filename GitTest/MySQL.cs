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
                Console.WriteLine(outerNumber);
                Console.WriteLine(connectionString);
            }

            Connect("Hello");
        }
    }
}
