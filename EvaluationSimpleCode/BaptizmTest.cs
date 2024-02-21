using System.ComponentModel.DataAnnotations;
using EvaluationSampleCode;

namespace EvaluationSimpleCode
{
    [TestClass]
    public class BaptizmTest
    {
        [TestMethod]
        public void Batptizm_InitializesClergyMemberCorrectly()
        {
            ClergyMember clergyMember = new ClergyMember();

            Baptizm baptism = new Baptizm(clergyMember);

            Assert.IsNotNull(baptism.ClergyMember);
            Assert.AreEqual(clergyMember, baptism.ClergyMember);
        }
        [TestMethod]
        public void Batptizm_WithNullClergyMember()
        {
            ClergyMember clergyMember = null;

            Baptizm baptism = new Baptizm(clergyMember);

            Assert.IsNull(baptism.ClergyMember);
        }
        [TestMethod]
        public void CanBeBaptizedBy_WithPriest_ReturnsTrue()
        {
            ClergyMember clergyMember = new ClergyMember { IsPriest = true };

            bool result = new Baptizm(clergyMember).CanBeBaptizedBy(clergyMember);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeBaptizedBy_WithPope_ReturnsTrue()
        {
            ClergyMember clergyMember = new ClergyMember { IsPope = true };

            bool result = new Baptizm(clergyMember).CanBeBaptizedBy(clergyMember);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeBaptizedBy_WithNonPriestNonPope_ReturnsFalse()
        {
            ClergyMember clergyMember = new ClergyMember { IsPriest = false, IsPope = false };

            bool result = new Baptizm(new ClergyMember()).CanBeBaptizedBy(clergyMember);

            Assert.IsFalse(result);

        }
        [TestMethod]
        public void CanBeTeachedBy_WithSameClergyMember_ReturnsTrue()
        {
            var clergyMember = new ClergyMember();
            var baptism = new Baptizm(clergyMember);

            bool result = baptism.CanBeTeachedBy(clergyMember);

            Assert.IsTrue(result);

        }[TestMethod]
        public void CanBeTeachedBy_WithDifferentClergyMember_ReturnsFalse()
        {
            var clergyMember1 = new ClergyMember();
            var clergyMember2 = new ClergyMember();
            var baptism = new Baptizm(clergyMember1);

            bool result = baptism.CanBeTeachedBy(clergyMember2);

            Assert.IsFalse(result);

        }
    }
}