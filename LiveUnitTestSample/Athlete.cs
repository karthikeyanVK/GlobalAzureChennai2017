using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveUnitTestSample
{
    public class Athlete
    {
        public bool IsAthlete()
        {
            return false;
        }


        public Biker GetBikerDetails()
        {

            var biker = new Biker()
            {
                IsBiker = true
            };
            return biker;
        }

    }
    //public class Swimmer
    //{
    //    public string style { get; set; }
    //}
}
