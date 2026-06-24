// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Serialization.MvcHtmlStringJsonConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using System;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics.Serialization
{
  /// <summary>Конвертер для json сериализатора</summary>
  public class MvcHtmlStringJsonConverter : JsonConverter
  {
    /// <summary>Экземпляр</summary>
    public static MvcHtmlStringJsonConverter Instance;
    private static MvcHtmlStringJsonConverter zfH0KDEhhdaeQ0mTsnPI;

    /// <summary>Можно ли конвертировать</summary>
    /// <param name="objectType">Тип объекта</param>
    /// <returns></returns>
    public override bool CanConvert(Type objectType) => MvcHtmlStringJsonConverter.FmOWaREhf50njrMeNZft(__typeref (MvcHtmlString)).IsAssignableFrom(objectType);

    /// <summary>Перевести из json'a</summary>
    /// <param name="reader">Ридер</param>
    /// <param name="objectType">тип объекта</param>
    /// <param name="existingValue">Значение</param>
    /// <param name="serializer">Сериализатор</param>
    /// <returns></returns>
    public override object ReadJson(
      JsonReader reader,
      Type objectType,
      object existingValue,
      JsonSerializer serializer)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MvcHtmlStringJsonConverter.QXcjLHEhCVIcGr9Jx2aM(typeof (MvcHtmlString), objectType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            str = MvcHtmlStringJsonConverter.hoIHVlEhQXR7iaw00PjJ((object) reader) as string;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) MvcHtmlString.Create(str);
label_3:
      return (object) null;
    }

    /// <summary>Перевести в json</summary>
    /// <param name="writer"></param>
    /// <param name="value"></param>
    /// <param name="serializer"></param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      int num = 2;
      MvcHtmlString mvcHtmlString;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 3;
              continue;
            }
            goto label_7;
          case 2:
            mvcHtmlString = value as MvcHtmlString;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          case 3:
            MvcHtmlStringJsonConverter.O6dXmhEhvvH3IrqFoMh8((object) writer, (object) mvcHtmlString.ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    public MvcHtmlStringJsonConverter()
    {
      MvcHtmlStringJsonConverter.V8ZRUvEh8UghsA4EQtlv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MvcHtmlStringJsonConverter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MvcHtmlStringJsonConverter.V8ZRUvEh8UghsA4EQtlv();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MvcHtmlStringJsonConverter.Instance = new MvcHtmlStringJsonConverter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static Type FmOWaREhf50njrMeNZft([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool DPXIZiEhGqGTAM3pY0fU() => MvcHtmlStringJsonConverter.zfH0KDEhhdaeQ0mTsnPI == null;

    internal static MvcHtmlStringJsonConverter cE87jEEhEM48eEy6iwhW() => MvcHtmlStringJsonConverter.zfH0KDEhhdaeQ0mTsnPI;

    internal static object hoIHVlEhQXR7iaw00PjJ([In] object obj0) => ((JsonReader) obj0).Value;

    internal static bool QXcjLHEhCVIcGr9Jx2aM([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void O6dXmhEhvvH3IrqFoMh8([In] object obj0, [In] object obj1) => ((JsonWriter) obj0).WriteValue((string) obj1);

    internal static void V8ZRUvEh8UghsA4EQtlv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
