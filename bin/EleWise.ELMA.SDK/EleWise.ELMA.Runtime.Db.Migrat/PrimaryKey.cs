using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public class PrimaryKey
{
	private static PrimaryKey Wfv7NIWO7sXcBYgHEEuv;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string TableName
	{
		[CompilerGenerated]
		get
		{
			return _003CTableName_003Ek__BackingField;
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
					_003CTableName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

	public List<string> Columns { get; set; }

	public PrimaryKey()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		z5yJlbWOm3W6P5jtlHkv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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
			Columns = new List<string>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool yc6nudWOxY1TfeITZByG()
	{
		return Wfv7NIWO7sXcBYgHEEuv == null;
	}

	internal static PrimaryKey O1dCYIWO06woGW09u0t4()
	{
		return Wfv7NIWO7sXcBYgHEEuv;
	}

	internal static void z5yJlbWOm3W6P5jtlHkv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
