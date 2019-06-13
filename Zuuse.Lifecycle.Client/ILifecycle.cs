// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Lifecycle.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Lifecycle operations.
    /// </summary>
    public partial interface ILifecycle
    {
        /// <summary>
        /// Retrieves a single lifecycle setting
        /// </summary>
        /// <param name='client'>
        /// The name of the client account
        /// </param>
        /// <param name='id'>
        /// The id of the lifecycle setting
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<LifecycleSetting>> GetLifecycleSettingWithHttpMessagesAsync(string client, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Upserts a single lifecycle setting
        ///
        /// Warnings will be returned using 'Warning' headers
        /// </summary>
        /// <param name='client'>
        /// The name of the client account
        /// </param>
        /// <param name='id'>
        /// The id of the lifecycle setting
        /// </param>
        /// <param name='lifecycleSetting'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<string>> UpsertLifecycleSettingWithHttpMessagesAsync(string client, string id, LifecycleSetting lifecycleSetting, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a single lifecycle setting
        /// </summary>
        /// <param name='client'>
        /// The name of the client account
        /// </param>
        /// <param name='id'>
        /// The id of the lifecycle setting
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<string>> DeleteLifecycleSettingWithHttpMessagesAsync(string client, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Will generate Lifecycle setting for all children physical assets
        /// from the provided LifecycleSetting Default
        /// </summary>
        /// <param name='client'>
        /// The name of the client account
        /// </param>
        /// <param name='id'>
        /// The id of the lifecycle setting
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<GenerationProgress>> GenerateLifecycleSettingsWithHttpMessagesAsync(string client, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the current generation progress for this primary key(if any,
        /// null if there is no progress to display)
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='id'>
        /// The Primary key of the object being generated
        /// </param>
        /// <param name='peek'>
        /// Enables or Disables the update of the Last View Time
        /// </param>
        /// <param name='force'>
        /// Forces the return of the progress regardless of if the information
        /// is out of date
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<GenerationProgress>> GetGenerationProgressWithHttpMessagesAsync(string client, string id, bool? peek = default(bool?), bool? force = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a summary of lifecycle setting Guids
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<SyncSummaryElement>>> GetLifecycleSettingSummaryWithHttpMessagesAsync(string client, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a count of active Lifecycle Settings grouped by their
        /// Method
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<LifecycleSettingCountByMethod>>> GetCountsByMethodWithHttpMessagesAsync(string client, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a collection of lifecycle settings by space separated
        /// Guids
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='terms'>
        /// Space separated Guids of entity ids or Property=Value. Valid
        /// operators are '=', '!=', '&amp;gt;', '&amp;lt;', '&amp;gt;=',
        /// '&amp;lt;='. Dates should be supplied as seconds since Unix epoch.
        /// </param>
        /// <param name='count'>
        /// The number of results to return
        /// </param>
        /// <param name='orderBy'>
        /// The property to order by in ascending order
        /// </param>
        /// <param name='orderByDesc'>
        /// The property to order by in descending order
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<LifecycleSetting>>> QueryLifecycleSettingWithHttpMessagesAsync(string client, string terms, int? count = default(int?), string orderBy = default(string), string orderByDesc = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
