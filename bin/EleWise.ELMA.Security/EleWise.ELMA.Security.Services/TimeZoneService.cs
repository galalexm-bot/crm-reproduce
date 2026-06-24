using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service]
public class TimeZoneService : ITimeZoneService
{
	private static TimeZoneService swDbUVvPyJMC04Yiwxm;

	[NotNull]
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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public IBLOBStore BLOBStore
	{
		[CompilerGenerated]
		get
		{
			return _003CBLOBStore_003Ek__BackingField;
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
					_003CBLOBStore_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
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

	public TimeZoneModel CurrentUserTimeZone
	{
		get
		{
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_003C_003Ec__DisplayClass9_.currentUser != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
						{
							num2 = 0;
						}
						break;
					}
					return (TimeZoneModel)t2624vvocX3afo1PguO();
				case 2:
					_003C_003Ec__DisplayClass9_.currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 2;
					break;
				default:
					return ContextVars.GetOrAdd((string)pN4tIsvU1QLiHcgbo81(-905821499 ^ -905828701), _003C_003Ec__DisplayClass9_._003Cget_CurrentUserTimeZone_003Eb__0);
				}
			}
		}
	}

	public long? GetBlockedTimeZoneOffset()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		byte[] array = ((currentUser != null) ? BLOBStore.LoadOrNull(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-185816410 ^ -185807324), currentUser.Id)) : null);
		if (array != null)
		{
			try
			{
				return ClassSerializationHelper.DeserializeObject(array) as long?;
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784489199), currentUser.Id), exception);
			}
		}
		return TZ.ServerOffset;
	}

	public TimeZoneModel GetUserTimeZone(IUser user)
	{
		//Discarded unreachable code: IL_0076, IL_0085
		int num = 4;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new ArgumentException((string)KV89wbvK9kocltxWLox(pN4tIsvU1QLiHcgbo81(0xA4E904F ^ 0xA4EF529), new object[1] { o46wwFvJt4vvFwU48aN(typeof(EleWise.ELMA.Security.Models.IUser).TypeHandle).FullName }));
			default:
				return (TimeZoneModel)aJ8SAivt13beP81MfsA(user2);
			case 4:
				if (user == null)
				{
					num2 = 3;
					break;
				}
				user2 = user as EleWise.ELMA.Security.Models.IUser;
				num2 = 2;
				break;
			case 3:
				throw new ArgumentNullException((string)pN4tIsvU1QLiHcgbo81(-2030777218 ^ -2030780012));
			case 2:
				if (user2 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public DateTime ToClientDateTime(DateTime runtimeDateTime, TZSettings settings = null)
	{
		//Discarded unreachable code: IL_0058, IL_0164, IL_0173, IL_01a2
		int num = 3;
		int num2 = num;
		int? num5 = default(int?);
		int? num3 = default(int?);
		while (true)
		{
			int? num4;
			switch (num2)
			{
			case 1:
				num4 = vOVi1DvGLXNRyDYxwwM(settings);
				break;
			case 4:
				return runtimeDateTime.ToServerDateTime();
			case 6:
				if (!IsRuntimeTimeZoneDetermined(num5))
				{
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 5;
			default:
				return WgobaDvqUWQIkBshc4x(runtimeDateTime, DateTimeKind.Unspecified);
			case 2:
				if (GHOHeDvOGIHMq4vgPha(settings) == TZSettings.TZType.WithoutOffset)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_00ab;
			case 5:
				return WgobaDvqUWQIkBshc4x(runtimeDateTime, DateTimeKind.Unspecified);
			case 9:
				if (!IsServerTimeZoneDetermined(num5))
				{
					if (IsClientRuntimeSideTransformationValid(runtimeDateTime, num5))
					{
						num2 = 10;
						continue;
					}
					goto case 7;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 != 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				if (NIRqf7vhMnAndKrcdXI(settings, null))
				{
					num2 = 2;
					continue;
				}
				goto IL_00ab;
			case 7:
				return WgobaDvqUWQIkBshc4x(runtimeDateTime, DateTimeKind.Unspecified);
			case 10:
				return WgobaDvqUWQIkBshc4x(runtimeDateTime.AddMinutes(GetDiffBtClientDtAndRuntimeDt(num5)), DateTimeKind.Unspecified);
			case 8:
				{
					num4 = num3;
					break;
				}
				IL_00ab:
				if (!nZSopyvcuOe4ZUOEgVy(settings, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
					{
						num2 = 1;
					}
					continue;
				}
				num3 = null;
				num2 = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
				{
					num2 = 4;
				}
				continue;
			}
			num5 = num4;
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
			{
				num2 = 6;
			}
		}
	}

	public DateTime ToRuntimeDateTimeFromClient(DateTime clientDateTime, TZSettings settings = null)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_00f0, IL_00ff, IL_0154, IL_0163, IL_017e, IL_0188
		int num = 3;
		int? num5 = default(int?);
		int? num3 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int? num4;
				switch (num2)
				{
				case 5:
					if (!IsRuntimeTimeZoneDetermined(num5))
					{
						num2 = 11;
						continue;
					}
					goto case 12;
				case 6:
					return WgobaDvqUWQIkBshc4x(clientDateTime, DateTimeKind.Unspecified);
				case 4:
					return WgobaDvqUWQIkBshc4x(clientDateTime.AddMinutes(-GetDiffBtClientDtAndRuntimeDt(num5)), DateTimeKind.Local);
				case 3:
					if (!NIRqf7vhMnAndKrcdXI(settings, null))
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 12:
					return WgobaDvqUWQIkBshc4x(clientDateTime, DateTimeKind.Local);
				case 11:
					if (!IsServerTimeZoneDetermined(num5))
					{
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				default:
					return clientDateTime.ToRuntimeDateTimeFromServer();
				case 7:
					if (IsClientRuntimeSideTransformationValid(clientDateTime, num5))
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 6;
				case 9:
					num4 = vOVi1DvGLXNRyDYxwwM(settings);
					break;
				case 1:
					if (settings.Type == TZSettings.TZType.WithoutOffset)
					{
						num2 = 8;
						continue;
					}
					goto case 2;
				case 8:
					return WgobaDvqUWQIkBshc4x(clientDateTime, DateTimeKind.Unspecified);
				case 2:
					if (!nZSopyvcuOe4ZUOEgVy(settings, null))
					{
						num2 = 9;
						continue;
					}
					goto end_IL_0012;
				case 10:
					num4 = num3;
					break;
				}
				num5 = num4;
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			num3 = null;
			num = 10;
		}
	}

	private bool IsRuntimeTimeZoneDetermined(int? customClientTimeZoneOffset = null)
	{
		return GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) == 0;
	}

	private bool IsServerTimeZoneDetermined(int? customClientTimeZoneOffset = null)
	{
		if (!customClientTimeZoneOffset.HasValue)
		{
			return CurrentUserTimeZone.Offset == TZ.ServerOffset;
		}
		return customClientTimeZoneOffset == TZ.ServerOffset;
	}

	private int GetDiffBtClientDtAndRuntimeDt(int? customTimeZoneOffset = null)
	{
		if (!customTimeZoneOffset.HasValue)
		{
			return ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738E3073 ^ 0x738E5679), () => ilgHvDv0VnYmkWfvAq5(CurrentUserTimeZone) - tcrfB2vEsFC06GWExJC());
		}
		return customTimeZoneOffset.Value - TZ.RuntimeOffset;
	}

	private DateTime GetMaxTheshold(int? customClientTimeZoneOffset = null)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass17_.customClientTimeZoneOffset = customClientTimeZoneOffset;
		Func<DateTime> func = delegate
		{
			int num = 2;
			int num2 = num;
			DateTime maxValue = default(DateTime);
			while (true)
			{
				switch (num2)
				{
				default:
					return maxValue.AddMinutes(-_003C_003Ec__DisplayClass17_._003C_003E4__this.GetDiffBtClientDtAndRuntimeDt(_003C_003Ec__DisplayClass17_.customClientTimeZoneOffset));
				case 2:
					if (_003C_003Ec__DisplayClass17_._003C_003E4__this.GetDiffBtClientDtAndRuntimeDt(_003C_003Ec__DisplayClass17_.customClientTimeZoneOffset) <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						maxValue = DateTime.MaxValue;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
						{
							num2 = 0;
						}
					}
					break;
				case 1:
					return DateTime.MaxValue;
				}
			}
		};
		if (_003C_003Ec__DisplayClass17_.customClientTimeZoneOffset.HasValue)
		{
			return ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1378061210 ^ -1378086364), func);
		}
		return func();
	}

	private DateTime GetMinTheshold(int? customClientTimeZoneOffset = null)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass18_.customClientTimeZoneOffset = customClientTimeZoneOffset;
		Func<DateTime> func = delegate
		{
			int num = 2;
			int num2 = num;
			DateTime minValue = default(DateTime);
			while (true)
			{
				switch (num2)
				{
				default:
					return minValue.AddMinutes(-_003C_003Ec__DisplayClass18_._003C_003E4__this.GetDiffBtClientDtAndRuntimeDt(_003C_003Ec__DisplayClass18_.customClientTimeZoneOffset));
				case 2:
					if (_003C_003Ec__DisplayClass18_._003C_003E4__this.GetDiffBtClientDtAndRuntimeDt(_003C_003Ec__DisplayClass18_.customClientTimeZoneOffset) >= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						minValue = DateTime.MinValue;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 1:
					return DateTime.MinValue;
				}
			}
		};
		if (_003C_003Ec__DisplayClass18_.customClientTimeZoneOffset.HasValue)
		{
			return ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-163225536 ^ -163248612), func);
		}
		return func();
	}

	private bool IsClientRuntimeSideTransformationValid(DateTime dateTime, int? customClientTimeZoneOffset = null)
	{
		if (dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue)
		{
			return false;
		}
		if (GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) > 0)
		{
			return dateTime < GetMaxTheshold(customClientTimeZoneOffset);
		}
		if (GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) < 0)
		{
			return dateTime > GetMinTheshold(customClientTimeZoneOffset);
		}
		return true;
	}

	public TimeZoneService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WfVtGAvFhpLVdv832OU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UyQeSlvvDSgAOmChiDW()
	{
		return swDbUVvPyJMC04Yiwxm == null;
	}

	internal static TimeZoneService VPkFXDvC7JCxP087009()
	{
		return swDbUVvPyJMC04Yiwxm;
	}

	internal static object pN4tIsvU1QLiHcgbo81(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object t2624vvocX3afo1PguO()
	{
		return TZ.ServerTimeZone;
	}

	internal static Type o46wwFvJt4vvFwU48aN(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object KV89wbvK9kocltxWLox(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object aJ8SAivt13beP81MfsA(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).TimeZone;
	}

	internal static bool NIRqf7vhMnAndKrcdXI(object P_0, object P_1)
	{
		return (TZSettings)P_0 != (TZSettings)P_1;
	}

	internal static TZSettings.TZType GHOHeDvOGIHMq4vgPha(object P_0)
	{
		return ((TZSettings)P_0).Type;
	}

	internal static DateTime WgobaDvqUWQIkBshc4x(DateTime P_0, DateTimeKind P_1)
	{
		return DateTime.SpecifyKind(P_0, P_1);
	}

	internal static bool nZSopyvcuOe4ZUOEgVy(object P_0, object P_1)
	{
		return (TZSettings)P_0 == (TZSettings)P_1;
	}

	internal static int vOVi1DvGLXNRyDYxwwM(object P_0)
	{
		return ((TZSettings)P_0).Offset;
	}

	internal static void WfVtGAvFhpLVdv832OU()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static int ilgHvDv0VnYmkWfvAq5(object P_0)
	{
		return ((TimeZoneModel)P_0).Offset;
	}

	internal static int tcrfB2vEsFC06GWExJC()
	{
		return TZ.RuntimeOffset;
	}
}
