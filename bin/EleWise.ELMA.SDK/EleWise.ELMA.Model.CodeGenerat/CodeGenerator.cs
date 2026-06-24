using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public abstract class CodeGenerator : ICodeGenerator
{
	protected GenerationParams generationParams;

	internal const string CONST_UID_FIELD = "_UID";

	protected const string CONST_UID_S = "UID_S";

	protected const string CONST_UID = "UID";

	protected readonly List<string> ignoreNamespaces;

	private IMetadata metadata;

	private static CodeGenerator mPg6afhDgDF0Cm5lkRV0;

	IMetadata ICodeGenerator.Metadata
	{
		get
		{
			return metadata;
		}
		set
		{
			int num = 3;
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
					rcWiOqhDL9kSGmJ2PSNF(this, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					kqOELshDYssuwPNau1pP(this, value);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					metadata = value;
					num2 = 2;
					break;
				}
			}
		}
	}

	GenerationParams ICodeGenerator.GenerationParams
	{
		get
		{
			return generationParams;
		}
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
					generationParams = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
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

	GeneratedFileInfo ICodeGenerator.GenerateMainFile()
	{
		return ignoreNamespaces.WithIgnoreNamespaces(() => (GeneratedFileInfo)NCR66khtq2BX1pqaJScY(this));
	}

	GeneratedFileInfo[] ICodeGenerator.Generate()
	{
		return ignoreNamespaces.WithIgnoreNamespaces(delegate
		{
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return Enumerable.Empty<GeneratedFileInfo>().If(_003C_003Ec__DisplayClass7_.mainFileInfo != null, _003C_003Ec__DisplayClass7_._003CEleWise_002EELMA_002EModel_002ECodeGeneration_002EICodeGenerator_002EGenerate_003Eb__1).Concat(GenerateAdditionalFilesInternal())
						.ToArray();
				case 2:
					new List<GeneratedFileInfo>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 2;
					break;
				default:
					_003C_003Ec__DisplayClass7_.mainFileInfo = (GeneratedFileInfo)NCR66khtq2BX1pqaJScY(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	GeneratedFileInfo[] ICodeGenerator.GenerateAdditionalFiles()
	{
		return ignoreNamespaces.WithIgnoreNamespaces(() => GenerateAdditionalFilesInternal().ToArray());
	}

	protected abstract void InitInternal(IMetadata metadata);

	protected abstract GeneratedFileInfo GenerateMainFileInternal();

	protected GeneratedFileInfo GenerateMainFileHelper(params ISyntaxNode[] declarations)
	{
		return GenerateMainFileHelper(declarations.AsEnumerable());
	}

	protected GeneratedFileInfo GenerateMainFileHelper(IEnumerable<ISyntaxNode> declarations, bool withPragmaWarningDisable = false)
	{
		return GenerateMainFileHelper(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488809851), declarations, withPragmaWarningDisable);
	}

	protected GeneratedFileInfo GenerateMainFileHelper(string extension, params ISyntaxNode[] declarations)
	{
		return GenerateMainFileHelper(extension, declarations.AsEnumerable());
	}

	protected GeneratedFileInfo GenerateMainFileHelper(string extension, IEnumerable<ISyntaxNode> declarations, bool withPragmaWarningDisable = false)
	{
		GeneratedFileInfo generatedFileInfo = new GeneratedFileInfo();
		generatedFileInfo.Type = GeneratedFileType.CS;
		generatedFileInfo.Data = (withPragmaWarningDisable ? declarations.WithPragmaWarningDisableDirective(108.CreateSyntaxNode(), 114.CreateSyntaxNode(), 162.CreateSyntaxNode(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837887663).IdentifierName()) : declarations).GenerateCSCode();
		generatedFileInfo.Extension = extension;
		return generatedFileInfo;
	}

	protected abstract IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal();

	protected virtual void InitIgnoreNamespaces(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		int num = 7;
		ICodeItemMetadata codeItemMetadata = default(ICodeItemMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					ignoreNamespaces.Insert(0, codeItemMetadata.Namespace);
					num2 = 4;
					continue;
				case 7:
					KMMSWEhDU5tGjX727tAH(ignoreNamespaces);
					num2 = 6;
					continue;
				case 4:
					return;
				case 3:
					if (codeItemMetadata == null)
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					ignoreNamespaces.Add((string)XnaKDUhDsNLG9ZLQH9No(0x7459E02 ^ 0x744905C));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 5:
					if (s5wJh3hDzPuYCwswKfmF(KxLLsYhDcGprwbtfXGKX(codeItemMetadata)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
			codeItemMetadata = metadata as ICodeItemMetadata;
			num = 3;
		}
	}

	protected void XmlComments(ISyntaxNode node, NamedDocumentedMetadata metadata, string resourcePrefix = null)
	{
		//Discarded unreachable code: IL_00a1, IL_0103, IL_01af, IL_01be
		int num = 2;
		int num2 = num;
		List<ISyntaxTrivia> list = default(List<ISyntaxTrivia>);
		string comment = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!s5wJh3hDzPuYCwswKfmF(g3cTIhhtBUu5kriycyEO(metadata)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 11:
				list.Add(((string)Hioph5htWHWeMTEb6ZCo(rAMD0phtoDNbJ1wPBUYX(metadata))).RemarksComment());
				num2 = 9;
				break;
			default:
				list.Add(((string)Hioph5htWHWeMTEb6ZCo(metadata.DisplayName)).SummaryComment());
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				list = new List<ISyntaxTrivia>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!s5wJh3hDzPuYCwswKfmF(siA45HhtFHFVnqmSaOgG(metadata)))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 7:
				if (s5wJh3hDzPuYCwswKfmF(rAMD0phtoDNbJ1wPBUYX(metadata)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 11;
			case 4:
				return;
			case 5:
			case 6:
				comment = (string)B46JXBhtboiGUjy2ruan(B46JXBhtboiGUjy2ruan(siA45HhtFHFVnqmSaOgG(metadata), XnaKDUhDsNLG9ZLQH9No(0x269E5FCA ^ 0x269D2EF4), Hioph5htWHWeMTEb6ZCo(g3cTIhhtBUu5kriycyEO(metadata))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459381633), SR.T((string)rAMD0phtoDNbJ1wPBUYX(metadata)));
				num2 = 12;
				break;
			case 8:
			case 9:
			case 10:
				node.XmlComments(list);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 4;
				}
				break;
			case 12:
				list.Add(comment.SplittedComment());
				num2 = 8;
				break;
			}
		}
	}

	protected virtual ISyntaxNode GetUidField(ISyntaxNode guidType)
	{
		return ((string)XnaKDUhDsNLG9ZLQH9No(-210725949 ^ -210517337)).FieldDeclaration(guidType, Accessibility.Private, DeclarationModifiers.Static, guidType.ObjectCreationExpression((ISyntaxNode)f9BLvuhthtXwsQfWqWhL(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105277806))));
	}

	[IteratorStateMachine(typeof(_003CUidStaticMembers_003Ed__24))]
	protected virtual IEnumerable<ISyntaxNode> UidStaticMembers(bool useNewKeyword = false)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CUidStaticMembers_003Ed__24(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__useNewKeyword = useNewKeyword
		};
	}

	protected void WriteBasicAttributes(ISyntaxNode declaration)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (metadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
				declaration.AddAttributes(TypeOf<MetadataTypeAttribute>.Raw.CreateAttribute(generationParams.MetadataType ?? metadata.GetType()), TypeOf<UidAttribute>.Raw.CreateAttribute(jGIS4KhtE99gLIOpbwpc(euBsYahtG1nUKf0Z8cKM(metadata).ToString())));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			default:
				throw new NullReferenceException((string)XnaKDUhDsNLG9ZLQH9No(-1867198571 ^ -1867089087));
			}
		}
	}

	protected string GetLocalizableText(string text)
	{
		//Discarded unreachable code: IL_0080, IL_008f
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (string.IsNullOrEmpty(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return string.Format((string)XnaKDUhDsNLG9ZLQH9No(-1767720453 ^ -1767782267), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42642F07), text);
			default:
				return "";
			}
		}
	}

	protected ISyntaxNode GetLocalizableExpression(string text, params object[] parameters)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					if (!s5wJh3hDzPuYCwswKfmF(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					obj = text;
					if (obj == null)
					{
						goto end_IL_0012;
					}
					goto IL_0090;
				case 3:
					obj = "";
					goto IL_0090;
				default:
					{
						return ((ISyntaxNode)c87lbOhtfjQiqNQMNXLB(TypeOf<SR>.Raw.CreateTypeSyntax(), XnaKDUhDsNLG9ZLQH9No(-1870892489 ^ -1870724191))).InvocationExpression(((ISyntaxNode)jGIS4KhtE99gLIOpbwpc(text)).Concat(parameters.Select((object p) => (ISyntaxNode)_003C_003Ec.IOOdFIvK0iib4QV8s3k4(p))));
					}
					IL_0090:
					return obj.CreateSyntaxNode();
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected string GetImageResourceExtension(MetadataImage image, string name = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				t2swWWhtQHtmwnLaOIZe(image, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C97E428));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)pwqf3ihtuNe5mDqyyewd(new object[6]
				{
					(!s5wJh3hDzPuYCwswKfmF(FbHb4DhtCqwBbnxBfqeJ(generationParams))) ? ((string)XnaKDUhDsNLG9ZLQH9No(0x4EA5403C ^ 0x4EA55AF8) + (string)FbHb4DhtCqwBbnxBfqeJ(generationParams)) : "",
					(!s5wJh3hDzPuYCwswKfmF(name)) ? MTuIQChtv7RdlNbpQGSQ(XnaKDUhDsNLG9ZLQH9No(-1487388570 ^ -1487381854), name) : "",
					XnaKDUhDsNLG9ZLQH9No(-867826612 ^ -867863066),
					KSxotnht8IK8cfXXvZUM(image),
					XnaKDUhDsNLG9ZLQH9No(-2099751081 ^ -2099753581),
					GfKlUOhtZ2i6FrIxDehs(image)
				});
			}
		}
	}

	protected string GetImageResourceName(MetadataImage image, string name = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				t2swWWhtQHtmwnLaOIZe(image, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3E9EE2));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)g3beBEhtiLSQ0TWdorYc(caTt74htILxB9rg0wpr7(generationParams), XnaKDUhDsNLG9ZLQH9No(0x57A5235E ^ 0x57A5399A), xCS6AIhtSxvfg9pKkr9q(Path.GetFileName((string)qkMVDghtVIGTlUa12qUB(generationParams))), GetImageResourceExtension(image, name));
			}
		}
	}

	protected virtual IMetadata GetMetadata(Guid uid)
	{
		return MetadataServiceContext.Service.GetMetadata(uid, loadImplementation: false);
	}

	protected static ISyntaxNode CreateGuid(Guid uid)
	{
		int num = 11;
		byte b2 = default(byte);
		byte[] array = default(byte[]);
		byte b5 = default(byte);
		int num5 = default(int);
		short num3 = default(short);
		short num4 = default(short);
		byte b4 = default(byte);
		byte b = default(byte);
		byte b6 = default(byte);
		byte b7 = default(byte);
		byte b8 = default(byte);
		byte b3 = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					b2 = array[13];
					num2 = 7;
					continue;
				case 1:
					b5 = array[8];
					num2 = 6;
					continue;
				case 2:
					return ((ISyntaxNode)C6LPJlhtReeCRjJ94Ucw(TypeOf<Guid>.Raw)).ObjectCreationExpression((ISyntaxNode)jGIS4KhtE99gLIOpbwpc(num5), (ISyntaxNode)jGIS4KhtE99gLIOpbwpc(num3), (ISyntaxNode)jGIS4KhtE99gLIOpbwpc(num4), (ISyntaxNode)jGIS4KhtE99gLIOpbwpc(b5), b4.CreateSyntaxNode(), b.CreateSyntaxNode(), b6.CreateSyntaxNode(), (ISyntaxNode)jGIS4KhtE99gLIOpbwpc(b7), (ISyntaxNode)jGIS4KhtE99gLIOpbwpc(b2), (ISyntaxNode)jGIS4KhtE99gLIOpbwpc(b8), (ISyntaxNode)jGIS4KhtE99gLIOpbwpc(b3));
				case 6:
					b4 = array[9];
					num2 = 9;
					continue;
				case 7:
					b8 = array[14];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					b6 = array[11];
					num2 = 12;
					continue;
				case 10:
					num5 = (array[3] << 24) | (array[2] << 16) | (array[1] << 8) | array[0];
					num2 = 8;
					continue;
				case 12:
					b7 = array[12];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 5;
					}
					continue;
				default:
					num4 = (short)(ushort)((array[7] << 8) | array[6]);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					array = uid.ToByteArray();
					num = 10;
					break;
				case 4:
					b3 = array[15];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					num3 = (short)(ushort)((array[5] << 8) | array[4]);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					b = array[10];
					num = 3;
					break;
				}
				break;
			}
		}
	}

	private static void GetIntfMethodsRecursively(Type type, BindingFlags flags, HashSet<MethodInfo> methods)
	{
		MethodInfo[] methods2 = type.GetMethods(flags);
		methods.UnionWith(methods2);
		Type[] interfaces = type.GetInterfaces();
		for (int i = 0; i < interfaces.Length; i++)
		{
			GetIntfMethodsRecursively(interfaces[i], flags, methods);
		}
	}

	protected CodeGenerator()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		generationParams = new GenerationParams();
		ignoreNamespaces = new List<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void kqOELshDYssuwPNau1pP(object P_0, object P_1)
	{
		((CodeGenerator)P_0).InitIgnoreNamespaces((IMetadata)P_1);
	}

	internal static void rcWiOqhDL9kSGmJ2PSNF(object P_0, object P_1)
	{
		((CodeGenerator)P_0).InitInternal((IMetadata)P_1);
	}

	internal static bool gIBR5whD5etgnVq9ZF86()
	{
		return mPg6afhDgDF0Cm5lkRV0 == null;
	}

	internal static CodeGenerator LOBEWkhDjHceTiPP5WRO()
	{
		return mPg6afhDgDF0Cm5lkRV0;
	}

	internal static void KMMSWEhDU5tGjX727tAH(object P_0)
	{
		((List<string>)P_0).Clear();
	}

	internal static object XnaKDUhDsNLG9ZLQH9No(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object KxLLsYhDcGprwbtfXGKX(object P_0)
	{
		return ((ICodeItemMetadata)P_0).Namespace;
	}

	internal static bool s5wJh3hDzPuYCwswKfmF(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object siA45HhtFHFVnqmSaOgG(object P_0)
	{
		return ((NamedDocumentedMetadata)P_0).XmlComments;
	}

	internal static object g3cTIhhtBUu5kriycyEO(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object Hioph5htWHWeMTEb6ZCo(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object rAMD0phtoDNbJ1wPBUYX(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static object B46JXBhtboiGUjy2ruan(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object f9BLvuhthtXwsQfWqWhL(object P_0)
	{
		return ((string)P_0).IdentifierName();
	}

	internal static Guid euBsYahtG1nUKf0Z8cKM(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object jGIS4KhtE99gLIOpbwpc(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static object c87lbOhtfjQiqNQMNXLB(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).MemberAccessExpression((string)P_1);
	}

	internal static void t2swWWhtQHtmwnLaOIZe(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object FbHb4DhtCqwBbnxBfqeJ(object P_0)
	{
		return ((GenerationParams)P_0).Prefix;
	}

	internal static object MTuIQChtv7RdlNbpQGSQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int KSxotnht8IK8cfXXvZUM(object P_0)
	{
		return ((MetadataImage)P_0).Size;
	}

	internal static ImageFormatType GfKlUOhtZ2i6FrIxDehs(object P_0)
	{
		return ((MetadataImage)P_0).Format;
	}

	internal static object pwqf3ihtuNe5mDqyyewd(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object caTt74htILxB9rg0wpr7(object P_0)
	{
		return ((GenerationParams)P_0).Namespace;
	}

	internal static object qkMVDghtVIGTlUa12qUB(object P_0)
	{
		return ((GenerationParams)P_0).FileName;
	}

	internal static object xCS6AIhtSxvfg9pKkr9q(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object g3beBEhtiLSQ0TWdorYc(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object C6LPJlhtReeCRjJ94Ucw(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object NCR66khtq2BX1pqaJScY(object P_0)
	{
		return ((CodeGenerator)P_0).GenerateMainFileInternal();
	}
}
