// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TablePartAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает тип с блоком, который принадлежит данному классу
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class TablePartAttribute : Attribute
  {
    private Type tablePartType;
    private static TablePartAttribute UTd7DXoZkCJG9Z5rsYLl;

    /// <summary>Ctor</summary>
    /// <param name="tablePartType">Тип блока</param>
    public TablePartAttribute(Type tablePartType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.tablePartType = tablePartType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип блока</summary>
    public Type TablePartType => this.tablePartType;

    internal static bool p2DBxSoZnjdTdcNaDqxF() => TablePartAttribute.UTd7DXoZkCJG9Z5rsYLl == null;

    internal static TablePartAttribute JY2XkBoZOJVjtLyvwECS() => TablePartAttribute.UTd7DXoZkCJG9Z5rsYLl;
  }
}
