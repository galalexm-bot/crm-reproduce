using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class ClassGenerator : CodeGenerator
{
	protected ClassMetadata metadata;

	private Dictionary<string, Tuple<FormViewItem, FormViewItemTransformation>> formsByUniqueName;

	private static ClassGenerator sg6Oj4htn5SWvaiyPVCq;

	protected virtual bool HasCustomCode
	{
		get
		{
			//Discarded unreachable code: IL_00cb, IL_00da
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return !string.IsNullOrEmpty(((string)lDXcKYhwmODm5Ai41a68(metadata)).Trim((char[])ENV2gYhwy8GJrUc5MUMF(VdcgsShteZAQpyeZuYHT(0x1A33FE36 ^ 0x1A33A87A))));
				case 1:
					return false;
				case 3:
					pNMkSmhtNeKYL7DK2m1V(metadata, VdcgsShteZAQpyeZuYHT(-2112703338 ^ -2112684632));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (string.IsNullOrEmpty(metadata.CustomCode))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				eAlyp5ht1g7TvtQKEQef(metadata is ClassMetadata, VdcgsShteZAQpyeZuYHT(0x7247028A ^ 0x72447338));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				break;
			default:
				this.metadata = (ClassMetadata)metadata;
				num2 = 3;
				break;
			case 3:
				return;
			case 2:
				tq2tKWhtPEt6RG6iKHvJ(metadata, VdcgsShteZAQpyeZuYHT(0x1A33FE36 ^ 0x1A33B708));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_004e, IL_00af, IL_00be, IL_00f3, IL_0102, IL_01d9, IL_021c, IL_022b
		int num = 2;
		int num2 = num;
		GeneratedFileInfo result = default(GeneratedFileInfo);
		string text = default(string);
		IEnumerable<ISyntaxTrivia> enumerable = default(IEnumerable<ISyntaxTrivia>);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				try
				{
					ISyntaxNode[] array = GetNamespaces().Concat(GenerateMainFile()).ToArray();
					int num3 = 5;
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 5:
							text = (string)FxRu3lht3umYonoYh6Ru(this);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num3 = 0;
							}
							break;
						case 6:
						case 7:
						case 8:
							result = GenerateMainFileHelper(array, withPragmaWarningDisable: true);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 2;
							}
							break;
						default:
							if (!array.Any())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
								{
									num3 = 7;
								}
								break;
							}
							goto case 10;
						case 1:
							if (J1CTcvhtpYGPrvUtpJrr(text))
							{
								num3 = 8;
								break;
							}
							goto case 4;
						case 9:
							array.Last().TextCommentsTrailing(enumerable);
							num3 = 6;
							break;
						case 10:
							enumerable = WriteLocalizationResources();
							num3 = 3;
							break;
						case 4:
							array = new ISyntaxNode[1] { text.NamespaceDeclaration(array) };
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							if (enumerable.Any())
							{
								num3 = 9;
								break;
							}
							goto case 6;
						}
					}
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new CodeGenerationException(SR.T((string)VdcgsShteZAQpyeZuYHT(0x269E5FCA ^ 0x269D34B4), metadata.TypeName), innerException);
					}
				}
			case 2:
				pNMkSmhtNeKYL7DK2m1V(metadata, VdcgsShteZAQpyeZuYHT(0x2ACE37D ^ 0x2ACAA43));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return GenerateImageResources().Concat(GenerateCustomCodeResources()).Concat(GenerateFormsResources());
	}

	protected virtual string GetNamespace()
	{
		return (string)Sjk3yShtav14CZmnwK6I(metadata);
	}

	protected virtual ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)mZMePEhtDXl5jLTpGd7k()).GetTypeDescriptor(typeUid, subTypeUid);
	}

	[IteratorStateMachine(typeof(_003CGenerateMainFile_003Ed__6))]
	protected virtual IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateMainFile_003Ed__6(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual Accessibility GetMainClassAccessibility()
	{
		return Accessibility.Public;
	}

	[IteratorStateMachine(typeof(_003CGetNamespaces_003Ed__8))]
	protected virtual IEnumerable<ISyntaxNode> GetNamespaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetNamespaces_003Ed__8(-2);
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
			case 1:
				XmlComments(type, metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void WriteTypeAttributes(ISyntaxNode type)
	{
		//Discarded unreachable code: IL_0116, IL_0120, IL_01ee, IL_0201, IL_022f, IL_02c2, IL_02d1, IL_02dc, IL_03f4, IL_0407, IL_0416, IL_075a, IL_076d, IL_082b, IL_0858, IL_0862, IL_0936, IL_0949, IL_0976, IL_0985, IL_0acf, IL_0ae2, IL_0b60, IL_0b6f, IL_0c96, IL_0ca9, IL_0cb8, IL_0dc8, IL_0dd7, IL_0fb2, IL_0fc5, IL_0fd4, IL_104a, IL_1059, IL_1064, IL_1140, IL_1153, IL_1162, IL_11fe, IL_1252, IL_125c, IL_1320, IL_1333
		int num = 2;
		List<string>.Enumerator enumerator6 = default(List<string>.Enumerator);
		string current6 = default(string);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		List<FormViewItem>.Enumerator enumerator2 = default(List<FormViewItem>.Enumerator);
		string text4 = default(string);
		FormViewItem current5 = default(FormViewItem);
		Func<string, string> func = default(Func<string, string>);
		List<MetadataImage>.Enumerator enumerator4 = default(List<MetadataImage>.Enumerator);
		List<FormViewItemTransformation>.Enumerator enumerator5 = default(List<FormViewItemTransformation>.Enumerator);
		List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>.Enumerator enumerator7 = default(List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>.Enumerator);
		List<FormView>.Enumerator enumerator = default(List<FormView>.Enumerator);
		List<TableView>.Enumerator enumerator8 = default(List<TableView>.Enumerator);
		string text3 = default(string);
		Tuple<ViewType, Guid, Guid, Guid, Guid, bool> current4 = default(Tuple<ViewType, Guid, Guid, Guid, Guid, bool>);
		string text2 = default(string);
		FormViewItemTransformation current3 = default(FormViewItemTransformation);
		MetadataImage current2 = default(MetadataImage);
		List<object> list = default(List<object>);
		Dictionary<Guid, string>.Enumerator enumerator3 = default(Dictionary<Guid, string>.Enumerator);
		KeyValuePair<Guid, string> current = default(KeyValuePair<Guid, string>);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 50:
					try
					{
						while (true)
						{
							IL_013e:
							int num20;
							if (!enumerator6.MoveNext())
							{
								num20 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
								{
									num20 = 0;
								}
								goto IL_0124;
							}
							goto IL_0164;
							IL_0164:
							current6 = enumerator6.Current;
							num20 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num20 = 1;
							}
							goto IL_0124;
							IL_0124:
							while (true)
							{
								switch (num20)
								{
								case 2:
									goto IL_013e;
								case 3:
									goto IL_0164;
								case 1:
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<InterfaceImplementationAttribute>.Raw.CreateAttribute(current6));
									num20 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num20 = 2;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator6).Dispose();
						int num21 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num21 = 0;
						}
						switch (num21)
						{
						case 0:
							break;
						}
					}
					goto case 30;
				case 14:
					if (IYtegGhtmC4eb2Q0IsrY(metadata.OnViewLoadScriptName))
					{
						num2 = 19;
						continue;
					}
					goto case 48;
				case 17:
				case 19:
					if (metadata.Images != null)
					{
						num2 = 40;
						continue;
					}
					goto case 49;
				case 8:
					if (metadata.ImplementedInterfaces != null)
					{
						num2 = 56;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 30;
				case 49:
					if (TCwS2Nhtj4wZDrW5IG7J(this))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 23;
				case 52:
					if (metadata.TableViews == null)
					{
						num2 = 45;
						continue;
					}
					goto case 46;
				case 35:
					try
					{
						while (true)
						{
							IL_0388:
							int num18;
							if (!enumerator2.MoveNext())
							{
								num18 = 2;
								goto IL_02e0;
							}
							goto IL_0302;
							IL_02e0:
							while (true)
							{
								switch (num18)
								{
								case 5:
									break;
								case 1:
									formsByUniqueName[text4] = new Tuple<FormViewItem, FormViewItemTransformation>(current5, null);
									num18 = 4;
									continue;
								case 4:
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<FormAttribute>.Raw.CreateAttribute(Q0wLochtJoSj9VPdneTQ(N8Q14chtM7HmW6L9Xnnw(metadata)), GetFormResourceName(text4)));
									num18 = 3;
									continue;
								case 3:
									goto IL_0388;
								default:
									text4 = func((string)lXrOdIhtsGddsTHs67yF(current5));
									num18 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num18 = 0;
									}
									continue;
								case 2:
									goto end_IL_0388;
								}
								break;
							}
							goto IL_0302;
							IL_0302:
							current5 = enumerator2.Current;
							num18 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num18 = 0;
							}
							goto IL_02e0;
							continue;
							end_IL_0388:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num19 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num19 = 0;
						}
						switch (num19)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 54:
					if (yWaSNNht7BH3CPvFPSQG(metadata))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 7;
				case 3:
					if (metadata.Forms == null)
					{
						num2 = 10;
						continue;
					}
					goto case 11;
				case 33:
					_003C_003Ec__DisplayClass10_.attributes = new List<ISyntaxNode>();
					num = 59;
					break;
				case 42:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<ShowInDesignerAttribute>.Raw.CreateAttribute(false));
					num = 8;
					break;
				case 10:
				case 44:
					if (metadata.FormTransformations != null)
					{
						num2 = 51;
						continue;
					}
					goto case 47;
				case 20:
				case 45:
					if (J1CTcvhtpYGPrvUtpJrr(tPnASehtcHiPEhZNvI3d(metadata)))
					{
						num2 = 38;
						continue;
					}
					goto case 60;
				case 21:
					if (tlvw5shtwyjc7tM1mXxF(TeJXtIhtAfdprL7QyyTD(metadata), Guid.Empty))
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 54;
				case 40:
					enumerator4 = metadata.Images.GetEnumerator();
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 24;
					}
					continue;
				case 30:
					if (!string.IsNullOrEmpty((string)tvfCSYht0wKLa85Mnr1m(metadata)))
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 14;
				case 51:
					enumerator5 = metadata.FormTransformations.GetEnumerator();
					num2 = 15;
					continue;
				case 6:
					enumerator7 = ((ClassDefaultForms)VRhT9whtLUd14lhllOpt(metadata)).ToDictionary().GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (tlvw5shtwyjc7tM1mXxF(metadata.BaseClassUid, Guid.Empty))
					{
						num2 = 37;
						continue;
					}
					goto case 22;
				case 1:
					_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
					num2 = 39;
					continue;
				case 53:
					J9DywShtUTMb2UbvKW2T(formsByUniqueName);
					num2 = 27;
					continue;
				case 7:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<ShowInTypeTreeAttribute>.Raw.CreateAttribute(false));
					num2 = 58;
					continue;
				case 23:
					if (aPJh7uhtYeGwoEUVnC5c(metadata) != 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 6;
				case 4:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<AllowCreateHeirsAttribute>.Raw.CreateAttribute(metadata.AllowCreateHeirs));
					num2 = 13;
					continue;
				case 12:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<CustomCodeAttribute>.Raw.CreateAttribute(Q0wLochtJoSj9VPdneTQ(N8Q14chtM7HmW6L9Xnnw(metadata)), GetCustomCodeResourceName()));
					num2 = 23;
					continue;
				case 16:
					enumerator = metadata.FormViews.GetEnumerator();
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 18;
					}
					continue;
				case 36:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<TitlePropertyAttribute>.Raw.CreateAttribute(TeJXtIhtAfdprL7QyyTD(metadata).ToString()));
					num2 = 54;
					continue;
				case 2:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
					continue;
				case 25:
					if (M1jMvEhtteFad8CuYl9r(metadata) > 0)
					{
						num = 28;
						break;
					}
					goto case 5;
				case 22:
					if (!mRJjjGht6iYw3qBUFomI(metadata))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 4;
				case 29:
				case 58:
					if (!ncraIuhtxJpPAokamIF6(metadata))
					{
						num2 = 42;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 47:
					if (metadata.FormViews != null)
					{
						num2 = 16;
						continue;
					}
					goto case 52;
				case 46:
					enumerator8 = metadata.TableViews.GetEnumerator();
					num2 = 41;
					continue;
				case 32:
					return;
				case 41:
					try
					{
						while (true)
						{
							IL_08e4:
							int num16;
							if (!enumerator8.MoveNext())
							{
								num16 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num16 = 1;
								}
								goto IL_0866;
							}
							goto IL_08bb;
							IL_08bb:
							text3 = ClassSerializationHelper.SerializeObjectByXml(enumerator8.Current);
							num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num16 = 0;
							}
							goto IL_0866;
							IL_0866:
							while (true)
							{
								switch (num16)
								{
								default:
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<TableViewAttribute>.Raw.CreateAttribute(text3));
									num16 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
									{
										num16 = 1;
									}
									continue;
								case 2:
									break;
								case 1:
									goto IL_08e4;
								case 3:
									goto end_IL_08e4;
								}
								break;
							}
							goto IL_08bb;
							continue;
							end_IL_08e4:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator8).Dispose();
						int num17 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num17 = 0;
						}
						switch (num17)
						{
						case 0:
							break;
						}
					}
					goto case 20;
				case 59:
					SR.RunWithFutureTranslate(_003C_003Ec__DisplayClass10_._003CWriteTypeAttributes_003Eb__0, escapeQuote: false);
					num2 = 25;
					continue;
				default:
					try
					{
						while (true)
						{
							IL_0a7d:
							int num13;
							if (!enumerator7.MoveNext())
							{
								num13 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
								{
									num13 = 1;
								}
								goto IL_0994;
							}
							goto IL_09ae;
							IL_09ae:
							current4 = enumerator7.Current;
							int num14 = 3;
							num13 = num14;
							goto IL_0994;
							IL_0994:
							while (true)
							{
								switch (num13)
								{
								case 3:
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<DefaultFormAttribute>.Raw.CreateAttribute(current4.Item1, current4.Item2.ToString(), current4.Item3.ToString(), current4.Item4.ToString(), current4.Item5.ToString(), current4.Item6));
									num13 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
									{
										num13 = 2;
									}
									continue;
								case 2:
									goto IL_0a7d;
								case 1:
									goto end_IL_0a7d;
								}
								break;
							}
							goto IL_09ae;
							continue;
							end_IL_0a7d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator7).Dispose();
						int num15 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num15 = 0;
						}
						switch (num15)
						{
						case 0:
							break;
						}
					}
					goto case 57;
				case 24:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<ClassFormsSchemeAttribute>.Raw.CreateAttribute(aPJh7uhtYeGwoEUVnC5c(metadata)));
					num2 = 6;
					continue;
				case 56:
					enumerator6 = metadata.ImplementedInterfaces.GetEnumerator();
					num2 = 50;
					continue;
				case 27:
					func = _003C_003Ec__DisplayClass10_._003CWriteTypeAttributes_003Eb__1;
					num2 = 3;
					continue;
				case 15:
					try
					{
						while (true)
						{
							int num10;
							if (!enumerator5.MoveNext())
							{
								num10 = 4;
								goto IL_0b7e;
							}
							goto IL_0c47;
							IL_0b7e:
							while (true)
							{
								switch (num10)
								{
								case 3:
									text2 = func(current3.FormName);
									num10 = 2;
									continue;
								case 1:
								{
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<FormTransformationAttribute>.Raw.CreateAttribute(((string)N8Q14chtM7HmW6L9Xnnw(metadata)).TypeOfExpression(), GetFormResourceName(text2)));
									int num11 = 5;
									num10 = num11;
									continue;
								}
								case 5:
									break;
								case 2:
									formsByUniqueName[text2] = new Tuple<FormViewItem, FormViewItemTransformation>(null, current3);
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
									{
										num10 = 1;
									}
									continue;
								default:
									goto IL_0c47;
								case 4:
									goto end_IL_0c02;
								}
								break;
							}
							continue;
							IL_0c47:
							current3 = enumerator5.Current;
							num10 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num10 = 3;
							}
							goto IL_0b7e;
							continue;
							end_IL_0c02:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator5).Dispose();
						int num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						case 0:
							break;
						}
					}
					goto case 47;
				case 31:
				case 38:
					type.AddAttributes(_003C_003Ec__DisplayClass10_.attributes);
					num = 32;
					break;
				case 60:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<NamespaceForDisplayAttribute>.Raw.CreateAttribute(tPnASehtcHiPEhZNvI3d(metadata)));
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 3;
					}
					continue;
				case 39:
					Contract.NotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978337739));
					num2 = 43;
					continue;
				case 11:
					enumerator2 = metadata.Forms.GetEnumerator();
					num2 = 35;
					continue;
				case 37:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<BaseClassAttribute>.Raw.CreateAttribute(SD0aOEht40ZjKfIhihlC(metadata).ToString()));
					num2 = 22;
					continue;
				case 43:
					WriteBasicAttributes(type);
					num = 33;
					break;
				case 34:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator4.MoveNext())
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num7 = 1;
								}
								goto IL_0de6;
							}
							goto IL_0eaf;
							IL_0eaf:
							current2 = enumerator4.Current;
							num7 = 3;
							goto IL_0de6;
							IL_0de6:
							while (true)
							{
								switch (num7)
								{
								case 10:
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<ImageAttribute>.Raw.CreateAttribute(list.ToArray()));
									num7 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
									{
										num7 = 6;
									}
									continue;
								case 8:
								{
									list.Add(Q0wLochtJoSj9VPdneTQ(N8Q14chtM7HmW6L9Xnnw(metadata)));
									int num8 = 7;
									num7 = num8;
									continue;
								}
								case 3:
									list = new List<object>();
									num7 = 8;
									continue;
								case 6:
									break;
								case 2:
									goto IL_0eaf;
								case 5:
									list.Add(MHK43Nht9m4W4g9dfKFX(current2));
									num7 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
									{
										num7 = 9;
									}
									continue;
								case 9:
									if (dKTU9Oht5IlT3DnXO81i(current2))
									{
										num7 = 4;
										continue;
									}
									goto case 10;
								default:
									list.Add(KbgUrdhtg5VDBlZeQ3cB(current2));
									num7 = 5;
									continue;
								case 4:
									list.Add(true);
									num7 = 10;
									continue;
								case 7:
									list.Add((MHK43Nht9m4W4g9dfKFX(current2) == ImageFormatType.IconPack) ? fFxHQahtraSc8p9xawBK(PsGVRMhtdZpcXttVAixR(), k5AGvphtlUb8HHDOwdXv(current2)) : GetImageResourceName(current2));
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
									{
										num7 = 0;
									}
									continue;
								case 1:
									goto end_IL_0e89;
								}
								break;
							}
							continue;
							end_IL_0e89:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 49;
				case 48:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<OnViewLoadScriptNameAttribute>.Raw.CreateAttribute(sR47Zfhtyh6lG13xQwsK(metadata)));
					num2 = 17;
					continue;
				case 57:
					enumerator3 = metadata.DefaultForms.FormSettingsToDictionary().GetEnumerator();
					num2 = 55;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 9;
					}
					continue;
				case 55:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator3.MoveNext())
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num5 = 0;
								}
								goto IL_1068;
							}
							goto IL_10a8;
							IL_10a8:
							current = enumerator3.Current;
							num5 = 2;
							goto IL_1068;
							IL_1068:
							while (true)
							{
								switch (num5)
								{
								case 3:
									goto IL_10a8;
								case 2:
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<DefaultFormSettingAttribute>.Raw.CreateAttribute(current.Key.ToString(), current.Value));
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									goto end_IL_1082;
								}
								break;
							}
							continue;
							end_IL_1082:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 53;
				case 28:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<GroupIdAttribute>.Raw.CreateAttribute(M1jMvEhtteFad8CuYl9r(metadata)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
				case 13:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<DisplayFormatAttribute>.Raw.CreateAttribute(frOtbWhtHdTOBfOBMcZG(metadata)));
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 14;
					}
					continue;
				case 26:
					_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<ScriptModuleAttribute>.Raw.CreateAttribute(tvfCSYht0wKLa85Mnr1m(metadata)));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					try
					{
						while (true)
						{
							IL_12ce:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num3 = 0;
								}
								goto IL_1260;
							}
							goto IL_12b5;
							IL_12b5:
							text = ClassSerializationHelper.SerializeObjectByXml(enumerator.Current);
							num3 = 3;
							goto IL_1260;
							IL_1260:
							while (true)
							{
								switch (num3)
								{
								case 3:
									_003C_003Ec__DisplayClass10_.attributes.Add(TypeOf<FormViewAttribute>.Raw.CreateAttribute(text));
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									goto IL_12b5;
								case 1:
									goto IL_12ce;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 52;
				}
				break;
			}
		}
	}

	protected virtual ISyntaxNode GetBaseClass()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!ePRdAxhtzt8JSDGHcZqU(SD0aOEht40ZjKfIhihlC(metadata), Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				pNMkSmhtNeKYL7DK2m1V(metadata, VdcgsShteZAQpyeZuYHT(0x3630F361 ^ 0x3630BA5F));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return null;
			default:
				return ((string)BfZGlBhwWBu1DAk4K0G3((mYwTsvhwFAn1MgQn0jye(this, SD0aOEht40ZjKfIhihlC(metadata)) as ClassMetadata) ?? throw new CodeGenerationException((string)myYI4FhwBsZd9USZckQl(VdcgsShteZAQpyeZuYHT(0x17ADCCD8 ^ 0x17AEBD30), N8Q14chtM7HmW6L9Xnnw(metadata), SD0aOEht40ZjKfIhihlC(metadata))))).CreateTypeSyntax();
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetBaseInterfaces_003Ed__12))]
	protected virtual IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetBaseInterfaces_003Ed__12(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual Accessibility CtorAccessibility()
	{
		return Accessibility.Public;
	}

	[IteratorStateMachine(typeof(_003CCtorParameters_003Ed__14))]
	protected virtual IEnumerable<ISyntaxNode> CtorParameters()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCtorParameters_003Ed__14(-2);
	}

	[IteratorStateMachine(typeof(_003CBaseConstructorArgs_003Ed__15))]
	protected virtual IEnumerable<ISyntaxNode> BaseConstructorArgs()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CBaseConstructorArgs_003Ed__15(-2);
	}

	protected string FieldName(PropertyMetadata propertyMetadata)
	{
		return (string)EH4qFThwh5epgu9TLVKv(VdcgsShteZAQpyeZuYHT(-218496594 ^ -218493484), J4ica4hwb9lPD2lmGB7L(GcbmFRhwobpG82RPSoYj(propertyMetadata)));
	}

	[IteratorStateMachine(typeof(_003CGetCtors_003Ed__17))]
	protected virtual IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetCtors_003Ed__17(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__ctorStatements = ctorStatements
		};
	}

	[IteratorStateMachine(typeof(_003CGetMembers_003Ed__18))]
	protected virtual IEnumerable<ISyntaxNode> GetMembers()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetMembers_003Ed__18(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual ISyntaxNode ToStringMethod()
	{
		int num = 3;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 2:
				propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata p) => ePRdAxhtzt8JSDGHcZqU(pF5JbEhwEukfysKlQfD6(p), metadata.TitlePropertyUid));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				Contract.NotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138940730));
				num2 = 2;
				continue;
			}
			if (propertyMetadata != null)
			{
				return ((string)VdcgsShteZAQpyeZuYHT(-889460160 ^ -889677702)).MethodDeclaration(null, null, TypeOf<string>.Raw.CreateTypeSyntax(), Accessibility.Public, DeclarationModifiers.Override, new ISyntaxNode[1] { ((ISyntaxNode)yGfcbfhwGBZvIx3mXw6i(GcbmFRhwobpG82RPSoYj(propertyMetadata))).ReturnStatement() });
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
			{
				num2 = 1;
			}
		}
	}

	protected virtual IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.ctorStatements = ctorStatements;
		return metadata.Properties.EmptyIfNull().SelectMany((PropertyMetadata propertyMetadata) => CS_0024_003C_003E8__locals0._003C_003E4__this.WriteProperty(propertyMetadata, CS_0024_003C_003E8__locals0.ctorStatements));
	}

	protected virtual IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(ITypeGenerationInfo typeDescr, PropertyMetadata propertyMetadata, string fieldName)
	{
		return typeDescr.GetPropertyGetterExpressions(metadata, propertyMetadata, fieldName) ?? new ISyntaxNode[1] { fieldName.IdentifierName().ReturnStatement() };
	}

	protected virtual IEnumerable<ISyntaxNode> GetPropertySetterExpressions(ITypeGenerationInfo typeDescr, PropertyMetadata propertyMetadata, string fieldName)
	{
		return typeDescr.GetPropertySetterExpressions(metadata, propertyMetadata, fieldName) ?? new ISyntaxNode[1] { fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value) };
	}

	[IteratorStateMachine(typeof(_003CWriteProperty_003Ed__23))]
	protected virtual IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteProperty_003Ed__23(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__propertyMetadata = propertyMetadata,
			_003C_003E3__ctorStatements = ctorStatements,
			_003C_003E3__writeAttributes = writeAttributes,
			_003C_003E3__propertyAction = propertyAction
		};
	}

	protected virtual ISyntaxNode PropertyDeclaration(PropertyMetadata propertyMetadata, ISyntaxNode propertyType, IEnumerable<ISyntaxNode> getAccessorStatements = null, IEnumerable<ISyntaxNode> setAccessorStatements = null)
	{
		return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements);
	}

	protected virtual IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(ITypeGenerationInfo typeDescr, PropertyMetadata propertyMetadata)
	{
		return typeDescr.GetAdditionalTypeMembers(metadata, propertyMetadata);
	}

	protected virtual ISyntaxNode GetPropertyInitExpression(PropertyMetadata propertyMetadata, ITypeGenerationInfo typeDescriptor)
	{
		return typeDescriptor.GetPropertyInitExpression(metadata, propertyMetadata);
	}

	protected virtual ISyntaxNode GetPropertyTypeReference(PropertyMetadata propertyMetadata, ITypeGenerationInfo typeDescriptor)
	{
		return typeDescriptor.GetPropertyTypeReference(metadata, propertyMetadata, forFilter: false);
	}

	protected virtual void WritePropertyComments(ISyntaxNode property, PropertyMetadata propertyMetadata)
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
				XmlComments(property, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual IEnumerable<ISyntaxNode> WritePropertyLocalizationAttributes(PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		return WritePropertyLocalizationDisplayNameAttribute(propertyMetadata, resourcePrefix).Concat(WritePropertyLocalizationDescriptionAttribute(propertyMetadata, resourcePrefix));
	}

	protected virtual IEnumerable<ISyntaxNode> WritePropertyLocalizationDisplayNameAttribute(PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		_003C_003Ec__DisplayClass30_.propertyMetadata = propertyMetadata;
		return SR.RunWithFutureTranslate(() => new ISyntaxNode[1] { TypeOf<DisplayNameAttribute>.Raw.CreateAttribute(SR.T((string)_003C_003Ec__DisplayClass30_0.pOeb3DvTnpd4C2pT6iKW(_003C_003Ec__DisplayClass30_.propertyMetadata))) }, escapeQuote: false);
	}

	protected virtual IEnumerable<ISyntaxNode> WritePropertyLocalizationDescriptionAttribute(PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass31_0();
		CS_0024_003C_003E8__locals0.propertyMetadata = propertyMetadata;
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.propertyMetadata.Description))
		{
			return SR.RunWithFutureTranslate(() => new ISyntaxNode[1] { TypeOf<DescriptionAttribute>.Raw.CreateAttribute(_003C_003Ec__DisplayClass31_0.EKuPImvT17JFvtuvh2If(_003C_003Ec__DisplayClass31_0.ql7Q1KvTP3jop6mcBey3(CS_0024_003C_003E8__locals0.propertyMetadata))) }, escapeQuote: false);
		}
		return Enumerable.Empty<ISyntaxNode>();
	}

	protected virtual void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		//Discarded unreachable code: IL_0205, IL_022d, IL_024c, IL_025b, IL_0288, IL_04f7, IL_0506, IL_056c, IL_057b, IL_058a, IL_0677, IL_06a9, IL_06b8, IL_06c3, IL_0790, IL_07a3, IL_07b2, IL_08f9, IL_0908, IL_0938, IL_0970, IL_097f, IL_09c9, IL_09d8, IL_09e3, IL_0b40, IL_0b53, IL_0b62, IL_0bb1, IL_0cfb, IL_0d0a, IL_0dc0, IL_0dd3, IL_0e4c
		int num = 15;
		List<ISyntaxNode> list = default(List<ISyntaxNode>);
		XmlWriter xmlWriter = default(XmlWriter);
		List<string> list3 = default(List<string>);
		PropertyMetadataAdditionalAttribute[] array = default(PropertyMetadataAdditionalAttribute[]);
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		Dictionary<string, object> settingsValuePairs = default(Dictionary<string, object>);
		List<ViewAttribute>.Enumerator enumerator = default(List<ViewAttribute>.Enumerator);
		PropertyCalculateType propertyCalculateType = default(PropertyCalculateType);
		List<PropertyHandlerInfo>.Enumerator enumerator2 = default(List<PropertyHandlerInfo>.Enumerator);
		PropertyHandlerInfo current2 = default(PropertyHandlerInfo);
		PropertyMetadataAdditionalAttribute propertyMetadataAdditionalAttribute = default(PropertyMetadataAdditionalAttribute);
		ViewAttribute current = default(ViewAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 66:
					list.Add(TypeOf<TableColumnWidthAttribute>.Raw.CreateAttribute(KDHWnihwKamsA0gWYVBf(propertyMetadata)));
					num2 = 68;
					continue;
				case 75:
					list.Add(TypeOf<GroupableAttribute>.Raw.CreateAttribute(EHbkqkhwkdjDD0Ee66oc(propertyMetadata)));
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 37;
					}
					continue;
				case 73:
					if (lvgQnthwfJmW1h41ZU5i(propertyMetadata) == 0)
					{
						num2 = 59;
						continue;
					}
					goto case 57;
				default:
					try
					{
						id2d5xhwwfJ7QrxOKpgU(new XmlSerializer(TypeOf<PropertyMetadataAdditionalAttribute[]>.Raw), xmlWriter, OrWvZphwpNGbMHYgmOxj(propertyMetadata));
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num9;
						if (xmlWriter == null)
						{
							num9 = 2;
							goto IL_0231;
						}
						goto IL_0266;
						IL_0231:
						switch (num9)
						{
						case 2:
							goto end_IL_021c;
						case 1:
							goto end_IL_021c;
						}
						goto IL_0266;
						IL_0266:
						jXy9hnhw4a8UFbBG9sJd(xmlWriter);
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num9 = 1;
						}
						goto IL_0231;
						end_IL_021c:;
					}
					goto case 55;
				case 45:
				case 72:
				{
					List<ISyntaxNode> list4 = list;
					Type raw = TypeOf<PropertyAttribute>.Raw;
					object[] args = (object[])bt4R6ghwVvGFkuksgW2C(list3);
					list4.Add(raw.CreateAttribute(args));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 69;
					}
					continue;
				}
				case 10:
					array = (PropertyMetadataAdditionalAttribute[])OrWvZphwpNGbMHYgmOxj(propertyMetadata);
					num = 39;
					break;
				case 61:
					return;
				case 57:
					list.Add(TypeOf<OrderAttribute>.Raw.CreateAttribute(propertyMetadata.Order));
					num2 = 40;
					continue;
				case 39:
					num3 = 0;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 6;
					}
					continue;
				case 14:
					list.Add(TypeOf<UidAttribute>.Raw.CreateAttribute(pF5JbEhwEukfysKlQfD6(propertyMetadata).ToString()));
					num2 = 73;
					continue;
				case 9:
				case 50:
					if (IYtegGhtmC4eb2Q0IsrY(Tpcp9RhwNj0BrqUJeYR0(propertyMetadata)))
					{
						num2 = 21;
						continue;
					}
					goto case 42;
				case 17:
					stringBuilder = new StringBuilder();
					num2 = 55;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 64;
					}
					continue;
				case 32:
					settingsValuePairs = propertyMetadata.Settings.GetSettingsValuePairs();
					num2 = 54;
					continue;
				case 23:
					if (KDHWnihwKamsA0gWYVBf(propertyMetadata) <= 0)
					{
						num2 = 24;
						continue;
					}
					goto case 47;
				case 11:
					list.Add(TypeOf<NotNullAttribute>.Raw.CreateAttribute());
					num2 = 44;
					continue;
				case 19:
					list.Add(TypeOf<OwnerPropertyUidAttribute>.Raw.CreateAttribute(bPIOF6hwIyDOa67rvhwy(propertyMetadata).ToString()));
					num2 = 4;
					continue;
				case 56:
					list.Add(TypeOf<RequiredAttribute>.Raw.CreateAttribute(ejeFAChwu4BfIBS624G9(propertyMetadata)));
					num2 = 49;
					continue;
				case 4:
				case 48:
					list3 = new List<string> { propertyMetadata.TypeUid.ToString() };
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (!tlvw5shtwyjc7tM1mXxF(l4EBRthwC9BulqwuRhWo(propertyMetadata), Guid.Empty))
					{
						num2 = 72;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 51;
						}
						continue;
					}
					goto case 43;
				case 12:
					list.Add(TypeOf<TableCellAlignmentAttribute>.Raw.CreateAttribute(KsPOq2hwXfMmEH2P8KtB(propertyMetadata)));
					num = 18;
					break;
				case 42:
					list.Add(TypeOf<OnChangeScriptNameAttribute>.Raw.CreateAttribute(Tpcp9RhwNj0BrqUJeYR0(propertyMetadata)));
					num2 = 60;
					continue;
				case 33:
					enumerator = propertyMetadata.ViewSettings.Attributes.GetEnumerator();
					num2 = 58;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 57;
					}
					continue;
				case 26:
					if (propertyCalculateType != PropertyCalculateType.SQLFormula)
					{
						num2 = 53;
						continue;
					}
					goto case 46;
				case 21:
				case 60:
					if (tlvw5shtwyjc7tM1mXxF(a4X2uEhw342gn0pZsKkP(propertyMetadata), Guid.Empty))
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				case 74:
					list.AddRange(WriteValidatePropertyAttributes(propertyMetadata));
					num2 = 27;
					continue;
				case 13:
					if (((Array)OrWvZphwpNGbMHYgmOxj(propertyMetadata)).Length != 0)
					{
						num2 = 17;
						continue;
					}
					goto case 7;
				case 15:
					list = new List<ISyntaxNode>();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 14;
					}
					continue;
				case 47:
					if (KDHWnihwKamsA0gWYVBf(propertyMetadata) != 200)
					{
						num2 = 66;
						continue;
					}
					goto case 24;
				case 27:
					list.AddRange(WritePropertyLocalizationAttributes(propertyMetadata, resourcePrefix));
					num2 = 23;
					continue;
				case 43:
					list3.Add(l4EBRthwC9BulqwuRhWo(propertyMetadata).ToString());
					num = 45;
					break;
				case 5:
					propertyCalculateType = q93c0vhwS8B6iYhSnRU0(propertyMetadata);
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 11;
					}
					continue;
				case 52:
					try
					{
						while (true)
						{
							IL_06e1:
							int num6;
							if (!enumerator2.MoveNext())
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num6 = 0;
								}
								goto IL_06c7;
							}
							goto IL_0751;
							IL_0751:
							current2 = enumerator2.Current;
							num6 = 2;
							goto IL_06c7;
							IL_06c7:
							while (true)
							{
								switch (num6)
								{
								case 3:
									goto IL_06e1;
								case 2:
									list.Add(TypeOf<PropertyHandlerAttribute>.Raw.CreateAttribute(LquInyhwnyIhGbQ2EPAO(current2).ToString()));
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
									{
										num6 = 3;
									}
									continue;
								case 1:
									goto IL_0751;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 71;
				case 6:
					if (OrWvZphwpNGbMHYgmOxj(propertyMetadata) != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 7;
				case 30:
				case 34:
					propertyMetadataAdditionalAttribute = array[num3];
					num2 = 62;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 9;
					}
					continue;
				case 49:
					if (propertyMetadata.IsSystem)
					{
						num2 = 76;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 66;
						}
						continue;
					}
					goto case 29;
				case 31:
				case 44:
				case 51:
					if (ejeFAChwu4BfIBS624G9(propertyMetadata))
					{
						num2 = 56;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 49;
				case 64:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					XmlWriterSettings obj = new XmlWriterSettings
					{
						Indent = true,
						IndentChars = (string)VdcgsShteZAQpyeZuYHT(0x3A5D5EF ^ 0x3A6A761),
						NewLineChars = (string)dkhSv5hwaGmgq6eSYcoF()
					};
					Y8pxRZhwD6nfmHRdZLE2(obj, true);
					xmlWriter = (XmlWriter)bGk8ZjhwtMaoQDocsh23(stringBuilder2, obj);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 29:
					if (!tlvw5shtwyjc7tM1mXxF(propertyMetadata.OwnerPropertyUid, Guid.Empty))
					{
						num2 = 48;
						continue;
					}
					goto case 19;
				case 28:
				case 36:
					if (!EHbkqkhwkdjDD0Ee66oc(propertyMetadata))
					{
						num2 = 75;
						continue;
					}
					goto case 37;
				case 37:
					enumerator2 = propertyMetadata.Handlers.GetEnumerator();
					num2 = 52;
					continue;
				case 76:
					list.Add(TypeOf<SystemPropertyAttribute>.Raw.CreateAttribute());
					num2 = 29;
					continue;
				case 20:
				case 35:
					if (num3 < array.Length)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 7;
				case 8:
					list.Add(TypeOf<TypeFilterPropertyResolverAttribute>.Raw.CreateAttribute(a4X2uEhw342gn0pZsKkP(propertyMetadata).ToString()));
					num2 = 6;
					continue;
				case 58:
					try
					{
						while (true)
						{
							IL_0aee:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
								{
									num4 = 1;
								}
								goto IL_09e7;
							}
							goto IL_0acb;
							IL_0acb:
							current = enumerator.Current;
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num4 = 2;
							}
							goto IL_09e7;
							IL_09e7:
							while (true)
							{
								switch (num4)
								{
								case 2:
									list.Add((ISyntaxNode)OoNP6ahw1n7pxm1u3ihd(TypeOf<ViewAttribute>.Raw, new Dictionary<string, object>
									{
										{
											(string)VdcgsShteZAQpyeZuYHT(0x12A5FAC7 ^ 0x12A7161F),
											current.ViewType
										},
										{
											z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x746EC4C),
											EUIjt8hw29olmWp9eTJf(current)
										},
										{
											(string)VdcgsShteZAQpyeZuYHT(0x7C1EE318 ^ 0x7C1D917A),
											GOHa5FhweHT3d7T5DNrI(current)
										},
										{
											(string)VdcgsShteZAQpyeZuYHT(-1939377524 ^ -1939603210),
											nv9r5WhwPHc02coEbfS2(current)
										}
									}.ToArray()));
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num4 = 0;
									}
									continue;
								case 3:
									break;
								default:
									goto IL_0aee;
								case 1:
									goto end_IL_0aee;
								}
								break;
							}
							goto IL_0acb;
							continue;
							end_IL_0aee:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 9;
				case 41:
					list.Add(TypeOf<CalculateScriptAttribute>.Raw.CreateAttribute(tOylMohwiSH6RXJAX27n(propertyMetadata)));
					num2 = 3;
					continue;
				case 71:
					if (zKluDOhwO9SlL4fv3IP4(propertyMetadata) == null)
					{
						num2 = 9;
						continue;
					}
					goto case 25;
				case 54:
					list.Add(lySRbihwqMnXRPLXOus7(propertyMetadata).GetType().CreateAttribute(settingsValuePairs.ToArray()));
					num2 = 74;
					continue;
				case 18:
					if (rw6vWkhwTneH91YvZgws(propertyMetadata))
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 70;
				case 24:
				case 68:
					if (KsPOq2hwXfMmEH2P8KtB(propertyMetadata) != 0)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 18;
				case 65:
					list.Add(TypeOf<CanBeNullAttribute>.Raw.CreateAttribute());
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 22;
					}
					continue;
				case 69:
					if (q93c0vhwS8B6iYhSnRU0(propertyMetadata) == PropertyCalculateType.None)
					{
						num2 = 16;
						continue;
					}
					goto case 22;
				case 67:
					num3++;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 35;
					}
					continue;
				case 25:
					if (((PropertyViewSettings)zKluDOhwO9SlL4fv3IP4(propertyMetadata)).Attributes.Any())
					{
						num = 33;
						break;
					}
					goto case 9;
				case 38:
					if (propertyCalculateType != PropertyCalculateType.CSScript)
					{
						num = 26;
						break;
					}
					goto case 41;
				case 46:
					list.Add(TypeOf<SQLFormulaAttribute>.Raw.CreateAttribute(IgVjjPhwRDTtvHaLdttq(propertyMetadata)));
					num2 = 63;
					continue;
				case 2:
					if (bu6o3uhwZxt6Y8ZnT2GX(propertyMetadata))
					{
						num2 = 65;
						continue;
					}
					goto case 11;
				case 70:
					list.Add(TypeOf<SortableAttribute>.Raw.CreateAttribute(propertyMetadata.Sortable));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 28;
					}
					continue;
				case 40:
				case 59:
					if (!Hvog6Jhw8qGrwl2s4TXn(bxRpBOhwvwfWierUTHpv(this, ibYO0khwQP5DbPvZMaOP(propertyMetadata), l4EBRthwC9BulqwuRhWo(propertyMetadata))))
					{
						num2 = 51;
						continue;
					}
					goto case 2;
				case 3:
				case 16:
				case 53:
				case 63:
					if (lySRbihwqMnXRPLXOus7(propertyMetadata) != null)
					{
						num = 32;
						break;
					}
					goto case 27;
				case 7:
					property.AddAttributes(list);
					num2 = 61;
					continue;
				case 55:
					list.Add(TypeOf<PropertyMetadataAdditionalAttributesAttribute>.Raw.CreateAttribute(stringBuilder.ToString()));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 4;
					}
					continue;
				case 22:
					list.Add(TypeOf<CalculateTypeAttribute>.Raw.CreateAttribute(q93c0vhwS8B6iYhSnRU0(propertyMetadata)));
					num2 = 5;
					continue;
				case 62:
				{
					List<ISyntaxNode> list2 = list;
					object attributeTypeName = bmWHQAhw6ParTD6EifCf(propertyMetadataAdditionalAttribute);
					object[] args = (from p in propertyMetadataAdditionalAttribute.Parameters.EmptyIfNull()
						select ((ISyntaxNode)_003C_003Ec.MyAfcJvKdth5sSyrJPDh(_003C_003Ec.DFgBblvK9do4UA4Hj0Qg(p))).AttributeArgument((string)_003C_003Ec.xQRGt0vKlid3p9X7DywU(p))).ToArray();
					list2.Add(((string)attributeTypeName).CreateAttribute(args));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 67;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CWriteValidatePropertyAttributes_003Ed__33))]
	protected virtual IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes(PropertyMetadata propertyMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteValidatePropertyAttributes_003Ed__33(-2)
		{
			_003C_003E3__propertyMetadata = propertyMetadata
		};
	}

	protected ITypeDescriptor GetPropertyTypeDescriptor(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0133, IL_0142
		int num = 4;
		int num2 = num;
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 4:
				tq2tKWhtPEt6RG6iKHvJ(propertyMetadata, VdcgsShteZAQpyeZuYHT(-2138160520 ^ -2138174678));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (typeDescriptor == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return typeDescriptor;
			default:
				throw new CodeGenerationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139004562), GcbmFRhwobpG82RPSoYj(propertyMetadata)));
			case 5:
				typeDescriptor = GetTypeDescriptor(ibYO0khwQP5DbPvZMaOP(propertyMetadata), propertyMetadata.SubTypeUid);
				num2 = 2;
				break;
			case 1:
				throw new CodeGenerationException(SR.T((string)VdcgsShteZAQpyeZuYHT(-195614443 ^ -195798075), GcbmFRhwobpG82RPSoYj(propertyMetadata), ibYO0khwQP5DbPvZMaOP(propertyMetadata)));
			case 3:
				if (!ePRdAxhtzt8JSDGHcZqU(ibYO0khwQP5DbPvZMaOP(propertyMetadata), Guid.Empty))
				{
					num2 = 5;
					break;
				}
				goto default;
			}
		}
	}

	protected RelationType? GetRelationType(PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata.Settings is IRelationTypeSettings relationTypeSettings)
		{
			return relationTypeSettings.RelationType;
		}
		return null;
	}

	protected virtual IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
	{
		List<ISyntaxTrivia> list = Resources().ToList();
		if (list.Any())
		{
			list.Insert(0, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ACDB40)).TextComment());
			return list;
		}
		return Enumerable.Empty<ISyntaxTrivia>();
	}

	[IteratorStateMachine(typeof(_003CResources_003Ed__37))]
	protected virtual IEnumerable<ISyntaxTrivia> Resources()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CResources_003Ed__37(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual IEnumerable<ISyntaxTrivia> PropertyResources(PropertyMetadata propertyMetadata)
	{
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307ED683));
		return PropertyTypeResources(propertyMetadata);
	}

	[IteratorStateMachine(typeof(_003CPropertyTypeResources_003Ed__39))]
	protected virtual IEnumerable<ISyntaxTrivia> PropertyTypeResources(PropertyMetadata propertyMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CPropertyTypeResources_003Ed__39(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__propertyMetadata = propertyMetadata
		};
	}

	[IteratorStateMachine(typeof(_003CGenerateImageResources_003Ed__40))]
	protected virtual IEnumerable<GeneratedFileInfo> GenerateImageResources()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateImageResources_003Ed__40(-2)
		{
			_003C_003E4__this = this
		};
	}

	[IteratorStateMachine(typeof(_003CGenerateFormsResources_003Ed__42))]
	protected virtual IEnumerable<GeneratedFileInfo> GenerateFormsResources()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateFormsResources_003Ed__42(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected string GetFormResourceExtension(string formUniquieName)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_00a5
		int num = 3;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 3:
				Contract.ArgumentNotNull(formUniquieName, (string)VdcgsShteZAQpyeZuYHT(--1418440330 ^ 0x5488DD92));
				num2 = 2;
				continue;
			case 2:
				if (!IYtegGhtmC4eb2Q0IsrY(BguOTUhwHOFef222T1tF(generationParams)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			default:
				obj = "";
				break;
			case 1:
				obj = (string)VdcgsShteZAQpyeZuYHT(--1333735954 ^ 0x4F7F28D6) + (string)BguOTUhwHOFef222T1tF(generationParams);
				break;
			}
			break;
		}
		return (string)aIReK2hwA61N6SNBxCja(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875968107), formUniquieName, VdcgsShteZAQpyeZuYHT(-867826612 ^ -867792382));
	}

	protected string GetFormResourceName(string formUniquieName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)aIReK2hwA61N6SNBxCja(rJCFDqhw7vgb9xDRJ6Mo(generationParams), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281840004), xCkuMDhw0ZhbFWYa7UJb(Path.GetFileName((string)toULW8hwxNHePeTZ2bTL(generationParams))), GetFormResourceExtension(formUniquieName));
			case 1:
				tq2tKWhtPEt6RG6iKHvJ(formUniquieName, VdcgsShteZAQpyeZuYHT(-1921202237 ^ -1921010469));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerateCustomCodeResources_003Ed__47))]
	protected virtual IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateCustomCodeResources_003Ed__47(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected string GetCustomCodeFileExtension(bool forCompile)
	{
		//Discarded unreachable code: IL_0032, IL_006b, IL_007a
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 2:
				obj = "";
				break;
			case 1:
				if (!IYtegGhtmC4eb2Q0IsrY(generationParams.Prefix))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			default:
				obj = EH4qFThwh5epgu9TLVKv(VdcgsShteZAQpyeZuYHT(-1886646897 ^ -1886644405), BguOTUhwHOFef222T1tF(generationParams));
				break;
			}
			break;
		}
		return (string)aIReK2hwA61N6SNBxCja(obj, VdcgsShteZAQpyeZuYHT(-882126494 ^ -882127962), forCompile ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606846354) : VdcgsShteZAQpyeZuYHT(-867826612 ^ -867862778), VdcgsShteZAQpyeZuYHT(-2138160520 ^ -2138088650));
	}

	protected string GetCustomCodeResourceName()
	{
		return (string)aIReK2hwA61N6SNBxCja(rJCFDqhw7vgb9xDRJ6Mo(generationParams), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CB667), xCkuMDhw0ZhbFWYa7UJb(Path.GetFileName((string)toULW8hwxNHePeTZ2bTL(generationParams))), GetCustomCodeFileExtension(forCompile: false));
	}

	public ClassGenerator()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		p6rq8DhwM6Feyssg4xYB();
		formsByUniqueName = new Dictionary<string, Tuple<FormViewItem, FormViewItemTransformation>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object VdcgsShteZAQpyeZuYHT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void tq2tKWhtPEt6RG6iKHvJ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void eAlyp5ht1g7TvtQKEQef(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool wI392qhtOpbMw9Vb8fQ2()
	{
		return sg6Oj4htn5SWvaiyPVCq == null;
	}

	internal static ClassGenerator vgIZrZht27qliCCFZP2r()
	{
		return sg6Oj4htn5SWvaiyPVCq;
	}

	internal static void pNMkSmhtNeKYL7DK2m1V(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object FxRu3lht3umYonoYh6Ru(object P_0)
	{
		return ((ClassGenerator)P_0).GetNamespace();
	}

	internal static bool J1CTcvhtpYGPrvUtpJrr(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static object Sjk3yShtav14CZmnwK6I(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static object mZMePEhtDXl5jLTpGd7k()
	{
		return MetadataServiceContext.Service;
	}

	internal static long M1jMvEhtteFad8CuYl9r(object P_0)
	{
		return ((ClassMetadata)P_0).GroupId;
	}

	internal static bool tlvw5shtwyjc7tM1mXxF(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid SD0aOEht40ZjKfIhihlC(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool mRJjjGht6iYw3qBUFomI(object P_0)
	{
		return ((ClassMetadata)P_0).AllowCreateHeirs;
	}

	internal static object frOtbWhtHdTOBfOBMcZG(object P_0)
	{
		return ((ClassMetadata)P_0).DisplayFormat;
	}

	internal static Guid TeJXtIhtAfdprL7QyyTD(object P_0)
	{
		return ((ClassMetadata)P_0).TitlePropertyUid;
	}

	internal static bool yWaSNNht7BH3CPvFPSQG(object P_0)
	{
		return ((ClassMetadata)P_0).ShowInTypeTree;
	}

	internal static bool ncraIuhtxJpPAokamIF6(object P_0)
	{
		return ((ClassMetadata)P_0).ShowInDesigner;
	}

	internal static object tvfCSYht0wKLa85Mnr1m(object P_0)
	{
		return ((ClassMetadata)P_0).ScriptModuleTypeName;
	}

	internal static bool IYtegGhtmC4eb2Q0IsrY(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object sR47Zfhtyh6lG13xQwsK(object P_0)
	{
		return ((ClassMetadata)P_0).OnViewLoadScriptName;
	}

	internal static object N8Q14chtM7HmW6L9Xnnw(object P_0)
	{
		return ((ClassMetadata)P_0).TypeName;
	}

	internal static object Q0wLochtJoSj9VPdneTQ(object P_0)
	{
		return ((string)P_0).TypeOfExpression();
	}

	internal static ImageFormatType MHK43Nht9m4W4g9dfKFX(object P_0)
	{
		return ((MetadataImage)P_0).Format;
	}

	internal static object PsGVRMhtdZpcXttVAixR()
	{
		return Encoding.UTF8;
	}

	internal static object k5AGvphtlUb8HHDOwdXv(object P_0)
	{
		return ((MetadataImage)P_0).Data;
	}

	internal static object fFxHQahtraSc8p9xawBK(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static int KbgUrdhtg5VDBlZeQ3cB(object P_0)
	{
		return ((MetadataImage)P_0).Size;
	}

	internal static bool dKTU9Oht5IlT3DnXO81i(object P_0)
	{
		return ((MetadataImage)P_0).IsDefault;
	}

	internal static bool TCwS2Nhtj4wZDrW5IG7J(object P_0)
	{
		return ((ClassGenerator)P_0).HasCustomCode;
	}

	internal static ClassFormsScheme aPJh7uhtYeGwoEUVnC5c(object P_0)
	{
		return ((ClassMetadata)P_0).FormsScheme;
	}

	internal static object VRhT9whtLUd14lhllOpt(object P_0)
	{
		return ((ClassMetadata)P_0).DefaultForms;
	}

	internal static void J9DywShtUTMb2UbvKW2T(object P_0)
	{
		((Dictionary<string, Tuple<FormViewItem, FormViewItemTransformation>>)P_0).Clear();
	}

	internal static object lXrOdIhtsGddsTHs67yF(object P_0)
	{
		return ((ViewItem)P_0).Name;
	}

	internal static object tPnASehtcHiPEhZNvI3d(object P_0)
	{
		return ((ClassMetadata)P_0).NamespaceForDisplay;
	}

	internal static bool ePRdAxhtzt8JSDGHcZqU(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object mYwTsvhwFAn1MgQn0jye(object P_0, Guid uid)
	{
		return ((CodeGenerator)P_0).GetMetadata(uid);
	}

	internal static object myYI4FhwBsZd9USZckQl(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object BfZGlBhwWBu1DAk4K0G3(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object GcbmFRhwobpG82RPSoYj(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object J4ica4hwb9lPD2lmGB7L(object P_0)
	{
		return ((string)P_0).ToLowerFirstChar();
	}

	internal static object EH4qFThwh5epgu9TLVKv(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object yGfcbfhwGBZvIx3mXw6i(object P_0)
	{
		return ((string)P_0).IdentifierName();
	}

	internal static Guid pF5JbEhwEukfysKlQfD6(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static int lvgQnthwfJmW1h41ZU5i(object P_0)
	{
		return ((PropertyMetadata)P_0).Order;
	}

	internal static Guid ibYO0khwQP5DbPvZMaOP(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid l4EBRthwC9BulqwuRhWo(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object bxRpBOhwvwfWierUTHpv(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((ClassGenerator)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static bool Hvog6Jhw8qGrwl2s4TXn(object P_0)
	{
		return ((ITypeDescriptor)P_0).CanBeNullable;
	}

	internal static bool bu6o3uhwZxt6Y8ZnT2GX(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static bool ejeFAChwu4BfIBS624G9(object P_0)
	{
		return ((PropertyMetadata)P_0).Required;
	}

	internal static Guid bPIOF6hwIyDOa67rvhwy(object P_0)
	{
		return ((PropertyMetadata)P_0).OwnerPropertyUid;
	}

	internal static object bt4R6ghwVvGFkuksgW2C(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	internal static PropertyCalculateType q93c0vhwS8B6iYhSnRU0(object P_0)
	{
		return ((PropertyMetadata)P_0).CalculateType;
	}

	internal static object tOylMohwiSH6RXJAX27n(object P_0)
	{
		return ((PropertyMetadata)P_0).CalculateScript;
	}

	internal static object IgVjjPhwRDTtvHaLdttq(object P_0)
	{
		return ((PropertyMetadata)P_0).SQLFormula;
	}

	internal static object lySRbihwqMnXRPLXOus7(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static int KDHWnihwKamsA0gWYVBf(object P_0)
	{
		return ((PropertyMetadata)P_0).TableColumnWidth;
	}

	internal static LineAlignment KsPOq2hwXfMmEH2P8KtB(object P_0)
	{
		return ((PropertyMetadata)P_0).TableCellAlignment;
	}

	internal static bool rw6vWkhwTneH91YvZgws(object P_0)
	{
		return ((PropertyMetadata)P_0).Sortable;
	}

	internal static bool EHbkqkhwkdjDD0Ee66oc(object P_0)
	{
		return ((PropertyMetadata)P_0).Groupable;
	}

	internal static Guid LquInyhwnyIhGbQ2EPAO(object P_0)
	{
		return ((PropertyHandlerInfo)P_0).HandlerUid;
	}

	internal static object zKluDOhwO9SlL4fv3IP4(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static ItemType EUIjt8hw29olmWp9eTJf(object P_0)
	{
		return ((ViewAttribute)P_0).ItemType;
	}

	internal static Visibility GOHa5FhweHT3d7T5DNrI(object P_0)
	{
		return ((ViewAttribute)P_0).Visibility;
	}

	internal static bool nv9r5WhwPHc02coEbfS2(object P_0)
	{
		return ((ViewAttribute)P_0).ReadOnly;
	}

	internal static object OoNP6ahw1n7pxm1u3ihd(Type attributeType, object P_1)
	{
		return attributeType.CreateAttribute((KeyValuePair<string, object>[])P_1);
	}

	internal static object Tpcp9RhwNj0BrqUJeYR0(object P_0)
	{
		return ((PropertyMetadata)P_0).OnChangeScriptName;
	}

	internal static Guid a4X2uEhw342gn0pZsKkP(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeResolver;
	}

	internal static object OrWvZphwpNGbMHYgmOxj(object P_0)
	{
		return ((PropertyMetadata)P_0).AdditionalAttributes;
	}

	internal static object dkhSv5hwaGmgq6eSYcoF()
	{
		return Environment.NewLine;
	}

	internal static void Y8pxRZhwD6nfmHRdZLE2(object P_0, bool P_1)
	{
		((XmlWriterSettings)P_0).OmitXmlDeclaration = P_1;
	}

	internal static object bGk8ZjhwtMaoQDocsh23(object P_0, object P_1)
	{
		return XmlWriter.Create((StringBuilder)P_0, (XmlWriterSettings)P_1);
	}

	internal static void id2d5xhwwfJ7QrxOKpgU(object P_0, object P_1, object P_2)
	{
		((XmlSerializer)P_0).Serialize((XmlWriter)P_1, P_2);
	}

	internal static void jXy9hnhw4a8UFbBG9sJd(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object bmWHQAhw6ParTD6EifCf(object P_0)
	{
		return ((PropertyMetadataAdditionalAttribute)P_0).AddtibuteName;
	}

	internal static object BguOTUhwHOFef222T1tF(object P_0)
	{
		return ((GenerationParams)P_0).Prefix;
	}

	internal static object aIReK2hwA61N6SNBxCja(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object rJCFDqhw7vgb9xDRJ6Mo(object P_0)
	{
		return ((GenerationParams)P_0).Namespace;
	}

	internal static object toULW8hwxNHePeTZ2bTL(object P_0)
	{
		return ((GenerationParams)P_0).FileName;
	}

	internal static object xCkuMDhw0ZhbFWYa7UJb(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object lDXcKYhwmODm5Ai41a68(object P_0)
	{
		return ((ClassMetadata)P_0).CustomCode;
	}

	internal static object ENV2gYhwy8GJrUc5MUMF(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static void p6rq8DhwM6Feyssg4xYB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object rqfT1ghwJLGaZuUtUlwo(object P_0)
	{
		return ((string)P_0).TextComment();
	}
}
