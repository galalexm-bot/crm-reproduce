using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

[Serializable]
public class ConfigExportSettings
{
	[NonSerialized]
	private readonly IEnumerable<IConfigExportExtension> configExportExtensions;

	public Dictionary<Guid, object> CustomSettings;

	internal static ConfigExportSettings Y1SIBuEYClBZ3AJOJHJc;

	public ElmaStoreComponentManifest Manifest
	{
		[CompilerGenerated]
		get
		{
			return _003CManifest_003Ek__BackingField;
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
					_003CManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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

	public string IconFileName
	{
		[CompilerGenerated]
		get
		{
			return _003CIconFileName_003Ek__BackingField;
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
					_003CIconFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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

	public byte[] Icon
	{
		[CompilerGenerated]
		get
		{
			return _003CIcon_003Ek__BackingField;
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
					_003CIcon_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return _003CFileName_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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

	public ConfigExportSettings(Guid newFileName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jdLIr6EYZM6EvmBXFxp5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				PrepareConfigExportSettings(newFileName);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num = 2;
				}
				break;
			default:
				configExportExtensions = ((ComponentManager)SQTpacEYu36b8bi4QRRY()).GetExtensionPoints<IConfigExportExtension>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public ConfigExportSettings()
	{
		//Discarded unreachable code: IL_0034, IL_0039
		jdLIr6EYZM6EvmBXFxp5();
		this._002Ector(((ComponentManager)SQTpacEYu36b8bi4QRRY()).GetExtensionPoints<IConfigExportExtension>());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ConfigExportSettings(bool needNewFileName)
	{
		//Discarded unreachable code: IL_0044, IL_0049
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(needNewFileName ? KsQARWEYISTYudxTDI75() : Guid.Empty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ConfigExportSettings(IEnumerable<IConfigExportExtension> configExportExtensions)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.configExportExtensions = configExportExtensions;
		PrepareConfigExportSettings(Guid.NewGuid());
	}

	private void PrepareConfigExportSettings(Guid newFileName)
	{
		//Discarded unreachable code: IL_00d2, IL_00dc, IL_0116, IL_0120, IL_020b, IL_021e, IL_022d, IL_028b, IL_02c3
		int num = 3;
		int num2 = num;
		IEnumerator<IConfigExportExtension> enumerator = default(IEnumerator<IConfigExportExtension>);
		Dictionary<Guid, object>.Enumerator enumerator2 = default(Dictionary<Guid, object>.Enumerator);
		KeyValuePair<Guid, object> current = default(KeyValuePair<Guid, object>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				enumerator = configExportExtensions.GetEnumerator();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 6;
				}
				continue;
			case 2:
				FileName = newFileName.ToString();
				num2 = 4;
				continue;
			case 4:
				CustomSettings = new Dictionary<Guid, object>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				if (ANpdSgEYVPbtDOGlWFae(newFileName, Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 4;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!G7UsmnEYSyXdtKMySMoV(enumerator))
						{
							num3 = 2;
							goto IL_00e0;
						}
						goto IL_0238;
						IL_00e0:
						switch (num3)
						{
						case 1:
							try
							{
								while (true)
								{
									IL_01c9:
									int num4;
									if (!enumerator2.MoveNext())
									{
										num4 = 2;
										goto IL_0124;
									}
									goto IL_01a6;
									IL_0124:
									while (true)
									{
										switch (num4)
										{
										case 3:
											if (!CustomSettings.ContainsKey(current.Key))
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
												{
													num4 = 1;
												}
												continue;
											}
											goto IL_01c9;
										case 1:
											CustomSettings.Add(current.Key, current.Value);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
											{
												num4 = 0;
											}
											continue;
										case 4:
											break;
										default:
											goto IL_01c9;
										case 2:
											goto end_IL_01c9;
										}
										break;
									}
									goto IL_01a6;
									IL_01a6:
									current = enumerator2.Current;
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num4 = 3;
									}
									goto IL_0124;
									continue;
									end_IL_01c9:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
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
						case 3:
							goto IL_0238;
						case 2:
							goto end_IL_00fa;
						}
						continue;
						IL_0238:
						enumerator2 = enumerator.Current.GetNewSettingObj().GetEnumerator();
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num3 = 0;
						}
						goto IL_00e0;
						continue;
						end_IL_00fa:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								VT1iJMEYik6nG8k5u0Uf(enumerator);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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
				break;
			case 5:
				break;
			}
			CustomSettings.Where((KeyValuePair<Guid, object> p) => p.Key == BpmAppsExportConsts.ExportBpmAppsUid).ForEach(delegate(KeyValuePair<Guid, object> p)
			{
				if (p.Value is BpmAppsExportSetting bpmAppsExportSetting)
				{
					bpmAppsExportSetting.TempId = FileName;
				}
			});
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void jdLIr6EYZM6EvmBXFxp5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object SQTpacEYu36b8bi4QRRY()
	{
		return ComponentManager.Current;
	}

	internal static bool n2okBFEYvjaFvM0rj8XN()
	{
		return Y1SIBuEYClBZ3AJOJHJc == null;
	}

	internal static ConfigExportSettings hYKxZIEY8ffQ7pG09TK8()
	{
		return Y1SIBuEYClBZ3AJOJHJc;
	}

	internal static Guid KsQARWEYISTYudxTDI75()
	{
		return Guid.NewGuid();
	}

	internal static bool ANpdSgEYVPbtDOGlWFae(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool G7UsmnEYSyXdtKMySMoV(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void VT1iJMEYik6nG8k5u0Uf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
