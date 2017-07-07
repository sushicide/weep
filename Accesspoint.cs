using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weep
{
    class Accesspoint
    {
        private int access_ID;

        public int Access_ID
        {
            get { return access_ID; }
            set { access_ID = value; }
        }
        private int access_ssid;

        public int Access_ssid
        {
            get { return access_ssid; }
            set { access_ssid = value; }
        }
    }
}
