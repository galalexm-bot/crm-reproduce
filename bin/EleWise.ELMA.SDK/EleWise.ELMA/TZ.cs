using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA;

public static class TZ
{
	private static ITimeZoneService timeZoneService;

	private static TimeZoneModel serverTimeZone;

	private static int? serverTimeZoneOffset;

	private static int? runtimeTimeZoneOffset;

	private static int diffBtServerDtAndRuntimeDt;

	private static readonly Lazy<DateTime> MaxThreshold;

	private static readonly Lazy<DateTime> MinThreshold;

	private static IEnumerable<TimeZoneModel> timeZones;

	private static readonly Lazy<TZSettings> tzSettingsRuntime;

	private static readonly Lazy<TZSettings> tzSettingsServer;

	public const string UserTimeZoneCookieName = "ElmaUserTimeZoneOffset";

	public const string ServerTimeZoneCookieName = "ElmaServerTimeZoneOffset";

	public const string RuntimeTimeZoneCookieName = "ElmaRuntimeTimeZoneOffset";

	public const string BlockedTimeZoneCookieName = "ElmaBlockedTimeZoneOffset";

	private static TZ A2LDXDQmdxxg5KFGq2i;

	internal static ITimeZoneService TimeZoneService
	{
		get
		{
			int num = 1;
			int num2 = num;
			ITimeZoneService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = timeZoneService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (timeZoneService = Locator.GetServiceNotNull<ITimeZoneService>());
					break;
				}
				break;
			}
			return obj;
		}
		set
		{
			timeZoneService = value;
		}
	}

	public static TimeZoneModel ServerTimeZone => serverTimeZone;

	public static int ServerOffset
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return serverTimeZoneOffset.Value;
				default:
					serverTimeZoneOffset = f7MZFnCGPf0PkI62Dbf(QbM3wUChjTrfMEwZq4L());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (!serverTimeZoneOffset.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public static int RuntimeOffset
	{
		get
		{
			//Discarded unreachable code: IL_00d1, IL_00e0
			int num = 4;
			int num2 = num;
			TimeSpan offset = default(TimeSpan);
			DateTimeOffset dateTimeOffset = default(DateTimeOffset);
			while (true)
			{
				switch (num2)
				{
				case 5:
					runtimeTimeZoneOffset = F3w5PNQsJtb8mdxNn0W(offset.TotalMinutes);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					dateTimeOffset = RWWXcJCEw8sOxnjc0L6();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					offset = dateTimeOffset.Offset;
					num2 = 5;
					break;
				default:
					return runtimeTimeZoneOffset.Value;
				case 4:
					if (runtimeTimeZoneOffset.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 1;
				}
			}
		}
	}

	public static int ClientOffset => f7MZFnCGPf0PkI62Dbf(((ITimeZoneService)v00b1PCfdohELX7PoV6()).CurrentUserTimeZone);

	public static DateTime ClientDateTimeNow => ContextVars.GetOrAdd((string)dHQLrAQ9x4QVAkERedD(-867826612 ^ -867812212), () => _003C_003Ec.pddU39f7qrG7gdhZTnoQ().ToClientDateTime());

	public static DateTime CurrentClientDate
	{
		get
		{
			int num = 1;
			int num2 = num;
			DateTime dateTime = default(DateTime);
			while (true)
			{
				switch (num2)
				{
				default:
					return dateTime.Date;
				case 1:
					dateTime = kf9DwRCQhxhwlbHA4Mf();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static IEnumerable<TimeZoneModel> TimeZones
	{
		get
		{
			if (timeZones == null)
			{
				InitializeTimeZoneCollection();
			}
			return timeZones;
		}
	}

	public static TZSettings Client => new TZSettings(TZSettings.TZType.Client, vpWu6oCR3emRshksOsG());

	public static TZSettings Runtime => tzSettingsRuntime.Value;

	public static TZSettings Server => tzSettingsServer.Value;

	public static TZSettings WithoutOffset => new TZSettings(TZSettings.TZType.WithoutOffset, 0);

	internal static void InitializeServerTimeZone(string serverTimeZoneData)
	{
		//Discarded unreachable code: IL_004f, IL_0082, IL_00b7, IL_00c6
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
				try
				{
					serverTimeZone = (TimeZoneModel)nDZqjqQJdYAmqhBdLct(serverTimeZoneData);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new InitializationException((string)y9JBUcQdqMje0efNIJF(dHQLrAQ9x4QVAkERedD(0x49E27B8A ^ 0x49E24C12)), innerException);
					}
				}
				break;
			case 1:
				break;
			}
			diffBtServerDtAndRuntimeDt = ServerOffset - Jg73imQlitfmEYOxCc8();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static string GetServerTimeZoneForSystemConfig(ITransformationProvider transform)
	{
		//Discarded unreachable code: IL_0049, IL_009b, IL_0278, IL_02a7, IL_02b6
		string result = default(string);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
				int num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 1;
				}
				TimeZoneModel timeZoneModel = default(TimeZoneModel);
				DateTime dateTime = default(DateTime);
				while (true)
				{
					switch (num)
					{
					case 4:
						return result;
					case 8:
						if (!T2RLuCQcyiSpXDsiRg1(timeZoneModel, null))
						{
							num = 6;
							continue;
						}
						goto case 3;
					case 1:
					case 6:
						result = (string)IWsM4OCbb8VXM6IkPas(timeZoneModel);
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num = 1;
						}
						continue;
					case 2:
						CS_0024_003C_003E8__locals0.offset = checked(F3w5PNQsJtb8mdxNn0W(RPlja5QUIMDL2ZoxUC7(dateTime, bYXj4JQLGmyo44apape()).TotalMinutes / 30.0 + 0.5) * 30);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num = 0;
						}
						continue;
					case 3:
						timeZoneModel = new TimeZoneModel((string)wCvhV1CFSD3pMf1BNUC(H4DPxnQzZcwOB5J9DpT()), (string)D5YWY7CoxaBkQEGAuaH(b3EwGSCWkVaoWoLrNag(gyRXh3CBiSbGv3cwuOo(H4DPxnQzZcwOB5J9DpT()), dHQLrAQ9x4QVAkERedD(-289714582 ^ -289704412), string.Empty)), CS_0024_003C_003E8__locals0.offset, dst: false);
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num = 0;
						}
						continue;
					case 5:
						dateTime = (DateTime)transform.ExecuteScalar((string)uwgF7VQYq8DDAcclaVm(dHQLrAQ9x4QVAkERedD(-1411196499 ^ -1411194451), ((Dialect)hUryknQ5MuXgbBMQa7P(transform)).CurrentTimestamp, dHQLrAQ9x4QVAkERedD(0xA592A41 ^ 0xA591253), x6Xc2FQjAEk6PFlOUpS(hUryknQ5MuXgbBMQa7P(transform), dHQLrAQ9x4QVAkERedD(-2106517564 ^ -2106511386))));
						num = 2;
						continue;
					case 9:
						qd6WHfQrMRoFr37gMBu();
						num = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num = 3;
						}
						continue;
					case 7:
						ascNSSQgxfoBNQyHjpH();
						num = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num = 5;
						}
						continue;
					}
					timeZoneModel = TimeZones.FirstOrDefault(delegate(TimeZoneModel tz)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (tz.Offset != CS_0024_003C_003E8__locals0.offset)
								{
									return false;
								}
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num4 = 0;
								}
								break;
							default:
								return !_003C_003Ec__DisplayClass8_0.lkpQbvf7I2ORhQuG1sTe(tz);
							}
						}
					});
					num = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num = 1;
					}
				}
			}
			catch (Exception innerException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw new InitializationException((string)y9JBUcQdqMje0efNIJF(dHQLrAQ9x4QVAkERedD(-2107978722 ^ -2107968390)), innerException);
				}
			}
		}
	}

	private static bool IsServerRuntimeSideTransformationValid(DateTime dateTime)
	{
		//Discarded unreachable code: IL_0083, IL_0092, IL_0134, IL_014e
		int num = 10;
		DateTime value2 = default(DateTime);
		int num3 = default(int);
		DateTime value = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return R5kt3VCvW3wgroBKBi0(dateTime, value2);
				case 1:
					if (num3 >= 0)
					{
						num = 8;
						break;
					}
					goto case 6;
				case 3:
				case 9:
					return false;
				case 4:
					if (num3 <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 7:
					value2 = MaxThreshold.Value;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					if (HoyhmQCCqT7MZAUcMgL(dateTime, DateTime.MinValue))
					{
						num2 = 9;
						continue;
					}
					goto default;
				default:
					if (!(dateTime == DateTime.MaxValue))
					{
						num3 = diffBtServerDtAndRuntimeDt;
						num = 7;
						break;
					}
					num2 = 3;
					continue;
				case 5:
					value = MinThreshold.Value;
					num2 = 4;
					continue;
				case 6:
					return ru8pQyC8BhrTVZqopZW(dateTime, value);
				case 8:
					return true;
				}
				break;
			}
		}
	}

	public static DateTime ToServerDateTime(this DateTime runtimeDateTime)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return DateTime.SpecifyKind(runtimeDateTime, DateTimeKind.Unspecified);
			case 1:
				return Oc1C75CuFqXJWep8ERZ(runtimeDateTime, DateTimeKind.Unspecified);
			case 2:
				if (oOqmKICInkIxedWiatA(runtimeDateTime))
				{
					return Oc1C75CuFqXJWep8ERZ(runtimeDateTime.AddMinutes(diffBtServerDtAndRuntimeDt), DateTimeKind.Unspecified);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!atWLqxCZ1tVKv1YXexW())
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	public static DateTime ToRuntimeDateTimeFromServer(this DateTime serverDateTime)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Oc1C75CuFqXJWep8ERZ(serverDateTime, DateTimeKind.Unspecified);
			case 1:
				if (atWLqxCZ1tVKv1YXexW())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (IsServerRuntimeSideTransformationValid(serverDateTime))
				{
					return DateTime.SpecifyKind(serverDateTime.AddMinutes(-diffBtServerDtAndRuntimeDt), DateTimeKind.Local);
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return Oc1C75CuFqXJWep8ERZ(serverDateTime, DateTimeKind.Local);
			}
		}
	}

	private static bool IsServerTimeZoneRuntimeTimeZone()
	{
		return diffBtServerDtAndRuntimeDt == 0;
	}

	public static DateTime ToClientDateTime(this DateTime runtimeDateTime, TZSettings settings = null)
	{
		return ((ITimeZoneService)v00b1PCfdohELX7PoV6()).ToClientDateTime(runtimeDateTime, settings);
	}

	public static DateTime ToRuntimeDateTimeFromClient(this DateTime clientDateTime, TZSettings settings = null)
	{
		return TimeZoneService.ToRuntimeDateTimeFromClient(clientDateTime, settings);
	}

	public static string ToRuntimeDateTimeFromClient(string clientDateTimeString)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 2:
				return dateTime.ToString((IFormatProvider)ndAjtBCVOndr3I0frI9());
			case 1:
				if (!string.IsNullOrEmpty(clientDateTimeString))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			}
			if (DateTime.TryParse(clientDateTimeString, out var result))
			{
				dateTime = result.ToRuntimeDateTimeFromClient();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 2;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	private static void InitializeTimeZoneCollection()
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
				vwMIj4CiqtqVj5aIl89(ff7tn0CSVqRDghoOVAn(), (Action)delegate
				{
					//Discarded unreachable code: IL_0032, IL_0041, IL_0123, IL_0148, IL_0157, IL_0166, IL_0190, IL_019f, IL_02c7, IL_05a0, IL_05d8, IL_05e7
					int num3 = 2;
					IEnumerator<XElement> enumerator = default(IEnumerator<XElement>);
					XElement current = default(XElement);
					string text = default(string);
					XElement xElement = default(XElement);
					List<TimeZoneModel> list = default(List<TimeZoneModel>);
					string text2 = default(string);
					string value2 = default(string);
					int result2 = default(int);
					string value = default(string);
					XElement xElement3 = default(XElement);
					XElement xElement2 = default(XElement);
					XElement xElement4 = default(XElement);
					int result = default(int);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 3:
								try
								{
									while (true)
									{
										IL_032d:
										int num5;
										if (!_003C_003Ec.qeTMOnf73FltHRRhSAqT(enumerator))
										{
											num5 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
											{
												num5 = 23;
											}
											goto IL_0050;
										}
										goto IL_030a;
										IL_030a:
										current = enumerator.Current;
										num5 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
										{
											num5 = 10;
										}
										goto IL_0050;
										IL_0050:
										while (true)
										{
											int num6;
											switch (num5)
											{
											case 29:
												text = (string)_003C_003Ec.YPQ4Kyf7eXNksYOKmSG1(xElement);
												num5 = 14;
												continue;
											case 18:
											case 19:
												list.Add(new TimeZoneModel(text2, value2, result2, dst: false));
												num5 = 15;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
												{
													num5 = 7;
												}
												continue;
											case 4:
												if (_003C_003Ec.nHjyHPf7PF9TmjAdvFJm(value))
												{
													num5 = 25;
													continue;
												}
												goto case 16;
											case 2:
												if (!_003C_003Ec.nHjyHPf7PF9TmjAdvFJm(value2))
												{
													num6 = 4;
													goto IL_004c;
												}
												goto case 25;
											case 31:
												if (xElement3 != null)
												{
													num5 = 8;
													continue;
												}
												goto case 13;
											case 10:
												xElement2 = (XElement)_003C_003Ec.KJkqoRf7OayT9aYb5kKM(current, (XName)(string)_003C_003Ec.yWCNDef7nVSfCVcj2Ajl(-210725949 ^ -210759011));
												num5 = 15;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
												{
													num5 = 20;
												}
												continue;
											case 27:
												if (!_003C_003Ec.nHjyHPf7PF9TmjAdvFJm(text2))
												{
													num5 = 2;
													continue;
												}
												goto case 25;
											case 9:
												if (xElement2 != null)
												{
													num6 = 31;
													goto IL_004c;
												}
												goto case 13;
											case 28:
												_003C_003Ec.qryayJf721RQrfpWAZpM(_003C_003Ec.NdJcSpf71FyldDfkbYnP(), _003C_003Ec.JaCI4uf7NxbLGbKHutHI(_003C_003Ec.yWCNDef7nVSfCVcj2Ajl(0x5A4C7B29 ^ 0x5A491857), value, text2));
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
												{
													num5 = 1;
												}
												continue;
											case 16:
												if (int.TryParse(value, out result2))
												{
													num5 = 12;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
													{
														num5 = 18;
													}
													continue;
												}
												goto case 21;
											case 20:
												xElement3 = (XElement)_003C_003Ec.KJkqoRf7OayT9aYb5kKM(current, _003C_003Ec.lGbrTMf7kMajkbrwKGmW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE8BAA)));
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
												{
													num5 = 0;
												}
												continue;
											case 8:
												if (xElement4 == null)
												{
													num5 = 13;
													continue;
												}
												goto case 17;
											case 13:
												_003C_003Ec.qryayJf721RQrfpWAZpM(Logger.Log, _003C_003Ec.yWCNDef7nVSfCVcj2Ajl(0x34185E55 ^ 0x341D3C07));
												num6 = 26;
												goto IL_004c;
											case 6:
												break;
											case 1:
											case 3:
											case 22:
											case 26:
											case 32:
												goto IL_032d;
											case 30:
												value2 = xElement3.Value;
												num5 = 7;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
												{
													num5 = 7;
												}
												continue;
											case 25:
												_003C_003Ec.qryayJf721RQrfpWAZpM(_003C_003Ec.NdJcSpf71FyldDfkbYnP(), _003C_003Ec.yWCNDef7nVSfCVcj2Ajl(-1939377524 ^ -1939730392));
												num5 = 32;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
												{
													num5 = 10;
												}
												continue;
											case 15:
												xElement = (XElement)_003C_003Ec.KJkqoRf7OayT9aYb5kKM(current, (XName)(string)_003C_003Ec.yWCNDef7nVSfCVcj2Ajl(-1108654032 ^ -1108464808));
												num5 = 24;
												continue;
											case 7:
												value = xElement4.Value;
												num5 = 27;
												continue;
											default:
												xElement4 = current.Element(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123647348));
												num5 = 9;
												continue;
											case 14:
												if (!_003C_003Ec.nHjyHPf7PF9TmjAdvFJm(text))
												{
													num5 = 12;
													continue;
												}
												goto case 5;
											case 17:
												text2 = (string)_003C_003Ec.YPQ4Kyf7eXNksYOKmSG1(xElement2);
												num5 = 30;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
												{
													num5 = 29;
												}
												continue;
											case 11:
												list.Add(new TimeZoneModel(text2, value2, result, dst: true));
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
												{
													num5 = 5;
												}
												continue;
											case 24:
												if (xElement != null)
												{
													num5 = 29;
													continue;
												}
												goto case 5;
											case 12:
												if (!int.TryParse(text, out result))
												{
													num5 = 28;
													continue;
												}
												goto case 11;
											case 21:
												_003C_003Ec.qryayJf721RQrfpWAZpM(_003C_003Ec.NdJcSpf71FyldDfkbYnP(), _003C_003Ec.JaCI4uf7NxbLGbKHutHI(_003C_003Ec.yWCNDef7nVSfCVcj2Ajl(-1487388570 ^ -1487068320), value, text2));
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
												{
													num5 = 3;
												}
												continue;
											case 5:
												timeZones = from tz in list
													orderby tz.Offset, tz.TimeZoneId, tz.Dst
													select tz;
												num5 = 22;
												continue;
											case 23:
												return;
												IL_004c:
												num5 = num6;
												continue;
											}
											break;
										}
										goto IL_030a;
									}
								}
								finally
								{
									if (enumerator != null)
									{
										int num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
										{
											num7 = 0;
										}
										while (true)
										{
											switch (num7)
											{
											case 1:
												_003C_003Ec.puNP7Uf7pspv6fTjU81H(enumerator);
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
												{
													num7 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
							case 1:
								break;
							case 0:
								return;
							case 2:
								list = new List<TimeZoneModel>();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						}
						enumerator = ((XContainer)_003C_003Ec.ct2YCgf7TvVfsbcwbyGK(_003C_003Ec.zBZ2pGf7XiAsmuHb2jFA(new TextTemplateGenerator((string)_003C_003Ec.zQiswNf7Ki5w8V5FIkRe()), new { }))).Descendants((XName)_003C_003Ec.lGbrTMf7kMajkbrwKGmW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787148965))).GetEnumerator();
						num3 = 3;
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static TimeZoneModel Deserialize(string data)
	{
		return JsonConvert.DeserializeObject<TimeZoneModel>(data);
	}

	public static TZSettings Utc(int timeZoneOffset)
	{
		return new TZSettings(TZSettings.TZType.Custom, timeZoneOffset);
	}

	static TZ()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 4:
					MinThreshold = new Lazy<DateTime>(delegate
					{
						int num3 = 2;
						int num4 = num3;
						DateTime minValue = default(DateTime);
						while (true)
						{
							switch (num4)
							{
							case 1:
								return DateTime.MinValue;
							case 2:
								if (diffBtServerDtAndRuntimeDt < 0)
								{
									minValue = DateTime.MinValue;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
									{
										num4 = 0;
									}
								}
								else
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num4 = 1;
									}
								}
								break;
							default:
								return minValue.AddMinutes(-diffBtServerDtAndRuntimeDt);
							}
						}
					});
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 5;
					}
					continue;
				default:
					MaxThreshold = new Lazy<DateTime>(delegate
					{
						int num5 = 2;
						int num6 = num5;
						DateTime maxValue = default(DateTime);
						while (true)
						{
							switch (num6)
							{
							case 2:
								if (diffBtServerDtAndRuntimeDt <= 0)
								{
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
									{
										num6 = 0;
									}
								}
								else
								{
									maxValue = DateTime.MaxValue;
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
									{
										num6 = 0;
									}
								}
								break;
							default:
								return maxValue.AddMinutes(-diffBtServerDtAndRuntimeDt);
							case 1:
								return DateTime.MaxValue;
							}
						}
					});
					num2 = 4;
					continue;
				case 1:
					nWSX8rCqLIltFdqhjtK();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				case 3:
					tzSettingsServer = new Lazy<TZSettings>(() => new TZSettings(TZSettings.TZType.Server, _003C_003Ec.DGRmvif7DYoQmoWNVNqu()));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			tzSettingsRuntime = new Lazy<TZSettings>(() => new TZSettings(TZSettings.TZType.Runtime, _003C_003Ec.nvkyW8f7aqc9K1G8yK3Z()));
			num = 3;
		}
	}

	internal static bool h2UV2IQynbgVwgGn4ef()
	{
		return A2LDXDQmdxxg5KFGq2i == null;
	}

	internal static TZ Y6uv1TQM9xpaPa3EQVk()
	{
		return A2LDXDQmdxxg5KFGq2i;
	}

	internal static object nDZqjqQJdYAmqhBdLct(object P_0)
	{
		return Deserialize((string)P_0);
	}

	internal static object dHQLrAQ9x4QVAkERedD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object y9JBUcQdqMje0efNIJF(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int Jg73imQlitfmEYOxCc8()
	{
		return RuntimeOffset;
	}

	internal static void qd6WHfQrMRoFr37gMBu()
	{
		InitializeTimeZoneCollection();
	}

	internal static void ascNSSQgxfoBNQyHjpH()
	{
		TimeZoneInfo.ClearCachedData();
	}

	internal static object hUryknQ5MuXgbBMQa7P(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object x6Xc2FQjAEk6PFlOUpS(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object uwgF7VQYq8DDAcclaVm(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static DateTime bYXj4JQLGmyo44apape()
	{
		return DateTime.UtcNow;
	}

	internal static TimeSpan RPlja5QUIMDL2ZoxUC7(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static int F3w5PNQsJtb8mdxNn0W(double P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static bool T2RLuCQcyiSpXDsiRg1(object P_0, object P_1)
	{
		return (TimeZoneModel)P_0 == (TimeZoneModel)P_1;
	}

	internal static object H4DPxnQzZcwOB5J9DpT()
	{
		return TimeZoneInfo.Local;
	}

	internal static object wCvhV1CFSD3pMf1BNUC(object P_0)
	{
		return ((TimeZoneInfo)P_0).Id;
	}

	internal static object gyRXh3CBiSbGv3cwuOo(object P_0)
	{
		return ((TimeZoneInfo)P_0).DisplayName;
	}

	internal static object b3EwGSCWkVaoWoLrNag(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object D5YWY7CoxaBkQEGAuaH(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object IWsM4OCbb8VXM6IkPas(object P_0)
	{
		return ((TimeZoneModel)P_0).ToJson();
	}

	internal static object QbM3wUChjTrfMEwZq4L()
	{
		return ServerTimeZone;
	}

	internal static int f7MZFnCGPf0PkI62Dbf(object P_0)
	{
		return ((TimeZoneModel)P_0).Offset;
	}

	internal static DateTimeOffset RWWXcJCEw8sOxnjc0L6()
	{
		return DateTimeOffset.Now;
	}

	internal static object v00b1PCfdohELX7PoV6()
	{
		return TimeZoneService;
	}

	internal static DateTime kf9DwRCQhxhwlbHA4Mf()
	{
		return ClientDateTimeNow;
	}

	internal static bool HoyhmQCCqT7MZAUcMgL(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static bool R5kt3VCvW3wgroBKBi0(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static bool ru8pQyC8BhrTVZqopZW(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static bool atWLqxCZ1tVKv1YXexW()
	{
		return IsServerTimeZoneRuntimeTimeZone();
	}

	internal static DateTime Oc1C75CuFqXJWep8ERZ(DateTime P_0, DateTimeKind P_1)
	{
		return DateTime.SpecifyKind(P_0, P_1);
	}

	internal static bool oOqmKICInkIxedWiatA(DateTime dateTime)
	{
		return IsServerRuntimeSideTransformationValid(dateTime);
	}

	internal static object ndAjtBCVOndr3I0frI9()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static object ff7tn0CSVqRDghoOVAn()
	{
		return SR.KeyCultureInfo;
	}

	internal static void vwMIj4CiqtqVj5aIl89(object P_0, object P_1)
	{
		SR.RunWithCulture((CultureInfo)P_0, (Action)P_1);
	}

	internal static int vpWu6oCR3emRshksOsG()
	{
		return ClientOffset;
	}

	internal static void nWSX8rCqLIltFdqhjtK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
