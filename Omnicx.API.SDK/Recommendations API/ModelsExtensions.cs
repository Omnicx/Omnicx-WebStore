﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Omnicx.API.SDK.Recomendation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Models.
    /// </summary>
    public static partial class ModelsExtensions
    {
            /// <summary>
            /// Lists all the models
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Model> GetModels(this IModels operations)
            {
                return Task.Factory.StartNew(s => ((IModels)s).GetModelsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the models
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Model>> GetModelsAsync(this IModels operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetModelsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Trains a new model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelParameters'>
            /// The new model parameters
            /// </param>
            public static Model TrainNewModel(this IModels operations, ModelParameters modelParameters)
            {
                return Task.Factory.StartNew(s => ((IModels)s).TrainNewModelAsync(modelParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Trains a new model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelParameters'>
            /// The new model parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Model> TrainNewModelAsync(this IModels operations, ModelParameters modelParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TrainNewModelWithHttpMessagesAsync(modelParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a model by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to retrieve
            /// </param>
            public static Model GetModel(this IModels operations, Guid modelId)
            {
                return Task.Factory.StartNew(s => ((IModels)s).GetModelAsync(modelId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a model by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to retrieve
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Model> GetModelAsync(this IModels operations, Guid modelId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetModelWithHttpMessagesAsync(modelId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an existing model by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model to delete
            /// </param>
            public static void DeleteModel(this IModels operations, Guid modelId)
            {
                Task.Factory.StartNew(s => ((IModels)s).DeleteModelAsync(modelId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an existing model by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteModelAsync(this IModels operations, Guid modelId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteModelWithHttpMessagesAsync(modelId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Retrieve the default model.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Model GetDefaultModel(this IModels operations)
            {
                return Task.Factory.StartNew(s => ((IModels)s).GetDefaultModelAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the default model.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Model> GetDefaultModelAsync(this IModels operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDefaultModelWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets a model as the default model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to set as default
            /// </param>
            public static void SetDefaultModel(this IModels operations, Guid modelId)
            {
                Task.Factory.StartNew(s => ((IModels)s).SetDefaultModelAsync(modelId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets a model as the default model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to set as default
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetDefaultModelAsync(this IModels operations, Guid modelId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.SetDefaultModelWithHttpMessagesAsync(modelId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get recommendations using the default model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='itemId'>
            /// Item id to get recommendations for
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            public static IList<RecommendationResult> GetItemRecommendationsFromDefaultModel(this IModels operations, string itemId, int? recommendationCount = default(int?))
            {
                return Task.Factory.StartNew(s => ((IModels)s).GetItemRecommendationsFromDefaultModelAsync(itemId, recommendationCount), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recommendations using the default model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='itemId'>
            /// Item id to get recommendations for
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RecommendationResult>> GetItemRecommendationsFromDefaultModelAsync(this IModels operations, string itemId, int? recommendationCount = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetItemRecommendationsFromDefaultModelWithHttpMessagesAsync(itemId, recommendationCount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recommendations using the default model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='usageEvents'>
            /// The usage events to get recommendations for
            /// </param>
            /// <param name='userId'>
            /// An optional id of the user to provide recommendations for. Any stored
            /// usage events associated with this user will be considered when getting
            /// recommendations
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            public static IList<RecommendationResult> GetPersonalizedRecommendationsFromDefaultModel(this IModels operations, IList<UsageEvent> usageEvents, string userId = default(string), int? recommendationCount = default(int?))
            {
                return Task.Factory.StartNew(s => ((IModels)s).GetPersonalizedRecommendationsFromDefaultModelAsync(usageEvents, userId, recommendationCount), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recommendations using the default model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='usageEvents'>
            /// The usage events to get recommendations for
            /// </param>
            /// <param name='userId'>
            /// An optional id of the user to provide recommendations for. Any stored
            /// usage events associated with this user will be considered when getting
            /// recommendations
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RecommendationResult>> GetPersonalizedRecommendationsFromDefaultModelAsync(this IModels operations, IList<UsageEvent> usageEvents, string userId = default(string), int? recommendationCount = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPersonalizedRecommendationsFromDefaultModelWithHttpMessagesAsync(usageEvents, userId, recommendationCount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recommendations using the requested model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to use when scoring
            /// </param>
            /// <param name='itemId'>
            /// Item id to get recommendations for
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            public static IList<RecommendationResult> GetItemRecommendations(this IModels operations, Guid modelId, string itemId, int? recommendationCount = default(int?))
            {
                return Task.Factory.StartNew(s => ((IModels)s).GetItemRecommendationsAsync(modelId, itemId, recommendationCount), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recommendations using the requested model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to use when scoring
            /// </param>
            /// <param name='itemId'>
            /// Item id to get recommendations for
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RecommendationResult>> GetItemRecommendationsAsync(this IModels operations, Guid modelId, string itemId, int? recommendationCount = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetItemRecommendationsWithHttpMessagesAsync(modelId, itemId, recommendationCount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get recommendations using the requested model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to use when scoring
            /// </param>
            /// <param name='usageEvents'>
            /// The usage events to get recommendations for
            /// </param>
            /// <param name='userId'>
            /// An optional id of the user to provide recommendations for. Any stored
            /// usage events associated with this user will be considered when getting
            /// recommendations
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            public static IList<RecommendationResult> GetPersonalizedRecommendations(this IModels operations, Guid modelId, IList<UsageEvent> usageEvents, string userId = default(string), int? recommendationCount = default(int?))
            {
                return Task.Factory.StartNew(s => ((IModels)s).GetPersonalizedRecommendationsAsync(modelId, usageEvents, userId, recommendationCount), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get recommendations using the requested model
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='modelId'>
            /// The model id to use when scoring
            /// </param>
            /// <param name='usageEvents'>
            /// The usage events to get recommendations for
            /// </param>
            /// <param name='userId'>
            /// An optional id of the user to provide recommendations for. Any stored
            /// usage events associated with this user will be considered when getting
            /// recommendations
            /// </param>
            /// <param name='recommendationCount'>
            /// The number of requested recommendations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<RecommendationResult>> GetPersonalizedRecommendationsAsync(this IModels operations, Guid modelId, IList<UsageEvent> usageEvents, string userId = default(string), int? recommendationCount = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPersonalizedRecommendationsWithHttpMessagesAsync(modelId, usageEvents, userId, recommendationCount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
