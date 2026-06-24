using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.UI.Listeners;

[Component]
internal sealed class ComponentMetadataItemListener : EntityEventsListener
{
	private readonly IModuleReferenceManager moduleReferenceManager;

	internal static ComponentMetadataItemListener IPUwsUdWRl5odt1dMCS;

	public ComponentMetadataItemListener(IModuleReferenceManager moduleReferenceManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IAkBqsdhhfwKiIVAVeb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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
			this.moduleReferenceManager = moduleReferenceManager;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
			{
				num = 1;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Update((IPostDatabaseOperationEventArgs)(object)@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				base.OnPostInsert(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
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
				Update((IPostDatabaseOperationEventArgs)(object)@event);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				base.OnPostUpdate(@event);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Update(IPostDatabaseOperationEventArgs @event)
	{
		//Discarded unreachable code: IL_00db, IL_00e5, IL_01ac, IL_01bf, IL_01fb
		int num = 3;
		int num2 = num;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		List<DataClassMetadata>.Enumerator enumerator = default(List<DataClassMetadata>.Enumerator);
		DataClassMetadata current = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
			{
				IModuleReferenceManager obj2 = moduleReferenceManager;
				ModuleReference moduleReference2 = new ModuleReference();
				boswe2dQ6wEu2Np487T(moduleReference2, iiwrsBdfuc6gUNlhfmH(componentMetadata));
				moduleReference2.ModuleUid = xn48XedCv9KIVDtVXeS(componentMetadata);
				pov7oZdvcB5CP1K90eT(obj2, moduleReference2);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 6;
				}
				break;
			}
			case 2:
				return;
			case 4:
				return;
			case 6:
				enumerator = componentMetadata.DataClasses.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num3 = 0;
							}
							goto IL_00e9;
						}
						goto IL_016d;
						IL_016d:
						current = enumerator.Current;
						num3 = 2;
						goto IL_00e9;
						IL_00e9:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 2:
							{
								IModuleReferenceManager obj = moduleReferenceManager;
								ModuleReference moduleReference = new ModuleReference();
								boswe2dQ6wEu2Np487T(moduleReference, iiwrsBdfuc6gUNlhfmH(current));
								moduleReference.ModuleUid = xn48XedCv9KIVDtVXeS(componentMetadata);
								pov7oZdvcB5CP1K90eT(obj, moduleReference);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							case 1:
								break;
							case 3:
								goto IL_016d;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 3:
				if (MAjRgvdGICr4eFDSdFJ(@event) is ComponentMetadataItem componentMetadataItem)
				{
					if ((componentMetadata = S0AubBdE71tJS3KVnOq(componentMetadataItem) as ComponentMetadata) == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	internal static void IAkBqsdhhfwKiIVAVeb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Nd3Jkudo9Sof8FSGxSS()
	{
		return IPUwsUdWRl5odt1dMCS == null;
	}

	internal static ComponentMetadataItemListener akbECrdbQwn3Ui9LhcI()
	{
		return IPUwsUdWRl5odt1dMCS;
	}

	internal static object MAjRgvdGICr4eFDSdFJ(object P_0)
	{
		return ((IPostDatabaseOperationEventArgs)P_0).get_Entity();
	}

	internal static object S0AubBdE71tJS3KVnOq(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static Guid iiwrsBdfuc6gUNlhfmH(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void boswe2dQ6wEu2Np487T(object P_0, Guid value)
	{
		((ModuleReference)P_0).MetadataUid = value;
	}

	internal static Guid xn48XedCv9KIVDtVXeS(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static void pov7oZdvcB5CP1K90eT(object P_0, object P_1)
	{
		((IModuleReferenceManager)P_0).Save((ModuleReference)P_1);
	}
}
