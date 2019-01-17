// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Lifecycle.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LifecycleSettingCountByMethod
    {
        /// <summary>
        /// Initializes a new instance of the LifecycleSettingCountByMethod
        /// class.
        /// </summary>
        public LifecycleSettingCountByMethod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LifecycleSettingCountByMethod
        /// class.
        /// </summary>
        /// <param name="lifecycleMethodType">Possible values include:
        /// 'NotIncluded', 'Active', 'Passive', 'Reserve'</param>
        public LifecycleSettingCountByMethod(string lifecycleMethodType = default(string), int? count = default(int?))
        {
            LifecycleMethodType = lifecycleMethodType;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NotIncluded', 'Active',
        /// 'Passive', 'Reserve'
        /// </summary>
        [JsonProperty(PropertyName = "LifecycleMethodType")]
        public string LifecycleMethodType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public int? Count { get; set; }

    }
}
