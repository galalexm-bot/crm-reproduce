using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "DeletedIdsPackage")]
public class DeletedIdsPackage : PackageBase
{
	private static DeletedIdsPackage vNPdWIf1k1UWEBOUxakT;

	[DataMember]
	public long[] Deleted
	{
		[CompilerGenerated]
		get
		{
			return _003CDeleted_003Ek__BackingField;
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
					_003CDeleted_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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

	[Obsolete("Этот конструктор предназначен только для десериализации.", true)]
	public DeletedIdsPackage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DeletedIdsPackage(Guid serviceUid, Guid typeUid)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		TNW8lxf12RQpdyRixl96();
		base._002Ector(serviceUid, typeUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DeletedIdsPackage(Guid serviceUid, Guid typeUid, long deleted)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		TNW8lxf12RQpdyRixl96();
		this._002Ector(serviceUid, typeUid);
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
			Deleted = new long[1] { deleted };
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num = 1;
			}
		}
	}

	public DeletedIdsPackage(Guid serviceUid, Guid typeUid, IEnumerable<long> deleted)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(serviceUid, typeUid);
		Deleted = deleted.ToArray();
	}

	internal static bool VxJpGQf1nqcXTqYeBLRp()
	{
		return vNPdWIf1k1UWEBOUxakT == null;
	}

	internal static DeletedIdsPackage duQ6LMf1OH7JvitX9L79()
	{
		return vNPdWIf1k1UWEBOUxakT;
	}

	internal static void TNW8lxf12RQpdyRixl96()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
