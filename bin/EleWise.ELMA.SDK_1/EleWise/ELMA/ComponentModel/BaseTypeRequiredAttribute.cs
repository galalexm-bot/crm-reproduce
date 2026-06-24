// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.BaseTypeRequiredAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// public class ComponentAttribute : Attribute { }
  /// [Component] // ComponentAttribute requires implementing IComponent interface
  /// public class MyComponent : IComponent { }
  /// </code></example>
  [BaseTypeRequired(typeof (Attribute))]
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public sealed class BaseTypeRequiredAttribute : Attribute
  {
    internal static BaseTypeRequiredAttribute YfGcZlff3F8W75KugYP9;

    public BaseTypeRequiredAttribute([NotNull] Type baseType)
    {
      BaseTypeRequiredAttribute.FmsDMcffDN28esGhm5yU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.BaseType = baseType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    [NotNull]
    public Type BaseType
    {
      get => this.\u003CBaseType\u003Ek__BackingField;
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
              this.\u003CBaseType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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

    internal static void FmsDMcffDN28esGhm5yU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool J2IgaiffpKG5n6gdxENV() => BaseTypeRequiredAttribute.YfGcZlff3F8W75KugYP9 == null;

    internal static BaseTypeRequiredAttribute vSH1wfffafJiFJNixdYg() => BaseTypeRequiredAttribute.YfGcZlff3F8W75KugYP9;
  }
}
