// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.MathCodeItemToolBoxGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>Группа математических элементов кода</summary>
  [Component(Order = 22)]
  public class MathCodeItemToolBoxGroup : ICodeItemToolBoxGroup
  {
    public static readonly Guid UID;
    private static MathCodeItemToolBoxGroup iyhdywVhyKk91TLR5vk;

    public Guid GroupUid => MathCodeItemToolBoxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => (string) MathCodeItemToolBoxGroup.YAg9JjVQn04q17rEX14(MathCodeItemToolBoxGroup.MGFgvwVfXGOeT4JGIGn(1253244298 - 1829393894 ^ -576132156));

    public MathCodeItemToolBoxGroup()
    {
      MathCodeItemToolBoxGroup.WPmep5VC0NkmvkvGGNC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MathCodeItemToolBoxGroup()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MathCodeItemToolBoxGroup.UID = new Guid((string) MathCodeItemToolBoxGroup.MGFgvwVfXGOeT4JGIGn(2045296739 + 1688595713 ^ -561061404));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object MGFgvwVfXGOeT4JGIGn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YAg9JjVQn04q17rEX14([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool sWPFL6VGpfIljsDX1mY() => MathCodeItemToolBoxGroup.iyhdywVhyKk91TLR5vk == null;

    internal static MathCodeItemToolBoxGroup qxq0iKVETMS4fl9H9lP() => MathCodeItemToolBoxGroup.iyhdywVhyKk91TLR5vk;

    internal static void WPmep5VC0NkmvkvGGNC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
