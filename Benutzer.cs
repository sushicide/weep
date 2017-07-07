using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weep
{
    class Benutzer
    {
        private int p_id;

        public int P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        private string f_mit_rid;

        public string F_mit_rid
        {
            get { return f_mit_rid; }
            set { f_mit_rid = value; }
        }
        private string wlan_access;

        public string Wlan_access
        {
            get { return wlan_access; }
            set { wlan_access = value; }
        }
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

    }
}
