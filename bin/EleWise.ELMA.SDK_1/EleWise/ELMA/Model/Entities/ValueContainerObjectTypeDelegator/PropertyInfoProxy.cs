// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.PropertyInfoProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  internal class PropertyInfoProxy : PropertyInfo
  {
    private readonly PropertyInfo propertyInfo;
    internal static PropertyInfoProxy YbhiOEhSbN8n6dh4gwqR;

    public PropertyInfoProxy(PropertyInfo propertyInfo, Type declaringType = null, Type reflectedType = null)
    {
      PropertyInfoProxy.UkZy5dhSEhE5TFqsLxkl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            Type type1 = reflectedType;
            if ((object) type1 == null)
              type1 = PropertyInfoProxy.NOTwZghSQRkHKBAUoWEE((object) propertyInfo);
            this.ReflectedType = type1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
          case 3:
            Type type2 = declaringType;
            if ((object) type2 == null)
              type2 = PropertyInfoProxy.QZuSkVhSfWnKeNCcXxa9((object) propertyInfo);
            this.DeclaringType = type2;
            num = 2;
            continue;
          default:
            this.propertyInfo = !(propertyInfo is PropertyInfoProxy propertyInfoProxy) ? propertyInfo : propertyInfoProxy.propertyInfo;
            num = 3;
            continue;
        }
      }
label_4:;
    }

    public override Type DeclaringType { get; }

    public override Type ReflectedType { get; }

    public override PropertyAttributes Attributes => PropertyInfoProxy.VDpeLmhSCY8kLPlRpkfj((object) this.propertyInfo);

    public override bool CanRead => PropertyInfoProxy.TtZN41hSvnX4UyaPHkqB((object) this.propertyInfo);

    public override bool CanWrite => PropertyInfoProxy.bawNqyhS89qDgEDBaH2a((object) this.propertyInfo);

    public override string Name => (string) PropertyInfoProxy.JE3fQjhSZM0NtiDGVFY7((object) this.propertyInfo);

    public override Type PropertyType => PropertyInfoProxy.wXKbxThSuDIcM9vnv6T0((object) this.propertyInfo);

    public override Module Module => (Module) PropertyInfoProxy.OVVdNahSIEWLNfh52aJS((object) this.propertyInfo);

    public override object GetValue(
      object obj,
      BindingFlags invokeAttr,
      Binder binder,
      object[] index,
      CultureInfo culture)
    {
      return PropertyInfoProxy.tU8mRuhSVRo5Q37AdSZv((object) this.propertyInfo, obj, invokeAttr, (object) binder, (object) index, (object) culture);
    }

    public override void SetValue(
      object obj,
      object value,
      BindingFlags invokeAttr,
      Binder binder,
      object[] index,
      CultureInfo culture)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PropertyInfoProxy.CH8vlohSSI1wJlGtv9Ia((object) this.propertyInfo, obj, value, invokeAttr, (object) binder, (object) index, (object) culture);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override ParameterInfo[] GetIndexParameters() => (ParameterInfo[]) PropertyInfoProxy.OWjxqNhSipJSjymLN1VG((object) this.propertyInfo);

    public override MethodInfo GetGetMethod(bool nonPublic) => (MethodInfo) new PropertyInfoProxy.MethodInfoProxy((MethodInfo) PropertyInfoProxy.S83YLXhSRygxhR5MsMe3((object) this.propertyInfo, nonPublic), PropertyInfoProxy.QZuSkVhSfWnKeNCcXxa9((object) this), PropertyInfoProxy.NOTwZghSQRkHKBAUoWEE((object) this));

    public override MethodInfo GetSetMethod(bool nonPublic) => (MethodInfo) new PropertyInfoProxy.MethodInfoProxy((MethodInfo) PropertyInfoProxy.AQt9nAhSqTkMKHF5GNAP((object) this.propertyInfo, nonPublic), PropertyInfoProxy.QZuSkVhSfWnKeNCcXxa9((object) this), PropertyInfoProxy.NOTwZghSQRkHKBAUoWEE((object) this));

    public override MethodInfo[] GetAccessors(bool nonPublic)
    {
      int num = 1;
      MethodInfo[] array;
      while (true)
      {
        switch (num)
        {
          case 1:
            array = (MethodInfo[]) ((IEnumerable<MethodInfo>) PropertyInfoProxy.gRVX6ehSKZ1ost5ivk0R((object) this.propertyInfo, nonPublic)).Select<MethodInfo, PropertyInfoProxy.MethodInfoProxy>((Func<MethodInfo, PropertyInfoProxy.MethodInfoProxy>) (m => new PropertyInfoProxy.MethodInfoProxy(m, this.DeclaringType, PropertyInfoProxy.NOTwZghSQRkHKBAUoWEE((object) this)))).ToArray<PropertyInfoProxy.MethodInfoProxy>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return array;
    }

    public override string ToString() => this.propertyInfo.ToString();

    public override IList<CustomAttributeData> GetCustomAttributesData() => this.propertyInfo.GetCustomAttributesData();

    public override bool IsDefined(Type attributeType, bool inherit) => PropertyInfoProxy.Er1tuLhSXZkp1fHbeS8I((object) this.propertyInfo, attributeType, inherit);

    public override object[] GetCustomAttributes(bool inherit) => this.propertyInfo.GetCustomAttributes(inherit);

    public override object[] GetCustomAttributes(Type attributeType, bool inherit) => (object[]) PropertyInfoProxy.MCU8gshSTLmN4ndWgtaY((object) this.propertyInfo, attributeType, inherit);

    internal static void UkZy5dhSEhE5TFqsLxkl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type QZuSkVhSfWnKeNCcXxa9([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static Type NOTwZghSQRkHKBAUoWEE([In] object obj0) => ((MemberInfo) obj0).ReflectedType;

    internal static bool CglsBahShFr8UkmMLIN2() => PropertyInfoProxy.YbhiOEhSbN8n6dh4gwqR == null;

    internal static PropertyInfoProxy ax1vlxhSGtTfD61e7IRA() => PropertyInfoProxy.YbhiOEhSbN8n6dh4gwqR;

    internal static PropertyAttributes VDpeLmhSCY8kLPlRpkfj([In] object obj0) => ((PropertyInfo) obj0).Attributes;

    internal static bool TtZN41hSvnX4UyaPHkqB([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static bool bawNqyhS89qDgEDBaH2a([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static object JE3fQjhSZM0NtiDGVFY7([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Type wXKbxThSuDIcM9vnv6T0([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object OVVdNahSIEWLNfh52aJS([In] object obj0) => (object) ((MemberInfo) obj0).Module;

    internal static object tU8mRuhSVRo5Q37AdSZv(
      [In] object obj0,
      [In] object obj1,
      [In] BindingFlags obj2,
      [In] object obj3,
      [In] object obj4,
      [In] object obj5)
    {
      return ((PropertyInfo) obj0).GetValue(obj1, obj2, (Binder) obj3, (object[]) obj4, (CultureInfo) obj5);
    }

    internal static void CH8vlohSSI1wJlGtv9Ia(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] BindingFlags obj3,
      [In] object obj4,
      [In] object obj5,
      [In] object obj6)
    {
      ((PropertyInfo) obj0).SetValue(obj1, obj2, obj3, (Binder) obj4, (object[]) obj5, (CultureInfo) obj6);
    }

    internal static object OWjxqNhSipJSjymLN1VG([In] object obj0) => (object) ((PropertyInfo) obj0).GetIndexParameters();

    internal static object S83YLXhSRygxhR5MsMe3([In] object obj0, [In] bool obj1) => (object) ((PropertyInfo) obj0).GetGetMethod(obj1);

    internal static object AQt9nAhSqTkMKHF5GNAP([In] object obj0, [In] bool obj1) => (object) ((PropertyInfo) obj0).GetSetMethod(obj1);

    internal static object gRVX6ehSKZ1ost5ivk0R([In] object obj0, [In] bool obj1) => (object) ((PropertyInfo) obj0).GetAccessors(obj1);

    internal static bool Er1tuLhSXZkp1fHbeS8I([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

    internal static object MCU8gshSTLmN4ndWgtaY([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    private class MethodInfoProxy : MethodInfo
    {
      private readonly object methodInfo;
      internal static object eqlU7lvByh2f2ZussRI1;

      public MethodInfoProxy(MethodInfo methodInfo, Type declaringType, Type reflectedType)
      {
        PropertyInfoProxy.MethodInfoProxy.xS8hl6vB9LEpEvO0igl9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.DeclaringType = declaringType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 2:
              this.methodInfo = (object) methodInfo;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_2;
            default:
              this.ReflectedType = reflectedType;
              num = 3;
              continue;
          }
        }
label_2:;
      }

      public override Type DeclaringType { get; }

      public override Type ReflectedType { get; }

      public override string Name => (string) PropertyInfoProxy.MethodInfoProxy.pihNNUvBdueeNWlL7VA6(this.methodInfo);

      public override MethodAttributes Attributes => PropertyInfoProxy.MethodInfoProxy.cuGAy4vBlLtIi15O29tX(this.methodInfo);

      public override CallingConventions CallingConvention => ((MethodBase) this.methodInfo).CallingConvention;

      public override IEnumerable<CustomAttributeData> CustomAttributes => ((MemberInfo) this.methodInfo).CustomAttributes;

      public override bool IsSecurityCritical => ((MethodBase) this.methodInfo).IsSecurityCritical;

      public override bool IsSecuritySafeCritical => PropertyInfoProxy.MethodInfoProxy.TZM26cvBrwkQJY6hgs8E(this.methodInfo);

      public override bool IsSecurityTransparent => PropertyInfoProxy.MethodInfoProxy.L196EGvBge0P6opEoTVk(this.methodInfo);

      public override MethodImplAttributes MethodImplementationFlags => PropertyInfoProxy.MethodInfoProxy.hcZAZ1vB5WdbdojFlaFn(this.methodInfo);

      public override MethodImplAttributes GetMethodImplementationFlags() => ((MethodBase) this.methodInfo).GetMethodImplementationFlags();

      public override Type ReturnType => ((MethodInfo) this.methodInfo).ReturnType;

      public override ParameterInfo ReturnParameter => (ParameterInfo) PropertyInfoProxy.MethodInfoProxy.VqUKt6vBjac9jvsl3LXS(this.methodInfo);

      public override ParameterInfo[] GetParameters() => (ParameterInfo[]) PropertyInfoProxy.MethodInfoProxy.EijOUovBY6CA1jo4Pemp(this.methodInfo);

      public override object Invoke(
        object obj,
        BindingFlags invokeAttr,
        Binder binder,
        object[] parameters,
        CultureInfo culture)
      {
        return PropertyInfoProxy.MethodInfoProxy.bZCPZlvBLJPx2pb4JZb2(this.methodInfo, obj, invokeAttr, (object) binder, (object) parameters, (object) culture);
      }

      public override string ToString() => this.methodInfo.ToString();

      public override ICustomAttributeProvider ReturnTypeCustomAttributes => ((MethodInfo) this.methodInfo).ReturnTypeCustomAttributes;

      public override IList<CustomAttributeData> GetCustomAttributesData() => ((MemberInfo) this.methodInfo).GetCustomAttributesData();

      public override bool IsDefined(Type attributeType, bool inherit) => PropertyInfoProxy.MethodInfoProxy.IZQn1svBUG10HriBasng(this.methodInfo, attributeType, inherit);

      public override object[] GetCustomAttributes(bool inherit) => (object[]) PropertyInfoProxy.MethodInfoProxy.L0SGL1vBsPpI3GKwc9fr(this.methodInfo, inherit);

      public override object[] GetCustomAttributes(Type attributeType, bool inherit) => (object[]) PropertyInfoProxy.MethodInfoProxy.CoEqWkvBcclUKqy77vcI(this.methodInfo, attributeType, inherit);

      public override Module Module => this.DeclaringType.Module;

      public override MethodInfo GetBaseDefinition() => (MethodInfo) this;

      public override RuntimeMethodHandle MethodHandle => throw new NotImplementedException();

      internal static void xS8hl6vB9LEpEvO0igl9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool p4QI1MvBMN9Ir6HfrrS0() => PropertyInfoProxy.MethodInfoProxy.eqlU7lvByh2f2ZussRI1 == null;

      internal static PropertyInfoProxy.MethodInfoProxy uDadXxvBJTM1Fx4bU3hY() => (PropertyInfoProxy.MethodInfoProxy) PropertyInfoProxy.MethodInfoProxy.eqlU7lvByh2f2ZussRI1;

      internal static object pihNNUvBdueeNWlL7VA6([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static MethodAttributes cuGAy4vBlLtIi15O29tX([In] object obj0) => ((MethodBase) obj0).Attributes;

      internal static bool TZM26cvBrwkQJY6hgs8E([In] object obj0) => ((MethodBase) obj0).IsSecuritySafeCritical;

      internal static bool L196EGvBge0P6opEoTVk([In] object obj0) => ((MethodBase) obj0).IsSecurityTransparent;

      internal static MethodImplAttributes hcZAZ1vB5WdbdojFlaFn([In] object obj0) => ((MethodBase) obj0).MethodImplementationFlags;

      internal static object VqUKt6vBjac9jvsl3LXS([In] object obj0) => (object) ((MethodInfo) obj0).ReturnParameter;

      internal static object EijOUovBY6CA1jo4Pemp([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

      internal static object bZCPZlvBLJPx2pb4JZb2(
        [In] object obj0,
        [In] object obj1,
        [In] BindingFlags obj2,
        [In] object obj3,
        [In] object obj4,
        [In] object obj5)
      {
        return ((MethodBase) obj0).Invoke(obj1, obj2, (Binder) obj3, (object[]) obj4, (CultureInfo) obj5);
      }

      internal static bool IZQn1svBUG10HriBasng([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

      internal static object L0SGL1vBsPpI3GKwc9fr([In] object obj0, [In] bool obj1) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1);

      internal static object CoEqWkvBcclUKqy77vcI([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);
    }
  }
}
