using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;

namespace BigDamnHeroes.WrathAndGlory.Service.Models  
{  
    public class SpeciesModel  
    {
        public SpeciesModel()
        {
            AttributeModifications = new AttributeModifications();
        }

        public string Name { get; set; }  
        public int BuildPointCost { get; set; }  
        public int BaseTier { get; set; } 
        public int Speed { get; set; }
        public AttributeModifications AttributeModifications { get; set;}
        public string[] SpeciesAbilities {get; set;}
    }

    public class AttributeModifications
    {
        public string None {get; set;}
        public int? Agility {get; set;}
        public int? Toughness {get; set;}
        public int? Resolve {get; set;}
        public int? Wounds {get; set;}
        public int? Strength {get; set;}
    }
}  