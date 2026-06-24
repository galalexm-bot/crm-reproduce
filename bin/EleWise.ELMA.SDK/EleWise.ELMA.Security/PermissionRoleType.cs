using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public class PermissionRoleType
{
	private readonly string nameForLocalization;

	internal static PermissionRoleType agmUvlBjnBVsB4sbmtl9;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid UID => Id;

	public Func<dynamic, IEntity> AssignedEntityEvalutor { get; private set; }

	public string Name => SR.T(nameForLocalization);

	public Type LinkedEntityType
	{
		[CompilerGenerated]
		get
		{
			return _003CLinkedEntityType_003Ek__BackingField;
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
				case 1:
					_003CLinkedEntityType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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

	public string Image
	{
		[CompilerGenerated]
		get
		{
			return _003CImage_003Ek__BackingField;
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
				case 1:
					_003CImage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
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

	public string EntityUrl
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityUrl_003Ek__BackingField;
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
				case 1:
					_003CEntityUrl_003Ek__BackingField = value;
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

	public PermissionRoleType(Guid id, string name, string image)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k0cgcEBje3M0oMZZ0Ktp();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				nameForLocalization = name;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num = 3;
				}
				break;
			case 2:
				Id = id;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 3:
				Image = image;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PermissionRoleType(Guid id, string name)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k0cgcEBje3M0oMZZ0Ktp();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Id = id;
				num = 2;
				break;
			case 2:
				nameForLocalization = name;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PermissionRoleType(Guid id, string name, Type linkedEntityType, string image)
	{
		//Discarded unreachable code: IL_001e
		k0cgcEBje3M0oMZZ0Ktp();
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				LinkedEntityType = linkedEntityType;
				num2 = 3;
				break;
			case 3:
				Image = image;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				nameForLocalization = name;
				num2 = 4;
				break;
			case 1:
				return;
			case 2:
				Id = id;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionRoleType(Guid id, string name, Type linkedEntityType, string image, string entityUrl)
	{
		//Discarded unreachable code: IL_002a
		k0cgcEBje3M0oMZZ0Ktp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Image = image;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 3;
				}
				break;
			default:
				Id = id;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 0;
				}
				break;
			case 4:
			{
				LinkedEntityType = linkedEntityType;
				int num2 = 2;
				num = num2;
				break;
			}
			case 1:
				nameForLocalization = name;
				num = 4;
				break;
			case 3:
				EntityUrl = entityUrl;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				return;
			}
		}
	}

	public PermissionRoleType(Guid id, string name, Type linkedEntityType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k0cgcEBje3M0oMZZ0Ktp();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				LinkedEntityType = linkedEntityType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				nameForLocalization = name;
				num = 3;
				break;
			case 1:
				Id = id;
				num = 2;
				break;
			}
		}
	}

	public PermissionRoleType(Guid id, string name, Type linkedEntityType, Func<dynamic, IEntity> assignedEntityEvalutor)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Id = id;
		nameForLocalization = name;
		LinkedEntityType = linkedEntityType;
		AssignedEntityEvalutor = assignedEntityEvalutor;
	}

	public PermissionRoleType(Guid id, string name, Type linkedEntityType, Func<dynamic, IEntity> assignedEntityEvalutor, string entityUrl)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Id = id;
		nameForLocalization = name;
		LinkedEntityType = linkedEntityType;
		AssignedEntityEvalutor = assignedEntityEvalutor;
		EntityUrl = entityUrl;
	}

	public PermissionRoleType(Guid id, string name, Type linkedEntityType, Func<dynamic, IEntity> assignedEntityEvalutor, string image, string entityUrl)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Id = id;
		nameForLocalization = name;
		LinkedEntityType = linkedEntityType;
		AssignedEntityEvalutor = assignedEntityEvalutor;
		Image = image;
		EntityUrl = entityUrl;
	}

	public override string ToString()
	{
		return (string)DINOj4BjPEQ57t6xrKFm(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1F9B86), Id, Name);
	}

	internal static void k0cgcEBje3M0oMZZ0Ktp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kZBTZYBjOl13QRcTW056()
	{
		return agmUvlBjnBVsB4sbmtl9 == null;
	}

	internal static PermissionRoleType KgHSasBj2FPilbxAlqZ3()
	{
		return agmUvlBjnBVsB4sbmtl9;
	}

	internal static object DINOj4BjPEQ57t6xrKFm(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
