// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.PreviewSettingsModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  [Component]
  public class PreviewSettingsModule : GlobalSettingsModuleBase<PreviewSettings>
  {
    public static Guid UID;
    private static PreviewSettingsModule n5udJXGNSdojtEV1VSGt;

    public override Guid ModuleGuid => PreviewSettingsModule.UID;

    /// <summary>Название модуля</summary>
    public override string ModuleName => (string) PreviewSettingsModule.t81mgJGNKuK8JPiE5RaJ(PreviewSettingsModule.yC93tAGNqPFrH5drF12o(372753449 ^ 372517767));

    /// <summary>Включено ли превью</summary>
    /// <param name="creator"></param>
    /// <returns></returns>
    public bool IsEnabledPreview(IFilePreviewCreator creator)
    {
      int num1 = 6;
      CreatorInfo creatorInfo;
      while (true)
      {
        int num2 = num1;
        IFilePreviewCreator creator1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_5;
            case 3:
              if (this.Settings == null)
              {
                num2 = 4;
                continue;
              }
              goto case 8;
            case 5:
              creator1 = creator;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 0;
              continue;
            case 6:
              num2 = 5;
              continue;
            case 7:
              if (creatorInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
                continue;
              }
              goto label_5;
            case 8:
              if (this.Settings.Infos == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            default:
              goto label_10;
          }
        }
label_11:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        creatorInfo = this.Settings.Infos.FirstOrDefault<CreatorInfo>((Func<CreatorInfo, bool>) (i => PreviewSettingsModule.\u003C\u003Ec__DisplayClass5_0.p6vjke8FZo6xCuMR5psL(PreviewSettingsModule.\u003C\u003Ec__DisplayClass5_0.ufxnSa8FvJ6BFSPpHhO5((object) i), PreviewSettingsModule.\u003C\u003Ec__DisplayClass5_0.ibFcwm8F8qwGp9aS38QB((object) creator1))));
        num1 = 7;
      }
label_5:
      return !PreviewSettingsModule.GcDoVaGNXMi2vL9QZbIK((object) creatorInfo);
label_6:
      return true;
label_10:
      return true;
    }

    public PreviewSettingsModule()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PreviewSettingsModule()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PreviewSettingsModule.POurBoGNTFkIAtjrgaY0();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PreviewSettingsModule.UID = new Guid((string) PreviewSettingsModule.yC93tAGNqPFrH5drF12o(-16752921 ^ -16535295));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object yC93tAGNqPFrH5drF12o(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object t81mgJGNKuK8JPiE5RaJ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool E4sOedGNiF3RaGkVboPa() => PreviewSettingsModule.n5udJXGNSdojtEV1VSGt == null;

    internal static PreviewSettingsModule PVNbTMGNRDYekYjc5UZZ() => PreviewSettingsModule.n5udJXGNSdojtEV1VSGt;

    internal static bool GcDoVaGNXMi2vL9QZbIK([In] object obj0) => ((CreatorInfo) obj0).Disable;

    internal static void POurBoGNTFkIAtjrgaY0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
