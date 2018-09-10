using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class ToDos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public bool IsUrgent { get; set; }
    }
}
