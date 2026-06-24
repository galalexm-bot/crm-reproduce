// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.LicenseWorkplaceExceededException
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
  /// Вызывается при превышении числа пользовательских лицензий
  /// </summary>
  [Serializable]
  public class LicenseWorkplaceExceededException : LicenseException
  {
    private static LicenseWorkplaceExceededException g5JxJC786AfGAVkse68;

    public LicenseWorkplaceExceededException()
    {
      LicenseWorkplaceExceededException.Pksm1i7I7BuH3Nxya8T();
      // ISSUE: explicit constructor call
      this.\u002Ector(Guid.Empty);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public LicenseWorkplaceExceededException(Guid moduleUid)
    {
      LicenseWorkplaceExceededException.Pksm1i7I7BuH3Nxya8T();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) LicenseWorkplaceExceededException.X8YIVZ7Vncgj3yfwpMG(moduleUid));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected LicenseWorkplaceExceededException(SerializationInfo info, StreamingContext context)
    {
      LicenseWorkplaceExceededException.Pksm1i7I7BuH3Nxya8T();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    private static string GenerateMessage(Guid moduleUid)
    {
      int num = 8;
      string message;
      while (true)
      {
        IApplicationUnit unitByUid;
        switch (num)
        {
          case 1:
            if (unitByUid == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 6 : 6;
              continue;
            }
            goto case 4;
          case 2:
          case 3:
          case 6:
            goto label_2;
          case 4:
            message = EleWise.ELMA.SR.T((string) LicenseWorkplaceExceededException.U46hsn7SLdvR230Imex(1113862659 ^ 1113892923), (object) unitByUid.Title);
            num = 3;
            continue;
          case 5:
            if (!LicenseWorkplaceExceededException.WGYHcJ7qUJbRy0T2XdA())
            {
              num = 2;
              continue;
            }
            break;
          case 7:
            if (LicenseWorkplaceExceededException.e3C4mp7RWwEAnFndhNc(moduleUid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 5;
              continue;
            }
            goto label_2;
          case 8:
            message = (string) LicenseWorkplaceExceededException.Ickosf7iDPSg7FxIakS(LicenseWorkplaceExceededException.U46hsn7SLdvR230Imex(1597012150 ^ 1597038958));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 7;
            continue;
        }
        unitByUid = ((IModuleManager) LicenseWorkplaceExceededException.tD21Pr7KLC0va6KLR7u((object) ComponentManager.Current)).FindUnitByUid(moduleUid);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
      }
label_2:
      return message;
    }

    internal static void Pksm1i7I7BuH3Nxya8T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool B9PHx17ZDPyTcFBvRGd() => LicenseWorkplaceExceededException.g5JxJC786AfGAVkse68 == null;

    internal static LicenseWorkplaceExceededException SaiFRt7utl5ESUS1beC() => LicenseWorkplaceExceededException.g5JxJC786AfGAVkse68;

    internal static object X8YIVZ7Vncgj3yfwpMG(Guid moduleUid) => (object) LicenseWorkplaceExceededException.GenerateMessage(moduleUid);

    internal static object U46hsn7SLdvR230Imex(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Ickosf7iDPSg7FxIakS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool e3C4mp7RWwEAnFndhNc([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool WGYHcJ7qUJbRy0T2XdA() => ComponentManager.Initialized;

    internal static object tD21Pr7KLC0va6KLR7u([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;
  }
}
