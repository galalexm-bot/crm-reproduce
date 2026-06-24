using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class CustomActivityFolderDTOManager : DTOManager, ICustomActivityFolderDTOManager, IConfigurationService
{
	private static CustomActivityFolderDTOManager amWnr4PwpsGhKa1d1P9;

	public CustomActivityFolderManager CustomActivityFolderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityFolderManager_003Ek__BackingField;
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
					_003CCustomActivityFolderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CustomActivityHeaderManager CustomActivityHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityHeaderManager_003Ek__BackingField;
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
					_003CCustomActivityHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual CustomActivityFolderDTO LoadOrNull(Guid uid)
	{
		return Mapper.Map<ICustomActivityFolder, CustomActivityFolderDTO>(CustomActivityFolderManager.LoadOrNull(uid), new CustomActivityFolderDTO());
	}

	public virtual CustomActivityFolderDTO LoadOrNull(long id)
	{
		return Mapper.Map<ICustomActivityFolder, CustomActivityFolderDTO>(CustomActivityFolderManager.LoadOrNull(id), new CustomActivityFolderDTO());
	}

	public virtual CustomActivityFolderDTO LoadRootFolder(long updateCA = 0L, bool? published = null)
	{
		CustomActivityFolderDTO customActivityFolderDTO = new CustomActivityFolderDTO
		{
			Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-182059571 ^ -182087303))
		};
		IEnumerable<ICustomActivityFolder> subFolders = CustomActivityFolderManager.LoadRootFolders();
		IEnumerable<ICustomActivityHeader> caHeads = CustomActivityHeaderManager.LoadRootCustomActivityHeader(published);
		FillFolderChilds(customActivityFolderDTO, subFolders, caHeads, updateCA);
		return customActivityFolderDTO;
	}

	public virtual IEnumerable<CustomActivityFolderDTO> GetChildFolders(long parentFolderId)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.parentFolder = ((parentFolderId > 0) ? CustomActivityFolderManager.Load(parentFolderId) : null);
		CustomActivityFolderManager customActivityFolderManager = CustomActivityFolderManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ICustomActivityFolder), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-897645572 ^ -897624038));
		return (from g in customActivityFolderManager.Find(Expression.Lambda<Func<ICustomActivityFolder, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<ICustomActivityFolder, CustomActivityFolderDTO>(g)).ToList();
	}

	public virtual CustomActivityFolderDTO Save(CustomActivityFolderDTO folder)
	{
		int num = 1;
		int num2 = num;
		ICustomActivityFolder customActivityFolder = default(ICustomActivityFolder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				customActivityFolder = Mapper.Map<CustomActivityFolderDTO, ICustomActivityFolder>(folder);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return Mapper.Map<ICustomActivityFolder, CustomActivityFolderDTO>(customActivityFolder, folder);
			default:
				CypcAQP2gB6WSJ74mg1(customActivityFolder);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (zKmLBvPqaXSGvcC9EHS(customActivityFolder) != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 4:
				B9th6ePQbGS1FrVHBaZ(zKmLBvPqaXSGvcC9EHS(customActivityFolder));
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual void Delete(long folderId)
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
				o7g333PVOjcmMQ0Bymm(CustomActivityFolderManager, folderId);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void FindHeader(ICustomActivityHeader header, long id, List<ICustomActivityHeader> result)
	{
		if (header.Id == id)
		{
			result.Add(header);
		}
		_ = result.Count;
		_ = 0;
	}

	private void FillFolderChilds(CustomActivityFolderDTO folderDto, IEnumerable<ICustomActivityFolder> subFolders, IEnumerable<ICustomActivityHeader> caHeads, long updateCA = 0L)
	{
		foreach (ICustomActivityFolder subFolder in subFolders)
		{
			CustomActivityFolderDTO item = Mapper.Map<ICustomActivityFolder, CustomActivityFolderDTO>(subFolder, new CustomActivityFolderDTO());
			folderDto.SubFolders.Add(item);
		}
		foreach (ICustomActivityHeader caHead in caHeads)
		{
			if (updateCA > 0)
			{
				List<ICustomActivityHeader> list = new List<ICustomActivityHeader>();
				FindHeader(caHead, updateCA, list);
				if (list.Count > 0)
				{
					list[0].Refresh();
				}
			}
			CustomActivityHeaderDTO item2 = Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(caHead, new CustomActivityHeaderDTO());
			folderDto.CustomActivitys.Add(item2);
		}
	}

	public CustomActivityFolderDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j8tJ49PDxDKtUrVOtr2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zM97lSPtRFo7cWvN13d()
	{
		return amWnr4PwpsGhKa1d1P9 == null;
	}

	internal static CustomActivityFolderDTOManager eRfrOXPsMgkZbcWeDrG()
	{
		return amWnr4PwpsGhKa1d1P9;
	}

	internal static void CypcAQP2gB6WSJ74mg1(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object zKmLBvPqaXSGvcC9EHS(object P_0)
	{
		return ((ICustomActivityFolder)P_0).Folder;
	}

	internal static void B9th6ePQbGS1FrVHBaZ(object P_0)
	{
		((IEntity)P_0).Refresh();
	}

	internal static void o7g333PVOjcmMQ0Bymm(object P_0, long folderId)
	{
		((CustomActivityFolderManager)P_0).Delete(folderId);
	}

	internal static void j8tJ49PDxDKtUrVOtr2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
