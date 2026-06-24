// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.IFullTextSearchDescriptorMappingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>
  /// Интерфейс сервиса работы с дескрипторами полнотекстового поиска с подддержкой маппинга полей
  /// </summary>
  public interface IFullTextSearchDescriptorMappingService : IFullTextSearchDescriptorService
  {
    /// <summary>Получение полей для настройки маппинга свойства</summary>
    /// <param name="propMd">Метаданные свойства</param>
    FieldIndexList GetMappingField(IPropertyMetadata propMd);
  }
}
