// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.DynamicModelAssemblyBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Collections.Generic;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Построитель сборки для динамических моделей</summary>
  public class DynamicModelAssemblyBuilder
  {
    private static ILogger publishLogger;
    private string assemblyName;
    private readonly IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders;
    private List<Assembly> requiredAssemblies;
    private Dictionary<string, string> sourceAssemblyHashes;
    private Dictionary<Guid, AbstractMetadata> metadataDict;
    private IEnumerable<IMetadata> configurationMetadataList;
    private List<EntityMetadata> intfMetadataList;
    private Dictionary<Guid, List<EntityMetadata>> intfExtMetadataByBaseUid;
    private List<System.Type> autoImplementAllTypes;
    private List<System.Type> autoImplementInterfaces;
    private Dictionary<System.Type, List<System.Type>> autoImplementExtensions;
    private List<EntityMetadata> metadataList;
    private byte[] documentationRaw;
    private MemoryStream documentationRawStream;
    private bool initialized;
    private bool metadataBuilt;
    private byte[] previousAssemblyRaw;
    private MemoryStream previousAssemblyRawStream;
    private bool buildDeltaAssembly;
    private Dictionary<string, string> previousHashCodes;
    private static readonly ContextVars.Local<ISet<Guid>> configurationModelUids;
    internal static DynamicModelAssemblyBuilder egNBONhaE4FMnt2XTXQI;

    /// <summary>
    /// Получить типы, которые могут быть переданы в построитель динамической сборки
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<System.Type> GetEntityInterfaceTypes() => ComponentManager.Current.GetExtensionPointTypes(TypeOf<IEntity>.Raw).Where<System.Type>((Func<System.Type, bool>) (t =>
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            if (DynamicModelAssemblyBuilder.\u003C\u003Ec.DaTV0nvidKYIN8PJq68i(t, TypeOf<IEntity>.Raw))
            {
              num = 4;
              continue;
            }
            goto label_3;
          case 2:
            if (t.IsInterface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
          case 5:
            goto label_3;
          case 4:
            if (t.ContainsGenericParameters)
            {
              num = 3;
              continue;
            }
            goto case 6;
          case 6:
            if (!t.IsDefined(TypeOf<MetadataTypeAttribute>.Raw, false))
            {
              num = 5;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return !DynamicModelAssemblyBuilder.\u003C\u003Ec.t4rHjuvirxr85RhlQnJI((object) DynamicModelAssemblyBuilder.\u003C\u003Ec.Y6PPjAvilqlfEMV7QsEC((object) AttributeHelper<MetadataTypeAttribute>.GetAttribute(t, false)), TypeOf<PartialMetadataTypeAttribute>.Raw, false);
label_3:
      return false;
    }));

    /// <summary>
    /// Получить типы, которые могут быть переданы в построитель динамической сборки
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<System.Type> GetAutoImplementTypes() => ComponentManager.Current.GetExtensionPointTypes(TypeOf<IAutoImplement>.Raw).Where<System.Type>((Func<System.Type, bool>) (t =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (t.IsInterface)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_2;
          default:
            // ISSUE: reference to a compiler-generated method
            if (DynamicModelAssemblyBuilder.\u003C\u003Ec.DaTV0nvidKYIN8PJq68i(t, TypeOf<IAutoImplement>.Raw))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return !t.ContainsGenericParameters;
label_3:
      return false;
    }));

    /// <summary>Получить документацию в текущей локали</summary>
    /// <param name="documentationTemplateRaw">Raw шаблона документации</param>
    /// <returns>Raw документации в текущей локали</returns>
    internal static MemoryStream GetDocumentation(MemoryStream documentationTemplateRaw)
    {
      int num1 = 2;
      string str;
      MemoryStream memoryStream;
      StreamWriter streamWriter;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = 5;
            continue;
          case 2:
            str = EleWise.ELMA.SR.PreparedTranslate((string) DynamicModelAssemblyBuilder.vE9FRkhavkKPH7kdCuwi((object) documentationTemplateRaw, DynamicModelAssemblyBuilder.q3IiYOhaCAIAMKgUtNvQ()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          case 4:
label_4:
            DynamicModelAssemblyBuilder.s0oFVHhaI4AlnDLMiMwS((object) memoryStream, 0L, SeekOrigin.Begin);
            num1 = 3;
            continue;
          case 5:
            streamWriter = new StreamWriter((Stream) DynamicModelAssemblyBuilder.gQretDha8nfaTB4cSgVU((object) memoryStream), (Encoding) DynamicModelAssemblyBuilder.q3IiYOhaCAIAMKgUtNvQ());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            try
            {
              DynamicModelAssemblyBuilder.Cofr9ThaZLXMnPpmEowT((object) streamWriter, (object) str);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_4;
              }
            }
            finally
            {
              if (streamWriter != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      DynamicModelAssemblyBuilder.LgX8AJhaurSqYuJhBjZf((object) streamWriter);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
label_16:;
            }
        }
      }
label_6:
      return memoryStream;
    }

    /// <summary>Сохранить документацию</summary>
    /// <param name="documentationTemplateRaw">Raw шаблона документации</param>
    /// <param name="baseDirectoryName">Путь для сохранения</param>
    /// <remarks>
    /// В указанную папку сохраняется документация в базовой локали (<see cref="P:EleWise.ELMA.SR.KeyCultureInfo" />), и для каждой дополнительно установленной локали (<seealso cref="!:SR.LanguagesMap.AllBaseCultureInfo()" />) создается папка с локализованной документацией
    /// </remarks>
    internal static void SaveDocumentation(
      MemoryStream documentationTemplateRaw,
      string baseDirectoryName)
    {
      int num1 = 1;
      string str1;
      List<CultureInfo>.Enumerator enumerator;
      int setting;
      string documentationTemplate;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            enumerator = EleWise.ELMA.SR.GetCultureNames().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 2 : 2;
            continue;
          case 4:
            documentationTemplate = (string) DynamicModelAssemblyBuilder.vE9FRkhavkKPH7kdCuwi((object) documentationTemplateRaw, DynamicModelAssemblyBuilder.q3IiYOhaCAIAMKgUtNvQ());
            num1 = 6;
            continue;
          case 5:
            goto label_24;
          case 6:
            setting = EleWise.ELMA.SR.GetSetting<int>((string) DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(-281842504 ^ -282049338), 30);
            num1 = 3;
            continue;
          default:
            str1 = (string) DynamicModelAssemblyBuilder.LfsVCShaV3V4nLuhwhHM((object) EleWise.ELMA.SR.KeyCultureInfo);
            num1 = 4;
            continue;
        }
      }
label_24:
      return;
label_4:
      try
      {
label_12:
        if (enumerator.MoveNext())
          goto label_6;
        else
          goto label_13;
label_5:
        CultureInfo current;
        string path;
        string str2;
        string str3;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              CultureInfo culture = current;
              Func<string> func;
              Func<string> func1 = func;
              // ISSUE: reference to a compiler-generated method
              Func<string> action = func1 == null ? (func = (Func<string>) (() => (string) DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass3_0.q2sr5Wviz7HEPNEqckUi((object) documentationTemplate))) : func1;
              str2 = EleWise.ELMA.SR.RunWithCulture<string>(culture, action);
              num2 = 6;
              continue;
            case 2:
              Directory.CreateDirectory(path);
              num2 = 10;
              continue;
            case 3:
              goto label_20;
            case 4:
              goto label_12;
            case 5:
              goto label_6;
            case 6:
              MemoryHelper.ActionWithMemoryBuffer<byte, (string, int, string)>(DynamicModelAssemblyBuilder.wi1pXEhaKDNWChfV8qyu(DynamicModelAssemblyBuilder.q3IiYOhaCAIAMKgUtNvQ(), (object) str2), (str2, setting, str3), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (string, int, string)>(DynamicModelAssemblyBuilder.SaveDocumentationAction));
              num2 = 4;
              continue;
            case 7:
              path = baseDirectoryName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            case 8:
              path = Path.Combine(baseDirectoryName, (string) DynamicModelAssemblyBuilder.LfsVCShaV3V4nLuhwhHM((object) current));
              num2 = 9;
              continue;
            case 9:
              if (!DynamicModelAssemblyBuilder.IkhYyVhaRudvT5HiQkbE((object) path))
              {
                num2 = 2;
                continue;
              }
              goto case 10;
            case 10:
              str3 = (string) DynamicModelAssemblyBuilder.arIUWLhaqnbnn5fnrUIm((object) path, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121035497));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
              continue;
            default:
              if (DynamicModelAssemblyBuilder.ACxYYZhaiS3DGZRSOTud(DynamicModelAssemblyBuilder.LfsVCShaV3V4nLuhwhHM((object) current), (object) str1))
              {
                num2 = 8;
                continue;
              }
              goto case 10;
          }
        }
label_20:
        return;
label_6:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        {
          num2 = 7;
          goto label_5;
        }
        else
          goto label_5;
label_13:
        num2 = 3;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Уникальные идентификаторы метаданных конфигурации</summary>
    internal static ISet<Guid> ConfigurationModelUids => DynamicModelAssemblyBuilder.configurationModelUids.Value;

    /// <summary>Ctor</summary>
    /// <param name="assemblyName">Имя сборки</param>
    public DynamicModelAssemblyBuilder(string assemblyName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(assemblyName, ((ComponentManager) DynamicModelAssemblyBuilder.XNSp4ahaXprqPnEwCUlu()).GetExtensionPoints<IPublicApiNodeProvider>());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="publicApiNodeProviders">Провайдеры узлов дерева Public API</param>
    public DynamicModelAssemblyBuilder(
      string assemblyName,
      IEnumerable<IPublicApiNodeProvider> publicApiNodeProviders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.requiredAssemblies = new List<Assembly>();
      this.sourceAssemblyHashes = new Dictionary<string, string>();
      this.metadataDict = new Dictionary<Guid, AbstractMetadata>();
      this.autoImplementAllTypes = new List<System.Type>();
      this.metadataList = new List<EntityMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNullOrEmpty(assemblyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583555768));
      Contract.ArgumentNotNull((object) publicApiNodeProviders, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173688477));
      this.assemblyName = assemblyName;
      this.publicApiNodeProviders = publicApiNodeProviders;
    }

    /// <summary>
    /// Зарегистрировать тип, на основе которого должна строиться реализация сущности
    /// </summary>
    /// <remarks>
    /// Может быть вызван только до вызова методов HasChanges, BuildAssembly и GetImplementationMetadataList
    /// </remarks>
    /// <param name="type"></param>
    public void RegisterType(System.Type type)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        AbstractMetadata abstractMetadata;
        Assembly assembly1;
        string str;
        Assembly assembly2;
        string hashCode;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
              {
                num2 = 28;
                continue;
              }
              goto case 14;
            case 2:
              goto label_14;
            case 3:
              if (!DynamicModelAssemblyBuilder.SuRoGJhaTZfggrnIdNDk(type, (System.Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 9 : 7;
                continue;
              }
              goto label_35;
            case 4:
              this.CheckNotInitialized((string) DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(1514961705 ^ 1515132453));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 3;
              continue;
            case 5:
              goto label_20;
            case 6:
              this.requiredAssemblies.Add(assembly1);
              num2 = 15;
              continue;
            case 7:
              this.sourceAssemblyHashes.Add(ComponentManager.GetAssemblyShortName(assembly2), hashCode);
              num2 = 5;
              continue;
            case 8:
              hashCode = AssemblyInfoCache.EvaluateHashCode(assembly2);
              num2 = 7;
              continue;
            case 9:
              if (TypeOf<IAutoImplement>.Raw.IsAssignableFrom(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 17 : 20;
                continue;
              }
              goto label_25;
            case 10:
            case 11:
            case 18:
              this.metadataDict[abstractMetadata.Uid] = abstractMetadata;
              num2 = 17;
              continue;
            case 12:
              this.requiredAssemblies.Add(assembly2);
              num2 = 8;
              continue;
            case 13:
              goto label_34;
            case 14:
              if (DynamicModelAssemblyBuilder.iHYrKBhan5LfQDiJL97X((object) entityMetadata) == EntityMetadataType.Interface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 18 : 0;
                continue;
              }
              goto label_32;
            case 15:
              str = (string) DynamicModelAssemblyBuilder.mJj07yhaOXgr1nA6qOUx((object) assembly1);
              num2 = 19;
              continue;
            case 16:
              goto label_37;
            case 17:
              assembly1 = type.Assembly;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            case 19:
              goto label_33;
            case 20:
              if (this.autoImplementAllTypes.Contains(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 24 : 2;
                continue;
              }
              this.autoImplementAllTypes.Add(type);
              num2 = 13;
              continue;
            case 21:
              if (!(abstractMetadata is EntityMetadata entityMetadata))
              {
                num2 = 22;
                continue;
              }
              goto case 1;
            case 22:
              goto label_17;
            case 23:
              if (abstractMetadata is EnumMetadata)
              {
                num2 = 11;
                continue;
              }
              goto case 21;
            case 24:
              goto label_24;
            case 25:
              goto label_10;
            case 26:
              if (abstractMetadata != null)
              {
                num2 = 23;
                continue;
              }
              goto label_36;
            case 27:
              if (!this.requiredAssemblies.Contains(assembly2))
              {
                num2 = 12;
                continue;
              }
              goto label_3;
            case 28:
              if (DynamicModelAssemblyBuilder.odC5JVhakUdJCuNO7489((object) entityMetadata) != Guid.Empty)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 10 : 1;
                continue;
              }
              goto case 14;
            case 29:
              goto label_7;
            default:
              if (this.requiredAssemblies.Contains(assembly1))
              {
                num2 = 25;
                continue;
              }
              goto case 6;
          }
        }
label_25:
        abstractMetadata = MetadataLoader.LoadMetadata(type, false, false) as AbstractMetadata;
        num1 = 26;
        continue;
label_33:
        this.sourceAssemblyHashes.Add((string) DynamicModelAssemblyBuilder.CVd0kOha2himyiiqiqGE((object) assembly1), str);
        num1 = 29;
        continue;
label_34:
        assembly2 = type.Assembly;
        num1 = 27;
      }
label_14:
      return;
label_20:
      return;
label_37:
      return;
label_17:
      return;
label_24:
      return;
label_10:
      return;
label_7:
      return;
label_32:
      return;
label_35:
      return;
label_36:
      return;
label_3:;
    }

    /// <summary>
    /// Зарегистрировать типы, на основе которых должны строиться реализации сущностей
    /// </summary>
    /// <remarks>
    /// Может быть вызван только до вызова методов HasChanges, BuildAssembly и GetImplementationMetadataList
    /// </remarks>
    /// <param name="types"></param>
    public void RegisterTypes(IEnumerable<System.Type> types)
    {
      this.CheckNotInitialized(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108055242));
      if (types == null)
        return;
      foreach (System.Type type in types)
        this.RegisterType(type);
    }

    /// <summary>Зарегистрировать объект метаданных</summary>
    /// <remarks>
    /// Может быть вызван только до вызова методов HasChanges, BuildAssembly и GetImplementationMetadataList
    /// </remarks>
    /// <param name="metadata"></param>
    public void RegisterMetadata(IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata is EnumMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 3 : 8;
              continue;
            }
            goto case 5;
          case 2:
            this.CheckNotInitialized((string) DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(--1333735954 ^ 1333550932));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
          case 3:
          case 8:
            this.metadataDict[DynamicModelAssemblyBuilder.ShNQRehaPIGFxkbFBMbg((object) metadata)] = (AbstractMetadata) metadata;
            num = 9;
            continue;
          case 4:
            if (!DynamicModelAssemblyBuilder.keBv8nhae82wXipOxyuL(DynamicModelAssemblyBuilder.odC5JVhakUdJCuNO7489((object) entityMetadata), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 5:
            if (!(metadata is EntityMetadata entityMetadata))
            {
              num = 6;
              continue;
            }
            goto case 7;
          case 6:
            goto label_13;
          case 7:
            if (DynamicModelAssemblyBuilder.iHYrKBhan5LfQDiJL97X((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
            {
              num = 4;
              continue;
            }
            break;
          case 9:
            goto label_2;
        }
        if (DynamicModelAssemblyBuilder.iHYrKBhan5LfQDiJL97X((object) entityMetadata) == EntityMetadataType.Interface)
          num = 3;
        else
          goto label_12;
      }
label_13:
      return;
label_2:
      return;
label_12:;
    }

    /// <summary>Зарегистрировать объекты метаданных</summary>
    /// <remarks>
    /// Может быть вызван только до вызова методов HasChanges, BuildAssembly и GetImplementationMetadataList
    /// </remarks>
    /// <param name="metadataList"></param>
    public void RegisterMetadataList(IEnumerable<IMetadata> metadataList)
    {
      this.CheckNotInitialized(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234114438));
      if (metadataList == null)
        return;
      foreach (IMetadata metadata in metadataList)
        this.RegisterMetadata(metadata);
    }

    /// <summary>Зарегистрировать объекты метаданных кофигурации</summary>
    /// <remarks>
    /// Может быть вызван только до вызова методов HasChanges, BuildAssembly и GetImplementationMetadataList
    /// </remarks>
    /// <param name="metadataList">Метаданные конфигурации</param>
    public void RegisterConfigurationMetadataList(IEnumerable<IMetadata> metadataList) => this.configurationMetadataList = metadataList;

    /// <summary>
    /// Зарегистрировать сборку, от которой зависит динамическая сборка
    /// </summary>
    /// <remarks>
    /// Может быть вызван только до вызова методов HasChanges, BuildAssembly и GetImplementationMetadataList
    /// </remarks>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="asmRaw">Бинарный код сборки</param>
    public void RegisterDependentAssembly(string assemblyName, byte[] asmRaw)
    {
      int num1 = 2;
      MemoryStream asmRaw1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_12;
          case 1:
            goto label_3;
          case 2:
            asmRaw1 = (MemoryStream) DynamicModelAssemblyBuilder.Hb4OCIha1RJm3y1XHHaM((object) asmRaw, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_12:
      return;
label_7:
      return;
label_3:
      try
      {
        this.RegisterDependentAssembly(assemblyName, asmRaw1);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (asmRaw1 != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                DynamicModelAssemblyBuilder.LgX8AJhaurSqYuJhBjZf((object) asmRaw1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    /// <summary>
    /// Зарегистрировать сборку, от которой зависит динамическая сборка
    /// </summary>
    /// <remarks>
    /// Может быть вызван только до вызова методов HasChanges, BuildAssembly и GetImplementationMetadataList
    /// </remarks>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="asmRaw">Поток, содержащий бинарный код сборки</param>
    public void RegisterDependentAssembly(string assemblyName, MemoryStream asmRaw)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (assemblyName != null)
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 2:
            this.CheckNotInitialized((string) DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(-281842504 ^ -282066642));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
          case 3:
            str = (string) DynamicModelAssemblyBuilder.sGl6QMhaN7bEblXDM0sj((object) asmRaw);
            num = 4;
            continue;
          case 4:
            this.sourceAssemblyHashes[assemblyName] = str;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_8:;
    }

    /// <summary>Получить список построенных метаданных</summary>
    public ICollection<EntityMetadata> GetImplementationMetadataList()
    {
      this.BuildMetadata();
      return (ICollection<EntityMetadata>) this.metadataList;
    }

    /// <summary>Построить сборку</summary>
    /// <param name="builderActions">Действия с построителем сборки. Обязательно необходимо вызвать у него добавление референсов на сборки, требуемые для компиляции динамической сборки.</param>
    /// <returns>Raw сборки</returns>
    public byte[] BuildAssembly(Action<ModelAssemblyBuilder> builderActions) => this.BuildAssemblyToStream(builderActions)?.ToArray();

    /// <summary>Построить сборку</summary>
    /// <param name="builderActions">Действия с построителем сборки. Обязательно необходимо вызвать у него добавление референсов на сборки, требуемые для компиляции динамической сборки.</param>
    /// <returns>Поток в памяти, содержащий Raw сборки</returns>
    public MemoryStream BuildAssemblyToStream(Action<ModelAssemblyBuilder> builderActions)
    {
      using (ModelAssemblyBuilder builder = new ModelAssemblyBuilder(this.assemblyName))
      {
        if (this.buildDeltaAssembly)
          DynamicModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105272786));
        else
          DynamicModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88064677));
        this.BuildMetadata();
        this.documentationRaw = (byte[]) null;
        this.documentationRawStream = (MemoryStream) null;
        EleWise.ELMA.SR.RunWithFutureTranslate((System.Action) (() =>
        {
          switch (1)
          {
            case 1:
              try
              {
                // ISSUE: reference to a compiler-generated method
                DynamicModelAssemblyBuilder.configurationModelUids.Value = (ISet<Guid>) (this.configurationMetadataList ?? Enumerable.Empty<IMetadata>()).SelectRecursive<IMetadata>((Func<IMetadata, IEnumerable<IMetadata>>) (m => !(m is ICompositeMetadata compositeMetadata2) ? Enumerable.Empty<IMetadata>() : compositeMetadata2.GetCompositeParts())).Select<IMetadata, Guid>((Func<IMetadata, Guid>) (m => DynamicModelAssemblyBuilder.\u003C\u003Ec.O6DM5SvigvhrihpJ4YQP((object) m))).ToHashSet<Guid>();
                int num1 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                  num1 = 0;
                List<EntityMetadata>.Enumerator enumerator1;
                List<System.Type>.Enumerator enumerator2;
                while (true)
                {
                  switch (num1)
                  {
                    case 1:
                      if (builderActions == null)
                      {
                        num1 = 4;
                        continue;
                      }
                      goto case 5;
                    case 2:
                    case 4:
                      enumerator1 = this.metadataList.GetEnumerator();
                      num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                      continue;
                    case 3:
label_19:
                      enumerator2 = this.autoImplementInterfaces.GetEnumerator();
                      num1 = 6;
                      continue;
                    case 5:
                      builderActions(builder);
                      num1 = 2;
                      continue;
                    case 6:
                      goto label_20;
                    default:
                      try
                      {
label_10:
                        if (enumerator1.MoveNext())
                          goto label_9;
                        else
                          goto label_11;
label_8:
                        EntityMetadata current;
                        int num2;
                        while (true)
                        {
                          switch (num2)
                          {
                            case 1:
                              goto label_10;
                            case 2:
                              goto label_9;
                            case 3:
                              builder.AddMetadata((IMetadata) current);
                              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                              continue;
                            default:
                              goto label_19;
                          }
                        }
label_9:
                        current = enumerator1.Current;
                        num2 = 3;
                        goto label_8;
label_11:
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                        goto label_8;
                      }
                      finally
                      {
                        enumerator1.Dispose();
                        int num3 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                          num3 = 0;
                        switch (num3)
                        {
                          default:
                        }
                      }
                  }
                }
label_20:
                try
                {
label_27:
                  if (enumerator2.MoveNext())
                    goto label_31;
                  else
                    goto label_28;
label_21:
                  int num4;
                  int num5 = num4;
label_22:
                  System.Type current;
                  List<System.Type> typeList;
                  while (true)
                  {
                    string code;
                    ClassGeneratorAttribute attribute;
                    System.Type type;
                    switch (num5)
                    {
                      case 1:
                        goto label_30;
                      case 2:
                        goto label_31;
                      case 3:
                        goto label_27;
                      case 4:
                        goto label_37;
                      case 5:
                        if (attribute == null)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 8 : 8;
                          continue;
                        }
                        goto case 6;
                      case 6:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass17_1.abJSS9vRQ76vhoO6QucL(DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass17_1.XIXAvovRfk3t7KrKE8Xc((object) attribute), (System.Type) null))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                          continue;
                        }
                        // ISSUE: reference to a compiler-generated method
                        type = DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass17_1.XIXAvovRfk3t7KrKE8Xc((object) attribute);
                        break;
                      case 7:
                        attribute = AttributeHelper<ClassGeneratorAttribute>.GetAttribute(current, false);
                        num5 = 5;
                        continue;
                      case 9:
                        // ISSUE: reference to a compiler-generated method
                        DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass17_1.e709GpvRZnoQktftBOo4((object) builder, (object) code);
                        num5 = 3;
                        continue;
                      default:
                        // ISSUE: type reference
                        // ISSUE: reference to a compiler-generated method
                        type = DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass17_1.ttZ6v4vRCHBkFT3aZevp(__typeref (AutoClassGenerator));
                        break;
                    }
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    code = ((IAutoClassGenerator) DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass17_1.PTEkJYvRvWadCRp0q52o(type)).GenerateCode(current, typeList == null ? new System.Type[0] : (System.Type[]) DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass17_1.Rjxbh7vR8qHidcMVvJpp((object) typeList));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 9;
                  }
label_37:
                  break;
label_30:
                  this.autoImplementExtensions.TryGetValue(current, out typeList);
                  num4 = 7;
                  goto label_21;
label_28:
                  num4 = 4;
                  goto label_21;
label_31:
                  current = enumerator2.Current;
                  num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                  {
                    num5 = 1;
                    goto label_22;
                  }
                  else
                    goto label_22;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                    num6 = 0;
                  switch (num6)
                  {
                    default:
                  }
                }
              }
              finally
              {
                DynamicModelAssemblyBuilder.configurationModelUids.Value = (ISet<Guid>) null;
                int num = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                  num = 0;
                switch (num)
                {
                  default:
                }
              }
          }
        }));
        this.BuildPublicApi(builder);
        builder.AddSourceCode(this.sourceAssemblyHashes.If<KeyValuePair<string, string>>(!ReflectionType.DynamicPublicationEnable.Value, (Func<IEnumerable<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>>) (_ => _.Append<KeyValuePair<string, string>>(new KeyValuePair<string, string>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574321984), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740339762))))).Select<KeyValuePair<string, string>, ISyntaxNode>((Func<KeyValuePair<string, string>, ISyntaxNode>) (pair =>
        {
          ISyntaxNode attribute = TypeOf<DynamicAssemblySourceAttribute>.Raw.CreateAttribute((object) pair.Key.CreateSyntaxNode(), (object) pair.Value.CreateSyntaxNode());
          attribute.Unpack<AttributeSyntax>().AssemblySpecifier = true;
          return attribute;
        })).GenerateCSCodeString());
        if (this.buildDeltaAssembly)
          DynamicModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766042850));
        else
          DynamicModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439390302));
        MemoryStream stream = builder.BuildToStream(false, true);
        if (stream != null)
          this.documentationRawStream = builder.DocumentationRawStream;
        if (this.buildDeltaAssembly)
          DynamicModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561134604));
        else
          DynamicModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710629348));
        return stream;
      }
    }

    private void BuildPublicApi(ModelAssemblyBuilder builder)
    {
      int num1 = 3;
      ModelAssemblyBuilder builder1;
      DynamicModelAssemblyBuilder modelAssemblyBuilder;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_3;
          case 1:
            modelAssemblyBuilder = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 5 : 5;
            continue;
          case 2:
            builder1 = builder;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            if (this.publicApiNodeProviders.Any<IPublicApiNodeProvider>())
            {
              EleWise.ELMA.SR.RunWithFutureTranslate((System.Action) (() =>
              {
                int num2 = 2;
                PublicApiCodeGenerator apiCodeGenerator;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      apiCodeGenerator = new PublicApiCodeGenerator((IEnumerable<System.Type>) modelAssemblyBuilder.autoImplementInterfaces, !modelAssemblyBuilder.buildDeltaAssembly ? (IEnumerable<IMetadata>) null : (IEnumerable<IMetadata>) modelAssemblyBuilder.metadataDict.Values, modelAssemblyBuilder.configurationMetadataList, modelAssemblyBuilder.publicApiNodeProviders);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass18_0.nNGsgXvRiZWQyL6hZuEI((object) builder1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638779029));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_5;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      DynamicModelAssemblyBuilder.\u003C\u003Ec__DisplayClass18_0.sKi5w4vRRviHGUcy1jXK((object) builder1, (object) apiCodeGenerator.GenerateCode());
                      num2 = 3;
                      continue;
                  }
                }
label_5:;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            }
            num1 = 4;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_2:
      return;
label_10:;
    }

    /// <summary>
    /// Raw файла XML-документации (доступен после вызова метода BuildAssembly)
    /// </summary>
    public byte[] DocumentationRaw
    {
      get
      {
        int num = 2;
        byte[] array;
        byte[] documentationRaw;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.documentationRaw = array = this.documentationRawStream?.ToArray();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 2:
              documentationRaw = this.documentationRaw;
              if (documentationRaw == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return documentationRaw;
label_6:
        return array;
      }
    }

    /// <summary>
    /// Поток в памяти, содержащий Raw файла XML-документации (доступен после вызова метода <see cref="M:EleWise.ELMA.Model.CodeGeneration.DynamicModelAssemblyBuilder.BuildAssemblyToStream(System.Action{EleWise.ELMA.Model.CodeGeneration.ModelAssemblyBuilder})" />)
    /// </summary>
    public MemoryStream DocumentationRawStream
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 2:
              MemoryStream documentationRawStream = this.documentationRawStream;
              if (documentationRawStream == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                continue;
              }
              DynamicModelAssemblyBuilder.s0oFVHhaI4AlnDLMiMwS((object) documentationRawStream, 0L, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return this.documentationRawStream;
      }
    }

    /// <summary>Бинарный код предудыщей сборки</summary>
    public byte[] PreviousAssemblyRaw
    {
      get
      {
        int num = 2;
        byte[] previousAssemblyRaw1;
        byte[] previousAssemblyRaw2;
        while (true)
        {
          switch (num)
          {
            case 1:
              MemoryStream assemblyRawStream = this.previousAssemblyRawStream;
              this.previousAssemblyRaw = previousAssemblyRaw1 = assemblyRawStream != null ? (byte[]) DynamicModelAssemblyBuilder.MRQ3tIha3evmYqDcLxFf((object) assemblyRawStream) : (byte[]) (object) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            case 2:
              previousAssemblyRaw2 = this.previousAssemblyRaw;
              if (previousAssemblyRaw2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return previousAssemblyRaw2;
label_6:
        return previousAssemblyRaw1;
      }
      set
      {
        int num1 = 5;
        while (true)
        {
          int num2 = num1;
          MemoryStream assemblyRawStream;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.previousAssemblyRawStream = (MemoryStream) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 2;
                continue;
              case 2:
                goto label_12;
              case 3:
                this.previousAssemblyRawStream = (MemoryStream) DynamicModelAssemblyBuilder.xr9tZuhaaEkNTA4r1x00(value.Length);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              case 4:
                assemblyRawStream = this.previousAssemblyRawStream;
                if (assemblyRawStream == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 6 : 0;
                  continue;
                }
                goto label_13;
              case 5:
                this.previousAssemblyRaw = value;
                num2 = 4;
                continue;
              case 6:
              case 8:
                if (value == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                  continue;
                }
                goto case 3;
              case 7:
                goto label_5;
              default:
                DynamicModelAssemblyBuilder.yjdNNShaDeNs8F17g3hn((object) this.previousAssemblyRawStream, (object) value, 0, value.Length);
                num2 = 7;
                continue;
            }
          }
label_13:
          DynamicModelAssemblyBuilder.wMvFPghapbPn7FVsP1L0((object) assemblyRawStream);
          num1 = 8;
        }
label_12:
        return;
label_5:;
      }
    }

    /// <summary>
    /// Поток в памяти, содержащей бинарный код предыдущей сборки
    /// </summary>
    public MemoryStream PreviousAssemblyRawStream
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 2:
              MemoryStream assemblyRawStream = this.previousAssemblyRawStream;
              if (assemblyRawStream == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
                continue;
              }
              assemblyRawStream.Seek(0L, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.previousAssemblyRawStream;
      }
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 2:
              MemoryStream assemblyRawStream = this.previousAssemblyRawStream;
              if (assemblyRawStream == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                continue;
              }
              DynamicModelAssemblyBuilder.wMvFPghapbPn7FVsP1L0((object) assemblyRawStream);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
              continue;
            case 3:
              this.previousAssemblyRaw = (byte[]) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_6;
            default:
              this.previousAssemblyRawStream = value;
              num = 4;
              continue;
          }
        }
label_6:;
      }
    }

    /// <summary>
    /// Есть ли изменения в текущей динамической сборке по сравнению с исходной - assemblyRaw
    /// </summary>
    /// <returns>True, если есть изменения</returns>
    public bool HasChanges()
    {
      int num1 = 3;
      string str1;
      bool flag;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, string>.Enumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              if (this.PreviousAssemblyRaw == null)
              {
                num2 = 8;
                continue;
              }
              goto case 5;
            case 3:
              this.Init();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 2 : 0;
              continue;
            case 4:
            case 8:
              goto label_5;
            case 5:
              if (this.PreviousAssemblyRaw.Length != 0)
              {
                this.LoadPreviousHashCodes();
                num2 = 10;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 3 : 4;
              continue;
            case 6:
label_8:
              this.previousHashCodes.TryGetValue((string) DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(--1333735954 ^ 1333550338), out str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            case 7:
              if (this.previousHashCodes.Count != DynamicModelAssemblyBuilder.LmYERChatWF1tS31Anhn((object) this.sourceAssemblyHashes))
              {
                num2 = 9;
                continue;
              }
              goto label_34;
            case 10:
              if (this.previousHashCodes == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 11:
              try
              {
label_21:
                if (enumerator.MoveNext())
                  goto label_27;
                else
                  goto label_22;
label_18:
                KeyValuePair<string, string> current;
                string str2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (this.previousHashCodes.TryGetValue(current.Key, out str2))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 8 : 8;
                        continue;
                      }
                      goto case 3;
                    case 2:
                      goto label_21;
                    case 3:
                      flag = true;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 4 : 7;
                      continue;
                    case 4:
                      goto label_27;
                    case 5:
                      flag = true;
                      num3 = 9;
                      continue;
                    case 6:
                    case 8:
                      if (str2 != current.Value)
                      {
                        num3 = 5;
                        continue;
                      }
                      goto label_21;
                    case 7:
                    case 9:
                      goto label_10;
                    default:
                      goto label_8;
                  }
                }
label_22:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                goto label_18;
label_27:
                current = enumerator.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                {
                  num3 = 1;
                  goto label_18;
                }
                else
                  goto label_18;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            default:
              goto label_33;
          }
        }
label_34:
        enumerator = this.sourceAssemblyHashes.GetEnumerator();
        num1 = 11;
      }
label_5:
      return true;
label_9:
      return DynamicModelAssemblyBuilder.ACxYYZhaiS3DGZRSOTud((object) str1, DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(~289714581 ^ -289713040)) == ReflectionType.DynamicPublicationEnable.Value;
label_10:
      return flag;
label_33:
      return true;
    }

    /// <summary>Формировать PublicApi только Delta</summary>
    internal void BuildDeltaAssembly()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.buildDeltaAssembly = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void CheckNotInitialized(string method)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new InvalidOperationException(string.Format((string) DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(1021410165 ^ 1021449267), (object) method));
    }

    /// <summary>Инициализировать</summary>
    private void Init()
    {
      int num1 = 9;
      IEnumerator<EntityMetadata> enumerator1;
      List<System.Type>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator2 = this.autoImplementAllTypes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          case 2:
label_32:
            this.initialized = true;
            num1 = 10;
            continue;
          case 3:
            enumerator1 = this.metadataDict.Values.OfType<EntityMetadata>().GetEnumerator();
            num1 = 6;
            continue;
          case 4:
            this.intfExtMetadataByBaseUid = new Dictionary<Guid, List<EntityMetadata>>();
            num1 = 3;
            continue;
          case 5:
label_27:
            this.autoImplementInterfaces = new List<System.Type>();
            num1 = 7;
            continue;
          case 6:
            try
            {
label_4:
              if (DynamicModelAssemblyBuilder.prLwSbha4RMTXuZQR00F((object) enumerator1))
                goto label_10;
              else
                goto label_5;
label_3:
              EntityMetadata rootMetadata;
              List<EntityMetadata> entityMetadataList;
              EntityMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 2:
                    goto label_27;
                  case 3:
                    this.intfExtMetadataByBaseUid.Add(DynamicModelAssemblyBuilder.v668wMhawoSEvLmmVSgU((object) rootMetadata), entityMetadataList);
                    num2 = 7;
                    continue;
                  case 4:
                    if (!this.intfExtMetadataByBaseUid.TryGetValue(rootMetadata.Uid, out entityMetadataList))
                    {
                      num2 = 8;
                      continue;
                    }
                    goto case 7;
                  case 5:
                    goto label_10;
                  case 6:
                    rootMetadata = this.GetRootMetadata(current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 10 : 0;
                    continue;
                  case 7:
                    entityMetadataList.Add(current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  case 8:
                    entityMetadataList = new List<EntityMetadata>();
                    num2 = 3;
                    continue;
                  case 9:
                    if (current.Type == EntityMetadataType.InterfaceExtension)
                    {
                      num2 = 6;
                      continue;
                    }
                    goto case 11;
                  case 10:
                    if (rootMetadata == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 4;
                  case 11:
                    if (DynamicModelAssemblyBuilder.iHYrKBhan5LfQDiJL97X((object) current) == EntityMetadataType.Interface)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 12 : 0;
                      continue;
                    }
                    goto label_4;
                  case 12:
                    this.intfMetadataList.Add(current);
                    num2 = 13;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_5:
              num2 = 2;
              goto label_3;
label_10:
              current = enumerator1.Current;
              num2 = 9;
              goto label_3;
            }
            finally
            {
              int num3;
              if (enumerator1 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
              else
                goto label_23;
label_22:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_23:
              DynamicModelAssemblyBuilder.LgX8AJhaurSqYuJhBjZf((object) enumerator1);
              num3 = 2;
              goto label_22;
            }
          case 7:
            this.autoImplementExtensions = new Dictionary<System.Type, List<System.Type>>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
            continue;
          case 8:
            goto label_55;
          case 9:
            if (this.initialized)
            {
              num1 = 8;
              continue;
            }
            this.intfMetadataList = new List<EntityMetadata>();
            num1 = 4;
            continue;
          case 10:
            goto label_53;
          default:
            try
            {
label_42:
              if (enumerator2.MoveNext())
                goto label_36;
              else
                goto label_43;
label_35:
              System.Type current;
              System.Type key;
              List<System.Type> typeList;
              InterfaceExtensionAttribute attribute;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    this.autoImplementExtensions.Add(key, typeList);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    key = DynamicModelAssemblyBuilder.AoSXarha6On05NFyMisn((object) attribute);
                    num4 = 9;
                    continue;
                  case 3:
                    typeList = new List<System.Type>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                    continue;
                  case 4:
                    goto label_36;
                  case 5:
                  case 7:
                    goto label_42;
                  case 6:
                    this.autoImplementInterfaces.Add(current);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 5 : 0;
                    continue;
                  case 8:
                    goto label_32;
                  case 9:
                    if (this.autoImplementExtensions.TryGetValue(key, out typeList))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 9 : 10;
                      continue;
                    }
                    goto case 3;
                  case 11:
                    if (attribute != null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
                      continue;
                    }
                    goto case 6;
                  case 12:
                    attribute = AttributeHelper<InterfaceExtensionAttribute>.GetAttribute(current, false);
                    num4 = 11;
                    continue;
                  default:
                    typeList.Add(current);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 7;
                    continue;
                }
              }
label_36:
              current = enumerator2.Current;
              num4 = 5;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
              {
                num4 = 12;
                goto label_35;
              }
              else
                goto label_35;
label_43:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 4 : 8;
              goto label_35;
            }
            finally
            {
              enumerator2.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
        }
      }
label_55:
      return;
label_53:;
    }

    /// <summary>Построить метаданные</summary>
    private void BuildMetadata()
    {
      int num1 = 3;
      List<EntityMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
label_23:
            this.metadataBuilt = true;
            num1 = 5;
            continue;
          case 2:
            this.Init();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 5 : 6;
            continue;
          case 3:
            if (!this.metadataBuilt)
            {
              num1 = 2;
              continue;
            }
            goto label_16;
          case 4:
            try
            {
label_10:
              if (enumerator.MoveNext())
                goto label_9;
              else
                goto label_11;
label_5:
              EntityMetadata current;
              List<EntityMetadata> extensions;
              EntityMetadata implementationMetadata;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    implementationMetadata = current.CreateInterfaceImplementationMetadata(extensions);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 2;
                    continue;
                  case 2:
                    this.metadataList.Add(implementationMetadata);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_9;
                  case 4:
                    goto label_23;
                  case 5:
                    this.intfExtMetadataByBaseUid.TryGetValue(DynamicModelAssemblyBuilder.v668wMhawoSEvLmmVSgU((object) current), out extensions);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_10;
                }
              }
label_9:
              current = enumerator.Current;
              num2 = 5;
              goto label_5;
label_11:
              num2 = 4;
              goto label_5;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 5:
            goto label_18;
          case 6:
            DynamicModelAssemblyBuilder.HqfnTZhaHwTZMdld7p1W((object) this.metadataList);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 7 : 3;
            continue;
          case 7:
            enumerator = this.intfMetadataList.GetEnumerator();
            num1 = 4;
            continue;
          default:
            goto label_12;
        }
      }
label_2:
      return;
label_18:
      return;
label_12:
      return;
label_16:;
    }

    private EntityMetadata GetRootMetadata(EntityMetadata metadata)
    {
      int num = 1;
      EntityMetadata metadata1;
      while (true)
      {
        AbstractMetadata abstractMetadata;
        EntityMetadata entityMetadata;
        switch (num)
        {
          case 1:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 2:
            entityMetadata = abstractMetadata as EntityMetadata;
            break;
          case 3:
            entityMetadata = (EntityMetadata) null;
            break;
          case 4:
            goto label_14;
          case 5:
            if (metadata1 != null)
            {
              num = 7;
              continue;
            }
            goto label_15;
          case 7:
            if (metadata1.Type == EntityMetadataType.Interface)
            {
              num = 4;
              continue;
            }
            goto label_15;
          case 8:
            if (DynamicModelAssemblyBuilder.odC5JVhakUdJCuNO7489((object) metadata) == Guid.Empty)
            {
              num = 6;
              continue;
            }
            if (this.metadataDict.TryGetValue(DynamicModelAssemblyBuilder.odC5JVhakUdJCuNO7489((object) metadata), out abstractMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 1;
              continue;
            }
            goto case 3;
          default:
            goto label_4;
        }
        metadata1 = entityMetadata;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 5 : 4;
      }
label_4:
      return metadata;
label_14:
      return metadata1;
label_15:
      return this.GetRootMetadata(metadata1);
    }

    private void LoadPreviousHashCodes()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            if (this.PreviousAssemblyRawStream == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            goto label_9;
          case 3:
            goto label_12;
          case 4:
            if (DynamicModelAssemblyBuilder.cbdYp3haATSAp2Vc3syw((object) this.PreviousAssemblyRawStream) == 0L)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 2;
              continue;
            }
            Collection<Mono.Cecil.CustomAttribute> customAttributes = ((AssemblyDefinition) DynamicModelAssemblyBuilder.TP5cThha71gB6VayLtS4((object) this.PreviousAssemblyRawStream)).CustomAttributes;
            // ISSUE: reference to a compiler-generated field
            Func<Mono.Cecil.CustomAttribute, bool> func1 = DynamicModelAssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__60_0;
            Func<Mono.Cecil.CustomAttribute, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              DynamicModelAssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__60_0 = predicate = (Func<Mono.Cecil.CustomAttribute, bool>) (a => (string) DynamicModelAssemblyBuilder.\u003C\u003Ec.wy28UavijnddwxbePcDd((object) ((MemberReference) DynamicModelAssemblyBuilder.\u003C\u003Ec.a8qWUVvi52VvhQkjmyDK((object) a)).DeclaringType) == (string) DynamicModelAssemblyBuilder.\u003C\u003Ec.pNW1rDviY7FUbmjCZN8P());
            }
            else
              goto label_16;
label_11:
            IEnumerable<Mono.Cecil.CustomAttribute> source = customAttributes.Where<Mono.Cecil.CustomAttribute>(predicate);
            // ISSUE: reference to a compiler-generated field
            Func<Mono.Cecil.CustomAttribute, string> func2 = DynamicModelAssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__60_1;
            Func<Mono.Cecil.CustomAttribute, string> keySelector;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              DynamicModelAssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__60_1 = keySelector = (Func<Mono.Cecil.CustomAttribute, string>) (a =>
              {
                int num2 = 1;
                CustomAttributeArgument constructorArgument;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      constructorArgument = a.ConstructorArguments[0];
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return (string) constructorArgument.Value;
              });
            }
            else
              goto label_15;
label_14:
            this.previousHashCodes = source.ToDictionary<Mono.Cecil.CustomAttribute, string, string>(keySelector, (Func<Mono.Cecil.CustomAttribute, string>) (a =>
            {
              int num3 = 1;
              CustomAttributeArgument constructorArgument;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    constructorArgument = a.ConstructorArguments[1];
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              return (string) constructorArgument.Value;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 2;
            continue;
label_15:
            keySelector = func2;
            goto label_14;
label_16:
            predicate = func1;
            goto label_11;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_9:
      return;
label_12:
      return;
label_7:;
    }

    private static void SaveDocumentationAction(
      object buffer,
      int offset,
      int length,
      (string, int, string) param)
    {
      (string s, int num, string fileName) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      object bytes = buffer;
      int offset1 = offset;
      int length1 = length;
      TimeSpan interval = TimeSpan.FromSeconds(1.0);
      int attemptCount = num;
      IOExtensions.WriteAllBytesWithAttempts(fileName, (byte[]) bytes, offset1, length1, interval, attemptCount);
    }

    static DynamicModelAssemblyBuilder()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DynamicModelAssemblyBuilder.aNQ4YghaxGw05BHxuLTg();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            DynamicModelAssemblyBuilder.configurationModelUids = new ContextVars.Local<ISet<Guid>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 2;
            continue;
          default:
            DynamicModelAssemblyBuilder.publishLogger = Logger.GetLogger((string) DynamicModelAssemblyBuilder.l4D9FhhaS8J19aT9wPkH(277947046 - -1479185048 ^ 1756932862));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static object q3IiYOhaCAIAMKgUtNvQ() => (object) Encoding.UTF8;

    internal static object vE9FRkhavkKPH7kdCuwi([In] object obj0, [In] object obj1) => (object) ((MemoryStream) obj0).AsString((Encoding) obj1);

    internal static object gQretDha8nfaTB4cSgVU([In] object obj0) => (object) ((MemoryStream) obj0).AsNoClose();

    internal static void Cofr9ThaZLXMnPpmEowT([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static void LgX8AJhaurSqYuJhBjZf([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static long s0oFVHhaI4AlnDLMiMwS([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static bool MICNNvhafv7YPgmKE2C8() => DynamicModelAssemblyBuilder.egNBONhaE4FMnt2XTXQI == null;

    internal static DynamicModelAssemblyBuilder vm4JkVhaQECl2UUWB6Pk() => DynamicModelAssemblyBuilder.egNBONhaE4FMnt2XTXQI;

    internal static object LfsVCShaV3V4nLuhwhHM([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object l4D9FhhaS8J19aT9wPkH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool ACxYYZhaiS3DGZRSOTud([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool IkhYyVhaRudvT5HiQkbE([In] object obj0) => Directory.Exists((string) obj0);

    internal static object arIUWLhaqnbnn5fnrUIm([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static int wi1pXEhaKDNWChfV8qyu([In] object obj0, [In] object obj1) => ((Encoding) obj0).GetByteCount((string) obj1);

    internal static object XNSp4ahaXprqPnEwCUlu() => (object) ComponentManager.Current;

    internal static bool SuRoGJhaTZfggrnIdNDk([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static Guid odC5JVhakUdJCuNO7489([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static EntityMetadataType iHYrKBhan5LfQDiJL97X([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static object mJj07yhaOXgr1nA6qOUx([In] object obj0) => (object) AssemblyInfoCache.EvaluateHashCode((Assembly) obj0);

    internal static object CVd0kOha2himyiiqiqGE([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static bool keBv8nhae82wXipOxyuL([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid ShNQRehaPIGFxkbFBMbg([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static object Hb4OCIha1RJm3y1XHHaM([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object sGl6QMhaN7bEblXDM0sj([In] object obj0) => (object) AssemblyInfoCache.EvaluateHashCode((Stream) obj0);

    internal static object MRQ3tIha3evmYqDcLxFf([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static void wMvFPghapbPn7FVsP1L0([In] object obj0) => __nonvirtual (((Stream) obj0).Dispose());

    internal static object xr9tZuhaaEkNTA4r1x00(int requiredSize) => (object) MemoryHelper.GetMemoryStream(requiredSize);

    internal static void yjdNNShaDeNs8F17g3hn([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static int LmYERChatWF1tS31Anhn([In] object obj0) => ((Dictionary<string, string>) obj0).Count;

    internal static Guid v668wMhawoSEvLmmVSgU([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool prLwSbha4RMTXuZQR00F([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static System.Type AoSXarha6On05NFyMisn([In] object obj0) => ((InterfaceExtensionAttribute) obj0).ExtendedInterfaceType;

    internal static void HqfnTZhaHwTZMdld7p1W([In] object obj0) => ((List<EntityMetadata>) obj0).Clear();

    internal static long cbdYp3haATSAp2Vc3syw([In] object obj0) => ((Stream) obj0).Length;

    internal static object TP5cThha71gB6VayLtS4([In] object obj0) => (object) AssemblyDefinition.ReadAssembly((Stream) obj0);

    internal static void aNQ4YghaxGw05BHxuLTg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class MetadataInfo
    {
      internal static object M1cShAvixQQruoS77xoJ;

      public EntityMetadata Metadata
      {
        get => this.\u003CMetadata\u003Ek__BackingField;
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
                this.\u003CMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

      public System.Type Type
      {
        get => this.\u003CType\u003Ek__BackingField;
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
                this.\u003CType\u003Ek__BackingField = value;
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

      public MetadataInfo()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool Ql6xCUvi0eXre4eOkbtc() => DynamicModelAssemblyBuilder.MetadataInfo.M1cShAvixQQruoS77xoJ == null;

      internal static DynamicModelAssemblyBuilder.MetadataInfo o6Tm0HvimMMPJOjFAdRZ() => (DynamicModelAssemblyBuilder.MetadataInfo) DynamicModelAssemblyBuilder.MetadataInfo.M1cShAvixQQruoS77xoJ;
    }
  }
}
