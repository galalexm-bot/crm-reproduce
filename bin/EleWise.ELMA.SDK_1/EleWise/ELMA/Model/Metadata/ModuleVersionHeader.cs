// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ModuleVersionHeader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Версия модуля</summary>
  [DataContract]
  [Serializable]
  internal sealed class ModuleVersionHeader
  {
    /// <summary>Версия модуля по умолчанию</summary>
    internal static readonly Version DefaultVersion;
    internal static ModuleVersionHeader scxqKkbNLupnKYtO5hhn;

    /// <summary>Ctor</summary>
    /// <param name="signature">Публичная сигнатура модуля</param>
    /// <param name="headerUid">Идентификатор заголовка</param>
    /// <param name="status">Статус активации модуля</param>
    /// <param name="disabledReason">Причина деактивации модуля</param>
    internal ModuleVersionHeader(
      ModuleSignature signature,
      Guid headerUid,
      ModuleStatus status,
      ModuleDisabledReason disabledReason = ModuleDisabledReason.Unknown)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(signature, ModuleVersionHeader.DefaultVersionUid(headerUid, ModuleVersionHeader.DefaultVersion), headerUid, ModuleVersionHeader.DefaultVersion, status, disabledReason);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="signature">Публичная сигнатура модуля</param>
    /// <param name="versionUid">Идентификатор версии</param>
    /// <param name="headerUid">Идентификатор заголовка</param>
    /// <param name="version">Номер версии</param>
    /// <param name="status">Статус активации модуля</param>
    /// <param name="disabledReason">Причина деактивации модуля</param>
    internal ModuleVersionHeader(
      ModuleSignature signature,
      Guid versionUid,
      Guid headerUid,
      Version version,
      ModuleStatus status,
      ModuleDisabledReason disabledReason = ModuleDisabledReason.Unknown)
    {
      ModuleVersionHeader.btRqPXbNctL1UevJuRMO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 8;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_12;
          case 2:
            ModuleVersionHeader.TtkktMb3FF1n1NiAinXH((object) version, ModuleVersionHeader.lOvR82bNzXPo87OjJAfa(694673736 ^ -23604109 ^ -672089777));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 4 : 3;
            continue;
          case 3:
            this.HeaderUid = headerUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 6;
            continue;
          case 4:
            this.Signature = signature;
            num = 3;
            continue;
          case 5:
            this.Status = status;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 8 : 9;
            continue;
          case 6:
            this.Version = version;
            num = 5;
            continue;
          case 7:
            ModuleVersionHeader.ctVk6xb3oomoBPPgJ8E8(ModuleVersionHeader.bVXYx0b3BnSCims3b55P(headerUid, Guid.Empty), ModuleVersionHeader.fNCZH3b3WX7X7Xl3kZXW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889647786)));
            num = 2;
            continue;
          case 8:
            ModuleVersionHeader.TtkktMb3FF1n1NiAinXH((object) signature, ModuleVersionHeader.lOvR82bNzXPo87OjJAfa(--1418440330 ^ 1418283402));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 7;
            continue;
          case 9:
            this.DisabledReason = disabledReason;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          default:
            this.VersionUid = !(versionUid != Guid.Empty) ? ModuleVersionHeader.DefaultVersionUid(headerUid, version) : versionUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
        }
      }
label_12:;
    }

    /// <summary>Создать заголовок из элемента хранения</summary>
    /// <param name="item">Элемент хранения метаданных</param>
    /// <returns>Заголовок версии модуля</returns>
    internal static ModuleVersionHeader FromItem(ModuleMetadataItem item)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(ModuleVersionHeader.horud0b3bg6P1N2YKrjU((object) item) is ModuleSignature moduleSignature))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            ModuleVersionHeader.TtkktMb3FF1n1NiAinXH((object) item, ModuleVersionHeader.lOvR82bNzXPo87OjJAfa(-1217523399 ^ -1217480377));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      ModuleSignature signature = ((ModuleInfoMetadata) ModuleVersionHeader.pFOYv0b3h4MaA4c6jg94((object) item)).GetSignature();
label_6:
      Version result;
      Version version1 = !Version.TryParse(item.Version, out result) ? ModuleVersionHeader.DefaultVersion : result;
      ModuleStatus moduleStatus = ModuleVersionHeader.xuSdq0b3G7epbIkBsQcv((object) item) != null || item.AssemblyRaw != null ? ModuleStatus.Enabled : ModuleStatus.Disabled;
      Guid versionUid = ModuleVersionHeader.XCxYEAb3Eb9fOc4Q4FV5((object) item);
      Guid headerUid = ModuleVersionHeader.EK4mDsb3f0uAo93fXINp((object) item.Header);
      Version version2 = version1;
      int status = (int) moduleStatus;
      return new ModuleVersionHeader(signature, versionUid, headerUid, version2, (ModuleStatus) status);
label_7:
      signature = moduleSignature;
      goto label_6;
    }

    /// <summary>Публичная сигнатура модуля</summary>
    public ModuleSignature Signature { get; }

    /// <summary>Идентификатор версии</summary>
    public Guid VersionUid { get; }

    /// <summary>Уникальный идентификатор заголовка</summary>
    public Guid HeaderUid { get; }

    /// <summary>Номер версии</summary>
    public Version Version { get; }

    /// <summary>Статус активации модуля</summary>
    public ModuleStatus Status { get; }

    /// <summary>Причина отключения модуля</summary>
    public ModuleDisabledReason DisabledReason { get; }

    /// <summary>Вычислить идентификатор версии если явно не задан</summary>
    /// <param name="headerUid">Идентификатор заголовка</param>
    /// <param name="version">Версия</param>
    /// <returns>Идентификатор версии</returns>
    internal static Guid DefaultVersionUid(Guid headerUid, Version version) => ModuleVersionHeader.A3on0Eb3C6xDph5qw6qQ(ModuleVersionHeader.cRy9IUb3Q5YXTawYpDbv((object) headerUid.ToString(), (object) version));

    static ModuleVersionHeader()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModuleVersionHeader.btRqPXbNctL1UevJuRMO();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ModuleVersionHeader.DefaultVersion = new Version((string) ModuleVersionHeader.lOvR82bNzXPo87OjJAfa(-1837662597 ^ -1837656917));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool do7WN8bNUvwkQv5wYN2U() => ModuleVersionHeader.scxqKkbNLupnKYtO5hhn == null;

    internal static ModuleVersionHeader jOel4TbNsKhWbjKBTeXB() => ModuleVersionHeader.scxqKkbNLupnKYtO5hhn;

    internal static void btRqPXbNctL1UevJuRMO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object lOvR82bNzXPo87OjJAfa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void TtkktMb3FF1n1NiAinXH([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool bVXYx0b3BnSCims3b55P([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object fNCZH3b3WX7X7Xl3kZXW([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void ctVk6xb3oomoBPPgJ8E8(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object horud0b3bg6P1N2YKrjU([In] object obj0) => ((ModuleMetadataItem) obj0).Signature;

    internal static object pFOYv0b3h4MaA4c6jg94([In] object obj0) => ((ModuleMetadataItem) obj0).Metadata;

    internal static object xuSdq0b3G7epbIkBsQcv([In] object obj0) => (object) ((ModuleMetadataItem) obj0).ClientAssemblyRaw;

    internal static Guid XCxYEAb3Eb9fOc4Q4FV5([In] object obj0) => ((ModuleMetadataItem) obj0).Uid;

    internal static Guid EK4mDsb3f0uAo93fXINp([In] object obj0) => ((ModuleMetadataItemHeader) obj0).Uid;

    internal static object cRy9IUb3Q5YXTawYpDbv([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static Guid A3on0Eb3C6xDph5qw6qQ([In] object obj0) => ((string) obj0).GetDeterministicGuid();
  }
}
