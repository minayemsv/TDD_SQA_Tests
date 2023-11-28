namespace TDD_SQA
{
    public class Tests
    {

        Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void AddingInteger()
        {
            Assert.AreEqual(2, cal.addinteger(1, 1));
        }
        [Test]
        public void AddingFloat()
        {
            Assert.AreEqual(2.7f, cal.addfloat(1.9f, 0.8f));
        }
        [Test]
        public void AddingDouble()
        {
            Assert.AreEqual(0.9d, cal.adddouble(0.8d, 0.1d));
        }



        [Test]
        public void SubtractInteger()
        {
            Assert.AreEqual(3, cal.subtractinteger(5, 2));
        }
        [Test]
        public void SubtractFloat()
        {
            Assert.AreEqual(3.0f, cal.subtractfloat(3.5f, 0.5f));
        }
        [Test]
        public void SubtractDouble()
        {
            Assert.AreEqual(0.5d, cal.subtractdouble(2.0, 1.5d));
        }



        [Test]
        public void MultiplyInteger()
        {
            Assert.AreEqual(12, cal.multiplyinteger(3, 4));
        }
        [Test]
        public void MultiplyFloat()
        {
            Assert.AreEqual(0.36f, cal.multiplyfloat(1.2f, 0.3f));
        }
        [Test]
        public void MultiplyDouble()
        {
            Assert.AreEqual(5.6d, cal.multiplydouble(2.8d, 2.0d));
        }




        [Test]
        public void DivisionInteger()
        {
            Assert.AreEqual(3, cal.divisioninteger(6, 2));
        }
        [Test]
        public void DivisionFloat()
        {
            Assert.AreEqual(13, cal.divisionfloat(3.9f, 0.3f));
        }
        [Test]
        public void DivisionDouble()
        {
            Assert.AreEqual(1.4d, cal.divisiondouble(2.8d, 2.0d));
        }

    }
}