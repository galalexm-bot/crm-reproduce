using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components;

internal abstract class AbstractEntitySystemComponentCreator : ISystemComponentCreator
{
	private static readonly Guid EntityPropertyUid;

	internal const string EntityIdProperty = "EntityId";

	internal const string EntityTypeUidProperty = "EntityTypeUid";

	internal const string ParentEntityIdProperty = "ParentEntityId";

	internal const string ParentEntityTypeUidProperty = "ParentEntityTypeUid";

	internal const string HierarchicalProperty = "Hierarchical";

	internal const string IsGroupProperty = "IsGroup";

	internal static AbstractEntitySystemComponentCreator znyihlfoGUfGsPHnLo5e;

	public IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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

	public ScriptModuleManager ScriptModuleManager
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptModuleManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CScriptModuleManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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

	public IComponentAssemblyBuilderService ComponentAssemblyBuilderService
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentAssemblyBuilderService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CComponentAssemblyBuilderService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
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

	public ISearchMetadataService SearchMetadataService
	{
		[CompilerGenerated]
		get
		{
			return _003CSearchMetadataService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CSearchMetadataService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected abstract Guid ComponentUid { get; }

	protected abstract string ComponentMetadataName { get; }

	protected abstract string ComponentDisplayName { get; }

	protected abstract ViewType ViewType { get; }

	public ComponentMetadataItem Create()
	{
		return CreateInternal();
	}

	private ComponentMetadataItem CreateInternal()
	{
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		int num = 12;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		ClassDeclarationSyntax val = default(ClassDeclarationSyntax);
		IUser user = default(IUser);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		ComponentMetadataItemHeader componentMetadataItemHeader = default(ComponentMetadataItemHeader);
		string text = default(string);
		ComponentBuildAssemblyModel componentBuildAssemblyModel = default(ComponentBuildAssemblyModel);
		List<DataClassAssemblyInfo> source = default(List<DataClassAssemblyInfo>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj3;
				switch (num2)
				{
				default:
					((EventedList<ViewItem>)XrKy6JfoVVebn1aZlGKA(componentMetadata.Content.View)).Add((ViewItem)CreateObjectFormViewItem());
					num2 = 27;
					continue;
				case 14:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add((PropertyMetadata)hVagDQfonbGnTNHoFceb());
					num2 = 16;
					continue;
				case 3:
					if (val != null)
					{
						num = 7;
						break;
					}
					goto case 8;
				case 27:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add((PropertyMetadata)YcytbvfoRXqTOgpjYqB8());
					num2 = 15;
					continue;
				case 8:
					user = (IUser)F7i4osfopDkuJGsUn4wK(AuthenticationService);
					num2 = 13;
					continue;
				case 30:
					qNCn5YfoLWqssbMu1yWi(componentMetadataItem, componentMetadataItemHeader);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 2;
					}
					continue;
				case 26:
				{
					ComponentMetadataItemHeader componentMetadataItemHeader2 = new ComponentMetadataItemHeader();
					CZYa2RfomvDiKMmVUBmP(componentMetadataItemHeader2, pAVGuZfo0S0nWldtETDr(componentMetadata));
					BD6LOJfoMyCdh5o3nhwd(componentMetadataItemHeader2, PtgBpjfoykh2aUZJ61hP(componentMetadata));
					SYXpfAfo9IhQmFGcIiU4(componentMetadataItemHeader2, Icu5icfoJXnBdiVCSJlF(componentMetadata));
					gGgvLnfolKiIQ7yUcs7L(componentMetadataItemHeader2, erbbyKfodtnS7CRIwgva(componentMetadata));
					HKmd6UforAIpUBQd8Zsj(componentMetadataItemHeader2, componentMetadata.ModuleUid);
					componentMetadataItemHeader2.CreationAuthorId = componentMetadataItem.CreationAuthorId;
					yIY00rfogMDxn6W3D2ok(componentMetadataItemHeader2, componentMetadataItem.CreationDate);
					componentMetadataItemHeader2.Draft = componentMetadataItem;
					tuA0Z7fo52r7aQIbkoPH(componentMetadataItemHeader2, componentMetadataItem);
					WukmZOfoYyNBcOPLZobO(componentMetadataItemHeader2, NQaZQ9fojZZHiZc4LfPA(componentMetadata));
					componentMetadataItemHeader = componentMetadataItemHeader2;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 30;
					}
					continue;
				}
				case 7:
				{
					string text2 = text;
					SyntaxToken openBraceToken = ((BaseTypeDeclarationSyntax)val).get_OpenBraceToken();
					TextSpan fullSpan = ((SyntaxToken)(ref openBraceToken)).get_FullSpan();
					text = (string)r5oJEIfo3CFi4LbtdaDh(text2, ((TextSpan)(ref fullSpan)).get_End(), sqioyQfoNGI7QikBijGb());
					num2 = 8;
					continue;
				}
				case 22:
					BdJmqmfoUKKS2DePDGLv(ComponentAssemblyBuilderService, componentBuildAssemblyModel);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 20;
					}
					continue;
				case 25:
				{
					ClassDeclarationSyntax obj = ((SyntaxNode)LcypNZfo1wO90cNaVPiU(CSharpSyntaxTree.ParseText(text, (CSharpParseOptions)a5LNmkfoPsIkrvHeX6Dg(cUlX0cfoe55ShqUDAjL2(), (LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)), default(CancellationToken))).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>().ToList()
						.FirstOrDefault(delegate(ClassDeclarationSyntax q)
						{
							//IL_0025: Unknown result type (might be due to invalid IL or missing references)
							//IL_002a: Unknown result type (might be due to invalid IL or missing references)
							int num5 = 1;
							int num6 = num5;
							SyntaxToken val3 = default(SyntaxToken);
							while (true)
							{
								switch (num6)
								{
								case 1:
									val3 = MMKXttfbnYALFDFY2s41(q);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
									{
										num6 = 0;
									}
									break;
								default:
									return jVa9AcfbOmdxFjLH8WYR(((object)(SyntaxToken)(ref val3)).ToString(), fdo6pQfo8B0OCV6uQHZ2(this));
								}
							}
						});
					if (obj == null)
					{
						num2 = 5;
						continue;
					}
					obj2 = ((IEnumerable)(object)((TypeDeclarationSyntax)obj).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax q)
					{
						//IL_004e: Unknown result type (might be due to invalid IL or missing references)
						//IL_0053: Unknown result type (might be due to invalid IL or missing references)
						int num3 = 1;
						int num4 = num3;
						SyntaxToken val2 = default(SyntaxToken);
						while (true)
						{
							switch (num4)
							{
							default:
								return ((object)(SyntaxToken)(ref val2)).ToString() == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70099006);
							case 1:
								val2 = _003C_003Ec.W2pd1o89Kbsvys4WiPrF(q);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					goto IL_0537;
				}
				case 29:
					aS8rnNfoIJQyBqtd4Z5N(componentMetadata, GFHcGlfouHVRMOoYrMpe(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add((PropertyMetadata)ETv5JZfoXZqic2Hf7nMF());
					num2 = 24;
					continue;
				case 4:
					source = SearchMetadataService.GetPublishedDataClassAssemblies().ToList();
					num2 = 28;
					continue;
				case 20:
					return componentMetadataItem;
				case 9:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add((PropertyMetadata)tTFNujfokU8KoqeKBJQO());
					num2 = 14;
					continue;
				case 2:
					if (!e3ux8Nfo2IdspTn8ZwNM(text))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 8;
				case 19:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(componentMetadata.Content)).Properties.Add((PropertyMetadata)N8V2TLfoKfrpEqXatM2k());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add((PropertyMetadata)saOTsEfoqjvhQyXkQvMP());
					num2 = 6;
					continue;
				case 21:
					NVQyd6fovb3uVBndeirl(componentMetadata, qqiPi8foC03Ugh7eCWuk(this));
					num = 17;
					break;
				case 12:
					componentMetadata = new ComponentMetadata(Guid.Empty);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 11;
					}
					continue;
				case 6:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add(CreateEntityProperty());
					num2 = 19;
					continue;
				case 17:
					wttJvvfoZpxNOAZRy6jw(componentMetadata, fdo6pQfo8B0OCV6uQHZ2(this));
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 7;
					}
					continue;
				case 24:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add((PropertyMetadata)bMafbrfoTn7NMTEOomsy());
					num2 = 9;
					continue;
				case 11:
					dtVugsfoQK7I7Viet2IB(componentMetadata);
					num2 = 21;
					continue;
				case 16:
					((ClassMetadata)HUlWkVfoiOEIAbH1ynyk(ooITjSfoSC1gs1K9sHOG(componentMetadata))).Properties.Add((PropertyMetadata)hmOwyjfoOWdZl1Gybc3e());
					num2 = 18;
					continue;
				case 18:
				{
					IScriptModuleType scriptModuleType = ScriptModuleManager.GetScriptModuleType(ComponentClientScriptModuleType.TypeUid);
					if (scriptModuleType == null)
					{
						num2 = 23;
						continue;
					}
					obj3 = scriptModuleType.GenerateSourceCode(componentMetadata);
					goto IL_04d9;
				}
				case 23:
					obj3 = null;
					goto IL_04d9;
				case 10:
					obj3 = string.Empty;
					goto IL_04ef;
				case 5:
					obj2 = null;
					goto IL_0537;
				case 13:
				{
					ComponentMetadataItem componentMetadataItem2 = new ComponentMetadataItem();
					f8yPqQfoDWlDbEyq5LhL(componentMetadataItem2, q1IxisfoacGFQYahAXQA());
					R3nn8ofotxTeCSZwugUA(componentMetadataItem2, componentMetadata);
					componentMetadataItem2.CreationAuthorId = (long?)((user != null) ? jQAaSvfowc9vB02nqgUw(user) : null);
					G57w7efo6ERtk4TaB7qT(componentMetadataItem2, vZedaPfo4vcLIGRpJ4to());
					phcsY1foHJkeJ6nsqP6b(componentMetadataItem2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE12BA));
					componentMetadataItem2.AssemblyName = (string)d06wM9foAk3kg2e6Rxld(componentMetadata);
					componentMetadataItem2.VersionNumber = 1L;
					nV49DnfoxDdWjIpkgJwE(componentMetadataItem2, bK7FhAfo7Q5O34TSrl9P(componentMetadata, text));
					componentMetadataItem = componentMetadataItem2;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 26;
					}
					continue;
				}
				case 28:
					{
						componentBuildAssemblyModel = new ComponentBuildAssemblyModel(componentMetadataItem, Enumerable.Empty<byte[]>(), source.Select((DataClassAssemblyInfo a) => (byte[])_003C_003Ec.bAZkHc89XHw2V78MuAJq(a)), isSystem: true);
						num2 = 22;
						continue;
					}
					IL_04d9:
					if (obj3 == null)
					{
						num2 = 10;
						continue;
					}
					goto IL_04ef;
					IL_04ef:
					text = (string)obj3;
					num2 = 2;
					continue;
					IL_0537:
					val = (ClassDeclarationSyntax)obj2;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	private ObjectFormViewItem CreateObjectFormViewItem()
	{
		ObjectFormViewItem objectFormViewItem = new ObjectFormViewItem();
		yW1YNwfosHg6yHbrZ9n7(objectFormViewItem, q1IxisfoacGFQYahAXQA());
		H8AwNBfozEKkdbG36aul(objectFormViewItem, Gktyjpfocp29nKGmfuqt(0x17ADCCD8 ^ 0x17A8DF98));
		objectFormViewItem.Type = AslFOmfbFpIHdnBdF5ox(this);
		o6qp64fbB0cVJEb5i3Bj(objectFormViewItem, EntityPropertyUid);
		rJTh5DfbWwKWlQYr8iKs(objectFormViewItem, ViewItemLoadingType.AsyncLoading);
		return objectFormViewItem;
	}

	private static ViewModelPropertyMetadata CreateEntityIdProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, q1IxisfoacGFQYahAXQA());
		viewModelPropertyMetadata.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A3C16A);
		viewModelPropertyMetadata.DisplayName = SR.T((string)Gktyjpfocp29nKGmfuqt(-740338220 ^ -740669766));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, Int64Descriptor.UID);
		SJoiwqfbb36s9SBfqmCp(viewModelPropertyMetadata, Guid.Empty);
		eJp8MEfbhbDgqk5sP902(viewModelPropertyMetadata, true);
		viewModelPropertyMetadata.IsSystem = true;
		svrE7vfbGnAts1d6jPIt(viewModelPropertyMetadata, false);
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateEntityTypeUidProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, Guid.NewGuid());
		viewModelPropertyMetadata.Name = (string)Gktyjpfocp29nKGmfuqt(-675505729 ^ -675706335);
		aS8rnNfoIJQyBqtd4Z5N(viewModelPropertyMetadata, wmT44HfbEU6yfHxBk3Fv(Gktyjpfocp29nKGmfuqt(-672123589 ^ -671799673)));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, GuidDescriptor.UID);
		SJoiwqfbb36s9SBfqmCp(viewModelPropertyMetadata, Guid.Empty);
		eJp8MEfbhbDgqk5sP902(viewModelPropertyMetadata, true);
		FjA1Ekfbf0dcnUBWaQLX(viewModelPropertyMetadata, true);
		svrE7vfbGnAts1d6jPIt(viewModelPropertyMetadata, false);
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateHierarchicalProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, q1IxisfoacGFQYahAXQA());
		viewModelPropertyMetadata.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6421B2);
		viewModelPropertyMetadata.DisplayName = (string)wmT44HfbEU6yfHxBk3Fv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978153766));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, BoolDescriptor.UID);
		SJoiwqfbb36s9SBfqmCp(viewModelPropertyMetadata, Guid.Empty);
		eJp8MEfbhbDgqk5sP902(viewModelPropertyMetadata, true);
		FjA1Ekfbf0dcnUBWaQLX(viewModelPropertyMetadata, true);
		svrE7vfbGnAts1d6jPIt(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateParentEntityIdProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, Guid.NewGuid());
		wttJvvfoZpxNOAZRy6jw(viewModelPropertyMetadata, Gktyjpfocp29nKGmfuqt(0x7459E02 ^ 0x7408A44));
		aS8rnNfoIJQyBqtd4Z5N(viewModelPropertyMetadata, wmT44HfbEU6yfHxBk3Fv(Gktyjpfocp29nKGmfuqt(0x34A6D230 ^ 0x34A3C656)));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, Int64Descriptor.UID);
		viewModelPropertyMetadata.SubTypeUid = Guid.Empty;
		eJp8MEfbhbDgqk5sP902(viewModelPropertyMetadata, true);
		viewModelPropertyMetadata.IsSystem = true;
		svrE7vfbGnAts1d6jPIt(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateParentEntityTypeUidProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, q1IxisfoacGFQYahAXQA());
		wttJvvfoZpxNOAZRy6jw(viewModelPropertyMetadata, Gktyjpfocp29nKGmfuqt(0x53FA00CE ^ 0x53FF147E));
		aS8rnNfoIJQyBqtd4Z5N(viewModelPropertyMetadata, wmT44HfbEU6yfHxBk3Fv(Gktyjpfocp29nKGmfuqt(-234299632 ^ -233976660)));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, GuidDescriptor.UID);
		SJoiwqfbb36s9SBfqmCp(viewModelPropertyMetadata, Guid.Empty);
		eJp8MEfbhbDgqk5sP902(viewModelPropertyMetadata, true);
		FjA1Ekfbf0dcnUBWaQLX(viewModelPropertyMetadata, true);
		viewModelPropertyMetadata.Nullable = true;
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateIsGroupProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, q1IxisfoacGFQYahAXQA());
		viewModelPropertyMetadata.Name = (string)Gktyjpfocp29nKGmfuqt(0x7C1EE318 ^ 0x7C1C5008);
		viewModelPropertyMetadata.DisplayName = (string)wmT44HfbEU6yfHxBk3Fv(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x74761A6));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, BoolDescriptor.UID);
		SJoiwqfbb36s9SBfqmCp(viewModelPropertyMetadata, Guid.Empty);
		viewModelPropertyMetadata.Input = true;
		FjA1Ekfbf0dcnUBWaQLX(viewModelPropertyMetadata, true);
		svrE7vfbGnAts1d6jPIt(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	private ViewModelPropertyMetadata CreateEntityProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, EntityPropertyUid);
		wttJvvfoZpxNOAZRy6jw(viewModelPropertyMetadata, Gktyjpfocp29nKGmfuqt(-576149596 ^ -575818882));
		aS8rnNfoIJQyBqtd4Z5N(viewModelPropertyMetadata, wmT44HfbEU6yfHxBk3Fv(Gktyjpfocp29nKGmfuqt(-606654180 ^ -606984726)));
		viewModelPropertyMetadata.Description = (string)wmT44HfbEU6yfHxBk3Fv(Gktyjpfocp29nKGmfuqt(-1824388195 ^ -1824055657));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, AnyTypeDescriptor.UID);
		AnyTypeSettings anyTypeSettings = new AnyTypeSettings();
		i0F1IgfbQVMP70tgPn6V(anyTypeSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957491418));
		Rw14dUfbCDGnxYeu4Q2P(viewModelPropertyMetadata, anyTypeSettings);
		eJp8MEfbhbDgqk5sP902(viewModelPropertyMetadata, false);
		viewModelPropertyMetadata.IsSystem = true;
		aAAMw7fbvpb2ySOjZjr0(viewModelPropertyMetadata, true);
		pAyR3Jfb87pUqLN4XiLr(viewModelPropertyMetadata, CreateEntityComputedValue());
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateFormUidProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, q1IxisfoacGFQYahAXQA());
		viewModelPropertyMetadata.Name = (string)Gktyjpfocp29nKGmfuqt(-1751176224 ^ -1751499186);
		viewModelPropertyMetadata.DisplayName = (string)Gktyjpfocp29nKGmfuqt(0x3CE17B75 ^ 0x3CE46EB5);
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, StringDescriptor.UID);
		SJoiwqfbb36s9SBfqmCp(viewModelPropertyMetadata, Guid.Empty);
		eJp8MEfbhbDgqk5sP902(viewModelPropertyMetadata, true);
		FjA1Ekfbf0dcnUBWaQLX(viewModelPropertyMetadata, true);
		viewModelPropertyMetadata.Nullable = false;
		return viewModelPropertyMetadata;
	}

	private static ViewModelPropertyMetadata CreateHideModeProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		NVQyd6fovb3uVBndeirl(viewModelPropertyMetadata, q1IxisfoacGFQYahAXQA());
		wttJvvfoZpxNOAZRy6jw(viewModelPropertyMetadata, Gktyjpfocp29nKGmfuqt(0x3630F361 ^ 0x3635E573));
		aS8rnNfoIJQyBqtd4Z5N(viewModelPropertyMetadata, wmT44HfbEU6yfHxBk3Fv(Gktyjpfocp29nKGmfuqt(-1217523399 ^ -1217722593)));
		MYBI6nfboc68ayWwkTaC(viewModelPropertyMetadata, Int32Descriptor.UID);
		SJoiwqfbb36s9SBfqmCp(viewModelPropertyMetadata, Guid.Empty);
		viewModelPropertyMetadata.Input = true;
		viewModelPropertyMetadata.Nullable = false;
		FjA1Ekfbf0dcnUBWaQLX(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	private ComputedValue CreateEntityComputedValue()
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				ScriptMethodInfo scriptMethodInfo = new ScriptMethodInfo();
				oRrK8wfbZnxv5D7psw8v(scriptMethodInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104869496));
				FSmd95fbuCAF3TkwqldR(scriptMethodInfo, CodeType.Client);
				sHmvupfbIUM2l01XViD1(scriptMethodInfo, qqiPi8foC03Ugh7eCWuk(this));
				text = (string)SiYfcQfbVbdOd1TfFkC8(scriptMethodInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
			{
				ComputedValue computedValue = new ComputedValue();
				kMtqdOfbSBlAVrCoWKuE(computedValue, ComputedValueType.Function);
				RIpIXffbi7JMRV7jYnMx(computedValue, text);
				return computedValue;
			}
			}
		}
	}

	private static string GetEntityMethod()
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x539BA23);
	}

	private static ScriptModule CreateScriptModule(object metadata, object sourceCode)
	{
		ScriptModule scriptModule = new ScriptModule();
		kSvOAOfbRXnvhgEDEksy(scriptModule, ((NamedMetadata)metadata).Name);
		scriptModule.ModuleName = ((NamedMetadata)metadata).Name;
		bNlcmKfbqeIfM5pHlYpv(scriptModule, ComponentMetadataHelper.ClientAssemblyName((ComponentMetadata)metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541771431)));
		scriptModule.ModuleTypeUid = ComponentClientScriptModuleType.TypeUid;
		ExTQWEfbKFnuoc0qFkc6(scriptModule, sourceCode);
		J40k7HfbXm9ryrJKjJDb(scriptModule, string.Empty);
		Q1fGXNfbTXQs1N4aAO2q(scriptModule, ((ComponentMetadata)metadata).Namespace);
		return scriptModule;
	}

	protected AbstractEntitySystemComponentCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Xqy67cfbkyvFIXCgwRGp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AbstractEntitySystemComponentCreator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				EntityPropertyUid = new Guid((string)Gktyjpfocp29nKGmfuqt(-1426094279 ^ -1426417491));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool drIF2xfoEqxKhRi81sww()
	{
		return znyihlfoGUfGsPHnLo5e == null;
	}

	internal static AbstractEntitySystemComponentCreator cBRI4FfofeI0L8vFpZbJ()
	{
		return znyihlfoGUfGsPHnLo5e;
	}

	internal static void dtVugsfoQK7I7Viet2IB(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static Guid qqiPi8foC03Ugh7eCWuk(object P_0)
	{
		return ((AbstractEntitySystemComponentCreator)P_0).ComponentUid;
	}

	internal static void NVQyd6fovb3uVBndeirl(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static object fdo6pQfo8B0OCV6uQHZ2(object P_0)
	{
		return ((AbstractEntitySystemComponentCreator)P_0).ComponentMetadataName;
	}

	internal static void wttJvvfoZpxNOAZRy6jw(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object GFHcGlfouHVRMOoYrMpe(object P_0)
	{
		return ((AbstractEntitySystemComponentCreator)P_0).ComponentDisplayName;
	}

	internal static void aS8rnNfoIJQyBqtd4Z5N(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object XrKy6JfoVVebn1aZlGKA(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static object ooITjSfoSC1gs1K9sHOG(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object HUlWkVfoiOEIAbH1ynyk(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static object YcytbvfoRXqTOgpjYqB8()
	{
		return CreateEntityIdProperty();
	}

	internal static object saOTsEfoqjvhQyXkQvMP()
	{
		return CreateEntityTypeUidProperty();
	}

	internal static object N8V2TLfoKfrpEqXatM2k()
	{
		return CreateHierarchicalProperty();
	}

	internal static object ETv5JZfoXZqic2Hf7nMF()
	{
		return CreateIsGroupProperty();
	}

	internal static object bMafbrfoTn7NMTEOomsy()
	{
		return CreateParentEntityIdProperty();
	}

	internal static object tTFNujfokU8KoqeKBJQO()
	{
		return CreateParentEntityTypeUidProperty();
	}

	internal static object hVagDQfonbGnTNHoFceb()
	{
		return CreateFormUidProperty();
	}

	internal static object hmOwyjfoOWdZl1Gybc3e()
	{
		return CreateHideModeProperty();
	}

	internal static bool e3ux8Nfo2IdspTn8ZwNM(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object cUlX0cfoe55ShqUDAjL2()
	{
		return CSharpParseOptions.get_Default();
	}

	internal static object a5LNmkfoPsIkrvHeX6Dg(object P_0, LanguageVersion P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CSharpParseOptions)P_0).WithLanguageVersion(P_1);
	}

	internal static object LcypNZfo1wO90cNaVPiU(object P_0, CancellationToken P_1)
	{
		return ((SyntaxTree)P_0).GetRoot(P_1);
	}

	internal static object sqioyQfoNGI7QikBijGb()
	{
		return GetEntityMethod();
	}

	internal static object r5oJEIfo3CFi4LbtdaDh(object P_0, int P_1, object P_2)
	{
		return ((string)P_0).Insert(P_1, (string)P_2);
	}

	internal static object F7i4osfopDkuJGsUn4wK(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static Guid q1IxisfoacGFQYahAXQA()
	{
		return Guid.NewGuid();
	}

	internal static void f8yPqQfoDWlDbEyq5LhL(object P_0, Guid value)
	{
		((ComponentMetadataItem)P_0).Uid = value;
	}

	internal static void R3nn8ofotxTeCSZwugUA(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Metadata = P_1;
	}

	internal static object jQAaSvfowc9vB02nqgUw(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static DateTime vZedaPfo4vcLIGRpJ4to()
	{
		return DateTime.Now;
	}

	internal static void G57w7efo6ERtk4TaB7qT(object P_0, DateTime value)
	{
		((ComponentMetadataItem)P_0).CreationDate = value;
	}

	internal static void phcsY1foHJkeJ6nsqP6b(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).AssemblyVersion = (string)P_1;
	}

	internal static object d06wM9foAk3kg2e6Rxld(object P_0)
	{
		return ComponentMetadataHelper.ServerAssemblyName((ComponentMetadata)P_0);
	}

	internal static object bK7FhAfo7Q5O34TSrl9P(object P_0, object P_1)
	{
		return CreateScriptModule(P_0, P_1);
	}

	internal static void nV49DnfoxDdWjIpkgJwE(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).ClientScriptModule = (ScriptModule)P_1;
	}

	internal static Guid pAVGuZfo0S0nWldtETDr(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void CZYa2RfomvDiKMmVUBmP(object P_0, Guid value)
	{
		((ComponentMetadataItemHeader)P_0).Uid = value;
	}

	internal static object PtgBpjfoykh2aUZJ61hP(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void BD6LOJfoMyCdh5o3nhwd(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static object Icu5icfoJXnBdiVCSJlF(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void SYXpfAfo9IhQmFGcIiU4(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static object erbbyKfodtnS7CRIwgva(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static void gGgvLnfolKiIQ7yUcs7L(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Description = (string)P_1;
	}

	internal static void HKmd6UforAIpUBQd8Zsj(object P_0, Guid value)
	{
		((ComponentMetadataItemHeader)P_0).ModuleUid = value;
	}

	internal static void yIY00rfogMDxn6W3D2ok(object P_0, DateTime value)
	{
		((ComponentMetadataItemHeader)P_0).CreationDate = value;
	}

	internal static void tuA0Z7fo52r7aQIbkoPH(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Published = (ComponentMetadataItem)P_1;
	}

	internal static Guid NQaZQ9fojZZHiZc4LfPA(object P_0)
	{
		return ((ComponentMetadata)P_0).GetMetadataTypeUid();
	}

	internal static void WukmZOfoYyNBcOPLZobO(object P_0, Guid value)
	{
		((ComponentMetadataItemHeader)P_0).MetadataTypeUid = value;
	}

	internal static void qNCn5YfoLWqssbMu1yWi(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Header = (ComponentMetadataItemHeader)P_1;
	}

	internal static void BdJmqmfoUKKS2DePDGLv(object P_0, object P_1)
	{
		((IComponentAssemblyBuilderService)P_0).Build((ComponentBuildAssemblyModel)P_1);
	}

	internal static void yW1YNwfosHg6yHbrZ9n7(object P_0, Guid value)
	{
		((ViewItem)P_0).Uid = value;
	}

	internal static object Gktyjpfocp29nKGmfuqt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void H8AwNBfozEKkdbG36aul(object P_0, object P_1)
	{
		((ViewItem)P_0).Name = (string)P_1;
	}

	internal static ViewType AslFOmfbFpIHdnBdF5ox(object P_0)
	{
		return ((AbstractEntitySystemComponentCreator)P_0).ViewType;
	}

	internal static void o6qp64fbB0cVJEb5i3Bj(object P_0, Guid value)
	{
		((ObjectFormViewItem)P_0).ContextPropertyUid = value;
	}

	internal static void rJTh5DfbWwKWlQYr8iKs(object P_0, ViewItemLoadingType value)
	{
		((ObjectFormViewItem)P_0).LoadingType = value;
	}

	internal static void MYBI6nfboc68ayWwkTaC(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static void SJoiwqfbb36s9SBfqmCp(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static void eJp8MEfbhbDgqk5sP902(object P_0, bool value)
	{
		((ViewModelPropertyMetadata)P_0).Input = value;
	}

	internal static void svrE7vfbGnAts1d6jPIt(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Nullable = value;
	}

	internal static object wmT44HfbEU6yfHxBk3Fv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void FjA1Ekfbf0dcnUBWaQLX(object P_0, bool value)
	{
		((PropertyMetadata)P_0).IsSystem = value;
	}

	internal static void i0F1IgfbQVMP70tgPn6V(object P_0, object P_1)
	{
		((AnyTypeSettings)P_0).FullTypeName = (string)P_1;
	}

	internal static void Rw14dUfbCDGnxYeu4Q2P(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static void aAAMw7fbvpb2ySOjZjr0(object P_0, bool value)
	{
		((ViewModelPropertyMetadata)P_0).ClientOnly = value;
	}

	internal static void pAyR3Jfb87pUqLN4XiLr(object P_0, object P_1)
	{
		((ViewModelPropertyMetadata)P_0).ComputedValue = (ComputedValue)P_1;
	}

	internal static void oRrK8wfbZnxv5D7psw8v(object P_0, object P_1)
	{
		((ScriptMethodInfo)P_0).Name = (string)P_1;
	}

	internal static void FSmd95fbuCAF3TkwqldR(object P_0, CodeType value)
	{
		((ScriptMethodInfo)P_0).CodeType = value;
	}

	internal static void sHmvupfbIUM2l01XViD1(object P_0, Guid value)
	{
		((ScriptMethodInfo)P_0).MetadataUid = value;
	}

	internal static object SiYfcQfbVbdOd1TfFkC8(object P_0)
	{
		return ScriptMethodInfoHelper.Serialize((ScriptMethodInfo)P_0);
	}

	internal static void kMtqdOfbSBlAVrCoWKuE(object P_0, ComputedValueType value)
	{
		((ComputedValue)P_0).ComputedValueType = value;
	}

	internal static void RIpIXffbi7JMRV7jYnMx(object P_0, object P_1)
	{
		((ComputedValue)P_0).MethodName = (string)P_1;
	}

	internal static void kSvOAOfbRXnvhgEDEksy(object P_0, object P_1)
	{
		((ScriptModule)P_0).ClassName = (string)P_1;
	}

	internal static void bNlcmKfbqeIfM5pHlYpv(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyName = (string)P_1;
	}

	internal static void ExTQWEfbKFnuoc0qFkc6(object P_0, object P_1)
	{
		((ScriptModule)P_0).SourceCode = (string)P_1;
	}

	internal static void J40k7HfbXm9ryrJKjJDb(object P_0, object P_1)
	{
		((ScriptModule)P_0).References = (string)P_1;
	}

	internal static void Q1fGXNfbTXQs1N4aAO2q(object P_0, object P_1)
	{
		((ScriptModule)P_0).Namespace = (string)P_1;
	}

	internal static void Xqy67cfbkyvFIXCgwRGp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static SyntaxToken MMKXttfbnYALFDFY2s41(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((BaseTypeDeclarationSyntax)P_0).get_Identifier();
	}

	internal static bool jVa9AcfbOmdxFjLH8WYR(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
