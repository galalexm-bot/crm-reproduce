using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Text;
using SG9KiyIbtdgGDf12qr;
using Svg;

namespace EleWise.ELMA.Services;

public static class SvgHelper
{
	private static SvgHelper dXI9XLBtrCI7qjRAXHxV;

	public static string MergeAttributes(string content, IDictionary<string, string> htmlAttributes)
	{
		string empty = string.Empty;
		if (!string.IsNullOrEmpty(content))
		{
			return SvgDocument.FromSvg<SvgDocumentRender>(content).MergeAttributes(htmlAttributes);
		}
		return empty;
	}

	public static string ResetColor(string content)
	{
		return MergeAttributes(content, new Dictionary<string, string> { 
		{
			(string)ykdoybBtjby1QcLdypF4(-1978478350 ^ -1978428156),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103EAF71)
		} });
	}

	public static Bitmap Convert(MemoryStream stream, ImageFormatType type, int size)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_0067, IL_00d1, IL_0130, IL_014f, IL_015e, IL_017b
		int num = 4;
		SvgDocument val = default(SvgDocument);
		MemoryStream memoryStream = default(MemoryStream);
		Bitmap bitmap = default(Bitmap);
		Bitmap result = default(Bitmap);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 7:
					obj = ycC7KmBtYh7MlYgca5DF(val);
					goto IL_01b5;
				case 5:
					memoryStream = (MemoryStream)oeOTQ1BtLcY8RfZL4P0j();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				case 6:
					return null;
				case 1:
					if (size <= 0)
					{
						num = 7;
						break;
					}
					obj = val.Draw(size, size);
					goto IL_01b5;
				default:
					try
					{
						YdKQqRBts65Cw9Yv5C9Z(bitmap, memoryStream, eEBM1vBtUTwUrWcCAepl(type));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							}
							result = new Bitmap(memoryStream);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						int num4;
						if (memoryStream == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num4 = 1;
							}
							goto IL_0134;
						}
						goto IL_0169;
						IL_0169:
						pVCdLuBtcb87WAOSlQ6T(memoryStream);
						num4 = 2;
						goto IL_0134;
						IL_0134:
						switch (num4)
						{
						case 1:
							goto end_IL_010f;
						case 2:
							goto end_IL_010f;
						}
						goto IL_0169;
						end_IL_010f:;
					}
				case 4:
					val = SvgDocument.Open<SvgDocument>((Stream)stream);
					num = 3;
					break;
				case 3:
					{
						if (val == null)
						{
							num2 = 2;
							continue;
						}
						goto case 1;
					}
					IL_01b5:
					bitmap = (Bitmap)obj;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	public static Bitmap Convert(MemoryStream stream, ImageFormatType type)
	{
		return (Bitmap)TdBo97BtzKBqsjCGsceI(stream, type, 0);
	}

	public static Bitmap Convert(byte[] data, ImageFormatType type)
	{
		//Discarded unreachable code: IL_0070, IL_00a8, IL_00c7, IL_00d6, IL_00f3, IL_0102
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		Bitmap result = default(Bitmap);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = (MemoryStream)GWWYm4BwF1G5s0bUkLpc(data, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = (Bitmap)pTgUGIBwBp4bRXym7Zbf(memoryStream, type);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
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
				int num4;
				if (memoryStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num4 = 0;
					}
					goto IL_00ac;
				}
				goto IL_00e1;
				IL_00e1:
				pVCdLuBtcb87WAOSlQ6T(memoryStream);
				num4 = 2;
				goto IL_00ac;
				IL_00ac:
				switch (num4)
				{
				default:
					goto end_IL_0087;
				case 0:
					goto end_IL_0087;
				case 1:
					break;
				case 2:
					goto end_IL_0087;
				}
				goto IL_00e1;
				end_IL_0087:;
			}
		}
	}

	public static Bitmap Convert(string imagePath, ImageFormatType type)
	{
		//Discarded unreachable code: IL_0093, IL_00cb, IL_00ea, IL_00f9, IL_0116, IL_0125
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		Bitmap result = default(Bitmap);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read, 1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				long length = fileStream.Length;
				if (length > int.MaxValue)
				{
					throw new IOException((string)ucrWNVBwWfTisIrsokVF(ykdoybBtjby1QcLdypF4(0x463A0F3C ^ 0x463B491C)));
				}
				result = MemoryHelper.ActionWithMemoryBuffer<byte, (FileStream, string, ImageFormatType), Bitmap>((int)length, (fileStream, imagePath, type), ConvertAction);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
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
				int num4;
				if (fileStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num4 = 0;
					}
					goto IL_00cf;
				}
				goto IL_0104;
				IL_0104:
				pVCdLuBtcb87WAOSlQ6T(fileStream);
				num4 = 2;
				goto IL_00cf;
				IL_00cf:
				switch (num4)
				{
				default:
					goto end_IL_00aa;
				case 0:
					goto end_IL_00aa;
				case 1:
					break;
				case 2:
					goto end_IL_00aa;
				}
				goto IL_0104;
				end_IL_00aa:;
			}
		}
	}

	private static Bitmap ConvertAction(object buffer, int offset, int length, (FileStream, string, ImageFormatType) param)
	{
		int length2 = length;
		var (fileStream, text, type) = param;
		while (length > 0)
		{
			int num = fileStream.Read((byte[])buffer, offset, length);
			if (num == 0)
			{
				throw new EndOfStreamException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98019786), text));
			}
			offset += num;
			length -= num;
		}
		using MemoryStream stream = MemoryHelper.GetMemoryStream((byte[])buffer, offset, length2, writable: false);
		return Convert(stream, type);
	}

	public static ViewBox GetViewBox(string content)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		SvgDocument val = default(SvgDocument);
		while (true)
		{
			switch (num2)
			{
			case 1:
				val = SvgDocument.FromSvg<SvgDocument>(content);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ViewBox viewBox = new ViewBox();
				SvgViewBox val2 = bKOZmcBwoAHp8m9CCVpN(val);
				UaM6BhBwbHEZI8EsFIlr(viewBox, ((SvgViewBox)(ref val2)).get_Height());
				val2 = bKOZmcBwoAHp8m9CCVpN(val);
				nhCG8fBwhaF5ThfBb67Q(viewBox, ((SvgViewBox)(ref val2)).get_Width());
				return viewBox;
			}
			}
		}
	}

	public static string SvgResize(string content, int size)
	{
		//Discarded unreachable code: IL_0064, IL_0133, IL_0152, IL_0161, IL_01af, IL_01e7, IL_01f6
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		MemoryStream memoryStream = default(MemoryStream);
		SvgDocument val = default(SvgDocument);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, EncodingCache.UTF8WithoutEmitIdentifier);
						fhWllwBwQTu3glH9EFwf(xmlTextWriter, Formatting.Indented);
						XmlTextWriter xmlTextWriter2 = xmlTextWriter;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								((SvgElement)val).Write(xmlTextWriter2);
								int num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
								{
									num4 = 3;
								}
								while (true)
								{
									switch (num4)
									{
									case 3:
									{
										xmlTextWriter2.Flush();
										int num5 = 2;
										num4 = num5;
										break;
									}
									case 2:
										if (TghpJKBwC4RdKDP1U06B(memoryStream) > 0)
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
											{
												num4 = 0;
											}
											break;
										}
										return content;
									default:
										content = memoryStream.AsString(EncodingCache.UTF8WithoutEmitIdentifier);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
										{
											num4 = 1;
										}
										break;
									case 1:
										return content;
									}
								}
							}
							finally
							{
								int num6;
								if (xmlTextWriter2 == null)
								{
									num6 = 2;
									goto IL_0137;
								}
								goto IL_016c;
								IL_0137:
								switch (num6)
								{
								case 2:
									goto end_IL_0122;
								case 1:
									goto end_IL_0122;
								}
								goto IL_016c;
								IL_016c:
								pVCdLuBtcb87WAOSlQ6T(xmlTextWriter2);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num6 = 0;
								}
								goto IL_0137;
								end_IL_0122:;
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							int num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									pVCdLuBtcb87WAOSlQ6T(memoryStream);
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
									{
										num7 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 2:
					memoryStream = MemoryHelper.GetMemoryStream();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return content;
				case 5:
					val = SvgDocument.FromSvg<SvgDocument>(content);
					num2 = 4;
					continue;
				case 4:
					break;
				case 3:
					Q56dNKBwf1KLBHFNfKcn(val, SvgUnit.op_Implicit((float)size));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			HtKFroBwE92U8NDU4V0J(val, lSRLAEBwGFegiyE80QFc(size));
			num = 3;
		}
	}

	private static ImageFormat GetImageFormat(ImageFormatType type)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0079, IL_0088, IL_0125, IL_0134, IL_0143
		int num = 6;
		int num2 = num;
		ImageFormat result = default(ImageFormat);
		while (true)
		{
			switch (num2)
			{
			default:
				result = (ImageFormat)BRS04kBwvXNoYIiPWmA2();
				num2 = 8;
				continue;
			case 2:
				goto IL_0093;
			case 3:
			case 7:
			case 8:
			case 9:
				return result;
			case 5:
				switch (type)
				{
				case ImageFormatType.Gif:
					break;
				case ImageFormatType.Svg:
					goto IL_0093;
				default:
					goto IL_00c7;
				case ImageFormatType.Jpg:
					goto IL_00e1;
				case ImageFormatType.Png:
					goto end_IL_0012;
				}
				goto default;
			case 1:
				goto IL_00e1;
			case 6:
				result = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 5;
				}
				continue;
			case 4:
				break;
				IL_0093:
				throw new ArgumentException((string)ucrWNVBwWfTisIrsokVF(ykdoybBtjby1QcLdypF4(-1146510045 ^ -1146559559)));
				IL_00e1:
				result = (ImageFormat)jtheHBBw8WAZNNcbLQVD();
				num2 = 7;
				continue;
				IL_00c7:
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			result = (ImageFormat)rxxbcDBwZHdFNSVnrjFN();
			num2 = 3;
		}
	}

	internal static object ykdoybBtjby1QcLdypF4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool pMaVKABtgfUxjWEE2iUt()
	{
		return dXI9XLBtrCI7qjRAXHxV == null;
	}

	internal static SvgHelper oFAedOBt5d2lTIuNtJ7P()
	{
		return dXI9XLBtrCI7qjRAXHxV;
	}

	internal static object ycC7KmBtYh7MlYgca5DF(object P_0)
	{
		return ((SvgDocument)P_0).Draw();
	}

	internal static object oeOTQ1BtLcY8RfZL4P0j()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object eEBM1vBtUTwUrWcCAepl(ImageFormatType type)
	{
		return GetImageFormat(type);
	}

	internal static void YdKQqRBts65Cw9Yv5C9Z(object P_0, object P_1, object P_2)
	{
		((Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
	}

	internal static void pVCdLuBtcb87WAOSlQ6T(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object TdBo97BtzKBqsjCGsceI(object P_0, ImageFormatType type, int size)
	{
		return Convert((MemoryStream)P_0, type, size);
	}

	internal static object GWWYm4BwF1G5s0bUkLpc(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object pTgUGIBwBp4bRXym7Zbf(object P_0, ImageFormatType type)
	{
		return Convert((MemoryStream)P_0, type);
	}

	internal static object ucrWNVBwWfTisIrsokVF(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static SvgViewBox bKOZmcBwoAHp8m9CCVpN(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SvgFragment)P_0).get_ViewBox();
	}

	internal static void UaM6BhBwbHEZI8EsFIlr(object P_0, float value)
	{
		((ViewBox)P_0).Height = value;
	}

	internal static void nhCG8fBwhaF5ThfBb67Q(object P_0, float value)
	{
		((ViewBox)P_0).Width = value;
	}

	internal static SvgUnit lSRLAEBwGFegiyE80QFc(float P_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return SvgUnit.op_Implicit(P_0);
	}

	internal static void HtKFroBwE92U8NDU4V0J(object P_0, SvgUnit P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SvgFragment)P_0).set_Height(P_1);
	}

	internal static void Q56dNKBwf1KLBHFNfKcn(object P_0, SvgUnit P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SvgFragment)P_0).set_Width(P_1);
	}

	internal static void fhWllwBwQTu3glH9EFwf(object P_0, Formatting P_1)
	{
		((XmlTextWriter)P_0).Formatting = P_1;
	}

	internal static long TghpJKBwC4RdKDP1U06B(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object BRS04kBwvXNoYIiPWmA2()
	{
		return ImageFormat.Gif;
	}

	internal static object jtheHBBw8WAZNNcbLQVD()
	{
		return ImageFormat.Jpeg;
	}

	internal static object rxxbcDBwZHdFNSVnrjFN()
	{
		return ImageFormat.Png;
	}
}
