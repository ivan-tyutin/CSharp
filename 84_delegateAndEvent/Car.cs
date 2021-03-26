using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84_delegateAndEvent
{

    interface ICar
    {
        delegate void TestDelegate();
        
        event TestDelegate testEvent
        {
            add { }
            remove { }
        }
       TestDelegate testDel {get; set;}

        
    }

    public class CarArgs : EventArgs
    {
        public CarArgs(int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
        }

        public int CurrentSpeed { get; }
    }

    public class Car
    {

        //public event Action<object, int> tooFastHandler;
        public event EventHandler<CarArgs> tooFastHandler;

        int speed = 0;
        public delegate void TooFast(int currentSpeed);

        protected TooFast tooFast;
        
        /*public event TooFast tooFastHandler;*/


        public void Accelerate()
        {
            speed += 10;
            if (speed > 80)
                tooFastHandler?.Invoke(this, new CarArgs(speed));
            
        }

        public void Start()
        {
            speed = 10; 
        }

        public void Stop()
        {
            speed = 0;
        }

        public void RegisterOnTooFast(TooFast tooFast)
        {
            this.tooFast += tooFast;
        }

        public void UnregisterOnTooFast(TooFast tooFast)
        {
            this.tooFast -= tooFast;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 80; i += 10)
            {
                yield return i;
            }
        }


        public static Car operator +(Car x, Car y)
        {
            return new Car() { speed = x.speed + x.speed };
        }
    }

    class MiniCar : Car
    {
        public void Foo()
        {
            tooFastHandler += (a,x) => Console.WriteLine(x); // Можно вызвать только в классе в котором определен
            tooFast(324);
        }
    }
}
