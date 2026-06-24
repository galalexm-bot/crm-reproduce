using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
[DiagnosticEvents(StartEvent = typeof(RenderViewStartEvent), EndEvent = typeof(RenderViewEndEvent), ErrorEvent = typeof(RenderViewErrorEvent))]
public class RenderViewInfo : AbstractCallInfo, IEmptyCallInfo
{
	private static RenderViewInfo kAk4o3EFMQlvp053GdpH;

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
				case 1:
					_003CViewContext_003Ek__BackingField = value;
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

	public string VirtualPath
	{
		[CompilerGenerated]
		get
		{
			return _003CVirtualPath_003Ek__BackingField;
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
					_003CVirtualPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
				case 1:
					_003CIsPartial_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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

	public override string CallType => (string)fqEaVMEFluCZYvTX04ow(-105199646 ^ -104927316);

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
					obj = VirtualPath;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = fqEaVMEFluCZYvTX04ow(0x2A7797B7 ^ 0x2A73B0FD);
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
				case 1:
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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

	public RenderViewInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t8t4BQEFdD0xbhSuLVZ7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RenderViewInfo(ViewContext viewContext, string virtualPath, bool isPartial)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t8t4BQEFdD0xbhSuLVZ7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 1:
				VirtualPath = virtualPath;
				num = 2;
				continue;
			case 2:
				IsPartial = isPartial;
				num = 3;
				continue;
			}
			ViewContext = viewContext;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
			{
				num = 1;
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
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
				w52mCxEFrVDi6UNJGkxZ(info, fqEaVMEFluCZYvTX04ow(-2112703338 ^ -2112449722), IsPartial);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void t8t4BQEFdD0xbhSuLVZ7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool iDdaFVEFJOqa55p2Fccn()
	{
		return kAk4o3EFMQlvp053GdpH == null;
	}

	internal static RenderViewInfo vpcJk7EF98M149V9GuYF()
	{
		return kAk4o3EFMQlvp053GdpH;
	}

	internal static object fqEaVMEFluCZYvTX04ow(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void w52mCxEFrVDi6UNJGkxZ(object P_0, object P_1, bool P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
