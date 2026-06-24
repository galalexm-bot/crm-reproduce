// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.AssemblyReferenceHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Scripts.ServiceReference.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Services.Description;

namespace EleWise.ELMA.Scripts
{
  /// <summary>Класс помощник для работы с ссылками на сборки</summary>
  public static class AssemblyReferenceHelper
  {
    private static string globalAssemblyLocation;
    private static string elmaAssemblyLocation;
    /// <summary>Ссылки на сборки модулей ELMA по умолчанию</summary>
    public static readonly string[] DefaultElmaReferenceList;
    /// <summary>Ссылки на глобальные сборки по умолчанию</summary>
    public static readonly string[] DefaultGlobalReferencesList;
    /// <summary>Ссылки на веб сборки по умолчанию</summary>
    public static readonly string[] DefaultWebReferences;
    internal static AssemblyReferenceHelper mZ7dnMBszP3dc7VA42Ke;

    /// <summary>Путь до библиотек платформы</summary>
    public static string GlobalAssemblyLocation
    {
      get
      {
        int num = 1;
        string assemblyLocation;
        while (true)
        {
          switch (num)
          {
            case 1:
              assemblyLocation = AssemblyReferenceHelper.globalAssemblyLocation;
              if (assemblyLocation == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return assemblyLocation;
label_5:
        return AssemblyReferenceHelper.globalAssemblyLocation = (string) AssemblyReferenceHelper.lrR6A1BcboudH0fWN7pB(AssemblyReferenceHelper.ujTTxxBco6UYt5m2eLvT(AssemblyReferenceHelper.L2CpahBcWp5j3G236erx()));
      }
    }

    /// <summary>Путь до библиотек Elma</summary>
    public static string ElmaAssemblyLocation
    {
      get
      {
        int num = 1;
        string assemblyLocation;
        while (true)
        {
          switch (num)
          {
            case 1:
              assemblyLocation = AssemblyReferenceHelper.elmaAssemblyLocation;
              if (assemblyLocation == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return assemblyLocation;
label_5:
        return AssemblyReferenceHelper.elmaAssemblyLocation = (string) AssemblyReferenceHelper.DFgEevBchqg6ha7gFYvk((object) Locator.GetServiceNotNull<IOmniSharpWorker>());
      }
    }

    /// <summary>Путь до папки с внешними сборками</summary>
    public static string ExternalAssemblyLocation => IOExtensions.GetTempPath(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272537131));

    /// <summary>Получить путь до сборки глобального модуля</summary>
    /// <param name="globalModuleAssemblyUid">Идентификатор заголока глобального модуля</param>
    [Obsolete("Use IGlobalModulesReferenceService.GetGlobalModuleAssemblyPath(...) instead", true)]
    public static string GetGlobalModuleAssemblyPath(Guid globalModuleAssemblyUid) => (string) AssemblyReferenceHelper.sJBlneBcQATD61cPgrJh(AssemblyReferenceHelper.pUeKm2BcG12bWLtg8GNW(), AssemblyReferenceHelper.f6hs2hBcfuteCgRjX7IG(AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(~-306453669 ^ 306537250), (object) globalModuleAssemblyUid, AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(1012087039 ^ 1012038725)));

    /// <summary>Ссылки модуля сценариев по умолчанию</summary>
    public static string[] DefaultReferenceList => ((IEnumerable<string>) AssemblyReferenceHelper.DefaultElmaReferenceList).Union<string>((IEnumerable<string>) AssemblyReferenceHelper.DefaultGlobalReferencesList).Union<string>((IEnumerable<string>) AssemblyReferenceHelper.DefaultWebReferences).ToArray<string>();

    /// <summary>
    /// Получить строку с xml-форматом сервиса или html-страницу для вывода на экран пользователю
    /// </summary>
    /// <param name="uri">Url</param>
    internal static string GetServiceString(Uri uri)
    {
      int num1 = 2;
      Stream stream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            stream = (Stream) AssemblyReferenceHelper.ENbhCnBc8JCmjmoIlwyA(AssemblyReferenceHelper.nF4I5HBcvUVRyVuYEUV7(AssemblyReferenceHelper.ErFQ9UBcCYWH10YpkBJc((object) uri)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          default:
            goto label_22;
        }
      }
label_2:
      string serviceString;
      try
      {
        StreamReader streamReader = new StreamReader(stream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              serviceString = (string) AssemblyReferenceHelper.PSXW0bBcZW2jouy02RaB((object) streamReader);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                num3 = 0;
              switch (num3)
              {
              }
            }
            finally
            {
              int num4;
              if (streamReader == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 0;
              else
                goto label_12;
label_11:
              switch (num4)
              {
                case 1:
                case 2:
              }
label_12:
              AssemblyReferenceHelper.PJBv4gBcuaTyBkxKDBDi((object) streamReader);
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
              {
                num4 = 0;
                goto label_11;
              }
              else
                goto label_11;
            }
            break;
        }
      }
      finally
      {
        if (stream != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_20;
              default:
                AssemblyReferenceHelper.PJBv4gBcuaTyBkxKDBDi((object) stream);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_20:;
      }
label_22:
      return serviceString;
    }

    /// <summary>
    /// Получить информацию о веб-сервисе для вывода на экран пользователю
    /// </summary>
    /// <param name="contracts">Контракты сервиса</param>
    internal static ServiceReferenceInfo GetServiceReferencesInfo(
      IEnumerable<ServiceDescription> contracts)
    {
      ServiceReferenceInfo serviceReferencesInfo = new ServiceReferenceInfo()
      {
        MethodNames = new List<string>()
      };
      foreach (ServiceDescription contract in contracts)
      {
        serviceReferencesInfo.Name = contract.Name;
        if (contract.Services.Count > 0)
        {
          foreach (Service service in (CollectionBase) contract.Services)
          {
            foreach (Port port1 in (CollectionBase) service.Ports)
            {
              Port port = port1;
              // ISSUE: reference to a compiler-generated method
              Binding binding = ((IEnumerable<Binding>) contract.Bindings.CastToArrayOrNull<Binding>()).FirstOrDefault<Binding>((Func<Binding, bool>) (q => AssemblyReferenceHelper.\u003C\u003Ec__DisplayClass15_0.scbfmoQPgQ5SLgEiFxig((object) q.Name, (object) port.Binding.Name)));
              if (binding != null)
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                PortType portType = ((IEnumerable<PortType>) contract.PortTypes.CastToArrayOrNull<PortType>()).FirstOrDefault<PortType>((Func<PortType, bool>) (q => AssemblyReferenceHelper.\u003C\u003Ec__DisplayClass15_1.P2xPwlQPzt6GMC8dcRoo(AssemblyReferenceHelper.\u003C\u003Ec__DisplayClass15_1.NGi0b7QPUWDSo3Ibe6FY((object) q), AssemblyReferenceHelper.\u003C\u003Ec__DisplayClass15_1.hO26iHQPctuve9de01lb(AssemblyReferenceHelper.\u003C\u003Ec__DisplayClass15_1.WbjvfPQPsRJBudq0GVTD((object) binding)))));
                if (portType != null)
                {
                  foreach (Operation operation in (CollectionBase) portType.Operations)
                    serviceReferencesInfo.MethodNames.Add(operation.Name);
                }
              }
            }
            if (string.IsNullOrEmpty(serviceReferencesInfo.Name))
              serviceReferencesInfo.Name = service.Name;
          }
        }
        else
        {
          foreach (PortType portType in (CollectionBase) contract.PortTypes)
          {
            foreach (Operation operation in (CollectionBase) portType.Operations)
              serviceReferencesInfo.MethodNames.Add(operation.Name);
          }
        }
      }
      return serviceReferencesInfo;
    }

    /// <summary>Получить имена сборок Elma</summary>
    /// <returns>Имена сборок Elma</returns>
    public static string[] GetElmaAssemblyList()
    {
      int num = 2;
      DirectoryInfo directoryInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!AssemblyReferenceHelper.JBjKf3BcVRQJwm0PPaak((object) directoryInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            directoryInfo = new DirectoryInfo((string) AssemblyReferenceHelper.gHWExxBcIMmdFCOSDYs2());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return new string[0];
label_6:
      return ((IEnumerable<FileInfo>) AssemblyReferenceHelper.uGF72eBcSCIrpWoV1ieR((object) directoryInfo, AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(-2112703338 ^ -2112622512), SearchOption.TopDirectoryOnly)).Select<FileInfo, string>((Func<FileInfo, string>) (info => Path.GetFileNameWithoutExtension(info.Name))).ToArray<string>();
    }

    static AssemblyReferenceHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyReferenceHelper.UlHpHUBciSODPpBbkrp5();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            AssemblyReferenceHelper.DefaultGlobalReferencesList = new string[5]
            {
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(-1380439818 << 3 ^ 1841318382),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(647913418 ^ 647962740),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(~-122002947 ^ 121954778),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(-53329496 >> 4 ^ -3365828),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(1581325282 << 3 ^ -234266814)
            };
            num = 3;
            continue;
          case 3:
            AssemblyReferenceHelper.DefaultWebReferences = new string[5]
            {
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(-1334993905 ^ -1335092103),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107945840),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(222162814 ^ 222064582),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(1574260816 ^ 1574228096),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(1149433385 + 173655049 ^ 1323121352)
            };
            num = 4;
            continue;
          case 4:
            goto label_2;
          default:
            AssemblyReferenceHelper.DefaultElmaReferenceList = new string[3]
            {
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(1470998129 - 231418599 ^ 1239573910),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(-488881205 ^ -488817583),
              (string) AssemblyReferenceHelper.Vjcn1SBcEP0FZsDVoL39(589593376 ^ -1977315327 ^ -1459560177)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object L2CpahBcWp5j3G236erx() => (object) TypeOf<object>.Assembly;

    internal static object ujTTxxBco6UYt5m2eLvT([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static object lrR6A1BcboudH0fWN7pB([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static bool B1OsWbBcFr7ZpqecmAfg() => AssemblyReferenceHelper.mZ7dnMBszP3dc7VA42Ke == null;

    internal static AssemblyReferenceHelper AUcMgVBcBvI2Hbodo7TU() => AssemblyReferenceHelper.mZ7dnMBszP3dc7VA42Ke;

    internal static object DFgEevBchqg6ha7gFYvk([In] object obj0) => (object) ((IOmniSharpWorker) obj0).CompletionLibsPath;

    internal static object pUeKm2BcG12bWLtg8GNW() => (object) AssemblyReferenceHelper.ExternalAssemblyLocation;

    internal static object Vjcn1SBcEP0FZsDVoL39(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object f6hs2hBcfuteCgRjX7IG([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object sJBlneBcQATD61cPgrJh([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object ErFQ9UBcCYWH10YpkBJc([In] object obj0) => (object) WebRequest.Create((Uri) obj0);

    internal static object nF4I5HBcvUVRyVuYEUV7([In] object obj0) => (object) ((WebRequest) obj0).GetResponse();

    internal static object ENbhCnBc8JCmjmoIlwyA([In] object obj0) => (object) ((WebResponse) obj0).GetResponseStream();

    internal static object PSXW0bBcZW2jouy02RaB([In] object obj0) => (object) ((TextReader) obj0).ReadToEnd();

    internal static void PJBv4gBcuaTyBkxKDBDi([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object gHWExxBcIMmdFCOSDYs2() => (object) AssemblyReferenceHelper.ElmaAssemblyLocation;

    internal static bool JBjKf3BcVRQJwm0PPaak([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static object uGF72eBcSCIrpWoV1ieR([In] object obj0, [In] object obj1, [In] SearchOption obj2) => (object) ((DirectoryInfo) obj0).GetFiles((string) obj1, obj2);

    internal static void UlHpHUBciSODPpBbkrp5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
