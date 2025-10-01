using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Entities
{
    public class TodoCard
    {
        public int Id { get; private set; }
        public string Title { get; private set; }

        public bool IsCompleted { get; private set; }

    }
}
