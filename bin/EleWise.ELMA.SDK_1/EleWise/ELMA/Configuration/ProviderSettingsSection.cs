// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.ProviderSettingsSection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Configuration
{
  public abstract class ProviderSettingsSection : ConfigurationSection
  {
    public const string CONFIGDIR = "{CONFIGDIR}";
    public const string PROVIDERTYPE = "type";
    private readonly ConfigurationProperty _providerType;
    protected bool? _autoInitialize;
    private static ProviderSettingsSection tH2OUDfB39DnrvDUFtdV;

    protected virtual void InitializeAutoInitilize()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._autoInitialize = new bool?(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected string CombinePath(string path)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) ProviderSettingsSection.DhlA8afBtrF2L87a4XJl((object) ((System.Configuration.Configuration) ProviderSettingsSection.pwRO69fBDnviVnKRKOJe((object) this)).FilePath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.ReplaceConfigDir(str != null ? (string) ProviderSettingsSection.KRTQQvfBwP6FoApPK4yn((object) str, (object) path) : path);
    }

    protected string ReplaceConfigDir(string path) => path.Replace((string) ProviderSettingsSection.WVtppCfB4mFDLS0AIWAQ(222162814 ^ 221839116), Path.GetDirectoryName(((System.Configuration.Configuration) ProviderSettingsSection.pwRO69fBDnviVnKRKOJe((object) this)).FilePath));

    /// <summary>Уникальный идентификатор провайдера БД</summary>
    [TypeConverter(typeof (TypeNameConverter))]
    [ConfigurationProperty("type", IsRequired = true, IsKey = true)]
    public virtual Type ProviderType
    {
      get => (Type) this[this._providerType];
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ProviderSettingsSection.W7wcHpfB6f4hfBA5py1o((object) this, (object) this._providerType, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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

    /// <summary>Автоматическая инициализация провайдера при загрузке</summary>
    public bool AutoInitialize
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              ProviderSettingsSection.JxlrvvfBHfIhnSuCrHBc((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            case 2:
              if (!this._autoInitialize.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            default:
              goto label_5;
          }
        }
label_5:
        return this._autoInitialize.Value;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._autoInitialize = new bool?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    protected ProviderSettingsSection()
    {
      ProviderSettingsSection.kZghpIfBAuxBiSbXq08X();
      // ISSUE: type reference
      this._providerType = new ConfigurationProperty((string) ProviderSettingsSection.WVtppCfB4mFDLS0AIWAQ(-710283084 ^ -537863435 ^ 173614691), ProviderSettingsSection.pKUehlfB7nTXu5XLItoV(__typeref (Type)), (object) null);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SDVaGbfBpPcFEWIEFl9x() => ProviderSettingsSection.tH2OUDfB39DnrvDUFtdV == null;

    internal static ProviderSettingsSection u7LHXDfBar1ie21rbZDW() => ProviderSettingsSection.tH2OUDfB39DnrvDUFtdV;

    internal static object pwRO69fBDnviVnKRKOJe([In] object obj0) => (object) ((ConfigurationElement) obj0).CurrentConfiguration;

    internal static object DhlA8afBtrF2L87a4XJl([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object KRTQQvfBwP6FoApPK4yn([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object WVtppCfB4mFDLS0AIWAQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void W7wcHpfB6f4hfBA5py1o([In] object obj0, [In] object obj1, [In] object obj2) => ((ConfigurationElement) obj0)[(ConfigurationProperty) obj1] = obj2;

    internal static void JxlrvvfBHfIhnSuCrHBc([In] object obj0) => ((ProviderSettingsSection) obj0).InitializeAutoInitilize();

    internal static void kZghpIfBAuxBiSbXq08X() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type pKUehlfB7nTXu5XLItoV([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
