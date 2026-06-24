// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.API.WebData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Common.Models.API
{
  /// <summary>Класс для передачи данных через веб-сервисы</summary>
  [KnownType(typeof (WebData[]))]
  [Serializable]
  public class WebData : EleWise.ELMA.Common.Models.WebData, ISerializable
  {
    private WebDataItem[] items;
    private static readonly Type TypeOfWebData;
    private static readonly Type TypeOfWebDataArray;
    private static readonly Type TypeOfObject;
    private static readonly Type TypeOfObjectArray;
    private static readonly Type TypeofValue;
    internal static WebData ryaVMXfiL15UA8IfH3wJ;

    public WebData()
    {
      WebData.ejmZh7ficYgGVaH6HOxB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
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
      WebDataItem[] webDataItemArray1 = new WebDataItem[dicObj.Count];
      int num = 0;
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) dicObj)
      {
        if (keyValuePair.Value is WebData)
        {
          WebDataItem[] webDataItemArray2 = webDataItemArray1;
          int index = num;
          WebDataItem webDataItem = new WebDataItem();
          webDataItem.Name = keyValuePair.Key;
          webDataItem.Data = (EleWise.ELMA.Common.Models.WebData) WebData.Create((EleWise.ELMA.Common.Models.WebData) keyValuePair.Value);
          webDataItemArray2[index] = webDataItem;
        }
        else if (keyValuePair.Value is SerializableDictionary<string, object>)
        {
          WebDataItem[] webDataItemArray3 = webDataItemArray1;
          int index = num;
          WebDataItem webDataItem = new WebDataItem();
          webDataItem.Name = keyValuePair.Key;
          webDataItem.Data = (EleWise.ELMA.Common.Models.WebData) new WebData((ICollection<KeyValuePair<string, object>>) keyValuePair.Value);
          webDataItemArray3[index] = webDataItem;
        }
        else if (keyValuePair.Value is SerializableList<object> serializableList)
        {
          WebData[] webDataArray = new WebData[serializableList.Count];
          for (int index = 0; index < serializableList.Count; ++index)
          {
            object obj = serializableList[index];
            switch (obj)
            {
              case null:
                webDataArray[index] = (WebData) null;
                break;
              case ICollection<KeyValuePair<string, object>> dicObj1:
                webDataArray[index] = new WebData(dicObj1);
                break;
              case WebData webData:
                webDataArray[index] = webData;
                break;
              default:
                Type type = obj.GetType();
                if (type == typeof (string) || type.IsPrimitive || type.IsValueType)
                {
                  WebData webData1 = new WebData();
                  webData1.Value = obj.ToString();
                  WebData webData2 = webData1;
                  webDataArray[index] = webData2;
                  break;
                }
                break;
            }
          }
          WebDataItem[] webDataItemArray4 = webDataItemArray1;
          int index1 = num;
          WebDataItem webDataItem = new WebDataItem();
          webDataItem.Name = keyValuePair.Key;
          webDataItem.DataArray = (EleWise.ELMA.Common.Models.WebData[]) webDataArray;
          webDataItemArray4[index1] = webDataItem;
        }
        else if (keyValuePair.Value == null)
        {
          WebDataItem[] webDataItemArray5 = webDataItemArray1;
          int index = num;
          WebDataItem webDataItem = new WebDataItem();
          webDataItem.Name = keyValuePair.Key;
          webDataItem.Value = (string) null;
          webDataItemArray5[index] = webDataItem;
        }
        else
        {
          TypeConverter converter = ElmaTypeDescriptorHelper.GetConverter(keyValuePair.Value.GetType());
          if (converter != null && converter.CanConvertTo(typeof (string)))
          {
            WebDataItem[] webDataItemArray6 = webDataItemArray1;
            int index = num;
            WebDataItem webDataItem = new WebDataItem();
            webDataItem.Name = keyValuePair.Key;
            webDataItem.Value = converter.ConvertToInvariantString(keyValuePair.Value);
            webDataItemArray6[index] = webDataItem;
          }
          else
          {
            WebDataItem[] webDataItemArray7 = webDataItemArray1;
            int index = num;
            WebDataItem webDataItem = new WebDataItem();
            webDataItem.Name = keyValuePair.Key;
            webDataItem.Value = keyValuePair.Value.ToString();
            webDataItemArray7[index] = webDataItem;
          }
        }
        ++num;
      }
      this.items = webDataItemArray1;
    }

    /// <summary>Элементы данных</summary>
    public override EleWise.ELMA.Common.Models.WebDataItem[] Items
    {
      get => this.items.Cast<EleWise.ELMA.Common.Models.WebDataItem>().ToArray<EleWise.ELMA.Common.Models.WebDataItem>();
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
              this.items = value.Cast<WebDataItem>().ToArray<WebDataItem>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    public WebData(SerializationInfo info, StreamingContext context)
    {
      WebData.ejmZh7ficYgGVaH6HOxB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 16;
      while (true)
      {
        List<WebDataItem> webDataItemList;
        WebDataItem webDataItem1;
        SerializationInfoEnumerator serializationInfoEnumerator;
        switch (num)
        {
          case 1:
            goto label_15;
          case 2:
            WebData.sLpwAifRGOb6kpXZyIS6((object) webDataItem1, (object) ((WebData[]) info.GetValue((string) WebData.CyH2LKfRF1saYg7WyMZe((object) serializationInfoEnumerator), WebData.TypeOfWebDataArray)).Cast<EleWise.ELMA.Common.Models.WebData>().ToArray<EleWise.ELMA.Common.Models.WebData>());
            num = 13;
            continue;
          case 3:
            this._value = WebData.ADUhOMfRboJ3KRaruVk7((object) info, WebData.CyH2LKfRF1saYg7WyMZe((object) serializationInfoEnumerator), WebData.TypeofValue).ToString();
            num = 4;
            continue;
          case 4:
          case 5:
          case 6:
          case 13:
          case 17:
            if (WebData.HnXCUrfRfsNS6An8RGQh((object) serializationInfoEnumerator))
            {
              num = 21;
              continue;
            }
            break;
          case 7:
            if (!WebData.xCkppwfRoFDmGMcfCrRp(WebData.C3js5RfRW6jvx1958Vji((object) serializationInfoEnumerator), WebData.TypeOfObject))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 20 : 15;
              continue;
            }
            goto case 8;
          case 8:
            WebData.heJKR5fRheD0U3J3nqsR((object) webDataItem1, (object) (WebData) WebData.ADUhOMfRboJ3KRaruVk7((object) info, WebData.CyH2LKfRF1saYg7WyMZe((object) serializationInfoEnumerator), WebData.TypeOfWebData));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 5 : 5;
            continue;
          case 9:
            if (!(serializationInfoEnumerator.ObjectType == WebData.TypeOfWebDataArray))
            {
              num = 12;
              continue;
            }
            goto case 2;
          case 10:
          case 14:
            WebData.X9wjkWfREIfAVkBigbx3((object) webDataItem1, (object) info.GetString(serializationInfoEnumerator.Name));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 17 : 8;
            continue;
          case 11:
            if (!WebData.xCkppwfRoFDmGMcfCrRp(serializationInfoEnumerator.ObjectType, WebData.TypeOfObjectArray))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 9 : 4;
              continue;
            }
            goto case 2;
          case 12:
          case 15:
            if (!(WebData.C3js5RfRW6jvx1958Vji((object) serializationInfoEnumerator) == WebData.TypeofValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 14 : 13;
              continue;
            }
            goto case 3;
          case 16:
            webDataItemList = new List<WebDataItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 14 : 18;
            continue;
          case 18:
            serializationInfoEnumerator = (SerializationInfoEnumerator) WebData.WXr2v3fizkUSqpITB0eh((object) info);
            num = 6;
            continue;
          case 19:
            webDataItemList.Add(webDataItem1);
            num = 7;
            continue;
          case 20:
            if (WebData.xCkppwfRoFDmGMcfCrRp(WebData.C3js5RfRW6jvx1958Vji((object) serializationInfoEnumerator), WebData.TypeOfWebData))
            {
              num = 8;
              continue;
            }
            goto case 11;
          case 21:
          case 22:
            WebDataItem webDataItem2 = new WebDataItem();
            WebData.TxnEgEfRBBcnc3kor8Nm((object) webDataItem2, WebData.CyH2LKfRF1saYg7WyMZe((object) serializationInfoEnumerator));
            webDataItem1 = webDataItem2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 19;
            continue;
        }
        this.items = (WebDataItem[]) WebData.wiJtF6fRQx3CWIOXhcLG((object) webDataItemList);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
      }
label_15:;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        WebDataItem webDataItem;
        WebData webData;
        WebData[] array1;
        int index;
        WebDataItem[] items;
        string[] array2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              WebData.mQn2udfRZHAPnVn89fuZ((object) info, WebData.NsuAqHfRvJdVCIOdHIVx((object) webDataItem), (object) array2, WebData.TypeOfWebDataArray);
              num2 = 13;
              continue;
            case 3:
              if (WebData.eAIHySfR8BpvBLjMYMH4((object) webDataItem) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 6 : 2;
                continue;
              }
              goto case 17;
            case 4:
              items = this.items;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 10 : 6;
              continue;
            case 5:
              if (this.items != null)
              {
                num2 = 4;
                continue;
              }
              WebData.mQn2udfRZHAPnVn89fuZ((object) info, WebData.WesVgdfRVRB3pfosq1yF(236071375 ^ 236097435), WebData.sQjuorfRS6pDl1raKlbt((object) this), WebData.TypeofValue);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 12 : 18;
              continue;
            case 7:
            case 23:
              array1 = ((IEnumerable) WebData.eAIHySfR8BpvBLjMYMH4((object) webDataItem)).Cast<WebData>().ToArray<WebData>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 12 : 6;
              continue;
            case 8:
              if (webDataItem.Data != null)
              {
                num2 = 22;
                continue;
              }
              goto case 3;
            case 9:
              info.AddValue((string) WebData.NsuAqHfRvJdVCIOdHIVx((object) webDataItem), (object) webData, WebData.TypeOfWebData);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 7 : 15;
              continue;
            case 10:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 20 : 16;
              continue;
            case 11:
            case 16:
              webDataItem = items[index];
              num2 = 8;
              continue;
            case 12:
              WebData.mQn2udfRZHAPnVn89fuZ((object) info, WebData.NsuAqHfRvJdVCIOdHIVx((object) webDataItem), (object) array1, WebData.TypeOfWebDataArray);
              num2 = 19;
              continue;
            case 13:
            case 15:
            case 19:
            case 21:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 8 : 14;
              continue;
            case 14:
            case 20:
              if (index < items.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 10 : 11;
                continue;
              }
              goto label_22;
            case 17:
              if (WebData.eAIHySfR8BpvBLjMYMH4((object) webDataItem).Length != 0)
                goto case 24;
              else
                goto label_6;
            case 18:
              goto label_28;
            case 22:
              webData = (WebData) WebData.OnsNkDfRCffFClaGCaJT((object) webDataItem);
              num2 = 9;
              continue;
            case 24:
              object source = WebData.eAIHySfR8BpvBLjMYMH4((object) webDataItem);
              // ISSUE: reference to a compiler-generated field
              Func<EleWise.ELMA.Common.Models.WebData, bool> func = WebData.\u003C\u003Ec.\u003C\u003E9__8_0;
              Func<EleWise.ELMA.Common.Models.WebData, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                WebData.\u003C\u003Ec.\u003C\u003E9__8_0 = predicate = (Func<EleWise.ELMA.Common.Models.WebData, bool>) (d => d.HasValue);
              }
              else
                goto label_7;
label_30:
              if (!((IEnumerable<EleWise.ELMA.Common.Models.WebData>) source).All<EleWise.ELMA.Common.Models.WebData>(predicate))
              {
                num2 = 7;
                continue;
              }
              goto case 26;
label_7:
              predicate = func;
              goto label_30;
            case 26:
              // ISSUE: reference to a compiler-generated method
              array2 = ((IEnumerable<EleWise.ELMA.Common.Models.WebData>) WebData.eAIHySfR8BpvBLjMYMH4((object) webDataItem)).Select<EleWise.ELMA.Common.Models.WebData, string>((Func<EleWise.ELMA.Common.Models.WebData, string>) (d => (string) WebData.\u003C\u003Ec.xsUsaC8jdNrd4nfOArVw((object) d))).ToArray<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
              continue;
            default:
              WebData.JbFNhDfRIPD6QYTqrlEC((object) info, WebData.NsuAqHfRvJdVCIOdHIVx((object) webDataItem), WebData.lXYJDUfRuLLKbjX7lHGR((object) webDataItem));
              num2 = 21;
              continue;
          }
        }
label_6:
        num1 = 25;
      }
label_3:
      return;
label_28:
      return;
label_22:;
    }

    public static WebData Create(EleWise.ELMA.Common.Models.WebData baseData)
    {
      int num = 1;
      WebData webData;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (baseData != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            webData.Items = ((IEnumerable<EleWise.ELMA.Common.Models.WebDataItem>) WebData.UFr8jlfRiOY7a9x6NAHF((object) baseData)).Select<EleWise.ELMA.Common.Models.WebDataItem, WebDataItem>(new Func<EleWise.ELMA.Common.Models.WebDataItem, WebDataItem>(WebDataItem.Create)).Cast<EleWise.ELMA.Common.Models.WebDataItem>().ToArray<EleWise.ELMA.Common.Models.WebDataItem>();
            num = 7;
            continue;
          case 3:
          case 8:
            WebData.e55f6RfRR8FOve4f7g5p((object) webData, WebData.sQjuorfRS6pDl1raKlbt((object) baseData));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 4;
            continue;
          case 4:
          case 7:
            goto label_10;
          case 5:
            goto label_5;
          case 6:
            if (WebData.UFr8jlfRiOY7a9x6NAHF((object) baseData) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 5 : 8;
              continue;
            }
            goto case 2;
          default:
            webData = new WebData();
            num = 6;
            continue;
        }
      }
label_5:
      return (WebData) null;
label_10:
      return webData;
    }

    static WebData()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              WebData.TypeOfObjectArray = typeof (object[]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            case 3:
              // ISSUE: type reference
              WebData.TypeOfObject = WebData.yK0u3xfRqWjNbJ7uVtL6(__typeref (object));
              num2 = 2;
              continue;
            case 4:
              // ISSUE: type reference
              WebData.TypeOfWebDataArray = WebData.yK0u3xfRqWjNbJ7uVtL6(__typeref (WebData[]));
              num2 = 3;
              continue;
            case 5:
              WebData.TypeOfWebData = typeof (WebData);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 4;
              continue;
            case 6:
              goto label_5;
            default:
              // ISSUE: type reference
              WebData.TypeofValue = WebData.yK0u3xfRqWjNbJ7uVtL6(__typeref (string));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
          }
        }
label_5:
        WebData.ejmZh7ficYgGVaH6HOxB();
        num1 = 5;
      }
label_3:;
    }

    internal static void ejmZh7ficYgGVaH6HOxB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bUI2bYfiUvpyApCwJycO() => WebData.ryaVMXfiL15UA8IfH3wJ == null;

    internal static WebData hK2WsVfisroT2xYyJ3lq() => WebData.ryaVMXfiL15UA8IfH3wJ;

    internal static object WXr2v3fizkUSqpITB0eh([In] object obj0) => (object) ((SerializationInfo) obj0).GetEnumerator();

    internal static object CyH2LKfRF1saYg7WyMZe([In] object obj0) => (object) ((SerializationInfoEnumerator) obj0).Name;

    internal static void TxnEgEfRBBcnc3kor8Nm([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Name = (string) obj1;

    internal static Type C3js5RfRW6jvx1958Vji([In] object obj0) => ((SerializationInfoEnumerator) obj0).ObjectType;

    internal static bool xCkppwfRoFDmGMcfCrRp([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object ADUhOMfRboJ3KRaruVk7([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void heJKR5fRheD0U3J3nqsR([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Data = (EleWise.ELMA.Common.Models.WebData) obj1;

    internal static void sLpwAifRGOb6kpXZyIS6([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Common.Models.WebDataItem) obj0).DataArray = (EleWise.ELMA.Common.Models.WebData[]) obj1;

    internal static void X9wjkWfREIfAVkBigbx3([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Value = (string) obj1;

    internal static bool HnXCUrfRfsNS6An8RGQh([In] object obj0) => ((SerializationInfoEnumerator) obj0).MoveNext();

    internal static object wiJtF6fRQx3CWIOXhcLG([In] object obj0) => (object) ((List<WebDataItem>) obj0).ToArray();

    internal static object OnsNkDfRCffFClaGCaJT([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Data;

    internal static object NsuAqHfRvJdVCIOdHIVx([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Name;

    internal static object eAIHySfR8BpvBLjMYMH4([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebDataItem) obj0).DataArray;

    internal static void mQn2udfRZHAPnVn89fuZ([In] object obj0, [In] object obj1, [In] object obj2, [In] Type obj3) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2, obj3);

    internal static object lXYJDUfRuLLKbjX7lHGR([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Value;

    internal static void JbFNhDfRIPD6QYTqrlEC([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static object WesVgdfRVRB3pfosq1yF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sQjuorfRS6pDl1raKlbt([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebData) obj0).Value;

    internal static object UFr8jlfRiOY7a9x6NAHF([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebData) obj0).Items;

    internal static void e55f6RfRR8FOve4f7g5p([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Common.Models.WebData) obj0).Value = (string) obj1;

    internal static Type yK0u3xfRqWjNbJ7uVtL6([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
