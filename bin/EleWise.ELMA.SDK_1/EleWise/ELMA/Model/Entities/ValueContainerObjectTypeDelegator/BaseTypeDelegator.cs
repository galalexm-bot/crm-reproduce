// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.BaseTypeDelegator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  /// <summary>
  /// Базовый класс для собственных реализаций <see cref="T:System.Reflection.TypeDelegator" />
  /// </summary>
  internal abstract class BaseTypeDelegator : System.Reflection.TypeDelegator
  {
    private PublishCacheContext.Local<CustomAttributesData> customAttributesData;
    internal static BaseTypeDelegator EnnLcShSkSJAqNy9kHna;

    /// <summary>Ctor</summary>
    /// <param name="runtimeType">Тип</param>
    protected BaseTypeDelegator(System.Type runtimeType)
    {
      BaseTypeDelegator.RHqclahS2TK5ooCPp3RJ();
      this.customAttributesData = new PublishCacheContext.Local<CustomAttributesData>();
      // ISSUE: explicit constructor call
      base.\u002Ector(runtimeType);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.RuntimeType = runtimeType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Тип</summary>
    internal System.Type RuntimeType { get; }

    /// <summary>Инициализация типа</summary>
    /// <param name="typeDefinition">Определение типа</param>
    public virtual void InitType(TypeDefinition typeDefinition)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.customAttributesData.Value = typeDefinition != null ? new CustomAttributesData((ICollection<Mono.Cecil.CustomAttribute>) typeDefinition.CustomAttributes) : new CustomAttributesData(this.RuntimeType.GetCustomAttributesData());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
    {
      int num1 = 1;
      MemberInfo[] members;
      while (true)
      {
        int num2 = num1;
        PropertyInfo[] properties;
        ConstructorInfo[] constructors;
        System.Type[] nestedTypes;
        int index;
        MethodInfo[] methods;
        FieldInfo[] fields;
        EventInfo[] events;
        while (true)
        {
          switch (num2)
          {
            case 1:
              methods = this.GetMethods(bindingAttr);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            case 2:
              BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) nestedTypes, (object) members, index);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 7;
              continue;
            case 3:
              index += methods.Length;
              num2 = 19;
              continue;
            case 4:
              index += events.Length;
              num2 = 20;
              continue;
            case 5:
              index += constructors.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 8 : 0;
              continue;
            case 6:
              members = new MemberInfo[methods.Length + constructors.Length + properties.Length + events.Length + fields.Length + nestedTypes.Length];
              num2 = 12;
              continue;
            case 7:
              index += nestedTypes.Length;
              num2 = 14;
              continue;
            case 8:
              BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) properties, (object) members, index);
              num2 = 13;
              continue;
            case 9:
              methods.CopyTo((Array) members, index);
              num2 = 3;
              continue;
            case 10:
              properties = this.GetProperties(bindingAttr);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 17 : 17;
              continue;
            case 11:
              goto label_11;
            case 12:
              index = 0;
              num2 = 9;
              continue;
            case 13:
              index += properties.Length;
              num2 = 18;
              continue;
            case 14:
              goto label_23;
            case 15:
              index += fields.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
              continue;
            case 16:
              nestedTypes = this.GetNestedTypes(bindingAttr);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 6;
              continue;
            case 17:
              events = this.GetEvents(bindingAttr);
              num2 = 11;
              continue;
            case 18:
              BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) events, (object) members, index);
              num2 = 4;
              continue;
            case 19:
              BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) constructors, (object) members, index);
              num2 = 5;
              continue;
            case 20:
              fields.CopyTo((Array) members, index);
              num2 = 15;
              continue;
            default:
              constructors = this.GetConstructors(bindingAttr);
              num2 = 10;
              continue;
          }
        }
label_11:
        fields = this.GetFields(bindingAttr);
        num1 = 16;
      }
label_23:
      return members;
    }

    /// <inheritdoc />
    public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
    {
      int num1 = 47;
      MemberInfo[] member1;
      MemberInfo[] member2;
      while (true)
      {
        int num2 = num1;
        int index;
        EventInfo[] eventInfoArray;
        System.Type[] typeArray;
        while (true)
        {
          MethodInfo[] methodInfoArray;
          PropertyInfo[] propertyInfoArray;
          FieldInfo[] fieldInfoArray;
          ConstructorInfo[] constructorInfoArray;
          int length;
          MemberInfo[] memberInfoArray;
          string name1;
          switch (num2)
          {
            case 1:
              eventInfoArray.CopyTo((Array) member1, index);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 37 : 33;
              continue;
            case 2:
              index += methodInfoArray.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 3:
              propertyInfoArray = ((IEnumerable<PropertyInfo>) this.GetProperties(bindingAttr)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (m => m.Name == name1)).ToArray<PropertyInfo>();
              num2 = 14;
              continue;
            case 4:
              if ((type & MemberTypes.Event) == (MemberTypes) 0)
                goto case 52;
              else
                goto label_9;
            case 5:
              member2 = (MemberInfo[]) eventInfoArray;
              num2 = 17;
              continue;
            case 6:
              member2 = (MemberInfo[]) methodInfoArray;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 23 : 14;
              continue;
            case 7:
            case 29:
              if ((type & (MemberTypes.TypeInfo | MemberTypes.NestedType)) != (MemberTypes) 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 7 : 15;
                continue;
              }
              goto case 44;
            case 8:
              goto label_66;
            case 9:
            case 10:
              if ((type & MemberTypes.Constructor) == (MemberTypes) 0)
              {
                num2 = 20;
                continue;
              }
              goto case 32;
            case 11:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              eventInfoArray = ((IEnumerable<EventInfo>) this.GetEvents(bindingAttr)).Where<EventInfo>((Func<EventInfo, bool>) (m => BaseTypeDelegator.\u003C\u003Ec__DisplayClass7_0.LlivWwvWoA7NfottbXJj(BaseTypeDelegator.\u003C\u003Ec__DisplayClass7_0.IcFPV1vWbNwb5jtpiDZj((object) m), (object) name1))).ToArray<EventInfo>();
              num2 = 58;
              continue;
            case 12:
              goto label_78;
            case 13:
              propertyInfoArray = new PropertyInfo[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 13 : 60;
              continue;
            case 14:
              if (type != MemberTypes.Property)
              {
                length += propertyInfoArray.Length;
                num2 = 4;
                continue;
              }
              num2 = 57;
              continue;
            case 15:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              typeArray = ((IEnumerable<System.Type>) this.GetNestedTypes(bindingAttr)).Where<System.Type>((Func<System.Type, bool>) (m => BaseTypeDelegator.\u003C\u003Ec__DisplayClass7_0.LlivWwvWoA7NfottbXJj(BaseTypeDelegator.\u003C\u003Ec__DisplayClass7_0.IcFPV1vWbNwb5jtpiDZj((object) m), (object) name1))).ToArray<System.Type>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 11 : 50;
              continue;
            case 16:
              index += constructorInfoArray.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 51 : 8;
              continue;
            case 17:
              goto label_20;
            case 18:
              member2 = (MemberInfo[]) constructorInfoArray;
              num2 = 45;
              continue;
            case 19:
              if (type != MemberTypes.Constructor)
              {
                length += constructorInfoArray.Length;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 41 : 1;
                continue;
              }
              num2 = 18;
              continue;
            case 20:
            case 41:
              if ((type & MemberTypes.Property) != (MemberTypes) 0)
              {
                num2 = 3;
                continue;
              }
              goto case 4;
            case 21:
              if ((type & MemberTypes.Method) == (MemberTypes) 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 6 : 9;
                continue;
              }
              goto case 36;
            case 22:
              if (type == MemberTypes.TypeInfo)
              {
                num2 = 42;
                continue;
              }
              length += typeArray.Length;
              num2 = 44;
              continue;
            case 23:
              goto label_46;
            case 24:
              fieldInfoArray = new FieldInfo[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 33 : 0;
              continue;
            case 25:
              index = 0;
              num2 = 31;
              continue;
            case 26:
              goto label_22;
            case 27:
              length = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 21 : 21;
              continue;
            case 28:
              index += fieldInfoArray.Length;
              num2 = 12;
              continue;
            case 30:
              goto label_63;
            case 31:
              BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) methodInfoArray, (object) member1, index);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 2;
              continue;
            case 32:
              constructorInfoArray = this.GetConstructors(bindingAttr);
              num2 = 19;
              continue;
            case 33:
              typeArray = new System.Type[0];
              num2 = 27;
              continue;
            case 34:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              fieldInfoArray = ((IEnumerable<FieldInfo>) this.GetFields(bindingAttr)).Where<FieldInfo>((Func<FieldInfo, bool>) (m => BaseTypeDelegator.\u003C\u003Ec__DisplayClass7_0.LlivWwvWoA7NfottbXJj(BaseTypeDelegator.\u003C\u003Ec__DisplayClass7_0.IcFPV1vWbNwb5jtpiDZj((object) m), (object) name1))).ToArray<FieldInfo>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 55 : 0;
              continue;
            case 35:
              fieldInfoArray.CopyTo((Array) member1, index);
              num2 = 28;
              continue;
            case 36:
              // ISSUE: reference to a compiler-generated method
              methodInfoArray = ((IEnumerable<MethodInfo>) this.GetMethods(bindingAttr)).Where<MethodInfo>((Func<MethodInfo, bool>) (m => BaseTypeDelegator.\u003C\u003Ec__DisplayClass7_0.LlivWwvWoA7NfottbXJj((object) m.Name, (object) name1))).ToArray<MethodInfo>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 12 : 48;
              continue;
            case 37:
              goto label_25;
            case 38:
              if (name1 != null)
              {
                methodInfoArray = new MethodInfo[0];
                num2 = 59;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 23 : 53;
              continue;
            case 39:
              memberInfoArray = member2;
              break;
            case 40:
              goto label_58;
            case 42:
              member2 = (MemberInfo[]) typeArray;
              num2 = 8;
              continue;
            case 43:
              memberInfoArray = new MemberInfo[length];
              break;
            case 44:
              if (type == (MemberTypes.Constructor | MemberTypes.Method))
              {
                member2 = (MemberInfo[]) new MethodBase[length];
                num2 = 39;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 34 : 43;
              continue;
            case 45:
              goto label_56;
            case 46:
              name1 = name;
              num2 = 38;
              continue;
            case 47:
              goto label_68;
            case 48:
              if (type == MemberTypes.Method)
              {
                num2 = 6;
                continue;
              }
              length += methodInfoArray.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 10;
              continue;
            case 49:
              index += propertyInfoArray.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            case 50:
              if (type != MemberTypes.NestedType)
              {
                num2 = 22;
                continue;
              }
              goto case 42;
            case 51:
              BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) propertyInfoArray, (object) member1, index);
              num2 = 49;
              continue;
            case 52:
              if ((type & MemberTypes.Field) == (MemberTypes) 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 29 : 3;
                continue;
              }
              goto case 34;
            case 53:
              goto label_35;
            case 54:
              index += typeArray.Length;
              num2 = 40;
              continue;
            case 55:
              if (type == MemberTypes.Field)
              {
                num2 = 56;
                continue;
              }
              length += fieldInfoArray.Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 7 : 3;
              continue;
            case 56:
              member2 = (MemberInfo[]) fieldInfoArray;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 20 : 30;
              continue;
            case 57:
              member2 = (MemberInfo[]) propertyInfoArray;
              num2 = 26;
              continue;
            case 58:
              if (type != MemberTypes.Event)
              {
                length += eventInfoArray.Length;
                num2 = 52;
                continue;
              }
              num2 = 5;
              continue;
            case 59:
              constructorInfoArray = new ConstructorInfo[0];
              num2 = 13;
              continue;
            case 60:
              eventInfoArray = new EventInfo[0];
              num2 = 24;
              continue;
            default:
              BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) constructorInfoArray, (object) member1, index);
              num2 = 16;
              continue;
          }
          member1 = memberInfoArray;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 21 : 25;
        }
label_9:
        num1 = 11;
        continue;
label_25:
        index += eventInfoArray.Length;
        num1 = 35;
        continue;
label_68:
        num1 = 46;
        continue;
label_78:
        BaseTypeDelegator.hGj8KShSe4rjl079d1BZ((object) typeArray, (object) member1, index);
        num1 = 54;
      }
label_20:
      return member2;
label_22:
      return member2;
label_35:
      throw new ArgumentNullException();
label_46:
      return member2;
label_56:
      return member2;
label_58:
      return member1;
label_63:
      return member2;
label_66:
      return member2;
    }

    public override IList<CustomAttributeData> GetCustomAttributesData() => this.customAttributesData.Value.GetCustomAttributesData();

    public override bool IsDefined(System.Type attributeType, bool inherit) => this.customAttributesData.Value.IsDefined(attributeType, inherit, this.BaseType);

    public override object[] GetCustomAttributes(bool inherit) => this.customAttributesData.Value.GetCustomAttributes(inherit, this.BaseType);

    public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) => this.customAttributesData.Value.GetCustomAttributes(attributeType, inherit, this.BaseType);

    internal static void RHqclahS2TK5ooCPp3RJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fqKWRehSnJMrvUXkFxIT() => BaseTypeDelegator.EnnLcShSkSJAqNy9kHna == null;

    internal static BaseTypeDelegator T1ChYqhSOoR8qoGd9ug5() => BaseTypeDelegator.EnnLcShSkSJAqNy9kHna;

    internal static void hGj8KShSe4rjl079d1BZ([In] object obj0, [In] object obj1, [In] int obj2) => ((Array) obj0).CopyTo((Array) obj1, obj2);
  }
}
