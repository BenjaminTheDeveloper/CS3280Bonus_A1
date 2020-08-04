using AutoFixture;
using System;
using Moq; 
using Xunit;
using AutoFixtureMoqPractice;
using AutoFixture.AutoMoq; 

namespace AutoFixureTesting
{
    public class UnitTest1
    {
        [Fact]
        public void CreatingRandomIntegerValue_IntegerComparison_MatchIsPossible()
        {
            Fixture fixture = new Fixture();

            var expected = fixture.Create<int>();
            int result = fixture.Create<int>();

            Assert.Equal(expected, result);
            
        }



        [Fact]
        public void MockTest()
        {
            // Set up the mock
            var mockInfo = new Mock<IPerson>();
            mockInfo.SetupAllProperties();
            mockInfo.SetupGet(p => p.name).Returns("Bill"); //When name property is accessed, will return something specific
            mockInfo.SetupSequence(p => p.health).Returns(100); //Setting up the health to return 100

            Action act = () =>
            {
                //Supplies an IPerson Person 
                var sut = new Person(mockInfo.Object);

                Assert.Equal("Bill", sut.Name());
                Assert.Equal(30, sut.Skills());
                Assert.Equal(100, sut.Health());
            };

        }


        //Usng fixture to create a person with Mock Data
        [Fact]
        public void AutoDataTest()
        {
            //Creating a auto data Person 
            var fixture = new Fixture().Customize(new AutoMoqCustomization());
            var objectWithAutoData = fixture.Create<Person>();

            //Writing out the data 
            Console.WriteLine("Name: ", objectWithAutoData.Name());
            Console.WriteLine("Amount of Skills: ", objectWithAutoData.Skills());
            Console.WriteLine("Current Health: ", objectWithAutoData.Health());
        }
    }
}
