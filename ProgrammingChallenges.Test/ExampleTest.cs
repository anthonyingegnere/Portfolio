using ProgrammingChallengesLibrary;
using System.Xml.Linq;
using Xunit;
using Challenges = ProgrammingChallengesLibrary.ProgrammingChallenges;

namespace ProgrammingChallenges.Test
{
    public class ExampleTest
    {
        [Fact(Skip = "i skipped this because xyz")]
        public void Test1()
        {
            // Arrange - what are we passing in

            // Act - what we do with it

            // Assert - did it work
            
        }


        [Fact]
        public void Test2()
        {
            // Arrange - what are we passing in

            // Act - what we do with it

            // Assert - did it work
            Assert.Equal(true, false);
            
        }


        [Fact]
        public void Test3()
        {
            // Arrange - what are we passing in

            // Act - what we do with it

            // Assert - did it work

            // By default test will pass

        }

        [Fact]
        public void ProgrammingChallenges_HelloWorld_ValidName_Success()
        {
            // Arrange - what are we passing in
            string name = "Ant";
            string expected = $"Hello, {name}";

            // Act - what we do with it
            string actual = Challenges.HelloWorld(name);

            // Assert - did it work
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test5() 
        {
            // Arrange - what are we passing in

            // Act & Assert 
            Assert.Throws<InvalidOperationException>(() => Challenges.WillFail());
            


        }


    }
}