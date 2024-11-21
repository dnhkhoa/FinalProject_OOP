using System;
using System.Drawing;

namespace FinalProject_OOP
{
    internal class UC_AddItems
    {
        public UC_AddItems()
        {
        }

        public bool Visible { get; internal set; }
        public Point Location { get; internal set; }
        public string Name { get; internal set; }
        public Size Size { get; internal set; }
        public int TabIndex { get; internal set; }

        internal void BringToFront()
        {
            throw new NotImplementedException();
        }
    }
}