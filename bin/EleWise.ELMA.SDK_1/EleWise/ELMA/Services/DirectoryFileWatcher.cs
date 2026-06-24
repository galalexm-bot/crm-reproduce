// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.DirectoryFileWatcher
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Класс, следящий за файлами в папке и вычисляющий их хэш
  /// </summary>
  public abstract class DirectoryFileWatcher
  {
    private string watchRoot;
    private FileSystemWatcher filesWatcher;
    private FileSystemWatcher directoriesWatcher;
    private bool needJointWatchPath;
    private string jointWatchPath;
    private readonly ConcurrentHashSet<string> watchPaths;
    private readonly ConcurrentHashSet<string> specificWatchPaths;
    private readonly ConcurrentDictionary<string, bool> existsWatchPaths;
    private readonly ConcurrentDictionary<string, ConcurrentHashSet<string>> existsFiles;
    public EventHandler<FileWatcherEventArgs> FileChanged;
    public EventHandler<FileWatcherEventArgs> FileAdded;
    public EventHandler<FileWatcherEventArgs> FileDeleted;
    public EventHandler<FileWatcherEventArgs> ExistsFilesAdded;
    public EventHandler<FileWatcherEventArgs> ExistsFilesDeleted;
    private static DirectoryFileWatcher w76uHNBH46nqSpgbY7g3;

    /// <summary>Конструктор</summary>
    protected DirectoryFileWatcher()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.needJointWatchPath = true;
      this.watchPaths = new ConcurrentHashSet<string>();
      this.specificWatchPaths = new ConcurrentHashSet<string>();
      this.existsWatchPaths = new ConcurrentDictionary<string, bool>((IEqualityComparer<string>) DirectoryFileWatcher.d0qmXwBHAdPh87ExleVQ());
      this.existsFiles = new ConcurrentDictionary<string, ConcurrentHashSet<string>>((IEqualityComparer<string>) DirectoryFileWatcher.d0qmXwBHAdPh87ExleVQ());
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="watchRoot">Всегда существующая папка, с которой начинать слежение за файлами</param>
    protected DirectoryFileWatcher(string watchRoot)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.needJointWatchPath = true;
      this.watchPaths = new ConcurrentHashSet<string>();
      this.specificWatchPaths = new ConcurrentHashSet<string>();
      this.existsWatchPaths = new ConcurrentDictionary<string, bool>((IEqualityComparer<string>) DirectoryFileWatcher.d0qmXwBHAdPh87ExleVQ());
      this.existsFiles = new ConcurrentDictionary<string, ConcurrentHashSet<string>>((IEqualityComparer<string>) DirectoryFileWatcher.d0qmXwBHAdPh87ExleVQ());
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.InitWatcher(watchRoot);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Инициализировать наблюдение за папкой</summary>
    /// <param name="watchRoot">Всегда существующая папка, с которой начинать слежение за файлами</param>
    protected void InitWatcher([NotNull] string watchRoot)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              if (watchRoot != null)
              {
                if (DirectoryFileWatcher.pp2vJGBHxiq1Y5EBmcLh((object) watchRoot, DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(--1333735954 ^ 1333734756)))
                {
                  num2 = 9;
                  continue;
                }
                goto case 4;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                continue;
              }
            case 3:
              DirectoryFileWatcher.ONByoeBHlvQMc1V6mmS8((object) this.directoriesWatcher, (object) new FileSystemEventHandler(this.PathWatcher));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 14 : 8;
              continue;
            case 4:
              watchRoot = (string) DirectoryFileWatcher.girTMKBH0uMVVyDW2V7c((object) watchRoot, DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(1218962250 ^ 1218968636));
              num2 = 10;
              continue;
            case 5:
              this.filesWatcher.Deleted += new FileSystemEventHandler(this.PathWatcher);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            case 6:
              goto label_15;
            case 7:
              goto label_16;
            case 8:
              FileSystemWatcher fileSystemWatcher1 = new FileSystemWatcher(watchRoot);
              fileSystemWatcher1.IncludeSubdirectories = true;
              DirectoryFileWatcher.AUGOrDBHmQxo7r0Tce4l((object) fileSystemWatcher1, this.watchPaths.Any<string>() || this.specificWatchPaths.Any<string>());
              DirectoryFileWatcher.wR2mFhBHyMEjQXV4skQK((object) fileSystemWatcher1, NotifyFilters.FileName | NotifyFilters.LastWrite);
              this.filesWatcher = fileSystemWatcher1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 12;
              continue;
            case 9:
            case 10:
              this.watchRoot = watchRoot;
              num2 = 8;
              continue;
            case 11:
              FileSystemWatcher fileSystemWatcher2 = new FileSystemWatcher(watchRoot);
              DirectoryFileWatcher.aZRj2jBHds7iSZOgdK4U((object) fileSystemWatcher2, true);
              DirectoryFileWatcher.AUGOrDBHmQxo7r0Tce4l((object) fileSystemWatcher2, this.watchPaths.Any<string>() || this.specificWatchPaths.Any<string>());
              DirectoryFileWatcher.wR2mFhBHyMEjQXV4skQK((object) fileSystemWatcher2, NotifyFilters.DirectoryName);
              this.directoriesWatcher = fileSystemWatcher2;
              num2 = 13;
              continue;
            case 12:
              DirectoryFileWatcher.kA9hx6BHMlnyaooqrPl2((object) this.filesWatcher, (object) new FileSystemEventHandler(this.PathWatcher));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 6 : 5;
              continue;
            case 13:
              goto label_12;
            case 14:
              DirectoryFileWatcher.CmawHpBH9YIj64XEuGWC((object) this.directoriesWatcher, (object) new RenamedEventHandler(this.PathWatcher));
              num2 = 7;
              continue;
            default:
              DirectoryFileWatcher.CmawHpBH9YIj64XEuGWC((object) this.filesWatcher, (object) new RenamedEventHandler(this.PathWatcher));
              num2 = 11;
              continue;
          }
        }
label_12:
        DirectoryFileWatcher.OOQkZSBHJPuvGe6mMyVt((object) this.directoriesWatcher, (object) new FileSystemEventHandler(this.PathWatcher));
        num1 = 3;
        continue;
label_15:
        DirectoryFileWatcher.OOQkZSBHJPuvGe6mMyVt((object) this.filesWatcher, (object) new FileSystemEventHandler(this.PathWatcher));
        num1 = 5;
      }
label_5:
      return;
label_16:;
    }

    public string WatchRoot => this.watchRoot;

    /// <summary>Остановить наблюдение за файлами</summary>
    /// <param name="watching"> True - остановить, false - возобновить</param>
    protected void StopWatchingFiles(bool watching = true)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_4;
            case 2:
              if (watching)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
                continue;
              }
              DirectoryFileWatcher.AUGOrDBHmQxo7r0Tce4l((object) this.filesWatcher, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_4:
        DirectoryFileWatcher.AUGOrDBHmQxo7r0Tce4l((object) this.filesWatcher, false);
        num1 = 3;
      }
label_7:
      return;
label_3:
      return;
label_9:;
    }

    /// <summary>
    /// Инициализировать списко подпапок, в которых нужно следить за файлами после их создания
    /// </summary>
    /// <param name="paths"></param>
    public void AddWatchPaths(params string[] paths)
    {
      int num1 = 39;
      while (true)
      {
        int num2 = num1;
        string[] strArray;
        while (true)
        {
          // ISSUE: variable of a compiler-generated type
          DirectoryFileWatcher.\u003C\u003Ec__DisplayClass20_0 cDisplayClass200;
          string key;
          int index;
          int num3;
          // ISSUE: variable of a compiler-generated type
          DirectoryFileWatcher.\u003C\u003Ec__DisplayClass20_1 cDisplayClass201;
          string str;
          switch (num2)
          {
            case 1:
            case 5:
              ++num3;
              num2 = 28;
              continue;
            case 2:
              if (this.jointWatchPath != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 20 : 17;
                continue;
              }
              goto case 13;
            case 3:
              // ISSUE: reference to a compiler-generated field
              if (!cDisplayClass200.addPath.StartsWith(this.watchRoot, StringComparison.InvariantCultureIgnoreCase))
              {
                num2 = 17;
                continue;
              }
              goto case 21;
            case 4:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.ExistsFilesAdded((object) this, new FileWatcherEventArgs(cDisplayClass201.CS\u0024\u003C\u003E8__locals1.addPath, (string) null, FileWatcherChangeTypes.ExistsFilesAdded));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 7;
              continue;
            case 6:
              goto label_11;
            case 7:
            case 40:
              // ISSUE: reference to a compiler-generated method
              key = this.watchPaths.FirstOrDefault<string>(new Func<string, bool>(cDisplayClass200.\u003CAddWatchPaths\u003Eb__0));
              num2 = 12;
              continue;
            case 8:
            case 14:
            case 16:
            case 22:
            case 23:
              if (!this.filesWatcher.EnableRaisingEvents)
              {
                num2 = 24;
                continue;
              }
              goto case 17;
            case 9:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass201.added = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 29 : 13;
              continue;
            case 10:
              this.jointWatchPath = (string) DirectoryFileWatcher.jJonhbBH5nInkTuURLLi((object) this.jointWatchPath, num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 10 : 11;
              continue;
            case 11:
            case 32:
            case 33:
              this.needJointWatchPath &= DirectoryFileWatcher.d9d6D5BHLIZ9H1WVUyAl((object) this.jointWatchPath, (object) this.watchRoot);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 5 : 7;
              continue;
            case 12:
              if (key == null)
              {
                num2 = 14;
                continue;
              }
              goto case 15;
            case 13:
              // ISSUE: reference to a compiler-generated field
              this.jointWatchPath = cDisplayClass200.addPath;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 30 : 32;
              continue;
            case 15:
              // ISSUE: reference to a compiler-generated field
              if (!this.existsFiles.TryGetValue(key, out cDisplayClass200.files))
              {
                num2 = 22;
                continue;
              }
              goto case 42;
            case 17:
            case 27:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 18 : 3;
              continue;
            case 18:
            case 43:
              if (index >= strArray.Length)
              {
                num2 = 44;
                continue;
              }
              break;
            case 19:
              // ISSUE: reference to a compiler-generated field
              if (!cDisplayClass201.added)
              {
                num2 = 16;
                continue;
              }
              goto case 31;
            case 20:
            case 26:
              num3 = 0;
              num2 = 37;
              continue;
            case 21:
              // ISSUE: reference to a compiler-generated field
              this.watchPaths.Add(cDisplayClass200.addPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 25 : 22;
              continue;
            case 24:
              DirectoryFileWatcher.AUGOrDBHmQxo7r0Tce4l((object) this.filesWatcher, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 32 : 34;
              continue;
            case 25:
              if (!this.needJointWatchPath)
              {
                num2 = 40;
                continue;
              }
              goto case 2;
            case 28:
            case 37:
              // ISSUE: reference to a compiler-generated field
              if (num3 >= DirectoryFileWatcher.GsD5k7BHYNQluQM9QZd0(DirectoryFileWatcher.TeMw8iBHjMZNsgchw82i((object) cDisplayClass200.addPath), DirectoryFileWatcher.TeMw8iBHjMZNsgchw82i((object) this.jointWatchPath)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 28 : 33;
                continue;
              }
              goto case 30;
            case 29:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              this.existsFiles.GetOrAdd(cDisplayClass201.CS\u0024\u003C\u003E8__locals1.addPath, new Func<string, ConcurrentHashSet<string>>(cDisplayClass201.\u003CAddWatchPaths\u003Eb__1));
              num2 = 19;
              continue;
            case 30:
              // ISSUE: reference to a compiler-generated field
              if (DirectoryFileWatcher.lrkayKBHgleQTRMSTeOJ(DirectoryFileWatcher.d0qmXwBHAdPh87ExleVQ(), (object) DirectoryFileWatcher.pr3nKRBHrQve9Cnhlt6m((object) cDisplayClass200.addPath, num3), (object) DirectoryFileWatcher.pr3nKRBHrQve9Cnhlt6m((object) this.jointWatchPath, num3)))
              {
                num2 = 5;
                continue;
              }
              goto case 10;
            case 31:
              if (this.ExistsFilesAdded == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 23 : 23;
                continue;
              }
              goto case 4;
            case 34:
              DirectoryFileWatcher.AUGOrDBHmQxo7r0Tce4l((object) this.directoriesWatcher, true);
              num2 = 27;
              continue;
            case 35:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass200.addPath = !DirectoryFileWatcher.pp2vJGBHxiq1Y5EBmcLh((object) str, DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(1574260816 ^ 1574260518)) ? (string) DirectoryFileWatcher.girTMKBH0uMVVyDW2V7c((object) str, DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(-2106517564 ^ -2106521422)) : str;
              num2 = 3;
              continue;
            case 36:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass201.CS\u0024\u003C\u003E8__locals1 = cDisplayClass200;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 7 : 9;
              continue;
            case 38:
              goto label_38;
            case 39:
              if (this.watchRoot != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 10 : 38;
                continue;
              }
              goto label_45;
            case 41:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 43 : 16;
              continue;
            case 42:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass201 = new DirectoryFileWatcher.\u003C\u003Ec__DisplayClass20_1();
              num2 = 36;
              continue;
            case 44:
              goto label_49;
            case 45:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass200 = new DirectoryFileWatcher.\u003C\u003Ec__DisplayClass20_0();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 35 : 20;
              continue;
          }
          str = strArray[index];
          num2 = 45;
        }
label_38:
        strArray = paths;
        num1 = 41;
      }
label_11:
      return;
label_49:
      return;
label_45:;
    }

    /// <summary>
    /// Инициализировать список конкретных подпапок, в которых нужно следить за файлами после их создания
    /// Для этого списка не учитываются изменения в их подпапках
    /// </summary>
    /// <param name="paths">Массив путей до папки</param>
    public void AddSpecificWatchPaths(params string[] paths)
    {
      int num = 9;
      while (true)
      {
        int index1;
        string str1;
        string str2;
        int index2;
        string[] strArray;
        object obj;
        switch (num)
        {
          case 1:
          case 3:
          case 33:
            this.needJointWatchPath &= DirectoryFileWatcher.d9d6D5BHLIZ9H1WVUyAl((object) this.jointWatchPath, (object) this.watchRoot);
            num = 28;
            continue;
          case 2:
            index2 = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 27 : 16;
            continue;
          case 4:
            obj = DirectoryFileWatcher.girTMKBH0uMVVyDW2V7c((object) str2, (object) Path.DirectorySeparatorChar.ToString());
            break;
          case 5:
          case 32:
            if (index1 < DirectoryFileWatcher.GsD5k7BHYNQluQM9QZd0(str1.Length, this.jointWatchPath.Length))
            {
              num = 22;
              continue;
            }
            goto case 1;
          case 6:
          case 10:
          case 24:
            ++index2;
            num = 15;
            continue;
          case 7:
            this.filesWatcher.EnableRaisingEvents = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 26 : 13;
            continue;
          case 8:
            strArray = paths;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 2;
            continue;
          case 9:
            if (this.watchRoot != null)
            {
              num = 8;
              continue;
            }
            goto label_35;
          case 11:
          case 23:
            str2 = strArray[index2];
            num = 13;
            continue;
          case 12:
            goto label_36;
          case 13:
            if (DirectoryFileWatcher.pp2vJGBHxiq1Y5EBmcLh((object) str2, (object) Path.DirectorySeparatorChar.ToString()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 20 : 0;
              continue;
            }
            goto case 4;
          case 14:
            if (!str1.StartsWith(this.watchRoot, StringComparison.InvariantCultureIgnoreCase))
            {
              num = 24;
              continue;
            }
            goto case 17;
          case 15:
          case 27:
            if (index2 < strArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 23 : 9;
              continue;
            }
            goto label_30;
          case 16:
            index1 = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 32 : 0;
            continue;
          case 17:
            this.specificWatchPaths.Add(str1);
            num = 29;
            continue;
          case 18:
            goto label_14;
          case 19:
          case 31:
            ++index1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 5 : 5;
            continue;
          case 20:
            obj = (object) str2;
            break;
          case 21:
            this.jointWatchPath = str1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
            continue;
          case 25:
            if (this.jointWatchPath == null)
            {
              num = 21;
              continue;
            }
            goto case 16;
          case 26:
            DirectoryFileWatcher.AUGOrDBHmQxo7r0Tce4l((object) this.directoriesWatcher, true);
            num = 10;
            continue;
          case 28:
            if (DirectoryFileWatcher.oxwsB1BHURjtdVX4j2jI((object) this.filesWatcher))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 5 : 6;
              continue;
            }
            goto case 7;
          case 29:
            if (this.needJointWatchPath)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 18 : 25;
              continue;
            }
            goto case 28;
          case 30:
            this.jointWatchPath = (string) DirectoryFileWatcher.jJonhbBH5nInkTuURLLi((object) this.jointWatchPath, index1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 3;
            continue;
          default:
            if (DirectoryFileWatcher.lrkayKBHgleQTRMSTeOJ(DirectoryFileWatcher.d0qmXwBHAdPh87ExleVQ(), (object) str1[index1], (object) DirectoryFileWatcher.pr3nKRBHrQve9Cnhlt6m((object) this.jointWatchPath, index1)))
            {
              num = 31;
              continue;
            }
            goto case 30;
        }
        str1 = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 13 : 14;
      }
label_36:
      return;
label_14:
      return;
label_30:
      return;
label_35:;
    }

    private ConcurrentHashSet<string> GetExistsFiles4WatchPath(
      string watchPath,
      Action<ConcurrentHashSet<string>> existsFilesAction = null)
    {
      return this.GetExistsFiles4WatchPath(watchPath, existsFilesAction == null ? (Action<ConcurrentHashSet<string>, bool>) null : (Action<ConcurrentHashSet<string>, bool>) ((existsFiles, added) =>
      {
        if (added)
          return;
        existsFilesAction(existsFiles);
      }));
    }

    private ConcurrentHashSet<string> GetExistsFiles4WatchPath(
      string watchPath,
      Action<ConcurrentHashSet<string>, bool> existsFilesAction)
    {
      bool added = false;
      string str = watchPath.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675510583)) ? watchPath : watchPath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317796954);
      ConcurrentHashSet<string> orAdd = this.existsFiles.GetOrAdd(str, (Func<string, ConcurrentHashSet<string>>) (p =>
      {
        added = true;
        return this.PathFiles(p, (string) null);
      }));
      if (added && this.ExistsFilesAdded != null)
        this.ExistsFilesAdded((object) this, new FileWatcherEventArgs(str, (string) null, FileWatcherChangeTypes.ExistsFilesAdded));
      if (existsFilesAction != null)
        existsFilesAction(orAdd, added);
      return orAdd;
    }

    /// <summary>Проверить существование файла в нужной подпапке</summary>
    /// <param name="watchPath"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public bool FileExists(string watchPath, string path) => this.GetExistsFiles4WatchPath(watchPath).Contains(path);

    /// <summary>Возращает все файлы в нужной подпапке</summary>
    /// <param name="watchPath"></param>
    /// <returns></returns>
    public IReadOnlyCollection<string> ExistsFiles(string watchPath) => (IReadOnlyCollection<string>) this.GetExistsFiles4WatchPath(watchPath);

    private ConcurrentHashSet<string> PathFiles(string watchPath, string dir)
    {
      if (!this.existsWatchPaths.GetOrAdd(watchPath, (Func<string, bool>) (s => this.PathPrefixes(s, dir = dir ?? watchPath))))
      {
        this.watchPaths.Where<string>((Func<string, bool>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (!DirectoryFileWatcher.\u003C\u003Ec__DisplayClass26_0.JZb6sqQTlt4N320DomR3((object) watchPath, (object) p, StringComparison.InvariantCultureIgnoreCase))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              default:
                goto label_2;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          return DirectoryFileWatcher.\u003C\u003Ec__DisplayClass26_0.m9fF22QTr7hvNIKQm3yP((object) p, (object) watchPath, StringComparison.InvariantCultureIgnoreCase);
label_3:
          return false;
        })).Each<string>((Action<string>) (p =>
        {
          int num1 = 3;
          while (true)
          {
            int num2 = num1;
            bool added;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  this.ExistsFilesAdded((object) this, new FileWatcherEventArgs(p, (string) null, FileWatcherChangeTypes.ExistsFilesAdded));
                  num2 = 4;
                  continue;
                case 2:
                  goto label_5;
                case 3:
                  num2 = 2;
                  continue;
                case 4:
                  goto label_3;
                case 5:
                  this.existsFiles.GetOrAdd(p, (Func<string, ConcurrentHashSet<string>>) (s =>
                  {
                    added = true;
                    return new ConcurrentHashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
                  }));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 6 : 2;
                  continue;
                case 6:
                  if (added)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_12;
                default:
                  if (this.ExistsFilesAdded != null)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
                    continue;
                  }
                  goto label_13;
              }
            }
label_5:
            added = false;
            num1 = 5;
          }
label_3:
          return;
label_12:
          return;
label_13:;
        }));
        return new ConcurrentHashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
      }
      dir = dir ?? watchPath;
      string[] files = Directory.GetFiles(dir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082386248), SearchOption.AllDirectories);
      this.watchPaths.Where<string>((Func<string, bool>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!watchPath.Equals(p, StringComparison.InvariantCultureIgnoreCase))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return DirectoryFileWatcher.\u003C\u003Ec__DisplayClass26_0.m9fF22QTr7hvNIKQm3yP((object) p, (object) watchPath, StringComparison.InvariantCultureIgnoreCase);
label_5:
        return false;
      })).Each<string>((Action<string>) (p =>
      {
        int num3 = 5;
        while (true)
        {
          int num4 = num3;
          bool added;
          // ISSUE: variable of a compiler-generated type
          DirectoryFileWatcher.\u003C\u003Ec__DisplayClass26_0 cDisplayClass260;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_11;
              case 2:
                if (added)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 3;
                  continue;
                }
                goto label_3;
              case 3:
                if (this.ExistsFilesAdded == null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
                  continue;
                }
                goto case 6;
              case 4:
                cDisplayClass260 = this;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                continue;
              case 5:
                goto label_8;
              case 6:
                this.ExistsFilesAdded((object) this, new FileWatcherEventArgs(p, (string) null, FileWatcherChangeTypes.ExistsFilesAdded));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 8 : 8;
                continue;
              case 7:
                this.existsFiles.GetOrAdd(p, (Func<string, ConcurrentHashSet<string>>) (s =>
                {
                  added = true;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  return new ConcurrentHashSet<string>(((IEnumerable<string>) cDisplayClass260.files).Where<string>((Func<string, bool>) (f => DirectoryFileWatcher.\u003C\u003Ec__DisplayClass26_3.U744ymQkWri7aWWs2G4T((object) f, (object) s, StringComparison.InvariantCultureIgnoreCase))), (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
                }));
                num4 = 2;
                continue;
              case 8:
                goto label_14;
              default:
                added = false;
                num4 = 7;
                continue;
            }
          }
label_8:
          num3 = 4;
        }
label_11:
        return;
label_14:
        return;
label_3:;
      }));
      return new ConcurrentHashSet<string>((IEnumerable<string>) files, (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
    }

    private bool PathPrefixes(string phisicalPathPrefix, string dir)
    {
      int num = 1;
      string str1;
      while (true)
      {
        switch (num)
        {
          case 1:
            str1 = dir;
            if (str1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_5:
      string str2 = phisicalPathPrefix;
label_6:
      return DirectoryFileWatcher.sO98u8BHs5uhuIVGKrIY((object) str2);
label_2:
      str2 = str1;
      goto label_6;
    }

    private bool PathStartsWith(string path, string startsWithPath)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!DirectoryFileWatcher.xWGB3kBHclGiKlNnhxPD((object) startsWithPath, (object) path, StringComparison.InvariantCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (DirectoryFileWatcher.xWGB3kBHclGiKlNnhxPD((object) startsWithPath, (object) (path + (string) DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(-1886646897 ^ -1886645511)), StringComparison.InvariantCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 0;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return path.StartsWith(startsWithPath, StringComparison.InvariantCultureIgnoreCase);
label_3:
      return true;
    }

    private bool PathDirEqualsWith(string path, string otherPath) => DirectoryFileWatcher.xWGB3kBHclGiKlNnhxPD(DirectoryFileWatcher.t7ONpHBHzW8Gpkdoh9JC((object) new FileInfo(path)), (object) (string) DirectoryFileWatcher.t7ONpHBHzW8Gpkdoh9JC((object) new FileInfo(otherPath)), StringComparison.InvariantCultureIgnoreCase);

    private void PathWatcher(object sender, FileSystemEventArgs e)
    {
      switch (1)
      {
        case 1:
          try
          {
            FileSystemWatcher fileSystemWatcher = (FileSystemWatcher) sender;
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
              num = 1;
            WatcherChangeTypes changeType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  changeType = e.ChangeType;
                  num = 5;
                  continue;
                case 2:
                  this.PathAdded(DirectoryFileWatcher.sfRTxLBAB7PWPdjxHSGZ((object) fileSystemWatcher), (string) DirectoryFileWatcher.slU8rRBAFGDK4fja7QMp((object) e), false);
                  num = 14;
                  continue;
                case 3:
                  goto label_33;
                case 4:
                  this.PathDeleted(DirectoryFileWatcher.sfRTxLBAB7PWPdjxHSGZ((object) fileSystemWatcher), e.FullPath);
                  num = 11;
                  continue;
                case 5:
                  switch (changeType)
                  {
                    case WatcherChangeTypes.Created:
                      goto label_21;
                    case WatcherChangeTypes.Deleted:
                      goto label_23;
                    case WatcherChangeTypes.Created | WatcherChangeTypes.Deleted:
                      goto label_29;
                    case WatcherChangeTypes.Changed:
                      goto label_11;
                    default:
                      num = 7;
                      continue;
                  }
                case 6:
                  goto label_25;
                case 7:
                  if (changeType != WatcherChangeTypes.Renamed)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 6 : 18;
                    continue;
                  }
                  goto case 10;
                case 8:
label_23:
                  if (this.CheckPathNeedProcess((string) DirectoryFileWatcher.slU8rRBAFGDK4fja7QMp((object) e)))
                  {
                    num = 4;
                    continue;
                  }
                  goto label_26;
                case 9:
label_11:
                  if (!this.CheckPathNeedProcess((string) DirectoryFileWatcher.slU8rRBAFGDK4fja7QMp((object) e)))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 2;
                    continue;
                  }
                  goto case 16;
                case 10:
                  if (!this.CheckPathNeedProcess(((RenamedEventArgs) e).OldFullPath))
                  {
                    num = 17;
                    continue;
                  }
                  goto case 19;
                case 11:
                  goto label_20;
                case 12:
                  goto label_13;
                case 13:
                  goto label_6;
                case 14:
                  goto label_5;
                case 15:
label_21:
                  if (this.CheckPathNeedProcess(e.FullPath))
                  {
                    num = 2;
                    continue;
                  }
                  goto label_28;
                case 16:
                  this.PathChanged(e.FullPath);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 6 : 6;
                  continue;
                case 18:
                  goto label_1;
                case 19:
                  this.PathDeleted(fileSystemWatcher.NotifyFilter, (string) DirectoryFileWatcher.rRJveTBAWr2iIxysJlNc((object) (RenamedEventArgs) e));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                  continue;
                case 20:
                  this.PathAdded(DirectoryFileWatcher.sfRTxLBAB7PWPdjxHSGZ((object) fileSystemWatcher), (string) DirectoryFileWatcher.slU8rRBAFGDK4fja7QMp((object) e), true);
                  num = 13;
                  continue;
                default:
                  if (!this.CheckPathNeedProcess((string) DirectoryFileWatcher.slU8rRBAFGDK4fja7QMp((object) e)))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 6 : 12;
                    continue;
                  }
                  goto case 20;
              }
            }
label_33:
            break;
label_25:
            break;
label_20:
            break;
label_13:
            break;
label_6:
            break;
label_5:
            break;
label_1:
            break;
label_29:
            break;
label_28:
            break;
label_26:
            break;
          }
          catch (IOException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_40;
                case 1:
                  DirectoryFileWatcher.egteL6BAbZnlm0TkpxrV((object) Logger.Log, DirectoryFileWatcher.h2gemjBAotF9QU1h5Zn1(DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(964881585 - -1459193222 ^ -1870845187), DirectoryFileWatcher.slU8rRBAFGDK4fja7QMp((object) e)), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_41;
              }
            }
label_40:
            break;
label_41:
            break;
          }
      }
    }

    private bool CheckPathNeedProcess(string fullPath)
    {
      int num = 4;
      DirectoryFileWatcher directoryFileWatcher;
      string fullPath1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!this.needJointWatchPath)
            {
              num = 5;
              continue;
            }
            break;
          case 3:
            directoryFileWatcher = this;
            num = 6;
            continue;
          case 4:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 3;
            continue;
          case 5:
            goto label_6;
          case 6:
            fullPath1 = fullPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 2;
            continue;
        }
        if (!this.PathStartsWith(fullPath1, this.jointWatchPath))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
        else
          goto label_6;
      }
label_5:
      return this.specificWatchPaths.Any<string>((Func<string, bool>) (t => directoryFileWatcher.PathDirEqualsWith(t, fullPath1)));
label_6:
      return true;
    }

    private void PathChanged(string path)
    {
      int num1 = 7;
      List<string> list;
      DirectoryFileWatcher sender;
      string path1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_11;
          case 3:
            if (DirectoryFileWatcher.T21Yy9BAGDGObWc3hxvC((object) new FileInfo(path1)))
            {
              num1 = 8;
              continue;
            }
            goto label_2;
          case 4:
            goto label_7;
          case 5:
            list = this.watchPaths.Where<string>((Func<string, bool>) (p => sender.PathStartsWith(path1, p))).Union<string>(this.specificWatchPaths.Where<string>((Func<string, bool>) (p => sender.PathDirEqualsWith(path1, p)))).ToList<string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 9 : 4;
            continue;
          case 6:
            sender = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 7:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 4 : 6;
            continue;
          case 8:
            Action<ConcurrentHashSet<string>> action;
            list.ForEach((Action<string>) (watchPath =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (sender.FileChanged != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_2;
                  case 2:
                    DirectoryFileWatcher directoryFileWatcher = sender;
                    string watchPath1 = watchPath;
                    Action<ConcurrentHashSet<string>> action1 = action;
                    Action<ConcurrentHashSet<string>> existsFilesAction = action1 == null ? (action = (Action<ConcurrentHashSet<string>>) (existsFiles => existsFiles.Add(path1))) : action1;
                    directoryFileWatcher.GetExistsFiles4WatchPath(watchPath1, existsFilesAction);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
                    continue;
                  case 3:
                    goto label_7;
                  default:
                    sender.FileChanged((object) sender, new FileWatcherEventArgs(watchPath, path1, FileWatcherChangeTypes.FileChanged));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 3;
                    continue;
                }
              }
label_7:
              return;
label_2:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
            continue;
          case 9:
            if (DirectoryFileWatcher.gks8TXBAhCWoEYqUBPmn((object) list) != 0)
            {
              list.Sort();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 3;
              continue;
            }
            num1 = 4;
            continue;
          default:
            path1 = path;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 4 : 5;
            continue;
        }
      }
label_3:
      return;
label_11:
      return;
label_7:
      return;
label_2:;
    }

    private void UpdateExistsWatchPaths(string watchPath, bool needValue)
    {
      int num1 = 6;
      bool flag;
      DirectoryFileWatcher sender;
      bool needValue1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_6;
          case 1:
            goto label_10;
          case 2:
            goto label_2;
          case 3:
            needValue1 = needValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 4;
            continue;
          case 4:
            if (!this.existsWatchPaths.TryGetValue(watchPath, out flag))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 5:
            sender = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 0;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 4 : 5;
            continue;
          case 7:
            if (flag != needValue1)
            {
              this.existsWatchPaths.AddOrUpdate(watchPath, (Func<string, bool>) (s => sender.PathPrefixes(s, (string) null)), (Func<string, bool, bool>) ((s, b) =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (b == needValue1)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_6;
                    default:
                      goto label_5;
                  }
                }
label_5:
                return b;
label_6:
                int num3 = sender.PathPrefixes(s, (string) null) ? 1 : 0;
                if (num3 == (b ? 1 : 0))
                  return num3 != 0;
                if (!sender.existsFiles.TryRemove(s, out ConcurrentHashSet<string> _))
                  return num3 != 0;
                if (sender.ExistsFilesDeleted == null)
                  return num3 != 0;
                sender.ExistsFilesDeleted((object) sender, new FileWatcherEventArgs(s, (string) null, FileWatcherChangeTypes.ExistsFilesDeleted));
                return num3 != 0;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 2;
            continue;
          default:
            goto label_13;
        }
      }
label_6:
      return;
label_10:
      return;
label_2:
      return;
label_13:;
    }

    private void PathAdded(NotifyFilters notifyFilters, string path, bool subdirs)
    {
      int num = 15;
      List<string> list;
      // ISSUE: variable of a compiler-generated type
      DirectoryFileWatcher.\u003C\u003Ec__DisplayClass34_0 cDisplayClass340;
      // ISSUE: variable of a compiler-generated type
      DirectoryFileWatcher.\u003C\u003Ec__DisplayClass34_1 cDisplayClass341;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            cDisplayClass340.FileNames = new Func<IList<string>>(cDisplayClass340.\u003CPathAdded\u003Eb__2);
            num = 8;
            continue;
          case 2:
            if (list.Count != 0)
            {
              list.Sort();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            }
            num = 3;
            continue;
          case 3:
            if (subdirs)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 12 : 9;
              continue;
            }
            goto label_23;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            this.watchPaths.Where<string>(new Func<string, bool>(cDisplayClass341.\u003CPathAdded\u003Eb__4)).Union<string>(this.specificWatchPaths.Where<string>(new Func<string, bool>(cDisplayClass341.\u003CPathAdded\u003Eb__5))).Each<string>(new Action<string>(cDisplayClass341.CS\u0024\u003C\u003E8__locals1.\u003CPathAdded\u003Eb__6));
            num = 11;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass340.notifyFilters = notifyFilters;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 13 : 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass341.CS\u0024\u003C\u003E8__locals1 = cDisplayClass340;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 16;
            continue;
          case 7:
            goto label_3;
          case 8:
            // ISSUE: reference to a compiler-generated method
            list.ForEach(new Action<string>(cDisplayClass340.\u003CPathAdded\u003Eb__3));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 3;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass340.path = path;
            num = 5;
            continue;
          case 10:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass341 = new DirectoryFileWatcher.\u003C\u003Ec__DisplayClass34_1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 4 : 6;
            continue;
          case 11:
            goto label_2;
          case 12:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass340.notifyFilters == NotifyFilters.DirectoryName)
            {
              num = 10;
              continue;
            }
            goto label_24;
          case 13:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            list = this.watchPaths.Where<string>(new Func<string, bool>(cDisplayClass340.\u003CPathAdded\u003Eb__0)).Union<string>(this.specificWatchPaths.Where<string>(new Func<string, bool>(cDisplayClass340.\u003CPathAdded\u003Eb__1))).ToList<string>();
            num = 2;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass340.\u003C\u003E4__this = this;
            num = 9;
            continue;
          case 15:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass340 = new DirectoryFileWatcher.\u003C\u003Ec__DisplayClass34_0();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 14 : 4;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            cDisplayClass341.searchPath = cDisplayClass341.CS\u0024\u003C\u003E8__locals1.path.EndsWith((string) DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(1232639661 >> 3 ^ 154078627)) ? cDisplayClass341.CS\u0024\u003C\u003E8__locals1.path : (string) DirectoryFileWatcher.girTMKBH0uMVVyDW2V7c((object) cDisplayClass341.CS\u0024\u003C\u003E8__locals1.path, DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(-218496594 ^ -218489128));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass340.fileNames = (IList<string>) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:
      return;
label_2:
      return;
label_23:
      return;
label_24:;
    }

    private void PathDeleted(NotifyFilters notifyFilters, string path)
    {
      int num1 = 12;
      List<string> list1;
      List<string> list2;
      DirectoryFileWatcher sender;
      string searchPath;
      string path1;
      NotifyFilters notifyFilters1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_9;
          case 1:
            if (list2.Count != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 2;
              continue;
            }
            goto label_2;
          case 2:
            list1 = this.watchPaths.Where<string>((Func<string, bool>) (p => sender.PathStartsWith(p, searchPath))).Union<string>(this.specificWatchPaths.Where<string>((Func<string, bool>) (p => sender.PathDirEqualsWith(p, searchPath)))).ToList<string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 9 : 3;
            continue;
          case 3:
            DirectoryFileWatcher.OgqUcdBAErHZhX1Wh9q8((object) list2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 13 : 10;
            continue;
          case 4:
            goto label_22;
          case 5:
            goto label_6;
          case 6:
            list2 = this.watchPaths.Where<string>((Func<string, bool>) (p => sender.PathStartsWith(path1, p))).Union<string>(this.specificWatchPaths.Where<string>((Func<string, bool>) (p => sender.PathDirEqualsWith(p, searchPath)))).ToList<string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 7:
            searchPath = !DirectoryFileWatcher.pp2vJGBHxiq1Y5EBmcLh((object) path1, DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(964881585 - -1459193222 ^ -1870893759)) ? (string) DirectoryFileWatcher.girTMKBH0uMVVyDW2V7c((object) path1, DirectoryFileWatcher.pgl7mGBH7UWGI04WDq3E(1253244298 - 1829393894 ^ -576145198)) : path1;
            num1 = 2;
            continue;
          case 8:
            list1.Distinct<string>().Each<string>((Action<string>) (watchPath =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    sender.UpdateExistsWatchPaths(watchPath, false);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 4;
            continue;
          case 9:
            if (DirectoryFileWatcher.gks8TXBAhCWoEYqUBPmn((object) list1) == 0)
            {
              num1 = 6;
              continue;
            }
            if (notifyFilters1 == NotifyFilters.DirectoryName)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 8 : 2;
              continue;
            }
            goto label_5;
          case 10:
            notifyFilters1 = notifyFilters;
            num1 = 7;
            continue;
          case 11:
            sender = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 13 : 14;
            continue;
          case 12:
            num1 = 11;
            continue;
          case 13:
            Action<ConcurrentHashSet<string>> action;
            list2.ForEach((Action<string>) (watchPath =>
            {
              int num5 = 8;
              while (true)
              {
                int num6 = num5;
                string watchPath1;
                // ISSUE: variable of a compiler-generated type
                DirectoryFileWatcher.\u003C\u003Ec__DisplayClass35_0 cDisplayClass350;
                while (true)
                {
                  switch (num6)
                  {
                    case 0:
                      goto label_16;
                    case 1:
                      watchPath1 = watchPath;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 4 : 2;
                      continue;
                    case 2:
                      if (sender.FileDeleted == null)
                      {
                        num6 = 9;
                        continue;
                      }
                      goto case 6;
                    case 3:
                      goto label_6;
                    case 4:
                      if (notifyFilters1 == NotifyFilters.DirectoryName)
                      {
                        num6 = 3;
                        continue;
                      }
                      DirectoryFileWatcher directoryFileWatcher = sender;
                      string watchPath2 = watchPath1;
                      Action<ConcurrentHashSet<string>> action1 = action;
                      Action<ConcurrentHashSet<string>> existsFilesAction = action1 == null ? (action = (Action<ConcurrentHashSet<string>>) (existsFiles => existsFiles.Remove(path1))) : action1;
                      directoryFileWatcher.GetExistsFiles4WatchPath(watchPath2, existsFilesAction);
                      num6 = 2;
                      continue;
                    case 5:
                      goto label_13;
                    case 6:
                      sender.FileDeleted((object) sender, new FileWatcherEventArgs(watchPath1, path1, FileWatcherChangeTypes.FileDeleted));
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                      continue;
                    case 7:
                      cDisplayClass350 = this;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
                      continue;
                    case 8:
                      num6 = 7;
                      continue;
                    case 9:
                      goto label_7;
                    default:
                      goto label_3;
                  }
                }
label_6:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                sender.GetExistsFiles4WatchPath(watchPath1, (Action<ConcurrentHashSet<string>>) (existsFiles => existsFiles.Where<string>(cDisplayClass350.\u003C\u003E9__8 ?? (cDisplayClass350.\u003C\u003E9__8 = new Func<string, bool>(cDisplayClass350.\u003CPathDeleted\u003Eb__8))).ToList<string>().Select<string, string>((Func<string, string>) (k =>
                {
                  int num7 = 1;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        existsFiles.Remove(k);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_3;
                    }
                  }
label_3:
                  return k;
                })).ToList<string>().ForEach((Action<string>) (p =>
                {
                  int num8 = 3;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 0:
                        goto label_3;
                      case 1:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass350.\u003C\u003E4__this.FileDeleted((object) cDisplayClass350.\u003C\u003E4__this, new FileWatcherEventArgs(watchPath1, p, FileWatcherChangeTypes.FileDeleted));
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_2;
                      case 3:
                        // ISSUE: reference to a compiler-generated field
                        if (cDisplayClass350.\u003C\u003E4__this.FileDeleted == null)
                        {
                          num8 = 2;
                          continue;
                        }
                        goto case 1;
                      default:
                        goto label_7;
                    }
                  }
label_3:
                  return;
label_2:
                  return;
label_7:;
                }))));
                num5 = 5;
              }
label_16:
              return;
label_13:
              return;
label_7:
              return;
label_3:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 14:
            path1 = path;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 10 : 4;
            continue;
          default:
            goto label_23;
        }
      }
label_9:
      return;
label_22:
      return;
label_6:
      return;
label_23:
      return;
label_2:
      return;
label_5:;
    }

    internal static object d0qmXwBHAdPh87ExleVQ() => (object) StringComparer.InvariantCultureIgnoreCase;

    internal static bool KU23M3BH6dBU5bn5d3BG() => DirectoryFileWatcher.w76uHNBH46nqSpgbY7g3 == null;

    internal static DirectoryFileWatcher RhTMtkBHHdjroQZKNIXh() => DirectoryFileWatcher.w76uHNBH46nqSpgbY7g3;

    internal static object pgl7mGBH7UWGI04WDq3E(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool pp2vJGBHxiq1Y5EBmcLh([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static object girTMKBH0uMVVyDW2V7c([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void AUGOrDBHmQxo7r0Tce4l([In] object obj0, [In] bool obj1) => ((FileSystemWatcher) obj0).EnableRaisingEvents = obj1;

    internal static void wR2mFhBHyMEjQXV4skQK([In] object obj0, [In] NotifyFilters obj1) => ((FileSystemWatcher) obj0).NotifyFilter = obj1;

    internal static void kA9hx6BHMlnyaooqrPl2([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Changed += (FileSystemEventHandler) obj1;

    internal static void OOQkZSBHJPuvGe6mMyVt([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Created += (FileSystemEventHandler) obj1;

    internal static void CmawHpBH9YIj64XEuGWC([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Renamed += (RenamedEventHandler) obj1;

    internal static void aZRj2jBHds7iSZOgdK4U([In] object obj0, [In] bool obj1) => ((FileSystemWatcher) obj0).IncludeSubdirectories = obj1;

    internal static void ONByoeBHlvQMc1V6mmS8([In] object obj0, [In] object obj1) => ((FileSystemWatcher) obj0).Deleted += (FileSystemEventHandler) obj1;

    internal static char pr3nKRBHrQve9Cnhlt6m([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static bool lrkayKBHgleQTRMSTeOJ([In] object obj0, [In] object obj1, [In] object obj2) => ((StringComparer) obj0).Equals(obj1, obj2);

    internal static object jJonhbBH5nInkTuURLLi([In] object obj0, [In] int obj1) => (object) ((string) obj0).Remove(obj1);

    internal static int TeMw8iBHjMZNsgchw82i([In] object obj0) => ((string) obj0).Length;

    internal static int GsD5k7BHYNQluQM9QZd0([In] int obj0, [In] int obj1) => Math.Min(obj0, obj1);

    internal static bool d9d6D5BHLIZ9H1WVUyAl([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool oxwsB1BHURjtdVX4j2jI([In] object obj0) => ((FileSystemWatcher) obj0).EnableRaisingEvents;

    internal static bool sO98u8BHs5uhuIVGKrIY([In] object obj0) => Directory.Exists((string) obj0);

    internal static bool xWGB3kBHclGiKlNnhxPD([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object t7ONpHBHzW8Gpkdoh9JC([In] object obj0) => (object) ((FileInfo) obj0).DirectoryName;

    internal static object slU8rRBAFGDK4fja7QMp([In] object obj0) => (object) ((FileSystemEventArgs) obj0).FullPath;

    internal static NotifyFilters sfRTxLBAB7PWPdjxHSGZ([In] object obj0) => ((FileSystemWatcher) obj0).NotifyFilter;

    internal static object rRJveTBAWr2iIxysJlNc([In] object obj0) => (object) ((RenamedEventArgs) obj0).OldFullPath;

    internal static object h2gemjBAotF9QU1h5Zn1([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void egteL6BAbZnlm0TkpxrV([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static int gks8TXBAhCWoEYqUBPmn([In] object obj0) => ((List<string>) obj0).Count;

    internal static bool T21Yy9BAGDGObWc3hxvC([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static void OgqUcdBAErHZhX1Wh9q8([In] object obj0) => ((List<string>) obj0).Sort();
  }
}
