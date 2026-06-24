using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Actions.Impl;

internal class EntityManagerActionsCollectModule : Module
{
	private EntityManagerActionsStorage _actionsStorage;

	private static EntityManagerActionsCollectModule o2gC6KfwzrrlbPrJVPOj;

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0055, IL_005f, IL_011d, IL_0155
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		IEnumerator<Service> enumerator = default(IEnumerator<Service>);
		TypedService val = default(TypedService);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				try
				{
					while (true)
					{
						IL_00d1:
						int num3;
						if (!Aq3TDXf4b36crmFBuKi2(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num3 = 0;
							}
							goto IL_0063;
						}
						goto IL_00a9;
						IL_00a9:
						val = (TypedService)enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num3 = 0;
						}
						goto IL_0063;
						IL_0063:
						while (true)
						{
							switch (num3)
							{
							default:
								BiOcG8f4oh5W7Aeos47D(_actionsStorage, XrBOSZf4WIyJpPIvSnrB(val));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
								break;
							case 2:
								goto IL_00d1;
							case 1:
								return;
							}
							break;
						}
						goto IL_00a9;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								MQCjuEf4h9pIMvxNLsu6(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 1:
				if (registration == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				return;
			case 2:
				break;
			}
			enumerator = registration.get_Services().Where(delegate(Service s)
			{
				//Discarded unreachable code: IL_004a, IL_0059
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Expected O, but got Unknown
				int num5 = 1;
				int num6 = num5;
				while (true)
				{
					switch (num6)
					{
					case 2:
						return typeof(IEntityManager).IsAssignableFrom(_003C_003Ec.v2Jvf3ZfxcjidUApNqB6((object)(TypedService)s));
					default:
						return false;
					case 1:
						if (!(s is TypedService))
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num6 = 0;
							}
							break;
						}
						goto case 2;
					}
				}
			}).GetEnumerator();
			num2 = 3;
		}
	}

	protected override void Load(ContainerBuilder builder)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				RegistrationExtensions.RegisterInstance<EntityManagerActionsStorage>(builder, _actionsStorage).As<IEntityManagerTypesStorage>().As<EntityManagerActionsStorage>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				NfWgvif4Gi8pXGwXdcJD(this, builder);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_actionsStorage = new EntityManagerActionsStorage();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public EntityManagerActionsCollectModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nUHS06f4E8eI0pwipvDK();
		((Module)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type XrBOSZf4WIyJpPIvSnrB(object P_0)
	{
		return ((TypedService)P_0).get_ServiceType();
	}

	internal static void BiOcG8f4oh5W7Aeos47D(object P_0, Type managerType)
	{
		((EntityManagerActionsStorage)P_0).AddManagerType(managerType);
	}

	internal static bool Aq3TDXf4b36crmFBuKi2(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void MQCjuEf4h9pIMvxNLsu6(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool XlGyEEf4F5GGFo147TeR()
	{
		return o2gC6KfwzrrlbPrJVPOj == null;
	}

	internal static EntityManagerActionsCollectModule PFEyZ6f4BE2sJsxDejxu()
	{
		return o2gC6KfwzrrlbPrJVPOj;
	}

	internal static void NfWgvif4Gi8pXGwXdcJD(object P_0, object P_1)
	{
		((Module)P_0).Load((ContainerBuilder)P_1);
	}

	internal static void nUHS06f4E8eI0pwipvDK()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
