// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportImportVersion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Информация о версионности экспорта-импорта</summary>
  public class ExportImportVersion
  {
    /// <summary>
    /// Версия протокола импорта, которая поддерживается в данный момент.
    /// </summary>
    internal const string ProtocolLegacy = "2.0";
    /// <summary>
    /// Версия протокола экспорта-импорта.
    /// Разница в версиях протокола указывает на возможную или неполную несовместимость
    /// </summary>
    public const string Protocol = "2.1";
    /// <summary>
    /// Версия экспорта-импорта.
    /// Разница версий экспорта-импорта указывает на полную несовместимость
    /// </summary>
    public const string Version = "400";
    /// <summary>Отображаемое название версии экспорта-импорта</summary>
    public static string VersionDescription;
    /// <summary>
    /// Версия экспорта-импорта, которые могут быть импортированы
    /// </summary>
    internal static readonly string[] SupportedVersion;
    private static ExportImportVersion SWW05DEpq95rifwFFRhB;

    public ExportImportVersion()
    {
      ExportImportVersion.rn86WFEpT9rvP8cWc9DJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ExportImportVersion()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExportImportVersion.SupportedVersion = new string[1]
            {
              (string) ExportImportVersion.b1IPAREpkegYT728foo5(1012087039 ^ 1012383097)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            ExportImportVersion.VersionDescription = (string) ExportImportVersion.WhglntEpnsOw8oV0ZUEu(ExportImportVersion.b1IPAREpkegYT728foo5(-441065788 ^ -2092910478 ^ 1727128570));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
            continue;
          case 3:
            ExportImportVersion.rn86WFEpT9rvP8cWc9DJ();
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void rn86WFEpT9rvP8cWc9DJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FNC3D8EpKtxiEQWrDacQ() => ExportImportVersion.SWW05DEpq95rifwFFRhB == null;

    internal static ExportImportVersion k8WbHqEpXekJnspdaDBg() => ExportImportVersion.SWW05DEpq95rifwFFRhB;

    internal static object b1IPAREpkegYT728foo5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object WhglntEpnsOw8oV0ZUEu([In] object obj0) => (object) SR.T((string) obj0);
  }
}
