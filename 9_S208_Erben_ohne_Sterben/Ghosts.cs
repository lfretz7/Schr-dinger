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
        public SlimeGhost(string name)
            : base(name)
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
        public void Eat(Ghost g)
        {
            this.Size += g.Size;
            g = null;
        }
    }
}
