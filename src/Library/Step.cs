//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Recipes
{
    public class Step : IJsonConvertible
    {
        [JsonConstructor]
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Step(string json)
        {
            this.LoadFromJson(json);
        }
        public void LoadFromJson(string json)
        {
            Step s = JsonSerializer.Deserialize<Step>(json);
            this.Quantity = s.Quantity;
            this.Input = s.Input;
            this.Time = s.Time;
            this.Equipment = s.Equipment;
        }
        public string ConvertToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}