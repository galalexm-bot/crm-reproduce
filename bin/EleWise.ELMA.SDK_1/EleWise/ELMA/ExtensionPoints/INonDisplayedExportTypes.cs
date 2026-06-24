// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.INonDisplayedExportTypes
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Неотображаемые типы объектов при экспорте из дизайнера
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface INonDisplayedExportTypes
  {
    /// <summary>
    /// Получаем уиды типов, которые не нужно отображать при экспорте
    /// </summary>
    /// <returns></returns>
    List<Guid> GetNonDisplayedTypesUids();
  }
}
