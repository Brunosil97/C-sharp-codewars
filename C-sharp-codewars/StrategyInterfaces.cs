using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_codewars
{
    public interface IUnit
    {
        int Position { get; set; }
        void Move();
        IMoveBehavior MoveBehavior { get; set; }
    }

    public interface IMoveBehavior
    {
        void Move(IUnit unit);
    }

}
