using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Comum
{
    public abstract class Base : Notifiable<Notification>, IEquatable<Base>
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals(Base other)
        {
            return Id == other.Id; ;
        }
    }
}
