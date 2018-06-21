using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy1
{
    /// <summary>
    /// This structural code demonstrates the Proxy pattern which provides a representative object (proxy) that controls access to another similar object.
    /// Proxy Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Subject
    {
        public abstract void Request();
    }

    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }

    /// <summary>
    /// The 'Proxy' class
    /// </summary>
    class Proxy : Subject
    {
        private RealSubject _realSubject;
        public override void Request()
        {
            // Use 'lazy initialization'
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
