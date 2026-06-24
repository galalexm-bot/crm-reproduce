using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.API.Models;

public class PropertyFormItemData
{
	private static class Names
	{
		public static readonly object Name;

		public static readonly object DisplayName;

		public static readonly object Description;

		public static readonly object TypeUid;

		public static readonly object SubTypeUid;

		public static readonly object Settings;

		public static readonly object Required;

		public static readonly object ReadOnly;

		public static readonly object Visible;

		public static readonly object CustomView;

		public static readonly object HideEmpty;

		public static readonly object FilterProviderUid;

		public static readonly object FilterProviderData;

		public static readonly object Items;

		internal static object eowwtaZBjULBG7ryXQh6;

		static Names()
		{
			int num = 8;
			ParameterExpression parameterExpression = default(ParameterExpression);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 19:
						parameterExpression = Expression.Parameter(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), (string)cqJ2P5ZBsnAst2Pxul1C(0x42643203 ^ 0x4264C793));
						num2 = 10;
						continue;
					case 12:
						Required = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>(Expression.Convert((Expression)RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 21;
						continue;
					case 17:
						FilterProviderUid = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>(Expression.Convert((Expression)RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), upMAZlZWFuHm1A8ZDAKr(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
						Wrr2XeZBUDndRRS6ZrcV();
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 1;
						}
						continue;
					case 11:
						Items = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression)RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 4;
						continue;
					case 26:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE32819));
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 28;
						}
						continue;
					case 2:
						Name = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>(Expression.Property(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 14;
						continue;
					case 6:
						parameterExpression = Expression.Parameter(typeof(PropertyFormItemData), (string)cqJ2P5ZBsnAst2Pxul1C(-675505729 ^ -675517393));
						num2 = 17;
						continue;
					case 20:
						Settings = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression)RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 27;
						}
						continue;
					case 13:
						SubTypeUid = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>(Expression.Convert((Expression)RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), upMAZlZWFuHm1A8ZDAKr(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 5;
						continue;
					case 28:
						FilterProviderData = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>(Expression.Property(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 0;
						}
						continue;
					case 18:
						Visible = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression)dnLcZIZWWN8V7YxQdoMK(RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), upMAZlZWFuHm1A8ZDAKr(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 22;
						continue;
					case 3:
						ReadOnly = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression)dnLcZIZWWN8V7YxQdoMK(Expression.Property(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), upMAZlZWFuHm1A8ZDAKr(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num = 23;
						break;
					default:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), cqJ2P5ZBsnAst2Pxul1C(-1633514411 ^ -1633519163));
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 4;
						}
						continue;
					case 4:
						return;
					case 5:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138130456));
						num = 20;
						break;
					case 27:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), cqJ2P5ZBsnAst2Pxul1C(0x5DD55050 ^ 0x5DD5A5C0));
						num2 = 12;
						continue;
					case 7:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(typeof(PropertyFormItemData), cqJ2P5ZBsnAst2Pxul1C(0x8317432 ^ 0x83181A2));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 2;
						}
						continue;
					case 9:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), cqJ2P5ZBsnAst2Pxul1C(-957824448 ^ -957859888));
						num2 = 24;
						continue;
					case 15:
						HideEmpty = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression)dnLcZIZWWN8V7YxQdoMK(RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), upMAZlZWFuHm1A8ZDAKr(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 6;
						}
						continue;
					case 25:
						CustomView = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), upMAZlZWFuHm1A8ZDAKr(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num = 16;
						break;
					case 21:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), cqJ2P5ZBsnAst2Pxul1C(-1459557599 ^ -1459609935));
						num2 = 3;
						continue;
					case 29:
						DisplayName = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression)RsDXxyZWBgZACmrxVC7k(parameterExpression, (MethodInfo)Pk8mnKZBzZtxlvEjS1w1((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num = 9;
						break;
					case 23:
						parameterExpression = Expression.Parameter(typeof(PropertyFormItemData), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12DC5F));
						num2 = 18;
						continue;
					case 22:
						parameterExpression = Expression.Parameter(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), (string)cqJ2P5ZBsnAst2Pxul1C(-978351861 ^ -978355045));
						num2 = 25;
						continue;
					case 10:
						TypeUid = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression)dnLcZIZWWN8V7YxQdoMK(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 1;
						}
						continue;
					case 14:
						parameterExpression = (ParameterExpression)peqy9XZBc1qmQSMTBJnr(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521213488));
						num2 = 29;
						continue;
					case 24:
						Description = LinqUtils.NameOf(Expression.Lambda<Func<PropertyFormItemData, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 19;
						}
						continue;
					case 16:
						parameterExpression = Expression.Parameter(upMAZlZWFuHm1A8ZDAKr(typeof(PropertyFormItemData).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951452554));
						num2 = 15;
						continue;
					case 1:
						parameterExpression = Expression.Parameter(typeof(PropertyFormItemData), (string)cqJ2P5ZBsnAst2Pxul1C(-1921202237 ^ -1921240493));
						num2 = 13;
						continue;
					}
					break;
				}
			}
		}

		internal static void Wrr2XeZBUDndRRS6ZrcV()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object cqJ2P5ZBsnAst2Pxul1C(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object peqy9XZBc1qmQSMTBJnr(Type P_0, object P_1)
		{
			return Expression.Parameter(P_0, (string)P_1);
		}

		internal static object Pk8mnKZBzZtxlvEjS1w1(RuntimeMethodHandle P_0)
		{
			return MethodBase.GetMethodFromHandle(P_0);
		}

		internal static Type upMAZlZWFuHm1A8ZDAKr(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object RsDXxyZWBgZACmrxVC7k(object P_0, object P_1)
		{
			return Expression.Property((Expression)P_0, (MethodInfo)P_1);
		}

		internal static object dnLcZIZWWN8V7YxQdoMK(object P_0, Type P_1)
		{
			return Expression.Convert((Expression)P_0, P_1);
		}

		internal static bool fkkn87ZBY5BClSMf8UyP()
		{
			return eowwtaZBjULBG7ryXQh6 == null;
		}

		internal static Names uYuKtjZBL2ZFNU7fye82()
		{
			return (Names)eowwtaZBjULBG7ryXQh6;
		}
	}

	private static PropertyFormItemData wYFVhJfNcmeilXtQpiCG;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid SubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TypeSettings Settings
	{
		[CompilerGenerated]
		get
		{
			return _003CSettings_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Required
	{
		[CompilerGenerated]
		get
		{
			return _003CRequired_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CRequired_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool ReadOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CReadOnly_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CReadOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool Visible
	{
		[CompilerGenerated]
		get
		{
			return _003CVisible_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CVisible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool CustomView
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomView_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CCustomView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool HideEmpty
	{
		[CompilerGenerated]
		get
		{
			return _003CHideEmpty_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CHideEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid FilterProviderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CFilterProviderUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CFilterProviderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string FilterProviderData
	{
		[CompilerGenerated]
		get
		{
			return _003CFilterProviderData_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CFilterProviderData_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<PropertyFormItemData> Items { get; set; }

	public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
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
				builder.ItemWithDescriptor((string)Names.Name, delegate(TypeSerializationDescriptorBuilder i)
				{
					int num29 = 1;
					int num30 = num29;
					while (true)
					{
						switch (num30)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.jNy8JBZWv9JHQk4u6G3s(_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, _003C_003Ec.yGC5ScZWf9nfaixW7hQ3(_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(--1867379187 ^ 0x6F4F614F))), _003C_003Ec.rKw23WZWCuhIKJFN00cB(typeof(string).TypeHandle));
							num30 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num30 = 0;
							}
							break;
						}
					}
				}).ItemWithDescriptor((string)Names.DisplayName, delegate(TypeSerializationDescriptorBuilder i)
				{
					int num27 = 1;
					int num28 = num27;
					while (true)
					{
						switch (num28)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.jNy8JBZWv9JHQk4u6G3s(_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, _003C_003Ec.yGC5ScZWf9nfaixW7hQ3(_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(0x3CE17B75 ^ 0x3CE158E1))), _003C_003Ec.rKw23WZWCuhIKJFN00cB(typeof(string).TypeHandle));
							num28 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num28 = 0;
							}
							break;
						}
					}
				}).ItemWithDescriptor((string)Names.Description, delegate(TypeSerializationDescriptorBuilder i)
				{
					int num25 = 1;
					int num26 = num25;
					while (true)
					{
						switch (num26)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							((TypeSerializationDescriptorBuilder)_003C_003Ec.jNy8JBZWv9JHQk4u6G3s(i.Description((string)_003C_003Ec.yGC5ScZWf9nfaixW7hQ3(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ADEF80))), _003C_003Ec.rKw23WZWCuhIKJFN00cB(typeof(string).TypeHandle))).Optional((object)null);
							num26 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num26 = 0;
							}
							break;
						}
					}
				})
					.ItemWithDescriptor((string)Names.TypeUid, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num23 = 1;
						int num24 = num23;
						while (true)
						{
							switch (num24)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, SR.T((string)_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(0x17ADCCD8 ^ 0x17ABDD7A)))).Type(typeof(Guid));
								num24 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num24 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.SubTypeUid, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num21 = 1;
						int num22 = num21;
						while (true)
						{
							switch (num22)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.jNy8JBZWv9JHQk4u6G3s(_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, _003C_003Ec.yGC5ScZWf9nfaixW7hQ3(_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(0x53FA00CE ^ 0x53FC1120))), _003C_003Ec.rKw23WZWCuhIKJFN00cB(typeof(Guid).TypeHandle))).Optional((object)null);
								num22 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num22 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.Settings, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num19 = 1;
						int num20 = num19;
						while (true)
						{
							switch (num20)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.jNy8JBZWv9JHQk4u6G3s(_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, _003C_003Ec.yGC5ScZWf9nfaixW7hQ3(_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(-561074844 ^ -561463312))), typeof(WebData))).Optional((object)null);
								num20 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num20 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.Required, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num17 = 1;
						int num18 = num17;
						while (true)
						{
							switch (num18)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.jNy8JBZWv9JHQk4u6G3s(i.Description(SR.T((string)_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(-1979251663 ^ -1979640013))), typeof(bool))).Optional((object)null);
								num18 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num18 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.ReadOnly, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num15 = 1;
						int num16 = num15;
						while (true)
						{
							switch (num16)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, SR.T((string)_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(-1852837372 ^ -1853234842)))).Type(_003C_003Ec.rKw23WZWCuhIKJFN00cB(typeof(bool).TypeHandle)).Optional();
								num16 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num16 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.Visible, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num13 = 1;
						int num14 = num13;
						while (true)
						{
							switch (num14)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, SR.T((string)_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(0x1DE3DD89 ^ 0x1DE5CE69)))).Type(typeof(bool)).Optional();
								num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num14 = 0;
								}
								break;
							}
						}
					})
					.ItemWithDescriptor((string)Names.CustomView, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num11 = 1;
						int num12 = num11;
						while (true)
						{
							switch (num12)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.jNy8JBZWv9JHQk4u6G3s(_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, _003C_003Ec.yGC5ScZWf9nfaixW7hQ3(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138830888))), _003C_003Ec.rKw23WZWCuhIKJFN00cB(typeof(bool).TypeHandle))).Optional((object)null);
								num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num12 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.HideEmpty, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num9 = 1;
						int num10 = num9;
						while (true)
						{
							switch (num10)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, SR.T((string)_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(--1867379187 ^ 0x6F4BE543)))).Type(typeof(bool)).Optional();
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num10 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.FilterProviderUid, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, SR.T((string)_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(0x76DD48E ^ 0x76BC1AA)))).Type(typeof(Guid)).Optional();
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num8 = 0;
								}
								break;
							}
						}
					})
					.ItemWithDescriptor((string)Names.FilterProviderData, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							default:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x26984A5C)))).Type(_003C_003Ec.rKw23WZWCuhIKJFN00cB(typeof(string).TypeHandle)).Optional();
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num6 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					})
					.ItemWithDescriptor((string)Names.Items, delegate(TypeSerializationDescriptorBuilder i)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								((TypeSerializationDescriptorBuilder)_003C_003Ec.qokZiwZWQhfaSWOPZbcj(i, SR.T((string)_003C_003Ec.NCt9LZZWEYDvcbgHsdYy(-643786247 ^ -643396587)))).Optional((object)null);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WebData ToWebData()
	{
		//Discarded unreachable code: IL_0118, IL_021d, IL_0361, IL_0370, IL_0380, IL_038f, IL_04ce, IL_04dd, IL_04ed
		int num = 30;
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		SerializableDictionary<string, object> serializableDictionary = default(SerializableDictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 30:
					dictionary = new Dictionary<string, object>();
					num2 = 29;
					continue;
				case 14:
					dictionary[(string)Names.FilterProviderUid] = FilterProviderUid;
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 14;
					}
					continue;
				case 3:
					dictionary[(string)Names.CustomView] = CustomView;
					num2 = 34;
					continue;
				case 31:
					if (XgLyv7f3oRR8vJxSMvS8(serializableDictionary) <= 0)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 18;
				case 16:
					dictionary[(string)Names.TypeUid] = TypeUid;
					num2 = 24;
					continue;
				case 12:
				case 33:
					if (ReadOnly)
					{
						num2 = 36;
						continue;
					}
					goto default;
				case 11:
					dictionary[(string)Names.Required] = Required;
					num2 = 33;
					continue;
				case 9:
					if (Items != null)
					{
						num2 = 25;
						continue;
					}
					goto case 7;
				case 29:
					dictionary[(string)Names.Name] = Name;
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 16;
					}
					continue;
				case 13:
					if (!IX7BtBf3WMiW0nBdr7XG(FilterProviderUid, Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 14;
				case 7:
					return new WebData(dictionary);
				case 15:
					dictionary[(string)Names.FilterProviderData] = FilterProviderData;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 9;
					}
					continue;
				case 2:
					if (!CustomView)
					{
						num2 = 35;
						continue;
					}
					goto case 3;
				case 10:
				case 20:
					if (Settings == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 19;
				case 21:
					dictionary[(string)Names.Visible] = Visible;
					num2 = 2;
					continue;
				case 4:
					if (!qHJW84f3B2ASZ0uIPaSU(Description))
					{
						num2 = 22;
						continue;
					}
					goto case 16;
				default:
					if (!Visible)
					{
						num2 = 21;
						continue;
					}
					goto case 2;
				case 22:
					dictionary[(string)Names.Description] = Description;
					num2 = 16;
					continue;
				case 6:
				case 23:
				case 26:
					if (!Required)
					{
						num2 = 12;
						continue;
					}
					goto case 11;
				case 24:
					if (!IX7BtBf3WMiW0nBdr7XG(SubTypeUid, Guid.Empty))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 5;
				case 1:
				case 32:
					if (IX7BtBf3WMiW0nBdr7XG(FilterProviderUid, Guid.Empty))
					{
						num2 = 15;
						continue;
					}
					goto case 9;
				case 18:
					dictionary[(string)Names.Settings] = serializableDictionary;
					num2 = 6;
					continue;
				case 36:
					dictionary[(string)Names.ReadOnly] = ReadOnly;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					serializableDictionary = new SerializableDictionary<string, object>();
					num2 = 17;
					continue;
				case 34:
				case 35:
					if (HideEmpty)
					{
						num2 = 28;
						continue;
					}
					goto case 13;
				case 27:
					dictionary[(string)Names.DisplayName] = DisplayName;
					num2 = 4;
					continue;
				case 5:
					dictionary[(string)Names.SubTypeUid] = SubTypeUid;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 20;
					}
					continue;
				case 28:
					dictionary[(string)Names.HideEmpty] = HideEmpty;
					num2 = 13;
					continue;
				case 25:
					if (l83Ii7f3bRRcJmsuD2fI(Items) > 0)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 7;
				case 17:
					Settings.SerializeToJsonObject(serializableDictionary);
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 21;
					}
					continue;
				case 8:
					dictionary[(string)Names.Items] = new SerializableList<object>(Items.Select((PropertyFormItemData fi) => (WebData)_003C_003Ec.XDGCrkZW8Iexb8MxTc55(fi)));
					num = 7;
					break;
				}
				break;
			}
		}
	}

	public PropertyFormItemData()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xKNc5Mf3hwx2DyvTSEdN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool bTjvYIfNzkc5pT1KT2eC()
	{
		return wYFVhJfNcmeilXtQpiCG == null;
	}

	internal static PropertyFormItemData sOlPZNf3FuQ9DMkHVf2l()
	{
		return wYFVhJfNcmeilXtQpiCG;
	}

	internal static bool qHJW84f3B2ASZ0uIPaSU(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool IX7BtBf3WMiW0nBdr7XG(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static int XgLyv7f3oRR8vJxSMvS8(object P_0)
	{
		return ((Dictionary<string, object>)P_0).Count;
	}

	internal static int l83Ii7f3bRRcJmsuD2fI(object P_0)
	{
		return ((List<PropertyFormItemData>)P_0).Count;
	}

	internal static void xKNc5Mf3hwx2DyvTSEdN()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
