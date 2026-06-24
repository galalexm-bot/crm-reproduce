// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ConfigurationModelAssemblyBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.CodeGeneration.Analyzers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis.Diagnostics;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Сборщик библиотеки конфигурации</summary>
  internal static class ConfigurationModelAssemblyBuilder
  {
    private static ILogger publishLogger;
    /// <summary>Имся дельта-сборки ConfigurationModel</summary>
    internal const string CONFIGURAION_MODEL_DELTA_ASSEMBLY_NAME = "EleWise.ELMA.ConfigurationModel.Delta";
    /// <summary>Имся дельта-сборки DynamicModel</summary>
    internal const string DYNAMIC_MODEL_DELTA_ASSEMBLY_NAME = "EleWise.ELMA.DynamicModel.Delta";
    private static bool versionIniting;
    private static Version version;
    private static bool existDataClassTable;
    private static readonly XmlObjectSerializableType xmlObjSerType;
    private static readonly ContextVars.Local<bool> isConfigurationModelBuild;
    private static ConfigurationModelAssemblyBuilder DIZ4SUh2KcTBW3s8pYim;

    private static MemoryStream Merge(
      object assemblyRaw,
      object deltaAssemblyRaw,
      IDictionary<string, string> referencesRewrite = null)
    {
      EntityDynamicGenerator.AssemblyResolver assemblyResolver = new EntityDynamicGenerator.AssemblyResolver();
      AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly((Stream) assemblyRaw, new ReaderParameters()
      {
        AssemblyResolver = (IAssemblyResolver) assemblyResolver
      });
      ConfigurationModelAssemblyBuilder.Merge((object) assembly, (object) AssemblyDefinition.ReadAssembly((Stream) deltaAssemblyRaw, new ReaderParameters()
      {
        AssemblyResolver = (IAssemblyResolver) assemblyResolver
      }), referencesRewrite);
      MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
      assembly.Write((Stream) memoryStream);
      ((Stream) assemblyRaw).Seek(0L, SeekOrigin.Begin);
      ((Stream) deltaAssemblyRaw).Seek(0L, SeekOrigin.Begin);
      memoryStream.Seek(0L, SeekOrigin.Begin);
      return memoryStream;
    }

    private static void Merge(
      object assembly,
      object deltaAssembly,
      IDictionary<string, string> referencesRewrite = null)
    {
      AssemblyDefinition assembly1 = (AssemblyDefinition) assembly;
      IDictionary<string, string> referencesRewrite1 = referencesRewrite;
      ModuleDefinition module = assembly1.MainModule;
      ModuleDefinition deltaModule = ((AssemblyDefinition) deltaAssembly).MainModule;
      Dictionary<TypeReference, TypeReference> resolvedTypes = new Dictionary<TypeReference, TypeReference>();
      Dictionary<MethodReference, MethodReference> resolvedMethods = new Dictionary<MethodReference, MethodReference>();
      Dictionary<FieldReference, FieldReference> resolvedFields = new Dictionary<FieldReference, FieldReference>();
      List<(TypeDefinition, TypeDefinition)> types = new List<(TypeDefinition, TypeDefinition)>();
      List<(TypeDefinition, TypeDefinition)> newTypes = new List<(TypeDefinition, TypeDefinition)>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (TypeDefinition deltaType in deltaModule.Types.Where<TypeDefinition>((System.Func<TypeDefinition, bool>) (t => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.RhajJnvZ6JTS4Ws5ljsj(ConfigurationModelAssemblyBuilder.\u003C\u003Ec.iIl0ZlvZ40CLm3hEPQdy((object) t), (object) "<Module>"))))
      {
        TypeDefinition typeDefinition = module.GetType(deltaType.Namespace, deltaType.Name);
        if (typeDefinition == null)
        {
          module.Types.Add(typeDefinition = new TypeDefinition(deltaType.Namespace, deltaType.Name, deltaType.Attributes));
          newTypes.Add((typeDefinition, deltaType));
          foreach (GenericParameter genericParameter1 in deltaType.GenericParameters)
          {
            GenericParameter genericParameter2 = new GenericParameter(genericParameter1.Name, (IGenericParameterProvider) typeDefinition);
            typeDefinition.GenericParameters.Add(genericParameter2);
            genericParameter2.Attributes = genericParameter1.Attributes;
            CreateCustomAttributes(genericParameter1.CustomAttributes, genericParameter2.CustomAttributes);
          }
        }
        else
        {
          foreach (GenericParameter genericParameter3 in deltaType.GenericParameters)
          {
            GenericParameter genericParameter4 = typeDefinition.GenericParameters[genericParameter3.Position];
            CreateCustomAttributes(genericParameter3.CustomAttributes, genericParameter4.CustomAttributes);
          }
        }
        types.Add((typeDefinition, deltaType));
        AddNestedTypes(typeDefinition, deltaType);
      }
      foreach ((TypeDefinition type, TypeDefinition deltaType) in newTypes)
      {
        foreach (GenericParameter genericParameter5 in deltaType.GenericParameters)
        {
          GenericParameter genericParameter6 = type.GenericParameters[genericParameter5.Position];
          foreach (TypeReference constraint in genericParameter5.Constraints)
            genericParameter6.Constraints.Add(ResolveTypeReference(constraint));
        }
        if (deltaType.BaseType != null)
          type.BaseType = ResolveTypeReference(deltaType.BaseType);
      }
      List<(MethodDefinition, MethodDefinition)> valueTupleList1 = new List<(MethodDefinition, MethodDefinition)>();
      List<(MethodDefinition, MethodDefinition)> valueTupleList2 = new List<(MethodDefinition, MethodDefinition)>();
      foreach ((TypeDefinition type, TypeDefinition deltaType) in types)
      {
        type.Interfaces.Clear();
        deltaType.Interfaces.Select<TypeReference, TypeReference>(new System.Func<TypeReference, TypeReference>(ResolveTypeReference)).ForEach<TypeReference>(new Action<TypeReference>(type.Interfaces.Add));
        CreateCustomAttributes(deltaType.CustomAttributes, type.CustomAttributes);
        foreach (FieldDefinition field in deltaType.Fields)
        {
          FieldDefinition deltaField = field;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          FieldDefinition fieldDefinition = type.Fields.FirstOrDefault<FieldDefinition>((System.Func<FieldDefinition, bool>) (f => ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_1.TiFAgSv8UiBNTKLVVaoU(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_1.VSRqMnv8LCEAujhICsh2((object) f), (object) deltaField.Name)));
          if (fieldDefinition == null)
          {
            fieldDefinition = new FieldDefinition(deltaField.Name, deltaField.Attributes, ResolveTypeReference(deltaField.FieldType));
            type.Fields.Add(fieldDefinition);
          }
          CreateCustomAttributes(deltaField.CustomAttributes, fieldDefinition.CustomAttributes);
          fieldDefinition.Constant = deltaField.Constant;
          fieldDefinition.Offset = deltaField.Offset;
        }
        Dictionary<MethodDefinition, MethodDefinition> dictionary = new Dictionary<MethodDefinition, MethodDefinition>();
        foreach (MethodDefinition method in deltaType.Methods)
        {
          MethodDefinition deltaMethod = method;
          MethodDefinition owner = type.Methods.FirstOrDefault<MethodDefinition>((System.Func<MethodDefinition, bool>) (m =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  if (m.Name == (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_2.asHrjDvZB3UI6wW48nMg((object) deltaMethod))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                default:
                  goto label_2;
              }
            }
label_2:
            return m.Parameters.SequenceEqual<ParameterDefinition>((IEnumerable<ParameterDefinition>) deltaMethod.Parameters, ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.Instance);
label_3:
            return false;
          }));
          if (owner == null)
          {
            type.Methods.Add(owner = new MethodDefinition(deltaMethod.Name, deltaMethod.Attributes, ResolveTypeReference(deltaMethod.ReturnType)));
            valueTupleList2.Add((owner, deltaMethod));
            foreach (GenericParameter genericParameter7 in deltaMethod.GenericParameters)
            {
              GenericParameter genericParameter8 = new GenericParameter(genericParameter7.Name, (IGenericParameterProvider) owner);
              owner.GenericParameters.Add(genericParameter8);
              genericParameter8.Attributes = genericParameter7.Attributes;
              CreateCustomAttributes(genericParameter7.CustomAttributes, genericParameter8.CustomAttributes);
            }
            foreach (GenericParameter genericParameter9 in deltaMethod.GenericParameters)
            {
              GenericParameter genericParameter10 = owner.GenericParameters[genericParameter9.Position];
              foreach (TypeReference constraint in genericParameter9.Constraints)
                genericParameter10.Constraints.Add(ResolveTypeReference(constraint));
            }
            foreach (ParameterDefinition parameter in deltaMethod.Parameters)
            {
              ParameterDefinition parameterDefinition = new ParameterDefinition(parameter.Name, parameter.Attributes, ResolveTypeReference(parameter.ParameterType));
              owner.Parameters.Add(parameterDefinition);
              CreateCustomAttributes(parameter.CustomAttributes, parameterDefinition.CustomAttributes);
            }
            owner.CallingConvention = deltaMethod.CallingConvention;
            owner.ImplAttributes = deltaMethod.ImplAttributes;
          }
          else
          {
            foreach (GenericParameter genericParameter11 in deltaMethod.GenericParameters)
            {
              GenericParameter genericParameter12 = owner.GenericParameters[genericParameter11.Position];
              CreateCustomAttributes(genericParameter11.CustomAttributes, genericParameter12.CustomAttributes);
            }
          }
          dictionary[deltaMethod] = owner;
          if (owner.HasBody)
            valueTupleList1.Add((owner, deltaMethod));
          CreateCustomAttributes(deltaMethod.CustomAttributes, owner.CustomAttributes);
        }
        foreach (PropertyDefinition property in deltaType.Properties)
        {
          PropertyDefinition deltaProperty = property;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          PropertyDefinition propertyDefinition = type.Properties.FirstOrDefault<PropertyDefinition>((System.Func<PropertyDefinition, bool>) (p => ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_3.mboHV7vZEXRXrNcqD4GM(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_3.U7qV5ovZGA5R46CEnLlE((object) p), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_3.U7qV5ovZGA5R46CEnLlE((object) deltaProperty))));
          if (propertyDefinition == null)
          {
            propertyDefinition = new PropertyDefinition(deltaProperty.Name, deltaProperty.Attributes, ResolveTypeReference(deltaProperty.PropertyType));
            type.Properties.Add(propertyDefinition);
            propertyDefinition.GetMethod = deltaProperty.GetMethod != null ? dictionary[deltaProperty.GetMethod] : (MethodDefinition) null;
            propertyDefinition.SetMethod = deltaProperty.SetMethod != null ? dictionary[deltaProperty.SetMethod] : (MethodDefinition) null;
          }
          CreateCustomAttributes(deltaProperty.CustomAttributes, propertyDefinition.CustomAttributes);
        }
      }
      foreach ((MethodDefinition, MethodDefinition) valueTuple in valueTupleList2)
      {
        MethodDefinition methodDefinition = valueTuple.Item1;
        foreach (MethodReference methodReference in valueTuple.Item2.Overrides)
          methodDefinition.Overrides.Add(ResolveMethodReference(methodReference));
      }
      foreach ((MethodDefinition methodDefinition1, MethodDefinition methodDefinition2) in valueTupleList1)
      {
        methodDefinition1.Body = methodDefinition2.Body;
        methodDefinition2.Body = (Mono.Cecil.Cil.MethodBody) null;
        foreach (VariableDefinition variable in methodDefinition1.Body.Variables)
          variable.VariableType = ResolveTypeReference(variable.VariableType);
        foreach (Instruction instruction in methodDefinition1.Body.Instructions)
        {
          switch (instruction.Operand)
          {
            case ParameterDefinition parameterDefinition:
              instruction.Operand = (object) methodDefinition1.Parameters[parameterDefinition.Index];
              continue;
            case MethodReference methodReference:
              instruction.Operand = (object) ResolveMethodReference(methodReference);
              continue;
            case TypeReference typeReference:
              instruction.Operand = (object) ResolveTypeReference(typeReference);
              continue;
            case FieldReference fieldReference:
              instruction.Operand = (object) ResolveFieldReference(fieldReference);
              continue;
            default:
              continue;
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      HashSet<Resource> hashSet = ((IEnumerable<Resource>) deltaModule.Resources.OfType<EmbeddedResource>().Select<EmbeddedResource, EmbeddedResource>((System.Func<EmbeddedResource, EmbeddedResource>) (r => new EmbeddedResource((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec.sXER1ZvZH6GcP8IgEGpm((object) r), ConfigurationModelAssemblyBuilder.\u003C\u003Ec.FEmrhAvZAtPu0srl8bGI((object) r), (byte[]) ConfigurationModelAssemblyBuilder.\u003C\u003Ec.lrHq2JvZ70ExvrSVMK4U((object) r))))).ToHashSet<Resource>((IEqualityComparer<Resource>) FunctorEqualityComparer<Resource>.Create((Func<Resource, Resource, bool>) ((r1, r2) => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.BowSaGvZx0ZX0r6IegY2(ConfigurationModelAssemblyBuilder.\u003C\u003Ec.sXER1ZvZH6GcP8IgEGpm((object) r1), (object) r2.Name)), (System.Func<Resource, int>) (r => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.sXER1ZvZH6GcP8IgEGpm((object) r).GetHashCode())));
      module.Resources.RemoveAll<Resource>(new System.Func<Resource, bool>(hashSet.Contains));
      module.Resources.AddRange<Resource>((IEnumerable<Resource>) hashSet);
      assembly1.Name.Version = ((AssemblyDefinition) deltaAssembly).Name.Version;

      void AddNestedTypes(TypeDefinition type, TypeDefinition deltaType)
      {
        int num1 = 1;
        Collection<TypeDefinition>.Enumerator enumerator1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              enumerator1 = deltaType.NestedTypes.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_49;
            default:
              goto label_3;
          }
        }
label_49:
        return;
label_3:
        try
        {
label_22:
          if (enumerator1.MoveNext())
            goto label_42;
          else
            goto label_23;
label_5:
          TypeDefinition typeDefinition;
          Collection<GenericParameter>.Enumerator enumerator2;
          int num2;
          TypeDefinition deltaNestedType;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_45;
              case 2:
              case 5:
                enumerator2 = deltaNestedType.GenericParameters.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 3;
                continue;
              case 3:
                try
                {
label_13:
                  if (enumerator2.MoveNext())
                    goto label_12;
                  else
                    goto label_14;
label_10:
                  GenericParameter current;
                  GenericParameter genericParameter;
                  int num3;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_40;
                      case 2:
                        goto label_12;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        genericParameter = typeDefinition.GenericParameters[ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.hHXD6tv8TgjJrtSTWGm3((object) current)];
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 4;
                        continue;
                      case 4:
                        CreateCustomAttributes(current.CustomAttributes, genericParameter.CustomAttributes);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_13;
                    }
                  }
label_12:
                  current = enumerator2.Current;
                  num3 = 3;
                  goto label_10;
label_14:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
                  goto label_10;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                    num4 = 0;
                  switch (num4)
                  {
                    default:
                  }
                }
              case 4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                type.NestedTypes.Add(typeDefinition = new TypeDefinition((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.vbxudSv8RRUmtBNXGFNK((object) deltaNestedType), deltaNestedType.Name, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.qfCceDv8qn3Eq7HXQi8G((object) deltaNestedType)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 12 : 8;
                continue;
              case 6:
label_40:
                types.Add((typeDefinition, deltaNestedType));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 1;
                continue;
              case 7:
                try
                {
label_34:
                  if (enumerator2.MoveNext())
                    goto label_31;
                  else
                    goto label_35;
label_27:
                  GenericParameter current;
                  GenericParameter genericParameter;
                  int num5;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_40;
                      case 2:
                        goto label_34;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.C3EU01v8XfHjB89bG96W((object) genericParameter, current.Attributes);
                        num5 = 5;
                        continue;
                      case 4:
                        typeDefinition.GenericParameters.Add(genericParameter);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 1;
                        continue;
                      case 5:
                        CreateCustomAttributes(current.CustomAttributes, genericParameter.CustomAttributes);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 0;
                        continue;
                      case 6:
                        goto label_31;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        genericParameter = new GenericParameter((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.iShDl4v8KaiMtEcvp3dj((object) current), (IGenericParameterProvider) typeDefinition);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 4 : 1;
                        continue;
                    }
                  }
label_31:
                  current = enumerator2.Current;
                  num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                  {
                    num5 = 0;
                    goto label_27;
                  }
                  else
                    goto label_27;
label_35:
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
                  goto label_27;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                    num6 = 0;
                  switch (num6)
                  {
                    default:
                  }
                }
              case 8:
                AddNestedTypes(typeDefinition, deltaNestedType);
                num2 = 13;
                continue;
              case 9:
                enumerator2 = deltaNestedType.GenericParameters.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 7 : 7;
                continue;
              case 10:
                if (typeDefinition != null)
                {
                  num2 = 5;
                  continue;
                }
                goto case 4;
              case 11:
                deltaNestedType = enumerator1.Current;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                continue;
              case 12:
                newTypes.Add((typeDefinition, deltaNestedType));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 6 : 9;
                continue;
              case 13:
                goto label_22;
              case 14:
                goto label_42;
              default:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                typeDefinition = type.NestedTypes.FirstOrDefault<TypeDefinition>((System.Func<TypeDefinition, bool>) (t => ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_4.eNUuFfvZ8iAjoKb10ctY(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_4.UAkta7vZvbg7yklmWZMI((object) t), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_4.UAkta7vZvbg7yklmWZMI((object) deltaNestedType))));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 5 : 10;
                continue;
            }
          }
label_45:
          return;
label_23:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
          goto label_5;
label_42:
          num2 = 11;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          {
            num2 = 3;
            goto label_5;
          }
          else
            goto label_5;
        }
        finally
        {
          enumerator1.Dispose();
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
            num7 = 0;
          switch (num7)
          {
            default:
          }
        }
      }

      void CreateCustomAttributes(
        Collection<Mono.Cecil.CustomAttribute> fromCustomAttributes,
        Collection<Mono.Cecil.CustomAttribute> toCustomAttributes)
      {
        toCustomAttributes.Clear();
        foreach (Mono.Cecil.CustomAttribute fromCustomAttribute in fromCustomAttributes)
        {
          Mono.Cecil.CustomAttribute customAttribute = new Mono.Cecil.CustomAttribute(ResolveMethodReference(fromCustomAttribute.Constructor));
          toCustomAttributes.Add(customAttribute);
          foreach (CustomAttributeArgument constructorArgument in fromCustomAttribute.ConstructorArguments)
            customAttribute.ConstructorArguments.Add(CreateCustomAttributeArgument(constructorArgument));
          foreach (Mono.Cecil.CustomAttributeNamedArgument field in fromCustomAttribute.Fields)
            customAttribute.Fields.Add(new Mono.Cecil.CustomAttributeNamedArgument(field.Name, CreateCustomAttributeArgument(field.Argument)));
          foreach (Mono.Cecil.CustomAttributeNamedArgument property in fromCustomAttribute.Properties)
            customAttribute.Properties.Add(new Mono.Cecil.CustomAttributeNamedArgument(property.Name, CreateCustomAttributeArgument(property.Argument)));
        }
      }

      CustomAttributeArgument CreateCustomAttributeArgument(CustomAttributeArgument argument) => new CustomAttributeArgument(ResolveTypeReference(argument.Type), !(argument.Value is TypeReference typeReference1) ? argument.Value : (object) ResolveTypeReference(typeReference1));

      TypeReference ResolveTypeReference(TypeReference typeReference)
      {
        int num1 = 6;
        TypeReference result;
        while (true)
        {
          int num2 = num1;
          AssemblyNameReference scope;
          string rewrite;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                resolvedTypes[typeReference] = result = (TypeReference) module.GetType((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.IG6MjPv8D13WmUK6hDOZ((object) typeReference));
                num2 = 15;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (!(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv((object) typeReference) is AssemblyNameReference assemblyNameReference1))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 24 : 30;
                  continue;
                }
                goto case 32;
              case 3:
              case 20:
                // ISSUE: reference to a compiler-generated method
                if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.fteVmav8nJ3rWVPR7gNK((object) typeReference))
                  goto case 22;
                else
                  goto label_41;
              case 4:
              case 10:
              case 13:
              case 15:
              case 16:
              case 21:
              case 36:
              case 42:
                goto label_3;
              case 5:
                goto label_25;
              case 6:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 5;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated method
                resolvedTypes[typeReference] = result = (TypeReference) new GenericInstanceType(ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.doHBlpv81o1946mFGTZa((object) (GenericInstanceType) typeReference)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 34 : 6;
                continue;
              case 8:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ToTo7Fv8anYy136Oki8p(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.bAPaSPv83XklVf3itqR1((object) assemblyNameReference2), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.F2YOBfv8pgyDLXoTaqwy((object) assembly1)))
                {
                  num2 = 35;
                  continue;
                }
                goto case 1;
              case 9:
                // ISSUE: reference to a compiler-generated method
                if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv((object) typeReference) is AssemblyNameReference assemblyNameReference2)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 8 : 6;
                  continue;
                }
                goto label_4;
              case 11:
              case 18:
                // ISSUE: reference to a compiler-generated method
                if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.xrLuyav8OJ1aPHT0NfiM((object) typeReference))
                {
                  num2 = 37;
                  continue;
                }
                goto case 25;
              case 12:
              case 41:
                // ISSUE: reference to a compiler-generated method
                if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv((object) typeReference) == deltaModule)
                  goto case 1;
                else
                  goto label_6;
              case 14:
                // ISSUE: reference to a compiler-generated method
                ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.fjgpvqv84t8oiffx1J3w((object) scope, (object) assemblyNameReference1.Version);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 8 : 23;
                continue;
              case 17:
              case 35:
                goto label_4;
              case 19:
                if (referencesRewrite1 == null)
                {
                  num2 = 29;
                  continue;
                }
                goto case 2;
              case 22:
                // ISSUE: reference to a compiler-generated method
                resolvedTypes[typeReference] = result = (TypeReference) new ArrayType(ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.hBNUbnv8kBnSqhBVrSWw((object) typeReference)));
                num2 = 4;
                continue;
              case 23:
              case 26:
                Dictionary<TypeReference, TypeReference> dictionary1 = resolvedTypes;
                TypeReference key1 = typeReference;
                // ISSUE: reference to a compiler-generated method
                TypeReference typeReference1 = new TypeReference((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.vbxudSv8RRUmtBNXGFNK((object) typeReference), typeReference.Name, module, (IMetadataScope) scope, typeReference.IsValueType);
                // ISSUE: reference to a compiler-generated method
                typeReference1.DeclaringType = ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) typeReference));
                TypeReference typeReference2 = typeReference1;
                result = typeReference1;
                TypeReference typeReference3 = typeReference2;
                dictionary1[key1] = typeReference3;
                num2 = 27;
                continue;
              case 24:
                // ISSUE: reference to a compiler-generated method
                scope = new AssemblyNameReference(rewrite, (Version) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.XaEEd7v8w2kb5GyAFcm9((object) assemblyNameReference1));
                num2 = 28;
                continue;
              case 25:
                // ISSUE: reference to a compiler-generated method
                if (!ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.OqkCPtv8PlQNDtRgOftq((object) typeReference))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 16 : 41;
                  continue;
                }
                goto case 7;
              case 27:
                // ISSUE: reference to a compiler-generated method
                typeReference.GenericParameters.Select<GenericParameter, GenericParameter>((System.Func<GenericParameter, GenericParameter>) (p => new GenericParameter((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_5.HHIxdQvZV3oLL7GUcdpv((object) p), (IGenericParameterProvider) result))).ForEach<GenericParameter>(new Action<GenericParameter>(result.GenericParameters.Add));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 42 : 40;
                continue;
              case 28:
                goto label_39;
              case 29:
              case 30:
              case 40:
                // ISSUE: reference to a compiler-generated method
                resolvedTypes[typeReference] = result = (TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.U7VI5pv86bbJResTt6CQ((object) module, (object) typeReference);
                num2 = 13;
                continue;
              case 31:
                if (resolvedTypes.TryGetValue(typeReference, out result))
                {
                  num2 = 10;
                  continue;
                }
                goto case 43;
              case 32:
                // ISSUE: reference to a compiler-generated method
                if (referencesRewrite1.TryGetValue((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.fOtyRJv8tnLy1JT4I3Iy((object) assemblyNameReference1), out rewrite))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                  continue;
                }
                goto case 29;
              case 33:
                // ISSUE: reference to a compiler-generated method
                resolvedTypes[typeReference] = result = (TypeReference) new ByReferenceType(ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.hBNUbnv8kBnSqhBVrSWw((object) typeReference)));
                num2 = 21;
                continue;
              case 34:
                ((GenericInstanceType) typeReference).GenericArguments.Select<TypeReference, TypeReference>(new System.Func<TypeReference, TypeReference>(ResolveTypeReference)).ForEach<TypeReference>(new Action<TypeReference>(((GenericInstanceType) result).GenericArguments.Add));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 36 : 27;
                continue;
              case 37:
                Dictionary<TypeReference, TypeReference> dictionary2 = resolvedTypes;
                TypeReference key2 = typeReference;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                GenericParameter genericParameter = ResolveMethodReference((MethodReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.IBUa0Mv82w5PiwMm0TwG((object) (GenericParameter) typeReference))?.GenericParameters[ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.hHXD6tv8TgjJrtSTWGm3((object) (GenericParameter) typeReference)];
                // ISSUE: reference to a compiler-generated method
                TypeReference typeReference4 = result = (TypeReference) (genericParameter == null ? ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) typeReference)).GenericParameters[((GenericParameter) typeReference).Position] : genericParameter);
                dictionary2[key2] = typeReference4;
                num2 = 16;
                continue;
              case 38:
                if (scope == null)
                {
                  num2 = 24;
                  continue;
                }
                goto case 14;
              case 39:
                goto label_12;
              case 43:
                if (!(typeReference is ByReferenceType))
                {
                  num2 = 20;
                  continue;
                }
                goto case 33;
              default:
                // ISSUE: reference to a compiler-generated method
                scope = module.AssemblyReferences.FirstOrDefault<AssemblyNameReference>((System.Func<AssemblyNameReference, bool>) (r => (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_6.SdoOQ3vZK9ewajFVrakN((object) r) == rewrite));
                num2 = 38;
                continue;
            }
          }
label_4:
          num1 = 19;
          continue;
label_6:
          num1 = 9;
          continue;
label_25:
          if (typeReference != null)
          {
            num1 = 31;
            continue;
          }
          goto label_12;
label_39:
          module.AssemblyReferences.Add(scope);
          num1 = 26;
          continue;
label_41:
          num1 = 11;
        }
label_3:
        return result;
label_12:
        return (TypeReference) null;
      }

      MethodReference ResolveMethodReference(MethodReference methodReference)
      {
        int num1 = 7;
        MethodReference result;
        while (true)
        {
          int num2 = num1;
          MethodReference methodReference1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ToTo7Fv8anYy136Oki8p(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.bAPaSPv83XklVf3itqR1((object) assemblyNameReference3), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.F2YOBfv8pgyDLXoTaqwy((object) assembly1)))
                {
                  num2 = 16;
                  continue;
                }
                goto case 11;
              case 2:
                if (!resolvedMethods.TryGetValue(methodReference1, out result))
                  goto default;
                else
                  goto label_24;
              case 3:
              case 12:
              case 15:
              case 17:
                goto label_3;
              case 4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) methodReference1)) is AssemblyNameReference assemblyNameReference3)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                  continue;
                }
                goto case 11;
              case 5:
                if (methodReference1 != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
                  continue;
                }
                goto label_22;
              case 6:
                methodReference1 = methodReference;
                num2 = 5;
                continue;
              case 7:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 6 : 5;
                continue;
              case 8:
                // ISSUE: reference to a compiler-generated method
                resolvedMethods[methodReference1] = result = (MethodReference) new GenericInstanceMethod(ResolveMethodReference((MethodReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.BYaNV8v8AJvRcEoqYeBo((object) (GenericInstanceMethod) methodReference1)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 14;
                continue;
              case 9:
                // ISSUE: reference to a compiler-generated method
                methodReference1.GenericParameters.Select<GenericParameter, GenericParameter>((System.Func<GenericParameter, GenericParameter>) (p => new GenericParameter((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_7.cNE216vZO29J3GJbm48H((object) p), (IGenericParameterProvider) result))).ForEach<GenericParameter>(new Action<GenericParameter>(result.GenericParameters.Add));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 6 : 10;
                continue;
              case 10:
                goto label_18;
              case 11:
                Dictionary<MethodReference, MethodReference> dictionary = resolvedMethods;
                MethodReference key = methodReference1;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                MethodReference methodReference2 = new MethodReference((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.iShDl4v8KaiMtEcvp3dj((object) methodReference1), (TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.hygSUCv8xHCrrh1vReNG((object) methodReference1), ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) methodReference1)));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.JqoyNHv8mabnXrA7sZpO((object) methodReference2, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.IiGy69v80qCSwtURIekG((object) methodReference1));
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.xgCVlcv8MRsfcP8Qu2ul((object) methodReference2, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.h5tX9xv8y0QO7rJEsynn((object) methodReference1));
                methodReference2.HasThis = methodReference1.HasThis;
                MethodReference methodReference3 = methodReference2;
                result = methodReference2;
                MethodReference methodReference4 = methodReference3;
                dictionary[key] = methodReference4;
                num2 = 9;
                continue;
              case 13:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                methodReference1.Parameters.Select<ParameterDefinition, ParameterDefinition>((System.Func<ParameterDefinition, ParameterDefinition>) (p => new ParameterDefinition((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.SJH7hbv89tW9nN8lCQy3((object) p), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.cMEMjfv8dPsKOHFrjkal((object) p), ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.OcWQ6Iv8lB8avde1wHAn((object) p))))).ForEach<ParameterDefinition>(new Action<ParameterDefinition>(result.Parameters.Add));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 11 : 17;
                continue;
              case 14:
                ((GenericInstanceMethod) methodReference1).GenericArguments.Select<TypeReference, TypeReference>(new System.Func<TypeReference, TypeReference>(ResolveTypeReference)).ForEach<TypeReference>(new Action<TypeReference>(((GenericInstanceMethod) result).GenericArguments.Add));
                num2 = 12;
                continue;
              case 16:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                resolvedMethods[methodReference1] = result = (MethodReference) ((TypeDefinition) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.shr5vLv87nSyS3QBwHMx((object) ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) methodReference1)))).Methods.First<MethodDefinition>((System.Func<MethodDefinition, bool>) (m =>
                {
                  int num = 1;
                  while (true)
                  {
                    switch (num)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_7.bSu3wSvZ2Z0fjOh3p2IQ((object) m.Name, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_7.cNE216vZO29J3GJbm48H((object) methodReference1)))
                        {
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  return m.Parameters.SequenceEqual<ParameterDefinition>((IEnumerable<ParameterDefinition>) methodReference1.Parameters, ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.Instance);
label_5:
                  return false;
                }));
                num2 = 15;
                continue;
              case 18:
                // ISSUE: reference to a compiler-generated method
                if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv((object) methodReference1.DeclaringType) != deltaModule)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 4;
                  continue;
                }
                goto case 16;
              case 19:
                goto label_22;
              default:
                // ISSUE: reference to a compiler-generated method
                if (!ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.Md5xT8v8H0dbL8yKDY8g((object) methodReference1))
                  goto case 18;
                else
                  goto label_20;
            }
          }
label_18:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.bPWjSjv8JDVsqZI6oPqm((object) result, (object) ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.hygSUCv8xHCrrh1vReNG((object) methodReference1)));
          num1 = 13;
          continue;
label_20:
          num1 = 8;
          continue;
label_24:
          num1 = 3;
        }
label_3:
        return result;
label_22:
        return (MethodReference) null;
      }

      FieldReference ResolveFieldReference(FieldReference fieldReference)
      {
        int num = 8;
        FieldReference fieldReference2;
        FieldReference fieldReference1;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 3:
              goto label_2;
            case 2:
              goto label_14;
            case 4:
              // ISSUE: reference to a compiler-generated method
              if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ToTo7Fv8anYy136Oki8p((object) assemblyNameReference4.FullName, (object) assembly1.FullName))
              {
                num = 5;
                continue;
              }
              goto case 9;
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              resolvedFields[fieldReference1] = fieldReference2 = (FieldReference) ((TypeDefinition) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.shr5vLv87nSyS3QBwHMx((object) ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) fieldReference1)))).Fields.First<FieldDefinition>((System.Func<FieldDefinition, bool>) (f => ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_8.mgxXVXvZp9lPXGr1LFq0(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_8.mMnNWtvZ3cDfNhLYdBc7((object) f), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_8.mMnNWtvZ3cDfNhLYdBc7((object) fieldReference1))));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
            case 6:
              if (fieldReference1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 2;
                continue;
              }
              if (!resolvedFields.TryGetValue(fieldReference1, out fieldReference2))
              {
                num = 10;
                continue;
              }
              goto label_2;
            case 7:
              fieldReference1 = fieldReference;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 6;
              continue;
            case 8:
              num = 7;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              resolvedFields[fieldReference1] = fieldReference2 = new FieldReference((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.iShDl4v8KaiMtEcvp3dj((object) fieldReference1), ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.BgigmUv8riRAaHovYFW5((object) fieldReference1)), ResolveTypeReference((TypeReference) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) fieldReference1)));
              num = 3;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) fieldReference1)) != deltaModule)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            default:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.ryaSFGv8NyfCZeZROPhv(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass1_0.W1Srlnv8eNDjJeMM4dC1((object) fieldReference1)) is AssemblyNameReference assemblyNameReference4)
              {
                num = 4;
                continue;
              }
              goto case 9;
          }
        }
label_2:
        return fieldReference2;
label_14:
        return (FieldReference) null;
      }
    }

    private static MemoryStream MergeDocumentation(object docRaw, object deltaDocRaw)
    {
      int num1 = 12;
      string str1;
      while (true)
      {
        int num2 = num1;
        Regex regex;
        Dictionary<string, string> deltaMembers;
        while (true)
        {
          switch (num2)
          {
            case 1:
              regex = new Regex((string) ConfigurationModelAssemblyBuilder.jd6noph2kB36YcYQqbQu(1505778440 - 1981636111 ^ -475943121), RegexOptions.Singleline);
              num2 = 7;
              continue;
            case 2:
              if (((Stream) docRaw).Length == 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 10 : 9;
                continue;
              }
              if (deltaDocRaw != null)
              {
                num2 = 3;
                continue;
              }
              goto label_5;
            case 3:
              if (((Stream) deltaDocRaw).Length != 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            case 4:
            case 10:
              goto label_17;
            case 5:
              if (deltaMembers.Count > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 6:
              str1 = (string) ConfigurationModelAssemblyBuilder.uc7yrfh2e48nCOZe4IFZ((object) regex, (object) ((Encoding) ConfigurationModelAssemblyBuilder.Iebw0ph22FNJPZDHleG3()).GetString((byte[]) ConfigurationModelAssemblyBuilder.UYLVyQh2n75Q2HxQnL6d(docRaw)), (object) (MatchEvaluator) (m =>
              {
                int num3 = 1;
                string str2;
                string key;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      key = (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass2_0.ukBGDCvuB8rnLdqR7l8b(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass2_0.nPYXb8vuF3U5Cb2hTnFw(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass2_0.fDscKIvZcwnfZObRGxc8((object) m), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass2_0.miE4sPvZzNgDUooqvkjy(2008901894 << 3 ^ -1108655066)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_3;
                    case 3:
                      deltaMembers.Remove(key);
                      num3 = 4;
                      continue;
                    case 4:
                      goto label_2;
                    default:
                      if (!deltaMembers.TryGetValue(key, out str2))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 2;
                        continue;
                      }
                      goto case 3;
                  }
                }
label_2:
                return str2;
label_3:
                // ISSUE: reference to a compiler-generated method
                return (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass2_0.ukBGDCvuB8rnLdqR7l8b((object) m);
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 5 : 5;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              deltaMembers = regex.Matches((string) ConfigurationModelAssemblyBuilder.kykDiZh2O5maKboJtRgv((object) Encoding.UTF8, ConfigurationModelAssemblyBuilder.UYLVyQh2n75Q2HxQnL6d(deltaDocRaw))).Cast<Match>().ToDictionary<Match, string, string>((System.Func<Match, string>) (m => (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec.al7cXbvZmKGH9PwkdWBx(ConfigurationModelAssemblyBuilder.\u003C\u003Ec.i8YApBvZ0A9x0bqQslBM((object) m.Groups, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521269162)))), (System.Func<Match, string>) (m => (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec.al7cXbvZmKGH9PwkdWBx((object) m)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 6;
              continue;
            case 8:
              goto label_13;
            case 9:
              goto label_5;
            case 11:
              if (docRaw == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 4;
                continue;
              }
              goto case 2;
            case 12:
              num2 = 11;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        str1 = str1.Insert(ConfigurationModelAssemblyBuilder.chqQrEh21U1nABbtfjsy((object) str1, ConfigurationModelAssemblyBuilder.jd6noph2kB36YcYQqbQu(1917998801 >> 2 ^ 479524490), ConfigurationModelAssemblyBuilder.EhiU2Hh2Pj2Q9Enl11PH((object) str1, ConfigurationModelAssemblyBuilder.jd6noph2kB36YcYQqbQu(~-122002947 ^ 122079820))) + 2, string.Concat((IEnumerable<string>) deltaMembers.Values));
        num1 = 8;
      }
label_5:
      return (MemoryStream) docRaw;
label_13:
      return (MemoryStream) ConfigurationModelAssemblyBuilder.UMBrZfh234A42cm4EViJ(ConfigurationModelAssemblyBuilder.cirkUFh2NqtqjCVoZ4nM((object) Encoding.UTF8, (object) str1), false);
label_17:
      return (MemoryStream) deltaDocRaw;
    }

    /// <summary>Сборка ConfigurationModel</summary>
    internal static bool IsConfigurationModelBuild => ConfigurationModelAssemblyBuilder.isConfigurationModelBuild.Value;

    /// <summary>Опубликовать</summary>
    /// <param name="publishedMetadataItems">Публикуемые элементы метаданных</param>
    /// <param name="loadAssemblyMetadata">Метод загрузки метаданных</param>
    /// <param name="saveAssemblyMetadata">Метод сохранения метаданных</param>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    /// <param name="modelAssemblyBuilderHandler">Точка расширения, реагирующая на построение динамических сборок</param>
    /// <param name="xmlMetadataList">Список всех метаданных, десериализованных из xml</param>
    /// <param name="allScriptModules">Все опубликованные модули сценариев</param>
    /// <param name="ignoreScriptsErrors">Игнорировать ошибки компиляции скриптов</param>
    /// <param name="buildDynamicAssembly">Собирать динамик-сборку</param>
    /// <param name="buildClientScripts">Собирать ли клиентские скрипты</param>
    /// <param name="buildDeltaAssemblies">Собрать дельта сборки</param>
    /// <returns>Результат публикации</returns>
    public static MetadataAssemblyPublishResult Publish(
      IEnumerable<IMetadataItem> publishedMetadataItems,
      Func<string, AssemblyModelsMetadataStatus, AssemblyModelsMetadata> loadAssemblyMetadata,
      Action<AssemblyModelsMetadata> saveAssemblyMetadata,
      IMetadataRuntimeService metadataRuntimeService,
      IModelAssemblyBuilderHandler modelAssemblyBuilderHandler,
      IEnumerable<AbstractMetadata> xmlMetadataList = null,
      IList<ScriptModule> allScriptModules = null,
      bool ignoreScriptsErrors = true,
      bool buildDynamicAssembly = false,
      bool buildClientScripts = false,
      bool buildDeltaAssemblies = false)
    {
      // ISSUE: reference to a compiler-generated method
      List<AbstractMetadata> list1 = publishedMetadataItems.Select<IMetadataItem, AbstractMetadata>((System.Func<IMetadataItem, AbstractMetadata>) (item => (AbstractMetadata) ConfigurationModelAssemblyBuilder.\u003C\u003Ec.GFUrwsvZyQCIQo9sEspD((object) item))).ToList<AbstractMetadata>();
      // ISSUE: reference to a compiler-generated method
      ScriptModule[] array1 = publishedMetadataItems.Select<IMetadataItem, ScriptModule>((System.Func<IMetadataItem, ScriptModule>) (item => (ScriptModule) ConfigurationModelAssemblyBuilder.\u003C\u003Ec.VjvbHQvZMr3i7SxvmN3l((object) item))).Where<ScriptModule>((System.Func<ScriptModule, bool>) (item => item != null)).ToArray<ScriptModule>();
      // ISSUE: reference to a compiler-generated method
      ScriptModule[] array2 = publishedMetadataItems.Select<IMetadataItem, ScriptModule>((System.Func<IMetadataItem, ScriptModule>) (item => (ScriptModule) ConfigurationModelAssemblyBuilder.\u003C\u003Ec.DUGNZBvZJKrcroL6PVB7((object) item))).Where<ScriptModule>((System.Func<ScriptModule, bool>) (item => item != null)).ToArray<ScriptModule>();
      ModelHelper.CheckEntityAndTableNames(list1);
      Dictionary<IMetadata, MetadataItemValidationError[]> dictionary1 = new Dictionary<IMetadata, MetadataItemValidationError[]>();
      foreach (IValidatableMetadata key in list1.OfType<IValidatableMetadata>())
      {
        MetadataItemValidationError[] itemValidationErrorArray = key.Validate();
        if (itemValidationErrorArray != null && itemValidationErrorArray.Length != 0)
          dictionary1[(IMetadata) key] = itemValidationErrorArray;
      }
      if (dictionary1.Count > 0)
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822707074)));
        foreach (KeyValuePair<IMetadata, MetadataItemValidationError[]> keyValuePair in dictionary1)
        {
          string str = keyValuePair.Key is NamedMetadata key ? key.DisplayName : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859062505) + (object) keyValuePair.Key.Uid;
          stringBuilder.Append(str);
          if (keyValuePair.Value.Length == 1)
          {
            stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418446558));
            stringBuilder.AppendLine(keyValuePair.Value[0].Message);
          }
          else
          {
            stringBuilder.AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319375230));
            foreach (MetadataItemValidationError itemValidationError in keyValuePair.Value)
            {
              stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643772197));
              stringBuilder.AppendLine(itemValidationError.Message);
            }
          }
        }
        throw new MetadataPublishingException(stringBuilder.ToString())
        {
          ValidationErrors = dictionary1.Values.SelectMany<MetadataItemValidationError[], MetadataItemValidationError>((System.Func<MetadataItemValidationError[], IEnumerable<MetadataItemValidationError>>) (e => (IEnumerable<MetadataItemValidationError>) e)).ToArray<MetadataItemValidationError>()
        };
      }
      MemoryStream memoryStream1 = (MemoryStream) null;
      MemoryStream docRaw1 = (MemoryStream) null;
      MemoryStream memoryStream2 = (MemoryStream) null;
      MemoryStream memoryStream3 = (MemoryStream) null;
      MemoryStream memoryStream4 = (MemoryStream) null;
      MemoryStream memoryStream5 = (MemoryStream) null;
      MemoryStream docRaw2 = (MemoryStream) null;
      AbstractMetadata[] source1 = (AbstractMetadata[]) null;
      Dictionary<Guid, AbstractMetadata> dictionary2;
      if (xmlMetadataList == null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        AssemblyModelsMetadata assemblyModelsMetadata = metadataRuntimeService.GetAssemblyModelsMetadataList().FirstOrDefault<AssemblyModelsMetadata>((System.Func<AssemblyModelsMetadata, bool>) (a => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.BowSaGvZx0ZX0r6IegY2(ConfigurationModelAssemblyBuilder.\u003C\u003Ec.YTaXmmvZdkrZqN5pDKqU((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138957412))));
        Dictionary<Guid, AbstractMetadata> dictionary3;
        if (assemblyModelsMetadata == null)
        {
          dictionary3 = (Dictionary<Guid, AbstractMetadata>) null;
        }
        else
        {
          AbstractMetadata[] source2 = assemblyModelsMetadata.RestoreMetadata();
          // ISSUE: reference to a compiler-generated method
          dictionary3 = source2 != null ? ((IEnumerable<AbstractMetadata>) source2).ToDictionary<AbstractMetadata, Guid>((System.Func<AbstractMetadata, Guid>) (m => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.KM8jh7vZ9QqM6xvNPojE((object) m))) : (Dictionary<Guid, AbstractMetadata>) null;
        }
        dictionary2 = dictionary3 ?? new Dictionary<Guid, AbstractMetadata>();
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        dictionary2 = xmlMetadataList.ToDictionary<AbstractMetadata, Guid>((System.Func<AbstractMetadata, Guid>) (m => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.KM8jh7vZ9QqM6xvNPojE((object) m)));
      }
      Dictionary<Guid, AbstractMetadata> metadataList = dictionary2;
      list1.ForEach((Action<AbstractMetadata>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              metadataList[ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.fu1BcPvuhESjlxeDVbbe((object) m)] = m;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      ConfigurationModelBuilderMetadataService tempMetadataService = new ConfigurationModelBuilderMetadataService(metadataRuntimeService, (IEnumerable<IMetadata>) metadataList.Values);
      IEnumerable<AbstractMetadata> source3 = (IEnumerable<AbstractMetadata>) null;
      ScriptCompiler scriptCompiler = (ScriptCompiler) null;
      StringBuilder scriptErrorsBuilder = (StringBuilder) null;
      try
      {
        using (new MetadataServiceContext((IMetadataService) tempMetadataService))
        {
          string version = ConfigurationModelAssemblyBuilder.NextVersion.ToString();
          using (ModelAssemblyBuilder modelAssemblyBuilder = new ModelAssemblyBuilder(buildDeltaAssemblies ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217521497) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867381655)))
          {
            if (buildDeltaAssemblies)
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123685198));
            else
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515138619));
            modelAssemblyBuilder.AddDefaultReferences();
            try
            {
              ConfigurationModelAssemblyBuilder.isConfigurationModelBuild.Value = true;
              foreach (AbstractMetadata abstractMetadata in buildDeltaAssemblies ? list1.AsEnumerable<AbstractMetadata>() : (IEnumerable<AbstractMetadata>) metadataList.Values)
                modelAssemblyBuilder.AddMetadata((IMetadata) abstractMetadata);
            }
            finally
            {
              ConfigurationModelAssemblyBuilder.isConfigurationModelBuild.Value = false;
            }
            modelAssemblyBuilder.GenerateAssemblyInfo((System.Func<string, string>) (a =>
            {
              int num = 5;
              string str;
              bool? publicationEnable;
              while (true)
              {
                switch (num)
                {
                  case 1:
                  case 2:
                    goto label_7;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    str = (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.lBIbbbvuiqEeMIPo6nRT((object) str, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(993438473 ^ 993225499));
                    num = 2;
                    continue;
                  case 4:
                    publicationEnable = ReflectionType.DynamicPublicationEnable;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                    continue;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    str = (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM((object) a, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-688192331 - 435440695 ^ -1123865656), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289717234)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951280148), (object) version), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(979449278 ^ 979673484), (object) version);
                    num = 4;
                    continue;
                  default:
                    if (!publicationEnable.Value)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                      continue;
                    }
                    goto case 3;
                }
              }
label_7:
              return str;
            }));
            if (buildDeltaAssemblies)
            {
              MemoryStream assemblyRawAsStream = ComponentManager.GetLoadedAssemblyRawAsStream(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236069803), false));
              modelAssemblyBuilder.AddReference(assemblyRawAsStream.AsNoClose());
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889667828));
              memoryStream1 = modelAssemblyBuilder.BuildToStream(false, true);
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309849552));
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575933830));
              cfgModelAssemblyRaw = ConfigurationModelAssemblyBuilder.Merge((object) assemblyRawAsStream, (object) memoryStream1, (IDictionary<string, string>) null);
              foreach (AssemblyModelsMetadata assemblyModelsMetadata in MetadataServiceContext.MetadataRuntimeService.GetAssemblyModelsMetadataList())
              {
                if (assemblyModelsMetadata.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921200729))
                  docRaw1 = assemblyModelsMetadata.DocumentationRawStream;
                if (assemblyModelsMetadata.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397264630))
                {
                  docRaw2 = assemblyModelsMetadata.DocumentationRawStream;
                  source1 = assemblyModelsMetadata.RestoreMetadata();
                }
              }
              docRaw1 = ConfigurationModelAssemblyBuilder.MergeDocumentation((object) docRaw1, (object) modelAssemblyBuilder.DocumentationRawStream);
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082321674));
            }
            else
            {
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643076320));
              cfgModelAssemblyRaw = modelAssemblyBuilder.BuildToStream(false, true);
              docRaw1 = modelAssemblyBuilder.DocumentationRawStream;
              ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153896025));
            }
          }
          ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669579577));
          modelAssemblyBuilderHandler.ConfigurationModelAssemblyBuilt((IEnumerable<AbstractMetadata>) metadataList.Values);
          ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173702413));
          IList<(MemoryStream, IMetadata)> dataClassAssemblies = ConfigurationModelAssemblyBuilder.GetPublishedDataClassAssemblies();
          dataClassAssemblies.ForEach<(MemoryStream, IMetadata)>((Action<(MemoryStream, IMetadata)>) (d => tempMetadataService.AddMetadata(d.Item2)));
          // ISSUE: reference to a compiler-generated method
          Dictionary<Guid, ScriptModule> scriptModules = (allScriptModules != null ? allScriptModules.ToDictionary<ScriptModule, Guid>((System.Func<ScriptModule, Guid>) (sm => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.df6TupvZlLU1tpgSgUku((object) sm))) : (Dictionary<Guid, ScriptModule>) null) ?? new Dictionary<Guid, ScriptModule>();
          if (array1 != null)
            ((IEnumerable<ScriptModule>) array1).ForEach<ScriptModule>((Action<ScriptModule>) (sm =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    scriptModules[ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.DyvSPCvuRMFOV2TRSiyg((object) sm)] = sm;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
          if (scriptModules.Count > 0)
          {
            scriptCompiler = new ScriptCompiler(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306501154), (IEnumerable<IScriptModule>) scriptModules.Values);
            scriptCompiler.AddReference(cfgModelAssemblyRaw.AsNoClose());
            scriptCompiler.AddAnalyzers((DiagnosticAnalyzer) new ComponentsAnalyzer());
            foreach (KeyValuePair<Guid, AbstractMetadata> keyValuePair in metadataList)
            {
              if ((keyValuePair.Value is EntityMetadata entityMetadata ? entityMetadata.ViewModelMetadata : (DataClassMetadata) null) != null)
                scriptCompiler.AddSourceCode(ConfigurationModelAssemblyBuilder.GenerateScriptPartialCode((object) entityMetadata, (object) MetadataServiceContext.Service));
            }
            foreach ((MemoryStream, IMetadata) tuple in (IEnumerable<(MemoryStream, IMetadata)>) dataClassAssemblies)
              scriptCompiler.AddReference(tuple.Item1);
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            scriptCompiler.GenerateAssemblyInfoFile((System.Func<string, string>) (a => (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM((object) a.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217690993), (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-218496594 ^ -218445016)), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(1654249598 >> 2 ^ 413393429), (object) version), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309406834), (object) version)));
            ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137503722));
            ScriptCompileResult scriptCompileResult = scriptCompiler.Compile();
            if (!scriptCompileResult.Success)
            {
              scriptErrorsBuilder = new StringBuilder();
              scriptCompileResult.Messages.ForEach((Action<ScriptCompileMessage>) (m =>
              {
                int num = 1;
                while (true)
                {
                  NamedMetadata namedMetadata1;
                  NamedMetadata namedMetadata2;
                  switch (num)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.Y9BUmLvuGbiQXhods2fP((object) m) != Guid.Empty)
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_2;
                    case 2:
                      StringBuilder stringBuilder = scriptErrorsBuilder;
                      // ISSUE: reference to a compiler-generated method
                      object t = ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.hHgdNPvufsFDVauo5Cnq(-488881205 ^ -489030609);
                      object[] objArray = new object[3];
                      // ISSUE: reference to a compiler-generated method
                      object obj = namedMetadata1 == null ? (object) null : ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.UHyeV0vuQRqpuP7Hq9in((object) namedMetadata1);
                      objArray[0] = obj == null ? (object) m.ObjectUid.ToString() : obj;
                      objArray[1] = (object) m.Line;
                      // ISSUE: reference to a compiler-generated method
                      objArray[2] = ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.DLJhAtvuCZw1W3wWUaX7((object) m);
                      string str = EleWise.ELMA.SR.T((string) t, objArray);
                      stringBuilder.AppendLine(str);
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 3;
                      continue;
                    case 3:
                      goto label_14;
                    case 4:
                      AbstractMetadata abstractMetadata;
                      if (!metadataList.TryGetValue(m.ObjectUid, out abstractMetadata))
                      {
                        num = 5;
                        continue;
                      }
                      namedMetadata2 = abstractMetadata as NamedMetadata;
                      break;
                    case 5:
                      namedMetadata2 = (NamedMetadata) null;
                      break;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.IR8cUvvuECyLAU6MExjF((object) m) == ScriptCompileMessageType.Error)
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 3;
                        continue;
                      }
                      goto label_13;
                  }
                  namedMetadata1 = namedMetadata2;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 2;
                }
label_14:
                return;
label_13:
                return;
label_2:;
              }));
              EleWise.ELMA.Logging.Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133123363) + scriptErrorsBuilder.ToString()));
              if (!ignoreScriptsErrors)
                throw new MetadataPublishingException(scriptCompileResult);
            }
            memoryStream2 = scriptCompiler.AssemblyRawStream;
            memoryStream3 = scriptCompiler.DebugRawStream;
            ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021453305));
          }
          if (buildDynamicAssembly)
          {
            DynamicModelAssemblyBuilder modelAssemblyBuilder1 = new DynamicModelAssemblyBuilder(buildDeltaAssemblies ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323086814) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979249121));
            MemoryStream dynamicModelCurrentAssemblyRaw = (MemoryStream) null;
            if (buildDeltaAssemblies)
            {
              modelAssemblyBuilder1.BuildDeltaAssembly();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              IMetadata[] array3 = list1.OfType<EntityMetadata>().Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (m => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.KNKWcXvZrxK84cEFa4IO((object) m) == EntityMetadataType.InterfaceExtension)).Select<EntityMetadata, IMetadata>((System.Func<EntityMetadata, IMetadata>) (m => tempMetadataService.GetMetadata(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.nMaT2bvuvpHVBdv7tPbU((object) m), false))).SelectMany<IMetadata, IMetadata>((System.Func<IMetadata, IEnumerable<IMetadata>>) (m => ((tempMetadataService.GetMetadata(((EntityMetadata) m).ImplementationUid, true) is EntityMetadata metadata1 ? (IEnumerable<Guid>) metadata1.ImplementedExtensionUids : (IEnumerable<Guid>) null) ?? Enumerable.Empty<Guid>()).Where<Guid>((System.Func<Guid, bool>) (u => !metadataList.ContainsKey(u))).Select<Guid, IMetadata>((System.Func<Guid, IMetadata>) (u => tempMetadataService.GetMetadata(u, false))).Prepend<IMetadata>(m))).ToArray<IMetadata>();
              IMetadata[] array4 = list1.OfType<EntityMetadata>().Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (m => m.Filterable)).Select<EntityMetadata, IMetadata>((System.Func<EntityMetadata, IMetadata>) (m =>
              {
                int num = 1;
                IMetadata metadata2;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_0.KDbi74vu83mSjZRxjwFb((object) m) != EntityMetadataType.InterfaceExtension)
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_4;
                    case 2:
                      goto label_3;
                    default:
                      metadata2 = (IMetadata) m;
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 2 : 1;
                      continue;
                  }
                }
label_3:
                return metadata2;
label_4:
                return tempMetadataService.GetMetadata(m.BaseClassUid, false);
              })).ToArray<IMetadata>();
              if (array3.Length != 0 || array4.Length != 0)
                dynamicModelCurrentAssemblyRaw = EntityDynamicGenerator.RemoveDynamicTypes(ComponentManager.GetLoadedAssemblyRawAsStream(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669211061), false)), (IEnumerable<IMetadata>) array3, (IEnumerable<IMetadata>) array4);
              modelAssemblyBuilder1.RegisterMetadataList(((IEnumerable<IMetadata>) list1).Concat<IMetadata>((IEnumerable<IMetadata>) array3));
            }
            else
            {
              List<System.Type> list2 = DynamicModelAssemblyBuilder.GetEntityInterfaceTypes().Where<System.Type>((System.Func<System.Type, bool>) (t =>
              {
                int num = 6;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec.RhajJnvZ6JTS4Ws5ljsj(ConfigurationModelAssemblyBuilder.\u003C\u003Ec.jZWKcvvZjsHbutf2tF8m((object) t.Assembly), ConfigurationModelAssemblyBuilder.\u003C\u003Ec.V6D4aLvZ5f0gSXUtpDdB(825385222 ^ 825387816)))
                      {
                        num = 2;
                        continue;
                      }
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!ConfigurationModelAssemblyBuilder.\u003C\u003Ec.RhajJnvZ6JTS4Ws5ljsj(ConfigurationModelAssemblyBuilder.\u003C\u003Ec.jZWKcvvZjsHbutf2tF8m((object) t.Assembly), ConfigurationModelAssemblyBuilder.\u003C\u003Ec.V6D4aLvZ5f0gSXUtpDdB(712480695 ^ 712482345)))
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 3 : 3;
                        continue;
                      }
                      goto label_4;
                    case 3:
                    case 4:
                      goto label_5;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!ConfigurationModelAssemblyBuilder.\u003C\u003Ec.RhajJnvZ6JTS4Ws5ljsj((object) ComponentManager.GetAssemblyShortName(t.Assembly), ConfigurationModelAssemblyBuilder.\u003C\u003Ec.V6D4aLvZ5f0gSXUtpDdB(277947046 - -1479185048 ^ 1757134682)))
                      {
                        num = 4;
                        continue;
                      }
                      goto case 1;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      if (ConfigurationModelAssemblyBuilder.\u003C\u003Ec.kNLBPOvZgB6PPbDqyF3l((object) t.Assembly) != null)
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 5;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return ConfigurationModelAssemblyBuilder.\u003C\u003Ec.RhajJnvZ6JTS4Ws5ljsj(ConfigurationModelAssemblyBuilder.\u003C\u003Ec.jZWKcvvZjsHbutf2tF8m((object) t.Assembly), ConfigurationModelAssemblyBuilder.\u003C\u003Ec.V6D4aLvZ5f0gSXUtpDdB(--1333735954 ^ 1333738494));
label_5:
                return false;
              })).ToList<System.Type>();
              modelAssemblyBuilder1.RegisterTypes((IEnumerable<System.Type>) list2);
              modelAssemblyBuilder1.RegisterTypes(DynamicModelAssemblyBuilder.GetAutoImplementTypes());
              modelAssemblyBuilder1.RegisterMetadataList((IEnumerable<IMetadata>) metadataList.Values.AsEnumerable<AbstractMetadata>());
            }
            modelAssemblyBuilder1.RegisterConfigurationMetadataList((IEnumerable<IMetadata>) metadataList.Values);
            modelAssemblyBuilder1.RegisterDependentAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272622353), cfgModelAssemblyRaw);
            ICollection<EntityMetadata> implementationMetadataList = modelAssemblyBuilder1.GetImplementationMetadataList();
            if (implementationMetadataList.Count > 0)
            {
              foreach (EntityMetadata entityMetadata in (IEnumerable<EntityMetadata>) implementationMetadataList)
                tempMetadataService.AddMetadata((IMetadata) entityMetadata);
              if (buildDeltaAssemblies && dynamicModelCurrentAssemblyRaw == null)
                dynamicModelCurrentAssemblyRaw = ComponentManager.GetLoadedAssemblyRawAsStream(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3330508), false));
              MemoryStream stream = modelAssemblyBuilder1.BuildAssemblyToStream((Action<ModelAssemblyBuilder>) (b =>
              {
                int num1 = 5;
                while (true)
                {
                  int num2 = num1;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_2.RdGt1Kvuna1I9UqX32L8((object) b, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_2.eYMu8vvukbnr4KGTPfVD((object) cfgModelAssemblyRaw));
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_9;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_2.RdGt1Kvuna1I9UqX32L8((object) b, ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_2.eYMu8vvukbnr4KGTPfVD((object) dynamicModelCurrentAssemblyRaw));
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
                        continue;
                      case 4:
                        if (!buildDeltaAssemblies)
                          goto case 1;
                        else
                          goto label_6;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_2.jpqMPFvuT0XkAuMlTkfW((object) b);
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 4;
                        continue;
                      default:
                        ModelAssemblyBuilder modelAssemblyBuilder2 = b;
                        System.Func<string, string> func = closure_2;
                        System.Func<string, string> conversions = func == null ? (closure_2 = (System.Func<string, string>) (a =>
                        {
                          int num3 = 1;
                          string str;
                          bool? publicationEnable;
                          while (true)
                          {
                            switch (num3)
                            {
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                str = ((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.rEyRJRvuS7Jl7F7RSmHM((object) a.Replace((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-97972138 ^ -97745952), (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(~-306453669 ^ 306452106)), ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(-882126494 ^ -881965720), (object) version)).Replace((string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(322893104 - -1992822529 ^ -1979543549), version);
                                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                                continue;
                              case 2:
                                goto label_2;
                              case 3:
                                // ISSUE: reference to a compiler-generated method
                                str += (string) ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_1.vRUw7VvuVr1uD48yKV11(381945751 ^ 1158627804 ^ 1406074787);
                                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 2;
                                continue;
                              case 4:
                                if (publicationEnable.Value)
                                {
                                  num3 = 3;
                                  continue;
                                }
                                goto label_2;
                              default:
                                publicationEnable = ReflectionType.DynamicPublicationEnable;
                                num3 = 4;
                                continue;
                            }
                          }
label_2:
                          return str;
                        })) : func;
                        modelAssemblyBuilder2.GenerateAssemblyInfo(conversions);
                        num2 = 2;
                        continue;
                    }
                  }
label_6:
                  num1 = 3;
                }
label_9:;
              }));
              if (buildDeltaAssemblies)
              {
                ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515135947));
                memoryStream4 = stream;
                memoryStream5 = ConfigurationModelAssemblyBuilder.Merge((object) dynamicModelCurrentAssemblyRaw, (object) memoryStream4, (IDictionary<string, string>) new Dictionary<string, string>()
                {
                  [z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837664283)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521267676)
                });
                docRaw2 = ConfigurationModelAssemblyBuilder.MergeDocumentation((object) docRaw2, (object) modelAssemblyBuilder1.DocumentationRawStream);
                ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993391107));
              }
              else
              {
                memoryStream5 = stream;
                docRaw2 = modelAssemblyBuilder1.DocumentationRawStream;
              }
            }
            if (buildDeltaAssemblies && source1 != null)
            {
              // ISSUE: reference to a compiler-generated method
              HashSet<Guid> exists = implementationMetadataList.Select<EntityMetadata, Guid>((System.Func<EntityMetadata, Guid>) (m => ConfigurationModelAssemblyBuilder.\u003C\u003Ec.KM8jh7vZ9QqM6xvNPojE((object) m))).ToHashSet<Guid>();
              // ISSUE: reference to a compiler-generated method
              implementationMetadataList.AddRange<EntityMetadata>(((IEnumerable<AbstractMetadata>) source1).Where<AbstractMetadata>((System.Func<AbstractMetadata, bool>) (m => !exists.Contains(ConfigurationModelAssemblyBuilder.\u003C\u003Ec__DisplayClass9_3.zS7uYPvu1D1iLpgf3cE8((object) m)))).OfType<EntityMetadata>());
            }
            ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218755086));
            modelAssemblyBuilderHandler.DynamicModelAssemblyBuilt((IEnumerable<EntityMetadata>) implementationMetadataList);
            ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133123213));
            source3 = implementationMetadataList.Cast<AbstractMetadata>();
          }
          if (buildClientScripts)
          {
            ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837882295));
            modelAssemblyBuilderHandler.AfterAll((IEnumerable<AbstractMetadata>) metadataList.Values, (IEnumerable<ScriptModule>) array1, (IEnumerable<ScriptModule>) array2);
            ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153897131));
          }
        }
        ConfigurationModelAssemblyBuilder.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45070753));
        AssemblyModelsMetadata configurationAssembly = loadAssemblyMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867824088), AssemblyModelsMetadataStatus.Published);
        if (configurationAssembly == null)
          configurationAssembly = new AssemblyModelsMetadata()
          {
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583742832),
            Status = AssemblyModelsMetadataStatus.Published
          };
        MemoryStream cfgModelAssemblyRaw;
        configurationAssembly.AssemblyRawStream = cfgModelAssemblyRaw;
        configurationAssembly.DocumentationRawStream = docRaw1;
        configurationAssembly.SetMetadata(metadataList.Values.ToArray<AbstractMetadata>());
        saveAssemblyMetadata(configurationAssembly);
        AssemblyModelsMetadata scriptsAssembly = (AssemblyModelsMetadata) null;
        if (memoryStream2 != null || scriptErrorsBuilder != null)
        {
          scriptsAssembly = loadAssemblyMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210740923), AssemblyModelsMetadataStatus.Published);
          if (scriptsAssembly == null)
            scriptsAssembly = new AssemblyModelsMetadata()
            {
              Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574279894),
              Status = AssemblyModelsMetadataStatus.Published
            };
          scriptsAssembly.AssemblyRawStream = memoryStream2;
          scriptsAssembly.DebugRawStream = memoryStream3;
          if (scriptErrorsBuilder != null)
          {
            scriptsAssembly.DocumentationRawStream = MemoryHelper.GetMemoryStream();
            using (StreamWriter streamWriter = new StreamWriter((Stream) scriptsAssembly.DocumentationRawStream.AsNoClose(), Encoding.UTF8))
              streamWriter.Write(scriptErrorsBuilder.ToString());
            scriptsAssembly.DocumentationRawStream.Seek(0L, SeekOrigin.Begin);
          }
          saveAssemblyMetadata(scriptsAssembly);
        }
        AssemblyModelsMetadata dynamicAssembly = (AssemblyModelsMetadata) null;
        if (buildDynamicAssembly && memoryStream5 != null)
        {
          dynamicAssembly = loadAssemblyMetadata(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867381725), AssemblyModelsMetadataStatus.Prepared);
          if (dynamicAssembly == null)
            dynamicAssembly = new AssemblyModelsMetadata()
            {
              Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16755511),
              Status = AssemblyModelsMetadataStatus.Prepared
            };
          dynamicAssembly.AssemblyRawStream = memoryStream5;
          dynamicAssembly.DocumentationRawStream = docRaw2;
          dynamicAssembly.SetMetadata(source3.ToArray<AbstractMetadata>());
          saveAssemblyMetadata(dynamicAssembly);
        }
        return new MetadataAssemblyPublishResult(configurationAssembly, scriptsAssembly, dynamicAssembly, memoryStream1, memoryStream4);
      }
      finally
      {
        scriptCompiler?.Dispose();
      }
    }

    private static string GenerateScriptPartialCode(object entityMetadata, object metadataService)
    {
      int num = 1;
      ICodeGenerator codeGenerator;
      while (true)
      {
        switch (num)
        {
          case 1:
            codeGenerator = (ICodeGenerator) new EntityScriptGenerator((IMetadataService) metadataService);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            ConfigurationModelAssemblyBuilder.yP4khUh2DRwacX57VI28((object) codeGenerator.GenerationParams, ConfigurationModelAssemblyBuilder.AnGQLHh2aMIUqiRdJAS3((object) ((NamedMetadata) entityMetadata).Name, ConfigurationModelAssemblyBuilder.jd6noph2kB36YcYQqbQu(-812025778 ^ -812097280)));
            num = 4;
            continue;
          case 4:
            ConfigurationModelAssemblyBuilder.PFy9nQh24jELDSd9gyk9(ConfigurationModelAssemblyBuilder.cHAlrMh2txNkGEgR2n3t((object) codeGenerator), ConfigurationModelAssemblyBuilder.x0B2qeh2w06sf1lPHPeL(entityMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
            continue;
          default:
            ConfigurationModelAssemblyBuilder.HgHcF6h2puB5DUg1ADdV((object) codeGenerator, entityMetadata);
            num = 3;
            continue;
        }
      }
label_2:
      return Encoding.UTF8.GetString((byte[]) ConfigurationModelAssemblyBuilder.T63F4ph2HOoRnX179bRg(ConfigurationModelAssemblyBuilder.Tiot7Fh26U4eGw3FlTDi((object) codeGenerator)));
    }

    /// <summary>Получить список опубликованных датаклассов</summary>
    /// <returns>Список{Поток, Метаданные}</returns>
    internal static IList<(MemoryStream, IMetadata)> GetPublishedDataClassAssemblies()
    {
      List<(MemoryStream, IMetadata)> dataClassAssemblies = new List<(MemoryStream, IMetadata)>();
      IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
      if (service == null)
        return (IList<(MemoryStream, IMetadata)>) dataClassAssemblies;
      ITransformationProvider transformationProvider = service.TransformationProvider;
      if (transformationProvider == null)
        return (IList<(MemoryStream, IMetadata)>) dataClassAssemblies;
      Dialect dialect = transformationProvider.Dialect;
      string table = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824491957));
      if (!ConfigurationModelAssemblyBuilder.existDataClassTable)
      {
        ConfigurationModelAssemblyBuilder.existDataClassTable = transformationProvider.TableExists(table);
        if (!ConfigurationModelAssemblyBuilder.existDataClassTable)
          return (IList<(MemoryStream, IMetadata)>) dataClassAssemblies;
      }
      string columnName1 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583699980));
      string str1 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874047639));
      string str2 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195734391));
      string str3 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426127257));
      string str4 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106365602));
      string sql1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138236800) + columnName1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583558176) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542776645) + table + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306661276) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811982034) + str3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487201308) + str4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951430530) + columnName1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317583002);
      string columnName2 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852947708));
      string str5 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199901391));
      string str6 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957694926));
      string str7 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822773852));
      string str8 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583777878));
      string str9 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333611656));
      string sql2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108057652) + columnName2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539312547) + str5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011901401) + str6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813548589) + str7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283591417) + str8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319509116) + str9 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1756948842) + columnName2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487201328);
      using (IDataReader dataReader = transformationProvider.ExecuteQuery(sql1, (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
          dataClassAssemblies.Add((dataReader.GetStream(columnName1), ConfigurationModelAssemblyBuilder.xmlObjSerType.NullSafeGet((DbDataReader) dataReader, new string[1]
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669341993)
          }, (ISessionImplementor) null, (object) null) as IMetadata));
      }
      using (IDataReader dataReader = transformationProvider.ExecuteQuery(sql2, (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
          dataClassAssemblies.Add((dataReader.GetStream(columnName2), ConfigurationModelAssemblyBuilder.xmlObjSerType.NullSafeGet((DbDataReader) dataReader, new string[1]
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44848575)
          }, (ISessionImplementor) null, (object) null) as IMetadata));
      }
      return (IList<(MemoryStream, IMetadata)>) dataClassAssemblies;
    }

    /// <summary>
    /// Версия сборки ConfigurationModel/DynamicModel, с которой запущена система
    /// </summary>
    internal static Version Version
    {
      get
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            Version version;
            switch (num2)
            {
              case 1:
                ConfigurationModelAssemblyBuilder.versionIniting = true;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                continue;
              case 2:
              case 5:
                if (ConfigurationModelAssemblyBuilder.versionIniting)
                {
                  num2 = 4;
                  continue;
                }
                goto label_9;
              case 3:
                version = (Version) null;
                break;
              case 4:
                goto label_8;
              case 6:
                if (ConfigurationModelAssemblyBuilder.versionIniting)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 2;
                  continue;
                }
                goto case 1;
              case 7:
                if (!ConfigurationModelAssemblyBuilder.CfvnDAh2A405sHcoT2M3((object) ConfigurationModelAssemblyBuilder.version, (object) null))
                  goto case 2;
                else
                  goto label_7;
              case 8:
                ConfigurationModelAssemblyBuilder.versionIniting = false;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 5 : 1;
                continue;
              default:
                object obj = ConfigurationModelAssemblyBuilder.wOxsOKh27UeOG9WlKr3l(ConfigurationModelAssemblyBuilder.jd6noph2kB36YcYQqbQu(-35995181 ^ -35992649), false);
                if (obj == null)
                {
                  num2 = 3;
                  continue;
                }
                version = ((AssemblyName) ConfigurationModelAssemblyBuilder.o3wc2Rh2xyAJ3bXsShIj(obj)).Version;
                break;
            }
            ConfigurationModelAssemblyBuilder.version = version;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 8 : 6;
          }
label_7:
          num1 = 6;
        }
label_8:
        return (Version) null;
label_9:
        return ConfigurationModelAssemblyBuilder.version;
      }
    }

    /// <summary>Версия текущей сборки ConfigurationModel/DynamicModel</summary>
    internal static Version CurrentVersion { get; private set; }

    /// <summary>
    /// Версия для следующей сборки ConfigurationModel/DynamicModel
    /// </summary>
    internal static Version NextVersion { get; private set; }

    /// <summary>Извлечь версию сборки</summary>
    /// <param name="assemblyRaw">Raw сборки</param>
    internal static Version ReadVersion(MemoryStream assemblyRaw)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (assemblyRaw.Length <= 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 4 : 2;
              continue;
            }
            goto label_2;
          case 2:
          case 4:
            goto label_3;
          case 3:
            if (assemblyRaw == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_2:
      return (Version) ConfigurationModelAssemblyBuilder.qh3l81h2mgVKUx0JrORJ((object) ((AssemblyDefinition) ConfigurationModelAssemblyBuilder.qnmfWLh20qMsqCMNONsZ((object) assemblyRaw)).Name);
label_3:
      return (Version) null;
    }

    /// <summary>
    /// Инициализировать текущую собранную версию ConfigurationModel для корректного вычисления <see cref="P:EleWise.ELMA.Model.CodeGeneration.ConfigurationModelAssemblyBuilder.NextVersion" />
    /// </summary>
    /// <param name="assemblyRaw">Raw сборки ConfigurationModel или null</param>
    internal static void InitVersion(MemoryStream assemblyRaw)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ConfigurationModelAssemblyBuilder.InitVersion(ConfigurationModelAssemblyBuilder.wsgTxih2yfHXQuBbWlxn((object) assemblyRaw));
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

    /// <summary>
    /// Инициализировать текущую собранную версию ConfigurationModel для корректного вычисления <see cref="P:EleWise.ELMA.Model.CodeGeneration.ConfigurationModelAssemblyBuilder.NextVersion" />
    /// </summary>
    /// <param name="assembly">Сборка ConfigurationModel</param>
    internal static void InitVersion(Assembly assembly)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ConfigurationModelAssemblyBuilder.uqcxUPh2Jw797M2uhUDm(ConfigurationModelAssemblyBuilder.Gp76QJh2MRq2pIGdNnns((object) assembly.GetName()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Увеличить версию для следующей сборки</summary>
    internal static void IncrementNextVersion()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ConfigurationModelAssemblyBuilder.D6sUsvh2jy0igJREeyFf((object) new Version(ConfigurationModelAssemblyBuilder.LSqGloh2l1QYsqitYmo3(ConfigurationModelAssemblyBuilder.IEbE0Oh298sSABOsuw0M()), ConfigurationModelAssemblyBuilder.qdJ9MCh2rrDZg019PWgX(ConfigurationModelAssemblyBuilder.IEbE0Oh298sSABOsuw0M()), ConfigurationModelAssemblyBuilder.PFPbEfh2geGxqOZYorpG((object) ConfigurationModelAssemblyBuilder.NextVersion), ConfigurationModelAssemblyBuilder.mSKm11h2538C3hHdQIs1(ConfigurationModelAssemblyBuilder.IEbE0Oh298sSABOsuw0M()) + 1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 2:
            ConfigurationModelAssemblyBuilder.ECTRGQh2dQHH484xZMZx(ConfigurationModelAssemblyBuilder.IEbE0Oh298sSABOsuw0M());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private static void InitVersion(object oldVersion)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Version version;
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              if (ConfigurationModelAssemblyBuilder.qdJ9MCh2rrDZg019PWgX((object) version) == ConfigurationModelAssemblyBuilder.qdJ9MCh2rrDZg019PWgX(oldVersion))
              {
                num2 = 5;
                continue;
              }
              break;
            case 2:
              if (ConfigurationModelAssemblyBuilder.LSqGloh2l1QYsqitYmo3((object) version) == ConfigurationModelAssemblyBuilder.LSqGloh2l1QYsqitYmo3(oldVersion))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              if (!ConfigurationModelAssemblyBuilder.Q44bojh2Yn5LXCt6yl0s(oldVersion, (object) null))
                break;
              goto label_13;
            case 4:
              version = VersionInfo.GetVersion<EleWise.ELMA.SR>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 1;
              continue;
            case 5:
              ConfigurationModelAssemblyBuilder.D6sUsvh2jy0igJREeyFf((object) new Version(version.Major, ConfigurationModelAssemblyBuilder.qdJ9MCh2rrDZg019PWgX((object) version), ConfigurationModelAssemblyBuilder.nJ0bPlh2Lxel915anPTf(0, ConfigurationModelAssemblyBuilder.PFPbEfh2geGxqOZYorpG(oldVersion)) + 1, 0));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_4;
            default:
              goto label_14;
          }
          ConfigurationModelAssemblyBuilder.NextVersion = new Version(version.Major, ConfigurationModelAssemblyBuilder.qdJ9MCh2rrDZg019PWgX((object) version), 0, 0);
          num2 = 6;
        }
label_13:
        num1 = 2;
      }
label_3:
      return;
label_4:
      return;
label_14:;
    }

    static ConfigurationModelAssemblyBuilder()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          case 2:
            ConfigurationModelAssemblyBuilder.xmlObjSerType = new XmlObjectSerializableType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            ConfigurationModelAssemblyBuilder.isConfigurationModelBuild = new ContextVars.Local<bool>();
            num = 3;
            continue;
          default:
            ConfigurationModelAssemblyBuilder.publishLogger = EleWise.ELMA.Logging.Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397333272));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object jd6noph2kB36YcYQqbQu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object UYLVyQh2n75Q2HxQnL6d([In] object obj0) => (object) ((Stream) obj0).ReadAllBytes();

    internal static object kykDiZh2O5maKboJtRgv([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static object Iebw0ph22FNJPZDHleG3() => (object) Encoding.UTF8;

    internal static object uc7yrfh2e48nCOZe4IFZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((Regex) obj0).Replace((string) obj1, (MatchEvaluator) obj2);

    internal static int EhiU2Hh2Pj2Q9Enl11PH([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static int chqQrEh21U1nABbtfjsy([In] object obj0, [In] object obj1, [In] int obj2) => ((string) obj0).LastIndexOf((string) obj1, obj2);

    internal static object cirkUFh2NqtqjCVoZ4nM([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static object UMBrZfh234A42cm4EViJ([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static bool Qjrox2h2X5aUIwDWVH7w() => ConfigurationModelAssemblyBuilder.DIZ4SUh2KcTBW3s8pYim == null;

    internal static ConfigurationModelAssemblyBuilder AX3fWyh2TUU6oWFWXoTu() => ConfigurationModelAssemblyBuilder.DIZ4SUh2KcTBW3s8pYim;

    internal static void HgHcF6h2puB5DUg1ADdV([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static object AnGQLHh2aMIUqiRdJAS3([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void yP4khUh2DRwacX57VI28([In] object obj0, [In] object obj1) => ((GenerationParams) obj0).FileName = (string) obj1;

    internal static object cHAlrMh2txNkGEgR2n3t([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerationParams;

    internal static object x0B2qeh2w06sf1lPHPeL([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static void PFy9nQh24jELDSd9gyk9([In] object obj0, [In] object obj1) => ((GenerationParams) obj0).Namespace = (string) obj1;

    internal static object Tiot7Fh26U4eGw3FlTDi([In] object obj0) => (object) ((ICodeGenerator) obj0).GenerateMainFile();

    internal static object T63F4ph2HOoRnX179bRg([In] object obj0) => (object) ((GeneratedFileInfo) obj0).Data;

    internal static bool CfvnDAh2A405sHcoT2M3([In] object obj0, [In] object obj1) => (Version) obj0 == (Version) obj1;

    internal static object wOxsOKh27UeOG9WlKr3l([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static object o3wc2Rh2xyAJ3bXsShIj([In] object obj0) => (object) ((Assembly) obj0).GetName();

    internal static object qnmfWLh20qMsqCMNONsZ([In] object obj0) => (object) AssemblyDefinition.ReadAssembly((Stream) obj0);

    internal static object qh3l81h2mgVKUx0JrORJ([In] object obj0) => (object) ((AssemblyNameReference) obj0).Version;

    internal static object wsgTxih2yfHXQuBbWlxn([In] object obj0) => (object) ConfigurationModelAssemblyBuilder.ReadVersion((MemoryStream) obj0);

    internal static object Gp76QJh2MRq2pIGdNnns([In] object obj0) => (object) ((AssemblyName) obj0).Version;

    internal static void uqcxUPh2Jw797M2uhUDm([In] object obj0) => ConfigurationModelAssemblyBuilder.InitVersion(obj0);

    internal static object IEbE0Oh298sSABOsuw0M() => (object) ConfigurationModelAssemblyBuilder.NextVersion;

    internal static void ECTRGQh2dQHH484xZMZx([In] object obj0) => ConfigurationModelAssemblyBuilder.CurrentVersion = (Version) obj0;

    internal static int LSqGloh2l1QYsqitYmo3([In] object obj0) => ((Version) obj0).Major;

    internal static int qdJ9MCh2rrDZg019PWgX([In] object obj0) => ((Version) obj0).Minor;

    internal static int PFPbEfh2geGxqOZYorpG([In] object obj0) => ((Version) obj0).Build;

    internal static int mSKm11h2538C3hHdQIs1([In] object obj0) => ((Version) obj0).Revision;

    internal static void D6sUsvh2jy0igJREeyFf([In] object obj0) => ConfigurationModelAssemblyBuilder.NextVersion = (Version) obj0;

    internal static bool Q44bojh2Yn5LXCt6yl0s([In] object obj0, [In] object obj1) => (Version) obj0 != (Version) obj1;

    internal static int nJ0bPlh2Lxel915anPTf([In] int obj0, [In] int obj1) => Math.Max(obj0, obj1);

    private class ParameterDefinitionComparer : IEqualityComparer<ParameterDefinition>
    {
      internal static object Lqpmcmv8QKAQvqpmtKbA;

      public static IEqualityComparer<ParameterDefinition> Instance { get; }

      private ParameterDefinitionComparer()
      {
        ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.zEeg4fv88uJkL6Ey1A42();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public bool Equals(ParameterDefinition x, ParameterDefinition y) => ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.dUgDPMv8IYWZPWT28qgt(ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.KU4yS6v8uFvSonWSKJ74(ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.tmRxT2v8ZSjgpNoxdhNi((object) x)), ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.KU4yS6v8uFvSonWSKJ74(ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.tmRxT2v8ZSjgpNoxdhNi((object) y)));

      public int GetHashCode(ParameterDefinition obj) => ((MemberReference) ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.tmRxT2v8ZSjgpNoxdhNi((object) obj)).FullName.GetHashCode();

      static ParameterDefinitionComparer()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.Instance = (IEqualityComparer<ParameterDefinition>) new ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            case 2:
              ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.zEeg4fv88uJkL6Ey1A42();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static void zEeg4fv88uJkL6Ey1A42() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool QOBYlYv8CPhhettUPemq() => ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.Lqpmcmv8QKAQvqpmtKbA == null;

      internal static ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer Cnydmfv8vlJMKjiWnXkL() => (ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer) ConfigurationModelAssemblyBuilder.ParameterDefinitionComparer.Lqpmcmv8QKAQvqpmtKbA;

      internal static object tmRxT2v8ZSjgpNoxdhNi([In] object obj0) => (object) ((ParameterReference) obj0).ParameterType;

      internal static object KU4yS6v8uFvSonWSKJ74([In] object obj0) => (object) ((MemberReference) obj0).FullName;

      internal static bool dUgDPMv8IYWZPWT28qgt([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
    }
  }
}
