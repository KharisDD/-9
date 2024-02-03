using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Net.Mime.MediaTypeNames;
using Лаб9;

namespace Lab9.tests
{
    [TestClass]
    public class UnitTestPokemon
    {
        [TestMethod]
        public void ConstructorTestWithoutParameters()
        {
            // Arrange
            Pokemon expectedPokemon1 = new Pokemon(17, 32, 1);
            Pokemon expectedPokemon2 = new Pokemon(414, 396, 496);
            // Act
            Pokemon actualPokemon1 = new Pokemon(0, 0, 0);
            Pokemon actualPokemon2 = new Pokemon();
            Pokemon actualPokemon3 = new Pokemon(1000, 1000, 1000);
            // Assert
            Assert.AreEqual(expectedPokemon1, actualPokemon1);
            Assert.AreEqual(expectedPokemon1, actualPokemon2);
            Assert.AreEqual(expectedPokemon2, actualPokemon3);
            Assert.AreNotEqual(expectedPokemon1, actualPokemon3);
        }

        [TestMethod]
        public void ConstructorTestWithParameters()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon(172, 321, 13);
            // Act
            Pokemon actualPokemon = new Pokemon(172, 321, 13);
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }

        [TestMethod]
        public void CopyConstructorTest()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon(172, 321, 13);
            // Act
            Pokemon actualPokemon = new Pokemon(expectedPokemon);
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }

        [TestMethod]
        public void StaticPokemonUpTest()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon(172, 321, 130);
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            Pokemon.PokemonUp(actualPokemon, 72, 221, 30);
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }

        [TestMethod]
        public void PokemonUpTest()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon(172, 321, 130);
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            actualPokemon.PokemonUp(72, 221, 30);
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }

        [TestMethod]
        public void CPTest()
        {
            // Arrange
            double expectedCP = 1000;
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            double actualCP = ~actualPokemon;
            // Assert
            Assert.AreEqual(expectedCP, actualCP);
        }

        [TestMethod]
        public void TestStaminaDicrement()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon (100, 100, 100);
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 101);
            --actualPokemon;
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }

        [TestMethod]
        public void TestIntType()
        {
            // Arrange
            int expectedNum = 300;
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            int actualNum = (int)actualPokemon;
            // Assert
            Assert.AreEqual(expectedNum, actualNum);
        }

        [TestMethod]
        public void TestDoubleType()
        {
            // Arrange
            double expectedNum = 100;
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            double actualNum = actualPokemon;
            // Assert
            Assert.AreEqual(expectedNum, actualNum);
        }

        [TestMethod]
        public void TestStaminaUp()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon(100, 100, 110);
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            actualPokemon = actualPokemon >> 10;
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }

        [TestMethod]
        public void TestDefenseUp()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon(100, 110, 100);
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            actualPokemon = actualPokemon > 10;
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }

        [TestMethod]
        public void TestAttackUp()
        {
            // Arrange
            Pokemon expectedPokemon = new Pokemon(110, 100, 100);
            // Act
            Pokemon actualPokemon = new Pokemon(100, 100, 100);
            actualPokemon = actualPokemon < 10;
            // Assert
            Assert.AreEqual(expectedPokemon, actualPokemon);
        }
    }

    [TestClass]
    public class UnitTestPokemonArray
    {
        [TestMethod]
        public void CopyConstructorTest()
        {
            // Arrange
            PokemonArray expectedPokemonArray = new PokemonArray();
            // Act
            PokemonArray actualPokemonArray = new PokemonArray(expectedPokemonArray);
            // Assert
            Assert.AreEqual(expectedPokemonArray, actualPokemonArray);
        }

        [TestMethod]
        public void LengthTest()
        {
            // Arrange
            int expectedLength = 10;
            // Act
            PokemonArray actualPokemonArray = new PokemonArray(10, 1);
            int actualLength = actualPokemonArray.Length;
            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void IndexTest()
        {
            // Arrange
            PokemonArray expectedPokemonArray1 = new PokemonArray(10, 1);
            PokemonArray expectedPokemonArray2 = new PokemonArray(expectedPokemonArray1);
            // Act
            Pokemon actualPokemon1 = new Pokemon(expectedPokemonArray1[0]);
            Pokemon actualPokemon2 = new Pokemon(expectedPokemonArray2[0]);
            expectedPokemonArray1[5] = actualPokemon2;
            expectedPokemonArray2[5] = actualPokemon1;
            // Assert
            Assert.AreEqual(expectedPokemonArray1[5], expectedPokemonArray2[5]);
        }
    }
}