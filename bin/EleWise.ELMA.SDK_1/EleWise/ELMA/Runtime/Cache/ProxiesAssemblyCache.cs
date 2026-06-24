// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Cache.ProxiesAssemblyCache
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Runtime.Cache
{
  /// <summary>Кэш сборки с прокси-классами</summary>
  internal class ProxiesAssemblyCache
  {
    private byte[] assemblyRaw;
    private string fileName;
    private static ProxiesAssemblyCache pKBGU0WPvA838hE3c3AX;

    public ProxiesAssemblyCache()
    {
      ProxiesAssemblyCache.hQiPxiWPuSp9ivWEJGu5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ProxiesAssemblyCache(string fileName)
    {
      ProxiesAssemblyCache.hQiPxiWPuSp9ivWEJGu5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      string[] strArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            strArray = (string[]) ProxiesAssemblyCache.ewONRsWPVRvmwDKPYK7x(ProxiesAssemblyCache.NcNO2NWPIqmOcdCEjR9Q((object) Path.GetFileName(fileName)), (object) new char[1]
            {
              '-'
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 4;
            continue;
          case 3:
            this.fileName = fileName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
          case 4:
            this.AssemblyNameHash = (string) ProxiesAssemblyCache.NjAcgXWPSR6qfq20Vvob((object) strArray[0]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            this.TypeSignaturesHash = (string) ProxiesAssemblyCache.NjAcgXWPSR6qfq20Vvob((object) strArray[1]);
            num = 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Хэш-код имени сборки с прокси-классами</summary>
    public string AssemblyNameHash
    {
      get => this.\u003CAssemblyNameHash\u003Ek__BackingField;
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
              this.\u003CAssemblyNameHash\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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

    /// <summary>Хэш-код, сформированный по сигнатурам типов</summary>
    public string TypeSignaturesHash
    {
      get => this.\u003CTypeSignaturesHash\u003Ek__BackingField;
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
              this.\u003CTypeSignaturesHash\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
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

    /// <summary>Raw сгенерированной сборки с прокси-классами</summary>
    public byte[] AssemblyRaw
    {
      get
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.fileName == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 4:
              if (this.assemblyRaw != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 3;
                continue;
              }
              goto case 1;
            case 5:
              this.assemblyRaw = File.ReadAllBytes(this.fileName);
              num = 2;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return this.assemblyRaw;
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
              this.assemblyRaw = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    public string GetCacheFileName() => (string) ProxiesAssemblyCache.NOqxBfWPq7H5PR4BU3dG(ProxiesAssemblyCache.pqOjXdWPi802BdLB2Flb((object) this.AssemblyNameHash), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312865963), ProxiesAssemblyCache.pqOjXdWPi802BdLB2Flb((object) this.TypeSignaturesHash), ProxiesAssemblyCache.tpHi8SWPRyNvoaWFT9R4(-1426456882 ^ 2009939514 ^ -583695282));

    /// <summary>Вычислить хэш-код сигнатуры типов</summary>
    /// <param name="types">Список типов</param>
    /// <returns>Хэш-код</returns>
    public static string EvaluateTypesSignatureHash(IEnumerable<Type> types) => (types.Count<Type>().ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70040998) + ProxiesAssemblyCache.EvaluateTypesSignature(types)).GetSHA1Base64Hash();

    /// <summary>Вычислить сигнатуру типов</summary>
    /// <param name="types">Список типов</param>
    /// <returns>Сигнатура методов</returns>
    public static string EvaluateTypesSignature(IEnumerable<Type> types)
    {
      if (types == null)
        return string.Empty;
      List<Type> processedTypes = new List<Type>();
      StringBuilder signature = new StringBuilder();
      foreach (Type type in (IEnumerable<Type>) types.OrderBy<Type, string>((Func<Type, string>) (t => t.FullName)))
        ProxiesAssemblyCache.EvaluateTypeSignature(type, processedTypes, (object) signature);
      return signature.ToString();
    }

    private static void EvaluateTypeSignature(
      Type type,
      List<Type> processedTypes,
      object signature)
    {
      if (processedTypes.Contains(type))
        return;
      processedTypes.Add(type);
      ((StringBuilder) signature).AppendLine(type.FullName);
      Type[] genericArguments = !type.IsGenericType || type.IsGenericTypeDefinition ? (Type[]) null : type.GetGenericArguments();
      if (genericArguments != null && genericArguments.Length != 0)
      {
        ((StringBuilder) signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787016628));
        for (int index = 0; index < genericArguments.Length; ++index)
        {
          if (index > 0)
            ((StringBuilder) signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629864494));
          ((StringBuilder) signature).Append((object) genericArguments[index]);
        }
        ((StringBuilder) signature).AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239584098));
        ProxiesAssemblyCache.EvaluateTypeSignature(type.GetGenericTypeDefinition(), processedTypes, signature);
      }
      else
      {
        foreach (MethodInfo methodInfo in (IEnumerable<MethodInfo>) ((IEnumerable<MethodInfo>) type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)).OrderBy<MethodInfo, string>((Func<MethodInfo, string>) (m => m.ToString())))
        {
          ((StringBuilder) signature).Append(methodInfo.Name);
          if (methodInfo.IsVirtual)
            ((StringBuilder) signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536671328));
          string str1 = methodInfo.ReturnType != (Type) null ? methodInfo.ReturnType.AssemblyQualifiedName ?? methodInfo.ReturnType.Name : (string) null;
          if (str1 != null)
          {
            ((StringBuilder) signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514960437));
            ((StringBuilder) signature).Append(str1);
          }
          ((StringBuilder) signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501465663));
          ParameterInfo[] parameters = methodInfo.GetParameters();
          for (int index = 0; index < parameters.Length; ++index)
          {
            if (index > 0)
              ((StringBuilder) signature).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647892282));
            ParameterInfo parameterInfo = parameters[index];
            string str2 = parameterInfo.ParameterType.AssemblyQualifiedName ?? parameterInfo.ParameterType.Name;
            ((StringBuilder) signature).Append(str2);
          }
          ((StringBuilder) signature).AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137456526));
        }
        if (!(type.BaseType != (Type) null))
          return;
        ProxiesAssemblyCache.EvaluateTypeSignature(type.BaseType, processedTypes, signature);
      }
    }

    /// <summary>
    /// Получить список закэшированных сборок с прокси-объектами
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<ProxiesAssemblyCache> GetProxiesAssemblyCaches(string cacheName)
    {
      string cacheFolder = ProxiesAssemblyCache.GetCacheFolder((object) cacheName);
      return !Directory.Exists(cacheFolder) ? (IEnumerable<ProxiesAssemblyCache>) new ProxiesAssemblyCache[0] : (IEnumerable<ProxiesAssemblyCache>) ((IEnumerable<string>) Directory.GetFiles(cacheFolder)).Select<string, ProxiesAssemblyCache>((Func<string, ProxiesAssemblyCache>) (fileName => new ProxiesAssemblyCache(fileName))).ToArray<ProxiesAssemblyCache>();
    }

    /// <summary>
    /// Сохранить список закэшированных сборок с прокси-объектами
    /// </summary>
    /// <returns></returns>
    public static void SaveProxiesAssemblyCaches(
      IEnumerable<ProxiesAssemblyCache> caches,
      string cacheName)
    {
      string cacheFolder = ProxiesAssemblyCache.GetCacheFolder((object) cacheName);
      if (!Directory.Exists(cacheFolder))
        Directory.CreateDirectory(cacheFolder);
      // ISSUE: reference to a compiler-generated method
      List<string> list = ((IEnumerable<string>) Directory.GetFiles(cacheFolder)).Select<string, string>((Func<string, string>) (f => (string) ProxiesAssemblyCache.\u003C\u003Ec.hkXBsOQArAyQZxsvLxp2((object) f))).ToList<string>();
      foreach (ProxiesAssemblyCache cach in caches)
      {
        string cacheFileName = cach.GetCacheFileName();
        if (list.Contains(cacheFileName))
          list.Remove(cacheFileName);
        else if (cach.AssemblyRaw != null)
          File.WriteAllBytes(Path.Combine(cacheFolder, cacheFileName), cach.AssemblyRaw);
      }
      foreach (string path2 in list)
        File.Delete(Path.Combine(cacheFolder, path2));
    }

    private static string GetCacheFolder(object cacheName)
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (ProxiesAssemblyCache.i9WLggWPTMiyT8lenHhN(cacheName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            str = (string) ProxiesAssemblyCache.F7bhUdWPXxWLlAeJFvNd((object) ((ComponentManager) ProxiesAssemblyCache.A1GjNCWPKUhgtn2sCwBB()).WorkDirectory, ProxiesAssemblyCache.tpHi8SWPRyNvoaWFT9R4(1925118608 << 2 ^ -889592226));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return (string) ProxiesAssemblyCache.F7bhUdWPXxWLlAeJFvNd((object) str, cacheName);
label_3:
      return (string) cacheName;
    }

    internal static void hQiPxiWPuSp9ivWEJGu5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool WZ1d2DWP8hl3LwUWk0Da() => ProxiesAssemblyCache.pKBGU0WPvA838hE3c3AX == null;

    internal static ProxiesAssemblyCache oG1UDiWPZ21DEtsTfRTu() => ProxiesAssemblyCache.pKBGU0WPvA838hE3c3AX;

    internal static object NcNO2NWPIqmOcdCEjR9Q([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object ewONRsWPVRvmwDKPYK7x([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object NjAcgXWPSR6qfq20Vvob([In] object obj0) => (object) ((string) obj0).Base64StringFromValidFileName();

    internal static object pqOjXdWPi802BdLB2Flb([In] object obj0) => (object) ((string) obj0).Base64StringToValidFileName();

    internal static object tpHi8SWPRyNvoaWFT9R4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NOqxBfWPq7H5PR4BU3dG(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object A1GjNCWPKUhgtn2sCwBB() => (object) ComponentManager.Current;

    internal static object F7bhUdWPXxWLlAeJFvNd([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool i9WLggWPTMiyT8lenHhN([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
