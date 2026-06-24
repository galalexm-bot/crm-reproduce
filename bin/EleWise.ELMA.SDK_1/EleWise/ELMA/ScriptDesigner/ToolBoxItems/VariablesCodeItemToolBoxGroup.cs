// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.VariablesCodeItemToolBoxGroup
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
  /// <summary>Группа локальных переменных</summary>
  [Component(Order = 20)]
  public class VariablesCodeItemToolBoxGroup : ICodeItemToolBoxGroup
  {
    public static readonly Guid UID;
    internal static VariablesCodeItemToolBoxGroup jYhjmOVPLBhqnSD69Y9;

    public Guid GroupUid => VariablesCodeItemToolBoxGroup.UID;

    public Guid ParentGroupUid => Guid.Empty;

    public string Name => (string) VariablesCodeItemToolBoxGroup.OBHTpkVpMIx3rCepeKW(VariablesCodeItemToolBoxGroup.kZjV1HV3dU2Lwk9KH7I(589593376 ^ -1977315327 ^ -1459574803));

    public VariablesCodeItemToolBoxGroup()
    {
      VariablesCodeItemToolBoxGroup.arO70NVa8lS8HXd0Okf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static VariablesCodeItemToolBoxGroup()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            VariablesCodeItemToolBoxGroup.arO70NVa8lS8HXd0Okf();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            VariablesCodeItemToolBoxGroup.UID = new Guid((string) VariablesCodeItemToolBoxGroup.kZjV1HV3dU2Lwk9KH7I(979449278 ^ 979466588));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object kZjV1HV3dU2Lwk9KH7I(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OBHTpkVpMIx3rCepeKW([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool PfNMbrV11B6lZIs0RjF() => VariablesCodeItemToolBoxGroup.jYhjmOVPLBhqnSD69Y9 == null;

    internal static VariablesCodeItemToolBoxGroup SGP4wRVNsLe0dhbevhX() => VariablesCodeItemToolBoxGroup.jYhjmOVPLBhqnSD69Y9;

    internal static void arO70NVa8lS8HXd0Okf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
