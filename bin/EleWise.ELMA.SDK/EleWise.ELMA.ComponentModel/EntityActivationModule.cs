using System;
using System.Linq;
using Autofac;
using Autofac.Core;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

internal class EntityActivationModule : Module
{
	internal static EntityActivationModule MoiTa3fEx9ejHQUMK76g;

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				registration.add_Activating((EventHandler<ActivatingEventArgs<object>>)registration_Activating);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				registration.add_Activated((EventHandler<ActivatedEventArgs<object>>)registration_Activated);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void handleRegistration(IEntity instance, Action<IEntityActivationHandler, IEntity> doForEach)
	{
		if (doForEach == null)
		{
			return;
		}
		foreach (IEntityActivationHandler item in from h in ComponentManager.Current.GetExtensionPoints<IEntityActivationHandler>()
			where h != null
			select h)
		{
			doForEach(item, instance);
		}
	}

	private void registration_Activated(object sender, ActivatedEventArgs<object> e)
	{
		if (!(e.get_Instance() is IEntity) || !ComponentManager.Initialized)
		{
			return;
		}
		handleRegistration((IEntity)e.get_Instance(), delegate(IEntityActivationHandler h, IEntity en)
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
					_003C_003Ec.inU98P8rO8pUtAt0r5mw(h, en);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
	}

	private void registration_Activating(object sender, ActivatingEventArgs<object> e)
	{
		if (!(e.get_Instance() is IEntity) || !ComponentManager.Initialized)
		{
			return;
		}
		handleRegistration((IEntity)e.get_Instance(), delegate(IEntityActivationHandler h, IEntity en)
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
					_003C_003Ec.uc64Tq8r2r1JLitc30yh(h, en);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
	}

	public EntityActivationModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		((Module)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UVnq7qfE0U8A8p3JELT3()
	{
		return MoiTa3fEx9ejHQUMK76g == null;
	}

	internal static EntityActivationModule WkbIgEfEmrNyTrm6mQmS()
	{
		return MoiTa3fEx9ejHQUMK76g;
	}
}
