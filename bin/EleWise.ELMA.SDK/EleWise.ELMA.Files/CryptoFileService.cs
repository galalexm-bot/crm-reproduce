using System;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

[Component]
internal class CryptoFileService : ICryptoContextAuthServiceImpl
{
	[Serializable]
	private class EncryptFilePasswordToken
	{
		internal static object a4AfTjvcPfR5eorM2MUX;

		public string PasswordHash
		{
			[CompilerGenerated]
			get
			{
				return _003CPasswordHash_003Ek__BackingField;
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
						_003CPasswordHash_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

		public DateTime DateCreate
		{
			[CompilerGenerated]
			get
			{
				return _003CDateCreate_003Ek__BackingField;
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
						_003CDateCreate_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
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

		public EncryptFilePasswordToken()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			lIYijpvc3LsVrr8DHWfr();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool l59sf7vc1QyZNJLhfK6e()
		{
			return a4AfTjvcPfR5eorM2MUX == null;
		}

		internal static EncryptFilePasswordToken CNlKFMvcNE3L7Sxs0Uxm()
		{
			return (EncryptFilePasswordToken)a4AfTjvcPfR5eorM2MUX;
		}

		internal static void lIYijpvc3LsVrr8DHWfr()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static TimeSpan validTokenTime;

	private readonly IFileManager fileManager;

	private readonly IAuthenticationService authenticationService;

	private readonly ISessionBoundVariableService sessionService;

	private readonly ICacheService cacheService;

	private readonly IFilePreviewService previewService;

	private static CryptoFileService AJKwo1GKHkMb2LgQKdZk;

	public ICryptoContextAuthService CryptoContextAuthService
	{
		[CompilerGenerated]
		get
		{
			return _003CCryptoContextAuthService_003Ek__BackingField;
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
					_003CCryptoContextAuthService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
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

	public CryptoFileService(IFileManager fileManager, IAuthenticationService authenticationService, ISessionBoundVariableService sessionService, ICacheService cacheService, IFilePreviewService previewService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		docDWZGKxJ0QtyaUTDq1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			default:
				this.fileManager = fileManager;
				num = 2;
				break;
			case 1:
				this.cacheService = cacheService;
				num = 3;
				break;
			case 2:
				this.authenticationService = authenticationService;
				num = 4;
				break;
			case 3:
				this.previewService = previewService;
				num = 5;
				break;
			case 4:
				this.sessionService = sessionService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public bool CheckType(IEntity entity)
	{
		return entity is FileStoreProvider.BinaryFileWrapper;
	}

	public IEntity DecryptFromContext(IEntity entity)
	{
		throw new NotImplementedException();
	}

	public string GetPasswordFromContext(IEntity entity)
	{
		//Discarded unreachable code: IL_014d
		int num = 2;
		int num2 = num;
		string text = default(string);
		EncryptFilePasswordToken value = default(EncryptFilePasswordToken);
		BinaryFile binaryFile = default(BinaryFile);
		IUser currentUser = default(IUser);
		string key = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			default:
				if (sessionService.TryGetValue<EncryptFilePasswordToken>(text, out value))
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 2:
				if (IsSignForEntity(entity))
				{
					binaryFile = (BinaryFile)v4eXNZGK0ENGFxTMHv9j((FileStoreProvider.BinaryFileWrapper)entity);
					num2 = 3;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return (string)Lgqy8LGKJ90m3jPhNLG6(value.PasswordHash);
			case 5:
				text = (string)R7C4YjGKyamu7mq3FxUj(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870880547), FlpVxPGKmB1hSw4BhblJ(0x92F12D5 ^ 0x92CCCFB), binaryFile.Id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				eWWSRKGKldk3Rh2HpdTc(sessionService, text, value);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 6;
				}
				break;
			case 3:
				currentUser = authenticationService.GetCurrentUser<IUser>();
				num2 = 5;
				break;
			case 6:
				return (string)Lgqy8LGKJ90m3jPhNLG6(N6lKARGKMTHWs0lWrVxP(value));
			case 8:
				key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979393417), FlpVxPGKmB1hSw4BhblJ(-1633514411 ^ -1633594757), MeyIN8GK9xiv581ZE2Ck(binaryFile), d7APtaGKdQyG4uZkMdhy(currentUser));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 9;
				}
				break;
			case 4:
				if (value == null)
				{
					num2 = 8;
					break;
				}
				goto case 6;
			case 9:
				if (!cacheService.TryGetValue<EncryptFilePasswordToken>(key, out value))
				{
					return null;
				}
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public bool IsSignForEntity(IEntity entity)
	{
		//Discarded unreachable code: IL_00d1, IL_00e0, IL_01af
		int num = 14;
		IUser currentUser = default(IUser);
		string text = default(string);
		EncryptFilePasswordToken value = default(EncryptFilePasswordToken);
		BinaryFile binaryFile = default(BinaryFile);
		DateTime dateTime = default(DateTime);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					currentUser = authenticationService.GetCurrentUser<IUser>();
					num2 = 15;
					continue;
				case 8:
					if (!sessionService.TryGetValue<EncryptFilePasswordToken>(text, out value))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 18;
				case 5:
					return false;
				case 18:
					if (value != null)
					{
						num = 4;
						break;
					}
					goto case 11;
				case 17:
					if (!CheckPassword(binaryFile, (string)Lgqy8LGKJ90m3jPhNLG6(value.PasswordHash)))
					{
						num2 = 10;
						continue;
					}
					goto case 2;
				case 4:
					if (Dx7vvBGKg1mbI1brjcww(dateTime, value.DateCreate) > validTokenTime)
					{
						num2 = 6;
						continue;
					}
					if (CheckPassword(binaryFile, (string)Lgqy8LGKJ90m3jPhNLG6(N6lKARGKMTHWs0lWrVxP(value))))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 10;
				case 14:
					binaryFile = (BinaryFile)v4eXNZGK0ENGFxTMHv9j((FileStoreProvider.BinaryFileWrapper)entity);
					num2 = 13;
					continue;
				case 9:
					HgjIoGGKY7uDOtRQMX4j(cacheService, text2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 5;
					}
					continue;
				case 19:
					if (cacheService.TryGetValue<EncryptFilePasswordToken>(text2, out value))
					{
						num = 12;
						break;
					}
					goto case 10;
				case 16:
					return true;
				case 10:
					return false;
				case 15:
					text = (string)R7C4YjGKyamu7mq3FxUj(FlpVxPGKmB1hSw4BhblJ(0x18A6761F ^ 0x18A6A4F5), FlpVxPGKmB1hSw4BhblJ(-1867198571 ^ -1867050565), binaryFile.Id);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					value.DateCreate = dateTime;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 14;
					}
					continue;
				default:
					return true;
				case 11:
					text2 = (string)p2CHDyGK5UPbf4tQlphL(FlpVxPGKmB1hSw4BhblJ(-672123589 ^ -671880323), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939559262), binaryFile.Id, d7APtaGKdQyG4uZkMdhy(currentUser));
					num2 = 19;
					continue;
				case 7:
					value.DateCreate = dateTime;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return false;
				case 1:
					dateTime = f1MBOxGKr7amCUVl96tK();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					if (!jofgasGKjCgwJ0xx7TVf(Dx7vvBGKg1mbI1brjcww(dateTime, value.DateCreate), validTokenTime))
					{
						sessionService.Set(text, value);
						num2 = 17;
						continue;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					sessionService.Remove(text);
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	public bool SignInForEntity(IEntity entity, string password)
	{
		//Discarded unreachable code: IL_0167
		int num = 10;
		int num2 = num;
		string text = default(string);
		EncryptFilePasswordToken value = default(EncryptFilePasswordToken);
		BinaryFile file = default(BinaryFile);
		string name = default(string);
		IUser currentUser = default(IUser);
		string key = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				EncryptFilePasswordToken encryptFilePasswordToken = new EncryptFilePasswordToken();
				DsXqb8GKUsIqYsh1KQq9(encryptFilePasswordToken, text);
				rBrK6CGKs5auuISWnLvO(encryptFilePasswordToken, f1MBOxGKr7amCUVl96tK());
				value = encryptFilePasswordToken;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 10:
				file = ((FileStoreProvider.BinaryFileWrapper)entity).File;
				num2 = 9;
				break;
			case 7:
				return false;
			case 5:
				text = (string)EuNveyGKLQ8DJ4rwtJ0D(password);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				name = (string)R7C4YjGKyamu7mq3FxUj(FlpVxPGKmB1hSw4BhblJ(0x3B36AB09 ^ 0x3B3679E3), FlpVxPGKmB1hSw4BhblJ(-978351861 ^ -978561243), file.Id);
				num2 = 3;
				break;
			default:
				return true;
			case 6:
				currentUser = AuthenticationService.GetCurrentUser<IUser>();
				num2 = 2;
				break;
			case 9:
				if (CheckPassword(file, password))
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 3:
				sessionService.Set(name, value);
				num2 = 8;
				break;
			case 4:
				cacheService.Insert(key, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				key = (string)p2CHDyGK5UPbf4tQlphL(FlpVxPGKmB1hSw4BhblJ(0x26FFCB59 ^ 0x26FC151F), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A2BA21), file.Id, d7APtaGKdQyG4uZkMdhy(currentUser));
				num2 = 4;
				break;
			}
		}
	}

	public void SignOutForEntity(IEntity entity)
	{
		int num = 3;
		int num2 = num;
		IUser currentUser = default(IUser);
		string key = default(string);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				currentUser = AuthenticationService.GetCurrentUser<IUser>();
				num2 = 5;
				break;
			case 6:
				key = (string)p2CHDyGK5UPbf4tQlphL(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3131BF40), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A6FD70), text, d7APtaGKdQyG4uZkMdhy(currentUser));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				break;
			default:
				lnbOGxGKckLegGv6eclb(sessionService, text2);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				text2 = (string)R7C4YjGKyamu7mq3FxUj(FlpVxPGKmB1hSw4BhblJ(-1411196499 ^ -1411249337), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76E0AA0), text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				cacheService.Remove(key);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				text = (string)entity.GetId();
				num2 = 2;
				break;
			case 4:
				return;
			}
		}
	}

	private bool CheckPassword(BinaryFile file, string password)
	{
		int num = 2;
		int num2 = num;
		IEntity entity = default(IEntity);
		string fileEncryptPassword = default(string);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (entity == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 4;
					}
					break;
				}
				fileEncryptPassword = (string)vqZXLRGXBs0va34s6NJP(CryptoContextAuthService, entity);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (XqdoMwGKzmosqmf0GCsr(_003C_003Ec__DisplayClass20_.file))
				{
					num2 = 3;
					break;
				}
				return Lkaf3jGXWo8rt9c8m26t(previewService, _003C_003Ec__DisplayClass20_.file, password);
			case 5:
				return false;
			case 2:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return previewService.CheckPassword(_003C_003Ec__DisplayClass20_.file, fileEncryptPassword, password);
			case 1:
				_003C_003Ec__DisplayClass20_.file = file;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				entity = ((ComponentManager)eKcIAXGXF33Ki6vLBJhD()).GetExtensionPoints<IBinaryFileParentEntity>().Select(_003C_003Ec__DisplayClass20_._003CCheckPassword_003Eb__0).FirstOrDefault((IEntity p) => p != null);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	static CryptoFileService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				docDWZGKxJ0QtyaUTDq1();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				validTokenTime = new TimeSpan(0, 0, 5, 0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool CiV3a4GKAnhbeKpAZRNj()
	{
		return AJKwo1GKHkMb2LgQKdZk == null;
	}

	internal static CryptoFileService EDMtwtGK7TpcN4bq6D5k()
	{
		return AJKwo1GKHkMb2LgQKdZk;
	}

	internal static void docDWZGKxJ0QtyaUTDq1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object v4eXNZGK0ENGFxTMHv9j(object P_0)
	{
		return ((FileStoreProvider.BinaryFileWrapper)P_0).File;
	}

	internal static object FlpVxPGKmB1hSw4BhblJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object R7C4YjGKyamu7mq3FxUj(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object N6lKARGKMTHWs0lWrVxP(object P_0)
	{
		return ((EncryptFilePasswordToken)P_0).PasswordHash;
	}

	internal static object Lgqy8LGKJ90m3jPhNLG6(object P_0)
	{
		return EncryptionHelper.DecryptPwd((string)P_0);
	}

	internal static object MeyIN8GK9xiv581ZE2Ck(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static object d7APtaGKdQyG4uZkMdhy(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void eWWSRKGKldk3Rh2HpdTc(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static DateTime f1MBOxGKr7amCUVl96tK()
	{
		return DateTime.Now;
	}

	internal static TimeSpan Dx7vvBGKg1mbI1brjcww(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object p2CHDyGK5UPbf4tQlphL(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool jofgasGKjCgwJ0xx7TVf(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 > P_1;
	}

	internal static void HgjIoGGKY7uDOtRQMX4j(object P_0, object P_1)
	{
		((ICacheService)P_0).Remove((string)P_1);
	}

	internal static object EuNveyGKLQ8DJ4rwtJ0D(object P_0)
	{
		return EncryptionHelper.EncryptPwd((string)P_0);
	}

	internal static void DsXqb8GKUsIqYsh1KQq9(object P_0, object P_1)
	{
		((EncryptFilePasswordToken)P_0).PasswordHash = (string)P_1;
	}

	internal static void rBrK6CGKs5auuISWnLvO(object P_0, DateTime value)
	{
		((EncryptFilePasswordToken)P_0).DateCreate = value;
	}

	internal static void lnbOGxGKckLegGv6eclb(object P_0, object P_1)
	{
		((IAbstractBoundVariableService)P_0).Remove((string)P_1);
	}

	internal static bool XqdoMwGKzmosqmf0GCsr(object P_0)
	{
		return ((BinaryFile)P_0).Encrypt;
	}

	internal static object eKcIAXGXF33Ki6vLBJhD()
	{
		return ComponentManager.Current;
	}

	internal static object vqZXLRGXBs0va34s6NJP(object P_0, object P_1)
	{
		return ((ICryptoContextAuthService)P_0).GetPasswordFromContext((IEntity)P_1);
	}

	internal static bool Lkaf3jGXWo8rt9c8m26t(object P_0, object P_1, object P_2)
	{
		return ((IFilePreviewService)P_0).CheckPassword((BinaryFile)P_1, (string)P_2);
	}
}
