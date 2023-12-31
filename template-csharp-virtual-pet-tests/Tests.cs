using NUnit.Framework;
using template_csharp_virtual_pet;
namespace virtual_pet_tests
{
    [TestFixture]
    public class PetTests
    {
        private Pet testPet;
        [SetUp]
        public void SetUp()
        {
            testPet = new Pet(string.Empty, string.Empty, 60, 60, 60);
        }

        [Test]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testPet);
        }

        // INSTRUCTIONS:        
        // Uncomment code in the test body one test at a time        
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Test]
        public void Pet_Should_Have_Name()
        {
            testPet.PetName = "Pet Name";
            Assert.AreEqual("Pet Name", testPet.PetName);
        }

        [Test]
        public void Pet_Should_Have_Species()
        {
           testPet.PetSpecies = "Pet Species";
           Assert.AreEqual("Pet Species", testPet.PetSpecies);
        }

        [Test]
        public void Constructor_Should_Return_Initial_Hunger_Level_Of_60()
        {
            // Assert.AreEqual(60, testPet.PetHunger);
        }

        [Test]
        public void Constructor_Should_Return_Initial_Boredom_Level_Of_60()
        {
            // Assert.AreEqual(60, testPet.PetBoredom);
        }

        [Test]
        public void Constructor_Should_Return_Initial_Health_Level_Of_60()
        {
            // Assert.AreEqual(60, testPet.PetHealth);
        }

        [Test]
        public void Feed_Should_Decrease_Hunger_By_10()
        {
            // testPet.Feed();
            // Assert.AreEqual(50, testPet.GetHunger());
        }

        [Test]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            // testPet.SeeDoctor();
            // Assert.AreEqual(90, testPet.GetHealth());
        }

        [Test]
        public void Play_Should_Increase_Hunger_By_10()
        {
            // testPet.Play();
            // Assert.AreEqual(70, testPet.GetHunger());
        }

        [Test]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            // testPet.Play();
            // Assert.AreEqual(40, testPet.GetBoredom());
        }

        [Test]
        public void Play_Should_Increase_Health_By_10()
        {
            // testPet.Play();
            // Assert.AreEqual(70, testPet.GetHealth());
        }

        [Test]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            // testPet.Tick();
            // Assert.AreEqual(65, testPet.GetHunger());
        }

        [Test]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            // testPet.Tick();
            // Assert.AreEqual(65, testPet.GetBoredom());
        }

        [Test]
        public void Tick_Should_Decrease_Health_By_5()
        {
            // testPet.Tick();
            // Assert.AreEqual(55, testPet.GetHealth());
        }
    }
}