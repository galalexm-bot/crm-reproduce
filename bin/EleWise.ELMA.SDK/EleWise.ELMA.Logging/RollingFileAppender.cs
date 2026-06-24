using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public class RollingFileAppender : FileAppender
{
	protected enum RollPoint
	{
		InvalidRollPoint = -1,
		TopOfMinute,
		TopOfHour,
		HalfDay,
		TopOfDay,
		TopOfWeek,
		TopOfMonth
	}

	private static readonly Type declaringType;

	private static readonly Type localDateTimeType;

	protected static readonly Type universalDateTimeType;

	protected string m_scheduledFilename;

	private DateTime m_nextCheck;

	protected DateTime m_now;

	private RollPoint m_rollPoint;

	private int m_curSizeRollBackups;

	private RollingMode m_rollingStyle;

	protected bool m_rollDate;

	private bool m_rollSize;

	private string m_baseFileName;

	private static readonly DateTime s_date1970;

	private static RollingFileAppender Ai0EvyhyYJi1upEKrP9d;

	public IDateTime DateTimeStrategy
	{
		[CompilerGenerated]
		get
		{
			return _003CDateTimeStrategy_003Ek__BackingField;
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
					_003CDateTimeStrategy_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DatePattern
	{
		[CompilerGenerated]
		get
		{
			return _003CDatePattern_003Ek__BackingField;
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
					_003CDatePattern_003Ek__BackingField = value;
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

	public int MaxSizeRollBackups
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxSizeRollBackups_003Ek__BackingField;
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
					_003CMaxSizeRollBackups_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int MaxDateRollBackups
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxDateRollBackups_003Ek__BackingField;
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
					_003CMaxDateRollBackups_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long MaxFileSize
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxFileSize_003Ek__BackingField;
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
					_003CMaxFileSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string MaximumFileSize
	{
		get
		{
			int num = 1;
			int num2 = num;
			long maxFileSize = default(long);
			while (true)
			{
				switch (num2)
				{
				case 1:
					maxFileSize = MaxFileSize;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return maxFileSize.ToString((IFormatProvider)AAEJQYhMFdu9swff2Zw9());
				}
			}
		}
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
					MaxFileSize = OptionConverter.ToFileSize(value, MaxFileSize + 1);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int CountDirection
	{
		[CompilerGenerated]
		get
		{
			return _003CCountDirection_003Ek__BackingField;
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
					_003CCountDirection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RollingMode RollingStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return m_rollingStyle;
		}
		set
		{
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected I4, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			int num = 11;
			int num2 = num;
			RollingMode rollingStyle = default(RollingMode);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 5:
					switch ((int)rollingStyle)
					{
					case 2:
						m_rollDate = true;
						num2 = 3;
						break;
					default:
						num2 = 12;
						break;
					case 3:
						m_rollDate = true;
						num2 = 6;
						break;
					case 0:
						m_rollDate = false;
						num2 = 4;
						break;
					case 1:
						m_rollDate = false;
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 1;
						}
						break;
					}
					break;
				case 11:
					m_rollingStyle = value;
					num2 = 10;
					break;
				case 0:
					return;
				case 3:
					m_rollSize = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				case 12:
					return;
				case 8:
					m_rollSize = true;
					num2 = 2;
					break;
				case 4:
					m_rollSize = false;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					return;
				case 10:
					rollingStyle = m_rollingStyle;
					num2 = 5;
					break;
				case 1:
					((FileAppender)this).set_AppendToFile(false);
					num2 = 9;
					break;
				case 7:
					return;
				case 6:
					m_rollSize = true;
					num2 = 7;
					break;
				}
			}
		}
	}

	public bool PreserveLogFileNameExtension
	{
		[CompilerGenerated]
		get
		{
			return _003CPreserveLogFileNameExtension_003Ek__BackingField;
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
					_003CPreserveLogFileNameExtension_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual bool StaticLogFileName
	{
		[CompilerGenerated]
		get
		{
			return _003CStaticLogFileName_003Ek__BackingField;
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
					_003CStaticLogFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
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

	public RollingFileAppender()
	{
		//Discarded unreachable code: IL_005e, IL_0063
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		i3BMnghysbmkjd0Qxytt();
		m_nextCheck = DateTime.MaxValue;
		m_rollingStyle = (RollingMode)3;
		m_rollDate = true;
		m_rollSize = true;
		((FileAppender)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				return;
			case 3:
				CountDirection = -1;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 1;
				}
				break;
			default:
				MaxSizeRollBackups = 0;
				num = 2;
				break;
			case 2:
				MaxDateRollBackups = -1;
				num = 7;
				break;
			case 5:
				DatePattern = (string)FbXo5ShycRZT1KQ5yGPT(-1837662597 ^ -1837828397);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num = 0;
				}
				break;
			case 1:
				PreserveLogFileNameExtension = false;
				num = 4;
				break;
			case 4:
				KbFwdIhyzm1srC5SHZ0J(this, true);
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 5;
				}
				break;
			case 7:
				MaxFileSize = 10485760L;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected override void SetQWForFiles(TextWriter writer)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				PBxr1HhMWfnuXDb8gs6g(this, (object)new CountingQuietTextWriter(writer, (IErrorHandler)em6qRFhMBuS5prl7DqEp(this)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Append(LoggingEvent loggingEvent)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				AdjustFileBeforeAppend();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				d7FqDNhMo377iDUAW7wM(this, loggingEvent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void Append(LoggingEvent[] loggingEvents)
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
				BIG5RvhMbePX3mAqsnn6(this, loggingEvents);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				AdjustFileBeforeAppend();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void AdjustFileBeforeAppend()
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_0121, IL_0130, IL_0155, IL_0164, IL_01b0
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 13:
				return;
			case 3:
				RollOverSize();
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 3;
				}
				break;
			case 12:
				ODVYEGhMEiLS4W47IZdu(this, true);
				num2 = 6;
				break;
			case 10:
				m_now = dateTime;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				if (iN4xR6hMCmQG70K7ZH2Q((object)(CountingQuietTextWriter)aGX3YLhMQrAyJPLTXrHn(this)) < MaxFileSize)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 3;
			default:
				if (!bZwrCQhMGNFDxX5Vcrxg(dateTime, m_nextCheck))
				{
					num2 = 2;
					break;
				}
				goto case 10;
			case 4:
				return;
			case 11:
				return;
			case 14:
				return;
			case 8:
				if (m_rollDate)
				{
					num2 = 7;
					break;
				}
				goto case 2;
			case 1:
				if (PCg0gDhMfq8DNUmQyJTa(this) == null)
				{
					num2 = 4;
					break;
				}
				goto case 9;
			case 7:
				dateTime = EKfIVBhMhyrTRQS9uoHT(DateTimeStrategy);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				m_nextCheck = NextCheckDate(m_now, m_rollPoint);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 12;
				}
				break;
			case 2:
			case 6:
				if (!m_rollSize)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	protected override void OpenFile(string fileName, bool append)
	{
		//Discarded unreachable code: IL_005e, IL_01af, IL_01e2, IL_0202, IL_0221, IL_0230, IL_0278, IL_02b8, IL_02c7, IL_02d3, IL_0357, IL_0376, IL_0385, IL_03b2, IL_03c1
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		RollingFileAppender rollingFileAppender = default(RollingFileAppender);
		bool lockTaken = default(bool);
		IDisposable disposable = default(IDisposable);
		long num4 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 3:
				rollingFileAppender = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				return;
			case 2:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				Monitor.Enter(rollingFileAppender, ref lockTaken);
				int num3 = 8;
				while (true)
				{
					switch (num3)
					{
					case 11:
						return;
					case 15:
						if (FileExists(fileName))
						{
							num3 = 12;
							break;
						}
						goto case 1;
					case 10:
						if (append)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 4;
					case 12:
						KdQYXuhMS1mYsOBcahDy(declaringType, jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(0x57A5235E ^ 0x57A6AB9C), fileName, FbXo5ShycRZT1KQ5yGPT(-787452571 ^ -787225547)));
						num3 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num3 = 4;
						}
						break;
					default:
						disposable = (IDisposable)W1J3T0hM8whc1rWhGYWc(dSmtiYhMvKTH81VK4DE1(this), this);
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num3 = 14;
						}
						break;
					case 2:
						num4 = 0L;
						num3 = 10;
						break;
					case 13:
						if (MaxSizeRollBackups == 0)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num3 = 1;
							}
							break;
						}
						goto case 15;
					case 5:
					case 6:
						ObuQyZhMRHfYPym5lM6o(this, fileName, append);
						num3 = 3;
						break;
					case 9:
						m_scheduledFilename = fileName;
						num3 = 6;
						break;
					case 4:
						if (EM7X8ZhMIxNZCkg5lyZa())
						{
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num3 = 11;
							}
							break;
						}
						goto case 1;
					case 14:
						try
						{
							int num5;
							if (!File.Exists(fileName))
							{
								num5 = 2;
								goto IL_0206;
							}
							goto IL_023b;
							IL_0206:
							switch (num5)
							{
							case 2:
								goto end_IL_01ed;
							case 1:
								goto end_IL_01ed;
							}
							goto IL_023b;
							IL_023b:
							num4 = zBoY0yhMZngOSCZWivec(new FileInfo(fileName));
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
							{
								num5 = 1;
							}
							goto IL_0206;
							end_IL_01ed:;
						}
						finally
						{
							int num6;
							if (disposable == null)
							{
								num6 = 2;
								goto IL_027c;
							}
							goto IL_0292;
							IL_027c:
							switch (num6)
							{
							case 2:
								goto end_IL_0267;
							case 1:
								goto end_IL_0267;
							}
							goto IL_0292;
							IL_0292:
							k9ZxvwhMuwq0oItapG2U(disposable);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num6 = 0;
							}
							goto IL_027c;
							end_IL_0267:;
						}
						goto case 1;
					case 1:
					case 7:
						if (o9tpxShMilIX8xy9TbUW(this))
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num3 = 5;
							}
							break;
						}
						goto case 9;
					case 8:
						fileName = GetNextOutputFileName(fileName);
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num3 = 1;
						}
						break;
					case 3:
						vHnRcvhMqJNRguNlZpQx((object)(CountingQuietTextWriter)aGX3YLhMQrAyJPLTXrHn(this), num4);
						num3 = 11;
						break;
					}
				}
			}
			finally
			{
				int num7;
				if (!lockTaken)
				{
					num7 = 2;
					goto IL_035b;
				}
				goto IL_0390;
				IL_035b:
				switch (num7)
				{
				case 2:
					goto end_IL_0346;
				case 1:
					goto end_IL_0346;
				}
				goto IL_0390;
				IL_0390:
				m6cbtghMK2A3nNHWo0L6(rollingFileAppender);
				num7 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num7 = 1;
				}
				goto IL_035b;
				end_IL_0346:;
			}
		}
	}

	protected string GetNextOutputFileName(string fileName)
	{
		//Discarded unreachable code: IL_00f7, IL_0106
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (m_rollDate)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				fileName = fileName.Trim();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (!o9tpxShMilIX8xy9TbUW(this))
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 4:
				fileName = CombinePath(fileName, (string)jxyUndhMTD8c1NOqeXhI(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289712978), m_curSizeRollBackups));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (CountDirection < 0)
				{
					num2 = 7;
					break;
				}
				goto case 4;
			case 2:
			case 7:
				return fileName;
			default:
				fileName = CombinePath(fileName, m_now.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w()));
				num2 = 3;
				break;
			}
		}
	}

	private void DetermineCurSizeRollBackups()
	{
		//Discarded unreachable code: IL_0136, IL_0195, IL_01cd, IL_01dc
		int num = 9;
		int num2 = num;
		string lastFile = default(string);
		DateTime lastDate = default(DateTime);
		IDisposable disposable = default(IDisposable);
		ArrayList existingFiles = default(ArrayList);
		string text = default(string);
		string baseFile = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				IWZTBkhM2xlOlPISajtr(this, lastFile, lastDate);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				disposable = ((SecurityContext)dSmtiYhMvKTH81VK4DE1(this)).Impersonate((object)this);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				DUAIlfhMO4Zb35bPZHRw(declaringType, string.Concat(FbXo5ShycRZT1KQ5yGPT(0x48A7E34A ^ 0x48A46A3C), m_curSizeRollBackups, FbXo5ShycRZT1KQ5yGPT(0x5DD55050 ^ 0x5DD5A6B8)));
				num2 = 2;
				break;
			default:
				existingFiles = GetExistingFiles(text, out lastFile, out lastDate);
				num2 = 3;
				break;
			case 9:
				m_curSizeRollBackups = 0;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				try
				{
					text = (string)degUSchMksgL83QSefY4(m_baseFileName);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							baseFile = (string)XeHRHKhMnAojGkoyLnd9(text);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					if (disposable != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								k9ZxvwhMuwq0oItapG2U(disposable);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto default;
			case 3:
				InitializeRollBackups(baseFile, existingFiles);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				baseFile = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 5;
				}
				break;
			case 8:
				text = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private string GetWildcardPatternForFile(string baseFileName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (PreserveLogFileNameExtension)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)dypyDwhMPx1WP9r2thtV(baseFileName, FbXo5ShycRZT1KQ5yGPT(-420743386 ^ -420764298));
			default:
				return (string)jM0rpchMVIDgFAvLfkkZ(Path.GetFileNameWithoutExtension(baseFileName), FbXo5ShycRZT1KQ5yGPT(0x8317432 ^ 0x830109C), NvgiKmhMeurNaa1FktWK(baseFileName));
			}
		}
	}

	private ArrayList GetExistingFiles(string baseFilePath, out string lastFile, out DateTime lastDate)
	{
		//Discarded unreachable code: IL_0205, IL_0248, IL_026e, IL_027d, IL_028d, IL_02ad, IL_02bc, IL_0362, IL_0371, IL_0416, IL_0449, IL_04a9, IL_04b8, IL_057f, IL_059e, IL_05ad, IL_05ca
		int num = 7;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		ArrayList arrayList = default(ArrayList);
		string text = default(string);
		DateTime dateTime = default(DateTime);
		int num8 = default(int);
		string text5 = default(string);
		FileSystemInfo[] array = default(FileSystemInfo[]);
		string text4 = default(string);
		string text3 = default(string);
		DateTime result = default(DateTime);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				disposable = ((SecurityContext)dSmtiYhMvKTH81VK4DE1(this)).Impersonate((object)this);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 5;
				}
				break;
			case 7:
				arrayList = new ArrayList();
				num2 = 6;
				break;
			case 3:
				return arrayList;
			case 4:
				LogLog.Debug(declaringType, (string)jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(-2099751081 ^ -2099519871), text, FbXo5ShycRZT1KQ5yGPT(-345420348 ^ -345392340)));
				num2 = 3;
				break;
			case 5:
				try
				{
					string text2 = (string)degUSchMksgL83QSefY4(baseFilePath);
					int num3 = 11;
					while (true)
					{
						IL_00ca:
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 17:
								dateTime = PrevDate(dateTime, m_rollPoint);
								num4 = 21;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num4 = 13;
								}
								continue;
							case 29:
								dateTime = EKfIVBhMhyrTRQS9uoHT(DateTimeStrategy);
								num4 = 23;
								continue;
							case 23:
								num8 = 0;
								num4 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num4 = 12;
								}
								continue;
							case 15:
							case 24:
								YO9KBKhM6B2FnVX4AWW0(arrayList, text5);
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num4 = 18;
								}
								continue;
							case 19:
								if (!Qw8NZEhMNlXZ33Dkgp4w(text))
								{
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
									{
										num4 = 27;
									}
									continue;
								}
								goto case 10;
							case 4:
								break;
							case 30:
								if (array == null)
								{
									num4 = 4;
									continue;
								}
								goto case 25;
							case 3:
							case 13:
								text4 = (string)brSTS0hMpFDraR2D3jFX(text3);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num4 = 1;
								}
								continue;
							case 6:
							case 12:
								if (num8 > MaxDateRollBackups)
								{
									num4 = 13;
									continue;
								}
								goto case 17;
							case 2:
								dateTime = DateTime.MinValue;
								num4 = 3;
								continue;
							case 27:
								break;
							case 21:
								num8++;
								num4 = 6;
								continue;
							case 10:
								text3 = (string)XeHRHKhMnAojGkoyLnd9(text2);
								num4 = 22;
								continue;
							case 20:
								if (Oj2cHPhMt5Yi3xIxZZa1(result, dateTime))
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
									{
										num4 = 14;
									}
									continue;
								}
								goto case 15;
							case 1:
								num5 = 0;
								num4 = 26;
								continue;
							case 8:
								if (Mw7s1khMDnEgvIPr78U6(text5, text4))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 5;
							case 25:
								if (MaxDateRollBackups >= 0)
								{
									num4 = 29;
									continue;
								}
								goto case 2;
							case 18:
								if (umKHfMhMHNcm2vY8M0TT(result, lastDate))
								{
									num4 = 9;
									continue;
								}
								goto case 5;
							case 11:
								text = (string)GS4x8hhM1kooiWGW7QIE(text2);
								num4 = 19;
								continue;
							case 22:
								array = (FileSystemInfo[])c7DR4HhM3tYatLxS6TJv(new DirectoryInfo(text), GetWildcardPatternForFile(text3));
								num4 = 30;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num4 = 22;
								}
								continue;
							case 9:
								lastFile = (string)c1hAKshMAQKUXWJdqrDE(array[num5]);
								num4 = 16;
								continue;
							case 14:
								try
								{
									DOIyAJhMw019YyKaNZIC(array[num5]);
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										default:
											KBSKIahM4brId29E624l(declaringType, dypyDwhMPx1WP9r2thtV(FbXo5ShycRZT1KQ5yGPT(0x4DC2B14D ^ 0x4DC138FB), array[num5].FullName), ex);
											num7 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
											{
												num7 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								goto case 5;
							case 16:
								lastDate = result;
								num4 = 5;
								continue;
							default:
								if (!DateTime.TryParseExact(((string)brSTS0hMpFDraR2D3jFX(text5)).Substring(text4.Length), DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w(), DateTimeStyles.None, out result))
								{
									num4 = 24;
									continue;
								}
								goto case 20;
							case 28:
								goto IL_050a;
							case 5:
								num5++;
								num4 = 31;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num4 = 1;
								}
								continue;
							case 26:
							case 31:
								if (num5 >= array.Length)
								{
									num4 = 7;
									continue;
								}
								goto IL_050a;
							case 7:
								break;
							}
							break;
							IL_050a:
							text5 = (string)KJ2CKghMaFScgRTphWye(array[num5]);
							num3 = 8;
							goto IL_00ca;
						}
						break;
					}
				}
				finally
				{
					int num9;
					if (disposable == null)
					{
						num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num9 = 1;
						}
						goto IL_0583;
					}
					goto IL_05b8;
					IL_05b8:
					k9ZxvwhMuwq0oItapG2U(disposable);
					num9 = 2;
					goto IL_0583;
					IL_0583:
					switch (num9)
					{
					case 1:
						goto end_IL_055e;
					case 2:
						goto end_IL_055e;
					}
					goto IL_05b8;
					end_IL_055e:;
				}
				goto case 4;
			case 6:
				lastFile = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				text = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				lastDate = DateTime.MinValue;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void RollOverIfDateBoundaryCrossing(string lastFile, DateTime lastDate)
	{
		//Discarded unreachable code: IL_00d2, IL_0138
		int num = 9;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					if (nxhRrdhMxQZlCAJ6hGW6(lastDate.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w()), m_now.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w())))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 8:
					if (!m_rollDate)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 3:
					if (lastFile != null)
					{
						num2 = 10;
						continue;
					}
					return;
				case 7:
					return;
				case 6:
					break;
				case 0:
					return;
				case 1:
					return;
				case 9:
					if (!o9tpxShMilIX8xy9TbUW(this))
					{
						return;
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					DUAIlfhMO4Zb35bPZHRw(declaringType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E794F7) + m_scheduledFilename + (string)FbXo5ShycRZT1KQ5yGPT(-2112703338 ^ -2112732546));
					num2 = 2;
					continue;
				case 10:
					LogLog.Debug(declaringType, (string)wxwEVAhM75ehxT53DYO0(new string[5]
					{
						(string)FbXo5ShycRZT1KQ5yGPT(0x2ACE37D ^ 0x2AC159F),
						lastDate.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w()),
						(string)FbXo5ShycRZT1KQ5yGPT(0x31326106 ^ 0x3131EB1C),
						m_now.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w()),
						(string)FbXo5ShycRZT1KQ5yGPT(--1418440330 ^ 0x548B5862)
					}));
					num2 = 4;
					continue;
				case 5:
					DUAIlfhMO4Zb35bPZHRw(declaringType, string.Concat(FbXo5ShycRZT1KQ5yGPT(0x26FFCB59 ^ 0x26FC4105), m_curSizeRollBackups, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77615F)));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					ODVYEGhMEiLS4W47IZdu(this, false);
					num2 = 5;
					continue;
				}
				break;
			}
			m_scheduledFilename = m_baseFileName + lastDate.ToString(DatePattern, DateTimeFormatInfo.InvariantInfo);
			num = 11;
		}
	}

	protected void ExistingInit()
	{
		//Discarded unreachable code: IL_0051, IL_00d9, IL_010b
		int num = 6;
		string nextOutputFileName = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 9:
					DUAIlfhMO4Zb35bPZHRw(declaringType, jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(0x49E27B8A ^ 0x49E1F126), nextOutputFileName, FbXo5ShycRZT1KQ5yGPT(-289714582 ^ -289880928)));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (!FileExists(nextOutputFileName))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 11:
					return;
				case 4:
					RollOverRenameFiles(nextOutputFileName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 8:
					return;
				case 7:
					if (MaxSizeRollBackups != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 5:
					if (!d37f3ohM0u6olBZwYikA(this))
					{
						break;
					}
					goto end_IL_0012;
				case 6:
					DetermineCurSizeRollBackups();
					num2 = 5;
					continue;
				case 3:
					return;
				case 1:
					DUAIlfhMO4Zb35bPZHRw(declaringType, jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(0x3CE17B75 ^ 0x3CE2F1D9), nextOutputFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867856578)));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					break;
				}
				nextOutputFileName = GetNextOutputFileName(m_baseFileName);
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	private void InitializeFromOneFile(string baseFile, string curFileName)
	{
		//Discarded unreachable code: IL_00d5, IL_00e4, IL_00f4, IL_0103, IL_012c, IL_0289, IL_02ee, IL_02fd, IL_0358
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
					try
					{
						int backUpIndex = GetBackUpIndex(curFileName);
						int num3 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 12:
								m_curSizeRollBackups = backUpIndex;
								num3 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num3 = 2;
								}
								break;
							case 9:
								if (CountDirection < 0)
								{
									int num4 = 2;
									num3 = num4;
									break;
								}
								goto case 12;
							case 5:
								m_curSizeRollBackups = backUpIndex;
								num3 = 6;
								break;
							case 2:
							case 7:
								if (backUpIndex <= MaxSizeRollBackups)
								{
									num3 = 8;
									break;
								}
								goto case 1;
							case 4:
								if (-1 == MaxSizeRollBackups)
								{
									num3 = 5;
									break;
								}
								goto case 9;
							case 1:
							case 6:
							case 10:
							case 13:
								DUAIlfhMO4Zb35bPZHRw(declaringType, tmaCyVhMmDuDvSFPWGnl(new object[5]
								{
									z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146476109),
									curFileName,
									FbXo5ShycRZT1KQ5yGPT(-234299632 ^ -234138694),
									m_curSizeRollBackups,
									FbXo5ShycRZT1KQ5yGPT(-521266112 ^ -521213272)
								}));
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num3 = 3;
								}
								break;
							default:
								if (MaxSizeRollBackups == 0)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num3 = 1;
									}
									break;
								}
								goto case 4;
							case 11:
								if (backUpIndex > m_curSizeRollBackups)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num3 = 0;
									}
									break;
								}
								return;
							case 8:
								m_curSizeRollBackups = backUpIndex;
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num3 = 10;
								}
								break;
							case 3:
								return;
							}
						}
					}
					catch (FormatException)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 1:
								LogLog.Debug(declaringType, (string)FbXo5ShycRZT1KQ5yGPT(-1886646897 ^ -1886420627) + curFileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70045211));
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
								{
									num5 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
				case 5:
					if (!Mw7s1khMDnEgvIPr78U6(curFileName, CombinePath(baseFile, DateTimeStrategy.get_Now().ToString(DatePattern, DateTimeFormatInfo.InvariantInfo))))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 9;
				case 0:
					return;
				case 3:
					return;
				case 9:
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (curFileName.StartsWith((string)brSTS0hMpFDraR2D3jFX(baseFile)))
					{
						if (nxhRrdhMxQZlCAJ6hGW6(curFileName, baseFile))
						{
							num2 = 4;
							break;
						}
						if (!m_rollDate)
						{
							num2 = 9;
							break;
						}
						goto case 6;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				case 6:
					if (!StaticLogFileName)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 2:
					LogLog.Debug(declaringType, (string)jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(--1333735954 ^ 0x4F7CBE00), curFileName, FbXo5ShycRZT1KQ5yGPT(-889460160 ^ -889690508)));
					num2 = 3;
					break;
				case 7:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private int GetBackUpIndex(string curFileName)
	{
		//Discarded unreachable code: IL_0049, IL_0058
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		string text = default(string);
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 5:
				num3 = hOHWixhMyA1ldc663ash(text, FbXo5ShycRZT1KQ5yGPT(0x1FFEF86A ^ 0x1FFEE2AE));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
			case 8:
				return result;
			case 3:
				if (!PreserveLogFileNameExtension)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 9;
			case 1:
				result = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				SystemInfo.TryParse(text.Substring(num3 + 1), ref result);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 8;
				}
				break;
			case 4:
				if (num3 <= 0)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 9:
				text = Path.GetFileNameWithoutExtension(text);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				text = curFileName;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private void InitializeRollBackups(string baseFile, ArrayList arrayFiles)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_0098, IL_014a, IL_019f, IL_01ae, IL_01ba, IL_01c9
		int num = 4;
		int num2 = num;
		string baseFile2 = default(string);
		IEnumerator enumerator = default(IEnumerator);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				baseFile2 = (string)K0lgfahMJMuK2hll9LTT(baseFile, YMKWYOhMMO8tscaaI8up());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 4:
				if (arrayFiles == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!nl74RxhMlpl2di5JK5Fl(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num3 = 1;
							}
							goto IL_009c;
						}
						goto IL_010a;
						IL_010a:
						text = (string)L4vkwKhMdqY8q9mKNjqd(enumerator);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num3 = 0;
						}
						goto IL_009c;
						IL_009c:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							default:
								InitializeFromOneFile(baseFile2, (string)K0lgfahMJMuK2hll9LTT(text, YMKWYOhMMO8tscaaI8up()));
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								break;
							case 2:
								goto IL_010a;
							}
							break;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 3;
					while (true)
					{
						switch (num4)
						{
						default:
							k9ZxvwhMuwq0oItapG2U(disposable);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num4 = 0;
							}
							continue;
						case 3:
							if (disposable == null)
							{
								num4 = 2;
								continue;
							}
							goto default;
						case 2:
							break;
						case 1:
							break;
						}
						break;
					}
				}
			default:
				enumerator = (IEnumerator)kAhL11hM9NYMf8BEwBae(arrayFiles);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private RollPoint ComputeCheckPeriod(string datePattern)
	{
		//Discarded unreachable code: IL_0059, IL_019f, IL_01ae
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		DateTime dateTime = default(DateTime);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return (RollPoint)num3;
			case 12:
				num3++;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				dateTime = NextCheckDate(s_date1970, (RollPoint)num3);
				num2 = 9;
				break;
			case 8:
				DUAIlfhMO4Zb35bPZHRw(declaringType, string.Concat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957657218), num3, FbXo5ShycRZT1KQ5yGPT(-477139494 ^ -477306744), text, FbXo5ShycRZT1KQ5yGPT(0x12A5FAC7 ^ 0x12A677AF), text2, FbXo5ShycRZT1KQ5yGPT(--1333735954 ^ 0x4F7FC4FA)));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			case 13:
				num3 = 0;
				num2 = 10;
				break;
			case 9:
				text2 = dateTime.ToString(datePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w());
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				if (text2 == null)
				{
					num2 = 12;
					break;
				}
				goto case 2;
			case 2:
				if (!nxhRrdhMxQZlCAJ6hGW6(text, text2))
				{
					num2 = 7;
					break;
				}
				goto case 12;
			case 1:
				dateTime = s_date1970;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			case 10:
				if (num3 > 5)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 3:
				if (text != null)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 12;
			case 5:
				return RollPoint.InvalidRollPoint;
			default:
				text = dateTime.ToString(datePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w());
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override void ActivateOptions()
	{
		//Discarded unreachable code: IL_00ad, IL_00bc, IL_00f8, IL_015a, IL_0192, IL_01a1, IL_028d, IL_035b, IL_0396, IL_03a5
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		int num = 15;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					disposable = (IDisposable)W1J3T0hM8whc1rWhGYWc(dSmtiYhMvKTH81VK4DE1(this), this);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 17;
					}
					continue;
				case 17:
					try
					{
						l12ZPShMs2RWXbRl08t5(this, he41KfhMUwB5pVQQWxaj(KZlvnhhMLRgYkXDXwTVI(((FileAppender)this).get_File())));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								m_baseFileName = ((FileAppender)this).get_File();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (disposable != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									k9ZxvwhMuwq0oItapG2U(disposable);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 13;
				case 21:
					if (DatePattern != null)
					{
						num = 11;
						break;
					}
					goto case 7;
				case 15:
					if (DateTimeStrategy == null)
					{
						num = 14;
						break;
					}
					goto case 6;
				case 24:
					m_rollPoint = ComputeCheckPeriod(DatePattern);
					num2 = 5;
					continue;
				case 6:
					if (m_rollDate)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 7;
				case 3:
					if (m_scheduledFilename != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 16:
					if (PCg0gDhMfq8DNUmQyJTa(this) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 14:
					DateTimeStrategy = (IDateTime)u2LCGKhMrFErHKRpLN0c(localDateTimeType);
					num2 = 6;
					continue;
				case 13:
					if (!m_rollDate)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 16;
				case 22:
					vZbye6hMcKLVC1qgp73q(this);
					num2 = 10;
					continue;
				case 5:
					if (m_rollPoint == RollPoint.InvalidRollPoint)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					m_nextCheck = NextCheckDate(m_now, m_rollPoint);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 19;
					}
					continue;
				default:
					throw new ArgumentException((string)jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(-488881205 ^ -488649035), DatePattern, FbXo5ShycRZT1KQ5yGPT(0x571EA399 ^ 0x571E5571)));
				case 1:
				case 2:
				case 9:
				case 18:
					ExistingInit();
					num2 = 22;
					continue;
				case 10:
					return;
				case 11:
					m_now = DateTimeStrategy.get_Now();
					num2 = 24;
					continue;
				case 4:
					m_scheduledFilename = CombinePath((string)PCg0gDhMfq8DNUmQyJTa(this), m_now.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w()));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 9;
					}
					continue;
				case 7:
					if (m_rollDate)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 8;
				case 23:
					((FileAppender)this).set_SecurityContext((SecurityContext)VeBOGmhMYSDvG33hOppx(wi3TxphMjSg5VECmmiPI(), this));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 19;
					}
					continue;
				case 8:
				case 19:
					if (dSmtiYhMvKTH81VK4DE1(this) == null)
					{
						num = 23;
						break;
					}
					goto case 20;
				case 12:
					nnbPbthM5kQGvgKUaJE2(em6qRFhMBuS5prl7DqEp(this), jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(-867826612 ^ -867858042), Arn0sxhMg75U5Y0ZxFPe(this), FbXo5ShycRZT1KQ5yGPT(0x5A4C7B29 ^ 0x5A4FF56F)));
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	private string CombinePath(string path1, string path2)
	{
		int num = 1;
		int num2 = num;
		string extension = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (PreserveLogFileNameExtension)
				{
					num2 = 3;
					break;
				}
				goto IL_007d;
			case 1:
				extension = Path.GetExtension(path1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (string)ri1ksDhMzhXVaITvJSe6(GS4x8hhM1kooiWGW7QIE(path1), jM0rpchMVIDgFAvLfkkZ(Path.GetFileNameWithoutExtension(path1), path2, extension));
			case 3:
				{
					if (extension.Length > 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_007d;
				}
				IL_007d:
				return (string)dypyDwhMPx1WP9r2thtV(path1, path2);
			}
		}
	}

	protected virtual void RollOverTime(bool fileIsOpen)
	{
		//Discarded unreachable code: IL_007d, IL_00fd, IL_010c
		int num = 4;
		int num2 = num;
		string path = default(string);
		string fromFile = default(string);
		int num3 = default(int);
		string toFile = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (fileIsOpen)
				{
					num2 = 10;
					break;
				}
				goto case 5;
			case 13:
				G84RwfhJBjyX8CtICkJQ(this);
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 14;
				}
				break;
			case 20:
				RollFile((string)PCg0gDhMfq8DNUmQyJTa(this), m_scheduledFilename);
				num2 = 8;
				break;
			case 15:
				nnbPbthM5kQGvgKUaJE2(em6qRFhMBuS5prl7DqEp(this), FbXo5ShycRZT1KQ5yGPT(-2099751081 ^ -2099521255));
				num2 = 6;
				break;
			case 6:
				return;
			case 14:
				path = m_now.ToString(DatePattern, DateTimeFormatInfo.InvariantInfo);
				num2 = 7;
				break;
			case 21:
				return;
			case 8:
				m_curSizeRollBackups = 0;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 19;
				}
				break;
			case 5:
				ClearOverTime();
				num2 = 21;
				break;
			case 3:
				if (DatePattern != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 15;
			case 19:
				m_scheduledFilename = CombinePath((string)PCg0gDhMfq8DNUmQyJTa(this), m_now.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w()));
				num2 = 2;
				break;
			case 4:
				if (o9tpxShMilIX8xy9TbUW(this))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 7:
				if (nxhRrdhMxQZlCAJ6hGW6(m_scheduledFilename, CombinePath(((FileAppender)this).get_File(), path)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (fileIsOpen)
				{
					num2 = 13;
					break;
				}
				goto case 18;
			case 22:
				fromFile = CombinePath(((FileAppender)this).get_File(), (string)jxyUndhMTD8c1NOqeXhI(FbXo5ShycRZT1KQ5yGPT(0x92F12D5 ^ 0x92F0811), num3));
				num2 = 11;
				break;
			case 11:
				toFile = CombinePath(m_scheduledFilename, (string)jxyUndhMTD8c1NOqeXhI(FbXo5ShycRZT1KQ5yGPT(0x7C1EE318 ^ 0x7C1EF9DC), num3));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 12;
				}
				break;
			default:
				if (num3 > m_curSizeRollBackups)
				{
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 20;
					}
					break;
				}
				goto case 22;
			case 18:
				num3 = 1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				num3++;
				num2 = 16;
				break;
			case 1:
				((IErrorHandler)em6qRFhMBuS5prl7DqEp(this)).Error((string)mTRkCohJFgMRSggrqD6D(FbXo5ShycRZT1KQ5yGPT(0x12441CA4 ^ 0x12479200), m_scheduledFilename, FbXo5ShycRZT1KQ5yGPT(0x571EA399 ^ 0x571DEECF), CombinePath((string)PCg0gDhMfq8DNUmQyJTa(this), path)));
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 17;
				}
				break;
			case 10:
				JjDBjHhJWcE6JZ1xyO4S(this, m_baseFileName, false);
				num2 = 5;
				break;
			case 17:
				return;
			case 12:
				RollFile(fromFile, toFile);
				num2 = 9;
				break;
			}
		}
	}

	private void ClearOverTime()
	{
		//Discarded unreachable code: IL_0074, IL_0083, IL_0093, IL_0220, IL_027a, IL_02ad, IL_0305, IL_0314, IL_0345, IL_037d, IL_038c
		int num = 1;
		int num2 = num;
		int num9 = default(int);
		IDisposable disposable = default(IDisposable);
		DateTime currentDateTime = default(DateTime);
		int num7 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
			case 5:
				if (num9 > MaxDateRollBackups)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 0:
				return;
			case 3:
				disposable = (IDisposable)W1J3T0hM8whc1rWhGYWc(((FileAppender)this).get_SecurityContext(), this);
				num2 = 6;
				break;
			case 10:
				num9++;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				if (MaxDateRollBackups < 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 9:
				currentDateTime = m_now;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				currentDateTime = PrevDate(currentDateTime, m_rollPoint);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				num9 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				try
				{
					string[] array = (string[])SZX6MrhJo7fhp1r4jhGK(GS4x8hhM1kooiWGW7QIE(m_baseFileName), dypyDwhMPx1WP9r2thtV(CombinePath((string)XeHRHKhMnAojGkoyLnd9(m_baseFileName), currentDateTime.ToString(DatePattern, (IFormatProvider)voVQJqhMXF8vx2FTle3w())), FbXo5ShycRZT1KQ5yGPT(-1426094279 ^ -1426136169)), SearchOption.TopDirectoryOnly);
					int num3 = 6;
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 2:
							case 4:
								if (num7 >= array.Length)
								{
									num4 = 5;
									continue;
								}
								break;
							default:
								goto end_IL_01cc;
							case 6:
								num7 = 0;
								num4 = 4;
								continue;
							case 3:
								break;
							case 1:
								try
								{
									sptxmMhJbgtZkIHdqYZE(text);
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											KBSKIahM4brId29E624l(declaringType, dypyDwhMPx1WP9r2thtV(FbXo5ShycRZT1KQ5yGPT(-1710575414 ^ -1710671492), text), ex);
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
											{
												num6 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								goto end_IL_01cc;
							case 5:
								return;
							}
							text = array[num7];
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num4 = 1;
							}
							continue;
							end_IL_01cc:
							break;
						}
						num7++;
						num3 = 2;
					}
				}
				finally
				{
					if (disposable != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								k9ZxvwhMuwq0oItapG2U(disposable);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 7:
				return;
			}
		}
	}

	protected void RollFile(string fromFile, string toFile)
	{
		//Discarded unreachable code: IL_00bf, IL_00fb, IL_0133, IL_016b, IL_01be, IL_024e, IL_025d
		int num = 4;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				DeleteFile(toFile);
				num2 = 2;
				break;
			case 2:
				try
				{
					DUAIlfhMO4Zb35bPZHRw(declaringType, wxwEVAhM75ehxT53DYO0(new string[5]
					{
						(string)FbXo5ShycRZT1KQ5yGPT(0x6A81B9B4 ^ 0x6A82370C),
						fromFile,
						(string)FbXo5ShycRZT1KQ5yGPT(0x20261A4F ^ 0x20259483),
						toFile,
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106466004)
					}));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 1:
							try
							{
								File.Move(fromFile, toFile);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								if (disposable != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											k9ZxvwhMuwq0oItapG2U(disposable);
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
											{
												num5 = 0;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
						default:
							disposable = (IDisposable)W1J3T0hM8whc1rWhGYWc(dSmtiYhMvKTH81VK4DE1(this), this);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 1;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							return;
						}
						zuB3YohJhOt91rpnTdhx(((AppenderSkeleton)this).get_ErrorHandler(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740500728) + fromFile + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538618150) + toFile + (string)FbXo5ShycRZT1KQ5yGPT(-1217523399 ^ -1217468463), ex, (ErrorCode)0);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num6 = 1;
						}
					}
				}
			default:
				tK81W3hJGDbpuNIKb8Iq(declaringType, (string)FbXo5ShycRZT1KQ5yGPT(-576149596 ^ -575985480) + fromFile + (string)FbXo5ShycRZT1KQ5yGPT(-218496594 ^ -218525854) + toFile + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420972444));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (FileExists(fromFile))
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	protected bool FileExists(string path)
	{
		//Discarded unreachable code: IL_0073, IL_00ab, IL_00e3, IL_00f2
		int num = 1;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				disposable = ((FileAppender)this).get_SecurityContext().Impersonate((object)this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = uXWOTehJEVBQAmq3Zl7a(path);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (disposable != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							k9ZxvwhMuwq0oItapG2U(disposable);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	protected void DeleteFile(string fileName)
	{
		//Discarded unreachable code: IL_00cf, IL_0155, IL_01a0, IL_01af, IL_01dc, IL_01eb, IL_0217, IL_023e, IL_0302, IL_0355, IL_0392, IL_03ca, IL_03e9, IL_0415, IL_0462, IL_04f6
		int num = 1;
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					break;
				case 1:
					if (FileExists(fileName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					try
					{
						IDisposable disposable = ((FileAppender)this).get_SecurityContext().Impersonate((object)this);
						int num7 = 2;
						while (true)
						{
							switch (num7)
							{
							default:
								return;
							case 1:
								break;
							case 2:
								try
								{
									sptxmMhJbgtZkIHdqYZE(text);
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num8 = 0;
									}
									switch (num8)
									{
									case 0:
										break;
									}
								}
								finally
								{
									int num10;
									if (disposable == null)
									{
										int num9 = 2;
										num10 = num9;
										goto IL_0185;
									}
									goto IL_01ba;
									IL_0185:
									switch (num10)
									{
									default:
										goto end_IL_016c;
									case 2:
										goto end_IL_016c;
									case 1:
										break;
									case 0:
										goto end_IL_016c;
									}
									goto IL_01ba;
									IL_01ba:
									k9ZxvwhMuwq0oItapG2U(disposable);
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
									{
										num10 = 0;
									}
									goto IL_0185;
									end_IL_016c:;
								}
								break;
							case 0:
								return;
							}
							LogLog.Debug(declaringType, (string)jM0rpchMVIDgFAvLfkkZ(FbXo5ShycRZT1KQ5yGPT(0xE1229CF ^ 0xE11A63F), fileName, FbXo5ShycRZT1KQ5yGPT(-787452571 ^ -787440755)));
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
							{
								num7 = 0;
							}
						}
					}
					catch (Exception ex2)
					{
						int num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num11 = 1;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								return;
							case 0:
								return;
							case 4:
								eGOhfchJCkhGjaAx1hAx(declaringType, (string)FbXo5ShycRZT1KQ5yGPT(-475857671 ^ -475960149) + text + (string)FbXo5ShycRZT1KQ5yGPT(-3333094 ^ -3288334), ex2);
								num11 = 2;
								break;
							case 1:
								if (drDTnghJvxgnCTPIMulO(text, fileName))
								{
									num11 = 3;
									break;
								}
								goto case 4;
							case 3:
								zuB3YohJhOt91rpnTdhx(em6qRFhMBuS5prl7DqEp(this), (string)FbXo5ShycRZT1KQ5yGPT(-521266112 ^ -521302960) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECEA5E2), ex2, (ErrorCode)0);
								num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
								{
									num11 = 0;
								}
								break;
							case 2:
								return;
							}
						}
					}
				case 5:
					return;
				case 3:
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					try
					{
						IDisposable disposable = (IDisposable)W1J3T0hM8whc1rWhGYWc(((FileAppender)this).get_SecurityContext(), this);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								try
								{
									DaFoCNhJQ9H8Opvn6VR4(fileName, text2);
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
								finally
								{
									int num5;
									if (disposable == null)
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
										{
											num5 = 0;
										}
										goto IL_03ce;
									}
									goto IL_03f3;
									IL_03f3:
									k9ZxvwhMuwq0oItapG2U(disposable);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num5 = 1;
									}
									goto IL_03ce;
									IL_03ce:
									switch (num5)
									{
									default:
										goto end_IL_03a9;
									case 0:
										goto end_IL_03a9;
									case 2:
										break;
									case 1:
										goto end_IL_03a9;
									}
									goto IL_03f3;
									end_IL_03a9:;
								}
								break;
							case 2:
								break;
							case 1:
								goto end_IL_0359;
							}
							text = text2;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num3 = 1;
							}
							continue;
							end_IL_0359:
							break;
						}
					}
					catch (Exception ex)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								eGOhfchJCkhGjaAx1hAx(declaringType, wxwEVAhM75ehxT53DYO0(new string[5]
								{
									(string)FbXo5ShycRZT1KQ5yGPT(-978351861 ^ -978581859),
									fileName,
									(string)FbXo5ShycRZT1KQ5yGPT(0xD3DEF7E ^ 0xD3E61B2),
									text2,
									(string)FbXo5ShycRZT1KQ5yGPT(-867826612 ^ -867765596)
								}), ex);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 3;
				default:
					text = fileName;
					num2 = 6;
					continue;
				}
				break;
			}
			text2 = (string)tmaCyVhMmDuDvSFPWGnl(new object[4]
			{
				fileName,
				FbXo5ShycRZT1KQ5yGPT(0x1A33FE36 ^ 0x1A33E4F2),
				mrfUNmhJfbKmwoEGZnts(),
				FbXo5ShycRZT1KQ5yGPT(-2106517564 ^ -2106419022)
			});
			num = 4;
		}
	}

	protected void RollOverSize()
	{
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					JjDBjHhJWcE6JZ1xyO4S(this, m_baseFileName, false);
					num2 = 6;
					continue;
				case 6:
					return;
				case 3:
					G84RwfhJBjyX8CtICkJQ(this);
					num2 = 2;
					continue;
				case 4:
					RollOverRenameFiles((string)PCg0gDhMfq8DNUmQyJTa(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					DUAIlfhMO4Zb35bPZHRw(declaringType, UtIS75hJ8VsKtEpjtNXn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477299464), CountDirection, FbXo5ShycRZT1KQ5yGPT(0x1FFEF86A ^ 0x1FFE0E82)));
					num2 = 4;
					continue;
				case 7:
					DUAIlfhMO4Zb35bPZHRw(declaringType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334965051) + MaxSizeRollBackups + FbXo5ShycRZT1KQ5yGPT(0x637E299B ^ 0x637EDF73));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				default:
					DUAIlfhMO4Zb35bPZHRw(declaringType, UtIS75hJ8VsKtEpjtNXn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426319409), m_curSizeRollBackups, FbXo5ShycRZT1KQ5yGPT(0x7247028A ^ 0x7247F462)));
					num2 = 5;
					continue;
				}
				break;
			}
			DUAIlfhMO4Zb35bPZHRw(declaringType, UtIS75hJ8VsKtEpjtNXn(FbXo5ShycRZT1KQ5yGPT(0x5F3078B6 ^ 0x5F33E828), iN4xR6hMCmQG70K7ZH2Q((object)(CountingQuietTextWriter)aGX3YLhMQrAyJPLTXrHn(this)), FbXo5ShycRZT1KQ5yGPT(-1767720453 ^ -1767747821)));
			num = 7;
		}
	}

	protected void RollOverRenameFiles(string baseFileName)
	{
		//Discarded unreachable code: IL_0242, IL_02f8, IL_03ba, IL_0422, IL_045b, IL_046a
		int num = 10;
		string text = default(string);
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
				case 25:
					text = baseFileName;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (!StaticLogFileName)
					{
						num2 = 17;
						continue;
					}
					goto case 11;
				case 27:
					num5--;
					num2 = 15;
					continue;
				case 18:
					num3 = hOHWixhMyA1ldc663ash(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBAFFA));
					num2 = 26;
					continue;
				case 24:
					num4 = m_curSizeRollBackups - MaxSizeRollBackups;
					num2 = 6;
					continue;
				case 5:
					if (m_curSizeRollBackups == MaxSizeRollBackups)
					{
						num2 = 22;
						continue;
					}
					goto case 30;
				case 22:
					DeleteFile(CombinePath(baseFileName, string.Concat(FbXo5ShycRZT1KQ5yGPT(-1852837372 ^ -1852839744), MaxSizeRollBackups)));
					num2 = 23;
					continue;
				case 30:
					num5 = m_curSizeRollBackups;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					break;
				case 29:
					if (o9tpxShMilIX8xy9TbUW(this))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 3:
					if (MaxSizeRollBackups > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 14;
				case 4:
					RollFile(baseFileName, CombinePath(baseFileName, string.Concat(FbXo5ShycRZT1KQ5yGPT(0x12441CA4 ^ 0x12440660), m_curSizeRollBackups)));
					num2 = 8;
					continue;
				case 7:
					RollFile(baseFileName, CombinePath(baseFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978577331)));
					num2 = 12;
					continue;
				case 14:
				case 21:
					m_curSizeRollBackups++;
					num2 = 29;
					continue;
				default:
					m_curSizeRollBackups++;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
				case 19:
					if (num5 < 1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 9:
					if (CountDirection >= 0)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 5;
				case 13:
				case 20:
					DeleteFile(CombinePath(text, (string)jxyUndhMTD8c1NOqeXhI(FbXo5ShycRZT1KQ5yGPT(-541731959 ^ -541734579), num4)));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 14;
					}
					continue;
				case 26:
					if (num3 >= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 13;
				case 23:
					m_curSizeRollBackups--;
					num2 = 30;
					continue;
				case 2:
					if (o9tpxShMilIX8xy9TbUW(this))
					{
						num2 = 13;
						continue;
					}
					goto case 18;
				case 12:
					return;
				case 16:
					if (m_curSizeRollBackups < MaxSizeRollBackups)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 3;
				case 8:
					return;
				case 11:
					num4++;
					num2 = 25;
					continue;
				case 10:
					if (MaxSizeRollBackups == 0)
					{
						return;
					}
					num2 = 9;
					continue;
				case 1:
					text = (string)loZkyKhJZ2rWIYXqeZWC(text, 0, num3);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 20;
					}
					continue;
				}
				break;
			}
			RollFile(CombinePath(baseFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31327BC2) + num5), CombinePath(baseFileName, string.Concat(FbXo5ShycRZT1KQ5yGPT(0x12A5FAC7 ^ 0x12A5E003), num5 + 1)));
			num = 27;
		}
	}

	protected DateTime NextCheckDate(DateTime currentDateTime, RollPoint rollPoint)
	{
		//Discarded unreachable code: IL_0119, IL_0128, IL_0138, IL_014b, IL_01cf, IL_027e, IL_042e, IL_043d, IL_04fb
		int num = 13;
		DateTime result = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					result = result.AddHours(-result.Hour);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 9;
					}
					continue;
				case 20:
					result = result.AddDays(1.0);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 7;
					}
					continue;
				case 13:
					result = currentDateTime;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 31:
					if (result.Hour < 12)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 2;
				case 33:
					result = result.AddMonths(1);
					num2 = 29;
					continue;
				case 10:
					result = result.AddSeconds(-result.Second);
					num2 = 38;
					continue;
				case 14:
					result = result.AddHours(1.0);
					num2 = 5;
					continue;
				case 9:
					result = result.AddDays(1.0);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 13;
					}
					continue;
				case 15:
					result = result.AddHours(-result.Hour);
					num2 = 8;
					continue;
				case 17:
					result = result.AddMilliseconds(-result.Millisecond);
					num = 34;
					break;
				case 3:
					result = result.AddHours(-result.Hour);
					num2 = 20;
					continue;
				case 21:
					result = result.AddDays(1 - result.Day);
					num2 = 33;
					continue;
				case 6:
					goto IL_02a5;
				default:
					result = result.AddSeconds(-result.Second);
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 9;
					}
					continue;
				case 38:
					result = result.AddMinutes(-result.Minute);
					num2 = 23;
					continue;
				case 1:
				case 5:
				case 18:
				case 19:
				case 22:
				case 29:
				case 36:
				case 39:
					return result;
				case 16:
					goto IL_031c;
				case 27:
					result = result.AddMinutes(-result.Minute);
					num = 31;
					break;
				case 34:
					result = result.AddSeconds(-result.Second);
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 25;
					}
					continue;
				case 26:
					goto IL_0394;
				case 8:
					result = result.AddDays((double)(7 - result.DayOfWeek));
					num = 19;
					break;
				case 23:
					result = result.AddHours(-result.Hour);
					num = 21;
					break;
				case 32:
					goto IL_03f1;
				case 7:
					result = result.AddSeconds(-result.Second);
					num2 = 37;
					continue;
				case 24:
					goto IL_0448;
				case 4:
					result = result.AddHours(12 - result.Hour);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					switch (rollPoint)
					{
					case RollPoint.TopOfMinute:
						break;
					case RollPoint.TopOfWeek:
						goto IL_02a5;
					case RollPoint.HalfDay:
						goto IL_031c;
					case RollPoint.TopOfHour:
						goto IL_0394;
					case RollPoint.TopOfDay:
						goto IL_03f1;
					case RollPoint.TopOfMonth:
						goto IL_0448;
					default:
						goto IL_04b0;
					}
					goto case 17;
				case 11:
					result = result.AddSeconds(-result.Second);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 27;
					}
					continue;
				case 35:
					result = result.AddMinutes(-result.Minute);
					num2 = 14;
					continue;
				case 25:
					result = result.AddMinutes(1.0);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 36;
					}
					continue;
				case 28:
					result = result.AddSeconds(-result.Second);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 35;
					}
					continue;
				case 30:
					result = result.AddMinutes(-result.Minute);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 1;
					}
					continue;
				case 37:
					{
						result = result.AddMinutes(-result.Minute);
						num2 = 3;
						continue;
					}
					IL_04b0:
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 3;
					}
					continue;
					IL_0448:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 10;
					continue;
					IL_03f1:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 7;
					continue;
					IL_0394:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 28;
					continue;
					IL_031c:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 7;
					}
					continue;
					IL_02a5:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private DateTime PrevDate(DateTime currentDateTime, RollPoint rollPoint)
	{
		//Discarded unreachable code: IL_00c1, IL_00d0, IL_013b, IL_0381, IL_044c, IL_0480, IL_048f, IL_054b, IL_055a, IL_056a, IL_0579
		int num = 23;
		DateTime result = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					result = result.AddSeconds(-result.Second);
					num2 = 9;
					continue;
				case 35:
					result = result.AddSeconds(-result.Second);
					num = 5;
					break;
				case 21:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 8;
					continue;
				case 2:
				case 3:
				case 7:
				case 13:
				case 18:
				case 29:
				case 34:
				case 39:
					return result;
				case 28:
					result = result.AddMinutes(-result.Minute);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 4;
					}
					continue;
				case 17:
					result = result.AddMonths(-1);
					num2 = 3;
					continue;
				case 8:
					result = result.AddSeconds(-result.Second);
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 32;
					}
					continue;
				case 12:
					result = result.AddMinutes(-result.Minute);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					continue;
				case 38:
					goto IL_01dd;
				case 20:
					goto IL_0209;
				case 26:
					result = result.AddDays(-1.0);
					num = 13;
					break;
				case 37:
					result = result.AddSeconds(-result.Second);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 12;
					}
					continue;
				case 16:
					result = result.AddHours(-result.Hour);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 39;
					}
					continue;
				case 15:
					result = result.AddSeconds(-result.Second);
					num2 = 28;
					continue;
				case 27:
					result = result.AddDays(1 - result.Day);
					num = 17;
					break;
				case 24:
					result = result.AddMinutes(-result.Minute);
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 6;
					}
					continue;
				case 10:
					goto IL_0316;
				case 25:
					result = result.AddHours(-12 - result.Hour);
					num2 = 7;
					continue;
				case 6:
					result = result.AddSeconds(-result.Second);
					num2 = 24;
					continue;
				default:
					result = result.AddHours(-result.Hour);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 19;
					}
					continue;
				case 9:
					result = result.AddMinutes(-result.Minute);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					result = result.AddMinutes(-result.Minute);
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 12;
					}
					continue;
				case 1:
					goto IL_040f;
				case 31:
					goto IL_042b;
				case 23:
					result = currentDateTime;
					num2 = 22;
					continue;
				case 30:
					if (result.Hour < 12)
					{
						num2 = 25;
						continue;
					}
					goto case 16;
				case 33:
					result = result.AddMinutes(-1.0);
					num2 = 2;
					continue;
				case 14:
					result = result.AddDays(-7.0);
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 29;
					}
					continue;
				case 19:
					result = result.AddDays(0 - result.DayOfWeek);
					num2 = 14;
					continue;
				case 36:
					result = result.AddHours(-result.Hour);
					num2 = 26;
					continue;
				case 32:
					result = result.AddHours(-1.0);
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 34;
					}
					continue;
				case 4:
					result = result.AddHours(-result.Hour);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 16;
					}
					continue;
				case 22:
					{
						switch (rollPoint)
						{
						case RollPoint.TopOfMinute:
							break;
						case RollPoint.TopOfWeek:
							goto IL_01dd;
						case RollPoint.HalfDay:
							goto IL_0209;
						case RollPoint.TopOfMonth:
							goto IL_0316;
						case RollPoint.TopOfDay:
							goto IL_040f;
						case RollPoint.TopOfHour:
							goto IL_042b;
						default:
							goto IL_05ce;
						}
						goto case 21;
					}
					IL_05ce:
					num2 = 18;
					continue;
					IL_0209:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 27;
					}
					continue;
					IL_01dd:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 25;
					}
					continue;
					IL_042b:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 6;
					continue;
					IL_040f:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 15;
					continue;
					IL_0316:
					result = result.AddMilliseconds(-result.Millisecond);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	static RollingFileAppender()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				universalDateTimeType = tGPG0jhJI0fd1ejtLMIB(FbXo5ShycRZT1KQ5yGPT(0x63ABA4E8 ^ 0x63A83520));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				s_date1970 = new DateTime(1970, 1, 1);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				declaringType = aGXWfQhJu10ItlyaBIli(typeof(RollingFileAppender).TypeHandle);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				localDateTimeType = tGPG0jhJI0fd1ejtLMIB(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F6F7F8));
				num2 = 5;
				break;
			case 1:
				return;
			case 3:
				i3BMnghysbmkjd0Qxytt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void i3BMnghysbmkjd0Qxytt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object FbXo5ShycRZT1KQ5yGPT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void KbFwdIhyzm1srC5SHZ0J(object P_0, bool value)
	{
		((RollingFileAppender)P_0).StaticLogFileName = value;
	}

	internal static bool dENuathyLFDqJZraBkD3()
	{
		return Ai0EvyhyYJi1upEKrP9d == null;
	}

	internal static RollingFileAppender GZcxqRhyU8LYqI6YE43o()
	{
		return Ai0EvyhyYJi1upEKrP9d;
	}

	internal static object AAEJQYhMFdu9swff2Zw9()
	{
		return NumberFormatInfo.InvariantInfo;
	}

	internal static object em6qRFhMBuS5prl7DqEp(object P_0)
	{
		return ((AppenderSkeleton)P_0).get_ErrorHandler();
	}

	internal static void PBxr1HhMWfnuXDb8gs6g(object P_0, object P_1)
	{
		((TextWriterAppender)P_0).set_QuietWriter((QuietTextWriter)P_1);
	}

	internal static void d7FqDNhMo377iDUAW7wM(object P_0, object P_1)
	{
		((FileAppender)P_0).Append((LoggingEvent)P_1);
	}

	internal static void BIG5RvhMbePX3mAqsnn6(object P_0, object P_1)
	{
		((FileAppender)P_0).Append((LoggingEvent[])P_1);
	}

	internal static DateTime EKfIVBhMhyrTRQS9uoHT(object P_0)
	{
		return ((IDateTime)P_0).get_Now();
	}

	internal static bool bZwrCQhMGNFDxX5Vcrxg(DateTime P_0, DateTime P_1)
	{
		return P_0 >= P_1;
	}

	internal static void ODVYEGhMEiLS4W47IZdu(object P_0, bool fileIsOpen)
	{
		((RollingFileAppender)P_0).RollOverTime(fileIsOpen);
	}

	internal static object PCg0gDhMfq8DNUmQyJTa(object P_0)
	{
		return ((FileAppender)P_0).get_File();
	}

	internal static object aGX3YLhMQrAyJPLTXrHn(object P_0)
	{
		return ((TextWriterAppender)P_0).get_QuietWriter();
	}

	internal static long iN4xR6hMCmQG70K7ZH2Q(object P_0)
	{
		return ((CountingQuietTextWriter)P_0).get_Count();
	}

	internal static object dSmtiYhMvKTH81VK4DE1(object P_0)
	{
		return ((FileAppender)P_0).get_SecurityContext();
	}

	internal static object W1J3T0hM8whc1rWhGYWc(object P_0, object P_1)
	{
		return ((SecurityContext)P_0).Impersonate(P_1);
	}

	internal static long zBoY0yhMZngOSCZWivec(object P_0)
	{
		return ((FileInfo)P_0).Length;
	}

	internal static void k9ZxvwhMuwq0oItapG2U(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool EM7X8ZhMIxNZCkg5lyZa()
	{
		return LogLog.get_IsErrorEnabled();
	}

	internal static object jM0rpchMVIDgFAvLfkkZ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void KdQYXuhMS1mYsOBcahDy(Type P_0, object P_1)
	{
		LogLog.Error(P_0, (string)P_1);
	}

	internal static bool o9tpxShMilIX8xy9TbUW(object P_0)
	{
		return ((RollingFileAppender)P_0).StaticLogFileName;
	}

	internal static void ObuQyZhMRHfYPym5lM6o(object P_0, object P_1, bool P_2)
	{
		((FileAppender)P_0).OpenFile((string)P_1, P_2);
	}

	internal static void vHnRcvhMqJNRguNlZpQx(object P_0, long P_1)
	{
		((CountingQuietTextWriter)P_0).set_Count(P_1);
	}

	internal static void m6cbtghMK2A3nNHWo0L6(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object voVQJqhMXF8vx2FTle3w()
	{
		return DateTimeFormatInfo.InvariantInfo;
	}

	internal static object jxyUndhMTD8c1NOqeXhI(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object degUSchMksgL83QSefY4(object P_0)
	{
		return Path.GetFullPath((string)P_0);
	}

	internal static object XeHRHKhMnAojGkoyLnd9(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static void DUAIlfhMO4Zb35bPZHRw(Type P_0, object P_1)
	{
		LogLog.Debug(P_0, (string)P_1);
	}

	internal static void IWZTBkhM2xlOlPISajtr(object P_0, object P_1, DateTime lastDate)
	{
		((RollingFileAppender)P_0).RollOverIfDateBoundaryCrossing((string)P_1, lastDate);
	}

	internal static object NvgiKmhMeurNaa1FktWK(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static object dypyDwhMPx1WP9r2thtV(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object GS4x8hhM1kooiWGW7QIE(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static bool Qw8NZEhMNlXZ33Dkgp4w(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object c7DR4HhM3tYatLxS6TJv(object P_0, object P_1)
	{
		return ((DirectoryInfo)P_0).GetFileSystemInfos((string)P_1);
	}

	internal static object brSTS0hMpFDraR2D3jFX(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object KJ2CKghMaFScgRTphWye(object P_0)
	{
		return ((FileSystemInfo)P_0).Name;
	}

	internal static bool Mw7s1khMDnEgvIPr78U6(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool Oj2cHPhMt5Yi3xIxZZa1(DateTime P_0, DateTime P_1)
	{
		return P_0 <= P_1;
	}

	internal static void DOIyAJhMw019YyKaNZIC(object P_0)
	{
		((FileSystemInfo)P_0).Delete();
	}

	internal static void KBSKIahM4brId29E624l(Type P_0, object P_1, object P_2)
	{
		LogLog.Error(P_0, (string)P_1, (Exception)P_2);
	}

	internal static int YO9KBKhM6B2FnVX4AWW0(object P_0, object P_1)
	{
		return ((ArrayList)P_0).Add(P_1);
	}

	internal static bool umKHfMhMHNcm2vY8M0TT(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static object c1hAKshMAQKUXWJdqrDE(object P_0)
	{
		return ((FileSystemInfo)P_0).FullName;
	}

	internal static object wxwEVAhM75ehxT53DYO0(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool nxhRrdhMxQZlCAJ6hGW6(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static bool d37f3ohM0u6olBZwYikA(object P_0)
	{
		return ((FileAppender)P_0).get_AppendToFile();
	}

	internal static object tmaCyVhMmDuDvSFPWGnl(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static int hOHWixhMyA1ldc663ash(object P_0, object P_1)
	{
		return ((string)P_0).LastIndexOf((string)P_1);
	}

	internal static object YMKWYOhMMO8tscaaI8up()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object K0lgfahMJMuK2hll9LTT(object P_0, object P_1)
	{
		return ((string)P_0).ToLower((CultureInfo)P_1);
	}

	internal static object kAhL11hM9NYMf8BEwBae(object P_0)
	{
		return ((ArrayList)P_0).GetEnumerator();
	}

	internal static object L4vkwKhMdqY8q9mKNjqd(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool nl74RxhMlpl2di5JK5Fl(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object u2LCGKhMrFErHKRpLN0c(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object Arn0sxhMg75U5Y0ZxFPe(object P_0)
	{
		return ((AppenderSkeleton)P_0).get_Name();
	}

	internal static void nnbPbthM5kQGvgKUaJE2(object P_0, object P_1)
	{
		((IErrorHandler)P_0).Error((string)P_1);
	}

	internal static object wi3TxphMjSg5VECmmiPI()
	{
		return SecurityContextProvider.get_DefaultProvider();
	}

	internal static object VeBOGmhMYSDvG33hOppx(object P_0, object P_1)
	{
		return ((SecurityContextProvider)P_0).CreateSecurityContext(P_1);
	}

	internal static object KZlvnhhMLRgYkXDXwTVI(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object he41KfhMUwB5pVQQWxaj(object P_0)
	{
		return FileAppender.ConvertToFullPath((string)P_0);
	}

	internal static void l12ZPShMs2RWXbRl08t5(object P_0, object P_1)
	{
		((FileAppender)P_0).set_File((string)P_1);
	}

	internal static void vZbye6hMcKLVC1qgp73q(object P_0)
	{
		((FileAppender)P_0).ActivateOptions();
	}

	internal static object ri1ksDhMzhXVaITvJSe6(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object mTRkCohJFgMRSggrqD6D(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static void G84RwfhJBjyX8CtICkJQ(object P_0)
	{
		((FileAppender)P_0).CloseFile();
	}

	internal static void JjDBjHhJWcE6JZ1xyO4S(object P_0, object P_1, bool P_2)
	{
		((FileAppender)P_0).SafeOpenFile((string)P_1, P_2);
	}

	internal static object SZX6MrhJo7fhp1r4jhGK(object P_0, object P_1, SearchOption P_2)
	{
		return Directory.GetFiles((string)P_0, (string)P_1, P_2);
	}

	internal static void sptxmMhJbgtZkIHdqYZE(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static void zuB3YohJhOt91rpnTdhx(object P_0, object P_1, object P_2, ErrorCode P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((IErrorHandler)P_0).Error((string)P_1, (Exception)P_2, P_3);
	}

	internal static void tK81W3hJGDbpuNIKb8Iq(Type P_0, object P_1)
	{
		LogLog.Warn(P_0, (string)P_1);
	}

	internal static bool uXWOTehJEVBQAmq3Zl7a(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static int mrfUNmhJfbKmwoEGZnts()
	{
		return Environment.TickCount;
	}

	internal static void DaFoCNhJQ9H8Opvn6VR4(object P_0, object P_1)
	{
		File.Move((string)P_0, (string)P_1);
	}

	internal static void eGOhfchJCkhGjaAx1hAx(Type P_0, object P_1, object P_2)
	{
		LogLog.Debug(P_0, (string)P_1, (Exception)P_2);
	}

	internal static bool drDTnghJvxgnCTPIMulO(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object UtIS75hJ8VsKtEpjtNXn(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object loZkyKhJZ2rWIYXqeZWC(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static Type aGXWfQhJu10ItlyaBIli(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type tGPG0jhJI0fd1ejtLMIB(object P_0)
	{
		return Type.GetType((string)P_0);
	}
}
