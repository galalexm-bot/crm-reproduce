using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryInFunctions;

[Component]
public class SubTypesFunction : IQueryInFunction, IEQLFunction
{
	private static SubTypesFunction dOwsZMGxLpL8ilpJ582g;

	public string FunctionName => (string)wAOywUGxcnbqw0XsIoWP(-1334993905 ^ -1335257181);

	public ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_009d, IL_00d1, IL_0133, IL_022e, IL_0256, IL_0265, IL_02d7, IL_034b, IL_0398
		int num = 10;
		List<ClassMetadata> childClasses = default(List<ClassMetadata>);
		ClassMetadata classMetadata = default(ClassMetadata);
		Guid result = default(Guid);
		PropertyInfo propertyInfo = default(PropertyInfo);
		object[] array = default(object[]);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		Type type = default(Type);
		string text = default(string);
		object[] array2 = default(object[]);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		IEnumerable<EntityMetadata> source = default(IEnumerable<EntityMetadata>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object[] array3;
				object obj2;
				object obj;
				object obj3;
				EntityMetadata entityMetadata;
				switch (num2)
				{
				case 23:
					throw new ArgumentException();
				case 30:
					childClasses.Add(classMetadata);
					num2 = 19;
					continue;
				case 27:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(result);
					num2 = 7;
					continue;
				default:
					if (!W6AsqiGxzFCmQv4sCGXC(propName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978494320)))
					{
						num2 = 3;
						continue;
					}
					array3 = ((IEnumerable<ClassMetadata>)childClasses).Select((Func<ClassMetadata, object>)((ClassMetadata m) => m.Uid)).ToArray();
					goto IL_04dd;
				case 11:
					obj2 = propName;
					goto IL_0444;
				case 12:
					if (vSlpNpG0Bq7Npg0CTrPY(propName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE13917)))
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto IL_00ad;
				case 25:
					if (classMetadata == null)
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 29;
				case 19:
					if (W6AsqiGxzFCmQv4sCGXC(propName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EE1FB)))
					{
						num2 = 18;
						continue;
					}
					goto case 11;
				case 4:
					if (!W6AsqiGxzFCmQv4sCGXC(propName, wAOywUGxcnbqw0XsIoWP(-1638402543 ^ -1638419341)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 20;
						}
						continue;
					}
					obj = null;
					goto IL_03bb;
				case 7:
				case 17:
				case 22:
					childClasses = MetadataLoader.GetChildClasses(classMetadata);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 30;
					}
					continue;
				case 21:
					if (!KDDU6OG0W2Xscqqh6sP6(propertyInfo, null))
					{
						num = 16;
						break;
					}
					goto case 23;
				case 2:
					array3 = array;
					goto IL_04dd;
				case 15:
					_003C_003Ec__DisplayClass2_.name = (string)parameters[0];
					num = 8;
					break;
				case 26:
					throw new ArgumentException();
				case 10:
					if (parameters.Length == 1)
					{
						num2 = 9;
						continue;
					}
					goto case 26;
				case 29:
					classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(bROawNG0baBmGl0wE0Zc(classMetadata));
					num2 = 17;
					continue;
				case 28:
					obj3 = I6AKUaG0FE6HqfAsrqEr(type, propName);
					goto IL_03d8;
				case 6:
				case 24:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 14;
					continue;
				case 16:
					if (!ORXI3bG0oXosVVCsEyCx(typeof(ReferenceOnEntityType).TypeHandle).IsAssignableFrom(propertyInfo.PropertyType))
					{
						num2 = 23;
						continue;
					}
					goto IL_00ad;
				case 13:
					return (ICriterion)AfOU0gG0Eic4CRT2bv9q(Qq9T8NG0GHig9AQPZO3e(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561057946), alias, text), array2);
				case 20:
					obj = serviceNotNull.GetTypeByUid(metadata.Uid);
					goto IL_03bb;
				case 9:
					if (parameters[0] is string)
					{
						serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 26;
					}
					continue;
				case 1:
					if (!(propName == (string)wAOywUGxcnbqw0XsIoWP(0x10E41EDB ^ 0x10E45CB9)))
					{
						num2 = 28;
						continue;
					}
					obj3 = null;
					goto IL_03d8;
				case 14:
					source = serviceNotNull.GetMetadataList().OfType<EntityMetadata>();
					num2 = 15;
					continue;
				case 8:
					entityMetadata = source.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetCriterion_003Eb__2);
					if (entityMetadata != null)
					{
						goto IL_0432;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					entityMetadata = source.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetCriterion_003Eb__3);
					goto IL_0432;
				case 18:
					obj2 = kgE9ZDG0hHErpjbw3ph5(metadata);
					goto IL_0444;
				case 3:
					{
						array = childClasses.Select(delegate(ClassMetadata m)
						{
							ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType();
							_003C_003Ec.VLvNfW8CQrXXq1D7E4x2(referenceOnEntityType, _003C_003Ec.lOcpr48CflwNhpB0W2nP(m));
							return referenceOnEntityType;
						}).ToArray();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					IL_0432:
					classMetadata = entityMetadata;
					num2 = 25;
					continue;
					IL_00ad:
					if (!Guid.TryParse((string)parameters[0], out result))
					{
						num2 = 6;
						continue;
					}
					goto case 27;
					IL_03bb:
					type = (Type)obj;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					continue;
					IL_0444:
					text = (string)obj2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					continue;
					IL_03d8:
					propertyInfo = (PropertyInfo)obj3;
					num2 = 12;
					continue;
					IL_04dd:
					array2 = array3;
					num2 = 13;
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
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751360866), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420479770))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881862006)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1625F3), FunctionName),
				Types = new Guid[2]
				{
					ReferenceOnEntityTypeDecription.UID,
					ReferenceOnEntityTypeDecription.TypeUid_UID
				}
			}
		};
	}

	public SubTypesFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CHpyXfG0fSkjssCUeW2Z();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object wAOywUGxcnbqw0XsIoWP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool VyUGbMGxUqCaDPXrQGMG()
	{
		return dOwsZMGxLpL8ilpJ582g == null;
	}

	internal static SubTypesFunction qlUT3fGxs7RBbJI8Q0St()
	{
		return dOwsZMGxLpL8ilpJ582g;
	}

	internal static bool W6AsqiGxzFCmQv4sCGXC(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object I6AKUaG0FE6HqfAsrqEr(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool vSlpNpG0Bq7Npg0CTrPY(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool KDDU6OG0W2Xscqqh6sP6(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type ORXI3bG0oXosVVCsEyCx(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid bROawNG0baBmGl0wE0Zc(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object kgE9ZDG0hHErpjbw3ph5(object P_0)
	{
		return NHibernateHelper.GetCriteriaTypeUidPropertyName((EntityMetadata)P_0);
	}

	internal static object Qq9T8NG0GHig9AQPZO3e(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object AfOU0gG0Eic4CRT2bv9q(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static void CHpyXfG0fSkjssCUeW2Z()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
