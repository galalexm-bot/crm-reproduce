using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models;

public static class UserExtensions
{
	private static UserExtensions CPYHJaqeTd6DQymxK9n;

	public static bool IsActive([NotNull] this IUser user)
	{
		return UserManager.Instance.IsActive(user);
	}

	public static void Block([NotNull] this IUser user)
	{
		//Discarded unreachable code: IL_0032
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
			case 2:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				throw new ArgumentNullException((string)gRqWaQqHiyFFRBC9qbB(--1130812004 ^ 0x4366DF8E));
			case 1:
				Ao8ObfqRAI2C4UtyJQk(BGm2eNqatVGdJRNTIUE(), user);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void UnBlock([NotNull] this IUser user)
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
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65F93013 ^ 0x65F93DF9));
			case 2:
				if (user != null)
				{
					YIuMyWqwxc1qLr0xHoS(UserManager.Instance, user);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
					{
						num2 = 1;
					}
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static string GetFullName(this IUser user)
	{
		//Discarded unreachable code: IL_00c9, IL_00d8, IL_0154, IL_0178, IL_0187, IL_0197, IL_01a6, IL_01d8, IL_01e7, IL_0245, IL_02a5, IL_02b4, IL_02be
		int num = 13;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text2;
				object obj2;
				object obj;
				switch (num2)
				{
				case 2:
					if (user.LastName == null)
					{
						num2 = 23;
						continue;
					}
					text2 = ((string)PK9UMjq2M3kAvYv2nGJ(user)).Trim();
					goto IL_0332;
				case 13:
					if (user == null)
					{
						num2 = 12;
						continue;
					}
					stringBuilder = new StringBuilder();
					num2 = 2;
					continue;
				case 1:
					if (nmnj1AqPryooVtYvIjg(text) <= 0)
					{
						num2 = 22;
						continue;
					}
					goto case 4;
				default:
					if (Wx7P9eqJLSZ3yMiTnsi(user) != null)
					{
						num2 = 17;
						continue;
					}
					goto case 18;
				case 21:
					return (string)eqi1cHqUiTdkGSAcTjx(stringBuilder.ToString());
				case 7:
					if (nmnj1AqPryooVtYvIjg(text) <= 0)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				case 9:
					if (CqsnmJqoKIpPRyurI68(stringBuilder) <= 0)
					{
						goto end_IL_0012;
					}
					goto case 20;
				case 16:
					UGTehbqvme1aOkMiHjy(stringBuilder, MPK514qKXaaCunLWUp9(user));
					num2 = 21;
					continue;
				case 15:
				case 22:
					if (C5mGKvqCQQMVgv9HCKJ(user) != null)
					{
						num2 = 11;
						continue;
					}
					goto case 14;
				case 20:
					UGTehbqvme1aOkMiHjy(stringBuilder, gRqWaQqHiyFFRBC9qbB(0x3B1D6430 ^ 0x3B1D40CA));
					num2 = 8;
					continue;
				case 19:
					if (nmnj1AqPryooVtYvIjg(text) > 0)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 24:
					UGTehbqvme1aOkMiHjy(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1195916818 ^ -1195907820));
					num2 = 26;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
					{
						num2 = 11;
					}
					continue;
				case 14:
					obj2 = string.Empty;
					goto IL_0359;
				case 3:
				case 6:
					if (CqsnmJqoKIpPRyurI68(stringBuilder) == 0)
					{
						num2 = 16;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 21;
				case 8:
				case 10:
					UGTehbqvme1aOkMiHjy(stringBuilder, text);
					num2 = 6;
					continue;
				case 5:
					if (CqsnmJqoKIpPRyurI68(stringBuilder) <= 0)
					{
						num2 = 25;
						continue;
					}
					goto case 24;
				case 23:
					text2 = string.Empty;
					goto IL_0332;
				case 18:
					obj = string.Empty;
					break;
				case 25:
				case 26:
					UGTehbqvme1aOkMiHjy(stringBuilder, text);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					throw new ArgumentNullException((string)gRqWaQqHiyFFRBC9qbB(0xBBC1CCD ^ 0xBBC1127));
				case 4:
					UGTehbqvme1aOkMiHjy(stringBuilder, text);
					num2 = 15;
					continue;
				case 11:
					obj2 = eqi1cHqUiTdkGSAcTjx(C5mGKvqCQQMVgv9HCKJ(user));
					goto IL_0359;
				case 17:
					{
						obj = eqi1cHqUiTdkGSAcTjx(user.MiddleName);
						break;
					}
					IL_0332:
					text = text2;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
					{
						num2 = 1;
					}
					continue;
					IL_0359:
					text = (string)obj2;
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
					{
						num2 = 19;
					}
					continue;
				}
				text = (string)obj;
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	public static string GetShortName(this IUser user)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x335D4787 ^ 0x335D4A6D));
			default:
				return GetShortName(DYD1g1qtAYrRbC5mLKV(user), (string)PK9UMjq2M3kAvYv2nGJ(user), (string)C5mGKvqCQQMVgv9HCKJ(user), (string)Wx7P9eqJLSZ3yMiTnsi(user), (string)MPK514qKXaaCunLWUp9(user));
			case 1:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static string GetShortName(Guid uid, string lastName, string firstName, string middleName, string userName)
	{
		//Discarded unreachable code: IL_00b9, IL_0113, IL_016e, IL_017d, IL_01dd, IL_01fe, IL_0220, IL_022f, IL_026d, IL_02a4, IL_02b8, IL_0380
		int num = 13;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				object obj3;
				switch (num2)
				{
				case 28:
					if (lastName != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 27:
					if (middleName != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 20;
				case 29:
					if (firstName != null)
					{
						num2 = 17;
						continue;
					}
					goto case 18;
				case 25:
					if (stringBuilder.Length != 0)
					{
						num2 = 23;
						continue;
					}
					goto case 1;
				case 20:
					obj = string.Empty;
					break;
				case 4:
					if (!(firstName == SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1378061210 ^ -1378075264)))
					{
						num2 = 5;
						continue;
					}
					goto case 9;
				case 16:
					return lastName;
				case 12:
					if (!(uid == SecurityConstants.AdminUserUid))
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 4;
				case 19:
				case 23:
					return (string)eqi1cHqUiTdkGSAcTjx(stringBuilder.ToString());
				case 15:
					Dfd8IYqO5X2vgaHuM5m(stringBuilder, text);
					num2 = 25;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
					{
						num2 = 20;
					}
					continue;
				case 7:
					if (CqsnmJqoKIpPRyurI68(stringBuilder) > 0)
					{
						goto end_IL_0012;
					}
					goto case 15;
				case 18:
					obj2 = string.Empty;
					goto IL_03b2;
				case 26:
					if (nmnj1AqPryooVtYvIjg(text) > 0)
					{
						num2 = 24;
						continue;
					}
					goto case 29;
				case 2:
					Dfd8IYqO5X2vgaHuM5m(stringBuilder, text);
					num2 = 27;
					continue;
				case 24:
					UGTehbqvme1aOkMiHjy(stringBuilder, text);
					num2 = 29;
					continue;
				case 13:
					if (!blqkgTqhtPdpyyij03o(uid, SecurityConstants.SystemUserUid))
					{
						num2 = 12;
						continue;
					}
					goto case 16;
				case 22:
					UGTehbqvme1aOkMiHjy(stringBuilder, gRqWaQqHiyFFRBC9qbB(-566078848 ^ -566069638));
					num2 = 15;
					continue;
				case 3:
					obj3 = string.Empty;
					goto IL_0390;
				case 11:
					if (CqsnmJqoKIpPRyurI68(stringBuilder) > 0)
					{
						num2 = 10;
						continue;
					}
					goto case 2;
				case 6:
					if (nmnj1AqPryooVtYvIjg(text) > 0)
					{
						num2 = 7;
						continue;
					}
					goto case 25;
				case 10:
					stringBuilder.Append((string)gRqWaQqHiyFFRBC9qbB(0xAEB118D ^ 0xAEB3577));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
					{
						num2 = 0;
					}
					continue;
				case 21:
					if (text.Length > 0)
					{
						num2 = 11;
						continue;
					}
					goto case 27;
				case 9:
					return lastName;
				case 5:
				case 8:
					stringBuilder = new StringBuilder();
					num2 = 28;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					UGTehbqvme1aOkMiHjy(stringBuilder, userName);
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					obj3 = eqi1cHqUiTdkGSAcTjx(lastName);
					goto IL_0390;
				case 17:
					obj2 = eqi1cHqUiTdkGSAcTjx(firstName);
					goto IL_03b2;
				case 14:
					{
						obj = eqi1cHqUiTdkGSAcTjx(middleName);
						break;
					}
					IL_0390:
					text = (string)obj3;
					num2 = 26;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
					{
						num2 = 2;
					}
					continue;
					IL_03b2:
					text = (string)obj2;
					num2 = 21;
					continue;
				}
				text = (string)obj;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
				{
					num2 = 6;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 22;
		}
	}

	public static string GetShortCompoundName(string name)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!string.IsNullOrEmpty(name))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return string.Empty;
			default:
			{
				StringBuilder stringBuilder = new StringBuilder();
				Dfd8IYqO5X2vgaHuM5m(stringBuilder, name);
				return stringBuilder.ToString();
			}
			}
		}
	}

	public static string GetFullNamePosition(this IUser user)
	{
		//Discarded unreachable code: IL_00ec, IL_00fb
		int num = 1;
		int num2 = num;
		string positions = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				positions = user.GetPositions();
				num2 = 4;
				break;
			case 6:
				throw new ArgumentNullException((string)gRqWaQqHiyFFRBC9qbB(-726732645 ^ -726729359));
			default:
				text = (string)jfl8oCqq21fJO26QrVn(user);
				num2 = 3;
				break;
			case 5:
				text = (string)VnU1qgqGb8IYrJU69uo(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-731479136 ^ -731511598), positions, gRqWaQqHiyFFRBC9qbB(-230994601 ^ -230962643));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (user != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 4:
				if (FsgL9SqcErYrDhj1qq8(positions))
				{
					num2 = 7;
					break;
				}
				goto case 5;
			case 2:
			case 7:
				return text.Trim();
			}
		}
	}

	public static string GetPositions(this IUser user)
	{
		//Discarded unreachable code: IL_0068, IL_0077
		int num = 5;
		int num2 = num;
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (gUVRdQqFKbaS9ndLO9b(user.OrganizationItems) <= 0)
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 6:
				if (gUVRdQqFKbaS9ndLO9b(user.OrganizationGroups) > 0)
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 2:
				return result;
			default:
				throw new ArgumentNullException((string)gRqWaQqHiyFFRBC9qbB(0x46F7DF98 ^ 0x46F7D272));
			case 4:
				result = null;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				if (user != null)
				{
					num2 = 4;
					continue;
				}
				goto default;
			case 3:
				break;
			}
			result = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C288D7), from s in ((IEnumerable<IOrganizationItem>)user.OrganizationItems).Select((IOrganizationItem item) => (string)_003C_003Ec.WppEKPpjHC0JLp6B9mAa(item)).ToList().Union(((IEnumerable<IOrganizationItem>)user.OrganizationGroups).Select((IOrganizationItem item) => (string)_003C_003Ec.WppEKPpjHC0JLp6B9mAa(item)).ToList())
				orderby s
				select s);
			num2 = 2;
		}
	}

	public static string GetSetPositions(this IUser user)
	{
		//Discarded unreachable code: IL_0098, IL_00a7, IL_00fb, IL_010a
		int num = 3;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return string.Format((string)qaGSm1qDWtBmmryEuPo(gRqWaQqHiyFFRBC9qbB(-1329706983 ^ -1329672295)), qaGSm1qDWtBmmryEuPo(gRqWaQqHiyFFRBC9qbB(0x8875F5C ^ 0x887D8CC)));
				case 1:
				case 4:
					return text;
				case 2:
					if (!string.IsNullOrWhiteSpace(text))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 5:
					if (!iOh1yvqEs8WpqsGNRKB(Locator.GetServiceNotNull<ISecurityService>(), PermissionProvider.UserManagmentPermission))
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto default;
				case 3:
					break;
				}
				break;
			}
			text = (string)SOlTTQq0bgR7OCpUfgp(user);
			num = 2;
		}
	}

	public static string GetShortNamePosition(this IUser user)
	{
		//Discarded unreachable code: IL_0041, IL_0054, IL_0063
		int num = 2;
		string text = default(string);
		string positions = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)eqi1cHqUiTdkGSAcTjx(text);
				case 3:
					throw new ArgumentNullException((string)gRqWaQqHiyFFRBC9qbB(0x4D765E72 ^ 0x4D765398));
				case 1:
					text = user.GetShortName();
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					text = (string)VnU1qgqGb8IYrJU69uo(text, gRqWaQqHiyFFRBC9qbB(-1429500015 ^ -1429534493), positions, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC667C6E));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (string.IsNullOrWhiteSpace(positions))
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				case 6:
					break;
				case 2:
					if (user != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			positions = user.GetPositions();
			num = 5;
		}
	}

	public static string GetReplacementsAbsencesText(this IUser user)
	{
		//Discarded unreachable code: IL_0101
		int num = 5;
		IReplacement replacement = default(IReplacement);
		IAbsence absence = default(IAbsence);
		IUser user2 = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (replacement == null)
					{
						absence = (from k in ((AbsenceManager)kgC9k7q4TDoDAn4egeW()).GetAbsences((EleWise.ELMA.Security.IUser)user)
							orderby _003C_003Ec.SQevyxpjaaAHd5AOvQMq(k)
							select k).FirstOrDefault((IAbsence k) => _003C_003Ec.I90RQZpjwoJ9O2m2DP73(_003C_003Ec.SQevyxpjaaAHd5AOvQMq(k), _003C_003Ec.H5liQVpjRj5nfrTtpiGh()));
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto end_IL_0012;
				default:
					if (absence == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				case 2:
					return (string)iIW6VAqQXRqjHjdB0AC(gRqWaQqHiyFFRBC9qbB(0x61EAE816 ^ 0x61EA601C), new object[2]
					{
						KiVJolqVrcFn3ADAOM5(absence),
						absence.EndDate
					});
				case 1:
					return "";
				case 5:
					replacement = ((ReplacementManager)D4MTTsqMbZUArJVktu0()).GetReplacementsReadOnly((EleWise.ELMA.Security.IUser)user).FirstOrDefault();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					user2 = UserManager.Instance.Load(((IEntity<long>)c6sHMRqsYe8NH4Xpttg(replacement)).Id);
					num2 = 6;
					break;
				case 6:
					return SR.T((string)gRqWaQqHiyFFRBC9qbB(0x4B68CDFB ^ 0x4B684A5D), jfl8oCqq21fJO26QrVn(user2), IosOn1qYcBjoeTqwKc4(replacement), PgVcxuqIsnIIDeOlagt(replacement));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static void Appoint(this IUser user, params IOrganizationItem[] organizationItems)
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
				((UserManager)BGm2eNqatVGdJRNTIUE()).Appoint(user, organizationItems);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void SetAppointments(this IUser user, IEnumerable<IOrganizationItem> organizationItems)
	{
		UserManager.Instance.SetAppointments(user, organizationItems);
	}

	public static bool AllowChangePassword([NotNull] this IUser user)
	{
		string error;
		return user.AllowChangePassword(out error);
	}

	public static bool AllowChangePassword([NotNull] this IUser user, out string error)
	{
		//Discarded unreachable code: IL_00db, IL_0133
		int num = 1;
		int num2 = num;
		ISecurityService service = default(ISecurityService);
		IUser currentUser = default(IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!IihMEyqTNyl9ooFtCYJ(K1ka0pqdugmZ51UGT6J(Locator.GetService<IMembershipService>(), user)))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					service = Locator.GetService<ISecurityService>();
					num2 = 12;
				}
				break;
			case 4:
				return false;
			case 3:
				return false;
			case 10:
				error = null;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
				{
					num2 = 7;
				}
				break;
			default:
				error = (string)qaGSm1qDWtBmmryEuPo(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B4737E7));
				num2 = 4;
				break;
			case 9:
				return false;
			case 2:
				if (!service.HasPermission(PermissionProvider.DenyPasswordResetPermission))
				{
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 5;
			case 6:
				if (currentUser.Id != user.Id)
				{
					num2 = 11;
					break;
				}
				goto case 2;
			case 8:
				error = (string)qaGSm1qDWtBmmryEuPo(gRqWaQqHiyFFRBC9qbB(0x9D1442B ^ 0x9D1CC85));
				num2 = 9;
				break;
			case 5:
				error = SR.T((string)gRqWaQqHiyFFRBC9qbB(-726732645 ^ -726763117));
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				return true;
			case 13:
				if (currentUser == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 12:
				currentUser = AuthenticationService.GetCurrentUser<IUser>();
				num2 = 13;
				break;
			case 11:
				if (!iOh1yvqEs8WpqsGNRKB(service, PermissionProvider.UserManagmentPermission))
				{
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static bool CheckOrganizationItem([NotNull] this IUser user, [NotNull] IUser executor)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return ((IEnumerable<IOrganizationItem>)user.OrganizationItems).ToArray().Union((IEnumerable<IOrganizationItem>)user.OrganizationGroups).Any(_003C_003Ec__DisplayClass16_._003CCheckOrganizationItem_003Eb__0);
			case 4:
				if (user.Id != _003C_003Ec__DisplayClass16_.executor.Id)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_007a;
			case 2:
				_003C_003Ec__DisplayClass16_.executor = executor;
				num2 = 4;
				break;
			case 1:
				{
					if (!((UserManager)BGm2eNqatVGdJRNTIUE()).IsSubordinateUser(user, _003C_003Ec__DisplayClass16_.executor))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_007a;
				}
				IL_007a:
				return true;
			}
		}
	}

	private static void AppendShortCompoundName(object builder, object name)
	{
		//Discarded unreachable code: IL_0086, IL_0095, IL_0161, IL_0170, IL_01d1, IL_01e0, IL_01f0, IL_01ff
		int num = 10;
		string[] array = default(string[]);
		int num3 = default(int);
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					array = (string[])Th1ZbtqgVyxIMZexw43(name, new char[1] { '-' });
					num2 = 13;
					break;
				case 4:
					UGTehbqvme1aOkMiHjy(builder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429359375));
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
				case 17:
					num3++;
					num2 = 15;
					break;
				default:
					flag = false;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 0;
					}
					break;
				case 16:
					return;
				case 7:
					UGTehbqvme1aOkMiHjy(builder, gRqWaQqHiyFFRBC9qbB(-1027693337 ^ -1027675667));
					num2 = 16;
					break;
				case 5:
				case 15:
					if (num3 >= array.Length)
					{
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 6:
					text = array[num3];
					num2 = 8;
					break;
				case 10:
					if (!string.IsNullOrEmpty((string)name))
					{
						num2 = 9;
						break;
					}
					return;
				case 1:
					UGTehbqvme1aOkMiHjy(builder, d2nZtjq8DWoDGSY12kG(eqi1cHqUiTdkGSAcTjx(text), 0, 1));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 0;
					}
					break;
				case 13:
					num3 = 0;
					num2 = 5;
					break;
				case 3:
				case 11:
					if (string.IsNullOrWhiteSpace(text))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 14:
					return;
				case 9:
					flag = true;
					num2 = 12;
					break;
				case 8:
					if (flag)
					{
						num2 = 11;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 17;
		}
	}

	internal static bool VA0JFsqLDdxlxnOqgkW()
	{
		return CPYHJaqeTd6DQymxK9n == null;
	}

	internal static UserExtensions EWGhL5qjXdY9fiMFoXd()
	{
		return CPYHJaqeTd6DQymxK9n;
	}

	internal static object gRqWaQqHiyFFRBC9qbB(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object BGm2eNqatVGdJRNTIUE()
	{
		return UserManager.Instance;
	}

	internal static void Ao8ObfqRAI2C4UtyJQk(object P_0, object P_1)
	{
		((UserManager)P_0).Block((IUser)P_1);
	}

	internal static void YIuMyWqwxc1qLr0xHoS(object P_0, object P_1)
	{
		((UserManager)P_0).UnBlock((IUser)P_1);
	}

	internal static object PK9UMjq2M3kAvYv2nGJ(object P_0)
	{
		return ((IUser)P_0).LastName;
	}

	internal static int nmnj1AqPryooVtYvIjg(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object UGTehbqvme1aOkMiHjy(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object C5mGKvqCQQMVgv9HCKJ(object P_0)
	{
		return ((IUser)P_0).FirstName;
	}

	internal static object eqi1cHqUiTdkGSAcTjx(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static int CqsnmJqoKIpPRyurI68(object P_0)
	{
		return ((StringBuilder)P_0).Length;
	}

	internal static object Wx7P9eqJLSZ3yMiTnsi(object P_0)
	{
		return ((IUser)P_0).MiddleName;
	}

	internal static object MPK514qKXaaCunLWUp9(object P_0)
	{
		return ((IUser)P_0).UserName;
	}

	internal static Guid DYD1g1qtAYrRbC5mLKV(object P_0)
	{
		return ((IUser)P_0).Uid;
	}

	internal static bool blqkgTqhtPdpyyij03o(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void Dfd8IYqO5X2vgaHuM5m(object P_0, object P_1)
	{
		AppendShortCompoundName(P_0, P_1);
	}

	internal static object jfl8oCqq21fJO26QrVn(object P_0)
	{
		return ((IUser)P_0).GetFullName();
	}

	internal static bool FsgL9SqcErYrDhj1qq8(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object VnU1qgqGb8IYrJU69uo(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static int gUVRdQqFKbaS9ndLO9b(object P_0)
	{
		return ((ICollection<IOrganizationItem>)P_0).Count;
	}

	internal static object SOlTTQq0bgR7OCpUfgp(object P_0)
	{
		return ((IUser)P_0).GetPositions();
	}

	internal static bool iOh1yvqEs8WpqsGNRKB(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static object qaGSm1qDWtBmmryEuPo(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object D4MTTsqMbZUArJVktu0()
	{
		return ReplacementManager.Instance;
	}

	internal static object c6sHMRqsYe8NH4Xpttg(object P_0)
	{
		return ((IReplacement)P_0).TargetUser;
	}

	internal static DateTime IosOn1qYcBjoeTqwKc4(object P_0)
	{
		return ((IReplacement)P_0).StartDate;
	}

	internal static DateTime PgVcxuqIsnIIDeOlagt(object P_0)
	{
		return ((IReplacement)P_0).EndDate;
	}

	internal static object kgC9k7q4TDoDAn4egeW()
	{
		return AbsenceManager.Instance;
	}

	internal static DateTime KiVJolqVrcFn3ADAOM5(object P_0)
	{
		return ((IAbsence)P_0).StartDate;
	}

	internal static object iIW6VAqQXRqjHjdB0AC(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object K1ka0pqdugmZ51UGT6J(object P_0, object P_1)
	{
		return ((IMembershipService)P_0).GetSettings((EleWise.ELMA.Security.IUser)P_1);
	}

	internal static bool IihMEyqTNyl9ooFtCYJ(object P_0)
	{
		return ((MembershipSettings)P_0).EnablePasswordReset;
	}

	internal static object Th1ZbtqgVyxIMZexw43(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object d2nZtjq8DWoDGSY12kG(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}
}
