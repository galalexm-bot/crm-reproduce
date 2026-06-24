using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates;

[Service]
public class TemplateLoader : IInitHandler
{
	private static readonly Guid Guid;

	private string templatesPath;

	private Dictionary<string, TemplateFileInfo> dictTemplateFileInfo;

	private FileSystemWatcher _watcher;

	private static TemplateLoader m1LAkrB1er5EgvSjNrlP;

	public static TemplateLoader Instance => Locator.GetService<TemplateLoader>();

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
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

	public IEnumerable<ITemplateDataSource> DataSources { get; set; }

	public IBLOBDataManager BlobManager
	{
		[CompilerGenerated]
		get
		{
			return _003CBlobManager_003Ek__BackingField;
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
					_003CBlobManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void Init()
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
				dictTemplateFileInfo = new Dictionary<string, TemplateFileInfo>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void InitComplete()
	{
		//Discarded unreachable code: IL_005e, IL_00b8, IL_00c7
		int num = 7;
		int num2 = num;
		string directoryName = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 8:
				if (!JpuDtyB1txd4T4MeQjoi(templatesPath))
				{
					num2 = 14;
					break;
				}
				goto case 4;
			case 13:
				_watcher.Created += WatcherCreated;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				return;
			case 14:
				Directory.CreateDirectory(templatesPath);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				DoInitTemplates(forceUpdate: false);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				if (DataSources == null)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			case 12:
			{
				FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
				zW06N5B1wPOK4o0EvhCK(fileSystemWatcher, true);
				fileSystemWatcher.Path = SR.Dir;
				_watcher = fileSystemWatcher;
				num2 = 13;
				break;
			}
			case 10:
				return;
			default:
				directoryName = Path.GetDirectoryName((string)C8yuHOB1pFLGFGeqvDdw(HrscTCB13ZmRDLVJejHU(IGbQNAB1NJvigm29UoNK(RuntimeApplication))));
				num2 = 11;
				break;
			case 3:
				if (RuntimeApplication == null)
				{
					return;
				}
				num2 = 9;
				break;
			case 5:
				Xtd5VjB1484TA7tNJU8m(_watcher, new FileSystemEventHandler(WatcherCreated));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_watcher.EnableRaisingEvents = true;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (IGbQNAB1NJvigm29UoNK(RuntimeApplication) == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				templatesPath = (string)RCll9kB1D9ERqVLQQj46(directoryName, OQCUdDB1aBNU99LDT8sT(-1426094279 ^ -1426089611));
				num2 = 8;
				break;
			}
		}
	}

	protected void WatcherCreated(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_004a, IL_007e, IL_00b6, IL_00d5, IL_0112, IL_0152, IL_0161, IL_016d, IL_017c
		int num = 2;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					CallContextSessionOwner callContextSessionOwner = (CallContextSessionOwner)xw2y6OB1HyPAdd0yyXQq();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					try
					{
						DoInitTemplates(forceUpdate: true);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num5;
						if (callContextSessionOwner == null)
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num5 = 0;
							}
							goto IL_00ba;
						}
						goto IL_00df;
						IL_00df:
						((IDisposable)callContextSessionOwner).Dispose();
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num5 = 0;
						}
						goto IL_00ba;
						IL_00ba:
						switch (num5)
						{
						default:
							goto end_IL_0095;
						case 0:
							goto end_IL_0095;
						case 2:
							break;
						case 1:
							goto end_IL_0095;
						}
						goto IL_00df;
						end_IL_0095:;
					}
				}
				finally
				{
					int num6;
					if (disposable == null)
					{
						num6 = 2;
						goto IL_0116;
					}
					goto IL_012c;
					IL_0116:
					switch (num6)
					{
					default:
						goto end_IL_0101;
					case 1:
						break;
					case 2:
						goto end_IL_0101;
					case 0:
						goto end_IL_0101;
					}
					goto IL_012c;
					IL_012c:
					vIRVNVB1AEkljXABFdrY(disposable);
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num6 = 0;
					}
					goto IL_0116;
					end_IL_0101:;
				}
			case 0:
				return;
			case 2:
				disposable = (IDisposable)qcj8lPB16lF1idFQDvB9();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected string GetTemplateFileName(string name, out TemplateFileInfo fileInfo)
	{
		//Discarded unreachable code: IL_0302, IL_0311, IL_0346
		int num = 12;
		int num2 = num;
		string text2 = default(string);
		CultureInfo cultureInfo = default(CultureInfo);
		string text3 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 20:
				text2 = (string)RCll9kB1D9ERqVLQQj46(templatesPath, yA9oQTB1dKoLG5mk2et7(xerTQcB1y5ACYRZMUxkN(fileInfo), fIIOHZB1MjyIlmaxSNwP(fileInfo)));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 6;
				}
				continue;
			case 3:
				if (fileInfo != null)
				{
					num2 = 19;
					continue;
				}
				goto case 17;
			case 10:
				text2 = Path.Combine(templatesPath, (string)xerTQcB1y5ACYRZMUxkN(fileInfo) + (string)DgRBkXB1mGLjcdTryPIr(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822841062), BdTOdyB1x4FEbeeJBh3u(cultureInfo)) + (string)OQCUdDB1aBNU99LDT8sT(-583745292 ^ -583695878) + (string)fIIOHZB1MjyIlmaxSNwP(fileInfo));
				num2 = 4;
				continue;
			case 6:
			case 9:
				if (!tVupqCB19IS4LjiODWub(text2))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 5;
			case 2:
				if (!File.Exists(text2))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 4;
			case 11:
				cultureInfo = (CultureInfo)CbkLAoB17xC6OWEYlV6P();
				num2 = 7;
				continue;
			case 18:
				return "";
			case 16:
				return text2;
			case 14:
				if (cultureInfo != null)
				{
					num2 = 8;
					continue;
				}
				goto case 4;
			case 17:
				return "";
			case 19:
				text2 = string.Empty;
				num2 = 14;
				continue;
			case 15:
				text3 = (string)DgRBkXB1mGLjcdTryPIr(OQCUdDB1aBNU99LDT8sT(-210725949 ^ -210644171), name);
				num2 = 13;
				continue;
			case 22:
				if (tVupqCB19IS4LjiODWub(text2))
				{
					num2 = 9;
					continue;
				}
				goto case 20;
			case 13:
				if (!dictTemplateFileInfo.ContainsKey(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				if (!dictTemplateFileInfo.ContainsKey(text3))
				{
					num2 = 21;
					continue;
				}
				break;
			case 12:
				fileInfo = null;
				num2 = 11;
				continue;
			case 1:
				text2 = (string)RCll9kB1D9ERqVLQQj46(templatesPath, fileInfo.Name + (string)OQCUdDB1aBNU99LDT8sT(0x20261A4F ^ 0x20275B41) + (string)fIIOHZB1MjyIlmaxSNwP(fileInfo));
				num2 = 5;
				continue;
			case 5:
				if (tVupqCB19IS4LjiODWub(text2))
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 18;
			case 8:
				text2 = Path.Combine(templatesPath, (string)xerTQcB1y5ACYRZMUxkN(fileInfo) + (string)DgRBkXB1mGLjcdTryPIr(OQCUdDB1aBNU99LDT8sT(0x4D1C1EE4 ^ 0x4D1D5FE6), BdTOdyB1x4FEbeeJBh3u(cultureInfo)) + fileInfo.Extension);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				if (!xyRvRTB1Jyy2mDx1JQ8b(text2))
				{
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 19;
					}
					continue;
				}
				goto case 20;
			case 7:
				text = string.Format((string)OQCUdDB1aBNU99LDT8sT(-1837662597 ^ -1837744481), name, (cultureInfo != null && !((string)BdTOdyB1x4FEbeeJBh3u(cultureInfo)).Equals(((CultureInfo)OZoCmDB10v9CBQydfpMy()).Name, StringComparison.OrdinalIgnoreCase)) ? BdTOdyB1x4FEbeeJBh3u(cultureInfo) : string.Empty);
				num2 = 15;
				continue;
			case 21:
				return "";
			}
			fileInfo = dictTemplateFileInfo[dictTemplateFileInfo.ContainsKey(text) ? text : text3];
			num2 = 3;
		}
	}

	public void DoInitTemplates()
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
				DoInitTemplates(forceUpdate: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void DoInitTemplates(bool forceUpdate)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_00e9, IL_00f8, IL_0146, IL_0150, IL_0261, IL_0299, IL_02a8, IL_02f1, IL_0324, IL_0387, IL_0396, IL_040b, IL_0443, IL_0452
		int num = 6;
		int num2 = num;
		string text = default(string);
		IEnumerator<ITemplateDataSource> enumerator = default(IEnumerator<ITemplateDataSource>);
		IEnumerator<TemplateFileInfo> enumerator2 = default(IEnumerator<TemplateFileInfo>);
		IEnumerable<TemplateFileInfo> files = default(IEnumerable<TemplateFileInfo>);
		string key = default(string);
		TemplateFileInfo current2 = default(TemplateFileInfo);
		ITemplateDataSource current = default(ITemplateDataSource);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return;
			case 3:
				forceUpdate = kfaPUuB1lgfuktLVixjX(BlobManager.GetBLOB<string>(Guid, "EleWise.ELMA.Templates.TemplateLoader"), text);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				BlobManager.SetBLOB(Guid, "EleWise.ELMA.Templates.TemplateLoader", text);
				num2 = 8;
				break;
			case 6:
				text = VersionInfo.GetVersion<SR>().ToString();
				num2 = 5;
				break;
			case 5:
				if (forceUpdate)
				{
					num2 = 9;
					break;
				}
				goto case 3;
			case 7:
				try
				{
					while (true)
					{
						int num4;
						if (!JsoLTkB1Y36uwgLXVoiY(enumerator))
						{
							int num3 = 2;
							num4 = num3;
							goto IL_0107;
						}
						goto IL_03a1;
						IL_0107:
						while (true)
						{
							switch (num4)
							{
							case 4:
								enumerator2 = files.GetEnumerator();
								num4 = 6;
								continue;
							case 6:
								try
								{
									while (true)
									{
										IL_01fc:
										int num7;
										if (!JsoLTkB1Y36uwgLXVoiY(enumerator2))
										{
											num7 = 3;
											goto IL_0154;
										}
										goto IL_01b6;
										IL_0154:
										while (true)
										{
											switch (num7)
											{
											case 1:
												key = (string)fODHPfB1jxQqlWCKF9Bd(OQCUdDB1aBNU99LDT8sT(0x17ADCCD8 ^ 0x17AC8C3C), xerTQcB1y5ACYRZMUxkN(current2), HK5CxAB15FcK5cxHTGip(current2));
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
												{
													num7 = 0;
												}
												continue;
											case 2:
												break;
											case 4:
												CheckTemplateFileInfo(current2, forceUpdate);
												num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
												{
													num7 = 1;
												}
												continue;
											case 5:
												goto IL_01fc;
											default:
												dictTemplateFileInfo[key] = current2;
												num7 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
												{
													num7 = 5;
												}
												continue;
											case 3:
												goto end_IL_01fc;
											}
											break;
										}
										goto IL_01b6;
										IL_01b6:
										current2 = enumerator2.Current;
										num7 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
										{
											num7 = 4;
										}
										goto IL_0154;
										continue;
										end_IL_01fc:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
										{
											num8 = 0;
										}
										while (true)
										{
											switch (num8)
											{
											default:
												vIRVNVB1AEkljXABFdrY(enumerator2);
												num8 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
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
								break;
							case 3:
								try
								{
									files = current.GetFiles();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											vPZUotB1g1bUHCO9Xh4o(t6bMG2B1rk43UvZC7lf4(), DgRBkXB1mGLjcdTryPIr(OQCUdDB1aBNU99LDT8sT(-16752921 ^ -16703545), current.GetType().FullName), ex);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
											{
												num6 = 0;
											}
											continue;
										}
										break;
									}
									break;
								}
								goto case 1;
							case 5:
								goto IL_03a1;
							case 1:
								if (files != null)
								{
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num4 = 3;
									}
									continue;
								}
								break;
							case 2:
								goto end_IL_02b3;
							}
							break;
						}
						continue;
						IL_03a1:
						current = enumerator.Current;
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num4 = 3;
						}
						goto IL_0107;
						continue;
						end_IL_02b3:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								enumerator.Dispose();
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
				goto case 1;
			case 4:
			case 9:
				dictTemplateFileInfo.Clear();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!forceUpdate)
				{
					return;
				}
				num2 = 2;
				break;
			default:
				enumerator = DataSources.GetEnumerator();
				num2 = 7;
				break;
			}
		}
	}

	public string LoadTemplate(string name)
	{
		int num = 1;
		string templateFileName = default(string);
		TemplateFileInfo fileInfo = default(TemplateFileInfo);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					templateFileName = GetTemplateFileName(name, out fileInfo);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return text;
				case 6:
					ixnFHgB1sNp4S0N5D2EW(templateFileName, text, true);
					num2 = 4;
					continue;
				case 5:
					text = (string)UcIKopB1UobxuyXxm0lB(text, OQCUdDB1aBNU99LDT8sT(0x48A7E34A ^ 0x48A7F98E), fileInfo.Extension);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					if (fileInfo == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto end_IL_0012;
				default:
					if (!xyRvRTB1Jyy2mDx1JQ8b(templateFileName))
					{
						num2 = 3;
						continue;
					}
					break;
				case 2:
					break;
				}
				return "";
				continue;
				end_IL_0012:
				break;
			}
			text = (string)ewPwGwB1L8NjleXp6od0();
			num = 5;
		}
	}

	public Stream GetTemplateStream(string name)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 3;
		string templateFileName = default(string);
		TemplateFileInfo fileInfo = default(TemplateFileInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 1:
					return null;
				case 4:
					return new FileStream(templateFileName, FileMode.Open);
				default:
					if (fileInfo != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 1;
				case 2:
					if (!xyRvRTB1Jyy2mDx1JQ8b(templateFileName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			templateFileName = GetTemplateFileName(name, out fileInfo);
			num = 2;
		}
	}

	public bool LoadTemplate(string name, string path)
	{
		//Discarded unreachable code: IL_006f
		int num = 3;
		int num2 = num;
		TemplateFileInfo fileInfo = default(TemplateFileInfo);
		string templateFileName = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (fileInfo != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 3:
				templateFileName = GetTemplateFileName(name, out fileInfo);
				num2 = 2;
				break;
			case 2:
				if (!xyRvRTB1Jyy2mDx1JQ8b(templateFileName))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			default:
				return true;
			case 4:
				return false;
			case 1:
				File.Copy(templateFileName, path, overwrite: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Save(TemplateFileInfo info, string fileName)
	{
		//Discarded unreachable code: IL_0080, IL_00ee, IL_0116, IL_0135, IL_0144, IL_0171, IL_0180, IL_018f, IL_01e3, IL_021b, IL_0258, IL_0267, IL_0276, IL_02d5, IL_0336, IL_036e, IL_03a6, IL_03d6, IL_03f5, IL_0404, IL_0431, IL_0440
		int num = 1;
		int num2 = num;
		Stream manifestResourceStream = default(Stream);
		FileStream fileStream3 = default(FileStream);
		FileStream fileStream = default(FileStream);
		FileStream fileStream2 = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (xyRvRTB1Jyy2mDx1JQ8b(QICxImBNF3WOEwkV71G0(info)))
				{
					num2 = 7;
					break;
				}
				goto default;
			case 4:
				try
				{
					if (manifestResourceStream == null)
					{
						return;
					}
					int num7 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num7 = 4;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							return;
						case 4:
							if (xWLaagBNBatmWIKoXCR5(manifestResourceStream) <= 0)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num7 = 0;
								}
								continue;
							}
							break;
						case 1:
							try
							{
								manifestResourceStream.CopyTo(fileStream3);
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								int num9;
								if (fileStream3 == null)
								{
									num9 = 2;
									goto IL_011a;
								}
								goto IL_014f;
								IL_011a:
								switch (num9)
								{
								default:
									goto end_IL_0105;
								case 2:
									goto end_IL_0105;
								case 1:
									break;
								case 0:
									goto end_IL_0105;
								}
								goto IL_014f;
								IL_014f:
								vIRVNVB1AEkljXABFdrY(fileStream3);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
								{
									num9 = 0;
								}
								goto IL_011a;
								end_IL_0105:;
							}
						case 0:
							return;
						case 2:
							break;
						case 3:
							return;
						}
						fileStream3 = new FileStream(fileName, FileMode.Create);
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num7 = 1;
						}
					}
				}
				finally
				{
					if (manifestResourceStream != null)
					{
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num10 = 1;
						}
						while (true)
						{
							switch (num10)
							{
							case 1:
								vIRVNVB1AEkljXABFdrY(manifestResourceStream);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num10 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				return;
			case 7:
				manifestResourceStream = info.Assembly.GetManifestResourceStream(info.FullName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				if (!CT0IgrB1zaHLKl4H4XyR(xZW3q1B1csUalOwMWheO(info), null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				try
				{
					if (xWLaagBNBatmWIKoXCR5(fileStream) <= 0)
					{
						return;
					}
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						default:
							fileStream2 = new FileStream(fileName, FileMode.Create);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							try
							{
								fileStream.CopyTo(fileStream2);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								if (fileStream2 != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											vIRVNVB1AEkljXABFdrY(fileStream2);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						}
					}
				}
				finally
				{
					int num6;
					if (fileStream == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num6 = 1;
						}
						goto IL_03da;
					}
					goto IL_040f;
					IL_040f:
					((IDisposable)fileStream).Dispose();
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num6 = 0;
					}
					goto IL_03da;
					IL_03da:
					switch (num6)
					{
					default:
						goto end_IL_03b5;
					case 1:
						goto end_IL_03b5;
					case 2:
						break;
					case 0:
						goto end_IL_03b5;
					}
					goto IL_040f;
					end_IL_03b5:;
				}
			default:
				if (tVupqCB19IS4LjiODWub(QICxImBNF3WOEwkV71G0(info)))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 8;
					}
					break;
				}
				return;
			case 6:
				return;
			case 8:
				fileStream = new FileStream((string)QICxImBNF3WOEwkV71G0(info), FileMode.Open, FileAccess.Read);
				num2 = 5;
				break;
			}
		}
	}

	protected virtual void CheckTemplateFileInfo(TemplateFileInfo fileInfo)
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
				CheckTemplateFileInfo(fileInfo, forceReplace: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void CheckTemplateFileInfo(TemplateFileInfo fileInfo, bool forceReplace)
	{
		//Discarded unreachable code: IL_00c7, IL_0148, IL_016c, IL_017b, IL_029a, IL_02f7, IL_0306
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (JpuDtyB1txd4T4MeQjoi(templatesPath))
				{
					num = 9;
					goto IL_0043;
				}
				goto IL_011a;
				IL_0152:
				string text = default(string);
				File.Delete(text);
				num = 4;
				goto IL_0043;
				IL_011a:
				WjJy5tBNWlg2uSDOl0jd(templatesPath);
				int num2 = 13;
				goto IL_0047;
				IL_0047:
				string text2 = default(string);
				while (true)
				{
					switch (num2)
					{
					case 12:
						if (tVupqCB19IS4LjiODWub(text2))
						{
							num2 = 11;
							continue;
						}
						goto case 2;
					case 1:
						Save(fileInfo, text2);
						num2 = 6;
						continue;
					case 11:
						if (!forceReplace)
						{
							num2 = 5;
							continue;
						}
						goto default;
					case 4:
						oLy9mCBNbjUxMwOeWdRQ(text2, text);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
						if (tVupqCB19IS4LjiODWub(text))
						{
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 4;
					case 3:
						break;
					case 2:
						Save(fileInfo, text2);
						num2 = 10;
						continue;
					case 6:
						return;
					case 7:
						goto IL_0152;
					case 5:
						return;
					case 9:
					case 13:
						goto IL_0186;
					default:
						text = (string)RCll9kB1D9ERqVLQQj46(templatesPath, UcIKopB1UobxuyXxm0lB(xerTQcB1y5ACYRZMUxkN(fileInfo), (!string.IsNullOrEmpty((string)HK5CxAB15FcK5cxHTGip(fileInfo))) ? DgRBkXB1mGLjcdTryPIr(OQCUdDB1aBNU99LDT8sT(0x4EA5403C ^ 0x4EA4013E), HK5CxAB15FcK5cxHTGip(fileInfo)) : "", OQCUdDB1aBNU99LDT8sT(-1886646897 ^ -1886565365)));
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 2;
						}
						continue;
					case 10:
						return;
					}
					break;
				}
				goto IL_011a;
				IL_0043:
				num2 = num;
				goto IL_0047;
				IL_0186:
				text2 = (string)RCll9kB1D9ERqVLQQj46(templatesPath, cOIwgFBNohAbxUUGgvUK(xerTQcB1y5ACYRZMUxkN(fileInfo), (!xyRvRTB1Jyy2mDx1JQ8b(HK5CxAB15FcK5cxHTGip(fileInfo))) ? DgRBkXB1mGLjcdTryPIr(OQCUdDB1aBNU99LDT8sT(0x1C9495B4 ^ 0x1C95D4B6), HK5CxAB15FcK5cxHTGip(fileInfo)) : "", OQCUdDB1aBNU99LDT8sT(-1217523399 ^ -1217441737), fIIOHZB1MjyIlmaxSNwP(fileInfo)));
				num = 12;
				goto IL_0043;
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					}
					vPZUotB1g1bUHCO9Xh4o(Logger.Log, DgRBkXB1mGLjcdTryPIr(OQCUdDB1aBNU99LDT8sT(-812025778 ^ -811993410), xerTQcB1y5ACYRZMUxkN(fileInfo)), ex);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num3 = 1;
					}
				}
			}
		case 0:
			break;
		}
	}

	public TemplateLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XPTimPBNh3BuYMqIUltA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TemplateLoader()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Guid = new Guid((string)OQCUdDB1aBNU99LDT8sT(0x4EDCBA32 ^ 0x4EDDFBAC));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool PXQv2aB1PBpZa3WVO81T()
	{
		return m1LAkrB1er5EgvSjNrlP == null;
	}

	internal static TemplateLoader bakgZhB11jN457NKVLCW()
	{
		return m1LAkrB1er5EgvSjNrlP;
	}

	internal static object IGbQNAB1NJvigm29UoNK(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object HrscTCB13ZmRDLVJejHU(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object C8yuHOB1pFLGFGeqvDdw(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).FilePath;
	}

	internal static object OQCUdDB1aBNU99LDT8sT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RCll9kB1D9ERqVLQQj46(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool JpuDtyB1txd4T4MeQjoi(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static void zW06N5B1wPOK4o0EvhCK(object P_0, bool P_1)
	{
		((FileSystemWatcher)P_0).IncludeSubdirectories = P_1;
	}

	internal static void Xtd5VjB1484TA7tNJU8m(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Changed += (FileSystemEventHandler)P_1;
	}

	internal static object qcj8lPB16lF1idFQDvB9()
	{
		return ELMAContext.CreateIsolated();
	}

	internal static object xw2y6OB1HyPAdd0yyXQq()
	{
		return CallContextSessionOwner.Create();
	}

	internal static void vIRVNVB1AEkljXABFdrY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object CbkLAoB17xC6OWEYlV6P()
	{
		return SR.GetCurrentCulture();
	}

	internal static object BdTOdyB1x4FEbeeJBh3u(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object OZoCmDB10v9CBQydfpMy()
	{
		return SR.KeyCultureInfo;
	}

	internal static object DgRBkXB1mGLjcdTryPIr(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object xerTQcB1y5ACYRZMUxkN(object P_0)
	{
		return ((TemplateFileInfo)P_0).Name;
	}

	internal static object fIIOHZB1MjyIlmaxSNwP(object P_0)
	{
		return ((TemplateFileInfo)P_0).Extension;
	}

	internal static bool xyRvRTB1Jyy2mDx1JQ8b(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool tVupqCB19IS4LjiODWub(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object yA9oQTB1dKoLG5mk2et7(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool kfaPUuB1lgfuktLVixjX(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object t6bMG2B1rk43UvZC7lf4()
	{
		return Logger.Log;
	}

	internal static void vPZUotB1g1bUHCO9Xh4o(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object HK5CxAB15FcK5cxHTGip(object P_0)
	{
		return ((TemplateFileInfo)P_0).CultureName;
	}

	internal static object fODHPfB1jxQqlWCKF9Bd(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool JsoLTkB1Y36uwgLXVoiY(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object ewPwGwB1L8NjleXp6od0()
	{
		return IOExtensions.GetTempFileName();
	}

	internal static object UcIKopB1UobxuyXxm0lB(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void ixnFHgB1sNp4S0N5D2EW(object P_0, object P_1, bool P_2)
	{
		File.Copy((string)P_0, (string)P_1, P_2);
	}

	internal static object xZW3q1B1csUalOwMWheO(object P_0)
	{
		return ((TemplateFileInfo)P_0).Assembly;
	}

	internal static bool CT0IgrB1zaHLKl4H4XyR(object P_0, object P_1)
	{
		return (Assembly)P_0 != (Assembly)P_1;
	}

	internal static object QICxImBNF3WOEwkV71G0(object P_0)
	{
		return ((TemplateFileInfo)P_0).FullPath;
	}

	internal static long xWLaagBNBatmWIKoXCR5(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object WjJy5tBNWlg2uSDOl0jd(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object cOIwgFBNohAbxUUGgvUK(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static void oLy9mCBNbjUxMwOeWdRQ(object P_0, object P_1)
	{
		File.Move((string)P_0, (string)P_1);
	}

	internal static void XPTimPBNh3BuYMqIUltA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
