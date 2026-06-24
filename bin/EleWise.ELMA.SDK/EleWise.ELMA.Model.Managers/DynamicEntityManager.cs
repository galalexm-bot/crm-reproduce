using System;
using System.Collections.Generic;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Managers;

[Component]
public class DynamicEntityManager : EternalRefObject, IConfigurationService
{
	private static Dictionary<Guid, TypedDynamicEntityManager> managers;

	internal static DynamicEntityManager NXySJhhQlhFHgkCUK9rI;

	public static TypedDynamicEntityManager Typed(Guid typeUid)
	{
		return (TypedDynamicEntityManager)Md8h0ZhQ5DtgrsZDREwq(Locator.GetServiceNotNull<DynamicEntityManager>(), typeUid);
	}

	public virtual TypedDynamicEntityManager GetTypedManager(Guid typeUid)
	{
		//Discarded unreachable code: IL_0075, IL_0140, IL_0170, IL_017f, IL_018b, IL_019a
		int num = 2;
		Dictionary<Guid, TypedDynamicEntityManager> dictionary = default(Dictionary<Guid, TypedDynamicEntityManager>);
		TypedDynamicEntityManager result = default(TypedDynamicEntityManager);
		bool lockTaken = default(bool);
		TypedDynamicEntityManager value = default(TypedDynamicEntityManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					break;
				case 2:
					dictionary = managers;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return result;
				case 3:
					try
					{
						Monitor.Enter(dictionary, ref lockTaken);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 4:
								return result;
							default:
								value = new TypedDynamicEntityManager(typeUid);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num3 = 0;
								}
								break;
							case 2:
								result = value;
								num3 = 4;
								break;
							case 1:
								managers[typeUid] = value;
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num3 = 2;
								}
								break;
							case 3:
								if (!managers.TryGetValue(typeUid, out value))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
									{
										num3 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					}
					finally
					{
						int num4;
						if (!lockTaken)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num4 = 0;
							}
							goto IL_0144;
						}
						goto IL_015a;
						IL_015a:
						CfBCs7hQjgBvH6d2MTaB(dictionary);
						num4 = 2;
						goto IL_0144;
						IL_0144:
						switch (num4)
						{
						default:
							goto end_IL_011f;
						case 1:
							break;
						case 0:
							goto end_IL_011f;
						case 2:
							goto end_IL_011f;
						}
						goto IL_015a;
						end_IL_011f:;
					}
				}
				break;
			}
			lockTaken = false;
			num = 3;
		}
	}

	public DynamicEntityManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MLwWGjhQY5aVRKx5hOLj();
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

	static DynamicEntityManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				managers = new Dictionary<Guid, TypedDynamicEntityManager>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				MLwWGjhQY5aVRKx5hOLj();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object Md8h0ZhQ5DtgrsZDREwq(object P_0, Guid typeUid)
	{
		return ((DynamicEntityManager)P_0).GetTypedManager(typeUid);
	}

	internal static bool E4HNewhQrObSFvpcTnjV()
	{
		return NXySJhhQlhFHgkCUK9rI == null;
	}

	internal static DynamicEntityManager YqpOJmhQgtDeuHIFeRY9()
	{
		return NXySJhhQlhFHgkCUK9rI;
	}

	internal static void CfBCs7hQjgBvH6d2MTaB(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void MLwWGjhQY5aVRKx5hOLj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
