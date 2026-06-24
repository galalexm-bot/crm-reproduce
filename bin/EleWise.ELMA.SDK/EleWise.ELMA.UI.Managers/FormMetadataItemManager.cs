using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using AutoMapper;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Exceptions;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Managers;

public class FormMetadataItemManager : EntityManager<IFormMetadataItem, long>
{
	internal static FormMetadataItemManager TeN5LxBv5FQspupXYM0m;

	public ILockManager LockManager
	{
		[CompilerGenerated]
		get
		{
			return _003CLockManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CLockManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public FormMetadataItemHeaderManager HeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IEnumerable<IFormDependencyExtension> FormDependencyExtensions { get; set; }

	public IWorkWithFormDependeciesService WorkWithFormDependeciesService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkWithFormDependeciesService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
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
					_003CWorkWithFormDependeciesService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void Save(IFormMetadataItem obj)
	{
		//Discarded unreachable code: IL_00ae, IL_015b, IL_02ec, IL_0329, IL_0338
		int num = 12;
		FormMetadata formMetadata = default(FormMetadata);
		IFormDependencyExtension formDependencyExtension = default(IFormDependencyExtension);
		string errorMessage = default(string);
		IUser user = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					base.Save(obj);
					num = 24;
					break;
				case 3:
					if (Ma08beBvzxBqHnYHbPYp(obj) != null)
					{
						num2 = 4;
						continue;
					}
					goto case 25;
				case 10:
					return;
				case 23:
					formMetadata = (FormMetadata)obj.Metadata;
					num2 = 20;
					continue;
				case 16:
					OGRwjEB8VpeJ0dZ0P4Ky(Ma08beBvzxBqHnYHbPYp(obj), Rt7oqJB8IIR8kYbXjMxr(formMetadata));
					num2 = 15;
					continue;
				case 21:
					if (formDependencyExtension != null)
					{
						formDependencyExtension.GenerateNewDependencies(formMetadata);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 10;
					}
					continue;
				case 29:
					throw new InvalidOperationException(errorMessage);
				case 26:
					DGlLlcB8o3fRYAAJhEdT(obj, cKFB4CB8WMHnv3aBNdm4());
					num2 = 9;
					continue;
				case 22:
					lncE2kB8ZF6TkGS259MO(Ma08beBvzxBqHnYHbPYp(obj), obj);
					num2 = 2;
					continue;
				case 27:
					LOTGdAB88O4aXWK6EI6R(Ma08beBvzxBqHnYHbPYp(obj), iCi5IuB8v4xuCnkKXaua(obj));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				case 1:
					if (bOwAMVB8C67BhhNVwipK(Ma08beBvzxBqHnYHbPYp(obj)) == null)
					{
						num2 = 27;
						continue;
					}
					goto case 2;
				case 9:
					user = (IUser)vDCll7B8hiZeS1beo9US(Tf10cbB8bMMsYZcs08aR(this));
					num = 5;
					break;
				case 2:
					CR6ZyYB8uWdw8i1BiFdJ(obj.Header, tgIFZGB8BpD5EZJlXtrp(formMetadata));
					num2 = 16;
					continue;
				case 4:
				case 28:
					IBM1A5B8fCTcjrvEa63o(Ma08beBvzxBqHnYHbPYp(obj), formMetadata.Uid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					gQ0MnBBvUqfWMTCGSUPd(obj, WMT4wnBvLntouUFWrs7S(0x6A81B9B4 ^ 0x6A811A3C));
					num2 = 11;
					continue;
				case 14:
					((IFormMetadataItemHeader)Ma08beBvzxBqHnYHbPYp(obj)).IsDirtyItem = true;
					num2 = 8;
					continue;
				default:
					yAS8P8B8QritjEI3OujR(Ma08beBvzxBqHnYHbPYp(obj), y29hT7B8FsHxDTGk9Aqb(formMetadata));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				case 24:
					if (!vhwZWYB8SmB6ASnx6RK7(WorkWithFormDependeciesService))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					return;
				case 15:
					obj.Header.Description = formMetadata.Description;
					num2 = 14;
					continue;
				case 25:
					UEAdSFB8Emj9fvvsXies(obj, InterfaceActivator.Create<IFormMetadataItemHeader>());
					num2 = 28;
					continue;
				case 11:
					C8oHhiBvcMtu08xrQ1MI(VtkRN3BvsdgjsX4ggFGq(obj) != null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CBBF87));
					num2 = 23;
					continue;
				case 20:
					if (HeaderManager.ValidateName((Ma08beBvzxBqHnYHbPYp(obj) != null) ? ((IEntity<long>)Ma08beBvzxBqHnYHbPYp(obj)).Id : 0, y29hT7B8FsHxDTGk9Aqb(formMetadata), (string)tgIFZGB8BpD5EZJlXtrp(formMetadata), out errorMessage))
					{
						num2 = 19;
						continue;
					}
					goto case 18;
				case 18:
					throw new InvalidOperationException(errorMessage);
				case 19:
					if (HeaderManager.ValidateDisplayName((Ma08beBvzxBqHnYHbPYp(obj) != null) ? obj.Header.Id : 0, formMetadata.GetTypeUid(), formMetadata.DisplayName, out errorMessage))
					{
						num = 26;
						break;
					}
					goto case 29;
				case 5:
					obj.CreationAuthorId = ((user != null) ? ((long?)Id2JFbB8GLbLmtxKS4EY(user)) : null);
					num2 = 3;
					continue;
				case 7:
					((IFormMetadataItemHeader)Ma08beBvzxBqHnYHbPYp(obj)).CreationAuthorId = ((user != null) ? ((long?)Id2JFbB8GLbLmtxKS4EY(user)) : null);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 22;
					}
					continue;
				case 17:
					return;
				case 13:
					formDependencyExtension = FormDependencyExtensions.FirstOrDefault((IFormDependencyExtension q) => q is UIFormDependencyExtension);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void Publish(long headerId, string comment, bool forEmulation)
	{
		//Discarded unreachable code: IL_014d, IL_0174, IL_01c7, IL_01d6, IL_01e1, IL_02b5, IL_02ed, IL_02fc, IL_03a9, IL_03b8, IL_03c3, IL_045a, IL_046d, IL_0521, IL_0559, IL_06f6, IL_0786, IL_0835, IL_0844, IL_08c6, IL_0962, IL_09f0, IL_0ac3, IL_0b03, IL_0b12, IL_0b1e, IL_0b2d
		int num = 1;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0;
		FormMetadata formMetadata = default(FormMetadata);
		ScriptCompileResult scriptCompileResult = default(ScriptCompileResult);
		FormCodeCompiler formCodeCompiler = default(FormCodeCompiler);
		IEnumerator<ScriptCompileMessage> enumerator = default(IEnumerator<ScriptCompileMessage>);
		StringBuilder stringBuilder = default(StringBuilder);
		ScriptCompileMessage current = default(ScriptCompileMessage);
		List<EntityMetadata>.Enumerator enumerator2 = default(List<EntityMetadata>.Enumerator);
		EntityMetadata current2 = default(EntityMetadata);
		string text = default(string);
		ScriptModule scriptModule = default(ScriptModule);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		IFormMetadataItem formMetadataItem = default(IFormMetadataItem);
		ScriptModuleDTO scriptModuleDTO = default(ScriptModuleDTO);
		Guid value = default(Guid);
		long? versionNumber = default(long?);
		IFormMetadataItem formMetadataItem3 = default(IFormMetadataItem);
		long? num4 = default(long?);
		IUser currentUser = default(IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				disposable = (IDisposable)vPZkXMB8ROuLSaVLCV0u(LockManager, EwOBJ9B8iuFaNLDMOhi0(WMT4wnBvLntouUFWrs7S(0x53FA00CE ^ 0x53FAF936), headerId));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
				int num3 = 44;
				while (true)
				{
					int num6;
					long? num5;
					object obj2;
					object obj;
					switch (num3)
					{
					case 1:
						try
						{
							List<IMetadata> list = new List<IMetadata>(formMetadata.GetMetadataToRegister());
							int num7 = 4;
							while (true)
							{
								switch (num7)
								{
								case 7:
									scriptCompileResult = (ScriptCompileResult)APU31aB8T3IdbWkLO3xY(formCodeCompiler);
									num7 = 6;
									break;
								case 10:
									try
									{
										while (true)
										{
											IL_0222:
											int num8;
											if (!enumerator.MoveNext())
											{
												num8 = 3;
												goto IL_01e5;
											}
											goto IL_01ff;
											IL_01e5:
											while (true)
											{
												switch (num8)
												{
												case 1:
													break;
												default:
													goto IL_0222;
												case 2:
													uvaQwuB8ngiUZ06HIem4(stringBuilder, yAa9J9B8PwI14VYCWnc3(WMT4wnBvLntouUFWrs7S(-16752921 ^ -16735077), Rw94nbB8Os6TVw0dQamG(current), Gjmp58B82oWKbFGgw3Hb(current), IDUN9OB8e47HayMnQ5NV(current)));
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
													{
														num8 = 0;
													}
													continue;
												case 3:
													goto end_IL_0222;
												}
												break;
											}
											goto IL_01ff;
											IL_01ff:
											current = enumerator.Current;
											num8 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
											{
												num8 = 2;
											}
											goto IL_01e5;
											continue;
											end_IL_0222:
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											int num9 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
											{
												num9 = 1;
											}
											while (true)
											{
												switch (num9)
												{
												case 1:
													qLeuBWB81grtuHyUPf29(enumerator);
													num9 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
													{
														num9 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									goto case 9;
								case 4:
									enumerator2 = list.OfType<EntityMetadata>().ToList().GetEnumerator();
									num7 = 3;
									break;
								case 2:
									stringBuilder = new StringBuilder();
									num7 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num7 = 8;
									}
									break;
								case 8:
									uvaQwuB8ngiUZ06HIem4(stringBuilder, WMT4wnBvLntouUFWrs7S(-787452571 ^ -787441877));
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
									{
										num7 = 0;
									}
									break;
								case 9:
									u2mr9aB833B0jP6TNXRn(Or96HcB8NmQwVZmqnsGQ(this), stringBuilder.ToString());
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num7 = 0;
									}
									break;
								case 3:
									try
									{
										while (true)
										{
											int num10;
											if (!enumerator2.MoveNext())
											{
												num10 = 2;
												goto IL_03c7;
											}
											goto IL_041b;
											IL_03c7:
											while (true)
											{
												switch (num10)
												{
												case 3:
													AddContainedMetadata(current2, list);
													num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
													{
														num10 = 0;
													}
													continue;
												case 1:
													goto IL_041b;
												case 2:
													goto end_IL_03e1;
												}
												break;
											}
											continue;
											IL_041b:
											current2 = enumerator2.Current;
											num10 = 3;
											goto IL_03c7;
											continue;
											end_IL_03e1:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
										{
											num11 = 0;
										}
										switch (num11)
										{
										case 0:
											break;
										}
									}
									goto case 5;
								case 5:
									formCodeCompiler = new FormCodeCompiler(text, formMetadata, scriptModule);
									num7 = 7;
									break;
								case 6:
									if (!o9NfYrB8khoa8cEu3fVb(scriptCompileResult))
									{
										num7 = 2;
										break;
									}
									goto end_IL_0178;
								case 1:
									enumerator = scriptCompileResult.Messages.Where((ScriptCompileMessage m) => m.Type == ScriptCompileMessageType.Error).GetEnumerator();
									num7 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
									{
										num7 = 10;
									}
									break;
								default:
									throw new FormMetadataPublishingException(scriptCompileResult);
								}
								continue;
								end_IL_0178:
								break;
							}
						}
						finally
						{
							if (metadataServiceContext != null)
							{
								int num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num12 = 0;
								}
								while (true)
								{
									switch (num12)
									{
									default:
										qLeuBWB81grtuHyUPf29(metadataServiceContext);
										num12 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
										{
											num12 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto case 29;
					case 19:
						EqcyFaB8a32DGVATFEjx(formMetadataItem, formMetadata);
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num3 = 22;
						}
						break;
					case 17:
					case 39:
						CS_0024_003C_003E8__locals0.header.Save();
						num3 = 4;
						break;
					case 40:
						qAZY8iB8HIHDYDQB4vkn(formMetadataItem, Ci8LoMB86tsHhRqnolFC(formCodeCompiler));
						num3 = 10;
						break;
					case 31:
						if (!forEmulation)
						{
							num3 = 41;
							break;
						}
						goto case 2;
					default:
						scriptModuleDTO.Id = 0L;
						num3 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num3 = 25;
						}
						break;
					case 22:
						DGlLlcB8o3fRYAAJhEdT(formMetadataItem, cKFB4CB8WMHnv3aBNdm4());
						num6 = 5;
						goto IL_0082;
					case 36:
						text = (string)HuQrvsB8XAkVrnD4OGaW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886586947), value.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6EA043)));
						num3 = 33;
						break;
					case 26:
						formMetadataItem.VersionNumber = versionNumber;
						num3 = 38;
						break;
					case 25:
						if (scriptModuleDTO != null)
						{
							num3 = 37;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
							{
								num3 = 30;
							}
							break;
						}
						goto case 21;
					case 24:
						Po8kyQB8pGNrVaDVu3ee(formMetadataItem, value);
						num3 = 19;
						break;
					case 18:
						HsQPcLB80Y1ep2eJAN2M(Locator.GetServiceNotNull<IUnitOfWorkManager>(), (Action)delegate
						{
							int num14 = 1;
							int num15 = num14;
							while (true)
							{
								switch (num15)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									CS_0024_003C_003E8__locals0.descriptorProvider.UpdateCache(_003C_003Ec__DisplayClass17_0.uJsad1QGTSdW1bnQkj34(CS_0024_003C_003E8__locals0.header));
									num15 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
									{
										num15 = 0;
									}
									break;
								}
							}
						});
						num3 = 42;
						break;
					case 43:
						if (scriptModuleDTO != null)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 6;
							}
							break;
						}
						goto case 25;
					case 20:
						z2iCGgB84skc0msBi1mI(formMetadataItem, formCodeCompiler.AssemblyRaw);
						num3 = 40;
						break;
					case 27:
						formMetadata.GenerateNewUids();
						num3 = 34;
						break;
					case 2:
						KrgnfLB87LblAeIcU8hR(CS_0024_003C_003E8__locals0.header, formMetadataItem);
						num3 = 17;
						break;
					case 16:
						MXhPAxB8D8BlvFldc1IO(formMetadataItem, comment);
						num3 = 26;
						break;
					case 38:
						MXWbd2B8tvkXRx68VX4u(formMetadataItem, scriptModule);
						num3 = 15;
						break;
					case 11:
						formMetadataItem3 = (IFormMetadataItem)bOwAMVB8C67BhhNVwipK(CS_0024_003C_003E8__locals0.header);
						num6 = 30;
						goto IL_0082;
					case 4:
						CS_0024_003C_003E8__locals0.descriptorProvider = Locator.GetServiceNotNull<FormDescriptorProvider>();
						num3 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num3 = 23;
						}
						break;
					case 8:
						num5 = num4;
						goto IL_0a0a;
					case 28:
						CS_0024_003C_003E8__locals0.header = HeaderManager.Load(headerId);
						num3 = 11;
						break;
					case 35:
						KrgnfLB87LblAeIcU8hR(CS_0024_003C_003E8__locals0.header, null);
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num3 = 12;
						}
						break;
					case 45:
						UEAdSFB8Emj9fvvsXies(formMetadataItem, CS_0024_003C_003E8__locals0.header);
						num3 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num3 = 16;
						}
						break;
					case 15:
						YG4OF8B8wNdxSNEm2Q2T(formMetadataItem, text);
						num3 = 20;
						break;
					case 6:
						w5GQp7B8KJZpkdmSvBFN(scriptModuleDTO, Guid.NewGuid());
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num3 = 0;
						}
						break;
					case 34:
						if (P7K0JoB8qOd1WAlJcL99(formMetadataItem3) != null)
						{
							num6 = 3;
							goto IL_0082;
						}
						goto case 9;
					case 7:
						formMetadata = (FormMetadata)ClassSerializationHelper.CloneObjectByXml(VtkRN3BvsdgjsX4ggFGq(formMetadataItem3));
						num3 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num3 = 27;
						}
						break;
					case 30:
						currentUser = ((IAuthenticationService)Tf10cbB8bMMsYZcs08aR(this)).GetCurrentUser();
						num3 = 14;
						break;
					case 13:
						num4 = null;
						num3 = 8;
						break;
					case 9:
						obj2 = null;
						goto IL_0a37;
					case 33:
						metadataServiceContext = new MetadataServiceContext(new ExtendedMetadataService(Locator.GetServiceNotNull<IMetadataRuntimeService>(), formMetadata.GetMetadataToRegister()));
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num3 = 1;
						}
						break;
					case 44:
						if (!forEmulation)
						{
							num3 = 32;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num3 = 14;
							}
							break;
						}
						goto case 13;
					case 10:
						base.Session.Save((object)formMetadataItem);
						num3 = 31;
						break;
					case 12:
						CS_0024_003C_003E8__locals0.header.IsDirtyItem = false;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num3 = 39;
						}
						break;
					case 21:
						obj = null;
						goto IL_0a5a;
					case 14:
						value = Guid.NewGuid();
						num3 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num3 = 7;
						}
						break;
					case 41:
						Oh0Ds8B8ADsKTxSs8iLl(CS_0024_003C_003E8__locals0.header, formMetadataItem);
						num3 = 35;
						break;
					case 23:
						JK7RPhB8xMpUT91dvZtM(CS_0024_003C_003E8__locals0.descriptorProvider, formMetadataItem);
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num3 = 18;
						}
						break;
					case 29:
						formMetadataItem = Create();
						num3 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num3 = 14;
						}
						break;
					case 32:
						num5 = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>().GetPublishingVersionNumber(headerId);
						goto IL_0a0a;
					case 3:
						obj2 = Mapper.Map<ScriptModule, ScriptModuleDTO>(formMetadataItem3.ScriptModule, new ScriptModuleDTO());
						goto IL_0a37;
					case 37:
						obj = Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModuleDTO);
						goto IL_0a5a;
					case 5:
					{
						IFormMetadataItem formMetadataItem2 = formMetadataItem;
						long? creationAuthorId;
						if (currentUser == null)
						{
							num4 = null;
							creationAuthorId = num4;
						}
						else
						{
							creationAuthorId = (long?)Id2JFbB8GLbLmtxKS4EY(currentUser);
						}
						formMetadataItem2.CreationAuthorId = creationAuthorId;
						num3 = 45;
						break;
					}
					case 42:
						return;
						IL_0a5a:
						scriptModule = (ScriptModule)obj;
						num6 = 36;
						goto IL_0082;
						IL_0a37:
						scriptModuleDTO = (ScriptModuleDTO)obj2;
						num3 = 43;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num3 = 42;
						}
						break;
						IL_0082:
						num3 = num6;
						break;
						IL_0a0a:
						versionNumber = num5;
						num3 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num3 = 28;
						}
						break;
					}
				}
			}
			finally
			{
				int num13;
				if (disposable == null)
				{
					num13 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num13 = 0;
					}
					goto IL_0ac7;
				}
				goto IL_0add;
				IL_0add:
				disposable.Dispose();
				num13 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num13 = 2;
				}
				goto IL_0ac7;
				IL_0ac7:
				switch (num13)
				{
				case 1:
					goto end_IL_0aa2;
				case 2:
					goto end_IL_0aa2;
				}
				goto IL_0add;
				end_IL_0aa2:;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 2;
		int num2 = num;
		ExportRuleList exportRuleList = default(ExportRuleList);
		Type value = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 5:
			{
				ExportRuleList exportRuleList4 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				chFEY6B8yjqOfHhrlZF9(exportRule, value);
				ExportRule exportRule4 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)YKCTIPB8JYPZ0F3fbTsp(y2fJctB8MUFfoSGBQvPA(typeof(IFormMetadataItem).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7247AE3E));
				w3ErYBB8ryJT1vpkOteV(exportRule4, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression)XQgUKcB8ls7oCID5jLVb(parameterExpression, (MethodInfo)BksJRQB892jwWVoRx1oy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				g8o6EyB8d4T74lslREMD(exportRule, ExportRuleType.Export);
				exportRuleList4.Add(exportRule);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 2:
				value = Q0T5djB8mZjDE9n1piu7(this);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			{
				ExportRuleList exportRuleList5 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				chFEY6B8yjqOfHhrlZF9(exportRule, value);
				ExportRule exportRule5 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)YKCTIPB8JYPZ0F3fbTsp(y2fJctB8MUFfoSGBQvPA(typeof(IFormMetadataItem).TypeHandle), WMT4wnBvLntouUFWrs7S(0x269E5FCA ^ 0x269EF37E));
				exportRule5.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression)XQgUKcB8ls7oCID5jLVb(parameterExpression, (MethodInfo)BksJRQB892jwWVoRx1oy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				g8o6EyB8d4T74lslREMD(exportRule, ExportRuleType.Export);
				exportRuleList5.Add(exportRule);
				num2 = 5;
				break;
			}
			case 4:
				return exportRuleList;
			default:
			{
				ExportRuleList exportRuleList3 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				chFEY6B8yjqOfHhrlZF9(exportRule, value);
				ExportRule exportRule3 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)YKCTIPB8JYPZ0F3fbTsp(y2fJctB8MUFfoSGBQvPA(typeof(IFormMetadataItem).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477118098));
				exportRule3.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItem, object>>(Expression.Property(parameterExpression, (MethodInfo)BksJRQB892jwWVoRx1oy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				g8o6EyB8d4T74lslREMD(exportRule, ExportRuleType.Export);
				exportRuleList3.Add(exportRule);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 6;
				}
				break;
			}
			case 1:
				exportRuleList = new ExportRuleList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
			{
				ExportRuleList exportRuleList2 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				chFEY6B8yjqOfHhrlZF9(exportRule, value);
				ExportRule exportRule2 = exportRule;
				ParameterExpression parameterExpression = Expression.Parameter(y2fJctB8MUFfoSGBQvPA(typeof(IFormMetadataItem).TypeHandle), (string)WMT4wnBvLntouUFWrs7S(-672123589 ^ -672097905));
				exportRule2.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression)sTKdQVB8gAD18obJjeaX(XQgUKcB8ls7oCID5jLVb(parameterExpression, (MethodInfo)BksJRQB892jwWVoRx1oy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
				g8o6EyB8d4T74lslREMD(exportRule, ExportRuleType.Export);
				exportRuleList2.Add(exportRule);
				num2 = 4;
				break;
			}
			}
		}
	}

	private void AddContainedMetadata(EntityMetadata metadata, List<IMetadata> metadataList)
	{
		foreach (TablePartMetadata tablePart in metadata.TableParts)
		{
			metadataList.Add(tablePart);
			AddContainedMetadata(tablePart, metadataList);
		}
	}

	public FormMetadataItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Aew2n7B85VFvGCTylfOB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IVUYsKBvjTL3cMM7EZjC()
	{
		return TeN5LxBv5FQspupXYM0m == null;
	}

	internal static FormMetadataItemManager tcnGB1BvYbKg5fJNvxTq()
	{
		return TeN5LxBv5FQspupXYM0m;
	}

	internal static object WMT4wnBvLntouUFWrs7S(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gQ0MnBBvUqfWMTCGSUPd(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object VtkRN3BvsdgjsX4ggFGq(object P_0)
	{
		return ((IFormMetadataItem)P_0).Metadata;
	}

	internal static void C8oHhiBvcMtu08xrQ1MI(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object Ma08beBvzxBqHnYHbPYp(object P_0)
	{
		return ((IFormMetadataItem)P_0).Header;
	}

	internal static Guid y29hT7B8FsHxDTGk9Aqb(object P_0)
	{
		return ((FormMetadata)P_0).GetTypeUid();
	}

	internal static object tgIFZGB8BpD5EZJlXtrp(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static DateTime cKFB4CB8WMHnv3aBNdm4()
	{
		return DateTime.Now;
	}

	internal static void DGlLlcB8o3fRYAAJhEdT(object P_0, DateTime value)
	{
		((IFormMetadataItem)P_0).CreationDate = value;
	}

	internal static object Tf10cbB8bMMsYZcs08aR(object P_0)
	{
		return ((EntityManager<IFormMetadataItem, long>)P_0).AuthenticationService;
	}

	internal static object vDCll7B8hiZeS1beo9US(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object Id2JFbB8GLbLmtxKS4EY(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void UEAdSFB8Emj9fvvsXies(object P_0, object P_1)
	{
		((IFormMetadataItem)P_0).Header = (IFormMetadataItemHeader)P_1;
	}

	internal static void IBM1A5B8fCTcjrvEa63o(object P_0, Guid value)
	{
		((IFormMetadataItemHeader)P_0).Uid = value;
	}

	internal static void yAS8P8B8QritjEI3OujR(object P_0, Guid value)
	{
		((IFormMetadataItemHeader)P_0).MetadataType = value;
	}

	internal static object bOwAMVB8C67BhhNVwipK(object P_0)
	{
		return ((IFormMetadataItemHeader)P_0).Draft;
	}

	internal static DateTime iCi5IuB8v4xuCnkKXaua(object P_0)
	{
		return ((IFormMetadataItem)P_0).CreationDate;
	}

	internal static void LOTGdAB88O4aXWK6EI6R(object P_0, DateTime value)
	{
		((IFormMetadataItemHeader)P_0).CreationDate = value;
	}

	internal static void lncE2kB8ZF6TkGS259MO(object P_0, object P_1)
	{
		((IFormMetadataItemHeader)P_0).Draft = (IFormMetadataItem)P_1;
	}

	internal static void CR6ZyYB8uWdw8i1BiFdJ(object P_0, object P_1)
	{
		((IFormMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object Rt7oqJB8IIR8kYbXjMxr(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void OGRwjEB8VpeJ0dZ0P4Ky(object P_0, object P_1)
	{
		((IFormMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static bool vhwZWYB8SmB6ASnx6RK7(object P_0)
	{
		return ((IWorkWithFormDependeciesService)P_0).IsActive();
	}

	internal static object EwOBJ9B8iuFaNLDMOhi0(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object vPZkXMB8ROuLSaVLCV0u(object P_0, object P_1)
	{
		return ((ILockManager)P_0).Lock((string)P_1);
	}

	internal static object P7K0JoB8qOd1WAlJcL99(object P_0)
	{
		return ((IFormMetadataItem)P_0).ScriptModule;
	}

	internal static void w5GQp7B8KJZpkdmSvBFN(object P_0, Guid value)
	{
		((ScriptModuleDTO)P_0).Uid = value;
	}

	internal static object HuQrvsB8XAkVrnD4OGaW(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object APU31aB8T3IdbWkLO3xY(object P_0)
	{
		return ((ScriptCompiler)P_0).Compile();
	}

	internal static bool o9NfYrB8khoa8cEu3fVb(object P_0)
	{
		return ((ScriptCompileResult)P_0).Success;
	}

	internal static object uvaQwuB8ngiUZ06HIem4(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static int Rw94nbB8Os6TVw0dQamG(object P_0)
	{
		return ((ScriptCompileMessage)P_0).Line;
	}

	internal static int Gjmp58B82oWKbFGgw3Hb(object P_0)
	{
		return ((ScriptCompileMessage)P_0).Column;
	}

	internal static object IDUN9OB8e47HayMnQ5NV(object P_0)
	{
		return ((ScriptCompileMessage)P_0).Message;
	}

	internal static object yAa9J9B8PwI14VYCWnc3(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void qLeuBWB81grtuHyUPf29(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Or96HcB8NmQwVZmqnsGQ(object P_0)
	{
		return ((EntityManager<IFormMetadataItem, long>)P_0).Logger;
	}

	internal static void u2mr9aB833B0jP6TNXRn(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static void Po8kyQB8pGNrVaDVu3ee(object P_0, Guid value)
	{
		((IFormMetadataItem)P_0).Uid = value;
	}

	internal static void EqcyFaB8a32DGVATFEjx(object P_0, object P_1)
	{
		((IFormMetadataItem)P_0).Metadata = P_1;
	}

	internal static void MXhPAxB8D8BlvFldc1IO(object P_0, object P_1)
	{
		((IFormMetadataItem)P_0).Comment = (string)P_1;
	}

	internal static void MXWbd2B8tvkXRx68VX4u(object P_0, object P_1)
	{
		((IFormMetadataItem)P_0).ScriptModule = (ScriptModule)P_1;
	}

	internal static void YG4OF8B8wNdxSNEm2Q2T(object P_0, object P_1)
	{
		((IFormMetadataItem)P_0).AssemblyName = (string)P_1;
	}

	internal static void z2iCGgB84skc0msBi1mI(object P_0, object P_1)
	{
		((IFormMetadataItem)P_0).AssemblyRaw = (byte[])P_1;
	}

	internal static object Ci8LoMB86tsHhRqnolFC(object P_0)
	{
		return ((AssemblyBuilder)P_0).DebugRaw;
	}

	internal static void qAZY8iB8HIHDYDQB4vkn(object P_0, object P_1)
	{
		((IFormMetadataItem)P_0).DebugRaw = (byte[])P_1;
	}

	internal static void Oh0Ds8B8ADsKTxSs8iLl(object P_0, object P_1)
	{
		((IFormMetadataItemHeader)P_0).Published = (IFormMetadataItem)P_1;
	}

	internal static void KrgnfLB87LblAeIcU8hR(object P_0, object P_1)
	{
		((IFormMetadataItemHeader)P_0).Emulation = (IFormMetadataItem)P_1;
	}

	internal static object JK7RPhB8xMpUT91dvZtM(object P_0, object P_1)
	{
		return ((FormDescriptorProvider)P_0).CreateDescriptor((IFormMetadataItem)P_1);
	}

	internal static void HsQPcLB80Y1ep2eJAN2M(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPostCommitAction((Action)P_1);
	}

	internal static Type Q0T5djB8mZjDE9n1piu7(object P_0)
	{
		return ((EntityManager<IFormMetadataItem, long>)P_0).ImplementationType;
	}

	internal static void chFEY6B8yjqOfHhrlZF9(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static Type y2fJctB8MUFfoSGBQvPA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object YKCTIPB8JYPZ0F3fbTsp(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object BksJRQB892jwWVoRx1oy(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static void g8o6EyB8d4T74lslREMD(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static object XQgUKcB8ls7oCID5jLVb(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void w3ErYBB8ryJT1vpkOteV(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static object sTKdQVB8gAD18obJjeaX(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static void Aew2n7B85VFvGCTylfOB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
