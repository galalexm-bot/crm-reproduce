// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.IFullTextSearchCardService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>
  /// Интерфейс сервиса работы с карточками полнотекстового поиска
  /// </summary>
  public interface IFullTextSearchCardService
  {
    /// <summary>Восстановление в фейковый объект по данным из индекса</summary>
    List<IEntity> ReconstructEntities(Type cardType, FullTextSearchResultModel resultModel);

    /// <summary>Полдучение списоков id по данным из индекса</summary>
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
}
