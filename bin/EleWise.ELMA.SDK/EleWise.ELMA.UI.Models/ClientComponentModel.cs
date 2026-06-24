using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[DataContract]
public sealed class ClientComponentModel : ICloneable
{
	internal static ClientComponentModel WbUDGsBWF4VrFD1lD3Xq;

	[DataMember]
	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
					_003CItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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
	public Guid ModuleUid
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
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
	public Guid ModuleItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleItemUid_003Ek__BackingField;
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
					_003CModuleItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
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
	public bool Async
	{
		[CompilerGenerated]
		get
		{
			return _003CAsync_003Ek__BackingField;
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
					_003CAsync_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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
	public HashSet<Guid> Owners { get; set; }

	[DataMember]
	public HashSet<string> RenderUidList { get; set; }

	[DataMember]
	public List<ClientFunctionModel> Functions { get; set; }

	[DataMember]
	public List<ClientDataClassModel> DataClasses { get; set; }

	public ClientComponentModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				Functions = new List<ClientFunctionModel>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num = 4;
				}
				break;
			case 2:
				RenderUidList = new HashSet<string>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 0;
				}
				break;
			case 3:
				Owners = new HashSet<Guid>();
				num = 2;
				break;
			case 4:
				DataClasses = new List<ClientDataClassModel>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public object Clone()
	{
		ClientComponentModel obj = new ClientComponentModel
		{
			Async = Async
		};
		JN5pFwBWojh2BbFM2pwj(obj, ItemUid);
		S5H7kEBWbHGAODHbWao5(obj, ModuleUid);
		msZersBWhpptaVGdG0kK(obj, ModuleItemUid);
		obj.Functions.AddRange(Functions.Select((ClientFunctionModel f) => (ClientFunctionModel)_003C_003Ec.TgZdsdQW0KvhpSZ26hc0(f)));
		obj.DataClasses.AddRange(DataClasses.Select((ClientDataClassModel d) => (ClientDataClassModel)_003C_003Ec.Oxa8yxQWmcoFxC1aXg6b(d)));
		obj.Owners.AddRange(Owners);
		obj.RenderUidList.AddRange(RenderUidList);
		return obj;
	}

	internal static bool GAZFDtBWBSUZedo0kXB7()
	{
		return WbUDGsBWF4VrFD1lD3Xq == null;
	}

	internal static ClientComponentModel qQLGTRBWWepYmik3sSPN()
	{
		return WbUDGsBWF4VrFD1lD3Xq;
	}

	internal static void JN5pFwBWojh2BbFM2pwj(object P_0, Guid value)
	{
		((ClientComponentModel)P_0).ItemUid = value;
	}

	internal static void S5H7kEBWbHGAODHbWao5(object P_0, Guid value)
	{
		((ClientComponentModel)P_0).ModuleUid = value;
	}

	internal static void msZersBWhpptaVGdG0kK(object P_0, Guid value)
	{
		((ClientComponentModel)P_0).ModuleItemUid = value;
	}
}
