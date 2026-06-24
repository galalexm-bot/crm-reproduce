// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.ComputedValueConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Конвертер для <see cref="T:EleWise.ELMA.Model.Views.ComputedValue" />
  /// </summary>
  internal sealed class ComputedValueConverter : JsonConverter
  {
    private static ComputedValueConverter instance;
    internal static ComputedValueConverter RBjmtJBJkVtK7UFUB84r;

    /// <summary>Экземпляр конвертера</summary>
    internal static ComputedValueConverter Instance
    {
      get
      {
        int num = 1;
        ComputedValueConverter instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = ComputedValueConverter.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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
        return ComputedValueConverter.instance = new ComputedValueConverter();
      }
    }

    /// <inheritdoc />
    public override bool CanConvert(Type objectType) => TypeOf<ComputedValue>.Raw.IsAssignableFrom(objectType);

    /// <inheritdoc />
    public override object ReadJson(
      JsonReader reader,
      Type objectType,
      object existingValue,
      Newtonsoft.Json.JsonSerializer serializer)
    {
      int num1 = 3;
      ComputedValue source;
      while (true)
      {
        int num2 = num1;
        JsonToken jsonToken;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              if (jsonToken != JsonToken.StartObject)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                continue;
              }
              Newtonsoft.Json.JsonSerializer jsonSerializer = new Newtonsoft.Json.JsonSerializer();
              ComputedValueConverter.y50oyTBJPsdJSSx8JjHv((object) jsonSerializer, ComputedValueConverter.HMDv6EBJeEUu8QG2iMEc());
              ComputedValueConverter.Rek7TfBJ1GaVd40fWlLL((object) jsonSerializer, TypeNameHandling.Objects);
              source = (ComputedValue) ComputedValueConverter.l4InQiBJN4B5uCcXxPoX((object) jsonSerializer, (object) reader, objectType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
              continue;
            case 3:
              jsonToken = ComputedValueConverter.YjAaKIBJ25CC7nTZmZt6((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_13;
            case 6:
              goto label_5;
            default:
              if (jsonToken == JsonToken.Null)
              {
                num2 = 5;
                continue;
              }
              goto label_6;
          }
        }
label_7:
        if (source != null)
        {
          source.Value = ComputedValueConverter.MapValue((object) source);
          num1 = 6;
        }
        else
          num1 = 4;
      }
label_3:
      return (object) null;
label_5:
      return (object) source;
label_6:
      return (object) new ComputedValue();
label_13:
      return (object) null;
    }

    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        ComputedValue computedValue;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              ComputedValueConverter.AY4FyKBJaReshrceAKVW((object) computedValue, ComputedValueConverter.mwolXjBJpIhMfNic5wc0((object) actionValue));
              num2 = 5;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (value == null)
              {
                num2 = 2;
                continue;
              }
              goto label_5;
            case 4:
              if (ComputedValueConverter.XgEDrvBJ3bmlfth62GV3((object) computedValue) is ActionValue actionValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 5:
              Newtonsoft.Json.JsonSerializer jsonSerializer = new Newtonsoft.Json.JsonSerializer();
              ComputedValueConverter.y50oyTBJPsdJSSx8JjHv((object) jsonSerializer, ComputedValueConverter.HMDv6EBJeEUu8QG2iMEc());
              ComputedValueConverter.Rek7TfBJ1GaVd40fWlLL((object) jsonSerializer, TypeNameHandling.Objects);
              jsonSerializer.Serialize(writer, (object) computedValue);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            default:
              goto label_12;
          }
        }
label_5:
        computedValue = (ComputedValue) value;
        num1 = 4;
      }
label_4:
      return;
label_3:
      return;
label_12:;
    }

    private static object MapValue(object source)
    {
      int num = 8;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_9;
          case 3:
            goto label_2;
          case 4:
            if (!(source is ActionInputComputedValue))
            {
              num = 5;
              continue;
            }
            goto label_12;
          case 5:
            if (!str.Contains((string) ComputedValueConverter.KZN9J5BJtkpF8W71r0WF(-787452571 ^ -787414773)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 6:
            goto label_12;
          case 7:
            if (str == null)
            {
              num = 2;
              continue;
            }
            if (!ComputedValueConverter.Ts9ObPBJDC9RTt26srZK((object) str))
            {
              num = 4;
              continue;
            }
            goto label_6;
          case 8:
            str = ComputedValueConverter.XgEDrvBJ3bmlfth62GV3(source) as string;
            num = 7;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return (object) JsonConvert.DeserializeObject<ActionValue>(str);
label_3:
      return (object) str;
label_6:
      return (object) null;
label_9:
      return (object) null;
label_12:
      return (object) JsonConvert.DeserializeObject<ActionValue>(str);
    }

    public ComputedValueConverter()
    {
      ComputedValueConverter.o1fB1MBJw1xabtdvc5aj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gQfT32BJn8p82MKxq7UO() => ComputedValueConverter.RBjmtJBJkVtK7UFUB84r == null;

    internal static ComputedValueConverter XtVxwuBJOXdajSpAfvRK() => ComputedValueConverter.RBjmtJBJkVtK7UFUB84r;

    internal static JsonToken YjAaKIBJ25CC7nTZmZt6([In] object obj0) => ((JsonReader) obj0).TokenType;

    internal static object HMDv6EBJeEUu8QG2iMEc() => (object) KnownTypesBinder.Instance;

    internal static void y50oyTBJPsdJSSx8JjHv([In] object obj0, [In] object obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).SerializationBinder = (ISerializationBinder) obj1;

    internal static void Rek7TfBJ1GaVd40fWlLL([In] object obj0, [In] TypeNameHandling obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).TypeNameHandling = obj1;

    internal static object l4InQiBJN4B5uCcXxPoX([In] object obj0, [In] object obj1, [In] Type obj2) => ((Newtonsoft.Json.JsonSerializer) obj0).Deserialize((JsonReader) obj1, obj2);

    internal static object XgEDrvBJ3bmlfth62GV3([In] object obj0) => ((ComputedValue) obj0).Value;

    internal static object mwolXjBJpIhMfNic5wc0([In] object obj0) => (object) JsonConvert.SerializeObject(obj0);

    internal static void AY4FyKBJaReshrceAKVW([In] object obj0, [In] object obj1) => ((ComputedValue) obj0).Value = obj1;

    internal static bool Ts9ObPBJDC9RTt26srZK([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object KZN9J5BJtkpF8W71r0WF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void o1fB1MBJw1xabtdvc5aj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
