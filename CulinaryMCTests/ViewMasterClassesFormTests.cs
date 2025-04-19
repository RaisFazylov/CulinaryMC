using CulinaryMC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace CulinaryMCTests.FormTests
{
    [TestClass]
    public class ViewMasterClassesFormTests
    {
        [TestMethod]
        public void TestFormLoads()
        {
            var form = new ViewMasterClassesForm();
            Assert.IsNotNull(form);
            Assert.IsInstanceOfType(form, typeof(Form));
            form.Dispose();
        }

        [TestMethod]
        public void TestFormHasGrid()
        {
            var form = new ViewMasterClassesForm();
            var grid = form.Controls.Find("dgvMasterClasses", true);
            Assert.IsTrue(grid.Length > 0);
            form.Dispose();
        }

        [TestMethod]
        public void TestSearchButtonExists()
        {
            var form = new ViewMasterClassesForm();
            var buttons = form.Controls.Find("btnSearch", true);
            Assert.IsTrue(buttons.Length > 0);
            form.Dispose();
        }
    }
}