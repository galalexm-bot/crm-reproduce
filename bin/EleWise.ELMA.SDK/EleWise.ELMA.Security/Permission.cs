using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public class Permission : IIdentified
{
	private readonly Func<string> name;

	private readonly string description;

	private readonly string category;

	private static Permission NjsR2CBYWCVB2Z4o3NQn;

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Name => name();

	public string Description => (string)vwOriYBYfKVvGqoPn5bZ(description);

	[Display(Name = "Категория")]
	public string Category => (string)vwOriYBYfKVvGqoPn5bZ(category);

	public Permission[] Dependencies
	{
		[CompilerGenerated]
		get
		{
			return _003CDependencies_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CDependencies_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	public IEnumerable<Permission> AllDependencies => Dependencies.Union(Dependencies.SelectMany((Permission d) => d.AllDependencies));

	public string ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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

	public bool CheckModuleAccess
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckModuleAccess_003Ek__BackingField;
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
					_003CCheckModuleAccess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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

	public PermissionType PermissionType
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissionType_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CPermissionType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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

	public bool IsInstanceSettingsPermission
	{
		[CompilerGenerated]
		get
		{
			return _003CIsInstanceSettingsPermission_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CIsInstanceSettingsPermission_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Permission Base
	{
		[CompilerGenerated]
		get
		{
			return _003CBase_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CBase_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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

	public Permission[] AdminPermissions
	{
		[CompilerGenerated]
		get
		{
			return _003CAdminPermissions_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CAdminPermissions_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Type EntityType
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityType_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Inverse
	{
		[CompilerGenerated]
		get
		{
			return _003CInverse_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CInverse_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ShowInGlobalSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CShowInGlobalSettings_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CShowInGlobalSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ReadOnly
	{
		[CompilerGenerated]
		get
		{
			return _003CReadOnly_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CReadOnly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Permission ParentPermission
	{
		[CompilerGenerated]
		get
		{
			return _003CParentPermission_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CParentPermission_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Func<object, object> ParentResolve { get; internal set; }

	public bool ParentAllTargets
	{
		[CompilerGenerated]
		get
		{
			return _003CParentAllTargets_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CParentAllTargets_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
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

	public Permission ProfileForPermission
	{
		[CompilerGenerated]
		get
		{
			return _003CProfileForPermission_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CProfileForPermission_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
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

	public Func<Permission, string> getDisplayName { get; internal set; }

	public static PermissionBuilder Create(Guid id, Func<string> name, string description, string category)
	{
		return new PermissionBuilder(id, name, description, category);
	}

	public static PermissionBuilder Create(Guid id, string name, string description, string category)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass1_.name = name;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Create(id, _003C_003Ec__DisplayClass1_._003CCreate_003Eb__0, description, category);
			case 2:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static PermissionBuilder Create(string id, string name, string description, string category)
	{
		return (PermissionBuilder)ybstEUBYG1LTi7aHmBxx(G0UMYdBYhiN7X3eOFB7R(id), name, description, category);
	}

	[Obsolete("Use Permission.Create instead")]
	public Permission(Guid id, Func<string> name, string description, string category, Permission[] dependencies = null, string moduleUid = null, PermissionType permissionType = PermissionType.Global, Permission @base = null, Type entityType = null, bool showInGlobalSettings = true, bool readOnly = false)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Id = id;
		this.name = name;
		this.description = description;
		this.category = category;
		Dependencies = dependencies ?? new Permission[0];
		ModuleUid = moduleUid;
		PermissionType = permissionType;
		Base = @base;
		EntityType = entityType;
		ShowInGlobalSettings = showInGlobalSettings;
		ReadOnly = readOnly;
		CheckModuleAccess = true;
	}

	[Obsolete("Use Permission.Create instead")]
	public Permission(Guid id, string name, string description, string category, Permission[] dependencies = null, string moduleUid = null, PermissionType permissionType = PermissionType.Global, Permission @base = null, Type entityType = null, bool showInGlobalSettings = true, bool readOnly = false)
	{
		//Discarded unreachable code: IL_0062, IL_0067
		qs99kDBYEDituxjVnqn1();
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.name = name;
		this._002Ector(id, () => (string)_003C_003Ec__DisplayClass4_0.DaAc7rQPB9R7Z4eYB3iL(CS_0024_003C_003E8__locals0.name), description, category, dependencies, moduleUid, permissionType, @base, entityType, showInGlobalSettings, readOnly);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[Obsolete("Use Permission.Create instead")]
	public Permission(string id, string name, string description, string category, Permission[] dependencies = null, string moduleUid = null, PermissionType permissionType = PermissionType.Global, Permission @base = null, Type entityType = null, bool showInGlobalSettings = true, bool readOnly = false)
	{
		//Discarded unreachable code: IL_0042, IL_0047
		qs99kDBYEDituxjVnqn1();
		this._002Ector(Guid.Parse(id), name, description, category, dependencies, moduleUid, permissionType, @base, entityType, showInGlobalSettings, readOnly);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public object GetId()
	{
		return Id;
	}

	public void SetId(object id)
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
				Id = (Guid)id;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool IsInheritOrSame(Permission @base, Permission target)
	{
		//Discarded unreachable code: IL_0058, IL_006b, IL_007a, IL_00d7, IL_00e6
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(target.Base != null))
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 3:
				if (!IHj5p1BYCQ4fbVwbNqVa(target, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 5:
				if (qNvahlBYQJeaJPiZu5ED(@base, target))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 2:
				return aEnii9BY81fZLJ3Ac3We(@base, pDVKhrBYvibd6eJdhpFT(target));
			default:
				return false;
			case 4:
				return true;
			}
		}
	}

	public override string ToString()
	{
		return (string)aOYowsBYuukp4oU6FfT4(iyYjuZBYZxPjXVVfkNCi(-398663332 ^ -398616482), new object[7] { Id, Name, Description, Category, Dependencies, ModuleUid, PermissionType });
	}

	public bool Equals(Permission other)
	{
		//Discarded unreachable code: IL_0114, IL_021d
		int num = 10;
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					if (itj8DqBYSOtuRITZ9KPy(pDVKhrBYvibd6eJdhpFT(other), Base))
					{
						goto end_IL_0012;
					}
					goto default;
				case 2:
					return false;
				case 9:
					if ((object)this == other)
					{
						num2 = 6;
						break;
					}
					guid = qOGKvZBYILwWYRh2EgCH(other);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 8;
					}
					break;
				case 3:
					if (itj8DqBYSOtuRITZ9KPy(other.Category, Category))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 12;
						}
						break;
					}
					goto default;
				case 12:
					if (object.Equals(c8cPOSBYRlceHX7tF6Xd(other), Dependencies))
					{
						num2 = 5;
						break;
					}
					goto default;
				case 7:
					return MYLTyoBYTCLQD0W8pHl9(rh68x1BYXprbYq9m1gfl(other), EntityType);
				default:
					return false;
				case 4:
					if (itj8DqBYSOtuRITZ9KPy(ThQ6X6BYi5vDu6BheGHp(other), Description))
					{
						num2 = 3;
						break;
					}
					goto default;
				case 11:
					if (itj8DqBYSOtuRITZ9KPy(aaQZiOBYKo9OyVpnZbAS(other), PermissionType))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 13;
						}
						break;
					}
					goto default;
				case 1:
					if (itj8DqBYSOtuRITZ9KPy(ojqnE8BYVowxZyUJXkpm(other), Name))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case 10:
					if ((object)other != null)
					{
						num2 = 9;
						break;
					}
					goto case 2;
				case 6:
					return true;
				case 8:
					if (guid.Equals(Id))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 5:
					if (!itj8DqBYSOtuRITZ9KPy(xSmTqiBYqFqLCHPa4UJq(other), ModuleUid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 11;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_009a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 3:
				return true;
			case 4:
				return false;
			}
			if (this != obj)
			{
				if (!(obj.GetType() != typeof(Permission)))
				{
					return Equals((Permission)obj);
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		Guid id = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				id = Id;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (((((((((((((((((id.GetHashCode() * 397) ^ ((Name != null) ? Name.GetHashCode() : 0)) * 397) ^ ((Description != null) ? Description.GetHashCode() : 0)) * 397) ^ ((Category != null) ? Category.GetHashCode() : 0)) * 397) ^ ((Dependencies != null) ? Dependencies.GetHashCode() : 0)) * 397) ^ ((ModuleUid != null) ? ModuleUid.GetHashCode() : 0)) * 397) ^ CheckModuleAccess.GetHashCode()) * 397) ^ PermissionType.GetHashCode()) * 397) ^ (IHj5p1BYCQ4fbVwbNqVa(Base, null) ? Base.GetHashCode() : 0)) * 397) ^ (ywYJpuBYkZADfddCiRY9(EntityType, null) ? EntityType.GetHashCode() : 0);
			}
		}
	}

	public static bool operator ==(Permission a, Permission b)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00d0, IL_00f2, IL_0101
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if ((object)b == null)
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 2:
				if ((object)a != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 3:
				return eHBLjDBYno8XulFkfmei(a, b);
			case 4:
				return true;
			case 1:
				if ((object)a == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 7;
			case 7:
				if ((object)b != null)
				{
					num2 = 8;
					break;
				}
				goto default;
			default:
				return false;
			case 8:
				if ((object)a == b)
				{
					return true;
				}
				num2 = 3;
				break;
			}
		}
	}

	public static bool operator !=(Permission a, Permission b)
	{
		return !qNvahlBYQJeaJPiZu5ED(a, b);
	}

	internal static bool phf8MIBYooA9hTfLLAqN()
	{
		return (object)NjsR2CBYWCVB2Z4o3NQn == null;
	}

	internal static Permission x6YBHfBYbdE8Y4PBbaEk()
	{
		return NjsR2CBYWCVB2Z4o3NQn;
	}

	internal static Guid G0UMYdBYhiN7X3eOFB7R(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static object ybstEUBYG1LTi7aHmBxx(Guid id, object P_1, object P_2, object P_3)
	{
		return Create(id, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static void qs99kDBYEDituxjVnqn1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object vwOriYBYfKVvGqoPn5bZ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool qNvahlBYQJeaJPiZu5ED(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static bool IHj5p1BYCQ4fbVwbNqVa(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static object pDVKhrBYvibd6eJdhpFT(object P_0)
	{
		return ((Permission)P_0).Base;
	}

	internal static bool aEnii9BY81fZLJ3Ac3We(object P_0, object P_1)
	{
		return IsInheritOrSame((Permission)P_0, (Permission)P_1);
	}

	internal static object iyYjuZBYZxPjXVVfkNCi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aOYowsBYuukp4oU6FfT4(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static Guid qOGKvZBYILwWYRh2EgCH(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static object ojqnE8BYVowxZyUJXkpm(object P_0)
	{
		return ((Permission)P_0).Name;
	}

	internal static bool itj8DqBYSOtuRITZ9KPy(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object ThQ6X6BYi5vDu6BheGHp(object P_0)
	{
		return ((Permission)P_0).Description;
	}

	internal static object c8cPOSBYRlceHX7tF6Xd(object P_0)
	{
		return ((Permission)P_0).Dependencies;
	}

	internal static object xSmTqiBYqFqLCHPa4UJq(object P_0)
	{
		return ((Permission)P_0).ModuleUid;
	}

	internal static PermissionType aaQZiOBYKo9OyVpnZbAS(object P_0)
	{
		return ((Permission)P_0).PermissionType;
	}

	internal static Type rh68x1BYXprbYq9m1gfl(object P_0)
	{
		return ((Permission)P_0).EntityType;
	}

	internal static bool MYLTyoBYTCLQD0W8pHl9(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool ywYJpuBYkZADfddCiRY9(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool eHBLjDBYno8XulFkfmei(object P_0, object P_1)
	{
		return ((Permission)P_0).Equals((Permission)P_1);
	}
}
