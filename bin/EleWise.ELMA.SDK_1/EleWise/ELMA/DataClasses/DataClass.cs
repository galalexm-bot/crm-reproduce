// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DataClasses.DataClass
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EleWise.ELMA.DataClasses
{
  /// <summary>Объект конструктора интерфейсов</summary>
  [DebuggerTypeProxy(typeof (DataClass.DebugView))]
  [DataContract]
  public class DataClass : IDataClass, IEquatable<DataClass>
  {
    private IDictionary<Guid, DataClass.ValueContainer.DataContainer> data;
    private static ContextVars.Local<ConcurrentDictionary<Type, Guid>> uids;
    private static readonly Guid DataClassUid;
    private static DataClass F3W4tqfFKkpE5xxh98xg;

    protected internal DataClass(DataClass.ValueContainer valueContainer)
    {
      DataClass.Sgw5MefFk5jrpOKqQQ40();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.data = (IDictionary<Guid, DataClass.ValueContainer.DataContainer>) new Dictionary<Guid, DataClass.ValueContainer.DataContainer>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
            continue;
          case 2:
            this.TypeRef = valueContainer.Initialize(this.data);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Оператор равенства по ссылке</summary>
    /// <param name="left">Левый операнд</param>
    /// <param name="right">Правый операнд</param>
    /// <returns><c>true</c>, если объекты равны по ссылке</returns>
    public static bool operator ==(DataClass left, DataClass right)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) left == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) right == null;
label_3:
      // ISSUE: explicit non-virtual call
      return __nonvirtual (left.Equals(right));
    }

    /// <summary>Оператор неравенства по ссылке</summary>
    /// <param name="left">Левый операнд</param>
    /// <param name="right">Правый операнд</param>
    /// <returns><c>true</c>, если объекты не равны по ссылке</returns>
    public static bool operator !=(DataClass left, DataClass right) => !(left == right);

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      bool flag;
      switch (1)
      {
        case 1:
          try
          {
            int num1;
            if (!DataClass.zYZtUafFneHV1Eed5AVq((object) this, obj))
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
            else
              goto label_6;
label_4:
            int num2;
            switch (num1)
            {
              case 1:
                num2 = this.Equals((DataClass) obj) ? 1 : 0;
                goto label_7;
              default:
                goto label_1;
            }
label_6:
            num2 = 1;
label_7:
            flag = num2 != 0;
            num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
            {
              num1 = 0;
              goto label_4;
            }
            else
              goto label_4;
          }
          catch (InvalidCastException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
                  continue;
              }
            }
          }
      }
label_1:
      return flag;
    }

    /// <inheritdoc />
    public bool Equals(DataClass other) => this.data == ((object) other == null ? (IDictionary<Guid, DataClass.ValueContainer.DataContainer>) null : other.data);

    /// <summary>Идентификатор, отвечающий за ссылку на тип</summary>
    [Obsolete("TODO: ELMA-29857 Убрать после выноса EleWise.ELMA.SDK.DTO")]
    internal string TypeRef
    {
      get => this.\u003CTypeRef\u003Ek__BackingField;
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
              this.\u003CTypeRef\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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

    /// <summary>Получить метаданные вложенных объектов</summary>
    /// <param name="onlyFilled">Только заполненные объекты</param>
    /// <returns>Метаданные вложенных объектов</returns>
    internal IEnumerable<DataClassMetadata> GetIncludes(bool onlyFilled) => this.data.If<KeyValuePair<Guid, DataClass.ValueContainer.DataContainer>>(onlyFilled, (Func<IEnumerable<KeyValuePair<Guid, DataClass.ValueContainer.DataContainer>>, IEnumerable<KeyValuePair<Guid, DataClass.ValueContainer.DataContainer>>>) (_ => _.Where<KeyValuePair<Guid, DataClass.ValueContainer.DataContainer>>((Func<KeyValuePair<Guid, DataClass.ValueContainer.DataContainer>, bool>) (p => p.Value.Initialized)))).Select<KeyValuePair<Guid, DataClass.ValueContainer.DataContainer>, DataClassMetadata>((Func<KeyValuePair<Guid, DataClass.ValueContainer.DataContainer>, DataClassMetadata>) (p => p.Value.Metadata));

    /// <summary>
    /// Проверка на соответствие объекта типу <paramref name="type" />
    /// </summary>
    /// <param name="type">Проверяемый тип</param>
    /// <returns><c>true</c>, если объект является типом <paramref name="type" /></returns>
    internal bool Is(Type type) => this.Is(DataClass.AJOHiWfFO61fTXGWM6aJ(type));

    /// <summary>
    /// Приведение объекта к типу <paramref name="uid" />
    /// </summary>
    /// <param name="uid">Тип, к которому будет приведен объект</param>
    /// <returns>Объект типа <paramref name="uid" /> или <c>null</c>, если приведение невозможно</returns>
    internal DataClass As(Guid uid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.Is(uid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (DataClass) null;
label_3:
      return this;
    }

    /// <summary>
    /// Приведение объекта к типу <paramref name="type" />
    /// </summary>
    /// <param name="type">Тип, к которому будет приведен объект</param>
    /// <returns>Объект типа <paramref name="type" /> или <c>null</c>, если приведение невозможно</returns>
    internal object As(Type type)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (type.IsInstanceOfType((object) this))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            if (this.Is(DataClass.AJOHiWfFO61fTXGWM6aJ(type)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      return (object) null;
label_7:
      return (object) this;
label_8:
      return (object) ((DataClass) DataClass.EX8LA7fF2OYKNiEf43mr(type)).InitFrom(this);
    }

    /// <summary>
    /// Проверка на соответствие объекта типу <typeparamref name="T" />
    /// </summary>
    /// <typeparam name="T">Проверяемый тип</typeparam>
    /// <returns><c>true</c>, если объект является типом <typeparamref name="T" /></returns>
    public virtual bool Is<T>() where T : DataClass => this.Is(DataClass.Uid<T>());

    /// <summary>
    /// Приведение объекта к типу <typeparamref name="T" />
    /// </summary>
    /// <typeparam name="T">Тип, к которому будет приведен объект</typeparam>
    /// <returns>Объект типа <typeparamref name="T" /> или <c>null</c>, если приведение невозможно</returns>
    public T As<T>() where T : DataClass, new()
    {
      if (!this.Is<T>())
        return default (T);
      return this is T obj ? obj : (T) new T().InitFrom(this);
    }

    protected bool Is(Guid metadataUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(metadataUid == DataClass.DataClassUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.data.ContainsKey(metadataUid);
label_3:
      return true;
    }

    protected DataClass Cast<T>() where T : DataClass, new() => !this.Is<T>() ? (DataClass) null : this;

    protected internal object GetObject(Guid metadataUid, Guid propertyUid) => DataClass.GecSmIfFPe3d6874WHRJ(DataClass.SAqhDofFeW1eEhEexLup((object) this.data[metadataUid], propertyUid), (object) this);

    protected internal void SetObject(Guid metadataUid, Guid propertyUid, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DataClass.Mt0eWjfF1Vtx5cOrFAsR(DataClass.SAqhDofFeW1eEhEexLup((object) this.data[metadataUid], propertyUid), (object) this, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected internal T Get<T>(Guid metadataUid, Guid propertyUid) => this.data[metadataUid][propertyUid].Cast<T>().Get((object) this);

    protected internal void Set<T>(Guid metadataUid, Guid propertyUid, T value) => this.data[metadataUid][propertyUid].Cast<T>().Set((object) this, value);

    /// <summary>Заполнить кеш типов</summary>
    /// <param name="type">Проверяемый тип</param>
    /// <param name="typesCast">Кеш типов</param>
    internal static void FillTypesCache(Type type, System.Collections.Generic.ISet<Type> typesCast)
    {
      if (!typesCast.Add(type))
        return;
      foreach (object customAttribute in type.GetCustomAttributes(false))
      {
        Type type1 = customAttribute.GetType();
        if (type1.FullName == "EleWise.ELMA.Model.Attributes.IncludeAttribute" && type1.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539170107), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetValue(customAttribute) is Type type2 && !type2.IsInterface)
          DataClass.FillTypesCache(type2, typesCast);
      }
    }

    private DataClass InitFrom(DataClass dataClass)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.data = dataClass.data;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.TypeRef = (string) DataClass.a07PQ9fFNOCBO9ufBngT((object) dataClass);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:
      return this;
    }

    protected static Guid Uid(Type type)
    {
      ConcurrentDictionary<Type, Guid> concurrentDictionary = DataClass.uids.Value;
      Type key = type;
      // ISSUE: reference to a compiler-generated field
      Func<Type, Guid> func = DataClass.\u003C\u003Ec.\u003C\u003E9__26_0;
      Func<Type, Guid> valueFactory;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        DataClass.\u003C\u003Ec.\u003C\u003E9__26_0 = valueFactory = (Func<Type, Guid>) (t =>
        {
          int num = 1;
          UidAttribute customAttribute;
          while (true)
          {
            switch (num)
            {
              case 1:
                customAttribute = t.GetCustomAttribute<UidAttribute>();
                if (customAttribute == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return DataClass.\u003C\u003Ec.VRiDu289GTjFG5YWhT5a(t);
label_5:
          return customAttribute.Uid;
        });
      }
      else
        goto label_1;
label_3:
      return concurrentDictionary.GetOrAdd(key, valueFactory);
label_1:
      valueFactory = func;
      goto label_3;
    }

    protected static Guid Uid<T>() => DataClass.Uid(TypeOf<T>.Raw);

    internal System.Reflection.PropertyInfo GetProperty(
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata)
    {
      return (System.Reflection.PropertyInfo) new DataClass.PropertyInfo(propertyMetadata.Name, DataClass.VGvhC0fFpcboKfaD0vfR(DataClass.SAqhDofFeW1eEhEexLup((object) this.data[DataClass.VVhoXpfF3hD16t3mr7Yf((object) metadata)], DataClass.VVhoXpfF3hD16t3mr7Yf((object) propertyMetadata))), DataClass.VVhoXpfF3hD16t3mr7Yf((object) metadata), DataClass.VVhoXpfF3hD16t3mr7Yf((object) propertyMetadata));
    }

    private static IModuleMetadataLoader ModuleMetadataLoader => Locator.GetServiceNotNull<IModuleMetadataLoader>();

    /// <summary>
    /// Загрузить метаданные объекта конструктора интерфейсов по типу
    /// </summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <returns>Метаданные объекта конструктора интерфейсов</returns>
    internal static DataClassMetadata LoadMetadata(Type type, bool inherit = true) => MetadataLoader.LoadMetadata(type, inherit) as DataClassMetadata;

    static DataClass()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DataClass.Sgw5MefFk5jrpOKqQQ40();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            DataClass.DataClassUid = DataClass.Uid<DataClass>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 2;
            continue;
          default:
            DataClass.uids = new ContextVars.Local<ConcurrentDictionary<Type, Guid>>((Func<ConcurrentDictionary<Type, Guid>>) (() => new ConcurrentDictionary<Type, Guid>()));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static void Sgw5MefFk5jrpOKqQQ40() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool C6IByVfFX5vmu1RDxLuR() => (object) DataClass.F3W4tqfFKkpE5xxh98xg == null;

    internal static DataClass eFejttfFT52V3DPTJBtq() => DataClass.F3W4tqfFKkpE5xxh98xg;

    internal static bool zYZtUafFneHV1Eed5AVq([In] object obj0, [In] object obj1) => __nonvirtual (obj0.Equals(obj1));

    internal static Guid AJOHiWfFO61fTXGWM6aJ(Type type) => DataClass.Uid(type);

    internal static object EX8LA7fF2OYKNiEf43mr([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object SAqhDofFeW1eEhEexLup([In] object obj0, Guid propertyUid) => (object) ((DataClass.ValueContainer.DataContainer) obj0)[propertyUid];

    internal static object GecSmIfFPe3d6874WHRJ([In] object obj0, [In] object obj1) => ((IPropertyValueContainer) obj0).Get(obj1);

    internal static void Mt0eWjfF1Vtx5cOrFAsR([In] object obj0, [In] object obj1, [In] object obj2) => ((IPropertyValueContainer) obj0).Set(obj1, obj2);

    internal static object a07PQ9fFNOCBO9ufBngT([In] object obj0) => (object) ((DataClass) obj0).TypeRef;

    internal static Guid VVhoXpfF3hD16t3mr7Yf([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Type VGvhC0fFpcboKfaD0vfR([In] object obj0) => ((IPropertyValueContainer) obj0).PropertyType;

    private sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly DataClass dataClass;
      internal static object scaQIY8JvycqIlm1eSV2;

      public DebugView(DataClass dataClass)
      {
        DataClass.DebugView.IXruol8JuTVvDOv0sga9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.dataClass = dataClass;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public DataClassMetadata[] Includes => this.dataClass.GetIncludes(true).ToArray<DataClassMetadata>();

      public (string Name, object Value)[] Properties
      {
        get
        {
          ICollection<DataClass.ValueContainer.DataContainer> values = this.dataClass.data.Values;
          Func<DataClass.ValueContainer.DataContainer, bool> func = DataClass.DebugView.\u003C\u003Ec.\u003C\u003E9__5_0;
          Func<DataClass.ValueContainer.DataContainer, bool> predicate;
          if (func == null)
            DataClass.DebugView.\u003C\u003Ec.\u003C\u003E9__5_0 = predicate = (Func<DataClass.ValueContainer.DataContainer, bool>) (v => v.Initialized);
          else
            goto label_1;
label_3:
          return values.Where<DataClass.ValueContainer.DataContainer>(predicate).SelectMany<DataClass.ValueContainer.DataContainer, (string, object)>((Func<DataClass.ValueContainer.DataContainer, IEnumerable<(string, object)>>) (a => a.values.Select<KeyValuePair<Guid, DataClass.IPropertyValueContainerCast>, (string, object)>((Func<KeyValuePair<Guid, DataClass.IPropertyValueContainerCast>, (string, object)>) (b => (this.Name(a.Metadata, b.Key), b.Value.Get((object) this.dataClass)))))).ToArray<(string, object)>();
label_1:
          predicate = func;
          goto label_3;
        }
      }

      private string Name(DataClassMetadata metadata, Guid propertyUid)
      {
        int num = 2;
        PropertyMetadata propertyMetadata;
        Guid propertyUid1;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyUid1 = propertyUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            default:
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => DataClass.DebugView.\u003C\u003Ec__DisplayClass6_0.Y6kjErZ1F7Yqh0ht2GL3((object) p) == propertyUid1));
              if (propertyMetadata == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 0;
                continue;
              }
              goto label_7;
          }
        }
label_6:
        return (string) null;
label_7:
        return (string) DataClass.DebugView.zr4HL68JIJxFymj04Mp0((object) propertyMetadata);
      }

      internal static void IXruol8JuTVvDOv0sga9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool KGgiAW8J8EZumGvHlVGI() => DataClass.DebugView.scaQIY8JvycqIlm1eSV2 == null;

      internal static DataClass.DebugView wOiFLK8JZ8PTXZgifAxK() => (DataClass.DebugView) DataClass.DebugView.scaQIY8JvycqIlm1eSV2;

      internal static object zr4HL68JIJxFymj04Mp0([In] object obj0) => (object) ((NamedMetadata) obj0).Name;
    }

    private class DataClassCollectionPropertyValueContainer : IPropertyDefaultValueContainer
    {
      private object propertyDefaultValueContainer;
      internal static object hwS85r8JVoy9rw9Ill1x;

      public DataClassCollectionPropertyValueContainer()
      {
        DataClass.DataClassCollectionPropertyValueContainer.aSJyem8JRxUcvhYrieEN();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.propertyDefaultValueContainer = (object) new DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer(this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) DataClass.DataClassCollectionPropertyValueContainer.srVh8q8JqkgP9vuSK3TC(this.propertyDefaultValueContainer);

      internal static void aSJyem8JRxUcvhYrieEN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool tJiQOx8JSorbkvsV1dbn() => DataClass.DataClassCollectionPropertyValueContainer.hwS85r8JVoy9rw9Ill1x == null;

      internal static DataClass.DataClassCollectionPropertyValueContainer m8cGjo8JiGuQva2EfxIF() => (DataClass.DataClassCollectionPropertyValueContainer) DataClass.DataClassCollectionPropertyValueContainer.hwS85r8JVoy9rw9Ill1x;

      internal static object srVh8q8JqkgP9vuSK3TC([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

      private class NestedDefaultValueContainer : 
        DataClass.IPropertyValueContainerCast,
        IPropertyValueContainer,
        IPropertyDefaultValueContainer
      {
        private readonly object dataClassCollectionPropertyValueContainer;
        private IEnumerable<DataClass> value;
        private object castedContainer;
        private static object ns8yCMZ1Bt7yfl4EgrXj;

        public NestedDefaultValueContainer(
          DataClass.DataClassCollectionPropertyValueContainer dataClassCollectionPropertyValueContainer)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          this.value = (IEnumerable<DataClass>) new List<DataClass>();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              default:
                this.dataClassCollectionPropertyValueContainer = (object) dataClassCollectionPropertyValueContainer;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
                continue;
            }
          }
label_3:;
        }

        object IPropertyValueContainer.Get(object obj)
        {
          int num = 2;
          object obj1;
          while (true)
          {
            switch (num)
            {
              case 1:
                obj1 = (object) null;
                break;
              case 2:
                object castedContainer = this.castedContainer;
                if (castedContainer == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
                  continue;
                }
                obj1 = ((IPropertyValueContainer) castedContainer).Get(obj);
                break;
              default:
                goto label_9;
            }
            if (obj1 == null)
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            else
              break;
          }
          return obj1;
label_9:
          return (object) this.value;
        }

        void IPropertyValueContainer.Set(object obj, object value)
        {
          int num = 3;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                goto label_6;
              case 2:
                DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer.e2v0vuZ1bjsfTqhTrN4t(this.castedContainer, obj, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              case 3:
                if (this.castedContainer != null)
                {
                  num = 2;
                  continue;
                }
                this.value = (IEnumerable<DataClass>) value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
                continue;
              default:
                goto label_8;
            }
          }
label_2:
          return;
label_6:
          return;
label_8:;
        }

        Type IPropertyValueContainer.PropertyType
        {
          get
          {
            int num = 1;
            Type propertyType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  object castedContainer = this.castedContainer;
                  if (castedContainer == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                    continue;
                  }
                  propertyType = DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer.HTsSy1Z1h2WZcU9vaUvI(castedContainer);
                  break;
                case 2:
                  goto label_9;
                default:
                  propertyType = (Type) null;
                  break;
              }
              if ((object) propertyType == null)
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 2;
              else
                break;
            }
            return propertyType;
label_9:
            return TypeOf<ICollection<DataClass>>.Raw;
          }
        }

        IPropertyValueContainer<T> DataClass.IPropertyValueContainerCast.Cast<T>()
        {
          if (this.castedContainer == null)
          {
            Type genericArgument = typeof (T).GetGenericArguments()[0];
            ((DataClass.DataClassCollectionPropertyValueContainer) this.dataClassCollectionPropertyValueContainer).propertyDefaultValueContainer = (object) (IPropertyDefaultValueContainer) Activator.CreateInstance(typeof (DataClass.PropertyCollectionValueContainer<,>).MakeGenericType(typeof (T), TypeOf.List.Raw.MakeGenericType(genericArgument)));
            IPropertyValueContainer<T> propertyValueContainer = (IPropertyValueContainer<T>) ((IPropertyDefaultValueContainer) ((DataClass.DataClassCollectionPropertyValueContainer) this.dataClassCollectionPropertyValueContainer).propertyDefaultValueContainer).Initialize();
            if (this.value != null)
            {
              IList list = (IList) (object) propertyValueContainer.Get((object) null);
              foreach (DataClass dataClass in this.value)
                list.Add(dataClass?.As(genericArgument));
            }
            else
              propertyValueContainer.Set((object) null, (object) null);
            this.castedContainer = (object) propertyValueContainer;
            this.value = (IEnumerable<DataClass>) null;
          }
          return (IPropertyValueContainer<T>) this.castedContainer;
        }

        IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer((DataClass.DataClassCollectionPropertyValueContainer) this.dataClassCollectionPropertyValueContainer);

        internal static bool RD53VWZ1W3r6FdHIYMFj() => DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer.ns8yCMZ1Bt7yfl4EgrXj == null;

        internal static DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer LUNPQSZ1omebrm5rRR2u() => (DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer) DataClass.DataClassCollectionPropertyValueContainer.NestedDefaultValueContainer.ns8yCMZ1Bt7yfl4EgrXj;

        internal static void e2v0vuZ1bjsfTqhTrN4t([In] object obj0, [In] object obj1, [In] object obj2) => ((IPropertyValueContainer) obj0).Set(obj1, obj2);

        internal static Type HTsSy1Z1h2WZcU9vaUvI([In] object obj0) => ((IPropertyValueContainer) obj0).PropertyType;
      }
    }

    private class DataClassPropertyValueContainer : IPropertyDefaultValueContainer
    {
      private object propertyDefaultValueContainer;
      internal static object h37bNR8JKNsAXUnwOyL9;

      public DataClassPropertyValueContainer()
      {
        DataClass.DataClassPropertyValueContainer.esmAye8JkYPSMuaeM2sx();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.propertyDefaultValueContainer = (object) new DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer(this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) DataClass.DataClassPropertyValueContainer.lHWhvU8JnncDlfradVPN(this.propertyDefaultValueContainer);

      internal static void esmAye8JkYPSMuaeM2sx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool I45rAA8JX3o3CRFKmWm6() => DataClass.DataClassPropertyValueContainer.h37bNR8JKNsAXUnwOyL9 == null;

      internal static DataClass.DataClassPropertyValueContainer CZ4mGH8JThWcbHVpZPhK() => (DataClass.DataClassPropertyValueContainer) DataClass.DataClassPropertyValueContainer.h37bNR8JKNsAXUnwOyL9;

      internal static object lHWhvU8JnncDlfradVPN([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

      private class NestedDefaultValueContainer : 
        DataClass.IPropertyValueContainerCast,
        IPropertyValueContainer,
        IPropertyDefaultValueContainer
      {
        private readonly object dataClassPropertyValueContainer;
        private object value;
        private object castedContainer;
        private static object EQXokPZ1GnwIROWK6Y2O;

        public NestedDefaultValueContainer(
          DataClass.DataClassPropertyValueContainer dataClassPropertyValueContainer)
        {
          DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer.maYRyDZ1QW60IABt4CsR();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.dataClassPropertyValueContainer = (object) dataClassPropertyValueContainer;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_3:
          return;
label_5:;
        }

        object IPropertyValueContainer.Get(object obj)
        {
          int num = 2;
          object obj1;
          while (true)
          {
            switch (num)
            {
              case 1:
                obj1 = (object) null;
                break;
              case 2:
                object castedContainer = this.castedContainer;
                if (castedContainer == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
                  continue;
                }
                obj1 = ((IPropertyValueContainer) castedContainer).Get(obj);
                break;
              default:
                goto label_9;
            }
            if (obj1 == null)
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            else
              break;
          }
          return obj1;
label_9:
          return this.value;
        }

        void IPropertyValueContainer.Set(object obj, object value)
        {
          int num = 3;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_4;
              case 1:
                goto label_3;
              case 2:
                this.value = (object) (DataClass) value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
                continue;
              case 3:
                if (this.castedContainer == null)
                {
                  num = 2;
                  continue;
                }
                goto case 4;
              case 4:
                DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer.SZvIWiZ1CPuyywGmyvcP(this.castedContainer, obj, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_4:
          return;
label_3:
          return;
label_2:;
        }

        Type IPropertyValueContainer.PropertyType
        {
          get
          {
            int num = 2;
            Type propertyType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  propertyType = (Type) null;
                  break;
                case 2:
                  object castedContainer = this.castedContainer;
                  if (castedContainer == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                    continue;
                  }
                  propertyType = DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer.m8n4MfZ1v0bsVaYePBdR(castedContainer);
                  break;
                default:
                  goto label_9;
              }
              if ((object) propertyType == null)
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              else
                break;
            }
            return propertyType;
label_9:
            return TypeOf<DataClass>.Raw;
          }
        }

        IPropertyValueContainer<T> DataClass.IPropertyValueContainerCast.Cast<T>()
        {
          if (this.castedContainer == null)
          {
            ((DataClass.DataClassPropertyValueContainer) this.dataClassPropertyValueContainer).propertyDefaultValueContainer = (object) new DataClass.PropertyValueContainer<T>((Func<T>) null);
            this.castedContainer = (object) new DataClass.PropertyValueContainer<T>(((DataClass) this.value)?.As(typeof (T)));
            this.value = (object) null;
          }
          return (IPropertyValueContainer<T>) this.castedContainer;
        }

        IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer((DataClass.DataClassPropertyValueContainer) this.dataClassPropertyValueContainer);

        internal static void maYRyDZ1QW60IABt4CsR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool K09qIjZ1Ev2rC0tv1qW4() => DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer.EQXokPZ1GnwIROWK6Y2O == null;

        internal static DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer P6lsGpZ1fndJ3ZZP7d0p() => (DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer) DataClass.DataClassPropertyValueContainer.NestedDefaultValueContainer.EQXokPZ1GnwIROWK6Y2O;

        internal static void SZvIWiZ1CPuyywGmyvcP([In] object obj0, [In] object obj1, [In] object obj2) => ((IPropertyValueContainer) obj0).Set(obj1, obj2);

        internal static Type m8n4MfZ1v0bsVaYePBdR([In] object obj0) => ((IPropertyValueContainer) obj0).PropertyType;
      }
    }

    private class PropertyAnyTypeValueContainer : IPropertyDefaultValueContainer
    {
      private object propertyDefaultValueContainer;
      private static object KofDlK8JO3gD52SmfLmH;

      public PropertyAnyTypeValueContainer(object defaultValue)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.propertyDefaultValueContainer = (object) new DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer(this, defaultValue);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) DataClass.PropertyAnyTypeValueContainer.MhlVnC8JPTjjPI38Pv2v(this.propertyDefaultValueContainer);

      internal static bool GpOghZ8J2F64CRUfIJwx() => DataClass.PropertyAnyTypeValueContainer.KofDlK8JO3gD52SmfLmH == null;

      internal static DataClass.PropertyAnyTypeValueContainer rNQPBK8JeYWePRP9m3l2() => (DataClass.PropertyAnyTypeValueContainer) DataClass.PropertyAnyTypeValueContainer.KofDlK8JO3gD52SmfLmH;

      internal static object MhlVnC8JPTjjPI38Pv2v([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

      private class NestedDefaultValueContainer : 
        DataClass.IPropertyValueContainerCast,
        IPropertyValueContainer,
        IPropertyDefaultValueContainer
      {
        private readonly object propertyAnyTypeValueContainer;
        private object value;
        private object castedContainer;
        internal static object MDkggbZ18o2UvN2VGnNc;

        public NestedDefaultValueContainer(
          DataClass.PropertyAnyTypeValueContainer propertyAnyTypeValueContainer,
          object value)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.propertyAnyTypeValueContainer = (object) propertyAnyTypeValueContainer;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 0;
                continue;
              case 2:
                this.value = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                continue;
              default:
                goto label_6;
            }
          }
label_3:
          return;
label_6:;
        }

        object IPropertyValueContainer.Get(object obj)
        {
          int num = 1;
          object obj1;
          while (true)
          {
            switch (num)
            {
              case 1:
                object castedContainer = this.castedContainer;
                if (castedContainer == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                  continue;
                }
                obj1 = DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer.LDpgwaZ1IV7kAiUffcCY(castedContainer, obj);
                break;
              case 2:
                goto label_9;
              default:
                obj1 = (object) null;
                break;
            }
            if (obj1 == null)
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 0;
            else
              break;
          }
          return obj1;
label_9:
          return this.value;
        }

        void IPropertyValueContainer.Set(object obj, object val)
        {
          int num = 4;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_4;
              case 1:
                DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer.lBh81JZ1VNE85pu9lfCn(this.castedContainer, obj, val);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              case 3:
                this.value = val;
                num = 2;
                continue;
              case 4:
                if (this.castedContainer == null)
                {
                  num = 3;
                  continue;
                }
                goto case 1;
              default:
                goto label_2;
            }
          }
label_4:
          return;
label_3:
          return;
label_2:;
        }

        Type IPropertyValueContainer.PropertyType
        {
          get
          {
            int num = 4;
            Type propertyType1;
            Type propertyType2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  object obj = this.value;
                  if (obj == null)
                  {
                    num = 2;
                    continue;
                  }
                  propertyType1 = DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer.qcbFWUZ1iwHhswn8Txfo(obj);
                  goto label_13;
                case 2:
                  propertyType1 = (Type) null;
                  goto label_13;
                case 3:
                  propertyType2 = (Type) null;
                  break;
                case 4:
                  object castedContainer = this.castedContainer;
                  if (castedContainer == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 0;
                    continue;
                  }
                  propertyType2 = DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer.xh0fsWZ1S1A77k6kFmlA(castedContainer);
                  break;
                default:
                  goto label_15;
              }
              if ((object) propertyType2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
                continue;
              }
              break;
label_13:
              if ((object) propertyType1 == null)
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              else
                goto label_9;
            }
            return propertyType2;
label_9:
            return propertyType1;
label_15:
            return TypeOf<object>.Raw;
          }
        }

        IPropertyValueContainer<T> DataClass.IPropertyValueContainerCast.Cast<T>()
        {
          if (this.castedContainer == null)
          {
            if (((DataClass.PropertyAnyTypeValueContainer) this.propertyAnyTypeValueContainer).propertyDefaultValueContainer is DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer defaultValueContainer)
              ((DataClass.PropertyAnyTypeValueContainer) this.propertyAnyTypeValueContainer).propertyDefaultValueContainer = (object) new DataClass.PropertyValueContainer<T>(defaultValueContainer.value ?? (object) default (T));
            if (this.value != null && TypeOf<T>.Raw != TypeOf<object>.Raw && !TypeOf<T>.Raw.IsInstanceOfType(this.value))
            {
              object obj = this.value;
              TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(TypeOf<T>.Raw);
              if (!converter.CanConvertFrom(obj.GetType()))
                obj = obj is IFormattable formattable ? (object) formattable.ToString((string) null, (IFormatProvider) CultureInfo.InvariantCulture) : (object) obj.ToString();
              if (converter.CanConvertFrom(obj.GetType()))
                this.value = converter.ConvertFrom((ITypeDescriptorContext) null, CultureInfo.InvariantCulture, obj);
            }
            this.castedContainer = (object) new DataClass.PropertyValueContainer<T>(this.value ?? (object) default (T));
            this.value = (object) null;
          }
          return (IPropertyValueContainer<T>) this.castedContainer;
        }

        IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer((DataClass.PropertyAnyTypeValueContainer) this.propertyAnyTypeValueContainer, this.value);

        internal static bool rLQWqXZ1Z2lc5jVwf9yQ() => DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer.MDkggbZ18o2UvN2VGnNc == null;

        internal static DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer LHM7HpZ1uyHvW8U7RvIB() => (DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer) DataClass.PropertyAnyTypeValueContainer.NestedDefaultValueContainer.MDkggbZ18o2UvN2VGnNc;

        internal static object LDpgwaZ1IV7kAiUffcCY([In] object obj0, [In] object obj1) => ((IPropertyValueContainer) obj0).Get(obj1);

        internal static void lBh81JZ1VNE85pu9lfCn([In] object obj0, [In] object obj1, [In] object obj2) => ((IPropertyValueContainer) obj0).Set(obj1, obj2);

        internal static Type xh0fsWZ1S1A77k6kFmlA([In] object obj0) => ((IPropertyValueContainer) obj0).PropertyType;

        internal static Type qcbFWUZ1iwHhswn8Txfo([In] object obj0) => obj0.GetType();
      }
    }

    private class PropertyCollectionValueContainer<TProp, TVal> : IPropertyDefaultValueContainer where TVal : class, TProp, new()
    {
      private static object Wl7cPL8J1TQNmH9C2lVo;

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new DataClass.PropertyValueContainer<TProp>((object) new TVal());

      public PropertyCollectionValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool r5EXbX8JN96YQ3LBJKvr() => DataClass.PropertyCollectionValueContainer<TProp, TVal>.Wl7cPL8J1TQNmH9C2lVo == null;

      internal static object YvDqLR8J3SHH1rMFWnKY() => DataClass.PropertyCollectionValueContainer<TProp, TVal>.Wl7cPL8J1TQNmH9C2lVo;
    }

    private class PropertyCollectionValueContainer : IPropertyDefaultValueContainer
    {
      private object propertyDefaultValueContainer;
      private static object OCuvQ68JpDygB5lHx9HU;

      public PropertyCollectionValueContainer(Type tTarget)
      {
        DataClass.PropertyCollectionValueContainer.xexW9l8JtZxMURGLTRar();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              // ISSUE: type reference
              this.propertyDefaultValueContainer = (object) (IPropertyDefaultValueContainer) DataClass.PropertyCollectionValueContainer.Jod5r88J4lrX8Iv5wwfN(DataClass.PropertyCollectionValueContainer.OdjoOV8Jwe15MU69ylwg(__typeref (DataClass.PropertyCollectionValueContainer.NestedDefaultValueContainer<>)).MakeGenericType(tTarget), (object) new object[1]
              {
                (object) this
              });
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

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => ((IPropertyDefaultValueContainer) this.propertyDefaultValueContainer).Initialize();

      internal static void xexW9l8JtZxMURGLTRar() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static Type OdjoOV8Jwe15MU69ylwg([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object Jod5r88J4lrX8Iv5wwfN([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

      internal static bool u7cr2b8Jae0hESEjkGqC() => DataClass.PropertyCollectionValueContainer.OCuvQ68JpDygB5lHx9HU == null;

      internal static DataClass.PropertyCollectionValueContainer thWYcN8JDwEiBt3T0bBj() => (DataClass.PropertyCollectionValueContainer) DataClass.PropertyCollectionValueContainer.OCuvQ68JpDygB5lHx9HU;

      private class NestedDefaultValueContainer<TValue> : 
        DataClass.IPropertyValueContainerCast,
        IPropertyValueContainer,
        IPropertyDefaultValueContainer
      {
        private readonly DataClass.PropertyCollectionValueContainer propertyCollectionValueContainer;
        private ICollection<TValue> value;
        private IPropertyValueContainer castedContainer;
        internal static object JwuCaLZ1RVmDaFrARAs2;

        public NestedDefaultValueContainer(
          DataClass.PropertyCollectionValueContainer propertyCollectionValueContainer)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.value = TypeOf<IEntity>.Raw.IsAssignableFrom(TypeOf<TValue>.Raw) ? (ICollection<TValue>) new HashedSet<TValue>() : (ICollection<TValue>) new List<TValue>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                continue;
              case 2:
                this.propertyCollectionValueContainer = propertyCollectionValueContainer;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }

        object IPropertyValueContainer.Get(object obj)
        {
          int num = 1;
          object obj1;
          while (true)
          {
            switch (num)
            {
              case 1:
                IPropertyValueContainer castedContainer = this.castedContainer;
                if (castedContainer == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                  continue;
                }
                obj1 = castedContainer.Get(obj);
                break;
              case 2:
                goto label_9;
              default:
                obj1 = (object) null;
                break;
            }
            if (obj1 == null)
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 2 : 2;
            else
              break;
          }
          return obj1;
label_9:
          return (object) this.value;
        }

        void IPropertyValueContainer.Set(object obj, object value)
        {
          int num = 3;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_2;
              case 2:
                this.value = (ICollection<TValue>) value;
                num = 4;
                continue;
              case 3:
                if (this.castedContainer == null)
                {
                  num = 2;
                  continue;
                }
                break;
              case 4:
                goto label_7;
            }
            this.castedContainer.Set(obj, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
          }
label_2:
          return;
label_7:;
        }

        Type IPropertyValueContainer.PropertyType
        {
          get
          {
            int num = 2;
            Type propertyType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  propertyType = (Type) null;
                  break;
                case 2:
                  IPropertyValueContainer castedContainer = this.castedContainer;
                  if (castedContainer == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                    continue;
                  }
                  propertyType = castedContainer.PropertyType;
                  break;
                default:
                  goto label_9;
              }
              if ((object) propertyType == null)
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              else
                break;
            }
            return propertyType;
label_9:
            return TypeOf<ICollection<TValue>>.Raw;
          }
        }

        IPropertyValueContainer<T> DataClass.IPropertyValueContainerCast.Cast<T>()
        {
          if (this.castedContainer == null)
          {
            this.propertyCollectionValueContainer.propertyDefaultValueContainer = (object) (IPropertyDefaultValueContainer) Activator.CreateInstance(typeof (DataClass.PropertyCollectionValueContainer<,>).MakeGenericType(typeof (T), TypeOf<IEntity>.Raw.IsAssignableFrom(TypeOf<TValue>.Raw) ? TypeOf<HashedSet<TValue>>.Raw : TypeOf<List<TValue>>.Raw));
            IPropertyValueContainer<T> propertyValueContainer = (IPropertyValueContainer<T>) ((IPropertyDefaultValueContainer) this.propertyCollectionValueContainer.propertyDefaultValueContainer).Initialize();
            if (this.value != null)
            {
              ICollection<TValue> objs = (ICollection<TValue>) (object) propertyValueContainer.Get((object) null);
              foreach (TValue obj in (IEnumerable<TValue>) this.value)
                objs.Add(obj);
            }
            else
              propertyValueContainer.Set((object) null, (object) null);
            this.castedContainer = (IPropertyValueContainer) propertyValueContainer;
            this.value = (ICollection<TValue>) null;
          }
          return (IPropertyValueContainer<T>) this.castedContainer;
        }

        IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new DataClass.PropertyCollectionValueContainer.NestedDefaultValueContainer<TValue>(this.propertyCollectionValueContainer);

        internal static bool fZJFC0Z1qerY11dyFg6K() => DataClass.PropertyCollectionValueContainer.NestedDefaultValueContainer<TValue>.JwuCaLZ1RVmDaFrARAs2 == null;

        internal static object KLuTbuZ1K5a6xh6kORCn() => DataClass.PropertyCollectionValueContainer.NestedDefaultValueContainer<TValue>.JwuCaLZ1RVmDaFrARAs2;
      }
    }

    private class PropertyInfo : System.Reflection.PropertyInfo
    {
      private static readonly object IndexParameters;
      private readonly object getMethod;
      private readonly object setMethod;
      private readonly object accessors;
      internal static object KYoxum8J6C6wiieRAceF;

      public PropertyInfo(string name, Type propertyType, Guid metadataUid, Guid propertyUid)
      {
        DataClass.PropertyInfo.t6Oo1X8J7Ip3ZgtVZ18U();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num1 = 4;
        while (true)
        {
          int num2;
          Type raw;
          switch (num1)
          {
            case 1:
              this.getMethod = (object) new DataClass.PropertyInfo.GetPropertyMethodInfo(raw, name, propertyType, metadataUid, propertyUid);
              num2 = 6;
              break;
            case 2:
              this.DeclaringType = raw;
              num1 = 5;
              continue;
            case 3:
              goto label_3;
            case 4:
              raw = TypeOf<DataClass>.Raw;
              num2 = 2;
              break;
            case 5:
              this.Name = name;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 7 : 4;
              continue;
            case 6:
              this.setMethod = (object) new DataClass.PropertyInfo.SetPropertyMethodInfo(raw, name, propertyType, metadataUid, propertyUid);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
              continue;
            case 7:
              this.PropertyType = propertyType;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
              continue;
            default:
              System.Reflection.MethodInfo[] methodInfoArray;
              if (!((System.Reflection.MethodInfo) this.setMethod != (System.Reflection.MethodInfo) null))
                methodInfoArray = new System.Reflection.MethodInfo[1]
                {
                  (System.Reflection.MethodInfo) this.getMethod
                };
              else
                methodInfoArray = new System.Reflection.MethodInfo[2]
                {
                  (System.Reflection.MethodInfo) this.getMethod,
                  (System.Reflection.MethodInfo) this.setMethod
                };
              this.accessors = (object) methodInfoArray;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 3 : 3;
              continue;
          }
          num1 = num2;
        }
label_3:;
      }

      public override PropertyAttributes Attributes => PropertyAttributes.None;

      public override bool CanRead => true;

      public override bool CanWrite => true;

      public override string Name { get; }

      public override Type PropertyType { get; }

      public override Type DeclaringType { get; }

      public override Type ReflectedType { get; }

      public override Module Module => this.DeclaringType.Module;

      public override object GetValue(
        object obj,
        BindingFlags invokeAttr,
        Binder binder,
        object[] index,
        CultureInfo culture)
      {
        return ((MethodBase) this.getMethod).Invoke(obj, (object[]) null);
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
              ((MethodBase) this.setMethod).Invoke(obj, new object[1]
              {
                value
              });
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public override ParameterInfo[] GetIndexParameters() => (ParameterInfo[]) DataClass.PropertyInfo.IndexParameters;

      public override System.Reflection.MethodInfo GetGetMethod(bool nonPublic) => (System.Reflection.MethodInfo) this.getMethod;

      public override System.Reflection.MethodInfo GetSetMethod(bool nonPublic) => (System.Reflection.MethodInfo) this.setMethod;

      public override System.Reflection.MethodInfo[] GetAccessors(bool nonPublic) => (System.Reflection.MethodInfo[]) this.accessors;

      public override IList<CustomAttributeData> GetCustomAttributesData() => (IList<CustomAttributeData>) Array.Empty<CustomAttributeData>();

      public override bool IsDefined(Type attributeType, bool inherit) => false;

      public override object[] GetCustomAttributes(bool inherit) => Array.Empty<object>();

      public override object[] GetCustomAttributes(Type attributeType, bool inherit) => Array.Empty<object>();

      public override string ToString() => (string) DataClass.PropertyInfo.NsKm218J06AE7ysodXph(DataClass.PropertyInfo.JQyjW18JxTyGENuJB1NO(1461825605 - 1531863589 ^ -70078352), (object) this.PropertyType, (object) this.Name);

      static PropertyInfo()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              DataClass.PropertyInfo.t6Oo1X8J7Ip3ZgtVZ18U();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              DataClass.PropertyInfo.IndexParameters = (object) new ParameterInfo[0];
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static void t6Oo1X8J7Ip3ZgtVZ18U() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool Sc3aGD8JHqLA3e8w2YDQ() => DataClass.PropertyInfo.KYoxum8J6C6wiieRAceF == null;

      internal static DataClass.PropertyInfo QQk7W98JACyNajydEiaA() => (DataClass.PropertyInfo) DataClass.PropertyInfo.KYoxum8J6C6wiieRAceF;

      internal static object JQyjW18JxTyGENuJB1NO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object NsKm218J06AE7ysodXph([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

      private class MethodParameterInfo : ParameterInfo
      {
        private static object IUsi7NZ1XINXmEYRNMwm;

        public MethodParameterInfo(
          MemberInfo member,
          Type parameterType,
          string name = null,
          int position = -1)
        {
          DataClass.PropertyInfo.MethodParameterInfo.GF02knZ1nYevafDDg1tD();
          this.CustomAttributes = (IEnumerable<CustomAttributeData>) new CustomAttributeData[0];
          this.DefaultValue = (object) DBNull.Value;
          this.RawDefaultValue = (object) DBNull.Value;
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                this.NameImpl = name;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 3 : 2;
                continue;
              case 3:
                this.PositionImpl = position;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 1;
                continue;
              case 4:
                this.ClassImpl = parameterType;
                num = 2;
                continue;
              case 5:
                this.DefaultValueImpl = (object) null;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
                continue;
              case 6:
                this.AttrsImpl = ParameterAttributes.None;
                num = 5;
                continue;
              default:
                this.MemberImpl = member;
                num = 4;
                continue;
            }
          }
label_3:;
        }

        public override IEnumerable<CustomAttributeData> CustomAttributes { get; }

        public override object DefaultValue { get; }

        public override bool HasDefaultValue => false;

        public override object RawDefaultValue { get; }

        internal static void GF02knZ1nYevafDDg1tD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool Q5ljWUZ1TZEN3KEBKX8p() => DataClass.PropertyInfo.MethodParameterInfo.IUsi7NZ1XINXmEYRNMwm == null;

        internal static DataClass.PropertyInfo.MethodParameterInfo B8rxrCZ1k7a2rZNvjEYa() => (DataClass.PropertyInfo.MethodParameterInfo) DataClass.PropertyInfo.MethodParameterInfo.IUsi7NZ1XINXmEYRNMwm;
      }

      private abstract class MethodInfo : System.Reflection.MethodInfo
      {
        internal static object vSeBGnZ1Ooh4DdaPL0Iq;

        public MethodInfo(Type declaringType, string name)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.DeclaringType = declaringType;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              case 2:
                this.Name = name;
                num = 3;
                continue;
              case 3:
                goto label_3;
              default:
                this.ReflectedType = declaringType;
                num = 2;
                continue;
            }
          }
label_3:;
        }

        public override string Name { get; }

        public override Type DeclaringType { get; }

        public override Type ReflectedType { get; }

        public override string ToString() => (string) DataClass.PropertyInfo.MethodInfo.bIilkiZ137yLmNEdRsel(DataClass.PropertyInfo.MethodInfo.UDYsJlZ1PIJmoDvDbMZg(1242972401 >> 4 ^ 77734077), (object) this.ReturnType, DataClass.PropertyInfo.MethodInfo.Ht7yu3Z119FyWp73pLhk((object) this), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470443356), ((IEnumerable<ParameterInfo>) DataClass.PropertyInfo.MethodInfo.bSQCMNZ1Nu7DhaqMoODn((object) this)).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (p => p.ParameterType.ToString()))));

        public override MethodAttributes Attributes => MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName;

        public override CallingConventions CallingConvention => CallingConventions.Standard | CallingConventions.HasThis;

        public override bool IsSecurityCritical => true;

        public override bool IsSecuritySafeCritical => false;

        public override bool IsSecurityTransparent => false;

        public override MethodImplAttributes MethodImplementationFlags => MethodImplAttributes.CodeTypeMask;

        public override MethodImplAttributes GetMethodImplementationFlags() => MethodImplAttributes.CodeTypeMask;

        public override System.Reflection.MethodInfo GetBaseDefinition() => (System.Reflection.MethodInfo) this;

        public override RuntimeMethodHandle MethodHandle => throw new NotImplementedException();

        public override ICustomAttributeProvider ReturnTypeCustomAttributes => (ICustomAttributeProvider) DataClass.PropertyInfo.MethodInfo.YV3URrZ1pmP21itS35kI((object) this);

        public override object[] GetCustomAttributes(bool inherit) => Array.Empty<object>();

        public override object[] GetCustomAttributes(Type attributeType, bool inherit) => Array.Empty<object>();

        public override bool IsDefined(Type attributeType, bool inherit) => false;

        internal static bool qyg6MmZ12NO9KxvirfaM() => DataClass.PropertyInfo.MethodInfo.vSeBGnZ1Ooh4DdaPL0Iq == null;

        internal static DataClass.PropertyInfo.MethodInfo IH4S23Z1eKiN4XhCQyVN() => (DataClass.PropertyInfo.MethodInfo) DataClass.PropertyInfo.MethodInfo.vSeBGnZ1Ooh4DdaPL0Iq;

        internal static object UDYsJlZ1PIJmoDvDbMZg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object Ht7yu3Z119FyWp73pLhk([In] object obj0) => (object) ((MemberInfo) obj0).Name;

        internal static object bSQCMNZ1Nu7DhaqMoODn([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

        internal static object bIilkiZ137yLmNEdRsel(
          [In] object obj0,
          [In] object obj1,
          [In] object obj2,
          [In] object obj3)
        {
          return (object) string.Format((string) obj0, obj1, obj2, obj3);
        }

        internal static object YV3URrZ1pmP21itS35kI([In] object obj0) => (object) ((System.Reflection.MethodInfo) obj0).ReturnParameter;
      }

      private class GetPropertyMethodInfo : DataClass.PropertyInfo.MethodInfo
      {
        private static readonly object getParameters;
        private readonly Guid metadataUid;
        private readonly Guid propertyUid;
        private static object VgmDuiZ1aUnCVs4WXLkH;

        public GetPropertyMethodInfo(
          Type declaringType,
          string name,
          Type type,
          Guid metadataUid,
          Guid propertyUid)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector(declaringType, (string) DataClass.PropertyInfo.GetPropertyMethodInfo.dxCWIBZ14TiopTMBBjKo(DataClass.PropertyInfo.GetPropertyMethodInfo.Di9yGnZ1w8yA2BPqpuMu(-1217523399 ^ -1217520199), (object) name));
          int num = 3;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.metadataUid = metadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              case 3:
                this.ReturnType = type;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 4 : 0;
                continue;
              case 4:
                this.ReturnParameter = (ParameterInfo) new DataClass.PropertyInfo.MethodParameterInfo((MemberInfo) this, type);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
                continue;
              default:
                this.propertyUid = propertyUid;
                num = 2;
                continue;
            }
          }
label_2:;
        }

        public override Type ReturnType { get; }

        public override ParameterInfo ReturnParameter { get; }

        public override ParameterInfo[] GetParameters() => (ParameterInfo[]) DataClass.PropertyInfo.GetPropertyMethodInfo.getParameters;

        public override object Invoke(
          object obj,
          BindingFlags invokeAttr,
          Binder binder,
          object[] parameters,
          CultureInfo culture)
        {
          return DataClass.PropertyInfo.GetPropertyMethodInfo.iHRCQjZ16tCH1HDA4XOe((object) (DataClass) obj, this.metadataUid, this.propertyUid);
        }

        static GetPropertyMethodInfo()
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                DataClass.PropertyInfo.GetPropertyMethodInfo.getParameters = (object) new ParameterInfo[0];
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                continue;
              case 2:
                DataClass.PropertyInfo.GetPropertyMethodInfo.keCKLDZ1HlFyNpNE0csK();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }

        internal static object Di9yGnZ1w8yA2BPqpuMu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object dxCWIBZ14TiopTMBBjKo([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

        internal static bool j5FW5IZ1D0tAgNNlqfC0() => DataClass.PropertyInfo.GetPropertyMethodInfo.VgmDuiZ1aUnCVs4WXLkH == null;

        internal static DataClass.PropertyInfo.GetPropertyMethodInfo UrbvlXZ1tMOsONF1koAA() => (DataClass.PropertyInfo.GetPropertyMethodInfo) DataClass.PropertyInfo.GetPropertyMethodInfo.VgmDuiZ1aUnCVs4WXLkH;

        internal static object iHRCQjZ16tCH1HDA4XOe(
          [In] object obj0,
          Guid metadataUid,
          Guid propertyUid)
        {
          return ((DataClass) obj0).GetObject(metadataUid, propertyUid);
        }

        internal static void keCKLDZ1HlFyNpNE0csK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }

      private class SetPropertyMethodInfo : DataClass.PropertyInfo.MethodInfo
      {
        private readonly object getParameters;
        private readonly Guid metadataUid;
        private readonly Guid propertyUid;
        internal static object ngOfVIZ1AJV4hTDZjhfH;

        public SetPropertyMethodInfo(
          Type declaringType,
          string name,
          Type type,
          Guid metadataUid,
          Guid propertyUid)
        {
          DataClass.PropertyInfo.SetPropertyMethodInfo.uL6NUvZ10SQW91JAeyTD();
          // ISSUE: explicit constructor call
          base.\u002Ector(declaringType, (string) DataClass.PropertyInfo.SetPropertyMethodInfo.evRk4cZ1mw9BywSa6jxZ(-2138958856 ^ -2138955916) + name);
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.propertyUid = propertyUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 2;
                continue;
              case 2:
                goto label_3;
              case 3:
                // ISSUE: type reference
                this.ReturnParameter = (ParameterInfo) new DataClass.PropertyInfo.MethodParameterInfo((MemberInfo) this, DataClass.PropertyInfo.SetPropertyMethodInfo.pvA8P5Z1yxBEhyJQ8pRM(__typeref (void)));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 4;
                continue;
              case 4:
                this.metadataUid = metadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                continue;
              default:
                this.getParameters = (object) (ParameterInfo[]) new DataClass.PropertyInfo.MethodParameterInfo[1]
                {
                  new DataClass.PropertyInfo.MethodParameterInfo((MemberInfo) this, type, (string) DataClass.PropertyInfo.SetPropertyMethodInfo.evRk4cZ1mw9BywSa6jxZ(~-306453669 ^ 306468306), 0)
                };
                num = 3;
                continue;
            }
          }
label_3:;
        }

        public override Type ReturnType => DataClass.PropertyInfo.SetPropertyMethodInfo.pvA8P5Z1yxBEhyJQ8pRM(__typeref (void));

        public override ParameterInfo ReturnParameter { get; }

        public override ParameterInfo[] GetParameters() => (ParameterInfo[]) this.getParameters;

        public override object Invoke(
          object obj,
          BindingFlags invokeAttr,
          Binder binder,
          object[] parameters,
          CultureInfo culture)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                DataClass.PropertyInfo.SetPropertyMethodInfo.cBGeySZ1MnL9jbtNgLKd((object) (DataClass) obj, this.metadataUid, this.propertyUid, parameters[0]);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          return (object) null;
        }

        internal static void uL6NUvZ10SQW91JAeyTD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static object evRk4cZ1mw9BywSa6jxZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static Type pvA8P5Z1yxBEhyJQ8pRM([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

        internal static bool tTsqEoZ17V250gWESXc5() => DataClass.PropertyInfo.SetPropertyMethodInfo.ngOfVIZ1AJV4hTDZjhfH == null;

        internal static DataClass.PropertyInfo.SetPropertyMethodInfo FX5Ou9Z1xFFTDX4rfv9U() => (DataClass.PropertyInfo.SetPropertyMethodInfo) DataClass.PropertyInfo.SetPropertyMethodInfo.ngOfVIZ1AJV4hTDZjhfH;

        internal static void cBGeySZ1MnL9jbtNgLKd(
          [In] object obj0,
          Guid metadataUid,
          Guid propertyUid,
          [In] object obj3)
        {
          ((DataClass) obj0).SetObject(metadataUid, propertyUid, obj3);
        }
      }
    }

    internal interface IPropertyValueContainerCast : IPropertyValueContainer
    {
      IPropertyValueContainer<T> Cast<T>();
    }

    private class PropertyValueContainer<T> : 
      IPropertyValueContainer<T>,
      IPropertyValueContainer,
      IPropertyDefaultValueContainer,
      DataClass.IPropertyValueContainerCast
    {
      private T value;
      private Func<T> valueFactory;
      internal static object fTBx3j8JJlqn8P7OcVf2;

      /// <summary>Ctor</summary>
      /// <param name="value">Объект контейнера</param>
      public PropertyValueContainer(object value)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.value = (T) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Ctor</summary>
      /// <param name="valueFactory">Фабрика значения</param>
      public PropertyValueContainer(Func<T> valueFactory)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.valueFactory = valueFactory;
      }

      object IPropertyValueContainer.Get(object obj) => (object) this.value;

      void IPropertyValueContainer.Set(object obj, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.value = (T) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      T IPropertyValueContainer<T>.Get(object obj) => this.value;

      void IPropertyValueContainer<T>.Set(object obj, T value) => this.value = value;

      Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.valueFactory == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        T obj = this.value;
        goto label_6;
label_5:
        obj = this.valueFactory();
label_6:
        return (IPropertyValueContainer) new DataClass.PropertyValueContainer<T>((object) obj);
      }

      IPropertyValueContainer<T1> DataClass.IPropertyValueContainerCast.Cast<T1>() => (IPropertyValueContainer<T1>) this;

      internal static bool xCgvVp8J9jR3RD79y066() => DataClass.PropertyValueContainer<T>.fTBx3j8JJlqn8P7OcVf2 == null;

      internal static object qlVanw8JdJtyfFGNDhmB() => DataClass.PropertyValueContainer<T>.fTBx3j8JJlqn8P7OcVf2;
    }

    protected internal abstract class ValueContainer
    {
      private static readonly ConcurrentDictionary<Type, DataClass.ValueContainer> DTOTypesValueContainers;
      private static readonly IDictionary<Guid, DataClass.ValueContainer> ViewModelValueContainers;
      private static readonly ConcurrentDictionary<Guid, DataClass.ValueContainer> DTOHeaderValueContainers;
      private static readonly ConcurrentDictionary<(Guid componentUid, Guid metadataUid), DataClass.ValueContainer> ComponentValueContainers;
      private static readonly ConcurrentDictionary<(Guid moduleHeaderUid, Guid componentUid, Guid metadataUid), DataClass.ValueContainer> ModuleHeaderValueContainers;
      private static readonly ConcurrentDictionary<(Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid), DataClass.ValueContainer> ModuleValueContainers;
      internal static DataClass.ValueContainer I7AcvZ8JlpEU0y7Ln0bi;

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для типа DTO
      /// </summary>
      /// <remarks>Используется для SDK.DTO</remarks>
      /// <typeparam name="T">Тип DTO</typeparam>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      public static DataClass.ValueContainer Create<T>() => DataClass.ValueContainer.Create(typeof (T));

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для типа DTO
      /// </summary>
      /// <remarks>Используется для SDK.DTO</remarks>
      /// <param name="type">Тип DTO</param>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      internal static DataClass.ValueContainer Create(Type type)
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              DataClass.ValueContainer.ylPCBI8JYRxb8nGhJCR7(DataClass.ValueContainer.rSivU28J5ksUmHtZXe2w(type, TypeOf<DataClass>.Raw), DataClass.ValueContainer.qx3rpL8JjnH5h78mNLml(~541731958 ^ -541861525));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return DataClass.ValueContainer.DTOTypesValueContainers.GetOrAdd(type, (Func<Type, DataClass.ValueContainer>) (t =>
        {
          int num2 = 5;
          ComponentMetadata componentMetadata;
          DataClassMetadata metadata;
          while (true)
          {
            int num3 = num2;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (DataClass.ValueContainer.\u003C\u003Ec.L3L42YZ3ZiHRYskCdUid(DataClass.ValueContainer.\u003C\u003Ec.LDsU3GZ38ZosQLaPMhnX((object) metadata), Guid.Empty))
                  {
                    num3 = 9;
                    continue;
                  }
                  goto label_8;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  componentMetadata = (ComponentMetadata) MetadataLoader.LoadMetadata(DataClass.ValueContainer.\u003C\u003Ec.anwdeOZ3vWJuxmged7lQ((object) t));
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                  continue;
                case 3:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (!DataClass.ValueContainer.\u003C\u003Ec.L3L42YZ3ZiHRYskCdUid(DataClass.ValueContainer.\u003C\u003Ec.LDsU3GZ38ZosQLaPMhnX((object) metadata), Guid.Empty))
                  {
                    num3 = 8;
                    continue;
                  }
                  goto label_11;
                case 4:
                  metadata = DataClass.LoadMetadata(t);
                  num3 = 7;
                  continue;
                case 5:
                  num3 = 4;
                  continue;
                case 6:
                  if (!t.IsNested)
                  {
                    num3 = 3;
                    continue;
                  }
                  goto case 2;
                case 7:
                  goto label_3;
                case 8:
                  goto label_12;
                case 9:
                  goto label_7;
                case 10:
                  goto label_11;
                default:
                  goto label_16;
              }
            }
label_3:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (!DataClass.ValueContainer.\u003C\u003Ec.k4UhNuZ3CN0nqlavBAJq(DataClass.ValueContainer.\u003C\u003Ec.oCqQ2KZ3QDbxT6M3UX4d((object) metadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334892485)))
              num2 = 6;
            else
              goto label_16;
          }
label_7:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (DataClass.ValueContainer) DataClass.ValueContainer.\u003C\u003Ec.fLBBqsZ3IkKtsv9BePIU(metadata.ModuleUid, DataClass.ValueContainer.\u003C\u003Ec.ElMNoUZ3uHa3jWpyMDrV((object) componentMetadata), DataClass.ValueContainer.\u003C\u003Ec.ElMNoUZ3uHa3jWpyMDrV((object) metadata));
label_8:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (DataClass.ValueContainer) new DataClass.ValueContainer.DataClassMetadataValueContainer(componentMetadata.DataClasses.First<DataClassMetadata>((Func<DataClassMetadata, bool>) (a => DataClass.ValueContainer.\u003C\u003Ec__DisplayClass1_0.KEjyjAZ3bEsO9pjPqHjw((object) a) == DataClass.ValueContainer.\u003C\u003Ec__DisplayClass1_0.KEjyjAZ3bEsO9pjPqHjw((object) metadata))));
label_11:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (DataClass.ValueContainer) DataClass.ValueContainer.\u003C\u003Ec.fLBBqsZ3IkKtsv9BePIU(metadata.ModuleUid, Guid.Empty, DataClass.ValueContainer.\u003C\u003Ec.ElMNoUZ3uHa3jWpyMDrV((object) metadata));
label_12:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (DataClass.ValueContainer) DataClass.ValueContainer.\u003C\u003Ec.KRWURUZ3V92rnVEaPar7(DataClass.ValueContainer.\u003C\u003Ec.ElMNoUZ3uHa3jWpyMDrV((object) metadata));
label_16:
          return (DataClass.ValueContainer) new DataClass.ValueContainer.DataClassMetadataValueContainer(metadata);
        }));
      }

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для ViewModelContext из <see cref="T:EleWise.ELMA.Model.Metadata.EntityMetadata" />
      /// </summary>
      /// <param name="entityMetadata">Метаданные сущности</param>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      internal static DataClass.ValueContainer CreateViewModelValueContainer(
        EntityMetadata entityMetadata)
      {
        int num = 1;
        EntityMetadata entityMetadata1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              entityMetadata1 = entityMetadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 2;
              continue;
          }
        }
label_3:
        return DataClass.ValueContainer.ViewModelValueContainers.GetOrAdd<Guid, DataClass.ValueContainer>(DataClass.ValueContainer.wdS8aM8JLKc2lALUI0nu((object) entityMetadata1), (Func<Guid, DataClass.ValueContainer>) (metadataUid => (DataClass.ValueContainer) new DataClass.ValueContainer.EntityMetadataValueContainer(entityMetadata1)));
      }

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для ViewModelContext из уникального идентификатора обладателя метаданных
      /// </summary>
      /// <param name="ownerMetadataUid">Уникальный идентификатор обладателя метаданных</param>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      public static DataClass.ValueContainer CreateViewModelMetadataHeaderValueContainer(
        Guid ownerMetadataUid)
      {
        return (DataClass.ValueContainer) new DataClass.ValueContainer.ViewModelMetadataHeaderValueContainer(ownerMetadataUid);
      }

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для DTO из конфигурации
      /// </summary>
      /// <param name="metadataUid">Уникальный идентификатор DTO</param>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      public static DataClass.ValueContainer Create(Guid metadataUid) => DataClass.ValueContainer.DTOHeaderValueContainers.GetOrAdd(metadataUid, (Func<Guid, DataClass.ValueContainer>) (uid => (DataClass.ValueContainer) new DataClass.ValueContainer.DTOHeaderValueContainer(uid)));

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для DTO из компонента
      /// </summary>
      /// <param name="componentUid">Уникальный идентификатор версии компонента</param>
      /// <param name="metadataUid">Уникальный идентификатор DTO</param>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      public static DataClass.ValueContainer Create(Guid componentUid, Guid metadataUid) => DataClass.ValueContainer.ComponentValueContainers.GetOrAdd((componentUid, metadataUid), (Func<(Guid, Guid), DataClass.ValueContainer>) (t => (DataClass.ValueContainer) new DataClass.ValueContainer.DataClassMetadataValueContainer(((ComponentMetadata) ComponentMetadataItemManager.Instance.Load(t.componentUid).Metadata).DataClasses.Find((Predicate<DataClassMetadata>) (m => DataClass.ValueContainer.\u003C\u003Ec__DisplayClass8_0.hCaZ4FZ3ndm0fq7GpSJU((object) m) == t.metadataUid)))));

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для DTO из заголовка модуля
      /// </summary>
      /// <param name="moduleHeaderUid">Уникальный идентификатор заголовка модуля</param>
      /// <param name="componentUid">Уникальный идентификатор компонента</param>
      /// <param name="metadataUid">Уникальный идентификатор DTO</param>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      public static DataClass.ValueContainer CreateByHeader(
        Guid moduleHeaderUid,
        Guid componentUid,
        Guid metadataUid)
      {
        return DataClass.ValueContainer.ModuleHeaderValueContainers.GetOrAdd((moduleHeaderUid, componentUid, metadataUid), (Func<(Guid, Guid, Guid), DataClass.ValueContainer>) (t => (DataClass.ValueContainer) new DataClass.ValueContainer.ModuleHeaderValueContainer(t.moduleHeaderUid, t.componentUid, t.metadataUid)));
      }

      /// <summary>
      /// Создать <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для DTO из элемента модуля
      /// </summary>
      /// <param name="moduleItemUid">Уникальный идентификатор версии модуля</param>
      /// <param name="componentUid">Уникальный идентификатор компонента</param>
      /// <param name="metadataUid">Уникальный идентификатор DTO</param>
      /// <returns><see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /></returns>
      public static DataClass.ValueContainer Create(
        Guid moduleUid,
        Guid moduleItemUid,
        Guid componentUid,
        Guid metadataUid)
      {
        ConcurrentDictionary<(Guid, Guid, Guid, Guid), DataClass.ValueContainer> moduleValueContainers = DataClass.ValueContainer.ModuleValueContainers;
        (Guid, Guid, Guid, Guid) key = (moduleUid, moduleItemUid, componentUid, metadataUid);
        // ISSUE: reference to a compiler-generated field
        Func<(Guid, Guid, Guid, Guid), DataClass.ValueContainer> func = DataClass.ValueContainer.\u003C\u003Ec.\u003C\u003E9__12_0;
        Func<(Guid, Guid, Guid, Guid), DataClass.ValueContainer> valueFactory;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          DataClass.ValueContainer.\u003C\u003Ec.\u003C\u003E9__12_0 = valueFactory = (Func<(Guid, Guid, Guid, Guid), DataClass.ValueContainer>) (t => (DataClass.ValueContainer) new DataClass.ValueContainer.ModuleValueContainer(t.moduleUid, t.moduleItemUid, t.componentUid, t.metadataUid));
        }
        else
          goto label_1;
label_3:
        return moduleValueContainers.GetOrAdd(key, valueFactory);
label_1:
        valueFactory = func;
        goto label_3;
      }

      /// <summary>Инициализировать данные</summary>
      /// <param name="data">Данные</param>
      /// <returns><see cref="P:EleWise.ELMA.Model.Metadata.DataClassMetadata.TypeRef" /> метаданных</returns>
      internal abstract string Initialize(
        IDictionary<Guid, DataClass.ValueContainer.DataContainer> data);

      protected ValueContainer()
      {
        DataClass.ValueContainer.L2RcWn8JUPqIVMPXx7Hx();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ValueContainer()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              DataClass.ValueContainer.DTOTypesValueContainers = new ConcurrentDictionary<Type, DataClass.ValueContainer>();
              num = 4;
              continue;
            case 2:
              DataClass.ValueContainer.L2RcWn8JUPqIVMPXx7Hx();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
              continue;
            case 3:
              DataClass.ValueContainer.DTOHeaderValueContainers = new ConcurrentDictionary<Guid, DataClass.ValueContainer>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 6;
              continue;
            case 4:
              DataClass.ValueContainer.ViewModelValueContainers = PublishCacheContext.CreateCache<Guid, DataClass.ValueContainer>((Action<IDictionary<Guid, DataClass.ValueContainer>, Type, Guid>) ((cache, _, uid) => cache.Remove(uid)));
              num = 3;
              continue;
            case 5:
              goto label_2;
            case 6:
              DataClass.ValueContainer.ComponentValueContainers = new ConcurrentDictionary<(Guid, Guid), DataClass.ValueContainer>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            case 7:
              DataClass.ValueContainer.ModuleValueContainers = new ConcurrentDictionary<(Guid, Guid, Guid, Guid), DataClass.ValueContainer>();
              num = 5;
              continue;
            default:
              DataClass.ValueContainer.ModuleHeaderValueContainers = new ConcurrentDictionary<(Guid, Guid, Guid), DataClass.ValueContainer>();
              num = 7;
              continue;
          }
        }
label_2:;
      }

      internal static bool rSivU28J5ksUmHtZXe2w([In] Type obj0, [In] Type obj1) => obj0 != obj1;

      internal static object qx3rpL8JjnH5h78mNLml(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void ylPCBI8JYRxb8nGhJCR7(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

      internal static bool XUBGyA8Jr6bY2gPlyuCA() => DataClass.ValueContainer.I7AcvZ8JlpEU0y7Ln0bi == null;

      internal static DataClass.ValueContainer pfMbiD8JgBK08XnAkbP6() => DataClass.ValueContainer.I7AcvZ8JlpEU0y7Ln0bi;

      internal static Guid wdS8aM8JLKc2lALUI0nu([In] object obj0) => ((AbstractMetadata) obj0).Uid;

      internal static void L2RcWn8JUPqIVMPXx7Hx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal class DataContainer
      {
        private readonly IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties;
        internal IDictionary<Guid, DataClass.IPropertyValueContainerCast> values;
        private static DataClass.ValueContainer.DataContainer VoSkylZ1JCOFc5Bq92Oa;

        internal DataContainer(
          DataClassMetadata metadata,
          IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          this.Metadata = metadata;
          this.defaultProperties = defaultProperties;
        }

        public DataClassMetadata Metadata { get; }

        public bool Initialized => this.values != null;

        public DataClass.IPropertyValueContainerCast this[Guid propertyUid]
        {
          get
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (this.values == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                case 2:
                  goto label_3;
                default:
                  IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties = this.defaultProperties;
                  Func<KeyValuePair<Guid, IPropertyDefaultValueContainer>, Guid> func1 = DataClass.ValueContainer.DataContainer.\u003C\u003Ec.\u003C\u003E9__9_0;
                  Func<KeyValuePair<Guid, IPropertyDefaultValueContainer>, Guid> keySelector;
                  if (func1 == null)
                    DataClass.ValueContainer.DataContainer.\u003C\u003Ec.\u003C\u003E9__9_0 = keySelector = (Func<KeyValuePair<Guid, IPropertyDefaultValueContainer>, Guid>) (v => v.Key);
                  else
                    goto label_11;
label_8:
                  Func<KeyValuePair<Guid, IPropertyDefaultValueContainer>, DataClass.IPropertyValueContainerCast> func2 = DataClass.ValueContainer.DataContainer.\u003C\u003Ec.\u003C\u003E9__9_1;
                  Func<KeyValuePair<Guid, IPropertyDefaultValueContainer>, DataClass.IPropertyValueContainerCast> elementSelector;
                  if (func2 == null)
                    DataClass.ValueContainer.DataContainer.\u003C\u003Ec.\u003C\u003E9__9_1 = elementSelector = (Func<KeyValuePair<Guid, IPropertyDefaultValueContainer>, DataClass.IPropertyValueContainerCast>) (v => (DataClass.IPropertyValueContainerCast) v.Value.Initialize());
                  else
                    goto label_2;
label_10:
                  this.values = (IDictionary<Guid, DataClass.IPropertyValueContainerCast>) defaultProperties.ToDictionary<KeyValuePair<Guid, IPropertyDefaultValueContainer>, Guid, DataClass.IPropertyValueContainerCast>(keySelector, elementSelector);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
                  continue;
label_2:
                  elementSelector = func2;
                  goto label_10;
label_11:
                  keySelector = func1;
                  goto label_8;
              }
            }
label_3:
            return this.values[propertyUid];
          }
        }

        internal static bool fBiudtZ19UhGh6XKMyte() => DataClass.ValueContainer.DataContainer.VoSkylZ1JCOFc5Bq92Oa == null;

        internal static DataClass.ValueContainer.DataContainer HaxuATZ1d2wFeGJZV0Bg() => DataClass.ValueContainer.DataContainer.VoSkylZ1JCOFc5Bq92Oa;
      }

      /// <summary>
      /// <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> по метаданным DTO
      /// </summary>
      private class DataClassMetadataValueContainer : DataClass.ValueContainer
      {
        private readonly object metadata;
        private readonly IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties;
        private readonly object includeValueContainers;
        private static object E251VnZ1lawhIbKNVYnR;

        public DataClassMetadataValueContainer(DataClassMetadata metadata)
        {
          DataClass.ValueContainer.DataClassMetadataValueContainer.obK93WZ15OdVOVAYwnpQ();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num1 = 2;
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_8;
              case 1:
                List<DataClassDependency> includeList = metadata.IncludeList;
                // ISSUE: reference to a compiler-generated field
                Func<DataClassDependency, DataClass.ValueContainer> func1 = DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__3_3;
                Func<DataClassDependency, DataClass.ValueContainer> selector;
                if (func1 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__3_3 = selector = (Func<DataClassDependency, DataClass.ValueContainer>) (i =>
                  {
                    int num2 = 2;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          goto label_5;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.UrQRWUZaTNfofVXvgj10(DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.BZEDiuZanZ2aAr0G69qg((object) i), Guid.Empty))
                          {
                            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                            continue;
                          }
                          goto label_4;
                        default:
                          goto label_4;
                      }
                    }
label_4:
                    // ISSUE: reference to a compiler-generated method
                    return (DataClass.ValueContainer) DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.e0fpa9ZaOTxnwNrF01Lm(i.HeaderUid);
label_5:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    return (DataClass.ValueContainer) DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.FHPV4mZae4m9dgcCYKp6(i.ModuleUid, Guid.Empty, DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.xKFEruZa2TGR1JmQVjR7((object) i));
                  });
                }
                else
                  goto label_11;
label_10:
                this.includeValueContainers = (object) includeList.Select<DataClassDependency, DataClass.ValueContainer>(selector).ToArray<DataClass.ValueContainer>();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                continue;
label_11:
                selector = func1;
                goto label_10;
              case 2:
                this.metadata = (object) metadata;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 3;
                continue;
              case 3:
                List<PropertyMetadata> properties = metadata.Properties;
                // ISSUE: reference to a compiler-generated field
                Func<PropertyMetadata, bool> func2 = DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__3_0;
                Func<PropertyMetadata, bool> predicate;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__3_0 = predicate = (Func<PropertyMetadata, bool>) (a => DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.UrQRWUZaTNfofVXvgj10(DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.oAprXUZaXT01PFOCHxij((object) a), ActionDescriptor.UID));
                }
                else
                  goto label_12;
label_6:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                this.defaultProperties = (IDictionary<Guid, IPropertyDefaultValueContainer>) properties.Where<PropertyMetadata>(predicate).ToDictionary<PropertyMetadata, Guid, IPropertyDefaultValueContainer>((Func<PropertyMetadata, Guid>) (p => DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec.ehCuI8Zak7jD9EcT9Fv6((object) p)), (Func<PropertyMetadata, IPropertyDefaultValueContainer>) (p => (IPropertyDefaultValueContainer) DataClass.ValueContainer.DataClassMetadataValueContainer.\u003C\u003Ec__DisplayClass3_0.Q4pRiKZaiJFm7rCc37hZ((object) metadata, (object) null, (object) p)));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
                continue;
label_12:
                predicate = func2;
                goto label_6;
              default:
                goto label_4;
            }
          }
label_8:
          return;
label_4:;
        }

        internal override string Initialize(
          IDictionary<Guid, DataClass.ValueContainer.DataContainer> data)
        {
          if (!data.ContainsKey(((AbstractMetadata) this.metadata).Uid))
          {
            data[((AbstractMetadata) this.metadata).Uid] = new DataClass.ValueContainer.DataContainer((DataClassMetadata) this.metadata, this.defaultProperties);
            for (int index = 0; index < this.includeValueContainers.Length; ++index)
              ((DataClass.ValueContainer) this.includeValueContainers[index]).Initialize(data);
          }
          return ((DataClassMetadata) this.metadata).TypeRef;
        }

        internal static IPropertyDefaultValueContainer CreatePropertyDefaultValueContainer(
          object metadata,
          object parentMetadata,
          object property)
        {
          int num1 = 4;
          IPropertyDefaultValueContainer defaultValueContainer;
          Type type;
          Type genericArgument;
          object obj1;
          object obj2;
          while (true)
          {
            int num2 = num1;
            IPropertyDefaultValueContainer defaultContainer;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  goto label_23;
                case 2:
                  goto label_18;
                case 3:
                  if (DataClass.ValueContainer.DataClassMetadataValueContainer.ort7P7Z1U6utkxnFCoMl((object) (DataClassSettings) DataClass.ValueContainer.DataClassMetadataValueContainer.sDPC6pZ1LcHNNnYP49Ol(property)) == RelationType.OneToOne)
                  {
                    defaultValueContainer = (IPropertyDefaultValueContainer) new DataClass.DataClassPropertyValueContainer();
                    num2 = 11;
                    continue;
                  }
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 13 : 6;
                  continue;
                case 4:
                  if (DataClass.ValueContainer.DataClassMetadataValueContainer.FUSSFcZ1Y05V0Tjr6cq4(DataClass.ValueContainer.DataClassMetadataValueContainer.LsNOUyZ1jdOb30jx38eA(property), DataClassDescriptor.UID))
                  {
                    num2 = 3;
                    continue;
                  }
                  ITypeDescriptor typeDescriptor = ((IMetadataService) DataClass.ValueContainer.DataClassMetadataValueContainer.YFNw4LZ1sT7XDAXNweUp()).GetTypeDescriptor(((PropertyMetadata) property).TypeUid, DataClass.ValueContainer.DataClassMetadataValueContainer.wD14eOZ1cVDC68U2foUl(property));
                  ClassMetadata classMetadata = (ClassMetadata) metadata;
                  if (parentMetadata != null)
                  {
                    DataClassMetadata dataClassMetadata = new DataClassMetadata();
                    DataClass.ValueContainer.DataClassMetadataValueContainer.diAo5uZNFnKVuRNH3hTK((object) dataClassMetadata, DataClass.ValueContainer.DataClassMetadataValueContainer.qo4ixkZ1zth4Grah3mHK(parentMetadata));
                    dataClassMetadata.BaseClassUid = DataClass.ValueContainer.DataClassMetadataValueContainer.IkCdrHZNBYvsHpQtrvJ7(parentMetadata);
                    dataClassMetadata.isInterfaceType = new bool?(DataClass.ValueContainer.DataClassMetadataValueContainer.w52ceRZNWQ482MfsMB9n(parentMetadata));
                    classMetadata = (ClassMetadata) dataClassMetadata;
                  }
                  defaultContainer = ((ITypeGenerationInfo) typeDescriptor).GetDefaultContainer(classMetadata, (PropertyMetadata) property);
                  num2 = 12;
                  continue;
                case 5:
                  goto label_22;
                case 6:
                  goto label_5;
                case 7:
                  // ISSUE: type reference
                  if (DataClass.ValueContainer.DataClassMetadataValueContainer.HZnqR1ZNbUivlnyeKr66(type.GetGenericTypeDefinition(), DataClass.ValueContainer.DataClassMetadataValueContainer.hSfcNpZNoQlfXLvGhymK(__typeref (EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyValueContainer<>))))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  }
                  break;
                case 8:
                  if (type.IsGenericType)
                  {
                    num2 = 7;
                    continue;
                  }
                  break;
                case 9:
                  goto label_9;
                case 10:
                  if (obj2 != null)
                  {
                    num2 = 2;
                    continue;
                  }
                  break;
                case 11:
                  goto label_24;
                case 12:
                  if (!(defaultContainer is EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyCollectionValueContainer collectionValueContainer))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
                    continue;
                  }
                  goto label_22;
                case 13:
                  defaultValueContainer = (IPropertyDefaultValueContainer) new DataClass.DataClassCollectionPropertyValueContainer();
                  num2 = 6;
                  continue;
                default:
                  obj2 = DataClass.ValueContainer.DataClassMetadataValueContainer.p1Z6v4ZNG1s9lyOUcn3r((object) type.GetField((string) DataClass.ValueContainer.DataClassMetadataValueContainer.LQmYrSZNhfXMBT5e1DfZ(-97972138 ^ -97572876), BindingFlags.Instance | BindingFlags.NonPublic), (object) defaultContainer);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 8 : 10;
                  continue;
              }
              object obj3 = DataClass.ValueContainer.DataClassMetadataValueContainer.Lp7POoZNff5X2lwFXWsi((object) defaultContainer);
              // ISSUE: type reference
              genericArgument = obj3.GetType().GetInterface(DataClass.ValueContainer.DataClassMetadataValueContainer.hSfcNpZNoQlfXLvGhymK(__typeref (IPropertyValueContainer<>)).FullName).GetGenericArguments()[0];
              obj1 = DataClass.ValueContainer.DataClassMetadataValueContainer.RjQCkpZNQgR7CyGZNdGL(obj3, (object) null);
              num2 = 9;
            }
label_23:
            type = defaultContainer.GetType();
            num1 = 8;
          }
label_5:
          return defaultValueContainer;
label_9:
          // ISSUE: type reference
          return (IPropertyDefaultValueContainer) DataClass.ValueContainer.DataClassMetadataValueContainer.fHhDFrZNEZOK7BPpD03T(DataClass.ValueContainer.DataClassMetadataValueContainer.hSfcNpZNoQlfXLvGhymK(__typeref (DataClass.PropertyValueContainer<>)).MakeGenericType(genericArgument), (object) new object[1]
          {
            obj1
          });
label_18:
          // ISSUE: type reference
          return (IPropertyDefaultValueContainer) DataClass.ValueContainer.DataClassMetadataValueContainer.fHhDFrZNEZOK7BPpD03T(DataClass.ValueContainer.DataClassMetadataValueContainer.hSfcNpZNoQlfXLvGhymK(__typeref (DataClass.PropertyValueContainer<>)).MakeGenericType(type.GetGenericArguments()[0]), (object) new object[1]
          {
            obj2
          });
label_22:
          return (IPropertyDefaultValueContainer) new DataClass.PropertyCollectionValueContainer(collectionValueContainer.tTarget);
label_24:
          return defaultValueContainer;
        }

        internal static void obK93WZ15OdVOVAYwnpQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool YWMVlaZ1rKRRmCj6LW1v() => DataClass.ValueContainer.DataClassMetadataValueContainer.E251VnZ1lawhIbKNVYnR == null;

        internal static DataClass.ValueContainer.DataClassMetadataValueContainer tywayMZ1g77IMsuind5L() => (DataClass.ValueContainer.DataClassMetadataValueContainer) DataClass.ValueContainer.DataClassMetadataValueContainer.E251VnZ1lawhIbKNVYnR;

        internal static Guid LsNOUyZ1jdOb30jx38eA([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

        internal static bool FUSSFcZ1Y05V0Tjr6cq4([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

        internal static object sDPC6pZ1LcHNNnYP49Ol([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

        internal static RelationType ort7P7Z1U6utkxnFCoMl([In] object obj0) => ((DataClassSettings) obj0).RelationType;

        internal static object YFNw4LZ1sT7XDAXNweUp() => (object) MetadataServiceContext.Service;

        internal static Guid wD14eOZ1cVDC68U2foUl([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

        internal static Guid qo4ixkZ1zth4Grah3mHK([In] object obj0) => ((AbstractMetadata) obj0).Uid;

        internal static void diAo5uZNFnKVuRNH3hTK([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

        internal static Guid IkCdrHZNBYvsHpQtrvJ7([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

        internal static bool w52ceRZNWQ482MfsMB9n([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

        internal static Type hSfcNpZNoQlfXLvGhymK([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

        internal static bool HZnqR1ZNbUivlnyeKr66([In] Type obj0, [In] Type obj1) => obj0 == obj1;

        internal static object LQmYrSZNhfXMBT5e1DfZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object p1Z6v4ZNG1s9lyOUcn3r([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

        internal static object fHhDFrZNEZOK7BPpD03T([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

        internal static object Lp7POoZNff5X2lwFXWsi([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

        internal static object RjQCkpZNQgR7CyGZNdGL([In] object obj0, [In] object obj1) => ((IPropertyValueContainer) obj0).Get(obj1);
      }

      /// <summary>
      /// <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для DTO из конфигурации (последняя версия)
      /// </summary>
      private class DTOHeaderValueContainer : DataClass.ValueContainer
      {
        private readonly Guid metadataUid;
        private long lastVersionId;
        private object lastVersion;
        private static readonly ConcurrentDictionary<Guid, long> LastVersions;
        internal static object r1CHHLZNCHbs87NhGhgA;

        public DTOHeaderValueContainer(Guid metadataUid)
        {
          DataClass.ValueContainer.DTOHeaderValueContainer.FdxX5VZNZodebcyTfGFa();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.metadataUid = metadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_3:
          return;
label_5:;
        }

        internal override string Initialize(
          IDictionary<Guid, DataClass.ValueContainer.DataContainer> data)
        {
          long orAdd = DataClass.ValueContainer.DTOHeaderValueContainer.LastVersions.GetOrAdd(this.metadataUid, new Func<Guid, long>(DataClass.ValueContainer.DTOHeaderValueContainer.GetLastVersionId));
          if (this.lastVersionId != orAdd || this.lastVersion == null)
          {
            this.lastVersion = (object) null;
            lock (this)
              this.lastVersion = this.lastVersion ?? (object) DataClass.ValueContainer.DTOHeaderValueContainer.CreateValueContainer(this.lastVersionId = orAdd);
          }
          return ((DataClass.ValueContainer) this.lastVersion).Initialize(data);
        }

        private static DataClass.ValueContainer CreateValueContainer(long id) => (DataClass.ValueContainer) new DataClass.ValueContainer.DataClassMetadataValueContainer((DataClassMetadata) DataClass.ValueContainer.DTOHeaderValueContainer.z9TdgJZNuOWYSMgEDFmU((object) DataClassMetadataItemManager.Instance.Load(id)));

        private static long GetLastVersionId(Guid metadataUid)
        {
          int num = 1;
          // ISSUE: variable of a compiler-generated type
          DataClass.ValueContainer.DTOHeaderValueContainer.\u003C\u003Ec__DisplayClass7_0 cDisplayClass70;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass70 = new DataClass.ValueContainer.DTOHeaderValueContainer.\u003C\u003Ec__DisplayClass7_0();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              default:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass70.metadataUid = metadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 0;
                continue;
            }
          }
label_3:
          IQueryOver<DataClassMetadataItemHeader, DataClassMetadataItemHeader> queryOver1 = ((ISession) DataClass.ValueContainer.DTOHeaderValueContainer.L7AJD9ZNIN1ls8NcXtNx((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) string.Empty)).QueryOver<DataClassMetadataItemHeader>();
          // ISSUE: type reference
          ParameterExpression parameterExpression1 = (ParameterExpression) DataClass.ValueContainer.DTOHeaderValueContainer.fab1rRZNiWToavkE6kAL(DataClass.ValueContainer.DTOHeaderValueContainer.oCDDngZNVi1A3ewsbuNi(__typeref (DataClassMetadataItemHeader)), DataClass.ValueContainer.DTOHeaderValueContainer.yp6SLwZNSUvfQrp3lkfC(993438473 ^ 993396669));
          // ISSUE: method reference
          // ISSUE: type reference
          // ISSUE: field reference
          // ISSUE: method reference
          Expression<Func<DataClassMetadataItemHeader, bool>> expression = Expression.Lambda<Func<DataClassMetadataItemHeader, bool>>((Expression) DataClass.ValueContainer.DTOHeaderValueContainer.Tva39FZNTbpNmBHTNFSk((object) Expression.Property((Expression) parameterExpression1, (System.Reflection.MethodInfo) DataClass.ValueContainer.DTOHeaderValueContainer.NGFAjvZNRcPQ74vAaB7R(__methodref (DataClassMetadataItemHeader.get_Uid))), DataClass.ValueContainer.DTOHeaderValueContainer.t8C7mYZNXfqmOTGV0VVU(DataClass.ValueContainer.DTOHeaderValueContainer.x9vPM8ZNqbnRRs9aDOxP((object) cDisplayClass70, DataClass.ValueContainer.DTOHeaderValueContainer.oCDDngZNVi1A3ewsbuNi(__typeref (DataClass.ValueContainer.DTOHeaderValueContainer.\u003C\u003Ec__DisplayClass7_0))), DataClass.ValueContainer.DTOHeaderValueContainer.yPKkWQZNKnVfvOSduLoB(__fieldref (DataClass.ValueContainer.DTOHeaderValueContainer.\u003C\u003Ec__DisplayClass7_0.metadataUid))), false, (object) (System.Reflection.MethodInfo) DataClass.ValueContainer.DTOHeaderValueContainer.NGFAjvZNRcPQ74vAaB7R(__methodref (Guid.op_Equality))), parameterExpression1);
          IQueryOver<DataClassMetadataItemHeader, DataClassMetadataItemHeader> queryOver2 = queryOver1.Where(expression);
          Expression<Func<DataClassMetadataItemHeader, object>>[] expressionArray = new Expression<Func<DataClassMetadataItemHeader, object>>[1];
          ParameterExpression parameterExpression2;
          // ISSUE: method reference
          // ISSUE: method reference
          // ISSUE: type reference
          // ISSUE: type reference
          expressionArray[0] = Expression.Lambda<Func<DataClassMetadataItemHeader, object>>((Expression) DataClass.ValueContainer.DTOHeaderValueContainer.YeoYkBZNnfPVs45QaO7t((object) Expression.Property((Expression) DataClass.ValueContainer.DTOHeaderValueContainer.iyi6YuZNkhZTm7x5hrcB((object) parameterExpression2, (object) (System.Reflection.MethodInfo) DataClass.ValueContainer.DTOHeaderValueContainer.NGFAjvZNRcPQ74vAaB7R(__methodref (DataClassMetadataItemHeader.get_Published))), (System.Reflection.MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity<long>.get_Id), __typeref (Entity<long>))), DataClass.ValueContainer.DTOHeaderValueContainer.oCDDngZNVi1A3ewsbuNi(__typeref (object))), parameterExpression2);
          return queryOver2.Select(expressionArray).SingleOrDefault<long>();
        }

        static DTOHeaderValueContainer()
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                DataClass.ValueContainer.DTOHeaderValueContainer.LastVersions = new ConcurrentDictionary<Guid, long>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                continue;
              case 2:
                DataClass.ValueContainer.DTOHeaderValueContainer.FdxX5VZNZodebcyTfGFa();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }

        internal static void FdxX5VZNZodebcyTfGFa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool VQgdw6ZNvfMZbNlFMUUu() => DataClass.ValueContainer.DTOHeaderValueContainer.r1CHHLZNCHbs87NhGhgA == null;

        internal static DataClass.ValueContainer.DTOHeaderValueContainer n36aWBZN8kgG1OAsYn3K() => (DataClass.ValueContainer.DTOHeaderValueContainer) DataClass.ValueContainer.DTOHeaderValueContainer.r1CHHLZNCHbs87NhGhgA;

        internal static object z9TdgJZNuOWYSMgEDFmU([In] object obj0) => ((DataClassMetadataItem) obj0).Metadata;

        internal static object L7AJD9ZNIN1ls8NcXtNx([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

        internal static Type oCDDngZNVi1A3ewsbuNi([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

        internal static object yp6SLwZNSUvfQrp3lkfC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object fab1rRZNiWToavkE6kAL([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

        internal static object NGFAjvZNRcPQ74vAaB7R([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

        internal static object x9vPM8ZNqbnRRs9aDOxP([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

        internal static object yPKkWQZNKnVfvOSduLoB([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

        internal static object t8C7mYZNXfqmOTGV0VVU([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

        internal static object Tva39FZNTbpNmBHTNFSk(
          [In] object obj0,
          [In] object obj1,
          [In] bool obj2,
          [In] object obj3)
        {
          return (object) Expression.Equal((Expression) obj0, (Expression) obj1, obj2, (System.Reflection.MethodInfo) obj3);
        }

        internal static object iyi6YuZNkhZTm7x5hrcB([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (System.Reflection.MethodInfo) obj1);

        internal static object YeoYkBZNnfPVs45QaO7t([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

        [Component]
        private class DataClassClearCacheHandler : 
          IDataClassMetadataPublishingEventHandler,
          IEventHandler
        {
          internal static object NXRlLSZaPPqbQn3Im1Ba;

          public Task Complete(Guid publicationToken, UIMetadataPublishResult result)
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  DataClass.ValueContainer.DTOHeaderValueContainer.DataClassClearCacheHandler.POqc2cZa3yVNrq5BvN4n((object) DataClass.ValueContainer.DTOHeaderValueContainer.LastVersions);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_3;
              }
            }
label_3:
            return (Task) DataClass.ValueContainer.DTOHeaderValueContainer.DataClassClearCacheHandler.zNR82bZapPEbbvLj3Bad();
          }

          public Task Error(Guid publicationToken, Exception exception) => Task.CompletedTask;

          public DataClassClearCacheHandler()
          {
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            // ISSUE: explicit constructor call
            base.\u002Ector();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
              num = 0;
            switch (num)
            {
            }
          }

          internal static void POqc2cZa3yVNrq5BvN4n([In] object obj0) => ((ConcurrentDictionary<Guid, long>) obj0).Clear();

          internal static object zNR82bZapPEbbvLj3Bad() => (object) Task.CompletedTask;

          internal static bool mtisOMZa1tHOWbJiULLF() => DataClass.ValueContainer.DTOHeaderValueContainer.DataClassClearCacheHandler.NXRlLSZaPPqbQn3Im1Ba == null;

          internal static DataClass.ValueContainer.DTOHeaderValueContainer.DataClassClearCacheHandler YiIiAvZaN0Tkl1fl0F7p() => (DataClass.ValueContainer.DTOHeaderValueContainer.DataClassClearCacheHandler) DataClass.ValueContainer.DTOHeaderValueContainer.DataClassClearCacheHandler.NXRlLSZaPPqbQn3Im1Ba;
        }
      }

      /// <summary>
      /// <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для структуры обмена данными из заголовка модуля
      /// </summary>
      private class ModuleHeaderValueContainer : DataClass.ValueContainer
      {
        private readonly Guid moduleHeaderUid;
        private readonly Guid componentUid;
        private readonly Guid metadataUid;
        private static object UT0YXpZNOWmwUj26GNs5;

        /// <summary>Ctor</summary>
        /// <param name="moduleHeaderUid">Уникальный идентификатор заголовка модуля</param>
        /// <param name="componentUid">Уникальный идентификатор метаданных компонента</param>
        /// <param name="metadataUid">Уникальный идентификатор метаданных структуры обмена данными</param>
        public ModuleHeaderValueContainer(
          Guid moduleHeaderUid,
          Guid componentUid,
          Guid metadataUid)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.componentUid = componentUid;
                num = 2;
                continue;
              case 2:
                this.metadataUid = metadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 3;
                continue;
              case 3:
                goto label_3;
              default:
                this.moduleHeaderUid = moduleHeaderUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
                continue;
            }
          }
label_3:;
        }

        /// <inheritdoc />
        internal override string Initialize(
          IDictionary<Guid, DataClass.ValueContainer.DataContainer> data)
        {
          UIRuntimeModel orDefault = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939359884));
          ItemRuntimeModel itemRuntimeModel1 = orDefault != null ? orDefault.RuntimeModules.FirstOrDefault<ItemRuntimeModel>((Func<ItemRuntimeModel, bool>) (a => DataClass.ValueContainer.ModuleHeaderValueContainer.vv5KyeZNPh2AZupkXJD0(a.HeaderUid, this.moduleHeaderUid))) : (ItemRuntimeModel) null;
          Guid moduleItemUid = Guid.Empty;
          Guid moduleUid = Guid.Empty;
          if (itemRuntimeModel1 != null)
          {
            moduleItemUid = itemRuntimeModel1.ItemUid;
            moduleUid = itemRuntimeModel1.HeaderUid;
          }
          else
          {
            UIRuntimeModel orAdd = ContextVars.GetOrAdd<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672182760), (Func<UIRuntimeModel>) (() => new UIRuntimeModel()));
            ItemRuntimeModel itemRuntimeModel2 = orAdd.RuntimeModules.FirstOrDefault<ItemRuntimeModel>((Func<ItemRuntimeModel, bool>) (a => DataClass.ValueContainer.ModuleHeaderValueContainer.vv5KyeZNPh2AZupkXJD0(a.HeaderUid, this.moduleHeaderUid)));
            if (itemRuntimeModel2 != null)
            {
              moduleItemUid = itemRuntimeModel2.ItemUid;
              moduleUid = itemRuntimeModel2.HeaderUid;
            }
            else
            {
              IFindComponentService serviceNotNull = Locator.GetServiceNotNull<IFindComponentService>();
              ContextVars.GetOrAdd<System.Collections.Generic.HashSet<Guid>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487364434), (Func<System.Collections.Generic.HashSet<Guid>>) (() => new System.Collections.Generic.HashSet<Guid>())).Add(this.moduleHeaderUid);
              ClientComponentModel clientComponentModel = serviceNotNull.GetAdditionalModules().FirstOrDefault<ClientComponentModel>((Func<ClientComponentModel, bool>) (a => DataClass.ValueContainer.ModuleHeaderValueContainer.vv5KyeZNPh2AZupkXJD0(DataClass.ValueContainer.ModuleHeaderValueContainer.HWG6m4ZN1572042oYT5Q((object) a), this.moduleHeaderUid)));
              if (clientComponentModel != null)
              {
                moduleItemUid = clientComponentModel.ModuleItemUid;
                orAdd.RuntimeModules.Add(new ItemRuntimeModel()
                {
                  HeaderUid = this.moduleHeaderUid,
                  ItemUid = moduleItemUid
                });
              }
            }
          }
          return !(moduleItemUid == Guid.Empty) ? DataClass.ValueContainer.Create(moduleUid, moduleItemUid, this.componentUid, this.metadataUid).Initialize(data) : string.Empty;
        }

        internal static bool gAoissZN2uAX8fUguMQG() => DataClass.ValueContainer.ModuleHeaderValueContainer.UT0YXpZNOWmwUj26GNs5 == null;

        internal static DataClass.ValueContainer.ModuleHeaderValueContainer q8YWsKZNemNyava5SRBi() => (DataClass.ValueContainer.ModuleHeaderValueContainer) DataClass.ValueContainer.ModuleHeaderValueContainer.UT0YXpZNOWmwUj26GNs5;

        internal static bool vv5KyeZNPh2AZupkXJD0([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

        internal static Guid HWG6m4ZN1572042oYT5Q([In] object obj0) => ((ClientComponentModel) obj0).ModuleUid;
      }

      /// <summary>
      /// <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> для структуры обмена данными из элемента модуля
      /// </summary>
      private class ModuleValueContainer : DataClass.ValueContainer
      {
        private static readonly ConcurrentDictionary<Guid, ModuleInfoMetadata> moduleInfoMetadataList;
        private readonly Guid moduleUid;
        private readonly Guid moduleItemUid;
        private readonly Guid componentUid;
        private readonly Guid metadataUid;
        private object valueContainer;
        internal static object Hp7Ig8ZNNUofLPO20AuR;

        /// <summary>Ctor</summary>
        /// <param name="moduleUid"></param>
        /// <param name="moduleItemUid">Уникальный идентификатор элемента модуля нужной версии</param>
        /// <param name="componentUid">Уникальный идентификатор метаданных компонента</param>
        /// <param name="metadataUid">Уникальный идентификатор метаданных структуры обмена данными</param>
        public ModuleValueContainer(
          Guid moduleUid,
          Guid moduleItemUid,
          Guid componentUid,
          Guid metadataUid)
        {
          DataClass.ValueContainer.ModuleValueContainer.D6Jaf5ZNaREGVP4BZL7x();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.moduleUid = moduleUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              case 2:
                this.metadataUid = metadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 4;
                continue;
              case 3:
                this.componentUid = componentUid;
                num = 2;
                continue;
              case 4:
                goto label_3;
              default:
                this.moduleItemUid = moduleItemUid;
                num = 3;
                continue;
            }
          }
label_3:;
        }

        /// <inheritdoc />
        internal override string Initialize(
          IDictionary<Guid, DataClass.ValueContainer.DataContainer> data)
        {
          if (this.valueContainer == null)
          {
            lock (this)
            {
              if (this.valueContainer == null)
              {
                ModuleInfoMetadata orAdd = DataClass.ValueContainer.ModuleValueContainer.moduleInfoMetadataList.GetOrAdd(this.moduleItemUid, (Func<Guid, ModuleInfoMetadata>) (uid => (ModuleInfoMetadata) DataClass.ValueContainer.ModuleValueContainer.IUT5ETZNwCISRUJjcWhC(DataClass.ValueContainer.ModuleValueContainer.QEaCYFZNtZQ9opHZw8BJ(DataClass.ValueContainer.ModuleValueContainer.udjx7wZNDT0IvcNFeL8F(), this.moduleUid, uid))));
                this.valueContainer = (object) new DataClass.ValueContainer.DataClassMetadataValueContainer(this.componentUid == Guid.Empty ? orAdd.DataClasses.Find((Predicate<DataClassMetadata>) (m => DataClass.ValueContainer.ModuleValueContainer.ElqQR2ZN6gp2wR47A6Xi(DataClass.ValueContainer.ModuleValueContainer.S15oZqZN4pHTKbJ2lktu((object) m), this.metadataUid))) : orAdd.Components.Find((Predicate<ComponentMetadata>) (c => DataClass.ValueContainer.ModuleValueContainer.S15oZqZN4pHTKbJ2lktu((object) c) == this.componentUid)).DataClasses.Find((Predicate<DataClassMetadata>) (m => DataClass.ValueContainer.ModuleValueContainer.ElqQR2ZN6gp2wR47A6Xi(m.Uid, this.metadataUid))));
              }
            }
          }
          return ((DataClass.ValueContainer) this.valueContainer).Initialize(data);
        }

        static ModuleValueContainer()
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                DataClass.ValueContainer.ModuleValueContainer.moduleInfoMetadataList = new ConcurrentDictionary<Guid, ModuleInfoMetadata>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              case 2:
                DataClass.ValueContainer.ModuleValueContainer.D6Jaf5ZNaREGVP4BZL7x();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }

        internal static void D6Jaf5ZNaREGVP4BZL7x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool ANLeRwZN3t67KopXH6vv() => DataClass.ValueContainer.ModuleValueContainer.Hp7Ig8ZNNUofLPO20AuR == null;

        internal static DataClass.ValueContainer.ModuleValueContainer iuPvfQZNpFenrrnWDt1W() => (DataClass.ValueContainer.ModuleValueContainer) DataClass.ValueContainer.ModuleValueContainer.Hp7Ig8ZNNUofLPO20AuR;

        internal static object udjx7wZNDT0IvcNFeL8F() => (object) DataClass.ModuleMetadataLoader;

        internal static object QEaCYFZNtZQ9opHZw8BJ([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleMetadataLoader) obj0).GetSpecificModuleVersion(moduleUid, versionUid);

        internal static object IUT5ETZNwCISRUJjcWhC([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

        internal static Guid S15oZqZN4pHTKbJ2lktu([In] object obj0) => ((AbstractMetadata) obj0).Uid;

        internal static bool ElqQR2ZN6gp2wR47A6Xi([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
      }

      /// <summary>
      /// <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> по <see cref="T:EleWise.ELMA.Model.Metadata.EntityMetadata" />
      /// </summary>
      private sealed class EntityMetadataValueContainer : DataClass.ValueContainer
      {
        private readonly object entityMetadata;
        private object valueContainer;
        internal static object wFVyJwZNHpEPEdC3rOKp;

        /// <summary>Ctor</summary>
        /// <param name="entityMetadata">Метаданные сущности</param>
        public EntityMetadataValueContainer(EntityMetadata entityMetadata)
        {
          DataClass.ValueContainer.EntityMetadataValueContainer.gD7fXnZNxLFZldf1qCqn();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              default:
                this.entityMetadata = (object) entityMetadata;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
                continue;
            }
          }
label_3:;
        }

        /// <inheritdoc />
        internal override string Initialize(
          IDictionary<Guid, DataClass.ValueContainer.DataContainer> data)
        {
          if (this.valueContainer == null)
          {
            lock (this)
            {
              if (this.valueContainer == null)
                this.valueContainer = (object) new DataClass.ValueContainer.ViewModelMetadataValueContainer((EntityMetadata) this.entityMetadata);
            }
          }
          return ((DataClass.ValueContainer) this.valueContainer).Initialize(data);
        }

        internal static void gD7fXnZNxLFZldf1qCqn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool IP9tPSZNASg6MsRPGA6a() => DataClass.ValueContainer.EntityMetadataValueContainer.wFVyJwZNHpEPEdC3rOKp == null;

        internal static DataClass.ValueContainer.EntityMetadataValueContainer kRSanxZN72fj7nH4wwu2() => (DataClass.ValueContainer.EntityMetadataValueContainer) DataClass.ValueContainer.EntityMetadataValueContainer.wFVyJwZNHpEPEdC3rOKp;
      }

      /// <summary>
      /// <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> по метаданным ViewModel
      /// </summary>
      private class ViewModelMetadataValueContainer : DataClass.ValueContainer
      {
        private object metadata;
        private IDictionary<Guid, IPropertyDefaultValueContainer> defaultProperties;
        private object includeViewModelMetadata;
        private static object I3iRqpZN0NdeRSu639AC;

        /// <summary>Ctor</summary>
        /// <param name="entityMetadata">Метаданные сущности</param>
        public ViewModelMetadataValueContainer(EntityMetadata entityMetadata)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_7;
              case 2:
                this.CaseProcessContext(entityMetadata);
                num = 3;
                continue;
              case 3:
                goto label_3;
              default:
                if (DataClass.ValueContainer.ViewModelMetadataValueContainer.yqTdIUZN9E251EHWKALK(DataClass.ValueContainer.ViewModelMetadataValueContainer.nfaBlRZNMqn82uPCyKfm((object) entityMetadata), DataClass.ValueContainer.ViewModelMetadataValueContainer.hNdlD1ZNJQwj9N8lR7Xn(1514961705 ^ 1514818711)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
                  continue;
                }
                this.CaseEntityMetadata(entityMetadata);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
                continue;
            }
          }
label_7:
          return;
label_3:;
        }

        /// <inheritdoc />
        internal override string Initialize(
          IDictionary<Guid, DataClass.ValueContainer.DataContainer> data)
        {
          if (!data.ContainsKey(((AbstractMetadata) this.metadata).Uid))
          {
            data[((AbstractMetadata) this.metadata).Uid] = new DataClass.ValueContainer.DataContainer((DataClassMetadata) this.metadata, this.defaultProperties);
            if (this.includeViewModelMetadata != null)
              ((DataClass.ValueContainer) this.includeViewModelMetadata).Initialize(data);
          }
          return ((DataClassMetadata) this.metadata).TypeRef;
        }

        private void CaseProcessContext(EntityMetadata entityMetadata)
        {
          int num = 2;
          DataClass.ValueContainer.ViewModelMetadataValueContainer metadataValueContainer;
          EntityMetadata entityMetadata1;
          while (true)
          {
            switch (num)
            {
              case 1:
                metadataValueContainer = this;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              case 2:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
                continue;
              case 3:
                if (DataClass.ValueContainer.ViewModelMetadataValueContainer.FuwJuhZNdMhK4xV5COvi((object) ((DataClassMetadata) this.metadata).IncludeList) == 1)
                {
                  num = 4;
                  continue;
                }
                goto label_2;
              case 4:
                this.includeViewModelMetadata = (object) DataClass.ValueContainer.CreateViewModelMetadataHeaderValueContainer(entityMetadata1.BaseClassUid);
                num = 7;
                continue;
              case 5:
                List<PropertyMetadata> properties = ((ClassMetadata) this.metadata).Properties;
                // ISSUE: reference to a compiler-generated field
                Func<PropertyMetadata, bool> func = DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__5_0;
                Func<PropertyMetadata, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__5_0 = predicate = (Func<PropertyMetadata, bool>) (a => DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.gYQtOHZa5IG7dLStfux4(a.TypeUid, ActionDescriptor.UID));
                }
                else
                  goto label_14;
label_13:
                // ISSUE: reference to a compiler-generated method
                this.defaultProperties = (IDictionary<Guid, IPropertyDefaultValueContainer>) properties.Where<PropertyMetadata>(predicate).ToDictionary<PropertyMetadata, Guid, IPropertyDefaultValueContainer>((Func<PropertyMetadata, Guid>) (p => DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.jqH4H8ZajSd6UyMXAfme((object) p)), (Func<PropertyMetadata, IPropertyDefaultValueContainer>) (p => DataClass.ValueContainer.DataClassMetadataValueContainer.CreatePropertyDefaultValueContainer(metadataValueContainer.metadata, (object) entityMetadata1, (object) p)));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 3;
                continue;
label_14:
                predicate = func;
                goto label_13;
              case 6:
                this.metadata = (object) entityMetadata1.ViewModelMetadata;
                num = 5;
                continue;
              case 7:
                goto label_11;
              default:
                entityMetadata1 = entityMetadata;
                num = 6;
                continue;
            }
          }
label_11:
          return;
label_2:;
        }

        private void CaseEntityMetadata(EntityMetadata entityMetadata)
        {
          int num1 = 4;
          while (true)
          {
            int num2 = num1;
            EntityMetadata entityMetadata2;
            Guid modelPropertyUid;
            PropertyMetadata property1;
            Guid rootViewModelMetadataUid;
            DataClass.ValueContainer.ViewModelMetadataValueContainer metadataValueContainer;
            EntityMetadata entityMetadata1;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  if (DataClass.ValueContainer.ViewModelMetadataValueContainer.FuwJuhZNdMhK4xV5COvi((object) ((DataClassMetadata) this.metadata).IncludeList) == 0)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 3 : 7;
                    continue;
                  }
                  goto case 16;
                case 2:
                  if (DataClass.ValueContainer.ViewModelMetadataValueContainer.pwtTfbZN5fJHFGJeftpv((object) entityMetadata2) == EntityMetadataType.InterfaceExtension)
                  {
                    num2 = 15;
                    continue;
                  }
                  goto case 13;
                case 3:
                  metadataValueContainer = this;
                  num2 = 9;
                  continue;
                case 4:
                  num2 = 3;
                  continue;
                case 5:
                  if (property1 != null)
                  {
                    num2 = 8;
                    continue;
                  }
                  goto case 14;
                case 6:
                  IEnumerable<PropertyMetadata> source = ((ClassMetadata) this.metadata).Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (a =>
                  {
                    int num3 = 1;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.gYQtOHZa5IG7dLStfux4(DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.kRmG9DZaYnnLKrQYGZRi((object) a), ActionDescriptor.UID))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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
                    return a.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154127513);
label_3:
                    return true;
                  }));
                  // ISSUE: reference to a compiler-generated field
                  Func<PropertyMetadata, Guid> func = DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__6_1;
                  Func<PropertyMetadata, Guid> keySelector;
                  if (func == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.\u003C\u003E9__6_1 = keySelector = (Func<PropertyMetadata, Guid>) (p => DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.jqH4H8ZajSd6UyMXAfme((object) p));
                  }
                  else
                    goto label_33;
label_31:
                  // ISSUE: reference to a compiler-generated method
                  Func<PropertyMetadata, IPropertyDefaultValueContainer> elementSelector = (Func<PropertyMetadata, IPropertyDefaultValueContainer>) (p => (IPropertyDefaultValueContainer) DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec__DisplayClass6_0.Qb8xcDZDB8BYsVI1piZi(metadataValueContainer.metadata, (object) entityMetadata1, (object) p));
                  this.defaultProperties = (IDictionary<Guid, IPropertyDefaultValueContainer>) source.ToDictionary<PropertyMetadata, Guid, IPropertyDefaultValueContainer>(keySelector, elementSelector);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 18 : 8;
                  continue;
label_33:
                  keySelector = func;
                  goto label_31;
                case 7:
                  goto label_24;
                case 8:
                  (rootViewModelMetadataUid, modelPropertyUid) = DataClass.ValueContainer.ViewModelMetadataValueContainer.GetRootViewModelContextData((object) entityMetadata1);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                  continue;
                case 9:
                  entityMetadata1 = entityMetadata;
                  num2 = 11;
                  continue;
                case 10:
                  this.defaultProperties[property1.Uid] = (IPropertyDefaultValueContainer) new DataClass.ViewModelContextModelPropertyValueContainer(rootViewModelMetadataUid, modelPropertyUid);
                  num2 = 14;
                  continue;
                case 11:
                  this.metadata = DataClass.ValueContainer.ViewModelMetadataValueContainer.pJ4bjEZNlTQP4IBEodTT((object) entityMetadata1);
                  num2 = 6;
                  continue;
                case 12:
                  if (property1 != null)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
                    continue;
                  }
                  goto case 16;
                case 13:
                  this.includeViewModelMetadata = DataClass.ValueContainer.ViewModelMetadataValueContainer.eVRUZXZNLF1POeD05rpv(DataClass.ValueContainer.ViewModelMetadataValueContainer.dYMBHsZNYi3d7lHbxtJ4((object) entityMetadata2));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 18 : 20;
                  continue;
                case 14:
                case 17:
                  entityMetadata2 = entityMetadata1;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
                  continue;
                case 15:
                  entityMetadata2 = (EntityMetadata) ((IMetadataService) DataClass.ValueContainer.ViewModelMetadataValueContainer.TKWLLYZNjmApjlqZvVdf()).GetMetadata(entityMetadata2.BaseClassUid);
                  num2 = 13;
                  continue;
                case 16:
                  if (DataClass.ValueContainer.ViewModelMetadataValueContainer.FuwJuhZNdMhK4xV5COvi((object) ((DataClassMetadata) this.metadata).IncludeList) == 1)
                  {
                    num2 = 5;
                    continue;
                  }
                  goto label_11;
                case 18:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  property1 = ((ClassMetadata) this.metadata).Properties.Find((Predicate<PropertyMetadata>) (property => DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.lq0nYqZasKXsAvRR2YJL(DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.uenULHZaL4dof7fwXIvg((object) property), DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.IPANvXZaUph62ekCrQEF(-1290212282 ^ -644262414 ^ 1786865656))));
                  num2 = 12;
                  continue;
                case 19:
                  if (modelPropertyUid != Guid.Empty)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 4 : 10;
                    continue;
                  }
                  goto case 14;
                case 20:
                  goto label_29;
                default:
                  if (DataClass.ValueContainer.ViewModelMetadataValueContainer.Jqsj4uZNgKMZttjLEA9F(rootViewModelMetadataUid, Guid.Empty))
                    goto case 19;
                  else
                    goto label_18;
              }
            }
label_18:
            num1 = 17;
            continue;
label_24:
            this.defaultProperties[DataClass.ValueContainer.ViewModelMetadataValueContainer.mlxUnCZNrFvUZVDxKesJ((object) property1)] = DataClass.ValueContainer.DataClassMetadataValueContainer.CreatePropertyDefaultValueContainer(this.metadata, (object) entityMetadata1, (object) property1);
            num1 = 16;
          }
label_29:
          return;
label_11:;
        }

        private static (Guid, Guid) GetRootViewModelContextData(object entityMetadata)
        {
          DataClassMetadata dataClassMetadata1 = ((EntityMetadata) entityMetadata).ViewModelMetadata;
          EntityMetadata entityMetadata1 = (EntityMetadata) entityMetadata;
          if (entityMetadata1.Type == EntityMetadataType.InterfaceExtension)
            entityMetadata1 = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(entityMetadata1.BaseClassUid);
          while (entityMetadata1.BaseClassUid != Guid.Empty)
          {
            entityMetadata1 = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(entityMetadata1.BaseClassUid);
            DataClassMetadata dataClassMetadata2 = (DataClassMetadata) null;
            if (entityMetadata1.ViewModelMetadata != null)
              dataClassMetadata2 = entityMetadata1.ViewModelMetadata;
            else if (entityMetadata1.ImplementedExtensionUids != null && entityMetadata1.ImplementedExtensionUids.Count != 0)
            {
              string str = entityMetadata1.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979526924);
              foreach (Guid implementedExtensionUid in entityMetadata1.ImplementedExtensionUids)
              {
                if ((MetadataServiceContext.Service.GetMetadata(implementedExtensionUid, false) is EntityMetadata metadata ? metadata.Name : (string) null) == str && metadata.ViewModelMetadata != null)
                {
                  dataClassMetadata2 = metadata.ViewModelMetadata;
                  break;
                }
              }
            }
            if (dataClassMetadata2 != null)
              dataClassMetadata1 = dataClassMetadata2;
            else
              break;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          PropertyMetadata propertyMetadata = dataClassMetadata1.Properties.Find((Predicate<PropertyMetadata>) (property => DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.lq0nYqZasKXsAvRR2YJL(DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.uenULHZaL4dof7fwXIvg((object) property), DataClass.ValueContainer.ViewModelMetadataValueContainer.\u003C\u003Ec.IPANvXZaUph62ekCrQEF(-1334993905 ^ -1335016893))));
          return (dataClassMetadata1.Uid, propertyMetadata != null ? propertyMetadata.Uid : Guid.Empty);
        }

        internal static object nfaBlRZNMqn82uPCyKfm([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

        internal static object hNdlD1ZNJQwj9N8lR7Xn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static bool yqTdIUZN9E251EHWKALK([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

        internal static bool YlxeM1ZNm8jZiG2YUYaW() => DataClass.ValueContainer.ViewModelMetadataValueContainer.I3iRqpZN0NdeRSu639AC == null;

        internal static DataClass.ValueContainer.ViewModelMetadataValueContainer yV2L41ZNyen7Pa40a1e6() => (DataClass.ValueContainer.ViewModelMetadataValueContainer) DataClass.ValueContainer.ViewModelMetadataValueContainer.I3iRqpZN0NdeRSu639AC;

        internal static int FuwJuhZNdMhK4xV5COvi([In] object obj0) => ((List<DataClassDependency>) obj0).Count;

        internal static object pJ4bjEZNlTQP4IBEodTT([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

        internal static Guid mlxUnCZNrFvUZVDxKesJ([In] object obj0) => ((AbstractMetadata) obj0).Uid;

        internal static bool Jqsj4uZNgKMZttjLEA9F([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

        internal static EntityMetadataType pwtTfbZN5fJHFGJeftpv([In] object obj0) => ((EntityMetadata) obj0).Type;

        internal static object TKWLLYZNjmApjlqZvVdf() => (object) MetadataServiceContext.Service;

        internal static Guid dYMBHsZNYi3d7lHbxtJ4([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

        internal static object eVRUZXZNLF1POeD05rpv(Guid ownerMetadataUid) => (object) DataClass.ValueContainer.CreateViewModelMetadataHeaderValueContainer(ownerMetadataUid);
      }

      /// <summary>
      /// <see cref="T:EleWise.ELMA.DataClasses.DataClass.ValueContainer" /> по уникальному идентификатору метаданных ViewModel
      /// </summary>
      private class ViewModelMetadataHeaderValueContainer : DataClass.ValueContainer
      {
        private readonly Guid ownerMetadataUid;
        internal static object WkrrBpZNUOr7TrBp9JkJ;

        /// <summary>Ctor</summary>
        /// <param name="ownerMetadataUid">Уникальный идентификатор метаданных обладателя ViewModelMetadata</param>
        public ViewModelMetadataHeaderValueContainer(Guid ownerMetadataUid)
        {
          DataClass.ValueContainer.ViewModelMetadataHeaderValueContainer.c4WMyIZNz5Bo2Jw2gwsx();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.ownerMetadataUid = ownerMetadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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
        internal override string Initialize(
          IDictionary<Guid, DataClass.ValueContainer.DataContainer> data)
        {
          EntityMetadata metadata1 = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(this.ownerMetadataUid);
          EntityMetadata entityMetadata = metadata1;
          if (metadata1.ViewModelMetadata == null && metadata1.ImplementedExtensionUids != null)
          {
            string str = entityMetadata.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334915907);
            foreach (Guid implementedExtensionUid in metadata1.ImplementedExtensionUids)
            {
              if ((MetadataServiceContext.Service.GetMetadata(implementedExtensionUid, false) is EntityMetadata metadata2 ? metadata2.Name : (string) null) == str && metadata2.ViewModelMetadata != null)
              {
                entityMetadata = metadata2;
                break;
              }
            }
          }
          return new DataClass.ValueContainer.ViewModelMetadataValueContainer(entityMetadata).Initialize(data);
        }

        internal static void c4WMyIZNz5Bo2Jw2gwsx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool sl73b6ZNsudnj5ugMoQw() => DataClass.ValueContainer.ViewModelMetadataHeaderValueContainer.WkrrBpZNUOr7TrBp9JkJ == null;

        internal static DataClass.ValueContainer.ViewModelMetadataHeaderValueContainer SrOTr1ZNcjlHWC7BluNX() => (DataClass.ValueContainer.ViewModelMetadataHeaderValueContainer) DataClass.ValueContainer.ViewModelMetadataHeaderValueContainer.WkrrBpZNUOr7TrBp9JkJ;
      }
    }

    private sealed class ViewModelContextModelPropertyValueContainer : IPropertyDefaultValueContainer
    {
      private object nested;
      private static object O0AK5j8JsftEsumGy3k2;

      public ViewModelContextModelPropertyValueContainer(
        Guid rootViewModelMetadataUid,
        Guid modelPropertyUid)
      {
        DataClass.ViewModelContextModelPropertyValueContainer.LlQ8En89F79SfJVlkaLu();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.nested = (object) new DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer(rootViewModelMetadataUid, modelPropertyUid, this);
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

      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) DataClass.ViewModelContextModelPropertyValueContainer.lxlbsH89BcD6ioHUFjxG(this.nested);

      internal static void LlQ8En89F79SfJVlkaLu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool ce1ArL8JcviaKUWlJ4Rl() => DataClass.ViewModelContextModelPropertyValueContainer.O0AK5j8JsftEsumGy3k2 == null;

      internal static DataClass.ViewModelContextModelPropertyValueContainer OTPLCb8JzZNWlMVwlYXj() => (DataClass.ViewModelContextModelPropertyValueContainer) DataClass.ViewModelContextModelPropertyValueContainer.O0AK5j8JsftEsumGy3k2;

      internal static object lxlbsH89BcD6ioHUFjxG([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

      private sealed class NestedDefaultValueContainer : 
        DataClass.IPropertyValueContainerCast,
        IPropertyValueContainer,
        IPropertyDefaultValueContainer
      {
        private readonly Guid rootViewModelMetadataUid;
        private readonly Guid modelPropertyUid;
        private readonly object viewModelContextModelPropertyValueContainer;
        private object castedContainer;
        internal static object yqnbiDZ3OWA729NC3xkm;

        public NestedDefaultValueContainer(
          Guid rootViewModelMetadataUid,
          Guid modelPropertyUid,
          DataClass.ViewModelContextModelPropertyValueContainer viewModelContextModelPropertyValueContainer)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.modelPropertyUid = modelPropertyUid;
                num = 3;
                continue;
              case 2:
                goto label_3;
              case 3:
                this.viewModelContextModelPropertyValueContainer = (object) viewModelContextModelPropertyValueContainer;
                num = 2;
                continue;
              default:
                this.rootViewModelMetadataUid = rootViewModelMetadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
                continue;
            }
          }
label_3:;
        }

        object IPropertyValueContainer.Get(object obj)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (this.castedContainer == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              default:
                goto label_2;
            }
          }
label_2:
          return DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer.YQ6wgVZ3PBkZGBgimwDZ((object) (DataClass) obj, this.rootViewModelMetadataUid, this.modelPropertyUid);
label_3:
          return ((IPropertyValueContainer) this.castedContainer).Get(obj);
        }

        void IPropertyValueContainer.Set(object obj, object value)
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_6;
              case 1:
                DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer.zHItTYZ31UocMG1Mc7Uj(this.castedContainer, obj, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                continue;
              case 2:
                if (this.castedContainer != null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                  continue;
                }
                DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer.nIGCdXZ3N53qtWO2LsRk((object) (DataClass) obj, this.rootViewModelMetadataUid, this.modelPropertyUid, value);
                num = 3;
                continue;
              case 3:
                goto label_2;
              default:
                goto label_8;
            }
          }
label_6:
          return;
label_2:
          return;
label_8:;
        }

        Type IPropertyValueContainer.PropertyType
        {
          get
          {
            int num = 2;
            Type propertyType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  propertyType = (Type) null;
                  break;
                case 2:
                  object castedContainer = this.castedContainer;
                  if (castedContainer == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
                    continue;
                  }
                  propertyType = DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer.O9X4mAZ33NHy2xCvgtYy(castedContainer);
                  break;
                default:
                  goto label_9;
              }
              if ((object) propertyType == null)
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              else
                break;
            }
            return propertyType;
label_9:
            return TypeOf<IEntity>.Raw;
          }
        }

        IPropertyValueContainer<T> DataClass.IPropertyValueContainerCast.Cast<T>()
        {
          if (this.castedContainer == null)
          {
            DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer<T> defaultValueContainer = new DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer<T>(this.rootViewModelMetadataUid, this.modelPropertyUid);
            ((DataClass.ViewModelContextModelPropertyValueContainer) this.viewModelContextModelPropertyValueContainer).nested = (object) defaultValueContainer;
            this.castedContainer = (object) defaultValueContainer;
          }
          return (IPropertyValueContainer<T>) this.castedContainer;
        }

        IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) this;

        internal static bool vDK8bSZ32LHZmaqs7fG5() => DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer.yqnbiDZ3OWA729NC3xkm == null;

        internal static DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer TsLPBEZ3eRywjXLYQUxi() => (DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer) DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer.yqnbiDZ3OWA729NC3xkm;

        internal static object YQ6wgVZ3PBkZGBgimwDZ(
          [In] object obj0,
          Guid metadataUid,
          Guid propertyUid)
        {
          return ((DataClass) obj0).GetObject(metadataUid, propertyUid);
        }

        internal static void zHItTYZ31UocMG1Mc7Uj([In] object obj0, [In] object obj1, [In] object obj2) => ((IPropertyValueContainer) obj0).Set(obj1, obj2);

        internal static void nIGCdXZ3N53qtWO2LsRk(
          [In] object obj0,
          Guid metadataUid,
          Guid propertyUid,
          [In] object obj3)
        {
          ((DataClass) obj0).SetObject(metadataUid, propertyUid, obj3);
        }

        internal static Type O9X4mAZ33NHy2xCvgtYy([In] object obj0) => ((IPropertyValueContainer) obj0).PropertyType;
      }

      private sealed class NestedDefaultValueContainer<T> : 
        DataClass.IPropertyValueContainerCast,
        IPropertyValueContainer,
        IPropertyDefaultValueContainer,
        IPropertyValueContainer<T>
      {
        private readonly Guid rootViewModelMetadataUid;
        private readonly Guid modelPropertyUid;
        private static object ujV8fJZ3pKiWLQBQYCg8;

        public NestedDefaultValueContainer(Guid rootViewModelMetadataUid, Guid modelPropertyUid)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                this.modelPropertyUid = modelPropertyUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
                continue;
              default:
                this.rootViewModelMetadataUid = rootViewModelMetadataUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 2;
                continue;
            }
          }
label_3:;
        }

        object IPropertyValueContainer.Get(object obj) => ((DataClass) obj).GetObject(this.rootViewModelMetadataUid, this.modelPropertyUid);

        void IPropertyValueContainer.Set(object obj, object value)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                ((DataClass) obj).SetObject(this.rootViewModelMetadataUid, this.modelPropertyUid, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        T IPropertyValueContainer<T>.Get(object obj) => (T) ((IPropertyValueContainer) this).Get(obj);

        void IPropertyValueContainer<T>.Set(object obj, T value) => ((IPropertyValueContainer) this).Set(obj, (object) value);

        Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

        IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) this;

        IPropertyValueContainer<T1> DataClass.IPropertyValueContainerCast.Cast<T1>() => (IPropertyValueContainer<T1>) this;

        internal static bool U68cAdZ3acj6Y5tgftLX() => DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer<T>.ujV8fJZ3pKiWLQBQYCg8 == null;

        internal static object bv229sZ3D7iAecwwe2gW() => DataClass.ViewModelContextModelPropertyValueContainer.NestedDefaultValueContainer<T>.ujV8fJZ3pKiWLQBQYCg8;
      }
    }
  }
}
