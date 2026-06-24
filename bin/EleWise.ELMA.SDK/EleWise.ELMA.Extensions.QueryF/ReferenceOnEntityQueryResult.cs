using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class ReferenceOnEntityQueryResult : IQueryFunctionResult, IEQLFunction
{
	internal static ReferenceOnEntityQueryResult s2jIZVGMej3rvvvXeG2S;

	public string FunctionName => (string)eVsXJAGMNMinu3dQqncX(-541731959 ^ -541829391);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6, IL_01ac
		int num = 8;
		PropertyInfo propertyInfo = default(PropertyInfo);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		Guid result = default(Guid);
		IEnumerable<EntityMetadata> source = default(IEnumerable<EntityMetadata>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				EntityMetadata entityMetadata;
				switch (num2)
				{
				case 16:
					if (parameters[1] is long)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 4;
				case 7:
					if (parameters[0] is string)
					{
						num = 16;
						break;
					}
					goto case 4;
				case 15:
					propertyInfo = (PropertyInfo)LYbGLQGMpFmf4TvLiUDt(serviceNotNull.GetTypeByUid(eJc9m1GM3RfX0ILTYTeM(metadata)), propName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (parameters.Length == 2)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 4;
				case 2:
					if (entityMetadata2 != null)
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 3:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 9;
					}
					continue;
				case 13:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 15;
					continue;
				case 1:
					if (!XLOr2iGMaHdTxiIH1BeG(propertyInfo, null))
					{
						num = 4;
						break;
					}
					goto case 11;
				case 11:
					if (typeof(ReferenceOnEntity).IsAssignableFrom(uimf9rGMDQ3ymqMedNqq(propertyInfo)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 9:
					if (!Guid.TryParse((string)parameters[0], out result))
					{
						num2 = 10;
						continue;
					}
					goto case 12;
				case 6:
					return aQ9udYGMw6DgVsxJkpYE(eJc9m1GM3RfX0ILTYTeM(entityMetadata2), Ru1OfwGMtJhrtKJV6Ill(parameters[1]));
				case 4:
					throw new ArgumentException();
				case 14:
					_003C_003Ec__DisplayClass2_.name = (string)parameters[0];
					num2 = 5;
					continue;
				case 12:
					return ReferenceOnEntity.Create(result, Ru1OfwGMtJhrtKJV6Ill(parameters[1]));
				case 10:
					source = from m in serviceNotNull.GetMetadataList().OfType<EntityMetadata>()
						where !_003C_003Ec.X8kJ0r8CLxfXXjjKohSQ(m)
						select m;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 14;
					}
					continue;
				case 5:
					entityMetadata = source.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetValue_003Eb__1);
					if (entityMetadata != null)
					{
						goto IL_02b5;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					{
						entityMetadata = source.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetValue_003Eb__2);
						goto IL_02b5;
					}
					IL_02b5:
					entityMetadata2 = entityMetadata;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837927513), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420479770)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1AEEE6))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217621333)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548FA0A6), FunctionName),
				Types = new Guid[1] { ReferenceOnEntityDecription.UID }
			}
		};
	}

	public ReferenceOnEntityQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object eVsXJAGMNMinu3dQqncX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool TgUUN0GMPfidLjCLxTj5()
	{
		return s2jIZVGMej3rvvvXeG2S == null;
	}

	internal static ReferenceOnEntityQueryResult I321LJGM1HCpFdlE8ZfH()
	{
		return s2jIZVGMej3rvvvXeG2S;
	}

	internal static Guid eJc9m1GM3RfX0ILTYTeM(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object LYbGLQGMpFmf4TvLiUDt(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool XLOr2iGMaHdTxiIH1BeG(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Type uimf9rGMDQ3ymqMedNqq(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static long Ru1OfwGMtJhrtKJV6Ill(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object aQ9udYGMw6DgVsxJkpYE(Guid typeUid, long id)
	{
		return ReferenceOnEntity.Create(typeUid, id);
	}
}
