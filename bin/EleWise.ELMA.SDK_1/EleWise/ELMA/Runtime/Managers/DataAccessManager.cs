// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.DataAccessManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Менеджер доступа к различным провайдерам данных</summary>
  public static class DataAccessManager
  {
    public static IBLOBDataManager _blobManager;
    public static ISettingsManager _settingsManager;
    public static IFileManager _fileManager;
    private static IBinaryFileStreams _binaryFileStreams;
    private static DataAccessManager TNMgIDW9Q7QpO210jpef;

    /// <summary>Менеджер данных сериализуемых объектов</summary>
    public static IBLOBDataManager BLOBManager
    {
      get
      {
        int num = 1;
        IBLOBDataManager blobManager;
        while (true)
        {
          switch (num)
          {
            case 1:
              blobManager = DataAccessManager._blobManager;
              if (blobManager == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return blobManager;
label_5:
        return DataAccessManager._blobManager = Locator.GetServiceNotNull<IBLOBDataManager>();
      }
    }

    /// <summary>Менеджер данных настроек строка-строка</summary>
    public static ISettingsManager SettingsManager
    {
      get
      {
        int num = 1;
        ISettingsManager settingsManager;
        while (true)
        {
          switch (num)
          {
            case 1:
              settingsManager = DataAccessManager._settingsManager;
              if (settingsManager == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return settingsManager;
label_5:
        return DataAccessManager._settingsManager = Locator.GetServiceNotNull<ISettingsManager>();
      }
    }

    /// <summary>Менеджер работы с файлами</summary>
    public static IFileManager FileManager
    {
      get
      {
        int num = 1;
        IFileManager fileManager;
        while (true)
        {
          switch (num)
          {
            case 1:
              fileManager = DataAccessManager._fileManager;
              if (fileManager == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return fileManager;
label_5:
        return DataAccessManager._fileManager = Locator.GetServiceNotNull<IFileManager>();
      }
    }

    /// <summary>Провайдер доступа к файлам через потоки.</summary>
    public static IBinaryFileStreams BinaryFileStreams
    {
      get
      {
        int num = 1;
        IBinaryFileStreams binaryFileStreams;
        while (true)
        {
          switch (num)
          {
            case 1:
              binaryFileStreams = DataAccessManager._binaryFileStreams;
              if (binaryFileStreams == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return binaryFileStreams;
label_5:
        return DataAccessManager._binaryFileStreams = Locator.GetServiceNotNull<IBinaryFileStreams>();
      }
    }

    internal static bool Usds4IW9CdghjULuVurV() => DataAccessManager.TNMgIDW9Q7QpO210jpef == null;

    internal static DataAccessManager b0iFB7W9vP7ookbdH7K8() => DataAccessManager.TNMgIDW9Q7QpO210jpef;
  }
}
