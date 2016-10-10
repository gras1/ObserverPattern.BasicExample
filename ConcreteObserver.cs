﻿using System;

namespace ObserverPattern.BasicExample
{
    public class ConcreteObserver : IObserver
    {
        private readonly string _name;
        private string _observerState;
        private ConcreteSubject _subject;
        
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _subject = subject;
            _name = name;
        }

        public void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
        }

        // Gets or sets subject
        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}