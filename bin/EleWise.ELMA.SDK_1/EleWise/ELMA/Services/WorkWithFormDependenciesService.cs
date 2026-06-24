// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.WorkWithFormDependenciesService
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
  public class WorkWithFormDependenciesService : IWorkWithFormDependeciesService
  {
    private static WorkWithFormDependenciesService VC4v1HBHZoHOMH0iegDg;

    public bool IsActive() => WorkWithFormDependenciesService.xtxFTCBHSxymYxrQVfBT(WorkWithFormDependenciesService.htcJvdBHVcMoTFSYQXvd(-1317790512 ^ -1317713148));

    public void Run(System.Action action)
    {
      int num1 = 1;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            flag = this.IsActive();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          default:
            goto label_2;
        }
      }
label_15:
      return;
label_2:
      try
      {
        int num2;
        if (flag)
          num2 = 2;
        else
          goto label_8;
label_5:
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_10;
            case 1:
            case 2:
              WorkWithFormDependenciesService.Md6R1YBHihApo4pHUVdC((object) action);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_8;
            default:
              goto label_6;
          }
        }
label_10:
        return;
label_6:
        return;
label_8:
        ContextVars.Set<bool>((string) WorkWithFormDependenciesService.htcJvdBHVcMoTFSYQXvd(-951514650 ^ -951558606), true);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        if (!flag)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                WorkWithFormDependenciesService.ahbRNRBHRk7rH8fsY3bm((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727279458));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    public WorkWithFormDependenciesService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object htcJvdBHVcMoTFSYQXvd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xtxFTCBHSxymYxrQVfBT([In] object obj0) => ContextVars.Contains((string) obj0);

    internal static bool GWGS0DBHuyN9sUrR07lJ() => WorkWithFormDependenciesService.VC4v1HBHZoHOMH0iegDg == null;

    internal static WorkWithFormDependenciesService LoUtHMBHIGdySu8cxXOm() => WorkWithFormDependenciesService.VC4v1HBHZoHOMH0iegDg;

    internal static void Md6R1YBHihApo4pHUVdC([In] object obj0) => ((System.Action) obj0)();

    internal static void ahbRNRBHRk7rH8fsY3bm([In] object obj0) => ContextVars.Remove((string) obj0);
  }
}
