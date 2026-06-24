using System.Runtime.CompilerServices;
using System.Web.Routing;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Results;

public class RedirectToPageResult : FormResult
{
	private static RedirectToPageResult ryLxRwyzcQLrhHCwtC6;

	public string PageId
	{
		[CompilerGenerated]
		get
		{
			return _003CPageId_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CPageId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RouteValueDictionary Values
	{
		[CompilerGenerated]
		get
		{
			return _003CValues_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CValues_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RedirectToPageResult(string pageId)
	{
		//Discarded unreachable code: IL_001e
		JQxPcIMWDNtWB1J4Fot();
		base._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				EDGF7mMolDX3qhBQueU(pageId, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420782722));
				num2 = 2;
				break;
			case 2:
				PageId = pageId;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			default:
				Values = new RouteValueDictionary();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public RedirectToPageResult(string pageId, RouteValueDictionary values)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		JQxPcIMWDNtWB1J4Fot();
		this._002Ector(pageId);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Values = values;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void JQxPcIMWDNtWB1J4Fot()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void EDGF7mMolDX3qhBQueU(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool DpP1PGMFiOGP8G8TXW1()
	{
		return ryLxRwyzcQLrhHCwtC6 == null;
	}

	internal static RedirectToPageResult CFHnqfMBLM85IbUdLxj()
	{
		return ryLxRwyzcQLrhHCwtC6;
	}
}
