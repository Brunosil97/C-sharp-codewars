using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_codewars
{
    public class Fly : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 10;
        }
    }

    public class Walk : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 1;
        }
    }

    public class Viking : IUnit
    {
        public IMoveBehavior MoveBehavior { get; set; }

        public int Position { get; set; }

        public Viking()
        {
            this.MoveBehavior = new Walk();
        }


        public void Move()
        {
            MoveBehavior.Move(this);
        }
    }
}
