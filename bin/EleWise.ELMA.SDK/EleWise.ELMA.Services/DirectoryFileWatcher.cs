using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

public abstract class DirectoryFileWatcher
{
	private string watchRoot;

	private FileSystemWatcher filesWatcher;

	private FileSystemWatcher directoriesWatcher;

	private bool needJointWatchPath;

	private string jointWatchPath;

	private readonly ConcurrentHashSet<string> watchPaths;

	private readonly ConcurrentHashSet<string> specificWatchPaths;

	private readonly ConcurrentDictionary<string, bool> existsWatchPaths;

	private readonly ConcurrentDictionary<string, ConcurrentHashSet<string>> existsFiles;

	public EventHandler<FileWatcherEventArgs> FileChanged;

	public EventHandler<FileWatcherEventArgs> FileAdded;

	public EventHandler<FileWatcherEventArgs> FileDeleted;

	public EventHandler<FileWatcherEventArgs> ExistsFilesAdded;

	public EventHandler<FileWatcherEventArgs> ExistsFilesDeleted;

	private static DirectoryFileWatcher w76uHNBH46nqSpgbY7g3;

	public string WatchRoot => watchRoot;

	protected DirectoryFileWatcher()
	{
		//Discarded unreachable code: IL_0080, IL_0085
		SingletonReader.JJCZtPuTvSt();
		needJointWatchPath = true;
		watchPaths = new ConcurrentHashSet<string>();
		specificWatchPaths = new ConcurrentHashSet<string>();
		existsWatchPaths = new ConcurrentDictionary<string, bool>((IEqualityComparer<string>)d0qmXwBHAdPh87ExleVQ());
		existsFiles = new ConcurrentDictionary<string, ConcurrentHashSet<string>>((IEqualityComparer<string>)d0qmXwBHAdPh87ExleVQ());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected DirectoryFileWatcher(string watchRoot)
	{
		//Discarded unreachable code: IL_0080, IL_0085
		SingletonReader.JJCZtPuTvSt();
		needJointWatchPath = true;
		watchPaths = new ConcurrentHashSet<string>();
		specificWatchPaths = new ConcurrentHashSet<string>();
		existsWatchPaths = new ConcurrentDictionary<string, bool>((IEqualityComparer<string>)d0qmXwBHAdPh87ExleVQ());
		existsFiles = new ConcurrentDictionary<string, ConcurrentHashSet<string>>((IEqualityComparer<string>)d0qmXwBHAdPh87ExleVQ());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
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
			InitWatcher(watchRoot);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
			{
				num = 1;
			}
		}
	}

	protected void InitWatcher([NotNull] string watchRoot)
	{
		//Discarded unreachable code: IL_01d5
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					kA9hx6BHMlnyaooqrPl2(filesWatcher, new FileSystemEventHandler(PathWatcher));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 5;
					}
					continue;
				default:
					CmawHpBH9YIj64XEuGWC(filesWatcher, new RenamedEventHandler(PathWatcher));
					num2 = 11;
					continue;
				case 7:
					return;
				case 3:
					ONByoeBHlvQMc1V6mmS8(directoriesWatcher, new FileSystemEventHandler(PathWatcher));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 8;
					}
					continue;
				case 1:
					return;
				case 2:
					if (watchRoot != null)
					{
						if (pp2vJGBHxiq1Y5EBmcLh(watchRoot, pgl7mGBH7UWGI04WDq3E(--1333735954 ^ 0x4F7F2D64)))
						{
							num2 = 9;
							continue;
						}
						goto case 4;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					filesWatcher.Deleted += PathWatcher;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					OOQkZSBHJPuvGe6mMyVt(directoriesWatcher, new FileSystemEventHandler(PathWatcher));
					num = 3;
					break;
				case 9:
				case 10:
					this.watchRoot = watchRoot;
					num2 = 8;
					continue;
				case 14:
					CmawHpBH9YIj64XEuGWC(directoriesWatcher, new RenamedEventHandler(PathWatcher));
					num2 = 7;
					continue;
				case 6:
					OOQkZSBHJPuvGe6mMyVt(filesWatcher, new FileSystemEventHandler(PathWatcher));
					num = 5;
					break;
				case 4:
					watchRoot = (string)girTMKBH0uMVVyDW2V7c(watchRoot, pgl7mGBH7UWGI04WDq3E(0x48A7E34A ^ 0x48A7FC3C));
					num2 = 10;
					continue;
				case 8:
				{
					FileSystemWatcher obj = new FileSystemWatcher(watchRoot)
					{
						IncludeSubdirectories = true
					};
					AUGOrDBHmQxo7r0Tce4l(obj, watchPaths.Any() || specificWatchPaths.Any());
					wR2mFhBHyMEjQXV4skQK(obj, NotifyFilters.FileName | NotifyFilters.LastWrite);
					filesWatcher = obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				case 11:
				{
					FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(watchRoot);
					aZRj2jBHds7iSZOgdK4U(fileSystemWatcher, true);
					AUGOrDBHmQxo7r0Tce4l(fileSystemWatcher, watchPaths.Any() || specificWatchPaths.Any());
					wR2mFhBHyMEjQXV4skQK(fileSystemWatcher, NotifyFilters.DirectoryName);
					directoriesWatcher = fileSystemWatcher;
					num2 = 13;
					continue;
				}
				}
				break;
			}
		}
	}

	protected void StopWatchingFiles(bool watching = true)
	{
		int num = 2;
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
					break;
				case 2:
					if (watching)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					AUGOrDBHmQxo7r0Tce4l(filesWatcher, true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 0:
					return;
				}
				break;
			}
			AUGOrDBHmQxo7r0Tce4l(filesWatcher, false);
			num = 3;
		}
	}

	public void AddWatchPaths(params string[] paths)
	{
		//Discarded unreachable code: IL_010b, IL_020a, IL_029c, IL_02ab, IL_02bb, IL_036a, IL_0379, IL_0402, IL_04c9, IL_04d8, IL_04fc, IL_050b, IL_0540, IL_054f, IL_055e, IL_0591, IL_05a0, IL_05b0
		int num = 39;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		string text2 = default(string);
		int num3 = default(int);
		int num4 = default(int);
		_003C_003Ec__DisplayClass20_1 _003C_003Ec__DisplayClass20_2 = default(_003C_003Ec__DisplayClass20_1);
		string text = default(string);
		string[] array = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 45:
					_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 20;
					}
					continue;
				case 12:
					if (text2 == null)
					{
						num2 = 14;
						continue;
					}
					goto case 15;
				case 3:
					if (!_003C_003Ec__DisplayClass20_.addPath.StartsWith(watchRoot, StringComparison.InvariantCultureIgnoreCase))
					{
						num2 = 17;
						continue;
					}
					goto case 21;
				case 41:
					num3 = 0;
					num2 = 43;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 16;
					}
					continue;
				case 30:
					if (lrkayKBHgleQTRMSTeOJ(d0qmXwBHAdPh87ExleVQ(), pr3nKRBHrQve9Cnhlt6m(_003C_003Ec__DisplayClass20_.addPath, num4), pr3nKRBHrQve9Cnhlt6m(jointWatchPath, num4)))
					{
						num2 = 5;
						continue;
					}
					goto case 10;
				case 44:
					return;
				case 10:
					jointWatchPath = (string)jJonhbBH5nInkTuURLLi(jointWatchPath, num4);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 11;
					}
					continue;
				case 42:
					_003C_003Ec__DisplayClass20_2 = new _003C_003Ec__DisplayClass20_1();
					num2 = 36;
					continue;
				case 1:
				case 5:
					num4++;
					num2 = 28;
					continue;
				case 7:
				case 40:
					text2 = watchPaths.FirstOrDefault(_003C_003Ec__DisplayClass20_._003CAddWatchPaths_003Eb__0);
					num2 = 12;
					continue;
				case 21:
					watchPaths.Add(_003C_003Ec__DisplayClass20_.addPath);
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 22;
					}
					continue;
				case 13:
					jointWatchPath = _003C_003Ec__DisplayClass20_.addPath;
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 32;
					}
					continue;
				case 29:
					existsFiles.GetOrAdd(_003C_003Ec__DisplayClass20_2.CS_0024_003C_003E8__locals1.addPath, _003C_003Ec__DisplayClass20_2._003CAddWatchPaths_003Eb__1);
					num2 = 19;
					continue;
				case 34:
					AUGOrDBHmQxo7r0Tce4l(directoriesWatcher, true);
					num2 = 27;
					continue;
				case 31:
					if (ExistsFilesAdded == null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 4;
				case 39:
					if (watchRoot != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 38;
						}
						continue;
					}
					return;
				case 9:
					_003C_003Ec__DisplayClass20_2.added = false;
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 13;
					}
					continue;
				case 8:
				case 14:
				case 16:
				case 22:
				case 23:
					if (!filesWatcher.EnableRaisingEvents)
					{
						num2 = 24;
						continue;
					}
					goto case 17;
				case 24:
					AUGOrDBHmQxo7r0Tce4l(filesWatcher, true);
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 34;
					}
					continue;
				case 19:
					if (!_003C_003Ec__DisplayClass20_2.added)
					{
						num2 = 16;
						continue;
					}
					goto case 31;
				case 28:
				case 37:
					if (num4 >= GsD5k7BHYNQluQM9QZd0(TeMw8iBHjMZNsgchw82i(_003C_003Ec__DisplayClass20_.addPath), TeMw8iBHjMZNsgchw82i(jointWatchPath)))
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 30;
				case 25:
					if (!needJointWatchPath)
					{
						num2 = 40;
						continue;
					}
					goto case 2;
				case 17:
				case 27:
					num3++;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					ExistsFilesAdded(this, new FileWatcherEventArgs(_003C_003Ec__DisplayClass20_2.CS_0024_003C_003E8__locals1.addPath, null, FileWatcherChangeTypes.ExistsFilesAdded));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 7;
					}
					continue;
				case 36:
					_003C_003Ec__DisplayClass20_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass20_;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 9;
					}
					continue;
				default:
					text = array[num3];
					num2 = 45;
					continue;
				case 6:
					return;
				case 38:
					break;
				case 18:
				case 43:
					if (num3 >= array.Length)
					{
						num2 = 44;
						continue;
					}
					goto default;
				case 2:
					if (jointWatchPath != null)
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 13;
				case 15:
					if (!existsFiles.TryGetValue(text2, out _003C_003Ec__DisplayClass20_.files))
					{
						num2 = 22;
						continue;
					}
					goto case 42;
				case 11:
				case 32:
				case 33:
					needJointWatchPath &= d9d6D5BHLIZ9H1WVUyAl(jointWatchPath, watchRoot);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 7;
					}
					continue;
				case 20:
				case 26:
					num4 = 0;
					num2 = 37;
					continue;
				case 35:
					_003C_003Ec__DisplayClass20_.addPath = (string)(pp2vJGBHxiq1Y5EBmcLh(text, pgl7mGBH7UWGI04WDq3E(0x5DD55050 ^ 0x5DD54F26)) ? text : girTMKBH0uMVVyDW2V7c(text, pgl7mGBH7UWGI04WDq3E(-2106517564 ^ -2106521422)));
					num2 = 3;
					continue;
				}
				break;
			}
			array = paths;
			num = 41;
		}
	}

	public void AddSpecificWatchPaths(params string[] paths)
	{
		//Discarded unreachable code: IL_0128, IL_0137, IL_01a4, IL_01ae, IL_023a, IL_0249, IL_0258, IL_02b6, IL_02c5, IL_02f5, IL_0304, IL_03bb, IL_03ca, IL_03ea, IL_03f9, IL_0409, IL_0468, IL_0477
		int num = 9;
		int num2 = num;
		int num4 = default(int);
		string text2 = default(string);
		string text = default(string);
		int num3 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 30:
				jointWatchPath = (string)jJonhbBH5nInkTuURLLi(jointWatchPath, num4);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 3;
				}
				continue;
			case 28:
				if (oxwsB1BHURjtdVX4j2jI(filesWatcher))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 7;
			case 5:
			case 32:
				if (num4 < GsD5k7BHYNQluQM9QZd0(text2.Length, jointWatchPath.Length))
				{
					num2 = 22;
					continue;
				}
				goto case 1;
			case 21:
				jointWatchPath = text2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				filesWatcher.EnableRaisingEvents = true;
				num2 = 26;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 13;
				}
				continue;
			case 4:
				obj = girTMKBH0uMVVyDW2V7c(text, Path.DirectorySeparatorChar.ToString());
				break;
			case 16:
				num4 = 0;
				num2 = 32;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				continue;
			case 15:
			case 27:
				if (num3 < array.Length)
				{
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 9;
					}
					continue;
				}
				return;
			case 2:
				num3 = 0;
				num2 = 27;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 16;
				}
				continue;
			case 12:
				return;
			case 8:
				array = paths;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
			case 3:
			case 33:
				needJointWatchPath &= d9d6D5BHLIZ9H1WVUyAl(jointWatchPath, watchRoot);
				num2 = 28;
				continue;
			case 11:
			case 23:
				text = array[num3];
				num2 = 13;
				continue;
			case 9:
				if (watchRoot == null)
				{
					return;
				}
				num2 = 8;
				continue;
			case 19:
			case 31:
				num4++;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 5;
				}
				continue;
			default:
				if (lrkayKBHgleQTRMSTeOJ(d0qmXwBHAdPh87ExleVQ(), text2[num4], pr3nKRBHrQve9Cnhlt6m(jointWatchPath, num4)))
				{
					num2 = 31;
					continue;
				}
				goto case 30;
			case 25:
				if (jointWatchPath == null)
				{
					num2 = 21;
					continue;
				}
				goto case 16;
			case 29:
				if (needJointWatchPath)
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 25;
					}
					continue;
				}
				goto case 28;
			case 13:
				if (pp2vJGBHxiq1Y5EBmcLh(text, Path.DirectorySeparatorChar.ToString()))
				{
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 6:
			case 10:
			case 24:
				num3++;
				num2 = 15;
				continue;
			case 17:
				specificWatchPaths.Add(text2);
				num2 = 29;
				continue;
			case 14:
				if (!text2.StartsWith(watchRoot, StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 24;
					continue;
				}
				goto case 17;
			case 18:
				return;
			case 26:
				AUGOrDBHmQxo7r0Tce4l(directoriesWatcher, true);
				num2 = 10;
				continue;
			case 20:
				obj = text;
				break;
			}
			text2 = (string)obj;
			num2 = 13;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
			{
				num2 = 14;
			}
		}
	}

	private ConcurrentHashSet<string> GetExistsFiles4WatchPath(string watchPath, Action<ConcurrentHashSet<string>> existsFilesAction = null)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.existsFilesAction = existsFilesAction;
		return GetExistsFiles4WatchPath(watchPath, (CS_0024_003C_003E8__locals0.existsFilesAction == null) ? null : ((Action<ConcurrentHashSet<string>, bool>)delegate(ConcurrentHashSet<string> existsFiles, bool added)
		{
			if (!added)
			{
				CS_0024_003C_003E8__locals0.existsFilesAction(existsFiles);
			}
		}));
	}

	private ConcurrentHashSet<string> GetExistsFiles4WatchPath(string watchPath, Action<ConcurrentHashSet<string>, bool> existsFilesAction)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.added = false;
		string text = (watchPath.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675510583)) ? watchPath : (watchPath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317796954)));
		ConcurrentHashSet<string> orAdd = existsFiles.GetOrAdd(text, delegate(string p)
		{
			CS_0024_003C_003E8__locals0.added = true;
			return CS_0024_003C_003E8__locals0._003C_003E4__this.PathFiles(p, null);
		});
		if (CS_0024_003C_003E8__locals0.added && ExistsFilesAdded != null)
		{
			ExistsFilesAdded(this, new FileWatcherEventArgs(text, null, FileWatcherChangeTypes.ExistsFilesAdded));
		}
		existsFilesAction?.Invoke(orAdd, CS_0024_003C_003E8__locals0.added);
		return orAdd;
	}

	public bool FileExists(string watchPath, string path)
	{
		return GetExistsFiles4WatchPath(watchPath).Contains(path);
	}

	public IReadOnlyCollection<string> ExistsFiles(string watchPath)
	{
		return GetExistsFiles4WatchPath(watchPath);
	}

	private ConcurrentHashSet<string> PathFiles(string watchPath, string dir)
	{
		_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass26_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.dir = dir;
		CS_0024_003C_003E8__locals0.watchPath = watchPath;
		if (!existsWatchPaths.GetOrAdd(CS_0024_003C_003E8__locals0.watchPath, delegate(string s)
		{
			DirectoryFileWatcher _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
			string obj = CS_0024_003C_003E8__locals0.dir ?? CS_0024_003C_003E8__locals0.watchPath;
			string dir2 = obj;
			CS_0024_003C_003E8__locals0.dir = obj;
			return _003C_003E4__this.PathPrefixes(s, dir2);
		}))
		{
			watchPaths.Where(delegate(string p)
			{
				int num7 = 1;
				int num8 = num7;
				while (true)
				{
					switch (num8)
					{
					default:
						return _003C_003Ec__DisplayClass26_0.m9fF22QTr7hvNIKQm3yP(p, CS_0024_003C_003E8__locals0.watchPath, StringComparison.InvariantCultureIgnoreCase);
					case 1:
						if (_003C_003Ec__DisplayClass26_0.JZb6sqQTlt4N320DomR3(CS_0024_003C_003E8__locals0.watchPath, p, StringComparison.InvariantCultureIgnoreCase))
						{
							return false;
						}
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num8 = 0;
						}
						break;
					}
				}
			}).Each(delegate(string p)
			{
				int num5 = 3;
				_003C_003Ec__DisplayClass26_1 _003C_003Ec__DisplayClass26_2 = default(_003C_003Ec__DisplayClass26_1);
				while (true)
				{
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						case 5:
							CS_0024_003C_003E8__locals0._003C_003E4__this.existsFiles.GetOrAdd(p, _003C_003Ec__DisplayClass26_2._003CPathFiles_003Eb__5);
							num6 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num6 = 2;
							}
							continue;
						case 2:
							break;
						case 6:
							if (_003C_003Ec__DisplayClass26_2.added)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num6 = 0;
								}
								continue;
							}
							return;
						case 4:
							return;
						default:
							if (CS_0024_003C_003E8__locals0._003C_003E4__this.ExistsFilesAdded == null)
							{
								return;
							}
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num6 = 1;
							}
							continue;
						case 1:
							CS_0024_003C_003E8__locals0._003C_003E4__this.ExistsFilesAdded(CS_0024_003C_003E8__locals0._003C_003E4__this, new FileWatcherEventArgs(p, null, FileWatcherChangeTypes.ExistsFilesAdded));
							num6 = 4;
							continue;
						case 3:
							_003C_003Ec__DisplayClass26_2 = new _003C_003Ec__DisplayClass26_1();
							num6 = 2;
							continue;
						}
						break;
					}
					_003C_003Ec__DisplayClass26_2.added = false;
					num5 = 5;
				}
			});
			return new ConcurrentHashSet<string>(StringComparer.InvariantCultureIgnoreCase);
		}
		CS_0024_003C_003E8__locals0.dir = CS_0024_003C_003E8__locals0.dir ?? CS_0024_003C_003E8__locals0.watchPath;
		CS_0024_003C_003E8__locals0.files = Directory.GetFiles(CS_0024_003C_003E8__locals0.dir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EB148), SearchOption.AllDirectories);
		watchPaths.Where(delegate(string p)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 1:
					if (CS_0024_003C_003E8__locals0.watchPath.Equals(p, StringComparison.InvariantCultureIgnoreCase))
					{
						return false;
					}
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num4 = 0;
					}
					break;
				default:
					return _003C_003Ec__DisplayClass26_0.m9fF22QTr7hvNIKQm3yP(p, CS_0024_003C_003E8__locals0.watchPath, StringComparison.InvariantCultureIgnoreCase);
				}
			}
		}).Each(delegate(string p)
		{
			//Discarded unreachable code: IL_010b, IL_011a
			int num = 5;
			_003C_003Ec__DisplayClass26_2 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_2);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						CS_0024_003C_003E8__locals0._003C_003E4__this.existsFiles.GetOrAdd(p, _003C_003Ec__DisplayClass26_._003CPathFiles_003Eb__6);
						num2 = 2;
						continue;
					case 2:
						if (_003C_003Ec__DisplayClass26_.added)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						return;
					case 6:
						CS_0024_003C_003E8__locals0._003C_003E4__this.ExistsFilesAdded(CS_0024_003C_003E8__locals0._003C_003E4__this, new FileWatcherEventArgs(p, null, FileWatcherChangeTypes.ExistsFilesAdded));
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 8;
						}
						continue;
					case 5:
						break;
					case 3:
						if (CS_0024_003C_003E8__locals0._003C_003E4__this.ExistsFilesAdded == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 6;
					case 1:
						return;
					case 4:
						_003C_003Ec__DisplayClass26_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
						continue;
					case 8:
						return;
					default:
						_003C_003Ec__DisplayClass26_.added = false;
						num2 = 7;
						continue;
					}
					break;
				}
				_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_2();
				num = 4;
			}
		});
		return new ConcurrentHashSet<string>(CS_0024_003C_003E8__locals0.files, StringComparer.InvariantCultureIgnoreCase);
	}

	private bool PathPrefixes(string phisicalPathPrefix, string dir)
	{
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = dir;
				if (text == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				text = phisicalPathPrefix;
				break;
			}
			break;
		}
		return sO98u8BHs5uhuIVGKrIY(text);
	}

	private bool PathStartsWith(string path, string startsWithPath)
	{
		//Discarded unreachable code: IL_009f, IL_00ae
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return path.StartsWith(startsWithPath, StringComparison.InvariantCultureIgnoreCase);
			case 3:
				return true;
			case 1:
				if (!xWGB3kBHclGiKlNnhxPD(startsWithPath, path, StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				if (xWGB3kBHclGiKlNnhxPD(startsWithPath, path + (string)pgl7mGBH7UWGI04WDq3E(-1886646897 ^ -1886645511), StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private bool PathDirEqualsWith(string path, string otherPath)
	{
		object obj = t7ONpHBHzW8Gpkdoh9JC(new FileInfo(path));
		string text = (string)t7ONpHBHzW8Gpkdoh9JC(new FileInfo(otherPath));
		return xWGB3kBHclGiKlNnhxPD(obj, text, StringComparison.InvariantCultureIgnoreCase);
	}

	private void PathWatcher(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_0047, IL_00ae, IL_0160, IL_01ed, IL_0232, IL_0241, IL_026e, IL_027d, IL_02e7, IL_0349, IL_0358
		switch (1)
		{
		case 1:
			try
			{
				FileSystemWatcher fileSystemWatcher = (FileSystemWatcher)sender;
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num = 1;
				}
				WatcherChangeTypes changeType = default(WatcherChangeTypes);
				while (true)
				{
					switch (num)
					{
					case 10:
						if (!CheckPathNeedProcess(((RenamedEventArgs)e).OldFullPath))
						{
							num = 17;
							break;
						}
						goto case 19;
					case 16:
						PathChanged(e.FullPath);
						num = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num = 6;
						}
						break;
					case 19:
						PathDeleted(fileSystemWatcher.NotifyFilter, (string)rRJveTBAWr2iIxysJlNc((RenamedEventArgs)e));
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num = 0;
						}
						break;
					case 9:
						if (!CheckPathNeedProcess((string)slU8rRBAFGDK4fja7QMp(e)))
						{
							num = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num = 2;
							}
							break;
						}
						goto case 16;
					case 12:
						return;
					case 5:
						switch (changeType)
						{
						case WatcherChangeTypes.Changed:
							break;
						default:
							goto IL_0183;
						case WatcherChangeTypes.Created:
							goto IL_01f7;
						case WatcherChangeTypes.Deleted:
							goto IL_0212;
						case WatcherChangeTypes.Created | WatcherChangeTypes.Deleted:
							return;
						}
						goto case 9;
					default:
						if (!CheckPathNeedProcess((string)slU8rRBAFGDK4fja7QMp(e)))
						{
							num = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num = 12;
							}
							break;
						}
						goto case 20;
					case 1:
						changeType = e.ChangeType;
						num = 5;
						break;
					case 2:
						PathAdded(sfRTxLBAB7PWPdjxHSGZ(fileSystemWatcher), (string)slU8rRBAFGDK4fja7QMp(e), subdirs: false);
						num = 14;
						break;
					case 14:
						return;
					case 15:
						goto IL_01f7;
					case 8:
						goto IL_0212;
					case 3:
						return;
					case 6:
						return;
					case 20:
						PathAdded(sfRTxLBAB7PWPdjxHSGZ(fileSystemWatcher), (string)slU8rRBAFGDK4fja7QMp(e), subdirs: true);
						num = 13;
						break;
					case 18:
						return;
					case 11:
						return;
					case 4:
						PathDeleted(sfRTxLBAB7PWPdjxHSGZ(fileSystemWatcher), e.FullPath);
						num = 11;
						break;
					case 7:
						if (changeType != WatcherChangeTypes.Renamed)
						{
							num = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num = 18;
							}
							break;
						}
						goto case 10;
					case 13:
						return;
						IL_0183:
						num = 7;
						break;
						IL_0212:
						if (CheckPathNeedProcess((string)slU8rRBAFGDK4fja7QMp(e)))
						{
							num = 4;
							break;
						}
						return;
						IL_01f7:
						if (CheckPathNeedProcess(e.FullPath))
						{
							num = 2;
							break;
						}
						return;
					}
				}
			}
			catch (IOException ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						egteL6BAbZnlm0TkpxrV(Logger.Log, h2gemjBAotF9QU1h5Zn1(pgl7mGBH7UWGI04WDq3E(-1870892489 ^ -1870845187), slU8rRBAFGDK4fja7QMp(e)), ex);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		case 0:
			break;
		}
	}

	private bool CheckPathNeedProcess(string fullPath)
	{
		//Discarded unreachable code: IL_0092, IL_00a1
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass31_._003C_003E4__this = this;
				num2 = 6;
				break;
			case 6:
				_003C_003Ec__DisplayClass31_.fullPath = fullPath;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return specificWatchPaths.Any(_003C_003Ec__DisplayClass31_._003CCheckPathNeedProcess_003Eb__0);
			case 5:
				return true;
			case 2:
				if (!needJointWatchPath)
				{
					num2 = 5;
					break;
				}
				goto default;
			default:
				if (!PathStartsWith(_003C_003Ec__DisplayClass31_.fullPath, jointWatchPath))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	private void PathChanged(string path)
	{
		//Discarded unreachable code: IL_00fe, IL_010d
		int num = 7;
		int num2 = num;
		List<string> list = default(List<string>);
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 8:
				list.ForEach(_003C_003Ec__DisplayClass32_._003CPathChanged_003Eb__2);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!T21Yy9BAGDGObWc3hxvC(new FileInfo(_003C_003Ec__DisplayClass32_.path)))
				{
					return;
				}
				num2 = 8;
				break;
			case 1:
				return;
			default:
				_003C_003Ec__DisplayClass32_.path = path;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass32_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				return;
			case 9:
				if (gks8TXBAhCWoEYqUBPmn(list) != 0)
				{
					list.Sort();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 5:
				list = watchPaths.Where(_003C_003Ec__DisplayClass32_._003CPathChanged_003Eb__0).Union(specificWatchPaths.Where(_003C_003Ec__DisplayClass32_._003CPathChanged_003Eb__1)).ToList();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void UpdateExistsWatchPaths(string watchPath, bool needValue)
	{
		//Discarded unreachable code: IL_00fb, IL_010a
		int num = 6;
		int num2 = num;
		bool value = default(bool);
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = default(_003C_003Ec__DisplayClass33_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (!existsWatchPaths.TryGetValue(watchPath, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 3:
				_003C_003Ec__DisplayClass33_.needValue = needValue;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				return;
			case 0:
				return;
			case 2:
				return;
			case 7:
				if (value != _003C_003Ec__DisplayClass33_.needValue)
				{
					existsWatchPaths.AddOrUpdate(watchPath, _003C_003Ec__DisplayClass33_._003CUpdateExistsWatchPaths_003Eb__0, _003C_003Ec__DisplayClass33_._003CUpdateExistsWatchPaths_003Eb__1);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass33_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void PathAdded(NotifyFilters notifyFilters, string path, bool subdirs)
	{
		int num = 15;
		int num2 = num;
		List<string> list = default(List<string>);
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_2 = default(_003C_003Ec__DisplayClass34_0);
		_003C_003Ec__DisplayClass34_1 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_1);
		while (true)
		{
			switch (num2)
			{
			case 11:
				return;
			case 8:
				list.ForEach(_003C_003Ec__DisplayClass34_2._003CPathAdded_003Eb__3);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				if (!subdirs)
				{
					return;
				}
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 9;
				}
				break;
			case 4:
				watchPaths.Where(_003C_003Ec__DisplayClass34_._003CPathAdded_003Eb__4).Union(specificWatchPaths.Where(_003C_003Ec__DisplayClass34_._003CPathAdded_003Eb__5)).Each(delegate(string p)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec__DisplayClass34_.CS_0024_003C_003E8__locals1._003C_003E4__this.UpdateExistsWatchPaths(p, needValue: true);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 11;
				break;
			case 13:
				list = watchPaths.Where(_003C_003Ec__DisplayClass34_2._003CPathAdded_003Eb__0).Union(specificWatchPaths.Where(_003C_003Ec__DisplayClass34_2._003CPathAdded_003Eb__1)).ToList();
				num2 = 2;
				break;
			case 10:
				_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_1();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass34_2.FileNames = _003C_003Ec__DisplayClass34_2._003CPathAdded_003Eb__2;
				num2 = 8;
				break;
			case 5:
				_003C_003Ec__DisplayClass34_2.notifyFilters = notifyFilters;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				return;
			case 15:
				_003C_003Ec__DisplayClass34_2 = new _003C_003Ec__DisplayClass34_0();
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				if (list.Count != 0)
				{
					list.Sort();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 12:
				if (_003C_003Ec__DisplayClass34_2.notifyFilters != NotifyFilters.DirectoryName)
				{
					return;
				}
				num2 = 10;
				break;
			case 6:
				_003C_003Ec__DisplayClass34_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass34_2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 16;
				}
				break;
			default:
				_003C_003Ec__DisplayClass34_2.fileNames = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				_003C_003Ec__DisplayClass34_2.path = path;
				num2 = 5;
				break;
			case 14:
				_003C_003Ec__DisplayClass34_2._003C_003E4__this = this;
				num2 = 9;
				break;
			case 16:
				_003C_003Ec__DisplayClass34_.searchPath = (string)(_003C_003Ec__DisplayClass34_.CS_0024_003C_003E8__locals1.path.EndsWith((string)pgl7mGBH7UWGI04WDq3E(0x92F12D5 ^ 0x92F0DA3)) ? _003C_003Ec__DisplayClass34_.CS_0024_003C_003E8__locals1.path : girTMKBH0uMVVyDW2V7c(_003C_003Ec__DisplayClass34_.CS_0024_003C_003E8__locals1.path, pgl7mGBH7UWGI04WDq3E(-218496594 ^ -218489128)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void PathDeleted(NotifyFilters notifyFilters, string path)
	{
		//Discarded unreachable code: IL_00a1, IL_00b0
		int num = 12;
		int num2 = num;
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		List<string> list = default(List<string>);
		List<string> list2 = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 11:
				_003C_003Ec__DisplayClass35_._003C_003E4__this = this;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 14;
				}
				break;
			case 14:
				_003C_003Ec__DisplayClass35_.path = path;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				return;
			case 10:
				_003C_003Ec__DisplayClass35_.notifyFilters = notifyFilters;
				num2 = 7;
				break;
			case 2:
				list = watchPaths.Where(_003C_003Ec__DisplayClass35_._003CPathDeleted_003Eb__0).Union(specificWatchPaths.Where(_003C_003Ec__DisplayClass35_._003CPathDeleted_003Eb__1)).ToList();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				return;
			case 3:
				OgqUcdBAErHZhX1Wh9q8(list2);
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 10;
				}
				break;
			case 6:
				list2 = watchPaths.Where(_003C_003Ec__DisplayClass35_._003CPathDeleted_003Eb__3).Union(specificWatchPaths.Where(_003C_003Ec__DisplayClass35_._003CPathDeleted_003Eb__4)).ToList();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (gks8TXBAhCWoEYqUBPmn(list) == 0)
				{
					num2 = 6;
					break;
				}
				if (_003C_003Ec__DisplayClass35_.notifyFilters != NotifyFilters.DirectoryName)
				{
					return;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 2;
				}
				break;
			case 12:
				_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
				num2 = 11;
				break;
			case 1:
				if (list2.Count == 0)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 13:
				list2.ForEach(_003C_003Ec__DisplayClass35_._003CPathDeleted_003Eb__5);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				list.Distinct().Each(_003C_003Ec__DisplayClass35_._003CPathDeleted_003Eb__2);
				num2 = 4;
				break;
			case 7:
				_003C_003Ec__DisplayClass35_.searchPath = (string)(pp2vJGBHxiq1Y5EBmcLh(_003C_003Ec__DisplayClass35_.path, pgl7mGBH7UWGI04WDq3E(-1870892489 ^ -1870893759)) ? _003C_003Ec__DisplayClass35_.path : girTMKBH0uMVVyDW2V7c(_003C_003Ec__DisplayClass35_.path, pgl7mGBH7UWGI04WDq3E(-576149596 ^ -576145198)));
				num2 = 2;
				break;
			}
		}
	}

	internal static object d0qmXwBHAdPh87ExleVQ()
	{
		return StringComparer.InvariantCultureIgnoreCase;
	}

	internal static bool KU23M3BH6dBU5bn5d3BG()
	{
		return w76uHNBH46nqSpgbY7g3 == null;
	}

	internal static DirectoryFileWatcher RhTMtkBHHdjroQZKNIXh()
	{
		return w76uHNBH46nqSpgbY7g3;
	}

	internal static object pgl7mGBH7UWGI04WDq3E(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool pp2vJGBHxiq1Y5EBmcLh(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static object girTMKBH0uMVVyDW2V7c(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void AUGOrDBHmQxo7r0Tce4l(object P_0, bool P_1)
	{
		((FileSystemWatcher)P_0).EnableRaisingEvents = P_1;
	}

	internal static void wR2mFhBHyMEjQXV4skQK(object P_0, NotifyFilters P_1)
	{
		((FileSystemWatcher)P_0).NotifyFilter = P_1;
	}

	internal static void kA9hx6BHMlnyaooqrPl2(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Changed += (FileSystemEventHandler)P_1;
	}

	internal static void OOQkZSBHJPuvGe6mMyVt(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Created += (FileSystemEventHandler)P_1;
	}

	internal static void CmawHpBH9YIj64XEuGWC(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Renamed += (RenamedEventHandler)P_1;
	}

	internal static void aZRj2jBHds7iSZOgdK4U(object P_0, bool P_1)
	{
		((FileSystemWatcher)P_0).IncludeSubdirectories = P_1;
	}

	internal static void ONByoeBHlvQMc1V6mmS8(object P_0, object P_1)
	{
		((FileSystemWatcher)P_0).Deleted += (FileSystemEventHandler)P_1;
	}

	internal static char pr3nKRBHrQve9Cnhlt6m(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static bool lrkayKBHgleQTRMSTeOJ(object P_0, object P_1, object P_2)
	{
		return ((StringComparer)P_0).Equals(P_1, P_2);
	}

	internal static object jJonhbBH5nInkTuURLLi(object P_0, int P_1)
	{
		return ((string)P_0).Remove(P_1);
	}

	internal static int TeMw8iBHjMZNsgchw82i(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static int GsD5k7BHYNQluQM9QZd0(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static bool d9d6D5BHLIZ9H1WVUyAl(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool oxwsB1BHURjtdVX4j2jI(object P_0)
	{
		return ((FileSystemWatcher)P_0).EnableRaisingEvents;
	}

	internal static bool sO98u8BHs5uhuIVGKrIY(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static bool xWGB3kBHclGiKlNnhxPD(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object t7ONpHBHzW8Gpkdoh9JC(object P_0)
	{
		return ((FileInfo)P_0).DirectoryName;
	}

	internal static object slU8rRBAFGDK4fja7QMp(object P_0)
	{
		return ((FileSystemEventArgs)P_0).FullPath;
	}

	internal static NotifyFilters sfRTxLBAB7PWPdjxHSGZ(object P_0)
	{
		return ((FileSystemWatcher)P_0).NotifyFilter;
	}

	internal static object rRJveTBAWr2iIxysJlNc(object P_0)
	{
		return ((RenamedEventArgs)P_0).OldFullPath;
	}

	internal static object h2gemjBAotF9QU1h5Zn1(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void egteL6BAbZnlm0TkpxrV(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static int gks8TXBAhCWoEYqUBPmn(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static bool T21Yy9BAGDGObWc3hxvC(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static void OgqUcdBAErHZhX1Wh9q8(object P_0)
	{
		((List<string>)P_0).Sort();
	}
}
