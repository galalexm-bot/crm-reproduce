using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing.Storages;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing.Impl;

internal class LicenseManager : ILicenseManager
{
	private Guid ceUid;

	private readonly List<IActivationKeyStorage> _storages;

	private static LicenseManager sK2gpJ7sIIbXvDZrPcW;

	public void ApplyAllActivationKeys()
	{
		//Discarded unreachable code: IL_00da, IL_00e4, IL_017d, IL_018c, IL_019d, IL_01a7, IL_022e, IL_0261, IL_02b8, IL_02c7, IL_02fe, IL_0311, IL_0320, IL_0370, IL_037f, IL_041f, IL_042e, IL_0475, IL_04ad, IL_04bc, IL_0571, IL_0584, IL_0593, IL_05a2
		int num = 2;
		int num2 = num;
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		IModuleManager moduleManager = default(IModuleManager);
		Dictionary<Guid, string>.Enumerator enumerator = default(Dictionary<Guid, string>.Enumerator);
		ModuleManager moduleManager2 = default(ModuleManager);
		List<IActivationKeyStorage>.Enumerator enumerator3 = default(List<IActivationKeyStorage>.Enumerator);
		IActivationKeyStorage current3 = default(IActivationKeyStorage);
		KeyValuePair<Guid, string> current2 = default(KeyValuePair<Guid, string>);
		IEnumerator<ModuleManager.StoreComponentConfigurationInfo> enumerator2 = default(IEnumerator<ModuleManager.StoreComponentConfigurationInfo>);
		ModuleManager.StoreComponentConfigurationInfo current = default(ModuleManager.StoreComponentConfigurationInfo);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 6:
				licensedUnit = vy8mIgxW2G9BBrfXwRJ(moduleManager) as ILicensedUnit;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				moduleManager = (IModuleManager)sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				if (licensedUnit != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 3:
				enumerator = GetActivationKeys().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				return;
			case 1:
				if (moduleManager == null)
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 6;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 7;
						goto IL_00e8;
					}
					goto IL_0155;
					IL_00e8:
					while (true)
					{
						switch (num3)
						{
						case 7:
							return;
						case 3:
							break;
						case 5:
							if (moduleManager2 == null)
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 9;
						case 2:
							goto IL_0155;
						case 4:
							try
							{
								while (true)
								{
									int num7;
									if (!enumerator3.MoveNext())
									{
										num7 = 3;
										goto IL_01ab;
									}
									goto IL_01c5;
									IL_01ab:
									switch (num7)
									{
									case 2:
										break;
									default:
										continue;
									case 1:
										try
										{
											HdwJbhxE85w0bWoRBxw(current3, current2.Key, current2.Value);
											int num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
											{
												num8 = 0;
											}
											switch (num8)
											{
											case 0:
												break;
											}
										}
										catch (Exception ex)
										{
											int num9 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
											{
												num9 = 1;
											}
											while (true)
											{
												switch (num9)
												{
												case 1:
													iDQaxLxC9Ni6L1esHyh(ErPGRNxf5eu0boxBCK6(), jIm3vOxQ1Nph7dkSsDe(-70037984 ^ -70003342), ex);
													num9 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
										continue;
									case 3:
										goto end_IL_01e8;
									}
									goto IL_01c5;
									IL_01c5:
									current3 = enumerator3.Current;
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num7 = 1;
									}
									goto IL_01ab;
									continue;
									end_IL_01e8:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator3).Dispose();
								int num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
								{
									num10 = 0;
								}
								switch (num10)
								{
								case 0:
									break;
								}
							}
							break;
						case 1:
							HOACPJxoEeommuEZBwq(licensedUnit, current2.Value);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num3 = 8;
							}
							continue;
						default:
							enumerator3 = _storages.GetEnumerator();
							num3 = 4;
							continue;
						case 10:
							try
							{
								while (true)
								{
									int num4;
									if (!IF0SLoxhTL68yY2Xrq8(enumerator2))
									{
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
										{
											num4 = 0;
										}
										goto IL_038e;
									}
									goto IL_03d6;
									IL_03d6:
									current = enumerator2.Current;
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num4 = 1;
									}
									goto IL_038e;
									IL_038e:
									while (true)
									{
										switch (num4)
										{
										case 4:
										case 5:
											break;
										default:
											goto IL_03d6;
										case 1:
										{
											((ILicensedUnit)QBblr2xbjVGrH2lNhXJ(current)).ApplyActivationKey(current2.Value);
											int num5 = 4;
											num4 = num5;
											continue;
										}
										case 3:
											if (current.LicensedUnit == null)
											{
												num4 = 5;
												continue;
											}
											goto case 1;
										case 2:
											goto end_IL_03b0;
										}
										break;
									}
									continue;
									end_IL_03b0:
									break;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									int num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											HUb4Y7xG6OYhP7kZrHH(enumerator2);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
											{
												num6 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							goto default;
						case 8:
							moduleManager2 = moduleManager as ModuleManager;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num3 = 5;
							}
							continue;
						case 9:
						{
							IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedComponentInfos = moduleManager2.GetInstalledComponentInfos();
							(from p in GetActivationKeys()
								select p.Value).ToList();
							enumerator2 = installedComponentInfos.GetEnumerator();
							num3 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						}
						break;
					}
					continue;
					IL_0155:
					current2 = enumerator.Current;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num3 = 1;
					}
					goto IL_00e8;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num11 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num11 = 0;
				}
				switch (num11)
				{
				case 0:
					break;
				}
			}
		}
	}

	public string GetRegistrationKey()
	{
		//Discarded unreachable code: IL_0044, IL_0053, IL_0088
		int num = 1;
		int num2 = num;
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				return GetRegistrationKey(licensedUnit);
			case 3:
				return string.Empty;
			case 1:
				if (!PwD7utxvSNhiZg0SNmf())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = WClOgRx8woilMtmPk6w(sUquw7xBKQl5bG7C2hM(ComponentManager.Current));
				break;
			default:
				obj = null;
				break;
			case 4:
				if (licensedUnit == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 2;
			}
			licensedUnit = (ILicensedUnit)obj;
			num2 = 4;
		}
	}

	public string GetRegistrationKey(ILicensedUnit unit)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				YZELWPxZ15yP5pSwiwK(unit, jIm3vOxQ1Nph7dkSsDe(-1852837372 ^ -1852872268));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)Y0Atb8xuor24lMwISE3(unit);
			}
		}
	}

	public void CompleteLicensingInitialize()
	{
		//Discarded unreachable code: IL_007d, IL_0087
		int num = 1;
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 6:
					rNEqJpxI4xEvdq01QTm(licensedUnit);
					num2 = 5;
					continue;
				case 2:
					return;
				case 3:
					return;
				case 1:
					if (sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H()) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = vy8mIgxW2G9BBrfXwRJ(sUquw7xBKQl5bG7C2hM(ComponentManager.Current)) as ILicensedUnit;
					break;
				default:
					obj = null;
					break;
				case 4:
					if (licensedUnit == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto end_IL_0012;
				case 5:
					((ModuleManager)sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H())).UpdateModuleStatuses();
					num2 = 4;
					continue;
				case 7:
					goto end_IL_0012;
				}
				licensedUnit = (ILicensedUnit)obj;
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			QXfZpCxVUbicqIPPoep(licensedUnit);
			num = 3;
		}
	}

	public Guid AddActivationKey(string key)
	{
		IEnumerable<IStoreComponentInfo> newActivatedComponents;
		return AddActivationKey(key, out newActivatedComponents);
	}

	public Guid AddActivationKey(string key, out IEnumerable<IStoreComponentInfo> newActivatedComponents)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_00ab, IL_00bf, IL_00cd, IL_00fc, IL_010b, IL_01d3, IL_01e6, IL_01f6, IL_0204, IL_0213, IL_021e, IL_02ec, IL_0324, IL_034f, IL_035e, IL_0369, IL_03ee, IL_0401, IL_0410, IL_0456, IL_0465, IL_0470, IL_050f, IL_0522, IL_0657, IL_0666, IL_0735, IL_0744, IL_07a0, IL_0816, IL_0829
		int num = 2;
		List<IStoreComponentInfo>.Enumerator enumerator2 = default(List<IStoreComponentInfo>.Enumerator);
		IStoreComponentInfo current2 = default(IStoreComponentInfo);
		ILicenseInfo licenseInfo2 = default(ILicenseInfo);
		Dictionary<string, LicenseStatus> dictionary = default(Dictionary<string, LicenseStatus>);
		Guid guid = default(Guid);
		IEnumerator<ModuleManager.StoreComponentConfigurationInfo> enumerator3 = default(IEnumerator<ModuleManager.StoreComponentConfigurationInfo>);
		ModuleManager.StoreComponentConfigurationInfo current3 = default(ModuleManager.StoreComponentConfigurationInfo);
		ModuleManager moduleManager = default(ModuleManager);
		List<IActivationKeyStorage>.Enumerator enumerator = default(List<IActivationKeyStorage>.Enumerator);
		List<IStoreComponentInfo> list2 = default(List<IStoreComponentInfo>);
		IStoreComponentInfo current4 = default(IStoreComponentInfo);
		List<IStoreComponentInfo> list = default(List<IStoreComponentInfo>);
		LicenseStatus value = default(LicenseStatus);
		ILicenseInfo licenseInfo = default(ILicenseInfo);
		IStoreComponentInfo current = default(IStoreComponentInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 25:
					try
					{
						while (true)
						{
							IL_0181:
							int num8;
							if (!enumerator2.MoveNext())
							{
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num8 = 1;
								}
								goto IL_00d1;
							}
							goto IL_012e;
							IL_012e:
							current2 = enumerator2.Current;
							num8 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num8 = 1;
							}
							goto IL_00d1;
							IL_00d1:
							while (true)
							{
								switch (num8)
								{
								case 6:
									licenseInfo2 = current2.LicensedUnit.GetLicenseInfo();
									num8 = 4;
									continue;
								case 2:
									break;
								case 4:
									if (licenseInfo2 == null)
									{
										num8 = 5;
										continue;
									}
									goto default;
								default:
									dictionary[(string)IwtDhsxiO1SBB6i3q4u(current2)] = licenseInfo2.Status;
									num8 = 3;
									continue;
								case 3:
								case 5:
									goto IL_0181;
								case 1:
									goto end_IL_0181;
								}
								break;
							}
							goto IL_012e;
							continue;
							end_IL_0181:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 23;
				case 20:
					obj = null;
					goto IL_08c0;
				case 19:
					return guid;
				case 7:
					try
					{
						while (true)
						{
							int num10;
							if (!IF0SLoxhTL68yY2Xrq8(enumerator3))
							{
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num10 = 0;
								}
								goto IL_0222;
							}
							goto IL_028c;
							IL_028c:
							current3 = enumerator3.Current;
							num10 = 3;
							goto IL_0222;
							IL_0222:
							while (true)
							{
								switch (num10)
								{
								case 3:
									if (QBblr2xbjVGrH2lNhXJ(current3) != null)
									{
										num10 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
										{
											num10 = 2;
										}
										continue;
									}
									break;
								case 4:
									goto IL_028c;
								case 2:
									HOACPJxoEeommuEZBwq(QBblr2xbjVGrH2lNhXJ(current3), key);
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
									{
										num10 = 0;
									}
									continue;
								case 1:
									goto end_IL_0266;
								}
								break;
							}
							continue;
							end_IL_0266:
							break;
						}
					}
					finally
					{
						if (enumerator3 != null)
						{
							int num11 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num11 = 1;
							}
							while (true)
							{
								switch (num11)
								{
								case 1:
									HUb4Y7xG6OYhP7kZrHH(enumerator3);
									num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
									{
										num11 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 16;
				case 10:
				case 11:
					moduleManager = sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H()) as ModuleManager;
					num2 = 17;
					continue;
				case 15:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num3 = 1;
								}
								goto IL_036d;
							}
							goto IL_03a9;
							IL_03a9:
							HdwJbhxE85w0bWoRBxw(enumerator.Current, guid, key);
							num3 = 2;
							goto IL_036d;
							IL_036d:
							switch (num3)
							{
							case 2:
								break;
							default:
								goto IL_03a9;
							case 1:
								goto end_IL_0383;
							}
							continue;
							end_IL_0383:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 16:
				case 18:
					if (list2 == null)
					{
						num2 = 26;
						continue;
					}
					goto case 4;
				case 17:
					if (moduleManager == null)
					{
						num2 = 18;
						continue;
					}
					break;
				case 4:
					enumerator2 = list2.GetEnumerator();
					num2 = 12;
					continue;
				case 24:
					try
					{
						while (true)
						{
							IL_04a1:
							int num12;
							if (!enumerator2.MoveNext())
							{
								num12 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
								{
									num12 = 0;
								}
								goto IL_0474;
							}
							goto IL_048e;
							IL_048e:
							current4 = enumerator2.Current;
							num12 = 2;
							goto IL_0474;
							IL_0474:
							while (true)
							{
								switch (num12)
								{
								case 1:
									goto IL_048e;
								case 3:
									goto IL_04a1;
								case 2:
									Douf6RxXJCBvwCbAXCe(sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H()), current4, StoreComponentStatus.Allowed);
									num12 = 3;
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
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					goto case 8;
				case 2:
					guid = Guid.NewGuid();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					list = new List<IStoreComponentInfo>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					if (!((PackageService)EmMjTAxSivZZ8JQCJuw(GYlD3kxFsbFPaMUdH9H())).Initialized)
					{
						goto end_IL_0012;
					}
					obj = ((PackageService)EmMjTAxSivZZ8JQCJuw(ComponentManager.Current)).GetStoreComponentsInfo(forRuntime: false).Where(delegate(IStoreComponentInfo i)
					{
						//Discarded unreachable code: IL_0063, IL_0072
						int num14 = 1;
						int num15 = num14;
						while (true)
						{
							switch (num15)
							{
							case 1:
								if (_003C_003Ec.EREOElfgXOU9PMRingLw(_003C_003Ec.s1fDH1fgK9Mim2TNtwEe(i)))
								{
									num15 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
									{
										num15 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return _003C_003Ec.E6lv1wfgTFnL8rGQ46bd(i) != null;
							default:
								return false;
							}
						}
					}).ToList();
					goto IL_08c0;
				case 9:
					enumerator2 = list2.GetEnumerator();
					num2 = 25;
					continue;
				case 8:
					newActivatedComponents = list;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 12;
					}
					continue;
				case 21:
					if (list2 != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 23;
				default:
					dictionary = new Dictionary<string, LicenseStatus>();
					num2 = 13;
					continue;
				case 23:
					enumerator = _storages.GetEnumerator();
					num2 = 15;
					continue;
				case 22:
					HOACPJxoEeommuEZBwq((ILicensedUnit)vy8mIgxW2G9BBrfXwRJ(sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H())), key);
					num2 = 11;
					continue;
				case 3:
				case 26:
					enumerator2 = list.GetEnumerator();
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 24;
					}
					continue;
				case 12:
					try
					{
						while (true)
						{
							IL_06ec:
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 2;
								goto IL_0675;
							}
							goto IL_06c9;
							IL_0675:
							while (true)
							{
								switch (num5)
								{
								case 11:
									if (value == LicenseStatus.NotActivated)
									{
										int num6 = 6;
										num5 = num6;
										continue;
									}
									goto IL_06ec;
								case 1:
									break;
								default:
									goto IL_06ec;
								case 12:
									licenseInfo = (ILicenseInfo)nGqkLYxq32QCKQuKnEn(nu232ExRAPcQv67yJNh(current));
									num5 = 4;
									continue;
								case 5:
									if (EkX8LUxKQNtQEuChFTp(licenseInfo) != 0)
									{
										num5 = 8;
										continue;
									}
									goto case 10;
								case 6:
									list.Add(current);
									num5 = 3;
									continue;
								case 9:
									if (EkX8LUxKQNtQEuChFTp(licenseInfo) != LicenseStatus.NeedRestart)
									{
										num5 = 5;
										continue;
									}
									goto case 10;
								case 10:
									if (value != LicenseStatus.DateExpired)
									{
										num5 = 11;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
										{
											num5 = 10;
										}
										continue;
									}
									goto case 6;
								case 4:
									if (licenseInfo != null)
									{
										num5 = 7;
										continue;
									}
									goto IL_06ec;
								case 7:
									if (!dictionary.TryGetValue(current.Id, out value))
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 9;
								case 2:
									goto end_IL_06ec;
								}
								break;
							}
							goto IL_06c9;
							IL_06c9:
							current = enumerator2.Current;
							num5 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num5 = 12;
							}
							goto IL_0675;
							continue;
							end_IL_06ec:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 6:
					if (sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H()) != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 10;
				case 5:
					if (!(vy8mIgxW2G9BBrfXwRJ(sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H())) is ILicensedUnit))
					{
						num2 = 10;
						continue;
					}
					goto case 22;
				case 14:
					break;
					IL_08c0:
					list2 = (List<IStoreComponentInfo>)obj;
					num2 = 21;
					continue;
				}
				IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedComponentInfos = moduleManager.GetInstalledComponentInfos();
				(from p in GetActivationKeys()
					select p.Value).ToList();
				enumerator3 = installedComponentInfos.GetEnumerator();
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			num = 20;
		}
	}

	public void RemoveActivationKey(Guid keyUid)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0070, IL_00f3, IL_0106, IL_0115
		int num = 2;
		int num2 = num;
		List<IActivationKeyStorage>.Enumerator enumerator = default(List<IActivationKeyStorage>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				enumerator = _storages.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0074;
						}
						goto IL_008a;
						IL_0074:
						switch (num3)
						{
						case 2:
							return;
						case 1:
							break;
						default:
							continue;
						}
						goto IL_008a;
						IL_008a:
						OWXBksxTyfTwBKrn13t(enumerator.Current, keyUid);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num3 = 0;
						}
						goto IL_0074;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	public Dictionary<Guid, string> GetActivationKeys()
	{
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
		foreach (IActivationKeyStorage storage in _storages)
		{
			Dictionary<Guid, string> activationKeys = storage.GetActivationKeys();
			if (activationKeys == null)
			{
				continue;
			}
			foreach (KeyValuePair<Guid, string> item in activationKeys)
			{
				dictionary[item.Key] = item.Value;
			}
		}
		return dictionary;
	}

	public bool CanAddActivationKey()
	{
		return false;
	}

	public string GetActivationToken()
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_009d, IL_00b0, IL_00bf, IL_00ca, IL_018a, IL_01c2, IL_021d, IL_02b0, IL_032e, IL_0379, IL_0414, IL_0423, IL_045c, IL_0487, IL_0496, IL_0533, IL_0546, IL_0576, IL_05c9, IL_05e8, IL_05f7, IL_0624, IL_0697, IL_06b6, IL_06e2, IL_0737, IL_0756
		int num = 14;
		int num2 = num;
		byte[] activationToken = default(byte[]);
		string result = default(string);
		IEnumerator<ModuleManager.StoreComponentConfigurationInfo> enumerator = default(IEnumerator<ModuleManager.StoreComponentConfigurationInfo>);
		ActivationToken activationToken3 = default(ActivationToken);
		List<Tuple<byte[], ActivationToken>> list = default(List<Tuple<byte[], ActivationToken>>);
		byte[] item5 = default(byte[]);
		ModuleManager moduleManager = default(ModuleManager);
		MemoryStream memoryStream = default(MemoryStream);
		List<Tuple<byte[], ActivationToken>>.Enumerator enumerator2 = default(List<Tuple<byte[], ActivationToken>>.Enumerator);
		byte item = default(byte);
		ActivationToken activationToken2 = default(ActivationToken);
		byte[] buffer = default(byte[]);
		byte[] array = default(byte[]);
		byte[] item3 = default(byte[]);
		ActivationToken item2 = default(ActivationToken);
		SHA1 sHA = default(SHA1);
		IModuleManager moduleManager2 = default(IModuleManager);
		ActivationToken item4 = default(ActivationToken);
		while (true)
		{
			object obj2;
			object obj3;
			switch (num2)
			{
			case 18:
				if (activationToken != null)
				{
					num2 = 9;
					break;
				}
				goto case 17;
			case 11:
				return result;
			case 5:
				try
				{
					while (true)
					{
						IL_013e:
						int num10;
						if (!IF0SLoxhTL68yY2Xrq8(enumerator))
						{
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num10 = 0;
							}
							goto IL_00ce;
						}
						goto IL_0126;
						IL_0126:
						activationToken3 = (ActivationToken)J412SpxkiQngeR7Dpuo(enumerator.Current);
						num10 = 3;
						goto IL_00ce;
						IL_00ce:
						while (true)
						{
							switch (num10)
							{
							case 3:
								if (activationToken3 != null)
								{
									num10 = 2;
									continue;
								}
								goto IL_013e;
							case 2:
								list.Add(new Tuple<byte[], ActivationToken>(null, activationToken3));
								num10 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num10 = 4;
								}
								continue;
							case 1:
								goto IL_0126;
							case 4:
								goto IL_013e;
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
						int num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num11 = 0;
						}
						while (true)
						{
							switch (num11)
							{
							case 1:
								enumerator.Dispose();
								num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num11 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 4;
			case 8:
				list.Add(new Tuple<byte[], ActivationToken>(item5, null));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (moduleManager != null)
				{
					num2 = 6;
					break;
				}
				goto case 4;
			case 2:
				try
				{
					trMAUsxOZKiga6pwlsn(memoryStream, byte.MaxValue);
					int num3 = 6;
					while (true)
					{
						switch (num3)
						{
						case 4:
							return result;
						default:
							enumerator2 = list.GetEnumerator();
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
							{
								num3 = 1;
							}
							continue;
						case 3:
							result = MemoryHelper.ActionWithMemoryBuffer<byte, (MemoryStream, byte), string>((int)pogS9Jx31JnInfIYjlq(memoryStream) + 1, (memoryStream, item), GetActivationTokenAction);
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							try
							{
								while (true)
								{
									int num6;
									if (!enumerator2.MoveNext())
									{
										num6 = 2;
										goto IL_02be;
									}
									goto IL_042d;
									IL_02be:
									while (true)
									{
										object obj;
										int num7;
										switch (num6)
										{
										case 18:
											if (activationToken2 != null)
											{
												num6 = 6;
												continue;
											}
											goto case 16;
										case 9:
											memoryStream.WriteByte(byte.MaxValue);
											num6 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
											{
												num6 = 8;
											}
											continue;
										default:
											memoryStream.Write(buffer, 0, 4);
											num6 = 3;
											continue;
										case 16:
											obj = null;
											goto IL_04e8;
										case 1:
										case 15:
											if (array == null)
											{
												num6 = 12;
												continue;
											}
											goto case 19;
										case 4:
										case 5:
										case 11:
										case 12:
											break;
										case 13:
											array = item3;
											num6 = 8;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
											{
												num6 = 6;
											}
											continue;
										case 10:
											buffer = (byte[])f4JkSrxecLtcIQ9subs(((Array)PTGmJrx2ajRlLyFedNH(activationToken2)).Length);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
											{
												num6 = 0;
											}
											continue;
										case 3:
											qEClV3xPXiMQElSDT49(memoryStream, PTGmJrx2ajRlLyFedNH(activationToken2), 0, activationToken2.Token.Length);
											num6 = 4;
											continue;
										case 17:
											goto IL_042d;
										case 19:
											if (array.Length >= 255)
											{
												num7 = 11;
												goto IL_02ba;
											}
											goto case 7;
										case 8:
											activationToken2 = item2;
											num7 = 18;
											goto IL_02ba;
										case 7:
											trMAUsxOZKiga6pwlsn(memoryStream, (byte)array.Length);
											num6 = 14;
											continue;
										case 14:
											qEClV3xPXiMQElSDT49(memoryStream, array, 0, array.Length);
											num6 = 5;
											continue;
										case 6:
											obj = activationToken2.Token;
											goto IL_04e8;
										case 2:
											goto end_IL_038f;
											IL_04e8:
											if (obj == null)
											{
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
												{
													num6 = 1;
												}
												continue;
											}
											goto case 9;
											IL_02ba:
											num6 = num7;
											continue;
										}
										break;
									}
									continue;
									IL_042d:
									enumerator2.Current.Deconstruct(out item3, out item2);
									num6 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
									{
										num6 = 13;
									}
									goto IL_02be;
									continue;
									end_IL_038f:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
							}
							break;
						case 1:
							try
							{
								memoryStream.Seek(0L, SeekOrigin.Begin);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										item = ((byte[])g27XNDxNMBNSL1FPiHc(sHA, memoryStream))[0];
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
										{
											num4 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							finally
							{
								int num5;
								if (sHA == null)
								{
									num5 = 2;
									goto IL_05cd;
								}
								goto IL_0602;
								IL_05cd:
								switch (num5)
								{
								case 2:
									goto end_IL_05b8;
								case 1:
									goto end_IL_05b8;
								}
								goto IL_0602;
								IL_0602:
								HUb4Y7xG6OYhP7kZrHH(sHA);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num5 = 1;
								}
								goto IL_05cd;
								end_IL_05b8:;
							}
							goto case 3;
						case 6:
							trMAUsxOZKiga6pwlsn(memoryStream, 0);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num3 = 0;
							}
							continue;
						case 5:
							break;
						}
						sHA = (SHA1)N8W2rux1RbeQwfKMM25();
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num9;
					if (memoryStream == null)
					{
						num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num9 = 1;
						}
						goto IL_069b;
					}
					goto IL_06c0;
					IL_06c0:
					HUb4Y7xG6OYhP7kZrHH(memoryStream);
					num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num9 = 0;
					}
					goto IL_069b;
					IL_069b:
					switch (num9)
					{
					default:
						goto end_IL_0676;
					case 1:
						goto end_IL_0676;
					case 2:
						break;
					case 0:
						goto end_IL_0676;
					}
					goto IL_06c0;
					end_IL_0676:;
				}
			case 7:
				if (moduleManager2 != null)
				{
					num2 = 15;
					break;
				}
				goto case 16;
			case 1:
				activationToken = RSALicense.GetActivationToken(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951479718), VersionInfo.GetVersion<SR>().ToString(), new List<StoreComponentSignatureInfo>());
				num2 = 18;
				break;
			case 17:
				obj2 = null;
				goto IL_0839;
			case 14:
				if (!PwD7utxvSNhiZg0SNmf())
				{
					num2 = 13;
					break;
				}
				obj3 = sUquw7xBKQl5bG7C2hM(GYlD3kxFsbFPaMUdH9H());
				goto IL_0810;
			case 13:
				obj3 = null;
				goto IL_0810;
			case 4:
				item5 = ceUid.ToByteArray();
				num2 = 8;
				break;
			default:
				list.Add(new Tuple<byte[], ActivationToken>(null, item4));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 12;
				}
				break;
			case 16:
				return string.Empty;
			case 15:
				list = new List<Tuple<byte[], ActivationToken>>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				memoryStream = (MemoryStream)MbWq3LxnlZ5JAGm0I74();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 2;
				}
				break;
			case 12:
				moduleManager = moduleManager2 as ModuleManager;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				obj2 = new ActivationToken
				{
					Token = activationToken
				};
				goto IL_0839;
			case 6:
				{
					IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedComponentInfos = moduleManager.GetInstalledComponentInfos();
					(from p in GetActivationKeys()
						select p.Value).ToList();
					enumerator = installedComponentInfos.GetEnumerator();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 4;
					}
					break;
				}
				IL_0839:
				item4 = (ActivationToken)obj2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
				IL_0810:
				moduleManager2 = (IModuleManager)obj3;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private string GetActivationTokenAction(byte[] buffer, int offset, int length, (MemoryStream, byte) param)
	{
		(MemoryStream, byte) tuple = param;
		MemoryStream item = tuple.Item1;
		byte b = (buffer[offset] = tuple.Item2);
		item.Seek(0L, SeekOrigin.Begin);
		item.Read(buffer, offset + 1, (int)item.Length);
		return Convert.ToBase64String(buffer, offset, length);
	}

	internal LicenseManager(IEnumerable<IActivationKeyStorage> storages)
	{
		SingletonReader.JJCZtPuTvSt();
		ceUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70003264));
		_storages = new List<IActivationKeyStorage>();
		base._002Ector();
		_storages.Add(new RegistryActivationKeyStorage(Registry.LocalMachine));
		_storages.Add(new RegistryActivationKeyStorage(Registry.CurrentUser));
		if (storages != null)
		{
			_storages.AddRange(storages);
		}
	}

	private static ActivationToken GetStoreComponentToken(object info)
	{
		//Discarded unreachable code: IL_00bb, IL_0139, IL_0172, IL_0181
		int num = 13;
		byte[] activationToken2 = default(byte[]);
		IActivationTokenContainer activationTokenContainer = default(IActivationTokenContainer);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					break;
				case 3:
				case 4:
				case 8:
					return null;
				default:
					if (DHciRixaykIvh3IWfHY(oKyVDdxpJhKM8iHamVL(info)) == ElmaStoreComponentActivationType.Paid)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						activationToken2 = RSALicense.GetActivationToken((string)BgJrkaxtkbgJOLjMlPG(oKyVDdxpJhKM8iHamVL(info)), ((ElmaStoreComponentManifest)oKyVDdxpJhKM8iHamVL(info)).Version, ((ModuleManager.StoreComponentConfigurationInfo)info).Signatures);
						num2 = 10;
					}
					continue;
				case 10:
					if (activationToken2 != null)
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				case 1:
					activationTokenContainer = ((ModuleManager.StoreComponentConfigurationInfo)info).LicensedUnit as IActivationTokenContainer;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					return (ActivationToken)T0GyjlxD6foWRJh3oGP(activationTokenContainer);
				case 5:
					if (activationTokenContainer == null)
					{
						return null;
					}
					num2 = 7;
					continue;
				case 6:
					if (((ModuleManager.StoreComponentConfigurationInfo)info).Signatures.Any())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 9:
					if (((ModuleManager.StoreComponentConfigurationInfo)info).Signatures == null)
					{
						num2 = 3;
						continue;
					}
					goto case 6;
				case 11:
					return null;
				case 2:
				{
					ActivationToken activationToken = new ActivationToken();
					FWoCrAxw0LTPHaLgXsZ(activationToken, activationToken2);
					return activationToken;
				}
				case 12:
					if (oKyVDdxpJhKM8iHamVL(info) == null)
					{
						num2 = 4;
						continue;
					}
					goto case 9;
				}
				break;
			}
			YZELWPxZ15yP5pSwiwK(info, jIm3vOxQ1Nph7dkSsDe(0x5DD55050 ^ 0x5DD52516));
			num = 12;
		}
	}

	internal static object GYlD3kxFsbFPaMUdH9H()
	{
		return ComponentManager.Current;
	}

	internal static object sUquw7xBKQl5bG7C2hM(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object vy8mIgxW2G9BBrfXwRJ(object P_0)
	{
		return ((IModuleManager)P_0).MainApplication;
	}

	internal static void HOACPJxoEeommuEZBwq(object P_0, object P_1)
	{
		((ILicensedUnit)P_0).ApplyActivationKey((string)P_1);
	}

	internal static object QBblr2xbjVGrH2lNhXJ(object P_0)
	{
		return ((ModuleManager.StoreComponentConfigurationInfo)P_0).LicensedUnit;
	}

	internal static bool IF0SLoxhTL68yY2Xrq8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void HUb4Y7xG6OYhP7kZrHH(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void HdwJbhxE85w0bWoRBxw(object P_0, Guid uid, object P_2)
	{
		((IActivationKeyStorage)P_0).AddActivationKey(uid, (string)P_2);
	}

	internal static object ErPGRNxf5eu0boxBCK6()
	{
		return Logger.Log;
	}

	internal static object jIm3vOxQ1Nph7dkSsDe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void iDQaxLxC9Ni6L1esHyh(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool giG4Wv7cZn3BZMj7QEg()
	{
		return sK2gpJ7sIIbXvDZrPcW == null;
	}

	internal static LicenseManager Y4a3WM7zLV6vQ8oKtUf()
	{
		return sK2gpJ7sIIbXvDZrPcW;
	}

	internal static bool PwD7utxvSNhiZg0SNmf()
	{
		return ComponentManager.Initialized;
	}

	internal static object WClOgRx8woilMtmPk6w(object P_0)
	{
		return ((IModuleManager)P_0).MainLicensedUnit;
	}

	internal static void YZELWPxZ15yP5pSwiwK(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object Y0Atb8xuor24lMwISE3(object P_0)
	{
		return ((ILicensedUnit)P_0).GetRegistrationKey();
	}

	internal static void rNEqJpxI4xEvdq01QTm(object P_0)
	{
		((ILicensedUnit)P_0).UpdateLicenseInfo();
	}

	internal static void QXfZpCxVUbicqIPPoep(object P_0)
	{
		((ILicensedUnit)P_0).CompleteLicensingInitialize();
	}

	internal static object EmMjTAxSivZZ8JQCJuw(object P_0)
	{
		return ((ComponentManager)P_0).PackageService;
	}

	internal static object IwtDhsxiO1SBB6i3q4u(object P_0)
	{
		return ((IStoreComponentInfo)P_0).Id;
	}

	internal static object nu232ExRAPcQv67yJNh(object P_0)
	{
		return ((IStoreComponentInfo)P_0).LicensedUnit;
	}

	internal static object nGqkLYxq32QCKQuKnEn(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static LicenseStatus EkX8LUxKQNtQEuChFTp(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static void Douf6RxXJCBvwCbAXCe(object P_0, object P_1, StoreComponentStatus status)
	{
		((IModuleManager)P_0).SaveStoreComponentInfo((IStoreComponentInfo)P_1, status);
	}

	internal static void OWXBksxTyfTwBKrn13t(object P_0, Guid uid)
	{
		((IActivationKeyStorage)P_0).RemoveActivationKey(uid);
	}

	internal static object J412SpxkiQngeR7Dpuo(object P_0)
	{
		return GetStoreComponentToken(P_0);
	}

	internal static object MbWq3LxnlZ5JAGm0I74()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void trMAUsxOZKiga6pwlsn(object P_0, byte P_1)
	{
		((Stream)P_0).WriteByte(P_1);
	}

	internal static object PTGmJrx2ajRlLyFedNH(object P_0)
	{
		return ((ActivationToken)P_0).Token;
	}

	internal static object f4JkSrxecLtcIQ9subs(int P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	internal static void qEClV3xPXiMQElSDT49(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static object N8W2rux1RbeQwfKMM25()
	{
		return SHA1.Create();
	}

	internal static object g27XNDxNMBNSL1FPiHc(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static long pogS9Jx31JnInfIYjlq(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object oKyVDdxpJhKM8iHamVL(object P_0)
	{
		return ((ModuleManager.StoreComponentConfigurationInfo)P_0).Manifest;
	}

	internal static ElmaStoreComponentActivationType DHciRixaykIvh3IWfHY(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).ActivationType;
	}

	internal static object T0GyjlxD6foWRJh3oGP(object P_0)
	{
		return ((IActivationTokenContainer)P_0).GetActivationToken();
	}

	internal static object BgJrkaxtkbgJOLjMlPG(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static void FWoCrAxw0LTPHaLgXsZ(object P_0, object P_1)
	{
		((ActivationToken)P_0).Token = (byte[])P_1;
	}
}
