using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.SDK;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class EnumGenerator : CodeGenerator
{
	protected EnumMetadata metadata;

	private static EnumGenerator F4uuJchw9d55mZrUtmTW;

	protected virtual bool IsExtendable
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return fl1RjWhwcai7HVJQPWHC(metadata) == EnumMetadataType.ExtendableEnum;
				case 1:
					if (metadata.Type == EnumMetadataType.EnumExtension)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override void InitInternal(IMetadata metadata)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (this.metadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				if (metadata == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					break;
				}
				this.metadata = metadata as EnumMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				throw new ArgumentException((string)SRd4GEhwrMIEjlABnrYS(-1978478350 ^ -1978555528), (string)SRd4GEhwrMIEjlABnrYS(0x4D1C1EE4 ^ 0x4D1C57DA));
			case 0:
				return;
			case 2:
				throw new ArgumentNullException((string)SRd4GEhwrMIEjlABnrYS(-889460160 ^ -889478274));
			}
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_010f, IL_0142, IL_0185, IL_0194
		int num = 2;
		int num2 = num;
		GeneratedFileInfo result = default(GeneratedFileInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				doaNqBhwg9PdEXneqtf7(metadata, SRd4GEhwrMIEjlABnrYS(-889460160 ^ -889478274));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					result = GenerateMainFileHelper((string)nAaGjHhwYA3kEUnTCqBF((!D0xPYHhw5mFoAsA7TrlC(generationParams.Prefix)) ? nAaGjHhwYA3kEUnTCqBF(SRd4GEhwrMIEjlABnrYS(0x103FE975 ^ 0x103FF3B1), WWSDQ5hwjK0K0tYdoptP(generationParams)) : "", SRd4GEhwrMIEjlABnrYS(-1852837372 ^ -1852904630)), new ISyntaxNode[1] { metadata.Namespace.NamespaceDeclaration(GetNamespaces().Concat(GenerateMainFile())) }, nN7QgDhwLj0lHDmHl3s4(this));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new CodeGenerationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487197416), u2iRMvhwUpeHfxy1qolW(metadata)), innerException);
					}
				}
			default:
				return result;
			}
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return GenerateImageResources();
	}

	[IteratorStateMachine(typeof(_003CGetNamespaces_003Ed__4))]
	protected virtual IEnumerable<ISyntaxNode> GetNamespaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetNamespaces_003Ed__4(-2);
	}

	[IteratorStateMachine(typeof(_003CGenerateMainFile_003Ed__5))]
	protected virtual IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateMainFile_003Ed__5(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual ISyntaxNode CreateTypeDeclaration()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (nN7QgDhwLj0lHDmHl3s4(this))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return ((string)u2iRMvhwUpeHfxy1qolW(metadata)).EnumDeclaration(Accessibility.Public, DeclarationModifiers.None, Values());
			default:
				return ((string)u2iRMvhwUpeHfxy1qolW(metadata)).ClassDeclaration(Accessibility.Public, DeclarationModifiers.None, (ISyntaxNode)xeTkGxhwsPh1Kuspx0Nb(this), null, Values());
			}
		}
	}

	protected virtual void WriteComments(ISyntaxNode type)
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
				XmlComments(type, metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void WriteTypeAttributes(ISyntaxNode declaration)
	{
		//Discarded unreachable code: IL_01df, IL_01ee, IL_0256, IL_02c6, IL_03df, IL_03ee, IL_03fe, IL_0411, IL_0420, IL_064d, IL_07d7, IL_07e6, IL_086a, IL_087d
		int num = 31;
		List<MetadataImage>.Enumerator enumerator = default(List<MetadataImage>.Enumerator);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		Guid? defaultValueUid = default(Guid?);
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		MetadataImage current = default(MetadataImage);
		List<object> list = default(List<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					enumerator = metadata.Images.GetEnumerator();
					num2 = 36;
					continue;
				case 8:
					SR.RunWithFutureTranslate(_003C_003Ec__DisplayClass8_._003CWriteTypeAttributes_003Eb__0, escapeQuote: false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 27;
					}
					continue;
				case 4:
				case 32:
				case 35:
					if (metadata.Images != null)
					{
						num2 = 9;
						continue;
					}
					goto case 34;
				case 38:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<GroupIdAttribute>.Raw.CreateAttribute(metadata.GroupId));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 26;
					}
					continue;
				case 14:
				{
					List<ISyntaxNode> attributes = _003C_003Ec__DisplayClass8_.attributes;
					Type raw = TypeOf<DefaultValueUidAttribute>.Raw;
					object[] array = new object[1];
					defaultValueUid = metadata.DefaultValueUid;
					array[0] = defaultValueUid.Value.ToString();
					attributes.Add(raw.CreateAttribute(array));
					num2 = 32;
					continue;
				}
				case 18:
					_003C_003Ec__DisplayClass8_.attributes = new List<ISyntaxNode>();
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 8;
					}
					continue;
				case 23:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<UidAttribute>.Raw.CreateAttribute(metadata.Uid.ToString()));
					num2 = 8;
					continue;
				case 31:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num = 30;
					break;
				case 17:
					return;
				case 5:
					if (!ERLDmvh4BkdT4hNoCA47(metadata.BaseTypeUid, Guid.Empty))
					{
						num2 = 29;
						continue;
					}
					goto case 12;
				case 22:
					syntaxNode = (ISyntaxNode)Jrj6dQh4FOO9x0ghJhLE(EleWise.ELMA.SDK.TypeOf.EnumBaseConverter1.Raw.CreateTypeSyntax((ISyntaxNode)MnqvvIhwz128Fy6nZpHu(metadata.FullTypeName)));
					num = 6;
					break;
				case 7:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<SerializableAttribute>.Raw.CreateAttribute());
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 4;
					}
					continue;
				case 16:
					defaultValueUid = metadata.DefaultValueUid;
					num2 = 10;
					continue;
				case 25:
					doaNqBhwg9PdEXneqtf7(metadata, SRd4GEhwrMIEjlABnrYS(-1886646897 ^ -1886632783));
					num = 18;
					break;
				case 27:
					if (metadata.Type == EnumMetadataType.Enum)
					{
						num2 = 2;
						continue;
					}
					goto case 20;
				case 12:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<BaseClassAttribute>.Raw.CreateAttribute(jG7Zy3h4WVKcwwQUJqvx(metadata).ToString()));
					num = 3;
					break;
				case 33:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<NamespaceForDisplayAttribute>.Raw.CreateAttribute(wdPVkRh48xZB4NsIwglk(metadata)));
					num2 = 37;
					continue;
				case 3:
				case 29:
					if (metadata.GroupId > 0)
					{
						num2 = 38;
						continue;
					}
					goto case 26;
				case 11:
					declaration.AddAttributes(_003C_003Ec__DisplayClass8_.attributes);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 21;
					}
					continue;
				case 34:
					if (metadata.NamespaceForDisplay.IsNullOrWhiteSpace())
					{
						num2 = 24;
						continue;
					}
					goto case 33;
				case 30:
					_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
					num2 = 25;
					continue;
				case 1:
					if (!D53H9dh4oMUqwD1JmOYp(metadata))
					{
						num = 19;
						break;
					}
					goto case 16;
				case 20:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<EnumMetadataTypeAttribute>.Raw.CreateAttribute(fl1RjWhwcai7HVJQPWHC(metadata)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					continue;
				case 26:
					if (!metadata.ShowInTypeTree)
					{
						num2 = 39;
						continue;
					}
					goto case 1;
				default:
					if (fl1RjWhwcai7HVJQPWHC(metadata) == EnumMetadataType.ExtendableEnum)
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				case 6:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<TypeConverterAttribute>.Raw.CreateAttribute(syntaxNode));
					num2 = 7;
					continue;
				case 10:
					if (!defaultValueUid.HasValue)
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 13;
				case 13:
					defaultValueUid = metadata.DefaultValueUid;
					num2 = 15;
					continue;
				case 39:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<ShowInTypeTreeAttribute>.Raw.CreateAttribute(false));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					if (!ERLDmvh4BkdT4hNoCA47(defaultValueUid.Value, Guid.Empty))
					{
						num2 = 4;
						continue;
					}
					goto case 14;
				case 28:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<MetadataTypeAttribute>.Raw.CreateAttribute(metadata.GetType()));
					num2 = 23;
					continue;
				case 36:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num3 = 1;
								}
								goto IL_065b;
							}
							goto IL_078e;
							IL_078e:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num3 = 0;
							}
							goto IL_065b;
							IL_065b:
							while (true)
							{
								switch (num3)
								{
								case 8:
									if (!JxUvWZh4CuiDP54BmpLH(current))
									{
										num3 = 3;
										continue;
									}
									goto case 6;
								case 1:
									list.Add(rGNOkEh4QxM4MWrVjtCb(current));
									num3 = 9;
									continue;
								case 4:
									break;
								case 2:
									list.Add(ixLfGDh4b8SVgA4M3PJI(u2iRMvhwUpeHfxy1qolW(metadata)));
									num3 = 7;
									continue;
								case 9:
								{
									list.Add(qdHcDNh4hRbv2QeSaF3C(current));
									int num4 = 8;
									num3 = num4;
									continue;
								}
								case 3:
								case 10:
									_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<ImageAttribute>.Raw.CreateAttribute((object[])gTc0Uoh4vp75NopPRTti(list)));
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num3 = 1;
									}
									continue;
								case 6:
									list.Add(true);
									num3 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num3 = 9;
									}
									continue;
								case 11:
									goto IL_078e;
								default:
									list = new List<object>();
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
									{
										num3 = 2;
									}
									continue;
								case 7:
									list.Add((qdHcDNh4hRbv2QeSaF3C(current) == ImageFormatType.IconPack) ? LTmdCbh4f6IusWYhsUAo(atNAOeh4GrdshVMyckWm(), OeBy38h4E3tT5XIgA37t(current)) : GetImageResourceName(current));
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									goto end_IL_06c8;
								}
								break;
							}
							continue;
							end_IL_06c8:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 34;
				case 24:
				case 37:
					if (HF5WmLh4ZOg5ZNJo8K1I(_003C_003Ec__DisplayClass8_.attributes) <= 0)
					{
						num = 17;
						break;
					}
					goto case 11;
				case 21:
					return;
				case 19:
					_003C_003Ec__DisplayClass8_.attributes.Add(TypeOf<ShowInDesignerAttribute>.Raw.CreateAttribute(false));
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CValues_003Ed__9))]
	protected virtual IEnumerable<ISyntaxNode> Values()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CValues_003Ed__9(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual ISyntaxNode Ctor()
	{
		return SyntaxGeneratorExtensions.ConstructorDeclaration(CtorParameters(), MJTQVUh4uXAKyHFhcPxN(this), DeclarationModifiers.None, BaseCtorArguments()).XmlComments(((string)SRd4GEhwrMIEjlABnrYS(-1837662597 ^ -1837888105)).SummaryComment());
	}

	protected virtual Accessibility CtorAccessibility()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Accessibility.Public;
			case 1:
				if (fl1RjWhwcai7HVJQPWHC(metadata) == EnumMetadataType.EnumExtension)
				{
					return Accessibility.Protected;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CCtorParameters_003Ed__12))]
	protected virtual IEnumerable<ISyntaxNode> CtorParameters()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCtorParameters_003Ed__12(-2);
	}

	[IteratorStateMachine(typeof(_003CBaseCtorArguments_003Ed__13))]
	protected virtual IEnumerable<ISyntaxNode> BaseCtorArguments()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CBaseCtorArguments_003Ed__13(-2);
	}

	protected virtual ISyntaxNode DeserializationCtor()
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode[] parameters = default(ISyntaxNode[]);
		ISyntaxNode[] baseConstructorArguments = default(ISyntaxNode[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 2:
				return SyntaxGeneratorExtensions.ConstructorDeclaration(parameters, Accessibility.Protected, DeclarationModifiers.None, baseConstructorArguments).XmlComments(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36338099).SummaryComment());
			case 1:
				if (metadata.Type == EnumMetadataType.ExtendableEnum)
				{
					parameters = new ISyntaxNode[2]
					{
						((string)SRd4GEhwrMIEjlABnrYS(-1123633026 ^ -1123627720)).ParameterDeclaration<SerializationInfo>(),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A12019).ParameterDeclaration<StreamingContext>()
					};
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 3:
				baseConstructorArguments = new ISyntaxNode[2]
				{
					(ISyntaxNode)jk2DEOh4I8NBP0m35cEU(SRd4GEhwrMIEjlABnrYS(-561074844 ^ -561063902)),
					((string)SRd4GEhwrMIEjlABnrYS(-1767720453 ^ -1767703059)).IdentifierName()
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CValue_003Ed__15))]
	protected virtual IEnumerable<ISyntaxNode> Value(EnumValueMetadata valueMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CValue_003Ed__15(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__valueMetadata = valueMetadata
		};
	}

	protected virtual void WriteValueComments(ISyntaxNode field, EnumValueMetadata valueMetadata)
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
				XmlComments(field, valueMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void WriteValueAttributes(ISyntaxNode field, EnumValueMetadata valueMetadata)
	{
		//Discarded unreachable code: IL_013e, IL_0180, IL_01a8, IL_01e8, IL_01f7, IL_0203, IL_0212, IL_02d8, IL_02e7, IL_03e1, IL_0477, IL_0486, IL_0619, IL_062c, IL_063b, IL_0696
		int num = 24;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		StringBuilder stringBuilder = default(StringBuilder);
		int num5 = default(int);
		EnumMetadataAdditionalAttribute[] array = default(EnumMetadataAdditionalAttribute[]);
		XmlWriter xmlWriter = default(XmlWriter);
		List<MetadataImage>.Enumerator enumerator = default(List<MetadataImage>.Enumerator);
		EnumMetadataAdditionalAttribute enumMetadataAdditionalAttribute = default(EnumMetadataAdditionalAttribute);
		MetadataImage current = default(MetadataImage);
		List<object> list = default(List<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					_003C_003Ec__DisplayClass17_.attributes.Add(TypeOf<EnumMetadataAdditionalAttributesAttribute>.Raw.CreateAttribute(stringBuilder.ToString()));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (_003C_003Ec__DisplayClass17_.valueMetadata.AdditionalAttributes == null)
					{
						num2 = 14;
						continue;
					}
					goto case 6;
				case 14:
				case 15:
					field.AddAttributes(_003C_003Ec__DisplayClass17_.attributes);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
				case 22:
					if (num5 < array.Length)
					{
						num2 = 19;
						continue;
					}
					goto case 14;
				case 1:
					SR.RunWithFutureTranslate(_003C_003Ec__DisplayClass17_._003CWriteValueAttributes_003Eb__0, escapeQuote: false);
					num2 = 5;
					continue;
				case 17:
					try
					{
						zhNDdIh4ktKVXc2CPglS(new XmlSerializer(TypeOf<EnumMetadataAdditionalAttribute[]>.Raw), xmlWriter, nZFbm9h4TtkT6VlBV2S9(_003C_003Ec__DisplayClass17_.valueMetadata));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num4;
						if (xmlWriter == null)
						{
							num4 = 2;
							goto IL_01ac;
						}
						goto IL_01c2;
						IL_01ac:
						switch (num4)
						{
						default:
							goto end_IL_0197;
						case 1:
							break;
						case 2:
							goto end_IL_0197;
						case 0:
							goto end_IL_0197;
						}
						goto IL_01c2;
						IL_01c2:
						xuoq6yh4n6vpdbVcxkhc(xmlWriter);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num4 = 0;
						}
						goto IL_01ac;
						end_IL_0197:;
					}
					goto case 18;
				case 20:
					num5++;
					num2 = 11;
					continue;
				case 23:
					_003C_003Ec__DisplayClass17_.valueMetadata = valueMetadata;
					num2 = 9;
					continue;
				case 25:
					enumerator = _003C_003Ec__DisplayClass17_.valueMetadata.Images.GetEnumerator();
					num2 = 4;
					continue;
				case 10:
				case 19:
					enumMetadataAdditionalAttribute = array[num5];
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					if (_003C_003Ec__DisplayClass17_.valueMetadata.Visibility != Visibility.Visible)
					{
						num2 = 3;
						continue;
					}
					goto case 21;
				case 3:
					_003C_003Ec__DisplayClass17_.attributes.Add(TypeOf<ViewAttribute>.Raw.CreateAttribute(w9op5sh4SJWyCxaZG6rm(_003C_003Ec__DisplayClass17_.valueMetadata)));
					num2 = 21;
					continue;
				case 6:
					stringBuilder = new StringBuilder();
					num2 = 12;
					continue;
				case 12:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
					JZGg4Lh4ipsbn6CZh1Eq(xmlWriterSettings, true);
					xmlWriterSettings.IndentChars = (string)SRd4GEhwrMIEjlABnrYS(-1998538950 ^ -1998338636);
					ul9BZbh4qYImhIS8xsTh(xmlWriterSettings, AW8C0vh4RjHppeXMr9iZ());
					IY9tosh4KQMpW8g8mySa(xmlWriterSettings, true);
					xmlWriter = (XmlWriter)m36wOUh4XL3YA6Uqv0ss(stringBuilder2, xmlWriterSettings);
					num2 = 17;
					continue;
				}
				case 24:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 23;
					continue;
				case 21:
					if (_003C_003Ec__DisplayClass17_.valueMetadata.Images != null)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 2;
				case 7:
					_003C_003Ec__DisplayClass17_.attributes.Add(TypeOf<UidAttribute>.Raw.CreateAttribute(vLRrXwh4VpsxDSyaRZnU(_003C_003Ec__DisplayClass17_.valueMetadata).ToString()));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_0531:
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 2;
								goto IL_03ef;
							}
							goto IL_0429;
							IL_03ef:
							while (true)
							{
								switch (num6)
								{
								case 5:
									break;
								case 11:
									if (!JxUvWZh4CuiDP54BmpLH(current))
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
										{
											num6 = 0;
										}
										continue;
									}
									goto case 1;
								case 7:
									list = new List<object>();
									num6 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
								{
									list.Add(true);
									int num7 = 9;
									num6 = num7;
									continue;
								}
								case 8:
									list.Add(qdHcDNh4hRbv2QeSaF3C(current));
									num6 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num6 = 7;
									}
									continue;
								default:
									_003C_003Ec__DisplayClass17_.attributes.Add(TypeOf<ImageAttribute>.Raw.CreateAttribute((object[])gTc0Uoh4vp75NopPRTti(list)));
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
									{
										num6 = 4;
									}
									continue;
								case 4:
									goto IL_0531;
								case 10:
									list.Add(ixLfGDh4b8SVgA4M3PJI(u2iRMvhwUpeHfxy1qolW(metadata)));
									num6 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num6 = 1;
									}
									continue;
								case 3:
									list.Add(rGNOkEh4QxM4MWrVjtCb(current));
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num6 = 8;
									}
									continue;
								case 6:
									list.Add((current.Format == ImageFormatType.IconPack) ? LTmdCbh4f6IusWYhsUAo(atNAOeh4GrdshVMyckWm(), current.Data) : GetImageResourceName(current, _003C_003Ec__DisplayClass17_.valueMetadata.Name));
									num6 = 3;
									continue;
								case 2:
									goto end_IL_0531;
								}
								break;
							}
							goto IL_0429;
							IL_0429:
							current = enumerator.Current;
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num6 = 7;
							}
							goto IL_03ef;
							continue;
							end_IL_0531:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 2;
				default:
					array = (EnumMetadataAdditionalAttribute[])nZFbm9h4TtkT6VlBV2S9(_003C_003Ec__DisplayClass17_.valueMetadata);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					num5 = 0;
					num2 = 22;
					continue;
				case 9:
					_003C_003Ec__DisplayClass17_.attributes = new List<ISyntaxNode>();
					num2 = 7;
					continue;
				case 16:
					return;
				case 13:
					_003C_003Ec__DisplayClass17_.attributes.Add(((string)xLA0jXh4O8tqkSpdD2K8(enumMetadataAdditionalAttribute)).CreateAttribute(((IEnumerable<EnumParameter>)sIChcsh42TENHjcqBEUq(enumMetadataAdditionalAttribute)).EmptyIfNull().Select(delegate(EnumParameter p)
					{
						//Discarded unreachable code: IL_002d, IL_003c
						int num9 = 1;
						int num10 = num9;
						while (true)
						{
							switch (num10)
							{
							case 2:
								return ((ISyntaxNode)_003C_003Ec.AnHK9dvn028s3epcWfHR(_003C_003Ec.B8HIPuvnxNVtMcnHaKqJ(p))).AttributeArgument((string)_003C_003Ec.J13I64vnABGBYwEYEp43(p));
							default:
								return p.Value;
							case 1:
								if (_003C_003Ec.DeAVYMvn7dMnjfKagXKB(_003C_003Ec.J13I64vnABGBYwEYEp43(p)))
								{
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
									{
										num10 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					}).ToArray()));
					num = 20;
					break;
				}
				break;
			}
		}
	}

	protected virtual ISyntaxNode GetBaseClass()
	{
		//Discarded unreachable code: IL_0036
		int num = 1;
		EnumMetadata enumMetadata = default(EnumMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					obj = null;
					break;
				case 3:
					if (enumMetadata != null)
					{
						return enumMetadata.FullTypeName.CreateTypeSyntax();
					}
					goto end_IL_0012;
				case 1:
					Contract.NotNull(metadata, (string)SRd4GEhwrMIEjlABnrYS(-35995181 ^ -36009747));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return (ISyntaxNode)U0NnLoh4eZJRBUTXRdSG(TypeOf<EnumBase>.Raw);
				default:
					if (!ERLDmvh4BkdT4hNoCA47(jG7Zy3h4WVKcwwQUJqvx(metadata), Guid.Empty))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					obj = (EnumMetadata)GetMetadata(jG7Zy3h4WVKcwwQUJqvx(metadata));
					break;
				}
				enumMetadata = (EnumMetadata)obj;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	[IteratorStateMachine(typeof(_003CGenerateImageResources_003Ed__21))]
	protected virtual IEnumerable<GeneratedFileInfo> GenerateImageResources()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateImageResources_003Ed__21(-2)
		{
			_003C_003E4__this = this
		};
	}

	public EnumGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Gmtgefh4PClpSawQuq7V();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object SRd4GEhwrMIEjlABnrYS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool VqqAhKhwd6d9CxVLL1mv()
	{
		return F4uuJchw9d55mZrUtmTW == null;
	}

	internal static EnumGenerator pFkHB5hwle9rABbUAcxV()
	{
		return F4uuJchw9d55mZrUtmTW;
	}

	internal static void doaNqBhwg9PdEXneqtf7(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static bool D0xPYHhw5mFoAsA7TrlC(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object WWSDQ5hwjK0K0tYdoptP(object P_0)
	{
		return ((GenerationParams)P_0).Prefix;
	}

	internal static object nAaGjHhwYA3kEUnTCqBF(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool nN7QgDhwLj0lHDmHl3s4(object P_0)
	{
		return ((EnumGenerator)P_0).IsExtendable;
	}

	internal static object u2iRMvhwUpeHfxy1qolW(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object xeTkGxhwsPh1Kuspx0Nb(object P_0)
	{
		return ((EnumGenerator)P_0).GetBaseClass();
	}

	internal static EnumMetadataType fl1RjWhwcai7HVJQPWHC(object P_0)
	{
		return ((EnumMetadata)P_0).Type;
	}

	internal static object MnqvvIhwz128Fy6nZpHu(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object Jrj6dQh4FOO9x0ghJhLE(object P_0)
	{
		return ((ISyntaxNode)P_0).TypeOfExpression();
	}

	internal static bool ERLDmvh4BkdT4hNoCA47(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid jG7Zy3h4WVKcwwQUJqvx(object P_0)
	{
		return ((EnumMetadata)P_0).BaseTypeUid;
	}

	internal static bool D53H9dh4oMUqwD1JmOYp(object P_0)
	{
		return ((EnumMetadata)P_0).ShowInDesigner;
	}

	internal static object ixLfGDh4b8SVgA4M3PJI(object P_0)
	{
		return ((string)P_0).TypeOfExpression();
	}

	internal static ImageFormatType qdHcDNh4hRbv2QeSaF3C(object P_0)
	{
		return ((MetadataImage)P_0).Format;
	}

	internal static object atNAOeh4GrdshVMyckWm()
	{
		return Encoding.UTF8;
	}

	internal static object OeBy38h4E3tT5XIgA37t(object P_0)
	{
		return ((MetadataImage)P_0).Data;
	}

	internal static object LTmdCbh4f6IusWYhsUAo(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static int rGNOkEh4QxM4MWrVjtCb(object P_0)
	{
		return ((MetadataImage)P_0).Size;
	}

	internal static bool JxUvWZh4CuiDP54BmpLH(object P_0)
	{
		return ((MetadataImage)P_0).IsDefault;
	}

	internal static object gTc0Uoh4vp75NopPRTti(object P_0)
	{
		return ((List<object>)P_0).ToArray();
	}

	internal static object wdPVkRh48xZB4NsIwglk(object P_0)
	{
		return ((EnumMetadata)P_0).NamespaceForDisplay;
	}

	internal static int HF5WmLh4ZOg5ZNJo8K1I(object P_0)
	{
		return ((List<ISyntaxNode>)P_0).Count;
	}

	internal static Accessibility MJTQVUh4uXAKyHFhcPxN(object P_0)
	{
		return ((EnumGenerator)P_0).CtorAccessibility();
	}

	internal static object jk2DEOh4I8NBP0m35cEU(object P_0)
	{
		return ((string)P_0).IdentifierName();
	}

	internal static Guid vLRrXwh4VpsxDSyaRZnU(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Visibility w9op5sh4SJWyCxaZG6rm(object P_0)
	{
		return ((EnumValueMetadata)P_0).Visibility;
	}

	internal static void JZGg4Lh4ipsbn6CZh1Eq(object P_0, bool P_1)
	{
		((XmlWriterSettings)P_0).Indent = P_1;
	}

	internal static object AW8C0vh4RjHppeXMr9iZ()
	{
		return Environment.NewLine;
	}

	internal static void ul9BZbh4qYImhIS8xsTh(object P_0, object P_1)
	{
		((XmlWriterSettings)P_0).NewLineChars = (string)P_1;
	}

	internal static void IY9tosh4KQMpW8g8mySa(object P_0, bool P_1)
	{
		((XmlWriterSettings)P_0).OmitXmlDeclaration = P_1;
	}

	internal static object m36wOUh4XL3YA6Uqv0ss(object P_0, object P_1)
	{
		return XmlWriter.Create((StringBuilder)P_0, (XmlWriterSettings)P_1);
	}

	internal static object nZFbm9h4TtkT6VlBV2S9(object P_0)
	{
		return ((EnumValueMetadata)P_0).AdditionalAttributes;
	}

	internal static void zhNDdIh4ktKVXc2CPglS(object P_0, object P_1, object P_2)
	{
		((XmlSerializer)P_0).Serialize((XmlWriter)P_1, P_2);
	}

	internal static void xuoq6yh4n6vpdbVcxkhc(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object xLA0jXh4O8tqkSpdD2K8(object P_0)
	{
		return ((EnumMetadataAdditionalAttribute)P_0).AddtibuteName;
	}

	internal static object sIChcsh42TENHjcqBEUq(object P_0)
	{
		return ((EnumMetadataAdditionalAttribute)P_0).Parameters;
	}

	internal static object U0NnLoh4eZJRBUTXRdSG(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static void Gmtgefh4PClpSawQuq7V()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
