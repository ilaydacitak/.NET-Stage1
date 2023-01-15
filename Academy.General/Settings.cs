using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.General
{
    public class Settings
    {
        public readonly string _aktifZaman;

        public Settings(string zaman)
        {
            _aktifZaman = zaman;
        }

        public const string PAGEKEY = "PAGE.DESIGN.SETTING.VALUE";

        public void Guncelle()
        {
            //PAGEKEY = "PAGE.DESIGN.SETTING.VALUE2";
        }
    }
}
