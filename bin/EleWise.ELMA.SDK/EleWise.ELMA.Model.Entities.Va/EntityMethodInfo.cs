using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal abstract class EntityMethodInfo : MethodInfo
{
	protected class EntityMethodParameterInfo : ParameterInfo
	{
		internal static EntityMethodParameterInfo eldK6BvWIq9ltg1FWawT;

		public override IEnumerable<CustomAttributeData> CustomAttributes { get; }

		public override object DefaultValue { get; }

		public override bool HasDefaultValue => false;

		public override object RawDefaultValue { get; }

		public EntityMethodParameterInfo(MemberInfo member, Type parameterType, string name = null, int position = -1)
		{
			//Discarded unreachable code: IL_005b
			SingletonReader.JJCZtPuTvSt();
			CustomAttributes = new CustomAttributeData[0];
			DefaultValue = DBNull.Value;
			RawDefaultValue = DBNull.Value;
			base._002Ector();
			int num = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 6:
					PositionImpl = position;
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num = 5;
					}
					break;
				case 2:
					ClassImpl = parameterType;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num = 1;
					}
					break;
				case 4:
					return;
				case 3:
				{
					MemberImpl = member;
					int num2 = 2;
					num = num2;
					break;
				}
				case 1:
					NameImpl = name;
					num = 6;
					break;
				case 5:
					AttrsImpl = ParameterAttributes.None;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num = 0;
					}
					break;
				default:
					DefaultValueImpl = null;
					num = 4;
					break;
				}
			}
		}

		internal static bool YsRfSDvWVMnh2ib3ZWU7()
		{
			return eldK6BvWIq9ltg1FWawT == null;
		}

		internal static EntityMethodParameterInfo exWdkZvWSN03n8HvbTRi()
		{
			return eldK6BvWIq9ltg1FWawT;
		}
	}

	private static readonly CustomAttributeData[] customAttributes;

	private static EntityMethodInfo qt3QUjhSU42DB9vteJ7Y;

	public override string Name { get; }

	public override Type DeclaringType { get; }

	public override Type ReflectedType { get; }

	public override MethodAttributes Attributes => MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName;

	public override CallingConventions CallingConvention => CallingConventions.Standard | CallingConventions.HasThis;

	public override IEnumerable<CustomAttributeData> CustomAttributes => customAttributes;

	public override bool IsSecurityCritical => true;

	public override bool IsSecuritySafeCritical => false;

	public override bool IsSecurityTransparent => false;

	public override Module Module => nPL6SkhihnYesEbHI3JD(this).Module;

	public override MethodImplAttributes MethodImplementationFlags => MethodImplAttributes.CodeTypeMask;

	public override RuntimeMethodHandle MethodHandle
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override ICustomAttributeProvider ReturnTypeCustomAttributes => ReturnParameter;

	public EntityMethodInfo(Type declaringType, Type reflectedType, string name)
	{
		//Discarded unreachable code: IL_002a
		FUkvephSzKCtllcAqegk();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			default:
				ReflectedType = reflectedType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num = 1;
				}
				break;
			case 1:
			{
				Name = name;
				int num2 = 3;
				num = num2;
				break;
			}
			case 2:
				DeclaringType = declaringType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)juk5UphibkbQQ9enIeUV(L9RaXehiFhZw90PhTjEh(-16752921 ^ -16573867), sYfQaahiBfqYDdfhEOjV(this), AdrDYchiWMKlZVy6EgPI(this), string.Join((string)L9RaXehiFhZw90PhTjEh(-475857671 ^ -475860741), ((IEnumerable<ParameterInfo>)h8ugWphioOMtdbVFXb7x(this)).Select((ParameterInfo p) => _003C_003Ec.ujaq2bvWX6sNtlutMO4h(p).ToString())));
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return MethodImplAttributes.CodeTypeMask;
	}

	public override MethodInfo GetBaseDefinition()
	{
		return this;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return CustomAttributes.Cast<object>().ToArray();
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = default(_003C_003Ec__DisplayClass36_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass36_.attributeType = attributeType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return CustomAttributes.Where(_003C_003Ec__DisplayClass36_._003CGetCustomAttributes_003Eb__0).Cast<object>().ToArray();
			}
		}
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = default(_003C_003Ec__DisplayClass37_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass37_.attributeType = attributeType;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return CustomAttributes.Any(_003C_003Ec__DisplayClass37_._003CIsDefined_003Eb__0);
			}
		}
	}

	static EntityMethodInfo()
	{
		int num = 3;
		int num2 = num;
		CustomAttributeData[] array = default(CustomAttributeData[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				FUkvephSzKCtllcAqegk();
				num2 = 2;
				break;
			case 1:
				customAttributes = array;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				array = new EntityCustomAttributeData[1]
				{
					new EntityCustomAttributeData(TypeOf<CompilerGeneratedAttribute>.Raw.GetConstructor(new Type[0]))
				};
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void FUkvephSzKCtllcAqegk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hWPopRhSskluxb7urQoO()
	{
		return (object)qt3QUjhSU42DB9vteJ7Y == null;
	}

	internal static EntityMethodInfo ygqqZGhScgpCrLCBwCdk()
	{
		return qt3QUjhSU42DB9vteJ7Y;
	}

	internal static object L9RaXehiFhZw90PhTjEh(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type sYfQaahiBfqYDdfhEOjV(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static object AdrDYchiWMKlZVy6EgPI(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object h8ugWphioOMtdbVFXb7x(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object juk5UphibkbQQ9enIeUV(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static Type nPL6SkhihnYesEbHI3JD(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}
}
