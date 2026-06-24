using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Actions;

[DisplayName(typeof(__Resources_DefaultEntityActions), "DisplayName")]
public class DefaultEntityActions
{
	[Image(typeof(DefaultEntityActions), "add_outline", 16, ImageFormatType.IconPack, false)]
	[DisplayName(typeof(__Resources_DefaultEntityActions), "P_Create_DisplayName")]
	[Uid("70c5300a-fafb-495c-bda9-4c5dc12cc8bd")]
	public const string Create = "70c5300a-fafb-495c-bda9-4c5dc12cc8bd";

	public static readonly Guid CreateGuid;

	[Uid("c573451f-5c32-469a-8e0b-a35ee73d80e0")]
	[DisplayName(typeof(__Resources_DefaultEntityActions), "P_View_DisplayName")]
	[Image(typeof(DefaultEntityActions), "visualibility", 16, ImageFormatType.IconPack, false)]
	public const string View = "c573451f-5c32-469a-8e0b-a35ee73d80e0";

	public static readonly Guid ViewGuid;

	[Image(typeof(DefaultEntityActions), "edit", 16, ImageFormatType.IconPack, false)]
	[Uid("42986da3-d210-414d-9225-f3cde17c18c9")]
	[DisplayName(typeof(__Resources_DefaultEntityActions), "P_Update_DisplayName")]
	public const string Update = "42986da3-d210-414d-9225-f3cde17c18c9";

	public static readonly Guid UpdateGuid;

	[Image(typeof(DefaultEntityActions), "basket", 16, ImageFormatType.IconPack, false)]
	[DisplayName(typeof(__Resources_DefaultEntityActions), "P_Delete_DisplayName")]
	[Uid("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
	public const string Delete = "f5d56c0f-95af-48d5-89a0-ea4e9a336429";

	public static readonly Guid EditCollectionGuid;

	[DisplayName("SR.M('Изменение свойства коллекции')")]
	[Uid("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
	[Image(typeof(DefaultEntityActions), "edit", 16, ImageFormatType.IconPack, false)]
	public const string EditCollection = "f5d56c0f-95af-48d5-89a0-ea4e9a336429";

	public static readonly Guid DeleteGuid;

	internal static DefaultEntityActions hpgCXYWY2FOYa3mBtJem;

	protected DefaultEntityActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DefaultEntityActions()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ViewGuid = new Guid((string)jqBbVkWYNgGRqyKOepHG(-576149596 ^ -576002682));
				num2 = 2;
				break;
			case 1:
				DeleteGuid = new Guid((string)jqBbVkWYNgGRqyKOepHG(-1317790512 ^ -1317642646));
				num2 = 5;
				break;
			case 5:
				return;
			case 4:
				jKmwQGWY1kMY5hY9duLa();
				num2 = 3;
				break;
			case 3:
				CreateGuid = new Guid((string)jqBbVkWYNgGRqyKOepHG(0x12441CA4 ^ 0x12465D72));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				EditCollectionGuid = new Guid((string)jqBbVkWYNgGRqyKOepHG(0x4EA5403C ^ 0x4EA70286));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				UpdateGuid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108800930));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	internal static bool YIklNFWYeB6Uy6ewxswB()
	{
		return hpgCXYWY2FOYa3mBtJem == null;
	}

	internal static DefaultEntityActions jSrsnmWYPKtTUBtJkedo()
	{
		return hpgCXYWY2FOYa3mBtJem;
	}

	internal static void jKmwQGWY1kMY5hY9duLa()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object jqBbVkWYNgGRqyKOepHG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
