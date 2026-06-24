using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings;

public class TablePartMetadataMap : JoinedSubclassMapping<TablePartMetadata>
{
	internal static TablePartMetadataMap TfWoFohbXHFrTePccPQK;

	public TablePartMetadataMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ke3ikEhbnp6P0OeKkGBl();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(eByR8uhb2JqGpXQ11Xl6(typeof(TablePartMetadata).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDC70EA));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).Property<bool>(Expression.Lambda<Func<TablePartMetadata, bool>>((Expression)r3KiEHhbNpXtWj7vZvRO(parameterExpression, (MethodInfo)CV3lh2hb14gjc7s2i3QC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num = 0;
				}
				break;
			}
			case 11:
				vKSIDGhbOfTsmwQXriHD(this, false);
				num = 4;
				break;
			case 2:
				return;
			default:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(typeof(TablePartMetadata), X76q0Mhbe8DIYQC03KCe(0x12441CA4 ^ 0x1244D67C));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).Property<bool>(Expression.Lambda<Func<TablePartMetadata, bool>>((Expression)r3KiEHhbNpXtWj7vZvRO(parameterExpression, (MethodInfo)CV3lh2hb14gjc7s2i3QC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 8;
				break;
			}
			case 4:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(eByR8uhb2JqGpXQ11Xl6(typeof(TablePartMetadata).TypeHandle), X76q0Mhbe8DIYQC03KCe(0x1637C429 ^ 0x16370EF1));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).ManyToOne<EntityMetadata>(Expression.Lambda<Func<TablePartMetadata, EntityMetadata>>((Expression)r3KiEHhbNpXtWj7vZvRO(parameterExpression, (MethodInfo)CV3lh2hb14gjc7s2i3QC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num = 1;
				}
				break;
			}
			case 1:
				((JoinedSubclassCustomizer<TablePartMetadata>)(object)this).Table(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289701518));
				num = 7;
				break;
			case 10:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(eByR8uhb2JqGpXQ11Xl6(typeof(TablePartMetadata).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309621404));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).Property<int>(Expression.Lambda<Func<TablePartMetadata, int>>(Expression.Property(parameterExpression, (MethodInfo)CV3lh2hb14gjc7s2i3QC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 2;
				}
				break;
			}
			case 5:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(typeof(TablePartMetadata), X76q0Mhbe8DIYQC03KCe(-541731959 ^ -541779631));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).Property<Guid>(Expression.Lambda<Func<TablePartMetadata, Guid>>((Expression)r3KiEHhbNpXtWj7vZvRO(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 9;
				}
				break;
			}
			case 6:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(eByR8uhb2JqGpXQ11Xl6(typeof(TablePartMetadata).TypeHandle), X76q0Mhbe8DIYQC03KCe(0x1DE3DD89 ^ 0x1DE31751));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).Property<bool>(Expression.Lambda<Func<TablePartMetadata, bool>>(Expression.Property(parameterExpression, (MethodInfo)CV3lh2hb14gjc7s2i3QC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 3;
				break;
			}
			case 7:
				((JoinedSubclassCustomizer<TablePartMetadata>)(object)this).Key((Action<IKeyMapper<TablePartMetadata>>)delegate(IKeyMapper<TablePartMetadata> k)
				{
					((IColumnsMapper)k).Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA59AB1F));
				});
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 9;
				}
				break;
			case 9:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(eByR8uhb2JqGpXQ11Xl6(typeof(TablePartMetadata).TypeHandle), X76q0Mhbe8DIYQC03KCe(-1088304168 ^ -1088356096));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).Property<string>(Expression.Lambda<Func<TablePartMetadata, string>>(Expression.Property(parameterExpression, (MethodInfo)CV3lh2hb14gjc7s2i3QC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.qw9gqVClxMAJ2MFh13r0(p, int.MaxValue);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				});
				num = 10;
				break;
			}
			case 8:
			{
				ParameterExpression parameterExpression = (ParameterExpression)owZMENhbPjFMSd21MZHp(typeof(TablePartMetadata), X76q0Mhbe8DIYQC03KCe(-2138160520 ^ -2138142560));
				((PropertyContainerCustomizer<TablePartMetadata>)(object)this).Property<string>(Expression.Lambda<Func<TablePartMetadata, string>>((Expression)r3KiEHhbNpXtWj7vZvRO(parameterExpression, (MethodInfo)CV3lh2hb14gjc7s2i3QC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num4 = 1;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.qw9gqVClxMAJ2MFh13r0(p, int.MaxValue);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num5 = 0;
							}
							break;
						}
					}
				});
				num = 2;
				break;
			}
			}
		}
	}

	internal static void Ke3ikEhbnp6P0OeKkGBl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void vKSIDGhbOfTsmwQXriHD(object P_0, bool P_1)
	{
		((JoinedSubclassCustomizer<TablePartMetadata>)P_0).Lazy(P_1);
	}

	internal static Type eByR8uhb2JqGpXQ11Xl6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object X76q0Mhbe8DIYQC03KCe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object owZMENhbPjFMSd21MZHp(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object CV3lh2hb14gjc7s2i3QC(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object r3KiEHhbNpXtWj7vZvRO(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool KVLIsUhbTmLfX7bZnVAn()
	{
		return TfWoFohbXHFrTePccPQK == null;
	}

	internal static TablePartMetadataMap eeY3X1hbk3lwRF1SaxIx()
	{
		return TfWoFohbXHFrTePccPQK;
	}
}
