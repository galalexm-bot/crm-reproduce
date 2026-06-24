// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTransformationSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  public class ViewItemTransformationSerializer : JsonSerializer
  {
    internal static ViewItemTransformationSerializer vwLx7So1D0IkKWQ4lSks;

    public ViewItemTransformationSerializer()
    {
      ViewItemTransformationSerializer.lShH75o14LpO7MZJCKZ6();
      // ISSUE: explicit constructor call
      base.\u002Ector((JavaScriptTypeResolver) new ViewItemTransformationSerializer.CustomTypeResolver());
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.RegisterConverters((IEnumerable<JavaScriptConverter>) new JavaScriptConverter[2]
            {
              (JavaScriptConverter) new ViewItemTransformationSerializer.FormViewItemTransformationConverter(),
              (JavaScriptConverter) new ViewItemTransformationSerializer.FormViewItemConverter()
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void lShH75o14LpO7MZJCKZ6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SCtYCWo1tcj387QBAFPI() => ViewItemTransformationSerializer.vwLx7So1D0IkKWQ4lSks == null;

    internal static ViewItemTransformationSerializer Gk4KSIo1wVWDed5DS1YO() => ViewItemTransformationSerializer.vwLx7So1D0IkKWQ4lSks;

    private class FormViewItemTransformationConverter : JavaScriptConverter
    {
      internal static object Iu5nHpCCtwpWSHxXMq5X;

      public override IEnumerable<Type> SupportedTypes => (IEnumerable<Type>) new Type[1]
      {
        typeof (FormViewItemTransformation)
      };

      public override object Deserialize(
        IDictionary<string, object> dictionary,
        Type type,
        JavaScriptSerializer serializer)
      {
        FormViewItemTransformation transformation = (FormViewItemTransformation) Activator.CreateInstance(type);
        if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236078685)))
          transformation.Uid = new Guid(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360358799)].ToString());
        if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538754318)))
          transformation.NewFormUid = new Guid(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978709521)].ToString());
        if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112410006)))
          transformation.FormName = (string) dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822589724)];
        if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909469809)))
          transformation.NewFormDisplayName = (string) dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69837795)];
        if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459261415)))
          transformation.NewFormName = (string) dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236434167)];
        if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767893991)))
          ((IEnumerable) dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319628254)]).Cast<object>().Each<object>((Action<object>) (i =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  transformation.Items.Add(serializer.ConvertToType<ViewItemTransformation>(i));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
        return (object) transformation;
      }

      public override IDictionary<string, object> Serialize(
        object obj,
        JavaScriptSerializer serializer)
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        if (obj is FormViewItemTransformation itemTransformation)
        {
          if (itemTransformation.Uid != Guid.Empty)
            dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372747195)] = (object) itemTransformation.Uid.ToString();
          if (itemTransformation.NewFormUid != Guid.Empty)
            dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514791373)] = (object) itemTransformation.NewFormUid.ToString();
          if (!string.IsNullOrEmpty(itemTransformation.FormName))
            dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642698308)] = (object) itemTransformation.FormName;
          if (!string.IsNullOrEmpty(itemTransformation.NewFormDisplayName))
            dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124276638)] = (object) itemTransformation.NewFormDisplayName;
          if (!string.IsNullOrEmpty(itemTransformation.NewFormName))
            dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998246910)] = (object) itemTransformation.NewFormName;
          if (itemTransformation.Items.Any<ViewItemTransformation>())
            dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477249480)] = (object) itemTransformation.Items;
        }
        return (IDictionary<string, object>) dictionary;
      }

      public FormViewItemTransformationConverter()
      {
        ViewItemTransformationSerializer.FormViewItemTransformationConverter.vFboewCC6DaVdWtkxxxj();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void vFboewCC6DaVdWtkxxxj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool W6waurCCwK5EeTXvhHJO() => ViewItemTransformationSerializer.FormViewItemTransformationConverter.Iu5nHpCCtwpWSHxXMq5X == null;

      internal static ViewItemTransformationSerializer.FormViewItemTransformationConverter nytYxxCC41GXXnw0lKMQ() => (ViewItemTransformationSerializer.FormViewItemTransformationConverter) ViewItemTransformationSerializer.FormViewItemTransformationConverter.Iu5nHpCCtwpWSHxXMq5X;
    }

    private class FormViewItemConverter : JavaScriptConverter
    {
      private static object IFPyF1CCHu5ArX61dWwe;

      public override IEnumerable<Type> SupportedTypes => (IEnumerable<Type>) new Type[1]
      {
        typeof (ViewItem)
      };

      public override object Deserialize(
        IDictionary<string, object> dictionary,
        Type type,
        JavaScriptSerializer serializer)
      {
        ViewItem instance = (ViewItem) Activator.CreateInstance(type);
        foreach (PropertyInfo propertyInfo in ((IEnumerable<PropertyInfo>) instance.GetType().GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo) p, true) == null)))
        {
          if (propertyInfo.CanWrite && dictionary.ContainsKey(propertyInfo.Name))
            propertyInfo.SetValue((object) instance, serializer.ConvertToType(dictionary[propertyInfo.Name], propertyInfo.PropertyType), (object[]) null);
        }
        RootViewItem rootViewItem = instance as RootViewItem;
        if (rootViewItem != null && dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372599243)))
          ((IEnumerable) dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108136964)]).Cast<object>().Each<object>((Action<object>) (i =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  ((EventedList<ViewItem>) ViewItemTransformationSerializer.FormViewItemConverter.\u003C\u003Ec__DisplayClass2_0.nX6iN1ZIYuDOTmvYOcWW((object) rootViewItem)).Add(serializer.ConvertToType<ViewItem>(i));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
        return (object) instance;
      }

      public override IDictionary<string, object> Serialize(
        object obj,
        JavaScriptSerializer serializer)
      {
        Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
        Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
        if (!(obj is ViewItem viewItem))
          return (IDictionary<string, object>) dictionary1;
        foreach (PropertyInfo propertyInfo in ((IEnumerable<PropertyInfo>) viewItem.GetType().GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo) p, true) == null)).ToList<PropertyInfo>())
        {
          if (propertyInfo.CanRead)
          {
            DefaultValueAttribute attribute = AttributeHelper<DefaultValueAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            object source = propertyInfo.GetValue((object) viewItem, (object[]) null);
            Func<object, object, bool> func = (Func<object, object, bool>) ((v1, v2) =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    if (v1 == null)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              return v2 == null;
label_5:
              return v1.Equals(v2);
            });
            if ((attribute == null || !func(attribute.Value, source)) && (!(source is IEnumerable) || ((IEnumerable) source).Cast<object>().Any<object>()))
              dictionary1[propertyInfo.Name] = source;
            dictionary2[propertyInfo.Name] = source;
          }
        }
        return (IDictionary<string, object>) dictionary1;
      }

      public FormViewItemConverter()
      {
        ViewItemTransformationSerializer.FormViewItemConverter.GPnMavCCxw8xW90LLNyY();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void GPnMavCCxw8xW90LLNyY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool HcHASECCAvO1Ly4YnUnR() => ViewItemTransformationSerializer.FormViewItemConverter.IFPyF1CCHu5ArX61dWwe == null;

      internal static ViewItemTransformationSerializer.FormViewItemConverter vcEy4ZCC7pen50tfA52N() => (ViewItemTransformationSerializer.FormViewItemConverter) ViewItemTransformationSerializer.FormViewItemConverter.IFPyF1CCHu5ArX61dWwe;
    }

    private class CustomTypeResolver : SimpleTypeResolver
    {
      internal static object pyGeEcCC0KPArJ9pMgvG;

      public override Type ResolveType(string id) => base.ResolveType(id);

      public override string ResolveTypeId(Type type) => base.ResolveTypeId(type);

      public CustomTypeResolver()
      {
        ViewItemTransformationSerializer.CustomTypeResolver.PdfJLECCMPCuVJvxjM5m();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool SKwaNECCmG4Is23AiHXt() => ViewItemTransformationSerializer.CustomTypeResolver.pyGeEcCC0KPArJ9pMgvG == null;

      internal static ViewItemTransformationSerializer.CustomTypeResolver uNv5GuCCyPwLwyq3mgKh() => (ViewItemTransformationSerializer.CustomTypeResolver) ViewItemTransformationSerializer.CustomTypeResolver.pyGeEcCC0KPArJ9pMgvG;

      internal static void PdfJLECCMPCuVJvxjM5m() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
