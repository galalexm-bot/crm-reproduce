// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ActionsCodeItemToolBoxGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  public class ActionsCodeItemToolBoxGroup : ICodeItemToolBoxGroup
  {
    public static readonly Guid UID;
    internal static ActionsCodeItemToolBoxGroup umf0iBulAfmlnKEheG8;

    public Guid GroupUid => ActionsCodeItemToolBoxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => (string) ActionsCodeItemToolBoxGroup.pFtjtbuj7NkFvOfkKJC(ActionsCodeItemToolBoxGroup.jVOl1Au5P6msinYjLue(1574260816 ^ 1574246912));

    public ActionsCodeItemToolBoxGroup()
    {
      ActionsCodeItemToolBoxGroup.Gi6wR1uYjnpxNyu4QBA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ActionsCodeItemToolBoxGroup()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ActionsCodeItemToolBoxGroup.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487402494));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 2:
            ActionsCodeItemToolBoxGroup.Gi6wR1uYjnpxNyu4QBA();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object jVOl1Au5P6msinYjLue(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object pFtjtbuj7NkFvOfkKJC([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool KQFsPkur9XV8hv5dFcJ() => ActionsCodeItemToolBoxGroup.umf0iBulAfmlnKEheG8 == null;

    internal static ActionsCodeItemToolBoxGroup MDWqmuugfnPw538O2ce() => ActionsCodeItemToolBoxGroup.umf0iBulAfmlnKEheG8;

    internal static void Gi6wR1uYjnpxNyu4QBA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
