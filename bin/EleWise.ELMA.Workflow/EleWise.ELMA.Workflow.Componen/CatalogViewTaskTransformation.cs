using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Catalogs;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ViewItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class CatalogViewTaskTransformation : BaseFormViewTransformation
{
	private static CatalogViewTaskTransformation E3EOkcOsYZmWLwcqWJ05;

	public override bool AcceptableElement(IElementWithView element)
	{
		return element is CatalogEditElement;
	}

	public override FormView GetFormView(IElementWithView element, IWorkflowTaskBase task)
	{
		return (FormView)Du3xjWOstGsLtnZh4Ba7(element, YhduA6Os0bAyFESYeyY5(ByedKQOsliBNJ5EoxVRP(VYJca4OsJMlcOLH5TFjJ(task))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028827113), XcMwaMOsmoK19UUUY9HY(nOOQE0OsyMx6YFUL3x0S(0x350C0E8 ^ 0x35158E6)));
	}

	internal static FormView GetFormView(IElementWithView element, WorkflowInstanceContext context, string formViewItemName, string formViewItemDisplayName)
	{
		//Discarded unreachable code: IL_021f, IL_022e, IL_023e, IL_024d
		int num = 17;
		ClassMetadata classMetadata = default(ClassMetadata);
		ColumnViewItem columnViewItem = default(ColumnViewItem);
		ContextDefaultContainerViewItem item = default(ContextDefaultContainerViewItem);
		FormViewItem formViewItem = default(FormViewItem);
		FormView formView2 = default(FormView);
		ColumnsLayoutViewItem columnsLayoutViewItem = default(ColumnsLayoutViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				FormView formView;
				switch (num2)
				{
				case 6:
					classMetadata = GAtQ9vOs5O6Xbc3SjVe1(context.GetType(), true, true) as ClassMetadata;
					num = 5;
					break;
				case 12:
					columnViewItem.Items.Add(item);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					item = new ContextDefaultContainerViewItem();
					num2 = 2;
					continue;
				case 13:
				case 15:
					return (FormView)WSGedhOsX52LaDShUL0Q(formViewItem, ContextDefaultContainerViewItem.Transformation(classMetadata, element, formViewItem, null));
				case 11:
				case 14:
					if (toBqJLOsctJ6DPgeetLP(formView2.OnLoadScriptName))
					{
						num2 = 15;
						continue;
					}
					goto case 10;
				case 7:
					nSDuc2Osb6fByBJoDZCy(columnViewItem, new Guid((string)nOOQE0OsyMx6YFUL3x0S(-935313063 ^ -935208575)));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					((EventedList<ViewItem>)eJfp1AOsB6EumRkigKMc(columnsLayoutViewItem)).Add((ViewItem)columnViewItem);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					((EventedList<ViewItem>)eJfp1AOsB6EumRkigKMc(formViewItem)).Add((ViewItem)columnsLayoutViewItem);
					num2 = 14;
					continue;
				case 18:
					nSDuc2Osb6fByBJoDZCy(columnsLayoutViewItem, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F52D374)));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					columnsLayoutViewItem = new ColumnsLayoutViewItem();
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					if (!((IEnumerable<ViewItem>)eJfp1AOsB6EumRkigKMc(formView2)).Any())
					{
						num = 11;
						break;
					}
					goto case 9;
				case 10:
					haGisCOsPVRYsV9mR2yh(formViewItem, formView2.OnLoadScriptName);
					num2 = 13;
					continue;
				case 5:
					if (classMetadata == null)
					{
						return formView2;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					columnViewItem = new ColumnViewItem();
					num2 = 7;
					continue;
				default:
					formViewItem = (FormViewItem)wXJrAYOsg8XUjLCMhG7g(new FormViewItemBuilder<IWorkflowTask>(ViewType.Edit).Uid(new Guid((string)nOOQE0OsyMx6YFUL3x0S(-1430645277 ^ -1430549137))).Name(formViewItemName).DisplayName(formViewItemDisplayName));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 8;
					}
					continue;
				case 17:
					formView = element.View;
					if (formView != null)
					{
						goto IL_030e;
					}
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 16;
					}
					continue;
				case 16:
					{
						formView = new FormView();
						nSDuc2Osb6fByBJoDZCy(formView, new Guid((string)nOOQE0OsyMx6YFUL3x0S(-667465279 ^ -667496063)));
						goto IL_030e;
					}
					IL_030e:
					formView2 = formView;
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public CatalogViewTaskTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HIJjAHOsdQB9QPxmfjFe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool aulvuMOs8t469H2DQbRu()
	{
		return E3EOkcOsYZmWLwcqWJ05 == null;
	}

	internal static CatalogViewTaskTransformation gjsKKiOssYMw0NblW9wH()
	{
		return E3EOkcOsYZmWLwcqWJ05;
	}

	internal static object VYJca4OsJMlcOLH5TFjJ(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object ByedKQOsliBNJ5EoxVRP(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object YhduA6Os0bAyFESYeyY5(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object nOOQE0OsyMx6YFUL3x0S(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XcMwaMOsmoK19UUUY9HY(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object Du3xjWOstGsLtnZh4Ba7(object P_0, object P_1, object P_2, object P_3)
	{
		return GetFormView((IElementWithView)P_0, (WorkflowInstanceContext)P_1, (string)P_2, (string)P_3);
	}

	internal static void nSDuc2Osb6fByBJoDZCy(object P_0, Guid P_1)
	{
		((ViewItem)P_0).Uid = P_1;
	}

	internal static object GAtQ9vOs5O6Xbc3SjVe1(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object wXJrAYOsg8XUjLCMhG7g(object P_0)
	{
		return ((FormViewItemBuilder<IWorkflowTask>)P_0).FormView;
	}

	internal static object eJfp1AOsB6EumRkigKMc(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static bool toBqJLOsctJ6DPgeetLP(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static void haGisCOsPVRYsV9mR2yh(object P_0, object P_1)
	{
		((FormView)P_0).OnLoadScriptName = (string)P_1;
	}

	internal static object WSGedhOsX52LaDShUL0Q(object P_0, object P_1)
	{
		return ((FormViewItem)P_0).Transformate((ViewItemTransformation)P_1);
	}

	internal static void HIJjAHOsdQB9QPxmfjFe()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
