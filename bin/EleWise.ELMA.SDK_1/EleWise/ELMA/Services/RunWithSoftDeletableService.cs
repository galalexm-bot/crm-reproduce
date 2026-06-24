// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.RunWithSoftDeletableService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  [Service]
  public class RunWithSoftDeletableService
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private static RunWithSoftDeletableService Kdr4WmBxudohnC55sXaI;

    public RunWithSoftDeletableService(
      IContextBoundVariableService contextBoundVariableService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Включен ли сервис, т.е. будет ли производиться проверка прав в текущем контексте
    /// </summary>
    public bool Turned
    {
      get
      {
        bool flag;
        return this.contextBoundVariableService.TryGetValue<bool>((string) RunWithSoftDeletableService.nkQillBxSiMfyDnY30ZH(333888594 ^ 1075625116 ^ 1408982830), out flag) & flag;
      }
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
              RunWithSoftDeletableService.BbD69HBxifP1ZkYO78DZ((object) this.contextBoundVariableService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411152307), (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    internal static bool cq3WFuBxIGeJAE6H40eV() => RunWithSoftDeletableService.Kdr4WmBxudohnC55sXaI == null;

    internal static RunWithSoftDeletableService ONygK3BxVyXEO5scOsFO() => RunWithSoftDeletableService.Kdr4WmBxudohnC55sXaI;

    internal static object nkQillBxSiMfyDnY30ZH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void BbD69HBxifP1ZkYO78DZ([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);
  }
}
