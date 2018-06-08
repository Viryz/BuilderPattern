using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApplication
{
    class Car
    {
        public string Engine { get; set; }
        public string Doors { get; set; }
        public string Wheels { get; set; }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.Append(Engine + "\n");
            st.Append(Doors + "\n");
            st.AppendFormat(Wheels + "\n");

            return st.ToString();
        }
    }
}
