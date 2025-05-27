using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contract
    {
        public string ContractId { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public List<Installment> Installments { get; set; }
    }
}
