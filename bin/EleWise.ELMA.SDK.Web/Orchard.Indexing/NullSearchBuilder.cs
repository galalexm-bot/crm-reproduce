using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Indexing;

public class NullSearchBuilder : ISearchBuilder
{
	public ISearchBuilder Parse(string defaultField, string query, bool escape)
	{
		return this;
	}

	public ISearchBuilder Parse(string[] defaultFields, string query, bool escape)
	{
		return this;
	}

	public ISearchBuilder WithField(string field, bool value)
	{
		return this;
	}

	public ISearchBuilder WithField(string field, DateTime value)
	{
		return this;
	}

	public ISearchBuilder WithField(string field, string value)
	{
		return this;
	}

	public ISearchBuilder WithField(string field, int value)
	{
		return this;
	}

	public ISearchBuilder WithField(string field, double value)
	{
		return this;
	}

	public ISearchBuilder WithinRange(string field, int? min, int? max, bool includeMin = true, bool includeMax = true)
	{
		return this;
	}

	public ISearchBuilder WithinRange(string field, double? min, double? max, bool includeMin = true, bool includeMax = true)
	{
		return this;
	}

	public ISearchBuilder WithinRange(string field, DateTime? min, DateTime? max, bool includeMin = true, bool includeMax = true)
	{
		return this;
	}

	public ISearchBuilder WithinRange(string field, string min, string max, bool includeMin = true, bool includeMax = true)
	{
		return this;
	}

	public ISearchBuilder Mandatory()
	{
		return this;
	}

	public ISearchBuilder Forbidden()
	{
		return this;
	}

	public ISearchBuilder ExactMatch()
	{
		return this;
	}

	public ISearchBuilder NotAnalyzed()
	{
		return this;
	}

	public ISearchBuilder Weighted(float weight)
	{
		return this;
	}

	public ISearchBuilder AsFilter()
	{
		return this;
	}

	public ISearchBuilder SortBy(string name)
	{
		return this;
	}

	public ISearchBuilder SortByInteger(string name)
	{
		return this;
	}

	public ISearchBuilder SortByBoolean(string name)
	{
		return this;
	}

	public ISearchBuilder SortByString(string name)
	{
		return this;
	}

	public ISearchBuilder SortByDouble(string name)
	{
		return this;
	}

	public ISearchBuilder SortByDateTime(string name)
	{
		return this;
	}

	public ISearchBuilder Ascending()
	{
		return this;
	}

	public ISearchBuilder Slice(int skip, int count)
	{
		return this;
	}

	public IEnumerable<ISearchHit> Search()
	{
		return Enumerable.Empty<ISearchHit>();
	}

	public ISearchHit Get(int documentId)
	{
		return null;
	}

	public ISearchBits GetBits()
	{
		throw new NotImplementedException();
	}

	public int Count()
	{
		return 0;
	}
}
