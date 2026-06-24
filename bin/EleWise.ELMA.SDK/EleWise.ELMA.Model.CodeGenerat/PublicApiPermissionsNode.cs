using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiPermissionsNode<T> : IPublicApiNode, IPublicApiPermissionsNode where T : IPermissionProvider
{
	internal static object ojunaNhAnw69JWdmElFq;

	public string ParentPath
	{
		[CompilerGenerated]
		get
		{
			return _003CParentPath_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CParentPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	string IPublicApiNode.Path
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	Type IPublicApiPermissionsNode.Type => TypeOf<T>.Raw;

	public PublicApiPermissionsNode(string parentPath)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
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
				ParentPath = parentPath;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		if (!PublicApiCodeGenerator.Current.AddIfNotExists(ParentPath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70206745)))
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		return (from d in tree[ParentPath].OfType<IPublicApiPermissionsNode>().SelectMany(delegate(IPublicApiPermissionsNode n)
			{
				_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
				CS_0024_003C_003E8__locals0.n = n;
				return from f in CS_0024_003C_003E8__locals0.n.Type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField)
					select (CS_0024_003C_003E8__locals0.n.Type, f.Name, f.GetValue(null) as Permission, AttributeHelper<ObsoleteAttribute>.GetAttribute(f, inherited: false));
			})
			where d.Permission != null
			select d).Select<(Type, string, Permission, ObsoleteAttribute), ISyntaxNode>(delegate((Type Type, string Name, Permission Permission, ObsoleteAttribute ObsoleteAttribute) d)
		{
			_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_1();
			CS_0024_003C_003E8__locals0.d = d;
			return CS_0024_003C_003E8__locals0.d.Name.PropertyDeclaration(TypeOf<Permission>.Raw.CreateTypeSyntax(), Accessibility.Public, DeclarationModifiers.None, new ISyntaxNode[1] { CS_0024_003C_003E8__locals0.d.Type.CreateTypeSyntax().MemberAccessExpression(CS_0024_003C_003E8__locals0.d.Name).ReturnStatement() }).If(CS_0024_003C_003E8__locals0.d.ObsoleteAttribute != null, (ISyntaxNode p) => p.AddAttributes(TypeOf<ObsoleteAttribute>.Raw.CreateAttribute(CS_0024_003C_003E8__locals0.d.ObsoleteAttribute.Message, CS_0024_003C_003E8__locals0.d.ObsoleteAttribute.IsError), TypeOf<BrowsableAttribute>.Raw.CreateAttribute(false))).XmlComments(SR.T(CS_0024_003C_003E8__locals0.d.Permission.Name).SummaryComment());
		});
	}

	internal static bool GvL0GkhAORETU4YvIHdV()
	{
		return ojunaNhAnw69JWdmElFq == null;
	}

	internal static object fMwmO4hA2uvLe5KLDs5l()
	{
		return ojunaNhAnw69JWdmElFq;
	}
}
