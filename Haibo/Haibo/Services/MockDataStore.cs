using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haibo
{
    public class MockDataStore : EventDataStore<Event>
    {
        List<Event> eventItems;

        public MockDataStore()
        {
            eventItems = new List<Event>();

            var mockEvents = new List<Event>
            {
                new Event { Id = Guid.NewGuid().ToString(), Text = "First Event", Description="This is an Event description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Second Event", Description="This is an Event description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Third Event", Description="This is an Event description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Fourth Event", Description="This is an Event description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Fifth Event", Description="This is an Event description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Sixth Event", Description="This is an Event description." },
            };

            foreach (var item in mockEvents)
            {
                eventItems.Add(item);
            }
        }

        public async Task<bool> AddEventAsync(Event item)
        {
            eventItems.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateEventAsync(Event item)
        {
            var _eventItem = eventItems.Where((Event arg) => arg.Id == item.Id).FirstOrDefault();
            eventItems.Remove(_eventItem);
            eventItems.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteEventAsync(string id)
        {
            var _eventItem = eventItems.Where((Event arg) => arg.Id == id).FirstOrDefault();
            eventItems.Remove(_eventItem);

            return await Task.FromResult(true);
        }

        public async Task<Event> GetEventAsync(string id)
        {
            return await Task.FromResult(eventItems.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Event>> GetEventsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(eventItems);
        }
    }
}
