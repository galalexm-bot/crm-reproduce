using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public class StringKeyLinkedObject : MetadataLinkedObject, IStringKeyLinkedObject, ILinkedObject
{
	private static StringKeyLinkedObject xIyboIb11LTm9CFsxIPy;

	public string UidStr
	{
		[CompilerGenerated]
		get
		{
			return _003CUidStr_003Ek__BackingField;
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
					_003CUidStr_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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

	public StringKeyLinkedObject()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AdPC5ub1pQoSEQ486eC5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool nPAXHQb1Nrd5OuMsgRtL()
	{
		return xIyboIb11LTm9CFsxIPy == null;
	}

	internal static StringKeyLinkedObject pnUD8vb1341NV580FdOa()
	{
		return xIyboIb11LTm9CFsxIPy;
	}

	internal static void AdPC5ub1pQoSEQ486eC5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
