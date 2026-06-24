// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ScriptModuleAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает тип модуля сценариев для объекта</summary>
  public class ScriptModuleAttribute : Attribute
  {
    private string _typeName;
    internal static ScriptModuleAttribute LWypXtoCrpFAhxulfEEX;

    /// <summary>Ctor</summary>
    /// <param name="typeName">Полное имя типа со сборкой</param>
    public ScriptModuleAttribute(string typeName)
    {
      ScriptModuleAttribute.T3bBNOoCjJXvx9Kmqjrl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._typeName = typeName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Полное имя типа со сборкой</summary>
    public string TypeName => this._typeName;

    internal static void T3bBNOoCjJXvx9Kmqjrl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kUx4vEoCgJSjD93Esnxw() => ScriptModuleAttribute.LWypXtoCrpFAhxulfEEX == null;

    internal static ScriptModuleAttribute J0aqdnoC5Q7LstrrfVIC() => ScriptModuleAttribute.LWypXtoCrpFAhxulfEEX;
  }
}
