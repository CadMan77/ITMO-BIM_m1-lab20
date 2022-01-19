using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DfLessons_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            //ShowMessage method = Show;
            //Action<string> method = Show;

            s1.Moving += S1_Moving;

            s1.Move(7);
        }

        private static void S1_Moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        //static void Show(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }
    public class Student
    {
        public void Move(int distance)
        {
            for (int i = 1; i <=distance; i++)
            {
                Thread.Sleep(1000);
                if (Moving!=null)
                    Moving(this, new MovingEventArgs(string.Format("Идет перемещение... Пройдено километров {0}",i)));
            }
        }
        public event EventHandler<MovingEventArgs> Moving;

    }
    public class MovingEventArgs: EventArgs
    {
        public string Message { get; private set; }
        public MovingEventArgs (string message)
        {
            Message = message;
        }
    }
}
