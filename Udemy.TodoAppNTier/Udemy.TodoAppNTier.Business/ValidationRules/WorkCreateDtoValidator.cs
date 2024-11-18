using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Dtos.WorkDtos;

namespace Udemy.ToDoAppNTier.Business.ValidationRules
{
    internal class WorkCreateDtoValidator : AbstractValidator<WorkCreateDto>
    {
        public WorkCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty().WithMessage("Definition is required").When(x=>x.IsCompleted).Must(NotBeBerkin).WithMessage("Definition Berkin olamaz");

        }

        private bool NotBeBerkin(string arg)
        {
            return arg != "Berkin" && arg != "berkin";
        }
    }
}
