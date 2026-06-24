// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.IEntityExportValuesEdit
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  [ExtensionPoint(ComponentType.All)]
  public interface IEntityExportValuesEdit
  {
    /// <summary>Guid типа сущности</summary>
    Guid TypeUid { get; }

    /// <summary>
    /// Выполнить модификацию значений свойств сущности в перед записью при экспорте
    /// </summary>
    /// <param name="values">Значения свойств</param>
    void EditValues(Dictionary<string, object> values);
  }
}
