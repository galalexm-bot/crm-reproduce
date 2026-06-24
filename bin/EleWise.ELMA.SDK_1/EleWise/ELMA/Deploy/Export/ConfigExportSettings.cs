// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ConfigExportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Настройки экспорта</summary>
  [Serializable]
  public class ConfigExportSettings
  {
    [NonSerialized]
    private readonly IEnumerable<IConfigExportExtension> configExportExtensions;
    public Dictionary<Guid, object> CustomSettings;
    internal static ConfigExportSettings Y1SIBuEYClBZ3AJOJHJc;

    public ConfigExportSettings(Guid newFileName)
    {
      ConfigExportSettings.jdLIr6EYZM6EvmBXFxp5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.PrepareConfigExportSettings(newFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.configExportExtensions = ((ComponentManager) ConfigExportSettings.SQTpacEYu36b8bi4QRRY()).GetExtensionPoints<IConfigExportExtension>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Конструктор с дефолтными настройками выборочного экспорта
    /// </summary>
    public ConfigExportSettings()
    {
      ConfigExportSettings.jdLIr6EYZM6EvmBXFxp5();
      // ISSUE: explicit constructor call
      this.\u002Ector(((ComponentManager) ConfigExportSettings.SQTpacEYu36b8bi4QRRY()).GetExtensionPoints<IConfigExportExtension>());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Конструктор с дефолтными настройками выборочного экспорта
    /// </summary>
    public ConfigExportSettings(bool needNewFileName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(!needNewFileName ? Guid.Empty : ConfigExportSettings.KsQARWEYISTYudxTDI75());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ConfigExportSettings(
      IEnumerable<IConfigExportExtension> configExportExtensions)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.configExportExtensions = configExportExtensions;
      this.PrepareConfigExportSettings(Guid.NewGuid());
    }

    private void PrepareConfigExportSettings(Guid newFileName)
    {
      int num1 = 3;
      IEnumerator<IConfigExportExtension> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_30;
          case 2:
            this.FileName = newFileName.ToString();
            num1 = 4;
            continue;
          case 3:
            if (ConfigExportSettings.ANpdSgEYVPbtDOGlWFae(newFileName, Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 2;
              continue;
            }
            goto case 4;
          case 4:
            this.CustomSettings = new Dictionary<Guid, object>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 5:
label_33:
            this.CustomSettings.Where<KeyValuePair<Guid, object>>((Func<KeyValuePair<Guid, object>, bool>) (p => p.Key == BpmAppsExportConsts.ExportBpmAppsUid)).ForEach<KeyValuePair<Guid, object>>((Action<KeyValuePair<Guid, object>>) (p =>
            {
              if (!(p.Value is BpmAppsExportSetting appsExportSetting2))
                return;
              appsExportSetting2.TempId = this.FileName;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
            continue;
          case 6:
            try
            {
label_9:
              if (ConfigExportSettings.G7UsmnEYSyXdtKMySMoV((object) enumerator1))
                goto label_24;
              else
                goto label_10;
label_8:
              Dictionary<Guid, object>.Enumerator enumerator2;
              int num2;
              switch (num2)
              {
                case 1:
                  try
                  {
label_18:
                    if (enumerator2.MoveNext())
                      goto label_16;
                    else
                      goto label_19;
label_12:
                    KeyValuePair<Guid, object> current;
                    int num3;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          this.CustomSettings.Add(current.Key, current.Value);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                          continue;
                        case 2:
                          goto label_9;
                        case 3:
                          if (!this.CustomSettings.ContainsKey(current.Key))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
                            continue;
                          }
                          goto label_18;
                        case 4:
                          goto label_16;
                        default:
                          goto label_18;
                      }
                    }
label_16:
                    current = enumerator2.Current;
                    num3 = 3;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                    {
                      num3 = 3;
                      goto label_12;
                    }
                    else
                      goto label_12;
label_19:
                    num3 = 2;
                    goto label_12;
                  }
                  finally
                  {
                    enumerator2.Dispose();
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                      num4 = 0;
                    switch (num4)
                    {
                      default:
                    }
                  }
                case 2:
                  goto label_33;
                case 3:
                  goto label_24;
                default:
                  goto label_9;
              }
label_10:
              num2 = 2;
              goto label_8;
label_24:
              enumerator2 = enumerator1.Current.GetNewSettingObj().GetEnumerator();
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
              {
                num2 = 0;
                goto label_8;
              }
              else
                goto label_8;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      ConfigExportSettings.VT1iJMEYik6nG8k5u0Uf((object) enumerator1);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_32;
                  }
                }
              }
label_32:;
            }
          default:
            enumerator1 = this.configExportExtensions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 6 : 6;
            continue;
        }
      }
label_30:;
    }

    /// <summary>Настройки генерации манифеста</summary>
    public ElmaStoreComponentManifest Manifest
    {
      get => this.\u003CManifest\u003Ek__BackingField;
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
              this.\u003CManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <summary>Имя файла иконки</summary>
    public string IconFileName
    {
      get => this.\u003CIconFileName\u003Ek__BackingField;
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
              this.\u003CIconFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
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

    /// <summary>Иконка компонента</summary>
    public byte[] Icon
    {
      get => this.\u003CIcon\u003Ek__BackingField;
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
              this.\u003CIcon\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>Имя временного файла на сервере (uid)</summary>
    public string FileName
    {
      get => this.\u003CFileName\u003Ek__BackingField;
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
              this.\u003CFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    internal static void jdLIr6EYZM6EvmBXFxp5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object SQTpacEYu36b8bi4QRRY() => (object) ComponentManager.Current;

    internal static bool n2okBFEYvjaFvM0rj8XN() => ConfigExportSettings.Y1SIBuEYClBZ3AJOJHJc == null;

    internal static ConfigExportSettings hYKxZIEY8ffQ7pG09TK8() => ConfigExportSettings.Y1SIBuEYClBZ3AJOJHJc;

    internal static Guid KsQARWEYISTYudxTDI75() => Guid.NewGuid();

    internal static bool ANpdSgEYVPbtDOGlWFae([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool G7UsmnEYSyXdtKMySMoV([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void VT1iJMEYik6nG8k5u0Uf([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
