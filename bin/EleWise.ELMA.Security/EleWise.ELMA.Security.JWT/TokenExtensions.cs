using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.JWT;

internal static class TokenExtensions
{
	private static readonly ISet<string> ClaimsToFilter;

	internal static TokenExtensions AGHH69TskWFoLKLliCx;

	public static IDictionary<string, string> ToDictionary(this AuthInfoContainer authInfo)
	{
		return new Dictionary<string, string>(2)
		{
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A336151 ^ 0x6A33017D),
				authInfo.UserId.ToString()
			},
			{
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429500015 ^ -1429509717),
				authInfo.ApplicationToken
			}
		}.Concat(authInfo.AdditionalClaims).ToDictionary((KeyValuePair<string, string> kv) => kv.Key, (KeyValuePair<string, string> kv) => kv.Value);
	}

	public static AuthInfoContainer ToAuthInfo(this IDictionary<string, string> claims)
	{
		Contract.CheckArgument(claims.ContainsKey(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1889123947 ^ -1889132103)) && claims.ContainsKey(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46F7DF98 ^ 0x46F739A2)), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C26707)));
		long userId = long.Parse(claims[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119503068)]);
		string applicationToken = claims[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-177725793 ^ -177669979)];
		Dictionary<string, string> additionalClaims = claims.Where((KeyValuePair<string, string> kv) => !ClaimsToFilter.Contains(kv.Key)).ToDictionary((KeyValuePair<string, string> kv) => kv.Key, (KeyValuePair<string, string> kv) => kv.Value);
		return new AuthInfoContainer(userId, applicationToken, additionalClaims);
	}

	static TokenExtensions()
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
				ClaimsToFilter = new HashSet<string>
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-848444002 ^ -848485584),
					(string)nZgO8MTVSt1ANtXKuN6(-1826813434 ^ -1826755394),
					(string)nZgO8MTVSt1ANtXKuN6(0x271B34E4 ^ 0x271BD226),
					(string)nZgO8MTVSt1ANtXKuN6(0x3E79A885 ^ 0x3E794E49),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-230994601 ^ -230970495),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-434542700 ^ -434536076),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C648300 ^ 0x2C6465EA),
					(string)nZgO8MTVSt1ANtXKuN6(0x3E79A885 ^ 0x3E79C8A9),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-177725793 ^ -177669979)
				};
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				gcyLKeT4x0q1TEeFHRH();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void gcyLKeT4x0q1TEeFHRH()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object nZgO8MTVSt1ANtXKuN6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool PBBsvaTYLDdhhJpoxBF()
	{
		return AGHH69TskWFoLKLliCx == null;
	}

	internal static TokenExtensions ELJ7uiTIVFDhmNLvLs1()
	{
		return AGHH69TskWFoLKLliCx;
	}
}
