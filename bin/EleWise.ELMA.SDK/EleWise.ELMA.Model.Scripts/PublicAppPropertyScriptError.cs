using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

public class PublicAppPropertyScriptError : IPublicApplicationCompatibilityError
{
	private string _scriptTypeCode;

	private string _messageFormat;

	private List<string> _propertyNames;

	internal static PublicAppPropertyScriptError Ju5xopbivDGWDjPLEGrO;

	public bool IsError
	{
		[CompilerGenerated]
		get
		{
			return _003CIsError_003Ek__BackingField;
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
					_003CIsError_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Message
	{
		get
		{
			//Discarded unreachable code: IL_003e
			int num = 1;
			int num2 = num;
			string format;
			while (true)
			{
				switch (num2)
				{
				default:
					format = SR.T((string)FbGfZnbiVru2CGJCmIpA(0x3A6135BE ^ 0x3A638AF6));
					break;
				case 1:
					if (ePl6BebiI2rRZ0sJKo82(_messageFormat))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					format = _messageFormat;
					break;
				}
				break;
			}
			return string.Format(format, EYd0jfbiS9T29eYrDm0o(FbGfZnbiVru2CGJCmIpA(-1487388570 ^ -1487385500), _propertyNames.Select((string p) => (string)_003C_003Ec.zFFaaQC1IdNS1yloWi1a(_003C_003Ec.ishulYC1uatucbfpViWg(-1317790512 ^ -1317797490), p, _003C_003Ec.ishulYC1uatucbfpViWg(0x18A6761F ^ 0x18A66B41))).ToArray()));
		}
	}

	public string ScriptTypeCode => _scriptTypeCode;

	public List<string> PropertyNames => _propertyNames;

	public PublicAppPropertyScriptError(string scriptTypeCode, string messageFormat, params string[] propertyNames)
	{
		//Discarded unreachable code: IL_003a, IL_00c6, IL_00d5
		rQ9kT0biuORYkUZfsj5J();
		_propertyNames = new List<string>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				_messageFormat = messageFormat;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num = 2;
				}
				continue;
			default:
				IsError = true;
				num = 6;
				continue;
			case 6:
				return;
			case 2:
				if (propertyNames == null)
				{
					num = 5;
					continue;
				}
				break;
			case 1:
			{
				_scriptTypeCode = scriptTypeCode;
				int num2 = 3;
				num = num2;
				continue;
			}
			case 4:
				break;
			}
			_propertyNames.AddRange(propertyNames);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
			{
				num = 0;
			}
		}
	}

	internal static void rQ9kT0biuORYkUZfsj5J()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OuDyrTbi8DZrWnKnVDjp()
	{
		return Ju5xopbivDGWDjPLEGrO == null;
	}

	internal static PublicAppPropertyScriptError z4K59lbiZpVoLGdiEVYA()
	{
		return Ju5xopbivDGWDjPLEGrO;
	}

	internal static bool ePl6BebiI2rRZ0sJKo82(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object FbGfZnbiVru2CGJCmIpA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object EYd0jfbiS9T29eYrDm0o(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}
}
