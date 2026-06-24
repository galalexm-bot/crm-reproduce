// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.IPlatformTypeDescriptorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Провайдер, возвращающий список типов для отображения в группе "Объекты платформы"
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IPlatformTypeDescriptorProvider
  {
    /// <summary>Получить список типов</summary>
    /// <returns></returns>
    IEnumerable<ITypeDescriptor> GetTypeDescriptors();
  }
}
