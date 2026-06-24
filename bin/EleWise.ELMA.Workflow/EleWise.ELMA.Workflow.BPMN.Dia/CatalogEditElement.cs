using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Plugins;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Catalogs;

[Serializable]
[WebDiagrammerShape(typeof(WebDiagrammerOrangeRectangleElementShape))]
[Shape(typeof(DocumentGenerationShape))]
[HintShape(typeof(DocumentGenerationHintShape))]
public class CatalogEditElement : CommonEditEntityWorkflowElement
{
	private static CatalogEditElement rsbZDXZmyabVclSwRCPm;

	public override bool OutputCancel => true;

	public override bool ValidateContextVariables => false;

	protected override int MaxOutputFlowsCount => int.MaxValue;

	protected override SwimlaneType[] SupportedSwimlaneTypes => new SwimlaneType[3]
	{
		SwimlaneType.Static,
		SwimlaneType.Dynamic,
		SwimlaneType.DynamicScript
	};

	public CatalogEditElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VXm5ODZmbQvGvmB5Dig6();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				nKRl9wZm54VCWjWAt47h(this, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651D4BF7)));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IEntity ExtractFromInstance(IWorkflowInstance instance)
	{
		return (IEntity)yAIah7ZmgdIQVhQgqH6e(this, instance);
	}

	public void SetToInstance(IWorkflowInstance instance, IEntity val)
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
				D5Ib1VZmB55bjs93MI9C(this, instance, val);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_00ea, IL_0107
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				validator.Messages.Add((ProcessValidationMessage)Khrk0iZmnHY9FjGdZN4F(base.ValidationHelper, Y2hQAjZmDgYwVIvglDxY(P4uCoZZmdSUBM97GnBtw(-432000546 ^ -431843304), new object[1] { RpIS7vZmuXHa0SMYCW8x(this) })));
				num2 = 6;
				continue;
			case 5:
				if (Sl53njZmcxhiasXdUtYj(base.DocumentType, Guid.Empty))
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto IL_010d;
			case 1:
				return;
			case 2:
				return;
			case 4:
				if ((ClassMetadata)GRtUijZmXY494lOVDKTu(RZenhgZmPnRbEiMLgA2R(), base.DocumentType, false) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_010d;
			case 3:
				if (iMXKq0ZmHkRYUg64dyRc(base.DocumentVars) > 0)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 6:
				return;
			case 7:
				break;
				IL_010d:
				if (base.DocumentVars != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			validator.Messages.Add((ProcessValidationMessage)Khrk0iZmnHY9FjGdZN4F(base.ValidationHelper, idvlqlZm9cMOo9u2hXKE(EMrgYWZmLAd8bGlAFmGS(this) ? z73Ay3ZmfT2tNE9DBN7M(P4uCoZZmdSUBM97GnBtw(0x141C968 ^ 0x143631C)) : z73Ay3ZmfT2tNE9DBN7M(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716716872)), RpIS7vZmuXHa0SMYCW8x(this))));
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
			{
				num2 = 1;
			}
		}
	}

	public override void ReplaceSignature(Dictionary<string, string> replaceNames)
	{
		if (base.View == null)
		{
			return;
		}
		base.View.OnLoadScriptName = CopyReplace(base.View.OnLoadScriptName, replaceNames);
		ReplaceSignatureRecursive(base.View.Items, replaceNames);
		foreach (ConnectorSettingsExtension connectorSetting in base.ConnectorSettings)
		{
			connectorSetting.ScriptName = CopyReplace(connectorSetting.ScriptName, replaceNames);
		}
	}

	private void ReplaceSignatureRecursive(ListViewItem items, Dictionary<string, string> replaceNames)
	{
		foreach (PropertyViewItem item in items.OfType<PropertyViewItem>())
		{
			if (item.Attributes != null)
			{
				item.Attributes.OnViewLoadScriptName = CopyReplace(item.Attributes.OnViewLoadScriptName, replaceNames);
				item.Attributes.OnChangeScriptName = CopyReplace(item.Attributes.OnChangeScriptName, replaceNames);
				if (item.Items.Any())
				{
					ReplaceSignatureRecursive(item.Items, replaceNames);
				}
			}
		}
	}

	internal static void VXm5ODZmbQvGvmB5Dig6()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void nKRl9wZm54VCWjWAt47h(object P_0, object P_1)
	{
		((Element)P_0).Name = (string)P_1;
	}

	internal static bool IeJRPeZmmXkPcGBVojm8()
	{
		return rsbZDXZmyabVclSwRCPm == null;
	}

	internal static CatalogEditElement OW7pAcZmtvbUwaTYRoro()
	{
		return rsbZDXZmyabVclSwRCPm;
	}

	internal static object yAIah7ZmgdIQVhQgqH6e(object P_0, object P_1)
	{
		return ((ICommonEditEntityWorkflowElement)P_0).ExtractFromInstance((IWorkflowInstance)P_1);
	}

	internal static void D5Ib1VZmB55bjs93MI9C(object P_0, object P_1, object P_2)
	{
		((ICommonEditEntityWorkflowElement)P_0).SetToInstance((IWorkflowInstance)P_1, (IEntity)P_2);
	}

	internal static bool Sl53njZmcxhiasXdUtYj(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object RZenhgZmPnRbEiMLgA2R()
	{
		return MetadataServiceContext.Service;
	}

	internal static object GRtUijZmXY494lOVDKTu(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataService)P_0).GetMetadata(P_1, P_2);
	}

	internal static object P4uCoZZmdSUBM97GnBtw(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RpIS7vZmuXHa0SMYCW8x(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object Y2hQAjZmDgYwVIvglDxY(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object Khrk0iZmnHY9FjGdZN4F(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static int iMXKq0ZmHkRYUg64dyRc(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool EMrgYWZmLAd8bGlAFmGS(object P_0)
	{
		return ((CommonEditEntityWorkflowElement)P_0).MultipleMode;
	}

	internal static object z73Ay3ZmfT2tNE9DBN7M(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object idvlqlZm9cMOo9u2hXKE(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
