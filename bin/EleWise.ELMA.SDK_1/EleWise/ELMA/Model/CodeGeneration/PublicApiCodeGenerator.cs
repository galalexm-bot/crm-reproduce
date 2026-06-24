// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.PublicApiCodeGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace EleWise.ELMA.Model.CodeGeneration
{
  public sealed class PublicApiCodeGenerator
  {
    private readonly IEnumerable<Type> autoImplementInterfaces;
    private readonly IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders;
    private readonly ISet<Guid> usesMetadata;
    private readonly HashSet<string> usedKeys;
    private readonly Dictionary<string, List<string>> propertyClassNodes;
    private readonly Dictionary<string, Pair<List<string>, List<string>>> propertyPropertyNodes;
    private bool useHiddenProperty;
    private ISet<Guid> configurationModelUids;
    private readonly ISet<Guid> metadataUids;
    private static readonly AsyncLocal<bool> NoImplementationLocal;
    private ILogger logger;
    private static PublicApiCodeGenerator OZNeUJhNWWVQ07usg7qD;

    /// <summary>Ctor</summary>
    /// <param name="autoImplementInterfaces">Список автореализуемых типов</param>
    /// <param name="metadataList">Список метаданных</param>
    /// <param name="configurationMetadataList">Список метаданных конфигурации</param>
    /// <param name="publicApiNodeProviders">Провайдеры узлов PublicAPI</param>
    public PublicApiCodeGenerator(
      IEnumerable<Type> autoImplementInterfaces,
      IEnumerable<IMetadata> metadataList,
      IEnumerable<IMetadata> configurationMetadataList,
      IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.usesMetadata = (ISet<Guid>) new HashSet<Guid>();
      this.usedKeys = new HashSet<string>();
      this.propertyClassNodes = new Dictionary<string, List<string>>();
      this.propertyPropertyNodes = new Dictionary<string, Pair<List<string>, List<string>>>();
      this.logger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426266557));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.autoImplementInterfaces = autoImplementInterfaces;
      this.metadataUids = metadataList != null ? (ISet<Guid>) metadataList.Select<IMetadata, Guid>((Func<IMetadata, Guid>) (m => m.Uid)).ToHashSet<Guid>() : (ISet<Guid>) null;
      // ISSUE: reference to a compiler-generated method
      this.configurationModelUids = configurationMetadataList != null ? (ISet<Guid>) configurationMetadataList.Select<IMetadata, Guid>((Func<IMetadata, Guid>) (m => PublicApiCodeGenerator.\u003C\u003Ec.sacTIOvIdlMU1K1Gm5Dv((object) m))).ToHashSet<Guid>() : (ISet<Guid>) null;
      this.publicApiNodeProviders = this.metadataUids == null ? publicApiNodeProviders : publicApiNodeProviders.Where<IPublicApiNodeProvider>((Func<IPublicApiNodeProvider, bool>) (p => !(p is PublicApiCustomMethodsNodeProvider)));
    }

    public static PublicApiCodeGenerator Current
    {
      get => PublicApiCodeGenerator.cC7k86hNGKFZvmQ4xsYF(PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(1461625753 ^ 1461568045)) as PublicApiCodeGenerator;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              PublicApiCodeGenerator.lyPyuDhNExCOlSlSdpjN(PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-345420348 ^ -345363344), (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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

    /// <summary>
    /// Флаг генерации реализаций Public API для текущей сессии. Использует контекст
    /// </summary>
    public static bool PublicApiNoImplementation
    {
      get => PublicApiCodeGenerator.NoImplementationLocal.Value;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              PublicApiCodeGenerator.NoImplementationLocal.Value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    /// <summary>Контекст генерации Public API без реализации</summary>
    /// <example>
    /// Пример использования
    /// <code>
    /// using (PublicApiCodeGenerator.NoImplementContext) { }
    /// </code>
    /// </example>
    internal static IDisposable NoImplementContext => (IDisposable) new PublicApiCodeGenerator.PublicApiNoImplementContext();

    /// <summary>Получить объект метаданных по Uid-у</summary>
    /// <param name="metadataUid">Uid объекта метаданных</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = false) => ((IMetadataService) PublicApiCodeGenerator.BH0m6shNfFlv57XE1Zb9()).GetMetadata(metadataUid, loadImplementation);

    /// <summary>Получить список метаданных</summary>
    /// <returns>Список метаданных</returns>
    public IEnumerable<IMetadata> GetAllMetadata() => MetadataServiceContext.Service.GetMetadataList();

    /// <summary>
    /// Получить список метаданных сущностей (только метаданные классов)
    /// </summary>
    /// <returns>Список метаданных сущностей</returns>
    public IEnumerable<EntityMetadata> GetEntityMetadataList() => this.GetAllMetadata().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => !PublicApiCodeGenerator.\u003C\u003Ec.hxfgxvvIlvpA3jIm7nBK((object) m)));

    /// <summary>Получить тип по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <returns>Тип. Если не найден, вызывается исключение.</returns>
    public Type GetTypeByUid(Guid uid) => ((IMetadataRuntimeService) PublicApiCodeGenerator.DsLMe6hNQNxR3lWCmBbQ()).GetTypeByUid(uid, false);

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="md">Метаданные</param>
    /// <returns>true, если метаданные системные</returns>
    public bool IsSystem(IMetadata md)
    {
      int num = 10;
      AssemblyModelsMetadata assemblyModelsMetadata;
      while (true)
      {
        switch (num)
        {
          case 2:
            this.configurationModelUids = (ISet<Guid>) new HashSet<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 3 : 0;
            continue;
          case 4:
            if (assemblyModelsMetadata == null)
            {
              num = 2;
              continue;
            }
            goto case 6;
          case 5:
            if (this.configurationModelUids != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
              continue;
            }
            goto case 8;
          case 6:
            // ISSUE: reference to a compiler-generated method
            this.configurationModelUids = (ISet<Guid>) ((IEnumerable<AbstractMetadata>) assemblyModelsMetadata.RestoreMetadata()).Select<AbstractMetadata, Guid>((Func<AbstractMetadata, Guid>) (m => PublicApiCodeGenerator.\u003C\u003Ec.mO32LcvI5oPDOfB20Vlc((object) m))).ToHashSet<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 7:
            md = this.GetMetadata(entityMetadata.ImplementationUid);
            num = 5;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            assemblyModelsMetadata = ((IMetadataRuntimeService) PublicApiCodeGenerator.DsLMe6hNQNxR3lWCmBbQ()).GetAssemblyModelsMetadataList().FirstOrDefault<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (m => PublicApiCodeGenerator.\u003C\u003Ec.nTi1uCvIg8NU4PWDL09T((object) m.Name, PublicApiCodeGenerator.\u003C\u003Ec.u6UI90vIrxk8y9CDsreD(-688192331 - 435440695 ^ -1123634662))));
            num = 4;
            continue;
          case 9:
            if (PublicApiCodeGenerator.vVOOTihNCXmfARUgr6rL((object) entityMetadata) == EntityMetadataType.InterfaceImplementation)
            {
              num = 7;
              continue;
            }
            goto case 5;
          case 10:
            if (md is EntityMetadata entityMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 9;
              continue;
            }
            goto case 5;
          default:
            goto label_5;
        }
      }
label_5:
      return !this.configurationModelUids.Contains(PublicApiCodeGenerator.ub876yhNv0GKVckSH2di((object) md));
    }

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid) => (ITypeDescriptor) PublicApiCodeGenerator.myFpSihN8KNWU49CwwK2(PublicApiCodeGenerator.BH0m6shNfFlv57XE1Zb9(), typeUid, subTypeUid);

    /// <summary>
    /// Получить описание типа данных, который можно использовать для первичного ключа, по его уникальному идентфикатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid) => (ITypeDescriptor) PublicApiCodeGenerator.Aroj1PhNZCZAcYECE6ND(PublicApiCodeGenerator.BH0m6shNfFlv57XE1Zb9(), typeUid);

    /// <summary>
    /// Сгенерировать код с реализацией интерфейса и расширений интерфейсов
    /// </summary>
    /// <returns></returns>
    public string GenerateCode()
    {
      int num1 = 1;
      PublicApiCodeGenerator apiCodeGenerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            apiCodeGenerator = (PublicApiCodeGenerator) PublicApiCodeGenerator.SqrjD7hNuhuOiZ2dYbS6();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      string csCodeString;
      return csCodeString;
label_5:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        PublicApiCodeGenerator.\u003C\u003Ec__DisplayClass29_0 cDisplayClass290 = new PublicApiCodeGenerator.\u003C\u003Ec__DisplayClass29_0();
        int num2 = 13;
        while (true)
        {
          int num3 = num2;
          Dictionary<Guid, Guid> dictionary;
          IEnumerator<Guid> enumerator;
          // ISSUE: variable of a compiler-generated type
          PublicApiCodeGenerator.\u003C\u003Ec__DisplayClass29_1 cDisplayClass291;
          while (true)
          {
            switch (num3)
            {
              case 1:
label_29:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                cDisplayClass291.CS\u0024\u003C\u003E8__locals1.nodes = cDisplayClass291.CS\u0024\u003C\u003E8__locals1.nodes.Where<IPublicApiNode>(new Func<IPublicApiNode, bool>(cDisplayClass291.\u003CGenerateCode\u003Eb__4));
                num3 = 12;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass290.nodes = ((IEnumerable<IPublicApiNode>) this.publicApiNodeProviders.SelectMany<IPublicApiNodeProvider, IPublicApiNode>((Func<IPublicApiNodeProvider, IEnumerable<IPublicApiNode>>) (p => p.CreatePublicApiNodes())).ToArray<IPublicApiNode>()).AsEnumerable<IPublicApiNode>();
                num3 = 15;
                continue;
              case 3:
                if (this.metadataUids == null)
                {
                  num3 = 14;
                  continue;
                }
                goto case 5;
              case 4:
                this.logger.Info(PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-2138160520 ^ -2138234818));
                num3 = 2;
                continue;
              case 5:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass291 = new PublicApiCodeGenerator.\u003C\u003Ec__DisplayClass29_1();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 7;
                continue;
              case 6:
                enumerator = this.metadataUids.GetEnumerator();
                num3 = 17;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass291.CS\u0024\u003C\u003E8__locals1 = cDisplayClass290;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              case 8:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                csCodeString = Enumerable.Repeat<ISyntaxNode>(cDisplayClass290.nodes.OfType<PublicApiRootNode>().Single<PublicApiRootNode>().Generate((IDictionary<string, IEnumerable<IPublicApiNode>>) cDisplayClass290.tree), 1).If<ISyntaxNode>(this.metadataUids == null, new Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>(cDisplayClass290.\u003CGenerateCode\u003Eb__1)).GenerateCSCodeString();
                num3 = 9;
                continue;
              case 9:
                goto label_3;
              case 10:
                PublicApiCodeGenerator.AVwoyhhNILn5A5sMhG6X((object) this.logger, PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-477139494 ^ -477360172));
                num3 = 11;
                continue;
              case 11:
                PublicApiCodeGenerator.KlHsbThNVkYCp0kh4xlX((object) this);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 4;
                continue;
              case 12:
              case 14:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass290.tree = new PublicApiCodeGenerator.PublicApiNodeDictionary(cDisplayClass290.nodes);
                num3 = 18;
                continue;
              case 13:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass290.\u003C\u003E4__this = this;
                num3 = 10;
                continue;
              case 15:
                goto label_39;
              case 16:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass291.metadataBaseUids = new HashSet<Guid>();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 6 : 1;
                continue;
              case 17:
                try
                {
label_12:
                  if (enumerator.MoveNext())
                    goto label_18;
                  else
                    goto label_13;
label_10:
                  Guid current;
                  int num4;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                      case 6:
                        if (PublicApiCodeGenerator.G8VbtlhNSbr077KuZUB9(current, Guid.Empty))
                        {
                          num4 = 7;
                          continue;
                        }
                        goto label_12;
                      case 2:
                        goto label_29;
                      case 3:
                        goto label_12;
                      case 4:
                        goto label_18;
                      case 7:
                        // ISSUE: reference to a compiler-generated field
                        if (cDisplayClass291.metadataBaseUids.Add(current))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 5;
                          continue;
                        }
                        goto label_12;
                      default:
                        current = dictionary[current];
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
                        continue;
                    }
                  }
label_13:
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 2;
                  goto label_10;
label_18:
                  current = enumerator.Current;
                  num4 = 6;
                  goto label_10;
                }
                finally
                {
                  int num5;
                  if (enumerator == null)
                    num5 = 2;
                  else
                    goto label_22;
label_21:
                  switch (num5)
                  {
                    case 1:
                      break;
                    default:
                  }
label_22:
                  PublicApiCodeGenerator.FDhfFFhNiIsVKXgORpHB((object) enumerator);
                  num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                  {
                    num5 = 0;
                    goto label_21;
                  }
                  else
                    goto label_21;
                }
              case 18:
                PublicApiCodeGenerator.AVwoyhhNILn5A5sMhG6X((object) this.logger, PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-787452571 ^ -787279913));
                num3 = 8;
                continue;
              default:
                IEnumerable<IMetadata> allMetadata = this.GetAllMetadata();
                // ISSUE: reference to a compiler-generated field
                Func<IMetadata, Guid> func = PublicApiCodeGenerator.\u003C\u003Ec.\u003C\u003E9__29_3;
                Func<IMetadata, Guid> elementSelector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  PublicApiCodeGenerator.\u003C\u003Ec.\u003C\u003E9__29_3 = elementSelector = (Func<IMetadata, Guid>) (m =>
                  {
                    int num6 = 1;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 1:
                          if (!(m is ClassMetadata classMetadata2))
                          {
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_5;
                        default:
                          goto label_4;
                      }
                    }
label_4:
                    return Guid.Empty;
label_5:
                    // ISSUE: reference to a compiler-generated method
                    return PublicApiCodeGenerator.\u003C\u003Ec.enT3Y1vIjdE54pfWy23s((object) classMetadata2);
                  });
                }
                else
                  goto label_2;
label_43:
                // ISSUE: reference to a compiler-generated method
                dictionary = allMetadata.ToDictionary<IMetadata, Guid, Guid>((Func<IMetadata, Guid>) (m => PublicApiCodeGenerator.\u003C\u003Ec.sacTIOvIdlMU1K1Gm5Dv((object) m)), elementSelector);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 9 : 16;
                continue;
label_2:
                elementSelector = func;
                goto label_43;
            }
          }
label_39:
          PublicApiCodeGenerator.AVwoyhhNILn5A5sMhG6X((object) this.logger, PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(1470998129 - 231418599 ^ 1239489012));
          num2 = 3;
        }
      }
      catch (Exception ex)
      {
        int num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
          num7 = 1;
        while (true)
        {
          switch (num7)
          {
            case 1:
              PublicApiCodeGenerator.PMQM7yhNqyOgjMcDk9dB((object) this.logger, PublicApiCodeGenerator.QurexIhNRsJG8iHUdtYW((object) ex), (object) ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            default:
              goto label_48;
          }
        }
label_48:
        throw new CodeGenerationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536713908)), ex);
      }
      finally
      {
        PublicApiCodeGenerator.AVwoyhhNILn5A5sMhG6X((object) this.logger, PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-606654180 ^ -606842308));
        int num8 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
          num8 = 2;
        while (true)
        {
          switch (num8)
          {
            case 1:
              PublicApiCodeGenerator.AVwoyhhNILn5A5sMhG6X((object) this.logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70242968));
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            case 2:
              PublicApiCodeGenerator.KlHsbThNVkYCp0kh4xlX((object) apiCodeGenerator);
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            default:
              goto label_54;
          }
        }
label_54:;
      }
    }

    public bool IsSystemObjects(EntityMetadata metadata)
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
              goto label_10;
            case 2:
              if (!(PublicApiCodeGenerator.dNPMpihNXv6NLXsksFmv((object) metadata) != new Guid((string) PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-812025778 ^ -811983994))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 5;
                continue;
              }
              goto case 9;
            case 3:
              if (PublicApiCodeGenerator.NtlHibhNTsHTGG8iLSms((object) metadata.FullTypeName, PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-1872275253 >> 6 ^ -29165193)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 8;
                continue;
              }
              goto label_10;
            case 4:
              goto label_5;
            case 5:
            case 7:
            case 8:
            case 10:
              goto label_7;
            case 6:
              goto label_6;
            case 9:
              if (metadata is TablePartMetadata)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 11:
              if (this.IsUsesMetadata((IMetadata) metadata))
              {
                num2 = 10;
                continue;
              }
              break;
          }
          if (PublicApiCodeGenerator.G8VbtlhNSbr077KuZUB9(PublicApiCodeGenerator.PSEE5AhNKmTTDlSH2Lmx((object) metadata), new Guid((string) PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-649342099 - -1150814748 ^ 501268213))))
            num2 = 2;
          else
            goto label_7;
        }
label_10:
        if (PublicApiCodeGenerator.vVOOTihNCXmfARUgr6rL((object) metadata) == EntityMetadataType.Entity)
          num1 = 6;
        else
          break;
      }
label_5:
      return metadata.Type == EntityMetadataType.Interface;
label_6:
      return true;
label_7:
      return false;
    }

    /// <summary>Метаданные пользовательского объекта</summary>
    /// <param name="metadata">Метаданные</param>
    public bool IsUserObject(IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.IsUsesMetadata(metadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return !this.IsSystem(metadata);
label_5:
      return false;
    }

    /// <summary>Запомнить пользовательские метаданные</summary>
    /// <typeparam name="T">Тип</typeparam>
    public void SaveUsesMetadata<T>() => this.SaveUsesMetadata(TypeOf<T>.Raw);

    /// <summary>Запомнить пользовательские метаданные</summary>
    /// <param name="type">тип</param>
    public void SaveUsesMetadata(Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SaveUsesMetadata(InterfaceActivator.UID(type));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Запомнить пользовательские метаданные</summary>
    /// <param name="metadata">Метаданные</param>
    public void SaveUsesMetadata(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SaveUsesMetadata(PublicApiCodeGenerator.ub876yhNv0GKVckSH2di((object) metadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private bool IsUsesMetadata(IMetadata metadata)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (metadata is EntityMetadata entityMetadata)
                break;
              goto label_7;
            case 3:
              if (!this.usesMetadata.Contains(PublicApiCodeGenerator.ub876yhNv0GKVckSH2di((object) metadata)))
              {
                num2 = 2;
                continue;
              }
              goto label_5;
            case 4:
              goto label_4;
          }
          if (PublicApiCodeGenerator.G8VbtlhNSbr077KuZUB9(entityMetadata.ImplementationUid, Guid.Empty))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
          else
            goto label_4;
        }
label_7:
        num1 = 4;
      }
label_3:
      return this.usesMetadata.Contains(PublicApiCodeGenerator.dpUbAJhNk3XMhhuihGER((object) entityMetadata));
label_4:
      return false;
label_5:
      return true;
    }

    private void SaveUsesMetadata(Guid guid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.usesMetadata.Add(guid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ISyntaxNode GetCodeTypeReference([NotNull] Type type, IList<TypeArgument> typeArguments = null)
    {
      TypeArgument typeArgument = (TypeArgument) null;
      return this.GetCodeTypeReference(type, typeArguments, true, ref typeArgument);
    }

    public ISyntaxNode GetCodeTypeReference(
      [NotNull] Type type,
      ref TypeArgument typeArgument,
      IList<TypeArgument> typeArguments = null)
    {
      return this.GetCodeTypeReference(type, typeArguments, true, ref typeArgument);
    }

    private ISyntaxNode GetCodeTypeReference(
      [NotNull] Type type,
      IList<TypeArgument> typeArguments,
      bool checkType,
      ref TypeArgument typeArgument)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672122599));
      if (type.IsGenericParameter && type.DeclaringMethod == (MethodBase) null && typeArguments != null)
      {
        typeArgument = typeArguments[type.GenericParameterPosition];
        return typeArgument.CreateTypeSyntax();
      }
      if (type.IsGenericType)
      {
        Type genericTypeDefinition = type.GetGenericTypeDefinition();
        bool checkType1 = checkType && ((IEnumerable<Type>) genericTypeDefinition.GetInterfaces()).Any<Type>((Func<Type, bool>) (i => i.IsAssignableFrom(TypeOf.IEnumerable.Raw)));
        List<ISyntaxNode> syntaxNodeList = new List<ISyntaxNode>();
        foreach (Type genericArgument in type.GetGenericArguments())
          syntaxNodeList.Add(this.GetCodeTypeReference(genericArgument, typeArguments, checkType1, ref typeArgument));
        return genericTypeDefinition.CreateTypeSyntax(syntaxNodeList.ToArray());
      }
      if (type.IsArray)
        return this.GetCodeTypeReference(type.GetElementType(), typeArguments, true, ref typeArgument).CreateArrayTypeSyntax();
      if (type == TypeOf<IUser>.Raw)
      {
        EntityMetadata metadata = (EntityMetadata) this.GetMetadata(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669156271)));
        if (metadata == null)
          return type.CreateTypeSyntax();
        typeArgument = (TypeArgument) metadata;
        return typeArgument?.CreateTypeSyntax();
      }
      if (checkType)
      {
        if (TypeOf<IEntity>.Raw.IsAssignableFrom(type) && MetadataLoader.LoadMetadata(type, loadImplementation: false) is EntityMetadata entityMetadata)
        {
          if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
            entityMetadata = (EntityMetadata) this.GetMetadata(entityMetadata.BaseClassUid);
          typeArgument = (TypeArgument) entityMetadata;
          return typeArgument.CreateTypeSyntax();
        }
        if (type.IsInterface)
        {
          Type type1 = this.autoImplementInterfaces.FirstOrDefault<Type>((Func<Type, bool>) (a => a.IsAssignableFrom(type)));
          if (type1 != (Type) null)
            return PublicApiPropertyClassNode.GetTypeName(type1).CreateTypeSyntax();
        }
      }
      return type.CreateTypeSyntax();
    }

    internal void UseHiddenProperty(bool useHidden, System.Action action)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        System.Action action1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              action1 = action;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        this.UseHiddenProperty<int>(useHidden, (Func<int>) (() =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                PublicApiCodeGenerator.\u003C\u003Ec__DisplayClass40_0.C47KIUvViiDrtjouBnvD((object) action1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_3:
          return 0;
        }));
        num1 = 3;
      }
label_3:;
    }

    internal T UseHiddenProperty<T>(bool useHidden, Func<T> func)
    {
      bool useHiddenProperty = this.useHiddenProperty;
      this.useHiddenProperty |= useHidden;
      try
      {
        return func();
      }
      finally
      {
        this.useHiddenProperty = useHiddenProperty;
      }
    }

    public string GetNodeFullPath(Type type) => this.GetNodeFullPath((string) PublicApiCodeGenerator.Om8uw2hNniB6hnoJtDDv(type));

    public string GetNodeFullPath(EntityMetadata metadata) => this.GetNodeFullPath((string) PublicApiCodeGenerator.A2Nb4phNOItdRZbJbYaI((object) metadata));

    public string GetNodeFullPath(EnumMetadata metadata) => this.GetNodeFullPath((string) PublicApiCodeGenerator.f0cvsRhN23t4fP0JMPhp((object) metadata));

    private string GetNodeFullPath(string typeName)
    {
      int num = 6;
      Pair<List<string>, List<string>> pair;
      List<string> values;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_4;
          case 2:
            values = pair.First;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 8 : 1;
            continue;
          case 4:
            if (!this.useHiddenProperty)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 9 : 7;
              continue;
            }
            goto case 7;
          case 5:
            if (!this.propertyPropertyNodes.TryGetValue(typeName, out pair))
            {
              num = 3;
              continue;
            }
            goto case 2;
          case 6:
            if (!PublicApiCodeGenerator.qeWk4whNe5kYOaZkMIyt((object) typeName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 5;
              continue;
            }
            goto label_4;
          case 7:
            values = pair.Second;
            num = 10;
            continue;
          case 8:
            if (values.Count != 0)
            {
              num = 11;
              continue;
            }
            goto case 4;
          case 9:
          case 10:
          case 11:
            if (PublicApiCodeGenerator.KyLkJ4hNP9rwtpCxKhtV((object) values) <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
        }
      }
label_3:
      return string.Join((string) PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(1669371371 ^ 1669372393), (IEnumerable<string>) values);
label_4:
      return (string) null;
    }

    public bool AddIfNotExists(string key) => this.usedKeys.Add(key);

    internal void AddPropertyClassNode(string className, string path)
    {
      int num = 3;
      while (true)
      {
        List<string> stringList;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.propertyClassNodes[className] = stringList = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 3:
            if (!this.propertyClassNodes.TryGetValue(className, out stringList))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 2;
              continue;
            }
            break;
        }
        stringList.Add(path);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
      }
label_2:;
    }

    internal void AddPropertyTypeNode(string typeName, string path, bool hidden)
    {
      int num = 8;
      while (true)
      {
        Pair<List<string>, List<string>> pair;
        List<string> stringList;
        switch (num)
        {
          case 1:
            this.propertyPropertyNodes[typeName] = pair = new Pair<List<string>, List<string>>(new List<string>(), new List<string>());
            num = 9;
            continue;
          case 2:
            if (this.propertyPropertyNodes.TryGetValue(typeName, out pair))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 4 : 4;
              continue;
            }
            goto case 1;
          case 3:
            goto label_11;
          case 4:
          case 9:
            if (!hidden)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 6 : 1;
              continue;
            }
            stringList = pair.Second;
            break;
          case 5:
            if (PublicApiCodeGenerator.sRuvy5hN1VZY8l3rSonf((object) typeName, PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(901793403 ^ 901980923)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 6:
            stringList = pair.First;
            break;
          case 7:
            goto label_2;
          case 8:
            if (typeName == null)
            {
              num = 7;
              continue;
            }
            goto case 2;
          default:
            this.AddPropertyTypeNode((string) PublicApiCodeGenerator.xqDh2uhNhjkDkV9jKLAc(-643786247 ^ -643564225), path, hidden);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 1;
            continue;
        }
        string str = path;
        stringList.Add(str);
        num = 5;
      }
label_11:
      return;
label_2:
      return;
label_8:;
    }

    internal IEnumerable<string> GetPropertyClassNodePath(string className)
    {
      List<string> stringList;
      return !this.propertyClassNodes.TryGetValue(className, out stringList) ? Enumerable.Repeat<string>(className, 1) : (IEnumerable<string>) stringList;
    }

    static PublicApiCodeGenerator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PublicApiCodeGenerator.NoImplementationLocal = new AsyncLocal<bool>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object xqDh2uhNhjkDkV9jKLAc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cC7k86hNGKFZvmQ4xsYF([In] object obj0) => CallContext.GetData((string) obj0);

    internal static bool jldXpHhNoL84hbHe6OYa() => PublicApiCodeGenerator.OZNeUJhNWWVQ07usg7qD == null;

    internal static PublicApiCodeGenerator I4HPpQhNbbyEdAGgkAeZ() => PublicApiCodeGenerator.OZNeUJhNWWVQ07usg7qD;

    internal static void lyPyuDhNExCOlSlSdpjN([In] object obj0, [In] object obj1) => CallContext.SetData((string) obj0, obj1);

    internal static object BH0m6shNfFlv57XE1Zb9() => (object) MetadataServiceContext.Service;

    internal static object DsLMe6hNQNxR3lWCmBbQ() => (object) MetadataServiceContext.MetadataRuntimeService;

    internal static EntityMetadataType vVOOTihNCXmfARUgr6rL([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid ub876yhNv0GKVckSH2di([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static object myFpSihN8KNWU49CwwK2([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object Aroj1PhNZCZAcYECE6ND([In] object obj0, Guid typeUid) => (object) ((IMetadataService) obj0).GetIdTypeDescriptor(typeUid);

    internal static object SqrjD7hNuhuOiZ2dYbS6() => (object) PublicApiCodeGenerator.Current;

    internal static void AVwoyhhNILn5A5sMhG6X([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static void KlHsbThNVkYCp0kh4xlX([In] object obj0) => PublicApiCodeGenerator.Current = (PublicApiCodeGenerator) obj0;

    internal static bool G8VbtlhNSbr077KuZUB9([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void FDhfFFhNiIsVKXgORpHB([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object QurexIhNRsJG8iHUdtYW([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void PMQM7yhNqyOgjMcDk9dB([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static Guid PSEE5AhNKmTTDlSH2Lmx([In] object obj0) => ((EntityMetadata) obj0).TypeUid;

    internal static Guid dNPMpihNXv6NLXsksFmv([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool NtlHibhNTsHTGG8iLSms([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static Guid dpUbAJhNk3XMhhuihGER([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static object Om8uw2hNniB6hnoJtDDv(Type type) => (object) PublicApiPropertyClassNode.GetTypeName(type);

    internal static object A2Nb4phNOItdRZbJbYaI([In] object obj0) => (object) PublicApiPropertyClassNode.GetTypeName((EntityMetadata) obj0);

    internal static object f0cvsRhN23t4fP0JMPhp([In] object obj0) => (object) ((EnumMetadata) obj0).FullTypeName;

    internal static bool qeWk4whNe5kYOaZkMIyt([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static int KyLkJ4hNP9rwtpCxKhtV([In] object obj0) => ((List<string>) obj0).Count;

    internal static bool sRuvy5hN1VZY8l3rSonf([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    private class PublicApiNodeDictionary : 
      IDictionary<string, IEnumerable<IPublicApiNode>>,
      ICollection<KeyValuePair<string, IEnumerable<IPublicApiNode>>>,
      IEnumerable<KeyValuePair<string, IEnumerable<IPublicApiNode>>>,
      IEnumerable
    {
      private readonly IDictionary<string, IEnumerable<IPublicApiNode>> _tree;
      private static object BXKDBbvIwRhLEuQbNxRu;

      public PublicApiNodeDictionary(IEnumerable<IPublicApiNode> nodes)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        // ISSUE: reference to a compiler-generated method
        this._tree = (IDictionary<string, IEnumerable<IPublicApiNode>>) nodes.GroupBy<IPublicApiNode, string>((Func<IPublicApiNode, string>) (n => (string) PublicApiCodeGenerator.PublicApiNodeDictionary.\u003C\u003Ec.aJNd40ZXAKe31pdixPqa((object) n))).ToDictionary<IGrouping<string, IPublicApiNode>, string, IEnumerable<IPublicApiNode>>((Func<IGrouping<string, IPublicApiNode>, string>) (g => g.Key), (Func<IGrouping<string, IPublicApiNode>, IEnumerable<IPublicApiNode>>) (g => ((IEnumerable<IPublicApiNode>) g.ToArray<IPublicApiNode>()).AsEnumerable<IPublicApiNode>()));
      }

      public IEnumerable<IPublicApiNode> this[string key]
      {
        get
        {
          IEnumerable<IPublicApiNode> publicApiNodes;
          return !this._tree.TryGetValue(key, out publicApiNodes) ? Enumerable.Empty<IPublicApiNode>() : publicApiNodes;
        }
        set => throw new NotImplementedException();
      }

      public int Count => this._tree.Count<KeyValuePair<string, IEnumerable<IPublicApiNode>>>();

      public bool IsReadOnly => true;

      public ICollection<string> Keys => this._tree.Keys;

      public ICollection<IEnumerable<IPublicApiNode>> Values => this._tree.Values;

      public void Add(
        KeyValuePair<string, IEnumerable<IPublicApiNode>> item)
      {
        throw new NotImplementedException();
      }

      public void Add(string key, IEnumerable<IPublicApiNode> value) => throw new NotImplementedException();

      public void Clear() => throw new NotImplementedException();

      public bool Contains(
        KeyValuePair<string, IEnumerable<IPublicApiNode>> item)
      {
        return this._tree.Contains(item);
      }

      public bool ContainsKey(string key) => this._tree.ContainsKey(key);

      public void CopyTo(
        KeyValuePair<string, IEnumerable<IPublicApiNode>>[] array,
        int arrayIndex)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              PublicApiCodeGenerator.PublicApiNodeDictionary.Y774StvIHUqoa3gao8KK((object) this._tree, (object) array, arrayIndex);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public IEnumerator<KeyValuePair<string, IEnumerable<IPublicApiNode>>> GetEnumerator() => this._tree.GetEnumerator();

      public bool Remove(
        KeyValuePair<string, IEnumerable<IPublicApiNode>> item)
      {
        throw new NotImplementedException();
      }

      public bool Remove(string key) => throw new NotImplementedException();

      public bool TryGetValue(string key, out IEnumerable<IPublicApiNode> value) => this._tree.TryGetValue(key, out value);

      IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

      internal static bool eNpLR8vI45Qey9sUHFB9() => PublicApiCodeGenerator.PublicApiNodeDictionary.BXKDBbvIwRhLEuQbNxRu == null;

      internal static PublicApiCodeGenerator.PublicApiNodeDictionary pIh99SvI6Fx2WeWKpAQD() => (PublicApiCodeGenerator.PublicApiNodeDictionary) PublicApiCodeGenerator.PublicApiNodeDictionary.BXKDBbvIwRhLEuQbNxRu;

      internal static void Y774StvIHUqoa3gao8KK([In] object obj0, [In] object obj1, [In] int obj2) => ((ICollection<KeyValuePair<string, IEnumerable<IPublicApiNode>>>) obj0).CopyTo((KeyValuePair<string, IEnumerable<IPublicApiNode>>[]) obj1, obj2);
    }

    private class PublicApiNoImplementContext : IDisposable
    {
      private static object b1lbYsvIApMjYnijV9nc;

      public PublicApiNoImplementContext()
      {
        PublicApiCodeGenerator.PublicApiNoImplementContext.FQeqv9vI0ncuWoo9Wbvd();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              PublicApiCodeGenerator.PublicApiNoImplementContext.Ij17y1vImjpy9uTeVErR(true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      void IDisposable.Dispose() => PublicApiCodeGenerator.PublicApiNoImplementContext.Ij17y1vImjpy9uTeVErR(false);

      internal static void FQeqv9vI0ncuWoo9Wbvd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static void Ij17y1vImjpy9uTeVErR(bool value) => PublicApiCodeGenerator.PublicApiNoImplementation = value;

      internal static bool Ry9VkFvI7mTFFS3dyvfF() => PublicApiCodeGenerator.PublicApiNoImplementContext.b1lbYsvIApMjYnijV9nc == null;

      internal static PublicApiCodeGenerator.PublicApiNoImplementContext VwkWh1vIxuJQYi0ytI43() => (PublicApiCodeGenerator.PublicApiNoImplementContext) PublicApiCodeGenerator.PublicApiNoImplementContext.b1lbYsvIApMjYnijV9nc;
    }
  }
}
