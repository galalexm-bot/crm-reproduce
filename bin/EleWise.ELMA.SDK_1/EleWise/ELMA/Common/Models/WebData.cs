// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.WebData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Класс для передачи данных через веб-сервисы</summary>
  [KnownType(typeof (WebDataItem))]
  [KnownType(typeof (EleWise.ELMA.Common.Models.API.WebData))]
  [KnownType(typeof (EleWise.ELMA.Common.Models.API.WebData[]))]
  [DataContract]
  [Serializable]
  public class WebData
  {
    private WebDataItem[] items;
    protected string _value;
    private static readonly string IdPropertyName;
    private static readonly string TypeUidPropertyName;
    private static readonly string IsDeletedPropertyName;
    internal static WebData No7KBtfihovppoO8ZLS1;

    /// <summary>Ctor</summary>
    public WebData()
    {
      WebData.BxAqgMfif0FqbsKHpf4c();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="dicObj">Список значений</param>
    public WebData(IEnumerable<KeyValuePair<string, object>> dicObj)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector((ICollection<KeyValuePair<string, object>>) dicObj.ToArray<KeyValuePair<string, object>>());
    }

    /// <summary>Ctor</summary>
    /// <param name="dicObj">Словарь</param>
    public WebData(IDictionary<string, object> dicObj)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector((ICollection<KeyValuePair<string, object>>) dicObj);
    }

    /// <summary>Ctor</summary>
    /// <param name="dicObj">Список значений</param>
    public WebData(ICollection<KeyValuePair<string, object>> dicObj)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      WebDataItem[] webDataItemArray = new WebDataItem[dicObj.Count];
      int index1 = 0;
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) dicObj)
      {
        if (keyValuePair.Value is WebData)
          webDataItemArray[index1] = new WebDataItem()
          {
            Name = keyValuePair.Key,
            Data = (WebData) keyValuePair.Value
          };
        else if (keyValuePair.Value is SerializableDictionary<string, object>)
          webDataItemArray[index1] = new WebDataItem()
          {
            Name = keyValuePair.Key,
            Data = new WebData((ICollection<KeyValuePair<string, object>>) keyValuePair.Value)
          };
        else if (keyValuePair.Value is SerializableList<object> serializableList)
        {
          WebData[] webDataArray = new WebData[serializableList.Count];
          for (int index2 = 0; index2 < serializableList.Count; ++index2)
          {
            object obj = serializableList[index2];
            switch (obj)
            {
              case null:
                webDataArray[index2] = (WebData) null;
                break;
              case ICollection<KeyValuePair<string, object>> dicObj1:
                webDataArray[index2] = new WebData(dicObj1);
                break;
              case WebData webData1:
                webDataArray[index2] = webData1;
                break;
              default:
                Type type = obj.GetType();
                if (type == typeof (string) || type.IsPrimitive || type.IsValueType)
                {
                  WebData webData = new WebData()
                  {
                    Value = obj.ToString()
                  };
                  webDataArray[index2] = webData;
                  break;
                }
                break;
            }
          }
          webDataItemArray[index1] = new WebDataItem()
          {
            Name = keyValuePair.Key,
            DataArray = webDataArray
          };
        }
        else if (keyValuePair.Value == null)
        {
          webDataItemArray[index1] = new WebDataItem()
          {
            Name = keyValuePair.Key,
            Value = (string) null
          };
        }
        else
        {
          TypeConverter converter = ElmaTypeDescriptorHelper.GetConverter(keyValuePair.Value.GetType());
          if (converter != null && converter.CanConvertTo(typeof (string)))
            webDataItemArray[index1] = new WebDataItem()
            {
              Name = keyValuePair.Key,
              Value = converter.ConvertToInvariantString(keyValuePair.Value)
            };
          else
            webDataItemArray[index1] = new WebDataItem()
            {
              Name = keyValuePair.Key,
              Value = keyValuePair.Value.ToString()
            };
        }
        ++index1;
      }
      this.items = webDataItemArray;
    }

    [Obsolete("Метод устарел", true)]
    public static WebData CreateFromEntity(
      IEntity entity,
      Func<PropertyMetadata, bool> propertyFilter,
      Func<TablePartMetadata, bool> tablePartFilter)
    {
      return WebData.CreateFromEntity(entity, propertyFilter, (Func<ITablePartMetadata, bool>) (m => tablePartFilter((TablePartMetadata) m)));
    }

    [Obsolete("Метод устарел", true)]
    public static WebData CreateFromEntity(
      IEntity entity,
      EntitySerializationSettings settings,
      Func<PropertyMetadata, bool> propertyFilter,
      Func<TablePartMetadata, bool> tablePartFilter)
    {
      return WebData.CreateFromEntity(entity, settings, propertyFilter, (Func<ITablePartMetadata, bool>) (m => tablePartFilter((TablePartMetadata) m)));
    }

    /// <summary>Создать данные для web из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="propertyFilter">Фильтр свойств</param>
    /// <param name="tablePartFilter">Фильтр табличных данных</param>
    public static WebData CreateFromEntity(
      IEntity entity,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      IDictionary<string, object> dicObj = WebData.DictionaryFromEntity(entity, propertyFilter, tablePartFilter);
      return dicObj == null ? (WebData) null : new WebData(dicObj);
    }

    /// <summary>Создать данные для web из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="settings">Настройки сущности</param>
    /// <param name="propertyFilter">Фильтр свойств</param>
    /// <param name="tablePartFilter">Фильтр табличных данных</param>
    public static WebData CreateFromEntity(
      IEntity entity,
      EntitySerializationSettings settings,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      IDictionary<string, object> dicObj = WebData.DictionaryFromEntity(entity, settings, propertyFilter, tablePartFilter);
      return dicObj == null ? (WebData) null : new WebData(dicObj);
    }

    /// <summary>
    /// Сформировать из сущности данные для передачи через веб-сервисы
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="loadDisplayName">Загружать ли отдельным параметром отображаемое имя</param>
    /// <returns></returns>
    public static WebData CreateFromEntity(IEntity entity, bool loadDisplayName) => (WebData) WebData.z3vDUafiQhPixNWNIqbE((object) entity, (object) null, loadDisplayName);

    /// <summary>
    /// Сформировать из сущности данные для передачи через веб-сервисы
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="settings">Настройки сериализации</param>
    /// <param name="loadDisplayName">Загружать ли отдельным параметром отображаемое имя</param>
    /// <returns></returns>
    internal static WebData CreateFromEntity(
      IEntity entity,
      EntitySerializationSettings settings,
      bool loadDisplayName)
    {
      int num1 = 2;
      WebData fromEntity;
      while (true)
      {
        int num2 = num1;
        List<WebDataItem> list;
        WebDataItem webDataItem1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!loadDisplayName)
              {
                num2 = 6;
                continue;
              }
              goto label_3;
            case 2:
              fromEntity = WebData.CreateFromEntity(entity, settings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_3;
            case 4:
            case 6:
              goto label_4;
            case 5:
              fromEntity.Items = (WebDataItem[]) WebData.q7rp1bfiZd2pSP7yTc9S((object) list);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 4 : 3;
              continue;
            case 7:
              WebDataItem webDataItem2 = new WebDataItem();
              WebData.GPc4oJfi8SyZJ0HoPtsC((object) webDataItem2, WebData.GQGDLIfiveaM7tkxB92K((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675685509), WebData.tSQ3YEfiCOvQ1MxCSpJI((object) entity.GetType())));
              webDataItem2.Value = entity.GetTitleOrDefault<IEntity>();
              webDataItem1 = webDataItem2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            default:
              list.AddIfNotContains<WebDataItem>(webDataItem1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 3 : 5;
              continue;
          }
        }
label_3:
        list = ((IEnumerable<WebDataItem>) fromEntity.Items).ToList<WebDataItem>();
        num1 = 7;
      }
label_4:
      return fromEntity;
    }

    public static WebData CreateFromObject(object data)
    {
      int num1 = 5;
      IEnumerator<KeyValuePair<string, object>> enumerator;
      Dictionary<string, object> dicObj;
      while (true)
      {
        int num2 = num1;
        IEnumerable<KeyValuePair<string, object>> serializable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              goto label_23;
            case 3:
              serializable = new EntityJsonSerializer().ConvertToSerializable(data) as IEnumerable<KeyValuePair<string, object>>;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_7;
            case 5:
              if (data == null)
              {
                num2 = 4;
                continue;
              }
              goto label_8;
            case 6:
              goto label_3;
            case 7:
              enumerator = serializable.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
              continue;
            default:
              if (serializable != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 7 : 5;
                continue;
              }
              goto label_3;
          }
        }
label_8:
        dicObj = new Dictionary<string, object>();
        num1 = 3;
      }
label_3:
      return (WebData) null;
label_7:
      return (WebData) null;
label_11:
      try
      {
label_14:
        if (WebData.qUNeWKfiuDJ52wa2nhAC((object) enumerator))
          goto label_16;
        else
          goto label_15;
label_12:
        KeyValuePair<string, object> current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_14;
            case 2:
              dicObj.Add(current.Key, current.Value);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_16;
            default:
              goto label_23;
          }
        }
label_15:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
        goto label_12;
label_16:
        current = enumerator.Current;
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        {
          num3 = 2;
          goto label_12;
        }
        else
          goto label_12;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
        else
          goto label_21;
label_20:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_21:
        WebData.JyG2ZNfiIDt0NL2kvA7e((object) enumerator);
        num4 = 2;
        goto label_20;
      }
label_23:
      return new WebData((IDictionary<string, object>) dicObj);
    }

    public static WebData CreateFromObject(object data, EntitySerializationSettings settings)
    {
      int num1 = 7;
      IEnumerator<KeyValuePair<string, object>> enumerator;
      Dictionary<string, object> dicObj;
      while (true)
      {
        int num2 = num1;
        IEnumerable<KeyValuePair<string, object>> serializable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              enumerator = serializable.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            case 3:
              if (serializable != null)
              {
                num2 = 2;
                continue;
              }
              goto label_7;
            case 4:
              goto label_10;
            case 5:
              goto label_7;
            case 6:
              dicObj = new Dictionary<string, object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
              continue;
            case 7:
              if (data != null)
              {
                num2 = 6;
                continue;
              }
              goto label_10;
            case 8:
              goto label_26;
            default:
              goto label_12;
          }
        }
label_9:
        serializable = new EntityJsonSerializer().ConvertToSerializable(data, settings) as IEnumerable<KeyValuePair<string, object>>;
        num1 = 3;
      }
label_7:
      return (WebData) null;
label_10:
      return (WebData) null;
label_12:
      try
      {
label_18:
        if (enumerator.MoveNext())
          goto label_16;
        else
          goto label_19;
label_14:
        KeyValuePair<string, object> current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              dicObj.Add(current.Key, current.Value);
              num3 = 2;
              continue;
            case 2:
              goto label_18;
            case 3:
              goto label_26;
            default:
              goto label_16;
          }
        }
label_16:
        current = enumerator.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        {
          num3 = 1;
          goto label_14;
        }
        else
          goto label_14;
label_19:
        num3 = 3;
        goto label_14;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = 2;
        else
          goto label_23;
label_22:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_23:
        WebData.JyG2ZNfiIDt0NL2kvA7e((object) enumerator);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        {
          num4 = 0;
          goto label_22;
        }
        else
          goto label_22;
      }
label_26:
      return new WebData((IDictionary<string, object>) dicObj);
    }

    public static WebData CreateForDeleted(Guid typeUid, Guid objectUid, object objectId = null)
    {
      int num = 6;
      Dictionary<string, object> dicObj;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            dicObj.Add(WebData.IdPropertyName, objectId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          case 3:
            dicObj.Add(WebData.TypeUidPropertyName, (object) typeUid);
            num = 4;
            continue;
          case 4:
            dicObj.Add(WebData.IsDeletedPropertyName, (object) true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
            continue;
          case 5:
            if (objectId != null)
            {
              num = 2;
              continue;
            }
            break;
          case 6:
            dicObj = new Dictionary<string, object>();
            num = 5;
            continue;
        }
        dicObj.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712505381), (object) objectUid);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 3;
      }
label_6:
      return new WebData((IDictionary<string, object>) dicObj);
    }

    /// <summary>Элементы данных</summary>
    [DataMember]
    public virtual WebDataItem[] Items
    {
      get => this.items;
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
              this.items = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    public bool HasValue => !WebData.wtaKpGfiVaVq9I1J0jYr((object) this._value);

    [DataMember]
    public virtual string Value
    {
      get => this._value;
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
              this._value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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

    /// <summary>Найти элемент данных по имени</summary>
    /// <param name="name">Имя элемент данных</param>
    /// <returns>Элемент данных. Если не найден - null.</returns>
    public virtual WebDataItem FindItem(string name)
    {
      int num = 1;
      string name1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            if (this.items == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 2;
              continue;
            }
            goto label_7;
          default:
            name1 = name;
            num = 3;
            continue;
        }
      }
label_6:
      return (WebDataItem) null;
label_7:
      return ((IEnumerable<WebDataItem>) this.items).FirstOrDefault<WebDataItem>((Func<WebDataItem, bool>) (i => i.Name == name1));
    }

    /// <summary>Найти элемент данных по имени</summary>
    /// <param name="path">Имя элемент данных</param>
    /// <returns>Элемент данных. Если не найден - null.</returns>
    public virtual WebData FindByPath([NotNull] string path)
    {
      int num1 = 19;
      WebData byPath;
      while (true)
      {
        int num2 = num1;
        string name;
        int num3;
        int num4;
        string s;
        long result;
        List<string> list;
        WebDataItem webDataItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              name = (string) WebData.EZ84qdfiKdURYq8WMfj3((object) name, num3);
              num2 = 5;
              continue;
            case 2:
              name = list[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 4 : 13;
              continue;
            case 3:
              byPath = webDataItem.DataArray[result];
              num2 = 4;
              continue;
            case 4:
            case 20:
              if (WebData.tSaGBofiTXySGICC1dbE((object) list) > 0)
                goto case 12;
              else
                goto label_26;
            case 5:
            case 7:
              webDataItem = this.FindItem(name);
              num2 = 6;
              continue;
            case 6:
              if (WebData.wtaKpGfiVaVq9I1J0jYr((object) s))
                goto case 10;
              else
                goto label_18;
            case 8:
              num4 = WebData.owMstTfiqFBVPsG4YKqQ((object) name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195567619), StringComparison.InvariantCultureIgnoreCase);
              num2 = 9;
              continue;
            case 9:
              s = name.Substring(num3 + 1, num4 - 1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
              continue;
            case 10:
              byPath = (WebData) WebData.DeAnBjfiXKuNRN6AdYD8((object) webDataItem);
              num2 = 20;
              continue;
            case 11:
              if (long.TryParse(s, out result))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 3 : 2;
                continue;
              }
              goto case 10;
            case 12:
              byPath = byPath.FindByPath(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867197103), (IEnumerable<string>) list));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 13:
              list.Remove(name);
              num2 = 16;
              continue;
            case 15:
              num3 = WebData.mKUDYgfiRcn9nhA9iyO5((object) name, WebData.qxlG8mfiiCJTBAP0lRSQ(1253244298 - 1829393894 ^ -576171706), StringComparison.InvariantCultureIgnoreCase);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 8;
              continue;
            case 16:
              s = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 17 : 10;
              continue;
            case 17:
              if (name.IndexOf((string) WebData.qxlG8mfiiCJTBAP0lRSQ(322893104 - -1992822529 ^ -1979190573), StringComparison.InvariantCultureIgnoreCase) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 7;
                continue;
              }
              goto case 15;
            case 18:
              goto label_15;
            case 19:
              if (WebData.wtaKpGfiVaVq9I1J0jYr((object) path))
              {
                num2 = 18;
                continue;
              }
              goto label_16;
            default:
              goto label_19;
          }
        }
label_16:
        list = ((IEnumerable<string>) WebData.UC7Z9BfiS70ACbQgOYW2((object) path, (object) new char[1]
        {
          '.'
        }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
        num1 = 2;
        continue;
label_18:
        num1 = 11;
        continue;
label_26:
        num1 = 14;
      }
label_15:
      return this;
label_19:
      return byPath;
    }

    /// <summary>Преобразовать в словарь</summary>
    /// <returns></returns>
    public virtual IDictionary<string, object> ToDictionary()
    {
      SerializableDictionary<string, object> dictionary = new SerializableDictionary<string, object>();
      if (this.HasValue)
        dictionary.Add("", (object) this.Value);
      else if (this.Items != null)
      {
        foreach (WebDataItem webDataItem in this.Items)
        {
          object obj = (object) null;
          if (webDataItem.Data != null)
            obj = (object) webDataItem.Data.ToDictionary();
          else if (webDataItem.DataArray != null && webDataItem.DataArray.Length != 0)
          {
            obj = (object) new SerializableList<object>();
            if (((IEnumerable<WebData>) webDataItem.DataArray).All<WebData>((Func<WebData, bool>) (d => d.HasValue)))
            {
              // ISSUE: reference to a compiler-generated method
              ((List<object>) obj).AddRange((IEnumerable<object>) ((IEnumerable<WebData>) webDataItem.DataArray).Select<WebData, string>((Func<WebData, string>) (d => (string) WebData.\u003C\u003Ec.XsBqJW8jkBnKgJ7uHi2S((object) d))));
            }
            else
              ((List<object>) obj).AddRange((IEnumerable<object>) ((IEnumerable<WebData>) webDataItem.DataArray).Select<WebData, IDictionary<string, object>>((Func<WebData, IDictionary<string, object>>) (y => y.ToDictionary())));
          }
          else if (webDataItem.Value != null)
            obj = (object) webDataItem.Value;
          dictionary.Add(webDataItem.Name, obj);
        }
      }
      return (IDictionary<string, object>) dictionary;
    }

    /// <summary>Преобразовать в список ключ-значение</summary>
    /// <returns></returns>
    public virtual IEnumerable<KeyValuePair<string, object>> ToKeyValueList() => (IEnumerable<KeyValuePair<string, object>>) new WebData.\u003CToKeyValueList\u003Ed__24(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Сохранить значения из данного объекта в объект (сущность)
    /// </summary>
    /// <param name="target">Объект, в который записываются данные</param>
    public virtual void SaveToEntity(object target)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebData.jpkNsGfike7xiWkObb3r((object) this, target, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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
    /// Сохранить значения из данного объекта в объект (сущность)
    /// </summary>
    /// <param name="target">Объект, в который записываются данные</param>
    /// <param name="ignoreNullDescriptor">Пропускать  свойства, дескрипторов для которых не существует</param>
    public virtual void SaveToEntity(object target, bool ignoreNullDescriptor)
    {
      int num1 = 8;
      ClassMetadata metadata;
      IMetadataService metadataService;
      List<PropertyMetadata>.Enumerator enumerator;
      IDictionary<string, object> dictionary;
      while (true)
      {
        int num2 = num1;
        IEntity entity;
        while (true)
        {
          switch (num2)
          {
            case 1:
              new EntityJsonSerializer().ConvertFromSerializable((object) entity, dictionary);
              num2 = 4;
              continue;
            case 2:
              dictionary = this.ToDictionary();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 5;
              continue;
            case 3:
              if (entity == null)
              {
                List<PropertyMetadata> properties = metadata.Properties;
                metadataService = (IMetadataService) WebData.Erv6fjfinC6BKJ6gBEmP();
                enumerator = properties.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
              continue;
            case 4:
              goto label_36;
            case 5:
              entity = target as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 3;
              continue;
            case 6:
              goto label_3;
            case 7:
              goto label_5;
            case 8:
              if (target == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 7 : 7;
                continue;
              }
              goto label_8;
            case 9:
              goto label_7;
            case 10:
              if (metadata != null)
              {
                num2 = 2;
                continue;
              }
              goto label_30;
            default:
              goto label_9;
          }
        }
label_8:
        metadata = MetadataLoader.LoadMetadata(target.GetType()) as ClassMetadata;
        num1 = 10;
      }
label_36:
      return;
label_3:
      return;
label_5:
      return;
label_7:
      return;
label_9:
      try
      {
label_21:
        if (enumerator.MoveNext())
          goto label_14;
        else
          goto label_22;
label_11:
        PropertyMetadata current;
        ITypeDescriptor typeDescriptor;
        ISerializableTypeDescriptor serializableTypeDescriptor;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 3:
              goto label_21;
            case 2:
              serializableTypeDescriptor.Deserialize(target, metadata, current, dictionary);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
            case 4:
              if (ignoreNullDescriptor)
              {
                num3 = 3;
                continue;
              }
              goto label_12;
            case 5:
              goto label_14;
            case 6:
              if (serializableTypeDescriptor != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 1;
                continue;
              }
              goto label_21;
            case 7:
              if (typeDescriptor != null)
              {
                num3 = 8;
                continue;
              }
              goto case 4;
            case 8:
              serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
              num3 = 6;
              continue;
            case 9:
              goto label_12;
            case 10:
              goto label_26;
            default:
              typeDescriptor = (ITypeDescriptor) WebData.HYMId0fi2o3n731C8WXk((object) metadataService, WebData.WGKCY0fiOFcEEyvEWDXd((object) current), current.SubTypeUid);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 7;
              continue;
          }
        }
label_26:
        return;
label_12:
        throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T((string) WebData.qxlG8mfiiCJTBAP0lRSQ(-1317790512 ^ -1317705152), (object) WebData.WGKCY0fiOFcEEyvEWDXd((object) current)));
label_14:
        current = enumerator.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
label_22:
        num3 = 10;
        goto label_11;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_30:;
    }

    public override string ToString()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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
      return (string) WebData.t1TJkqfi1LyEsvLdwUok(WebData.qxlG8mfiiCJTBAP0lRSQ(-680446928 - -370807692 ^ -309638080), this.items != null ? (object) ((string) WebData.pQV6p9fiefsba88c6Skn() + string.Join((string) WebData.r3vUlGfiP0PJIODUvJJI(WebData.qxlG8mfiiCJTBAP0lRSQ(381945751 ^ 1158627804 ^ 1405818043), WebData.pQV6p9fiefsba88c6Skn()), ((IEnumerable<WebDataItem>) this.items).Select<WebDataItem, string>((Func<WebDataItem, string>) (i => i.ToString()))) + (string) WebData.pQV6p9fiefsba88c6Skn()) : (object) (string) null, WebData.qxlG8mfiiCJTBAP0lRSQ(--1418440330 ^ 1418437274));
label_5:
      return (string) WebData.qxlG8mfiiCJTBAP0lRSQ(~-306453669 ^ 306273874) + this._value + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309759962);
    }

    /// <summary>Словарь из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="propertyFilter">Фильтр свойства</param>
    /// <param name="tablePartFilter">Фильтр блока</param>
    /// <returns>Словарь</returns>
    internal static IDictionary<string, object> DictionaryFromEntity(
      IEntity entity,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      if (entity == null)
        return (IDictionary<string, object>) null;
      ClassMetadata classMetadata = MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType()) as ClassMetadata;
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (classMetadata != null)
      {
        if (!(new EntityJsonSerializer()
        {
          PropertyFilter = propertyFilter,
          NeedBindTablePart = tablePartFilter
        }.ConvertToSerializable((object) entity) is IEnumerable<KeyValuePair<string, object>> serializable))
          return (IDictionary<string, object>) null;
        foreach (KeyValuePair<string, object> keyValuePair in serializable)
          dictionary.Add(keyValuePair.Key, keyValuePair.Value);
      }
      return (IDictionary<string, object>) dictionary;
    }

    /// <summary>Словарь из сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="settings">Настройки сериализации</param>
    /// <param name="propertyFilter">Фильтр свойства</param>
    /// <param name="tablePartFilter">Фильтр блока</param>
    /// <returns>Словарь</returns>
    internal static IDictionary<string, object> DictionaryFromEntity(
      IEntity entity,
      EntitySerializationSettings settings,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      if (entity == null)
        return (IDictionary<string, object>) null;
      ClassMetadata classMetadata = MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType()) as ClassMetadata;
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (classMetadata != null)
      {
        if (!(new EntityJsonSerializer()
        {
          PropertyFilter = propertyFilter,
          NeedBindTablePart = tablePartFilter
        }.ConvertToSerializable((object) entity, settings) is IEnumerable<KeyValuePair<string, object>> serializable))
          return (IDictionary<string, object>) null;
        foreach (KeyValuePair<string, object> keyValuePair in serializable)
          dictionary.Add(keyValuePair.Key, keyValuePair.Value);
      }
      return (IDictionary<string, object>) dictionary;
    }

    static WebData()
    {
      int num = 1;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: method reference
            // ISSUE: type reference
            WebData.IdPropertyName = LinqUtils.NameOf<IEntity<object>>(Expression.Lambda<Func<IEntity<object>, object>>((Expression) WebData.j6kIVjfippkQaLqluV2y((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IEntity<object>.get_Id), __typeref (IEntity<object>))), parameterExpression));
            num = 6;
            continue;
          case 3:
            // ISSUE: method reference
            WebData.IsDeletedPropertyName = LinqUtils.NameOf<ISoftDeletable>(Expression.Lambda<Func<ISoftDeletable, object>>((Expression) WebData.I8mFVZfiD9rofU2AwHWe((object) Expression.Property((Expression) parameterExpression, (MethodInfo) WebData.sMDwOLfia7JafpMElwxy(__methodref (ISoftDeletable.get_IsDeleted))), typeof (object)), parameterExpression));
            num = 7;
            continue;
          case 4:
            // ISSUE: method reference
            // ISSUE: type reference
            WebData.TypeUidPropertyName = LinqUtils.NameOf<IInheritable>(Expression.Lambda<Func<IInheritable, object>>((Expression) Expression.Convert((Expression) WebData.j6kIVjfippkQaLqluV2y((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IInheritable.get_TypeUid))), WebData.jf8a1AfiNSQjcMRLpd5j(__typeref (object))), parameterExpression));
            num = 5;
            continue;
          case 5:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) WebData.Bj5eAwfi3tl9owYdJCMv(WebData.jf8a1AfiNSQjcMRLpd5j(__typeref (ISoftDeletable)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210529503));
            num = 3;
            continue;
          case 6:
            // ISSUE: type reference
            parameterExpression = Expression.Parameter(WebData.jf8a1AfiNSQjcMRLpd5j(__typeref (IInheritable)), (string) WebData.qxlG8mfiiCJTBAP0lRSQ(-1204263869 ^ -1341583247 ^ 137462178));
            num = 4;
            continue;
          case 7:
            goto label_2;
          default:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) WebData.Bj5eAwfi3tl9owYdJCMv(WebData.jf8a1AfiNSQjcMRLpd5j(__typeref (IEntity<object>)), WebData.qxlG8mfiiCJTBAP0lRSQ(712480695 ^ 712449951));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void BxAqgMfif0FqbsKHpf4c() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fZa0MOfiGGKYywlHY8dt() => WebData.No7KBtfihovppoO8ZLS1 == null;

    internal static WebData MFEhikfiENGUjkSwxe2L() => WebData.No7KBtfihovppoO8ZLS1;

    internal static object z3vDUafiQhPixNWNIqbE([In] object obj0, [In] object obj1, bool loadDisplayName) => (object) WebData.CreateFromEntity((IEntity) obj0, (EntitySerializationSettings) obj1, loadDisplayName);

    internal static object tSQ3YEfiCOvQ1MxCSpJI([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object GQGDLIfiveaM7tkxB92K([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void GPc4oJfi8SyZJ0HoPtsC([In] object obj0, [In] object obj1) => ((WebDataItem) obj0).Name = (string) obj1;

    internal static object q7rp1bfiZd2pSP7yTc9S([In] object obj0) => (object) ((List<WebDataItem>) obj0).ToArray();

    internal static bool qUNeWKfiuDJ52wa2nhAC([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void JyG2ZNfiIDt0NL2kvA7e([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool wtaKpGfiVaVq9I1J0jYr([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object UC7Z9BfiS70ACbQgOYW2([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static object qxlG8mfiiCJTBAP0lRSQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int mKUDYgfiRcn9nhA9iyO5([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static int owMstTfiqFBVPsG4YKqQ([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).LastIndexOf((string) obj1, obj2);

    internal static object EZ84qdfiKdURYq8WMfj3([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object DeAnBjfiXKuNRN6AdYD8([In] object obj0) => (object) ((WebDataItem) obj0).Data;

    internal static int tSaGBofiTXySGICC1dbE([In] object obj0) => ((List<string>) obj0).Count;

    internal static void jpkNsGfike7xiWkObb3r([In] object obj0, [In] object obj1, bool ignoreNullDescriptor) => ((WebData) obj0).SaveToEntity(obj1, ignoreNullDescriptor);

    internal static object Erv6fjfinC6BKJ6gBEmP() => (object) MetadataServiceContext.Service;

    internal static Guid WGKCY0fiOFcEEyvEWDXd([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static object HYMId0fi2o3n731C8WXk([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object pQV6p9fiefsba88c6Skn() => (object) Environment.NewLine;

    internal static object r3vUlGfiP0PJIODUvJJI([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object t1TJkqfi1LyEsvLdwUok([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static Type jf8a1AfiNSQjcMRLpd5j([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Bj5eAwfi3tl9owYdJCMv([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object j6kIVjfippkQaLqluV2y([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object sMDwOLfia7JafpMElwxy([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object I8mFVZfiD9rofU2AwHWe([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);
  }
}
