using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN;

[Serializable]
public class GenerationSettings
{
	private static GenerationSettings Fym7HWOkxXh7NH0Pu8aG;

	public bool IsScriptDoc
	{
		[CompilerGenerated]
		get
		{
			return _003CIsScriptDoc_003Ek__BackingField;
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
					_003CIsScriptDoc_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
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

	public bool MetricsOk
	{
		[CompilerGenerated]
		get
		{
			return _003CMetricsOk_003Ek__BackingField;
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
					_003CMetricsOk_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
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

	public bool ContexOk
	{
		[CompilerGenerated]
		get
		{
			return _003CContexOk_003Ek__BackingField;
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
					_003CContexOk_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool SubProcessOk
	{
		[CompilerGenerated]
		get
		{
			return _003CSubProcessOk_003Ek__BackingField;
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
					_003CSubProcessOk_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
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

	public bool ResponsibilityMatrOk
	{
		[CompilerGenerated]
		get
		{
			return _003CResponsibilityMatrOk_003Ek__BackingField;
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
					_003CResponsibilityMatrOk_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
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

	public bool TasksOk
	{
		[CompilerGenerated]
		get
		{
			return _003CTasksOk_003Ek__BackingField;
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
					_003CTasksOk_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
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

	public bool NotificationOk
	{
		[CompilerGenerated]
		get
		{
			return _003CNotificationOk_003Ek__BackingField;
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
					_003CNotificationOk_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
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

	public long ParentTableId
	{
		[CompilerGenerated]
		get
		{
			return _003CParentTableId_003Ek__BackingField;
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
					_003CParentTableId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ParentProcessUid
	{
		[CompilerGenerated]
		get
		{
			return _003CParentProcessUid_003Ek__BackingField;
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
					_003CParentProcessUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long ProcessId
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessId_003Ek__BackingField;
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
					_003CProcessId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
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

	public bool GenerationType
	{
		[CompilerGenerated]
		get
		{
			return _003CGenerationType_003Ek__BackingField;
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
					_003CGenerationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
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

	public string UserDirectory
	{
		[CompilerGenerated]
		get
		{
			return _003CUserDirectory_003Ek__BackingField;
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
					_003CUserDirectory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ServerDirectory
	{
		[CompilerGenerated]
		get
		{
			return _003CServerDirectory_003Ek__BackingField;
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
					_003CServerDirectory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<GroupProcessSetting> GroupProcess { get; set; }

	public Image ImageDiagram
	{
		[CompilerGenerated]
		get
		{
			return _003CImageDiagram_003Ek__BackingField;
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
					_003CImageDiagram_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
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

	public GenerationSettings()
	{
		//Discarded unreachable code: IL_002a, IL_00a4
		EU87PAOkhwbVdEjqpeI0();
		base._002Ector();
		int num = 8;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
		{
			num = 3;
		}
		IEnumerable<IDocumentationChapter> extensionPoints = default(IEnumerable<IDocumentationChapter>);
		while (true)
		{
			switch (num)
			{
			case 11:
				TasksOk = true;
				num = 9;
				continue;
			case 12:
				ContexOk = true;
				num = 15;
				continue;
			case 13:
				if (extensionPoints == null)
				{
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num = 3;
					}
					continue;
				}
				break;
			case 9:
				NotificationOk = true;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num = 0;
				}
				continue;
			case 15:
				SubProcessOk = true;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num = 1;
				}
				continue;
			case 2:
				UserDirectory = (string)QBZlLvOkzdNn1jrvmPdD(Et49lQOkwCFPd589bIpo(Assembly.GetExecutingAssembly().Location), XnbrmeOk45XMBsFym2QF(--1436248540 ^ 0x55995C50));
				num = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num = 9;
				}
				continue;
			case 4:
				ParentProcessUid = Guid.Empty;
				num = 7;
				continue;
			case 3:
			case 6:
				IsScriptDoc = true;
				num = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num = 12;
				}
				continue;
			case 7:
				ProcessId = 0L;
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num = 3;
				}
				continue;
			case 5:
				GenerationType = true;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num = 1;
				}
				continue;
			case 8:
				extensionPoints = ((ComponentManager)xsTFS1OkEe4N409lW6ws()).GetExtensionPoints<IDocumentationChapter>();
				num = 13;
				continue;
			default:
				ParentTableId = 0L;
				num = 4;
				continue;
			case 1:
			{
				ResponsibilityMatrOk = true;
				int num2 = 11;
				num = num2;
				continue;
			}
			case 14:
				return;
			case 10:
				break;
			}
			MetricsOk = extensionPoints.FirstOrDefault((IDocumentationChapter p) => _003C_003Ec.yITZnqvJOa2wQA7v3N7v(p) == DocumentationChapters.MetricAndInInndicator) != null;
			num = 4;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
			{
				num = 6;
			}
		}
	}

	public GenerationSettings Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}

	internal static void EU87PAOkhwbVdEjqpeI0()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object xsTFS1OkEe4N409lW6ws()
	{
		return ComponentManager.Current;
	}

	internal static object Et49lQOkwCFPd589bIpo(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object XnbrmeOk45XMBsFym2QF(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QBZlLvOkzdNn1jrvmPdD(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool QCVpqCOkSaUvRCTK3qCG()
	{
		return Fym7HWOkxXh7NH0Pu8aG == null;
	}

	internal static GenerationSettings fZcavyOk1yjM47l6thv3()
	{
		return Fym7HWOkxXh7NH0Pu8aG;
	}
}
