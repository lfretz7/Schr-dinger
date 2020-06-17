using System;
using System.Collections.Generic;
using System.Text;

namespace _9_S208_Erben_ohne_Sterben
{
    public class Ghost
    {
        public Ghost(string name)
        {
            this.Name = name;
        }
        public int Size { get; set; }
        public string Name { get; set; }
        public virtual void Haunt()
        {
            Console.WriteLine("{0} sagt: 'Buh'", this.Name);
        }
    }
    public class SlimeGhost : Ghost
    {
        public SlimeGhost(string name) : base(name)
        {
        }
        public override void Haunt()
        {
            this.Slime();
            base.Haunt();
        }
        public void Slime()
        {
            Console.WriteLine("{0} hinterlässt eine Schleimspur", this.Name);
        }
    }
    public class CannibalGhost : Ghost
    {
        public CannibalGhost(string name) : base(name) { }
        public CannibalGhost() : base("") { }
        public void Eat(ref Ghost g)
        {
            IncreaseSize(g.Size);
            g = null;
        }
        public void Eat(ref SlimeGhost g)
        {
            IncreaseSize(g.Size);
            g = null;
        }
        public void Eat(ref CannibalGhost g)
        {
            IncreaseSize(g.Size);
            g = null;
        }
        private void IncreaseSize(int size)
        {
            this.Size += size;
        }
    }
    sealed class EgoistenKlasse { }
}
