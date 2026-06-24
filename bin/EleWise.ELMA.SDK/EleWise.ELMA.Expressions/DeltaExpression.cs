using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Cecil.Cil;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Expressions;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class DeltaExpression
{
	private sealed class InternalMethodInfo : IEquatable<MethodReference>
	{
		private readonly object methodName;

		private readonly object returnTypeName;

		private readonly IEnumerable<string> paramsTypeName;

		public readonly object MethodInfo;

		private static object rI5OCnQqK668d8NfLi9L;

		public InternalMethodInfo(string methodName, string returnTypeName, IEnumerable<string> paramsTypeName, MethodInfo methodInfo)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.methodName = methodName;
			this.returnTypeName = returnTypeName;
			this.paramsTypeName = paramsTypeName;
			MethodInfo = methodInfo;
		}

		public bool Equals(MethodReference obj)
		{
			//Discarded unreachable code: IL_0039, IL_0048, IL_00af, IL_00be
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (!Eq6egWQqnVVm2asXFYJg(returnTypeName, ((MemberReference)obj.get_ReturnType()).get_Name()))
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 2:
					return false;
				default:
					if (Eq6egWQqnVVm2asXFYJg(methodName, irxAK8QqkfgfAsXiGSwF(obj)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				case 1:
					if (obj != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 5:
					return paramsTypeName.SequenceEqual(((IEnumerable<ParameterDefinition>)obj.get_Parameters()).Select((ParameterDefinition parameter) => (string)_003C_003Ec.pwQMJwZvHPaeCOhy336J(_003C_003Ec.pk5abPZv6XFErXUWuHDo(parameter))));
				case 3:
					break;
				}
				break;
			}
			return false;
		}

		internal static object irxAK8QqkfgfAsXiGSwF(object P_0)
		{
			return ((MemberReference)P_0).get_Name();
		}

		internal static bool Eq6egWQqnVVm2asXFYJg(object P_0, object P_1)
		{
			return ((string)P_0).Equals((string)P_1);
		}

		internal static bool Vv3FqmQqXLEcIoDfBjqb()
		{
			return rI5OCnQqK668d8NfLi9L == null;
		}

		internal static InternalMethodInfo RAKbIfQqTLVUvEZEnvrt()
		{
			return (InternalMethodInfo)rI5OCnQqK668d8NfLi9L;
		}
	}

	private static readonly InternalMethodInfo[] MethodsToReplace;

	internal static DeltaExpression cj6KYYBejQXBgV7ZQ0dF;

	static DeltaExpression()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				MethodsToReplace = (from method in typeof(DeltaExpression).GetMethods(BindingFlags.Static | BindingFlags.Public)
					where _003C_003Ec.aKb5FMQq3Y3I1IpG7EBW(_003C_003Ec.jmYMNRQq1JQVNnqyTebu(method), _003C_003Ec.ai5KHfQqNO6jXSJgqBt3(0x4DC2B14D ^ 0x4DC08F3F))
					select new InternalMethodInfo((string)_003C_003Ec.jmYMNRQq1JQVNnqyTebu(method), (string)_003C_003Ec.jmYMNRQq1JQVNnqyTebu(_003C_003Ec.kM8FTPQqprRhySkrFVOE(method)), ((IEnumerable<ParameterInfo>)_003C_003Ec.vUXhm3QqaAbWSRiF8q4T(method)).Select((ParameterInfo parameter) => (string)_003C_003Ec.jmYMNRQq1JQVNnqyTebu(parameter.ParameterType)).ToArray(), method)).ToArray();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static bool CheckAndReplace(ModuleDefinition module, Instruction instruction)
	{
		//Discarded unreachable code: IL_0066, IL_0075
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		int num = 9;
		MethodReference val2 = default(MethodReference);
		InternalMethodInfo internalMethodInfo = default(InternalMethodInfo);
		int num3 = default(int);
		InternalMethodInfo[] methodsToReplace = default(InternalMethodInfo[]);
		MethodReference val = default(MethodReference);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					val2 = module.Import((MethodBase)internalMethodInfo.MethodInfo);
					num2 = 7;
					continue;
				case 3:
				case 10:
					if (num3 >= methodsToReplace.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto default;
				case 6:
					return true;
				case 1:
					num3 = 0;
					num2 = 10;
					continue;
				default:
					internalMethodInfo = methodsToReplace[num3];
					num2 = 4;
					continue;
				case 9:
					break;
				case 8:
					methodsToReplace = MethodsToReplace;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					HQhZFQBecA6SlIjYnE6C(instruction, val2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					return false;
				case 4:
					if (!kkpPg3BesckTs6vvmlGH(internalMethodInfo, val))
					{
						num3++;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 5;
						}
					}
					continue;
				}
				break;
			}
			val = (MethodReference)pHWoFsBeUxjDFLSFdHae(instruction);
			num = 8;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_00a7, IL_00b6, IL_00e7, IL_00f6
		int num = 10;
		ParameterInfo parameterInfo = default(ParameterInfo);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					parameterInfo = propertyAccessor.GetParameters().FirstOrDefault();
					num2 = 5;
					break;
				case 7:
					if (xFLcOnBPhyHydqAMCtX5(hJO5CbBPoxcjhOh8Ukof(), NVuFbdBPbl52A17PZhMY(parameterInfo)))
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 5:
					if (parameterInfo == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto default;
				case 10:
					Tuh1mWBPFbtm6q8n1PiI(propertyAccessor, I8oRoUBezhdHWuHcZFjF(-1767720453 ^ -1767667867));
					num2 = 9;
					break;
				case 1:
				case 6:
				case 8:
					return (MemberExpression)v6bxG1BPGeHV5aov5kte(expression, propertyAccessor);
				case 3:
					text = ((string)SrT6CvBPWJsD2ERVX9IX(propertyAccessor)).Substring(4);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 11;
					}
					break;
				case 4:
					if (!propertyAccessor.Name.StartsWith((string)I8oRoUBezhdHWuHcZFjF(-740338220 ^ -740337324)))
					{
						num2 = 2;
						break;
					}
					goto case 7;
				default:
					if (SZaBbJBPBWv7aPXdpiZw(propertyAccessor))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 11:
					return (MemberExpression)xwNFj6BPEWue5XOyjLYe(expression, NVuFbdBPbl52A17PZhMY(parameterInfo), text);
				case 2:
					if (!((string)SrT6CvBPWJsD2ERVX9IX(propertyAccessor)).StartsWith((string)I8oRoUBezhdHWuHcZFjF(0x7E6E5A0B ^ 0x7E6E5687)))
					{
						num2 = 6;
						break;
					}
					goto case 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static MemberExpression Property(Expression expression, PropertyInfo property)
	{
		//Discarded unreachable code: IL_00a4, IL_00b3
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!xFLcOnBPhyHydqAMCtX5(hJO5CbBPoxcjhOh8Ukof(), type))
				{
					num2 = 5;
					break;
				}
				return (MemberExpression)xwNFj6BPEWue5XOyjLYe(expression, type, SrT6CvBPWJsD2ERVX9IX(property));
			default:
				if (Q93vSWBPQMbIc62D3MD5(type, null))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 1:
				type = E0rFFlBPfOb5fO8vGH4b(property);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
			case 5:
				return Expression.Property(expression, property);
			case 2:
				Tuh1mWBPFbtm6q8n1PiI(property, I8oRoUBezhdHWuHcZFjF(-97972138 ^ -98039472));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static MemberExpression Property(Expression expression, string propertyName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Property(expression, FZZEd8BPCQ5BFwYM4hoR(expression), propertyName);
			case 1:
				Tuh1mWBPFbtm6q8n1PiI(expression, I8oRoUBezhdHWuHcZFjF(0x1DE3DD89 ^ 0x1DE3D08D));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static MemberExpression Property(Expression expression, Type type, string propertyName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!xFLcOnBPhyHydqAMCtX5(EntityDynamicProvider.Instance, type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return (MemberExpression)xwNFj6BPEWue5XOyjLYe(expression, type, propertyName);
			case 1:
				Tuh1mWBPFbtm6q8n1PiI(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740337162));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return (MemberExpression)mBTQ5EBP8EI91jw4hDXP(expression, propertyName);
			default:
				TsWWvCBPvxvHcO7BruWd(propertyName, I8oRoUBezhdHWuHcZFjF(0x6A81B9B4 ^ 0x6A808776));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static MemberExpression PropertyOrField(Expression expression, string propertyOrFieldName)
	{
		//Discarded unreachable code: IL_00f2, IL_0101
		int num = 7;
		Type type = default(Type);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (((TypeDescriptionProvider)hJO5CbBPoxcjhOh8Ukof()).IsSupportedType(type))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 7:
					Tuh1mWBPFbtm6q8n1PiI(expression, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA0DCA));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 4;
					}
					break;
				case 5:
					return (MemberExpression)bxUkiCBPZIRFqXhnuQFT(expression, propertyOrFieldName);
				default:
					propertyInfo = (PropertyInfo)fOLlYFBPuoYy1HU5NqoF(type, propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					type = expression.Type;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					if (d10FL3BPIIcqbRqDrH6Y(propertyInfo, null))
					{
						return (MemberExpression)mbFqmBBPVETN3mvrMgHw(expression, propertyInfo);
					}
					goto end_IL_0012;
				case 2:
					return (MemberExpression)bxUkiCBPZIRFqXhnuQFT(expression, propertyOrFieldName);
				case 6:
					TsWWvCBPvxvHcO7BruWd(propertyOrFieldName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A4EB31));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private static MemberExpression PropertyInternal(object expression, Type type, object propertyName)
	{
		int num = 1;
		int num2 = num;
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new InvalidOperationException(SR.T((string)I8oRoUBezhdHWuHcZFjF(-3333094 ^ -3400942), propertyName, type.FullName));
			case 1:
				propertyInfo = (PropertyInfo)lMNeyoBPS2SBFWHLl3bq(type, propertyName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (Va27l1BPioZdRsB1ryoQ(propertyInfo, null))
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return (MemberExpression)mbFqmBBPVETN3mvrMgHw(expression, propertyInfo);
		}
	}

	internal static bool e92LI6BeYTpeamFNOf2w()
	{
		return cj6KYYBejQXBgV7ZQ0dF == null;
	}

	internal static DeltaExpression vk8phKBeLg9Z9TGZnVrw()
	{
		return cj6KYYBejQXBgV7ZQ0dF;
	}

	internal static object pHWoFsBeUxjDFLSFdHae(object P_0)
	{
		return ((Instruction)P_0).get_Operand();
	}

	internal static bool kkpPg3BesckTs6vvmlGH(object P_0, object P_1)
	{
		return ((InternalMethodInfo)P_0).Equals((MethodReference)P_1);
	}

	internal static void HQhZFQBecA6SlIjYnE6C(object P_0, object P_1)
	{
		((Instruction)P_0).set_Operand(P_1);
	}

	internal static object I8oRoUBezhdHWuHcZFjF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Tuh1mWBPFbtm6q8n1PiI(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool SZaBbJBPBWv7aPXdpiZw(object P_0)
	{
		return ((MethodBase)P_0).IsStatic;
	}

	internal static object SrT6CvBPWJsD2ERVX9IX(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object hJO5CbBPoxcjhOh8Ukof()
	{
		return EntityDynamicProvider.Instance;
	}

	internal static Type NVuFbdBPbl52A17PZhMY(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static bool xFLcOnBPhyHydqAMCtX5(object P_0, Type P_1)
	{
		return ((TypeDescriptionProvider)P_0).IsSupportedType(P_1);
	}

	internal static object v6bxG1BPGeHV5aov5kte(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object xwNFj6BPEWue5XOyjLYe(object P_0, Type type, object P_2)
	{
		return PropertyInternal(P_0, type, P_2);
	}

	internal static Type E0rFFlBPfOb5fO8vGH4b(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static bool Q93vSWBPQMbIc62D3MD5(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type FZZEd8BPCQ5BFwYM4hoR(object P_0)
	{
		return ((Expression)P_0).Type;
	}

	internal static void TsWWvCBPvxvHcO7BruWd(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object mBTQ5EBP8EI91jw4hDXP(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (string)P_1);
	}

	internal static object bxUkiCBPZIRFqXhnuQFT(object P_0, object P_1)
	{
		return Expression.PropertyOrField((Expression)P_0, (string)P_1);
	}

	internal static object fOLlYFBPuoYy1HU5NqoF(Type type, object P_1, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperty((string)P_1, bindingAttr);
	}

	internal static bool d10FL3BPIIcqbRqDrH6Y(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object mbFqmBBPVETN3mvrMgHw(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (PropertyInfo)P_1);
	}

	internal static object lMNeyoBPS2SBFWHLl3bq(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool Va27l1BPioZdRsB1ryoQ(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}
}
