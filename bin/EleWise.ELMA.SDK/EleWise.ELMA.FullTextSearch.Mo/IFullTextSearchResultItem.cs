using System.Collections.Generic;
using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.FullTextSearch.Model;

public interface IFullTextSearchResultItem
{
	Dictionary<string, List<string>> Highlights { get; set; }

	long HighlightsCount { get; }

	WebData ResultData { get; set; }

	IFullTextSearchObject ResultObject { get; set; }
}
