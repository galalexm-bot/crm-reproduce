using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component]
public class AudioPreviewCreator : BaseFilePreviewCreatorEx
{
	private readonly Guid uid;

	internal static AudioPreviewCreator bYMFJTG2L8t8yArY6kjp;

	public override Guid Uid => uid;

	public override string DisplayName => (string)r695hsG2zDLGBE5JtRcV(fcvbLUG2c0YANoZWqIJK(-420743386 ^ -420998230));

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138966230),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317537778),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475981805),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138200434)
	};

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
		return file.ContentFilePath;
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

	public AudioPreviewCreator()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		uid = new Guid((string)fcvbLUG2c0YANoZWqIJK(-1886646897 ^ -1886394227));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object fcvbLUG2c0YANoZWqIJK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object r695hsG2zDLGBE5JtRcV(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool jDTk2nG2UWlaGIdjXJdI()
	{
		return bYMFJTG2L8t8yArY6kjp == null;
	}

	internal static AudioPreviewCreator xwd6KlG2sUB06qhJ8Bme()
	{
		return bYMFJTG2L8t8yArY6kjp;
	}
}
