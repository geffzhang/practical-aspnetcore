using System;

namespace DependencyInjection.Services
{
    public class TheTransientClock
    {
        DateTime _clock = DateTime.UtcNow;

        public string Get()
        {
            return _clock.ToString();
        }
    }
}