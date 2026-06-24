// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.AbstractJsonConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Конвертер для абстрактных классов при десериализации</summary>
  internal sealed class AbstractJsonConverter : JsonConverter
  {
    private static AbstractJsonConverter instance;
    internal static AbstractJsonConverter llc2VCB9RrrTwseXLxsR;

    /// <summary>Экземпляр конвертера</summary>
    internal static AbstractJsonConverter Instance
    {
      get
      {
        int num = 1;
        AbstractJsonConverter instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = AbstractJsonConverter.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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
        return AbstractJsonConverter.instance = new AbstractJsonConverter();
      }
    }

    /// <inheritdoc />
    public override bool CanConvert(Type objectType) => objectType.IsAbstract;

    /// <inheritdoc />
    public override object ReadJson(
      JsonReader reader,
      Type objectType,
      object existingValue,
      Newtonsoft.Json.JsonSerializer serializer)
    {
      int num = 1;
      object target;
      JObject jobject;
      while (true)
      {
        switch (num)
        {
          case 1:
            jobject = (JObject) AbstractJsonConverter.uKohR3B9XtQqIhfu0e5Y((object) reader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            serializer.Populate((JsonReader) AbstractJsonConverter.devlb3B9kah7ST3pfeeN((object) jobject), target);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 2;
            continue;
          default:
            target = AbstractJsonConverter.yl0uIDB9TCVUQLkMSQNp((object) jobject);
            num = 3;
            continue;
        }
      }
label_2:
      return target;
    }

    /// <inheritdoc />
    public override bool CanWrite => false;

    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) => throw new NotImplementedException();

    private static object Create(object jObject)
    {
      int num = 3;
      string str1;
      Type t;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (AbstractJsonConverter.lp9InmB9n1hxaxYfXNMO((object) str1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
              continue;
            }
            t = AbstractJsonConverter.HrDZTBB92WtnVyLrSgHL(AbstractJsonConverter.wQr2gtB9OkTqSZK7JX62(), (object) str2, (object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 3:
            (str1, str2) = AbstractJsonConverter.GetItemTypeString(jObject);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 1;
            continue;
          case 4:
            goto label_2;
          default:
            if (AbstractJsonConverter.iCjHUXB9ehm30lPjqDPq(t, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 4;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) AbstractJsonConverter.D0riiAB9ParvxYLlhtOE(694673736 ^ -23604109 ^ -672048271), (object) str1));
label_3:
      return InterfaceActivator.Create(t);
label_9:
      return (object) null;
    }

    private static (string, string) GetItemTypeString(object jObject)
    {
      JToken jtoken;
      if (((JObject) jObject).TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195672677), out jtoken))
      {
        string str = jtoken.Value<string>();
        if (!string.IsNullOrWhiteSpace(str))
        {
          string[] strArray = str.Split(',');
          return strArray.Length > 1 ? (strArray[0], strArray[1]) : (str, string.Empty);
        }
      }
      return (string.Empty, string.Empty);
    }

    public AbstractJsonConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool WkVOdoB9qq66M28Od5l6() => AbstractJsonConverter.llc2VCB9RrrTwseXLxsR == null;

    internal static AbstractJsonConverter bpLcodB9KZQBSgmRH2Mo() => AbstractJsonConverter.llc2VCB9RrrTwseXLxsR;

    internal static object uKohR3B9XtQqIhfu0e5Y([In] object obj0) => (object) JObject.Load((JsonReader) obj0);

    internal static object yl0uIDB9TCVUQLkMSQNp([In] object obj0) => AbstractJsonConverter.Create(obj0);

    internal static object devlb3B9kah7ST3pfeeN([In] object obj0) => (object) ((JToken) obj0).CreateReader();

    internal static bool lp9InmB9n1hxaxYfXNMO([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object wQr2gtB9OkTqSZK7JX62() => (object) KnownTypesBinder.Instance;

    internal static Type HrDZTBB92WtnVyLrSgHL([In] object obj0, [In] object obj1, [In] object obj2) => ((KnownTypesBinder) obj0).BindToType((string) obj1, (string) obj2);

    internal static bool iCjHUXB9ehm30lPjqDPq([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object D0riiAB9ParvxYLlhtOE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
