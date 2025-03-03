using Xunit;
using Program;

namespace Program.Tests
{
    public class Tests
    {
        [Fact]
        public void TestPrime()
        {
            Assert.True(Prime.millerrabin(2, Prime.pick(2)));
            Assert.True(Prime.millerrabin(3, Prime.pick(3)));
            Assert.True(Prime.millerrabin(5, Prime.pick(5)));
            Assert.True(Prime.millerrabin(356869, Prime.pick(356869)));
        }

        [Fact]
        public void TestComposite()
        {
            Assert.False(Prime.millerrabin(1, Prime.pick(1)));
            Assert.False(Prime.millerrabin(4, Prime.pick(4)));
            Assert.False(Prime.millerrabin(100, Prime.pick(100)));
            Assert.False(Prime.millerrabin(221, Prime.pick(221))); 
        }

        [Fact]
        public void TestHorner()
        {
            Assert.Equal(4, Prime.horner(2, 2, 5));
            Assert.Equal(9, Prime.horner(3, 2, 10));
            Assert.Equal(16, Prime.horner(2, 4, 20));
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
