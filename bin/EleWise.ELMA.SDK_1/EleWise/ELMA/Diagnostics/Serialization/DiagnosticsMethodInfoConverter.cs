// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Serialization.DiagnosticsMethodInfoConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Serialization
{
  /// <summary>
  /// Преобразователь аргументов метода при JSON-сериализации
  /// </summary>
  public class DiagnosticsMethodInfoConverter : JsonConverter
  {
    public static DiagnosticsMethodInfoConverter Instance;
    private static DiagnosticsMethodInfoConverter LBOdo9Ebd3dGe1pOR0Bw;

    public override bool CanConvert(Type objectType) => TypeOf<MethodInfo>.Raw.IsAssignableFrom(objectType);

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
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        ParameterInfo[] parameters;
        MethodInfo methodInfo;
        JObject jobject1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!DiagnosticsMethodInfoConverter.gvsf76Ebg6K56Hd1hlH9((object) methodInfo, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 2:
              methodInfo = value as MethodInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_8;
            case 4:
            case 6:
              goto label_6;
            case 5:
            case 10:
              DiagnosticsMethodInfoConverter.eSjoMmEhoXxc7YRKoY7y((object) jobject1, (object) writer, (object) Array.Empty<JsonConverter>());
              num2 = 8;
              continue;
            case 7:
              if (parameters.Length == 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 4 : 3;
                continue;
              }
              goto case 11;
            case 8:
              goto label_15;
            case 9:
              parameters = methodInfo.GetParameters();
              num2 = 7;
              continue;
            case 11:
              // ISSUE: object of a compiler-generated type is created
              DiagnosticsMethodInfoConverter.y4PX0OEbcb9UFEyre6uD((object) jobject1, DiagnosticsMethodInfoConverter.ou9wjhEbYmAwv4OwEbDs(1925118608 << 2 ^ -889208548), DiagnosticsMethodInfoConverter.zSrOHVEhFBTluFvo0N2W((object) ((IEnumerable<ParameterInfo>) parameters).Select(p => new \u003C\u003Ef__AnonymousType1<string, Type>(p.Name, p.ParameterType))));
              num2 = 6;
              continue;
            case 12:
              goto label_14;
            default:
              goto label_16;
          }
        }
label_6:
        if (!DiagnosticsMethodInfoConverter.ToAu8yEhB2WkHgUe15M2((object) methodInfo))
        {
          num1 = 5;
          continue;
        }
label_14:
        DiagnosticsMethodInfoConverter.y4PX0OEbcb9UFEyre6uD((object) jobject1, DiagnosticsMethodInfoConverter.ou9wjhEbYmAwv4OwEbDs(~210725948 ^ -210453489), DiagnosticsMethodInfoConverter.zSrOHVEhFBTluFvo0N2W(DiagnosticsMethodInfoConverter.eU4yQwEhWhVvG3MEFyHI((object) methodInfo)));
        num1 = 10;
        continue;
label_16:
        JObject jobject2 = new JObject();
        jobject2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272603829), (JToken) DiagnosticsMethodInfoConverter.rHxMaJEbjOI5lNuLmfuO(DiagnosticsMethodInfoConverter.exskctEb5NQrSqbpUhfd((object) methodInfo)));
        jobject2.Add((string) DiagnosticsMethodInfoConverter.ou9wjhEbYmAwv4OwEbDs(901793403 ^ 901903915), JToken.FromObject(DiagnosticsMethodInfoConverter.OlLYgfEbLeWeYmVAXwcy((object) methodInfo) != (Type) null ? DiagnosticsMethodInfoConverter.OXaZ2xEbUO2RS5cx2kjK((object) DiagnosticsMethodInfoConverter.OlLYgfEbLeWeYmVAXwcy((object) methodInfo).Assembly) : (object) ""));
        DiagnosticsMethodInfoConverter.y4PX0OEbcb9UFEyre6uD((object) jobject2, DiagnosticsMethodInfoConverter.ou9wjhEbYmAwv4OwEbDs(222162814 ^ 222058364), (object) JToken.FromObject(DiagnosticsMethodInfoConverter.LHR4hwEbsfb9C6Oe52UH(methodInfo.DeclaringType, (Type) null) ? (object) DiagnosticsMethodInfoConverter.OlLYgfEbLeWeYmVAXwcy((object) methodInfo).FullName : (object) ""));
        DiagnosticsMethodInfoConverter.y4PX0OEbcb9UFEyre6uD((object) jobject2, DiagnosticsMethodInfoConverter.ou9wjhEbYmAwv4OwEbDs(1178210108 ^ 1178476680), DiagnosticsMethodInfoConverter.rHxMaJEbjOI5lNuLmfuO((object) DiagnosticsMethodInfoConverter.HaxgXqEbzNCTP8Brsfa5((object) methodInfo).FullName));
        jobject1 = jobject2;
        num1 = 9;
      }
label_8:
      return;
label_15:
      return;
label_12:;
    }

    public DiagnosticsMethodInfoConverter()
    {
      DiagnosticsMethodInfoConverter.sSsLcZEhbI4s7Z0HN8UA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DiagnosticsMethodInfoConverter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DiagnosticsMethodInfoConverter.sSsLcZEhbI4s7Z0HN8UA();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DiagnosticsMethodInfoConverter.Instance = new DiagnosticsMethodInfoConverter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool iC2SSEEbl1JeenM1HoTD() => DiagnosticsMethodInfoConverter.LBOdo9Ebd3dGe1pOR0Bw == null;

    internal static DiagnosticsMethodInfoConverter IhCOQ0EbrylycCIuPBrn() => DiagnosticsMethodInfoConverter.LBOdo9Ebd3dGe1pOR0Bw;

    internal static bool gvsf76Ebg6K56Hd1hlH9([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object exskctEb5NQrSqbpUhfd([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object rHxMaJEbjOI5lNuLmfuO([In] object obj0) => (object) JToken.FromObject(obj0);

    internal static object ou9wjhEbYmAwv4OwEbDs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type OlLYgfEbLeWeYmVAXwcy([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object OXaZ2xEbUO2RS5cx2kjK([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static bool LHR4hwEbsfb9C6Oe52UH([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static void y4PX0OEbcb9UFEyre6uD([In] object obj0, [In] object obj1, [In] object obj2) => ((JObject) obj0).Add((string) obj1, (JToken) obj2);

    internal static Type HaxgXqEbzNCTP8Brsfa5([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static object zSrOHVEhFBTluFvo0N2W([In] object obj0) => (object) JArray.FromObject(obj0);

    internal static bool ToAu8yEhB2WkHgUe15M2([In] object obj0) => ((MethodBase) obj0).IsGenericMethod;

    internal static object eU4yQwEhWhVvG3MEFyHI([In] object obj0) => (object) ((MethodBase) obj0).GetGenericArguments();

    internal static void eSjoMmEhoXxc7YRKoY7y([In] object obj0, [In] object obj1, [In] object obj2) => ((JToken) obj0).WriteTo((JsonWriter) obj1, (JsonConverter[]) obj2);

    internal static void sSsLcZEhbI4s7Z0HN8UA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
