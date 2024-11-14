using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto
    {
        public string Definition { get; set; }
        public int IsCompleted { get; set; }
    }
}
