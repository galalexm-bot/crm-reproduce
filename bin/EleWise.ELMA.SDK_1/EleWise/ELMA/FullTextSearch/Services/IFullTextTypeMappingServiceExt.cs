// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.IFullTextTypeMappingServiceExt
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>
  /// Расширение <see cref="T:EleWise.ELMA.FullTextSearch.Services.IFullTextTypeMappingService" />.
  /// </summary>
  internal interface IFullTextTypeMappingServiceExt : IFullTextTypeMappingService
  {
    /// <summary>Проверить доступность сервиса.</summary>
    /// <returns>Модель, описывающая доступность сервиса.</returns>
    IFullTextTypeMappingAvailability CheckAvailability();
  }
}
