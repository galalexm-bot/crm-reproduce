// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.MacroAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Allows specifying a macro for a parameter of a <see cref="T:EleWise.ELMA.ComponentModel.SourceTemplateAttribute">source template</see>.
  /// </summary>
  /// <remarks>
  /// You can apply the attribute on the whole method or on any of its additional parameters. The macro expression
  /// is defined in the <see cref="P:EleWise.ELMA.ComponentModel.MacroAttribute.Expression" /> property. When applied on a method, the target
  /// template parameter is defined in the <see cref="P:EleWise.ELMA.ComponentModel.MacroAttribute.Target" /> property. To apply the macro silently
  /// for the parameter, set the <see cref="P:EleWise.ELMA.ComponentModel.MacroAttribute.Editable" /> property value = -1.
  /// </remarks>
  /// <example>
  /// Applying the attribute on a source template method:
  /// <code>
  /// [SourceTemplate, Macro(Target = "item", Expression = "suggestVariableName()")]
  /// public static void forEach&lt;T&gt;(this IEnumerable&lt;T&gt; collection) {
  ///   foreach (var item in collection) {
  ///     //$ $END$
  ///   }
  /// }
  /// </code>
  /// Applying the attribute on a template method parameter:
  /// <code>
  /// [SourceTemplate]
  /// public static void something(this Entity x, [Macro(Expression = "guid()", Editable = -1)] string newguid) {
  ///   /*$ var $x$Id = "$newguid$" + x.ToString();
  ///   x.DoSomething($x$Id); */
  /// }
  /// </code>
  /// </example>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
  public sealed class MacroAttribute : Attribute
  {
    internal static MacroAttribute Eqpnj4fQGkZKNcg8eFSW;

    /// <summary>
    /// Allows specifying a macro that will be executed for a <see cref="T:EleWise.ELMA.ComponentModel.SourceTemplateAttribute">source template</see>
    /// parameter when the template is expanded.
    /// </summary>
    public string Expression
    {
      get => this.\u003CExpression\u003Ek__BackingField;
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
              this.\u003CExpression\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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

    /// <summary>
    /// Allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
    /// </summary>
    /// <remarks>
    /// If the target parameter is used several times in the template, only one occurrence becomes editable;
    /// other occurrences are changed synchronously. To specify the zero-based index of the editable occurrence,
    /// use values &gt;= 0. To make the parameter non-editable when the template is expanded, use -1.
    /// </remarks>
    /// &gt;
    public int Editable
    {
      get => this.\u003CEditable\u003Ek__BackingField;
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
              this.\u003CEditable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    /// <summary>
    /// Identifies the target parameter of a <see cref="T:EleWise.ELMA.ComponentModel.SourceTemplateAttribute">source template</see> if the
    /// <see cref="T:EleWise.ELMA.ComponentModel.MacroAttribute" /> is applied on a template method.
    /// </summary>
    public string Target
    {
      get => this.\u003CTarget\u003Ek__BackingField;
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
              this.\u003CTarget\u003Ek__BackingField = value;
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

    public MacroAttribute()
    {
      MacroAttribute.kU8wdsfQQJFQ8vtg4x5y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Wucxb7fQEw9BBkmbxegW() => MacroAttribute.Eqpnj4fQGkZKNcg8eFSW == null;

    internal static MacroAttribute suTSkOfQfR4xsyuyY6SL() => MacroAttribute.Eqpnj4fQGkZKNcg8eFSW;

    internal static void kU8wdsfQQJFQ8vtg4x5y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
