using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[DataContract]
public sealed class ClientDataClassModel : ICloneable
{
	internal static ClientDataClassModel UucY2lBWG92G7Eg98wg2;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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
				case 0:
					return;
				case 1:
					_003CModuleItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public object Clone()
	{
		ClientDataClassModel clientDataClassModel = new ClientDataClassModel();
		BDP8HiBWQHLTH1H42eNv(clientDataClassModel, HeaderUid);
		pCJBnJBWCNw6AMdYrPeK(clientDataClassModel, ItemUid);
		dwP972BWvIROS0UhNdp6(clientDataClassModel, ModuleItemUid);
		return clientDataClassModel;
	}

	public ClientDataClassModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		d02XJaBW8HStBwrn9Ku8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iMm41sBWE34fGgKMnDfv()
	{
		return UucY2lBWG92G7Eg98wg2 == null;
	}

	internal static ClientDataClassModel hmKZNmBWfeP2ipcOC1kf()
	{
		return UucY2lBWG92G7Eg98wg2;
	}

	internal static void BDP8HiBWQHLTH1H42eNv(object P_0, Guid value)
	{
		((ClientDataClassModel)P_0).HeaderUid = value;
	}

	internal static void pCJBnJBWCNw6AMdYrPeK(object P_0, Guid value)
	{
		((ClientDataClassModel)P_0).ItemUid = value;
	}

	internal static void dwP972BWvIROS0UhNdp6(object P_0, Guid value)
	{
		((ClientDataClassModel)P_0).ModuleItemUid = value;
	}

	internal static void d02XJaBW8HStBwrn9Ku8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
