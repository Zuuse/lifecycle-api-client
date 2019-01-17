// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Lifecycle.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Zuuse.
    /// </summary>
    public static partial class ZuuseExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string Heartbeat(this IZuuse operations)
            {
                return operations.HeartbeatAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> HeartbeatAsync(this IZuuse operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.HeartbeatWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
