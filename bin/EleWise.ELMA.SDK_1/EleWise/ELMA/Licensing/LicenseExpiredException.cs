// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.LicenseExpiredException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Licensing
{
  /// <summary>
  /// Вызывается, когда для вызова метода требуется активация модуля
  /// </summary>
  [Serializable]
  public class LicenseExpiredException : LicenseException
  {
    internal static LicenseExpiredException lDVP5mAc8YA58ONkIFe;

    public LicenseExpiredException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(Guid.Empty);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public LicenseExpiredException(Guid moduleUid)
    {
      LicenseExpiredException.wuMGvb7ByWby3Imk5T5();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) LicenseExpiredException.QgpgcP7WLdTlEk5fpqV(moduleUid));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected LicenseExpiredException(SerializationInfo info, StreamingContext context)
    {
      LicenseExpiredException.wuMGvb7ByWby3Imk5T5();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    private static string GenerateMessage(Guid moduleUid)
    {
      int num1 = 3;
      string message;
      while (true)
      {
        int num2 = num1;
        IApplicationUnit applicationUnit;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ComponentManager.Initialized)
              {
                num2 = 5;
                continue;
              }
              goto label_3;
            case 2:
              if (!LicenseExpiredException.RoJybI7hBN0buyR0PGk(moduleUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 4;
                continue;
              }
              goto case 1;
            case 3:
              goto label_12;
            case 4:
            case 6:
              goto label_3;
            case 5:
              applicationUnit = (IApplicationUnit) LicenseExpiredException.oBUd6n7E5W70NIVZe5Q(LicenseExpiredException.KoZoDB7Gc4m7j4pHmqw((object) ComponentManager.Current), moduleUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            case 7:
              message = EleWise.ELMA.SR.T((string) LicenseExpiredException.OyTx397oXiSmnMTucwl(-1921202237 ^ -1921229127), LicenseExpiredException.faw5C57fbLGqGISaMCN((object) applicationUnit));
              num2 = 6;
              continue;
            default:
              if (applicationUnit != null)
              {
                num2 = 7;
                continue;
              }
              goto label_3;
          }
        }
label_12:
        message = (string) LicenseExpiredException.C72phL7bEBdrqM1AFB2(LicenseExpiredException.OyTx397oXiSmnMTucwl(-2138160520 ^ -2138121402));
        num1 = 2;
      }
label_3:
      return message;
    }

    internal static bool VAEruAAzjxDGsmV64GQ() => LicenseExpiredException.lDVP5mAc8YA58ONkIFe == null;

    internal static LicenseExpiredException LgkD9Z7FUv2E71t9Hw6() => LicenseExpiredException.lDVP5mAc8YA58ONkIFe;

    internal static void wuMGvb7ByWby3Imk5T5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object QgpgcP7WLdTlEk5fpqV(Guid moduleUid) => (object) LicenseExpiredException.GenerateMessage(moduleUid);

    internal static object OyTx397oXiSmnMTucwl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object C72phL7bEBdrqM1AFB2([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool RoJybI7hBN0buyR0PGk([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object KoZoDB7Gc4m7j4pHmqw([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object oBUd6n7E5W70NIVZe5Q([In] object obj0, Guid uid) => (object) ((IModuleManager) obj0).FindUnitByUid(uid);

    internal static object faw5C57fbLGqGISaMCN([In] object obj0) => (object) ((IApplicationUnit) obj0).Title;
  }
}
