// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ModuleDeployDirectoryWatcher
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>
  /// Слежение за содержимым папки с целью авторазвертывания пакетов в ней в момент появления.
  /// </summary>
  internal class ModuleDeployDirectoryWatcher : DirectoryFileWatcher
  {
    private static readonly IReadOnlyCollection<string> componentExtensionsToTry;
    private readonly IModuleFileDeployService moduleFileDeployService;
    private readonly ISecurityServiceAsync securityService;
    private readonly object lockObj;
    private static readonly ILogger deployLog;
    private static ModuleDeployDirectoryWatcher GeIarRE6pbVGOUMEXsWY;

    /// <summary>Ctor</summary>
    /// <param name="moduleFileDeployService">Сервис развертывания модулей</param>
    /// <param name="securityService">Сервис безопасности и привилегий</param>
    public ModuleDeployDirectoryWatcher(
      IModuleFileDeployService moduleFileDeployService,
      ISecurityServiceAsync securityService)
    {
      ModuleDeployDirectoryWatcher.nEv5OaE6tcNWGxGPQKrk();
      this.lockObj = new object();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.moduleFileDeployService = moduleFileDeployService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            this.securityService = securityService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Инициализировать</summary>
    public void Init()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        string watchRoot;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_14;
            case 1:
              if (!ModuleDeployDirectoryWatcher.aq12EgE602feaqk3nBB5((object) watchRoot))
              {
                num2 = 3;
                continue;
              }
              this.FileAdded = (EventHandler<FileWatcherEventArgs>) ModuleDeployDirectoryWatcher.yAlvEnE6mRLlVXPWQ7f2((object) this.FileAdded, (object) new EventHandler<FileWatcherEventArgs>(this.OnFileAdded));
              num2 = 7;
              continue;
            case 2:
            case 9:
              if (ModuleDeployDirectoryWatcher.teknfZE6xxbQQXW16TnI((object) watchRoot))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 10;
                continue;
              }
              goto case 1;
            case 3:
              goto label_10;
            case 4:
              if (!ModuleDeployDirectoryWatcher.BFCvySE6HErpK3vUI62S((object) watchRoot))
                goto case 8;
              else
                goto label_8;
            case 5:
              watchRoot = (string) ModuleDeployDirectoryWatcher.RVcq4YE66Zyim57c1ITK(ModuleDeployDirectoryWatcher.bKWeRlE6wXC3eHUyC9vA(), ModuleDeployDirectoryWatcher.FZ3jgOE64jfPmv0PLo1x(-680446928 - -370807692 ^ -309343584));
              num2 = 4;
              continue;
            case 6:
              this.AddSpecificWatchPaths(watchRoot);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            case 7:
              this.InitWatcher(watchRoot);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 6 : 6;
              continue;
            case 8:
              watchRoot = (string) ModuleDeployDirectoryWatcher.QGYI2nE67anOoxkElYmW(ModuleDeployDirectoryWatcher.vHqZ5CE6AAdquWhJqjgn((object) AppDomain.CurrentDomain), (object) watchRoot);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 2;
              continue;
            case 10:
              goto label_3;
            default:
              goto label_4;
          }
        }
label_8:
        num1 = 9;
      }
label_14:
      return;
label_10:
      return;
label_3:
      return;
label_4:;
    }

    private void OnFileAdded(object sender, FileWatcherEventArgs e)
    {
      int num1 = 9;
      object lockObj;
      bool lockTaken;
      while (true)
      {
        int num2 = num1;
        FileWatcherEventArgs e1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              lockObj = this.lockObj;
              num2 = 7;
              continue;
            case 3:
              goto label_23;
            case 4:
              goto label_9;
            case 5:
              if (ModuleDeployDirectoryWatcher.BFCvySE6HErpK3vUI62S(ModuleDeployDirectoryWatcher.mECQNwE6y1lwdf5nBMkN((object) e1)))
              {
                num2 = 3;
                continue;
              }
              goto label_17;
            case 6:
              goto label_21;
            case 7:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
              continue;
            case 8:
              e1 = e;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 6 : 2;
              continue;
            case 9:
              goto label_19;
            case 10:
              goto label_25;
            default:
              goto label_17;
          }
        }
label_17:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!ModuleDeployDirectoryWatcher.componentExtensionsToTry.All<string>((Func<string, bool>) (ext => ModuleDeployDirectoryWatcher.\u003C\u003Ec__DisplayClass8_0.jJfpdE8Pml4xV5ZhoOc2(ModuleDeployDirectoryWatcher.\u003C\u003Ec__DisplayClass8_0.EoTdQV8P0W0c7avITWC6(ModuleDeployDirectoryWatcher.\u003C\u003Ec__DisplayClass8_0.nLtHAf8Pxa0XYflXLMcN((object) e1)), (object) ext))))
        {
          num1 = 2;
          continue;
        }
        goto label_13;
label_19:
        num1 = 8;
        continue;
label_21:
        ModuleDeployDirectoryWatcher directoryWatcher = this;
        num1 = 5;
      }
label_23:
      return;
label_9:
      return;
label_25:
      return;
label_5:
      try
      {
        Monitor.Enter(lockObj, ref lockTaken);
        int num3 = 2;
        TaskAwaiter taskAwaiter;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_20;
            case 1:
              taskAwaiter.GetResult();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 2:
              taskAwaiter = ModuleDeployDirectoryWatcher.mXnT53E6JoR9dRpPuScX((object) new BackgroundAsyncTask((Func<Task>) (() =>
              {
                int num4 = 5;
                // ISSUE: variable of a compiler-generated type
                ModuleDeployDirectoryWatcher.\u003C\u003Ec__DisplayClass8_0.\u003C\u003COnFileAdded\u003Eb__1\u003Ed stateMachine;
                AsyncTaskMethodBuilder tBuilder;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated field
                      tBuilder = stateMachine.\u003C\u003Et__builder;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_6;
                    case 3:
                      // ISSUE: reference to a compiler-generated field
                      stateMachine.\u003C\u003E1__state = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 1;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated field
                      stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 3 : 3;
                      continue;
                    case 5:
                      // ISSUE: reference to a compiler-generated field
                      stateMachine.\u003C\u003E4__this = (object) this;
                      num4 = 4;
                      continue;
                    default:
                      tBuilder.Start<ModuleDeployDirectoryWatcher.\u003C\u003Ec__DisplayClass8_0.\u003C\u003COnFileAdded\u003Eb__1\u003Ed>(ref stateMachine);
                      num4 = 2;
                      continue;
                  }
                }
label_6:
                // ISSUE: reference to a compiler-generated field
                return stateMachine.\u003C\u003Et__builder.Task;
              }), typeof (ModuleDeployDirectoryWatcher), (string) ModuleDeployDirectoryWatcher.CB9DfBE6MtsKCmK77mqU(ModuleDeployDirectoryWatcher.FZ3jgOE64jfPmv0PLo1x(1033719030 - 2012070891 ^ -978647995)), "").ExecuteAsync());
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            default:
              goto label_14;
          }
        }
label_20:
        return;
label_14:
        return;
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
        else
          goto label_15;
label_12:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_15:
        ModuleDeployDirectoryWatcher.cVtDMDE69W2roV6Dj8qP(lockObj);
        num5 = 2;
        goto label_12;
      }
label_13:;
    }

    private string MoveFile(string file)
    {
      int num1 = 2;
      string file1;
      string newPath;
      while (true)
      {
        switch (num1)
        {
          case 1:
            file1 = file;
            num1 = 4;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
            continue;
          case 3:
            this.ExecuteFileAction((System.Action) (() =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    ModuleDeployDirectoryWatcher.\u003C\u003Ec__DisplayClass9_0.TQIb998PURYunnNc1ESu((object) file1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    ModuleDeployDirectoryWatcher.\u003C\u003Ec__DisplayClass9_0.Dl091n8PLrsSCtEigndZ((object) file1, (object) newPath);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_2:
              return;
label_5:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 4:
            newPath = (string) ModuleDeployDirectoryWatcher.QGYI2nE67anOoxkElYmW((object) this.GetModulePath(file1), (object) Path.GetFileName(file1));
            num1 = 3;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return newPath;
    }

    private string GetModulePath(string file)
    {
      int num = 4;
      string path;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModuleDeployDirectoryWatcher.gb4hDZE657cl7FRgSuIL((object) path);
            num = 2;
            continue;
          case 3:
            if (Directory.Exists(path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            path = Path.Combine((string) ModuleDeployDirectoryWatcher.zcThf9E6dTYdu496Yeer((object) file), (string) ModuleDeployDirectoryWatcher.CSIq5YE6gZsnkAvpqEFe(ModuleDeployDirectoryWatcher.wyPgS4E6lCaunTQCyP0B((object) file), ModuleDeployDirectoryWatcher.FZ3jgOE64jfPmv0PLo1x(-649342099 - -1150814748 ^ 501469683), (object) ModuleDeployDirectoryWatcher.iiTeO4E6rVcWmPY8xVhQ().ToString((string) ModuleDeployDirectoryWatcher.FZ3jgOE64jfPmv0PLo1x(-1978478350 ^ -1978245794))));
            num = 3;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return path;
    }

    private TextWriter CreateLog(string componentPath) => (TextWriter) new StreamWriter((Stream) new FileStream((string) ModuleDeployDirectoryWatcher.QGYI2nE67anOoxkElYmW(ModuleDeployDirectoryWatcher.zcThf9E6dTYdu496Yeer((object) componentPath), ModuleDeployDirectoryWatcher.FZ3jgOE64jfPmv0PLo1x(-1290212282 ^ -644262414 ^ 1787114618)), FileMode.Create, FileAccess.Write, FileShare.ReadWrite, 1024), (Encoding) ModuleDeployDirectoryWatcher.FSQobQE6j8RJXGGJSxVb(), 1024, false);

    private void ExecuteFileAction(System.Action action)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ActionExtensions.ExecuteWithAttempts(action, ModuleDeployDirectoryWatcher.i9n4GoE6YqHLNEPLM3wJ(1000.0), 10, (Func<Exception, bool>) (ex => ex is IOException));
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

    static ModuleDeployDirectoryWatcher()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ModuleDeployDirectoryWatcher.deployLog = Logger.GetLogger((string) ModuleDeployDirectoryWatcher.FZ3jgOE64jfPmv0PLo1x(-138018305 ^ -138245095));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          case 2:
            ModuleDeployDirectoryWatcher.componentExtensionsToTry = (IReadOnlyCollection<string>) ((IEnumerable<string>) new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317772910)
            }).Concat<string>((IEnumerable<string>) ElmaStoreComponentFile.SupportedComponentExtension).ToList<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
            continue;
          case 3:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void nEv5OaE6tcNWGxGPQKrk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool J47dMvE6aVoJZs9MaoyG() => ModuleDeployDirectoryWatcher.GeIarRE6pbVGOUMEXsWY == null;

    internal static ModuleDeployDirectoryWatcher X0LmbyE6Dp1wxKxj2Dlk() => ModuleDeployDirectoryWatcher.GeIarRE6pbVGOUMEXsWY;

    internal static object bKWeRlE6wXC3eHUyC9vA() => (object) ConfigurationManager.AppSettings;

    internal static object FZ3jgOE64jfPmv0PLo1x(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RVcq4YE66Zyim57c1ITK([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static bool BFCvySE6HErpK3vUI62S([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object vHqZ5CE6AAdquWhJqjgn([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static object QGYI2nE67anOoxkElYmW([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool teknfZE6xxbQQXW16TnI([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool aq12EgE602feaqk3nBB5([In] object obj0) => Directory.Exists((string) obj0);

    internal static object yAlvEnE6mRLlVXPWQ7f2([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

    internal static object mECQNwE6y1lwdf5nBMkN([In] object obj0) => (object) ((FileWatcherEventArgs) obj0).Path;

    internal static object CB9DfBE6MtsKCmK77mqU([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static TaskAwaiter mXnT53E6JoR9dRpPuScX([In] object obj0) => ((Task) obj0).GetAwaiter();

    internal static void cVtDMDE69W2roV6Dj8qP([In] object obj0) => Monitor.Exit(obj0);

    internal static object zcThf9E6dTYdu496Yeer([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object wyPgS4E6lCaunTQCyP0B([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static DateTime iiTeO4E6rVcWmPY8xVhQ() => DateTime.Now;

    internal static object CSIq5YE6gZsnkAvpqEFe([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object gb4hDZE657cl7FRgSuIL([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object FSQobQE6j8RJXGGJSxVb() => (object) Encoding.UTF8;

    internal static TimeSpan i9n4GoE6YqHLNEPLM3wJ([In] double obj0) => TimeSpan.FromMilliseconds(obj0);
  }
}
