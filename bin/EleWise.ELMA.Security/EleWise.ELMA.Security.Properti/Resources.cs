using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	internal static Resources sv7rnUBQv3BXlhch2Hg;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
					return resourceMan;
				case 2:
					if (resourceMan != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				resourceMan = new ResourceManager("EleWise.ELMA.Security.Properties.Resources", qNBFY0B8gsrNSsmmkFJ(typeof(Resources).TypeHandle).Assembly);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap ELMA => (Bitmap)Hs7lhGBypK0yxZ41RmH(nH8lV2BrB7qeh7GhwGr(), WPcTsAB3ySTyquQp8Ih(0x201ABE6B ^ 0x201AF78D), resourceCulture);

	internal static byte[] SystemUser => (byte[])Hs7lhGBypK0yxZ41RmH(ResourceManager, WPcTsAB3ySTyquQp8Ih(0x31274285 ^ 0x31270B77), resourceCulture);

	internal Resources()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		G6qgCyBgs2cHhXRL3Sp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void G6qgCyBgs2cHhXRL3Sp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool L18kRABdGV56gKxRExr()
	{
		return sv7rnUBQv3BXlhch2Hg == null;
	}

	internal static Resources EgLkMFBTln8OyacTgOy()
	{
		return sv7rnUBQv3BXlhch2Hg;
	}

	internal static Type qNBFY0B8gsrNSsmmkFJ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nH8lV2BrB7qeh7GhwGr()
	{
		return ResourceManager;
	}

	internal static object WPcTsAB3ySTyquQp8Ih(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Hs7lhGBypK0yxZ41RmH(object P_0, object P_1, object P_2)
	{
		return ((ResourceManager)P_0).GetObject((string)P_1, (CultureInfo)P_2);
	}
}
