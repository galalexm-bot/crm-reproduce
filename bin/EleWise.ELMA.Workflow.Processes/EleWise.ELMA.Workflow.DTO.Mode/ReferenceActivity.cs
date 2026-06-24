using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

public abstract class ReferenceActivity
{
	internal static ReferenceActivity yrpyEg4SE4VMEaZKmKc;

	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid EntityUid
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityUid_003Ek__BackingField;
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
					_003CEntityUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long EntityId
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityId_003Ek__BackingField;
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
					_003CEntityId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ReferenceActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ReferenceActivity(Guid typeUid, Guid uid, long id)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		LOn9Zh4UeTNg7sTrdL7();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 3:
				EntityId = id;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
				{
					num = 1;
				}
				break;
			default:
				EntityUid = uid;
				num = 3;
				break;
			case 1:
				return;
			case 2:
				TypeUid = typeUid;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public abstract object Resolve();

	internal static bool jdGcR34kQPsCYT5jhRS()
	{
		return yrpyEg4SE4VMEaZKmKc == null;
	}

	internal static ReferenceActivity FA4E404bLNJY2USycFP()
	{
		return yrpyEg4SE4VMEaZKmKc;
	}

	internal static void LOn9Zh4UeTNg7sTrdL7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
