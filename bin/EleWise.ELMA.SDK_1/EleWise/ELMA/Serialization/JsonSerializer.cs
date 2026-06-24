// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.JsonSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;

namespace EleWise.ELMA.Serialization
{
  public class JsonSerializer : JavaScriptSerializer
  {
    internal static JsonSerializer xcu5XSBgCZsVtkUb7soa;

    public JsonSerializer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector((JavaScriptTypeResolver) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected JsonSerializer(JavaScriptTypeResolver resolver)
    {
      JsonSerializer.qc0WcbBgZr3cgcpJiQWk();
      // ISSUE: explicit constructor call
      base.\u002Ector(resolver);
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            JsonSerializer.dTJgZHBgIsoDYeLe1M4U((object) this, int.MaxValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 2:
            this.RegisterConverters((IEnumerable<JavaScriptConverter>) new JsonSerializer.EntityConverter[1]
            {
              new JsonSerializer.EntityConverter()
            });
            num = 4;
            continue;
          case 3:
            this.RegisterConverters((IEnumerable<JavaScriptConverter>) new JsonSerializer.ExpandoObjectConverter[1]
            {
              new JsonSerializer.ExpandoObjectConverter()
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 2;
            continue;
          case 4:
            JsonSerializer.F7qJLFBguASSW6XRPMJm((object) this, int.MaxValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static bool AjiDqIBgvNbparPwnXFV() => JsonSerializer.xcu5XSBgCZsVtkUb7soa == null;

    internal static JsonSerializer w43SVsBg84nNQnitwUUV() => JsonSerializer.xcu5XSBgCZsVtkUb7soa;

    internal static void qc0WcbBgZr3cgcpJiQWk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void F7qJLFBguASSW6XRPMJm([In] object obj0, [In] int obj1) => ((JavaScriptSerializer) obj0).MaxJsonLength = obj1;

    internal static void dTJgZHBgIsoDYeLe1M4U([In] object obj0, [In] int obj1) => ((JavaScriptSerializer) obj0).RecursionLimit = obj1;

    private class ExpandoObjectConverter : JavaScriptConverter
    {
      internal static object yWmqVtQe1iWlFFOom48h;

      public override object Deserialize(
        IDictionary<string, object> dictionary,
        Type type,
        JavaScriptSerializer serializer)
      {
        ExpandoObject expandoObject = new ExpandoObject();
        IDictionary<string, object> dictionary1 = (IDictionary<string, object>) expandoObject;
        if (dictionary != null)
        {
          foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) dictionary)
            dictionary1[keyValuePair.Key] = keyValuePair.Value;
        }
        return (object) expandoObject;
      }

      public override IDictionary<string, object> Serialize(
        object obj,
        JavaScriptSerializer serializer)
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        if (obj is ExpandoObject expandoObject)
        {
          foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) expandoObject)
            dictionary[keyValuePair.Key] = keyValuePair.Value;
        }
        return (IDictionary<string, object>) dictionary;
      }

      public override IEnumerable<Type> SupportedTypes => (IEnumerable<Type>) new Type[1]
      {
        typeof (ExpandoObject)
      };

      public ExpandoObjectConverter()
      {
        JsonSerializer.ExpandoObjectConverter.yTLJYkQepkEmpYG4Arqd();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void yTLJYkQepkEmpYG4Arqd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool JpGN2pQeNJ0h0hRS2SSB() => JsonSerializer.ExpandoObjectConverter.yWmqVtQe1iWlFFOom48h == null;

      internal static JsonSerializer.ExpandoObjectConverter XNhrdVQe3uB5NBKUDXYa() => (JsonSerializer.ExpandoObjectConverter) JsonSerializer.ExpandoObjectConverter.yWmqVtQe1iWlFFOom48h;
    }

    private class EntityConverter : JavaScriptConverter
    {
      internal static object TSOEtOQeaaHx1jeGDXfC;

      public override object Deserialize(
        IDictionary<string, object> dictionary,
        Type type,
        JavaScriptSerializer serializer)
      {
        return InterfaceActivator.Create(type);
      }

      public override IDictionary<string, object> Serialize(
        object obj,
        JavaScriptSerializer serializer)
      {
        return obj is IEntity entity ? (IDictionary<string, object>) new EntityJsonSerializer().ConvertToSerializable((object) entity) : (IDictionary<string, object>) new Dictionary<string, object>();
      }

      public override IEnumerable<Type> SupportedTypes => (IEnumerable<Type>) new Type[4]
      {
        typeof (IEntity),
        typeof (Entity<short>),
        typeof (Entity<int>),
        typeof (Entity<long>)
      };

      public EntityConverter()
      {
        JsonSerializer.EntityConverter.MkfOVxQewiMpGcypKK8r();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void MkfOVxQewiMpGcypKK8r() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool WZqDW2QeDiDt8SMISRmO() => JsonSerializer.EntityConverter.TSOEtOQeaaHx1jeGDXfC == null;

      internal static JsonSerializer.EntityConverter aAmelWQet5rdRdD7M7u5() => (JsonSerializer.EntityConverter) JsonSerializer.EntityConverter.TSOEtOQeaaHx1jeGDXfC;
    }
  }
}
