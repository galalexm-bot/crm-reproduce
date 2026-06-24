// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.CommonSettingsModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Settings
{
  /// <summary>Модуль общих настроек системы</summary>
  [Component]
  public class CommonSettingsModule : GlobalSettingsModuleBase<CommonSettings>
  {
    public const string UID = "e0fe14e4-ff52-435c-85f0-5e92a5d11c6b";
    public static readonly Guid Uid;
    private static CommonSettingsModule Cag9BUWhpFk0Y4E8hiKA;

    public override Guid ModuleGuid => CommonSettingsModule.Uid;

    /// <summary>Название модуля</summary>
    public override string ModuleName => (string) CommonSettingsModule.bZZr9IWhtix0YHtbyPw4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672028519));

    protected override void LoadSettings()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_6;
            case 3:
              if (CommonSettingsModule.c8bKEwWh6D2KdO3uPQBH(CommonSettingsModule.RilbNXWh46Wk5tBK4Ibi((object) this._settings)))
                break;
              goto label_11;
            case 4:
              goto label_3;
            case 5:
              if (this._settings == null)
              {
                num2 = 4;
                continue;
              }
              goto case 3;
            case 6:
              CommonSettingsModule.Yq7aQ0Whw9NQHHJIsIaI((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 5 : 3;
              continue;
          }
          CommonSettingsModule.DIDC5QWhHTR7r4nE8Tlq((object) this._settings, (object) EleWise.ELMA.SR.GetDefaultCulture().Name);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
        }
label_11:
        num1 = 2;
      }
label_8:
      return;
label_6:
      return;
label_3:;
    }

    public override void SaveSettings()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            EleWise.ELMA.SR.SaveCultureToSettings((string) CommonSettingsModule.RilbNXWh46Wk5tBK4Ibi((object) this.Settings));
            num = 5;
            continue;
          case 2:
            if (!CommonSettingsModule.c8bKEwWh6D2KdO3uPQBH((object) this.Settings.SystemDefaultCultureName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            if (this.Settings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 4:
            CommonSettingsModule.g5NAKZWhAuIffZDFB6rT((object) this);
            num = 3;
            continue;
          case 5:
            goto label_10;
          default:
            goto label_11;
        }
      }
label_3:
      return;
label_10:
      return;
label_11:
      return;
label_2:;
    }

    public CommonSettingsModule()
    {
      CommonSettingsModule.BteGKvWh7AUD1Qd7sXsG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CommonSettingsModule()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CommonSettingsModule.Uid = new Guid((string) CommonSettingsModule.zMVi1sWhxbGHCP2hcYC2(-1876063057 ^ -1876053665));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            CommonSettingsModule.BteGKvWh7AUD1Qd7sXsG();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object bZZr9IWhtix0YHtbyPw4([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool z7mwnUWhaSfCyK70kORv() => CommonSettingsModule.Cag9BUWhpFk0Y4E8hiKA == null;

    internal static CommonSettingsModule WcDGndWhDbeOCVqsQ305() => CommonSettingsModule.Cag9BUWhpFk0Y4E8hiKA;

    internal static void Yq7aQ0Whw9NQHHJIsIaI([In] object obj0) => __nonvirtual (((GlobalSettingsModuleBase<CommonSettings>) obj0).LoadSettings());

    internal static object RilbNXWh46Wk5tBK4Ibi([In] object obj0) => (object) ((CommonSettings) obj0).SystemDefaultCultureName;

    internal static bool c8bKEwWh6D2KdO3uPQBH([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void DIDC5QWhHTR7r4nE8Tlq([In] object obj0, [In] object obj1) => ((CommonSettings) obj0).SystemDefaultCultureName = (string) obj1;

    internal static void g5NAKZWhAuIffZDFB6rT([In] object obj0) => __nonvirtual (((GlobalSettingsModuleBase<CommonSettings>) obj0).SaveSettings());

    internal static void BteGKvWh7AUD1Qd7sXsG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object zMVi1sWhxbGHCP2hcYC2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
