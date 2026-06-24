using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Services;

[Service]
internal class ExportRulesService : IExportRulesService
{
	internal static ExportRulesService bTFpH0E7CgRJ59lFjq95;

	public virtual ExportRuleList BaseMerge(IEntity entity, ExportRuleList customRules)
	{
		//Discarded unreachable code: IL_00af, IL_00be, IL_00c9, IL_0221, IL_0234, IL_0264, IL_0273
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		Type type = default(Type);
		ExportRuleList exportRuleList = default(ExportRuleList);
		List<ExportRule>.Enumerator enumerator = default(List<ExportRule>.Enumerator);
		_003C_003Ec__DisplayClass0_1 _003C_003Ec__DisplayClass0_2 = default(_003C_003Ec__DisplayClass0_1);
		EntityMetadata metadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 6;
				break;
			case 8:
				if (entity == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					break;
				}
				type = entity.GetType();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				return exportRuleList;
			case 1:
				return exportRuleList;
			case 12:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num3 = 2;
							}
							goto IL_00cd;
						}
						goto IL_01d4;
						IL_01d4:
						_003C_003Ec__DisplayClass0_2 = new _003C_003Ec__DisplayClass0_1();
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num3 = 4;
						}
						goto IL_00cd;
						IL_00cd:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return exportRuleList;
							case 6:
							{
								ExportRuleList exportRuleList2 = exportRuleList;
								ExportRule exportRule = new ExportRule();
								HZ4sx2E7uqcJY8oCG1Am(exportRule, type);
								exportRule.PropertyName = (string)FDtUDwE7IqBI8Ty5HckG(_003C_003Ec__DisplayClass0_2.customRule);
								jmRtbgE7SAhYU2oqrl7B(exportRule, oAa9Z8E7VGS5BeVH5Akg(_003C_003Ec__DisplayClass0_2.customRule));
								exportRuleList2.Add(exportRule);
								num3 = 3;
								continue;
							}
							case 5:
								exportRuleList.ForEach(_003C_003Ec__DisplayClass0_2._003CBaseMerge_003Eb__2);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								if (!exportRuleList.Any(_003C_003Ec__DisplayClass0_2._003CBaseMerge_003Eb__3))
								{
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num3 = 4;
									}
									continue;
								}
								break;
							case 4:
								_003C_003Ec__DisplayClass0_2.customRule = enumerator.Current;
								num3 = 5;
								continue;
							case 3:
								break;
							default:
								goto IL_01d4;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 6:
				exportRuleList = new ExportRuleList();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				exportRuleList.AddRange((IEnumerable<ExportRule>)YIQAYsE7ZhOQL28F4hHD(this, entity));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 4;
				}
				break;
			default:
				enumerator = customRules.Where(_003C_003Ec__DisplayClass0_._003CBaseMerge_003Eb__1).ToList().GetEnumerator();
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass0_.legalTypes.Add(type);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				metadata = InterfaceActivator.LoadMetadata(type) as EntityMetadata;
				num2 = 10;
				break;
			case 9:
				if (_003C_003Ec__DisplayClass0_.legalTypes.Contains(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 10:
				_003C_003Ec__DisplayClass0_.legalTypes = (from m in MetadataLoader.GetBaseClasses(metadata)
					select Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(_003C_003Ec.VNeR1b8ayjIhycPPhffe(m))).ToList();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public virtual ExportRuleList Base(IEntity entity)
	{
		//Discarded unreachable code: IL_019e, IL_01ad, IL_01d1, IL_01e0, IL_024c, IL_027a, IL_0289, IL_0406, IL_0419, IL_0428, IL_0507, IL_051a
		int num = 8;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		ExportRuleList exportRuleList = default(ExportRuleList);
		List<ClassMetadata> baseClasses = default(List<ClassMetadata>);
		List<ClassMetadata>.Enumerator enumerator = default(List<ClassMetadata>.Enumerator);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		_003C_003Ec__DisplayClass1_1 _003C_003Ec__DisplayClass1_2 = default(_003C_003Ec__DisplayClass1_1);
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<ExportRule>.Enumerator enumerator2 = default(List<ExportRule>.Enumerator);
		_003C_003Ec__DisplayClass1_2 _003C_003Ec__DisplayClass1_3 = default(_003C_003Ec__DisplayClass1_2);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					_003C_003Ec__DisplayClass1_.legalTypes.Add(_003C_003Ec__DisplayClass1_.entityType);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					return exportRuleList;
				case 1:
					break;
				case 10:
					if (!_003C_003Ec__DisplayClass1_.legalTypes.Contains(_003C_003Ec__DisplayClass1_.entityType))
					{
						num2 = 12;
						continue;
					}
					goto case 2;
				case 8:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					crAfeBE7igs3iqm2k82a(baseClasses);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					enumerator = baseClasses.GetEnumerator();
					num2 = 4;
					continue;
				case 14:
					if (entity != null)
					{
						_003C_003Ec__DisplayClass1_.entityType = entity.GetType();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 5:
					baseClasses = MetadataLoader.GetBaseClasses(entityMetadata2);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					if (baseClasses.Contains(entityMetadata2))
					{
						num2 = 15;
						continue;
					}
					goto case 11;
				case 11:
					baseClasses.Add(entityMetadata2);
					num2 = 13;
					continue;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num3 = 1;
								}
								goto IL_01ef;
							}
							goto IL_046b;
							IL_046b:
							ClassMetadata current = enumerator.Current;
							_003C_003Ec__DisplayClass1_2 = new _003C_003Ec__DisplayClass1_1();
							_003C_003Ec__DisplayClass1_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass1_;
							entityMetadata = current as EntityMetadata;
							num3 = 5;
							goto IL_01ef;
							IL_01ef:
							while (true)
							{
								object obj;
								int num4;
								switch (num3)
								{
								case 3:
									break;
								default:
									obj = sp0FSmE7qnIBguNdtbtq(_003C_003Ec__DisplayClass1_2.baseType);
									goto IL_04aa;
								case 5:
									_003C_003Ec__DisplayClass1_2.baseType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.Uid);
									num3 = 4;
									continue;
								case 2:
									try
									{
										while (true)
										{
											IL_0313:
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
												{
													num5 = 0;
												}
												goto IL_0298;
											}
											goto IL_0339;
											IL_0339:
											_003C_003Ec__DisplayClass1_3 = new _003C_003Ec__DisplayClass1_2();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
											{
												num5 = 4;
											}
											goto IL_0298;
											IL_0298:
											while (true)
											{
												switch (num5)
												{
												case 1:
												{
													ExportRuleList exportRuleList2 = exportRuleList;
													ExportRule obj2 = new ExportRule
													{
														ParentType = _003C_003Ec__DisplayClass1_3.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.entityType
													};
													jLEUG2E7XdoHhxeAGOyo(obj2, FDtUDwE7IqBI8Ty5HckG(_003C_003Ec__DisplayClass1_3.baseRule));
													jmRtbgE7SAhYU2oqrl7B(obj2, oAa9Z8E7VGS5BeVH5Akg(_003C_003Ec__DisplayClass1_3.baseRule));
													exportRuleList2.Add(obj2);
													num5 = 2;
													continue;
												}
												case 2:
													goto IL_0313;
												case 5:
													goto IL_0339;
												case 6:
													if (!exportRuleList.Any(_003C_003Ec__DisplayClass1_3._003CBase_003Eb__3))
													{
														num5 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
														{
															num5 = 0;
														}
														continue;
													}
													goto IL_0313;
												case 4:
													_003C_003Ec__DisplayClass1_3.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass1_2;
													num5 = 7;
													continue;
												case 7:
												{
													_003C_003Ec__DisplayClass1_3.baseRule = enumerator2.Current;
													int num6 = 3;
													num5 = num6;
													continue;
												}
												case 3:
													exportRuleList.ForEach(_003C_003Ec__DisplayClass1_3._003CBase_003Eb__2);
													num5 = 6;
													continue;
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
										((IDisposable)enumerator2).Dispose();
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									break;
								case 4:
									if (z8pDreE7RPgeUCnqTK29(InterfaceActivator.LoadMetadata(_003C_003Ec__DisplayClass1_2.baseType, inherit: false) as EntityMetadata) != EntityMetadataType.InterfaceImplementation)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
										{
											num3 = 0;
										}
										continue;
									}
									obj = ModelHelper.GetEntityManagerOrNull(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.ImplementationUid, loadImplementation: false));
									goto IL_04aa;
								case 6:
									goto IL_046b;
								case 1:
									{
										return exportRuleList;
									}
									IL_04aa:
									enumerator2 = ((IEnumerable<ExportRule>)EGFbJaE7KY3VZRah1efr(obj)).Where(_003C_003Ec__DisplayClass1_2._003CBase_003Eb__1).ToList().GetEnumerator();
									num4 = 2;
									num3 = num4;
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
				case 3:
					return exportRuleList;
				case 7:
					exportRuleList = new ExportRuleList();
					num2 = 14;
					continue;
				case 13:
				case 15:
					_003C_003Ec__DisplayClass1_.legalTypes = baseClasses.Select((ClassMetadata m) => Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(_003C_003Ec.VNeR1b8ayjIhycPPhffe(m))).ToList();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
			entityMetadata2 = InterfaceActivator.LoadMetadata(_003C_003Ec__DisplayClass1_.entityType) as EntityMetadata;
			num = 5;
		}
	}

	public ExportRulesService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object YIQAYsE7ZhOQL28F4hHD(object P_0, object P_1)
	{
		return ((ExportRulesService)P_0).Base((IEntity)P_1);
	}

	internal static void HZ4sx2E7uqcJY8oCG1Am(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static object FDtUDwE7IqBI8Ty5HckG(object P_0)
	{
		return ((ExportRule)P_0).PropertyName;
	}

	internal static ExportRuleType oAa9Z8E7VGS5BeVH5Akg(object P_0)
	{
		return ((ExportRule)P_0).ExportRuleType;
	}

	internal static void jmRtbgE7SAhYU2oqrl7B(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static bool qr77R0E7vaiUuHY70Pgj()
	{
		return bTFpH0E7CgRJ59lFjq95 == null;
	}

	internal static ExportRulesService hByjqAE78am1uN81AGNr()
	{
		return bTFpH0E7CgRJ59lFjq95;
	}

	internal static void crAfeBE7igs3iqm2k82a(object P_0)
	{
		((List<ClassMetadata>)P_0).Reverse();
	}

	internal static EntityMetadataType z8pDreE7RPgeUCnqTK29(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static object sp0FSmE7qnIBguNdtbtq(Type entityType)
	{
		return ModelHelper.GetEntityManagerOrNull(entityType);
	}

	internal static object EGFbJaE7KY3VZRah1efr(object P_0)
	{
		return ((IEntityManager)P_0).ExportRules();
	}

	internal static void jLEUG2E7XdoHhxeAGOyo(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}
}
