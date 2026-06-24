using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

[Component]
public class PortletDynamicFormProvider : UIDynamicFormProvider
{
	public static readonly Guid UID;

	internal static PortletDynamicFormProvider ASPg98codWgSHqqAwHC;

	public override Guid Uid => UID;

	public static string CreateData(FormDescriptor formDescriptor, FormPartMetadata partMetadata, int portletManagerScope, string portletManagerPath, Guid portletId, Guid instanceId, string path)
	{
		return (string)Dt3XndcGkIJYIrrJ7h7(formDescriptor, partMetadata, portletManagerScope, portletManagerPath, portletId, instanceId, path);
	}

	protected override UIViewItemParams ParseViewItemParams(string dynamicFormsProviderData)
	{
		return new PortletViewItemParams(dynamicFormsProviderData);
	}

	protected override Type GetItemViewModelType(Type itemType, FormDescriptor descriptor)
	{
		int num = 3;
		PortletDescriptor portletDescriptor = default(PortletDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return rMBWQncQNePbRff8RnY(typeof(PortletContentItemViewModel<, >).TypeHandle).MakeGenericType(itemType, jIq5LjcCxMr5yUn3SvZ(portletDescriptor));
				default:
					portletDescriptor = (PortletDescriptor)descriptor;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					break;
				case 2:
					X8Yx9ncfZ0J7Tlbecbi(descriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289719136));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			X8Yx9ncfZ0J7Tlbecbi(itemType, Y062OucEnvtCP1vf1T7(0x42643203 ^ 0x4264E487));
			num = 2;
		}
	}

	protected override Type GetViewModelType(Type entityType, FormDescriptor descriptor)
	{
		int num = 1;
		int num2 = num;
		PortletDescriptor portletDescriptor = default(PortletDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(entityType, (string)Y062OucEnvtCP1vf1T7(-576149596 ^ -576162768));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				portletDescriptor = (PortletDescriptor)descriptor;
				num2 = 3;
				break;
			default:
				X8Yx9ncfZ0J7Tlbecbi(descriptor, Y062OucEnvtCP1vf1T7(0x3A5D5EF ^ 0x3A5A725));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return rMBWQncQNePbRff8RnY(typeof(PortletContentViewModel<, >).TypeHandle).MakeGenericType(entityType, jIq5LjcCxMr5yUn3SvZ(portletDescriptor));
			}
		}
	}

	protected override object CreateItemViewModelType(Type itemViewModelType, FormDescriptor descriptor, IEntity entity, RootViewItem view, UIViewItemParams viewItemParams)
	{
		int num = 2;
		int num2 = num;
		PortletViewItemParams portletViewItemParams = default(PortletViewItemParams);
		IPortletPersonalization portletPersonalization = default(IPortletPersonalization);
		while (true)
		{
			switch (num2)
			{
			default:
				portletViewItemParams = (PortletViewItemParams)viewItemParams;
				num2 = 4;
				break;
			case 3:
				return WMCJmBcuEFIOHoOpE1F(itemViewModelType, new object[3] { entity, portletPersonalization, view });
			case 2:
				Contract.ArgumentNotNull(itemViewModelType, (string)Y062OucEnvtCP1vf1T7(-29254301 ^ -29275141));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				X8Yx9ncfZ0J7Tlbecbi(viewItemParams, Y062OucEnvtCP1vf1T7(-542721635 ^ -542744261));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				portletPersonalization = (IPortletPersonalization)J4NAMAcZWq0RZ8gPvsl(Locator.GetServiceNotNull<IPortletPersonalizationLoader>(), PA9DvRcvaVIatN2TJqZ(portletViewItemParams), portletViewItemParams.PortletManagerPath, portletViewItemParams.PortletId, portletViewItemParams.InstanceId, sQqSlIc8YAfh3J0JW7G(portletViewItemParams));
				num2 = 3;
				break;
			}
		}
	}

	protected override object CreateViewModelType(Type viewModelType, FormDescriptor descriptor, IEntity entity, RootViewItem view, UIViewItemParams viewItemParams)
	{
		int num = 2;
		PortletDescriptor portletDescriptor = default(PortletDescriptor);
		IPortletPersonalization portletPersonalization = default(IPortletPersonalization);
		PortletViewItemParams portletViewItemParams = default(PortletViewItemParams);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					X8Yx9ncfZ0J7Tlbecbi(descriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123628364));
					num2 = 5;
					continue;
				case 3:
					return WMCJmBcuEFIOHoOpE1F(viewModelType, new object[4] { portletDescriptor.Content, entity, portletPersonalization, view });
				default:
					portletPersonalization = (IPortletPersonalization)J4NAMAcZWq0RZ8gPvsl(Locator.GetServiceNotNull<IPortletPersonalizationLoader>(), PA9DvRcvaVIatN2TJqZ(portletViewItemParams), SuOV7dcI7qLmJbIHP2g(portletViewItemParams), portletViewItemParams.PortletId, portletViewItemParams.InstanceId, portletViewItemParams.Path);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					portletViewItemParams = (PortletViewItemParams)viewItemParams;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				case 2:
					X8Yx9ncfZ0J7Tlbecbi(viewModelType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867773710));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			portletDescriptor = (PortletDescriptor)descriptor;
			num = 4;
		}
	}

	protected override object GetResult(object viewModel)
	{
		int num = 2;
		int num2 = num;
		IPortletContentViewModel portletContentViewModel = default(IPortletContentViewModel);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 2:
				portletContentViewModel = viewModel as IPortletContentViewModel;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (portletContentViewModel != null)
				{
					return RsuKiScVRmVnekmOkmw(portletContentViewModel);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PortletDynamicFormProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a5SueycSyvEHQwq7CVO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PortletDynamicFormProvider()
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
				UID = new Guid((string)Y062OucEnvtCP1vf1T7(0x31326106 ^ 0x3132B9C0));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object Dt3XndcGkIJYIrrJ7h7(object P_0, object P_1, int portletManagerScope, object P_3, Guid portletId, Guid instanceId, object P_6)
	{
		return PortletViewItemProvider.CreateViewItemId((FormDescriptor)P_0, (FormPartMetadata)P_1, portletManagerScope, (string)P_3, portletId, instanceId, (string)P_6);
	}

	internal static bool B979m0cbXafOUmeqA6P()
	{
		return ASPg98codWgSHqqAwHC == null;
	}

	internal static PortletDynamicFormProvider fO0WfmchkuK8yQJKQXC()
	{
		return ASPg98codWgSHqqAwHC;
	}

	internal static object Y062OucEnvtCP1vf1T7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void X8Yx9ncfZ0J7Tlbecbi(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type rMBWQncQNePbRff8RnY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type jIq5LjcCxMr5yUn3SvZ(object P_0)
	{
		return ((PortletDescriptor)P_0).PersonalizationType;
	}

	internal static int PA9DvRcvaVIatN2TJqZ(object P_0)
	{
		return ((PortletViewItemParams)P_0).PortletManagerScope;
	}

	internal static object sQqSlIc8YAfh3J0JW7G(object P_0)
	{
		return ((PortletViewItemParams)P_0).Path;
	}

	internal static object J4NAMAcZWq0RZ8gPvsl(object P_0, int portletManagerScope, object P_2, Guid portletId, Guid instanceId, object P_5)
	{
		return ((IPortletPersonalizationLoader)P_0).Load(portletManagerScope, (string)P_2, portletId, instanceId, (string)P_5);
	}

	internal static object WMCJmBcuEFIOHoOpE1F(Type P_0, object P_1)
	{
		return Activator.CreateInstance(P_0, (object[])P_1);
	}

	internal static object SuOV7dcI7qLmJbIHP2g(object P_0)
	{
		return ((PortletViewItemParams)P_0).PortletManagerPath;
	}

	internal static object RsuKiScVRmVnekmOkmw(object P_0)
	{
		return ((IFormViewModel)P_0).Result;
	}

	internal static void a5SueycSyvEHQwq7CVO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
