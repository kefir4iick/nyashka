using Xunit;
using Program;

namespace Program.Tests
{
    public class Tests
    {
        [Fact]
        public void TestPrime()
        {
            Assert.True(Prime.millerrabin(2, 1));
            Assert.True(Prime.millerrabin(3, 1));
            Assert.True(Prime.millerrabin(5, 10));
            Assert.True(Prime.millerrabin(356869, 54));
        }

        [Fact]
        public void TestComposite()
        {
            Assert.False(Prime.millerrabin(1, 10));
            Assert.False(Prime.millerrabin(4, 10));
            Assert.False(Prime.millerrabin(100, 18));
            Assert.False(Prime.millerrabin(221, 25)); 
        }

        [Fact]
        public void TestHorner()
        {
            Assert.Equal(4, MillerRabin.horner(2, 2, 5));
            Assert.Equal(9, MillerRabin.horner(3, 2, 10));
            Assert.Equal(16, MillerRabin.horner(2, 4, 20));
        }
        
        [Fact]
        public void TestGcd()
        {
            Assert.Equal(5, Prime.gcd(15, 10));
            Assert.Equal(1, Prime.gcd(7, 6));
            Assert.Equal(2, Prime.gcd(4, 2));
        }
    }
}
