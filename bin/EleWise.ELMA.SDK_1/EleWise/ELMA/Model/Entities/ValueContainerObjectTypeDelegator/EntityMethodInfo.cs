// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.EntityMethodInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  internal abstract class EntityMethodInfo : MethodInfo
  {
    private static readonly CustomAttributeData[] customAttributes;
    private static EntityMethodInfo qt3QUjhSU42DB9vteJ7Y;

    public EntityMethodInfo(Type declaringType, Type reflectedType, string name)
    {
      EntityMethodInfo.FUkvephSzKCtllcAqegk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Name = name;
            num = 3;
            continue;
          case 2:
            this.DeclaringType = declaringType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            this.ReflectedType = reflectedType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public override string Name { get; }

    public override Type DeclaringType { get; }

    public override Type ReflectedType { get; }

    public override string ToString()
    {
      object obj1 = EntityMethodInfo.L9RaXehiFhZw90PhTjEh(-16752921 ^ -16573867);
      Type type = EntityMethodInfo.sYfQaahiBfqYDdfhEOjV((object) this);
      object obj2 = EntityMethodInfo.AdrDYchiWMKlZVy6EgPI((object) this);
      object separator = EntityMethodInfo.L9RaXehiFhZw90PhTjEh(1505778440 - 1981636111 ^ -475860741);
      object source = EntityMethodInfo.h8ugWphioOMtdbVFXb7x((object) this);
      // ISSUE: reference to a compiler-generated field
      Func<ParameterInfo, string> func = EntityMethodInfo.\u003C\u003Ec.\u003C\u003E9__12_0;
      Func<ParameterInfo, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        EntityMethodInfo.\u003C\u003Ec.\u003C\u003E9__12_0 = selector = (Func<ParameterInfo, string>) (p => EntityMethodInfo.\u003C\u003Ec.ujaq2bvWX6sNtlutMO4h((object) p).ToString());
      }
      else
        goto label_1;
label_3:
      IEnumerable<string> values = ((IEnumerable<ParameterInfo>) source).Select<ParameterInfo, string>(selector);
      string str = string.Join((string) separator, values);
      return (string) EntityMethodInfo.juk5UphibkbQQ9enIeUV(obj1, (object) type, obj2, (object) str);
label_1:
      selector = func;
      goto label_3;
    }

    public override MethodAttributes Attributes => MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName;

    public override CallingConventions CallingConvention => CallingConventions.Standard | CallingConventions.HasThis;

    public override IEnumerable<CustomAttributeData> CustomAttributes => (IEnumerable<CustomAttributeData>) EntityMethodInfo.customAttributes;

    public override bool IsSecurityCritical => true;

    public override bool IsSecuritySafeCritical => false;

    public override bool IsSecurityTransparent => false;

    public override Module Module => EntityMethodInfo.nPL6SkhihnYesEbHI3JD((object) this).Module;

    public override MethodImplAttributes MethodImplementationFlags => MethodImplAttributes.CodeTypeMask;

    public override MethodImplAttributes GetMethodImplementationFlags() => MethodImplAttributes.CodeTypeMask;

    public override MethodInfo GetBaseDefinition() => (MethodInfo) this;

    public override RuntimeMethodHandle MethodHandle => throw new NotImplementedException();

    public override ICustomAttributeProvider ReturnTypeCustomAttributes => (ICustomAttributeProvider) this.ReturnParameter;

    public override object[] GetCustomAttributes(bool inherit) => this.CustomAttributes.Cast<object>().ToArray<object>();

    public override object[] GetCustomAttributes(Type attributeType, bool inherit)
    {
      int num = 1;
      Type attributeType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            attributeType1 = attributeType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 2;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return this.CustomAttributes.Where<CustomAttributeData>((Func<CustomAttributeData, bool>) (a => attributeType1 == EntityMethodInfo.\u003C\u003Ec__DisplayClass36_0.bZ4B6ivW2638GoOQ22Y5((object) a))).Cast<object>().ToArray<object>();
    }

    public override bool IsDefined(Type attributeType, bool inherit)
    {
      int num = 1;
      Type attributeType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            attributeType1 = attributeType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.CustomAttributes.Any<CustomAttributeData>((Func<CustomAttributeData, bool>) (a => EntityMethodInfo.\u003C\u003Ec__DisplayClass37_0.cydSjYvWphelI4dq3bWN(attributeType1, EntityMethodInfo.\u003C\u003Ec__DisplayClass37_0.vNxeAkvW3IUVHUriBfPm((object) a))));
    }

    static EntityMethodInfo()
    {
      int num = 3;
      CustomAttributeData[] customAttributeDataArray;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityMethodInfo.customAttributes = customAttributeDataArray;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 2:
            customAttributeDataArray = (CustomAttributeData[]) new EntityCustomAttributeData[1]
            {
              new EntityCustomAttributeData(TypeOf<CompilerGeneratedAttribute>.Raw.GetConstructor(new Type[0]))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
          case 3:
            EntityMethodInfo.FUkvephSzKCtllcAqegk();
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void FUkvephSzKCtllcAqegk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hWPopRhSskluxb7urQoO() => EntityMethodInfo.qt3QUjhSU42DB9vteJ7Y == null;

    internal static EntityMethodInfo ygqqZGhScgpCrLCBwCdk() => EntityMethodInfo.qt3QUjhSU42DB9vteJ7Y;

    internal static object L9RaXehiFhZw90PhTjEh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type sYfQaahiBfqYDdfhEOjV([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static object AdrDYchiWMKlZVy6EgPI([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object h8ugWphioOMtdbVFXb7x([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object juk5UphibkbQQ9enIeUV(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static Type nPL6SkhihnYesEbHI3JD([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    protected class EntityMethodParameterInfo : ParameterInfo
    {
      internal static EntityMethodInfo.EntityMethodParameterInfo eldK6BvWIq9ltg1FWawT;

      public EntityMethodParameterInfo(
        MemberInfo member,
        Type parameterType,
        string name = null,
        int position = -1)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.CustomAttributes = (IEnumerable<CustomAttributeData>) new CustomAttributeData[0];
        this.DefaultValue = (object) DBNull.Value;
        this.RawDefaultValue = (object) DBNull.Value;
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.NameImpl = name;
              num = 6;
              continue;
            case 2:
              this.ClassImpl = parameterType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
              continue;
            case 3:
              this.MemberImpl = member;
              num = 2;
              continue;
            case 4:
              goto label_3;
            case 5:
              this.AttrsImpl = ParameterAttributes.None;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            case 6:
              this.PositionImpl = position;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 4 : 5;
              continue;
            default:
              this.DefaultValueImpl = (object) null;
              num = 4;
              continue;
          }
        }
label_3:;
      }

      public override IEnumerable<CustomAttributeData> CustomAttributes { get; }

      public override object DefaultValue { get; }

      public override bool HasDefaultValue => false;

      public override object RawDefaultValue { get; }

      internal static bool YsRfSDvWVMnh2ib3ZWU7() => EntityMethodInfo.EntityMethodParameterInfo.eldK6BvWIq9ltg1FWawT == null;

      internal static EntityMethodInfo.EntityMethodParameterInfo exWdkZvWSN03n8HvbTRi() => EntityMethodInfo.EntityMethodParameterInfo.eldK6BvWIq9ltg1FWawT;
    }
  }
}
