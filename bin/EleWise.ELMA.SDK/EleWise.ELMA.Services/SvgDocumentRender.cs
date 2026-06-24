using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using Svg;

namespace EleWise.ELMA.Services;

internal class SvgDocumentRender : SvgDocument
{
	private IDictionary<string, string> htmlAttributes;

	internal static SvgDocumentRender vQb12OB6ltTaBZ2xyMgU;

	protected override void WriteAttributes(XmlTextWriter writer)
	{
		//Discarded unreachable code: IL_0033, IL_0042, IL_004d, IL_00fa, IL_013a, IL_0145, IL_0154
		int num = 2;
		int num2 = num;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current = default(string);
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
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0051;
						}
						goto IL_00b1;
						IL_0051:
						while (true)
						{
							switch (num3)
							{
							default:
								LLR9toB658GJkdZKQEj9(this, current, htmlAttributes[current], 0);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							case 3:
								goto IL_00b1;
							case 2:
								goto end_IL_009b;
							}
							break;
						}
						continue;
						IL_00b1:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num3 = 0;
						}
						goto IL_0051;
						continue;
						end_IL_009b:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num4 = 0;
						}
						goto IL_00fe;
					}
					goto IL_0114;
					IL_0114:
					cddSAaB6j06TEOqoOd1S(enumerator);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num4 = 1;
					}
					goto IL_00fe;
					IL_00fe:
					switch (num4)
					{
					default:
						goto end_IL_00d9;
					case 2:
						break;
					case 0:
						goto end_IL_00d9;
					case 1:
						goto end_IL_00d9;
					}
					goto IL_0114;
					end_IL_00d9:;
				}
				goto case 3;
			case 3:
				puOpxPB6YlKBwYp7BQgH(this, writer);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				enumerator = htmlAttributes.Keys.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public string MergeAttributes(IDictionary<string, string> htmlAttributes)
	{
		Contract.NotNull(htmlAttributes, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE02D51));
		this.htmlAttributes = htmlAttributes;
		using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
		{
			((SvgDocument)this).Write((Stream)memoryStream, false);
			if (memoryStream.Length > 0)
			{
				return memoryStream.AsString(EncodingCache.UTF8WithoutEmitIdentifier);
			}
		}
		return string.Empty;
	}

	public SvgDocumentRender()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		((SvgDocument)this)._002Ector();
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

	internal static void LLR9toB658GJkdZKQEj9(object P_0, object P_1, object P_2, int P_3)
	{
		((SvgElement)P_0).AddStyle((string)P_1, (string)P_2, P_3);
	}

	internal static void cddSAaB6j06TEOqoOd1S(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void puOpxPB6YlKBwYp7BQgH(object P_0, object P_1)
	{
		((SvgElement)P_0).WriteAttributes((XmlTextWriter)P_1);
	}

	internal static bool ifb8eNB6r16jdnFTg7Jd()
	{
		return vQb12OB6ltTaBZ2xyMgU == null;
	}

	internal static SvgDocumentRender iuuWMCB6gwae7uK3f0lA()
	{
		return vQb12OB6ltTaBZ2xyMgU;
	}
}
