// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.EmptyArray`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Пустой массив</summary>
  /// <typeparam name="T">тип элемента ммасива</typeparam>
  public class EmptyArray<T>
  {
    /// <summary>Экземпляр пустого массива</summary>
    public static readonly T[] Instance;
    internal static object YycwYghzqJCPNDxBAuoJ;

    public EmptyArray()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EmptyArray()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EmptyArray<T>.Instance = new T[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool oetQO3hzK0ky03yGpCxc() => EmptyArray<T>.YycwYghzqJCPNDxBAuoJ == null;

    internal static object qbuNbxhzXdnVfOgs9PGu() => EmptyArray<T>.YycwYghzqJCPNDxBAuoJ;
  }
}
