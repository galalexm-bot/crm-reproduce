// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.ServerInfoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>
  /// Менеджер, предоставляющий информацию о сервере ELMA (Runtime-части). Используется в дизайнере ELMA.
  /// </summary>
  public class ServerInfoManager : DTOManager, IServerInfoManager, IConfigurationService
  {
    private static ServerInfoManager bG76jKWJ17Ms0O5hMMJh;

    /// <summary>
    /// Получить информацию с хэш-кодами о бинарных файлах на сервере
    /// </summary>
    /// <returns>Информация о загруженных сборках</returns>
    public virtual AssemblyHashInfo[] GetBinaryHashInfos()
    {
      int num1 = 4;
      List<AssemblyHashInfo> assemblyHashInfoList;
      while (true)
      {
        int num2 = num1;
        AssemblyHashInfo assemblyHashInfo1;
        int index1;
        string str1;
        int index2;
        string[] assemblyPaths;
        string[] strArray;
        string fileName;
        string str2;
        string path;
        while (true)
        {
          switch (num2)
          {
            case 1:
              path = (string) ServerInfoManager.NTWUGnWJ7EMZpiZ9fBx7((object) fileName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108097306));
              num2 = 27;
              continue;
            case 2:
            case 29:
              if (index1 >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 15 : 4;
                continue;
              }
              goto case 5;
            case 3:
              if (((ComponentManager) ServerInfoManager.xE6lTuWJaQOWGbR6rBJ1()).AssemblyPaths != null)
              {
                assemblyHashInfoList = new List<AssemblyHashInfo>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 25 : 5;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 23 : 23;
              continue;
            case 4:
              if (ServerInfoManager.w0vlTKWJpEXnLLaL85ci())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 3;
                continue;
              }
              goto label_13;
            case 5:
              fileName = strArray[index1];
              num2 = 18;
              continue;
            case 6:
              strArray = (string[]) ServerInfoManager.VIHn6uWJ6SeWEvKc7tom((object) str1, ServerInfoManager.sF9ldNWJ4c45PUgeKGNn(1925118608 << 2 ^ -889540986));
              num2 = 36;
              continue;
            case 7:
              if (!ServerInfoManager.T6C3VhWJ0lukG0DQVv4y((object) str2))
              {
                num2 = 17;
                continue;
              }
              goto case 22;
            case 8:
            case 17:
            case 28:
              ++index1;
              num2 = 29;
              continue;
            case 9:
              index2 = 0;
              num2 = 12;
              continue;
            case 11:
              if (ServerInfoManager.mq4JOXWJDR94hpJmxeHX((object) str1))
              {
                num2 = 16;
                continue;
              }
              goto case 15;
            case 12:
            case 34:
              if (index2 < assemblyPaths.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 10 : 6;
                continue;
              }
              goto label_36;
            case 13:
              ServerInfoManager.kHYGb5WJxhYd2XPZcsjk((object) assemblyHashInfo1, (object) str2);
              num2 = 26;
              continue;
            case 14:
              assemblyHashInfo1.EvaluteMD5(fileName);
              num2 = 30;
              continue;
            case 15:
            case 35:
              ++index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 34 : 28;
              continue;
            case 16:
              if (ServerInfoManager.v6vQhQWJwyC4ZCaR0i2e(ServerInfoManager.fFJoStWJtWMrrG1E7B6T((object) str1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099615815), StringComparison.CurrentCultureIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 35 : 29;
                continue;
              }
              goto case 6;
            case 18:
              if (!ServerInfoManager.OC1R0CWJHAUqtKo8K1hj((object) fileName))
              {
                num2 = 28;
                continue;
              }
              goto case 19;
            case 19:
              AssemblyHashInfo assemblyHashInfo2 = new AssemblyHashInfo();
              ServerInfoManager.FxkZsRWJA5OiJ89b2T6V((object) assemblyHashInfo2, ServerInfoManager.fFJoStWJtWMrrG1E7B6T((object) fileName));
              assemblyHashInfo1 = assemblyHashInfo2;
              num2 = 14;
              continue;
            case 20:
              goto label_37;
            case 21:
            case 32:
              str2 = (string) ServerInfoManager.NTWUGnWJ7EMZpiZ9fBx7((object) fileName, ServerInfoManager.sF9ldNWJ4c45PUgeKGNn(1149433385 + 173655049 ^ 1323054204));
              num2 = 7;
              continue;
            case 22:
              AssemblyHashInfo assemblyHashInfo3 = new AssemblyHashInfo();
              ServerInfoManager.FxkZsRWJA5OiJ89b2T6V((object) assemblyHashInfo3, ServerInfoManager.fFJoStWJtWMrrG1E7B6T((object) str2));
              assemblyHashInfo1 = assemblyHashInfo3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 12 : 13;
              continue;
            case 23:
              goto label_13;
            case 24:
              ServerInfoManager.kHYGb5WJxhYd2XPZcsjk((object) assemblyHashInfo1, (object) path);
              num2 = 33;
              continue;
            case 25:
              assemblyPaths = this.GetAssemblyPaths();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 9 : 3;
              continue;
            case 26:
              assemblyHashInfoList.Add(assemblyHashInfo1);
              num2 = 8;
              continue;
            case 27:
              if (!File.Exists(path))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 16 : 21;
                continue;
              }
              goto label_37;
            case 30:
              assemblyHashInfoList.Add(assemblyHashInfo1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
              continue;
            case 31:
              goto label_36;
            case 33:
              goto label_22;
            case 36:
              index1 = 0;
              num2 = 2;
              continue;
            default:
              str1 = assemblyPaths[index2];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 11;
              continue;
          }
        }
label_22:
        assemblyHashInfoList.Add(assemblyHashInfo1);
        num1 = 32;
        continue;
label_37:
        assemblyHashInfo1 = new AssemblyHashInfo()
        {
          AssemblyName = Path.GetFileName(path)
        };
        num1 = 24;
      }
label_13:
      return new AssemblyHashInfo[0];
label_36:
      return (AssemblyHashInfo[]) ServerInfoManager.NEm5ZqWJm9kU78ascSwl((object) assemblyHashInfoList);
    }

    /// <summary>Получить содержимое файла</summary>
    /// <param name="assemblyName">Имя бинарного файла</param>
    /// <returns>Содержимое файла</returns>
    public virtual byte[] GetAssemblyRaw(string assemblyName)
    {
      int num1 = 6;
      string str1;
      while (true)
      {
        int num2 = num1;
        string[] assemblyPaths;
        int index;
        string str2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_17;
            case 3:
            case 10:
              str2 = assemblyPaths[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 3 : 8;
              continue;
            case 4:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 11 : 6;
              continue;
            case 5:
            case 12:
              goto label_6;
            case 6:
              if (!ServerInfoManager.w0vlTKWJpEXnLLaL85ci())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 5;
                continue;
              }
              goto label_10;
            case 7:
              goto label_10;
            case 8:
              if (ServerInfoManager.mq4JOXWJDR94hpJmxeHX((object) str2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 15;
                continue;
              }
              goto case 13;
            case 9:
              if (!ServerInfoManager.T6C3VhWJ0lukG0DQVv4y((object) str1))
              {
                num2 = 13;
                continue;
              }
              goto label_8;
            case 13:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 14:
              assemblyPaths = this.GetAssemblyPaths();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 4 : 3;
              continue;
            case 15:
              str1 = (string) ServerInfoManager.DfsA4HWJML3NWLYiDEcy((object) str2, (object) assemblyName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 4 : 9;
              continue;
            default:
              if (index < assemblyPaths.Length)
              {
                num2 = 3;
                continue;
              }
              goto label_17;
          }
        }
label_10:
        if (ServerInfoManager.rcxOXMWJyEoKKFGf18cV(ServerInfoManager.xE6lTuWJaQOWGbR6rBJ1()) != null)
          num1 = 14;
        else
          break;
      }
label_6:
      return (byte[]) null;
label_8:
      return (byte[]) ServerInfoManager.jsZj7rWJJdXphkY10gMg((object) str1);
label_17:
      return (byte[]) null;
    }

    /// <summary>Получить тип основного провайдера</summary>
    /// <returns></returns>
    public virtual string GetMainProviderType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (((ComponentManager) ServerInfoManager.xE6lTuWJaQOWGbR6rBJ1()).Stage != ComponentManager.LifetimeStage.BeforeInit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      RuntimeApplication runtimeApplication = Locator.GetServiceNotNull<RuntimeApplication>();
      goto label_6;
label_5:
      runtimeApplication = ((ComponentManager) ServerInfoManager.xE6lTuWJaQOWGbR6rBJ1()).GetComponentsForRegister<RuntimeApplication>().FirstOrDefault<RuntimeApplication>();
label_6:
      return (string) ServerInfoManager.QPNOg6WJd2rP4dCBxDPn((object) ((runtimeApplication != null ? ServerInfoManager.geCs29WJ9YcRN0RQgq7o((object) runtimeApplication) : throw new InvalidOperationException((string) ServerInfoManager.sF9ldNWJ4c45PUgeKGNn(333888594 ^ 1075625116 ^ 1408922570))) ?? throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87349429))).GetType());
    }

    /// <summary>Получить название редакции</summary>
    /// <returns></returns>
    public virtual string GetEdition() => (string) ServerInfoManager.dYR5ZLWJl0YSFpXAnnjU();

    /// <summary>Получить информацию о статусах модулей</summary>
    /// <returns></returns>
    public virtual ModuleStatusInfo[] GetModuleStatuses()
    {
      int num = 1;
      List<ModuleStatusInfo> result;
      while (true)
      {
        switch (num)
        {
          case 1:
            result = new List<ModuleStatusInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.AddModuleStatuses((IModule) ((IModuleManager) ServerInfoManager.vT8CotWJrZ8S9ylWXrvX(ServerInfoManager.xE6lTuWJaQOWGbR6rBJ1())).MainApplication, result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return (ModuleStatusInfo[]) ServerInfoManager.GGpU5CWJg4XMZhTuicQY((object) result);
    }

    private static bool IsAssembly(object fileName)
    {
      switch (1)
      {
        case 1:
          bool flag;
          try
          {
            AssemblyName.GetAssemblyName((string) fileName);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
              num = 0;
            switch (num)
            {
              default:
                goto label_8;
            }
          }
          catch
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_9;
              }
            }
          }
label_9:
          return flag;
      }
label_8:
      return true;
    }

    private string[] GetAssemblyPaths() => ((IEnumerable<string>) ((ComponentManager) ServerInfoManager.xE6lTuWJaQOWGbR6rBJ1()).AssemblyPaths).Union<string>((IEnumerable<string>) new string[1]
    {
      (string) ServerInfoManager.DfsA4HWJML3NWLYiDEcy(ServerInfoManager.YgWm64WJ5uPl8fcaKjRG(ServerInfoManager.xE6lTuWJaQOWGbR6rBJ1()), ServerInfoManager.sF9ldNWJ4c45PUgeKGNn(-1290212282 ^ -644262414 ^ 1786833372))
    }).ToArray<string>();

    private void AddModuleStatuses(IModule module, List<ModuleStatusInfo> result)
    {
      if (module != null)
        result.Add(new ModuleStatusInfo()
        {
          Uid = module.Uid,
          Status = module.Status
        });
      foreach (IModule extensionModule in module.ExtensionModules)
        this.AddModuleStatuses(extensionModule, result);
      if (!(module is IApplication application))
        return;
      foreach (IModule systemModule in application.SystemModules)
        this.AddModuleStatuses(systemModule, result);
    }

    public ServerInfoManager()
    {
      ServerInfoManager.VWVf4OWJjfROEWtZXYX2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool w0vlTKWJpEXnLLaL85ci() => ComponentManager.Initialized;

    internal static object xE6lTuWJaQOWGbR6rBJ1() => (object) ComponentManager.Current;

    internal static bool mq4JOXWJDR94hpJmxeHX([In] object obj0) => Directory.Exists((string) obj0);

    internal static object fFJoStWJtWMrrG1E7B6T([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static bool v6vQhQWJwyC4ZCaR0i2e([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object sF9ldNWJ4c45PUgeKGNn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VIHn6uWJ6SeWEvKc7tom([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static bool OC1R0CWJHAUqtKo8K1hj([In] object obj0) => ServerInfoManager.IsAssembly(obj0);

    internal static void FxkZsRWJA5OiJ89b2T6V([In] object obj0, [In] object obj1) => ((AssemblyHashInfo) obj0).AssemblyName = (string) obj1;

    internal static object NTWUGnWJ7EMZpiZ9fBx7([In] object obj0, [In] object obj1) => (object) Path.ChangeExtension((string) obj0, (string) obj1);

    internal static void kHYGb5WJxhYd2XPZcsjk([In] object obj0, [In] object obj1) => ((AssemblyHashInfo) obj0).EvaluteMD5((string) obj1);

    internal static bool T6C3VhWJ0lukG0DQVv4y([In] object obj0) => File.Exists((string) obj0);

    internal static object NEm5ZqWJm9kU78ascSwl([In] object obj0) => (object) ((List<AssemblyHashInfo>) obj0).ToArray();

    internal static bool i6oJ9QWJNp8jWbgfvMth() => ServerInfoManager.bG76jKWJ17Ms0O5hMMJh == null;

    internal static ServerInfoManager yoP2TqWJ3jUsI7WGEcYl() => ServerInfoManager.bG76jKWJ17Ms0O5hMMJh;

    internal static object rcxOXMWJyEoKKFGf18cV([In] object obj0) => (object) ((ComponentManager) obj0).AssemblyPaths;

    internal static object DfsA4HWJML3NWLYiDEcy([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object jsZj7rWJJdXphkY10gMg([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    internal static object geCs29WJ9YcRN0RQgq7o([In] object obj0) => (object) ((RuntimeApplication) obj0).MainProvider;

    internal static object QPNOg6WJd2rP4dCBxDPn([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object dYR5ZLWJl0YSFpXAnnjU() => (object) VersionInfo.GetEdition();

    internal static object vT8CotWJrZ8S9ylWXrvX([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object GGpU5CWJg4XMZhTuicQY([In] object obj0) => (object) ((List<ModuleStatusInfo>) obj0).ToArray();

    internal static object YgWm64WJ5uPl8fcaKjRG([In] object obj0) => (object) ((ComponentManager) obj0).WorkDirectory;

    internal static void VWVf4OWJjfROEWtZXYX2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
