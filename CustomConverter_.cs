using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConverter
{
    public class CustomConverter_
    {
        public void Convert(string input, out int result)
        {
            int.TryParse(input, out result);
        }
        public void Convert(string input, out double result)
        {
            double.TryParse(input, out result);
        }
        public void Convert(string input, out bool result)
        {
            bool.TryParse(input, out result);
        }
    }
}
