// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Modules.ModuleDeployException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Modules
{
  /// <summary>Ошибка разворачивания модуля</summary>
  internal sealed class ModuleDeployException : Exception
  {
    private static ModuleDeployException ObW2ZxEMuhKgEf3rNbPM;

    private ModuleDeployException(string message)
    {
      ModuleDeployException.zu57nGEMSRmqcLdoAsdq();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ошибка импорта модуля</summary>
    /// <returns>Исключение</returns>
    public static ModuleDeployException ImportError() => new ModuleDeployException((string) ModuleDeployException.KfFUV8EMiEd8hPbhayWl((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304825235)));

    /// <summary>Ошибка тестирования модуля</summary>
    /// <param name="id">Идентификатор модуля</param>
    /// <param name="title">Название модуля</param>
    /// <param name="message">Сообщение об ошибке</param>
    /// <returns>Исключение</returns>
    public static ModuleDeployException TestError(string id, string title, string message)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            message = (string) ModuleDeployException.KfFUV8EMiEd8hPbhayWl(ModuleDeployException.AOQ7LQEMqKbpitLFdEov(-1710575414 ^ -1710355060));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            if (ModuleDeployException.wsPep4EMRcYjJbsaFFqt((object) message))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return new ModuleDeployException(EleWise.ELMA.SR.T((string) ModuleDeployException.AOQ7LQEMqKbpitLFdEov(236071375 ^ 236360783), (object) title, (object) id, (object) message));
    }

    /// <summary>Ошибка тестирования модуля</summary>
    public static ModuleDeployException TestError() => new ModuleDeployException((string) ModuleDeployException.KfFUV8EMiEd8hPbhayWl(ModuleDeployException.AOQ7LQEMqKbpitLFdEov(1199946765 ^ 1199636953)));

    internal static void zu57nGEMSRmqcLdoAsdq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nlVpCuEMIWegTQmBUNXG() => ModuleDeployException.ObW2ZxEMuhKgEf3rNbPM == null;

    internal static ModuleDeployException zaiTW1EMVLD0U0k6gVE2() => ModuleDeployException.ObW2ZxEMuhKgEf3rNbPM;

    internal static object KfFUV8EMiEd8hPbhayWl([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool wsPep4EMRcYjJbsaFFqt([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object AOQ7LQEMqKbpitLFdEov(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
