using System;

namespace Models
{
    public class EventClass
    {
        private static int callAmount;
        public static event Action OnAnnualCall;
        public void Method()
        {
            if (++callAmount % 10 == 0)
            {
                callAmount = 0;
                OnAnnualCall?.Invoke();
            }
            Console.WriteLine("Method called");
        }
    }
}
