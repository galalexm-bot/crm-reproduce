// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.ISkipFilterEmptyProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>
  /// Возможность не учитывать некоторые свойства при определении пустоты фильтра
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ISkipFilterEmptyProperty
  {
    /// <summary>Проверка</summary>
    /// <param name="metadata"></param>
    /// <param name="filterMetadata"></param>
    /// <returns></returns>
    bool TryProperty(PropertyMetadata metadata, ClassMetadata filterMetadata);
  }
}
