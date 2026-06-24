// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.SourceTemplateAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// An extension method marked with this attribute is processed by ReSharper code completion
  /// as a 'Source Template'. When extension method is completed over some expression, it's source code
  /// is automatically expanded like a template at call site.
  /// </summary>
  /// <remarks>
  /// Template method body can contain valid source code and/or special comments starting with '$'.
  /// Text inside these comments is added as source code when the template is applied. Template parameters
  /// can be used either as additional method parameters or as identifiers wrapped in two '$' signs.
  /// Use the <see cref="T:EleWise.ELMA.ComponentModel.MacroAttribute" /> attribute to specify macros for parameters.
  /// </remarks>
  /// <example>
  /// In this example, the 'forEach' method is a source template available over all values
  /// of enumerable types, producing ordinary C# 'foreach' statement and placing caret inside block:
  /// <code>
  /// [SourceTemplate]
  /// public static void forEach&lt;T&gt;(this IEnumerable&lt;T&gt; xs) {
  ///   foreach (var x in xs) {
  ///      //$ $END$
  ///   }
  /// }
  /// </code>
  /// </example>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class SourceTemplateAttribute : Attribute
  {
    private static SourceTemplateAttribute pPRfJWfQWMN5uu6B4LUh;

    public SourceTemplateAttribute()
    {
      SourceTemplateAttribute.UftY02fQh1tFRfC2Ww83();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void UftY02fQh1tFRfC2Ww83() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool drETXvfQoLBLO4NfFpgi() => SourceTemplateAttribute.pPRfJWfQWMN5uu6B4LUh == null;

    internal static SourceTemplateAttribute BStKjhfQb6Gu388LM4Pi() => SourceTemplateAttribute.pPRfJWfQWMN5uu6B4LUh;
  }
}
