// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IStringKeyLinkedObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Информация об объекте со строковым идентификатором</summary>
  public interface IStringKeyLinkedObject : ILinkedObject
  {
    /// <summary>Уникальный строковый идентификатор объекта</summary>
    string UidStr { get; }
  }
}
