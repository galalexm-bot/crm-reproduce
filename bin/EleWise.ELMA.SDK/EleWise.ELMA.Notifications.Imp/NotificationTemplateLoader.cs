using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

[Component(Order = 100000)]
public class NotificationTemplateLoader : INotificationTemplateLoader, IInitHandler, IDisposable
{
	private readonly FileSystemWatcher watcher;

	private string templatesPath;

	private DateTime lastRootLoaded;

	private bool needReloadTemplates;

	private bool initialized;

	private DateTime lastLoaded;

	private Dictionary<string, DateTime> lastTemplateLoaded;

	private Dictionary<string, NotificationTemplateFileInfo> notificationFileInfos;

	private List<NotificationTemplate> templates;

	private List<NotificationPartialExtensionTemplate> extensionTemplates;

	private List<NotificationTemplate> defaultTemplates;

	private List<CustomMessage> customMessages;

	private static NotificationTemplateLoader LS6W7s4hlHMu0BmJCaO;

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
				case 0:
					return;
				case 1:
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<INotificationTemplateDataSource> DataSources { get; set; }

	public virtual IEnumerable<INotificationTemplate> GetTemplates(INotification notification)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.notification = notification;
		if (!initialized)
		{
			return new INotificationTemplate[0];
		}
		CheckTemplates();
		IEnumerable<NotificationTemplate> enumerable = templates;
		return (from t in enumerable ?? new NotificationTemplate[0]
			where _003C_003Ec.Sj83imflc2ColasxvEZ0(_003C_003Ec.uadgc8flsSUH3JUNwEwf(t))
			select CS_0024_003C_003E8__locals0._003C_003E4__this.CheckTemplate(t, CS_0024_003C_003E8__locals0.notification) into t
			where t != null
			select t).ToList();
	}

	public virtual IEnumerable<INotificationPartialTemplate> GetExtensionTemplates(string zone)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.zone = zone;
		if (!initialized)
		{
			return new INotificationPartialTemplate[0];
		}
		CheckTemplates();
		IEnumerable<NotificationPartialExtensionTemplate> enumerable = extensionTemplates;
		return (enumerable ?? new NotificationPartialExtensionTemplate[0]).Where(delegate(NotificationPartialExtensionTemplate t)
		{
			//Discarded unreachable code: IL_0066, IL_0075
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (t.Zones == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return t.Zones.Contains(CS_0024_003C_003E8__locals0.zone);
				default:
					return false;
				}
			}
		}).Cast<INotificationPartialTemplate>().ToList();
	}

	public virtual NotificationTemplate GetDefaultTemplate(NotificationTemplateFileInfo currentFileInfo, string name)
	{
		//Discarded unreachable code: IL_00fb, IL_011c, IL_0126, IL_0135, IL_01da, IL_01e9
		int num = 14;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		NotificationTemplateFileInfo value = default(NotificationTemplateFileInfo);
		int num3 = default(int);
		string key = default(string);
		while (true)
		{
			int num2 = num;
			object obj;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 7:
					return null;
				case 9:
					if (currentFileInfo != null)
					{
						return currentFileInfo.DefaultTemplates.FirstOrDefault(_003C_003Ec__DisplayClass10_._003CGetDefaultTemplate_003Eb__0);
					}
					num2 = 7;
					continue;
				case 1:
				case 11:
					return value.DefaultTemplates.FirstOrDefault(_003C_003Ec__DisplayClass10_._003CGetDefaultTemplate_003Eb__1);
				case 6:
					if (_003C_003Ec__DisplayClass10_.name == null)
					{
						num2 = 12;
						continue;
					}
					num4 = _003C_003Ec__DisplayClass10_.name.IndexOf('/');
					goto IL_0202;
				case 12:
					num4 = -1;
					goto IL_0202;
				case 2:
					if (num3 >= 0)
					{
						if (num3 > 0)
						{
							num2 = 10;
							continue;
						}
						goto case 3;
					}
					num2 = 9;
					continue;
				case 3:
					obj = "";
					goto end_IL_0012;
				case 13:
					_003C_003Ec__DisplayClass10_.name = name;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass10_.templateName = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 13;
					}
					continue;
				case 4:
					if (!gPUbjT4vxK0PKbOkMo8(_003C_003Ec__DisplayClass10_.templateName, string.Empty))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 8;
				case 10:
					obj = gE2rxr4f1VDEH6YnrDP(_003C_003Ec__DisplayClass10_.name, 0, num3);
					goto end_IL_0012;
				case 5:
					{
						_003C_003Ec__DisplayClass10_.templateName = (string)((num3 < Oa5EhP4Q1ZlU1UBINoX(_003C_003Ec__DisplayClass10_.name) - 1) ? dplOjV4CRrLiIub3wpI(_003C_003Ec__DisplayClass10_.name, num3 + 1) : "");
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					IL_0202:
					num3 = num4;
					num2 = 2;
					continue;
				}
				if (notificationFileInfos.TryGetValue(key, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				return null;
				continue;
				end_IL_0012:
				break;
			}
			key = (string)obj;
			num = 5;
		}
	}

	public virtual NotificationPartialTemplate GetPartialTemplate(NotificationTemplateFileInfo currentFileInfo, string name)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_0154, IL_015e, IL_016d, IL_01ca, IL_01de
		int num = 3;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		int num3 = default(int);
		string key = default(string);
		NotificationTemplateFileInfo value = default(NotificationTemplateFileInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				object obj;
				switch (num2)
				{
				case 8:
					_003C_003Ec__DisplayClass11_.templateName = null;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass11_.name = name;
					num2 = 15;
					continue;
				case 15:
					if (_003C_003Ec__DisplayClass11_.name == null)
					{
						num2 = 9;
						continue;
					}
					num4 = q35Kel48Hc05ZdORl0D(_003C_003Ec__DisplayClass11_.name, '/');
					goto IL_01f1;
				case 14:
					if (num3 >= 0)
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 12:
					if (gPUbjT4vxK0PKbOkMo8(_003C_003Ec__DisplayClass11_.templateName, string.Empty))
					{
						num = 8;
						break;
					}
					goto case 7;
				case 5:
					if (!notificationFileInfos.TryGetValue(key, out value))
					{
						num = 11;
						break;
					}
					goto case 12;
				case 1:
					return null;
				case 10:
					if (num3 > 0)
					{
						num = 13;
						break;
					}
					goto case 4;
				case 9:
					num4 = -1;
					goto IL_01f1;
				case 6:
					if (currentFileInfo != null)
					{
						return currentFileInfo.Partials.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CGetPartialTemplate_003Eb__0);
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					return value.Partials.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CGetPartialTemplate_003Eb__1);
				case 11:
					return null;
				case 3:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 2;
					continue;
				case 4:
					obj = "";
					goto IL_020c;
				case 13:
					obj = gE2rxr4f1VDEH6YnrDP(_003C_003Ec__DisplayClass11_.name, 0, num3);
					goto IL_020c;
				default:
					{
						_003C_003Ec__DisplayClass11_.templateName = (string)((num3 < Oa5EhP4Q1ZlU1UBINoX(_003C_003Ec__DisplayClass11_.name) - 1) ? dplOjV4CRrLiIub3wpI(_003C_003Ec__DisplayClass11_.name, num3 + 1) : "");
						num2 = 5;
						continue;
					}
					IL_020c:
					key = (string)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					continue;
					IL_01f1:
					num3 = num4;
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	public void Init()
	{
	}

	public void InitComplete()
	{
		//Discarded unreachable code: IL_009d, IL_00ac, IL_0134, IL_0143, IL_014e, IL_0191, IL_01a0, IL_01ab, IL_023a, IL_0272, IL_0281, IL_02ea, IL_031d, IL_0385, IL_03a5, IL_03c4, IL_03d3, IL_0400, IL_040f, IL_041f, IL_0447, IL_0456
		int num = 8;
		IEnumerator<INotificationTemplateDataSource> enumerator = default(IEnumerator<INotificationTemplateDataSource>);
		IEnumerator<NotificationTemplateFileInfo> enumerator2 = default(IEnumerator<NotificationTemplateFileInfo>);
		IEnumerable<NotificationTemplateFileInfo> files = default(IEnumerable<NotificationTemplateFileInfo>);
		NotificationTemplateFileInfo current2 = default(NotificationTemplateFileInfo);
		INotificationTemplateDataSource current = default(INotificationTemplateDataSource);
		string path = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					v204Ho4k2m6WeHc51DR(watcher, true);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 9;
					}
					continue;
				case 15:
					FH5Qgp4iRAFZNKVQ5kG(templatesPath);
					num2 = 12;
					continue;
				case 14:
					initialized = true;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 10;
					}
					continue;
				case 6:
					if (lOZT7B4SujEYk3NUPiB(templatesPath))
					{
						num2 = 3;
						continue;
					}
					goto case 15;
				case 7:
					if (RuntimeApplication == null)
					{
						num2 = 13;
						continue;
					}
					goto case 1;
				case 3:
				case 12:
					enumerator = DataSources.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 11;
					}
					continue;
				case 11:
					try
					{
						while (true)
						{
							IL_029f:
							int num3;
							if (!muyrH94XZyHpov9Xaeu(enumerator))
							{
								num3 = 6;
								goto IL_0152;
							}
							goto IL_028c;
							IL_0152:
							while (true)
							{
								switch (num3)
								{
								case 3:
									enumerator2 = files.GetEnumerator();
									num3 = 5;
									continue;
								case 5:
									try
									{
										while (true)
										{
											int num6;
											if (!muyrH94XZyHpov9Xaeu(enumerator2))
											{
												num6 = 2;
												goto IL_01af;
											}
											goto IL_01f1;
											IL_01af:
											while (true)
											{
												switch (num6)
												{
												case 1:
													bL8e3u4K3hmBKn9fQU6(this, current2);
													num6 = 3;
													continue;
												case 3:
													break;
												default:
													goto IL_01f1;
												case 2:
													goto end_IL_01db;
												}
												break;
											}
											continue;
											IL_01f1:
											current2 = enumerator2.Current;
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
											{
												num6 = 1;
											}
											goto IL_01af;
											continue;
											end_IL_01db:
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													XKiUm64Tg0E7qMd6y6U(enumerator2);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
													{
														num7 = 0;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto IL_029f;
								case 1:
									goto IL_029f;
								case 2:
									if (files != null)
									{
										num3 = 3;
										continue;
									}
									goto IL_029f;
								case 4:
									try
									{
										files = current.GetFiles();
										int num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
										{
											num4 = 0;
										}
										switch (num4)
										{
										case 0:
											break;
										}
									}
									catch (Exception ex)
									{
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												break;
											default:
												jQrJAF4qpcddGCXPLgX(Logger.Log, ku4Bjy4RBgnKwpEvMIm(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A57707), current.GetType().FullName), ex);
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
												{
													num5 = 0;
												}
												continue;
											}
											break;
										}
										goto IL_029f;
									}
									goto case 2;
								case 6:
									goto end_IL_029f;
								}
								break;
							}
							goto IL_028c;
							IL_028c:
							current = enumerator.Current;
							num3 = 4;
							goto IL_0152;
							continue;
							end_IL_029f:
							break;
						}
					}
					finally
					{
						int num8;
						if (enumerator == null)
						{
							num8 = 2;
							goto IL_03a9;
						}
						goto IL_03de;
						IL_03a9:
						switch (num8)
						{
						case 2:
							goto end_IL_0394;
						case 1:
							goto end_IL_0394;
						}
						goto IL_03de;
						IL_03de:
						XKiUm64Tg0E7qMd6y6U(enumerator);
						num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num8 = 1;
						}
						goto IL_03a9;
						end_IL_0394:;
					}
					goto case 2;
				case 8:
					if (DataSources != null)
					{
						num = 7;
						break;
					}
					return;
				case 13:
					return;
				case 5:
					return;
				default:
					path = (string)qVtwgx4Il76svkK8Aw0(((System.Configuration.Configuration)pLugl84uRylQhn84D0F(rEYKQt4ZjViYyWPnbtt(RuntimeApplication))).FilePath);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					if (rEYKQt4ZjViYyWPnbtt(RuntimeApplication) == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					templatesPath = Path.Combine(path, (string)KNLRfh4VHvHHNuvYdpj(-1459557599 ^ -1459591549));
					num = 6;
					break;
				case 10:
					return;
				case 2:
					watcher.Path = templatesPath;
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	public void Dispose()
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
				FGYea74nyNOUqy7Z7EJ(watcher);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public NotificationTemplateLoader()
	{
		//Discarded unreachable code: IL_0046, IL_004b
		yM8W1m4OFSEj8tUjUe2();
		needReloadTemplates = true;
		lastLoaded = DateTime.MinValue;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
			{
				FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
				eATWvX42g29sKd9aJlv(fileSystemWatcher, NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.CreationTime);
				MOhx9G4eXNKPQVhAxxY(fileSystemWatcher, KNLRfh4VHvHHNuvYdpj(0x6DC147B0 ^ 0x6DC1C99C));
				fileSystemWatcher.IncludeSubdirectories = true;
				watcher = fileSystemWatcher;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num = 3;
				}
				break;
			}
			case 2:
				watcher.Deleted += WatcherOnChanged;
				num = 5;
				break;
			case 0:
				return;
			case 4:
				uDJMeD41nwcnONeRyVp(watcher, new FileSystemEventHandler(WatcherOnChanged));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				bOo7v84PFbc8V0E6SRv(watcher, new FileSystemEventHandler(WatcherOnChanged));
				num = 4;
				break;
			case 5:
				p5XDS74NmG8HU0ZySyC(watcher, new RenamedEventHandler(WatcherOnChanged));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected virtual void CheckTemplateFileInfo(NotificationTemplateFileInfo fileInfo)
	{
		//Discarded unreachable code: IL_00fa, IL_025d, IL_027e, IL_028d, IL_02b3, IL_02c2, IL_02f8, IL_036b, IL_03e7, IL_0440, IL_0492, IL_052e, IL_057f, IL_058e, IL_05e6, IL_06d8, IL_073a, IL_0749
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (!lOZT7B4SujEYk3NUPiB(templatesPath))
				{
					num = 11;
					goto IL_0043;
				}
				goto IL_0328;
				IL_0043:
				string text2 = default(string);
				string text7 = default(string);
				string text3 = default(string);
				string text5 = default(string);
				Version version = default(Version);
				Version version2 = default(Version);
				string text = default(string);
				string text6 = default(string);
				string text4 = default(string);
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 22:
						File.Delete(text2);
						num = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num = 5;
						}
						continue;
					case 23:
						if (!F7SpWa4tf1xlR9Vk5gt(text2))
						{
							num = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num = 2;
							}
							continue;
						}
						goto case 22;
					case 4:
					case 5:
						text2 = (string)O6sjHa4D5WOAMyvRytj(text7, aR2dDi4a19s9qgF6tC1(qMEC6K4po8AI9wBe780(fileInfo), KNLRfh4VHvHHNuvYdpj(0xA592A41 ^ 0xA59A40F)));
						num = 23;
						continue;
					case 38:
						I7sXvl4wm0Au3Hui6hy(text3);
						num = 37;
						continue;
					case 29:
						text5 = (string)pLso0143vBSMT792mUw(templatesPath, KNLRfh4VHvHHNuvYdpj(-1822890472 ^ -1822922718), version.ToString());
						num = 9;
						continue;
					case 27:
						if (version2.Equals(version))
						{
							num = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num = 6;
							}
							continue;
						}
						goto case 14;
					case 17:
						I7sXvl4wm0Au3Hui6hy(text);
						num = 18;
						continue;
					case 19:
						text6 = (string)O6sjHa4D5WOAMyvRytj(templatesPath, KNLRfh4VHvHHNuvYdpj(-1633514411 ^ -1633549809));
						num = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num = 31;
						}
						continue;
					case 7:
					case 24:
						puYhYO4AJKoRYsp7d07(text4, text2);
						num = 20;
						continue;
					case 2:
						version2 = null;
						num = 35;
						continue;
					case 16:
						fileInfo.Version = version;
						num = 29;
						continue;
					case 30:
						if (!File.Exists(text4))
						{
							num = 15;
							continue;
						}
						goto case 2;
					case 6:
						return;
					case 25:
					case 37:
						DdPoUX47S2nLbvggK6U(syFJjB44tEhEWJywNVq(fileInfo), text4);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num = 0;
						}
						continue;
					case 11:
						FH5Qgp4iRAFZNKVQ5kG(templatesPath);
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num = 3;
						}
						continue;
					case 3:
						break;
					case 35:
						try
						{
							XmlDocument xmlDocument = new XmlDocument();
							int num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 1;
							}
							while (true)
							{
								switch (num3)
								{
								case 2:
									version2 = new NotificationTemplateFileInfo((string)qMEC6K4po8AI9wBe780(fileInfo), xmlDocument).Version;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									xmlDocument.Load(text4);
									num3 = 2;
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						catch (Exception exception)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									((ILogger)G25PIE46HIbxaEMo2PG()).Error(ku4Bjy4RBgnKwpEvMIm(KNLRfh4VHvHHNuvYdpj(-210725949 ^ -210756185), text4), exception);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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
						goto case 39;
					case 39:
						if (version2 == null)
						{
							num = 33;
							continue;
						}
						goto case 27;
					case 28:
						if (Directory.Exists(text7))
						{
							num = 5;
							continue;
						}
						goto case 12;
					case 9:
						if (Directory.Exists(text5))
						{
							num = 34;
							continue;
						}
						goto case 32;
					case 31:
						if (lOZT7B4SujEYk3NUPiB(text6))
						{
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num = 8;
							}
							continue;
						}
						goto case 10;
					case 15:
					case 21:
						DdPoUX47S2nLbvggK6U(syFJjB44tEhEWJywNVq(fileInfo), text4);
						num = 41;
						continue;
					case 32:
						FH5Qgp4iRAFZNKVQ5kG(text5);
						num = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num = 13;
						}
						continue;
					case 13:
					case 34:
						text = (string)O6sjHa4D5WOAMyvRytj(text5, aR2dDi4a19s9qgF6tC1(qMEC6K4po8AI9wBe780(fileInfo), KNLRfh4VHvHHNuvYdpj(0x4785BC0D ^ 0x47853243)));
						num = 36;
						continue;
					case 1:
					case 8:
						text4 = Path.Combine(templatesPath, (string)qMEC6K4po8AI9wBe780(fileInfo) + (string)KNLRfh4VHvHHNuvYdpj(-1146510045 ^ -1146541203));
						num = 30;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num = 21;
						}
						continue;
					case 36:
						if (!F7SpWa4tf1xlR9Vk5gt(text))
						{
							num = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num = 26;
							}
							continue;
						}
						goto case 17;
					case 10:
						FH5Qgp4iRAFZNKVQ5kG(text6);
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num = 1;
						}
						continue;
					case 20:
						text3 = (string)O6sjHa4D5WOAMyvRytj(templatesPath, aR2dDi4a19s9qgF6tC1(qMEC6K4po8AI9wBe780(fileInfo), KNLRfh4VHvHHNuvYdpj(-675505729 ^ -675539109)));
						num = 40;
						continue;
					case 12:
					{
						FH5Qgp4iRAFZNKVQ5kG(text7);
						int num2 = 4;
						num = num2;
						continue;
					}
					case 40:
						if (!F7SpWa4tf1xlR9Vk5gt(text3))
						{
							num = 25;
							continue;
						}
						goto case 38;
					case 18:
					case 26:
						((XmlDocument)syFJjB44tEhEWJywNVq(fileInfo)).Save(text);
						num = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num = 17;
						}
						continue;
					case 14:
					case 33:
						text7 = (string)O6sjHa4D5WOAMyvRytj(text6, HSbQWp4HThcBwBReTMF(version2, null) ? version2.ToString() : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672089099));
						num = 28;
						continue;
					case 41:
						return;
					}
					break;
				}
				goto IL_0328;
				IL_0328:
				version = VersionInfo.GetVersion<SR>();
				num = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num = 1;
				}
				goto IL_0043;
			}
			catch (Exception ex)
			{
				int num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num5 = 0;
				}
				while (true)
				{
					switch (num5)
					{
					case 1:
						return;
					}
					jQrJAF4qpcddGCXPLgX(G25PIE46HIbxaEMo2PG(), ku4Bjy4RBgnKwpEvMIm(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F5E846), fileInfo.Name), ex);
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num5 = 1;
					}
				}
			}
		case 0:
			break;
		}
	}

	protected virtual void CheckFiles(DirectoryInfo directory)
	{
		//Discarded unreachable code: IL_00f9, IL_0108, IL_0197, IL_01ca, IL_0227, IL_0281, IL_028b, IL_033f, IL_037f, IL_038a, IL_039a, IL_03a4, IL_0449, IL_0481, IL_04a9, IL_04b3, IL_0567, IL_059f, IL_05ae, IL_05dc, IL_060f, IL_0672, IL_0681, IL_06ae, IL_06bd, IL_06c8, IL_078d, IL_07a0, IL_07af, IL_080b, IL_083e, IL_089b, IL_092b, IL_093a, IL_0945, IL_0988, IL_0997, IL_0a21, IL_0a30, IL_0aeb, IL_0b0a, IL_0b36, IL_0b46, IL_0b54, IL_0bf8, IL_0c28, IL_0c37, IL_0c43, IL_0c97, IL_0ca6, IL_0cb1, IL_0d55, IL_0d8d, IL_0e16, IL_0e25, IL_0e30, IL_0ee5, IL_0f25, IL_0f34, IL_0f40, IL_0f7c, IL_0f8b, IL_103f, IL_107f, IL_108a, IL_110f, IL_111f, IL_112e, IL_1139, IL_11de, IL_11fd, IL_120c, IL_1239, IL_1248
		int num = 25;
		string text = default(string);
		FileInfo fileInfo = default(FileInfo);
		FileInfo[] array = default(FileInfo[]);
		XmlDocument xmlDocument = default(XmlDocument);
		NotificationTemplateFileInfo notificationTemplateFileInfo = default(NotificationTemplateFileInfo);
		Dictionary<NotificationTemplate, List<CustomMessage>>.Enumerator enumerator3 = default(Dictionary<NotificationTemplate, List<CustomMessage>>.Enumerator);
		Dictionary<NotificationTemplate, List<CustomMessage>> dictionary = default(Dictionary<NotificationTemplate, List<CustomMessage>>);
		IEnumerator<NotificationPartialExtensionTemplate> enumerator4 = default(IEnumerator<NotificationPartialExtensionTemplate>);
		NotificationPartialExtensionTemplate current10 = default(NotificationPartialExtensionTemplate);
		NotificationPartialExtensionTemplate current9 = default(NotificationPartialExtensionTemplate);
		IEnumerator<NotificationTemplate> enumerator2 = default(IEnumerator<NotificationTemplate>);
		NotificationTemplateFileInfo value = default(NotificationTemplateFileInfo);
		IEnumerator<CustomMessage> enumerator = default(IEnumerator<CustomMessage>);
		CustomMessage current8 = default(CustomMessage);
		KeyValuePair<NotificationTemplate, List<CustomMessage>> current7 = default(KeyValuePair<NotificationTemplate, List<CustomMessage>>);
		int num10 = default(int);
		NotificationTemplate notificationTemplate = default(NotificationTemplate);
		CustomMessage current6 = default(CustomMessage);
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		NotificationTemplate current5 = default(NotificationTemplate);
		NotificationTemplate current4 = default(NotificationTemplate);
		NotificationTemplate current3 = default(NotificationTemplate);
		CustomMessage current2 = default(CustomMessage);
		NotificationTemplate current = default(NotificationTemplate);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					text = (string)ltFw8x4yyaV0rggrEva(FTXAwJ4mxZ9MvLcoAhB(fileInfo));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 8;
					}
					continue;
				case 24:
					array = (FileInfo[])lhCATO40AnpPbUgNxVm(directory, KNLRfh4VHvHHNuvYdpj(0x12441CA4 ^ 0x12449288));
					num2 = 5;
					continue;
				case 27:
					xmlDocument = new XmlDocument();
					num2 = 39;
					continue;
				case 36:
					if (customMessages.Any())
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					return;
				case 34:
					try
					{
						notificationTemplateFileInfo = new NotificationTemplateFileInfo(text, xmlDocument);
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num14 = 0;
						}
						while (true)
						{
							switch (num14)
							{
							default:
								jQrJAF4qpcddGCXPLgX(G25PIE46HIbxaEMo2PG(), string.Format((string)KNLRfh4VHvHHNuvYdpj(-1824388195 ^ -1824357347), O7Lk4149UecZWaw9rmU(fileInfo)), ex);
								num14 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num14 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
						goto default;
					}
					goto case 4;
				case 20:
					lastTemplateLoaded[text] = fileInfo.LastWriteTime;
					num2 = 38;
					continue;
				case 6:
					enumerator3 = dictionary.GetEnumerator();
					num = 22;
					break;
				case 15:
					dictionary = new Dictionary<NotificationTemplate, List<CustomMessage>>();
					num2 = 30;
					continue;
				case 35:
					try
					{
						while (true)
						{
							int num29;
							if (!muyrH94XZyHpov9Xaeu(enumerator4))
							{
								num29 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num29 = 2;
								}
								goto IL_028f;
							}
							goto IL_02f6;
							IL_02f6:
							current10 = enumerator4.Current;
							num29 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
							{
								num29 = 0;
							}
							goto IL_028f;
							IL_028f:
							while (true)
							{
								switch (num29)
								{
								case 1:
									break;
								default:
									extensionTemplates.Add(current10);
									num29 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num29 = 0;
									}
									continue;
								case 3:
									goto IL_02f6;
								case 2:
									goto end_IL_02a9;
								}
								break;
							}
							continue;
							end_IL_02a9:
							break;
						}
					}
					finally
					{
						int num30;
						if (enumerator4 == null)
						{
							num30 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num30 = 0;
							}
							goto IL_0343;
						}
						goto IL_0359;
						IL_0359:
						XKiUm64Tg0E7qMd6y6U(enumerator4);
						num30 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num30 = 1;
						}
						goto IL_0343;
						IL_0343:
						switch (num30)
						{
						default:
							goto end_IL_031e;
						case 2:
							break;
						case 0:
							goto end_IL_031e;
						case 1:
							goto end_IL_031e;
						}
						goto IL_0359;
						end_IL_031e:;
					}
					goto case 3;
				case 7:
					try
					{
						while (true)
						{
							IL_03da:
							int num27;
							if (!muyrH94XZyHpov9Xaeu(enumerator4))
							{
								num27 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num27 = 0;
								}
								goto IL_03a8;
							}
							goto IL_0400;
							IL_0400:
							current9 = enumerator4.Current;
							num27 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num27 = 1;
							}
							goto IL_03a8;
							IL_03a8:
							while (true)
							{
								switch (num27)
								{
								case 1:
									extensionTemplates.Remove(current9);
									num27 = 3;
									continue;
								case 3:
									goto IL_03da;
								case 2:
									goto IL_0400;
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
						if (enumerator4 != null)
						{
							int num28 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num28 = 0;
							}
							while (true)
							{
								switch (num28)
								{
								case 1:
									enumerator4.Dispose();
									num28 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num28 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 10;
				case 21:
					enumerator2 = value.Templates.GetEnumerator();
					num2 = 26;
					continue;
				case 42:
					try
					{
						while (true)
						{
							int num25;
							if (!muyrH94XZyHpov9Xaeu(enumerator))
							{
								num25 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num25 = 3;
								}
								goto IL_04b7;
							}
							goto IL_051e;
							IL_051e:
							current8 = enumerator.Current;
							num25 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
							{
								num25 = 1;
							}
							goto IL_04b7;
							IL_04b7:
							while (true)
							{
								switch (num25)
								{
								case 1:
									customMessages.Add(current8);
									num25 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num25 = 0;
									}
									continue;
								case 2:
									goto IL_051e;
								case 3:
									goto end_IL_04d1;
								}
								break;
							}
							continue;
							end_IL_04d1:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num26 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num26 = 0;
							}
							while (true)
							{
								switch (num26)
								{
								default:
									XKiUm64Tg0E7qMd6y6U(enumerator);
									num26 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num26 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto default;
				case 2:
					try
					{
						xiNRsZ4ddtwET8yOuvp(notificationTemplateFileInfo, this);
						int num23 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num23 = 0;
						}
						switch (num23)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex3)
					{
						int num24 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num24 = 1;
						}
						while (true)
						{
							switch (num24)
							{
							case 1:
								jQrJAF4qpcddGCXPLgX(Logger.Log, ku4Bjy4RBgnKwpEvMIm(KNLRfh4VHvHHNuvYdpj(-978351861 ^ -978385189), O7Lk4149UecZWaw9rmU(fileInfo)), ex3);
								num24 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num24 = 0;
								}
								continue;
							}
							break;
						}
						goto default;
					}
					goto case 1;
				case 23:
					enumerator4 = value.ExtensionTemplates.GetEnumerator();
					num = 7;
					break;
				case 22:
					try
					{
						while (true)
						{
							int num21;
							if (!enumerator3.MoveNext())
							{
								num21 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num21 = 0;
								}
								goto IL_06cc;
							}
							goto IL_073e;
							IL_073e:
							current7 = enumerator3.Current;
							num21 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num21 = 0;
							}
							goto IL_06cc;
							IL_06cc:
							while (true)
							{
								switch (num21)
								{
								default:
									return;
								case 2:
									current7.Key.SetCustomMessages((CustomMessage[])aZujkA4lMI4RRdZ9Naf(current7.Value));
									num21 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num21 = 2;
									}
									continue;
								case 3:
									break;
								case 1:
									goto IL_073e;
								case 0:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num22 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						case 0:
							break;
						}
					}
				case 3:
					enumerator2 = notificationTemplateFileInfo.DefaultTemplates.GetEnumerator();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 16;
					}
					continue;
				case 39:
					try
					{
						xmlDocument.Load((string)O7Lk4149UecZWaw9rmU(fileInfo));
						int num19 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num19 = 0;
						}
						switch (num19)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex2)
					{
						int num20 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num20 = 0;
						}
						while (true)
						{
							switch (num20)
							{
							default:
								jQrJAF4qpcddGCXPLgX(G25PIE46HIbxaEMo2PG(), ku4Bjy4RBgnKwpEvMIm(KNLRfh4VHvHHNuvYdpj(0x1ECE530A ^ 0x1ECEDC5E), O7Lk4149UecZWaw9rmU(fileInfo)), ex2);
								num20 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num20 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
						goto default;
					}
					goto case 32;
				case 31:
					return;
				case 11:
					enumerator2 = notificationTemplateFileInfo.Templates.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 37;
					}
					continue;
				case 40:
					enumerator = notificationTemplateFileInfo.CustomMessages.GetEnumerator();
					num2 = 42;
					continue;
				case 43:
					fileInfo = array[num10];
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 18;
					}
					continue;
				case 38:
					if (notificationFileInfos.TryGetValue(text, out value))
					{
						num2 = 21;
						continue;
					}
					goto case 27;
				case 9:
					try
					{
						while (true)
						{
							IL_0a74:
							int num17;
							if (!enumerator.MoveNext())
							{
								num17 = 11;
								goto IL_0949;
							}
							goto IL_09f6;
							IL_0949:
							while (true)
							{
								switch (num17)
								{
								case 6:
									dictionary.Add(notificationTemplate, new List<CustomMessage> { current6 });
									num17 = 3;
									continue;
								case 2:
									notificationTemplate = templates.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CCheckFiles_003Eb__1);
									num17 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num17 = 9;
									}
									continue;
								case 1:
									break;
								case 4:
									_003C_003Ec__DisplayClass17_.message = current6;
									num17 = 2;
									continue;
								case 10:
									_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
									num17 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num17 = 3;
									}
									continue;
								case 8:
									if (dictionary.ContainsKey(notificationTemplate))
									{
										num17 = 7;
										continue;
									}
									goto case 6;
								default:
									goto IL_0a74;
								case 9:
									if (notificationTemplate == null)
									{
										num17 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
										{
											num17 = 0;
										}
										continue;
									}
									goto case 8;
								case 7:
									dictionary[notificationTemplate].Add(current6);
									num17 = 5;
									continue;
								case 11:
									goto end_IL_0a74;
								}
								break;
							}
							goto IL_09f6;
							IL_09f6:
							current6 = enumerator.Current;
							num17 = 10;
							goto IL_0949;
							continue;
							end_IL_0a74:
							break;
						}
					}
					finally
					{
						int num18;
						if (enumerator == null)
						{
							num18 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num18 = 1;
							}
							goto IL_0aef;
						}
						goto IL_0b14;
						IL_0b14:
						XKiUm64Tg0E7qMd6y6U(enumerator);
						num18 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num18 = 0;
						}
						goto IL_0aef;
						IL_0aef:
						switch (num18)
						{
						default:
							goto end_IL_0aca;
						case 1:
							goto end_IL_0aca;
						case 2:
							break;
						case 0:
							goto end_IL_0aca;
						}
						goto IL_0b14;
						end_IL_0aca:;
					}
					goto case 6;
				case 16:
					try
					{
						while (true)
						{
							int num15;
							if (!muyrH94XZyHpov9Xaeu(enumerator2))
							{
								num15 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num15 = 0;
								}
								goto IL_0b58;
							}
							goto IL_0b98;
							IL_0b98:
							current5 = enumerator2.Current;
							num15 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num15 = 0;
							}
							goto IL_0b58;
							IL_0b58:
							while (true)
							{
								switch (num15)
								{
								case 2:
									break;
								case 3:
									goto IL_0b98;
								default:
									defaultTemplates.Add(current5);
									num15 = 2;
									continue;
								case 1:
									goto end_IL_0b72;
								}
								break;
							}
							continue;
							end_IL_0b72:
							break;
						}
					}
					finally
					{
						int num16;
						if (enumerator2 == null)
						{
							num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num16 = 0;
							}
							goto IL_0bfc;
						}
						goto IL_0c12;
						IL_0c12:
						enumerator2.Dispose();
						num16 = 2;
						goto IL_0bfc;
						IL_0bfc:
						switch (num16)
						{
						default:
							goto end_IL_0bd7;
						case 1:
							break;
						case 0:
							goto end_IL_0bd7;
						case 2:
							goto end_IL_0bd7;
						}
						goto IL_0c12;
						end_IL_0bd7:;
					}
					goto case 40;
				case 17:
					enumerator = value.CustomMessages.GetEnumerator();
					num2 = 14;
					continue;
				default:
					num10++;
					num2 = 13;
					continue;
				case 8:
					if (lastTemplateLoaded.ContainsKey(text))
					{
						num2 = 41;
						continue;
					}
					goto case 20;
				case 37:
					try
					{
						while (true)
						{
							IL_0d09:
							int num11;
							if (!muyrH94XZyHpov9Xaeu(enumerator2))
							{
								num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num11 = 0;
								}
								goto IL_0cb5;
							}
							goto IL_0cf6;
							IL_0cf6:
							current4 = enumerator2.Current;
							num11 = 2;
							goto IL_0cb5;
							IL_0cb5:
							while (true)
							{
								switch (num11)
								{
								case 2:
									templates.Add(current4);
									num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num11 = 3;
									}
									continue;
								case 1:
									goto IL_0cf6;
								case 3:
									goto IL_0d09;
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
						if (enumerator2 != null)
						{
							int num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									enumerator2.Dispose();
									num12 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num12 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 28;
				case 1:
					notificationFileInfos.Add(text, notificationTemplateFileInfo);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					num10 = 0;
					num2 = 33;
					continue;
				case 19:
					notificationFileInfos.Remove(text);
					num2 = 27;
					continue;
				case 4:
					num2 = 2;
					continue;
				case 13:
				case 33:
					if (num10 >= array.Length)
					{
						num2 = 36;
						continue;
					}
					goto case 43;
				case 32:
					num2 = 34;
					continue;
				case 26:
					try
					{
						while (true)
						{
							IL_0e99:
							int num8;
							if (!muyrH94XZyHpov9Xaeu(enumerator2))
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num8 = 0;
								}
								goto IL_0e34;
							}
							goto IL_0e4e;
							IL_0e4e:
							current3 = enumerator2.Current;
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
							{
								num8 = 2;
							}
							goto IL_0e34;
							IL_0e34:
							while (true)
							{
								switch (num8)
								{
								case 3:
									goto IL_0e4e;
								case 2:
									templates.Remove(current3);
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
									{
										num8 = 1;
									}
									continue;
								case 1:
									goto IL_0e99;
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
						int num9;
						if (enumerator2 == null)
						{
							num9 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num9 = 2;
							}
							goto IL_0ee9;
						}
						goto IL_0eff;
						IL_0eff:
						XKiUm64Tg0E7qMd6y6U(enumerator2);
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num9 = 0;
						}
						goto IL_0ee9;
						IL_0ee9:
						switch (num9)
						{
						default:
							goto end_IL_0ec4;
						case 1:
							break;
						case 2:
							goto end_IL_0ec4;
						case 0:
							goto end_IL_0ec4;
						}
						goto IL_0eff;
						end_IL_0ec4:;
					}
					goto case 23;
				case 41:
					if (!Cu4bOZ4JGU7v3eFEkki(lastTemplateLoaded[text], uTIlgZ4Mkp0P8M3Lxop(fileInfo)))
					{
						num2 = 12;
						continue;
					}
					goto case 20;
				case 14:
					try
					{
						while (true)
						{
							IL_0ff3:
							int num5;
							if (!muyrH94XZyHpov9Xaeu(enumerator))
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num5 = 0;
								}
								goto IL_0f9a;
							}
							goto IL_0fdc;
							IL_0fdc:
							current2 = enumerator.Current;
							int num6 = 2;
							num5 = num6;
							goto IL_0f9a;
							IL_0f9a:
							while (true)
							{
								switch (num5)
								{
								case 2:
									customMessages.Remove(current2);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num5 = 3;
									}
									continue;
								case 1:
									goto IL_0fdc;
								case 3:
									goto IL_0ff3;
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
						int num7;
						if (enumerator == null)
						{
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num7 = 1;
							}
							goto IL_1043;
						}
						goto IL_1059;
						IL_1059:
						enumerator.Dispose();
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num7 = 0;
						}
						goto IL_1043;
						IL_1043:
						switch (num7)
						{
						default:
							goto end_IL_101e;
						case 2:
							break;
						case 1:
							goto end_IL_101e;
						case 0:
							goto end_IL_101e;
						}
						goto IL_1059;
						end_IL_101e:;
					}
					goto case 19;
				case 10:
					enumerator2 = value.DefaultTemplates.GetEnumerator();
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 29;
					}
					continue;
				case 25:
					yQWgaw4x6rMgYrQhp9l(directory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633549461));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 24;
					}
					continue;
				case 28:
					enumerator4 = notificationTemplateFileInfo.ExtensionTemplates.GetEnumerator();
					num2 = 35;
					continue;
				case 29:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num3 = 2;
								}
								goto IL_113d;
							}
							goto IL_117d;
							IL_117d:
							current = enumerator2.Current;
							num3 = 3;
							goto IL_113d;
							IL_113d:
							while (true)
							{
								switch (num3)
								{
								case 1:
									goto IL_117d;
								case 3:
									defaultTemplates.Remove(current);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									goto end_IL_1157;
								}
								break;
							}
							continue;
							end_IL_1157:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator2 == null)
						{
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num4 = 2;
							}
							goto IL_11e2;
						}
						goto IL_1217;
						IL_1217:
						XKiUm64Tg0E7qMd6y6U(enumerator2);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num4 = 0;
						}
						goto IL_11e2;
						IL_11e2:
						switch (num4)
						{
						case 2:
							goto end_IL_11bd;
						case 1:
							goto end_IL_11bd;
						}
						goto IL_1217;
						end_IL_11bd:;
					}
					goto case 17;
				case 30:
					enumerator = customMessages.Where((CustomMessage cm) => cm != null).GetEnumerator();
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void CheckTemplates()
	{
		//Discarded unreachable code: IL_0044, IL_00e1, IL_00f0, IL_0168, IL_0177, IL_01ef, IL_01fe, IL_02f8, IL_0330, IL_033f
		int num = 3;
		int num2 = num;
		NotificationTemplateLoader obj = default(NotificationTemplateLoader);
		bool lockTaken = default(bool);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 13;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 11:
							defaultTemplates = null;
							num3 = 4;
							break;
						case 7:
							NqVTiB4r4xT5uEw6UF1(notificationFileInfos);
							num3 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num3 = 14;
							}
							break;
						case 0:
							return;
						case 9:
							extensionTemplates = null;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num3 = 11;
							}
							break;
						case 17:
							YHxZX54gfSDX8mXCXMp(defaultTemplates);
							num3 = 12;
							break;
						case 2:
							if (lastRootLoaded < uTIlgZ4Mkp0P8M3Lxop(directoryInfo))
							{
								num3 = 6;
								break;
							}
							goto case 10;
						case 1:
							notificationFileInfos = null;
							num3 = 3;
							break;
						case 12:
							return;
						case 10:
							waDk8G4jUQGrmd257dU(this, directoryInfo);
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num3 = 8;
							}
							break;
						case 20:
							lastTemplateLoaded = null;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 1;
							}
							break;
						case 6:
							lastLoaded = DateTime.MinValue;
							num3 = 20;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num3 = 5;
							}
							break;
						case 5:
							if (!lOZT7B4SujEYk3NUPiB(templatesPath))
							{
								num3 = 7;
								break;
							}
							goto case 16;
						case 16:
							directoryInfo = new DirectoryInfo(templatesPath);
							num3 = 2;
							break;
						case 15:
							Ja9ZYh45R37h4xdCJl5(extensionTemplates);
							num3 = 17;
							break;
						case 4:
							lastRootLoaded = uTIlgZ4Mkp0P8M3Lxop(directoryInfo);
							num3 = 10;
							break;
						case 13:
							if (!needReloadTemplates)
							{
								return;
							}
							num3 = 18;
							break;
						case 18:
						case 19:
							needReloadTemplates = false;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num3 = 5;
							}
							break;
						case 3:
							templates = null;
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num3 = 7;
							}
							break;
						case 14:
							YHxZX54gfSDX8mXCXMp(templates);
							num3 = 15;
							break;
						case 8:
							return;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Monitor.Exit(obj);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num4 = 0;
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
			case 3:
				if (initialized)
				{
					obj = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 4:
				return;
			default:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected virtual void CheckTemplates(DirectoryInfo directory)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0074, IL_0096
		int num = 7;
		int num2 = num;
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 5:
			case 8:
				PDX9Dw4LjarbltN14YA(this, directory);
				num2 = 4;
				break;
			case 4:
				return;
			default:
				num3 = (Cu4bOZ4JGU7v3eFEkki(lastLoaded, uTIlgZ4Mkp0P8M3Lxop(directory)) ? 1 : 0);
				if (num3 != 0 || lastTemplateLoaded == null)
				{
					goto IL_0141;
				}
				goto IL_014c;
			case 6:
				return;
			case 2:
				if (customMessages != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 7:
				if (initialized)
				{
					if (!H2IPCh4YTUpGpqgcWrq(lastLoaded, DateTime.MinValue))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					num3 = 1;
					goto IL_0141;
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
			case 3:
				{
					customMessages = new List<CustomMessage>();
					num2 = 8;
					break;
				}
				IL_0141:
				lastTemplateLoaded = new Dictionary<string, DateTime>();
				goto IL_014c;
				IL_014c:
				if (num3 != 0 || notificationFileInfos == null)
				{
					notificationFileInfos = new Dictionary<string, NotificationTemplateFileInfo>();
				}
				if (num3 != 0 || templates == null)
				{
					templates = new List<NotificationTemplate>();
				}
				if (num3 != 0 || extensionTemplates == null)
				{
					extensionTemplates = new List<NotificationPartialExtensionTemplate>();
				}
				if (num3 != 0 || defaultTemplates == null)
				{
					defaultTemplates = new List<NotificationTemplate>();
				}
				if (num3 != 0 || H2IPCh4YTUpGpqgcWrq(lastLoaded, DateTime.MinValue))
				{
					lastLoaded = directory.LastWriteTime;
				}
				if (num3 != 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private void WatcherOnChanged(object sender, FileSystemEventArgs args)
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
				needReloadTemplates = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private NotificationTemplateBase CheckTemplate(NotificationTemplate t, INotification notification)
	{
		return CheckTemplate(t, (NotificationTemplateBase)KbyGlj4U60VIJRJWspe(t), notification);
	}

	private NotificationTemplateBase CheckTemplate(NotificationTemplateBase t, NotificationTemplateBase def, INotification notification)
	{
		//Discarded unreachable code: IL_00f9, IL_0108, IL_0190, IL_019f, IL_01bd, IL_01cc, IL_0229, IL_023c
		int num = 5;
		int num2 = num;
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_0);
		List<NotificationTemplate>.Enumerator enumerator = default(List<NotificationTemplate>.Enumerator);
		NotificationTemplateBase result = default(NotificationTemplateBase);
		NotificationTemplateBase notificationTemplateBase2 = default(NotificationTemplateBase);
		NotificationTemplateWrapper t2 = default(NotificationTemplateWrapper);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return notificationTemplateBase;
			case 4:
				_003C_003Ec__DisplayClass34_.t = t;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
				num2 = 4;
				break;
			case 6:
				if (notificationTemplateBase == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 7;
					}
					break;
				}
				_003C_003Ec__DisplayClass34_.name = (string)(bNE8tq4sdfvRkWcy8MJ(_003C_003Ec__DisplayClass34_.t) ?? string.Empty);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass34_.fullName = (string)qMEC6K4po8AI9wBe780(lccpFL4cl053FIJnPPw(_003C_003Ec__DisplayClass34_.t)) + (string)KNLRfh4VHvHHNuvYdpj(-1765851862 ^ -1765844614) + _003C_003Ec__DisplayClass34_.t.Name;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 8;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_0117;
						}
						goto IL_0168;
						IL_0117:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return notificationTemplateBase;
							case 7:
								return result;
							case 2:
							case 4:
								break;
							case 1:
								if (notificationTemplateBase2 == null)
								{
									num3 = 4;
									continue;
								}
								goto default;
							case 6:
								goto IL_0168;
							default:
								result = notificationTemplateBase2;
								num3 = 7;
								continue;
							case 5:
								notificationTemplateBase2 = CheckTemplate(t2, def, notification);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						}
						continue;
						IL_0168:
						t2 = new NotificationTemplateWrapper(enumerator.Current, _003C_003Ec__DisplayClass34_.t);
						int num4 = 5;
						num3 = num4;
						goto IL_0117;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			default:
				notificationTemplateBase = CheckTemplateWithDefault(_003C_003Ec__DisplayClass34_.t, def, notification);
				num2 = 6;
				break;
			case 8:
				enumerator = ((NotificationTemplateFileInfo)lccpFL4cl053FIJnPPw(_003C_003Ec__DisplayClass34_.t)).Templates.Where(_003C_003Ec__DisplayClass34_._003CCheckTemplate_003Eb__0).Union(templates.Where(_003C_003Ec__DisplayClass34_._003CCheckTemplate_003Eb__1)).ToList()
					.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				return null;
			}
		}
	}

	private NotificationTemplateBase CheckTemplateWithDefault(NotificationTemplateBase t, NotificationTemplateBase def, INotification notification)
	{
		//Discarded unreachable code: IL_0069, IL_0078, IL_0083, IL_00ef, IL_00fe, IL_0192, IL_01a5, IL_02d7, IL_02e6
		int num = 2;
		NotificationTemplateWrapper notificationTemplateWrapper = default(NotificationTemplateWrapper);
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		List<NotificationTemplate>.Enumerator enumerator = default(List<NotificationTemplate>.Enumerator);
		NotificationTemplateWrapper def2 = default(NotificationTemplateWrapper);
		NotificationTemplateBase result = default(NotificationTemplateBase);
		NotificationTemplateBase notificationTemplateBase = default(NotificationTemplateBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (!XFyDOD4zbpQGTV3wUDT(notificationTemplateWrapper, notification))
					{
						num2 = 3;
						continue;
					}
					_003C_003Ec__DisplayClass35_.name = (string)(bNE8tq4sdfvRkWcy8MJ(_003C_003Ec__DisplayClass35_.def) ?? string.Empty);
					num2 = 7;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_0109:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
								{
									num3 = 1;
								}
								goto IL_0087;
							}
							goto IL_00ad;
							IL_00ad:
							def2 = new NotificationTemplateWrapper(enumerator.Current, _003C_003Ec__DisplayClass35_.def);
							num3 = 5;
							goto IL_0087;
							IL_0087:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 3:
									result = notificationTemplateBase;
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num3 = 6;
									}
									continue;
								default:
									goto IL_0109;
								case 4:
									if (notificationTemplateBase != null)
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto IL_0109;
								case 5:
									notificationTemplateBase = CheckTemplateWithDefault(t, def2, notification);
									num3 = 4;
									continue;
								case 1:
									return notificationTemplateWrapper;
								case 6:
									return result;
								}
								break;
							}
							goto IL_00ad;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 1:
					_003C_003Ec__DisplayClass35_.def = def;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (_003C_003Ec__DisplayClass35_.def != null)
					{
						num2 = 6;
						continue;
					}
					goto case 11;
				case 7:
					_003C_003Ec__DisplayClass35_.fullName = (string)jbOItX6FwwZ2HoWy8yJ(_003C_003Ec__DisplayClass35_.def.FileInfo.Name, KNLRfh4VHvHHNuvYdpj(-583745292 ^ -583752540), _003C_003Ec__DisplayClass35_.name);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					enumerator = ((NotificationTemplateFileInfo)lccpFL4cl053FIJnPPw(_003C_003Ec__DisplayClass35_.def)).DefaultTemplates.Where(_003C_003Ec__DisplayClass35_._003CCheckTemplateWithDefault_003Eb__0).Union(defaultTemplates.Where(_003C_003Ec__DisplayClass35_._003CCheckTemplateWithDefault_003Eb__1)).ToList()
						.GetEnumerator();
					num2 = 5;
					continue;
				case 11:
					if (XFyDOD4zbpQGTV3wUDT(t, notification))
					{
						num = 8;
						break;
					}
					return null;
				case 10:
					return notificationTemplateWrapper;
				case 8:
					return t;
				case 6:
					notificationTemplateWrapper = new NotificationTemplateWrapper(t, _003C_003Ec__DisplayClass35_.def);
					num = 9;
					break;
				case 2:
					_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return null;
				}
				break;
			}
		}
	}

	internal static bool TrK6we4G5Mqvl8COip8()
	{
		return LS6W7s4hlHMu0BmJCaO == null;
	}

	internal static NotificationTemplateLoader bnn8Wj4ErpmxG7LNKBS()
	{
		return LS6W7s4hlHMu0BmJCaO;
	}

	internal static object gE2rxr4f1VDEH6YnrDP(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static int Oa5EhP4Q1ZlU1UBINoX(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object dplOjV4CRrLiIub3wpI(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static bool gPUbjT4vxK0PKbOkMo8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static int q35Kel48Hc05ZdORl0D(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object rEYKQt4ZjViYyWPnbtt(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object pLugl84uRylQhn84D0F(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object qVtwgx4Il76svkK8Aw0(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object KNLRfh4VHvHHNuvYdpj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool lOZT7B4SujEYk3NUPiB(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object FH5Qgp4iRAFZNKVQ5kG(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object ku4Bjy4RBgnKwpEvMIm(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void jQrJAF4qpcddGCXPLgX(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void bL8e3u4K3hmBKn9fQU6(object P_0, object P_1)
	{
		((NotificationTemplateLoader)P_0).CheckTemplateFileInfo((NotificationTemplateFileInfo)P_1);
	}

	internal static bool muyrH94XZyHpov9Xaeu(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void XKiUm64Tg0E7qMd6y6U(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void v204Ho4k2m6WeHc51DR(object P_0, bool P_1)
	{
		((FileSystemWatcher)P_0).EnableRaisingEvents = P_1;
	}

	internal static void FGYea74nyNOUqy7Z7EJ(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static void yM8W1m4OFSEj8tUjUe2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void eATWvX42g29sKd9aJlv(object P_0, NotifyFilters P_1)
	{
		((FileSystemWatcher)P_0).NotifyFilter = P_1;
	}

	internal static void MOhx9G4eXNKPQVhAxxY(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Filter = (string)P_1;
	}

	internal static void bOo7v84PFbc8V0E6SRv(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Changed += (FileSystemEventHandler)P_1;
	}

	internal static void uDJMeD41nwcnONeRyVp(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Created += (FileSystemEventHandler)P_1;
	}

	internal static void p5XDS74NmG8HU0ZySyC(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Renamed += (RenamedEventHandler)P_1;
	}

	internal static object pLso0143vBSMT792mUw(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object qMEC6K4po8AI9wBe780(object P_0)
	{
		return ((NotificationTemplateFileInfo)P_0).Name;
	}

	internal static object aR2dDi4a19s9qgF6tC1(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object O6sjHa4D5WOAMyvRytj(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool F7SpWa4tf1xlR9Vk5gt(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void I7sXvl4wm0Au3Hui6hy(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object syFJjB44tEhEWJywNVq(object P_0)
	{
		return ((NotificationTemplateFileInfo)P_0).Document;
	}

	internal static object G25PIE46HIbxaEMo2PG()
	{
		return Logger.Log;
	}

	internal static bool HSbQWp4HThcBwBReTMF(object P_0, object P_1)
	{
		return (Version)P_0 != (Version)P_1;
	}

	internal static void puYhYO4AJKoRYsp7d07(object P_0, object P_1)
	{
		File.Move((string)P_0, (string)P_1);
	}

	internal static void DdPoUX47S2nLbvggK6U(object P_0, object P_1)
	{
		((XmlDocument)P_0).Save((string)P_1);
	}

	internal static void yQWgaw4x6rMgYrQhp9l(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object lhCATO40AnpPbUgNxVm(object P_0, object P_1)
	{
		return ((DirectoryInfo)P_0).GetFiles((string)P_1);
	}

	internal static object FTXAwJ4mxZ9MvLcoAhB(object P_0)
	{
		return ((FileSystemInfo)P_0).Name;
	}

	internal static object ltFw8x4yyaV0rggrEva(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static DateTime uTIlgZ4Mkp0P8M3Lxop(object P_0)
	{
		return ((FileSystemInfo)P_0).LastWriteTime;
	}

	internal static bool Cu4bOZ4JGU7v3eFEkki(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static object O7Lk4149UecZWaw9rmU(object P_0)
	{
		return ((FileSystemInfo)P_0).FullName;
	}

	internal static void xiNRsZ4ddtwET8yOuvp(object P_0, object P_1)
	{
		((NotificationTemplateFileInfo)P_0).LoadTemplates((NotificationTemplateLoader)P_1);
	}

	internal static object aZujkA4lMI4RRdZ9Naf(object P_0)
	{
		return ((List<CustomMessage>)P_0).ToArray();
	}

	internal static void NqVTiB4r4xT5uEw6UF1(object P_0)
	{
		((Dictionary<string, NotificationTemplateFileInfo>)P_0).Clear();
	}

	internal static void YHxZX54gfSDX8mXCXMp(object P_0)
	{
		((List<NotificationTemplate>)P_0).Clear();
	}

	internal static void Ja9ZYh45R37h4xdCJl5(object P_0)
	{
		((List<NotificationPartialExtensionTemplate>)P_0).Clear();
	}

	internal static void waDk8G4jUQGrmd257dU(object P_0, object P_1)
	{
		((NotificationTemplateLoader)P_0).CheckTemplates((DirectoryInfo)P_1);
	}

	internal static bool H2IPCh4YTUpGpqgcWrq(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static void PDX9Dw4LjarbltN14YA(object P_0, object P_1)
	{
		((NotificationTemplateLoader)P_0).CheckFiles((DirectoryInfo)P_1);
	}

	internal static object KbyGlj4U60VIJRJWspe(object P_0)
	{
		return ((NotificationTemplate)P_0).Default;
	}

	internal static object bNE8tq4sdfvRkWcy8MJ(object P_0)
	{
		return ((NotificationTemplateBase)P_0).Name;
	}

	internal static object lccpFL4cl053FIJnPPw(object P_0)
	{
		return ((NotificationTemplateBase)P_0).FileInfo;
	}

	internal static bool XFyDOD4zbpQGTV3wUDT(object P_0, object P_1)
	{
		return ((NotificationTemplateBase)P_0).CheckFilter((INotification)P_1);
	}

	internal static object jbOItX6FwwZ2HoWy8yJ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
