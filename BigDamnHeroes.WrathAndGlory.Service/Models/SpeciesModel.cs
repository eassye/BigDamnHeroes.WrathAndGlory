using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BigDamnHeroes.WrathAndGlory.Service.Models  
{  
    public class SpeciesModel  
    {
        public SpeciesModel()
        {
            AttributeModifications = new AttributeModifications();
        }

        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("BuildPointCost")]  
        public int BuildPointCost { get; set; }

        [BsonElement("BaseTier")]  
        public int BaseTier { get; set; }

        [BsonElement("Speed")] 
        public int Speed { get; set; }

        [BsonElement("AttributeModifications")]
        public AttributeModifications AttributeModifications { get; set;}

        [BsonElement("SpeciesAbilities")]
        public string[] SpeciesAbilities {get; set;}
    }

    public class AttributeModifications
    {
        [BsonElement("None")]
        public string None {get; set;}

        [BsonElement("Agility")]
        public int? Agility {get; set;}

        [BsonElement("Toughness")]
        public int? Toughness {get; set;}

        [BsonElement("Resolve")]
        public int? Resolve {get; set;}

        [BsonElement("Wounds")]
        public int? Wounds {get; set;}

        [BsonElement("Strength")]
        public int? Strength {get; set;}
    }
}  