// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.NHManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Базовый класс менеджера NHibernate</summary>
  public abstract class NHManager : NHManagerBase, INHManager
  {
    private static NHManager r2O5x1W9iaGPQ1tJLYcY;

    void INHManager.Init() => NHManager.kEF46uW9K6FyK1wj0uY7((object) this);

    /// <summary>Внутренняя инициализация менеджера</summary>
    protected virtual void InitInternal()
    {
    }

    protected NHManager()
    {
      NHManager.mywQQ0W9XY7PEEUupt0M();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void kEF46uW9K6FyK1wj0uY7([In] object obj0) => ((NHManager) obj0).InitInternal();

    internal static void mywQQ0W9XY7PEEUupt0M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Yhpl9xW9RuU3pOGErKp9() => NHManager.r2O5x1W9iaGPQ1tJLYcY == null;

    internal static NHManager W0V5RPW9qS4FhGFcp6hE() => NHManager.r2O5x1W9iaGPQ1tJLYcY;
  }
}
