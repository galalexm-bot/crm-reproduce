// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.ModuleReferenceManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер ссылки метаданных на модуль</summary>
  [Service(Type = ComponentType.Server, EnableInterceptors = false)]
  internal sealed class ModuleReferenceManager : NHManager, IModuleReferenceManager
  {
    internal static ModuleReferenceManager n2mOhgbUqtIpmtpjCsua;

    /// <summary>Сохранить</summary>
    /// <param name="moduleReference">Ссылка на модуль</param>
    /// <exception cref="T:System.Exception">Возникает, если уникальный идентификатор метаданных пустой</exception>
    public void Save(ModuleReference moduleReference)
    {
      int num1 = 8;
      string message;
      while (true)
      {
        int num2 = num1;
        Guid metadataUid;
        ModuleReference moduleReference1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ModuleReferenceManager.F8meSwbUnMMxP0EblFKX(ModuleReferenceManager.ICJQ3kbUkd8yZJooR2av((object) moduleReference1), moduleReference.ModuleUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 5 : 1;
                continue;
              }
              goto label_3;
            case 2:
              if (moduleReference1 == null)
              {
                ModuleReferenceManager.FGkDvwbUeO4E3VVG8V6x((object) this.Session, (object) moduleReference);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 3;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_10;
            case 4:
              goto label_4;
            case 5:
              message = EleWise.ELMA.SR.T((string) ModuleReferenceManager.djuV5ybUOJmBbZ7tuVfK(864270449 << 6 ^ -521332636), (object) ModuleReferenceManager.ICJQ3kbUkd8yZJooR2av((object) moduleReference1), (object) moduleReference.ModuleUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 4 : 6;
              continue;
            case 6:
              ((ILogger) ModuleReferenceManager.VgCOnpbU2qW3imnaqLvq()).Error((object) message);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            case 7:
              if (!(metadataUid == Guid.Empty))
              {
                moduleReference1 = this.LoadOrNull(metadataUid);
                num2 = 2;
                continue;
              }
              num2 = 4;
              continue;
            case 8:
              goto label_17;
            default:
              goto label_9;
          }
        }
label_17:
        metadataUid = moduleReference.MetadataUid;
        num1 = 7;
      }
label_10:
      return;
label_4:
      throw new Exception((string) ModuleReferenceManager.Ken1DRbUTwkHMsHKkG5I((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293884810)));
label_3:
      return;
label_9:
      throw new Exception(message);
    }

    /// <summary>Загрузить ссылку метаданных на модуль</summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>Ссылка метаданных на модуль или <c>null</c></returns>
    public ModuleReference LoadOrNull(Guid metadataUid) => this.Session.Get<ModuleReference>((object) metadataUid);

    public ModuleReferenceManager()
    {
      ModuleReferenceManager.FUN5OYbUPkLobeij1AjQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Ken1DRbUTwkHMsHKkG5I([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Guid ICJQ3kbUkd8yZJooR2av([In] object obj0) => ((ModuleReference) obj0).ModuleUid;

    internal static bool F8meSwbUnMMxP0EblFKX([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object djuV5ybUOJmBbZ7tuVfK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VgCOnpbU2qW3imnaqLvq() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static object FGkDvwbUeO4E3VVG8V6x([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static bool leI6RSbUKuRg8QNGshCB() => ModuleReferenceManager.n2mOhgbUqtIpmtpjCsua == null;

    internal static ModuleReferenceManager rRDe3VbUXWmxCdSbuXHG() => ModuleReferenceManager.n2mOhgbUqtIpmtpjCsua;

    internal static void FUN5OYbUPkLobeij1AjQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
