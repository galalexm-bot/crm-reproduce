using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

internal sealed class PageMetadataUpdateHandler : FormMetadataUpdateHandler
{
	internal static PageMetadataUpdateHandler XLWoYTgVIqXw0BbMgDD;

	protected override string OnLoadScriptName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E4DACB);

	protected override string ItemViewModelTypeName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16737691);

	public override bool Check(IMetadata metadata)
	{
		return metadata is PageMetadata;
	}

	protected override string GetMetadataName(IMetadataUpdateResult updateResult)
	{
		return ((PageMetadata)VjholQgRo6nPVTCh3NZ(updateResult)).Name;
	}

	protected override FormPartMetadata GetContent(IMetadataUpdateResult updateResult)
	{
		return ((PageMetadata)VjholQgRo6nPVTCh3NZ(updateResult)).Content;
	}

	protected override string GetViewModelTypeName(IMetadataUpdateResult updateResult)
	{
		return (string)usPDYfgKb0Bb6QQn1tJ(SUO9SBgqGrXKdO6NLTu(0x7EC153F ^ 0x7ECD117), GetMetadataName(updateResult), SUO9SBgqGrXKdO6NLTu(-1487388570 ^ -1487371218));
	}

	protected override string GetLoadViewModelTypeName(IMetadataUpdateResult updateResult)
	{
		return (string)usPDYfgKb0Bb6QQn1tJ(SUO9SBgqGrXKdO6NLTu(-2138160520 ^ -2138143198), eNhndpgXhQnVB5ASA2H(this, updateResult), SUO9SBgqGrXKdO6NLTu(0x17ADCCD8 ^ 0x17AD0890));
	}

	public PageMetadataUpdateHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		B7PkB1gT998aKd5bhZ8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QSxvmdgSsS4I3KkFUOv()
	{
		return XLWoYTgVIqXw0BbMgDD == null;
	}

	internal static PageMetadataUpdateHandler G2PnOBgifZnfK4Njk5u()
	{
		return XLWoYTgVIqXw0BbMgDD;
	}

	internal static object VjholQgRo6nPVTCh3NZ(object P_0)
	{
		return ((IMetadataUpdateResult)P_0).Metadata;
	}

	internal static object SUO9SBgqGrXKdO6NLTu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object usPDYfgKb0Bb6QQn1tJ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object eNhndpgXhQnVB5ASA2H(object P_0, object P_1)
	{
		return ((FormMetadataUpdateHandler)P_0).GetMetadataName((IMetadataUpdateResult)P_1);
	}

	internal static void B7PkB1gT998aKd5bhZ8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
