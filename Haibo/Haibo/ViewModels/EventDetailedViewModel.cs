using System;
using System.Collections.Generic;
using System.Text;

namespace Haibo
{
    public class EventDetailedViewModel:   BaseViewModel
    {
        public Event Event { get; set; }
        public EventDetailedViewModel(Event eventItem = null)
        {
            Title = eventItem?.Text;
            Event = eventItem;
        }
    }
}
