using System;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;

namespace EleWise.ELMA.FullTextSearch.Services;

public interface IFullTextSearchService
{
	IFullTextSearchProvider Provider { get; }

	FullTextSearchState GetIndexState();

	void SetOffIndexState();

	void SetReadyIndexState();

	void SetOnIndexState();

	bool IndexingIsWorking();

	FullTextSearchResultModel Search(Type cardType, string searchString, int? pageIndex = null, int? pageSize = null);

	FullTextSearchResultModel Search(Type cardType, FullTextSearchResultModel resultModel, string searchString, int? pageIndex = null, int? pageSize = null);

	bool IndexEntities(Type cardType, List<Guid> listUid);

	bool IndexEntities(Type cardType, List<long> listId);

	bool ReIndexAllEntities(IIndexQueue item, string dirtyValues, out bool breakBecauseIsIndexAll);

	bool ReIndexAllEntitiesByType(Type cardType, Guid? typeUidFilter = null);

	bool ReIndexByPropertyList(Type cardType, List<IEnumerable<KeyValuePair<string, object>>> listProperty);

	void StartIndexing();

	void StopIndexing();

	void StopIndexing(string info);

	void StartReIndexing();

	void StopIndexingType(Type cardType);

	string GetStopIndexingInfo();

	FullTextSearchResultModel Find(Type cardType, FullTextSearchResultModel resultModel, IEntityFilter filter, SerializableFilter filterFields, List<Guid> selectedColumns, int firstResult, int maxResult, string sortExpression, ListSortDirection sortDirection);

	FullTextSearchResultModel Find(Type cardType, List<string> listReturnFields, FilterList listFilterFields, SortList listSortFields, int firstResult, int maxResult);

	FullTextSearchResultModel Count(Type cardType, FullTextSearchResultModel resultModel, IEntityFilter filter, SerializableFilter filterFields);
}
