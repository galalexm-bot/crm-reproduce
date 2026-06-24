using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

public class BackupManager
{
	internal class BackupInfo
	{
		private static BackupInfo BfZi7OQaBHQ1wMNJNqDD;

		public DateTime BackupDate
		{
			[CompilerGenerated]
			get
			{
				return _003CBackupDate_003Ek__BackingField;
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
						_003CBackupDate_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
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

		public string Folder
		{
			[CompilerGenerated]
			get
			{
				return _003CFolder_003Ek__BackingField;
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
						_003CFolder_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string MainDbFileName
		{
			[CompilerGenerated]
			get
			{
				return _003CMainDbFileName_003Ek__BackingField;
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
						_003CMainDbFileName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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

		public BackupInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			EX7beaQab4BNYL5sNmFe();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool MHnfXYQaWu5AQWMrQJ0d()
		{
			return BfZi7OQaBHQ1wMNJNqDD == null;
		}

		internal static BackupInfo atsECFQaoNNHLSLtcBqc()
		{
			return BfZi7OQaBHQ1wMNJNqDD;
		}

		internal static void EX7beaQab4BNYL5sNmFe()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class Db
	{
		public static class Fields
		{
			public const string BackupDate = "BackupDate";

			public const string Folder = "Folder";

			public const string MainDbFileName = "MainDbFileName";
		}

		private static object g9DqkkQahDrqeU9QoRpC;

		public Db()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			w2DhAYQafwKKQ9TXotvW();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void w2DhAYQafwKKQ9TXotvW()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool ntRGGbQaG4fWtwyGGcEF()
		{
			return g9DqkkQahDrqeU9QoRpC == null;
		}

		internal static Db JtgLXPQaEbfIspqJe4XB()
		{
			return (Db)g9DqkkQahDrqeU9QoRpC;
		}
	}

	private RuntimeConfiguration _configuration;

	private ITransformationProvider _transform;

	private readonly IStartControl startControl;

	private bool _structuresChecked;

	private static readonly ILogger BackupLog;

	private static BackupManager jdgQVyWZ0lLtfbutPa1y;

	public bool BackupsEnabled => fjNt8VWZJZxm7g36Sh1u(gw2NVBWZM9xqh5bgJP59(_configuration));

	public bool FullAutoBackupSupport => _transform.HasFullAutoBackupSupport;

	public bool BackupCreated
	{
		[CompilerGenerated]
		get
		{
			return _003CBackupCreated_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CBackupCreated_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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

	public void DoBackup(BackupParameters p, string cause, bool ignoreIfDone = true)
	{
		//Discarded unreachable code: IL_0121, IL_0282, IL_03b7, IL_03ef, IL_03fe, IL_042a, IL_0494, IL_0592, IL_05a1
		int num = 10;
		int num2 = num;
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				BackupCreated = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				RedirectToManualBackupPage();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 8:
				return;
			case 1:
				return;
			case 11:
				if (!BackupCreated)
				{
					if (!BackupsEnabled)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 6;
						}
						break;
					}
					XKE9ktWZdRU5c31vBxgv(BackupLog, imQYPvWZ9oDijLRf0wed(-1886646897 ^ -1886538973));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 6;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 6:
				try
				{
					DBStartInformation dBStartInformation = new DBStartInformation(DatabaseConversionStage.Backup);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 1:
						return;
					}
					try
					{
						string backupPath = ((IDataBaseSettingsSection)gw2NVBWZM9xqh5bgJP59(_configuration)).BackupPath;
						int num4 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num4 = 7;
						}
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 1:
								return;
							case 2:
							case 5:
								BackupCreated = true;
								num4 = 6;
								break;
							default:
								RedirectToManualBackupPage();
								num5 = 10;
								goto IL_0164;
							case 8:
								RVZRD5WZj1uKC9YG4vKN(L7opydWZ5c4h7qbRPBUQ(ePsVgiWZY4HbJar0Oe4F()), BackupStatus.BackupContext.DoneAutomatically);
								num4 = 5;
								break;
							case 12:
								XKE9ktWZdRU5c31vBxgv(BackupLog, imQYPvWZ9oDijLRf0wed(-2138958856 ^ -2138854242));
								num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num4 = 4;
								}
								break;
							case 4:
								XKE9ktWZdRU5c31vBxgv(BackupLog, (string)imQYPvWZ9oDijLRf0wed(-1978478350 ^ -1978437822) + text);
								num4 = 3;
								break;
							case 7:
								text = (string)x5t80HWZrYnOFUekFP4W(_transform, v2LbwaWZlRSl1pxZ40B3(_configuration.MainDB), backupPath);
								num4 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num4 = 4;
								}
								break;
							case 10:
								RVZRD5WZj1uKC9YG4vKN(L7opydWZ5c4h7qbRPBUQ(StartInformation.Root), BackupStatus.BackupContext.DoneManually);
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num4 = 2;
								}
								break;
							case 11:
								XKE9ktWZdRU5c31vBxgv(BackupLog, imQYPvWZ9oDijLRf0wed(-1824388195 ^ -1824279173));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num4 = 0;
								}
								break;
							case 9:
								if (zb3fpgWZgRwgtZsEVr90(text))
								{
									num5 = 11;
									goto IL_0164;
								}
								goto case 8;
							case 6:
							{
								BackupInfo backupInfo = new BackupInfo();
								kqrp4PWZUwKuNGyU1uUX(backupInfo, aCC0k2WZLCM8WbfbdCio());
								backupInfo.Folder = backupPath;
								HXZwQ1WZsmjP4GVm5aWU(backupInfo, text);
								SaveInfo(backupInfo);
								num4 = 12;
								break;
							}
							case 3:
								{
									XKE9ktWZdRU5c31vBxgv(BackupLog, rfTHkcWZcGUij31AsEQM(imQYPvWZ9oDijLRf0wed(-787452571 ^ -787361101), backupPath ?? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583728906)));
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num4 = 1;
									}
									break;
								}
								IL_0164:
								num4 = num5;
								break;
							}
						}
					}
					finally
					{
						if (dBStartInformation != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									ekkAYOWZzpDf0pFBgFEm(dBStartInformation);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
				catch (InvalidOperationException ex)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							throw;
						}
						wYMc6UWuFFRCtFEgFMiD(BackupLog, imQYPvWZ9oDijLRf0wed(0x4785BC0D ^ 0x47847C4F), ex);
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num7 = 1;
						}
					}
				}
				catch (ArgumentNullException ex2)
				{
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num8 = 0;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							if (sHQZWjWuWyuxC9V55Rnv(PSDxhmWuBUWyROr6K2Dy(ex2), imQYPvWZ9oDijLRf0wed(-521266112 ^ -521151454)))
							{
								num8 = 2;
								break;
							}
							throw;
						case 3:
							text2 = (string)imQYPvWZ9oDijLRf0wed(-1487388570 ^ -1487306508);
							num8 = 4;
							break;
						case 4:
							wYMc6UWuFFRCtFEgFMiD(BackupLog, aB8C4vWuoNkUMCvSsoj1(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541846739), Environment.NewLine, text3, text2), ex2);
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num8 = 1;
							}
							break;
						case 2:
							text3 = (string)imQYPvWZ9oDijLRf0wed(-538519530 ^ -538503060);
							num8 = 3;
							break;
						case 1:
							throw new InvalidOperationException(SR.T((string)imQYPvWZ9oDijLRf0wed(0x4DC2B14D ^ 0x4DC37001), text2, text3));
						}
					}
				}
			case 4:
				BackupLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FBBD42));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				XKE9ktWZdRU5c31vBxgv(BackupLog, imQYPvWZ9oDijLRf0wed(-606654180 ^ -606695590));
				num2 = 8;
				break;
			case 7:
				BackupLog.Info(imQYPvWZ9oDijLRf0wed(-1870892489 ^ -1870802955));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 2;
				}
				break;
			case 10:
				BackupLog.Info(imQYPvWZ9oDijLRf0wed(-105199646 ^ -105153848));
				num2 = 9;
				break;
			case 9:
				XKE9ktWZdRU5c31vBxgv(BackupLog, (string)imQYPvWZ9oDijLRf0wed(0x20261A4F ^ 0x2027A739) + cause);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 11;
				}
				break;
			}
		}
	}

	internal void CreateDbStructures(ITransformationProvider transform, int version)
	{
		int num = 5;
		int num2 = num;
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				transform.AddTable(table);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
				if (version == 0)
				{
					num2 = 4;
					continue;
				}
				break;
			case 4:
				if (!xlUwHgWub6vUqL1IS6OH(transform, imQYPvWZ9oDijLRf0wed(0x6DC147B0 ^ 0x6DC0852A)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
				table = new Table
				{
					Name = (string)imQYPvWZ9oDijLRf0wed(0x68BBB53E ^ 0x68BA77A4),
					Columns = new List<Column>
					{
						new Column((string)imQYPvWZ9oDijLRf0wed(-1317790512 ^ -1317675414), DbType.DateTime),
						new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710525928), new ColumnType(DbType.String, 256)),
						new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6F98E9), new ColumnType(DbType.String, 256))
					}
				};
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				continue;
			case 0:
				return;
			case 3:
				break;
			}
			_structuresChecked = true;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal BackupManager([NotNull] RuntimeConfiguration configuration, [NotNull] ITransformationProvider transform, [NotNull] IStartControl startControl)
	{
		//Discarded unreachable code: IL_002a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 0;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 3:
				K3FcvIWuhQAXNDIRR687(startControl, imQYPvWZ9oDijLRf0wed(--1360331293 ^ 0x5114C13D));
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 5;
				}
				break;
			case 2:
				_transform = transform;
				num2 = 5;
				goto IL_002f;
			default:
				K3FcvIWuhQAXNDIRR687(configuration, imQYPvWZ9oDijLRf0wed(0x48A7E34A ^ 0x48A62048));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num = 1;
				}
				break;
			case 1:
				K3FcvIWuhQAXNDIRR687(transform, imQYPvWZ9oDijLRf0wed(-1852837372 ^ -1852947950));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 3;
				}
				break;
			case 5:
				this.startControl = startControl;
				num2 = 4;
				goto IL_002f;
			case 6:
				_configuration = configuration;
				num = 2;
				break;
			case 7:
				return;
			case 4:
				{
					((BackupStatus)L7opydWZ5c4h7qbRPBUQ(ePsVgiWZY4HbJar0Oe4F())).CurrentStatus = BackupStatus.BackupContext.Unknown;
					num = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num = 5;
					}
					break;
				}
				IL_002f:
				num = num2;
				break;
			}
		}
	}

	private void SaveInfo(BackupInfo info)
	{
		//Discarded unreachable code: IL_00ce, IL_0129, IL_0169, IL_0178
		int num = 3;
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
					try
					{
						g1rK06WuCHRCo4T6op1d(_transform, imQYPvWZ9oDijLRf0wed(-1217523399 ^ -1217408093), new string[3]
						{
							(string)imQYPvWZ9oDijLRf0wed(0x10E41EDB ^ 0x10E5DC61),
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886531747),
							(string)imQYPvWZ9oDijLRf0wed(0x48A7E34A ^ 0x48A621A8)
						}, new object[3]
						{
							s8JnX5WuEgswALghPJwC(info),
							botKmeWufxgOABhGb61B(info),
							twyN12WuQys2HAOVtx8f(info)
						});
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								_transform.CommitTransaction();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
					catch
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
								IGGOWkWuv3IXxP5m1EJf(_transform);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
				case 3:
					if (!_structuresChecked)
					{
						num = 2;
						break;
					}
					FKTUlMWuGiBvy5Z4IEH4(_transform);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void RedirectToManualBackupPage()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				Locator.AddService(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				auRZ8XWu8QMeJo7uyqU1(startControl, StartStatus.BackupNeeded);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	static BackupManager()
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
				BackupLog = (ILogger)AYlPcWWuusVhqDP1YeiD(imQYPvWZ9oDijLRf0wed(0x31326106 ^ 0x3133F358));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				gWenOdWuZ456s3V1mC3v();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object gw2NVBWZM9xqh5bgJP59(object P_0)
	{
		return ((RuntimeConfiguration)P_0).MainDB;
	}

	internal static bool fjNt8VWZJZxm7g36Sh1u(object P_0)
	{
		return ((IDataBaseSettingsSection)P_0).BackupEnabled;
	}

	internal static bool eM1SslWZmf2y4DfjuQqo()
	{
		return jdgQVyWZ0lLtfbutPa1y == null;
	}

	internal static BackupManager w7k3MRWZyAxyXTjRXDZ5()
	{
		return jdgQVyWZ0lLtfbutPa1y;
	}

	internal static object imQYPvWZ9oDijLRf0wed(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XKE9ktWZdRU5c31vBxgv(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static object v2LbwaWZlRSl1pxZ40B3(object P_0)
	{
		return ((IDataBaseSettingsSection)P_0).ConnectionString;
	}

	internal static object x5t80HWZrYnOFUekFP4W(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).BackupDatabase((string)P_1, (string)P_2);
	}

	internal static bool zb3fpgWZgRwgtZsEVr90(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object L7opydWZ5c4h7qbRPBUQ(object P_0)
	{
		return ((StartInformation)P_0).Backup;
	}

	internal static void RVZRD5WZj1uKC9YG4vKN(object P_0, BackupStatus.BackupContext value)
	{
		((BackupStatus)P_0).CurrentStatus = value;
	}

	internal static object ePsVgiWZY4HbJar0Oe4F()
	{
		return StartInformation.Root;
	}

	internal static DateTime aCC0k2WZLCM8WbfbdCio()
	{
		return DateTime.Now;
	}

	internal static void kqrp4PWZUwKuNGyU1uUX(object P_0, DateTime value)
	{
		((BackupInfo)P_0).BackupDate = value;
	}

	internal static void HXZwQ1WZsmjP4GVm5aWU(object P_0, object P_1)
	{
		((BackupInfo)P_0).MainDbFileName = (string)P_1;
	}

	internal static object rfTHkcWZcGUij31AsEQM(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void ekkAYOWZzpDf0pFBgFEm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void wYMc6UWuFFRCtFEgFMiD(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object PSDxhmWuBUWyROr6K2Dy(object P_0)
	{
		return ((ArgumentException)P_0).ParamName;
	}

	internal static bool sHQZWjWuWyuxC9V55Rnv(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object aB8C4vWuoNkUMCvSsoj1(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool xlUwHgWub6vUqL1IS6OH(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void K3FcvIWuhQAXNDIRR687(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void FKTUlMWuGiBvy5Z4IEH4(object P_0)
	{
		((ITransformationProvider)P_0).BeginTransaction();
	}

	internal static DateTime s8JnX5WuEgswALghPJwC(object P_0)
	{
		return ((BackupInfo)P_0).BackupDate;
	}

	internal static object botKmeWufxgOABhGb61B(object P_0)
	{
		return ((BackupInfo)P_0).Folder;
	}

	internal static object twyN12WuQys2HAOVtx8f(object P_0)
	{
		return ((BackupInfo)P_0).MainDbFileName;
	}

	internal static int g1rK06WuCHRCo4T6op1d(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ITransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3);
	}

	internal static void IGGOWkWuv3IXxP5m1EJf(object P_0)
	{
		((ITransformationProvider)P_0).RollbackTransaction();
	}

	internal static void auRZ8XWu8QMeJo7uyqU1(object P_0, StartStatus suspendReason)
	{
		((IStartControl)P_0).Suspend(suspendReason);
	}

	internal static void gWenOdWuZ456s3V1mC3v()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object AYlPcWWuusVhqDP1YeiD(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
