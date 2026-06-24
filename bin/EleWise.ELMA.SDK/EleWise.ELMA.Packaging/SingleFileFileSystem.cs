using System;
using System.Collections.Generic;
using System.IO;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

internal class SingleFileFileSystem : IFileSystem, IDisposable
{
	private readonly string fileName;

	private byte[] buffer;

	internal static SingleFileFileSystem ddGhiNBnWqS0RMT9NHhm;

	public ILogger Logger
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public string Root
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public SingleFileFileSystem(string fileName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		znCVvOBnhQVAnsomRgOm();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.fileName = fileName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AddFile(string path, Stream stream)
	{
		throw new NotImplementedException();
	}

	public void AddFile(string path, Action<Stream> writeToStream)
	{
		if (path != fileName)
		{
			throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B379B8F), fileName, path));
		}
		MemoryStream memoryStream = new MemoryStream();
		writeToStream(memoryStream);
		buffer = memoryStream.ToArray();
	}

	public void AddFiles(IEnumerable<IPackageFile> files, string rootDir)
	{
		throw new NotImplementedException();
	}

	public Stream CreateFile(string path)
	{
		throw new NotImplementedException();
	}

	public void DeleteDirectory(string path, bool recursive)
	{
		throw new NotImplementedException();
	}

	public void DeleteFile(string path)
	{
		throw new NotImplementedException();
	}

	public void DeleteFiles(IEnumerable<IPackageFile> files, string rootDir)
	{
		throw new NotImplementedException();
	}

	public bool DirectoryExists(string path)
	{
		throw new NotImplementedException();
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_008c, IL_00c2, IL_00fa, IL_0153, IL_0172, IL_019e, IL_01ad, IL_01fa, IL_020d, IL_021c
		switch (1)
		{
		case 1:
			try
			{
				if (buffer == null)
				{
					break;
				}
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num = 1;
				}
				MemoryStream memoryStream = default(MemoryStream);
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 2:
						try
						{
							FileStream fileStream = (FileStream)aXBHg6BnGfx0kvTCw4EB(fileName);
							int num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							}
							try
							{
								FVcAWhBnEUMXTxvYlhw7(memoryStream, fileStream);
								int num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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
								if (fileStream != null)
								{
									int num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
									{
										num4 = 1;
									}
									while (true)
									{
										switch (num4)
										{
										case 1:
											sIOVjWBnfjpL5QxjBC7r(fileStream);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
											{
												num4 = 0;
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
						finally
						{
							int num5;
							if (memoryStream == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num5 = 1;
								}
								goto IL_0157;
							}
							goto IL_017c;
							IL_017c:
							((IDisposable)memoryStream).Dispose();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num5 = 0;
							}
							goto IL_0157;
							IL_0157:
							switch (num5)
							{
							default:
								goto end_IL_0132;
							case 1:
								goto end_IL_0132;
							case 2:
								break;
							case 0:
								goto end_IL_0132;
							}
							goto IL_017c;
							end_IL_0132:;
						}
					case 1:
						break;
					case 0:
						return;
					}
					memoryStream = new MemoryStream(buffer, writable: false);
					int num6 = 2;
					num = num6;
				}
			}
			finally
			{
				buffer = null;
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		case 0:
			break;
		}
	}

	public bool FileExists(string path)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (buffer != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return lXhbt8BnQjgv7v8BevlJ(path);
			default:
				return true;
			}
		}
	}

	public DateTimeOffset GetCreated(string path)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<string> GetDirectories(string path)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<string> GetFiles(string path, string filter, bool recursive)
	{
		throw new NotImplementedException();
	}

	public string GetFullPath(string path)
	{
		throw new NotImplementedException();
	}

	public DateTimeOffset GetLastAccessed(string path)
	{
		throw new NotImplementedException();
	}

	public DateTimeOffset GetLastModified(string path)
	{
		throw new NotImplementedException();
	}

	public void MakeFileWritable(string path)
	{
		throw new NotImplementedException();
	}

	public void MoveFile(string source, string destination)
	{
		throw new NotImplementedException();
	}

	public Stream OpenFile(string path)
	{
		//Discarded unreachable code: IL_0085, IL_00c3, IL_00fb, IL_013b, IL_014a, IL_0156, IL_0165, IL_01ad, IL_01cc, IL_01db, IL_01f8, IL_0207, IL_0217
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (buffer != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return new MemoryStream(buffer, writable: false);
			case 4:
				try
				{
					FileStream fileStream = (FileStream)hseZ2iBnCaWfe6yJQUHs(path);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							try
							{
								fileStream.CopyTo(memoryStream);
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
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
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
									{
										num5 = 0;
									}
									goto IL_00ff;
								}
								goto IL_0115;
								IL_0115:
								((IDisposable)fileStream).Dispose();
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
								{
									num5 = 2;
								}
								goto IL_00ff;
								IL_00ff:
								switch (num5)
								{
								case 1:
									goto end_IL_00da;
								case 2:
									goto end_IL_00da;
								}
								goto IL_0115;
								end_IL_00da:;
							}
							break;
						case 1:
							break;
						case 2:
							goto end_IL_0089;
						}
						buffer = (byte[])EdaE2tBnvehjnsXwx567(memoryStream);
						num3 = 2;
						continue;
						end_IL_0089:
						break;
					}
				}
				finally
				{
					int num6;
					if (memoryStream == null)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num6 = 1;
						}
						goto IL_01b1;
					}
					goto IL_01e6;
					IL_01e6:
					sIOVjWBnfjpL5QxjBC7r(memoryStream);
					num6 = 2;
					goto IL_01b1;
					IL_01b1:
					switch (num6)
					{
					case 1:
						goto end_IL_018c;
					case 2:
						goto end_IL_018c;
					}
					goto IL_01e6;
					end_IL_018c:;
				}
				goto default;
			case 3:
				break;
			}
			memoryStream = new MemoryStream();
			num2 = 4;
		}
	}

	internal static void znCVvOBnhQVAnsomRgOm()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool aGOY3tBnohroUJOrS4Eh()
	{
		return ddGhiNBnWqS0RMT9NHhm == null;
	}

	internal static SingleFileFileSystem NuNomxBnbDGbUl4LGxhM()
	{
		return ddGhiNBnWqS0RMT9NHhm;
	}

	internal static object aXBHg6BnGfx0kvTCw4EB(object P_0)
	{
		return File.OpenWrite((string)P_0);
	}

	internal static void FVcAWhBnEUMXTxvYlhw7(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void sIOVjWBnfjpL5QxjBC7r(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool lXhbt8BnQjgv7v8BevlJ(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object hseZ2iBnCaWfe6yJQUHs(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static object EdaE2tBnvehjnsXwx567(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}
}
