// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.Entity`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Settings.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Сущность с идентификатором</summary>
  /// <typeparam name="IdT">Тип идентификатора (первичного ключа)</typeparam>
  [Component(InjectProerties = false)]
  [DefaultManager(typeof (EntityManagerMaker))]
  [DataContract]
  [Serializable]
  public abstract class Entity<IdT> : 
    IEntity<IdT>,
    IEntity,
    IIdentified,
    IDynamicMetaObjectProvider,
    IEntityImplementorProvider
  {
    private static ConcurrentDictionary<string, List<PropertyInfo>> formatCache;
    private int? hashCode;
    [XmlIgnore]
    [NonSerialized]
    private Dictionary<Guid, TypeSettings> _loadedTypeSettings;
    private static object NvyMAlhuzeDfivaJhHGc;

    /// <summary>Ctor</summary>
    public Entity()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._loadedTypeSettings = new Dictionary<Guid, TypeSettings>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Идентификатор (первичный ключ)</summary>
    [DefaultValue(0)]
    [XmlElement("Id")]
    [DataMember]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_Entity), "P_Id_DisplayName")]
    public virtual IdT Id { get; set; }

    /// <summary>Тип, реализующий сущность.</summary>
    protected virtual Type EntityImplementorType => NHibernateProxyHelper.GuessClass((object) this);

    /// <summary>Тип, реализующий сущность.</summary>
    Type IEntityImplementorProvider.EntityImplementorType => this.EntityImplementorType;

    private IEntityManager Manager
    {
      get
      {
        int num = 3;
        Type entityType;
        while (true)
        {
          Type typeWithoutProxy;
          EntityMetadata entityMetadata;
          Type type;
          switch (num)
          {
            case 1:
              if (entityMetadata.Type == EntityMetadataType.InterfaceImplementation)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 6;
                continue;
              }
              goto label_6;
            case 2:
              entityMetadata = MetadataLoader.LoadMetadata(typeWithoutProxy) as EntityMetadata;
              num = 7;
              continue;
            case 3:
              typeWithoutProxy = this.GetType().GetTypeWithoutProxy();
              num = 2;
              continue;
            case 4:
              if (entityMetadata == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 5 : 5;
                continue;
              }
              goto case 1;
            case 6:
              type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.ImplementationUid);
              if ((object) type == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 8 : 7;
                continue;
              }
              break;
            case 7:
              entityType = typeWithoutProxy;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 4 : 3;
              continue;
            case 8:
              type = typeWithoutProxy;
              break;
            default:
              goto label_6;
          }
          entityType = type;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
        }
label_6:
        return ModelHelper.GetEntityManager(entityType);
      }
    }

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
            this.Manager.Save((object) this);
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
            this.Manager.Delete((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обновить сущность из БД</summary>
    public virtual void Refresh()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Refresh((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Сущность не сохранялась в базе</summary>
    /// <returns></returns>
    public virtual bool IsNew() => this.Manager.IsNew((object) this);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <returns>True, если есть</returns>
    public virtual bool IsDirty() => this.Manager.IsDirty((object) this);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <returns>Список идентификаторов свойств</returns>
    public virtual Guid[] GetDirtyPropertyUids() => this.Manager.GetDirtyPropertyUids((object) this);

    /// <summary>Получает не типизированный Id у сущности</summary>
    /// <returns></returns>
    public virtual object GetId() => (object) this.Id;

    /// <summary>Установить нетипизированное значение идентификатора</summary>
    /// <param name="id">Значение идентификатора</param>
    public virtual void SetId(object id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Id = (IdT) this.GetType().ConvertId(typeof (IdT), id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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
    /// Получить значение свойства по его уникальному идентификатору
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>Значение свойства</returns>
    public virtual object GetPropertyValue(Guid propertyUid) => this.GetPropertyInfo(propertyUid).GetValue((object) this, (object[]) null);

    /// <summary>
    /// Получить значение свойства по его уникальному идентификатору
    /// </summary>
    /// <typeparam name="T">Тип свойства</typeparam>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>Значение свойства</returns>
    public virtual T GetPropertyValue<T>(Guid propertyUid) => (T) this.GetPropertyValue(propertyUid);

    /// <summary>
    /// Установить значение свойства по его уникальному идентификатору
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="value">Значение свойства</param>
    public virtual void SetPropertyValue(Guid propertyUid, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetPropertyInfo(propertyUid).SetValue((object) this, value, (object[]) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
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
    /// Получить настройки свойства (возвращаются настройки для данного экземпляра сущности, либо копия общих)
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    public virtual TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings => (TSettings) this.GetPropertySettings(propertyUid);

    /// <summary>
    /// Получить настройки свойства (возвращаются настройки для данного экземпляра сущности, либо копия общих)
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    public virtual TypeSettings GetPropertySettings(Guid propertyUid) => this.GetPropertySettings(propertyUid, (TypeSettings) null);

    /// <summary>
    /// Получить настройки свойства (возвращаются настройки для данного экземпляра сущности, либо копия общих)
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="defaultSettings">Настройки по умолчанию</param>
    public virtual TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings)
    {
      int num1 = 6;
      bool lockTaken;
      TypeSettings propertySettings1;
      TypeSettings propertySettings2;
      Entity<IdT> entity;
      IPropertyMetadata propertyMetadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_34;
          case 2:
            propertyMetadata = this.GetPropertyMetadata(propertyUid);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 5 : 7;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_4;
          case 5:
            if (propertySettings1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 8 : 5;
              continue;
            }
            goto label_29;
          case 6:
            propertySettings1 = this.LoadPropertyInstanceSettings(propertyUid);
            num1 = 5;
            continue;
          case 7:
            if (propertyMetadata.Settings != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 9 : 1;
              continue;
            }
            goto label_34;
          case 8:
            if (defaultSettings == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 2;
              continue;
            }
            goto case 10;
          case 9:
            defaultSettings = propertyMetadata.Settings;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 10 : 2;
            continue;
          case 10:
            if (!this._loadedTypeSettings.TryGetValue(propertyUid, out propertySettings2))
            {
              entity = this;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 12;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 4;
            continue;
          case 11:
            goto label_29;
          case 12:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_4:
      return propertySettings2;
label_8:
      return propertySettings2;
label_10:
      TypeSettings propertySettings3;
      try
      {
        Monitor.Enter((object) entity, ref lockTaken);
        int num2 = 3;
        while (true)
        {
          int num3 = num2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_8;
              case 2:
                propertySettings2.BindToEntity((IEntity) this, propertyUid);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                continue;
              case 3:
                goto label_16;
              case 4:
                goto label_9;
              case 5:
                goto label_18;
              case 6:
              case 7:
                propertySettings2 = ClassSerializationHelper.CloneObjectByXml<TypeSettings>(defaultSettings);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 2;
                continue;
              default:
                this._loadedTypeSettings[propertyUid] = propertySettings2;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
                continue;
            }
          }
label_16:
          if (!this._loadedTypeSettings.TryGetValue(propertyUid, out propertySettings2))
          {
            num2 = 6;
            continue;
          }
label_18:
          propertySettings3 = propertySettings2;
          num2 = 4;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_25;
              default:
                Monitor.Exit((object) entity);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_25:;
      }
label_9:
      return propertySettings3;
label_29:
      return propertySettings1;
label_34:
      return (TypeSettings) null;
    }

    /// <summary>
    /// Получить настройки свойства, сохраненные для данного объекта. Если их нет - то возвращается null
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    public virtual TypeSettings LoadPropertyInstanceSettings(Guid propertyUid)
    {
      int num1 = 18;
      TypeSettings typeSettings;
      TypeSettingsInstanceData.DataItem dataItem;
      while (true)
      {
        int num2 = num1;
        ITypeSettingsInstanceStore settingsInstanceStore;
        TablePartMetadata tablePartMetadata;
        IEntity propertyValue;
        Guid propertyUid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              if (Locator.Initialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 13 : 10;
                continue;
              }
              goto label_15;
            case 3:
              dataItem.Settings.BindToEntity((IEntity) this, propertyUid1);
              num2 = 14;
              continue;
            case 4:
              if (settingsInstanceStore == null)
              {
                num2 = 16;
                continue;
              }
              goto case 20;
            case 5:
              if (tablePartMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 6 : 6;
                continue;
              }
              goto case 19;
            case 6:
              goto label_12;
            case 7:
              goto label_31;
            case 8:
              dataItem = settingsInstanceStore.Settings.Items.FirstOrDefault<TypeSettingsInstanceData.DataItem>((Func<TypeSettingsInstanceData.DataItem, bool>) (i => i.PropertyUid == propertyUid1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 21 : 21;
              continue;
            case 9:
              goto label_11;
            case 10:
              goto label_14;
            case 11:
              typeSettings = ClassSerializationHelper.CloneObjectByXml<TypeSettings>(typeSettings);
              num2 = 10;
              continue;
            case 12:
            case 16:
              tablePartMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.GetType()) as TablePartMetadata;
              num2 = 5;
              continue;
            case 13:
              settingsInstanceStore = TypeSettingsInstanceStoreManager.Instance.Load((IEntity) this, false, true);
              num2 = 4;
              continue;
            case 14:
              goto label_17;
            case 15:
              typeSettings = propertyValue.LoadPropertyInstanceSettings(propertyUid1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 7 : 6;
              continue;
            case 17:
              propertyUid1 = propertyUid;
              num2 = 2;
              continue;
            case 18:
              num2 = 17;
              continue;
            case 19:
              propertyValue = this.GetPropertyValue(tablePartMetadata.ParentPropertyUid) as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            case 20:
              if (settingsInstanceStore.Settings != null)
                goto case 8;
              else
                goto label_6;
            case 21:
              if (dataItem != null)
              {
                num2 = 22;
                continue;
              }
              goto case 12;
            case 22:
              if (dataItem.Settings != null)
              {
                num2 = 3;
                continue;
              }
              goto case 12;
            default:
              if (propertyValue != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 10 : 15;
                continue;
              }
              goto label_12;
          }
        }
label_6:
        num1 = 12;
        continue;
label_14:
        typeSettings.BindToEntity((IEntity) this, propertyUid1);
        num1 = 9;
        continue;
label_31:
        if (typeSettings != null)
          num1 = 11;
        else
          break;
      }
label_11:
      return typeSettings;
label_12:
      return (TypeSettings) null;
label_15:
      return (TypeSettings) null;
label_17:
      return dataItem.Settings;
    }

    /// <summary>Сохранить настройки свойства для данного объекта</summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="settings">Настройки</param>
    public virtual void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        ITypeSettingsInstanceStore settingsStore;
        while (true)
        {
          TypeSettingsInstanceData.DataItem dataItem;
          Guid propertyUid1;
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              if (settingsStore != null)
              {
                num2 = 8;
                continue;
              }
              goto label_6;
            case 3:
              settingsStore.Settings.Items.Add(dataItem);
              num2 = 15;
              continue;
            case 4:
              if (dataItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 7 : 2;
                continue;
              }
              break;
            case 5:
              if (Locator.Initialized)
              {
                num2 = 14;
                continue;
              }
              goto label_16;
            case 6:
              goto label_21;
            case 7:
            case 15:
              dataItem.Settings = settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 12 : 3;
              continue;
            case 8:
              dataItem = settingsStore.Settings.Items.FirstOrDefault<TypeSettingsInstanceData.DataItem>((Func<TypeSettingsInstanceData.DataItem, bool>) (i => i.PropertyUid == propertyUid1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 1;
              continue;
            case 9:
              propertyUid1 = propertyUid;
              num2 = 5;
              continue;
            case 10:
              num2 = 9;
              continue;
            case 11:
              goto label_5;
            case 12:
              goto label_20;
            case 13:
              settingsStore = TypeSettingsInstanceStoreManager.Instance.Load((IEntity) this, true, true);
              num2 = 2;
              continue;
            case 14:
              ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.GetType());
              num2 = 13;
              continue;
          }
          dataItem = new TypeSettingsInstanceData.DataItem()
          {
            PropertyUid = propertyUid1
          };
          num2 = 3;
        }
label_20:
        TypeSettingsInstanceStoreManager.Instance.Save((IEntity) this, settingsStore);
        num1 = 6;
      }
label_13:
      return;
label_21:
      return;
label_5:
      return;
label_16:
      return;
label_6:;
    }

    /// <summary>Загрузить хранилище настроек свойств даннного объекта</summary>
    /// <param name="createIfNotExists">Создавать ли хранилище, если оно не существует</param>
    /// <param name="loadIfNotLoaded">Загружать, если не были загружены</param>
    /// <returns></returns>
    public virtual ITypeSettingsInstanceStore LoadSettingsInstanceStore(
      bool createIfNotExists,
      bool loadIfNotLoaded)
    {
      return TypeSettingsInstanceStoreManager.Instance.Load((IEntity) this, createIfNotExists, loadIfNotLoaded);
    }

    /// <summary>
    /// Получить сущности, которые содержатся в данной сущности (например, элементы блока, настройки сущности)
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<IEntity> GetContainedEntities()
    {
      List<IEntity> containedEntities = new List<IEntity>();
      ITypeSettingsInstanceStore settingsInstanceStore = this.LoadSettingsInstanceStore(false, false);
      if (settingsInstanceStore != null)
        containedEntities.Add((IEntity) settingsInstanceStore);
      if (MetadataLoader.LoadMetadata(this.GetType()) is EntityMetadata entityMetadata)
      {
        foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
        {
          IEnumerable source1 = (IEnumerable) null;
          object propertyValue = this.GetPropertyValue(tablePart.TablePartPropertyUid);
          if (!(propertyValue is AbstractPersistentCollection persistentCollection) && propertyValue is IInheritedSet inheritedSet)
            persistentCollection = inheritedSet.GetSourceSet() as AbstractPersistentCollection;
          if (persistentCollection != null)
            source1 = persistentCollection.StoredSnapshot as IEnumerable;
          IEnumerable source2 = propertyValue as IEnumerable;
          containedEntities.AddRange(EleWise.ELMA.Extensions.EnumerableExtensions.CastOrNull<IEntity>(source2).EmptyIfNull<IEntity>().Union<IEntity>(EleWise.ELMA.Extensions.EnumerableExtensions.CastOrNull<IEntity>(source1).EmptyIfNull<IEntity>()).Where<IEntity>((Func<IEntity, bool>) (i => i != null)).SelectMany<IEntity, IEntity>((Func<IEntity, IEnumerable<IEntity>>) (i => ((IEnumerable<IEntity>) new IEntity[1]
          {
            i
          }).Concat<IEntity>(i.GetContainedEntities()))));
        }
      }
      return (IEnumerable<IEntity>) containedEntities;
    }

    /// <summary>
    /// Получить корневую сущность (если это элемент блока, то возвращается первый родитель)
    /// </summary>
    /// <returns></returns>
    public virtual IEntity GetRootEntity()
    {
      int num1 = 3;
      IEntity propertyValue;
      IEntity rootEntity;
      while (true)
      {
        int num2 = num1;
        TablePartMetadata tablePartMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              if (tablePartMetadata != null)
              {
                propertyValue = this.GetPropertyValue(tablePartMetadata.ParentPropertyUid) as IEntity;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 4;
                continue;
              }
              goto label_8;
            case 3:
              tablePartMetadata = MetadataLoader.LoadMetadata(this.GetType()) as TablePartMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 1;
              continue;
            case 4:
              if (propertyValue == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 5:
              goto label_9;
            default:
              rootEntity = (IEntity) this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
              continue;
          }
        }
label_8:
        num1 = 5;
      }
label_9:
      return (IEntity) this;
label_11:
      return rootEntity;
label_12:
      return propertyValue.GetRootEntity();
    }

    /// <summary>
    ///  Возвращает строковое представление объекта в указанном формате
    /// </summary>
    /// <param name="format">Формат отображения, свойства доступны через {$Имя свойства}</param>
    /// <returns>Строка представляющая сущность</returns>
    public virtual string ToString(string format)
    {
      int num1 = 1;
      string key;
      List<PropertyInfo> list;
      string fmt;
      Entity<IdT> entity;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 2:
          case 5:
            goto label_5;
          case 3:
            if (string.IsNullOrEmpty(format))
            {
              num1 = 6;
              continue;
            }
            fmt = format;
            num1 = 9;
            continue;
          case 4:
            Entity<IdT>.formatCache[key] = list;
            num1 = 5;
            continue;
          case 6:
            goto label_6;
          case 7:
            list = ((IEnumerable<PropertyInfo>) this.GetType().GetReflectionProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (propertyInfo => fmt.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536615278) + propertyInfo.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108655072)))).ToList<PropertyInfo>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 4;
            continue;
          case 8:
            if (Entity<IdT>.formatCache.TryGetValue(key, out list))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
              continue;
            }
            goto case 7;
          case 9:
            key = this.GetType().FullName + format;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 8 : 8;
            continue;
          default:
            entity = this;
            num1 = 3;
            continue;
        }
      }
label_5:
      return list.Aggregate<PropertyInfo, string>(format, (Func<string, PropertyInfo, string>) ((current, propertyInfo) =>
      {
        int num2 = 1;
        object obj;
        while (true)
        {
          switch (num2)
          {
            case 1:
              obj = propertyInfo.GetValue((object) entity, (object[]) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return current.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210603321) + propertyInfo.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306450612), obj == null ? string.Empty : obj.ToString());
      }));
label_6:
      return string.Empty;
    }

    /// <summary>Возвращает строковое представление объекта</summary>
    /// <returns>Строковое предсталвение объекта</returns>
    public override string ToString()
    {
      int num = 3;
      ClassMetadata classMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (classMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            classMetadata = MetadataLoader.LoadMetadata(this.GetType()) as ClassMetadata;
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return base.ToString();
label_6:
      return this.ToString(classMetadata.DisplayFormat);
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        IdT id;
        IEntity<IdT> entity;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!id.Equals((object) default (IdT)))
              {
                num2 = 5;
                continue;
              }
              goto label_14;
            case 2:
              goto label_16;
            case 3:
              if (this == obj)
              {
                num2 = 2;
                continue;
              }
              goto label_17;
            case 4:
              id = this.Id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
              continue;
            case 5:
              id = this.Id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 6:
              if ((object) this.Id == null)
              {
                num2 = 8;
                continue;
              }
              goto case 4;
            case 7:
            case 8:
              goto label_14;
            case 9:
              if (entity != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 6 : 4;
                continue;
              }
              goto label_14;
            default:
              goto label_12;
          }
        }
label_12:
        if (!id.Equals((object) entity.Id))
        {
          num1 = 7;
          continue;
        }
        goto label_15;
label_17:
        entity = obj as IEntity<IdT>;
        num1 = 9;
      }
label_14:
      return false;
label_15:
      return this.TypeAssignable(obj);
label_16:
      return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.hashCode.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            this.hashCode = new int?((object) this.Id == null || this.Id.Equals((object) default (IdT)) ? base.GetHashCode() : this.Id.GetHashCode());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return this.hashCode.Value;
    }

    /// <summary>
    /// Получить метаданные свойства по уникальному идентификатору свойства
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>Метаданные свойства</returns>
    protected virtual IPropertyMetadata GetPropertyMetadata(Guid propertyUid)
    {
      IPropertyMetadata propertyMetadata = this.TryGetPropertyMetadata(propertyUid);
      if (propertyMetadata != null)
        return propertyMetadata;
      ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.GetType());
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542794621)), (object) propertyUid, (object) classMetadata.FullTypeName));
    }

    /// <summary>
    /// Получить метаданные свойства по уникальному идентификатору свойства
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>Метаданные свойства</returns>
    protected virtual IPropertyMetadata TryGetPropertyMetadata(Guid propertyUid)
    {
      int num1 = 8;
      IPropertyMetadata propertyMetadata;
      while (true)
      {
        int num2 = num1;
        IEntityMetadata entityMetadata;
        while (true)
        {
          ClassMetadata classMetadata;
          Guid propertyUid1;
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
            case 9:
              goto label_5;
            case 3:
              propertyMetadata = (IPropertyMetadata) classMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == propertyUid1));
              num2 = 10;
              continue;
            case 4:
              goto label_10;
            case 5:
              if (classMetadata != null)
              {
                num2 = 3;
                continue;
              }
              goto label_12;
            case 6:
              classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.GetType());
              num2 = 5;
              continue;
            case 7:
              propertyUid1 = propertyUid;
              num2 = 6;
              continue;
            case 8:
              num2 = 7;
              continue;
            case 10:
              if (propertyMetadata != null)
              {
                num2 = 2;
                continue;
              }
              break;
            case 11:
              propertyMetadata = (IPropertyMetadata) entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault<ITablePartMetadata>((Func<ITablePartMetadata, bool>) (tp => tp.TablePartPropertyUid == propertyUid1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 9 : 6;
              continue;
          }
          entityMetadata = classMetadata as IEntityMetadata;
          num2 = 4;
        }
label_10:
        if (entityMetadata != null)
          num1 = 11;
        else
          break;
      }
label_5:
      return propertyMetadata;
label_12:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825312710)), (object) this.GetType().FullName));
    }

    /// <summary>
    /// Получить PropertyInfo по уникальному идентификатору свойства
    /// </summary>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>PropertyInfo</returns>
    protected virtual PropertyInfo GetPropertyInfo(Guid propertyUid)
    {
      int num = 2;
      ClassMetadata classMetadata;
      IPropertyMetadata propertyMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            propertyMetadata = this.GetPropertyMetadata(propertyUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      PropertyInfo reflectionProperty = this.GetType().GetReflectionProperty(propertyMetadata.Name);
      return !(reflectionProperty == (PropertyInfo) null) ? reflectionProperty : throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1920998477)), (object) propertyMetadata.Name, (object) classMetadata.FullTypeName));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool TypeAssignable([NotNull] object obj)
    {
      int num = 4;
      Type c1;
      Type c2;
      while (true)
      {
        Type type1;
        Type type2;
        switch (num)
        {
          case 1:
            type1 = obj.GetType().BaseType;
            goto label_17;
          case 2:
            if (c1 == c2)
            {
              num = 6;
              continue;
            }
            goto case 7;
          case 3:
            type2 = this.GetType().BaseType;
            break;
          case 4:
            if (this is INHibernateProxy)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 5:
            type2 = this.GetType();
            break;
          case 6:
            goto label_9;
          case 7:
            if (!c2.IsAssignableFrom(c1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 9 : 1;
              continue;
            }
            goto label_9;
          case 8:
            if (obj is INHibernateProxy)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
              continue;
            }
            goto default;
          case 9:
            goto label_8;
          default:
            type1 = obj.GetType();
            goto label_17;
        }
        c1 = type2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 7 : 8;
        continue;
label_17:
        c2 = type1;
        num = 2;
      }
label_8:
      return c1.IsAssignableFrom(c2);
label_9:
      return true;
    }

    DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) => (DynamicMetaObject) new Entity<IdT>.ReflectionDynamicMetaObject(parameter, (object) this);

    static Entity()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            Entity<IdT>.formatCache = new ConcurrentDictionary<string, List<PropertyInfo>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool tdCLwXhIFYTeQrNan3ip() => Entity<IdT>.NvyMAlhuzeDfivaJhHGc == null;

    internal static object OrrwTlhIBvmX4OvJE4Qs() => Entity<IdT>.NvyMAlhuzeDfivaJhHGc;

    internal class ReflectionDynamicMetaObject : DynamicMetaObject
    {
      private static object ONG1iHCzxiSDcVrQljl2;

      public ReflectionDynamicMetaObject(Expression parameter, object value)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(parameter, BindingRestrictions.GetTypeRestriction(parameter, value.GetType()), value);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
      {
        int num = 1;
        PropertyInfo property;
        while (true)
        {
          switch (num)
          {
            case 1:
              property = this.LimitType.GetProperty(binder.Name);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              if (property == (PropertyInfo) null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        return base.BindGetMember(binder);
label_5:
        return new DynamicMetaObject((Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Convert(this.Expression, this.LimitType), property), binder.ReturnType), BindingRestrictions.GetTypeRestriction(this.Expression, this.LimitType));
      }

      public override DynamicMetaObject BindSetMember(
        SetMemberBinder binder,
        DynamicMetaObject value)
      {
        int num = 1;
        PropertyInfo property;
        while (true)
        {
          switch (num)
          {
            case 1:
              property = this.LimitType.GetProperty(binder.Name);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_6;
            default:
              if (!(property == (PropertyInfo) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 1;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        return base.BindSetMember(binder, value);
label_6:
        return new DynamicMetaObject((Expression) Expression.Convert((Expression) Expression.Assign((Expression) Expression.Property((Expression) Expression.Convert(this.Expression, this.LimitType), property), value.Expression), binder.ReturnType), BindingRestrictions.GetTypeRestriction(this.Expression, this.LimitType));
      }

      public override DynamicMetaObject BindInvokeMember(
        InvokeMemberBinder binder,
        DynamicMetaObject[] args)
      {
        int num = 8;
        Expression[] array;
        Expression expression;
        MethodInfo method;
        Expression[] expressionArray;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 3:
            case 5:
              expressionArray = new Expression[3]
              {
                (Expression) Expression.Convert(this.Expression, this.LimitType),
                (Expression) Expression.Constant((object) binder.Name),
                expression
              };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
              continue;
            case 4:
              if (array.Length != 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 6:
              expression = (Expression) Expression.Convert((Expression) Expression.Constant((object) null), typeof (object[]));
              num = 5;
              continue;
            case 7:
              DynamicMetaObject[] source = args;
              // ISSUE: reference to a compiler-generated field
              Func<DynamicMetaObject, Expression> func = Entity<IdT>.ReflectionDynamicMetaObject.\u003C\u003Ec.\u003C\u003E9__3_0;
              Func<DynamicMetaObject, Expression> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                Entity<IdT>.ReflectionDynamicMetaObject.\u003C\u003Ec.\u003C\u003E9__3_0 = selector = (Func<DynamicMetaObject, Expression>) (a => a.Expression);
              }
              else
                goto label_12;
label_11:
              array = ((IEnumerable<DynamicMetaObject>) source).Select<DynamicMetaObject, Expression>(selector).ToArray<Expression>();
              num = 4;
              continue;
label_12:
              selector = func;
              goto label_11;
            case 8:
              method = typeof (ObjectExtensions).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309396558), BindingFlags.Static | BindingFlags.Public);
              num = 7;
              continue;
            default:
              expression = (Expression) Expression.NewArrayInit(typeof (object), array);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 3 : 2;
              continue;
          }
        }
label_6:
        return new DynamicMetaObject((Expression) Expression.Call(method, expressionArray), BindingRestrictions.GetTypeRestriction(this.Expression, this.LimitType));
      }

      internal static bool IlVLvNCz0p6nbtV1xf4Y() => Entity<IdT>.ReflectionDynamicMetaObject.ONG1iHCzxiSDcVrQljl2 == null;

      internal static object rJN857CzmAL78U6VGpY3() => Entity<IdT>.ReflectionDynamicMetaObject.ONG1iHCzxiSDcVrQljl2;
    }
  }
}
