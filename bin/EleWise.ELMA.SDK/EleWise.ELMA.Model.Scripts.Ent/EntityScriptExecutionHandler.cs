using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Scripts.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Entities;

[Component]
internal sealed class EntityScriptExecutionHandler : IScriptExecutionHandler
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IEntityScriptingService entityScriptingService;

	private readonly ViewModelDescriptor viewModelDescriptor;

	private readonly IEqlPropertiesService eqlPropertiesService;

	private readonly ISecurityService securityService;

	private static EntityScriptExecutionHandler dZLsXcbeC2r5MwH2chmp;

	public EntityScriptExecutionHandler(IMetadataRuntimeService metadataRuntimeService, IEntityScriptingService entityScriptingService, ViewModelDescriptor viewModelDescriptor, IEqlPropertiesService eqlPropertiesService, ISecurityService securityService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		w6jAIebeZ684FUVCuNAP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num = 2;
				}
				break;
			case 0:
				return;
			case 2:
				this.entityScriptingService = entityScriptingService;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 4;
				}
				break;
			case 5:
				this.viewModelDescriptor = viewModelDescriptor;
				num = 4;
				break;
			case 4:
				this.eqlPropertiesService = eqlPropertiesService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.securityService = securityService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool Check(ScriptExecutionParams parameters)
	{
		return IZS14WbeI2NDr4wYfRqr(E6I9GnbeuPq8CyMK4U8V(parameters)) == EntityMetadata.UID;
	}

	public ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters)
	{
		//Discarded unreachable code: IL_0125, IL_0134, IL_03bb, IL_03ca, IL_0458, IL_0529, IL_0533, IL_05ba, IL_05c9, IL_062e, IL_0666, IL_0675, IL_06a8, IL_06ed, IL_06f7, IL_077d, IL_0787, IL_0796, IL_07a6, IL_0862, IL_0875, IL_0884, IL_08ac, IL_0950, IL_09b2, IL_09d9, IL_09e8, IL_0a4a, IL_0a78, IL_0a87, IL_0a97, IL_0aa6, IL_0b1c, IL_0b4f, IL_0bb3, IL_0bc2
		int num = 40;
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		Type type = default(Type);
		Assembly assembly = default(Assembly);
		string text4 = default(string);
		string text2 = default(string);
		string text3 = default(string);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		string name = default(string);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		Dictionary<string, object> parameters2 = default(Dictionary<string, object>);
		Guid guid = default(Guid);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		IEnumerator<PropertyViewInfo> enumerator = default(IEnumerator<PropertyViewInfo>);
		PropertyViewInfo current2 = default(PropertyViewInfo);
		TypeSettings typeSettings = default(TypeSettings);
		string text = default(string);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		Guid current = default(Guid);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 9:
				case 11:
				case 58:
					if (dataClassMetadata != null)
					{
						num2 = 6;
						continue;
					}
					goto case 24;
				case 44:
					type = PUAAhfbeeKKtKEIF3sjN(assembly, text4);
					num2 = 64;
					continue;
				case 50:
					text4 = (string)Ybg2N0be25He7QUh9mx5(text2, hRZTpqbeX2sKkA4251Ed(-1852837372 ^ -1852850726), text3, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345245200));
					num = 44;
					break;
				case 28:
					if (!((string)Wx30LibeNVorWTHWn1PD(_003C_003Ec__DisplayClass7_.parameters) == (string)hRZTpqbeX2sKkA4251Ed(--1418440330 ^ 0x548B6930)))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 23;
				case 12:
					if (_003C_003Ec__DisplayClass7_.entity == null)
					{
						num2 = 35;
						continue;
					}
					goto case 55;
				case 34:
					_003C_003Ec__DisplayClass7_.viewModelType = assembly.GetType(name);
					num2 = 57;
					continue;
				case 39:
					_003C_003Ec__DisplayClass7_.parameters = parameters;
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 21;
					}
					continue;
				case 1:
					if (string.IsNullOrWhiteSpace(entityMetadata2.ScriptModuleTypeName))
					{
						num = 4;
						break;
					}
					obj2 = YjkXBSbeOkMWIQ2E5WKw(((IEnumerable<string>)PxWjELbenwiKRDZr48Lb(l5vEAJbekrDThQ1aM9gr(entityMetadata2), new char[1] { ',' })).First());
					goto IL_0c63;
				case 20:
					dataClassMetadata = entityMetadata.ViewModelMetadata;
					num2 = 37;
					continue;
				case 49:
					if (sfq9AUbeihqNIP3L7Eo9(entityMetadata.BaseClassUid, Guid.Empty))
					{
						num2 = 11;
						continue;
					}
					goto case 56;
				case 38:
					entityMetadata = entityMetadata2;
					num2 = 62;
					continue;
				case 18:
					_003C_003Ec__DisplayClass7_.entity = null;
					num2 = 63;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 61;
					}
					continue;
				case 24:
					KuXJ8MbeaSwr7ErTLOEU(securityService, new Action(_003C_003Ec__DisplayClass7_._003CExecuteScript_003Eb__0));
					num = 14;
					break;
				case 17:
					scriptMethodInfo = (ScriptMethodInfo)Ssu2QebeDH795uoexbLS(Wx30LibeNVorWTHWn1PD(_003C_003Ec__DisplayClass7_.parameters));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 48;
					}
					continue;
				case 8:
				case 14:
				case 22:
				case 47:
					parameters2 = new Dictionary<string, object>();
					num2 = 45;
					continue;
				case 7:
					wudbcDbe44WlK28cpVUW(scriptMethodInfo, guid);
					num2 = 5;
					continue;
				case 29:
					if (!((string)X6MOBbbewpuuhnnUkBha(scriptMethodInfo)).Contains((string)hRZTpqbeX2sKkA4251Ed(0x4EDCBA32 ^ 0x4EDC7994)))
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				case 37:
					entityMetadata2 = entityMetadata;
					num2 = 9;
					continue;
				case 27:
					_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 18;
					}
					continue;
				case 21:
					_003C_003Ec__DisplayClass7_.viewModelContext = DeserializeViewModelContext(_003C_003Ec__DisplayClass7_.parameters.Model, dataClassMetadata, type) as DataClass;
					num2 = 61;
					continue;
				case 41:
					_003C_003Ec__DisplayClass7_.item = null;
					num2 = 59;
					continue;
				case 40:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 28;
					}
					continue;
				case 60:
					entityMetadata3 = null;
					num = 38;
					break;
				case 2:
					name = text2 + (string)hRZTpqbeX2sKkA4251Ed(0x1637C429 ^ 0x163524BB);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 34;
					}
					continue;
				case 3:
					obj = sJuVPJbeTUgb3HNtnsHa(entityMetadata2);
					goto IL_0c76;
				case 6:
					assembly = (Assembly)DXlKdjbeq86rgHLF2cNg(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785768B), false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 42:
					guid = dT3wWebeVOBJrfBmh8h1(E6I9GnbeuPq8CyMK4U8V(_003C_003Ec__DisplayClass7_.parameters));
					num2 = 53;
					continue;
				case 13:
				case 15:
					if (entityMetadata.ImplementedExtensionUids != null)
					{
						num2 = 51;
						continue;
					}
					goto case 49;
				default:
					_003C_003Ec__DisplayClass7_.viewModelContext = null;
					num2 = 42;
					continue;
				case 45:
					_003C_003Ec__DisplayClass7_.propertyContainer = null;
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 10;
					}
					continue;
				case 35:
				case 54:
				{
					ScriptExecutionResult obj3 = new ScriptExecutionResult
					{
						Model = _003C_003Ec__DisplayClass7_.viewModelContext,
						Item = _003C_003Ec__DisplayClass7_.item
					};
					B9wSI0beyLlY7y6ibQ7x(obj3, _003C_003Ec__DisplayClass7_.propertyContainer);
					return obj3;
				}
				case 19:
					try
					{
						while (true)
						{
							IL_058f:
							int num7;
							if (!hUDML3be0wCqvPYROjVT(enumerator))
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num7 = 0;
								}
								goto IL_0537;
							}
							goto IL_05f5;
							IL_05f5:
							current2 = enumerator.Current;
							num7 = 2;
							goto IL_0537;
							IL_0537:
							while (true)
							{
								switch (num7)
								{
								case 2:
									typeSettings = (TypeSettings)Fxc9OCbe7KcXqJ5v1mJm(_003C_003Ec__DisplayClass7_.entity, boRhECbeAdoPADLWP18N(current2));
									num7 = 6;
									continue;
								case 1:
									r3VBC0bex4RREowiKJgw(current2, typeSettings);
									num7 = 4;
									continue;
								case 4:
								case 5:
									goto IL_058f;
								case 6:
									if (typeSettings == null)
									{
										num7 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
										{
											num7 = 3;
										}
										continue;
									}
									goto case 1;
								case 3:
									goto IL_05f5;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num8 = 0;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									zrDNP1bem4oed9U8BfUB(enumerator);
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
									{
										num8 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 35;
				case 10:
					dataClassMetadata = (DataClassMetadata)RMTrLAbeSBLE0MrPwiRp(entityMetadata2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 60;
					}
					continue;
				case 63:
					_003C_003Ec__DisplayClass7_.viewModelType = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 52:
					text = (string)N4L7Z1be6ebpUQkrtXjw(scriptMethodInfo);
					num2 = 41;
					continue;
				case 36:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 8;
								goto IL_06fb;
							}
							goto IL_07fd;
							IL_06fb:
							while (true)
							{
								object obj4;
								switch (num5)
								{
								case 6:
									dataClassMetadata = (DataClassMetadata)RMTrLAbeSBLE0MrPwiRp(entityMetadata3);
									num5 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num5 = 5;
									}
									continue;
								case 3:
									if (entityMetadata3 != null)
									{
										num5 = 4;
										continue;
									}
									goto case 2;
								case 2:
									obj4 = null;
									goto IL_0827;
								case 5:
									goto end_IL_072d;
								case 1:
									entityMetadata3 = metadataRuntimeService.GetMetadata(current, loadImplementation: false) as EntityMetadata;
									num5 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num5 = 3;
									}
									continue;
								case 9:
									entityMetadata2 = entityMetadata;
									num5 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
									{
										num5 = 0;
									}
									continue;
								case 7:
									goto IL_07fd;
								case 4:
									obj4 = entityMetadata3.ViewModelMetadata;
									goto IL_0827;
								case 8:
									goto end_IL_072d;
									IL_0827:
									if (obj4 != null)
									{
										num5 = 6;
										continue;
									}
									break;
								}
								break;
							}
							continue;
							IL_07fd:
							current = enumerator2.Current;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num5 = 0;
							}
							goto IL_06fb;
							continue;
							end_IL_072d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 49;
				case 51:
					enumerator2 = entityMetadata.ImplementedExtensionUids.GetEnumerator();
					num2 = 36;
					continue;
				case 32:
					_003C_003Ec__DisplayClass7_.entity = _003C_003Ec__DisplayClass7_.viewModelContext.GetObject(MU94oBbep3dJlV0iDPrg(dataClassMetadata), MU94oBbep3dJlV0iDPrg(propertyMetadata)) as IEntity;
					num2 = 8;
					continue;
				case 48:
					if (!sfq9AUbeihqNIP3L7Eo9(pIFbYYbet5mOjnGlCGmK(scriptMethodInfo), Guid.Empty))
					{
						num2 = 52;
						continue;
					}
					goto case 29;
				case 56:
					entityMetadata = (EntityMetadata)metadataRuntimeService.GetMetadata(qR5XKkbeRpAxGQYOEkYj(entityMetadata));
					num2 = 31;
					continue;
				case 30:
				case 62:
					if (dataClassMetadata == null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 9;
				case 64:
					if (!vf2vi1bePyl37SekLM73(type, null))
					{
						num = 47;
						break;
					}
					goto case 21;
				case 4:
					obj2 = (string)zZrv90beKZTNRZlONPyE(entityMetadata2) + (string)hRZTpqbeX2sKkA4251Ed(-16752921 ^ -16597349) + (string)sJuVPJbeTUgb3HNtnsHa(entityMetadata2) + (string)hRZTpqbeX2sKkA4251Ed(-1638402543 ^ -1638488817);
					goto IL_0c63;
				case 26:
					enumerator = _003C_003Ec__DisplayClass7_.propertyContainer.GetAll().GetEnumerator();
					num2 = 19;
					continue;
				case 61:
					if (UWT8S3be1ylFNG7Ksg1n(_003C_003Ec__DisplayClass7_.viewModelContext, null))
					{
						num2 = 43;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 8;
				case 31:
					if (RMTrLAbeSBLE0MrPwiRp(entityMetadata) != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 30;
				case 53:
					_003C_003Ec__DisplayClass7_.entityType = metadataRuntimeService.GetTypeByUid(guid);
					num2 = 25;
					continue;
				case 57:
					if (!(_003C_003Ec__DisplayClass7_.viewModelType != null))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 33;
				case 59:
					try
					{
						entityScriptingService.ExecuteScript(_003C_003Ec__DisplayClass7_.entity, text, parameters2, _003C_003Ec__DisplayClass7_._003CExecuteScript_003Eb__1);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								throw;
							}
							((ILogger)vLjRGhbeHBK8L8l7hA74()).Error(SR.T((string)hRZTpqbeX2sKkA4251Ed(-195614443 ^ -195704385), text), exception);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num4 = 1;
							}
						}
					}
					goto case 12;
				case 33:
					if (entityMetadata3 != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 3;
				case 25:
					entityMetadata2 = (EntityMetadata)metadataRuntimeService.GetMetadata(guid);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 10;
					}
					continue;
				case 55:
					if (_003C_003Ec__DisplayClass7_.propertyContainer != null)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 35;
				case 16:
					obj = entityMetadata3.Name;
					goto IL_0c76;
				case 43:
					eqlPropertiesService.SetEqlComputedProperties(_003C_003Ec__DisplayClass7_.viewModelContext, dataClassMetadata, _003C_003Ec__DisplayClass7_.parameters.AdditionalModels.Select(delegate(SerializedModel s)
					{
						SerializedModel serializedModel = new SerializedModel();
						_003C_003Ec.AusFvPCpJ6alvjPG4D8u(serializedModel, _003C_003Ec.iSyVVQCpMqhq1mdevheF(s));
						serializedModel.Name = (string)_003C_003Ec.neX6oRCp9qGhb7qyR3Ye(s);
						return serializedModel;
					}).ToList());
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 22;
					}
					continue;
				case 23:
				{
					ScriptExecutionResult scriptExecutionResult = new ScriptExecutionResult();
					j052GTbe3s1DHMB3dGRb(scriptExecutionResult, _003C_003Ec__DisplayClass7_.viewModelContext);
					return scriptExecutionResult;
				}
				case 46:
					{
						propertyMetadata = dataClassMetadata.Properties.Find((PropertyMetadata a) => _003C_003Ec.DILvFACplK3Lll1qyryR(_003C_003Ec.bHMJtTCpdQvhkjiYJTt8(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210743921)));
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 32;
						}
						continue;
					}
					IL_0c63:
					text2 = (string)obj2;
					num2 = 2;
					continue;
					IL_0c76:
					text3 = (string)obj;
					num2 = 50;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 47;
					}
					continue;
				}
				break;
			}
		}
	}

	private object DeserializeViewModelContext(string model, DataClassMetadata viewModelContextMetadata, Type viewModelContextType)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		ExpandoObject value = default(ExpandoObject);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				KuXJ8MbeaSwr7ErTLOEU(securityService, new Action(_003C_003Ec__DisplayClass8_._003CDeserializeViewModelContext_003Eb__0));
				num2 = 9;
				break;
			case 1:
				_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				return _003C_003Ec__DisplayClass8_.functionRequest.Parameter;
			case 3:
				_003C_003Ec__DisplayClass8_.requestMetadata = new ClassMetadata();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass8_.dict = new Dictionary<string, object> { 
				{
					(string)hRZTpqbeX2sKkA4251Ed(-1088304168 ^ -1088195926),
					value
				} };
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 8;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass8_.functionRequest = (IActionExecutionParamModel)Activator.CreateInstance(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				type = Gp0YxEbeMWyLbEekJt4x(typeof(ActionExecutionParamModel<>).TypeHandle).MakeGenericType(viewModelContextType);
				num2 = 5;
				break;
			default:
				value = new JsonSerializer().Deserialize<ExpandoObject>(model);
				num2 = 4;
				break;
			case 7:
				_003C_003Ec__DisplayClass8_.paramPropertyMetadata = new PropertyMetadata
				{
					Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576053546),
					TypeUid = y65TL6beJVNIfpHNjocR(viewModelDescriptor),
					SubTypeUid = MU94oBbep3dJlV0iDPrg(viewModelContextMetadata),
					Settings = new DataClassSettings
					{
						RelationType = RelationType.OneToOne
					}
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static object ProcessLegacySignature(Type type, object form, out PropertyViewInfoContainer propertyContainer)
	{
		int num = 1;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return uhxSNZbe9JGtFvTb62pt(type, new object[3] { form, classMetadata, propertyContainer });
			case 1:
				classMetadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				propertyContainer = new PropertyViewInfoContainer(classMetadata);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static object ProcessV2Signature(Type type, object form, Type viewModelType, object viewModelContext, out PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_00e4, IL_00f3, IL_016f
		int num = 7;
		ClassMetadata classMetadata = default(ClassMetadata);
		Type baseType = default(Type);
		object obj = default(object);
		Type type2 = default(Type);
		PropertyInfo property = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (LgjVJcbelqtEwqRebb4w(viewModelContext, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 0;
						}
						break;
					}
					classMetadata = MetadataLoader.LoadMetadata(baseType.GetGenericArguments()[0]) as ClassMetadata;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					propertyContainer = null;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					return null;
				case 10:
					if (!FM6F1AbedCoJfIIofaUZ(type, viewModelType))
					{
						num2 = 8;
						break;
					}
					goto case 15;
				case 11:
					if (CheckParameterType(baseType))
					{
						num2 = 14;
						break;
					}
					goto default;
				default:
					return null;
				case 6:
					baseType = type.BaseType;
					num2 = 13;
					break;
				case 13:
					if (FM6F1AbedCoJfIIofaUZ(baseType, null))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 11;
				case 2:
					if (obj != null)
					{
						return DWU3CcberL2FgDdqTpZL(type, obj, form, classMetadata, propertyContainer);
					}
					num2 = 4;
					break;
				case 9:
					obj = ((DataClass)viewModelContext).As(type2);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 2;
					}
					break;
				case 15:
					return DWU3CcberL2FgDdqTpZL(type, viewModelContext, form, classMetadata, propertyContainer);
				case 8:
					property = type.GetProperty((string)hRZTpqbeX2sKkA4251Ed(-195614443 ^ -195597039), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					num2 = 12;
					break;
				case 12:
					if (!xEFXVlbegr7bSoMRtsaX(property, null))
					{
						return null;
					}
					goto end_IL_0012;
				case 5:
					type2 = vklIKCbe5tYVvIde0UNc(property);
					num2 = 9;
					break;
				case 1:
					propertyContainer = new PropertyViewInfoContainer(classMetadata);
					num2 = 10;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private static bool CheckParameterType(Type parameterType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return parameterType.GetGenericTypeDefinition() == Gp0YxEbeMWyLbEekJt4x(typeof(FormViewBuilder<>).TypeHandle);
			case 1:
				if (!parameterType.IsGenericType)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static object CreateViewModelInstance(Type viewModelType, object viewModelContext, object form, object formItemMetadata, object propertyContainer)
	{
		return DWMGGAbejBq6JBdq7nl1(Array.Find(viewModelType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), (ConstructorInfo ctorInfo) => ctorInfo.GetParameters().Length == 4), new object[4] { viewModelContext, form, formItemMetadata, propertyContainer });
	}

	internal static void w6jAIebeZ684FUVCuNAP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GmHx5LbevZ2gb5WBA09a()
	{
		return dZLsXcbeC2r5MwH2chmp == null;
	}

	internal static EntityScriptExecutionHandler A8J2UAbe8UNFnPJ7eZP7()
	{
		return dZLsXcbeC2r5MwH2chmp;
	}

	internal static object E6I9GnbeuPq8CyMK4U8V(object P_0)
	{
		return ((ScriptExecutionParams)P_0).ModelInfo;
	}

	internal static Guid IZS14WbeI2NDr4wYfRqr(object P_0)
	{
		return ((ModelInfo)P_0).TypeUid;
	}

	internal static Guid dT3wWebeVOBJrfBmh8h1(object P_0)
	{
		return ((ModelInfo)P_0).SubTypeUid;
	}

	internal static object RMTrLAbeSBLE0MrPwiRp(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static bool sfq9AUbeihqNIP3L7Eo9(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid qR5XKkbeRpAxGQYOEkYj(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object DXlKdjbeq86rgHLF2cNg(object P_0, bool isFullName)
	{
		return ComponentManager.FindLoadedAssembly((string)P_0, isFullName);
	}

	internal static object zZrv90beKZTNRZlONPyE(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static object hRZTpqbeX2sKkA4251Ed(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sJuVPJbeTUgb3HNtnsHa(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object l5vEAJbekrDThQ1aM9gr(object P_0)
	{
		return ((ClassMetadata)P_0).ScriptModuleTypeName;
	}

	internal static object PxWjELbenwiKRDZr48Lb(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object YjkXBSbeOkMWIQ2E5WKw(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object Ybg2N0be25He7QUh9mx5(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static Type PUAAhfbeeKKtKEIF3sjN(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool vf2vi1bePyl37SekLM73(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool UWT8S3be1ylFNG7Ksg1n(object P_0, object P_1)
	{
		return (DataClass)P_0 != (DataClass)P_1;
	}

	internal static object Wx30LibeNVorWTHWn1PD(object P_0)
	{
		return ((ScriptExecutionParams)P_0).ScriptName;
	}

	internal static void j052GTbe3s1DHMB3dGRb(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).Model = P_1;
	}

	internal static Guid MU94oBbep3dJlV0iDPrg(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void KuXJ8MbeaSwr7ErTLOEU(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegiesAndWithDeleted((Action)P_1);
	}

	internal static object Ssu2QebeDH795uoexbLS(object P_0)
	{
		return ScriptMethodInfoHelper.Deserialize((string)P_0);
	}

	internal static Guid pIFbYYbet5mOjnGlCGmK(object P_0)
	{
		return ((ScriptMethodInfo)P_0).MetadataUid;
	}

	internal static object X6MOBbbewpuuhnnUkBha(object P_0)
	{
		return ((ScriptMethodInfo)P_0).Name;
	}

	internal static void wudbcDbe44WlK28cpVUW(object P_0, Guid value)
	{
		((ScriptMethodInfo)P_0).MetadataUid = value;
	}

	internal static object N4L7Z1be6ebpUQkrtXjw(object P_0)
	{
		return ScriptMethodInfoHelper.Serialize((ScriptMethodInfo)P_0);
	}

	internal static object vLjRGhbeHBK8L8l7hA74()
	{
		return Logger.Log;
	}

	internal static Guid boRhECbeAdoPADLWP18N(object P_0)
	{
		return ((PropertyViewInfo)P_0).Uid;
	}

	internal static object Fxc9OCbe7KcXqJ5v1mJm(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).LoadPropertyInstanceSettings(propertyUid);
	}

	internal static void r3VBC0bex4RREowiKJgw(object P_0, object P_1)
	{
		((PropertyViewInfo)P_0).Settings = (TypeSettings)P_1;
	}

	internal static bool hUDML3be0wCqvPYROjVT(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void zrDNP1bem4oed9U8BfUB(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void B9wSI0beyLlY7y6ibQ7x(object P_0, object P_1)
	{
		((ScriptExecutionResult)P_0).PropertyContainer = (PropertyViewInfoContainer)P_1;
	}

	internal static Type Gp0YxEbeMWyLbEekJt4x(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid y65TL6beJVNIfpHNjocR(object P_0)
	{
		return ((TypeDescriptor)P_0).Uid;
	}

	internal static object uhxSNZbe9JGtFvTb62pt(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static bool FM6F1AbedCoJfIIofaUZ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool LgjVJcbelqtEwqRebb4w(object P_0, object P_1)
	{
		return (DataClass)P_0 == (DataClass)P_1;
	}

	internal static object DWU3CcberL2FgDdqTpZL(Type viewModelType, object P_1, object P_2, object P_3, object P_4)
	{
		return CreateViewModelInstance(viewModelType, P_1, P_2, P_3, P_4);
	}

	internal static bool xEFXVlbegr7bSoMRtsaX(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Type vklIKCbe5tYVvIde0UNc(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object DWMGGAbejBq6JBdq7nl1(object P_0, object P_1)
	{
		return ((ConstructorInfo)P_0).Invoke((object[])P_1);
	}
}
