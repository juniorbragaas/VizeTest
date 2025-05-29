using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeTest.Testes.Cenarios
{
    internal class Entrada
    {
        public static string ContratoOK = @"
                [
                  {
                    ""ContractId"": ""CONTRATO-001"",
                    ""ClientId"": ""CLIENTE-123"",
                    ""ClientName"": ""João da Silva"",
                    ""Installments"": [
                      {
                        ""InstallmentId"": ""P001"",
                        ""DueDate"": ""2025-06-10"",
                        ""Amount"": 1500.00,
                        ""Status"": ""open"",
                        ""Anticipated"": false
                      }
                    ]
                  }
                ]";

        public static  string ClientesOK = @"
                [
                  {
                    ""ClientId"": ""CLIENTE-123"",
                    ""ClientName"": ""João da Silva""
                  },
                  {
                    ""ClientId"": ""CLIENTE-456"",
                    ""ClientName"": ""Maria Oliveira""
                  },
                  {
                    ""ClientId"": ""CLIENTE-789"",
                    ""ClientName"": ""Carlos Pereira""
                  }
                ]";

        public static  string InstallmentOk = @"
                [
                  {
                    ""InstallmentId"": 1,
                    ""DueDate"": ""2025-06-10T00:00:00"",
                    ""Amount"": 1500.00,
                    ""Status"": ""open"",
                    ""Anticipated"": false,
                    ""ContractId"": ""CONTRATO-001"",  
                  },
                  {
                    ""InstallmentId"": 2,
                    ""DueDate"": ""2025-07-10T00:00:00"",
                    ""Amount"": 1800.00,
                    ""Status"": ""paid"",
                    ""Anticipated"": true,
                    ""ContractId"": ""CONTRATO-002"",
                  }
                ]";
    }
}
