using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using AutoMapper;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Managers;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Service]
internal sealed class BpmAppService : IBpmAppService
{
	private readonly IModuleDTOManager moduleDtoManager;

	private readonly IEnumerable<IBPMAppItemsConverter> converters;

	private readonly BPMAppManager manager;

	private readonly ICacheFilesService cacheFilesService;

	private Dictionary<string, Guid> filesKeys;

	private static BpmAppService JeSf9afOBSRyHuDrjRfX;

	public BpmAppService(IModuleDTOManager moduleDtoManager, IEnumerable<IBPMAppItemsConverter> converters, BPMAppManager manager, ICacheFilesService cacheFilesService)
	{
		SingletonReader.JJCZtPuTvSt();
		filesKeys = new Dictionary<string, Guid>();
		base._002Ector();
		this.moduleDtoManager = moduleDtoManager;
		this.converters = converters;
		this.manager = manager;
		this.cacheFilesService = cacheFilesService;
	}

	public IEnumerable<BPMAppDTO> LoadAll()
	{
		return (from e in manager.FindAll()
			select Mapper.Map<IBPMApp, BPMAppDTO>(e)).ToList();
	}

	public BPMAppDTO Save(BPMAppDTO bpmApp, byte[] helpFileContent, byte[] additionalFilesContent)
	{
		int num = 1;
		IBPMApp iBPMApp = default(IBPMApp);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					WpOQhQfOGyL52oND3jRJ(iBPMApp, additionalFilesContent, helpFileContent);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					OtqV1EfOhKh5vGxOrWx0(bpmApp, fAt5U5fObxLl58aH8Wfj(-2107978722 ^ -2107669464));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return Mapper.Map<IBPMApp, BPMAppDTO>(iBPMApp);
				case 4:
					break;
				default:
					iBPMApp = Mapper.Map<BPMAppDTO, IBPMApp>(bpmApp);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			manager.Save(iBPMApp);
			num = 3;
		}
	}

	public BPMAppDTO Save(BPMAppDTO bpmApp)
	{
		int num = 1;
		int num2 = num;
		byte[] helpFileContent = default(byte[]);
		byte[] additionalFilesContent = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				LoadFiles(bpmApp.Id, out helpFileContent, out additionalFilesContent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				OtqV1EfOhKh5vGxOrWx0(bpmApp, fAt5U5fObxLl58aH8Wfj(0x1FFEF86A ^ 0x1FFBB05C));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Save(bpmApp, helpFileContent, additionalFilesContent);
			}
		}
	}

	public void Delete(long id)
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
			{
				IBPMApp iBPMApp = manager.Load(id);
				if (uE7xBafOEgC91QBjnaCD(iBPMApp))
				{
					throw new InvalidOperationException((string)pcyskRfOfNvY7t2wnlMI(fAt5U5fObxLl58aH8Wfj(-606654180 ^ -606963366)));
				}
				iBPMApp.Delete();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public void LoadFiles(long id, out byte[] helpFileContent, out byte[] additionalFilesContent)
	{
		int num = 2;
		int num2 = num;
		IBPMApp iBPMApp = default(IBPMApp);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				iBPMApp = manager.Load(id);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				helpFileContent = (byte[])JCCOa0fOQYiaFROYBIkR(iBPMApp);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				additionalFilesContent = (byte[])o02VYpfOCEcFplN0mKTT(iBPMApp);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ConfigExportSettings GetAppExportSettings(Guid uid, Guid settingsFilename)
	{
		//Discarded unreachable code: IL_01f9, IL_0208, IL_023e, IL_024d, IL_0258, IL_02dd, IL_031d, IL_0328, IL_0337, IL_0346, IL_0356, IL_0365
		int num = 20;
		ConfigExportSettings configExportSettings = default(ConfigExportSettings);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		BPMAppDTO bPMAppDTO = default(BPMAppDTO);
		FilesExportSetting filesExportSetting = default(FilesExportSetting);
		object value = default(object);
		IEnumerator<IBPMAppItemsConverter> enumerator = default(IEnumerator<IBPMAppItemsConverter>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!configExportSettings.Manifest.Dependencies.Any(_003C_003Ec__DisplayClass11_._003CGetAppExportSettings_003Eb__1))
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				case 10:
				case 12:
					if (PseQFhfOuIgXIBqsrSG1(bPMAppDTO) == null)
					{
						num2 = 21;
						continue;
					}
					goto case 17;
				case 5:
					filesExportSetting.BpmAppId = bPMAppDTO.Id;
					num2 = 13;
					continue;
				case 1:
				{
					ConfigExportSettings configExportSettings2 = configExportSettings;
					ElmaStoreComponentManifest elmaStoreComponentManifest = new ElmaStoreComponentManifest();
					sMyuDlfOZiDR7Tj6iTfa(elmaStoreComponentManifest, ManifestComponentType.ProcessPackage);
					aFCpx9fO82eLHSDSqXnB(configExportSettings2, elmaStoreComponentManifest);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				case 9:
					if (_003C_003Ec__DisplayClass11_.platform != null)
					{
						num2 = 2;
						continue;
					}
					goto case 7;
				case 20:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 19;
					continue;
				case 7:
					if (!configExportSettings.CustomSettings.TryGetValue(FilesExportConsts.ExportExtensionUid, out value))
					{
						num = 16;
						break;
					}
					goto case 4;
				case 4:
					if ((filesExportSetting = value as FilesExportSetting) == null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 5;
				case 3:
					if (lDjhDEfOvsHD0nPuPdpA(bPMAppDTO) != null)
					{
						num2 = 15;
						continue;
					}
					goto case 1;
				case 8:
				{
					List<ElmaStoreComponentDependency> dependencies = configExportSettings.Manifest.Dependencies;
					ElmaStoreComponentDependency elmaStoreComponentDependency = new ElmaStoreComponentDependency();
					uS55m9fORj9PhLcTd1w8(elmaStoreComponentDependency, SVmqBCfOiypNkOBbC28q(_003C_003Ec__DisplayClass11_.platform));
					UYwaQ6fOXHu5Sly19S13(elmaStoreComponentDependency, re4HWRfOKMcrEolDIlec(zj38ebfOqgpiRtJPJLIV(_003C_003Ec__DisplayClass11_.platform)));
					dependencies.Add(elmaStoreComponentDependency);
					num2 = 7;
					continue;
				}
				case 6:
					((ElmaStoreComponentManifest)BN7hC2fOSk3C0kmpS946(configExportSettings)).BPMAppManifest = ClassSerializationHelper.SerializeObjectByXml(bPMAppDTO.AppManifest);
					num2 = 11;
					continue;
				case 19:
					configExportSettings = new ConfigExportSettings(settingsFilename);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 14;
					}
					continue;
				case 13:
				case 16:
				case 18:
					return configExportSettings;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!AmkxB4fOVXgUAo0ryR4i(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num3 = 0;
								}
								goto IL_025c;
							}
							goto IL_0272;
							IL_0272:
							E1i5ysfOIBSVQbOZjicr(enumerator.Current, PseQFhfOuIgXIBqsrSG1(bPMAppDTO), configExportSettings);
							num3 = 2;
							goto IL_025c;
							IL_025c:
							switch (num3)
							{
							case 1:
								goto IL_0272;
							case 2:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num4 = 0;
							}
							goto IL_02e1;
						}
						goto IL_02f7;
						IL_02f7:
						enumerator.Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num4 = 0;
						}
						goto IL_02e1;
						IL_02e1:
						switch (num4)
						{
						default:
							goto end_IL_02bc;
						case 2:
							break;
						case 1:
							goto end_IL_02bc;
						case 0:
							goto end_IL_02bc;
						}
						goto IL_02f7;
						end_IL_02bc:;
					}
					goto case 6;
				case 17:
					enumerator = converters.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					bPMAppDTO = Mapper.Map<IBPMApp, BPMAppDTO>(manager.Load(uid));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					aFCpx9fO82eLHSDSqXnB(configExportSettings, lDjhDEfOvsHD0nPuPdpA(bPMAppDTO));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 12;
					}
					continue;
				case 11:
				case 21:
					_003C_003Ec__DisplayClass11_.platform = moduleDtoManager.GetInstalledComponentManifests().FirstOrDefault((ElmaStoreComponentManifest m) => m.ProductType == ManifestComponentType.Platform);
					num = 9;
					break;
				}
				break;
			}
		}
	}

	public FilesLoadToCacheResult PutBpmAppFilesToCache(FilesLoadToCacheInput input)
	{
		//Discarded unreachable code: IL_00da, IL_00e9, IL_01ac, IL_01bb
		int num = 10;
		int num2 = num;
		FilesLoadToCacheResult filesLoadToCacheResult = default(FilesLoadToCacheResult);
		byte[] additionalFilesContent = default(byte[]);
		byte[] helpFileContent = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (scUTJUfOkBPs4b3uLaHM(q8dHUMfOTTTVT3m8uPCk(input)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 12:
				xFvBZwfO2SiE369KsxsW(filesLoadToCacheResult, LoadFileToCacheByUniqueKey(input.BpmAppId, (string)q7aXiffOOPqLFof8xObs(input), additionalFilesContent));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 11;
				}
				break;
			default:
				if (additionalFilesContent == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				if (additionalFilesContent.Length != 0)
				{
					num2 = 8;
					break;
				}
				goto case 2;
			case 2:
			case 11:
				return filesLoadToCacheResult;
			case 9:
				LoadFiles(input.BpmAppId, out helpFileContent, out additionalFilesContent);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				if (helpFileContent.Length != 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 6:
				if (helpFileContent != null)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 3:
				filesLoadToCacheResult.HelpFileUid = LoadFileToCacheByUniqueKey(Kjx2VAfOn0KfGcyrjB4G(input), (string)q8dHUMfOTTTVT3m8uPCk(input), helpFileContent);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 5;
				}
				break;
			case 10:
				filesLoadToCacheResult = new FilesLoadToCacheResult();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 9;
				}
				break;
			case 8:
				if (!scUTJUfOkBPs4b3uLaHM(input.HelpFolderName))
				{
					num2 = 12;
					break;
				}
				goto case 2;
			}
		}
	}

	private Guid LoadFileToCacheByUniqueKey(long bpmAppId, string fileName, byte[] fileContent)
	{
		//Discarded unreachable code: IL_0038
		int num = 2;
		int num2 = num;
		Guid fileCacheGuid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return fileCacheGuid;
			case 2:
				fileCacheGuid = GetFileCacheGuid(bpmAppId, fileContent);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				if (!scUTJUfOkBPs4b3uLaHM(vbNWi4fOem1mJU958waw(cacheFilesService, fileCacheGuid)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			LoadFileToCache(fileName, fileContent, fileCacheGuid);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
			{
				num2 = 4;
			}
		}
	}

	private Guid GetFileCacheGuid(long bpmAppId, byte[] fileContent)
	{
		//Discarded unreachable code: IL_00af
		int num = 1;
		int num2 = num;
		string fileHashKey = default(string);
		Guid value = default(Guid);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileHashKey = GetFileHashKey(bpmAppId, fileContent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!filesKeys.TryGetValue(fileHashKey, out value))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			case 5:
				return value;
			case 3:
				guid = qnbOI9fOPyM1EKYmtKpL();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				filesKeys.Add(fileHashKey, guid);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return guid;
			}
		}
	}

	private string GetFileHashKey(long bpmAppId, byte[] fileContent)
	{
		//Discarded unreachable code: IL_006e, IL_00dd, IL_0115, IL_0124
		int num = 2;
		int num2 = num;
		Crc32 crc = default(Crc32);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				crc = new Crc32();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					byte[] array = (byte[])kDeocyfO1VohbsnmiFgp(crc, fileContent);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						result = (string)rZjp91fOpK2dW02VbJxR(chgbacfO37yvDoEcAKGR(HBSQoEfONLfqrWCX4YKv(bpmAppId)), chgbacfO37yvDoEcAKGR(array));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					if (crc != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((IDisposable)crc).Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
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
			default:
				return result;
			}
		}
	}

	private void LoadFileToCache(string fileName, byte[] fileContent, Guid fileGuid)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_00b1, IL_00e9, IL_0121
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				if (!DoCPRifOaIVfiBBPv5EZ(cacheFilesService, fileGuid, fileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				return;
			case 4:
				try
				{
					cacheFilesService.IncrementCacheFile(fileGuid, memoryStream, 0L);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								ASaefCfOtDTSUDsmlJ8G(memoryStream);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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
				}
			}
			memoryStream = (MemoryStream)Vk8t5pfOD0YRpN5ckFCl(fileContent, false);
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
			{
				num2 = 4;
			}
		}
	}

	internal static object fAt5U5fObxLl58aH8Wfj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void OtqV1EfOhKh5vGxOrWx0(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void WpOQhQfOGyL52oND3jRJ(object P_0, object P_1, object P_2)
	{
		((IBPMApp)P_0).InputFilesContent((byte[])P_1, (byte[])P_2);
	}

	internal static bool wbNFaKfOWwfmxy9ov8VN()
	{
		return JeSf9afOBSRyHuDrjRfX == null;
	}

	internal static BpmAppService zZW7slfOoletkZikSvrk()
	{
		return JeSf9afOBSRyHuDrjRfX;
	}

	internal static bool uE7xBafOEgC91QBjnaCD(object P_0)
	{
		return ((IBPMApp)P_0).Installed;
	}

	internal static object pcyskRfOfNvY7t2wnlMI(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JCCOa0fOQYiaFROYBIkR(object P_0)
	{
		return ((IBPMApp)P_0).HelpFileContent;
	}

	internal static object o02VYpfOCEcFplN0mKTT(object P_0)
	{
		return ((IBPMApp)P_0).AdditionalFilesContent;
	}

	internal static object lDjhDEfOvsHD0nPuPdpA(object P_0)
	{
		return ((BPMAppDTO)P_0).ComponentManifest;
	}

	internal static void aFCpx9fO82eLHSDSqXnB(object P_0, object P_1)
	{
		((ConfigExportSettings)P_0).Manifest = (ElmaStoreComponentManifest)P_1;
	}

	internal static void sMyuDlfOZiDR7Tj6iTfa(object P_0, ManifestComponentType P_1)
	{
		((ElmaStoreComponentManifest)P_0).ProductType = P_1;
	}

	internal static object PseQFhfOuIgXIBqsrSG1(object P_0)
	{
		return ((BPMAppDTO)P_0).AppManifest;
	}

	internal static void E1i5ysfOIBSVQbOZjicr(object P_0, object P_1, object P_2)
	{
		((IBPMAppItemsConverter)P_0).ToExportSettings((BPMAppManifest)P_1, (ConfigExportSettings)P_2);
	}

	internal static bool AmkxB4fOVXgUAo0ryR4i(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object BN7hC2fOSk3C0kmpS946(object P_0)
	{
		return ((ConfigExportSettings)P_0).Manifest;
	}

	internal static object SVmqBCfOiypNkOBbC28q(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static void uS55m9fORj9PhLcTd1w8(object P_0, object P_1)
	{
		((ElmaStoreComponentDependency)P_0).Id = (string)P_1;
	}

	internal static object zj38ebfOqgpiRtJPJLIV(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).SemanticVersion;
	}

	internal static object re4HWRfOKMcrEolDIlec(object P_0)
	{
		return ManifestValidationHelper.GetFromVersion((SemanticVersion)P_0);
	}

	internal static void UYwaQ6fOXHu5Sly19S13(object P_0, object P_1)
	{
		((ElmaStoreComponentDependency)P_0).ManifestVersion = (IVersionSpec)P_1;
	}

	internal static object q8dHUMfOTTTVT3m8uPCk(object P_0)
	{
		return ((FilesLoadToCacheInput)P_0).HelpFileName;
	}

	internal static bool scUTJUfOkBPs4b3uLaHM(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static long Kjx2VAfOn0KfGcyrjB4G(object P_0)
	{
		return ((FilesLoadToCacheInput)P_0).BpmAppId;
	}

	internal static object q7aXiffOOPqLFof8xObs(object P_0)
	{
		return ((FilesLoadToCacheInput)P_0).HelpFolderName;
	}

	internal static void xFvBZwfO2SiE369KsxsW(object P_0, Guid value)
	{
		((FilesLoadToCacheResult)P_0).HelpFolderUid = value;
	}

	internal static object vbNWi4fOem1mJU958waw(object P_0, Guid uid)
	{
		return ((ICacheFilesService)P_0).GetFileName(uid);
	}

	internal static Guid qnbOI9fOPyM1EKYmtKpL()
	{
		return Guid.NewGuid();
	}

	internal static object kDeocyfO1VohbsnmiFgp(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object HBSQoEfONLfqrWCX4YKv(long P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	internal static object chgbacfO37yvDoEcAKGR(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static object rZjp91fOpK2dW02VbJxR(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool DoCPRifOaIVfiBBPv5EZ(object P_0, Guid uid, object P_2)
	{
		return ((ICacheFilesService)P_0).CreateCacheFileByUid(uid, (string)P_2);
	}

	internal static object Vk8t5pfOD0YRpN5ckFCl(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static void ASaefCfOtDTSUDsmlJ8G(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
