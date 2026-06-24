using System;
using System.Activities;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Diagrams.Activities;

[Service(EnableInterceptors = false, Scope = ServiceScope.Transient)]
public abstract class WorkflowActivity : NativeActivity<ActivityExecuteResult>, IWorkflowActivityImpl
{
	internal static WorkflowActivity aJTFFyEc3RTtCYnQf2t;

	public IWorkflowRuntimeService WorkflowRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowRuntimeService_003Ek__BackingField;
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
					_003CWorkflowRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[NotNull]
	public IEntityActionHandler ActionHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CActionHandler_003Ek__BackingField;
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
					_003CActionHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Element Element
	{
		[CompilerGenerated]
		get
		{
			return _003CElement_003Ek__BackingField;
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
					_003CElement_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
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

	public WorkflowDiagram Diagram
	{
		[CompilerGenerated]
		get
		{
			return _003CDiagram_003Ek__BackingField;
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
					_003CDiagram_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual IWorkflowTrackingService GetTrackingService(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				V93e3NEuiAtpyMJqY1j(WorkflowRuntimeService, RgD67VEdxpVQDkXId76(-2125897096 ^ -2125912574));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return context.GetExtension<IWorkflowTrackingService>() ?? throw new ServiceNotFoundException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050331266));
			}
		}
	}

	protected virtual IWorkflowInstance GetInstance(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				V93e3NEuiAtpyMJqY1j(WorkflowRuntimeService, RgD67VEdxpVQDkXId76(-801808857 ^ -801826211));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (IWorkflowInstance)cwRpb8EDNua1NbFZOrO(context.GetExtension<IWorkflowExecutingContext>() ?? throw new ServiceNotFoundException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62973433)));
			}
		}
	}

	protected PropertyMetadata GetProperty(IWorkflowInstance instance, Guid uid)
	{
		int num = 2;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return ((EntityMetadata)MetadataLoader.LoadMetadata(((WorkflowInstanceContext)IdcTfwEHJ3dwucDLTJQ(instance)).CastAsRealType().GetType())).Properties.FirstOrDefault(_003C_003Ec__DisplayClass18_._003CGetProperty_003Eb__0);
				case 1:
					_003C_003Ec__DisplayClass18_.uid = uid;
					num2 = 4;
					continue;
				case 4:
					break;
				case 3:
					Contract.ArgumentNotNull(IdcTfwEHJ3dwucDLTJQ(instance), (string)RgD67VEdxpVQDkXId76(0x7381F16B ^ 0x7380AF0D));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			HDZp5jEnx98a4rncJfx(instance, RgD67VEdxpVQDkXId76(0x595C500A ^ 0x595C090C));
			num = 3;
		}
	}

	protected void ContinueOnConnector(NativeActivityContext context, Guid connectorUid)
	{
		int num = 6;
		int num2 = num;
		Connector connector = default(Connector);
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				vUHnQYEL0gdJgLpMVou(Element.OutputConnectors, RgD67VEdxpVQDkXId76(0x5DB28AD2 ^ 0x5DB3D44E));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				connector = Element.OutputConnectors.FirstOrDefault(_003C_003Ec__DisplayClass19_._003CContinueOnConnector_003Eb__0);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num2 = 4;
				}
				break;
			default:
				vUHnQYEL0gdJgLpMVou(Element, RgD67VEdxpVQDkXId76(-1600060848 ^ -1600103206));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				ContinueOnConnector(context, connector);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 5:
				_003C_003Ec__DisplayClass19_.connectorUid = connectorUid;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void ContinueOnConnector(NativeActivityContext context, Connector connector)
	{
		//Discarded unreachable code: IL_0105, IL_014f, IL_015e
		int num = 1;
		Guid nextElementUid = default(Guid);
		while (true)
		{
			int num2 = num;
			Guid guid;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (SOYvNJE918LuITnTdmX(connector) != null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 2;
				case 5:
					if (connector != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 1:
					vUHnQYEL0gdJgLpMVou(Element, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4942BD6E));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					Nxrq4dEfm2Pgo3M0aGG(this, context, connector);
					num2 = 5;
					continue;
				case 7:
					base.Result.Set(context, new ActivityExecuteResult(nextElementUid));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					return;
				case 2:
					guid = Guid.Empty;
					break;
				default:
					vUHnQYEL0gdJgLpMVou(Element.OutputConnectors, RgD67VEdxpVQDkXId76(-1600060848 ^ -1600103220));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					guid = EjyWqgEWIslaskNcgJJ(SOYvNJE918LuITnTdmX(connector));
					break;
				}
				break;
			}
			nextElementUid = guid;
			num = 7;
		}
	}

	protected void ContinueOnDefaultConnector(NativeActivityContext context)
	{
		int num = 6;
		Connector connector = default(Connector);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (connector == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 3:
					return;
				case 5:
					break;
				case 1:
					if (connector == null)
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				case 2:
					O4vMRgEjY1CZI48c2Dg(this, context, connector);
					num2 = 3;
					continue;
				case 6:
					vUHnQYEL0gdJgLpMVou(Element, RgD67VEdxpVQDkXId76(-1600060848 ^ -1600103206));
					num2 = 5;
					continue;
				case 7:
					connector = Element.OutputConnectors.Where((Connector c) => c is FlowConnectorElement).FirstOrDefault((Connector c) => _003C_003Ec.TJAmsdZNwBnBYr3A9vId((FlowConnectorElement)c));
					num2 = 8;
					continue;
				default:
					connector = Element.OutputConnectors.FirstOrDefault(delegate(Connector c)
					{
						//Discarded unreachable code: IL_0063, IL_0072
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (!(c is FlowConnectorElement))
								{
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return _003C_003Ec.vJ58JPZN4d1ekgljoJOp((FlowConnectorElement)c) == EventTrigger.None;
							default:
								return false;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					connector = Element.OutputConnectors.FirstOrDefault((Connector c) => c is FlowConnectorElement);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			Contract.NotNull(Element.OutputConnectors, (string)RgD67VEdxpVQDkXId76(0x628167BE ^ 0x62803922));
			num = 7;
		}
	}

	protected virtual void TrackConnector(NativeActivityContext context, Connector connector)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				if (connector == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return;
			}
			aSTDIDE6kM98jsCfOBV(yV3ce8ERtGQSj3opLQO(this, context), EjyWqgEWIslaskNcgJJ(connector), true);
			num2 = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
			{
				num2 = 1;
			}
		}
	}

	protected virtual void CreateActivityBookmark(NativeActivityContext context, string bookmarkId, BookmarkCallback resumeCallback)
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
				KqWkIlEqQo1WTj1d8Kp(context, bookmarkId, resumeCallback);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void RemoveAllActivityBookmarks(NativeActivityContext context)
	{
		ORnLmcE3PgWfAxIwMGp(context);
	}

	void IWorkflowActivityImpl.ContinueOnDefaultConnector(NativeActivityContext context)
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
				ContinueOnDefaultConnector(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void IWorkflowActivityImpl.ContinueOnConnector(NativeActivityContext context, Connector connector)
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
				O4vMRgEjY1CZI48c2Dg(this, context, connector);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected WorkflowActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qkIUO4ETLtJGMfBHX5p();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool G3JUEIEPjKcPTlkanXg()
	{
		return aJTFFyEc3RTtCYnQf2t == null;
	}

	internal static WorkflowActivity xOnZaJEXOdZ86JgraSn()
	{
		return aJTFFyEc3RTtCYnQf2t;
	}

	internal static object RgD67VEdxpVQDkXId76(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void V93e3NEuiAtpyMJqY1j(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object cwRpb8EDNua1NbFZOrO(object P_0)
	{
		return ((IWorkflowExecutingContext)P_0).Instance;
	}

	internal static void HDZp5jEnx98a4rncJfx(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object IdcTfwEHJ3dwucDLTJQ(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static void vUHnQYEL0gdJgLpMVou(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static void Nxrq4dEfm2Pgo3M0aGG(object P_0, object P_1, object P_2)
	{
		((WorkflowActivity)P_0).TrackConnector((NativeActivityContext)P_1, (Connector)P_2);
	}

	internal static object SOYvNJE918LuITnTdmX(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static Guid EjyWqgEWIslaskNcgJJ(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void O4vMRgEjY1CZI48c2Dg(object P_0, object P_1, object P_2)
	{
		((WorkflowActivity)P_0).ContinueOnConnector((NativeActivityContext)P_1, (Connector)P_2);
	}

	internal static object yV3ce8ERtGQSj3opLQO(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetTrackingService((NativeActivityContext)P_1);
	}

	internal static void aSTDIDE6kM98jsCfOBV(object P_0, Guid elementUid, bool executed)
	{
		((IWorkflowTrackingService)P_0).Add(elementUid, executed);
	}

	internal static object KqWkIlEqQo1WTj1d8Kp(object P_0, object P_1, object P_2)
	{
		return ((NativeActivityContext)P_0).CreateBookmark((string)P_1, (BookmarkCallback)P_2);
	}

	internal static void ORnLmcE3PgWfAxIwMGp(object P_0)
	{
		((NativeActivityContext)P_0).RemoveAllBookmarks();
	}

	internal static void qkIUO4ETLtJGMfBHX5p()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
public abstract class WorkflowActivity<TElement> : WorkflowActivity where TElement : Element
{
	internal static object ownm81EQO3q1yG5DBpG;

	public new TElement Element
	{
		get
		{
			return (TElement)base.Element;
		}
		set
		{
			base.Element = value;
		}
	}

	protected WorkflowActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UyDssgEpQW429Z34Gk1()
	{
		return ownm81EQO3q1yG5DBpG == null;
	}

	internal static object JkQ59PECURoVqiRAjCs()
	{
		return ownm81EQO3q1yG5DBpG;
	}
}
