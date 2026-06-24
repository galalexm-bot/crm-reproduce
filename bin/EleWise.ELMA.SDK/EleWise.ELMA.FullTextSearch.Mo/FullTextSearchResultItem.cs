using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

public class FullTextSearchResultItem : IFullTextSearchResultItem
{
	internal static FullTextSearchResultItem JkDp09GqWCZPdgEf3UhK;

	public Dictionary<string, List<string>> Highlights { get; set; }

	public long HighlightsCount
	{
		get
		{
			//Discarded unreachable code: IL_009e, IL_00ad
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					return 0L;
				case 2:
					if (!Highlights.Any())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				default:
					Highlights.Values.ForEach(_003C_003Ec__DisplayClass5_._003Cget_HighlightsCount_003Eb__0);
					num2 = 3;
					break;
				case 4:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 5;
					break;
				case 5:
					_003C_003Ec__DisplayClass5_.cnt = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Dictionary<string, object> ResultDictionary { get; set; }

	public WebData ResultData
	{
		[CompilerGenerated]
		get
		{
			return _003CResultData_003Ek__BackingField;
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
					_003CResultData_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IFullTextSearchObject ResultObject
	{
		[CompilerGenerated]
		get
		{
			return _003CResultObject_003Ek__BackingField;
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
					_003CResultObject_003Ek__BackingField = value;
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

	public FullTextSearchResultItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nLvHJQGqh5lKS7xaXN0o();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DY5jcNGqou2NQoTun1PP()
	{
		return JkDp09GqWCZPdgEf3UhK == null;
	}

	internal static FullTextSearchResultItem suZlY8Gqbjrk3MQ6D1c9()
	{
		return JkDp09GqWCZPdgEf3UhK;
	}

	internal static void nLvHJQGqh5lKS7xaXN0o()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
