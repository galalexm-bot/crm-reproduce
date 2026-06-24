using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[DataContract]
public sealed class ClientExtensionPointModel : ICloneable
{
	internal static ClientExtensionPointModel P52H5WBBt1oM4T1IDHN2;

	[DataMember]
	public string PointId
	{
		[CompilerGenerated]
		get
		{
			return _003CPointId_003Ek__BackingField;
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
					_003CPointId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
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

	[DataMember]
	public List<ClientImplementationModel> Implementations { get; set; }

	public ClientExtensionPointModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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
			Implementations = new List<ClientImplementationModel>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
			{
				num = 1;
			}
		}
	}

	public object Clone()
	{
		ClientExtensionPointModel clientExtensionPointModel = new ClientExtensionPointModel();
		LADHRuBB6Z1ZGYf7Lh2p(clientExtensionPointModel, PointId);
		DiNY4oBBHwKm2fIRvNSp(clientExtensionPointModel, TypeUid);
		clientExtensionPointModel.Implementations.AddRange(Implementations.Select((ClientImplementationModel i) => (ClientImplementationModel)_003C_003Ec.eicn2qQW63nZeDlcigtd(i)));
		return clientExtensionPointModel;
	}

	internal static bool p6HPoyBBwx5elGneXrOM()
	{
		return P52H5WBBt1oM4T1IDHN2 == null;
	}

	internal static ClientExtensionPointModel scXsESBB4pSqu8T6jjjH()
	{
		return P52H5WBBt1oM4T1IDHN2;
	}

	internal static void LADHRuBB6Z1ZGYf7Lh2p(object P_0, object P_1)
	{
		((ClientExtensionPointModel)P_0).PointId = (string)P_1;
	}

	internal static void DiNY4oBBHwKm2fIRvNSp(object P_0, Guid value)
	{
		((ClientExtensionPointModel)P_0).TypeUid = value;
	}
}
