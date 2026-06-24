// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.FakeVariableServiceBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>
  /// Пустое хранилище данных на основе словаря ключ-значение
  /// </summary>
  public class FakeVariableServiceBase : IContextBoundVariableService, IAbstractBoundVariableService
  {
    private static FakeVariableServiceBase mbUt72BMghTuQiAcbv8e;

    /// <inheritdoc />
    public bool Contains(string name) => false;

    /// <inheritdoc />
    public T Get<T>(string name) => default (T);

    /// <inheritdoc />
    public bool TryGetValue<T>(string name, out T value)
    {
      value = default (T);
      return false;
    }

    /// <inheritdoc />
    public void Set(string name, object value)
    {
    }

    /// <inheritdoc />
    public void Remove(string key)
    {
    }

    public FakeVariableServiceBase()
    {
      FakeVariableServiceBase.UbY5b4BMYsGeE9gsGibG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void UbY5b4BMYsGeE9gsGibG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kF2uyGBM5AiHn1vOV6Yp() => FakeVariableServiceBase.mbUt72BMghTuQiAcbv8e == null;

    internal static FakeVariableServiceBase GpAe54BMjAd0umBihivH() => FakeVariableServiceBase.mbUt72BMghTuQiAcbv8e;
  }
}
