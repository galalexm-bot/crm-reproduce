using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Orleans.Runtime;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal class GrainsAssemblyBuilder
{
	public static Assembly Build()
	{
		List<MemberDeclarationSyntax> list = new List<MemberDeclarationSyntax>();
		(Type interfaceType, Type implementationType)[] array = ComponentManager.ActorTypes.ToArray();
		BuildAndLoadActorsProxiesAssemblies(array);
		foreach (IGrouping<string, (Type, Type)> item in from p in array
			group p by p.interfaceType.Namespace)
		{
			List<MemberDeclarationSyntax> list2 = new List<MemberDeclarationSyntax>();
			foreach (var (type, type2) in item)
			{
				list2.Add((MemberDeclarationSyntax)(object)GrainInterfaceWrapperGenerator.Generate(type, type2));
				list2.Add((MemberDeclarationSyntax)(object)GrainClassWrapperGenerator.Generate(type, type2));
			}
			if (list2.Count != 0)
			{
				list.Add((MemberDeclarationSyntax)(object)SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(item.Key, 0, true)).AddMembers(list2.ToArray()));
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		return CodeGeneratorCommon.CompileAssembly(SyntaxFactory.CompilationUnit().AddMembers(list.ToArray()), "OrleansCodeGen", emitDebugSymbols: false);
	}

	private static void BuildAndLoadActorsProxiesAssemblies((Type interfaceType, Type implementationType)[] actorTypes)
	{
		byte[] publicKey = typeof(IActor).Assembly.GetName().GetPublicKey();
		foreach (IGrouping<bool, (Type, Type)> item in from p in actorTypes
			group p by p.interfaceType.Assembly.GetName().GetPublicKey().Length != 0)
		{
			List<MemberDeclarationSyntax> list = new List<MemberDeclarationSyntax>();
			foreach (IGrouping<string, (Type, Type)> item2 in from p in item
				group p by p.interfaceType.Namespace)
			{
				List<MemberDeclarationSyntax> list2 = new List<MemberDeclarationSyntax>();
				foreach (var (actorInterfaceType, actorImplementationType) in item2)
				{
					list2.Add((MemberDeclarationSyntax)(object)ActorProxyInterfaceGenerator.Generate(actorInterfaceType, actorImplementationType));
					list2.AddRange((IEnumerable<MemberDeclarationSyntax>)(object)ActorInterfaceWrapperGenerator.Generate(actorInterfaceType, actorImplementationType));
				}
				if (list2.Count != 0)
				{
					list.Add((MemberDeclarationSyntax)(object)SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(item2.Key, 0, true)).AddMembers(list2.ToArray()));
				}
			}
			if (list.Count != 0)
			{
				OrleansServiceCollectionHelper.ParseAssembly(CodeGeneratorCommon.CompileAssembly(SyntaxFactory.CompilationUnit().AddMembers(list.ToArray()), "EleWise.ELMA.Actors", emitDebugSymbols: false, item.Key ? publicKey : null));
			}
		}
	}
}
