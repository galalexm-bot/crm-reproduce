using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using ICSharpCode.NRefactory.CSharp;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
public class ServiceReferenceHelper
{
	[Component]
	public class ServiceReferenceFolderInitHandler : IInitHandler
	{
		internal static ServiceReferenceFolderInitHandler YDl7IsQTGp50AFL1aKD9;

		public void Init()
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
					TVusPMQTQpHhCNrOBEhN(init: true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void InitComplete()
		{
		}

		public ServiceReferenceFolderInitHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			fwsnJkQTCqyiuNbyigWY();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object TVusPMQTQpHhCNrOBEhN(bool init)
		{
			return InitServiceReferenceConfigFolder(init);
		}

		internal static bool VjZGrNQTEgJCTlv6FMAU()
		{
			return YDl7IsQTGp50AFL1aKD9 == null;
		}

		internal static ServiceReferenceFolderInitHandler Wv3M8AQTf2DthvhkrNFn()
		{
			return YDl7IsQTGp50AFL1aKD9;
		}

		internal static void fwsnJkQTCqyiuNbyigWY()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public const string ServiceReferenceConfig = "ServiceReferenceConfig";

	private static ServiceReferenceHelper oZYr5QB6IVf7C4KW85S6;

	public string EditSourceCode(string sourceCodeContent, string appConfigContent, string url)
	{
		//Discarded unreachable code: IL_00ea, IL_011a, IL_030d, IL_034c, IL_0356, IL_039d, IL_043c, IL_04b2, IL_0519, IL_0539, IL_0579, IL_0588, IL_0594, IL_05c0
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d9: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		int num = 26;
		List<TypeDeclaration> source = default(List<TypeDeclaration>);
		AstNode val4 = default(AstNode);
		string text = default(string);
		ConstructorDeclaration val5 = default(ConstructorDeclaration);
		TypeDeclaration val = default(TypeDeclaration);
		IEnumerator<ConstructorDeclaration> enumerator = default(IEnumerator<ConstructorDeclaration>);
		AttributeSection val8 = default(AttributeSection);
		TypeDeclaration val3 = default(TypeDeclaration);
		ConstructorInitializer val2 = default(ConstructorInitializer);
		ParameterDeclaration val11 = default(ParameterDeclaration);
		ConstructorDeclaration val9 = default(ConstructorDeclaration);
		SyntaxTree val6 = default(SyntaxTree);
		ConstructorDeclaration current = default(ConstructorDeclaration);
		ParameterDeclaration val10 = default(ParameterDeclaration);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return sourceCodeContent;
				case 22:
					source = val4.get_Children().OfType<TypeDeclaration>().ToList();
					num2 = 20;
					continue;
				case 26:
					text = sourceCodeContent.Replace((string)eW5HlxB6i7CR07rAk5J4(-867826612 ^ -867739730), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA4141E));
					num2 = 25;
					continue;
				case 23:
					if (val5 != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 12;
				case 7:
					return sourceCodeContent;
				case 2:
				{
					IEnumerable<ConstructorDeclaration> enumerable = ((IEnumerable)val.get_Members()).OfType<ConstructorDeclaration>();
					val5 = null;
					enumerator = enumerable.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 29:
					if (val4 != null)
					{
						num2 = 22;
						continue;
					}
					goto case 3;
				case 24:
					return sourceCodeContent;
				case 4:
				{
					Attribute val7 = new Attribute();
					nyR8BQB6q6dLa3DBZv7R((object)val7, AstType.Create((string)eW5HlxB6i7CR07rAk5J4(-234299632 ^ -234255466)));
					val7.get_Arguments().Add((Expression)new PrimitiveExpression((object)appConfigContent));
					val7.get_Arguments().Add((Expression)new PrimitiveExpression((object)DateTime.Now.ToString((IFormatProvider)fjx4NtB6KaIS6TP9m20u())));
					val7.get_Arguments().Add((Expression)new PrimitiveExpression((object)url));
					val8 = new AttributeSection(val7);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 6:
					if (val3 != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 24;
				case 10:
					val2.get_Arguments().Add((Expression)new IdentifierExpression((string)eW5HlxB6i7CR07rAk5J4(-542721635 ^ -542643183)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 14;
					}
					continue;
				case 1:
					val11 = new ParameterDeclaration((AstType)RXQd5AB6n3TAvs9JxZNG(eW5HlxB6i7CR07rAk5J4(-70007027 ^ -70086045)), (string)eW5HlxB6i7CR07rAk5J4(-138018305 ^ -137931661), (ParameterModifier)0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 11;
					}
					continue;
				case 9:
					((AstNode)val).InsertChildAfter<EntityDeclaration>((AstNode)(object)val5, (EntityDeclaration)(object)val9, Roles.TypeMemberRole);
					num2 = 13;
					continue;
				case 11:
					val9.get_Parameters().Add(val11);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 27;
					}
					continue;
				case 13:
				case 28:
					return ((object)val6).ToString();
				case 15:
					if (val != null)
					{
						num2 = 2;
						continue;
					}
					goto case 7;
				case 27:
					break;
				case 8:
					((EntityDeclaration)val3).get_Attributes().Add(val8);
					num2 = 19;
					continue;
				case 14:
					WnLyq4B62EW959a5LWSx(val9, val2);
					num2 = 18;
					continue;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!uMJXDsB6kAJvmhSe6gaQ(enumerator))
							{
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num3 = 1;
								}
								goto IL_035a;
							}
							goto IL_048a;
							IL_048a:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num3 = 0;
							}
							goto IL_035a;
							IL_035a:
							while (true)
							{
								switch (num3)
								{
								case 11:
								{
									ParameterDeclaration obj = ((IEnumerable<ParameterDeclaration>)current.get_Parameters()).ElementAt(0);
									val10 = ((IEnumerable<ParameterDeclaration>)current.get_Parameters()).ElementAt(1);
									if (!Bc5H9PB6TGBi8Ucp0bOg(((object)obj.get_Type()).ToString(), eW5HlxB6i7CR07rAk5J4(-309639236 ^ -309718172)))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 4;
								}
								case 4:
									if (Bc5H9PB6TGBi8Ucp0bOg(((object)val10.get_Type()).ToString(), eW5HlxB6i7CR07rAk5J4(-138018305 ^ -137931557)))
									{
										num3 = 10;
										continue;
									}
									goto case 1;
								case 9:
									val5 = current;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									goto IL_048a;
								case 2:
									if (current.get_Parameters().get_Count() != 0)
									{
										num3 = 7;
										continue;
									}
									goto case 9;
								case 1:
								case 6:
									((AstNode)current).Remove();
									num3 = 8;
									continue;
								case 3:
								case 7:
									if (ecta4MB6X7yoGkyUKy0k(current.get_Parameters()) == 2)
									{
										num3 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num3 = 11;
										}
										continue;
									}
									goto case 1;
								case 12:
									goto end_IL_0464;
								}
								break;
							}
							continue;
							end_IL_0464:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 2;
							goto IL_053d;
						}
						goto IL_0553;
						IL_053d:
						switch (num4)
						{
						case 2:
							goto end_IL_0528;
						case 1:
							goto end_IL_0528;
						}
						goto IL_0553;
						IL_0553:
						enumerator.Dispose();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num4 = 1;
						}
						goto IL_053d;
						end_IL_0528:;
					}
					goto case 5;
				case 25:
					val6 = (SyntaxTree)q0a5CWB6RQ1xCdyjUPJu((object)new CSharpParser(), text, "");
					num2 = 17;
					continue;
				case 16:
					ieA6mQB6PLVSgbZT8CQy(val9, (object)new BlockStatement());
					num2 = 23;
					continue;
				case 12:
					((AstNode)val).AddChild<EntityDeclaration>((EntityDeclaration)(object)val9, Roles.TypeMemberRole);
					num2 = 28;
					continue;
				case 18:
					QDepBwB6eNsdYHthW1mw(val9, (Modifiers)8);
					num2 = 16;
					continue;
				case 21:
					qYsAsQB6OBLyBvpZxsu2(val2, (ConstructorInitializerType)1);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					val9 = new ConstructorDeclaration();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					val4 = ((IEnumerable<AstNode>)val6.get_Members()).FirstOrDefault((AstNode q) => q is NamespaceDeclaration);
					num2 = 29;
					continue;
				case 20:
					val3 = source.FirstOrDefault(delegate(TypeDeclaration q)
					{
						//IL_0025: Unknown result type (might be due to invalid IL or missing references)
						//IL_002b: Invalid comparison between Unknown and I4
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 1:
								if ((int)_003C_003Ec.VCK9u5QTIV7ShiV79ZLB(q) != 2)
								{
									return false;
								}
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num6 = 0;
								}
								break;
							default:
								return !((IEnumerable<AstType>)q.get_BaseTypes()).Any();
							}
						}
					});
					num2 = 6;
					continue;
				case 19:
					val = source.FirstOrDefault(delegate(TypeDeclaration q)
					{
						//Discarded unreachable code: IL_002d, IL_003c
						//IL_0048: Unknown result type (might be due to invalid IL or missing references)
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							case 1:
								if ((int)_003C_003Ec.VCK9u5QTIV7ShiV79ZLB(q) != 0)
								{
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
									{
										num8 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return ((IEnumerable<AstType>)q.get_BaseTypes()).FirstOrDefault((AstType qq) => _003C_003Ec.MD3PbdQTSPGFuAiWt9j3(((object)qq).ToString(), _003C_003Ec.JdYfu0QTVX4i5rKSbJ4E(0x3C5338FF ^ 0x3C526CDD))) != null;
							default:
								return false;
							}
						}
					});
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 15;
					}
					continue;
				}
				break;
			}
			val2 = new ConstructorInitializer();
			num = 21;
		}
	}

	public string GetAppConfigPath(Type serviceType)
	{
		//Discarded unreachable code: IL_0124, IL_01b3, IL_0203
		int num = 13;
		string text = default(string);
		object[] array = default(object[]);
		string text2 = default(string);
		string text3 = default(string);
		int hashCode = default(int);
		string contents = default(string);
		Guid deterministicGuid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (raNFAdB6wt5XUj9pOY5P(text))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					break;
				case 13:
					array = (object[])JHjQCFB6N8dagT6btWQ4(serviceType, Hp9vbWB61qWTRw3KNOxo(typeof(AppConfigAttribute).TypeHandle), false);
					num2 = 12;
					continue;
				case 6:
				case 11:
					text2 = _003C_003Eo__3._003C_003Ep__1.Target(_003C_003Eo__3._003C_003Ep__1, array[0]) as string;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					text3 = hashCode.ToString();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					if (_003C_003Eo__3._003C_003Ep__1 != null)
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 1:
					return text;
				case 2:
				case 7:
					contents = _003C_003Eo__3._003C_003Ep__0.Target(_003C_003Eo__3._003C_003Ep__0, array[0]) as string;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					_003C_003Eo__3._003C_003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, (string)eW5HlxB6i7CR07rAk5J4(-345420348 ^ -345398416), Hp9vbWB61qWTRw3KNOxo(typeof(ServiceReferenceHelper).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)YJDIUGB63LZDlZSMiMiV(CSharpArgumentInfoFlags.None, null) }));
					num2 = 7;
					continue;
				case 10:
					break;
				case 8:
					deterministicGuid = ((string)adA8deB6po1PNsn8uDH4(eW5HlxB6i7CR07rAk5J4(-812025778 ^ -812110460), text3, text2)).GetDeterministicGuid();
					num2 = 16;
					continue;
				case 17:
				case 19:
					text = (string)O4jBOPB669rq4Xy3giup(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099707253));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 18;
					}
					continue;
				case 16:
					text = (string)nhZVbOB6tygn3BtGaN00(kVi8UDB6aYhhBY22SOrH(InitServiceReferenceConfigFolder(init: false)), kX7B2ZB6D6u9AhqCkMuk(serviceType), deterministicGuid.ToString((string)eW5HlxB6i7CR07rAk5J4(0x307E9FD1 ^ 0x307EEFDF)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					if (_003C_003Eo__3._003C_003Ep__0 != null)
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 4:
					_003C_003Eo__3._003C_003Ep__1 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, (string)eW5HlxB6i7CR07rAk5J4(0x638095EB ^ 0x6381C045), typeof(ServiceReferenceHelper), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)YJDIUGB63LZDlZSMiMiV(CSharpArgumentInfoFlags.None, null) }));
					num2 = 11;
					continue;
				case 14:
					File.WriteAllText(text, contents);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					hashCode = serviceType.Assembly.GetHashCode();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 3;
					}
					continue;
				case 18:
					if (!File.Exists(text))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			LfDht4B64PrxLVVB0Aqf(text);
			num = 19;
		}
	}

	private static DirectoryInfo InitServiceReferenceConfigFolder(bool init)
	{
		//Discarded unreachable code: IL_0088, IL_0097, IL_00a7, IL_00b6
		int num = 5;
		int num2 = num;
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return directoryInfo;
			case 5:
				directoryInfo = new DirectoryInfo((string)r1hOGgB6H2W7g8SATBu3(eW5HlxB6i7CR07rAk5J4(-1426094279 ^ -1426140467)));
				num2 = 4;
				break;
			case 4:
				if (!(krnwmrB6AoUQni0SjRb8(directoryInfo) && init))
				{
					num2 = 7;
					break;
				}
				goto case 2;
			case 2:
				WwxfBPB67jQ8FLyAYF9T(directoryInfo, true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				ahe1QqB6xbeGiWTOilGn(directoryInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			case 7:
				if (directoryInfo.Exists)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public ServiceReferenceHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XHcHv7B60MyPr67RxbEV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object eW5HlxB6i7CR07rAk5J4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object q0a5CWB6RQ1xCdyjUPJu(object P_0, object P_1, object P_2)
	{
		return ((CSharpParser)P_0).Parse((string)P_1, (string)P_2);
	}

	internal static void nyR8BQB6q6dLa3DBZv7R(object P_0, object P_1)
	{
		((Attribute)P_0).set_Type((AstType)P_1);
	}

	internal static object fjx4NtB6KaIS6TP9m20u()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static int ecta4MB6X7yoGkyUKy0k(object P_0)
	{
		return ((AstNodeCollection<ParameterDeclaration>)P_0).get_Count();
	}

	internal static bool Bc5H9PB6TGBi8Ucp0bOg(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool uMJXDsB6kAJvmhSe6gaQ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object RXQd5AB6n3TAvs9JxZNG(object P_0)
	{
		return AstType.Create((string)P_0);
	}

	internal static void qYsAsQB6OBLyBvpZxsu2(object P_0, ConstructorInitializerType P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ConstructorInitializer)P_0).set_ConstructorInitializerType(P_1);
	}

	internal static void WnLyq4B62EW959a5LWSx(object P_0, object P_1)
	{
		((ConstructorDeclaration)P_0).set_Initializer((ConstructorInitializer)P_1);
	}

	internal static void QDepBwB6eNsdYHthW1mw(object P_0, Modifiers P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((EntityDeclaration)P_0).set_Modifiers(P_1);
	}

	internal static void ieA6mQB6PLVSgbZT8CQy(object P_0, object P_1)
	{
		((ConstructorDeclaration)P_0).set_Body((BlockStatement)P_1);
	}

	internal static bool xrrx1aB6VrvReX48Vd9J()
	{
		return oZYr5QB6IVf7C4KW85S6 == null;
	}

	internal static ServiceReferenceHelper tGn2k9B6S6UYmjbB2urf()
	{
		return oZYr5QB6IVf7C4KW85S6;
	}

	internal static Type Hp9vbWB61qWTRw3KNOxo(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object JHjQCFB6N8dagT6btWQ4(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static object YJDIUGB63LZDlZSMiMiV(CSharpArgumentInfoFlags P_0, object P_1)
	{
		return CSharpArgumentInfo.Create(P_0, (string)P_1);
	}

	internal static object adA8deB6po1PNsn8uDH4(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object kVi8UDB6aYhhBY22SOrH(object P_0)
	{
		return ((FileSystemInfo)P_0).FullName;
	}

	internal static object kX7B2ZB6D6u9AhqCkMuk(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object nhZVbOB6tygn3BtGaN00(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static bool raNFAdB6wt5XUj9pOY5P(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object LfDht4B64PrxLVVB0Aqf(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object O4jBOPB669rq4Xy3giup(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object r1hOGgB6H2W7g8SATBu3(object P_0)
	{
		return IOExtensions.GetTempPath((string)P_0);
	}

	internal static bool krnwmrB6AoUQni0SjRb8(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static void WwxfBPB67jQ8FLyAYF9T(object P_0, bool P_1)
	{
		((DirectoryInfo)P_0).Delete(P_1);
	}

	internal static void ahe1QqB6xbeGiWTOilGn(object P_0)
	{
		((DirectoryInfo)P_0).Create();
	}

	internal static void XHcHv7B60MyPr67RxbEV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
