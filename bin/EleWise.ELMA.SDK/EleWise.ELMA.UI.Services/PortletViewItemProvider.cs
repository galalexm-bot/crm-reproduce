using System;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

public class PortletViewItemProvider : UIViewItemProvider
{
	public static readonly Guid UID;

	internal static PortletViewItemProvider qwQog3ciVBom13MhafX;

	public override Guid ProviderUid => UID;

	public static string CreateViewItemId(FormDescriptor formDescriptor, FormPartMetadata partMetadata, int portletManagerScope, string portletManagerPath, Guid portletId, Guid instanceId, string path)
	{
		PortletViewItemParams portletViewItemParams = new PortletViewItemParams();
		vyIm5ScKXpnwYC3l314(portletViewItemParams, formDescriptor, partMetadata, portletManagerScope, portletManagerPath, portletId, instanceId, path);
		return portletViewItemParams.ToString();
	}

	public static void InitViewItemParams(PortletViewItemParams viewItemParams, FormDescriptor formDescriptor, FormPartMetadata partMetadata, int portletManagerScope, string portletManagerPath, Guid portletId, Guid instanceId, string path)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				viewItemParams.PortletManagerScope = portletManagerScope;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 6:
				IdI8G0cOTWKvw8WdWGk(viewItemParams, path);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				wfLBg5ckuNU29tGrlZG(viewItemParams, portletId);
				num2 = 5;
				break;
			case 1:
				Contract.ArgumentNotNull(viewItemParams, (string)dvscI1cXhyXfw7a4ZRI(0x53CACA3 ^ 0x53C7405));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			default:
				cm6TB3cTS3xAawUtA29(viewItemParams, formDescriptor, partMetadata);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				gRWHCecnMnl8QK18cBh(viewItemParams, instanceId);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				viewItemParams.PortletManagerPath = portletManagerPath;
				num2 = 7;
				break;
			}
		}
	}

	public new static UIViewItemParams ParseViewItemId(string viewItemId)
	{
		return new PortletViewItemParams(viewItemId);
	}

	protected override UIViewItemParams ParseViewItemParams(string viewItemId)
	{
		return (UIViewItemParams)TLeEsjc2h8orO0Uxtl6(viewItemId);
	}

	public PortletViewItemProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lfEQLpcerW61YGO2lvM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PortletViewItemProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				lfEQLpcerW61YGO2lvM();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)dvscI1cXhyXfw7a4ZRI(-398663332 ^ -398706614));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void vyIm5ScKXpnwYC3l314(object P_0, object P_1, object P_2, int portletManagerScope, object P_4, Guid portletId, Guid instanceId, object P_7)
	{
		InitViewItemParams((PortletViewItemParams)P_0, (FormDescriptor)P_1, (FormPartMetadata)P_2, portletManagerScope, (string)P_4, portletId, instanceId, (string)P_7);
	}

	internal static bool cFTPZocRbOAXreQCH22()
	{
		return qwQog3ciVBom13MhafX == null;
	}

	internal static PortletViewItemProvider nc6uoMcqBD27uAmqUSh()
	{
		return qwQog3ciVBom13MhafX;
	}

	internal static object dvscI1cXhyXfw7a4ZRI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void cm6TB3cTS3xAawUtA29(object P_0, object P_1, object P_2)
	{
		UIViewItemProvider.InitViewItemParams((UIViewItemParams)P_0, (FormDescriptor)P_1, (FormPartMetadata)P_2);
	}

	internal static void wfLBg5ckuNU29tGrlZG(object P_0, Guid value)
	{
		((PortletViewItemParams)P_0).PortletId = value;
	}

	internal static void gRWHCecnMnl8QK18cBh(object P_0, Guid value)
	{
		((PortletViewItemParams)P_0).InstanceId = value;
	}

	internal static void IdI8G0cOTWKvw8WdWGk(object P_0, object P_1)
	{
		((PortletViewItemParams)P_0).Path = (string)P_1;
	}

	internal static object TLeEsjc2h8orO0Uxtl6(object P_0)
	{
		return ParseViewItemId((string)P_0);
	}

	internal static void lfEQLpcerW61YGO2lvM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
