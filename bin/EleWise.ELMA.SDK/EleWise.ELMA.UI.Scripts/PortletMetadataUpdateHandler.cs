using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

internal sealed class PortletMetadataUpdateHandler : FormMetadataUpdateHandler
{
	private static PortletMetadataUpdateHandler a6fwwWgPXVlXEUj3X3K;

	protected override string OnLoadScriptName => (string)iorPAOg3BXxMEsGZeZM(0x61EC0CB8 ^ 0x61ECC810);

	protected override string ItemViewModelTypeName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE1BE05);

	public override bool Check(IMetadata metadata)
	{
		return metadata is PortletMetadata;
	}

	protected override string GetMetadataName(IMetadataUpdateResult updateResult)
	{
		return (string)H1OlvsgaXhtv5kWBRk1((PortletMetadata)fpRUwvgp5LXwnIo8LvL(updateResult));
	}

	protected override FormPartMetadata GetContent(IMetadataUpdateResult updateResult)
	{
		return (FormPartMetadata)PmxFIlgDe10VwdaoiGr((PortletMetadata)fpRUwvgp5LXwnIo8LvL(updateResult));
	}

	protected override string GetViewModelTypeName(IMetadataUpdateResult updateResult)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)RPL9E4gw1CumE71HWiq(new string[5]
				{
					(string)iorPAOg3BXxMEsGZeZM(-1426094279 ^ -1426111491),
					text,
					(string)iorPAOg3BXxMEsGZeZM(0x2ACE37D ^ 0x2AC2785),
					text,
					(string)iorPAOg3BXxMEsGZeZM(0x76DD48E ^ 0x76D1180)
				});
			case 1:
				text = (string)X8wIIYgtFABcrbDwQ0d(this, updateResult);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override string GetLoadViewModelTypeName(IMetadataUpdateResult updateResult)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)X8wIIYgtFABcrbDwQ0d(this, updateResult);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)RPL9E4gw1CumE71HWiq(new string[5]
				{
					(string)iorPAOg3BXxMEsGZeZM(0x4A1640F ^ 0x4A1A13B),
					text,
					(string)iorPAOg3BXxMEsGZeZM(-1217523399 ^ -1217473087),
					text,
					(string)iorPAOg3BXxMEsGZeZM(0x1A33FE36 ^ 0x1A333B38)
				});
			}
		}
	}

	protected override void AdditionalMetadataActions(FormMetadata formMetadata, ComponentMetadata componentMetadata)
	{
		//Discarded unreachable code: IL_0068, IL_0077, IL_0082, IL_0137, IL_014a, IL_0159
		int num = 1;
		int num2 = num;
		PortletComponentMetadata portletComponentMetadata = default(PortletComponentMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
			{
				PortletMetadata obj = (PortletMetadata)formMetadata;
				portletComponentMetadata = (PortletComponentMetadata)componentMetadata;
				enumerator = obj.PersonalizationContext.Properties.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num3 = 1;
						}
						goto IL_0086;
					}
					goto IL_00f8;
					IL_00f8:
					current = enumerator.Current;
					num3 = 3;
					goto IL_0086;
					IL_0086:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 3:
							portletComponentMetadata.PersonalizationContext.Properties.Add((PropertyMetadata)xHm4GNg4np5Xe18FtnJ(current));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							goto IL_00f8;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	public PortletMetadataUpdateHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		abBHYTg6E0KrFZVXWcV();
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

	internal static bool ffN3drg1legPHo1VIvn()
	{
		return a6fwwWgPXVlXEUj3X3K == null;
	}

	internal static PortletMetadataUpdateHandler aR7tFQgNctJhf5bhrnD()
	{
		return a6fwwWgPXVlXEUj3X3K;
	}

	internal static object iorPAOg3BXxMEsGZeZM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fpRUwvgp5LXwnIo8LvL(object P_0)
	{
		return ((IMetadataUpdateResult)P_0).Metadata;
	}

	internal static object H1OlvsgaXhtv5kWBRk1(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object PmxFIlgDe10VwdaoiGr(object P_0)
	{
		return ((PortletMetadata)P_0).Content;
	}

	internal static object X8wIIYgtFABcrbDwQ0d(object P_0, object P_1)
	{
		return ((FormMetadataUpdateHandler)P_0).GetMetadataName((IMetadataUpdateResult)P_1);
	}

	internal static object RPL9E4gw1CumE71HWiq(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object xHm4GNg4np5Xe18FtnJ(object P_0)
	{
		return FormMetadataUpdateHandler.CloneToViewModelPropertyMetadata((PropertyMetadata)P_0);
	}

	internal static void abBHYTg6E0KrFZVXWcV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
