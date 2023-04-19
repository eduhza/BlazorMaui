namespace BlazorLibraryTestProject
{
    public class Tests
    {
        private TodoControl _todoControl;

        [SetUp]
        public void Setup()
        {
            _todoControl = new TodoControl();
        }

        [Theory]
        [TestCase("Eduardo", "Arruda", "Eduardo Arruda")]
        [TestCase("Arthur", "Paz", "Arthur Paz")]
        public void InsertSpaceBetweenNames(string firstName, string lastName, string expected)
        {
            //ACT
            string actual = _todoControl.GetFullName(firstName, lastName);

            //ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(100, 0.6, 10, 170)]
        [TestCase(100, 0, 25, 125)]
        public void PriceShouldBeCorrect(double price, double tax, double fee, double expected)
        {
            //ACT
            double actual = _todoControl.GetFullPrice(price, tax, fee);

            //ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}


/* Test Driven Development
 * RED - GREEN - REFACTOR 
 * 
 * ARRANGE -> ACT -> ASSERT
 */
