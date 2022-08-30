using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask_1.DataRequest;

namespace Hometask_1.Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataRequest();
        
        }

        static void DataRequest()
        {
            var new_card = new Card();

            while (true)
            {
                new_card.DataRequest();
            }
        }

    }
}


