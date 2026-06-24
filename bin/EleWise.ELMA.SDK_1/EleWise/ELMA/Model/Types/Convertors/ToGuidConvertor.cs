// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToGuidConvertor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>
  /// Базовый класс преобразования из какого-либо типа в тип "Строка"
  /// </summary>
  public class ToGuidConvertor : TypeConvertor
  {
    internal static ToGuidConvertor mPjbEBojhWC1nvgYgvg2;

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> SourceTypeUids => new List<Guid>()
    {
      GuidDescriptor.UID,
      HtmlStringDescriptor.UID,
      TextDescriptor.UID,
      StringDescriptor.UID
    };

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> TargetTypeUids => new List<Guid>()
    {
      GuidDescriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 2;
      Guid? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (obj != null)
            {
              num1 = 3;
              continue;
            }
            goto label_4;
          case 2:
            nullable = new Guid?();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) nullable;
label_5:
      try
      {
        Guid result;
        int num2;
        if (!Guid.TryParse(obj.ToString(), out result))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
        else
          goto label_8;
label_7:
        switch (num2)
        {
          case 2:
            break;
          default:
            goto label_4;
        }
label_8:
        nullable = new Guid?(result);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        {
          num2 = 0;
          goto label_7;
        }
        else
          goto label_7;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_4;
        }
      }
    }

    public ToGuidConvertor()
    {
      ToGuidConvertor.EXJTCXojfJV0TibwrjIS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool hq58DFojGeqTYrkNmutD() => ToGuidConvertor.mPjbEBojhWC1nvgYgvg2 == null;

    internal static ToGuidConvertor dqE3jZojE1LqW4VxFgFN() => ToGuidConvertor.mPjbEBojhWC1nvgYgvg2;

    internal static void EXJTCXojfJV0TibwrjIS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
