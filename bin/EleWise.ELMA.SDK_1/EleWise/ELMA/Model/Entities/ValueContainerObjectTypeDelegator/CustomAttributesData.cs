// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.CustomAttributesData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  internal class CustomAttributesData
  {
    private readonly CustomAttributesData.AttributeData[] attributesData;
    private IList<CustomAttributeData> customAttributesData;
    private object[] customAttributes;
    internal static CustomAttributesData ahLwpvhVJbFhKNuiMfDM;

    public CustomAttributesData(IList<CustomAttributeData> customAttributesData)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.customAttributesData = customAttributesData;
    }

    public CustomAttributesData(ICollection<Mono.Cecil.CustomAttribute> customAttributes)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.attributesData = customAttributes.Select<Mono.Cecil.CustomAttribute, CustomAttributesData.AttributeData>((Func<Mono.Cecil.CustomAttribute, CustomAttributesData.AttributeData>) (customAttribute => new CustomAttributesData.AttributeData(customAttribute))).ToArray<CustomAttributesData.AttributeData>();
    }

    public IList<CustomAttributeData> GetCustomAttributesData() => this.customAttributesData ?? (this.customAttributesData = (IList<CustomAttributeData>) ((IEnumerable<CustomAttributesData.AttributeData>) this.attributesData).Select<CustomAttributesData.AttributeData, CustomAttributeData>((Func<CustomAttributesData.AttributeData, CustomAttributeData>) (a => a.Resolve())).ToArray<CustomAttributeData>());

    public object[] GetCustomAttributes()
    {
      int num1 = 2;
      object[] array1;
      object[] customAttributes;
      while (true)
      {
        switch (num1)
        {
          case 1:
            IList<CustomAttributeData> customAttributesData = this.GetCustomAttributesData();
            // ISSUE: reference to a compiler-generated field
            Func<CustomAttributeData, object> func1 = CustomAttributesData.\u003C\u003Ec.\u003C\u003E9__6_0;
            Func<CustomAttributeData, object> selector1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              CustomAttributesData.\u003C\u003Ec.\u003C\u003E9__6_0 = selector1 = (Func<CustomAttributeData, object>) (d =>
              {
                int num3 = 1;
                object attr;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      d.NamedArguments.ForEach<System.Reflection.CustomAttributeNamedArgument>((Action<System.Reflection.CustomAttributeNamedArgument>) (a =>
                      {
                        int num4 = 4;
                        CustomAttributeTypedArgument typedValue;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 0:
                              goto label_6;
                            case 1:
                              FieldInfo memberInfo3 = (FieldInfo) a.MemberInfo;
                              object obj5 = attr;
                              typedValue = a.TypedValue;
                              object obj6 = typedValue.Value;
                              // ISSUE: reference to a compiler-generated method
                              CustomAttributesData.\u003C\u003Ec__DisplayClass6_0.FJXLQCvFOS4TtCgrU9xw((object) memberInfo3, obj5, obj6);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
                              continue;
                            case 2:
                              goto label_7;
                            case 3:
                              PropertyInfo memberInfo4 = (PropertyInfo) a.MemberInfo;
                              object obj7 = attr;
                              typedValue = a.TypedValue;
                              object obj8 = typedValue.Value;
                              // ISSUE: reference to a compiler-generated method
                              CustomAttributesData.\u003C\u003Ec__DisplayClass6_0.NFiQoTvF2gE6ETXyfacy((object) memberInfo4, obj7, obj8);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                              continue;
                            case 4:
                              if (!a.IsField)
                              {
                                num4 = 3;
                                continue;
                              }
                              goto case 1;
                            default:
                              goto label_2;
                          }
                        }
label_6:
                        return;
label_7:
                        return;
label_2:;
                      }));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 3;
                      continue;
                    case 3:
                      goto label_2;
                    default:
                      ConstructorInfo constructor = d.Constructor;
                      IList<CustomAttributeTypedArgument> constructorArguments = d.ConstructorArguments;
                      // ISSUE: reference to a compiler-generated field
                      Func<CustomAttributeTypedArgument, object> func2 = CustomAttributesData.\u003C\u003Ec.\u003C\u003E9__6_1;
                      Func<CustomAttributeTypedArgument, object> selector2;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        CustomAttributesData.\u003C\u003Ec.\u003C\u003E9__6_1 = selector2 = (Func<CustomAttributeTypedArgument, object>) (a => a.Value);
                      }
                      else
                        goto label_8;
label_7:
                      object[] array2 = constructorArguments.Select<CustomAttributeTypedArgument, object>(selector2).ToArray<object>();
                      attr = constructor.Invoke(array2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 2;
                      continue;
label_8:
                      selector2 = func2;
                      goto label_7;
                  }
                }
label_2:
                return attr;
              });
            }
            else
              goto label_9;
label_7:
            this.customAttributes = array1 = customAttributesData.Select<CustomAttributeData, object>(selector1).ToArray<object>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
label_9:
            selector1 = func1;
            goto label_7;
          case 2:
            customAttributes = this.customAttributes;
            if (customAttributes == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          default:
            goto label_8;
        }
      }
label_3:
      return customAttributes;
label_8:
      return array1;
    }

    public bool IsDefined(System.Type attributeType, bool inherit, System.Type baseType = null) => CustomAttributesData.IsDefined(this.GetCustomAttributesData(), attributeType, inherit, baseType, (Func<System.Type, bool>) null);

    public object[] GetCustomAttributes(bool inherit, System.Type baseType = null) => this.GetCustomAttributes(TypeOf<object>.Raw, inherit, baseType);

    public object[] GetCustomAttributes(System.Type attributeType, bool inherit, System.Type baseType = null)
    {
      int num = 7;
      object[] customAttributes;
      List<object> list;
      System.Type attributeType1;
      CustomAttributesData customAttributesData;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 10:
            customAttributes = (object[]) CustomAttributesData.EJBbwxhVl4MUbo4126kx(attributeType1, list.Count);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            CustomAttributesData.dTFxpLhVrM9aYSdTqbid((object) list, (object) customAttributes);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 2;
            continue;
          case 4:
            if (!inherit)
            {
              num = 10;
              continue;
            }
            goto case 8;
          case 5:
            list = ((IEnumerable<object>) this.GetCustomAttributes()).Where<object>((Func<object, bool>) (a => attributeType1.IsInstanceOfType(a))).ToList<object>();
            num = 4;
            continue;
          case 6:
            attributeType1 = attributeType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 9 : 9;
            continue;
          case 7:
            num = 6;
            continue;
          case 8:
            if (baseType != (System.Type) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 9:
            customAttributesData = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 5;
            continue;
          default:
            list.AddRange(((IEnumerable<object>) baseType.GetCustomAttributes(attributeType1, true)).Where<object>((Func<object, bool>) (a => CustomAttributesData.CheckAttributeType(a.GetType(), customAttributesData.GetCustomAttributesData()))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
            continue;
        }
      }
label_7:
      return customAttributes;
    }

    private static bool IsDefined(
      IList<CustomAttributeData> customAttributesData,
      System.Type attributeType,
      bool inherit,
      System.Type baseType,
      Func<System.Type, bool> check)
    {
      if (customAttributesData.Any<CustomAttributeData>((Func<CustomAttributeData, bool>) (d =>
      {
        int num = 2;
        Func<System.Type, bool> func;
        while (true)
        {
          switch (num)
          {
            case 1:
              func = check;
              if (func == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (attributeType.IsAssignableFrom(CustomAttributesData.\u003C\u003Ec__DisplayClass10_0.jjdLG1vFtqBLWopF6Ebs((object) d)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
                continue;
              }
              goto label_8;
            default:
              goto label_6;
          }
        }
label_6:
        return true;
label_7:
        // ISSUE: reference to a compiler-generated method
        return func(CustomAttributesData.\u003C\u003Ec__DisplayClass10_0.jjdLG1vFtqBLWopF6Ebs((object) d));
label_8:
        return false;
      })))
        return true;
      return inherit && baseType != (System.Type) null && CustomAttributesData.IsDefined(baseType.GetCustomAttributesData(), attributeType, true, baseType.BaseType, (Func<System.Type, bool>) (t => CustomAttributesData.CheckAttributeType(t, (IList<CustomAttributeData>) null)));
    }

    private static bool CheckAttributeType(
      System.Type attributeType,
      IList<CustomAttributeData> customAttributesData)
    {
      AttributeUsageAttribute attribute = AttributeHelper<AttributeUsageAttribute>.GetAttribute(attributeType, true);
      if ((attribute != null ? (attribute.Inherited ? 1 : 0) : 1) == 0)
        return false;
      // ISSUE: reference to a compiler-generated method
      return attribute.AllowMultiple || customAttributesData == null || customAttributesData.All<CustomAttributeData>((Func<CustomAttributeData, bool>) (d => CustomAttributesData.\u003C\u003Ec__DisplayClass11_0.MPJRn7vFAZiKUfH1nK9m(d.AttributeType, attributeType)));
    }

    internal static bool XB9A8JhV9hNICcixrx25() => CustomAttributesData.ahLwpvhVJbFhKNuiMfDM == null;

    internal static CustomAttributesData R10xBbhVdY5umn3QNK3H() => CustomAttributesData.ahLwpvhVJbFhKNuiMfDM;

    internal static object EJBbwxhVl4MUbo4126kx([In] System.Type obj0, [In] int obj1) => (object) Array.CreateInstance(obj0, obj1);

    internal static void dTFxpLhVrM9aYSdTqbid([In] object obj0, [In] object obj1) => ((List<object>) obj0).CopyTo((object[]) obj1);

    private class AttributeData
    {
      private readonly object constructorReference;
      private readonly object constructorArguments;
      private readonly object namedArguments;
      private static object Tcj98ZvFbmnAmm7VLys5;

      public AttributeData(Mono.Cecil.CustomAttribute customAttribute)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_11;
            case 2:
              this.constructorReference = (object) EntityDynamicGenerator.CreateReference((MethodReference) CustomAttributesData.AttributeData.XboZ5RvFEfhWBnt9F3uo((object) customAttribute));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            case 3:
              Collection<Mono.Cecil.CustomAttributeNamedArgument> fields = customAttribute.Fields;
              // ISSUE: reference to a compiler-generated field
              Func<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedArgument> func1 = CustomAttributesData.AttributeData.\u003C\u003Ec.\u003C\u003E9__3_1;
              Func<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedArgument> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                CustomAttributesData.AttributeData.\u003C\u003Ec.\u003C\u003E9__3_1 = selector1 = (Func<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedArgument>) (f => (CustomAttributesData.AttributeData.AttributeNamedArgument) new CustomAttributesData.AttributeData.AttributeNamedFieldArgument(f.Name, f));
              }
              else
                goto label_15;
label_10:
              IEnumerable<CustomAttributesData.AttributeData.AttributeNamedArgument> first = fields.Select<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedArgument>(selector1);
              Collection<Mono.Cecil.CustomAttributeNamedArgument> properties = customAttribute.Properties;
              // ISSUE: reference to a compiler-generated field
              Func<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedPropertyArgument> func2 = CustomAttributesData.AttributeData.\u003C\u003Ec.\u003C\u003E9__3_2;
              Func<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedPropertyArgument> selector2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                CustomAttributesData.AttributeData.\u003C\u003Ec.\u003C\u003E9__3_2 = selector2 = (Func<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedPropertyArgument>) (p => new CustomAttributesData.AttributeData.AttributeNamedPropertyArgument(p.Name, p));
              }
              else
                goto label_14;
label_13:
              IEnumerable<CustomAttributesData.AttributeData.AttributeNamedPropertyArgument> second = properties.Select<Mono.Cecil.CustomAttributeNamedArgument, CustomAttributesData.AttributeData.AttributeNamedPropertyArgument>(selector2);
              this.namedArguments = (object) first.Concat<CustomAttributesData.AttributeData.AttributeNamedArgument>((IEnumerable<CustomAttributesData.AttributeData.AttributeNamedArgument>) second).ToArray<CustomAttributesData.AttributeData.AttributeNamedArgument>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
              continue;
label_14:
              selector2 = func2;
              goto label_13;
label_15:
              selector1 = func1;
              goto label_10;
            default:
              Collection<CustomAttributeArgument> constructorArguments = customAttribute.ConstructorArguments;
              // ISSUE: reference to a compiler-generated field
              Func<CustomAttributeArgument, CustomAttributesData.AttributeData.AttributeTypedArgument> func3 = CustomAttributesData.AttributeData.\u003C\u003Ec.\u003C\u003E9__3_0;
              Func<CustomAttributeArgument, CustomAttributesData.AttributeData.AttributeTypedArgument> selector3;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                CustomAttributesData.AttributeData.\u003C\u003Ec.\u003C\u003E9__3_0 = selector3 = (Func<CustomAttributeArgument, CustomAttributesData.AttributeData.AttributeTypedArgument>) (a => new CustomAttributesData.AttributeData.AttributeTypedArgument(a));
              }
              else
                goto label_5;
label_7:
              this.constructorArguments = (object) constructorArguments.Select<CustomAttributeArgument, CustomAttributesData.AttributeData.AttributeTypedArgument>(selector3).ToArray<CustomAttributesData.AttributeData.AttributeTypedArgument>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 3;
              continue;
label_5:
              selector3 = func3;
              goto label_7;
          }
        }
label_11:;
      }

      public CustomAttributeData Resolve()
      {
        int num = 3;
        CustomAttributesData.AttributeData attributeData;
        System.Type attributeType;
        while (true)
        {
          switch (num)
          {
            case 1:
              attributeType = EntityDynamicGenerator.Resolve(((MemberReference) this.constructorReference).DeclaringType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 2:
              attributeData = this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            case 3:
              num = 2;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (CustomAttributeData) new EntityCustomAttributeData(((IEnumerable<ConstructorInfo>) attributeType.GetConstructors()).FirstOrDefault<ConstructorInfo>((Func<ConstructorInfo, bool>) (c => CustomAttributesData.AttributeData.SequenceEqual((IList<ParameterInfo>) CustomAttributesData.AttributeData.\u003C\u003Ec__DisplayClass4_0.jFIVyAZilsgS1nsPmNSx((object) c), (IList<ParameterDefinition>) ((MethodReference) attributeData.constructorReference).Parameters))), (IList<CustomAttributeTypedArgument>) ((IEnumerable<CustomAttributesData.AttributeData.AttributeTypedArgument>) this.constructorArguments).Select<CustomAttributesData.AttributeData.AttributeTypedArgument, CustomAttributeTypedArgument>((Func<CustomAttributesData.AttributeData.AttributeTypedArgument, CustomAttributeTypedArgument>) (a => CustomAttributesData.AttributeData.\u003C\u003Ec.Tb1UvNZiMrPKJ3rVMcq7((object) a))).ToArray<CustomAttributeTypedArgument>(), (IList<System.Reflection.CustomAttributeNamedArgument>) ((IEnumerable<CustomAttributesData.AttributeData.AttributeNamedArgument>) this.namedArguments).Select<CustomAttributesData.AttributeData.AttributeNamedArgument, System.Reflection.CustomAttributeNamedArgument>((Func<CustomAttributesData.AttributeData.AttributeNamedArgument, System.Reflection.CustomAttributeNamedArgument>) (a => CustomAttributesData.AttributeData.\u003C\u003Ec__DisplayClass4_0.hDr50OZirmgRTacpR2fU((object) a, attributeType))).ToArray<System.Reflection.CustomAttributeNamedArgument>());
      }

      private static bool SequenceEqual(
        IList<ParameterInfo> parameters1,
        IList<ParameterDefinition> parameters2)
      {
        if (parameters1.Count != parameters2.Count)
          return false;
        for (int index = 0; index < parameters1.Count; ++index)
        {
          if (!CustomAttributesData.AttributeData.Equal(parameters1[index].ParameterType, (object) parameters2[index].ParameterType))
            return false;
        }
        return true;
      }

      private static bool SequenceEqual(IList<System.Type> types1, IList<TypeReference> types2)
      {
        if (types1.Count != types2.Count)
          return false;
        for (int index = 0; index < types1.Count; ++index)
        {
          if (!CustomAttributesData.AttributeData.Equal(types1[index], (object) types2[index]))
            return false;
        }
        return true;
      }

      private static bool Equal(System.Type type1, object type2)
      {
        int num1 = 11;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 12:
                goto label_9;
              case 2:
                if (type1.Name == (string) CustomAttributesData.AttributeData.hHMFPKvFSQFhtutYyifK(type2))
                {
                  num2 = 3;
                  continue;
                }
                goto label_13;
              case 3:
                goto label_12;
              case 4:
                if (!CustomAttributesData.AttributeData.m0ZObGvFQLymhQuYggGm(type1.GetGenericTypeDefinition(), CustomAttributesData.AttributeData.emChldvFfWwofp2PcDvR((object) genericInstanceType2)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 21 : 12;
                  continue;
                }
                goto label_14;
              case 5:
                if (CustomAttributesData.AttributeData.Yt1UHLvFCKd3eTvkDcZA(type1.DeclaringType, (System.Type) null))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 7 : 9;
                  continue;
                }
                goto case 23;
              case 6:
                if (!(type2 is GenericInstanceType genericInstanceType1))
                {
                  num2 = 28;
                  continue;
                }
                goto label_20;
              case 7:
                goto label_24;
              case 8:
                goto label_50;
              case 9:
                if (CustomAttributesData.AttributeData.NfBOuDvFvZaoqEUYgiTR((object) genericParameter) != null)
                {
                  num2 = 15;
                  continue;
                }
                goto case 23;
              case 10:
                if (!(type2 is ArrayType arrayType))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 16 : 14;
                  continue;
                }
                goto label_43;
              case 11:
                if (type1.IsArray)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 10 : 9;
                  continue;
                }
                if (!type1.IsByRef)
                {
                  if (!type1.IsGenericParameter)
                  {
                    if (!type1.IsGenericTypeDefinition)
                    {
                      num2 = 22;
                      continue;
                    }
                    goto case 6;
                  }
                  else
                    goto label_26;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 9 : 20;
                  continue;
                }
              case 13:
                goto label_43;
              case 14:
                if (CustomAttributesData.AttributeData.MkHIePvFIJJ1qSC2TCBW(type2))
                {
                  num2 = 2;
                  continue;
                }
                goto label_9;
              case 15:
                goto label_49;
              case 16:
                goto label_44;
              case 17:
                if (type2 is GenericInstanceType genericInstanceType2)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 4;
                  continue;
                }
                goto label_15;
              case 18:
                goto label_47;
              case 19:
                goto label_23;
              case 20:
                goto label_37;
              case 21:
                goto label_15;
              case 22:
                if (type1.IsGenericType)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 7 : 17;
                  continue;
                }
                goto case 28;
              case 23:
                if (CustomAttributesData.AttributeData.cFI7ucvF8TYHaLbYr6pV((object) type1.DeclaringMethod, (object) null))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 10 : 24;
                  continue;
                }
                goto label_47;
              case 24:
                goto label_29;
              case 25:
                goto label_48;
              case 26:
                goto label_20;
              case 27:
                if (!(type2 is GenericParameter genericParameter))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 7 : 8;
                  continue;
                }
                goto case 5;
              case 28:
                if (!type1.IsNested)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
                  continue;
                }
                goto case 14;
              default:
                goto label_14;
            }
          }
label_26:
          num1 = 27;
          continue;
label_29:
          if (CustomAttributesData.AttributeData.eXBSSjvFZ4np0mYvA64J((object) genericParameter) != null)
          {
            num1 = 25;
            continue;
          }
          goto label_47;
label_37:
          if (!(type2 is ByReferenceType byReferenceType))
            num1 = 7;
          else
            goto label_23;
        }
label_9:
        return type1.FullName == (string) CustomAttributesData.AttributeData.MT9MNUvFV79YejZ2rGFL(type2);
label_12:
        return CustomAttributesData.AttributeData.Equal(type1.DeclaringType, CustomAttributesData.AttributeData.NfBOuDvFvZaoqEUYgiTR(type2));
label_13:
        return false;
label_14:
        return CustomAttributesData.AttributeData.SequenceEqual((IList<System.Type>) type1.GetGenericArguments(), (IList<TypeReference>) genericInstanceType2.GenericArguments);
label_15:
        return false;
label_20:
        return CustomAttributesData.AttributeData.m0ZObGvFQLymhQuYggGm(type1.GetGenericTypeDefinition(), (object) genericInstanceType1.ElementType);
label_23:
        return CustomAttributesData.AttributeData.Equal(type1.GetElementType(), CustomAttributesData.AttributeData.emChldvFfWwofp2PcDvR((object) byReferenceType));
label_24:
        return false;
label_43:
        return CustomAttributesData.AttributeData.m0ZObGvFQLymhQuYggGm(type1.GetElementType(), CustomAttributesData.AttributeData.emChldvFfWwofp2PcDvR((object) arrayType));
label_44:
        return false;
label_47:
        return false;
label_48:
        return type1.GenericParameterPosition == CustomAttributesData.AttributeData.bg6WKRvFuWQi3RduUoO3((object) genericParameter);
label_49:
        return type1.GenericParameterPosition == CustomAttributesData.AttributeData.bg6WKRvFuWQi3RduUoO3((object) genericParameter);
label_50:
        return false;
      }

      internal static object XboZ5RvFEfhWBnt9F3uo([In] object obj0) => (object) ((Mono.Cecil.CustomAttribute) obj0).Constructor;

      internal static bool GvebMvvFhQhao8IcGmQJ() => CustomAttributesData.AttributeData.Tcj98ZvFbmnAmm7VLys5 == null;

      internal static CustomAttributesData.AttributeData dV4vUxvFGbbDscuagHlc() => (CustomAttributesData.AttributeData) CustomAttributesData.AttributeData.Tcj98ZvFbmnAmm7VLys5;

      internal static object emChldvFfWwofp2PcDvR([In] object obj0) => (object) ((TypeSpecification) obj0).ElementType;

      internal static bool m0ZObGvFQLymhQuYggGm(System.Type type1, [In] object obj1) => CustomAttributesData.AttributeData.Equal(type1, obj1);

      internal static bool Yt1UHLvFCKd3eTvkDcZA([In] System.Type obj0, [In] System.Type obj1) => obj0 != obj1;

      internal static object NfBOuDvFvZaoqEUYgiTR([In] object obj0) => (object) ((MemberReference) obj0).DeclaringType;

      internal static bool cFI7ucvF8TYHaLbYr6pV([In] object obj0, [In] object obj1) => (MethodBase) obj0 != (MethodBase) obj1;

      internal static object eXBSSjvFZ4np0mYvA64J([In] object obj0) => (object) ((GenericParameter) obj0).DeclaringMethod;

      internal static int bg6WKRvFuWQi3RduUoO3([In] object obj0) => ((GenericParameter) obj0).Position;

      internal static bool MkHIePvFIJJ1qSC2TCBW([In] object obj0) => ((TypeReference) obj0).IsNested;

      internal static object MT9MNUvFV79YejZ2rGFL([In] object obj0) => (object) ((MemberReference) obj0).FullName;

      internal static object hHMFPKvFSQFhtutYyifK([In] object obj0) => (object) ((MemberReference) obj0).Name;

      private class AttributeTypedArgument
      {
        private readonly object typeReference;
        private readonly object value;
        internal static object oDW4jxZiOsxUTvX9041b;

        public AttributeTypedArgument(CustomAttributeArgument argument)
        {
          CustomAttributesData.AttributeData.AttributeTypedArgument.dm8oBIZiPuU1jiolqUUl();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.typeReference = CustomAttributesData.AttributeData.AttributeTypedArgument.MXKVSuZi1rTeV7mSTW3T((object) argument.Type);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              default:
                this.value = this.ResolveAttributeArgument(argument);
                num = 2;
                continue;
            }
          }
label_3:;
        }

        public CustomAttributeTypedArgument Resolve() => new CustomAttributeTypedArgument(CustomAttributesData.AttributeData.AttributeTypedArgument.n8NgCjZiNtqPheTBNoDY(this.typeReference), this.value is TypeReference typeReference ? (object) CustomAttributesData.AttributeData.AttributeTypedArgument.n8NgCjZiNtqPheTBNoDY((object) typeReference) : this.value);

        private object ResolveAttributeArgument(CustomAttributeArgument argument)
        {
          int num = 2;
          object obj;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (obj == null)
                {
                  num = 6;
                  continue;
                }
                goto case 5;
              case 2:
                obj = argument.Value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                continue;
              case 3:
                goto label_13;
              case 4:
                goto label_4;
              case 5:
                if (!(obj is TypeReference typeReference))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 7;
                  continue;
                }
                goto label_4;
              case 6:
                goto label_14;
              case 7:
                if (!(obj is CustomAttributeArgument[] source))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              case 8:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 9 : 8;
                continue;
              case 9:
                num = 3;
                continue;
              default:
                if (obj is CustomAttributeArgument attributeArgument)
                {
                  num = 8;
                  continue;
                }
                goto label_14;
            }
          }
label_4:
          return CustomAttributesData.AttributeData.AttributeTypedArgument.MXKVSuZi1rTeV7mSTW3T((object) typeReference);
label_5:
          return (object) ((IEnumerable<CustomAttributeArgument>) source).Select<CustomAttributeArgument, object>(new Func<CustomAttributeArgument, object>(this.ResolveAttributeArgument)).ToArray<object>();
label_13:
          return this.ResolveAttributeArgument(attributeArgument);
label_14:
          return argument.Value;
        }

        internal static void dm8oBIZiPuU1jiolqUUl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static object MXKVSuZi1rTeV7mSTW3T([In] object obj0) => (object) EntityDynamicGenerator.CreateReference((TypeReference) obj0);

        internal static bool CaY2dkZi2sIMQxZFkmFd() => CustomAttributesData.AttributeData.AttributeTypedArgument.oDW4jxZiOsxUTvX9041b == null;

        internal static CustomAttributesData.AttributeData.AttributeTypedArgument o3Mj43ZierhqUu45T7Lv() => (CustomAttributesData.AttributeData.AttributeTypedArgument) CustomAttributesData.AttributeData.AttributeTypedArgument.oDW4jxZiOsxUTvX9041b;

        internal static System.Type n8NgCjZiNtqPheTBNoDY([In] object obj0) => EntityDynamicGenerator.Resolve((TypeReference) obj0);
      }

      private abstract class AttributeNamedArgument
      {
        protected readonly object Name;
        protected readonly object Argument;
        private static object jMMxyAZi37fq7FQ4cbcd;

        public AttributeNamedArgument(string name, Mono.Cecil.CustomAttributeNamedArgument argument)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.Name = (object) name;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              default:
                this.Argument = (object) new CustomAttributesData.AttributeData.AttributeTypedArgument(argument.Argument);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 2;
                continue;
            }
          }
label_3:;
        }

        public abstract System.Reflection.CustomAttributeNamedArgument Resolve(System.Type attributeType);

        internal static bool yeU7AnZipADt4PnT6Lo1() => CustomAttributesData.AttributeData.AttributeNamedArgument.jMMxyAZi37fq7FQ4cbcd == null;

        internal static CustomAttributesData.AttributeData.AttributeNamedArgument wSEeJHZiaAsX7unxmOUX() => (CustomAttributesData.AttributeData.AttributeNamedArgument) CustomAttributesData.AttributeData.AttributeNamedArgument.jMMxyAZi37fq7FQ4cbcd;
      }

      private class AttributeNamedFieldArgument : 
        CustomAttributesData.AttributeData.AttributeNamedArgument
      {
        internal static object xHEF73ZiDsZNwkInTTTN;

        public AttributeNamedFieldArgument(string name, Mono.Cecil.CustomAttributeNamedArgument argument)
        {
          CustomAttributesData.AttributeData.AttributeNamedFieldArgument.k8ZL5vZi4cNyO9r3IvqF();
          // ISSUE: explicit constructor call
          base.\u002Ector(name, argument);
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
            num = 0;
          switch (num)
          {
          }
        }

        public override System.Reflection.CustomAttributeNamedArgument Resolve(System.Type attributeType) => new System.Reflection.CustomAttributeNamedArgument((MemberInfo) attributeType.GetField((string) this.Name), ((CustomAttributesData.AttributeData.AttributeTypedArgument) this.Argument).Resolve());

        internal static void k8ZL5vZi4cNyO9r3IvqF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static bool q6NO2FZitf9xlhUwCMc6() => CustomAttributesData.AttributeData.AttributeNamedFieldArgument.xHEF73ZiDsZNwkInTTTN == null;

        internal static CustomAttributesData.AttributeData.AttributeNamedFieldArgument SvAu6BZiwBhO57H74Enb() => (CustomAttributesData.AttributeData.AttributeNamedFieldArgument) CustomAttributesData.AttributeData.AttributeNamedFieldArgument.xHEF73ZiDsZNwkInTTTN;
      }

      private class AttributeNamedPropertyArgument : 
        CustomAttributesData.AttributeData.AttributeNamedArgument
      {
        private static object LYcQmEZi6UW4po1M6rLH;

        public AttributeNamedPropertyArgument(string name, Mono.Cecil.CustomAttributeNamedArgument argument)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector(name, argument);
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
            num = 0;
          switch (num)
          {
          }
        }

        public override System.Reflection.CustomAttributeNamedArgument Resolve(System.Type attributeType) => new System.Reflection.CustomAttributeNamedArgument((MemberInfo) attributeType.GetProperty((string) this.Name), CustomAttributesData.AttributeData.AttributeNamedPropertyArgument.rvRDyBZi74FDhsHPwFDc(this.Argument));

        internal static bool YHt7BWZiH3Y1kdO8Ulsn() => CustomAttributesData.AttributeData.AttributeNamedPropertyArgument.LYcQmEZi6UW4po1M6rLH == null;

        internal static CustomAttributesData.AttributeData.AttributeNamedPropertyArgument WmjPYmZiAl46Wtu1tKET() => (CustomAttributesData.AttributeData.AttributeNamedPropertyArgument) CustomAttributesData.AttributeData.AttributeNamedPropertyArgument.LYcQmEZi6UW4po1M6rLH;

        internal static CustomAttributeTypedArgument rvRDyBZi74FDhsHPwFDc([In] object obj0) => ((CustomAttributesData.AttributeData.AttributeTypedArgument) obj0).Resolve();
      }
    }
  }
}
