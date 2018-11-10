﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m4.d9
{
    public class SelectiveContractResolver : DefaultContractResolver
    {
        private IList<string> propertiesList = null;

        public SelectiveContractResolver(IList<string> propertiesToSerialize)
        {
            propertiesList = propertiesToSerialize;
        }

        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            IList<JsonProperty> properties = base.CreateProperties(type, memberSerialization);
            return properties.Where(p => propertiesList.Contains(p.PropertyName)).ToList();
        }
    }
}

