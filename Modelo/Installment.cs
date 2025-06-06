﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Installment
    {
        public int InstallmentId { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public bool Anticipated { get; set; }

        public string ContractId { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
