using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAzeriCat
{
    public class Yazisma
    {
        public string? Date { get; set; }
        public string? Text { get; set; }

        public override string ToString()
        {
            return $@"{Date} {Text}";
        }
    }
    
}
