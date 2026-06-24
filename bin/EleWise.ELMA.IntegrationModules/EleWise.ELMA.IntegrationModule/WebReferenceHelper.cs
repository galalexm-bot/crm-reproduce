using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scripts.ServiceReference;
using ICSharpCode.NRefactory.CSharp;
using Microsoft.Tools.ServiceModel.SvcUtil;

namespace EleWise.ELMA.IntegrationModules.Extensions;

internal static class WebReferenceHelper
{
	private const string ReferenceMapFileName = "Reference.map";

	private const string ReferenceFileName = "Reference.cs";

	private const string AppConfigFileName = "App.config";

	private const string SystemClientBaseFullName = "System.ServiceModel.ClientBase";

	private const string ELMAClientBaseFullName = "EleWise.ELMA.IntegrationModules.Models.CodeGeneration.ClientBase";

	private const string AppConfigFullName = "EleWise.ELMA.Model.Attributes.AppConfig";

	private const string EndpointAddressParamName = "endpointAddress";

	private const string BindingParamName = "binding";

	private const string HeadersParamName = "headers";

	private const string IntegrationModuleParamName = "integrationModule";

	private const string DictionaryFullTypeName = "System.Collections.Generic.IDictionary<string, string>";

	private static readonly List<string> Extensions = new List<string> { "*.wsdl", "*.xsd", "*.wspolicy", "*.wsmex" };

	private static readonly string BindingFullTypeName = typeof(System.ServiceModel.Channels.Binding).FullName;

	private static readonly string EndpointAddressFullTypeName = typeof(EndpointAddress).FullName;

	private static readonly string StringFullTypeName = typeof(string).FullName;

	private static readonly string IntegrationModuleFullTypeName = typeof(IIntegrationModule).FullName;

	internal static void Save(this EleWise.ELMA.Scripts.ServiceReference.WebReference webReference)
	{
		Directory.CreateDirectory(webReference.Directory);
		webReference.CheckDocumentsNames();
		webReference.Protocol.WriteAll(webReference.Directory, "Reference.map");
		webReference.RunSvcUtil();
	}

	private static void CheckDocumentsNames(this EleWise.ELMA.Scripts.ServiceReference.WebReference webReference)
	{
		string str = new string(Path.GetInvalidFileNameChars());
		Regex regex = new Regex($"[{Regex.Escape(str)}]");
		foreach (object value in webReference.Protocol.Documents.Values)
		{
			if (value is NamedItem namedItem && !string.IsNullOrEmpty(namedItem.Name))
			{
				namedItem.Name = regex.Replace(namedItem.Name, "_");
			}
		}
	}

	private static void RunSvcUtil(this EleWise.ELMA.Scripts.ServiceReference.WebReference webReference)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(webReference.Directory);
		foreach (string extension in Extensions)
		{
			if (directoryInfo.GetFiles(extension).Any())
			{
				list.Add($"{webReference.Directory}\\{extension}");
			}
		}
		List<string> list2 = new List<string>
		{
			"/t:code",
			"/d:" + webReference.Directory,
			"/o:" + webReference.Directory + "\\Reference.cs",
			"/n:*," + webReference.ProxyNamespace,
			"/s",
			"/edb",
			"/config:" + webReference.Directory + "\\App"
		};
		if (!string.IsNullOrEmpty(SR.GetSetting("SvcUtilAdditionalParams")))
		{
			list2.AddRange(SR.GetSetting("SvcUtilAdditionalParams").Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
		}
		if (list.Count > 0)
		{
			list2.AddRange(list);
		}
		if (Tool.Main(list2.ToArray()) != 0)
		{
			Logger.Log.Error(SR.T("Генерация файла Reference.cs завершилась с ошибкой. Аргументы запуска: {0}", string.Join(" ", list2)));
			throw new Exception(SR.T("Не удалось сгенерировать прокси-класс для указанного сервиса. Подробности в логе."));
		}
		string path = Path.Combine(webReference.Directory, "Reference.cs");
		string sourceCodeContent = (File.Exists(path) ? File.ReadAllText(path) : "");
		string path2 = Path.Combine(webReference.Directory, "App.config");
		string appConfigContent = (File.Exists(path2) ? File.ReadAllText(path2) : "");
		string contents = EditSourceCode(sourceCodeContent, appConfigContent, webReference.Url);
		File.WriteAllText(Path.Combine(webReference.Directory, "Reference.cs"), contents);
	}

	private static string EditSourceCode(string sourceCodeContent, string appConfigContent, string url)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ef: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		string text = sourceCodeContent.Replace("System.ServiceModel.ClientBase", "EleWise.ELMA.IntegrationModules.Models.CodeGeneration.ClientBase");
		SyntaxTree val = new CSharpParser().Parse(text, "");
		AstNode val2 = ((IEnumerable<AstNode>)val.get_Members()).FirstOrDefault((AstNode q) => q is NamespaceDeclaration);
		if (val2 == null)
		{
			return sourceCodeContent;
		}
		List<TypeDeclaration> source = val2.get_Children().OfType<TypeDeclaration>().ToList();
		TypeDeclaration val3 = source.FirstOrDefault((TypeDeclaration q) => (int)q.get_ClassType() == 2 && !((IEnumerable<AstType>)q.get_BaseTypes()).Any());
		if (val3 == null)
		{
			return sourceCodeContent;
		}
		Attribute val4 = new Attribute();
		val4.set_Type(AstType.Create("EleWise.ELMA.Model.Attributes.AppConfig"));
		val4.get_Arguments().Add((Expression)new PrimitiveExpression((object)appConfigContent));
		val4.get_Arguments().Add((Expression)new PrimitiveExpression((object)DateTime.Now.ToString(CultureInfo.InvariantCulture)));
		val4.get_Arguments().Add((Expression)new PrimitiveExpression((object)url));
		AttributeSection val5 = new AttributeSection(val4);
		((EntityDeclaration)val3).get_Attributes().Add(val5);
		TypeDeclaration val6 = source.FirstOrDefault((TypeDeclaration q) => (int)q.get_ClassType() == 0 && ((IEnumerable<AstType>)q.get_BaseTypes()).FirstOrDefault((AstType qq) => ((object)qq).ToString().Contains("EleWise.ELMA.IntegrationModules.Models.CodeGeneration.ClientBase")) != null);
		if (val6 == null)
		{
			return sourceCodeContent;
		}
		IEnumerable<ConstructorDeclaration> enumerable = ((IEnumerable)val6.get_Members()).OfType<ConstructorDeclaration>();
		ConstructorDeclaration defaultCtor = null;
		foreach (ConstructorDeclaration item in enumerable)
		{
			if (item.get_Parameters().get_Count() == 0)
			{
				defaultCtor = item;
				continue;
			}
			if (item.get_Parameters().get_Count() == 2)
			{
				ParameterDeclaration obj = ((IEnumerable<ParameterDeclaration>)item.get_Parameters()).ElementAt(0);
				ParameterDeclaration val7 = ((IEnumerable<ParameterDeclaration>)item.get_Parameters()).ElementAt(1);
				if (((object)obj.get_Type()).ToString().Contains(BindingFullTypeName) && ((object)val7.get_Type()).ToString().Contains(EndpointAddressFullTypeName))
				{
					continue;
				}
			}
			((AstNode)item).Remove();
		}
		GenerateNewCtor(defaultCtor, val6, new Dictionary<string, string> { { "endpointAddress", StringFullTypeName } });
		GenerateNewCtor(defaultCtor, val6, new Dictionary<string, string>
		{
			{ "binding", BindingFullTypeName },
			{ "endpointAddress", EndpointAddressFullTypeName },
			{ "headers", "System.Collections.Generic.IDictionary<string, string>" }
		});
		GenerateNewCtor(defaultCtor, val6, new Dictionary<string, string>
		{
			{ "binding", BindingFullTypeName },
			{ "endpointAddress", EndpointAddressFullTypeName },
			{ "integrationModule", IntegrationModuleFullTypeName }
		});
		return ((object)val).ToString();
	}

	private static void GenerateNewCtor(ConstructorDeclaration defaultCtor, TypeDeclaration clientClass, IDictionary<string, string> parameters)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		ConstructorDeclaration val = new ConstructorDeclaration();
		val.get_Parameters().AddRange(((IEnumerable<KeyValuePair<string, string>>)parameters).Select((Func<KeyValuePair<string, string>, ParameterDeclaration>)((KeyValuePair<string, string> x) => new ParameterDeclaration(AstType.Create(x.Value), x.Key, (ParameterModifier)0))));
		ConstructorInitializer val2 = new ConstructorInitializer();
		val2.set_ConstructorInitializerType((ConstructorInitializerType)1);
		ConstructorInitializer val3 = val2;
		val3.get_Arguments().AddRange((IEnumerable<Expression>)((IEnumerable<KeyValuePair<string, string>>)parameters).Select((Func<KeyValuePair<string, string>, IdentifierExpression>)((KeyValuePair<string, string> x) => new IdentifierExpression(x.Key))));
		val.set_Initializer(val3);
		((EntityDeclaration)val).set_Modifiers((Modifiers)8);
		val.set_Body(new BlockStatement());
		if (defaultCtor != null)
		{
			((AstNode)clientClass).InsertChildAfter<EntityDeclaration>((AstNode)(object)defaultCtor, (EntityDeclaration)(object)val, Roles.TypeMemberRole);
		}
		else
		{
			((AstNode)clientClass).AddChild<EntityDeclaration>((EntityDeclaration)(object)val, Roles.TypeMemberRole);
		}
	}
}
