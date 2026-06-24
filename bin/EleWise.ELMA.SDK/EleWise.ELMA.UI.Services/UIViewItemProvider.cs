using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

[Component]
public abstract class UIViewItemProvider : IObjectViewItemProvider
{
	internal static UIViewItemProvider EhiHckzGBBBnLuGgD0a;

	public abstract Guid ProviderUid { get; }

	public static string CreateViewItemId(FormDescriptor formDescriptor, FormPartMetadata partMetadata)
	{
		UIViewItemParams uIViewItemParams = new UIViewItemParams();
		s9ZlB8zQ7x6mtHAIsgq(uIViewItemParams, formDescriptor, partMetadata);
		return uIViewItemParams.ToString();
	}

	public static void InitViewItemParams(UIViewItemParams viewItemParams, FormDescriptor formDescriptor, FormPartMetadata partMetadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				UFX7T2zvXVgQNZBscMC(partMetadata, K02KPVzC9ofxupayUy8(0x7EC153F ^ 0x7ECCFAF));
				num2 = 3;
				break;
			case 0:
				return;
			case 5:
				viewItemParams.PartMetadata = partMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UFX7T2zvXVgQNZBscMC(formDescriptor, K02KPVzC9ofxupayUy8(-957824448 ^ -957845910));
				num2 = 4;
				break;
			case 2:
				UFX7T2zvXVgQNZBscMC(viewItemParams, K02KPVzC9ofxupayUy8(-1108654032 ^ -1108635498));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				lmAyOYz8vR3q4EBbyCR(viewItemParams, formDescriptor);
				num2 = 5;
				break;
			}
		}
	}

	public static UIViewItemParams ParseViewItemId(string viewItemId)
	{
		return new UIViewItemParams(viewItemId);
	}

	public ViewItem GetViewItem(string viewItemId)
	{
		int num = 2;
		int num2 = num;
		UIViewItemParams uIViewItemParams = default(UIViewItemParams);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (uIViewItemParams.PartMetadata != null)
				{
					return (ViewItem)nP68lFzuKgnq6dNWEue(kXehHGzZHnW8BS6YdZb(uIViewItemParams));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				uIViewItemParams = ParseViewItemParams(viewItemId);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual UIViewItemParams ParseViewItemParams(string viewItemId)
	{
		return (UIViewItemParams)qg0OyZzIpfDJfZrSlZI(viewItemId);
	}

	protected UIViewItemProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PPGno4zVMwcuqZWqDmM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void s9ZlB8zQ7x6mtHAIsgq(object P_0, object P_1, object P_2)
	{
		InitViewItemParams((UIViewItemParams)P_0, (FormDescriptor)P_1, (FormPartMetadata)P_2);
	}

	internal static bool jU0jnpzEdWPRcIVlJbo()
	{
		return EhiHckzGBBBnLuGgD0a == null;
	}

	internal static UIViewItemProvider NXtwL8zfGqRlZ0Zw90G()
	{
		return EhiHckzGBBBnLuGgD0a;
	}

	internal static object K02KPVzC9ofxupayUy8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void UFX7T2zvXVgQNZBscMC(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void lmAyOYz8vR3q4EBbyCR(object P_0, object P_1)
	{
		((UIViewItemParams)P_0).FormDescriptor = (FormDescriptor)P_1;
	}

	internal static object kXehHGzZHnW8BS6YdZb(object P_0)
	{
		return ((UIViewItemParams)P_0).PartMetadata;
	}

	internal static object nP68lFzuKgnq6dNWEue(object P_0)
	{
		return ((FormPartMetadata)P_0).View;
	}

	internal static object qg0OyZzIpfDJfZrSlZI(object P_0)
	{
		return ParseViewItemId((string)P_0);
	}

	internal static void PPGno4zVMwcuqZWqDmM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
