using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiEntityFilterHelperNode : IPublicApiNode
{
	private bool isDelta;

	private readonly ISyntaxNode[] notImplStatements;

	private readonly Dictionary<Guid, string> _objectTypes;

	private static PublicApiEntityFilterHelperNode w0I4EihHR8nxvbeLwURn;

	internal EntityMetadata EntityMetadata { get; }

	public string ParentPath => (string)gTAEaZhH1X3NsImWRHXf();

	string IPublicApiNode.Path
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public PublicApiEntityFilterHelperNode([NotNull] EntityMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_0136
		h4aOT9hHXSUdH3DT4uBq();
		notImplStatements = ((!Qj8nibhHT94YudPeiXcC()) ? null : new ISyntaxNode[1] { (ISyntaxNode)jJU7IXhHkCUGBGUgj9by() });
		_objectTypes = new Dictionary<Guid, string>
		{
			{
				new Guid((string)ddhRLChHnTebe2B1ojB0(-672123589 ^ -671923677)),
				(string)MIpegbhHOk23RWDvMWWw(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571C3D37))
			},
			{
				new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538595470)),
				(string)MIpegbhHOk23RWDvMWWw(ddhRLChHnTebe2B1ojB0(0x1C9495B4 ^ 0x1C961A06))
			},
			{
				new Guid((string)ddhRLChHnTebe2B1ojB0(-105199646 ^ -105271214)),
				(string)MIpegbhHOk23RWDvMWWw(ddhRLChHnTebe2B1ojB0(0x103FE975 ^ 0x103C9E89))
			},
			{
				new Guid((string)ddhRLChHnTebe2B1ojB0(-3333094 ^ -3253248)),
				SR.T((string)ddhRLChHnTebe2B1ojB0(0x31326106 ^ 0x31311960))
			}
		};
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				if (oJ47DThH2BKB7gkxDqmH(entityMetadata) == EntityMetadataType.InterfaceExtension)
				{
					int num2 = 5;
					num = num2;
					break;
				}
				goto case 1;
			case 2:
				entityMetadata = (EntityMetadata)((PublicApiCodeGenerator)b3wmh0hHegOOPeaegRoC()).GetMetadata(KBuBOYhHPEieZ92T7dCw(entityMetadata), loadImplementation: false);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				entityMetadata = (EntityMetadata)((PublicApiCodeGenerator)b3wmh0hHegOOPeaegRoC()).GetMetadata(entityMetadata.BaseClassUid, loadImplementation: false);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num = 0;
				}
				break;
			default:
				EntityMetadata = entityMetadata;
				num = 4;
				break;
			case 4:
				return;
			case 1:
				if (oJ47DThH2BKB7gkxDqmH(entityMetadata) == EntityMetadataType.Interface)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num = 2;
					}
					break;
				}
				goto default;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerate_003Ed__11))]
	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerate_003Ed__11(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__tree = tree
		};
	}

	internal static bool CalculateType(PropertyMetadata prop, ref ISyntaxNode codeTypeReference, string @namespace, IDictionary<string, IEnumerable<IPublicApiNode>> tree = null, List<ISyntaxNode> additionalTypes = null, List<ISyntaxNode> members = null, List<ISyntaxNode> membersImpl = null, ISyntaxNode codeCast = null, ISyntaxNode returnType = null, ISyntaxNode returnTypeImpl = null, ISyntaxNode returnThis = null, ISyntaxNode[] addObsoleteAttributes = null, ISyntaxTrivia summaryComment = null, ISyntaxTrivia paramMethodSummary = null, ISyntaxTrivia paramComment = null)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.prop = prop;
		ISyntaxNode[] array = ((!PublicApiCodeGenerator.PublicApiNoImplementation) ? null : new ISyntaxNode[1] { SyntaxGeneratorExtensions.ThrowNotImplementedStatement() });
		string text = CS_0024_003C_003E8__locals0.prop.Name.ToLowerFirstChar();
		bool result = false;
		if (CS_0024_003C_003E8__locals0.prop.Settings is EntitySettings entitySettings)
		{
			if (entitySettings.GenerateFilterInFilter)
			{
				ISyntaxNode syntaxNode = (codeTypeReference.IsGeneric() ? codeTypeReference.GetGenericArguments().First() : codeTypeReference);
				string text2 = string.Concat(syntaxNode, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CEF9F));
				codeTypeReference = text2.CreateTypeSyntax();
				if (members != null)
				{
					string text3 = text2.Substring(text2.LastIndexOf('.') + 1) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A6AD6F);
					if (tree != null && !tree[PublicApiFilterHelpers.Path].OfType<PublicApiEntityFilterHelperNode>().Any((PublicApiEntityFilterHelperNode n) => _003C_003Ec__DisplayClass12_0.W4MLGLvNbZMKuV9Bwsid(n.EntityMetadata.ImplementationUid, _003C_003Ec__DisplayClass12_0.HvXyWlvNo9F3EVWSB7C5(CS_0024_003C_003E8__locals0.prop))) && PublicApiCodeGenerator.Current.AddIfNotExists(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309838036) + text3))
					{
						EntityMetadata entityMetadata = (EntityMetadata)PublicApiCodeGenerator.Current.GetMetadata(CS_0024_003C_003E8__locals0.prop.SubTypeUid);
						ISyntaxNode propertyTypeReference = ((ITypeGenerationInfo)MetadataServiceContext.Service.GetIdTypeDescriptor(entityMetadata.IdTypeUid)).GetPropertyTypeReference(entityMetadata, null, forFilter: false);
						additionalTypes.Add(text3.ClassDeclaration(Accessibility.Public, DeclarationModifiers.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921007765).CreateTypeSyntax(syntaxNode, propertyTypeReference, codeTypeReference, text3.CreateTypeSyntax())).MakeClassHide());
					}
					ISyntaxNode syntaxNode2 = text3.CreateTypeSyntax(useGlobal: false);
					ISyntaxNode type = TypeOf.Func2.Raw.CreateTypeSyntax(syntaxNode2, syntaxNode2);
					members.Add(CS_0024_003C_003E8__locals0.prop.Name.MethodDeclaration(new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103C91A5).ParameterDeclaration(type) }, null, returnType, Accessibility.Public, DeclarationModifiers.None, array ?? new ISyntaxNode[3]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921007825).LocalDeclarationStatement(syntaxNode2.ObjectCreationExpression()),
						codeCast.AssignmentStatement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C50402F).IdentifierName().InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978521625).IdentifierName())
							.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334976717))),
						returnThis.ReturnStatement()
					}).XmlComments(summaryComment, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978553862), SR.T(CS_0024_003C_003E8__locals0.prop.DisplayName)).SplittedComment()));
					membersImpl.Add(CS_0024_003C_003E8__locals0.prop.Name.MethodDeclaration(new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53C83E9B).ParameterDeclaration(type) }, null, returnTypeImpl, Accessibility.Public, DeclarationModifiers.New, new ISyntaxNode[1] { SyntaxGeneratorExtensions.Base.MemberAccessExpression(CS_0024_003C_003E8__locals0.prop.Name).InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571DDB49).IdentifierName()).ReturnStatement() }).XmlComments(summaryComment, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87544449), SR.T(CS_0024_003C_003E8__locals0.prop.DisplayName)).SplittedComment()));
				}
			}
			else if (entitySettings.RelationType != 0)
			{
				result = true;
				codeTypeReference = codeTypeReference.GetGenericArguments().First().CreateArrayTypeSyntax();
			}
			else if (entitySettings.GenerateListInFilter)
			{
				result = true;
				codeTypeReference = codeTypeReference.CreateArrayTypeSyntax();
			}
		}
		else
		{
			DateTimeSettings obj = CS_0024_003C_003E8__locals0.prop.Settings as DateTimeSettings;
			if (obj != null && obj.RelativeInFilter && CS_0024_003C_003E8__locals0.prop is EntityPropertyMetadata)
			{
				codeTypeReference = TypeOf<RelativeDateTime>.Raw.CreateTypeSyntax();
			}
			else
			{
				DateTimeSettings obj2 = CS_0024_003C_003E8__locals0.prop.Settings as DateTimeSettings;
				if (obj2 != null && obj2.RangeInFilter && CS_0024_003C_003E8__locals0.prop is EntityPropertyMetadata)
				{
					codeTypeReference = TypeOf<DateTimeRange>.Raw.CreateTypeSyntax();
				}
				else
				{
					Int64Settings obj3 = CS_0024_003C_003E8__locals0.prop.Settings as Int64Settings;
					if (obj3 != null && obj3.RangeInFilter && CS_0024_003C_003E8__locals0.prop is EntityPropertyMetadata)
					{
						codeTypeReference = TypeOf<Int64Range>.Raw.CreateTypeSyntax();
					}
					else
					{
						Int32Settings obj4 = CS_0024_003C_003E8__locals0.prop.Settings as Int32Settings;
						if (obj4 != null && obj4.RangeInFilter && CS_0024_003C_003E8__locals0.prop is EntityPropertyMetadata)
						{
							codeTypeReference = TypeOf<Int32Range>.Raw.CreateTypeSyntax();
						}
						else
						{
							Int16Settings obj5 = CS_0024_003C_003E8__locals0.prop.Settings as Int16Settings;
							if (obj5 != null && obj5.RangeInFilter && CS_0024_003C_003E8__locals0.prop is EntityPropertyMetadata)
							{
								codeTypeReference = TypeOf<Int16Range>.Raw.CreateTypeSyntax();
							}
							else
							{
								DoubleSettings obj6 = CS_0024_003C_003E8__locals0.prop.Settings as DoubleSettings;
								if (obj6 != null && obj6.RangeInFilter)
								{
									codeTypeReference = TypeOf<DoubleRange>.Raw.CreateTypeSyntax();
								}
								else
								{
									MoneySettings obj7 = CS_0024_003C_003E8__locals0.prop.Settings as MoneySettings;
									if (obj7 != null && obj7.RangeInFilter)
									{
										codeTypeReference = TypeOf<MoneyRange>.Raw.CreateTypeSyntax();
									}
									else if (CS_0024_003C_003E8__locals0.prop.Settings is ListOfSimpleTypeSettings)
									{
										if (members != null)
										{
											ISyntaxNode syntaxNode3 = codeTypeReference.GetGenericArguments().First();
											members.Add(CS_0024_003C_003E8__locals0.prop.Name.MethodDeclaration(new ISyntaxNode[1] { text.ParameterDeclaration(syntaxNode3.CreateArrayTypeSyntax()).WithParamsModifier() }, null, returnType, Accessibility.Public, DeclarationModifiers.None, array ?? new ISyntaxNode[3]
											{
												codeCast.ValueEqualsExpression(SyntaxGeneratorExtensions.Null).IfStatement(new ISyntaxNode[1] { codeCast.AssignmentStatement(TypeOf.List.Raw.CreateTypeSyntax(syntaxNode3).ObjectCreationExpression()) }),
												codeCast.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106429878)).InvocationExpression(text.IdentifierName()),
												returnThis.ReturnStatement()
											}).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment));
											membersImpl.Add(CS_0024_003C_003E8__locals0.prop.Name.MethodDeclaration(new ISyntaxNode[1] { text.ParameterDeclaration(syntaxNode3.CreateArrayTypeSyntax()).WithParamsModifier() }, null, returnTypeImpl, Accessibility.Public, DeclarationModifiers.New, new ISyntaxNode[1] { SyntaxGeneratorExtensions.Base.MemberAccessExpression(CS_0024_003C_003E8__locals0.prop.Name).InvocationExpression(text.IdentifierName()).ReturnStatement() }).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment));
										}
									}
									else if (CS_0024_003C_003E8__locals0.prop.Settings is AnyTypeSettings)
									{
										ISyntaxNode syntaxNode4 = ((AnyTypeSettings)CS_0024_003C_003E8__locals0.prop.Settings).FullTypeName.CreateTypeSyntax();
										if (syntaxNode4.GetGenericIdentifier() == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767784359) || syntaxNode4.GetGenericIdentifier() == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x202563AB))
										{
											ISyntaxNode syntaxNode5 = syntaxNode4.GetGenericArguments().First();
											string text4 = syntaxNode5.ToString();
											codeTypeReference = ((text4 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538598880) || text4.ToString().Contains('.')) ? syntaxNode4 : TypeOf.List.Raw.CreateTypeSyntax((@namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604) + text4).CreateTypeSyntax()));
											if (members != null)
											{
												members.Add(CS_0024_003C_003E8__locals0.prop.Name.MethodDeclaration(new ISyntaxNode[1] { text.ParameterDeclaration((text4 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740544542) || text4.ToString().Contains('.')) ? syntaxNode5.CreateArrayTypeSyntax() : (@namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA1A0A) + text4).CreateTypeSyntax().CreateArrayTypeSyntax()).WithParamsModifier() }, null, returnType, Accessibility.Public, DeclarationModifiers.None, array ?? new ISyntaxNode[3]
												{
													codeCast.ValueEqualsExpression(SyntaxGeneratorExtensions.Null).IfStatement(new ISyntaxNode[1] { codeCast.AssignmentStatement(codeTypeReference.ObjectCreationExpression()) }),
													codeCast.MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87544327)).InvocationExpression(text.IdentifierName()),
													returnThis.ReturnStatement()
												}).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment));
												membersImpl.Add(CS_0024_003C_003E8__locals0.prop.Name.MethodDeclaration(new ISyntaxNode[1] { text.ParameterDeclaration((text4 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A82C382) || text4.ToString().Contains('.')) ? syntaxNode5.CreateArrayTypeSyntax() : (@namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521271676) + text4).CreateTypeSyntax().CreateArrayTypeSyntax()).WithParamsModifier() }, null, returnTypeImpl, Accessibility.Public, DeclarationModifiers.New, new ISyntaxNode[1] { SyntaxGeneratorExtensions.Base.MemberAccessExpression(CS_0024_003C_003E8__locals0.prop.Name).InvocationExpression(text.IdentifierName()).ReturnStatement() }).AddAttributes(addObsoleteAttributes).XmlComments(summaryComment, paramMethodSummary, paramComment));
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return result;
	}

	internal void SetIsDelta()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				isDelta = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void h4aOT9hHXSUdH3DT4uBq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Qj8nibhHT94YudPeiXcC()
	{
		return PublicApiCodeGenerator.PublicApiNoImplementation;
	}

	internal static object jJU7IXhHkCUGBGUgj9by()
	{
		return SyntaxGeneratorExtensions.ThrowNotImplementedStatement();
	}

	internal static object ddhRLChHnTebe2B1ojB0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MIpegbhHOk23RWDvMWWw(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static EntityMetadataType oJ47DThH2BKB7gkxDqmH(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static object b3wmh0hHegOOPeaegRoC()
	{
		return PublicApiCodeGenerator.Current;
	}

	internal static Guid KBuBOYhHPEieZ92T7dCw(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static bool NMLmjahHqm2gFYhvD9bG()
	{
		return w0I4EihHR8nxvbeLwURn == null;
	}

	internal static PublicApiEntityFilterHelperNode Ah7Z9phHK89r8V4yDAvk()
	{
		return w0I4EihHR8nxvbeLwURn;
	}

	internal static object gTAEaZhH1X3NsImWRHXf()
	{
		return PublicApiFilterHelpers.Path;
	}
}
