﻿namespace Lab17
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
    }
}
