using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime;

[Serializable]
public class StartInformation : IStartInformation, IDisposable
{
	private class ChildStartInformation : IStartInformation, IDisposable
	{
		private object parent;

		private object startMessage;

		private double startPercent;

		private double completePercent;

		private double deltaPercent;

		private double percent;

		private bool stopped;

		private object level;

		private static object AVRNM0Q1XT7PmohkJodk;

		public double Percent
		{
			get
			{
				return percent;
			}
			set
			{
				//Discarded unreachable code: IL_007e, IL_00f5
				int num = 3;
				int num2 = num;
				double num4 = default(double);
				while (true)
				{
					double num3;
					switch (num2)
					{
					case 3:
						if (!(value < 0.0))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						num3 = 0.0;
						break;
					case 1:
						return;
					case 5:
						percent = num4;
						num2 = 4;
						continue;
					case 4:
						U9Bu9hQ1P0XQtPrlg6sP(parent, startPercent + percent * deltaPercent / 100.0);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						if (value > 100.0)
						{
							num3 = 100.0;
							break;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						num3 = value;
						break;
					}
					num4 = num3;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 4;
					}
				}
			}
		}

		public string Message
		{
			get
			{
				return ((IStartInformation)parent).Message;
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
						N7ROehQ110NaBefbJGQO(parent, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ChildStartInformation(double completePercent, string message)
		{
			//Discarded unreachable code: IL_002a, IL_010e
			nWURqNQ1noFfwBhfjVZ0();
			base._002Ector();
			int num = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 6:
				{
					startMessage = KsNPTeQ12Vq7e8ZB5q7i(parent);
					int num2 = 12;
					num = num2;
					break;
				}
				case 3:
					level = pUJiETQ1eMmFyD6bhXUo(level, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76EA600));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num = 0;
					}
					break;
				case 12:
					deltaPercent = completePercent - startPercent;
					num = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num = 13;
					}
					break;
				case 1:
					Message = message;
					num = 2;
					break;
				case 11:
					startPercent = SNAMLCQ1OMIRgVNj43uJ(parent);
					num = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num = 4;
					}
					break;
				case 13:
					if (level == null)
					{
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num = 16;
						}
						break;
					}
					goto case 3;
				case 2:
					current = this;
					num = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num = 10;
					}
					break;
				case 7:
					Log(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AC4B9C), (string)level);
					num = 5;
					break;
				default:
					stopped = false;
					num = 7;
					break;
				case 9:
					deltaPercent = 0.0;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num = 1;
					}
					break;
				case 5:
					return;
				case 16:
					level = "";
					num = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num = 4;
					}
					break;
				case 15:
					if (deltaPercent < 0.0)
					{
						num = 9;
						break;
					}
					goto case 1;
				case 10:
					this.completePercent = completePercent;
					num = 6;
					break;
				case 4:
					parent = current;
					num = 11;
					break;
				case 14:
					level = (parent as ChildStartInformation)?.level;
					num = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num = 3;
					}
					break;
				}
			}
		}

		public void SetInfo(double percent, string message)
		{
			//Discarded unreachable code: IL_00aa
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 4:
					if (percent > Percent)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 7;
				case 6:
					Percent = percent;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 7;
					}
					break;
				case 7:
					Message = message;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					Log((string)MSQpqPQ13Ll3PN1dGrQk(0x1C9495B4 ^ 0x1C951AC0), (string)level);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (Percent == percent)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 2:
					return;
				default:
					if (uYG2xqQ1NRdFINuwebpV(Message, message))
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public void StopOperation()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						break;
					case 2:
						stopped = true;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						d9Ooi0Q1pJeZaXIfU9FB(parent);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
				Log((string)MSQpqPQ13Ll3PN1dGrQk(-576149596 ^ -576118538), (string)level);
				num = 3;
			}
		}

		public void Dispose()
		{
			//Discarded unreachable code: IL_00e8, IL_00f7
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 2:
					current = (IStartInformation)parent;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					U9Bu9hQ1P0XQtPrlg6sP(parent, completePercent);
					num2 = 6;
					break;
				case 7:
					return;
				case 6:
					Log((string)MSQpqPQ13Ll3PN1dGrQk(-477139494 ^ -477173112), (string)level);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					((IStartInformation)parent).Message = (string)startMessage;
					num2 = 7;
					break;
				default:
					current = (IStartInformation)parent;
					num2 = 5;
					break;
				case 3:
					if (!stopped)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				}
			}
		}

		internal static void nWURqNQ1noFfwBhfjVZ0()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static double SNAMLCQ1OMIRgVNj43uJ(object P_0)
		{
			return ((IStartInformation)P_0).Percent;
		}

		internal static object KsNPTeQ12Vq7e8ZB5q7i(object P_0)
		{
			return ((IStartInformation)P_0).Message;
		}

		internal static object pUJiETQ1eMmFyD6bhXUo(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static bool TJEovwQ1TkS4Q7rEto6A()
		{
			return AVRNM0Q1XT7PmohkJodk == null;
		}

		internal static ChildStartInformation W22Lf2Q1kNPwIQkxHaDP()
		{
			return (ChildStartInformation)AVRNM0Q1XT7PmohkJodk;
		}

		internal static void U9Bu9hQ1P0XQtPrlg6sP(object P_0, double value)
		{
			((IStartInformation)P_0).Percent = value;
		}

		internal static void N7ROehQ110NaBefbJGQO(object P_0, object P_1)
		{
			((IStartInformation)P_0).Message = (string)P_1;
		}

		internal static bool uYG2xqQ1NRdFINuwebpV(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object MSQpqPQ13Ll3PN1dGrQk(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void d9Ooi0Q1pJeZaXIfU9FB(object P_0)
		{
			((IStartInformation)P_0).StopOperation();
		}
	}

	private static ILogger logger;

	private static readonly StartInformation root;

	private static IStartInformation current;

	private string _message;

	private readonly BackupStatus backupStatus;

	private static StartInformation jEMaK7Wo00pPVimdQ23p;

	public static IStartInformation Current
	{
		get
		{
			return current;
		}
		protected set
		{
			current = value;
		}
	}

	public static StartInformation Root => root;

	public StartStatus Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public StartErrorType ErrorType
	{
		[CompilerGenerated]
		get
		{
			return _003CErrorType_003Ek__BackingField;
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
					_003CErrorType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string Message
	{
		get
		{
			return SR.T(_message);
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
				case 1:
					_message = value;
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

	public string Errors
	{
		[CompilerGenerated]
		get
		{
			return _003CErrors_003Ek__BackingField;
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
					_003CErrors_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public double Percent
	{
		[CompilerGenerated]
		get
		{
			return _003CPercent_003Ek__BackingField;
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
					_003CPercent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool HasErrors
	{
		[CompilerGenerated]
		get
		{
			return _003CHasErrors_003Ek__BackingField;
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
					_003CHasErrors_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string UpdateFromVersion
	{
		[CompilerGenerated]
		get
		{
			return _003CUpdateFromVersion_003Ek__BackingField;
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
					_003CUpdateFromVersion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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

	public BackupStatus Backup => backupStatus;

	public static IStartInformation Operation(double completePercent, string message)
	{
		return new ChildStartInformation(completePercent, message);
	}

	public void SetInfo(double percent, string message)
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (!((string)ptWi2aWoMfqVPRZZR16N(this) == message))
				{
					num2 = 6;
					continue;
				}
				return;
			case 0:
				return;
			case 6:
				if (percent > Percent)
				{
					num2 = 4;
					continue;
				}
				break;
			case 3:
				return;
			case 4:
				Percent = percent;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
				if (Percent == percent)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 5:
				Log((string)VCLOBsWo9GRWDDV3DGIc(-606654180 ^ -606683544));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 3;
				}
				continue;
			case 7:
				break;
			}
			jsCs7eWoJdOy6qAgUJ2y(this, message);
			num2 = 5;
		}
	}

	public void StopOperation()
	{
	}

	public override string ToString()
	{
		return (string)iFPIudWodTdl4RgxmZL8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6FD575), Status);
	}

	protected static void Log(string operation, string level = "")
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
				logger.InfoFormat((string)VCLOBsWo9GRWDDV3DGIc(-1710575414 ^ -1710538920), Root.Percent, operation, level, ptWi2aWoMfqVPRZZR16N(RQtT7bWolfwtfWnauwT1()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void IDisposable.Dispose()
	{
	}

	public StartInformation()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		CJC20KWor1cKof1GiCKl();
		backupStatus = new BackupStatus();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static StartInformation()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				current = root;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				logger = (ILogger)pHL5LhWogtygIZrJmdst(VCLOBsWo9GRWDDV3DGIc(0x6A81B9B4 ^ 0x6A80367C));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				root = new StartInformation();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				CJC20KWor1cKof1GiCKl();
				num2 = 3;
				break;
			}
		}
	}

	internal static bool ObRQ62Womkfgu4iK5OZo()
	{
		return jEMaK7Wo00pPVimdQ23p == null;
	}

	internal static StartInformation Y5QujrWoyewJYbwQBIdM()
	{
		return jEMaK7Wo00pPVimdQ23p;
	}

	internal static object ptWi2aWoMfqVPRZZR16N(object P_0)
	{
		return ((StartInformation)P_0).Message;
	}

	internal static void jsCs7eWoJdOy6qAgUJ2y(object P_0, object P_1)
	{
		((StartInformation)P_0).Message = (string)P_1;
	}

	internal static object VCLOBsWo9GRWDDV3DGIc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iFPIudWodTdl4RgxmZL8(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object RQtT7bWolfwtfWnauwT1()
	{
		return Root;
	}

	internal static void CJC20KWor1cKof1GiCKl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object pHL5LhWogtygIZrJmdst(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
