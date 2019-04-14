using System;
using System.Collections.Generic;
using BigDamnHeroes.WrathAndGlory.Service.Models;

namespace BigDamnHeroes.WrathAndGlory.Service.Services
{
    public class SpeciesService : ISpeciesService
    {
        private readonly SpeciesModel _speciesModel;
        public SpeciesService()
        {
            _speciesModel = new SpeciesModel();
        }

        public IEnumerable<SpeciesModel> ReturnSpeciesList()
        {
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
            
            return speciesList;
        }
    }
}