using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

[Component]
internal sealed class ModuleHeaderImportSaveActions : EntityImportSaveActions
{
	internal sealed class Tester
	{
		private static readonly string errorStart;

		private readonly Action<TestImportMessagesType, string> logger;

		private readonly XmlReader reader;

		private readonly TestModuleImportSettings settings;

		private static Tester Jr5b5w84exsSl3hZdV19;

		public Tester(XmlReader reader, TestModuleImportSettings settings, Action<TestImportMessagesType, string> logger)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.reader = reader;
			this.settings = settings;
			this.logger = logger;
		}

		public Guid? Test()
		{
			if (settings.ModuleHeaderUid.HasValue)
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939697982)));
				return settings.ModuleHeaderUid;
			}
			XElement xElement = XElement.Load(reader.ReadSubtree()).Descendants().FirstOrDefault(delegate(XElement e)
			{
				object obj = _003C_003Ec.br8FPtZePAdEca1LEhDH(e);
				ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec.cj5Uw2ZeNTaqMCrPoXCF(_003C_003Ec.yg3D9vZe1tFIUEcp4Mwv(typeof(ModuleMetadataItemHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380395F));
				return _003C_003Ec.J2XFo7ZeaDI2ndkhU1EN(obj, (XName)LinqUtils.NameOf(Expression.Lambda<Func<ModuleMetadataItemHeader, object>>((Expression)_003C_003Ec.MJBk0KZepJCq0ImxVsUP(_003C_003Ec.Mp4Z1VZe39cLixdIrg76(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), _003C_003Ec.yg3D9vZe1tFIUEcp4Mwv(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
			});
			if (xElement == null || !Guid.TryParse(xElement.Value, out var result))
			{
				LogError(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108429576)));
				return null;
			}
			return result;
		}

		private void LogError(string message)
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
					logger(TestImportMessagesType.Error, errorStart + message);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		static Tester()
		{
			int num = 2;
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
					errorStart = (string)fPrjDZ84pHDKqV0Pm2gt(GI3vtB84336BsXKsxRgA(-70037984 ^ -69815492));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					z2B9DW84NyYXSUjIsPGT();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool JnIUhB84PhEWuVrcw4mF()
		{
			return Jr5b5w84exsSl3hZdV19 == null;
		}

		internal static Tester mGeBTp841EbMy4iYmmnm()
		{
			return Jr5b5w84exsSl3hZdV19;
		}

		internal static void z2B9DW84NyYXSUjIsPGT()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object GI3vtB84336BsXKsxRgA(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object fPrjDZ84pHDKqV0Pm2gt(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	private readonly IEntityManager<ModuleMetadataItemHeader> moduleHeaderManager;

	private static ModuleHeaderImportSaveActions JAexc9EM7CJh82NkNJsc;

	public ModuleHeaderImportSaveActions(IEntityManager<ModuleMetadataItemHeader> moduleHeaderManager)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.moduleHeaderManager = moduleHeaderManager;
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == ModuleMetadataItemHeader.UID;
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_00c0, IL_00cf
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass3_0);
		TestModuleImportSettings testModuleImportSettings = default(TestModuleImportSettings);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				CS_0024_003C_003E8__locals0.testModuleImportSettings.ModuleHeaderUid = new Tester((XmlReader)rWUbjQEMMi5N4Wp52klO(data), CS_0024_003C_003E8__locals0.testModuleImportSettings, Logger).Test();
				num2 = 9;
				break;
			case 10:
				return;
			case 5:
				kka9egEMJJjeX3eAD9m4(rWUbjQEMMi5N4Wp52klO(data));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				CS_0024_003C_003E8__locals0.result = result;
				num2 = 6;
				break;
			case 2:
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				testModuleImportSettings = (CS_0024_003C_003E8__locals0.testModuleImportSettings = XfZWU1EMmcCQBeUqQhgw(data) as TestModuleImportSettings);
				num2 = 8;
				break;
			default:
				text = SR.T((string)vuSWONEMyVXubo5LbMTK(0x3B36AB09 ^ 0x3B326B45), vuSWONEMyVXubo5LbMTK(0x34185E55 ^ 0x341C9F5B));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				if (testModuleImportSettings != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 3:
				((IImportSettings)XfZWU1EMmcCQBeUqQhgw(data)).TestResult.Add(new TestImportMessages(TestImportMessagesType.Error, text));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 10;
				}
				break;
			case 9:
				return;
			case 7:
				CS_0024_003C_003E8__locals0.result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, text));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
	{
		if (!serviceData.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B3217B9)) || moduleHeaderManager.LoadOrNull(entity.GetId()) == null)
		{
			base.ExecSaveActions(entity, serviceData);
		}
	}

	internal static bool xIkJZTEMxmAUkJ1wLjT4()
	{
		return JAexc9EM7CJh82NkNJsc == null;
	}

	internal static ModuleHeaderImportSaveActions s7cUlhEM0xvFjcaHU1FU()
	{
		return JAexc9EM7CJh82NkNJsc;
	}

	internal static object XfZWU1EMmcCQBeUqQhgw(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static object vuSWONEMyVXubo5LbMTK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rWUbjQEMMi5N4Wp52klO(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static XmlNodeType kka9egEMJJjeX3eAD9m4(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}
}
