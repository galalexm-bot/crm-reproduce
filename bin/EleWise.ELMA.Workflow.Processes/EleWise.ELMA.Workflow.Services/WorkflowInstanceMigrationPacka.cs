using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

[Obsolete("Not used", true)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class WorkflowInstanceMigrationPackageSweepHandler : ISweepHandler, IThreadPoolContainer
{
	internal static WorkflowInstanceMigrationPackageSweepHandler YFBhsyX8sMUtu4HRScM;

	public ISecurityService SecurityService
	{
		[CompilerGenerated]
		get
		{
			return _003CSecurityService_003Ek__BackingField;
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
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
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

	public WorkflowInstanceMigrationPackageManager MigrationPackageManager
	{
		[CompilerGenerated]
		get
		{
			return _003CMigrationPackageManager_003Ek__BackingField;
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
					_003CMigrationPackageManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 == 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Not used", true)]
	public IThreadPool Pool { get; }

	public WorkflowInstanceMigrationPackageSweepHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[Obsolete("Not used", true)]
	public void Execute()
	{
	}

	internal static bool TgJoL6XwJHM9Vd9WwKN()
	{
		return YFBhsyX8sMUtu4HRScM == null;
	}

	internal static WorkflowInstanceMigrationPackageSweepHandler CbFPOTXtIPDr3XePcB4()
	{
		return YFBhsyX8sMUtu4HRScM;
	}
}
