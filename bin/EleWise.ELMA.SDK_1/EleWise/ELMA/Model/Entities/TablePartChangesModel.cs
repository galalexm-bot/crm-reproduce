// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.TablePartChangesModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Модель для хранения изменений в блоке</summary>
  public class TablePartChangesModel
  {
    private static IEnumerable<IOriginalCollectionExtension> originalCollectionExtension;
    private static ISecurityService securityService;
    [ScriptIgnore]
    [JsonIgnore]
    [XmlIgnore]
    [NonSerialized]
    private List<IEntity> _addedEntities;
    [ScriptIgnore]
    [JsonIgnore]
    [XmlIgnore]
    [NonSerialized]
    private List<IEntity> _changedEntities;
    [XmlIgnore]
    [JsonIgnore]
    [ScriptIgnore]
    [NonSerialized]
    private List<IEntity> _deletedEntities;
    internal static TablePartChangesModel zeIO6PhZf2fy1xxZoT96;

    private static IEnumerable<IOriginalCollectionExtension> OriginalCollectionExtension => TablePartChangesModel.originalCollectionExtension ?? (TablePartChangesModel.originalCollectionExtension = ComponentManager.Current.GetExtensionPoints<IOriginalCollectionExtension>());

    private static ISecurityService SecurityService
    {
      get
      {
        int num = 1;
        ISecurityService securityService;
        while (true)
        {
          switch (num)
          {
            case 1:
              securityService = TablePartChangesModel.securityService;
              if (securityService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return securityService;
label_5:
        return TablePartChangesModel.securityService = Locator.GetServiceNotNull<ISecurityService>();
      }
    }

    /// <summary>Ctor</summary>
    public TablePartChangesModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Changed = new List<IDictionary<string, object>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            this.Added = new List<IDictionary<string, object>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            this.Deleted = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 2;
            continue;
        }
      }
label_3:;
    }

    public TablePartChangesModel(IEnumerable items, IEnumerable originalItems)
    {
      TablePartChangesModel.mn84yfhZvo3ntpDjEj2B();
      // ISSUE: explicit constructor call
      this.\u002Ector(items, originalItems, (ViewItemTransformation) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TablePartChangesModel(
      IEnumerable items,
      IEnumerable originalItems,
      ViewItemTransformation viewItemTransformation)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num1 = 12;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num1 = 7;
      while (true)
      {
        IOriginalCollectionExtension collectionExtension;
        IEnumerator<IEntity> enumerator1;
        IEnumerator enumerator2;
        IEnumerable source1;
        EntitySerializationSettings settings;
        object obj;
        List<object> currentIds;
        switch (num1)
        {
          case 1:
          case 15:
            IEnumerable<IEntity> source2 = source1.OfType<IEntity>();
            Func<IEntity, bool> func;
            Func<IEntity, bool> func1 = func;
            Func<IEntity, bool> predicate = func1 == null ? (func = (Func<IEntity, bool>) (e =>
            {
              int num2 = 2;
              object id;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    id = e.GetId();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              return !currentIds.Any<object>((Func<object, bool>) (currentId => currentId.Equals(id)));
            })) : func1;
            enumerator1 = source2.Where<IEntity>(predicate).GetEnumerator();
            num1 = 7;
            continue;
          case 2:
            source1 = (IEnumerable) items.OfType<IEntity>().Where<IEntity>((Func<IEntity, bool>) (e => !e.IsNew())).ToList<IEntity>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 13 : 15;
            continue;
          case 3:
            obj = (object) originalItems;
            break;
          case 4:
            if (collectionExtension == null)
            {
              num1 = 3;
              continue;
            }
            obj = TablePartChangesModel.JVgsi8hZinOB3L1F3oba((object) collectionExtension, (object) originalItems);
            break;
          case 5:
          case 19:
label_5:
            this.TotalCount = new int?(items.Cast<object>().Count<object>());
            num1 = 13;
            continue;
          case 6:
            this._changedEntities = new List<IEntity>();
            num1 = 20;
            continue;
          case 7:
            try
            {
label_10:
              if (enumerator1.MoveNext())
                goto label_13;
              else
                goto label_11;
label_9:
              IEntity current;
              int num3;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    this.Deleted.Add(TablePartChangesModel.Mroko9hZV2k6FxbC5Ya3((object) current).ToString());
                    num3 = 4;
                    continue;
                  case 3:
                    goto label_10;
                  case 4:
                    this._deletedEntities.Add(current);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 3;
                    continue;
                  default:
                    goto label_13;
                }
              }
label_11:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
              goto label_9;
label_13:
              current = enumerator1.Current;
              num3 = 2;
              goto label_9;
            }
            finally
            {
              int num4;
              if (enumerator1 == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
              else
                goto label_18;
label_17:
              switch (num4)
              {
                case 2:
                  break;
                default:
              }
label_18:
              enumerator1.Dispose();
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
              {
                num4 = 0;
                goto label_17;
              }
              else
                goto label_17;
            }
          case 8:
            goto label_26;
          case 9:
            try
            {
label_40:
              if (enumerator2.MoveNext())
                goto label_31;
              else
                goto label_41;
label_29:
              IEntity entity;
              int num5;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    this.Added.Add((IDictionary<string, object>) new EntityJsonSerializer().ConvertToSerializable((object) entity, settings));
                    num5 = 2;
                    continue;
                  case 2:
                    this._addedEntities.Add(entity);
                    num5 = 4;
                    continue;
                  case 3:
                    goto label_40;
                  case 4:
                  case 10:
                    currentIds.Add(TablePartChangesModel.Mroko9hZV2k6FxbC5Ya3((object) entity));
                    num5 = 3;
                    continue;
                  case 5:
                    goto label_31;
                  case 6:
                    if (!entity.IsNew())
                    {
                      num5 = 7;
                      continue;
                    }
                    goto case 1;
                  case 7:
                  case 9:
                    if (TablePartChangesModel.UKUWAVhZIP0LSHjyMjk8((object) entity))
                    {
                      num5 = 11;
                      continue;
                    }
                    goto case 4;
                  case 8:
                    this._changedEntities.Add(entity);
                    num5 = 10;
                    continue;
                  case 11:
                    this.Changed.Add((IDictionary<string, object>) new EntityJsonSerializer().ConvertToSerializable((object) entity, settings));
                    num5 = 8;
                    continue;
                  default:
                    goto label_53;
                }
              }
label_31:
              entity = (IEntity) TablePartChangesModel.QY6WOphZuyYYiMxhle5w((object) enumerator2);
              num5 = 6;
              goto label_29;
label_41:
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              goto label_29;
            }
            finally
            {
              IDisposable disposable = enumerator2 as IDisposable;
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_48;
                  case 2:
                    TablePartChangesModel.oZGWOVhZS8ULWGREWDbx((object) disposable);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
                    continue;
                  default:
                    if (disposable != null)
                    {
                      num6 = 2;
                      continue;
                    }
                    goto label_48;
                }
              }
label_48:;
            }
          case 10:
            this._addedEntities = new List<IEntity>();
            num1 = 6;
            continue;
          case 11:
            this.ViewItemTransformation = viewItemTransformation;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 10 : 3;
            continue;
          case 12:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 11 : 9;
            continue;
          case 13:
            goto label_62;
          case 14:
            // ISSUE: reference to a compiler-generated method
            collectionExtension = TablePartChangesModel.OriginalCollectionExtension.FirstOrDefault<IOriginalCollectionExtension>((Func<IOriginalCollectionExtension, bool>) (ext => TablePartChangesModel.\u003C\u003Ec__DisplayClass8_0.V6SbvWCc8DDCUkImVWdP((object) ext, (object) originalItems)));
            num1 = 4;
            continue;
          case 16:
            currentIds = new List<object>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 17:
            enumerator2 = (IEnumerator) TablePartChangesModel.DQ6Qu7hZZvB0iuEcFA6j((object) items);
            num1 = 9;
            continue;
          case 18:
            if (source1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 20:
            this._deletedEntities = new List<IEntity>();
            num1 = 21;
            continue;
          case 21:
            if (items != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 9 : 16;
              continue;
            }
            goto label_55;
          case 22:
label_53:
            if (originalItems == null)
            {
              num1 = 19;
              continue;
            }
            goto case 14;
          default:
            EntitySerializationSettings serializationSettings = new EntitySerializationSettings();
            TablePartChangesModel.ixsdJVhZ8pmr7GTNKW4I((object) serializationSettings, EntitySerializationMode.ChangesOnly);
            settings = serializationSettings;
            num1 = 17;
            continue;
        }
        source1 = (IEnumerable) obj;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 5 : 18;
      }
label_26:
      return;
label_62:
      return;
label_55:;
    }

    /// <summary>Добавленные элементы</summary>
    public List<IDictionary<string, object>> Added { get; set; }

    /// <summary>Измененные элементы</summary>
    public List<IDictionary<string, object>> Changed { get; set; }

    /// <summary>Идентификаторы удаленных элементов</summary>
    public List<string> Deleted { get; set; }

    /// <summary>Серилизованная трансформация элемента представления</summary>
    public string Transformation
    {
      get => this.ViewItemTransformation.SerializeToJson();
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
              this.ViewItemTransformation = !TablePartChangesModel.VapOMMhZRAgQjVAOrt1v((object) value) ? ViewItemTransformation.DeserializeFromJson(value) : (ViewItemTransformation) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    /// <summary>Общее количество записей</summary>
    public int? TotalCount { get; set; }

    /// <summary>
    /// Добавленные элементы (заполняется только после вызова конструктора с параметрами (IEnumerable, IEnumerable)
    /// </summary>
    [JsonIgnore]
    [ScriptIgnore]
    [XmlIgnore]
    public IEnumerable<IEntity> AddedEntities => (IEnumerable<IEntity>) this._addedEntities;

    /// <summary>
    /// Измененные элементы (заполняется только после вызова конструктора с параметрами (IEnumerable, IEnumerable)
    /// </summary>
    [XmlIgnore]
    [JsonIgnore]
    [ScriptIgnore]
    public IEnumerable<IEntity> ChangedEntities => (IEnumerable<IEntity>) this._changedEntities;

    /// <summary>
    /// Удаленные элементы (заполняется только после вызова конструктора с параметрами (IEnumerable, IEnumerable)
    /// </summary>
    [XmlIgnore]
    [ScriptIgnore]
    [JsonIgnore]
    public IEnumerable<IEntity> DeletedEntities => (IEnumerable<IEntity>) this._deletedEntities;

    /// <summary>Трансформация элемента представления</summary>
    [JsonIgnore]
    [XmlIgnore]
    [ScriptIgnore]
    public ViewItemTransformation ViewItemTransformation
    {
      get => this.\u003CViewItemTransformation\u003Ek__BackingField;
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
              this.\u003CViewItemTransformation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    /// <summary>Применить изменения</summary>
    /// <param name="items">Оригинальный список элементов</param>
    /// <param name="itemType">Тип элемента</param>
    public void Apply(ISet items, Type itemType, Func<IEntity, bool> needBindProperties = null) => this.Apply(items, itemType, false, needBindProperties);

    /// <summary>Применить изменения</summary>
    /// <param name="items">Оригинальный список элементов</param>
    /// <param name="itemType">Тип элемента</param>
    /// <param name="needBindProperties">Функция, определяющая нужно ли биндить значения свойств сущности</param>
    /// <returns>Элементы с применёнными изменениями</returns>
    public IEnumerable ApplyImmutable(
      IEnumerable items,
      Type itemType,
      Func<IEntity, bool> needBindProperties = null)
    {
      HashedSet<IEntity> items1 = items != null ? new HashedSet<IEntity>(items.Cast<IEntity>()) : new HashedSet<IEntity>();
      this.Apply((ISet) items1, itemType, false, needBindProperties);
      return (IEnumerable) items1;
    }

    /// <summary>Применить изменения</summary>
    /// <param name="items">Оригинальный список элементов</param>
    /// <param name="itemType">Тип элемента</param>
    public void Apply(
      ISet items,
      Type itemType,
      bool needRemoveOldItems,
      Func<IEntity, bool> needBindProperties = null)
    {
      if (items == null || itemType == (Type) null)
        return;
      // ISSUE: object of a compiler-generated type is created
      Dictionary<object, IEntity> dictionary1 = items.OfType<IEntity>().Select(e => new \u003C\u003Ef__AnonymousType12<object, IEntity>(e.GetId(), e)).Where(i => !i.entity.GetType().IsDefaultId(i.id.GetType(), i.id)).ToDictionary(i => i.id, i => i.entity);
      PropertyInfo uidProp = itemType.GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411205569));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      Dictionary<object, IEntity> dictionary2 = uidProp != (PropertyInfo) null ? items.OfType<IEntity>().Where<IEntity>((Func<IEntity, bool>) (i => TablePartChangesModel.\u003C\u003Ec.ync4OCCcOV0iaatv3Z0y(i.GetType(), i.GetId().GetType(), TablePartChangesModel.\u003C\u003Ec.phX5rsCcnEpiKGDvd35i((object) i)))).GroupBy<IEntity, object>((Func<IEntity, object>) (k => TablePartChangesModel.\u003C\u003Ec__DisplayClass40_0.XqppaCCc1CIyTbV56S3N((object) uidProp, (object) k, (object) null))).Where<IGrouping<object, IEntity>>((Func<IGrouping<object, IEntity>, bool>) (p => p.Count<IEntity>() == 1)).ToDictionary<IGrouping<object, IEntity>, object, IEntity>((Func<IGrouping<object, IEntity>, object>) (p => p.Key), (Func<IGrouping<object, IEntity>, IEntity>) (p => p.First<IEntity>())) : (Dictionary<object, IEntity>) null;
      List<object> neededItemIds = new List<object>();
      foreach (IDictionary<string, object> expItem in this.Added)
      {
        IEntity entity = this.DeserializeEntity(items, (Dictionary<object, IEntity>) null, dictionary2, itemType, needBindProperties, expItem, true);
        if (entity != null)
          neededItemIds.Add(entity.GetId());
      }
      foreach (IDictionary<string, object> expItem in this.Changed)
      {
        IEntity entity = this.DeserializeEntity(items, dictionary1, (Dictionary<object, IEntity>) null, itemType, needBindProperties, expItem, false);
        if (entity != null)
          neededItemIds.Add(entity.GetId());
      }
      foreach (string idValue in this.Deleted)
      {
        object key = ModelHelper.TryConvertEntityId(itemType, (object) idValue);
        IEntity o;
        if (key != null && dictionary1.TryGetValue(key, out o))
        {
          items.Remove((object) o);
          if (MetadataLoader.LoadMetadata(o.GetType()) is ITablePartMetadata tablePartMetadata && tablePartMetadata.ParentPropertyUid != Guid.Empty)
            o.SetPropertyValue(tablePartMetadata.ParentPropertyUid, (object) null);
        }
      }
      if (!needRemoveOldItems)
        return;
      foreach (IEntity o in items.OfType<IEntity>().Where<IEntity>((Func<IEntity, bool>) (i =>
      {
        int num = 1;
        IEntity i1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (TablePartChangesModel.\u003C\u003Ec__DisplayClass40_0.J5XBeeCcNqDSmUOSirlb((object) i1))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 1;
                continue;
              }
              goto label_7;
            default:
              i1 = i;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 3 : 3;
              continue;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated method
        return !neededItemIds.Any<object>((Func<object, bool>) (id => id.Equals(TablePartChangesModel.\u003C\u003Ec__DisplayClass40_1.N4BGfCCctZyPJrQANhS2((object) i1))));
label_7:
        return false;
      })).ToList<IEntity>())
        items.Remove((object) o);
    }

    /// <summary>Преобразовать в словарь</summary>
    /// <returns></returns>
    public IDictionary<string, object> ToDictionary()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.TotalCount.HasValue)
        dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536721928)] = (object) this.TotalCount.Value;
      if (this.Added.Count > 0)
        dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099571411)] = (object) this.Added;
      if (this.Changed.Count > 0)
        dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334911353)] = (object) this.Changed;
      if (this.Deleted.Count > 0)
        dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333555336)] = (object) this.Deleted;
      if (this.ViewItemTransformation != null)
        dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712299803)] = (object) this.ViewItemTransformation.SerializeToJson();
      return (IDictionary<string, object>) dictionary;
    }

    /// <summary>Преобразовать из словаря</summary>
    /// <param name="dict"></param>
    /// <returns></returns>
    public static TablePartChangesModel FromDictionary(IDictionary<string, object> dict)
    {
      TablePartChangesModel partChangesModel = new TablePartChangesModel();
      if (dict != null)
      {
        Action<string, IList> action = (Action<string, IList>) ((key, resultList) =>
        {
          int num1 = 3;
          IEnumerator enumerator;
          while (true)
          {
            int num2 = num1;
            object obj;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  goto label_24;
                case 2:
                  if (obj is IEnumerable enumerable2)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_16;
                case 3:
                  goto label_3;
                case 4:
                  goto label_8;
                default:
                  // ISSUE: reference to a compiler-generated method
                  enumerator = (IEnumerator) TablePartChangesModel.\u003C\u003Ec__DisplayClass42_0.EHpTrxCcA7eovpOe6iTa((object) enumerable2);
                  num2 = 4;
                  continue;
              }
            }
label_3:
            if (dict.TryGetValue(key, out obj))
              num1 = 2;
            else
              goto label_20;
          }
label_24:
          return;
label_20:
          return;
label_16:
          return;
label_8:
          try
          {
label_14:
            // ISSUE: reference to a compiler-generated method
            if (TablePartChangesModel.\u003C\u003Ec__DisplayClass42_0.paorGMCc0V2mWSElcrhU((object) enumerator))
              goto label_12;
            else
              goto label_15;
label_9:
            object obj;
            int num3;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_10;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  TablePartChangesModel.\u003C\u003Ec__DisplayClass42_0.sUg4JQCcxQ7ck2Ni7UGt((object) resultList, obj);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 1;
                  continue;
                case 3:
                  goto label_14;
                default:
                  goto label_12;
              }
            }
label_10:
            return;
label_12:
            // ISSUE: reference to a compiler-generated method
            obj = TablePartChangesModel.\u003C\u003Ec__DisplayClass42_0.yoNWx8Cc7tjVaRo11edV((object) enumerator);
            num3 = 2;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
            {
              num3 = 2;
              goto label_9;
            }
            else
              goto label_9;
label_15:
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
            goto label_9;
          }
          finally
          {
            IDisposable disposable = enumerator as IDisposable;
            int num4 = 3;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
              num4 = 3;
            while (true)
            {
              switch (num4)
              {
                case 1:
                case 2:
                  goto label_25;
                case 3:
                  if (disposable == null)
                  {
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 0;
                    continue;
                  }
                  break;
              }
              // ISSUE: reference to a compiler-generated method
              TablePartChangesModel.\u003C\u003Ec__DisplayClass42_0.C8X9b4CcmY5lMq3vHrKk((object) disposable);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            }
label_25:;
          }
        });
        action(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -282054974), (IList) partChangesModel.Added);
        action(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917075458), (IList) partChangesModel.Changed);
        action(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859067077), (IList) partChangesModel.Deleted);
        object json;
        if (dict.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217571947), out json) && json is string)
          partChangesModel.ViewItemTransformation = !string.IsNullOrEmpty((string) json) ? ViewItemTransformation.DeserializeFromJson((string) json) : (ViewItemTransformation) null;
      }
      return partChangesModel;
    }

    /// <summary>Сериализвать в JSON</summary>
    /// <returns></returns>
    public string ToJson() => new EleWise.ELMA.Serialization.JsonSerializer().Serialize((object) this.ToDictionary());

    private IEntity DeserializeEntity(
      ISet items,
      Dictionary<object, IEntity> itemsById,
      Dictionary<object, IEntity> itemsByUid,
      Type itemType,
      Func<IEntity, bool> needBindProperties,
      IDictionary<string, object> expItem,
      bool canCreateNew)
    {
      object idObj;
      if (!expItem.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113895773), out idObj))
        return (IEntity) null;
      IEntity entity = (IEntity) null;
      Func<IEntity, bool> func;
      TablePartChangesModel.SecurityService.RunWithElevatedPrivilegiesAndWithDeleted((System.Action) (() =>
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          EntityJsonSerializer entityJsonSerializer;
          object obj1;
          object key;
          object obj2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                entityJsonSerializer = new EntityJsonSerializer()
                {
                  NeedBindProperties = needBindProperties
                };
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                continue;
              case 2:
                if (obj1 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 14 : 21;
                  continue;
                }
                goto case 3;
              case 3:
                if (itemsById == null)
                {
                  num2 = 15;
                  continue;
                }
                goto case 20;
              case 4:
                goto label_35;
              case 5:
                goto label_14;
              case 6:
                goto label_16;
              case 7:
                goto label_19;
              case 8:
                goto label_25;
              case 9:
              case 19:
                if (!canCreateNew)
                {
                  num2 = 8;
                  continue;
                }
                goto case 23;
              case 10:
                goto label_6;
              case 11:
                entityJsonSerializer.ConvertFromSerializable((object) entity, expItem);
                num2 = 10;
                continue;
              case 12:
                goto label_13;
              case 13:
                // ISSUE: reference to a compiler-generated method
                if (!expItem.TryGetValue((string) TablePartChangesModel.\u003C\u003Ec__DisplayClass47_0.D0f5YXCcl7fR41CQ7Mf5(1470998129 - 231418599 ^ 1239553048), out obj2))
                {
                  num2 = 9;
                  continue;
                }
                goto case 17;
              case 14:
                IEnumerable<IEntity> source = items.OfType<IEntity>();
                Func<IEntity, bool> func1 = func;
                Func<IEntity, bool> predicate = func1 == null ? (func = (Func<IEntity, bool>) (i => !i.Equals((object) entity))) : func1;
                if (source.All<IEntity>(predicate))
                  goto case 25;
                else
                  goto label_36;
              case 15:
              case 21:
                if (itemsByUid != null)
                {
                  num2 = 13;
                  continue;
                }
                goto case 9;
              case 16:
                goto label_11;
              case 17:
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if ((key = TablePartChangesModel.\u003C\u003Ec__DisplayClass47_0.gnlXXbCcgDWh87opucW0((object) Locator.GetServiceNotNull<GuidDescriptor>(), obj2, TablePartChangesModel.\u003C\u003Ec__DisplayClass47_0.QHwDZ8Ccrl0q9UcgsEiL(__typeref (Guid)))) != null)
                {
                  num2 = 7;
                  continue;
                }
                goto case 9;
              case 18:
                entity.SetId(obj1);
                num2 = 4;
                continue;
              case 20:
                if (!itemsById.TryGetValue(obj1, out entity))
                  goto case 15;
                else
                  goto label_5;
              case 22:
                if (entity == null)
                {
                  num2 = 6;
                  continue;
                }
                goto case 14;
              case 23:
                entity = (IEntity) entityJsonSerializer.ConvertFromSerializable(expItem, itemType);
                num2 = 22;
                continue;
              case 24:
                entityJsonSerializer.ConvertFromSerializable((object) entity, expItem);
                num2 = 18;
                continue;
              case 25:
                items.Add((object) entity);
                num2 = 12;
                continue;
              default:
                // ISSUE: reference to a compiler-generated method
                obj1 = TablePartChangesModel.\u003C\u003Ec__DisplayClass47_0.R0PMGICcd36Mc5whLA2r(itemType, idObj);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 2;
                continue;
            }
          }
label_5:
          num1 = 11;
          continue;
label_14:
          // ISSUE: reference to a compiler-generated method
          obj1 = TablePartChangesModel.\u003C\u003Ec__DisplayClass47_0.yo3DI8Cc52rm3eS01nmm((object) entity);
          num1 = 24;
          continue;
label_19:
          if (!itemsByUid.TryGetValue(key, out entity))
          {
            num1 = 19;
            continue;
          }
          goto label_14;
label_36:
          num1 = 16;
        }
label_35:
        return;
label_16:
        return;
label_25:
        return;
label_6:
        return;
label_13:
        return;
label_11:;
      }));
      return entity;
    }

    internal static bool u1Ei9khZQLsNgMj9y4MU() => TablePartChangesModel.zeIO6PhZf2fy1xxZoT96 == null;

    internal static TablePartChangesModel cO179EhZC5oEdTms5hIB() => TablePartChangesModel.zeIO6PhZf2fy1xxZoT96;

    internal static void mn84yfhZvo3ntpDjEj2B() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void ixsdJVhZ8pmr7GTNKW4I([In] object obj0, EntitySerializationMode value) => ((EntitySerializationSettings) obj0).Mode = value;

    internal static object DQ6Qu7hZZvB0iuEcFA6j([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object QY6WOphZuyYYiMxhle5w([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool UKUWAVhZIP0LSHjyMjk8([In] object obj0) => ((IEntity) obj0).IsDirty();

    internal static object Mroko9hZV2k6FxbC5Ya3([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void oZGWOVhZS8ULWGREWDbx([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object JVgsi8hZinOB3L1F3oba([In] object obj0, [In] object obj1) => (object) ((IOriginalCollectionExtension) obj0).OriginalItems(obj1);

    internal static bool VapOMMhZRAgQjVAOrt1v([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
