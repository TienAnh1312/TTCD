using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_5
{
    internal interface Multipleinterface
    {
        public interface IDrivable
        {
            void start();
            void stop();
            bool Strated
            {
                get;
            }
        }
        public interface ISteerable {
            void TurnLeft();
            void TurnRight();
        }
        public interface IMovable : IDrivable, ISteerable
        {
            void Accelerate();
            void Brake();
        }

    }
}
