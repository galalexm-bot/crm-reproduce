using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class EntitySecurityException : SecurityException
{
	internal static EntitySecurityException lB36HIG5N4HBtRIiMhlG;

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
				case 0:
					return;
				case 1:
					_003CPermissionId_003Ek__BackingField = value;
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

	public long EntityId
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityId_003Ek__BackingField;
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
					_003CEntityId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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

	public List<Guid> Permissions { get; set; }

	public EntitySecurityException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ylIDixG5aD1d07u2Zv6y();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EntitySecurityException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		ylIDixG5aD1d07u2Zv6y();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected EntitySecurityException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void ylIDixG5aD1d07u2Zv6y()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sVsx7DG53LrbVAbam2b9()
	{
		return lB36HIG5N4HBtRIiMhlG == null;
	}

	internal static EntitySecurityException FiJwa8G5pt1yUn1fXMGE()
	{
		return lB36HIG5N4HBtRIiMhlG;
	}
}
