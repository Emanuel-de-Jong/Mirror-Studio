using MirrorStudio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorStudio.Models.Events
{
    internal class ClickEventModel : EventModel
    {
        public ClickEventType Type { get; set; }


        public ClickEventModel(string name, ClickEventType type) : base(name)
        {
            Type = type;
        }
    }
}
