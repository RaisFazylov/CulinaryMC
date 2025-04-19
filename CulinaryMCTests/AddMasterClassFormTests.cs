using CulinaryMC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace CulinaryMCTests.FormTests
{
    [TestClass]
    public class AddMasterClassFormTests
    {
        [TestMethod]
        public void TestFormLoads()
        {
            var form = new AddMasterClassForm();
            Assert.IsNotNull(form);
            Assert.IsInstanceOfType(form, typeof(Form));
            form.Dispose();
        }

        [TestMethod]
        public void TestRequiredControlsExist()
        {
            var form = new AddMasterClassForm();

            Assert.IsNotNull(form.Controls.Find("txtName", true)[0]);
            Assert.IsNotNull(form.Controls.Find("btnSave", true)[0]);
            Assert.IsNotNull(form.Controls.Find("cmbCategory", true)[0]);

            form.Dispose();
        }

        [TestMethod]
        public void TestCategoryDropdownHasItems()
        {
            var form = new AddMasterClassForm();
            var comboBox = form.Controls.Find("cmbCategory", true)[0] as ComboBox;

            Assert.IsTrue(comboBox.Items.Count >= 3);
            Assert.AreEqual("Online", comboBox.Items[0].ToString());

            form.Dispose();
        }
    }
}