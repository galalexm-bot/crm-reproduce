using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts.Types;

public class PortletScriptType : FormScriptType
{
	public static class PortletParameters
	{
		public const string PersonalizationContextMetadata = "PersonalizationContextMetadata";
	}

	public const string UID_S = "{8F831BBC-B778-48F6-AA3D-251F135A4645}";

	public static readonly Guid UID;

	internal static PortletScriptType nfPB8qLRon3sB7s6Rqf;

	public override Guid Uid => UID;

	public override string Name => (string)tEaTs8LTIFCc5r2T8Nk(p0mUJhLX91ewmnoeAZL(0x53CB464B ^ 0x53CB96C3));

	protected override void SetMethodParameters(ScriptMethodDeclaration declaration, FormMetadata formMetadata, FormContextMetadata contextMetadata, FormTablePartMetadata tablePartMetadata, IDictionary<string, object> generationParams)
	{
		Contract.ArgumentNotNull(declaration, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477125962));
		Contract.ArgumentNotNull(formMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787438877));
		Contract.ArgumentNotNull(contextMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC18812));
		FormContextMetadata formContextMetadata = (FormContextMetadata)generationParams[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463ADF8A)];
		Contract.NotNull(formContextMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE30D7F));
		if (tablePartMetadata != null)
		{
			declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C943DCA), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A61E488), formMetadata.Name, tablePartMetadata.Name, formContextMetadata.Name)));
		}
		else
		{
			declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921247657), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70017146), formMetadata.Name, contextMetadata.Name, formContextMetadata.Name)));
		}
	}

	public PortletScriptType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cLSb29Lk0tvjmN5oKU3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PortletScriptType()
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
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12F833));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object p0mUJhLX91ewmnoeAZL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object tEaTs8LTIFCc5r2T8Nk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool PcdEs8LqEiC7GvgZ9G2()
	{
		return nfPB8qLRon3sB7s6Rqf == null;
	}

	internal static PortletScriptType TRbXm9LKvNdfn3xQ3eC()
	{
		return nfPB8qLRon3sB7s6Rqf;
	}

	internal static void cLSb29Lk0tvjmN5oKU3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
