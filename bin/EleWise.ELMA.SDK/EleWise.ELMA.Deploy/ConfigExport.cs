using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Manifest;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy;

public class ConfigExport
{
	private readonly IAuthenticationService authenticationService;

	private readonly ISecurityService securityService;

	private readonly IMembershipService membershipService;

	private readonly IExportImportFileService exportImportFileService;

	private readonly IZipService zipService;

	private readonly PackageService packageService;

	private readonly IModuleManager moduleManager;

	private readonly IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions;

	private readonly IEnumerable<IManifestChapterCreator> manifestChapterCreators;

	private readonly IEnumerable<IConfigExportExtension> configExportExtensions;

	private readonly IEnumerable<IExportDataExtension> exportDataExtension;

	private ISet<Guid> importants;

	private Dictionary<string, object> exportServiceData;

	private List<PackageDescription> exportedPackages;

	private Dictionary<string, IPackage> exportPackages;

	private List<PacketEntity> exportedPacketEntities;

	private List<PacketMetadata> exportedPacketMetadatas;

	private Dictionary<IGroupedMetadata, bool> exportedObjects;

	private List<FormExportData> formExportData;

	private List<Action<IExportImportFileService, string>> writeComponentFileActions;

	private ConfigExportSettings exportSettings;

	private static readonly ILogger ExportLog;

	private List<string> fileUidsM;

	private List<string> fileUidsD;

	internal static ConfigExport v8oOK9EPV7R8Xar9GdCl;

	private string Protocol
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return (string)AG4Q6BEPqE5aLValmTMo(0x3C5338FF ^ 0x3C576619);
				case 1:
				{
					ISet<Guid> set = importants;
					if (set == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					if (eLgxOFEPRbqCYA6N0jED(set) > 0)
					{
						return (string)AG4Q6BEPqE5aLValmTMo(-521266112 ^ -521518416);
					}
					break;
				}
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	private string Version => (string)AG4Q6BEPqE5aLValmTMo(0x34A6D230 ^ 0x34A28CCA);

	private string Build => VersionInfo.GetVersion<SR>().ToString();

	public ConfigExport(ConfigExportSettings settings, IAuthenticationService authenticationService, ISecurityService securityService, IMembershipService membershipService, IExportImportFileService exportImportFileService, IZipService zipService, PackageService packageService, IModuleManager moduleManager, IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions, IEnumerable<IManifestChapterCreator> manifestChapterCreators, IEnumerable<IConfigExportExtension> configExportExtensions)
	{
		SingletonReader.JJCZtPuTvSt();
		exportPackages = new Dictionary<string, IPackage>();
		fileUidsM = new List<string>();
		fileUidsD = new List<string>();
		base._002Ector();
		exportSettings = settings;
		this.authenticationService = authenticationService;
		this.securityService = securityService;
		this.membershipService = membershipService;
		this.exportImportFileService = exportImportFileService;
		this.zipService = zipService;
		this.packageService = packageService;
		this.moduleManager = moduleManager;
		this.securityDeployHelperExtensions = securityDeployHelperExtensions;
		this.manifestChapterCreators = manifestChapterCreators;
		this.configExportExtensions = configExportExtensions;
	}

	public ConfigExport(ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_005a, IL_005f
		m3QHF6EPKH5TVrsw1Tf2();
		exportPackages = new Dictionary<string, IPackage>();
		fileUidsM = new List<string>();
		fileUidsD = new List<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 11:
				exportImportFileService = Locator.GetServiceNotNull<IExportImportFileService>();
				num = 10;
				break;
			case 6:
				securityDeployHelperExtensions = ((ComponentManager)l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<ISecurityDeployHelperExtension>();
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			case 8:
				authenticationService = Locator.GetServiceNotNull<IAuthenticationService>();
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num = 2;
				}
				break;
			case 3:
				configExportExtensions = ((ComponentManager)l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<IConfigExportExtension>();
				num = 4;
				break;
			case 9:
				membershipService = Locator.GetServiceNotNull<IMembershipService>();
				num = 11;
				break;
			case 7:
				securityService = Locator.GetServiceNotNull<ISecurityService>();
				num = 9;
				break;
			default:
				exportSettings = settings;
				num = 8;
				break;
			case 1:
				moduleManager = Locator.GetServiceNotNull<IModuleManager>();
				num = 6;
				break;
			case 12:
				packageService = Locator.GetServiceNotNull<PackageService>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 1;
				}
				break;
			case 10:
				zipService = Locator.GetServiceNotNull<IZipService>();
				num = 12;
				break;
			case 5:
				manifestChapterCreators = ((ComponentManager)l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<IManifestChapterCreator>();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num = 3;
				}
				break;
			case 4:
				exportDataExtension = ComponentManager.Current.GetExtensionPoints<IExportDataExtension>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void RunExport(IRunExportParameters parameters)
	{
		//Discarded unreachable code: IL_00dc, IL_011e, IL_0175, IL_0185, IL_01e8, IL_0218, IL_0227, IL_0233, IL_0242, IL_026d, IL_02e6, IL_039b, IL_03aa
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		IUser user = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_003C_003Ec__DisplayClass32_._003C_003E4__this = this;
				num2 = 4;
				break;
			case 6:
				Contract.ArgumentNotNull(_003C_003Ec__DisplayClass32_.parameters, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426111049));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass32_.parameters = parameters;
				num2 = 6;
				break;
			case 2:
				_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				try
				{
					CallContextSessionOwner callContextSessionOwner = (CallContextSessionOwner)D4IV6LEPTsHFZ4dWj1so();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 1:
						return;
					}
					try
					{
						int num4;
						if (_003C_003Ec__DisplayClass32_.parameters.SignedUserId != 0L)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num4 = 0;
							}
							goto IL_0122;
						}
						goto IL_017f;
						IL_018a:
						object obj = FyIjNAEPk8Gc0ZhhLviP(securityDeployHelperExtensions.First(), _003C_003Ec__DisplayClass32_.parameters.SignedUserId);
						goto IL_01a6;
						IL_0122:
						while (true)
						{
							switch (num4)
							{
							case 3:
								return;
							case 1:
								PHqqbPEPniItLegN6evn(securityService, user, new Action(_003C_003Ec__DisplayClass32_._003CRunExport_003Eb__0));
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num4 = 3;
								}
								continue;
							case 2:
								break;
							default:
								goto IL_018a;
							}
							break;
						}
						goto IL_017f;
						IL_017f:
						obj = null;
						goto IL_01a6;
						IL_01a6:
						user = (IUser)obj;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num4 = 1;
						}
						goto IL_0122;
					}
					finally
					{
						int num5;
						if (callContextSessionOwner == null)
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num5 = 0;
							}
							goto IL_01ec;
						}
						goto IL_0202;
						IL_0202:
						amyCuPEPONea2Y3rgLkk(callContextSessionOwner);
						num5 = 2;
						goto IL_01ec;
						IL_01ec:
						switch (num5)
						{
						default:
							goto end_IL_01c7;
						case 1:
							break;
						case 0:
							goto end_IL_01c7;
						case 2:
							goto end_IL_01c7;
						}
						goto IL_0202;
						end_IL_01c7:;
					}
				}
				catch (OperationCanceledException)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec__DisplayClass32_.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, (string)JmSPtCEP2AFdjU8Jqdnc(AG4Q6BEPqE5aLValmTMo(-138018305 ^ -138256645)), endProcess: true));
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num6 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex2)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 3:
							return;
						case 2:
							_003C_003Ec__DisplayClass32_.messages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T((string)AG4Q6BEPqE5aLValmTMo(-538519530 ^ -538802384), FgfQoeEPePex3xR0tvkT(ex2)), endProcess: true));
							num7 = 3;
							continue;
						case 1:
							_003C_003Ec__DisplayClass32_.messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", endProcess: false));
							num7 = 2;
							continue;
						}
						ExportLog.Error(FgfQoeEPePex3xR0tvkT(ex2), ex2);
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num7 = 0;
						}
					}
				}
			case 3:
				_003C_003Ec__DisplayClass32_.messages = _003C_003Ec__DisplayClass32_.parameters.LogMessages;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	private void FillExportedObjects(List<DeployLogMessage> messages)
	{
		fileUidsM = new List<string>();
		fileUidsD = new List<string>();
		exportedPacketEntities = new List<PacketEntity>();
		exportedPacketMetadatas = new List<PacketMetadata>();
		importants = new HashSet<Guid>();
		exportServiceData = new Dictionary<string, object>();
		exportedObjects = new Dictionary<IGroupedMetadata, bool>();
		exportedPackages = new List<PackageDescription>();
		formExportData = new List<FormExportData>();
		writeComponentFileActions = new List<Action<IExportImportFileService, string>>();
		ExportExtensionParams parameters = new ExportExtensionParams(exportSettings.CustomSettings, exportedObjects, importants, exportServiceData, exportedPacketEntities, exportedPacketMetadatas, exportedPackages, formExportData, writeComponentFileActions, messages, exportSettings.Manifest);
		foreach (IConfigExportExtension configExportExtension in configExportExtensions)
		{
			configExportExtension.AddExportObjects(parameters);
		}
	}

	private void WriteImportants(XmlWriter writer)
	{
		//Discarded unreachable code: IL_0093, IL_00a2, IL_00ad, IL_0186, IL_0195, IL_0251, IL_0260, IL_026b, IL_032f, IL_0367, IL_0397, IL_03b6, IL_03c5, IL_03f2, IL_0401
		int num = 1;
		int num2 = num;
		IEnumerator<IImportantData> enumerator = default(IEnumerator<IImportantData>);
		IImportantData current = default(IImportantData);
		IEnumerator<Version> enumerator2 = default(IEnumerator<Version>);
		Version current2 = default(Version);
		while (true)
		{
			switch (num2)
			{
			case 1:
				WYv0WjEPPi09LpaLe4pq(writer, AG4Q6BEPqE5aLValmTMo(-477139494 ^ -477416794));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			default:
				enumerator = (from d in ((ComponentManager)l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<IImportantData>()
					where importants.Contains(d.Uid)
					select d).GetEnumerator();
				num2 = 4;
				continue;
			case 4:
				try
				{
					while (true)
					{
						IL_01e8:
						int num3;
						if (!O6tRLhEPpgfxm2eto07C(enumerator))
						{
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num3 = 8;
							}
							goto IL_00b1;
						}
						goto IL_00e7;
						IL_00e7:
						current = enumerator.Current;
						num3 = 7;
						goto IL_00b1;
						IL_00b1:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 6:
								XT0ubCEPa5LP6YLPfYsE(writer);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num3 = 9;
								}
								continue;
							case 5:
								VhdgEREP1R7gVwF6UdK7(writer, AG4Q6BEPqE5aLValmTMo(-1108654032 ^ -1108702234), current.Uid.ToString());
								num3 = 2;
								continue;
							case 2:
								if (zZ7rO4EPN7a0SVuA9Poe(current.Module))
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto default;
							case 7:
								WYv0WjEPPi09LpaLe4pq(writer, AG4Q6BEPqE5aLValmTMo(-1710575414 ^ -1710297250));
								num3 = 5;
								continue;
							case 3:
							case 10:
								enumerator2 = current.Versions.GetEnumerator();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num3 = 0;
								}
								continue;
							case 9:
								goto IL_01e8;
							default:
								VhdgEREP1R7gVwF6UdK7(writer, AG4Q6BEPqE5aLValmTMo(-583745292 ^ -583667668), iQnLl8EP3DHhdsnkdph2(current));
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
								{
									num3 = 5;
								}
								continue;
							case 1:
								try
								{
									while (true)
									{
										int num4;
										if (!O6tRLhEPpgfxm2eto07C(enumerator2))
										{
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
											{
												num4 = 2;
											}
											goto IL_026f;
										}
										goto IL_02e6;
										IL_02e6:
										current2 = enumerator2.Current;
										num4 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
										{
											num4 = 3;
										}
										goto IL_026f;
										IL_026f:
										while (true)
										{
											switch (num4)
											{
											case 3:
												writer.WriteElementString((string)AG4Q6BEPqE5aLValmTMo(-1939377524 ^ -1939344392), current2.ToString());
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
												{
													num4 = 0;
												}
												continue;
											case 1:
												goto IL_02e6;
											case 2:
												goto end_IL_0289;
											}
											break;
										}
										continue;
										end_IL_0289:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											default:
												amyCuPEPONea2Y3rgLkk(enumerator2);
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
												{
													num5 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto case 6;
							case 8:
								goto end_IL_01e8;
							}
							break;
						}
						goto IL_00e7;
						continue;
						end_IL_01e8:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num6 = 0;
						}
						goto IL_039b;
					}
					goto IL_03d0;
					IL_03d0:
					enumerator.Dispose();
					num6 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num6 = 2;
					}
					goto IL_039b;
					IL_039b:
					switch (num6)
					{
					default:
						goto end_IL_0376;
					case 0:
						goto end_IL_0376;
					case 1:
						break;
					case 2:
						goto end_IL_0376;
					}
					goto IL_03d0;
					end_IL_0376:;
				}
				break;
			case 2:
				break;
			}
			writer.WriteEndElement();
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
			{
				num2 = 0;
			}
		}
	}

	private void WriteServiceData(XmlWriter writer)
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
				WriteDictionary(writer, exportServiceData, (string)AG4Q6BEPqE5aLValmTMo(0x17ADCCD8 ^ 0x17A99372));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void WriteDictionary(XmlWriter writer, IDictionary<string, object> dictionary, string name)
	{
		writer.WriteStartElement(name);
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			writer.WriteElementString(item.Key, item.Value.ToString());
		}
		writer.WriteEndElement();
	}

	private void WriteHash(string configFile)
	{
		//Discarded unreachable code: IL_0117, IL_0172, IL_01aa, IL_01e2, IL_01f1, IL_0222, IL_0252, IL_0261, IL_026d, IL_02ba, IL_02f2, IL_032a, IL_0339, IL_0365, IL_03bc, IL_03cb
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				if (!File.Exists(configFile))
				{
					break;
				}
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 1;
				}
				FileStream fileStream = default(FileStream);
				StreamWriter streamWriter = default(StreamWriter);
				string id = default(string);
				string text = default(string);
				while (true)
				{
					int num4;
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						fileStream = (FileStream)KRjpH6EPDQlNyjDjiLPn(configFile);
						num4 = 3;
						goto IL_004b;
					case 5:
						streamWriter = File.CreateText(exportImportFileService.CreateFileName(id, (string)AG4Q6BEPqE5aLValmTMo(-3333094 ^ -3374174), (string)AG4Q6BEPqE5aLValmTMo(-951514650 ^ -951232990)));
						num = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num = 5;
						}
						break;
					case 2:
						if (zZ7rO4EPN7a0SVuA9Poe(text))
						{
							return;
						}
						num = 4;
						break;
					case 3:
						try
						{
							SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							default:
								try
								{
									text = (string)R6aP6iEPw6rtOhJ5e3jA(WbKuXyEPtFnM8NoetdEm(sHA1CryptoServiceProvider.ComputeHash(fileStream)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3DE112), string.Empty);
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								finally
								{
									if (sHA1CryptoServiceProvider != null)
									{
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num7 = 0;
										}
										while (true)
										{
											switch (num7)
											{
											default:
												amyCuPEPONea2Y3rgLkk(sHA1CryptoServiceProvider);
												num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
												{
													num7 = 1;
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
							case 1:
								break;
							}
						}
						finally
						{
							int num8;
							if (fileStream == null)
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
								{
									num8 = 0;
								}
								goto IL_0226;
							}
							goto IL_023c;
							IL_023c:
							amyCuPEPONea2Y3rgLkk(fileStream);
							num8 = 2;
							goto IL_0226;
							IL_0226:
							switch (num8)
							{
							default:
								goto end_IL_0201;
							case 1:
								break;
							case 0:
								goto end_IL_0201;
							case 2:
								goto end_IL_0201;
							}
							goto IL_023c;
							end_IL_0201:;
						}
						goto case 2;
					case 4:
						id = (string)MBjDuSEP4KiAbh3OsRot(exportSettings);
						num4 = 5;
						goto IL_004b;
					case 6:
						{
							try
							{
								vQ58LXEP6SBO7Mje660k(streamWriter, text);
								int num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num2 = 0;
								}
								switch (num2)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								if (streamWriter != null)
								{
									int num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
									{
										num3 = 0;
									}
									while (true)
									{
										switch (num3)
										{
										default:
											amyCuPEPONea2Y3rgLkk(streamWriter);
											num3 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
											{
												num3 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
						}
						IL_004b:
						num = num4;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num9 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num9 = 1;
				}
				while (true)
				{
					switch (num9)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						nG9Tw3EPHSYppZ0yEvQc(ExportLog, AG4Q6BEPqE5aLValmTMo(-889460160 ^ -889211506), ex);
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num9 = 0;
						}
						break;
					}
				}
			}
		}
	}

	private void WriteFiles(string id, string folderPath)
	{
		//Discarded unreachable code: IL_0097, IL_00a6, IL_00f9, IL_0183, IL_01da, IL_0275, IL_0288, IL_0298, IL_02a7, IL_02b2, IL_02e1, IL_03b2, IL_03c5, IL_0445, IL_0454, IL_045f, IL_0552, IL_0561, IL_058f, IL_05df, IL_0647, IL_0656, IL_06ee, IL_06fd, IL_070c, IL_072d, IL_076d, IL_077c, IL_0788, IL_0797, IL_07a6, IL_07b6, IL_088c, IL_08b0, IL_08ba, IL_0925, IL_09fa, IL_0bc4, IL_0c0c, IL_0c1b, IL_0c68, IL_0c7b, IL_0cfe, IL_0d0d, IL_0d2e, IL_0d3d
		int num = 2;
		string text = default(string);
		List<string>.Enumerator enumerator3 = default(List<string>.Enumerator);
		Guid result3 = default(Guid);
		Dictionary<Guid, long> dictionary = default(Dictionary<Guid, long>);
		string text2 = default(string);
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		string[] array = default(string[]);
		KeyValuePair<string, object> current2 = default(KeyValuePair<string, object>);
		long result = default(long);
		Guid result2 = default(Guid);
		XmlWriter xmlWriter = default(XmlWriter);
		Dictionary<Guid, long>.Enumerator enumerator2 = default(Dictionary<Guid, long>.Enumerator);
		KeyValuePair<Guid, long> current = default(KeyValuePair<Guid, long>);
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (string.IsNullOrWhiteSpace(text))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 19;
				case 10:
					return;
				case 3:
					return;
				case 6:
					return;
				case 13:
					return;
				case 8:
					enumerator3 = fileUidsD.GetEnumerator();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					if (!WBRT5kEPmZFHWdHavVcR(text))
					{
						num = 16;
						break;
					}
					goto case 9;
				case 15:
					try
					{
						while (true)
						{
							IL_01e4:
							int num14;
							if (!enumerator3.MoveNext())
							{
								num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
								{
									num14 = 0;
								}
								goto IL_010b;
							}
							goto IL_018d;
							IL_018d:
							if (!Guid.TryParse(enumerator3.Current, out result3))
							{
								continue;
							}
							num14 = 7;
							goto IL_010b;
							IL_010b:
							while (true)
							{
								switch (num14)
								{
								case 3:
								{
									dictionary[result3] = 1L;
									int num15 = 5;
									num14 = num15;
									continue;
								}
								case 9:
									if (!dictionary.ContainsKey(result3))
									{
										num14 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
										{
											num14 = 2;
										}
										continue;
									}
									goto case 6;
								case 4:
									goto IL_018d;
								case 7:
									if (!(result3 != Guid.Empty))
									{
										num14 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
										{
											num14 = 1;
										}
										continue;
									}
									goto case 9;
								case 1:
								case 5:
								case 8:
									goto IL_01e4;
								case 2:
									dictionary.Add(result3, 1L);
									num14 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num14 = 8;
									}
									continue;
								case 6:
									if (dictionary[result3] == 2)
									{
										num14 = 3;
										continue;
									}
									goto IL_01e4;
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
						((IDisposable)enumerator3).Dispose();
						int num16 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num16 = 0;
						}
						switch (num16)
						{
						case 0:
							break;
						}
					}
					goto case 18;
				case 4:
					try
					{
						while (true)
						{
							IL_0360:
							int num12;
							if (!enumerator3.MoveNext())
							{
								num12 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num12 = 1;
								}
								goto IL_02b6;
							}
							goto IL_0318;
							IL_0345:
							if (!ehjakIEP7FpjBWxThaX2(result3, Guid.Empty))
							{
								continue;
							}
							num12 = 3;
							goto IL_02b6;
							IL_02b6:
							while (true)
							{
								switch (num12)
								{
								case 2:
									dictionary.Add(result3, 2L);
									num12 = 5;
									continue;
								case 3:
									if (!dictionary.ContainsKey(result3))
									{
										num12 = 2;
										continue;
									}
									goto IL_0360;
								case 6:
									goto IL_0345;
								case 4:
								case 5:
									goto IL_0360;
								case 1:
									goto end_IL_0360;
								}
								break;
							}
							goto IL_0318;
							IL_0318:
							if (!Guid.TryParse(enumerator3.Current, out result3))
							{
								num12 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num12 = 4;
								}
								goto IL_02b6;
							}
							goto IL_0345;
							continue;
							end_IL_0360:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					goto case 12;
				case 16:
					Directory.CreateDirectory(text);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 9;
					}
					continue;
				default:
					text2 = (string)EDtyRYEPx1wpv4ZsPOwN(exportImportFileService, id, AG4Q6BEPqE5aLValmTMo(-542721635 ^ -542972311), AG4Q6BEPqE5aLValmTMo(-561074844 ^ -561328794));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_0660:
							int num10;
							if (!O6tRLhEPpgfxm2eto07C(enumerator))
							{
								num10 = 18;
								goto IL_0463;
							}
							goto IL_053a;
							IL_0463:
							while (true)
							{
								switch (num10)
								{
								case 21:
									fileUidsD.Add(array[1]);
									num10 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
									{
										num10 = 11;
									}
									continue;
								case 3:
									if (!long.TryParse(current2.Value.ToString(), out result))
									{
										num10 = 20;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
										{
											num10 = 20;
										}
										continue;
									}
									goto case 6;
								case 17:
									if (current2.Value == null)
									{
										num10 = 5;
										continue;
									}
									goto case 9;
								case 4:
									break;
								default:
									if (!fileUidsM.Contains(array[1]))
									{
										num10 = 2;
										continue;
									}
									goto IL_0660;
								case 1:
									if (array.Count() == 3)
									{
										num10 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
										{
											num10 = 5;
										}
										continue;
									}
									goto IL_0660;
								case 7:
									if (!Guid.TryParse(array[1], out result2))
									{
										num10 = 10;
										continue;
									}
									goto case 15;
								case 6:
									if (result != 1)
									{
										num10 = 22;
										continue;
									}
									goto default;
								case 9:
									array = (string[])K2AyhHEPAr2kTTZlNqlC(current2.Key, new char[1] { '_' });
									num10 = 13;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num10 = 10;
									}
									continue;
								case 22:
									if (result != 2)
									{
										num10 = 12;
										continue;
									}
									goto case 8;
								case 5:
								case 10:
								case 11:
								case 12:
								case 14:
								case 16:
								case 19:
								case 20:
									goto IL_0660;
								case 8:
									if (fileUidsD.Contains(array[1]))
									{
										num10 = 19;
										continue;
									}
									goto case 21;
								case 2:
									fileUidsM.Add(array[1]);
									num10 = 16;
									continue;
								case 13:
									if (array != null)
									{
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
										{
											num10 = 1;
										}
										continue;
									}
									goto IL_0660;
								case 15:
									if (!ehjakIEP7FpjBWxThaX2(result2, Guid.Empty))
									{
										num10 = 14;
										continue;
									}
									goto case 3;
								case 18:
									goto end_IL_0660;
								}
								break;
							}
							goto IL_053a;
							IL_053a:
							current2 = enumerator.Current;
							num10 = 17;
							goto IL_0463;
							continue;
							end_IL_0660:
							break;
						}
					}
					finally
					{
						int num11;
						if (enumerator == null)
						{
							num11 = 2;
							goto IL_0731;
						}
						goto IL_0747;
						IL_0731:
						switch (num11)
						{
						case 2:
							goto end_IL_071c;
						case 1:
							goto end_IL_071c;
						}
						goto IL_0747;
						IL_0747:
						amyCuPEPONea2Y3rgLkk(enumerator);
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num11 = 1;
						}
						goto IL_0731;
						end_IL_071c:;
					}
					goto case 14;
				case 7:
				{
					string text4 = text2;
					XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
					YR860UEPyXhs1IBuERcn(xmlWriterSettings, Encoding.UTF8);
					IwJBHHEPM6cHbWhGrt0U(xmlWriterSettings, true);
					SbBJHwEPJ9HHBls1K8DA(xmlWriterSettings, true);
					PlRO3xEP9KFY0jW5MuCk(xmlWriterSettings, ConformanceLevel.Fragment);
					xmlWriter = (XmlWriter)UHLMCgEPdadJW7Vr9MJ6(text4, xmlWriterSettings);
					num = 11;
					break;
				}
				case 18:
					if (dictionary.Count <= 0)
					{
						num2 = 10;
						continue;
					}
					goto default;
				case 14:
					dictionary = new Dictionary<Guid, long>();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					text = (string)m8N5feEP0SyMkkApBXBn(folderPath, AG4Q6BEPqE5aLValmTMo(0x2A7797B7 ^ 0x2A76F47F));
					num = 17;
					break;
				case 11:
					try
					{
						WYv0WjEPPi09LpaLe4pq(xmlWriter, AG4Q6BEPqE5aLValmTMo(0x4DC2B14D ^ 0x4DC6D141));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 3:
								try
								{
									while (true)
									{
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 3;
											goto IL_08be;
										}
										goto IL_08d8;
										IL_08be:
										switch (num4)
										{
										case 2:
											break;
										default:
											try
											{
												string text3 = Path.Combine(text, current.Key.ToString());
												int num5 = 13;
												while (true)
												{
													switch (num5)
													{
													case 12:
														oF2OUREPUqnmS3bjWjAg(xmlWriter, AG4Q6BEPqE5aLValmTMo(0x92F12D5 ^ 0x92D5A43), Convert.ToString(s4XkMOEPcKEJf8tsoS4O(binaryFile), (IFormatProvider)KVtt7EEPz7g1iSpkmV2V()));
														num5 = 10;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
														{
															num5 = 3;
														}
														continue;
													case 11:
														if (ktyCqZEP5U1KhkURa0MA(binaryFile.ContentLocation, null))
														{
															num5 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
															{
																num5 = 2;
															}
															continue;
														}
														break;
													case 13:
														if (rrTl4uEPlaYWf0XxAqkE(text3))
														{
															num5 = 7;
															continue;
														}
														goto case 5;
													case 7:
														break;
													case 4:
														xmlWriter.WriteElementString((string)AG4Q6BEPqE5aLValmTMo(0x4EDCBA32 ^ 0x4EDCC9F2), (string)iDFMy3EPYfbaJbLbF2fA(binaryFile));
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
														{
															num5 = 1;
														}
														continue;
													case 2:
														Dt6JohEPjR7p93ZLnC34(binaryFile, text3);
														num5 = 3;
														continue;
													case 5:
														binaryFile = (BinaryFile)CZHd9WEPg4SZwgScjpmm(tNJCmlEPr2o7u11cWDBG(), current.Key.ToString());
														num5 = 11;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
														{
															num5 = 4;
														}
														continue;
													case 10:
														XT0ubCEPa5LP6YLPfYsE(xmlWriter);
														num5 = 6;
														continue;
													default:
														xmlWriter.WriteAttributeString((string)AG4Q6BEPqE5aLValmTMo(-672123589 ^ -672114007), current.Key.ToString());
														num5 = 8;
														continue;
													case 3:
														WYv0WjEPPi09LpaLe4pq(xmlWriter, AG4Q6BEPqE5aLValmTMo(-1487388570 ^ -1487134656));
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
														{
															num5 = 0;
														}
														continue;
													case 9:
														oF2OUREPUqnmS3bjWjAg(xmlWriter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957707716), Y4jHvCEPsdkWWJuwn9Vc(binaryFile));
														num5 = 12;
														continue;
													case 8:
														VhdgEREP1R7gVwF6UdK7(xmlWriter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410942561), current.Value.ToString());
														num5 = 4;
														continue;
													case 1:
														oF2OUREPUqnmS3bjWjAg(xmlWriter, AG4Q6BEPqE5aLValmTMo(0x8317432 ^ 0x831F56C), di82NbEPLglNkWCgAfdA(binaryFile));
														num5 = 9;
														continue;
													case 6:
														break;
													}
													break;
												}
											}
											catch (Exception ex)
											{
												int num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
												{
													num6 = 0;
												}
												while (true)
												{
													switch (num6)
													{
													case 1:
														mUfkm6E1FS8GF2bvGRC1(ExportLog, FgfQoeEPePex3xR0tvkT(ex), ex);
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
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
											continue;
										case 1:
											continue;
										case 3:
											goto end_IL_0c26;
										}
										goto IL_08d8;
										IL_08d8:
										current = enumerator2.Current;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
										{
											num4 = 0;
										}
										goto IL_08be;
										continue;
										end_IL_0c26:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
									{
										num7 = 0;
									}
									switch (num7)
									{
									case 0:
										break;
									}
								}
								goto case 2;
							case 2:
								XT0ubCEPa5LP6YLPfYsE(xmlWriter);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num3 = 1;
								}
								break;
							default:
								enumerator2 = dictionary.GetEnumerator();
								num3 = 3;
								break;
							}
						}
					}
					finally
					{
						int num8;
						if (xmlWriter == null)
						{
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
							{
								num8 = 0;
							}
							goto IL_0ce3;
						}
						goto IL_0d18;
						IL_0d18:
						amyCuPEPONea2Y3rgLkk(xmlWriter);
						int num9 = 2;
						num8 = num9;
						goto IL_0ce3;
						IL_0ce3:
						switch (num8)
						{
						default:
							goto end_IL_0cbe;
						case 0:
							goto end_IL_0cbe;
						case 1:
							break;
						case 2:
							goto end_IL_0cbe;
						}
						goto IL_0d18;
						end_IL_0cbe:;
					}
				case 19:
					if (!WBRT5kEPmZFHWdHavVcR(text))
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 12:
					enumerator3 = fileUidsM.GetEnumerator();
					num = 15;
					break;
				case 2:
					enumerator = exportServiceData.Where((KeyValuePair<string, object> sd) => sd.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487033220))).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void WriteAdditionalFiles(string fileName)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0070, IL_00f9, IL_010c, IL_011b
		int num = 2;
		int num2 = num;
		List<Action<IExportImportFileService, string>>.Enumerator enumerator = default(List<Action<IExportImportFileService, string>>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				enumerator = writeComponentFileActions.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
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
						goto IL_00a0;
						IL_0074:
						switch (num3)
						{
						case 2:
							return;
						case 1:
							goto IL_00a0;
						}
						continue;
						IL_00a0:
						enumerator.Current(exportImportFileService, fileName);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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

	private void WritePackages(string folderPath)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_0177, IL_0181, IL_0285, IL_0298, IL_02a7, IL_0398, IL_03ab, IL_03ba, IL_044c, IL_045b, IL_0466, IL_04fe, IL_05ba, IL_061e, IL_0656, IL_06a3, IL_06eb, IL_0721, IL_0734
		int num = 6;
		Dictionary<string, IPackage>.Enumerator enumerator2 = default(Dictionary<string, IPackage>.Enumerator);
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = default(_003C_003Ec__DisplayClass40_0);
		List<PackageDescription>.Enumerator enumerator = default(List<PackageDescription>.Enumerator);
		IPackage val = default(IPackage);
		PackageDescription current2 = default(PackageDescription);
		List<PackageDescription>.Enumerator enumerator3 = default(List<PackageDescription>.Enumerator);
		PackageDescription current3 = default(PackageDescription);
		IPackage value = default(IPackage);
		PackageFilter filter = default(PackageFilter);
		List<ElmaStoreComponentDependency> dependencies = default(List<ElmaStoreComponentDependency>);
		FileStream fileStream = default(FileStream);
		string path = default(string);
		KeyValuePair<string, IPackage> current = default(KeyValuePair<string, IPackage>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					enumerator2 = exportPackages.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					return;
				case 7:
					if (DLlX1TE1B2XxcdZsVRuZ(exportSettings) == null)
					{
						num2 = 3;
						continue;
					}
					exportPackages = new Dictionary<string, IPackage>();
					num2 = 4;
					continue;
				case 5:
					_003C_003Ec__DisplayClass40_._003C_003E4__this = this;
					num2 = 7;
					continue;
				case 10:
					try
					{
						while (true)
						{
							int num11;
							if (!enumerator.MoveNext())
							{
								int num10 = 8;
								num11 = num10;
								goto IL_00c0;
							}
							goto IL_02b2;
							IL_00c0:
							while (true)
							{
								switch (num11)
								{
								case 1:
									break;
								default:
									val = (IPackage)Hf4P0EE1bEYwfturK5l4(packageService, Iv3TSjE1WKCynwNNgHbm(current2), t7hxO7E1onQBsgjPEcBo(current2).ToString());
									num11 = 3;
									continue;
								case 7:
									exportPackages.Add((string)Iv3TSjE1WKCynwNNgHbm(current2), val);
									num11 = 5;
									continue;
								case 3:
									if (!exportPackages.ContainsKey((string)Iv3TSjE1WKCynwNNgHbm(current2)))
									{
										num11 = 7;
										continue;
									}
									goto case 5;
								case 4:
									try
									{
										while (true)
										{
											int num12;
											if (!enumerator3.MoveNext())
											{
												num12 = 3;
												goto IL_0185;
											}
											goto IL_01de;
											IL_0185:
											while (true)
											{
												switch (num12)
												{
												case 1:
													if (!exportPackages.ContainsKey((string)Iv3TSjE1WKCynwNNgHbm(current3)))
													{
														num12 = 4;
														continue;
													}
													break;
												case 5:
													goto IL_01de;
												case 4:
													exportPackages.Add(current3.Id, value);
													num12 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
													{
														num12 = 0;
													}
													continue;
												case 2:
													value = (IPackage)Hf4P0EE1bEYwfturK5l4(packageService, current3.Id, t7hxO7E1onQBsgjPEcBo(current3).ToString());
													num12 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
													{
														num12 = 1;
													}
													continue;
												case 3:
													goto end_IL_01a7;
												}
												break;
											}
											continue;
											IL_01de:
											current3 = enumerator3.Current;
											num12 = 2;
											goto IL_0185;
											continue;
											end_IL_01a7:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num13 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
										{
											num13 = 0;
										}
										switch (num13)
										{
										case 0:
											break;
										}
									}
									break;
								case 6:
									goto IL_02b2;
								case 5:
								{
									PackageFilter packageFilter = new PackageFilter();
									aD00qNE1h8ADhlfSYnVd(packageFilter, PackageLevel.All);
									CwvqDBE1GGjLkEQEBqw0(packageFilter, PackageStatus.Any);
									pj31LCE1fDweU8JxjUFY(packageFilter, dDB4BSE1EKE419sblRHx(val));
									D7mAVYE1QWVb8naAVWUJ(packageFilter, true);
									filter = packageFilter;
									num11 = 2;
									continue;
								}
								case 2:
									enumerator3 = packageService.Find(filter).Where(_003C_003Ec__DisplayClass40_._003CWritePackages_003Eb__1).ToList()
										.GetEnumerator();
									num11 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
									{
										num11 = 1;
									}
									continue;
								case 8:
									goto end_IL_00ee;
								}
								break;
							}
							continue;
							IL_02b2:
							current2 = enumerator.Current;
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
							{
								num11 = 0;
							}
							goto IL_00c0;
							continue;
							end_IL_00ee:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num14 = 0;
						}
						switch (num14)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 4:
					dependencies = exportSettings.Manifest.Dependencies;
					num2 = 2;
					continue;
				case 6:
					_003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					return;
				case 2:
					break;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 2;
								goto IL_046a;
							}
							goto IL_049a;
							IL_046a:
							switch (num3)
							{
							case 2:
								return;
							case 3:
								continue;
							case 1:
								goto IL_049a;
							}
							try
							{
								int num4 = 2;
								int num5 = num4;
								while (true)
								{
									switch (num5)
									{
									case 2:
										if (WBRT5kEPmZFHWdHavVcR(folderPath))
										{
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
											{
												num5 = 0;
											}
											continue;
										}
										break;
									case 6:
										fileStream = new FileStream(Path.Combine(folderPath, path), FileMode.CreateNew);
										num5 = 4;
										continue;
									default:
										path = (string)LvAWGeE1viPKCkH4pW4a(AG4Q6BEPqE5aLValmTMo(0x76DD48E ^ 0x769B4B0), dDB4BSE1EKE419sblRHx(current.Value), ((IPackageName)current.Value).get_Version());
										num5 = 6;
										continue;
									case 4:
										try
										{
											byte[] array = (byte[])LulUBkE1Z1M4kXPQTB8h(J3qbQtE18TZr1ZnENxZB(current.Value));
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													fileStream.Write(array, 0, array.Length);
													num6 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
													{
														num6 = 0;
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
											if (fileStream != null)
											{
												int num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
												{
													num7 = 1;
												}
												while (true)
												{
													switch (num7)
													{
													case 1:
														amyCuPEPONea2Y3rgLkk(fileStream);
														num7 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
														{
															num7 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto end_IL_04d3;
									case 5:
										break;
									case 3:
										goto end_IL_04d3;
									}
									gjEk0jE1Csw56G9Rmw5J(folderPath);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num5 = 0;
									}
									continue;
									end_IL_04d3:
									break;
								}
							}
							catch (Exception ex)
							{
								int num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									case 1:
										mUfkm6E1FS8GF2bvGRC1(ExportLog, FgfQoeEPePex3xR0tvkT(ex), ex);
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
										{
											num8 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							continue;
							IL_049a:
							current = enumerator2.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num3 = 0;
							}
							goto IL_046a;
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
				case 8:
					enumerator = exportedPackages.GetEnumerator();
					num2 = 10;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass40_.componentsPackages = dependencies.SelectMany(_003C_003Ec__DisplayClass40_._003CWritePackages_003Eb__0).ToList();
			num = 8;
		}
	}

	static ConfigExport()
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
				ExportLog = Logger.GetLogger((string)AG4Q6BEPqE5aLValmTMo(0x34185E55 ^ 0x341C3E09));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static int eLgxOFEPRbqCYA6N0jED(object P_0)
	{
		return ((ICollection<Guid>)P_0).Count;
	}

	internal static object AG4Q6BEPqE5aLValmTMo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool p9lGwKEPSmQiGVI75Ifi()
	{
		return v8oOK9EPV7R8Xar9GdCl == null;
	}

	internal static ConfigExport dsq18yEPiBvLKjkZK9gk()
	{
		return v8oOK9EPV7R8Xar9GdCl;
	}

	internal static void m3QHF6EPKH5TVrsw1Tf2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object l6cGbPEPXXLEvRQqcrsc()
	{
		return ComponentManager.Current;
	}

	internal static object D4IV6LEPTsHFZ4dWj1so()
	{
		return CallContextSessionOwner.Create();
	}

	internal static object FyIjNAEPk8Gc0ZhhLviP(object P_0, long userId)
	{
		return ((ISecurityDeployHelperExtension)P_0).LoadUserOrNull(userId);
	}

	internal static void PHqqbPEPniItLegN6evn(object P_0, object P_1, object P_2)
	{
		((ISecurityService)P_0).RunByUser((IUser)P_1, (Action)P_2);
	}

	internal static void amyCuPEPONea2Y3rgLkk(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object JmSPtCEP2AFdjU8Jqdnc(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object FgfQoeEPePex3xR0tvkT(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void WYv0WjEPPi09LpaLe4pq(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteStartElement((string)P_1);
	}

	internal static void VhdgEREP1R7gVwF6UdK7(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteAttributeString((string)P_1, (string)P_2);
	}

	internal static bool zZ7rO4EPN7a0SVuA9Poe(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object iQnLl8EP3DHhdsnkdph2(object P_0)
	{
		return ((IImportantData)P_0).Module;
	}

	internal static bool O6tRLhEPpgfxm2eto07C(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void XT0ubCEPa5LP6YLPfYsE(object P_0)
	{
		((XmlWriter)P_0).WriteEndElement();
	}

	internal static object KRjpH6EPDQlNyjDjiLPn(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static object WbKuXyEPtFnM8NoetdEm(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object R6aP6iEPw6rtOhJ5e3jA(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object MBjDuSEP4KiAbh3OsRot(object P_0)
	{
		return ((ConfigExportSettings)P_0).FileName;
	}

	internal static void vQ58LXEP6SBO7Mje660k(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static void nG9Tw3EPHSYppZ0yEvQc(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static object K2AyhHEPAr2kTTZlNqlC(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static bool ehjakIEP7FpjBWxThaX2(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object EDtyRYEPx1wpv4ZsPOwN(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IExportImportFileService)P_0).CreateFileName((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object m8N5feEP0SyMkkApBXBn(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool WBRT5kEPmZFHWdHavVcR(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static void YR860UEPyXhs1IBuERcn(object P_0, object P_1)
	{
		((XmlWriterSettings)P_0).Encoding = (Encoding)P_1;
	}

	internal static void IwJBHHEPM6cHbWhGrt0U(object P_0, bool P_1)
	{
		((XmlWriterSettings)P_0).CloseOutput = P_1;
	}

	internal static void SbBJHwEPJ9HHBls1K8DA(object P_0, bool P_1)
	{
		((XmlWriterSettings)P_0).Indent = P_1;
	}

	internal static void PlRO3xEP9KFY0jW5MuCk(object P_0, ConformanceLevel P_1)
	{
		((XmlWriterSettings)P_0).ConformanceLevel = P_1;
	}

	internal static object UHLMCgEPdadJW7Vr9MJ6(object P_0, object P_1)
	{
		return XmlWriter.Create((string)P_0, (XmlWriterSettings)P_1);
	}

	internal static bool rrTl4uEPlaYWf0XxAqkE(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object tNJCmlEPr2o7u11cWDBG()
	{
		return DataAccessManager.FileManager;
	}

	internal static object CZHd9WEPg4SZwgScjpmm(object P_0, object P_1)
	{
		return ((IFileManager)P_0).LoadFile((string)P_1);
	}

	internal static bool ktyCqZEP5U1KhkURa0MA(object P_0, object P_1)
	{
		return (Uri)P_0 != (Uri)P_1;
	}

	internal static void Dt6JohEPjR7p93ZLnC34(object P_0, object P_1)
	{
		((BinaryFile)P_0).SaveToLocalPath((string)P_1);
	}

	internal static object iDFMy3EPYfbaJbLbF2fA(object P_0)
	{
		return ((BinaryFile)P_0).Name;
	}

	internal static object di82NbEPLglNkWCgAfdA(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static void oF2OUREPUqnmS3bjWjAg(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteElementString((string)P_1, (string)P_2);
	}

	internal static object Y4jHvCEPsdkWWJuwn9Vc(object P_0)
	{
		return ((BinaryFile)P_0).ContentType;
	}

	internal static DateTime s4XkMOEPcKEJf8tsoS4O(object P_0)
	{
		return ((BinaryFile)P_0).CreateDate;
	}

	internal static object KVtt7EEPz7g1iSpkmV2V()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static void mUfkm6E1FS8GF2bvGRC1(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object DLlX1TE1B2XxcdZsVRuZ(object P_0)
	{
		return ((ConfigExportSettings)P_0).Manifest;
	}

	internal static object Iv3TSjE1WKCynwNNgHbm(object P_0)
	{
		return ((PackageDescription)P_0).Id;
	}

	internal static object t7hxO7E1onQBsgjPEcBo(object P_0)
	{
		return ((PackageDescription)P_0).LastVersion;
	}

	internal static object Hf4P0EE1bEYwfturK5l4(object P_0, object P_1, object P_2)
	{
		return ((PackageService)P_0).GetPackage((string)P_1, (string)P_2);
	}

	internal static void aD00qNE1h8ADhlfSYnVd(object P_0, PackageLevel value)
	{
		((PackageFilter)P_0).Level = value;
	}

	internal static void CwvqDBE1GGjLkEQEBqw0(object P_0, PackageStatus value)
	{
		((PackageFilter)P_0).Status = value;
	}

	internal static object dDB4BSE1EKE419sblRHx(object P_0)
	{
		return ((IPackageName)P_0).get_Id();
	}

	internal static void pj31LCE1fDweU8JxjUFY(object P_0, object P_1)
	{
		((PackageFilter)P_0).Owner = (string)P_1;
	}

	internal static void D7mAVYE1QWVb8naAVWUJ(object P_0, bool value)
	{
		((PackageFilter)P_0).IncludeIncompatiblePackages = value;
	}

	internal static object gjEk0jE1Csw56G9Rmw5J(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object LvAWGeE1viPKCkH4pW4a(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object J3qbQtE18TZr1ZnENxZB(object P_0)
	{
		return ((IPackage)P_0).GetStream();
	}

	internal static object LulUBkE1Z1M4kXPQTB8h(object P_0)
	{
		return ((Stream)P_0).ReadAllBytes();
	}
}
