// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.LocalizationRequiredAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that marked element should be localized or not.
  /// </summary>
  /// <example><code>
  /// [LocalizationRequiredAttribute(true)]
  /// public class Foo {
  ///   private string str = "my string"; // Warning: Localizable string
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.All)]
  public sealed class LocalizationRequiredAttribute : Attribute
  {
    internal static LocalizationRequiredAttribute RRCg0yffkVcChuttcLNF;

    public LocalizationRequiredAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(true);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public LocalizationRequiredAttribute(bool required)
    {
      LocalizationRequiredAttribute.MdvSLwff2pwj9OKCpQIc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Required = required;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public bool Required
    {
      get => this.\u003CRequired\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    internal static bool ltiTdpffnAB8KFF7cHT3() => LocalizationRequiredAttribute.RRCg0yffkVcChuttcLNF == null;

    internal static LocalizationRequiredAttribute jqAtOjffOaUkhrpZFbLD() => LocalizationRequiredAttribute.RRCg0yffkVcChuttcLNF;

    internal static void MdvSLwff2pwj9OKCpQIc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
