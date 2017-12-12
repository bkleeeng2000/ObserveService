using System;

namespace RemoteObject
{
    public class RmtObject : MarshalByRefObject
    {
        private static int count = 0;
        public int Count
        {
            get
            {
                return count++;
            }
        }
    }
}
