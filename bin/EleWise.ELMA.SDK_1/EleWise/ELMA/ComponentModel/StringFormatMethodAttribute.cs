// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.StringFormatMethodAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the marked method builds string by format pattern and (optional) arguments.
  /// Parameter, which contains format string, should be given in constructor. The format string
  /// should be in <see cref="M:System.String.Format(System.IFormatProvider,System.String,System.Object[])" />-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// public void ShowError(string message, params object[] args) { /* do something */ }
  /// public void Foo() {
  ///   ShowError("Failed: {0}"); // Warning: Non-existing argument in format string
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
  public sealed class StringFormatMethodAttribute : Attribute
  {
    private static StringFormatMethodAttribute bf85oSffbLPyYCS6VGHW;

    /// <param name="formatParameterName">
    /// Specifies which parameter of an annotated method should be treated as format-string
    /// </param>
    public StringFormatMethodAttribute(string formatParameterName)
    {
      StringFormatMethodAttribute.p00Ak6ffEk5DKfGRFFLO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.FormatParameterName = formatParameterName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string FormatParameterName
    {
      get => this.\u003CFormatParameterName\u003Ek__BackingField;
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
              this.\u003CFormatParameterName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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

    internal static void p00Ak6ffEk5DKfGRFFLO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QWWif2ffh9tUtkVnQmdx() => StringFormatMethodAttribute.bf85oSffbLPyYCS6VGHW == null;

    internal static StringFormatMethodAttribute eo9ZfqffG3AJ9ta5HUu7() => StringFormatMethodAttribute.bf85oSffbLPyYCS6VGHW;
  }
}
