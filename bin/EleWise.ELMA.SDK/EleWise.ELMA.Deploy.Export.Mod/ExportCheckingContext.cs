using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export.Models;

public sealed class ExportCheckingContext : IExportCheckingContext, ILinkedExportCheckingContext
{
	private static ExportCheckingContext JYG8uYELD3QrRXfZeK5J;

	public ConfigExportSettings Settings
	{
		[CompilerGenerated]
		get
		{
			return _003CSettings_003Ek__BackingField;
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
				case 1:
					_003CSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ExportCheckingMessageType? DefaultExportLinkChecking { get; set; }

	public LinkedObjectsSearchParams SearchParams
	{
		[CompilerGenerated]
		get
		{
			return _003CSearchParams_003Ek__BackingField;
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
				case 1:
					_003CSearchParams_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ExportCheckingContext()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IKhA9UEL45yYu4598KsH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool K0XulrELtQFkGKDbZQfX()
	{
		return JYG8uYELD3QrRXfZeK5J == null;
	}

	internal static ExportCheckingContext zAwQtEELwMTy0iDTZyhY()
	{
		return JYG8uYELD3QrRXfZeK5J;
	}

	internal static void IKhA9UEL45yYu4598KsH()
	{
		SingletonReader.PushGlobal();
	}
}
