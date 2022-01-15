using MirrorStudio.Enums;
using MirrorStudio.Models;
using MirrorStudio.Models.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorStudio.Templates
{
    internal class EventModelTemplate
    {
        public static ObservableCollection<EventModel> EventModels
        {
            get
            {
                return new ObservableCollection<EventModel>
                    {
                        new ClickEventModel("Click event 1", ClickEventType.Single),
                        new ClickEventModel("Click event 2", ClickEventType.Single),
                        new ClickEventModel("Click event 3", ClickEventType.Single)
                    };
            }
        }

    }
}
