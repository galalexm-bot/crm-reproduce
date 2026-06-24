using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models;

[Serializable]
[DataContract]
public class AddPermissionModel
{
	internal static AddPermissionModel Lcne7FJM7d0OVXF9v4T;

	[DataMember]
	public Type EntityType
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityType_003Ek__BackingField;
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
					_003CEntityType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public EntityMetadata EntityMetadata
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityMetadata_003Ek__BackingField;
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
					_003CEntityMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
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

	[DataMember]
	public Dictionary<object, List<IUser>> Dictionary { get; set; }

	[DataMember]
	public Guid[] DefaultPermissions
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultPermissions_003Ek__BackingField;
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
					_003CDefaultPermissions_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> PermissionTypeRolesModels { get; set; }

	[DataMember]
	public bool HasGrantPermission
	{
		[CompilerGenerated]
		get
		{
			return _003CHasGrantPermission_003Ek__BackingField;
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
					_003CHasGrantPermission_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Dictionary<long, IEnumerable<Permission>> GrandPermissions { get; set; }

	public AddPermissionModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xr0Id0JI8hx0nhueyvu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public AddPermissionModel(Type type, EntityMetadata entityMetadata, IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> stereotypes)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		PermissionTypeRolesModels = stereotypes;
		EntityType = type;
		EntityMetadata = entityMetadata;
	}

	internal static void xr0Id0JI8hx0nhueyvu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool idOaomJsauybTsTbsGg()
	{
		return Lcne7FJM7d0OVXF9v4T == null;
	}

	internal static AddPermissionModel ebBug6JYQyGcc7P2KmU()
	{
		return Lcne7FJM7d0OVXF9v4T;
	}
}
