using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

[Service]
public class EntityService
{
	private static EntityService i6FWJjB75H5HMh8Nftmm;

	public RunWithSoftDeletableService RunWithSoftDeletableService
	{
		[CompilerGenerated]
		get
		{
			return _003CRunWithSoftDeletableService_003Ek__BackingField;
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
					_003CRunWithSoftDeletableService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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

	public void RunWithSoftDeletable(Action action)
	{
		//Discarded unreachable code: IL_00b2, IL_00c1, IL_0112, IL_0131, IL_0162, IL_0171
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				flag = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				flag = YdOrm3B7LoK6fHx0hfZC(RunWithSoftDeletableService);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						if (flag)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
					{
						q1duxGB7UU03xh56wOUi(RunWithSoftDeletableService, true);
						int num4 = 3;
						num3 = num4;
						break;
					}
					default:
						PpWbafB7sZNnlFCAWgBn(action);
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num3 = 4;
						}
						break;
					case 4:
						return;
					}
				}
			}
			finally
			{
				int num5;
				if (flag)
				{
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num5 = 0;
					}
					goto IL_0116;
				}
				goto IL_013b;
				IL_013b:
				q1duxGB7UU03xh56wOUi(RunWithSoftDeletableService, false);
				num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num5 = 1;
				}
				goto IL_0116;
				IL_0116:
				switch (num5)
				{
				default:
					goto end_IL_00f1;
				case 0:
					goto end_IL_00f1;
				case 2:
					break;
				case 1:
					goto end_IL_00f1;
				}
				goto IL_013b;
				end_IL_00f1:;
			}
		}
	}

	public EntityService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		w3UTE7B7cQpm5Zvw3pWV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool k1QkMBB7j4rgAM7eRf9Y()
	{
		return i6FWJjB75H5HMh8Nftmm == null;
	}

	internal static EntityService BaaEroB7YtCHH0hjyZvM()
	{
		return i6FWJjB75H5HMh8Nftmm;
	}

	internal static bool YdOrm3B7LoK6fHx0hfZC(object P_0)
	{
		return ((RunWithSoftDeletableService)P_0).Turned;
	}

	internal static void q1duxGB7UU03xh56wOUi(object P_0, bool value)
	{
		((RunWithSoftDeletableService)P_0).Turned = value;
	}

	internal static void PpWbafB7sZNnlFCAWgBn(object P_0)
	{
		P_0();
	}

	internal static void w3UTE7B7cQpm5Zvw3pWV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
