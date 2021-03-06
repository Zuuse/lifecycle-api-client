// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Lifecycle.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LifecycleGenerationProgress
    {
        /// <summary>
        /// Initializes a new instance of the LifecycleGenerationProgress
        /// class.
        /// </summary>
        public LifecycleGenerationProgress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LifecycleGenerationProgress
        /// class.
        /// </summary>
        /// <param name="step">Possible values include: 'Starting',
        /// 'Processing', 'Finished', 'Errored'</param>
        public LifecycleGenerationProgress(int? currentCount = default(int?), int? totalCount = default(int?), string id = default(string), string step = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? completedTime = default(System.DateTime?), System.DateTime? lastUpdatedTime = default(System.DateTime?), System.DateTime? lastViewedTime = default(System.DateTime?), string errorMessage = default(string))
        {
            CurrentCount = currentCount;
            TotalCount = totalCount;
            Id = id;
            Step = step;
            StartTime = startTime;
            CompletedTime = completedTime;
            LastUpdatedTime = lastUpdatedTime;
            LastViewedTime = lastViewedTime;
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CurrentCount")]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TotalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets possible values include: 'Starting', 'Processing', 'Finished',
        /// 'Errored'
        /// </summary>
        [JsonProperty(PropertyName = "Step")]
        public string Step { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompletedTime")]
        public System.DateTime? CompletedTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastViewedTime")]
        public System.DateTime? LastViewedTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }

    }
}
