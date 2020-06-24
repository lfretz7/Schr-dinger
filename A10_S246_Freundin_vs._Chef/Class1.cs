using System;
using System.Collections.Generic;
using System.Text;

namespace A10_S246_Freundin_vs._Chef
{
    public class Person : IEmployee, IFriend
    {
        public string Name { get; set; }
        void IEmployee.GetCalled()
        {
            Console.WriteLine("Ja, Chef?");
        }
        void IFriend.GetCalled()
        {
            Console.WriteLine("Was gibt es, mein Zuckerschneckchen?");
        }

        public void GetCalled()
        {
            Console.WriteLine("Wer schreit denn jetzt?");
        }
        public void BeCool()
        {

        }
        public void GetFired()
        {

        }
    }
}