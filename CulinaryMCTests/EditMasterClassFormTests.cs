using CulinaryMC;
using MasterClassManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace CulinaryMCTests.FormTests
{
    [TestClass]
    public class EditMasterClassFormTests
    {
        private MasterClass CreateTestMasterClass()
        {
            return new MasterClass
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Category = "Online",
                Date = DateTime.Now
            };
        }

        [TestMethod]
        public void TestFormLoads()
        {
            using var db = new ApplicationDbContext();
            var testClass = CreateTestMasterClass();
            var form = new EditMasterClassForm(testClass, db);

            Assert.IsNotNull(form);
            Assert.IsInstanceOfType(form, typeof(Form));
        }

        [TestMethod]
        public void TestControlsExist()
        {
            using var db = new ApplicationDbContext();
            var testClass = CreateTestMasterClass();
            var form = new EditMasterClassForm(testClass, db);

            var nameBox = form.Controls.Find("txtName", true);
            var saveBtn = form.Controls.Find("btnSave", true);
            var cancelBtn = form.Controls.Find("btnCancel", true);

            Assert.IsTrue(nameBox.Length > 0);
            Assert.IsTrue(saveBtn.Length > 0);
            Assert.IsTrue(cancelBtn.Length > 0);
        }

        [TestMethod]
        public void TestCategoryDropdown()
        {
            using var db = new ApplicationDbContext();
            var testClass = CreateTestMasterClass();
            var form = new EditMasterClassForm(testClass, db);

            var combo = form.Controls.Find("comboBoxCategory", true)[0] as System.Windows.Forms.ComboBox;
            Assert.IsTrue(combo.Items.Count > 0);
            Assert.AreEqual("Online", combo.Items[0].ToString());
        }
    }
}