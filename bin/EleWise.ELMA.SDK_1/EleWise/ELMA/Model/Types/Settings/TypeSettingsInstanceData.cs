// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.TypeSettingsInstanceData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>
  /// Данные хранилища настроек свойств для экземпляров объектов
  /// </summary>
  public class TypeSettingsInstanceData
  {
    internal static TypeSettingsInstanceData Yo7HdyocJBL6LxIZNvHP;

    /// <summary>Ctor</summary>
    public TypeSettingsInstanceData()
    {
      TypeSettingsInstanceData.eOnXu7oclbrbfgjo7bod();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<TypeSettingsInstanceData.DataItem>();
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

    /// <summary>Элементы настроек</summary>
    public List<TypeSettingsInstanceData.DataItem> Items { get; set; }

    /// <summary>
    /// Получить или записать настройки по идентификатору свойства
    /// </summary>
    /// <param name="uid">Идентификатор свойства</param>
    /// <returns></returns>
    public TypeSettings this[Guid uid]
    {
      get
      {
        int num1 = 2;
        TypeSettingsInstanceData.DataItem dataItem;
        while (true)
        {
          int num2 = num1;
          Guid uid1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                uid1 = uid;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              case 2:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
                continue;
              case 3:
                if (dataItem == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 4;
                  continue;
                }
                goto label_5;
              case 4:
                goto label_4;
              default:
                goto label_3;
            }
          }
label_3:
          dataItem = this.Items.FirstOrDefault<TypeSettingsInstanceData.DataItem>((Func<TypeSettingsInstanceData.DataItem, bool>) (i => TypeSettingsInstanceData.\u003C\u003Ec__DisplayClass7_0.QHt5TLCK8Xvoh3JcurAy((object) i) == uid1));
          num1 = 3;
        }
label_4:
        return (TypeSettings) null;
label_5:
        return dataItem.Settings;
      }
      set
      {
        int num1 = 9;
        while (true)
        {
          int num2 = num1;
          TypeSettingsInstanceData.DataItem dataItem;
          Guid uid1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                this.Items.Add(dataItem);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                continue;
              case 2:
                dataItem = new TypeSettingsInstanceData.DataItem();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 3;
                continue;
              case 4:
                TypeSettingsInstanceData.fgy8Ioocrpphf23Ip9BI((object) dataItem, uid1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
                continue;
              case 5:
                dataItem = this.Items.FirstOrDefault<TypeSettingsInstanceData.DataItem>((Func<TypeSettingsInstanceData.DataItem, bool>) (i => TypeSettingsInstanceData.\u003C\u003Ec__DisplayClass8_0.cdmqkZCKiuMqR9vW0FK7(TypeSettingsInstanceData.\u003C\u003Ec__DisplayClass8_0.H7nMSCCKSU3jARI2S3PV((object) i), uid1)));
                num2 = 6;
                continue;
              case 6:
                if (dataItem != null)
                {
                  num2 = 3;
                  continue;
                }
                goto case 2;
              case 7:
                goto label_3;
              case 8:
                uid1 = uid;
                num2 = 5;
                continue;
              case 9:
                goto label_4;
              default:
                goto label_12;
            }
          }
label_4:
          num1 = 8;
          continue;
label_12:
          TypeSettingsInstanceData.mibXaIocgCIGQwDvSoXe((object) dataItem, (object) value);
          num1 = 7;
        }
label_3:;
      }
    }

    /// <summary>Сериализовать в JSON</summary>
    /// <returns></returns>
    public string SerializeToJson() => (string) TypeSettingsInstanceData.cGAELpoc5OcbbIyqTJFB((object) this.SerializeToJsonObject());

    /// <summary>
    /// Сериализовать в объект, пригодный для сериализации в JSON
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, SerializableDictionary<string, object>> SerializeToJsonObject()
    {
      Dictionary<string, SerializableDictionary<string, object>> jsonObject1 = new Dictionary<string, SerializableDictionary<string, object>>();
      foreach (TypeSettingsInstanceData.DataItem dataItem in this.Items)
      {
        if (dataItem.Settings != null)
        {
          SerializableDictionary<string, object> jsonObject2 = TypeSettingsSerializer.SerializeToJsonObject(dataItem.Settings);
          jsonObject1[dataItem.PropertyUid.ToString()] = jsonObject2;
        }
      }
      return jsonObject1;
    }

    /// <summary>Десериализовать из JSON</summary>
    /// <param name="json"></param>
    public void DeserializeFromJson(string json)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, Dictionary<string, object>> dictionary;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_14;
            case 2:
              goto label_3;
            case 3:
              if (string.IsNullOrEmpty(json))
              {
                num2 = 2;
                continue;
              }
              goto label_5;
            case 4:
              if (dictionary == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                continue;
              }
              Dictionary<string, Dictionary<string, object>> source = dictionary;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, Dictionary<string, object>>, string> func1 = TypeSettingsInstanceData.\u003C\u003Ec.\u003C\u003E9__11_0;
              Func<KeyValuePair<string, Dictionary<string, object>>, string> keySelector;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                TypeSettingsInstanceData.\u003C\u003Ec.\u003C\u003E9__11_0 = keySelector = (Func<KeyValuePair<string, Dictionary<string, object>>, string>) (p => p.Key);
              }
              else
                goto label_18;
label_13:
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, Dictionary<string, object>>, IDictionary<string, object>> func2 = TypeSettingsInstanceData.\u003C\u003Ec.\u003C\u003E9__11_1;
              Func<KeyValuePair<string, Dictionary<string, object>>, IDictionary<string, object>> elementSelector;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                TypeSettingsInstanceData.\u003C\u003Ec.\u003C\u003E9__11_1 = elementSelector = (Func<KeyValuePair<string, Dictionary<string, object>>, IDictionary<string, object>>) (p => (IDictionary<string, object>) p.Value);
              }
              else
                goto label_17;
label_16:
              this.DeserializeFromJsonObject(source.ToDictionary<KeyValuePair<string, Dictionary<string, object>>, string, IDictionary<string, object>>(keySelector, elementSelector));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
              continue;
label_17:
              elementSelector = func2;
              goto label_16;
label_18:
              keySelector = func1;
              goto label_13;
            default:
              goto label_11;
          }
        }
label_5:
        dictionary = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(json);
        num1 = 4;
      }
label_4:
      return;
label_14:
      return;
label_3:
      return;
label_11:;
    }

    /// <summary>Десериализовать из JSON</summary>
    /// <param name="jsonObject"></param>
    public void DeserializeFromJsonObject(
      Dictionary<string, IDictionary<string, object>> jsonObject)
    {
      if (jsonObject == null)
        return;
      foreach (KeyValuePair<string, IDictionary<string, object>> keyValuePair in jsonObject)
      {
        TypeSettings typeSettings = TypeSettingsSerializer.DeserializeFromJsonObject(keyValuePair.Value);
        if (typeSettings != null)
          this.Items.Add(new TypeSettingsInstanceData.DataItem()
          {
            PropertyUid = new Guid(keyValuePair.Key),
            Settings = typeSettings
          });
      }
    }

    internal static void eOnXu7oclbrbfgjo7bod() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TkTkgyoc9xGG2tCUYSD6() => TypeSettingsInstanceData.Yo7HdyocJBL6LxIZNvHP == null;

    internal static TypeSettingsInstanceData DkCVIrocdI38rxhqhVuh() => TypeSettingsInstanceData.Yo7HdyocJBL6LxIZNvHP;

    internal static void fgy8Ioocrpphf23Ip9BI([In] object obj0, Guid value) => ((TypeSettingsInstanceData.DataItem) obj0).PropertyUid = value;

    internal static void mibXaIocgCIGQwDvSoXe([In] object obj0, [In] object obj1) => ((TypeSettingsInstanceData.DataItem) obj0).Settings = (TypeSettings) obj1;

    internal static object cGAELpoc5OcbbIyqTJFB([In] object obj0) => (object) JsonConvert.SerializeObject(obj0);

    /// <summary>
    /// Элемент с настройками, принадлежащий конкретному свойству
    /// </summary>
    [XmlType(TypeName = "TypeSettingsInstanceDataItem")]
    public class DataItem
    {
      private static TypeSettingsInstanceData.DataItem DyshiHCKbrqqkHPLWRyv;

      /// <summary>Уникальный идентификатор свойства</summary>
      public Guid PropertyUid
      {
        get => this.\u003CPropertyUid\u003Ek__BackingField;
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
                this.\u003CPropertyUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

      /// <summary>Настройки</summary>
      public TypeSettings Settings
      {
        get => this.\u003CSettings\u003Ek__BackingField;
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
                this.\u003CSettings\u003Ek__BackingField = value;
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

      public DataItem()
      {
        TypeSettingsInstanceData.DataItem.oNeuENCKE0TSjXxSCOe8();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool sSLH90CKhp9oL6i9SmKD() => TypeSettingsInstanceData.DataItem.DyshiHCKbrqqkHPLWRyv == null;

      internal static TypeSettingsInstanceData.DataItem hF9sXVCKG5a1H6wRHCwO() => TypeSettingsInstanceData.DataItem.DyshiHCKbrqqkHPLWRyv;

      internal static void oNeuENCKE0TSjXxSCOe8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
