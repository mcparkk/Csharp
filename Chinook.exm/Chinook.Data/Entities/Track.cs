using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    partial class Track : Entity
    {
        public override string ToText()
        {
            return $"{TrackId}:{Name}";
        }
    }
}
