using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Components;

[Component]
internal class FormDependenciesImportExtension : ConfigImportExtension
{
	private readonly ISecurityService securityService;

	private readonly IEnumerable<IFormDependencyExtension> formDependencyExtensions;

	internal static FormDependenciesImportExtension mSGQdoEyYNVpcO40mg5b;

	public FormDependenciesImportExtension(ISecurityService securityService, IEnumerable<IFormDependencyExtension> formDependencyExtensions)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.securityService = securityService;
		this.formDependencyExtensions = formDependencyExtensions;
	}

	public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
	{
		int num = 5;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003C_003Ec__DisplayClass3_.parameters = parameters;
					num2 = 3;
					continue;
				case 5:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					if (_003C_003Ec__DisplayClass3_.parameters.ServiceData != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					return;
				case 9:
					return;
				case 0:
					return;
				case 8:
					if (_003C_003Ec__DisplayClass3_.parameters.Messages != null)
					{
						_003C_003Ec__DisplayClass3_.forms = ReadObjectForms(_003C_003Ec__DisplayClass3_.parameters.ServiceData);
						num = 7;
						break;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 9;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					_003C_003Ec__DisplayClass3_.dependencies = ReadDependencies(_003C_003Ec__DisplayClass3_.parameters.ServiceData);
					num = 2;
					break;
				case 3:
					if (_003C_003Ec__DisplayClass3_.parameters == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					luSiI1Eys40RTGENypPt(securityService, new Action(_003C_003Ec__DisplayClass3_._003COnPostCompleteTest_003Eb__0));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void OnPostCompleteImport(PostCompleteImportParameters parameters)
	{
		//Discarded unreachable code: IL_00b4
		int num = 10;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 11:
					_003C_003Ec__DisplayClass4_.parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", endProcess: false));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (_003C_003Ec__DisplayClass4_.parameters.ServiceData == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 8;
				case 0:
					return;
				case 6:
					return;
				case 2:
					if (!_003C_003Ec__DisplayClass4_.hasMessages)
					{
						return;
					}
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass4_._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 9;
					continue;
				case 7:
					if (_003C_003Ec__DisplayClass4_.parameters != null)
					{
						num2 = 5;
						continue;
					}
					return;
				case 4:
					break;
				case 1:
					_003C_003Ec__DisplayClass4_.parameters = parameters;
					num2 = 7;
					continue;
				case 8:
					if (_003C_003Ec__DisplayClass4_.parameters.Messages == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						_003C_003Ec__DisplayClass4_.hasMessages = false;
						num2 = 4;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			securityService.RunWithElevatedPrivilegies(_003C_003Ec__DisplayClass4_._003COnPostCompleteImport_003Eb__0);
			num = 2;
		}
	}

	private string GetDependencyObjectName(string dependency, Dictionary<string, string> serviceData)
	{
		string key = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F3E68), ExportFormDependencyHelper.FormDependencyDisplayName, dependency);
		if (!serviceData.ContainsKey(key))
		{
			return string.Empty;
		}
		return serviceData[key];
	}

	private List<IFormDependencyData> ReadDependencies(Dictionary<string, string> serviceData)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		List<IFormDependencyData> list = new List<IFormDependencyData>();
		CS_0024_003C_003E8__locals0.keyPrefix = ExportFormDependencyHelper.FormDependencyPrefix + FormDependencyHelper.KeySplitter;
		foreach (KeyValuePair<string, string> item in serviceData.Where((KeyValuePair<string, string> p) => p.Key.StartsWith(CS_0024_003C_003E8__locals0.keyPrefix)))
		{
			string[] array = item.Key.Replace(CS_0024_003C_003E8__locals0.keyPrefix, "").Split(new string[1] { FormDependencyHelper.KeySplitter }, StringSplitOptions.None);
			string[] array2 = item.Value.Split(new string[1] { FormDependencyHelper.KeySplitter }, StringSplitOptions.None);
			if (Guid.TryParse(array[0], out var result) && Guid.TryParse(array[1], out var result2) && Guid.TryParse(array2[0], out var result3) && Guid.TryParse(array2[1], out var result4) && Enum.TryParse<FormDependencyDataType>(array[2], out var result5))
			{
				list.Add(new FormDependencyData(result, result2, result3, result4, result5));
			}
		}
		return list;
	}

	private Dictionary<Guid, List<Guid>> ReadObjectForms(Dictionary<string, string> serviceData)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		Dictionary<Guid, List<Guid>> dictionary = new Dictionary<Guid, List<Guid>>();
		CS_0024_003C_003E8__locals0.keyPrefix = ExportFormDependencyHelper.ObjectFormsPrefix + FormDependencyHelper.KeySplitter;
		foreach (KeyValuePair<string, string> item in serviceData.Where((KeyValuePair<string, string> q) => q.Key.StartsWith(CS_0024_003C_003E8__locals0.keyPrefix)))
		{
			if (!Guid.TryParse(item.Key.Replace(CS_0024_003C_003E8__locals0.keyPrefix, ""), out var result))
			{
				continue;
			}
			string[] array = item.Value.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675749631) }, StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				if (Guid.TryParse(array[i], out var result2))
				{
					if (dictionary.ContainsKey(result))
					{
						dictionary[result].Add(result2);
						continue;
					}
					dictionary.Add(result, new List<Guid> { result2 });
				}
			}
		}
		return dictionary;
	}

	internal static void luSiI1Eys40RTGENypPt(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static bool di5ysmEyLW89b2mRpPTs()
	{
		return mSGQdoEyYNVpcO40mg5b == null;
	}

	internal static FormDependenciesImportExtension EcnLD3EyUFTt4YmpGkR4()
	{
		return mSGQdoEyYNVpcO40mg5b;
	}
}
