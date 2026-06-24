using System;
using System.Collections.Generic;

namespace Orchard.Indexing;

public interface ISearchBuilder
{
	ISearchBuilder Parse(string defaultField, string query, bool escape = true);

	ISearchBuilder Parse(string[] defaultFields, string query, bool escape = true);

	ISearchBuilder WithField(string field, bool value);

	ISearchBuilder WithField(string field, DateTime value);

	ISearchBuilder WithField(string field, string value);

	ISearchBuilder WithField(string field, int value);

	ISearchBuilder WithField(string field, double value);

	ISearchBuilder WithinRange(string field, int? min, int? max, bool includeMin = true, bool includeMax = true);

	ISearchBuilder WithinRange(string field, double? min, double? max, bool includeMin = true, bool includeMax = true);

	ISearchBuilder WithinRange(string field, DateTime? min, DateTime? max, bool includeMin = true, bool includeMax = true);

	ISearchBuilder WithinRange(string field, string min, string max, bool includeMin = true, bool includeMax = true);

	ISearchBuilder Mandatory();

	ISearchBuilder Forbidden();

	ISearchBuilder NotAnalyzed();

	ISearchBuilder ExactMatch();

	ISearchBuilder Weighted(float weight);

	ISearchBuilder AsFilter();

	ISearchBuilder SortBy(string name);

	ISearchBuilder SortByInteger(string name);

	ISearchBuilder SortByBoolean(string name);

	ISearchBuilder SortByString(string name);

	ISearchBuilder SortByDouble(string name);

	ISearchBuilder SortByDateTime(string name);

	ISearchBuilder Ascending();

	ISearchBuilder Slice(int skip, int count);

	IEnumerable<ISearchHit> Search();

	ISearchHit Get(int documentId);

	ISearchBits GetBits();

	int Count();
}
