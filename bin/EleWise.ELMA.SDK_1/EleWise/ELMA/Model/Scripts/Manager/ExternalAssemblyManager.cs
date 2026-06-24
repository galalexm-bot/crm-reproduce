// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Manager.ExternalAssemblyManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Manager
{
  public class ExternalAssemblyManager : EntityManager<IExternalAssembly, long>
  {
    internal static ExternalAssemblyManager RPVDijbnOKX2KBSQlQmH;

    /// <summary>Экземпляр менеджера</summary>
    public static ExternalAssemblyManager Instance => Locator.GetServiceNotNull<ExternalAssemblyManager>();

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<IExternalAssembly>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      ExternalAssemblyManager.OYyLLqbnPXQUCd3Zm0lX((object) exportRule1, type);
      exportRule1.PropertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236078685);
      ExternalAssemblyManager.xP1V9Gbn1cB9NnC69TFV((object) exportRule1, ExportRuleType.Export);
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      ExternalAssemblyManager.OYyLLqbnPXQUCd3Zm0lX((object) exportRule2, type);
      ExternalAssemblyManager.Qbl8PBbn3p7fOPqor2SB((object) exportRule2, ExternalAssemblyManager.DtVXPMbnN6A8g6PFLHiS(-1146510045 ^ -1146497309));
      ExternalAssemblyManager.xP1V9Gbn1cB9NnC69TFV((object) exportRule2, ExportRuleType.Export);
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      exportRule3.ParentType = type;
      ExternalAssemblyManager.Qbl8PBbn3p7fOPqor2SB((object) exportRule3, ExternalAssemblyManager.DtVXPMbnN6A8g6PFLHiS(222162814 ^ 222253656));
      ExternalAssemblyManager.xP1V9Gbn1cB9NnC69TFV((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      ExternalAssemblyManager.OYyLLqbnPXQUCd3Zm0lX((object) exportRule4, type);
      ExternalAssemblyManager.Qbl8PBbn3p7fOPqor2SB((object) exportRule4, ExternalAssemblyManager.DtVXPMbnN6A8g6PFLHiS(-812025778 ^ -811874956));
      ExternalAssemblyManager.xP1V9Gbn1cB9NnC69TFV((object) exportRule4, ExportRuleType.Export);
      exportRuleList.Add(exportRule4);
      return exportRuleList;
    }

    public ExternalAssemblyManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void OYyLLqbnPXQUCd3Zm0lX([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static void xP1V9Gbn1cB9NnC69TFV([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static object DtVXPMbnN6A8g6PFLHiS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Qbl8PBbn3p7fOPqor2SB([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static bool zglsLwbn2x3hmmivKaRw() => ExternalAssemblyManager.RPVDijbnOKX2KBSQlQmH == null;

    internal static ExternalAssemblyManager bTeZuvbneSkjaXHOvM7x() => ExternalAssemblyManager.RPVDijbnOKX2KBSQlQmH;
  }
}
