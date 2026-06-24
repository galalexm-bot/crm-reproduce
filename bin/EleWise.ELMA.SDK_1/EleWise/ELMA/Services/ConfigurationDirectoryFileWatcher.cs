// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ConfigurationDirectoryFileWatcher
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис, следящий за файлами из корня конфигурации</summary>
  [Service]
  public class ConfigurationDirectoryFileWatcher : DirectoryFileWatcher
  {
    internal static ConfigurationDirectoryFileWatcher GI90GNB6f7MZB5sZwhSk;

    public void Init(string configurationDirectory)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddWatchPaths(configurationDirectory);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            this.InitWatcher(configurationDirectory);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public void ConfigurationDirectoryStopWatchingFiles(bool watching = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.StopWatchingFiles(watching);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ConfigurationDirectoryFileWatcher()
    {
      ConfigurationDirectoryFileWatcher.MkjpxMB6v7dqH2J7k4Uk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Q0iNDxB6Q8mrbFqpRjyQ() => ConfigurationDirectoryFileWatcher.GI90GNB6f7MZB5sZwhSk == null;

    internal static ConfigurationDirectoryFileWatcher kNGIBdB6CgwhoEAvC5Kb() => ConfigurationDirectoryFileWatcher.GI90GNB6f7MZB5sZwhSk;

    internal static void MkjpxMB6v7dqH2J7k4Uk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
