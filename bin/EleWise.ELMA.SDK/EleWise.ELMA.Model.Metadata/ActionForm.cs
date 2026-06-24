using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class ActionForm
{
	[OptionalField]
	private bool deletedFromChild;

	private static ActionForm gThHygbtS3exOpr59yBK;

	public Guid GroupUid
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupUid_003Ek__BackingField;
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
					_003CGroupUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ActionTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CActionTypeUid_003Ek__BackingField;
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
					_003CActionTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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

	public Guid ActionUid
	{
		[CompilerGenerated]
		get
		{
			return _003CActionUid_003Ek__BackingField;
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
					_003CActionUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid Target
	{
		[CompilerGenerated]
		get
		{
			return _003CTarget_003Ek__BackingField;
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
					_003CTarget_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool DeletedFromChild
	{
		get
		{
			return deletedFromChild;
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
					deletedFromChild = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ActionForm()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vhO7RJbtqW8Q4kTlfeTK();
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

	internal static bool hsBVtUbtiLj5qHAXAijA()
	{
		return gThHygbtS3exOpr59yBK == null;
	}

	internal static ActionForm gfg7SrbtR7RwulHvJTS9()
	{
		return gThHygbtS3exOpr59yBK;
	}

	internal static void vhO7RJbtqW8Q4kTlfeTK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
