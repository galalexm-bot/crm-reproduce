using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Proxy;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Proxy;
using NHibernate.Proxy.DynamicProxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class TypeExtensions
{
	internal static readonly Type[] PredefinedTypes;

	private static readonly Func<Type, string, PropertyInfo> getPropertyCached;

	private static readonly Func<Type, string, BindingFlags, PropertyInfo> getPropertyWithBindingFlagsCached;

	private static readonly Func<Type, PropertyInfo[]> getPropertiesCached;

	private static readonly HashSet<Type> FunctionTypes;

	private static IEnumerable<ITypePropertyExtensionPoint> typePropertyExtensions;

	internal static TypeExtensions yhgJtiGAevwljcsZdAGJ;

	internal static bool IsPredefinedType(this Type type)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass1_.type = type;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return PredefinedTypes.Any(_003C_003Ec__DisplayClass1_._003CIsPredefinedType_003Eb__0);
			}
		}
	}

	internal static string FirstSortableProperty(this Type type)
	{
		PropertyInfo propertyInfo = ((IEnumerable<PropertyInfo>)XiV8YTGANEw6bTpQMIH7(type)).FirstOrDefault((PropertyInfo property) => property.PropertyType.IsPredefinedType());
		if (Kq06pdGA3kCenFfv31dF(propertyInfo, null))
		{
			throw new NotSupportedException((string)BtJq4uGApa5eJ364GC3o(-1334993905 ^ -1335256667));
		}
		return (string)pnWPeyGAajbwsJT2dQUr(propertyInfo);
	}

	internal static bool IsNullableType(this Type type)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!type.IsGenericType)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return type.GetGenericTypeDefinition() == smL2k9GADPP32TicHiLn(typeof(Nullable<>).TypeHandle);
			case 1:
				return false;
			}
		}
	}

	internal static Type GetNonNullableType(this Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!J11aKKGAtRM7sIM2Drsm(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
				return type.GetGenericArguments()[0];
			default:
				return type;
			}
		}
	}

	public static bool IsAssignableFromNull(this Type type)
	{
		//Discarded unreachable code: IL_0042, IL_0051
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return J11aKKGAtRM7sIM2Drsm(type);
			case 4:
				return true;
			case 1:
				if (!type.IsInterface)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			default:
				if (!cBEGC9GAwJdkSZRNtkfl(type, smL2k9GADPP32TicHiLn(typeof(string).TypeHandle)))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 2:
				if (type.IsClass)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 3:
				if (!type.IsByRef)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	internal static string GetTypeName(this Type type)
	{
		//Discarded unreachable code: IL_0062, IL_0071
		int num = 3;
		string text = default(string);
		Type type2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 2:
					text = type2.Name;
					num2 = 5;
					continue;
				default:
					return text;
				case 4:
					text += (string)BtJq4uGApa5eJ364GC3o(-672123589 ^ -672125583);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (!oU0wejGA6Uk1xQxoF083(type, type2))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			type2 = ordBKSGA4jmr2Fy38y2i(type);
			num = 2;
		}
	}

	internal static bool IsNumericType(this Type type)
	{
		return type.GetNumericTypeKind() != 0;
	}

	internal static bool IsSignedIntegralType(this Type type)
	{
		return type.GetNumericTypeKind() == 2;
	}

	internal static bool IsUnsignedIntegralType(this Type type)
	{
		return DfpENyGAH2LKm1q91vZ1(type) == 3;
	}

	internal static int GetNumericTypeKind(this Type type)
	{
		//Discarded unreachable code: IL_008a, IL_0099, IL_00eb
		int num = 3;
		int num2 = num;
		TypeCode typeCode = default(TypeCode);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return 0;
			case 2:
				type = ordBKSGA4jmr2Fy38y2i(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				return 1;
			case 4:
				return 0;
			case 3:
				if (!cBEGC9GAwJdkSZRNtkfl(type, null))
				{
					num2 = 2;
					continue;
				}
				goto case 7;
			case 5:
				return 0;
			case 1:
				switch (typeCode)
				{
				case TypeCode.Char:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					break;
				case TypeCode.SByte:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
					return 2;
				case TypeCode.Byte:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					return 3;
				default:
					num2 = 4;
					continue;
				}
				goto case 6;
			}
			if (type.IsEnum)
			{
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 3;
				}
				continue;
			}
			typeCode = nE2wDjGAAxob0mmmeboZ(type);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
			{
				num2 = 1;
			}
		}
	}

	internal static PropertyInfo GetIndexerPropertyInfo(this Type type, params Type[] indexerArguments)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass11_.indexerArguments = indexerArguments;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return ((IEnumerable<PropertyInfo>)XiV8YTGANEw6bTpQMIH7(type)).Where(_003C_003Ec__DisplayClass11_._003CGetIndexerPropertyInfo_003Eb__0).FirstOrDefault();
			}
		}
	}

	private static bool AreArgumentsApplicable(IEnumerable<Type> arguments, IEnumerable<ParameterInfo> parameters)
	{
		List<Type> list = arguments.ToList();
		List<ParameterInfo> list2 = parameters.ToList();
		if (list.Count != list2.Count)
		{
			return false;
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list2[i].ParameterType != list[i])
			{
				return false;
			}
		}
		return true;
	}

	internal static bool IsEnumType(this Type type)
	{
		return type.GetNonNullableType().IsEnum;
	}

	internal static bool IsCompatibleWith(this Type source, Type target)
	{
		//Discarded unreachable code: IL_017b, IL_018a, IL_01e1, IL_0207, IL_0265, IL_0274, IL_0287, IL_0296, IL_02a5, IL_02bc, IL_02cd, IL_02fe, IL_0322, IL_0331, IL_0357, IL_0366, IL_039d, IL_03ac, IL_0472, IL_0481
		int num = 11;
		Type nonNullableType = default(Type);
		Type type = default(Type);
		TypeCode typeCode2 = default(TypeCode);
		TypeCode typeCode = default(TypeCode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				case 31:
					return true;
				case 22:
					return true;
				case 19:
					if (cBEGC9GAwJdkSZRNtkfl(nonNullableType, type))
					{
						num2 = 16;
						continue;
					}
					goto IL_046b;
				case 30:
					if (!type.IsEnum)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 14;
						}
						continue;
					}
					num4 = 1;
					goto IL_04d8;
				case 8:
					return true;
				case 20:
					return target.IsAssignableFrom(source);
				case 29:
					nonNullableType = source.GetNonNullableType();
					num = 24;
					break;
				case 5:
					return true;
				case 15:
					return false;
				case 12:
				case 18:
					if (nonNullableType.IsEnum)
					{
						num2 = 13;
						continue;
					}
					goto default;
				case 28:
					return true;
				case 24:
					type = ordBKSGA4jmr2Fy38y2i(target);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 26;
					}
					continue;
				case 2:
					return true;
				case 17:
					goto IL_0211;
				default:
					num3 = (int)nE2wDjGAAxob0mmmeboZ(nonNullableType);
					goto IL_04bb;
				case 32:
					num4 = (int)nE2wDjGAAxob0mmmeboZ(type);
					goto IL_04d8;
				case 26:
					if (!(nonNullableType != source))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 21;
				case 23:
					if ((uint)(typeCode2 - 13) > 2u)
					{
						num2 = 9;
						continue;
					}
					goto case 8;
				case 11:
					if (!cBEGC9GAwJdkSZRNtkfl(source, target))
					{
						num2 = 10;
						continue;
					}
					goto case 4;
				case 4:
					return true;
				case 10:
					if (target.IsValueType)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 20;
				case 7:
					switch (typeCode)
					{
					case TypeCode.UInt16:
						break;
					case TypeCode.UInt64:
						goto IL_0110;
					case TypeCode.UInt32:
						goto IL_0145;
					case TypeCode.Int64:
						goto IL_0197;
					case TypeCode.Single:
						goto IL_01ed;
					case TypeCode.SByte:
						goto IL_0211;
					default:
						goto IL_03e4;
					case TypeCode.Int32:
						goto IL_03f0;
					case TypeCode.Int16:
						goto IL_0422;
					case TypeCode.Byte:
						goto IL_04a5;
					}
					if ((uint)(typeCode2 - 8) <= 7u)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto IL_046b;
				case 3:
					return true;
				case 14:
					return true;
				case 16:
					return true;
				case 1:
				case 6:
				case 9:
				case 25:
				case 33:
				case 34:
					goto IL_046b;
				case 21:
					if (!cBEGC9GAwJdkSZRNtkfl(type, target))
					{
						num2 = 18;
						continue;
					}
					goto case 15;
				case 27:
					goto IL_04a3;
				case 13:
					{
						num3 = 1;
						goto IL_04bb;
					}
					IL_04a5:
					if ((uint)(typeCode2 - 6) <= 9u)
					{
						num2 = 14;
						continue;
					}
					goto IL_046b;
					IL_0422:
					switch (typeCode2)
					{
					case TypeCode.Int16:
					case TypeCode.Int32:
					case TypeCode.Int64:
					case TypeCode.Single:
					case TypeCode.Double:
					case TypeCode.Decimal:
						break;
					default:
						goto IL_044f;
					case TypeCode.UInt16:
					case TypeCode.UInt32:
					case TypeCode.UInt64:
						goto IL_046b;
					}
					goto case 31;
					IL_044f:
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					continue;
					IL_03f0:
					switch (typeCode2)
					{
					case TypeCode.Int32:
					case TypeCode.Int64:
					case TypeCode.Single:
					case TypeCode.Double:
					case TypeCode.Decimal:
						break;
					default:
						goto IL_0416;
					case TypeCode.UInt32:
					case TypeCode.UInt64:
						goto IL_046b;
					}
					goto case 5;
					IL_0416:
					num2 = 25;
					continue;
					IL_03e4:
					num2 = 19;
					continue;
					IL_01ed:
					if ((uint)(typeCode2 - 13) <= 1u)
					{
						num2 = 22;
						continue;
					}
					goto IL_046b;
					IL_0197:
					if (typeCode2 != TypeCode.Int64)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 8;
					IL_04d8:
					typeCode2 = (TypeCode)num4;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 7;
					}
					continue;
					IL_0145:
					if ((uint)(typeCode2 - 10) > 5u)
					{
						num = 33;
						break;
					}
					goto case 28;
					IL_0110:
					if ((uint)(typeCode2 - 12) > 3u)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
					IL_04bb:
					typeCode = (TypeCode)num3;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 30;
					}
					continue;
					IL_046b:
					return false;
					IL_0211:
					switch (typeCode2)
					{
					case TypeCode.Byte:
					case TypeCode.UInt16:
					case TypeCode.UInt32:
					case TypeCode.UInt64:
						goto IL_046b;
					case TypeCode.SByte:
					case TypeCode.Int16:
					case TypeCode.Int32:
					case TypeCode.Int64:
					case TypeCode.Single:
					case TypeCode.Double:
					case TypeCode.Decimal:
						goto IL_04a3;
					}
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 30;
					}
					continue;
					IL_04a3:
					return true;
				}
				break;
			}
		}
	}

	public static PropertyInfo GetPropertyFor<TType, TValue>(this Type typeObject, [NotNull] Expression<Func<TType, TValue>> propertyExpression)
	{
		if (propertyExpression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF43A7));
		}
		if (!(propertyExpression.Body is MemberExpression memberExpression) || !(memberExpression.Member is PropertyInfo))
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C573EEB)));
		}
		return (PropertyInfo)memberExpression.Member;
	}

	internal static PropertyInfo GetPropertyCached([NotNull] this Type typeObject, [NotNull] string propertyName, BindingFlags bindingAttr)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return getPropertyWithBindingFlagsCached(typeObject, propertyName, bindingAttr);
			case 1:
				H8EWG7GA7U93mfT0707H(typeObject, BtJq4uGApa5eJ364GC3o(-1146510045 ^ -1146248369));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Contract.ArgumentNotNullOrEmpty(propertyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53D9261));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static PropertyInfo GetPropertyCached([NotNull] this Type typeObject, [NotNull] string propertyName)
	{
		//Discarded unreachable code: IL_0059, IL_009f
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4CCF31));
			default:
				return getPropertyCached(typeObject, propertyName);
			case 3:
				throw new ArgumentNullException((string)BtJq4uGApa5eJ364GC3o(--1418440330 ^ 0x548FA8E6));
			case 1:
				if (propertyName != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				if (!cBEGC9GAwJdkSZRNtkfl(typeObject, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public static PropertyInfo[] GetPropertiesCached([NotNull] this Type typeObject)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)BtJq4uGApa5eJ364GC3o(-576149596 ^ -575888952));
			case 1:
				if (!cBEGC9GAwJdkSZRNtkfl(typeObject, null))
				{
					return getPropertiesCached(typeObject);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Type FindGenericType(this Type type, Type genericType)
	{
		//Discarded unreachable code: IL_007c, IL_008b, IL_00ca, IL_00d9, IL_00e8, IL_015e, IL_016d, IL_01e1
		int num = 11;
		int num2 = num;
		Type type2 = default(Type);
		int num3 = default(int);
		Type[] interfaces = default(Type[]);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return type2;
			case 3:
				num3++;
				num2 = 17;
				break;
			case 8:
				if (!(type != smL2k9GADPP32TicHiLn(typeof(object).TypeHandle)))
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 10;
			case 14:
				return null;
			case 7:
			case 11:
				if (oU0wejGA6Uk1xQxoF083(type, null))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 14;
			case 16:
				if (!oU0wejGA6Uk1xQxoF083(type2, null))
				{
					num2 = 3;
					break;
				}
				goto case 9;
			case 12:
				return type;
			case 15:
				if (genericType.IsInterface)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if (type.GetGenericTypeDefinition() == genericType)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 15;
			case 1:
				type = type.BaseType;
				num2 = 7;
				break;
			case 13:
			case 17:
				if (num3 < interfaces.Length)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			default:
				interfaces = type.GetInterfaces();
				num2 = 5;
				break;
			case 2:
			case 6:
				type2 = gCEJdMGAxXpuL6tCFvL9(interfaces[num3], genericType);
				num2 = 16;
				break;
			case 5:
				num3 = 0;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				if (!type.IsGenericType)
				{
					num2 = 15;
					break;
				}
				goto case 4;
			}
		}
	}

	internal static string GetName(this Type type)
	{
		return (string)BkXAMuGAmca9Lvf3mBZs(type.FullName, VhosKoGA0yq75QqaG88B(type.Namespace, BtJq4uGApa5eJ364GC3o(--1333735954 ^ 0x4F7F28D6)), "");
	}

	public static object DefaultValue(this Type type)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return tAbrcAGAydmxyfmLE2N4(type);
			default:
				return null;
			case 1:
				if (!type.IsValueType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static object DefaultIdentifierValue(this Type type, Type idType)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		ITypePropertyExtensionPoint typePropertyExtension = default(ITypePropertyExtensionPoint);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!idType.IsValueType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				if (typePropertyExtension == null)
				{
					num2 = 4;
					break;
				}
				return GL6oCeGAMDKnFoLKFiFo(typePropertyExtension, type, idType, true);
			case 4:
				return null;
			case 2:
				return tAbrcAGAydmxyfmLE2N4(idType);
			default:
				typePropertyExtension = GetTypePropertyExtension(type);
				num2 = 3;
				break;
			}
		}
	}

	public static bool IsDefaultId(this Type type, Type idType, object idValue)
	{
		//Discarded unreachable code: IL_0090, IL_009f
		int num = 3;
		int num2 = num;
		ITypePropertyExtensionPoint typePropertyExtensionPoint = default(ITypePropertyExtensionPoint);
		while (true)
		{
			switch (num2)
			{
			default:
				return Convert.ToInt64(idValue) == 0;
			case 4:
				return true;
			case 1:
				if (idValue == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 3:
				typePropertyExtensionPoint = (ITypePropertyExtensionPoint)O89GUqGAJAIQg9w0buIG(type);
				num2 = 2;
				break;
			case 2:
				if (typePropertyExtensionPoint != null)
				{
					return ICUCE6GA93ucJUpZu8h5(typePropertyExtensionPoint, type, idType, idValue);
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static long ConvertToNewId(this Type type, Type idType, object idValue)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 2;
		int num2 = num;
		ITypePropertyExtensionPoint typePropertyExtension = default(ITypePropertyExtensionPoint);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (typePropertyExtension != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				return 0L;
			case 2:
				if (!AaFS5eGAdOcd9buB7j3B(type, idType, idValue))
				{
					typePropertyExtension = GetTypePropertyExtension(type);
					num2 = 4;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return KekYNwGAlrx8dfYqfExn(idValue);
			case 3:
				return typePropertyExtension.ConvertToNewId(type, idType, idValue);
			}
		}
	}

	public static object ConvertId(this Type type, Type idType, object id)
	{
		//Discarded unreachable code: IL_00a3, IL_00b6
		int num = 2;
		int num2 = num;
		ITypePropertyExtensionPoint typePropertyExtensionPoint = default(ITypePropertyExtensionPoint);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return Convert.ChangeType(id, idType);
			case 5:
				return cWK2E1GAgYilLCCd7cFw(typePropertyExtensionPoint, type, idType, id);
			default:
				if (typePropertyExtensionPoint != null)
				{
					num2 = 5;
					continue;
				}
				goto case 6;
			case 1:
			case 4:
				typePropertyExtensionPoint = (ITypePropertyExtensionPoint)O89GUqGAJAIQg9w0buIG(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (id != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			id = kP8jBHGAr4Te5pcUWRVm(type, idType);
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
			{
				num2 = 1;
			}
		}
	}

	public static bool IsNewId(this Type type, Type idType, object idValue)
	{
		return type.ConvertToNewId(idType, idValue) <= 0;
	}

	internal static MemberInfo FindPropertyOrField(this Type type, string memberName)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = DC7BFMGA5dLCqkDMR6nD(type, memberName, false);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				obj = DC7BFMGA5dLCqkDMR6nD(type, memberName, true);
				break;
			}
			break;
		}
		return (MemberInfo)obj;
	}

	internal static MemberInfo FindPropertyOrField(this Type type, string memberName, bool staticAccess)
	{
		//Discarded unreachable code: IL_005e, IL_006d, IL_0078, IL_00c9, IL_014d, IL_016c, IL_0198, IL_01a7
		int num = 2;
		int num2 = num;
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		MemberInfo[] array = default(MemberInfo[]);
		BindingFlags bindingAttr = default(BindingFlags);
		MemberInfo result = default(MemberInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = type.SelfAndBaseTypes().GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return null;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num3 = 1;
							}
							goto IL_007c;
						}
						goto IL_00f5;
						IL_00f5:
						array = enumerator.Current.FindMembers(MemberTypes.Field | MemberTypes.Property, bindingAttr, Type.FilterNameIgnoreCase, memberName);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num3 = 4;
						}
						goto IL_007c;
						IL_007c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return result;
							case 5:
								break;
							case 4:
								if (array.Length != 0)
								{
									num3 = 2;
									continue;
								}
								break;
							case 2:
								result = array[0];
								num3 = 3;
								continue;
							default:
								goto IL_00f5;
							case 1:
								goto end_IL_009e;
							}
							break;
						}
						continue;
						end_IL_009e:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num4 = 1;
						}
						goto IL_0151;
					}
					goto IL_0176;
					IL_0176:
					cGJrr8GAj7WYi6vBIAwA(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num4 = 0;
					}
					goto IL_0151;
					IL_0151:
					switch (num4)
					{
					default:
						goto end_IL_012c;
					case 1:
						goto end_IL_012c;
					case 2:
						break;
					case 0:
						goto end_IL_012c;
					}
					goto IL_0176;
					end_IL_012c:;
				}
				goto default;
			case 2:
				bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (staticAccess ? BindingFlags.Static : BindingFlags.Instance);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static IEnumerable<Type> SelfAndBaseTypes(this Type type)
	{
		if (type.IsInterface)
		{
			List<Type> list = new List<Type>();
			AddInterface(list, type);
			return list;
		}
		return type.SelfAndBaseClasses();
	}

	[IteratorStateMachine(typeof(_003CSelfAndBaseClasses_003Ed__33))]
	internal static IEnumerable<Type> SelfAndBaseClasses(this Type type)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CSelfAndBaseClasses_003Ed__33(-2)
		{
			_003C_003E3__type = type
		};
	}

	private static void AddInterface(List<Type> types, Type type)
	{
		if (!types.Contains(type))
		{
			types.Add(type);
			Type[] interfaces = type.GetInterfaces();
			foreach (Type type2 in interfaces)
			{
				AddInterface(types, type2);
			}
		}
	}

	internal static bool IsDataRow(this Type type)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (OMi2tLGAYKqyZE9qZq1O(type, smL2k9GADPP32TicHiLn(typeof(DataRow).TypeHandle)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return OMi2tLGAYKqyZE9qZq1O(type, smL2k9GADPP32TicHiLn(typeof(DataRowView).TypeHandle));
			case 1:
				return true;
			}
		}
	}

	internal static bool IsDateTime(this Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return cBEGC9GAwJdkSZRNtkfl(type, smL2k9GADPP32TicHiLn(typeof(DateTime?).TypeHandle));
			case 1:
				if (cBEGC9GAwJdkSZRNtkfl(type, smL2k9GADPP32TicHiLn(typeof(DateTime).TypeHandle)))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string ToJavaScriptType(this Type type)
	{
		//Discarded unreachable code: IL_0137, IL_0146, IL_0159, IL_0209
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 10:
				return (string)BtJq4uGApa5eJ364GC3o(0x1FFEF86A ^ 0x1FFDA6A6);
			case 11:
				return (string)BtJq4uGApa5eJ364GC3o(-398663332 ^ -398923780);
			case 2:
			case 4:
				return (string)BtJq4uGApa5eJ364GC3o(-1765851862 ^ -1766114370);
			case 6:
				if (!(type == typeof(string)))
				{
					if (!(type == smL2k9GADPP32TicHiLn(typeof(bool).TypeHandle)))
					{
						num2 = 7;
						break;
					}
					goto case 3;
				}
				num2 = 10;
				break;
			case 9:
				if (!cBEGC9GAwJdkSZRNtkfl(type, smL2k9GADPP32TicHiLn(typeof(DateTime?).TypeHandle)))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 7:
				if (!cBEGC9GAwJdkSZRNtkfl(type, smL2k9GADPP32TicHiLn(typeof(bool?).TypeHandle)))
				{
					num2 = 8;
					break;
				}
				goto case 3;
			case 1:
				if (cBEGC9GAwJdkSZRNtkfl(type, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!type.IsNumericType())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 5;
			case 5:
				return (string)BtJq4uGApa5eJ364GC3o(-1886646897 ^ -1886909685);
			case 12:
				if (type == smL2k9GADPP32TicHiLn(typeof(DateTime).TypeHandle))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 9;
			default:
				return (string)BtJq4uGApa5eJ364GC3o(-2138160520 ^ -2138124516);
			case 3:
				return (string)BtJq4uGApa5eJ364GC3o(0xA592A41 ^ 0xA5A7449);
			case 8:
				if (!type.IsEnum)
				{
					return (string)BtJq4uGApa5eJ364GC3o(-475857671 ^ -475893347);
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 11;
				}
				break;
			}
		}
	}

	public static bool IsProxy(this Type type)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return oU0wejGA6Uk1xQxoF083(type.GetInterface(smL2k9GADPP32TicHiLn(typeof(IProxy).TypeHandle).FullName), null);
			case 2:
				if (!type.IsInheritOrSame<IEntityProxy>())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				if (oU0wejGA6Uk1xQxoF083(type.GetInterface(typeof(INHibernateProxy).FullName), null))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static MethodInfo GetImlementationMethodInfoFromInterface(this Type type, MethodInfo interfaceMethod)
	{
		int num = 1;
		int num3 = default(int);
		InterfaceMapping interfaceMap = default(InterfaceMapping);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					num3 = Array.IndexOf(interfaceMap.InterfaceMethods, interfaceMethod);
					num2 = 3;
					continue;
				case 1:
					H8EWG7GA7U93mfT0707H(interfaceMethod, BtJq4uGApa5eJ364GC3o(0x3630F361 ^ 0x3634F5CD));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					throw new Exception(SR.T((string)BtJq4uGApa5eJ364GC3o(0x8317432 ^ 0x83572FC), interfaceMethod.Name, type.FullName));
				case 3:
					if (num3 != -1)
					{
						return interfaceMap.TargetMethods[num3];
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			interfaceMap = type.GetInterfaceMap(interfaceMethod.DeclaringType);
			num = 4;
		}
	}

	public static bool IsSimpleType(this Type type)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!(type == smL2k9GADPP32TicHiLn(typeof(string).TypeHandle)))
					{
						goto end_IL_0012;
					}
					goto default;
				case 3:
					return cBEGC9GAwJdkSZRNtkfl(type, smL2k9GADPP32TicHiLn(typeof(Guid).TypeHandle));
				default:
					return true;
				case 1:
					if (type.IsPrimitive)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static bool IsEnumerable(this Type type)
	{
		return smL2k9GADPP32TicHiLn(typeof(IEnumerable).TypeHandle).IsAssignableFrom(type);
	}

	public static bool IsEnumerableOfSimpleType(this Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (roWpWyGALPEWM4GI6mwT(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return type.GetGenericArguments().All(IsSimpleType);
			}
		}
	}

	public static bool IsIdentifiedType(this Type type)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_ = default(_003C_003Ec__DisplayClass43_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return type.GetTypeInfo().ImplementedInterfaces.Any(_003C_003Ec__DisplayClass43_._003CIsIdentifiedType_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass43_.identifiedType = smL2k9GADPP32TicHiLn(typeof(IIdentified).TypeHandle);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass43_ = new _003C_003Ec__DisplayClass43_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool ImplementsGenericInterface(this Type type, Type interfaceType)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_00bf, IL_00ce
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 6:
				return ((TypeInfo)Daj1llGAUomDUhHFHagW(type)).ImplementedInterfaces.Any(_003C_003Ec__DisplayClass44_._003CImplementsGenericInterface_003Eb__0);
			case 3:
				return true;
			case 4:
				if (cBEGC9GAwJdkSZRNtkfl(type.GetGenericTypeDefinition(), _003C_003Ec__DisplayClass44_.interfaceType))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			default:
				_003C_003Ec__DisplayClass44_.interfaceType = interfaceType;
				num2 = 5;
				break;
			case 5:
				if (!type.IsGenericType)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static IEnumerable<Type> GetBaseClasses(this Type type)
	{
		Contract.ArgumentNotNull(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C12C6));
		if (type.IsInterface)
		{
			return Enumerable.Empty<Type>();
		}
		List<Type> list = new List<Type>();
		Type baseType = type.BaseType;
		while (baseType != null)
		{
			list.Add(baseType);
			baseType = baseType.BaseType;
		}
		return list;
	}

	public static bool IsAsync(this Type type)
	{
		//Discarded unreachable code: IL_00a5, IL_00bf, IL_00df, IL_00ee
		int num = 1;
		Type genericTypeDefinition = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (cBEGC9GAwJdkSZRNtkfl(genericTypeDefinition, otKWuHGAsaIaAEgRfdTS(TypeOf.Task1)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				case 8:
					if (cBEGC9GAwJdkSZRNtkfl(genericTypeDefinition, otKWuHGAsaIaAEgRfdTS(TypeOf.ValueTask1)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_00fb;
				default:
					if (!cBEGC9GAwJdkSZRNtkfl(type, TypeOf<System.Threading.Tasks.ValueTask>.Raw))
					{
						num2 = 6;
						continue;
					}
					goto case 5;
				case 3:
					break;
				case 2:
				case 4:
					return true;
				case 5:
					return true;
				case 6:
					if (type.IsGenericType)
					{
						num2 = 3;
						continue;
					}
					goto IL_00fb;
				case 1:
					{
						if (!cBEGC9GAwJdkSZRNtkfl(type, TypeOf<Task>.Raw))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 5;
					}
					IL_00fb:
					return false;
				}
				break;
			}
			genericTypeDefinition = type.GetGenericTypeDefinition();
			num = 7;
		}
	}

	public static bool IsFunc(this Type type)
	{
		//Discarded unreachable code: IL_005b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!FunctionTypes.Contains(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			case 3:
				return FunctionTypes.Contains(type.GetGenericTypeDefinition());
			case 2:
				return false;
			default:
				if (!type.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private static ITypePropertyExtensionPoint GetTypePropertyExtension(Type type)
	{
		int num = 2;
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = default(_003C_003Ec__DisplayClass50_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (typePropertyExtensions == null)
					{
						num2 = 3;
						continue;
					}
					goto default;
				default:
					return typePropertyExtensions.FirstOrDefault(_003C_003Ec__DisplayClass50_._003CGetTypePropertyExtension_003Eb__0);
				case 1:
					break;
				case 3:
					typePropertyExtensions = ((ComponentManager)mAldGGGAc9kD2msfeNvC()).GetExtensionPoints<ITypePropertyExtensionPoint>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass50_.type = type;
			num = 4;
		}
	}

	static TypeExtensions()
	{
		int num = 12;
		int num2 = num;
		ParameterExpression parameterExpression3 = default(ParameterExpression);
		ParameterExpression parameterExpression2 = default(ParameterExpression);
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 7:
				getPropertiesCached = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, PropertyInfo[]>>((Expression)kIpllBG7Wdfk4GFaaDxY(null, (MethodInfo)DismAWG7BphmQflNXHmR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[1] { parameterExpression3 }), new ParameterExpression[1] { parameterExpression3 }));
				num2 = 9;
				break;
			case 11:
				PredefinedTypes = new Type[20]
				{
					smL2k9GADPP32TicHiLn(typeof(object).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(bool).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(char).TypeHandle),
					typeof(string),
					smL2k9GADPP32TicHiLn(typeof(sbyte).TypeHandle),
					typeof(byte),
					smL2k9GADPP32TicHiLn(typeof(short).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(ushort).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(int).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(uint).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(long).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(ulong).TypeHandle),
					smL2k9GADPP32TicHiLn(typeof(float).TypeHandle),
					typeof(double),
					typeof(decimal),
					smL2k9GADPP32TicHiLn(typeof(DateTime).TypeHandle),
					typeof(TimeSpan),
					smL2k9GADPP32TicHiLn(typeof(Guid).TypeHandle),
					typeof(Math),
					smL2k9GADPP32TicHiLn(typeof(Convert).TypeHandle)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				parameterExpression2 = Expression.Parameter(typeof(string), (string)BtJq4uGApa5eJ364GC3o(-1852837372 ^ -1852834286));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				parameterExpression = (ParameterExpression)LCrabIG7FYXPCGM7k0dI(smL2k9GADPP32TicHiLn(typeof(string).TypeHandle), BtJq4uGApa5eJ364GC3o(0x3A6135BE ^ 0x3A6139A8));
				num2 = 10;
				break;
			case 1:
				return;
			default:
				parameterExpression2 = (ParameterExpression)LCrabIG7FYXPCGM7k0dI(smL2k9GADPP32TicHiLn(typeof(Type).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EC191D));
				num2 = 6;
				break;
			case 2:
				parameterExpression3 = Expression.Parameter(typeof(BindingFlags), (string)BtJq4uGApa5eJ364GC3o(-1939377524 ^ -1939638864));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				parameterExpression = (ParameterExpression)LCrabIG7FYXPCGM7k0dI(smL2k9GADPP32TicHiLn(typeof(Type).TypeHandle), BtJq4uGApa5eJ364GC3o(-542721635 ^ -542722625));
				num2 = 5;
				break;
			case 4:
				parameterExpression3 = (ParameterExpression)LCrabIG7FYXPCGM7k0dI(typeof(Type), BtJq4uGApa5eJ364GC3o(-1146510045 ^ -1146509055));
				num2 = 7;
				break;
			case 12:
				aONjN0GAzx9Pc8SNt0uD();
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 8;
				}
				break;
			case 9:
				FunctionTypes = new HashSet<Type>
				{
					TypeOf.Func1.Raw,
					TypeOf.Func2.Raw,
					TypeOf.Func3.Raw
				};
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				getPropertyCached = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, string, PropertyInfo>>(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2] { parameterExpression2, parameterExpression }), new ParameterExpression[2] { parameterExpression2, parameterExpression }));
				num2 = 8;
				break;
			case 3:
				getPropertyWithBindingFlagsCached = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, string, BindingFlags, PropertyInfo>>((Expression)kIpllBG7Wdfk4GFaaDxY(null, (MethodInfo)DismAWG7BphmQflNXHmR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[3] { parameterExpression, parameterExpression2, parameterExpression3 }), new ParameterExpression[3] { parameterExpression, parameterExpression2, parameterExpression3 }));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	internal static bool jagY6ZGAPBcJY9yXci1a()
	{
		return yhgJtiGAevwljcsZdAGJ == null;
	}

	internal static TypeExtensions nwL5P2GA15sSGSGMQclL()
	{
		return yhgJtiGAevwljcsZdAGJ;
	}

	internal static object XiV8YTGANEw6bTpQMIH7(Type type)
	{
		return type.GetReflectionProperties();
	}

	internal static bool Kq06pdGA3kCenFfv31dF(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object BtJq4uGApa5eJ364GC3o(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object pnWPeyGAajbwsJT2dQUr(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Type smL2k9GADPP32TicHiLn(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool J11aKKGAtRM7sIM2Drsm(Type type)
	{
		return type.IsNullableType();
	}

	internal static bool cBEGC9GAwJdkSZRNtkfl(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type ordBKSGA4jmr2Fy38y2i(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool oU0wejGA6Uk1xQxoF083(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static int DfpENyGAH2LKm1q91vZ1(Type type)
	{
		return type.GetNumericTypeKind();
	}

	internal static TypeCode nE2wDjGAAxob0mmmeboZ(Type P_0)
	{
		return Type.GetTypeCode(P_0);
	}

	internal static void H8EWG7GA7U93mfT0707H(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type gCEJdMGAxXpuL6tCFvL9(Type type, Type genericType)
	{
		return type.FindGenericType(genericType);
	}

	internal static object VhosKoGA0yq75QqaG88B(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object BkXAMuGAmca9Lvf3mBZs(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object tAbrcAGAydmxyfmLE2N4(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object GL6oCeGAMDKnFoLKFiFo(object P_0, Type type, Type idType, bool forIdentifier)
	{
		return ((ITypePropertyExtensionPoint)P_0).DefaultValue(type, idType, forIdentifier);
	}

	internal static object O89GUqGAJAIQg9w0buIG(Type type)
	{
		return GetTypePropertyExtension(type);
	}

	internal static bool ICUCE6GA93ucJUpZu8h5(object P_0, Type type, Type idType, object P_3)
	{
		return ((ITypePropertyExtensionPoint)P_0).IsDefaultId(type, idType, P_3);
	}

	internal static bool AaFS5eGAdOcd9buB7j3B(Type type, Type idType, object P_2)
	{
		return type.IsDefaultId(idType, P_2);
	}

	internal static long KekYNwGAlrx8dfYqfExn(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object kP8jBHGAr4Te5pcUWRVm(Type type, Type idType)
	{
		return type.DefaultIdentifierValue(idType);
	}

	internal static object cWK2E1GAgYilLCCd7cFw(object P_0, Type type, Type idType, object P_3)
	{
		return ((ITypePropertyExtensionPoint)P_0).ConvertId(type, idType, P_3);
	}

	internal static object DC7BFMGA5dLCqkDMR6nD(Type type, object P_1, bool staticAccess)
	{
		return type.FindPropertyOrField((string)P_1, staticAccess);
	}

	internal static void cGJrr8GAj7WYi6vBIAwA(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool OMi2tLGAYKqyZE9qZq1O(Type source, Type target)
	{
		return source.IsCompatibleWith(target);
	}

	internal static bool roWpWyGALPEWM4GI6mwT(Type type)
	{
		return type.IsEnumerable();
	}

	internal static object Daj1llGAUomDUhHFHagW(Type P_0)
	{
		return P_0.GetTypeInfo();
	}

	internal static Type otKWuHGAsaIaAEgRfdTS(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static object mAldGGGAc9kD2msfeNvC()
	{
		return ComponentManager.Current;
	}

	internal static void aONjN0GAzx9Pc8SNt0uD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object LCrabIG7FYXPCGM7k0dI(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object DismAWG7BphmQflNXHmR(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object kIpllBG7Wdfk4GFaaDxY(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}
}
