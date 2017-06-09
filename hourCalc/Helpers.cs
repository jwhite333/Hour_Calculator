using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hourCalc
{
    class Helpers
    {
        // Do generic things like load files
        public string dateTimeOutput(System.DateTime dateTime)
        {
            string hours = dateTime.Hour.ToString();
            if (hours.Length == 1)
                hours = hours.Insert(0, "0");
            string minutes = dateTime.Minute.ToString();
            if (minutes.Length == 1)
                minutes = minutes.Insert(0, "0");
            string seconds = dateTime.Second.ToString();
            if (seconds.Length == 1)
                seconds = seconds.Insert(0, "0");
            return (hours + ":" + minutes + ":" + seconds);
        }
    }
}
