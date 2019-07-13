using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneyGainBot
{
    public class Realtime
    {
        public double credits { get; set; }
        public int usd_cents { get; set; }
    }

    public class Payout
    {
        public double credits { get; set; }
        public int usd_cents { get; set; }
    }

    public class MinPayout
    {
        public double credits { get; set; }
        public int usd_cents { get; set; }
    }

    public class Data
    {
        public Realtime realtime { get; set; }
        public Payout payout { get; set; }
        public MinPayout min_payout { get; set; }
    }

    public class RootObject
    {
        public object meta { get; set; }
        public Data data { get; set; }
    }
}
