using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Design;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Components;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Rebranding;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Gettext.Cs;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA;

public class SR
{
	internal interface ILocalizer
	{
		string Localize();
	}

	[Serializable]
	internal abstract class LocalizableString
	{
		internal class SRTLocalizer : ILocalizer
		{
			private readonly string baseString;

			private static SRTLocalizer oSp1GWZQ7pFfBBve5UBD;

			public SRTLocalizer(string baseString)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				zxagU8ZQmHl6lGnTTqNK();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						this.baseString = baseString;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			public string Localize()
			{
				return (string)dXOFFqZQyoT599r0uJsr(baseString);
			}

			internal static void zxagU8ZQmHl6lGnTTqNK()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool BhZcJsZQximHAFE3B9hq()
			{
				return oSp1GWZQ7pFfBBve5UBD == null;
			}

			internal static SRTLocalizer w74KBbZQ0b0Zk2VeM1TP()
			{
				return oSp1GWZQ7pFfBBve5UBD;
			}

			internal static object dXOFFqZQyoT599r0uJsr(object P_0)
			{
				return T((string)P_0);
			}
		}

		[Serializable]
		[DebuggerDisplay("null")]
		private class NullLocalizableString : LocalizableString
		{
			internal static object O87qLRZQMVTHHrGnpR0E;

			internal override string GetLocalized()
			{
				return null;
			}

			public NullLocalizableString()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				HjIUSoZQds9jhWq5oZSl();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static void HjIUSoZQds9jhWq5oZSl()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool unWOuaZQJ2GVeE5iGCDA()
			{
				return O87qLRZQMVTHHrGnpR0E == null;
			}

			internal static NullLocalizableString wZLFD7ZQ94hWu6xjvRYK()
			{
				return (NullLocalizableString)O87qLRZQMVTHHrGnpR0E;
			}
		}

		[Serializable]
		[DebuggerDisplay("\"\"")]
		private class EmptyLocalizableString : LocalizableString
		{
			internal static object z3ZaxDZQl5Ph3SGMBgD6;

			internal override string GetLocalized()
			{
				return "";
			}

			public EmptyLocalizableString()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				ikUNt8ZQ5sptBVKPRqeR();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static void ikUNt8ZQ5sptBVKPRqeR()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool ne5w3OZQr9HA0NvoH2s6()
			{
				return z3ZaxDZQl5Ph3SGMBgD6 == null;
			}

			internal static EmptyLocalizableString DVvyGJZQglt27fOonKn1()
			{
				return (EmptyLocalizableString)z3ZaxDZQl5Ph3SGMBgD6;
			}
		}

		[Serializable]
		[DebuggerDisplay("{@string}")]
		private class NonLocalizableString : LocalizableString
		{
			private readonly object @string;

			internal static object RsJZjUZQjg3VlyIOv3RO;

			public NonLocalizableString(string @string)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				nGPSibZQUVXSaC4WlCgR();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						this.@string = @string;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			internal override string GetLocalized()
			{
				return (string)@string;
			}

			internal static void nGPSibZQUVXSaC4WlCgR()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool RdNiTvZQYorIpdyrCJ5a()
			{
				return RsJZjUZQjg3VlyIOv3RO == null;
			}

			internal static NonLocalizableString M0OwCnZQL2vuRcAdx0XY()
			{
				return (NonLocalizableString)RsJZjUZQjg3VlyIOv3RO;
			}
		}

		[Serializable]
		[DebuggerDisplay("{GetLocalized()}")]
		private class LocalizerLocalizableString : LocalizableString, ISerializable
		{
			[Serializable]
			private class EmptyLocalizer : ILocalizer
			{
				private readonly object baseString;

				internal static object MnNivwZpCOlstr49uIHN;

				public EmptyLocalizer(ILocalizer localizer)
				{
					//Discarded unreachable code: IL_002a, IL_002f
					tDpdSxZpZGmWOF55nlsc();
					base._002Ector();
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num = 1;
					}
					while (true)
					{
						switch (num)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							baseString = EktifHZpuvCS7nWguXtC(localizer);
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num = 0;
							}
							break;
						}
					}
				}

				public string Localize()
				{
					return (string)baseString;
				}

				internal static void tDpdSxZpZGmWOF55nlsc()
				{
					SingletonReader.JJCZtPuTvSt();
				}

				internal static object EktifHZpuvCS7nWguXtC(object P_0)
				{
					return ((ILocalizer)P_0).Localize();
				}

				internal static bool d3KquBZpv7k1EJFKxgaH()
				{
					return MnNivwZpCOlstr49uIHN == null;
				}

				internal static EmptyLocalizer MvrbdBZp8tWZvYGfrrYt()
				{
					return (EmptyLocalizer)MnNivwZpCOlstr49uIHN;
				}
			}

			[Component(Order = 1)]
			private class ResetLocalizationCache : ITranslateChangeHandler
			{
				internal static object H7Hsp6ZpIbFsio4JRtnV;

				public void Execute()
				{
					//Discarded unreachable code: IL_0036, IL_0045, IL_0050, IL_0109, IL_0168, IL_01a0, IL_01af
					int num = 1;
					int num2 = num;
					IEnumerator<KeyValuePair<string[], object>> enumerator = default(IEnumerator<KeyValuePair<string[], object>>);
					KeyValuePair<string[], object> current = default(KeyValuePair<string[], object>);
					int num4 = default(int);
					while (true)
					{
						switch (num2)
						{
						case 4:
							try
							{
								while (true)
								{
									IL_007e:
									int num3;
									if (!poqytWZpiqib6uYeJ0lZ(enumerator))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
										{
											num3 = 0;
										}
										goto IL_0054;
									}
									goto IL_00c1;
									IL_00c1:
									current = enumerator.Current;
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
									{
										num3 = 2;
									}
									goto IL_0054;
									IL_0054:
									while (true)
									{
										switch (num3)
										{
										case 5:
											goto IL_007e;
										case 7:
											num4 = 0;
											num3 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
											{
												num3 = 3;
											}
											continue;
										case 4:
											goto IL_00c1;
										case 6:
											num4++;
											num3 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
											{
												num3 = 1;
											}
											continue;
										case 1:
										case 3:
											if (num4 >= current.Key.Length)
											{
												num3 = 5;
												continue;
											}
											goto case 2;
										case 2:
											current.Key[num4] = null;
											num3 = 6;
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
								if (enumerator != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											fEdfZqZpRccDMW5GJ5hx(enumerator);
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
											{
												num5 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							goto case 2;
						case 1:
							resetLocalizationCache = true;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							resetLocalizationCache = false;
							num2 = 3;
							break;
						case 3:
							return;
						default:
							enumerator = LocalizedStringsAll.GetEnumerator();
							num2 = 4;
							break;
						}
					}
				}

				public ResetLocalizationCache()
				{
					//Discarded unreachable code: IL_002a, IL_002f
					nuQwB5ZpqIoxB65d7J2G();
					base._002Ector();
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num = 0;
					}
					switch (num)
					{
					case 0:
						break;
					}
				}

				internal static bool poqytWZpiqib6uYeJ0lZ(object P_0)
				{
					return ((IEnumerator)P_0).MoveNext();
				}

				internal static void fEdfZqZpRccDMW5GJ5hx(object P_0)
				{
					((IDisposable)P_0).Dispose();
				}

				internal static bool sDvbxBZpV9dtX3Mhg9wC()
				{
					return H7Hsp6ZpIbFsio4JRtnV == null;
				}

				internal static ResetLocalizationCache VaE8QKZpSes4TlwLjoYo()
				{
					return (ResetLocalizationCache)H7Hsp6ZpIbFsio4JRtnV;
				}

				internal static void nuQwB5ZpqIoxB65d7J2G()
				{
					SingletonReader.JJCZtPuTvSt();
				}
			}

			private static readonly IDictionary<string[], object> LocalizedStringsAll;

			private static readonly IDictionary<int, int> LCIDIndexes;

			private static bool resetLocalizationCache;

			[ThreadStatic]
			private static int lcidThread;

			[ThreadStatic]
			private static int lcidIndex;

			private readonly object localizer;

			private object localizedStrings;

			private static object eVOUArZQsEvXsG3NKOrU;

			public LocalizerLocalizableString(ILocalizer localizer)
			{
				//Discarded unreachable code: IL_003b, IL_0040
				EhbRVDZCFUdPSRpe6yCS();
				localizedStrings = new string[2];
				base._002Ector();
				int num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					default:
						LocalizedStringsAll.Add((string[])localizedStrings, null);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num = 1;
						}
						break;
					case 2:
						this.localizer = localizer;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			public LocalizerLocalizableString(SerializationInfo info, StreamingContext context)
			{
				//Discarded unreachable code: IL_003b, IL_0040
				EhbRVDZCFUdPSRpe6yCS();
				localizedStrings = new string[2];
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					localizer = (ILocalizer)jgRWoRZCW4Bs1vD3YxYV(info, cuVi0YZCB6ivq0ENcULo(-675505729 ^ -675627525), typeof(ILocalizer));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num = 1;
					}
				}
			}

			~LocalizerLocalizableString()
			{
				//Discarded unreachable code: IL_0051, IL_0088, IL_009b, IL_00aa
				switch (1)
				{
				case 0:
					break;
				case 1:
					try
					{
						LocalizedStringsAll.Remove((string[])localizedStrings);
						int num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num = 0;
						}
						switch (num)
						{
						case 0:
							break;
						}
						break;
					}
					finally
					{
						dRY0ODZCoXLxjsHeJ8vo(this);
						int num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
					}
				}
			}

			internal override string GetLocalized()
			{
				//Discarded unreachable code: IL_00b4, IL_0115, IL_0146, IL_0278, IL_02b0, IL_02bf
				int num = 7;
				int num2 = num;
				LocalizerLocalizableString localizerLocalizableString = default(LocalizerLocalizableString);
				int num3 = default(int);
				string text = default(string);
				bool lockTaken = default(bool);
				string[] array = default(string[]);
				while (true)
				{
					switch (num2)
					{
					case 7:
						if (!futureTranslate)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num2 = 6;
							}
							break;
						}
						goto case 2;
					case 9:
						localizerLocalizableString = this;
						num2 = 3;
						break;
					case 2:
						return (string)WRjkddZCbBAW2dFpMVNJ(localizer);
					case 6:
						num3 = AuXbfcZCh5ZADxOQl9Yu();
						num2 = 8;
						break;
					case 5:
						text = (string)((object[])localizedStrings)[num3];
						num2 = 10;
						break;
					case 10:
						if (text != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 11;
					case 11:
						text = (string)(((object[])localizedStrings)[num3] = ((ILocalizer)localizer).Localize());
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 4;
						}
						break;
					case 1:
					case 4:
						return text;
					default:
						try
						{
							Monitor.Enter(localizerLocalizableString, ref lockTaken);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 5:
									localizedStrings = array;
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num4 = 6;
									}
									continue;
								case 7:
									RSwoKSZCGbbjcoNnjBbs(localizedStrings, array, 0);
									num4 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
									{
										num4 = 2;
									}
									continue;
								case 3:
									LocalizedStringsAll.Remove((string[])localizedStrings);
									num4 = 2;
									continue;
								case 2:
									if (!resetLocalizationCache)
									{
										num4 = 7;
										continue;
									}
									goto case 5;
								default:
									LocalizedStringsAll.Add(array, null);
									num4 = 3;
									continue;
								case 4:
									array = new string[num3 + 1];
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									if (((Array)localizedStrings).Length <= num3)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
										{
											num4 = 4;
										}
										continue;
									}
									break;
								case 6:
									break;
								}
								break;
							}
						}
						finally
						{
							if (lockTaken)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										nQR8jiZCEL6ZWpx82p8T(localizerLocalizableString);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 5;
					case 8:
						if (((Array)localizedStrings).Length <= num3)
						{
							num2 = 9;
							break;
						}
						goto case 5;
					case 3:
						lockTaken = false;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			private static int GetLCIDIndex()
			{
				//Discarded unreachable code: IL_005c, IL_00f8, IL_0130
				int num = 1;
				IDictionary<int, int> lCIDIndexes = default(IDictionary<int, int>);
				bool lockTaken = default(bool);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 6:
							try
							{
								Monitor.Enter(lCIDIndexes, ref lockTaken);
								int num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num3 = 0;
								}
								while (true)
								{
									switch (num3)
									{
									default:
										if (!LCIDIndexes.TryGetValue(CV7TvvZCfY9mTIx1qh8B(), out lcidIndex))
										{
											num3 = 2;
											continue;
										}
										break;
									case 2:
										LCIDIndexes[CurrentLCID] = (lcidIndex = AEH7eGZCQR22cyNIBnrn(LCIDIndexes));
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
										{
											num3 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							finally
							{
								if (lockTaken)
								{
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
									{
										num4 = 0;
									}
									while (true)
									{
										switch (num4)
										{
										default:
											nQR8jiZCEL6ZWpx82p8T(lCIDIndexes);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
											{
												num4 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
							goto case 4;
						case 4:
							lcidThread = CV7TvvZCfY9mTIx1qh8B();
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num2 = 3;
							}
							continue;
						case 3:
							return lcidIndex;
						case 1:
							if (lcidThread != CV7TvvZCfY9mTIx1qh8B())
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 3;
						case 5:
							lCIDIndexes = LCIDIndexes;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
							{
								num2 = 2;
							}
							continue;
						case 2:
							lockTaken = false;
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num2 = 5;
							}
							continue;
						default:
							if (!LCIDIndexes.TryGetValue(CurrentLCID, out lcidIndex))
							{
								break;
							}
							goto case 4;
						}
						break;
					}
					num = 5;
				}
			}

			public void GetObjectData(SerializationInfo info, StreamingContext context)
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
						DBs6X4ZCCqFmTMV83drr(info, cuVi0YZCB6ivq0ENcULo(0x1DE3DD89 ^ 0x1DE5F9CD), (localizer as EmptyLocalizer) ?? new EmptyLocalizer((ILocalizer)localizer));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			static LocalizerLocalizableString()
			{
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						LocalizedStringsAll = new ConcurrentDictionary<string[], object>();
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 4;
						}
						break;
					case 4:
						LCIDIndexes = new Dictionary<int, int>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						return;
					case 3:
						EhbRVDZCFUdPSRpe6yCS();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 2;
						}
						break;
					default:
						resetLocalizationCache = false;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static void EhbRVDZCFUdPSRpe6yCS()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool LEsphqZQcaau6U9eFS2R()
			{
				return eVOUArZQsEvXsG3NKOrU == null;
			}

			internal static LocalizerLocalizableString aCso0FZQzmXn3bpwV2RL()
			{
				return (LocalizerLocalizableString)eVOUArZQsEvXsG3NKOrU;
			}

			internal static object cuVi0YZCB6ivq0ENcULo(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object jgRWoRZCW4Bs1vD3YxYV(object P_0, object P_1, Type P_2)
			{
				return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
			}

			internal static void dRY0ODZCoXLxjsHeJ8vo(object P_0)
			{
				P_0.Finalize();
			}

			internal static object WRjkddZCbBAW2dFpMVNJ(object P_0)
			{
				return ((ILocalizer)P_0).Localize();
			}

			internal static int AuXbfcZCh5ZADxOQl9Yu()
			{
				return GetLCIDIndex();
			}

			internal static void RSwoKSZCGbbjcoNnjBbs(object P_0, object P_1, int P_2)
			{
				((Array)P_0).CopyTo((Array)P_1, P_2);
			}

			internal static void nQR8jiZCEL6ZWpx82p8T(object P_0)
			{
				Monitor.Exit(P_0);
			}

			internal static int CV7TvvZCfY9mTIx1qh8B()
			{
				return CurrentLCID;
			}

			internal static int AEH7eGZCQR22cyNIBnrn(object P_0)
			{
				return ((ICollection<KeyValuePair<int, int>>)P_0).Count;
			}

			internal static void DBs6X4ZCCqFmTMV83drr(object P_0, object P_1, object P_2)
			{
				((SerializationInfo)P_0).AddValue((string)P_1, P_2);
			}
		}

		private static ContextVars.Local<bool> runWithSRLocalizer;

		private static LocalizableString TCqMkNfHTg6OacbYr3bl;

		public static LocalizableString Null { get; }

		public static LocalizableString Empty { get; }

		internal static LocalizableString Create(ILocalizer localizer)
		{
			return new LocalizerLocalizableString(localizer);
		}

		internal static void RunWithSRLocalizer(Action action)
		{
			//Discarded unreachable code: IL_0077, IL_00b4, IL_00c7, IL_00d6
			int num = 3;
			int num2 = num;
			bool value = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					runWithSRLocalizer.Value = true;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					try
					{
						RunWithCulture((CultureInfo)XeJVFAfHO6UHlUqnsEwO(), action);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						runWithSRLocalizer.Value = value;
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 3:
					value = runWithSRLocalizer.Value;
					num2 = 2;
					break;
				case 0:
					return;
				}
			}
		}

		public static implicit operator LocalizableString(string @string)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return new LocalizerLocalizableString(new SRTLocalizer(@string));
				case 1:
					if (!runWithSRLocalizer.Value)
					{
						return new NonLocalizableString(@string);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public static implicit operator string(LocalizableString str)
		{
			return (string)V3ZGE3fH2xaOEq6MDE1U(str);
		}

		internal abstract string GetLocalized();

		protected LocalizableString()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			cN3EVWfHe2rwo9gLU55M();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static LocalizableString()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					Empty = new EmptyLocalizableString();
					num2 = 4;
					break;
				case 1:
					cN3EVWfHe2rwo9gLU55M();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				default:
					Null = new NullLocalizableString();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					runWithSRLocalizer = new ContextVars.Local<bool>();
					num2 = 3;
					break;
				case 3:
					return;
				}
			}
		}

		internal static object XeJVFAfHO6UHlUqnsEwO()
		{
			return KeyCultureInfo;
		}

		internal static bool R7nRUGfHkguICMrR8g1j()
		{
			return TCqMkNfHTg6OacbYr3bl == null;
		}

		internal static LocalizableString euPYMJfHnWgx2KZSFsUu()
		{
			return TCqMkNfHTg6OacbYr3bl;
		}

		internal static object V3ZGE3fH2xaOEq6MDE1U(object P_0)
		{
			return ((LocalizableString)P_0).GetLocalized();
		}

		internal static void cN3EVWfHe2rwo9gLU55M()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly List<ResourceManager> managers;

	private static readonly Dictionary<CultureInfo, Dictionary<string, string>> localizationStrings;

	private static readonly ReaderWriterLockSlim localizationStringsRWLock;

	internal static bool WatcherDisable;

	private static string resourcesDir;

	private static string fileFormat;

	private static FileSystemWatcher _watcher;

	private static LanguagesMap _languagesMap;

	private static ILocalizationService _localizationService;

	public static string Dir;

	private static LanguageHolder _languageHolder;

	private static object _watcherWorks;

	private static readonly object _languageHolderSinch;

	private static readonly Regex TranslationVariant;

	[ThreadStatic]
	private static bool futureTranslate;

	[ThreadStatic]
	private static bool escapeQuote;

	private static FileSystemWatcher settigsFileWatcher;

	private static Dictionary<string, string> settigsStrings;

	private static readonly ReaderWriterLockSlim settigsObjectsRWLock;

	private static readonly Dictionary<string, object> settigsObjects;

	public const string TranslateSRT = "SR.T";

	public const string FutureTranslateSRT = "SR.M";

	private static Regex formatParse;

	private static string futureTranslateSRTParse1;

	private static string futureTranslateSRTParse2;

	private static string futureTranslateSRTParse3;

	private static string futureTranslateSRTParse4;

	private static readonly string translateSRTFormat;

	private static Regex translateSRTParse;

	private static FieldInfo exceptionMessageField;

	internal const string InternationalCultureName = "en-US";

	private static SR hhETXDEKMSWwCMFllS2;

	private static ILocalizationService LocalizationService
	{
		get
		{
			int num = 1;
			int num2 = num;
			ILocalizationService localizationService;
			while (true)
			{
				switch (num2)
				{
				case 1:
					localizationService = _localizationService;
					if (localizationService != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					localizationService = (_localizationService = Locator.GetService<ILocalizationService>());
					break;
				}
				break;
			}
			return localizationService;
		}
	}

	public static CultureInfo KeyCultureInfo => new CultureInfo((string)vrPDjpEk9ZyFJxtBPVT(-234299632 ^ -234306220));

	public static LanguagesMap LanguagesMap
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_languagesMap != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					_languagesMap = (LanguagesMap)TfqWJrEJmXGOFKOZeAv(sLXJnbEMYC63UfMFJ9W());
					num2 = 3;
					break;
				default:
					return _languagesMap;
				}
			}
		}
	}

	public static int CurrentLCID
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return 0;
				default:
					return DHJVtgfOCny6u95QqrJ(TbORhafn2l9tC8ugc3q());
				case 3:
					if (!futureTranslate)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 2:
					if (TbORhafn2l9tC8ugc3q() != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
			}
		}
	}

	public static string ResourcesDirectory
	{
		get
		{
			return resourcesDir;
		}
		set
		{
			resourcesDir = value;
		}
	}

	public static string FileFormat
	{
		get
		{
			return fileFormat;
		}
		set
		{
			fileFormat = value;
		}
	}

	public static bool Is12Hours => ((string)Yu5m4rfjUyiwlEs6QHV(((CultureInfo)ENoAQ5fRxFpE3Db0aA0(ilBR3WfS9bcKJDpOKiS())).DateTimeFormat)).Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630EC67));

	public static string Login => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x1C9495B4 ^ 0x1C94B51E));

	public static string Password => T((string)vrPDjpEk9ZyFJxtBPVT(0x638095EB ^ 0x6380B525));

	public static string CurrentPassword => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1411196499 ^ -1411188365));

	public static string NewPassword => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542729885));

	public static string ConfirmPassword => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x53FA00CE ^ 0x53FA21D4));

	public static string Version => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675497735));

	public static string SystemEdition => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x31326106 ^ 0x31324050));

	public static string FillRequiredField => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x17ADCCD8 ^ 0x17ADEDA2));

	public static string WrongInputField => T((string)vrPDjpEk9ZyFJxtBPVT(0x18A6761F ^ 0x18A657AB));

	public static string CascadeMode_None => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-812025778 ^ -812033626));

	public static string CascadeMode_All => T((string)vrPDjpEk9ZyFJxtBPVT(-1978478350 ^ -1978470132));

	public static string CascadeMode_SaveUpdate => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC2EF8));

	public static string AddPortlet => T((string)vrPDjpEk9ZyFJxtBPVT(0x53CACA3 ^ 0x53C8ECF));

	public static string Loading => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767728277));

	public static string NoPortlet => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-210725949 ^ -210718359));

	public static string PleaseWaitText => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1411196499 ^ -1411187867));

	public static string Search => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-2107978722 ^ -2107969824));

	public static string Searching => T((string)vrPDjpEk9ZyFJxtBPVT(0x10E41EDB ^ 0x10E43DD7));

	public static string Show => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-2138160520 ^ -2138152616));

	public static string CatalogPortlet => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1939377524 ^ -1939385928));

	public static string Description => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088296832));

	public static string TypeID => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751185268));

	public static string DisplayName => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x2A7797B7 ^ 0x2A77B423));

	public static string DatabaseTable => T((string)vrPDjpEk9ZyFJxtBPVT(-138018305 ^ -138010041));

	public static string Name => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-218496594 ^ -218488248));

	public static string Untitled => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1146510045 ^ -1146517799));

	public static string PropertyName => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882117256));

	public static string DatabaseTableColumn => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x7EC153F ^ 0x7EC317F));

	public static string DataType => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x92F12D5 ^ 0x92F36BD));

	public static string Settings => T((string)vrPDjpEk9ZyFJxtBPVT(0x6A81B9B4 ^ 0x6A819D34));

	public static string Required => T((string)vrPDjpEk9ZyFJxtBPVT(-521266112 ^ -521258794));

	public static string InputIntNumber => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x3B36AB09 ^ 0x3B368FC7));

	public static string InputNumber => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138949888));

	public static string InputNumberLtGt => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6E7F1D));

	public static string InputNumberLt => T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785997F));

	public static string InputNumberGt => T((string)vrPDjpEk9ZyFJxtBPVT(-1765851862 ^ -1765861220));

	public static string InputNotConstraint => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459564837));

	public static string InputDateTimeLtGt => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x1637C429 ^ 0x1637E231));

	public static string InputDateLt => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-210725949 ^ -210717251));

	public static string InputDateGt => T((string)vrPDjpEk9ZyFJxtBPVT(0x57A5235E ^ 0x57A50592));

	public static string InputStringTimeLtGt => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-345420348 ^ -345412898));

	public static string InputStringLt => T((string)vrPDjpEk9ZyFJxtBPVT(0x4785BC0D ^ 0x47859B89));

	public static string InputStringGt => T((string)vrPDjpEk9ZyFJxtBPVT(-1487388570 ^ -1487378512));

	public static string DeleteQuestion => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x76DD48E ^ 0x76DFCA6));

	public static string Question => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29248161));

	public static string Add => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69996735));

	public static string Edit => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411190323));

	public static string Delete => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-889460160 ^ -889470402));

	public static string Hide => T((string)vrPDjpEk9ZyFJxtBPVT(-2138958856 ^ -2138948760));

	public static string MoveUp => T((string)vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69996627));

	public static string MoveDown => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1710575414 ^ -1710581658));

	public static string Copy => T((string)vrPDjpEk9ZyFJxtBPVT(-1978478350 ^ -1978468278));

	public static string Paste => T((string)vrPDjpEk9ZyFJxtBPVT(-867826612 ^ -867816292));

	public static string Create => T((string)vrPDjpEk9ZyFJxtBPVT(0x17ADCCD8 ^ 0x17ADE43C));

	public static string Save => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1921202237 ^ -1921192139));

	public static string Cancel => T((string)vrPDjpEk9ZyFJxtBPVT(0x103FE975 ^ 0x103FC079));

	public static string Close => T((string)vrPDjpEk9ZyFJxtBPVT(-105199646 ^ -105189694));

	public static string Select => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-210725949 ^ -210715919));

	public static string Back => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1998538950 ^ -1998545282));

	public static string Next => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77BEE5));

	public static string Ok => T((string)vrPDjpEk9ZyFJxtBPVT(0x18A6761F ^ 0x18A65F7F));

	public static string Enable => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1822890472 ^ -1822896272));

	public static string Yes => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146516385));

	public static string No => T((string)vrPDjpEk9ZyFJxtBPVT(0x2A7797B7 ^ 0x2A77BE33));

	public static string MinValue => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538513000));

	public static string MaxValue => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542732249));

	public static string ElmaDesigner => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x1ECE530A ^ 0x1ECE7AE2));

	public static string ControlIsNotInitialized => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x34185E55 ^ 0x3418745D));

	public static string ValidationError => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x61EC0CB8 ^ 0x61EC26EE));

	public static string EntityNameValidateMessage => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1710575414 ^ -1710581182));

	public static string PropertyNameValidateMessage => T((string)vrPDjpEk9ZyFJxtBPVT(0x34A6D230 ^ 0x34A6F97C));

	public static string EnumNameValidateMessage => T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420750538));

	public static string Feedback => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x12441CA4 ^ 0x1244304C));

	public static string Authorization => T((string)vrPDjpEk9ZyFJxtBPVT(0x18A6761F ^ 0x18A65B17));

	public static string NoTrueLogin => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088297222));

	public static string SelectUser => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583733884));

	public static string RequiredLogin => T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4C56B7));

	public static string RequiredLoginTooltip => T((string)vrPDjpEk9ZyFJxtBPVT(0x3CE17B75 ^ 0x3CE156A7));

	public static string Remember => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-488881205 ^ -488870439));

	public static string Enter => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x42643203 ^ 0x42641C5B));

	public static string LoggedOut => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-2107978722 ^ -2107973020));

	public static string RowCount => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x31326106 ^ 0x31324F8E));

	public static string Records => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x463A0F3C ^ 0x463A21A4));

	public static string Pages => T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A14AB5));

	public static string HomePage => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812034432));

	public static string Administration => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1108654032 ^ -1108646206));

	public static string Users => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0xE1229CF ^ 0xE1206D7));

	public static string RecordsNotFound => T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672130545));

	public static string CreateUser => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x10E41EDB ^ 0x10E43187));

	public static string PersonalInfo => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x34185E55 ^ 0x341871DD));

	public static string RequireChangePassword => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-1123633026 ^ -1123641372));

	public static string ChangePassword => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69998393));

	public static string SaveUserTooltip => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x5F3078B6 ^ 0x5F30575C));

	[Obsolete("Use WeekMonthDay")]
	public static string WeekMonthDayPattern => T((string)vrPDjpEk9ZyFJxtBPVT(-2107978722 ^ -2107966460));

	[Obsolete("Use MonthDayWeek")]
	public static string MonthDayWeekPattern => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x3B36AB09 ^ 0x3B369B53));

	[Obsolete("Use YearMonthDay")]
	public static string YearMonthDayPattern => T((string)vrPDjpEk9ZyFJxtBPVT(-1334993905 ^ -1334989675));

	[Obsolete("Use YearMonthDayWeek")]
	public static string YearMonthDayWeekPattern => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x1FFEF86A ^ 0x1FFEC88C));

	[Obsolete("Use YearMonthDayShortWeek")]
	public static string YearMonthDayShortWeekPattern => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112715304));

	[Obsolete("Use WeekYearMonthDay")]
	public static string WeekYearMonthDayPattern => T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BB8490));

	[Obsolete("Use WeekYearMonthDay2")]
	public static string WeekYearMonthDayPattern2 => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-29254301 ^ -29249683));

	[Obsolete("Use YearMonth")]
	public static string YearMonthPattern => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92F20BB));

	[Obsolete("Use CalendarDDMY")]
	public static string CalendarDDMYPattern => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(0x63ABA4E8 ^ 0x63AB9624));

	[Obsolete("Use CalendarDMDMY")]
	public static string CalendarDMDMYPattern => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-477139494 ^ -477143394));

	[Obsolete("Use CalendarDMYDMY")]
	public static string CalendarDMYDMYPattern => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A818A78));

	[Obsolete("Use ShortMonthDayWeek")]
	public static string ShortMonthDayWeekPattern => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765865134));

	public static string Language => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-882126494 ^ -882121258));

	[Obsolete("Use ToString(\"M\")")]
	public static string DayAndFullMonthPattern => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3DDBBE));

	[Obsolete("Use DateFullMonth")]
	public static string DateFullMonthPattern => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-2138958856 ^ -2138953942));

	public static string[] WeekDayNames
	{
		get
		{
			//Discarded unreachable code: IL_0085, IL_0094, IL_00a4, IL_00b3
			int num = 7;
			int num2 = num;
			int num3 = default(int);
			string[] array = default(string[]);
			while (true)
			{
				switch (num2)
				{
				case 6:
					num3 = 0;
					num2 = 3;
					break;
				default:
					if (num3 <= 6)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 1;
				case 1:
					return array;
				case 7:
					array = new string[7];
					num2 = 6;
					break;
				case 2:
				case 4:
					array[(num3 + 7 - 1) % 7] = (string)((object[])dhmrhyQ3ucja3nk5MgP(TekMapQNQCNsN9fVuBE(TbORhafn2l9tC8ugc3q())))[num3];
					num2 = 5;
					break;
				case 5:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static string Weekend => T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538514172));

	public static string Calendar => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542733125));

	public static string Today => T((string)vrPDjpEk9ZyFJxtBPVT(-978351861 ^ -978338761));

	public static string Partisipants => (string)zQj0ibfrmOi0M6BSYOP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765865372));

	public static string ToInfrom => (string)zQj0ibfrmOi0M6BSYOP(vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -69995927));

	static SR()
	{
		//Discarded unreachable code: IL_04e1, IL_07d9
		int num = 10;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object path;
				switch (num2)
				{
				case 21:
					_watcherWorks = new object();
					num = 8;
					break;
				case 12:
					SUtFUrE4IP1kCbLIbN4(settigsFileWatcher, new FileSystemEventHandler(ClearSettingsCache));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 15;
					}
					continue;
				case 24:
					futureTranslateSRTParse1 = (string)EcubNPE2ApKSGDnHF26(wv2V9uEO2uKL83swaT4(vrPDjpEk9ZyFJxtBPVT(-1978478350 ^ -1978480054), vrPDjpEk9ZyFJxtBPVT(-70007027 ^ -70001207), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475863501)), vrPDjpEk9ZyFJxtBPVT(0x1DE3DD89 ^ 0x1DE3C75B), ((string)vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088302752)).Replace((string)vrPDjpEk9ZyFJxtBPVT(0x1637C429 ^ 0x1637DEED), (string)vrPDjpEk9ZyFJxtBPVT(0x1A33FE36 ^ 0x1A33E4FC)), vrPDjpEk9ZyFJxtBPVT(-234299632 ^ -234306476));
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 21;
					}
					continue;
				case 8:
					_languageHolderSinch = new object();
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 22;
					}
					continue;
				case 11:
					KSiFlZEtHptU6ov4xRF(settigsFileWatcher, new FileSystemEventHandler(ClearSettingsCache));
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 33;
					}
					continue;
				case 6:
					futureTranslate = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					localizationStrings = new Dictionary<CultureInfo, Dictionary<string, string>>();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 14;
					}
					continue;
				case 28:
					futureTranslateSRTParse2 = (string)EcubNPE2ApKSGDnHF26(wv2V9uEO2uKL83swaT4(vrPDjpEk9ZyFJxtBPVT(-672123589 ^ -672125053), vrPDjpEk9ZyFJxtBPVT(-345420348 ^ -345417984), vrPDjpEk9ZyFJxtBPVT(-867826612 ^ -867819898)), vrPDjpEk9ZyFJxtBPVT(0x571EA399 ^ 0x571EB94B), wv2V9uEO2uKL83swaT4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480054), vrPDjpEk9ZyFJxtBPVT(-643786247 ^ -643792067), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475863501)), vrPDjpEk9ZyFJxtBPVT(-1858887263 ^ -1858880973));
					num = 17;
					break;
				case 16:
					fileFormat = GetSetting((string)vrPDjpEk9ZyFJxtBPVT(0xA592A41 ^ 0xA5937F9), (string)vrPDjpEk9ZyFJxtBPVT(-629844702 ^ -629847872));
					num2 = 26;
					continue;
				case 4:
					settigsObjectsRWLock = new ReaderWriterLockSlim();
					num2 = 19;
					continue;
				case 14:
					localizationStringsRWLock = new ReaderWriterLockSlim();
					num = 7;
					break;
				case 31:
				{
					FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(((AppDomain)amhCBBENfPr0FTQhOlV()).BaseDirectory);
					CyKNcHE3LfoF40woUpa(fileSystemWatcher, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A5E7A3));
					csFyHZEpgNend1Trjy2(fileSystemWatcher, false);
					ubcQihEaliD8V6sqHBC(fileSystemWatcher, true);
					m9WcKWEDiq0722G1jS2(fileSystemWatcher, NotifyFilters.FileName | NotifyFilters.LastWrite);
					settigsFileWatcher = fileSystemWatcher;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 6;
					}
					continue;
				}
				case 18:
					translateSRTParse = new Regex((string)lc8hOAE1sRHAJUqTiBu(translateSRTFormat, j5NFCIEPKZBdAXjpiy5(vrPDjpEk9ZyFJxtBPVT(--1418440330 ^ 0x548BB3D8), new string[2]
					{
						(string)vrPDjpEk9ZyFJxtBPVT(-1876063057 ^ -1876061705),
						(string)vrPDjpEk9ZyFJxtBPVT(0x53FA00CE ^ 0x53FA1D90)
					})));
					num2 = 25;
					continue;
				case 34:
					eNikLQEw9g5LUjIp0QO(_watcher, new FileSystemEventHandler(WatcherCreated));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 27;
					}
					continue;
				case 33:
					eNikLQEw9g5LUjIp0QO(settigsFileWatcher, new FileSystemEventHandler(ClearSettingsCache));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 6;
					}
					continue;
				case 20:
					return;
				case 22:
					TranslationVariant = new Regex((string)vrPDjpEk9ZyFJxtBPVT(0x103FE975 ^ 0x103FF327));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 4;
					}
					continue;
				case 29:
					path = eLcujBEHAM4OsWcWIeD(v04rSTE6JPQRN7lmO1M(typeof(SR).TypeHandle).Assembly.Location);
					goto IL_0833;
				case 9:
					managers = new List<ResourceManager>();
					num2 = 2;
					continue;
				case 1:
					futureTranslateSRTParse4 = (string)zDd21wEe2Q9vWeCZ5Vq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138011169), wv2V9uEO2uKL83swaT4(vrPDjpEk9ZyFJxtBPVT(0x7E6E5A0B ^ 0x7E6E40B3), vrPDjpEk9ZyFJxtBPVT(-309639236 ^ -309633672), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FF3BF)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837669873));
					num2 = 23;
					continue;
				case 25:
					settigsObjects = new Dictionary<string, object>();
					num2 = 31;
					continue;
				case 32:
					KSiFlZEtHptU6ov4xRF(_watcher, new FileSystemEventHandler(WatcherCreated));
					num2 = 34;
					continue;
				case 10:
					xTWNKgEn9iEi1QjfS8W();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 4;
					}
					continue;
				default:
					escapeQuote = true;
					num2 = 4;
					continue;
				case 15:
					resourcesDir = GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108650570), (string)vrPDjpEk9ZyFJxtBPVT(0x3C5338FF ^ 0x3C53255D));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 16;
					}
					continue;
				case 27:
					SUtFUrE4IP1kCbLIbN4(_watcher, new FileSystemEventHandler(WatcherCreated));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					Dir = string.Empty;
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					formatParse = new Regex((string)vrPDjpEk9ZyFJxtBPVT(0x49E27B8A ^ 0x49E261F2));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 24;
					}
					continue;
				case 26:
					if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.Designer)
					{
						num2 = 13;
						continue;
					}
					goto case 29;
				case 23:
					translateSRTFormat = (string)vrPDjpEk9ZyFJxtBPVT(0x3C5338FF ^ 0x3C532407) + (string)wv2V9uEO2uKL83swaT4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FFD65D), vrPDjpEk9ZyFJxtBPVT(0x1DE3DD89 ^ 0x1DE3C74D), vrPDjpEk9ZyFJxtBPVT(0x4EDCBA32 ^ 0x4EDCA0F8)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x638088FB);
					num2 = 18;
					continue;
				case 17:
					futureTranslateSRTParse3 = (string)vrPDjpEk9ZyFJxtBPVT(-957824448 ^ -957817248) + (string)wv2V9uEO2uKL83swaT4(vrPDjpEk9ZyFJxtBPVT(0x5A4C7B29 ^ 0x5A4C6191), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210728697), vrPDjpEk9ZyFJxtBPVT(0xE1229CF ^ 0xE123305)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x34184265);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					continue;
				case 30:
					t4Z1yZE7fBklY0hqG9y(text);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					ubcQihEaliD8V6sqHBC(_watcher, true);
					num2 = 20;
					continue;
				case 3:
				{
					FileSystemWatcher obj = new FileSystemWatcher
					{
						IncludeSubdirectories = true
					};
					BkyZ2xExBSVMbjmCg0r(obj, text);
					_watcher = obj;
					num = 32;
					break;
				}
				case 13:
					{
						path = eLcujBEHAM4OsWcWIeD(jHTe4DEAXt2du1YvRsV(((AppDomain)amhCBBENfPr0FTQhOlV()).SetupInformation));
						goto IL_0833;
					}
					IL_0833:
					text = Path.Combine((string)path, resourcesDir);
					num2 = 30;
					continue;
				}
				break;
			}
		}
	}

	protected static void WatcherCreated(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_0051, IL_0088, IL_00bb, IL_0124, IL_0164, IL_016f, IL_017e
		int num = 3;
		int num2 = num;
		object watcherWorks = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					Monitor.Enter(watcherWorks, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					try
					{
						t4Z1yZE7fBklY0hqG9y(Dir);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception ex)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								Rt6iupEmcpmcigB36oL(Logger.Log, fRxTRuE0Fu7IiSgLGiJ(ex), ex);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num5 = 0;
								}
								break;
							}
						}
					}
				}
				finally
				{
					int num6;
					if (!lockTaken)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num6 = 1;
						}
						goto IL_0128;
					}
					goto IL_013e;
					IL_013e:
					uAdJh8Eyu8SUX82LTvH(watcherWorks);
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num6 = 0;
					}
					goto IL_0128;
					IL_0128:
					switch (num6)
					{
					default:
						goto end_IL_0103;
					case 2:
						break;
					case 1:
						goto end_IL_0103;
					case 0:
						goto end_IL_0103;
					}
					goto IL_013e;
					end_IL_0103:;
				}
			case 2:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				watcherWorks = _watcherWorks;
				num2 = 2;
				break;
			}
		}
	}

	public static string GetCultureDir(CultureInfo info)
	{
		return (string)qUO8HQEdMHJcMgVtYQs(ER5pPiE9h18lxXF0djO(info));
	}

	public static string GetCultureDir(string name)
	{
		return (string)ePijyxElsJnePn3Rlaf(Dir, name);
	}

	public static void ReInitSR(string dir)
	{
		//Discarded unreachable code: IL_00e0, IL_0168, IL_019c, IL_01ab, IL_01e2, IL_0275, IL_027f, IL_0306, IL_0315, IL_03c1, IL_041e, IL_042d, IL_043d, IL_044c, IL_04a6, IL_04b9, IL_04c8, IL_0580, IL_0593, IL_05a2, IL_05b3, IL_05c2, IL_05cd, IL_067b, IL_068e, IL_069d, IL_0773, IL_07df, IL_07f2, IL_0801, IL_0856, IL_0865
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_0);
		List<CultureInfo>.Enumerator enumerator = default(List<CultureInfo>.Enumerator);
		CultureInfo current = default(CultureInfo);
		HashSet<string>.Enumerator enumerator2 = default(HashSet<string>.Enumerator);
		List<CultureInfo> cultureNames = default(List<CultureInfo>);
		ResourceSet resourceSet = default(ResourceSet);
		GettextResourceManager val = default(GettextResourceManager);
		CultureInfo current2 = default(CultureInfo);
		IDictionaryEnumerator dictionaryEnumerator = default(IDictionaryEnumerator);
		string text = default(string);
		DictionaryEntry dictionaryEntry = default(DictionaryEntry);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (WatcherDisable)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					Dir = dir;
					num2 = 6;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
				num2 = 3;
				break;
			case 5:
				sx0DOeEgaV9hG4Sac2k(dir);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (w3XdpxEru2SQXqvBqWC(dir))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 5;
			case 8:
				try
				{
					zopcDbE5esKil0UNMTM(localizationStringsRWLock);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							A4UyHMEYUuWXrXPgSA8(localizationStrings);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
							{
								num3 = 2;
							}
							break;
						case 1:
							YWdO0cEjvdVXPX7sQek(managers);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							try
							{
								if (!w3XdpxEru2SQXqvBqWC(dir))
								{
									return;
								}
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num4 = 2;
								}
								while (true)
								{
									switch (num4)
									{
									case 6:
										try
										{
											while (true)
											{
												IL_0639:
												int num5;
												if (!enumerator.MoveNext())
												{
													num5 = 2;
													goto IL_05d1;
												}
												goto IL_0616;
												IL_05d1:
												while (true)
												{
													switch (num5)
													{
													case 3:
														localizationStrings[current] = new Dictionary<string, string>();
														num5 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
														{
															num5 = 1;
														}
														continue;
													case 1:
														goto IL_0639;
													case 2:
														goto end_IL_0639;
													}
													break;
												}
												goto IL_0616;
												IL_0616:
												current = enumerator.Current;
												num5 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
												{
													num5 = 3;
												}
												goto IL_05d1;
												continue;
												end_IL_0639:
												break;
											}
										}
										finally
										{
											((IDisposable)enumerator).Dispose();
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
											{
												num6 = 0;
											}
											switch (num6)
											{
											case 0:
												break;
											}
										}
										goto case 1;
									case 1:
										enumerator2 = _003C_003Ec__DisplayClass27_.resourceNames.GetEnumerator();
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
										{
											num4 = 0;
										}
										continue;
									case 7:
										enumerator = cultureNames.GetEnumerator();
										num4 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
										{
											num4 = 6;
										}
										continue;
									case 4:
										if (F9tHyvELEwA31Ff1ZC4(cultureNames) > 0)
										{
											num4 = 7;
											continue;
										}
										return;
									case 3:
										cultureNames = GetCultureNames();
										num4 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num4 = 4;
										}
										continue;
									case 2:
										new DirectoryInfo(dir).GetDirectories().ForEach(_003C_003Ec__DisplayClass27_._003CReInitSR_003Eb__0);
										num4 = 3;
										continue;
									case 5:
										return;
									}
									try
									{
										while (true)
										{
											IL_0514:
											int num8;
											if (!enumerator2.MoveNext())
											{
												int num7 = 4;
												num8 = num7;
												goto IL_01ba;
											}
											goto IL_04d3;
											IL_01ba:
											while (true)
											{
												switch (num8)
												{
												case 5:
													try
													{
														while (true)
														{
															int num9;
															if (!enumerator.MoveNext())
															{
																num9 = 5;
																goto IL_01f0;
															}
															goto IL_0457;
															IL_01f0:
															while (true)
															{
																switch (num9)
																{
																case 1:
																	resourceSet = ((ResourceManager)(object)val).GetResourceSet(current2, createIfNotExists: true, tryParents: true);
																	num9 = 2;
																	continue;
																case 6:
																{
																	dictionaryEnumerator = (IDictionaryEnumerator)XH6sWAEU0IVwOHVWELH(resourceSet);
																	int num12 = 3;
																	num9 = num12;
																	continue;
																}
																case 2:
																	if (resourceSet == null)
																	{
																		num9 = 7;
																		continue;
																	}
																	goto case 6;
																case 3:
																	try
																	{
																		while (true)
																		{
																			IL_0393:
																			int num10;
																			if (!D7yccqEcy1QouE1npyx(dictionaryEnumerator))
																			{
																				num10 = 8;
																				goto IL_0283;
																			}
																			goto IL_02b1;
																			IL_0283:
																			while (true)
																			{
																				switch (num10)
																				{
																				case 6:
																					break;
																				default:
																					text = dictionaryEntry.Key.ToString();
																					num10 = 5;
																					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
																					{
																						num10 = 5;
																					}
																					continue;
																				case 5:
																					text2 = dictionaryEntry.Value.ToString();
																					num10 = 4;
																					continue;
																				case 1:
																					if (!xhtPxdEs9nG9CKwHKbx(text2))
																					{
																						num10 = 2;
																						continue;
																					}
																					goto IL_0393;
																				case 2:
																					localizationStrings[current2][text] = text2;
																					num10 = 3;
																					continue;
																				case 4:
																					if (xhtPxdEs9nG9CKwHKbx(text))
																					{
																						num10 = 2;
																						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
																						{
																							num10 = 7;
																						}
																						continue;
																					}
																					goto case 1;
																				case 3:
																				case 7:
																					goto IL_0393;
																				case 8:
																					goto end_IL_0393;
																				}
																				break;
																			}
																			goto IL_02b1;
																			IL_02b1:
																			dictionaryEntry = (DictionaryEntry)dictionaryEnumerator.Current;
																			num10 = 0;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
																			{
																				num10 = 0;
																			}
																			goto IL_0283;
																			continue;
																			end_IL_0393:
																			break;
																		}
																	}
																	finally
																	{
																		IDisposable disposable = dictionaryEnumerator as IDisposable;
																		int num11 = 2;
																		while (true)
																		{
																			switch (num11)
																			{
																			case 2:
																				if (disposable != null)
																				{
																					num11 = 0;
																					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
																					{
																						num11 = 0;
																					}
																					continue;
																				}
																				break;
																			default:
																				fNbGRaEzWbfbl76JXxQ(disposable);
																				num11 = 0;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
																				{
																					num11 = 1;
																				}
																				continue;
																			case 1:
																				break;
																			}
																			break;
																		}
																	}
																	break;
																case 4:
																	goto IL_0457;
																case 5:
																	goto end_IL_0248;
																}
																break;
															}
															continue;
															IL_0457:
															current2 = enumerator.Current;
															num9 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
															{
																num9 = 1;
															}
															goto IL_01f0;
															continue;
															end_IL_0248:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator).Dispose();
														int num13 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
														{
															num13 = 0;
														}
														switch (num13)
														{
														case 0:
															break;
														}
													}
													goto IL_0514;
												case 1:
													enumerator = cultureNames.GetEnumerator();
													num8 = 5;
													continue;
												case 2:
													goto IL_0514;
												case 3:
													managers.Add((ResourceManager)(object)val);
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
													{
														num8 = 1;
													}
													continue;
												case 4:
													return;
												}
												break;
											}
											goto IL_04d3;
											IL_04d3:
											val = new GettextResourceManager(enumerator2.Current, dir, fileFormat);
											num8 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
											{
												num8 = 1;
											}
											goto IL_01ba;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num14 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
										{
											num14 = 0;
										}
										switch (num14)
										{
										case 0:
											break;
										}
									}
								}
							}
							catch (Exception ex)
							{
								int num15 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num15 = 0;
								}
								while (true)
								{
									switch (num15)
									{
									case 1:
										return;
									}
									Logger.Log.Error(ex.Message, ex);
									num15 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num15 = 0;
									}
								}
							}
						}
					}
				}
				finally
				{
					vQFfoqfF6L9U9w0pBEm(localizationStringsRWLock);
					int num16 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num16 = 0;
					}
					switch (num16)
					{
					case 0:
						break;
					}
				}
			case 1:
			case 7:
				_003C_003Ec__DisplayClass27_.resourceNames = new HashSet<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751173636) };
				num2 = 8;
				break;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	public static LocalizationHash[] ComputeLocalizationHash()
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_0075, IL_0146, IL_0159, IL_0168
		int num = 2;
		int num2 = num;
		List<LocalizationHash> list = default(List<LocalizationHash>);
		List<CultureInfo>.Enumerator enumerator = default(List<CultureInfo>.Enumerator);
		string text = default(string);
		CultureInfo current = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return list.ToArray();
			case 2:
				list = new List<LocalizationHash>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_00e9:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0079;
						}
						goto IL_00be;
						IL_0079:
						while (true)
						{
							switch (num3)
							{
							case 5:
								text = (string)jNeJPafWELTvdE0VKh7(current);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							default:
								list.Add((LocalizationHash)gWjOp4foyfoRwtYZxrt(text));
								num3 = 3;
								continue;
							case 3:
								goto IL_00e9;
							case 4:
								if (!current.Equals(wI6wbifBevfaFuGnfnY()))
								{
									num3 = 5;
									continue;
								}
								goto IL_00e9;
							case 2:
								goto end_IL_00e9;
							}
							break;
						}
						goto IL_00be;
						IL_00be:
						current = enumerator.Current;
						num3 = 4;
						goto IL_0079;
						continue;
						end_IL_00e9:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 1:
				enumerator = GetCultureNames().GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	public static LocalizationHash ComputeLocalizationHash(string targetPath)
	{
		//Discarded unreachable code: IL_01ad, IL_01e5, IL_0204, IL_0213, IL_0240, IL_024f, IL_0292, IL_02a1, IL_0352, IL_0361, IL_03d7, IL_03ff, IL_043f, IL_044e, IL_045a, IL_0469, IL_0479, IL_0488, IL_04d9, IL_0511, IL_0520
		int num = 3;
		int num2 = num;
		LocalizationHash localizationHash = default(LocalizationHash);
		string local = default(string);
		MD5 mD = default(MD5);
		int num6 = default(int);
		FileStream fileStream2 = default(FileStream);
		string text2 = default(string);
		string text3 = default(string);
		string text = default(string);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				localizationHash = new LocalizationHash
				{
					Local = local
				};
				num2 = 4;
				break;
			case 4:
				if (!Directory.Exists(targetPath))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					mD = (MD5)n5W0AVfhkrNK5UmjAYE();
					num2 = 5;
				}
				break;
			default:
				return localizationHash;
			case 1:
				return localizationHash;
			case 5:
				try
				{
					string[] array = (string[])VTE36ofG6Fk1KyI6i8k(targetPath, vrPDjpEk9ZyFJxtBPVT(-475857671 ^ -475864391));
					int num3 = 16;
					while (true)
					{
						int num7;
						switch (num3)
						{
						case 5:
							return localizationHash;
						case 16:
							num6 = 0;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num3 = 0;
							}
							continue;
						case 10:
							fileStream2 = (FileStream)O0KVcGfExvQOVrb4KWP(text2);
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
							{
								num3 = 13;
							}
							continue;
						case 4:
						case 12:
							if (num6 < array.Length)
							{
								num7 = 14;
								goto IL_00b2;
							}
							goto default;
						case 13:
							try
							{
								List<LocalizationFileHash> fileHashes2 = localizationHash.FileHashes;
								LocalizationFileHash localizationFileHash2 = new LocalizationFileHash();
								SNdTRNffMDU8W0jv0wV(localizationFileHash2, XBHUIKfbQ9HLpIWj9Ln(text2));
								x94ybafCYHWqkFgLZvO(localizationFileHash2, mD.ComputeHash(fileStream2));
								fileHashes2.Add(localizationFileHash2);
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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
								if (fileStream2 == null)
								{
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num9 = 0;
									}
									goto IL_01e9;
								}
								goto IL_021e;
								IL_021e:
								fNbGRaEzWbfbl76JXxQ(fileStream2);
								num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num9 = 0;
								}
								goto IL_01e9;
								IL_01e9:
								switch (num9)
								{
								default:
									goto end_IL_01c4;
								case 0:
									goto end_IL_01c4;
								case 2:
									break;
								case 1:
									goto end_IL_01c4;
								}
								goto IL_021e;
								end_IL_01c4:;
							}
							break;
						default:
							text3 = Path.Combine(targetPath, (string)vrPDjpEk9ZyFJxtBPVT(-488881205 ^ -488874617));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
							{
								num3 = 18;
							}
							continue;
						case 18:
							if (!Directory.Exists(text3))
							{
								return localizationHash;
							}
							num3 = 15;
							continue;
						case 15:
							array = (string[])mUFwmafQI3l24KjKvEC(text3);
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num3 = 11;
							}
							continue;
						case 3:
						case 17:
							if (num6 >= array.Length)
							{
								num3 = 5;
								continue;
							}
							goto case 9;
						case 1:
							num6++;
							num3 = 12;
							continue;
						case 11:
							num6 = 0;
							num7 = 3;
							goto IL_00b2;
						case 6:
						case 14:
							text = array[num6];
							num3 = 7;
							continue;
						case 9:
							text2 = array[num6];
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
							{
								num3 = 10;
							}
							continue;
						case 7:
							fileStream = (FileStream)O0KVcGfExvQOVrb4KWP(text);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							try
							{
								List<LocalizationFileHash> fileHashes = localizationHash.FileHashes;
								LocalizationFileHash localizationFileHash = new LocalizationFileHash();
								SNdTRNffMDU8W0jv0wV(localizationFileHash, XBHUIKfbQ9HLpIWj9Ln(text));
								localizationFileHash.Hash = mD.ComputeHash(fileStream);
								fileHashes.Add(localizationFileHash);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							finally
							{
								int num5;
								if (fileStream == null)
								{
									num5 = 2;
									goto IL_0403;
								}
								goto IL_0419;
								IL_0403:
								switch (num5)
								{
								default:
									goto end_IL_03ee;
								case 1:
									break;
								case 2:
									goto end_IL_03ee;
								case 0:
									goto end_IL_03ee;
								}
								goto IL_0419;
								IL_0419:
								((IDisposable)fileStream).Dispose();
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
								{
									num5 = 0;
								}
								goto IL_0403;
								end_IL_03ee:;
							}
							goto case 1;
						case 8:
							break;
							IL_00b2:
							num3 = num7;
							continue;
						}
						num6++;
						num3 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num3 = 14;
						}
					}
				}
				finally
				{
					if (mD != null)
					{
						int num10 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num10 = 1;
						}
						while (true)
						{
							switch (num10)
							{
							case 1:
								fNbGRaEzWbfbl76JXxQ(mD);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num10 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 3:
				local = (string)XBHUIKfbQ9HLpIWj9Ln(targetPath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static List<CultureInfo> GetCultureNames()
	{
		if (string.IsNullOrEmpty(Dir))
		{
			return new List<CultureInfo> { KeyCultureInfo };
		}
		List<DirectoryInfo> source = new List<DirectoryInfo>();
		if (Directory.Exists(Dir))
		{
			source = (from d in new DirectoryInfo(Dir).GetDirectories()
				where !d.Name.Equals((string)_003C_003Ec.H98icRfHHX1gVBH9UoAp(0x637E299B ^ 0x637F73C3), StringComparison.OrdinalIgnoreCase)
				select d).ToList();
		}
		List<CultureInfo> list = (from c in source.Select(delegate(DirectoryInfo c)
			{
				//Discarded unreachable code: IL_004c, IL_007f, IL_00d8, IL_00e7
				CultureInfo cultureInfo = default(CultureInfo);
				switch (1)
				{
				case 1:
					try
					{
						cultureInfo = new CultureInfo(c.Name);
						int num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num = 0;
						}
						return num switch
						{
							0 => cultureInfo, 
							_ => cultureInfo, 
						};
					}
					catch (Exception ex)
					{
						int num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 1;
						}
						while (true)
						{
							switch (num2)
							{
							case 2:
								cultureInfo = null;
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num2 = 0;
								}
								break;
							case 1:
								_003C_003Ec.daCcOKfH7MtYqWY3TWYm(_003C_003Ec.LT1eMZfHAsHcqIUb27Pr(), ex.Message, ex);
								num2 = 2;
								break;
							default:
								return cultureInfo;
							case 0:
								return cultureInfo;
							}
						}
					}
				default:
					return cultureInfo;
				}
			})
			where c != null
			select c).ToList();
		if (!source.Any((DirectoryInfo c) => ((string)_003C_003Ec.h8LqyLfHxOcgYmSYLqj7(c)).StartsWith(((CultureInfo)_003C_003Ec.RY52oOfH0UXJLoE2VLpu()).Name)))
		{
			list.Add(new CultureInfo(KeyCultureInfo.Name));
		}
		return list;
	}

	public static CultureInfo GetCultureByName(string cultureName)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass31_.cultureName = cultureName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return GetCultureNames().FirstOrDefault(_003C_003Ec__DisplayClass31_._003CGetCultureByName_003Eb__0);
			}
		}
	}

	public static void InitCulture()
	{
		//Discarded unreachable code: IL_0049, IL_00a4, IL_00ec, IL_00fb
		switch (1)
		{
		case 1:
			try
			{
				if (GBi3c8fvDVNA69Cnbs8() == null)
				{
					break;
				}
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						BmXYoTf82JiVq0fBY2r(GBi3c8fvDVNA69Cnbs8());
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					Logger.Log.Error(fRxTRuE0Fu7IiSgLGiJ(ex), ex);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
				}
			}
		case 0:
			break;
		}
	}

	public static CultureInfo GetCurrentCulture()
	{
		return (CultureInfo)OE4XD9fZcGLeABfJ5Cx(null);
	}

	public static CultureInfo GetCurrentCulture(IUser user)
	{
		//Discarded unreachable code: IL_0089, IL_0098
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 3:
				return (CultureInfo)Dm5MNlfu3ZSojur4rLc(LocalizationService, user);
			case 1:
				if (Locator.Initialized)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			}
			if (GBi3c8fvDVNA69Cnbs8() != null)
			{
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 1;
				}
				continue;
			}
			return null;
		}
	}

	public static CultureInfo GetDefaultCulture()
	{
		int num = 3;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 3:
				if (LT6X7FfInVe2V4Qju61())
				{
					if (GBi3c8fvDVNA69Cnbs8() != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = GIxm43fiaqb6NBWslFj(ER5pPiE9h18lxXF0djO(((Thread)ilBR3WfS9bcKJDpOKiS()).CurrentCulture));
					if (obj != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					continue;
				}
				num2 = 2;
				continue;
			default:
				return (CultureInfo)EPsa3ifVCRMqykoxK6W(GBi3c8fvDVNA69Cnbs8());
			case 1:
				obj = wI6wbifBevfaFuGnfnY();
				break;
			}
			break;
		}
		return (CultureInfo)obj;
	}

	public static T RunWithCulture<T>(CultureInfo culture, Func<T> action)
	{
		_003C_003Ec__DisplayClass36_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass36_0<T>();
		CS_0024_003C_003E8__locals0.action = action;
		CS_0024_003C_003E8__locals0.result = default(T);
		RunWithCulture(culture, delegate
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
					CS_0024_003C_003E8__locals0.result = CS_0024_003C_003E8__locals0.action();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.result;
	}

	[AsyncStateMachine(typeof(_003CRunWithCultureAsync_003Ed__37))]
	public static Task RunWithCultureAsync(CultureInfo culture, Func<Task> action)
	{
		_003CRunWithCultureAsync_003Ed__37 stateMachine = default(_003CRunWithCultureAsync_003Ed__37);
		stateMachine.culture = culture;
		stateMachine.action = action;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static void RunWithCulture(CultureInfo culture, Action action)
	{
		//Discarded unreachable code: IL_008f, IL_0123, IL_0160
		int num = 2;
		int num2 = num;
		CultureInfo currentUICulture = default(CultureInfo);
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				currentUICulture = ((Thread)ilBR3WfS9bcKJDpOKiS()).CurrentUICulture;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				return;
			case 1:
				cultureInfo = (CultureInfo)ENoAQ5fRxFpE3Db0aA0(ilBR3WfS9bcKJDpOKiS());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				((Thread)ilBR3WfS9bcKJDpOKiS()).CurrentUICulture = culture;
				int num3 = 2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					case 2:
						QKI0p7fqAucnfg62r6k(ilBR3WfS9bcKJDpOKiS(), CultureInfo.CreateSpecificCulture((string)ER5pPiE9h18lxXF0djO(culture)));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 0;
						}
						break;
					default:
						GhEBiQfKllxnPl0PNkW(action);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num3 = 1;
						}
						break;
					}
				}
			}
			finally
			{
				HJSDGGfXC1aSSNCQinE(ilBR3WfS9bcKJDpOKiS(), currentUICulture);
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						QKI0p7fqAucnfg62r6k(ilBR3WfS9bcKJDpOKiS(), cultureInfo);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num4 = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
			}
		}
	}

	public static void RunWithSpecificUICulture(Action action)
	{
		//Discarded unreachable code: IL_007e, IL_011b, IL_012e, IL_013d
		int num = 1;
		int num2 = num;
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				cultureInfo = (CultureInfo)VqkN2yfTkUovyT1i9kT(ilBR3WfS9bcKJDpOKiS());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				int num3;
				if (Thread.CurrentThread.CurrentUICulture.IsNeutralCulture)
				{
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num3 = 0;
					}
					goto IL_0082;
				}
				goto IL_0098;
				IL_0098:
				action();
				num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num3 = 1;
				}
				goto IL_0082;
				IL_0082:
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					case 2:
						break;
					default:
						((Thread)ilBR3WfS9bcKJDpOKiS()).CurrentUICulture = (CultureInfo)ejgM9efkMhTI4CUxAkj(ER5pPiE9h18lxXF0djO(VqkN2yfTkUovyT1i9kT(ilBR3WfS9bcKJDpOKiS())));
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				goto IL_0098;
			}
			finally
			{
				HJSDGGfXC1aSSNCQinE(ilBR3WfS9bcKJDpOKiS(), cultureInfo);
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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

	internal static void RunWithFutureTranslate(Action action, bool escapeQuote = true)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
				_003C_003Ec__DisplayClass44_.action = action;
				RunWithFutureTranslate(delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							_003C_003Ec__DisplayClass44_0.laFvqvfARcBlvlnDq1jx(_003C_003Ec__DisplayClass44_.action);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
							{
								num4 = 0;
							}
							break;
						default:
							return 0;
						}
					}
				}, escapeQuote);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static T RunWithFutureTranslate<T>(Func<T> action, bool escapeQuote = true)
	{
		bool flag = futureTranslate;
		bool flag2 = SR.escapeQuote;
		try
		{
			futureTranslate = true;
			SR.escapeQuote = escapeQuote;
			return action();
		}
		catch (Exception exception)
		{
			futureTranslate = flag;
			SR.escapeQuote = flag2;
			PreparedTranslate(exception);
			throw;
		}
		finally
		{
			futureTranslate = flag;
			SR.escapeQuote = flag2;
		}
	}

	public static string GetSetting(string setting, string defaultValue = null)
	{
		//Discarded unreachable code: IL_0061, IL_0106, IL_0146, IL_0155, IL_0161, IL_0170, IL_01bd
		int num = 6;
		int num2 = num;
		string value = default(string);
		FileSystemWatcher obj = default(FileSystemWatcher);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return defaultValue;
			case 1:
				return value;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							if (settigsStrings == null)
							{
								num3 = 2;
								continue;
							}
							break;
						default:
							((SettingsFeatureFlagProvider.SettingsFeatureFlagContainer)lMtYqjf2YyFB6MqEelK()).UpdateFlags((IDictionary<string, string>)settigsStrings);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							settigsStrings = ReadSettings();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num4 = 2;
						}
						goto IL_010a;
					}
					goto IL_0120;
					IL_0120:
					Monitor.Exit(obj);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num4 = 1;
					}
					goto IL_010a;
					IL_010a:
					switch (num4)
					{
					case 2:
						goto end_IL_00e5;
					case 1:
						goto end_IL_00e5;
					}
					goto IL_0120;
					end_IL_00e5:;
				}
				goto default;
			default:
				if (settigsStrings.TryGetValue(setting, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 5:
				obj = settigsFileWatcher;
				num2 = 2;
				break;
			case 2:
				lockTaken = false;
				num2 = 3;
				break;
			case 6:
				if (settigsStrings == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static Dictionary<string, string> ReadSettings()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			NameValueCollection appSettings = ConfigurationManager.AppSettings;
			string[] allKeys = appSettings.AllKeys;
			foreach (string text in allKeys)
			{
				dictionary[text] = appSettings[text];
			}
			return dictionary;
		}
		catch (Exception)
		{
			Thread.Sleep(TimeSpan.FromSeconds(1.0));
			NameValueCollection appSettings2 = ConfigurationManager.AppSettings;
			string[] allKeys = appSettings2.AllKeys;
			foreach (string text2 in allKeys)
			{
				dictionary[text2] = appSettings2[text2];
			}
			return dictionary;
		}
	}

	private static void ClearSettingsCache(object sender, object e)
	{
		//Discarded unreachable code: IL_0131, IL_016c, IL_017f, IL_018e, IL_01e2, IL_021d, IL_0230, IL_023f
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				settigsObjectsRWLock.EnterWriteLock();
				num2 = 9;
				break;
			default:
				Thread.Sleep(TimeSpan.FromSeconds(5.0));
				num2 = 4;
				break;
			case 1:
				return;
			case 6:
				settigsStrings = ReadSettings();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				zopcDbE5esKil0UNMTM(settigsObjectsRWLock);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				rKpwuffeFfMsfAZuTYf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBAB5C));
				num2 = 6;
				break;
			case 8:
				((SettingsFeatureFlagProvider.SettingsFeatureFlagContainer)lMtYqjf2YyFB6MqEelK()).UpdateFlags((IDictionary<string, string>)settigsStrings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				try
				{
					AYhD3sfPCBmMhgwc0ZA(settigsObjects);
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				finally
				{
					vQFfoqfF6L9U9w0pBEm(settigsObjectsRWLock);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 4:
				settigsStrings = ReadSettings();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				try
				{
					AYhD3sfPCBmMhgwc0ZA(settigsObjects);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
					vQFfoqfF6L9U9w0pBEm(settigsObjectsRWLock);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 8;
			}
		}
	}

	public static T GetSetting<T>(string setting, T defaultValue = default(T))
	{
		settigsObjectsRWLock.EnterReadLock();
		object value;
		try
		{
			if (settigsObjects.TryGetValue(setting, out value))
			{
				return (T)(value ?? ((object)defaultValue));
			}
		}
		finally
		{
			settigsObjectsRWLock.ExitReadLock();
		}
		string setting2 = GetSetting(setting);
		if (setting2 != null)
		{
			Type typeFromHandle = typeof(T);
			try
			{
				TypeConverter converter = TypeDescriptor.GetConverter(typeFromHandle);
				if (converter == null || !converter.CanConvertFrom(typeof(string)))
				{
					try
					{
						value = Convert.ChangeType(setting2, typeFromHandle);
					}
					catch (Exception)
					{
						value = null;
					}
				}
				else
				{
					value = converter.ConvertFrom(null, CultureInfo.InvariantCulture, setting2);
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Warn(exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A66863), setting, typeFromHandle, setting2);
			}
		}
		settigsObjectsRWLock.EnterWriteLock();
		try
		{
			settigsObjects[setting] = value;
		}
		finally
		{
			settigsObjectsRWLock.ExitWriteLock();
		}
		return (T)(value ?? ((object)defaultValue));
	}

	private static string GetString(object s, object cultureInfo)
	{
		//Discarded unreachable code: IL_0049, IL_01cb, IL_01da, IL_01ea, IL_01f9, IL_0209, IL_0220, IL_026c, IL_027f, IL_028e
		string result = default(string);
		switch (1)
		{
		case 1:
			try
			{
				yI3DdLf1odUpTbYq9Tw(localizationStringsRWLock);
				int num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 5;
				}
				Dictionary<string, string> value = default(Dictionary<string, string>);
				string value2 = default(string);
				while (true)
				{
					object obj;
					switch (num)
					{
					case 5:
						if (localizationStrings.Count <= 0)
						{
							num = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
							{
								num = 1;
							}
							break;
						}
						goto case 2;
					case 10:
						if (!localizationStrings.TryGetValue((CultureInfo)cultureInfo, out value))
						{
							num = 8;
							break;
						}
						goto default;
					case 8:
					case 13:
						if (value2 != null)
						{
							num = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num = 7;
							}
							break;
						}
						goto case 3;
					case 2:
						if (cultureInfo == null)
						{
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num = 11;
							}
							break;
						}
						goto case 1;
					default:
						value.TryGetValue((string)zdvXKufN548Bomluk73(s, vrPDjpEk9ZyFJxtBPVT(-309639236 ^ -309634748), ""), out value2);
						num = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num = 6;
						}
						break;
					case 7:
						if (!SKaSXef3wPLiiMxWjBu(TranslationVariant, value2))
						{
							num = 3;
							break;
						}
						goto case 9;
					case 11:
						cultureInfo = ((Thread)ilBR3WfS9bcKJDpOKiS()).CurrentCulture;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						value2 = null;
						num = 10;
						break;
					case 12:
						result = (string)s;
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num = 4;
						}
						break;
					case 9:
						obj = Fwh7LUfpeYalvIHcb2R(s, value2);
						goto IL_0227;
					case 3:
						obj = value2;
						goto IL_0227;
					case 4:
						return result;
					case 6:
						{
							return result;
						}
						IL_0227:
						result = (string)obj;
						num = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num = 6;
						}
						break;
					}
				}
			}
			finally
			{
				r03onkfa5hciDbdP5rS(localizationStringsRWLock);
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		default:
			return result;
		}
	}

	private static string GetCorrectTranslationVariant(object s, object res)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_00eb
		int num = 4;
		int num2 = num;
		string[] array = default(string[]);
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = default(_003C_003Ec__DisplayClass55_0);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				array = (string[])AmJgVtfDTHtutwU5BT1(TranslationVariant, res);
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass55_.stackTrace = (string)uMVd6GftmiLF9clEMG8();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				return array[num3 + 1];
			case 5:
				num3 += 2;
				num2 = 7;
				break;
			case 4:
				_003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
				num2 = 3;
				break;
			case 8:
				num3 = 1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 >= array.Length)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			case 6:
				return (string)s;
			case 1:
				if (!((IEnumerable<string>)hLGe5efwVmmtam67qDf(array[num3], new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries)).Any(_003C_003Ec__DisplayClass55_._003CGetCorrectTranslationVariant_003Eb__0))
				{
					num2 = 5;
					break;
				}
				goto case 9;
			}
		}
	}

	public static bool ContainsKey(string str)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ContainsKey(str, vrPDjpEk9ZyFJxtBPVT(-787452571 ^ -787451807));
			case 1:
				if (nslMSgf4kNavaANKuti(str, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317796248)))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static bool ContainsKey(object str, object key)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return rMvA0kfHnXtosAHDHwa(str, wjOd72f69ggE1fcKUeJ(key, vrPDjpEk9ZyFJxtBPVT(0x1ECE530A ^ 0x1ECE4DF4)), StringComparison.OrdinalIgnoreCase);
			default:
				return false;
			case 1:
				if (xhtPxdEs9nG9CKwHKbx(str))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static string ExtractKeyFromString(string str)
	{
		//Discarded unreachable code: IL_00a5, IL_00b4
		int num = 4;
		int num2 = num;
		int length = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return str.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB58B3), "");
			case 4:
				if (xhtPxdEs9nG9CKwHKbx(str))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 3;
					}
					break;
				}
				if (!mtwX23fAMdqOQyDem3K(str))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				str = str.Substring(6, length);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				length = str.Length - 8;
				num2 = 2;
				break;
			case 3:
				return str;
			}
		}
	}

	public static string T(string t)
	{
		//Discarded unreachable code: IL_0135, IL_0196, IL_01a9, IL_01b8, IL_0211, IL_0220
		int num = 5;
		long value = default(long);
		IUser user = default(IUser);
		string translateLocalization = default(string);
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (!asXlO1fmyP1EGNujCPc(TranslateService.Instance))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 12;
				case 6:
					if (((TranslateService)uEWa04fxBoxFsQt26MC()).IsTranslationModeEnabled((long?)value))
					{
						num2 = 8;
						continue;
					}
					goto case 2;
				case 10:
					if (!I8Kgqjf0XUhfOyCJNNu(uEWa04fxBoxFsQt26MC()))
					{
						num = 7;
						break;
					}
					goto case 2;
				case 1:
					return t;
				case 16:
					return (string)T3pY1vf9p5wOaHT2d3p(null, t);
				case 15:
					value = Convert.ToInt64(zuAjLGfdMObPvKu1wGJ(user));
					num = 6;
					break;
				case 13:
					try
					{
						((TranslateService)uEWa04fxBoxFsQt26MC()).InLineDisabled = true;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								user = (IUser)VtfQ4sfMxRLjSLso1ML();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						aK4YNSfJnhP1R3eYIp2(uEWa04fxBoxFsQt26MC(), false);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto default;
				default:
					if (user != null)
					{
						num2 = 15;
						continue;
					}
					goto case 16;
				case 4:
					if (LT6X7FfInVe2V4Qju61())
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 2;
				case 14:
					if (Locator.GetService<TranslateService>() != null)
					{
						num2 = 10;
						continue;
					}
					goto case 2;
				case 11:
					translateLocalization = ((TranslateService)uEWa04fxBoxFsQt26MC()).GetTranslateLocalization((long?)value);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					if (!xhtPxdEs9nG9CKwHKbx(t))
					{
						cultureInfo = (CultureInfo)OE4XD9fZcGLeABfJ5Cx(user);
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 11;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
					}
					continue;
				case 9:
					user = null;
					num2 = 13;
					continue;
				case 5:
					if (JcbhQkf7EkwLGkp7urB())
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 12:
					t = (string)tLHZIffyaOOFFY10KCT(t);
					num2 = 9;
					continue;
				case 3:
					return ((TranslateService)uEWa04fxBoxFsQt26MC()).T((string)ER5pPiE9h18lxXF0djO(cultureInfo), translateLocalization, t, pu1oHZflZBnsDtK8WKB(uEWa04fxBoxFsQt26MC()));
				case 2:
					return (string)T3pY1vf9p5wOaHT2d3p(null, t);
				}
				break;
			}
		}
	}

	internal static string T(string t, bool ignoreTranslationMode)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ignoreTranslationMode)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)zQj0ibfrmOi0M6BSYOP(t);
			default:
				return (string)T3pY1vf9p5wOaHT2d3p(null, t);
			}
		}
	}

	internal static string T(bool ignoreTranslationMode, string t, params object[] parameters)
	{
		//Discarded unreachable code: IL_0085, IL_0094, IL_00a3, IL_00fe
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				t = (string)tLHZIffyaOOFFY10KCT(t);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return (string)lc8hOAE1sRHAJUqTiBu(GuiLocalizationUtility.TemplateInCodeRes, t);
			case 2:
				return (string)KcN3P6f5Q33p7saMZkQ(T3pY1vf9p5wOaHT2d3p(null, t), parameters);
			case 6:
				return T(t, parameters);
			default:
				return t;
			case 5:
				if (!dHmVm3fgQQ816kwVw9V())
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 1:
				if (!xhtPxdEs9nG9CKwHKbx(t))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 7:
				if (!ignoreTranslationMode)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	private static bool ContainsNonPrintable(object source)
	{
		//Discarded unreachable code: IL_008a, IL_00ab, IL_00ba, IL_00ed, IL_0150, IL_015f, IL_016f
		int num = 4;
		char c = default(char);
		int num3 = default(int);
		string text = default(string);
		UnicodeCategory unicodeCategory = default(UnicodeCategory);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					return true;
				case 7:
					goto IL_006e;
				case 9:
				case 11:
					return true;
				case 17:
					if (c == '\\')
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto IL_006e;
				case 3:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					return false;
				case 12:
				case 19:
					if (c != '<')
					{
						num2 = 14;
						continue;
					}
					goto case 15;
				case 2:
				case 13:
					c = text[num3];
					num2 = 6;
					continue;
				case 4:
					text = (string)source;
					num2 = 3;
					continue;
				case 1:
					if (unicodeCategory != UnicodeCategory.OtherNotAssigned)
					{
						num3++;
						num2 = 16;
					}
					else
					{
						num2 = 11;
					}
					continue;
				case 8:
					switch (c)
					{
					case '\0':
					case '\a':
					case '\b':
					case '\t':
					case '\n':
					case '\v':
					case '\f':
					case '\r':
						break;
					case '\u0001':
					case '\u0002':
					case '\u0003':
					case '\u0004':
					case '\u0005':
					case '\u0006':
						goto IL_006e;
					default:
						goto IL_01cb;
					}
					goto case 15;
				case 6:
					if ((uint)c > 39u)
					{
						num2 = 12;
						continue;
					}
					goto case 8;
				case 14:
					if (c != '>')
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 15;
				default:
					if (num3 < GBJ0shfYcW1fDaoXcPi(text))
					{
						num2 = 13;
						continue;
					}
					goto case 18;
				case 5:
					if ((uint)(unicodeCategory - 12) <= 2u)
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				case 10:
					{
						if (c != '\'')
						{
							num = 7;
							break;
						}
						goto case 15;
					}
					IL_01cb:
					num2 = 10;
					continue;
					IL_006e:
					unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
					num = 5;
					break;
				}
				break;
			}
		}
	}

	private static string EscapeNonPrintable(object source, char quoteChar = '\'', bool includeLetter = false)
	{
		//Discarded unreachable code: IL_00fd, IL_010c, IL_01fd, IL_020c, IL_021c, IL_022b, IL_0276, IL_0285, IL_0294, IL_02fa, IL_0309, IL_035f, IL_036e, IL_037e, IL_038d, IL_039d, IL_03ac, IL_03bc, IL_03cb, IL_0461, IL_0521, IL_0534, IL_065a, IL_06b7, IL_06c6, IL_06d6, IL_070b, IL_071a, IL_0750, IL_075f, IL_07ef
		int num = 2;
		StringBuilder stringBuilder = default(StringBuilder);
		UnicodeCategory unicodeCategory = default(UnicodeCategory);
		int num3 = default(int);
		char c = default(char);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					plrWIZfsunMGnoDbsC4(stringBuilder, vrPDjpEk9ZyFJxtBPVT(0x4A1640F ^ 0x4A17B49));
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 28;
					}
					continue;
				case 47:
					if (unicodeCategory == UnicodeCategory.OtherNotAssigned)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto case 45;
				case 41:
					plrWIZfsunMGnoDbsC4(stringBuilder, wjOd72f69ggE1fcKUeJ(vrPDjpEk9ZyFJxtBPVT(-561074844 ^ -561073646), quoteChar.ToString()));
					num2 = 40;
					continue;
				case 43:
					goto IL_01a6;
				default:
					num3++;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					if (c != '<')
					{
						num2 = 36;
						continue;
					}
					goto case 22;
				case 7:
					goto IL_0249;
				case 46:
				{
					StringBuilder stringBuilder3 = stringBuilder;
					object obj2 = vrPDjpEk9ZyFJxtBPVT(-97972138 ^ -97972438);
					int num4 = c;
					plrWIZfsunMGnoDbsC4(stringBuilder3, (string)obj2 + num4.ToString((string)vrPDjpEk9ZyFJxtBPVT(0x1ECE530A ^ 0x1ECE4C8E)));
					num2 = 4;
					continue;
				}
				case 35:
				case 42:
					stringBuilder.Append(c);
					num2 = 44;
					continue;
				case 2:
					stringBuilder = new StringBuilder();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					if ((uint)(unicodeCategory - 12) > 2u)
					{
						num2 = 47;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 34;
				case 16:
				case 24:
					c = mAw3SifUOge9U7pspLw(text, num3);
					num2 = 23;
					continue;
				case 27:
					goto IL_03eb;
				case 14:
					plrWIZfsunMGnoDbsC4(stringBuilder, vrPDjpEk9ZyFJxtBPVT(0x3B36AB09 ^ 0x3B36B417));
					num = 31;
					break;
				case 8:
					if (c != '\\')
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 50;
						}
						continue;
					}
					goto case 28;
				case 51:
					goto IL_046b;
				case 3:
					switch (c)
					{
					case '\b':
						break;
					case '\a':
						goto IL_01a6;
					case '\v':
						goto IL_0249;
					case '\f':
						goto IL_03eb;
					case '\t':
						goto IL_046b;
					default:
						goto IL_04dc;
					case '\n':
						goto IL_0598;
					case '\u0001':
					case '\u0002':
					case '\u0003':
					case '\u0004':
					case '\u0005':
					case '\u0006':
						goto IL_06f2;
					case '\r':
						goto IL_0725;
					case '\0':
						goto IL_07c2;
					}
					goto case 5;
				case 19:
					GdnoxofLlnwDOdyW7KX(stringBuilder, quoteChar);
					num2 = 18;
					continue;
				case 37:
					if (c != '>')
					{
						num2 = 8;
						continue;
					}
					goto case 14;
				case 9:
					text = (string)source;
					num2 = 12;
					continue;
				case 23:
					if ((uint)c <= 60u)
					{
						num2 = 3;
						continue;
					}
					goto case 37;
				case 29:
					unicodeCategory = RX7sHTfc8uwHWHVfGa8(c);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 20;
					}
					continue;
				case 1:
					GdnoxofLlnwDOdyW7KX(stringBuilder, quoteChar);
					num2 = 9;
					continue;
				case 25:
					goto IL_0598;
				case 11:
				case 38:
					if (num3 < GBJ0shfYcW1fDaoXcPi(text))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 19;
				case 18:
					return stringBuilder.ToString();
				case 22:
					plrWIZfsunMGnoDbsC4(stringBuilder, vrPDjpEk9ZyFJxtBPVT(0x8317432 ^ 0x8316B3C));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
					num3 = 0;
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 38;
					}
					continue;
				case 34:
				{
					StringBuilder stringBuilder2 = stringBuilder;
					object obj = vrPDjpEk9ZyFJxtBPVT(0x53CB464B ^ 0x53CB5937);
					int num4 = c;
					plrWIZfsunMGnoDbsC4(stringBuilder2, (string)obj + num4.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8316BB6)));
					num2 = 13;
					continue;
				}
				case 33:
					if (c == quoteChar)
					{
						num2 = 41;
						continue;
					}
					goto case 29;
				case 15:
				case 36:
				case 50:
					goto IL_06f2;
				case 52:
					goto IL_0725;
				case 53:
					if (!U39iKrfz4PTIVB4xC3n(c))
					{
						num2 = 35;
						continue;
					}
					goto case 46;
				case 28:
					stringBuilder.Append((string)vrPDjpEk9ZyFJxtBPVT(-542721635 ^ -542726477));
					num2 = 54;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 8;
					}
					continue;
				case 45:
					if (includeLetter)
					{
						num2 = 53;
						continue;
					}
					goto case 35;
				case 32:
					goto IL_07c2;
					IL_01a6:
					plrWIZfsunMGnoDbsC4(stringBuilder, vrPDjpEk9ZyFJxtBPVT(-477139494 ^ -477138204));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 6;
					}
					continue;
					IL_07c2:
					plrWIZfsunMGnoDbsC4(stringBuilder, vrPDjpEk9ZyFJxtBPVT(0x3A5D5EF ^ 0x3A5CAD9));
					num2 = 39;
					continue;
					IL_0725:
					plrWIZfsunMGnoDbsC4(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978478676));
					num = 26;
					break;
					IL_06f2:
					if (escapeQuote)
					{
						num2 = 33;
						continue;
					}
					goto case 29;
					IL_0249:
					stringBuilder.Append((string)vrPDjpEk9ZyFJxtBPVT(0x18A6761F ^ 0x18A66971));
					num2 = 30;
					continue;
					IL_0598:
					plrWIZfsunMGnoDbsC4(stringBuilder, vrPDjpEk9ZyFJxtBPVT(-1751176224 ^ -1751173962));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					continue;
					IL_04dc:
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 5;
					}
					continue;
					IL_046b:
					plrWIZfsunMGnoDbsC4(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97972432));
					num2 = 49;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 20;
					}
					continue;
					IL_03eb:
					plrWIZfsunMGnoDbsC4(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20260501));
					num2 = 21;
					continue;
				}
				break;
			}
		}
	}

	private static string UnEscapeNonPrintable(object source)
	{
		//Discarded unreachable code: IL_0088, IL_018d, IL_019c, IL_01ab, IL_02d6, IL_02e9, IL_0309, IL_0318, IL_033b, IL_034a, IL_035a, IL_0369, IL_03cd, IL_03dc, IL_0431, IL_0440, IL_0450, IL_045f, IL_04e1, IL_04f0, IL_0571, IL_0580, IL_05a7, IL_05b6, IL_06cf, IL_06de, IL_06fb, IL_070a, IL_072d, IL_073c, IL_076e, IL_077d, IL_0804, IL_0813, IL_0844, IL_087c, IL_088b
		int num = 1;
		int num2 = num;
		StringBuilder stringBuilder2 = default(StringBuilder);
		IEnumerator<char> enumerator = default(IEnumerator<char>);
		char current = default(char);
		StringBuilder stringBuilder = default(StringBuilder);
		bool flag = default(bool);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stringBuilder2 = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return stringBuilder2.ToString();
			case 5:
				enumerator = ((IEnumerable<char>)source).Skip(1).Take(GBJ0shfYcW1fDaoXcPi(source) - 2).GetEnumerator();
				num2 = 3;
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!D7yccqEcy1QouE1npyx(enumerator))
						{
							num3 = 11;
							goto IL_0096;
						}
						goto IL_050e;
						IL_0096:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 12:
								if (current != 'b')
								{
									num3 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
									{
										num3 = 15;
									}
									continue;
								}
								goto case 49;
							case 40:
								if ((uint)current > 92u)
								{
									num3 = 19;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto case 2;
							case 5:
							case 9:
							case 13:
							case 18:
							case 22:
							case 26:
							case 27:
							case 31:
							case 32:
							case 37:
							case 42:
							case 44:
							case 45:
							case 55:
							case 57:
								break;
							case 46:
								plrWIZfsunMGnoDbsC4(stringBuilder2, vrPDjpEk9ZyFJxtBPVT(0x3630F361 ^ 0x3630EE39));
								num4 = 13;
								goto IL_0092;
							case 28:
								if (current != '"')
								{
									num3 = 10;
									continue;
								}
								goto case 46;
							case 3:
								GdnoxofLlnwDOdyW7KX(stringBuilder2, current);
								num4 = 32;
								goto IL_0092;
							case 6:
							case 19:
								if ((uint)current > 98u)
								{
									num3 = 34;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
									{
										num3 = 23;
									}
									continue;
								}
								goto case 25;
							case 20:
							case 34:
								if (current != 'f')
								{
									num3 = 51;
									continue;
								}
								goto case 8;
							case 14:
								plrWIZfsunMGnoDbsC4(stringBuilder2, vrPDjpEk9ZyFJxtBPVT(0x3A6135BE ^ 0x3A612A0E));
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num3 = 5;
								}
								continue;
							case 54:
								if (stringBuilder != null)
								{
									num3 = 39;
									continue;
								}
								goto case 47;
							case 35:
								if (current != '\\')
								{
									num3 = 24;
									continue;
								}
								goto case 56;
							case 30:
								plrWIZfsunMGnoDbsC4(stringBuilder2, vrPDjpEk9ZyFJxtBPVT(0x7EC153F ^ 0x7EC0AB3));
								num3 = 42;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
								{
									num3 = 18;
								}
								continue;
							case 8:
								plrWIZfsunMGnoDbsC4(stringBuilder2, vrPDjpEk9ZyFJxtBPVT(-1852837372 ^ -1852838502));
								num3 = 18;
								continue;
							case 21:
								flag = true;
								num3 = 44;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num3 = 11;
								}
								continue;
							case 17:
								goto IL_0404;
							case 16:
								GdnoxofLlnwDOdyW7KX(stringBuilder2, bGbNKNQWXtGNaXiJC0b(num5));
								num3 = 27;
								continue;
							case 49:
								plrWIZfsunMGnoDbsC4(stringBuilder2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637E3603));
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num3 = 37;
								}
								continue;
							case 36:
								goto IL_04b5;
							case 39:
								stringBuilder.Append(current);
								num3 = 43;
								continue;
							case 23:
								goto IL_050e;
							case 47:
								if (!flag)
								{
									num3 = 40;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
									{
										num3 = 41;
									}
									continue;
								}
								goto case 1;
							case 50:
								num5 = wgXXaUQBOF1cAnNgoe3(stringBuilder.ToString(), 16);
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num3 = 52;
								}
								continue;
							case 10:
								if (current != '\'')
								{
									num4 = 29;
									goto IL_0092;
								}
								goto case 53;
							case 48:
								stringBuilder2.Append((string)vrPDjpEk9ZyFJxtBPVT(-1411196499 ^ -1411201473));
								num3 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num3 = 22;
								}
								continue;
							case 2:
								if ((uint)current <= 39u)
								{
									num3 = 28;
									continue;
								}
								goto case 38;
							case 7:
								goto IL_060b;
							case 53:
								plrWIZfsunMGnoDbsC4(stringBuilder2, vrPDjpEk9ZyFJxtBPVT(0x42643203 ^ 0x42642F5D));
								num3 = 9;
								continue;
							case 4:
								goto IL_064e;
							default:
								goto IL_0680;
							case 43:
								if (lvI4olQF7albnw00yWR(stringBuilder) == 4)
								{
									num3 = 50;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num3 = 31;
									}
									continue;
								}
								break;
							case 1:
								flag = false;
								num3 = 40;
								continue;
							case 38:
								if (current != '0')
								{
									num3 = 35;
									continue;
								}
								goto case 30;
							case 56:
								plrWIZfsunMGnoDbsC4(stringBuilder2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345419086));
								num3 = 55;
								continue;
							case 25:
								if (current != 'a')
								{
									num3 = 12;
									continue;
								}
								goto case 48;
							case 52:
								stringBuilder = null;
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num3 = 16;
								}
								continue;
							case 51:
								switch (current)
								{
								case 'v':
									break;
								case 'n':
									goto IL_0404;
								case 'r':
									goto IL_04b5;
								case 'u':
									goto IL_060b;
								case 't':
									goto IL_064e;
								case 'o':
								case 'p':
								case 'q':
								case 's':
									goto IL_0680;
								default:
									goto IL_07e5;
								}
								goto case 14;
							case 11:
								goto end_IL_01fc;
								IL_07e5:
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num3 = 0;
								}
								continue;
								IL_0092:
								num3 = num4;
								continue;
								IL_0680:
								if (current == '\\')
								{
									num3 = 21;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 3;
								IL_064e:
								plrWIZfsunMGnoDbsC4(stringBuilder2, vrPDjpEk9ZyFJxtBPVT(-2138958856 ^ -2138960814));
								num3 = 57;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num3 = 16;
								}
								continue;
								IL_060b:
								stringBuilder = new StringBuilder();
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num3 = 26;
								}
								continue;
								IL_04b5:
								plrWIZfsunMGnoDbsC4(stringBuilder2, vrPDjpEk9ZyFJxtBPVT(-1767720453 ^ -1767725309));
								num4 = 31;
								goto IL_0092;
								IL_0404:
								plrWIZfsunMGnoDbsC4(stringBuilder2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E2642E));
								num3 = 45;
								continue;
							}
							break;
						}
						continue;
						IL_050e:
						current = enumerator.Current;
						num3 = 54;
						goto IL_0096;
						continue;
						end_IL_01fc:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								fNbGRaEzWbfbl76JXxQ(enumerator);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 2;
			default:
				flag = false;
				num2 = 4;
				break;
			case 4:
				stringBuilder = null;
				num2 = 5;
				break;
			}
		}
	}

	public static string T(CultureInfo info, string t)
	{
		//Discarded unreachable code: IL_0061, IL_0089, IL_0098, IL_00a8, IL_0225, IL_0234, IL_0244
		int num = 6;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return t;
				case 12:
					break;
				case 13:
					if (!string.IsNullOrEmpty(t))
					{
						num2 = 12;
						continue;
					}
					goto case 3;
				case 14:
					if (!ContainsKey(t, vrPDjpEk9ZyFJxtBPVT(0x5A4C7B29 ^ 0x5A4C6191)))
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 7:
					if (uMfBKQQbd5qoCDWUgJN(RuhSxJQopS7Z6nEKkOA(t), ""))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 15:
					return (string)kwlvTKQEEHO8sfth8N8(info, text);
				case 4:
					return BrandResourceManager.R(null, t);
				case 8:
					if (GuiLocalizationUtility.DesignMode)
					{
						return (string)lc8hOAE1sRHAJUqTiBu(GuiLocalizationUtility.TemplateInCodeRes, t);
					}
					num2 = 13;
					continue;
				case 11:
					if (t != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto default;
				case 10:
					if (xhtPxdEs9nG9CKwHKbx(text))
					{
						num2 = 4;
						continue;
					}
					goto case 15;
				case 1:
					if (!L0PxKdQhr7FZKQO4hnp(t))
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 6:
					if (!futureTranslate)
					{
						num2 = 5;
						continue;
					}
					goto case 11;
				default:
					return t;
				case 2:
					return (string)EcubNPE2ApKSGDnHF26(vrPDjpEk9ZyFJxtBPVT(-583745292 ^ -583738804), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBAA88), EscapeNonPrintable(tLHZIffyaOOFFY10KCT(t)), vrPDjpEk9ZyFJxtBPVT(-281842504 ^ -281840892));
				case 5:
					t = (string)tLHZIffyaOOFFY10KCT(t);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
			text = (string)tLcP3gQGa9N3dZwprrk(t, info);
			num = 10;
		}
	}

	public static string T(string t, params object[] parameters)
	{
		return T(null, t, parameters);
	}

	public static string T(CultureInfo info, string t, params object[] parameters)
	{
		//Discarded unreachable code: IL_00d1, IL_00e0, IL_0100, IL_0261, IL_0270, IL_028d, IL_029c, IL_02d4, IL_032e, IL_033d, IL_03c6, IL_04c2, IL_0523, IL_0536, IL_0545, IL_0618
		int num = 31;
		string text2 = default(string);
		List<string> list = default(List<string>);
		string text = default(string);
		string translateLocalization = default(string);
		long value = default(long);
		IUser user = default(IUser);
		CultureInfo cultureInfo = default(CultureInfo);
		_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = default(_003C_003Ec__DisplayClass78_0);
		object[] source = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (t != null)
					{
						num2 = 39;
						break;
					}
					goto case 13;
				case 27:
					text2 = list[3];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 3;
					}
					break;
				case 20:
					text = list[2];
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 6;
					}
					break;
				case 18:
					t = (string)tLHZIffyaOOFFY10KCT(t);
					num2 = 12;
					break;
				case 21:
					if (list[3] != null)
					{
						num2 = 19;
						break;
					}
					goto case 29;
				case 1:
					translateLocalization = ((TranslateService)uEWa04fxBoxFsQt26MC()).GetTranslateLocalization((long?)value);
					num2 = 23;
					break;
				case 39:
					if (uMfBKQQbd5qoCDWUgJN(RuhSxJQopS7Z6nEKkOA(t), ""))
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 32;
						}
						break;
					}
					goto case 22;
				case 4:
					if (list[2] != null)
					{
						num2 = 42;
						break;
					}
					goto case 21;
				case 2:
					if (!((TranslateService)uEWa04fxBoxFsQt26MC()).InLineDisabled)
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 28;
						}
						break;
					}
					goto case 10;
				case 33:
					return (string)lc8hOAE1sRHAJUqTiBu(GuiLocalizationUtility.TemplateInCodeRes, list[0]);
				case 10:
				case 26:
				case 38:
					if (!GuiLocalizationUtility.DesignMode)
					{
						num2 = 24;
						break;
					}
					goto case 5;
				case 34:
					if (!L0PxKdQhr7FZKQO4hnp(t))
					{
						goto end_IL_0012;
					}
					goto IL_0624;
				case 12:
					user = null;
					num2 = 3;
					break;
				case 36:
					if (!xhtPxdEs9nG9CKwHKbx(t))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 43;
				case 35:
					if (user != null)
					{
						num2 = 17;
						break;
					}
					goto case 25;
				case 7:
					return t;
				case 31:
					if (!futureTranslate)
					{
						num2 = 30;
						break;
					}
					goto case 40;
				case 28:
					if (!asXlO1fmyP1EGNujCPc(TranslateService.Instance))
					{
						num2 = 26;
						break;
					}
					goto case 18;
				case 43:
					return t;
				case 8:
					cultureInfo = (CultureInfo)OE4XD9fZcGLeABfJ5Cx(user);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					break;
				case 41:
					if (list.Count == 5)
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 7;
						}
						break;
					}
					if (!dHmVm3fgQQ816kwVw9V())
					{
						return (string)KcN3P6f5Q33p7saMZkQ(T3pY1vf9p5wOaHT2d3p(info, list[0]), parameters);
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 33;
					}
					break;
				case 11:
					if (!Locator.Initialized)
					{
						num2 = 10;
						break;
					}
					goto case 15;
				case 14:
					if (!TranslateService.Instance.IsTranslationModeEnabled(value))
					{
						num2 = 38;
						break;
					}
					goto case 36;
				case 5:
					return (string)lc8hOAE1sRHAJUqTiBu(GuiLocalizationUtility.TemplateInCodeRes, t);
				case 24:
					return string.Format((string)T3pY1vf9p5wOaHT2d3p(info, t), parameters);
				case 40:
					_003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
					num2 = 9;
					break;
				case 25:
					if (!dHmVm3fgQQ816kwVw9V())
					{
						num2 = 37;
						break;
					}
					goto default;
				case 22:
					if (ContainsKey(t, vrPDjpEk9ZyFJxtBPVT(0x63ABA4E8 ^ 0x63ABBE50)))
					{
						num2 = 34;
						break;
					}
					goto IL_0624;
				case 15:
					if (Locator.GetService<TranslateService>() != null)
					{
						num2 = 2;
						break;
					}
					goto case 10;
				case 23:
					list = ((TranslateService)uEWa04fxBoxFsQt26MC()).TA((string)ER5pPiE9h18lxXF0djO(cultureInfo), translateLocalization, t, pu1oHZflZBnsDtK8WKB(TranslateService.Instance));
					num2 = 41;
					break;
				case 3:
					try
					{
						aK4YNSfJnhP1R3eYIp2(TranslateService.Instance, true);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								user = (IUser)VtfQ4sfMxRLjSLso1ML();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						aK4YNSfJnhP1R3eYIp2(TranslateService.Instance, false);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 35;
				case 29:
					return string.Format((string)vrPDjpEk9ZyFJxtBPVT(-2112703338 ^ -2112705708), list[0], list[1], list[2], list[3], text, text2, list[4]);
				default:
					return (string)lc8hOAE1sRHAJUqTiBu(GuiLocalizationUtility.TemplateInCodeRes, t);
				case 37:
					return (string)KcN3P6f5Q33p7saMZkQ(T3pY1vf9p5wOaHT2d3p(info, t), parameters);
				case 17:
					value = Convert.ToInt64(zuAjLGfdMObPvKu1wGJ(user));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 14;
					}
					break;
				case 13:
				case 32:
					return t;
				case 16:
					source = parameters.Select(_003C_003Ec__DisplayClass78_._003CT_003Eb__1).Select(delegate(object p)
					{
						int num5 = 2;
						while (true)
						{
							int num6 = num5;
							while (true)
							{
								object obj;
								switch (num6)
								{
								case 2:
									if (p is string)
									{
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
										{
											num6 = 0;
										}
										continue;
									}
									goto case 3;
								case 3:
									obj = p;
									if (obj == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num6 = 0;
										}
										continue;
									}
									goto IL_00a7;
								case 1:
									if (_003C_003Ec.jkOQR6fHJ5ElPMUA8pwL((string)p, _003C_003Ec.H98icRfHHX1gVBH9UoAp(-812025778 ^ -812031242)))
									{
										return p;
									}
									break;
								default:
									{
										obj = "";
										goto IL_00a7;
									}
									IL_00a7:
									return EscapeNonPrintable(obj.ToString());
								}
								break;
							}
							num5 = 3;
						}
					}).ToArray();
					num2 = 6;
					break;
				case 6:
					return (string)PmLX0FQQHgEiCT6txmq(new string[5]
					{
						(string)vrPDjpEk9ZyFJxtBPVT(-1870892489 ^ -1870894961),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3327060),
						EscapeNonPrintable(tLHZIffyaOOFFY10KCT(t)),
						string.Concat(source.Select((object v) => (string)_003C_003Ec.jdjjCPfH9SSvAYh9xJbg(_003C_003Ec.H98icRfHHX1gVBH9UoAp(-1852837372 ^ -1852834298), v))),
						(string)vrPDjpEk9ZyFJxtBPVT(-1921202237 ^ -1921197953)
					});
				case 30:
					if (!string.IsNullOrEmpty(t))
					{
						if (JcbhQkf7EkwLGkp7urB())
						{
							num2 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 10;
					}
					num2 = 7;
					break;
				case 42:
					list[2] = (string)((!dHmVm3fgQQ816kwVw9V()) ? string.Format((string)T3pY1vf9p5wOaHT2d3p(info, list[2]), parameters) : lc8hOAE1sRHAJUqTiBu(GuiLocalizationUtility.TemplateInCodeRes, list[2]));
					num2 = 21;
					break;
				case 19:
					{
						list[3] = (string)((!dHmVm3fgQQ816kwVw9V()) ? KcN3P6f5Q33p7saMZkQ(T(info, list[3]), parameters) : lc8hOAE1sRHAJUqTiBu(GuiLocalizationUtility.TemplateInCodeRes, list[3]));
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 29;
						}
						break;
					}
					IL_0624:
					_003C_003Ec__DisplayClass78_.indexes = (from Match m in (IEnumerable)qIjWcfQf5rSBCxJxJoT(formatParse, t)
						select _003C_003Ec.wLlxIhfHM39thZ0ROU6P(((Capture)_003C_003Ec.Uhc1FvfHyPI7uMWNp5IF(_003C_003Ec.EcU2EpfHmwgk0iF3vRxV(m), _003C_003Ec.H98icRfHHX1gVBH9UoAp(0x2ACE37D ^ 0x2AD2E09))).Value)).ToList();
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 4;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	public static string PreparedTranslate(string resource)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 8;
		_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_ = default(_003C_003Ec__DisplayClass84_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!_003C_003Ec__DisplayClass84_.needRepeat)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 6;
				case 3:
					if (_003C_003Ec__DisplayClass84_.needRepeat)
					{
						num2 = 4;
						continue;
					}
					break;
				case 4:
				case 9:
					_003C_003Ec__DisplayClass84_.needRepeat = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return resource;
				case 1:
					goto end_IL_0012;
				case 6:
					_003C_003Ec__DisplayClass84_.needRepeat = false;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					resource = (string)XgpVseQCOibmASoYadl(resource, futureTranslateSRTParse4, new MatchEvaluator(_003C_003Ec__DisplayClass84_._003CPreparedTranslate_003Eb__3));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					_003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_0();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					resource = Regex.Replace(resource, futureTranslateSRTParse1, delegate(Match m)
					{
						//Discarded unreachable code: IL_00cf, IL_00de
						int num5 = 5;
						int num6 = num5;
						_003C_003Ec__DisplayClass84_1 _003C_003Ec__DisplayClass84_3 = default(_003C_003Ec__DisplayClass84_1);
						while (true)
						{
							switch (num6)
							{
							case 3:
								_003C_003Ec__DisplayClass84_3.tGroup = (Group)_003C_003Ec.Uhc1FvfHyPI7uMWNp5IF(_003C_003Ec.EcU2EpfHmwgk0iF3vRxV(_003C_003Ec__DisplayClass84_3.m), _003C_003Ec.H98icRfHHX1gVBH9UoAp(-195614443 ^ -195671049));
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num6 = 0;
								}
								break;
							case 5:
								_003C_003Ec__DisplayClass84_3 = new _003C_003Ec__DisplayClass84_1();
								num6 = 4;
								break;
							case 4:
								_003C_003Ec__DisplayClass84_3.m = m;
								num6 = 3;
								break;
							case 1:
								if (_003C_003Ec.F4VOYjfHdDDEl5FmKjfW(_003C_003Ec__DisplayClass84_3.tGroup))
								{
									num6 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num6 = 1;
									}
									break;
								}
								goto default;
							default:
								return _003C_003Ec__DisplayClass84_3.m.Value;
							case 2:
								return (from c in ((IEnumerable)_003C_003Ec.NKRL02fHl60i3m3e5WZh(_003C_003Ec.Uhc1FvfHyPI7uMWNp5IF(_003C_003Ec.EcU2EpfHmwgk0iF3vRxV(_003C_003Ec__DisplayClass84_3.m), _003C_003Ec.H98icRfHHX1gVBH9UoAp(-475857671 ^ -475554097)))).Cast<Capture>().Select(_003C_003Ec__DisplayClass84_3._003CPreparedTranslate_003Eb__4)
									orderby c.Index descending
									select c).Aggregate((string)_003C_003Ec.Ilo3EgfHrf1dqpNGvgpn(_003C_003Ec__DisplayClass84_3.m), (string text, c) => text.Remove(c.Index, c.Length).Insert(c.Index, EscapeNonPrintable(T(UnEscapeNonPrintable(c.t)))));
							}
						}
					});
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					break;
				}
				resource = (string)XgpVseQCOibmASoYadl(resource, futureTranslateSRTParse3, (MatchEvaluator)delegate(Match m)
				{
					//Discarded unreachable code: IL_0097
					int num3 = 1;
					int num4 = num3;
					_003C_003Ec__DisplayClass84_4 _003C_003Ec__DisplayClass84_2 = default(_003C_003Ec__DisplayClass84_4);
					while (true)
					{
						switch (num4)
						{
						case 1:
							_003C_003Ec__DisplayClass84_2 = new _003C_003Ec__DisplayClass84_4();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num4 = 0;
							}
							break;
						case 5:
							if (_003C_003Ec__DisplayClass84_2.tGroup.Success)
							{
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num4 = 2;
								}
								break;
							}
							goto case 3;
						default:
							_003C_003Ec__DisplayClass84_2.m = m;
							num4 = 4;
							break;
						case 4:
							_003C_003Ec__DisplayClass84_2.tGroup = (Group)_003C_003Ec.Uhc1FvfHyPI7uMWNp5IF(_003C_003Ec__DisplayClass84_2.m.Groups, _003C_003Ec.H98icRfHHX1gVBH9UoAp(0x26FFCB59 ^ 0x26FEA9BB));
							num4 = 5;
							break;
						case 3:
							return _003C_003Ec__DisplayClass84_2.m.Value;
						case 2:
							return (from c in ((Group)_003C_003Ec.Uhc1FvfHyPI7uMWNp5IF(_003C_003Ec.EcU2EpfHmwgk0iF3vRxV(_003C_003Ec__DisplayClass84_2.m), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103A8B43))).Captures.Cast<Capture>().Select(_003C_003Ec__DisplayClass84_2._003CPreparedTranslate_003Eb__13)
								orderby c.Index descending
								select c).Aggregate(_003C_003Ec__DisplayClass84_2.m.Value, (string text, c) => text.Remove(c.Index, c.Length).Insert(c.Index, T(UnEscapeNonPrintable(c.t))));
						}
					}
				});
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 6;
				}
				continue;
				end_IL_0012:
				break;
			}
			resource = Regex.Replace(resource, futureTranslateSRTParse2, _003C_003Ec__DisplayClass84_._003CPreparedTranslate_003Eb__1);
			num = 3;
		}
	}

	internal static string TranslateStringResource(string resource)
	{
		return (string)HSJBx8Qv5rufVERi4AT(translateSRTParse, resource, (MatchEvaluator)delegate(Match match)
		{
			//Discarded unreachable code: IL_008d, IL_0101, IL_0139, IL_014c, IL_017f, IL_018e
			int num = 6;
			int num2 = num;
			string text3 = default(string);
			string text = default(string);
			string text2 = default(string);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (!text2.Contains(_003C_003Ec.OlFcevfHUM6WaLRLUp74(text3, 0)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 6:
					text = (string)_003C_003Ec.Ilo3EgfHrf1dqpNGvgpn(match);
					num2 = 5;
					break;
				case 5:
					text3 = (string)_003C_003Ec.Ilo3EgfHrf1dqpNGvgpn(_003C_003Ec.BdfET7fHg7i7Xy8e03dy(_003C_003Ec.EcU2EpfHmwgk0iF3vRxV(match), 1));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 10;
					}
					break;
				case 3:
					escapeQuote = true;
					num2 = 7;
					break;
				case 7:
					try
					{
						text2 = EscapeNonPrintable(text2, _003C_003Ec.OlFcevfHUM6WaLRLUp74(text3, 0), includeLetter: true);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num4 = 0;
						}
						return num4 switch
						{
							0 => text2, 
							_ => text2, 
						};
					}
					finally
					{
						escapeQuote = flag;
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 1:
				case 8:
					flag = escapeQuote;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 3;
					}
					break;
				case 4:
					return text2;
				default:
					text2 = (string)_003C_003Ec.NSbTjLfHsoP8v75EnjYQ(_003C_003Ec.H98icRfHHX1gVBH9UoAp(-629844702 ^ -629680492), text3[0], text2, text3[0]);
					num2 = 4;
					break;
				case 10:
				{
					bool num3 = ContainsNonPrintable(text);
					text = (string)((!num3) ? _003C_003Ec.FhrFiVfHYfCYGimL7r3p(text, 1, _003C_003Ec.V2JJNYfHjGfnDbfHf9re(text) - 2) : _003C_003Ec.Rf6EO8fH54C0ELUtSh8O(text));
					text2 = (string)_003C_003Ec.FrjWq5fHLuK57Au86qMo(text);
					if (num3)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 9;
				}
				}
			}
		});
	}

	private static void PreparedTranslate(object exception)
	{
		//Discarded unreachable code: IL_00af, IL_00be
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			FieldInfo fieldInfo;
			switch (num2)
			{
			case 4:
				return;
			case 2:
				fieldInfo = exceptionMessageField;
				if ((object)fieldInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 7:
				if (text != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 1;
			case 1:
				PreparedTranslate(((Exception)exception).InnerException);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				return;
			case 5:
				BCJNJSQuVJnwmtjuKwk(exceptionMessageField, exception, PV5rvhQZjGRk8gVdlhI(text));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				if (exception == null)
				{
					return;
				}
				num2 = 2;
				continue;
			default:
				fieldInfo = (exceptionMessageField = v04rSTE6JPQRN7lmO1M(typeof(Exception).TypeHandle).GetField((string)vrPDjpEk9ZyFJxtBPVT(-345420348 ^ -345412132), BindingFlags.Instance | BindingFlags.NonPublic));
				break;
			}
			text = (string)aAVbr7Q8yPGLFqGkHyw(fieldInfo, exception);
			num2 = 7;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
			{
				num2 = 5;
			}
		}
	}

	public static string M(string t)
	{
		return BrandResourceManager.R((CultureInfo)VqkN2yfTkUovyT1i9kT(ilBR3WfS9bcKJDpOKiS()), t);
	}

	public static string M(string t, params object[] parameters)
	{
		return BrandResourceManager.R(Thread.CurrentThread.CurrentUICulture, (string)KcN3P6f5Q33p7saMZkQ(t, parameters));
	}

	public static IEnumerable<ResourceSet> GetResourceSet(CultureInfo culture)
	{
		_003C_003Ec__DisplayClass93_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass93_0();
		CS_0024_003C_003E8__locals0.culture = culture;
		try
		{
			localizationStringsRWLock.EnterReadLock();
			return from m in managers
				select (ResourceSet)_003C_003Ec__DisplayClass93_0.Obuie3f7BPg7HJxuQTci(m, CS_0024_003C_003E8__locals0.culture, true, true) into r
				where r != null
				select r;
		}
		finally
		{
			localizationStringsRWLock.ExitReadLock();
		}
	}

	public static CultureInfo GetCultureFromSettings()
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					hikBXFQIx4YxJJ4veN2();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (_languageHolder != null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 4:
					return (CultureInfo)GIxm43fiaqb6NBWslFj(_languageHolder.Name);
				default:
					if (_languageHolder == null)
					{
						return null;
					}
					num = 4;
					break;
				}
				break;
			}
		}
	}

	public static LanguageHolder ReadFromFile(string filePath)
	{
		//Discarded unreachable code: IL_007b, IL_00cf, IL_0147, IL_017d, IL_01be, IL_01f6, IL_0215, IL_0224, IL_0272, IL_02c6, IL_0359, IL_03c9, IL_03d8, IL_0405
		int num = 5;
		int num2 = num;
		bool lockTaken = default(bool);
		object languageHolderSinch = default(object);
		int num10 = default(int);
		LanguageHolder languageHolder = default(LanguageHolder);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!File.Exists(filePath))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
			case 4:
				return null;
			case 3:
				languageHolderSinch = _languageHolderSinch;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					Monitor.Enter(languageHolderSinch, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							num10 = 0;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						case 2:
							try
							{
								FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								default:
									try
									{
										XmlReader xmlReader = (XmlReader)MSJMhNQVQ0jCTmjUlQm(fileStream);
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										default:
											try
											{
												languageHolder = (LanguageHolder)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<LanguageHolder>.Raw, xmlReader, useComponentManager: false);
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
												{
													num6 = 0;
												}
												return num6 switch
												{
													0 => languageHolder, 
													_ => languageHolder, 
												};
											}
											finally
											{
												int num7;
												if (xmlReader == null)
												{
													num7 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
													{
														num7 = 2;
													}
													goto IL_01fa;
												}
												goto IL_022f;
												IL_022f:
												fNbGRaEzWbfbl76JXxQ(xmlReader);
												num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
												{
													num7 = 1;
												}
												goto IL_01fa;
												IL_01fa:
												switch (num7)
												{
												case 2:
													goto end_IL_01d5;
												case 1:
													goto end_IL_01d5;
												}
												goto IL_022f;
												end_IL_01d5:;
											}
										}
									}
									finally
									{
										if (fileStream != null)
										{
											int num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
											{
												num8 = 1;
											}
											while (true)
											{
												switch (num8)
												{
												case 1:
													((IDisposable)fileStream).Dispose();
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
													{
														num8 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
								}
							}
							catch (Exception ex)
							{
								int num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num9 = 0;
								}
								while (true)
								{
									switch (num9)
									{
									case 4:
										return languageHolder;
									case 1:
										if (num10 > 20)
										{
											num9 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
											{
												num9 = 6;
											}
											continue;
										}
										break;
									case 3:
										ndPOVnQSZmBuJtC5DSa(1000);
										num9 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
										{
											num9 = 1;
										}
										continue;
									case 6:
										languageHolder = null;
										num9 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
										{
											num9 = 3;
										}
										continue;
									case 2:
										Rt6iupEmcpmcigB36oL(Logger.Log, fRxTRuE0Fu7IiSgLGiJ(ex), ex);
										num9 = 3;
										continue;
									default:
										num10++;
										num9 = 2;
										continue;
									case 5:
										break;
									}
									break;
								}
							}
							break;
						}
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num3 = 2;
						}
					}
				}
				finally
				{
					int num12;
					if (!lockTaken)
					{
						int num11 = 2;
						num12 = num11;
						goto IL_03ae;
					}
					goto IL_03e3;
					IL_03ae:
					switch (num12)
					{
					case 2:
						goto end_IL_0395;
					case 1:
						goto end_IL_0395;
					}
					goto IL_03e3;
					IL_03e3:
					Monitor.Exit(languageHolderSinch);
					num12 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num12 = 0;
					}
					goto IL_03ae;
					end_IL_0395:;
				}
			}
		}
	}

	private static void InitLanguageHolder()
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_languageHolder = (LanguageHolder)SaunRnQRAw1qhtHyIsX(ePijyxElsJnePn3Rlaf(text, vrPDjpEk9ZyFJxtBPVT(-97972138 ^ -97963910)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (w3XdpxEru2SQXqvBqWC(text))
				{
					num2 = 3;
					break;
				}
				return;
			case 2:
				return;
			case 1:
				text = Path.Combine((string)eLcujBEHAM4OsWcWIeD(jHTe4DEAXt2du1YvRsV(tlWStpQi3Hf2bBM08Jh(amhCBBENfPr0FTQhOlV()))));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool SaveCultureToSettings(string culture)
	{
		//Discarded unreachable code: IL_0070, IL_009e, IL_00d5, IL_0113, IL_014d, IL_0185, IL_01bd, IL_01cc, IL_01fd, IL_022d, IL_023c, IL_0248, IL_0257, IL_0283, IL_02ec, IL_0324, IL_0358, IL_0398
		int num = 7;
		bool flag = default(bool);
		object languageHolderSinch = default(object);
		bool lockTaken = default(bool);
		string path = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 3:
				case 14:
					return flag;
				case 13:
					try
					{
						Monitor.Enter(languageHolderSinch, ref lockTaken);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								FileStream fileStream = new FileStream(path, FileMode.Create);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 1:
									return flag;
								default:
									try
									{
										MemoryStream memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(_languageHolder, useComponentManager: false);
										int num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										default:
											return flag;
										case 0:
											return flag;
										case 1:
											try
											{
												nLP3HYQkc1tcQAbhyTF(memoryStream, fileStream);
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
												{
													num6 = 0;
												}
												return num6 switch
												{
													0 => flag, 
													_ => flag, 
												};
											}
											finally
											{
												if (memoryStream != null)
												{
													int num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
													{
														num7 = 0;
													}
													while (true)
													{
														switch (num7)
														{
														default:
															fNbGRaEzWbfbl76JXxQ(memoryStream);
															num7 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
															{
																num7 = 1;
															}
															continue;
														case 1:
															break;
														}
														break;
													}
												}
											}
										}
									}
									finally
									{
										int num8;
										if (fileStream == null)
										{
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
											{
												num8 = 1;
											}
											goto IL_0201;
										}
										goto IL_0217;
										IL_0217:
										fNbGRaEzWbfbl76JXxQ(fileStream);
										num8 = 2;
										goto IL_0201;
										IL_0201:
										switch (num8)
										{
										case 1:
											goto end_IL_01dc;
										case 2:
											goto end_IL_01dc;
										}
										goto IL_0217;
										end_IL_01dc:;
									}
								}
							}
							catch (Exception ex)
							{
								int num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num9 = 1;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										return flag;
									case 0:
										return flag;
									case 1:
										Logger.Log.Error(fRxTRuE0Fu7IiSgLGiJ(ex), ex);
										num9 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
										{
											num9 = 0;
										}
										break;
									}
								}
							}
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num10 = 1;
							}
							while (true)
							{
								switch (num10)
								{
								case 1:
									Monitor.Exit(languageHolderSinch);
									num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
									{
										num10 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 5:
					_languageHolder = new LanguageHolder();
					num2 = 18;
					continue;
				case 2:
					lockTaken = false;
					num = 13;
					break;
				case 7:
					flag = false;
					num2 = 6;
					continue;
				case 6:
					if (_languageHolder == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto default;
				case 15:
					languageHolderSinch = _languageHolderSinch;
					num2 = 2;
					continue;
				case 4:
				case 8:
					flag = true;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 17;
					}
					continue;
				case 11:
					hikBXFQIx4YxJJ4veN2();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					JCNRMHQXDekHR5975gn(_languageHolder, culture);
					num = 16;
					break;
				case 12:
					if (gp0RC3QKMejxIhjubBd(R0VTSvQqu4QmJxdRWAS(_languageHolder), culture, StringComparison.OrdinalIgnoreCase))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 18:
					if (R0VTSvQqu4QmJxdRWAS(_languageHolder) == null)
					{
						num2 = 4;
						continue;
					}
					goto case 12;
				case 9:
					path = (string)ePijyxElsJnePn3Rlaf(text, vrPDjpEk9ZyFJxtBPVT(-957824448 ^ -957816212));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 10;
					}
					continue;
				default:
					if (_languageHolder == null)
					{
						num2 = 5;
						continue;
					}
					goto case 18;
				case 10:
					if (!Directory.Exists(text))
					{
						num2 = 14;
						continue;
					}
					goto case 9;
				case 16:
					text = (string)JR8aUOQTGoA3cwNfGJr(new string[1] { (string)eLcujBEHAM4OsWcWIeD(jHTe4DEAXt2du1YvRsV(tlWStpQi3Hf2bBM08Jh(AppDomain.CurrentDomain))) });
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 10;
					}
					continue;
				}
				break;
			}
		}
	}

	public static void SetDefaultCultureFromAppSettings()
	{
		//Discarded unreachable code: IL_008a, IL_00f1, IL_0147, IL_0156
		int num = 3;
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 3:
					break;
				case 2:
					if (cultureInfo == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						HJSDGGfXC1aSSNCQinE(ilBR3WfS9bcKJDpOKiS(), cultureInfo);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							}
							QKI0p7fqAucnfg62r6k(ilBR3WfS9bcKJDpOKiS(), ejgM9efkMhTI4CUxAkj(cultureInfo.Name));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num3 = 1;
							}
						}
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							}
							Rt6iupEmcpmcigB36oL(tvtXdeQOayhO5fojfJm(), T((string)vrPDjpEk9ZyFJxtBPVT(-1886646897 ^ -1886638649)), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num4 = 0;
							}
						}
					}
				}
				break;
			}
			cultureInfo = (CultureInfo)UogLjCQnaJP4c3IDq0m();
			num = 2;
		}
	}

	public static string GetSettingsFile(bool forSave = false, string fileName = "Language.xml")
	{
		//Discarded unreachable code: IL_009b, IL_00aa, IL_00e3, IL_00ed, IL_00fc, IL_014c, IL_015b
		int num = 5;
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object path;
				switch (num2)
				{
				case 6:
					text2 = Path.Combine(text, fileName);
					num2 = 9;
					continue;
				case 11:
					if (!w3XdpxEru2SQXqvBqWC(text))
					{
						num = 2;
						break;
					}
					goto case 7;
				case 12:
					if (forSave)
					{
						num = 10;
						break;
					}
					goto case 13;
				case 5:
					if (Hm3kMFQ2UCLVdsMRlJF())
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				case 8:
					path = uhipgoQeMFLh789jssT();
					goto IL_01c3;
				case 7:
					text2 = (string)ePijyxElsJnePn3Rlaf(text, fileName);
					num2 = 12;
					continue;
				case 13:
					if (PjZmdRQ1nLQM3oPLgur(text2))
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				default:
					if (w3XdpxEru2SQXqvBqWC(text))
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				case 1:
					text = Path.Combine((string)eLcujBEHAM4OsWcWIeD(jHTe4DEAXt2du1YvRsV(((AppDomain)amhCBBENfPr0FTQhOlV()).SetupInformation)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				case 9:
				case 10:
					return text2;
				case 2:
					sx0DOeEgaV9hG4Sac2k(text);
					num2 = 7;
					continue;
				case 4:
					{
						path = U0cNrTQPdDVLsUegSRW(ComponentManager.Current);
						goto IL_01c3;
					}
					IL_01c3:
					text = Path.Combine((string)path, (string)vrPDjpEk9ZyFJxtBPVT(-1822890472 ^ -1822898546));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	public static string WeekMonthDay(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(0x103FE975 ^ 0x103FD943), date);
	}

	public static string MonthDayWeek(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-1317790512 ^ -1317786458), date);
	}

	public static string YearMonthDay(DateTime date)
	{
		return T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A513E0), date);
	}

	public static string YearMonthDayWeek(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(0x53CACA3 ^ 0x53C9DB1), date);
	}

	public static string YearMonthDayShortWeek(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-289714582 ^ -289702116), date);
	}

	public static string WeekYearMonthDay(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-1426094279 ^ -1426082077), date);
	}

	public static string WeekYearMonthDay2(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(0x31326106 ^ 0x3132533C), date);
	}

	public static string YearMonth(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-234299632 ^ -234295906), date);
	}

	public static string Year(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-70037984 ^ -70026094), date);
	}

	public static string CalendarDDMY(DateTime date1, DateTime date2)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(0x5F3078B6 ^ 0x5F304BBA), date1, date2);
	}

	public static string CalendarDMDMY(DateTime date1, DateTime date2)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-1088304168 ^ -1088292782), date1, date2);
	}

	public static string CalendarDMYDMY(DateTime date1, DateTime date2)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-2112703338 ^ -2112716624), date1, date2);
	}

	public static string ShortMonthDayWeek(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-1633514411 ^ -1633503033), date);
	}

	public static string DateFullMonth(DateTime date)
	{
		return T((string)vrPDjpEk9ZyFJxtBPVT(-1886646897 ^ -1886635679), date);
	}

	public SR()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool p8WyqUEXtTP7TvhOF8W()
	{
		return hhETXDEKMSWwCMFllS2 == null;
	}

	internal static SR W7ZFGKETtxxkqHKQ9KG()
	{
		return hhETXDEKMSWwCMFllS2;
	}

	internal static object vrPDjpEk9ZyFJxtBPVT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void xTWNKgEn9iEi1QjfS8W()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object wv2V9uEO2uKL83swaT4(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object EcubNPE2ApKSGDnHF26(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object zDd21wEe2Q9vWeCZ5Vq(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object j5NFCIEPKZBdAXjpiy5(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object lc8hOAE1sRHAJUqTiBu(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object amhCBBENfPr0FTQhOlV()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void CyKNcHE3LfoF40woUpa(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Filter = (string)P_1;
	}

	internal static void csFyHZEpgNend1Trjy2(object P_0, bool P_1)
	{
		((FileSystemWatcher)P_0).IncludeSubdirectories = P_1;
	}

	internal static void ubcQihEaliD8V6sqHBC(object P_0, bool P_1)
	{
		((FileSystemWatcher)P_0).EnableRaisingEvents = P_1;
	}

	internal static void m9WcKWEDiq0722G1jS2(object P_0, NotifyFilters P_1)
	{
		((FileSystemWatcher)P_0).NotifyFilter = P_1;
	}

	internal static void KSiFlZEtHptU6ov4xRF(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Created += (FileSystemEventHandler)P_1;
	}

	internal static void eNikLQEw9g5LUjIp0QO(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Changed += (FileSystemEventHandler)P_1;
	}

	internal static void SUtFUrE4IP1kCbLIbN4(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Deleted += (FileSystemEventHandler)P_1;
	}

	internal static Type v04rSTE6JPQRN7lmO1M(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object eLcujBEHAM4OsWcWIeD(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object jHTe4DEAXt2du1YvRsV(object P_0)
	{
		return ((AppDomainSetup)P_0).ConfigurationFile;
	}

	internal static void t4Z1yZE7fBklY0hqG9y(object P_0)
	{
		ReInitSR((string)P_0);
	}

	internal static void BkyZ2xExBSVMbjmCg0r(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Path = (string)P_1;
	}

	internal static object fRxTRuE0Fu7IiSgLGiJ(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void Rt6iupEmcpmcigB36oL(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void uAdJh8Eyu8SUX82LTvH(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object sLXJnbEMYC63UfMFJ9W()
	{
		return Resources.LangMap;
	}

	internal static object TfqWJrEJmXGOFKOZeAv(object P_0)
	{
		return LanguagesMap.Load((string)P_0);
	}

	internal static object ER5pPiE9h18lxXF0djO(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object qUO8HQEdMHJcMgVtYQs(object P_0)
	{
		return GetCultureDir((string)P_0);
	}

	internal static object ePijyxElsJnePn3Rlaf(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool w3XdpxEru2SQXqvBqWC(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object sx0DOeEgaV9hG4Sac2k(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static void zopcDbE5esKil0UNMTM(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterWriteLock();
	}

	internal static void YWdO0cEjvdVXPX7sQek(object P_0)
	{
		((List<ResourceManager>)P_0).Clear();
	}

	internal static void A4UyHMEYUuWXrXPgSA8(object P_0)
	{
		((Dictionary<CultureInfo, Dictionary<string, string>>)P_0).Clear();
	}

	internal static int F9tHyvELEwA31Ff1ZC4(object P_0)
	{
		return ((List<CultureInfo>)P_0).Count;
	}

	internal static object XH6sWAEU0IVwOHVWELH(object P_0)
	{
		return ((ResourceSet)P_0).GetEnumerator();
	}

	internal static bool xhtPxdEs9nG9CKwHKbx(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool D7yccqEcy1QouE1npyx(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void fNbGRaEzWbfbl76JXxQ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void vQFfoqfF6L9U9w0pBEm(object P_0)
	{
		((ReaderWriterLockSlim)P_0).ExitWriteLock();
	}

	internal static object wI6wbifBevfaFuGnfnY()
	{
		return KeyCultureInfo;
	}

	internal static object jNeJPafWELTvdE0VKh7(object P_0)
	{
		return GetCultureDir((CultureInfo)P_0);
	}

	internal static object gWjOp4foyfoRwtYZxrt(object P_0)
	{
		return ComputeLocalizationHash((string)P_0);
	}

	internal static object XBHUIKfbQ9HLpIWj9Ln(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static object n5W0AVfhkrNK5UmjAYE()
	{
		return MD5.Create();
	}

	internal static object VTE36ofG6Fk1KyI6i8k(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static object O0KVcGfExvQOVrb4KWP(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static void SNdTRNffMDU8W0jv0wV(object P_0, object P_1)
	{
		((LocalizationFileHash)P_0).FileName = (string)P_1;
	}

	internal static object mUFwmafQI3l24KjKvEC(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static void x94ybafCYHWqkFgLZvO(object P_0, object P_1)
	{
		((LocalizationFileHash)P_0).Hash = (byte[])P_1;
	}

	internal static object GBi3c8fvDVNA69Cnbs8()
	{
		return LocalizationService;
	}

	internal static void BmXYoTf82JiVq0fBY2r(object P_0)
	{
		((ILocalizationService)P_0).InitCulture();
	}

	internal static object OE4XD9fZcGLeABfJ5Cx(object P_0)
	{
		return GetCurrentCulture((IUser)P_0);
	}

	internal static object Dm5MNlfu3ZSojur4rLc(object P_0, object P_1)
	{
		return ((ILocalizationService)P_0).Load((IUser)P_1);
	}

	internal static bool LT6X7FfInVe2V4Qju61()
	{
		return Locator.Initialized;
	}

	internal static object EPsa3ifVCRMqykoxK6W(object P_0)
	{
		return ((ILocalizationService)P_0).DefaultCulture;
	}

	internal static object ilBR3WfS9bcKJDpOKiS()
	{
		return Thread.CurrentThread;
	}

	internal static object GIxm43fiaqb6NBWslFj(object P_0)
	{
		return GetCultureByName((string)P_0);
	}

	internal static object ENoAQ5fRxFpE3Db0aA0(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static void QKI0p7fqAucnfg62r6k(object P_0, object P_1)
	{
		((Thread)P_0).CurrentCulture = (CultureInfo)P_1;
	}

	internal static void GhEBiQfKllxnPl0PNkW(object P_0)
	{
		P_0();
	}

	internal static void HJSDGGfXC1aSSNCQinE(object P_0, object P_1)
	{
		((Thread)P_0).CurrentUICulture = (CultureInfo)P_1;
	}

	internal static object VqkN2yfTkUovyT1i9kT(object P_0)
	{
		return ((Thread)P_0).CurrentUICulture;
	}

	internal static object ejgM9efkMhTI4CUxAkj(object P_0)
	{
		return CultureInfo.CreateSpecificCulture((string)P_0);
	}

	internal static object TbORhafn2l9tC8ugc3q()
	{
		return CultureInfo.CurrentCulture;
	}

	internal static int DHJVtgfOCny6u95QqrJ(object P_0)
	{
		return ((CultureInfo)P_0).LCID;
	}

	internal static object lMtYqjf2YyFB6MqEelK()
	{
		return SettingsFeatureFlagProvider.Container;
	}

	internal static void rKpwuffeFfMsfAZuTYf(object P_0)
	{
		ConfigurationManager.RefreshSection((string)P_0);
	}

	internal static void AYhD3sfPCBmMhgwc0ZA(object P_0)
	{
		((Dictionary<string, object>)P_0).Clear();
	}

	internal static void yI3DdLf1odUpTbYq9Tw(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterReadLock();
	}

	internal static object zdvXKufN548Bomluk73(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool SKaSXef3wPLiiMxWjBu(object P_0, object P_1)
	{
		return ((Regex)P_0).IsMatch((string)P_1);
	}

	internal static object Fwh7LUfpeYalvIHcb2R(object P_0, object P_1)
	{
		return GetCorrectTranslationVariant(P_0, P_1);
	}

	internal static void r03onkfa5hciDbdP5rS(object P_0)
	{
		((ReaderWriterLockSlim)P_0).ExitReadLock();
	}

	internal static object AmJgVtfDTHtutwU5BT1(object P_0, object P_1)
	{
		return ((Regex)P_0).Split((string)P_1);
	}

	internal static object uMVd6GftmiLF9clEMG8()
	{
		return Environment.StackTrace;
	}

	internal static object hLGe5efwVmmtam67qDf(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static bool nslMSgf4kNavaANKuti(object P_0, object P_1)
	{
		return ContainsKey(P_0, P_1);
	}

	internal static object wjOd72f69ggE1fcKUeJ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool rMvA0kfHnXtosAHDHwa(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	internal static bool mtwX23fAMdqOQyDem3K(object P_0)
	{
		return ContainsKey((string)P_0);
	}

	internal static bool JcbhQkf7EkwLGkp7urB()
	{
		return ELMAContext.Initialized;
	}

	internal static object uEWa04fxBoxFsQt26MC()
	{
		return TranslateService.Instance;
	}

	internal static bool I8Kgqjf0XUhfOyCJNNu(object P_0)
	{
		return ((TranslateService)P_0).InLineDisabled;
	}

	internal static bool asXlO1fmyP1EGNujCPc(object P_0)
	{
		return ((TranslateService)P_0).Initialized;
	}

	internal static object tLHZIffyaOOFFY10KCT(object P_0)
	{
		return ExtractKeyFromString((string)P_0);
	}

	internal static object VtfQ4sfMxRLjSLso1ML()
	{
		return AuthenticationService.GetCurrentUser();
	}

	internal static void aK4YNSfJnhP1R3eYIp2(object P_0, bool value)
	{
		((TranslateService)P_0).InLineDisabled = value;
	}

	internal static object T3pY1vf9p5wOaHT2d3p(object P_0, object P_1)
	{
		return T((CultureInfo)P_0, (string)P_1);
	}

	internal static object zuAjLGfdMObPvKu1wGJ(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static bool pu1oHZflZBnsDtK8WKB(object P_0)
	{
		return ((TranslateService)P_0).InLineTurned;
	}

	internal static object zQj0ibfrmOi0M6BSYOP(object P_0)
	{
		return T((string)P_0);
	}

	internal static bool dHmVm3fgQQ816kwVw9V()
	{
		return GuiLocalizationUtility.DesignMode;
	}

	internal static object KcN3P6f5Q33p7saMZkQ(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object Yu5m4rfjUyiwlEs6QHV(object P_0)
	{
		return ((DateTimeFormatInfo)P_0).ShortTimePattern;
	}

	internal static int GBJ0shfYcW1fDaoXcPi(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object GdnoxofLlnwDOdyW7KX(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static char mAw3SifUOge9U7pspLw(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object plrWIZfsunMGnoDbsC4(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static UnicodeCategory RX7sHTfc8uwHWHVfGa8(char P_0)
	{
		return CharUnicodeInfo.GetUnicodeCategory(P_0);
	}

	internal static bool U39iKrfz4PTIVB4xC3n(char P_0)
	{
		return char.IsLetter(P_0);
	}

	internal static int lvI4olQF7albnw00yWR(object P_0)
	{
		return ((StringBuilder)P_0).Length;
	}

	internal static int wgXXaUQBOF1cAnNgoe3(object P_0, int P_1)
	{
		return Convert.ToInt32((string)P_0, P_1);
	}

	internal static char bGbNKNQWXtGNaXiJC0b(int P_0)
	{
		return Convert.ToChar(P_0);
	}

	internal static object RuhSxJQopS7Z6nEKkOA(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool uMfBKQQbd5qoCDWUgJN(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool L0PxKdQhr7FZKQO4hnp(object P_0)
	{
		return ContainsNonPrintable(P_0);
	}

	internal static object tLcP3gQGa9N3dZwprrk(object P_0, object P_1)
	{
		return GetString(P_0, P_1);
	}

	internal static object kwlvTKQEEHO8sfth8N8(object P_0, object P_1)
	{
		return BrandResourceManager.R((CultureInfo)P_0, (string)P_1);
	}

	internal static object qIjWcfQf5rSBCxJxJoT(object P_0, object P_1)
	{
		return ((Regex)P_0).Matches((string)P_1);
	}

	internal static object PmLX0FQQHgEiCT6txmq(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object XgpVseQCOibmASoYadl(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (MatchEvaluator)P_2);
	}

	internal static object HSJBx8Qv5rufVERi4AT(object P_0, object P_1, object P_2)
	{
		return ((Regex)P_0).Replace((string)P_1, (MatchEvaluator)P_2);
	}

	internal static object aAVbr7Q8yPGLFqGkHyw(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object PV5rvhQZjGRk8gVdlhI(object P_0)
	{
		return PreparedTranslate((string)P_0);
	}

	internal static void BCJNJSQuVJnwmtjuKwk(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static void hikBXFQIx4YxJJ4veN2()
	{
		InitLanguageHolder();
	}

	internal static object MSJMhNQVQ0jCTmjUlQm(object P_0)
	{
		return XmlReader.Create((Stream)P_0);
	}

	internal static void ndPOVnQSZmBuJtC5DSa(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static object tlWStpQi3Hf2bBM08Jh(object P_0)
	{
		return ((AppDomain)P_0).SetupInformation;
	}

	internal static object SaunRnQRAw1qhtHyIsX(object P_0)
	{
		return ReadFromFile((string)P_0);
	}

	internal static object R0VTSvQqu4QmJxdRWAS(object P_0)
	{
		return ((LanguageHolder)P_0).Name;
	}

	internal static bool gp0RC3QKMejxIhjubBd(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static void JCNRMHQXDekHR5975gn(object P_0, object P_1)
	{
		((LanguageHolder)P_0).Name = (string)P_1;
	}

	internal static object JR8aUOQTGoA3cwNfGJr(object P_0)
	{
		return Path.Combine((string[])P_0);
	}

	internal static void nLP3HYQkc1tcQAbhyTF(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static object UogLjCQnaJP4c3IDq0m()
	{
		return GetCultureFromSettings();
	}

	internal static object tvtXdeQOayhO5fojfJm()
	{
		return Logger.Log;
	}

	internal static bool Hm3kMFQ2UCLVdsMRlJF()
	{
		return ComponentManager.Initialized;
	}

	internal static object uhipgoQeMFLh789jssT()
	{
		return DesignEnvironment.WorkDir;
	}

	internal static object U0cNrTQPdDVLsUegSRW(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static bool PjZmdRQ1nLQM3oPLgur(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object TekMapQNQCNsN9fVuBE(object P_0)
	{
		return ((CultureInfo)P_0).DateTimeFormat;
	}

	internal static object dhmrhyQ3ucja3nk5MgP(object P_0)
	{
		return ((DateTimeFormatInfo)P_0).DayNames;
	}
}
