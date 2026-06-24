using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFullTextSearchProvider
{
	Guid ProviderUid { get; }

	string ProviderName { get; }

	bool CheckServerStatus(ICollection<string> checkSettings, out string info);

	bool GetServerStatus();

	FullTextSearchResultModel Search(Type cardType, string searchString, List<string> listForHighlight, FilterList listForFilter, List<string> listForFields, List<string> listForSearchFields, int? from = null, int? size = null);

	FullTextSearchResultModel Find(Type cardType, FastSearchList listFastSearch, FieldList listSearchFields, FilterList listFilterField, List<string> listReturnFields, SortList sortFields, int? from, int? size);

	FullTextSearchResultModel Find(Type cardType, List<string> listReturnFields, FilterList listFilterFields, SortList listSortFields, int size);

	FullTextSearchResultModel Count(Type cardType, FastSearchList listFastSearch, FieldList listSearchFields, FilterList listFilterField);

	bool Index(Type type, IEnumerable<IFullTextSearchObjectContainer> objects);

	bool ReIndex(Type cardType, List<ToReindex> listToReIndex);

	bool DeleteAllFromType(Type cardType);

	bool DeleteIndex();
}
