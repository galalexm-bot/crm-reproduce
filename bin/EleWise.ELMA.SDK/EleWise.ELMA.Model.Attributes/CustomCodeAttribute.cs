using System;
using System.IO;
using System.Reflection;
using System.Text;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class CustomCodeAttribute : Attribute
{
	private Type typeOfAssembly;

	private string resourceName;

	internal static CustomCodeAttribute UDrO52ov5HIPP72dJSUr;

	public CustomCodeAttribute(Type typeOfAssembly, string resourceName)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		v2dC0QovLcnDsTrbmKtK();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.typeOfAssembly = typeOfAssembly;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.resourceName = resourceName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public string GetCode()
	{
		//Discarded unreachable code: IL_007f, IL_00c3, IL_00d2, IL_010b, IL_011a, IL_0149, IL_01ad, IL_0206, IL_023e, IL_024d
		int num = 1;
		int num2 = num;
		Stream stream = default(Stream);
		string result = default(string);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stream = (Stream)ehvbY2ovUwuBPkylTLPd(typeOfAssembly.Assembly, resourceName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				int num3;
				if (stream != null)
				{
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num3 = 0;
					}
					goto IL_0083;
				}
				goto IL_00a1;
				IL_00a1:
				result = null;
				num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num3 = 1;
				}
				goto IL_0083;
				IL_0083:
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					case 2:
						break;
					default:
						memoryStream = (MemoryStream)Rr0ImMovsK44dqyslDuU((int)stream.Length);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num3 = 4;
						}
						continue;
					case 4:
						try
						{
							mQJDtWovcQGA3KhAb4jL(stream, memoryStream);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									return result;
								}
								result = memoryStream.AsString((Encoding)iHGlsTovzFTlNrKZsY5o());
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num4 = 0;
								}
							}
						}
						finally
						{
							if (memoryStream != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										BLJ8Ffo8FQ1PxgsruJDZ(memoryStream);
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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
					}
					break;
				}
				goto IL_00a1;
			}
			finally
			{
				if (stream != null)
				{
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							BLJ8Ffo8FQ1PxgsruJDZ(stream);
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
		}
	}

	internal static void v2dC0QovLcnDsTrbmKtK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool D1ys1WovjPPaWu75Z5vH()
	{
		return UDrO52ov5HIPP72dJSUr == null;
	}

	internal static CustomCodeAttribute WN2fKuovYu6OPUK8aUHD()
	{
		return UDrO52ov5HIPP72dJSUr;
	}

	internal static object ehvbY2ovUwuBPkylTLPd(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionManifestResourceStream((string)P_1);
	}

	internal static object Rr0ImMovsK44dqyslDuU(int requiredSize)
	{
		return MemoryHelper.GetMemoryStream(requiredSize);
	}

	internal static void mQJDtWovcQGA3KhAb4jL(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static object iHGlsTovzFTlNrKZsY5o()
	{
		return Encoding.UTF8;
	}

	internal static void BLJ8Ffo8FQ1PxgsruJDZ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
