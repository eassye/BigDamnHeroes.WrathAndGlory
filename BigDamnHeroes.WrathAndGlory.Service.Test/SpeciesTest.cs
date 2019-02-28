using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigDamnHeroes.WrathAndGlory.Service.Models;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace BigDamnHeroes.WrathAndGlory.Service.Test
{
    [TestClass]
    public class SpeciesTest
    {
        private readonly SpeciesModel _speciesModel;
        private readonly SpeciesService _serviceUnderTest;
        public SpeciesTest()
        {
            _speciesModel = new SpeciesModel();
            _serviceUnderTest = new SpeciesService();
        }

        [TestMethod]
        public void TestThatSpeciesListReturnsExpectedData()
        {
            
            //Arrange
            var speciesList = new List<SpeciesModel>();
            var abilitiesList = new List<String>();

            abilitiesList.Add("Outsider");
            abilitiesList.Add("Intense Emotion");
            abilitiesList.Add("Psychosensitive");

            _speciesModel.Name = "Eldar";
            _speciesModel.BuildPointCost = 10;
            _speciesModel.BaseTier = 1;
            _speciesModel.Speed = 8;
            _speciesModel.AttributeModifications.Agility = 1;
            _speciesModel.SpeciesAbilities = abilitiesList.ToArray();

            speciesList.Add(_speciesModel);

            var expected = speciesList;
        
            //Act
            var actual = _serviceUnderTest.ReturnSpeciesList();

            System.Console.WriteLine("Expected: ", expected);
            System.Console.WriteLine("Actual: ", actual);
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
