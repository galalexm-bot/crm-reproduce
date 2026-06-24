// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.IPublicMetadataProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>
  /// Провайдер, которые возвращает информацию о метаданных, доступных
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IPublicMetadataProvider
  {
    /// <summary>Получить список с информацией об объектах метаданных</summary>
    /// <returns></returns>
    IEnumerable<IPublicMetadataInfo> GetMetadataInfoList();

    /// <summary>Получить список групп</summary>
    /// <returns></returns>
    IEnumerable<IPublicMetadataGroupInfo> GetGroups();
  }
}
