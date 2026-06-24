using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.DTO.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.BPMApps;

[Component(Order = 100)]
public class SecurityBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportOrgStructUid;

	private static readonly Guid _exportUserGroupUid;

	private static SecurityBAConverter hlKB8Pz3btMpldlOOaZ;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_00a5, IL_015a, IL_02ad, IL_02b7, IL_031f, IL_03e4, IL_03f7, IL_0432, IL_0441, IL_0452, IL_0461, IL_046c, IL_049b, IL_0589, IL_059c, IL_0604, IL_0613, IL_065a, IL_0669
		int num = 10;
		SecurityExportSetting securityExportSetting = default(SecurityExportSetting);
		SecurityBAChapter securityBAChapter = default(SecurityBAChapter);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		object value = default(object);
		List<long>.Enumerator enumerator = default(List<long>.Enumerator);
		Guid current2 = default(Guid);
		Dictionary<Guid, UserGroupDTO> dictionary2 = default(Dictionary<Guid, UserGroupDTO>);
		UserGroupDTO value3 = default(UserGroupDTO);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		long current = default(long);
		Dictionary<long, UserGroupDTO> dictionary = default(Dictionary<long, UserGroupDTO>);
		UserGroupDTO value2 = default(UserGroupDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					return;
				case 31:
					if (securityExportSetting.UserGroupsIds == null)
					{
						num2 = 27;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 6;
				case 4:
					xYjrB2pkXLZth9qIpgac(bpmAppManifest, securityBAChapter);
					num2 = 25;
					continue;
				case 10:
					Contract.ArgumentNotNull(bpmAppManifest, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A57533));
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
					{
						num2 = 8;
					}
					continue;
				case 1:
					enumerator2 = securityExportSetting.UserGroupsUids.GetEnumerator();
					num2 = 8;
					continue;
				case 3:
					bpmAppManifest.SetFlag(_exportUserGroupUid, Kxu9Hsz1DYfXXch8qPB(securityExportSetting));
					num = 30;
					break;
				case 29:
					return;
				case 22:
					KdPiwszfoES7tmxMnlG(bpmAppManifest, _exportOrgStructUid, MAL8fgz9eYa5gSqe8fJ(securityExportSetting));
					num2 = 3;
					continue;
				case 26:
					if (FslRoxpkWZqbm9FvVjXE(securityBAChapter.UserGroups) <= 0)
					{
						num2 = 15;
						continue;
					}
					goto case 4;
				case 30:
				{
					SecurityBAChapter securityBAChapter2 = new SecurityBAChapter();
					Lt0cKkzzOpQq2plQ6iT(securityBAChapter2, SecurityExportConsts.ExportExtensionUid);
					securityBAChapter = securityBAChapter2;
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
					{
						num2 = 19;
					}
					continue;
				}
				case 16:
					uRZPjMpkk9JJVidf8MuK(securityBAChapter, true);
					num2 = 14;
					continue;
				case 28:
					if (settings.CustomSettings.TryGetValue(SecurityExportConsts.ExportExtensionUid, out value))
					{
						num2 = 7;
						continue;
					}
					return;
				case 27:
					if (securityExportSetting.UserGroupsUids != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 21;
				case 12:
				case 13:
					if (securityExportSetting.UserGroupsUids == null)
					{
						num2 = 24;
						continue;
					}
					goto case 1;
				case 15:
					return;
				case 25:
					return;
				case 20:
					enumerator = securityExportSetting.UserGroupsIds.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					Contract.ArgumentNotNull(settings, (string)iTV6aVzSroEuYT4FRbP(0x1869C442 ^ 0x1868E764));
					num2 = 28;
					continue;
				case 11:
					if (securityBAChapter.UserGroups == null)
					{
						num2 = 17;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 26;
				case 8:
					try
					{
						while (true)
						{
							IL_02f4:
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
								{
									num5 = 2;
								}
								goto IL_02bb;
							}
							goto IL_02e1;
							IL_02e1:
							current2 = enumerator2.Current;
							num5 = 6;
							goto IL_02bb;
							IL_02bb:
							while (true)
							{
								switch (num5)
								{
								case 4:
									break;
								default:
									goto IL_02f4;
								case 6:
									if (!dictionary2.TryGetValue(current2, out value3))
									{
										num5 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 3;
								case 3:
									if (hashSet.Add(ik8EfLpkpLpwgXxPwBHr(value3)))
									{
										num5 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
										{
											num5 = 1;
										}
										continue;
									}
									goto IL_02f4;
								case 1:
								{
									List<UserGroupBAItem> userGroups2 = securityBAChapter.UserGroups;
									UserGroupBAItem userGroupBAItem2 = new UserGroupBAItem();
									IRvcJcpk5fJB8llDhmEx(userGroupBAItem2, ik8EfLpkpLpwgXxPwBHr(value3));
									userGroups2.Add(userGroupBAItem2);
									num5 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
									{
										num5 = 5;
									}
									continue;
								}
								case 2:
									goto end_IL_02f4;
								}
								break;
							}
							goto IL_02e1;
							continue;
							end_IL_02f4:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 21;
				case 21:
				case 24:
					if (!mQJ5iHpkAqbg2T4eppHk(securityBAChapter))
					{
						num2 = 11;
						continue;
					}
					goto case 4;
				case 19:
					if (MAL8fgz9eYa5gSqe8fJ(securityExportSetting))
					{
						num2 = 16;
						continue;
					}
					goto case 14;
				default:
					try
					{
						while (true)
						{
							IL_0537:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
								{
									num3 = 2;
								}
								goto IL_0470;
							}
							goto IL_04bf;
							IL_04bf:
							current = enumerator.Current;
							num3 = 4;
							goto IL_0470;
							IL_0470:
							while (true)
							{
								switch (num3)
								{
								case 4:
									if (dictionary.TryGetValue(current, out value2))
									{
										num3 = 5;
										continue;
									}
									goto IL_0537;
								case 3:
								{
									List<UserGroupBAItem> userGroups = securityBAChapter.UserGroups;
									UserGroupBAItem userGroupBAItem = new UserGroupBAItem();
									IRvcJcpk5fJB8llDhmEx(userGroupBAItem, value2.Uid);
									userGroups.Add(userGroupBAItem);
									num3 = 3;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
									{
										num3 = 6;
									}
									continue;
								}
								case 5:
									if (!hashSet.Add(ik8EfLpkpLpwgXxPwBHr(value2)))
									{
										num3 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 3;
								case 1:
								case 6:
									goto IL_0537;
								case 2:
									goto end_IL_0537;
								}
								break;
							}
							goto IL_04bf;
							continue;
							end_IL_0537:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 12;
				case 32:
					if (securityExportSetting == null)
					{
						return;
					}
					num = 22;
					break;
				case 23:
					if (Kxu9Hsz1DYfXXch8qPB(securityExportSetting))
					{
						num2 = 31;
						continue;
					}
					goto case 21;
				case 2:
					return;
				case 7:
					securityExportSetting = value as SecurityExportSetting;
					num2 = 32;
					continue;
				case 18:
					if (securityExportSetting.UserGroupsIds == null)
					{
						num2 = 12;
						continue;
					}
					goto case 20;
				case 14:
					securityBAChapter.UserGroups = new List<UserGroupBAItem>();
					num2 = 23;
					continue;
				case 5:
					hashSet = new HashSet<Guid>();
					num2 = 18;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
					{
						num2 = 17;
					}
					continue;
				case 6:
				{
					ICollection<UserGroupDTO> source = Locator.GetServiceNotNull<IUserGroupDTOManager>().FindAll();
					dictionary = source.ToDictionary((UserGroupDTO g) => g.Id, (UserGroupDTO g) => g);
					dictionary2 = source.ToDictionary((UserGroupDTO g) => _003C_003Ec.GFOP07poSkfB5iK4fcWC(g));
					num2 = 5;
					continue;
				}
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_0061, IL_0146, IL_0155, IL_0160, IL_0254, IL_0267, IL_0276
		int num = 12;
		SecurityExportSetting securityExportSetting = default(SecurityExportSetting);
		SecurityBAChapter securityBAChapter = default(SecurityBAChapter);
		List<UserGroupBAItem>.Enumerator enumerator = default(List<UserGroupBAItem>.Enumerator);
		UserGroupBAItem current = default(UserGroupBAItem);
		UserGroupDTO value = default(UserGroupDTO);
		Dictionary<Guid, UserGroupDTO> dictionary = default(Dictionary<Guid, UserGroupDTO>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					eY6lRKpknwFi7VfmBIfA(bpmAppManifest, iTV6aVzSroEuYT4FRbP(-1801396866 ^ -1801322888));
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					return;
				case 3:
					securityExportSetting.UserGroupsUids = new List<Guid>();
					num2 = 6;
					continue;
				default:
					securityBAChapter = bpmAppManifest.GetChapter(SecurityExportConsts.ExportExtensionUid) as SecurityBAChapter;
					num = 10;
					break;
				case 2:
					keMxxSpk7aOHNCjsU0Wc(securityExportSetting, OPyKbxpkiQ6vo2cGAUQ3(bpmAppManifest, _exportUserGroupUid, securityExportSetting.ExportUserGroups));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					securityExportSetting.UserGroupsIds = new List<long>();
					num = 3;
					break;
				case 9:
					securityExportSetting = new SecurityExportSetting();
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num2 = 13;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_0202:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
								{
									num3 = 2;
								}
								goto IL_0164;
							}
							goto IL_0186;
							IL_0186:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
							{
								num3 = 0;
							}
							goto IL_0164;
							IL_0164:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 4:
									securityExportSetting.UserGroupsIds.Add(value.Id);
									num3 = 5;
									continue;
								case 5:
									securityExportSetting.UserGroupsUids.Add(ik8EfLpkpLpwgXxPwBHr(value));
									num3 = 3;
									continue;
								default:
									if (dictionary.TryGetValue(AaOToapk6ab67WoZ3GsC(current), out value))
									{
										num3 = 4;
										continue;
									}
									goto IL_0202;
								case 3:
									goto IL_0202;
								case 2:
									goto end_IL_0202;
								}
								break;
							}
							goto IL_0186;
							continue;
							end_IL_0202:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 7:
					if (securityBAChapter.UserGroups != null)
					{
						num = 14;
						break;
					}
					goto case 4;
				case 10:
					if (securityBAChapter == null)
					{
						num2 = 15;
						continue;
					}
					goto case 7;
				case 5:
					enumerator = securityBAChapter.UserGroups.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					securityExportSetting.ExportOrgModel = OPyKbxpkiQ6vo2cGAUQ3(bpmAppManifest, _exportOrgStructUid, MAL8fgz9eYa5gSqe8fJ(securityExportSetting));
					num2 = 2;
					continue;
				case 11:
					eY6lRKpknwFi7VfmBIfA(settings, iTV6aVzSroEuYT4FRbP(0x1869C442 ^ 0x1868E764));
					num = 9;
					break;
				case 4:
				case 15:
					settings.CustomSettings[SecurityExportConsts.ExportExtensionUid] = securityExportSetting;
					num2 = 8;
					continue;
				case 6:
					dictionary = Locator.GetServiceNotNull<IUserGroupDTOManager>().FindAll().ToDictionary((UserGroupDTO g) => _003C_003Ec.GFOP07poSkfB5iK4fcWC(g), (UserGroupDTO g) => g);
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	public SecurityBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ck0p3ZpklQNyOH4I13Px();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SecurityBAConverter()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_exportOrgStructUid = new Guid((string)iTV6aVzSroEuYT4FRbP(-1518425080 ^ -1518366926));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_exportUserGroupUid = new Guid((string)iTV6aVzSroEuYT4FRbP(0x4B68CDFB ^ 0x4B69EE71));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				ck0p3ZpklQNyOH4I13Px();
				num2 = 2;
				break;
			}
		}
	}

	internal static object iTV6aVzSroEuYT4FRbP(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool MAL8fgz9eYa5gSqe8fJ(object P_0)
	{
		return ((SecurityExportSetting)P_0).ExportOrgModel;
	}

	internal static void KdPiwszfoES7tmxMnlG(object P_0, Guid P_1, bool P_2)
	{
		((BPMAppManifest)P_0).SetFlag(P_1, P_2);
	}

	internal static bool Kxu9Hsz1DYfXXch8qPB(object P_0)
	{
		return ((SecurityExportSetting)P_0).ExportUserGroups;
	}

	internal static void Lt0cKkzzOpQq2plQ6iT(object P_0, Guid P_1)
	{
		((BPMAppManifestChapter)P_0).Uid = P_1;
	}

	internal static void uRZPjMpkk9JJVidf8MuK(object P_0, bool value)
	{
		((SecurityBAChapter)P_0).ExportFullOrgstructure = value;
	}

	internal static Guid ik8EfLpkpLpwgXxPwBHr(object P_0)
	{
		return ((UserGroupDTO)P_0).Uid;
	}

	internal static void IRvcJcpk5fJB8llDhmEx(object P_0, Guid P_1)
	{
		((BPMAppManifestItem)P_0).Uid = P_1;
	}

	internal static bool mQJ5iHpkAqbg2T4eppHk(object P_0)
	{
		return ((SecurityBAChapter)P_0).ExportFullOrgstructure;
	}

	internal static int FslRoxpkWZqbm9FvVjXE(object P_0)
	{
		return ((List<UserGroupBAItem>)P_0).Count;
	}

	internal static void xYjrB2pkXLZth9qIpgac(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool BpP2rczyOyXyPLXKqh1()
	{
		return hlKB8Pz3btMpldlOOaZ == null;
	}

	internal static SecurityBAConverter E7KqmpzbEqFjZHnDqac()
	{
		return hlKB8Pz3btMpldlOOaZ;
	}

	internal static void eY6lRKpknwFi7VfmBIfA(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool OPyKbxpkiQ6vo2cGAUQ3(object P_0, Guid P_1, bool P_2)
	{
		return ((BPMAppManifest)P_0).GetFlag(P_1, P_2);
	}

	internal static void keMxxSpk7aOHNCjsU0Wc(object P_0, bool value)
	{
		((SecurityExportSetting)P_0).ExportUserGroups = value;
	}

	internal static Guid AaOToapk6ab67WoZ3GsC(object P_0)
	{
		return ((BPMAppManifestItem)P_0).Uid;
	}

	internal static void ck0p3ZpklQNyOH4I13Px()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
