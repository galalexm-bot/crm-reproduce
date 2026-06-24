using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.TranslateData;

public static class CodeItemCodeGenerator
{
	internal static CodeItemCodeGenerator o5RB0i8sbowdSWYPlsZ;

	public static List<string> AlfabetList { get; set; }

	public static List<string> ExceptionsWordList { get; set; }

	static CodeItemCodeGenerator()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					yZpSb4ZBEPaZ4LDtqZj();
					num = 3;
					break;
				default:
					ExceptionsWordList = new List<string>();
					num = 4;
					break;
				case 3:
					return;
				case 2:
					F0dj9OZFj7Tpal4poof();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					AlfabetList = new List<string>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public static byte[] GenerateCSCode(CodeNamespace code)
	{
		//Discarded unreachable code: IL_0054, IL_00b6, IL_0115, IL_0134, IL_0181, IL_01b9, IL_01c8
		int num = 2;
		int num2 = num;
		byte[] result = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				try
				{
					StreamWriter streamWriter = new StreamWriter(memoryStream, (Encoding)SV01mDZoKMRW3dZsRkb());
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							ICodeGenerator codeGenerator = new CSharpCodeProvider().CreateGenerator(streamWriter);
							CodeGeneratorOptions codeGeneratorOptions = new CodeGeneratorOptions();
							oGP5WBZhoZeR72Z6grd(codeGeneratorOptions, Jm855pZbDswibI4U2gQ(0xA592A41 ^ 0xA59690D));
							codeGenerator.GenerateCodeFromNamespace(code, streamWriter, codeGeneratorOptions);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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
								result = (byte[])a93vbJZGccsXtqPoTOI(memoryStream);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num4 = 0;
								}
							}
						}
						finally
						{
							int num5;
							if (streamWriter == null)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
								{
									num5 = 1;
								}
								goto IL_0119;
							}
							goto IL_013e;
							IL_013e:
							LRqoE5ZEF1FBYOkOHWZ(streamWriter);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num5 = 0;
							}
							goto IL_0119;
							IL_0119:
							switch (num5)
							{
							default:
								goto end_IL_00f4;
							case 1:
								goto end_IL_00f4;
							case 2:
								break;
							case 0:
								goto end_IL_00f4;
							}
							goto IL_013e;
							end_IL_00f4:;
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								((IDisposable)memoryStream).Dispose();
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num6 = 1;
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
				memoryStream = (MemoryStream)CQUk1IZWfB082RT57DH();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static string GenerateCSCodeString(CodeNamespace code)
	{
		//Discarded unreachable code: IL_0075, IL_00d1, IL_0135, IL_0154, IL_0163, IL_01b1, IL_01d0, IL_01df, IL_01fc, IL_020b
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = (MemoryStream)CQUk1IZWfB082RT57DH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter(memoryStream, (Encoding)SV01mDZoKMRW3dZsRkb());
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						object obj = zq8bhpZfN6Q6dt4nRF0(new CSharpCodeProvider(), streamWriter);
						CodeGeneratorOptions codeGeneratorOptions = new CodeGeneratorOptions();
						oGP5WBZhoZeR72Z6grd(codeGeneratorOptions, Jm855pZbDswibI4U2gQ(0x2ACE37D ^ 0x2ACA031));
						BK8PlvZQnVpF4pM6rZ5(obj, code, streamWriter, codeGeneratorOptions);
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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
								result = memoryStream.AsString(Encoding.UTF8);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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
						if (streamWriter == null)
						{
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num5 = 2;
							}
							goto IL_0139;
						}
						goto IL_016e;
						IL_016e:
						LRqoE5ZEF1FBYOkOHWZ(streamWriter);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num5 = 0;
						}
						goto IL_0139;
						IL_0139:
						switch (num5)
						{
						case 2:
							goto end_IL_0114;
						case 1:
							goto end_IL_0114;
						}
						goto IL_016e;
						end_IL_0114:;
					}
				}
			}
			finally
			{
				int num6;
				if (memoryStream == null)
				{
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num6 = 1;
					}
					goto IL_01b5;
				}
				goto IL_01ea;
				IL_01ea:
				LRqoE5ZEF1FBYOkOHWZ(memoryStream);
				num6 = 2;
				goto IL_01b5;
				IL_01b5:
				switch (num6)
				{
				case 1:
					goto end_IL_0190;
				case 2:
					goto end_IL_0190;
				}
				goto IL_01ea;
				end_IL_0190:;
			}
		}
	}

	public static string GenerateCSCodeStringFromStatement(CodeStatement code)
	{
		//Discarded unreachable code: IL_0054, IL_00b0, IL_0114, IL_016d, IL_01a5, IL_01b4
		int num = 1;
		int num2 = num;
		string result = default(string);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				memoryStream = (MemoryStream)CQUk1IZWfB082RT57DH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter(memoryStream, (Encoding)SV01mDZoKMRW3dZsRkb());
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						object obj = zq8bhpZfN6Q6dt4nRF0(new CSharpCodeProvider(), streamWriter);
						CodeGeneratorOptions codeGeneratorOptions = new CodeGeneratorOptions();
						oGP5WBZhoZeR72Z6grd(codeGeneratorOptions, Jm855pZbDswibI4U2gQ(0x1637C429 ^ 0x16378765));
						W2jCmrZCAdsGhqU34cQ(obj, code, streamWriter, codeGeneratorOptions);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
							result = memoryStream.AsString(Encoding.UTF8);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num4 = 1;
							}
						}
					}
					finally
					{
						if (streamWriter != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									LRqoE5ZEF1FBYOkOHWZ(streamWriter);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
			}
			finally
			{
				if (memoryStream != null)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							((IDisposable)memoryStream).Dispose();
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num6 = 1;
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

	public static byte[] GenerateCSCodeFromStatement(CodeStatement code)
	{
		//Discarded unreachable code: IL_0072, IL_00d4, IL_0133, IL_018c, IL_01c4, IL_01d3
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							object obj = zq8bhpZfN6Q6dt4nRF0(new CSharpCodeProvider(), streamWriter);
							CodeGeneratorOptions codeGeneratorOptions = new CodeGeneratorOptions();
							oGP5WBZhoZeR72Z6grd(codeGeneratorOptions, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A596A3));
							W2jCmrZCAdsGhqU34cQ(obj, code, streamWriter, codeGeneratorOptions);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									result = (byte[])a93vbJZGccsXtqPoTOI(memoryStream);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
									{
										num4 = 0;
									}
									break;
								default:
									return result;
								case 0:
									return result;
								}
							}
						}
						finally
						{
							if (streamWriter != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										LRqoE5ZEF1FBYOkOHWZ(streamWriter);
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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
				}
				finally
				{
					if (memoryStream != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								LRqoE5ZEF1FBYOkOHWZ(memoryStream);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			default:
				return result;
			}
		}
	}

	public static string GenerateCSCodeString(CodeExpression expression)
	{
		//Discarded unreachable code: IL_0059, IL_00ef, IL_0127, IL_0167, IL_0172, IL_0181, IL_01d7, IL_0217, IL_0222, IL_0231
		int num = 1;
		int num2 = num;
		string result = default(string);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				memoryStream = (MemoryStream)CQUk1IZWfB082RT57DH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter(memoryStream.AsNoClose(), (Encoding)SV01mDZoKMRW3dZsRkb());
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						return result;
					case 3:
						result = memoryStream.AsString((Encoding)SV01mDZoKMRW3dZsRkb());
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num3 = 2;
						}
						continue;
					default:
						try
						{
							object obj = zq8bhpZfN6Q6dt4nRF0(new CSharpCodeProvider(), streamWriter);
							CodeGeneratorOptions codeGeneratorOptions = new CodeGeneratorOptions();
							oGP5WBZhoZeR72Z6grd(codeGeneratorOptions, Jm855pZbDswibI4U2gQ(0x34A6D230 ^ 0x34A6917C));
							e5Zh2xZvXU8ED1YcT3W(obj, expression, streamWriter, codeGeneratorOptions);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
							if (streamWriter == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num5 = 0;
								}
								goto IL_012b;
							}
							goto IL_0141;
							IL_0141:
							LRqoE5ZEF1FBYOkOHWZ(streamWriter);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num5 = 0;
							}
							goto IL_012b;
							IL_012b:
							switch (num5)
							{
							default:
								goto end_IL_0106;
							case 2:
								break;
							case 0:
								goto end_IL_0106;
							case 1:
								goto end_IL_0106;
							}
							goto IL_0141;
							end_IL_0106:;
						}
						break;
					case 1:
						break;
					}
					m3dh8YZ8qkJk7Xk9Vs2(memoryStream, 0L, SeekOrigin.Begin);
					num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num3 = 2;
					}
				}
			}
			finally
			{
				int num6;
				if (memoryStream == null)
				{
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num6 = 0;
					}
					goto IL_01db;
				}
				goto IL_01f1;
				IL_01f1:
				((IDisposable)memoryStream).Dispose();
				num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num6 = 1;
				}
				goto IL_01db;
				IL_01db:
				switch (num6)
				{
				default:
					goto end_IL_01b6;
				case 2:
					break;
				case 0:
					goto end_IL_01b6;
				case 1:
					goto end_IL_01b6;
				}
				goto IL_01f1;
				end_IL_01b6:;
			}
		}
	}

	public static CodeNamespace GenerateCode(string processName, string scriptName, string processDisplayName, RootCodeItem rootItem)
	{
		//Discarded unreachable code: IL_0246, IL_0250, IL_0351, IL_0364, IL_0373, IL_0383, IL_0392, IL_03d3, IL_03e2, IL_0657
		int num = 8;
		CodeMemberMethod codeMemberMethod = default(CodeMemberMethod);
		CodeTypeDeclaration codeTypeDeclaration = default(CodeTypeDeclaration);
		int num3 = default(int);
		CodeStatement[] array = default(CodeStatement[]);
		CodeStatement value = default(CodeStatement);
		List<VariableCodeItemToolBoxItem>.Enumerator enumerator = default(List<VariableCodeItemToolBoxItem>.Enumerator);
		CodeExpression initExpression = default(CodeExpression);
		VariableCodeItemToolBoxItem current = default(VariableCodeItemToolBoxItem);
		CodeVariableDeclarationStatement codeVariableDeclarationStatement = default(CodeVariableDeclarationStatement);
		CodeNamespace codeNamespace = default(CodeNamespace);
		CodeCommentStatement codeCommentStatement = default(CodeCommentStatement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 27:
					UU5hvTZinnTEWZ0kcsi(LoSE0sZS6YKBrKpCPjp(codeMemberMethod), new CodeCommentStatement((string)k81MifZZ2SHvqMjGwc4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123615756), scriptName), docComment: true));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 5;
					}
					continue;
				case 28:
					UU5hvTZinnTEWZ0kcsi(LoSE0sZS6YKBrKpCPjp(codeTypeDeclaration), new CodeCommentStatement((string)Jm855pZbDswibI4U2gQ(0x3CE17B75 ^ 0x3CE138E1), docComment: true));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				case 29:
					Dgm5IdZTU6jHKpHc7TF(XwRdRwZXRmVlUBvbM3P(codeMemberMethod), new CodeSnippetStatement());
					num2 = 30;
					continue;
				case 3:
				case 16:
					if (num3 < array.Length)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 15;
				case 6:
					OAB3eTZqBsHL1eaLcoh(codeMemberMethod, new CodeTypeReference(typeof(void)));
					num2 = 12;
					continue;
				case 26:
					dfVrIlZVnFMyXFJT6C5(codeTypeDeclaration, true);
					num2 = 28;
					continue;
				case 7:
					codeTypeDeclaration = new CodeTypeDeclaration((string)k81MifZZ2SHvqMjGwc4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C537B75), processName));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 13;
					}
					continue;
				case 14:
					L7FmdnZIkgMewCIDQbB(codeTypeDeclaration, TypeAttributes.Public);
					num2 = 26;
					continue;
				case 31:
					codeMemberMethod.Statements.Add(value);
					num2 = 33;
					continue;
				case 25:
					codeMemberMethod = new CodeMemberMethod();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 9;
					}
					continue;
				case 33:
					num3++;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 16;
					}
					continue;
				case 19:
					try
					{
						while (true)
						{
							IL_02ac:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 2;
								goto IL_0254;
							}
							goto IL_0276;
							IL_0254:
							while (true)
							{
								switch (num4)
								{
								case 4:
									break;
								case 3:
									initExpression = (CodeExpression)VowLIVZkfxhOJw6gnE7(current);
									num4 = 5;
									continue;
								case 1:
									goto IL_02ac;
								default:
									Dgm5IdZTU6jHKpHc7TF(codeMemberMethod.Statements, codeVariableDeclarationStatement);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
									{
										num4 = 1;
									}
									continue;
								case 5:
									codeVariableDeclarationStatement = new CodeVariableDeclarationStatement((string)Jm855pZbDswibI4U2gQ(0x34185E55 ^ 0x34181A01), (string)ORnOYVZnNrJJDTL0IYc(current), initExpression);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num4 = 0;
									}
									continue;
								case 2:
									goto end_IL_02ac;
								}
								break;
							}
							goto IL_0276;
							IL_0276:
							current = enumerator.Current;
							num4 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num4 = 3;
							}
							goto IL_0254;
							continue;
							end_IL_02ac:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 29;
				case 8:
					codeNamespace = new CodeNamespace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978494048));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					return codeNamespace;
				case 32:
					codeCommentStatement = new CodeCommentStatement(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F303C9E)));
					num2 = 22;
					continue;
				case 24:
					UU5hvTZinnTEWZ0kcsi(codeMemberMethod.Comments, new CodeCommentStatement((string)Jm855pZbDswibI4U2gQ(-1979251663 ^ -1979234395), docComment: true));
					num = 27;
					break;
				case 4:
				case 17:
					enumerator = rootItem.LocalVariables.GetEnumerator();
					num = 19;
					break;
				case 23:
					Bm1s07ZP5UICFQwRDgc(codeNamespace.Types, codeTypeDeclaration);
					num2 = 11;
					continue;
				case 13:
					ze9aZsZuyX1hMnoZy97(codeTypeDeclaration, true);
					num2 = 14;
					continue;
				case 15:
					IV5ObCZetANEa9QBQOW(KSrmouZ2jk8HaS3LYIF(codeTypeDeclaration), codeMemberMethod);
					num = 23;
					break;
				default:
					UU5hvTZinnTEWZ0kcsi(codeTypeDeclaration.Comments, new CodeCommentStatement(SR.T((string)Jm855pZbDswibI4U2gQ(-345420348 ^ -345436562), processDisplayName), docComment: true));
					num2 = 20;
					continue;
				case 1:
					codeMemberMethod.Name = scriptName.ToTranslit();
					num2 = 6;
					continue;
				case 9:
					pLOsvUZRm83vD9wWda1(codeMemberMethod, MemberAttributes.Public);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					UU5hvTZinnTEWZ0kcsi(LoSE0sZS6YKBrKpCPjp(codeTypeDeclaration), new CodeCommentStatement((string)Jm855pZbDswibI4U2gQ(-675505729 ^ -675489197), docComment: true));
					num2 = 25;
					continue;
				case 2:
					Dgm5IdZTU6jHKpHc7TF(XwRdRwZXRmVlUBvbM3P(codeMemberMethod), codeCommentStatement);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
					UU5hvTZinnTEWZ0kcsi(LoSE0sZS6YKBrKpCPjp(codeMemberMethod), new CodeCommentStatement((string)Jm855pZbDswibI4U2gQ(-1870892489 ^ -1870908965), docComment: true));
					num2 = 32;
					continue;
				case 10:
				case 18:
					value = array[num3];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 31;
					}
					continue;
				case 12:
					((CodeParameterDeclarationExpressionCollection)thHrBYZKRkPiUZcAeAb(codeMemberMethod)).Add(new CodeParameterDeclarationExpression((string)Jm855pZbDswibI4U2gQ(0x637E299B ^ 0x637E6D9F), (string)Jm855pZbDswibI4U2gQ(0x1C9495B4 ^ 0x1C94D1A2)));
					num2 = 24;
					continue;
				case 30:
					array = (CodeStatement[])q0FWgCZO4F6eHGCC1Ho(rootItem);
					num = 21;
					break;
				case 22:
					if (!rootItem.LocalVariables.Any())
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				case 21:
					num3 = 0;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	public static CodeExpression GetInitExpressionByType(NewCodeItemToolBoxItem variable)
	{
		//Discarded unreachable code: IL_0075, IL_0121, IL_024b
		int num = 1;
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (thuHmdZaCnvBdmAVWNo(type, QU8swGZpqvZti8c4VKU(typeof(string).TypeHandle)))
					{
						num2 = 6;
						continue;
					}
					goto case 12;
				case 11:
					return new CodeSnippetExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521250562));
				case 3:
					return new CodeSnippetExpression((string)Jm855pZbDswibI4U2gQ(-477139494 ^ -477157000));
				case 9:
					if (DtxPw5ZwdxcfHQhbUe8(type))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 2:
				case 5:
					return new CodePrimitiveExpression(CRNDvCZ47bP79sA5OjT(type));
				case 6:
					return new CodeObjectCreateExpression(variable.VariableType);
				case 12:
					if (!PV8ZduZDk4n04ft5cPQ(type, QU8swGZpqvZti8c4VKU(typeof(string).TypeHandle)))
					{
						if (!bDH4rnZtAi8J7yIkJFt(type))
						{
							num2 = 9;
							continue;
						}
						goto case 2;
					}
					num = 3;
					break;
				case 1:
					type = USUMUvZ1cfILEEmdrR8(variable);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (!PV8ZduZDk4n04ft5cPQ(type, QU8swGZpqvZti8c4VKU(typeof(bool).TypeHandle)))
					{
						if (!PV8ZduZDk4n04ft5cPQ(type, QU8swGZpqvZti8c4VKU(typeof(DateTime).TypeHandle)))
						{
							return new CodeSnippetExpression(string.Format((string)Jm855pZbDswibI4U2gQ(0x1DE3DD89 ^ 0x1DE39957), type.Namespace, iDeM3XZ66bAQMbOGn4p(type)));
						}
						num = 11;
						break;
					}
					num2 = 5;
					continue;
				default:
					if (!Bp95ZIZNcPtwgptFZKA(type))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 4;
				case 4:
					return new CodeSnippetExpression((string)k81MifZZ2SHvqMjGwc4(Jm855pZbDswibI4U2gQ(-1633514411 ^ -1633499125), USUMUvZ1cfILEEmdrR8(variable)));
				case 10:
					if (!qCBkUuZ3ZwOp60UopZL(type))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	public static object GetDefaultValue(Type t)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Activator.CreateInstance(t);
			case 1:
				return null;
			case 2:
				if (!t.IsValueType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static bool IsEntity(Type type)
	{
		//Discarded unreachable code: IL_0078, IL_00aa, IL_00c1, IL_00d0
		int num = 2;
		int num2 = num;
		Type type2 = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				type2 = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				try
				{
					type2 = type.GetInterface((string)Jm855pZbDswibI4U2gQ(-2138958856 ^ -2138941692));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			}
			break;
		}
		return type2 != null;
	}

	public static bool IsCollection(Type type)
	{
		//Discarded unreachable code: IL_0065, IL_0097, IL_00ae, IL_00bd
		int num = 1;
		int num2 = num;
		Type type2 = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					type2 = type.GetInterface((string)Jm855pZbDswibI4U2gQ(0x53CB464B ^ 0x53CB0345));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 3:
				return type2 != null;
			case 1:
				if (PV8ZduZDk4n04ft5cPQ(type, QU8swGZpqvZti8c4VKU(typeof(string).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
				type2 = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return false;
			}
		}
	}

	public static string GenerateCodeString(string processName, string scriptName, string projectDisplayName, RootCodeItem rootItem)
	{
		int num = 3;
		int num2 = num;
		List<string> list = default(List<string>);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				list = text2.Split((char[])ncHTskZHXwPfYd0M2yM(Jm855pZbDswibI4U2gQ(-16752921 ^ -16760509))).ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				text2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107976774), list);
				num2 = 5;
				break;
			case 5:
				text = (string)k81MifZZ2SHvqMjGwc4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630B649), xi5U8KZ7Pb3pd0NAOa2(processName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6E12AD), ""));
				num2 = 4;
				break;
			case 6:
				list.RemoveAt(2);
				num2 = 7;
				break;
			case 3:
				text2 = GenerateCSCodeString(GenerateCode(processName, scriptName, projectDisplayName, rootItem));
				num2 = 2;
				break;
			case 7:
				rPvUMGZAfdIjlPfvQDj(list, 7);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return (string)YUxfl7ZxPI5dkZBmI7Z(Jm855pZbDswibI4U2gQ(-97972138 ^ -97953556), text, text2);
			default:
				rPvUMGZAfdIjlPfvQDj(list, 2);
				num2 = 6;
				break;
			}
		}
	}

	public static string GenerateMethodCodeString(string processName, string scriptName, RootCodeItem rootItem)
	{
		//Discarded unreachable code: IL_013f, IL_0149, IL_027a, IL_028d, IL_02b6
		int num = 3;
		int num5 = default(int);
		CodeStatement[] array = default(CodeStatement[]);
		string text = default(string);
		List<VariableCodeItemToolBoxItem>.Enumerator enumerator = default(List<VariableCodeItemToolBoxItem>.Enumerator);
		CodeStatement codeStatement = default(CodeStatement);
		VariableCodeItemToolBoxItem current = default(VariableCodeItemToolBoxItem);
		CodeExpression initExpression = default(CodeExpression);
		CodeVariableDeclarationStatement codeVariableDeclarationStatement = default(CodeVariableDeclarationStatement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 9:
					if (num5 >= array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 10:
					num5++;
					num2 = 9;
					continue;
				case 4:
					text = (string)KWH7CCZmt9rjDadj2kf(text, Jm855pZbDswibI4U2gQ(0x3A5D5EF ^ 0x3A5CA4B));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					enumerator = rootItem.LocalVariables.GetEnumerator();
					num2 = 5;
					continue;
				case 3:
					text = string.Empty;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					return text;
				case 8:
					break;
				case 11:
					codeStatement = array[num5];
					num2 = 6;
					continue;
				case 7:
					num5 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num3 = 0;
								}
								goto IL_014d;
							}
							goto IL_022b;
							IL_022b:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num3 = 0;
							}
							goto IL_014d;
							IL_014d:
							while (true)
							{
								switch (num3)
								{
								default:
									initExpression = (CodeExpression)VowLIVZkfxhOJw6gnE7(current);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
									{
										num3 = 2;
									}
									continue;
								case 2:
									codeVariableDeclarationStatement = new CodeVariableDeclarationStatement(USUMUvZ1cfILEEmdrR8(current), (string)ORnOYVZnNrJJDTL0IYc(current), initExpression);
									num3 = 3;
									continue;
								case 4:
									break;
								case 3:
									text = (string)KWH7CCZmt9rjDadj2kf(text, SfMVJIZ0xlHYIr8jU5R(codeVariableDeclarationStatement));
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num3 = 1;
									}
									continue;
								case 6:
									text = (string)KWH7CCZmt9rjDadj2kf(text, Jm855pZbDswibI4U2gQ(-812025778 ^ -812029974));
									num3 = 4;
									continue;
								case 5:
									goto IL_022b;
								case 1:
									goto end_IL_01b7;
								}
								break;
							}
							continue;
							end_IL_01b7:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				case 6:
					text = (string)KWH7CCZmt9rjDadj2kf(text, SfMVJIZ0xlHYIr8jU5R(codeStatement));
					num2 = 4;
					continue;
				}
				break;
			}
			array = (CodeStatement[])q0FWgCZO4F6eHGCC1Ho(rootItem);
			num = 7;
		}
	}

	public static CodeStatement[] TranslateToCode(RootCodeItem rootCodeItem)
	{
		//Discarded unreachable code: IL_0058, IL_0074, IL_01c0, IL_01d3, IL_01e2, IL_020e, IL_025b, IL_026a
		int num = 2;
		int num2 = num;
		List<CodeStatement> list = default(List<CodeStatement>);
		CodeStatement codeStatement = default(CodeStatement);
		CodeStatement[] array = default(CodeStatement[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return list.ToArray();
			case 1:
				try
				{
					List<CodeItem>.Enumerator enumerator = rootCodeItem.Items.GetEnumerator();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							while (true)
							{
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num4 = 2;
									}
									goto IL_0082;
								}
								goto IL_0116;
								IL_0116:
								CodeItem current = enumerator.Current;
								codeStatement = (CodeStatement)Cqy5nVZy4Mub8H7gDRo(current);
								array = current.ToCodeStatementList();
								int num5 = 5;
								num4 = num5;
								goto IL_0082;
								IL_0082:
								while (true)
								{
									switch (num4)
									{
									case 1:
										list.AddRange(array);
										num4 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
										{
											num4 = 6;
										}
										continue;
									case 6:
										break;
									case 5:
										if (codeStatement != null)
										{
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
											{
												num4 = 3;
											}
											continue;
										}
										goto default;
									case 7:
										goto IL_0116;
									default:
										if (array != null)
										{
											num4 = 4;
											continue;
										}
										break;
									case 4:
										if (array.Any())
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										break;
									case 3:
										list.Add(codeStatement);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
										{
											num4 = 0;
										}
										continue;
									case 2:
										goto end_IL_00cf;
									}
									break;
								}
								continue;
								end_IL_00cf:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
						break;
					case 1:
						break;
					}
				}
				catch (Exception ex)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					default:
						throw new Exception(SR.T((string)Jm855pZbDswibI4U2gQ(0x12A5FAC7 ^ 0x12A5B20B), GlvHgPZMnFO7hmNbu5V(ex), nlqmBmZJYWXDsXogWRq(ex)));
					}
				}
				goto default;
			case 2:
				list = new List<CodeStatement>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void InitializeAlfabet()
	{
		//Discarded unreachable code: IL_00bf, IL_00d2, IL_00e1, IL_013a
		int num = 10;
		int num3 = default(int);
		string item = default(string);
		char c = default(char);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				case 8:
					num3++;
					num2 = 5;
					continue;
				case 2:
					if (ExceptionsWordList.Contains(item))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 3:
				case 4:
					c = (char)num3;
					num2 = 7;
					continue;
				case 6:
					AlfabetList.Add(item);
					num2 = 8;
					continue;
				case 10:
					num3 = 65;
					num = 9;
					break;
				case 0:
					return;
				case 7:
					item = (string)dj11UoZd3t1oDCKJpbT(LHR3IQZ9IsEOolGoGqj(KWH7CCZmt9rjDadj2kf(c.ToString(), Jm855pZbDswibI4U2gQ(0x76DD48E ^ 0x76D9DAC))));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				case 9:
					if (num3 > 90)
					{
						return;
					}
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public static string GetRandomName()
	{
		//Discarded unreachable code: IL_006e, IL_00b4, IL_00c3
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (rsvGYlZlNnZXnbVFGtm(AlfabetList) != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 8:
				rPvUMGZAfdIjlPfvQDj(AlfabetList, 0);
				num2 = 5;
				break;
			case 7:
				yZpSb4ZBEPaZ4LDtqZj();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
			case 6:
				return text;
			case 4:
				text = AlfabetList[0];
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (ExceptionsWordList.Contains(text))
				{
					num2 = 6;
					break;
				}
				goto case 8;
			default:
				AlfabetList.RemoveAll((string a) => ExceptionsWordList.Contains(a));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public static void AddString(string word)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 1:
				return;
			default:
				AlfabetList.Add(word);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (AlfabetList.Contains(word))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 3:
				if (AlfabetList == null)
				{
					return;
				}
				num2 = 2;
				break;
			}
		}
	}

	internal static void F0dj9OZFj7Tpal4poof()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void yZpSb4ZBEPaZ4LDtqZj()
	{
		InitializeAlfabet();
	}

	internal static bool nJXTs38c5r1LHRXAYrE()
	{
		return o5RB0i8sbowdSWYPlsZ == null;
	}

	internal static CodeItemCodeGenerator tbOshl8zeHft1bm21cH()
	{
		return o5RB0i8sbowdSWYPlsZ;
	}

	internal static object CQUk1IZWfB082RT57DH()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object SV01mDZoKMRW3dZsRkb()
	{
		return Encoding.UTF8;
	}

	internal static object Jm855pZbDswibI4U2gQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void oGP5WBZhoZeR72Z6grd(object P_0, object P_1)
	{
		((CodeGeneratorOptions)P_0).BracingStyle = (string)P_1;
	}

	internal static object a93vbJZGccsXtqPoTOI(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void LRqoE5ZEF1FBYOkOHWZ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object zq8bhpZfN6Q6dt4nRF0(object P_0, object P_1)
	{
		return ((CodeDomProvider)P_0).CreateGenerator((TextWriter)P_1);
	}

	internal static void BK8PlvZQnVpF4pM6rZ5(object P_0, object P_1, object P_2, object P_3)
	{
		((ICodeGenerator)P_0).GenerateCodeFromNamespace((CodeNamespace)P_1, (TextWriter)P_2, (CodeGeneratorOptions)P_3);
	}

	internal static void W2jCmrZCAdsGhqU34cQ(object P_0, object P_1, object P_2, object P_3)
	{
		((ICodeGenerator)P_0).GenerateCodeFromStatement((CodeStatement)P_1, (TextWriter)P_2, (CodeGeneratorOptions)P_3);
	}

	internal static void e5Zh2xZvXU8ED1YcT3W(object P_0, object P_1, object P_2, object P_3)
	{
		((ICodeGenerator)P_0).GenerateCodeFromExpression((CodeExpression)P_1, (TextWriter)P_2, (CodeGeneratorOptions)P_3);
	}

	internal static long m3dh8YZ8qkJk7Xk9Vs2(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object k81MifZZ2SHvqMjGwc4(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void ze9aZsZuyX1hMnoZy97(object P_0, bool P_1)
	{
		((CodeTypeDeclaration)P_0).IsClass = P_1;
	}

	internal static void L7FmdnZIkgMewCIDQbB(object P_0, TypeAttributes P_1)
	{
		((CodeTypeDeclaration)P_0).TypeAttributes = P_1;
	}

	internal static void dfVrIlZVnFMyXFJT6C5(object P_0, bool P_1)
	{
		((CodeTypeDeclaration)P_0).IsPartial = P_1;
	}

	internal static object LoSE0sZS6YKBrKpCPjp(object P_0)
	{
		return ((CodeTypeMember)P_0).Comments;
	}

	internal static int UU5hvTZinnTEWZ0kcsi(object P_0, object P_1)
	{
		return ((CodeCommentStatementCollection)P_0).Add((CodeCommentStatement)P_1);
	}

	internal static void pLOsvUZRm83vD9wWda1(object P_0, MemberAttributes P_1)
	{
		((CodeTypeMember)P_0).Attributes = P_1;
	}

	internal static void OAB3eTZqBsHL1eaLcoh(object P_0, object P_1)
	{
		((CodeMemberMethod)P_0).ReturnType = (CodeTypeReference)P_1;
	}

	internal static object thHrBYZKRkPiUZcAeAb(object P_0)
	{
		return ((CodeMemberMethod)P_0).Parameters;
	}

	internal static object XwRdRwZXRmVlUBvbM3P(object P_0)
	{
		return ((CodeMemberMethod)P_0).Statements;
	}

	internal static int Dgm5IdZTU6jHKpHc7TF(object P_0, object P_1)
	{
		return ((CodeStatementCollection)P_0).Add((CodeStatement)P_1);
	}

	internal static object VowLIVZkfxhOJw6gnE7(object P_0)
	{
		return GetInitExpressionByType((NewCodeItemToolBoxItem)P_0);
	}

	internal static object ORnOYVZnNrJJDTL0IYc(object P_0)
	{
		return ((NewCodeItemToolBoxItem)P_0).VariableName;
	}

	internal static object q0FWgCZO4F6eHGCC1Ho(object P_0)
	{
		return TranslateToCode((RootCodeItem)P_0);
	}

	internal static object KSrmouZ2jk8HaS3LYIF(object P_0)
	{
		return ((CodeTypeDeclaration)P_0).Members;
	}

	internal static int IV5ObCZetANEa9QBQOW(object P_0, object P_1)
	{
		return ((CodeTypeMemberCollection)P_0).Add((CodeTypeMember)P_1);
	}

	internal static int Bm1s07ZP5UICFQwRDgc(object P_0, object P_1)
	{
		return ((CodeTypeDeclarationCollection)P_0).Add((CodeTypeDeclaration)P_1);
	}

	internal static Type USUMUvZ1cfILEEmdrR8(object P_0)
	{
		return ((NewCodeItemToolBoxItem)P_0).VariableType;
	}

	internal static bool Bp95ZIZNcPtwgptFZKA(Type type)
	{
		return IsEntity(type);
	}

	internal static bool qCBkUuZ3ZwOp60UopZL(Type type)
	{
		return IsCollection(type);
	}

	internal static Type QU8swGZpqvZti8c4VKU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool thuHmdZaCnvBdmAVWNo(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool PV8ZduZDk4n04ft5cPQ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool bDH4rnZtAi8J7yIkJFt(Type type)
	{
		return type.IsNullableType();
	}

	internal static bool DtxPw5ZwdxcfHQhbUe8(Type type)
	{
		return type.IsNumericType();
	}

	internal static object CRNDvCZ47bP79sA5OjT(Type t)
	{
		return GetDefaultValue(t);
	}

	internal static object iDeM3XZ66bAQMbOGn4p(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object ncHTskZHXwPfYd0M2yM(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static void rPvUMGZAfdIjlPfvQDj(object P_0, int P_1)
	{
		((List<string>)P_0).RemoveAt(P_1);
	}

	internal static object xi5U8KZ7Pb3pd0NAOa2(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object YUxfl7ZxPI5dkZBmI7Z(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object SfMVJIZ0xlHYIr8jU5R(object P_0)
	{
		return GenerateCSCodeStringFromStatement((CodeStatement)P_0);
	}

	internal static object KWH7CCZmt9rjDadj2kf(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Cqy5nVZy4Mub8H7gDRo(object P_0)
	{
		return ((CodeItem)P_0).ToCodeStatement();
	}

	internal static object GlvHgPZMnFO7hmNbu5V(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object nlqmBmZJYWXDsXogWRq(object P_0)
	{
		return ((Exception)P_0).StackTrace;
	}

	internal static object LHR3IQZ9IsEOolGoGqj(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object dj11UoZd3t1oDCKJpbT(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static int rsvGYlZlNnZXnbVFGtm(object P_0)
	{
		return ((List<string>)P_0).Count;
	}
}
