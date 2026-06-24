using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class ProcessObjectFormProvider : IObjectFormProvider
{
	private readonly WorkflowTaskBaseManager workflowTaskBaseManager;

	private readonly ViewModelDescriptor viewModelDescriptor;

	private static ProcessObjectFormProvider g6wfZBO0guQbufLOpPeL;

	public ProcessObjectFormProvider(WorkflowTaskBaseManager workflowTaskBaseManager, ViewModelDescriptor viewModelDescriptor)
	{
		//Discarded unreachable code: IL_001e
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
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
				this.viewModelDescriptor = viewModelDescriptor;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				this.workflowTaskBaseManager = workflowTaskBaseManager;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public bool Check(Guid typeUid, Guid subTypeUid)
	{
		return d6wCkwO0Pg4syk30K8Ey(typeUid, ProcessContext.ProcessContextUid);
	}

	public (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
	{
		IWorkflowInstance instance = workflowTaskBaseManager.Load(subTypeUid).WorkflowBookmark.Instance;
		IWorkflowProcess workflowProcess = instance.Process;
		ProcessContext context = workflowProcess.Context;
		if (context.ViewModelMetadata != null)
		{
			ScriptModule scriptModule = workflowProcess.ScriptModule;
			while (workflowProcess.Parent != null)
			{
				scriptModule = workflowProcess.Parent.ScriptModule;
				workflowProcess = workflowProcess.Parent;
			}
			Assembly assembly = ComponentManager.FindLoadedAssembly(scriptModule.AssemblyName, isFullName: false);
			if (assembly == null)
			{
				assembly = ComponentManager.LoadAssembly(scriptModule.AssemblyRaw, scriptModule.DebugRaw);
			}
			string name = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCC9422) + context.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19266D2F);
			if (assembly.GetType(name) != null)
			{
				string name2 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122790691) + context.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965182807) + context.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885048433);
				Type type = assembly.GetType(name2);
				if (type != null)
				{
					return (DeserializeViewModelContext(model, context.ViewModelMetadata, type), context.ViewModelMetadata);
				}
			}
		}
		else
		{
			new EntityJsonSerializer().Deserialize(model, instance.Context.GetType());
		}
		return (instance.Context, instance.Process.Context);
	}

	public FormViewItem GetFormByType(object obj, ViewType viewType)
	{
		throw new NotImplementedException((string)jX577YO0dyP0QeZTACvl(dWVTJJO0XWuMEiysmD6a(-667465279 ^ -667487755)));
	}

	public FormViewItem GetFormByUid(object obj, Guid formUid)
	{
		throw new NotImplementedException((string)jX577YO0dyP0QeZTACvl(dWVTJJO0XWuMEiysmD6a(-22348816 ^ -22330538)));
	}

	public void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
	{
	}

	private object DeserializeViewModelContext(string model, DataClassMetadata viewModelContextMetadata, Type viewModelContextType)
	{
		int num = 1;
		int num2 = num;
		IActionExecutionParamModel actionExecutionParamModel = default(IActionExecutionParamModel);
		ClassMetadata metadata = default(ClassMetadata);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		Dictionary<string, object> values = default(Dictionary<string, object>);
		ExpandoObject value = default(ExpandoObject);
		while (true)
		{
			switch (num2)
			{
			case 1:
				actionExecutionParamModel = (IActionExecutionParamModel)vdLQETO0ucdwuS5g8nC5(typeof(ActionExecutionParamModel<>).MakeGenericType(viewModelContextType));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				viewModelDescriptor.Deserialize(actionExecutionParamModel, metadata, propertyMetadata2, values);
				num2 = 5;
				break;
			case 6:
				value = (ExpandoObject)S7IvJTO0fTOdWADHB4dr(new EntityJsonSerializer(), model);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return actionExecutionParamModel.Parameter;
			case 3:
			{
				PropertyMetadata propertyMetadata = new PropertyMetadata();
				rfeDLkO0DsMcwfpWPw6Y(propertyMetadata, dWVTJJO0XWuMEiysmD6a(-1108877388 ^ -1108973654));
				Lcvc0AO0nO4wfJDmyXgH(propertyMetadata, viewModelDescriptor.Uid);
				propertyMetadata.SubTypeUid = HKJRKIO0HPHxeXYfyKOX(viewModelContextMetadata);
				HekLF7O0LAEfwrR3UF6W(propertyMetadata, new DataClassSettings
				{
					RelationType = RelationType.OneToOne
				});
				propertyMetadata2 = propertyMetadata;
				num2 = 6;
				break;
			}
			default:
				metadata = new ClassMetadata();
				num2 = 3;
				break;
			case 2:
				values = new Dictionary<string, object> { 
				{
					(string)dWVTJJO0XWuMEiysmD6a(0x738ABA6E ^ 0x738B0270),
					value
				} };
				num2 = 4;
				break;
			}
		}
	}

	internal static bool X9tQAvO0B6fkmflHfyIq()
	{
		return g6wfZBO0guQbufLOpPeL == null;
	}

	internal static ProcessObjectFormProvider y0EghyO0cOBEogZBUOqE()
	{
		return g6wfZBO0guQbufLOpPeL;
	}

	internal static bool d6wCkwO0Pg4syk30K8Ey(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object dWVTJJO0XWuMEiysmD6a(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jX577YO0dyP0QeZTACvl(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object vdLQETO0ucdwuS5g8nC5(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void rfeDLkO0DsMcwfpWPw6Y(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void Lcvc0AO0nO4wfJDmyXgH(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).TypeUid = P_1;
	}

	internal static Guid HKJRKIO0HPHxeXYfyKOX(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void HekLF7O0LAEfwrR3UF6W(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static object S7IvJTO0fTOdWADHB4dr(object P_0, object P_1)
	{
		return ((EntityJsonSerializer)P_0).DeserializeJson((string)P_1);
	}
}
