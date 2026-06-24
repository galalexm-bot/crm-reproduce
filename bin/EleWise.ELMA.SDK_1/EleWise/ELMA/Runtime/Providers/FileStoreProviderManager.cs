// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.FileStoreProviderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>
  /// Менеджер провайдеров <see cref="T:EleWise.ELMA.Runtime.Providers.FileStoreProvider" />.
  /// Регистрирует провайдер как <see cref="T:EleWise.ELMA.Runtime.Managers.IFileManager" />
  /// </summary>
  public class FileStoreProviderManager : 
    GenericProviderManager<FileStoreProvider, IFileManager>,
    IUpdatableProviderManager
  {
    /// <summary>Строковое представление идентификатора</summary>
    public const string UID_S = "{5CEE6AEC-28C5-48C0-8D89-6A94AD14FBB2}";
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    internal static FileStoreProviderManager rIQYCEWGUaXJovT4sfh5;

    /// <summary>Uid провайдера</summary>
    public override Guid Uid => FileStoreProviderManager.UID;

    /// <summary>Имя СУБД</summary>
    public override string Name => (string) FileStoreProviderManager.yaj18sWGzULyLkIiU2OL(-812025778 ^ -812063308);

    public void UpdateConfiguration(RuntimeConfiguration configuration)
    {
      switch (1)
      {
        case 1:
          try
          {
            FileStoreProviderManager.QYtXSpWEFZMGkv0CfqSY((object) this.DefaultProvider, (object) configuration);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_1;
                case 1:
                  FileStoreProviderManager.vSsHOsWEW96uI4bOoGdi((object) Logger.GetLogger((string) FileStoreProviderManager.yaj18sWGzULyLkIiU2OL(-812025778 ^ -812115066)), FileStoreProviderManager.wBhfHfWEBoLTAQ9iWAhs((object) ex));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_13;
              }
            }
label_1:
            break;
label_13:
            break;
          }
      }
    }

    public FileStoreProviderManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FileStoreProviderManager()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FileStoreProviderManager.UID = new Guid((string) FileStoreProviderManager.yaj18sWGzULyLkIiU2OL(222162814 ^ 222065006));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object yaj18sWGzULyLkIiU2OL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CaSTLGWGsaJFKR79VtVs() => FileStoreProviderManager.rIQYCEWGUaXJovT4sfh5 == null;

    internal static FileStoreProviderManager i0PZlPWGcK7Ughwpe0kL() => FileStoreProviderManager.rIQYCEWGUaXJovT4sfh5;

    internal static void QYtXSpWEFZMGkv0CfqSY([In] object obj0, [In] object obj1) => ((FileStoreProvider) obj0).ReConfigure((RuntimeConfiguration) obj1);

    internal static object wBhfHfWEBoLTAQ9iWAhs([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void vSsHOsWEW96uI4bOoGdi([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);
  }
}
