using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Impl;

[Service]
internal class CacheFilesService : IStructuredFileService, ICacheFilesService, IInitHandler
{
	[Serializable]
	internal class TempFileInfo
	{
		public string FilePath;

		public string FileName;

		internal static TempFileInfo Wl0UDXQOR3LWwlEJcnPI;

		public TempFileInfo()
		{
			//Discarded unreachable code: IL_004a, IL_004f
			EAygtFQOXFpocJet1fY9();
			FilePath = "";
			FileName = "";
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void EAygtFQOXFpocJet1fY9()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool asPfJKQOqhCRPx49Dval()
		{
			return Wl0UDXQOR3LWwlEJcnPI == null;
		}

		internal static TempFileInfo p0SpQjQOK46MF1Zcr4Tl()
		{
			return Wl0UDXQOR3LWwlEJcnPI;
		}
	}

	private static IAuthenticationService authenticationService;

	private string cacheFilesDirectory;

	private ICacheService cacheService;

	private ILogger logger;

	private FileSystemWatcher watcher;

	private static CacheFilesService vAphfdByFiFvMlMtDAh9;

	public IZipService ZipService
	{
		[CompilerGenerated]
		get
		{
			return _003CZipService_003Ek__BackingField;
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
					_003CZipService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ICacheService Cache
	{
		get
		{
			int num = 2;
			int num2 = num;
			ICacheService cacheService = default(ICacheService);
			ICacheService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					cacheService = (this.cacheService = Locator.GetServiceNotNull<ICacheService>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.cacheService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = cacheService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	private ILogger Logger
	{
		get
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					nWYheUBySKuXqtQRRxul(logger, new EventHandler(OnConfigurationChanged));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					logger = (ILogger)PpJoLYByVQ7P9wa9d5bx(AJJ6D4ByofIIYeCCNkVe(0x103FE975 ^ 0x103E8ABD));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return logger;
				case 3:
					if (logger == null)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
			}
		}
	}

	private static IAuthenticationService AuthenticationService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IAuthenticationService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = authenticationService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (authenticationService = Locator.GetService<IAuthenticationService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private string CurrentUser
	{
		get
		{
			//Discarded unreachable code: IL_005e, IL_006d, IL_00a3, IL_00b3
			int num = 1;
			int num2 = num;
			IUser user = default(IUser);
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (user != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 3;
				case 5:
					return null;
				default:
					if (gZ32bBByRiSbvBFD1BIk() == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						user = (IUser)ygjytAByqXr8X3jWNUu7(gZ32bBByRiSbvBFD1BIk());
						num2 = 6;
					}
					continue;
				case 3:
					obj = null;
					break;
				case 1:
					if (Lkj7OhByiyt5C7FvD6pF(Logger))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 2:
					return (string)AJJ6D4ByofIIYeCCNkVe(0x49E27B8A ^ 0x49E213DE);
				case 4:
					obj = pJWsntByKqnNQTBVXDni(user);
					break;
				}
				break;
			}
			return (string)obj + (string)AJJ6D4ByofIIYeCCNkVe(0x76DD48E ^ 0x76DBCDA);
		}
	}

	private string CacheFilesDir => cacheFilesDirectory;

	Guid IStructuredFileService.Create(StructuredFileFolder structuredFileFolder)
	{
		//Discarded unreachable code: IL_0060, IL_012f, IL_0167, IL_01a7, IL_01b6, IL_01c2, IL_01ed, IL_0273, IL_0286, IL_0295
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		string text = default(string);
		Exception ex = default(Exception);
		FileStream fileStream = default(FileStream);
		string text3 = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return guid;
			case 5:
				try
				{
					CreateStructuredFolder(structuredFileFolder, text);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							return guid;
						case 2:
							if (ex != null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
								{
									num3 = 0;
								}
							}
							else
							{
								fileStream = new FileStream(text3, FileMode.Open);
								num3 = 5;
							}
							break;
						case 4:
							ex = (Exception)akFwesByCtfnO0Iv4ZHS(ZipService, text3, Path.Combine(text, (string)eNBE3IByQeLFjTv47uEe(structuredFileFolder)));
							num3 = 2;
							break;
						case 1:
							text3 = (string)cuCqK1ByflxIQ6NyjqBC(text, text2);
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num3 = 4;
							}
							break;
						default:
							throw ex;
						case 5:
							try
							{
								AppendCacheFile(guid, fileStream);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num4 = 0;
								}
								return num4 switch
								{
									0 => guid, 
									_ => guid, 
								};
							}
							finally
							{
								int num5;
								if (fileStream == null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num5 = 0;
									}
									goto IL_016b;
								}
								goto IL_0181;
								IL_0181:
								gkZTvFByvjPDSGPIT9Kw(fileStream);
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num5 = 2;
								}
								goto IL_016b;
								IL_016b:
								switch (num5)
								{
								default:
									goto end_IL_0146;
								case 1:
									break;
								case 0:
									goto end_IL_0146;
								case 2:
									goto end_IL_0146;
								}
								goto IL_0181;
								end_IL_0146:;
							}
						}
					}
				}
				catch (Exception ex2)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							Pp27sJBy8KNKfadcO3AM(Logger, SR.T((string)AJJ6D4ByofIIYeCCNkVe(0x57A5235E ^ 0x57A44032), eNBE3IByQeLFjTv47uEe(structuredFileFolder)), ex2);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num6 = 0;
							}
							break;
						default:
							throw ex2;
						}
					}
				}
				finally
				{
					FbwtyjByZisrujCigLCi(text, true);
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 1:
				IDovjHBybiOL2BHBlccv(structuredFileFolder, AJJ6D4ByofIIYeCCNkVe(-1751176224 ^ -1751234348));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				guid = pIAir7ByEsx8PcN2lspU(this, text2);
				num2 = 4;
				break;
			case 6:
				text2 = (string)DBPk8UByG1SZQctnQYw9(structuredFileFolder.Name, AJJ6D4ByofIIYeCCNkVe(-740338220 ^ -740411724));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 3;
				}
				break;
			default:
				CPA9R9Byhm7v9oVKbAUc(structuredFileFolder.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939406516));
				num2 = 6;
				break;
			case 4:
				text = Path.Combine(CacheFilesDir, guid.ToString());
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void CreateStructuredFolder(StructuredFileFolder structuredFile, string parentDirectory)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass5_._003C_003E4__this = this;
				num2 = 11;
				break;
			case 4:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 3;
				}
				break;
			case 10:
				return;
			default:
				wPX301ByIuql4vat9OJU(_003C_003Ec__DisplayClass5_.currentDirectory);
				num2 = 2;
				break;
			case 1:
				if (K586s4ByuNLZFNKW6iwd(_003C_003Ec__DisplayClass5_.currentDirectory))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				return;
			case 7:
			case 9:
			{
				List<StructuredFileFile> files = structuredFile.Files;
				if (files == null)
				{
					num2 = 6;
					break;
				}
				files.ForEach(_003C_003Ec__DisplayClass5_._003CCreateStructuredFolder_003Eb__1);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 11:
				if (structuredFile != null)
				{
					_003C_003Ec__DisplayClass5_.currentDirectory = (string)cuCqK1ByflxIQ6NyjqBC(parentDirectory, eNBE3IByQeLFjTv47uEe(structuredFile));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 4;
					}
				}
				break;
			case 5:
				return;
			case 2:
			{
				List<StructuredFileFolder> folders = structuredFile.Folders;
				if (folders == null)
				{
					num2 = 9;
					break;
				}
				folders.ForEach(_003C_003Ec__DisplayClass5_._003CCreateStructuredFolder_003Eb__0);
				num2 = 7;
				break;
			}
			case 6:
				return;
			}
		}
	}

	private string GetFilePathPrivate(Guid uid, string originalFileName)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_008b
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				if (HqQH7EByX9ADbPJ5AJv9(originalFileName))
				{
					num2 = 5;
					continue;
				}
				obj = Path.GetExtension(originalFileName.ReplaceInvalidFileNameChars());
				break;
			case 4:
			case 6:
				return (string)cuCqK1ByflxIQ6NyjqBC(CacheFilesDir, MEqmD0ByT5SM9vHJKUs5(uid, text));
			case 5:
				obj = null;
				break;
			default:
				if (!HqQH7EByX9ADbPJ5AJv9(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 3;
			case 3:
				text = (string)AJJ6D4ByofIIYeCCNkVe(0x61EC0CB8 ^ 0x61ED6F6E);
				num2 = 4;
				continue;
			case 2:
				EnsureCacheDirectory();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			text = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
			{
				num2 = 0;
			}
		}
	}

	private static string GetKey(Guid key)
	{
		return (string)OdC8miByk1Z1WEn8qH9s(AJJ6D4ByofIIYeCCNkVe(-2112703338 ^ -2112628876), AJJ6D4ByofIIYeCCNkVe(0x4DC2B14D ^ 0x4DC3D2B9), key);
	}

	private void RemoveCacheDirectory()
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
				Wu9jvdBynIkjUjbYTX7M(CacheFilesDir);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void EnsureCacheDirectory()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				wPX301ByIuql4vat9OJU(CacheFilesDir);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				if (!K586s4ByuNLZFNKW6iwd(CacheFilesDir))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 4:
				OnConfigurationChanged(this, EventArgs.Empty);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				return;
			}
			vBeLg9ByOrLD4JKYdlek(CacheFilesDir);
			num2 = 4;
		}
	}

	private void OnConfigurationChanged(object sender, EventArgs eventArgs)
	{
		//Discarded unreachable code: IL_0121, IL_0173, IL_0182, IL_01a7
		int num = 8;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (Logger.IsEnabled(LogLevel.Information))
					{
						num2 = 6;
						break;
					}
					goto default;
				case 6:
					if (!K586s4ByuNLZFNKW6iwd(CacheFilesDir))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 1:
					RKKvlAByeP3QOXVt0QBn(watcher, new FileSystemEventHandler(CacheFilesWatcher));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 11;
					}
					break;
				case 2:
					return;
				default:
					if (watcher == null)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 5:
				{
					FileSystemWatcher obj = new FileSystemWatcher(CacheFilesDir)
					{
						IncludeSubdirectories = false
					};
					j3iWu9By2lwEMqIgrN7S(obj, true);
					obj.NotifyFilter = NotifyFilters.FileName;
					watcher = obj;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				case 11:
					sIMxdwByPndBFTT8RYLH(watcher, new FileSystemEventHandler(CacheFilesWatcher));
					num2 = 2;
					break;
				case 9:
					j3iWu9By2lwEMqIgrN7S(watcher, Jj1VoGBy1tfo6yMm6QA0(Logger, LogLevel.Information));
					num2 = 10;
					break;
				case 4:
					return;
				case 10:
					return;
				case 8:
					if (watcher != null)
					{
						num2 = 7;
						break;
					}
					goto case 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private void CacheFilesWatcher(object sender, FileSystemEventArgs e)
	{
		int num = 2;
		WatcherChangeTypes watcherChangeTypes = default(WatcherChangeTypes);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (watcherChangeTypes == WatcherChangeTypes.Created)
					{
						Logger.LogFormat(LogLevel.Information, (string)AJJ6D4ByofIIYeCCNkVe(-882126494 ^ -882199292), W1FlbEBy3OaVCJFY8Nlq(e));
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto end_IL_0012;
				case 4:
					if (watcherChangeTypes != WatcherChangeTypes.Deleted)
					{
						num2 = 3;
						break;
					}
					Logger.LogFormat(LogLevel.Information, (string)AJJ6D4ByofIIYeCCNkVe(0x1C9495B4 ^ 0x1C95F13E), W1FlbEBy3OaVCJFY8Nlq(e));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 5:
					return;
				case 0:
					return;
				case 2:
					watcherChangeTypes = A5VNgTByNyXcKqNLKgjk(e);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public virtual bool DeleteByUid(Guid uid)
	{
		//Discarded unreachable code: IL_014b, IL_015a, IL_0268
		int num = 15;
		bool flag = default(bool);
		string text = default(string);
		int num3 = default(int);
		string[] array = default(string[]);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					flag = true;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					flag = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					tPM6Y4ByD5ObDCmdoDoH(text);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					return flag;
				case 8:
				case 16:
					if (num3 >= array.Length)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 9:
					Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(0x53CACA3 ^ 0x53DC87F), CurrentUser, uid);
					num2 = 11;
					continue;
				case 15:
					text2 = (string)ipK3aeBypticGKf8sGIC(uid);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 13;
					}
					continue;
				case 10:
					array = (string[])bWF3HXByaUfWR8dxoqDw(CacheFilesDir, string.Concat(uid, AJJ6D4ByofIIYeCCNkVe(-1876063057 ^ -1876105215)));
					num = 2;
					break;
				case 6:
					Cache.Remove(text2, (string)AJJ6D4ByofIIYeCCNkVe(-1710575414 ^ -1710501058));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					text = array[num3];
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 7;
					}
					continue;
				case 14:
					flag = false;
					num2 = 10;
					continue;
				case 4:
				case 12:
					if (flag)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 11;
				case 3:
					if (!tlxuMqBythdwFhR1dTPI(Cache, text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A49933)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 6;
				case 7:
					Logger.InfoFormat((string)AJJ6D4ByofIIYeCCNkVe(-29254301 ^ -29296171), text);
					num2 = 17;
					continue;
				default:
					num3++;
					num = 8;
					break;
				case 2:
					num3 = 0;
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	public virtual Guid CreateCacheFile(string fileName)
	{
		int num = 2;
		int num2 = num;
		Guid guid = default(Guid);
		TempFileInfo value = default(TempFileInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return Guid.Empty;
			case 2:
				guid = dO6wkdBywZeR9u8rJbgC();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (AddValue(guid, value))
				{
					return guid;
				}
				num2 = 3;
				break;
			case 1:
				value = new TempFileInfo
				{
					FileName = fileName,
					FilePath = GetFilePathPrivate(guid, fileName)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private bool AddValue(Guid uid, TempFileInfo value, bool needSaveName = true)
	{
		//Discarded unreachable code: IL_00ed, IL_00fc, IL_01c5, IL_01d4, IL_024b, IL_025a
		int num = 3;
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (needSaveName)
					{
						num2 = 11;
						continue;
					}
					break;
				case 11:
					BvJrdQBy4NfBFYw2jTk4(value.FilePath + (string)AJJ6D4ByofIIYeCCNkVe(-1633514411 ^ -1633425079), value.FileName.ToBase64String());
					num2 = 6;
					continue;
				case 13:
					if (!nj2IfbBy6JYF52tYjEZ8(fileInfo))
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				case 3:
					Cache.Insert((string)ipK3aeBypticGKf8sGIC(uid), value, (string)AJJ6D4ByofIIYeCCNkVe(-1767720453 ^ -1767646705), FileCleaner.cacheDuration);
					num2 = 2;
					continue;
				case 5:
				case 6:
				case 8:
					Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(-1426094279 ^ -1426136575), CurrentUser, value.FileName, uid, value.FilePath);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					hT8XtLByHYurNgshAqZM(fileInfo, qghom1ByAk0KBvJ1IQcC());
					num2 = 8;
					continue;
				case 7:
					return true;
				case 4:
				case 9:
					fileInfo = new FileInfo(value.FilePath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35937031));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 13;
					}
					continue;
				case 12:
					goto end_IL_0012;
				default:
					if (!nj2IfbBy6JYF52tYjEZ8(fileInfo))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto end_IL_0012;
				case 10:
					break;
				}
				fileInfo = new FileInfo(value.FilePath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			hT8XtLByHYurNgshAqZM(fileInfo, DateTime.Now);
			num = 4;
		}
	}

	public virtual bool CreateCacheFileByUid(Guid uid, string fileName)
	{
		//Discarded unreachable code: IL_00d8, IL_00e7, IL_00f7, IL_0106, IL_0180, IL_01b6, IL_0286, IL_02be, IL_02cd
		int num = 2;
		int num2 = num;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (AddValue(uid, tempFileInfo))
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 1:
				if (tlxuMqBythdwFhR1dTPI(Cache, ipK3aeBypticGKf8sGIC(uid), AJJ6D4ByofIIYeCCNkVe(0x3A6135BE ^ 0x3A60564A)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 2:
				tempFileInfo = new TempFileInfo
				{
					FileName = fileName,
					FilePath = GetFilePathPrivate(uid, fileName)
				};
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (Directory.EnumerateFiles(CacheFilesDir, (string)MEqmD0ByT5SM9vHJKUs5(uid, AJJ6D4ByofIIYeCCNkVe(-1317790512 ^ -1317701506))).Any())
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 8;
			case 5:
				return false;
			default:
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				return result;
			case 6:
				try
				{
					int num3;
					if (File.Exists(tempFileInfo.FilePath))
					{
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num3 = 1;
						}
						goto IL_01ba;
					}
					goto IL_0223;
					IL_0223:
					result = true;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num3 = 0;
					}
					goto IL_01ba;
					IL_01ba:
					while (true)
					{
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 3:
							Logger.InfoFormat((string)AJJ6D4ByofIIYeCCNkVe(-488881205 ^ -488823231), CurrentUser, tempFileInfo.FilePath);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							break;
						case 2:
							tPM6Y4ByD5ObDCmdoDoH(tempFileInfo.FilePath);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					goto IL_0223;
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return result;
						}
						result = false;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num4 = 1;
						}
					}
				}
			}
		}
	}

	protected virtual TempFileInfo GetTempFileInfo(Guid uid)
	{
		//Discarded unreachable code: IL_0199, IL_01a8, IL_01f0, IL_01ff, IL_0286, IL_0310, IL_0371
		int num = 12;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(-1217523399 ^ -1217431755), CurrentUser, tempFileInfo.FileName, uid, tempFileInfo.FilePath);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 5;
					}
					break;
				case 4:
				case 15:
					if (tempFileInfo != null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 7:
				case 8:
					Logger.WarnFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C525E77), CurrentUser, uid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				case 10:
					Logger.WarnFormat((string)AJJ6D4ByofIIYeCCNkVe(0x269E5FCA ^ 0x269F3986), CurrentUser, uid, CiG4YMByyHC8WtvQ5aTd());
					num2 = 17;
					break;
				case 11:
					if (tempFileInfo != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 6;
				default:
					return tempFileInfo;
				case 14:
					if (string.IsNullOrWhiteSpace(text))
					{
						num2 = 4;
						break;
					}
					goto case 2;
				case 2:
					text2 = (string)G5ZRIFBym9IDD5TNqHrP(Yu4qNvBy7aQ43fNUZGAC(), EcQiVLBy02bKHUrVLBk6(wTjwdHByxJDJXw0jnY7L(text)));
					num2 = 9;
					break;
				case 6:
					Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(-1939377524 ^ -1939466438), CurrentUser, uid);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 9;
					}
					break;
				case 1:
					if (!Lkj7OhByiyt5C7FvD6pF(Logger))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 10;
				case 9:
					tempFileInfo = new TempFileInfo
					{
						FileName = text2,
						FilePath = GetFilePathPrivate(uid, text2)
					};
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 9;
					}
					break;
				case 12:
					tempFileInfo = Cache.Get<TempFileInfo>(GetKey(uid), (string)AJJ6D4ByofIIYeCCNkVe(-1411196499 ^ -1411138983));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 11;
					}
					break;
				case 18:
					text = Directory.EnumerateFiles(CacheFilesDir, (string)MEqmD0ByT5SM9vHJKUs5(uid, AJJ6D4ByofIIYeCCNkVe(0x1FFEF86A ^ 0x1FFF9D90))).FirstOrDefault();
					num2 = 14;
					break;
				case 5:
					AddValue(uid, tempFileInfo, needSaveName: false);
					num2 = 16;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	public virtual bool IncrementCacheFile(Guid uid, [NotNull] Stream inputStream, long startPos = 0L, long endPos = long.MaxValue)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_01b1, IL_0224, IL_025c, IL_026b, IL_02b2, IL_0339, IL_03cc, IL_03db
		int num = 9;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		bool result = default(bool);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (tempFileInfo != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto end_IL_0012;
				case 6:
					return result;
				default:
					return false;
				case 3:
					tempFileInfo = (TempFileInfo)rq8Vi3ByMm7jUVX133Wv(this, uid);
					num2 = 7;
					break;
				case 2:
					try
					{
						EnsureCacheDirectory();
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							default:
							{
								Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(0x638095EB ^ 0x6381F2F7), CurrentUser, tempFileInfo.FileName, uid, tempFileInfo.FilePath, startPos);
								int num6 = 5;
								num3 = num6;
								break;
							}
							case 2:
								d6eHgSBydAILEDgwNpaK(LF9KLEBy9Ryl5t4bjcA1(tempFileInfo.FilePath));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num3 = 0;
								}
								break;
							case 6:
								result = true;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 1;
								}
								break;
							case 3:
								if (!Lgx56rByJYoYrkMGKWnR(tempFileInfo.FilePath))
								{
									num3 = 2;
									break;
								}
								goto default;
							case 4:
								try
								{
									eSv3I9Byl3qpsL7ot6i8(fileStream, startPos, SeekOrigin.Begin);
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										case 1:
											fileStream.Flush();
											num4 = 2;
											continue;
										default:
											q4Z9hKByrvToUFCRjnyI(inputStream, fileStream);
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
											{
												num4 = 1;
											}
											continue;
										case 2:
											break;
										}
										break;
									}
								}
								finally
								{
									if (fileStream != null)
									{
										int num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
										{
											num5 = 1;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												gkZTvFByvjPDSGPIT9Kw(fileStream);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
								goto case 6;
							case 5:
								fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 4;
								}
								break;
							}
						}
					}
					catch (Exception exception)
					{
						int num7 = 2;
						while (true)
						{
							switch (num7)
							{
							case 1:
								return result;
							case 2:
								Logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317700680), uid), exception);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num7 = 0;
								}
								break;
							default:
								result = false;
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num7 = 1;
								}
								break;
							}
						}
					}
				case 1:
					throw new ArgumentException(SR.T((string)AJJ6D4ByofIIYeCCNkVe(0x76DD48E ^ 0x76CB25A)), (string)AJJ6D4ByofIIYeCCNkVe(0x92F12D5 ^ 0x92E746F));
				case 4:
					if (endPos > startPos)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 8:
					throw new ArgumentNullException((string)AJJ6D4ByofIIYeCCNkVe(-1638402543 ^ -1638494037));
				case 9:
					if (inputStream != null)
					{
						if (inputStream.CanRead)
						{
							num2 = 4;
							break;
						}
						goto case 1;
					}
					num2 = 8;
					break;
				case 5:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public bool IncrementCacheFile(Guid uid, byte[] buf, long startPos = 0L, long endPos = long.MaxValue)
	{
		//Discarded unreachable code: IL_009f, IL_00f0, IL_0238, IL_02ae, IL_02e6, IL_03a8
		int num = 5;
		int num2 = num;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		bool result = default(bool);
		FileStream fileStream = default(FileStream);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 6:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BAD28E));
			case 4:
				if (endPos <= startPos)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					tempFileInfo = (TempFileInfo)rq8Vi3ByMm7jUVX133Wv(this, uid);
					num2 = 2;
				}
				break;
			case 1:
				return false;
			case 5:
				if (buf != null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 3:
				return result;
			default:
				return false;
			case 2:
				if (tempFileInfo != null)
				{
					num2 = 7;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				try
				{
					EnsureCacheDirectory();
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						case 4:
							fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num3 = 7;
							}
							break;
						case 5:
							result = true;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num3 = 1;
							}
							break;
						case 6:
							num5 = Xs9j5IBy5fYcXsavNAIa(xHd3YpBygqDxKXVPa2nH(buf.LongLength, endPos - startPos));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							d6eHgSBydAILEDgwNpaK(LF9KLEBy9Ryl5t4bjcA1(tempFileInfo.FilePath));
							num3 = 6;
							break;
						default:
							Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(-541731959 ^ -541805517), CurrentUser, tempFileInfo.FileName, uid, tempFileInfo.FilePath, startPos, num5);
							num3 = 4;
							break;
						case 7:
							try
							{
								fileStream.Seek(startPos, SeekOrigin.Begin);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										EYaxZhByYEFZvhRRqTWc(fileStream);
										num4 = 2;
										continue;
									default:
										RK3lbMByj3GQR5YMA7dX(fileStream, buf, 0, num5);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
										{
											num4 = 1;
										}
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							finally
							{
								if (fileStream != null)
								{
									int num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
									{
										num6 = 1;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											((IDisposable)fileStream).Dispose();
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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
							goto case 5;
						case 2:
							if (!Lgx56rByJYoYrkMGKWnR(tempFileInfo.FilePath))
							{
								num3 = 3;
								break;
							}
							goto case 6;
						}
					}
				}
				catch (Exception ex)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 2:
							return result;
						case 1:
						{
							result = false;
							int num8 = 2;
							num7 = num8;
							continue;
						}
						}
						Pp27sJBy8KNKfadcO3AM(Logger, SR.T((string)AJJ6D4ByofIIYeCCNkVe(--1360331293 ^ 0x51146575), uid), ex);
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num7 = 1;
						}
					}
				}
			}
		}
	}

	public virtual bool AppendCacheFile(Guid uid, [NotNull] byte[] buf, int cnt)
	{
		//Discarded unreachable code: IL_0041, IL_006c, IL_012b, IL_0188, IL_01a7, IL_01b6, IL_01e3, IL_01f2, IL_0255, IL_027f, IL_02b7, IL_0358, IL_0367
		int num = 2;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		FileStream fileStream = default(FileStream);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						EnsureCacheDirectory();
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 6:
								Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(0x3B36AB09 ^ 0x3B37C307), CurrentUser, tempFileInfo.FileName, uid, tempFileInfo.FilePath);
								num3 = 2;
								break;
							case 2:
								fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
								num3 = 7;
								break;
							case 7:
								try
								{
									RK3lbMByj3GQR5YMA7dX(fileStream, buf, 0, cnt);
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										default:
											EYaxZhByYEFZvhRRqTWc(fileStream);
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
											{
												num4 = 0;
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
									if (fileStream == null)
									{
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
										{
											num5 = 0;
										}
										goto IL_018c;
									}
									goto IL_01c1;
									IL_01c1:
									((IDisposable)fileStream).Dispose();
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
									{
										num5 = 0;
									}
									goto IL_018c;
									IL_018c:
									switch (num5)
									{
									default:
										goto end_IL_0167;
									case 2:
										goto end_IL_0167;
									case 1:
										break;
									case 0:
										goto end_IL_0167;
									}
									goto IL_01c1;
									end_IL_0167:;
								}
								goto default;
							case 5:
								if (Lgx56rByJYoYrkMGKWnR(tempFileInfo.FilePath))
								{
									num3 = 6;
									break;
								}
								goto case 3;
							case 3:
								d6eHgSBydAILEDgwNpaK(File.Create(tempFileInfo.FilePath));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num3 = 1;
								}
								break;
							default:
								result = true;
								num3 = 4;
								break;
							case 4:
								return result;
							}
						}
					}
					catch (Exception)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								result = false;
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num6 = 0;
								}
								break;
							default:
								return result;
							case 0:
								return result;
							}
						}
					}
				case 5:
					throw new ArgumentNullException((string)AJJ6D4ByofIIYeCCNkVe(0xD3DEF7E ^ 0xD3C88CE));
				case 1:
					break;
				default:
					return false;
				case 4:
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					if (tempFileInfo != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto default;
				case 2:
					if (buf != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 3:
					return result;
				}
				break;
			}
			tempFileInfo = GetTempFileInfo(uid);
			num = 7;
		}
	}

	public bool AppendCacheFile(Guid uid, [NotNull] Stream inputStream)
	{
		//Discarded unreachable code: IL_0041, IL_01c9, IL_0226, IL_0245, IL_0254, IL_0271, IL_0280, IL_02f1, IL_0329, IL_0338
		int num = 7;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		bool result = default(bool);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return false;
				case 2:
					num2 = 5;
					break;
				default:
					if (tempFileInfo != null)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 3:
					throw new ArgumentException((string)q7gwsrByLV26r1oss90n(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398620792)), (string)AJJ6D4ByofIIYeCCNkVe(-1921202237 ^ -1921146503));
				case 7:
					if (inputStream == null)
					{
						num2 = 6;
					}
					else if (inputStream.CanRead)
					{
						tempFileInfo = GetTempFileInfo(uid);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 3;
					}
					break;
				case 1:
					return result;
				case 5:
					try
					{
						EnsureCacheDirectory();
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								return result;
							default:
								fileStream = new FileStream(tempFileInfo.FilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
								num3 = 5;
								break;
							case 3:
							{
								result = true;
								int num4 = 4;
								num3 = num4;
								break;
							}
							case 2:
								Logger.DebugFormat((string)AJJ6D4ByofIIYeCCNkVe(-1638402543 ^ -1638490593), CurrentUser, tempFileInfo.FileName, uid, tempFileInfo.FilePath);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 0;
								}
								break;
							case 5:
								try
								{
									q4Z9hKByrvToUFCRjnyI(inputStream, fileStream);
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											EYaxZhByYEFZvhRRqTWc(fileStream);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
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
								finally
								{
									int num6;
									if (fileStream == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
										{
											num6 = 1;
										}
										goto IL_022a;
									}
									goto IL_025f;
									IL_025f:
									gkZTvFByvjPDSGPIT9Kw(fileStream);
									num6 = 2;
									goto IL_022a;
									IL_022a:
									switch (num6)
									{
									case 1:
										goto end_IL_0205;
									case 2:
										goto end_IL_0205;
									}
									goto IL_025f;
									end_IL_0205:;
								}
								goto case 3;
							case 6:
								d6eHgSBydAILEDgwNpaK(LF9KLEBy9Ryl5t4bjcA1(tempFileInfo.FilePath));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num3 = 0;
								}
								break;
							case 1:
								if (!Lgx56rByJYoYrkMGKWnR(tempFileInfo.FilePath))
								{
									num3 = 6;
									break;
								}
								goto case 2;
							}
						}
					}
					catch (Exception)
					{
						int num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								return result;
							case 0:
								return result;
							case 1:
								result = false;
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num7 = 0;
								}
								break;
							}
						}
					}
				case 6:
					throw new ArgumentNullException((string)AJJ6D4ByofIIYeCCNkVe(0x4785BC0D ^ 0x4784DAB7));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public virtual string GetFileName(Guid uid)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				tempFileInfo = GetTempFileInfo(uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (tempFileInfo != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return "";
			default:
				return tempFileInfo.FileName;
			}
		}
	}

	public virtual string GetFilePath(Guid uid)
	{
		int num = 1;
		int num2 = num;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return "";
			case 1:
				tempFileInfo = (TempFileInfo)rq8Vi3ByMm7jUVX133Wv(this, uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (tempFileInfo != null)
			{
				return tempFileInfo.FilePath;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual long GetFileLength(Guid uid)
	{
		//Discarded unreachable code: IL_0065
		int num = 5;
		int num2 = num;
		TempFileInfo tempFileInfo = default(TempFileInfo);
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (tempFileInfo != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				return 0L;
			case 3:
				return 0L;
			case 1:
				fileInfo = new FileInfo(tempFileInfo.FilePath);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (fileInfo.Exists)
				{
					return AT9ayUByUhnrcIFuImrG(fileInfo);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				tempFileInfo = (TempFileInfo)rq8Vi3ByMm7jUVX133Wv(this, uid);
				num2 = 4;
				break;
			}
		}
	}

	public void Init()
	{
	}

	public void InitComplete()
	{
		//Discarded unreachable code: IL_0108, IL_01ed, IL_01fc
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				IFileManager service = Locator.GetService<IFileManager>();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 0;
				}
				string value = default(string);
				while (true)
				{
					int num2;
					object obj;
					switch (num)
					{
					case 3:
						return;
					case 7:
						EnsureCacheDirectory();
						num = 3;
						continue;
					case 6:
						value = (string)hhohlJBycAWmFpJxsKUu(AJJ6D4ByofIIYeCCNkVe(--1867379187 ^ 0x6F4C99A3));
						num = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num = 5;
						}
						continue;
					case 5:
						cacheFilesDirectory = value;
						num2 = 2;
						goto IL_0047;
					default:
						if (service == null)
						{
							num = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num = 3;
							}
							continue;
						}
						obj = hFZQh9BysJEnFcH3X3cN(service);
						break;
					case 2:
						RemoveCacheDirectory();
						num2 = 7;
						goto IL_0047;
					case 4:
						obj = null;
						break;
					case 1:
						{
							if (string.IsNullOrEmpty(value))
							{
								num = 6;
								continue;
							}
							goto case 5;
						}
						IL_0047:
						num = num2;
						continue;
					}
					value = (string)obj;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num = 1;
					}
				}
			}
			catch (Exception innerException)
			{
				int num3 = 2;
				int num4 = num3;
				InvalidOperationException ex = default(InvalidOperationException);
				while (true)
				{
					switch (num4)
					{
					case 2:
						ex = new InvalidOperationException((string)q7gwsrByLV26r1oss90n(AJJ6D4ByofIIYeCCNkVe(-35995181 ^ -35935837)), innerException);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num4 = 0;
						}
						break;
					case 1:
						Pp27sJBy8KNKfadcO3AM(Logger, AJJ6D4ByofIIYeCCNkVe(0x49E27B8A ^ 0x49E31350), ex);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num4 = 0;
						}
						break;
					default:
						throw ex;
					}
				}
			}
		}
	}

	public CacheFilesService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		qiI97KByzwsCPc1EOhGY();
		cacheFilesDirectory = "";
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Apo2DxByBGbdTPsVGUxy()
	{
		return vAphfdByFiFvMlMtDAh9 == null;
	}

	internal static CacheFilesService E31pulByWHwx8K7cc9vS()
	{
		return vAphfdByFiFvMlMtDAh9;
	}

	internal static object AJJ6D4ByofIIYeCCNkVe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void IDovjHBybiOL2BHBlccv(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void CPA9R9Byhm7v9oVKbAUc(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object DBPk8UByG1SZQctnQYw9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Guid pIAir7ByEsx8PcN2lspU(object P_0, object P_1)
	{
		return ((CacheFilesService)P_0).CreateCacheFile((string)P_1);
	}

	internal static object cuCqK1ByflxIQ6NyjqBC(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object eNBE3IByQeLFjTv47uEe(object P_0)
	{
		return ((StructuredFileFolder)P_0).Name;
	}

	internal static object akFwesByCtfnO0Iv4ZHS(object P_0, object P_1, object P_2)
	{
		return ((IZipService)P_0).CreateZipFolder((string)P_1, (string)P_2);
	}

	internal static void gkZTvFByvjPDSGPIT9Kw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void Pp27sJBy8KNKfadcO3AM(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void FbwtyjByZisrujCigLCi(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static bool K586s4ByuNLZFNKW6iwd(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object wPX301ByIuql4vat9OJU(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object PpJoLYByVQ7P9wa9d5bx(object P_0)
	{
		return EleWise.ELMA.Logging.Logger.GetLogger((string)P_0);
	}

	internal static void nWYheUBySKuXqtQRRxul(object P_0, object P_1)
	{
		((ILogger)P_0).ConfigurationChanged += (EventHandler)P_1;
	}

	internal static bool Lkj7OhByiyt5C7FvD6pF(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static object gZ32bBByRiSbvBFD1BIk()
	{
		return AuthenticationService;
	}

	internal static object ygjytAByqXr8X3jWNUu7(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object pJWsntByKqnNQTBVXDni(object P_0)
	{
		return ((IUser)P_0).UserName;
	}

	internal static bool HqQH7EByX9ADbPJ5AJv9(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object MEqmD0ByT5SM9vHJKUs5(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object OdC8miByk1Z1WEn8qH9s(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void Wu9jvdBynIkjUjbYTX7M(object P_0)
	{
		FileCleaner.CleanFiles((string)P_0);
	}

	internal static void vBeLg9ByOrLD4JKYdlek(object P_0)
	{
		FileCleaner.SetCacheFilesDirectory((string)P_0);
	}

	internal static void j3iWu9By2lwEMqIgrN7S(object P_0, bool P_1)
	{
		((FileSystemWatcher)P_0).EnableRaisingEvents = P_1;
	}

	internal static void RKKvlAByeP3QOXVt0QBn(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Created += (FileSystemEventHandler)P_1;
	}

	internal static void sIMxdwByPndBFTT8RYLH(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Deleted += (FileSystemEventHandler)P_1;
	}

	internal static bool Jj1VoGBy1tfo6yMm6QA0(object P_0, LogLevel level)
	{
		return ((ILogger)P_0).IsEnabled(level);
	}

	internal static WatcherChangeTypes A5VNgTByNyXcKqNLKgjk(object P_0)
	{
		return ((FileSystemEventArgs)P_0).ChangeType;
	}

	internal static object W1FlbEBy3OaVCJFY8Nlq(object P_0)
	{
		return ((FileSystemEventArgs)P_0).FullPath;
	}

	internal static object ipK3aeBypticGKf8sGIC(Guid key)
	{
		return GetKey(key);
	}

	internal static object bWF3HXByaUfWR8dxoqDw(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static void tPM6Y4ByD5ObDCmdoDoH(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static bool tlxuMqBythdwFhR1dTPI(object P_0, object P_1, object P_2)
	{
		return ((ICacheService)P_0).Contains((string)P_1, (string)P_2);
	}

	internal static Guid dO6wkdBywZeR9u8rJbgC()
	{
		return Guid.NewGuid();
	}

	internal static void BvJrdQBy4NfBFYw2jTk4(object P_0, object P_1)
	{
		File.WriteAllText((string)P_0, (string)P_1);
	}

	internal static bool nj2IfbBy6JYF52tYjEZ8(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static void hT8XtLByHYurNgshAqZM(object P_0, DateTime P_1)
	{
		((FileSystemInfo)P_0).LastWriteTime = P_1;
	}

	internal static DateTime qghom1ByAk0KBvJ1IQcC()
	{
		return DateTime.Now;
	}

	internal static object Yu4qNvBy7aQ43fNUZGAC()
	{
		return Encoding.UTF8;
	}

	internal static object wTjwdHByxJDJXw0jnY7L(object P_0)
	{
		return File.ReadAllText((string)P_0);
	}

	internal static object EcQiVLBy02bKHUrVLBk6(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object G5ZRIFBym9IDD5TNqHrP(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static object CiG4YMByyHC8WtvQ5aTd()
	{
		return Environment.StackTrace;
	}

	internal static object rq8Vi3ByMm7jUVX133Wv(object P_0, Guid uid)
	{
		return ((CacheFilesService)P_0).GetTempFileInfo(uid);
	}

	internal static bool Lgx56rByJYoYrkMGKWnR(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object LF9KLEBy9Ryl5t4bjcA1(object P_0)
	{
		return File.Create((string)P_0);
	}

	internal static void d6eHgSBydAILEDgwNpaK(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static long eSv3I9Byl3qpsL7ot6i8(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void q4Z9hKByrvToUFCRjnyI(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static long xHd3YpBygqDxKXVPa2nH(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int Xs9j5IBy5fYcXsavNAIa(long P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static void RK3lbMByj3GQR5YMA7dX(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void EYaxZhByYEFZvhRRqTWc(object P_0)
	{
		((Stream)P_0).Flush();
	}

	internal static object q7gwsrByLV26r1oss90n(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static long AT9ayUByUhnrcIFuImrG(object P_0)
	{
		return ((FileInfo)P_0).Length;
	}

	internal static object hFZQh9BysJEnFcH3X3cN(object P_0)
	{
		return ((IFileManager)P_0).TempFilesPath;
	}

	internal static object hhohlJBycAWmFpJxsKUu(object P_0)
	{
		return IOExtensions.GetTempPath((string)P_0);
	}

	internal static void qiI97KByzwsCPc1EOhGY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
