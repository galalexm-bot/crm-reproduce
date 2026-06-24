// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.EnumProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Collections.Generic;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  /// <summary>Провайдер получения ReflectionType для перечислений</summary>
  internal class EnumProvider : TypeDescriptionProvider
  {
    private static EnumProvider instance;
    private static readonly ISet<System.Type> providerTypes;
    private static readonly IDictionary<System.Type, EnumProvider.TypeDelegator> types;
    private static readonly IDictionary<System.Type, ICustomTypeDescriptor> typeDescriptor;
    internal static EnumProvider n8xV4Mhiqx88LHfuy19e;

    internal static EnumProvider Instance
    {
      get
      {
        int num = 1;
        EnumProvider instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = EnumProvider.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return instance;
label_5:
        return new EnumProvider();
      }
    }

    internal static void AddType(System.Type type, TypeDefinition typeDefinition)
    {
      int num = 1;
      EnumProvider.TypeDelegator typeDelegator;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!EnumProvider.providerTypes.Add(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 3:
          case 4:
            EnumProvider.oQq8vLhikRhVgTSo1f3v((object) typeDelegator, (object) typeDefinition);
            num = 6;
            continue;
          case 5:
            TypeDescriptor.AddProvider((TypeDescriptionProvider) EnumProvider.lQWPdThiTeNIMsuNMQRy(), type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 2 : 0;
            continue;
          case 6:
            goto label_7;
          case 7:
            EnumProvider.types[type] = typeDelegator = new EnumProvider.TypeDelegator(type);
            num = 4;
            continue;
          default:
            if (EnumProvider.types.TryGetValue(type, out typeDelegator))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 3 : 3;
              continue;
            }
            goto case 7;
        }
      }
label_7:;
    }

    public EnumProvider()
    {
      EnumProvider.BrfL0Uhin2HeXNGLeOZR();
      // ISSUE: type reference
      // ISSUE: explicit constructor call
      base.\u002Ector((TypeDescriptionProvider) EnumProvider.c7ouYmhi20QeWjUVgMuj(EnumProvider.zaCotHhiOUA6EnEG3XHi(__typeref (Enum))));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            EnumProvider.instance = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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
    public override bool IsSupportedType(System.Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!type.IsEnum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return EnumProvider.v1K1pOhiei9H7p3LQBQh((object) type.Assembly);
label_5:
      return false;
    }

    /// <inheritdoc />
    public override System.Type GetRuntimeType(System.Type reflectionType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (reflectionType is BaseTypeDelegator baseTypeDelegator)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
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
      return EnumProvider.QYTeX9hiPBB5J0TFnDa2((object) this, reflectionType);
label_3:
      return EnumProvider.H5KSa1hi1HaVrip3cwKd((object) baseTypeDelegator);
    }

    /// <inheritdoc />
    public override System.Type GetReflectionType(System.Type objectType, object instance)
    {
      int num = 1;
      EnumProvider.TypeDelegator reflectionType;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!EnumProvider.types.TryGetValue(objectType, out reflectionType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return objectType;
label_5:
      return (System.Type) reflectionType;
    }

    private static EnumMetadata GetEnumMetadata(System.Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      AssemblyModelsMetadata assemblyModelsMetadata = MetadataServiceContext.MetadataRuntimeService.GetAssemblyModelsMetadataList().First<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (a => EnumProvider.\u003C\u003Ec.avr5aHvoB5xQP8BsuHev(EnumProvider.\u003C\u003Ec.b8OvwgvoFZtvYUlLlXMR((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178207576))));
      string fullTypeName = type.FullName;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return assemblyModelsMetadata.RestoreMetadata().OfType<EnumMetadata>().First<EnumMetadata>((Func<EnumMetadata, bool>) (m => EnumProvider.\u003C\u003Ec__DisplayClass11_0.jMqVrsvWLoZ6TOf28n6f(EnumProvider.\u003C\u003Ec__DisplayClass11_0.R5h11rvWYZnRDkA0d79C((object) m), (object) fullTypeName)));
    }

    /// <inheritdoc />
    public override ICustomTypeDescriptor GetTypeDescriptor(System.Type type, object instance)
    {
      int num1 = 1;
      EnumProvider enumProvider;
      object instance1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            instance1 = instance;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 2;
            continue;
          default:
            enumProvider = this;
            num1 = 3;
            continue;
        }
      }
label_3:
      return EnumProvider.typeDescriptor.GetOrAdd<System.Type, ICustomTypeDescriptor>(type, (Func<System.Type, ICustomTypeDescriptor>) (t =>
      {
        int num2 = 2;
        ICustomTypeDescriptor typeDescriptor;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              typeDescriptor = (ICustomTypeDescriptor) new EnumProvider.CustomTypeDescriptor(t, enumProvider.\u003C\u003En__0(t, instance1));
              num2 = 3;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (EnumProvider.\u003C\u003Ec__DisplayClass12_0.jSkGk5vohwVebrdlQUQ9((object) enumProvider, t))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            case 3:
              goto label_6;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return enumProvider.\u003C\u003En__0(t, instance1);
label_6:
        return typeDescriptor;
      }));
    }

    static EnumProvider()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            EnumProvider.types = PublishCacheContext.CreateCache<System.Type, EnumProvider.TypeDelegator>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            EnumProvider.providerTypes = (ISet<System.Type>) new HashSet<System.Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
            continue;
          case 4:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = 3;
            continue;
          default:
            EnumProvider.typeDescriptor = PublishCacheContext.CreateCache<System.Type, ICustomTypeDescriptor>();
            num = 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool UeG0xPhiKvyfYh5QCPPI() => EnumProvider.n8xV4Mhiqx88LHfuy19e == null;

    internal static EnumProvider aurP45hiXIZarOWyhger() => EnumProvider.n8xV4Mhiqx88LHfuy19e;

    internal static object lQWPdThiTeNIMsuNMQRy() => (object) EnumProvider.Instance;

    internal static void oQq8vLhikRhVgTSo1f3v([In] object obj0, [In] object obj1) => ((BaseTypeDelegator) obj0).InitType((TypeDefinition) obj1);

    internal static void BrfL0Uhin2HeXNGLeOZR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static System.Type zaCotHhiOUA6EnEG3XHi([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object c7ouYmhi20QeWjUVgMuj([In] System.Type obj0) => (object) TypeDescriptor.GetProvider(obj0);

    internal static bool v1K1pOhiei9H7p3LQBQh([In] object obj0) => ((Assembly) obj0).IsDynamicAssembly();

    internal static System.Type QYTeX9hiPBB5J0TFnDa2([In] object obj0, [In] System.Type obj1) => __nonvirtual (((TypeDescriptionProvider) obj0).GetRuntimeType(obj1));

    internal static System.Type H5KSa1hi1HaVrip3cwKd([In] object obj0) => ((BaseTypeDelegator) obj0).RuntimeType;

    internal static object JeyWrBhiNEgK0hIv8sF5([In] object obj0, [In] System.Type obj1, [In] object obj2) => (object) __nonvirtual (((TypeDescriptionProvider) obj0).GetTypeDescriptor(obj1, obj2));

    private class TypeDelegator : BaseTypeDelegator
    {
      private static readonly object GenericCacheProperty;
      private static readonly System.Type ValuesAndNamesType;
      private static readonly IDictionary<System.Type, object> EnumCachedValuesAndNames;
      private static readonly object MetadataTypeAttribute;
      private static readonly object UidAttribute;
      private static readonly object DisplayNameAttribute;
      private PublishCacheContext.Local<FieldInfo[]> allValues;
      private PublishCacheContext.Local<FieldInfo[]> staticValues;
      internal static object AvmijAvWaOgEeCRaJQFt;

      public TypeDelegator(System.Type runtimeType)
      {
        EnumProvider.TypeDelegator.DvPZqPvWwtnklF5rFcZ9();
        this.allValues = new PublishCacheContext.Local<FieldInfo[]>();
        this.staticValues = new PublishCacheContext.Local<FieldInfo[]>();
        // ISSUE: explicit constructor call
        base.\u002Ector(runtimeType);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public override void InitType(TypeDefinition typeDefinition)
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          FieldInfo[] fieldInfoArray1;
          FieldInfo[] fieldInfoArray2;
          ulong[] numArray;
          string[] strArray;
          int index;
          FieldInfo[] fieldInfoArray3;
          IEnumerator<FieldDefinition> enumerator;
          while (true)
          {
            switch (num2)
            {
              case 1:
                Collection<FieldDefinition> fields = typeDefinition.Fields;
                // ISSUE: reference to a compiler-generated field
                Func<FieldDefinition, bool> func = EnumProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__9_0;
                Func<FieldDefinition, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  EnumProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__9_0 = predicate = (Func<FieldDefinition, bool>) (f => EnumProvider.TypeDelegator.\u003C\u003Ec.WYV9cdZR5rcgtgEcLbXR((object) f) != null);
                }
                else
                  goto label_11;
label_32:
                enumerator = fields.Where<FieldDefinition>(predicate).GetEnumerator();
                num2 = 10;
                continue;
label_11:
                predicate = func;
                goto label_32;
              case 2:
                this.allValues.Value = fieldInfoArray2 = new FieldInfo[EnumProvider.TypeDelegator.jC2lOmvW4sCUJ0GeUbRh((object) typeDefinition.Fields)];
                num2 = 12;
                continue;
              case 3:
                goto label_27;
              case 4:
                fieldInfoArray3 = fieldInfoArray2;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 5 : 7;
                continue;
              case 5:
                index = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                continue;
              case 6:
                goto label_30;
              case 7:
                numArray = new ulong[EnumProvider.TypeDelegator.jC2lOmvW4sCUJ0GeUbRh((object) typeDefinition.Fields) - 1];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 8 : 8;
                continue;
              case 8:
                strArray = new string[EnumProvider.TypeDelegator.jC2lOmvW4sCUJ0GeUbRh((object) typeDefinition.Fields) - 1];
                num2 = 9;
                continue;
              case 9:
                fieldInfoArray1[0] = this.RuntimeType.GetField(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470144482));
                num2 = 5;
                continue;
              case 10:
                try
                {
label_13:
                  if (EnumProvider.TypeDelegator.aUg9vGvW7pDRNbqjDlgU((object) enumerator))
                    goto label_15;
                  else
                    goto label_14;
label_10:
                  FieldDefinition current;
                  int num3;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_25;
                      case 2:
                        goto label_15;
                      case 3:
                        numArray[index] = EnumProvider.TypeDelegator.SGxxB0vWHBiWe71LFjkw(EnumProvider.TypeDelegator.MwVmBevW6VZMq9WHAqq8((object) current));
                        num3 = 6;
                        continue;
                      case 4:
                        fieldInfoArray1[index + 1] = fieldInfoArray3[index] = (FieldInfo) new EnumProvider.TypeDelegator.EnumFieldInfo(this.RuntimeType, current);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                        continue;
                      case 5:
                        goto label_13;
                      case 6:
                        strArray[index] = (string) EnumProvider.TypeDelegator.DELWayvWAXOSGJEsA03c((object) current);
                        num3 = 4;
                        continue;
                      default:
                        ++index;
                        num3 = 5;
                        continue;
                    }
                  }
label_14:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
                  goto label_10;
label_15:
                  current = enumerator.Current;
                  num3 = 3;
                  goto label_10;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num4 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                      num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          enumerator.Dispose();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_24;
                      }
                    }
                  }
label_24:;
                }
              case 11:
label_25:
                EnumProvider.TypeDelegator.EnumCachedValuesAndNames[this.RuntimeType] = EnumProvider.TypeDelegator.i3bK9DvWxHibkHODyi6O(EnumProvider.TypeDelegator.ValuesAndNamesType, (object) new object[2]
                {
                  (object) numArray,
                  (object) strArray
                });
                num2 = 6;
                continue;
              case 12:
                fieldInfoArray1 = fieldInfoArray2;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              default:
                this.staticValues.Value = fieldInfoArray2 = new FieldInfo[EnumProvider.TypeDelegator.jC2lOmvW4sCUJ0GeUbRh((object) typeDefinition.Fields) - 1];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 4;
                continue;
            }
          }
label_27:
          base.InitType(typeDefinition);
          num1 = 2;
        }
label_30:;
      }

      public override FieldInfo[] GetFields(BindingFlags bindingAttr)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (!bindingAttr.HasFlag((Enum) BindingFlags.Instance))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
                continue;
              }
              goto label_3;
            case 3:
              if (bindingAttr.HasFlag((Enum) (BindingFlags.Static | BindingFlags.Public)))
              {
                num = 2;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_2:
        return this.staticValues.Value;
label_3:
        return this.allValues.Value;
label_4:
        return (FieldInfo[]) EnumProvider.TypeDelegator.f0uTxEvW0Is3DvEZ2HfD((object) this, bindingAttr);
      }

      public override FieldInfo GetField(string name, BindingFlags bindingAttr)
      {
        int num = 4;
        List<FieldInfo> list;
        string name1;
        bool ignoreCase;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              list = ((IEnumerable<FieldInfo>) this.GetFields(bindingAttr)).Where<FieldInfo>((Func<FieldInfo, bool>) (p => EnumProvider.TypeDelegator.\u003C\u003Ec__DisplayClass11_0.wsf2HmZRclSFkZN8oWRW(EnumProvider.TypeDelegator.\u003C\u003Ec__DisplayClass11_0.MPEgrWZRsMC97aZKhNGn((object) p), (object) name1, !ignoreCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase))).ToList<FieldInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            case 3:
              name1 = name;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 7;
              continue;
            case 4:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 3 : 3;
              continue;
            case 5:
              if (list.Count != 1)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            case 6:
              goto label_14;
            case 7:
              if (name1 == null)
              {
                num = 6;
                continue;
              }
              ignoreCase = bindingAttr.HasFlag((Enum) BindingFlags.IgnoreCase);
              num = 2;
              continue;
            default:
              if (EnumProvider.TypeDelegator.rf5RokvWmsII6dp78XXa((object) list) != 0)
              {
                num = 5;
                continue;
              }
              goto label_4;
          }
        }
label_2:
        throw new AmbiguousMatchException();
label_3:
        return list[0];
label_4:
        return (FieldInfo) null;
label_14:
        throw new ArgumentNullException();
      }

      static TypeDelegator()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: type reference
              EnumProvider.TypeDelegator.ValuesAndNamesType = EnumProvider.TypeDelegator.bo4GWdvWMOghebOCsJUa(__typeref (Enum)).GetNestedType((string) EnumProvider.TypeDelegator.ykEOXlvWylVqBHO3Cnkf(-1120607109 - 305487170 ^ -1426441261), BindingFlags.NonPublic);
              num = 4;
              continue;
            case 2:
              EnumProvider.TypeDelegator.GenericCacheProperty = (object) typeof (System.Type).GetType().GetProperty((string) EnumProvider.TypeDelegator.ykEOXlvWylVqBHO3Cnkf(-1638402543 ^ -1638774049), BindingFlags.Instance | BindingFlags.NonPublic);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
              continue;
            case 3:
              EnumProvider.TypeDelegator.DvPZqPvWwtnklF5rFcZ9();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 2;
              continue;
            case 4:
              EnumProvider.TypeDelegator.EnumCachedValuesAndNames = PublishCacheContext.CreateCache<System.Type, object>((Func<IDictionary<System.Type, object>, IDictionary<System.Type, object>>) (_ => (IDictionary<System.Type, object>) new Dictionary<System.Type, object>()), onComplete: (Action<IDictionary<System.Type, object>>) (_ => _.RemoveAll<KeyValuePair<System.Type, object>>((Func<KeyValuePair<System.Type, object>, bool>) (p =>
              {
                ((PropertyInfo) EnumProvider.TypeDelegator.GenericCacheProperty).SetValue((object) p.Key, p.Value);
                return true;
              }))), onCancel: (Action<IDictionary<System.Type, object>>) (_ => _.Clear()));
              num = 6;
              continue;
            case 5:
              goto label_2;
            case 6:
              EnumProvider.TypeDelegator.MetadataTypeAttribute = (object) TypeOf<MetadataTypeAttribute>.Raw.GetConstructor(new System.Type[1]
              {
                TypeOf<System.Type>.Raw
              });
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            case 7:
              EnumProvider.TypeDelegator.DisplayNameAttribute = (object) TypeOf<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.Raw.GetConstructor(new System.Type[1]
              {
                TypeOf<string>.Raw
              });
              num = 5;
              continue;
            default:
              EnumProvider.TypeDelegator.UidAttribute = (object) TypeOf<UidAttribute>.Raw.GetConstructor(new System.Type[1]
              {
                TypeOf<string>.Raw
              });
              num = 7;
              continue;
          }
        }
label_2:;
      }

      internal static void DvPZqPvWwtnklF5rFcZ9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool JNMG3dvWDKMI4kEE6Xyi() => EnumProvider.TypeDelegator.AvmijAvWaOgEeCRaJQFt == null;

      internal static EnumProvider.TypeDelegator u9Q26pvWtjiTCJALKuMc() => (EnumProvider.TypeDelegator) EnumProvider.TypeDelegator.AvmijAvWaOgEeCRaJQFt;

      internal static int jC2lOmvW4sCUJ0GeUbRh([In] object obj0) => ((Collection<FieldDefinition>) obj0).Count;

      internal static object MwVmBevW6VZMq9WHAqq8([In] object obj0) => ((FieldDefinition) obj0).Constant;

      internal static ulong SGxxB0vWHBiWe71LFjkw([In] object obj0) => Convert.ToUInt64(obj0);

      internal static object DELWayvWAXOSGJEsA03c([In] object obj0) => (object) ((MemberReference) obj0).Name;

      internal static bool aUg9vGvW7pDRNbqjDlgU([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static object i3bK9DvWxHibkHODyi6O([In] System.Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

      internal static object f0uTxEvW0Is3DvEZ2HfD([In] object obj0, [In] BindingFlags obj1) => (object) __nonvirtual (((System.Reflection.TypeDelegator) obj0).GetFields(obj1));

      internal static int rf5RokvWmsII6dp78XXa([In] object obj0) => ((List<FieldInfo>) obj0).Count;

      internal static object ykEOXlvWylVqBHO3Cnkf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static System.Type bo4GWdvWMOghebOCsJUa([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

      private class EnumFieldInfo : FieldInfo
      {
        private readonly object value;
        private PublishCacheContext.Local<CustomAttributesData> customAttributesData;
        internal static object cCUCP7ZR7qMFATIkkRTR;

        public EnumFieldInfo(System.Type runtimeType, FieldDefinition fieldDefinition)
        {
          EnumProvider.TypeDelegator.EnumFieldInfo.r7RbL2ZRmKaKCNKOQwNv();
          this.customAttributesData = new PublishCacheContext.Local<CustomAttributesData>();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.DeclaringType = runtimeType;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                continue;
              case 2:
                this.value = EnumProvider.TypeDelegator.EnumFieldInfo.OrdLWLZRJIl1kQfWSku2(runtimeType, EnumProvider.TypeDelegator.EnumFieldInfo.Q3qYLFZRMQIlhPG8ZNCQ((object) fieldDefinition));
                num = 4;
                continue;
              case 3:
                this.Name = (string) EnumProvider.TypeDelegator.EnumFieldInfo.otIgORZRypWK3InN77UV((object) fieldDefinition);
                num = 2;
                continue;
              case 4:
                this.customAttributesData.Value = new CustomAttributesData((ICollection<Mono.Cecil.CustomAttribute>) fieldDefinition.CustomAttributes);
                num = 5;
                continue;
              case 5:
                goto label_3;
              default:
                this.ReflectedType = runtimeType;
                num = 3;
                continue;
            }
          }
label_3:;
        }

        public override string Name { get; }

        public override System.Type FieldType => EnumProvider.TypeDelegator.EnumFieldInfo.PRhVVPZR96bLdFer5XWd((object) this);

        public override System.Reflection.FieldAttributes Attributes => System.Reflection.FieldAttributes.Public | System.Reflection.FieldAttributes.Static | System.Reflection.FieldAttributes.Literal | System.Reflection.FieldAttributes.HasDefault;

        public override System.Type DeclaringType { get; }

        public override System.Type ReflectedType { get; }

        public override object GetValue(object obj) => this.value;

        public override void SetValue(
          object obj,
          object value,
          BindingFlags invokeAttr,
          Binder binder,
          CultureInfo culture)
        {
          throw new FieldAccessException();
        }

        public override RuntimeFieldHandle FieldHandle => throw new NotImplementedException();

        public override IList<CustomAttributeData> GetCustomAttributesData() => this.customAttributesData.Value.GetCustomAttributesData();

        public override bool IsDefined(System.Type attributeType, bool inherit) => this.customAttributesData.Value.IsDefined(attributeType, inherit);

        public override object[] GetCustomAttributes(bool inherit) => this.customAttributesData.Value.GetCustomAttributes(inherit);

        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) => this.customAttributesData.Value.GetCustomAttributes(attributeType, inherit);

        internal static void r7RbL2ZRmKaKCNKOQwNv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static object otIgORZRypWK3InN77UV([In] object obj0) => (object) ((MemberReference) obj0).Name;

        internal static object Q3qYLFZRMQIlhPG8ZNCQ([In] object obj0) => ((FieldDefinition) obj0).Constant;

        internal static object OrdLWLZRJIl1kQfWSku2([In] System.Type obj0, [In] object obj1) => Enum.ToObject(obj0, obj1);

        internal static bool QmPaV7ZRxRppba1PM7my() => EnumProvider.TypeDelegator.EnumFieldInfo.cCUCP7ZR7qMFATIkkRTR == null;

        internal static EnumProvider.TypeDelegator.EnumFieldInfo NhgXCaZR0uhoKZFNj7tW() => (EnumProvider.TypeDelegator.EnumFieldInfo) EnumProvider.TypeDelegator.EnumFieldInfo.cCUCP7ZR7qMFATIkkRTR;

        internal static System.Type PRhVVPZR96bLdFer5XWd([In] object obj0) => ((MemberInfo) obj0).DeclaringType;
      }
    }

    private class CustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor
    {
      private readonly object typeConverter;
      internal static object eLT4xdvWJtheNmVkHiFo;

      public CustomTypeDescriptor(System.Type enumType, ICustomTypeDescriptor enumTypeDescriptor)
      {
        EnumProvider.CustomTypeDescriptor.PT6CORvWlGElCJHkKGC8();
        // ISSUE: explicit constructor call
        base.\u002Ector(enumTypeDescriptor);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.typeConverter = (object) new EnumProvider.CustomTypeDescriptor.EnumTypeConverter(enumType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public override TypeConverter GetConverter() => (TypeConverter) this.typeConverter;

      internal static void PT6CORvWlGElCJHkKGC8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool YfT411vW9n55XHLEuVvk() => EnumProvider.CustomTypeDescriptor.eLT4xdvWJtheNmVkHiFo == null;

      internal static EnumProvider.CustomTypeDescriptor JpXl4mvWdcASF4fCxi6c() => (EnumProvider.CustomTypeDescriptor) EnumProvider.CustomTypeDescriptor.eLT4xdvWJtheNmVkHiFo;

      private class EnumTypeConverter : TypeConverter
      {
        private readonly object enumType;
        internal static object JehKaBZRzTtGi2jCTrIE;

        public EnumTypeConverter(System.Type enumType)
        {
          EnumProvider.CustomTypeDescriptor.EnumTypeConverter.NEPEhRZqWNKykur72UqI();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.enumType = (object) EnumProvider.types[enumType];
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_3:
          return;
label_5:;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType)
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                // ISSUE: type reference
                if (sourceType == EnumProvider.CustomTypeDescriptor.EnumTypeConverter.KplalMZqoJLCf5RL4Oa2(__typeref (string)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              default:
                goto label_2;
            }
          }
label_2:
          return EnumProvider.CustomTypeDescriptor.EnumTypeConverter.uIyrEnZqbgS07PBgoqey((object) this, (object) context, sourceType);
label_3:
          return true;
        }

        public override object ConvertFrom(
          ITypeDescriptorContext context,
          CultureInfo culture,
          object value)
        {
          int num1 = 8;
          int? nullable1;
          while (true)
          {
            int num2 = num1;
            string[] strArray;
            int index;
            string name1;
            while (true)
            {
              int? nullable2;
              FieldInfo field1;
              int? nullable3;
              int num3;
              int? nullable4;
              object obj;
              switch (num2)
              {
                case 1:
                  goto label_4;
                case 2:
                  nullable4 = nullable3;
                  break;
                case 3:
                  if (EnumProvider.CustomTypeDescriptor.EnumTypeConverter.fpQQeoZqGTjyKTgHncmx((object) field1, (object) null))
                  {
                    num2 = 5;
                    continue;
                  }
                  goto case 9;
                case 4:
                  field1 = ((System.Type) this.enumType).GetField(name1);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 2;
                  continue;
                case 5:
                  nullable2 = nullable1;
                  num2 = 6;
                  continue;
                case 6:
                  num3 = (int) EnumProvider.CustomTypeDescriptor.EnumTypeConverter.KrZnilZqECpbRZiEYoAx((object) field1, (object) null);
                  num2 = 14;
                  continue;
                case 7:
                  if (EnumProvider.CustomTypeDescriptor.EnumTypeConverter.okk89jZqhiIyOTM7Ae8D((object) name2, ',') == -1)
                    goto case 11;
                  else
                    goto label_8;
                case 8:
                  if (value is string name2)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 7 : 4;
                    continue;
                  }
                  goto label_14;
                case 9:
                  ++index;
                  num2 = 20;
                  continue;
                case 10:
                case 20:
                  if (index >= strArray.Length)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 17 : 12;
                    continue;
                  }
                  goto label_4;
                case 11:
                  FieldInfo field2 = ((System.Type) this.enumType).GetField(name2);
                  if ((object) field2 == null)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 10 : 13;
                    continue;
                  }
                  obj = EnumProvider.CustomTypeDescriptor.EnumTypeConverter.KrZnilZqECpbRZiEYoAx((object) field2, (object) null);
                  goto label_33;
                case 12:
                  index = 0;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 10;
                  continue;
                case 13:
                  obj = (object) null;
                  goto label_33;
                case 14:
                  if (!nullable2.HasValue)
                  {
                    num2 = 15;
                    continue;
                  }
                  nullable4 = new int?(nullable2.GetValueOrDefault() | num3);
                  break;
                case 15:
                  nullable3 = new int?();
                  num2 = 2;
                  continue;
                case 16:
                  strArray = name2.Split(',');
                  num2 = 12;
                  continue;
                case 17:
                case 18:
                  if (nullable1.HasValue)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_14;
                case 19:
                  nullable1 = new int?(0);
                  num2 = 16;
                  continue;
                default:
                  goto label_13;
              }
              nullable1 = nullable4;
              num2 = 9;
              continue;
label_33:
              nullable1 = (int?) obj;
              num2 = 18;
            }
label_4:
            name1 = strArray[index];
            num1 = 4;
            continue;
label_8:
            num1 = 19;
          }
label_13:
          return EnumProvider.CustomTypeDescriptor.EnumTypeConverter.MPjxTuZqfBAKpP95hY83((System.Type) this.enumType, (object) nullable1);
label_14:
          return EnumProvider.CustomTypeDescriptor.EnumTypeConverter.EB4LWXZqQVxGKFX6Sby1((object) this, (object) context, (object) culture, value);
        }

        internal static void NEPEhRZqWNKykur72UqI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool HeYk6RZqFW3wUfoa6r4x() => EnumProvider.CustomTypeDescriptor.EnumTypeConverter.JehKaBZRzTtGi2jCTrIE == null;

        internal static EnumProvider.CustomTypeDescriptor.EnumTypeConverter EkVmLIZqBE9OfbdCnFgm() => (EnumProvider.CustomTypeDescriptor.EnumTypeConverter) EnumProvider.CustomTypeDescriptor.EnumTypeConverter.JehKaBZRzTtGi2jCTrIE;

        internal static System.Type KplalMZqoJLCf5RL4Oa2([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

        internal static bool uIyrEnZqbgS07PBgoqey([In] object obj0, [In] object obj1, [In] System.Type obj2) => __nonvirtual (((TypeConverter) obj0).CanConvertFrom((ITypeDescriptorContext) obj1, obj2));

        internal static int okk89jZqhiIyOTM7Ae8D([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

        internal static bool fpQQeoZqGTjyKTgHncmx([In] object obj0, [In] object obj1) => (FieldInfo) obj0 != (FieldInfo) obj1;

        internal static object KrZnilZqECpbRZiEYoAx([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

        internal static object MPjxTuZqfBAKpP95hY83([In] System.Type obj0, [In] object obj1) => Enum.ToObject(obj0, obj1);

        internal static object EB4LWXZqQVxGKFX6Sby1(
          [In] object obj0,
          [In] object obj1,
          [In] object obj2,
          [In] object obj3)
        {
          // ISSUE: explicit non-virtual call
          return __nonvirtual (((TypeConverter) obj0).ConvertFrom((ITypeDescriptorContext) obj1, (CultureInfo) obj2, obj3));
        }
      }
    }
  }
}
