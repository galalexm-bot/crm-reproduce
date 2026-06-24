// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.SimpleTypesConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Конвертер простых типов</summary>
  internal sealed class SimpleTypesConverter : JsonConverter
  {
    private static SimpleTypesConverter instance;
    private readonly ConcurrentDictionary<Type, bool> canConvert;
    internal static SimpleTypesConverter IwsuFKB9Ach9pUMrwhSF;

    /// <summary>Экземпляр конвертера</summary>
    internal static SimpleTypesConverter Instance
    {
      get
      {
        int num = 1;
        SimpleTypesConverter instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = SimpleTypesConverter.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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
        return SimpleTypesConverter.instance = new SimpleTypesConverter();
      }
    }

    /// <summary>Можно ли сконвертировать тип</summary>
    /// <param name="objectType">Тип</param>
    /// <returns><c>true</c>, если можно сконвертировать тип</returns>
    public override bool CanConvert(Type objectType) => this.canConvert.GetOrAdd(objectType, (Func<Type, bool>) (t =>
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_8;
          case 3:
            // ISSUE: reference to a compiler-generated method
            if (SimpleTypesConverter.\u003C\u003Ec.cgyS7DQ2WPAFaffMEqrh(t))
            {
              num = 2;
              continue;
            }
            break;
        }
        // ISSUE: reference to a compiler-generated method
        if (SimpleTypesConverter.\u003C\u003Ec.qZWFrkQ2obSy1jLFfB94(t))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
        else
          goto label_7;
      }
label_6:
      return t.GetGenericArguments()[0].IsSimpleType();
label_7:
      return false;
label_8:
      return true;
    }));

    /// <summary>Можно ли прочитать</summary>
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
      TypeConverter typeConverter;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeConverter = (TypeConverter) SimpleTypesConverter.W325K3B90CVDgrcFOYFq(value.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SimpleTypesConverter.BLGJ6nB9yg8tCMSbRYPR((object) writer, SimpleTypesConverter.rJvyULB9mNdEEiGLoEOi((object) typeConverter, value));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    public SimpleTypesConverter()
    {
      SimpleTypesConverter.SgAr8hB9MWWOtFlk3pX3();
      this.canConvert = new ConcurrentDictionary<Type, bool>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool GVYeJQB97gcPSWWSVetZ() => SimpleTypesConverter.IwsuFKB9Ach9pUMrwhSF == null;

    internal static SimpleTypesConverter MbWHjkB9xRr9E0LCSlLG() => SimpleTypesConverter.IwsuFKB9Ach9pUMrwhSF;

    internal static object W325K3B90CVDgrcFOYFq([In] Type obj0) => (object) TypeDescriptor.GetConverter(obj0);

    internal static object rJvyULB9mNdEEiGLoEOi([In] object obj0, [In] object obj1) => (object) ((TypeConverter) obj0).ConvertToInvariantString(obj1);

    internal static void BLGJ6nB9yg8tCMSbRYPR([In] object obj0, [In] object obj1) => ((JsonWriter) obj0).WriteValue((string) obj1);

    internal static void SgAr8hB9MWWOtFlk3pX3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
