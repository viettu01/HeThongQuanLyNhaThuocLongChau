using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau
{
    class ConvertDateToSecond
    {
        public long convertDateToSecond()
        {
            DateTime now = DateTime.Now;
            long epochTicks = now.Ticks - new DateTime(2023, 1, 1).Ticks; 
            long epochSeconds = epochTicks / TimeSpan.TicksPerSecond;

            return epochSeconds;
        }
    }
}
