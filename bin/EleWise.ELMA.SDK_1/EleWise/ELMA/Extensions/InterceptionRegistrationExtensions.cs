// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.InterceptionRegistrationExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Extras.DynamicProxy;
using Autofac.Features.Scanning;
using Castle.DynamicProxy;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Internal;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Cache;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Расширения для генерации перехватчиков Autofac с возможностью кэширования сгенерированных сборок
  /// </summary>
  internal static class InterceptionRegistrationExtensions
  {
    private static readonly Dictionary<string, IProxyBuilder> ProxyBuilders;
    private static readonly Dictionary<string, IProxyBuilder> CacheProxyBuilders;
    private static readonly List<Type> CacheableTypes;
    private static readonly Dictionary<string, ProxiesAssemblyCache> AsmCaches;
    private static readonly IEnumerable<Service> EmptyServices;
    private static readonly string CachePathName;
    private static readonly List<Assembly> CacheProxyAssemblies;
    internal static InterceptionRegistrationExtensions eQTEqOG6VXXEExeYk5LR;

    /// <summary>Загрузить кэш</summary>
    /// <param name="cacheableTypes">Типы, для которых нужно активировать кэширование</param>
    /// <param name="asmCaches">Закэшированные сборки</param>
    public static void LoadCache(
      IEnumerable<Type> cacheableTypes,
      IEnumerable<ProxiesAssemblyCache> asmCaches)
    {
      InterceptionRegistrationExtensions.CacheableTypes.Clear();
      InterceptionRegistrationExtensions.AsmCaches.Clear();
      if (cacheableTypes == null)
        return;
      Type[] array = cacheableTypes.ToArray<Type>();
      InterceptionRegistrationExtensions.CacheableTypes.AddRange((IEnumerable<Type>) array);
      Dictionary<string, List<Type>> dictionary = new Dictionary<string, List<Type>>();
      foreach (Type type in array)
      {
        string shA1Base64Hash = InterceptionRegistrationExtensions.GetProxyAssemblyName(type).AssemblyName.GetSHA1Base64Hash();
        List<Type> typeList;
        if (!dictionary.TryGetValue(shA1Base64Hash, out typeList))
        {
          typeList = new List<Type>();
          dictionary[shA1Base64Hash] = typeList;
        }
        typeList.Add(type);
      }
      ProxiesAssemblyCache[] source = asmCaches != null ? asmCaches.ToArray<ProxiesAssemblyCache>() : new ProxiesAssemblyCache[0];
      foreach (KeyValuePair<string, List<Type>> keyValuePair in dictionary)
      {
        KeyValuePair<string, List<Type>> pair = keyValuePair;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ProxiesAssemblyCache proxiesAssemblyCache = ((IEnumerable<ProxiesAssemblyCache>) source).FirstOrDefault<ProxiesAssemblyCache>((Func<ProxiesAssemblyCache, bool>) (a => InterceptionRegistrationExtensions.\u003C\u003Ec__DisplayClass0_0.PmYrUQ8h6SRsPgYjyt35(InterceptionRegistrationExtensions.\u003C\u003Ec__DisplayClass0_0.YpNt678h4okohPmmJLDK((object) a), (object) pair.Key)));
        string typesSignatureHash = ProxiesAssemblyCache.EvaluateTypesSignatureHash((IEnumerable<Type>) pair.Value);
        if (proxiesAssemblyCache != null && proxiesAssemblyCache.TypeSignaturesHash != typesSignatureHash)
          proxiesAssemblyCache = (ProxiesAssemblyCache) null;
        if (proxiesAssemblyCache == null)
          proxiesAssemblyCache = new ProxiesAssemblyCache()
          {
            AssemblyNameHash = pair.Key,
            TypeSignaturesHash = typesSignatureHash
          };
        InterceptionRegistrationExtensions.AsmCaches.Add(proxiesAssemblyCache.AssemblyNameHash, proxiesAssemblyCache);
      }
    }

    /// <summary>Сохранить кэш со сборками</summary>
    public static IEnumerable<ProxiesAssemblyCache> SaveCache()
    {
      lock (InterceptionRegistrationExtensions.ProxyBuilders)
      {
        List<ProxiesAssemblyCache> proxiesAssemblyCacheList = new List<ProxiesAssemblyCache>();
        try
        {
          foreach (KeyValuePair<string, IProxyBuilder> cacheProxyBuilder in InterceptionRegistrationExtensions.CacheProxyBuilders)
          {
            string key = cacheProxyBuilder.Key;
            ProxiesAssemblyCache proxiesAssemblyCache;
            if (InterceptionRegistrationExtensions.AsmCaches.TryGetValue(key.GetSHA1Base64Hash(), out proxiesAssemblyCache) && proxiesAssemblyCache != null)
            {
              ModuleScope moduleScope = cacheProxyBuilder.Value.ModuleScope;
              if (proxiesAssemblyCache.AssemblyRaw == null && ((System.Reflection.Module) moduleScope.WeakNamedModule != (System.Reflection.Module) null || (System.Reflection.Module) moduleScope.StrongNamedModule != (System.Reflection.Module) null))
              {
                if (!Directory.Exists(InterceptionRegistrationExtensions.CachePathName))
                  Directory.CreateDirectory(InterceptionRegistrationExtensions.CachePathName);
                bool strongNamed = (System.Reflection.Module) moduleScope.WeakNamedModule == (System.Reflection.Module) null && (System.Reflection.Module) moduleScope.StrongNamedModule != (System.Reflection.Module) null;
                moduleScope.SaveAssembly(strongNamed);
                string path = Path.Combine(InterceptionRegistrationExtensions.CachePathName, key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16704931));
                if (File.Exists(path))
                  proxiesAssemblyCache.AssemblyRaw = File.ReadAllBytes(path);
              }
              proxiesAssemblyCacheList.Add(proxiesAssemblyCache);
            }
          }
          InterceptionRegistrationExtensions.ProxyBuilders.Clear();
          InterceptionRegistrationExtensions.CacheProxyBuilders.Clear();
          InterceptionRegistrationExtensions.CacheableTypes.Clear();
          InterceptionRegistrationExtensions.AsmCaches.Clear();
        }
        finally
        {
          if (Directory.Exists(InterceptionRegistrationExtensions.CachePathName))
          {
            try
            {
              Directory.Delete(InterceptionRegistrationExtensions.CachePathName, true);
            }
            catch (Exception ex)
            {
              Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867116767), ex);
            }
          }
        }
        return (IEnumerable<ProxiesAssemblyCache>) proxiesAssemblyCacheList.ToArray();
      }
    }

    /// <summary>
    /// Enable class interception on the target type. Interceptors will be determined
    /// via Intercept attributes on the class or added with InterceptedBy().
    /// Only virtual methods can be intercepted this way.
    /// </summary>
    /// <typeparam name="TLimit"></typeparam>
    /// <typeparam name="TRegistrationStyle"></typeparam>
    /// <param name="registration"></param>
    /// <returns></returns>
    public static IRegistrationBuilder<TLimit, ScanningActivatorData, TRegistrationStyle> EnableClassInterceptorsCacheable<TLimit, TRegistrationStyle>(
      this IRegistrationBuilder<TLimit, ScanningActivatorData, TRegistrationStyle> registration)
    {
      if (registration == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146248111));
      registration.ActivatorData.ConfigurationActions.Add((Action<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>) ((t, rb) => rb.EnableClassInterceptorsCacheable<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>()));
      return registration;
    }

    /// <summary>
    /// Enable class interception on the target type. Interceptors will be determined
    /// via Intercept attributes on the class or added with InterceptedBy().
    /// Only virtual methods can be intercepted this way.
    /// </summary>
    /// <typeparam name="TLimit"></typeparam>
    /// <typeparam name="TRegistrationStyle"></typeparam>
    /// <typeparam name="TConcreteReflectionActivatorData"></typeparam>
    /// <param name="registration"></param>
    /// <returns></returns>
    public static IRegistrationBuilder<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> EnableClassInterceptorsCacheable<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>(
      this IRegistrationBuilder<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> registration)
      where TConcreteReflectionActivatorData : ConcreteReflectionActivatorData
    {
      registration.ActivatorData.ImplementationType = InterceptionRegistrationExtensions.GetBuilder(registration.ActivatorData.ImplementationType).CreateClassProxyType(registration.ActivatorData.ImplementationType, new Type[0], ProxyGenerationOptions.Default);
      registration.OnPreparing((Action<PreparingEventArgs>) (e =>
      {
        int num = 2;
        PreparingEventArgs e1;
        while (true)
        {
          switch (num)
          {
            case 1:
              e1 = e;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              e1.Parameters = (IEnumerable<Parameter>) ((IEnumerable<Parameter>) new Parameter[1]
              {
                (Parameter) new PositionalParameter(0, (object) InterceptionRegistrationExtensions.GetInterceptorServices((object) e1.Component, registration.ActivatorData.ImplementationType).Select<Service, object>((Func<Service, object>) (s => e1.Context.ResolveService(s))).Cast<IInterceptor>().ToArray<IInterceptor>())
              }).Concat<Parameter>(e1.Parameters).ToArray<Parameter>();
              num = 3;
              continue;
          }
        }
label_2:;
      }));
      return registration;
    }

    static InterceptionRegistrationExtensions()
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            InterceptionRegistrationExtensions.EmptyServices = (IEnumerable<Service>) new Service[0];
            num = 6;
            continue;
          case 2:
            InterceptionRegistrationExtensions.CacheProxyBuilders = new Dictionary<string, IProxyBuilder>();
            num = 8;
            continue;
          case 3:
            InterceptionRegistrationExtensions.CachePathName = (string) InterceptionRegistrationExtensions.vySCqBG6qCkn3eRKSWDc(InterceptionRegistrationExtensions.v1kSFhG6RBtCuxSVneb1(-1638402543 ^ -1638664289));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          case 4:
            InterceptionRegistrationExtensions.ProxyBuilders = new Dictionary<string, IProxyBuilder>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 1;
            continue;
          case 5:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = 4;
            continue;
          case 6:
            InterceptionRegistrationExtensions.CacheProxyAssemblies = new List<Assembly>();
            num = 3;
            continue;
          case 7:
            InterceptionRegistrationExtensions.AsmCaches = new Dictionary<string, ProxiesAssemblyCache>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
            continue;
          case 8:
            InterceptionRegistrationExtensions.CacheableTypes = new List<Type>();
            num = 7;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_11:;
    }

    /// <summary>Получить имя сборки для прокси-класса указанного типа</summary>
    /// <param name="type">Тип, для которого создается прокси-класс</param>
    /// <param name="needStrongName">Необходимость вычисления строгого имени</param>
    /// <returns>Имя сборки и является ли она сборкой со строгим именем</returns>
    private static (string AssemblyName, bool StrongNamed) GetProxyAssemblyName(
      Type type,
      bool needStrongName = false)
    {
      IEnumerable<Type> source1;
      if (!type.IsGenericType || type.IsGenericTypeDefinition)
        source1 = (IEnumerable<Type>) new Type[1]{ type };
      else
        source1 = ((IEnumerable<Type>) type.GetGenericArguments()).Prepend<Type>(type.GetGenericTypeDefinition());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      SortedSet<Assembly> source2 = new SortedSet<Assembly>(source1.Select<Type, Assembly>((Func<Type, Assembly>) (t => t.Assembly)), (IComparer<Assembly>) FunctorComparer<Assembly>.Create((Comparison<Assembly>) ((a, b) => InterceptionRegistrationExtensions.\u003C\u003Ec.FHBVdy8hjASQwSctX5yU(InterceptionRegistrationExtensions.\u003C\u003Ec.owBbAp8hglkE5W919x32(), InterceptionRegistrationExtensions.\u003C\u003Ec.jV1KXw8h5C1atcOgJZmc((object) a), (object) b.FullName))));
      string str = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979250613), source2.Select<Assembly, string>(new Func<Assembly, string>(ComponentManager.GetAssemblyShortName))) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123638598) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87467927);
      return needStrongName ? (str, source2.All<Assembly>((Func<Assembly, bool>) (a =>
      {
        int num = 1;
        object obj;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              obj = InterceptionRegistrationExtensions.\u003C\u003Ec.aJlBrw8hLpvYoZBRlXBh(InterceptionRegistrationExtensions.\u003C\u003Ec.LyHplJ8hYufwUIxPxO3B((object) a));
              if (obj == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return false;
label_5:
        return obj.Length != 0;
      }))) : (str, false);
    }

    internal static bool IsProxyAssembly(Assembly asm)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!InterceptionRegistrationExtensions.CacheProxyAssemblies.Contains(asm))
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 2:
            if (!asm.IsDynamic)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          case 3:
            goto label_3;
          case 4:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      return true;
label_3:
      return false;
label_4:
      return true;
    }

    private static IEnumerable<Service> GetInterceptorServices(object registration, Type implType)
    {
      if (registration == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461363435));
      if (implType == (Type) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538781262));
      IEnumerable<Service> services = InterceptionRegistrationExtensions.EmptyServices;
      object second;
      if (((IComponentRegistration) registration).Metadata.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132650119), out second))
        services = services.Concat<Service>((IEnumerable<Service>) second);
      if (implType.IsClass)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        services = services.Concat<Service>(implType.GetCustomAttributes(typeof (InterceptAttribute), true).Cast<InterceptAttribute>().Select<InterceptAttribute, Service>((Func<InterceptAttribute, Service>) (att => (Service) InterceptionRegistrationExtensions.\u003C\u003Ec.w5FIWE8hUjhRx8rrpqoJ((object) att)))).Concat<Service>(((IEnumerable<Type>) implType.GetInterfaces()).SelectMany<Type, object>((Func<Type, IEnumerable<object>>) (i => (IEnumerable<object>) i.GetCustomAttributes(typeof (InterceptAttribute), true))).Cast<InterceptAttribute>().Select<InterceptAttribute, Service>((Func<InterceptAttribute, Service>) (att => (Service) InterceptionRegistrationExtensions.\u003C\u003Ec.w5FIWE8hUjhRx8rrpqoJ((object) att))));
      }
      return (IEnumerable<Service>) services.ToArray<Service>();
    }

    private static IProxyBuilder GetBuilder(Type type)
    {
      int num1 = 3;
      Dictionary<string, IProxyBuilder> proxyBuilders;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
            continue;
          case 3:
            proxyBuilders = InterceptionRegistrationExtensions.ProxyBuilders;
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      IProxyBuilder builder;
      return builder;
label_4:
      try
      {
        Monitor.Enter((object) proxyBuilders, ref lockTaken);
        int num2 = 5;
        while (true)
        {
          (string AssemblyName, bool StrongNamed) proxyAssemblyName;
          string assemblyName;
          string str;
          IProxyBuilder proxyBuilder;
          bool flag;
          Dictionary<string, IProxyBuilder> dictionary1;
          Assembly assembly;
          ProxiesAssemblyCache proxiesAssemblyCache;
          Dictionary<string, IProxyBuilder> dictionary2;
          switch (num2)
          {
            case 1:
              flag = InterceptionRegistrationExtensions.CacheableTypes.Contains(type);
              num2 = 3;
              continue;
            case 2:
            case 16:
              builder = proxyBuilder;
              num2 = 18;
              continue;
            case 3:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 2;
                continue;
              }
              dictionary2 = InterceptionRegistrationExtensions.CacheProxyBuilders;
              break;
            case 4:
              dictionary2 = InterceptionRegistrationExtensions.ProxyBuilders;
              break;
            case 5:
              proxyAssemblyName = InterceptionRegistrationExtensions.GetProxyAssemblyName(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
              continue;
            case 7:
              InterceptionRegistrationExtensions.CacheProxyAssemblies.Add(assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 11 : 11;
              continue;
            case 8:
              if (dictionary1.TryGetValue(assemblyName, out proxyBuilder))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 2;
                continue;
              }
              goto case 15;
            case 9:
              proxyBuilder = (IProxyBuilder) new InterceptionRegistrationExtensions.CustomProxyBuilder(new ModuleScope(true, !proxyAssemblyName.StrongNamed, assemblyName, str, assemblyName, str));
              num2 = 17;
              continue;
            case 11:
              InterceptionRegistrationExtensions.M0Q3OMG62Eu544korKVk(InterceptionRegistrationExtensions.xQHclWG6OjbkP0WnMV57((object) proxyBuilder), (object) assembly);
              num2 = 6;
              continue;
            case 13:
              assemblyName = proxyAssemblyName.AssemblyName;
              num2 = 8;
              continue;
            case 14:
              assembly = (Assembly) InterceptionRegistrationExtensions.poeerbG6nQIAZjfWbkD7(InterceptionRegistrationExtensions.M8GkSyG6ktNiT81E598Z((object) proxiesAssemblyCache));
              num2 = 7;
              continue;
            case 15:
              str = (string) InterceptionRegistrationExtensions.UwVhSAG6X3fY8WLuYto5((object) InterceptionRegistrationExtensions.CachePathName, InterceptionRegistrationExtensions.MYDRKFG6KqBmKlkPmcNe((object) assemblyName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870842227)));
              num2 = 9;
              continue;
            case 17:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 10 : 12;
                continue;
              }
              goto case 20;
            case 18:
              goto label_2;
            case 19:
              if (proxiesAssemblyCache.AssemblyRaw == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 10 : 10;
                continue;
              }
              goto case 14;
            case 20:
              if (!InterceptionRegistrationExtensions.AsmCaches.TryGetValue((string) InterceptionRegistrationExtensions.ERrWP0G6T7nYLVm0EqIb((object) assemblyName), out proxiesAssemblyCache))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              goto case 19;
            default:
              dictionary1.Add(assemblyName, proxyBuilder);
              num2 = 16;
              continue;
          }
          dictionary1 = dictionary2;
          num2 = 13;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                Monitor.Exit((object) proxyBuilders);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                continue;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
    }

    internal static object v1kSFhG6RBtCuxSVneb1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vySCqBG6qCkn3eRKSWDc([In] object obj0) => (object) IOExtensions.GetTempPath((string) obj0);

    internal static bool MiJmLBG6SBQq7fIdY2rn() => InterceptionRegistrationExtensions.eQTEqOG6VXXEExeYk5LR == null;

    internal static InterceptionRegistrationExtensions ma76JtG6iFsBZEJ2tgkQ() => InterceptionRegistrationExtensions.eQTEqOG6VXXEExeYk5LR;

    internal static object MYDRKFG6KqBmKlkPmcNe([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object UwVhSAG6X3fY8WLuYto5([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object ERrWP0G6T7nYLVm0EqIb([In] object obj0) => (object) ((string) obj0).GetSHA1Base64Hash();

    internal static object M8GkSyG6ktNiT81E598Z([In] object obj0) => (object) ((ProxiesAssemblyCache) obj0).AssemblyRaw;

    internal static object poeerbG6nQIAZjfWbkD7([In] object obj0) => (object) ComponentManager.LoadAssembly((byte[]) obj0);

    internal static object xQHclWG6OjbkP0WnMV57([In] object obj0) => (object) ((IProxyBuilder) obj0).ModuleScope;

    internal static void M0Q3OMG62Eu544korKVk([In] object obj0, [In] object obj1) => ((ModuleScope) obj0).LoadAssemblyIntoCache((Assembly) obj1);

    private class CustomClassProxyGenerator : ClassProxyGenerator
    {
      internal static object DrgF508hXDwUNvn3Hdxt;

      public CustomClassProxyGenerator(ModuleScope scope, Type targetType)
      {
        InterceptionRegistrationExtensions.CustomClassProxyGenerator.t3c3QW8hnIrA9GqILM7Z();
        // ISSUE: explicit constructor call
        base.\u002Ector(scope, targetType);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      protected override ClassEmitter BuildClassEmitter(
        string typeName,
        Type parentType,
        IEnumerable<Type> interfaces)
      {
        this.CheckNotGenericTypeDefinition(parentType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561285698));
        this.CheckNotGenericTypeDefinitions(interfaces, z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825735668));
        return new ClassEmitter(this.Scope, typeName, parentType, interfaces, TypeAttributes.Public | TypeAttributes.Serializable, false);
      }

      internal static void t3c3QW8hnIrA9GqILM7Z() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool tdqZHK8hTBNrS9N9cNHd() => InterceptionRegistrationExtensions.CustomClassProxyGenerator.DrgF508hXDwUNvn3Hdxt == null;

      internal static InterceptionRegistrationExtensions.CustomClassProxyGenerator fK3l2C8hkKhBDk6OFn6C() => (InterceptionRegistrationExtensions.CustomClassProxyGenerator) InterceptionRegistrationExtensions.CustomClassProxyGenerator.DrgF508hXDwUNvn3Hdxt;
    }

    private class CustomProxyBuilder : IProxyBuilder
    {
      private readonly object scope;
      private object logger;
      internal static object LtYdMt8hO61XK7yrWnYV;

      public CustomProxyBuilder(ModuleScope scope)
      {
        InterceptionRegistrationExtensions.CustomProxyBuilder.nYfF2W8hPyrhDoQVJf0G();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.logger = (object) Castle.Core.Logging.NullLogger.Instance;
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this.scope = (object) scope;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      public Type CreateClassProxyType(
        Type classToProxy,
        Type[] additionalInterfacesToProxy,
        ProxyGenerationOptions options)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.AssertValidType(classToProxy);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              this.AssertValidTypes((IEnumerable<Type>) additionalInterfacesToProxy);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 2;
              continue;
          }
        }
label_3:
        InterceptionRegistrationExtensions.CustomClassProxyGenerator classProxyGenerator = new InterceptionRegistrationExtensions.CustomClassProxyGenerator((ModuleScope) this.scope, classToProxy);
        InterceptionRegistrationExtensions.CustomProxyBuilder.d4dOP98h1TVcblHAjX1E((object) classProxyGenerator, this.logger);
        return InterceptionRegistrationExtensions.CustomProxyBuilder.T3qx3s8hNYcmFW0B0L4E((object) classProxyGenerator, (object) additionalInterfacesToProxy, (object) options);
      }

      private void AssertValidType(Type target)
      {
        int num1 = 16;
        while (true)
        {
          int num2 = num1;
          bool isNested;
          while (true)
          {
            int num3;
            int num4;
            int num5;
            int num6;
            switch (num2)
            {
              case 1:
                if (target.IsVisible)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 8 : 12;
                  continue;
                }
                goto case 11;
              case 2:
                if (target.IsNestedAssembly)
                {
                  num2 = 8;
                  continue;
                }
                goto case 6;
              case 3:
label_10:
                num3 = InterceptionRegistrationExtensions.CustomProxyBuilder.AqVs5u8h3bxG81QJb4Cc((object) target.Assembly) ? 1 : 0;
                goto label_28;
              case 4:
                goto label_18;
              case 5:
                num6 = 1;
                goto label_30;
              case 6:
                num5 = target.IsNestedFamORAssem ? 1 : 0;
                break;
              case 7:
                if (!target.IsGenericTypeDefinition)
                {
                  num2 = 13;
                  continue;
                }
                goto label_21;
              case 8:
                num5 = 1;
                break;
              case 9:
                goto label_21;
              case 10:
                if (target.IsPublic)
                {
                  num2 = 5;
                  continue;
                }
                goto case 14;
              case 11:
                num4 = !isNested ? 1 : 0;
                goto label_25;
              case 12:
                num4 = 0;
                goto label_25;
              case 13:
                goto label_15;
              case 14:
                num6 = target.IsNestedPublic ? 1 : 0;
                goto label_30;
              case 15:
                if (isNested)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 2;
                  continue;
                }
                num5 = 0;
                break;
              case 16:
                goto label_11;
              default:
                num3 = 0;
                goto label_28;
            }
            bool flag1 = num5 != 0;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
label_25:
            int num7 = flag1 ? 1 : 0;
            if ((num4 | num7) == 0)
            {
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
label_28:
            bool flag2 = num3 != 0;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 10 : 6;
            continue;
label_30:
            int num8 = flag2 ? 1 : 0;
            if ((num6 | num8) != 0)
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 7 : 6;
            else
              goto label_18;
          }
label_11:
          isNested = target.IsNested;
          num1 = 15;
        }
label_15:
        return;
label_18:
        throw new GeneratorException((string) InterceptionRegistrationExtensions.CustomProxyBuilder.KiNFBn8haY5SoH3PQ7TL(InterceptionRegistrationExtensions.CustomProxyBuilder.KPyCnp8hpERcJRFCKBuu(825385222 ^ 825735180), (object) target.FullName, InterceptionRegistrationExtensions.CustomProxyBuilder.KPyCnp8hpERcJRFCKBuu(654297945 ^ 653922881)));
label_21:
        throw new GeneratorException((string) InterceptionRegistrationExtensions.CustomProxyBuilder.KiNFBn8haY5SoH3PQ7TL(InterceptionRegistrationExtensions.CustomProxyBuilder.KPyCnp8hpERcJRFCKBuu(1052221104 - 768835541 ^ 283232209), (object) target.FullName, InterceptionRegistrationExtensions.CustomProxyBuilder.KPyCnp8hpERcJRFCKBuu(1251470110 >> 2 ^ 312484719)));
      }

      private void AssertValidTypes(IEnumerable<Type> targetTypes)
      {
        if (targetTypes == null)
          return;
        foreach (Type targetType in targetTypes)
          this.AssertValidType(targetType);
      }

      public Type CreateClassProxyTypeWithTarget(
        Type classToProxy,
        Type[] additionalInterfacesToProxy,
        ProxyGenerationOptions options)
      {
        throw new NotImplementedException();
      }

      public Type CreateInterfaceProxyTypeWithTarget(
        Type interfaceToProxy,
        Type[] additionalInterfacesToProxy,
        Type targetType,
        ProxyGenerationOptions options)
      {
        throw new NotImplementedException();
      }

      public Type CreateInterfaceProxyTypeWithTargetInterface(
        Type interfaceToProxy,
        Type[] additionalInterfacesToProxy,
        ProxyGenerationOptions options)
      {
        throw new NotImplementedException();
      }

      public Type CreateInterfaceProxyTypeWithoutTarget(
        Type interfaceToProxy,
        Type[] additionalInterfacesToProxy,
        ProxyGenerationOptions options)
      {
        throw new NotImplementedException();
      }

      public Castle.Core.Logging.ILogger Logger
      {
        get => (Castle.Core.Logging.ILogger) this.logger;
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
                this.logger = (object) value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

      public ModuleScope ModuleScope => (ModuleScope) this.scope;

      internal static void nYfF2W8hPyrhDoQVJf0G() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool YpSiY78h2u5kpHvR5L96() => InterceptionRegistrationExtensions.CustomProxyBuilder.LtYdMt8hO61XK7yrWnYV == null;

      internal static InterceptionRegistrationExtensions.CustomProxyBuilder I89ifk8heEebw9sEphda() => (InterceptionRegistrationExtensions.CustomProxyBuilder) InterceptionRegistrationExtensions.CustomProxyBuilder.LtYdMt8hO61XK7yrWnYV;

      internal static void d4dOP98h1TVcblHAjX1E([In] object obj0, [In] object obj1) => ((BaseProxyGenerator) obj0).Logger = (Castle.Core.Logging.ILogger) obj1;

      internal static Type T3qx3s8hNYcmFW0B0L4E([In] object obj0, [In] object obj1, [In] object obj2) => ((ClassProxyGenerator) obj0).GenerateCode((Type[]) obj1, (ProxyGenerationOptions) obj2);

      internal static bool AqVs5u8h3bxG81QJb4Cc([In] object obj0) => InternalsUtil.IsInternalToDynamicProxy((Assembly) obj0);

      internal static object KPyCnp8hpERcJRFCKBuu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object KiNFBn8haY5SoH3PQ7TL([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);
    }
  }
}
