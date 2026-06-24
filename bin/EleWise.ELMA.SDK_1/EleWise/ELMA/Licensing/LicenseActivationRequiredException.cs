// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.LicenseActivationRequiredException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Licensing
{
  /// <summary>
  /// Вызывается, когда для вызова метода требуется активация модуля
  /// </summary>
  [Serializable]
  public class LicenseActivationRequiredException : LicenseException
  {
    private static LicenseActivationRequiredException aaBib0AxIr4PLIavdSR;

    public LicenseActivationRequiredException()
    {
      LicenseActivationRequiredException.rHKlOEAyXahlQT2cQrG();
      // ISSUE: explicit constructor call
      this.\u002Ector(Guid.Empty);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public LicenseActivationRequiredException(Guid moduleUid)
    {
      LicenseActivationRequiredException.rHKlOEAyXahlQT2cQrG();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) LicenseActivationRequiredException.yxvS2BAM8CiJsC6682G(moduleUid));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public LicenseActivationRequiredException(string[] moduleNames)
    {
      LicenseActivationRequiredException.rHKlOEAyXahlQT2cQrG();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) LicenseActivationRequiredException.YKcI0RAJGB6fgVUeWp8((object) moduleNames));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ModuleNames = moduleNames;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string[] ModuleNames
    {
      get => this.\u003CModuleNames\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CModuleNames\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    protected LicenseActivationRequiredException(SerializationInfo info, StreamingContext context)
    {
      LicenseActivationRequiredException.rHKlOEAyXahlQT2cQrG();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    private static string GenerateMessage(Guid moduleUid)
    {
      int num = 1;
      string message;
      IApplicationUnit applicationUnit;
      while (true)
      {
        switch (num)
        {
          case 1:
            message = (string) LicenseActivationRequiredException.tBFCExAdx2wMwc7JFNY(LicenseActivationRequiredException.j9VovEA9rdxd1p2o9Ln(222162814 ^ 222132228));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
          case 8:
            goto label_4;
          case 4:
            applicationUnit = (IApplicationUnit) LicenseActivationRequiredException.qiXrmYArCDD4Mb6WsWF(LicenseActivationRequiredException.k8H02IAl9j6IvipeYp5((object) ComponentManager.Current), moduleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 7;
            continue;
          case 5:
            if (ComponentManager.Initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 4 : 4;
              continue;
            }
            goto label_4;
          case 6:
            message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998577448), LicenseActivationRequiredException.oow2CwAg13IvF6mIMDW((object) applicationUnit));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 8 : 1;
            continue;
          case 7:
            if (applicationUnit == null)
            {
              num = 3;
              continue;
            }
            goto case 6;
          default:
            if (!(moduleUid != Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 2;
              continue;
            }
            goto case 5;
        }
      }
label_4:
      return message;
    }

    private static string GenerateMessage(object moduleNames) => EleWise.ELMA.SR.T((string) LicenseActivationRequiredException.j9VovEA9rdxd1p2o9Ln(589593376 ^ -1977315327 ^ -1459588275), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138015235), ((IEnumerable<string>) moduleNames).Select<string, string>((Func<string, string>) (n => (string) LicenseActivationRequiredException.\u003C\u003Ec.NFPxfBfgV3fwbBkVX7Y7(LicenseActivationRequiredException.\u003C\u003Ec.HdBVL6fgIRtUV8Yp4FsZ(-441065788 ^ -2092910478 ^ 1727331162), (object) n)))));

    internal static void rHKlOEAyXahlQT2cQrG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool eX8TiQA0aorsPR5L6Lr() => LicenseActivationRequiredException.aaBib0AxIr4PLIavdSR == null;

    internal static LicenseActivationRequiredException rsnFuKAm6oB03Dx6xsD() => LicenseActivationRequiredException.aaBib0AxIr4PLIavdSR;

    internal static object yxvS2BAM8CiJsC6682G(Guid moduleUid) => (object) LicenseActivationRequiredException.GenerateMessage(moduleUid);

    internal static object YKcI0RAJGB6fgVUeWp8([In] object obj0) => (object) LicenseActivationRequiredException.GenerateMessage(obj0);

    internal static object j9VovEA9rdxd1p2o9Ln(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object tBFCExAdx2wMwc7JFNY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object k8H02IAl9j6IvipeYp5([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object qiXrmYArCDD4Mb6WsWF([In] object obj0, Guid uid) => (object) ((IModuleManager) obj0).FindUnitByUid(uid);

    internal static object oow2CwAg13IvF6mIMDW([In] object obj0) => (object) ((IApplicationUnit) obj0).Title;
  }
}
