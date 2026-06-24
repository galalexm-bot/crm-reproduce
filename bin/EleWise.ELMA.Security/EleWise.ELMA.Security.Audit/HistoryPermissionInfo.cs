using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Audit;

[Serializable]
[XmlRoot("HistoryPermissionInfo")]
public class HistoryPermissionInfo
{
	internal static HistoryPermissionInfo QgxC1VpkwGIhrqCHxBSL;

	[XmlElement("ObjectTypeUid")]
	public Guid ObjectTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectTypeUid_003Ek__BackingField;
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
					_003CObjectTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("RoleTypeUid")]
	public Guid RoleTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CRoleTypeUid_003Ek__BackingField;
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
					_003CRoleTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
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

	[XmlElement("ObjectId")]
	public long ObjectId
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectId_003Ek__BackingField;
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
					_003CObjectId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
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

	[XmlElement("PermissionId")]
	public Guid PermissionId
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissionId_003Ek__BackingField;
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
					_003CPermissionId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
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

	[XmlElement("ManageAccess")]
	public bool ManageAccess
	{
		[CompilerGenerated]
		get
		{
			return _003CManageAccess_003Ek__BackingField;
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
					_003CManageAccess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
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

	public IEntity GetObject()
	{
		return (IEntity)EtjscmpkvR9BoUc3EHut(EntityHelper.GetEntityManager(Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(ObjectTypeUid)), ObjectId);
	}

	public Permission GetPermission()
	{
		return Locator.GetServiceNotNull<IPermissionManagmentService>().GetPermissions().FirstOrDefault((Permission p) => qxd9umpkoEsJ02ZZO9ig(pYeDGkpkUl1TTfVdWTFk(p), PermissionId));
	}

	public HistoryPermissionInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Vsm1KKpkCDZL310QeFAx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TRPPjrpk2Lmp7PUQ7AF2()
	{
		return QgxC1VpkwGIhrqCHxBSL == null;
	}

	internal static HistoryPermissionInfo fUPpAPpkPXjMGS8Oljjh()
	{
		return QgxC1VpkwGIhrqCHxBSL;
	}

	internal static object EtjscmpkvR9BoUc3EHut(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static void Vsm1KKpkCDZL310QeFAx()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static Guid pYeDGkpkUl1TTfVdWTFk(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool qxd9umpkoEsJ02ZZO9ig(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
