// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.AutoImplementClassBaseAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает, что для интерфейса нужно автоматически строить реализацию, используя базовый класс
  /// </summary>
  [AttributeUsage(AttributeTargets.Interface)]
  public class AutoImplementClassBaseAttribute : Attribute
  {
    private readonly Type _baseAutoImplementType;
    private static AutoImplementClassBaseAttribute g3x8FSoC8jnfdr5BnmMV;

    /// <summary>Ctor</summary>
    /// <param name="baseAutoImplementType">Базовый класс</param>
    public AutoImplementClassBaseAttribute(Type baseAutoImplementType)
    {
      AutoImplementClassBaseAttribute.SADrRboCIlcYbiYL9hop();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._baseAutoImplementType = baseAutoImplementType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Базовый класс</summary>
    public Type BaseAutoImplementType => this._baseAutoImplementType;

    internal static void SADrRboCIlcYbiYL9hop() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool l3QbWToCZbQgsCHtxpe9() => AutoImplementClassBaseAttribute.g3x8FSoC8jnfdr5BnmMV == null;

    internal static AutoImplementClassBaseAttribute mFO1Y9oCuhXTfnXkh0Ul() => AutoImplementClassBaseAttribute.g3x8FSoC8jnfdr5BnmMV;
  }
}
