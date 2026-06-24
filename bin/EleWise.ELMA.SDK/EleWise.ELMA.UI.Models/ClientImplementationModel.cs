using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[DataContract]
public sealed class ClientImplementationModel : ICloneable
{
	private static ClientImplementationModel ghR9w3BBAB9lvWmOE1cS;

	[DataMember]
	public Guid HeaderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderUid_003Ek__BackingField;
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
					_003CHeaderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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

	public object Clone()
	{
		ClientImplementationModel clientImplementationModel = new ClientImplementationModel();
		zRtb4nBB08a3xh0k6JCR(clientImplementationModel, HeaderUid);
		uSVJL9BBmIw9YVp816NC(clientImplementationModel, ItemUid);
		wx2aRyBByqiNPY1vwCfF(clientImplementationModel, ModuleUid);
		gN2bMwBBMYjyN7qu7QQl(clientImplementationModel, ModuleItemUid);
		return clientImplementationModel;
	}

	public ClientImplementationModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pffppPBB76aClWjJ4RHj()
	{
		return ghR9w3BBAB9lvWmOE1cS == null;
	}

	internal static ClientImplementationModel sLcpZcBBxqWrlhHyIQE9()
	{
		return ghR9w3BBAB9lvWmOE1cS;
	}

	internal static void zRtb4nBB08a3xh0k6JCR(object P_0, Guid value)
	{
		((ClientImplementationModel)P_0).HeaderUid = value;
	}

	internal static void uSVJL9BBmIw9YVp816NC(object P_0, Guid value)
	{
		((ClientImplementationModel)P_0).ItemUid = value;
	}

	internal static void wx2aRyBByqiNPY1vwCfF(object P_0, Guid value)
	{
		((ClientImplementationModel)P_0).ModuleUid = value;
	}

	internal static void gN2bMwBBMYjyN7qu7QQl(object P_0, Guid value)
	{
		((ClientImplementationModel)P_0).ModuleItemUid = value;
	}
}
