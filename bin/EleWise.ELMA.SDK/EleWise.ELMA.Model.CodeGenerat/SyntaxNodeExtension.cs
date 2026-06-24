using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;

namespace EleWise.ELMA.Model.CodeGeneration;

public static class SyntaxNodeExtension
{
	private static SyntaxNodeExtension gHMwkWheYIPAkU7aXIOt;

	public static ISyntaxNode If(this ISyntaxNode syntaxNode, bool condition, Func<ISyntaxNode, ISyntaxNode> builder)
	{
		if (condition)
		{
			syntaxNode = builder(syntaxNode);
		}
		return syntaxNode;
	}

	public static ISyntaxNode Pack(this SyntaxNode syntaxNode)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (syntaxNode == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new SyntaxNodeContainer(syntaxNode);
			default:
				return null;
			}
		}
	}

	public static ISyntaxNode Pack(this ISyntaxNode syntaxNodeContainer, SyntaxNode syntaxNode)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				VML29shes86heR6MXIkM((SyntaxNodeContainer)syntaxNodeContainer, syntaxNode);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return syntaxNodeContainer;
			}
		}
	}

	public static IEnumerable<ISyntaxNode> Pack(this IEnumerable<SyntaxNode> syntaxNodes)
	{
		return syntaxNodes?.Select(Pack);
	}

	public static SyntaxNode Unpack(this ISyntaxNode syntaxNode)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (syntaxNode == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (SyntaxNode)Ers7qAhecgaT9UPp4k3O((SyntaxNodeContainer)syntaxNode);
			default:
				return null;
			}
		}
	}

	public static T Unpack<T>(this ISyntaxNode syntaxNode) where T : SyntaxNode
	{
		if (syntaxNode == null)
		{
			return null;
		}
		return (T)syntaxNode.Unpack();
	}

	public static IEnumerable<SyntaxNode> Unpack(this IEnumerable<ISyntaxNode> syntaxNodes)
	{
		return syntaxNodes?.Select(Unpack);
	}

	public static IEnumerable<T> Unpack<T>(this IEnumerable<ISyntaxNode> syntaxNodes) where T : SyntaxNode
	{
		return syntaxNodes?.Unpack().Cast<T>();
	}

	public static IEnumerable<StatementSyntax> UnpackStatements(this IEnumerable<ISyntaxNode> syntaxNodes)
	{
		return syntaxNodes?.Where((ISyntaxNode n) => n != null).Select(Unpack).Select(delegate(SyntaxNode n)
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = n as StatementSyntax;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (StatementSyntax)_003C_003Ec.sHNJwNvutAoMNmuDnDtX(_003C_003Ec.xONuqQvuDiYvSF4sqNwZ(), (ExpressionSyntax)n);
					break;
				}
				break;
			}
			return (StatementSyntax)obj;
		});
	}

	internal static bool SjdhGTheL0bNo4rKEnpn()
	{
		return gHMwkWheYIPAkU7aXIOt == null;
	}

	internal static SyntaxNodeExtension EB6ACuheUxgJTsVVXGgY()
	{
		return gHMwkWheYIPAkU7aXIOt;
	}

	internal static void VML29shes86heR6MXIkM(object P_0, object P_1)
	{
		((SyntaxNodeContainer)P_0).SyntaxNode = (SyntaxNode)P_1;
	}

	internal static object Ers7qAhecgaT9UPp4k3O(object P_0)
	{
		return ((SyntaxNodeContainer)P_0).SyntaxNode;
	}
}
