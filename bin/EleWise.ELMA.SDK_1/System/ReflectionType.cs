// Decompiled with JetBrains decompiler
// Type: System.ReflectionType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System
{
  /// <summary>Хелпер для получения Type по имени</summary>
  public static class ReflectionType
  {
    private static IDynamicPublicationService dynamicPublicationService;
    private static IDictionary<Assembly, IDictionary<string, MemoryStream>> manifestResources;
    private static readonly IDictionary<string, Type> DynamicTypes;
    private static readonly IDictionary<string, Type> DynamicTypesIgnoreCase;
    private static Assembly configuraionModelAssembly;
    private static Assembly dynamicModelAssembly;
    internal static ReflectionType n1v4IBosNT6s4EXUbrm;

    /// <summary>
    /// Gets the System.Type with the specified name, performing a case-sensitive search.
    /// </summary>
    /// <param name="typeName">
    /// The assembly-qualified name of the type to get. See System.Type.AssemblyQualifiedName.
    /// If the type is in the currently executing assembly or in Mscorlib.dll, it is
    /// sufficient to supply the type name qualified by its namespace.
    /// </param>
    /// <returns>The type with the specified name, if found; otherwise, null.</returns>
    public static Type GetType(string typeName) => ReflectionType.GetType(typeName, false, false);

    /// <summary>
    /// Gets the System.Type with the specified name, performing a case-sensitive search
    /// and specifying whether to throw an exception if the type is not found.
    /// </summary>
    /// <param name="typeName">
    /// The assembly-qualified name of the type to get. See System.Type.AssemblyQualifiedName.
    /// If the type is in the currently executing assembly or in Mscorlib.dll, it is
    /// sufficient to supply the type name qualified by its namespace.
    /// </param>
    /// <param name="throwOnError">
    /// true to throw an exception if the type cannot be found; false to return null.
    /// Specifying false also suppresses some other exception conditions, but not all
    /// of them. See the Exceptions section.
    /// </param>
    /// <returns>
    /// The type with the specified name. If the type is not found, the throwOnError
    /// parameter specifies whether null is returned or an exception is thrown. In some
    /// cases, an exception is thrown regardless of the value of throwOnError. See the
    /// Exceptions section.
    /// </returns>
    public static Type GetType(string typeName, bool throwOnError) => ReflectionType.GetType(typeName, throwOnError, false);

    /// <summary>
    /// Gets the System.Type with the specified name, specifying whether to throw an
    /// exception if the type is not found and whether to perform a case-sensitive search.
    /// </summary>
    /// <param name="typeName">
    /// The assembly-qualified name of the type to get. See System.Type.AssemblyQualifiedName.
    /// If the type is in the currently executing assembly or in Mscorlib.dll, it is
    /// sufficient to supply the type name qualified by its namespace.
    /// </param>
    /// <param name="throwOnError">
    /// true to throw an exception if the type cannot be found; false to return null.
    /// Specifying false also suppresses some other exception conditions, but not all
    /// of them. See the Exceptions section.
    /// </param>
    /// <param name="ignoreCase">true to perform a case-insensitive search for typeName, false to perform a case-sensitive search for typeName.</param>
    /// <returns>
    /// The type with the specified name. If the type is not found, the throwOnError
    /// parameter specifies whether null is returned or an exception is thrown. In some
    /// cases, an exception is thrown regardless of the value of throwOnError. See the
    /// Exceptions section.
    /// </returns>
    public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
    {
      int num = 2;
      bool throwOnError1;
      while (true)
      {
        switch (num)
        {
          case 1:
            throwOnError1 = throwOnError;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return ReflectionType.GetType(typeName, (Func<AssemblyName, Assembly>) (asmName => ReflectionType.AssemblyResolver((object) asmName, throwOnError1)), new Func<Assembly, string, bool, Type>(ReflectionType.TypeResolver), throwOnError1, ignoreCase);
    }

    /// <summary>
    /// Gets the type with the specified name, optionally providing custom methods to
    /// resolve the assembly and the type.
    /// </summary>
    /// <param name="typeName">
    /// The name of the type to get. If the typeResolver parameter is provided, the type
    /// name can be any string that typeResolver is capable of resolving. If the assemblyResolver
    /// parameter is provided or if standard type resolution is used, typeName must be
    /// an assembly-qualified name (see System.Type.AssemblyQualifiedName), unless the
    /// type is in the currently executing assembly or in Mscorlib.dll, in which case
    /// it is sufficient to supply the type name qualified by its namespace.
    /// </param>
    /// <param name="assemblyResolver">
    /// A method that locates and returns the assembly that is specified in typeName.
    /// The assembly name is passed to assemblyResolver as an System.Reflection.AssemblyName
    /// object. If typeName does not contain the name of an assembly, assemblyResolver
    /// is not called. If assemblyResolver is not supplied, standard assembly resolution
    /// is performed. Caution Do not pass methods from unknown or untrusted callers.
    /// Doing so could result in elevation of privilege for malicious code. Use only
    /// methods that you provide or that you are familiar with.
    /// </param>
    /// <param name="typeResolver">
    /// A method that locates and returns the type that is specified by typeName from
    /// the assembly that is returned by assemblyResolver or by standard assembly resolution.
    /// If no assembly is provided, the typeResolver method can provide one. The method
    /// also takes a parameter that specifies whether to perform a case-insensitive search;
    /// false is passed to that parameter. Caution Do not pass methods from unknown or
    /// untrusted callers.
    /// </param>
    /// <returns>The type with the specified name, or null if the type is not found.</returns>
    public static Type GetType(
      string typeName,
      Func<AssemblyName, Assembly> assemblyResolver,
      Func<Assembly, string, bool, Type> typeResolver)
    {
      return ReflectionType.GetType(typeName, assemblyResolver, typeResolver, false, false);
    }

    /// <summary>
    /// Gets the type with the specified name, specifying whether to throw an exception
    /// if the type is not found, and optionally providing custom methods to resolve
    /// the assembly and the type.
    /// </summary>
    /// <param name="typeName">
    /// The name of the type to get. If the typeResolver parameter is provided, the type
    /// name can be any string that typeResolver is capable of resolving. If the assemblyResolver
    /// parameter is provided or if standard type resolution is used, typeName must be
    /// an assembly-qualified name (see System.Type.AssemblyQualifiedName), unless the
    /// type is in the currently executing assembly or in Mscorlib.dll, in which case
    /// it is sufficient to supply the type name qualified by its namespace.
    /// </param>
    /// <param name="assemblyResolver">
    /// A method that locates and returns the assembly that is specified in typeName.
    /// The assembly name is passed to assemblyResolver as an System.Reflection.AssemblyName
    /// object. If typeName does not contain the name of an assembly, assemblyResolver
    /// is not called. If assemblyResolver is not supplied, standard assembly resolution
    /// is performed. Caution Do not pass methods from unknown or untrusted callers.
    /// Doing so could result in elevation of privilege for malicious code. Use only
    /// methods that you provide or that you are familiar with.
    /// </param>
    /// <param name="typeResolver">
    /// A method that locates and returns the type that is specified by typeName from
    /// the assembly that is returned by assemblyResolver or by standard assembly resolution.
    /// If no assembly is provided, the method can provide one. The method also takes
    /// a parameter that specifies whether to perform a case-insensitive search; false
    /// is passed to that parameter. Caution Do not pass methods from unknown or untrusted
    /// callers.
    /// </param>
    /// <param name="throwOnError">
    /// true to throw an exception if the type cannot be found; false to return null.
    /// Specifying false also suppresses some other exception conditions, but not all
    /// of them. See the Exceptions section.
    /// </param>
    /// <returns>
    /// The type with the specified name. If the type is not found, the throwOnError
    /// parameter specifies whether null is returned or an exception is thrown. In some
    /// cases, an exception is thrown regardless of the value of throwOnError. See the
    /// Exceptions section.
    /// </returns>
    public static Type GetType(
      string typeName,
      Func<AssemblyName, Assembly> assemblyResolver,
      Func<Assembly, string, bool, Type> typeResolver,
      bool throwOnError)
    {
      return ReflectionType.GetType(typeName, assemblyResolver, typeResolver, throwOnError, false);
    }

    /// <summary>
    /// Gets the type with the specified name, specifying whether to perform a case-sensitive
    /// search and whether to throw an exception if the type is not found, and optionally
    /// providing custom methods to resolve the assembly and the type.
    /// </summary>
    /// <param name="typeName">
    /// The name of the type to get. If the typeResolver parameter is provided, the type
    /// name can be any string that typeResolver is capable of resolving. If the assemblyResolver
    /// parameter is provided or if standard type resolution is used, typeName must be
    /// an assembly-qualified name (see System.Type.AssemblyQualifiedName), unless the
    /// type is in the currently executing assembly or in Mscorlib.dll, in which case
    /// it is sufficient to supply the type name qualified by its namespace.
    /// </param>
    /// <param name="assemblyResolver">
    /// A method that locates and returns the assembly that is specified in typeName.
    /// The assembly name is passed to assemblyResolver as an System.Reflection.AssemblyName
    /// object. If typeName does not contain the name of an assembly, assemblyResolver
    /// is not called. If assemblyResolver is not supplied, standard assembly resolution
    /// is performed. Caution Do not pass methods from unknown or untrusted callers.
    /// Doing so could result in elevation of privilege for malicious code. Use only
    /// methods that you provide or that you are familiar with.
    /// </param>
    /// <param name="typeResolver">
    /// A method that locates and returns the type that is specified by typeName from
    /// the assembly that is returned by assemblyResolver or by standard assembly resolution.
    /// If no assembly is provided, the method can provide one. The method also takes
    /// a parameter that specifies whether to perform a case-insensitive search; the
    /// value of ignoreCase is passed to that parameter. Caution Do not pass methods
    /// from unknown or untrusted callers.
    /// </param>
    /// <param name="throwOnError">
    /// true to throw an exception if the type cannot be found; false to return null.
    /// Specifying false also suppresses some other exception conditions, but not all
    /// of them. See the Exceptions section.
    /// </param>
    /// <param name="ignoreCase">true to perform a case-insensitive search for typeName, false to perform a case-sensitive search for typeName.</param>
    /// <returns>
    /// The type with the specified name. If the type is not found, the throwOnError
    /// parameter specifies whether null is returned or an exception is thrown. In some
    /// cases, an exception is thrown regardless of the value of throwOnError. See the
    /// Exceptions section.
    /// </returns>
    public static Type GetType(
      string typeName,
      Func<AssemblyName, Assembly> assemblyResolver,
      Func<Assembly, string, bool, Type> typeResolver,
      bool throwOnError,
      bool ignoreCase)
    {
      Assembly assembly = (Assembly) null;
      Type type1 = Type.GetType(typeName, (Func<AssemblyName, Assembly>) (asmName => ReflectionType.AssemblyResolver((object) asmName, assemblyResolver)), (Func<Assembly, string, bool, Type>) ((asm, type, ignore) =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              assembly = asm;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return ReflectionType.TypeResolver((object) asm, (object) type, ignore, typeResolver);
      }), throwOnError, ignoreCase);
      if (type1 == (Type) null && typeName.Contains<char>('+') && (assembly == (Assembly) null || assembly == ReflectionType.configuraionModelAssembly || assembly == ReflectionType.dynamicModelAssembly))
      {
        int num = typeName.IndexOf(',');
        (ignoreCase ? ReflectionType.DynamicTypesIgnoreCase : ReflectionType.DynamicTypes).TryGetValue(ReflectionType.GetTypeName(num > 0 ? (object) typeName.Remove(typeName.IndexOf(',')).Trim() : (object) typeName.Trim()), out type1);
      }
      return type1;
    }

    /// <summary>
    /// Gets the System.Type object with the specified name in the assembly instance.
    /// </summary>
    /// <param name="assembly">Assembly</param>
    /// <param name="name">The full name of the type.</param>
    /// <returns>An object that represents the specified class, or null if the class is not found.</returns>
    public static Type GetReflectionType(this Assembly assembly, string name) => assembly.GetReflectionType(name, false, false);

    /// <summary>
    /// Gets the System.Type object with the specified name in the assembly instance
    /// and optionally throws an exception if the type is not found.
    /// </summary>
    /// <param name="assembly">Assembly</param>
    /// <param name="name">The full name of the type.</param>
    /// <param name="throwOnError">true to throw an exception if the type is not found; false to return null.</param>
    /// <returns>An object that represents the specified class.</returns>
    public static Type GetReflectionType(this Assembly assembly, string name, bool throwOnError) => ReflectionType.d8lBdobFlgoo8NrdMON((object) assembly, (object) name, throwOnError, false);

    /// <summary>
    /// Gets the System.Type object with the specified name in the assembly instance,
    /// with the options of ignoring the case, and of throwing an exception if the type
    /// is not found.
    /// </summary>
    /// <param name="assembly">Assembly</param>
    /// <param name="name">The full name of the type.</param>
    /// <param name="throwOnError">true to throw an exception if the type is not found; false to return null.</param>
    /// <param name="ignoreCase">true to ignore the case of the type name; otherwise, false.</param>
    /// <returns>An object that represents the specified class.</returns>
    public static Type GetReflectionType(
      this Assembly assembly,
      string name,
      bool throwOnError,
      bool ignoreCase)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (throwOnError)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return ReflectionType.TypeResolver((object) assembly, (object) name, ignoreCase, new Func<Assembly, string, bool, Type>(ReflectionType.TypeResolver));
label_3:
      return ReflectionType.TypeResolver((object) assembly, (object) name, ignoreCase, new Func<Assembly, string, bool, Type>(ReflectionType.TypeResolverThrowOnError));
    }

    /// <summary>
    /// Returns information about how the given resource has been persisted.
    /// </summary>
    /// <param name="assembly"></param>
    /// <param name="resourceName">The case-sensitive name of the resource.</param>
    /// <returns>
    /// An object that is populated with information about the resource's topology, or
    /// null if the resource is not found.
    /// </returns>
    public static ManifestResourceInfo GetReflectionManifestResourceInfo(
      this Assembly assembly,
      string resourceName)
    {
      int num = 12;
      MemoryStream memoryStream;
      string str;
      IDictionary<string, MemoryStream> dictionary;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
          case 9:
          case 10:
          case 11:
            goto label_12;
          case 2:
            assembly = ReflectionType.dynamicModelAssembly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 8 : 9;
            continue;
          case 3:
            assembly = ReflectionType.configuraionModelAssembly;
            num = 10;
            continue;
          case 5:
            goto label_4;
          case 6:
            if (!ReflectionType.pNpUFubbxhUgPo2oaox((object) str, ReflectionType.AdIcTsboJk5FvALb41m(-477139494 ^ -477141962)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 4;
              continue;
            }
            goto case 2;
          case 7:
            if (memoryStream != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 5 : 5;
              continue;
            }
            str = (string) ReflectionType.DrdXihbWBYkwC882Tvt(ReflectionType.HwfRXSbBl14iJYS5Gcv((object) assembly));
            num = 8;
            continue;
          case 8:
            if (!ReflectionType.pNpUFubbxhUgPo2oaox((object) str, ReflectionType.AdIcTsboJk5FvALb41m(1051276242 - 990076387 ^ 61201521)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 1;
              continue;
            }
            goto case 3;
          case 12:
            if (!ReflectionType.manifestResources.TryGetValue(assembly, out dictionary))
            {
              num = 11;
              continue;
            }
            goto default;
          default:
            if (!dictionary.TryGetValue(resourceName, out memoryStream))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
              continue;
            }
            goto case 7;
        }
      }
label_4:
      return new ManifestResourceInfo((Assembly) null, (string) null, ResourceLocation.Embedded | ResourceLocation.ContainedInManifestFile);
label_12:
      return (ManifestResourceInfo) ReflectionType.GHAE8vbh8FWN0x3WU0G((object) assembly, (object) resourceName);
    }

    /// <summary>
    /// Returns the names of all the resources in this assembly.
    /// </summary>
    /// <param name="assembly"></param>
    /// <returns>An array that contains the names of all the resources.</returns>
    public static string[] GetReflectionManifestResourceNames(this Assembly assembly)
    {
      int num = 1;
      IDictionary<string, MemoryStream> dictionary;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ReflectionType.manifestResources.TryGetValue(assembly, out dictionary))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (string[]) ReflectionType.vKUF7DbGYZNmZuYvOJF((object) assembly);
label_3:
      return dictionary.Keys.ToArray<string>();
    }

    /// <summary>
    /// Loads the specified manifest resource, scoped by the namespace of the specified
    /// type, from this assembly.
    /// </summary>
    /// <param name="assembly"></param>
    /// <param name="type">The type whose namespace is used to scope the manifest resource name.</param>
    /// <param name="name">The case-sensitive name of the manifest resource being requested.</param>
    /// <returns>
    /// The manifest resource; or null if no resources were specified during compilation
    /// or if the resource is not visible to the caller.
    /// </returns>
    public static Stream GetReflectionManifestResourceStream(
      this Assembly assembly,
      Type type,
      string name)
    {
      return (Stream) ReflectionType.nJbjmlbEnnUBvkiFm36((object) assembly, (object) type == null || type.Namespace == null ? (object) name : (name == null ? (object) type.Namespace : (object) (type.Namespace + (object) Type.Delimiter + name)));
    }

    /// <summary>
    /// Loads the specified manifest resource from this assembly.
    /// </summary>
    /// <param name="assembly"></param>
    /// <param name="name">The case-sensitive name of the manifest resource being requested.</param>
    /// <returns>
    /// The manifest resource; or null if no resources were specified during compilation
    /// or if the resource is not visible to the caller.
    /// </returns>
    public static Stream GetReflectionManifestResourceStream(this Assembly assembly, string name)
    {
      int num1 = 19;
      MemoryStream manifestResourceStream;
      while (true)
      {
        int num2 = num1;
        IDictionary<string, MemoryStream> dictionary;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 18:
              if (ReflectionType.pNpUFubbxhUgPo2oaox(ReflectionType.DrdXihbWBYkwC882Tvt(ReflectionType.HwfRXSbBl14iJYS5Gcv((object) assembly)), ReflectionType.AdIcTsboJk5FvALb41m(-1824388195 ^ -1824390733)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 6 : 3;
                continue;
              }
              goto label_3;
            case 2:
              goto label_12;
            case 4:
              goto label_13;
            case 5:
              if (ReflectionType.pNpUFubbxhUgPo2oaox((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97969720)))
              {
                num2 = 13;
                continue;
              }
              goto case 7;
            case 6:
              if (!ReflectionType.manifestResources.TryGetValue(ReflectionType.FindAssembly(ref ReflectionType.configuraionModelAssembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397264572)), out dictionary))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 3 : 3;
                continue;
              }
              goto case 14;
            case 7:
              if (ReflectionType.pNpUFubbxhUgPo2oaox((object) str, ReflectionType.AdIcTsboJk5FvALb41m(-1939377524 ^ -1939375264)))
              {
                num2 = 16;
                continue;
              }
              goto label_3;
            case 8:
            case 13:
              assembly = ReflectionType.configuraionModelAssembly;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            case 9:
              goto label_5;
            case 12:
              if (!dictionary.TryGetValue(name, out manifestResourceStream))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
                continue;
              }
              goto case 15;
            case 14:
              if (dictionary.TryGetValue(name, out manifestResourceStream))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 12 : 15;
                continue;
              }
              goto label_3;
            case 15:
              if (manifestResourceStream == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 4;
                continue;
              }
              goto label_5;
            case 16:
            case 17:
              assembly = ReflectionType.dynamicModelAssembly;
              num2 = 11;
              continue;
            case 19:
              if (!ReflectionType.manifestResources.TryGetValue(assembly, out dictionary))
              {
                num2 = 18;
                continue;
              }
              goto case 12;
            default:
              goto label_3;
          }
        }
label_5:
        manifestResourceStream.Seek(0L, SeekOrigin.Begin);
        num1 = 2;
        continue;
label_13:
        str = (string) ReflectionType.DrdXihbWBYkwC882Tvt(ReflectionType.HwfRXSbBl14iJYS5Gcv((object) assembly));
        num1 = 5;
      }
label_3:
      return (Stream) ReflectionType.Ym8q1Cbf7DnHpb49TgJ((object) assembly, (object) name);
label_12:
      return (Stream) manifestResourceStream;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static bool? DynamicPublicationEnable => (ReflectionType.dynamicPublicationService ?? (ReflectionType.dynamicPublicationService = Locator.Initialized ? Locator.GetService<IDynamicPublicationService>() : (IDynamicPublicationService) null))?.Enable;

    internal static bool IsDynamicAssembly(this Assembly asm)
    {
      int num = 6;
      string str;
      bool flag;
      bool? publicationEnable;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            str = (string) ReflectionType.DrdXihbWBYkwC882Tvt(ReflectionType.HwfRXSbBl14iJYS5Gcv((object) asm));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 9;
            continue;
          case 3:
            if (publicationEnable.GetValueOrDefault() == flag & publicationEnable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 2 : 2;
              continue;
            }
            goto label_7;
          case 4:
            if (!(str == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606652286)))
            {
              num = 7;
              continue;
            }
            goto label_6;
          case 5:
            flag = true;
            num = 3;
            continue;
          case 6:
            publicationEnable = ReflectionType.DynamicPublicationEnable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 1;
            continue;
          case 7:
            if (!ReflectionType.pNpUFubbxhUgPo2oaox((object) str, ReflectionType.AdIcTsboJk5FvALb41m(-1445902765 ^ -1980277732 ^ 539365473)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
              continue;
            }
            goto label_6;
          case 8:
            goto label_6;
          case 9:
            if (ReflectionType.pNpUFubbxhUgPo2oaox((object) str, ReflectionType.AdIcTsboJk5FvALb41m(1470440286 ^ 1470441786)))
            {
              num = 8;
              continue;
            }
            goto case 4;
          default:
            goto label_7;
        }
      }
label_5:
      return ReflectionType.pNpUFubbxhUgPo2oaox((object) str, ReflectionType.AdIcTsboJk5FvALb41m(-1839087379 - 334718690 ^ 2121159655));
label_6:
      return true;
label_7:
      return false;
    }

    internal static void Register(IEnumerable<Type> newTypes) => newTypes.ForEach<Type>(new Action<Type>(ReflectionType.Register));

    internal static void Register(Type type)
    {
      int num = 3;
      string key;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ReflectionType.DynamicTypesIgnoreCase.Add(key, type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            ReflectionType.DynamicTypes.Add(key, type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
            continue;
          case 3:
            key = (string) ReflectionType.vyD4u7bQBKGCAaxya99((object) type.FullName);
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

    internal static void AddManifestResources(
      Assembly assembly,
      IEnumerable<(string name, byte[] data)> manifestResources)
    {
      string name = assembly.GetName().Name;
      IDictionary<string, MemoryStream> dictionary1;
      if (!(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105198202)) && !(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837664283)))
      {
        if (!(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35992579)) && !(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360333809)))
          return;
        if (!ReflectionType.manifestResources.TryGetValue(ReflectionType.FindAssembly(ref ReflectionType.dynamicModelAssembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669373893)), out dictionary1))
        {
          IDictionary<Assembly, IDictionary<string, MemoryStream>> manifestResources1 = ReflectionType.manifestResources;
          Assembly dynamicModelAssembly = ReflectionType.dynamicModelAssembly;
          string[] manifestResourceNames = ReflectionType.dynamicModelAssembly.GetManifestResourceNames();
          Dictionary<string, MemoryStream> dictionary2;
          dictionary1 = (IDictionary<string, MemoryStream>) (dictionary2 = ((IEnumerable<string>) manifestResourceNames).ToDictionary<string, string, MemoryStream>((Func<string, string>) (n => n), (Func<string, MemoryStream>) (_ => (MemoryStream) null)));
          manifestResources1[dynamicModelAssembly] = (IDictionary<string, MemoryStream>) dictionary2;
        }
      }
      else if (!ReflectionType.manifestResources.TryGetValue(ReflectionType.FindAssembly(ref ReflectionType.configuraionModelAssembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812027350)), out dictionary1))
      {
        IDictionary<Assembly, IDictionary<string, MemoryStream>> manifestResources2 = ReflectionType.manifestResources;
        Assembly configuraionModelAssembly = ReflectionType.configuraionModelAssembly;
        string[] manifestResourceNames = ReflectionType.configuraionModelAssembly.GetManifestResourceNames();
        Dictionary<string, MemoryStream> dictionary3;
        dictionary1 = (IDictionary<string, MemoryStream>) (dictionary3 = ((IEnumerable<string>) manifestResourceNames).ToDictionary<string, string, MemoryStream>((Func<string, string>) (n => n), (Func<string, MemoryStream>) (_ => (MemoryStream) null)));
        manifestResources2[configuraionModelAssembly] = (IDictionary<string, MemoryStream>) dictionary3;
      }
      ReflectionType.manifestResources[assembly] = dictionary1;
      foreach ((string str, byte[] numArray) in manifestResources)
      {
        MemoryStream memoryStream = MemoryHelper.GetMemoryStream(numArray.Length);
        memoryStream.Write(numArray, 0, numArray.Length);
        dictionary1[str] = memoryStream.AsReadOnly();
      }
    }

    private static Assembly AssemblyResolver(object asmName, bool throwOnError)
    {
      Assembly assembly;
      switch (1)
      {
        case 1:
          try
          {
            assembly = (Assembly) ReflectionType.MBNytVbvfgD9PJPRGSf(ReflectionType.ueIK1ObCaBQV7mWwxhD(), asmName);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                case 2:
                  goto label_10;
                default:
                  if (throwOnError)
                  {
                    num = 2;
                    continue;
                  }
                  assembly = (Assembly) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
                  continue;
              }
            }
label_10:
            throw;
          }
          break;
      }
label_1:
      return assembly;
    }

    private static Assembly AssemblyResolver(
      object asmName,
      Func<AssemblyName, Assembly> assemblyResolver)
    {
      string name = ((AssemblyName) asmName).Name;
      if (name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138159076) || name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479501354))
        return ReflectionType.FindAssembly(ref ReflectionType.configuraionModelAssembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099749581));
      return name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87335335) || name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012085011) ? ReflectionType.FindAssembly(ref ReflectionType.dynamicModelAssembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411198077)) : assemblyResolver((AssemblyName) asmName);
    }

    private static Type TypeResolver(object assembly, object typeName, bool ignoreCase)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if ((Assembly) assembly != (Assembly) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return ReflectionType.VNO7o9b81wu0uCYaqFC(typeName, false, ignoreCase);
label_5:
      return ReflectionType.Dm6d0RbZJB2Nsa4KLEI(assembly, typeName, false, ignoreCase);
    }

    private static Type TypeResolverThrowOnError(object assembly, object typeName, bool ignoreCase)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ReflectionType.NDHVAlbubDh4XKLqLlR(assembly, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return Type.GetType((string) typeName, true, ignoreCase);
label_3:
      return ((Assembly) assembly).GetType((string) typeName, true, ignoreCase);
    }

    private static Type TypeResolver(
      object assembly,
      object typeName,
      bool ignoreCase,
      Func<Assembly, string, bool, Type> typeResolver)
    {
      string name;
      Type type;
      return ((Assembly) assembly == (Assembly) null || (Assembly) assembly == ReflectionType.FindAssembly(ref ReflectionType.configuraionModelAssembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439612498)) || (Assembly) assembly == ReflectionType.FindAssembly(ref ReflectionType.dynamicModelAssembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812027296)) || (name = ((Assembly) assembly)?.GetName().Name) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841385006) || name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813602365)) && (ignoreCase ? ReflectionType.DynamicTypesIgnoreCase : ReflectionType.DynamicTypes).TryGetValue(ReflectionType.GetTypeName(typeName), out type) ? type : typeResolver((Assembly) assembly, (string) typeName, ignoreCase);
    }

    private static string GetTypeName(object typeName) => (string) typeName;

    private static Assembly FindAssembly(ref Assembly assembly, object assemblyName)
    {
      int num = 4;
      Assembly assembly1;
      Assembly assembly2;
      string assemblyName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            assembly2 = assembly;
            if ((object) assembly2 == null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            assembly = assembly1 = ((IEnumerable<Assembly>) ReflectionType.vR4KLdbITVxeMtvynfI((object) AppDomain.CurrentDomain)).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a => ReflectionType.\u003C\u003Ec__DisplayClass27_0.qv3rIef6CDZ23yUKO8p4((object) ((AssemblyName) ReflectionType.\u003C\u003Ec__DisplayClass27_0.BsUUoBf6QWkIlIwfxXVg((object) a)).Name, (object) assemblyName1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 3:
            assemblyName1 = (string) assemblyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          case 4:
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return assembly2;
label_8:
      return assembly1;
    }

    static ReflectionType()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            ReflectionType.DynamicTypes = PublishCacheContext.CreateCache<string, Type>((Func<IDictionary<string, Type>, IDictionary<string, Type>>) (c => (IDictionary<string, Type>) new Dictionary<string, Type>(c)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            ReflectionType.manifestResources = (IDictionary<Assembly, IDictionary<string, MemoryStream>>) new Dictionary<Assembly, IDictionary<string, MemoryStream>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
            continue;
          case 3:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = 2;
            continue;
          case 4:
            goto label_2;
          default:
            ReflectionType.DynamicTypesIgnoreCase = PublishCacheContext.CreateCache<string, Type>((Func<IDictionary<string, Type>, IDictionary<string, Type>>) (c => (IDictionary<string, Type>) new Dictionary<string, Type>(c, (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase)));
            num = 4;
            continue;
        }
      }
label_2:;
    }

    internal static bool DCwfqAocdwHl46Ubc3m() => ReflectionType.n1v4IBosNT6s4EXUbrm == null;

    internal static ReflectionType jSxWekozCHxrub23Ege() => ReflectionType.n1v4IBosNT6s4EXUbrm;

    internal static Type d8lBdobFlgoo8NrdMON(
      [In] object obj0,
      [In] object obj1,
      bool throwOnError,
      bool ignoreCase)
    {
      return ((Assembly) obj0).GetReflectionType((string) obj1, throwOnError, ignoreCase);
    }

    internal static object HwfRXSbBl14iJYS5Gcv([In] object obj0) => (object) ((Assembly) obj0).GetName();

    internal static object DrdXihbWBYkwC882Tvt([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static object AdIcTsboJk5FvALb41m(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool pNpUFubbxhUgPo2oaox([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object GHAE8vbh8FWN0x3WU0G([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetReflectionManifestResourceInfo((string) obj1);

    internal static object vKUF7DbGYZNmZuYvOJF([In] object obj0) => (object) ((Assembly) obj0).GetManifestResourceNames();

    internal static object nJbjmlbEnnUBvkiFm36([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetReflectionManifestResourceStream((string) obj1);

    internal static object Ym8q1Cbf7DnHpb49TgJ([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetManifestResourceStream((string) obj1);

    internal static object vyD4u7bQBKGCAaxya99([In] object obj0) => (object) ReflectionType.GetTypeName(obj0);

    internal static object ueIK1ObCaBQV7mWwxhD() => (object) AppDomain.CurrentDomain;

    internal static object MBNytVbvfgD9PJPRGSf([In] object obj0, [In] object obj1) => (object) ((AppDomain) obj0).Load((AssemblyName) obj1);

    internal static Type VNO7o9b81wu0uCYaqFC([In] object obj0, [In] bool obj1, [In] bool obj2) => Type.GetType((string) obj0, obj1, obj2);

    internal static Type Dm6d0RbZJB2Nsa4KLEI([In] object obj0, [In] object obj1, [In] bool obj2, [In] bool obj3) => ((Assembly) obj0).GetType((string) obj1, obj2, obj3);

    internal static bool NDHVAlbubDh4XKLqLlR([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

    internal static object vR4KLdbITVxeMtvynfI([In] object obj0) => (object) ((AppDomain) obj0).GetAssemblies();
  }
}
