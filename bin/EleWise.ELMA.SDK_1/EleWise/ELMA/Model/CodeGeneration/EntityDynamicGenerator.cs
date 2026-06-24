// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EntityDynamicGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Генератор кода сущности с внутренним контейнером на основе метаданных
  /// </summary>
  public class EntityDynamicGenerator : EntityGenerator
  {
    private static readonly int AccessorClassNamePostfixLength;
    private static IDictionary<string, IDictionary<string, TypeReference>> configurationModelProperties;
    private static readonly System.Type CreatorType;
    private static readonly ILogger PublishLogger;
    private static readonly IDictionary<string, MethodReference> ReplaceMethods;
    private static readonly IDictionary<string, TypeReference> ReplaceTypes;
    /// <summary>Флаг генерации EntityDynamic</summary>
    [ThreadStatic]
    private static bool isEntityDynamicGenerating;
    internal const string DataClassName = "Data͏";
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string DataEntityFieldName = "entity͏";
    [EditorBrowsable(EditorBrowsableState.Never)]
    public const string ResolveDataMethodName = "ResolveData͏";
    private ISet<string> csScripts;
    private ISyntaxNode dataCtor;
    private IList<ISyntaxNode> dataInterfaceMembers;
    private IList<ISyntaxNode> dataClassMembers;
    private static EntityDynamicGenerator C511m3hkDxih6u0pCvk4;

    /// <summary>Загрузить дельта-сборку</summary>
    /// <param name="assemblyRaw">Оригинальная дельта-сборка</param>
    /// <param name="changedTypes">Изменненные типы сборки</param>
    /// <param name="newTypes">Новые типы сборки</param>
    /// <returns>Сборка</returns>
    internal static Assembly LoadDeltaAssembly(
      MemoryStream assemblyRaw,
      out IEnumerable<System.Type> changedTypes,
      out IEnumerable<System.Type> newTypes)
    {
      int num = 5;
      EntityDynamicGenerator.AssemblyResolver assemblyResolver;
      AssemblyDefinition assemblyDefinition;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 3:
          case 6:
            if (EntityDynamicGenerator.iEqA3LhkmuHDBqZnIkvq((object) ComponentManager.FindLoadedAssembly((string) EntityDynamicGenerator.AsNnoJhk0j4rprL1pWdc((object) assemblyDefinition), true), (object) null))
            {
              num = 2;
              continue;
            }
            goto label_3;
          case 4:
            assemblyDefinition = (AssemblyDefinition) EntityDynamicGenerator.eonSTThk4E7EQOr98lKN((object) assemblyRaw, (object) new ReaderParameters()
            {
              AssemblyResolver = (IAssemblyResolver) assemblyResolver
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 4 : 6;
            continue;
          case 5:
            assemblyResolver = new EntityDynamicGenerator.AssemblyResolver();
            num = 4;
            continue;
          default:
            EntityDynamicGenerator.ybpkLYhkx6U2rQqwMxNP(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition), (object) new Version(((AssemblyNameReference) EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition)).Version.Major, EntityDynamicGenerator.BiLU2VhkATEw6kjqVkLx(EntityDynamicGenerator.r3TPvHhkHpuap4HlX5O8(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition))), EntityDynamicGenerator.E11vVMhk729qg4RhV6V6(EntityDynamicGenerator.r3TPvHhkHpuap4HlX5O8(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition))), ((Version) EntityDynamicGenerator.r3TPvHhkHpuap4HlX5O8(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition))).Revision + 1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 3;
            continue;
        }
      }
label_3:
      EntityDynamicGenerator.DeltaAssemblyProcessor assemblyProcessor = new EntityDynamicGenerator.DeltaAssemblyProcessor((ModuleDefinition) EntityDynamicGenerator.NNxEjmhkyEwD9BWgkfBY((object) assemblyDefinition));
      EntityDynamicGenerator.Xakg6EhkMGJI3disi1jI((object) assemblyProcessor);
      MemoryStream memoryStream = (MemoryStream) EntityDynamicGenerator.j3moPjhkJfBAnjtd3BiK();
      EntityDynamicGenerator.YW4wC5hk9KsWtvtaV1XY((object) assemblyDefinition, (object) memoryStream);
      EntityDynamicGenerator.MU2aP8hkdxC4Yk7IqUQh((object) memoryStream, 0L, SeekOrigin.Begin);
      return assemblyProcessor.PostProcess((Assembly) EntityDynamicGenerator.u0RVOMhklXaIAWFamFWj((object) memoryStream, (object) null), out changedTypes, out newTypes);
    }

    /// <summary>
    /// Удалить интерфейсы расширений системных метаданных и фильтры
    /// </summary>
    /// <param name="assemblyRaw">Сборка DynamicModel</param>
    /// <param name="systemExtendedMetadata">Расширения системных метаданных</param>
    /// <param name="filterableMetadata">Фильтруемые метаданные</param>
    /// <returns>Исправленная сборка</returns>
    internal static MemoryStream RemoveDynamicTypes(
      MemoryStream assemblyRaw,
      IEnumerable<IMetadata> systemExtendedMetadata,
      IEnumerable<IMetadata> filterableMetadata)
    {
      EntityDynamicGenerator.AssemblyResolver assemblyResolver = new EntityDynamicGenerator.AssemblyResolver();
      AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly((Stream) assemblyRaw, new ReaderParameters()
      {
        AssemblyResolver = (IAssemblyResolver) assemblyResolver
      });
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      Dictionary<string, string> typeNames = systemExtendedMetadata.Cast<ClassMetadata>().ToDictionary<ClassMetadata, string, string>((Func<ClassMetadata, string>) (m => (string) EntityDynamicGenerator.\u003C\u003Ec.CDkIJHvQKDW95mUmlkiW((object) m.Namespace, EntityDynamicGenerator.\u003C\u003Ec.Tgs9RuvQq5pEfWSAs3bn(277947046 - -1479185048 ^ 1757130746), (object) m.Name)), (Func<ClassMetadata, string>) (m => (string) EntityDynamicGenerator.\u003C\u003Ec.GRXT7fvQTCiVt8htb3is(EntityDynamicGenerator.\u003C\u003Ec.REbcGxvQXIaEDRZpTfW2((object) m))));
      filterableMetadata.Cast<ClassMetadata>().ForEach<ClassMetadata>((Action<ClassMetadata>) (m =>
      {
        int num = 1;
        string key;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              key = (string) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.lwqOeavQEOhEyarApQLJ(EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.F17iBgvQbtKAPiiqvJng((object) m), EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.RSenmevQhIhDjc0puSZC(1994213607 >> 4 ^ 124636746), EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.aBtdIjvQGustxrHHVa28((object) m));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              string str;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              typeNames.Add(key + (string) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.RSenmevQhIhDjc0puSZC(-488881205 ^ -488898313), (string) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.EvyPdZvQQXsVpv8dCbFQ(!typeNames.TryGetValue(key, out str) ? EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.NnfPn9vQfodCIR6xla1I((object) m) : (object) str, EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.RSenmevQhIhDjc0puSZC(1470998129 - 231418599 ^ 1239562422)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 1;
              continue;
          }
        }
label_4:;
      }));
      // ISSUE: reference to a compiler-generated method
      foreach (TypeDefinition typeDefinition1 in assemblyDefinition.MainModule.Types.Where<TypeDefinition>((Func<TypeDefinition, bool>) (t => typeNames.ContainsKey((string) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_0.daqEUhvQCpLdVMwWX4Fs((object) t)))).ToArray<TypeDefinition>())
      {
        string interfaceName = typeNames[typeDefinition1.FullName];
        // ISSUE: reference to a compiler-generated method
        if (typeDefinition1.Interfaces.SingleOrDefault<TypeReference>((Func<TypeReference, bool>) (i => EntityDynamicGenerator.\u003C\u003Ec__DisplayClass3_1.YGevEivQIr7YSGslp5on((object) i.FullName, (object) interfaceName))) is TypeDefinition typeDefinition2)
        {
          typeDefinition1.Interfaces.Remove((TypeReference) typeDefinition2);
          assemblyDefinition.MainModule.Types.Remove(typeDefinition2);
        }
      }
      MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
      assemblyDefinition.Write((Stream) memoryStream);
      memoryStream.Seek(0L, SeekOrigin.Begin);
      return memoryStream;
    }

    private static void SetCreator(System.Type entityType, System.Type dataClassType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            System.Type type = EntityDynamicGenerator.CreatorType.MakeGenericType(entityType);
            MethodInfo method = dataClassType.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669229551));
            object name = EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(1470440286 ^ 1470524726);
            EntityDynamicGenerator.E3DvSnhkg14KJsj2wGOF((object) type.GetMethod((string) name, BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(entityType.GetNestedType((string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(964881585 - -1459193222 ^ -1870709577), BindingFlags.NonPublic)), (object) null, (object) new object[2]
            {
              method.Invoke((object) null, (object[]) null),
              (object) dataClassType
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static AssemblyNameReference CreateReference(object name)
    {
      int num1 = 1;
      EntityDynamicGenerator.CloneScope cloneScope;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cloneScope = new EntityDynamicGenerator.CloneScope();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      AssemblyNameReference reference;
      return reference;
label_4:
      try
      {
        AssemblyNameReference assemblyNameReference;
        int num2;
        if (cloneScope.TryGetAssemblyNameReference((string) EntityDynamicGenerator.Q4L8MNhk5vu7cNYiJAPh(name), (Version) EntityDynamicGenerator.ivqncshkj5Tt6q9RGxYY(name), out assemblyNameReference))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
        else
          goto label_12;
label_7:
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
              reference = assemblyNameReference;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 5 : 3;
              continue;
            case 2:
              EntityDynamicGenerator.zEXsNXhkcmTSKAgeHCUd((object) assemblyNameReference, (object) ((System.Reflection.AssemblyName) name).GetPublicKeyToken());
              num2 = 6;
              continue;
            case 3:
              EntityDynamicGenerator.L8DslRhksqtmYKrx3wLy((object) assemblyNameReference, EntityDynamicGenerator.uosokNhkUQeNnqL4MbA8(name).HasFlag((Enum) AssemblyNameFlags.Retargetable));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 2;
              continue;
            case 4:
              goto label_12;
            case 5:
              goto label_3;
            default:
              EntityDynamicGenerator.KrQUpWhkL2ft7QNheeJZ((object) assemblyNameReference, (AssemblyHashAlgorithm) ((System.Reflection.AssemblyName) name).HashAlgorithm);
              num2 = 3;
              continue;
          }
        }
label_12:
        assemblyNameReference.Culture = (string) EntityDynamicGenerator.s1uE7bhkYP8YX1NbM01V(name);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        {
          num2 = 0;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        if (cloneScope != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                EntityDynamicGenerator.tNcLjRhkzumcZrtq5X5u((object) cloneScope);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    private static TypeReference CreateReference(System.Type type)
    {
      int num1 = 1;
      EntityDynamicGenerator.CloneScope cloneScope;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cloneScope = new EntityDynamicGenerator.CloneScope();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_2;
        }
      }
label_2:
      TypeReference reference;
      try
      {
        TypeReference typeReference;
        cloneScope.TryGetTypeReference((string) EntityDynamicGenerator.qk78g7hnFlRgPdbvtOID((object) type.FullName, '+', '/'), type.Namespace, (string) EntityDynamicGenerator.tyblcIhnB7rUgH0mbXRr((object) type), (IMetadataScope) EntityDynamicGenerator.l9JSaAhno456rwu0XE9d(EntityDynamicGenerator.J4YrL5hnWD3sjkq0DINm((object) type.Assembly)), type.IsValueType, out typeReference);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              reference = (TypeReference) EntityDynamicGenerator.oI2MPOhnbKqkeYbZqJ9h((object) cloneScope, (object) typeReference);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        if (cloneScope != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_12;
              default:
                EntityDynamicGenerator.tNcLjRhkzumcZrtq5X5u((object) cloneScope);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_12:;
      }
label_14:
      return reference;
    }

    private static MethodReference CreateReference(object method)
    {
      int num1 = 1;
      EntityDynamicGenerator.CloneScope cloneScope;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cloneScope = new EntityDynamicGenerator.CloneScope();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          default:
            goto label_2;
        }
      }
label_2:
      MethodReference reference;
      try
      {
        MethodReference methodReference1 = new MethodReference((string) EntityDynamicGenerator.tyblcIhnB7rUgH0mbXRr(method), (TypeReference) EntityDynamicGenerator.JvlmUhhnGMDjcsLAgBhk(EntityDynamicGenerator.f3tMUwhnhMyGbcp34OdJ(method)), (TypeReference) EntityDynamicGenerator.JvlmUhhnGMDjcsLAgBhk(((MemberInfo) method).DeclaringType));
        EntityDynamicGenerator.amL2IUhnfxBSmBR7EZex((object) methodReference1, EntityDynamicGenerator.rbHFDRhnE2GY4HupLoBY(method).HasFlag((Enum) CallingConventions.HasThis));
        EntityDynamicGenerator.eIckYihnQpwNiGKo9sYN((object) methodReference1, EntityDynamicGenerator.rbHFDRhnE2GY4HupLoBY(method).HasFlag((Enum) CallingConventions.ExplicitThis));
        EntityDynamicGenerator.jiuNWjhnCUtNoMAmBlRC((object) methodReference1, MethodCallingConvention.Default);
        MethodReference methodReference2 = methodReference1;
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              // ISSUE: reference to a compiler-generated method
              ((IEnumerable<System.Reflection.ParameterInfo>) EntityDynamicGenerator.SkgmXOhnvs2sMIyGtQpc(method)).Select<System.Reflection.ParameterInfo, ParameterDefinition>((Func<System.Reflection.ParameterInfo, ParameterDefinition>) (p => new ParameterDefinition((TypeReference) EntityDynamicGenerator.\u003C\u003Ec.UHFo8pvQk48HWdxjVvIo(p.ParameterType)))).ForEach<ParameterDefinition>(new Action<ParameterDefinition>(methodReference2.Parameters.Add));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            default:
              reference = methodReference2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
              continue;
          }
        }
      }
      finally
      {
        if (cloneScope != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_13;
              default:
                cloneScope.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_13:;
      }
label_15:
      return reference;
    }

    private static AssemblyNameReference CreateReference(object name)
    {
      int num1 = 2;
      EntityDynamicGenerator.CloneScope cloneScope;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            cloneScope = new EntityDynamicGenerator.CloneScope();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      AssemblyNameReference reference;
      return reference;
label_4:
      try
      {
        AssemblyNameReference assemblyNameReference;
        int num2;
        if (cloneScope.TryGetAssemblyNameReference((string) EntityDynamicGenerator.o8xwr1hn8QFrgSQawYTL(name), ((AssemblyNameReference) name).Version, out assemblyNameReference))
          num2 = 11;
        else
          goto label_13;
label_6:
        while (true)
        {
          byte[] numArray;
          int num3;
          switch (num2)
          {
            case 1:
            case 3:
            case 11:
              reference = assemblyNameReference;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 4 : 7;
              continue;
            case 2:
              EntityDynamicGenerator.BKCVPqhnVhtIHFwcG8jA(EntityDynamicGenerator.r2vLb2hnI8WhkjRBsatI(name), (object) numArray, 0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            case 4:
              EntityDynamicGenerator.KrQUpWhkL2ft7QNheeJZ((object) assemblyNameReference, ((AssemblyNameReference) name).HashAlgorithm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 9 : 6;
              continue;
            case 5:
              object obj = EntityDynamicGenerator.r2vLb2hnI8WhkjRBsatI(name);
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 10;
                continue;
              }
              num3 = obj.Length != 0 ? 1 : 0;
              break;
            case 6:
label_7:
              numArray = new byte[EntityDynamicGenerator.r2vLb2hnI8WhkjRBsatI(name).Length];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 2;
              continue;
            case 7:
              goto label_2;
            case 8:
              goto label_13;
            case 9:
              EntityDynamicGenerator.L8DslRhksqtmYKrx3wLy((object) assemblyNameReference, EntityDynamicGenerator.syFZfChnuR3gD6oEGH58(name));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 5;
              continue;
            case 10:
              num3 = 0;
              break;
            default:
              EntityDynamicGenerator.zEXsNXhkcmTSKAgeHCUd((object) assemblyNameReference, (object) numArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
              continue;
          }
          if (num3 == 0)
            num2 = 3;
          else
            goto label_7;
        }
label_13:
        EntityDynamicGenerator.QvXIZuhnZl9ZH18gcyJc((object) assemblyNameReference, (object) ((AssemblyNameReference) name).Culture);
        num2 = 4;
        goto label_6;
      }
      finally
      {
        if (cloneScope != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                EntityDynamicGenerator.tNcLjRhkzumcZrtq5X5u((object) cloneScope);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
    }

    private static IMetadataScope CreateReference(object scope)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(scope is AssemblyNameReference assemblyNameReference))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          default:
            goto label_4;
        }
      }
label_4:
      object obj = EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) ((ModuleDefinition) scope).Assembly);
label_5:
      return (IMetadataScope) EntityDynamicGenerator.wQ5Zt3hnSKhywmgQWoi0(obj);
label_6:
      obj = (object) assemblyNameReference;
      goto label_5;
    }

    internal static TypeReference CreateReference(TypeReference type) => EntityDynamicGenerator.CreateReference((object) type, (Func<GenericParameter, GenericParameter>) null);

    private static TypeReference CreateReference(
      object type,
      Func<GenericParameter, GenericParameter> genericParameterResolver)
    {
      using (EntityDynamicGenerator.CloneScope cloneScope = new EntityDynamicGenerator.CloneScope())
      {
        switch ((TypeReference) type)
        {
          case ArrayType arrayType2:
            ArrayType arrayType1 = new ArrayType(EntityDynamicGenerator.CreateReference((object) arrayType2.ElementType, genericParameterResolver));
            if (!arrayType2.IsVector)
            {
              arrayType1.Dimensions.Clear();
              arrayType2.Dimensions.Select<ArrayDimension, ArrayDimension>((Func<ArrayDimension, ArrayDimension>) (d => new ArrayDimension(d.LowerBound, d.UpperBound))).ForEach<ArrayDimension>(new Action<ArrayDimension>(arrayType1.Dimensions.Add));
            }
            return cloneScope.Import((TypeReference) arrayType1);
          case PointerType pointerType:
            return cloneScope.Import((TypeReference) new PointerType(EntityDynamicGenerator.CreateReference((object) pointerType.ElementType, genericParameterResolver)));
          case ByReferenceType byReferenceType:
            return cloneScope.Import((TypeReference) new ByReferenceType(EntityDynamicGenerator.CreateReference((object) byReferenceType.ElementType, genericParameterResolver)));
          case PinnedType pinnedType:
            return cloneScope.Import((TypeReference) new PinnedType(EntityDynamicGenerator.CreateReference((object) pinnedType.ElementType, genericParameterResolver)));
          case SentinelType sentinelType:
            return cloneScope.Import((TypeReference) new SentinelType(EntityDynamicGenerator.CreateReference((object) sentinelType.ElementType, genericParameterResolver)));
          case OptionalModifierType optionalModifierType:
            return cloneScope.Import((TypeReference) new OptionalModifierType(EntityDynamicGenerator.CreateReference((object) optionalModifierType.ModifierType, genericParameterResolver), EntityDynamicGenerator.CreateReference((object) optionalModifierType.ElementType, genericParameterResolver)));
          case RequiredModifierType requiredModifierType:
            return cloneScope.Import((TypeReference) new RequiredModifierType(EntityDynamicGenerator.CreateReference((object) requiredModifierType.ModifierType, genericParameterResolver), EntityDynamicGenerator.CreateReference((object) requiredModifierType.ElementType, genericParameterResolver)));
          case GenericInstanceType genericInstanceType2:
            GenericInstanceType genericInstanceType1 = new GenericInstanceType(EntityDynamicGenerator.CreateReference(genericInstanceType2.ElementType));
            genericInstanceType2.GenericArguments.Select<TypeReference, TypeReference>((Func<TypeReference, TypeReference>) (a => EntityDynamicGenerator.CreateReference((object) a, genericParameterResolver))).ForEach<TypeReference>(new Action<TypeReference>(genericInstanceType1.GenericArguments.Add));
            return cloneScope.Import((TypeReference) genericInstanceType1);
          case GenericParameter genericParameter:
            Func<GenericParameter, GenericParameter> func = genericParameterResolver;
            return (TypeReference) ((func != null ? func(genericParameter) : (GenericParameter) null) ?? throw new NotSupportedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561126412)));
          default:
            TypeReference reference;
            if (!cloneScope.TryGetTypeReference(((MemberReference) type).FullName, ((TypeReference) type).Namespace, ((MemberReference) type).Name, EntityDynamicGenerator.CreateReference((object) ((TypeReference) type).Scope), ((TypeReference) type).IsValueType, out reference))
            {
              if (((TypeReference) type).IsNested)
                reference.DeclaringType = EntityDynamicGenerator.CreateReference(((MemberReference) type).DeclaringType);
              if (((TypeReference) type).HasGenericParameters)
              {
                // ISSUE: reference to a compiler-generated method
                ((TypeReference) type).GenericParameters.Select<GenericParameter, GenericParameter>((Func<GenericParameter, GenericParameter>) (p => new GenericParameter((string) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass16_1.AEEKFkvQ5kpXXJDjgc5U((object) p), (IGenericParameterProvider) reference))).ForEach<GenericParameter>(new Action<GenericParameter>(reference.GenericParameters.Add));
              }
              reference = cloneScope.Import(reference);
            }
            return reference;
        }
      }
    }

    internal static System.Type Resolve(TypeReference type)
    {
      int num1 = 26;
      System.Type type1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          TypeReference typeReference;
          System.Type type2;
          switch (num2)
          {
            case 1:
            case 7:
            case 23:
              goto label_40;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 4;
              continue;
            case 3:
            case 15:
              num2 = 13;
              continue;
            case 4:
              goto label_3;
            case 5:
              if (typeReference is ArrayType arrayType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 3 : 0;
                continue;
              }
              goto default;
            case 6:
              if (typeReference is ByReferenceType byReferenceType)
              {
                num2 = 27;
                continue;
              }
              goto case 10;
            case 8:
              if (typeReference is GenericInstanceType genericInstanceType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 2;
                continue;
              }
              goto case 21;
            case 9:
              goto label_4;
            case 10:
              if (!(typeReference is PinnedType _))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 10 : 24;
                continue;
              }
              goto label_31;
            case 11:
              goto label_34;
            case 12:
              if (typeReference is RequiredModifierType _)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 11 : 4;
                continue;
              }
              goto case 8;
            case 13:
              goto label_28;
            case 14:
              System.Type type3 = EntityDynamicGenerator.iRZ96shnRtiPlIIchpNs(EntityDynamicGenerator.LdH5vfhnO6EQ5e4ytaxo((object) type));
              if ((object) type3 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 11 : 28;
                continue;
              }
              type2 = type3.GetNestedType((string) EntityDynamicGenerator.kLX18Ahn2UGIsgI90Krv((object) type), BindingFlags.Public | BindingFlags.NonPublic);
              break;
            case 16:
              if (!(typeReference is OptionalModifierType _))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 12 : 8;
                continue;
              }
              goto label_33;
            case 17:
              if (!EntityDynamicGenerator.OYTKwyhnnm0mC72xGd1p((object) type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                continue;
              }
              goto case 14;
            case 18:
              type1 = ReflectionType.GetType((string) EntityDynamicGenerator.hJ2KTshnTG9rxiU91BuJ(EntityDynamicGenerator.qk78g7hnFlRgPdbvtOID(EntityDynamicGenerator.Ofp4m0hnKhKS8lVhbBkZ((object) type), '/', '+'), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917259400), EntityDynamicGenerator.cWAOhIhnXlY19adVMb14((object) type)));
              num2 = 22;
              continue;
            case 19:
              goto label_29;
            case 20:
              goto label_32;
            case 21:
              if (!(typeReference is GenericParameter _))
              {
                num2 = 18;
                continue;
              }
              goto label_4;
            case 22:
              if (!EntityDynamicGenerator.QwsILFhnkkeNjevxqvGL(type1, (System.Type) null))
              {
                num2 = 23;
                continue;
              }
              goto case 17;
            case 24:
              if (!(typeReference is SentinelType _))
                goto case 16;
              else
                goto label_39;
            case 25:
              if (typeReference != null)
              {
                num2 = 5;
                continue;
              }
              goto case 18;
            case 26:
              typeReference = type;
              num2 = 25;
              continue;
            case 27:
              goto label_30;
            case 28:
              type2 = (System.Type) null;
              break;
            default:
              if (typeReference is PointerType pointerType)
              {
                num2 = 19;
                continue;
              }
              goto case 6;
          }
          type1 = type2;
          num2 = 7;
        }
label_39:
        num1 = 20;
      }
label_3:
      return EntityDynamicGenerator.iRZ96shnRtiPlIIchpNs(EntityDynamicGenerator.h9y15jhnifgRJAE2wDrn((object) genericInstanceType)).MakeGenericType(genericInstanceType.GenericArguments.Select<TypeReference, System.Type>(new Func<TypeReference, System.Type>(EntityDynamicGenerator.Resolve)).ToArray<System.Type>());
label_4:
      throw new NotSupportedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439398566));
label_28:
      return EntityDynamicGenerator.iRZ96shnRtiPlIIchpNs(EntityDynamicGenerator.h9y15jhnifgRJAE2wDrn((object) arrayType)).MakeArrayType(EntityDynamicGenerator.LCb6BqhnqEgZoVpNs8AQ((object) arrayType));
label_29:
      return EntityDynamicGenerator.iRZ96shnRtiPlIIchpNs((object) pointerType.ElementType).MakePointerType();
label_30:
      return EntityDynamicGenerator.iRZ96shnRtiPlIIchpNs((object) byReferenceType.ElementType).MakeByRefType();
label_31:
      throw new NotSupportedException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105281230));
label_32:
      throw new NotSupportedException((string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-2138958856 ^ -2139005700));
label_33:
      throw new NotSupportedException((string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-1445902765 ^ -1980277732 ^ 539317619));
label_34:
      throw new NotSupportedException((string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(901793403 ^ 901974527));
label_40:
      return type1;
    }

    internal static MethodReference CreateReference(
      MethodReference method,
      TypeReference declaringType = null,
      ModuleDefinition module = null)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      EntityDynamicGenerator.\u003C\u003Ec__DisplayClass18_0 cDisplayClass180;
      EntityDynamicGenerator.CloneScope cloneScope;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass180.declaringType = declaringType;
            num1 = 3;
            continue;
          case 2:
            goto label_5;
          case 3:
            cloneScope = new EntityDynamicGenerator.CloneScope(module);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass180.method = method;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          case 5:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass180 = new EntityDynamicGenerator.\u003C\u003Ec__DisplayClass18_0();
            num1 = 4;
            continue;
          default:
            goto label_7;
        }
      }
label_5:
      MethodReference reference;
      return reference;
label_7:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        EntityDynamicGenerator.\u003C\u003Ec__DisplayClass18_1 cDisplayClass181 = new EntityDynamicGenerator.\u003C\u003Ec__DisplayClass18_1();
        int num2 = 3;
        while (true)
        {
          int num3;
          GenericInstanceMethod genericInstanceMethod;
          MethodReference methodReference1;
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: method pointer
              EntityDynamicGenerator.XB2NxnhnD5OO0PA9xyxd((object) cDisplayClass181.reference, (object) EntityDynamicGenerator.CreateReference(EntityDynamicGenerator.LxKIANhn1G8BE9oV6iei((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method), new Func<GenericParameter, GenericParameter>((object) cDisplayClass181, __methodptr(\u003CCreateReference\u003Eg__GenericParameterResolver\u007C2))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 4 : 6;
              continue;
            case 2:
              reference = (MethodReference) genericInstanceMethod;
              num2 = 15;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass181.CS\u0024\u003C\u003E8__locals1 = cDisplayClass180;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 4:
            case 15:
              goto label_5;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated field
              cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method.Parameters.Select<ParameterDefinition, ParameterDefinition>(new Func<ParameterDefinition, ParameterDefinition>(cDisplayClass181.\u003CCreateReference\u003Eb__1)).ForEach<ParameterDefinition>(new Action<ParameterDefinition>(cDisplayClass181.reference.Parameters.Add));
              num2 = 11;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (!EntityDynamicGenerator.tShT2uhntpun8GmBD0O0((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method))
              {
                num2 = 16;
                continue;
              }
              goto case 5;
            case 7:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              MethodReference methodReference2 = new MethodReference((string) EntityDynamicGenerator.kLX18Ahn2UGIsgI90Krv((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method), (TypeReference) EntityDynamicGenerator.LxKIANhn1G8BE9oV6iei((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method), cDisplayClass181.CS\u0024\u003C\u003E8__locals1.declaringType);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              EntityDynamicGenerator.amL2IUhnfxBSmBR7EZex((object) methodReference2, EntityDynamicGenerator.WiUJAjhnNUNPeIv6Nd2q((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method));
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              EntityDynamicGenerator.eIckYihnQpwNiGKo9sYN((object) methodReference2, EntityDynamicGenerator.JiZx8xhn3aVY27d17ln3((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method));
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              EntityDynamicGenerator.jiuNWjhnCUtNoMAmBlRC((object) methodReference2, EntityDynamicGenerator.jJu9iOhnpLhulQdTiq30((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method));
              // ISSUE: reference to a compiler-generated field
              cDisplayClass181.reference = methodReference2;
              num2 = 13;
              continue;
            case 8:
              methodReference1 = (MethodReference) null;
              goto label_29;
            case 9:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass181.CS\u0024\u003C\u003E8__locals1.declaringType = (TypeReference) ((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.declaringType ?? EntityDynamicGenerator.dEerjphnPjn7FcxFYbXZ(EntityDynamicGenerator.LdH5vfhnO6EQ5e4ytaxo((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method)));
              num3 = 7;
              break;
            case 10:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              GenericInstanceMethod method1 = (GenericInstanceMethod) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method;
              genericInstanceMethod = new GenericInstanceMethod(EntityDynamicGenerator.CreateReference(method1.ElementMethod, (TypeReference) null, (ModuleDefinition) null));
              method1.GenericArguments.Select<TypeReference, TypeReference>(new Func<TypeReference, TypeReference>(EntityDynamicGenerator.CreateReference)).ForEach<TypeReference>(new Action<TypeReference>(genericInstanceMethod.GenericArguments.Add));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 1;
              continue;
            case 11:
            case 16:
              if (module == null)
              {
                num2 = 8;
                continue;
              }
              // ISSUE: reference to a compiler-generated field
              methodReference1 = module.Import(cDisplayClass181.reference);
              goto label_29;
            case 12:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated field
              cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method.GenericParameters.Select<GenericParameter, GenericParameter>(new Func<GenericParameter, GenericParameter>(cDisplayClass181.\u003CCreateReference\u003Eb__0)).ForEach<GenericParameter>(new Action<GenericParameter>(cDisplayClass181.reference.GenericParameters.Add));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
              continue;
            case 13:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (EntityDynamicGenerator.WLvp2mhnaT0cacECS6yp((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method))
              {
                num2 = 12;
                continue;
              }
              goto case 1;
            case 14:
              // ISSUE: reference to a compiler-generated field
              methodReference1 = cDisplayClass181.reference;
              goto label_32;
            default:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (EntityDynamicGenerator.ou9hK2hnecrPsmYkXx7w((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.method))
              {
                num3 = 10;
                break;
              }
              goto case 9;
          }
label_9:
          num2 = num3;
          continue;
label_29:
          if (methodReference1 == null)
          {
            num2 = 14;
            continue;
          }
label_32:
          reference = methodReference1;
          num3 = 4;
          goto label_9;
        }
      }
      finally
      {
        if (cloneScope != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                cloneScope.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
    }

    private static string AssemblyName(object typeReference)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        IMetadataScope metadataScope;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (metadataScope != null)
              {
                num2 = 5;
                continue;
              }
              goto label_5;
            case 2:
              metadataScope = (IMetadataScope) EntityDynamicGenerator.bycSo2hnwnQC3Ubt5XTN(typeReference);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_8;
            case 4:
              goto label_4;
            case 5:
              if (!(metadataScope is AssemblyNameReference assemblyNameReference))
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            default:
              goto label_3;
          }
        }
label_8:
        if (metadataScope is ModuleDefinition moduleDefinition)
          num1 = 4;
        else
          goto label_5;
      }
label_3:
      return (string) EntityDynamicGenerator.MWThlghn49KGlBcfmwJx((object) assemblyNameReference);
label_4:
      return (string) EntityDynamicGenerator.MWThlghn49KGlBcfmwJx(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) moduleDefinition.Assembly));
label_5:
      throw new NotImplementedException();
    }

    private byte[] RewriteCSScripts(byte[] data, ISet<string> csScripts)
    {
      if (csScripts.Count == 0)
        return data;
      CompilationUnitSyntax compilationUnitRoot = SyntaxFactory.ParseSyntaxTree(SourceText.From(data, data.Length), (ParseOptions) null, "", (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()).GetCompilationUnitRoot();
      ClassDeclarationSyntax[] array1 = compilationUnitRoot.DescendantNodes().OfType<ClassDeclarationSyntax>().Where<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (c =>
      {
        int num = 1;
        SyntaxToken syntaxToken;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              syntaxToken = EntityDynamicGenerator.\u003C\u003Ec.SYcKRuvQnjT1AboPDiEd((object) c);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        return syntaxToken.ValueText == (string) EntityDynamicGenerator.\u003C\u003Ec.Tgs9RuvQq5pEfWSAs3bn(95909607 + 343705423 ^ 439401484);
      })).ToArray<ClassDeclarationSyntax>();
      if (array1.Length == 0)
      {
        EntityDynamicGenerator.PublishLogger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87548997), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439401484), (object) Environment.NewLine, (object) Encoding.UTF8.GetString(data));
        return data;
      }
      // ISSUE: reference to a compiler-generated method
      PropertyDeclarationSyntax[] array2 = ((IEnumerable<ClassDeclarationSyntax>) array1).SelectMany<ClassDeclarationSyntax, MemberDeclarationSyntax>((Func<ClassDeclarationSyntax, IEnumerable<MemberDeclarationSyntax>>) (c => (IEnumerable<MemberDeclarationSyntax>) c.Members)).OfType<PropertyDeclarationSyntax>().Where<PropertyDeclarationSyntax>((Func<PropertyDeclarationSyntax, bool>) (p => csScripts.Contains(EntityDynamicGenerator.\u003C\u003Ec__DisplayClass23_0.HJHP7xvCEsvnqX0SST5i((object) p).ValueText))).ToArray<PropertyDeclarationSyntax>();
      if (array2.Length == 0)
        return data;
      EntityDynamicGenerator.IdentifierRewriter identifierRewriter = new EntityDynamicGenerator.IdentifierRewriter(this);
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
      {
        using (StreamWriter streamWriter = new StreamWriter((Stream) memoryStream.AsNoClose()))
          ((SyntaxNode) compilationUnitRoot.ReplaceNodes<CompilationUnitSyntax, PropertyDeclarationSyntax>((IEnumerable<PropertyDeclarationSyntax>) array2, (Func<PropertyDeclarationSyntax, PropertyDeclarationSyntax, SyntaxNode>) ((o, r) => identifierRewriter.Visit((SyntaxNode) o)))).SyntaxTree.GetText().Write((TextWriter) streamWriter);
        return memoryStream.ToArray();
      }
    }

    static EntityDynamicGenerator()
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
              EntityDynamicGenerator.ReplaceTypes = PublishCacheContext.CreateCache<string, TypeReference>();
              num2 = 5;
              continue;
            case 2:
              // ISSUE: type reference
              EntityDynamicGenerator.CreatorType = EntityDynamicGenerator.ahs6yrhnAd4G7pxVVsxB(__typeref (Creator<>));
              num2 = 6;
              continue;
            case 3:
              EntityDynamicGenerator.AccessorClassNamePostfixLength = EntityDynamicGenerator.BY9XIHhnHqi0quIsV0Ks(EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(372753449 ^ 372544565));
              num2 = 7;
              continue;
            case 4:
              EntityDynamicGenerator.JNuy0Nhn6Or8X7R3ZkVZ();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 3;
              continue;
            case 5:
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              EntityDynamicGenerator.ReplaceMethods[(string) EntityDynamicGenerator.X4WaZKhnxGUP3rTQy1sm() + (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(1470998129 - 231418599 ^ 1239560872) + (string) EntityDynamicGenerator.oqmjfShn0JZU8r1EAQPq() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61244891)] = (MethodReference) EntityDynamicGenerator.bpUg2NhnmAsdhiRYT1c4((object) __nonvirtual (EntityDynamicGenerator.ahs6yrhnAd4G7pxVVsxB(__typeref (EntityDynamicExtensions)).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597188320))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 8 : 8;
              continue;
            case 6:
              EntityDynamicGenerator.PublishLogger = (ILogger) EntityDynamicGenerator.M0S5U0hn75XaSWyQJutH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461566553));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            case 7:
              EntityDynamicGenerator.configurationModelProperties = PublishCacheContext.CreateCache<string, IDictionary<string, TypeReference>>((Func<IDictionary<string, IDictionary<string, TypeReference>>, IDictionary<string, IDictionary<string, TypeReference>>>) (_ => (IDictionary<string, IDictionary<string, TypeReference>>) new Dictionary<string, IDictionary<string, TypeReference>>()), onComplete: (Action<IDictionary<string, IDictionary<string, TypeReference>>>) (_ => _.Clear()), onCancel: (Action<IDictionary<string, IDictionary<string, TypeReference>>>) (_ => _.Clear()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 2;
              continue;
            case 8:
              goto label_5;
            case 9:
              goto label_3;
            default:
              EntityDynamicGenerator.ReplaceMethods = PublishCacheContext.CreateCache<string, MethodReference>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
              continue;
          }
        }
label_5:
        // ISSUE: type reference
        // ISSUE: explicit non-virtual call
        EntityDynamicGenerator.ReplaceMethods[(string) EntityDynamicGenerator.Pw7fsqhny3B22cJQgTQk((object) System.Reflection.TypeOf.Void) + (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(2045296739 + 1688595713 ^ -561060794) + TypeOf<IInheritable>.FullName + (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-1598106783 - -968262081 ^ -629799604) + (string) EntityDynamicGenerator.X4WaZKhnxGUP3rTQy1sm() + (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-951514650 ^ -951511462)] = EntityDynamicGenerator.CreateReference((object) __nonvirtual (EntityDynamicGenerator.ahs6yrhnAd4G7pxVVsxB(__typeref (EntityDynamicExtensions)).GetMethod((string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(647913418 ^ 647827268))));
        num1 = 9;
      }
label_3:;
    }

    private static void AddReplace(object typeName, object type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityDynamicGenerator.ReplaceTypes[(string) typeName] = (TypeReference) type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void AddReplace(object methodName, object method)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityDynamicGenerator.ReplaceMethods[(string) methodName] = (MethodReference) method;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static bool ContainsReplace(object method) => EntityDynamicGenerator.ReplaceMethods.ContainsKey((string) EntityDynamicGenerator.keXJsnhnMwyfCU8Tu0Zh(method));

    private static bool ContainsReplace(object type) => EntityDynamicGenerator.ReplaceTypes.ContainsKey((string) EntityDynamicGenerator.Ofp4m0hnKhKS8lVhbBkZ(type));

    private static bool TryGetReplace(object fromMethod, out MethodReference toMethod) => EntityDynamicGenerator.ReplaceMethods.TryGetValue((string) (EntityDynamicGenerator.keXJsnhnMwyfCU8Tu0Zh(fromMethod) ?? (object) string.Empty), out toMethod);

    private static bool TryGetReplace(object fromType, out TypeReference toType) => EntityDynamicGenerator.ReplaceTypes.TryGetValue((string) ((fromType != null ? EntityDynamicGenerator.Ofp4m0hnKhKS8lVhbBkZ(fromType) : (object) null) ?? (object) string.Empty), out toType);

    private static string TypeName(object type)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_2;
          case 3:
            if (!(type is GenericInstanceType genericInstanceType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 4:
            if (!(type is GenericParameter genericParameter))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_2:
      return (string) EntityDynamicGenerator.e9MT9YhnJ1cJVENhQULv(EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(1654249598 >> 2 ^ 413476537), (object) genericParameter.Position);
label_7:
      return (string) EntityDynamicGenerator.s0N42whndrdPVcyTJ75J(EntityDynamicGenerator.F5e4CIhn9pERVVBPIW10((object) genericInstanceType.ElementType), EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(993438473 ^ 993453263), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124618366), genericInstanceType.GenericArguments.Select<TypeReference, string>(new Func<TypeReference, string>(EntityDynamicGenerator.TypeName))), EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(1232639661 >> 3 ^ 154098965));
label_8:
      return ((MemberReference) type).FullName;
    }

    private static string MethodName(object method)
    {
      int num1 = 3;
      TypeReference typeReference;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              typeReference = genericInstanceType.ElementType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              if (method != null)
              {
                num2 = 2;
                continue;
              }
              goto label_6;
            case 4:
              goto label_6;
            case 5:
              if (typeReference is GenericInstanceType genericInstanceType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
                continue;
              }
              goto label_10;
            default:
              goto label_10;
          }
        }
label_7:
        typeReference = ((MemberReference) method).DeclaringType;
        num1 = 5;
      }
label_6:
      return (string) null;
label_10:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (string) EntityDynamicGenerator.x1sAH6hnlV7amNoNuvfv((object) new string[8]
      {
        (string) EntityDynamicGenerator.F5e4CIhn9pERVVBPIW10(EntityDynamicGenerator.LxKIANhn1G8BE9oV6iei(method)),
        (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-643786247 ^ -643772197),
        (string) EntityDynamicGenerator.F5e4CIhn9pERVVBPIW10((object) typeReference),
        (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(1819636893 << 3 ^ 1672103054),
        (string) EntityDynamicGenerator.kLX18Ahn2UGIsgI90Krv(method),
        (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(~541731958 ^ -541733825),
        string.Join((string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-1921202237 ^ -1921215181), ((MethodReference) method).Parameters.Select<ParameterDefinition, string>((Func<ParameterDefinition, string>) (p => (string) EntityDynamicGenerator.\u003C\u003Ec.jkmkVfvQ2XGH0L15HmsU(EntityDynamicGenerator.\u003C\u003Ec.kp6J73vQOGLXhU97Rgq2((object) p))))),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538523734)
      });
    }

    /// <summary>Проверить сборку и внести изменения в IL-код</summary>
    /// <param name="assemblyRaw">Поток, содержащий бинарный код сборки</param>
    /// <returns>Поток, содержащий исправленный бинарный код сборки</returns>
    public static MemoryStream CheckAssembly(MemoryStream assemblyRaw)
    {
      int num1 = 20;
      MemoryStream memoryStream;
      while (true)
      {
        int num2 = num1;
        List<AssemblyNameReference> list;
        ModuleDefinition module;
        IEnumerator<TypeReference> enumerator;
        AssemblyDefinition assemblyDefinition;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!((string) EntityDynamicGenerator.o8xwr1hn8QFrgSQawYTL(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition)) == (string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-2092274397 << 4 ^ 883350492)))
              {
                module = (ModuleDefinition) EntityDynamicGenerator.NNxEjmhkyEwD9BWgkfBY((object) assemblyDefinition);
                num2 = 21;
                continue;
              }
              num2 = 14;
              continue;
            case 2:
            case 14:
            case 18:
              goto label_8;
            case 3:
              enumerator = module.GetTypeReferences().GetEnumerator();
              num2 = 10;
              continue;
            case 4:
              if (EntityDynamicGenerator.uY8Yg2hn5di72k4aOt8I((object) assemblyDefinition.Name.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852835744)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 2;
                continue;
              }
              goto case 16;
            case 5:
              if (!module.GetMemberReferences().OfType<MethodReference>().Any<MethodReference>(new Func<MethodReference, bool>(EntityDynamicGenerator.ContainsReplace)))
              {
                num2 = 13;
                continue;
              }
              goto label_51;
            case 6:
              goto label_3;
            case 7:
label_19:
              memoryStream = (MemoryStream) EntityDynamicGenerator.j3moPjhkJfBAnjtd3BiK();
              num2 = 15;
              continue;
            case 8:
              assemblyDefinition = (AssemblyDefinition) EntityDynamicGenerator.eonSTThk4E7EQOr98lKN((object) assemblyRaw, (object) new ReaderParameters()
              {
                AssemblyResolver = (IAssemblyResolver) new EntityDynamicGenerator.AssemblyResolver()
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 4 : 3;
              continue;
            case 9:
              goto label_23;
            case 10:
              try
              {
label_33:
                if (enumerator.MoveNext())
                  goto label_37;
                else
                  goto label_34;
label_29:
                TypeReference current;
                TypeReference typeReference;
                TypeReference toType;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      EntityDynamicGenerator.m6Xci2hnL17pVeQHSnXI((object) current, EntityDynamicGenerator.LdH5vfhnO6EQ5e4ytaxo((object) typeReference));
                      num3 = 3;
                      continue;
                    case 2:
                      typeReference = (TypeReference) EntityDynamicGenerator.rlLnDohnYQkcwMWBUxCL((object) module, (object) toType);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                      continue;
                    case 3:
                      EntityDynamicGenerator.OkwYh8hnUSTaE31L5XcY((object) current, EntityDynamicGenerator.bycSo2hnwnQC3Ubt5XTN((object) typeReference));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 4 : 5;
                      continue;
                    case 4:
                      if (!EntityDynamicGenerator.TryGetReplace((object) current, out toType))
                      {
                        num3 = 7;
                        continue;
                      }
                      goto case 2;
                    case 5:
                    case 7:
                      goto label_33;
                    case 6:
                      goto label_37;
                    default:
                      goto label_19;
                  }
                }
label_34:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                goto label_29;
label_37:
                current = enumerator.Current;
                num3 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
                {
                  num3 = 3;
                  goto label_29;
                }
                else
                  goto label_29;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                else
                  goto label_42;
label_41:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_42:
                enumerator.Dispose();
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                {
                  num4 = 1;
                  goto label_41;
                }
                else
                  goto label_41;
              }
            case 11:
              if (!EntityDynamicGenerator.uY8Yg2hn5di72k4aOt8I(EntityDynamicGenerator.o8xwr1hn8QFrgSQawYTL(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138957210)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                continue;
              }
              goto label_8;
            case 12:
              EntityDynamicGenerator.MU2aP8hkdxC4Yk7IqUQh((object) memoryStream, 0L, SeekOrigin.Begin);
              num2 = 9;
              continue;
            case 13:
              goto label_50;
            case 15:
              assemblyDefinition.Write((Stream) memoryStream);
              num2 = 12;
              continue;
            case 16:
              if (EntityDynamicGenerator.uY8Yg2hn5di72k4aOt8I(EntityDynamicGenerator.o8xwr1hn8QFrgSQawYTL(EntityDynamicGenerator.SKuovGhk6fuKJCWWtcMA((object) assemblyDefinition)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138957354)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 6 : 18;
                continue;
              }
              goto case 11;
            case 17:
              if (module.GetTypeReferences().Any<TypeReference>(new Func<TypeReference, bool>(EntityDynamicGenerator.ContainsReplace)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 19:
              goto label_15;
            case 20:
              if (!EntityDynamicGenerator.pdc1nxhng8NbBTLjYhcF(EntityDynamicGenerator.kImPPthnrGgq6aBjF2vT(), (object) null))
              {
                assemblyRaw.Seek(0L, SeekOrigin.Begin);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 8 : 5;
                continue;
              }
              num2 = 19;
              continue;
            case 21:
              Collection<AssemblyNameReference> assemblyReferences = module.AssemblyReferences;
              // ISSUE: reference to a compiler-generated field
              Func<AssemblyNameReference, bool> func = EntityDynamicGenerator.\u003C\u003Ec.\u003C\u003E9__37_0;
              Func<AssemblyNameReference, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.\u003C\u003Ec.\u003C\u003E9__37_0 = predicate = (Func<AssemblyNameReference, bool>) (r =>
                {
                  int num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (EntityDynamicGenerator.\u003C\u003Ec.EMBgDDvQeVcYY7NiXHt7((object) r.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561076480)))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                          continue;
                        }
                        goto case 2;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        if (!EntityDynamicGenerator.\u003C\u003Ec.EMBgDDvQeVcYY7NiXHt7((object) r.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979451792)))
                        {
                          num5 = 3;
                          continue;
                        }
                        goto label_6;
                      case 3:
                        goto label_7;
                      default:
                        goto label_6;
                    }
                  }
label_6:
                  // ISSUE: reference to a compiler-generated method
                  return EntityDynamicGenerator.\u003C\u003Ec.kPGlrhvQPVSASU4lsTsH((object) r.Version, (object) ConfigurationModelAssemblyBuilder.Version);
label_7:
                  return false;
                });
              }
              else
                goto label_52;
label_49:
              list = assemblyReferences.Where<AssemblyNameReference>(predicate).ToList<AssemblyNameReference>();
              num2 = 6;
              continue;
label_52:
              predicate = func;
              goto label_49;
            case 22:
              EntityDynamicGenerator.UpdateModule((object) module, (IDictionary<TypeReference, TypeReference>) new Dictionary<TypeReference, TypeReference>(), (IDictionary<MethodReference, MethodReference>) new Dictionary<MethodReference, MethodReference>());
              num2 = 3;
              continue;
            default:
              goto label_51;
          }
        }
label_3:
        if (EntityDynamicGenerator.gqTmBLhnjx8eFrfardME((object) list) != 0)
        {
          num1 = 17;
          continue;
        }
        goto label_50;
label_51:
        list.ForEach((Action<AssemblyNameReference>) (r =>
        {
          int num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                EntityDynamicGenerator.\u003C\u003Ec.ajyZ1TvQNE8xOH2LDWqa((object) r, EntityDynamicGenerator.\u003C\u003Ec.qWOA2yvQ1xdiasybCKqy());
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        num1 = 22;
      }
label_8:
      return assemblyRaw;
label_15:
      return assemblyRaw;
label_23:
      return memoryStream;
label_50:
      return assemblyRaw;
    }

    private static void UpdateModule(
      object module,
      IDictionary<TypeReference, TypeReference> typesToReplace,
      IDictionary<MethodReference, MethodReference> methodsToReplace,
      IDictionary<FieldReference, FieldReference> fieldsToReplace = null,
      Func<TypeDefinition, bool> typesFilter = null)
    {
      ModuleDefinition module1 = (ModuleDefinition) module;
      IDictionary<MethodReference, MethodReference> methodsToReplace1 = methodsToReplace;
      IDictionary<FieldReference, FieldReference> fieldsToReplace1 = fieldsToReplace;
      Action<Mono.Cecil.CustomAttribute> action;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      module1.Types.Where<TypeDefinition>((Func<TypeDefinition, bool>) (t => EntityDynamicGenerator.\u003C\u003Ec.uaeVYSvQp7yp7t2hFTCj(EntityDynamicGenerator.\u003C\u003Ec.Q46l0QvQ3xOse1EsHGsW((object) t), (object) "<Module>"))).SelectRecursive<TypeDefinition>((Func<TypeDefinition, IEnumerable<TypeDefinition>>) (t => (IEnumerable<TypeDefinition>) t.NestedTypes)).If<TypeDefinition>(typesFilter != null, (Func<IEnumerable<TypeDefinition>, IEnumerable<TypeDefinition>>) (_ => _.Where<TypeDefinition>(typesFilter))).ForEach<TypeDefinition>((Action<TypeDefinition>) (tr =>
      {
        int num6 = 1;
        while (true)
        {
          switch (num6)
          {
            case 1:
              Collection<Mono.Cecil.CustomAttribute> customAttributes = tr.CustomAttributes;
              Collection<PropertyDefinition> properties = tr.Properties;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyDefinition, IEnumerable<Mono.Cecil.CustomAttribute>> func = EntityDynamicGenerator.\u003C\u003Ec.\u003C\u003E9__38_4;
              Func<PropertyDefinition, IEnumerable<Mono.Cecil.CustomAttribute>> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.\u003C\u003Ec.\u003C\u003E9__38_4 = selector = (Func<PropertyDefinition, IEnumerable<Mono.Cecil.CustomAttribute>>) (p => (IEnumerable<Mono.Cecil.CustomAttribute>) p.CustomAttributes);
              }
              else
                goto label_7;
label_4:
              IEnumerable<Mono.Cecil.CustomAttribute> second = properties.SelectMany<PropertyDefinition, Mono.Cecil.CustomAttribute>(selector);
              IEnumerable<Mono.Cecil.CustomAttribute> enumeration = customAttributes.Concat<Mono.Cecil.CustomAttribute>(second).Concat<Mono.Cecil.CustomAttribute>(tr.Methods.SelectMany<MethodDefinition, Mono.Cecil.CustomAttribute>((Func<MethodDefinition, IEnumerable<Mono.Cecil.CustomAttribute>>) (p => (IEnumerable<Mono.Cecil.CustomAttribute>) p.CustomAttributes)));
              Action<Mono.Cecil.CustomAttribute> action1 = action;
              Action<Mono.Cecil.CustomAttribute> action2 = action1 == null ? (action = (Action<Mono.Cecil.CustomAttribute>) (attr =>
              {
                int num7 = 7;
                while (true)
                {
                  int num8 = num7;
                  int index3;
                  CustomAttributeArgument constructorArgument;
                  TypeReference replaceTo;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        goto label_7;
                      case 3:
                        goto label_6;
                      case 4:
                        if (!(constructorArgument.Value is TypeReference typeReference2))
                          goto case 5;
                        else
                          goto label_14;
                      case 5:
                        ++index3;
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 8;
                        continue;
                      case 6:
                      case 8:
                        // ISSUE: reference to a compiler-generated method
                        if (index3 < EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.cgjIa5vC8OUsnHHvQJqn((object) attr.ConstructorArguments))
                        {
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      case 7:
                        index3 = 0;
                        num8 = 6;
                        continue;
                      case 9:
                        if (EntityDynamicGenerator.CheckType(typesToReplace, (object) typeReference2, out replaceTo))
                        {
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                          continue;
                        }
                        goto case 5;
                      default:
                        constructorArgument = attr.ConstructorArguments[index3];
                        num8 = 4;
                        continue;
                    }
                  }
label_7:
                  Collection<CustomAttributeArgument> constructorArguments = attr.ConstructorArguments;
                  int index4 = index3;
                  constructorArgument = attr.ConstructorArguments[index3];
                  CustomAttributeArgument attributeArgument = new CustomAttributeArgument(constructorArgument.Type, (object) replaceTo);
                  constructorArguments[index4] = attributeArgument;
                  num7 = 5;
                  continue;
label_14:
                  num7 = 9;
                }
label_6:
                return;
label_5:;
              })) : action1;
              enumeration.ForEach<Mono.Cecil.CustomAttribute>(action2);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
label_7:
              selector = func;
              goto label_4;
            case 2:
              goto label_5;
            default:
              // ISSUE: reference to a compiler-generated method
              tr.Methods.Where<MethodDefinition>((Func<MethodDefinition, bool>) (m => EntityDynamicGenerator.\u003C\u003Ec.kudnTAvQaG2rWBEp0VcS((object) m))).SelectMany<MethodDefinition, Instruction>((Func<MethodDefinition, IEnumerable<Instruction>>) (m => (IEnumerable<Instruction>) m.Body.Instructions)).ForEach<Instruction>((Action<Instruction>) (i =>
              {
                int num9 = 16;
                while (true)
                {
                  int num10 = num9;
                  bool flag;
                  TypeReference replaceTo4;
                  MethodReference reference;
                  MethodReference toMethod;
                  FieldReference fieldReference;
                  TypeReference replaceTo5;
                  int index;
                  object operand;
                  GenericInstanceType declaringType;
                  // ISSUE: variable of a compiler-generated type
                  EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0 cDisplayClass380;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                      case 42:
                        if (operand is FieldReference key2)
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 51 : 12;
                          continue;
                        }
                        goto label_81;
                      case 2:
                      case 7:
                      case 69:
                        // ISSUE: reference to a compiler-generated method
                        if (EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.DdrY4kvCnbF0EeuCDDlE((object) methodReference2))
                        {
                          num10 = 3;
                          continue;
                        }
                        goto case 43;
                      case 3:
                        goto label_34;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        i.Operand = EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.GHuc5KvCirivv2NAW7Ys((object) module1, (object) methodReference2);
                        num10 = 71;
                        continue;
                      case 5:
                        reference.HasThis = true;
                        num10 = 41;
                        continue;
                      case 6:
                      case 17:
                      case 18:
                        if (flag)
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 4 : 4;
                          continue;
                        }
                        goto label_80;
                      case 8:
                        flag = true;
                        num10 = 13;
                        continue;
                      case 9:
                        i.Operand = (object) replaceTo5;
                        num10 = 49;
                        continue;
                      case 10:
                        cDisplayClass380 = this;
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 29 : 22;
                        continue;
                      case 11:
                        if (!EntityDynamicGenerator.CheckType(typesToReplace, (object) methodReference2.DeclaringType, out replaceTo4))
                        {
                          num10 = 69;
                          continue;
                        }
                        goto case 77;
                      case 12:
                        if (toMethod != null)
                        {
                          num10 = 67;
                          continue;
                        }
                        goto label_84;
                      case 13:
                      case 33:
                        index = 0;
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 13 : 64;
                        continue;
                      case 14:
                      case 56:
                        // ISSUE: reference to a compiler-generated method
                        toMethod = (MethodReference) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.GHuc5KvCirivv2NAW7Ys((object) module1, (object) toMethod);
                        num10 = 74;
                        continue;
                      case 15:
                        if (operand == null)
                        {
                          num10 = 44;
                          continue;
                        }
                        goto case 22;
                      case 16:
                        operand = i.Operand;
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 15 : 10;
                        continue;
                      case 19:
                        goto label_66;
                      case 20:
                      case 26:
                        if (!EntityDynamicGenerator.CheckType(typesToReplace, (object) methodReference2.DeclaringType, out replaceTo4))
                        {
                          num10 = 17;
                          continue;
                        }
                        goto case 36;
                      case 21:
                        if (!((MethodDefinition) methodReference2).IsConstructor)
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 7 : 5;
                          continue;
                        }
                        goto case 11;
                      case 22:
                        if (operand is TypeReference typeReference4)
                        {
                          num10 = 76;
                          continue;
                        }
                        goto case 30;
                      case 23:
                        if (EntityDynamicGenerator.CheckType(typesToReplace, (object) typeReference4, out replaceTo5))
                        {
                          num10 = 9;
                          continue;
                        }
                        goto case 30;
                      case 24:
                        genericInstanceMethod2.GenericArguments[index] = replaceTo4;
                        num10 = 58;
                        continue;
                      case 25:
                        goto label_83;
                      case 27:
                        if (!methodsToReplace1.TryGetValue(methodReference2, out toMethod))
                        {
                          if (!EntityDynamicGenerator.TryGetReplace((object) methodReference2, out toMethod))
                          {
                            num10 = 48;
                            continue;
                          }
                          goto case 50;
                        }
                        else
                          goto label_11;
                      case 28:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.iDTMOhvC2lF2YIqnF1Ue(EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.OquyLFvCONUASNKeiCuX((object) genericInstanceMethod2), (object) replaceTo4);
                        num10 = 8;
                        continue;
                      case 29:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        declaringType = new GenericInstanceType((TypeReference) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.VcOesSvCSL2R2FFcZEPc((object) module1, EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.Re70LuvCVPLZhFZChVdf((object) toMethod)));
                        num10 = 62;
                        continue;
                      case 30:
                        if (operand is MethodReference methodReference2)
                        {
                          num10 = 45;
                          continue;
                        }
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
                        continue;
                      case 31:
                        ++index;
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                        continue;
                      case 32:
                        // ISSUE: reference to a compiler-generated method
                        EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.gccMGpvCuc4oIVkhD2dT((object) i, (object) fieldReference);
                        num10 = 59;
                        continue;
                      case 34:
                        if (methodReference2 is GenericInstanceMethod genericInstanceMethod2)
                        {
                          num10 = 66;
                          continue;
                        }
                        goto case 20;
                      case 35:
                      case 74:
                        // ISSUE: reference to a compiler-generated method
                        EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.gccMGpvCuc4oIVkhD2dT((object) i, (object) (methodsToReplace1[methodReference2] = toMethod));
                        num10 = 72;
                        continue;
                      case 36:
                        methodReference2.DeclaringType = replaceTo4;
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 65 : 16;
                        continue;
                      case 37:
                        // ISSUE: reference to a compiler-generated method
                        EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.Ue4udWvCqRyRdBalWWTX((object) i, OpCodes.Call);
                        num10 = 73;
                        continue;
                      case 38:
                        i.OpCode = OpCodes.Call;
                        num10 = 63;
                        continue;
                      case 39:
                        // ISSUE: reference to a compiler-generated method
                        if (EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.LHnrVwvCI1hfAlLHiOfL(i.OpCode, OpCodes.Callvirt))
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 12 : 38;
                          continue;
                        }
                        goto label_82;
                      case 40:
                        if (fieldsToReplace1 == null)
                        {
                          num10 = 19;
                          continue;
                        }
                        goto case 53;
                      case 41:
                      case 68:
                        // ISSUE: reference to a compiler-generated method
                        i.Operand = (object) (methodsToReplace1[methodReference2] = (MethodReference) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.GHuc5KvCirivv2NAW7Ys((object) module1, (object) reference));
                        num10 = 75;
                        continue;
                      case 43:
                        flag = false;
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 57 : 27;
                        continue;
                      case 44:
                        goto label_63;
                      case 45:
                        // ISSUE: reference to a compiler-generated method
                        if (!EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.TlxaXHvCZ7qnBNHTAWuo((object) module1, (object) i))
                          goto case 27;
                        else
                          goto label_43;
                      case 46:
                        if (EntityDynamicGenerator.CheckType(typesToReplace, (object) genericInstanceMethod2.GenericArguments[index], out replaceTo4))
                        {
                          num10 = 24;
                          continue;
                        }
                        goto case 31;
                      case 47:
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 10 : 6;
                        continue;
                      case 48:
                        if (!methodReference2.IsDefinition)
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 1;
                          continue;
                        }
                        goto case 21;
                      case 49:
                        goto label_4;
                      case 50:
                        if (!(methodReference2.DeclaringType is GenericInstanceType declaringType2))
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 14 : 6;
                          continue;
                        }
                        goto case 47;
                      case 51:
                        goto label_5;
                      case 52:
                        goto label_62;
                      case 53:
                        if (fieldsToReplace1.TryGetValue(key2, out fieldReference))
                        {
                          num10 = 32;
                          continue;
                        }
                        goto label_86;
                      case 54:
                        toMethod = EntityDynamicGenerator.CreateReference(toMethod, (TypeReference) declaringType, module1);
                        num10 = 35;
                        continue;
                      case 55:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.SD1jpovCXS6FKJKtpIiw((object) reference, (object) ((TypeSystem) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.TNNJNlvCKLfHCETYhggb((object) module1)).Void);
                        num10 = 70;
                        continue;
                      case 57:
                        if (!methodReference2.IsGenericInstance)
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 7 : 20;
                          continue;
                        }
                        goto case 34;
                      case 58:
                        flag = true;
                        num10 = 31;
                        continue;
                      case 59:
                        goto label_57;
                      case 60:
                        goto label_96;
                      case 61:
                      case 76:
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 23 : 4;
                        continue;
                      case 62:
                        declaringType2.GenericArguments.ForEach<TypeReference>((Action<TypeReference>) (a =>
                        {
                          int num5 = 1;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 0:
                                goto label_4;
                              case 1:
                                TypeReference replaceTo3;
                                // ISSUE: reference to a compiler-generated field
                                declaringType.GenericArguments.Add(!EntityDynamicGenerator.CheckType(cDisplayClass380.typesToReplace, (object) a, out replaceTo3) ? a : replaceTo3);
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_2;
                            }
                          }
label_4:
                          return;
label_2:;
                        }));
                        num10 = 54;
                        continue;
                      case 63:
                        goto label_74;
                      case 65:
                        flag = true;
                        num10 = 18;
                        continue;
                      case 66:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!EntityDynamicGenerator.CheckType(typesToReplace, EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.Re70LuvCVPLZhFZChVdf(EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.OquyLFvCONUASNKeiCuX((object) genericInstanceMethod2)), out replaceTo4))
                        {
                          num10 = 33;
                          continue;
                        }
                        goto case 28;
                      case 67:
                        // ISSUE: reference to a compiler-generated method
                        EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.gccMGpvCuc4oIVkhD2dT((object) i, (object) toMethod);
                        num10 = 39;
                        continue;
                      case 70:
                        // ISSUE: reference to a compiler-generated method
                        if (EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.jxKq46vCTylVPnT1x1K5((object) reference))
                        {
                          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 6 : 68;
                          continue;
                        }
                        goto label_83;
                      case 71:
                        goto label_31;
                      case 72:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.LHnrVwvCI1hfAlLHiOfL(EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.noLHOIvCRwUODb4ljo1a((object) i), OpCodes.Callvirt))
                        {
                          num10 = 52;
                          continue;
                        }
                        goto case 37;
                      case 73:
                        goto label_68;
                      case 75:
                        goto label_77;
                      case 77:
                        reference = EntityDynamicGenerator.CreateReference(methodReference2, replaceTo4);
                        num10 = 55;
                        continue;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        if (index >= EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.wPSFmFvCe5Fe7iBfJB6e((object) genericInstanceMethod2.GenericArguments))
                        {
                          num10 = 6;
                          continue;
                        }
                        goto case 46;
                    }
                  }
label_5:
                  num9 = 40;
                  continue;
label_11:
                  num9 = 12;
                  continue;
label_31:
                  methodsToReplace1[methodReference2] = (MethodReference) null;
                  num9 = 60;
                  continue;
label_43:
                  num9 = 42;
                  continue;
label_83:
                  // ISSUE: reference to a compiler-generated method
                  reference.Name = (string) EntityDynamicGenerator.\u003C\u003Ec__DisplayClass38_0.iv9ixcvCkExuIcQhVurB(-1978478350 ^ -1978175820);
                  num9 = 5;
                }
label_34:
                return;
label_66:
                return;
label_63:
                return;
label_4:
                return;
label_62:
                return;
label_57:
                return;
label_96:
                return;
label_74:
                return;
label_68:
                return;
label_77:
                return;
label_86:
                return;
label_84:
                return;
label_82:
                return;
label_81:
                return;
label_80:;
              }));
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 1;
              continue;
          }
        }
label_5:;
      }));
    }

    private static bool CheckType(
      IDictionary<TypeReference, TypeReference> typesToReplace,
      object typeReference,
      out TypeReference replaceTo)
    {
      if (typeReference == null)
      {
        replaceTo = (TypeReference) null;
        return false;
      }
      if (typesToReplace.TryGetValue((TypeReference) typeReference, out replaceTo))
        return replaceTo != null;
      if (EntityDynamicGenerator.TryGetReplace(typeReference, out replaceTo))
      {
        typesToReplace[(TypeReference) typeReference] = replaceTo = ((MemberReference) typeReference).Module.Import(replaceTo);
        return true;
      }
      switch ((TypeReference) typeReference)
      {
        case ArrayType arrayType when EntityDynamicGenerator.CheckType(typesToReplace, (object) arrayType.ElementType, out replaceTo):
          typesToReplace[(TypeReference) typeReference] = replaceTo = ((MemberReference) typeReference).Module.Import((TypeReference) new ArrayType(replaceTo));
          return true;
        case ByReferenceType byReferenceType when EntityDynamicGenerator.CheckType(typesToReplace, (object) byReferenceType.ElementType, out replaceTo):
          typesToReplace[(TypeReference) typeReference] = replaceTo = ((MemberReference) typeReference).Module.Import((TypeReference) new ByReferenceType(replaceTo));
          return true;
        case GenericInstanceType genericInstanceType:
          bool flag = EntityDynamicGenerator.CheckType(typesToReplace, (object) genericInstanceType.ElementType, out replaceTo);
          GenericInstanceType type = new GenericInstanceType(flag ? replaceTo : genericInstanceType.ElementType);
          foreach (TypeReference genericArgument in genericInstanceType.GenericArguments)
          {
            if (EntityDynamicGenerator.CheckType(typesToReplace, (object) genericArgument, out replaceTo))
            {
              type.GenericArguments.Add(replaceTo);
              flag = true;
            }
            else
              type.GenericArguments.Add(genericArgument);
          }
          if (flag)
          {
            typesToReplace[(TypeReference) typeReference] = replaceTo = ((MemberReference) typeReference).Module.Import((TypeReference) type);
            return true;
          }
          break;
      }
      typesToReplace[(TypeReference) typeReference] = replaceTo = (TypeReference) null;
      return false;
    }

    /// <summary>Флаг генерации EntityDynamic</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool IsEntityDynamicGenerating
    {
      get
      {
        int num1 = 2;
        bool? publicationEnable;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_9;
              case 2:
                if (!EntityDynamicGenerator.isEntityDynamicGenerating)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
                  continue;
                }
                break;
              case 3:
                goto label_7;
              case 4:
                goto label_3;
            }
            publicationEnable = ReflectionType.DynamicPublicationEnable;
            num2 = 4;
          }
label_3:
          if (!publicationEnable.HasValue)
            num1 = 3;
          else
            goto label_8;
        }
label_7:
        return false;
label_8:
        return publicationEnable.GetValueOrDefault();
label_9:
        return false;
      }
    }

    private bool DynamicPublicationEnable
    {
      get
      {
        int num = 3;
        bool? publicationEnable;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!publicationEnable.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 4 : 3;
                continue;
              }
              goto label_3;
            case 2:
              goto label_4;
            case 3:
              if (EntityDynamicGenerator.D1hI47hns7WsrckyHJp7((object) this.metadata))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 0;
                continue;
              }
              break;
            case 4:
              goto label_2;
          }
          publicationEnable = ReflectionType.DynamicPublicationEnable;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
        }
label_2:
        return false;
label_3:
        return publicationEnable.GetValueOrDefault();
label_4:
        return false;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static GeneratedFileInfo RunAsDynamicGenerating(
      bool isEntityDynamicGenerating,
      Func<GeneratedFileInfo> action)
    {
      bool dynamicGenerating = EntityDynamicGenerator.isEntityDynamicGenerating;
      try
      {
        EntityDynamicGenerator.isEntityDynamicGenerating = isEntityDynamicGenerating;
        return action();
      }
      finally
      {
        EntityDynamicGenerator.isEntityDynamicGenerating = dynamicGenerating;
      }
    }

    /// <inheritdoc />
    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      GeneratedFileInfo mainFileInternal;
      switch (1)
      {
        case 1:
          try
          {
            this.csScripts = (ISet<string>) new HashSet<string>();
            int num1 = 4;
            while (true)
            {
              int num2;
              GeneratedFileInfo generatedFileInfo;
              switch (num1)
              {
                case 1:
                  EntityDynamicGenerator.O092mGhnzbsidBg7kRwD((object) generatedFileInfo, (object) this.RewriteCSScripts((byte[]) EntityDynamicGenerator.ExPxlIhnc6shpyR6usW6((object) generatedFileInfo), this.csScripts));
                  num2 = 3;
                  break;
                case 2:
                case 3:
                  mainFileInternal = generatedFileInfo;
                  num2 = 5;
                  break;
                case 4:
                  generatedFileInfo = EntityDynamicGenerator.RunAsDynamicGenerating(!EntityDynamicGenerator.D1hI47hns7WsrckyHJp7((object) this.metadata), new Func<GeneratedFileInfo>(((ClassGenerator) this).GenerateMainFileInternal));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                  continue;
                case 5:
                  goto label_1;
                default:
                  if (!this.DynamicPublicationEnable)
                  {
                    num2 = 2;
                    break;
                  }
                  goto case 1;
              }
              num1 = num2;
            }
          }
          finally
          {
            this.csScripts = (ISet<string>) null;
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
              num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  this.dataClassMembers = (IList<ISyntaxNode>) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                  continue;
                case 2:
                  this.dataCtor = (ISyntaxNode) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 0;
                  continue;
                case 3:
                  this.dataInterfaceMembers = (IList<ISyntaxNode>) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
                  continue;
                default:
                  goto label_16;
              }
            }
label_16:;
          }
      }
label_1:
      return mainFileInternal;
    }

    /// <inheritdoc />
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
    {
      bool dynamicGenerating = EntityDynamicGenerator.isEntityDynamicGenerating;
      try
      {
        EntityDynamicGenerator.isEntityDynamicGenerating = true;
        return base.GenerateAdditionalFilesInternal().Concat<GeneratedFileInfo>(this.GenerateConfigExt());
      }
      finally
      {
        EntityDynamicGenerator.isEntityDynamicGenerating = dynamicGenerating;
      }
    }

    private bool IsConfig(Guid uid)
    {
      int num = 1;
      ISet<Guid> configurationModelUids;
      while (true)
      {
        switch (num)
        {
          case 1:
            configurationModelUids = DynamicModelAssemblyBuilder.ConfigurationModelUids;
            if (configurationModelUids == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return true;
label_5:
      return configurationModelUids.Contains(uid);
    }

    private static string GetConfigExtTypeName(object typeName) => (string) EntityDynamicGenerator.IJGXnahOF6DHMQcNTTXB(typeName, EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(-2112703338 ^ -2112756700));

    private static string GetConfigExtTypeName(object metadata) => (string) EntityDynamicGenerator.HmKtEPhOW8h4nS67PRYR(EntityDynamicGenerator.bNUY8fhOBwdhH6GVVKQ4(metadata));

    private IEnumerable<GeneratedFileInfo> GenerateConfigExt() => (IEnumerable<GeneratedFileInfo>) new EntityDynamicGenerator.\u003CGenerateConfigExt\u003Ed__66(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <inheritdoc />
    protected override ISyntaxNode GetBasicEntity(ISyntaxNode idTypeRef)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.DynamicPublicationEnable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return base.GetBasicEntity(idTypeRef);
label_3:
      return EntityDynamicGenerator.w3AXI9hOoeG6fKLAS8BW((object) EleWise.ELMA.SDK.TypeOf.EntityDynamic1).CreateTypeSyntax(idTypeRef);
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetBaseInterfaces() => base.GetBaseInterfaces().If<ISyntaxNode>(this.DynamicPublicationEnable && !this.IsConfig(this.metadata.ImplementationUid) && !this.metadata.ImplementedExtensionUids.Any<Guid>(new Func<Guid, bool>(this.IsConfig)), (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (_ => _.Append<ISyntaxNode>(EntityDynamicGenerator.GetConfigExtTypeName((object) (EntityMetadata) MetadataServiceContext.Service.GetMetadata(this.metadata.ImplementationUid)).CreateTypeSyntax())));

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements)
    {
      if (!this.DynamicPublicationEnable)
        return base.GetCtors(ctorStatements);
      this.dataCtor = SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372544737).ParameterDeclaration(this.metadata.TypeName.CreateTypeSyntax())
      }, Accessibility.Public, statements: ctorStatements.Prepend<ISyntaxNode>(SyntaxGeneratorExtensions.This.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541686975)).AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867424059).IdentifierName())));
      return Enumerable.Empty<ISyntaxNode>();
    }

    /// <summary>Члены с данными</summary>
    /// <param name="members">Основные члены класса</param>
    /// <param name="type">Тип</param>
    /// <param name="getDataMethodName">Имя метода получения данных</param>
    /// <param name="resolveCreatorMethodName">Имя метода полуеченя креатора</param>
    /// <param name="generateConstructor">Генерировать конструктор</param>
    protected virtual IEnumerable<ISyntaxNode> DataMembers(
      IEnumerable<ISyntaxNode> members,
      ISyntaxNode type,
      string getDataMethodName,
      string resolveCreatorMethodName,
      bool generateConstructor = false)
    {
      return EntityDynamicGenerator.DataMembers(members, type, getDataMethodName, resolveCreatorMethodName, generateConstructor, (ClassMetadata) this.metadata, this.dataInterfaceMembers, this.dataClassMembers, this.dataCtor);
    }

    /// <summary>Члены с данными</summary>
    /// <param name="members">Основные члены класса</param>
    /// <param name="type">Тип</param>
    /// <param name="getDataMethodName">Имя метода получения данных</param>
    /// <param name="resolveCreatorMethodName">Имя метода полуеченя креатора</param>
    /// <param name="generateConstructor">Генерировать конструктор</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="dataInterfaceMembers">Члены типа интерфейса</param>
    /// <param name="dataClassMembers">Слены типа класса</param>
    /// <param name="dataCtor">Операторы конструктора</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<ISyntaxNode> DataMembers(
      IEnumerable<ISyntaxNode> members,
      ISyntaxNode type,
      string getDataMethodName,
      string resolveCreatorMethodName,
      bool generateConstructor,
      ClassMetadata metadata,
      IList<ISyntaxNode> dataInterfaceMembers,
      IList<ISyntaxNode> dataClassMembers,
      ISyntaxNode dataCtor)
    {
      return members.If<ISyntaxNode>(generateConstructor, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (_ => _.Prepend<ISyntaxNode>(SyntaxGeneratorExtensions.ConstructorDeclaration(Accessibility.Public, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360417527).IdentifierName().AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883262152).IdentifierName().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712496579)).InvocationExpression(SyntaxGeneratorExtensions.This))
      })))).Prepend<ISyntaxNode>(getDataMethodName.MethodDeclaration(returnType: TypeOf<IEnumerable<object>>.Raw.CreateTypeSyntax(), accessibility: Accessibility.Protected, modifiers: DeclarationModifiers.Override, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        typeof (Enumerable).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477348608)).InvocationExpression(SyntaxGeneratorExtensions.Base.MemberAccessExpression(getDataMethodName).InvocationExpression(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77739237).IdentifierName()).ReturnStatement()
      })).If<ISyntaxNode>(!generateConstructor, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (_ => _.Prepend<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87554753).MethodDeclaration(returnType: z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675293377).CreateTypeSyntax(), accessibility: Accessibility.Internal, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575932594).IdentifierName().CoalesceExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323297496).IdentifierName().AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939594636).IdentifierName().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124622586)).InvocationExpression(SyntaxGeneratorExtensions.This))).ReturnStatement()
      })))).Prepend<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236026149).FieldDeclaration(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289931030).CreateTypeSyntax(), generateConstructor ? Accessibility.Internal : Accessibility.Private, generateConstructor ? DeclarationModifiers.ReadOnly : DeclarationModifiers.None)).Prepend<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021455245).FieldDeclaration(typeof (ICreator<,>).CreateTypeSyntax(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398479396).CreateTypeSyntax()), Accessibility.Private, DeclarationModifiers.Static | DeclarationModifiers.ReadOnly, resolveCreatorMethodName.GenericName(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671908933).CreateTypeSyntax(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306667166).CreateTypeSyntax()).InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575937122).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633497567))))).Append<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978556814).InterfaceDeclaration(Accessibility.Internal, members: (IEnumerable<ISyntaxNode>) dataInterfaceMembers)).Append<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978531535).ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed, interfaceTypes: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470524894).CreateTypeSyntax()
      }, members: dataClassMembers.Prepend<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654281005).MethodDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921018101).ParameterDeclaration(type)
      }, returnType: z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475942279).CreateTypeSyntax(), accessibility: Accessibility.Internal, modifiers: DeclarationModifiers.Static, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099571347).CreateTypeSyntax().ObjectCreationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217576463).IdentifierName()).ReturnStatement()
      })).Prepend<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883331140).MethodDeclaration(returnType: System.Reflection.TypeOf.Func2.Raw.CreateTypeSyntax(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082319768).CreateTypeSyntax()), accessibility: Accessibility.Public, modifiers: DeclarationModifiers.Static, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405813823).IdentifierName().ReturnStatement()
      })).If<ISyntaxNode>(dataCtor != null, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (_ => _.Prepend<ISyntaxNode>(dataCtor))).Prepend<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195790371).FieldDeclaration(type, Accessibility.Private, DeclarationModifiers.ReadOnly)))).Concat<ISyntaxNode>(EntityDynamicGenerator.GettersSetter((object) type, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870712819).CreateTypeSyntax(), (object) metadata, dataInterfaceMembers));
    }

    private static IEnumerable<ISyntaxNode> GettersSetter(
      object ownerType,
      object dataClassType,
      object metadata,
      IList<ISyntaxNode> dataInterfaceMembers)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new EntityDynamicGenerator.\u003CGettersSetter\u003Ed__72(-2)
      {
        \u003C\u003E3__ownerType = (ISyntaxNode) ownerType,
        \u003C\u003E3__dataClassType = (ISyntaxNode) dataClassType,
        \u003C\u003E3__metadata = (ClassMetadata) metadata,
        \u003C\u003E3__dataInterfaceMembers = dataInterfaceMembers
      };
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers()
    {
      if (!this.DynamicPublicationEnable)
        return base.GetMembers();
      this.dataInterfaceMembers = (IList<ISyntaxNode>) new List<ISyntaxNode>();
      this.dataClassMembers = (IList<ISyntaxNode>) new List<ISyntaxNode>();
      return this.DataMembers((IEnumerable<ISyntaxNode>) base.GetMembers().ToArray<ISyntaxNode>(), this.metadata.TypeName.CreateTypeSyntax(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461580429), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461580465));
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> WriteProperty(
      PropertyMetadata propertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool writeAttributes = true,
      Action<ISyntaxNode> propertyAction = null)
    {
      if (!this.DynamicPublicationEnable)
        return base.WriteProperty(propertyMetadata, ctorStatements, writeAttributes, propertyAction);
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218947608));
      ITypeGenerationInfo propertyTypeDescriptor = (ITypeGenerationInfo) this.GetPropertyTypeDescriptor(propertyMetadata);
      ISyntaxNode propertyTypeReference = propertyTypeDescriptor.GetPropertyTypeReference((ClassMetadata) this.metadata, propertyMetadata, false);
      ISyntaxNode expression = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70246552).IdentifierName().InvocationExpression();
      IEnumerable<ISyntaxNode> syntaxNodes1;
      if (!propertyTypeDescriptor.HasPropertyGetter)
        syntaxNodes1 = (IEnumerable<ISyntaxNode>) null;
      else if (!this.metadata.IsInterfaceType)
        syntaxNodes1 = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          expression.MemberAccessExpression(propertyMetadata.Name).ReturnStatement()
        };
      else
        syntaxNodes1 = Enumerable.Empty<ISyntaxNode>();
      IEnumerable<ISyntaxNode> getAccessorStatements1 = syntaxNodes1;
      IEnumerable<ISyntaxNode> syntaxNodes2;
      if (!propertyTypeDescriptor.HasPropertySetter)
        syntaxNodes2 = (IEnumerable<ISyntaxNode>) null;
      else if (!this.metadata.IsInterfaceType)
        syntaxNodes2 = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          expression.MemberAccessExpression(propertyMetadata.Name).AssignmentStatement(SyntaxGeneratorExtensions.Value)
        };
      else
        syntaxNodes2 = Enumerable.Empty<ISyntaxNode>();
      IEnumerable<ISyntaxNode> setAccessorStatements1 = syntaxNodes2;
      ISyntaxNode syntaxNode = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements1, setAccessorStatements1);
      if (writeAttributes)
      {
        this.WritePropertyComments(syntaxNode, propertyMetadata);
        this.WritePropertyAttributes(syntaxNode, propertyMetadata, (string) null);
      }
      if (propertyAction != null)
        propertyAction(syntaxNode);
      string str = this.FieldName(propertyMetadata);
      if (!this.metadata.IsInterfaceType && propertyMetadata.CalculateType != PropertyCalculateType.CSScript)
        this.dataClassMembers.Add(str.FieldDeclaration(propertyTypeReference, Accessibility.Private));
      IEnumerable<ISyntaxNode> getAccessorStatements2;
      if (propertyTypeDescriptor.HasPropertyGetter)
      {
        if (propertyMetadata.CalculateType == PropertyCalculateType.CSScript)
        {
          this.csScripts.Add(propertyMetadata.Name);
          getAccessorStatements2 = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
          {
            propertyMetadata.CalculateScript.ParseExpression().ReturnStatement()
          };
        }
        else
          getAccessorStatements2 = this.GetPropertyGetterExpressions(propertyTypeDescriptor, propertyMetadata, str);
      }
      else
        getAccessorStatements2 = (IEnumerable<ISyntaxNode>) null;
      IEnumerable<ISyntaxNode> setAccessorStatements2 = !propertyTypeDescriptor.HasPropertySetter ? (IEnumerable<ISyntaxNode>) null : (propertyMetadata.CalculateType != PropertyCalculateType.CSScript ? this.GetPropertySetterExpressions(propertyTypeDescriptor, propertyMetadata, str) : Enumerable.Empty<ISyntaxNode>());
      this.dataInterfaceMembers.Add(propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, getAccessorStatements: getAccessorStatements2, setAccessorStatements: setAccessorStatements2));
      ISyntaxNode property = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, getAccessorStatements: getAccessorStatements2, setAccessorStatements: setAccessorStatements2);
      if (writeAttributes)
        this.WritePropertyAttributes(property, propertyMetadata, (string) null);
      if (propertyAction != null)
        propertyAction(property);
      if (ctorStatements != null && propertyMetadata.CalculateType != PropertyCalculateType.CSScript)
      {
        ISyntaxNode propertyInitExpression = this.GetPropertyInitExpression(propertyMetadata, propertyTypeDescriptor);
        if (propertyInitExpression != null)
          ctorStatements.Add(this.FieldName(propertyMetadata).IdentifierName().AssignmentStatement(propertyInitExpression));
      }
      this.dataClassMembers.Add(property);
      return syntaxNode.Concat<ISyntaxNode>(propertyTypeDescriptor.GetAdditionalTypeMembers((ClassMetadata) this.metadata, propertyMetadata));
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(
      ITypeGenerationInfo typeDescr,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      if (this.csScripts == null || !this.DynamicPublicationEnable)
        return base.GetPropertyGetterExpressions(typeDescr, propertyMetadata, fieldName);
      IEnumerable<ISyntaxNode> getterExpressions = typeDescr.GetPropertyGetterExpressions((ClassMetadata) this.metadata, propertyMetadata, fieldName);
      if (getterExpressions == null)
        getterExpressions = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          fieldName.IdentifierName().ReturnStatement()
        };
      else
        this.csScripts.Add(propertyMetadata.Name);
      return getterExpressions;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetPropertySetterExpressions(
      ITypeGenerationInfo typeDescr,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      if (this.csScripts == null || !this.DynamicPublicationEnable)
        return base.GetPropertySetterExpressions(typeDescr, propertyMetadata, fieldName);
      IEnumerable<ISyntaxNode> setterExpressions = typeDescr.GetPropertySetterExpressions((ClassMetadata) this.metadata, propertyMetadata, fieldName);
      if (setterExpressions == null)
        setterExpressions = (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value)
        };
      else
        this.csScripts.Add(propertyMetadata.Name);
      return setterExpressions;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements) => base.GetProperties(ctorStatements).If<ISyntaxNode>(this.DynamicPublicationEnable, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (_ => _.Append<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221794636).PropertyDeclaration(TypeOf<Guid>.Raw.CreateTypeSyntax(), Accessibility.Protected, DeclarationModifiers.Override, (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643076846).InvocationExpression(SyntaxGeneratorExtensions.This, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597188562).IdentifierName()).ReturnStatement()
    }))));

    /// <inheritdoc />
    protected override ISyntaxNode GetUidField(ISyntaxNode guidType) => ((string) EntityDynamicGenerator.aKKQkChkr8RWXNo8cDHU(654297945 ^ 654088765)).FieldDeclaration(guidType, Accessibility.Internal, DeclarationModifiers.Static, guidType.ObjectCreationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122081138).IdentifierName()));

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> WriteTypeUidProperty()
    {
      if (!this.DynamicPublicationEnable)
        return base.WriteTypeUidProperty();
      ISyntaxNode typeSyntax = TypeOf<Guid>.Raw.CreateTypeSyntax();
      ISyntaxNode syntaxNode = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137442896).PropertyDeclaration(typeSyntax, Accessibility.Public, (DeclarationModifiers) (this.metadata.BaseClassUid != Guid.Empty ? 8 : 16), (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        typeof (EntityDynamicExtensions).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112756544)).InvocationExpression(SyntaxGeneratorExtensions.This).ReturnStatement()
      }, Enumerable.Empty<ISyntaxNode>());
      syntaxNode.XmlComments(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345367366)).SummaryComment());
      return Enumerable.Repeat<ISyntaxNode>(syntaxNode, 1);
    }

    /// <inheritdoc />
    protected override ISyntaxNode ToStringMethod()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.DynamicPublicationEnable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return base.ToStringMethod();
label_3:
      return (ISyntaxNode) null;
    }

    /// <inheritdoc />
    protected override bool HasFilterClass
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.metadata is TablePartMetadata)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 3:
              if (!this.DynamicPublicationEnable)
              {
                num = 2;
                continue;
              }
              goto case 1;
            default:
              goto label_4;
          }
        }
label_4:
        return base.HasFilterClass;
label_5:
        return true;
      }
    }

    /// <inheritdoc />
    protected override ISyntaxNode GetBasicFilter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.DynamicPublicationEnable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return base.GetBasicFilter();
label_5:
      return TypeOf<FilterDynamic>.Raw.CreateTypeSyntax();
    }

    /// <inheritdoc />
    protected override string GetInterfaceTypeName()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (!this.DynamicPublicationEnable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (!this.IsConfig(EntityDynamicGenerator.iv1ooQhObXDAs4JZu1uZ((object) this.metadata)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      return base.GetInterfaceTypeName();
label_7:
      return (string) EntityDynamicGenerator.YI78jHhOGILFYUydLNfp((object) (ClassMetadata) EntityDynamicGenerator.HYn2ELhOhSSRFofIOX51((object) this, EntityDynamicGenerator.iv1ooQhObXDAs4JZu1uZ((object) this.metadata)));
    }

    /// <inheritdoc />
    protected override ISyntaxNode WriteFilterClassByBaseClass(
      List<ISyntaxNode> attributes,
      List<ISyntaxNode> interfaceTypes)
    {
      if (!this.DynamicPublicationEnable)
        return base.WriteFilterClassByBaseClass(attributes, interfaceTypes);
      ISyntaxNode syntaxNode = this.metadata.BaseClassUid != Guid.Empty ? (((ClassMetadata) this.GetMetadata(this.metadata.BaseClassUid)).FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917272502)).CreateTypeSyntax() : this.GetBasicFilter();
      if (!this.metadata.Filterable)
        attributes.Add(TypeOf<EditorBrowsableAttribute>.Raw.CreateAttribute((object) EditorBrowsableState.Never.CreateSyntaxNode()));
      EntityMetadata metadata1 = (EntityMetadata) this.GetMetadata(this.metadata.ImplementationUid);
      if (this.IsConfig(metadata1.Uid) || metadata1.Filterable)
      {
        ISyntaxNode typeSyntax = (metadata1.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87353525)).CreateTypeSyntax();
        interfaceTypes.Add(typeSyntax);
        if (metadata1.Filterable)
          attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute((object) typeSyntax.TypeOfExpression()));
      }
      if (this.metadata.ImplementedExtensionUids != null)
      {
        foreach (Guid implementedExtensionUid in this.metadata.ImplementedExtensionUids)
        {
          if (this.GetMetadata(implementedExtensionUid) is EntityMetadata metadata2 && metadata2.Filterable)
          {
            ISyntaxNode typeSyntax = (metadata2.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418456502)).CreateTypeSyntax();
            interfaceTypes.Add(typeSyntax);
            attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute((object) typeSyntax.TypeOfExpression()));
          }
        }
      }
      if (!this.IsConfig(metadata1.Uid))
      {
        EntityMetadata entityMetadata = this.metadata.ImplementedExtensionUids.EmptyIfNull<Guid>().Where<Guid>(new Func<Guid, bool>(this.IsConfig)).Select<Guid, IMetadata>(new Func<Guid, IMetadata>(((CodeGenerator) this).GetMetadata)).Cast<EntityMetadata>().FirstOrDefault<EntityMetadata>();
        if (entityMetadata == null || !entityMetadata.Filterable)
        {
          ISyntaxNode typeSyntax = (EntityDynamicGenerator.GetConfigExtTypeName((object) metadata1.FullTypeName) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461641381)).CreateTypeSyntax();
          interfaceTypes.Add(typeSyntax);
        }
      }
      return syntaxNode;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetFilterCtors(List<ISyntaxNode> ctorStatements)
    {
      if (!this.DynamicPublicationEnable)
        return base.GetFilterCtors(ctorStatements);
      this.dataCtor = SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138238288).ParameterDeclaration(this.FilterClassName.CreateTypeSyntax())
      }, Accessibility.Public, statements: ctorStatements.Prepend<ISyntaxNode>(SyntaxGeneratorExtensions.This.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146423829)).AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740555492).IdentifierName())));
      return Enumerable.Empty<ISyntaxNode>();
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> WriteFilterMembers()
    {
      if (!this.DynamicPublicationEnable)
        return base.WriteFilterMembers();
      this.dataInterfaceMembers = (IList<ISyntaxNode>) new List<ISyntaxNode>();
      this.dataClassMembers = (IList<ISyntaxNode>) new List<ISyntaxNode>();
      return this.DataMembers((IEnumerable<ISyntaxNode>) base.WriteFilterMembers().ToArray<ISyntaxNode>(), this.FilterClassName.CreateTypeSyntax(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583560736), z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909353545), true);
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> WriteFilterClassProperty(
      PropertyMetadata filterPropertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool isCustomProperty,
      ITypeDescriptor filterType)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new EntityDynamicGenerator.\u003CWriteFilterClassProperty\u003Ed__88(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__filterPropertyMetadata = filterPropertyMetadata,
        \u003C\u003E3__ctorStatements = ctorStatements,
        \u003C\u003E3__isCustomProperty = isCustomProperty,
        \u003C\u003E3__filterType = filterType
      };
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxTrivia> WriteLocalizationResources() => this.DynamicPublicationEnable && !this.metadata.IsInterfaceType ? Enumerable.Empty<ISyntaxTrivia>() : base.WriteLocalizationResources();

    /// <inheritdoc />
    protected override EntityGenerator CreateTablePartGenerator(TablePartMetadata tablePart)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (this.DynamicPublicationEnable)
            {
              if (tablePart == null)
              {
                num = 3;
                continue;
              }
              goto case 4;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
              continue;
            }
          case 3:
            goto label_3;
          case 4:
            if (EntityDynamicGenerator.Np9uaPhOEFKs7rBtYEmb((object) tablePart))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      EntityDynamicGenerator.EntityDynamicPermissionsGenerator tablePartGenerator = new EntityDynamicGenerator.EntityDynamicPermissionsGenerator(this.metadata);
      tablePartGenerator.csScripts = this.csScripts;
      return (EntityGenerator) tablePartGenerator;
label_3:
      return (EntityGenerator) new EntityDynamicGenerator()
      {
        csScripts = this.csScripts
      };
label_6:
      return base.CreateTablePartGenerator(tablePart);
    }

    public EntityDynamicGenerator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object eonSTThk4E7EQOr98lKN([In] object obj0, [In] object obj1) => (object) AssemblyDefinition.ReadAssembly((Stream) obj0, (ReaderParameters) obj1);

    internal static object SKuovGhk6fuKJCWWtcMA([In] object obj0) => (object) ((AssemblyDefinition) obj0).Name;

    internal static object r3TPvHhkHpuap4HlX5O8([In] object obj0) => (object) ((AssemblyNameReference) obj0).Version;

    internal static int BiLU2VhkATEw6kjqVkLx([In] object obj0) => ((Version) obj0).Minor;

    internal static int E11vVMhk729qg4RhV6V6([In] object obj0) => ((Version) obj0).Build;

    internal static void ybpkLYhkx6U2rQqwMxNP([In] object obj0, [In] object obj1) => ((AssemblyNameReference) obj0).Version = (Version) obj1;

    internal static object AsNnoJhk0j4rprL1pWdc([In] object obj0) => (object) ((AssemblyDefinition) obj0).FullName;

    internal static bool iEqA3LhkmuHDBqZnIkvq([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

    internal static object NNxEjmhkyEwD9BWgkfBY([In] object obj0) => (object) ((AssemblyDefinition) obj0).MainModule;

    internal static void Xakg6EhkMGJI3disi1jI([In] object obj0) => ((EntityDynamicGenerator.DeltaAssemblyProcessor) obj0).Process();

    internal static object j3moPjhkJfBAnjtd3BiK() => (object) MemoryHelper.GetMemoryStream();

    internal static void YW4wC5hk9KsWtvtaV1XY([In] object obj0, [In] object obj1) => ((AssemblyDefinition) obj0).Write((Stream) obj1);

    internal static long MU2aP8hkdxC4Yk7IqUQh([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object u0RVOMhklXaIAWFamFWj([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((MemoryStream) obj0, (MemoryStream) obj1);

    internal static bool ySPWi6hkti3sbOkKhWW0() => EntityDynamicGenerator.C511m3hkDxih6u0pCvk4 == null;

    internal static EntityDynamicGenerator NTLb7DhkwlPdDoXMxblW() => EntityDynamicGenerator.C511m3hkDxih6u0pCvk4;

    internal static object aKKQkChkr8RWXNo8cDHU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object E3DvSnhkg14KJsj2wGOF([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static object Q4L8MNhk5vu7cNYiJAPh([In] object obj0) => (object) ((System.Reflection.AssemblyName) obj0).Name;

    internal static object ivqncshkj5Tt6q9RGxYY([In] object obj0) => (object) ((System.Reflection.AssemblyName) obj0).Version;

    internal static object s1uE7bhkYP8YX1NbM01V([In] object obj0) => (object) ((System.Reflection.AssemblyName) obj0).CultureName;

    internal static void KrQUpWhkL2ft7QNheeJZ([In] object obj0, [In] AssemblyHashAlgorithm obj1) => ((AssemblyNameReference) obj0).HashAlgorithm = obj1;

    internal static AssemblyNameFlags uosokNhkUQeNnqL4MbA8([In] object obj0) => ((System.Reflection.AssemblyName) obj0).Flags;

    internal static void L8DslRhksqtmYKrx3wLy([In] object obj0, [In] bool obj1) => ((AssemblyNameReference) obj0).IsRetargetable = obj1;

    internal static void zEXsNXhkcmTSKAgeHCUd([In] object obj0, [In] object obj1) => ((AssemblyNameReference) obj0).PublicKeyToken = (byte[]) obj1;

    internal static void tNcLjRhkzumcZrtq5X5u([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object qk78g7hnFlRgPdbvtOID([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object tyblcIhnB7rUgH0mbXRr([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object J4YrL5hnWD3sjkq0DINm([In] object obj0) => (object) ((Assembly) obj0).GetName();

    internal static object l9JSaAhno456rwu0XE9d([In] object obj0) => (object) EntityDynamicGenerator.CreateReference(obj0);

    internal static object oI2MPOhnbKqkeYbZqJ9h([In] object obj0, [In] object obj1) => (object) ((EntityDynamicGenerator.CloneScope) obj0).Import((TypeReference) obj1);

    internal static System.Type f3tMUwhnhMyGbcp34OdJ([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static object JvlmUhhnGMDjcsLAgBhk(System.Type type) => (object) EntityDynamicGenerator.CreateReference(type);

    internal static CallingConventions rbHFDRhnE2GY4HupLoBY([In] object obj0) => ((MethodBase) obj0).CallingConvention;

    internal static void amL2IUhnfxBSmBR7EZex([In] object obj0, [In] bool obj1) => ((MethodReference) obj0).HasThis = obj1;

    internal static void eIckYihnQpwNiGKo9sYN([In] object obj0, [In] bool obj1) => ((MethodReference) obj0).ExplicitThis = obj1;

    internal static void jiuNWjhnCUtNoMAmBlRC([In] object obj0, [In] MethodCallingConvention obj1) => ((MethodReference) obj0).CallingConvention = obj1;

    internal static object SkgmXOhnvs2sMIyGtQpc([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object o8xwr1hn8QFrgSQawYTL([In] object obj0) => (object) ((AssemblyNameReference) obj0).Name;

    internal static void QvXIZuhnZl9ZH18gcyJc([In] object obj0, [In] object obj1) => ((AssemblyNameReference) obj0).Culture = (string) obj1;

    internal static bool syFZfChnuR3gD6oEGH58([In] object obj0) => ((AssemblyNameReference) obj0).IsRetargetable;

    internal static object r2vLb2hnI8WhkjRBsatI([In] object obj0) => (object) ((AssemblyNameReference) obj0).PublicKeyToken;

    internal static void BKCVPqhnVhtIHFwcG8jA([In] object obj0, [In] object obj1, [In] int obj2) => ((Array) obj0).CopyTo((Array) obj1, obj2);

    internal static object wQ5Zt3hnSKhywmgQWoi0([In] object obj0) => (object) EntityDynamicGenerator.CreateReference(obj0);

    internal static object h9y15jhnifgRJAE2wDrn([In] object obj0) => (object) ((TypeSpecification) obj0).ElementType;

    internal static System.Type iRZ96shnRtiPlIIchpNs([In] object obj0) => EntityDynamicGenerator.Resolve((TypeReference) obj0);

    internal static int LCb6BqhnqEgZoVpNs8AQ([In] object obj0) => ((ArrayType) obj0).Rank;

    internal static object Ofp4m0hnKhKS8lVhbBkZ([In] object obj0) => (object) ((MemberReference) obj0).FullName;

    internal static object cWAOhIhnXlY19adVMb14([In] object obj0) => (object) EntityDynamicGenerator.AssemblyName(obj0);

    internal static object hJ2KTshnTG9rxiU91BuJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool QwsILFhnkkeNjevxqvGL([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static bool OYTKwyhnnm0mC72xGd1p([In] object obj0) => ((TypeReference) obj0).IsNested;

    internal static object LdH5vfhnO6EQ5e4ytaxo([In] object obj0) => (object) ((MemberReference) obj0).DeclaringType;

    internal static object kLX18Ahn2UGIsgI90Krv([In] object obj0) => (object) ((MemberReference) obj0).Name;

    internal static bool ou9hK2hnecrPsmYkXx7w([In] object obj0) => ((MethodReference) obj0).IsGenericInstance;

    internal static object dEerjphnPjn7FcxFYbXZ([In] object obj0) => (object) EntityDynamicGenerator.CreateReference((TypeReference) obj0);

    internal static object LxKIANhn1G8BE9oV6iei([In] object obj0) => (object) ((MethodReference) obj0).ReturnType;

    internal static bool WiUJAjhnNUNPeIv6Nd2q([In] object obj0) => ((MethodReference) obj0).HasThis;

    internal static bool JiZx8xhn3aVY27d17ln3([In] object obj0) => ((MethodReference) obj0).ExplicitThis;

    internal static MethodCallingConvention jJu9iOhnpLhulQdTiq30([In] object obj0) => ((MethodReference) obj0).CallingConvention;

    internal static bool WLvp2mhnaT0cacECS6yp([In] object obj0) => ((MethodReference) obj0).HasGenericParameters;

    internal static void XB2NxnhnD5OO0PA9xyxd([In] object obj0, [In] object obj1) => ((MethodReference) obj0).ReturnType = (TypeReference) obj1;

    internal static bool tShT2uhntpun8GmBD0O0([In] object obj0) => ((MethodReference) obj0).HasParameters;

    internal static object bycSo2hnwnQC3Ubt5XTN([In] object obj0) => (object) ((TypeReference) obj0).Scope;

    internal static object MWThlghn49KGlBcfmwJx([In] object obj0) => (object) ((AssemblyNameReference) obj0).FullName;

    internal static void JNuy0Nhn6Or8X7R3ZkVZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static int BY9XIHhnHqi0quIsV0Ks([In] object obj0) => ((string) obj0).Length;

    internal static System.Type ahs6yrhnAd4G7pxVVsxB([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object M0S5U0hn75XaSWyQJutH([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    internal static object X4WaZKhnxGUP3rTQy1sm() => (object) TypeOf<Guid>.FullName;

    internal static object oqmjfShn0JZU8r1EAQPq() => (object) TypeOf<IInheritable>.FullName;

    internal static object bpUg2NhnmAsdhiRYT1c4([In] object obj0) => (object) EntityDynamicGenerator.CreateReference(obj0);

    internal static object Pw7fsqhny3B22cJQgTQk([In] object obj0) => (object) ((RipeType) obj0).FullName;

    internal static object keXJsnhnMwyfCU8Tu0Zh([In] object obj0) => (object) EntityDynamicGenerator.MethodName(obj0);

    internal static object e9MT9YhnJ1cJVENhQULv([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object F5e4CIhn9pERVVBPIW10([In] object obj0) => (object) EntityDynamicGenerator.TypeName(obj0);

    internal static object s0N42whndrdPVcyTJ75J(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object x1sAH6hnlV7amNoNuvfv([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object kImPPthnrGgq6aBjF2vT() => (object) ConfigurationModelAssemblyBuilder.Version;

    internal static bool pdc1nxhng8NbBTLjYhcF([In] object obj0, [In] object obj1) => (Version) obj0 == (Version) obj1;

    internal static bool uY8Yg2hn5di72k4aOt8I([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static int gqTmBLhnjx8eFrfardME([In] object obj0) => ((List<AssemblyNameReference>) obj0).Count;

    internal static object rlLnDohnYQkcwMWBUxCL([In] object obj0, [In] object obj1) => (object) ((ModuleDefinition) obj0).Import((TypeReference) obj1);

    internal static void m6Xci2hnL17pVeQHSnXI([In] object obj0, [In] object obj1) => ((MemberReference) obj0).DeclaringType = (TypeReference) obj1;

    internal static void OkwYh8hnUSTaE31L5XcY([In] object obj0, [In] object obj1) => ((TypeReference) obj0).Scope = (IMetadataScope) obj1;

    internal static bool D1hI47hns7WsrckyHJp7([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static object ExPxlIhnc6shpyR6usW6([In] object obj0) => (object) ((GeneratedFileInfo) obj0).Data;

    internal static void O092mGhnzbsidBg7kRwD([In] object obj0, [In] object obj1) => ((GeneratedFileInfo) obj0).Data = (byte[]) obj1;

    internal static object IJGXnahOF6DHMQcNTTXB([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object bNUY8fhOBwdhH6GVVKQ4([In] object obj0) => (object) ((ClassMetadata) obj0).TypeName;

    internal static object HmKtEPhOW8h4nS67PRYR([In] object obj0) => (object) EntityDynamicGenerator.GetConfigExtTypeName(obj0);

    internal static System.Type w3AXI9hOoeG6fKLAS8BW([In] object obj0) => ((RipeType) obj0).Raw;

    internal static Guid iv1ooQhObXDAs4JZu1uZ([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static object HYn2ELhOhSSRFofIOX51([In] object obj0, Guid uid) => (object) ((CodeGenerator) obj0).GetMetadata(uid);

    internal static object YI78jHhOGILFYUydLNfp([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static bool Np9uaPhOEFKs7rBtYEmb([In] object obj0) => ((EntityMetadata) obj0).IsActivePermissionMetadata();

    private class TypeReferenceFullNameComparer : IEqualityComparer<TypeReference>
    {
      private static object phYcphvGOYjv4v4Hhbo1;

      public static IEqualityComparer<TypeReference> Instance { get; }

      public bool Equals(TypeReference x, TypeReference y)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (x != y)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return EntityDynamicGenerator.TypeReferenceFullNameComparer.v4b76WvG11c8U3dLKRjU(EntityDynamicGenerator.TypeReferenceFullNameComparer.APW4vEvGPVq2KtAgqHeM((object) x), EntityDynamicGenerator.TypeReferenceFullNameComparer.APW4vEvGPVq2KtAgqHeM((object) y));
label_3:
        return true;
      }

      public int GetHashCode(TypeReference obj) => obj.FullName.GetHashCode();

      public TypeReferenceFullNameComparer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static TypeReferenceFullNameComparer()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              EntityDynamicGenerator.TypeReferenceFullNameComparer.lLh9OyvGNFX9JtROvUOI();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              EntityDynamicGenerator.TypeReferenceFullNameComparer.Instance = (IEqualityComparer<TypeReference>) new EntityDynamicGenerator.TypeReferenceFullNameComparer();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }

      internal static object APW4vEvGPVq2KtAgqHeM([In] object obj0) => (object) ((MemberReference) obj0).FullName;

      internal static bool v4b76WvG11c8U3dLKRjU([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static bool GC5mATvG2Lx64qJqR5HL() => EntityDynamicGenerator.TypeReferenceFullNameComparer.phYcphvGOYjv4v4Hhbo1 == null;

      internal static EntityDynamicGenerator.TypeReferenceFullNameComparer HUJQ9uvGe7TEMLyFjXBZ() => (EntityDynamicGenerator.TypeReferenceFullNameComparer) EntityDynamicGenerator.TypeReferenceFullNameComparer.phYcphvGOYjv4v4Hhbo1;

      internal static void lLh9OyvGNFX9JtROvUOI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class MethodReferenceFullNameComparer : IEqualityComparer<MethodReference>
    {
      private static object jDpYgXvG3LDaaL7aDwU8;

      public static IEqualityComparer<MethodReference> Instance { get; }

      public bool Equals(MethodReference x, MethodReference y) => x == y;

      public int GetHashCode(MethodReference obj) => obj.GetHashCode();

      public MethodReferenceFullNameComparer()
      {
        EntityDynamicGenerator.MethodReferenceFullNameComparer.V1h62EvGDjfDqZN4ap4x();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static MethodReferenceFullNameComparer()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityDynamicGenerator.MethodReferenceFullNameComparer.Instance = (IEqualityComparer<MethodReference>) new EntityDynamicGenerator.MethodReferenceFullNameComparer();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static bool YNV2tvvGpn4IxTUJEkYT() => EntityDynamicGenerator.MethodReferenceFullNameComparer.jDpYgXvG3LDaaL7aDwU8 == null;

      internal static EntityDynamicGenerator.MethodReferenceFullNameComparer K6G47lvGaW2LFpTcX3ES() => (EntityDynamicGenerator.MethodReferenceFullNameComparer) EntityDynamicGenerator.MethodReferenceFullNameComparer.jDpYgXvG3LDaaL7aDwU8;

      internal static void V1h62EvGDjfDqZN4ap4x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class LazyDictionary<TKey, TValue> : 
      IDictionary<TKey, TValue>,
      ICollection<KeyValuePair<TKey, TValue>>,
      IEnumerable<KeyValuePair<TKey, TValue>>,
      IEnumerable
    {
      private readonly IDictionary<TKey, Lazy<TValue>> dictionary;
      private static object nXJHO0vGt6gxfcyOmpZp;

      public LazyDictionary()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.dictionary = (IDictionary<TKey, Lazy<TValue>>) new Dictionary<TKey, Lazy<TValue>>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public LazyDictionary(IEqualityComparer<TKey> comparer)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.dictionary = (IDictionary<TKey, Lazy<TValue>>) new Dictionary<TKey, Lazy<TValue>>(comparer);
      }

      public TValue this[TKey key]
      {
        get => this.dictionary[key].Value;
        set => this.dictionary[key] = new Lazy<TValue>((Func<TValue>) (() => value));
      }

      public ICollection<TKey> Keys => this.dictionary.Keys;

      public ICollection<TValue> Values => throw new NotImplementedException();

      public int Count => this.dictionary.Count;

      public bool IsReadOnly => false;

      public void Add(TKey key, TValue value) => this.dictionary.Add(key, new Lazy<TValue>((Func<TValue>) (() => value)));

      public void Add(TKey key, Func<TValue> valueFunc) => this.dictionary.Add(key, new Lazy<TValue>(valueFunc));

      public void Add(KeyValuePair<TKey, TValue> item) => this.Add(item.Key, item.Value);

      public void Clear()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.dictionary.Clear();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool ContainsKey(TKey key) => this.dictionary.ContainsKey(key);

      public bool Remove(TKey key) => this.dictionary.Remove(key);

      public bool TryGetValue(TKey key, out TValue value)
      {
        Lazy<TValue> lazy;
        if (this.dictionary.TryGetValue(key, out lazy))
        {
          value = lazy.Value;
          return true;
        }
        value = default (TValue);
        return false;
      }

      public bool Contains(KeyValuePair<TKey, TValue> item) => throw new NotImplementedException();

      public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => throw new NotImplementedException();

      public bool Remove(KeyValuePair<TKey, TValue> item) => throw new NotImplementedException();

      public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => throw new NotImplementedException();

      IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();

      internal static bool sxPN0rvGwss3QUdoBfEb() => EntityDynamicGenerator.LazyDictionary<TKey, TValue>.nXJHO0vGt6gxfcyOmpZp == null;

      internal static object uGREQcvG4tS9Oyu84YaZ() => EntityDynamicGenerator.LazyDictionary<TKey, TValue>.nXJHO0vGt6gxfcyOmpZp;
    }

    private class DeltaAssemblyProcessor
    {
      private readonly object module;
      private readonly IList<System.Type> changedTypes;
      private readonly IList<TypeDefinition> newTypes;
      private readonly IList<TypeDefinition> newPublicApiTypes;
      private readonly IList<TypeDefinition> dataClasses;
      private readonly ISet<TypeDefinition> typesToRemove;
      private readonly IList<(System.Type type, TypeDefinition typeDefinition, int index)> typesToRename;
      private readonly IDictionary<TypeReference, TypeReference> typesToReplace;
      private readonly EntityDynamicGenerator.LazyDictionary<MethodReference, MethodReference> methodsToReplace;
      private readonly EntityDynamicGenerator.LazyDictionary<FieldReference, FieldReference> fieldsToReplace;
      private readonly IDictionary<MethodDefinition, string> replaceMethods;
      internal static object J3I0fUvG6IXsDGOEv1d5;

      public DeltaAssemblyProcessor(ModuleDefinition module)
      {
        EntityDynamicGenerator.DeltaAssemblyProcessor.yJV7eEvG7LJ5q9M2EslM();
        this.changedTypes = (IList<System.Type>) new List<System.Type>();
        this.newTypes = (IList<TypeDefinition>) new List<TypeDefinition>();
        this.newPublicApiTypes = (IList<TypeDefinition>) new List<TypeDefinition>();
        this.dataClasses = (IList<TypeDefinition>) new List<TypeDefinition>();
        this.typesToRemove = (ISet<TypeDefinition>) new HashSet<TypeDefinition>();
        this.typesToRename = (IList<(System.Type, TypeDefinition, int)>) new List<(System.Type, TypeDefinition, int)>();
        this.typesToReplace = (IDictionary<TypeReference, TypeReference>) new Dictionary<TypeReference, TypeReference>(EntityDynamicGenerator.TypeReferenceFullNameComparer.Instance);
        this.methodsToReplace = new EntityDynamicGenerator.LazyDictionary<MethodReference, MethodReference>(EntityDynamicGenerator.MethodReferenceFullNameComparer.Instance);
        this.fieldsToReplace = new EntityDynamicGenerator.LazyDictionary<FieldReference, FieldReference>();
        this.replaceMethods = (IDictionary<MethodDefinition, string>) new Dictionary<MethodDefinition, string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.module = (object) module;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public void Process()
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          Dictionary<TypeReference, string> publicApiReplaces;
          while (true)
          {
            switch (num2)
            {
              case 1:
                publicApiReplaces = new Dictionary<TypeReference, string>();
                num2 = 5;
                continue;
              case 2:
                this.ProceedTypes();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
                continue;
              case 3:
                goto label_11;
              case 4:
                this.ReplaceTypes();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              case 5:
                this.ProceedPublicApi(((ModuleDefinition) this.module).GetType((string) EntityDynamicGenerator.DeltaAssemblyProcessor.uvMl8QvGxXJLNc1YU10F(-951514650 ^ -951498544)), (IDictionary<TypeReference, string>) publicApiReplaces);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 3;
                continue;
              case 6:
                Dictionary<TypeReference, string> enumeration = publicApiReplaces;
                // ISSUE: reference to a compiler-generated field
                Action<KeyValuePair<TypeReference, string>> action1 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__12_0;
                Action<KeyValuePair<TypeReference, string>> action2;
                if (action1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__12_0 = action2 = (Action<KeyValuePair<TypeReference, string>>) (p => EntityDynamicGenerator.AddReplace((object) p.Value, (object) EntityDynamicGenerator.CreateReference(p.Key)));
                }
                else
                  goto label_16;
label_10:
                enumeration.ForEach<KeyValuePair<TypeReference, string>>(action2);
                num2 = 3;
                continue;
label_16:
                action2 = action1;
                goto label_10;
              case 7:
                goto label_12;
              default:
                this.ProcessDataClasses();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 6;
                continue;
            }
          }
label_11:
          IDictionary<MethodDefinition, string> replaceMethods = this.replaceMethods;
          // ISSUE: reference to a compiler-generated field
          Action<KeyValuePair<MethodDefinition, string>> action3 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__12_1;
          Action<KeyValuePair<MethodDefinition, string>> action4;
          if (action3 == null)
          {
            // ISSUE: reference to a compiler-generated field
            EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__12_1 = action4 = (Action<KeyValuePair<MethodDefinition, string>>) (p => EntityDynamicGenerator.AddReplace((object) p.Value, (object) EntityDynamicGenerator.CreateReference((MethodReference) p.Key)));
          }
          else
            goto label_15;
label_14:
          replaceMethods.ForEach<KeyValuePair<MethodDefinition, string>>(action4);
          num1 = 7;
          continue;
label_15:
          action4 = action3;
          goto label_14;
        }
label_12:;
      }

      public Assembly PostProcess(
        Assembly result,
        out IEnumerable<System.Type> changedTypes,
        out IEnumerable<System.Type> newTypes)
      {
        int num1 = 6;
        IEnumerator<(System.Type, System.Type)> enumerator;
        Assembly result1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              IList<(System.Type type, TypeDefinition typeDefinition, int index)> typesToRename = this.typesToRename;
              // ISSUE: reference to a compiler-generated field
              Func<(System.Type, TypeDefinition, int), bool> func1 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__13_3;
              Func<(System.Type, TypeDefinition, int), bool> predicate;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__13_3 = predicate = (Func<(System.Type, TypeDefinition, int), bool>) (t => t.index > 0);
              }
              else
                goto label_20;
label_27:
              enumerator = typesToRename.Where<(System.Type, TypeDefinition, int)>(predicate).Select<(System.Type, TypeDefinition, int), (System.Type, System.Type)>((Func<(System.Type, TypeDefinition, int), (System.Type, System.Type)>) (t => (t.type, result1.GetType(t.typeDefinition.FullName.Replace('/', '+'))))).GetEnumerator();
              num1 = 3;
              continue;
label_20:
              predicate = func1;
              goto label_27;
            case 2:
              Assembly assembly = result1;
              IEnumerable<Mono.Cecil.EmbeddedResource> source1 = ((ModuleDefinition) this.module).Resources.OfType<Mono.Cecil.EmbeddedResource>();
              // ISSUE: reference to a compiler-generated field
              Func<Mono.Cecil.EmbeddedResource, (string, byte[])> func2 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__13_2;
              Func<Mono.Cecil.EmbeddedResource, (string, byte[])> selector1;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__13_2 = selector1 = (Func<Mono.Cecil.EmbeddedResource, (string, byte[])>) (r => (r.Name, r.GetResourceData()));
              }
              else
                goto label_13;
label_30:
              IEnumerable<(string, byte[])> manifestResources = source1.Select<Mono.Cecil.EmbeddedResource, (string, byte[])>(selector1);
              ReflectionType.AddManifestResources(assembly, manifestResources);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
label_13:
              selector1 = func2;
              goto label_30;
            case 3:
              try
              {
label_8:
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.nI2mXnvGmait7AmwPp5n((object) enumerator))
                  goto label_11;
                else
                  goto label_9;
label_7:
                System.Type entityType;
                System.Type type1;
                int num2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      EntityDynamicGenerator.DeltaAssemblyProcessor.S0PAadvG08Qi9OROsEwM(entityType, type1.GetNestedType((string) EntityDynamicGenerator.DeltaAssemblyProcessor.uvMl8QvGxXJLNc1YU10F(-105199646 ^ -105282088), BindingFlags.NonPublic));
                      num2 = 3;
                      continue;
                    case 2:
                      System.Type type2 = entityType;
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      IEnumerable<System.Type> source2 = ((IEnumerable<System.Type>) type1.GetNestedTypes(BindingFlags.NonPublic)).Where<System.Type>((Func<System.Type, bool>) (t => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.HwTT9tZq3qv44OlWRBLi(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.L92kUoZq10ciSaZcsHp6((object) t), EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(647913418 ^ 647827414))));
                      // ISSUE: reference to a compiler-generated field
                      Func<System.Type, object> func3 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__13_6;
                      Func<System.Type, object> selector2;
                      if (func3 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__13_6 = selector2 = (Func<System.Type, object>) (t => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.mQcwDqZqpWQHARjF5EP1((object) t.GetField((string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(372753449 ^ 372406837)), (object) null));
                      }
                      else
                        goto label_31;
label_15:
                      IEnumerable<object> accessors = source2.Select<System.Type, object>(selector2);
                      type2.AddAccessors((IEnumerable) accessors);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
                      continue;
label_31:
                      selector2 = func3;
                      goto label_15;
                    case 3:
                      goto label_8;
                    case 4:
                      goto label_24;
                    default:
                      goto label_11;
                  }
                }
label_9:
                num2 = 4;
                goto label_7;
label_11:
                (entityType, type1) = enumerator.Current;
                num2 = 2;
                goto label_7;
              }
              finally
              {
                int num3;
                if (enumerator == null)
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
                else
                  goto label_19;
label_18:
                switch (num3)
                {
                  case 1:
                  case 2:
                }
label_19:
                EntityDynamicGenerator.DeltaAssemblyProcessor.UwdDNsvGyVPTLJ7XKuQ5((object) enumerator);
                num3 = 2;
                goto label_18;
              }
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              ReflectionType.Register((IEnumerable<System.Type>) this.newPublicApiTypes.Select<TypeDefinition, System.Type>((Func<TypeDefinition, System.Type>) (typeDefinition => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass13_0.ijaRo5Zq5sxkjJsNlmgQ((object) result1, EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass13_0.sPjJ7iZqjveUBWwVdcSy(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass13_0.bupHc2ZqgqFaGBscU4Xm((object) typeDefinition), '/', '+')))).ToArray<System.Type>());
              num1 = 2;
              continue;
            case 5:
              result1 = result;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 9 : 2;
              continue;
            case 6:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 5;
              continue;
            case 7:
label_24:
              ReflectionType.Register(newTypes);
              num1 = 4;
              continue;
            case 8:
              newTypes = (IEnumerable<System.Type>) this.newTypes.Select<TypeDefinition, System.Type>((Func<TypeDefinition, System.Type>) (typeDefinition =>
              {
                int num4 = 1;
                System.Type type;
                while (true)
                {
                  int num5 = num4;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        type = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass13_0.ijaRo5Zq5sxkjJsNlmgQ((object) result1, (object) ((string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass13_0.bupHc2ZqgqFaGBscU4Xm((object) typeDefinition)).Replace('/', '+'));
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                        continue;
                      case 2:
                      case 6:
                        EntityDynamicProvider.AddType(type, typeDefinition);
                        num5 = 7;
                        continue;
                      case 3:
                        goto label_4;
                      case 4:
                        if (type.IsClass)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
                          continue;
                        }
                        goto label_5;
                      case 5:
                      case 7:
                        goto label_5;
                      case 8:
                      case 9:
                        if (type.IsInterface)
                        {
                          num5 = 6;
                          continue;
                        }
                        goto case 4;
                      default:
                        if (!type.IsEnum)
                        {
                          num5 = 8;
                          continue;
                        }
                        goto label_4;
                    }
                  }
label_4:
                  EnumProvider.AddType(type, typeDefinition);
                  num4 = 5;
                }
label_5:
                return type;
              })).ToArray<System.Type>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
              continue;
            case 9:
              changedTypes = (IEnumerable<System.Type>) this.changedTypes;
              num1 = 8;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return result1;
      }

      private void AddMethodReplace(MethodReference fromMethod, MethodDefinition toMethod)
      {
        int num = 2;
        string methodName;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityDynamicGenerator.AddReplace((object) methodName, (object) toMethod);
              num = 3;
              continue;
            case 2:
              methodName = (string) EntityDynamicGenerator.DeltaAssemblyProcessor.eh79NsvGMsWrtjkBuyqL((object) fromMethod);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
              continue;
            case 3:
              this.replaceMethods[toMethod] = methodName;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      private void ProceedTypes()
      {
        int num1 = 2;
        IEnumerator<TypeDefinition> enumerator1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_188;
            case 1:
              goto label_2;
            case 2:
              Collection<TypeDefinition> types = ((ModuleDefinition) this.module).Types;
              // ISSUE: reference to a compiler-generated field
              Func<TypeDefinition, bool> func1 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_0;
              Func<TypeDefinition, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_0 = predicate1 = (Func<TypeDefinition, bool>) (t =>
                {
                  int num2 = 1;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if ((string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.BT0sQpZqaDafrV2McCSg((object) t) != "<Module>")
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return (string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.BT0sQpZqaDafrV2McCSg((object) t) != z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012103625);
label_5:
                  return false;
                });
              }
              else
                goto label_197;
label_190:
              enumerator1 = types.Where<TypeDefinition>(predicate1).GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
label_197:
              predicate1 = func1;
              goto label_190;
            default:
              goto label_185;
          }
        }
label_188:
        return;
label_185:
        return;
label_2:
        try
        {
label_31:
          if (EntityDynamicGenerator.DeltaAssemblyProcessor.nI2mXnvGmait7AmwPp5n((object) enumerator1))
            goto label_91;
          else
            goto label_32;
label_4:
          // ISSUE: variable of a compiler-generated type
          EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_0 cDisplayClass150;
          int num3;
          while (true)
          {
            int num4;
            TypeDefinition typeDefinition1;
            // ISSUE: variable of a compiler-generated type
            EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_2 cDisplayClass152;
            // ISSUE: variable of a compiler-generated type
            EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_1 cDisplayClass151;
            MethodDefinition methodDefinition;
            TypeReference typeReference1;
            Collection<PropertyDefinition>.Enumerator enumerator2;
            Dictionary<TypeReference, TypeDefinition> dictionary;
            Mono.Cecil.CustomAttribute customAttribute1;
            Collection<FieldDefinition>.Enumerator enumerator3;
            TypeReference toType;
            Mono.Cecil.CustomAttribute customAttribute2;
            CustomAttributeArgument constructorArgument;
            TypeDefinition typeDefinition2;
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.newTypes.Add(cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition);
                num3 = 32;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass151.type = EntityDynamicGenerator.DeltaAssemblyProcessor.blrqYKvGjPVUAOiDUwKf(EntityDynamicGenerator.DeltaAssemblyProcessor.o30ebSvG5buVdwaPnnni(EntityDynamicGenerator.DeltaAssemblyProcessor.ve3HnmvGg9SRuNo1X9NL((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition), EntityDynamicGenerator.DeltaAssemblyProcessor.uvMl8QvGxXJLNc1YU10F(1597012150 ^ 1597011124), EntityDynamicGenerator.DeltaAssemblyProcessor.uvMl8QvGxXJLNc1YU10F(1461625753 ^ 1461627319)));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 80 : 68;
                continue;
              case 3:
                Collection<MethodDefinition> methods1 = typeDefinition1.Methods;
                // ISSUE: reference to a compiler-generated field
                Func<MethodDefinition, bool> func2 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_20;
                Func<MethodDefinition, bool> predicate2;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_20 = predicate2 = (Func<MethodDefinition, bool>) (m =>
                  {
                    int num5 = 2;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          goto label_5;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (!((string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.FPSwiEZqAExXcRqpq46x((object) m) == (string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(-97972138 ^ -97955294)))
                          {
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                            continue;
                          }
                          goto label_4;
                        default:
                          goto label_4;
                      }
                    }
label_4:
                    // ISSUE: reference to a compiler-generated method
                    return EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.Fh1EBvZq0Ns5HwrD62ZS((object) m.Parameters) == 1;
label_5:
                    return false;
                  });
                }
                else
                  goto label_144;
label_175:
                methodDefinition = methods1.First<MethodDefinition>(predicate2);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 11 : 28;
                continue;
label_144:
                predicate2 = func2;
                goto label_175;
              case 4:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                Collection<TypeReference> interfaces = cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Interfaces;
                // ISSUE: reference to a compiler-generated field
                Func<TypeReference, bool> func3 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_5;
                Func<TypeReference, bool> predicate3;
                if (func3 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_5 = predicate3 = (Func<TypeReference, bool>) (i =>
                  {
                    int num6 = 1;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          if (EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.pW3aZYZq4faLqLChhLXV((object) i) is AssemblyNameReference assemblyNameReference2)
                          {
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                            continue;
                          }
                          goto label_3;
                        default:
                          goto label_2;
                      }
                    }
label_2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    return EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.DAK0RBZqte1jhB7xkPtu(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.ibb3E9Zq6UxxiCCcIAWq((object) assemblyNameReference2), EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(-1445902765 ^ -1980277732 ^ 539365419));
label_3:
                    return false;
                  });
                }
                else
                  goto label_139;
label_158:
                TypeReference typeReference2 = interfaces.FirstOrDefault<TypeReference>(predicate3);
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.interfaceReference = typeReference2;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 56 : 9;
                continue;
label_139:
                predicate3 = func3;
                goto label_158;
              case 5:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicProvider.AddType(cDisplayClass151.type, cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition);
                num3 = 14;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicProvider.AddType(cDisplayClass152.CS\u0024\u003C\u003E8__locals2.type, cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 7 : 5;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.KBZboEvEGtxDPjt5srNF((object) cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition, EntityDynamicGenerator.DeltaAssemblyProcessor.gE6YgSvEhHS3Vuexw5Hc(EntityDynamicGenerator.DeltaAssemblyProcessor.Y5kG0wvEbiHEwhpSdYxY(this.module)));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 9 : 25;
                continue;
              case 8:
              case 34:
              case 55:
              case 75:
                // ISSUE: reference to a compiler-generated field
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.NHZVdivG9EIWnGIEo7Wb(cDisplayClass151.type, (System.Type) null))
                {
                  num3 = 23;
                  continue;
                }
                goto case 10;
              case 9:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                Collection<TypeDefinition> nestedTypes1 = cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.NestedTypes;
                // ISSUE: reference to a compiler-generated field
                Func<TypeDefinition, bool> func4 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_17;
                Func<TypeDefinition, bool> predicate4;
                if (func4 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_17 = predicate4 = (Func<TypeDefinition, bool>) (t => (string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.FPSwiEZqAExXcRqpq46x((object) t) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487207844));
                }
                else
                  goto label_101;
label_169:
                typeDefinition1 = nestedTypes1.First<TypeDefinition>(predicate4);
                num3 = 82;
                continue;
label_101:
                predicate4 = func4;
                goto label_169;
              case 10:
              case 77:
                // ISSUE: reference to a compiler-generated field
                this.changedTypes.Add(cDisplayClass151.type);
                num3 = 19;
                continue;
              case 11:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass151.CS\u0024\u003C\u003E8__locals1 = cDisplayClass150;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 33 : 15;
                continue;
              case 12:
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.Qwa0HyvGU9pCKbqYjQSr(cDisplayClass151.type);
                num3 = 30;
                continue;
              case 13:
                // ISSUE: reference to a compiler-generated field
                if (cDisplayClass152.dataInterface == null)
                {
                  num3 = 65;
                  continue;
                }
                goto case 49;
              case 14:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EntityDynamicGenerator.configurationModelProperties[(string) EntityDynamicGenerator.DeltaAssemblyProcessor.ve3HnmvGg9SRuNo1X9NL((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition)] = (IDictionary<string, TypeReference>) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition.Properties.ToDictionary<PropertyDefinition, string, TypeReference>((Func<PropertyDefinition, string>) (p => p.Name), (Func<PropertyDefinition, TypeReference>) (p => (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.mGutCLZqwLgNSMZYdHqj((object) p.PropertyType)));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 31 : 28;
                continue;
              case 15:
                ((GenericInstanceType) EntityDynamicGenerator.DeltaAssemblyProcessor.uiODTXvEXjtqE8iVvQ63((object) methodDefinition)).GenericArguments[1] = typeReference1;
                num3 = 69;
                continue;
              case 16:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.eTRpChvES4aQlwFnuCXQ((object) cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Properties);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 20 : 5;
                continue;
              case 17:
                goto label_91;
              case 18:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                enumerator2 = cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Properties.GetEnumerator();
                num3 = 39;
                continue;
              case 19:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                customAttribute1 = cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition.CustomAttributes.SingleOrDefault<Mono.Cecil.CustomAttribute>((Func<Mono.Cecil.CustomAttribute, bool>) (ca => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.DAK0RBZqte1jhB7xkPtu((object) ((MemberReference) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.w6Q6sNZqDUDuN5FbKHke((object) ca)).FullName, (object) TypeOf<EleWise.ELMA.Model.Attributes.FilterForAttribute>.FullName)));
                num3 = 83;
                continue;
              case 20:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Methods.RemoveAll<MethodDefinition>(new Func<MethodDefinition, bool>(cDisplayClass152.CS\u0024\u003C\u003E8__locals2.\u003CProceedTypes\u003Eb__8));
                num3 = 73;
                continue;
              case 21:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.typesToReplace.Add((TypeReference) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition, (TypeReference) null);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                continue;
              case 22:
                // ISSUE: reference to a compiler-generated field
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.CIeW1LvEKJqbRVaJsJ3O((object) cDisplayClass152.dataInterface.Properties) != 0)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 49 : 52;
                  continue;
                }
                goto case 79;
              case 23:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.WvokcgvGc651au2ZrVEN((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition.FullName, EntityDynamicGenerator.DeltaAssemblyProcessor.SgYwTBvGsZXiv9mcMcLn((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 21 : 15;
                continue;
              case 24:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.typesToRename.Add((cDisplayClass152.CS\u0024\u003C\u003E8__locals2.type, cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition, EntityDynamicGenerator.DeltaAssemblyProcessor.dk3BxavEqNqF5pqWao9W((object) dictionary)));
                num3 = 22;
                continue;
              case 25:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                TypeDefinition typeDefinition3 = cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition;
                EntityDynamicGenerator.DeltaAssemblyProcessor.GTCaPpvEfFhWLaE6pBsm((object) typeDefinition3, EntityDynamicGenerator.DeltaAssemblyProcessor.liM4RfvEEUCDxVFNfy8q((object) typeDefinition3) | Mono.Cecil.TypeAttributes.Abstract | Mono.Cecil.TypeAttributes.Sealed);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 4 : 1;
                continue;
              case 26:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.e8DWhivEF9AG02bN9PuV((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition))
                {
                  num3 = 64;
                  continue;
                }
                goto case 45;
              case 27:
                constructorArgument = customAttribute1.ConstructorArguments[0];
                num4 = 85;
                break;
              case 28:
                methodDefinition.ReturnType = typeReference1;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 13 : 72;
                continue;
              case 29:
                if (customAttribute2 != null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 57 : 58;
                  continue;
                }
                goto case 63;
              case 30:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.AddReplace((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition.FullName, (object) EntityDynamicGenerator.CreateReference(cDisplayClass151.type));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 8 : 5;
                continue;
              case 31:
              case 32:
              case 65:
              case 68:
              case 74:
                goto label_31;
              case 33:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass151.type = EntityDynamicGenerator.DeltaAssemblyProcessor.JqxPZcvGJ1K5l85qJuyh((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition);
                num4 = 46;
                break;
              case 35:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.XCdEAevEB8b2mmjLX91w(cDisplayClass151.type, (object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 68 : 33;
                continue;
              case 36:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.OEvGWZvEo54avmnJjd48((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition))
                {
                  num3 = 66;
                  continue;
                }
                goto label_31;
              case 37:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.t0LFWQvGLkwCNOQT7Nkv((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 23 : 55;
                  continue;
                }
                goto case 12;
              case 38:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                Collection<TypeDefinition> nestedTypes2 = cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.NestedTypes;
                // ISSUE: reference to a compiler-generated field
                Func<TypeDefinition, bool> func5 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_10;
                Func<TypeDefinition, bool> predicate5;
                if (func5 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_10 = predicate5 = (Func<TypeDefinition, bool>) (t => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.DAK0RBZqte1jhB7xkPtu(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.FPSwiEZqAExXcRqpq46x((object) t), EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(-1088304168 ^ -1088256680)));
                }
                else
                  goto label_191;
label_166:
                TypeDefinition typeDefinition4 = nestedTypes2.FirstOrDefault<TypeDefinition>(predicate5);
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.dataInterface = typeDefinition4;
                num3 = 13;
                continue;
label_191:
                predicate5 = func5;
                goto label_166;
              case 39:
                try
                {
label_35:
                  if (enumerator2.MoveNext())
                    goto label_37;
                  else
                    goto label_36;
label_34:
                  // ISSUE: variable of a compiler-generated type
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_3 cDisplayClass153;
                  int num7;
                  while (true)
                  {
                    MethodReference toMethod;
                    object obj1;
                    object fromMethod;
                    switch (num7)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated field
                        obj1 = EntityDynamicGenerator.DeltaAssemblyProcessor.Vv3A5dvEZU8w4vZdEDAL((object) cDisplayClass153.property);
                        goto label_54;
                      case 2:
label_46:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        cDisplayClass152.\u003CProceedTypes\u003Eg__ChangeMethod\u007C11((MethodDefinition) EntityDynamicGenerator.DeltaAssemblyProcessor.BygEN7vE8efWKaQSk1lt((object) cDisplayClass153.property), ref cDisplayClass153);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 0;
                        continue;
                      case 3:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        cDisplayClass152.\u003CProceedTypes\u003Eg__ChangeMethod\u007C11((MethodDefinition) EntityDynamicGenerator.DeltaAssemblyProcessor.Vv3A5dvEZU8w4vZdEDAL((object) cDisplayClass153.property), ref cDisplayClass153);
                        num7 = 16;
                        continue;
                      case 4:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass152.oldProperties.Add(cDisplayClass153.property.Name, this.typesToReplace[(TypeReference) cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition]);
                        num7 = 10;
                        continue;
                      case 5:
                      case 12:
                        // ISSUE: reference to a compiler-generated field
                        if (((IEnumerable<char>) EntityDynamicGenerator.DeltaAssemblyProcessor.wInmYJvEv3L9TNLy3x4u((object) cDisplayClass153.property)).Contains<char>('.'))
                        {
                          num7 = 14;
                          continue;
                        }
                        goto case 2;
                      case 6:
                      case 10:
                      case 15:
                      case 16:
                        goto label_35;
                      case 7:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (cDisplayClass152.CS\u0024\u003C\u003E8__locals2.type.GetProperty((string) EntityDynamicGenerator.DeltaAssemblyProcessor.wInmYJvEv3L9TNLy3x4u((object) cDisplayClass153.property), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) != (PropertyInfo) null)
                        {
                          num7 = 4;
                          continue;
                        }
                        goto case 8;
                      case 8:
                        // ISSUE: reference to a compiler-generated field
                        fromMethod = EntityDynamicGenerator.DeltaAssemblyProcessor.BygEN7vE8efWKaQSk1lt((object) cDisplayClass153.property);
                        if (fromMethod == null)
                        {
                          num7 = 13;
                          continue;
                        }
                        break;
                      case 9:
label_38:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass152.oldProperties.Add((string) EntityDynamicGenerator.DeltaAssemblyProcessor.wInmYJvEv3L9TNLy3x4u((object) cDisplayClass153.property), (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.kQK1kPvEIqbY1Us6wjtc(this.module, EntityDynamicGenerator.DeltaAssemblyProcessor.wEI7NVvEuI7pod8jreDD((object) toMethod)));
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 15 : 14;
                        continue;
                      case 11:
                        goto label_37;
                      case 13:
                        // ISSUE: reference to a compiler-generated field
                        fromMethod = EntityDynamicGenerator.DeltaAssemblyProcessor.Vv3A5dvEZU8w4vZdEDAL((object) cDisplayClass153.property);
                        break;
                      case 14:
                        // ISSUE: reference to a compiler-generated field
                        object obj2 = EntityDynamicGenerator.DeltaAssemblyProcessor.BygEN7vE8efWKaQSk1lt((object) cDisplayClass153.property);
                        if (obj2 == null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
                          continue;
                        }
                        obj1 = obj2;
                        goto label_54;
                      default:
                        goto label_21;
                    }
                    if (!EntityDynamicGenerator.TryGetReplace(fromMethod, out toMethod))
                    {
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 5 : 2;
                      continue;
                    }
                    goto label_38;
label_54:
                    if (EntityDynamicGenerator.TryGetReplace((object) ((MethodDefinition) obj1).Overrides.Single<MethodReference>(), out MethodReference _))
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 6;
                    else
                      goto label_46;
                  }
label_36:
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                  goto label_34;
label_37:
                  // ISSUE: reference to a compiler-generated field
                  cDisplayClass153.property = enumerator2.Current;
                  num7 = 7;
                  goto label_34;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                    num8 = 0;
                  switch (num8)
                  {
                    default:
                  }
                }
              case 40:
              case 54:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.oldProperties = new Dictionary<string, TypeReference>();
                num3 = 62;
                continue;
              case 41:
                try
                {
label_133:
                  if (enumerator2.MoveNext())
                    goto label_123;
                  else
                    goto label_134;
label_122:
                  // ISSUE: variable of a compiler-generated type
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_7 cDisplayClass157;
                  TypeReference key;
                  PropertyDefinition propertyDefinition;
                  int num9;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                      case 9:
                        // ISSUE: reference to a compiler-generated field
                        object obj3 = EntityDynamicGenerator.DeltaAssemblyProcessor.Vv3A5dvEZU8w4vZdEDAL((object) cDisplayClass157.property);
                        if (obj3 == null)
                        {
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 13 : 1;
                          continue;
                        }
                        ((MethodDefinition) obj3).Overrides.Add((MethodReference) EntityDynamicGenerator.DeltaAssemblyProcessor.QidgY9vEO7IEW9oKN9td(this.module, (object) propertyDefinition.SetMethod));
                        num9 = 6;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated field
                        object obj4 = EntityDynamicGenerator.DeltaAssemblyProcessor.BygEN7vE8efWKaQSk1lt((object) cDisplayClass157.property);
                        if (obj4 == null)
                        {
                          num9 = 3;
                          continue;
                        }
                        ((MethodDefinition) obj4).Overrides.Clear();
                        num9 = 14;
                        continue;
                      case 3:
                      case 14:
                        // ISSUE: reference to a compiler-generated field
                        object obj5 = EntityDynamicGenerator.DeltaAssemblyProcessor.BygEN7vE8efWKaQSk1lt((object) cDisplayClass157.property);
                        if (obj5 == null)
                        {
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 8 : 1;
                          continue;
                        }
                        ((MethodDefinition) obj5).Overrides.Add((MethodReference) EntityDynamicGenerator.DeltaAssemblyProcessor.QidgY9vEO7IEW9oKN9td(this.module, EntityDynamicGenerator.DeltaAssemblyProcessor.BygEN7vE8efWKaQSk1lt((object) propertyDefinition)));
                        num9 = 4;
                        continue;
                      case 4:
                      case 8:
                        // ISSUE: reference to a compiler-generated field
                        object obj6 = EntityDynamicGenerator.DeltaAssemblyProcessor.Vv3A5dvEZU8w4vZdEDAL((object) cDisplayClass157.property);
                        if (obj6 == null)
                        {
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 9;
                          continue;
                        }
                        EntityDynamicGenerator.DeltaAssemblyProcessor.pqyNxMvE2fjFRux3yLHj((object) ((MethodDefinition) obj6).Overrides);
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
                        continue;
                      case 5:
                      case 6:
                      case 13:
                        goto label_133;
                      case 7:
                        goto label_19;
                      case 10:
                        goto label_123;
                      case 11:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (!cDisplayClass152.oldProperties.TryGetValue(cDisplayClass157.property.Name, out key))
                        {
                          num9 = 5;
                          continue;
                        }
                        goto case 12;
                      case 12:
                        // ISSUE: reference to a compiler-generated method
                        propertyDefinition = dictionary[key].Properties.First<PropertyDefinition>(new Func<PropertyDefinition, bool>(cDisplayClass157.\u003CProceedTypes\u003Eb__23));
                        num9 = 2;
                        continue;
                      default:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass157.property = enumerator2.Current;
                        num9 = 11;
                        continue;
                    }
                  }
label_123:
                  // ISSUE: object of a compiler-generated type is created
                  cDisplayClass157 = new EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_7();
                  num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                  {
                    num9 = 0;
                    goto label_122;
                  }
                  else
                    goto label_122;
label_134:
                  num9 = 7;
                  goto label_122;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                    num10 = 0;
                  switch (num10)
                  {
                    default:
                  }
                }
              case 42:
                goto label_182;
              case 43:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass151 = new EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_1();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 5 : 11;
                continue;
              case 44:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.interfaceReference = toType;
                num3 = 40;
                continue;
              case 45:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.TjsW5bvEWsXmqfRMRj1S((object) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 20 : 61;
                  continue;
                }
                goto case 36;
              case 46:
                // ISSUE: reference to a compiler-generated field
                if (!EntityDynamicGenerator.DeltaAssemblyProcessor.NHZVdivG9EIWnGIEo7Wb(cDisplayClass151.type, (System.Type) null))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 77 : 38;
                  continue;
                }
                goto case 60;
              case 47:
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.bvuQN2vECrVeDy0OfQR8((object) (AssemblyNameReference) EntityDynamicGenerator.DeltaAssemblyProcessor.nSDsHdvEQbrUbcNuMVtd((object) cDisplayClass152.interfaceReference), (object) ConfigurationModelAssemblyBuilder.Version);
                num3 = 54;
                continue;
              case 48:
label_19:
                this.dataClasses.Add(typeDefinition1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 37 : 74;
                continue;
              case 49:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                cDisplayClass152.dataInterface.Properties.RemoveAll<PropertyDefinition>(new Func<PropertyDefinition, bool>(cDisplayClass152.\u003CProceedTypes\u003Eb__16));
                num3 = 9;
                continue;
              case 50:
                enumerator2 = typeDefinition1.Properties.GetEnumerator();
                num3 = 41;
                continue;
              case 51:
                typeDefinition1.Interfaces.AddRange<TypeReference>(dictionary.Values.Select<TypeDefinition, TypeReference>(new Func<TypeDefinition, TypeReference>(((ModuleDefinition) this.module).Import)));
                num3 = 24;
                continue;
              case 52:
              case 53:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                typeReference1 = (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.HmmgRuvGzuZoSyXVH2J0(this.module, cDisplayClass152.CS\u0024\u003C\u003E8__locals2.type.GetNestedType((string) EntityDynamicGenerator.DeltaAssemblyProcessor.uvMl8QvGxXJLNc1YU10F(-1978478350 ^ -1978556814), BindingFlags.NonPublic));
                num3 = 3;
                continue;
              case 56:
                // ISSUE: reference to a compiler-generated field
                if (cDisplayClass152.interfaceReference != null)
                {
                  num3 = 78;
                  continue;
                }
                goto case 40;
              case 57:
label_80:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.h1944kvEVF6xL7w5IdmZ((object) cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Fields);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 16 : 14;
                continue;
              case 58:
                // ISSUE: reference to a compiler-generated field
                System.Type type = cDisplayClass151.type;
                constructorArgument = customAttribute2.ConstructorArguments[0];
                Guid uid = new Guid((string) constructorArgument.Value);
                PublishCacheContext.RemoveFromCache(type, uid);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 63 : 11;
                continue;
              case 59:
label_21:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                enumerator3 = cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Fields.GetEnumerator();
                num3 = 81;
                continue;
              case 60:
                if (!EntityDynamicGenerator.DeltaAssemblyProcessor.TjuKRVvGr77Vq9RWDrQ3(EntityDynamicGenerator.DeltaAssemblyProcessor.Kh22nkvGlDuDhQEdwFuH(EntityDynamicGenerator.DeltaAssemblyProcessor.Yux9bmvGdusih5pI7WbC((object) ((ModuleDefinition) this.module).Assembly)), EntityDynamicGenerator.DeltaAssemblyProcessor.uvMl8QvGxXJLNc1YU10F(-138018305 ^ -138016671)))
                {
                  num3 = 34;
                  continue;
                }
                goto case 2;
              case 61:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.typesToRemove.Add(cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition);
                num3 = 5;
                continue;
              case 62:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                Collection<PropertyDefinition> properties = cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Properties;
                // ISSUE: reference to a compiler-generated field
                Func<PropertyDefinition, string> func6 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_6;
                Func<PropertyDefinition, string> selector;
                if (func6 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_6 = selector = (Func<PropertyDefinition, string>) (p =>
                  {
                    int num11 = 2;
                    int num12;
                    while (true)
                    {
                      switch (num11)
                      {
                        case 1:
                          if (num12 > 0)
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 3 : 3;
                            continue;
                          }
                          goto label_2;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          num12 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.K2FW7cZqHeQHM9ysuHc7((object) p.Name, '.');
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
                          continue;
                        case 3:
                          goto label_3;
                        default:
                          goto label_2;
                      }
                    }
label_2:
                    return (string) null;
label_3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    return (string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.r4oipkZq7WVLtqrR1pxu(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.FPSwiEZqAExXcRqpq46x((object) p), num12 + 1);
                  });
                }
                else
                  goto label_194;
label_161:
                IEnumerable<string> source1 = properties.Select<PropertyDefinition, string>(selector);
                // ISSUE: reference to a compiler-generated field
                Func<string, bool> func7 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_7;
                Func<string, bool> predicate6;
                if (func7 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_7 = predicate6 = (Func<string, bool>) (n => n != null);
                }
                else
                  goto label_193;
label_163:
                HashSet<string> hashSet = source1.Where<string>(predicate6).ToHashSet<string>();
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.interfaceProperties = hashSet;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 16 : 18;
                continue;
label_193:
                predicate6 = func7;
                goto label_163;
label_194:
                selector = func6;
                goto label_161;
              case 63:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.typesToReplace.Add((TypeReference) cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition, (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.HmmgRuvGzuZoSyXVH2J0(this.module, cDisplayClass151.type));
                num3 = 26;
                continue;
              case 64:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.typesToRemove.Add(cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition);
                num4 = 35;
                break;
              case 66:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass152 = new EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_2();
                num3 = 70;
                continue;
              case 67:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.NestedTypes.Remove(cDisplayClass152.dataInterface);
                num3 = 53;
                continue;
              case 69:
                EntityDynamicGenerator.DeltaAssemblyProcessor.cdBAdVvEnWbbUqffIMS1((object) (MethodReference) EntityDynamicGenerator.DeltaAssemblyProcessor.PT5qrFvEkeAydYxrNoNv((object) ((Mono.Cecil.Cil.MethodBody) EntityDynamicGenerator.DeltaAssemblyProcessor.KmMBmEvETLs96EVeDsVO((object) methodDefinition)).Instructions[2]), EntityDynamicGenerator.DeltaAssemblyProcessor.uiODTXvEXjtqE8iVvQ63((object) methodDefinition));
                num3 = 50;
                continue;
              case 70:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.CS\u0024\u003C\u003E8__locals2 = cDisplayClass151;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 6;
                continue;
              case 71:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                typeDefinition2 = cDisplayClass151.CS\u0024\u003C\u003E8__locals1.typeDefinition;
                goto label_154;
              case 72:
                Collection<MethodDefinition> methods2 = typeDefinition1.Methods;
                // ISSUE: reference to a compiler-generated field
                Func<MethodDefinition, bool> func8 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_21;
                Func<MethodDefinition, bool> predicate7;
                if (func8 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_21 = predicate7 = (Func<MethodDefinition, bool>) (m =>
                  {
                    int num13 = 1;
                    while (true)
                    {
                      switch (num13)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if ((string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.FPSwiEZqAExXcRqpq46x((object) m) == (string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(372753449 ^ 372737629))
                          {
                            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_3;
                        default:
                          goto label_2;
                      }
                    }
label_2:
                    // ISSUE: reference to a compiler-generated method
                    return EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.Fh1EBvZq0Ns5HwrD62ZS((object) m.Parameters) == 0;
label_3:
                    return false;
                  });
                }
                else
                  goto label_195;
label_178:
                methodDefinition = methods2.First<MethodDefinition>(predicate7);
                num3 = 15;
                continue;
label_195:
                predicate7 = func8;
                goto label_178;
              case 73:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.NestedTypes.RemoveAll<TypeDefinition>(new Func<TypeDefinition, bool>(cDisplayClass152.\u003CProceedTypes\u003Eb__9));
                num4 = 86;
                break;
              case 76:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass152.interfaceReference = (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.SgYwTBvGsZXiv9mcMcLn((object) cDisplayClass152.interfaceReference);
                num4 = 47;
                break;
              case 78:
                // ISSUE: reference to a compiler-generated field
                if (EntityDynamicGenerator.TryGetReplace((object) cDisplayClass152.interfaceReference, out toType))
                {
                  num3 = 44;
                  continue;
                }
                goto case 76;
              case 79:
                // ISSUE: reference to a compiler-generated field
                typeDefinition1.Interfaces.Remove((TypeReference) cDisplayClass152.dataInterface);
                num3 = 67;
                continue;
              case 80:
                // ISSUE: reference to a compiler-generated field
                if (!EntityDynamicGenerator.DeltaAssemblyProcessor.hZ5pgtvGYIsGToUNxTBI(cDisplayClass151.type, (System.Type) null))
                {
                  num3 = 75;
                  continue;
                }
                goto case 37;
              case 81:
                try
                {
label_66:
                  if (enumerator3.MoveNext())
                    goto label_64;
                  else
                    goto label_67;
label_61:
                  // ISSUE: variable of a compiler-generated type
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_4 cDisplayClass154;
                  int num14;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass154.field = enumerator3.Current;
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 2;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        this.fieldsToReplace.Add((FieldReference) cDisplayClass154.field, new Func<FieldReference>(cDisplayClass154.\u003CProceedTypes\u003Eb__12));
                        num14 = 4;
                        continue;
                      case 3:
                        goto label_64;
                      case 4:
                        goto label_66;
                      case 5:
                        goto label_80;
                      default:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass154.CS\u0024\u003C\u003E8__locals3 = cDisplayClass152;
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
                        continue;
                    }
                  }
label_64:
                  // ISSUE: object of a compiler-generated type is created
                  cDisplayClass154 = new EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_4();
                  num14 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                  {
                    num14 = 0;
                    goto label_61;
                  }
                  else
                    goto label_61;
label_67:
                  num14 = 5;
                  goto label_61;
                }
                finally
                {
                  enumerator3.Dispose();
                  int num15 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                    num15 = 0;
                  switch (num15)
                  {
                    default:
                  }
                }
              case 82:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                IEnumerable<TypeReference> source2 = cDisplayClass152.oldProperties.Values.Append<TypeReference>(this.typesToReplace[(TypeReference) cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition]).Distinct<TypeReference>((IEqualityComparer<TypeReference>) EntityDynamicGenerator.DeltaAssemblyProcessor.QIxgXxvERds4rycVaNVm());
                // ISSUE: reference to a compiler-generated field
                Func<TypeReference, TypeDefinition> func9 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_19;
                Func<TypeReference, TypeDefinition> elementSelector;
                if (func9 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_19 = elementSelector = (Func<TypeReference, TypeDefinition>) (t =>
                  {
                    // ISSUE: reference to a compiler-generated method
                    Collection<TypeDefinition> nestedTypes3 = ((TypeDefinition) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.eMA0uCZqxnDcUk8Z77vt((object) t)).NestedTypes;
                    // ISSUE: reference to a compiler-generated field
                    Func<TypeDefinition, bool> func10 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_22;
                    Func<TypeDefinition, bool> predicate8;
                    if (func10 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__15_22 = predicate8 = (Func<TypeDefinition, bool>) (t2 => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.DAK0RBZqte1jhB7xkPtu(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.FPSwiEZqAExXcRqpq46x((object) t2), EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(-2106517564 ^ -2106435260)));
                    }
                    else
                      goto label_1;
label_3:
                    return nestedTypes3.First<TypeDefinition>(predicate8);
label_1:
                    predicate8 = func10;
                    goto label_3;
                  });
                }
                else
                  goto label_196;
label_172:
                object comparer = EntityDynamicGenerator.DeltaAssemblyProcessor.QIxgXxvERds4rycVaNVm();
                dictionary = source2.ToDictionary<TypeReference, TypeReference, TypeDefinition>((Func<TypeReference, TypeReference>) (t => t), elementSelector, (IEqualityComparer<TypeReference>) comparer);
                num3 = 51;
                continue;
label_196:
                elementSelector = func9;
                goto label_172;
              case 83:
                if (customAttribute1 != null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 27 : 3;
                  continue;
                }
                goto case 71;
              case 84:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass150.\u003C\u003E4__this = this;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                continue;
              case 85:
                typeDefinition2 = ((TypeReference) constructorArgument.Value).Resolve();
                goto label_154;
              case 86:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.fiJ5oMvEiWsx9rNYFLiI((object) cDisplayClass152.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.typeDefinition.Interfaces);
                num3 = 38;
                continue;
              default:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass150.typeDefinition = enumerator1.Current;
                num4 = 43;
                break;
            }
            num3 = num4;
            continue;
label_154:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            customAttribute2 = typeDefinition2.CustomAttributes.SingleOrDefault<Mono.Cecil.CustomAttribute>((Func<Mono.Cecil.CustomAttribute, bool>) (ca => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.DAK0RBZqte1jhB7xkPtu((object) ((MemberReference) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.w6Q6sNZqDUDuN5FbKHke((object) ca)).FullName, (object) TypeOf<UidAttribute>.FullName)));
            num3 = 29;
          }
label_182:
          return;
label_32:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 42 : 25;
          goto label_4;
label_91:
          // ISSUE: object of a compiler-generated type is created
          cDisplayClass150 = new EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass15_0();
          num3 = 84;
          goto label_4;
        }
        finally
        {
          int num16;
          if (enumerator1 == null)
            num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
          else
            goto label_183;
label_181:
          switch (num16)
          {
            case 2:
              break;
            default:
          }
label_183:
          EntityDynamicGenerator.DeltaAssemblyProcessor.UwdDNsvGyVPTLJ7XKuQ5((object) enumerator1);
          num16 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          {
            num16 = 0;
            goto label_181;
          }
          else
            goto label_181;
        }
      }

      private void ProceedPublicApi(
        TypeDefinition typeDefinition,
        IDictionary<TypeReference, string> publicApiReplaces)
      {
        if (typeDefinition == null)
          return;
        System.Type type1 = EntityDynamicGenerator.Resolve((TypeReference) typeDefinition);
        if (type1 == (System.Type) null)
        {
          EntityDynamicGenerator.AddReplace((object) typeDefinition.FullName, (object) typeDefinition);
          publicApiReplaces.Add((TypeReference) typeDefinition, typeDefinition.FullName);
          this.typesToReplace.Add((TypeReference) typeDefinition, (TypeReference) null);
          this.newPublicApiTypes.Add(typeDefinition);
        }
        else
        {
          this.typesToReplace.Add((TypeReference) typeDefinition, ((ModuleDefinition) this.module).Import(type1));
          bool isRoot = typeDefinition.DeclaringType == null;
          MethodDefinition methodDefinition1 = typeDefinition.Methods.FirstOrDefault<MethodDefinition>((Func<MethodDefinition, bool>) (m =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (m.IsConstructor)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            return EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_0.vqKZGjZK54yp7cMp07Ai((object) m) == isRoot;
label_3:
            return false;
          }));
          if (isRoot)
          {
            typeDefinition.Methods.RemoveAll<MethodDefinition>((Func<MethodDefinition, bool>) (m =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.KIQ1xvZqmIxNvcoFT5wd((object) m))
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              return !EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.EnQ4M9Zqy7WceLJ4Nj9m((object) m);
label_3:
              return false;
            }));
          }
          else
          {
            methodDefinition1.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107674118);
            methodDefinition1.HasThis = false;
            methodDefinition1.Attributes = Mono.Cecil.MethodAttributes.Private | Mono.Cecil.MethodAttributes.Static | Mono.Cecil.MethodAttributes.HideBySig | Mono.Cecil.MethodAttributes.SpecialName | Mono.Cecil.MethodAttributes.RTSpecialName;
            int index = methodDefinition1.Body.Instructions.Count - 3;
            methodDefinition1.Body.Instructions.RemoveAt(index);
            methodDefinition1.Body.Instructions.RemoveAt(index);
          }
          typeDefinition.BaseType = ((ModuleDefinition) this.module).TypeSystem.Object;
          typeDefinition.Attributes |= Mono.Cecil.TypeAttributes.Abstract | Mono.Cecil.TypeAttributes.Sealed;
          foreach (PropertyDefinition propertyDefinition in typeDefinition.Properties.ToArray())
          {
            PropertyDefinition property = propertyDefinition;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            FieldDefinition field = typeDefinition.Fields.First<FieldDefinition>((Func<FieldDefinition, bool>) (f => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_1.GEDndQZKcggdJQfs1j57((object) f) == EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_1.V05x82ZKzxyvjGiLl8SP((object) property)));
            if (EntityDynamicGenerator.TryGetReplace((object) property.GetMethod, out MethodReference _) || type1.GetProperty(property.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public) != (PropertyInfo) null)
            {
              Instruction instruction = methodDefinition1 != null ? methodDefinition1.Body.Instructions.FirstOrDefault<Instruction>((Func<Instruction, bool>) (i =>
              {
                int num = 1;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_2.aW9EZ2ZXbMZjrD28tT69((object) i) is FieldDefinition fieldDefinition2)
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return fieldDefinition2 == field;
label_5:
                return false;
              })) : (Instruction) null;
              if (instruction != null)
              {
                if (!field.IsStatic)
                  methodDefinition1.Body.Instructions.Remove(instruction.Previous.Previous);
                methodDefinition1.Body.Instructions.Remove(instruction.Previous);
                methodDefinition1.Body.Instructions.Remove(instruction);
              }
              typeDefinition.Fields.Remove(field);
              typeDefinition.Methods.Remove(property.GetMethod);
              typeDefinition.Properties.Remove(property);
            }
            else
            {
              this.AddMethodReplace((MethodReference) property.GetMethod, property.GetMethod);
              if (!property.GetMethod.IsStatic)
              {
                field.Attributes = Mono.Cecil.FieldAttributes.Private | Mono.Cecil.FieldAttributes.Static | Mono.Cecil.FieldAttributes.InitOnly;
                property.GetMethod.Attributes = Mono.Cecil.MethodAttributes.Public | Mono.Cecil.MethodAttributes.Static;
                property.GetMethod.Overrides.Clear();
                property.GetMethod.HasThis = false;
                property.GetMethod.Parameters.Insert(0, new ParameterDefinition(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323243820), Mono.Cecil.ParameterAttributes.In, ((ModuleDefinition) this.module).Import(type1)));
                property.GetMethod.Body.Instructions.RemoveAt(0);
                property.GetMethod.Body.Instructions[0].OpCode = OpCodes.Ldsfld;
                Instruction instruction = methodDefinition1 != null ? methodDefinition1.Body.Instructions.FirstOrDefault<Instruction>((Func<Instruction, bool>) (i =>
                {
                  int num = 1;
                  while (true)
                  {
                    switch (num)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_2.aW9EZ2ZXbMZjrD28tT69((object) i) is FieldDefinition fieldDefinition4)
                        {
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_3;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  return fieldDefinition4 == field;
label_3:
                  return false;
                })) : (Instruction) null;
                if (instruction != null)
                {
                  methodDefinition1.Body.Instructions.Remove(instruction.Previous.Previous);
                  instruction.OpCode = OpCodes.Stsfld;
                }
                typeDefinition.Properties.Remove(property);
              }
            }
          }
          foreach (MethodDefinition methodDefinition2 in typeDefinition.Methods.Where<MethodDefinition>((Func<MethodDefinition, bool>) (m =>
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_3;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  if (EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_0.FG2dXgZKjteJ4Q5TSN16((object) m))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
                    continue;
                  }
                  goto label_2;
                default:
                  goto label_2;
              }
            }
label_2:
            return !this.replaceMethods.ContainsKey(m);
label_3:
            return false;
          })).ToArray<MethodDefinition>())
          {
            MethodReference m;
            if (EntityDynamicGenerator.TryGetReplace((object) methodDefinition2, out m))
            {
              typeDefinition.Methods.Remove(methodDefinition2);
              // ISSUE: reference to a compiler-generated method
              this.methodsToReplace.Add((MethodReference) methodDefinition2, (Func<MethodReference>) (() => (MethodReference) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_3.d0aBhJZXQ6YyxChqrAeD(this.module, (object) m)));
            }
            else if (type1.GetMember(methodDefinition2.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).Length != 0)
            {
              string methodName = methodDefinition2.FullName;
              typeDefinition.Methods.Remove(methodDefinition2);
              this.methodsToReplace.Add((MethodReference) methodDefinition2, (Func<MethodReference>) (() =>
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                throw new NotImplementedException((string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_4.lKm8UxZXIBdIa8m2jbmB(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass16_4.jMYcQIZXuDFf0q7dAFgb(516838154 ^ 516456178), (object) methodName));
              }));
            }
            else if (!methodDefinition2.IsGetter)
            {
              this.AddMethodReplace((MethodReference) methodDefinition2, methodDefinition2);
              this.methodsToReplace.Add((MethodReference) methodDefinition2, (MethodReference) methodDefinition2);
              TypeReference typeReference = ((ModuleDefinition) this.module).Import(type1);
              if (type1.IsGenericType)
              {
                GenericInstanceType type2 = new GenericInstanceType(typeReference);
                type2.GenericArguments.AddRange<TypeReference>((IEnumerable<TypeReference>) typeDefinition.GenericParameters);
                typeReference = ((ModuleDefinition) this.module).Import((TypeReference) type2);
              }
              methodDefinition2.Attributes = Mono.Cecil.MethodAttributes.Public | Mono.Cecil.MethodAttributes.Static;
              methodDefinition2.Overrides.Clear();
              methodDefinition2.HasThis = false;
              methodDefinition2.Parameters.Insert(0, new ParameterDefinition(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70193858), Mono.Cecil.ParameterAttributes.In, typeReference));
            }
          }
          typeDefinition.NestedTypes.ForEach<TypeDefinition>((Action<TypeDefinition>) (t =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  this.ProceedPublicApi(t, publicApiReplaces);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          // ISSUE: reference to a compiler-generated method
          if (!typeDefinition.NestedTypes.All<TypeDefinition>(new Func<TypeDefinition, bool>(((ICollection<TypeDefinition>) this.typesToRemove).Contains)) || !typeDefinition.Methods.All<MethodDefinition>((Func<MethodDefinition, bool>) (m => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.KIQ1xvZqmIxNvcoFT5wd((object) m))))
            return;
          this.typesToRemove.Add(typeDefinition);
        }
      }

      private void ReplaceTypes()
      {
        int num1 = 4;
        IEnumerator<TypeDefinition> enumerator1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_198;
            case 2:
label_183:
              EntityDynamicGenerator.UpdateModule(this.module, this.typesToReplace, (IDictionary<MethodReference, MethodReference>) this.methodsToReplace, (IDictionary<FieldReference, FieldReference>) this.fieldsToReplace, (Func<TypeDefinition, bool>) (t => !this.typesToRemove.Contains(t)));
              num1 = 5;
              continue;
            case 3:
            case 9:
              IEnumerable<TypeReference> typeReferences = ((ModuleDefinition) this.module).GetTypeReferences();
              // ISSUE: reference to a compiler-generated field
              Func<TypeReference, bool> func1 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_2;
              Func<TypeReference, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_2 = predicate1 = (Func<TypeReference, bool>) (t =>
                {
                  int num2 = 2;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        goto label_8;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        if (!(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.pW3aZYZq4faLqLChhLXV((object) t) is AssemblyNameReference assemblyNameReference2))
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
                          continue;
                        }
                        break;
                      case 3:
                        goto label_6;
                    }
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (!EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.DAK0RBZqte1jhB7xkPtu(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.ibb3E9Zq6UxxiCCcIAWq((object) assemblyNameReference2), EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(572119659 - -337058038 ^ 909179141)))
                      num2 = 3;
                    else
                      goto label_7;
                  }
label_6:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  return EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.DAK0RBZqte1jhB7xkPtu(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.ibb3E9Zq6UxxiCCcIAWq((object) assemblyNameReference2), EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.a9fLdkZqNth1063Ec3v1(-488881205 ^ -488879643));
label_7:
                  return true;
label_8:
                  return false;
                });
              }
              else
                goto label_166;
label_193:
              IEnumerable<TypeReference> source1 = typeReferences.Where<TypeReference>(predicate1);
              // ISSUE: reference to a compiler-generated field
              Func<TypeReference, (TypeReference, System.Type)> func2 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_3;
              Func<TypeReference, (TypeReference, System.Type)> selector;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_3 = selector = (Func<TypeReference, (TypeReference, System.Type)>) (t => (t, EntityDynamicGenerator.Resolve(t)));
              }
              else
                goto label_173;
label_196:
              source1.Select<TypeReference, (TypeReference, System.Type)>(selector).Where<(TypeReference, System.Type)>((Func<(TypeReference, System.Type), bool>) (t =>
              {
                string name = t.type?.Assembly.GetName().Name;
                return name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317792434) || name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740336584);
              })).GroupBy<(TypeReference, System.Type), string>((Func<(TypeReference, System.Type), string>) (t => t.type.Assembly.FullName)).ForEach<IGrouping<string, (TypeReference, System.Type)>>((Action<IGrouping<string, (TypeReference, System.Type)>>) (g =>
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                AssemblyNameReference assemblyReference = ((ModuleDefinition) this.module).AssemblyReferences.FirstOrDefault<AssemblyNameReference>((Func<AssemblyNameReference, bool>) (r => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass17_0.DjTvZCZXKGvn6gcl6d1N(EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec__DisplayClass17_0.JcIT5dZXqbuFuTgRO9ms((object) r), (object) g.Key)));
                if (assemblyReference == null)
                  assemblyReference = (AssemblyNameReference) ((ModuleDefinition) this.module).Import(g.First<(TypeReference, System.Type)>().Item2).Scope;
                g.ForEach<(TypeReference, System.Type)>((Action<(TypeReference, System.Type)>) (t =>
                {
                  t.typeReference.Scope = (IMetadataScope) assemblyReference;
                  this.typesToReplace[t.typeReference] = t.typeReference;
                }));
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 5 : 8;
              continue;
label_173:
              selector = func2;
              goto label_196;
label_166:
              predicate1 = func1;
              goto label_193;
            case 4:
              if (EntityDynamicGenerator.DeltaAssemblyProcessor.op17aRvEeJTqV24h5Mhd((object) this.typesToReplace) <= 0)
              {
                num1 = 3;
                continue;
              }
              break;
            case 5:
              this.typesToRemove.Count<TypeDefinition>((Func<TypeDefinition, bool>) (t =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (((ModuleDefinition) this.module).Types.Remove(t))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                return ((TypeDefinition) EntityDynamicGenerator.DeltaAssemblyProcessor.JtJ2RSvElF2LQ8W7yaej((object) t)).NestedTypes.Remove(t);
label_3:
                return true;
              }));
              num1 = 9;
              continue;
            case 6:
              goto label_143;
            case 7:
              try
              {
label_49:
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.nI2mXnvGmait7AmwPp5n((object) enumerator1))
                  goto label_24;
                else
                  goto label_50;
label_5:
                TypeReference replaceTo;
                TypeDefinition current1;
                Collection<MethodDefinition>.Enumerator enumerator2;
                int num4;
                while (true)
                {
                  Collection<PropertyDefinition>.Enumerator enumerator3;
                  int index1;
                  Collection<FieldDefinition>.Enumerator enumerator4;
                  Collection<GenericParameter>.Enumerator enumerator5;
                  switch (num4)
                  {
                    case 1:
label_45:
                      enumerator2 = current1.Methods.GetEnumerator();
                      num4 = 11;
                      continue;
                    case 2:
                      goto label_24;
                    case 3:
label_22:
                      enumerator3 = current1.Properties.GetEnumerator();
                      num4 = 5;
                      continue;
                    case 4:
                    case 9:
                      if (index1 >= EntityDynamicGenerator.DeltaAssemblyProcessor.m8VANjvE1F9DxbXsAeqQ((object) current1.Interfaces))
                      {
                        num4 = 12;
                        continue;
                      }
                      goto case 18;
                    case 5:
                      try
                      {
label_13:
                        if (enumerator3.MoveNext())
                          goto label_9;
                        else
                          goto label_14;
label_7:
                        PropertyDefinition current2;
                        int num5;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                            case 4:
                              goto label_13;
                            case 2:
                              EntityDynamicGenerator.DeltaAssemblyProcessor.sLLA6YvE36yJ9IJU38Mo((object) current2, (object) replaceTo);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
                              continue;
                            case 3:
                              goto label_9;
                            case 5:
                              goto label_23;
                            default:
                              if (!EntityDynamicGenerator.CheckType(this.typesToReplace, EntityDynamicGenerator.DeltaAssemblyProcessor.qjh1ZbvENiKg7TDriHC9((object) current2), out replaceTo))
                              {
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 1;
                                continue;
                              }
                              goto case 2;
                          }
                        }
label_9:
                        current2 = enumerator3.Current;
                        num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                        {
                          num5 = 0;
                          goto label_7;
                        }
                        else
                          goto label_7;
label_14:
                        num5 = 5;
                        goto label_7;
                      }
                      finally
                      {
                        enumerator3.Dispose();
                        int num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                          num6 = 0;
                        switch (num6)
                        {
                          default:
                        }
                      }
                    case 6:
                      ++index1;
                      num4 = 4;
                      continue;
                    case 7:
                      try
                      {
label_39:
                        if (enumerator5.MoveNext())
                          goto label_32;
                        else
                          goto label_40;
label_29:
                        GenericParameter current3;
                        int num7;
                        while (true)
                        {
                          int index2;
                          switch (num7)
                          {
                            case 1:
                              goto label_22;
                            case 2:
                              goto label_32;
                            case 3:
                            case 4:
                              if (index2 >= EntityDynamicGenerator.DeltaAssemblyProcessor.m8VANjvE1F9DxbXsAeqQ((object) current3.Constraints))
                              {
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 9;
                                continue;
                              }
                              goto case 7;
                            case 5:
                              index2 = 0;
                              num7 = 4;
                              continue;
                            case 6:
                            case 8:
                              ++index2;
                              num7 = 3;
                              continue;
                            case 7:
                              if (!EntityDynamicGenerator.CheckType(this.typesToReplace, (object) current3.Constraints[index2], out replaceTo))
                              {
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 8 : 1;
                                continue;
                              }
                              break;
                            case 9:
                              goto label_39;
                          }
                          current3.Constraints[index2] = replaceTo;
                          num7 = 6;
                        }
label_32:
                        current3 = enumerator5.Current;
                        num7 = 5;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                        {
                          num7 = 1;
                          goto label_29;
                        }
                        else
                          goto label_29;
label_40:
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                        goto label_29;
                      }
                      finally
                      {
                        enumerator5.Dispose();
                        int num8 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                          num8 = 0;
                        switch (num8)
                        {
                          default:
                        }
                      }
                    case 8:
                      try
                      {
label_130:
                        if (enumerator4.MoveNext())
                          goto label_128;
                        else
                          goto label_131;
label_124:
                        FieldDefinition current4;
                        int num9;
                        while (true)
                        {
                          switch (num9)
                          {
                            case 1:
                              goto label_45;
                            case 2:
                              goto label_128;
                            case 3:
                              current4.FieldType = replaceTo;
                              num9 = 5;
                              continue;
                            case 4:
                            case 5:
                              goto label_130;
                            default:
                              if (!EntityDynamicGenerator.CheckType(this.typesToReplace, EntityDynamicGenerator.DeltaAssemblyProcessor.KTqbO4vEpugjJbiVEwWx((object) current4), out replaceTo))
                              {
                                num9 = 4;
                                continue;
                              }
                              goto case 3;
                          }
                        }
label_128:
                        current4 = enumerator4.Current;
                        num9 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                        {
                          num9 = 0;
                          goto label_124;
                        }
                        else
                          goto label_124;
label_131:
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
                        goto label_124;
                      }
                      finally
                      {
                        enumerator4.Dispose();
                        int num10 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                          num10 = 0;
                        switch (num10)
                        {
                          default:
                        }
                      }
                    case 10:
                      goto label_49;
                    case 11:
                      goto label_52;
                    case 12:
                      enumerator5 = current1.GenericParameters.GetEnumerator();
                      num4 = 7;
                      continue;
                    case 13:
                      goto label_183;
                    case 14:
                      EntityDynamicGenerator.DeltaAssemblyProcessor.KBZboEvEGtxDPjt5srNF((object) current1, (object) replaceTo);
                      num4 = 15;
                      continue;
                    case 15:
                      index1 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 9 : 9;
                      continue;
                    case 16:
                      current1.Interfaces[index1] = replaceTo;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 6 : 6;
                      continue;
                    case 17:
                      if (EntityDynamicGenerator.CheckType(this.typesToReplace, EntityDynamicGenerator.DeltaAssemblyProcessor.n1C8QQvEPfDxcYobxkov((object) current1), out replaceTo))
                      {
                        num4 = 14;
                        continue;
                      }
                      goto case 15;
                    case 18:
                      if (EntityDynamicGenerator.CheckType(this.typesToReplace, (object) current1.Interfaces[index1], out replaceTo))
                      {
                        num4 = 16;
                        continue;
                      }
                      goto case 6;
                  }
label_23:
                  enumerator4 = current1.Fields.GetEnumerator();
                  num4 = 8;
                }
label_52:
                try
                {
label_104:
                  if (enumerator2.MoveNext())
                    goto label_100;
                  else
                    goto label_105;
label_53:
                  MethodDefinition current5;
                  Collection<VariableDefinition>.Enumerator enumerator6;
                  int num11;
                  while (true)
                  {
                    Collection<ParameterDefinition>.Enumerator enumerator7;
                    Collection<MethodReference>.Enumerator enumerator8;
                    switch (num11)
                    {
                      case 1:
                      case 8:
                        enumerator7 = current5.Parameters.GetEnumerator();
                        num11 = 5;
                        continue;
                      case 2:
                        if (!EntityDynamicGenerator.CheckType(this.typesToReplace, EntityDynamicGenerator.DeltaAssemblyProcessor.uiODTXvEXjtqE8iVvQ63((object) current5), out replaceTo))
                        {
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
                          continue;
                        }
                        break;
                      case 3:
label_101:
                        if (EntityDynamicGenerator.DeltaAssemblyProcessor.FNDHCWvEwxkjiP3j2p54((object) current5))
                        {
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 6;
                          continue;
                        }
                        goto label_104;
                      case 4:
label_103:
                        enumerator8 = current5.Overrides.GetEnumerator();
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 8 : 11;
                        continue;
                      case 5:
                        try
                        {
label_58:
                          if (enumerator7.MoveNext())
                            goto label_60;
                          else
                            goto label_59;
label_55:
                          ParameterDefinition current6;
                          int num12;
                          while (true)
                          {
                            switch (num12)
                            {
                              case 1:
                                goto label_58;
                              case 2:
                                if (EntityDynamicGenerator.CheckType(this.typesToReplace, EntityDynamicGenerator.DeltaAssemblyProcessor.aW4AbAvEDOW3qvItRHmw((object) current6), out replaceTo))
                                {
                                  num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 3;
                                  continue;
                                }
                                goto label_58;
                              case 3:
                                EntityDynamicGenerator.DeltaAssemblyProcessor.NMaT1QvEtIbaq3NV2y7o((object) current6, (object) replaceTo);
                                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
                                continue;
                              case 4:
                                goto label_60;
                              default:
                                goto label_103;
                            }
                          }
label_59:
                          num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                          goto label_55;
label_60:
                          current6 = enumerator7.Current;
                          num12 = 2;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                          {
                            num12 = 0;
                            goto label_55;
                          }
                          else
                            goto label_55;
                        }
                        finally
                        {
                          enumerator7.Dispose();
                          int num13 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                            num13 = 0;
                          switch (num13)
                          {
                            default:
                          }
                        }
                      case 6:
                        enumerator6 = ((Mono.Cecil.Cil.MethodBody) EntityDynamicGenerator.DeltaAssemblyProcessor.KmMBmEvETLs96EVeDsVO((object) current5)).Variables.GetEnumerator();
                        num11 = 10;
                        continue;
                      case 7:
                        goto label_104;
                      case 9:
                        goto label_49;
                      case 10:
                        goto label_106;
                      case 11:
                        try
                        {
label_86:
                          if (enumerator8.MoveNext())
                            goto label_89;
                          else
                            goto label_87;
label_68:
                          int num14;
                          int num15 = num14;
label_69:
                          MethodReference current7;
                          while (true)
                          {
                            switch (num15)
                            {
                              case 1:
                                goto label_86;
                              case 2:
                                goto label_72;
                              case 3:
                                goto label_101;
                              case 4:
                                if (!EntityDynamicGenerator.CheckType(this.typesToReplace, EntityDynamicGenerator.DeltaAssemblyProcessor.uiODTXvEXjtqE8iVvQ63((object) current7), out replaceTo))
                                  goto case 5;
                                else
                                  goto label_71;
                              case 5:
                                enumerator7 = current7.Parameters.GetEnumerator();
                                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 6;
                                continue;
                              case 6:
                                goto label_73;
                              default:
                                goto label_89;
                            }
                          }
label_71:
                          num14 = 2;
                          goto label_68;
label_72:
                          EntityDynamicGenerator.DeltaAssemblyProcessor.qkerTuvEaifyqiVXDWjc((object) current7, (object) replaceTo);
                          num14 = 5;
                          goto label_68;
label_73:
                          try
                          {
label_80:
                            if (enumerator7.MoveNext())
                              goto label_75;
                            else
                              goto label_81;
label_74:
                            ParameterDefinition current8;
                            int num16;
                            while (true)
                            {
                              switch (num16)
                              {
                                case 1:
                                  current8.ParameterType = replaceTo;
                                  num16 = 2;
                                  continue;
                                case 2:
                                case 5:
                                  goto label_80;
                                case 3:
                                  goto label_75;
                                case 4:
                                  goto label_86;
                                default:
                                  if (!EntityDynamicGenerator.CheckType(this.typesToReplace, EntityDynamicGenerator.DeltaAssemblyProcessor.aW4AbAvEDOW3qvItRHmw((object) current8), out replaceTo))
                                  {
                                    num16 = 5;
                                    continue;
                                  }
                                  goto case 1;
                              }
                            }
label_75:
                            current8 = enumerator7.Current;
                            num16 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                            {
                              num16 = 0;
                              goto label_74;
                            }
                            else
                              goto label_74;
label_81:
                            num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 4 : 3;
                            goto label_74;
                          }
                          finally
                          {
                            enumerator7.Dispose();
                            int num17 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
                              num17 = 0;
                            switch (num17)
                            {
                              default:
                            }
                          }
label_87:
                          num14 = 3;
                          goto label_68;
label_89:
                          current7 = enumerator8.Current;
                          num15 = 2;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                          {
                            num15 = 4;
                            goto label_69;
                          }
                          else
                            goto label_69;
                        }
                        finally
                        {
                          enumerator8.Dispose();
                          int num18 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
                            num18 = 0;
                          switch (num18)
                          {
                            default:
                          }
                        }
                      case 12:
                        goto label_100;
                    }
                    EntityDynamicGenerator.DeltaAssemblyProcessor.qkerTuvEaifyqiVXDWjc((object) current5, (object) replaceTo);
                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 4 : 8;
                  }
label_106:
                  try
                  {
label_109:
                    if (enumerator6.MoveNext())
                      goto label_111;
                    else
                      goto label_110;
label_107:
                    VariableDefinition current9;
                    int num19;
                    while (true)
                    {
                      switch (num19)
                      {
                        case 1:
                        case 5:
                          goto label_109;
                        case 2:
                          current9.VariableType = replaceTo;
                          num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                          continue;
                        case 3:
                          if (!EntityDynamicGenerator.CheckType(this.typesToReplace, (object) current9.VariableType, out replaceTo))
                          {
                            num19 = 5;
                            continue;
                          }
                          goto case 2;
                        case 4:
                          goto label_111;
                        default:
                          goto label_104;
                      }
                    }
label_110:
                    num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                    goto label_107;
label_111:
                    current9 = enumerator6.Current;
                    num19 = 3;
                    goto label_107;
                  }
                  finally
                  {
                    enumerator6.Dispose();
                    int num20 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                      num20 = 0;
                    switch (num20)
                    {
                      default:
                    }
                  }
label_100:
                  current5 = enumerator2.Current;
                  num11 = 2;
                  goto label_53;
label_105:
                  num11 = 9;
                  goto label_53;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num21 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                    num21 = 0;
                  switch (num21)
                  {
                    default:
                  }
                }
label_24:
                current1 = enumerator1.Current;
                num4 = 17;
                goto label_5;
label_50:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 13;
                goto label_5;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num22 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                    num22 = 0;
                  while (true)
                  {
                    switch (num22)
                    {
                      case 1:
                        goto label_142;
                      default:
                        EntityDynamicGenerator.DeltaAssemblyProcessor.UwdDNsvGyVPTLJ7XKuQ5((object) enumerator1);
                        num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_142:;
              }
            case 8:
              Collection<TypeDefinition> types1 = ((ModuleDefinition) this.module).Types;
              // ISSUE: reference to a compiler-generated field
              Func<TypeDefinition, bool> func3 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_12;
              Func<TypeDefinition, bool> predicate2;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_12 = predicate2 = (Func<TypeDefinition, bool>) (t => (string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.BT0sQpZqaDafrV2McCSg((object) t) != "<Module>");
              }
              else
                goto label_201;
label_200:
              enumerator1 = types1.Where<TypeDefinition>(predicate2).SelectRecursive<TypeDefinition>((Func<TypeDefinition, IEnumerable<TypeDefinition>>) (t => (IEnumerable<TypeDefinition>) t.NestedTypes)).GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 6 : 1;
              continue;
label_201:
              predicate2 = func3;
              goto label_200;
          }
          Collection<TypeDefinition> types2 = ((ModuleDefinition) this.module).Types;
          // ISSUE: reference to a compiler-generated field
          Func<TypeDefinition, bool> func4 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_7;
          Func<TypeDefinition, bool> predicate3;
          if (func4 == null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_7 = predicate3 = (Func<TypeDefinition, bool>) (t => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.HN21ihZqMVIOkiokLc79((object) t.FullName, (object) "<Module>"));
          }
          else
            goto label_187;
label_186:
          IEnumerable<TypeDefinition> source2 = types2.Where<TypeDefinition>(predicate3);
          // ISSUE: reference to a compiler-generated field
          Func<TypeDefinition, IEnumerable<TypeDefinition>> func5 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_8;
          Func<TypeDefinition, IEnumerable<TypeDefinition>> recursiveSelector;
          if (func5 == null)
          {
            // ISSUE: reference to a compiler-generated field
            EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_8 = recursiveSelector = (Func<TypeDefinition, IEnumerable<TypeDefinition>>) (t => (IEnumerable<TypeDefinition>) t.NestedTypes);
          }
          else
            goto label_191;
label_189:
          enumerator1 = source2.SelectRecursive<TypeDefinition>(recursiveSelector).Where<TypeDefinition>((Func<TypeDefinition, bool>) (t => !this.typesToRemove.Contains(t))).GetEnumerator();
          num1 = 7;
          continue;
label_191:
          recursiveSelector = func5;
          goto label_189;
label_187:
          predicate3 = func4;
          goto label_186;
        }
label_198:
        return;
label_143:
        try
        {
label_170:
          if (EntityDynamicGenerator.DeltaAssemblyProcessor.nI2mXnvGmait7AmwPp5n((object) enumerator1))
            goto label_168;
          else
            goto label_171;
label_144:
          IEnumerator<Mono.Cecil.CustomAttribute> enumerator9;
          TypeDefinition current10;
          int num23;
          while (true)
          {
            switch (num23)
            {
              case 1:
                goto label_168;
              case 2:
                goto label_170;
              case 3:
                goto label_145;
              case 4:
                goto label_194;
              default:
                Collection<Mono.Cecil.CustomAttribute> customAttributes = current10.CustomAttributes;
                Collection<PropertyDefinition> properties = current10.Properties;
                // ISSUE: reference to a compiler-generated field
                Func<PropertyDefinition, IEnumerable<Mono.Cecil.CustomAttribute>> func = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_14;
                Func<PropertyDefinition, IEnumerable<Mono.Cecil.CustomAttribute>> selector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__17_14 = selector = (Func<PropertyDefinition, IEnumerable<Mono.Cecil.CustomAttribute>>) (p => (IEnumerable<Mono.Cecil.CustomAttribute>) p.CustomAttributes);
                }
                else
                  goto label_121;
label_175:
                IEnumerable<Mono.Cecil.CustomAttribute> second = properties.SelectMany<PropertyDefinition, Mono.Cecil.CustomAttribute>(selector);
                enumerator9 = customAttributes.Concat<Mono.Cecil.CustomAttribute>(second).Concat<Mono.Cecil.CustomAttribute>(current10.Methods.SelectMany<MethodDefinition, Mono.Cecil.CustomAttribute>((Func<MethodDefinition, IEnumerable<Mono.Cecil.CustomAttribute>>) (p => (IEnumerable<Mono.Cecil.CustomAttribute>) p.CustomAttributes))).GetEnumerator();
                num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 3;
                continue;
label_121:
                selector = func;
                goto label_175;
            }
          }
label_194:
          return;
label_145:
          try
          {
label_155:
            if (enumerator9.MoveNext())
              goto label_153;
            else
              goto label_156;
label_147:
            Mono.Cecil.CustomAttribute current11;
            int num24;
            while (true)
            {
              int num25;
              int index3;
              CustomAttributeArgument constructorArgument;
              TypeReference replaceTo;
              switch (num24)
              {
                case 1:
                  goto label_170;
                case 2:
                  goto label_155;
                case 3:
                  constructorArgument = current11.ConstructorArguments[index3];
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 8 : 1;
                  continue;
                case 4:
                case 9:
                  if (index3 >= EntityDynamicGenerator.DeltaAssemblyProcessor.zhnvbQvE4c6QZOPg0SVI((object) current11.ConstructorArguments))
                  {
                    num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
                    continue;
                  }
                  goto case 3;
                case 5:
                  if (!EntityDynamicGenerator.CheckType(this.typesToReplace, (object) typeReference, out replaceTo))
                  {
                    num25 = 11;
                    break;
                  }
                  goto case 10;
                case 6:
                  goto label_153;
                case 7:
                  index3 = 0;
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 9 : 9;
                  continue;
                case 8:
                  if (constructorArgument.Value is TypeReference typeReference)
                  {
                    num25 = 5;
                    break;
                  }
                  goto default;
                case 10:
                  Collection<CustomAttributeArgument> constructorArguments = current11.ConstructorArguments;
                  int index4 = index3;
                  constructorArgument = current11.ConstructorArguments[index3];
                  CustomAttributeArgument attributeArgument = new CustomAttributeArgument(constructorArgument.Type, (object) replaceTo);
                  constructorArguments[index4] = attributeArgument;
                  num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                  continue;
                default:
                  ++index3;
                  num25 = 4;
                  break;
              }
              num24 = num25;
            }
label_153:
            current11 = enumerator9.Current;
            num24 = 7;
            goto label_147;
label_156:
            num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
            goto label_147;
          }
          finally
          {
            int num26;
            if (enumerator9 == null)
              num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
            else
              goto label_164;
label_163:
            switch (num26)
            {
              case 2:
                break;
              default:
            }
label_164:
            enumerator9.Dispose();
            num26 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
            {
              num26 = 0;
              goto label_163;
            }
            else
              goto label_163;
          }
label_168:
          current10 = enumerator1.Current;
          num23 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
          {
            num23 = 0;
            goto label_144;
          }
          else
            goto label_144;
label_171:
          num23 = 4;
          goto label_144;
        }
        finally
        {
          int num27;
          if (enumerator1 == null)
            num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 2;
          else
            goto label_179;
label_178:
          switch (num27)
          {
            case 1:
              break;
            default:
          }
label_179:
          enumerator1.Dispose();
          num27 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
          {
            num27 = 0;
            goto label_178;
          }
          else
            goto label_178;
        }
      }

      private void ProcessDataClasses()
      {
        int num1 = 2;
        MethodReference[] array1;
        HashSet<TypeReference> hashSet;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_7;
            case 1:
              IEnumerable<MethodReference> source1 = ((IEnumerable<MethodReference>) array1).Where<MethodReference>((Func<MethodReference, bool>) (m =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (!this.IsModuleScope(m.DeclaringType))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return EntityDynamicGenerator.DeltaAssemblyProcessor.A9uSVEvE5yAoDIUC5j1i(EntityDynamicGenerator.DeltaAssemblyProcessor.p63fUlvEgLODVrTw4fYm(EntityDynamicGenerator.DeltaAssemblyProcessor.Xy356bvErabC7DxcFKbI((object) m)));
label_3:
                return false;
              }));
              // ISSUE: reference to a compiler-generated field
              Func<MethodReference, TypeReference> func1 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__18_4;
              Func<MethodReference, TypeReference> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__18_4 = selector1 = (Func<MethodReference, TypeReference>) (m => (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.EOmUBgZq9XbdjOO4qXLP((object) m));
              }
              else
                goto label_10;
label_9:
              // ISSUE: reference to a compiler-generated method
              source1.Select<MethodReference, TypeReference>(selector1).Concat<TypeReference>(hashSet.Where<TypeReference>((Func<TypeReference, bool>) (t =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (!this.IsModuleScope(t))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return EntityDynamicGenerator.DeltaAssemblyProcessor.FOAQ4FvEYnW935MHK3qU(EntityDynamicGenerator.DeltaAssemblyProcessor.liM4RfvEEUCDxVFNfy8q(EntityDynamicGenerator.DeltaAssemblyProcessor.IeCkGpvEjrAv0brMAecd((object) t)));
label_3:
                return false;
              }))).Select<TypeReference, IMetadataScope>(new Func<TypeReference, IMetadataScope>(this.GetScope)).Cast<AssemblyNameReference>().Select<AssemblyNameReference, string>((Func<AssemblyNameReference, string>) (a => (string) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.ibb3E9Zq6UxxiCCcIAWq((object) a))).Distinct<string>().ForEach<string>(new Action<string>(this.AddIgnoresAccessChecksToAttribute));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
label_10:
              selector1 = func1;
              goto label_9;
            case 2:
              IEnumerable<PropertyDefinition> source2 = this.dataClasses.SelectMany<TypeDefinition, PropertyDefinition>((Func<TypeDefinition, IEnumerable<PropertyDefinition>>) (d => (IEnumerable<PropertyDefinition>) d.Properties));
              // ISSUE: reference to a compiler-generated field
              Func<PropertyDefinition, IEnumerable<object>> func2 = EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__18_1;
              Func<PropertyDefinition, IEnumerable<object>> selector2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.\u003C\u003E9__18_1 = selector2 = (Func<PropertyDefinition, IEnumerable<object>>) (p =>
                {
                  MethodDefinition getMethod = p.GetMethod;
                  // ISSUE: reference to a compiler-generated method
                  IEnumerable<object> first = (getMethod != null ? getMethod.Body.Instructions.Select<Instruction, object>((Func<Instruction, object>) (i => EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.KDjPTvZqJDMOdoSyCGAy((object) i))) : (IEnumerable<object>) null) ?? Enumerable.Empty<object>();
                  MethodDefinition setMethod = p.SetMethod;
                  IEnumerable<object> second = (setMethod != null ? setMethod.Body.Instructions.Select<Instruction, object>((Func<Instruction, object>) (i => i.Operand)) : (IEnumerable<object>) null) ?? Enumerable.Empty<object>();
                  return first.Concat<object>(second);
                });
              }
              else
                goto label_11;
label_5:
              object[] array2 = source2.SelectMany<PropertyDefinition, object>(selector2).ToArray<object>();
              array1 = array2.OfType<MethodReference>().ToArray<MethodReference>();
              // ISSUE: reference to a compiler-generated method
              hashSet = array2.OfType<TypeReference>().Concat<TypeReference>(((IEnumerable<MethodReference>) array1).Select<MethodReference, TypeReference>((Func<MethodReference, TypeReference>) (m => (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.\u003C\u003Ec.EOmUBgZq9XbdjOO4qXLP((object) m)))).ToHashSet<TypeReference>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
              continue;
label_11:
              selector2 = func2;
              goto label_5;
            default:
              goto label_3;
          }
        }
label_7:
        return;
label_3:;
      }

      private static bool CheckMethodAccessMask(Mono.Cecil.MethodAttributes attributes)
      {
        int num = 1;
        Mono.Cecil.MethodAttributes methodAttributes;
        while (true)
        {
          switch (num)
          {
            case 1:
              methodAttributes = attributes & Mono.Cecil.MethodAttributes.MemberAccessMask;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (methodAttributes != Mono.Cecil.MethodAttributes.Private)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 1;
                continue;
              }
              goto label_6;
          }
        }
label_5:
        return methodAttributes == Mono.Cecil.MethodAttributes.Family;
label_6:
        return true;
      }

      private static bool CheckTypeAccessMask(Mono.Cecil.TypeAttributes attributes)
      {
        int num = 1;
        Mono.Cecil.TypeAttributes typeAttributes;
        while (true)
        {
          switch (num)
          {
            case 1:
              typeAttributes = attributes & Mono.Cecil.TypeAttributes.VisibilityMask;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (typeAttributes != Mono.Cecil.TypeAttributes.NestedPrivate)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 2;
                continue;
              }
              goto label_4;
            default:
              if (typeAttributes != Mono.Cecil.TypeAttributes.NotPublic)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 3 : 2;
                continue;
              }
              goto label_4;
          }
        }
label_3:
        return typeAttributes == Mono.Cecil.TypeAttributes.NestedFamily;
label_4:
        return true;
      }

      private IMetadataScope GetScope(TypeReference type)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!EntityDynamicGenerator.DeltaAssemblyProcessor.btZMXovE6YGMeyylmnDy((object) type))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (IMetadataScope) EntityDynamicGenerator.DeltaAssemblyProcessor.nSDsHdvEQbrUbcNuMVtd((object) type);
label_3:
        return this.GetScope((TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.wEI7NVvEuI7pod8jreDD((object) type));
      }

      private bool IsModuleScope(TypeReference type) => this.GetScope(type) == this.module;

      private void AddIgnoresAccessChecksToAttribute(string assemblyName)
      {
        int num = 3;
        Mono.Cecil.CustomAttribute customAttribute;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((ModuleDefinition) this.module).Assembly.CustomAttributes.Add(customAttribute);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            case 2:
              customAttribute.ConstructorArguments.Add(new CustomAttributeArgument((TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.h10rsRvE7HS9FfhOrAE1((object) ((ModuleDefinition) this.module).TypeSystem), (object) assemblyName));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
              continue;
            case 3:
              // ISSUE: type reference
              // ISSUE: type reference
              // ISSUE: explicit non-virtual call
              customAttribute = new Mono.Cecil.CustomAttribute((MethodReference) EntityDynamicGenerator.DeltaAssemblyProcessor.moiA5lvEAdmxqGUgm5jA(this.module, (object) __nonvirtual (EntityDynamicGenerator.DeltaAssemblyProcessor.e5aHAgvEHtRx2jal079E(__typeref (IgnoresAccessChecksToAttribute)).GetConstructor(new System.Type[1]
              {
                EntityDynamicGenerator.DeltaAssemblyProcessor.e5aHAgvEHtRx2jal079E(__typeref (string))
              }))));
              num = 2;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      private void AddInterfaceMethodImplementation(
        TypeDefinition typeDefinition,
        string propertyName,
        TypeReference parameterType,
        MethodDefinition method,
        ref TypeReference interfaceReference)
      {
        int num1 = 10;
        while (true)
        {
          int num2 = num1;
          TypeReference parameterType1;
          MethodDefinition toMethod;
          while (true)
          {
            ILProcessor ilProcessor;
            MethodReference fromMethod;
            switch (num2)
            {
              case 1:
                toMethod = new MethodDefinition((string) EntityDynamicGenerator.DeltaAssemblyProcessor.wInmYJvEv3L9TNLy3x4u((object) method), Mono.Cecil.MethodAttributes.Public | Mono.Cecil.MethodAttributes.Static, !method.IsGetter ? ((ModuleDefinition) this.module).TypeSystem.Void : parameterType1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 19 : 5;
                continue;
              case 2:
                fromMethod.Parameters.Add(new ParameterDefinition(parameterType1));
                num2 = 8;
                continue;
              case 3:
                if (!EntityDynamicGenerator.DeltaAssemblyProcessor.jqFuYyvEJrYhth0D4udS((object) method))
                {
                  num2 = 17;
                  continue;
                }
                break;
              case 4:
                ilProcessor.Emit(OpCodes.Ret);
                num2 = 27;
                continue;
              case 5:
                if (!EntityDynamicGenerator.DeltaAssemblyProcessor.msXkNhvE94Q9RWpZ0TIq((object) ((MemberReference) EntityDynamicGenerator.DeltaAssemblyProcessor.aW4AbAvEDOW3qvItRHmw((object) toMethod.Parameters[1])).FullName, EntityDynamicGenerator.DeltaAssemblyProcessor.ve3HnmvGg9SRuNo1X9NL(EntityDynamicGenerator.DeltaAssemblyProcessor.aW4AbAvEDOW3qvItRHmw((object) method.Parameters[0]))))
                {
                  num2 = 25;
                  continue;
                }
                goto case 20;
              case 6:
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.jqFuYyvEJrYhth0D4udS((object) method))
                {
                  num2 = 2;
                  continue;
                }
                goto case 8;
              case 7:
                goto label_11;
              case 8:
                this.AddMethodReplace(fromMethod, toMethod);
                num2 = 13;
                continue;
              case 9:
                goto label_4;
              case 10:
                if (interfaceReference == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 9 : 0;
                  continue;
                }
                goto label_11;
              case 11:
                EntityDynamicGenerator.DeltaAssemblyProcessor.UqQXFdvEmS552wp8HMqw((object) toMethod, Mono.Cecil.MethodImplAttributes.IL);
                num2 = 22;
                continue;
              case 12:
                EntityDynamicGenerator.DeltaAssemblyProcessor.BYRFXmvEMACT45Ghpqib((object) ilProcessor, OpCodes.Ldarg_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 28 : 15;
                continue;
              case 13:
                goto label_36;
              case 14:
                parameterType1 = (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.kQK1kPvEIqbY1Us6wjtc(this.module, (object) parameterType1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
                continue;
              case 15:
                interfaceReference = (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.kQK1kPvEIqbY1Us6wjtc(this.module, (object) interfaceReference);
                num2 = 14;
                continue;
              case 16:
              case 17:
              case 25:
                ilProcessor.Emit(OpCodes.Call, (MethodReference) method);
                num2 = 4;
                continue;
              case 18:
                goto label_17;
              case 19:
                toMethod.Parameters.Add(new ParameterDefinition((string) EntityDynamicGenerator.DeltaAssemblyProcessor.uvMl8QvGxXJLNc1YU10F(-812025778 ^ -811934896), Mono.Cecil.ParameterAttributes.In, interfaceReference));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 21 : 7;
                continue;
              case 20:
                EntityDynamicGenerator.DeltaAssemblyProcessor.MESGb0vEdJO3o4y1p1ws((object) ilProcessor, OpCodes.Castclass, EntityDynamicGenerator.DeltaAssemblyProcessor.aW4AbAvEDOW3qvItRHmw((object) method.Parameters[0]));
                num2 = 16;
                continue;
              case 21:
                EntityDynamicGenerator.DeltaAssemblyProcessor.P9qOl7vE0apan4feyj2s((object) toMethod, false);
                num2 = 11;
                continue;
              case 22:
                ilProcessor = (ILProcessor) EntityDynamicGenerator.DeltaAssemblyProcessor.lP9HpevEyPTldhGwJDff((object) toMethod.Body);
                num2 = 12;
                continue;
              case 23:
                fromMethod = new MethodReference((string) EntityDynamicGenerator.DeltaAssemblyProcessor.wInmYJvEv3L9TNLy3x4u((object) method), (TypeReference) EntityDynamicGenerator.DeltaAssemblyProcessor.uiODTXvEXjtqE8iVvQ63((object) toMethod), interfaceReference);
                num2 = 6;
                continue;
              case 24:
                EntityDynamicGenerator.DeltaAssemblyProcessor.BYRFXmvEMACT45Ghpqib((object) ilProcessor, OpCodes.Ldarg_1);
                num2 = 5;
                continue;
              case 26:
                if (EntityDynamicGenerator.DeltaAssemblyProcessor.fCBLyEvExGxeaIgqZsNp((object) interfaceReference) == null)
                {
                  num2 = 15;
                  continue;
                }
                goto case 14;
              case 27:
                goto label_25;
              case 28:
                ilProcessor.Emit(OpCodes.Castclass, parameterType);
                num2 = 3;
                continue;
            }
            toMethod.Parameters.Add(new ParameterDefinition(parameterType1));
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 24 : 24;
          }
label_11:
          if (EntityDynamicGenerator.configurationModelProperties[interfaceReference.FullName].TryGetValue(propertyName, out parameterType1))
          {
            num1 = 26;
            continue;
          }
          goto label_22;
label_25:
          typeDefinition.Methods.Add(toMethod);
          num1 = 23;
        }
label_4:
        return;
label_36:
        return;
label_17:
        return;
label_22:;
      }

      internal static void yJV7eEvG7LJ5q9M2EslM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool dAoYyKvGHd46hjPAX2v3() => EntityDynamicGenerator.DeltaAssemblyProcessor.J3I0fUvG6IXsDGOEv1d5 == null;

      internal static EntityDynamicGenerator.DeltaAssemblyProcessor Il8uAevGAc1BYm01Ceer() => (EntityDynamicGenerator.DeltaAssemblyProcessor) EntityDynamicGenerator.DeltaAssemblyProcessor.J3I0fUvG6IXsDGOEv1d5;

      internal static object uvMl8QvGxXJLNc1YU10F(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void S0PAadvG08Qi9OROsEwM(System.Type entityType, System.Type dataClassType) => EntityDynamicGenerator.SetCreator(entityType, dataClassType);

      internal static bool nI2mXnvGmait7AmwPp5n([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void UwdDNsvGyVPTLJ7XKuQ5([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static object eh79NsvGMsWrtjkBuyqL([In] object obj0) => (object) EntityDynamicGenerator.MethodName(obj0);

      internal static System.Type JqxPZcvGJ1K5l85qJuyh([In] object obj0) => EntityDynamicGenerator.Resolve((TypeReference) obj0);

      internal static bool NHZVdivG9EIWnGIEo7Wb([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

      internal static object Yux9bmvGdusih5pI7WbC([In] object obj0) => (object) ((AssemblyDefinition) obj0).Name;

      internal static object Kh22nkvGlDuDhQEdwFuH([In] object obj0) => (object) ((AssemblyNameReference) obj0).Name;

      internal static bool TjuKRVvGr77Vq9RWDrQ3([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static object ve3HnmvGg9SRuNo1X9NL([In] object obj0) => (object) ((MemberReference) obj0).FullName;

      internal static object o30ebSvG5buVdwaPnnni([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

      internal static System.Type blrqYKvGjPVUAOiDUwKf([In] object obj0) => System.Type.GetType((string) obj0);

      internal static bool hZ5pgtvGYIsGToUNxTBI([In] System.Type obj0, [In] System.Type obj1) => obj0 != obj1;

      internal static bool t0LFWQvGLkwCNOQT7Nkv([In] object obj0) => EntityDynamicGenerator.ContainsReplace(obj0);

      internal static void Qwa0HyvGU9pCKbqYjQSr(System.Type type) => ReflectionType.Register(type);

      internal static object SgYwTBvGsZXiv9mcMcLn([In] object obj0) => (object) EntityDynamicGenerator.CreateReference((TypeReference) obj0);

      internal static void WvokcgvGc651au2ZrVEN([In] object obj0, [In] object obj1) => EntityDynamicGenerator.AddReplace(obj0, obj1);

      internal static object HmmgRuvGzuZoSyXVH2J0([In] object obj0, [In] System.Type obj1) => (object) ((ModuleDefinition) obj0).Import(obj1);

      internal static bool e8DWhivEF9AG02bN9PuV([In] object obj0) => ((TypeDefinition) obj0).IsEnum;

      internal static void XCdEAevEB8b2mmjLX91w(System.Type type, [In] object obj1) => EnumProvider.AddType(type, (TypeDefinition) obj1);

      internal static bool TjsW5bvEWsXmqfRMRj1S([In] object obj0) => ((TypeDefinition) obj0).IsInterface;

      internal static bool OEvGWZvEo54avmnJjd48([In] object obj0) => ((TypeDefinition) obj0).IsClass;

      internal static object Y5kG0wvEbiHEwhpSdYxY([In] object obj0) => (object) ((ModuleDefinition) obj0).TypeSystem;

      internal static object gE6YgSvEhHS3Vuexw5Hc([In] object obj0) => (object) ((TypeSystem) obj0).Object;

      internal static void KBZboEvEGtxDPjt5srNF([In] object obj0, [In] object obj1) => ((TypeDefinition) obj0).BaseType = (TypeReference) obj1;

      internal static Mono.Cecil.TypeAttributes liM4RfvEEUCDxVFNfy8q([In] object obj0) => ((TypeDefinition) obj0).Attributes;

      internal static void GTCaPpvEfFhWLaE6pBsm([In] object obj0, [In] Mono.Cecil.TypeAttributes obj1) => ((TypeDefinition) obj0).Attributes = obj1;

      internal static object nSDsHdvEQbrUbcNuMVtd([In] object obj0) => (object) ((TypeReference) obj0).Scope;

      internal static void bvuQN2vECrVeDy0OfQR8([In] object obj0, [In] object obj1) => ((AssemblyNameReference) obj0).Version = (Version) obj1;

      internal static object wInmYJvEv3L9TNLy3x4u([In] object obj0) => (object) ((MemberReference) obj0).Name;

      internal static object BygEN7vE8efWKaQSk1lt([In] object obj0) => (object) ((PropertyDefinition) obj0).GetMethod;

      internal static object Vv3A5dvEZU8w4vZdEDAL([In] object obj0) => (object) ((PropertyDefinition) obj0).SetMethod;

      internal static object wEI7NVvEuI7pod8jreDD([In] object obj0) => (object) ((MemberReference) obj0).DeclaringType;

      internal static object kQK1kPvEIqbY1Us6wjtc([In] object obj0, [In] object obj1) => (object) ((ModuleDefinition) obj0).Import((TypeReference) obj1);

      internal static void h1944kvEVF6xL7w5IdmZ([In] object obj0) => ((Collection<FieldDefinition>) obj0).Clear();

      internal static void eTRpChvES4aQlwFnuCXQ([In] object obj0) => ((Collection<PropertyDefinition>) obj0).Clear();

      internal static void fiJ5oMvEiWsx9rNYFLiI([In] object obj0) => ((Collection<TypeReference>) obj0).Clear();

      internal static object QIxgXxvERds4rycVaNVm() => (object) EntityDynamicGenerator.TypeReferenceComparer.Instance;

      internal static int dk3BxavEqNqF5pqWao9W([In] object obj0) => ((Dictionary<TypeReference, TypeDefinition>) obj0).Count;

      internal static int CIeW1LvEKJqbRVaJsJ3O([In] object obj0) => ((Collection<PropertyDefinition>) obj0).Count;

      internal static object uiODTXvEXjtqE8iVvQ63([In] object obj0) => (object) ((MethodReference) obj0).ReturnType;

      internal static object KmMBmEvETLs96EVeDsVO([In] object obj0) => (object) ((MethodDefinition) obj0).Body;

      internal static object PT5qrFvEkeAydYxrNoNv([In] object obj0) => ((Instruction) obj0).Operand;

      internal static void cdBAdVvEnWbbUqffIMS1([In] object obj0, [In] object obj1) => ((MemberReference) obj0).DeclaringType = (TypeReference) obj1;

      internal static object QidgY9vEO7IEW9oKN9td([In] object obj0, [In] object obj1) => (object) ((ModuleDefinition) obj0).Import((MethodReference) obj1);

      internal static void pqyNxMvE2fjFRux3yLHj([In] object obj0) => ((Collection<MethodReference>) obj0).Clear();

      internal static int op17aRvEeJTqV24h5Mhd([In] object obj0) => ((ICollection<KeyValuePair<TypeReference, TypeReference>>) obj0).Count;

      internal static object n1C8QQvEPfDxcYobxkov([In] object obj0) => (object) ((TypeDefinition) obj0).BaseType;

      internal static int m8VANjvE1F9DxbXsAeqQ([In] object obj0) => ((Collection<TypeReference>) obj0).Count;

      internal static object qjh1ZbvENiKg7TDriHC9([In] object obj0) => (object) ((PropertyReference) obj0).PropertyType;

      internal static void sLLA6YvE36yJ9IJU38Mo([In] object obj0, [In] object obj1) => ((PropertyReference) obj0).PropertyType = (TypeReference) obj1;

      internal static object KTqbO4vEpugjJbiVEwWx([In] object obj0) => (object) ((FieldReference) obj0).FieldType;

      internal static void qkerTuvEaifyqiVXDWjc([In] object obj0, [In] object obj1) => ((MethodReference) obj0).ReturnType = (TypeReference) obj1;

      internal static object aW4AbAvEDOW3qvItRHmw([In] object obj0) => (object) ((ParameterReference) obj0).ParameterType;

      internal static void NMaT1QvEtIbaq3NV2y7o([In] object obj0, [In] object obj1) => ((ParameterReference) obj0).ParameterType = (TypeReference) obj1;

      internal static bool FNDHCWvEwxkjiP3j2p54([In] object obj0) => ((MethodDefinition) obj0).HasBody;

      internal static int zhnvbQvE4c6QZOPg0SVI([In] object obj0) => ((Collection<CustomAttributeArgument>) obj0).Count;

      internal static bool btZMXovE6YGMeyylmnDy([In] object obj0) => ((TypeReference) obj0).IsNested;

      internal static System.Type e5aHAgvEHtRx2jal079E([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

      internal static object moiA5lvEAdmxqGUgm5jA([In] object obj0, [In] object obj1) => (object) ((ModuleDefinition) obj0).Import((MethodBase) obj1);

      internal static object h10rsRvE7HS9FfhOrAE1([In] object obj0) => (object) ((TypeSystem) obj0).String;

      internal static object fCBLyEvExGxeaIgqZsNp([In] object obj0) => (object) ((MemberReference) obj0).Module;

      internal static void P9qOl7vE0apan4feyj2s([In] object obj0, [In] bool obj1) => ((MethodReference) obj0).HasThis = obj1;

      internal static void UqQXFdvEmS552wp8HMqw([In] object obj0, [In] Mono.Cecil.MethodImplAttributes obj1) => ((MethodDefinition) obj0).ImplAttributes = obj1;

      internal static object lP9HpevEyPTldhGwJDff([In] object obj0) => (object) ((Mono.Cecil.Cil.MethodBody) obj0).GetILProcessor();

      internal static void BYRFXmvEMACT45Ghpqib([In] object obj0, [In] OpCode obj1) => ((ILProcessor) obj0).Emit(obj1);

      internal static bool jqFuYyvEJrYhth0D4udS([In] object obj0) => ((MethodDefinition) obj0).IsSetter;

      internal static bool msXkNhvE94Q9RWpZ0TIq([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

      internal static void MESGb0vEdJO3o4y1p1ws([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILProcessor) obj0).Emit(obj1, (TypeReference) obj2);

      internal static object JtJ2RSvElF2LQ8W7yaej([In] object obj0) => (object) ((TypeDefinition) obj0).DeclaringType;

      internal static object Xy356bvErabC7DxcFKbI([In] object obj0) => (object) ((MethodReference) obj0).Resolve();

      internal static Mono.Cecil.MethodAttributes p63fUlvEgLODVrTw4fYm([In] object obj0) => ((MethodDefinition) obj0).Attributes;

      internal static bool A9uSVEvE5yAoDIUC5j1i(Mono.Cecil.MethodAttributes attributes) => EntityDynamicGenerator.DeltaAssemblyProcessor.CheckMethodAccessMask(attributes);

      internal static object IeCkGpvEjrAv0brMAecd([In] object obj0) => (object) ((TypeReference) obj0).Resolve();

      internal static bool FOAQ4FvEYnW935MHK3qU(Mono.Cecil.TypeAttributes attributes) => EntityDynamicGenerator.DeltaAssemblyProcessor.CheckTypeAccessMask(attributes);
    }

    private class TypeReferenceComparer : IComparer<TypeReference>, IEqualityComparer<TypeReference>
    {
      internal static object YQX2DAvELRB7psJVCMJc;

      public static EntityDynamicGenerator.TypeReferenceComparer Instance { get; }

      private TypeReferenceComparer()
      {
        EntityDynamicGenerator.TypeReferenceComparer.HhfLvlvEcZUvRp56IhRf();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
          num = 0;
        switch (num)
        {
        }
      }

      int IComparer<TypeReference>.Compare(TypeReference x, TypeReference y)
      {
        int num1 = 3;
        int num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_5;
            case 2:
              if (num2 == 0)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 3:
              num2 = ((StringComparer) EntityDynamicGenerator.TypeReferenceComparer.PiU8t9vEzvoHhEYxT51s()).Compare(x.FullName, y.FullName);
              num1 = 2;
              continue;
            default:
              num2 = EntityDynamicGenerator.TypeReferenceComparer.j4SiJZvfBsrBULRxl9Fd(EntityDynamicGenerator.TypeReferenceComparer.PiU8t9vEzvoHhEYxT51s(), (object) this.AssemblyName((IMetadataScope) EntityDynamicGenerator.TypeReferenceComparer.Hb5hwbvfFef6eCf0UG8p((object) x)), (object) this.AssemblyName(y.Scope));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
          }
        }
label_5:
        return num2;
      }

      bool IEqualityComparer<TypeReference>.Equals(TypeReference x, TypeReference y) => ((IComparer<TypeReference>) this).Compare(x, y) == 0;

      int IEqualityComparer<TypeReference>.GetHashCode(TypeReference obj) => (1925753114 * -1521134295 + EntityDynamicGenerator.TypeReferenceComparer.vUWh4PvfWuVXiDmeh7WO((object) obj).GetHashCode()) * -1521134295 + this.AssemblyName(obj.Scope).GetHashCode();

      private string AssemblyName(IMetadataScope scope)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(scope is AssemblyNameReference assemblyNameReference1))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_5:
        AssemblyNameReference assemblyNameReference2 = (AssemblyNameReference) ((AssemblyDefinition) EntityDynamicGenerator.TypeReferenceComparer.G5ICcmvfopILftcxRkw8((object) (ModuleDefinition) scope)).Name;
label_6:
        return (string) EntityDynamicGenerator.TypeReferenceComparer.GvDmFSvfbUwI6XYVGdUT((object) assemblyNameReference2);
label_2:
        assemblyNameReference2 = assemblyNameReference1;
        goto label_6;
      }

      static TypeReferenceComparer()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              EntityDynamicGenerator.TypeReferenceComparer.Instance = new EntityDynamicGenerator.TypeReferenceComparer();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static void HhfLvlvEcZUvRp56IhRf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool MvX3LMvEUZFF2D3MW3ju() => EntityDynamicGenerator.TypeReferenceComparer.YQX2DAvELRB7psJVCMJc == null;

      internal static EntityDynamicGenerator.TypeReferenceComparer elctHJvEs8bw6IIhyDPx() => (EntityDynamicGenerator.TypeReferenceComparer) EntityDynamicGenerator.TypeReferenceComparer.YQX2DAvELRB7psJVCMJc;

      internal static object PiU8t9vEzvoHhEYxT51s() => (object) StringComparer.Ordinal;

      internal static object Hb5hwbvfFef6eCf0UG8p([In] object obj0) => (object) ((TypeReference) obj0).Scope;

      internal static int j4SiJZvfBsrBULRxl9Fd([In] object obj0, [In] object obj1, [In] object obj2) => ((StringComparer) obj0).Compare((string) obj1, (string) obj2);

      internal static object vUWh4PvfWuVXiDmeh7WO([In] object obj0) => (object) ((MemberReference) obj0).FullName;

      internal static object G5ICcmvfopILftcxRkw8([In] object obj0) => (object) ((ModuleDefinition) obj0).Assembly;

      internal static object GvDmFSvfbUwI6XYVGdUT([In] object obj0) => (object) ((AssemblyNameReference) obj0).FullName;
    }

    private class CloneScope : IDisposable
    {
      [ThreadStatic]
      private static EntityDynamicGenerator.CloneScope current;
      private readonly object module;
      private readonly object prev;
      private readonly IDictionary<(string, Version), AssemblyNameReference> assemblyNameReferences;
      private readonly IDictionary<string, TypeReference> typeReferences;
      private static object vQ7p0yvfhEwo4iidpAok;

      public CloneScope(ModuleDefinition module = null)
      {
        EntityDynamicGenerator.CloneScope.hWkTgCvff4ffLkwAcH5L();
        this.assemblyNameReferences = (IDictionary<(string, Version), AssemblyNameReference>) new Dictionary<(string, Version), AssemblyNameReference>();
        this.typeReferences = (IDictionary<string, TypeReference>) new Dictionary<string, TypeReference>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.prev = (object) EntityDynamicGenerator.CloneScope.current;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 3 : 0;
              continue;
            case 2:
              this.module = this.prev != null ? ((EntityDynamicGenerator.CloneScope) this.prev).module : (object) module;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            case 3:
              EntityDynamicGenerator.CloneScope.current = this;
              num = 2;
              continue;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:;
      }

      public void Dispose()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityDynamicGenerator.CloneScope.current = (EntityDynamicGenerator.CloneScope) this.prev;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool TryGetAssemblyNameReference(
        string name,
        Version version,
        out AssemblyNameReference assemblyNameReference)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!EntityDynamicGenerator.CloneScope.current.assemblyNameReferences.TryGetValue((name, version), out assemblyNameReference))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            case 3:
              goto label_6;
            default:
              EntityDynamicGenerator.CloneScope.current.assemblyNameReferences[(name, version)] = assemblyNameReference = new AssemblyNameReference(name, version);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 3 : 2;
              continue;
          }
        }
label_2:
        return true;
label_6:
        return false;
      }

      public bool TryGetTypeReference(
        string fullName,
        string @namespace,
        string name,
        IMetadataScope scope,
        bool isValueType,
        out TypeReference typeReference)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!EntityDynamicGenerator.CloneScope.current.typeReferences.TryGetValue(fullName, out typeReference))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            case 3:
              goto label_4;
            default:
              EntityDynamicGenerator.CloneScope.current.typeReferences[fullName] = typeReference = new TypeReference(@namespace, name, (ModuleDefinition) null, scope, isValueType);
              num = 3;
              continue;
          }
        }
label_2:
        return true;
label_4:
        return false;
      }

      public TypeReference Import(TypeReference typeReference)
      {
        int num = 1;
        object obj;
        while (true)
        {
          switch (num)
          {
            case 1:
              object module = this.module;
              if (module == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                continue;
              }
              obj = EntityDynamicGenerator.CloneScope.yM7tlLvfQCTGhXAkGtKl(module, (object) typeReference);
              break;
            case 2:
              goto label_9;
            default:
              obj = (object) null;
              break;
          }
          if (obj == null)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 2;
          else
            break;
        }
        return (TypeReference) obj;
label_9:
        return typeReference;
      }

      internal static void hWkTgCvff4ffLkwAcH5L() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool wSk2XMvfGqBcc47jXuAq() => EntityDynamicGenerator.CloneScope.vQ7p0yvfhEwo4iidpAok == null;

      internal static EntityDynamicGenerator.CloneScope ryhJkjvfEhvmdqTNyolG() => (EntityDynamicGenerator.CloneScope) EntityDynamicGenerator.CloneScope.vQ7p0yvfhEwo4iidpAok;

      internal static object yM7tlLvfQCTGhXAkGtKl([In] object obj0, [In] object obj1) => (object) ((ModuleDefinition) obj0).Import((TypeReference) obj1);
    }

    private class IdentifierRewriter : CSharpSyntaxRewriter
    {
      private readonly object generator;
      private object semanticModel;
      private ISet<INamedTypeSymbol> entityTypes;
      private static readonly object entityCode;
      private static readonly object entityDynamicTypeSyntax;
      private static object s8sieKvfCV4DTiFihhm6;

      public IdentifierRewriter(EntityDynamicGenerator generator)
      {
        EntityDynamicGenerator.IdentifierRewriter.iF1JJUvfZsFVFKIRySrN();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.generator = (object) generator;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      static IdentifierRewriter()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityDynamicGenerator.IdentifierRewriter.entityDynamicTypeSyntax = (object) typeof (EntityDynamic<long>).CreateTypeSyntax();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 3;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EntityDynamicGenerator.IdentifierRewriter.entityCode = EntityDynamicGenerator.IdentifierRewriter.eAjCFFvfSoC9PIvggw8p((object) EleWise.ELMA.SDK.TypeOf.EntityDynamic1.Raw.Namespace.NamespaceDeclaration(((string) EntityDynamicGenerator.IdentifierRewriter.x3T6cjvfuWyaK6COQWrK(1051802738 - -1831968059 ^ -1410898855)).ClassDeclaration((IEnumerable<string>) new string[1]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825745172)
              }, Accessibility.Public, DeclarationModifiers.Abstract, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121749518).CreateTypeSyntax((ISyntaxNode) EntityDynamicGenerator.IdentifierRewriter.rEi3btvfIGCNA9q4ZZjB((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858723917)))), ((string) EntityDynamicGenerator.IdentifierRewriter.x3T6cjvfuWyaK6COQWrK(-345420348 ^ -345173048)).ClassDeclaration(((IEnumerable<System.Type>) EntityDynamicGenerator.IdentifierRewriter.zW7N13vfVo7Zuv2XwgJx((object) EleWise.ELMA.SDK.TypeOf.Entity1).GetGenericArguments()).Select<System.Type, string>((Func<System.Type, string>) (t => (string) EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.JfbBWmZXO9aCq3tD5a3F((object) t))), Accessibility.Public, DeclarationModifiers.Abstract, members: ((IEnumerable<PropertyInfo>) EleWise.ELMA.SDK.TypeOf.Entity1.Raw.GetProperties()).Select<PropertyInfo, ISyntaxNode>((Func<PropertyInfo, ISyntaxNode>) (p => p.Name.PropertyDeclaration((ISyntaxNode) EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.KK8dhBZXeBqdvaR1rcYF(EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.XtClRvZX2QjFb0fcOl47((object) p)), Accessibility.Public))).Concat<ISyntaxNode>(((IEnumerable<MethodInfo>) EntityDynamicGenerator.IdentifierRewriter.zW7N13vfVo7Zuv2XwgJx((object) EleWise.ELMA.SDK.TypeOf.Entity1).GetMethods()).Where<MethodInfo>((Func<MethodInfo, bool>) (m => !m.Attributes.HasFlag((Enum) System.Reflection.MethodAttributes.SpecialName))).Select<MethodInfo, ISyntaxNode>((Func<MethodInfo, ISyntaxNode>) (m =>
              {
                // ISSUE: reference to a compiler-generated method
                object name = EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.JfbBWmZXO9aCq3tD5a3F((object) m);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                IEnumerable<ISyntaxNode> parameters = ((IEnumerable<System.Reflection.ParameterInfo>) m.GetParameters()).Select<System.Reflection.ParameterInfo, ISyntaxNode>((Func<System.Reflection.ParameterInfo, ISyntaxNode>) (p => ((string) EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.PLZwW8ZXN0HEgUdLhqNU((object) p)).ParameterDeclaration((ISyntaxNode) EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.KK8dhBZXeBqdvaR1rcYF(EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.iQ1BL4ZX3jduf1pa80l6((object) p)))));
                IEnumerable<string> typeParameters;
                if (!m.IsGenericMethod)
                {
                  typeParameters = (IEnumerable<string>) null;
                }
                else
                {
                  // ISSUE: reference to a compiler-generated method
                  object source = EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.daAqI9ZXP8Cu85C76lQC((object) m);
                  // ISSUE: reference to a compiler-generated field
                  Func<System.Type, string> func = EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.\u003C\u003E9__6_5;
                  Func<System.Type, string> selector;
                  if (func == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.\u003C\u003E9__6_5 = selector = (Func<System.Type, string>) (t => (string) EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.JfbBWmZXO9aCq3tD5a3F((object) t));
                  }
                  else
                    goto label_1;
label_5:
                  typeParameters = ((IEnumerable<System.Type>) source).Select<System.Type, string>(selector);
                  goto label_6;
label_1:
                  selector = func;
                  goto label_5;
                }
label_6:
                // ISSUE: reference to a compiler-generated method
                ISyntaxNode typeSyntax = EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.SNZAsIZX1chXVPufPRjs((object) m).CreateTypeSyntax();
                return ((string) name).MethodDeclaration(parameters, typeParameters, typeSyntax, Accessibility.Public, DeclarationModifiers.Abstract);
              }))))));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      private SymbolInfo GetSymbolInfo(ExpressionSyntax expression)
      {
        int num1 = 20;
        IEnumerator<ClassDeclarationSyntax> enumerator;
        while (true)
        {
          int num2 = num1;
          EntityMetadata metadata;
          while (true)
          {
            IEnumerable<SyntaxTree> syntaxTrees;
            CSharpCompilation csharpCompilation;
            ISyntaxNode syntaxNode;
            EntityMetadata entityMetadata1;
            EntityMetadata entityMetadata2;
            EntityMetadata md;
            switch (num2)
            {
              case 1:
                if (((string) EntityDynamicGenerator.IdentifierRewriter.RML6TSvfO2uv9QK8uAjn((object) metadata)).IsNullOrWhiteSpace())
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
                  continue;
                }
                goto case 28;
              case 2:
              case 27:
                syntaxTrees = syntaxTrees.Append<SyntaxTree>(SyntaxFactory.ParseSyntaxTree((string) EntityDynamicGenerator.IdentifierRewriter.eAjCFFvfSoC9PIvggw8p((object) syntaxNode), (ParseOptions) null, "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()));
                num2 = 18;
                continue;
              case 3:
              case 14:
                md = entityMetadata1;
                num2 = 5;
                continue;
              case 4:
                object name = EntityDynamicGenerator.IdentifierRewriter.VAjDl9vfk4XYL4XVmIyH((object) md);
                object obj1 = entityMetadata1 != null ? EntityDynamicGenerator.IdentifierRewriter.rEi3btvfIGCNA9q4ZZjB(EntityDynamicGenerator.IdentifierRewriter.WLOQotvfnIA7LyZoFwh3((object) entityMetadata1)) : (object) null;
                object baseType = obj1 == null ? EntityDynamicGenerator.IdentifierRewriter.entityDynamicTypeSyntax : obj1;
                List<PropertyMetadata> properties = md.Properties;
                IEnumerable<TablePartMetadata> source = md.TableParts.EmptyIfNull<TablePartMetadata>();
                Func<TablePartMetadata, EntityPropertyTablePartMetadata> func;
                Func<TablePartMetadata, EntityPropertyTablePartMetadata> func1 = func;
                Func<TablePartMetadata, EntityPropertyTablePartMetadata> selector = func1 == null ? (func = (Func<TablePartMetadata, EntityPropertyTablePartMetadata>) (tp => new EntityPropertyTablePartMetadata(md, tp))) : func1;
                IEnumerable<EntityPropertyTablePartMetadata> second = source.Select<TablePartMetadata, EntityPropertyTablePartMetadata>(selector);
                IEnumerable<ISyntaxNode> members = properties.Concat<PropertyMetadata>((IEnumerable<PropertyMetadata>) second).Select<PropertyMetadata, ISyntaxNode>((Func<PropertyMetadata, ISyntaxNode>) (p =>
                {
                  int num3 = 1;
                  ISyntaxNode type;
                  ITypeGenerationInfo typeGenerationInfo;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        typeGenerationInfo = (ITypeGenerationInfo) EntityDynamicGenerator.IdentifierRewriter.OrfX8Dvf6Mfto2pxjHwO(this.generator, (object) p);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_2;
                      default:
                        type = (ISyntaxNode) EntityDynamicGenerator.IdentifierRewriter.DQmyG7vfH4Anjf6VKlGu(this.generator, (object) p, (object) typeGenerationInfo);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 2;
                        continue;
                    }
                  }
label_2:
                  return ((string) EntityDynamicGenerator.IdentifierRewriter.ltg27PvfARnVHtwhQCVM((object) p)).PropertyDeclaration(type, Accessibility.Public);
                }));
                syntaxNode = ((string) name).ClassDeclaration(Accessibility.Public, DeclarationModifiers.Partial, (ISyntaxNode) baseType, members: members);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                continue;
              case 6:
                this.semanticModel = EntityDynamicGenerator.IdentifierRewriter.iSgfgkvf2RwHjqrRJQaY((object) csharpCompilation, EntityDynamicGenerator.IdentifierRewriter.FsusBIvfi9H6opNSwyWJ((object) expression), false);
                num2 = 17;
                continue;
              case 7:
                syntaxTrees = syntaxTrees.Append<SyntaxTree>(SyntaxFactory.ParseSyntaxTree((string) EntityDynamicGenerator.IdentifierRewriter.xLnp90vfRdStOVfWQrXs((object) metadata), (ParseOptions) null, "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()));
                num2 = 9;
                continue;
              case 8:
                goto label_44;
              case 9:
                md = EntityDynamicGenerator.IdentifierRewriter.IM7FfFvfX7FMh4D4AoZy(EntityDynamicGenerator.IdentifierRewriter.xlQt1YvfK83boKcAJAeA((object) metadata), Guid.Empty) ? (EntityMetadata) MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid) : (EntityMetadata) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                continue;
              case 10:
                csharpCompilation = CSharpCompilation.Create(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87335525), syntaxTrees);
                num2 = 6;
                continue;
              case 11:
                syntaxTrees = syntaxTrees.Append<SyntaxTree>(SyntaxFactory.ParseSyntaxTree((string) EntityDynamicGenerator.IdentifierRewriter.xLnp90vfRdStOVfWQrXs((object) md), (ParseOptions) null, "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 11 : 14;
                continue;
              case 12:
              case 19:
                goto label_10;
              case 13:
                if (EntityDynamicGenerator.IdentifierRewriter.IM7FfFvfX7FMh4D4AoZy(EntityDynamicGenerator.IdentifierRewriter.xlQt1YvfK83boKcAJAeA((object) md), Guid.Empty))
                {
                  num2 = 25;
                  continue;
                }
                goto case 21;
              case 15:
                syntaxTrees = Enumerable.Repeat<SyntaxTree>((SyntaxTree) EntityDynamicGenerator.IdentifierRewriter.FsusBIvfi9H6opNSwyWJ((object) expression), 1);
                num2 = 26;
                continue;
              case 16:
                syntaxTrees = syntaxTrees.Append<SyntaxTree>(SyntaxFactory.ParseSyntaxTree((string) EntityDynamicGenerator.IdentifierRewriter.entityCode, (ParseOptions) null, "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 10 : 10;
                continue;
              case 17:
                this.entityTypes = (ISet<INamedTypeSymbol>) new HashSet<INamedTypeSymbol>();
                num2 = 24;
                continue;
              case 18:
                if (EntityDynamicGenerator.IdentifierRewriter.XlGAJ4vfqho0Q4bhwJeP((object) md.CustomCode))
                {
                  num2 = 3;
                  continue;
                }
                goto case 11;
              case 20:
                goto label_37;
              case 21:
                entityMetadata2 = (EntityMetadata) null;
                break;
              case 22:
                goto label_6;
              case 23:
                goto label_20;
              case 24:
                object obj2 = EntityDynamicGenerator.IdentifierRewriter.r2J81RvfeVDaTdc0PFLP(EntityDynamicGenerator.IdentifierRewriter.FsusBIvfi9H6opNSwyWJ((object) expression), new CancellationToken());
                // ISSUE: reference to a compiler-generated field
                Func<SyntaxNode, bool> func2 = EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.\u003C\u003E9__7_2;
                Func<SyntaxNode, bool> descendIntoChildren;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  EntityDynamicGenerator.IdentifierRewriter.\u003C\u003Ec.\u003C\u003E9__7_2 = descendIntoChildren = (Func<SyntaxNode, bool>) (n => !(n is ClassDeclarationSyntax));
                }
                else
                  goto label_53;
label_52:
                enumerator = ((SyntaxNode) obj2).DescendantNodes(descendIntoChildren).OfType<ClassDeclarationSyntax>().GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 23;
                continue;
label_53:
                descendIntoChildren = func2;
                goto label_52;
              case 25:
                entityMetadata2 = (EntityMetadata) ((IMetadataService) EntityDynamicGenerator.IdentifierRewriter.BJvoMfvfT4AThqnXkvSk()).GetMetadata(EntityDynamicGenerator.IdentifierRewriter.xlQt1YvfK83boKcAJAeA((object) md));
                break;
              case 26:
                if (!EntityDynamicGenerator.IdentifierRewriter.XlGAJ4vfqho0Q4bhwJeP(EntityDynamicGenerator.IdentifierRewriter.xLnp90vfRdStOVfWQrXs((object) metadata)))
                {
                  num2 = 7;
                  continue;
                }
                goto case 9;
              case 28:
                syntaxNode = ((string) EntityDynamicGenerator.IdentifierRewriter.RML6TSvfO2uv9QK8uAjn((object) metadata)).NamespaceDeclaration(syntaxNode);
                num2 = 27;
                continue;
              default:
                if (md != null)
                  goto case 13;
                else
                  goto label_40;
            }
            entityMetadata1 = entityMetadata2;
            num2 = 4;
          }
label_6:
          metadata = ((EntityGenerator) this.generator).metadata;
          num1 = 15;
          continue;
label_37:
          if (this.semanticModel != null)
          {
            num1 = 19;
            continue;
          }
          goto label_44;
label_40:
          num1 = 16;
          continue;
label_44:
          num1 = 22;
        }
label_10:
        return EntityDynamicGenerator.IdentifierRewriter.p2LNAavf3qpCSkVq21hX(this.semanticModel, (object) expression, new CancellationToken());
label_20:
        try
        {
label_29:
          if (enumerator.MoveNext())
            goto label_26;
          else
            goto label_30;
label_21:
          INamedTypeSymbol namedTypeSymbol;
          ClassDeclarationSyntax current;
          int num4;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_10;
              case 2:
                this.entityTypes.Add(namedTypeSymbol);
                num4 = 5;
                continue;
              case 3:
              case 6:
                if (namedTypeSymbol == null)
                {
                  num4 = 4;
                  continue;
                }
                goto case 2;
              case 4:
                goto label_29;
              case 5:
                namedTypeSymbol = (INamedTypeSymbol) EntityDynamicGenerator.IdentifierRewriter.afblLVvf1h7jeOceADLS((object) namedTypeSymbol);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 3;
                continue;
              case 7:
                namedTypeSymbol = (INamedTypeSymbol) EntityDynamicGenerator.IdentifierRewriter.Bwmga2vfPImxWDOyTO3b(this.semanticModel, (object) current, new CancellationToken());
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 6;
                continue;
              default:
                goto label_26;
            }
          }
label_26:
          current = enumerator.Current;
          num4 = 7;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
          {
            num4 = 0;
            goto label_21;
          }
          else
            goto label_21;
label_30:
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
          goto label_21;
        }
        finally
        {
          int num5;
          if (enumerator == null)
            num5 = 2;
          else
            goto label_34;
label_33:
          switch (num5)
          {
            case 1:
              break;
            default:
          }
label_34:
          EntityDynamicGenerator.IdentifierRewriter.YO5wX7vfNSnxhLtDyW0n((object) enumerator);
          num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          {
            num5 = 0;
            goto label_33;
          }
          else
            goto label_33;
        }
      }

      public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node) => (SyntaxNode) EntityDynamicGenerator.IdentifierRewriter.RWifmjvfDCZv3cWgDKkL((object) node, (object) (ExpressionSyntax) this.Visit((SyntaxNode) node.Expression), EntityDynamicGenerator.IdentifierRewriter.UnP0kHvfp6bAQ3da6sNF((object) node), EntityDynamicGenerator.IdentifierRewriter.eZgHV4vfaCXmnNs8iIv2((object) node));

      public override SyntaxNode VisitVariableDeclaration(VariableDeclarationSyntax node) => (SyntaxNode) node.Update((TypeSyntax) EntityDynamicGenerator.IdentifierRewriter.KvGt5vvft18Lcg5Nnq42((object) node), this.VisitList<VariableDeclaratorSyntax>(node.Variables));

      public override SyntaxNode VisitThisExpression(ThisExpressionSyntax node) => (SyntaxNode) SyntaxFactory.IdentifierName((string) EntityDynamicGenerator.IdentifierRewriter.x3T6cjvfuWyaK6COQWrK(1505778440 - 1981636111 ^ -475943887));

      public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
      {
        int num = 3;
        while (true)
        {
          SymbolInfo symbolInfo;
          ImmutableArray<ISymbol> candidateSymbols;
          ISymbol symbol1;
          ISymbol symbol2;
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              symbol2 = symbolInfo.Symbol;
              if (symbol2 == null)
              {
                num = 5;
                continue;
              }
              break;
            case 3:
              symbolInfo = this.GetSymbolInfo((ExpressionSyntax) node);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 2;
              continue;
            case 4:
              symbol2 = candidateSymbols[0];
              break;
            case 5:
              candidateSymbols = symbolInfo.CandidateSymbols;
              num = 8;
              continue;
            case 6:
              symbol2 = (ISymbol) null;
              break;
            case 7:
              candidateSymbols = symbolInfo.CandidateSymbols;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 4;
              continue;
            case 8:
              if (candidateSymbols.IsEmpty)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 6 : 5;
                continue;
              }
              goto case 7;
            case 9:
              goto label_2;
            default:
              if (!this.entityTypes.Contains(symbol1 != null ? (INamedTypeSymbol) EntityDynamicGenerator.IdentifierRewriter.K0dJA4vfwFCWXgS6WSL8((object) symbol1) : (INamedTypeSymbol) (object) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
          }
          symbol1 = symbol2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
        }
label_2:
        return (SyntaxNode) EntityDynamicGenerator.IdentifierRewriter.jjNBSPvf40aGWAfa4Gf2(SyntaxKind.SimpleMemberAccessExpression, (object) (ExpressionSyntax) this.VisitThisExpression((ThisExpressionSyntax) null), (object) node);
label_3:
        return (SyntaxNode) node;
      }

      internal static void iF1JJUvfZsFVFKIRySrN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool WTeLwLvfv9H2lff6gt9o() => EntityDynamicGenerator.IdentifierRewriter.s8sieKvfCV4DTiFihhm6 == null;

      internal static EntityDynamicGenerator.IdentifierRewriter GfCb5Ovf8lfopXFAkhYR() => (EntityDynamicGenerator.IdentifierRewriter) EntityDynamicGenerator.IdentifierRewriter.s8sieKvfCV4DTiFihhm6;

      internal static object x3T6cjvfuWyaK6COQWrK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object rEi3btvfIGCNA9q4ZZjB([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

      internal static System.Type zW7N13vfVo7Zuv2XwgJx([In] object obj0) => ((RipeType) obj0).Raw;

      internal static object eAjCFFvfSoC9PIvggw8p([In] object obj0) => (object) ((ISyntaxNode) obj0).GenerateCSCodeString();

      internal static object FsusBIvfi9H6opNSwyWJ([In] object obj0) => (object) ((SyntaxNode) obj0).SyntaxTree;

      internal static object xLnp90vfRdStOVfWQrXs([In] object obj0) => (object) ((ClassMetadata) obj0).CustomCode;

      internal static bool XlGAJ4vfqho0Q4bhwJeP([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

      internal static Guid xlQt1YvfK83boKcAJAeA([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

      internal static bool IM7FfFvfX7FMh4D4AoZy([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static object BJvoMfvfT4AThqnXkvSk() => (object) MetadataServiceContext.Service;

      internal static object VAjDl9vfk4XYL4XVmIyH([In] object obj0) => (object) ((ClassMetadata) obj0).TypeName;

      internal static object WLOQotvfnIA7LyZoFwh3([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

      internal static object RML6TSvfO2uv9QK8uAjn([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

      internal static object iSgfgkvf2RwHjqrRJQaY([In] object obj0, [In] object obj1, [In] bool obj2) => (object) ((CSharpCompilation) obj0).GetSemanticModel((SyntaxTree) obj1, obj2);

      internal static object r2J81RvfeVDaTdc0PFLP([In] object obj0, [In] CancellationToken obj1) => (object) ((SyntaxTree) obj0).GetCompilationUnitRoot(obj1);

      internal static object Bwmga2vfPImxWDOyTO3b([In] object obj0, [In] object obj1, [In] CancellationToken obj2) => (object) Microsoft.CodeAnalysis.CSharp.CSharpExtensions.GetDeclaredSymbol((SemanticModel) obj0, (BaseTypeDeclarationSyntax) obj1, obj2);

      internal static object afblLVvf1h7jeOceADLS([In] object obj0) => (object) ((ITypeSymbol) obj0).BaseType;

      internal static void YO5wX7vfNSnxhLtDyW0n([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static SymbolInfo p2LNAavf3qpCSkVq21hX(
        [In] object obj0,
        [In] object obj1,
        [In] CancellationToken obj2)
      {
        return Microsoft.CodeAnalysis.CSharp.CSharpExtensions.GetSymbolInfo((SemanticModel) obj0, (ExpressionSyntax) obj1, obj2);
      }

      internal static SyntaxToken UnP0kHvfp6bAQ3da6sNF([In] object obj0) => ((MemberAccessExpressionSyntax) obj0).OperatorToken;

      internal static object eZgHV4vfaCXmnNs8iIv2([In] object obj0) => (object) ((MemberAccessExpressionSyntax) obj0).Name;

      internal static object RWifmjvfDCZv3cWgDKkL(
        [In] object obj0,
        [In] object obj1,
        [In] SyntaxToken obj2,
        [In] object obj3)
      {
        return (object) ((MemberAccessExpressionSyntax) obj0).Update((ExpressionSyntax) obj1, obj2, (SimpleNameSyntax) obj3);
      }

      internal static object KvGt5vvft18Lcg5Nnq42([In] object obj0) => (object) ((VariableDeclarationSyntax) obj0).Type;

      internal static object K0dJA4vfwFCWXgS6WSL8([In] object obj0) => (object) ((ISymbol) obj0).ContainingType;

      internal static object jjNBSPvf40aGWAfa4Gf2([In] SyntaxKind obj0, [In] object obj1, [In] object obj2) => (object) SyntaxFactory.MemberAccessExpression(obj0, (ExpressionSyntax) obj1, (SimpleNameSyntax) obj2);

      internal static object OrfX8Dvf6Mfto2pxjHwO([In] object obj0, [In] object obj1) => (object) ((ClassGenerator) obj0).GetPropertyTypeDescriptor((PropertyMetadata) obj1);

      internal static object DQmyG7vfH4Anjf6VKlGu([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ClassGenerator) obj0).GetPropertyTypeReference((PropertyMetadata) obj1, (ITypeGenerationInfo) obj2);

      internal static object ltg27PvfARnVHtwhQCVM([In] object obj0) => (object) ((NamedMetadata) obj0).Name;
    }

    /// <inheritdoc />
    public class AssemblyResolver : IAssemblyResolver
    {
      private readonly IDictionary<string, AssemblyDefinition> references;
      internal static EntityDynamicGenerator.AssemblyResolver EhsHK6vf7m2LPYjIkLEC;

      /// <inheritdoc />
      public AssemblyDefinition Resolve(AssemblyNameReference name)
      {
        int num = 12;
        AssemblyDefinition assemblyDefinition;
        while (true)
        {
          MemoryStream memoryStream1;
          Assembly assembly;
          object obj1;
          switch (num)
          {
            case 1:
              obj1 = (object) ComponentManager.FindLoadedAssembly((string) EntityDynamicGenerator.AssemblyResolver.t8kRmMvfyflBo9aRHGfi((object) name), false);
              break;
            case 2:
              EntityDynamicGenerator.AssemblyResolver.GbvlAVvfYJ46DopHXtpU((object) memoryStream1, 0L, SeekOrigin.Begin);
              num = 5;
              continue;
            case 3:
            case 9:
            case 18:
              memoryStream1 = (MemoryStream) EntityDynamicGenerator.AssemblyResolver.zfEJjmvfjJwagaTWlg63((object) assembly);
              num = 15;
              continue;
            case 4:
              object obj2 = EntityDynamicGenerator.AssemblyResolver.TO0PFQvfld9CYK6urPAh((object) assembly);
              ReaderParameters readerParameters1 = new ReaderParameters();
              EntityDynamicGenerator.AssemblyResolver.EtYAifvfgZIRnuODr8FM((object) readerParameters1, (object) this);
              assemblyDefinition = (AssemblyDefinition) EntityDynamicGenerator.AssemblyResolver.xpG9RSvf5bRIfjXnkW4r(obj2, (object) readerParameters1);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 8 : 0;
              continue;
            case 5:
              MemoryStream memoryStream2 = memoryStream1;
              ReaderParameters readerParameters2 = new ReaderParameters();
              EntityDynamicGenerator.AssemblyResolver.EtYAifvfgZIRnuODr8FM((object) readerParameters2, (object) this);
              assemblyDefinition = (AssemblyDefinition) EntityDynamicGenerator.AssemblyResolver.aTa5sqvfLwlKHICppDF5((object) memoryStream2, (object) readerParameters2);
              num = 13;
              continue;
            case 6:
              obj1 = EntityDynamicGenerator.AssemblyResolver.NtT5N8vf9blcHPsnmopH(EntityDynamicGenerator.AssemblyResolver.n6OlSrvfmtfFpG1uMiwl((object) name), true);
              break;
            case 7:
            case 8:
            case 13:
            case 14:
              this.references[(string) EntityDynamicGenerator.AssemblyResolver.n6OlSrvfmtfFpG1uMiwl((object) name)] = assemblyDefinition;
              num = 17;
              continue;
            case 10:
              if (EntityDynamicGenerator.AssemblyResolver.kAl3MOvfdxPC2OsoU2Lx((object) assembly))
              {
                num = 18;
                continue;
              }
              goto case 19;
            case 11:
              if (!EntityDynamicGenerator.AssemblyResolver.xaOdXXvfJNq7SI5EuNh3(EntityDynamicGenerator.AssemblyResolver.t8kRmMvfyflBo9aRHGfi((object) name), EntityDynamicGenerator.AssemblyResolver.vRnAOhvfMw15ZpN93tBU(1051802738 - -1831968059 ^ -1411198007)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 12:
              if (!this.references.TryGetValue((string) EntityDynamicGenerator.AssemblyResolver.n6OlSrvfmtfFpG1uMiwl((object) name), out assemblyDefinition))
              {
                num = 11;
                continue;
              }
              goto label_5;
            case 15:
              if (memoryStream1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 7;
                continue;
              }
              goto case 2;
            case 16:
              if (!(assembly != (Assembly) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 12 : 14;
                continue;
              }
              goto case 10;
            case 17:
              goto label_5;
            case 19:
              if (EntityDynamicGenerator.AssemblyResolver.Ga1uKMvfrSnp4KQMVBkU(EntityDynamicGenerator.AssemblyResolver.TO0PFQvfld9CYK6urPAh((object) assembly)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 3 : 1;
                continue;
              }
              goto case 4;
            default:
              if ((string) EntityDynamicGenerator.AssemblyResolver.t8kRmMvfyflBo9aRHGfi((object) name) == (string) EntityDynamicGenerator.AssemblyResolver.vRnAOhvfMw15ZpN93tBU(-542721635 ^ -542723149))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
                continue;
              }
              goto case 6;
          }
          assembly = (Assembly) obj1;
          num = 16;
        }
label_5:
        return assemblyDefinition;
      }

      /// <inheritdoc />
      public AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters) => throw new NotImplementedException();

      /// <inheritdoc />
      public AssemblyDefinition Resolve(string fullName) => throw new NotImplementedException();

      /// <inheritdoc />
      public AssemblyDefinition Resolve(string fullName, ReaderParameters parameters) => throw new NotImplementedException();

      public AssemblyResolver()
      {
        EntityDynamicGenerator.AssemblyResolver.NTbNy2vfUxiyONhFSE5x();
        this.references = (IDictionary<string, AssemblyDefinition>) new Dictionary<string, AssemblyDefinition>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object n6OlSrvfmtfFpG1uMiwl([In] object obj0) => (object) ((AssemblyNameReference) obj0).FullName;

      internal static object t8kRmMvfyflBo9aRHGfi([In] object obj0) => (object) ((AssemblyNameReference) obj0).Name;

      internal static object vRnAOhvfMw15ZpN93tBU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool xaOdXXvfJNq7SI5EuNh3([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static object NtT5N8vf9blcHPsnmopH([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

      internal static bool kAl3MOvfdxPC2OsoU2Lx([In] object obj0) => ((Assembly) obj0).IsDynamic;

      internal static object TO0PFQvfld9CYK6urPAh([In] object obj0) => (object) ((Assembly) obj0).Location;

      internal static bool Ga1uKMvfrSnp4KQMVBkU([In] object obj0) => string.IsNullOrEmpty((string) obj0);

      internal static void EtYAifvfgZIRnuODr8FM([In] object obj0, [In] object obj1) => ((ReaderParameters) obj0).AssemblyResolver = (IAssemblyResolver) obj1;

      internal static object xpG9RSvf5bRIfjXnkW4r([In] object obj0, [In] object obj1) => (object) AssemblyDefinition.ReadAssembly((string) obj0, (ReaderParameters) obj1);

      internal static object zfEJjmvfjJwagaTWlg63([In] object obj0) => (object) ComponentManager.GetLoadedAssemblyRawAsStream((Assembly) obj0);

      internal static long GbvlAVvfYJ46DopHXtpU([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

      internal static object aTa5sqvfLwlKHICppDF5([In] object obj0, [In] object obj1) => (object) AssemblyDefinition.ReadAssembly((Stream) obj0, (ReaderParameters) obj1);

      internal static bool DjsFnQvfxdUsbaCj61bh() => EntityDynamicGenerator.AssemblyResolver.EhsHK6vf7m2LPYjIkLEC == null;

      internal static EntityDynamicGenerator.AssemblyResolver RiXiAjvf072B8JJhFQ6b() => EntityDynamicGenerator.AssemblyResolver.EhsHK6vf7m2LPYjIkLEC;

      internal static void NTbNy2vfUxiyONhFSE5x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private sealed class EntityDynamicPermissionsGenerator : EntityDynamicGenerator
    {
      private readonly object entityMetadata;
      private static object QaritgvfsYFmHnIEOUAO;

      /// <summary>Ctor</summary>
      /// <param name="entityMetadata">Метаданные сущности</param>
      public EntityDynamicPermissionsGenerator(EntityMetadata entityMetadata)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.entityMetadata = (object) entityMetadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <inheritdoc />
      protected override IEnumerable<ISyntaxNode> GenerateMainFile() => EntityPermissionsGenerator.GenerateMainFile(this.metadata, new Func<IEnumerable<ISyntaxNode>>(((EntityGenerator) this).GenerateMainFile));

      /// <inheritdoc />
      protected override bool HasCustomCode => true;

      /// <inheritdoc />
      protected override IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources() => EntityPermissionsGenerator.GenerateCustomCodeResources((EntityMetadata) this.entityMetadata, this.metadata);

      /// <inheritdoc />
      protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => this.GenerateCustomCodeResources();

      internal static bool ecs38CvfcBGe74qmxFwH() => EntityDynamicGenerator.EntityDynamicPermissionsGenerator.QaritgvfsYFmHnIEOUAO == null;

      internal static EntityDynamicGenerator.EntityDynamicPermissionsGenerator hI004mvfzm7yl521Ohil() => (EntityDynamicGenerator.EntityDynamicPermissionsGenerator) EntityDynamicGenerator.EntityDynamicPermissionsGenerator.QaritgvfsYFmHnIEOUAO;
    }
  }
}
