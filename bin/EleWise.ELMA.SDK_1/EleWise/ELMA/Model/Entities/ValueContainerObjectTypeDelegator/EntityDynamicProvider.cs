// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.EntityDynamicProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Accessors;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Collections.Generic;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  /// <summary>
  /// Провайдер получения ReflectionType для <see cref="T:EleWise.ELMA.Model.Entities.IValueContainerObjectInternal" />
  /// </summary>
  internal class EntityDynamicProvider : TypeDescriptionProvider
  {
    private static EntityDynamicProvider instance;
    private static readonly ISet<System.Type> providerTypes;
    private static readonly IDictionary<System.Type, EntityDynamicProvider.TypeDelegator> types;
    private static readonly IDictionary<System.Type, ICustomTypeDescriptor> typeDelegators;
    private static ILogger entityDynamicProviderLogger;
    internal static EntityDynamicProvider Tu1cFuhVgZIiBXftthqM;

    internal static EntityDynamicProvider Instance
    {
      get
      {
        int num = 1;
        EntityDynamicProvider instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = EntityDynamicProvider.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
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
        return new EntityDynamicProvider();
      }
    }

    internal static void AddType(System.Type type, TypeDefinition typeDefinition = null)
    {
      int num = 7;
      EntityDynamicProvider.TypeDelegator typeDelegator;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            EntityDynamicProvider.types[type] = typeDelegator = new EntityDynamicProvider.TypeDelegator(type);
            num = 4;
            continue;
          case 2:
            EntityDynamicProvider.ehSbyLhVYB21B8GthfV5((object) EntityDynamicProvider.Instance, type);
            num = 9;
            continue;
          case 3:
          case 9:
            if (!EntityDynamicProvider.types.TryGetValue(type, out typeDelegator))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          case 4:
            EntityDynamicProvider.RcqbOShVLAsbs9KSBdIs((object) typeDelegator, (object) typeDefinition);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_7;
          case 6:
          case 8:
            if (typeDefinition != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 1;
              continue;
            }
            goto label_3;
          case 7:
            if (!EntityDynamicProvider.providerTypes.Add(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 6 : 6;
              continue;
            }
            goto case 2;
          default:
            goto label_4;
        }
      }
label_6:
      return;
label_7:
      return;
label_4:
      return;
label_3:;
    }

    public EntityDynamicProvider()
    {
      EntityDynamicProvider.pg8dWShVUiTQCQKHamqB();
      // ISSUE: type reference
      // ISSUE: explicit constructor call
      base.\u002Ector((TypeDescriptionProvider) EntityDynamicProvider.oMQCvThVctZDE8ThSna8(EntityDynamicProvider.z6EXhehVsyoEBcWjnlvG(__typeref (object))));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            EntityDynamicProvider.instance = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool IsSupportedType(System.Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (type.IsEnum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
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
      return EntityDynamicProvider.Ta5V97hVzYoQ18r8LGha((object) type.Assembly);
label_3:
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
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
      return EntityDynamicProvider.ITnDXJhSFC6PpHT7jUnv((object) this, reflectionType);
label_3:
      return EntityDynamicProvider.Tg5YbuhSBIiw9GPixrua((object) baseTypeDelegator);
    }

    /// <inheritdoc />
    public override System.Type GetReflectionType(System.Type objectType, object instance)
    {
      int num = 1;
      EntityDynamicProvider.TypeDelegator reflectionType;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityDynamicProvider.types.TryGetValue(objectType, out reflectionType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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
      return objectType;
label_5:
      return (System.Type) reflectionType;
    }

    /// <inheritdoc />
    public override ICustomTypeDescriptor GetTypeDescriptor(System.Type type, object instance)
    {
      int num1 = 3;
      EntityDynamicProvider entityDynamicProvider;
      object instance1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            instance1 = instance;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 2:
            entityDynamicProvider = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return EntityDynamicProvider.typeDelegators.GetOrAdd<System.Type, ICustomTypeDescriptor>(!(type is EntityDynamicProvider.TypeDelegator typeDelegator) ? type : EntityDynamicProvider.Tg5YbuhSBIiw9GPixrua((object) typeDelegator), (Func<System.Type, ICustomTypeDescriptor>) (t =>
      {
        int num2 = 4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              goto label_2;
            case 3:
              if (EntityDynamicProvider.entityDynamicProviderLogger.IsTraceEnabled())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 4:
              // ISSUE: reference to a compiler-generated method
              if (!EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.q9UIljvBDh0NMnuEsL3b((object) entityDynamicProvider, t))
              {
                // ISSUE: reference to a compiler-generated method
                if (EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.ivVJ4kvBHt8ZohnFtrC7((object) EntityDynamicProvider.entityDynamicProviderLogger))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 5 : 2;
                  continue;
                }
                goto label_2;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 3;
                continue;
              }
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.kOwavBvB6cxTADYSIv80((object) EntityDynamicProvider.entityDynamicProviderLogger, EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.Sggeq9vBAVSfjbS6ASdb((object) new string[5]
              {
                (string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.vAXuJMvBtoyTQU1UCw0E(-477139494 ^ -477441552),
                t.FullName,
                (string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.vAXuJMvBtoyTQU1UCw0E(95909607 + 343705423 ^ 439589148),
                !(t is TypeBuilder typeBuilder3) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867882490) : (string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.C5N6I4vB4JH67Bmg8kxn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638606773), (object) typeBuilder3.IsCreated()),
                (string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.vAXuJMvBtoyTQU1UCw0E(-345420348 ^ -345181862)
              }));
              num2 = 2;
              continue;
            default:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.kOwavBvB6cxTADYSIv80((object) EntityDynamicProvider.entityDynamicProviderLogger, (object) ((string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.vAXuJMvBtoyTQU1UCw0E(-1822890472 ^ -1822598606) + t.FullName + (string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.vAXuJMvBtoyTQU1UCw0E(1461825605 - 1531863589 ^ -70047478) + (!(t is TypeBuilder typeBuilder4) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538577316) : (string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.C5N6I4vB4JH67Bmg8kxn(EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.vAXuJMvBtoyTQU1UCw0E(1304605005 ^ 1304534807), (object) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.MEX7HavBwSQZajIK2w3d((object) typeBuilder4))) + (string) EntityDynamicProvider.\u003C\u003Ec__DisplayClass15_0.vAXuJMvBtoyTQU1UCw0E(-53329496 >> 4 ^ -3630980)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return entityDynamicProvider.\u003C\u003En__0(t, instance1);
label_5:
        // ISSUE: reference to a compiler-generated method
        return (ICustomTypeDescriptor) new EntityDynamicProvider.CustomTypeDescriptor(t, entityDynamicProvider.\u003C\u003En__0(t, instance1));
      }));
    }

    static EntityDynamicProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityDynamicProvider.providerTypes = (ISet<System.Type>) new HashSet<System.Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 2:
            EntityDynamicProvider.pg8dWShVUiTQCQKHamqB();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
            continue;
          case 3:
            EntityDynamicProvider.entityDynamicProviderLogger = (ILogger) EntityDynamicProvider.ArWCe3hSWlBmlM8Wb5ku(typeof (EntityDynamicProvider));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            EntityDynamicProvider.typeDelegators = PublishCacheContext.CreateCache<System.Type, ICustomTypeDescriptor>((Action<IDictionary<System.Type, ICustomTypeDescriptor>, System.Type, Guid>) ((c, type, _) => c.Remove(type)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 0;
            continue;
          default:
            EntityDynamicProvider.types = PublishCacheContext.CreateCache<System.Type, EntityDynamicProvider.TypeDelegator>();
            num = 5;
            continue;
        }
      }
label_2:;
    }

    internal static bool akLfDAhV5nh06Mcs0b7D() => EntityDynamicProvider.Tu1cFuhVgZIiBXftthqM == null;

    internal static EntityDynamicProvider BcMC2uhVjRThBtTyG8RO() => EntityDynamicProvider.Tu1cFuhVgZIiBXftthqM;

    internal static void ehSbyLhVYB21B8GthfV5([In] object obj0, [In] System.Type obj1) => TypeDescriptor.AddProvider((TypeDescriptionProvider) obj0, obj1);

    internal static void RcqbOShVLAsbs9KSBdIs([In] object obj0, [In] object obj1) => ((BaseTypeDelegator) obj0).InitType((TypeDefinition) obj1);

    internal static void pg8dWShVUiTQCQKHamqB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static System.Type z6EXhehVsyoEBcWjnlvG([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object oMQCvThVctZDE8ThSna8([In] System.Type obj0) => (object) TypeDescriptor.GetProvider(obj0);

    internal static bool Ta5V97hVzYoQ18r8LGha([In] object obj0) => ((Assembly) obj0).IsDynamicAssembly();

    internal static System.Type ITnDXJhSFC6PpHT7jUnv([In] object obj0, [In] System.Type obj1) => __nonvirtual (((TypeDescriptionProvider) obj0).GetRuntimeType(obj1));

    internal static System.Type Tg5YbuhSBIiw9GPixrua([In] object obj0) => ((BaseTypeDelegator) obj0).RuntimeType;

    internal static object ArWCe3hSWlBmlM8Wb5ku(System.Type componentType) => (object) Logger.GetLogger(componentType);

    internal static object seaykUhSoiNtHn0h2YUS([In] object obj0, [In] System.Type obj1, [In] object obj2) => (object) __nonvirtual (((TypeDescriptionProvider) obj0).GetTypeDescriptor(obj1, obj2));

    private class CustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor, ICustomTypeDescriptor
    {
      private readonly object entityType;
      private readonly ConcurrentDictionary<PropertyInfo, PropertyDescriptor> propertyDescriptors;
      private object concatProperties;
      private static object hHPdM8vF7nsiOwvJx2Xo;

      internal CustomTypeDescriptor(System.Type entityType, ICustomTypeDescriptor entityTypeDescriptor)
      {
        EntityDynamicProvider.CustomTypeDescriptor.Lodl9qvFm3wkGgTPdAYK();
        this.propertyDescriptors = new ConcurrentDictionary<PropertyInfo, PropertyDescriptor>();
        // ISSUE: explicit constructor call
        base.\u002Ector(entityTypeDescriptor);
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              this.entityType = !(entityType is EntityDynamicProvider.TypeDelegator typeDelegator) ? (object) EntityDynamicProvider.types[entityType] : (object) typeDelegator;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_5:
        return;
label_3:;
      }

      private IEnumerable<PropertyDescriptor> MetadataProperties => ((EntityDynamicProvider.TypeDelegator) this.entityType).metadataProperties.Values.Select<PropertyInfo, PropertyDescriptor>((Func<PropertyInfo, PropertyDescriptor>) (p => this.propertyDescriptors.GetOrAdd(p, (Func<PropertyInfo, PropertyDescriptor>) (pp => (PropertyDescriptor) new EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor((EntityDynamicProvider.EntityPropertyInfo) pp)))));

      private IEnumerable<PropertyDescriptor> ConcatProperties => (IEnumerable<PropertyDescriptor>) this.concatProperties ?? (IEnumerable<PropertyDescriptor>) (PropertyDescriptor[]) (this.concatProperties = (object) base.GetProperties().Cast<PropertyDescriptor>().Where<PropertyDescriptor>((Func<PropertyDescriptor, bool>) (pd =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (EntityDynamicProvider.CustomTypeDescriptor.jj68YbvFJBPuWVpM5DWT(pd.ComponentType, (System.Type) this.entityType))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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
        return EntityDynamicProvider.CustomTypeDescriptor.jj68YbvFJBPuWVpM5DWT(pd.ComponentType, EntityDynamicProvider.CustomTypeDescriptor.Ax0AJpvF9ySEfm7XtoJs(this.entityType));
label_5:
        return true;
      })).Except<PropertyDescriptor>(this.MetadataProperties, EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.Instance).ToArray<PropertyDescriptor>());

      public override PropertyDescriptorCollection GetProperties()
      {
        int num1 = 3;
        ICustomTypeDescriptor baseTypeDescriptor;
        EntityDynamicProvider.CustomTypeDescriptor customTypeDescriptor;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                object entityType = this.entityType;
                baseTypeDescriptor = (ICustomTypeDescriptor) ((entityType == null ? (System.Type) null : ((System.Type) entityType).BaseType) != (System.Type) null ? EntityDynamicProvider.CustomTypeDescriptor.n8K2qevFMISgOVxdndvb(EntityDynamicProvider.CustomTypeDescriptor.NUojpfvFybTxgiFdIiQG(), ((System.Type) this.entityType).BaseType) : (object) null);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                continue;
              case 2:
                customTypeDescriptor = this;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
                continue;
              case 3:
                goto label_5;
              default:
                goto label_4;
            }
          }
label_5:
          num1 = 2;
        }
label_4:
        return new PropertyDescriptorCollection(this.MetadataProperties.Concat<PropertyDescriptor>(this.ConcatProperties).If<PropertyDescriptor>(baseTypeDescriptor != null, (Func<IEnumerable<PropertyDescriptor>, IEnumerable<PropertyDescriptor>>) (_ => _.Concat<PropertyDescriptor>(baseTypeDescriptor.GetProperties().Cast<PropertyDescriptor>().Except<PropertyDescriptor>(customTypeDescriptor.ConcatProperties, EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.Instance)))).ToArray<PropertyDescriptor>());
      }

      public override PropertyDescriptorCollection GetProperties(Attribute[] attributes) => this.GetProperties();

      internal static void Lodl9qvFm3wkGgTPdAYK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool sYW7a6vFxXu0I7U4ELDk() => EntityDynamicProvider.CustomTypeDescriptor.hHPdM8vF7nsiOwvJx2Xo == null;

      internal static EntityDynamicProvider.CustomTypeDescriptor Jf1IyWvF0tQ7lfUK6AZH() => (EntityDynamicProvider.CustomTypeDescriptor) EntityDynamicProvider.CustomTypeDescriptor.hHPdM8vF7nsiOwvJx2Xo;

      internal static object NUojpfvFybTxgiFdIiQG() => (object) EntityDynamicProvider.Instance;

      internal static object n8K2qevFMISgOVxdndvb([In] object obj0, [In] System.Type obj1) => (object) ((TypeDescriptionProvider) obj0).GetTypeDescriptor(obj1);

      internal static bool jj68YbvFJBPuWVpM5DWT([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

      internal static System.Type Ax0AJpvF9ySEfm7XtoJs([In] object obj0) => ((BaseTypeDelegator) obj0).RuntimeType;

      private class EntityPropertyDescriptor : PropertyDescriptor
      {
        private readonly object propertyInfo;
        internal static object W01soZZigtpkHmBkJgTu;

        public EntityPropertyDescriptor(
          EntityDynamicProvider.EntityPropertyInfo propertyInfo)
        {
          EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor.zbvjThZiYuBLFImGTaxm();
          // ISSUE: explicit constructor call
          base.\u002Ector(propertyInfo.Name, (Attribute[]) null);
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.propertyInfo = (object) propertyInfo;
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

        protected override void FillAttributes(IList attributeList)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                ((MemberInfo) this.propertyInfo).GetCustomAttributes().Max<Attribute>(new Func<Attribute, int>(attributeList.Add));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        public override System.Type ComponentType => EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor.TmG2ThZiLdWIRDyrTJmA(this.propertyInfo);

        public override bool IsReadOnly => !((PropertyInfo) this.propertyInfo).CanWrite;

        public override System.Type PropertyType => EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor.CCen7aZiUvv4kdpSeHvL(this.propertyInfo);

        public override object GetValue(object component) => ((IGetter) ((EntityDynamicProvider.EntityPropertyInfo) this.propertyInfo).Accessor).Get(component);

        public override void SetValue(object component, object value)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor.GV5wqcZiseTymibMJTX8((object) (ISetter) ((EntityDynamicProvider.EntityPropertyInfo) this.propertyInfo).Accessor, component, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        public override bool ShouldSerializeValue(object component) => true;

        public override bool CanResetValue(object component) => false;

        public override void ResetValue(object component)
        {
        }

        internal static void zbvjThZiYuBLFImGTaxm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool Op6eaYZi51SpgN7Sxfqb() => EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor.W01soZZigtpkHmBkJgTu == null;

        internal static EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor RP5pGYZijoQdySxZjRfc() => (EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor) EntityDynamicProvider.CustomTypeDescriptor.EntityPropertyDescriptor.W01soZZigtpkHmBkJgTu;

        internal static System.Type TmG2ThZiLdWIRDyrTJmA([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

        internal static System.Type CCen7aZiUvv4kdpSeHvL([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

        internal static void GV5wqcZiseTymibMJTX8([In] object obj0, [In] object obj1, [In] object obj2) => ((ISetter) obj0).Set(obj1, obj2);
      }

      private class PropertyDescriptorComparer : IEqualityComparer<PropertyDescriptor>
      {
        public static IEqualityComparer<PropertyDescriptor> Instance;
        internal static object e6pxS6ZicINW2PubO3DU;

        public bool Equals(PropertyDescriptor x, PropertyDescriptor y) => EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.bRjYICZRW0ho6hWY0VNR(EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.M52oC3ZRBOoyoCNI48ro((object) x), (object) y.Name);

        public int GetHashCode(PropertyDescriptor obj) => EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.M52oC3ZRBOoyoCNI48ro((object) obj).GetHashCode();

        public PropertyDescriptorComparer()
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
            num = 0;
          switch (num)
          {
          }
        }

        static PropertyDescriptorComparer()
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.Instance = (IEqualityComparer<PropertyDescriptor>) new EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                continue;
              case 2:
                EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.DyGVqKZRoXJEYWU6cfib();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }

        internal static object M52oC3ZRBOoyoCNI48ro([In] object obj0) => (object) ((MemberDescriptor) obj0).Name;

        internal static bool bRjYICZRW0ho6hWY0VNR([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

        internal static bool LS6pUnZizssnJk9W9Kmy() => EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.e6pxS6ZicINW2PubO3DU == null;

        internal static EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer vLwKqTZRFyg8jTMxocyE() => (EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer) EntityDynamicProvider.CustomTypeDescriptor.PropertyDescriptorComparer.e6pxS6ZicINW2PubO3DU;

        internal static void DyGVqKZRoXJEYWU6cfib() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }
    }

    private class TypeDelegator : BaseTypeDelegator
    {
      private readonly bool hasBase;
      internal IDictionary<string, PropertyInfo> metadataProperties;
      private readonly ConcurrentDictionary<IAccessor, PropertyInfo> propertyInfos;
      private readonly ConcurrentDictionary<PropertyInfo, PropertyInfo> reflectedBaseProperties;
      private object baseExceptProperties;
      private object exceptMethods;
      private static object j41j02vFdvRev0bxOq7C;

      public TypeDelegator(System.Type runtimeType)
      {
        EntityDynamicProvider.TypeDelegator.LdOoqjvFg1T6hbHnlEXN();
        this.metadataProperties = PublishCacheContext.CreateCache<string, PropertyInfo>();
        this.propertyInfos = new ConcurrentDictionary<IAccessor, PropertyInfo>();
        this.reflectedBaseProperties = new ConcurrentDictionary<PropertyInfo, PropertyInfo>();
        // ISSUE: explicit constructor call
        base.\u002Ector(runtimeType);
        int num1 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
          num1 = 0;
        while (true)
        {
          int num2;
          System.Type type1;
          System.Type type2;
          switch (num1)
          {
            case 1:
              this.hasBase = !type1.BaseType.IsGenericType || EntityDynamicProvider.TypeDelegator.u9gDuJvFjGVYaJcXI27b(type1.BaseType.GetGenericTypeDefinition(), EntityDynamicProvider.TypeDelegator.vekDskvF5hygG5GnmJfo((object) EleWise.ELMA.SDK.TypeOf.EntityDynamic1)) && EntityDynamicProvider.TypeDelegator.u9gDuJvFjGVYaJcXI27b(type1.BaseType.GetGenericTypeDefinition(), EntityDynamicProvider.TypeDelegator.vekDskvF5hygG5GnmJfo((object) EleWise.ELMA.SDK.TypeOf.Entity1));
              num2 = 5;
              break;
            case 2:
              if (!this.hasBase)
              {
                num1 = 3;
                continue;
              }
              goto case 7;
            case 3:
              goto label_13;
            case 4:
              type2 = (System.Type) null;
              goto label_12;
            case 5:
              goto label_5;
            case 6:
              type2 = runtimeType;
              goto label_16;
            case 7:
              FilterForAttribute customAttribute = runtimeType.GetCustomAttribute<FilterForAttribute>();
              if (customAttribute == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 4 : 4;
                continue;
              }
              type2 = customAttribute.EntityType;
              goto label_12;
            default:
              this.hasBase = this.RuntimeType.BaseType != (System.Type) null;
              num1 = 2;
              continue;
          }
label_2:
          num1 = num2;
          continue;
label_12:
          if ((object) type2 == null)
          {
            num2 = 6;
            goto label_2;
          }
label_16:
          type1 = type2;
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
        }
label_13:
        return;
label_5:;
      }

      public override void InitType(TypeDefinition typeDefinition)
      {
        int num1 = 5;
        Lazy<ISet<string>> lazy;
        Collection<PropertyDefinition>.Enumerator enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              enumerator = typeDefinition.Properties.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_33;
            case 3:
              // ISSUE: reference to a compiler-generated method
              lazy = new Lazy<ISet<string>>((Func<ISet<string>>) (() => (ISet<string>) ((IEnumerable<PropertyInfo>) this.RuntimeType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)).Select<PropertyInfo, string>((Func<PropertyInfo, string>) (p => (string) EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.UNloXEZRKOhLI8nqfHLw((object) p))).ToHashSet<string>()));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
              continue;
            case 4:
              if (typeDefinition != null)
              {
                num1 = 3;
                continue;
              }
              goto label_29;
            case 5:
              base.InitType(typeDefinition);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 4 : 4;
              continue;
            default:
              goto label_7;
          }
        }
label_33:
        return;
label_29:
        return;
label_7:
        try
        {
label_22:
          if (enumerator.MoveNext())
            goto label_14;
          else
            goto label_23;
label_9:
          PropertyDefinition current;
          PropertyInfo propertyInfo;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (!this.metadataProperties.TryGetValue((string) EntityDynamicProvider.TypeDelegator.PvyAghvFY4pDNnGa5cxR((object) current), out propertyInfo))
                {
                  num2 = 8;
                  continue;
                }
                goto case 7;
              case 2:
              case 5:
              case 9:
              case 10:
                goto label_22;
              case 3:
              case 8:
                if (lazy.Value.Contains((string) EntityDynamicProvider.TypeDelegator.PvyAghvFY4pDNnGa5cxR((object) current)))
                {
                  num2 = 12;
                  continue;
                }
                goto case 4;
              case 4:
                this.metadataProperties[current.Name] = (PropertyInfo) new EntityDynamicProvider.EntityPropertyInfo(this.RuntimeType, current);
                num2 = 5;
                continue;
              case 6:
                if (EntityDynamicProvider.TypeDelegator.AgTM77vFspaUry7MeBqt((object) current))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 11 : 0;
                  continue;
                }
                goto label_22;
              case 7:
                EntityDynamicProvider.TypeDelegator.Iax2fPvFL4GcGj7DdAVD((object) (EntityDynamicProvider.EntityPropertyInfo) propertyInfo, (object) current);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 7 : 9;
                continue;
              case 11:
                Collection<Mono.Cecil.CustomAttribute> customAttributes = current.CustomAttributes;
                // ISSUE: reference to a compiler-generated field
                Func<Mono.Cecil.CustomAttribute, bool> func = EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__3_2;
                Func<Mono.Cecil.CustomAttribute, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__3_2 = predicate = (Func<Mono.Cecil.CustomAttribute, bool>) (ca => EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.GFSJIiZRnPEJfk7dL27o(EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.VuVY1OZRT4sf9mGBhFQQ(EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.M57RUxZRXQhAyJDBfQJ2((object) ca)), EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.YakbdaZRkkajE9LfHk06()));
                }
                else
                  goto label_35;
label_27:
                if (!customAttributes.Any<Mono.Cecil.CustomAttribute>(predicate))
                {
                  num2 = 2;
                  continue;
                }
                goto case 4;
label_35:
                predicate = func;
                goto label_27;
              case 12:
                if (!EntityDynamicProvider.TypeDelegator.i90OcuvFUNEnnty0wd5h((object) current))
                {
                  num2 = 10;
                  continue;
                }
                goto case 6;
              case 13:
                goto label_25;
              default:
                goto label_14;
            }
          }
label_25:
          return;
label_14:
          current = enumerator.Current;
          num2 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
          {
            num2 = 1;
            goto label_9;
          }
          else
            goto label_9;
label_23:
          num2 = 13;
          goto label_9;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
      }

      public override System.Type BaseType
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (!this.hasBase)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              default:
                goto label_2;
            }
          }
label_2:
          return this.RuntimeType.BaseType;
label_3:
          return EntityDynamicProvider.TypeDelegator.qgEu4DvFzGr6ZIIfQnPT(EntityDynamicProvider.TypeDelegator.D6IMipvFchZTSpGYmD21(this.RuntimeType.BaseType), this.RuntimeType.BaseType);
        }
      }

      private PropertyInfo GetReflectedBaseProperty(PropertyInfo propertyInfo) => this.reflectedBaseProperties.GetOrAdd(propertyInfo, (Func<PropertyInfo, PropertyInfo>) (p => (PropertyInfo) new PropertyInfoProxy(p, reflectedType: this.RuntimeType)));

      private PropertyInfo[] BaseExceptProperties
      {
        get
        {
          int num = 1;
          PropertyInfo[] array;
          object exceptProperties;
          while (true)
          {
            switch (num)
            {
              case 1:
                exceptProperties = this.baseExceptProperties;
                if (exceptProperties == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              case 2:
                goto label_6;
              default:
                this.baseExceptProperties = (object) (array = ((IEnumerable<PropertyInfo>) this.BaseType.GetProperties(BindingFlags.Instance | BindingFlags.Public)).Intersect<PropertyInfo>((IEnumerable<PropertyInfo>) EntityDynamicProvider.TypeDelegator.rkMBcivBFkwt4fTFdYua((object) this, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public), EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.Instance).ToArray<PropertyInfo>());
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 2;
                continue;
            }
          }
label_2:
          return (PropertyInfo[]) exceptProperties;
label_6:
          return array;
        }
      }

      public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
      {
        int num = 1;
        EntityDynamicProvider.TypeDelegator typeDelegator;
        BindingFlags bindingAttr1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_8;
            case 3:
              bindingAttr1 = bindingAttr;
              num = 5;
              continue;
            case 4:
              goto label_7;
            case 5:
              if (bindingAttr1.HasFlag((Enum) (BindingFlags.Instance | BindingFlags.Public)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 2;
                continue;
              }
              goto label_7;
            default:
              typeDelegator = this;
              num = 3;
              continue;
          }
        }
label_7:
        return base.GetProperties(bindingAttr1);
label_8:
        return this.metadataProperties.Values.Union<PropertyInfo>(this.hasBase ? ((IEnumerable<PropertyInfo>) EntityDynamicProvider.TypeDelegator.rkMBcivBFkwt4fTFdYua((object) this, bindingAttr1 | BindingFlags.DeclaredOnly)).If<PropertyInfo>(!bindingAttr1.HasFlag((Enum) BindingFlags.DeclaredOnly), (Func<IEnumerable<PropertyInfo>, IEnumerable<PropertyInfo>>) (_ => _.Concat<PropertyInfo>(((IEnumerable<PropertyInfo>) typeDelegator.BaseType.GetProperties(bindingAttr1 & ~BindingFlags.Static)).Except<PropertyInfo>((IEnumerable<PropertyInfo>) typeDelegator.BaseExceptProperties).Select<PropertyInfo, PropertyInfo>(new Func<PropertyInfo, PropertyInfo>(typeDelegator.GetReflectedBaseProperty))))) : (IEnumerable<PropertyInfo>) base.GetProperties(bindingAttr1), EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.Instance).ToArray<PropertyInfo>();
      }

      protected override PropertyInfo GetPropertyImpl(
        string name,
        BindingFlags bindingAttr,
        Binder binder,
        System.Type returnType,
        System.Type[] types,
        ParameterModifier[] modifiers)
      {
        int num1 = 36;
        PropertyInfo propertyImpl1;
        PropertyInfo[] array;
        PropertyInfo propertyImpl2;
        object obj;
        System.Type[] types1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            int index1;
            int num3;
            int index2;
            ParameterInfo[] indexParameters;
            int num4;
            string name1;
            bool ignoreCase;
            switch (num2)
            {
              case 1:
              case 4:
                if (index2 < array.Length)
                {
                  num2 = 30;
                  continue;
                }
                goto label_9;
              case 2:
                num4 = 0;
                goto label_61;
              case 3:
              case 28:
                ++index2;
                num2 = 4;
                continue;
              case 5:
                if (types1.Length == 0)
                {
                  num2 = 37;
                  continue;
                }
                break;
              case 6:
              case 23:
                if (!(propertyImpl1 != (PropertyInfo) null))
                {
                  num2 = 21;
                  continue;
                }
                goto label_12;
              case 7:
                if (array.Length != 0)
                {
                  num2 = 31;
                  continue;
                }
                goto label_43;
              case 8:
              case 38:
                if (index1 >= num3)
                {
                  num2 = 13;
                  continue;
                }
                goto case 15;
              case 9:
                index2 = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                continue;
              case 10:
                goto label_29;
              case 11:
                if (types1 != null)
                {
                  num2 = 41;
                  continue;
                }
                goto case 2;
              case 12:
                goto label_51;
              case 13:
              case 26:
                if (index1 < num3)
                {
                  num2 = 3;
                  continue;
                }
                goto case 34;
              case 14:
                EntityDynamicProvider.TypeDelegator.hSKmUAvBW1ZhVLA6MWdh((object) name1, EntityDynamicProvider.TypeDelegator.pJdceWvBBjAs1TmbxpNP(-882126494 ^ -882123404));
                num2 = 39;
                continue;
              case 15:
                if (EntityDynamicProvider.TypeDelegator.u9gDuJvFjGVYaJcXI27b(EntityDynamicProvider.TypeDelegator.v9lELEvBGLJKbBCO6OEy((object) indexParameters[index1]), types1[index1]))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 15 : 26;
                  continue;
                }
                goto case 24;
              case 16:
                goto label_33;
              case 17:
                if (!EntityDynamicProvider.TypeDelegator.u9gDuJvFjGVYaJcXI27b(returnType, EntityDynamicProvider.TypeDelegator.pKa7wGvBoFbKhTcIjvSQ((object) array[index2])))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 23 : 4;
                  continue;
                }
                goto case 3;
              case 18:
                goto label_15;
              case 19:
                goto label_12;
              case 20:
              case 33:
                goto label_16;
              case 21:
                propertyImpl1 = array[index2];
                num2 = 28;
                continue;
              case 22:
                propertyImpl2 = array[0];
                num2 = 42;
                continue;
              case 24:
                ++index1;
                num2 = 38;
                continue;
              case 25:
                index1 = 0;
                num2 = 8;
                continue;
              case 27:
                obj = (object) binder;
                if (obj == null)
                {
                  num2 = 32;
                  continue;
                }
                goto label_58;
              case 29:
                array = ((IEnumerable<PropertyInfo>) this.GetProperties(bindingAttr)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
                {
                  int num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!EntityDynamicProvider.TypeDelegator.\u003C\u003Ec__DisplayClass13_0.fKOmI8ZRaRj8sKtFvCDj(EntityDynamicProvider.TypeDelegator.\u003C\u003Ec__DisplayClass13_0.suBLL3ZRpuxJ01afIxA5((object) p), (object) name1, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                          continue;
                        }
                        goto case 3;
                      case 2:
                        goto label_5;
                      case 3:
                        if (types1 == null)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
                          continue;
                        }
                        goto label_4;
                      case 4:
                        goto label_4;
                      default:
                        goto label_6;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return EntityDynamicProvider.TypeDelegator.\u003C\u003Ec__DisplayClass13_0.jOQ4HeZRDc9SMjxW2Vfb((object) p).Length == types1.Length;
label_5:
                  return true;
label_6:
                  return false;
                })).ToArray<PropertyInfo>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 7 : 6;
                continue;
              case 31:
                if (types1 != null)
                {
                  num2 = 5;
                  continue;
                }
                goto case 37;
              case 32:
                goto label_57;
              case 34:
                if (!(returnType != (System.Type) null))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 6;
                  continue;
                }
                goto case 17;
              case 35:
                name1 = name;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 16;
                continue;
              case 36:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 35 : 16;
                continue;
              case 37:
                if (array.Length != 1)
                {
                  if (returnType == (System.Type) null)
                  {
                    num2 = 12;
                    continue;
                  }
                  break;
                }
                num2 = 22;
                continue;
              case 39:
                ignoreCase = bindingAttr.HasFlag((Enum) BindingFlags.IgnoreCase);
                num2 = 29;
                continue;
              case 40:
                goto label_9;
              case 41:
                num4 = types1.Length;
                goto label_61;
              case 42:
                if (!(returnType != (System.Type) null))
                {
                  num2 = 20;
                  continue;
                }
                goto label_29;
              case 43:
                goto label_43;
              default:
                indexParameters = array[index2].GetIndexParameters();
                num2 = 25;
                continue;
            }
            if (!bindingAttr.HasFlag((Enum) BindingFlags.ExactBinding))
            {
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 27 : 26;
              continue;
            }
            propertyImpl1 = (PropertyInfo) null;
            num2 = 11;
            continue;
label_61:
            num3 = num4;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 6 : 9;
          }
label_29:
          if (returnType.IsEquivalentTo(EntityDynamicProvider.TypeDelegator.pKa7wGvBoFbKhTcIjvSQ((object) propertyImpl2)))
          {
            num1 = 33;
            continue;
          }
          goto label_15;
label_33:
          types1 = types;
          num1 = 14;
        }
label_9:
        return propertyImpl1;
label_12:
        throw new AmbiguousMatchException();
label_15:
        return (PropertyInfo) null;
label_16:
        return propertyImpl2;
label_43:
        return (PropertyInfo) null;
label_51:
        throw new AmbiguousMatchException();
label_57:
        obj = EntityDynamicProvider.TypeDelegator.ob6lLIvBb7XI3N2Kw73P();
label_58:
        return (PropertyInfo) EntityDynamicProvider.TypeDelegator.yFuIvkvBhGvB3a2lXyop(obj, bindingAttr, (object) array, returnType, (object) types1, (object) modifiers);
      }

      private MethodInfo[] ExceptMethods
      {
        get
        {
          int num = 1;
          MethodInfo[] array;
          object exceptMethods;
          while (true)
          {
            switch (num)
            {
              case 1:
                exceptMethods = this.exceptMethods;
                if (exceptMethods == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              case 2:
                goto label_8;
              default:
                object source = EntityDynamicProvider.TypeDelegator.rkMBcivBFkwt4fTFdYua((object) this, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                Func<PropertyInfo, IEnumerable<MethodInfo>> func = EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__17_0;
                Func<PropertyInfo, IEnumerable<MethodInfo>> selector;
                if (func == null)
                  EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__17_0 = selector = (Func<PropertyInfo, IEnumerable<MethodInfo>>) (p => (IEnumerable<MethodInfo>) p.GetAccessors());
                else
                  goto label_9;
label_7:
                this.exceptMethods = (object) (array = ((IEnumerable<PropertyInfo>) source).SelectMany<PropertyInfo, MethodInfo>(selector).ToArray<MethodInfo>());
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 0;
                continue;
label_9:
                selector = func;
                goto label_7;
            }
          }
label_5:
          return (MethodInfo[]) exceptMethods;
label_8:
          return array;
        }
      }

      public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (bindingAttr.HasFlag((Enum) (BindingFlags.Instance | BindingFlags.Public)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return (MethodInfo[]) EntityDynamicProvider.TypeDelegator.d8hYn3vBEh68i59jNL9a((object) this, bindingAttr);
label_5:
        PropertyInfo[] properties = this.GetProperties(bindingAttr);
        // ISSUE: reference to a compiler-generated field
        Func<PropertyInfo, IEnumerable<MethodInfo>> func = EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__18_0;
        Func<PropertyInfo, IEnumerable<MethodInfo>> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          EntityDynamicProvider.TypeDelegator.\u003C\u003Ec.\u003C\u003E9__18_0 = selector = (Func<PropertyInfo, IEnumerable<MethodInfo>>) (p => (IEnumerable<MethodInfo>) p.GetAccessors());
        }
        else
          goto label_6;
label_8:
        return ((IEnumerable<PropertyInfo>) properties).SelectMany<PropertyInfo, MethodInfo>(selector).Concat<MethodInfo>(((IEnumerable<MethodInfo>) EntityDynamicProvider.TypeDelegator.d8hYn3vBEh68i59jNL9a((object) this, bindingAttr)).Except<MethodInfo>((IEnumerable<MethodInfo>) this.ExceptMethods)).ToArray<MethodInfo>();
label_6:
        selector = func;
        goto label_8;
      }

      protected override MethodInfo GetMethodImpl(
        string name,
        BindingFlags bindingAttr,
        Binder binder,
        CallingConventions callConvention,
        System.Type[] types,
        ParameterModifier[] modifiers)
      {
        int num1 = 10;
        MethodInfo methodImpl;
        MethodBase[] match;
        MethodInfo[] array;
        BindingFlags bindingAttr1;
        System.Type[] types1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            int index;
            string name1;
            bool ignoreCase;
            CallingConventions callConvention1;
            switch (num2)
            {
              case 1:
              case 6:
                if (((IEnumerable<ParameterInfo>) array[index].GetParameters()).SequenceEqual<ParameterInfo>((IEnumerable<ParameterInfo>) methodImpl.GetParameters()))
                {
                  ++index;
                  num2 = 8;
                  continue;
                }
                num2 = 2;
                continue;
              case 2:
                goto label_9;
              case 3:
              case 18:
                goto label_16;
              case 4:
              case 8:
                if (index < array.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                  continue;
                }
                goto label_11;
              case 5:
                if (array.Length != 1)
                {
                  if (types1 != null)
                  {
                    num2 = 25;
                    continue;
                  }
                  break;
                }
                num2 = 11;
                continue;
              case 7:
                array = ((IEnumerable<MethodInfo>) this.GetMethods(bindingAttr1)).Where<MethodInfo>((Func<MethodInfo, bool>) (m =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!EntityDynamicProvider.TypeDelegator.\u003C\u003Ec__DisplayClass19_0.qx6YvZZRAlarG5iZQtu2(EntityDynamicProvider.TypeDelegator.\u003C\u003Ec__DisplayClass19_0.d652PfZRHqKxCGultY7l((object) m), (object) name1, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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
                  return EntityDynamicProvider.TypeDelegator.FilterApplyMethodBase((object) m, bindingAttr1, callConvention1, (object) types1);
label_3:
                  return false;
                })).ToArray<MethodInfo>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 15 : 26;
                continue;
              case 9:
                name1 = name;
                num2 = 15;
                continue;
              case 10:
                num2 = 9;
                continue;
              case 11:
                goto label_3;
              case 12:
                ignoreCase = bindingAttr1.HasFlag((Enum) BindingFlags.IgnoreCase);
                num2 = 7;
                continue;
              case 13:
                EntityDynamicProvider.TypeDelegator.hSKmUAvBW1ZhVLA6MWdh((object) name1, EntityDynamicProvider.TypeDelegator.pJdceWvBBjAs1TmbxpNP(-35995181 ^ -35992123));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 10 : 12;
                continue;
              case 14:
                callConvention1 = callConvention;
                num2 = 17;
                continue;
              case 15:
                bindingAttr1 = bindingAttr;
                num2 = 14;
                continue;
              case 16:
                goto label_6;
              case 17:
                types1 = types;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 13 : 8;
                continue;
              case 19:
                goto label_27;
              case 20:
                methodImpl = array[0];
                num2 = 5;
                continue;
              case 21:
                if (types1.Length != 0)
                {
                  num2 = 24;
                  continue;
                }
                goto case 20;
              case 22:
                goto label_19;
              case 23:
                goto label_11;
              case 24:
              case 25:
                if (binder != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
                  continue;
                }
                goto label_27;
              case 26:
                if (array.Length != 0)
                {
                  if (types1 != null)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 21;
                    continue;
                  }
                  goto case 20;
                }
                else
                {
                  num2 = 22;
                  continue;
                }
            }
            index = 1;
            num2 = 4;
          }
label_11:
          match = (MethodBase[]) array;
          num1 = 16;
          continue;
label_27:
          binder = (Binder) EntityDynamicProvider.TypeDelegator.ob6lLIvBb7XI3N2Kw73P();
          num1 = 18;
        }
label_3:
        return methodImpl;
label_6:
        return EntityDynamicProvider.TypeDelegator.FindMostDerivedNewSlotMeth((object) match) as MethodInfo;
label_9:
        throw new AmbiguousMatchException();
label_16:
        return EntityDynamicProvider.TypeDelegator.FEPuPpvBfBvlAccbKoDd((object) binder, bindingAttr1, (object) (MethodBase[]) array, (object) types1, (object) modifiers) as MethodInfo;
label_19:
        return (MethodInfo) null;
      }

      private static bool FilterApplyMethodBase(
        object methodBase,
        BindingFlags bindingFlags,
        CallingConventions callConv,
        object argumentTypes)
      {
        int num = 12;
        while (true)
        {
          ParameterInfo parameterInfo;
          bool flag;
          ParameterInfo[] parameterInfoArray;
          int index;
          switch (num)
          {
            case 1:
              flag = true;
              num = 36;
              continue;
            case 2:
            case 38:
              flag = true;
              num = 23;
              continue;
            case 4:
              if ((object) EntityDynamicProvider.TypeDelegator.v9lELEvBGLJKbBCO6OEy((object) parameterInfoArray[index]) != argumentTypes[index])
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 13;
                continue;
              }
              goto label_19;
            case 6:
label_53:
              parameterInfoArray = (ParameterInfo[]) EntityDynamicProvider.TypeDelegator.LV5mIBvBCA8e5YJnpXMP(methodBase);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 11 : 29;
              continue;
            case 7:
              if (EntityDynamicProvider.TypeDelegator.v9lELEvBGLJKbBCO6OEy((object) parameterInfo).IsArray)
              {
                num = 34;
                continue;
              }
              goto label_27;
            case 8:
            case 9:
              goto label_6;
            case 10:
              if (!EntityDynamicProvider.TypeDelegator.pkmfd6vBQwQojcHpeMtJ(methodBase).HasFlag((Enum) CallingConventions.Standard))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 6 : 9;
                continue;
              }
              break;
            case 11:
              if (!callConv.HasFlag((Enum) CallingConventions.Any))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 25 : 39;
                continue;
              }
              break;
            case 12:
              bindingFlags ^= BindingFlags.DeclaredOnly;
              num = 11;
              continue;
            case 13:
              goto label_18;
            case 15:
              if (!EntityDynamicProvider.TypeDelegator.pkmfd6vBQwQojcHpeMtJ(methodBase).HasFlag((Enum) CallingConventions.VarArgs))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
                continue;
              }
              goto case 21;
            case 16:
              if (!EntityDynamicProvider.TypeDelegator.pkmfd6vBQwQojcHpeMtJ(methodBase).HasFlag((Enum) CallingConventions.VarArgs))
              {
                num = 8;
                continue;
              }
              goto case 19;
            case 17:
              if (argumentTypes.Length <= parameterInfoArray.Length)
              {
                num = 33;
                continue;
              }
              goto case 15;
            case 18:
            case 28:
              if (index >= parameterInfoArray.Length)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 4;
                continue;
              }
              goto case 26;
            case 19:
              if (callConv.HasFlag((Enum) CallingConventions.Standard))
              {
                num = 10;
                continue;
              }
              break;
            case 20:
              goto label_56;
            case 21:
            case 23:
            case 36:
              if (flag)
              {
                num = 27;
                continue;
              }
              goto label_45;
            case 22:
              if (bindingFlags.HasFlag((Enum) (BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetProperty | BindingFlags.SetProperty)))
              {
                flag = false;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 15 : 17;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 31 : 21;
              continue;
            case 24:
              goto label_27;
            case 25:
              if (EntityDynamicProvider.TypeDelegator.BaXUZavBvRA99PtiTmlj((object) parameterInfoArray[argumentTypes.Length]))
              {
                num = 21;
                continue;
              }
              goto case 2;
            case 26:
              if (EntityDynamicProvider.TypeDelegator.u9gDuJvFjGVYaJcXI27b((System.Type) argumentTypes[index], (System.Type) null))
              {
                num = 4;
                continue;
              }
              goto label_19;
            case 27:
              if (parameterInfoArray.Length == 0)
              {
                num = 20;
                continue;
              }
              if (argumentTypes.Length >= parameterInfoArray.Length - 1)
              {
                parameterInfo = parameterInfoArray[parameterInfoArray.Length - 1];
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 7;
                continue;
              }
              num = 37;
              continue;
            case 29:
              if (argumentTypes.Length != parameterInfoArray.Length)
              {
                num = 22;
                continue;
              }
              if (!bindingFlags.HasFlag((Enum) BindingFlags.ExactBinding))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              }
              goto case 30;
            case 30:
              if (!bindingFlags.HasFlag((Enum) BindingFlags.InvokeMethod))
              {
                num = 35;
                continue;
              }
              goto label_45;
            case 31:
              goto label_9;
            case 32:
            case 33:
              if (!bindingFlags.HasFlag((Enum) BindingFlags.OptionalParamBinding))
              {
                num = 2;
                continue;
              }
              goto case 25;
            case 34:
              // ISSUE: type reference
              if (parameterInfo.IsDefined(EntityDynamicProvider.TypeDelegator.DKeLeQvB8H0v1tHVEE47(__typeref (ParamArrayAttribute)), false))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 3 : 3;
                continue;
              }
              goto label_27;
            case 35:
              index = 0;
              num = 18;
              continue;
            case 37:
              goto label_22;
            case 39:
              if (callConv.HasFlag((Enum) CallingConventions.VarArgs))
              {
                num = 16;
                continue;
              }
              goto case 19;
            default:
              goto label_45;
          }
          if (argumentTypes == null)
          {
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 14;
            continue;
          }
          goto label_53;
label_19:
          ++index;
          num = 28;
        }
label_6:
        return false;
label_9:
        return false;
label_18:
        return false;
label_22:
        return false;
label_27:
        return false;
label_45:
        return true;
label_56:
        return false;
      }

      private static MethodBase FindMostDerivedNewSlotMeth(object match)
      {
        int num1 = 3;
        MethodBase derivedNewSlotMeth;
        while (true)
        {
          int num2 = num1;
          int index;
          int num3;
          int num4;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_9;
              case 2:
                derivedNewSlotMeth = (MethodBase) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 8 : 1;
                continue;
              case 3:
                num3 = 0;
                num2 = 2;
                continue;
              case 5:
              case 10:
                if (index >= match.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
                  continue;
                }
                goto case 12;
              case 6:
                if (num4 != num3)
                {
                  if (num4 <= num3)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                    continue;
                  }
                  goto case 9;
                }
                else
                  goto label_17;
              case 7:
                goto label_6;
              case 8:
                index = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 5 : 2;
                continue;
              case 9:
                num3 = num4;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 11;
                continue;
              case 11:
                derivedNewSlotMeth = (MethodBase) match[index];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 0;
                continue;
              case 12:
                num4 = EntityDynamicProvider.TypeDelegator.RhwExBvBZ02v6gIOD1TI(((MemberInfo) match[index]).DeclaringType);
                num2 = 6;
                continue;
              default:
                ++index;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 10 : 3;
                continue;
            }
          }
label_17:
          num1 = 7;
        }
label_6:
        throw new AmbiguousMatchException();
label_9:
        return derivedNewSlotMeth;
      }

      private static int GetHierarchyDepth(System.Type t)
      {
        int num = 2;
        System.Type type;
        int hierarchyDepth;
        while (true)
        {
          switch (num)
          {
            case 1:
              type = t;
              num = 3;
              continue;
            case 2:
              hierarchyDepth = 0;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
              continue;
            case 3:
              ++hierarchyDepth;
              num = 4;
              continue;
            case 4:
              type = type.BaseType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_7;
            default:
              if (!EntityDynamicProvider.TypeDelegator.u9gDuJvFjGVYaJcXI27b(type, (System.Type) null))
              {
                num = 5;
                continue;
              }
              goto case 3;
          }
        }
label_7:
        return hierarchyDepth;
      }

      internal static void LdOoqjvFg1T6hbHnlEXN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static System.Type vekDskvF5hygG5GnmJfo([In] object obj0) => ((RipeType) obj0).Raw;

      internal static bool u9gDuJvFjGVYaJcXI27b([In] System.Type obj0, [In] System.Type obj1) => obj0 != obj1;

      internal static bool kPGA7HvFlG4nbgi4skRA() => EntityDynamicProvider.TypeDelegator.j41j02vFdvRev0bxOq7C == null;

      internal static EntityDynamicProvider.TypeDelegator b20QWPvFrHXoPLUdZ0Bb() => (EntityDynamicProvider.TypeDelegator) EntityDynamicProvider.TypeDelegator.j41j02vFdvRev0bxOq7C;

      internal static object PvyAghvFY4pDNnGa5cxR([In] object obj0) => (object) ((MemberReference) obj0).Name;

      internal static void Iax2fPvFL4GcGj7DdAVD([In] object obj0, [In] object obj1) => ((EntityDynamicProvider.EntityPropertyInfo) obj0).UpdateCustomAttributes((PropertyDefinition) obj1);

      internal static bool i90OcuvFUNEnnty0wd5h([In] object obj0) => ((PropertyDefinition) obj0).HasThis;

      internal static bool AgTM77vFspaUry7MeBqt([In] object obj0) => ((PropertyDefinition) obj0).HasCustomAttributes;

      internal static object D6IMipvFchZTSpGYmD21([In] System.Type obj0) => (object) TypeDescriptor.GetProvider(obj0);

      internal static System.Type qgEu4DvFzGr6ZIIfQnPT([In] object obj0, [In] System.Type obj1) => ((TypeDescriptionProvider) obj0).GetReflectionType(obj1);

      internal static object rkMBcivBFkwt4fTFdYua([In] object obj0, [In] BindingFlags obj1) => (object) __nonvirtual (((System.Reflection.TypeDelegator) obj0).GetProperties(obj1));

      internal static object pJdceWvBBjAs1TmbxpNP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void hSKmUAvBW1ZhVLA6MWdh([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

      internal static System.Type pKa7wGvBoFbKhTcIjvSQ([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

      internal static object ob6lLIvBb7XI3N2Kw73P() => (object) System.Type.DefaultBinder;

      internal static object yFuIvkvBhGvB3a2lXyop(
        [In] object obj0,
        [In] BindingFlags obj1,
        [In] object obj2,
        [In] System.Type obj3,
        [In] object obj4,
        [In] object obj5)
      {
        return (object) ((Binder) obj0).SelectProperty(obj1, (PropertyInfo[]) obj2, obj3, (System.Type[]) obj4, (ParameterModifier[]) obj5);
      }

      internal static System.Type v9lELEvBGLJKbBCO6OEy([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

      internal static object d8hYn3vBEh68i59jNL9a([In] object obj0, [In] BindingFlags obj1) => (object) __nonvirtual (((System.Reflection.TypeDelegator) obj0).GetMethods(obj1));

      internal static object FEPuPpvBfBvlAccbKoDd(
        [In] object obj0,
        [In] BindingFlags obj1,
        [In] object obj2,
        [In] object obj3,
        [In] object obj4)
      {
        return (object) ((Binder) obj0).SelectMethod(obj1, (MethodBase[]) obj2, (System.Type[]) obj3, (ParameterModifier[]) obj4);
      }

      internal static CallingConventions pkmfd6vBQwQojcHpeMtJ([In] object obj0) => ((MethodBase) obj0).CallingConvention;

      internal static object LV5mIBvBCA8e5YJnpXMP([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

      internal static bool BaXUZavBvRA99PtiTmlj([In] object obj0) => ((ParameterInfo) obj0).IsOptional;

      internal static System.Type DKeLeQvB8H0v1tHVEE47([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

      internal static int RhwExBvBZ02v6gIOD1TI(System.Type t) => EntityDynamicProvider.TypeDelegator.GetHierarchyDepth(t);

      private class PropertyInfoComparer : IEqualityComparer<PropertyInfo>
      {
        public static IEqualityComparer<PropertyInfo> Instance;
        internal static object p7MwjmZR8hprF4e3Ay3k;

        public bool Equals(PropertyInfo x, PropertyInfo y) => (string) EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.EIPoPGZRIaUy9fvak6Rp((object) x) == (string) EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.EIPoPGZRIaUy9fvak6Rp((object) y);

        public int GetHashCode(PropertyInfo obj) => EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.EIPoPGZRIaUy9fvak6Rp((object) obj).GetHashCode();

        public PropertyInfoComparer()
        {
          EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.JMj9slZRVBomtJS0F0fS();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
            num = 0;
          switch (num)
          {
          }
        }

        static PropertyInfoComparer()
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.JMj9slZRVBomtJS0F0fS();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.Instance = (IEqualityComparer<PropertyInfo>) new EntityDynamicProvider.TypeDelegator.PropertyInfoComparer();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 0;
                continue;
            }
          }
label_2:;
        }

        internal static object EIPoPGZRIaUy9fvak6Rp([In] object obj0) => (object) ((MemberInfo) obj0).Name;

        internal static bool hdHf0lZRZ8myXK9KnwDT() => EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.p7MwjmZR8hprF4e3Ay3k == null;

        internal static EntityDynamicProvider.TypeDelegator.PropertyInfoComparer VDxlHfZRu9fYJHcFvkfp() => (EntityDynamicProvider.TypeDelegator.PropertyInfoComparer) EntityDynamicProvider.TypeDelegator.PropertyInfoComparer.p7MwjmZR8hprF4e3Ay3k;

        internal static void JMj9slZRVBomtJS0F0fS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }
    }

    internal class EntityPropertyInfo : PropertyInfo
    {
      private readonly ParameterInfo[] indexParameters;
      private readonly TypeReference propertyTypeReference;
      private System.Type propertyType;
      private MethodInfo getMethod;
      private MethodInfo setMethod;
      private MethodInfo[] accessors;
      private IAccessor accessor;
      private PublishCacheContext.Local<CustomAttributesData> customAttributesData;
      private static EntityDynamicProvider.EntityPropertyInfo oY1qMpvBuYsQ8qKH1v2o;

      internal EntityPropertyInfo(System.Type runtimeType, PropertyDefinition propertyDefinition)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.indexParameters = new ParameterInfo[0];
        this.customAttributesData = new PublishCacheContext.Local<CustomAttributesData>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.Name = (string) EntityDynamicProvider.EntityPropertyInfo.cSH7dsvBSfgq8nU4mIEo((object) propertyDefinition);
              num = 4;
              continue;
            case 2:
              this.DeclaringType = runtimeType;
              num = 7;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.propertyTypeReference = (TypeReference) EntityDynamicProvider.EntityPropertyInfo.OgyxEkvBiSu464kgttYn((object) propertyDefinition.PropertyType);
              num = 6;
              continue;
            case 5:
              this.UpdateCustomAttributes(propertyDefinition);
              num = 3;
              continue;
            case 6:
              this.CanRead = propertyDefinition.GetMethod != null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            case 7:
              this.ReflectedType = runtimeType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
              continue;
            default:
              this.CanWrite = EntityDynamicProvider.EntityPropertyInfo.oI5MiFvBRUT64lURmohB((object) propertyDefinition) != null;
              num = 5;
              continue;
          }
        }
label_3:;
      }

      public override System.Type DeclaringType { get; }

      public override System.Type ReflectedType { get; }

      public override string Name { get; }

      public override System.Type PropertyType
      {
        get
        {
          int num = 2;
          System.Type propertyType1;
          System.Type propertyType2;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.propertyType = propertyType1 = EntityDynamicGenerator.Resolve(this.propertyTypeReference);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              case 2:
                propertyType2 = this.propertyType;
                if ((object) propertyType2 == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              default:
                goto label_6;
            }
          }
label_2:
          return propertyType2;
label_6:
          return propertyType1;
        }
      }

      public override bool CanRead { get; }

      public override bool CanWrite { get; }

      public override System.Reflection.PropertyAttributes Attributes => System.Reflection.PropertyAttributes.None;

      public override Module Module => EntityDynamicProvider.EntityPropertyInfo.dwnZluvBqcyKZbLWe5SB((object) this).Module;

      public override object GetValue(
        object obj,
        BindingFlags invokeAttr,
        Binder binder,
        object[] index,
        CultureInfo culture)
      {
        return EntityDynamicProvider.EntityPropertyInfo.TRLZ60vBX1w1K4hNYI8H(EntityDynamicProvider.EntityPropertyInfo.I4fUF5vBKrbH08ELFcJe((object) this), obj, (object) null);
      }

      public override void SetValue(
        object obj,
        object value,
        BindingFlags invokeAttr,
        Binder binder,
        object[] index,
        CultureInfo culture)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityDynamicProvider.EntityPropertyInfo.TRLZ60vBX1w1K4hNYI8H((object) this.SetMethod, obj, (object) new object[1]
              {
                value
              });
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public override ParameterInfo[] GetIndexParameters() => this.indexParameters;

      public override string ToString() => (string) EntityDynamicProvider.EntityPropertyInfo.W13xf4vBnP69rWrqrboM(EntityDynamicProvider.EntityPropertyInfo.NKnA2svBTET25WXFcKRi(-1710575414 ^ -1710535014), (object) EntityDynamicProvider.EntityPropertyInfo.kaIWg1vBkW0sYynacL2b((object) this), (object) this.Name);

      public override MethodInfo GetGetMethod(bool nonPublic)
      {
        int num = 1;
        MethodInfo getMethod1;
        MethodInfo getMethod2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!EntityDynamicProvider.EntityPropertyInfo.m9rVp7vBOu35AMBKAyWg((object) this))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              goto label_8;
            case 3:
              this.getMethod = getMethod1 = (MethodInfo) new EntityGetPropertyMethodInfo(EntityDynamicProvider.EntityPropertyInfo.dwnZluvBqcyKZbLWe5SB((object) this), this.ReflectedType, (string) EntityDynamicProvider.EntityPropertyInfo.eppuLHvB2RcWtGkdNAI2((object) this), EntityDynamicProvider.EntityPropertyInfo.kaIWg1vBkW0sYynacL2b((object) this), (IGetter) this.Accessor);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 2 : 2;
              continue;
            case 4:
              getMethod2 = this.getMethod;
              if ((object) getMethod2 == null)
              {
                num = 3;
                continue;
              }
              goto label_7;
            default:
              goto label_9;
          }
        }
label_7:
        return getMethod2;
label_8:
        return getMethod1;
label_9:
        return (MethodInfo) null;
      }

      public override MethodInfo GetSetMethod(bool nonPublic)
      {
        int num = 4;
        MethodInfo setMethod1;
        MethodInfo setMethod2;
        while (true)
        {
          switch (num)
          {
            case 1:
              setMethod2 = this.setMethod;
              if ((object) setMethod2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 2;
                continue;
              }
              goto label_2;
            case 2:
              this.setMethod = setMethod1 = (MethodInfo) new EntitySetPropertyMethodInfo(this.DeclaringType, EntityDynamicProvider.EntityPropertyInfo.z8UnhJvBPvKDikq98HEE((object) this), (string) EntityDynamicProvider.EntityPropertyInfo.eppuLHvB2RcWtGkdNAI2((object) this), this.PropertyType, (ISetter) this.Accessor);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_9;
            case 4:
              if (!EntityDynamicProvider.EntityPropertyInfo.TgXmF2vBePX6ORcxVi0l((object) this))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 0;
                continue;
              }
              goto case 1;
            default:
              goto label_8;
          }
        }
label_2:
        return setMethod2;
label_8:
        return setMethod1;
label_9:
        return (MethodInfo) null;
      }

      public override MethodInfo[] GetAccessors(bool nonPublic)
      {
        int num = 1;
        MethodInfo[] accessors1;
        MethodInfo[] accessors2;
        while (true)
        {
          switch (num)
          {
            case 1:
              accessors2 = this.accessors;
              if (accessors2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_11;
            default:
              MethodInfo[] methodInfoArray;
              if (EntityDynamicProvider.EntityPropertyInfo.TgXmF2vBePX6ORcxVi0l((object) this))
              {
                if (EntityDynamicProvider.EntityPropertyInfo.m9rVp7vBOu35AMBKAyWg((object) this))
                  methodInfoArray = new MethodInfo[2]
                  {
                    this.GetMethod,
                    (MethodInfo) EntityDynamicProvider.EntityPropertyInfo.bU6HTPvB1xQv7j7U5jpj((object) this)
                  };
                else
                  methodInfoArray = new MethodInfo[1]
                  {
                    (MethodInfo) EntityDynamicProvider.EntityPropertyInfo.bU6HTPvB1xQv7j7U5jpj((object) this)
                  };
              }
              else
                methodInfoArray = new MethodInfo[1]
                {
                  (MethodInfo) EntityDynamicProvider.EntityPropertyInfo.I4fUF5vBKrbH08ELFcJe((object) this)
                };
              accessors1 = methodInfoArray;
              this.accessors = methodInfoArray;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
              continue;
          }
        }
label_3:
        return accessors2;
label_11:
        return accessors1;
      }

      internal IAccessor Accessor
      {
        get
        {
          int num = 1;
          IAccessor accessor1;
          IAccessor accessor2;
          while (true)
          {
            switch (num)
            {
              case 1:
                accessor2 = this.accessor;
                if (accessor2 == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              case 2:
                goto label_6;
              default:
                this.accessor = accessor1 = (IAccessor) EntityDynamicProvider.EntityPropertyInfo.GcA65evBNUdLoUjNoUSI(this.DeclaringType, (object) this.Name, true);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 2;
                continue;
            }
          }
label_2:
          return accessor2;
label_6:
          return accessor1;
        }
      }

      public override IList<CustomAttributeData> GetCustomAttributesData() => this.customAttributesData.Value.GetCustomAttributesData();

      public override bool IsDefined(System.Type attributeType, bool inherit) => this.customAttributesData.Value.IsDefined(attributeType, inherit);

      public override object[] GetCustomAttributes(bool inherit) => this.customAttributesData.Value.GetCustomAttributes(inherit);

      public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) => this.customAttributesData.Value.GetCustomAttributes(attributeType, inherit);

      internal void UpdateCustomAttributes(PropertyDefinition propertyDefinition)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.customAttributesData.Value = new CustomAttributesData((ICollection<Mono.Cecil.CustomAttribute>) propertyDefinition.CustomAttributes);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static object cSH7dsvBSfgq8nU4mIEo([In] object obj0) => (object) ((MemberReference) obj0).Name;

      internal static object OgyxEkvBiSu464kgttYn([In] object obj0) => (object) EntityDynamicGenerator.CreateReference((TypeReference) obj0);

      internal static object oI5MiFvBRUT64lURmohB([In] object obj0) => (object) ((PropertyDefinition) obj0).SetMethod;

      internal static bool faQqdFvBINe81UuEMvBq() => EntityDynamicProvider.EntityPropertyInfo.oY1qMpvBuYsQ8qKH1v2o == null;

      internal static EntityDynamicProvider.EntityPropertyInfo bEnSo9vBVfoB3RSM6pWn() => EntityDynamicProvider.EntityPropertyInfo.oY1qMpvBuYsQ8qKH1v2o;

      internal static System.Type dwnZluvBqcyKZbLWe5SB([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

      internal static object I4fUF5vBKrbH08ELFcJe([In] object obj0) => (object) ((PropertyInfo) obj0).GetMethod;

      internal static object TRLZ60vBX1w1K4hNYI8H([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

      internal static object NKnA2svBTET25WXFcKRi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static System.Type kaIWg1vBkW0sYynacL2b([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

      internal static object W13xf4vBnP69rWrqrboM([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

      internal static bool m9rVp7vBOu35AMBKAyWg([In] object obj0) => ((PropertyInfo) obj0).CanRead;

      internal static object eppuLHvB2RcWtGkdNAI2([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static bool TgXmF2vBePX6ORcxVi0l([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

      internal static System.Type z8UnhJvBPvKDikq98HEE([In] object obj0) => ((MemberInfo) obj0).ReflectedType;

      internal static object bU6HTPvB1xQv7j7U5jpj([In] object obj0) => (object) ((PropertyInfo) obj0).SetMethod;

      internal static object GcA65evBNUdLoUjNoUSI(System.Type type, [In] object obj1, bool declaredOnly) => (object) type.GetAccessor((string) obj1, declaredOnly);
    }
  }
}
