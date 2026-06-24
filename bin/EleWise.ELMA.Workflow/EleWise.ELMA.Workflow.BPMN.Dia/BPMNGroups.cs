using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

public static class BPMNGroups
{
	[Component(Order = 10)]
	public class BPMNPanel : IBPMNToolboxItemPanel
	{
		public static readonly Guid UID;

		internal static BPMNPanel Doj3MPvyPp8BbxhNSTLO;

		public Guid PanelUid => UID;

		public string Title => (string)daaO6RvyD6euytJOgQX5(TWCk3uvyurBHxiapGw3I(0x1C7F6FED ^ 0x1C7DB795));

		public Image Image => Resources.bpmnElement;

		public BPMNPanel()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static BPMNPanel()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					Nj7MZGvynSP2i5uoKELR();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					UID = new Guid((string)TWCk3uvyurBHxiapGw3I(0x13F63440 ^ 0x13F4ECD6));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static object TWCk3uvyurBHxiapGw3I(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object daaO6RvyD6euytJOgQX5(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool UIE1gavyXK8a3nyr94N1()
		{
			return Doj3MPvyPp8BbxhNSTLO == null;
		}

		internal static BPMNPanel M5ukMavydsXRTl4eWoey()
		{
			return Doj3MPvyPp8BbxhNSTLO;
		}

		internal static void Nj7MZGvynSP2i5uoKELR()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 100)]
	public class Events : IBPMNToolboxItemGroup, IToolboxItemGroup
	{
		public static readonly Guid UID;

		internal static Events Dg3hLwvyHbEef9XDWvZu;

		public Guid PanelUid => BPMNPanel.UID;

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => (string)R33v8evyWnxJ3EvXl4WQ(K6C1UTvy9YFvDPGwSvtD(0x2269BD32 ^ 0x226B2144));

		public Events()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static Events()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					djBwnFvyjeTv0fFPSwK7();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x11360A26));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static object K6C1UTvy9YFvDPGwSvtD(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object R33v8evyWnxJ3EvXl4WQ(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool bwm27LvyLPYddgu9cTGq()
		{
			return Dg3hLwvyHbEef9XDWvZu == null;
		}

		internal static Events f1B0f2vyfMO4Rh14fi6Z()
		{
			return Dg3hLwvyHbEef9XDWvZu;
		}

		internal static void djBwnFvyjeTv0fFPSwK7()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 200)]
	public class Operations : IBPMNToolboxItemGroup, IToolboxItemGroup
	{
		public static readonly Guid UID;

		internal static Operations BiflctvyR8iNEI0OJGNI;

		public Guid PanelUid => BPMNPanel.UID;

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => SR.T((string)RRxwQqvy3lm5PHYgc3r8(0x1EA50FCC ^ 0x1EA7D6FA));

		public Operations()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LbdAA5vyTu98Wmb3FQ5X();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static Operations()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
					{
						num2 = 0;
					}
					break;
				default:
					UID = new Guid((string)RRxwQqvy3lm5PHYgc3r8(-947937941 ^ -948091871));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static object RRxwQqvy3lm5PHYgc3r8(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool tRD2m9vy6S0pIjuP2JmR()
		{
			return BiflctvyR8iNEI0OJGNI == null;
		}

		internal static Operations Dv5RNWvyqELVgQwPGaVl()
		{
			return BiflctvyR8iNEI0OJGNI;
		}

		internal static void LbdAA5vyTu98Wmb3FQ5X()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 300)]
	public class Subprocesses : IBPMNToolboxItemGroup, IToolboxItemGroup
	{
		public static readonly Guid UID;

		internal static Subprocesses XLwiNvvyQg0QR3xlXM1o;

		public Guid PanelUid => BPMNPanel.UID;

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => (string)lAqkGFvyMIxsws20T1ZC(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712551167));

		public Subprocesses()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static Subprocesses()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					yaNtkTvykSdsva1cCIxb();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					UID = new Guid((string)BXv8JAvyUiMpBVmjNbR6(-39189604 ^ -39265786));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		internal static object lAqkGFvyMIxsws20T1ZC(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool gVRl6mvyp7FsX950V4Zc()
		{
			return XLwiNvvyQg0QR3xlXM1o == null;
		}

		internal static Subprocesses z90UE1vyCypk7AuDGeHD()
		{
			return XLwiNvvyQg0QR3xlXM1o;
		}

		internal static void yaNtkTvykSdsva1cCIxb()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object BXv8JAvyUiMpBVmjNbR6(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	[Component(Order = 400)]
	public class Gateways : IBPMNToolboxItemGroup, IToolboxItemGroup
	{
		public static readonly Guid UID;

		internal static Gateways m0TfZXvyVUYRt6SOXmxg;

		public Guid PanelUid => BPMNPanel.UID;

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => (string)Xv0psYvy2ImGBqEgivtd(CFamlKvy7d7GIkmFUKM0(-420003255 ^ -420095867));

		public Gateways()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			h43X0gvyoZpdwJJACQ4i();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static Gateways()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					h43X0gvyoZpdwJJACQ4i();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					UID = new Guid((string)CFamlKvy7d7GIkmFUKM0(0x1EA50FCC ^ 0x1EA7D626));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object CFamlKvy7d7GIkmFUKM0(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Xv0psYvy2ImGBqEgivtd(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool JnXx41vyAip2xp0VgaXi()
		{
			return m0TfZXvyVUYRt6SOXmxg == null;
		}

		internal static Gateways OEXJqKvyGlRclP33nPGJ()
		{
			return m0TfZXvyVUYRt6SOXmxg;
		}

		internal static void h43X0gvyoZpdwJJACQ4i()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 500)]
	public class Swimlanes : IBPMNToolboxItemGroup, IToolboxItemGroup
	{
		public static readonly Guid UID;

		private static Swimlanes AuXEMNvyFxaCl3JuTU5R;

		public Guid PanelUid => BPMNPanel.UID;

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667577349));

		public Swimlanes()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static Swimlanes()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					WLgbrqvya5xNimvflDHc();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					UID = new Guid((string)uDTDvVvyrCnuPa5Vc1e8(-1386448964 ^ -1386304038));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static bool jwGXt7vyiQJSw041yRGY()
		{
			return AuXEMNvyFxaCl3JuTU5R == null;
		}

		internal static Swimlanes hwSPSfvyIDI1mAgnVQiS()
		{
			return AuXEMNvyFxaCl3JuTU5R;
		}

		internal static void WLgbrqvya5xNimvflDHc()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object uDTDvVvyrCnuPa5Vc1e8(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	[Component(Order = 600)]
	public class Artefacts : IBPMNToolboxItemGroup, IToolboxItemGroup
	{
		public static readonly Guid UID;

		internal static Artefacts w3Hi1TvyebYukIUJnfje;

		public Guid PanelUid => BPMNPanel.UID;

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7DC503));

		public Artefacts()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static Artefacts()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					UID = new Guid((string)fWlduMvy1g9mG369aqpA(-105863102 ^ -105745676));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					h6hcZivySJf2DUfSDRak();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static bool WDDNblvyNNGnOltKZi6M()
		{
			return w3Hi1TvyebYukIUJnfje == null;
		}

		internal static Artefacts dinJGlvyxMmOicp9VF7m()
		{
			return w3Hi1TvyebYukIUJnfje;
		}

		internal static void h6hcZivySJf2DUfSDRak()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object fWlduMvy1g9mG369aqpA(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}
}
