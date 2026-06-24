using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts.Types;

public class PageScriptType : FormScriptType
{
	public const string UID_S = "{C81E2965-5096-4135-A4BD-06CD87F74B8D}";

	public static readonly Guid UID;

	private static PageScriptType C0j0tfLZYKmaUoZM4Uk;

	public override Guid Uid => UID;

	public override string Name => (string)dTYDd7LSbrxdeH3IsB9(McJMUlLVKJpODmPZBnX(-1867198571 ^ -1867251541));

	protected override void SetMethodParameters(ScriptMethodDeclaration declaration, FormMetadata formMetadata, FormContextMetadata contextMetadata, FormTablePartMetadata tablePartMetadata, IDictionary<string, object> generationParams)
	{
		Contract.ArgumentNotNull(declaration, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6B973));
		Contract.ArgumentNotNull(formMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398709030));
		Contract.ArgumentNotNull(contextMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D20DC));
		if (tablePartMetadata != null)
		{
			declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672096955), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889510524), formMetadata.Name, tablePartMetadata.Name)));
		}
		else
		{
			declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643803643), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4CAB21), formMetadata.Name, contextMetadata.Name)));
		}
	}

	public PageScriptType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vF2PQnLilRsjxRp4wqj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PageScriptType()
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
				vF2PQnLilRsjxRp4wqj();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F5B68E));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object McJMUlLVKJpODmPZBnX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dTYDd7LSbrxdeH3IsB9(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool mjmas9Lu5UQ7BTDfbQ5()
	{
		return C0j0tfLZYKmaUoZM4Uk == null;
	}

	internal static PageScriptType jgYKQ7LIhD7GI2DxMs2()
	{
		return C0j0tfLZYKmaUoZM4Uk;
	}

	internal static void vF2PQnLilRsjxRp4wqj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
