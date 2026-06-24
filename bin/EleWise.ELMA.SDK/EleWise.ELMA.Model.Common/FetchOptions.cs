using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

[Serializable]
[DataContract]
public sealed class FetchOptions : IEquatable<FetchOptions>
{
	private int firstResult;

	private int maxResults;

	private ListSortDirection sortDirection;

	private string sortExpression;

	private List<FetchOptionsSortDescriptor> sortDescriptors;

	internal static FetchOptions ocF3WohTcM8axpnHbmUx;

	public static FetchOptions All => new FetchOptions(0, 0, ListSortDirection.Ascending, null);

	public static FetchOptions First => new FetchOptions(0, 1);

	[DataMember]
	public int FirstResult
	{
		get
		{
			return firstResult;
		}
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
					firstResult = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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

	[DataMember]
	public int MaxResults
	{
		get
		{
			return maxResults;
		}
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
					maxResults = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public List<FetchOptionsSortDescriptor> SortDescriptors
	{
		get
		{
			return sortDescriptors;
		}
		set
		{
			sortDescriptors = value;
		}
	}

	[DataMember]
	public string SortExpression
	{
		get
		{
			return sortExpression;
		}
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
					sortExpression = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
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

	[DataMember]
	public ListSortDirection SortDirection
	{
		get
		{
			return sortDirection;
		}
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
					sortDirection = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public List<string> SelectColumns { get; set; }

	[DataMember]
	public List<string> FetchRelations { get; set; }

	[DataMember]
	public string QueryKey
	{
		[CompilerGenerated]
		get
		{
			return _003CQueryKey_003Ek__BackingField;
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
					_003CQueryKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public bool UseProjections
	{
		[CompilerGenerated]
		get
		{
			return _003CUseProjections_003Ek__BackingField;
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
					_003CUseProjections_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public bool UsePartialFetching
	{
		[CompilerGenerated]
		get
		{
			return _003CUsePartialFetching_003Ek__BackingField;
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
					_003CUsePartialFetching_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	internal bool DisableDefaultGroupSorting
	{
		[CompilerGenerated]
		get
		{
			return _003CDisableDefaultGroupSorting_003Ek__BackingField;
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
					_003CDisableDefaultGroupSorting_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	public FetchOptions()
	{
		//Discarded unreachable code: IL_0047, IL_004c
		WLoE6HhkBUlGXxa0156L();
		maxResults = 20;
		sortDescriptors = new List<FetchOptionsSortDescriptor>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FetchOptions(int firstResult, int maxResults)
	{
		//Discarded unreachable code: IL_0037, IL_003c
		WLoE6HhkBUlGXxa0156L();
		this.maxResults = 20;
		sortDescriptors = new List<FetchOptionsSortDescriptor>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.firstResult = firstResult;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.maxResults = maxResults;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public FetchOptions(int firstResult, int maxResults, ListSortDirection sortDirection, string sortExpression)
	{
		//Discarded unreachable code: IL_0047, IL_004c
		SingletonReader.JJCZtPuTvSt();
		this.maxResults = 20;
		sortDescriptors = new List<FetchOptionsSortDescriptor>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				this.sortExpression = sortExpression;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num = 3;
				}
				break;
			case 1:
				this.sortDirection = sortDirection;
				num = 4;
				break;
			case 2:
				this.maxResults = maxResults;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num = 1;
				}
				break;
			default:
				this.firstResult = firstResult;
				num = 2;
				break;
			case 3:
				return;
			}
		}
	}

	public FetchOptions(int firstResult, int maxResults, string sortExpression)
	{
		//Discarded unreachable code: IL_0037, IL_007b, IL_008a
		SingletonReader.JJCZtPuTvSt();
		this.maxResults = 20;
		sortDescriptors = new List<FetchOptionsSortDescriptor>();
		base._002Ector();
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 7:
				return;
			case 3:
				return;
			case 2:
				if (gU6Nl1hkbtqc8t5cJjsq(sortExpression, qR4bbAhko3rb2V0vQZTs(0x34A6D230 ^ 0x34A59C20), StringComparison.OrdinalIgnoreCase))
				{
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num = 4;
					}
					break;
				}
				if (gU6Nl1hkbtqc8t5cJjsq(sortExpression, qR4bbAhko3rb2V0vQZTs(0x5A4C7B29 ^ 0x5A4F3537), StringComparison.OrdinalIgnoreCase))
				{
					int num2 = 9;
					num = num2;
					break;
				}
				this.sortExpression = sortExpression;
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num = 1;
				}
				break;
			default:
				this.maxResults = maxResults;
				num = 10;
				break;
			case 4:
				sortDirection = ListSortDirection.Descending;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num = 8;
				}
				break;
			case 8:
				this.sortExpression = sortExpression.Remove(K7gr4AhkhlovZc2kuHKL(sortExpression) - 5);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num = 1;
				}
				break;
			case 9:
				this.sortExpression = (string)t9usB9hkGD2K8RsJOctq(sortExpression, K7gr4AhkhlovZc2kuHKL(sortExpression) - 4);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num = 3;
				}
				break;
			case 10:
				if (FL1almhkWhXCjglPqggX(sortExpression))
				{
					num = 7;
					break;
				}
				goto case 2;
			case 5:
				this.firstResult = firstResult;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				break;
			case 6:
				return;
			case 1:
				return;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_007b, IL_008e
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (obj != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				return false;
			case 1:
				if (this == obj)
				{
					num2 = 4;
					break;
				}
				if (!(obj.GetType() != THbhslhkEwEcHApiBSk6(this)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return false;
			default:
				return Equals((FetchOptions)obj);
			case 4:
				return true;
			}
		}
	}

	private bool SortDescriptorsSequenceEqual(List<FetchOptionsSortDescriptor> sortDescriptorsObj, List<FetchOptionsSortDescriptor> otherSortDescriptorsObj)
	{
		if (sortDescriptorsObj == otherSortDescriptorsObj)
		{
			return true;
		}
		if (sortDescriptorsObj == null || otherSortDescriptorsObj == null)
		{
			return false;
		}
		if (!sortDescriptorsObj.SequenceEqual(otherSortDescriptorsObj))
		{
			return sortDescriptorsObj.Equals(otherSortDescriptorsObj);
		}
		return true;
	}

	public bool Equals(FetchOptions other)
	{
		//Discarded unreachable code: IL_006e, IL_007d, IL_008c, IL_00b7, IL_00c6
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 9:
				return UsePartialFetching == other.UsePartialFetching;
			default:
				return false;
			case 12:
				if (maxResults == other.maxResults)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 2:
				return true;
			case 7:
				if ((object)other == null)
				{
					num2 = 6;
					break;
				}
				if ((object)this != other)
				{
					if (firstResult == other.firstResult)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto default;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				return false;
			case 13:
				if (utXdVmhkQClJOfXKgCUo(FetchRelations, other.FetchRelations))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto default;
			case 10:
				if (UseProjections == L2f6A5hkvjr8u326ZNXI(other))
				{
					num2 = 9;
					break;
				}
				goto default;
			case 3:
				if (!utXdVmhkQClJOfXKgCUo(SelectColumns, other.SelectColumns))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 13;
			case 11:
				if (UN9l9ChkffK2RALTHF0q(sortExpression, other.sortExpression, StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto default;
			case 14:
				if (!SortDescriptorsSequenceEqual(SortDescriptors, other.SortDescriptors))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 4:
				if (sortDirection == other.sortDirection)
				{
					num2 = 11;
					break;
				}
				goto default;
			case 8:
				if (!string.Equals(QueryKey, (string)RT6Kk7hkC8OR887ruHnH(other), StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 5;
					break;
				}
				goto case 10;
			}
		}
	}

	public override int GetHashCode()
	{
		return (int)(((((((((((((((uint)(((firstResult * 397) ^ maxResults) * 397) ^ (uint)sortDirection) * 397) ^ (uint)((sortExpression != null) ? sbEfBmhkZaOaxhJD11ml(BZ7ox9hk8c2jLPfjgBxA(), sortExpression) : 0)) * 397) ^ (uint)((SortDescriptors != null) ? SelectColumns.GetHashCode() : 0)) * 397) ^ (uint)((SelectColumns != null) ? SelectColumns.GetHashCode() : 0)) * 397) ^ (uint)((FetchRelations != null) ? FetchRelations.GetHashCode() : 0)) * 397) ^ (uint)((QueryKey != null) ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(QueryKey) : 0)) * 397) ^ (uint)UseProjections.GetHashCode()) * 397) ^ UsePartialFetching.GetHashCode();
	}

	public static bool operator ==(FetchOptions left, FetchOptions right)
	{
		return object.Equals(left, right);
	}

	public static bool operator !=(FetchOptions left, FetchOptions right)
	{
		return !object.Equals(left, right);
	}

	internal static void WLoE6HhkBUlGXxa0156L()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool HDJVHihTzNSDe21HvsqB()
	{
		return (object)ocF3WohTcM8axpnHbmUx == null;
	}

	internal static FetchOptions orpdINhkFO2UFhsh1Av0()
	{
		return ocF3WohTcM8axpnHbmUx;
	}

	internal static bool FL1almhkWhXCjglPqggX(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object qR4bbAhko3rb2V0vQZTs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool gU6Nl1hkbtqc8t5cJjsq(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	internal static int K7gr4AhkhlovZc2kuHKL(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object t9usB9hkGD2K8RsJOctq(object P_0, int P_1)
	{
		return ((string)P_0).Remove(P_1);
	}

	internal static Type THbhslhkEwEcHApiBSk6(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool UN9l9ChkffK2RALTHF0q(object P_0, object P_1, StringComparison P_2)
	{
		return string.Equals((string)P_0, (string)P_1, P_2);
	}

	internal static bool utXdVmhkQClJOfXKgCUo(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object RT6Kk7hkC8OR887ruHnH(object P_0)
	{
		return ((FetchOptions)P_0).QueryKey;
	}

	internal static bool L2f6A5hkvjr8u326ZNXI(object P_0)
	{
		return ((FetchOptions)P_0).UseProjections;
	}

	internal static object BZ7ox9hk8c2jLPfjgBxA()
	{
		return StringComparer.InvariantCultureIgnoreCase;
	}

	internal static int sbEfBmhkZaOaxhJD11ml(object P_0, object P_1)
	{
		return ((StringComparer)P_0).GetHashCode((string)P_1);
	}
}
