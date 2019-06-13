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
    /// Extension methods for Scenario.
    /// </summary>
    public static partial class ScenarioExtensions
    {
            /// <summary>
            /// Retrieve a single baseline scenario by Guid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            public static BaselineScenario GetScenario(this IScenario operations, string client, string baselineId, string scenarioId)
            {
                return operations.GetScenarioAsync(client, baselineId, scenarioId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a single baseline scenario by Guid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaselineScenario> GetScenarioAsync(this IScenario operations, string client, string baselineId, string scenarioId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetScenarioWithHttpMessagesAsync(client, baselineId, scenarioId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upserts a single baselineScenario
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            /// <param name='scenario'>
            /// The baselineScenario to insert/update. contained in the httppost body
            /// </param>
            public static string UpsertScenario(this IScenario operations, string client, string baselineId, string scenarioId, BaselineScenario scenario)
            {
                return operations.UpsertScenarioAsync(client, baselineId, scenarioId, scenario).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upserts a single baselineScenario
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            /// <param name='scenario'>
            /// The baselineScenario to insert/update. contained in the httppost body
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> UpsertScenarioAsync(this IScenario operations, string client, string baselineId, string scenarioId, BaselineScenario scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpsertScenarioWithHttpMessagesAsync(client, baselineId, scenarioId, scenario, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a collection of scenarios by a baselines Guid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The baseline Guid.
            /// </param>
            public static IList<BaselineScenarioDetails> GetScenarios(this IScenario operations, string client, string baselineId)
            {
                return operations.GetScenariosAsync(client, baselineId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a collection of scenarios by a baselines Guid
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The baseline Guid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<BaselineScenarioDetails>> GetScenariosAsync(this IScenario operations, string client, string baselineId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetScenariosWithHttpMessagesAsync(client, baselineId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retirves a Scenario Summary
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            /// <param name='locationId'>
            /// The unique Id for the position of location taxonomy
            /// </param>
            /// <param name='functionId'>
            /// The unique Id for the position of function taxonomy
            /// </param>
            public static BaselineScenarioSummary ScenarioSummary(this IScenario operations, string client, string baselineId, string scenarioId, System.Guid? locationId = default(System.Guid?), System.Guid? functionId = default(System.Guid?))
            {
                return operations.ScenarioSummaryAsync(client, baselineId, scenarioId, locationId, functionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retirves a Scenario Summary
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            /// <param name='locationId'>
            /// The unique Id for the position of location taxonomy
            /// </param>
            /// <param name='functionId'>
            /// The unique Id for the position of function taxonomy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaselineScenarioSummary> ScenarioSummaryAsync(this IScenario operations, string client, string baselineId, string scenarioId, System.Guid? locationId = default(System.Guid?), System.Guid? functionId = default(System.Guid?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ScenarioSummaryWithHttpMessagesAsync(client, baselineId, scenarioId, locationId, functionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Calculates a Scenario Summary Calculation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            /// <param name='deferrals'>
            /// The baselineScenarioDetails to use in the calculations. contained in the
            /// httppost body
            /// </param>
            /// <param name='locationId'>
            /// The unique Id for the position of location taxonomy
            /// </param>
            /// <param name='functionId'>
            /// The unique Id for the position of function taxonomy
            /// </param>
            public static BaselineScenarioSummary ScenarioSummaryPreview(this IScenario operations, string client, string baselineId, string scenarioId, IList<Deferral> deferrals, System.Guid? locationId = default(System.Guid?), System.Guid? functionId = default(System.Guid?))
            {
                return operations.ScenarioSummaryPreviewAsync(client, baselineId, scenarioId, deferrals, locationId, functionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Calculates a Scenario Summary Calculation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// The name of the client account.
            /// </param>
            /// <param name='baselineId'>
            /// The Id of the Baseline that the Scenario references
            /// </param>
            /// <param name='scenarioId'>
            /// The Id of the Scenario
            /// </param>
            /// <param name='deferrals'>
            /// The baselineScenarioDetails to use in the calculations. contained in the
            /// httppost body
            /// </param>
            /// <param name='locationId'>
            /// The unique Id for the position of location taxonomy
            /// </param>
            /// <param name='functionId'>
            /// The unique Id for the position of function taxonomy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaselineScenarioSummary> ScenarioSummaryPreviewAsync(this IScenario operations, string client, string baselineId, string scenarioId, IList<Deferral> deferrals, System.Guid? locationId = default(System.Guid?), System.Guid? functionId = default(System.Guid?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ScenarioSummaryPreviewWithHttpMessagesAsync(client, baselineId, scenarioId, deferrals, locationId, functionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves the interventions for a baseline scenario
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// </param>
            /// <param name='baselineId'>
            /// </param>
            /// <param name='scenarioId'>
            /// </param>
            /// <param name='locationId'>
            /// The unique Id for the position of location taxonomy
            /// </param>
            /// <param name='functionId'>
            /// The unique Id for the position of function taxonomy
            /// </param>
            public static BaselineInterventions ScenarioInterventions(this IScenario operations, string client, string baselineId, string scenarioId, System.Guid? locationId = default(System.Guid?), System.Guid? functionId = default(System.Guid?))
            {
                return operations.ScenarioInterventionsAsync(client, baselineId, scenarioId, locationId, functionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the interventions for a baseline scenario
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='client'>
            /// </param>
            /// <param name='baselineId'>
            /// </param>
            /// <param name='scenarioId'>
            /// </param>
            /// <param name='locationId'>
            /// The unique Id for the position of location taxonomy
            /// </param>
            /// <param name='functionId'>
            /// The unique Id for the position of function taxonomy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaselineInterventions> ScenarioInterventionsAsync(this IScenario operations, string client, string baselineId, string scenarioId, System.Guid? locationId = default(System.Guid?), System.Guid? functionId = default(System.Guid?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ScenarioInterventionsWithHttpMessagesAsync(client, baselineId, scenarioId, locationId, functionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
