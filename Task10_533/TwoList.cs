using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_533
{
    public class TwoList
    {
        private class Point
        {
            public int Data { get; set; }
            public Point Next { get; set; }
            public Point Pred { get; set; }
        }

        private Point _beg;
        private Point _last;

        public void Add(int element)
        {
            Point p = new Point();
            p.Data = element;

            if (_beg == null)
            {
                _beg = p;
                _last = p;
            }
            else
            {
                _last.Next = p;
                p.Pred = _last;
                _last = p;
            }
        }

        public void Show()
        {
            Point p = _beg;
            while (p != null)
            {
                Console.Write(p.Data + " ");
                p = p.Next;
            }

            Console.WriteLine();
        }

        public int Calc()
        {
            Point start = _beg;
            Point end = _last;

            int p = 1;

            while (start != null)
            {
                p = p * (start.Data + end.Data);

                start = start.Next;
                end = end.Pred;
            }

            return p;
        }
    }
}
