using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service]
internal class ExternalMembershipManager : IExternalMembershipManager
{
	internal static ExternalMembershipManager m1UsOTwQOgFAPsNXWDT;

	public IEnumerable<IExternalMembershipModule> Modules { get; set; }

	public IExternalMembershipModule GetModule(Guid moduleUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return Modules.FirstOrDefault(_003C_003Ec__DisplayClass4_._003CGetModule_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass4_.moduleUid = moduleUid;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void SaveSettings(IExternalMembershipModuleSettings settings)
	{
		int num = 3;
		int num2 = num;
		Guid guid = default(Guid);
		IDictionary<string, string> storageValues = default(IDictionary<string, string>);
		IStoreValuesObject storeValuesObject = default(IStoreValuesObject);
		while (true)
		{
			switch (num2)
			{
			case 4:
				VMRDW9w9QDBjZI8nMSx(f9wq9Nw3E4cXcnjvjsr(), mJU4H6wbhaTRhu7mQOt(XTC3FvwygCV46EuwTB0(settings)), KJs11mwS6rfS73xfohl(guid.ToString()), ClassSerializationHelper.SerializeObjectByXml(ExternalMembershipSettingsHolder.DictionaryToHolder(storageValues)));
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				return;
			case 7:
				return;
			case 9:
				if (!X1cEjSw8kli2gvkUJ48(guid, Guid.Empty))
				{
					storageValues = storeValuesObject.GetStorageValues();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 6;
				}
				break;
			case 1:
				csw4Nvwr4NIGti32Uy0(settings, Guid.NewGuid());
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				storeValuesObject = settings;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				guid = PagxCKwgCyiTXFr9RvE(settings);
				num2 = 8;
				break;
			case 2:
				return;
			case 3:
				if (settings != null)
				{
					if (X1cEjSw8kli2gvkUJ48(PagxCKwgCyiTXFr9RvE(settings), Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				}
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (settings.Module() == null)
				{
					return;
				}
				num2 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public IExternalMembershipModuleSettings LoadSettings(Guid instanceUid)
	{
		//Discarded unreachable code: IL_0037, IL_0041, IL_013d, IL_014c, IL_01ac, IL_01bb, IL_01cb, IL_0227, IL_0285, IL_02c6, IL_02d5, IL_033f, IL_035e, IL_036d, IL_039a, IL_03a9
		int num = 2;
		int num2 = num;
		IEnumerator<IExternalMembershipModule> enumerator = default(IEnumerator<IExternalMembershipModule>);
		IExternalMembershipModule current = default(IExternalMembershipModule);
		IExternalMembershipModuleSettings result = default(IExternalMembershipModuleSettings);
		IDictionary<string, string> storageValues = default(IDictionary<string, string>);
		string value = default(string);
		IExternalMembershipModuleSettings externalMembershipModuleSettings = default(IExternalMembershipModuleSettings);
		IStoreValuesObject storeValuesObject = default(IStoreValuesObject);
		string key = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!NnI6OR2k6GwYiEWQph1(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
							{
								num3 = 1;
							}
							goto IL_0045;
						}
						goto IL_0306;
						IL_0306:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
						{
							num3 = 0;
						}
						goto IL_0045;
						IL_0045:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (current != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							default:
								try
								{
									IDictionary<string, string> allStrings = ((ISettingsManager)f9wq9Nw3E4cXcnjvjsr()).GetAllStrings(mJU4H6wbhaTRhu7mQOt(current));
									int num4 = 10;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
									{
										num4 = 4;
									}
									while (true)
									{
										int num5;
										switch (num4)
										{
										case 9:
											return result;
										case 4:
										case 8:
											storageValues = ExternalMembershipSettingsHolder.HolderToDictionary(ClassSerializationHelper.DeserializeObjectByXml<ExternalMembershipSettingsHolder>(value));
											num4 = 2;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
											{
												num4 = 11;
											}
											continue;
										case 6:
											externalMembershipModuleSettings = (IExternalMembershipModuleSettings)QvliNMwfRcyST9lcg0b(current);
											num5 = 12;
											goto IL_00b2;
										case 5:
											if (externalMembershipModuleSettings == null)
											{
												num4 = 13;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
												{
													num4 = 6;
												}
												continue;
											}
											goto case 2;
										case 12:
											storeValuesObject = externalMembershipModuleSettings;
											num4 = 5;
											continue;
										case 10:
											if (allStrings != null)
											{
												num4 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
												{
													num4 = 7;
												}
												continue;
											}
											break;
										case 1:
											break;
										case 13:
											break;
										case 7:
											if (allStrings.TryGetValue(key, out value))
											{
												num4 = 6;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
												{
													num4 = 5;
												}
												continue;
											}
											break;
										case 11:
											storeValuesObject.SetStorageValues(storageValues);
											num4 = 3;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
											{
												num4 = 3;
											}
											continue;
										case 2:
											if (storeValuesObject == null)
											{
												break;
											}
											num5 = 4;
											goto IL_00b2;
										case 3:
											result = externalMembershipModuleSettings;
											num4 = 8;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
											{
												num4 = 9;
											}
											continue;
										case 0:
											break;
											IL_00b2:
											num4 = num5;
											continue;
										}
										break;
									}
								}
								catch (Exception ex)
								{
									int num6 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
									{
										num6 = 1;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											jwnRfvwzpn2xa9iZnHK(Sof05ow1tlPfJwyogRl(), ex);
											num6 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
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
								break;
							case 2:
								break;
							case 4:
								goto IL_0306;
							case 1:
								goto end_IL_02e0;
							}
							break;
						}
						continue;
						end_IL_02e0:
						break;
					}
				}
				finally
				{
					int num7;
					if (enumerator == null)
					{
						num7 = 2;
						goto IL_0343;
					}
					goto IL_0378;
					IL_0343:
					switch (num7)
					{
					case 2:
						goto end_IL_032e;
					case 1:
						goto end_IL_032e;
					}
					goto IL_0378;
					IL_0378:
					enumerator.Dispose();
					num7 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num7 = 0;
					}
					goto IL_0343;
					end_IL_032e:;
				}
				goto default;
			case 2:
				key = instanceUid.ToString().ToLower();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				enumerator = Modules.GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	[Transaction]
	public virtual void DeleteSettings(Guid moduleUid, Guid instanceUid)
	{
		//Discarded unreachable code: IL_0058, IL_008b, IL_00cc, IL_00db
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				((ISettingsManager)f9wq9Nw3E4cXcnjvjsr()).RemoveString(moduleUid, instanceUid.ToString());
				int num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (Exception ex)
			{
				int num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						jwnRfvwzpn2xa9iZnHK(Sof05ow1tlPfJwyogRl(), ex);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public IEnumerable<IExternalMembershipModuleSettings> GetAllSettings()
	{
		List<IExternalMembershipModuleSettings> list = new List<IExternalMembershipModuleSettings>();
		foreach (IExternalMembershipModule module in Modules)
		{
			if (module == null)
			{
				continue;
			}
			try
			{
				IDictionary<string, string> allStrings = DataAccessManager.SettingsManager.GetAllStrings(module.Uid);
				if (allStrings == null)
				{
					continue;
				}
				foreach (KeyValuePair<string, string> item in allStrings)
				{
					try
					{
						IExternalMembershipModuleSettings externalMembershipModuleSettings = module.CreateDefaultSettings();
						IStoreValuesObject storeValuesObject = externalMembershipModuleSettings;
						if (externalMembershipModuleSettings != null && storeValuesObject != null)
						{
							IDictionary<string, string> storageValues = ExternalMembershipSettingsHolder.HolderToDictionary(ClassSerializationHelper.DeserializeObjectByXml<ExternalMembershipSettingsHolder>(item.Value));
							storeValuesObject.SetStorageValues(storageValues);
							list.Add(externalMembershipModuleSettings);
						}
					}
					catch (Exception message)
					{
						Logger.Log.Error(message);
					}
				}
			}
			catch (Exception message2)
			{
				Logger.Log.Error(message2);
			}
		}
		return list;
	}

	public IExternalMembershipModuleSettings CreateDefaultSettings(IExternalMembershipModule module)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException((string)k6VLB52p5rig0FyudIF(--553267277 ^ 0x20FA67B1));
			default:
				return CreateDefaultSettings(module.CreateDefaultSettings);
			case 1:
				if (module != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public IExternalMembershipModuleSettings CreateDefaultSettings(Func<IExternalMembershipModuleSettings> createDefaultSettingsFunc)
	{
		return createDefaultSettingsFunc();
	}

	public IEnumerable<IUser> FindUsers(string searchString, Guid authProviderGuid)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.authProviderGuid = authProviderGuid;
		IExternalMembershipModuleSettings externalMembershipModuleSettings = null;
		try
		{
			externalMembershipModuleSettings = GetAllSettings().FirstOrDefault((IExternalMembershipModuleSettings m) => _003C_003Ec__DisplayClass11_0.kAdN0Opu6uG5SiZbemxD(_003C_003Ec__DisplayClass11_0.aJPuXNpu7FKxJj3JJs0i(m), CS_0024_003C_003E8__locals0.authProviderGuid));
			if (externalMembershipModuleSettings != null)
			{
				return externalMembershipModuleSettings.Module().FindUsers(searchString, externalMembershipModuleSettings);
			}
		}
		catch (Exception ex)
		{
			string message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-225736894 ^ -225714354), (externalMembershipModuleSettings == null) ? "" : externalMembershipModuleSettings.Name, CS_0024_003C_003E8__locals0.authProviderGuid);
			Logger.Log.Error(message, ex);
			throw new Exception(message, ex);
		}
		string message2 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-905821499 ^ -905831751), CS_0024_003C_003E8__locals0.authProviderGuid);
		Logger.Log.Error(message2);
		throw new Exception(message2);
	}

	public string Name(Guid authProviderGuid)
	{
		//Discarded unreachable code: IL_0083, IL_00bb, IL_00ed, IL_00fc, IL_0118, IL_017e
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass12_.authProviderGuid = authProviderGuid;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				try
				{
					IExternalMembershipModuleSettings externalMembershipModuleSettings = GetAllSettings().FirstOrDefault(_003C_003Ec__DisplayClass12_._003CName_003Eb__0);
					int num3 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
					{
						num3 = 4;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							if (externalMembershipModuleSettings == null)
							{
								num3 = 3;
								continue;
							}
							goto case 1;
						case 1:
							result = (string)tPWAOc25UvQE7lr5GVN(externalMembershipModuleSettings);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							break;
						case 2:
							break;
						default:
							return result;
						case 0:
							return result;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 2:
							jwnRfvwzpn2xa9iZnHK(Logger.Log, ex);
							num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							result = string.Empty;
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			}
			break;
		}
		return string.Empty;
	}

	public Dictionary<Guid, string> GetAllName()
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.result = new Dictionary<Guid, string>();
		GetAllSettings().ForEach(delegate(IExternalMembershipModuleSettings s)
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						if (CS_0024_003C_003E8__locals0.result.ContainsKey(s.InstanceUid))
						{
							return;
						}
						goto end_IL_0012;
					case 3:
						return;
					case 1:
						if (s == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 2;
					case 4:
						CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass13_0.zpRfqYpuLpyfoPMFhsN3(s), (string)_003C_003Ec__DisplayClass13_0.imrsgppujiCVwnrL8C4e(s));
						num2 = 3;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 4;
			}
		});
		return CS_0024_003C_003E8__locals0.result;
	}

	public void Sync(IUser user, Guid authProviderGuid)
	{
		//Discarded unreachable code: IL_00b2, IL_0102, IL_0132, IL_015d, IL_0215, IL_0224
		int num = 5;
		int num2 = num;
		IExternalMembershipModuleSettings externalMembershipModuleSettings = default(IExternalMembershipModuleSettings);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		string message = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				externalMembershipModuleSettings = null;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass14_.authProviderGuid = authProviderGuid;
				num2 = 3;
				continue;
			case 6:
				((ILogger)Sof05ow1tlPfJwyogRl()).Error(message);
				num2 = 2;
				continue;
			case 1:
				try
				{
					externalMembershipModuleSettings = GetAllSettings().FirstOrDefault(_003C_003Ec__DisplayClass14_._003CSync_003Eb__0);
					int num3 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 3:
							cllDH92AT9eINAEr5GL(XTC3FvwygCV46EuwTB0(externalMembershipModuleSettings), user, externalMembershipModuleSettings);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							return;
						case 2:
							if (externalMembershipModuleSettings == null)
							{
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 3;
						case 1:
							break;
						case 4:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							dZe0qt2Xtba0pyLy45H(Logger.Log, text, ex);
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
							{
								num4 = 2;
							}
							break;
						case 1:
							text = (string)QtKJq12WiXHqPcOj6Xi(k6VLB52p5rig0FyudIF(0xD946FDB ^ 0xD9437D7), new object[2]
							{
								(externalMembershipModuleSettings == null) ? "" : tPWAOc25UvQE7lr5GVN(externalMembershipModuleSettings),
								_003C_003Ec__DisplayClass14_.authProviderGuid
							});
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							throw new Exception(text, ex);
						}
					}
				}
				break;
			case 2:
				throw new Exception(message);
			case 5:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 4;
				continue;
			}
			message = (string)QtKJq12WiXHqPcOj6Xi(k6VLB52p5rig0FyudIF(0x7A093321 ^ 0x7A096B5D), new object[1] { _003C_003Ec__DisplayClass14_.authProviderGuid });
			num2 = 6;
		}
	}

	public void ValidateUser(UserValidationContext validationContext, Guid authProviderGuid)
	{
		//Discarded unreachable code: IL_008f, IL_0139, IL_0148, IL_0158, IL_0183, IL_023d, IL_0322, IL_0331
		int num = 9;
		int num2 = num;
		string message = default(string);
		IExternalMembershipModuleSettings externalMembershipModuleSettings = default(IExternalMembershipModuleSettings);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				((ILogger)Sof05ow1tlPfJwyogRl()).Error(message);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
				{
					num2 = 5;
				}
				break;
			case 7:
				return;
			case 5:
				validationContext.Error = new Exception(message);
				num2 = 7;
				break;
			case 10:
				try
				{
					externalMembershipModuleSettings = GetAllSettings().FirstOrDefault(_003C_003Ec__DisplayClass15_._003CValidateUser_003Eb__0);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 4:
							teWLgI2ivbD7KNt6exT(validationContext, JWO7SZ2nHY2dABZmaP1(XTC3FvwygCV46EuwTB0(externalMembershipModuleSettings), validationContext, externalMembershipModuleSettings));
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
							{
								num3 = 1;
							}
							continue;
						default:
							if (externalMembershipModuleSettings == null)
							{
								int num4 = 2;
								num3 = num4;
								continue;
							}
							goto case 4;
						case 2:
							break;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 2:
							oxggh027a4xD21Arsh9(validationContext, new Exception(text, ex));
							num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
							{
								num5 = 0;
							}
							continue;
						case 3:
							dZe0qt2Xtba0pyLy45H(Sof05ow1tlPfJwyogRl(), text, ex);
							num5 = 2;
							continue;
						case 1:
							text = (string)QtKJq12WiXHqPcOj6Xi(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1869C442 ^ 0x18699C4E), new object[2]
							{
								(externalMembershipModuleSettings == null) ? "" : tPWAOc25UvQE7lr5GVN(externalMembershipModuleSettings),
								_003C_003Ec__DisplayClass15_.authProviderGuid
							});
							num5 = 3;
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 11;
			case 8:
				_003C_003Ec__DisplayClass15_.authProviderGuid = authProviderGuid;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
				{
					num2 = 8;
				}
				break;
			case 2:
				return;
			case 4:
				return;
			case 6:
				externalMembershipModuleSettings = null;
				num2 = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
				{
					num2 = 8;
				}
				break;
			case 11:
				message = (string)QtKJq12WiXHqPcOj6Xi(k6VLB52p5rig0FyudIF(-236222459 ^ -236203911), new object[1] { _003C_003Ec__DisplayClass15_.authProviderGuid });
				num2 = 3;
				break;
			case 1:
				if (validationContext.Authorized)
				{
					return;
				}
				num2 = 6;
				break;
			default:
				if (validationContext == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public ExternalMembershipManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SyZhKA26Z1s2vlJu4le();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CLy2iewdnnmv52F1eO4()
	{
		return m1UsOTwQOgFAPsNXWDT == null;
	}

	internal static ExternalMembershipManager TWQKKOwTQ7texd6g1k7()
	{
		return m1UsOTwQOgFAPsNXWDT;
	}

	internal static Guid PagxCKwgCyiTXFr9RvE(object P_0)
	{
		return ((IExternalMembershipModuleSettings)P_0).InstanceUid;
	}

	internal static bool X1cEjSw8kli2gvkUJ48(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void csw4Nvwr4NIGti32Uy0(object P_0, Guid P_1)
	{
		((IExternalMembershipModuleSettings)P_0).InstanceUid = P_1;
	}

	internal static object f9wq9Nw3E4cXcnjvjsr()
	{
		return DataAccessManager.SettingsManager;
	}

	internal static object XTC3FvwygCV46EuwTB0(object P_0)
	{
		return ((IExternalMembershipModuleSettings)P_0).Module();
	}

	internal static Guid mJU4H6wbhaTRhu7mQOt(object P_0)
	{
		return ((IExternalMembershipModule)P_0).Uid;
	}

	internal static object KJs11mwS6rfS73xfohl(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static void VMRDW9w9QDBjZI8nMSx(object P_0, Guid P_1, object P_2, object P_3)
	{
		((ISettingsManager)P_0).SetString(P_1, (string)P_2, (string)P_3);
	}

	internal static object QvliNMwfRcyST9lcg0b(object P_0)
	{
		return ((IExternalMembershipModule)P_0).CreateDefaultSettings();
	}

	internal static object Sof05ow1tlPfJwyogRl()
	{
		return Logger.Log;
	}

	internal static void jwnRfvwzpn2xa9iZnHK(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool NnI6OR2k6GwYiEWQph1(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object k6VLB52p5rig0FyudIF(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object tPWAOc25UvQE7lr5GVN(object P_0)
	{
		return ((IExternalMembershipModuleSettings)P_0).Name;
	}

	internal static void cllDH92AT9eINAEr5GL(object P_0, object P_1, object P_2)
	{
		((IExternalMembershipModule)P_0).Sync((IUser)P_1, (IExternalMembershipModuleSettings)P_2);
	}

	internal static object QtKJq12WiXHqPcOj6Xi(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void dZe0qt2Xtba0pyLy45H(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool JWO7SZ2nHY2dABZmaP1(object P_0, object P_1, object P_2)
	{
		return ((IExternalMembershipModule)P_0).ValidateUser((UserValidationContext)P_1, (IExternalMembershipModuleSettings)P_2);
	}

	internal static void teWLgI2ivbD7KNt6exT(object P_0, bool P_1)
	{
		((UserValidationContext)P_0).Authorized = P_1;
	}

	internal static void oxggh027a4xD21Arsh9(object P_0, object P_1)
	{
		((UserValidationContext)P_0).Error = (Exception)P_1;
	}

	internal static void SyZhKA26Z1s2vlJu4le()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
