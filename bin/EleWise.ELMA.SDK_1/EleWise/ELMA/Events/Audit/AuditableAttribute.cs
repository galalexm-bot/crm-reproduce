// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.AuditableAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Атрибут указывает, что метод должен перехватываться системой аудита и обрабатываться с помощью <see cref="T:EleWise.ELMA.Events.Audit.IAuditableEventHandler" />
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public class AuditableAttribute : Attribute
  {
    private static AuditableAttribute o9NIX1Gs1DSXw8ejnw0B;

    /// <summary>Ctor</summary>
    public AuditableAttribute()
    {
      AuditableAttribute.VsWC5oGsp5PLtV507esu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Preprocess = true;
            num = 2;
            continue;
          case 2:
            this.Postprocess = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Делать ли предобработку (по умолчанию True)</summary>
    public bool Preprocess
    {
      get => this.\u003CPreprocess\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPreprocess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Делать ли постобработку (по умолчанию True)</summary>
    public bool Postprocess
    {
      get => this.\u003CPostprocess\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPostprocess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void VsWC5oGsp5PLtV507esu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jmqmjZGsNvmSSUsF8MvP() => AuditableAttribute.o9NIX1Gs1DSXw8ejnw0B == null;

    internal static AuditableAttribute NB7uKpGs32y17CgFmmTV() => AuditableAttribute.o9NIX1Gs1DSXw8ejnw0B;
  }
}
