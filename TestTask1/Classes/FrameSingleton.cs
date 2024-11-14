using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TestTask1.Classes
{
    internal class FrameSingleton
    {
        private static Frame _frame;
        public static void setFrame(Frame frame)
        {
            _frame = frame;
        }
        public static Frame getFrame() { return _frame; }
    }
}
