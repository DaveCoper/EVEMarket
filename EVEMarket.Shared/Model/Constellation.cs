﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using YamlDotNet.Serialization;

namespace EVEMarket.Model
{
    public class Constellation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [YamlMember(Alias = "constellationID")]
        public int Id { get; set; }

        [YamlMember(Alias = "regionID")]
        [ForeignKey("region")]
        public int RegionId { get; set; }
        
        [JsonIgnore]
        public Region Region { get; set; }

        [YamlMember(Alias = "nameID")]
        public int NameId { get; set; }

        [YamlMember(Alias = "descriptionID")]
        public int DescriptionId { get; set; }

        [YamlMember(Alias = "radius")]
        public double? Radius { get; set; }

        [YamlMember(Alias = "nebula")]
        public int? Nebula { get; set; }

        [YamlMember(Alias = "wormholeClassID")]
        public int? WormholeClassId { get; set; }

        [YamlMember(Alias = "center")]
        public Vector3 Center { get; set; }

        [YamlMember(Alias = "min")]
        public Vector3 Min { get; set; }

        [YamlMember(Alias = "max")]
        public Vector3 Max { get; set; }
    }
}
