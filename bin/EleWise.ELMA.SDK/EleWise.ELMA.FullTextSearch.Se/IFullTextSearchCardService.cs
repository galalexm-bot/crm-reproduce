using System;
using System.Collections.Generic;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.FullTextSearch.Services;

public interface IFullTextSearchCardService
{
	List<IEntity> ReconstructEntities(Type cardType, FullTextSearchResultModel resultModel);

	List<long> GetIdArray(List<FullTextSearchResultItem> resultItems);

	IModuleFullTextSearchExtension GetExtensionByFilter(IEntityFilter filter);

	Type GetCardTypeByFilter(IEntityFilter filter);

	IModuleFullTextSearchExtension GetExtensionByObjectTypeUid(Guid typeUid);

	IModuleFullTextSearchExtension GetExtensionByObjectType(Type type);

	Type GetCardTypeByObjectTypeUid(Guid typeUid);

	Type GetCardTypeByObjectType(Type type);

	IModuleFullTextSearchExtension GetExtensionByCardType(Type cardType);

	Guid? GetCardUidByCardType(Type cardType);

	Type GetCardTypeByCardUid(Guid cardUid);
}
