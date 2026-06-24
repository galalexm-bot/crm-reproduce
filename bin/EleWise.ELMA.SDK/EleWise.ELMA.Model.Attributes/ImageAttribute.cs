using System;
using System.Drawing;
using System.IO;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = true)]
public class ImageAttribute : Attribute, IImageAttribute
{
	private Type typeOfAssembly;

	private string resourceName;

	private int size;

	private ImageFormatType format;

	private bool isDefault;

	internal static ImageAttribute RFfrSyo8PeOmhfLa2jBd;

	public int Size => size;

	public bool IsDefault => isDefault;

	public ImageFormatType Format => format;

	public string ResouseName => resourceName;

	public ImageAttribute(Type typeOfAssembly, string resourceName, int size, ImageFormatType format, bool isDefault = false)
	{
		//Discarded unreachable code: IL_001a
		rioH4go83dRZUc8FUP8V();
		base._002Ector();
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				this.typeOfAssembly = typeOfAssembly;
				num = 2;
				break;
			case 1:
				return;
			case 4:
				this.size = size;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 0;
				}
				break;
			default:
			{
				this.format = format;
				int num2 = 3;
				num = num2;
				break;
			}
			case 2:
				this.resourceName = resourceName;
				num = 4;
				break;
			case 3:
				this.isDefault = isDefault;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public byte[] GetImageData()
	{
		//Discarded unreachable code: IL_00a7, IL_00b6, IL_015c, IL_017b, IL_018a, IL_01a7, IL_01b6
		int num = 2;
		int num2 = num;
		Stream reflectionManifestResourceStream = default(Stream);
		byte[] array = default(byte[]);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				reflectionManifestResourceStream = typeOfAssembly.Assembly.GetReflectionManifestResourceStream(resourceName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					int num3;
					if (reflectionManifestResourceStream == null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num3 = 0;
						}
						goto IL_0080;
					}
					goto IL_00d2;
					IL_00d2:
					array = new byte[reflectionManifestResourceStream.Length];
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num3 = 0;
					}
					goto IL_0080;
					IL_0080:
					while (true)
					{
						switch (num3)
						{
						case 1:
						{
							result = null;
							int num4 = 4;
							num3 = num4;
							continue;
						}
						case 5:
							break;
						case 2:
							result = array;
							num3 = 3;
							continue;
						default:
							reflectionManifestResourceStream.Read(array, 0, (int)xAYPxwo8pLauRWEGr3TK(reflectionManifestResourceStream));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num3 = 2;
							}
							continue;
						case 3:
							return result;
						case 4:
							return result;
						}
						break;
					}
					goto IL_00d2;
				}
				finally
				{
					int num5;
					if (reflectionManifestResourceStream == null)
					{
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num5 = 1;
						}
						goto IL_0160;
					}
					goto IL_0195;
					IL_0195:
					T0IXiho8ah8x7B2SYJAT(reflectionManifestResourceStream);
					num5 = 2;
					goto IL_0160;
					IL_0160:
					switch (num5)
					{
					case 1:
						goto end_IL_013b;
					case 2:
						goto end_IL_013b;
					}
					goto IL_0195;
					end_IL_013b:;
				}
			default:
				return result;
			}
		}
	}

	public Image CreateImage()
	{
		//Discarded unreachable code: IL_006e, IL_00a6, IL_00de, IL_00ed, IL_011f, IL_012e
		int num = 5;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] imageData = default(byte[]);
		Image result = default(Image);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				memoryStream = (MemoryStream)w33aSko8DV1NbbVQxCSr(imageData, false);
				num2 = 2;
				break;
			case 2:
				try
				{
					result = new Bitmap(memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								T0IXiho8ah8x7B2SYJAT(memoryStream);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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
			case 5:
				imageData = GetImageData();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (imageData != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 1:
				return result;
			}
		}
	}

	internal static void rioH4go83dRZUc8FUP8V()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Ys3jcpo81skeVmKi1Jdj()
	{
		return RFfrSyo8PeOmhfLa2jBd == null;
	}

	internal static ImageAttribute ax5QCHo8NLvwnlMEMnCi()
	{
		return RFfrSyo8PeOmhfLa2jBd;
	}

	internal static long xAYPxwo8pLauRWEGr3TK(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static void T0IXiho8ah8x7B2SYJAT(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object w33aSko8DV1NbbVQxCSr(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}
}
