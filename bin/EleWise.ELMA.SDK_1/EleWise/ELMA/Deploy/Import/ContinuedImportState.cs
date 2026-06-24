// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ContinuedImportState
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Состояние продолжаемого импорта</summary>
  [Serializable]
  internal sealed class ContinuedImportState : IContinuedImportState
  {
    internal static ContinuedImportState pVpDbTExbSa5ypmUlvXY;

    /// <summary>Ctor</summary>
    /// <param name="userId">Идентификатор пользователя от которого запущен продолжаемый импорт</param>
    /// <param name="settingsList">Список настроек для импорта</param>
    /// <param name="manifests">Список манифестов BPM App</param>
    public ContinuedImportState(
      long? userId,
      IEnumerable<IConfigImportSettings> settingsList,
      BPMAppFakeManifest[] manifests)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.LogMessages = new List<DeployLogMessage>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.UserId = userId ?? 0L;
      this.SettingsList = (settingsList != null ? settingsList.ToList<IConfigImportSettings>() : (List<IConfigImportSettings>) null) ?? new List<IConfigImportSettings>();
      this.Manifests = manifests;
      this.InitialSettingsCount = this.SettingsList.Count;
    }

    /// <summary>Список настроек для импорта</summary>
    public List<IConfigImportSettings> SettingsList { get; }

    /// <summary>
    /// Идентификатор пользователя от которого запущен продолжаемый импорт
    /// </summary>
    public long UserId { get; }

    /// <summary>Список манифестов BPM App</summary>
    public BPMAppFakeManifest[] Manifests { get; }

    /// <summary>Список сообщений лога</summary>
    public List<DeployLogMessage> LogMessages { get; }

    /// <summary>Начальное количество настроек импорта</summary>
    public int InitialSettingsCount { get; }

    /// <inheritdoc />
    IReadOnlyCollection<IConfigImportSettings> IContinuedImportState.SettingsList => (IReadOnlyCollection<IConfigImportSettings>) this.SettingsList;

    /// <summary>Требуется ли установка пакетов</summary>
    public bool NeedToInstallPackages
    {
      get => this.\u003CNeedToInstallPackages\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CNeedToInstallPackages\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <summary>Данные для установки пакетов</summary>
    public PackageInstallInfo PackageInstallInfo
    {
      get => this.\u003CPackageInstallInfo\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPackageInstallInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

    internal static bool bPf0yRExh69huOoP6LH0() => ContinuedImportState.pVpDbTExbSa5ypmUlvXY == null;

    internal static ContinuedImportState sH1anpExG8cjlts6e83Q() => ContinuedImportState.pVpDbTExbSa5ypmUlvXY;
  }
}
