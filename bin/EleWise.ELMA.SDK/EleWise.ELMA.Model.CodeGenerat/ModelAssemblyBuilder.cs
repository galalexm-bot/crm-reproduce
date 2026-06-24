using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Projects;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class ModelAssemblyBuilder : AssemblyBuilder
{
	private class ReferencedAssembliesResolver : MarshalByRefObject
	{
		private object path;

		private static Dictionary<string, Assembly> loadedAsms;

		internal static object XA0G7YvVRsm2rqoi5Y9b;

		public string[] GetReferencedAssemblies(string path)
		{
			//Discarded unreachable code: IL_005b, IL_006a, IL_0075, IL_011b, IL_012a, IL_018a, IL_024d, IL_0264, IL_0273, IL_0449, IL_0458, IL_04d0, IL_04e7, IL_04f6, IL_0560, IL_056f, IL_059c, IL_05ab
			int num = 1;
			int num2 = num;
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			string current = default(string);
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0;
			Assembly assembly = default(Assembly);
			AssemblyName assemblyName = default(AssemblyName);
			List<string> list = default(List<string>);
			AssemblyName[] referencedAssemblies = default(AssemblyName[]);
			int num7 = default(int);
			List<string> list2 = default(List<string>);
			while (true)
			{
				switch (num2)
				{
				case 1:
					this.path = path;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!KbOD97vVwpJq5N0ZpUeL(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num3 = 0;
								}
								goto IL_0079;
							}
							goto IL_0093;
							IL_0093:
							current = enumerator.Current;
							num3 = 3;
							goto IL_0079;
							IL_0079:
							switch (num3)
							{
							case 1:
								goto IL_0093;
							case 3:
								try
								{
									CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
									int num4 = 15;
									while (true)
									{
										switch (num4)
										{
										case 18:
											assembly = Assembly.ReflectionOnlyLoadFrom(current);
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
											{
												num4 = 0;
											}
											continue;
										case 1:
											try
											{
												if (dqrPA3vVegOF7Ti7e5B6(uLWRDxvVp8KRxNhR7VUc(pMctoNvV3JQEkJSIaKG1(assemblyName)), null))
												{
													int num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
													{
														num5 = 1;
													}
													while (true)
													{
														switch (num5)
														{
														case 1:
															if (!wlydTZvVtEaDGoUd9XNY(hAIHh7vVD3Nmvp6tVAOc(path, aD9ax4vVau2Z4iXxsVg5(EMT99ivV1k2u420DrSKA(assemblyName), KR1ruqvVknvgxoJyJHUP(0x1637C429 ^ 0x16368093)))))
															{
																num5 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
																{
																	num5 = 0;
																}
																continue;
															}
															break;
														default:
															list.Add((string)aD9ax4vVau2Z4iXxsVg5(EMT99ivV1k2u420DrSKA(assemblyName), KR1ruqvVknvgxoJyJHUP(0x92F12D5 ^ 0x92E566F)));
															num5 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
															{
																num5 = 2;
															}
															continue;
														case 2:
															break;
														}
														break;
													}
												}
											}
											catch
											{
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
												{
													num6 = 0;
												}
												switch (num6)
												{
												case 0:
													break;
												}
											}
											goto case 6;
										case 13:
											break;
										case 15:
											CS_0024_003C_003E8__locals0.asmName = (AssemblyName)PWkRTRvVOf58uf7fXuOV(current);
											num4 = 12;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
											{
												num4 = 2;
											}
											continue;
										case 5:
											assemblyName = referencedAssemblies[num7];
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
											{
												num4 = 7;
											}
											continue;
										case 12:
											assembly = AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies().FirstOrDefault((Assembly a) => (string)_003C_003Ec__DisplayClass1_0.mZcDjuZXm5JLnkaNYALi(a) == (string)_003C_003Ec__DisplayClass1_0.hU3vI8ZXyOgrovwyKZiG(CS_0024_003C_003E8__locals0.asmName));
											num4 = 11;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
											{
												num4 = 3;
											}
											continue;
										case 4:
											if (!Fux5bIvVN4xYlZAM10p8(EMT99ivV1k2u420DrSKA(assemblyName), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811908394), StringComparison.CurrentCultureIgnoreCase))
											{
												num4 = 9;
												continue;
											}
											goto case 6;
										case 19:
											num7 = 0;
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
											{
												num4 = 2;
											}
											continue;
										case 3:
											if (dqrPA3vVegOF7Ti7e5B6(assembly, null))
											{
												num4 = 17;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
												{
													num4 = 6;
												}
												continue;
											}
											break;
										case 7:
											if (list2.Contains((string)EMT99ivV1k2u420DrSKA(assemblyName)))
											{
												int num8 = 16;
												num4 = num8;
												continue;
											}
											goto case 4;
										case 9:
											list2.Add((string)EMT99ivV1k2u420DrSKA(assemblyName));
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
											{
												num4 = 1;
											}
											continue;
										case 8:
											referencedAssemblies = assembly.GetReferencedAssemblies();
											num4 = 19;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
											{
												num4 = 19;
											}
											continue;
										case 6:
										case 16:
											num7++;
											num4 = 14;
											continue;
										case 11:
											if (xFPP3TvV2GMWNvde9Zxy(assembly, null))
											{
												num4 = 18;
												continue;
											}
											goto case 3;
										case 2:
										case 14:
											if (num7 >= referencedAssemblies.Length)
											{
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
												{
													num4 = 0;
												}
												continue;
											}
											goto case 5;
										case 17:
											loadedAsms[(string)dZTUJWvVPykjhAP6BfW3(assembly)] = assembly;
											num4 = 10;
											continue;
										case 10:
											if (!CustomAttributeData.GetCustomAttributes(assembly).Any((CustomAttributeData c) => _003C_003Ec.doYUV9ZXU4cZ1WMEo7rX(_003C_003Ec.qp8s7jZXYTYW6WHVvwMJ(_003C_003Ec.ePCIRnZXjgPj4bArk4qd(c)).FullName, _003C_003Ec.nqhtYeZXLBMaXY01iBn0())))
											{
												num4 = 13;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
												{
													num4 = 11;
												}
												continue;
											}
											goto case 8;
										case 0:
											break;
										}
										break;
									}
								}
								catch
								{
									int num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
									{
										num9 = 0;
									}
									switch (num9)
									{
									case 0:
										break;
									}
								}
								continue;
							case 2:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num11;
						if (enumerator == null)
						{
							int num10 = 2;
							num11 = num10;
							goto IL_0545;
						}
						goto IL_057a;
						IL_0545:
						switch (num11)
						{
						case 2:
							goto end_IL_052c;
						case 1:
							goto end_IL_052c;
						}
						goto IL_057a;
						IL_057a:
						yLNNCbvV42C4rNOgbwK8(enumerator);
						num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num11 = 0;
						}
						goto IL_0545;
						end_IL_052c:;
					}
					goto case 5;
				case 5:
					return (string[])FA2OBRvV6ilABlDrvIvC(list);
				default:
					((AppDomain)pb8pZUvVXyjFDpqq9SdZ()).ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
				{
					if (!CIJBAFvVT3lL7fGZafvB(path))
					{
						num2 = 3;
						break;
					}
					IEnumerable<string> enumerable = ((IEnumerable<string>)RufOXMvVncubluKhfAm1(path, KR1ruqvVknvgxoJyJHUP(0x571EA399 ^ 0x571FE75F))).Where((string fn) => !_003C_003Ec.pZD2LHZX5XE07MxkXnHb(_003C_003Ec.Cytcl4ZXrx4EmnHDuiVj(_003C_003Ec.BefWa7ZXl9skB4pGsOse(fn)), _003C_003Ec.vTZ9HSZXgGh4GReMEAKL(-1411196499 ^ -1411198077)));
					list = new List<string>();
					list2 = new List<string>();
					enumerator = enumerable.GetEnumerator();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 1;
					}
					break;
				}
				case 3:
					return new string[0];
				}
			}
		}

		private Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
		{
			//Discarded unreachable code: IL_0065, IL_016e, IL_017d
			int num = 8;
			int num2 = num;
			Assembly value = default(Assembly);
			string text = default(string);
			_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
			AssemblyName assemblyName = default(AssemblyName);
			while (true)
			{
				switch (num2)
				{
				case 15:
					value = (Assembly)AqmsZ3vVxBZIoLaCtsRE(text);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (!wlydTZvVtEaDGoUd9XNY(text))
					{
						num2 = 11;
						break;
					}
					goto case 15;
				default:
					loadedAsms[(string)YOQqEQvVHxptwIwZmf9c(_003C_003Ec__DisplayClass2_.args)] = value;
					num2 = 13;
					break;
				case 13:
					return value;
				case 3:
				case 11:
					value = Assembly.ReflectionOnlyLoad((string)YOQqEQvVHxptwIwZmf9c(_003C_003Ec__DisplayClass2_.args));
					num2 = 16;
					break;
				case 12:
					if (eBaQNgvV74BiBYN882uo(path))
					{
						num2 = 3;
						break;
					}
					goto case 9;
				case 6:
					return value;
				case 4:
					return value;
				case 1:
					return value;
				case 14:
					if (!dqrPA3vVegOF7Ti7e5B6(value, null))
					{
						assemblyName = new AssemblyName((string)YOQqEQvVHxptwIwZmf9c(_003C_003Ec__DisplayClass2_.args));
						num2 = 12;
					}
					else
					{
						num2 = 5;
					}
					break;
				case 9:
					text = (string)hAIHh7vVD3Nmvp6tVAOc(path, aD9ax4vVau2Z4iXxsVg5(EMT99ivV1k2u420DrSKA(assemblyName), KR1ruqvVknvgxoJyJHUP(-1146510045 ^ -1146560103)));
					num2 = 2;
					break;
				case 16:
					loadedAsms[(string)YOQqEQvVHxptwIwZmf9c(_003C_003Ec__DisplayClass2_.args)] = value;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 1;
					}
					break;
				case 10:
					if (!loadedAsms.TryGetValue((string)YOQqEQvVHxptwIwZmf9c(_003C_003Ec__DisplayClass2_.args), out value))
					{
						value = ((IEnumerable<Assembly>)tsWQQQvVAF4y8ebsi9mI(AppDomain.CurrentDomain)).FirstOrDefault(_003C_003Ec__DisplayClass2_._003CCurrentDomain_ReflectionOnlyAssemblyResolve_003Eb__0);
						num2 = 14;
					}
					else
					{
						num2 = 6;
					}
					break;
				case 8:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass2_.args = args;
					num2 = 10;
					break;
				case 5:
					loadedAsms[_003C_003Ec__DisplayClass2_.args.Name] = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public ReferencedAssembliesResolver()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			AcXdrmvV0WL2m5O36sca();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ReferencedAssembliesResolver()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				default:
					loadedAsms = new Dictionary<string, Assembly>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static object pb8pZUvVXyjFDpqq9SdZ()
		{
			return AppDomain.CurrentDomain;
		}

		internal static bool CIJBAFvVT3lL7fGZafvB(object P_0)
		{
			return Directory.Exists((string)P_0);
		}

		internal static object KR1ruqvVknvgxoJyJHUP(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object RufOXMvVncubluKhfAm1(object P_0, object P_1)
		{
			return Directory.GetFiles((string)P_0, (string)P_1);
		}

		internal static object PWkRTRvVOf58uf7fXuOV(object P_0)
		{
			return System.Reflection.AssemblyName.GetAssemblyName((string)P_0);
		}

		internal static bool xFPP3TvV2GMWNvde9Zxy(object P_0, object P_1)
		{
			return (Assembly)P_0 == (Assembly)P_1;
		}

		internal static bool dqrPA3vVegOF7Ti7e5B6(object P_0, object P_1)
		{
			return (Assembly)P_0 != (Assembly)P_1;
		}

		internal static object dZTUJWvVPykjhAP6BfW3(object P_0)
		{
			return ((Assembly)P_0).FullName;
		}

		internal static object EMT99ivV1k2u420DrSKA(object P_0)
		{
			return ((AssemblyName)P_0).Name;
		}

		internal static bool Fux5bIvVN4xYlZAM10p8(object P_0, object P_1, StringComparison P_2)
		{
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		internal static object pMctoNvV3JQEkJSIaKG1(object P_0)
		{
			return ((AssemblyName)P_0).FullName;
		}

		internal static object uLWRDxvVp8KRxNhR7VUc(object P_0)
		{
			return Assembly.ReflectionOnlyLoad((string)P_0);
		}

		internal static object aD9ax4vVau2Z4iXxsVg5(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static object hAIHh7vVD3Nmvp6tVAOc(object P_0, object P_1)
		{
			return Path.Combine((string)P_0, (string)P_1);
		}

		internal static bool wlydTZvVtEaDGoUd9XNY(object P_0)
		{
			return File.Exists((string)P_0);
		}

		internal static bool KbOD97vVwpJq5N0ZpUeL(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void yLNNCbvV42C4rNOgbwK8(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static object FA2OBRvV6ilABlDrvIvC(object P_0)
		{
			return ((List<string>)P_0).ToArray();
		}

		internal static bool fBAFsMvVqTF8Nl4TLwZm()
		{
			return XA0G7YvVRsm2rqoi5Y9b == null;
		}

		internal static ReferencedAssembliesResolver kVeEcYvVKLv4vNhKZXIS()
		{
			return (ReferencedAssembliesResolver)XA0G7YvVRsm2rqoi5Y9b;
		}

		internal static object YOQqEQvVHxptwIwZmf9c(object P_0)
		{
			return ((ResolveEventArgs)P_0).Name;
		}

		internal static object tsWQQQvVAF4y8ebsi9mI(object P_0)
		{
			return ((AppDomain)P_0).ReflectionOnlyGetAssemblies();
		}

		internal static bool eBaQNgvV74BiBYN882uo(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object AqmsZ3vVxBZIoLaCtsRE(object P_0)
		{
			return Assembly.ReflectionOnlyLoadFrom((string)P_0);
		}

		internal static void AcXdrmvV0WL2m5O36sca()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private IEnumerable<IModelReferenceProvider> modelReferenceProviders;

	private IMetadataGeneratorService metadataGeneratorService;

	private string assemblyInfo;

	private string rootNamespace;

	private static ModelAssemblyBuilder uNjFtGhNd8WBp9nFPBdZ;

	private IEnumerable<IModelReferenceProvider> ModelReferenceProviders
	{
		get
		{
			IEnumerable<IModelReferenceProvider> enumerable = modelReferenceProviders;
			if (enumerable == null)
			{
				if (!ComponentManager.Initialized)
				{
					return Enumerable.Empty<IModelReferenceProvider>();
				}
				enumerable = (modelReferenceProviders = ComponentManager.Current.GetExtensionPoints<IModelReferenceProvider>());
			}
			return enumerable;
		}
		set
		{
			modelReferenceProviders = value;
		}
	}

	internal IMetadataGeneratorService MetadataGeneratorService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IMetadataGeneratorService serviceNotNull;
			while (true)
			{
				switch (num2)
				{
				case 1:
					serviceNotNull = metadataGeneratorService;
					if (serviceNotNull != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataGeneratorService>();
					break;
				}
				break;
			}
			return serviceNotNull;
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
				case 0:
					return;
				case 1:
					metadataGeneratorService = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ModelAssemblyBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XQqS71hNg15cyyXg5HpM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ModelAssemblyBuilder(string assemblyName, string rootNamespace = null)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		XQqS71hNg15cyyXg5HpM();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				base.AssemblyName = assemblyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 3:
				Contract.ArgumentNotNullOrEmpty(assemblyName, (string)yADEBbhN5hqo09FBLkjR(0x2A7797B7 ^ 0x2A74F20B));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num = 0;
				}
				break;
			default:
				this.rootNamespace = (xcWtAshNjVCyRJUROuYB(rootNamespace) ? assemblyName : rootNamespace);
				num = 2;
				break;
			}
		}
	}

	public override void AddDefaultReferences()
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_00bd, IL_00de, IL_00ed, IL_01c4, IL_01d3
		int num = 7;
		Assembly[] array = default(Assembly[]);
		string text = default(string);
		Assembly assembly = default(Assembly);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					array = (Assembly[])Emp3M2hNYXX68ZnG3y7J();
					num = 16;
					break;
				case 5:
					text = (string)FoTld3hNLIGPgT4VFxMQ(assembly);
					num2 = 3;
					continue;
				case 19:
					return;
				case 9:
					AddReference(assembly);
					num2 = 4;
					continue;
				case 17:
					if (assembly.IsDynamic)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 5;
				case 11:
					if (!I4ECllhNsDFagZiC5tPX(assembly))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 3:
					if (xcWtAshNjVCyRJUROuYB(hwWnpQhNUEt93wKIVPSs(assembly)))
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				case 18:
					AddDefaultReferencesFromConfig(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112717108));
					num2 = 10;
					continue;
				default:
					if (YQpVYMhNcK4bcSrqrPqm(text, yADEBbhN5hqo09FBLkjR(0x7C1EE318 ^ 0x7C1EE97C)))
					{
						num2 = 13;
						continue;
					}
					goto case 1;
				case 7:
					base.AddDefaultReferences();
					num = 6;
					break;
				case 13:
					if (YQpVYMhNcK4bcSrqrPqm(text, yADEBbhN5hqo09FBLkjR(0x12441CA4 ^ 0x1244168A)))
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				case 8:
				case 15:
					if (num3 >= array.Length)
					{
						num = 19;
						break;
					}
					goto case 14;
				case 1:
				case 2:
				case 4:
				case 12:
					num3++;
					num2 = 15;
					continue;
				case 6:
					AddReferences(ModelReferenceProviders);
					num2 = 18;
					continue;
				case 16:
					num3 = 0;
					num2 = 8;
					continue;
				case 14:
					assembly = array[num3];
					num2 = 17;
					continue;
				case 10:
					AddDefaultReferencesFromElmaConfig((string)yADEBbhN5hqo09FBLkjR(-561074844 ^ -561092802));
					num2 = 20;
					continue;
				}
				break;
			}
		}
	}

	public virtual void AddMetadata(IMetadata metadata, GenerationParams generationParams = null)
	{
		//Discarded unreachable code: IL_00ed, IL_00fc, IL_0144, IL_015a, IL_0164, IL_01b8, IL_01c7, IL_0331, IL_0340, IL_034f, IL_035f, IL_036e
		int num = 32;
		ICodeGenerator codeGenerator = default(ICodeGenerator);
		int num3 = default(int);
		ICodeItemMetadata codeItemMetadata = default(ICodeItemMetadata);
		string name = default(string);
		GeneratedFileInfo generatedFileInfo = default(GeneratedFileInfo);
		GeneratedFileInfo[] array = default(GeneratedFileInfo[]);
		GeneratedFileType generatedFileType = default(GeneratedFileType);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 16:
					codeGenerator.Metadata = metadata;
					num = 2;
					break;
				case 12:
				case 22:
				case 24:
					num3++;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 5;
					}
					continue;
				case 31:
					metadata = metadata.CastAsRealType();
					num2 = 13;
					continue;
				case 2:
					codeItemMetadata = metadata as ICodeItemMetadata;
					num = 28;
					break;
				case 28:
					if (codeItemMetadata == null)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 7;
				case 5:
					obj2 = null;
					goto IL_0449;
				case 21:
					obj = MetadataGeneratorService.GetCodeGenerator(metadata);
					goto IL_0461;
				case 17:
					name = (string)xdxrioh3uyZTsaDSfEHd(tVjy3ih3or9cGELfdft4(codeGenerator)) + (string)yADEBbhN5hqo09FBLkjR(0x4D1C1EE4 ^ 0x4D1C0420) + codeItemMetadata.Name + (string)kYAxhqh3IX0SY4Iqin71(generatedFileInfo);
					num2 = 10;
					continue;
				case 7:
					prVPIFh3h5cgi7k2OCKZ(tVjy3ih3or9cGELfdft4(codeGenerator), (string)CriSHeh3bnDaeLuaxWOJ(codeItemMetadata) + (string)yADEBbhN5hqo09FBLkjR(0x637E299B ^ 0x637EE3CB));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 4;
					}
					continue;
				case 32:
					wStpW5hNzm5oLCULaVPh(metadata, yADEBbhN5hqo09FBLkjR(-1088304168 ^ -1088322842));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 31;
					}
					continue;
				case 11:
				case 26:
					if (num3 < array.Length)
					{
						num2 = 27;
						continue;
					}
					return;
				case 27:
				case 30:
					generatedFileInfo = array[num3];
					num2 = 15;
					continue;
				case 13:
					if (generationParams != null)
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 14:
					return;
				case 10:
					AddEmbeddedResource(name, (byte[])vqPpwMh38cT8vSEoA5nT(generatedFileInfo));
					num2 = 22;
					continue;
				case 25:
					if (generatedFileType != GeneratedFileType.EmbeddedResource)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 6;
				case 1:
					E5ISqth3ZRWYbxluEV9S(this, ((Encoding)A7ayfph3vAxrsCUpYUT8()).GetString((byte[])vqPpwMh38cT8vSEoA5nT(generatedFileInfo)));
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 18;
					}
					continue;
				case 8:
					array = (GeneratedFileInfo[])WnoX8gh3QNgiPuYR0l2x(codeGenerator);
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 27;
					}
					continue;
				case 9:
					if (generatedFileType != GeneratedFileType.CS)
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 1;
				case 18:
					coo4Sjh3fHVKUcaHiwUR(codeGenerator, generationParams);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 8;
					}
					continue;
				case 23:
					if (MJlBa0h3BINw9sDp1Umd(type, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 21;
				case 6:
					if (codeItemMetadata != null)
					{
						num2 = 17;
						continue;
					}
					goto case 12;
				case 29:
					num3 = 0;
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 18;
					}
					continue;
				case 4:
					s4VyjFh3EnpFSVrNjIIg(tVjy3ih3or9cGELfdft4(codeGenerator), Co4MbVh3GcOFubJ1Irrb(codeItemMetadata));
					num2 = 20;
					continue;
				case 19:
				case 20:
					if (generationParams != null)
					{
						num2 = 18;
						continue;
					}
					goto case 8;
				case 15:
					generatedFileType = oiGD1Wh3CHqtl8rNb8WX(generatedFileInfo);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					obj2 = ponAyrh3FeQYPiLHFgOf(generationParams);
					goto IL_0449;
				default:
					{
						obj = (ICodeGenerator)Yhfjw2h3W48bXme6eYqV(type);
						goto IL_0461;
					}
					IL_0461:
					codeGenerator = (ICodeGenerator)obj;
					num2 = 16;
					continue;
					IL_0449:
					type = (Type)obj2;
					num2 = 23;
					continue;
				}
				break;
			}
		}
	}

	public override MemoryStream BuildToStream(bool pdb = true, bool doc = true)
	{
		//Discarded unreachable code: IL_0241
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					eeZi1Wh3SPC5rHOjNEJu(this, av9yaZh3eCeLMBMr4RSu());
					num2 = 11;
					continue;
				case 12:
					eeZi1Wh3SPC5rHOjNEJu(this, TypeOf<ISession>.Assembly);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					eeZi1Wh3SPC5rHOjNEJu(this, U4e9irh3qPSkj7S43bis());
					num2 = 16;
					continue;
				case 4:
					eeZi1Wh3SPC5rHOjNEJu(this, wTUragh3VtGhdwHQMZwf());
					num2 = 3;
					continue;
				case 18:
					AddReference((Assembly)wp6bXoh3nG5soerEtRYM());
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 14;
					}
					continue;
				case 5:
				case 19:
					E5ISqth3ZRWYbxluEV9S(this, assemblyInfo);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 6;
					}
					continue;
				case 10:
					eeZi1Wh3SPC5rHOjNEJu(this, VF9rkEh3RJqFFKJqwI97());
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 13;
					}
					continue;
				case 2:
					GenerateAssemblyInfo();
					num2 = 19;
					continue;
				case 6:
					return base.BuildToStream(pdb, doc);
				case 14:
					eeZi1Wh3SPC5rHOjNEJu(this, i8OJ1Xh3T7RWWYqukkyV());
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 12;
					}
					continue;
				case 9:
					AddReference((Assembly)ypjxiPh3OYJWd0buIWEH());
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 17;
					}
					continue;
				case 16:
					eeZi1Wh3SPC5rHOjNEJu(this, LrRPiwh3KE3H14anBF2i());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					if (!NmFd0Dh3NHT09PRanVhH(assemblyInfo))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				default:
					eeZi1Wh3SPC5rHOjNEJu(this, KMxxpkh3kHCISMQe0MPK());
					num2 = 8;
					continue;
				case 11:
					B6fk2fh316K1fGZtgY48(this, hwWnpQhNUEt93wKIVPSs(PLyqsJh3P6O7S89W4JOt(yADEBbhN5hqo09FBLkjR(-583745292 ^ -583555614))));
					num2 = 20;
					continue;
				case 17:
					AddReference((Assembly)lMqmYuh32hlZ1waGEflj());
					num = 7;
					break;
				case 8:
					AddReference(TypeOf<RuntimeBinderException>.Assembly);
					num2 = 18;
					continue;
				case 15:
					eeZi1Wh3SPC5rHOjNEJu(this, TypeOf<DateTimeFormat>.Assembly);
					num2 = 9;
					continue;
				case 1:
					eeZi1Wh3SPC5rHOjNEJu(this, S7d3cOh3XS42kZhLUd1a());
					num2 = 14;
					continue;
				case 3:
					AddReference((Assembly)pQuudth3ip77MRwW6GdH());
					num = 10;
					break;
				}
				break;
			}
		}
	}

	public virtual void GenerateAssemblyInfo(Func<string, string> conversions = null)
	{
		assemblyInfo = ModelProject.GenerateAssemblyInfoFile(conversions);
	}

	public static string[] GetAllReferencedAssembliesFromPath(string path)
	{
		//Discarded unreachable code: IL_011a, IL_0152, IL_0165, IL_0174
		int num = 3;
		int num2 = num;
		AppDomainSetup appDomainSetup = default(AppDomainSetup);
		Assembly assembly = default(Assembly);
		AppDomain appDomain = default(AppDomain);
		string[] result = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				BgI0Moh3aWGRmKCOLsxG(appDomainSetup, EM15Xfh3p7GN9xPAqYfF(hwWnpQhNUEt93wKIVPSs(assembly)));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				appDomain = (AppDomain)rDPbDxh3tfOq6IVgCMX3(l80J4Dh3DBrI4BMykV6o(yADEBbhN5hqo09FBLkjR(-1710575414 ^ -1710631662), Guid.NewGuid().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDCCA3C))), null, appDomainSetup);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				appDomainSetup = new AppDomainSetup();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				assembly = (Assembly)GiyxV1h33fO0VQe939GH();
				num2 = 4;
				continue;
			case 1:
				return result;
			}
			try
			{
				result = ((ReferencedAssembliesResolver)appDomain.CreateInstanceAndUnwrap(assembly.FullName, (string)iFvAwXh3wh0oCbEOsOiD())).GetReferencedAssemblies(path);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				bG9WKwh34DGnhu5dUVkC(appDomain);
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	internal static bool ES0iD8hNlOLVVI7VYXXr()
	{
		return uNjFtGhNd8WBp9nFPBdZ == null;
	}

	internal static ModelAssemblyBuilder vSdd1nhNrsy5kXn4VIFl()
	{
		return uNjFtGhNd8WBp9nFPBdZ;
	}

	internal static void XQqS71hNg15cyyXg5HpM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object yADEBbhN5hqo09FBLkjR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xcWtAshNjVCyRJUROuYB(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Emp3M2hNYXX68ZnG3y7J()
	{
		return ComponentManager.GetAssemblies();
	}

	internal static object FoTld3hNLIGPgT4VFxMQ(object P_0)
	{
		return ComponentManager.GetAssemblyShortName((Assembly)P_0);
	}

	internal static object hwWnpQhNUEt93wKIVPSs(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static bool I4ECllhNsDFagZiC5tPX(object P_0)
	{
		return ComponentManager.IsModelAssembly((Assembly)P_0);
	}

	internal static bool YQpVYMhNcK4bcSrqrPqm(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void wStpW5hNzm5oLCULaVPh(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type ponAyrh3FeQYPiLHFgOf(object P_0)
	{
		return ((GenerationParams)P_0).GeneratorType;
	}

	internal static bool MJlBa0h3BINw9sDp1Umd(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object Yhfjw2h3W48bXme6eYqV(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object tVjy3ih3or9cGELfdft4(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerationParams;
	}

	internal static object CriSHeh3bnDaeLuaxWOJ(object P_0)
	{
		return ((ICodeItemMetadata)P_0).Name;
	}

	internal static void prVPIFh3h5cgi7k2OCKZ(object P_0, object P_1)
	{
		((GenerationParams)P_0).FileName = (string)P_1;
	}

	internal static object Co4MbVh3GcOFubJ1Irrb(object P_0)
	{
		return ((ICodeItemMetadata)P_0).Namespace;
	}

	internal static void s4VyjFh3EnpFSVrNjIIg(object P_0, object P_1)
	{
		((GenerationParams)P_0).Namespace = (string)P_1;
	}

	internal static void coo4Sjh3fHVKUcaHiwUR(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).GenerationParams = (GenerationParams)P_1;
	}

	internal static object WnoX8gh3QNgiPuYR0l2x(object P_0)
	{
		return ((ICodeGenerator)P_0).Generate();
	}

	internal static GeneratedFileType oiGD1Wh3CHqtl8rNb8WX(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Type;
	}

	internal static object A7ayfph3vAxrsCUpYUT8()
	{
		return Encoding.UTF8;
	}

	internal static object vqPpwMh38cT8vSEoA5nT(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Data;
	}

	internal static void E5ISqth3ZRWYbxluEV9S(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddSourceCode((string)P_1);
	}

	internal static object xdxrioh3uyZTsaDSfEHd(object P_0)
	{
		return ((GenerationParams)P_0).Namespace;
	}

	internal static object kYAxhqh3IX0SY4Iqin71(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Extension;
	}

	internal static object wTUragh3VtGhdwHQMZwf()
	{
		return TypeOf<Uri>.Assembly;
	}

	internal static void eeZi1Wh3SPC5rHOjNEJu(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddReference((Assembly)P_1);
	}

	internal static object pQuudth3ip77MRwW6GdH()
	{
		return TypeOf<IQueryable>.Assembly;
	}

	internal static object VF9rkEh3RJqFFKJqwI97()
	{
		return TypeOf<RequiredAttribute>.Assembly;
	}

	internal static object U4e9irh3qPSkj7S43bis()
	{
		return TypeOf<System.Configuration.Configuration>.Assembly;
	}

	internal static object LrRPiwh3KE3H14anBF2i()
	{
		return TypeOf<HttpContext>.Assembly;
	}

	internal static object S7d3cOh3XS42kZhLUd1a()
	{
		return TypeOf<MvcHtmlString>.Assembly;
	}

	internal static object i8OJ1Xh3T7RWWYqukkyV()
	{
		return TypeOf<IEntity>.Assembly;
	}

	internal static object KMxxpkh3kHCISMQe0MPK()
	{
		return TypeOf<ISet>.Assembly;
	}

	internal static object wp6bXoh3nG5soerEtRYM()
	{
		return TypeOf<Color>.Assembly;
	}

	internal static object ypjxiPh3OYJWd0buIWEH()
	{
		return TypeOf<AuditLevel>.Assembly;
	}

	internal static object lMqmYuh32hlZ1waGEflj()
	{
		return TypeOf<WebService>.Assembly;
	}

	internal static object av9yaZh3eCeLMBMr4RSu()
	{
		return TypeOf<Formatting>.Assembly;
	}

	internal static object PLyqsJh3P6O7S89W4JOt(object P_0)
	{
		return Assembly.Load((string)P_0);
	}

	internal static void B6fk2fh316K1fGZtgY48(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddReference((string)P_1);
	}

	internal static bool NmFd0Dh3NHT09PRanVhH(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static object GiyxV1h33fO0VQe939GH()
	{
		return TypeOf<ModelAssemblyBuilder>.Assembly;
	}

	internal static object EM15Xfh3p7GN9xPAqYfF(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static void BgI0Moh3aWGRmKCOLsxG(object P_0, object P_1)
	{
		((AppDomainSetup)P_0).ApplicationBase = (string)P_1;
	}

	internal static object l80J4Dh3DBrI4BMykV6o(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object rDPbDxh3tfOq6IVgCMX3(object P_0, object P_1, object P_2)
	{
		return AppDomain.CreateDomain((string)P_0, (Evidence)P_1, (AppDomainSetup)P_2);
	}

	internal static object iFvAwXh3wh0oCbEOsOiD()
	{
		return TypeOf<ReferencedAssembliesResolver>.FullName;
	}

	internal static void bG9WKwh34DGnhu5dUVkC(object P_0)
	{
		AppDomain.Unload((AppDomain)P_0);
	}
}
