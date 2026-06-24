// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.PropertiesContainerConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Конвертер для <see cref="T:EleWise.ELMA.Model.Types.Settings.TypeSettings" />
  /// </summary>
  internal sealed class PropertiesContainerConverter : JsonConverter
  {
    private static PropertiesContainerConverter instance;
    internal static PropertiesContainerConverter kH8sNaBJ4A1jQJKj35K9;

    /// <summary>Экземпляр конвертера</summary>
    internal static PropertiesContainerConverter Instance
    {
      get
      {
        int num = 1;
        PropertiesContainerConverter instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = PropertiesContainerConverter.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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
        return PropertiesContainerConverter.instance = new PropertiesContainerConverter();
      }
    }

    /// <inheritdoc />
    public override bool CanConvert(Type objectType) => TypeOf<PropertiesContainer>.Raw.IsAssignableFrom(objectType);

    /// <inheritdoc />
    public override object ReadJson(
      JsonReader reader,
      Type objectType,
      object existingValue,
      Newtonsoft.Json.JsonSerializer serializer)
    {
      int num1 = 4;
      PropertiesContainer propertiesContainer1;
      JsonToken jsonToken;
      IEnumerator<KeyValuePair<string, object>> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (jsonToken == JsonToken.Null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            enumerator = ((IEnumerable<KeyValuePair<string, object>>) serializer.Deserialize(reader, TypeOf<ExpandoObject>.Raw)).GetEnumerator();
            num1 = 5;
            continue;
          case 3:
            if (jsonToken == JsonToken.StartObject)
            {
              propertiesContainer1 = new PropertiesContainer();
              num1 = 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
            continue;
          case 4:
            jsonToken = PropertiesContainerConverter.FuQqZpBJABRCjCSyurLy((object) reader);
            num1 = 3;
            continue;
          case 5:
            goto label_10;
          case 6:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      return (object) propertiesContainer1;
label_3:
      return (object) new PropertiesContainer();
label_4:
      return (object) null;
label_10:
      try
      {
label_22:
        if (PropertiesContainerConverter.VB1AkjBJd7PQJr0iZxip((object) enumerator))
          goto label_27;
        else
          goto label_23;
label_11:
        KeyValuePair<string, object> current;
        object obj1;
        int num2;
        while (true)
        {
          object obj2;
          Type type1;
          switch (num2)
          {
            case 1:
              type1 = PropertiesContainerConverter.f1bxu3BJmZ0V672aNnRm(PropertiesContainerConverter.UWOBmbBJ0N3TcAr16B3p(), (object) null, (object) (string) obj1);
              num2 = 7;
              continue;
            case 2:
            case 8:
              goto label_22;
            case 3:
              goto label_27;
            case 4:
              goto label_2;
            case 5:
              PropertiesContainer propertiesContainer2 = propertiesContainer1;
              string key = current.Key;
              string str = (string) obj2;
              Type type2 = type1;
              JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
              PropertiesContainerConverter.RxRaf7BJMF8XeCgJbgPD((object) serializerSettings, DateFormatHandling.IsoDateFormat);
              object obj3 = PropertiesContainerConverter.DZLEKEBJJm4xaod5eMqF((object) str, type2, (object) serializerSettings);
              PropertiesContainerConverter.lsJdraBJ9QYASW3B2Kff((object) propertiesContainer2, (object) key, (object) null, obj3);
              num2 = 2;
              continue;
            case 6:
              goto label_14;
            case 7:
              if (!PropertiesContainerConverter.U50oQEBJyM0YOyk9l8My(type1, (Type) null))
              {
                if (dictionary.TryGetValue((string) PropertiesContainerConverter.Xb1iFEBJ7LElbnWGNWrR(-812025778 ^ -812043976), out obj2))
                {
                  num2 = 5;
                  continue;
                }
                goto label_22;
              }
              else
              {
                num2 = 6;
                continue;
              }
            case 9:
              if (dictionary.TryGetValue((string) PropertiesContainerConverter.Xb1iFEBJ7LElbnWGNWrR(322893104 - -1992822529 ^ -1979291457), out obj1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
                continue;
              }
              goto label_22;
            case 10:
              if (PropertiesContainerConverter.X8raRpBJxI2btXlbpx1v((object) current.Key, PropertiesContainerConverter.Xb1iFEBJ7LElbnWGNWrR(-1120607109 - 305487170 ^ -1426134089)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 8 : 0;
                continue;
              }
              break;
          }
          if (current.Value is IDictionary<string, object> dictionary)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 9;
          else
            goto label_22;
        }
label_14:
        throw new InvalidOperationException(EleWise.ELMA.SR.T((string) PropertiesContainerConverter.Xb1iFEBJ7LElbnWGNWrR(712480695 ^ 712440619), obj1));
label_23:
        num2 = 4;
        goto label_11;
label_27:
        current = enumerator.Current;
        num2 = 10;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        {
          num2 = 8;
          goto label_11;
        }
        else
          goto label_11;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                PropertiesContainerConverter.CrrfJPBJllQjlAw8JZLf((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                continue;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
    }

    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
    {
      int num1 = 1;
      JObject jobject1;
      IEnumerator<string> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            if (value is PropertiesContainer propertiesContainer)
            {
              jobject1 = new JObject();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            PropertiesContainerConverter.rFv8gFBJrmQUBS4Y5Ujq((object) jobject1, (object) new JProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858941649), (object) TypeOf<PropertiesContainer>.Raw.FullName));
            num1 = 5;
            continue;
          case 4:
            try
            {
label_12:
              if (PropertiesContainerConverter.VB1AkjBJd7PQJr0iZxip((object) enumerator))
                goto label_16;
              else
                goto label_13;
label_10:
              JObject jobject2;
              object obj;
              string current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    PropertiesContainerConverter.xJtHL8BJjl4g0cF2RU2S((object) jobject1, (object) current, (object) jobject2);
                    num2 = 7;
                    continue;
                  case 2:
                    jobject2.Add((string) PropertiesContainerConverter.Xb1iFEBJ7LElbnWGNWrR(-675505729 ^ -675491639), (JToken) PropertiesContainerConverter.tUxtvvBJ53IrVo1pTgfP(obj, (object) serializer));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
                    continue;
                  case 3:
                    goto label_16;
                  case 4:
                    goto label_7;
                  case 5:
                    jobject2.AddFirst((object) new JProperty((string) PropertiesContainerConverter.Xb1iFEBJ7LElbnWGNWrR(-643786247 ^ -643697289), (object) obj.GetType().FullName));
                    num2 = 2;
                    continue;
                  case 6:
                    obj = PropertiesContainerConverter.SAxtWSBJgDtk99Bod4uK((object) propertiesContainer, (object) current, (object) null);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 2;
                    continue;
                  case 7:
                    goto label_12;
                  default:
                    jobject2 = new JObject();
                    num2 = 6;
                    continue;
                }
              }
label_13:
              num2 = 4;
              goto label_10;
label_16:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
              {
                num2 = 0;
                goto label_10;
              }
              else
                goto label_10;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_27;
                    default:
                      PropertiesContainerConverter.CrrfJPBJllQjlAw8JZLf((object) enumerator);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_27:;
            }
          case 5:
            enumerator = propertiesContainer.GetProperties().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 4;
            continue;
          case 6:
label_7:
            PropertiesContainerConverter.E8dmwoBJYLvB3I0AKBYP((object) jobject1, (object) writer, (object) Array.Empty<JsonConverter>());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
            continue;
          default:
            goto label_20;
        }
      }
label_25:
      return;
label_2:
      return;
label_20:;
    }

    public PropertiesContainerConverter()
    {
      PropertiesContainerConverter.PGxN8NBJLOdLEKLX3avr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kLwq1lBJ6hpv8XlQLeml() => PropertiesContainerConverter.kH8sNaBJ4A1jQJKj35K9 == null;

    internal static PropertiesContainerConverter VXPmJWBJHwkQE9MSIDM4() => PropertiesContainerConverter.kH8sNaBJ4A1jQJKj35K9;

    internal static JsonToken FuQqZpBJABRCjCSyurLy([In] object obj0) => ((JsonReader) obj0).TokenType;

    internal static object Xb1iFEBJ7LElbnWGNWrR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool X8raRpBJxI2btXlbpx1v([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object UWOBmbBJ0N3TcAr16B3p() => (object) KnownTypesBinder.Instance;

    internal static Type f1bxu3BJmZ0V672aNnRm([In] object obj0, [In] object obj1, [In] object obj2) => ((KnownTypesBinder) obj0).BindToType((string) obj1, (string) obj2);

    internal static bool U50oQEBJyM0YOyk9l8My([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void RxRaf7BJMF8XeCgJbgPD([In] object obj0, [In] DateFormatHandling obj1) => ((JsonSerializerSettings) obj0).DateFormatHandling = obj1;

    internal static object DZLEKEBJJm4xaod5eMqF([In] object obj0, [In] Type obj1, [In] object obj2) => JsonConvert.DeserializeObject((string) obj0, obj1, (JsonSerializerSettings) obj2);

    internal static void lsJdraBJ9QYASW3B2Kff([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertiesContainer) obj0).SetPropertyValue((string) obj1, (object[]) obj2, obj3);

    internal static bool VB1AkjBJd7PQJr0iZxip([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void CrrfJPBJllQjlAw8JZLf([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void rFv8gFBJrmQUBS4Y5Ujq([In] object obj0, [In] object obj1) => ((JContainer) obj0).AddFirst(obj1);

    internal static object SAxtWSBJgDtk99Bod4uK([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertiesContainer) obj0).GetPropertyValue((string) obj1, (object[]) obj2);

    internal static object tUxtvvBJ53IrVo1pTgfP([In] object obj0, [In] object obj1) => (object) JToken.FromObject(obj0, (Newtonsoft.Json.JsonSerializer) obj1);

    internal static void xJtHL8BJjl4g0cF2RU2S([In] object obj0, [In] object obj1, [In] object obj2) => ((JObject) obj0).Add((string) obj1, (JToken) obj2);

    internal static void E8dmwoBJYLvB3I0AKBYP([In] object obj0, [In] object obj1, [In] object obj2) => ((JToken) obj0).WriteTo((JsonWriter) obj1, (JsonConverter[]) obj2);

    internal static void PGxN8NBJLOdLEKLX3avr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
