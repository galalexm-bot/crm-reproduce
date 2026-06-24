using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

public class DiagnosticsSettings : GlobalSettingsBase
{
	internal class __Resources_DiagnosticsSettings
	{
		private static __Resources_DiagnosticsSettings EMgdjd8VwZvGYCv4rNvo;

		public static string Enabled => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(-1146510045 ^ -1146324831));

		public static string ExportReports => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(-1633514411 ^ -1633201695));

		public static string ClearOldReports => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(-1317790512 ^ -1317945048));

		public static string ExportReportPeriod => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(-16752921 ^ -16416693));

		public static string ExportReportStartTime => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(--1333735954 ^ 0x4F7AECF4));

		public static string ClearStatisticsPeriod => SR.T((string)U1o6DW8VHVIdNaBhWEc0(-1998538950 ^ -1998231098));

		public static string LogsEnabled => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(0x4DC2B14D ^ 0x4DC76E7B));

		public static string LogLevel => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(-1334993905 ^ -1335344301));

		public static string CountersEnabled => (string)TpGnRM8VAwbL8vf7FPUW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E1C14D));

		public static string GlimpseDiagnostic => (string)TpGnRM8VAwbL8vf7FPUW(U1o6DW8VHVIdNaBhWEc0(-1146510045 ^ -1146324279));

		public __Resources_DiagnosticsSettings()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			a9j3Fy8V7ByApXxoghMG();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object U1o6DW8VHVIdNaBhWEc0(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object TpGnRM8VAwbL8vf7FPUW(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool FUZhpu8V4vigrw4ZVMro()
		{
			return EMgdjd8VwZvGYCv4rNvo == null;
		}

		internal static __Resources_DiagnosticsSettings fMRLAA8V6aSO6iGcNrhf()
		{
			return EMgdjd8VwZvGYCv4rNvo;
		}

		internal static void a9j3Fy8V7ByApXxoghMG()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private List<EventProcessorsInfo> eventProcessorsInfos;

	internal static DiagnosticsSettings dNBaBSEWfi9KpMdCB0JM;

	[BoolSettings(DisplayType = BoolDisplayType.Switch)]
	[DisplayName(typeof(__Resources_DiagnosticsSettings), "Enabled")]
	public bool Enabled
	{
		[CompilerGenerated]
		get
		{
			return _003CEnabled_003Ek__BackingField;
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
					_003CEnabled_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
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

	[BoolSettings(DisplayType = BoolDisplayType.Switch)]
	[DisplayName(typeof(__Resources_DiagnosticsSettings), "ExportReports")]
	public bool ExportReports
	{
		[CompilerGenerated]
		get
		{
			return _003CExportReports_003Ek__BackingField;
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
					_003CExportReports_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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

	[DisplayName(typeof(__Resources_DiagnosticsSettings), "ClearOldReports")]
	public int ClearOldReports
	{
		[CompilerGenerated]
		get
		{
			return _003CClearOldReports_003Ek__BackingField;
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
					_003CClearOldReports_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
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

	[Int32Settings(MinValue = 0, MaxValue = 1440)]
	[DisplayName(typeof(__Resources_DiagnosticsSettings), "ExportReportPeriod")]
	public int ExportReportPeriod
	{
		[CompilerGenerated]
		get
		{
			return _003CExportReportPeriod_003Ek__BackingField;
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
					_003CExportReportPeriod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__Resources_DiagnosticsSettings), "ExportReportStartTime")]
	[DateTimeSettings(ShowDate = false, ShowTime = true)]
	public DateTime ExportReportStartTime
	{
		[CompilerGenerated]
		get
		{
			return _003CExportReportStartTime_003Ek__BackingField;
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
					_003CExportReportStartTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(__Resources_DiagnosticsSettings), "ClearStatisticsPeriod")]
	public ClearStatisticsPeriod ClearStatisticsPeriod
	{
		[CompilerGenerated]
		get
		{
			return _003CClearStatisticsPeriod_003Ek__BackingField;
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
					_003CClearStatisticsPeriod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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

	[DisplayName(typeof(__Resources_DiagnosticsSettings), "LogsEnabled")]
	[BoolSettings(DisplayType = BoolDisplayType.Switch)]
	public bool LogsEnabled
	{
		[CompilerGenerated]
		get
		{
			return _003CLogsEnabled_003Ek__BackingField;
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
					_003CLogsEnabled_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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

	[HiddenInput(DisplayValue = false)]
	public IList<EventProcessorsInfo> EventProcessorsInfos => eventProcessorsInfos;

	public string SerializedEventProcessorsInfos
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (eventProcessorsInfos == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210712801), eventProcessorsInfos.Select((EventProcessorsInfo i) => ClassSerializationHelper.SerializeObjectByXml(i)));
				default:
					return string.Empty;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_006f, IL_007e
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					eventProcessorsInfos = new List<EventProcessorsInfo>();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					if (!qpxgxSEW8aGHshoxNsWk(value))
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 0:
					return;
				case 4:
					return;
				case 2:
					eventProcessorsInfos = ((IEnumerable<string>)VNaFDmEWu6fYpb7q5Gpf(value, new string[1] { (string)yVIEpTEWZO6DLihAiE58(-583745292 ^ -583756760) }, StringSplitOptions.RemoveEmptyEntries)).Select((string i) => ClassSerializationHelper.DeserializeObjectByXml<EventProcessorsInfo>(i)).ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Свойство устарело и больше не используется", true)]
	[DisplayName(typeof(__Resources_DiagnosticsSettings), "LogLevel")]
	public LogLevel LogLevel
	{
		[CompilerGenerated]
		get
		{
			return _003CLogLevel_003Ek__BackingField;
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
					_003CLogLevel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[BoolSettings(DisplayType = BoolDisplayType.Switch)]
	[DisplayName(typeof(__Resources_DiagnosticsSettings), "CountersEnabled")]
	public bool CountersEnabled
	{
		[CompilerGenerated]
		get
		{
			return _003CCountersEnabled_003Ek__BackingField;
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
					_003CCountersEnabled_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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

	[BoolSettings(DisplayType = BoolDisplayType.Switch)]
	[DisplayName(typeof(__Resources_DiagnosticsSettings), "GlimpseDiagnostic")]
	public bool GlimpseDiagnostic
	{
		[CompilerGenerated]
		get
		{
			return _003CGlimpseDiagnostic_003Ek__BackingField;
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
					_003CGlimpseDiagnostic_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DiagnosticsSettings()
	{
		//Discarded unreachable code: IL_001a
		AMdVisEWvbPPHlKMnXLh();
		base._002Ector();
		int num = 3;
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				ExportReportPeriod = 1440;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				Enabled = false;
				num2 = 6;
				goto IL_001f;
			case 5:
				CountersEnabled = false;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 7;
				}
				break;
			case 4:
				ClearOldReports = 0;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			case 1:
				ClearStatisticsPeriod = ClearStatisticsPeriod.Never;
				num2 = 5;
				goto IL_001f;
			case 6:
				ExportReports = false;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 0;
				}
				break;
			case 7:
				{
					eventProcessorsInfos = new List<EventProcessorsInfo>();
					num2 = 4;
					goto IL_001f;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	public void InitEventProcessorsInfos()
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass34_.storages.ForEach(_003C_003Ec__DisplayClass34_._003CInitEventProcessorsInfos_003Eb__0);
				num2 = 4;
				break;
			case 1:
				_003C_003Ec__DisplayClass34_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			default:
				_003C_003Ec__DisplayClass34_.storages = ((ComponentManager)xDPgiCEWIu0LlWOj6Ggh()).GetExtensionPoints<IDiagnosticsEventProcessor>().ToList();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				eventProcessorsInfos.RemoveAll(_003C_003Ec__DisplayClass34_._003CInitEventProcessorsInfos_003Eb__1);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void AMdVisEWvbPPHlKMnXLh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tLvtOTEWQhPbehO6ukRx()
	{
		return dNBaBSEWfi9KpMdCB0JM == null;
	}

	internal static DiagnosticsSettings o0LaUVEWCNBEETJ3k8Y0()
	{
		return dNBaBSEWfi9KpMdCB0JM;
	}

	internal static bool qpxgxSEW8aGHshoxNsWk(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static object yVIEpTEWZO6DLihAiE58(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VNaFDmEWu6fYpb7q5Gpf(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object xDPgiCEWIu0LlWOj6Ggh()
	{
		return ComponentManager.Current;
	}
}
