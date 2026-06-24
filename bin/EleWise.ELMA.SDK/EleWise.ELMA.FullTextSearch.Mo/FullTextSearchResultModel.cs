using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.FullTextSearch.Exceptions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

public class FullTextSearchResultModel
{
	public Guid TypeUid;

	public string Index;

	public List<FullTextSearchResultItem> Items;

	public List<string> ListReturnFields;

	private static FullTextSearchResultModel f5B6G0GqGTGSIdvWKDHo;

	public long Total
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040, IL_0094
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 2:
						if (Items == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto default;
					default:
						if (Items.Any())
						{
							num3 = Items.Count();
							break;
						}
						goto end_IL_0012;
					case 1:
					case 3:
						num3 = 0;
						break;
					}
					return num3;
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}
	}

	public int CountAllResult
	{
		[CompilerGenerated]
		get
		{
			return _003CCountAllResult_003Ek__BackingField;
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
					_003CCountAllResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

	public FullTextFilterException Error
	{
		[CompilerGenerated]
		get
		{
			return _003CError_003Ek__BackingField;
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
					_003CError_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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

	public FullTextSearchResultModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UBF4aCGqEwWoBaLACJTe()
	{
		return f5B6G0GqGTGSIdvWKDHo == null;
	}

	internal static FullTextSearchResultModel EAiQP5GqfoQl3uWNPOR7()
	{
		return f5B6G0GqGTGSIdvWKDHo;
	}
}
