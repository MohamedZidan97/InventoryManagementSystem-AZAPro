namespace IMS.Persistance.Tests
{
    public class UnitTest1
    {
        //[Fact]
        //public void Method_Scenario_Outcome()
        //{
        //    // arrange    is input

        //    // act        is operations

        //    // Assert     is  Equalation

        //}



        private int Multiplication (int num1)
        {
            if(num1 == 0) // if obiect must be = null
            {
                throw new ArgumentNullException(nameof(num1));
            }
            return num1 * 6;
        }

        [Fact]
        public void Multiplication_MultiTwoNumbers_Multi()
        {
            // arrange    is input
            int num1 = 5;

            // act        is operations

            int multiplication = Multiplication (num1);
            int expected = 30;

            // Assert     is  Equalation

            Assert.Equal(expected, multiplication);

        }
        [Fact]
        public void Multiplication_Num1IsNull_ThrowArgumentNullException()
        {
            // arrange    is input
            int num1 = 0; // if obiect must be = null

            // act        is operations

            // create generic delegate
            //   in  output      object of input       input
            Func<int,int> func = (n) => Multiplication (n);

            // Assert     is  Equalation

            Assert.Throws<ArgumentNullException>(()=>func(num1));

        }
    }
}