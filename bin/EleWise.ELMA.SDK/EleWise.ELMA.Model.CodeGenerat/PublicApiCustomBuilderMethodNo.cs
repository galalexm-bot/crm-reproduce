using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiCustomBuilderMethodNode : IPublicApiNode
{
	private readonly string methodName;

	private readonly string @namespace;

	private readonly string className;

	private readonly string summaryComment;

	private readonly List<(string Name, Type Type, string Description)> parameters;

	private string obsoleteMessage;

	private bool obsoleteError;

	private static PublicApiCustomBuilderMethodNode C1XgFQhHWwacXUYmiAn8;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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

	public string Path => @namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CB667) + className;

	public string Namespace => (string)yqxlP9hHhxRUehZRTs84(-2099751081 ^ -2099568147) + @namespace;

	public PublicApiCustomBuilderMethodNode(string parentPath, string methodName, string @namespace, string className, string summaryComment)
	{
		//Discarded unreachable code: IL_001e
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				this.summaryComment = summaryComment;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				this.className = className;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				this.methodName = methodName;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				parameters = new List<(string, Type, string)>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				this.@namespace = @namespace;
				num2 = 5;
				break;
			case 3:
				ParentPath = parentPath;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	IEnumerable<ISyntaxNode> IPublicApiNode.Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		return new ISyntaxNode[1] { PublicApiNodeGenerate() };
	}

	public ISyntaxNode Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		_003C_003Ec__DisplayClass18_4 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		if (!PublicApiCodeGenerator.Current.AddIfNotExists(Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921196793) + className))
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.builderNodes = tree[Path].OfType<PublicApiCustomBuilderNode>().ToArray();
		if (CS_0024_003C_003E8__locals0.builderNodes.Length == 0)
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.builderField = ((CS_0024_003C_003E8__locals0.builderNodes.Length > 1) ? ((Func<int, string>)((int i) => (string)_003C_003Ec.fVx9DhvPiRwDUgtpBkFp(_003C_003Ec.LndUt8vPSjmrHOdniwHK(--1867379187 ^ 0x6F48B083), i))) : ((Func<int, string>)((int i) => (string)_003C_003Ec.LndUt8vPSjmrHOdniwHK(0x638095EB ^ 0x6385D49B))));
		CS_0024_003C_003E8__locals0.method = delegate(Type builderType, string field, MethodInfo methodInfo)
		{
			//Discarded unreachable code: IL_0065, IL_0074, IL_0084, IL_00ae, IL_00bd, IL_011f, IL_012e, IL_013e, IL_0189
			int num3 = 8;
			List<ISyntaxNode> list = default(List<ISyntaxNode>);
			ISyntaxNode syntaxNode = default(ISyntaxNode);
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 12:
					case 15:
						if (!_003C_003Ec.x797uZvPOj8inFWfDHTL(_003C_003Ec.JbAf6xvPntfEQFHDlCfj(methodInfo), builderType))
						{
							num4 = 14;
							continue;
						}
						break;
					case 9:
					case 14:
						list.Add((ISyntaxNode)_003C_003Ec.OeBd3ovP2XTIJTWYv4Sx(_003C_003Ec.t7fwPgvPPY0vXZgFFECW(syntaxNode, ((PublicApiCodeGenerator)_003C_003Ec.KlN3W5vPeEc28583tJwc()).GetCodeTypeReference(methodInfo.ReturnType, (IList<TypeArgument>)null))));
						num4 = 3;
						continue;
					default:
						if (!(_003C_003Ec.JbAf6xvPntfEQFHDlCfj(methodInfo) == TypeOf.Void.Raw))
						{
							num4 = 15;
							continue;
						}
						goto case 2;
					case 16:
						break;
					case 8:
						list = new List<ISyntaxNode>();
						num4 = 7;
						continue;
					case 4:
						if (!_003C_003Ec.wAtpZQvPTjfb0OkeeekV())
						{
							num4 = 13;
							continue;
						}
						goto case 10;
					case 2:
						list.Add(syntaxNode);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num4 = 0;
						}
						continue;
					case 10:
						list.Add((ISyntaxNode)_003C_003Ec.DJFWCXvPkkT4BVoVkfeH());
						num4 = 11;
						continue;
					case 6:
						list.Add((ISyntaxNode)_003C_003Ec.OeBd3ovP2XTIJTWYv4Sx(_003C_003Ec.Wi2Ub5vPRwI9TqB3pc6H()));
						num4 = 5;
						continue;
					case 7:
						syntaxNode = ((ISyntaxNode)_003C_003Ec.k69gsQvPXc9eAiyaIKdn(_003C_003Ec.dpS9M1vPqwa9es0XbNeO(_003C_003Ec.Wi2Ub5vPRwI9TqB3pc6H(), field.IdentifierName()), _003C_003Ec.WAcoZBvPKLgqVTguYsyu(methodInfo))).InvocationExpression(from p in methodInfo.GetParameters()
							select (ISyntaxNode)_003C_003Ec.z8UhOevP4cjVRsR76TLF(_003C_003Ec.XS3xvvvPtkR6jbKsG1Nx(p), _003C_003Ec.rDkG0PvPw1UOj1ZEZ83a(p)));
						num4 = 4;
						continue;
					case 1:
					case 3:
					case 5:
					case 11:
						return methodInfo.Name.MethodDeclaration(methodInfo.GetParameters().Select(delegate(ParameterInfo p)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								case 1:
									if (_003C_003Ec.ARwiOevP6PC79qwlvDaG(p, TypeOf<ParamArrayAttribute>.Raw))
									{
										return (ISyntaxNode)_003C_003Ec.LM29w6vPxiitqoSZENa6(((string)_003C_003Ec.DxW7CuvP7CwmRi5qtVpn(p)).ParameterDeclaration(PublicApiCodeGenerator.Current.GetCodeTypeReference(p.ParameterType)));
									}
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
									{
										num6 = 0;
									}
									break;
								default:
									return p.Name.ParameterDeclaration((ISyntaxNode)_003C_003Ec.dBagV8vPAxpjdX6fK9e1(_003C_003Ec.o2sIj4vPHIevH4vg0sUr(p)));
								}
							}
						}), _003C_003Ec.uPM0TvvP1Okr2m87NWQE(methodInfo) ? ((IEnumerable<Type>)_003C_003Ec.GUOfXUvPNU5Cd9KwAUNj(methodInfo)).Select((Type t) => (string)_003C_003Ec.WAcoZBvPKLgqVTguYsyu(t)) : null, (ISyntaxNode)(((string)_003C_003Ec.WAcoZBvPKLgqVTguYsyu(_003C_003Ec.JbAf6xvPntfEQFHDlCfj(methodInfo)) == builderType.Name) ? _003C_003Ec.q3YtTOvPDKBa7f5pAO4V(_003C_003Ec.zdt2e0vPa101tJTCMDqw(_003C_003Ec.WAcoZBvPKLgqVTguYsyu(builderType), _003C_003Ec.LndUt8vPSjmrHOdniwHK(-1886646897 ^ -1886795567))) : (_003C_003Ec.OPkvD6vPpJVkPqjBrooJ(_003C_003Ec.JbAf6xvPntfEQFHDlCfj(methodInfo), _003C_003Ec.Td9YPnvP3CldY30k2na5(TypeOf.Void)) ? ((PublicApiCodeGenerator)_003C_003Ec.KlN3W5vPeEc28583tJwc()).GetCodeTypeReference(_003C_003Ec.JbAf6xvPntfEQFHDlCfj(methodInfo), (IList<TypeArgument>)null) : null)), Accessibility.Public, DeclarationModifiers.None, list).XmlComments(methodInfo.GetFullCommentsTrivia());
					}
					break;
				}
				list.Add(syntaxNode);
				num3 = 6;
			}
		};
		return className.ClassDeclaration(Accessibility.Public, DeclarationModifiers.None, null, null, CS_0024_003C_003E8__locals0.builderNodes.Select((PublicApiCustomBuilderNode builderNode, int i) => CS_0024_003C_003E8__locals0.builderField(i).FieldDeclaration((ISyntaxNode)_003C_003Ec__DisplayClass18_0.HpaIvIveU3mbiK0uF0ve(builderNode.BuilderType), Accessibility.Private)).Concat(CS_0024_003C_003E8__locals0.builderNodes.First().BuilderType.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).Select(delegate(ConstructorInfo ctor)
		{
			//Discarded unreachable code: IL_006b, IL_007a, IL_0168
			int num = 2;
			int num2 = num;
			IEnumerable<ISyntaxNode> enumerable2 = default(IEnumerable<ISyntaxNode>);
			_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_1);
			IEnumerable<ISyntaxNode> statements = default(IEnumerable<ISyntaxNode>);
			while (true)
			{
				IEnumerable<ISyntaxNode> enumerable;
				switch (num2)
				{
				case 7:
					enumerable2 = new ISyntaxNode[1] { SyntaxGeneratorExtensions.ThrowNotImplementedStatement() };
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass18_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (_003C_003Ec__DisplayClass18_0.QhGPPTvesO3btGJwx0F9())
					{
						num2 = 7;
						break;
					}
					goto default;
				case 2:
					_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_1();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					_003C_003Ec__DisplayClass18_.parameters = from p in ctor.GetParameters()
						select (p.Name, p.ParameterType);
					num2 = 3;
					break;
				default:
					enumerable = from i in CS_0024_003C_003E8__locals0.builderNodes.Aggregate(new List<(Type, ISyntaxNode)>(), _003C_003Ec__DisplayClass18_._003CGenerate_003Eb__10)
						select i.SyntaxNode;
					goto IL_016f;
				case 6:
					enumerable = enumerable2;
					goto IL_016f;
				case 4:
					{
						return SyntaxGeneratorExtensions.ConstructorDeclaration(_003C_003Ec__DisplayClass18_.parameters.Select(((string Name, Type Type) p) => p.Name.ParameterDeclaration(PublicApiCodeGenerator.Current.GetCodeTypeReference(p.Type))), Accessibility.Public, DeclarationModifiers.None, null, statements).XmlComments(ctor.GetFullCommentsTrivia());
					}
					IL_016f:
					statements = enumerable;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		})).Concat(CS_0024_003C_003E8__locals0.builderNodes.SelectMany(delegate(PublicApiCustomBuilderNode builderNode, int i)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_4();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.builderNode = builderNode;
			CS_0024_003C_003E8__locals0.i = i;
			return from methodInfo in CS_0024_003C_003E8__locals0.builderNode.BuilderType.GetMethods(BindingFlags.Instance | BindingFlags.Public)
				where _003C_003Ec.OPkvD6vPpJVkPqjBrooJ(_003C_003Ec.ci5dmivP088Xf2URInaS(methodInfo), TypeOf<object>.Raw)
				select CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.method(CS_0024_003C_003E8__locals0.builderNode.BuilderType, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.builderField(CS_0024_003C_003E8__locals0.i), methodInfo);
		}))).MakeClassHide();
	}

	public PublicApiCustomBuilderMethodNode Obsolete(string obsoleteMessage, bool obsoleteError = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return this;
			case 1:
				this.obsoleteMessage = obsoleteMessage;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				this.obsoleteError = obsoleteError;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public PublicApiCustomBuilderMethodNode Parameter<T>(string name, string description)
	{
		parameters.Add((name, TypeOf<T>.Raw, description));
		return this;
	}

	protected virtual ISyntaxNode PublicApiNodeGenerate()
	{
		//Discarded unreachable code: IL_00d9
		int num = 2;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		IEnumerable<ISyntaxNode> statements = default(IEnumerable<ISyntaxNode>);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				syntaxNode = (ISyntaxNode)fyBy3ahHEOSyrDiWgTvf(OySEqdhHGcg3PIEsYDpC(Namespace, yqxlP9hHhxRUehZRTs84(-2112703338 ^ -2112704942), className));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!qEdAhQhHfDuxSxJlg12T())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				}
				obj = new ISyntaxNode[1] { (ISyntaxNode)ebo6y1hHCFo8x0cslGa2() };
				goto IL_00ec;
			default:
				obj = new ISyntaxNode[1] { (ISyntaxNode)uWFXPUhHQxTvkBpSwGOE(syntaxNode.ObjectCreationExpression(parameters.Select(((string Name, Type Type, string Description) p) => p.Name.IdentifierName()))) };
				goto IL_00ec;
			case 3:
				{
					return methodName.MethodDeclaration(parameters.Select(((string Name, Type Type, string Description) p) => p.Name.ParameterDeclaration(PublicApiCodeGenerator.Current.GetCodeTypeReference(p.Type))), null, syntaxNode, Accessibility.Public, DeclarationModifiers.Virtual, statements).If(obsoleteMessage != null, (ISyntaxNode b) => b.AddAttributes(SyntaxGeneratorExtensions.CreateAttribute<ObsoleteAttribute>(new object[2] { obsoleteMessage, obsoleteError }))).XmlComments(summaryComment?.SummaryComment().Concat(parameters.Select(delegate((string Name, Type Type, string Description) p)
					{
						string text = p.Type.ParameterPath();
						return (z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6254FE) + p.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123690208) + p.Description + ((text != null) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317973032) : "") + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F1A4F)).SplittedComment();
					})));
				}
				IL_00ec:
				statements = (IEnumerable<ISyntaxNode>)obj;
				num2 = 3;
				break;
			}
		}
	}

	internal static bool tAtaSehHoT4s0VBXseHC()
	{
		return C1XgFQhHWwacXUYmiAn8 == null;
	}

	internal static PublicApiCustomBuilderMethodNode XLWO18hHbX75ia3IEnG6()
	{
		return C1XgFQhHWwacXUYmiAn8;
	}

	internal static object yqxlP9hHhxRUehZRTs84(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OySEqdhHGcg3PIEsYDpC(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object fyBy3ahHEOSyrDiWgTvf(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static bool qEdAhQhHfDuxSxJlg12T()
	{
		return PublicApiCodeGenerator.PublicApiNoImplementation;
	}

	internal static object uWFXPUhHQxTvkBpSwGOE(object P_0)
	{
		return ((ISyntaxNode)P_0).ReturnStatement();
	}

	internal static object ebo6y1hHCFo8x0cslGa2()
	{
		return SyntaxGeneratorExtensions.ThrowNotImplementedStatement();
	}
}
