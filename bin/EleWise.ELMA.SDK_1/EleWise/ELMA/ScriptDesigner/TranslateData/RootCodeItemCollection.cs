// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.TranslateData.RootCodeItemCollection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.ScriptDesigner.TranslateData
{
  [Component]
  [Serializable]
  public class RootCodeItemCollection : IXsiRoot
  {
    private static RootCodeItemCollection GQwKJ2Zr33nOxOHU76D;

    public RootCodeItemCollection()
    {
      RootCodeItemCollection.cBANrYZjbPL2OgyD894();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Items = new List<RootCodeItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public List<RootCodeItem> Items { get; set; }

    public RootCodeItem GetItem(Guid uid)
    {
      int num = 2;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.Items.FirstOrDefault<RootCodeItem>((Func<RootCodeItem, bool>) (a => RootCodeItemCollection.\u003C\u003Ec__DisplayClass5_0.U4sF3pf7zuJsMgPjpwFm(RootCodeItemCollection.\u003C\u003Ec__DisplayClass5_0.DS8lCLf7cVDLNwphHG1Y((object) a), uid1)));
    }

    internal static void cBANrYZjbPL2OgyD894() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hmUYo1ZgDXaIJgCawq3() => RootCodeItemCollection.GQwKJ2Zr33nOxOHU76D == null;

    internal static RootCodeItemCollection cPc01LZ5lCvbOjDnKjX() => RootCodeItemCollection.GQwKJ2Zr33nOxOHU76D;
  }
}
