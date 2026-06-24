using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IModuleFullTextSearchExtension
{
	IGlobalSettingsModule SettingModule { get; }

	List<KeyValuePair<Type, Guid>> GetSupportedCardTypes(bool checkSettings = true);

	Type GetSupportedCardType(Guid cardUid);

	Guid? GetSupportedCardType(Type cardType);

	Type GetSupportedCardTypeByTypeUid(Guid objectTypeUid);

	Type GetSupportedCardTypeByObject(object obj);

	Dictionary<Type, Dictionary<Guid, List<string>>> GetDynamicFieldsMapping();

	List<string> GetHighlightFields(Type cardType);

	List<string> GetFields(Type cardType);

	List<string> GetSearchFields(Type cardType);

	List<string> GetSearchFields(Type cardType, IEntityFilter filter);

	Dictionary<string, Weight> GetWeightSearchFields(Type cardType);

	Dictionary<string, string> GetReverseMapping(Type cardType);

	Dictionary<string, long> GetHighlightsOrder(Type cardType);

	FilterList GetFilterFields(Type cardType, FullTextSearchResultModel searchModel);

	FieldList GetCustomSearchFields(Type cardType, FilterProperty filterProperty);

	FilterList GetCustomFilterFields(Type cardType, FilterProperty filterProperty, FullTextSearchResultModel searchModel);

	FilterList GetAutoFilterFields(Type cardType, FilterProperty filterProperty, FullTextSearchResultModel searchModel);

	void FillObject(Type cardType, IFullTextSearchObjectContainer obj, IEntity entity);

	List<IEntity> GetEntities(Type cardType, List<Guid> listUid);

	List<IEntity> GetEntities(Type cardType, List<long> listId);

	List<IEntity> LoadEntitiesByPage(Type cardType, int page, List<Guid> typeUidFilter = null);

	List<IEntity> LoadEntities(Type cardType, long? lastId, List<Guid> typeUidFilter = null);

	FullTextSearchResultModel CreateResultModelByFilter(IEntityFilter filter);

	SortList GetDefaultSortExpression();

	List<KeyValuePair<string, object>> CreateFromObject(Type cardType, IFullTextSearchObjectContainer obj);

	void ReconstructEntity(Type cardType, IFullTextSearchResultItem resultItem, IEntity<long> fakeEntity);
}
