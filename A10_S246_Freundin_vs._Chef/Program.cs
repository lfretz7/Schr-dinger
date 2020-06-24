using System;

namespace A10_S246_Freundin_vs._Chef
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            ((IFriend)p).GetCalled();
            ((IEmployee)p).GetCalled();
            p.GetCalled();

            Person p2 = new Person();
            p2.GetCalled();
        }
    }
}
