using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
public sealed class PublicAPIAttribute : Attribute
{
	private static PublicAPIAttribute Aua0mqffdQM6Zh6h6xoq;

	public string Comment
	{
		[CompilerGenerated]
		get
		{
			return _003CComment_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CComment_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PublicAPIAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ala8cpffg5xCNnoht9VL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicAPIAttribute([NotNull] string comment)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ala8cpffg5xCNnoht9VL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Comment = comment;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void ala8cpffg5xCNnoht9VL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool D2tEEcfflIPLSD0nOAd7()
	{
		return Aua0mqffdQM6Zh6h6xoq == null;
	}

	internal static PublicAPIAttribute oYdqAdffrq1aVhKVTVLD()
	{
		return Aua0mqffdQM6Zh6h6xoq;
	}
}
