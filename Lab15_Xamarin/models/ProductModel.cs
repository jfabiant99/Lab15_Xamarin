﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Lab15_Xamarin.models;
//
//    var productModel = ProductModel.FromJson(jsonString);

namespace Lab15_Xamarin.models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ProductModel
    {
        [JsonProperty("codigo")]
        public long Codigo { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("precio")]
        public string Precio { get; set; }
    }

    public partial class ProductModel
    {
        public static ProductModel[] FromJson(string json) => JsonConvert.DeserializeObject<ProductModel[]>(json, Lab15_Xamarin.models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ProductModel[] self) => JsonConvert.SerializeObject(self, Lab15_Xamarin.models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
