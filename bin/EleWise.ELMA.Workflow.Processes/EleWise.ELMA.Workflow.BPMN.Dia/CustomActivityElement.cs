using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.CustomActivity;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.CustomActivity;

[Serializable]
[Shape(typeof(CustomActivityShape))]
[HintShape(typeof(CustomActivityHintShape))]
public class CustomActivityElement : BPMNFlowElement, IExceptionFlowSupported, IReplaceContextVar, IElementWithPropertyMap
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem
	{
		internal static ToolboxItem YjVP6iHqmmB7R0gXnXU;

		public string Name => (string)D4heUuHDf6a3MqdpU3u(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747C4140 ^ 0x747C076A));

		public Guid GroupUid => CustomActivityGroups.CustomActivityPlugin.UID;

		public Image Image => null;

		public Type ElementType => T6AlVRHK7O6AExZTTGV(typeof(CustomActivityElement).TypeHandle);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object D4heUuHDf6a3MqdpU3u(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool VGHKY5HQRCqamstCYJK()
		{
			return YjVP6iHqmmB7R0gXnXU == null;
		}

		internal static ToolboxItem jRMrXoHVsriAi8w9OGd()
		{
			return YjVP6iHqmmB7R0gXnXU;
		}

		internal static Type T6AlVRHK7O6AExZTTGV(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	public string _defaultName;

	internal static CustomActivityElement ERgKombjOqmK2HjCqEa;

	public override string DefaultName => _defaultName;

	private Guid customActivityHeaderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CcustomActivityHeaderUid_003Ek__BackingField;
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
					_003CcustomActivityHeaderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
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

	public Guid CustomActivityHeaderUid
	{
		get
		{
			return customActivityHeaderUid;
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
					pWCmpnbbtnBwJfLGylY(this);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					customActivityHeaderUid = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public PropertyMap InputContextMap
	{
		[CompilerGenerated]
		get
		{
			return _003CInputContextMap_003Ek__BackingField;
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
					_003CInputContextMap_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
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

	public PropertyMap OutputContextMap
	{
		[CompilerGenerated]
		get
		{
			return _003COutputContextMap_003Ek__BackingField;
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
					_003COutputContextMap_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
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

	public PropertyMap[] UsingPropertyMap => new PropertyMap[2] { InputContextMap, OutputContextMap };

	protected override bool QueueExecutionTimeoutSupported => true;

	public override string ChapterName => (string)rLvjB4brdcB3qGwryyZ(sN72dbbmkF77yLA5D1Z(0x148F9F60 ^ 0x148FD886));

	public CustomActivityElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		int num = 5;
		CustomActivityHeaderDTO customActivityHeaderDTO = default(CustomActivityHeaderDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (customActivityHeaderDTO != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 != 0)
						{
							num2 = 6;
						}
					}
					else
					{
						validator.Messages.Add((ProcessValidationMessage)AdOy9wbpSqXCqGFdiuS(base.ValidationHelper, SR.T((string)sN72dbbmkF77yLA5D1Z(-769877317 ^ -769914163), O7dTY4bASmNJxA03nWj(this))));
						num2 = 2;
					}
					continue;
				case 3:
					validator.Messages.Add(base.ValidationHelper.CreateValidationError(SR.T((string)sN72dbbmkF77yLA5D1Z(-1843608060 ^ -1843639814), Name)));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					customActivityHeaderDTO = (CustomActivityHeaderDTO)hYnp46bUd4uwTGSEEWb(Locator.GetServiceNotNull<ICustomActivityHeaderDTOManager>(), customActivityHeaderUid);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				case 5:
					break;
				case 1:
					return;
				case 6:
					if (customActivityHeaderDTO.PublishedId != 0L)
					{
						return;
					}
					num2 = 3;
					continue;
				}
				break;
			}
			base.Validate(validator);
			num = 4;
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
			case 0:
				return;
			case 1:
				UpdateStyles();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				LmhZwBbGfNd0l1IL62f(this, oldShape, newShape);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void UpdateStyles()
	{
		//Discarded unreachable code: IL_00d1, IL_00e0
		int num = 6;
		int num2 = num;
		BPMNShape bPMNShape = default(BPMNShape);
		CustomActivityHeaderDTO customActivityHeaderDTO = default(CustomActivityHeaderDTO);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				bPMNShape = base.Shape as BPMNShape;
				num2 = 5;
				break;
			case 5:
				if (bPMNShape == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 4:
				customActivityHeaderDTO = (CustomActivityHeaderDTO)hYnp46bUd4uwTGSEEWb(Locator.GetServiceNotNull<ICustomActivityHeaderDTOManager>(), customActivityHeaderUid);
				num2 = 2;
				break;
			case 3:
				fgWc8gbODNWUdqPCEFP(bPMNShape, pWYpo6bnweXFGeHnAov(customActivityHeaderDTO), y4cqI9byOy8jMooHYBO(customActivityHeaderDTO));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (customActivityHeaderDTO != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 1:
				return;
			case 0:
				return;
			}
		}
	}

	protected override bool CanHandleExceptionByEscalation(Exception exception)
	{
		return exception is ScriptExecuteException;
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 4;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					KKvYKWbWBHwLSuRkDDu(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-732058802 ^ -732087980));
					num2 = 5;
					continue;
				case 5:
					return stringBuilder.ToString();
				case 2:
					KKvYKWbWBHwLSuRkDDu(stringBuilder, sN72dbbmkF77yLA5D1Z(-275868378 ^ -275905522));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					stringBuilder = new StringBuilder();
					num2 = 3;
					continue;
				case 1:
					break;
				case 3:
					stringBuilder.Append((string)yUoU9rbBS7tXnNw6WtE(new object[5]
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1803374629 ^ -1803403465),
						fgtrSXbRBjwwDGxx4K3(fc8oK4b60x7oxyfrGQh(O7dTY4bASmNJxA03nWj(this)), "") ? iKr2fUb0kBVTirJG5V6(this) : O7dTY4bASmNJxA03nWj(this),
						sN72dbbmkF77yLA5D1Z(0x3C126B81 ^ 0x3C12FB79),
						base.Uid,
						sN72dbbmkF77yLA5D1Z(0x27475F40 ^ 0x2747CE4E)
					}));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					KKvYKWbWBHwLSuRkDDu(stringBuilder, psPkPfbfADJ2ERdpfuY(z6jUdcbiQrUGIADLYxF(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365449958 ^ -1365478756), r9EpCLbeBMwKLl32q6S(iU0rHPbHQSKx6TgWcZg(this).ToString()), sN72dbbmkF77yLA5D1Z(-2125832759 ^ -2125804525)), subFolders ? "" : I9yooablAMFa0GYBkiZ(gJ7ca9buOmu8yF6NFVf(context).ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E58FEAF ^ 0x4E586CA9), "")));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			KKvYKWbWBHwLSuRkDDu(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179265198 ^ -179293346));
			num = 6;
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-481953825 ^ -481991241), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1683072034 ^ -1683043880), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C817E00 ^ 0x2C81EC74), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31D4A123 ^ 0x31D433BD)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411073168 ^ -1411110470) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x138E9AEB ^ 0x138ED199)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x138E9AEB ^ 0x138E0837) + element.Description);
		}
		CustomActivityHeaderDTO customActivityHeaderDTO = Locator.GetServiceNotNull<ICustomActivityHeaderDTOManager>().LoadOrNull(CustomActivityHeaderUid);
		ICustomActivity customActivity = CustomActivityManager.Instance.Load(customActivityHeaderDTO.PublishedId);
		if (customActivity != null)
		{
			CustomActivityContext(customActivity, stringBuilder, wp, subFolders);
			EntityMetadata entityMetadata;
			try
			{
				entityMetadata = customActivity.Header.Draft.Parameters;
			}
			catch
			{
				entityMetadata = null;
			}
			if (entityMetadata != null && ((ICollection<EntityPropertyMetadata>)entityMetadata.EntityProperties).Count > 0)
			{
				GetInputOutputAttributesTable(stringBuilder, wp, entityMetadata);
			}
			if (customActivity.ScriptModule != null && !string.IsNullOrWhiteSpace(customActivity.ScriptModule.SourceCode))
			{
				CustomActivityScript(customActivity, stringBuilder);
			}
		}
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append((string)msRnmKbJgxB37VmaCbc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1587393812 ^ -1587357696), Y0C7ZTbLTC2haiXyC9E(this)));
		stringBuilder.Append((string)sN72dbbmkF77yLA5D1Z(0x5B9A4287 ^ 0x5B9AD195));
		return stringBuilder.ToString();
	}

	private void CustomActivityContext(ICustomActivity activity, StringBuilder sb, IWorkflowProcess wp, bool subFolders)
	{
		//Discarded unreachable code: IL_0276, IL_0284, IL_0333, IL_0363, IL_0382, IL_0391, IL_03be
		int num = 8;
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
					sb.Append((string)sN72dbbmkF77yLA5D1Z(0x31D4A123 ^ 0x31D43219));
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					KKvYKWbWBHwLSuRkDDu(sb, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-437373675 ^ -437345963));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					KKvYKWbWBHwLSuRkDDu(sb, HTMLUtility.InsertRowToTable(new string[7]
					{
						(string)rLvjB4brdcB3qGwryyZ(sN72dbbmkF77yLA5D1Z(-1363339545 ^ -1363324487)),
						SR.T((string)sN72dbbmkF77yLA5D1Z(-1275462473 ^ -1275498713)),
						(string)rLvjB4brdcB3qGwryyZ(sN72dbbmkF77yLA5D1Z(0x1C21F94 ^ 0x1C28C3C)),
						(string)rLvjB4brdcB3qGwryyZ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-802458460 ^ -802429154)),
						SR.T((string)sN72dbbmkF77yLA5D1Z(0x77CE159B ^ 0x77CE8655)),
						(string)rLvjB4brdcB3qGwryyZ(sN72dbbmkF77yLA5D1Z(-193507406 ^ -193471564)),
						SR.T((string)sN72dbbmkF77yLA5D1Z(-1643416224 ^ -1643430382))
					}, isBold: true, null));
					num2 = 5;
					continue;
				case 5:
					break;
				case 0:
					return;
				case 7:
					sb.Append((string)sN72dbbmkF77yLA5D1Z(-182059571 ^ -182096253) + SR.T((string)sN72dbbmkF77yLA5D1Z(-1587393812 ^ -1587409868)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A4998B0 ^ 0x2A490A6C));
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					sb.Append((string)sN72dbbmkF77yLA5D1Z(0x48B7D69C ^ 0x48B742C4));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(0x32F3F75 ^ 0x32FAC2D));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					try
					{
						while (true)
						{
							IL_02bd:
							int num3;
							if (!xJc5qAbgHOKayTYC8Aw(enumerator))
							{
								num3 = 3;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
								{
									num3 = 1;
								}
								goto IL_0288;
							}
							goto IL_02aa;
							IL_02aa:
							current = enumerator.Current;
							num3 = 5;
							goto IL_0288;
							IL_0288:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								default:
									goto IL_02bd;
								case 2:
									GenerateEntityPropertyRow(current, subFolders, sb, (ProcessContext)jxmkrdb5DHX2D7vYX3g(wp));
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									if (wp == null)
									{
										num3 = 1;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 2;
								case 3:
									goto end_IL_02bd;
								}
								break;
							}
							goto IL_02aa;
							continue;
							end_IL_02bd:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 2;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa == 0)
							{
								num4 = 0;
							}
							goto IL_0367;
						}
						goto IL_039c;
						IL_039c:
						L3AQbkb1GdraabCuC3q(enumerator);
						num4 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 == 0)
						{
							num4 = 1;
						}
						goto IL_0367;
						IL_0367:
						switch (num4)
						{
						case 2:
							goto end_IL_0342;
						case 1:
							goto end_IL_0342;
						}
						goto IL_039c;
						end_IL_0342:;
					}
					goto case 4;
				}
				break;
			}
			enumerator = ((IEnumerable<EntityPropertyMetadata>)((EntityMetadata)ScZXSqb7FEts1DWIx2t(activity)).EntityProperties).GetEnumerator();
			num = 3;
		}
	}

	private void GenerateEntityPropertyRow(EntityPropertyMetadata property, bool subFolders, StringBuilder sb, ProcessContext context)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				text = (string)Pjtr6FbIdBtlmWwSVmP(property);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				KKvYKWbWBHwLSuRkDDu(sb, HTMLUtility.InsertRowToTable(new string[7]
				{
					(string)f3yl8cbZyGf09N7AXTF(sN72dbbmkF77yLA5D1Z(--1059430085 ^ 0x3F250AA9), gJ7ca9buOmu8yF6NFVf(property).ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-658644315 ^ -658673501), ""), property.DisplayName),
					text,
					(string)(JJne19bznFcB9HnWSVs(property) ? ProcessDocumentationGenerator.OK : sN72dbbmkF77yLA5D1Z(0x124714F0 ^ 0x1247806A)),
					(string)(YEwxRHUExwFwdHeHlE2(property) ? ProcessDocumentationGenerator.OK : sN72dbbmkF77yLA5D1Z(0x51F798FE ^ 0x51F70C64)),
					(string)(elZ1LdUCmLcoV2sPHKe(property) ? ProcessDocumentationGenerator.OK : sN72dbbmkF77yLA5D1Z(0x2B6686C0 ^ 0x2B66125A)),
					(string)(l4a716UX8ejlis2sMHe(property) ? ProcessDocumentationGenerator.OK : sN72dbbmkF77yLA5D1Z(-275868378 ^ -275906116)),
					(string)WIVy08UouI1OflqS2tC(property)
				}, isBold: false, new string[7]
				{
					"",
					"",
					(string)sN72dbbmkF77yLA5D1Z(0x2A4998B0 ^ 0x2A490C18),
					(string)sN72dbbmkF77yLA5D1Z(0x6C324F5C ^ 0x6C32DBF4),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-79921577 ^ -79893761),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179265198 ^ -179292678),
					""
				}));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void GetInputOutputAttributesTable(StringBuilder sb, IWorkflowProcess wp, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_00a0, IL_01f3, IL_0202, IL_0252, IL_025c, IL_02e8, IL_02f7, IL_0302, IL_03ac, IL_03bf, IL_03f5, IL_0404, IL_0446, IL_0450, IL_050a, IL_051d, IL_052c
		int num = 14;
		List<PropertyMapItem>.Enumerator enumerator = default(List<PropertyMapItem>.Enumerator);
		bool flag2 = default(bool);
		bool flag = default(bool);
		ProcessContext rightContext = default(ProcessContext);
		ProcessContext rightContext2 = default(ProcessContext);
		PropertyMapItem current2 = default(PropertyMapItem);
		PropertyMapItem current = default(PropertyMapItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				default:
					return;
				case 24:
					num4 = ((s7AQWGU3WJWVxOHMTC4(InputContextMap.Items) > 0) ? 1 : 0);
					goto IL_056d;
				case 20:
					enumerator = InputContextMap.Items.GetEnumerator();
					num2 = 23;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 != 0)
					{
						num2 = 10;
					}
					continue;
				case 6:
					if (OutputContextMap == null)
					{
						num2 = 25;
						continue;
					}
					goto case 10;
				case 15:
					return;
				case 16:
					sb.Append((string)sN72dbbmkF77yLA5D1Z(-478552651 ^ -478590783));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(0x604C9214 ^ 0x604C07A8));
					num2 = 11;
					continue;
				case 0:
					return;
				case 7:
					KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(0x688CC33F ^ 0x688C57EF));
					num2 = 26;
					continue;
				case 21:
					InputTable(SR.T((string)sN72dbbmkF77yLA5D1Z(-1969850261 ^ -1969820167)), sb);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					InputTable((string)rLvjB4brdcB3qGwryyZ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901337984 ^ -901367348)), sb);
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-182059571 ^ -182097727));
					num2 = 21;
					continue;
				case 4:
					enumerator = OutputContextMap.Items.GetEnumerator();
					num2 = 19;
					continue;
				case 1:
				case 12:
					if (flag2)
					{
						num2 = 8;
						continue;
					}
					goto case 11;
				case 10:
					num3 = ((s7AQWGU3WJWVxOHMTC4(OutputContextMap.Items) > 0) ? 1 : 0);
					goto IL_058a;
				case 17:
					if (flag)
					{
						num = 7;
						break;
					}
					goto case 2;
				case 2:
					if (!flag2)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 14:
					if (InputContextMap == null)
					{
						num2 = 13;
						continue;
					}
					goto case 24;
				case 5:
					rightContext = ProcessContextManager.Instance.Load(FHejoNUhK64VcblCbJT(InputContextMap));
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9bbeebf035a641e28535eada260bd583 == 0)
					{
						num2 = 20;
					}
					continue;
				case 19:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator.MoveNext())
							{
								num7 = 3;
								goto IL_0306;
							}
							goto IL_035d;
							IL_0306:
							while (true)
							{
								switch (num7)
								{
								case 1:
									break;
								case 2:
									Append(metadata, rightContext2, current2, wp, sb);
									num7 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 != 0)
									{
										num7 = 1;
									}
									continue;
								default:
									goto IL_035d;
								case 3:
									goto end_IL_0320;
								}
								break;
							}
							continue;
							IL_035d:
							current2 = enumerator.Current;
							num7 = 2;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
							{
								num7 = 2;
							}
							goto IL_0306;
							continue;
							end_IL_0320:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 18;
				case 11:
					KKvYKWbWBHwLSuRkDDu(sb, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C324F5C ^ 0x6C32DB04));
					num2 = 15;
					continue;
				case 3:
					rightContext2 = ((AbstractNHEntityManager<ProcessContext, long>)gFZHuFUxYOa0vNKpxuJ()).Load(FHejoNUhK64VcblCbJT(OutputContextMap));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
					{
						num2 = 4;
					}
					continue;
				case 23:
					try
					{
						while (true)
						{
							IL_0491:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 != 0)
								{
									num5 = 0;
								}
								goto IL_0454;
							}
							goto IL_046e;
							IL_046e:
							current = enumerator.Current;
							num5 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
							{
								num5 = 2;
							}
							goto IL_0454;
							IL_0454:
							while (true)
							{
								switch (num5)
								{
								case 3:
									goto IL_046e;
								case 1:
									goto IL_0491;
								case 2:
									Append(metadata, rightContext, current, wp, sb);
									num5 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
									{
										num5 = 1;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 16;
				case 26:
					if (!flag)
					{
						num = 12;
						break;
					}
					goto case 22;
				case 22:
					KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-1329217772 ^ -1329255912));
					num2 = 9;
					continue;
				case 13:
					num4 = 0;
					goto IL_056d;
				case 25:
					{
						num3 = 0;
						goto IL_058a;
					}
					IL_056d:
					flag = (byte)num4 != 0;
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
					{
						num2 = 3;
					}
					continue;
					IL_058a:
					flag2 = (byte)num3 != 0;
					num2 = 14;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
					{
						num2 = 17;
					}
					continue;
				}
				break;
			}
		}
	}

	private void InputTable(string name, StringBuilder sb)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				sb.Append((string)kp0OLrUF81UkTL2TRF4(new string[3]
				{
					SR.T((string)sN72dbbmkF77yLA5D1Z(-275868378 ^ -275852290)),
					SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2038986505 ^ -2039013671)),
					SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882678999 ^ -882641647))
				}, true, null));
				num2 = 3;
				break;
			case 3:
				return;
			case 2:
				KKvYKWbWBHwLSuRkDDu(sb, string.Format((string)sN72dbbmkF77yLA5D1Z(-588615921 ^ -588580139), name));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-1979431200 ^ -1979395298));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Append(EntityMetadata leftContext, EntityMetadata rightContext, PropertyMapItem item, IWorkflowProcess wp, StringBuilder sb)
	{
		//Discarded unreachable code: IL_00b3, IL_00c2, IL_00cd, IL_0187, IL_019a, IL_01a9, IL_01ff, IL_0253, IL_0285
		int num = 14;
		int num2 = num;
		object obj3 = default(object);
		object obj2 = default(object);
		int padding = default(int);
		List<ProcessContext> list = default(List<ProcessContext>);
		List<ProcessContext>.Enumerator enumerator = default(List<ProcessContext>.Enumerator);
		ProcessContext current = default(ProcessContext);
		while (true)
		{
			object obj4;
			object obj;
			switch (num2)
			{
			default:
				obj4 = B3lNxRUtgBBY5SZ42Ob(item);
				if (obj4 == null)
				{
					num2 = 12;
					continue;
				}
				break;
			case 16:
				if (obj3 != null)
				{
					num2 = 6;
					continue;
				}
				goto case 7;
			case 12:
				if (obj2 == null)
				{
					num2 = 4;
					continue;
				}
				obj4 = ProcessDocumentationHelper.GetEntityProperty((IEnumerable<EntityPropertyMetadata>)rightContext.EntityProperties, (IEnumerable<TablePartMetadata>)rightContext.EntityTableParts, mV7AI2UsUSpuQnJsqTY(item), ref padding);
				break;
			case 3:
				ProcessDocumentationHelper.GetParentsContext(wp, list, thisContext: false);
				num2 = 9;
				continue;
			case 11:
				try
				{
					while (true)
					{
						IL_0135:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a != 0)
							{
								num3 = 1;
							}
							goto IL_00d1;
						}
						goto IL_0112;
						IL_0112:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
						{
							num3 = 2;
						}
						goto IL_00d1;
						IL_00d1:
						while (true)
						{
							switch (num3)
							{
							case 2:
								obj3 = ProcessDocumentationHelper.GetEntityProperty((IEnumerable<EntityPropertyMetadata>)current.EntityProperties, (IEnumerable<TablePartMetadata>)current.EntityTableParts, mV7AI2UsUSpuQnJsqTY(item), ref padding);
								num3 = 3;
								continue;
							case 3:
								goto IL_0135;
							case 1:
								goto end_IL_0135;
							}
							break;
						}
						goto IL_0112;
						continue;
						end_IL_0135:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 7:
				list = new List<ProcessContext>();
				num2 = 3;
				continue;
			case 14:
				padding = 0;
				num2 = 13;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
				{
					num2 = 8;
				}
				continue;
			case 10:
				d5u63tU2766YtMoFFjJ(obj2, obj3, sb, 0, 0);
				num2 = 5;
				continue;
			case 4:
				obj4 = null;
				break;
			case 13:
				obj = vEgpOJU8eshiWhOJ2r3(item);
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_02a8;
			case 6:
			case 8:
			case 15:
				if (obj2 != null)
				{
					num2 = 10;
					continue;
				}
				return;
			case 5:
				return;
			case 2:
				if (obj2 == null)
				{
					num2 = 8;
					continue;
				}
				goto case 16;
			case 9:
				enumerator = list.GetEnumerator();
				num2 = 9;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 == 0)
				{
					num2 = 11;
				}
				continue;
			case 1:
				{
					obj = ProcessDocumentationHelper.GetEntityProperty((IEnumerable<EntityPropertyMetadata>)leftContext.EntityProperties, (IEnumerable<TablePartMetadata>)leftContext.EntityTableParts, qVLPeiUwkdyoB31pFq7(item), ref padding);
					goto IL_02a8;
				}
				IL_02a8:
				obj2 = obj;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			obj3 = obj4;
			num2 = 2;
		}
	}

	private void CustomActivityScript(ICustomActivity activity, StringBuilder sb)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				KKvYKWbWBHwLSuRkDDu(sb, activity.ScriptModule.SourceCode);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
				{
					num2 = 4;
				}
				break;
			default:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-1737696342 ^ -1737732672));
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
				{
					num2 = 9;
				}
				break;
			case 7:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(0xE6AF0C2 ^ 0xE6A6726));
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(0x1CF99A4A ^ 0x1CF90C14));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-769877317 ^ -769913527));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-275868378 ^ -275903180));
				num2 = 6;
				break;
			case 5:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-1967154668 ^ -1967190774));
				num2 = 7;
				break;
			case 6:
				return;
			case 2:
				KKvYKWbWBHwLSuRkDDu(sb, sN72dbbmkF77yLA5D1Z(-1015538293 ^ -1015511671));
				num2 = 8;
				break;
			case 9:
				sb.Append((string)z6jUdcbiQrUGIADLYxF(sN72dbbmkF77yLA5D1Z(--286570904 ^ 0x11142B52), SR.T((string)sN72dbbmkF77yLA5D1Z(0xB863F17 ^ 0xB86A81D)), sN72dbbmkF77yLA5D1Z(0x234241C0 ^ 0x2342D31C)));
				num2 = 5;
				break;
			}
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
		base.ReplaceContextVar(replaceContextVar);
		OutputContextMap?.ReplaceContextVars(replaceContextVar);
		InputContextMap?.ReplaceContextVars(replaceContextVar);
	}

	internal static bool ywvS2mbSLAFbNZvJFiU()
	{
		return ERgKombjOqmK2HjCqEa == null;
	}

	internal static CustomActivityElement XrcxRObkXfDt9l9vB7f()
	{
		return ERgKombjOqmK2HjCqEa;
	}

	internal static void pWCmpnbbtnBwJfLGylY(object P_0)
	{
		((CustomActivityElement)P_0).UpdateStyles();
	}

	internal static object hYnp46bUd4uwTGSEEWb(object P_0, Guid uid)
	{
		return ((ICustomActivityHeaderDTOManager)P_0).LoadOrNull(uid);
	}

	internal static object sN72dbbmkF77yLA5D1Z(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object O7dTY4bASmNJxA03nWj(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object AdOy9wbpSqXCqGFdiuS(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static void LmhZwBbGfNd0l1IL62f(object P_0, object P_1, object P_2)
	{
		((BPMNFlowElement)P_0).OnShapeChanged((NShape)P_1, (NShape)P_2);
	}

	internal static Color pWYpo6bnweXFGeHnAov(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).ColorSecondC;
	}

	internal static Color y4cqI9byOy8jMooHYBO(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).ColorFirstC;
	}

	internal static void fgWc8gbODNWUdqPCEFP(object P_0, Color P_1, Color P_2)
	{
		((BPMNShape)P_0).UpdateStyle(P_1, P_2);
	}

	internal static object fc8oK4b60x7oxyfrGQh(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool fgtrSXbRBjwwDGxx4K3(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object iKr2fUb0kBVTirJG5V6(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static object yUoU9rbBS7tXnNw6WtE(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object KKvYKWbWBHwLSuRkDDu(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static Guid iU0rHPbHQSKx6TgWcZg(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object r9EpCLbeBMwKLl32q6S(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object z6jUdcbiQrUGIADLYxF(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid gJ7ca9buOmu8yF6NFVf(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object I9yooablAMFa0GYBkiZ(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object psPkPfbfADJ2ERdpfuY(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Y0C7ZTbLTC2haiXyC9E(object P_0)
	{
		return ((BPMNFlowElement)P_0).GetConnectorsLink();
	}

	internal static object msRnmKbJgxB37VmaCbc(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object rLvjB4brdcB3qGwryyZ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object ScZXSqb7FEts1DWIx2t(object P_0)
	{
		return ((ICustomActivity)P_0).Parameters;
	}

	internal static object jxmkrdb5DHX2D7vYX3g(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static bool xJc5qAbgHOKayTYC8Aw(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void L3AQbkb1GdraabCuC3q(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Pjtr6FbIdBtlmWwSVmP(object P_0)
	{
		return ProcessDocumentationHelper.GetPropertyType((IPropertyMetadata)P_0);
	}

	internal static object f3yl8cbZyGf09N7AXTF(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool JJne19bznFcB9HnWSVs(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).Input;
	}

	internal static bool YEwxRHUExwFwdHeHlE2(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).Output;
	}

	internal static bool elZ1LdUCmLcoV2sPHKe(object P_0)
	{
		return ((PropertyMetadata)P_0).Required;
	}

	internal static bool l4a716UX8ejlis2sMHe(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static object WIVy08UouI1OflqS2tC(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static int s7AQWGU3WJWVxOHMTC4(object P_0)
	{
		return ((List<PropertyMapItem>)P_0).Count;
	}

	internal static Guid FHejoNUhK64VcblCbJT(object P_0)
	{
		return ((PropertyMap)P_0).RightClassUid;
	}

	internal static object gFZHuFUxYOa0vNKpxuJ()
	{
		return ProcessContextManager.Instance;
	}

	internal static object kp0OLrUF81UkTL2TRF4(object P_0, bool P_1, object P_2)
	{
		return HTMLUtility.InsertRowToTable((string[])P_0, P_1, (string[])P_2);
	}

	internal static object vEgpOJU8eshiWhOJ2r3(object P_0)
	{
		return ((PropertyMapItem)P_0).LeftValue;
	}

	internal static Guid qVLPeiUwkdyoB31pFq7(object P_0)
	{
		return ((PropertyMapItem)P_0).LeftPropertyUid;
	}

	internal static object B3lNxRUtgBBY5SZ42Ob(object P_0)
	{
		return ((PropertyMapItem)P_0).RightValue;
	}

	internal static Guid mV7AI2UsUSpuQnJsqTY(object P_0)
	{
		return ((PropertyMapItem)P_0).RightPropertyUid;
	}

	internal static void d5u63tU2766YtMoFFjJ(object P_0, object P_1, object P_2, int P_3, int P_4)
	{
		ProcessDocumentationHelper.AppendPropertyRow(P_0, P_1, (StringBuilder)P_2, P_3, P_4);
	}
}
