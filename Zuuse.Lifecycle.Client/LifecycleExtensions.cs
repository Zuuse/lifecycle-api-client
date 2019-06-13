// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Lifecycle.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Lifecycle.
    /// </summary>
    public static partial class LifecycleExtensions
    {
            /// <summary>
            /// Retrieves a single lifecycle setting
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            public static LifecycleSetting GetLifecycleSetting(this ILifecycle operations, string client, string id)
            {
                return operations.GetLifecycleSettingAsync(client, id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a single lifecycle setting
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LifecycleSetting> GetLifecycleSettingAsync(this ILifecycle operations, string client, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLifecycleSettingWithHttpMessagesAsync(client, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upserts a single lifecycle setting
            ///
            /// Warnings will be returned using 'Warning' headers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            /// <param name='lifecycleSetting'>
            /// </param>
            public static string UpsertLifecycleSetting(this ILifecycle operations, string client, string id, LifecycleSetting lifecycleSetting)
            {
                return operations.UpsertLifecycleSettingAsync(client, id, lifecycleSetting).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upserts a single lifecycle setting
            ///
            /// Warnings will be returned using 'Warning' headers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            /// <param name='lifecycleSetting'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> UpsertLifecycleSettingAsync(this ILifecycle operations, string client, string id, LifecycleSetting lifecycleSetting, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpsertLifecycleSettingWithHttpMessagesAsync(client, id, lifecycleSetting, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a single lifecycle setting
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            public static string DeleteLifecycleSetting(this ILifecycle operations, string client, string id)
            {
                return operations.DeleteLifecycleSettingAsync(client, id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a single lifecycle setting
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> DeleteLifecycleSettingAsync(this ILifecycle operations, string client, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteLifecycleSettingWithHttpMessagesAsync(client, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Will generate Lifecycle setting for all children physical assets from the
            /// provided LifecycleSetting Default
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            public static GenerationProgress GenerateLifecycleSettings(this ILifecycle operations, string client, string id)
            {
                return operations.GenerateLifecycleSettingsAsync(client, id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Will generate Lifecycle setting for all children physical assets from the
            /// provided LifecycleSetting Default
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account
            /// </param>
            /// <param name='id'>
            /// The id of the lifecycle setting
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GenerationProgress> GenerateLifecycleSettingsAsync(this ILifecycle operations, string client, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateLifecycleSettingsWithHttpMessagesAsync(client, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the current generation progress for this primary key(if any, null if
            /// there is no progress to display)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// Forces the return of the progress regardless of if the information is out
            /// of date
            /// </param>
            public static GenerationProgress GetGenerationProgress(this ILifecycle operations, string client, string id, bool? peek = default(bool?), bool? force = default(bool?))
            {
                return operations.GetGenerationProgressAsync(client, id, peek, force).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the current generation progress for this primary key(if any, null if
            /// there is no progress to display)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// Forces the return of the progress regardless of if the information is out
            /// of date
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GenerationProgress> GetGenerationProgressAsync(this ILifecycle operations, string client, string id, bool? peek = default(bool?), bool? force = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGenerationProgressWithHttpMessagesAsync(client, id, peek, force, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a summary of lifecycle setting Guids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            public static IList<SyncSummaryElement> GetLifecycleSettingSummary(this ILifecycle operations, string client)
            {
                return operations.GetLifecycleSettingSummaryAsync(client).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a summary of lifecycle setting Guids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SyncSummaryElement>> GetLifecycleSettingSummaryAsync(this ILifecycle operations, string client, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLifecycleSettingSummaryWithHttpMessagesAsync(client, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a count of active Lifecycle Settings grouped by their Method
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            public static IList<LifecycleSettingCountByMethod> GetCountsByMethod(this ILifecycle operations, string client)
            {
                return operations.GetCountsByMethodAsync(client).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a count of active Lifecycle Settings grouped by their Method
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LifecycleSettingCountByMethod>> GetCountsByMethodAsync(this ILifecycle operations, string client, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCountsByMethodWithHttpMessagesAsync(client, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a collection of lifecycle settings by space separated Guids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='terms'>
            /// Space separated Guids of entity ids or Property=Value. Valid operators are
            /// '=', '!=', '&amp;gt;', '&amp;lt;', '&amp;gt;=', '&amp;lt;='. Dates should
            /// be supplied as seconds since Unix epoch.
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
            public static IList<LifecycleSetting> QueryLifecycleSetting(this ILifecycle operations, string client, string terms, int? count = default(int?), string orderBy = default(string), string orderByDesc = default(string))
            {
                return operations.QueryLifecycleSettingAsync(client, terms, count, orderBy, orderByDesc).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a collection of lifecycle settings by space separated Guids
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='terms'>
            /// Space separated Guids of entity ids or Property=Value. Valid operators are
            /// '=', '!=', '&amp;gt;', '&amp;lt;', '&amp;gt;=', '&amp;lt;='. Dates should
            /// be supplied as seconds since Unix epoch.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LifecycleSetting>> QueryLifecycleSettingAsync(this ILifecycle operations, string client, string terms, int? count = default(int?), string orderBy = default(string), string orderByDesc = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryLifecycleSettingWithHttpMessagesAsync(client, terms, count, orderBy, orderByDesc, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
