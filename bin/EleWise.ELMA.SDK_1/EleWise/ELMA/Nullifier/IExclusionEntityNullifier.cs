// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Nullifier.IExclusionEntityNullifier
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Nullifier
{
  /// <summary>
  /// Список исключений сущностей в участии очистки в обнуляторе. Вносятся системные сущности которые не должны показываться.
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IExclusionEntityNullifier
  {
    /// <summary>Вернуть список исключений</summary>
    /// <returns></returns>
    List<Guid> SetExclusion();
  }
}
