using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ToDoAppNTier.Common.ResponseObjects
{
    public interface IResponse<T> : IResponse
    {
        public T Data { get; set; }
        public List<CustomValidationError> ValidationErrors { get; set; }
    }
}
