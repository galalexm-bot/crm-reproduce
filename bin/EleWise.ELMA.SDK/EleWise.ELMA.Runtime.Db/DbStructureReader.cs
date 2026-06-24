using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

[Service]
public class DbStructureReader
{
	protected const string DB_STRUCTURE = "DB_STRUCTURE";

	protected const string UID = "Uid";

	protected const string STRUCTURE = "Structure";

	protected const string UPDATE_DATE = "UpdateDate";

	protected const string DB_STRUCTURE_HISTORY = "DB_STRUCTURE_HISTORY";

	private IEnumerable<DbStructure> structures;

	private IEnumerable<DbStructure> prevStructures;

	private IEnumerable<IDbUpdateHandler> handlers;

	private DbStructure currStruct;

	private DbStructure prevStruct;

	private DateTime startUpdateTime;

	private bool recreateConstraints;

	private static readonly ILogger DbUpdateLog;

	private static string quoteWrapperPattern;

	private static string quoteWrapperPatternXml;

	private DbMigrator dbMigrator;

	private static DbStructureReader r0eoZ6WVWfLB7IOcTsSF;

	public BackupManager BackupManager
	{
		[CompilerGenerated]
		get
		{
			return _003CBackupManager_003Ek__BackingField;
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
					_003CBackupManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ITransformationProvider Transform
	{
		[CompilerGenerated]
		get
		{
			return _003CTransform_003Ek__BackingField;
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
					_003CTransform_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionProvider_003Ek__BackingField;
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected DbStructure CurrStruct => currStruct;

	protected DbStructure PrevStruct => prevStruct;

	protected DateTime StartUpdateTime => startUpdateTime;

	private bool UseSmartUpdater
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return result;
				default:
					result = true;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (!bool.TryParse((string)LC12BxWVTLuces7IkGGZ(ConfigurationManager.AppSettings, qQNj7gWVE9ZflK2e5LD6(-138018305 ^ -137897075)), out result))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
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

	public void Read(IEnumerable<DbStructure> structures, IEnumerable<IDbUpdateHandler> handlers)
	{
		Contract.ArgumentNotNull(structures, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C19481));
		Contract.ArgumentNotNull(handlers, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16675339));
		Contract.ArgumentNotNull(Transform, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765898252));
		this.structures = structures;
		this.handlers = handlers;
		startUpdateTime = DateTime.Now;
		Logger.Logged += Logger_Logged;
		Logger.Log.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C1955D));
		DbUpdateLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426172847));
		DbUpdateLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398642514), VersionInfo.GetInfoVersion<SR>());
		IGrouping<Guid, DbStructure>[] array = (from x in structures
			group x by _003C_003Ec.WE6KUmQDfL9PUhgcvRyn(x) into x
			where x.Count() > 1
			select x).ToArray();
		if (array.Length != 0)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.dbStructureExtension = ComponentManager.Current.GetExtensionPoints<IDbStructureExtension>().ToArray();
			string message = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852955108) + Environment.NewLine + string.Join(Environment.NewLine, array.Select((IGrouping<Guid, DbStructure> d) => string.Concat(d.Key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317768060), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EF4EE2), d.Select(delegate(DbStructure s)
			{
				int num = 1;
				int num2 = num;
				_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_1);
				while (true)
				{
					switch (num2)
					{
					default:
						_003C_003Ec__DisplayClass8_.s = s;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_1();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return CS_0024_003C_003E8__locals0.dbStructureExtension.First(_003C_003Ec__DisplayClass8_._003CRead_003Eb__4).GetType().FullName;
					}
				}
			})))));
			DbUpdateLog.Fatal(message);
			throw new InvalidOperationException(message);
		}
		dbMigrator = new DbMigrator(Transform);
		dbMigrator.ReadDbMetadata();
		try
		{
			ExecuteInitialStructuresTransaction();
			StartInformation.Current.SetInfo(5.0, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECF8772)));
			ExecuteInitTransaction();
			ILogger logger = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957788130));
			if (!CheckHasChanges())
			{
				StartInformation.Root.Backup.CurrentStatus = BackupStatus.BackupContext.NotNeeded;
				logger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EDC1EF));
				Logger.Log.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867708550));
				DbUpdateLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC3642F));
				return;
			}
			if (recreateConstraints)
			{
				using (new DBStartInformation(DatabaseConversionStage.StartDatabaseConversion))
				{
					logger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E3AE58));
					if (RuntimeApplication == null)
					{
						throw new ServiceNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643714013));
					}
					if (!RuntimeApplication.DbPreUpdater.BackupCreated && !RuntimeApplication.DbPreUpdater.IsFirstStart)
					{
						if (BackupManager == null)
						{
							throw new ServiceNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638522833));
						}
						BackupManager.DoBackup(BackupParameters.OnlyMainDatabase, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A7641EB)));
					}
					RuntimeApplication.DbPreUpdater.StartUpdating();
				}
				ExecuteMain();
			}
			else
			{
				StartInformation.Root.Backup.CurrentStatus = BackupStatus.BackupContext.NotNeeded;
				logger.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867708222));
				ExecuteMainInTransaction();
			}
			Logger.Log.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335080133));
			DbUpdateLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998495662));
		}
		catch (DbStructureException exception)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F31AF5C), exception);
			DbUpdateLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1F34F2), exception);
			throw;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576098226), ex);
			DbUpdateLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335079963), ex);
			throw new DbStructureException(ex);
		}
	}

	[Transaction]
	protected virtual void ExecuteInitialStructuresTransaction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				CheckStructureVersions();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			ExecuteHandlers(delegate(IDbUpdateHandler h)
			{
				_003C_003Ec.rlHi5rQDQd77qe3egO8I(h);
			});
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
			{
				num2 = 2;
			}
		}
	}

	[Transaction]
	protected virtual void ExecuteInitTransaction()
	{
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
				case 3:
					break;
				case 0:
					return;
				case 2:
					prevStructures = ReadPreviousStructures();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					ExecuteHandlers(delegate(IDbUpdateHandler h)
					{
						_003C_003Ec.VGtmGFQDCQ9vmt1ay6Tu(h);
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			CheckActiveUpdates();
			num = 2;
		}
	}

	protected bool CheckHasChanges()
	{
		//Discarded unreachable code: IL_0084, IL_0093, IL_00e5, IL_00f4, IL_01f7, IL_0206, IL_0227, IL_027e, IL_02be, IL_02cd, IL_02d9, IL_0366, IL_0375, IL_03a3, IL_03b2, IL_03bd, IL_04bc, IL_0502, IL_0556, IL_0575, IL_05a1, IL_063e, IL_07eb, IL_07fa, IL_081b
		int num = 6;
		bool result = default(bool);
		IEnumerator<DbStructure> enumerator = default(IEnumerator<DbStructure>);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		DbStructure dbStructure = default(DbStructure);
		IEnumerator<IDbUpdateHandler> enumerator2 = default(IEnumerator<IDbUpdateHandler>);
		_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_2 = default(_003C_003Ec__DisplayClass11_1);
		DbStructure current2 = default(DbStructure);
		IDbUpdateHandler current = default(IDbUpdateHandler);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 16:
					return result;
				case 17:
					enumerator = prevStructures.GetEnumerator();
					num2 = 15;
					continue;
				case 7:
					try
					{
						while (true)
						{
							IL_01ba:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_00a2;
							}
							goto IL_01d0;
							IL_00a2:
							while (true)
							{
								switch (num3)
								{
								case 5:
									_003C_003Ec__DisplayClass11_.currItem = enumerator.Current;
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num3 = 7;
									}
									continue;
								case 9:
									dbStructure = prevStructures.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CCheckHasChanges_003Eb__1);
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num3 = 11;
									}
									continue;
								case 12:
									recreateConstraints = true;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
									{
										num3 = 0;
									}
									continue;
								case 7:
								case 10:
									DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(0x4DC2B14D ^ 0x4DC36969), Cbl1SBWVf2WBEqNlQMH1(_003C_003Ec__DisplayClass11_.currItem));
									num3 = 4;
									continue;
								case 3:
								case 8:
									goto IL_01ba;
								case 1:
									goto IL_01d0;
								case 4:
									result = true;
									num3 = 12;
									continue;
								case 11:
									if (dbStructure == null)
									{
										num3 = 7;
										continue;
									}
									goto case 6;
								case 0:
									break;
								case 6:
									if (!yp935jWVGwVVyow1A7UY(XtGRVXWVhRgOK9OXD85s(_003C_003Ec__DisplayClass11_.currItem), XtGRVXWVhRgOK9OXD85s(dbStructure)))
									{
										num3 = 3;
										continue;
									}
									goto case 7;
								case 2:
									break;
								}
								break;
							}
							break;
							IL_01d0:
							_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
							int num4 = 5;
							num3 = num4;
							goto IL_00a2;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num5 = 2;
							}
							goto IL_0282;
						}
						goto IL_0298;
						IL_0298:
						enumerator.Dispose();
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num5 = 0;
						}
						goto IL_0282;
						IL_0282:
						switch (num5)
						{
						default:
							goto end_IL_025d;
						case 1:
							break;
						case 2:
							goto end_IL_025d;
						case 0:
							goto end_IL_025d;
						}
						goto IL_0298;
						end_IL_025d:;
					}
					goto case 17;
				case 3:
					recreateConstraints = false;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					enumerator2 = handlers.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					if (SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1245C5B8), defaultValue: false))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 13:
					break;
				case 15:
					try
					{
						while (true)
						{
							IL_0484:
							int num10;
							if (!yE55KhWVQpOIplEmPfQY(enumerator))
							{
								num10 = 8;
								goto IL_03c1;
							}
							goto IL_0461;
							IL_03c1:
							while (true)
							{
								switch (num10)
								{
								case 1:
									_003C_003Ec__DisplayClass11_2 = new _003C_003Ec__DisplayClass11_1();
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
									{
										num10 = 0;
									}
									continue;
								case 6:
									DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(-1822890472 ^ -1822867900), Cbl1SBWVf2WBEqNlQMH1(current2));
									num10 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num10 = 3;
									}
									continue;
								case 9:
									break;
								case 2:
								case 5:
									goto IL_0484;
								case 3:
									result = true;
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num10 = 7;
									}
									continue;
								case 4:
									goto end_IL_0484;
								case 10:
									if (!structures.Any(_003C_003Ec__DisplayClass11_2._003CCheckHasChanges_003Eb__2))
									{
										num10 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
										{
											num10 = 2;
										}
										continue;
									}
									goto case 6;
								default:
									_003C_003Ec__DisplayClass11_2.p = current2;
									num10 = 10;
									continue;
								case 7:
									recreateConstraints = true;
									num10 = 4;
									continue;
								case 8:
									goto end_IL_0484;
								}
								break;
							}
							goto IL_0461;
							IL_0461:
							current2 = enumerator.Current;
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num10 = 1;
							}
							goto IL_03c1;
							continue;
							end_IL_0484:
							break;
						}
					}
					finally
					{
						int num11;
						if (enumerator == null)
						{
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num11 = 0;
							}
							goto IL_055a;
						}
						goto IL_057f;
						IL_057f:
						RgLq98WVCgqwvpENPdQm(enumerator);
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num11 = 1;
						}
						goto IL_055a;
						IL_055a:
						switch (num11)
						{
						default:
							goto end_IL_0535;
						case 0:
							goto end_IL_0535;
						case 2:
							break;
						case 1:
							goto end_IL_0535;
						}
						goto IL_057f;
						end_IL_0535:;
					}
					goto case 12;
				case 6:
					result = false;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 5;
					}
					continue;
				case 14:
					WZXOMdWV8NVfBM0YG5BI(DbUpdateLog, "");
					num2 = 11;
					continue;
				case 9:
					if (!recreateConstraints)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 1:
					bb64fGWVZCMBBcY2PQUT(WHWBbBWVub1R9Z72y32y(), "");
					num2 = 3;
					continue;
				case 2:
					bb64fGWVZCMBBcY2PQUT(Logger.Log, "");
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
					try
					{
						while (true)
						{
							IL_078c:
							int num7;
							if (!yE55KhWVQpOIplEmPfQY(enumerator2))
							{
								int num6 = 2;
								num7 = num6;
								goto IL_064c;
							}
							goto IL_06fc;
							IL_064c:
							while (true)
							{
								switch (num7)
								{
								default:
									DbUpdateLog.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123589968), current);
									num7 = 6;
									continue;
								case 4:
									DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(-16752921 ^ -16677253), current);
									num7 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num7 = 3;
									}
									continue;
								case 3:
									result = true;
									num7 = 7;
									continue;
								case 8:
									break;
								case 6:
									recreateConstraints = true;
									num7 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
									{
										num7 = 5;
									}
									continue;
								case 1:
									if (current.HasChanges)
									{
										num7 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
										{
											num7 = 3;
										}
										continue;
									}
									goto case 7;
								case 7:
									if (tb5kQ8WVvynJI14rEahG(current))
									{
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
										{
											num7 = 0;
										}
										continue;
									}
									goto IL_078c;
								case 5:
									goto IL_078c;
								case 2:
									goto end_IL_078c;
								}
								break;
							}
							goto IL_06fc;
							IL_06fc:
							current = enumerator2.Current;
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num7 = 0;
							}
							goto IL_064c;
							continue;
							end_IL_078c:
							break;
						}
					}
					finally
					{
						int num8;
						if (enumerator2 == null)
						{
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num8 = 0;
							}
							goto IL_07d0;
						}
						goto IL_0805;
						IL_0805:
						RgLq98WVCgqwvpENPdQm(enumerator2);
						int num9 = 2;
						num8 = num9;
						goto IL_07d0;
						IL_07d0:
						switch (num8)
						{
						default:
							goto end_IL_07ab;
						case 0:
							goto end_IL_07ab;
						case 1:
							break;
						case 2:
							goto end_IL_07ab;
						}
						goto IL_0805;
						end_IL_07ab:;
					}
					goto case 9;
				case 11:
					WZXOMdWV8NVfBM0YG5BI(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x3B36AB09 ^ 0x3B37725D));
					num2 = 13;
					continue;
				case 10:
					bb64fGWVZCMBBcY2PQUT(WHWBbBWVub1R9Z72y32y(), qQNj7gWVE9ZflK2e5LD6(-1876063057 ^ -1876142597));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					enumerator = structures.Where((DbStructure s) => !_003C_003Ec.Qd9EV4QDvYBgnuCBKkm7(s)).GetEnumerator();
					num2 = 7;
					continue;
				}
				break;
			}
			WZXOMdWV8NVfBM0YG5BI(DbUpdateLog, "");
			num = 2;
		}
	}

	[Transaction]
	protected virtual void ExecuteMainInTransaction()
	{
		tDCZPDWVI08UPJ5rPn2T(this);
	}

	protected virtual void ExecuteMain()
	{
		//Discarded unreachable code: IL_0061, IL_00f6, IL_0105, IL_0111, IL_0120
		int num = 1;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 5:
				try
				{
					ti41twWVqbO3SsGTYsro(this);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						px3wEoWVKTaSrljPnvQ1(dbMigrator);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					int num4;
					if (dBStartInformation == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num4 = 0;
						}
						goto IL_00c6;
					}
					goto IL_00dc;
					IL_00dc:
					RgLq98WVCgqwvpENPdQm(dBStartInformation);
					int num5 = 2;
					num4 = num5;
					goto IL_00c6;
					IL_00c6:
					switch (num4)
					{
					case 1:
						goto end_IL_00a1;
					case 2:
						goto end_IL_00a1;
					}
					goto IL_00dc;
					end_IL_00a1:;
				}
			case 7:
				ExecuteDeleteRecreatedTransaction();
				num2 = 8;
				break;
			case 4:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.CompleteDatabaseConversion);
				num2 = 5;
				break;
			case 2:
				IoVAWdWVRlNbxFai9VxE(this);
				num2 = 4;
				break;
			case 1:
				Jl68mXWVV18qdGUYdoeE(dbMigrator);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				cMXHEOWViMG3o02d1BLa(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 2;
				}
				break;
			default:
				vtrIE6WVSO911JqYbIcQ(this);
				num2 = 7;
				break;
			case 8:
				ExecuteCreateTablesTransaction();
				num2 = 3;
				break;
			case 6:
				return;
			}
		}
	}

	[Transaction]
	protected virtual void ExecuteStart()
	{
		int num = 8;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					structures.Where(_003C_003Ec__DisplayClass14_._003CExecuteStart_003Eb__0).ToList();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					ProcessRemovingIndexes();
					num2 = 6;
					continue;
				case 9:
					DbUpdateLog.Debug(qQNj7gWVE9ZflK2e5LD6(-35995181 ^ -35972997));
					num2 = 2;
					continue;
				case 5:
					ExecuteHandlers(_003C_003Ec__DisplayClass14_._003CExecuteStart_003Eb__1);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnStart);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 10;
					}
					continue;
				case 1:
					prevStruct = DbStructure.Merge(prevStructures);
					num2 = 11;
					continue;
				case 0:
					return;
				case 10:
					break;
				case 3:
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x6A81B9B4 ^ 0x6A806052));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					currStruct = DbStructure.Merge(structures);
					num2 = 3;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass14_.parameters = new DbUpdateParameters
			{
				RecreateConstraints = recreateConstraints
			};
			num = 5;
		}
	}

	[Transaction]
	protected virtual void ExecuteDeleteRecreatedTransaction()
	{
		//Discarded unreachable code: IL_00e8, IL_0120, IL_0158, IL_01ba, IL_01f2, IL_0232, IL_0241, IL_024d, IL_0260, IL_026f, IL_029b, IL_02d3, IL_030b, IL_031a
		int num = 2;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (recreateConstraints)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.DeletingViews);
				num2 = 4;
				break;
			case 2:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.DeleteTriggers);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.DeletingOfProcedures);
				num2 = 10;
				break;
			case 11:
				DropConstraintsSmart();
				num2 = 8;
				break;
			case 4:
				try
				{
					DeleteViews();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (dBStartInformation != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								((IDisposable)dBStartInformation).Dispose();
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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
				goto case 6;
			case 9:
				return;
			case 8:
				return;
			case 7:
				DropConstraints();
				num2 = 9;
				break;
			default:
				if (!UseSmartUpdater)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 10:
				try
				{
					DeleteProcedures();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num6;
					if (dBStartInformation == null)
					{
						num6 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num6 = 2;
						}
						goto IL_01f6;
					}
					goto IL_020c;
					IL_020c:
					((IDisposable)dBStartInformation).Dispose();
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num6 = 0;
					}
					goto IL_01f6;
					IL_01f6:
					switch (num6)
					{
					case 2:
						goto end_IL_01d1;
					case 1:
						goto end_IL_01d1;
					}
					goto IL_020c;
					end_IL_01d1:;
				}
				goto case 3;
			case 1:
				try
				{
					DeleteTriggers();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (dBStartInformation != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								RgLq98WVCgqwvpENPdQm(dBStartInformation);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 5;
			}
		}
	}

	[Transaction]
	protected virtual void ExecuteCreateTablesTransaction()
	{
		//Discarded unreachable code: IL_006c, IL_00a4, IL_00dc, IL_00eb
		int num = 2;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.TableCreation);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					CreateTables();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (dBStartInformation != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((IDisposable)dBStartInformation).Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			}
		}
	}

	[Transaction]
	protected virtual void ExecuteDeleteTablesTransaction()
	{
		//Discarded unreachable code: IL_004a, IL_0082, IL_00c2, IL_00cd, IL_00dc
		int num = 1;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.DeleteTables);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				DeleteTables();
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (dBStartInformation == null)
				{
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num4 = 0;
					}
					goto IL_0086;
				}
				goto IL_009c;
				IL_009c:
				RgLq98WVCgqwvpENPdQm(dBStartInformation);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num4 = 0;
				}
				goto IL_0086;
				IL_0086:
				switch (num4)
				{
				default:
					goto end_IL_0061;
				case 2:
					break;
				case 1:
					goto end_IL_0061;
				case 0:
					goto end_IL_0061;
				}
				goto IL_009c;
				end_IL_0061:;
			}
		}
	}

	[Transaction]
	protected virtual void ExecuteCreateRecreatedTransaction()
	{
		//Discarded unreachable code: IL_0076, IL_00ae, IL_00cd, IL_00dc, IL_0109, IL_01ae, IL_01e6, IL_021e, IL_022d, IL_0259, IL_0281, IL_02c1, IL_02d0, IL_02dc, IL_02eb
		int num = 6;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (recreateConstraints)
				{
					num2 = 5;
					continue;
				}
				break;
			case 7:
				try
				{
					CreateTriggers();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num8;
					if (dBStartInformation == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num8 = 1;
						}
						goto IL_00b2;
					}
					goto IL_00e7;
					IL_00e7:
					RgLq98WVCgqwvpENPdQm(dBStartInformation);
					num8 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num8 = 2;
					}
					goto IL_00b2;
					IL_00b2:
					switch (num8)
					{
					case 1:
						goto end_IL_008d;
					case 2:
						goto end_IL_008d;
					}
					goto IL_00e7;
					end_IL_008d:;
				}
			case 5:
				RecreateConstraints();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.CreationOfProcedures);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.CreateTriggers);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 7;
				}
				continue;
			case 8:
				return;
			case 1:
				break;
			case 4:
				try
				{
					CreateViews();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (dBStartInformation != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								((IDisposable)dBStartInformation).Dispose();
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
				}
				goto case 3;
			default:
				try
				{
					CreateProcedures();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num4;
					if (dBStartInformation == null)
					{
						num4 = 2;
						goto IL_0285;
					}
					goto IL_029b;
					IL_0285:
					switch (num4)
					{
					case 2:
						goto end_IL_0270;
					case 1:
						goto end_IL_0270;
					}
					goto IL_029b;
					IL_029b:
					RgLq98WVCgqwvpENPdQm(dBStartInformation);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num4 = 0;
					}
					goto IL_0285;
					end_IL_0270:;
				}
				goto case 2;
			}
			dBStartInformation = new DBStartInformation(DatabaseConversionStage.CreatingViews);
			num2 = 4;
		}
	}

	[Transaction]
	protected virtual void ExecuteComplete()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					return;
				default:
					SaveCurrentStructures();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					DbUpdateLog.Debug(qQNj7gWVE9ZflK2e5LD6(-882126494 ^ -882242748));
					num2 = 2;
					continue;
				case 4:
					ExecuteHandlers(delegate(IDbUpdateHandler h)
					{
						_003C_003Ec.wpMSBYQD8NrD1fGVuBc9(h);
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnComplete);
			num = 4;
		}
	}

	private void Logger_Logged(LoggingEventArgs loggingEventArgs)
	{
	}

	private void ExecuteHandlers(Action<IDbUpdateHandler> handlerMethod)
	{
		foreach (IDbUpdateHandler handler in handlers)
		{
			DbUpdateLog.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x363129F9), handlerMethod.Method.Name, handler.GetType().FullName));
			handlerMethod(handler);
		}
	}

	private void CheckStructureVersions()
	{
		//Discarded unreachable code: IL_0065, IL_0236, IL_0245, IL_0466, IL_04ba, IL_04c9
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
			case 1:
				try
				{
					int num3;
					if (!Transform.TableExists((string)qQNj7gWVE9ZflK2e5LD6(-16752921 ^ -16677385)))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num3 = 0;
						}
						goto IL_0069;
					}
					goto IL_040b;
					IL_00f3:
					ITransformationProvider transform = Transform;
					Table table = new Table();
					kvqDAfWVkSOR3ivgmmbK(table, qQNj7gWVE9ZflK2e5LD6(-1852837372 ^ -1852954274));
					table.Columns = new List<Column>
					{
						new Column((string)qQNj7gWVE9ZflK2e5LD6(0x1DE3DD89 ^ 0x1DE35CD7), DbType.Int32, ColumnProperty.PrimaryKeyWithIdentity),
						new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345467326), DbType.DateTime, ColumnProperty.NotNull),
						new Column((string)qQNj7gWVE9ZflK2e5LD6(-345420348 ^ -345467292), DbType.DateTime, ColumnProperty.NotNull),
						new Column((string)qQNj7gWVE9ZflK2e5LD6(-309639236 ^ -309683196), DbType.DateTime),
						new Column((string)qQNj7gWVE9ZflK2e5LD6(0x42643203 ^ 0x4264B385), DbType.Int16, ColumnProperty.NotNull),
						new Column((string)qQNj7gWVE9ZflK2e5LD6(-1487388570 ^ -1487299672), new ColumnType(DbType.String, int.MaxValue)),
						new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3342338), new ColumnType(DbType.String, int.MaxValue))
					};
					snh15OWV2IG4IXekVN64(transform, table);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num3 = 3;
					}
					goto IL_0069;
					IL_0069:
					while (true)
					{
						switch (num3)
						{
						case 4:
							return;
						case 2:
						case 3:
							if (!TT4nT3WVOSGZA3fitOso(Transform, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16653705)))
							{
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto case 1;
						case 1:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-541731959 ^ -541847623));
							num3 = 4;
							continue;
						case 6:
							break;
						case 5:
							Transform.AddTable(new Table
							{
								Name = (string)qQNj7gWVE9ZflK2e5LD6(0x3C5338FF ^ 0x3C52846F),
								Columns = new List<Column>
								{
									new Column((string)qQNj7gWVE9ZflK2e5LD6(-1334993905 ^ -1335026429), DbType.Guid),
									new Column((string)qQNj7gWVE9ZflK2e5LD6(-1767720453 ^ -1767676421), new ColumnType(DbType.String, int.MaxValue)),
									new Column((string)qQNj7gWVE9ZflK2e5LD6(-398663332 ^ -398631430), new ColumnType(DbType.String, int.MaxValue)),
									new Column((string)qQNj7gWVE9ZflK2e5LD6(-1852837372 ^ -1852921942), DbType.DateTime),
									new Column((string)qQNj7gWVE9ZflK2e5LD6(-538519530 ^ -538508274), DbType.DateTime)
								}
							});
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num3 = 1;
							}
							continue;
						default:
						{
							ITransformationProvider transform2 = Transform;
							Table table2 = new Table();
							kvqDAfWVkSOR3ivgmmbK(table2, qQNj7gWVE9ZflK2e5LD6(0x76DD48E ^ 0x76C0F9E));
							List<Column> list = new List<Column>();
							Column column = new Column((string)qQNj7gWVE9ZflK2e5LD6(-309639236 ^ -309647314), DbType.Guid);
							dISkkPWVnCOxO0VwljM9(column, ColumnProperty.PrimaryKey);
							list.Add(column);
							list.Add(new Column((string)qQNj7gWVE9ZflK2e5LD6(0x92F12D5 ^ 0x92EC9F9), new ColumnType(DbType.String, int.MaxValue)));
							list.Add(new Column((string)qQNj7gWVE9ZflK2e5LD6(-1459557599 ^ -1459539869), DbType.DateTime));
							table2.Columns = list;
							transform2.AddTable(table2);
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						case 7:
							goto IL_040b;
						}
						break;
					}
					goto IL_00f3;
					IL_040b:
					if (TT4nT3WVOSGZA3fitOso(Transform, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87388371)))
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num3 = 2;
						}
						goto IL_0069;
					}
					goto IL_00f3;
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							throw;
						}
						NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-1123633026 ^ -1123589100), ex);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num4 = 1;
						}
					}
				}
			case 2:
				vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-606654180 ^ -606671926));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void CheckActiveUpdates()
	{
		//Discarded unreachable code: IL_014d, IL_01e2, IL_0231, IL_0240
		int num = 2;
		int num2 = num;
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				vEngZXWVXBHFkCJQvB0J(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A70E9A));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					int num3 = 0;
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 3:
							return;
						case 6:
							if (num3 >= 10)
							{
								int num6 = 2;
								num4 = num6;
							}
							else
							{
								E51rgJWVNm24mKGU77KV(6000);
								num4 = 8;
							}
							break;
						case 5:
							num5 = X8aw6XWVPjdRr5OIGREv(Transform.ExecuteScalar(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35971781)));
							num4 = 7;
							break;
						case 4:
						case 8:
							if (num5 <= 0)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 1;
						case 2:
							throw new Exception((string)WETw7WWV1OFCfFh74sto(qQNj7gWVE9ZflK2e5LD6(0x5F3078B6 ^ 0x5F31A5D6)));
						case 1:
							num3++;
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num4 = 5;
							}
							break;
						case 7:
							if (num5 <= 0)
							{
								num4 = 4;
								break;
							}
							goto case 6;
						default:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-1876063057 ^ -1876143849));
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num7 = 1;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							CNT2fQWV3u4r6xoJyGOR(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1245C158), ex);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
							{
								num7 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
			}
		}
	}

	private DbStructure[] ReadPreviousStructures()
	{
		//Discarded unreachable code: IL_00b1, IL_00f6, IL_0105, IL_0110, IL_01e6, IL_0216, IL_024e, IL_025d, IL_0289, IL_02d8
		int num = 1;
		int num2 = num;
		string text = default(string);
		DbStructure item = default(DbStructure);
		List<DbStructure> list = default(List<DbStructure>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					IDataReader dataReader = Transform.ExecuteQuery(string.Format((string)qQNj7gWVE9ZflK2e5LD6(0x53CB464B ^ 0x53CAE9E3), ((Dialect)AIPWQaWVpLAe0SqDRHaj(Transform)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538508486)), hpH7YSWVaayuA7BGat5e(AIPWQaWVpLAe0SqDRHaj(Transform), qQNj7gWVE9ZflK2e5LD6(0x3C5338FF ^ 0x3C52E3EF))));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							try
							{
								while (true)
								{
									IL_0192:
									int num4;
									if (!lgmbB4WVtNQsZ7AWBQS8(dataReader))
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
										{
											num4 = 0;
										}
										goto IL_0114;
									}
									goto IL_01b8;
									IL_01b8:
									text = CYsqmoWVD9SVfBJYXA6w(dataReader, 0) as string;
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
									{
										num4 = 1;
									}
									goto IL_0114;
									IL_0114:
									while (true)
									{
										switch (num4)
										{
										case 3:
											item = new DbStructure(text, null);
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
											{
												num4 = 2;
											}
											continue;
										case 2:
											list.Add(item);
											num4 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
											{
												num4 = 5;
											}
											continue;
										case 6:
											if (text == null)
											{
												num4 = 4;
												continue;
											}
											goto case 3;
										case 4:
										case 5:
											goto IL_0192;
										case 1:
											goto IL_01b8;
										case 0:
											break;
										}
										break;
									}
									break;
								}
							}
							finally
							{
								if (dataReader != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											RgLq98WVCgqwvpENPdQm(dataReader);
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
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
							break;
						case 2:
							goto end_IL_00b5;
						}
						vEngZXWVXBHFkCJQvB0J(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289763094));
						num3 = 2;
						continue;
						end_IL_00b5:
						break;
					}
				}
				catch (Exception exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							DbUpdateLog.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210678407), exception);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num6 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto case 3;
			default:
				list = new List<DbStructure>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return (DbStructure[])ayjIi8WVw2pIU8FBLbFu(list);
			case 1:
				vEngZXWVXBHFkCJQvB0J(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335082423));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ProcessRemovingIndexes()
	{
		//Discarded unreachable code: IL_0066, IL_019b, IL_01aa, IL_02b0, IL_02e8, IL_030e, IL_031c, IL_0476, IL_04ae, IL_04bd, IL_05ca, IL_0602, IL_0611
		int num = 2;
		int num2 = num;
		IEnumerator<DbStructure> enumerator = default(IEnumerator<DbStructure>);
		_003C_003Ec__DisplayClass57_1 _003C_003Ec__DisplayClass57_ = default(_003C_003Ec__DisplayClass57_1);
		DbStructure dbStructure = default(DbStructure);
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_2 = default(_003C_003Ec__DisplayClass57_0);
		IEnumerator<DbStructure.DbIndex> enumerator3 = default(IEnumerator<DbStructure.DbIndex>);
		DbStructure.DbIndex current2 = default(DbStructure.DbIndex);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		string current = default(string);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x3C5338FF ^ 0x3C52E7FF));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_02f2:
						int num3;
						if (!yE55KhWVQpOIplEmPfQY(enumerator))
						{
							num3 = 12;
							goto IL_0074;
						}
						goto IL_0136;
						IL_0074:
						while (true)
						{
							switch (num3)
							{
							case 14:
								_003C_003Ec__DisplayClass57_.currItemIndexes = _003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.currItem.Indexes;
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num3 = 10;
								}
								continue;
							case 8:
								_003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_1();
								num3 = 3;
								continue;
							case 9:
								if (dbStructure != null)
								{
									num3 = 6;
									continue;
								}
								goto IL_02f2;
							case 6:
								_003C_003Ec__DisplayClass57_.prevItemIndexes = dbStructure.Indexes;
								num3 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num3 = 13;
								}
								continue;
							case 4:
								break;
							case 7:
							{
								_003C_003Ec__DisplayClass57_2._003C_003E4__this = this;
								int num9 = 11;
								num3 = num9;
								continue;
							}
							case 11:
								_003C_003Ec__DisplayClass57_2.currItem = enumerator.Current;
								num3 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num3 = 7;
								}
								continue;
							default:
								try
								{
									while (true)
									{
										IL_01fa:
										int num6;
										if (!yE55KhWVQpOIplEmPfQY(enumerator3))
										{
											num6 = 4;
											goto IL_01b5;
										}
										goto IL_01d7;
										IL_0214:
										DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(-210725949 ^ -210678671), aRouyRWV4nHtrPtnMWtC(current2), oIUhdYWV6SAYNFC5iR8t(current2));
										num6 = 3;
										goto IL_01b5;
										IL_01d7:
										current2 = enumerator3.Current;
										int num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
										{
											num7 = 2;
										}
										goto IL_01b9;
										IL_01b5:
										num7 = num6;
										goto IL_01b9;
										IL_01b9:
										while (true)
										{
											switch (num7)
											{
											case 1:
												goto IL_01fa;
											case 2:
												goto IL_0214;
											case 3:
												hTjUAfWVHRpxtAVSou4P(dbMigrator, current2.Name, oIUhdYWV6SAYNFC5iR8t(current2));
												num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
												{
													num7 = 1;
												}
												continue;
											case 4:
												goto end_IL_01fa;
											}
											break;
										}
										goto IL_01d7;
										continue;
										end_IL_01fa:
										break;
									}
								}
								finally
								{
									if (enumerator3 != null)
									{
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
										{
											num8 = 1;
										}
										while (true)
										{
											switch (num8)
											{
											case 1:
												RgLq98WVCgqwvpENPdQm(enumerator3);
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
												{
													num8 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto IL_02f2;
							case 2:
								goto IL_02f2;
							case 5:
								try
								{
									while (true)
									{
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
											{
												num4 = 0;
											}
											goto IL_0320;
										}
										goto IL_042d;
										IL_042d:
										current = enumerator2.Current;
										num4 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
										{
											num4 = 6;
										}
										goto IL_0320;
										IL_0320:
										while (true)
										{
											switch (num4)
											{
											case 6:
												text2 = (string)aRouyRWV4nHtrPtnMWtC(_003C_003Ec__DisplayClass57_.prevItemIndexes[current]);
												num4 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
												{
													num4 = 4;
												}
												continue;
											case 5:
												DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(-234299632 ^ -234291110), text2, text);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
												{
													num4 = 0;
												}
												continue;
											default:
												hTjUAfWVHRpxtAVSou4P(dbMigrator, text2, text);
												num4 = 3;
												continue;
											case 3:
												break;
											case 4:
												text = (string)oIUhdYWV6SAYNFC5iR8t(_003C_003Ec__DisplayClass57_.prevItemIndexes[current]);
												num4 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
												{
													num4 = 3;
												}
												continue;
											case 2:
												goto IL_042d;
											case 1:
												goto end_IL_03d8;
											}
											break;
										}
										continue;
										end_IL_03d8:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											default:
												RgLq98WVCgqwvpENPdQm(enumerator2);
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
												{
													num5 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto case 1;
							case 1:
								enumerator3 = _003C_003Ec__DisplayClass57_.prevItemIndexes.Keys.Intersect(_003C_003Ec__DisplayClass57_.currItemIndexes.Keys).Where(_003C_003Ec__DisplayClass57_._003CProcessRemovingIndexes_003Eb__2).Select(_003C_003Ec__DisplayClass57_._003CProcessRemovingIndexes_003Eb__3)
									.GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num3 = 0;
								}
								continue;
							case 10:
								enumerator2 = _003C_003Ec__DisplayClass57_.prevItemIndexes.Keys.Except(_003C_003Ec__DisplayClass57_.currItemIndexes.Keys).GetEnumerator();
								num3 = 5;
								continue;
							case 13:
								dbStructure = prevStructures.FirstOrDefault((DbStructure s) => _003C_003Ec__DisplayClass57_0.d5Z42xQDgLJSqUn1PAIe(s.Uid, _003C_003Ec__DisplayClass57_0.uSKVRKQDrZIN14wtL11C(_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.currItem)));
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num3 = 9;
								}
								continue;
							case 3:
								_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass57_2;
								num3 = 13;
								continue;
							case 12:
								return;
							}
							break;
						}
						goto IL_0136;
						IL_0136:
						_003C_003Ec__DisplayClass57_2 = new _003C_003Ec__DisplayClass57_0();
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num3 = 7;
						}
						goto IL_0074;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								RgLq98WVCgqwvpENPdQm(enumerator);
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num10 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 1:
				enumerator = structures.Where((DbStructure s) => !s.Deactivating).GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private bool IsIndexChanged(DbStructure.DbIndex left, DbStructure.DbIndex right)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (rd8xBYWVAyHZcocv6QUY(left) == rd8xBYWVAyHZcocv6QUY(right))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			default:
				return yp935jWVGwVVyow1A7UY(GEZFPbWV7joBsaaOxwQl(left), GEZFPbWV7joBsaaOxwQl(right));
			case 1:
				return true;
			case 4:
				if (left.Columns.SequenceEqual(right.Columns))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				if (left.TableName != (string)oIUhdYWV6SAYNFC5iR8t(right))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private void ExecuteIndexes()
	{
		//Discarded unreachable code: IL_005a, IL_006b, IL_021a, IL_0229, IL_0239, IL_0248, IL_0257, IL_029f, IL_02ae, IL_038d, IL_039c, IL_0418, IL_042b, IL_043a
		int num = 3;
		int num2 = num;
		Dictionary<string, DbStructure.DbIndex>.ValueCollection.Enumerator enumerator = default(Dictionary<string, DbStructure.DbIndex>.ValueCollection.Enumerator);
		DbStructure.DbIndex current = default(DbStructure.DbIndex);
		Index index = default(Index);
		List<string> list = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			default:
				enumerator = currStruct.Indexes.Values.GetEnumerator();
				num2 = 5;
				break;
			case 1:
				return;
			case 5:
				try
				{
					while (true)
					{
						IL_0344:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 14;
							goto IL_0079;
						}
						goto IL_0121;
						IL_0079:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 14:
								return;
							case 8:
								DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(0x1637C429 ^ 0x16362433), aRouyRWV4nHtrPtnMWtC(current), oIUhdYWV6SAYNFC5iR8t(current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
								{
									num3 = 0;
								}
								continue;
							case 16:
								break;
							default:
								if (!Jhj8UDWVxB9BnQIFFPCi(Transform, oIUhdYWV6SAYNFC5iR8t(current), aRouyRWV4nHtrPtnMWtC(current)))
								{
									num3 = 6;
									continue;
								}
								goto case 12;
							case 4:
								DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(-643786247 ^ -643729123), aRouyRWV4nHtrPtnMWtC(current), current.TableName);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num3 = 1;
								}
								continue;
							case 17:
								DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(0x637E299B ^ 0x637FC9F5), aRouyRWV4nHtrPtnMWtC(current), oIUhdYWV6SAYNFC5iR8t(current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
							case 15:
								jJIA5lWVdMmBfdeLcpfk(current, B9bmkkWV9OKwQBoMOKmD(GEZFPbWV7joBsaaOxwQl(current)));
								num3 = 11;
								continue;
							case 18:
							{
								Index index2 = new Index();
								LCfn1wWVMnI3RmZGtSaI(index2, aRouyRWV4nHtrPtnMWtC(current));
								SarcmXWVJFwcSkZhPXeM(index2, current.TableName);
								index2.Columns = current.Columns;
								index = index2;
								num3 = 19;
								continue;
							}
							case 12:
								if (!list.Contains((string)Xp4MccWVmNRd7HXMJApW(N2KmpNWV0yaCegl1DxNc(oIUhdYWV6SAYNFC5iR8t(current)), qQNj7gWVE9ZflK2e5LD6(0x53CACA3 ^ 0x53D4CC5), N2KmpNWV0yaCegl1DxNc(aRouyRWV4nHtrPtnMWtC(current)))))
								{
									num3 = 17;
									continue;
								}
								goto case 4;
							case 19:
								dbMigrator.CreateStandardIndex(index, rd8xBYWVAyHZcocv6QUY(current));
								num4 = 10;
								goto IL_0075;
							case 2:
								Transform.RemoveIndex((string)oIUhdYWV6SAYNFC5iR8t(current), (string)aRouyRWV4nHtrPtnMWtC(current));
								num3 = 9;
								continue;
							case 1:
							case 13:
								goto IL_0344;
							case 11:
								dbMigrator.CreateNonStandardIndex((string)aRouyRWV4nHtrPtnMWtC(current), current.TableName, current.Text);
								num4 = 5;
								goto IL_0075;
							case 6:
							case 7:
							case 9:
								if (!dwRtOJWVy5Dkxt1VmNvP(current.Text))
								{
									num3 = 3;
									continue;
								}
								goto case 18;
							case 5:
							case 10:
								{
									vEngZXWVXBHFkCJQvB0J(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123591904));
									num3 = 13;
									continue;
								}
								IL_0075:
								num3 = num4;
								continue;
							}
							break;
						}
						goto IL_0121;
						IL_0121:
						current = enumerator.Current;
						num3 = 8;
						goto IL_0079;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 3:
				if (recreateConstraints)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 4:
				return;
			case 2:
				list = prevStruct.Indexes.Values.Select((DbStructure.DbIndex idx) => (string)_003C_003Ec.fnIseEQDVnfULgDsXRVw(_003C_003Ec.gMobmCQDuFMkWD9j6Vvf(_003C_003Ec.pYoeEyQDZMHgvXgTclCI(idx)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978425491), ((string)_003C_003Ec.UnJQ3fQDINu7hPKTC9H7(idx)).ToUpperInvariant())).ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ExecuteScriptsAndMethods(DbStructure.ExecuteTime executeTime)
	{
		int num = 3;
		int num2 = num;
		Func<DbStructure.DbScript, string> scriptExecutor = default(Func<DbStructure.DbScript, string>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 2:
				scriptExecutor = GetScriptExecutor(executeTime);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ExecuteScripts(executeTime, scriptExecutor);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!recreateConstraints)
				{
					return;
				}
				num2 = 2;
				break;
			case 1:
				ExecuteMethods(executeTime);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void ExecuteMethods(DbStructure.ExecuteTime executeTime)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00dd, IL_00ec, IL_018c, IL_01d6, IL_020e, IL_021d
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass61_0 _003C_003Ec__DisplayClass61_ = default(_003C_003Ec__DisplayClass61_0);
		IEnumerator<DbStructure.UserMethod> enumerator = default(IEnumerator<DbStructure.UserMethod>);
		DbStructure.UserMethod current = default(DbStructure.UserMethod);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_003C_003Ec__DisplayClass61_.executeTime = executeTime;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				try
				{
					while (true)
					{
						IL_019a:
						int num3;
						if (!yE55KhWVQpOIplEmPfQY(enumerator))
						{
							num3 = 8;
							goto IL_0077;
						}
						goto IL_011f;
						IL_0077:
						while (true)
						{
							switch (num3)
							{
							case 8:
								return;
							case 9:
								if (!QgKgbDWVYqba382hDJhV(p51195WVj7KGOpfGfJ25(RuntimeApplication)))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto IL_019a;
							case 6:
								if (pSY925WVlLWy7O3BxhuW(current))
								{
									num3 = 3;
									continue;
								}
								goto case 1;
							case 4:
							case 7:
								ExecuteMethod(current);
								num3 = 5;
								continue;
							case 2:
							case 3:
								if (eFI9SXWV5y9MWZ2nwUmQ(current) == null)
								{
									num3 = 7;
									continue;
								}
								goto case 9;
							case 1:
								if (!prevStruct.Methods.ContainsKey((string)TwwlJLWVgc0DAr75gQs5(rswcomWVr5UcjEfNMjCo(current))))
								{
									int num4 = 2;
									num3 = num4;
									continue;
								}
								goto IL_019a;
							case 5:
								goto IL_019a;
							}
							break;
						}
						goto IL_011f;
						IL_011f:
						current = enumerator.Current;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num3 = 6;
						}
						goto IL_0077;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								RgLq98WVCgqwvpENPdQm(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 3:
				_003C_003Ec__DisplayClass61_ = new _003C_003Ec__DisplayClass61_0();
				num2 = 2;
				break;
			case 1:
				enumerator = currStruct.Methods.Values.Where(_003C_003Ec__DisplayClass61_._003CExecuteMethods_003Eb__0).GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void ExecuteScripts(DbStructure.ExecuteTime executeTime, Func<DbStructure.DbScript, string> scriptExecutionFunc)
	{
		_003C_003Ec__DisplayClass62_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass62_0();
		CS_0024_003C_003E8__locals0.executeTime = executeTime;
		foreach (DbStructure.DbScript item in currStruct.Scripts.Values.Where((DbStructure.DbScript s) => _003C_003Ec__DisplayClass62_0.boOp8QQto5YGq1wwrKPp(s) == CS_0024_003C_003E8__locals0.executeTime))
		{
			if ((item.AlwaysExecute || !prevStruct.Scripts.ContainsKey(item.Name.ToUpper())) && (item.TransformationInVersion == null || !RuntimeApplication.DbPreUpdater.IsFirstStart))
			{
				DbUpdateLog.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70113677), item.Name));
				string text = scriptExecutionFunc(item);
				string message = (string.IsNullOrEmpty(text) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951523318) : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541838809), text));
				DbUpdateLog.Debug(message);
			}
		}
	}

	private Func<DbStructure.DbScript, string> GetScriptExecutor(DbStructure.ExecuteTime executeTime)
	{
		if (executeTime == DbStructure.ExecuteTime.OnIndexesCreated)
		{
			return ExecuteScriptOnIndexesCreated;
		}
		return ExecuteScript;
	}

	private string ExecuteScriptOnIndexesCreated(DbStructure.DbScript script)
	{
		//Discarded unreachable code: IL_00ef, IL_00fe
		int num = 1;
		string result = default(string);
		Index index = default(Index);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					result = (string)qQNj7gWVE9ZflK2e5LD6(0x4D1C1EE4 ^ 0x4D1DFCEA);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				case 7:
					return result;
				default:
					KRD8mJWVUveLI74wiyE0(script, B9bmkkWV9OKwQBoMOKmD(nhHxwiWVLkHhCW85NNtX(script)));
					num2 = 6;
					continue;
				case 8:
					if (Transform.IndexExists((string)ziTLYEWVcjvaLECfAfhV(index), index.Name))
					{
						num2 = 3;
						continue;
					}
					break;
				case 5:
					if (index != null)
					{
						num2 = 8;
						continue;
					}
					break;
				case 6:
					goto end_IL_0012;
				case 1:
					result = string.Empty;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				}
				Transform.ExecuteNonQuery((string)nhHxwiWVLkHhCW85NNtX(script));
				num2 = 7;
				continue;
				end_IL_0012:
				break;
			}
			index = (Index)LAQgoKWVs0uOvrYT2hZ7(Transform, script.Text);
			num = 5;
		}
	}

	private string ExecuteScript(DbStructure.DbScript script)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Transform.ExecuteNonQuery((string)nhHxwiWVLkHhCW85NNtX(script));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				KRD8mJWVUveLI74wiyE0(script, B9bmkkWV9OKwQBoMOKmD(nhHxwiWVLkHhCW85NNtX(script)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return string.Empty;
			}
		}
	}

	private void ExecuteMethod(DbStructure.UserMethod method)
	{
		//Discarded unreachable code: IL_005a, IL_0157, IL_022c, IL_025c, IL_02ac, IL_02bb
		int num = 2;
		ISession val = default(ISession);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					try
					{
						int num3;
						if (!jEKjL4WSFDAZAPHgSJhu(DbUpdateLog))
						{
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num3 = 2;
							}
							goto IL_005e;
						}
						goto IL_0084;
						IL_0084:
						vEngZXWVXBHFkCJQvB0J(DbUpdateLog, s6xWUvWSWO1qJFF6of25(qQNj7gWVE9ZflK2e5LD6(0x8317432 ^ 0x8309694), method.MethodExecutor.GetType().FullName, Tsv21xWSBbljYeFkR0Nf(method)));
						num3 = 2;
						goto IL_005e;
						IL_005e:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 5:
								break;
							case 6:
								if (jEKjL4WSFDAZAPHgSJhu(DbUpdateLog))
								{
									num3 = 4;
									continue;
								}
								return;
							case 1:
								np92OuWShsBlGtVeBmBn(val);
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num3 = 1;
								}
								continue;
							case 4:
								vEngZXWVXBHFkCJQvB0J(DbUpdateLog, s6xWUvWSWO1qJFF6of25(qQNj7gWVE9ZflK2e5LD6(0x7247028A ^ 0x7246E19E), oHNl97WVztXUIpveWOA2(method).GetType().FullName, method.Method));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
							case 3:
							{
								MethodInfo method2 = oHNl97WVztXUIpveWOA2(method).GetType().GetMethod(method.Method, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
								if (jWh1YcWSoK1AfCojkFql(method2, null))
								{
									throw new DbStructureException(string.Format((string)WETw7WWV1OFCfFh74sto(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870819095)), method.MethodExecutor.GetType().FullName, Tsv21xWSBbljYeFkR0Nf(method)));
								}
								val = (ISession)vuZkVVWSbue3itFK5S1J(SessionProvider, "");
								method2.Invoke(oHNl97WVztXUIpveWOA2(method), new object[0]);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num3 = 1;
								}
								continue;
							}
							case 0:
								return;
							}
							break;
						}
						goto IL_0084;
					}
					catch (DbStructureException)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							throw;
						}
					}
					catch (Exception innerException)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						default:
							throw new DbStructureException((string)s6xWUvWSWO1qJFF6of25(WETw7WWV1OFCfFh74sto(qQNj7gWVE9ZflK2e5LD6(-195614443 ^ -195638689)), oHNl97WVztXUIpveWOA2(method).GetType().FullName, Tsv21xWSBbljYeFkR0Nf(method)), innerException);
						}
					}
				case 2:
					if (oHNl97WVztXUIpveWOA2(method) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 1;
						}
						break;
					}
					if (oHNl97WVztXUIpveWOA2(method) == null)
					{
						return;
					}
					goto end_IL_0012;
				case 1:
					throw new DbStructureException(SR.T((string)qQNj7gWVE9ZflK2e5LD6(0x53FA00CE ^ 0x53FBE2F2), rswcomWVr5UcjEfNMjCo(method)));
				case 0:
					return;
				case 4:
					if (dwRtOJWVy5Dkxt1VmNvP(method.Method))
					{
						return;
					}
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private void DeleteTriggers()
	{
		//Discarded unreachable code: IL_008a, IL_00b2, IL_00c1, IL_00cc, IL_0190, IL_01a3, IL_0252, IL_02a6
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = default(_003C_003Ec__DisplayClass67_0);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ExecuteHandlers(_003C_003Ec__DisplayClass67_._003CDeleteTriggers_003Eb__0);
				num2 = 6;
				break;
			case 6:
				try
				{
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x3CE17B75 ^ 0x3CE098E3));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							try
							{
								while (true)
								{
									IL_011b:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
										{
											num4 = 0;
										}
										goto IL_00d0;
									}
									goto IL_0141;
									IL_0141:
									current = enumerator.Current;
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
									{
										num4 = 1;
									}
									goto IL_00d0;
									IL_00d0:
									while (true)
									{
										switch (num4)
										{
										case 1:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, MrPGydWSG16ra010xmQh(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195638569), current));
											num4 = 2;
											continue;
										case 2:
											goto IL_011b;
										case 3:
											goto IL_0141;
										case 0:
											break;
										}
										break;
									}
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							break;
						case 3:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-1767720453 ^ -1767679471));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num3 = 1;
							}
							continue;
						default:
							enumerator = _003C_003Ec__DisplayClass67_.e.SkipNames.GetEnumerator();
							num3 = 4;
							continue;
						case 2:
							break;
						case 1:
							goto end_IL_008e;
						}
						Transform.RemoveTriggers(_003C_003Ec__DisplayClass67_.e.SkipNames);
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num3 = 2;
						}
						continue;
						end_IL_008e:
						break;
					}
				}
				catch (Exception ex)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x7C1EE318 ^ 0x7C1F0716), ex);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num6 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto case 5;
			case 3:
				_003C_003Ec__DisplayClass67_.e = new TriggersDeletingEventArgs();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 5:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTriggersDeleted);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					_003C_003Ec.HqorELQDSVDgRheosaJS(h);
				});
				num2 = 2;
				break;
			}
		}
	}

	private void DeleteProcedures()
	{
		//Discarded unreachable code: IL_00ad, IL_00b7, IL_018b, IL_019e, IL_0230, IL_0284
		int num = 2;
		int num2 = num;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		_003C_003Ec__DisplayClass68_0 _003C_003Ec__DisplayClass68_ = default(_003C_003Ec__DisplayClass68_0);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 4:
				try
				{
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x1A33FE36 ^ 0x1A321A70));
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 2:
						{
							enumerator = _003C_003Ec__DisplayClass68_.e.SkipNames.GetEnumerator();
							int num4 = 4;
							num3 = num4;
							continue;
						}
						case 4:
							try
							{
								while (true)
								{
									IL_0116:
									int num5;
									if (!enumerator.MoveNext())
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
										{
											num5 = 0;
										}
										goto IL_00bb;
									}
									goto IL_013c;
									IL_013c:
									current = enumerator.Current;
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
									{
										num5 = 0;
									}
									goto IL_00bb;
									IL_00bb:
									while (true)
									{
										switch (num5)
										{
										case 1:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, string.Format((string)qQNj7gWVE9ZflK2e5LD6(0x63ABA4E8 ^ 0x63AA409E), current));
											num5 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
											{
												num5 = 1;
											}
											continue;
										case 2:
											goto IL_0116;
										case 3:
											goto IL_013c;
										case 0:
											break;
										}
										break;
									}
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							goto case 3;
						case 3:
							Transform.RemoveProcedures(_003C_003Ec__DisplayClass68_.e.SkipNames);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							DbUpdateLog.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138069286));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
				catch (Exception exception)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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
						DbUpdateLog.Error(qQNj7gWVE9ZflK2e5LD6(-3333094 ^ -3358512), exception);
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num7 = 0;
						}
					}
				}
				goto case 5;
			default:
				ExecuteHandlers(_003C_003Ec__DisplayClass68_._003CDeleteProcedures_003Eb__0);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass68_ = new _003C_003Ec__DisplayClass68_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass68_.e = new ProceduresDeletingEventArgs();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnProceduresDeleted);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					h.OnProceduresDeleted();
				});
				num2 = 6;
				break;
			}
		}
	}

	private void DeleteViews()
	{
		//Discarded unreachable code: IL_00f3, IL_0101, IL_01cf, IL_01e2, IL_01f1, IL_0270, IL_02be, IL_02cd
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = default(_003C_003Ec__DisplayClass69_0);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 6:
				ExecuteHandlers(_003C_003Ec__DisplayClass69_._003CDeleteViews_003Eb__0);
				num2 = 5;
				break;
			case 2:
				_003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				try
				{
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-1633514411 ^ -1633457837));
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						default:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-978351861 ^ -978424763));
							num3 = 3;
							continue;
						case 4:
							try
							{
								while (true)
								{
									int num5;
									if (!enumerator.MoveNext())
									{
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
										{
											num5 = 2;
										}
										goto IL_0105;
									}
									goto IL_0180;
									IL_0180:
									current = enumerator.Current;
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
									{
										num5 = 0;
									}
									goto IL_0105;
									IL_0105:
									while (true)
									{
										switch (num5)
										{
										case 1:
											break;
										default:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, MrPGydWSG16ra010xmQh(qQNj7gWVE9ZflK2e5LD6(0xD3DEF7E ^ 0xD3C0A52), current));
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
											{
												num5 = 1;
											}
											continue;
										case 3:
											goto IL_0180;
										case 2:
											goto end_IL_011f;
										}
										break;
									}
									continue;
									end_IL_011f:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							break;
						case 2:
						{
							enumerator = _003C_003Ec__DisplayClass69_.e.SkipNames.GetEnumerator();
							int num4 = 4;
							num3 = num4;
							continue;
						}
						case 1:
							break;
						case 3:
							goto end_IL_00a5;
						}
						Transform.RemoveViews(_003C_003Ec__DisplayClass69_.e.SkipNames);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num3 = 0;
						}
						continue;
						end_IL_00a5:
						break;
					}
				}
				catch (Exception exception)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
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
						DbUpdateLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787380215), exception);
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num7 = 1;
						}
					}
				}
				goto default;
			default:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnViewsDeleted);
				num2 = 4;
				break;
			case 1:
				_003C_003Ec__DisplayClass69_.e = new ViewsDeletingEventArgs();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 6;
				}
				break;
			case 3:
				return;
			case 4:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					_003C_003Ec.Y2UukKQDiDaN5pK2FSQL(h);
				});
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private void DeleteIndexes()
	{
		//Discarded unreachable code: IL_00f2, IL_0101, IL_010c, IL_01ca, IL_01dd, IL_02bd, IL_0311, IL_0320
		int num = 4;
		_003C_003Ec__DisplayClass70_0 _003C_003Ec__DisplayClass70_ = default(_003C_003Ec__DisplayClass70_0);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		List<string> list = default(List<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					ExecuteHandlers(_003C_003Ec__DisplayClass70_._003CDeleteIndexes_003Eb__0);
					num2 = 5;
					continue;
				case 3:
					_003C_003Ec__DisplayClass70_.e = new IndexesDeletingEventArgs();
					num2 = 6;
					continue;
				case 1:
					ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnIndexesDeleted);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass70_ = new _003C_003Ec__DisplayClass70_0();
					num2 = 3;
					continue;
				case 5:
					try
					{
						vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-606654180 ^ -606677886));
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								goto end_IL_00ca;
							case 3:
								try
								{
									while (true)
									{
										IL_0178:
										int num5;
										if (!enumerator.MoveNext())
										{
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
											{
												num5 = 2;
											}
											goto IL_0110;
										}
										goto IL_0165;
										IL_0165:
										current = enumerator.Current;
										num5 = 2;
										goto IL_0110;
										IL_0110:
										while (true)
										{
											switch (num5)
											{
											case 2:
												vEngZXWVXBHFkCJQvB0J(DbUpdateLog, MrPGydWSG16ra010xmQh(qQNj7gWVE9ZflK2e5LD6(-218496594 ^ -218373018), current));
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
												{
													num5 = 0;
												}
												continue;
											case 1:
												break;
											default:
												goto IL_0178;
											case 3:
												goto end_IL_0178;
											}
											break;
										}
										goto IL_0165;
										continue;
										end_IL_0178:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								break;
							case 1:
								enumerator = list.GetEnumerator();
								num4 = 3;
								continue;
							case 4:
								vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-281842504 ^ -281900716));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								list = _003C_003Ec__DisplayClass70_.e.SkipNames.Union(new string[1] { (string)qQNj7gWVE9ZflK2e5LD6(-195614443 ^ -195649695) }).ToList();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num4 = 1;
								}
								continue;
							case 5:
								break;
							case 0:
								goto end_IL_00ca;
							}
							Transform.RemoveIndexes(list);
							num4 = 4;
							continue;
							end_IL_00ca:
							break;
						}
					}
					catch (Exception exception)
					{
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
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
							DbUpdateLog.Error(qQNj7gWVE9ZflK2e5LD6(-3333094 ^ -3358188), exception);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num7 = 1;
							}
						}
					}
					goto case 1;
				case 2:
					return;
				default:
					ExecuteHandlers(delegate(IDbUpdateHandler h)
					{
						_003C_003Ec.irKvyTQDRQFD3XYbrUGN(h);
					});
					num = 2;
					break;
				}
				break;
			}
		}
	}

	private void DeleteForeignKeys()
	{
		//Discarded unreachable code: IL_006e, IL_00f5, IL_00ff, IL_01cd, IL_01e0, IL_022f, IL_027d, IL_028c
		int num = 3;
		int num2 = num;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		_003C_003Ec__DisplayClass71_0 _003C_003Ec__DisplayClass71_ = default(_003C_003Ec__DisplayClass71_0);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				try
				{
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x7459E02 ^ 0x7447846));
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							enumerator = _003C_003Ec__DisplayClass71_.e.SkipNames.GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							Transform.RemoveForeignKeys(_003C_003Ec__DisplayClass71_.e.SkipNames);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num3 = 1;
							}
							continue;
						default:
							try
							{
								while (true)
								{
									IL_0158:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
										{
											num4 = 0;
										}
										goto IL_0103;
									}
									goto IL_017e;
									IL_017e:
									current = enumerator.Current;
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num4 = 1;
									}
									goto IL_0103;
									IL_0103:
									while (true)
									{
										switch (num4)
										{
										case 2:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, MrPGydWSG16ra010xmQh(qQNj7gWVE9ZflK2e5LD6(-1487388570 ^ -1487296994), current));
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
											{
												num4 = 1;
											}
											continue;
										case 1:
											goto IL_0158;
										case 3:
											goto IL_017e;
										case 0:
											break;
										}
										break;
									}
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							goto case 4;
						case 1:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x57A5235E ^ 0x57A4C5F6));
							num3 = 3;
							continue;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							DbUpdateLog.Error(qQNj7gWVE9ZflK2e5LD6(-1088304168 ^ -1088410356), exception);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num6 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto default;
			case 3:
				_003C_003Ec__DisplayClass71_ = new _003C_003Ec__DisplayClass71_0();
				num2 = 2;
				break;
			case 4:
				return;
			case 1:
				ExecuteHandlers(_003C_003Ec__DisplayClass71_._003CDeleteForeignKeys_003Eb__0);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 5;
				}
				break;
			default:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnForeignKeysDeleted);
				num2 = 6;
				break;
			case 2:
				_003C_003Ec__DisplayClass71_.e = new ForeginKeysDeletingEventArgs();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					h.OnForeignKeysDeleted();
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void DeletePrimaryKeys()
	{
		//Discarded unreachable code: IL_0093, IL_00dd, IL_00ec, IL_00f7, IL_01a6, IL_01b9, IL_01c8, IL_025b, IL_02aa
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass72_0 _003C_003Ec__DisplayClass72_ = default(_003C_003Ec__DisplayClass72_0);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass72_.e = new PrimaryKeysDeletingEventArgs();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				try
				{
					DbUpdateLog.Debug(qQNj7gWVE9ZflK2e5LD6(-97972138 ^ -97978558));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							Transform.RemovePrimaryKeys(_003C_003Ec__DisplayClass72_.e.SkipNames);
							num3 = 4;
							continue;
						default:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 2;
										goto IL_00fb;
									}
									goto IL_0157;
									IL_00fb:
									while (true)
									{
										switch (num4)
										{
										case 1:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, MrPGydWSG16ra010xmQh(qQNj7gWVE9ZflK2e5LD6(-281842504 ^ -281900048), current));
											num4 = 3;
											continue;
										case 3:
											break;
										default:
											goto IL_0157;
										case 2:
											goto end_IL_0141;
										}
										break;
									}
									continue;
									IL_0157:
									current = enumerator.Current;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
									{
										num4 = 1;
									}
									goto IL_00fb;
									continue;
									end_IL_0141:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							goto case 2;
						case 4:
							DbUpdateLog.Debug(qQNj7gWVE9ZflK2e5LD6(0x6A81B9B4 ^ 0x6A805ECC));
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							enumerator = _003C_003Ec__DisplayClass72_.e.SkipNames.GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-2138160520 ^ -2138069540), ex);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num6 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto case 2;
			case 2:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnPrimaryKeysDeleted);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				ExecuteHandlers(_003C_003Ec__DisplayClass72_._003CDeletePrimaryKeys_003Eb__0);
				num2 = 6;
				break;
			case 5:
				_003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_0();
				num2 = 4;
				break;
			default:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					_003C_003Ec.HttVIyQDqIyGv4HPcteM(h);
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void CreateTables()
	{
		//Discarded unreachable code: IL_00c4, IL_0135, IL_0189, IL_0198
		int num = 2;
		_003C_003Ec__DisplayClass73_0 _003C_003Ec__DisplayClass73_ = default(_003C_003Ec__DisplayClass73_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass73_.e = new TablesCreatingEventArgs();
					num2 = 7;
					continue;
				case 7:
					break;
				case 3:
					return;
				case 2:
					_003C_003Ec__DisplayClass73_ = new _003C_003Ec__DisplayClass73_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					try
					{
						vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x1A33FE36 ^ 0x1A3219D2));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-1108654032 ^ -1108697080));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
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
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								throw;
							}
							NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x53CB464B ^ 0x53CAAEC9), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num4 = 1;
							}
						}
					}
					goto default;
				default:
					ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesCreated);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 5;
					}
					continue;
				case 6:
					ExecuteHandlers(_003C_003Ec__DisplayClass73_._003CCreateTables_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					ExecuteHandlers(delegate(IDbUpdateHandler h)
					{
						h.OnTablesCreated();
					});
					num2 = 3;
					continue;
				}
				break;
			}
			ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesCreating);
			num = 6;
		}
	}

	private void DeleteTables()
	{
		//Discarded unreachable code: IL_00c7, IL_0138, IL_0186
		int num = 3;
		_003C_003Ec__DisplayClass74_0 _003C_003Ec__DisplayClass74_ = default(_003C_003Ec__DisplayClass74_0);
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
					ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesDeleted);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					break;
				case 0:
					return;
				case 3:
					_003C_003Ec__DisplayClass74_ = new _003C_003Ec__DisplayClass74_0();
					num2 = 2;
					continue;
				case 5:
					try
					{
						DbUpdateLog.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488789217));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-3333094 ^ -3355336));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x269E5FCA ^ 0x269FB6A2), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num4 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto case 4;
				case 1:
					ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTablesDeleting);
					num2 = 6;
					continue;
				case 2:
					_003C_003Ec__DisplayClass74_.e = new TablesDeletingEventArgs();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					ExecuteHandlers(delegate(IDbUpdateHandler h)
					{
						h.OnTablesDeleted();
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			ExecuteHandlers(_003C_003Ec__DisplayClass74_._003CDeleteTables_003Eb__0);
			num = 5;
		}
	}

	private void CreateForeignKeys()
	{
		//Discarded unreachable code: IL_0084, IL_00f0, IL_0144, IL_0153
		int num = 5;
		_003C_003Ec__DisplayClass75_0 _003C_003Ec__DisplayClass75_ = default(_003C_003Ec__DisplayClass75_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass75_ = new _003C_003Ec__DisplayClass75_0();
					num2 = 4;
					continue;
				case 3:
					try
					{
						vEngZXWVXBHFkCJQvB0J(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195641169));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(--1333735954 ^ 0x4F7EDBFC));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-576149596 ^ -576107074), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num4 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto default;
				default:
					ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnForeignKeysCreated);
					num = 2;
					break;
				case 4:
					_003C_003Ec__DisplayClass75_.e = new ForeignKeysCreatingEventArgs();
					num = 6;
					break;
				case 6:
					ExecuteHandlers(_003C_003Ec__DisplayClass75_._003CCreateForeignKeys_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					return;
				case 2:
					ExecuteHandlers(delegate(IDbUpdateHandler h)
					{
						_003C_003Ec.WO3GEKQDKbTpD5imx5tQ(h);
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private void CreatePrimaryKeys()
	{
		//Discarded unreachable code: IL_00b6, IL_0121, IL_0175
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass76_0 _003C_003Ec__DisplayClass76_ = default(_003C_003Ec__DisplayClass76_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 4:
				_003C_003Ec__DisplayClass76_ = new _003C_003Ec__DisplayClass76_0();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass76_.e = new PrimaryKeysCreatingEventArgs();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				try
				{
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-812025778 ^ -812084748));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x1ECE530A ^ 0x1ECFBAE4));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch (Exception exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							DbUpdateLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A410DD), exception);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto case 2;
			case 2:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnPrimaryKeysCreated);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			default:
				ExecuteHandlers(_003C_003Ec__DisplayClass76_._003CCreatePrimaryKeys_003Eb__0);
				num2 = 5;
				break;
			case 1:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					h.OnPrimaryKeysCreated();
				});
				num2 = 6;
				break;
			}
		}
	}

	private void CreateIndexes()
	{
		//Discarded unreachable code: IL_00ab, IL_012a, IL_0178, IL_0187
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass77_0 _003C_003Ec__DisplayClass77_ = default(_003C_003Ec__DisplayClass77_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass77_ = new _003C_003Ec__DisplayClass77_0();
				num2 = 5;
				break;
			case 2:
				ExecuteHandlers(_003C_003Ec__DisplayClass77_._003CCreateIndexes_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					DbUpdateLog.Debug(qQNj7gWVE9ZflK2e5LD6(-1858887263 ^ -1858974733));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x53CACA3 ^ 0x53D46DF));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							ExecuteIndexes();
							num3 = 2;
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (Exception exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							DbUpdateLog.Error(qQNj7gWVE9ZflK2e5LD6(-787452571 ^ -787380229), exception);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto default;
			default:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnIndexesCreated);
				num2 = 3;
				break;
			case 5:
				_003C_003Ec__DisplayClass77_.e = new IndexesCreatingEventArgs();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 3:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					_003C_003Ec.Fn8ObQQDXT4vgUhYIdhQ(h);
				});
				num2 = 4;
				break;
			}
		}
	}

	private void CreateViews()
	{
		//Discarded unreachable code: IL_008f, IL_011e, IL_012d, IL_0191, IL_01a0, IL_0262, IL_0295, IL_02da, IL_034e, IL_0361, IL_0370, IL_039c, IL_03ea, IL_03f9
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = default(_003C_003Ec__DisplayClass78_0);
		Dictionary<string, DbStructure.DbView>.ValueCollection.Enumerator enumerator = default(Dictionary<string, DbStructure.DbView>.ValueCollection.Enumerator);
		DbStructure.DbView current = default(DbStructure.DbView);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				_003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				try
				{
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x5F3078B6 ^ 0x5F31927A));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x1A33FE36 ^ 0x1A3215BE));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							enumerator = currStruct.Views.Values.GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num3 = 0;
							}
							continue;
						default:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num4 = 5;
										}
										goto IL_013c;
									}
									goto IL_0210;
									IL_0210:
									current = enumerator.Current;
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
									{
										num4 = 1;
									}
									goto IL_013c;
									IL_013c:
									while (true)
									{
										switch (num4)
										{
										case 1:
										case 6:
											break;
										case 4:
											if (dwRtOJWVy5Dkxt1VmNvP(K2xys8WSE8CbtA3AXOrc(current)))
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
												{
													num4 = 1;
												}
												continue;
											}
											goto default;
										default:
										{
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, MrPGydWSG16ra010xmQh(qQNj7gWVE9ZflK2e5LD6(-576149596 ^ -576107178), NQdqSdWSfEouMw2s6NjR(current)));
											int num7 = 7;
											num4 = num7;
											continue;
										}
										case 2:
											goto IL_0210;
										case 7:
											try
											{
												Transform.ExecuteNonQuery((string)K2xys8WSE8CbtA3AXOrc(current));
												int num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
												{
													num5 = 0;
												}
												switch (num5)
												{
												case 0:
													break;
												}
											}
											catch (Exception innerException)
											{
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
												{
													num6 = 0;
												}
												switch (num6)
												{
												default:
													throw new DbStructureException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459552195), NQdqSdWSfEouMw2s6NjR(current)), innerException);
												}
											}
											goto case 3;
										case 3:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, gYhdXMWSQHpF3bZOF9Dg(qQNj7gWVE9ZflK2e5LD6(-1638402543 ^ -1638523523), Array.Empty<object>()));
											num4 = 6;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
											{
												num4 = 6;
											}
											continue;
										case 5:
											goto end_IL_0166;
										}
										break;
									}
									continue;
									end_IL_0166:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
							}
							goto case 3;
						case 2:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num9 = 0;
					}
					while (true)
					{
						switch (num9)
						{
						case 1:
							throw;
						}
						NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x61EC0CB8 ^ 0x61EDE71E), ex);
						num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num9 = 0;
						}
					}
				}
				goto case 6;
			case 6:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnViewsCreated);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				ExecuteHandlers(_003C_003Ec__DisplayClass78_._003CCreateViews_003Eb__0);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 5;
				}
				break;
			default:
				_003C_003Ec__DisplayClass78_.e = new ViewsCreatingEventArgs();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					_003C_003Ec.Rdc2NdQDTpAqGjsi0DDI(h);
				});
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string PrepareSqlText(string text)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_ = default(_003C_003Ec__DisplayClass79_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass79_.transform = (ITransformationProvider)kop6ooWSCKuuth5IGg1Z(Locator.GetServiceNotNull<IRuntimeApplication>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)voTOt3WSvDdOt106ahrZ(voTOt3WSvDdOt106ahrZ(text, quoteWrapperPattern, new MatchEvaluator(_003C_003Ec__DisplayClass79_._003CPrepareSqlText_003Eb__0)), quoteWrapperPatternXml, new MatchEvaluator(_003C_003Ec__DisplayClass79_._003CPrepareSqlText_003Eb__1));
			}
		}
	}

	private void CreateProcedures()
	{
		//Discarded unreachable code: IL_00e3, IL_0107, IL_0116, IL_0121, IL_017d, IL_01e2, IL_0221, IL_029a, IL_02a9, IL_0364, IL_0377, IL_0386, IL_0417, IL_0466, IL_0475
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass80_0 _003C_003Ec__DisplayClass80_ = default(_003C_003Ec__DisplayClass80_0);
		Dictionary<string, DbStructure.DbProcedure>.ValueCollection.Enumerator enumerator = default(Dictionary<string, DbStructure.DbProcedure>.ValueCollection.Enumerator);
		DbStructure.DbProcedure current = default(DbStructure.DbProcedure);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass80_.e = new ProceduresCreatingEventArgs();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				return;
			case 1:
				_003C_003Ec__DisplayClass80_ = new _003C_003Ec__DisplayClass80_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				ExecuteHandlers(_003C_003Ec__DisplayClass80_._003CCreateProcedures_003Eb__0);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-16752921 ^ -16665289));
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							goto end_IL_00e7;
						case 3:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num4 = 5;
										}
										goto IL_0125;
									}
									goto IL_02fa;
									IL_02fa:
									current = enumerator.Current;
									num4 = 3;
									goto IL_0125;
									IL_0125:
									while (true)
									{
										switch (num4)
										{
										case 2:
											try
											{
												BQdHwuWSu31ZcQtoOAEi(current, B9bmkkWV9OKwQBoMOKmD(chQvFoWS8wDaPfKoAh4t(current)));
												int num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
												{
													num5 = 1;
												}
												while (true)
												{
													switch (num5)
													{
													case 1:
														Transform.ExecuteNonQuery((string)chQvFoWS8wDaPfKoAh4t(current));
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
														{
															num5 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											catch (Exception innerException)
											{
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
												{
													num6 = 0;
												}
												switch (num6)
												{
												default:
													throw new DbStructureException(SR.T((string)qQNj7gWVE9ZflK2e5LD6(-105199646 ^ -105174058), rrAsMQWSZ1o4JBwdBils(current)), innerException);
												}
											}
											goto case 6;
										case 6:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, gYhdXMWSQHpF3bZOF9Dg(qQNj7gWVE9ZflK2e5LD6(0x68BBB53E ^ 0x68BA5942), Array.Empty<object>()));
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
											{
												num4 = 0;
											}
											continue;
										case 7:
											vEngZXWVXBHFkCJQvB0J(DbUpdateLog, MrPGydWSG16ra010xmQh(qQNj7gWVE9ZflK2e5LD6(-70037984 ^ -70082016), rrAsMQWSZ1o4JBwdBils(current)));
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
											{
												num4 = 2;
											}
											continue;
										case 4:
											goto IL_02fa;
										case 3:
											if (string.IsNullOrEmpty((string)chQvFoWS8wDaPfKoAh4t(current)))
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
												{
													num4 = 0;
												}
												continue;
											}
											goto case 7;
										case 5:
											goto end_IL_022b;
										}
										break;
									}
									continue;
									end_IL_022b:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
							break;
						case 2:
							enumerator = currStruct.Procedures.Values.GetEnumerator();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num3 = 3;
							}
							continue;
						case 1:
							break;
						case 0:
							goto end_IL_00e7;
						}
						vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x42643203 ^ 0x4265DEA1));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num3 = 0;
						}
						continue;
						end_IL_00e7:
						break;
					}
				}
				catch (Exception ex)
				{
					int num8 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num8 = 1;
					}
					while (true)
					{
						switch (num8)
						{
						case 1:
							NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1245F076), ex);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
							{
								num8 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto case 4;
			case 4:
				ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnProceduresCreated);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				ExecuteHandlers(delegate(IDbUpdateHandler h)
				{
					_003C_003Ec.awVAsdQDkFiOHaO3lJOg(h);
				});
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void CreateTriggers()
	{
		//Discarded unreachable code: IL_00da, IL_00e4, IL_0195, IL_01fa, IL_0239, IL_02e4, IL_02f7, IL_0306, IL_035a, IL_03a8
		int num = 6;
		_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = default(_003C_003Ec__DisplayClass81_0);
		Dictionary<string, DbStructure.DbTrigger>.ValueCollection.Enumerator enumerator = default(Dictionary<string, DbStructure.DbTrigger>.ValueCollection.Enumerator);
		DbStructure.DbTrigger current = default(DbStructure.DbTrigger);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					ExecuteHandlers(_003C_003Ec__DisplayClass81_._003CCreateTriggers_003Eb__0);
					num2 = 2;
					continue;
				case 4:
					return;
				case 2:
					try
					{
						vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(-475857671 ^ -475852289));
						int num3 = 3;
						while (true)
						{
							IL_0085:
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 3:
									enumerator = currStruct.Triggers.Values.GetEnumerator();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									try
									{
										while (true)
										{
											IL_0277:
											int num5;
											if (!enumerator.MoveNext())
											{
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
												{
													num5 = 0;
												}
												goto IL_00e8;
											}
											goto IL_0144;
											IL_0144:
											current = enumerator.Current;
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
											{
												num5 = 0;
											}
											goto IL_00e8;
											IL_00e8:
											while (true)
											{
												switch (num5)
												{
												case 6:
													vEngZXWVXBHFkCJQvB0J(DbUpdateLog, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92EFFE7), G8hvSGWSVQoJjNL8oLZH(current)));
													num5 = 4;
													continue;
												case 5:
													break;
												case 4:
													try
													{
														bmFDcTWSSwcH2JGFp2h3(current, PrepareSqlText((string)RTQBRlWSIAfxFmB3fyMj(current)));
														int num6 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
														{
															num6 = 0;
														}
														while (true)
														{
															switch (num6)
															{
															case 1:
																Transform.ExecuteNonQuery(current.Text);
																num6 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
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
													catch (Exception innerException)
													{
														int num7 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
														{
															num7 = 0;
														}
														switch (num7)
														{
														default:
															throw new DbStructureException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A60D8DC), G8hvSGWSVQoJjNL8oLZH(current)), innerException);
														}
													}
													goto case 3;
												case 3:
													DbUpdateLog.Debug(gYhdXMWSQHpF3bZOF9Dg(qQNj7gWVE9ZflK2e5LD6(-1108654032 ^ -1108695658), Array.Empty<object>()));
													num5 = 2;
													continue;
												case 2:
													goto IL_0277;
												default:
													if (!string.IsNullOrEmpty((string)RTQBRlWSIAfxFmB3fyMj(current)))
													{
														num5 = 6;
														continue;
													}
													goto IL_0277;
												case 1:
													goto end_IL_0277;
												}
												break;
											}
											goto IL_0144;
											continue;
											end_IL_0277:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator).Dispose();
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									break;
								case 2:
									goto end_IL_0089;
								}
								vEngZXWVXBHFkCJQvB0J(DbUpdateLog, qQNj7gWVE9ZflK2e5LD6(0x4DC2B14D ^ 0x4DC35C85));
								num3 = 2;
								goto IL_0085;
								continue;
								end_IL_0089:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								throw;
							}
							NmJ0pdWVeVpyHmlZi50C(DbUpdateLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECFBEFE), ex);
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num9 = 0;
							}
						}
					}
					goto case 3;
				case 3:
					ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnTriggersCreated);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass81_.e = new TriggersCreatingEventArgs();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					break;
				case 1:
					ExecuteHandlers(delegate(IDbUpdateHandler h)
					{
						h.OnTriggersCreated();
					});
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
			num = 5;
		}
	}

	private void SaveCurrentStructures()
	{
		//Discarded unreachable code: IL_0050, IL_00aa, IL_0238, IL_0344, IL_044d, IL_04a3, IL_04db, IL_0506, IL_0554, IL_0563
		int num = 2;
		int num2 = num;
		DbStructure current = default(DbStructure);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					IEnumerator<DbStructure> enumerator = structures.GetEnumerator();
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 2:
							break;
						case 1:
							try
							{
								while (true)
								{
									IL_0329:
									int num4;
									if (!yE55KhWVQpOIplEmPfQY(enumerator))
									{
										num4 = 9;
										goto IL_00b8;
									}
									goto IL_0316;
									IL_00b8:
									while (true)
									{
										switch (num4)
										{
										case 7:
											if (X8aw6XWVPjdRr5OIGREv(Transform.ExecuteScalar((string)s6xWUvWSWO1qJFF6of25(qQNj7gWVE9ZflK2e5LD6(0xE1229CF ^ 0xE13C793), hpH7YSWVaayuA7BGat5e(AIPWQaWVpLAe0SqDRHaj(Transform), qQNj7gWVE9ZflK2e5LD6(-1088304168 ^ -1088314294)), ldjpNOWSiVU6CkP9Dvm7(Transform)), new Dictionary<string, object> { 
											{
												z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420865568),
												current.Uid
											} })) <= 0)
											{
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
												{
													num4 = 0;
												}
												continue;
											}
											goto case 6;
										case 10:
										{
											Transform.ExecuteNonQuery((string)U8YZ4NWSKupDxyyfsMs8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740377800), hpH7YSWVaayuA7BGat5e(Transform.Dialect, qQNj7gWVE9ZflK2e5LD6(--1418440330 ^ 0x548A759A)), hpH7YSWVaayuA7BGat5e(Transform.Dialect, qQNj7gWVE9ZflK2e5LD6(0x1A33FE36 ^ 0x1A3391A4)), ldjpNOWSiVU6CkP9Dvm7(Transform)), new Dictionary<string, object> { 
											{
												(string)qQNj7gWVE9ZflK2e5LD6(0x5F3078B6 ^ 0x5F319670),
												Cbl1SBWVf2WBEqNlQMH1(current)
											} });
											int num5 = 11;
											num4 = num5;
											continue;
										}
										case 5:
											fBCEftWSq7437Fw6biMV(Transform, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A40EFF), new string[3]
											{
												(string)qQNj7gWVE9ZflK2e5LD6(-867826612 ^ -867800098),
												(string)qQNj7gWVE9ZflK2e5LD6(-1123633026 ^ -1123589294),
												z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939428914)
											}, new object[3]
											{
												Cbl1SBWVf2WBEqNlQMH1(current),
												current.Xml,
												startUpdateTime
											});
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
											{
												num4 = 2;
											}
											continue;
										case 6:
											if (!current.Deactivating)
											{
												num4 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
												{
													num4 = 2;
												}
												continue;
											}
											goto case 10;
										case 8:
											break;
										case 1:
										case 3:
										case 4:
										case 11:
											goto IL_0329;
										case 2:
											Transform.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979261151), new string[2]
											{
												(string)qQNj7gWVE9ZflK2e5LD6(0x1637C429 ^ 0x16361F05),
												z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561023450)
											}, new object[2]
											{
												XtGRVXWVhRgOK9OXD85s(current),
												startUpdateTime
											}, (string)s6xWUvWSWO1qJFF6of25(qQNj7gWVE9ZflK2e5LD6(0x63ABA4E8 ^ 0x63AA4A3A), hpH7YSWVaayuA7BGat5e(AIPWQaWVpLAe0SqDRHaj(Transform), qQNj7gWVE9ZflK2e5LD6(-289714582 ^ -289725960)), Transform.ParameterSeparator), new Dictionary<string, object> { 
											{
												z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787381341),
												Cbl1SBWVf2WBEqNlQMH1(current)
											} });
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
											{
												num4 = 0;
											}
											continue;
										default:
											if (UGn2CYWSRIqGHv5uqa05(current))
											{
												num4 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
												{
													num4 = 0;
												}
												continue;
											}
											goto case 5;
										case 9:
											goto end_IL_0329;
										}
										break;
									}
									goto IL_0316;
									IL_0316:
									current = enumerator.Current;
									num4 = 7;
									goto IL_00b8;
									continue;
									end_IL_0329:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											RgLq98WVCgqwvpENPdQm(enumerator);
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
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
							}
							break;
						case 0:
							return;
						}
						DbUpdateLog.Debug(qQNj7gWVE9ZflK2e5LD6(0x6A81B9B4 ^ 0x6A805686));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num3 = 0;
						}
					}
				}
				catch (Exception exception)
				{
					int num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							DbUpdateLog.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867177729), exception);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num7 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
			case 0:
				return;
			case 2:
				DbUpdateLog.Debug(qQNj7gWVE9ZflK2e5LD6(0x26FFCB59 ^ 0x26FE257D));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void DropConstraints()
	{
		//Discarded unreachable code: IL_0052, IL_008a, IL_00ca, IL_00d9, IL_00e5, IL_0110, IL_0148, IL_0188, IL_0197, IL_01a3, IL_01b2
		int num = 2;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 3:
				try
				{
					DeleteIndexes();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (dBStartInformation == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num4 = 1;
						}
						goto IL_008e;
					}
					goto IL_00a4;
					IL_00a4:
					((IDisposable)dBStartInformation).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num4 = 0;
					}
					goto IL_008e;
					IL_008e:
					switch (num4)
					{
					default:
						goto end_IL_0069;
					case 2:
						break;
					case 1:
						goto end_IL_0069;
					case 0:
						goto end_IL_0069;
					}
					goto IL_00a4;
					end_IL_0069:;
				}
			case 1:
				try
				{
					DeleteForeignKeys();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num6;
					if (dBStartInformation == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num6 = 0;
						}
						goto IL_014c;
					}
					goto IL_0162;
					IL_0162:
					RgLq98WVCgqwvpENPdQm(dBStartInformation);
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num6 = 1;
					}
					goto IL_014c;
					IL_014c:
					switch (num6)
					{
					default:
						goto end_IL_0127;
					case 2:
						break;
					case 0:
						goto end_IL_0127;
					case 1:
						goto end_IL_0127;
					}
					goto IL_0162;
					end_IL_0127:;
				}
				goto default;
			default:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.IndexRemoval);
				num2 = 3;
				break;
			case 2:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.DeletingForeignKeys);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void DropConstraintsSmart()
	{
		//Discarded unreachable code: IL_02d3, IL_02f2, IL_0301, IL_032e, IL_033d
		int num = 2;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					ProcessDbActions();
					int num3 = 8;
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 13:
								bivHOTWSTUqTk65Jwo15(dbMigrator);
								num4 = 6;
								continue;
							case 6:
								ijKR2oWSk8pqf0HX2Z3y(dbMigrator);
								num4 = 8;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
								{
									num4 = 10;
								}
								continue;
							case 4:
								ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnForeignKeysDeleted);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num4 = 0;
								}
								continue;
							case 3:
								ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnIndexesDeleted);
								num4 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
								{
									num4 = 6;
								}
								continue;
							case 1:
								ExecuteScriptsAndMethods(DbStructure.ExecuteTime.OnPrimaryKeysDeleted);
								num4 = 2;
								continue;
							case 10:
								dbMigrator.OnIndexesDropped();
								num4 = 5;
								continue;
							case 8:
								r34NbYWSXnxinGgcW8JP(dbMigrator);
								num3 = 13;
								break;
							case 5:
								ExecuteHandlers(delegate(IDbUpdateHandler h)
								{
									int num8 = 1;
									int num9 = num8;
									while (true)
									{
										switch (num9)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											_003C_003Ec.Ti038QQDn7yWENILJTEp(h, new ForeginKeysDeletingEventArgs());
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
											{
												num9 = 0;
											}
											break;
										}
									}
								});
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num4 = 4;
								}
								continue;
							default:
								ExecuteHandlers(delegate(IDbUpdateHandler h)
								{
									h.OnForeignKeysDeleted();
								});
								num4 = 12;
								continue;
							case 12:
								ExecuteHandlers(delegate(IDbUpdateHandler h)
								{
									int num6 = 1;
									int num7 = num6;
									while (true)
									{
										switch (num7)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											_003C_003Ec.mY48P1QDOp52mioaJVjE(h, new PrimaryKeysDeletingEventArgs());
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
											{
												num7 = 0;
											}
											break;
										}
									}
								});
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num4 = 1;
								}
								continue;
							case 2:
								ExecuteHandlers(delegate(IDbUpdateHandler h)
								{
									_003C_003Ec.HttVIyQDqIyGv4HPcteM(h);
								});
								num4 = 9;
								continue;
							case 9:
								ExecuteHandlers(delegate(IDbUpdateHandler h)
								{
									int num10 = 1;
									int num11 = num10;
									while (true)
									{
										switch (num11)
										{
										default:
											return;
										case 1:
											h.OnIndexesDeleting(new IndexesDeletingEventArgs());
											num11 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
											{
												num11 = 0;
											}
											break;
										case 0:
											return;
										}
									}
								});
								num3 = 3;
								break;
							case 7:
								ExecuteHandlers(delegate(IDbUpdateHandler h)
								{
									_003C_003Ec.irKvyTQDRQFD3XYbrUGN(h);
								});
								num4 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
								{
									num4 = 11;
								}
								continue;
							case 11:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					int num5;
					if (dBStartInformation == null)
					{
						num5 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num5 = 1;
						}
						goto IL_02d7;
					}
					goto IL_030c;
					IL_030c:
					RgLq98WVCgqwvpENPdQm(dBStartInformation);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num5 = 0;
					}
					goto IL_02d7;
					IL_02d7:
					switch (num5)
					{
					default:
						goto end_IL_02b2;
					case 2:
						goto end_IL_02b2;
					case 1:
						break;
					case 0:
						goto end_IL_02b2;
					}
					goto IL_030c;
					end_IL_02b2:;
				}
			case 2:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.SmartDeleteKeysAndIndexes);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void RecreateConstraints()
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c1, IL_0133, IL_016b, IL_01a3, IL_01b2
		int num = 4;
		int num2 = num;
		DBStartInformation dBStartInformation = default(DBStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					CreateIndexes();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (dBStartInformation != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								RgLq98WVCgqwvpENPdQm(dBStartInformation);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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
				}
			default:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.IndexCreation);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				dBStartInformation = new DBStartInformation(DatabaseConversionStage.CreatingForeignKeys);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 3:
				try
				{
					CreateForeignKeys();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (dBStartInformation != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								RgLq98WVCgqwvpENPdQm(dBStartInformation);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto default;
			}
		}
	}

	private void ProcessDbActions()
	{
		//Discarded unreachable code: IL_0042, IL_0051, IL_005c, IL_015e, IL_0196, IL_01a5, IL_01b6, IL_01c5, IL_01d0, IL_02dc, IL_0314, IL_0323, IL_035c, IL_036b, IL_045c, IL_0494
		int num = 5;
		int num2 = num;
		IEnumerator<DbDeleteColumnAction> enumerator = default(IEnumerator<DbDeleteColumnAction>);
		DbDeleteColumnAction current = default(DbDeleteColumnAction);
		IEnumerator<DbRenameColumnAction> enumerator2 = default(IEnumerator<DbRenameColumnAction>);
		DbRenameColumnAction current2 = default(DbRenameColumnAction);
		IDbAction[] source = default(IDbAction[]);
		IEnumerator<DbDeleteTableAction> enumerator3 = default(IEnumerator<DbDeleteTableAction>);
		DbDeleteTableAction current3 = default(DbDeleteTableAction);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				try
				{
					while (true)
					{
						IL_00a1:
						int num3;
						if (!yE55KhWVQpOIplEmPfQY(enumerator))
						{
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num3 = 0;
							}
							goto IL_0060;
						}
						goto IL_007e;
						IL_007e:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num3 = 2;
						}
						goto IL_0060;
						IL_0060:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto IL_00a1;
							case 4:
								dbMigrator.MarkTouchedDbMetadata((string)L85xslWS2LvCGV8eXA6W(current), current.ColumnName);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								DbUpdateLog.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C1A9AB), current.ColumnName, T0vVt7WSOUI0PPZ9Gj2b(current));
								num3 = 4;
								continue;
							case 3:
								goto end_IL_00a1;
							}
							break;
						}
						goto IL_007e;
						continue;
						end_IL_00a1:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								RgLq98WVCgqwvpENPdQm(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
				goto case 2;
			case 1:
				try
				{
					while (true)
					{
						IL_0290:
						int num5;
						if (!enumerator2.MoveNext())
						{
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num5 = 1;
							}
							goto IL_01d4;
						}
						goto IL_0215;
						IL_0215:
						current2 = enumerator2.Current;
						num5 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num5 = 3;
						}
						goto IL_01d4;
						IL_01d4:
						while (true)
						{
							switch (num5)
							{
							case 2:
								dbMigrator.MarkTouchedDbMetadata((string)VbEi8cWS155L8YNyo4DC(current2), (string)FXgZi7WSefedAhug9OXe(current2));
								num5 = 4;
								continue;
							case 3:
								DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(-398663332 ^ -398651058), FXgZi7WSefedAhug9OXe(current2), MGhEB1WSP7ZBVnYZfqbb(current2), current2.TableName);
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num5 = 0;
								}
								continue;
							case 4:
								goto IL_0290;
							case 1:
								return;
							}
							break;
						}
						goto IL_0215;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								RgLq98WVCgqwvpENPdQm(enumerator2);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
				}
			case 2:
				enumerator2 = source.OfType<DbRenameColumnAction>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				try
				{
					while (true)
					{
						IL_0410:
						int num7;
						if (!enumerator3.MoveNext())
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num7 = 1;
							}
							goto IL_037a;
						}
						goto IL_03c5;
						IL_03c5:
						current3 = enumerator3.Current;
						int num8 = 3;
						num7 = num8;
						goto IL_037a;
						IL_037a:
						while (true)
						{
							switch (num7)
							{
							case 2:
								dbMigrator.MarkTouchedDbMetadata((string)ix0152WSnPtOOPY1G4BL(current3));
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num7 = 0;
								}
								continue;
							case 4:
								break;
							case 3:
								DbUpdateLog.DebugFormat((string)qQNj7gWVE9ZflK2e5LD6(0x3CE17B75 ^ 0x3CE094DD), current3.TableName);
								num7 = 2;
								continue;
							default:
								goto IL_0410;
							case 1:
								goto end_IL_0410;
							}
							break;
						}
						goto IL_03c5;
						continue;
						end_IL_0410:
						break;
					}
				}
				finally
				{
					if (enumerator3 != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								RgLq98WVCgqwvpENPdQm(enumerator3);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 7;
			case 7:
				enumerator = source.OfType<DbDeleteColumnAction>().GetEnumerator();
				num2 = 3;
				break;
			case 4:
				enumerator3 = source.OfType<DbDeleteTableAction>().GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 6;
				}
				break;
			case 0:
				return;
			case 5:
				source = handlers.OfType<IActionsHolder>().SelectMany((IActionsHolder a) => a.TablesCreatedActions.Concat(a.TablesDeletedActions)).ToArray();
				num2 = 4;
				break;
			}
		}
	}

	public DbStructureReader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KFBJ6qWSNF4K5juJe7s7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DbStructureReader()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					DbUpdateLog = (ILogger)im1MPOWS3pOQoONscpqI(qQNj7gWVE9ZflK2e5LD6(0x18A6761F ^ 0x18A78673));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					quoteWrapperPattern = (string)qQNj7gWVE9ZflK2e5LD6(-1852837372 ^ -1852964212);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					quoteWrapperPatternXml = (string)qQNj7gWVE9ZflK2e5LD6(0x4A1640F ^ 0x4A09495);
					num2 = 2;
					continue;
				case 4:
					break;
				case 2:
					return;
				}
				break;
			}
			KFBJ6qWSNF4K5juJe7s7();
			num = 3;
		}
	}

	internal static bool KYSnw1WVoFHdVP6Cpucr()
	{
		return r0eoZ6WVWfLB7IOcTsSF == null;
	}

	internal static DbStructureReader zpnK5FWVbe2L5MMvuxfM()
	{
		return r0eoZ6WVWfLB7IOcTsSF;
	}

	internal static object XtGRVXWVhRgOK9OXD85s(object P_0)
	{
		return ((DbStructure)P_0).Xml;
	}

	internal static bool yp935jWVGwVVyow1A7UY(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object qQNj7gWVE9ZflK2e5LD6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid Cbl1SBWVf2WBEqNlQMH1(object P_0)
	{
		return ((DbStructure)P_0).Uid;
	}

	internal static bool yE55KhWVQpOIplEmPfQY(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void RgLq98WVCgqwvpENPdQm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool tb5kQ8WVvynJI14rEahG(object P_0)
	{
		return ((IDbUpdateHandler)P_0).NeedRecreateConstraints;
	}

	internal static void WZXOMdWV8NVfBM0YG5BI(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static void bb64fGWVZCMBBcY2PQUT(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object WHWBbBWVub1R9Z72y32y()
	{
		return Logger.Log;
	}

	internal static void tDCZPDWVI08UPJ5rPn2T(object P_0)
	{
		((DbStructureReader)P_0).ExecuteMain();
	}

	internal static void Jl68mXWVV18qdGUYdoeE(object P_0)
	{
		((DbMigrator)P_0).OnMigrationStart();
	}

	internal static void vtrIE6WVSO911JqYbIcQ(object P_0)
	{
		((DbStructureReader)P_0).ExecuteStart();
	}

	internal static void cMXHEOWViMG3o02d1BLa(object P_0)
	{
		((DbStructureReader)P_0).ExecuteDeleteTablesTransaction();
	}

	internal static void IoVAWdWVRlNbxFai9VxE(object P_0)
	{
		((DbStructureReader)P_0).ExecuteCreateRecreatedTransaction();
	}

	internal static void ti41twWVqbO3SsGTYsro(object P_0)
	{
		((DbStructureReader)P_0).ExecuteComplete();
	}

	internal static void px3wEoWVKTaSrljPnvQ1(object P_0)
	{
		((DbMigrator)P_0).OnMigrationEnd();
	}

	internal static void vEngZXWVXBHFkCJQvB0J(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object LC12BxWVTLuces7IkGGZ(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static void kvqDAfWVkSOR3ivgmmbK(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void dISkkPWVnCOxO0VwljM9(object P_0, ColumnProperty value)
	{
		((Column)P_0).ColumnProperty = value;
	}

	internal static bool TT4nT3WVOSGZA3fitOso(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void snh15OWV2IG4IXekVN64(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static void NmJ0pdWVeVpyHmlZi50C(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static int X8aw6XWVPjdRr5OIGREv(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static object WETw7WWV1OFCfFh74sto(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void E51rgJWVNm24mKGU77KV(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static void CNT2fQWV3u4r6xoJyGOR(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Debug(P_1, (Exception)P_2);
	}

	internal static object AIPWQaWVpLAe0SqDRHaj(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object hpH7YSWVaayuA7BGat5e(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object CYsqmoWVD9SVfBJYXA6w(object P_0, int P_1)
	{
		return ((IDataRecord)P_0)[P_1];
	}

	internal static bool lgmbB4WVtNQsZ7AWBQS8(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static object ayjIi8WVw2pIU8FBLbFu(object P_0)
	{
		return ((List<DbStructure>)P_0).ToArray();
	}

	internal static object aRouyRWV4nHtrPtnMWtC(object P_0)
	{
		return ((DbStructure.DbIndex)P_0).Name;
	}

	internal static object oIUhdYWV6SAYNFC5iR8t(object P_0)
	{
		return ((DbStructure.DbIndex)P_0).TableName;
	}

	internal static void hTjUAfWVHRpxtAVSou4P(object P_0, object P_1, object P_2)
	{
		((DbMigrator)P_0).MarkDroppingIndex((string)P_1, (string)P_2);
	}

	internal static bool rd8xBYWVAyHZcocv6QUY(object P_0)
	{
		return ((DbStructure.DbIndex)P_0).IsUnique;
	}

	internal static object GEZFPbWV7joBsaaOxwQl(object P_0)
	{
		return ((DbStructure.DbIndex)P_0).Text;
	}

	internal static bool Jhj8UDWVxB9BnQIFFPCi(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).IndexExists((string)P_1, (string)P_2);
	}

	internal static object N2KmpNWV0yaCegl1DxNc(object P_0)
	{
		return ((string)P_0).ToUpperInvariant();
	}

	internal static object Xp4MccWVmNRd7HXMJApW(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool dwRtOJWVy5Dkxt1VmNvP(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void LCfn1wWVMnI3RmZGtSaI(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static void SarcmXWVJFwcSkZhPXeM(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static object B9bmkkWV9OKwQBoMOKmD(object P_0)
	{
		return PrepareSqlText((string)P_0);
	}

	internal static void jJIA5lWVdMmBfdeLcpfk(object P_0, object P_1)
	{
		((DbStructure.DbIndex)P_0).Text = (string)P_1;
	}

	internal static bool pSY925WVlLWy7O3BxhuW(object P_0)
	{
		return ((DbStructure.UserMethod)P_0).AlwaysExecute;
	}

	internal static object rswcomWVr5UcjEfNMjCo(object P_0)
	{
		return ((DbStructure.UserMethod)P_0).Name;
	}

	internal static object TwwlJLWVgc0DAr75gQs5(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object eFI9SXWV5y9MWZ2nwUmQ(object P_0)
	{
		return ((DbStructure.UserMethod)P_0).TransformationInVersion;
	}

	internal static object p51195WVj7KGOpfGfJ25(object P_0)
	{
		return ((IRuntimeApplication)P_0).DbPreUpdater;
	}

	internal static bool QgKgbDWVYqba382hDJhV(object P_0)
	{
		return ((DbPreUpdater)P_0).IsFirstStart;
	}

	internal static object nhHxwiWVLkHhCW85NNtX(object P_0)
	{
		return ((DbStructure.DbScript)P_0).Text;
	}

	internal static void KRD8mJWVUveLI74wiyE0(object P_0, object P_1)
	{
		((DbStructure.DbScript)P_0).Text = (string)P_1;
	}

	internal static object LAQgoKWVs0uOvrYT2hZ7(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).GetIndexInfoFromStatement((string)P_1);
	}

	internal static object ziTLYEWVcjvaLECfAfhV(object P_0)
	{
		return ((Index)P_0).TableName;
	}

	internal static object oHNl97WVztXUIpveWOA2(object P_0)
	{
		return ((DbStructure.UserMethod)P_0).MethodExecutor;
	}

	internal static bool jEKjL4WSFDAZAPHgSJhu(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static object Tsv21xWSBbljYeFkR0Nf(object P_0)
	{
		return ((DbStructure.UserMethod)P_0).Method;
	}

	internal static object s6xWUvWSWO1qJFF6of25(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool jWh1YcWSoK1AfCojkFql(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object vuZkVVWSbue3itFK5S1J(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void np92OuWShsBlGtVeBmBn(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static object MrPGydWSG16ra010xmQh(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object K2xys8WSE8CbtA3AXOrc(object P_0)
	{
		return ((DbStructure.DbView)P_0).Text;
	}

	internal static object NQdqSdWSfEouMw2s6NjR(object P_0)
	{
		return ((DbStructure.DbView)P_0).Name;
	}

	internal static object gYhdXMWSQHpF3bZOF9Dg(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object kop6ooWSCKuuth5IGg1Z(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static object voTOt3WSvDdOt106ahrZ(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (MatchEvaluator)P_2);
	}

	internal static object chQvFoWS8wDaPfKoAh4t(object P_0)
	{
		return ((DbStructure.DbProcedure)P_0).Text;
	}

	internal static object rrAsMQWSZ1o4JBwdBils(object P_0)
	{
		return ((DbStructure.DbProcedure)P_0).Name;
	}

	internal static void BQdHwuWSu31ZcQtoOAEi(object P_0, object P_1)
	{
		((DbStructure.DbProcedure)P_0).Text = (string)P_1;
	}

	internal static object RTQBRlWSIAfxFmB3fyMj(object P_0)
	{
		return ((DbStructure.DbTrigger)P_0).Text;
	}

	internal static object G8hvSGWSVQoJjNL8oLZH(object P_0)
	{
		return ((DbStructure.DbTrigger)P_0).Name;
	}

	internal static void bmFDcTWSSwcH2JGFp2h3(object P_0, object P_1)
	{
		((DbStructure.DbTrigger)P_0).Text = (string)P_1;
	}

	internal static object ldjpNOWSiVU6CkP9Dvm7(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static bool UGn2CYWSRIqGHv5uqa05(object P_0)
	{
		return ((DbStructure)P_0).Deactivating;
	}

	internal static int fBCEftWSq7437Fw6biMV(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ITransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3);
	}

	internal static object U8YZ4NWSKupDxyyfsMs8(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void r34NbYWSXnxinGgcW8JP(object P_0)
	{
		((DbMigrator)P_0).DropMarkedForeignKeys();
	}

	internal static void bivHOTWSTUqTk65Jwo15(object P_0)
	{
		((DbMigrator)P_0).DropMarkedPrimaryKeys();
	}

	internal static void ijKR2oWSk8pqf0HX2Z3y(object P_0)
	{
		((DbMigrator)P_0).DropMarkedIndexes();
	}

	internal static object ix0152WSnPtOOPY1G4BL(object P_0)
	{
		return ((DbDeleteTableAction)P_0).TableName;
	}

	internal static object T0vVt7WSOUI0PPZ9Gj2b(object P_0)
	{
		return ((DbDeleteColumnAction)P_0).ColumnName;
	}

	internal static object L85xslWS2LvCGV8eXA6W(object P_0)
	{
		return ((DbDeleteColumnAction)P_0).TableName;
	}

	internal static object FXgZi7WSefedAhug9OXe(object P_0)
	{
		return ((DbRenameColumnAction)P_0).OldColumnName;
	}

	internal static object MGhEB1WSP7ZBVnYZfqbb(object P_0)
	{
		return ((DbRenameColumnAction)P_0).NewColumnName;
	}

	internal static object VbEi8cWS155L8YNyo4DC(object P_0)
	{
		return ((DbRenameColumnAction)P_0).TableName;
	}

	internal static void KFBJ6qWSNF4K5juJe7s7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object im1MPOWS3pOQoONscpqI(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
