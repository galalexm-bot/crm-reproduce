using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using System.Web.Services;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Hubs.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Hubs;
using EleWise.ELMA.Web.Hubs.Attributes;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Service;

[Service]
internal sealed class BuildHubsAssemblyService : IBuildHubsAssemblyService
{
	public byte[][] BuildAssemblies()
	{
		List<byte[]> list = new List<byte[]>();
		byte[] publicKey = typeof(IHub).Assembly.GetName().GetPublicKey();
		foreach (IGrouping<bool, (Type, Type)> item5 in from p in ComponentManager.HubTypes
			group p by p.interfaceType.Assembly.GetName().GetPublicKey().Length != 0)
		{
			HashSet<Assembly> assemblySet = new HashSet<Assembly>
			{
				typeof(object).Assembly,
				typeof(Uri).Assembly,
				typeof(Enumerable).Assembly,
				typeof(Bitmap).Assembly,
				typeof(RangeAttribute).Assembly,
				typeof(HtmlString).Assembly,
				typeof(WebService).Assembly,
				typeof(XmlAttribute).Assembly,
				typeof(BasicHttpBinding).Assembly,
				typeof(ExportOptions).Assembly,
				typeof(IHub).Assembly,
				typeof(RequestWrapper).Assembly,
				typeof(IGroupManager).Assembly
			};
			AssemblyBuilder builder = new AssemblyBuilder
			{
				AssemblyName = "EleWise.ELMA.SignalRHubs",
				PublicKey = (item5.Key ? publicKey : null)
			};
			try
			{
				foreach (var item6 in item5)
				{
					Type interfaceType = item6.Item1;
					Type implementationType = item6.Item2;
					HashSet<string> usings = new HashSet<string> { "System", "Microsoft.AspNet.SignalR", "Microsoft.AspNet.SignalR.Hubs", "EleWise.ELMA.Web.Hubs", "EleWise.ELMA.ComponentModel", "EleWise.ELMA.Web.Hubs.Attributes" };
					usings.WithIgnoreNamespaces(delegate
					{
						Type type = implementationType.BaseType.GetGenericArguments()[0];
						Type type2 = typeof(HubProxy<, >).MakeGenericType(interfaceType, type);
						ISyntaxNode baseType = type2.CreateTypeSyntax();
						List<ISyntaxNode> list2 = new List<ISyntaxNode>();
						Attribute[] customAttributes = Attribute.GetCustomAttributes(implementationType, typeof(AuthorizeAttribute));
						foreach (Attribute attribute in customAttributes)
						{
							list2.Add(attribute.GetType().CreateAttribute());
						}
						if (list2.Count == 0)
						{
							list2.Add(typeof(HubAuthorizeAttribute).CreateAttribute());
						}
						AddUsingIfNeed(implementationType, usings, assemblySet);
						HubNameAttribute attribute2 = AttributeHelper<HubNameAttribute>.GetAttribute(implementationType, inherited: false);
						string value = ((attribute2 != null) ? attribute2.HubName : implementationType.Name.ToLowerFirstChar());
						list2.Add(typeof(HubNameAttribute).CreateAttribute(value.CreateSyntaxNode()));
						ConstructorInfo constructorInfo = type2.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).First();
						List<ISyntaxNode> list3 = new List<ISyntaxNode>();
						List<ISyntaxNode> list4 = new List<ISyntaxNode>();
						ParameterInfo[] parameters = constructorInfo.GetParameters();
						foreach (ParameterInfo parameterInfo in parameters)
						{
							list3.Add(parameterInfo.Name.IdentifierName());
							list4.Add(parameterInfo.Name.ParameterDeclaration(ProcessType(parameterInfo.ParameterType, usings, assemblySet)));
						}
						ISyntaxNode item = SyntaxGeneratorExtensions.ConstructorDeclaration(list4, Accessibility.Public, DeclarationModifiers.None, list3);
						List<ISyntaxNode> list5 = new List<ISyntaxNode> { item };
						MethodInfo[] array = (from method in implementationType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public)
							where !method.IsSpecialName
							select method).ToArray();
						foreach (MethodInfo methodInfo in array)
						{
							List<ISyntaxNode> list6 = new List<ISyntaxNode>();
							List<ISyntaxNode> list7 = new List<ISyntaxNode>();
							parameters = methodInfo.GetParameters();
							foreach (ParameterInfo parameterInfo2 in parameters)
							{
								list6.Add(parameterInfo2.Name.IdentifierName());
								list7.Add(parameterInfo2.Name.ParameterDeclaration(ProcessType(parameterInfo2.ParameterType, usings, assemblySet)));
							}
							ISyntaxNode syntaxNode = ((methodInfo.ReturnType != typeof(void)) ? ProcessType(methodInfo.ReturnType, usings, assemblySet) : null);
							ISyntaxNode syntaxNode2 = SyntaxGeneratorExtensions.This.MemberAccessExpression("Hub").CastExpression(interfaceType.CreateTypeSyntax()).MemberAccessExpression(methodInfo.Name)
								.InvocationExpression(list6);
							if (syntaxNode != null)
							{
								syntaxNode2 = syntaxNode2.ReturnStatement();
							}
							ISyntaxNode syntaxNode3 = methodInfo.Name.MethodDeclaration(list7, null, syntaxNode, Accessibility.Public, DeclarationModifiers.None, new ISyntaxNode[1] { syntaxNode2 });
							HubMethodNameAttribute attribute3 = AttributeHelper<HubMethodNameAttribute>.GetAttribute(methodInfo, inherited: false);
							if (attribute3 != null)
							{
								syntaxNode3 = syntaxNode3.AddAttributes(typeof(HubMethodNameAttribute).CreateAttribute(attribute3.MethodName.CreateSyntaxNode()));
							}
							list5.Add(syntaxNode3);
						}
						ISyntaxNode syntaxNode4 = (implementationType.Name + "SignalR").ClassDeclaration(null, Accessibility.Internal, DeclarationModifiers.Sealed, baseType, null, list5).AddAttributes(list2.ToArray());
						string text = "I" + implementationType.Name + "Client_Proxy";
						List<ISyntaxNode> list8 = new List<ISyntaxNode>();
						MethodInfo[] array2 = type.GetMethods().ToArray();
						array = array2;
						foreach (MethodInfo methodInfo2 in array)
						{
							List<ISyntaxNode> list9 = new List<ISyntaxNode>();
							parameters = methodInfo2.GetParameters();
							foreach (ParameterInfo parameterInfo3 in parameters)
							{
								list9.Add(parameterInfo3.Name.ParameterDeclaration(ProcessType(parameterInfo3.ParameterType, usings, assemblySet)));
							}
							ISyntaxNode returnType = ((methodInfo2.ReturnType != typeof(void)) ? ProcessType(methodInfo2.ReturnType, usings, assemblySet) : null);
							ISyntaxNode item2 = methodInfo2.Name.MethodDeclaration(list9, null, returnType, Accessibility.Public);
							list8.Add(item2);
						}
						ISyntaxNode syntaxNode5 = text.InterfaceDeclaration(null, Accessibility.Public, DeclarationModifiers.None, null, list8);
						Type typeFromHandle = typeof(HubClientProxy<, >);
						string name = "Wrapper_" + text;
						ISyntaxNode item3 = SyntaxGeneratorExtensions.ConstructorDeclaration(new ISyntaxNode[1] { "clientProxy".ParameterDeclaration(text.CreateTypeSyntax()) }, Accessibility.Public, DeclarationModifiers.None, new ISyntaxNode[1] { "clientProxy".IdentifierName() });
						List<ISyntaxNode> list10 = new List<ISyntaxNode> { item3 };
						array = array2;
						foreach (MethodInfo methodInfo3 in array)
						{
							List<ISyntaxNode> list11 = new List<ISyntaxNode>();
							List<ISyntaxNode> list12 = new List<ISyntaxNode>();
							parameters = methodInfo3.GetParameters();
							foreach (ParameterInfo parameterInfo4 in parameters)
							{
								list11.Add(parameterInfo4.Name.IdentifierName());
								list12.Add(parameterInfo4.Name.ParameterDeclaration(ProcessType(parameterInfo4.ParameterType, usings, assemblySet)));
							}
							ISyntaxNode syntaxNode6 = ((methodInfo3.ReturnType != typeof(void)) ? ProcessType(methodInfo3.ReturnType, usings, assemblySet) : null);
							ISyntaxNode syntaxNode7 = SyntaxGeneratorExtensions.This.MemberAccessExpression("ClientProxy").MemberAccessExpression(methodInfo3.Name).InvocationExpression(list11);
							if (syntaxNode6 != null)
							{
								syntaxNode7 = syntaxNode7.ReturnStatement();
							}
							ISyntaxNode item4 = methodInfo3.Name.MethodDeclaration(list12, null, syntaxNode6, Accessibility.Public, DeclarationModifiers.None, new ISyntaxNode[1] { syntaxNode7 });
							list10.Add(item4);
						}
						ISyntaxNode syntaxNode8 = name.ClassDeclaration(null, Accessibility.Internal, DeclarationModifiers.Sealed, typeFromHandle.CreateTypeSyntax(type.CreateTypeSyntax(), text.CreateTypeSyntax()), new ISyntaxNode[1] { type.CreateTypeSyntax() }, list10);
						IEnumerable<ISyntaxNode> declarations = usings.Select((string q) => q.NamespaceImportDeclaration()).Concat(implementationType.Namespace.NamespaceDeclaration(syntaxNode4)).Concat(type.Namespace.NamespaceDeclaration(syntaxNode5))
							.Concat(type.Namespace.NamespaceDeclaration(syntaxNode8));
						builder.AddSourceCode(declarations.GenerateCSCodeString());
					});
				}
				assemblySet.ForEach(builder.AddReference);
				list.Add(builder.Build(pdb: false, doc: false));
			}
			finally
			{
				if (builder != null)
				{
					((IDisposable)builder).Dispose();
				}
			}
		}
		return list.ToArray();
	}

	private static void AddUsingIfNeed(Type type, ISet<string> usings, ISet<Assembly> assemblies)
	{
		if (!string.IsNullOrEmpty(type.Namespace))
		{
			usings.Add(type.Namespace);
		}
		assemblies.Add(type.Assembly);
	}

	private static ISyntaxNode ProcessType(Type type, ISet<string> usings, ISet<Assembly> assemblies)
	{
		if (type.IsGenericType)
		{
			Type[] genericArguments = type.GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				AddUsingIfNeed(genericArguments[i], usings, assemblies);
			}
		}
		AddUsingIfNeed(type, usings, assemblies);
		return type.CreateTypeSyntax();
	}
}
