﻿using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace Sillycore.RestClient.Serialization
{
    public class CustomJsonSerializer : ISerializer, IDeserializer
    {
        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, SillycoreApp.JsonSerializerSettings);
        }

        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content, SillycoreApp.JsonSerializerSettings);
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public string ContentType
        {
            get { return "application/json"; }
            set { }
        }
    }
}