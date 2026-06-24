using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Deploy.Import;

public class UserGroupImportEntitySaveAction : EntityImportSaveActions
{
	public static readonly Guid UID;

	private static UserGroupImportEntitySaveAction bETo1N3zB25pciDs1D1;

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == UID;
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IUserGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x1617B22));
		_003C_003Ec__DisplayClass2_.uidPropName = InterfaceActivator.PropertyName(Expression.Lambda<Func<IUserGroup, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
		if (propValues.ContainsKey(_003C_003Ec__DisplayClass2_.uidPropName))
		{
			parameterExpression = Expression.Parameter(typeof(IUserGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x201ABE6B ^ 0x201A44CB));
			string key = InterfaceActivator.PropertyName(Expression.Lambda<Func<IUserGroup, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			if (propValues.ContainsKey(key) && ModelHelper.GetEntityManager(UID).LoadOrNull(Guid.Parse(propValues[_003C_003Ec__DisplayClass2_.uidPropName] as string)) is IUserGroup userGroup)
			{
				SerializableList<object> serializableList = propValues[key] as SerializableList<object>;
				foreach (EleWise.ELMA.Security.Models.IUser item in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)userGroup.Users)
				{
					_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_1();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass2_;
					CS_0024_003C_003E8__locals0.userStringUid = item.Uid.ToString();
					SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
					serializableDictionary.Add(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.uidPropName, CS_0024_003C_003E8__locals0.userStringUid);
					if (serializableList.FirstOrDefault((object it) => _003C_003Ec__DisplayClass2_1.cxKHs1pU2oeWUtggM7cU((it as SerializableDictionary<string, object>)[CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.uidPropName] as string, CS_0024_003C_003E8__locals0.userStringUid)) == null)
					{
						serializableList.Add(serializableDictionary);
					}
				}
				propValues[key] = serializableList;
			}
		}
		return base.CanBeSaved(propValues, data);
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_00a5, IL_00b4, IL_00c4, IL_00d3, IL_01ef, IL_024e, IL_027f, IL_0397, IL_046a
		int num = 22;
		Guid result2 = default(Guid);
		XmlReader reader = default(XmlReader);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					return;
				case 31:
					if (K7djJcyLdCM0OsGu3B8(result2, default(Guid)))
					{
						num2 = 29;
						continue;
					}
					return;
				case 22:
					if (s6cUMNy55d0rTIF95oV(data) == null)
					{
						num2 = 21;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 1;
				case 16:
					result2 = Guid.Empty;
					num2 = 12;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
					{
						num2 = 3;
					}
					continue;
				case 18:
					ytjVcNymoBeCLLrkXs0(reader);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num2 = 25;
					}
					continue;
				case 1:
					reader = data.Reader;
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
					{
						num2 = 16;
					}
					continue;
				case 11:
					Guid.TryParse((string)VOSXgVyNgKYDGePAsBp(reader), out result2);
					num = 20;
					break;
				case 23:
					u31xXTyW0RKUCIpB0cJ(reader);
					num2 = 2;
					continue;
				case 9:
					reader.MoveToElement();
					num2 = 4;
					continue;
				case 12:
					text = "";
					num2 = 32;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
					{
						num2 = 19;
					}
					continue;
				case 4:
				case 25:
					if (eGwwaRye2LIEltsiT6e(reader) == XmlNodeType.EndElement)
					{
						num2 = 31;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 5;
				case 30:
					DGJfcsyAURXSToSdVID(reader);
					num2 = 27;
					continue;
				case 32:
					reader.Read();
					num2 = 30;
					continue;
				case 8:
					DGJfcsyAURXSToSdVID(reader);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					if (ROSoaEyX1vq1hSpWkEO(reader))
					{
						num2 = 19;
						continue;
					}
					goto case 14;
				case 15:
					if (zntpcxylPuWEhrp93SC(reader))
					{
						num2 = 13;
						continue;
					}
					goto case 6;
				case 19:
				{
					object obj = QHmkwbynXdR3Z1LArl7(reader);
					ParameterExpression parameterExpression = (ParameterExpression)uWSvlgyiMV2BhlLwWsB(typeof(IUserGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x22A54A05 ^ 0x22A5B0AD));
					if (!DEHfbqy6RuyD0rBkoKh(obj, LinqUtils.NameOf(Expression.Lambda<Func<IUserGroup, object>>((Expression)URhjw6y781jRPKRbets(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 24;
						continue;
					}
					goto default;
				}
				case 10:
					text = (string)VOSXgVyNgKYDGePAsBp(reader);
					num = 23;
					break;
				case 14:
				case 17:
				case 24:
					if (!ROSoaEyX1vq1hSpWkEO(reader))
					{
						num2 = 3;
						continue;
					}
					goto case 28;
				default:
					if (zntpcxylPuWEhrp93SC(reader))
					{
						num2 = 14;
						continue;
					}
					goto case 8;
				case 2:
				case 3:
				case 7:
				case 13:
					g5t3Mcyusua2kvPjIWx(reader);
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 != 0)
					{
						num2 = 18;
					}
					continue;
				case 6:
					DGJfcsyAURXSToSdVID(reader);
					num2 = 11;
					continue;
				case 29:
					evV7pgya0UoFyRh37IY(PLe9g5yHvmEhyQ6Fxml(y0Jf9Qyj8L0HKZ0FZog(s6cUMNy55d0rTIF95oV(data)), SecurityExportConsts.ExportExtensionUidUserGroup, ""), result2, text);
					num2 = 26;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
					{
						num2 = 17;
					}
					continue;
				case 28:
				{
					string name = reader.Name;
					ParameterExpression parameterExpression = (ParameterExpression)uWSvlgyiMV2BhlLwWsB(tjEUAeyZrdoiocD2qDB(typeof(IUserGroup).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580341915));
					if (DEHfbqy6RuyD0rBkoKh(name, LinqUtils.NameOf(Expression.Lambda<Func<IUserGroup, object>>((Expression)HuV4UfyBsWpRtiIHb1P(Expression.Property(parameterExpression, (MethodInfo)jkVcbUyx0lS8i6KNhEZ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), tjEUAeyZrdoiocD2qDB(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }))))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 2;
				}
				case 26:
					return;
				case 27:
					u31xXTyW0RKUCIpB0cJ(reader);
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
					{
						num2 = 9;
					}
					continue;
				case 20:
					u31xXTyW0RKUCIpB0cJ(reader);
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	public UserGroupImportEntitySaveAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VFuwQDyReWWJLUQGMks();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserGroupImportEntitySaveAction()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				VFuwQDyReWWJLUQGMks();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = InterfaceActivator.UID<IUserGroup>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool pS3fMuykK6WHvsnEorA()
	{
		return bETo1N3zB25pciDs1D1 == null;
	}

	internal static UserGroupImportEntitySaveAction ef7qWxypMDhMIGTZp7h()
	{
		return bETo1N3zB25pciDs1D1;
	}

	internal static object s6cUMNy55d0rTIF95oV(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static bool DGJfcsyAURXSToSdVID(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool u31xXTyW0RKUCIpB0cJ(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool ROSoaEyX1vq1hSpWkEO(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object QHmkwbynXdR3Z1LArl7(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static object uWSvlgyiMV2BhlLwWsB(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object URhjw6y781jRPKRbets(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool DEHfbqy6RuyD0rBkoKh(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool zntpcxylPuWEhrp93SC(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object VOSXgVyNgKYDGePAsBp(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static Type tjEUAeyZrdoiocD2qDB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object jkVcbUyx0lS8i6KNhEZ(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object HuV4UfyBsWpRtiIHb1P(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static void g5t3Mcyusua2kvPjIWx(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType ytjVcNymoBeCLLrkXs0(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType eGwwaRye2LIEltsiT6e(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool K7djJcyLdCM0OsGu3B8(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object y0Jf9Qyj8L0HKZ0FZog(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}

	internal static object PLe9g5yHvmEhyQ6Fxml(object P_0, Guid P_1, object P_2)
	{
		return ((BPMAppFakeManifest)P_0).GetOrCreateChapterByUid(P_1, (string)P_2);
	}

	internal static object evV7pgya0UoFyRh37IY(object P_0, Guid P_1, object P_2)
	{
		return ((BPMAppManifestFakeChapter)P_0).GetOrCreateItemByUid(P_1, (string)P_2);
	}

	internal static void VFuwQDyReWWJLUQGMks()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
