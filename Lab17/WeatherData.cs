namespace Lab17
{
    public class WeatherData : WeatherDataBase, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected override void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
