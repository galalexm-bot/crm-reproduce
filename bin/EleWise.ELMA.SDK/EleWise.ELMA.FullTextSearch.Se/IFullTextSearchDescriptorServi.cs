using System.Collections.Generic;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FullTextSearch.Services;

public interface IFullTextSearchDescriptorService
{
	bool IsSupportedIndexing(IPropertyMetadata propertyMd);

	bool IsSupportedSearchInIndex(IPropertyMetadata propertyMd);

	bool IsSupportedFullTextSearchInIndex(IPropertyMetadata propertyMd);

	FieldIndexList GetIndexField(object value, IPropertyMetadata propMd, bool reindex);

	FieldListItem GetSearchField(object value, IPropertyMetadata propMd);

	FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter);

	List<string> GetReturnField(IPropertyMetadata propMd);

	SortListItem GetSortField(IPropertyMetadata propMd);

	void SetIndexField(object obj, object value, IPropertyMetadata propMd);

	void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName);
}
