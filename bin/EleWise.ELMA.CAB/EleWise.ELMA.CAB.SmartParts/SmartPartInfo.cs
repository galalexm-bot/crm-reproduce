#define DEBUG
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.SmartParts;

[DesignerSerializer(typeof(SmartPartInfoDesignerSerializer), typeof(CodeDomSerializer))]
[DesignerCategory("Code")]
[ToolboxBitmap(typeof(SmartPartInfo), "SmartPartInfo")]
public class SmartPartInfo : Component, ISmartPartInfo
{
	private class SmartPartInfoDesigner : ComponentDesigner
	{
		private string smartPart;

		[DesignOnly(true)]
		[DefaultValue(null)]
		[Description("The smart part this information object describes.")]
		[TypeConverter(typeof(SmartPartConverter))]
		[Category("Behavior")]
		public string SmartPart
		{
			get
			{
				return smartPart;
			}
			set
			{
				smartPart = value;
			}
		}

		protected override void PreFilterProperties(IDictionary properties)
		{
			IDesignerHost designerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
			if (designerHost.RootComponent is WorkItem)
			{
				properties.Add("SmartPart", TypeDescriptor.GetProperties(this)["SmartPart"]);
			}
		}
	}

	private class SmartPartConverter : TypeConverter
	{
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<string> list = new List<string>();
			foreach (IComponent component in context.Container.Components)
			{
				if (Attribute.IsDefined(component.GetType(), typeof(SmartPartAttribute)))
				{
					list.Add(component.Site.Name);
				}
			}
			return new StandardValuesCollection(list);
		}
	}

	private class SmartPartInfoDesignerSerializer : DesignerCodeDomSerializer
	{
		private const string GetSmartPartInfoMethod = "GetSmartPartInfo";

		private const string AddSmartPartInfosMethod = "AddSmartPartInfos";

		private const string ProviderField = "infoProvider";

		public override object Serialize(IDesignerSerializationManager manager, object value)
		{
			CodeDomSerializer codeDomSerializer = (CodeDomSerializer)manager.GetSerializer(typeof(Component), typeof(CodeDomSerializer));
			CodeStatementCollection codeStatementCollection = (CodeStatementCollection)codeDomSerializer.Serialize(manager, value);
			IDesignerHost designerHost = (IDesignerHost)manager.GetService(typeof(IDesignerHost));
			if (!(designerHost.RootComponent is WorkItem))
			{
				GenerateSmartPartCode(manager, value, codeStatementCollection);
			}
			return codeStatementCollection;
		}

		public override object Deserialize(IDesignerSerializationManager manager, object codeObject)
		{
			CodeTypeDeclaration codeTypeDeclaration = (CodeTypeDeclaration)manager.GetService(typeof(CodeTypeDeclaration));
			if (codeObject is CodeStatementCollection statements)
			{
				DesignerCodeDomSerializer.RemoveFromStatements(statements, delegate(CodeMethodInvokeExpression invoke)
				{
					if (invoke.Method.TargetObject is CodePropertyReferenceExpression codePropertyReferenceExpression)
					{
						CodeFieldReferenceExpression codeFieldReferenceExpression = codePropertyReferenceExpression.TargetObject as CodeFieldReferenceExpression;
						return codeFieldReferenceExpression.FieldName == "infoProvider" && codeFieldReferenceExpression.TargetObject is CodeThisReferenceExpression;
					}
					return false;
				});
				CodeMemberField codeMemberField = DesignerCodeDomSerializer.FindMember<CodeMemberField>(codeTypeDeclaration, "infoProvider");
				if (codeMemberField != null)
				{
					codeTypeDeclaration.Members.Remove(codeMemberField);
				}
			}
			return base.Deserialize(manager, codeObject);
		}

		private static void GenerateSmartPartCode(IDesignerSerializationManager manager, object value, CodeStatementCollection statements)
		{
			IDesignerHost designerHost = (IDesignerHost)manager.GetService(typeof(IDesignerHost));
			CodeTypeDeclaration codeTypeDeclaration = (CodeTypeDeclaration)manager.GetService(typeof(CodeTypeDeclaration));
			if (designerHost.Container.Components["infoProvider"] == null)
			{
				IComponent component = designerHost.CreateComponent(typeof(SmartPartInfoProvider), "infoProvider");
				designerHost.Container.Add(component, "infoProvider");
			}
			MethodInfo method = typeof(ISmartPartInfoProvider).GetMethod("GetSmartPartInfo");
			Debug.Assert(method != null, "ISmartPartInfoProvider interface definition changed. GetSmartPartInfo method not found.");
			CodeMemberMethod codeMemberMethod = DesignerCodeDomSerializer.FindMember<CodeMemberMethod>(codeTypeDeclaration, "GetSmartPartInfo");
			if (codeMemberMethod == null)
			{
				codeMemberMethod = GenerateGetSmartPartInfo(method);
				codeTypeDeclaration.Members.Add(codeMemberMethod);
			}
			AddToProvider(manager, value, statements);
		}

		private static void AddToProvider(IDesignerSerializationManager manager, object value, CodeStatementCollection statements)
		{
			IReferenceService referenceService = (IReferenceService)manager.GetService(typeof(IReferenceService));
			statements.Add(new CodeMethodInvokeExpression(new CodePropertyReferenceExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "infoProvider"), "Items"), "Add", new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), referenceService.GetName(value))));
		}

		private static CodeMemberMethod GenerateGetSmartPartInfo(MethodInfo interfaceMethod)
		{
			CodeMemberMethod codeMemberMethod = new CodeMemberMethod();
			codeMemberMethod.Attributes = MemberAttributes.Public;
			codeMemberMethod.Comments.Add(new CodeCommentStatement("<summary>Generated by a designer. Required inmplementation of ISmartPartInfoProvider"));
			GenerateCastForInterface(codeMemberMethod);
			codeMemberMethod.Name = interfaceMethod.Name;
			codeMemberMethod.ReturnType = new CodeTypeReference(interfaceMethod.ReturnType);
			List<CodeExpression> list = new List<CodeExpression>();
			ParameterInfo[] parameters = interfaceMethod.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				codeMemberMethod.Parameters.Add(new CodeParameterDeclarationExpression(parameterInfo.ParameterType, parameterInfo.Name));
				list.Add(new CodeArgumentReferenceExpression(parameterInfo.Name));
			}
			CodeMethodInvokeExpression expression = new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "infoProvider"), interfaceMethod.Name, list.ToArray());
			codeMemberMethod.Statements.Add(new CodeMethodReturnStatement(expression));
			return codeMemberMethod;
		}

		private static void GenerateCastForInterface(CodeMemberMethod methodImpl)
		{
			methodImpl.Statements.Add(new CodeCommentStatement(Resources.SmartPartMustImplementISmartPartInfoProvider));
			methodImpl.Statements.Add(new CodeVariableDeclarationStatement(typeof(ISmartPartInfoProvider), "ensureProvider", new CodeThisReferenceExpression()));
		}

		private static void GenerateWorkItemCode(IDesignerSerializationManager manager, object value, CodeStatementCollection statements)
		{
			string text = (string)TypeDescriptor.GetProperties(value)["SmartPart"].GetValue(value);
			if (text != null)
			{
				CodeMethodInvokeExpression value2 = new CodeMethodInvokeExpression(new CodeMethodReferenceExpression(new CodeBaseReferenceExpression(), "RegisterSmartPartInfo"), new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), text), new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), manager.GetName(value)));
				statements.Add(value2);
			}
		}
	}

	private string description = string.Empty;

	private string title = string.Empty;

	[Category("Layout")]
	public string Description
	{
		get
		{
			return description;
		}
		set
		{
			description = value;
		}
	}

	[Category("Layout")]
	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public SmartPartInfo()
	{
	}

	public SmartPartInfo(string title, string description)
	{
		this.title = title;
		this.description = description;
	}

	public static TSmartPartInfo ConvertTo<TSmartPartInfo>(ISmartPartInfo source) where TSmartPartInfo : ISmartPartInfo, new()
	{
		Guard.ArgumentNotNull(source, "source");
		return new TSmartPartInfo
		{
			Description = source.Description,
			Title = source.Title
		};
	}
}
