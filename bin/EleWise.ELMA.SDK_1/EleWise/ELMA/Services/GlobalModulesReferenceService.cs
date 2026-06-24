// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.GlobalModulesReferenceService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts.DTO.Manager;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Сервис для работы с ссылками на глобальные модули (их сборки).
  /// </summary>
  [Service]
  internal sealed class GlobalModulesReferenceService : IGlobalModulesReferenceService
  {
    private readonly IGlobalScriptModuleHeaderDtoManager globalScriptModuleHeaderDtoManager;
    private static GlobalModulesReferenceService FvhTUDBawfURfiVbJFo1;

    /// <summary>Ctor</summary>
    /// <param name="globalScriptModuleHeaderDtoManager">DTO Менеджер для работы с заголовками глобальных модулей сценариев</param>
    public GlobalModulesReferenceService(
      IGlobalScriptModuleHeaderDtoManager globalScriptModuleHeaderDtoManager)
    {
      GlobalModulesReferenceService.cpyPvWBaHNoxLYaA2MqK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.globalScriptModuleHeaderDtoManager = globalScriptModuleHeaderDtoManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.ClearGlobalModuleAssemblyFolder();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public string CreateGlobalModuleAssembly(Guid globalModuleHeaderUid)
    {
      int num = 2;
      string moduleAssemblyPath;
      byte[] numArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!GlobalModulesReferenceService.CYS72eBaA884CZVuMYVv((object) moduleAssemblyPath))
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 2:
            moduleAssemblyPath = this.GetGlobalModuleAssemblyPath(globalModuleHeaderUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
          case 3:
            numArray = (byte[]) GlobalModulesReferenceService.aEARWYBa7MdZNUHFcjww((object) this.globalScriptModuleHeaderDtoManager, globalModuleHeaderUid);
            num = 4;
            continue;
          case 4:
            if (numArray == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 5:
            GlobalModulesReferenceService.twg3f5BaxH5xfe5Qls2r((object) moduleAssemblyPath, (object) numArray);
            num = 7;
            continue;
          case 7:
            goto label_4;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) null;
label_4:
      return moduleAssemblyPath;
    }

    /// <inheritdoc />
    public string GetGlobalModuleAssemblyPath(Guid globalModuleHeaderUid)
    {
      int num = 4;
      GlobalScriptModuleHeaderDto scriptModuleHeaderDto;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            if (scriptModuleHeaderDto != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            scriptModuleHeaderDto = (GlobalScriptModuleHeaderDto) GlobalModulesReferenceService.AEDDFNBa0KvcNt7H3eEk((object) this.globalScriptModuleHeaderDtoManager, globalModuleHeaderUid);
            num = 3;
            continue;
          default:
            if (scriptModuleHeaderDto.PublishedId > 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return (string) null;
label_3:
      return (string) GlobalModulesReferenceService.JQ5JUwBaJPciiu4J2eBY(GlobalModulesReferenceService.Am471RBamg41qMNmCB2h(), GlobalModulesReferenceService.nrFm7HBaMK8ijKjF7vC1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461708551), (object) scriptModuleHeaderDto.Uid, (object) scriptModuleHeaderDto.PublishedId, GlobalModulesReferenceService.HnAlj6BayFKfCvtCEM3D(1461825605 - 1531863589 ^ -70120806)));
    }

    private void ClearGlobalModuleAssemblyFolder()
    {
      int num1 = 3;
      IEnumerator<string> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_27;
          case 2:
            enumerator = Directory.EnumerateFiles((string) GlobalModulesReferenceService.Am471RBamg41qMNmCB2h(), (string) GlobalModulesReferenceService.HnAlj6BayFKfCvtCEM3D(-2106517564 ^ -2106567934), SearchOption.TopDirectoryOnly).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 3:
            if (GlobalModulesReferenceService.AiMExRBa9X2Bsmm7NZ8C(GlobalModulesReferenceService.Am471RBamg41qMNmCB2h()))
            {
              num1 = 2;
              continue;
            }
            goto label_20;
          case 4:
            goto label_28;
          default:
            goto label_2;
        }
      }
label_27:
      return;
label_28:
      return;
label_2:
      try
      {
label_15:
        if (GlobalModulesReferenceService.z87gpoBaddS99NXonrjd((object) enumerator))
          goto label_13;
        else
          goto label_16;
label_4:
        string current;
        int num2;
        switch (num2)
        {
          case 1:
            goto label_15;
          case 2:
            break;
          case 3:
            return;
          default:
            try
            {
              File.Delete(current);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_15;
              }
            }
            catch
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_15;
                  default:
                    Logger.Log.WarnFormat((string) GlobalModulesReferenceService.HnAlj6BayFKfCvtCEM3D(-1876063057 ^ -1876113285), (object) current);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
                    continue;
                }
              }
            }
        }
label_13:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_16:
        num2 = 3;
        goto label_4;
      }
      finally
      {
        int num5;
        if (enumerator == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
        else
          goto label_22;
label_19:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_22:
        GlobalModulesReferenceService.pnG0F0BalkK7mm85QPoY((object) enumerator);
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        {
          num5 = 1;
          goto label_19;
        }
        else
          goto label_19;
      }
label_20:;
    }

    internal static void cpyPvWBaHNoxLYaA2MqK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cMDsf5Ba4m7fK3INs5BA() => GlobalModulesReferenceService.FvhTUDBawfURfiVbJFo1 == null;

    internal static GlobalModulesReferenceService IF4pvgBa6MfqtaGH7icl() => GlobalModulesReferenceService.FvhTUDBawfURfiVbJFo1;

    internal static bool CYS72eBaA884CZVuMYVv([In] object obj0) => File.Exists((string) obj0);

    internal static object aEARWYBa7MdZNUHFcjww([In] object obj0, Guid headerUid) => (object) ((IGlobalScriptModuleHeaderDtoManager) obj0).GetAssemblyRaw(headerUid);

    internal static void twg3f5BaxH5xfe5Qls2r([In] object obj0, [In] object obj1) => File.WriteAllBytes((string) obj0, (byte[]) obj1);

    internal static object AEDDFNBa0KvcNt7H3eEk([In] object obj0, Guid uid) => (object) ((IGlobalScriptModuleHeaderDtoManager) obj0).LoadOrNull(uid);

    internal static object Am471RBamg41qMNmCB2h() => (object) AssemblyReferenceHelper.ExternalAssemblyLocation;

    internal static object HnAlj6BayFKfCvtCEM3D(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nrFm7HBaMK8ijKjF7vC1(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object JQ5JUwBaJPciiu4J2eBY([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool AiMExRBa9X2Bsmm7NZ8C([In] object obj0) => Directory.Exists((string) obj0);

    internal static bool z87gpoBaddS99NXonrjd([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void pnG0F0BalkK7mm85QPoY([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
