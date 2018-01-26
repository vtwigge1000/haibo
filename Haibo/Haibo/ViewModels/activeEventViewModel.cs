using System;
using System.Collections.Generic;
using System.Text;

namespace Haibo
{
    public class activeEventViewModel
    {
        public Event CurrentEvent {get; set;}

        public activeEventViewModel()
        {
            CurrentEvent = new Event { Id = Guid.NewGuid().ToString(), Text = "This is the current event", Description = "And this is the description." };
        }
    }
}
