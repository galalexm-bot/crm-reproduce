// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.IInternalMapperService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using System;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal
{
  /// <summary>Внутренний сервис маппинга</summary>
  internal interface IInternalMapperService
  {
    /// <summary>Получить конфигурацию маппера по типу</summary>
    /// <param name="declaredSourceType">Тип</param>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>Конфигурация маппера</returns>
    IInternalMapperConfiguration GetMapper(Type declaredSourceType, Guid metadataUid);

    /// <summary>
    /// Получить конфигурацию маппера по уникальному идентфикатору метаданных
    /// </summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>Конфигурация маппера</returns>
    IInternalMapperConfiguration GetMapper(Guid metadataUid);

    /// <summary>Получить конфигурацию маппера</summary>
    /// <param name="dataClass">Структура обмена данными</param>
    /// <param name="declaredSourceType">Объявленный конечный тип</param>
    /// <returns>Конфигурация маппера</returns>
    IInternalMapperConfiguration GetMapper(DataClass dataClass, Type declaredSourceType);
  }
}
