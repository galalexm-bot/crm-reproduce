using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.DTO.Models;

[Serializable]
[Component]
public class ProjectInfo : ProjectFolderItem
{
	internal static ProjectInfo zdrXfGbKZou84TbOWsDS;

	public string CompiledFolderPath
	{
		[CompilerGenerated]
		get
		{
			return _003CCompiledFolderPath_003Ek__BackingField;
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
					_003CCompiledFolderPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProjectInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				base.Items = new List<ProjectItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private ProjectItem GetItemByUid(Guid uid, List<ProjectItem> items)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		ProjectItem projectItem = items.FirstOrDefault((ProjectItem a) => _003C_003Ec__DisplayClass5_0.deVTeJCNDFCbW9ruTaLO(a) == CS_0024_003C_003E8__locals0.uid);
		if (projectItem != null)
		{
			return projectItem;
		}
		foreach (ProjectItem item in items)
		{
			if (item is ProjectFolderItem)
			{
				ProjectFolderItem projectFolderItem = item as ProjectFolderItem;
				projectItem = GetItemByUid(CS_0024_003C_003E8__locals0.uid, projectFolderItem.Items);
				if (projectItem != null)
				{
					return projectItem;
				}
			}
		}
		return null;
	}

	public ProjectItem GetItemByUid(Guid uid)
	{
		return GetItemByUid(uid, base.Items);
	}

	public void RemoveItemByUid(Guid uid)
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
				RemoveItemByUid(uid, base.Items);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void RemoveItemByUid(Guid uid, List<ProjectItem> items)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		ProjectItem projectItem = items.FirstOrDefault((ProjectItem a) => _003C_003Ec__DisplayClass8_0.RB5wMyCNHVsOyVOrcvgM(a.Uid, CS_0024_003C_003E8__locals0.uid));
		if (projectItem != null)
		{
			items.Remove(projectItem);
			return;
		}
		foreach (ProjectItem item in items)
		{
			if (item is ProjectFolderItem)
			{
				ProjectFolderItem projectFolderItem = item as ProjectFolderItem;
				RemoveItemByUid(CS_0024_003C_003E8__locals0.uid, projectFolderItem.Items);
			}
		}
	}

	internal static bool wpSF3VbKuvRo8SsTBWkf()
	{
		return zdrXfGbKZou84TbOWsDS == null;
	}

	internal static ProjectInfo pm5djUbKIIdnAcMPH6Lo()
	{
		return zdrXfGbKZou84TbOWsDS;
	}
}
