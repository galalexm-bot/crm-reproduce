using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[Shape(typeof(ScriptShape))]
[TaskType(20, "Script")]
[HintShape(typeof(ScriptHintShape))]
[WebDiagrammerShape(typeof(WebDiagrammerScriptShape))]
public class ScriptElement : TaskElement, IExceptionFlowSupported
{
	[Component(Order = 200)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem bCckKsHk7Nnt2tkliwH;

		public string Name => (string)OY89hKHmI9C9Db1YEB9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-478552651 ^ -478590273));

		public Guid GroupUid => BPMNGroups.Operations.UID;

		public Image Image => (Image)GqNiSqHAs45cUdEvPlv();

		public Type ElementType => n77CEvHp88L2duLxSAO(typeof(ScriptElement).TypeHandle);

		public string ElementIcon => (string)lsPCHxHGBOdF2wjhMo3(-193507406 ^ -193494470);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			xfIZSlHnhXjqDP9BeQD();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object OY89hKHmI9C9Db1YEB9(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool mhybAtHbGFNmsAEnkDC()
		{
			return bCckKsHk7Nnt2tkliwH == null;
		}

		internal static ToolboxItem FABBlhHU7L91jb8dm71()
		{
			return bCckKsHk7Nnt2tkliwH;
		}

		internal static object GqNiSqHAs45cUdEvPlv()
		{
			return Resources.symb_task_script;
		}

		internal static Type n77CEvHp88L2duLxSAO(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object lsPCHxHGBOdF2wjhMo3(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void xfIZSlHnhXjqDP9BeQD()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	[Component(Order = 200)]
	private class TaskElementHintExtension : HintDrawElementExtension<TaskElement>
	{
		internal static object EiQBA5Hy2ZC22QC1JF9;

		public override Type[] TargetElementTypes => new Type[1] { typeof(ScriptElement) };

		public TaskElementHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool RFyON6HO1l1KixhIvSX()
		{
			return EiQBA5Hy2ZC22QC1JF9 == null;
		}

		internal static TaskElementHintExtension vlZgY6H6V8IgsOa7rXq()
		{
			return (TaskElementHintExtension)EiQBA5Hy2ZC22QC1JF9;
		}
	}

	[Component(Order = 200)]
	private class IntermediateEventElementHintExtension : HintDrawElementExtension<IntermediateEventElement>
	{
		private static object q9YmnuHRIKr881WAjp5;

		public override Type[] TargetElementTypes => new Type[1] { typeof(ScriptElement) };

		public IntermediateEventElementHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			YHeMEAHWJgNy0ZI89mk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool H8Ea5cH09YRU7uD37Fo()
		{
			return q9YmnuHRIKr881WAjp5 == null;
		}

		internal static IntermediateEventElementHintExtension gWH7LrHB2gBtFp8Q1yr()
		{
			return (IntermediateEventElementHintExtension)q9YmnuHRIKr881WAjp5;
		}

		internal static void YHeMEAHWJgNy0ZI89mk()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	[Component(Order = 200)]
	private class StartEventElementHintExtension : HintDrawElementExtension<StartEventElement>
	{
		internal static object SKb065HH3qMn14DXgC1;

		public override Type[] TargetElementTypes => new Type[1] { z4p44NHuELRxBT4Nn4o(typeof(ScriptElement).TypeHandle) };

		public StartEventElementHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			pcnTt5HlRRjglh9erS6();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type z4p44NHuELRxBT4Nn4o(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool Eknl27HeeVIqRW20ltv()
		{
			return SKb065HH3qMn14DXgC1 == null;
		}

		internal static StartEventElementHintExtension ba86U0Hia5Iot06ihmo()
		{
			return (StartEventElementHintExtension)SKb065HH3qMn14DXgC1;
		}

		internal static void pcnTt5HlRRjglh9erS6()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	[Component(Order = 200)]
	private class GatewayElementHintExtension : HintDrawElementExtension<GatewayElement>
	{
		private static object reYP6PHfSWNLhocFkFG;

		public override Type[] TargetElementTypes => new Type[1] { Acx48aHr4255UpoEp8H(typeof(ScriptElement).TypeHandle) };

		public GatewayElementHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			g0HmvVH79pFoM0vmv0F();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type Acx48aHr4255UpoEp8H(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool TtDJCbHLxHP5ypUBOeb()
		{
			return reYP6PHfSWNLhocFkFG == null;
		}

		internal static GatewayElementHintExtension ve1a7FHJe9W0xhdFX55()
		{
			return (GatewayElementHintExtension)reYP6PHfSWNLhocFkFG;
		}

		internal static void g0HmvVH79pFoM0vmv0F()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	private static ScriptElement nYD7N6UGeJt1OOyX2eu;

	public override string DefaultName => (string)m75ZPmU6vZhV0S1wIBP(Ac76hSUOb5mooVKUmud(-711228462 ^ -711256872));

	public string ScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptName_003Ek__BackingField;
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
					_003CScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.ErrorCatch
	};

	protected override bool QueueExecutionTimeoutSupported => true;

	public override void ReplaceSignature(Dictionary<string, string> replaceNames)
	{
		ScriptName = CopyReplace(ScriptName, replaceNames);
	}

	protected override bool CanHandleExceptionByEscalation(Exception exception)
	{
		return exception is ScriptExecuteException;
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-658644315 ^ -658673173) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32F3F75 ^ 0x32FA717)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1635137248 ^ -1635165188) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411073168 ^ -1411109766)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1275462473 ^ -1275499799));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, wp, gs));
		string arg = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51F798FE ^ 0x51F70058) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C324F5C ^ 0x6C32D7F0)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-416187968 ^ -416161534);
		if (!string.IsNullOrEmpty(ScriptName))
		{
			arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3F8E27D0 ^ 0x3F8EB5B8), ScriptName), ScriptName);
		}
		stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x29336E79 ^ 0x2933F6B1), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x319750D3 ^ 0x3197C839)), arg));
		return stringBuilder.ToString();
	}

	public ScriptElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sAftA9URM1BGtfWI8xB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Ac76hSUOb5mooVKUmud(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object m75ZPmU6vZhV0S1wIBP(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool DToscBUn1kJOvpA7Cw3()
	{
		return nYD7N6UGeJt1OOyX2eu == null;
	}

	internal static ScriptElement tENBoJUy8cyZB8YjrCk()
	{
		return nYD7N6UGeJt1OOyX2eu;
	}

	internal static void sAftA9URM1BGtfWI8xB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
