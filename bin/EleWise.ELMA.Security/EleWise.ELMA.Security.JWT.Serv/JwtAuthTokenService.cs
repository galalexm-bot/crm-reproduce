using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.JWT.Services;

[Service]
internal sealed class JwtAuthTokenService : IJwtAuthTokenService
{
	private readonly byte[] secret;

	private readonly ILogger authLog;

	private readonly IJwtTokenService jwtTokenService;

	private readonly IRefreshTokenService refreshTokenService;

	internal static JwtAuthTokenService V0SxwRgk4ROKmpHJe76;

	private TimeSpan TokenDuration => tUE28vgZmQvDhw3KpbF(SR.GetSetting((string)MgvNm7gAXoIuJPkjWrT(0x65F93013 ^ 0x65F9D807), 15.0));

	public JwtAuthTokenService(IJwtTokenService jwtTokenService, IRefreshTokenService refreshTokenService)
	{
		//Discarded unreachable code: IL_0067, IL_006c
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		secret = new byte[32]
		{
			109, 89, 112, 51, 115, 54, 118, 57, 121, 36,
			66, 38, 69, 41, 72, 64, 77, 99, 81, 102,
			84, 106, 87, 110, 90, 114, 52, 116, 55, 119,
			33, 122
		};
		authLog = (ILogger)z5nsA0gWEkWWVeK5t04(MgvNm7gAXoIuJPkjWrT(-1943394692 ^ -1943355110));
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				this.jwtTokenService = jwtTokenService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
				{
					num = 0;
				}
				break;
			default:
				this.refreshTokenService = refreshTokenService;
				num = 2;
				break;
			}
		}
	}

	public JwtTokenContainer CreateToken(AuthInfoContainer authInfo)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				LfVuZNgXO9EVKyALeyc(authInfo, MgvNm7gAXoIuJPkjWrT(-163225536 ^ -163215560));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return CreateTokenPrivate(authInfo);
			}
		}
	}

	public AuthInfoContainer GetAuthInfo(string jwtToken)
	{
		//Discarded unreachable code: IL_0062, IL_0095, IL_010d, IL_011c
		int num = 2;
		int num2 = num;
		IDictionary<string, string> validatedPayload = default(IDictionary<string, string>);
		AuthInfoContainer result = default(AuthInfoContainer);
		while (true)
		{
			switch (num2)
			{
			default:
				return validatedPayload.ToAuthInfo();
			case 1:
				try
				{
					validatedPayload = jwtTokenService.GetValidatedPayload(jwtToken, secret);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 2:
							return result;
						case 1:
							result = null;
							num4 = 2;
							continue;
						}
						b2jo41g7IX2k2nsUNfe(authLog, ViCb7ngi304YqrHBKdk(MgvNm7gAXoIuJPkjWrT(0x65F93013 ^ 0x65F9D7B3), new object[1] { jwtToken }), ex);
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
						{
							num4 = 1;
						}
					}
				}
				goto default;
			case 2:
				gpXn4hgnhBbin9kAqSJ(jwtToken, MgvNm7gAXoIuJPkjWrT(-1788380826 ^ -1788371222));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public JwtTokenContainer RefreshToken(string refreshToken)
	{
		int num = 3;
		int num2 = num;
		AuthInfoContainer authInfoContainer = default(AuthInfoContainer);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 3:
				gpXn4hgnhBbin9kAqSJ(refreshToken, MgvNm7gAXoIuJPkjWrT(-1429357207 ^ -1429382511));
				num2 = 2;
				continue;
			case 2:
				authInfoContainer = (AuthInfoContainer)mASxcmg6nF04UQre7wi(refreshTokenService, refreshToken);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (authInfoContainer != null)
			{
				return CreateTokenPrivate(authInfoContainer);
			}
			num2 = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 != 0)
			{
				num2 = 1;
			}
		}
	}

	public void Revoke(AuthInfoContainer authInfo)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				mmLBbuglN8n0yll5E11(refreshTokenService, authInfo);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				LfVuZNgXO9EVKyALeyc(authInfo, MgvNm7gAXoIuJPkjWrT(0x2121ECF9 ^ 0x21210B81));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private JwtTokenContainer CreateTokenPrivate(AuthInfoContainer authInfo)
	{
		string jwtToken = jwtTokenService.CreateToken(authInfo.ToDictionary(), secret, TokenDuration);
		string refreshToken = (string)znWuN5gNNFfy7bnyqpY(refreshTokenService, authInfo);
		return new JwtTokenContainer(jwtToken, refreshToken);
	}

	internal static object MgvNm7gAXoIuJPkjWrT(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object z5nsA0gWEkWWVeK5t04(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static bool XVsU53gpwnMPKHLuqqn()
	{
		return V0SxwRgk4ROKmpHJe76 == null;
	}

	internal static JwtAuthTokenService yHe9Edg5FEN15psxNfV()
	{
		return V0SxwRgk4ROKmpHJe76;
	}

	internal static void LfVuZNgXO9EVKyALeyc(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void gpXn4hgnhBbin9kAqSJ(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object ViCb7ngi304YqrHBKdk(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void b2jo41g7IX2k2nsUNfe(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Debug(P_1, (Exception)P_2);
	}

	internal static object mASxcmg6nF04UQre7wi(object P_0, object P_1)
	{
		return ((IRefreshTokenService)P_0).GetAuthInfo((string)P_1);
	}

	internal static void mmLBbuglN8n0yll5E11(object P_0, object P_1)
	{
		((IRefreshTokenService)P_0).Revoke((AuthInfoContainer)P_1);
	}

	internal static object znWuN5gNNFfy7bnyqpY(object P_0, object P_1)
	{
		return ((IRefreshTokenService)P_0).CreateToken((AuthInfoContainer)P_1);
	}

	internal static TimeSpan tUE28vgZmQvDhw3KpbF(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}
}
