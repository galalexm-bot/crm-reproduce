// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IInheritable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Интерфейс типа сущности, у которого могут быть наследники
  /// </summary>
  public interface IInheritable
  {
    /// <summary>Uid типа сущности</summary>
    Guid TypeUid { get; set; }
  }
}
