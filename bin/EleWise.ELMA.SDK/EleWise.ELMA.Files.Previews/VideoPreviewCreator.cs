using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component]
public class VideoPreviewCreator : BaseFilePreviewCreatorEx
{
	private readonly Guid uid;

	internal static VideoPreviewCreator lDZMjjGeFyGt3Yn5429M;

	public override Guid Uid => uid;

	public override string DisplayName => SR.T((string)OY10GiGeoIVRC3LpCN5B(-1426094279 ^ -1426300309));

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583588494),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234145150)
	};

	public override string ExternalCreatorFileName => null;

	public override string PreviewDir => null;

	public override bool RequiredExternalCreator => false;

	public override bool EnableGenerateHtml()
	{
		return false;
	}

	public override string GetPreviewText(BinaryFile file)
	{
		return null;
	}

	public override string GetMainFileName(BinaryFile file)
	{
		return (string)LhI8MuGebiUEOERqg2n4(file);
	}

	public override string GetRelativeMainFileName(BinaryFile file)
	{
		return null;
	}

	public override string GetTextFileName(string filePreviewDir, BinaryFile file)
	{
		return null;
	}

	public override string GetTextFileName(BinaryFile file)
	{
		return null;
	}

	public VideoPreviewCreator()
	{
		//Discarded unreachable code: IL_0050, IL_0055
		SingletonReader.PushGlobal();
		uid = new Guid((string)OY10GiGeoIVRC3LpCN5B(0x4D1C1EE4 ^ 0x4D1FFB44));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object OY10GiGeoIVRC3LpCN5B(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool qOyKyJGeBIMctcTC6qdx()
	{
		return lDZMjjGeFyGt3Yn5429M == null;
	}

	internal static VideoPreviewCreator infkcKGeWvdCMCGvhlyK()
	{
		return lDZMjjGeFyGt3Yn5429M;
	}

	internal static object LhI8MuGebiUEOERqg2n4(object P_0)
	{
		return ((BinaryFile)P_0).ContentFilePath;
	}
}
