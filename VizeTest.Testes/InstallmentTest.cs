using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VizeTest.Testes
{
    [TestClass]
    public class InstallmentTest
    {
        [TestMethod]
        public void T001CriarInstallmentSucesso()
        {

        }

        [TestMethod]
        public void T002InstallmentErroIdContratoInvalido()
        {
        }

        [TestMethod]
        public void T003InstallmentErroDataInvalida()
        {
        }
        [TestMethod]
        public void T004InstallmentErroValorInvalido()
        {
        }
        [TestMethod]
        public void T005InstallmentErroAntecipacaoDataParcelamentoComVencimentoMenorQue30Dias()
        {
        }

        [TestMethod]
        public void T006InstallmentErroAntecipacaoDataParcelamentoVenmcidaDataAtualMaiorQueVencimento()
        {

        }

        [TestMethod]
        public void T007T006InstallmentErroAntecipacaoUsuarioNaoPodeExecutarEssaOperacao()
        {
        }
    }
}
