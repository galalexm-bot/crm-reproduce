using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.Helper;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
internal sealed class ConfigurationUnpackService : IConfigurationUnpackService
{
	private sealed class ExportImportTempFolderTracer : IDisposable
	{
		private List<string> tmpFolderPaths;

		private readonly object exportImportTempFolder;

		internal static object O1IWJ58e5AObEr6oWJb2;

		internal ExportImportTempFolderTracer()
		{
			//Discarded unreachable code: IL_003a
			jmgZaE8eLu2mC1DEcA8w();
			tmpFolderPaths = new List<string>();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					exportImportTempFolder = u3ZH588ecTlKkyEVePBK(UR8umP8eUwWUdPGtcTZj(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488894401), LJM0B68esSEmetePr1hS(-2106517564 ^ -2106267728));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num = 0;
					}
					break;
				case 2:
				{
					JW1rtB8PFnsjr4aJnHOu(exportImportTempFolder);
					int num2 = 3;
					num = num2;
					break;
				}
				case 3:
					return;
				default:
					if (zKXFfq8ez4f0UDIp0SLC(exportImportTempFolder))
					{
						return;
					}
					num = 2;
					break;
				}
			}
		}

		public void Dispose()
		{
			CleanTempFolders();
		}

		internal string GetTempUniqueFolder(string prefix)
		{
			int num = 1;
			int num2 = num;
			string tempUniqueFolder = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					tmpFolderPaths.Add(tempUniqueFolder);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					tempUniqueFolder = ExportImportTempFolderHelper.GetTempUniqueFolder((string)exportImportTempFolder, prefix);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return tempUniqueFolder;
				}
			}
		}

		private void CleanTempFolders()
		{
			int num = 2;
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
					EOWBjw8PBrpY6K2dLffb(tmpFolderPaths);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					tmpFolderPaths.ForEach(delegate(string item)
					{
						//Discarded unreachable code: IL_006f, IL_00a2, IL_010c, IL_011b
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (!_003C_003Ec.OIPe8dZ20FkCFSZnGY8N(item))
								{
									return;
								}
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num4 = 0;
								}
								break;
							default:
								try
								{
									_003C_003Ec.w9VAsYZ2mXFKr3isC0FD(item, true);
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
									return;
								}
								catch (Exception ex)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											_003C_003Ec.mXyPFcZ2J8BAGxR9SHMB(Logger.Log, SR.T((string)_003C_003Ec.pKG3w0Z2y6n3gGwg5tik(0x7C1EE318 ^ 0x7C18D044), _003C_003Ec.sIf3vdZ2MjXDS6apWcEK(ex)));
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
											{
												num6 = 1;
											}
											break;
										case 1:
											return;
										}
									}
								}
							case 2:
								return;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void jmgZaE8eLu2mC1DEcA8w()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object UR8umP8eUwWUdPGtcTZj()
		{
			return Path.GetTempPath();
		}

		internal static object LJM0B68esSEmetePr1hS(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object u3ZH588ecTlKkyEVePBK(object P_0, object P_1, object P_2)
		{
			return Path.Combine((string)P_0, (string)P_1, (string)P_2);
		}

		internal static bool zKXFfq8ez4f0UDIp0SLC(object P_0)
		{
			return Directory.Exists((string)P_0);
		}

		internal static object JW1rtB8PFnsjr4aJnHOu(object P_0)
		{
			return Directory.CreateDirectory((string)P_0);
		}

		internal static bool tjqhS28ejaKedA5iwL7y()
		{
			return O1IWJ58e5AObEr6oWJb2 == null;
		}

		internal static ExportImportTempFolderTracer XZZMY48eY3pYbixRG8yP()
		{
			return (ExportImportTempFolderTracer)O1IWJ58e5AObEr6oWJb2;
		}

		internal static void EOWBjw8PBrpY6K2dLffb(object P_0)
		{
			((List<string>)P_0).Clear();
		}
	}

	private sealed class ConfigurationUnpacker
	{
		private readonly object fileService;

		private readonly object moduleMetadataExtractorService;

		private readonly object tagService;

		private readonly object zipService;

		private readonly object moduleManager;

		private readonly object logger;

		private readonly bool checkManifests;

		private readonly bool tagFilter;

		private readonly List<string> allErrors;

		private readonly List<string> allWarnings;

		private readonly object rootSettings;

		private object rootLocalFile;

		private List<string> extractedFiles;

		private List<ElmaStoreComponentManifest> loadedManifests;

		private List<ConfigImportSettings> allSettings;

		private Dictionary<ElmaStoreComponentManifest, string> localFiles;

		private object tempFolderTracer;

		internal static object zx8ius8PWoM3KRUAdSLy;

		public ConfigurationUnpacker(IExportImportFileService fileService, IModuleMetadataExtractorService moduleMetadataExtractorService, ITagService tagService, IZipService zipService, IModuleDTOManager moduleManager, ILogger logger, bool checkManifests, bool tagFilter)
		{
			//Discarded unreachable code: IL_004a
			uNU9RE8PhEyuGgw27T4t();
			allErrors = new List<string>();
			allWarnings = new List<string>();
			rootSettings = new ConfigImportSettings();
			base._002Ector();
			int num = 9;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 6:
					tempFolderTracer = new ExportImportTempFolderTracer();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num = 0;
					}
					break;
				case 5:
					this.moduleManager = moduleManager;
					num = 3;
					break;
				case 2:
					this.tagService = tagService;
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num = 0;
					}
					break;
				case 4:
					this.zipService = zipService;
					num = 5;
					break;
				case 1:
					this.checkManifests = checkManifests;
					num = 7;
					break;
				case 0:
					return;
				case 3:
					this.logger = logger;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num = 1;
					}
					break;
				case 8:
				{
					this.moduleMetadataExtractorService = moduleMetadataExtractorService;
					int num2 = 2;
					num = num2;
					break;
				}
				case 7:
					this.tagFilter = tagFilter;
					num = 6;
					break;
				case 9:
					this.fileService = fileService;
					num = 8;
					break;
				}
			}
		}

		public IEnumerable<ConfigImportSettings> Unpack(BinaryFile file)
		{
			try
			{
				IEnumerable<ConfigImportSettings> result = DoUnpack(file);
				if (allErrors.Any())
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571B5309)));
				}
				return result;
			}
			catch (Exception ex)
			{
				throw new ConfigurationUnpackException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7AC2C2), ex.Message), ex, allWarnings, allErrors);
			}
			finally
			{
				((ExportImportTempFolderTracer)tempFolderTracer).Dispose();
			}
		}

		private IEnumerable<ConfigImportSettings> DoUnpack(BinaryFile file)
		{
			rootLocalFile = UploadFile((ConfigImportSettings)rootSettings, file);
			allSettings = new List<ConfigImportSettings>();
			((ConfigImportSettings)rootSettings).Manifest = ElmaStoreComponentsBuilder.Read((string)rootLocalFile);
			((ConfigImportSettings)rootSettings).FakeManifest.DisplayName = Path.GetFileNameWithoutExtension(file.Name);
			bool flag = false;
			if (((ConfigImportSettings)rootSettings).Manifest != null && ((ConfigImportSettings)rootSettings).Manifest.BpmApps != null && ((ConfigImportSettings)rootSettings).Manifest.BpmApps.Any())
			{
				List<string> files = new List<string>();
				List<string> activationKeys = (from a in ComponentManager.Current.LicenseManager.GetActivationKeys()
					select a.Value).ToList();
				List<ValidateTreeItem> items = ElmaStoreComponentsBuilder.ExtractAndValidateOnComponent(new List<string> { (string)rootLocalFile }, ((ExportImportTempFolderTracer)tempFolderTracer).GetTempUniqueFolder, activationKeys, ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration);
				ValidateTags(items, files, 0);
				extractedFiles = files;
				loadedManifests = DownloadManifestsLocal();
				flag = true;
				((ConfigImportSettings)rootSettings).Manifest = null;
			}
			if (((ConfigImportSettings)rootSettings).Manifest != null && !string.IsNullOrEmpty(((ConfigImportSettings)rootSettings).Manifest.BPMAppManifest))
			{
				AddMessages(BPMAppManifestSerializationHelper.ValidateChaptersXsiTypes(((ConfigImportSettings)rootSettings).Manifest.BPMAppManifest));
			}
			else if (loadedManifests != null)
			{
				foreach (ElmaStoreComponentManifest loadedManifest in loadedManifests)
				{
					AddMessages(BPMAppManifestSerializationHelper.ValidateChaptersXsiTypes(loadedManifest.BPMAppManifest));
				}
			}
			if (flag)
			{
				ExecuteLoadComponents();
			}
			else
			{
				if (((ConfigImportSettings)rootSettings).Manifest != null)
				{
					ValidateComponents(new List<ElmaStoreComponentManifest> { ((ConfigImportSettings)rootSettings).Manifest });
				}
				allSettings.Add((ConfigImportSettings)rootSettings);
			}
			allSettings.ForEach(delegate(ConfigImportSettings s)
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
						_003C_003Ec.gpnZXTZ25VJIq6mkTenx(_003C_003Ec.mgcTw7Z2gHyyUiFuL7OB(s), s.FileName);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
			return allSettings;
		}

		private void AddMessages(IEnumerable<TestImportMessages> messages)
		{
			if (messages == null)
			{
				return;
			}
			foreach (TestImportMessages message in messages)
			{
				if (message.Type == TestImportMessagesType.Error)
				{
					AddErrors(new string[1] { message.Text });
				}
				if (message.Type == TestImportMessagesType.Warning)
				{
					AddWarnings(new string[1] { message.Text });
				}
			}
		}

		private string UploadFile(ConfigImportSettings importSettings, BinaryFile file)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					((IExportImportFileService)fileService).AddToFile((string)f0tR9F8PGyvJymH49uQO(importSettings), file);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					((IExportImportFileService)fileService).DeleteFiles((string)f0tR9F8PGyvJymH49uQO(importSettings));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return (string)uGiOtG8PEJFFhepviIZm(fileService, f0tR9F8PGyvJymH49uQO(importSettings));
				}
			}
		}

		private void ValidateTags(List<ValidateTreeItem> items, List<string> files, int level)
		{
			_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
			CS_0024_003C_003E8__locals0.files = files;
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.level = level;
			CS_0024_003C_003E8__locals0.level++;
			if (CS_0024_003C_003E8__locals0.level > 100)
			{
				throw new NestingLevelException();
			}
			items.ForEach(delegate(ValidateTreeItem item)
			{
				//Discarded unreachable code: IL_00c6, IL_0131, IL_013b, IL_026f, IL_027e, IL_028e, IL_029d, IL_02f5, IL_0308, IL_0366, IL_0375
				int num = 12;
				List<TestImportMessages> messages = default(List<TestImportMessages>);
				List<TestImportMessages>.Enumerator enumerator = default(List<TestImportMessages>.Enumerator);
				TestImportMessagesType type = default(TestImportMessagesType);
				TestImportMessages current = default(TestImportMessages);
				while (true)
				{
					int num2 = num;
					List<TestImportMessages> list;
					List<ValidateMessage> messages2;
					Func<ValidateMessage, TestImportMessages> selector;
					while (true)
					{
						switch (num2)
						{
						case 4:
							CS_0024_003C_003E8__locals0._003C_003E4__this.ValidateTags(item.Items, CS_0024_003C_003E8__locals0.files, CS_0024_003C_003E8__locals0.level);
							num2 = 7;
							continue;
						case 13:
							return;
						case 11:
							if (!CS_0024_003C_003E8__locals0._003C_003E4__this.tagFilter)
							{
								num2 = 6;
							}
							else
							{
								((ITagService)CS_0024_003C_003E8__locals0._003C_003E4__this.tagService).ValidateTags(item.Manifest, out messages);
								num2 = 8;
							}
							continue;
						case 6:
							CS_0024_003C_003E8__locals0.files.Add((string)_003C_003Ec__DisplayClass22_0.fENeG8ZeBLe6uwohQUCo(item));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num2 = 1;
							}
							continue;
						case 2:
							return;
						case 1:
							CS_0024_003C_003E8__locals0._003C_003E4__this.ValidateTags(item.Items, CS_0024_003C_003E8__locals0.files, CS_0024_003C_003E8__locals0.level);
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num2 = 2;
							}
							continue;
						case 10:
							try
							{
								while (true)
								{
									int num3;
									if (!enumerator.MoveNext())
									{
										num3 = 8;
										goto IL_013f;
									}
									goto IL_0216;
									IL_013f:
									while (true)
									{
										switch (num3)
										{
										case 4:
										case 5:
										case 10:
											break;
										default:
											type = current.Type;
											num3 = 3;
											continue;
										case 3:
											if (type != TestImportMessagesType.Warning)
											{
												num3 = 9;
												continue;
											}
											goto case 6;
										case 6:
											((ILogger)CS_0024_003C_003E8__locals0._003C_003E4__this.logger).Warn(current.Text);
											num3 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
											{
												num3 = 5;
											}
											continue;
										case 1:
											((ILogger)CS_0024_003C_003E8__locals0._003C_003E4__this.logger).Error(_003C_003Ec__DisplayClass22_0.ILobHIZeWpY4gpUOnesj(current));
											num3 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
											{
												num3 = 6;
											}
											continue;
										case 7:
											goto IL_0216;
										case 2:
										case 11:
											_003C_003Ec__DisplayClass22_0.sf4QncZeoaDnidlLfGJj(CS_0024_003C_003E8__locals0._003C_003E4__this.logger, _003C_003Ec__DisplayClass22_0.ILobHIZeWpY4gpUOnesj(current));
											num3 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
											{
												num3 = 1;
											}
											continue;
										case 9:
											if (type != TestImportMessagesType.Error)
											{
												num3 = 9;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
												{
													num3 = 11;
												}
												continue;
											}
											goto case 1;
										case 8:
											goto end_IL_0179;
										}
										break;
									}
									continue;
									IL_0216:
									current = enumerator.Current;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num3 = 0;
									}
									goto IL_013f;
									continue;
									end_IL_0179:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							break;
						case 9:
							return;
						default:
							CS_0024_003C_003E8__locals0.files.Add((string)_003C_003Ec__DisplayClass22_0.fENeG8ZeBLe6uwohQUCo(item));
							num2 = 4;
							continue;
						case 12:
							if (CS_0024_003C_003E8__locals0.files.Contains((string)_003C_003Ec__DisplayClass22_0.fENeG8ZeBLe6uwohQUCo(item)))
							{
								return;
							}
							num2 = 11;
							continue;
						case 5:
							enumerator = messages.GetEnumerator();
							num2 = 10;
							continue;
						case 7:
							return;
						case 8:
							list = messages;
							messages2 = item.Messages;
							selector = delegate(ValidateMessage m)
							{
								//Discarded unreachable code: IL_00ed, IL_011e
								int num5 = 3;
								int num6 = num5;
								ValidateMessageCode validateMessageCode = default(ValidateMessageCode);
								TestImportMessages testImportMessages = default(TestImportMessages);
								while (true)
								{
									switch (num6)
									{
									case 2:
										validateMessageCode = _003C_003Ec.BTYPdCZ2jtuOZWBvqxQZ(m);
										num6 = 9;
										break;
									case 4:
									case 5:
									case 6:
										_003C_003Ec.nvhoOIZ2UKfTSiUeFTCk(testImportMessages, _003C_003Ec.HJaca6Z2LLMgvPW17YLx(m));
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
										{
											num6 = 1;
										}
										break;
									case 10:
										if (validateMessageCode == ValidateMessageCode.Error)
										{
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
											{
												num6 = 0;
											}
											break;
										}
										goto case 7;
									case 3:
										testImportMessages = new TestImportMessages();
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
										{
											num6 = 2;
										}
										break;
									case 7:
										_003C_003Ec.vyTreCZ2YgkIl3bs7SYw(testImportMessages, TestImportMessagesType.InfoCommon);
										num6 = 4;
										break;
									case 8:
										testImportMessages.Type = TestImportMessagesType.Warning;
										num6 = 5;
										break;
									default:
										_003C_003Ec.vyTreCZ2YgkIl3bs7SYw(testImportMessages, TestImportMessagesType.Error);
										num6 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
										{
											num6 = 6;
										}
										break;
									case 9:
										if (validateMessageCode != ValidateMessageCode.Warning)
										{
											num6 = 10;
											break;
										}
										goto case 8;
									case 1:
										return testImportMessages;
									}
								}
							};
							goto end_IL_0012;
						case 3:
							break;
						}
						if (messages.Any((TestImportMessages m) => _003C_003Ec.ju7dsiZ2sTUDy4geJlIh(m) == TestImportMessagesType.Error))
						{
							return;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						continue;
						end_IL_0012:
						break;
					}
					list.AddRange(messages2.Select(selector));
					num = 5;
				}
			});
		}

		private List<ElmaStoreComponentManifest> DownloadManifestsLocal()
		{
			List<ElmaStoreComponentManifest> list = new List<ElmaStoreComponentManifest>();
			List<string> list2 = new List<string>();
			foreach (string extractedFile in extractedFiles)
			{
				_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
				CS_0024_003C_003E8__locals0.tmpDirPath = ((ExportImportTempFolderTracer)tempFolderTracer).GetTempUniqueFolder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606945222));
				((IZipService)zipService).ExtractZipFolder(extractedFile, CS_0024_003C_003E8__locals0.tmpDirPath);
				string[] array = Directory.GetFiles(CS_0024_003C_003E8__locals0.tmpDirPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87120589)).Union(ElmaStoreComponentFile.SupportedManifestMask.SelectMany((string mask) => Directory.GetFiles(CS_0024_003C_003E8__locals0.tmpDirPath, mask))).ToArray();
				if (array.Length != 0)
				{
					list2.Add(array.First());
				}
			}
			ParseComponentFiles(list2, list);
			return list;
		}

		private void ParseComponentFiles(List<string> files, List<ElmaStoreComponentManifest> manifests)
		{
			foreach (string file in files)
			{
				try
				{
					ElmaStoreComponentManifest item = ManifestBuilder.DeserializeByXmlFromFile<ElmaStoreComponentManifest>(file);
					manifests.Add(item);
				}
				catch (Exception ex)
				{
					Logger.Log.Error(ex.Message, ex);
				}
			}
		}

		private void ValidateComponents(List<ElmaStoreComponentManifest> components)
		{
			if (!checkManifests || ConfigurationUnpackService.ValidateComponents((IEnumerable<ElmaStoreComponentManifest>)components, ((IModuleDTOManager)moduleManager).GetInstalledComponentManifests(), out List<string> warnings, out List<string> errors))
			{
				return;
			}
			AddErrors(errors);
			AddWarnings(warnings);
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853130722)));
		}

		private void AddErrors(IEnumerable<string> errors)
		{
			foreach (string error in errors)
			{
				((ILogger)logger).Error(error);
			}
			allErrors.AddRange(errors);
		}

		private void AddWarnings(IEnumerable<string> warnings)
		{
			foreach (string warning in warnings)
			{
				((ILogger)logger).Warn(warning);
			}
			allWarnings.AddRange(warnings);
		}

		private void ExecuteLoadComponents()
		{
			//Discarded unreachable code: IL_0049, IL_0059, IL_0063, IL_020a, IL_0219, IL_027c, IL_028f, IL_02cc, IL_02db, IL_03e0, IL_03ef, IL_04b1, IL_04f1, IL_0500
			int num = 6;
			List<ElmaStoreComponentManifest>.Enumerator enumerator2 = default(List<ElmaStoreComponentManifest>.Enumerator);
			_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
			int num4 = default(int);
			ElmaStoreComponentManifest manifest = default(ElmaStoreComponentManifest);
			List<string> errors = default(List<string>);
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			ConfigImportSettings configImportSettings = default(ConfigImportSettings);
			string current = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						try
						{
							while (true)
							{
								int num3;
								if (!enumerator2.MoveNext())
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
									{
										num3 = 1;
									}
									goto IL_0067;
								}
								goto IL_0155;
								IL_0155:
								_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
								num3 = 3;
								goto IL_0067;
								IL_0067:
								while (true)
								{
									switch (num3)
									{
									case 2:
										throw new InvalidOperationException((string)dNqKTg8PffEGoZHer2O0(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x7695E94)));
									default:
										num4++;
										num3 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
										{
											num3 = 9;
										}
										continue;
									case 6:
									{
										manifest = ((IModuleDTOManager)moduleManager).GetManifest((string)smadog8PQJYgLDdEXeEV(_003C_003Ec__DisplayClass28_.componentManifest), out bool _);
										num3 = 9;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
										{
											num3 = 9;
										}
										continue;
									}
									case 10:
										break;
									case 3:
										_003C_003Ec__DisplayClass28_.componentManifest = enumerator2.Current;
										num3 = 5;
										continue;
									case 4:
										goto IL_0155;
									case 5:
										if (localFiles.Keys.All(_003C_003Ec__DisplayClass28_._003CExecuteLoadComponents_003Eb__0))
										{
											num3 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
											{
												num3 = 2;
											}
											continue;
										}
										goto default;
									case 8:
									case 11:
										AddErrors(new string[1] { SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138578364), rPMuNu8PCOstx1xsYHcQ(_003C_003Ec__DisplayClass28_.componentManifest), smadog8PQJYgLDdEXeEV(_003C_003Ec__DisplayClass28_.componentManifest)) });
										num3 = 2;
										continue;
									case 9:
										if (manifest == null)
										{
											num3 = 11;
											continue;
										}
										goto case 7;
									case 7:
										loadedManifests[num4] = manifest;
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
										{
											num3 = 0;
										}
										continue;
									case 1:
										goto end_IL_0117;
									}
									break;
								}
								continue;
								end_IL_0117:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator2).Dispose();
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
						goto case 9;
					case 5:
						if (DownloadComponentsLocal(out localFiles, out errors))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					default:
						try
						{
							while (true)
							{
								IL_0475:
								int num6;
								if (!enumerator.MoveNext())
								{
									num6 = 8;
									goto IL_02ea;
								}
								goto IL_0391;
								IL_02ea:
								while (true)
								{
									switch (num6)
									{
									case 7:
									{
										configImportSettings = ClassSerializationHelper.CloneObject((ConfigImportSettings)rootSettings);
										int num7 = 9;
										num6 = num7;
										continue;
									}
									case 12:
										UploadFile(configImportSettings, new BinaryFile(current));
										num6 = 6;
										continue;
									case 1:
									case 5:
										MWMvBe8Pu6YYtXOYZoHb(configImportSettings, E6JkVj8PZUQrFnFj9nP1(current));
										num6 = 4;
										continue;
									case 9:
										if (current == (string)rootLocalFile)
										{
											num6 = 2;
											continue;
										}
										goto case 3;
									case 6:
										allSettings.Add(configImportSettings);
										num6 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
										{
											num6 = 5;
										}
										continue;
									case 2:
										RHytFc8PvjIQqSlXufo9(configImportSettings, f0tR9F8PGyvJymH49uQO(rootSettings));
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
										{
											num6 = 0;
										}
										continue;
									case 11:
										if (reVpsQ8PSQD9RdsDAtIi(current, rootLocalFile))
										{
											num6 = 12;
											continue;
										}
										goto case 6;
									case 3:
										E78L4D8P8EHnARTlY69d(configImportSettings);
										num6 = 5;
										continue;
									case 4:
										IIu5if8PV2lYjbnvOhxX(xb2sfQ8PIGjK9jdPlQsm(configImportSettings), rPMuNu8PCOstx1xsYHcQ(configImportSettings.Manifest));
										num6 = 11;
										continue;
									case 10:
										goto IL_0475;
									case 8:
										return;
									}
									break;
								}
								goto IL_0391;
								IL_0391:
								current = enumerator.Current;
								num6 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num6 = 7;
								}
								goto IL_02ea;
							}
						}
						finally
						{
							int num8;
							if (enumerator == null)
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num8 = 0;
								}
								goto IL_04b5;
							}
							goto IL_04cb;
							IL_04cb:
							enumerator.Dispose();
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
							{
								num8 = 1;
							}
							goto IL_04b5;
							IL_04b5:
							switch (num8)
							{
							default:
								goto end_IL_0490;
							case 2:
								break;
							case 0:
								goto end_IL_0490;
							case 1:
								goto end_IL_0490;
							}
							goto IL_04cb;
							end_IL_0490:;
						}
					case 9:
						ValidateComponents(loadedManifests);
						num2 = 3;
						continue;
					case 8:
						break;
					case 6:
						localFiles = new Dictionary<ElmaStoreComponentManifest, string>();
						num2 = 5;
						continue;
					case 2:
						return;
					case 4:
						throw new InvalidOperationException((string)dNqKTg8PffEGoZHer2O0(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766142900)));
					case 1:
					{
						List<ElmaStoreComponentManifest> list = loadedManifests.ToList();
						num4 = 0;
						enumerator2 = list.GetEnumerator();
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					case 3:
						enumerator = localFiles.Values.Distinct().GetEnumerator();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				AddErrors(errors);
				num = 4;
			}
		}

		private bool DownloadComponentsLocal(out Dictionary<ElmaStoreComponentManifest, string> localFileNames, out List<string> errors)
		{
			//Discarded unreachable code: IL_0060, IL_007c, IL_008b, IL_0096, IL_0154, IL_019d, IL_0296, IL_02d6, IL_02e5, IL_02f1, IL_0300, IL_0337, IL_034a, IL_0359, IL_0375, IL_040a, IL_0419, IL_0486, IL_0495, IL_04a0, IL_053f, IL_0552, IL_0561
			int num = 3;
			ElmaStoreComponentManifest elmaStoreComponentManifest2 = default(ElmaStoreComponentManifest);
			string current2 = default(string);
			IEnumerator<ModuleVersion> enumerator3 = default(IEnumerator<ModuleVersion>);
			Dictionary<ElmaStoreComponentManifest, string> dictionary = default(Dictionary<ElmaStoreComponentManifest, string>);
			ElmaStoreComponentManifest elmaStoreComponentManifest = default(ElmaStoreComponentManifest);
			ModuleVersion current3 = default(ModuleVersion);
			bool result = default(bool);
			List<ElmaStoreComponentManifest>.Enumerator enumerator = default(List<ElmaStoreComponentManifest>.Enumerator);
			ElmaStoreComponentManifest current = default(ElmaStoreComponentManifest);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						try
						{
							List<string>.Enumerator enumerator2 = extractedFiles.GetEnumerator();
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num5 = 1;
							}
							switch (num5)
							{
							case 1:
								try
								{
									while (true)
									{
										IL_0181:
										int num6;
										if (!enumerator2.MoveNext())
										{
											num6 = 4;
											goto IL_009a;
										}
										goto IL_015e;
										IL_009a:
										while (true)
										{
											switch (num6)
											{
											case 8:
												elmaStoreComponentManifest2 = (ElmaStoreComponentManifest)E6JkVj8PZUQrFnFj9nP1(current2);
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
												{
													num6 = 3;
												}
												continue;
											default:
												enumerator3 = ((IModuleMetadataExtractorService)moduleMetadataExtractorService).ExtractModules(current2).GetEnumerator();
												num6 = 5;
												continue;
											case 3:
												if (elmaStoreComponentManifest2 == null)
												{
													num6 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
													{
														num6 = 1;
													}
													continue;
												}
												goto case 2;
											case 2:
												dictionary.Add(elmaStoreComponentManifest2, current2);
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
												{
													num6 = 0;
												}
												continue;
											case 6:
												break;
											case 1:
											case 7:
												goto IL_0181;
											case 5:
												try
												{
													while (true)
													{
														int num7;
														if (!zlQd9m8PKVhZxdWKYd12(enumerator3))
														{
															num7 = 3;
															goto IL_01ab;
														}
														goto IL_0208;
														IL_01ab:
														while (true)
														{
															switch (num7)
															{
															case 1:
																break;
															case 4:
																dictionary[elmaStoreComponentManifest] = current2;
																num7 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
																{
																	num7 = 0;
																}
																continue;
															case 2:
																goto IL_0208;
															case 5:
															{
																elmaStoreComponentManifest = new ElmaStoreComponentManifest
																{
																	Version = IPA1pt8PR2uMjeJZhEcB(oaUcEC8PiFxMkITkvSjV(current3)).ToString(),
																	Id = ((NamedMetadata)US2UMR8PqpREKTRw8k8A(current3)).Name
																};
																int num8 = 4;
																num7 = num8;
																continue;
															}
															default:
																loadedManifests.Add(elmaStoreComponentManifest);
																num7 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
																{
																	num7 = 1;
																}
																continue;
															case 3:
																goto end_IL_01cd;
															}
															break;
														}
														continue;
														IL_0208:
														current3 = enumerator3.Current;
														num7 = 5;
														goto IL_01ab;
														continue;
														end_IL_01cd:
														break;
													}
												}
												finally
												{
													int num9;
													if (enumerator3 == null)
													{
														num9 = 2;
														goto IL_029a;
													}
													goto IL_02b0;
													IL_029a:
													switch (num9)
													{
													case 2:
														goto end_IL_0285;
													case 1:
														goto end_IL_0285;
													}
													goto IL_02b0;
													IL_02b0:
													JdnoAx8PXNq9Q5MGMRK3(enumerator3);
													num9 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
													{
														num9 = 1;
													}
													goto IL_029a;
													end_IL_0285:;
												}
												goto IL_0181;
											case 4:
												goto end_IL_0181;
											}
											break;
										}
										goto IL_015e;
										IL_015e:
										current2 = enumerator2.Current;
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num6 = 8;
										}
										goto IL_009a;
										continue;
										end_IL_0181:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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
							case 0:
								break;
							}
						}
						catch (Exception ex)
						{
							int num11 = 3;
							while (true)
							{
								switch (num11)
								{
								case 3:
									((ILogger)pFtGmZ8PTa4CKTjRXeZr()).Error(mmTK708PkCgwhPRWX1SU(ex), ex);
									num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num11 = 0;
									}
									break;
								case 2:
									result = false;
									num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num11 = 1;
									}
									break;
								default:
									errors.Add((string)mmTK708PkCgwhPRWX1SU(ex));
									num11 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num11 = 2;
									}
									break;
								case 1:
									return result;
								}
							}
						}
						break;
					default:
						return true;
					case 1:
						dictionary = new Dictionary<ElmaStoreComponentManifest, string>();
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						localFileNames = new Dictionary<ElmaStoreComponentManifest, string>();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						goto end_IL_0012;
					case 6:
						try
						{
							while (true)
							{
								IL_04fd:
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 2;
									goto IL_04a4;
								}
								goto IL_04ea;
								IL_04a4:
								while (true)
								{
									switch (num3)
									{
									case 3:
										localFileNames.Add(current, dictionary[current]);
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
										{
											num3 = 0;
										}
										continue;
									case 1:
										break;
									default:
										goto IL_04fd;
									case 2:
										goto end_IL_04fd;
									}
									break;
								}
								goto IL_04ea;
								IL_04ea:
								current = enumerator.Current;
								num3 = 3;
								goto IL_04a4;
								continue;
								end_IL_04fd:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto default;
					case 5:
						break;
					}
					enumerator = DeployUtils.SortComponentsByDependencies(dictionary.Select((KeyValuePair<ElmaStoreComponentManifest, string> d) => d.Key).ToList()).GetEnumerator();
					num2 = 6;
					continue;
					end_IL_0012:
					break;
				}
				errors = new List<string>();
				num = 2;
			}
		}

		internal static void uNU9RE8PhEyuGgw27T4t()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool TJM3dh8PotnXYKbbfXql()
		{
			return zx8ius8PWoM3KRUAdSLy == null;
		}

		internal static ConfigurationUnpacker F6iHcK8Pb2cNAgTK6hSl()
		{
			return (ConfigurationUnpacker)zx8ius8PWoM3KRUAdSLy;
		}

		internal static object f0tR9F8PGyvJymH49uQO(object P_0)
		{
			return ((ConfigImportSettings)P_0).FileName;
		}

		internal static object uGiOtG8PEJFFhepviIZm(object P_0, object P_1)
		{
			return ((IExportImportFileService)P_0).CreateZipFileName((string)P_1);
		}

		internal static object dNqKTg8PffEGoZHer2O0(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static object smadog8PQJYgLDdEXeEV(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).Id;
		}

		internal static object rPMuNu8PCOstx1xsYHcQ(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).Title;
		}

		internal static void RHytFc8PvjIQqSlXufo9(object P_0, object P_1)
		{
			((ConfigImportSettings)P_0).FileName = (string)P_1;
		}

		internal static void E78L4D8P8EHnARTlY69d(object P_0)
		{
			((ConfigImportSettings)P_0).CreateFileName();
		}

		internal static object E6JkVj8PZUQrFnFj9nP1(object P_0)
		{
			return ElmaStoreComponentsBuilder.Read((string)P_0);
		}

		internal static void MWMvBe8Pu6YYtXOYZoHb(object P_0, object P_1)
		{
			((ConfigImportSettings)P_0).Manifest = (ElmaStoreComponentManifest)P_1;
		}

		internal static object xb2sfQ8PIGjK9jdPlQsm(object P_0)
		{
			return ((ConfigImportSettings)P_0).FakeManifest;
		}

		internal static void IIu5if8PV2lYjbnvOhxX(object P_0, object P_1)
		{
			((BPMAppFakeManifest)P_0).DisplayName = (string)P_1;
		}

		internal static bool reVpsQ8PSQD9RdsDAtIi(object P_0, object P_1)
		{
			return (string)P_0 != (string)P_1;
		}

		internal static object oaUcEC8PiFxMkITkvSjV(object P_0)
		{
			return ((ModuleVersion)P_0).Header;
		}

		internal static object IPA1pt8PR2uMjeJZhEcB(object P_0)
		{
			return ((ModuleVersionHeader)P_0).Version;
		}

		internal static object US2UMR8PqpREKTRw8k8A(object P_0)
		{
			return ((ModuleVersion)P_0).Metadata;
		}

		internal static bool zlQd9m8PKVhZxdWKYd12(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void JdnoAx8PXNq9Q5MGMRK3(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static object pFtGmZ8PTa4CKTjRXeZr()
		{
			return Logger.Log;
		}

		internal static object mmTK708PkCgwhPRWX1SU(object P_0)
		{
			return ((Exception)P_0).Message;
		}
	}

	private readonly IExportImportFileService fileService;

	private readonly IModuleMetadataExtractorService moduleMetadataExtractorService;

	private readonly ITagService tagService;

	private readonly IZipService zipService;

	private readonly IModuleDTOManager moduleManager;

	internal static ConfigurationUnpackService z72SD2E4zpj7sCFtDHVj;

	public ConfigurationUnpackService(IExportImportFileService fileService, IModuleMetadataExtractorService moduleMetadataExtractorService, ITagService tagService, IZipService zipService, IModuleDTOManager moduleManager)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		xlMDMhE6W7jgYd3wDsy8();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 1:
				this.tagService = tagService;
				num = 3;
				break;
			case 4:
				this.fileService = fileService;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 2;
				}
				break;
			default:
				this.moduleManager = moduleManager;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num = 5;
				}
				break;
			case 2:
				this.moduleMetadataExtractorService = moduleMetadataExtractorService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				this.zipService = zipService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<IConfigImportSettings> Unpack(BinaryFile file, ILogger logger, bool checkManifests, bool tagFilter)
	{
		Contract.ArgumentNotNull(file, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35917269));
		return new ConfigurationUnpacker(fileService, moduleMetadataExtractorService, tagService, zipService, moduleManager, logger ?? NullLogger.Instance, checkManifests, tagFilter).Unpack(file);
	}

	public IEnumerable<IConfigImportSettings> FilterByTags(IEnumerable<IConfigImportSettings> importSettings)
	{
		return importSettings.Where((IConfigImportSettings s) => tagService.ValidateTags((ElmaStoreComponentManifest)TZw001E6oN5anUcM5AI2(s)));
	}

	public void ValidateComponents(IEnumerable<IConfigImportSettings> importSettings)
	{
		if (ValidateComponents(from s in importSettings
			where _003C_003Ec.trhdUx8PP67C8JNcF2Wy(s) != null
			select (ElmaStoreComponentManifest)_003C_003Ec.trhdUx8PP67C8JNcF2Wy(s), moduleManager.GetInstalledComponentManifests(), out var warnings, out var errors))
		{
			return;
		}
		throw new ConfigurationUnpackException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269AD5D0)), null, warnings, errors);
	}

	private static bool ValidateComponents(IEnumerable<ElmaStoreComponentManifest> components, IEnumerable<ElmaStoreComponentManifest> installedComponents, out List<string> warnings, out List<string> errors)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.components = components;
		if (CS_0024_003C_003E8__locals0.components.Any((ElmaStoreComponentManifest c) => c.ActivationType == ElmaStoreComponentActivationType.Paid))
		{
			warnings = new List<string>(0);
			errors = new List<string> { SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F1ECE6), ElmaEditionHelper.GetDisplayName(ElmaEdition.CE)) };
			return false;
		}
		Dictionary<ElmaStoreComponentManifest, bool> dictionary = installedComponents.Where(delegate(ElmaStoreComponentManifest c)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_1);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return !CS_0024_003C_003E8__locals0.components.Any(_003C_003Ec__DisplayClass11_._003CValidateComponents_003Eb__4);
				case 1:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_1();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				default:
					_003C_003Ec__DisplayClass11_.c = c;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}).Distinct().ToDictionary((ElmaStoreComponentManifest c) => c, (ElmaStoreComponentManifest c) => true);
		foreach (ElmaStoreComponentManifest component in CS_0024_003C_003E8__locals0.components)
		{
			dictionary.Add(component, value: false);
		}
		if (ManifestValidationHelper.Check(dictionary, out errors, out warnings))
		{
			return ManifestValidationHelper.CheckByDependencies(CS_0024_003C_003E8__locals0.components.ToList(), dictionary.Keys.ToList(), out errors);
		}
		return false;
	}

	internal static void xlMDMhE6W7jgYd3wDsy8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool n3ndjcE6Fwpey3RFM6wq()
	{
		return z72SD2E4zpj7sCFtDHVj == null;
	}

	internal static ConfigurationUnpackService b8YsSaE6BAMb0pA3o5YO()
	{
		return z72SD2E4zpj7sCFtDHVj;
	}

	internal static object TZw001E6oN5anUcM5AI2(object P_0)
	{
		return ((IConfigImportSettings)P_0).Manifest;
	}
}
