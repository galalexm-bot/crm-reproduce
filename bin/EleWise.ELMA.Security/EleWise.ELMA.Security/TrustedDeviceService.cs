using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Services.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(EnableInterceptors = false)]
public class TrustedDeviceService : ITrustedDeviceService
{
	public const string UID_S = "34a2fe2c-fd83-42d9-a0bf-59ebe665f4a5";

	public static Guid UID;

	internal static TrustedDeviceService pgFdaZNBbwZ1OUZop2a;

	public IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private bool IsDeviceValid(Guid deviceToken, string info, string user)
	{
		//Discarded unreachable code: IL_00c4, IL_00d3
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		string stringToken = default(string);
		UserTrustedDevices bLOB = default(UserTrustedDevices);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				stringToken = GetStringToken(info, user);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				bLOB = DataAccessManager.BLOBManager.GetBLOB<UserTrustedDevices>(UID, user);
				num2 = 7;
				break;
			default:
				_003C_003Ec__DisplayClass6_.deviceToken = deviceToken;
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				return false;
			case 4:
				_003C_003Ec__DisplayClass6_.hash = PublicClientService.Generate128ByteToken(stringToken);
				num2 = 5;
				break;
			case 5:
				return bLOB.Tokens.Where(_003C_003Ec__DisplayClass6_._003CIsDeviceValid_003Eb__0).ToList().Any(_003C_003Ec__DisplayClass6_._003CIsDeviceValid_003Eb__1);
			case 7:
				if (bLOB != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private string GetStringToken(string info, string user)
	{
		return info + user;
	}

	private string GetUserInfo(IUser user = null)
	{
		int num = 2;
		int num2 = num;
		Guid guid = default(Guid);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return guid.ToString((string)MvFYJ6NLG2JioZRGOQR(0x50A2A0A3 ^ 0x50A29CC7));
			case 2:
				obj = user as EleWise.ELMA.Security.Models.IUser;
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				obj = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				break;
			}
			guid = ck7BxpNeE3OJE58odsv(obj);
			num2 = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
			{
				num2 = 0;
			}
		}
	}

	private void RegisterUsage(string deviceToken, IUser user)
	{
		//Discarded unreachable code: IL_018e
		int num = 10;
		DeviceToken deviceToken2 = default(DeviceToken);
		UserTrustedDevices bLOB = default(UserTrustedDevices);
		string userInfo = default(string);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					deviceToken2.LastLogonDate = S063FWNj1Lyd41XHwrS();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					bLOB = DataAccessManager.BLOBManager.GetBLOB<UserTrustedDevices>(UID, userInfo);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					break;
				case 4:
					if (deviceToken2 != null)
					{
						num2 = 7;
						continue;
					}
					return;
				case 6:
					return;
				case 8:
					return;
				case 3:
					if (bLOB == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 2;
				case 9:
					if (!Guid.TryParse(deviceToken, out _003C_003Ec__DisplayClass9_.guid))
					{
						return;
					}
					num2 = 5;
					continue;
				case 5:
					userInfo = GetUserInfo(user);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					deviceToken2 = bLOB.Tokens.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CRegisterUsage_003Eb__0);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
			((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).SetBLOB(UID, userInfo, bLOB);
			num = 6;
		}
	}

	private DeviceToken CreateDeviceToken(string deviceInfo, string name, IUser user = null, Guid? token = null)
	{
		string stringToken = GetStringToken(deviceInfo, GetUserInfo(user));
		return new DeviceToken
		{
			CreationDate = DateTime.Now,
			Name = name,
			Token = (token ?? Guid.NewGuid()),
			Hash = PublicClientService.Generate128ByteToken(stringToken)
		};
	}

	public string AddDevice(string deviceInfo, string deviceName)
	{
		int num = 3;
		int num2 = num;
		string userInfo = default(string);
		UserTrustedDevices userTrustedDevices2 = default(UserTrustedDevices);
		Guid guid = default(Guid);
		DeviceToken deviceToken = default(DeviceToken);
		while (true)
		{
			UserTrustedDevices userTrustedDevices;
			switch (num2)
			{
			case 7:
				((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).SetBLOB(UID, userInfo, userTrustedDevices2);
				num2 = 6;
				continue;
			default:
				userTrustedDevices = ((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).GetBLOB<UserTrustedDevices>(UID, userInfo);
				if (userTrustedDevices == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 6:
				guid = aXQdE7Na3mEVmhe7fmt(deviceToken);
				num2 = 4;
				continue;
			case 2:
				userInfo = GetUserInfo();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return guid.ToString((string)MvFYJ6NLG2JioZRGOQR(-1642017152 ^ -1642007836));
			case 3:
				deviceToken = CreateDeviceToken(deviceInfo, deviceName);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
				{
					num2 = 2;
				}
				continue;
			case 5:
				userTrustedDevices2.Tokens.Add(deviceToken);
				num2 = 7;
				continue;
			case 1:
				userTrustedDevices = new UserTrustedDevices();
				break;
			}
			userTrustedDevices2 = userTrustedDevices;
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
			{
				num2 = 5;
			}
		}
	}

	public bool CheckDevice(string deviceToken, string deviceInfo, IUser user)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 2;
		bool flag = default(bool);
		bool flag2 = default(bool);
		Guid result = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!flag)
					{
						num2 = 4;
						break;
					}
					goto default;
				default:
					RegisterUsage(deviceToken, user);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
					{
						num2 = 2;
					}
					break;
				case 3:
				case 4:
					return !flag2 || flag;
				case 1:
					if (!Guid.TryParse(deviceToken, out result))
					{
						return !flag2;
					}
					goto end_IL_0012;
				case 2:
					flag2 = TrustedLogonEnabled(user);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					flag = IsDeviceValid(result, deviceInfo, GetUserInfo(user));
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public void DeleteDevice(string deviceToken, IUser user)
	{
		//Discarded unreachable code: IL_009b, IL_00aa
		int num = 7;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		DeviceToken deviceToken2 = default(DeviceToken);
		UserTrustedDevices bLOB = default(UserTrustedDevices);
		string userInfo = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!Guid.TryParse(deviceToken, out _003C_003Ec__DisplayClass13_.guid))
					{
						num2 = 8;
						continue;
					}
					break;
				case 10:
					if (deviceToken2 != null)
					{
						num2 = 4;
						continue;
					}
					return;
				case 7:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					return;
				case 9:
					bLOB = ((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).GetBLOB<UserTrustedDevices>(UID, userInfo);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					if (bLOB != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 3:
					return;
				default:
					((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).SetBLOB(UID, userInfo, bLOB);
					num2 = 3;
					continue;
				case 4:
					bLOB.Tokens.Remove(deviceToken2);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 2:
					goto end_IL_0012;
				}
				userInfo = GetUserInfo(user);
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
				{
					num2 = 9;
				}
				continue;
				end_IL_0012:
				break;
			}
			deviceToken2 = bLOB.Tokens.FirstOrDefault(_003C_003Ec__DisplayClass13_._003CDeleteDevice_003Eb__0);
			num = 10;
		}
	}

	public string[] GetDeviceTokens(string deviceInfo, IUser user = null)
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 7;
		int num2 = num;
		List<DeviceToken> source = default(List<DeviceToken>);
		UserTrustedDevices bLOB = default(UserTrustedDevices);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		string stringToken = default(string);
		string userInfo = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				source = bLOB.Tokens.Where(_003C_003Ec__DisplayClass14_._003CGetDeviceTokens_003Eb__0).ToList();
				num2 = 3;
				break;
			case 3:
				if (source.Any())
				{
					num2 = 9;
					break;
				}
				goto case 1;
			case 4:
				if (bLOB == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					stringToken = GetStringToken(deviceInfo, userInfo);
					num2 = 8;
				}
				break;
			case 8:
				_003C_003Ec__DisplayClass14_.hash = (string)FujNKXNRUoGlgXnbAyH(stringToken);
				num2 = 2;
				break;
			case 6:
				userInfo = GetUserInfo(user);
				num2 = 5;
				break;
			case 7:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 6;
				break;
			default:
				return new string[0];
			case 5:
				bLOB = ((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).GetBLOB<UserTrustedDevices>(UID, userInfo);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return new string[0];
			case 9:
				return source.Select(delegate(DeviceToken x)
				{
					int num3 = 1;
					int num4 = num3;
					Guid guid = default(Guid);
					while (true)
					{
						switch (num4)
						{
						case 1:
							guid = _003C_003Ec.NkRAutp6b3riSiYYYNln(x);
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
							{
								num4 = 0;
							}
							break;
						default:
							return guid.ToString((string)_003C_003Ec.QEIBcDp6S8bU3A1138fW(-1973849202 ^ -1973858326));
						}
					}
				}).ToArray();
			}
		}
	}

	public List<DeviceToken> GetDevices(IUser user)
	{
		string userInfo = GetUserInfo(user);
		UserTrustedDevices bLOB = DataAccessManager.BLOBManager.GetBLOB<UserTrustedDevices>(UID, userInfo);
		if (bLOB == null)
		{
			return new List<DeviceToken>();
		}
		return bLOB.Tokens;
	}

	public bool TrustedLogonEnabled(IUser user = null)
	{
		int num = 3;
		UserTrustedDevices bLOB = default(UserTrustedDevices);
		string userInfo = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (bLOB == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return M90xAKNwVYPEcXWJvct(bLOB);
				default:
					return false;
				case 2:
					bLOB = ((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).GetBLOB<UserTrustedDevices>(UID, userInfo);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					break;
				}
				break;
			}
			userInfo = GetUserInfo(user);
			num = 2;
		}
	}

	public void SetTrustedLogon(IUser user, bool enabled)
	{
		int num = 3;
		int num2 = num;
		string userInfo = default(string);
		UserTrustedDevices userTrustedDevices2 = default(UserTrustedDevices);
		while (true)
		{
			UserTrustedDevices userTrustedDevices;
			switch (num2)
			{
			default:
				return;
			case 3:
				userInfo = GetUserInfo(user);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
				{
					num2 = 2;
				}
				continue;
			case 0:
				return;
			case 2:
				userTrustedDevices = ((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).GetBLOB<UserTrustedDevices>(UID, userInfo);
				if (userTrustedDevices == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 5:
				((IBLOBDataManager)EDj6m1NHh5OHH9548dY()).SetBLOB(UID, userInfo, userTrustedDevices2);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				userTrustedDevices2.LogonFromTrustedDevicesOnly = enabled;
				num2 = 5;
				continue;
			case 1:
				userTrustedDevices = new UserTrustedDevices();
				break;
			}
			userTrustedDevices2 = userTrustedDevices;
			num2 = 4;
		}
	}

	public TrustedDeviceService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TrustedDeviceService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)MvFYJ6NLG2JioZRGOQR(-1580392499 ^ -1580391513));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				xY8RLfN2TssYwtKiXjp();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool YIYwpVNuFFJn86liLy7()
	{
		return pgFdaZNBbwZ1OUZop2a == null;
	}

	internal static TrustedDeviceService FsDCMnNmF5Hbx92NyxZ()
	{
		return pgFdaZNBbwZ1OUZop2a;
	}

	internal static Guid ck7BxpNeE3OJE58odsv(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Uid;
	}

	internal static object MvFYJ6NLG2JioZRGOQR(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime S063FWNj1Lyd41XHwrS()
	{
		return DateTime.Now;
	}

	internal static object EDj6m1NHh5OHH9548dY()
	{
		return DataAccessManager.BLOBManager;
	}

	internal static Guid aXQdE7Na3mEVmhe7fmt(object P_0)
	{
		return ((DeviceToken)P_0).Token;
	}

	internal static object FujNKXNRUoGlgXnbAyH(object P_0)
	{
		return PublicClientService.Generate128ByteToken((string)P_0);
	}

	internal static bool M90xAKNwVYPEcXWJvct(object P_0)
	{
		return ((UserTrustedDevices)P_0).LogonFromTrustedDevicesOnly;
	}

	internal static void xY8RLfN2TssYwtKiXjp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
