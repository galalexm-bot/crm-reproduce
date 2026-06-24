using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;
using Nevron.Dom;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Diagrams;

[Serializable]
[XmlExport]
[XmlRoot("OrganizationDiagram")]
public class OrganizationDiagram : Diagram
{
	public const string ClipboardFormatNameConst = "OrganizationDiagramClipboardData";

	private static OrganizationDiagram kgxPZWmGf3Qong2iX7E;

	public override string ClipboardFormatName => (string)UYuPMxmDA8ao1M42q6X(0x61EAE816 ^ 0x61EAA49C);

	public bool AllowNodeRemoving
	{
		[CompilerGenerated]
		get
		{
			return _003CAllowNodeRemoving_003Ek__BackingField;
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
					_003CAllowNodeRemoving_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool NeedNodeRemoving
	{
		[CompilerGenerated]
		get
		{
			return _003CNeedNodeRemoving_003Ek__BackingField;
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
					_003CNeedNodeRemoving_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
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

	public event EventHandler ElementRemoving
	{
		[CompilerGenerated]
		add
		{
			int num = 4;
			int num2 = num;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if ((object)eventHandler2 == eventHandler)
					{
						num2 = 2;
						break;
					}
					goto case 3;
				case 4:
					eventHandler2 = this.ElementRemoving;
					num2 = 3;
					break;
				case 5:
					value2 = (EventHandler)Delegate.Combine(eventHandler, value);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					eventHandler = eventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 5;
					}
					break;
				case 2:
					return;
				default:
					eventHandler2 = Interlocked.CompareExchange(ref this.ElementRemoving, value2, eventHandler);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler = default(EventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						eventHandler2 = this.ElementRemoving;
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						value2 = (EventHandler)aMb7UYmMYGyyowSRN24(eventHandler, value);
						num2 = 4;
						continue;
					case 3:
						if ((object)eventHandler2 == eventHandler)
						{
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 0:
						return;
					case 4:
						eventHandler2 = Interlocked.CompareExchange(ref this.ElementRemoving, value2, eventHandler);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
						{
							num2 = 3;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				eventHandler = eventHandler2;
				num = 5;
			}
		}
	}

	public OrganizationDiagram()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yLTBkkmE1NZvEGVOepD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected OrganizationDiagram(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		yLTBkkmE1NZvEGVOepD();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected new void InvokeElementInserted(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_006e, IL_007d
		int num = 4;
		EventHandler elementRemoving = default(EventHandler);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (elementRemoving == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					return;
				case 2:
					return;
				case 4:
					elementRemoving = this.ElementRemoving;
					num2 = 3;
					continue;
				}
				break;
			}
			QaTMncmsxlWfGBb6aQ4(elementRemoving, sender, e);
			num = 2;
		}
	}

	protected override void NodeRemoving(NChildNodeCancelEventArgs args)
	{
		int num = 5;
		int num2 = num;
		Element element = default(Element);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!NeedNodeRemoving)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 1:
				InvokeElementInserted(element, EventArgs.Empty);
				num2 = 3;
				break;
			case 2:
				return;
			default:
				AllowNodeRemoving = false;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
			{
				ExtractShapeAndElement(args.Child, out var _, out element);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
				{
					num2 = 4;
				}
				break;
			}
			case 3:
				NnVBgymY1bPVMZnK8es(args, true);
				num2 = 2;
				break;
			}
		}
	}

	internal static void yLTBkkmE1NZvEGVOepD()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool f53RXymFK05slUHEa0f()
	{
		return kgxPZWmGf3Qong2iX7E == null;
	}

	internal static OrganizationDiagram uCaIq4m0Hvnwh29QEWQ()
	{
		return kgxPZWmGf3Qong2iX7E;
	}

	internal static object UYuPMxmDA8ao1M42q6X(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aMb7UYmMYGyyowSRN24(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void QaTMncmsxlWfGBb6aQ4(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (EventArgs)P_2);
	}

	internal static void NnVBgymY1bPVMZnK8es(object P_0, bool P_1)
	{
		((CancelEventArgs)P_0).Cancel = P_1;
	}
}
