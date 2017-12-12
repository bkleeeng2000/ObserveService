using System;

namespace RemoteObject
{
    public class RemoteObject : MarshalByRefObject
    {
        private int callCount = 0;

        public int GetCount()
        {
            callCount++;
            return callCount;
        }
    }
}
