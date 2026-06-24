using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.SDK;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

[Component(Order = int.MaxValue)]
internal class PublicApiCustomMethodsNodeProvider : IPublicApiNodeProvider
{
	private readonly IEntityManagerTypesStorage entityManagerTypesStorage;

	internal static PublicApiCustomMethodsNodeProvider C7fAJjhHvrcBxXfFvE1k;

	public PublicApiCustomMethodsNodeProvider(IEntityManagerTypesStorage entityManagerTypesStorage)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.entityManagerTypesStorage = entityManagerTypesStorage;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		return (from method in entityManagerTypesStorage.GetManagerTypes().SelectMany((Type t) => t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod))
			select new
			{
				method = method,
				PublicApiNodeId = AttributeHelper<PublicApiNodeIdAttribute>.GetAttribute(method, inherited: false)?.PublicApiNodeId
			} into data
			where data.PublicApiNodeId != null && data.PublicApiNodeId != z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92AD7BD) && AttributeHelper<PublicApiMemberAttribute>.GetAttribute(data.method, inherited: false) != null
			select new PublicApiMethodInvokeNode(PublicApiCodeGenerator.Current.GetPropertyClassNodePath(data.PublicApiNodeId).Single(), data.method, ManagerReferenceCode(data.method))).ToArray();
	}

	private ISyntaxNode ManagerReferenceCode(MethodInfo method)
	{
		return ((ISyntaxNode)ohZ2XwhHiheX9YswC3l2(wMgUhqhHuuPB63XE0Pnq(EleWise.ELMA.SDK.TypeOf.Locator).CreateTypeSyntax(), ((string)AdPjJ9hHI3C31Y6oSNGq(-1638402543 ^ -1638629149)).GenericName((ISyntaxNode)O1ULM1hHSohOIkTr3QSL(Ex9DKnhHVekDovts2Zs5(method))))).InvocationExpression();
	}

	internal static bool txNMH8hH8hoxV1JHHhMy()
	{
		return C7fAJjhHvrcBxXfFvE1k == null;
	}

	internal static PublicApiCustomMethodsNodeProvider zesDsshHZexGeBkakvDK()
	{
		return C7fAJjhHvrcBxXfFvE1k;
	}

	internal static Type wMgUhqhHuuPB63XE0Pnq(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static object AdPjJ9hHI3C31Y6oSNGq(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type Ex9DKnhHVekDovts2Zs5(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object O1ULM1hHSohOIkTr3QSL(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object ohZ2XwhHiheX9YswC3l2(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).MemberAccessExpression((ISyntaxNode)P_1);
	}
}
