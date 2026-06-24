using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.CodeGeneration;

public class ProcessContextGenerationParams : GenerationParams
{
	internal static ProcessContextGenerationParams Bd33qAO8lcetteG5Xb1s;

	public IProcessHeader ProcessHeader
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeader_003Ek__BackingField;
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
					_003CProcessHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
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

	public bool IsFullContext
	{
		[CompilerGenerated]
		get
		{
			return _003CIsFullContext_003Ek__BackingField;
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
					_003CIsFullContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
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

	public EntityMetadata ParentContext
	{
		[CompilerGenerated]
		get
		{
			return _003CParentContext_003Ek__BackingField;
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
					_003CParentContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<EntityMetadata> ParentContextList { get; set; }

	public ProcessContextGenerationParams()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JjOKdaO8mDPqqMQwS3pg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool D1x79nO80dGfmJh2BWhi()
	{
		return Bd33qAO8lcetteG5Xb1s == null;
	}

	internal static ProcessContextGenerationParams BZdo3jO8ylcjKXwsAstI()
	{
		return Bd33qAO8lcetteG5Xb1s;
	}

	internal static void JjOKdaO8mDPqqMQwS3pg()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
