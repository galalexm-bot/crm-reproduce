// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.PrivateReflectionDynamicObjectExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Use private members via dynamic
  /// 
  /// code from http://blogs.msdn.com/b/davidebb/archive/2010/01/18/use-c-4-0-dynamic-to-drastically-simplify-your-private-reflection-code.aspx
  /// 
  /// </summary>
  public static class PrivateReflectionDynamicObjectExtensions
  {
    public static object AsDynamic(this object o) => PrivateReflectionDynamicObjectExtensions.PnlUA7GA2UHvJxhTh57t(o);

    internal static object PnlUA7GA2UHvJxhTh57t([In] object obj0) => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.WrapObjectIfNeeded(obj0);

    internal class PrivateReflectionDynamicObject : DynamicObject
    {
      private static readonly IDictionary<Type, IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty>> PropertiesOnType;
      private static PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject RKcbxC8frXgZ113DVgsF;

      private object RealObject
      {
        get => this.\u003CRealObject\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CRealObject\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      internal static object WrapObjectIfNeeded(object o)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (o != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            case 3:
              if (!(o is string))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 4 : 2;
                continue;
              }
              goto label_4;
            case 4:
              goto label_5;
            default:
              if (!o.GetType().IsPrimitive)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 3;
                continue;
              }
              goto label_4;
          }
        }
label_4:
        return o;
label_5:
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject reflectionDynamicObject = new PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject();
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.iSvSWn8fjYSxg679mcMO((object) reflectionDynamicObject, o);
        return (object) reflectionDynamicObject;
      }

      public override bool TryGetMember(GetMemberBinder binder, out object result)
      {
        int num = 2;
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty property;
        while (true)
        {
          switch (num)
          {
            case 1:
              result = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.iTxc3y8fYYTTq30iDS5W((object) property, this.RealObject, (object) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            case 2:
              property = this.GetProperty(binder.Name);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              result = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.MqBnP98fLud7rNdbLvdd(result);
              num = 3;
              continue;
          }
        }
label_2:
        return true;
      }

      public override bool TrySetMember(SetMemberBinder binder, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.OaTwIX8fs3GSQ7mibcFg((object) this.GetProperty((string) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.FJEWeT8fU3MK1x1CO60l((object) binder)), this.RealObject, value, (object) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return true;
      }

      public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
      {
        int num = 2;
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty indexProperty;
        while (true)
        {
          switch (num)
          {
            case 1:
              result = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.iTxc3y8fYYTTq30iDS5W((object) indexProperty, this.RealObject, (object) indexes);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            case 2:
              indexProperty = this.GetIndexProperty();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              result = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.WrapObjectIfNeeded(result);
              num = 3;
              continue;
          }
        }
label_3:
        return true;
      }

      public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.GetIndexProperty().SetValue(this.RealObject, value, indexes);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return true;
      }

      public override bool TryInvokeMember(
        InvokeMemberBinder binder,
        object[] args,
        out object result)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              result = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.MqBnP98fLud7rNdbLvdd(result);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 2:
              result = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.KxBg7g8fz5HPiF86oeNd(this.RealObject.GetType(), this.RealObject, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.nblhP08fc6YMdLDFy7lr((object) binder), (object) args);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return true;
      }

      public override bool TryConvert(ConvertBinder binder, out object result)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              result = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.eoqiJE8QBSL3BGEyaNjM(this.RealObject, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.jaf9eN8QF5XwQcN93Dur((object) binder));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return true;
      }

      public override string ToString() => this.RealObject.ToString();

      private PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty GetIndexProperty() => this.GetProperty((string) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.WUWAve8QWWBdM6V3yeiU(-138018305 ^ -138016623));

      private PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty GetProperty(
        string propertyName)
      {
        int num = 3;
        IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty> typeProperties;
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty property;
        IOrderedEnumerable<string> values;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              IEnumerable<string> source = typeProperties.Keys.Where<string>((Func<string, bool>) (name => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.\u003C\u003Ec.NMItdmZnyD4KnOUntW98((object) name, 0) != '<'));
              // ISSUE: reference to a compiler-generated field
              Func<string, string> func = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.\u003C\u003Ec.\u003C\u003E9__18_1;
              Func<string, string> keySelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.\u003C\u003Ec.\u003C\u003E9__18_1 = keySelector = (Func<string, string>) (name => name);
              }
              else
                goto label_2;
label_10:
              values = source.OrderBy<string, string>(keySelector);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
label_2:
              keySelector = func;
              goto label_10;
            case 2:
              if (!typeProperties.TryGetValue(propertyName, out property))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                continue;
              }
              goto label_7;
            case 3:
              typeProperties = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.GetTypeProperties(this.RealObject.GetType());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_6;
          }
        }
label_6:
        throw new ArgumentException((string) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.t8tSp28QoavwpRI0NKgN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195890281), (object) propertyName, (object) this.RealObject.GetType(), (object) string.Join((string) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.WUWAve8QWWBdM6V3yeiU(-2106517564 ^ -2106516538), (IEnumerable<string>) values)));
label_7:
        return property;
      }

      private static IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty> GetTypeProperties(
        Type type)
      {
        IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty> typeProperties1;
        if (PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.PropertiesOnType.TryGetValue(type, out typeProperties1))
          return typeProperties1;
        IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty> typeProperties2 = (IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty>) new ConcurrentDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty>();
        // ISSUE: reference to a compiler-generated method
        foreach (PropertyInfo propertyInfo in ((IEnumerable<PropertyInfo>) type.GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.\u003C\u003Ec__DisplayClass19_0.np57IWZnlN4InbDxX15X(p.DeclaringType, type))))
          typeProperties2[propertyInfo.Name] = (PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty) new PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property()
          {
            PropertyInfo = propertyInfo
          };
        // ISSUE: reference to a compiler-generated method
        foreach (FieldInfo fieldInfo in ((IEnumerable<FieldInfo>) type.GetReflectionFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)).Where<FieldInfo>((Func<FieldInfo, bool>) (p => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.\u003C\u003Ec__DisplayClass19_0.np57IWZnlN4InbDxX15X(p.DeclaringType, type))))
          typeProperties2[fieldInfo.Name] = (PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty) new PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field()
          {
            FieldInfo = fieldInfo
          };
        if (type.BaseType != (Type) null)
        {
          foreach (PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty property in (IEnumerable<PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty>) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.GetTypeProperties(type.BaseType).Values)
            typeProperties2[property.Name] = property;
        }
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.PropertiesOnType[type] = typeProperties2;
        return typeProperties2;
      }

      private static object InvokeMemberOnType(Type type, object target, object name, object args)
      {
        object obj;
        switch (1)
        {
          case 1:
            try
            {
              obj = type.InvokeMember((string) name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, (Binder) null, target, (object[]) args);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                num = 0;
              switch (num)
              {
              }
            }
            catch (MissingMethodException ex)
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    if (PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.teuLqY8Qb8hAiHIEhWtM(type.BaseType, (Type) null))
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_11;
                  case 2:
                    goto label_1;
                  case 3:
                    goto label_11;
                  default:
                    obj = PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.KxBg7g8fz5HPiF86oeNd(type.BaseType, target, name, args);
                    num = 2;
                    continue;
                }
              }
label_11:
              throw;
            }
            break;
        }
label_1:
        return obj;
      }

      public PrivateReflectionDynamicObject()
      {
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.njOn3c8QhomIWFtVF4Cm();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static PrivateReflectionDynamicObject()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.PropertiesOnType = (IDictionary<Type, IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty>>) new ConcurrentDictionary<Type, IDictionary<string, PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty>>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            case 2:
              PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.njOn3c8QhomIWFtVF4Cm();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static bool IHUE7f8fgnBFtwaDHxuX() => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.RKcbxC8frXgZ113DVgsF == null;

      internal static PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject Esv0Ll8f56OhdhqrCi4m() => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.RKcbxC8frXgZ113DVgsF;

      internal static void iSvSWn8fjYSxg679mcMO([In] object obj0, [In] object obj1) => ((PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject) obj0).RealObject = obj1;

      internal static object iTxc3y8fYYTTq30iDS5W([In] object obj0, [In] object obj1, [In] object obj2) => ((PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty) obj0).GetValue(obj1, (object[]) obj2);

      internal static object MqBnP98fLud7rNdbLvdd([In] object obj0) => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.WrapObjectIfNeeded(obj0);

      internal static object FJEWeT8fU3MK1x1CO60l([In] object obj0) => (object) ((SetMemberBinder) obj0).Name;

      internal static void OaTwIX8fs3GSQ7mibcFg(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3)
      {
        ((PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty) obj0).SetValue(obj1, obj2, (object[]) obj3);
      }

      internal static object nblhP08fc6YMdLDFy7lr([In] object obj0) => (object) ((InvokeMemberBinder) obj0).Name;

      internal static object KxBg7g8fz5HPiF86oeNd(
        Type type,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3)
      {
        return PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.InvokeMemberOnType(type, obj1, obj2, obj3);
      }

      internal static Type jaf9eN8QF5XwQcN93Dur([In] object obj0) => ((ConvertBinder) obj0).Type;

      internal static object eoqiJE8QBSL3BGEyaNjM([In] object obj0, [In] Type obj1) => Convert.ChangeType(obj0, obj1);

      internal static object WUWAve8QWWBdM6V3yeiU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object t8tSp28QoavwpRI0NKgN(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3)
      {
        return (object) string.Format((string) obj0, obj1, obj2, obj3);
      }

      internal static bool teuLqY8Qb8hAiHIEhWtM([In] Type obj0, [In] Type obj1) => obj0 != obj1;

      internal static void njOn3c8QhomIWFtVF4Cm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      private interface IProperty
      {
        string Name { get; }

        object GetValue(object obj, object[] index);

        void SetValue(object obj, object val, object[] index);
      }

      private class Property : 
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty
      {
        internal static object gpE8WsZnPrFyxuUnnSUM;

        internal PropertyInfo PropertyInfo
        {
          get => this.\u003CPropertyInfo\u003Ek__BackingField;
          set
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  this.\u003CPropertyInfo\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }
        }

        string PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty.Name => (string) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property.skO2dhZn3ID4QWCw3CJx((object) this.PropertyInfo);

        object PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty.GetValue(
          object obj,
          object[] index)
        {
          return PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property.bwxU4pZnpJWRw0wjZjFq((object) this.PropertyInfo, obj, (object) index);
        }

        void PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty.SetValue(
          object obj,
          object val,
          object[] index)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.PropertyInfo.SetValue(obj, val, index);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        public Property()
        {
          PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property.wHyqGEZnavDE8rcSSPUy();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool y3NsMfZn1MdQimu4vBKs() => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property.gpE8WsZnPrFyxuUnnSUM == null;

        internal static PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property aqZFt3ZnNXtPWbnHsUfB() => (PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Property.gpE8WsZnPrFyxuUnnSUM;

        internal static object skO2dhZn3ID4QWCw3CJx([In] object obj0) => (object) ((MemberInfo) obj0).Name;

        internal static object bwxU4pZnpJWRw0wjZjFq([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

        internal static void wHyqGEZnavDE8rcSSPUy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }

      private class Field : 
        PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty
      {
        private static object ISQeLYZnDU2DEhSLqb4r;

        internal FieldInfo FieldInfo
        {
          get => this.\u003CFieldInfo\u003Ek__BackingField;
          set
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  this.\u003CFieldInfo\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }
        }

        string PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty.Name => (string) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field.TOKy2oZn4iRCoD37ldHY((object) this.FieldInfo);

        object PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty.GetValue(
          object obj,
          object[] index)
        {
          return PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field.ujjodVZn6mt3dZ9AZ2U1((object) this.FieldInfo, obj);
        }

        void PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.IProperty.SetValue(
          object obj,
          object val,
          object[] index)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field.iw0owKZnHpmqTkygRqo0((object) this.FieldInfo, obj, val);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        public Field()
        {
          PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field.zdOXaPZnAgojOr7apoA2();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool vlE2bVZntHTl4FHscUtd() => PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field.ISQeLYZnDU2DEhSLqb4r == null;

        internal static PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field m4nIpuZnw6wOXqE91e5q() => (PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field) PrivateReflectionDynamicObjectExtensions.PrivateReflectionDynamicObject.Field.ISQeLYZnDU2DEhSLqb4r;

        internal static object TOKy2oZn4iRCoD37ldHY([In] object obj0) => (object) ((MemberInfo) obj0).Name;

        internal static object ujjodVZn6mt3dZ9AZ2U1([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

        internal static void iw0owKZnHpmqTkygRqo0([In] object obj0, [In] object obj1, [In] object obj2) => ((FieldInfo) obj0).SetValue(obj1, obj2);

        internal static void zdOXaPZnAgojOr7apoA2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }
    }
  }
}
