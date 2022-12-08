using BiblioTech_3._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bibliotech_Tests
{
    [TestClass]
    public class EmailClickTest
    {
        [TestMethod]

        public void LayoutTest()
        {
            var frm = new frmAdicionarUsuario(null, null);

            frm.BtnEmail_Click(null, null);
            Assert.IsFalse(frm.btnexibirEmail2.Visible);
            Assert.IsFalse(frm.pnlEmail2.Visible);
        }
    }
}
