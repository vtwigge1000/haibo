using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Haibo
{
    public interface EventDataStore<T>
    {
        Task<bool> AddEventAsync(T item);
        Task<bool> UpdateEventAsync(T item);
        Task<bool> DeleteEventAsync(string id);
        Task<T> GetEventAsync(string id);
        Task<IEnumerable<T>> GetEventsAsync(bool forceRefresh = false);
    }
}
