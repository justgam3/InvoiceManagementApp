using FluentValidation;
using FluentValidation.Validators;
using InvoiceManagementApp.Application.Invoices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceManagementApp.Application.Invoices.Validators
{
    public class MustHaveInvoiceItemPropertyValidator<T, TCollectionElement> : PropertyValidator<T, IList<TCollectionElement>>
    {
        public override bool IsValid(ValidationContext<T> context, IList<TCollectionElement> list)
        {
            if(list != null && list.Any())
            {
                return true;
            }
            return false;
        }

        public override string Name => "MustHaveInvoiceItemPropertyValidator";

        protected override string GetDefaultMessageTemplate(string errorCode)
                => "{PropertyName} should not be an empty list.";
    }
}
