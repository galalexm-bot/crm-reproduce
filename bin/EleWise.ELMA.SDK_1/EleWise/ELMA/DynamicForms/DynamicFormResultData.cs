// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DynamicForms.DynamicFormResultData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.DynamicForms
{
  /// <summary>
  /// Дополнительные данные для результата выполнения динамической формы
  /// </summary>
  public class DynamicFormResultData
  {
    private static DynamicFormResultData tWoFj1ORZK4N7X8Tcls;

    public DynamicFormResultData()
    {
      DynamicFormResultData.BPlZEEOX7CVXwAPsx4b();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Data = new Dictionary<string, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public Dictionary<string, object> Data { get; private set; }

    internal static void BPlZEEOX7CVXwAPsx4b() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ctbD6iOq9LbDvfh2qLc() => DynamicFormResultData.tWoFj1ORZK4N7X8Tcls == null;

    internal static DynamicFormResultData Kl7xDFOKWXtfLvhW4Fp() => DynamicFormResultData.tWoFj1ORZK4N7X8Tcls;
  }
}
