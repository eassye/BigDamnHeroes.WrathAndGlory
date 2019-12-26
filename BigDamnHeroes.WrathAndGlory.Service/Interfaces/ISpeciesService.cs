using System.Collections.Generic;
using BigDamnHeroes.WrathAndGlory.Service.Models;

public interface ISpeciesService
{
    IEnumerable<SpeciesModel> ReturnSpeciesList();
}