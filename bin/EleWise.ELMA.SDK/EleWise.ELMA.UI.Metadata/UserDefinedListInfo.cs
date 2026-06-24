using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
public sealed class UserDefinedListInfo
{
	internal static UserDefinedListInfo OssdfKBhm08Bkp6pktD3;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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

	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
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

	public Guid SubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
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
					_003CSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

	public List<GroupingProperty> GroupingProperties { get; set; }

	public List<AggregationProperty> AggregationProperties { get; set; }

	public List<IncludedProperty> IncludedProperties { get; set; }

	public string ComputedEqlQuery
	{
		[CompilerGenerated]
		get
		{
			return _003CComputedEqlQuery_003Ek__BackingField;
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
					_003CComputedEqlQuery_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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

	public UserDefinedListInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				IncludedProperties = new List<IncludedProperty>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				AggregationProperties = new List<AggregationProperty>();
				num = 3;
				break;
			case 1:
				GroupingProperties = new List<GroupingProperty>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeGroupingProperties()
	{
		return wT1VBUBhJZDtWLMJtJQs(GroupingProperties) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeAggregationProperties()
	{
		return JcJxHABh9ZNtC9M9KOAQ(AggregationProperties) != 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeIncludedProperties()
	{
		return hZYP8sBhdhujVoCiOyZy(IncludedProperties) != 0;
	}

	internal static bool V44WstBhyUvJ1vlbJfeK()
	{
		return OssdfKBhm08Bkp6pktD3 == null;
	}

	internal static UserDefinedListInfo NQhEhCBhMwacQC7mR8g7()
	{
		return OssdfKBhm08Bkp6pktD3;
	}

	internal static int wT1VBUBhJZDtWLMJtJQs(object P_0)
	{
		return ((List<GroupingProperty>)P_0).Count;
	}

	internal static int JcJxHABh9ZNtC9M9KOAQ(object P_0)
	{
		return ((List<AggregationProperty>)P_0).Count;
	}

	internal static int hZYP8sBhdhujVoCiOyZy(object P_0)
	{
		return ((List<IncludedProperty>)P_0).Count;
	}
}
