using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiRootNode : IPublicApiNode
{
	public const string Namespace = "EleWise.ELMA.API";

	public const string Path = "PublicAPI";

	internal static PublicApiRootNode ErRYQnh7hDYPdXbghNGG;

	public string ParentPath => (string)WEXL66h7QXhRjm6FR5a3(--1867379187 ^ 0x6F4CE3D5);

	string IPublicApiNode.Path => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978553374);

	internal PublicApiRootNode()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k6uq2Xh7f8ShpfAG2RKs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ISyntaxNode Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.tree = tree;
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20270869).NamespaceDeclaration(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92C69C5).ClassDeclaration(Accessibility.Public, DeclarationModifiers.Sealed, null, null, SyntaxGeneratorExtensions.ConstructorDeclaration(Accessibility.Private).Concat(CS_0024_003C_003E8__locals0.tree[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76EAF9E)].SelectMany((IPublicApiNode n) => n.Generate(CS_0024_003C_003E8__locals0.tree)))).AddAttributes(TypeOf<ShowDefaultMethodsAttribute>.Raw.CreateAttribute(false))
			.XmlComments(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671893937)).SummaryComment()));
	}

	IEnumerable<ISyntaxNode> IPublicApiNode.Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		throw new NotImplementedException();
	}

	internal static void k6uq2Xh7f8ShpfAG2RKs()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ELadLOh7Gxsxr09dIjmu()
	{
		return ErRYQnh7hDYPdXbghNGG == null;
	}

	internal static PublicApiRootNode ydpeRsh7ER9mrHALQORw()
	{
		return ErRYQnh7hDYPdXbghNGG;
	}

	internal static object WEXL66h7QXhRjm6FR5a3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
