using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings;

public class AssemblyModelsMetadataMap : ClassMapping<AssemblyModelsMetadata>
{
	internal static AssemblyModelsMetadataMap yArMTNhhVvoJoMeGJDoY;

	public AssemblyModelsMetadataMap()
	{
		//Discarded unreachable code: IL_001a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			ParameterExpression parameterExpression;
			switch (num)
			{
			case 3:
				NN2bNQhhq5lTZaXJhdOm(this, eVcOevhhRs5mmyUabyjj(0x1DE3DD89 ^ 0x1DE26D53));
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 8;
				}
				continue;
			case 4:
				return;
			case 8:
				parameterExpression = (ParameterExpression)HS0DoohhX7XNEKEXjAgN(K1KKtrhhKdcRlH9ltqc7(typeof(AssemblyModelsMetadata).TypeHandle), eVcOevhhRs5mmyUabyjj(0x12441CA4 ^ 0x1244D67C));
				((ClassCustomizer<AssemblyModelsMetadata>)(object)this).Id<long>(Expression.Lambda<Func<AssemblyModelsMetadata, long>>((Expression)uC2jklhhkhtVWNN61rxh(parameterExpression, (MethodInfo)KuuJFmhhTCgXZFDdfbqs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper p)
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
							_003C_003Ec.fVV3NlCgB29Wecfml8Id(p, _003C_003Ec.fjblpyCgFlyHjdFuCmTP(0x4EA5403C ^ 0x4EA4F0E6), _003C_003Ec.fjblpyCgFlyHjdFuCmTP(-1886646897 ^ -1886614319));
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num6 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 6;
				}
				continue;
			case 6:
				parameterExpression = Expression.Parameter(K1KKtrhhKdcRlH9ltqc7(typeof(AssemblyModelsMetadata).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BB7FE6));
				((PropertyContainerCustomizer<AssemblyModelsMetadata>)(object)this).Property<string>(Expression.Lambda<Func<AssemblyModelsMetadata, string>>((Expression)uC2jklhhkhtVWNN61rxh(parameterExpression, (MethodInfo)KuuJFmhhTCgXZFDdfbqs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num15 = 2;
					int num16 = num15;
					while (true)
					{
						switch (num16)
						{
						default:
							return;
						case 1:
							((IColumnsMapper)p).Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487278026));
							num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num16 = 0;
							}
							break;
						case 0:
							return;
						case 2:
							_003C_003Ec.wvkFLTCgWIBi7UqXsLJh(p, int.MaxValue);
							num16 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
							{
								num16 = 1;
							}
							break;
						}
					}
				});
				num = 5;
				continue;
			case 5:
			{
				parameterExpression = (ParameterExpression)HS0DoohhX7XNEKEXjAgN(K1KKtrhhKdcRlH9ltqc7(typeof(AssemblyModelsMetadata).TypeHandle), eVcOevhhRs5mmyUabyjj(0xA592A41 ^ 0xA59E099));
				((PropertyContainerCustomizer<AssemblyModelsMetadata>)(object)this).Property<AssemblyModelsMetadataStatus>(Expression.Lambda<Func<AssemblyModelsMetadata, AssemblyModelsMetadataStatus>>(Expression.Property(parameterExpression, (MethodInfo)KuuJFmhhTCgXZFDdfbqs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num11 = 1;
					int num12 = num11;
					while (true)
					{
						switch (num12)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							((IColumnsMapper)p).Column((Action<IColumnMapper>)delegate(IColumnMapper c)
							{
								int num13 = 1;
								int num14 = num13;
								while (true)
								{
									switch (num14)
									{
									default:
										return;
									case 1:
										c.SqlType((string)_003C_003Ec.fjblpyCgFlyHjdFuCmTP(-2138160520 ^ -2138256050));
										num14 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
										{
											num14 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num12 = 0;
							}
							break;
						}
					}
				});
				int num2 = 7;
				num = num2;
				continue;
			}
			case 7:
				parameterExpression = (ParameterExpression)HS0DoohhX7XNEKEXjAgN(K1KKtrhhKdcRlH9ltqc7(typeof(AssemblyModelsMetadata).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A3334EE));
				((PropertyContainerCustomizer<AssemblyModelsMetadata>)(object)this).Property<MemoryStream>(Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>((Expression)uC2jklhhkhtVWNN61rxh(parameterExpression, (MethodInfo)KuuJFmhhTCgXZFDdfbqs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num7 = 3;
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
							p.Type(NHProviderDependentUserTypes.Get<StreamNHType>(), (object)null);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num8 = 0;
							}
							break;
						case 3:
							p.Length(int.MaxValue);
							num8 = 2;
							break;
						case 2:
							_003C_003Ec.KUMAXjCgoXU1IH2I5bId(p, _003C_003Ec.fjblpyCgFlyHjdFuCmTP(-281842504 ^ -281814406));
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
							{
								num8 = 1;
							}
							break;
						}
					}
				});
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 0;
				}
				continue;
			case 2:
				parameterExpression = Expression.Parameter(typeof(AssemblyModelsMetadata), (string)eVcOevhhRs5mmyUabyjj(-1751176224 ^ -1751129800));
				((PropertyContainerCustomizer<AssemblyModelsMetadata>)(object)this).Property<MemoryStream>(Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>((Expression)uC2jklhhkhtVWNN61rxh(parameterExpression, (MethodInfo)KuuJFmhhTCgXZFDdfbqs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num9 = 2;
					int num10 = num9;
					while (true)
					{
						switch (num10)
						{
						case 3:
							return;
						case 1:
							_003C_003Ec.KUMAXjCgoXU1IH2I5bId(p, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A7C705));
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num10 = 0;
							}
							break;
						case 2:
							_003C_003Ec.wvkFLTCgWIBi7UqXsLJh(p, int.MaxValue);
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
							{
								num10 = 1;
							}
							break;
						default:
							_003C_003Ec.AdVPuLCgbxrZy7cYf9xy(p, NHProviderDependentUserTypes.Get<StreamNHType>(), null);
							num10 = 3;
							break;
						}
					}
				});
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 1;
				}
				continue;
			case 1:
				parameterExpression = (ParameterExpression)HS0DoohhX7XNEKEXjAgN(K1KKtrhhKdcRlH9ltqc7(typeof(AssemblyModelsMetadata).TypeHandle), eVcOevhhRs5mmyUabyjj(0x31326106 ^ 0x3132ABDE));
				((PropertyContainerCustomizer<AssemblyModelsMetadata>)(object)this).Property<MemoryStream>(Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>((Expression)uC2jklhhkhtVWNN61rxh(parameterExpression, (MethodInfo)KuuJFmhhTCgXZFDdfbqs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num17 = 1;
					int num18 = num17;
					while (true)
					{
						switch (num18)
						{
						default:
							_003C_003Ec.KUMAXjCgoXU1IH2I5bId(p, _003C_003Ec.fjblpyCgFlyHjdFuCmTP(-105199646 ^ -105154868));
							num18 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num18 = 1;
							}
							break;
						case 3:
							return;
						case 2:
							p.Type(NHProviderDependentUserTypes.Get<StreamNHType>(), (object)null);
							num18 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num18 = 3;
							}
							break;
						case 1:
							_003C_003Ec.wvkFLTCgWIBi7UqXsLJh(p, int.MaxValue);
							num18 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num18 = 0;
							}
							break;
						}
					}
				});
				num = 4;
				continue;
			}
			parameterExpression = (ParameterExpression)HS0DoohhX7XNEKEXjAgN(K1KKtrhhKdcRlH9ltqc7(typeof(AssemblyModelsMetadata).TypeHandle), eVcOevhhRs5mmyUabyjj(-787452571 ^ -787437635));
			((PropertyContainerCustomizer<AssemblyModelsMetadata>)(object)this).Property<MemoryStream>(Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>(Expression.Property(parameterExpression, (MethodInfo)KuuJFmhhTCgXZFDdfbqs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
			{
				int num3 = 3;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 2:
						_003C_003Ec.KUMAXjCgoXU1IH2I5bId(p, _003C_003Ec.fjblpyCgFlyHjdFuCmTP(-1886646897 ^ -1886536561));
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num4 = 1;
						}
						break;
					case 0:
						return;
					case 3:
						_003C_003Ec.wvkFLTCgWIBi7UqXsLJh(p, int.MaxValue);
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num4 = 0;
						}
						break;
					case 1:
						p.Type(NHProviderDependentUserTypes.Get<StreamNHType>(), (object)null);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			num = 2;
		}
	}

	internal static object eVcOevhhRs5mmyUabyjj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void NN2bNQhhq5lTZaXJhdOm(object P_0, object P_1)
	{
		((ClassCustomizer<AssemblyModelsMetadata>)P_0).Table((string)P_1);
	}

	internal static Type K1KKtrhhKdcRlH9ltqc7(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object HS0DoohhX7XNEKEXjAgN(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object KuuJFmhhTCgXZFDdfbqs(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object uC2jklhhkhtVWNN61rxh(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool iiYcIFhhSWSkdvKse3Zh()
	{
		return yArMTNhhVvoJoMeGJDoY == null;
	}

	internal static AssemblyModelsMetadataMap cSlpwEhhi54gvGChMYjZ()
	{
		return yArMTNhhVvoJoMeGJDoY;
	}
}
