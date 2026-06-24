using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class InstancePermissionAttribute : Attribute
{
	private readonly bool enabled;

	private readonly string permissionPropertyName;

	private readonly string permissionClassName;

	internal static InstancePermissionAttribute uYVZtCoflyH0Iyf3wlBj;

	public bool Enabled => enabled;

	public string PermissionPropertyName => permissionPropertyName;

	public string PermissionClassName => permissionClassName;

	public InstancePermissionAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TAE6KQof5INvUU9lSwHh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public InstancePermissionAttribute(bool enabled)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TAE6KQof5INvUU9lSwHh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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
			this.enabled = enabled;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
			{
				num = 1;
			}
		}
	}

	public InstancePermissionAttribute(bool enabled, string permissionClassName, string permissionPropertyName)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		TAE6KQof5INvUU9lSwHh();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.enabled = enabled;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				this.permissionPropertyName = permissionPropertyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.permissionClassName = permissionClassName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void TAE6KQof5INvUU9lSwHh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool CeajhfofrU7SLwMAM9og()
	{
		return uYVZtCoflyH0Iyf3wlBj == null;
	}

	internal static InstancePermissionAttribute LS90vWofgqTNsWc4nYSr()
	{
		return uYVZtCoflyH0Iyf3wlBj;
	}
}
