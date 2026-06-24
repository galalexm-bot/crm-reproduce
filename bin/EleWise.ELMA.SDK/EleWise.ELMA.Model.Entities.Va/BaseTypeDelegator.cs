using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal abstract class BaseTypeDelegator : TypeDelegator
{
	private PublishCacheContext.Local<CustomAttributesData> customAttributesData;

	internal static BaseTypeDelegator EnnLcShSkSJAqNy9kHna;

	internal Type RuntimeType { get; }

	protected BaseTypeDelegator(Type runtimeType)
	{
		//Discarded unreachable code: IL_003f, IL_0044
		RHqclahS2TK5ooCPp3RJ();
		customAttributesData = new PublishCacheContext.Local<CustomAttributesData>();
		base._002Ector(runtimeType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				RuntimeType = runtimeType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual void InitType(TypeDefinition typeDefinition)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				customAttributesData.Value = ((typeDefinition != null) ? new CustomAttributesData((ICollection<CustomAttribute>)typeDefinition.get_CustomAttributes()) : new CustomAttributesData(RuntimeType.GetCustomAttributesData()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		int num = 1;
		PropertyInfo[] properties = default(PropertyInfo[]);
		ConstructorInfo[] constructors = default(ConstructorInfo[]);
		Type[] nestedTypes = default(Type[]);
		MemberInfo[] array = default(MemberInfo[]);
		int num3 = default(int);
		MethodInfo[] methods = default(MethodInfo[]);
		FieldInfo[] fields = default(FieldInfo[]);
		EventInfo[] events = default(EventInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					properties = GetProperties(bindingAttr);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 17;
					}
					continue;
				default:
					constructors = GetConstructors(bindingAttr);
					num2 = 10;
					continue;
				case 2:
					hGj8KShSe4rjl079d1BZ(nestedTypes, array, num3);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					num3 += constructors.Length;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					num3 += methods.Length;
					num2 = 19;
					continue;
				case 20:
					fields.CopyTo(array, num3);
					num2 = 15;
					continue;
				case 7:
					num3 += nestedTypes.Length;
					num2 = 14;
					continue;
				case 15:
					num3 += fields.Length;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					break;
				case 9:
					methods.CopyTo(array, num3);
					num2 = 3;
					continue;
				case 19:
					hGj8KShSe4rjl079d1BZ(constructors, array, num3);
					num2 = 5;
					continue;
				case 4:
					num3 += events.Length;
					num2 = 20;
					continue;
				case 8:
					hGj8KShSe4rjl079d1BZ(properties, array, num3);
					num2 = 13;
					continue;
				case 1:
					methods = GetMethods(bindingAttr);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					hGj8KShSe4rjl079d1BZ(events, array, num3);
					num2 = 4;
					continue;
				case 6:
					array = new MemberInfo[methods.Length + constructors.Length + properties.Length + events.Length + fields.Length + nestedTypes.Length];
					num2 = 12;
					continue;
				case 16:
					nestedTypes = GetNestedTypes(bindingAttr);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 6;
					}
					continue;
				case 17:
					events = GetEvents(bindingAttr);
					num2 = 11;
					continue;
				case 12:
					num3 = 0;
					num2 = 9;
					continue;
				case 13:
					num3 += properties.Length;
					num2 = 18;
					continue;
				case 14:
					return array;
				}
				break;
			}
			fields = GetFields(bindingAttr);
			num = 16;
		}
	}

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		//Discarded unreachable code: IL_0146, IL_01fe, IL_020d, IL_0614, IL_06bf
		int num = 47;
		int num3 = default(int);
		int num4 = default(int);
		FieldInfo[] array9 = default(FieldInfo[]);
		MethodInfo[] array7 = default(MethodInfo[]);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		EventInfo[] array4 = default(EventInfo[]);
		MemberInfo[] array5 = default(MemberInfo[]);
		MemberInfo[] array = default(MemberInfo[]);
		PropertyInfo[] array8 = default(PropertyInfo[]);
		ConstructorInfo[] array3 = default(ConstructorInfo[]);
		Type[] array6 = default(Type[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				MemberInfo[] array2;
				switch (num2)
				{
				case 20:
				case 41:
					if ((type & MemberTypes.Property) != 0)
					{
						num2 = 3;
						continue;
					}
					goto case 4;
				case 25:
					num3 = 0;
					num2 = 31;
					continue;
				case 55:
					if (type == MemberTypes.Field)
					{
						num2 = 56;
						continue;
					}
					num4 += array9.Length;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					if ((type & MemberTypes.Event) != 0)
					{
						num = 11;
						break;
					}
					goto case 52;
				case 48:
					if (type == MemberTypes.Method)
					{
						num2 = 6;
						continue;
					}
					num4 += array7.Length;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 10;
					}
					continue;
				case 36:
					array7 = GetMethods(bindingAttr).Where(_003C_003Ec__DisplayClass7_._003CGetMember_003Eb__0).ToArray();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 48;
					}
					continue;
				case 1:
					array4.CopyTo(array5, num3);
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 33;
					}
					continue;
				case 57:
					array = array8;
					num2 = 26;
					continue;
				case 35:
					array9.CopyTo(array5, num3);
					num2 = 28;
					continue;
				default:
					hGj8KShSe4rjl079d1BZ(array3, array5, num3);
					num2 = 16;
					continue;
				case 52:
					if ((type & MemberTypes.Field) == 0)
					{
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 34;
				case 60:
					array4 = new EventInfo[0];
					num2 = 24;
					continue;
				case 17:
					return array;
				case 26:
					return array;
				case 37:
					num3 += array4.Length;
					num = 35;
					break;
				case 27:
					num4 = 0;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 21;
					}
					continue;
				case 58:
					if (type != MemberTypes.Event)
					{
						num4 += array4.Length;
						num2 = 52;
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 44:
					if (type == (MemberTypes.Constructor | MemberTypes.Method))
					{
						array = new MethodBase[num4];
						num2 = 39;
						continue;
					}
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 43;
					}
					continue;
				case 56:
					array = array9;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 30;
					}
					continue;
				case 2:
					num3 += array7.Length;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 50:
					if (type != MemberTypes.NestedType)
					{
						num2 = 22;
						continue;
					}
					goto case 42;
				case 53:
					throw new ArgumentNullException();
				case 42:
					array = array6;
					num2 = 8;
					continue;
				case 38:
					if (_003C_003Ec__DisplayClass7_.name != null)
					{
						array7 = new MethodInfo[0];
						num2 = 59;
						continue;
					}
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 53;
					}
					continue;
				case 54:
					num3 += array6.Length;
					num2 = 40;
					continue;
				case 11:
					array4 = GetEvents(bindingAttr).Where(_003C_003Ec__DisplayClass7_._003CGetMember_003Eb__2).ToArray();
					num2 = 58;
					continue;
				case 31:
					hGj8KShSe4rjl079d1BZ(array7, array5, num3);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 2;
					}
					continue;
				case 46:
					_003C_003Ec__DisplayClass7_.name = name;
					num2 = 38;
					continue;
				case 14:
					if (type != MemberTypes.Property)
					{
						num4 += array8.Length;
						num2 = 4;
					}
					else
					{
						num2 = 57;
					}
					continue;
				case 23:
					return array;
				case 15:
					array6 = GetNestedTypes(bindingAttr).Where(_003C_003Ec__DisplayClass7_._003CGetMember_003Eb__4).ToArray();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 50;
					}
					continue;
				case 33:
					array6 = new Type[0];
					num2 = 27;
					continue;
				case 3:
					array8 = GetProperties(bindingAttr).Where(_003C_003Ec__DisplayClass7_._003CGetMember_003Eb__1).ToArray();
					num2 = 14;
					continue;
				case 5:
					array = array4;
					num2 = 17;
					continue;
				case 28:
					num3 += array9.Length;
					num2 = 12;
					continue;
				case 6:
					array = array7;
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 14;
					}
					continue;
				case 7:
				case 29:
					if ((type & (MemberTypes.TypeInfo | MemberTypes.NestedType)) != 0)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 44;
				case 45:
					return array;
				case 40:
					return array5;
				case 13:
					array8 = new PropertyInfo[0];
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 60;
					}
					continue;
				case 24:
					array9 = new FieldInfo[0];
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					if (type == MemberTypes.TypeInfo)
					{
						num2 = 42;
						continue;
					}
					num4 += array6.Length;
					num2 = 44;
					continue;
				case 30:
					return array;
				case 34:
					array9 = GetFields(bindingAttr).Where(_003C_003Ec__DisplayClass7_._003CGetMember_003Eb__3).ToArray();
					num2 = 55;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					return array;
				case 47:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num = 46;
					break;
				case 49:
					num3 += array8.Length;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				case 59:
					array3 = new ConstructorInfo[0];
					num2 = 13;
					continue;
				case 9:
				case 10:
					if ((type & MemberTypes.Constructor) == 0)
					{
						num2 = 20;
						continue;
					}
					goto case 32;
				case 16:
					num3 += array3.Length;
					num2 = 51;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 8;
					}
					continue;
				case 43:
					array2 = new MemberInfo[num4];
					goto IL_0748;
				case 51:
					hGj8KShSe4rjl079d1BZ(array8, array5, num3);
					num2 = 49;
					continue;
				case 19:
					if (type != MemberTypes.Constructor)
					{
						num4 += array3.Length;
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 18;
					}
					continue;
				case 12:
					hGj8KShSe4rjl079d1BZ(array6, array5, num3);
					num = 54;
					break;
				case 32:
					array3 = GetConstructors(bindingAttr);
					num2 = 19;
					continue;
				case 21:
					if ((type & MemberTypes.Method) == 0)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 36;
				case 18:
					array = array3;
					num2 = 45;
					continue;
				case 39:
					{
						array2 = array;
						goto IL_0748;
					}
					IL_0748:
					array5 = array2;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 25;
					}
					continue;
				}
				break;
			}
		}
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return customAttributesData.Value.GetCustomAttributesData();
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return customAttributesData.Value.IsDefined(attributeType, inherit, BaseType);
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return customAttributesData.Value.GetCustomAttributes(inherit, BaseType);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return customAttributesData.Value.GetCustomAttributes(attributeType, inherit, BaseType);
	}

	internal static void RHqclahS2TK5ooCPp3RJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fqKWRehSnJMrvUXkFxIT()
	{
		return (object)EnnLcShSkSJAqNy9kHna == null;
	}

	internal static BaseTypeDelegator T1ChYqhSOoR8qoGd9ug5()
	{
		return EnnLcShSkSJAqNy9kHna;
	}

	internal static void hGj8KShSe4rjl079d1BZ(object P_0, object P_1, int P_2)
	{
		((Array)P_0).CopyTo((Array)P_1, P_2);
	}
}
