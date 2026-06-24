using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.JWT.Services;

[Service]
internal sealed class JwtTokenService : IJwtTokenService
{
	private static readonly TimeSpan DefaultClockSkew;

	private readonly JsonWebTokenHandler tokenHandler;

	private readonly ConcurrentDictionary<byte[], SigningCredentials> keysLocalCache;

	internal static JwtTokenService mQ8slTTQJmhukLfWbqg;

	public JwtTokenService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		jtdC1HTgHAGyaJMAtJT();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				keysLocalCache = new ConcurrentDictionary<byte[], SigningCredentials>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				tokenHandler = new JsonWebTokenHandler();
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	public string CreateToken(IDictionary<string, string> payload, byte[] signatureSecret, TimeSpan duration)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		Contract.NotNull(payload, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784521435));
		Contract.CheckArgument(duration > TimeSpan.Zero, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757468131)));
		DateTime utcNow = DateTime.UtcNow;
		IEnumerable<Claim> claims = payload.Select((KeyValuePair<string, string> d) => new Claim(d.Key, d.Value));
		SecurityTokenDescriptor val = new SecurityTokenDescriptor();
		val.set_Issuer(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71C96C9));
		val.set_Subject(new ClaimsIdentity(claims));
		val.set_Expires((DateTime?)utcNow.Add(duration));
		val.set_IssuedAt((DateTime?)utcNow);
		val.set_NotBefore((DateTime?)utcNow);
		val.set_SigningCredentials(GetSigningCredentials(signatureSecret));
		SecurityTokenDescriptor val2 = val;
		return tokenHandler.CreateToken(val2).ToString();
	}

	public IDictionary<string, string> GetValidatedPayload(string token, byte[] signatureSecret)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNullOrEmpty(token, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B3723C5 ^ 0x1B37900F));
		TokenValidationParameters tokenValidationParameters = GetTokenValidationParameters(signatureSecret);
		TokenValidationResult val = tokenHandler.ValidateToken(token, tokenValidationParameters);
		if (!val.get_IsValid())
		{
			throw val.get_Exception();
		}
		return ((JsonWebToken)val.get_SecurityToken()).get_Claims().ToDictionary((Claim c) => (string)_003C_003Ec.TELQb1pvgMrvHQtW2kHb(c), (Claim c) => (string)_003C_003Ec.PxHh8ypv8YCNTsPP4Ksr(c));
	}

	private SigningCredentials GetSigningCredentials(byte[] signatureSecret)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (signatureSecret == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return keysLocalCache.GetOrAdd(signatureSecret, new SigningCredentials((SecurityKey)new SymmetricSecurityKey(signatureSecret), (string)b1qoLuT8Q3kTibju0V8(--553267277 ^ 0x20FAD715)));
			default:
				return null;
			}
		}
	}

	private TokenValidationParameters GetTokenValidationParameters(byte[] signatureSecret)
	{
		//Discarded unreachable code: IL_0042, IL_004c, IL_005b
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num2 = num;
		SymmetricSecurityKey val2 = default(SymmetricSecurityKey);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				if (signatureSecret != null)
				{
					num2 = 2;
					continue;
				}
				goto default;
			default:
				obj = null;
				break;
			case 1:
			{
				TokenValidationParameters val = new TokenValidationParameters();
				IXHfBhTrdCvXW611vwR((object)val, DefaultClockSkew);
				YM8kh2T3ivS9shXMv5U((object)val, val2);
				wImtoFTydjlBOHKot44((object)val, false);
				val.set_ValidateIssuer(false);
				Shl3bUTbvVwmJaiav4d((object)val, val2 != null);
				piGBg7TSH533C5ttdru((object)val, true);
				return val;
			}
			case 2:
				obj = (object)new SymmetricSecurityKey(signatureSecret);
				break;
			}
			val2 = (SymmetricSecurityKey)obj;
			num2 = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
			{
				num2 = 1;
			}
		}
	}

	static JwtTokenService()
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
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				DefaultClockSkew = CvWrumT9QidivZXnyE9(10.0);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void jtdC1HTgHAGyaJMAtJT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool XxPeFHTdODLfnSsS3PU()
	{
		return mQ8slTTQJmhukLfWbqg == null;
	}

	internal static JwtTokenService IFb4GmTTNejJiL0GvDN()
	{
		return mQ8slTTQJmhukLfWbqg;
	}

	internal static object b1qoLuT8Q3kTibju0V8(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void IXHfBhTrdCvXW611vwR(object P_0, TimeSpan P_1)
	{
		((TokenValidationParameters)P_0).set_ClockSkew(P_1);
	}

	internal static void YM8kh2T3ivS9shXMv5U(object P_0, object P_1)
	{
		((TokenValidationParameters)P_0).set_IssuerSigningKey((SecurityKey)P_1);
	}

	internal static void wImtoFTydjlBOHKot44(object P_0, bool P_1)
	{
		((TokenValidationParameters)P_0).set_ValidateAudience(P_1);
	}

	internal static void Shl3bUTbvVwmJaiav4d(object P_0, bool P_1)
	{
		((TokenValidationParameters)P_0).set_ValidateIssuerSigningKey(P_1);
	}

	internal static void piGBg7TSH533C5ttdru(object P_0, bool P_1)
	{
		((TokenValidationParameters)P_0).set_ValidateLifetime(P_1);
	}

	internal static TimeSpan CvWrumT9QidivZXnyE9(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}
}
