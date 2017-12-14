using System;
using System.Windows.Forms;

namespace RemoteObject
{
    public class RmtObject : MarshalByRefObject
    {
        private static Button Button;
        private static int count = 0;
        public int Count
        {
            set
            {
                count = value;
            }
            get
            {
                return count;
            }
        }
    }
}
