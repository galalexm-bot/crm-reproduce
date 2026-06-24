using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class DateTimeSettings : SimpleTypeSettings, IMvcValidatableTypeSettings
{
	private static class __Resources
	{
		private static object iiVdRNCXsc1AtyXt5EL0;

		public static string ShowDate => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889303064));

		public static string ShowTime => (string)uExKGCCTBHx8bG4Dj6Pm(Hkuxk7CTFonNbL8E9b5q(-1426094279 ^ -1426447629));

		public static string WithoutOffset => (string)uExKGCCTBHx8bG4Dj6Pm(Hkuxk7CTFonNbL8E9b5q(-2107978722 ^ -2107676176));

		internal static bool Ex9SU0CXccUDjbuaRbDg()
		{
			return iiVdRNCXsc1AtyXt5EL0 == null;
		}

		internal static __Resources W1S0rFCXzYLpU9L1WDHW()
		{
			return (__Resources)iiVdRNCXsc1AtyXt5EL0;
		}

		internal static object Hkuxk7CTFonNbL8E9b5q(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object uExKGCCTBHx8bG4Dj6Pm(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	internal static DateTimeSettings O6WR9rbWf1Ch8L8M2axU;

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ShowDate")]
	[XmlElement("ShowDate")]
	[DefaultValue(true)]
	public bool ShowDate
	{
		[CompilerGenerated]
		get
		{
			return _003CShowDate_003Ek__BackingField;
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
					_003CShowDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
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

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ShowTime")]
	[DefaultValue(true)]
	[XmlElement("ShowTime")]
	public bool ShowTime
	{
		[CompilerGenerated]
		get
		{
			return _003CShowTime_003Ek__BackingField;
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
					_003CShowTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "WithoutOffset")]
	[DefaultValue(false)]
	[XmlElement("WithoutOffset")]
	public bool WithoutOffset
	{
		[CompilerGenerated]
		get
		{
			return _003CWithoutOffset_003Ek__BackingField;
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
					_003CWithoutOffset_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
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

	[XmlElement("SetCurrentDate")]
	[JsonSerializationIgnore]
	[DefaultValue(false)]
	[PublicationBehaviour(PublicationType.Delta)]
	public bool SetCurrentDate
	{
		[CompilerGenerated]
		get
		{
			return _003CSetCurrentDate_003Ek__BackingField;
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
					_003CSetCurrentDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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

	[XmlIgnore]
	public DateTime? MinDateValue { get; set; }

	[DefaultValue(null)]
	[XmlElement("MinDate")]
	[JsonSerializationIgnore]
	public string MinDate
	{
		get
		{
			int num = 5;
			int num2 = num;
			long ticks = default(long);
			DateTime? minDateValue = default(DateTime?);
			DateTime value = default(DateTime);
			while (true)
			{
				switch (num2)
				{
				default:
					return ticks.ToString();
				case 4:
					if (!minDateValue.HasValue)
					{
						num2 = 2;
						break;
					}
					minDateValue = MinDateValue;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return null;
				case 1:
					ticks = value.Ticks;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					minDateValue = MinDateValue;
					num2 = 4;
					break;
				case 3:
					value = minDateValue.Value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_008c
			int num = 3;
			int num2 = num;
			long result = default(long);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!long.TryParse(value, out result))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 4:
					MinDateValue = new DateTime(result);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return;
				case 3:
					if (!iMAMMKbW8bRpv5Hv6XHJ(value))
					{
						num2 = 2;
						continue;
					}
					break;
				case 1:
					return;
				}
				MinDateValue = null;
				num2 = 5;
			}
		}
	}

	[XmlIgnore]
	public DateTime? MinTimeValue { get; set; }

	[JsonSerializationIgnore]
	[DefaultValue(null)]
	[XmlElement("MinTime")]
	public string MinTime
	{
		get
		{
			//Discarded unreachable code: IL_003d, IL_004c
			int num = 4;
			int num2 = num;
			long ticks = default(long);
			DateTime? minTimeValue = default(DateTime?);
			DateTime value = default(DateTime);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return ticks.ToString();
				case 3:
					if (minTimeValue.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 4:
					minTimeValue = MinTimeValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					ticks = value.Ticks;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					return null;
				default:
					minTimeValue = MinTimeValue;
					num2 = 6;
					break;
				case 6:
					value = minTimeValue.Value;
					num2 = 2;
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_003d, IL_004c, IL_005b
			int num = 6;
			long result = default(long);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						if (string.IsNullOrEmpty(value))
						{
							goto end_IL_0012;
						}
						goto case 3;
					case 2:
						return;
					case 1:
					case 5:
						MinTimeValue = null;
						num2 = 4;
						continue;
					case 3:
						if (!long.TryParse(value, out result))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 4:
						return;
					}
					MinTimeValue = new DateTime(result);
					num2 = 2;
					continue;
					end_IL_0012:
					break;
				}
				num = 5;
			}
		}
	}

	[XmlIgnore]
	public DateTime? MaxDateValue { get; set; }

	[JsonSerializationIgnore]
	[XmlElement("MaxDate")]
	[DefaultValue(null)]
	public string MaxDate
	{
		get
		{
			//Discarded unreachable code: IL_0051, IL_0060
			int num = 2;
			DateTime? maxDateValue = default(DateTime?);
			long ticks = default(long);
			DateTime value = default(DateTime);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return null;
					case 3:
						maxDateValue = MaxDateValue;
						num2 = 5;
						continue;
					case 6:
						return ticks.ToString();
					case 1:
						if (maxDateValue.HasValue)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto default;
					case 4:
						ticks = value.Ticks;
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 6;
						}
						continue;
					case 2:
						maxDateValue = MaxDateValue;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						break;
					}
					break;
				}
				value = maxDateValue.Value;
				num = 4;
			}
		}
		set
		{
			//Discarded unreachable code: IL_0071
			int num = 1;
			int num2 = num;
			long result = default(long);
			while (true)
			{
				switch (num2)
				{
				case 2:
					MaxDateValue = new DateTime(result);
					num2 = 4;
					break;
				case 5:
					return;
				case 4:
					return;
				default:
					MaxDateValue = null;
					num2 = 5;
					break;
				case 1:
					if (iMAMMKbW8bRpv5Hv6XHJ(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					if (long.TryParse(value, out result))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	[XmlIgnore]
	public DateTime? MaxTimeValue { get; set; }

	[XmlElement("MaxTime")]
	[DefaultValue(null)]
	[JsonSerializationIgnore]
	public string MaxTime
	{
		get
		{
			//Discarded unreachable code: IL_009f, IL_00ae
			int num = 3;
			int num2 = num;
			long ticks = default(long);
			DateTime value = default(DateTime);
			DateTime? maxTimeValue = default(DateTime?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return ticks.ToString();
				default:
					value = maxTimeValue.Value;
					num2 = 4;
					break;
				case 4:
					ticks = value.Ticks;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					return null;
				case 5:
					maxTimeValue = MaxTimeValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					maxTimeValue = MaxTimeValue;
					num2 = 2;
					break;
				case 2:
					if (maxTimeValue.HasValue)
					{
						num2 = 5;
						break;
					}
					goto case 6;
				}
			}
		}
		set
		{
			int num = 4;
			int num2 = num;
			long result = default(long);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					if (!iMAMMKbW8bRpv5Hv6XHJ(value))
					{
						num2 = 3;
						break;
					}
					goto IL_0072;
				case 1:
					MaxTimeValue = new DateTime(result);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					return;
				case 3:
					{
						if (long.TryParse(value, out result))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0072;
					}
					IL_0072:
					MaxTimeValue = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	[JsonSerializationIgnore]
	[DefaultValue(null)]
	[XmlElement("TZ")]
	public TZSettings TZ
	{
		[CompilerGenerated]
		get
		{
			return _003CTZ_003Ek__BackingField;
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
					_003CTZ_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Delta)]
	public DateTime? DefaultValue
	{
		get
		{
			if (!string.IsNullOrEmpty(DefaultValueStr))
			{
				return new DateTime(Convert.ToInt64(DefaultValueStr));
			}
			return null;
		}
		set
		{
			DateTime? dateTime = value;
			if (dateTime.HasValue)
			{
				DefaultValueStr = dateTime.Value.Ticks.ToString();
			}
			else
			{
				DefaultValueStr = null;
			}
		}
	}

	[XmlElement("DefaultValue")]
	[DefaultValue(null)]
	[PublicationBehaviour(PublicationType.Delta)]
	[JsonSerializationIgnore]
	public string DefaultValueStr
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultValueStr_003Ek__BackingField;
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
					_003CDefaultValueStr_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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

	[XmlElement("RangeInFilter")]
	[DefaultValue(true)]
	[JsonSerializationIgnore]
	[PublicationBehaviour(PublicationType.Restart)]
	public bool RangeInFilter
	{
		[CompilerGenerated]
		get
		{
			return _003CRangeInFilter_003Ek__BackingField;
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
					_003CRangeInFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
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

	[JsonSerializationIgnore]
	[DefaultValue(false)]
	[XmlElement("RelativeInFilter")]
	[PublicationBehaviour(PublicationType.Restart)]
	public bool RelativeInFilter
	{
		[CompilerGenerated]
		get
		{
			return _003CRelativeInFilter_003Ek__BackingField;
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
					_003CRelativeInFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTimeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected DateTimeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		i0E5UkbWvQjqdpRhcciD();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0055, IL_01eb, IL_01fa
		int num = 3;
		int num2 = num;
		DateTimeSettings dateTimeSettings = default(DateTimeSettings);
		while (true)
		{
			switch (num2)
			{
			case 10:
				return MaxTime == (string)IRNuc3bWif8oRwCqlLBZ(dateTimeSettings);
			case 1:
			case 7:
				return false;
			case 4:
				if (!wMx8ojbWVhGYI3TMqyXI(MaxDate, KvPJSQbWSXTaYMcN92EP(dateTimeSettings)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 6:
				if (WithoutOffset == goSaOibWumYkAPRe8hdR(dateTimeSettings))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 1;
			case 12:
				if (SetCurrentDate == dateTimeSettings.SetCurrentDate)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 5:
				if (wMx8ojbWVhGYI3TMqyXI(MinTime, dateTimeSettings.MinTime))
				{
					num2 = 10;
					break;
				}
				goto case 1;
			case 3:
				if (!(obj is DateTimeSettings))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 2;
					}
					break;
				}
				dateTimeSettings = (DateTimeSettings)obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 11;
				}
				break;
			default:
				if (wMx8ojbWVhGYI3TMqyXI(MinDate, XiL8dkbWIRKG8LSZrwY4(dateTimeSettings)))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 11:
				if (!base.Equals(obj))
				{
					num2 = 7;
					break;
				}
				goto case 9;
			case 9:
				if (ShowDate == VGckmhbWZD0lUUAyF9sY(dateTimeSettings))
				{
					num2 = 8;
					break;
				}
				goto case 1;
			case 8:
				if (ShowTime == dateTimeSettings.ShowTime)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 2:
				return false;
			}
		}
	}

	public override int GetHashCode()
	{
		return base.GetHashCode() ^ (ShowDate.GetHashCode() * 397) ^ (((MaxDate != null) ? MaxDate.GetHashCode() : 0) * 397) ^ (((MinDate != null) ? MinDate.GetHashCode() : 0) * 397) ^ (((MaxTime != null) ? MaxTime.GetHashCode() : 0) * 397) ^ (((MinTime != null) ? MinTime.GetHashCode() : 0) * 397) ^ (SetCurrentDate.GetHashCode() * 397) ^ (ShowTime.GetHashCode() * 397) ^ (WithoutOffset.GetHashCode() * 397);
	}

	protected override void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.GetSerializationDescriptor(descriptor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			new TypeSerializationDescriptorBuilder(descriptor).ItemWithDescriptor((string)sZJi7NbWRxgi900y4uli(0x7247028A ^ 0x7245B284), delegate(TypeSerializationDescriptorBuilder i)
			{
				int num5 = 1;
				int num6 = num5;
				while (true)
				{
					switch (num6)
					{
					default:
						return;
					case 1:
						((TypeSerializationDescriptorBuilder)_003C_003Ec.rxMvA6CTC1Kdhwp8E3Hu(_003C_003Ec.ROpidICTfmjkwLcTeU1J(i, _003C_003Ec.uw9nBKCTEUJxXfw3o3QJ(_003C_003Ec.yoRZqhCTGotoK29ZG4TT(-1146510045 ^ -1146354933))), _003C_003Ec.UxZxpZCTQBsEYJ2Pgq3S(typeof(DateTime).TypeHandle))).Optional((object)null);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num6 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}).ItemWithDescriptor((string)sZJi7NbWRxgi900y4uli(0x3630F361 ^ 0x36324341), delegate(TypeSerializationDescriptorBuilder i)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						((TypeSerializationDescriptorBuilder)_003C_003Ec.rxMvA6CTC1Kdhwp8E3Hu(_003C_003Ec.ROpidICTfmjkwLcTeU1J(i, SR.T((string)_003C_003Ec.yoRZqhCTGotoK29ZG4TT(0x637E299B ^ 0x637B8F1D))), typeof(DateTime))).Optional((object)null);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
			{
				num2 = 2;
			}
		}
	}

	public override void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject)
	{
		base.SerializeToJsonObject(jsonObject);
		if (MinDateValue.HasValue)
		{
			jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FD7B57)] = MinDateValue.Value.ToString(CultureInfo.InvariantCulture);
		}
		if (MaxDateValue.HasValue)
		{
			jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2024AA6F)] = MaxDateValue.Value.ToString(CultureInfo.InvariantCulture);
		}
	}

	public override void DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
	{
		base.DeserializeFromJsonObject(jsonObject);
		if (jsonObject != null)
		{
			if (jsonObject.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875952479), out var value) && value != null && DateTime.TryParse(value.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
			{
				MinDateValue = result;
			}
			if (jsonObject.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B9051E), out var value2) && value2 != null && DateTime.TryParse(value2.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out var result2))
			{
				MaxDateValue = result2;
			}
		}
	}

	void IMvcValidatableTypeSettings.ApplyValidationRules(ICollection<ModelClientValidationRule> rules, ModelMetadata metadata, ControllerContext context, TypeSettings originalPropertySettings)
	{
		Contract.ArgumentNotNull(rules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289807462));
		if (originalPropertySettings is DateTimeSettings dateTimeSettings)
		{
			DateTime? minDateValue = MinDateValue;
			DateTime? minDateValue2 = dateTimeSettings.MinDateValue;
			if (minDateValue.HasValue == minDateValue2.HasValue && (!minDateValue.HasValue || !(minDateValue.GetValueOrDefault() != minDateValue2.GetValueOrDefault())) && !(MaxDateValue != dateTimeSettings.MaxDateValue))
			{
				return;
			}
		}
		rules.RemoveAll((ModelClientValidationRule r) => _003C_003Ec.EdgYJnCT86RDWrQYedtv(_003C_003Ec.PApVeHCTvVAbmlQ6phaQ(r), _003C_003Ec.yoRZqhCTGotoK29ZG4TT(0x4DC2B14D ^ 0x4DC01259)));
		if ((MinDateValue.HasValue && MinDateValue.Value > DateTime.MinValue) || (MaxDateValue.HasValue && MaxDateValue.Value > DateTime.MinValue))
		{
			rules.AddRange(((ModelValidator)new RangeDateTimeValidator(metadata, context, new RangeDateTimeAttribute(MinDate, MaxDate))).GetClientValidationRules());
		}
	}

	internal static bool vrOHwpbWQPgXBDNYiTG1()
	{
		return O6WR9rbWf1Ch8L8M2axU == null;
	}

	internal static DateTimeSettings g2q7aAbWC13aNSwgF0Wr()
	{
		return O6WR9rbWf1Ch8L8M2axU;
	}

	internal static void i0E5UkbWvQjqdpRhcciD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool iMAMMKbW8bRpv5Hv6XHJ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool VGckmhbWZD0lUUAyF9sY(object P_0)
	{
		return ((DateTimeSettings)P_0).ShowDate;
	}

	internal static bool goSaOibWumYkAPRe8hdR(object P_0)
	{
		return ((DateTimeSettings)P_0).WithoutOffset;
	}

	internal static object XiL8dkbWIRKG8LSZrwY4(object P_0)
	{
		return ((DateTimeSettings)P_0).MinDate;
	}

	internal static bool wMx8ojbWVhGYI3TMqyXI(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object KvPJSQbWSXTaYMcN92EP(object P_0)
	{
		return ((DateTimeSettings)P_0).MaxDate;
	}

	internal static object IRNuc3bWif8oRwCqlLBZ(object P_0)
	{
		return ((DateTimeSettings)P_0).MaxTime;
	}

	internal static object sZJi7NbWRxgi900y4uli(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
