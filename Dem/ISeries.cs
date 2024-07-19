using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem
{
    internal interface ISeries
    {

        public int Current { get; set; }

        public void GetNext();

        public void Reset()
        { Current = 0; }






    }


    public class SeriesTwo : ISeries
    {

        public int Current { get; set; }

        public void GetNext()
        {

            Current += 2;

        }

    






    }

    public class SeriesThree : ISeries
    {

        public int Current { get; set; }

        public void GetNext()
        {

            Current += 3;

        }

     






    }

    public class SeriesFour : ISeries
    {

        public int Current { get; set; }

        public void GetNext()
        {

            Current += 4;

        }

        






    }








}
