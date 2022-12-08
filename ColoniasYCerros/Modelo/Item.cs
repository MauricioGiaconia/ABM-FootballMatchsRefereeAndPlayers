using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoniasYCerros.Modelo
{
    public class Item
    {

        private String text;
        private object value;

        public String Text { get => text; set => text = value; }
        public object Value { get => this.value; set => this.value = value; }

        public override String ToString()
        {
            return Text;
        }
    }
}
