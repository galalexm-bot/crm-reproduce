// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.ActorInterfaceWrapper`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>Базовый класс Wrapper-а для прокси-интерфейса актора</summary>
  /// <typeparam name="TActor">Тип актора</typeparam>
  public abstract class ActorInterfaceWrapper<TActor> : IActorInterfaceWrapper where TActor : IActor
  {
    /// <summary>Актор</summary>
    protected readonly TActor Actor;
    private static object aHOypkfDqBYKK4tEwBB6;

    /// <summary>Ctor</summary>
    /// <param name="actor">Актор</param>
    protected ActorInterfaceWrapper(TActor actor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Actor = actor;
    }

    /// <inheritdoc />
    IActor IActorInterfaceWrapper.Actor => (IActor) this.Actor;

    internal static bool c7ObSJfDKwmVemgkFGoD() => ActorInterfaceWrapper<TActor>.aHOypkfDqBYKK4tEwBB6 == null;

    internal static object unSYnEfDXoVaCaBA5lwa() => ActorInterfaceWrapper<TActor>.aHOypkfDqBYKK4tEwBB6;
  }
}
