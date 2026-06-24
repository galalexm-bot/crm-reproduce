// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Serialization.DiagnosticsWorkTreeIgnoreConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Serialization
{
  /// <summary>
  /// Преобразователь массива IWorkTreeElement объектов при JSON-сериализации, в том случае когда необходимо их проигнорировать
  /// </summary>
  public class DiagnosticsWorkTreeIgnoreConverter : JsonConverter
  {
    public static DiagnosticsWorkTreeIgnoreConverter Instance;
    private static DiagnosticsWorkTreeIgnoreConverter cnTqihEb0Okn5VRTBL40;

    public override bool CanConvert(Type objectType) => TypeOf<IEnumerable<IWorkTreeElement>>.Raw.IsAssignableFrom(objectType);

    public override bool CanRead => false;

    public override object ReadJson(
      JsonReader reader,
      Type objectType,
      object existingValue,
      JsonSerializer serializer)
    {
      throw new NotImplementedException();
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DiagnosticsWorkTreeIgnoreConverter.iOWb37EbJtyNRCXlj3UQ(DiagnosticsWorkTreeIgnoreConverter.yfvK2VEbMSUm5vwqaxNu((object) new object[0]), (object) writer, (object) Array.Empty<JsonConverter>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public DiagnosticsWorkTreeIgnoreConverter()
    {
      DiagnosticsWorkTreeIgnoreConverter.pfXkYhEb9ypOD8gAJOEI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DiagnosticsWorkTreeIgnoreConverter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DiagnosticsWorkTreeIgnoreConverter.Instance = new DiagnosticsWorkTreeIgnoreConverter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool doshMpEbm2y8X4ywls0K() => DiagnosticsWorkTreeIgnoreConverter.cnTqihEb0Okn5VRTBL40 == null;

    internal static DiagnosticsWorkTreeIgnoreConverter oFN0ZwEbyqJyaNBPthJN() => DiagnosticsWorkTreeIgnoreConverter.cnTqihEb0Okn5VRTBL40;

    internal static object yfvK2VEbMSUm5vwqaxNu([In] object obj0) => (object) JArray.FromObject(obj0);

    internal static void iOWb37EbJtyNRCXlj3UQ([In] object obj0, [In] object obj1, [In] object obj2) => ((JToken) obj0).WriteTo((JsonWriter) obj1, (JsonConverter[]) obj2);

    internal static void pfXkYhEb9ypOD8gAJOEI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
