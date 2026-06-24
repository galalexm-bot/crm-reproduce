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
public class ReferenceOnEntityTypeQueryResult : IQueryFunctionResult, IEQLFunction
{
	private static ReferenceOnEntityTypeQueryResult owwiVAGyAeBSKWono8Ld;

	public string FunctionName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487123178);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_0093, IL_00e5, IL_0108, IL_0117, IL_028f, IL_029e, IL_0304
		int num = 3;
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		ClassMetadata classMetadata2 = default(ClassMetadata);
		Type type = default(Type);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		PropertyInfo propertyInfo = default(PropertyInfo);
		Guid result = default(Guid);
		IEnumerable<ClassMetadata> source = default(IEnumerable<ClassMetadata>);
		while (true)
		{
			int num2 = num;
			ClassMetadata classMetadata;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 4:
					obj2 = serviceNotNull.GetTypeByUid(metadata.Uid);
					goto IL_0370;
				case 6:
					if (classMetadata2 != null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0168;
				case 12:
					classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(GAJ916GydJRw77PSmJUt(classMetadata2));
					num2 = 18;
					continue;
				case 20:
					obj = type.GetReflectionProperty(propName);
					goto IL_038d;
				case 15:
					_003C_003Ec__DisplayClass2_.name = (string)parameters[0];
					num2 = 8;
					continue;
				case 2:
					if (parameters[0] is string)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0168;
				case 5:
				{
					ReferenceOnEntityType referenceOnEntityType2 = new ReferenceOnEntityType();
					ztCOu5Gy93ZX8XSKVQR1(referenceOnEntityType2, GAJ916GydJRw77PSmJUt(classMetadata2));
					return referenceOnEntityType2;
				}
				default:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 11;
					}
					continue;
				case 13:
					if (r0VdrAGyytlCj7QlqUiM(propertyInfo, null))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto IL_0168;
				case 1:
					if (!Guid.TryParse((string)parameters[0], out result))
					{
						num2 = 23;
						continue;
					}
					goto case 9;
				case 17:
					if (uPHCiTGyMS5IpSiBoHE8(typeof(ReferenceOnEntityType).TypeHandle).IsAssignableFrom(plZ0XYGyJKcxbPa7XEO4(propertyInfo)))
					{
						num2 = 24;
						continue;
					}
					goto IL_0168;
				case 19:
				{
					ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
					ztCOu5Gy93ZX8XSKVQR1(referenceOnEntityType, result);
					return referenceOnEntityType;
				}
				case 21:
					return result;
				case 23:
					source = serviceNotNull.GetMetadataList().OfType<ClassMetadata>();
					num2 = 15;
					continue;
				case 11:
					if (xdNYSQGymFXqBxqm54bS(propName, x0xpn1Gy0S8ooB7DEvsL(0x4DC2B14D ^ 0x4DC2F32F)))
					{
						num2 = 7;
						continue;
					}
					goto case 4;
				case 18:
					if (xdNYSQGymFXqBxqm54bS(propName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E45CB9)))
					{
						return GAJ916GydJRw77PSmJUt(classMetadata2);
					}
					num2 = 5;
					continue;
				case 3:
					if (parameters.Length == 1)
					{
						num2 = 2;
						continue;
					}
					goto IL_0168;
				case 24:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					if (xdNYSQGymFXqBxqm54bS(propName, x0xpn1Gy0S8ooB7DEvsL(0x637E299B ^ 0x637E6BF9)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 20;
				case 10:
					if (!xdNYSQGymFXqBxqm54bS(propName, x0xpn1Gy0S8ooB7DEvsL(0x53CB464B ^ 0x53CB0429)))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 24;
				case 9:
					if (xdNYSQGymFXqBxqm54bS(propName, x0xpn1Gy0S8ooB7DEvsL(-1998538950 ^ -1998523048)))
					{
						num2 = 21;
						continue;
					}
					goto case 19;
				case 7:
					obj2 = null;
					goto IL_0370;
				case 16:
					obj = null;
					goto IL_038d;
				case 8:
					classMetadata = source.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetValue_003Eb__0);
					if (classMetadata != null)
					{
						break;
					}
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 4;
					}
					continue;
				case 14:
					{
						classMetadata = source.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetValue_003Eb__1);
						break;
					}
					IL_038d:
					propertyInfo = (PropertyInfo)obj;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 10;
					}
					continue;
					IL_0168:
					throw new ArgumentException();
					IL_0370:
					type = (Type)obj2;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 22;
					}
					continue;
				}
				break;
			}
			classMetadata2 = classMetadata;
			num = 6;
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F617C8), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146245405))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A63B5A8)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6A5637), FunctionName),
				Types = new Guid[2]
				{
					ReferenceOnEntityTypeDecription.UID,
					ReferenceOnEntityTypeDecription.TypeUid_UID
				}
			}
		};
	}

	public ReferenceOnEntityTypeQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Mjcxg2Gyls2HAdWL2un3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CbO5vcGy7kxWwg7oMOP1()
	{
		return owwiVAGyAeBSKWono8Ld == null;
	}

	internal static ReferenceOnEntityTypeQueryResult UjWDDgGyx0QS0gN9wdyW()
	{
		return owwiVAGyAeBSKWono8Ld;
	}

	internal static object x0xpn1Gy0S8ooB7DEvsL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xdNYSQGymFXqBxqm54bS(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool r0VdrAGyytlCj7QlqUiM(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Type uPHCiTGyMS5IpSiBoHE8(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type plZ0XYGyJKcxbPa7XEO4(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static void ztCOu5Gy93ZX8XSKVQR1(object P_0, Guid value)
	{
		((ReferenceOnEntityType)P_0).TypeUid = value;
	}

	internal static Guid GAJ916GydJRw77PSmJUt(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void Mjcxg2Gyls2HAdWL2un3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
