using Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Dispatcher.Entities
{
    public class Dispatcher : BaseAggregateRoot
    {
        public string Name { get;protected set; }
        public Guid UserId { get; private set; }
        private Dispatcher()
        {

        }
        private Dispatcher(string name, Guid userId)
        {
            Name = name;
            UserId = userId;
        }
        public Dispatcher CreateDispatcher(string name,Guid userId)
        {
            return new Dispatcher(name, userId);
        }
    } 
}
