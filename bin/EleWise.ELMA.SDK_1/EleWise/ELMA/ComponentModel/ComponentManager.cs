// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ComponentManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using Autofac.Features.Metadata;
using Castle.DynamicProxy;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Actions.Impl;
using EleWise.ELMA.ActorModel;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Cache.Modules;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Hubs.Attributes;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Storages;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Interceptors;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Менеджер компонентов</summary>
  public class ComponentManager : IComponentManager, IDisposable
  {
    private bool disposed;
    /// <summary>Данные для регистрации</summary>
    protected internal ComponentManager.RegistrationData registrationData;
    /// <summary>Список загруженных компонентных сборок</summary>
    protected readonly List<Assembly> componentAssemblies;
    /// <summary>Список обработанных сборок</summary>
    protected readonly List<Assembly> processedAssemblies;
    /// <summary>Список загруженных компонентов</summary>
    protected readonly List<object> components;
    /// <summary>Список загруженных типов компонентов</summary>
    protected readonly List<Type> componentTypes;
    /// <summary>Карта интерфейс - тип компонента</summary>
    protected readonly Dictionary<Type, List<Type>> extensionPointTypesMap;
    protected readonly Dictionary<Type, List<Type>> extensionPointTypesMapShell;
    protected Dictionary<Type, List<Type>> extensionPointTypesMapToAdd;
    /// <summary>Контейнер IoC</summary>
    protected ContainerBuilder initBuilder;
    /// <summary>Пути сборок</summary>
    private string[] _assembliesPaths;
    private bool _assembliesLoaded;
    private static readonly List<Tuple<Type, string, Type>> attributeMethodInterceptors;
    private static readonly List<Tuple<Type, string, Type>> typeInterceptors;
    private static readonly List<Tuple<Type, string>> requiredInterceptors;
    private static readonly List<string> interceptorNames;
    private static ComponentManager _current;
    private static readonly IDictionary<string, Assembly> assembliesByName;
    private static readonly IDictionary<string, Assembly> assembliesByFullName;
    private static readonly IDictionary<Assembly, MemoryStream> assemblyRaws;
    private static readonly IDictionary<Assembly, string> assemblyShortNames;
    private static readonly IDictionary<Assembly, string> assemblyFullNames;
    private static readonly IDictionary<Assembly, string> assemblyLocations;
    private static readonly IDictionary<Assembly, byte[]> assemblyPublicKeys;
    private static readonly IDictionary<Assembly, bool> assemblyIsModelResults;
    private static (Type interfaceType, Type implementationType)[] actorTypes;
    private static (Type interfaceType, Type implementationType)[] hubTypes;
    private ContainerBuilder preInitBuilder;
    private readonly ComponentType componentType;
    private readonly IStartControl startControl;
    private IContainer currentContainer;
    private ComponentManager.LifetimeStage stage;
    private AssemblyInfoCache assemblyInfoCache;
    private readonly List<Tuple<Type, object>> shellComponents;
    private readonly List<Type> shellServices;
    private ApplicationStartCache applicationStartCache;
    private Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister;
    private IRuntimeApplication runtimeApplication;
    private string workDirectory;
    private EleWise.ELMA.Licensing.Impl.LicenseManager licenseManager;
    private IModuleManager moduleManager;
    private readonly PackageService packageService;
    private bool initializeTerminatedByLicense;
    private bool cacheEnabled;
    private readonly ConcurrentDictionary<Type, bool> cacheAvailability;
    private readonly ConcurrentDictionary<Type, object> cache;
    internal static ComponentManager QJMBdufvrLQnbvJUYYZb;

    /// <summary>Получить текущий менеджер</summary>
    public static ComponentManager Current
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ComponentManager._current == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        throw new NotInitializedException((string) ComponentManager.oB6VAWfvjUcykXtDN2xn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727022076)));
label_3:
        return ComponentManager._current;
      }
    }

    /// <summary>Загрузить сборку</summary>
    /// <param name="assemblyRaw">Raw сборки</param>
    /// <returns>Загруженная сборка</returns>
    public static Assembly LoadAssembly(byte[] assemblyRaw) => (Assembly) ComponentManager.ajNSXxfvLetrW0lfpyqb(ComponentManager.rmS4nRfvYnQowt8RKw6Y((object) assemblyRaw, false), (object) null);

    /// <summary>Загрузить сборку</summary>
    /// <param name="assemblyPath">Путь до сборки</param>
    /// <returns>Загруженная сборка</returns>
    public static Assembly LoadAssembly(string assemblyPath)
    {
      int num1 = 1;
      FileStream fileStream1;
      MemoryStream memoryStream1;
      FileStream fileStream2;
      MemoryStream memoryStream2;
      string path;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ComponentManager.fCv9KKfvUqj26fb31diw((object) assemblyPath))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto label_25;
          case 2:
label_31:
            path = (string) ComponentManager.xFOOAUf8WGtTJQHqHNVa((object) assemblyPath, ComponentManager.wCv31Xf8BDT6klkASJPg(1051802738 - -1831968059 ^ -1411323563));
            num1 = 4;
            continue;
          case 3:
            if (ComponentManager.fCv9KKfvUqj26fb31diw((object) path))
            {
              num1 = 5;
              continue;
            }
            goto label_24;
          case 4:
            memoryStream2 = (MemoryStream) null;
            num1 = 3;
            continue;
          case 5:
            fileStream2 = new FileStream(path, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 5 : 7;
            continue;
          case 6:
            try
            {
              memoryStream1 = MemoryHelper.GetMemoryStream((int) ComponentManager.nqrMNBfvsYqLRb8dCEKG((object) fileStream1));
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_31;
                  case 2:
                    ComponentManager.SK5GEgfvc1bJ2EjpDtgL((object) fileStream1, (object) memoryStream1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  default:
                    ComponentManager.sLdQBBfvzH8cyZvmUkMb((object) memoryStream1, 0L, SeekOrigin.Begin);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                    continue;
                }
              }
            }
            finally
            {
              int num3;
              if (fileStream1 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              else
                goto label_9;
label_8:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_9:
              ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) fileStream1);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
              {
                num3 = 1;
                goto label_8;
              }
              else
                goto label_8;
            }
          case 7:
            goto label_12;
          case 8:
            goto label_24;
          default:
            fileStream1 = new FileStream(assemblyPath, FileMode.Open, FileAccess.Read);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 1;
            continue;
        }
      }
label_12:
      try
      {
        memoryStream2 = (MemoryStream) ComponentManager.FoVNpRf8oMBqyZSXryE6((int) ComponentManager.nqrMNBfvsYqLRb8dCEKG((object) fileStream2));
        int num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num4 = 2;
        while (true)
        {
          switch (num4)
          {
            case 1:
              ComponentManager.sLdQBBfvzH8cyZvmUkMb((object) memoryStream2, 0L, SeekOrigin.Begin);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            case 2:
              ComponentManager.SK5GEgfvc1bJ2EjpDtgL((object) fileStream2, (object) memoryStream2);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              continue;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        int num5;
        if (fileStream2 == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
        else
          goto label_20;
label_19:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_20:
        ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) fileStream2);
        num5 = 2;
        goto label_19;
      }
label_24:
      return (Assembly) ComponentManager.ajNSXxfvLetrW0lfpyqb((object) memoryStream1, (object) memoryStream2);
label_25:
      return (Assembly) null;
    }

    /// <summary>Загрузить сборку с блокировкой по имени</summary>
    /// <remarks>
    /// Блокировка будет вызвана исключительно, если имя сборки является полным именем
    /// </remarks>
    /// &gt;
    ///             <param name="lockService">Сервис блокировки</param>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="isFullName"><c>True</c>, если передно полное имя сборки</param>
    /// <param name="assemblyRaw">Raw сборки</param>
    /// <param name="debugRaw">Raw отладочной информации</param>
    /// <returns>Загруженная сборка</returns>
    internal static Assembly LoadAssemblyWithLock(
      ILockService lockService,
      string assemblyName,
      bool isFullName,
      byte[] assemblyRaw,
      byte[] debugRaw)
    {
      int num1 = 5;
      Assembly assembly1;
      ILock @lock;
      while (true)
      {
        switch (num1)
        {
          case 1:
            @lock = lockService.AcquireLock(assemblyName);
            num1 = 2;
            continue;
          case 2:
            goto label_11;
          case 3:
            if (isFullName)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          case 4:
            if (!(assembly1 != (Assembly) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 2;
              continue;
            }
            goto label_4;
          case 5:
            assembly1 = (Assembly) ComponentManager.dGstXOf8bmTXQR0gWfP3((object) assemblyName, isFullName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 4;
            continue;
          case 6:
            goto label_10;
          case 7:
            goto label_7;
          default:
            goto label_4;
        }
      }
label_4:
      return assembly1;
label_7:
      return (Assembly) ComponentManager.PMS0jff8hmwqAq23WOsK((object) assemblyRaw, (object) debugRaw);
label_10:
      Assembly assembly2;
      return assembly2;
label_11:
      try
      {
        Assembly assembly3 = (Assembly) ComponentManager.dGstXOf8bmTXQR0gWfP3((object) assemblyName, true);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num2 = 1;
        while (true)
        {
          Assembly assembly4;
          switch (num2)
          {
            case 1:
              if (!ComponentManager.RFH3yXf8G144TwqweIOi((object) assembly3, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
                continue;
              }
              assembly4 = assembly3;
              break;
            case 2:
              assembly4 = ComponentManager.LoadAssembly(assemblyRaw, debugRaw);
              break;
            default:
              goto label_10;
          }
          assembly2 = assembly4;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
        }
      }
      finally
      {
        int num3;
        if (@lock == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
        else
          goto label_22;
label_21:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_22:
        @lock.Dispose();
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        {
          num3 = 0;
          goto label_21;
        }
        else
          goto label_21;
      }
    }

    /// <summary>Загрузить сборку</summary>
    /// <param name="assemblyRaw">Raw сборки</param>
    /// <param name="debugRaw">Raw отладочной информации</param>
    /// <returns>Загруженная сборка</returns>
    public static Assembly LoadAssembly(byte[] assemblyRaw, byte[] debugRaw)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (assemblyRaw == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      object assemblyRaw1 = (object) null;
      goto label_6;
label_5:
      assemblyRaw1 = ComponentManager.rmS4nRfvYnQowt8RKw6Y((object) assemblyRaw, false);
label_6:
      MemoryStream memoryStream = debugRaw != null ? MemoryHelper.GetMemoryStream(debugRaw, false) : (MemoryStream) null;
      return ComponentManager.LoadAssembly((MemoryStream) assemblyRaw1, memoryStream);
    }

    /// <summary>
    /// Загрузить сборку с проверкой совместимости delta-публикации
    /// </summary>
    /// <param name="assemblyRaw">Поток, содержащий Raw сборки</param>
    /// <param name="debugRaw">Поток, содержащий Raw отладочной информации</param>
    /// <returns></returns>
    public static Assembly LoadAssembly(MemoryStream assemblyRaw, MemoryStream debugRaw)
    {
      int num1 = 3;
      Assembly key;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              ComponentManager.assemblyRaws[key] = (MemoryStream) ComponentManager.kaxDhff8CmFtTDwlJshq((object) assemblyRaw);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 5 : 0;
              continue;
            case 2:
              if (debugRaw != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                continue;
              }
              obj = (object) Assembly.Load((byte[]) ComponentManager.jWxwSbf8fSObbiwFJuE8(ComponentManager.OLJy54f8ET3bhgMLXCAm((object) assemblyRaw)));
              break;
            case 3:
              goto label_6;
            case 4:
              goto label_5;
            case 5:
              ComponentManager.assembliesByFullName[(string) ComponentManager.x64lvJf8v6CF4oxdDeL5((object) key)] = key;
              num2 = 6;
              continue;
            case 6:
              ComponentManager.assembliesByName[(string) ComponentManager.n9g3yIf88CaM0X95aYoX((object) key)] = key;
              num2 = 4;
              continue;
            case 7:
              goto label_10;
            default:
              obj = ComponentManager.RkCv57f8QQLg0Cwd5X11(ComponentManager.jWxwSbf8fSObbiwFJuE8(ComponentManager.OLJy54f8ET3bhgMLXCAm((object) assemblyRaw)), ComponentManager.jWxwSbf8fSObbiwFJuE8((object) debugRaw));
              break;
          }
          key = (Assembly) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
        }
label_6:
        if (assemblyRaw != null)
          num1 = 2;
        else
          goto label_10;
      }
label_5:
      return key;
label_10:
      return (Assembly) null;
    }

    /// <summary>Обновить Raw сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <param name="assemblyRaw">Raw</param>
    internal static void UpdateAssemblyRaw(Assembly assembly, MemoryStream assemblyRaw)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentManager.assemblyRaws[assembly] = assemblyRaw.AsReadOnly();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Загрузить Raw загруженной сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns>Raw</returns>
    public static byte[] GetLoadedAssemblyRaw(Assembly assembly)
    {
      int num = 1;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            obj = ComponentManager.nPjKSNf8ZLZ15ThUoVfp((object) assembly);
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (byte[]) null;
label_5:
      return (byte[]) ComponentManager.jWxwSbf8fSObbiwFJuE8(obj);
    }

    /// <summary>Загрузить Raw загруженной сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns>Поток, содержащий Raw загруженной сборки</returns>
    public static MemoryStream GetLoadedAssemblyRawAsStream(Assembly assembly)
    {
      int num = 1;
      MemoryStream assemblyRawAsStream;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ComponentManager.MLUjBmf8uveewmtmyNK1((object) assembly, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            ComponentManager.assemblyRaws.TryGetValue(assembly, out assemblyRawAsStream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 0;
            continue;
          case 2:
            goto label_6;
          default:
            goto label_4;
        }
      }
label_4:
      return (MemoryStream) null;
label_6:
      return assemblyRawAsStream;
    }

    /// <summary>
    /// Получить список загруженных сборок (исключая отключенные или недоступные)
    /// </summary>
    /// <returns></returns>
    public static Assembly[] GetAssemblies() => (Assembly[]) ComponentManager.v5Q9sxf8V01q5Iw9Niyo(ComponentManager.T4L9EQf8IXdhwhUHsXDu());

    /// <summary>
    /// Получить список загруженных сборок (исключая отключенные или недоступные)
    /// </summary>
    /// <param name="domain"></param>
    /// <returns></returns>
    public static Assembly[] GetAssemblies(AppDomain domain)
    {
      int num = 4;
      while (true)
      {
        AppDomain appDomain1;
        switch (num)
        {
          case 1:
            if (ComponentManager._current.moduleManager != null)
            {
              num = 5;
              continue;
            }
            goto label_10;
          case 2:
            if (ComponentManager._current != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
              continue;
            }
            goto label_10;
          case 3:
            appDomain1 = AppDomain.CurrentDomain;
            break;
          case 4:
            AppDomain appDomain2 = domain;
            if (appDomain2 == null)
            {
              num = 3;
              continue;
            }
            appDomain1 = appDomain2;
            break;
          case 5:
            goto label_11;
          default:
            goto label_10;
        }
        domain = appDomain1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 2;
      }
label_10:
      return (Assembly[]) ComponentManager.zdh7Gvf8SStPvj8tRfiU((object) domain);
label_11:
      Assembly[] assemblies = domain.GetAssemblies();
      // ISSUE: reference to a compiler-generated field
      Func<Assembly, bool> func = ComponentManager.\u003C\u003Ec.\u003C\u003E9__13_0;
      Func<Assembly, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ComponentManager.\u003C\u003Ec.\u003C\u003E9__13_0 = predicate = (Func<Assembly, bool>) (a => ComponentManager._current.moduleManager.IsAssemblyAvailable(a));
      }
      else
        goto label_15;
label_13:
      return ((IEnumerable<Assembly>) assemblies).Where<Assembly>(predicate).ToArray<Assembly>();
label_15:
      predicate = func;
      goto label_13;
    }

    /// <summary>Проверить, содержит ли сборка модели</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns></returns>
    public static bool IsModelAssembly(Assembly assembly)
    {
      int num = 2;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!ComponentManager.MLUjBmf8uveewmtmyNK1((object) assembly, (object) null))
            {
              if (ComponentManager.assemblyIsModelResults.TryGetValue(assembly, out flag))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 5;
                continue;
              }
              goto case 4;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
              continue;
            }
          case 3:
          case 5:
            goto label_7;
          case 4:
            // ISSUE: type reference
            flag = ComponentManager.QW7fFif8RUT9OOfShLAn((object) assembly, ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (ModelAssemblyAttribute)), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            ComponentManager.assemblyIsModelResults[assembly] = flag;
            num = 3;
            continue;
        }
      }
label_3:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1217523399 ^ -1217502121));
label_7:
      return flag;
    }

    /// <summary>Инициализирован или нет</summary>
    public static bool Initialized => ComponentManager._current != null;

    /// <summary>
    /// Текущий контейнер IoC (доступен только в процессе начала инициализации - в методе IInitHandler.Init)
    /// </summary>
    public static ContainerBuilder Builder
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ComponentManager.UHpgitf8qjb4qfO8dayD() == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (ContainerBuilder) null;
label_5:
        return ((ComponentManager) ComponentManager.UHpgitf8qjb4qfO8dayD()).initBuilder;
      }
    }

    /// <summary>Типы акторов (интерфейс и реализация)</summary>
    public static IEnumerable<(Type interfaceType, Type implementationType)> ActorTypes
    {
      get
      {
        if (ComponentManager.actorTypes == null)
        {
          string[] additionalAssemblyWithActors = new string[9]
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87133725),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978141424),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272289619),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542652755),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088098932),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312532037),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538524150),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881920090),
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -542050959)
          };
          ComponentManager.actorTypes = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).Where<Assembly>(new Func<Assembly, bool>(ShouldGenerateCodeForAssembly)).SelectMany<Assembly, Type>((Func<Assembly, IEnumerable<Type>>) (a =>
          {
            try
            {
              return (IEnumerable<Type>) a.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
              string str = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218549832), ((IEnumerable<Exception>) ex.LoaderExceptions).Select<Exception, string>((Func<Exception, string>) (e => e.ToString())).ToArray<string>());
              Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418239966) + a.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138169018) + str), (Exception) ex);
              throw;
            }
          })).Where<Type>((Func<Type, bool>) (t =>
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_3;
                case 2:
                  if (!ComponentManager.\u003C\u003Ec.p0to0q8r4vDsnxUQjfRL(__typeref (Actor)).IsAssignableFrom(t))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
                    continue;
                  }
                  goto label_2;
                default:
                  goto label_2;
              }
            }
label_2:
            return !t.IsAbstract;
label_3:
            return false;
          })).Select<Type, (Type, Type)>((Func<Type, (Type, Type)>) (t => (((IEnumerable<Type>) t.GetInterfaces()).Where<Type>(new Func<Type, bool>(ActorInterfaceUtils.IsActorInterface)).FirstOrDefault<Type>(), t))).Where<(Type, Type)>((Func<(Type, Type), bool>) (p => p.interfaceType != (Type) null)).ToArray<(Type, Type)>();
          if (Locator.Initialized)
          {
            ContainerBuilder builder = new ContainerBuilder();
            foreach ((Type interfaceType, Type implementationType) actorType in ComponentManager.actorTypes)
              builder.RegisterType(actorType.implementationType).AsSelf<object, ConcreteReflectionActivatorData>().As(actorType.interfaceType).PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
            builder.Update(Locator.GetServiceNotNull<IContainer>());
          }

          bool ShouldGenerateCodeForAssembly(Assembly assembly)
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (!ComponentManager.\u003C\u003Ec__DisplayClass20_0.mxdRbS8rrO4tAdxlVwEe((object) assembly))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_7;
                case 2:
                  goto label_6;
                default:
                  if (assembly.GetCustomAttribute<GeneratedCodeAttribute>() == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 2;
                    continue;
                  }
                  goto label_7;
              }
            }
label_6:
            return ((IEnumerable<string>) additionalAssemblyWithActors).Contains<string>(((AssemblyName) ComponentManager.\u003C\u003Ec__DisplayClass20_0.POVukQ8rgQH2jTn5jkk4((object) assembly)).Name);
label_7:
            return false;
          }
        }
        return (IEnumerable<(Type, Type)>) ComponentManager.actorTypes;
      }
    }

    /// <summary>Типы хабов (интерфейс и реализация)</summary>
    internal static IEnumerable<(Type interfaceType, Type implementationType)> HubTypes
    {
      get
      {
        if (ComponentManager.hubTypes == null)
        {
          ComponentManager.hubTypes = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).Where<Assembly>(new Func<Assembly, bool>(ShouldGenerateCodeForAssembly)).SelectMany<Assembly, Type>((Func<Assembly, IEnumerable<Type>>) (assembly =>
          {
            try
            {
              return (IEnumerable<Type>) assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
              string str = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516776732), ((IEnumerable<Exception>) ex.LoaderExceptions).Select<Exception, string>((Func<Exception, string>) (e => e.ToString())).ToArray<string>());
              Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479700192) + assembly.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217498617) + str), (Exception) ex);
              throw;
            }
          })).Where<Type>((Func<Type, bool>) (type =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (!type.IsAbstract)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                default:
                  goto label_2;
              }
            }
label_2:
            return ComponentManager.\u003C\u003Ec.Ljqoco8rHEY45IxNiSyn(type, typeof (HubBase<>));
label_3:
            return false;
          })).Select<Type, (Type, Type)>((Func<Type, (Type, Type)>) (type => (((IEnumerable<Type>) type.GetInterfaces()).Where<Type>(new Func<Type, bool>(HubInterfaceUtils.IsHubInterface)).FirstOrDefault<Type>(), type))).Where<(Type, Type)>((Func<(Type, Type), bool>) (information => information.interfaceType != (Type) null)).ToArray<(Type, Type)>();
          if (Locator.Initialized)
          {
            ContainerBuilder builder = new ContainerBuilder();
            foreach ((Type interfaceType, Type implementationType) hubType in ComponentManager.hubTypes)
              builder.RegisterType(hubType.implementationType).AsSelf<object, ConcreteReflectionActivatorData>().As(hubType.implementationType.GetInterfaces()).PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
            builder.Update(Locator.GetServiceNotNull<IContainer>());
          }
        }
        return (IEnumerable<(Type, Type)>) ComponentManager.hubTypes;

        bool ShouldGenerateCodeForAssembly(Assembly assembly)
        {
          int num1 = 4;
          while (true)
          {
            int num2 = num1;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  if (!ComponentManager.\u003C\u003Ec.OXsyoJ8r6369VvmJ2EfQ((object) assembly, ComponentManager.\u003C\u003Ec.p0to0q8r4vDsnxUQjfRL(__typeref (ComponentAssemblyAttribute)), false))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                case 2:
                  goto label_3;
                case 4:
                  if (!assembly.IsDynamic)
                    goto case 1;
                  else
                    goto label_8;
                default:
                  goto label_4;
              }
            }
label_8:
            num1 = 3;
          }
label_3:
          return assembly.GetCustomAttribute<GeneratedCodeAttribute>() == null;
label_4:
          return false;
        }
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="componentType">Типы компонентов, которые регистрируются данным менеджером компонентов.</param>
    /// <param name="containerBuilder">Контейнер IoC. Может быть null.</param>
    public ComponentManager(ComponentType componentType, ContainerBuilder containerBuilder = null)
    {
      ComponentManager.q9Em1cf8KGVrygmCgNB8();
      // ISSUE: explicit constructor call
      this.\u002Ector(componentType, (IStartControl) null, containerBuilder);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="componentType">Типы компонентов, которые регистрируются данным менеджером компонентов.</param>
    /// <param name="startControl">Компонент управления запуском сервера.</param>
    /// <param name="containerBuilder">Контейнер IoC. Может быть null.</param>
    public ComponentManager(
      ComponentType componentType,
      IStartControl startControl,
      ContainerBuilder containerBuilder = null)
    {
      ComponentManager.q9Em1cf8KGVrygmCgNB8();
      this.registrationData = new ComponentManager.RegistrationData();
      this.componentAssemblies = new List<Assembly>();
      this.processedAssemblies = new List<Assembly>();
      this.components = new List<object>();
      this.componentTypes = new List<Type>();
      this.extensionPointTypesMap = new Dictionary<Type, List<Type>>();
      this.extensionPointTypesMapShell = new Dictionary<Type, List<Type>>();
      this.shellComponents = new List<Tuple<Type, object>>();
      this.shellServices = new List<Type>();
      this.cacheAvailability = new ConcurrentDictionary<Type, bool>();
      this.cache = new ConcurrentDictionary<Type, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            ComponentManager.zNG16vf8TI2LJqYeDHPf(ComponentManager.T4L9EQf8IXdhwhUHsXDu(), (object) new ResolveEventHandler(ComponentManager.CurrentDomainReflectionOnlyAssemblyResolve));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
            continue;
          case 3:
            this.packageService = new PackageService();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 5;
            continue;
          case 4:
            ContainerBuilder containerBuilder1 = containerBuilder;
            this.preInitBuilder = containerBuilder1 == null ? new ContainerBuilder() : containerBuilder1;
            num = 7;
            continue;
          case 5:
            ComponentManager.MDhNfRf8XTOyqDV7LOcj(ComponentManager.T4L9EQf8IXdhwhUHsXDu(), (object) new ResolveEventHandler(ComponentManager.CurrentDomainAssemblyResolve));
            num = 2;
            continue;
          case 6:
            this.componentType = componentType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 7:
            this.extensionPointTypesMapToAdd = this.extensionPointTypesMap;
            num = 3;
            continue;
          default:
            this.startControl = startControl ?? (IStartControl) new DoNothingStartControl();
            num = 4;
            continue;
        }
      }
label_9:;
    }

    /// <summary>Этап жизненного цикла</summary>
    public ComponentManager.LifetimeStage Stage => this.stage;

    /// <summary>Рабочая папка</summary>
    public string WorkDirectory => this.workDirectory;

    /// <summary>Менеджер лицензирования системы</summary>
    public ILicenseManager LicenseManager => (ILicenseManager) this.licenseManager;

    /// <summary>Менеджер работы с модулями системы</summary>
    public IModuleManager ModuleManager => this.moduleManager;

    /// <summary>Менеджер работы с пакетной системой системы</summary>
    public PackageService PackageService => this.packageService;

    /// <summary>
    /// Типы компонентов, которые регистрируются данные менеджером компонентов
    /// </summary>
    public ComponentType ComponentType => this.componentType;

    /// <summary>Дополнительные хранилища ключей активации</summary>
    public IEnumerable<IActivationKeyStorage> ActivationKeyStorages { get; set; }

    /// <summary>
    /// Получить регистрируемые компоненты. Метод может вызываться до момента инициализации менеджера компонентов.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IEnumerable<T> GetComponentsForRegister<T>()
    {
      if (this.stage != ComponentManager.LifetimeStage.BeforeInit)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867388763), (object) this.stage));
      return (IEnumerable<T>) this.registrationData.ComponentsToRegister.OfType<T>().ToList<T>();
    }

    /// <summary>Инициализация лицензирования.</summary>
    /// <param name="assembliesPaths">Список путей, где нужно искать компонентные сборки</param>
    /// <param name="workingDirectory">Рабочая папка (где приложение может создавать какие-то временные файлы для работы)</param>
    public void InitLicensing(string[] assembliesPaths, [NotNull] string workingDirectory)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.InitLicensing(assembliesPaths, workingDirectory, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Инициализация лицензирования.</summary>
    /// <param name="assembliesPaths">Список путей, где нужно искать компонентные сборки</param>
    /// <param name="workingDirectory">Рабочая папка (где приложение может создавать какие-то временные файлы для работы)</param>
    /// <param name="onlyLoadedAssemblies">Обрабатывать только загруженные сборки</param>
    public void InitLicensing(
      string[] assembliesPaths,
      [NotNull] string workingDirectory,
      bool onlyLoadedAssemblies)
    {
      int num1 = 4;
      IStartInformation startInformation;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              ComponentManager._current = this;
              num2 = 7;
              continue;
            case 3:
              ComponentManager.Tv4ncrf8kNlRhOhmeKEG((object) workingDirectory, ComponentManager.wCv31Xf8BDT6klkASJPg(-1852837372 ^ -1853171180));
              num2 = 9;
              continue;
            case 4:
              ComponentManager.Tv4ncrf8kNlRhOhmeKEG((object) assembliesPaths, ComponentManager.wCv31Xf8BDT6klkASJPg(87862435 ^ 87657293));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 1;
              continue;
            case 5:
              goto label_33;
            case 6:
              goto label_3;
            case 7:
              startInformation = (IStartInformation) ComponentManager.OB3ZKXf82AiHB1c8go0f(7.0, ComponentManager.zCdDexf8Ov8Ow1CLnVht((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137649390)));
              num2 = 6;
              continue;
            case 8:
              if (Directory.Exists(workingDirectory))
              {
                num2 = 2;
                continue;
              }
              goto case 10;
            case 9:
              if (this.stage == ComponentManager.LifetimeStage.BeforeInit)
              {
                num2 = 12;
                continue;
              }
              goto label_26;
            case 10:
              Directory.CreateDirectory(workingDirectory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
            case 11:
              goto label_26;
            case 12:
              this._assembliesPaths = (string[]) ComponentManager.pg5KxNf8n9c69kdxEpZb((object) assembliesPaths);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_24;
          }
        }
label_24:
        this.workDirectory = workingDirectory;
        num1 = 8;
      }
label_33:
      return;
label_3:
      try
      {
        int num3;
        if (this.licenseManager != null)
          num3 = 12;
        else
          goto label_15;
label_6:
        while (true)
        {
          int num4;
          RemoteServiceProvider remoteServiceProvider;
          IRuntimeApplication runtimeApplication;
          switch (num3)
          {
            case 1:
              runtimeApplication = this.registrationData.ComponentsToRegister.OfType<IRuntimeApplication>().FirstOrDefault<IRuntimeApplication>();
              num3 = 4;
              continue;
            case 2:
            case 12:
              this.CheckLicensing();
              num3 = 10;
              continue;
            case 3:
              remoteServiceProvider = this.registrationData.ComponentsToRegister.OfType<RemoteServiceProvider>().FirstOrDefault<RemoteServiceProvider>();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
              continue;
            case 4:
              if (ComponentManager.GLLOL4f8PFRD0nvCwcOm(ComponentManager.Ywh3E7f8esDbbESNlstN((object) this.packageService)))
              {
                num4 = 5;
                break;
              }
              goto case 7;
            case 5:
            case 9:
              this.moduleManager = (IModuleManager) new EleWise.ELMA.Modules.Impl.ModuleManager((IEnumerable<Assembly>) this.registrationData.Assemblies, this.packageService, remoteServiceProvider, runtimeApplication);
              num3 = 8;
              continue;
            case 6:
              goto label_15;
            case 7:
              ComponentManager.HBYsiLf81Ud8SNSZpPdy((object) this.packageService);
              num3 = 9;
              continue;
            case 8:
              ComponentManager.zaKxIrf8NQ2IJrNHDgOr((object) this.licenseManager);
              num4 = 2;
              break;
            case 10:
              goto label_22;
            case 11:
              this.licenseManager = new EleWise.ELMA.Licensing.Impl.LicenseManager(this.ActivationKeyStorages);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
              continue;
            default:
              startInformation.Message = (string) ComponentManager.zCdDexf8Ov8Ow1CLnVht(ComponentManager.wCv31Xf8BDT6klkASJPg(272623989 ^ 272286091));
              num3 = 3;
              continue;
          }
          num3 = num4;
        }
label_22:
        return;
label_15:
        this.LoadAssemblies(onlyLoadedAssemblies);
        num3 = 11;
        goto label_6;
      }
      finally
      {
        int num5;
        if (startInformation == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
        else
          goto label_21;
label_20:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_21:
        ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) startInformation);
        num5 = 2;
        goto label_20;
      }
label_26:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-16752921 ^ -16419117), (object) this.stage));
    }

    /// <summary>Загрузить сборки.</summary>
    /// <param name="assembliesPaths">Список путей, где нужно искать компонентные сборки</param>
    public void LoadAssemblies(string[] assembliesPaths)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.LoadAssemblies(false);
            num = 4;
            continue;
          case 2:
            if (this.stage == ComponentManager.LifetimeStage.BeforeInit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            ComponentManager.Tv4ncrf8kNlRhOhmeKEG((object) assembliesPaths, ComponentManager.wCv31Xf8BDT6klkASJPg(813604817 ^ 813414463));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            goto label_7;
          default:
            this._assembliesPaths = ComponentManager.GetAssembliesPathsWithArchitecture((object) assembliesPaths);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return;
label_7:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583931468), (object) this.stage));
    }

    /// <summary>
    /// Инициализация менеджера. Метод доступен на этапе BeforeInit (начальный этап).
    /// </summary>
    /// <param name="assembliesPaths">Список путей, где нужно искать компонентные сборки</param>
    /// <param name="workingDirectory">Рабочая папка (где приложение может создавать какие-то временные файлы для работы)</param>
    public void Init(string[] assembliesPaths, [NotNull] string workingDirectory)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentManager.Tv4ncrf8kNlRhOhmeKEG((object) workingDirectory, ComponentManager.wCv31Xf8BDT6klkASJPg(825385222 ^ 825706774));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Init(assembliesPaths, workingDirectory, (Type[]) null, (Type[]) null, (Type[]) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Инициализация менеджера. Метод доступен на этапе BeforeInit (начальный этап).
    /// </summary>
    /// <param name="assembliesPaths">Список путей, где нужно искать компонентные сборки</param>
    /// <param name="workingDirectory">Рабочая папка (где приложение может создавать какие-то временные файлы для работы)</param>
    public void Init(
      string[] assembliesPaths,
      [NotNull] string workingDirectory,
      Type[] componentTypesToRegister,
      Type[] extensionPointsToRegister,
      Type[] servicesToRegister)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              this.registrationData.ExtensionPointsToRegister.AddRange((IEnumerable<Type>) extensionPointsToRegister);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 6;
              continue;
            case 3:
              this.registrationData.ComponentsTypesToRegister.AddRange((IEnumerable<Type>) componentTypesToRegister);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            case 4:
              ComponentManager.gU1fdof83wfgD06oHiei((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
              continue;
            case 5:
              goto label_16;
            case 6:
              if (servicesToRegister != null)
                goto case 8;
              else
                goto label_8;
            case 7:
            case 9:
              this.InitLicensing(assembliesPaths, workingDirectory);
              num2 = 4;
              continue;
            case 8:
              this.registrationData.ServiceTypesToRegister.AddRange((IEnumerable<Type>) servicesToRegister);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 9;
              continue;
            case 10:
              if (this.stage != ComponentManager.LifetimeStage.BeforeInit)
              {
                num2 = 5;
                continue;
              }
              if (componentTypesToRegister != null)
              {
                num2 = 3;
                continue;
              }
              goto default;
            case 11:
              ComponentManager.Tv4ncrf8kNlRhOhmeKEG((object) workingDirectory, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979569119));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 10 : 9;
              continue;
            default:
              if (extensionPointsToRegister != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
                continue;
              }
              goto case 6;
          }
        }
label_8:
        num1 = 7;
      }
label_11:
      return;
label_16:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ComponentManager.wCv31Xf8BDT6klkASJPg(236071375 ^ 236388389), (object) this.stage));
    }

    /// <summary>Возобновить инициализацию</summary>
    /// <remarks>Метод доступен после ошибки активации приложения</remarks>
    public void ResumeInit()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_9;
            case 2:
              this.Init();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 3:
              this.CheckLicensing();
              num2 = 2;
              continue;
            case 4:
              this.initializeTerminatedByLicense = false;
              num2 = 3;
              continue;
            case 5:
              goto label_7;
            default:
              goto label_3;
          }
        }
label_7:
        if (this.initializeTerminatedByLicense)
          num1 = 4;
        else
          goto label_9;
      }
label_4:
      return;
label_3:
      return;
label_9:
      throw new InvalidOperationException((string) ComponentManager.oB6VAWfvjUcykXtDN2xn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426412103)));
    }

    /// <summary>
    /// Получить список путей, в которых находятся компонентные сборки
    /// </summary>
    public string[] AssemblyPaths => this._assembliesPaths;

    /// <summary>
    /// Зарегистрировать существующий компонент. Метод доступен на этапах BeforeInit и Initializing.
    /// </summary>
    /// <param name="component">Компонент</param>
    public ComponentManager RegisterComponent(object component)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.stage == ComponentManager.LifetimeStage.BeforeInit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            goto label_7;
          case 3:
            goto label_2;
          case 4:
            if (this.stage != ComponentManager.LifetimeStage.Initializing)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
              continue;
            }
            break;
        }
        this.registrationData.ComponentsToRegister.Add(component);
        num = 3;
      }
label_2:
      return this;
label_7:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-710283084 ^ -537863435 ^ 173801747), (object) this.stage));
    }

    /// <summary>
    /// Пропустить тип компонента при инициализации. Метод доступен на этапах BeforeInit и Initializing.
    /// </summary>
    /// <param name="ignoreComponentType">Тип компонента</param>
    public ComponentManager IgnoreComponentType(Type ignoreComponentType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.stage == ComponentManager.LifetimeStage.BeforeInit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (this.stage != ComponentManager.LifetimeStage.Initializing)
            {
              num = 3;
              continue;
            }
            break;
          case 3:
            goto label_5;
          case 4:
            goto label_2;
        }
        this.registrationData.ComponentsTypesToIgnore.Add(ignoreComponentType);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 4 : 4;
      }
label_2:
      return this;
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-606654180 ^ -606986946), (object) this.stage));
    }

    /// <summary>
    /// Зарегистрировать сборку, в которой будет искаться компоненты. Метод доступен на этапах BeforeInit и Initializing.
    /// </summary>
    /// <param name="assembly">Сборка</param>
    public ComponentManager RegisterAssembly(Assembly assembly)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            this.ProcessAssembly(assembly, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 4:
            if (this.stage != ComponentManager.LifetimeStage.BeforeInit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 3 : 3;
              continue;
            }
            goto case 7;
          case 5:
            if (this.stage == ComponentManager.LifetimeStage.BeforeInit)
            {
              num = 4;
              continue;
            }
            goto case 8;
          case 7:
            this.AddAssembly(assembly);
            num = 6;
            continue;
          case 8:
            if (this.stage != ComponentManager.LifetimeStage.Initializing)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 2;
              continue;
            }
            goto case 4;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
label_6:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ComponentManager.wCv31Xf8BDT6klkASJPg(1021410165 ^ 1021597571), (object) this.stage));
    }

    /// <summary>
    /// Обновить контейнер Autofac. Метод доступен на этапе Initializing.
    /// </summary>
    public void UpdateContainer()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.stage == ComponentManager.LifetimeStage.Initializing)
            {
              ComponentManager.r87KH2f8pPCgu5NM7KpL((object) this.initBuilder, (object) this.currentContainer);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.initBuilder = new ContainerBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            this.preInitBuilder = this.initBuilder;
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653977245), (object) this.stage));
    }

    /// <summary>
    /// Возвращает компонент определенного типа. Метод доступен на этапах Initializing, InitCompleting и Initialized.
    /// </summary>
    /// <typeparam name="T">Тип расширения</typeparam>
    /// <returns>Экземпляр расширения</returns>
    public T GetExtensionPointByType<T>() => !(this.GetExtensionPointByType(typeof (T)) is T extensionPointByType) ? default (T) : extensionPointByType;

    /// <summary>
    /// Возвращает компонент, определенного типа. Метод доступен на этапах Initializing, InitCompleting и Initialized.
    /// </summary>
    /// <param name="type">Тип расширения</param>
    /// <returns>Экземпляр расширения</returns>
    public object GetExtensionPointByType(Type type)
    {
      int num = 1;
      object instance;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.stage != ComponentManager.LifetimeStage.Initializing)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            break;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          case 4:
            if (this.stage != ComponentManager.LifetimeStage.Initialized)
            {
              num = 3;
              continue;
            }
            break;
          default:
            if (this.stage != ComponentManager.LifetimeStage.InitCompleting)
            {
              num = 4;
              continue;
            }
            break;
        }
        this.CurrentScope().TryResolve(type, out instance);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 1;
      }
label_2:
      return instance;
label_3:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281656628), (object) this.stage));
    }

    /// <summary>
    /// Возвращает компоненты, реализующие интерфейс-расширение. Метод доступен на этапах Initializing, InitCompleting и Initialized.
    /// </summary>
    /// <typeparam name="T">Тип интерфейса расширения</typeparam>
    /// <returns></returns>
    public IEnumerable<T> GetExtensionPoints<T>() => this.GetExtensionPointsInternal<T>();

    /// <summary>
    /// Возвращает компоненты, реализующие интерфейс-расширение. Метод доступен на этапах Initializing, InitCompleting и Initialized.
    /// </summary>
    /// <typeparam name="T">Тип интерфейса расширения</typeparam>
    /// <param name="useCache">Кэшировать ли результаты</param>
    /// <returns></returns>
    public IEnumerable<T> GetExtensionPoints<T>(bool useCache) => useCache ? this.GetExtensionPointsInternal<T>() : this.GetExtensionPointsNonCached<T>();

    /// <summary>
    /// Возвращает типы компонентов, реализующих интерфейс-расширение.
    /// </summary>
    /// <param name="type">Тип интерфейса расширения</param>
    /// <returns>Список типов компонентов. Если не найдены - возвращается пустой список.</returns>
    public IEnumerable<Type> GetExtensionPointTypes(Type type)
    {
      List<Type> typeList;
      return !this.extensionPointTypesMap.TryGetValue(type, out typeList) && !this.extensionPointTypesMapShell.TryGetValue(type, out typeList) ? (IEnumerable<Type>) EleWise.ELMA.Helpers.EmptyArray<Type>.Instance : (IEnumerable<Type>) typeList;
    }

    /// <summary>
    /// Возвращает типы компонентов, реализующих интерфейс-расширение.
    /// </summary>
    /// <typeparam name="T">Тип интерфейса расширения</typeparam>
    /// <returns>Список компонентов</returns>
    public IEnumerable<Type> GetExtensionPointTypes<T>() => this.GetExtensionPointTypes(typeof (T));

    /// <summary>
    /// Возвращает типы компонентов, реализующих интерфейс-расширение.
    /// </summary>
    /// <param name="type">Тип интерфейса расширения</param>
    /// <returns>Список типов компонентов. Если не найдены - возвращается пустой список.</returns>
    public Type[] GetExtensionPointTypesArray(Type type) => this.GetExtensionPointTypes(type).ToArray<Type>();

    /// <summary>Получить типы, реализующие интерфейс IXsiType.</summary>
    /// <returns></returns>
    public Type[] GetXsiTypes() => this.GetExtensionPointTypesArray(typeof (IXsiType));

    /// <summary>Получить типы, реализующие интерфейс IXsiRoot.</summary>
    /// <returns></returns>
    public Type[] GetXsiRoots() => this.GetExtensionPointTypesArray(ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (IXsiRoot)));

    /// <summary>Запустить кэш точек расширения</summary>
    public void StartCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.cacheEnabled = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Сбросить кэш точек расширения</summary>
    public void ResetCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentManager.gy6LMvf8aAA8sK6LetIh((object) this.cache);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Выгрузка менеджера</summary>
    public void Dispose()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.disposed = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 6 : 4;
            continue;
          case 2:
            if (!this.disposed)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 3:
            goto label_5;
          case 4:
            GC.SuppressFinalize((object) this);
            num = 5;
            continue;
          case 5:
            goto label_6;
          case 6:
            ComponentManager.O8pAoYf8D1FNnpmN6Lde(ComponentManager.T4L9EQf8IXdhwhUHsXDu(), (object) new ResolveEventHandler(ComponentManager.CurrentDomainAssemblyResolve));
            num = 7;
            continue;
          case 7:
            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= new ResolveEventHandler(ComponentManager.CurrentDomainReflectionOnlyAssemblyResolve);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          default:
            ComponentManager.cUPMLcf8t8o2OHJEXnGT((object) this, true);
            num = 4;
            continue;
        }
      }
label_5:
      return;
label_6:
      return;
label_2:;
    }

    protected static ILogger log => Logger.Log;

    /// <summary>Инициализация</summary>
    protected virtual void Init()
    {
      int num1 = 2;
      IStartInformation startInformation1;
      while (true)
      {
        int num2 = num1;
        IStartInformation startInformation2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
                ComponentManager.QuZb1gf8wZgJPPqATKGy((object) startInformation2, ComponentManager.zCdDexf8Ov8Ow1CLnVht(ComponentManager.wCv31Xf8BDT6klkASJPg(-1839087379 - 334718690 ^ 2120971641)));
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                  num3 = 0;
                List<string>.Enumerator enumerator;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this.runtimeApplication = this.registrationData.ComponentsToRegister.OfType<IRuntimeApplication>().FirstOrDefault<IRuntimeApplication>();
                      num3 = 3;
                      continue;
                    case 2:
                      ComponentManager.vHp45Ff8AxB2Ll7CoFDt((object) this);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                      continue;
                    case 3:
                      if (this.runtimeApplication == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 9;
                        continue;
                      }
                      goto case 11;
                    case 4:
                      ComponentManager.obs47Ef8HCmXygAAEXBM((object) this);
                      num3 = 2;
                      continue;
                    case 5:
                    case 9:
label_40:
                      ComponentManager.QuZb1gf8wZgJPPqATKGy((object) startInformation2, (object) EleWise.ELMA.SR.M((string) ComponentManager.wCv31Xf8BDT6klkASJPg(813604817 ^ 813412455)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 4 : 4;
                      continue;
                    case 6:
                      this.applicationStartCache = (ApplicationStartCache) ComponentManager.iCXEMjf86FkZ4CMmCrMa((object) this.runtimeApplication);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 6 : 10;
                      continue;
                    case 7:
                      try
                      {
label_30:
                        if (enumerator.MoveNext())
                          goto label_28;
                        else
                          goto label_31;
label_25:
                        string current;
                        int num4;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              goto label_40;
                            case 2:
                              goto label_30;
                            case 3:
                              goto label_28;
                            case 4:
                              this.applicationStartCache.InterceptorNames.Add(current);
                              num4 = 2;
                              continue;
                            default:
                              if (!this.applicationStartCache.InterceptorNames.Contains(current))
                              {
                                num4 = 4;
                                continue;
                              }
                              goto label_30;
                          }
                        }
label_28:
                        current = enumerator.Current;
                        num4 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                        {
                          num4 = 0;
                          goto label_25;
                        }
                        else
                          goto label_25;
label_31:
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
                        goto label_25;
                      }
                      finally
                      {
                        enumerator.Dispose();
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                        }
                      }
                    case 8:
                      enumerator = ComponentManager.interceptorNames.GetEnumerator();
                      num3 = 7;
                      continue;
                    case 10:
                      if (this.applicationStartCache != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 5 : 8;
                        continue;
                      }
                      goto case 5;
                    case 11:
                      ComponentManager.xbaUumf84xps0wdtJv35((object) this.runtimeApplication);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 4 : 6;
                      continue;
                    default:
                      goto label_74;
                  }
                }
              }
              finally
              {
                if (startInformation2 != null)
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) startInformation2);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_49;
                    }
                  }
                }
label_49:;
              }
            case 2:
              startInformation2 = (IStartInformation) ComponentManager.OB3ZKXf82AiHB1c8go0f(7.0, ComponentManager.zCdDexf8Ov8Ow1CLnVht(ComponentManager.wCv31Xf8BDT6klkASJPg(381945751 ^ 1158627804 ^ 1406037655)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_3;
            case 4:
label_16:
              startInformation1 = StartInformation.Operation(99.0, EleWise.ELMA.SR.M((string) ComponentManager.wCv31Xf8BDT6klkASJPg(87862435 ^ 87661719)));
              num2 = 3;
              continue;
            case 5:
              goto label_70;
            case 6:
label_74:
              startInformation1 = StartInformation.Operation(91.0, (string) ComponentManager.zCdDexf8Ov8Ow1CLnVht((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439799348)));
              num2 = 7;
              continue;
            case 7:
              try
              {
                this.RegisterComponents();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                    goto label_16;
                }
              }
              finally
              {
                int num8;
                if (startInformation1 == null)
                  num8 = 2;
                else
                  goto label_56;
label_55:
                switch (num8)
                {
                  case 1:
                    break;
                  default:
                }
label_56:
                ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) startInformation1);
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                {
                  num8 = 0;
                  goto label_55;
                }
                else
                  goto label_55;
              }
            case 8:
              goto label_59;
            default:
              goto label_15;
          }
        }
label_3:
        try
        {
          this.stage = ComponentManager.LifetimeStage.InitCompleting;
          int num9 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
            num9 = 0;
          while (true)
          {
            switch (num9)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                Action<IInitHandler> action1 = ComponentManager.\u003C\u003Ec.\u003C\u003E9__84_0;
                Action<IInitHandler> action2;
                if (action1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  ComponentManager.\u003C\u003Ec.\u003C\u003E9__84_0 = action2 = (Action<IInitHandler>) (h => ComponentManager.\u003C\u003Ec.AmkM3l8rAvvtRtS2jjNr((object) h));
                }
                else
                  goto label_75;
label_8:
                this.InvokeInitHandlers(action2);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                continue;
label_75:
                action2 = action1;
                goto label_8;
              default:
                goto label_15;
            }
          }
        }
        finally
        {
          int num10;
          if (startInformation1 == null)
            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
          else
            goto label_12;
label_11:
          switch (num10)
          {
            case 2:
              break;
            default:
          }
label_12:
          ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) startInformation1);
          num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
          {
            num10 = 0;
            goto label_11;
          }
          else
            goto label_11;
        }
label_15:
        startInformation1 = StartInformation.Operation(99.0, (string) ComponentManager.zCdDexf8Ov8Ow1CLnVht(ComponentManager.wCv31Xf8BDT6klkASJPg(-1710575414 ^ -1710260150)));
        num1 = 8;
      }
label_70:
      return;
label_59:
      try
      {
        int num11;
        if (this.applicationStartCache == null)
          num11 = 2;
        else
          goto label_63;
label_61:
        while (true)
        {
          switch (num11)
          {
            case 1:
            case 2:
              this.stage = ComponentManager.LifetimeStage.Initialized;
              num11 = 3;
              continue;
            case 3:
              goto label_65;
            default:
              goto label_63;
          }
        }
label_65:
        return;
label_63:
        this.applicationStartCache.Save();
        num11 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        {
          num11 = 1;
          goto label_61;
        }
        else
          goto label_61;
      }
      finally
      {
        if (startInformation1 != null)
        {
          int num12 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
            num12 = 0;
          while (true)
          {
            switch (num12)
            {
              case 1:
                goto label_72;
              default:
                ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) startInformation1);
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_72:;
      }
    }

    /// <summary>Зарегистрировать компоненты</summary>
    protected virtual void RegisterComponents()
    {
      int num1 = 10;
      IStartInformation startInformation;
      ILifetimeScope lifetimeScope;
      ProxiesAssemblyActivator assemblyActivator;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_51:
            startInformation = StartInformation.Operation(3.0, (string) ComponentManager.zCdDexf8Ov8Ow1CLnVht(ComponentManager.wCv31Xf8BDT6klkASJPg(323422137 << 2 ^ 1293495856)));
            num1 = 7;
            continue;
          case 2:
            goto label_52;
          case 3:
            this.stage = ComponentManager.LifetimeStage.Initializing;
            num1 = 6;
            continue;
          case 4:
            lifetimeScope = this.currentContainer.BeginLifetimeScope(ComponentManager.wCv31Xf8BDT6klkASJPg(654297945 ^ 653982279));
            num1 = 2;
            continue;
          case 5:
            goto label_102;
          case 6:
            this.registrationData = new ComponentManager.RegistrationData();
            num1 = 4;
            continue;
          case 7:
            try
            {
              int num2;
              if (ComponentManager.ak7x64f8MUeCSWUyQlu7())
                num2 = 3;
              else
                goto label_44;
label_41:
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_44;
                  case 3:
                    this.currentContainer = Locator.GetServiceNotNull<IContainer>();
                    num2 = 4;
                    continue;
                  case 4:
                    this.preInitBuilder.Update(this.currentContainer);
                    num2 = 2;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_44:
              this.currentContainer = (IContainer) ComponentManager.zZxacwf8JxHmadkXTyJS((object) this.preInitBuilder, ContainerBuildOptions.None);
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
              {
                num2 = 0;
                goto label_41;
              }
              else
                goto label_41;
            }
            finally
            {
              int num3;
              if (startInformation == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
              else
                goto label_49;
label_48:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_49:
              ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) startInformation);
              num3 = 2;
              goto label_48;
            }
          case 8:
label_4:
            ComponentManager.dKon21f89ADKk47U06VN((object) new LifetimeScopeAccessorLocatorImpl(this.currentContainer, this.currentContainer.Resolve<ILifetimeScopeAccessor>()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 9:
            try
            {
              this.interceptorsToRegister = new Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                num4 = 1;
              while (true)
              {
                object obj;
                switch (num4)
                {
                  case 1:
                    if (this.runtimeApplication == null)
                    {
                      num4 = 2;
                      continue;
                    }
                    obj = ComponentManager.i5KsxUf80NLvuC9y1TJH((object) this.runtimeApplication);
                    break;
                  case 2:
                    obj = (object) null;
                    break;
                  case 3:
                    try
                    {
                      ComponentManager.BTftcJf8mQJ0fJiLolaw((object) this, (object) this.registrationData);
                      int num5 = 6;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            this.preInitBuilder.RegisterInstance<IModuleManager>(this.moduleManager).As<IModuleManager>().As<EleWise.ELMA.Modules.Impl.ModuleManager>().SingleInstance();
                            num5 = 5;
                            continue;
                          case 2:
                            goto label_12;
                          case 3:
                            this.preInitBuilder.RegisterInstance<PackageService>(this.packageService).As<PackageService>().SingleInstance();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                            continue;
                          case 4:
                            if (this.packageService != null)
                            {
                              num5 = 3;
                              continue;
                            }
                            goto default;
                          case 5:
                          case 8:
                            this.preInitBuilder.RegisterInstance<LifetimeScopeAccessor>(new LifetimeScopeAccessor((Func<ILifetimeScope>) (() => (ILifetimeScope) this.currentContainer))).As<ILifetimeScopeAccessor>().SingleInstance();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 7;
                            continue;
                          case 6:
                            this.preInitBuilder.RegisterInstance<ComponentManager>(this).As<IComponentManager>().As<ComponentManager>().SingleInstance();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 4;
                            continue;
                          case 7:
                            ComponentManager.S2Tp5lf8yImDLkmk4tjl(ComponentManager.AvZseCf87nQFXfGZQCuK(), 95.0);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 2;
                            continue;
                          default:
                            if (this.moduleManager == null)
                            {
                              num5 = 8;
                              continue;
                            }
                            goto case 1;
                        }
                      }
                    }
                    finally
                    {
                      int num6;
                      if (assemblyActivator == null)
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 1;
                      else
                        goto label_29;
label_28:
                      switch (num6)
                      {
                        case 1:
                          break;
                        default:
                      }
label_29:
                      assemblyActivator.Dispose();
                      num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                      {
                        num6 = 0;
                        goto label_28;
                      }
                      else
                        goto label_28;
                    }
                  case 4:
                    goto label_51;
                  default:
label_12:
                    this.interceptorsToRegister = (Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>) null;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 4;
                    continue;
                }
                string cacheName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218630530);
                Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister = this.interceptorsToRegister;
                assemblyActivator = new ProxiesAssemblyActivator((DbPreUpdater) obj, cacheName, interceptorsToRegister);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
              }
            }
            finally
            {
              int num7;
              if (startInformation == null)
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              else
                goto label_37;
label_36:
              switch (num7)
              {
                case 1:
                  break;
                default:
              }
label_37:
              startInformation.Dispose();
              num7 = 2;
              goto label_36;
            }
          case 10:
            startInformation = (IStartInformation) ComponentManager.OB3ZKXf82AiHB1c8go0f(2.0, ComponentManager.LZ008Nf8xmu585fmbT9g(ComponentManager.AvZseCf87nQFXfGZQCuK()));
            num1 = 9;
            continue;
          default:
            this.preInitBuilder = (ContainerBuilder) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 3;
            continue;
        }
      }
label_102:
      return;
label_52:
      try
      {
        this.initBuilder = new ContainerBuilder();
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
          num8 = 1;
        while (true)
        {
          switch (num8)
          {
            case 1:
              this.preInitBuilder = this.initBuilder;
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 2:
              startInformation = (IStartInformation) ComponentManager.OB3ZKXf82AiHB1c8go0f(99.0, ComponentManager.zCdDexf8Ov8Ow1CLnVht(ComponentManager.wCv31Xf8BDT6klkASJPg(-1822890472 ^ -1822566556)));
              num8 = 5;
              continue;
            case 3:
label_96:
              this.initBuilder = (ContainerBuilder) null;
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 4 : 2;
              continue;
            case 4:
              this.preInitBuilder = (ContainerBuilder) null;
              num8 = 7;
              continue;
            case 5:
              try
              {
                ComponentManager.r87KH2f8pPCgu5NM7KpL((object) this.initBuilder, (object) this.currentContainer);
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
                  num9 = 0;
                switch (num9)
                {
                  default:
                    goto label_96;
                }
              }
              finally
              {
                if (startInformation != null)
                {
                  int num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                    num10 = 0;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        goto label_94;
                      default:
                        startInformation.Dispose();
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_94:;
              }
            case 6:
              try
              {
                int num11;
                if (this.runtimeApplication == null)
                  num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
                else
                  goto label_62;
label_60:
                object obj;
                switch (num11)
                {
                  case 1:
                    obj = (object) null;
                    goto label_63;
                  default:
                    try
                    {
                      // ISSUE: reference to a compiler-generated field
                      Action<IInitHandler> action1 = ComponentManager.\u003C\u003Ec.\u003C\u003E9__85_1;
                      Action<IInitHandler> action2;
                      if (action1 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        ComponentManager.\u003C\u003Ec.\u003C\u003E9__85_1 = action2 = (Action<IInitHandler>) (h => h.Init());
                      }
                      else
                        goto label_105;
label_68:
                      this.InvokeInitHandlers(action2);
                      int num12 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                        num12 = 0;
                      while (true)
                      {
                        switch (num12)
                        {
                          case 1:
                            ComponentManager.S2Tp5lf8yImDLkmk4tjl((object) StartInformation.Current, 95.0);
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_95;
                        }
                      }
label_105:
                      action2 = action1;
                      goto label_68;
                    }
                    finally
                    {
                      int num13;
                      if (assemblyActivator == null)
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                      else
                        goto label_75;
label_74:
                      switch (num13)
                      {
                        case 2:
                          break;
                        default:
                      }
label_75:
                      ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) assemblyActivator);
                      num13 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                      {
                        num13 = 0;
                        goto label_74;
                      }
                      else
                        goto label_74;
                    }
                }
label_62:
                obj = ComponentManager.i5KsxUf80NLvuC9y1TJH((object) this.runtimeApplication);
label_63:
                object cacheName = ComponentManager.wCv31Xf8BDT6klkASJPg(-1146510045 ^ -1146317757);
                Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>> interceptorsToRegister = this.interceptorsToRegister;
                assemblyActivator = new ProxiesAssemblyActivator((DbPreUpdater) obj, (string) cacheName, interceptorsToRegister);
                num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                {
                  num11 = 0;
                  goto label_60;
                }
                else
                  goto label_60;
              }
              finally
              {
                if (startInformation != null)
                {
                  int num14 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                    num14 = 0;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 1:
                        goto label_83;
                      default:
                        ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) startInformation);
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_83:;
              }
            case 7:
              goto label_97;
            case 8:
label_95:
              this.interceptorsToRegister = (Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>) null;
              num8 = 2;
              continue;
            case 9:
              startInformation = (IStartInformation) ComponentManager.OB3ZKXf82AiHB1c8go0f(98.0, ComponentManager.zCdDexf8Ov8Ow1CLnVht(ComponentManager.wCv31Xf8BDT6klkASJPg(1012087039 ^ 1012271573)));
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 0;
              continue;
            default:
              this.interceptorsToRegister = new Dictionary<Type, IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>>();
              num8 = 9;
              continue;
          }
        }
label_97:;
      }
      finally
      {
        if (lifetimeScope != null)
        {
          int num15 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
            num15 = 0;
          while (true)
          {
            switch (num15)
            {
              case 1:
                goto label_104;
              default:
                ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) lifetimeScope);
                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_104:;
      }
    }

    /// <summary>Зарегистрировать сборки и компоненты из data</summary>
    /// <param name="regData">Регистрируемые данные</param>
    protected virtual void RegisterData(ComponentManager.RegistrationData regData)
    {
      int num1 = 6;
      List<object>.Enumerator enumerator1;
      List<Assembly>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_40:
            enumerator2 = regData.Assemblies.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          case 3:
label_39:
            enumerator2 = regData.DisabledAssemblies.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 2;
            continue;
          case 4:
            goto label_37;
          case 5:
            try
            {
label_8:
              if (enumerator1.MoveNext())
                goto label_5;
              else
                goto label_9;
label_4:
              object current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    ComponentManager.m7QHUtf8dZ9i8Ndx3bXb((object) this, current);
                    num2 = 2;
                    continue;
                  case 2:
                    goto label_8;
                  case 3:
                    goto label_40;
                  default:
                    goto label_5;
                }
              }
label_5:
              current = enumerator1.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
              {
                num2 = 1;
                goto label_4;
              }
              else
                goto label_4;
label_9:
              num2 = 3;
              goto label_4;
            }
            finally
            {
              enumerator1.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 6:
            enumerator1 = regData.ComponentsToRegister.GetEnumerator();
            num1 = 5;
            continue;
          default:
            try
            {
label_28:
              if (enumerator2.MoveNext())
                goto label_31;
              else
                goto label_29;
label_26:
              Assembly current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    this.ProcessAssembly(current);
                    num4 = 3;
                    continue;
                  case 2:
                    goto label_39;
                  case 3:
                    goto label_28;
                  default:
                    goto label_31;
                }
              }
label_29:
              num4 = 2;
              goto label_26;
label_31:
              current = enumerator2.Current;
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
              {
                num4 = 1;
                goto label_26;
              }
              else
                goto label_26;
            }
            finally
            {
              enumerator2.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
        }
      }
label_37:
      return;
label_14:
      try
      {
label_18:
        if (enumerator2.MoveNext())
          goto label_16;
        else
          goto label_19;
label_15:
        Assembly current;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 0:
              goto label_33;
            case 1:
              goto label_18;
            case 2:
              this.ProcessAssembly(current, disabled: true);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_16;
            default:
              goto label_27;
          }
        }
label_33:
        return;
label_27:
        return;
label_16:
        current = enumerator2.Current;
        num6 = 2;
        goto label_15;
label_19:
        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
        goto label_15;
      }
      finally
      {
        enumerator2.Dispose();
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num7 = 0;
        switch (num7)
        {
          default:
        }
      }
    }

    /// <summary>Зарегистрировать перехватчики</summary>
    protected virtual void RegisterAutofacInterceptors()
    {
      int num1 = 2;
      List<Tuple<Type, string>>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        List<Tuple<Type, string, Type>>.Enumerator enumerator2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_18;
            case 2:
              enumerator2 = ComponentManager.attributeMethodInterceptors.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
            case 3:
label_15:
              enumerator1 = ComponentManager.requiredInterceptors.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_16;
            case 5:
              goto label_39;
            case 6:
              try
              {
label_30:
                if (enumerator2.MoveNext())
                  goto label_32;
                else
                  goto label_31;
label_29:
                Tuple<Type, string, Type> current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_15;
                    case 2:
                      goto label_32;
                    case 3:
                      goto label_30;
                    default:
                      this.preInitBuilder.RegisterType(current.Item1).Named<IInterceptor>(current.Item2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 1;
                      continue;
                  }
                }
label_31:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
                goto label_29;
label_32:
                current = enumerator2.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                {
                  num3 = 0;
                  goto label_29;
                }
                else
                  goto label_29;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            default:
              goto label_3;
          }
        }
label_16:
        enumerator2 = ComponentManager.typeInterceptors.GetEnumerator();
        num1 = 6;
        continue;
label_18:
        try
        {
label_22:
          if (enumerator2.MoveNext())
            goto label_21;
          else
            goto label_23;
label_19:
          Tuple<Type, string, Type> current;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_21;
              case 2:
                this.preInitBuilder.RegisterType(current.Item1).Named<IInterceptor>(current.Item2);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                continue;
              case 3:
                goto label_16;
              default:
                goto label_22;
            }
          }
label_21:
          current = enumerator2.Current;
          num5 = 2;
          goto label_19;
label_23:
          num5 = 3;
          goto label_19;
        }
        finally
        {
          enumerator2.Dispose();
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
            num6 = 0;
          switch (num6)
          {
            default:
          }
        }
      }
label_39:
      return;
label_3:
      try
      {
label_7:
        if (enumerator1.MoveNext())
          goto label_9;
        else
          goto label_8;
label_5:
        Tuple<Type, string> current;
        int num7;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_7;
            case 3:
              goto label_35;
            default:
              this.preInitBuilder.RegisterType(current.Item1).Named<IInterceptor>(current.Item2);
              num7 = 2;
              continue;
          }
        }
label_35:
        return;
label_8:
        num7 = 3;
        goto label_5;
label_9:
        current = enumerator1.Current;
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        {
          num7 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        enumerator1.Dispose();
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num8 = 0;
        switch (num8)
        {
          default:
        }
      }
    }

    /// <summary>Зарегистрировать модули Autofac</summary>
    protected virtual void RegisterAutofacModules()
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        ComponentManager.\u003C\u003Ec__DisplayClass88_0 cDisplayClass880;
        while (true)
        {
          List<Tuple<Type, string, Type>>.Enumerator enumerator;
          switch (num2)
          {
            case 1:
              this.preInitBuilder.RegisterModule((Autofac.Core.IModule) new EntityManagerActionsCollectModule());
              num2 = 9;
              continue;
            case 2:
              this.preInitBuilder.RegisterModule((Autofac.Core.IModule) new LoggingModule());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            case 3:
label_28:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass880.cfgServiceMessageTemplate = EleWise.ELMA.SR.T((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-2112703338 ^ -2112387482));
              num2 = 10;
              continue;
            case 4:
              try
              {
label_19:
                if (enumerator.MoveNext())
                  goto label_18;
                else
                  goto label_20;
label_14:
                // ISSUE: variable of a compiler-generated type
                ComponentManager.\u003C\u003Ec__DisplayClass88_1 cDisplayClass881;
                Tuple<Type, string, Type> current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass881.attributeType = current.Item3;
                      num3 = 2;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ComponentManager.P7ty2Tf8ljIjsQ73A092((object) this.preInitBuilder, (object) new RequiredVirtualMethodModule(new Func<Type, IEnumerable<MethodInfo>>(cDisplayClass881.\u003CRegisterAutofacModules\u003Eb__4), new Func<Type, MethodInfo, string>(cDisplayClass881.\u003CRegisterAutofacModules\u003Eb__5), this.applicationStartCache));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 4;
                      continue;
                    case 3:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass881 = new ComponentManager.\u003C\u003Ec__DisplayClass88_1();
                      num3 = 6;
                      continue;
                    case 4:
                      goto label_19;
                    case 5:
                      goto label_18;
                    case 6:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass881.CS\u0024\u003C\u003E8__locals1 = cDisplayClass880;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_28;
                  }
                }
label_18:
                current = enumerator.Current;
                num3 = 3;
                goto label_14;
label_20:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                goto label_14;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              ComponentManager.P7ty2Tf8ljIjsQ73A092((object) this.preInitBuilder, (object) new RequiredVirtualMethodModule(new Func<Type, IEnumerable<MethodInfo>>(cDisplayClass880.\u003CRegisterAutofacModules\u003Eb__2), new Func<Type, MethodInfo, string>(cDisplayClass880.\u003CRegisterAutofacModules\u003Eb__3), this.applicationStartCache));
              num2 = 14;
              continue;
            case 6:
              goto label_12;
            case 7:
              goto label_25;
            case 8:
              enumerator = ComponentManager.attributeMethodInterceptors.GetEnumerator();
              num2 = 4;
              continue;
            case 9:
              ComponentManager.P7ty2Tf8ljIjsQ73A092((object) this.preInitBuilder, (object) new EntityActivationModule());
              num2 = 13;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              ComponentManager.P7ty2Tf8ljIjsQ73A092((object) this.preInitBuilder, (object) new RequiredVirtualMethodModule(new Func<Type, IEnumerable<MethodInfo>>(cDisplayClass880.\u003CRegisterAutofacModules\u003Eb__0), new Func<Type, MethodInfo, string>(cDisplayClass880.\u003CRegisterAutofacModules\u003Eb__1), this.applicationStartCache));
              num2 = 15;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass880.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
              continue;
            case 12:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass880 = new ComponentManager.\u003C\u003Ec__DisplayClass88_0();
              num2 = 11;
              continue;
            case 13:
              ComponentManager.P7ty2Tf8ljIjsQ73A092((object) this.preInitBuilder, (object) new ExtensionPointsActivationModule());
              num2 = 6;
              continue;
            case 14:
              if (this.componentType == ComponentType.Test)
                break;
              goto label_6;
            case 15:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: type reference
              cDisplayClass880.attType = ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (HubMethodNameAttribute));
              num2 = 5;
              continue;
          }
          ComponentManager.P7ty2Tf8ljIjsQ73A092((object) this.preInitBuilder, (object) new LazyResolverModule());
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 7 : 7;
        }
label_6:
        num1 = 2;
        continue;
label_12:
        // ISSUE: reference to a compiler-generated field
        cDisplayClass880.messageTemplate = (string) ComponentManager.oB6VAWfvjUcykXtDN2xn(ComponentManager.wCv31Xf8BDT6klkASJPg(1470998129 - 231418599 ^ 1239894606));
        num1 = 8;
      }
label_25:;
    }

    /// <summary>Загрузить сборки</summary>
    /// <param name="onlyLoadedAssemblies">Только загруженные сборки</param>
    protected virtual void LoadAssemblies(bool onlyLoadedAssemblies)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.LoadAssemblies(onlyLoadedAssemblies, (AppDomain) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Загрузить сборки</summary>
    /// <param name="onlyLoadedAssemblies">Только загруженные сборки</param>
    /// <param name="domain"></param>
    protected virtual void LoadAssemblies(bool onlyLoadedAssemblies, AppDomain domain)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        string path;
        IEnumerator<string> enumerator;
        int index;
        string[] assembliesPaths;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 9:
              if (index >= assembliesPaths.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 7 : 5;
                continue;
              }
              goto label_48;
            case 2:
              goto label_45;
            case 3:
              goto label_48;
            case 4:
              enumerator = ((IEnumerable<string>) ComponentManager.RpN0Cif8rMl36lDkbCPb((object) path, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138876098))).Union<string>((IEnumerable<string>) Directory.GetFiles(path, z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459386561))).GetEnumerator();
              num2 = 6;
              continue;
            case 5:
              goto label_40;
            case 6:
              try
              {
label_17:
                if (ComponentManager.pMYTqhf8UFUy6jrJ5ODO((object) enumerator))
                  goto label_19;
                else
                  goto label_18;
label_16:
                int num3;
                string file;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      file = enumerator.Current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_19;
                    case 3:
                      goto label_17;
                    case 4:
                      goto label_7;
                    default:
                      goto label_21;
                  }
                }
label_21:
                try
                {
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  Assembly assembly = ((IEnumerable<Assembly>) ComponentManager.v5Q9sxf8V01q5Iw9Niyo((object) domain)).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a => ((string) ComponentManager.\u003C\u003Ec__DisplayClass90_0.Ti8VGO8gfp5Ytwe8c7Lr((object) a)).Equals((string) ComponentManager.\u003C\u003Ec__DisplayClass90_0.jOaR968gQ3SmLRTCtJV8((object) file), StringComparison.CurrentCultureIgnoreCase)));
                  int num4 = 3;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
                    num4 = 5;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                      case 3:
                      case 6:
                        goto label_17;
                      case 2:
                        this.AddAssembly(assembly);
                        num4 = 6;
                        continue;
                      case 4:
                        if (onlyLoadedAssemblies)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                          continue;
                        }
                        break;
                      case 5:
                        if (ComponentManager.RFH3yXf8G144TwqweIOi((object) assembly, (object) null))
                        {
                          num4 = 2;
                          continue;
                        }
                        goto case 4;
                    }
                    this.AddAssembly(domain != null ? (Assembly) ComponentManager.BBH6ZXf8jMvCBLNJBUG0((object) domain, ComponentManager.qZRn8xf85fbF35GLkVx7((object) file)) : (Assembly) ComponentManager.xhDBvwf8giCa1LwM4d84((object) file));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 3 : 1;
                  }
                }
                catch (BadImageFormatException ex)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_17;
                      default:
                        ComponentManager.yVWEs6f8L7ZQtBtryb75(ComponentManager.wYY10Qf8YZfu2qyo2lEJ(), (object) string.Format((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1487388570 ^ -1487047736), (object) file));
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
                catch (Exception ex)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_17;
                      default:
                        ((ILogger) ComponentManager.wYY10Qf8YZfu2qyo2lEJ()).Warn(ComponentManager.wCv31Xf8BDT6klkASJPg(-53329496 >> 4 ^ -3663896), ex);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_18:
                num3 = 4;
                goto label_16;
label_19:
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
                {
                  num3 = 0;
                  goto label_16;
                }
                else
                  goto label_16;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num7 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
                    num7 = 1;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        enumerator.Dispose();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_47;
                    }
                  }
                }
label_47:;
              }
            case 7:
              goto label_11;
            case 8:
label_7:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
              continue;
            case 10:
              goto label_3;
            case 11:
              if (this._assembliesLoaded)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 5 : 10;
                continue;
              }
              if (this._assembliesPaths != null)
                goto case 12;
              else
                goto label_10;
            case 12:
              assembliesPaths = this._assembliesPaths;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
              continue;
            default:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 9 : 8;
              continue;
          }
        }
label_10:
        num1 = 5;
        continue;
label_11:
        this._assembliesLoaded = true;
        num1 = 2;
        continue;
label_48:
        path = assembliesPaths[index];
        num1 = 4;
      }
label_45:
      return;
label_40:
      return;
label_3:;
    }

    /// <summary>Вызвать метод компонентов IInitHandler</summary>
    protected virtual void InvokeInitHandlers(Action<IInitHandler> action)
    {
      foreach (IInitHandler extensionPoint in this.GetExtensionPoints<IInitHandler>())
        action(extensionPoint);
    }

    /// <summary>Уничтожение менеджера</summary>
    /// <param name="disposing"></param>
    protected virtual void Dispose(bool disposing)
    {
      int num1 = 5;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_18;
          case 1:
            if (this.currentContainer != null)
            {
              num1 = 2;
              continue;
            }
            goto case 6;
          case 2:
            try
            {
              ComponentManager.GZq6Oaf8FISSCf4iMf0C((object) this.currentContainer);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_2;
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    ComponentManager.LB0mCcf8cq99ok71aam0(ComponentManager.K3ITMvf8s05BklVvjDli(), ComponentManager.wCv31Xf8BDT6klkASJPg(1505778440 - 1981636111 ^ -475543391), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
            }
          case 3:
            ComponentManager._current = (ComponentManager) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 4:
            ((ILogger) ComponentManager.K3ITMvf8s05BklVvjDli()).Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406038633));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          case 5:
            this.stage = ComponentManager.LifetimeStage.Disposed;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 4;
            continue;
          case 6:
label_2:
            if (ComponentManager._current == this)
            {
              num1 = 3;
              continue;
            }
            goto label_16;
          default:
            goto label_12;
        }
      }
label_18:
      return;
label_12:
      return;
label_16:;
    }

    /// <summary>Обработать сборку</summary>
    /// <param name="assembly">Сборка</param>
    /// <param name="checkComponentAttribute">Проверять ли наличие атрибута у сборки</param>
    /// <param name="disabled">Отключена ли сборка (по умолчанию false)</param>
    protected virtual void ProcessAssembly(
      Assembly assembly,
      bool checkComponentAttribute = true,
      bool disabled = false)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        bool flag;
        bool? componentAssembly;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.processedAssemblies.Add(assembly);
              num2 = 4;
              continue;
            case 2:
              if (!this.processedAssemblies.Contains(assembly))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                continue;
              }
              goto label_31;
            case 3:
              goto label_18;
            case 4:
              this.assemblyInfoCache = (AssemblyInfoCache) null;
              num2 = 17;
              continue;
            case 5:
              flag = true;
              num2 = 16;
              continue;
            case 6:
              if (this.assemblyInfoCache == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 6 : 10;
                continue;
              }
              goto case 20;
            case 7:
              if (componentAssembly.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 11 : 5;
                continue;
              }
              goto label_10;
            case 8:
            case 15:
            case 16:
            case 18:
              if (flag)
              {
                num2 = 3;
                continue;
              }
              goto label_30;
            case 9:
              flag = componentAssembly.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 14 : 15;
              continue;
            case 10:
            case 12:
              goto label_10;
            case 11:
              componentAssembly = this.assemblyInfoCache.IsComponentAssembly;
              num2 = 9;
              continue;
            case 13:
              goto label_8;
            case 14:
              goto label_11;
            case 17:
              if (!checkComponentAttribute)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 5;
                continue;
              }
              goto case 21;
            case 19:
              goto label_36;
            case 20:
              componentAssembly = this.assemblyInfoCache.IsComponentAssembly;
              num2 = 7;
              continue;
            case 21:
              this.assemblyInfoCache = this.applicationStartCache == null ? (AssemblyInfoCache) (object) null : (AssemblyInfoCache) ComponentManager.fwAmGgf8zofGfRgrkkHS((object) this.applicationStartCache, (object) assembly);
              num2 = 6;
              continue;
            default:
              goto label_32;
          }
        }
label_10:
        flag = ComponentManager.ccwPrsfZFfxGqf7KjX5X((object) this, (object) assembly);
        num1 = 14;
        continue;
label_11:
        if (this.assemblyInfoCache == null)
        {
          num1 = 18;
          continue;
        }
label_32:
        this.assemblyInfoCache.IsComponentAssembly = new bool?(flag);
        num1 = 8;
      }
label_8:
      return;
label_36:
      return;
label_30:
      return;
label_18:
      try
      {
        this.ProcessComponentAssembly(assembly, disabled);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      finally
      {
        this.assemblyInfoCache = (AssemblyInfoCache) null;
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_31:;
    }

    /// <summary>Обработать сборку, содержащую компоненты</summary>
    /// <param name="assembly">Сборка</param>
    /// <param name="disabled">Отключена ли сборка (по умолчанию false)</param>
    protected virtual void ProcessComponentAssembly(Assembly assembly, bool disabled = false)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!ComponentManager.MLUjBmf8uveewmtmyNK1((object) assembly, (object) null))
            {
              if (!this.componentAssemblies.Contains(assembly))
              {
                num1 = 5;
                continue;
              }
              goto label_35;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            }
          case 2:
            goto label_36;
          case 3:
            goto label_9;
          case 4:
            goto label_2;
          case 5:
            this.componentAssemblies.Add(assembly);
            num1 = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_36:
      return;
label_2:
      return;
label_4:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(864270449 << 6 ^ -521246418));
label_35:
      return;
label_9:
      try
      {
        Type[] types = assembly.GetTypes();
        int num2 = 4;
        int index;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_30;
            case 3:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            case 4:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 2;
              continue;
            case 5:
              this.ProcessType(type, disabled);
              num2 = 3;
              continue;
            case 6:
              type = types[index];
              num2 = 5;
              continue;
            default:
              if (index >= types.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
                continue;
              }
              goto case 6;
          }
        }
label_30:;
      }
      catch (ReflectionTypeLoadException ex)
      {
        int num3 = 2;
        string message;
        string str;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (!ComponentManager.mex9u6fZhL1d3Aq3MgS0(ComponentManager.x64lvJf8v6CF4oxdDeL5((object) assembly), ComponentManager.wCv31Xf8BDT6klkASJPg(1033719030 - 2012070891 ^ -978335613)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 3 : 0;
                continue;
              }
              goto label_25;
            case 2:
              str = (string) ComponentManager.E1nOPTfZWFcbapix9WGp(ComponentManager.wCv31Xf8BDT6klkASJPg(-345420348 ^ -345342510), (object) ((IEnumerable<Exception>) ComponentManager.VSD4gpfZBv3GyDn7IbhH((object) ex)).Select<Exception, string>((Func<Exception, string>) (e => e.ToString())).ToArray<string>());
              num3 = 4;
              continue;
            case 3:
              goto label_26;
            case 4:
              message = (string) ComponentManager.jMRKQmfZb6NgS6ZwZvMi(ComponentManager.wCv31Xf8BDT6klkASJPg(-643786247 ^ -643585875), ComponentManager.s1RFq1fZopCWVkoKLgAB((object) assembly), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487396008), (object) str);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_25;
            default:
              ((ILogger) ComponentManager.wYY10Qf8YZfu2qyo2lEJ()).Error((object) message, (Exception) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
              continue;
          }
        }
label_26:
        return;
label_25:
        throw new InvalidOperationException(message, (Exception) ex);
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (ComponentManager.mex9u6fZhL1d3Aq3MgS0(ComponentManager.x64lvJf8v6CF4oxdDeL5((object) assembly), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521249336)))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 2;
                continue;
              }
              goto label_19;
            case 2:
              goto label_34;
            default:
              ((ILogger) ComponentManager.wYY10Qf8YZfu2qyo2lEJ()).Error(ComponentManager.ah0QgIfZG8YS1QTM2hsV(ComponentManager.wCv31Xf8BDT6klkASJPg(572119659 - -337058038 ^ 909494259), ComponentManager.x64lvJf8v6CF4oxdDeL5((object) assembly)), ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
              continue;
          }
        }
label_19:
        return;
label_34:
        throw;
      }
    }

    /// <summary>Проверить содержит ли сборка компоненты</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns></returns>
    protected virtual bool IsComponentAssembly(Assembly assembly)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!ComponentManager.MLUjBmf8uveewmtmyNK1((object) assembly, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411207997));
label_5:
      return assembly.IsDefined(typeof (ComponentAssemblyAttribute), false);
    }

    /// <summary>Обработать тип</summary>
    /// <param name="type">Тип</param>
    /// <param name="assemblyDisabled">Отключена ли сборка с данным типом</param>
    protected virtual void ProcessType(Type type, bool assemblyDisabled = false)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        int index;
        object[] source;
        object[] objArray;
        ImplementAttribute implementAttribute;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_56;
            case 1:
              goto label_46;
            case 2:
              if (type.IsValueType)
              {
                num2 = 25;
                continue;
              }
              goto case 8;
            case 3:
              objArray = source;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 4 : 23;
              continue;
            case 4:
              if (!type.IsClass)
              {
                num2 = 28;
                continue;
              }
              goto case 9;
            case 5:
              goto label_15;
            case 6:
              implementAttribute = (ImplementAttribute) objArray[index];
              num2 = 19;
              continue;
            case 7:
              // ISSUE: type reference
              if (ComponentManager.caqunGfZCSCVAp24EyF5((object) type, ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (EntityAttribute)), false).Length == 0)
              {
                num2 = 20;
                continue;
              }
              goto case 37;
            case 8:
            case 16:
            case 36:
              if (assemblyDisabled)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 14 : 15;
                continue;
              }
              goto case 35;
            case 9:
              if (type.ContainsGenericParameters)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 13 : 26;
                continue;
              }
              goto case 21;
            case 10:
            case 13:
              if (index >= objArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 11:
              goto label_36;
            case 12:
              if (ComponentManager.Q1IZdBfZEF00fCvibT7o(type, (Type) null))
              {
                num2 = 11;
                continue;
              }
              if (!type.IsAbstract)
              {
                num2 = 34;
                continue;
              }
              goto case 22;
            case 14:
              // ISSUE: reference to a compiler-generated method
              this.preInitBuilder.RegisterType(type).As(type).As(source.Cast<ImplementAttribute>().Select<ImplementAttribute, Type>((Func<ImplementAttribute, Type>) (a => ComponentManager.\u003C\u003Ec.Ooa6om8r7uLJufod7v7M((object) a))).ToArray<Type>());
              num2 = 3;
              continue;
            case 15:
              goto label_48;
            case 17:
            case 31:
              if (type.ContainsGenericParameters)
              {
                num2 = 16;
                continue;
              }
              goto case 33;
            case 18:
              if (source.Length == 0)
              {
                num2 = 7;
                continue;
              }
              goto case 14;
            case 19:
              this.AddToExtensionPointTypesMap(ComponentManager.NAKZrlfZvugthLE49hhX((object) implementAttribute), type);
              num2 = 24;
              continue;
            case 20:
              goto label_35;
            case 21:
              if (!this.IsServiceType(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 17 : 29;
                continue;
              }
              goto label_46;
            case 22:
              if (!type.IsInterface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 2;
                continue;
              }
              goto case 17;
            case 23:
              index = 0;
              num2 = 13;
              continue;
            case 24:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 10 : 2;
              continue;
            case 25:
              if (!type.IsEnum)
              {
                num2 = 38;
                continue;
              }
              goto case 8;
            case 26:
              goto label_32;
            case 27:
              // ISSUE: type reference
              if (ComponentManager.ErSpsGfZfEQpWCmqJs9J(type, ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (Decimal))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 31 : 7;
                continue;
              }
              goto case 8;
            case 28:
              goto label_31;
            case 29:
            case 30:
              // ISSUE: type reference
              source = (object[]) ComponentManager.caqunGfZCSCVAp24EyF5((object) type, ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (ImplementAttribute)), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 15 : 18;
              continue;
            case 32:
              this.ProcessComponentType(type, assemblyDisabled);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 4 : 36;
              continue;
            case 33:
              if (ComponentManager.TieWjafZQfkqmZD9ZTHY((object) this, type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 16 : 32;
                continue;
              }
              goto case 8;
            case 34:
              if (type.IsClass)
              {
                num2 = 17;
                continue;
              }
              goto case 22;
            case 35:
              if (!type.IsAbstract)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 4;
                continue;
              }
              goto label_50;
            case 37:
              this.preInitBuilder.RegisterType(type).As(type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 5 : 4;
              continue;
            case 38:
              if (type.IsPrimitive)
              {
                num2 = 8;
                continue;
              }
              goto case 27;
            default:
              goto label_54;
          }
        }
label_46:
        this.ProcessService(type);
        num1 = 30;
      }
label_56:
      return;
label_15:
      return;
label_48:
      return;
label_35:
      return;
label_32:
      return;
label_31:
      return;
label_54:
      return;
label_50:
      return;
label_36:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1317790512 ^ -1317793550));
    }

    public bool IsServiceType(Type type)
    {
      int num1 = 13;
      bool? isServiceType;
      bool flag;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          TypeInfoCache typeInfoCache1;
          TypeInfoCache typeInfoCache2;
          switch (num2)
          {
            case 1:
            case 15:
              goto label_16;
            case 2:
            case 9:
              goto label_7;
            case 3:
              isServiceType = typeInfoCache1.IsServiceType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 14 : 8;
              continue;
            case 4:
              typeInfoCache2 = ((AssemblyInfoCache) ComponentManager.fwAmGgf8zofGfRgrkkHS((object) this.applicationStartCache, (object) type.Assembly)).GetTypeInfo(type);
              break;
            case 5:
              typeInfoCache1.IsServiceType = new bool?(flag);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            case 6:
              if (typeInfoCache1 == null)
              {
                num2 = 15;
                continue;
              }
              goto case 5;
            case 7:
              goto label_17;
            case 8:
              if (typeInfoCache1 == null)
              {
                num2 = 9;
                continue;
              }
              goto case 3;
            case 10:
              typeInfoCache2 = (TypeInfoCache) null;
              break;
            case 11:
              isServiceType = typeInfoCache1.IsServiceType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            case 12:
              goto label_20;
            case 13:
              if (ComponentManager.Q1IZdBfZEF00fCvibT7o(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 12 : 6;
                continue;
              }
              if (!this.registrationData.ServiceTypesToRegister.Contains(type))
              {
                if (this.applicationStartCache != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 4;
                  continue;
                }
                goto case 10;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 6 : 7;
                continue;
              }
            case 14:
              if (!isServiceType.HasValue)
              {
                num2 = 2;
                continue;
              }
              goto case 11;
            default:
              goto label_6;
          }
          typeInfoCache1 = typeInfoCache2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 8 : 5;
        }
label_7:
        // ISSUE: type reference
        flag = ComponentManager.QoPPLJfZ8RCjmLbtMORD((object) type, ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (ServiceAttribute)), true);
        num1 = 6;
      }
label_6:
      return isServiceType.Value;
label_16:
      return flag;
label_17:
      return true;
label_20:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-53329496 >> 4 ^ -3332040));
    }

    private void ProcessService(Type serviceType)
    {
      int num = 2;
      ComponentManager componentManager;
      Type serviceType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            componentManager = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.ProcessService(serviceType1, this.preInitBuilder, (Func<ServiceScope?, bool>) (scope =>
            {
              if (!scope.HasValue || scope.Value != ServiceScope.Shell && scope.Value != ServiceScope.UnitOfWork)
                return false;
              componentManager.shellServices.Add(serviceType1);
              return true;
            }));
            num = 3;
            continue;
          default:
            serviceType1 = serviceType;
            num = 4;
            continue;
        }
      }
label_2:;
    }

    public void ProcessShellService(
      Type serviceType,
      ContainerBuilder containerBuilder,
      params ServiceScope[] serviceScope)
    {
      int num1 = 1;
      ComponentManager componentManager;
      Type serviceType1;
      ContainerBuilder containerBuilder1;
      ServiceScope[] serviceScope1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            serviceType1 = serviceType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 6;
            continue;
          case 3:
            this.RunWithShellExtensionPointTypesMap((System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    componentManager.ProcessService(serviceType1, containerBuilder1, componentManager.SkipByScopes(serviceType1, serviceScope1));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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
          case 4:
            goto label_2;
          case 5:
            serviceScope1 = serviceScope;
            num1 = 3;
            continue;
          case 6:
            containerBuilder1 = containerBuilder;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 5;
            continue;
          default:
            componentManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    public virtual void ProcessService(
      Type serviceType,
      ContainerBuilder containerBuilder,
      Func<ServiceScope?, bool> skipCondition)
    {
      if (ComponentManager.log.IsVerboseEnabled())
        ComponentManager.log.Verbose((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113655015) + (object) serviceType));
      ServiceAttribute attribute1 = AttributeHelper<ServiceAttribute>.GetAttribute(serviceType, true);
      if (attribute1 == null || (attribute1.Type & this.componentType) == (ComponentType) 0 && !this.registrationData.ServiceTypesToRegister.Contains(serviceType))
        return;
      if (skipCondition(new ServiceScope?(attribute1.Scope)))
      {
        this.shellServices.Add(serviceType);
      }
      else
      {
        IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrationBuilder = containerBuilder.RegisterType(serviceType);
        if (attribute1.InjectProperties)
          registrationBuilder.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
        List<Type> list = ((IEnumerable<Type>) serviceType.GetInterfaces()).Where<Type>((Func<Type, bool>) (itf => !TypeOf<IEventHandler>.Raw.IsAssignableFrom(itf))).ToList<Type>();
        if (TypeOf<IEventHandler>.Raw.IsAssignableFrom(serviceType))
          list.Add(TypeOf<IEventHandler>.Raw);
        if (list.Count > 0)
          registrationBuilder.As(list.ToArray());
        registrationBuilder.As(serviceType);
        registrationBuilder.SetScope<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(attribute1.Scope);
        ComponentOrderAttribute attribute2 = AttributeHelper<ComponentOrderAttribute>.GetAttribute(serviceType, true);
        if (attribute2 != null)
          registrationBuilder.WithMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69829846), (object) attribute2.Order);
        if (!attribute1.EnableInterceptors)
          return;
        this.SetupInterceptors(serviceType, registrationBuilder);
      }
    }

    /// <summary>
    /// Зарегистрировать перехватчики (по атрибутам, навешенным на методы типа) и активировать прокси-класс для типа, если есть хотя бы один перехватчик
    /// </summary>
    /// <param name="type">Регистрируемый тип</param>
    /// <param name="registrar">Параметры регистрации в контейнере IoC</param>
    public void SetupInterceptors(
      Type type,
      IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrar)
    {
      TypeInfoCache typeInfo = this.applicationStartCache != null ? this.applicationStartCache.GetAssemblyInfo(type.Assembly).GetTypeInfo(type) : (TypeInfoCache) null;
      Dictionary<string, bool?> source = new Dictionary<string, bool?>();
      bool flag1 = false;
      foreach (string interceptorName in ComponentManager.interceptorNames)
      {
        bool? nullable = (bool?) typeInfo?.IsInterceptorEnabled(interceptorName);
        source[interceptorName] = nullable;
        if (!nullable.HasValue)
          flag1 = true;
      }
      if (flag1)
      {
        MethodInfo[] methods = registrar.ActivatorData.ImplementationType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (Tuple<Type, string, Type> methodInterceptor in ComponentManager.attributeMethodInterceptors)
        {
          if (!source[methodInterceptor.Item2].HasValue)
          {
            Tuple<Type, string, Type> interceptor = methodInterceptor;
            // ISSUE: reference to a compiler-generated method
            bool enabled = ((IEnumerable<MethodInfo>) methods).Any<MethodInfo>((Func<MethodInfo, bool>) (m => ComponentManager.\u003C\u003Ec__DisplayClass101_0.zw7XS78gXZ9tFvQXyZHp((object) m, interceptor.Item3, true).Length != 0));
            source[methodInterceptor.Item2] = new bool?(enabled);
            typeInfo?.SetInterceptorEnabled(methodInterceptor.Item2, enabled);
          }
        }
        foreach (Tuple<Type, string, Type> typeInterceptor in ComponentManager.typeInterceptors)
        {
          if (!source[typeInterceptor.Item2].HasValue)
          {
            bool enabled = typeInterceptor.Item3.IsAssignableFrom(type);
            source[typeInterceptor.Item2] = new bool?(enabled);
            typeInfo?.SetInterceptorEnabled(typeInterceptor.Item2, enabled);
          }
        }
      }
      bool flag2 = false;
      foreach (KeyValuePair<string, bool?> keyValuePair in source.Where<KeyValuePair<string, bool?>>((Func<KeyValuePair<string, bool?>, bool>) (p => p.Value.HasValue && p.Value.Value)))
      {
        registrar.InterceptedBy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(keyValuePair.Key);
        flag2 = true;
      }
      if (!flag2)
        return;
      if (flag1)
      {
        foreach (Tuple<Type, string> requiredInterceptor in ComponentManager.requiredInterceptors)
        {
          if (!source[requiredInterceptor.Item2].HasValue)
          {
            bool enabled = type.IsPublic && type.IsClass && !type.IsAbstract;
            source[requiredInterceptor.Item2] = new bool?(enabled);
            typeInfo?.SetInterceptorEnabled(requiredInterceptor.Item2, enabled);
            registrar.InterceptedBy<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(requiredInterceptor.Item2);
          }
        }
      }
      if (this.interceptorsToRegister != null)
        this.interceptorsToRegister.Add(type, registrar);
      else
        registrar.EnableClassInterceptorsCacheable<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>();
    }

    /// <summary>
    /// Проверить, является ли <paramref name="type" /> типом компонента
    /// </summary>
    /// <param name="type">Тип</param>
    /// <returns></returns>
    public virtual bool IsComponentType(Type type)
    {
      int num1 = 22;
      bool? isComponentType;
      bool flag;
      while (true)
      {
        int num2 = num1;
        TypeInfoCache typeInfoCache1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              flag = false;
              num2 = 19;
              continue;
            case 2:
              if (typeInfoCache1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 17 : 12;
                continue;
              }
              break;
            case 3:
              if (isComponentType.HasValue)
              {
                num2 = 10;
                continue;
              }
              break;
            case 4:
            case 7:
              Type[] interfaces = type.GetInterfaces();
              // ISSUE: reference to a compiler-generated field
              Func<Type, bool> func = ComponentManager.\u003C\u003Ec.\u003C\u003E9__102_0;
              Func<Type, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ComponentManager.\u003C\u003Ec.\u003C\u003E9__102_0 = predicate = (Func<Type, bool>) (intf => ComponentManager.\u003C\u003Ec.W1JlcZ8rxR1nQA81XnP8((object) intf, ComponentManager.\u003C\u003Ec.p0to0q8r4vDsnxUQjfRL(__typeref (ComponentAttribute)), true));
              }
              else
                goto label_34;
label_33:
              flag = ComponentManager.ErSpsGfZfEQpWCmqJs9J(((IEnumerable<Type>) interfaces).FirstOrDefault<Type>(predicate), (Type) null);
              num2 = 9;
              continue;
label_34:
              predicate = func;
              goto label_33;
            case 5:
label_24:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 7 : 16;
              continue;
            case 6:
              goto label_20;
            case 8:
              goto label_29;
            case 9:
            case 16:
            case 19:
              if (typeInfoCache1 != null)
              {
                num2 = 13;
                continue;
              }
              goto label_7;
            case 10:
              isComponentType = typeInfoCache1.IsComponentType;
              num2 = 12;
              continue;
            case 11:
              if (this.applicationStartCache != null)
              {
                num2 = 8;
                continue;
              }
              goto label_23;
            case 12:
              goto label_13;
            case 13:
              typeInfoCache1.IsComponentType = new bool?(flag);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 14 : 9;
              continue;
            case 14:
              goto label_7;
            case 15:
              goto label_4;
            case 17:
              isComponentType = typeInfoCache1.IsComponentType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 1;
              continue;
            case 18:
              goto label_23;
            case 21:
              goto label_5;
            case 22:
              if (!ComponentManager.Q1IZdBfZEF00fCvibT7o(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 21 : 5;
                continue;
              }
              goto label_4;
            default:
              if (type.IsInterface)
              {
                num2 = 4;
                continue;
              }
              goto case 1;
          }
          // ISSUE: type reference
          if (!ComponentManager.QoPPLJfZ8RCjmLbtMORD((object) type, ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (ComponentAttribute)), true))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
          else
            goto label_24;
        }
label_5:
        if (!this.registrationData.ComponentsTypesToRegister.Contains(type))
        {
          num1 = 11;
          continue;
        }
        goto label_20;
label_23:
        TypeInfoCache typeInfoCache2 = (TypeInfoCache) null;
        goto label_30;
label_29:
        typeInfoCache2 = this.applicationStartCache.GetAssemblyInfo(type.Assembly).GetTypeInfo(type);
label_30:
        typeInfoCache1 = typeInfoCache2;
        num1 = 2;
      }
label_4:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(1199946765 ^ 1199943727));
label_7:
      return flag;
label_13:
      return isComponentType.Value;
label_20:
      return true;
    }

    /// <summary>Создать компонент компонент</summary>
    /// <param name="type">Тип компонента</param>
    protected virtual object CreateComponent(Type type)
    {
      object component;
      switch (1)
      {
        case 1:
          try
          {
            component = ComponentManager.uquioYfZZPrSnh2AyBLt(type, true);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  ComponentManager.LB0mCcf8cq99ok71aam0(ComponentManager.K3ITMvf8s05BklVvjDli(), ComponentManager.ah0QgIfZG8YS1QTM2hsV(ComponentManager.wCv31Xf8BDT6klkASJPg(901793403 ^ 902132579), (object) type), (object) ex);
                  num = 2;
                  continue;
                case 2:
                  component = (object) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_9;
              }
            }
          }
          break;
      }
label_9:
      return component;
    }

    /// <summary>Обработать тип компонента</summary>
    /// <param name="type">Тип компонента</param>
    protected virtual void ProcessComponentType(Type type, bool assemblyDisabled = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ProcessComponent(type, (object) null, assemblyDisabled);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обработать компонент</summary>
    /// <param name="component">Компонент</param>
    protected virtual void ProcessComponent(object component)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_3;
          case 2:
            if (component != null)
            {
              this.ProcessComponent(component.GetType(), component);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_3:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-488881205 ^ -488740317));
    }

    protected virtual void ProcessComponent(Type type, object instance, bool assemblyDisabled = false)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        ComponentManager componentManager;
        Type type1;
        object instance1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              componentManager = this;
              num2 = 7;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_5;
            case 4:
              instance1 = instance;
              num2 = 5;
              continue;
            case 5:
              goto label_9;
            case 6:
              this.componentTypes.Add(type1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            case 7:
              type1 = type;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 4;
              continue;
            case 8:
              goto label_12;
            default:
              this.ProcessComponent(type1, instance1, this.preInitBuilder, (Func<ServiceScope?, bool>) (scope =>
              {
                if (!scope.HasValue || scope.Value != ServiceScope.Shell && scope.Value != ServiceScope.UnitOfWork)
                  return false;
                componentManager.shellComponents.Add(new Tuple<Type, object>(type1, instance1));
                return true;
              }), assemblyDisabled);
              num2 = 8;
              continue;
          }
        }
label_9:
        if (!this.componentTypes.Contains(type1))
          num1 = 6;
        else
          goto label_3;
      }
label_5:
      return;
label_12:
      return;
label_3:;
    }

    public virtual bool IsProcessedType(Type type) => this.componentTypes.Contains(type);

    private void RunWithShellExtensionPointTypesMap(System.Action action)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        Dictionary<Type, List<Type>> pointTypesMapToAdd;
        while (true)
        {
          switch (num2)
          {
            case 1:
              pointTypesMapToAdd = this.extensionPointTypesMapToAdd;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.extensionPointTypesMapToAdd = pointTypesMapToAdd;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
              continue;
            case 4:
              ComponentManager.lLPXDTfZulS9hZZw80iO((object) action);
              num2 = 3;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        this.extensionPointTypesMapToAdd = this.extensionPointTypesMapShell;
        num1 = 4;
      }
label_3:;
    }

    /// <summary>
    /// Зарегистрировать Shell компоненты, этот метод следует вызывать при создании shell scope
    /// </summary>
    /// <param name="containterBuilder"></param>
    public virtual void AddShellComponents(ContainerBuilder containterBuilder)
    {
      int num1 = 2;
      ComponentManager componentManager;
      ContainerBuilder containterBuilder1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            componentManager = this;
            num1 = 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
          case 3:
            containterBuilder1 = containterBuilder;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 5 : 0;
            continue;
          case 4:
            this.RunWithShellExtensionPointTypesMap((System.Action) (() =>
            {
              int num2 = 6;
              List<Type>.Enumerator enumerator1;
              while (true)
              {
                int num3 = num2;
                List<Tuple<Type, object>>.Enumerator enumerator2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ComponentManager.\u003C\u003Ec__DisplayClass109_0.cpijhG8garwOIyrt1PGb(ComponentManager.\u003C\u003Ec__DisplayClass109_0.gyj56p8gNVoCD1T1psyd(), (object) EleWise.ELMA.SR.T((string) ComponentManager.\u003C\u003Ec__DisplayClass109_0.h1Ve8h8g3iFQMwLrvRO1(-1921202237 ^ -1921332159), (object) ComponentManager.\u003C\u003Ec__DisplayClass109_0.m9HbfG8gpIfI4mKJDhKt((object) componentManager.shellComponents)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                      continue;
                    case 2:
label_34:
                      enumerator1 = componentManager.shellServices.GetEnumerator();
                      num3 = 4;
                      continue;
                    case 3:
                      try
                      {
label_22:
                        if (enumerator2.MoveNext())
                          goto label_20;
                        else
                          goto label_23;
label_19:
                        Tuple<Type, object> current;
                        int num4;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              goto label_22;
                            case 2:
                              ComponentManager componentManager1 = componentManager;
                              Type type = current.Item1;
                              object instance = current.Item2;
                              ContainerBuilder containerBuilder = containterBuilder1;
                              // ISSUE: reference to a compiler-generated field
                              Func<ServiceScope?, bool> func = ComponentManager.\u003C\u003Ec.\u003C\u003E9__109_1;
                              Func<ServiceScope?, bool> skipCondition;
                              if (func == null)
                              {
                                // ISSUE: reference to a compiler-generated field
                                ComponentManager.\u003C\u003Ec.\u003C\u003E9__109_1 = skipCondition = (Func<ServiceScope?, bool>) (scope => false);
                              }
                              else
                                goto label_35;
label_26:
                              componentManager1.ProcessComponent(type, instance, containerBuilder, skipCondition);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
                              continue;
label_35:
                              skipCondition = func;
                              goto label_26;
                            case 3:
                              goto label_20;
                            default:
                              goto label_34;
                          }
                        }
label_20:
                        current = enumerator2.Current;
                        num4 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                        {
                          num4 = 2;
                          goto label_19;
                        }
                        else
                          goto label_19;
label_23:
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                        goto label_19;
                      }
                      finally
                      {
                        enumerator2.Dispose();
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                        }
                      }
                    case 4:
                      goto label_6;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      if (((ILogger) ComponentManager.\u003C\u003Ec__DisplayClass109_0.gyj56p8gNVoCD1T1psyd()).IsDebugEnabled())
                        goto case 1;
                      else
                        goto label_5;
                    case 7:
                      goto label_31;
                    default:
                      enumerator2 = componentManager.shellComponents.GetEnumerator();
                      num3 = 3;
                      continue;
                  }
                }
label_5:
                num2 = 5;
              }
label_31:
              return;
label_6:
              try
              {
label_8:
                if (enumerator1.MoveNext())
                  goto label_10;
                else
                  goto label_9;
label_7:
                Type current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_27;
                    case 2:
                      goto label_10;
                    case 3:
                      ComponentManager componentManager2 = componentManager;
                      Type serviceType = current;
                      ContainerBuilder containerBuilder = containterBuilder1;
                      // ISSUE: reference to a compiler-generated field
                      Func<ServiceScope?, bool> func = ComponentManager.\u003C\u003Ec.\u003C\u003E9__109_2;
                      Func<ServiceScope?, bool> skipCondition;
                      if (func == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        ComponentManager.\u003C\u003Ec.\u003C\u003E9__109_2 = skipCondition = (Func<ServiceScope?, bool>) (scope => false);
                      }
                      else
                        goto label_36;
label_13:
                      componentManager2.ProcessService(serviceType, containerBuilder, skipCondition);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                      continue;
label_36:
                      skipCondition = func;
                      goto label_13;
                    default:
                      goto label_8;
                  }
                }
label_27:
                return;
label_9:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                goto label_7;
label_10:
                current = enumerator1.Current;
                num6 = 3;
                goto label_7;
              }
              finally
              {
                enumerator1.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 5:
            ComponentManager.JFluwafZICIrmHSYkAej((object) this.extensionPointTypesMapShell);
            num1 = 4;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>
    /// Обработать тип компонента и компонент (если не задан, создается новый)
    /// </summary>
    /// <param name="type">Тип компонента</param>
    /// <param name="instance">Компонент</param>
    /// <param name="serviceScopes"></param>
    public virtual void ProcessShellComponent(
      Type type,
      object instance,
      ContainerBuilder containerBuilder,
      params ServiceScope[] serviceScopes)
    {
      int num1 = 7;
      ComponentManager componentManager;
      Type type1;
      object instance1;
      ContainerBuilder containerBuilder1;
      ServiceScope[] serviceScopes1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            serviceScopes1 = serviceScopes;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 5 : 4;
            continue;
          case 2:
            type1 = type;
            num1 = 4;
            continue;
          case 3:
            containerBuilder1 = containerBuilder;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
            continue;
          case 4:
            instance1 = instance;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 3;
            continue;
          case 5:
            this.RunWithShellExtensionPointTypesMap((System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    componentManager.ProcessComponent(type1, instance1, containerBuilder1, componentManager.SkipByScopes(type1, serviceScopes1));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 6:
            componentManager = this;
            num1 = 2;
            continue;
          case 7:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 6 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:;
    }

    private Func<ServiceScope?, bool> SkipByScopes(Type type, ServiceScope[] serviceScopes) => (Func<ServiceScope?, bool>) (scope =>
    {
      if (!scope.HasValue || ((IEnumerable<ServiceScope>) serviceScopes).Contains<ServiceScope>(scope.Value))
        return false;
      if (ComponentManager.log.IsVerboseEnabled())
        ComponentManager.log.Verbose((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 538972549), (object) type, (object) scope));
      return true;
    });

    /// <summary>
    /// Обработать тип компонента и компонент (если не задан, создается новый)
    /// </summary>
    /// <param name="type">Тип компонента</param>
    /// <param name="instance">Компонент</param>
    /// <param name="skipCondition"></param>
    protected internal virtual void ProcessComponent(
      Type type,
      object instance,
      ContainerBuilder containerBuilder,
      Func<ServiceScope?, bool> skipCondition,
      bool assemblyDisabled = false)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633517449));
      if (this.registrationData.ComponentsTypesToIgnore.Any<Type>((Func<Type, bool>) (t => t.IsAssignableFrom(type))))
      {
        if (!ComponentManager.log.IsDebugEnabled())
          return;
        ComponentManager.log.DebugFormat(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1916942316)), (object) type.FullName);
      }
      else
      {
        if (ComponentManager.log.IsVerboseEnabled())
          ComponentManager.log.Verbose((object) (EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132718731)) + (object) type));
        ComponentAttribute attribute1 = AttributeHelper<ComponentAttribute>.GetAttribute(type, true);
        ComponentType itemComponentType = attribute1 != null ? attribute1.Type : ComponentType.All;
        Type[] interfaces = type.GetInterfaces();
        List<Type> source = new List<Type>();
        source.AddRange((IEnumerable<Type>) interfaces);
        source.AddRange(((IEnumerable<Type>) interfaces).Where<Type>((Func<Type, bool>) (@interface =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (ComponentManager.\u003C\u003Ec.wFbQvx8r0O8IbDdYCK68(@interface, (Type) null))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              case 2:
                goto label_6;
              case 3:
                goto label_7;
              default:
                if (!@interface.IsGenericType)
                {
                  num = 3;
                  continue;
                }
                goto label_6;
            }
          }
label_6:
          return !@interface.IsGenericTypeDefinition;
label_7:
          return false;
        })).Select<Type, Type>((Func<Type, Type>) (@interface => @interface.GetGenericTypeDefinition())));
        // ISSUE: object of a compiler-generated type is created
        List<\u003C\u003Ef__AnonymousType22<Type, ExtensionPointAttribute>> list1 = source.Select(ifc => new \u003C\u003Ef__AnonymousType22<Type, ExtensionPointAttribute>(ifc, AttributeHelper<ExtensionPointAttribute>.GetAttribute(ifc, true))).Where(v =>
        {
          if (v.ifc == TypeOf<IEventHandler>.Raw || v.attr != null && ((v.attr.Type & this.componentType) != (ComponentType) 0 || this.registrationData.ComponentsTypesToRegister.Contains(type) || this.registrationData.ExtensionPointsToRegister.Contains(v.ifc)))
          {
            if (assemblyDisabled)
            {
              ExtensionPointAttribute attr = v.attr;
              if ((attr != null ? (attr.ForceRegister ? 1 : 0) : 0) == 0)
                goto label_6;
            }
            return (itemComponentType & this.componentType) != (ComponentType) 0 || this.componentType == (ComponentType) 0;
          }
label_6:
          return false;
        }).ToList();
        List<ServiceScope> list2 = list1.Where(v => v.attr != null).Select(v => v.attr.ServiceScope).Distinct<ServiceScope>().ToList<ServiceScope>();
        if (list2.Count > 1)
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3665424), (object) type));
        ServiceScope scope = list2.Count == 0 ? ServiceScope.Application : list2[0];
        if (skipCondition(new ServiceScope?(scope)))
        {
          if (!ComponentManager.log.IsDebugEnabled())
            return;
          ComponentManager.log.DebugFormat(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489065051)), (object) type.FullName, (object) list2);
        }
        else
        {
          List<Type> list3 = list1.Where(v =>
          {
            ExtensionPointAttribute attr = v.attr;
            return attr != null && !attr.CreateInstance;
          }).Select(v => v.ifc).ToList<Type>();
          if (list3.Count > 0)
          {
            list3.ForEach((Action<Type>) (ifc =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    this.AddToExtensionPointTypesMap(ifc, type);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            if (type.IsInterface && list3.Count == list1.Count)
              return;
          }
          if (type.IsInterface || list1.Count == 0)
            return;
          Type[] array = list1.Where(v =>
          {
            if (v.ifc == TypeOf<IEventHandler>.Raw)
              return true;
            return v.attr.CreateInstance && !TypeOf<IEventHandler>.Raw.IsAssignableFrom(v.ifc);
          }).Select(v => v.ifc).ToArray<Type>();
          if (instance == null && type.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length == 0)
          {
            if (ComponentManager.log.IsVerboseEnabled())
              ComponentManager.log.Verbose((object) (EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787129419)) + (object) type));
            instance = this.CreateComponent(type);
          }
          IRegistrationBuilder<object, IConcreteActivatorData, SingleRegistrationStyle> registrationBuilder;
          if (instance != null)
            registrationBuilder = (IRegistrationBuilder<object, IConcreteActivatorData, SingleRegistrationStyle>) containerBuilder.RegisterInstance<object>(instance).As(type);
          else
            registrationBuilder = (IRegistrationBuilder<object, IConcreteActivatorData, SingleRegistrationStyle>) containerBuilder.RegisterType(type).As(type);
          if (array.Length > 1 && ComponentManager.log.IsWarnEnabled())
            ComponentManager.log.Warn((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410863425), (object) type, (object) string.Join<Type>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629843680), ((IEnumerable<Type>) array).AsEnumerable<Type>())));
          else if (ComponentManager.log.IsVerboseEnabled())
            ComponentManager.log.Verbose((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643453351), (object) type, (object) string.Join<Type>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137459760), ((IEnumerable<Type>) array).AsEnumerable<Type>())));
          if (array.Length != 0)
          {
            registrationBuilder.As(array);
            registrationBuilder.SetScope<object, IConcreteActivatorData, SingleRegistrationStyle>(scope);
          }
          ComponentOrderAttribute attribute2 = AttributeHelper<ComponentOrderAttribute>.GetAttribute(type, true);
          int num1 = attribute2 != null ? attribute2.Order : (attribute1 != null ? attribute1.Order : 0);
          registrationBuilder.WithMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218155868), (object) num1);
          if (attribute1 == null)
            return;
          if (attribute1.InjectProerties)
            registrationBuilder.PropertiesAutowired<object, IConcreteActivatorData, SingleRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
          if (!attribute1.EnableInterceptors)
            return;
          this.SetupInterceptors(type, (IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>) registrationBuilder);
        }
      }
    }

    /// <summary>Добавить в карту загруженных типов компонентов</summary>
    /// <param name="interface">Интерфейс точки расширения</param>
    /// <param name="type">Тип компонента</param>
    public void AddToExtensionPointTypesMap(Type @interface, Type type)
    {
      int num = 8;
      List<Type> typeList1;
      List<Type> typeList2;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeList2 = typeList1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 4;
            continue;
          case 2:
            goto label_13;
          case 3:
            typeList1 = new List<Type>();
            num = 5;
            continue;
          case 5:
            this.extensionPointTypesMapToAdd.Add(@interface, typeList1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          case 6:
            if (this.extensionPointTypesMapToAdd.TryGetValue(@interface, out typeList2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 7:
            ((ILogger) ComponentManager.K3ITMvf8s05BklVvjDli()).DebugFormat((string) ComponentManager.oB6VAWfvjUcykXtDN2xn(ComponentManager.wCv31Xf8BDT6klkASJPg(1021410165 ^ 1021592421)), (object) type.FullName, (object) @interface.FullName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 5 : 6;
            continue;
          case 8:
            if (((ILogger) ComponentManager.K3ITMvf8s05BklVvjDli()).IsDebugEnabled())
            {
              num = 7;
              continue;
            }
            goto case 6;
          case 9:
            typeList2.Add(type);
            num = 2;
            continue;
          default:
            if (!typeList2.Contains(type))
            {
              num = 9;
              continue;
            }
            goto label_2;
        }
      }
label_13:
      return;
label_2:;
    }

    /// <summary>Найти сборку, загруженную в текущий домен</summary>
    /// <param name="name">Имя сборки</param>
    /// <param name="isFullName">True, если передно полное имя сборки</param>
    /// <returns>Если сборка не найдена - null</returns>
    public static Assembly FindLoadedAssembly(string name, bool isFullName)
    {
      int num1 = 10;
      Assembly loadedAssembly;
      while (true)
      {
        int num2 = num1;
        IDictionary<string, Assembly> dictionary1;
        IRemotingAssemblyResolverService service;
        string name1;
        while (true)
        {
          byte[] numArray;
          IDictionary<string, Assembly> dictionary2;
          switch (num2)
          {
            case 1:
              if (!ComponentManager.ak7x64f8MUeCSWUyQlu7())
              {
                num2 = 11;
                continue;
              }
              goto label_22;
            case 2:
            case 5:
            case 11:
            case 13:
              goto label_6;
            case 3:
              if (!ComponentManager.MLUjBmf8uveewmtmyNK1((object) loadedAssembly, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 2;
                continue;
              }
              goto case 1;
            case 4:
              goto label_22;
            case 6:
              loadedAssembly = (Assembly) ComponentManager.h2sQuRfZivgEJgC38bj4((object) numArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 5 : 7;
              continue;
            case 7:
              goto label_9;
            case 8:
              loadedAssembly = ((IEnumerable<Assembly>) ComponentManager.LkeEIWfZVP7QvxWcvsKs()).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if ((string) ComponentManager.\u003C\u003Ec__DisplayClass114_0.hIHhQF8glf7HbFcIBQCf((object) a) == name1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_4;
                    case 2:
                      goto label_4;
                    default:
                      goto label_5;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return ComponentManager.\u003C\u003Ec__DisplayClass114_0.aV76rt8gg0aento0VmPx(ComponentManager.\u003C\u003Ec__DisplayClass114_0.ykAPFt8grrIqO3n95xCW((object) a), (object) name1);
label_5:
                return true;
              }));
              num2 = 3;
              continue;
            case 9:
              name1 = name;
              num2 = 14;
              continue;
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 9 : 1;
              continue;
            case 12:
              dictionary2 = ComponentManager.assembliesByFullName;
              break;
            case 14:
              if (isFullName)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 12 : 12;
                continue;
              }
              goto case 18;
            case 15:
              if (numArray != null)
              {
                num2 = 6;
                continue;
              }
              goto label_9;
            case 16:
              if (service != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 17:
              if (dictionary1.TryGetValue(name1, out loadedAssembly))
              {
                num2 = 5;
                continue;
              }
              goto case 8;
            case 18:
              dictionary2 = ComponentManager.assembliesByName;
              break;
            default:
              numArray = (byte[]) ComponentManager.mEg1infZS0RErI5OokjW((object) service, (object) name1, isFullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 15 : 13;
              continue;
          }
          dictionary1 = dictionary2;
          num2 = 17;
        }
label_9:
        dictionary1[name1] = loadedAssembly;
        num1 = 13;
        continue;
label_22:
        service = Locator.GetService<IRemotingAssemblyResolverService>();
        num1 = 16;
      }
label_6:
      return loadedAssembly;
    }

    /// <summary>Получить короткое имя сборки (результат кэшируется)</summary>
    /// <param name="assembly"></param>
    /// <returns></returns>
    public static string GetAssemblyShortName(Assembly assembly)
    {
      int num = 2;
      string assemblyShortName;
      while (true)
      {
        AssemblyName assemblyName;
        object obj;
        switch (num)
        {
          case 1:
          case 4:
            goto label_6;
          case 2:
            if (ComponentManager.assemblyShortNames.TryGetValue(assembly, out assemblyShortName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            }
            goto case 6;
          case 3:
            obj = ComponentManager.T72yEwfZqbUN6aBPknoJ((object) assemblyName);
            break;
          case 5:
            ComponentManager.assemblyShortNames[assembly] = assemblyShortName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 4;
            continue;
          case 6:
            assemblyName = (AssemblyName) ComponentManager.ki2Ea2fZRqwm5SDipU0F((object) assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 7:
            obj = (object) string.Empty;
            break;
          default:
            if (assemblyName != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 3;
              continue;
            }
            goto case 7;
        }
        assemblyShortName = (string) obj;
        num = 5;
      }
label_6:
      return assemblyShortName;
    }

    /// <summary>Получить полное имя сборки (результат кэшируется)</summary>
    /// <param name="assembly"></param>
    /// <returns></returns>
    public static string GetAssemblyFullName(Assembly assembly)
    {
      int num = 1;
      string assemblyFullName;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ComponentManager.assemblyFullNames.TryGetValue(assembly, out assemblyFullName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_6;
          case 3:
            ComponentManager.assemblyFullNames[assembly] = assemblyFullName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 2;
            continue;
          default:
            assemblyFullName = (string) ComponentManager.s1RFq1fZopCWVkoKLgAB((object) assembly);
            num = 3;
            continue;
        }
      }
label_6:
      return assemblyFullName;
    }

    /// <summary>
    /// Получить расположение файла сборки (результат кэшируется)
    /// </summary>
    /// <param name="assembly"></param>
    /// <returns>Расположение файла сборки или Null</returns>
    public static string GetAssemblyLocation(Assembly assembly)
    {
      int num = 1;
      string assemblyLocation;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            if (ComponentManager.assemblyLocations.TryGetValue(assembly, out assemblyLocation))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 2:
            assemblyLocation = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 2;
            continue;
          case 3:
            ComponentManager.assemblyLocations[assembly] = assemblyLocation;
            num = 4;
            continue;
          case 5:
            obj = ComponentManager.WSLVaGfZXhjki7qCxyVW((object) assembly);
            break;
          case 6:
            if (ComponentManager.j71FQEfZTAOhcfmky4SR((object) assemblyLocation, (object) string.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 2;
              continue;
            }
            goto case 3;
          case 7:
            obj = (object) null;
            break;
          case 8:
            if (!ComponentManager.a3KxhFfZKhxKuAZ4h4ue((object) assembly))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 5;
              continue;
            }
            goto case 7;
          default:
            goto label_8;
        }
        assemblyLocation = (string) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 0;
      }
label_8:
      return assemblyLocation;
    }

    /// <summary>Ключ сборки (результат кэшируется)</summary>
    /// <param name="assembly"></param>
    /// <returns></returns>
    public static byte[] GetAssemblyPublicKey(Assembly assembly)
    {
      int num = 3;
      byte[] assemblyPublicKey;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentManager.assemblyPublicKeys[assembly] = assemblyPublicKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 0;
            continue;
          case 2:
          case 4:
            goto label_4;
          case 3:
            if (ComponentManager.assemblyPublicKeys.TryGetValue(assembly, out assemblyPublicKey))
            {
              num = 2;
              continue;
            }
            break;
        }
        assemblyPublicKey = (byte[]) ComponentManager.UdSXs0fZkr84fpcCDhpr(ComponentManager.ki2Ea2fZRqwm5SDipU0F((object) assembly));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
      }
label_4:
      return assemblyPublicKey;
    }

    /// <summary>Добавить сборку</summary>
    /// <param name="assembly">Сборка</param>
    protected void AddAssembly(Assembly assembly)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.registrationData.Assemblies.Contains(assembly))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            }
            break;
          case 3:
            goto label_3;
          case 4:
            ComponentManager.assembliesByName[ComponentManager.GetAssemblyShortName(assembly)] = assembly;
            num = 3;
            continue;
          case 5:
            goto label_2;
          case 6:
            ComponentManager.assembliesByFullName[ComponentManager.GetAssemblyFullName(assembly)] = assembly;
            num = 4;
            continue;
        }
        if (!this.processedAssemblies.Contains(assembly))
        {
          this.registrationData.Assemblies.Add(assembly);
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 6 : 2;
        }
        else
          num = 5;
      }
label_5:
      return;
label_3:
      return;
label_2:;
    }

    ~ComponentManager()
    {
      switch (1)
      {
        case 1:
          try
          {
            this.Dispose();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          finally
          {
            // ISSUE: explicit finalizer call
            base.Finalize();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    private static Assembly CurrentDomainAssemblyResolve(object sender, object args)
    {
      int num = 3;
      AssemblyName assemblyName;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            assemblyName = new AssemblyName((string) ComponentManager.cwFwi1fZne8Cb0Erc622(args));
            num = 7;
            continue;
          case 3:
            if (args != null)
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 4:
            if (ComponentManager.j71FQEfZTAOhcfmky4SR(ComponentManager.T72yEwfZqbUN6aBPknoJ((object) assemblyName), ComponentManager.wCv31Xf8BDT6klkASJPg(-345420348 ^ -345405630)))
            {
              num = 6;
              continue;
            }
            goto case 5;
          case 5:
            if (!((string) ComponentManager.T72yEwfZqbUN6aBPknoJ((object) assemblyName) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138159018)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
              continue;
            }
            goto label_3;
          case 6:
            goto label_3;
          case 7:
            if (!(assemblyName.Name == (string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1146510045 ^ -1146507449)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 4 : 2;
              continue;
            }
            goto label_3;
          default:
            goto label_8;
        }
      }
label_2:
      return ComponentManager.FindLoadedAssembly((string) ComponentManager.cwFwi1fZne8Cb0Erc622(args), true);
label_3:
      return (Assembly) ComponentManager.dGstXOf8bmTXQR0gWfP3(ComponentManager.T72yEwfZqbUN6aBPknoJ((object) assemblyName), false);
label_8:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410866893));
    }

    private static Assembly CurrentDomainReflectionOnlyAssemblyResolve(object sender, object args)
    {
      int num = 7;
      Assembly assembly;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_12;
          case 2:
            goto label_7;
          case 3:
            if (ComponentManager.RFH3yXf8G144TwqweIOi((object) assembly, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 4:
            if (!ComponentManager.GLLOL4f8PFRD0nvCwcOm(ComponentManager.WSLVaGfZXhjki7qCxyVW((object) assembly)))
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 5:
          case 8:
            goto label_6;
          case 6:
            assembly = (Assembly) ComponentManager.dGstXOf8bmTXQR0gWfP3(ComponentManager.cwFwi1fZne8Cb0Erc622(args), true);
            num = 3;
            continue;
          case 7:
            if (args != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 6;
              continue;
            }
            goto label_12;
          default:
            if (ComponentManager.a3KxhFfZKhxKuAZ4h4ue((object) assembly))
            {
              num = 5;
              continue;
            }
            goto case 4;
        }
      }
label_6:
      return (Assembly) null;
label_7:
      return (Assembly) ComponentManager.KT3enQfZOlQIWilQmmgb((object) assembly.Location);
label_12:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(132912447 ^ 132722081));
    }

    private static string[] GetAssembliesPathsWithArchitecture(object assembliesPaths)
    {
      int num = 1;
      string architecturePath;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            architecturePath = Environment.Is64BitProcess ? (string) ComponentManager.wCv31Xf8BDT6klkASJPg(1461825605 - 1531863589 ^ -70156594) : (string) ComponentManager.wCv31Xf8BDT6klkASJPg(825385222 ^ 825680280);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 0;
            continue;
        }
      }
label_3:
      return ((IEnumerable<string>) assembliesPaths).Union<string>(((IEnumerable<string>) assembliesPaths).Select<string, string>((Func<string, string>) (p => Path.Combine(p, architecturePath))).Where<string>(new Func<string, bool>(Directory.Exists))).ToArray<string>();
    }

    private IEnumerable<T> GetExtensionPointsInternal<T>()
    {
      Type type = typeof (T);
      if (!this.cacheEnabled)
        return this.GetExtensionPointsNonCached<T>();
      bool flag;
      if (!this.cacheAvailability.TryGetValue(type, out flag))
      {
        ExtensionPointAttribute attribute = AttributeHelper<ExtensionPointAttribute>.GetAttribute(type, true);
        flag = attribute != null && (attribute.ServiceScope == ServiceScope.Application || attribute.ServiceScope == ServiceScope.Shell);
        this.cacheAvailability[type] = flag;
      }
      object extensionPointsInternal;
      if (flag && this.cache.TryGetValue(type, out extensionPointsInternal))
        return (IEnumerable<T>) extensionPointsInternal;
      IEnumerable<T> extensionPointsNonCached = this.GetExtensionPointsNonCached<T>();
      if (flag)
        this.cache[type] = (object) extensionPointsNonCached;
      return extensionPointsNonCached;
    }

    private IEnumerable<T> GetExtensionPointsNonCached<T>()
    {
      if (this.stage != ComponentManager.LifetimeStage.Initializing && this.stage != ComponentManager.LifetimeStage.InitCompleting && this.stage != ComponentManager.LifetimeStage.Initialized)
        throw new InvalidOperationException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124316708)), (object) this.stage));
      return !this.CurrentScope().IsRegistered<T>() ? Enumerable.Empty<T>() : (IEnumerable<T>) this.CurrentScope().Resolve<IEnumerable<Meta<T>>>().Select(m =>
      {
        object obj;
        m.Metadata.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120969985), out obj);
        // ISSUE: object of a compiler-generated type is created
        return new \u003C\u003Ef__AnonymousType21<T, int>(m.Value, obj != null ? (int) obj : 0);
      }).OrderBy(v => v.order).Select(v => v.value).ToList<T>();
    }

    private IEnumerable<MethodInfo> GetIConfigurationServiceMethods(Type type)
    {
      List<Type> list = ((IEnumerable<Type>) type.GetInterfaces()).Where<Type>((Func<Type, bool>) (intf =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (ComponentManager.\u003C\u003Ec.wFbQvx8r0O8IbDdYCK68(intf, ComponentManager.\u003C\u003Ec.p0to0q8r4vDsnxUQjfRL(__typeref (IConfigurationService))))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: type reference
        // ISSUE: reference to a compiler-generated method
        return ComponentManager.\u003C\u003Ec.p0to0q8r4vDsnxUQjfRL(__typeref (IConfigurationService)).IsAssignableFrom(intf);
label_5:
        return false;
      })).ToList<Type>();
      if (!list.Any<Type>())
        return (IEnumerable<MethodInfo>) null;
      List<MethodInfo> iconfigurationServiceMethods = new List<MethodInfo>();
      foreach (Type type1 in list)
      {
        foreach (MethodInfo method1 in type1.GetMethods())
        {
          // ISSUE: reference to a compiler-generated method
          MethodInfo method2 = type.GetMethod(method1.Name, ((IEnumerable<ParameterInfo>) method1.GetParameters()).Select<ParameterInfo, Type>((Func<ParameterInfo, Type>) (p => ComponentManager.\u003C\u003Ec.iyQSkH8rm64EyWdRfKw1((object) p))).ToArray<Type>());
          if (method2 == (MethodInfo) null)
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418630932), (object) method1.Name, (object) type.FullName, (object) type1.Name));
          iconfigurationServiceMethods.Add(method2);
        }
      }
      return (IEnumerable<MethodInfo>) iconfigurationServiceMethods;
    }

    private Type GetMethodDeclaringType([NotNull] MethodInfo method)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!(method.DeclaringType != (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 5 : 5;
              continue;
            }
            break;
          case 3:
            if (!ComponentManager.EaXGAhfZ27BO3moDsl0f((object) method, (object) null))
            {
              num = 2;
              continue;
            }
            goto label_4;
          case 4:
          case 5:
            goto label_2;
          case 6:
            goto label_4;
        }
        if (ComponentManager.s7kgZTfZed9q3PbxsTJO((object) method).IsGenericType)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
        else
          break;
      }
label_2:
      return ComponentManager.s7kgZTfZed9q3PbxsTJO((object) method);
label_3:
      return ComponentManager.s7kgZTfZed9q3PbxsTJO((object) method).GetGenericTypeDefinition();
label_4:
      throw new ArgumentNullException((string) ComponentManager.wCv31Xf8BDT6klkASJPg(2045296739 + 1688595713 ^ -561008526));
    }

    private ILifetimeScope CurrentScope() => (ILifetimeScope) ComponentManager.o9fGesfZPJTsI4FiJANW((object) this.currentContainer.Resolve<ILifetimeScopeAccessor>());

    private void CheckLicensing()
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          List<string> list1;
          List<string> list2;
          string str1;
          string str2;
          switch (num2)
          {
            case 1:
            case 22:
              ComponentManager.bfD9WwfZp20hURxVIo4X((object) this.licenseManager);
              num2 = 13;
              continue;
            case 2:
              str1 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516841224), (IEnumerable<string>) list1);
              num2 = 18;
              continue;
            case 3:
              if (!this.initializeTerminatedByLicense)
              {
                num2 = 19;
                continue;
              }
              goto case 20;
            case 4:
              this.initializeTerminatedByLicense = true;
              num2 = 7;
              continue;
            case 5:
            case 15:
              IEnumerable<ILicensedUnit> source1 = this.moduleManager.MainApplication.SystemModules.OfType<ILicensedUnit>();
              // ISSUE: reference to a compiler-generated field
              Func<ILicensedUnit, ILicenseInfo> func1 = ComponentManager.\u003C\u003Ec.\u003C\u003E9__160_0;
              Func<ILicensedUnit, ILicenseInfo> selector;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ComponentManager.\u003C\u003Ec.\u003C\u003E9__160_0 = selector = (Func<ILicensedUnit, ILicenseInfo>) (module => (ILicenseInfo) ComponentManager.\u003C\u003Ec.wlPwbp8ryUFqlLqywFAA((object) module));
              }
              else
                goto label_32;
label_27:
              IEnumerable<ILicenseInfo> source2 = source1.Select<ILicensedUnit, ILicenseInfo>(selector);
              // ISSUE: reference to a compiler-generated field
              Func<ILicenseInfo, bool> func2 = ComponentManager.\u003C\u003Ec.\u003C\u003E9__160_1;
              Func<ILicenseInfo, bool> predicate;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ComponentManager.\u003C\u003Ec.\u003C\u003E9__160_1 = predicate = (Func<ILicenseInfo, bool>) (info =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        if (info != null)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return ComponentManager.\u003C\u003Ec.y3HbLV8rMMR5hx5U5egv((object) info) != 0;
label_5:
                  return false;
                });
              }
              else
                goto label_31;
label_30:
              this.initializeTerminatedByLicense = source2.Any<ILicenseInfo>(predicate);
              num2 = 3;
              continue;
label_31:
              predicate = func2;
              goto label_30;
label_32:
              selector = func1;
              goto label_27;
            case 6:
            case 16:
              if (this.moduleManager.MainApplication != null)
              {
                num2 = 15;
                continue;
              }
              break;
            case 7:
              str2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105198624), (IEnumerable<string>) list2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 14;
              continue;
            case 8:
              if (!list1.Any<string>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 22 : 10;
                continue;
              }
              goto label_5;
            case 9:
            case 19:
              if (this.initializeTerminatedByLicense)
              {
                num2 = 5;
                continue;
              }
              break;
            case 10:
              goto label_5;
            case 11:
              if (!list2.Any<string>())
              {
                num2 = 16;
                continue;
              }
              goto case 4;
            case 12:
              list2 = ((EleWise.ELMA.Modules.Impl.ModuleManager) this.moduleManager).GetMissedRequiredModules().ToList<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 10 : 11;
              continue;
            case 13:
              this.registrationData.DisabledAssemblies = this.registrationData.Assemblies.Where<Assembly>((Func<Assembly, bool>) (a => !ComponentManager.xjaheBfZarOXcEacQwjN((object) this.moduleManager, (object) a))).ToList<Assembly>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 15 : 17;
              continue;
            case 14:
              ComponentManager.pxQDF6fZNj7Cl6QyVQ9c(ComponentManager.wYY10Qf8YZfu2qyo2lEJ(), ComponentManager.Eei7MCfZ1JFfAnMoJy8e(ComponentManager.wCv31Xf8BDT6klkASJPg(-441065788 ^ -2092910478 ^ 1727028236), (object) str2));
              num2 = 6;
              continue;
            case 17:
              this.registrationData.Assemblies = this.registrationData.Assemblies.Where<Assembly>((Func<Assembly, bool>) (a => !this.registrationData.DisabledAssemblies.Contains(a))).ToList<Assembly>();
              num2 = 21;
              continue;
            case 18:
              ComponentManager.pxQDF6fZNj7Cl6QyVQ9c((object) Logger.Log, (object) ((string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1255365154 ^ 596875508 ^ -1766193164) + str1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
              continue;
            case 20:
              ComponentManager.OaDK0CfZ3xZxJHMK3TBT((object) this.startControl, StartStatus.NotActivated);
              num2 = 9;
              continue;
            case 21:
              goto label_28;
          }
          list1 = ((EleWise.ELMA.Modules.Impl.ModuleManager) this.moduleManager).GetDisableRequiredModules().ToList<string>();
          num2 = 8;
        }
label_5:
        this.initializeTerminatedByLicense = true;
        num1 = 2;
      }
label_28:;
    }

    static ComponentManager()
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ComponentManager.assembliesByName = (IDictionary<string, Assembly>) new ConcurrentDictionary<string, Assembly>();
              num2 = 8;
              continue;
            case 2:
              goto label_8;
            case 3:
              ComponentManager.assemblyRaws = PublishCacheContext.CreateCache<Assembly, MemoryStream>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 5 : 5;
              continue;
            case 4:
              ComponentManager.assemblyLocations = (IDictionary<Assembly, string>) new ConcurrentDictionary<Assembly, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 13;
              continue;
            case 5:
              ComponentManager.assemblyShortNames = (IDictionary<Assembly, string>) new ConcurrentDictionary<Assembly, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 10 : 8;
              continue;
            case 6:
              goto label_3;
            case 7:
              // ISSUE: type reference
              ComponentManager.typeInterceptors = new List<Tuple<Type, string, Type>>()
              {
                Tuple.Create<Type, string, Type>(typeof (CallSessionInterceptor), (string) ComponentManager.wCv31Xf8BDT6klkASJPg(1917998801 >> 2 ^ 479308174), ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (IConfigurationService)))
              };
              num2 = 9;
              continue;
            case 8:
              ComponentManager.assembliesByFullName = (IDictionary<string, Assembly>) new ConcurrentDictionary<string, Assembly>();
              num2 = 3;
              continue;
            case 9:
              // ISSUE: type reference
              ComponentManager.requiredInterceptors = new List<Tuple<Type, string>>()
              {
                Tuple.Create<Type, string>(ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (DiagnosticsInterceptor)), (string) ComponentManager.wCv31Xf8BDT6klkASJPg(-420743386 ^ -420558004))
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
            case 10:
              ComponentManager.assemblyFullNames = (IDictionary<Assembly, string>) new ConcurrentDictionary<Assembly, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 4 : 4;
              continue;
            case 11:
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: type reference
              ComponentManager.attributeMethodInterceptors = new List<Tuple<Type, string, Type>>()
              {
                Tuple.Create<Type, string, Type>(ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (TransactionInterceptor)), (string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1867198571 ^ -1867385667), typeof (TransactionAttribute)),
                Tuple.Create<Type, string, Type>(ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (ManagerActionsInterceptor)), (string) ComponentManager.wCv31Xf8BDT6klkASJPg(1232639661 >> 3 ^ 153758093), typeof (ActionImplAttribute)),
                Tuple.Create<Type, string, Type>(ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (AuditInterceptor)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239891972), typeof (AuditableAttribute)),
                Tuple.Create<Type, string, Type>(typeof (ContextCacheInterceptor), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69796673), typeof (ContextCacheAttribute)),
                Tuple.Create<Type, string, Type>(ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (CacheInterceptor)), (string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1255365154 ^ 596875508 ^ -1766193458), ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (CacheAttribute))),
                Tuple.Create<Type, string, Type>(ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (ComplexCacheInterceptor)), (string) ComponentManager.wCv31Xf8BDT6klkASJPg(-1445902765 ^ -1980277732 ^ 539174471), ComponentManager.fq0cNOf8iuVHvsiP5PGY(__typeref (ComplexCacheAttribute)))
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 3 : 7;
              continue;
            case 12:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num2 = 11;
              continue;
            case 13:
              ComponentManager.assemblyPublicKeys = (IDictionary<Assembly, byte[]>) new ConcurrentDictionary<Assembly, byte[]>();
              num2 = 2;
              continue;
            default:
              ComponentManager.interceptorNames = ComponentManager.attributeMethodInterceptors.Select<Tuple<Type, string, Type>, string>((Func<Tuple<Type, string, Type>, string>) (t => t.Item2)).Union<string>(ComponentManager.typeInterceptors.Select<Tuple<Type, string, Type>, string>((Func<Tuple<Type, string, Type>, string>) (t => t.Item2))).Union<string>(ComponentManager.requiredInterceptors.Select<Tuple<Type, string>, string>((Func<Tuple<Type, string>, string>) (t => t.Item2))).ToList<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
          }
        }
label_8:
        ComponentManager.assemblyIsModelResults = (IDictionary<Assembly, bool>) new ConcurrentDictionary<Assembly, bool>();
        num1 = 6;
      }
label_3:;
    }

    internal static object oB6VAWfvjUcykXtDN2xn([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool DfU7MqfvgnrTvlixFv2l() => ComponentManager.QJMBdufvrLQnbvJUYYZb == null;

    internal static ComponentManager OrtUyJfv5EsrNuDXPo3c() => ComponentManager.QJMBdufvrLQnbvJUYYZb;

    internal static object rmS4nRfvYnQowt8RKw6Y([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object ajNSXxfvLetrW0lfpyqb([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((MemoryStream) obj0, (MemoryStream) obj1);

    internal static bool fCv9KKfvUqj26fb31diw([In] object obj0) => File.Exists((string) obj0);

    internal static long nqrMNBfvsYqLRb8dCEKG([In] object obj0) => ((Stream) obj0).Length;

    internal static void SK5GEgfvc1bJ2EjpDtgL([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static long sLdQBBfvzH8cyZvmUkMb([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void GZq6Oaf8FISSCf4iMf0C([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object wCv31Xf8BDT6klkASJPg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xFOOAUf8WGtTJQHqHNVa([In] object obj0, [In] object obj1) => (object) Path.ChangeExtension((string) obj0, (string) obj1);

    internal static object FoVNpRf8oMBqyZSXryE6(int requiredSize) => (object) MemoryHelper.GetMemoryStream(requiredSize);

    internal static object dGstXOf8bmTXQR0gWfP3([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static object PMS0jff8hmwqAq23WOsK([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((byte[]) obj0, (byte[]) obj1);

    internal static bool RFH3yXf8G144TwqweIOi([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

    internal static object OLJy54f8ET3bhgMLXCAm([In] object obj0) => (object) EntityDynamicGenerator.CheckAssembly((MemoryStream) obj0);

    internal static object jWxwSbf8fSObbiwFJuE8([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static object RkCv57f8QQLg0Cwd5X11([In] object obj0, [In] object obj1) => (object) Assembly.Load((byte[]) obj0, (byte[]) obj1);

    internal static object kaxDhff8CmFtTDwlJshq([In] object obj0) => (object) ((MemoryStream) obj0).AsReadOnly();

    internal static object x64lvJf8v6CF4oxdDeL5([In] object obj0) => (object) ComponentManager.GetAssemblyFullName((Assembly) obj0);

    internal static object n9g3yIf88CaM0X95aYoX([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static object nPjKSNf8ZLZ15ThUoVfp([In] object obj0) => (object) ComponentManager.GetLoadedAssemblyRawAsStream((Assembly) obj0);

    internal static bool MLUjBmf8uveewmtmyNK1([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object T4L9EQf8IXdhwhUHsXDu() => (object) AppDomain.CurrentDomain;

    internal static object v5Q9sxf8V01q5Iw9Niyo([In] object obj0) => (object) ComponentManager.GetAssemblies((AppDomain) obj0);

    internal static object zdh7Gvf8SStPvj8tRfiU([In] object obj0) => (object) ((AppDomain) obj0).GetAssemblies();

    internal static Type fq0cNOf8iuVHvsiP5PGY([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool QW7fFif8RUT9OOfShLAn([In] object obj0, [In] Type obj1, [In] bool obj2) => ((Assembly) obj0).IsDefined(obj1, obj2);

    internal static object UHpgitf8qjb4qfO8dayD() => (object) ComponentManager.Current;

    internal static void q9Em1cf8KGVrygmCgNB8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void MDhNfRf8XTOyqDV7LOcj([In] object obj0, [In] object obj1) => ((AppDomain) obj0).AssemblyResolve += (ResolveEventHandler) obj1;

    internal static void zNG16vf8TI2LJqYeDHPf([In] object obj0, [In] object obj1) => ((AppDomain) obj0).ReflectionOnlyAssemblyResolve += (ResolveEventHandler) obj1;

    internal static void Tv4ncrf8kNlRhOhmeKEG([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object pg5KxNf8n9c69kdxEpZb([In] object obj0) => (object) ComponentManager.GetAssembliesPathsWithArchitecture(obj0);

    internal static object zCdDexf8Ov8Ow1CLnVht([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object OB3ZKXf82AiHB1c8go0f(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static object Ywh3E7f8esDbbESNlstN([In] object obj0) => (object) ((PackageService) obj0).ComponentName;

    internal static bool GLLOL4f8PFRD0nvCwcOm([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void HBYsiLf81Ud8SNSZpPdy([In] object obj0) => ((PackageService) obj0).Initialize();

    internal static void zaKxIrf8NQ2IJrNHDgOr([In] object obj0) => ((EleWise.ELMA.Licensing.Impl.LicenseManager) obj0).ApplyAllActivationKeys();

    internal static void gU1fdof83wfgD06oHiei([In] object obj0) => ((ComponentManager) obj0).Init();

    internal static void r87KH2f8pPCgu5NM7KpL([In] object obj0, [In] object obj1) => ((ContainerBuilder) obj0).Update((IContainer) obj1);

    internal static void gy6LMvf8aAA8sK6LetIh([In] object obj0) => ((ConcurrentDictionary<Type, object>) obj0).Clear();

    internal static void O8pAoYf8D1FNnpmN6Lde([In] object obj0, [In] object obj1) => ((AppDomain) obj0).AssemblyResolve -= (ResolveEventHandler) obj1;

    internal static void cUPMLcf8t8o2OHJEXnGT([In] object obj0, bool disposing) => ((ComponentManager) obj0).Dispose(disposing);

    internal static void QuZb1gf8wZgJPPqATKGy([In] object obj0, [In] object obj1) => ((IStartInformation) obj0).SetInfo((string) obj1);

    internal static void xbaUumf84xps0wdtJv35([In] object obj0) => ((IRuntimeApplication) obj0).OnApplicationStarting();

    internal static object iCXEMjf86FkZ4CMmCrMa([In] object obj0) => (object) ((IRuntimeApplication) obj0).ApplicationStartCache;

    internal static void obs47Ef8HCmXygAAEXBM([In] object obj0) => ((ComponentManager) obj0).RegisterAutofacInterceptors();

    internal static void vHp45Ff8AxB2Ll7CoFDt([In] object obj0) => ((ComponentManager) obj0).RegisterAutofacModules();

    internal static object AvZseCf87nQFXfGZQCuK() => (object) StartInformation.Current;

    internal static object LZ008Nf8xmu585fmbT9g([In] object obj0) => (object) ((IStartInformation) obj0).Message;

    internal static object i5KsxUf80NLvuC9y1TJH([In] object obj0) => (object) ((IRuntimeApplication) obj0).DbPreUpdater;

    internal static void BTftcJf8mQJ0fJiLolaw([In] object obj0, [In] object obj1) => ((ComponentManager) obj0).RegisterData((ComponentManager.RegistrationData) obj1);

    internal static void S2Tp5lf8yImDLkmk4tjl([In] object obj0, double value) => ((IStartInformation) obj0).Percent = value;

    internal static bool ak7x64f8MUeCSWUyQlu7() => Locator.Initialized;

    internal static object zZxacwf8JxHmadkXTyJS([In] object obj0, [In] ContainerBuildOptions obj1) => (object) ((ContainerBuilder) obj0).Build(obj1);

    internal static void dKon21f89ADKk47U06VN([In] object obj0) => Locator.SetImpl((ILocatorImpl) obj0);

    internal static void m7QHUtf8dZ9i8Ndx3bXb([In] object obj0, [In] object obj1) => ((ComponentManager) obj0).ProcessComponent(obj1);

    internal static object P7ty2Tf8ljIjsQ73A092([In] object obj0, [In] object obj1) => (object) ((ContainerBuilder) obj0).RegisterModule((Autofac.Core.IModule) obj1);

    internal static object RpN0Cif8rMl36lDkbCPb([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static object xhDBvwf8giCa1LwM4d84([In] object obj0) => (object) Assembly.LoadFrom((string) obj0);

    internal static object qZRn8xf85fbF35GLkVx7([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    internal static object BBH6ZXf8jMvCBLNJBUG0([In] object obj0, [In] object obj1) => (object) ((AppDomain) obj0).Load((byte[]) obj1);

    internal static object wYY10Qf8YZfu2qyo2lEJ() => (object) Logger.Log;

    internal static void yVWEs6f8L7ZQtBtryb75([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static bool pMYTqhf8UFUy6jrJ5ODO([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object K3ITMvf8s05BklVvjDli() => (object) ComponentManager.log;

    internal static void LB0mCcf8cq99ok71aam0([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object fwAmGgf8zofGfRgrkkHS([In] object obj0, [In] object obj1) => (object) ((ApplicationStartCache) obj0).GetAssemblyInfo((Assembly) obj1);

    internal static bool ccwPrsfZFfxGqf7KjX5X([In] object obj0, [In] object obj1) => ((ComponentManager) obj0).IsComponentAssembly((Assembly) obj1);

    internal static object VSD4gpfZBv3GyDn7IbhH([In] object obj0) => (object) ((ReflectionTypeLoadException) obj0).LoaderExceptions;

    internal static object E1nOPTfZWFcbapix9WGp([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object s1RFq1fZopCWVkoKLgAB([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static object jMRKQmfZb6NgS6ZwZvMi(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static bool mex9u6fZhL1d3Aq3MgS0([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object ah0QgIfZG8YS1QTM2hsV([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool Q1IZdBfZEF00fCvibT7o([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool ErSpsGfZfEQpWCmqJs9J([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool TieWjafZQfkqmZD9ZTHY([In] object obj0, Type type) => ((ComponentManager) obj0).IsComponentType(type);

    internal static object caqunGfZCSCVAp24EyF5([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static Type NAKZrlfZvugthLE49hhX([In] object obj0) => ((ImplementAttribute) obj0).InterfaceType;

    internal static bool QoPPLJfZ8RCjmLbtMORD([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

    internal static object uquioYfZZPrSnh2AyBLt([In] Type obj0, [In] bool obj1) => Activator.CreateInstance(obj0, obj1);

    internal static void lLPXDTfZulS9hZZw80iO([In] object obj0) => ((System.Action) obj0)();

    internal static void JFluwafZICIrmHSYkAej([In] object obj0) => ((Dictionary<Type, List<Type>>) obj0).Clear();

    internal static object LkeEIWfZVP7QvxWcvsKs() => (object) ComponentManager.GetAssemblies();

    internal static object mEg1infZS0RErI5OokjW([In] object obj0, [In] object obj1, bool isFullName) => (object) ((IRemotingAssemblyResolverService) obj0).ResolveAssembly((string) obj1, isFullName);

    internal static object h2sQuRfZivgEJgC38bj4([In] object obj0) => (object) ComponentManager.LoadAssembly((byte[]) obj0);

    internal static object ki2Ea2fZRqwm5SDipU0F([In] object obj0) => (object) ((Assembly) obj0).GetName();

    internal static object T72yEwfZqbUN6aBPknoJ([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static bool a3KxhFfZKhxKuAZ4h4ue([In] object obj0) => ((Assembly) obj0).IsDynamic;

    internal static object WSLVaGfZXhjki7qCxyVW([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static bool j71FQEfZTAOhcfmky4SR([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object UdSXs0fZkr84fpcCDhpr([In] object obj0) => (object) ((AssemblyName) obj0).GetPublicKey();

    internal static object cwFwi1fZne8Cb0Erc622([In] object obj0) => (object) ((ResolveEventArgs) obj0).Name;

    internal static object KT3enQfZOlQIWilQmmgb([In] object obj0) => (object) Assembly.ReflectionOnlyLoadFrom((string) obj0);

    internal static bool EaXGAhfZ27BO3moDsl0f([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static Type s7kgZTfZed9q3PbxsTJO([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object o9fGesfZPJTsI4FiJANW([In] object obj0) => (object) ((ILifetimeScopeAccessor) obj0).Current;

    internal static object Eei7MCfZ1JFfAnMoJy8e([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void pxQDF6fZNj7Cl6QyVQ9c([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static void OaDK0CfZ3xZxJHMK3TBT([In] object obj0, StartStatus suspendReason) => ((IStartControl) obj0).Suspend(suspendReason);

    internal static void bfD9WwfZp20hURxVIo4X([In] object obj0) => ((EleWise.ELMA.Licensing.Impl.LicenseManager) obj0).CompleteLicensingInitialize();

    internal static bool xjaheBfZarOXcEacQwjN([In] object obj0, [In] object obj1) => ((IModuleManager) obj0).IsAssemblyAvailable((Assembly) obj1);

    /// <summary>Данные для регистрации</summary>
    protected internal class RegistrationData
    {
      /// <summary>Список сборок для регистрации</summary>
      public List<Assembly> Assemblies;
      /// <summary>
      /// Список отключенных сборок (для них регистрируются только компоненты с точками расширений, у которых ForceRegister=true
      /// </summary>
      public List<Assembly> DisabledAssemblies;
      /// <summary>
      /// Список существующих компонентов, которые нужно загрузить
      /// </summary>
      public readonly List<object> ComponentsToRegister;
      /// <summary>
      /// Список типов компонентов, которые нужно пропустить при регистрации
      /// </summary>
      public readonly List<Type> ComponentsTypesToIgnore;
      /// <summary>
      /// Список типов компонентов, которые нужно учитывать при регистрации
      /// </summary>
      public readonly List<Type> ComponentsTypesToRegister;
      /// <summary>
      /// Список точек расширений, которые нужно учитывать при регистрации
      /// </summary>
      public readonly List<Type> ExtensionPointsToRegister;
      /// <summary>
      /// Список типов сервисов, которые нужно учитывать при регистрации
      /// </summary>
      public readonly List<Type> ServiceTypesToRegister;
      internal static ComponentManager.RegistrationData N4LL1D8re4aLINfWcO1S;

      public RegistrationData()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.Assemblies = new List<Assembly>();
        this.DisabledAssemblies = new List<Assembly>();
        this.ComponentsToRegister = new List<object>();
        this.ComponentsTypesToIgnore = new List<Type>();
        this.ComponentsTypesToRegister = new List<Type>();
        this.ExtensionPointsToRegister = new List<Type>();
        this.ServiceTypesToRegister = new List<Type>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool DMBKVc8rPugLrsgjIwmd() => ComponentManager.RegistrationData.N4LL1D8re4aLINfWcO1S == null;

      internal static ComponentManager.RegistrationData BhT4xs8r1tZyTkbJSUcS() => ComponentManager.RegistrationData.N4LL1D8re4aLINfWcO1S;
    }

    /// <summary>Этап жизненного цикла</summary>
    public enum LifetimeStage
    {
      /// <summary>До начала инициализации</summary>
      BeforeInit,
      /// <summary>В момент вызова IInitHandler.Init</summary>
      Initializing,
      /// <summary>В момент вызова IInitHandler.InitComplete</summary>
      InitCompleting,
      /// <summary>После инициализации</summary>
      Initialized,
      /// <summary>Уничтожен</summary>
      Disposed,
    }
  }
}
