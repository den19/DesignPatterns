using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer1
{
    /// <summary>
    /// Defines a dependency between objects so that when one object
    /// changes its stae, all its observers are notified
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // The subject that will be observed
            Subject subject = new ConcreteSubject("ABC");

            // Attaching 3 observers
            subject.AttachRange(new List<Observer>
                {
                    new ConcreteObserver("o1"),
                    new ConcreteObserver("o2"),
                    new ConcreteObserver("o3")
                }
            );

            // This will trigger the notification to the observers
            subject.SetState("XYZ");

            // Output:
            // Observer o1 notified. New subject state: XYZ

            Console.ReadKey();
        }
    }

    // The abstract classes for the Observer (objects
    // that woukd be notified) and Subject (who notifies)
    abstract class Observer
    {
        public abstract void Update(string state);
    }

    abstract class Subject
    {
        protected string SubjectState;
        protected List<Observer> Observers = new List<Observer>();
        public virtual void Attach(Observer o) => Observers.Add(o);
        public virtual void AttachRange(List<Observer> o) => Observers.AddRange(o);
        public virtual void Detach(Observer o) => Observers.Remove(o);
        public abstract void SetState(string state);
        protected virtual void Notify() => Observers.ForEach(o => o.Update(this.SubjectState));
    }

    // The concrete representation for the Observer and Subject abstarctions
    class ConcreteSubject : Subject
    {
        public ConcreteSubject(string state)
        {
            SetState(state);
        }

        public override void SetState(string state)
        {
            if (this.SubjectState != state)
            {
                this.SubjectState = state;
                Notify();
            }
        }
    }

    class ConcreteObserver : Observer
    {
        private string Name;

        public ConcreteObserver(string name)
        {
            this.Name = name;
        }

        public override void Update(string state) =>
            Console.WriteLine($"Observer {Name} notified. New subject state: {state}");

    }
}
