// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class SearchModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.QueryAnswerResult"/>. </summary>
        /// <param name="score"> The score value represents how relevant the answer is to the query relative to other answers returned for the query. </param>
        /// <param name="key"> The key of the document the answer was extracted from. </param>
        /// <param name="text"> The text passage extracted from the document contents as the answer. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted text phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.QueryAnswerResult"/> instance for mocking. </returns>
        public static QueryAnswerResult QueryAnswerResult(double? score = null, string key = null, string text = null, string highlights = null, IReadOnlyDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new QueryAnswerResult(score, key, text, highlights, additionalProperties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QueryCaptionResult"/>. </summary>
        /// <param name="text"> A representative text passage extracted from the document most relevant to the search query. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.QueryCaptionResult"/> instance for mocking. </returns>
        public static QueryCaptionResult QueryCaptionResult(string text = null, string highlights = null, IReadOnlyDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new QueryCaptionResult(text, highlights, additionalProperties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AutocompleteResults"/>. </summary>
        /// <param name="coverage"> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        /// <returns> A new <see cref="Models.AutocompleteResults"/> instance for mocking. </returns>
        public static AutocompleteResults AutocompleteResults(double? coverage = null, IEnumerable<AutocompleteItem> results = null)
        {
            results ??= new List<AutocompleteItem>();

            return new AutocompleteResults(coverage, results?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.SearchIndexerStatus"/>. </summary>
        /// <param name="status"> Overall indexer status. </param>
        /// <param name="lastResult"> The result of the most recent or an in-progress indexer execution. </param>
        /// <param name="executionHistory"> History of the recent indexer executions, sorted in reverse chronological order. </param>
        /// <param name="limits"> The execution limits for the indexer. </param>
        /// <returns> A new <see cref="Indexes.Models.SearchIndexerStatus"/> instance for mocking. </returns>
        public static SearchIndexerStatus SearchIndexerStatus(IndexerStatus status = default, IndexerExecutionResult lastResult = null, IEnumerable<IndexerExecutionResult> executionHistory = null, SearchIndexerLimits limits = null)
        {
            executionHistory ??= new List<IndexerExecutionResult>();

            return new SearchIndexerStatus(status, lastResult, executionHistory?.ToList(), limits);
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.SearchIndexStatistics"/>. </summary>
        /// <param name="documentCount"> The number of documents in the index. </param>
        /// <param name="storageSize"> The amount of storage in bytes consumed by the index. </param>
        /// <param name="vectorIndexSize"> The amount of memory in bytes consumed by vectors in the index. </param>
        /// <returns> A new <see cref="Indexes.Models.SearchIndexStatistics"/> instance for mocking. </returns>
        public static SearchIndexStatistics SearchIndexStatistics(long documentCount = default, long storageSize = default, long vectorIndexSize = default)
        {
            return new SearchIndexStatistics(documentCount, storageSize, vectorIndexSize);
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.SearchServiceCounters"/>. </summary>
        /// <param name="documentCounter"> Total number of documents across all indexes in the service. </param>
        /// <param name="indexCounter"> Total number of indexes. </param>
        /// <param name="indexerCounter"> Total number of indexers. </param>
        /// <param name="dataSourceCounter"> Total number of data sources. </param>
        /// <param name="storageSizeCounter"> Total size of used storage in bytes. </param>
        /// <param name="synonymMapCounter"> Total number of synonym maps. </param>
        /// <param name="skillsetCounter"> Total number of skillsets. </param>
        /// <param name="vectorIndexSizeCounter"> Total memory consumption of all vector indexes within the service, in bytes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documentCounter"/>, <paramref name="indexCounter"/>, <paramref name="indexerCounter"/>, <paramref name="dataSourceCounter"/>, <paramref name="storageSizeCounter"/>, <paramref name="synonymMapCounter"/>, <paramref name="skillsetCounter"/> or <paramref name="vectorIndexSizeCounter"/> is null. </exception>
        /// <returns> A new <see cref="Indexes.Models.SearchServiceCounters"/> instance for mocking. </returns>
        public static SearchServiceCounters SearchServiceCounters(SearchResourceCounter documentCounter = null, SearchResourceCounter indexCounter = null, SearchResourceCounter indexerCounter = null, SearchResourceCounter dataSourceCounter = null, SearchResourceCounter storageSizeCounter = null, SearchResourceCounter synonymMapCounter = null, SearchResourceCounter skillsetCounter = null, SearchResourceCounter vectorIndexSizeCounter = null)
        {
            if (documentCounter == null)
            {
                throw new ArgumentNullException(nameof(documentCounter));
            }
            if (indexCounter == null)
            {
                throw new ArgumentNullException(nameof(indexCounter));
            }
            if (indexerCounter == null)
            {
                throw new ArgumentNullException(nameof(indexerCounter));
            }
            if (dataSourceCounter == null)
            {
                throw new ArgumentNullException(nameof(dataSourceCounter));
            }
            if (storageSizeCounter == null)
            {
                throw new ArgumentNullException(nameof(storageSizeCounter));
            }
            if (synonymMapCounter == null)
            {
                throw new ArgumentNullException(nameof(synonymMapCounter));
            }
            if (skillsetCounter == null)
            {
                throw new ArgumentNullException(nameof(skillsetCounter));
            }
            if (vectorIndexSizeCounter == null)
            {
                throw new ArgumentNullException(nameof(vectorIndexSizeCounter));
            }

            return new SearchServiceCounters(
                documentCounter,
                indexCounter,
                indexerCounter,
                dataSourceCounter,
                storageSizeCounter,
                synonymMapCounter,
                skillsetCounter,
                vectorIndexSizeCounter);
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.SearchServiceLimits"/>. </summary>
        /// <param name="maxFieldsPerIndex"> The maximum allowed fields per index. </param>
        /// <param name="maxFieldNestingDepthPerIndex"> The maximum depth which you can nest sub-fields in an index, including the top-level complex field. For example, a/b/c has a nesting depth of 3. </param>
        /// <param name="maxComplexCollectionFieldsPerIndex"> The maximum number of fields of type Collection(Edm.ComplexType) allowed in an index. </param>
        /// <param name="maxComplexObjectsInCollectionsPerDocument"> The maximum number of objects in complex collections allowed per document. </param>
        /// <param name="maxStoragePerIndexInBytes"> The maximum amount of storage in bytes allowed per index. </param>
        /// <returns> A new <see cref="Indexes.Models.SearchServiceLimits"/> instance for mocking. </returns>
        public static SearchServiceLimits SearchServiceLimits(int? maxFieldsPerIndex = null, int? maxFieldNestingDepthPerIndex = null, int? maxComplexCollectionFieldsPerIndex = null, int? maxComplexObjectsInCollectionsPerDocument = null, long? maxStoragePerIndexInBytes = null)
        {
            return new SearchServiceLimits(maxFieldsPerIndex, maxFieldNestingDepthPerIndex, maxComplexCollectionFieldsPerIndex, maxComplexObjectsInCollectionsPerDocument, maxStoragePerIndexInBytes);
        }
    }
}
