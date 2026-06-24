using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.DTO.Models;

[Serializable]
public class GlobalScriptModuleDto : EntityDTO<long>, IMetadata, IXsiType
{
	internal static GlobalScriptModuleDto d2YC8gbqLShx0E1KIGWV;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	public virtual Guid ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
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
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
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

	[DefaultValue(false)]
	public virtual bool Internal
	{
		[CompilerGenerated]
		get
		{
			return _003CInternal_003Ek__BackingField;
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
					_003CInternal_003Ek__BackingField = value;
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

	public ScriptModuleDTO ScriptModule
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptModule_003Ek__BackingField;
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
					_003CScriptModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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

	public ProjectInfo Project
	{
		[CompilerGenerated]
		get
		{
			return _003CProject_003Ek__BackingField;
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
					_003CProject_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
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

	public GlobalScriptModuleHeaderDto Header
	{
		[CompilerGenerated]
		get
		{
			return _003CHeader_003Ek__BackingField;
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
					_003CHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public GlobalScriptModuleDto()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		do2rPJbqcrjFX5O6Y4lv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Header = new GlobalScriptModuleHeaderDto();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
			{
				num = 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeModuleUid()
	{
		return nnDkUDbqzrLQhAh85aJ8(this) != Guid.Empty;
	}

	public void InitNew()
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
				Uid = Guid.NewGuid();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ScriptModuleDTO scriptModuleDTO = new ScriptModuleDTO();
			N6EbZubKBTlfOKAss9sd(scriptModuleDTO, PTjxd0bKF01dfcdNwopY());
			pi1EpdbKWQgvVq0h9wQJ(scriptModuleDTO, GlobalScriptModuleType.UID);
			ScriptModule = scriptModuleDTO;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
			{
				num2 = 2;
			}
		}
	}

	public void AfterLoad()
	{
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
				InitScriptModule();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (ScriptModule != null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void ResetIdsForPublish()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				N6EbZubKBTlfOKAss9sd(ScriptModule, Guid.NewGuid());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				Uid = PTjxd0bKF01dfcdNwopY();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				ScriptModule.Id = 0L;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				base.Id = 0L;
				num2 = 3;
				break;
			}
		}
	}

	private void InitScriptModule()
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
			{
				ScriptModuleDTO scriptModuleDTO = new ScriptModuleDTO();
				N6EbZubKBTlfOKAss9sd(scriptModuleDTO, PTjxd0bKF01dfcdNwopY());
				scriptModuleDTO.ModuleTypeUid = GlobalScriptModuleType.UID;
				scriptModuleDTO.ObjectUid = Uid;
				ScriptModule = scriptModuleDTO;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	public override void CopyChanges(EntityDTO<long> saved)
	{
		if (saved is GlobalScriptModuleDto globalScriptModuleDto)
		{
			Project.CompiledFolderPath = globalScriptModuleDto.Project.CompiledFolderPath;
		}
		base.CopyChanges(saved);
	}

	public static GlobalScriptModuleDto New()
	{
		GlobalScriptModuleDto globalScriptModuleDto = new GlobalScriptModuleDto();
		globalScriptModuleDto.InitNew();
		return globalScriptModuleDto;
	}

	internal static void do2rPJbqcrjFX5O6Y4lv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool v9hPufbqUEnq3DnTLi01()
	{
		return d2YC8gbqLShx0E1KIGWV == null;
	}

	internal static GlobalScriptModuleDto joWxvZbqsv40gbonpqAM()
	{
		return d2YC8gbqLShx0E1KIGWV;
	}

	internal static Guid nnDkUDbqzrLQhAh85aJ8(object P_0)
	{
		return ((GlobalScriptModuleDto)P_0).ModuleUid;
	}

	internal static Guid PTjxd0bKF01dfcdNwopY()
	{
		return Guid.NewGuid();
	}

	internal static void N6EbZubKBTlfOKAss9sd(object P_0, Guid value)
	{
		((ScriptModuleDTO)P_0).Uid = value;
	}

	internal static void pi1EpdbKWQgvVq0h9wQJ(object P_0, Guid value)
	{
		((ScriptModuleDTO)P_0).ModuleTypeUid = value;
	}
}
