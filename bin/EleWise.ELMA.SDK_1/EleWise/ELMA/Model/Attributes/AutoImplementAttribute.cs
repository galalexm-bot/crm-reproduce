// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.AutoImplementAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает, что для интерфейса нужно автоматически строить реализацию, используя базовый интерфейс
  /// </summary>
  [AttributeUsage(AttributeTargets.Interface)]
  public class AutoImplementAttribute : Attribute
  {
    private readonly Type _baseAutoImplementType;
    internal static AutoImplementAttribute Kx86WwovKvh25PLZyQLh;

    /// <summary>Ctor</summary>
    /// <param name="baseAutoImplementType">Базовый интерфейс</param>
    public AutoImplementAttribute(Type baseAutoImplementType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._baseAutoImplementType = baseAutoImplementType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Базовый интерфейс</summary>
    public Type BaseAutoImplementType => this._baseAutoImplementType;

    internal static bool J0FbgYovXqSbimd97grZ() => AutoImplementAttribute.Kx86WwovKvh25PLZyQLh == null;

    internal static AutoImplementAttribute FSWIWTovTyPw6SbxM8Q3() => AutoImplementAttribute.Kx86WwovKvh25PLZyQLh;
  }
}
