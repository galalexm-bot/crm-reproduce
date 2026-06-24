using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ViewItems;

namespace EleWise.ELMA.Workflow.UIBuilder.Db;

internal sealed class WorkflowUIBuilderDbStructure : DbStructureExtension
{
	private static readonly Regex regexOldProcess = new Regex("(?<=\\[\")(?<typeRef>\\w+)\\$(?<propertyName>\\w+)(?=\"\\])");

	private static readonly Regex regexNewProcess = new Regex("(?<=\\.)(?<typeRef>P_\\d\\w+)\\$(?<propertyName>\\w+)");

	public override Guid ProviderUid => Guid.Empty;

	internal void ClearDynamicPropertyProcessForms()
	{
		foreach (IWorkflowProcess processesWithClientScriptAndForm in WorkflowProcessManager.Instance.GetProcessesWithClientScriptAndForms())
		{
			if (processesWithClientScriptAndForm != null && processesWithClientScriptAndForm.Forms != null)
			{
				ClearMetadataItem(processesWithClientScriptAndForm);
			}
		}
	}

	private void ClearMetadataItem(IWorkflowProcess process)
	{
		WorkflowFormsContainer workflowFormsContainer = ClassSerializationHelper.CloneObjectByXml(process.Forms);
		foreach (WorkflowTaskForm item in workflowFormsContainer.Items.OfType<WorkflowTaskForm>())
		{
			FormViewItemTransformation transformation;
			if (item == null || (transformation = item.Transformation) == null)
			{
				continue;
			}
			foreach (ViewItemTransformation item2 in transformation.Items)
			{
				ViewItem viewItem = (item2 as ViewItemTransformationAdd)?.Item;
				if (viewItem != null)
				{
					DeleteEmptyFormItem(viewItem);
				}
			}
		}
		process.Forms = workflowFormsContainer;
		process.Save();
	}

	private void DeleteEmptyFormItem(ViewItem viewItem)
	{
		if (viewItem is RootViewItem rootViewItem)
		{
			List<ViewItem> list = new List<ViewItem>();
			foreach (ViewItem item in rootViewItem.Items)
			{
				if (item.Hide)
				{
					list.Add(item);
				}
				else
				{
					DeleteEmptyFormItem(item);
				}
			}
			foreach (ViewItem item2 in list)
			{
				rootViewItem.Items.Remove(item2);
			}
		}
		if (viewItem.DynamicProperties == null || viewItem.DynamicProperties.Count == 0)
		{
			return;
		}
		ComputedValue[] array = viewItem.DynamicProperties.ToArray();
		foreach (ComputedValue computedValue in array)
		{
			if (computedValue is InputComputedValue)
			{
				continue;
			}
			if (computedValue.ComputedValueType == ComputedValueType.CalculateScript && string.IsNullOrWhiteSpace(computedValue.CalculateScript))
			{
				ClearProperty(viewItem, computedValue);
			}
			else if (computedValue.ComputedValueType == ComputedValueType.Function)
			{
				if (viewItem is ButtonViewItem buttonViewItem && computedValue.Name == "ButtonViewItem" && string.IsNullOrWhiteSpace(buttonViewItem.ScriptName))
				{
					ClearProperty(viewItem, computedValue);
				}
				else if (string.IsNullOrWhiteSpace(computedValue.MethodName))
				{
					ClearProperty(viewItem, computedValue);
				}
			}
			else
			{
				if (computedValue.ComputedValueType != 0)
				{
					continue;
				}
				if (computedValue.Value is ActionValue actionValue)
				{
					if ((actionValue.CodeType == CodeType.Client || actionValue.CodeType == CodeType.Server) && string.IsNullOrWhiteSpace(actionValue.MethodName))
					{
						ClearProperty(viewItem, computedValue);
					}
					else if (actionValue.CodeType == CodeType.GlobalFunction && actionValue.FunctionHeaderUid == Guid.Empty)
					{
						ClearProperty(viewItem, computedValue);
					}
				}
				else
				{
					ClearProperty(viewItem, computedValue);
				}
			}
		}
	}

	private void ClearProperty(ViewItem viewItem, ComputedValue dynamicProperty)
	{
		viewItem.DynamicProperties.Remove(dynamicProperty);
	}

	internal void UpdateClientScriptModules()
	{
		IDataClassMetadataTypeReferenceService serviceNotNull = Locator.GetServiceNotNull<IDataClassMetadataTypeReferenceService>();
		foreach (ProcessWithScriptModuleWrapper processesWithClientScriptModule in WorkflowProcessManager.Instance.GetProcessesWithClientScriptModules())
		{
			DataClassMetadata viewModelMetadata = processesWithClientScriptModule.ProcessContext.ViewModelMetadata;
			if (viewModelMetadata == null)
			{
				continue;
			}
			FixViewModelMetadataTypeRefRc1(processesWithClientScriptModule.ProcessContext);
			ScriptModule scriptModule = processesWithClientScriptModule.ScriptModule;
			if (scriptModule != null)
			{
				byte[] assemblyRaw = scriptModule.AssemblyRaw;
				if (assemblyRaw != null)
				{
					byte[] array2 = (scriptModule.AssemblyRaw = ProcessScriptModuleRaw(serviceNotNull, assemblyRaw, viewModelMetadata.Uid));
				}
				byte[] debugRaw = scriptModule.DebugRaw;
				if (debugRaw != null)
				{
					byte[] array4 = (scriptModule.DebugRaw = ProcessScriptModuleRaw(serviceNotNull, debugRaw, viewModelMetadata.Uid));
				}
				scriptModule.Save();
			}
		}
	}

	internal void UpdateClientScriptModuleSourceCodeClassNames()
	{
		foreach (ProcessWithScriptModuleWrapper processesWithClientScriptModule in WorkflowProcessManager.Instance.GetProcessesWithClientScriptModules())
		{
			ScriptModule scriptModule = processesWithClientScriptModule.ScriptModule;
			if (scriptModule == null)
			{
				continue;
			}
			string sourceCode = scriptModule.SourceCode;
			if (!string.IsNullOrWhiteSpace(sourceCode))
			{
				string className = scriptModule.ClassName;
				if (!sourceCode.Contains("partial class " + className))
				{
					int startIndex = sourceCode.IndexOf("partial class ");
					int index = sourceCode.IndexOf("Scripts", startIndex);
					sourceCode = (scriptModule.SourceCode = sourceCode.ReplaceAt(index, "Scripts".Length, "_Scripts"));
					scriptModule.Save();
				}
			}
		}
	}

	private static byte[] ProcessScriptModuleRaw(IDataClassMetadataTypeReferenceService typeReferenceService, byte[] raw, Guid metadataUid)
	{
		string @string = Encoding.UTF8.GetString(raw);
		string input = regexOldProcess.Replace(@string, delegate(Match match)
		{
			GroupCollection groups2 = match.Groups;
			string value3 = groups2["propertyName"].Value;
			string value4 = groups2["typeRef"].Value;
			if (value4.StartsWith("P_"))
			{
				return $"{value3}${metadataUid:n}";
			}
			if (ProcessTypeRef(value4) != null)
			{
				return $"{value3}${metadataUid:n}";
			}
			Guid? metadataUid2 = typeReferenceService.GetMetadataUid(value4);
			return metadataUid2.HasValue ? $"{value3}${metadataUid2.Value:n}" : match.Value;
		});
		string s = regexNewProcess.Replace(input, delegate(Match match)
		{
			GroupCollection groups = match.Groups;
			string value = groups["propertyName"].Value;
			string value2 = groups["typeRef"].Value;
			if (value2.StartsWith("P_"))
			{
				return $"{value}${metadataUid:n}";
			}
			return (ProcessTypeRef(value2) != null) ? $"{value}${metadataUid:n}" : match.Value;
		});
		return Encoding.UTF8.GetBytes(s);
	}

	private void FixViewModelMetadataTypeRefRc1(EntityMetadata context)
	{
		DataClassMetadata viewModelMetadata = context.ViewModelMetadata;
		if (viewModelMetadata != null)
		{
			string text = ProcessTypeRef(viewModelMetadata.TypeRef);
			if (text != null)
			{
				viewModelMetadata.TypeRef = text;
				DataClassMetadata dataClassMetadata = (DataClassMetadata)viewModelMetadata.Clone();
				dataClassMetadata.Uid = viewModelMetadata.Uid;
				context.ViewModelMetadata = dataClassMetadata;
				context.Save();
			}
		}
	}

	private static string ProcessTypeRef(string typeRef)
	{
		if (string.IsNullOrWhiteSpace(typeRef))
		{
			return null;
		}
		if (typeRef.StartsWith("P_"))
		{
			return null;
		}
		string[] array = typeRef.Split('P');
		if (array.Length != 2)
		{
			return null;
		}
		return "P_" + array[0] + "_" + array[1];
	}
}
