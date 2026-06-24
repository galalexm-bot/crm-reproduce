using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;

[Serializable]
[Shape(typeof(ArtifactConnectorShape))]
public class ArtifactConnectorElement : Connector
{
	private EventTrigger trigger;

	private bool isDefault;

	internal static ArtifactConnectorElement JiVwggZy3vdlU3aXjaVg;

	public bool IsDefault
	{
		get
		{
			return isDefault;
		}
		set
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
					JPt3plZyplDqGYkbpEaE(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					isDefault = value;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
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

	public EventTrigger Trigger
	{
		get
		{
			return trigger;
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
					JPt3plZyplDqGYkbpEaE(this);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 1:
					trigger = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IntermediateTimerSettings TimerSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CTimerSettings_003Ek__BackingField;
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
					_003CTimerSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override void OnShapeChanged(NShape oldShape, NShape newShape)
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
				JPt3plZyplDqGYkbpEaE(this);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				KJEHaMZyCR8Cqx31a2vj(this, oldShape, newShape);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected virtual void UpdateDecorators()
	{
		int num = 3;
		IDecoratableShape decoratableShape = default(IDecoratableShape);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (decoratableShape != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 1:
					return;
				case 3:
					break;
				default:
					decoratableShape.UpdateDecorators(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			decoratableShape = s4ibJtZyMCBo6kEYtcwW(this) as IDecoratableShape;
			num = 2;
		}
	}

	public ArtifactConnectorElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jQyZwPZykVCcV7EKR1dw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void JPt3plZyplDqGYkbpEaE(object P_0)
	{
		((ArtifactConnectorElement)P_0).UpdateDecorators();
	}

	internal static bool WoCRMxZyTAcFqj62Kec1()
	{
		return JiVwggZy3vdlU3aXjaVg == null;
	}

	internal static ArtifactConnectorElement I9dkPcZyQViNXIKUHOPI()
	{
		return JiVwggZy3vdlU3aXjaVg;
	}

	internal static void KJEHaMZyCR8Cqx31a2vj(object P_0, object P_1, object P_2)
	{
		((Element)P_0).OnShapeChanged((NShape)P_1, (NShape)P_2);
	}

	internal static object s4ibJtZyMCBo6kEYtcwW(object P_0)
	{
		return ((Element)P_0).Shape;
	}

	internal static void jQyZwPZykVCcV7EKR1dw()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
