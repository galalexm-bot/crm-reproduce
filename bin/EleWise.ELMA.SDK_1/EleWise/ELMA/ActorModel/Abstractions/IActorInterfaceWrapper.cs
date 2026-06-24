// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.IActorInterfaceWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>Интерфейс Wrapper-а для прокси-интерфейса актора</summary>
  public interface IActorInterfaceWrapper
  {
    /// <summary>Актор</summary>
    IActor Actor { get; }
  }
}
