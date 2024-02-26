using System;


namespace N3_2
{
    abstract class Parent
    {
        protected static Random rnd = new Random();

        protected bool entry = false;

        protected Parent(bool entry = false)
        {
            this.entry = entry;
        }

        public abstract void RndEntry();

        public abstract void UserEntry();

        public abstract void Print();

        public abstract double AverageValue();
        
    }
}
