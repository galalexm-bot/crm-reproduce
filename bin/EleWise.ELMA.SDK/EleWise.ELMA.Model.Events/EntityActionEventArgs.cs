using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Dynamic;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Events;

[Uid("E190A53F-D5D9-43AD-A4F4-0A1347584F45")]
[Component]
public class EntityActionEventArgs : EntityTypeEventArgs, IEntityHistoryEventArgs, IAuditEventArgs, IAuditEventHolder, IExtendedPropertiesContainer
{
	protected IEntity oldEntity;

	protected IEntity newEntity;

	private Guid _unitOfWorkUid;

	protected const string EntityActionHistory_UsersToObjects = "EntityActionHistory_UsersToObjects";

	private IAuthenticationService authenticationService;

	internal static EntityActionEventArgs YVAAoLoB8hvlN4if1DkF;

	[JsonIgnore]
	public virtual IEntity Old
	{
		get
		{
			return oldEntity;
		}
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
					oldEntity = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[JsonIgnore]
	public virtual IEntity New
	{
		get
		{
			return newEntity;
		}
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
					newEntity = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime ActionDate
	{
		[CompilerGenerated]
		get
		{
			return _003CActionDate_003Ek__BackingField;
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
					_003CActionDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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

	[JsonIgnore]
	public IUser ActionAuthor
	{
		[CompilerGenerated]
		get
		{
			return _003CActionAuthor_003Ek__BackingField;
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
					_003CActionAuthor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
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

	public Guid UnitOfWorkUid
	{
		get
		{
			return _unitOfWorkUid;
		}
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
					_unitOfWorkUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
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

	public bool Multiple
	{
		[CompilerGenerated]
		get
		{
			return _003CMultiple_003Ek__BackingField;
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
					_003CMultiple_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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

	[JsonIgnore]
	public override IDictionary<string, object> ExtendedProperties
	{
		get
		{
			IDictionary<string, object> extendedProperties = base.ExtendedProperties;
			if (Old != null)
			{
				extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289685456)] = Old;
			}
			else if (extendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672089247)))
			{
				extendedProperties.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C941BEE));
			}
			if (New != null)
			{
				extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583629282)] = New;
			}
			else if (extendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4787FAE7)))
			{
				extendedProperties.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882272376));
			}
			if (ActionAuthor != null)
			{
				extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x47853A27)] = ActionAuthor;
			}
			else if (extendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD5D67A)))
			{
				extendedProperties.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6EDC21));
			}
			_ = ActionDate;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AF8A2C)] = ActionDate;
			return extendedProperties;
		}
	}

	protected IAuthenticationService AuthenticationService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IAuthenticationService authenticationService = default(IAuthenticationService);
			IAuthenticationService obj;
			while (true)
			{
				switch (num2)
				{
				default:
					authenticationService = (this.authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.authenticationService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = authenticationService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public EntityActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
	{
		//Discarded unreachable code: IL_005b, IL_0060, IL_00c6
		psDvNvoBIsYeXsCBP5yk();
		_unitOfWorkUid = Guid.Empty;
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.actionUid = actionUid;
		base._002Ector(jbEwgYoBVPxsbOLXfaT6((@new ?? old).CastAsRealType().GetType()));
		int num = 5;
		IEnumerable<IAuditActionProvider> extensionPoints = default(IEnumerable<IAuditActionProvider>);
		while (true)
		{
			int condition;
			switch (num)
			{
			case 6:
				return;
			default:
				extensionPoints = ((ComponentManager)P8uiApoBi6E4p5c8YSSg()).GetExtensionPoints<IAuditActionProvider>();
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 7;
				}
				break;
			case 1:
				condition = ((@new != null) ? 1 : 0);
				goto IL_0155;
			case 4:
				if (old == null)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num = 1;
					}
					break;
				}
				condition = 1;
				goto IL_0155;
			case 9:
				oldEntity = old;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 2;
				}
				break;
			case 2:
				newEntity = @new;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num = 0;
				}
				break;
			case 3:
				ActionDate = gdmBCioBKeAG9QykiPHe();
				num = 6;
				break;
			case 5:
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				num = 4;
				break;
			case 7:
				auditAction = extensionPoints.Select((IAuditActionProvider p) => (IAuditAction)_003C_003Ec__DisplayClass0_0.BplUveCW5YAmHEnODqr2(p, CS_0024_003C_003E8__locals0._003C_003E4__this.auditObject, CS_0024_003C_003E8__locals0.actionUid)).FirstOrDefault((IAuditAction a) => a != null);
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num = 2;
				}
				break;
			case 8:
				{
					ActionAuthor = (IUser)(mKTcKCoBRUJAPCIb9JCc(this, @new) ?? brFvAxoBqtVQ803bEyQx(AuthenticationService));
					num = 3;
					break;
				}
				IL_0155:
				B17mBFoBSUJvaV8d5IHF((byte)condition != 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E65895));
				num = 9;
				break;
			}
		}
	}

	public EntityActionEventArgs(IEntity old, IEntity @new, string actionUidStr)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		psDvNvoBIsYeXsCBP5yk();
		this._002Ector(old, @new, new Guid(actionUidStr));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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
			t9B75soBXuTPEL86536s(actionUidStr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951365792));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
			{
				num = 1;
			}
		}
	}

	public static void SetUserForHistory(IUser user, IEntity obj)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (user == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				ContextVars.GetOrAdd((string)fat1KIoBTH2LVBLW4egG(-1334993905 ^ -1334846803), () => new Dictionary<IEntity, IUser>())[obj] = user;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (obj != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 1:
				return;
			case 0:
				return;
			}
		}
	}

	public static bool TryGetUserForHistory(IEntity obj, out IUser user)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				user = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return false;
			case 1:
				return ContextVars.GetOrAdd((string)fat1KIoBTH2LVBLW4egG(0x3C5338FF ^ 0x3C517E5D), () => new Dictionary<IEntity, IUser>()).TryGetValue(obj, out user);
			}
		}
	}

	public static EntityActionEventArgs TryCreate(IEntity old, IEntity @new, Guid actionUid)
	{
		//Discarded unreachable code: IL_004c, IL_00ee, IL_00fd, IL_0128, IL_0160, IL_016f
		EntityActionEventArgs result = default(EntityActionEventArgs);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(old, @new, actionUid);
				int num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						return result;
					case 4:
						if (TBBnSaoBk5L5Ve20dVjF(entityActionEventArgs) == null)
						{
							num = 2;
							continue;
						}
						goto case 3;
					case 3:
						result = entityActionEventArgs;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num = 0;
						}
						continue;
					case 5:
						if (entityActionEventArgs.Action != null)
						{
							num = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num = 0;
							}
							continue;
						}
						break;
					case 2:
						break;
					}
					result = null;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num = 1;
					}
				}
			}
			catch
			{
				int num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public static EntityActionEventArgs TryCreate(IEntity old, IEntity @new, string actionUidStr)
	{
		//Discarded unreachable code: IL_004b, IL_007d, IL_00b5, IL_00c4
		int num = 2;
		int num2 = num;
		Guid actionUid = default(Guid);
		EntityActionEventArgs result = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					actionUid = new Guid(actionUidStr);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return result;
						}
						result = null;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num4 = 1;
						}
					}
				}
				break;
			case 2:
				t9B75soBXuTPEL86536s(actionUidStr, fat1KIoBTH2LVBLW4egG(-398663332 ^ -398546982));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			break;
		}
		return (EntityActionEventArgs)dSc5RYoBn5R5VLn0s2v6(old, @new, actionUid);
	}

	public virtual byte[] GetAdditionalData()
	{
		return null;
	}

	public virtual void SetAdditionalData(byte[] data)
	{
	}

	public bool Equals(EntityActionEventArgs other)
	{
		//Discarded unreachable code: IL_0167, IL_0176, IL_0185, IL_02ea, IL_033c, IL_034b, IL_035b, IL_036a, IL_037a, IL_03da, IL_03e9, IL_03f8, IL_0436, IL_04e2, IL_0525, IL_0534, IL_0544, IL_05b8, IL_05c7, IL_05eb, IL_05fa, IL_062f, IL_063e, IL_064d, IL_0672, IL_0709, IL_0718, IL_0728
		int num = 2;
		DateTime actionDate = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 24:
					if (tFCt2RoB2GpoXhGt3gHN(mSBSiHoBOx1pVIWxjuAV(other)) != null)
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				case 43:
				case 54:
					if (NMhi73oBNghfXhR3QeP4(other) == null)
					{
						num = 31;
						break;
					}
					goto case 28;
				case 37:
					if (other.ActionAuthor == null)
					{
						num2 = 12;
						continue;
					}
					goto case 51;
				case 23:
					if (tFCt2RoB2GpoXhGt3gHN(mSBSiHoBOx1pVIWxjuAV(this)) != null)
					{
						num2 = 32;
						continue;
					}
					goto case 14;
				case 10:
					if (mSBSiHoBOx1pVIWxjuAV(this) == null)
					{
						num2 = 22;
						continue;
					}
					goto case 39;
				case 12:
					if (ActionAuthor == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 51;
				case 3:
					if (zYmRJEoBPMs4IBFKZ77M(this) != null)
					{
						num2 = 21;
						continue;
					}
					goto case 5;
				case 21:
					if (tFCt2RoB2GpoXhGt3gHN(other.New) != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 17;
				case 6:
					if (!xQqhyQoBebPCWrp2EZ5M(((IIdentified)NMhi73oBNghfXhR3QeP4(other)).GetId().ToString(), ActionAuthor.GetId().ToString()))
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto default;
				case 41:
					if (ActionAuthor != null)
					{
						num = 48;
						break;
					}
					goto case 43;
				case 11:
					if (tFCt2RoB2GpoXhGt3gHN(ActionAuthor) == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 43;
				case 2:
					if (!base.Equals((object)other))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 50;
				case 52:
					if (mSBSiHoBOx1pVIWxjuAV(this) == null)
					{
						num2 = 4;
						continue;
					}
					goto case 24;
				case 26:
					if (((IIdentified)zYmRJEoBPMs4IBFKZ77M(this)).GetId() != null)
					{
						num2 = 27;
						continue;
					}
					goto case 1;
				case 51:
					if (other.ActionAuthor != null)
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 43;
				case 48:
					if (tFCt2RoB2GpoXhGt3gHN(NMhi73oBNghfXhR3QeP4(other)) != null)
					{
						num = 43;
						break;
					}
					goto case 11;
				case 9:
					if (tFCt2RoB2GpoXhGt3gHN(mSBSiHoBOx1pVIWxjuAV(this)) != null)
					{
						num2 = 45;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 41;
						}
						continue;
					}
					goto case 1;
				case 35:
				case 55:
				case 56:
					actionDate = ActionDate;
					num2 = 46;
					continue;
				case 14:
					if (zYmRJEoBPMs4IBFKZ77M(other) == null)
					{
						num2 = 18;
						continue;
					}
					goto case 30;
				case 29:
					if (((IIdentified)NMhi73oBNghfXhR3QeP4(other)).GetId() != null)
					{
						num2 = 36;
						continue;
					}
					goto case 1;
				default:
					return o8A79ToB3dtxTnt30rMK(other) == UnitOfWorkUid;
				case 1:
				case 4:
				case 8:
				case 16:
				case 19:
				case 25:
				case 31:
				case 38:
				case 40:
				case 44:
				case 53:
					return false;
				case 33:
					if (mSBSiHoBOx1pVIWxjuAV(other) == null)
					{
						num = 34;
						break;
					}
					goto case 10;
				case 22:
				case 32:
				case 34:
				case 49:
					if (mSBSiHoBOx1pVIWxjuAV(other) == null)
					{
						num = 44;
						break;
					}
					goto case 52;
				case 39:
					if (tFCt2RoB2GpoXhGt3gHN(mSBSiHoBOx1pVIWxjuAV(other)) != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 23;
				case 46:
					if (!actionDate.Equals(hQiDxeoB17Fru5JYuOxv(other)))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 37;
				case 5:
				case 7:
					if (zYmRJEoBPMs4IBFKZ77M(other) != null)
					{
						num2 = 13;
						continue;
					}
					goto case 1;
				case 27:
					if (!xQqhyQoBebPCWrp2EZ5M(tFCt2RoB2GpoXhGt3gHN(zYmRJEoBPMs4IBFKZ77M(other)).ToString(), tFCt2RoB2GpoXhGt3gHN(zYmRJEoBPMs4IBFKZ77M(this)).ToString()))
					{
						num2 = 38;
						continue;
					}
					goto case 35;
				case 42:
					if (other.New.GetId() == null)
					{
						num = 16;
						break;
					}
					goto case 26;
				case 28:
					if (ActionAuthor == null)
					{
						num = 19;
						break;
					}
					goto case 29;
				case 17:
					if (tFCt2RoB2GpoXhGt3gHN(zYmRJEoBPMs4IBFKZ77M(this)) == null)
					{
						num2 = 55;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 39;
						}
						continue;
					}
					goto case 5;
				case 13:
					if (zYmRJEoBPMs4IBFKZ77M(this) == null)
					{
						num2 = 25;
						continue;
					}
					goto case 42;
				case 30:
					if (other.New != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 5;
				case 50:
					if (mSBSiHoBOx1pVIWxjuAV(other) == null)
					{
						num2 = 47;
						continue;
					}
					goto case 33;
				case 47:
					if (Old != null)
					{
						num2 = 33;
						continue;
					}
					goto case 14;
				case 45:
					if (!xQqhyQoBebPCWrp2EZ5M(tFCt2RoB2GpoXhGt3gHN(mSBSiHoBOx1pVIWxjuAV(other)).ToString(), tFCt2RoB2GpoXhGt3gHN(mSBSiHoBOx1pVIWxjuAV(this)).ToString()))
					{
						num2 = 53;
						continue;
					}
					goto case 14;
				case 18:
					if (zYmRJEoBPMs4IBFKZ77M(this) == null)
					{
						num2 = 44;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 56;
						}
						continue;
					}
					goto case 30;
				case 36:
					if (ActionAuthor.GetId() != null)
					{
						num2 = 6;
						continue;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 2;
		int num2 = num;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 2:
				entityActionEventArgs = obj as EntityActionEventArgs;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (entityActionEventArgs != null)
				{
					return Equals(entityActionEventArgs);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override int GetHashCode()
	{
		return (((((((((base.GetHashCode() * 397) ^ ((mSBSiHoBOx1pVIWxjuAV(this) != null && tFCt2RoB2GpoXhGt3gHN(mSBSiHoBOx1pVIWxjuAV(this)) != null) ? tFCt2RoB2GpoXhGt3gHN(Old).GetHashCode() : 0)) * 397) ^ ((zYmRJEoBPMs4IBFKZ77M(this) != null && tFCt2RoB2GpoXhGt3gHN(zYmRJEoBPMs4IBFKZ77M(this)) != null) ? ((IIdentified)zYmRJEoBPMs4IBFKZ77M(this)).GetId().GetHashCode() : 0)) * 397) ^ ActionDate.GetHashCode()) * 397) ^ ((ActionAuthor != null && tFCt2RoB2GpoXhGt3gHN(ActionAuthor) != null) ? ActionAuthor.GetId().GetHashCode() : 0)) * 397) ^ UnitOfWorkUid.GetHashCode();
	}

	protected virtual IUser GetUserForHistory(IEntity obj)
	{
		int num = 1;
		int num2 = num;
		IUser user = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return user;
			case 1:
				if (!TryGetUserForHistory(obj, out user))
				{
					return AuthenticationService.GetCurrentUser<IUser>();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected EntityActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
	{
		//Discarded unreachable code: IL_0044, IL_0049
		psDvNvoBIsYeXsCBP5yk();
		_unitOfWorkUid = Guid.Empty;
		_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass41_0();
		CS_0024_003C_003E8__locals0.actionUid = actionUid;
		base._002Ector(objectUid);
		int num = 6;
		IEnumerable<IAuditActionProvider> extensionPoints = default(IEnumerable<IAuditActionProvider>);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				oldEntity = entity;
				num = 3;
				break;
			case 0:
				return;
			case 3:
				newEntity = entity;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 4;
				}
				break;
			case 4:
				extensionPoints = ((ComponentManager)P8uiApoBi6E4p5c8YSSg()).GetExtensionPoints<IAuditActionProvider>();
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				ActionDate = DateTime.Now;
				num = 5;
				break;
			case 6:
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num = 2;
				}
				break;
			case 7:
				auditAction = extensionPoints.Select((IAuditActionProvider p) => (IAuditAction)_003C_003Ec__DisplayClass41_0.idjaGCCoBOjHX0vA9Xe3(p, CS_0024_003C_003E8__locals0._003C_003E4__this.auditObject, CS_0024_003C_003E8__locals0.actionUid)).FirstOrDefault((IAuditAction a) => a != null);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 1;
				}
				break;
			case 5:
				ActionAuthor = (IUser)(mKTcKCoBRUJAPCIb9JCc(this, entity) ?? brFvAxoBqtVQ803bEyQx(AuthenticationService));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void psDvNvoBIsYeXsCBP5yk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type jbEwgYoBVPxsbOLXfaT6(Type type)
	{
		return type.GetTypeWithoutProxy();
	}

	internal static void B17mBFoBSUJvaV8d5IHF(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object P8uiApoBi6E4p5c8YSSg()
	{
		return ComponentManager.Current;
	}

	internal static object mKTcKCoBRUJAPCIb9JCc(object P_0, object P_1)
	{
		return ((EntityActionEventArgs)P_0).GetUserForHistory((IEntity)P_1);
	}

	internal static object brFvAxoBqtVQ803bEyQx(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static DateTime gdmBCioBKeAG9QykiPHe()
	{
		return DateTime.Now;
	}

	internal static bool RMM7YxoBZok8TxhwHG23()
	{
		return YVAAoLoB8hvlN4if1DkF == null;
	}

	internal static EntityActionEventArgs fM9aI9oBuCQepbYlAQ0A()
	{
		return YVAAoLoB8hvlN4if1DkF;
	}

	internal static void t9B75soBXuTPEL86536s(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object fat1KIoBTH2LVBLW4egG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TBBnSaoBk5L5Ve20dVjF(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static object dSc5RYoBn5R5VLn0s2v6(object P_0, object P_1, Guid actionUid)
	{
		return TryCreate((IEntity)P_0, (IEntity)P_1, actionUid);
	}

	internal static object mSBSiHoBOx1pVIWxjuAV(object P_0)
	{
		return ((EntityActionEventArgs)P_0).Old;
	}

	internal static object tFCt2RoB2GpoXhGt3gHN(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static bool xQqhyQoBebPCWrp2EZ5M(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object zYmRJEoBPMs4IBFKZ77M(object P_0)
	{
		return ((EntityActionEventArgs)P_0).New;
	}

	internal static DateTime hQiDxeoB17Fru5JYuOxv(object P_0)
	{
		return ((EntityActionEventArgs)P_0).ActionDate;
	}

	internal static object NMhi73oBNghfXhR3QeP4(object P_0)
	{
		return ((EntityActionEventArgs)P_0).ActionAuthor;
	}

	internal static Guid o8A79ToB3dtxTnt30rMK(object P_0)
	{
		return ((EntityActionEventArgs)P_0).UnitOfWorkUid;
	}
}
