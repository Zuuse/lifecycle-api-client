// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Lifecycle.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TaxonomySummary
    {
        /// <summary>
        /// Initializes a new instance of the TaxonomySummary class.
        /// </summary>
        public TaxonomySummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaxonomySummary class.
        /// </summary>
        public TaxonomySummary(string id = default(string), string name = default(string), bool? isPhysical = default(bool?), IList<double?> interventions = default(IList<double?>))
        {
            Id = id;
            Name = name;
            IsPhysical = isPhysical;
            Interventions = interventions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPhysical")]
        public bool? IsPhysical { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Interventions")]
        public IList<double?> Interventions { get; private set; }

    }
}
