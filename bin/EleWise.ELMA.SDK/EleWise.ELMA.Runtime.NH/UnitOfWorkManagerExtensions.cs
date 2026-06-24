using System;

namespace EleWise.ELMA.Runtime.NH;

public static class UnitOfWorkManagerExtensions
{
	internal static UnitOfWorkManagerExtensions sDoQY9W6FKnPL3c4N5Tg;

	public static void Execute(this IUnitOfWorkManager manager, Action action)
	{
		//Discarded unreachable code: IL_0049, IL_00a6, IL_00de, IL_00ed
		int num = 2;
		int num2 = num;
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					QnMUEBW6otjcGgVKxnWg(action);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							WJs1OqW6bRC1xJTRGM8q(unitOfWork);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num3 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				finally
				{
					if (unitOfWork != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								Xo50qNW6hd3xxgto7VWj(unitOfWork);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 2:
				unitOfWork = manager.Create(string.Empty, transactional: true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static void Execute(this IUnitOfWorkManager manager, Action<IUnitOfWork> action)
	{
		using IUnitOfWork unitOfWork = manager.Create(string.Empty, transactional: true);
		action(unitOfWork);
		unitOfWork.Commit();
	}

	internal static void QnMUEBW6otjcGgVKxnWg(object P_0)
	{
		P_0();
	}

	internal static void WJs1OqW6bRC1xJTRGM8q(object P_0)
	{
		((IUnitOfWork)P_0).Commit();
	}

	internal static void Xo50qNW6hd3xxgto7VWj(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool KcEhClW6BflFIaudj5In()
	{
		return sDoQY9W6FKnPL3c4N5Tg == null;
	}

	internal static UnitOfWorkManagerExtensions NENbP3W6WO3uAxEpZcns()
	{
		return sDoQY9W6FKnPL3c4N5Tg;
	}
}
