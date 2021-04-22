using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementApp.Application.Invoices.ViewModels
{
    public class InvoiceItemVm
    {
        public long Id { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount
        {
            get
            {
                return Quantity * Rate;
            }
        }
    }
}
