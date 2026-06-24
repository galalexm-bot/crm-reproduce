using System;
using System.Collections.Generic;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
public class DatePartProperty : UserDefinedListPropertyBase
{
	internal static DatePartProperty C9mPD9BhZnjWLUtXLRqD;

	public List<int> DatePartTypes { get; set; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeAggregationProperties()
	{
		return R5FVPMBhVYdMiQKJilx5(DatePartTypes) != 0;
	}

	public DatePartProperty()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		viZ7TmBhS4WA6ZTkgr7J();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static int R5FVPMBhVYdMiQKJilx5(object P_0)
	{
		return ((List<int>)P_0).Count;
	}

	internal static bool QxSfO9BhuVYtECi71cpW()
	{
		return C9mPD9BhZnjWLUtXLRqD == null;
	}

	internal static DatePartProperty oHZo83BhIbBlwmQiqnDQ()
	{
		return C9mPD9BhZnjWLUtXLRqD;
	}

	internal static void viZ7TmBhS4WA6ZTkgr7J()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
