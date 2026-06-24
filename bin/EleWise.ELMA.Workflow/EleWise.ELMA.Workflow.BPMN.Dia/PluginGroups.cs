using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

public static class PluginGroups
{
	[Component(Order = 100)]
	public class PluginsPanel : IBPMNToolboxItemPanel
	{
		public static readonly Guid UID;

		internal static PluginsPanel XYI4CtvyhfqnK1qaITy2;

		public Guid PanelUid => UID;

		public string Title => SR.T((string)efU0NOvy4JCNwKDDunpo(0x7AC609FE ^ 0x7AC4D2F8));

		public Image Image => (Image)hDe0gYvyzZ0SgaiyQNJY();

		public PluginsPanel()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ysGDfjvmKhRV4LYtpmXD();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static PluginsPanel()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UID = new Guid((string)efU0NOvy4JCNwKDDunpo(0x65B7F624 ^ 0x65B52D3E));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					ysGDfjvmKhRV4LYtpmXD();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object efU0NOvy4JCNwKDDunpo(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool KxZnu3vyEV4WaoyS2UG8()
		{
			return XYI4CtvyhfqnK1qaITy2 == null;
		}

		internal static PluginsPanel FL8cy9vywFYNHLkXVjwW()
		{
			return XYI4CtvyhfqnK1qaITy2;
		}

		internal static object hDe0gYvyzZ0SgaiyQNJY()
		{
			return Resources.plugins;
		}

		internal static void ysGDfjvmKhRV4LYtpmXD()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 100)]
	public class DocumentGeneration : IBPMNToolboxItemGroup, IToolboxItemGroup
	{
		public static readonly Guid UID;

		internal static DocumentGeneration pyXVvjvmOWNXvKqBQE8t;

		public Guid PanelUid => PluginsPanel.UID;

		public Guid GroupUid => UID;

		public Guid ParentGroupUid => Guid.Empty;

		public string Name => (string)uQ5Nk7vm8ekcAEDLbJup(e2ryt0vmYGLbdLDEbHiY(-495296780 ^ -495395632));

		public DocumentGeneration()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Y3JZGHvms4IeKlif3paM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static DocumentGeneration()
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
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					UID = new Guid((string)e2ryt0vmYGLbdLDEbHiY(-25709590 ^ -25859968));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object e2ryt0vmYGLbdLDEbHiY(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object uQ5Nk7vm8ekcAEDLbJup(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool IbbDTPvmZybBKkIIwnnF()
		{
			return pyXVvjvmOWNXvKqBQE8t == null;
		}

		internal static DocumentGeneration Y9cEGIvmvJIpDDVJY2LW()
		{
			return pyXVvjvmOWNXvKqBQE8t;
		}

		internal static void Y3JZGHvms4IeKlif3paM()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}
}
