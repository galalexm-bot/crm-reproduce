// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.IGenericIdentity`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Common
{
  /// <summary>
  /// Объект с идентификатором типа <typeparamref name="T" />
  /// </summary>
  /// <typeparam name="T">Тип идентификатора</typeparam>
  public interface IGenericIdentity<T>
  {
    /// <summary>Идентификатор</summary>
    T Id { get; }
  }
}
