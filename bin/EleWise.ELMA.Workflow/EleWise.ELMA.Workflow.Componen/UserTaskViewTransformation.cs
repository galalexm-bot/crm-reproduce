using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ViewItems;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class UserTaskViewTransformation : BaseFormViewTransformation
{
	internal static UserTaskViewTransformation DalnfrOycJV0anr4xisI;

	public override bool AcceptableElement(IElementWithView element)
	{
		return element is UserTaskElement;
	}

	public override FormView GetFormView(IElementWithView element, IWorkflowTaskBase task)
	{
		int num = 4;
		int num2 = num;
		FormViewItem formViewItem = default(FormViewItem);
		EntityMetadata entityMetadata = default(EntityMetadata);
		ClassMetadata metadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return formViewItem;
			default:
				formViewItem = ((FormViewItem)BKCJDmOynlaR9GV07tpX(entityMetadata.DefaultForms, ViewType.Edit)).Transformate((ViewItemTransformation)WorkflowTaskFormViewTransformate.GetTransformation(entityMetadata, ViewType.Edit)).Transformate((ViewItemTransformation)l6AYFTOyHboOpewa2nx1((UserTaskElement)element));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				entityMetadata = LhTtE7OydqRwWH8mLiL8(task.CastAsRealType().GetType(), true, true) as EntityMetadata;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				formViewItem = (FormViewItem)tTZU8pOyL0FliqXyWY8M(formViewItem, ContextDefaultContainerViewItem.Transformation(metadata, element, formViewItem, null));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				metadata = LhTtE7OydqRwWH8mLiL8(x4sLx7OyDxOsEYgAc3wt(hvnYh8OyuHXdliHOfSZ5(task.WorkflowBookmark)).GetType(), true, true) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public UserTaskViewTransformation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iuHhW8OyPSblSOdNe4j0()
	{
		return DalnfrOycJV0anr4xisI == null;
	}

	internal static UserTaskViewTransformation AK13cuOyX6EDo2niwuqL()
	{
		return DalnfrOycJV0anr4xisI;
	}

	internal static object LhTtE7OydqRwWH8mLiL8(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object hvnYh8OyuHXdliHOfSZ5(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object x4sLx7OyDxOsEYgAc3wt(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object BKCJDmOynlaR9GV07tpX(object P_0, ViewType P_1)
	{
		return ((ClassDefaultForms)P_0).GetForm(P_1);
	}

	internal static object l6AYFTOyHboOpewa2nx1(object P_0)
	{
		return WorkflowTaskFormViewTransformate.GetTaskSettingsTransformation((UserTaskElement)P_0);
	}

	internal static object tTZU8pOyL0FliqXyWY8M(object P_0, object P_1)
	{
		return ((FormViewItem)P_0).Transformate((ViewItemTransformation)P_1);
	}
}
