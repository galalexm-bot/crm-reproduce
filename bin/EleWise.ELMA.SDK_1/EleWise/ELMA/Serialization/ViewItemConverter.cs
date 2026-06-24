// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.ViewItemConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Конвертер для <see cref="T:EleWise.ELMA.Model.Views.ViewItem" />
  /// </summary>
  internal sealed class ViewItemConverter : JsonConverter
  {
    private static ViewItemConverter instance;
    private static ViewItemConverter B3Oiu0BdVd9QcMUnQ69o;

    /// <summary>Экземпляр конвертера</summary>
    internal static ViewItemConverter Instance
    {
      get
      {
        int num = 1;
        ViewItemConverter instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = ViewItemConverter.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
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
        return ViewItemConverter.instance = new ViewItemConverter();
      }
    }

    /// <summary>Можно ли сконвертировать тип</summary>
    /// <param name="objectType">Тип</param>
    /// <returns><c>true</c>, если можно сконвертировать тип</returns>
    public override bool CanConvert(Type objectType) => TypeOf<ViewItem>.Raw.IsAssignableFrom(objectType);

    public override bool CanRead => false;

    /// <summary>Прочитать Json</summary>
    /// <param name="reader">Reader, откуда производится чтение данных</param>
    /// <param name="objectType">Тип объекта</param>
    /// <param name="existingValue">Существующее значение</param>
    /// <param name="serializer">Сериализатор</param>
    /// <returns>Десериализованный объект</returns>
    public override object ReadJson(
      JsonReader reader,
      Type objectType,
      object existingValue,
      Newtonsoft.Json.JsonSerializer serializer)
    {
      return (object) null;
    }

    /// <summary>Записать значение</summary>
    /// <param name="writer">Writer, куда производится запись данных в json</param>
    /// <param name="value">Значение объекта</param>
    /// <param name="serializer">Сериализатор</param>
    public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Newtonsoft.Json.JsonSerializer jsonSerializer = new Newtonsoft.Json.JsonSerializer();
            ViewItemConverter.X4HBepBdqc9Mndp5cnOc((object) jsonSerializer, ViewItemConverter.eJSJuABdRqfwvDfwElUP());
            ViewItemConverter.vi8amJBdKWWWlCTfScRI((object) jsonSerializer, (object) new XmlContractResolver());
            ViewItemConverter.NUOQFhBdXANUdXhtZVLh((object) jsonSerializer, TypeNameHandling.Objects);
            ViewItemConverter.xirclMBdTT81Hfs2db4X((object) jsonSerializer, DateFormatHandling.IsoDateFormat);
            ViewItemConverter.HsQMnRBdkQyfUqQ0mE8Z((object) jsonSerializer, ReferenceLoopHandling.Ignore);
            ((Collection<JsonConverter>) ViewItemConverter.vFLhJuBdnxYkWHt5stCj((object) jsonSerializer)).Add((JsonConverter) SimpleTypesConverter.Instance);
            ((Collection<JsonConverter>) ViewItemConverter.vFLhJuBdnxYkWHt5stCj((object) jsonSerializer)).Add((JsonConverter) ViewItemConverter.QNtvdCBdO51RGSnERdFx());
            jsonSerializer.Converters.Add((JsonConverter) ViewItemConverter.k2lALDBd2hSlslh2HMqK());
            jsonSerializer.Converters.Add((JsonConverter) ViewItemConverter.W4yBqFBdeOn2lotlgUdf());
            ViewItemConverter.YBxg9rBdPdyuNIkmTefC((object) jsonSerializer, (object) writer, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ViewItemConverter()
    {
      ViewItemConverter.WdSpVcBd1OMWBATsqsMe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bF81lLBdSfMVGpBqUc5I() => ViewItemConverter.B3Oiu0BdVd9QcMUnQ69o == null;

    internal static ViewItemConverter BlxWOPBdikxOtABwRBMc() => ViewItemConverter.B3Oiu0BdVd9QcMUnQ69o;

    internal static object eJSJuABdRqfwvDfwElUP() => (object) KnownTypesBinder.Instance;

    internal static void X4HBepBdqc9Mndp5cnOc([In] object obj0, [In] object obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).SerializationBinder = (ISerializationBinder) obj1;

    internal static void vi8amJBdKWWWlCTfScRI([In] object obj0, [In] object obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).ContractResolver = (IContractResolver) obj1;

    internal static void NUOQFhBdXANUdXhtZVLh([In] object obj0, [In] TypeNameHandling obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).TypeNameHandling = obj1;

    internal static void xirclMBdTT81Hfs2db4X([In] object obj0, [In] DateFormatHandling obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).DateFormatHandling = obj1;

    internal static void HsQMnRBdkQyfUqQ0mE8Z([In] object obj0, [In] ReferenceLoopHandling obj1) => ((Newtonsoft.Json.JsonSerializer) obj0).ReferenceLoopHandling = obj1;

    internal static object vFLhJuBdnxYkWHt5stCj([In] object obj0) => (object) ((Newtonsoft.Json.JsonSerializer) obj0).Converters;

    internal static object QNtvdCBdO51RGSnERdFx() => (object) AbstractJsonConverter.Instance;

    internal static object k2lALDBd2hSlslh2HMqK() => (object) ComputedValueConverter.Instance;

    internal static object W4yBqFBdeOn2lotlgUdf() => (object) PropertiesContainerConverter.Instance;

    internal static void YBxg9rBdPdyuNIkmTefC([In] object obj0, [In] object obj1, [In] object obj2) => ((Newtonsoft.Json.JsonSerializer) obj0).Serialize((JsonWriter) obj1, obj2);

    internal static void WdSpVcBd1OMWBATsqsMe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
