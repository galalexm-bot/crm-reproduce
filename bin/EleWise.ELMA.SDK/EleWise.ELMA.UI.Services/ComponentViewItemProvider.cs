using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

[Component]
internal sealed class ComponentViewItemProvider : IObjectViewItemProvider
{
	private readonly IEnumerable<IObjectFormProvider> objectFormProviders;

	public static readonly Guid UID;

	internal static ComponentViewItemProvider B2SNxYUwEeSgbVxb8AQ;

	public Guid ProviderUid => UID;

	public ComponentViewItemProvider(IEnumerable<IObjectFormProvider> objectFormProviders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.objectFormProviders = objectFormProviders;
	}

	public ViewItem GetViewItem(string viewItemId)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		string[] array = default(string[]);
		IObjectFormProvider objectFormProvider = default(IObjectFormProvider);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return null;
			case 5:
				_003C_003Ec__DisplayClass5_.itemUid = new Guid(array[1]);
				num2 = 7;
				break;
			case 3:
				return null;
			case 8:
				_003C_003Ec__DisplayClass5_.typeUid = new Guid(array[0]);
				num2 = 5;
				break;
			case 2:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (array.Length >= 2)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 3;
			case 4:
				if (objectFormProvider != null)
				{
					return (ViewItem)mPjyl8UHG4q8gdVZmx2(objectFormProvider, null, _003C_003Ec__DisplayClass5_.itemUid);
				}
				num2 = 6;
				break;
			case 7:
				objectFormProvider = objectFormProviders.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetViewItem_003Eb__0);
				num2 = 4;
				break;
			case 1:
				array = viewItemId.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C94C168) }, StringSplitOptions.None);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static ComponentViewItemProvider()
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
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)GjhCmaUA7RleyGcmly0(0x7EC153F ^ 0x7ECC151));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object mPjyl8UHG4q8gdVZmx2(object P_0, object P_1, Guid formUid)
	{
		return ((IObjectFormProvider)P_0).GetFormByUid(P_1, formUid);
	}

	internal static bool X8tlexU4FJar5fdHOnh()
	{
		return B2SNxYUwEeSgbVxb8AQ == null;
	}

	internal static ComponentViewItemProvider jDW3JEU6ATIajSoYj3i()
	{
		return B2SNxYUwEeSgbVxb8AQ;
	}

	internal static object GjhCmaUA7RleyGcmly0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
