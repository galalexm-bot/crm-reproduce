using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
[DiagnosticEvents(StartEvent = typeof(FindViewStartEvent), EndEvent = typeof(FindViewEndEvent))]
public class FindViewInfo : AbstractCallInfo, IEmptyCallInfo
{
	private static FindViewInfo q7PNKeEFOeDmqFkVZoPY;

	public ViewEngineResult ViewEngineResult
	{
		[CompilerGenerated]
		get
		{
			return _003CViewEngineResult_003Ek__BackingField;
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
					_003CViewEngineResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ControllerContext ControllerContext
	{
		[CompilerGenerated]
		get
		{
			return _003CControllerContext_003Ek__BackingField;
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
					_003CControllerContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ViewContext ViewContext
	{
		[CompilerGenerated]
		get
		{
			return _003CViewContext_003Ek__BackingField;
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
					_003CViewContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ViewName
	{
		[CompilerGenerated]
		get
		{
			return _003CViewName_003Ek__BackingField;
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
					_003CViewName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string MasterName
	{
		[CompilerGenerated]
		get
		{
			return _003CMasterName_003Ek__BackingField;
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
					_003CMasterName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<string> SearchedLocations { get; set; }

	public bool IsFound
	{
		[CompilerGenerated]
		get
		{
			return _003CIsFound_003Ek__BackingField;
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
					_003CIsFound_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool UseCache
	{
		[CompilerGenerated]
		get
		{
			return _003CUseCache_003Ek__BackingField;
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
					_003CUseCache_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsPartial
	{
		[CompilerGenerated]
		get
		{
			return _003CIsPartial_003Ek__BackingField;
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
					_003CIsPartial_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string CallType => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x741B934);

	public override string Description
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = ViewName;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = lTfgnOEF1xVmtdUU7KNJ(-1822890472 ^ -1822637742);
					break;
				}
				break;
			}
			return (string)obj;
		}
	}

	public bool IsEmpty
	{
		[CompilerGenerated]
		get
		{
			return _003CIsEmpty_003Ek__BackingField;
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
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FindViewInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PQfGwsEFPw5BRtBHm5pA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FindViewInfo(ControllerContext controllerContext, string viewName, string masterName, IEnumerable<string> searchedLocations, bool isFound, bool useCache, bool isPartial)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		ControllerContext = controllerContext;
		ViewContext = controllerContext.get_ParentActionViewContext();
		ViewName = viewName;
		MasterName = masterName;
		SearchedLocations = searchedLocations;
		IsFound = isFound;
		UseCache = useCache;
		IsPartial = isPartial;
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_00bc
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					L7a54cEF3WOxgRIKLPfL(info, lTfgnOEF1xVmtdUU7KNJ(0x68BBB53E ^ 0x68BF92BA), SearchedLocations);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					yXfRP2EFpXZwjwkQvQdy(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12403B74), IsPartial);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548F89E6), MasterName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (SearchedLocations != null)
					{
						num = 2;
						break;
					}
					goto case 1;
				case 1:
				case 8:
					yXfRP2EFpXZwjwkQvQdy(info, lTfgnOEF1xVmtdUU7KNJ(0x4DC2B14D ^ 0x4DC696E7), IsFound);
					num2 = 4;
					continue;
				case 2:
					if (SearchedLocations.Any())
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 9;
				case 4:
					yXfRP2EFpXZwjwkQvQdy(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1633E395), UseCache);
					num = 3;
					break;
				case 7:
					return;
				case 6:
					if (!BlOoagEFNdHG287ASFoN(MasterName))
					{
						num = 5;
						break;
					}
					goto default;
				}
				break;
			}
		}
	}

	internal static void PQfGwsEFPw5BRtBHm5pA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool RIh2pPEF2a82dB88Zpcw()
	{
		return q7PNKeEFOeDmqFkVZoPY == null;
	}

	internal static FindViewInfo cMEG1yEFe72hAnALEGji()
	{
		return q7PNKeEFOeDmqFkVZoPY;
	}

	internal static object lTfgnOEF1xVmtdUU7KNJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool BlOoagEFNdHG287ASFoN(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static void L7a54cEF3WOxgRIKLPfL(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void yXfRP2EFpXZwjwkQvQdy(object P_0, object P_1, bool P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
