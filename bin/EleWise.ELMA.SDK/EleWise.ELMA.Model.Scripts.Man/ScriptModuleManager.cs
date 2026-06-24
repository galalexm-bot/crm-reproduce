using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Manager;

public class ScriptModuleManager : EntityManager<ScriptModule, long>
{
	public static readonly string[] GlobalAssemblyList;

	internal static ScriptModuleManager MMVOwAbOYTTLLANhvKWB;

	public new static ScriptModuleManager Instance => Locator.GetServiceNotNull<ScriptModuleManager>();

	public IEnumerable<IScriptModuleType> ScriptModuleTypes { get; set; }

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<ScriptModule>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule obj = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)h6p9C9bOsM01G9cgjIEP(0x1FFEF86A ^ 0x1FFF483A)
			};
			o29KxubOcZFj3muL8PXG(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule, type);
			exportRule.PropertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FE7A59);
			o29KxubOcZFj3muL8PXG(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule2, type);
			eMty7mb2FWQb0NsmdQyC(exportRule2, h6p9C9bOsM01G9cgjIEP(-1765851862 ^ -1765898968));
			o29KxubOcZFj3muL8PXG(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			eMty7mb2FWQb0NsmdQyC(obj2, h6p9C9bOsM01G9cgjIEP(-1876063057 ^ -1876151167));
			obj2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj2);
			ExportRule exportRule3 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule3, type);
			eMty7mb2FWQb0NsmdQyC(exportRule3, h6p9C9bOsM01G9cgjIEP(-1858887263 ^ -1858989893));
			exportRule3.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule4, type);
			exportRule4.PropertyName = (string)h6p9C9bOsM01G9cgjIEP(0x26FFCB59 ^ 0x26FF66A5);
			o29KxubOcZFj3muL8PXG(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule5, type);
			eMty7mb2FWQb0NsmdQyC(exportRule5, h6p9C9bOsM01G9cgjIEP(-1751176224 ^ -1751213578));
			o29KxubOcZFj3muL8PXG(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule exportRule6 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule6, type);
			eMty7mb2FWQb0NsmdQyC(exportRule6, h6p9C9bOsM01G9cgjIEP(0x3C5338FF ^ 0x3C5280AD));
			o29KxubOcZFj3muL8PXG(exportRule6, ExportRuleType.Export);
			exportRuleList.Add(exportRule6);
			ExportRule exportRule7 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule7, type);
			eMty7mb2FWQb0NsmdQyC(exportRule7, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDD3C7E));
			exportRule7.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule7);
			ExportRule exportRule8 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule8, type);
			eMty7mb2FWQb0NsmdQyC(exportRule8, h6p9C9bOsM01G9cgjIEP(--1418440330 ^ 0x548A16FA));
			o29KxubOcZFj3muL8PXG(exportRule8, ExportRuleType.Export);
			exportRuleList.Add(exportRule8);
			ExportRule exportRule9 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule9, type);
			eMty7mb2FWQb0NsmdQyC(exportRule9, h6p9C9bOsM01G9cgjIEP(0x68BBB53E ^ 0x68BA0DB8));
			o29KxubOcZFj3muL8PXG(exportRule9, ExportRuleType.Export);
			exportRuleList.Add(exportRule9);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type
			};
			eMty7mb2FWQb0NsmdQyC(obj3, h6p9C9bOsM01G9cgjIEP(-740338220 ^ -740365062));
			o29KxubOcZFj3muL8PXG(obj3, ExportRuleType.Export);
			exportRuleList.Add(obj3);
			ExportRule exportRule10 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule10, type);
			eMty7mb2FWQb0NsmdQyC(exportRule10, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C5280E7));
			o29KxubOcZFj3muL8PXG(exportRule10, ExportRuleType.Export);
			exportRuleList.Add(exportRule10);
			ExportRule exportRule11 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule11, type);
			eMty7mb2FWQb0NsmdQyC(exportRule11, h6p9C9bOsM01G9cgjIEP(-1633514411 ^ -1633492025));
			o29KxubOcZFj3muL8PXG(exportRule11, ExportRuleType.Export);
			exportRuleList.Add(exportRule11);
			ExportRule exportRule12 = new ExportRule();
			JoWOZBbOzrj9GMe7B1D1(exportRule12, type);
			eMty7mb2FWQb0NsmdQyC(exportRule12, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E5A79D));
			exportRule12.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule12);
			return exportRuleList;
		}
	}

	public void ConvertOldReferences(ScriptModule module)
	{
		//Discarded unreachable code: IL_00b5, IL_00c4, IL_01ab, IL_01ba, IL_025c, IL_02d4, IL_02e7, IL_02f6, IL_0340, IL_037b, IL_038a
		int num = 9;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					module.WebReferences = new List<ScriptWebReference>();
					num2 = 10;
					continue;
				case 10:
					if (!string.IsNullOrEmpty((string)MLJfwqb2ojd3aOY3mSco(module)))
					{
						num2 = 18;
						continue;
					}
					break;
				default:
					if (module.LocalReferences == null)
					{
						goto end_IL_0012;
					}
					goto case 12;
				case 16:
					module.LocalReferences = new List<AssemblyReference>();
					num2 = 12;
					continue;
				case 14:
					if (module.LocalReferences != null)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				case 5:
					if (module.WebReferences == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 14;
				case 18:
					enumerator = module.References.Split((char[])PYyjcRb2bVvcJkUti2UW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA597E9D)), StringSplitOptions.RemoveEmptyEntries).ToList().GetEnumerator();
					num2 = 17;
					continue;
				case 7:
					WFdwVIb2W5xwRfl6sW7N(module, "");
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					if (module.GlobalScriptModules == null)
					{
						num2 = 8;
						continue;
					}
					goto case 5;
				case 17:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_01c9;
							}
							goto IL_0291;
							IL_0221:
							WFdwVIb2W5xwRfl6sW7N(module, (string)zlwxofb2BJH4XrL4sb8s(module) + string.Format((string)h6p9C9bOsM01G9cgjIEP(-882126494 ^ -882304270), current));
							int num4 = 6;
							goto IL_01c5;
							IL_0291:
							current = enumerator.Current;
							num4 = 3;
							goto IL_01c5;
							IL_01c5:
							num3 = num4;
							goto IL_01c9;
							IL_01c9:
							while (true)
							{
								switch (num3)
								{
								case 4:
									if (!((string)zlwxofb2BJH4XrL4sb8s(module)).Contains(current))
									{
										num3 = 5;
										continue;
									}
									break;
								case 5:
									goto IL_0221;
								case 3:
									if (GlobalAssemblyList.Contains(current))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 4;
								case 1:
									goto IL_0291;
								case 2:
									goto end_IL_020b;
								}
								break;
							}
							continue;
							end_IL_020b:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					break;
				case 6:
					module.GlobalScriptModules = new List<AssemblyReference>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				case 2:
					if (module.GlobalScriptModules == null)
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 15:
					return;
				case 8:
				case 11:
					if (zlwxofb2BJH4XrL4sb8s(module) != null)
					{
						num2 = 2;
						continue;
					}
					goto case 7;
				case 3:
					return;
				case 12:
					if (module.WebReferences == null)
					{
						num2 = 4;
						continue;
					}
					goto case 10;
				case 13:
					break;
				}
				MoHpFJb2hoBoL2utbG9m(module);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 16;
		}
	}

	public IScriptModuleType GetScriptModuleType(Guid moduleTypeUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass8_.moduleTypeUid = moduleTypeUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return ScriptModuleTypes.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetScriptModuleType_003Eb__0);
			}
		}
	}

	public ScriptModuleManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eCD9C1b2GHFOQib9boyC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ScriptModuleManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				eCD9C1b2GHFOQib9boyC();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				continue;
			}
			GlobalAssemblyList = new string[115]
			{
				(string)h6p9C9bOsM01G9cgjIEP(-1876063057 ^ -1875949773),
				(string)h6p9C9bOsM01G9cgjIEP(0x638095EB ^ 0x63825E51),
				(string)h6p9C9bOsM01G9cgjIEP(0x3CE17B75 ^ 0x3CE3B0AB),
				(string)h6p9C9bOsM01G9cgjIEP(-1317790512 ^ -1317611736),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC38BAA),
				(string)h6p9C9bOsM01G9cgjIEP(-138018305 ^ -138097245),
				(string)h6p9C9bOsM01G9cgjIEP(-1822890472 ^ -1822807404),
				(string)h6p9C9bOsM01G9cgjIEP(0x7459E02 ^ 0x74752C0),
				(string)h6p9C9bOsM01G9cgjIEP(-1979251663 ^ -1979332405),
				(string)h6p9C9bOsM01G9cgjIEP(0x5DD55050 ^ 0x5DD79D6A),
				(string)h6p9C9bOsM01G9cgjIEP(0x4EA5403C ^ 0x4EA78D5C),
				(string)h6p9C9bOsM01G9cgjIEP(0x18A6761F ^ 0x18A4BB91),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x4638C2E4),
				(string)h6p9C9bOsM01G9cgjIEP(-195614443 ^ -195696839),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487237580),
				(string)h6p9C9bOsM01G9cgjIEP(0x5F3078B6 ^ 0x5F32B630),
				(string)h6p9C9bOsM01G9cgjIEP(-2099751081 ^ -2099602975),
				(string)h6p9C9bOsM01G9cgjIEP(0x7247028A ^ 0x7245CC50),
				(string)h6p9C9bOsM01G9cgjIEP(0x18A6761F ^ 0x18A4B917),
				(string)h6p9C9bOsM01G9cgjIEP(0x3A6135BE ^ 0x3A63FAFE),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420923304),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218575336),
				(string)h6p9C9bOsM01G9cgjIEP(0x103FE975 ^ 0x103D2687),
				(string)h6p9C9bOsM01G9cgjIEP(-561074844 ^ -561218186),
				(string)h6p9C9bOsM01G9cgjIEP(0x53FA00CE ^ 0x53FB0E90),
				(string)h6p9C9bOsM01G9cgjIEP(-1317790512 ^ -1317614346),
				(string)h6p9C9bOsM01G9cgjIEP(0x7459E02 ^ 0x7474E4E),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123784472),
				(string)h6p9C9bOsM01G9cgjIEP(-957824448 ^ -957738336),
				(string)h6p9C9bOsM01G9cgjIEP(-1411196499 ^ -1411381107),
				(string)h6p9C9bOsM01G9cgjIEP(0x3B36AB09 ^ 0x3B347A35),
				(string)h6p9C9bOsM01G9cgjIEP(-2138958856 ^ -2139045230),
				(string)h6p9C9bOsM01G9cgjIEP(-1638402543 ^ -1638495799),
				(string)h6p9C9bOsM01G9cgjIEP(-309639236 ^ -309750260),
				(string)h6p9C9bOsM01G9cgjIEP(-1824388195 ^ -1824466367),
				(string)h6p9C9bOsM01G9cgjIEP(0x4D1C1EE4 ^ 0x4D1D615A),
				(string)h6p9C9bOsM01G9cgjIEP(-2138958856 ^ -2139045408),
				(string)h6p9C9bOsM01G9cgjIEP(-87337865 ^ -87456201),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979328953),
				(string)h6p9C9bOsM01G9cgjIEP(0x103FE975 ^ 0x103D3BEF),
				(string)h6p9C9bOsM01G9cgjIEP(-538519530 ^ -538703144),
				(string)h6p9C9bOsM01G9cgjIEP(-195614443 ^ -195691537),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751254828),
				(string)h6p9C9bOsM01G9cgjIEP(-2138958856 ^ -2139045738),
				(string)h6p9C9bOsM01G9cgjIEP(-218496594 ^ -218574280),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571C7025),
				(string)h6p9C9bOsM01G9cgjIEP(0xA592A41 ^ 0xA5BF99B),
				(string)h6p9C9bOsM01G9cgjIEP(-1710575414 ^ -1710726350),
				(string)h6p9C9bOsM01G9cgjIEP(--1360331293 ^ 0x5117D631),
				(string)h6p9C9bOsM01G9cgjIEP(0x7E6E5A0B ^ 0x7E6C8E8F),
				(string)h6p9C9bOsM01G9cgjIEP(0x76DD48E ^ 0x76FE1B4),
				(string)h6p9C9bOsM01G9cgjIEP(0x18A6761F ^ 0x18A4A2D3),
				(string)h6p9C9bOsM01G9cgjIEP(0x76DD48E ^ 0x76F0074),
				(string)h6p9C9bOsM01G9cgjIEP(-1979251663 ^ -1979330303),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710725738),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921117601),
				(string)h6p9C9bOsM01G9cgjIEP(0x4D1C1EE4 ^ 0x4D1ECB5E),
				(string)h6p9C9bOsM01G9cgjIEP(-2112703338 ^ -2112855690),
				(string)h6p9C9bOsM01G9cgjIEP(-740338220 ^ -740457486),
				(string)h6p9C9bOsM01G9cgjIEP(0x1DE3DD89 ^ 0x1DE10BC3),
				(string)h6p9C9bOsM01G9cgjIEP(-561074844 ^ -561218810),
				(string)h6p9C9bOsM01G9cgjIEP(-16752921 ^ -16611229),
				(string)h6p9C9bOsM01G9cgjIEP(-105199646 ^ -105377468),
				(string)h6p9C9bOsM01G9cgjIEP(-2112703338 ^ -2112844162),
				(string)h6p9C9bOsM01G9cgjIEP(-1767720453 ^ -1767870675),
				(string)h6p9C9bOsM01G9cgjIEP(0x63ABA4E8 ^ 0x63AA2412),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EEDBB0),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218613118),
				(string)h6p9C9bOsM01G9cgjIEP(-812025778 ^ -812058466),
				(string)h6p9C9bOsM01G9cgjIEP(-867826612 ^ -867904728),
				(string)h6p9C9bOsM01G9cgjIEP(-951514650 ^ -951329214),
				(string)h6p9C9bOsM01G9cgjIEP(0x49E27B8A ^ 0x49E0AC6E),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571C7BB9),
				(string)h6p9C9bOsM01G9cgjIEP(-2138160520 ^ -2138269146),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36169397),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146389015),
				(string)h6p9C9bOsM01G9cgjIEP(0x1C9495B4 ^ 0x1C964D4C),
				(string)h6p9C9bOsM01G9cgjIEP(-812025778 ^ -811884200),
				(string)h6p9C9bOsM01G9cgjIEP(-218496594 ^ -218398248),
				(string)h6p9C9bOsM01G9cgjIEP(0x3630F361 ^ 0x36322A21),
				(string)h6p9C9bOsM01G9cgjIEP(--1360331293 ^ 0x5117DB6F),
				(string)h6p9C9bOsM01G9cgjIEP(0x1FFEF86A ^ 0x1FFC21D8),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576029110),
				(string)h6p9C9bOsM01G9cgjIEP(0x7C1EE318 ^ 0x7C1C3920),
				(string)h6p9C9bOsM01G9cgjIEP(0x638095EB ^ 0x63824F83),
				(string)h6p9C9bOsM01G9cgjIEP(0x92F12D5 ^ 0x92DC873),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A836378),
				(string)h6p9C9bOsM01G9cgjIEP(-1837662597 ^ -1837808331),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875945553),
				(string)h6p9C9bOsM01G9cgjIEP(-1765851862 ^ -1765939690),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE10F2AD),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345270684),
				(string)h6p9C9bOsM01G9cgjIEP(0x26FFCB59 ^ 0x26FE4BD7),
				(string)h6p9C9bOsM01G9cgjIEP(0x269E5FCA ^ 0x269C8402),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307C4425),
				(string)h6p9C9bOsM01G9cgjIEP(0x5DD55050 ^ 0x5DD78C14),
				(string)h6p9C9bOsM01G9cgjIEP(-16752921 ^ -16612795),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53E7049),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426236899),
				(string)h6p9C9bOsM01G9cgjIEP(0x5F3078B6 ^ 0x5F32A5EA),
				(string)h6p9C9bOsM01G9cgjIEP(-957824448 ^ -957734948),
				(string)h6p9C9bOsM01G9cgjIEP(-951514650 ^ -951331800),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87455113),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E62253),
				(string)h6p9C9bOsM01G9cgjIEP(-978351861 ^ -978495727),
				(string)h6p9C9bOsM01G9cgjIEP(0x49E27B8A ^ 0x49E3FBD8),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92D281B),
				(string)h6p9C9bOsM01G9cgjIEP(-1638402543 ^ -1638500695),
				(string)h6p9C9bOsM01G9cgjIEP(-70007027 ^ -70182571),
				(string)h6p9C9bOsM01G9cgjIEP(-643786247 ^ -643676295),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629699616),
				(string)h6p9C9bOsM01G9cgjIEP(0x6DC147B0 ^ 0x6DC3995E),
				(string)h6p9C9bOsM01G9cgjIEP(-1858887263 ^ -1859027275),
				z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F32A798),
				(string)h6p9C9bOsM01G9cgjIEP(0x68BBB53E ^ 0x68B96A5E)
			};
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static object h6p9C9bOsM01G9cgjIEP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void o29KxubOcZFj3muL8PXG(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static void JoWOZBbOzrj9GMe7B1D1(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static void eMty7mb2FWQb0NsmdQyC(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static bool HX9H8UbOLLp4RsBdXhLF()
	{
		return MMVOwAbOYTTLLANhvKWB == null;
	}

	internal static ScriptModuleManager io1cQ3bOUmgUKCMmUupy()
	{
		return MMVOwAbOYTTLLANhvKWB;
	}

	internal static object zlwxofb2BJH4XrL4sb8s(object P_0)
	{
		return ((ScriptModule)P_0).ElmaReferences;
	}

	internal static void WFdwVIb2W5xwRfl6sW7N(object P_0, object P_1)
	{
		((ScriptModule)P_0).ElmaReferences = (string)P_1;
	}

	internal static object MLJfwqb2ojd3aOY3mSco(object P_0)
	{
		return ((ScriptModule)P_0).References;
	}

	internal static object PYyjcRb2bVvcJkUti2UW(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static void MoHpFJb2hoBoL2utbG9m(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static void eCD9C1b2GHFOQib9boyC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
