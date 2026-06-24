using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

[Component(Order = int.MinValue)]
internal class EntityIdSequenceMigrationDbHandler : DbUpdateHandler
{
	private bool needConvert;

	private static EntityIdSequenceMigrationDbHandler mRKbqEDkk7KG3G9ryZ;

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
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9457c8cc16bd407492ec82836e6ece2b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IMainDatabaseProvider MainDatabaseProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CMainDatabaseProvider_003Ek__BackingField;
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
					_003CMainDatabaseProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_6e4085613a434991b7308d69af884312 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SessionFactoryHolder SessionFactoryHolder
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionFactoryHolder_003Ek__BackingField;
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
					_003CSessionFactoryHolder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_26c4d17a35c943fbaf0ef30e123de177 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private MSSQLTransformationProvider MSSQLTransform => bZVSFkmb8ed4ePiUuZ(RuntimeApplication) as MSSQLTransformationProvider;

	private bool CanMigrate
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (MSSQLTransform.IsSequenceSupport)
					{
						num2 = 0;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ac8b4db689fb4d85a7bb7ce35db5e4d5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					if (MSSQLTransform != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b14550e4462b4c7190663aa2ba86338f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					return U9qLKslTrp9WcXAr44(MSSQLTransform, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1974253802 ^ 0x75ACB8C4));
				}
				break;
			}
			return false;
		}
	}

	public override Guid ProviderUid => MSSQLProvider.UID;

	public override bool HasChanges => CanMigrate;

	public override bool NeedRecreateConstraints => CanMigrate;

	public override void Init()
	{
		//Discarded unreachable code: IL_0039
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				needConvert = false;
				num2 = 4;
				break;
			case 4:
				return;
			case 5:
				return;
			default:
				if (RuntimeApplication != null)
				{
					if (!RuntimeApplication.DbPreUpdater.IsFirstStart)
					{
						num2 = 2;
						if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a790b36cf25c47829dbedbeba78b0de0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
				num2 = 5;
				break;
			case 1:
				base.Init();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9f50fa62c83545aa885cad260f298366 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnStart(DbUpdateParameters parameters)
	{
		//Discarded unreachable code: IL_0070
		int num = 3;
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
				if (!needConvert)
				{
					num2 = 5;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_b13d731cb79641de887177267153d656 == 0)
					{
						num2 = 5;
					}
					break;
				}
				if (CanMigrate)
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_d77c90c2b1934f16bf9cfe858d8dba6d == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				base.OnStart(parameters);
				num2 = 2;
				break;
			case 5:
				return;
			case 4:
				return;
			case 1:
				((ITransformationProvider)Dmp2r3vT4IACcSbAn6(this)).InitTableGenerators();
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bb662a6d5969493581c2c367e740adde != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public EntityIdSequenceMigrationDbHandler()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		sjkbebbp76hi5cqGiX();
		needConvert = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_74c50b4541604f879acc41487ba8662e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kucjAPf86gSH7SXa7O()
	{
		return mRKbqEDkk7KG3G9ryZ == null;
	}

	internal static EntityIdSequenceMigrationDbHandler bf3sX70SLxNZUhR7pI()
	{
		return mRKbqEDkk7KG3G9ryZ;
	}

	internal static object bZVSFkmb8ed4ePiUuZ(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static bool U9qLKslTrp9WcXAr44(object P_0, object P_1)
	{
		return ((TransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static object Dmp2r3vT4IACcSbAn6(object P_0)
	{
		return ((DbUpdateHandler)P_0).Transform;
	}

	internal static void sjkbebbp76hi5cqGiX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}
}
