using System;
using System.IO;
using AutoMapper;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files.DTO.AutoMaps;

public class BinaryFileMap : BidirectionalMap<BinaryFile, BinaryFileDTO>
{
	internal static BinaryFileMap w3aRYoGnN5hK8j63fyHL;

	protected override void InitMap(IMappingExpression<BinaryFile, BinaryFileDTO> map)
	{
		base.InitMap(map);
		map.AfterMap((Action<BinaryFile, BinaryFileDTO>)delegate(BinaryFile f, BinaryFileDTO dto)
		{
			//Discarded unreachable code: IL_0080, IL_008f, IL_00c2, IL_00fa, IL_013a, IL_0145
			int num = 3;
			Stream content = default(Stream);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						content = f.GetContent(GetContentOptions.NonSeekable);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						if (_003C_003Ec.yqiAFUvzvluAsGxQgxZT(_003C_003Ec.tbkUhmvzCZMOhwDG5brO(f), Guid.Empty))
						{
							return;
						}
						break;
					case 1:
						try
						{
							dto.Content = (byte[])_003C_003Ec.RZ8E9qvz8b7gWM8rGma1(content);
							int num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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
							int num4;
							if (content == null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num4 = 0;
								}
								goto IL_00fe;
							}
							goto IL_0114;
							IL_0114:
							_003C_003Ec.lvaCkavzZ8LoZmEQJXMS(content);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
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
					case 4:
						return;
					}
					break;
				}
				num = 2;
			}
		});
	}

	protected override void InitReverseMap(IMappingExpression<BinaryFileDTO, BinaryFile> map)
	{
		base.InitReverseMap(map);
		map.ConstructUsing((Func<BinaryFileDTO, BinaryFile>)delegate(BinaryFileDTO dto)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!_003C_003Ec.GjcK5ovzIOwIsj0aZXHE(_003C_003Ec.UYtZptvzuUks7mXI6jbN(dto)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return ((BinaryFileBuilder)_003C_003Ec.jwcUOsvzSlKLFBy9rywG(BinaryFile.CreateNew(), _003C_003Ec.RkJXp1vzV5xEegInQZQX(dto))).Build();
				case 1:
					return (BinaryFile)_003C_003Ec.sseWHgvzibB2v3gdkxLV(Locator.GetServiceNotNull<IFileManager>(), _003C_003Ec.UYtZptvzuUks7mXI6jbN(dto));
				}
			}
		});
	}

	public BinaryFileMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		T4wB3QGna8Y7iTTgpeIZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void T4wB3QGna8Y7iTTgpeIZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sdIYn2Gn3ojrwLKk2cwK()
	{
		return w3aRYoGnN5hK8j63fyHL == null;
	}

	internal static BinaryFileMap M6v5quGnpRQ7YcTpCxnr()
	{
		return w3aRYoGnN5hK8j63fyHL;
	}
}
