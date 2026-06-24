using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ListViewItemAddingException : Exception
{
	private static ListViewItemAddingException igse64oONkpf7cQKkgSD;

	public Guid ParentUid
	{
		[CompilerGenerated]
		get
		{
			return _003CParentUid_003Ek__BackingField;
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
					_003CParentUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
					_003CItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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

	public override string Message => (string)kaBuIdoOwRosqT6RN9ly(l6GRbDoOtREif5xYEHe0(0x1DE3DD89 ^ 0x1DE1834B), ItemUid, ParentUid);

	public ListViewItemAddingException(ViewItem parent, ViewItem item)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		v5fINqoOaSEN2trfEsJF();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ParentUid = zvILkZoODF1PgVxbOunb(parent);
				num = 2;
				break;
			case 2:
				ItemUid = zvILkZoODF1PgVxbOunb(item);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool PaFsZXoO3ej7hPBFntu5()
	{
		return igse64oONkpf7cQKkgSD == null;
	}

	internal static ListViewItemAddingException RoT4yXoOpGrMI9NEU4WJ()
	{
		return igse64oONkpf7cQKkgSD;
	}

	internal static void v5fINqoOaSEN2trfEsJF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Guid zvILkZoODF1PgVxbOunb(object P_0)
	{
		return ((ViewItem)P_0).Uid;
	}

	internal static object l6GRbDoOtREif5xYEHe0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kaBuIdoOwRosqT6RN9ly(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
