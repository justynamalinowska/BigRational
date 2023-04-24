using BigRationalLib;
using System.Numerics;

namespace BigRationalTests
   
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]

        [DataRow(1, 2, 1, 2)]
        [DataRow(2, 4, 1, 2)] //upraszczanie
        [DataRow(32, 12, 8, 3)]
        [DataRow(1, -2, -1, 2)] //normalizacja znaków
        [DataRow(-1, 2, -1, 2)]
        [DataRow(-1, -2, 1, 2)]


        public void TestConstructor_2args_OK(int a, int b, int c, int d)
        {
            //AAA
            //Act
            BigRational u = new(a, b);

            //Assert
            Assert.AreEqual(c, u.Numerator); //zweryfikuj czy 1 znajduje sie w u
            Assert.AreEqual(d, u.Denominator);

            
                
        }
    }
}