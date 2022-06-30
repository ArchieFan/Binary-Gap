

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        [DataRow(9, 2)] //The number 9 has binary representation 1001 and contains a binary gap of length 2.
        [DataRow(529, 4)] //The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3.
        [DataRow(20, 1)] //The number 20 has binary representation 10100 and contains one binary gap of length 1.
        [DataRow(15, 0)] //The number 15 has binary representation 1111 and has no binary gaps.
        [DataRow(32, 0)] //The number 32 has binary representation 100000 and has no binary gaps.
        [DataRow(3245, 2)]
        [DataRow(22, 2)]
        public void TestMethod1(int input_value,int expected_result)
        {
            //Arrange
            Solution s = new Solution();
            //Act
            int result = s.solution(input_value);
            //Assert
            Assert.AreEqual(expected_result, result);

        }
        
    }
}