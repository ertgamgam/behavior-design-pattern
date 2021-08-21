using System.Collections.Generic;

namespace Iterator
{
    public class Cars : IAggregate<Car>
    {
        List<Car> _cars = new();
        public void Add(Car car) => _cars.Add(car);
        public IIterator<Car> CreateIterator() => new Iterator<Car>(_cars);
    }
}