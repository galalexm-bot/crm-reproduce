// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.DynamicEntity
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Динамическая сущность</summary>
  [Serializable]
  public class DynamicEntity : DynamicObject, ISerializable, ICustomTypeDescriptor
  {
    private object entity;
    private Guid typeUid;
    private Dictionary<Guid, DynamicEntity.ValueHolder> valuesByUid;
    private Dictionary<string, DynamicEntity.ValueHolder> valuesByName;
    private Dictionary<Guid, PropertyInfo> propsByUid;
    private static DynamicEntity iicl1BhuBWJTshLVFfCL;

    public DynamicEntity()
    {
      DynamicEntity.yobhM8hubL6DYoIcmkLl();
      this.valuesByUid = new Dictionary<Guid, DynamicEntity.ValueHolder>();
      this.valuesByName = new Dictionary<string, DynamicEntity.ValueHolder>();
      this.propsByUid = new Dictionary<Guid, PropertyInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DynamicEntity(Guid typeUid)
    {
      DynamicEntity.yobhM8hubL6DYoIcmkLl();
      this.valuesByUid = new Dictionary<Guid, DynamicEntity.ValueHolder>();
      this.valuesByName = new Dictionary<string, DynamicEntity.ValueHolder>();
      this.propsByUid = new Dictionary<Guid, PropertyInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.typeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public DynamicEntity(EntityMetadata metadata, object entity)
    {
      DynamicEntity.yobhM8hubL6DYoIcmkLl();
      this.valuesByUid = new Dictionary<Guid, DynamicEntity.ValueHolder>();
      this.valuesByName = new Dictionary<string, DynamicEntity.ValueHolder>();
      this.propsByUid = new Dictionary<Guid, PropertyInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull(entity, (string) DynamicEntity.vKDRMmhuhjXKT4KpubRJ(813604817 ^ 813577077));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 2:
            DynamicEntity.n38tWuhuGGophCSK93xR((object) metadata, DynamicEntity.vKDRMmhuhjXKT4KpubRJ(~-397266137 ^ 397247974));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            DynamicEntity.mht3ighuEdXFHHPqoQ9e((object) this, (object) metadata, entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 3;
            continue;
        }
      }
label_3:;
    }

    public virtual void SaveToEntity(EntityMetadata metadata, object entity)
    {
      int num1 = 2;
      List<PropertyMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_27;
          case 1:
            goto label_3;
          case 2:
            enumerator = metadata.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
          default:
            goto label_23;
        }
      }
label_27:
      return;
label_23:
      return;
label_3:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_10;
label_4:
        DynamicEntity.ValueHolder valueHolder;
        PropertyMetadata current;
        PropertyInfo propertyInfo;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: type reference
              DynamicEntity.\u003C\u003Eo__4.\u003C\u003Ep__0 = CallSite<Action<CallSite, PropertyInfo, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, (string) DynamicEntity.vKDRMmhuhjXKT4KpubRJ(-951514650 ^ -951432390), (IEnumerable<Type>) null, DynamicEntity.DQ6UnPhuZ55Zasm7RplH(__typeref (DynamicEntity)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[4]
              {
                (CSharpArgumentInfo) DynamicEntity.xndHk1huubILkJmAAxHK(CSharpArgumentInfoFlags.UseCompileTimeType, (object) null),
                (CSharpArgumentInfo) DynamicEntity.xndHk1huubILkJmAAxHK(CSharpArgumentInfoFlags.UseCompileTimeType, (object) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                (CSharpArgumentInfo) DynamicEntity.xndHk1huubILkJmAAxHK(CSharpArgumentInfoFlags.Constant, (object) null)
              }));
              num2 = 9;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              if (DynamicEntity.\u003C\u003Eo__4.\u003C\u003Ep__0 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                continue;
              }
              goto case 9;
            case 3:
              goto label_15;
            case 4:
              if (!this.valuesByName.TryGetValue(current.Name, out valueHolder))
              {
                num2 = 10;
                continue;
              }
              goto case 11;
            case 5:
            case 7:
            case 10:
            case 13:
              goto label_9;
            case 6:
              propertyInfo = (PropertyInfo) DynamicEntity.MsvXhvhuCtTUOoXU0BCM(entity.GetType(), DynamicEntity.c2AwVUhuQMxkugFsvsQu((object) current), BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
              num2 = 12;
              continue;
            case 8:
              goto label_17;
            case 9:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              DynamicEntity.\u003C\u003Eo__4.\u003C\u003Ep__0.Target((CallSite) DynamicEntity.\u003C\u003Eo__4.\u003C\u003Ep__0, propertyInfo, entity, valueHolder.Value, (object) null);
              num2 = 7;
              continue;
            case 11:
              if (DynamicEntity.SlsTcPhu86N8Qhhh7Q1y((object) valueHolder))
              {
                num2 = 2;
                continue;
              }
              goto label_9;
            case 12:
              if (!DynamicEntity.YVuxFbhuvEg21GuVtrdq((object) propertyInfo, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 13 : 2;
                continue;
              }
              goto case 4;
            default:
              if (!(DynamicEntity.Kuy0UBhufwZKQFPA09Vr((object) current) != EntityDescriptor.UID))
              {
                num2 = 5;
                continue;
              }
              goto case 6;
          }
        }
label_17:
        return;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 8 : 3;
        goto label_4;
label_15:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public virtual object Id
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.LoadEntityIfNeeded();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this[(string) DynamicEntity.vKDRMmhuhjXKT4KpubRJ(1581325282 << 3 ^ -234332594)];
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this[(string) DynamicEntity.vKDRMmhuhjXKT4KpubRJ(44884861 ^ 44851747)] = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 2:
              this.LoadEntityIfNeeded();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    public virtual object this[string name]
    {
      get => this.SafeGetHolder(name).Value;
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
              this.SafeGetHolder(name).Value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    public virtual object this[Guid uid]
    {
      get => this.SafeGetHolder(uid).Value;
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
              this.SafeGetHolder(uid).Value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    public object Entity
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.LoadEntityIfNeeded();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.entity;
      }
    }

    /// <summary>
    /// Использовать ленивую загрузку свойств (по умолчанию false)
    /// </summary>
    protected virtual bool UseLazyLoadProperty => false;

    protected virtual void LoadEntityIfNeeded()
    {
    }

    protected virtual void Init(EntityMetadata metadata, object entity)
    {
      int num1 = 8;
      List<PropertyMetadata>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_35;
            case 2:
              goto label_8;
            case 3:
            case 6:
              enumerator = metadata.Properties.GetEnumerator();
              num2 = 2;
              continue;
            case 4:
              goto label_7;
            case 5:
              this.typeUid = DynamicEntity.XAM2ZIhuIEg576w3nn7M((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            case 7:
              Contract.ArgumentNotNull(entity, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173639397));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 4;
              continue;
            case 8:
              DynamicEntity.n38tWuhuGGophCSK93xR((object) metadata, DynamicEntity.vKDRMmhuhjXKT4KpubRJ(1505778440 - 1981636111 ^ -475875897));
              num2 = 7;
              continue;
            case 9:
              Dictionary<string, DynamicEntity.ValueHolder> valuesByName = this.valuesByName;
              object key = DynamicEntity.vKDRMmhuhjXKT4KpubRJ(--1360331293 ^ 1360364355);
              DynamicEntity.ValueHolder valueHolder1 = new DynamicEntity.ValueHolder();
              valueHolder1.Name = (string) DynamicEntity.vKDRMmhuhjXKT4KpubRJ(1218962250 ^ 1218929172);
              DynamicEntity.ValueHolder valueHolder2 = valueHolder1;
              // ISSUE: reference to a compiler-generated field
              if (DynamicEntity.\u003C\u003Eo__19.\u003C\u003Ep__0 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: type reference
                DynamicEntity.\u003C\u003Eo__19.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, (string) DynamicEntity.vKDRMmhuhjXKT4KpubRJ(132912447 ^ 132944993), DynamicEntity.DQ6UnPhuZ55Zasm7RplH(__typeref (DynamicEntity)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              object obj = DynamicEntity.\u003C\u003Eo__19.\u003C\u003Ep__0.Target((CallSite) DynamicEntity.\u003C\u003Eo__19.\u003C\u003Ep__0, entity);
              valueHolder2.Value = obj;
              DynamicEntity.ValueHolder valueHolder3 = valueHolder1;
              valuesByName[(string) key] = valueHolder3;
              num2 = 6;
              continue;
            default:
              // ISSUE: type reference
              if (!DynamicEntity.aJyxu4huVE7rmprerX42(entity.GetType().GetInterface(DynamicEntity.DQ6UnPhuZ55Zasm7RplH(__typeref (IEntity<>)).FullName), (Type) null))
              {
                num2 = 3;
                continue;
              }
              goto case 9;
          }
        }
label_7:
        this.entity = entity;
        num1 = 5;
      }
label_35:
      return;
label_8:
      try
      {
label_17:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_18;
label_9:
        PropertyMetadata current;
        DynamicEntity.ValueHolder valueHolder4;
        PropertyInfo reflectionProperty;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_17;
            case 2:
              if (DynamicEntity.lOYVPShuSgEF3K4JNC9o(DynamicEntity.Kuy0UBhufwZKQFPA09Vr((object) current), EntityDescriptor.UID))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 12;
                continue;
              }
              goto label_17;
            case 3:
            case 8:
              this.propsByUid[current.Uid] = reflectionProperty;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
              continue;
            case 4:
              valueHolder4.Value = reflectionProperty.GetValue(entity, (object[]) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 3 : 1;
              continue;
            case 5:
              DynamicEntity.eRxIFNhuKGQ6EIxPCb9y((object) valueHolder4, !DynamicEntity.IJxm0ihuqMToJ3sZD9Lb((object) this));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 11;
              continue;
            case 6:
              this.valuesByName[(string) DynamicEntity.kALQDvhuTD2N8XQOLRGD((object) valueHolder4)] = valueHolder4;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 7 : 10;
              continue;
            case 7:
              goto label_30;
            case 9:
              DynamicEntity.ValueHolder valueHolder5 = new DynamicEntity.ValueHolder();
              DynamicEntity.gRZTyOhuiCIghn01S4QK((object) valueHolder5, current.Uid);
              DynamicEntity.rWGgNchuReHXZu3vvAoV((object) valueHolder5, (object) current.Name);
              valueHolder4 = valueHolder5;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 5 : 4;
              continue;
            case 10:
              if (!valueHolder4.Loaded)
              {
                num3 = 8;
                continue;
              }
              goto case 4;
            case 11:
              this.valuesByUid[DynamicEntity.DSQERghuX87su12e3cm9((object) valueHolder4)] = valueHolder4;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 6 : 1;
              continue;
            case 12:
              reflectionProperty = entity.GetType().GetReflectionProperty((string) DynamicEntity.c2AwVUhuQMxkugFsvsQu((object) current), BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
              num3 = 13;
              continue;
            case 13:
              if (DynamicEntity.YVuxFbhuvEg21GuVtrdq((object) reflectionProperty, (object) null))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 9 : 7;
                continue;
              }
              goto label_17;
            default:
              goto label_10;
          }
        }
label_30:
        return;
label_10:
        current = enumerator.Current;
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        {
          num3 = 1;
          goto label_9;
        }
        else
          goto label_9;
label_18:
        num3 = 7;
        goto label_9;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    private DynamicEntity.ValueHolder GetHolder(Guid uid)
    {
      int num1 = 2;
      DynamicEntity.ValueHolder holder;
      while (true)
      {
        int num2 = num1;
        PropertyInfo propertyInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_14;
            case 2:
              DynamicEntity.qqsRuJhukwHrjnptLNAK((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_12;
            case 4:
              goto label_11;
            case 5:
              holder.Value = propertyInfo.GetValue(this.entity, (object[]) null);
              num2 = 4;
              continue;
            case 6:
              goto label_5;
            case 7:
              if (this.propsByUid.TryGetValue(DynamicEntity.DSQERghuX87su12e3cm9((object) holder), out propertyInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            default:
              DynamicEntity.eRxIFNhuKGQ6EIxPCb9y((object) holder, true);
              num2 = 5;
              continue;
          }
        }
label_12:
        if (!holder.Loaded)
        {
          num1 = 7;
          continue;
        }
        goto label_11;
label_14:
        if (this.valuesByUid.TryGetValue(uid, out holder))
        {
          if (holder != null)
            num1 = 3;
          else
            goto label_11;
        }
        else
          num1 = 6;
      }
label_5:
      return (DynamicEntity.ValueHolder) null;
label_11:
      return holder;
    }

    private DynamicEntity.ValueHolder SafeGetHolder(Guid uid) => this.GetHolder(uid) ?? throw new Exception((string) DynamicEntity.HUvB82hunIaMuxfI8tFW((object) EleWise.ELMA.SR.T((string) DynamicEntity.vKDRMmhuhjXKT4KpubRJ(-2112703338 ^ -2112752026)), (object) uid));

    private DynamicEntity.ValueHolder GetHolder(string name)
    {
      int num1 = 5;
      DynamicEntity.ValueHolder holder;
      while (true)
      {
        int num2 = num1;
        PropertyInfo propertyInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              holder.Loaded = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 0;
              continue;
            case 2:
              holder.Value = DynamicEntity.tiRQJJhuORrG2jRsG9Gs((object) propertyInfo, this.entity, (object) null);
              num2 = 6;
              continue;
            case 3:
              if (this.propsByUid.TryGetValue(holder.Uid, out propertyInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
                continue;
              }
              goto label_10;
            case 4:
              if (this.valuesByName.TryGetValue(name, out holder))
              {
                if (holder != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                  continue;
                }
                goto label_10;
              }
              else
                goto label_9;
            case 5:
              DynamicEntity.qqsRuJhukwHrjnptLNAK((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 4;
              continue;
            case 6:
              goto label_10;
            case 7:
              goto label_11;
            default:
              goto label_5;
          }
        }
label_5:
        if (!DynamicEntity.SlsTcPhu86N8Qhhh7Q1y((object) holder))
        {
          num1 = 3;
          continue;
        }
        break;
label_9:
        num1 = 7;
      }
label_10:
      return holder;
label_11:
      return (DynamicEntity.ValueHolder) null;
    }

    private DynamicEntity.ValueHolder SafeGetHolder(string name) => this.GetHolder(name) ?? throw new Exception((string) DynamicEntity.HUvB82hunIaMuxfI8tFW(DynamicEntity.ywV5AJhu2hZF8EEMFL3I(DynamicEntity.vKDRMmhuhjXKT4KpubRJ(964881585 - -1459193222 ^ -1870712451)), (object) name));

    public DynamicEntity(SerializationInfo info, StreamingContext context)
    {
      DynamicEntity.yobhM8hubL6DYoIcmkLl();
      this.valuesByUid = new Dictionary<Guid, DynamicEntity.ValueHolder>();
      this.valuesByName = new Dictionary<string, DynamicEntity.ValueHolder>();
      this.propsByUid = new Dictionary<Guid, PropertyInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num1 = 0;
      List<DynamicEntity.ValueHolder> valueHolderList;
      List<DynamicEntity.ValueHolder>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            valueHolderList = (List<DynamicEntity.ValueHolder>) DynamicEntity.fp4152hue4V2QB8Lqfpl((object) info, DynamicEntity.vKDRMmhuhjXKT4KpubRJ(813604817 ^ 813688873), DynamicEntity.DQ6UnPhuZ55Zasm7RplH(__typeref (List<DynamicEntity.ValueHolder>)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 3 : 2;
            continue;
          case 2:
            goto label_22;
          case 3:
            if (valueHolderList == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 2;
              continue;
            }
            goto case 4;
          case 4:
            enumerator = valueHolderList.GetEnumerator();
            num1 = 5;
            continue;
          case 5:
            goto label_8;
          case 6:
            goto label_18;
          default:
            // ISSUE: type reference
            this.typeUid = (Guid) DynamicEntity.fp4152hue4V2QB8Lqfpl((object) info, DynamicEntity.vKDRMmhuhjXKT4KpubRJ(-2092274397 << 4 ^ 883198768), DynamicEntity.DQ6UnPhuZ55Zasm7RplH(__typeref (Guid)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
            continue;
        }
      }
label_22:
      return;
label_18:
      return;
label_8:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_13;
        else
          goto label_11;
label_9:
        DynamicEntity.ValueHolder current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              this.valuesByName[(string) DynamicEntity.kALQDvhuTD2N8XQOLRGD((object) current)] = current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 5;
              continue;
            case 3:
              if (!DynamicEntity.lOYVPShuSgEF3K4JNC9o(DynamicEntity.DSQERghuX87su12e3cm9((object) current), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 2;
                continue;
              }
              goto case 4;
            case 4:
              this.valuesByUid[current.Uid] = current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_10;
            case 6:
              goto label_17;
            default:
              goto label_13;
          }
        }
label_17:
        return;
label_11:
        num2 = 6;
        goto label_9;
label_13:
        current = enumerator.Current;
        num2 = 3;
        goto label_9;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DynamicEntity.l1rEyKhuPbc7QJ0mSXkA((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217435967), (object) new List<DynamicEntity.ValueHolder>((IEnumerable<DynamicEntity.ValueHolder>) this.valuesByName.Values));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            DynamicEntity.l1rEyKhuPbc7QJ0mSXkA((object) info, DynamicEntity.vKDRMmhuhjXKT4KpubRJ(-1638402543 ^ -1638551791), (object) this.typeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>
    /// When a new property is set,
    /// add the property name and value to the dictionary
    /// </summary>
    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
      int num = 3;
      DynamicEntity.ValueHolder holder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (holder == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
              continue;
            }
            holder.Value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 3:
            holder = this.GetHolder((string) DynamicEntity.UnQHYChu1jqp3tPsmbiD((object) binder));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return true;
label_6:
      return DynamicEntity.USdK71huNpBGqEkOFUTm((object) this, (object) binder, value);
    }

    /// <summary>
    /// When user accesses something, return the value if we have it
    /// </summary>
    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
      int num = 2;
      DynamicEntity.ValueHolder holder;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (holder != null)
            {
              result = holder.Value;
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 2:
            holder = this.GetHolder((string) DynamicEntity.L8Fvw7hu3R6fEf2kVIvj((object) binder));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      return true;
label_4:
      return base.TryGetMember(binder, out result);
    }

    /// <summary>Return all dynamic member names</summary>
    public override IEnumerable<string> GetDynamicMemberNames() => (IEnumerable<string>) this.valuesByName.Keys;

    public AttributeCollection GetAttributes() => (AttributeCollection) null;

    public string GetClassName() => (string) null;

    public string GetComponentName() => (string) null;

    public TypeConverter GetConverter() => (TypeConverter) null;

    public EventDescriptor GetDefaultEvent() => (EventDescriptor) null;

    public PropertyDescriptor GetDefaultProperty() => (PropertyDescriptor) null;

    public object GetEditor(Type editorBaseType) => (object) null;

    public EventDescriptorCollection GetEvents(Attribute[] attributes) => (EventDescriptorCollection) null;

    public EventDescriptorCollection GetEvents() => (EventDescriptorCollection) null;

    public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      int num1 = 2;
      Dictionary<string, DynamicEntity.ValueHolder>.KeyCollection.Enumerator enumerator;
      List<PropertyDescriptor> propertyDescriptorList;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.valuesByName.Keys.GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            propertyDescriptorList = new List<PropertyDescriptor>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_15;
        }
      }
label_2:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_4;
        else
          goto label_7;
label_3:
        string current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_15;
            case 3:
              propertyDescriptorList.Add((PropertyDescriptor) new DynamicEntity.DynamicPropDescriptor(current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        current = enumerator.Current;
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
label_7:
        num2 = 2;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_15:
      return new PropertyDescriptorCollection((PropertyDescriptor[]) DynamicEntity.iDfIsMhupPjeHvN0Aawv((object) propertyDescriptorList));
    }

    public PropertyDescriptorCollection GetProperties() => this.GetProperties((Attribute[]) null);

    public object GetPropertyOwner(PropertyDescriptor pd) => (object) null;

    /// <summary>Сохранить сущность</summary>
    public virtual void Save()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Id = DynamicEntity.IUOHQXhuDh3tpo969IaL(DynamicEntity.LYiRZrhuaDS1sy3Ew2Fk(this.typeUid), (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Удалить сущность</summary>
    public virtual void Delete()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DynamicEntity.WTXfIIhutVqspiH9sdqZ(DynamicEntity.LYiRZrhuaDS1sy3Ew2Fk(this.typeUid), (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void yobhM8hubL6DYoIcmkLl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nA9RxXhuWJBmpth3xtyT() => DynamicEntity.iicl1BhuBWJTshLVFfCL == null;

    internal static DynamicEntity hC67BAhuoujmVfH1YqHC() => DynamicEntity.iicl1BhuBWJTshLVFfCL;

    internal static object vKDRMmhuhjXKT4KpubRJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void n38tWuhuGGophCSK93xR([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void mht3ighuEdXFHHPqoQ9e([In] object obj0, [In] object obj1, [In] object obj2) => ((DynamicEntity) obj0).Init((EntityMetadata) obj1, obj2);

    internal static Guid Kuy0UBhufwZKQFPA09Vr([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static object c2AwVUhuQMxkugFsvsQu([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object MsvXhvhuCtTUOoXU0BCM(Type type, [In] object obj1, BindingFlags bindingAttr) => (object) type.GetReflectionProperty((string) obj1, bindingAttr);

    internal static bool YVuxFbhuvEg21GuVtrdq([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static bool SlsTcPhu86N8Qhhh7Q1y([In] object obj0) => ((DynamicEntity.ValueHolder) obj0).Loaded;

    internal static Type DQ6UnPhuZ55Zasm7RplH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object xndHk1huubILkJmAAxHK([In] CSharpArgumentInfoFlags obj0, [In] object obj1) => (object) CSharpArgumentInfo.Create(obj0, (string) obj1);

    internal static Guid XAM2ZIhuIEg576w3nn7M([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool aJyxu4huVE7rmprerX42([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool lOYVPShuSgEF3K4JNC9o([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void gRZTyOhuiCIghn01S4QK([In] object obj0, Guid value) => ((DynamicEntity.ValueHolder) obj0).Uid = value;

    internal static void rWGgNchuReHXZu3vvAoV([In] object obj0, [In] object obj1) => ((DynamicEntity.ValueHolder) obj0).Name = (string) obj1;

    internal static bool IJxm0ihuqMToJ3sZD9Lb([In] object obj0) => ((DynamicEntity) obj0).UseLazyLoadProperty;

    internal static void eRxIFNhuKGQ6EIxPCb9y([In] object obj0, bool value) => ((DynamicEntity.ValueHolder) obj0).Loaded = value;

    internal static Guid DSQERghuX87su12e3cm9([In] object obj0) => ((DynamicEntity.ValueHolder) obj0).Uid;

    internal static object kALQDvhuTD2N8XQOLRGD([In] object obj0) => (object) ((DynamicEntity.ValueHolder) obj0).Name;

    internal static void qqsRuJhukwHrjnptLNAK([In] object obj0) => ((DynamicEntity) obj0).LoadEntityIfNeeded();

    internal static object HUvB82hunIaMuxfI8tFW([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object tiRQJJhuORrG2jRsG9Gs([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object ywV5AJhu2hZF8EEMFL3I([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object fp4152hue4V2QB8Lqfpl([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void l1rEyKhuPbc7QJ0mSXkA([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static object UnQHYChu1jqp3tPsmbiD([In] object obj0) => (object) ((SetMemberBinder) obj0).Name;

    internal static bool USdK71huNpBGqEkOFUTm([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((DynamicObject) obj0).TrySetMember((SetMemberBinder) obj1, obj2));

    internal static object L8Fvw7hu3R6fEf2kVIvj([In] object obj0) => (object) ((GetMemberBinder) obj0).Name;

    internal static object iDfIsMhupPjeHvN0Aawv([In] object obj0) => (object) ((List<PropertyDescriptor>) obj0).ToArray();

    internal static object LYiRZrhuaDS1sy3Ew2Fk(Guid typeUid) => (object) DynamicEntityManager.Typed(typeUid);

    internal static object IUOHQXhuDh3tpo969IaL([In] object obj0, [In] object obj1) => ((TypedDynamicEntityManager) obj0).Save((DynamicEntity) obj1);

    internal static void WTXfIIhutVqspiH9sdqZ([In] object obj0, [In] object obj1) => ((TypedDynamicEntityManager) obj0).Delete((DynamicEntity) obj1);

    /// <summary>Класс, хранящий значение свойства</summary>
    [Serializable]
    public class ValueHolder
    {
      private object value;
      private static DynamicEntity.ValueHolder yK3muECzIXr9yl6KRani;

      public ValueHolder()
      {
        DynamicEntity.ValueHolder.cpbj08Czio1wgTqoCl0p();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.Loaded = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public Guid Uid
      {
        get => this.\u003CUid\u003Ek__BackingField;
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
                this.\u003CUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
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

      public string Name
      {
        get => this.\u003CName\u003Ek__BackingField;
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
                this.\u003CName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

      public bool Loaded
      {
        get => this.\u003CLoaded\u003Ek__BackingField;
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
                this.\u003CLoaded\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

      public object Value
      {
        get => this.value;
        set
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, DynamicEntity.ValueHolder.BaKitdCzRFkqxwRQdZbc(__typeref (DynamicEntity.ValueHolder)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                }));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 4;
                continue;
              case 2:
                if (DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__1 == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
                  continue;
                }
                goto case 4;
              case 3:
                goto label_2;
              case 4:
                Func<CallSite, object, bool> target = DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__1.Target;
                CallSite<Func<CallSite, object, bool>> p1 = DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__1;
                if (DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__0 == null)
                  DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof (DynamicEntity.ValueHolder), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                    (CSharpArgumentInfo) DynamicEntity.ValueHolder.qYpEj5CzqT9t7I8KRatd(CSharpArgumentInfoFlags.None, (object) null)
                  }));
                object obj = DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__0.Target((CallSite) DynamicEntity.ValueHolder.\u003C\u003Eo__16.\u003C\u003Ep__0, this.value, value);
                if (target((CallSite) p1, obj))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                  continue;
                }
                goto label_11;
              default:
                this.value = value;
                num = 3;
                continue;
            }
          }
label_2:
          return;
label_11:;
        }
      }

      internal static void cpbj08Czio1wgTqoCl0p() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool rNsCFvCzVcGj9LAt7yfL() => DynamicEntity.ValueHolder.yK3muECzIXr9yl6KRani == null;

      internal static DynamicEntity.ValueHolder kQdPkOCzS8uUFGu9MvGY() => DynamicEntity.ValueHolder.yK3muECzIXr9yl6KRani;

      internal static Type BaKitdCzRFkqxwRQdZbc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object qYpEj5CzqT9t7I8KRatd([In] CSharpArgumentInfoFlags obj0, [In] object obj1) => (object) CSharpArgumentInfo.Create(obj0, (string) obj1);
    }

    private class DynamicPropDescriptor : PropertyDescriptor
    {
      internal static object MirrL7CzKpjrtTxGy3CZ;

      public DynamicPropDescriptor(string name)
      {
        DynamicEntity.DynamicPropDescriptor.LM1wm6CzknoLS9gatcTC();
        // ISSUE: explicit constructor call
        base.\u002Ector(name, (Attribute[]) null);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public override bool CanResetValue(object component) => false;

      public override Type ComponentType => throw new NotImplementedException();

      public override object GetValue(object component)
      {
        int num = 1;
        DynamicEntity dynamicEntity;
        while (true)
        {
          switch (num)
          {
            case 1:
              dynamicEntity = component as DynamicEntity;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_2;
            default:
              if (dynamicEntity != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 2;
                continue;
              }
              goto label_2;
          }
        }
label_2:
        return (object) null;
label_3:
        return DynamicEntity.DynamicPropDescriptor.TtJJEjCzORNtS9ht5lK1((object) dynamicEntity, DynamicEntity.DynamicPropDescriptor.D4YqZtCznU2Vw3bEK2p6((object) this));
      }

      public override bool IsReadOnly => false;

      public override Type PropertyType => DynamicEntity.DynamicPropDescriptor.L7w6FXCz2Q1keZC485yx(__typeref (object));

      public override void ResetValue(object component)
      {
      }

      public override void SetValue(object component, object value)
      {
        int num = 1;
        DynamicEntity dynamicEntity;
        while (true)
        {
          switch (num)
          {
            case 1:
              dynamicEntity = component as DynamicEntity;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 2:
              DynamicEntity.DynamicPropDescriptor.irIJApCzeIVCMcNPE4k4((object) dynamicEntity, DynamicEntity.DynamicPropDescriptor.D4YqZtCznU2Vw3bEK2p6((object) this), value);
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              if (dynamicEntity != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
                continue;
              }
              goto label_7;
          }
        }
label_2:
        return;
label_7:;
      }

      public override bool ShouldSerializeValue(object component) => false;

      internal static void LM1wm6CzknoLS9gatcTC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool fAQMfQCzXZJ4JEgtc1GX() => DynamicEntity.DynamicPropDescriptor.MirrL7CzKpjrtTxGy3CZ == null;

      internal static DynamicEntity.DynamicPropDescriptor HAv6brCzT0hq18uhNulY() => (DynamicEntity.DynamicPropDescriptor) DynamicEntity.DynamicPropDescriptor.MirrL7CzKpjrtTxGy3CZ;

      internal static object D4YqZtCznU2Vw3bEK2p6([In] object obj0) => (object) ((MemberDescriptor) obj0).Name;

      internal static object TtJJEjCzORNtS9ht5lK1([In] object obj0, [In] object obj1) => ((DynamicEntity) obj0)[(string) obj1];

      internal static Type L7w6FXCz2Q1keZC485yx([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void irIJApCzeIVCMcNPE4k4([In] object obj0, [In] object obj1, [In] object obj2) => ((DynamicEntity) obj0)[(string) obj1] = obj2;
    }
  }
}
