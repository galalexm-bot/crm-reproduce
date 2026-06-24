using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Formats;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public class ElmaGeneratorFormatProvider : GeneratorFormatProvider
{
	private IEnumerable<ITemplateGeneratorFormatter> formatProviders;

	internal static ElmaGeneratorFormatProvider FQ8Ve9B3x6WG9d0jGIQX;

	public ElmaGeneratorFormatProvider(GenerationContext context)
	{
		//Discarded unreachable code: IL_002b, IL_0030, IL_0053
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(context);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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
			case 2:
				return;
			case 3:
				formatProviders = ((ComponentManager)EikosQB3MMbW85cj3Vim()).GetExtensionPoints<ITemplateGeneratorFormatter>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 0;
				}
				break;
			case 1:
				if (!dVEXH7B3yK03k6tJphqK())
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override string FormatValue(FormatedValue value)
	{
		//Discarded unreachable code: IL_010a, IL_0124, IL_0133, IL_01a1, IL_01b0, IL_0207, IL_0238, IL_0247, IL_0256, IL_028e, IL_029d, IL_02a8, IL_0357, IL_03bc, IL_03c7, IL_03d6, IL_03e5, IL_0432, IL_0490, IL_049f, IL_04af, IL_052d, IL_054b, IL_05b9, IL_0609, IL_0658, IL_06c2, IL_06d1, IL_06f6, IL_0731, IL_0740, IL_07c6, IL_07d5, IL_089b, IL_08aa, IL_08cb, IL_090b, IL_091a, IL_0926
		int num = 23;
		string text = default(string);
		TemplateRenderMode templateRenderMode = default(TemplateRenderMode);
		IEnumerator<ITemplateGeneratorFormatter> enumerator = default(IEnumerator<ITemplateGeneratorFormatter>);
		MetadataBasedFormat metadataBasedFormat = default(MetadataBasedFormat);
		IEnumerator enumerator2 = default(IEnumerator);
		object value2 = default(object);
		StringBuilder stringBuilder = default(StringBuilder);
		IFormatTypeDescriptor formatTypeDescriptor = default(IFormatTypeDescriptor);
		bool flag = default(bool);
		string text3 = default(string);
		string result = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				object obj;
				string text2;
				switch (num2)
				{
				case 45:
					num3 = (text.Contains('\n') ? 1 : 0);
					goto IL_0989;
				case 20:
					if (value != null)
					{
						num2 = 14;
						continue;
					}
					goto IL_0683;
				case 48:
					if (text == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 3;
				case 27:
					if (value == null)
					{
						num2 = 44;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 39;
				case 9:
					text = null;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 34;
					}
					continue;
				case 5:
					return (string)goLhx1Bpo9mc5D2yDraQ(this, text);
				case 13:
					if (templateRenderMode == TemplateRenderMode.HTML)
					{
						num2 = 48;
						continue;
					}
					return (string)goLhx1Bpo9mc5D2yDraQ(this, text);
				case 34:
					if (value == null)
					{
						num = 24;
						break;
					}
					obj = value.Format as MetadataBasedFormat;
					goto IL_093b;
				case 22:
					IwYpOkB39gEMptQjHYBc(this, value);
					num2 = 31;
					continue;
				case 46:
					text2 = HttpUtility.HtmlEncode(text);
					goto IL_09b2;
				case 37:
					enumerator = formatProviders.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (metadataBasedFormat != null)
					{
						num2 = 40;
						continue;
					}
					goto case 6;
				case 1:
					if (!ygMHUUBpbP8gNTd51AZW(text))
					{
						num2 = 13;
						continue;
					}
					goto case 5;
				case 12:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator2.MoveNext())
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num7 = 2;
								}
								goto IL_02ac;
							}
							goto IL_02ec;
							IL_02ec:
							value2 = m9OGOEBpF4p0wOf7qvyw(enumerator2);
							num7 = 3;
							goto IL_02ac;
							IL_02ac:
							while (true)
							{
								switch (num7)
								{
								case 1:
									break;
								default:
									goto IL_02ec;
								case 3:
									stringBuilder.Append((string)bxM1UNBpB1CC4BuBs24V(this, new FormatedValue(value2)));
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
									{
										num7 = 1;
									}
									continue;
								case 2:
									goto end_IL_02c6;
								}
								break;
							}
							continue;
							end_IL_02c6:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator2 as IDisposable;
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							case 3:
								V4L6J6BpWDWQ44kjP4S5(disposable);
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num8 = 1;
								}
								continue;
							default:
								if (disposable == null)
								{
									num8 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num8 = 2;
									}
									continue;
								}
								goto case 3;
							case 2:
								break;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 8;
				case 55:
					text = (string)BxGE0CB3sD9APXjPRCny(oPk1X4B3d1CH3xNRwR6c(value));
					num2 = 21;
					continue;
				case 35:
					if (!MqxTo8B3527DXkxfpYQ0(((PropertyMetadata)jCFp63B3gs6DV0ENBoLV(metadataBasedFormat)).TypeUid, Guid.Empty))
					{
						num2 = 6;
						continue;
					}
					goto case 49;
				case 49:
					formatTypeDescriptor = TZdvgCB3LF6o05lxG074(UA2oPZB3jDQcuH6CwL22(), iA39ICB3YPMmNjy7KbA0(jCFp63B3gs6DV0ENBoLV(metadataBasedFormat)), ((PropertyMetadata)jCFp63B3gs6DV0ENBoLV(metadataBasedFormat)).SubTypeUid) as IFormatTypeDescriptor;
					num2 = 17;
					continue;
				case 30:
					stringBuilder = new StringBuilder();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 42;
					}
					continue;
				case 14:
					if (oPk1X4B3d1CH3xNRwR6c(value) is HtmlString)
					{
						num2 = 2;
						continue;
					}
					goto IL_0683;
				case 42:
					enumerator2 = (IEnumerator)sqTeECB3zPd8qu0S4KRV((IEnumerable)value.Value);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 10;
					}
					continue;
				case 47:
					if (value != null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 26;
				case 54:
					text2 = string.Empty;
					goto IL_09b2;
				case 19:
					text = FormatTextToLink(text);
					num2 = 50;
					continue;
				case 21:
				case 44:
				case 52:
					if (text != null)
					{
						num2 = 38;
						continue;
					}
					goto case 47;
				case 15:
					if (value == null)
					{
						num2 = 33;
						continue;
					}
					goto case 7;
				case 33:
				case 36:
				case 50:
					return (string)goLhx1Bpo9mc5D2yDraQ(this, text);
				case 23:
					templateRenderMode = lLy54VB3JvJQqZIq7Wtu(base.Context);
					num2 = 22;
					continue;
				case 17:
					if (formatTypeDescriptor == null)
					{
						num2 = 43;
						continue;
					}
					goto case 29;
				case 24:
					obj = null;
					goto IL_093b;
				case 10:
					text = base.FormatValue(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					return (string)goLhx1Bpo9mc5D2yDraQ(this, stringBuilder.ToString());
				case 26:
				case 28:
				case 38:
					if (text == null)
					{
						num = 10;
						break;
					}
					goto case 1;
				case 4:
					if (oPk1X4B3d1CH3xNRwR6c(value).GetType().IsEnum)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 55;
						}
						continue;
					}
					goto case 21;
				case 41:
					if (flag)
					{
						num2 = 51;
						continue;
					}
					goto case 46;
				case 32:
					if (text != null)
					{
						num = 41;
						break;
					}
					goto case 54;
				case 2:
					return oPk1X4B3d1CH3xNRwR6c(value).ToString();
				case 39:
					if (value.Value != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 21;
				case 6:
				case 25:
				case 43:
					if (text != null)
					{
						num = 52;
						break;
					}
					goto case 27;
				case 31:
					if (templateRenderMode == TemplateRenderMode.HTML)
					{
						num2 = 20;
						continue;
					}
					goto IL_0683;
				case 18:
					if (!(oPk1X4B3d1CH3xNRwR6c(value) is IEnumerable))
					{
						num2 = 26;
						continue;
					}
					goto case 53;
				case 7:
					if (!(oPk1X4B3d1CH3xNRwR6c(value) is string))
					{
						num = 36;
						break;
					}
					goto case 19;
				case 3:
					if (text.Contains('\r'))
					{
						num3 = 1;
						goto IL_0989;
					}
					num2 = 45;
					continue;
				case 40:
					if (metadataBasedFormat.PropertyMetadata != null)
					{
						num2 = 35;
						continue;
					}
					goto case 6;
				case 53:
					if (!jGbKRfB3ccAB20NDUNbV(oPk1X4B3d1CH3xNRwR6c(value).GetType(), typeof(string)))
					{
						num2 = 28;
						continue;
					}
					goto case 30;
				default:
					try
					{
						while (true)
						{
							IL_0870:
							int num4;
							if (!f1BN7tB3rtS9CbIxYmyi(enumerator))
							{
								num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num4 = 0;
								}
								goto IL_07e4;
							}
							goto IL_082a;
							IL_082a:
							text3 = (string)as99aSB3lJOkothebKFa(enumerator.Current, base.Context, value, templateRenderMode);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num4 = 0;
							}
							goto IL_07e4;
							IL_07e4:
							while (true)
							{
								switch (num4)
								{
								case 3:
									return result;
								case 2:
									result = AdaptNewLines(text3);
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num4 = 3;
									}
									continue;
								case 5:
									break;
								default:
									if (text3 != null)
									{
										int num5 = 2;
										num4 = num5;
										continue;
									}
									goto IL_0870;
								case 1:
									goto IL_0870;
								case 4:
									goto end_IL_0870;
								}
								break;
							}
							goto IL_082a;
							continue;
							end_IL_0870:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 2;
							goto IL_08cf;
						}
						goto IL_08e5;
						IL_08cf:
						switch (num6)
						{
						case 2:
							goto end_IL_08ba;
						case 1:
							goto end_IL_08ba;
						}
						goto IL_08e5;
						IL_08e5:
						enumerator.Dispose();
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num6 = 0;
						}
						goto IL_08cf;
						end_IL_08ba:;
					}
					goto case 9;
				case 29:
					text = (string)ePsQTWB3UBUA1OLRFOyn(formatTypeDescriptor, (value != null) ? oPk1X4B3d1CH3xNRwR6c(value) : null, jCFp63B3gs6DV0ENBoLV(metadataBasedFormat));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 17;
					}
					continue;
				case 16:
					num3 = 0;
					goto IL_0989;
				case 51:
					{
						text2 = WrapByPre(HttpUtility.HtmlEncode(text));
						goto IL_09b2;
					}
					IL_09b2:
					text = text2;
					num2 = 15;
					continue;
					IL_093b:
					metadataBasedFormat = (MetadataBasedFormat)obj;
					num2 = 11;
					continue;
					IL_0989:
					flag = (byte)num3 != 0;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 32;
					}
					continue;
					IL_0683:
					if (formatProviders != null)
					{
						num2 = 37;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	public static string FormatTextToLink(string text, bool wrap = true)
	{
		return (string)aj1XNHBph3yO48dXEIug(text, wrap, false);
	}

	public static string FormatTextToLink(string text, bool wrap, bool contextVarEnabled)
	{
		//Discarded unreachable code: IL_0074, IL_007e, IL_008d
		int num = 4;
		int num2 = num;
		string text2 = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				obj = string.Format((string)LllrseBpECcJRVWLeECk(-2106517564 ^ -2106567324), LllrseBpECcJRVWLeECk(0x10E41EDB ^ 0x10E55C69), LllrseBpECcJRVWLeECk(-542721635 ^ -542639239));
				goto IL_013e;
			case 5:
				return text;
			case 3:
				return text;
			case 4:
				if (!rgrAfcBpGC0eLvfnimJr(text))
				{
					if (contextVarEnabled)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				obj = wThxBKBpf6mI0hEj4GkU(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672041409), LllrseBpECcJRVWLeECk(0x1C9495B4 ^ 0x1C95D706), LllrseBpECcJRVWLeECk(-978351861 ^ -978400273), LllrseBpECcJRVWLeECk(-70037984 ^ -70120178));
				goto IL_013e;
			case 2:
				{
					text = (string)no9dwnBpC0R4Jvtd49VL(text, yZlFDeBpQ6sE3IEQ8Ei0(LllrseBpECcJRVWLeECk(-561074844 ^ -560992728), text2), (MatchEvaluator)((Match match) => (string)_003C_003Ec.VdbC0eQKKEUb9g7cUd6w(_003C_003Ec.dbenkWQKR11kTtwd5vNR(-672123589 ^ -671792937), _003C_003Ec.HOyKW1QKqpfj9dn8hsnl(match))), RegexOptions.IgnoreCase);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 5;
					}
					break;
				}
				IL_013e:
				text2 = (string)obj;
				num2 = 2;
				break;
			}
		}
	}

	public static string FormatTextTagBracket(string text)
	{
		return (string)h2daPiBpv88mcrQX3tIZ(h2daPiBpv88mcrQX3tIZ(text, LllrseBpECcJRVWLeECk(--1360331293 ^ 0x51154DDB), LllrseBpECcJRVWLeECk(0x68BBB53E ^ 0x68BAF642)), LllrseBpECcJRVWLeECk(-1870892489 ^ -1870905865), LllrseBpECcJRVWLeECk(-2138160520 ^ -2138111504));
	}

	public override Image GetImage(FormatedValue value)
	{
		//Discarded unreachable code: IL_00b0, IL_00e6, IL_0145, IL_0164, IL_0173, IL_01b1, IL_01e9, IL_021d, IL_027b
		int num = 2;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		Image result = default(Image);
		Stream content = default(Stream);
		string ext = default(string);
		while (true)
		{
			string text;
			switch (num2)
			{
			case 1:
				return null;
			case 8:
				if (binaryFile != null)
				{
					num2 = 9;
					continue;
				}
				goto case 7;
			case 6:
				return result;
			default:
				try
				{
					MemoryStream memoryStream = ((MemoryStream)iVpfUyBpuaV2XYquMDny((int)YneDZvBpZjYThqd8JZUh(content))).AsNoClose();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							XmZSpjBpIS2aPZcLL3hK(content, memoryStream);
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									return result;
								case 0:
									return result;
								case 1:
									result = (Image)npY7H8BpVsWXZPPcf3UH(memoryStream);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}
						finally
						{
							int num5;
							if (memoryStream == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num5 = 0;
								}
								goto IL_0149;
							}
							goto IL_017e;
							IL_017e:
							V4L6J6BpWDWQ44kjP4S5(memoryStream);
							num5 = 2;
							goto IL_0149;
							IL_0149:
							switch (num5)
							{
							default:
								goto end_IL_0124;
							case 0:
								goto end_IL_0124;
							case 1:
								break;
							case 2:
								goto end_IL_0124;
							}
							goto IL_017e;
							end_IL_0124:;
						}
					}
				}
				finally
				{
					if (content != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								V4L6J6BpWDWQ44kjP4S5(content);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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
			case 2:
				if (value != null)
				{
					binaryFile = oPk1X4B3d1CH3xNRwR6c(value) as BinaryFile;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 4:
				text = string.Empty;
				break;
			case 3:
				if (binaryFile != null)
				{
					num2 = 5;
					continue;
				}
				goto case 4;
			case 7:
				return (Image)yN9EVbBp8rsKekGa3Mav(this, value);
			case 9:
				if (IsSupportedImageExtension(ext))
				{
					content = binaryFile.GetContent();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 7;
				}
				continue;
			case 5:
				text = binaryFile.Extension;
				break;
			}
			ext = text;
			num2 = 8;
		}
	}

	protected virtual bool IsSupportedImageExtension(string ext)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!jFueYYBpSn8FYxogOSSh(ext, LllrseBpECcJRVWLeECk(0x63ABA4E8 ^ 0x63AA990A)))
				{
					num2 = 4;
					continue;
				}
				break;
			case 1:
				ext = ext.ToLower();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				if (!(ext == (string)LllrseBpECcJRVWLeECk(-561074844 ^ -560992572)))
				{
					num2 = 5;
					continue;
				}
				break;
			case 3:
				if (!jFueYYBpSn8FYxogOSSh(ext, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A7EF8E)))
				{
					num2 = 6;
					continue;
				}
				break;
			case 4:
				if (!(ext == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870843485)))
				{
					num2 = 3;
					continue;
				}
				break;
			default:
				if (!jFueYYBpSn8FYxogOSSh(ext, LllrseBpECcJRVWLeECk(-1852837372 ^ -1852911662)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 5:
				return jFueYYBpSn8FYxogOSSh(ext, LllrseBpECcJRVWLeECk(-70007027 ^ -70089567));
			}
			break;
		}
		return true;
	}

	private string WrapByPre(string s)
	{
		return (string)lnZxATBpiY1LO4J6V3Nl(LllrseBpECcJRVWLeECk(-1765851862 ^ -1765900656), s.Nl2Br(), LllrseBpECcJRVWLeECk(-1998538950 ^ -1998458050));
	}

	internal static bool dVEXH7B3yK03k6tJphqK()
	{
		return ComponentManager.Initialized;
	}

	internal static object EikosQB3MMbW85cj3Vim()
	{
		return ComponentManager.Current;
	}

	internal static bool mIUUb5B30pjTDmoaXDij()
	{
		return FQ8Ve9B3x6WG9d0jGIQX == null;
	}

	internal static ElmaGeneratorFormatProvider ebgfnJB3mayiiCna6Rq8()
	{
		return FQ8Ve9B3x6WG9d0jGIQX;
	}

	internal static TemplateRenderMode lLy54VB3JvJQqZIq7Wtu(object P_0)
	{
		return ((GenerationContext)P_0).GetRenderMode();
	}

	internal static void IwYpOkB39gEMptQjHYBc(object P_0, object P_1)
	{
		((GeneratorFormatProvider)P_0).TransformDateTime((FormatedValue)P_1);
	}

	internal static object oPk1X4B3d1CH3xNRwR6c(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object as99aSB3lJOkothebKFa(object P_0, object P_1, object P_2, TemplateRenderMode renderMode)
	{
		return ((ITemplateGeneratorFormatter)P_0).FormatValue((GenerationContext)P_1, (FormatedValue)P_2, renderMode);
	}

	internal static bool f1BN7tB3rtS9CbIxYmyi(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object jCFp63B3gs6DV0ENBoLV(object P_0)
	{
		return ((MetadataBasedFormat)P_0).PropertyMetadata;
	}

	internal static bool MqxTo8B3527DXkxfpYQ0(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object UA2oPZB3jDQcuH6CwL22()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid iA39ICB3YPMmNjy7KbA0(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object TZdvgCB3LF6o05lxG074(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object ePsQTWB3UBUA1OLRFOyn(object P_0, object P_1, object P_2)
	{
		return ((IFormatTypeDescriptor)P_0).FormatValue(P_1, (PropertyMetadata)P_2);
	}

	internal static object BxGE0CB3sD9APXjPRCny(object P_0)
	{
		return ModelHelper.GetEnumDisplayName(P_0);
	}

	internal static bool jGbKRfB3ccAB20NDUNbV(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object sqTeECB3zPd8qu0S4KRV(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object m9OGOEBpF4p0wOf7qvyw(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object bxM1UNBpB1CC4BuBs24V(object P_0, object P_1)
	{
		return ((GeneratorFormatProvider)P_0).FormatValue((FormatedValue)P_1);
	}

	internal static void V4L6J6BpWDWQ44kjP4S5(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object goLhx1Bpo9mc5D2yDraQ(object P_0, object P_1)
	{
		return ((GeneratorFormatProvider)P_0).AdaptNewLines((string)P_1);
	}

	internal static bool ygMHUUBpbP8gNTd51AZW(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object aj1XNHBph3yO48dXEIug(object P_0, bool wrap, bool contextVarEnabled)
	{
		return FormatTextToLink((string)P_0, wrap, contextVarEnabled);
	}

	internal static bool rgrAfcBpGC0eLvfnimJr(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object LllrseBpECcJRVWLeECk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object wThxBKBpf6mI0hEj4GkU(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object yZlFDeBpQ6sE3IEQ8Ei0(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object no9dwnBpC0R4Jvtd49VL(object P_0, object P_1, object P_2, RegexOptions P_3)
	{
		return Regex.Replace((string)P_0, (string)P_1, (MatchEvaluator)P_2, P_3);
	}

	internal static object h2daPiBpv88mcrQX3tIZ(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object yN9EVbBp8rsKekGa3Mav(object P_0, object P_1)
	{
		return ((GeneratorFormatProvider)P_0).GetImage((FormatedValue)P_1);
	}

	internal static long YneDZvBpZjYThqd8JZUh(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object iVpfUyBpuaV2XYquMDny(int requiredSize)
	{
		return MemoryHelper.GetMemoryStream(requiredSize);
	}

	internal static void XmZSpjBpIS2aPZcLL3hK(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static object npY7H8BpVsWXZPPcf3UH(object P_0)
	{
		return Image.FromStream((Stream)P_0);
	}

	internal static bool jFueYYBpSn8FYxogOSSh(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object lnZxATBpiY1LO4J6V3Nl(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
