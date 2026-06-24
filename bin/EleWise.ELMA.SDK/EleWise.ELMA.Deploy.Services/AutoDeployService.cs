using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
public class AutoDeployService : IAutoDeployService, IAutoDeployWithResultService
{
	private class ManifestList
	{
		internal static object Bb8swn819axCoYAcM5k3;

		public List<ManifestItem> All { get; }

		public string DeployDirectory
		{
			[CompilerGenerated]
			get
			{
				return _003CDeployDirectory_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CDeployDirectory_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public void Remove(ManifestItem item)
		{
			//Discarded unreachable code: IL_0041, IL_0050, IL_00d8
			int num = 7;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 7:
					item.Childs.ToList().ForEach(Remove);
					num2 = 6;
					break;
				case 4:
					All.Remove(item);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					if (!All.Contains(item))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 4;
				case 3:
					EBkCPR81gUm27JSuVjF5(jUWRY881rM30vfwHTCZT(item), item);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				default:
					if (jUWRY881rM30vfwHTCZT(item) == null)
					{
						num2 = 5;
						break;
					}
					goto case 3;
				}
			}
		}

		public void Remove(ElmaStoreComponentManifest manifest)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 1;
					}
					break;
				default:
					All.Where(_003C_003Ec__DisplayClass8_._003CRemove_003Eb__0).ToList().ForEach(Remove);
					num2 = 3;
					break;
				case 3:
					return;
				case 1:
					_003C_003Ec__DisplayClass8_.manifest = manifest;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void Add(ManifestItem item, ManifestItem parent)
		{
			//Discarded unreachable code: IL_00b0, IL_00bf
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					All.Add(item);
					num2 = 4;
					break;
				case 2:
					return;
				case 3:
					return;
				case 6:
					aiPM4s815DTK7UsvGJZr(parent, item);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (All.Contains(item))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				default:
					if (parent == null)
					{
						num2 = 3;
						break;
					}
					goto case 6;
				}
			}
		}

		public ManifestList()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			vbj9aW81jpVPnWdqE8yE();
			All = new List<ManifestItem>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool a9UWo781dlMoiW5u7p6p()
		{
			return Bb8swn819axCoYAcM5k3 == null;
		}

		internal static ManifestList uGN2TN81ltsFiu8ukNXk()
		{
			return (ManifestList)Bb8swn819axCoYAcM5k3;
		}

		internal static object jUWRY881rM30vfwHTCZT(object P_0)
		{
			return ((ManifestItem)P_0).Parent;
		}

		internal static void EBkCPR81gUm27JSuVjF5(object P_0, object P_1)
		{
			((ManifestItem)P_0).RemoveChild((ManifestItem)P_1);
		}

		internal static void aiPM4s815DTK7UsvGJZr(object P_0, object P_1)
		{
			((ManifestItem)P_0).AddChild((ManifestItem)P_1);
		}

		internal static void vbj9aW81jpVPnWdqE8yE()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class ManifestItem
	{
		public List<ManifestItem> Childs;

		private static object bsGgaP81YpS6wiyl3G6b;

		public string ElmaFile
		{
			[CompilerGenerated]
			get
			{
				return _003CElmaFile_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CElmaFile_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public string ManifestFile
		{
			[CompilerGenerated]
			get
			{
				return _003CManifestFile_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CManifestFile_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ElmaStoreComponentManifest Manifest
		{
			[CompilerGenerated]
			get
			{
				return _003CManifest_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CManifest_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Id
		{
			get
			{
				//Discarded unreachable code: IL_003f, IL_004e
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return (string)Rl1o3R81spJLQgaQ1GY7(Manifest);
					case 1:
						return "";
					case 2:
						if (Manifest == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					}
				}
			}
		}

		public SemanticVersion Version => (SemanticVersion)Hy94Kj81cGJo7B1R84BS(Manifest);

		public ManifestItem Parent
		{
			[CompilerGenerated]
			get
			{
				return _003CParent_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CParent_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public void AddChild(ManifestItem child)
		{
			//Discarded unreachable code: IL_0081, IL_0090
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						Childs.Add(child);
						num2 = 4;
						continue;
					case 2:
						return;
					case 4:
						return;
					case 3:
						if (child != null)
						{
							break;
						}
						goto end_IL_0012;
					}
					child.Parent = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}

		public void RemoveChild(ManifestItem child)
		{
			//Discarded unreachable code: IL_003d, IL_004c, IL_006e, IL_007d
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						return;
					case 5:
						R7jkJM81zmtSnrEXvGTp(child, null);
						num2 = 6;
						continue;
					case 0:
						return;
					case 3:
						return;
					case 6:
						Childs.Remove(child);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						if (child == null)
						{
							break;
						}
						goto case 1;
					case 1:
						if (!Childs.Contains(child))
						{
							num2 = 2;
							continue;
						}
						goto case 5;
					}
					break;
				}
				num = 3;
			}
		}

		public ManifestItem()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			DwFCwK8NFJXp0jT3tb99();
			Childs = new List<ManifestItem>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool opeMSW81Lwhpahgu8055()
		{
			return bsGgaP81YpS6wiyl3G6b == null;
		}

		internal static ManifestItem Cl6YDx81UdlaZCstxrv2()
		{
			return (ManifestItem)bsGgaP81YpS6wiyl3G6b;
		}

		internal static object Rl1o3R81spJLQgaQ1GY7(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).Id;
		}

		internal static object Hy94Kj81cGJo7B1R84BS(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).SemanticVersion;
		}

		internal static void R7jkJM81zmtSnrEXvGTp(object P_0, object P_1)
		{
			((ManifestItem)P_0).Parent = (ManifestItem)P_1;
		}

		internal static void DwFCwK8NFJXp0jT3tb99()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class StandardAutoDeployResult : IDeployResult
	{
		private readonly object logPath;

		private static object QukqkU8NB3eir13hA2Xh;

		public bool HasErrors { get; }

		public StandardAutoDeployResult(bool hasErrors, string logPath)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			P4x6Wg8NbB9L1sQDqQRt();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					this.logPath = logPath;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num = 2;
					}
					break;
				case 1:
					HasErrors = hasErrors;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		public string GetLog()
		{
			return (string)q1Wrq68NG7ZymTDPXsYR(logPath, Qx26Vk8NhAi1mXuq9NHB());
		}

		internal static void P4x6Wg8NbB9L1sQDqQRt()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool Tj60HK8NWHMa3OwnXlkP()
		{
			return QukqkU8NB3eir13hA2Xh == null;
		}

		internal static StandardAutoDeployResult btbfVg8No9RZDqG30bfm()
		{
			return (StandardAutoDeployResult)QukqkU8NB3eir13hA2Xh;
		}

		internal static object Qx26Vk8NhAi1mXuq9NHB()
		{
			return Encoding.UTF8;
		}

		internal static object q1Wrq68NG7ZymTDPXsYR(object P_0, object P_1)
		{
			return File.ReadAllText((string)P_0, (Encoding)P_1);
		}
	}

	private class ExceptionAutoDeployResult : IDeployResult
	{
		private readonly object exception;

		internal static object zLoWZf8NE9CGUpTclYTT;

		public bool HasErrors => true;

		public ExceptionAutoDeployResult(Exception exception)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			NxMlnt8NCjmT6H7PO3oh();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
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
				this.exception = exception;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num = 1;
				}
			}
		}

		public string GetLog()
		{
			return exception.ToString();
		}

		internal static void NxMlnt8NCjmT6H7PO3oh()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool fO4WvN8NfVIEsekLn2xW()
		{
			return zLoWZf8NE9CGUpTclYTT == null;
		}

		internal static ExceptionAutoDeployResult CyTHry8NQwmDjFgR7FFS()
		{
			return (ExceptionAutoDeployResult)zLoWZf8NE9CGUpTclYTT;
		}
	}

	private class ManifestDeployLogger : ILogger
	{
		private readonly object deployDirectory;

		private readonly object builder;

		private static object rnjaZ08Nv5ywfDiCaoT7;

		public string LogPath => (string)hw1gDp8NVTLnWdklcQYf(deployDirectory, WBJtwc8NIy0burxTLt7m(-475857671 ^ -475631305));

		public bool HasErrors
		{
			[CompilerGenerated]
			get
			{
				return _003CHasErrors_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CHasErrors_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public event EventHandler ConfigurationChanged
		{
			[CompilerGenerated]
			add
			{
				int num = 2;
				int num2 = num;
				EventHandler eventHandler = default(EventHandler);
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 3:
						if ((object)eventHandler == eventHandler2)
						{
							num2 = 5;
							continue;
						}
						break;
					case 4:
						eventHandler = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler2);
						num2 = 3;
						continue;
					default:
						value2 = (EventHandler)d66f818NuYQ004THq5kD(eventHandler2, value);
						num2 = 4;
						continue;
					case 5:
						return;
					case 2:
						eventHandler = this.ConfigurationChanged;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						break;
					}
					eventHandler2 = eventHandler;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 2;
				int num2 = num;
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler eventHandler = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 4:
						if ((object)eventHandler2 == eventHandler)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 1;
					default:
						value2 = (EventHandler)Delegate.Remove(eventHandler, value);
						num2 = 5;
						break;
					case 3:
						return;
					case 1:
						eventHandler = eventHandler2;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						eventHandler2 = this.ConfigurationChanged;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 1;
						}
						break;
					case 5:
						eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 2;
						}
						break;
					}
				}
			}
		}

		public ManifestDeployLogger(string deployDirectory)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			oVYv148NSaMtbeGYJw1E();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					gbwa6l8NijhyktRWITHJ(deployDirectory, WBJtwc8NIy0burxTLt7m(0x17ADCCD8 ^ 0x17A83ECE));
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num = 0;
					}
					break;
				case 3:
					builder = new StringBuilder();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num = 1;
					}
					break;
				default:
					this.deployDirectory = deployDirectory;
					num = 3;
					break;
				case 1:
					return;
				}
			}
		}

		public void InnerLog(string logItem, LogLevel level)
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
					rZdMOP8NXSRbArcnsetN(builder, ltU6CZ8NKakO6P8Lg4mE(new string[5]
					{
						(string)Dl8lRF8NRsWp8Q3kjFbH(level),
						(string)WBJtwc8NIy0burxTLt7m(-16752921 ^ -16771131),
						aaIGEE8NqBjp5Ga9KQ9O().ToString((string)WBJtwc8NIy0burxTLt7m(-1767720453 ^ -1767822187)),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECE90AC),
						logItem
					}));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void CompleteDeploy()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					File.WriteAllText(LogPath, builder.ToString());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public bool IsEnabled(LogLevel level)
		{
			return true;
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					InnerLog(format, level);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				default:
					DeployLog.Log(level, exception, format, args);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					HasErrors |= level == LogLevel.Error || level == LogLevel.Fatal;
					num2 = 2;
					break;
				}
			}
		}

		private static string StringifyLogLevel(LogLevel level)
		{
			//Discarded unreachable code: IL_0069, IL_0078
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					switch (level)
					{
					default:
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					case LogLevel.Verbose:
						break;
					case LogLevel.Trace:
						return (string)WBJtwc8NIy0burxTLt7m(0x53FA00CE ^ 0x53FEBE9A);
					case LogLevel.Debug:
						return (string)WBJtwc8NIy0burxTLt7m(0x10E41EDB ^ 0x10E0A0B9);
					case LogLevel.Information:
						return (string)WBJtwc8NIy0burxTLt7m(-1822890472 ^ -1822664600);
					case LogLevel.Warning:
						return (string)WBJtwc8NIy0burxTLt7m(-2138958856 ^ -2138657402);
					case LogLevel.Error:
						return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1240A228);
					case LogLevel.Fatal:
						return (string)WBJtwc8NIy0burxTLt7m(0x8317432 ^ 0x835CAA8);
					}
					goto case 2;
				case 2:
					return (string)WBJtwc8NIy0burxTLt7m(-629844702 ^ -630068380);
				default:
					{
						throw new InvalidOperationException((string)WBJtwc8NIy0burxTLt7m(0x5A4C7B29 ^ 0x5A48C581));
					}
					end_IL_0012:
					break;
				}
			}
		}

		internal static object d66f818NuYQ004THq5kD(object P_0, object P_1)
		{
			return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
		}

		internal static bool hYraZy8N83aPLh7Rp8Oh()
		{
			return rnjaZ08Nv5ywfDiCaoT7 == null;
		}

		internal static ManifestDeployLogger mAVD2s8NZmFekE2HtarI()
		{
			return (ManifestDeployLogger)rnjaZ08Nv5ywfDiCaoT7;
		}

		internal static object WBJtwc8NIy0burxTLt7m(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object hw1gDp8NVTLnWdklcQYf(object P_0, object P_1)
		{
			return Path.Combine((string)P_0, (string)P_1);
		}

		internal static void oVYv148NSaMtbeGYJw1E()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static void gbwa6l8NijhyktRWITHJ(object P_0, object P_1)
		{
			Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
		}

		internal static object Dl8lRF8NRsWp8Q3kjFbH(LogLevel level)
		{
			return StringifyLogLevel(level);
		}

		internal static DateTime aaIGEE8NqBjp5Ga9KQ9O()
		{
			return DateTime.Now;
		}

		internal static object ltU6CZ8NKakO6P8Lg4mE(object P_0)
		{
			return string.Concat((string[])P_0);
		}

		internal static object rZdMOP8NXSRbArcnsetN(object P_0, object P_1)
		{
			return ((StringBuilder)P_0).AppendLine((string)P_1);
		}
	}

	public const string AutoDeployExtension = ".elma4deploy";

	[Obsolete("Константа устарела. Используйте массив AutoDeployMasks.", true)]
	public const string AutoDeployMask = "*.elma3deploy";

	public static readonly string[] AllowedAutoDeployExtensions;

	public static readonly string[] AutoDeployMasks;

	private static readonly ILogger DeployLog;

	internal static AutoDeployService K4cWdEEHVcMEgNoaS6PX;

	private string DefaultAutoDeployPath()
	{
		int num = 2;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					text = (string)PKUS72EHKKn6swMQ9jxy(WV9tFuEHRwCCp4TYNLwd(Locator.GetServiceNotNull<PackageService>()), NOqQvoEHqpypsttIQ10j(-29254301 ^ -29027467));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (!NW3HeNEHXbyNJ1Ku4KHP(text))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					goto end_IL_0012;
				case 3:
					break;
				}
				return text;
				continue;
				end_IL_0012:
				break;
			}
			R4eZwKEHTNTlOAWr5Bbj(text);
			num = 3;
		}
	}

	private string DefaultSubmodulesPath(string mainPath)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!Directory.Exists(text))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 3:
				R4eZwKEHTNTlOAWr5Bbj(text);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return text;
			case 1:
				text = (string)PKUS72EHKKn6swMQ9jxy(mainPath, NOqQvoEHqpypsttIQ10j(-561074844 ^ -561372342));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private string GetModulePath(string mainPath, string deployFile)
	{
		//Discarded unreachable code: IL_00b5
		int num = 4;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return text;
			case 2:
				R4eZwKEHTNTlOAWr5Bbj(text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				text = (string)PKUS72EHKKn6swMQ9jxy(mainPath, (string)irB9GcEHkLRx4w9RFEXZ(deployFile) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FE50F) + jNWBr6EHnfuZdCBXT5P1().ToString((string)NOqQvoEHqpypsttIQ10j(-1886646897 ^ -1886879709)));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (NW3HeNEHXbyNJ1Ku4KHP(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private string GetSubmodulePath(string mainPath, ManifestItem manifest)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!NW3HeNEHXbyNJ1Ku4KHP(text))
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				Directory.CreateDirectory(text);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				text = (string)PKUS72EHKKn6swMQ9jxy(mainPath, wtJZyUEHeZHPAxYcd2jK(NOqQvoEHqpypsttIQ10j(-309639236 ^ -309721256), oPEcFbEHOmiXeFTUix9x(manifest), I5GCs4EH2NX4MsLi0ifu(manifest)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		return text;
	}

	public void RunAutoDeploy()
	{
		int num = 2;
		int num2 = num;
		string autoDeployPath = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				autoDeployPath = DefaultAutoDeployPath();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				RunAutoDeploy(autoDeployPath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RunAutoDeploy(string autoDeployPath)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNullOrEmpty(autoDeployPath, (string)NOqQvoEHqpypsttIQ10j(0x1637C429 ^ 0x16334A6F));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				RunDeploy(autoDeployPath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public IEnumerable<IDeployResult> RunAutoDeployWithResult(string autoDeployPath)
	{
		Contract.ArgumentNotNullOrEmpty(autoDeployPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575919646));
		return RunDeploy(autoDeployPath);
	}

	private IEnumerable<IDeployResult> RunDeploy(string autoDeployPath)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_._003C_003E4__this = this;
		DeployLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978245484));
		_003C_003Ec__DisplayClass24_.results = new List<IDeployResult>();
		try
		{
			_003C_003Ec__DisplayClass24_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass24_;
			ICollection<IDeployResult> moduleDeployResults;
			List<ManifestList> source = BuildTree(autoDeployPath, out moduleDeployResults);
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.results.AddRange(moduleDeployResults);
			CS_0024_003C_003E8__locals0.designerItems = source.Where((ManifestList manifestList) => manifestList.All.Any((ManifestItem item) => (string)_003C_003Ec.cObD3i8Nx0qPLVnFK04G(item) == ModuleMetadataItemHeaderManager.WebDesignerPackageName)).ToList();
			(from manifestList in source
				where !CS_0024_003C_003E8__locals0.designerItems.Contains(manifestList)
				select manifestList into t
				group t by t.DeployDirectory into @group
				where @group != null && @group.Any() && !string.IsNullOrEmpty(@group.Key)
				select @group).ForEach(delegate(IGrouping<string, ManifestList> group)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_2();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1;
				CS_0024_003C_003E8__locals0.localDeployLog = new ManifestDeployLogger(group.Key);
				try
				{
					group.ForEach(delegate(ManifestList manifest)
					{
						int num5 = 6;
						int num6 = num5;
						List<ManifestItem> sortedManifestList = default(List<ManifestItem>);
						while (true)
						{
							switch (num6)
							{
							default:
								return;
							case 5:
								CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2._003C_003E4__this.CutTree(manifest, CS_0024_003C_003E8__locals0.localDeployLog);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num6 = 1;
								}
								break;
							case 7:
								_003C_003Ec__DisplayClass24_2.Xug4xy8N4T0K8gErTfD0(CS_0024_003C_003E8__locals0.localDeployLog, _003C_003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(0x5F3078B6 ^ 0x5F358B86), LogLevel.Information);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
								{
									num6 = 0;
								}
								break;
							case 4:
								sortedManifestList = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2._003C_003E4__this.GetSortedManifestList(manifest.All);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num6 = 2;
								}
								break;
							case 0:
								return;
							case 2:
								_003C_003Ec__DisplayClass24_2.Xug4xy8N4T0K8gErTfD0(CS_0024_003C_003E8__locals0.localDeployLog, _003C_003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(-1088304168 ^ -1088145120), LogLevel.Information);
								num6 = 3;
								break;
							case 3:
								CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2._003C_003E4__this.RunImport(sortedManifestList, CS_0024_003C_003E8__locals0.localDeployLog);
								num6 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num6 = 3;
								}
								break;
							case 6:
								CS_0024_003C_003E8__locals0.localDeployLog.InnerLog((string)_003C_003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(0x92F12D5 ^ 0x92AE0ED), LogLevel.Information);
								num6 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num6 = 2;
								}
								break;
							case 1:
								_003C_003Ec__DisplayClass24_2.Xug4xy8N4T0K8gErTfD0(CS_0024_003C_003E8__locals0.localDeployLog, _003C_003Ec__DisplayClass24_2.dMK3y08NwkWLBt7Gkck9(0x7EC153F ^ 0x7E9E7BB), LogLevel.Information);
								num6 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num6 = 4;
								}
								break;
							}
						}
					});
				}
				finally
				{
					CS_0024_003C_003E8__locals0.localDeployLog.CompleteDeploy();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.results.Add(new StandardAutoDeployResult(CS_0024_003C_003E8__locals0.localDeployLog.HasErrors, CS_0024_003C_003E8__locals0.localDeployLog.LogPath));
				}
			});
			if (CS_0024_003C_003E8__locals0.designerItems.Count != 0)
			{
				ThreadStarter.StartNewThread((ThreadStart)delegate
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
							CS_0024_003C_003E8__locals0.designerItems.ForEach(delegate(ManifestList designerItem)
							{
								int num3 = 1;
								int num4 = num3;
								ManifestItem manifestItem = default(ManifestItem);
								while (true)
								{
									switch (num4)
									{
									case 1:
										manifestItem = designerItem.All.First();
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
										{
											num4 = 0;
										}
										break;
									case 2:
										return;
									default:
										CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.InstallModule((string)_003C_003Ec__DisplayClass24_0.vWnDlB8N2e1GLquvk1ZU(manifestItem), (string)_003C_003Ec__DisplayClass24_0.gjfJ8r8NeiFfHdCOQaOQ(designerItem));
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
										{
											num4 = 2;
										}
										break;
									}
								}
							});
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				});
			}
		}
		catch (Exception ex)
		{
			DeployLog.Error(ex);
			_003C_003Ec__DisplayClass24_.results.Add(new ExceptionAutoDeployResult(ex));
		}
		DeployLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72438C02));
		return _003C_003Ec__DisplayClass24_.results;
	}

	private void RunImport(List<ManifestItem> manifests, ManifestDeployLogger localDeployLog)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals0.manifests = manifests;
		CS_0024_003C_003E8__locals0.localDeployLog = localDeployLog;
		if (CS_0024_003C_003E8__locals0.manifests == null || CS_0024_003C_003E8__locals0.manifests.Count == 0)
		{
			return;
		}
		CS_0024_003C_003E8__locals0.moduleManager = ComponentManager.Current.ModuleManager as ModuleManager;
		if (CS_0024_003C_003E8__locals0.moduleManager == null)
		{
			CS_0024_003C_003E8__locals0.localDeployLog.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335291229));
			return;
		}
		CS_0024_003C_003E8__locals0.componentsInfo = (from i in CS_0024_003C_003E8__locals0.moduleManager.GetInstalledComponentInfos()
			where _003C_003Ec.wFhLHD8N0fDYIs2ESyKZ(i) != null
			select i).ToList();
		List<ModuleManager.StoreComponentConfigurationInfo> list = CS_0024_003C_003E8__locals0.componentsInfo.Where(delegate(ModuleManager.StoreComponentConfigurationInfo i)
		{
			int num17 = 2;
			int num18 = num17;
			while (true)
			{
				switch (num18)
				{
				case 1:
					if (_003C_003Ec.QRhN0d8NmBPvLJ1bGGeo(i) != AutoDeployComponentStatus.Step1)
					{
						num18 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num18 = 0;
						}
						break;
					}
					goto IL_005a;
				default:
					return i.DeployStatus == AutoDeployComponentStatus.Step2;
				case 2:
					{
						if (_003C_003Ec.QRhN0d8NmBPvLJ1bGGeo(i) != AutoDeployComponentStatus.Step0)
						{
							num18 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num18 = 1;
							}
							break;
						}
						goto IL_005a;
					}
					IL_005a:
					return true;
				}
			}
		}).ToList();
		if (list.Count() > 1)
		{
			CS_0024_003C_003E8__locals0.localDeployLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E09001));
			list.ForEach(delegate(ModuleManager.StoreComponentConfigurationInfo i)
			{
				int num15 = 1;
				int num16 = num15;
				while (true)
				{
					switch (num16)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003C_003Ec__DisplayClass25_0.c8WARi83FloG4crGqeVA(CS_0024_003C_003E8__locals0.moduleManager, i, AutoDeployComponentStatus.Failed);
						num16 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num16 = 0;
						}
						break;
					}
				}
			});
			list.RemoveAll((ModuleManager.StoreComponentConfigurationInfo i) => true);
		}
		CS_0024_003C_003E8__locals0.componentInStep = list.FirstOrDefault();
		bool flag = CS_0024_003C_003E8__locals0.componentInStep != null;
		if (CS_0024_003C_003E8__locals0.componentInStep != null && CS_0024_003C_003E8__locals0.manifests.All((ManifestItem ad) => _003C_003Ec__DisplayClass25_0.F08rt283of9al6s8e6GN(_003C_003Ec__DisplayClass25_0.WInWMM83BumMFntwBWfp(ad), _003C_003Ec__DisplayClass25_0.zitm3k83WV9xdt9M4WK3(CS_0024_003C_003E8__locals0.componentInStep))))
		{
			CS_0024_003C_003E8__locals0.localDeployLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822660350));
			CS_0024_003C_003E8__locals0.moduleManager.UpdateAutoDeployComponentInfo(CS_0024_003C_003E8__locals0.componentInStep, AutoDeployComponentStatus.Failed);
			flag = false;
		}
		if (!flag)
		{
			_003C_003Ec__DisplayClass25_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass25_1();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals1.removeList = new List<ManifestItem>();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.manifests.ForEach(delegate(ManifestItem ad)
			{
				//Discarded unreachable code: IL_00d5
				int num13 = 3;
				int num14 = num13;
				_003C_003Ec__DisplayClass25_2 _003C_003Ec__DisplayClass25_2 = default(_003C_003Ec__DisplayClass25_2);
				while (true)
				{
					switch (num14)
					{
					default:
						return;
					case 0:
						return;
					case 4:
						return;
					case 2:
						_003C_003Ec__DisplayClass25_2.ad = ad;
						num14 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num14 = 0;
						}
						break;
					case 5:
						CS_0024_003C_003E8__locals1.removeList.Add(_003C_003Ec__DisplayClass25_2.ad);
						num14 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num14 = 4;
						}
						break;
					case 1:
						if (!CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.componentsInfo.Any(_003C_003Ec__DisplayClass25_2._003CRunImport_003Eb__7))
						{
							num14 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num14 = 0;
							}
							break;
						}
						goto case 5;
					case 3:
						_003C_003Ec__DisplayClass25_2 = new _003C_003Ec__DisplayClass25_2();
						num14 = 2;
						break;
					}
				}
			});
			CS_0024_003C_003E8__locals1.removeList.ForEach(delegate(ManifestItem r)
			{
				int num11 = 1;
				int num12 = num11;
				while (true)
				{
					switch (num12)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.manifests.Remove(r);
						num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num12 = 0;
						}
						break;
					}
				}
			});
			if (CS_0024_003C_003E8__locals0.manifests.Count == 0)
			{
				return;
			}
			_003C_003Ec__DisplayClass25_3 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass25_3();
			CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals2.removeList = new List<ManifestItem>();
			CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.manifests.ForEach(delegate(ManifestItem ad)
			{
				//Discarded unreachable code: IL_00b3, IL_00c2
				int num9 = 3;
				int num10 = num9;
				_003C_003Ec__DisplayClass25_4 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_4);
				while (true)
				{
					switch (num10)
					{
					case 1:
						return;
					case 5:
						return;
					case 4:
						CS_0024_003C_003E8__locals2.removeList.Add(_003C_003Ec__DisplayClass25_.ad);
						num10 = 5;
						break;
					default:
						if (!CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.componentsInfo.Any(_003C_003Ec__DisplayClass25_._003CRunImport_003Eb__10))
						{
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num10 = 1;
							}
							break;
						}
						goto case 4;
					case 3:
						_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_4();
						num10 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num10 = 0;
						}
						break;
					case 2:
						_003C_003Ec__DisplayClass25_.ad = ad;
						num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num10 = 0;
						}
						break;
					}
				}
			});
			CS_0024_003C_003E8__locals2.removeList.ForEach(delegate(ManifestItem r)
			{
				int num7 = 1;
				int num8 = num7;
				while (true)
				{
					switch (num8)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals2.manifests.Remove(r);
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num8 = 0;
						}
						break;
					}
				}
			});
			if (CS_0024_003C_003E8__locals0.manifests.Count == 0)
			{
				return;
			}
			ManifestItem manifestItem = CS_0024_003C_003E8__locals0.manifests.FirstOrDefault();
			if (manifestItem == null)
			{
				return;
			}
			_003C_003Ec__DisplayClass25_5 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass25_5();
			CS_0024_003C_003E8__locals3.adManifest = manifestItem.Manifest;
			ModuleManager.StoreComponentConfigurationInfo storeComponentConfigurationInfo = CS_0024_003C_003E8__locals0.componentsInfo.FirstOrDefault((ModuleManager.StoreComponentConfigurationInfo i) => _003C_003Ec__DisplayClass25_5.BJL6aN837WDRXFFdq55P(i.Id, CS_0024_003C_003E8__locals3.adManifest.Id)) ?? new ModuleManager.StoreComponentConfigurationInfo(CS_0024_003C_003E8__locals0.moduleManager)
			{
				Id = CS_0024_003C_003E8__locals3.adManifest.Id,
				Title = CS_0024_003C_003E8__locals3.adManifest.Title,
				Status = StoreComponentStatus.Allowed,
				SemanticDeployVersion = CS_0024_003C_003E8__locals3.adManifest.SemanticVersion,
				Manifest = CS_0024_003C_003E8__locals3.adManifest
			};
			ConfigImportSettings importSettings = NewConfigImportSettings();
			UploadFile(manifestItem.ElmaFile, importSettings);
			storeComponentConfigurationInfo.SemanticDeployVersion = CS_0024_003C_003E8__locals3.adManifest.SemanticVersion;
			CS_0024_003C_003E8__locals0.moduleManager.UpdateAutoDeployComponentInfo(storeComponentConfigurationInfo, CS_0024_003C_003E8__locals3.adManifest.SemanticVersion);
			List<TestImportMessages> source = TestConfiguration(importSettings);
			if (source.Any(delegate(TestImportMessages m)
			{
				int num5 = 1;
				int num6 = num5;
				while (true)
				{
					switch (num6)
					{
					default:
						return _003C_003Ec.EZmjoX8NyahWvoNrTGCK(m) == TestImportMessagesType.Warning;
					case 1:
						if (_003C_003Ec.EZmjoX8NyahWvoNrTGCK(m) == TestImportMessagesType.Error)
						{
							return true;
						}
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num6 = 0;
						}
						break;
					}
				}
			}))
			{
				CS_0024_003C_003E8__locals0.localDeployLog.Info(CS_0024_003C_003E8__locals3.adManifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F303194) + CS_0024_003C_003E8__locals3.adManifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112472302));
				source.Where(delegate(TestImportMessages m)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							if (_003C_003Ec.EZmjoX8NyahWvoNrTGCK(m) == TestImportMessagesType.Error)
							{
								return true;
							}
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							return _003C_003Ec.EZmjoX8NyahWvoNrTGCK(m) == TestImportMessagesType.Warning;
						}
					}
				}).ForEach(delegate(TestImportMessages m)
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
							_003C_003Ec__DisplayClass25_0.xpKhom83hag7EI90TixH(CS_0024_003C_003E8__locals0.localDeployLog, _003C_003Ec__DisplayClass25_0.YJfDUp83bsplWYkjl9lA(m));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				});
				CS_0024_003C_003E8__locals0.moduleManager.UpdateAutoDeployComponentInfo(storeComponentConfigurationInfo, AutoDeployComponentStatus.Failed, CS_0024_003C_003E8__locals3.adManifest.SemanticVersion);
				CS_0024_003C_003E8__locals0.manifests.Remove(manifestItem);
				RunImport(CS_0024_003C_003E8__locals0.manifests, CS_0024_003C_003E8__locals0.localDeployLog);
			}
			else
			{
				RunImportStep0(importSettings, storeComponentConfigurationInfo, CS_0024_003C_003E8__locals0.localDeployLog);
			}
			CS_0024_003C_003E8__locals0.manifests.Remove(manifestItem);
			if (CS_0024_003C_003E8__locals0.manifests.Any())
			{
				RunImport(CS_0024_003C_003E8__locals0.manifests, CS_0024_003C_003E8__locals0.localDeployLog);
			}
		}
		else
		{
			CS_0024_003C_003E8__locals0.localDeployLog.Info(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766083958));
			ManifestItem manifestItem2 = CS_0024_003C_003E8__locals0.manifests.First((ManifestItem ad) => _003C_003Ec__DisplayClass25_0.JVhNyF83GCNp5hpKrmOR(_003C_003Ec__DisplayClass25_0.WInWMM83BumMFntwBWfp(ad), _003C_003Ec__DisplayClass25_0.zitm3k83WV9xdt9M4WK3(CS_0024_003C_003E8__locals0.componentInStep)));
			ElmaStoreComponentManifest manifest = manifestItem2.Manifest;
			ModuleManager.StoreComponentConfigurationInfo componentInStep = CS_0024_003C_003E8__locals0.componentInStep;
			if (manifest.SemanticVersion > componentInStep.SemanticDeployVersion)
			{
				CS_0024_003C_003E8__locals0.localDeployLog.Info(manifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307ED6F3) + manifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED835EA));
				CS_0024_003C_003E8__locals0.moduleManager.UpdateAutoDeployComponentInfo(componentInStep, AutoDeployComponentStatus.Step0, manifest.SemanticVersion);
			}
			if (manifest.SemanticVersion > componentInStep.SemanticDeployVersion)
			{
				CS_0024_003C_003E8__locals0.localDeployLog.Info(manifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852851418) + manifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69746214));
				CS_0024_003C_003E8__locals0.moduleManager.UpdateAutoDeployComponentInfo(componentInStep, AutoDeployComponentStatus.Failed, manifest.SemanticVersion);
				CS_0024_003C_003E8__locals0.manifests.Remove(manifestItem2);
				RunImport(CS_0024_003C_003E8__locals0.manifests, CS_0024_003C_003E8__locals0.localDeployLog);
			}
			ConfigImportSettings importSettings2 = NewConfigImportSettings();
			UploadFile(manifestItem2.ElmaFile, importSettings2);
			switch (CS_0024_003C_003E8__locals0.componentInStep.DeployStatus)
			{
			case AutoDeployComponentStatus.Step0:
				RunImportStep0(importSettings2, componentInStep, CS_0024_003C_003E8__locals0.localDeployLog);
				break;
			case AutoDeployComponentStatus.Step1:
				RunImportStep1(importSettings2, componentInStep, needRestart: false, CS_0024_003C_003E8__locals0.localDeployLog);
				break;
			case AutoDeployComponentStatus.Step2:
				RunImportStep2(importSettings2, componentInStep, needRestart: false, CS_0024_003C_003E8__locals0.localDeployLog);
				CS_0024_003C_003E8__locals0.manifests.Remove(manifestItem2);
				RunImport(CS_0024_003C_003E8__locals0.manifests, CS_0024_003C_003E8__locals0.localDeployLog);
				break;
			}
		}
	}

	private void RemoveEmptyComplexBpmApp(ManifestList manifestList, ManifestDeployLogger localDeployLog)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = default(_003C_003Ec__DisplayClass26_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass26_.localDeployLog = localDeployLog;
				num2 = 4;
				continue;
			case 1:
				_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass26_.manifestList = manifestList;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				return;
			case 2:
				break;
			}
			int num3;
			do
			{
				num3 = _003C_003Ec__DisplayClass26_.manifestList.All.Count();
				_003C_003Ec__DisplayClass26_.manifestList.All.Where(delegate(ManifestItem i)
				{
					//Discarded unreachable code: IL_0065, IL_0074, IL_0084
					int num4 = 2;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						default:
							if (_003C_003Ec.KfxWUO8NMHvIUrIjweFS(i.Manifest.BpmApps) <= 0)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num5 = 3;
								}
								break;
							}
							goto case 4;
						case 2:
							if (i.Manifest.BpmApps == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num5 = 1;
								}
								break;
							}
							goto default;
						case 4:
							return _003C_003Ec.pB7m3Z8NJq9RwGgCsVYW(i.Childs) == 0;
						case 1:
						case 3:
							return false;
						}
					}
				}).ToList()?.Distinct().ForEach(_003C_003Ec__DisplayClass26_._003CRemoveEmptyComplexBpmApp_003Eb__1);
			}
			while (num3 != _003C_003Ec__DisplayClass26_.manifestList.All.Count());
			num2 = 3;
		}
	}

	private void CutTree(ManifestList manifestList, ManifestDeployLogger localDeployLog)
	{
		//Discarded unreachable code: IL_00d4, IL_00e3, IL_0189, IL_019c, IL_01ab, IL_023e, IL_024d
		int num = 1;
		int num8 = default(int);
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_2 = default(_003C_003Ec__DisplayClass27_0);
		Dictionary<ElmaStoreComponentManifest, bool> dictionary = default(Dictionary<ElmaStoreComponentManifest, bool>);
		List<string> errors = default(List<string>);
		List<string> warnings = default(List<string>);
		List<ElmaStoreComponentManifest> incompatible = default(List<ElmaStoreComponentManifest>);
		List<ElmaStoreComponentManifest>.Enumerator enumerator = default(List<ElmaStoreComponentManifest>.Enumerator);
		ElmaStoreComponentManifest current = default(ElmaStoreComponentManifest);
		_003C_003Ec__DisplayClass27_1 _003C_003Ec__DisplayClass27_3 = default(_003C_003Ec__DisplayClass27_1);
		_003C_003Ec__DisplayClass27_3 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_3);
		List<ElmaStoreComponentManifest> list = default(List<ElmaStoreComponentManifest>);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 12:
					if (num8 == _003C_003Ec__DisplayClass27_2.manifestList.All.Count())
					{
						num2 = 9;
						continue;
					}
					goto case 21;
				case 5:
					ManifestValidationHelper.Check(dictionary, out errors, out warnings, out incompatible);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 2;
					}
					continue;
				case 23:
					try
					{
						while (true)
						{
							IL_012f:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 3;
								goto IL_00f2;
							}
							goto IL_010c;
							IL_00f2:
							while (true)
							{
								switch (num5)
								{
								case 2:
									goto IL_012f;
								case 1:
								{
									dictionary.Add(current, value: false);
									int num6 = 2;
									num5 = num6;
									continue;
								}
								case 3:
									goto end_IL_012f;
								}
								break;
							}
							goto IL_010c;
							IL_010c:
							current = enumerator.Current;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num5 = 1;
							}
							goto IL_00f2;
							continue;
							end_IL_012f:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				case 24:
					return;
				case 3:
					_003C_003Ec__DisplayClass27_3.incompatible = new List<ManifestItem>();
					num2 = 13;
					continue;
				case 25:
					l3eGbYEHP1DTHug84kr8(_003C_003Ec__DisplayClass27_2.localDeployLog, string.Join((string)aWVUCHEH1JrRmbJ8vw14(), errors.Concat(warnings)));
					num2 = 12;
					continue;
				case 2:
					if (incompatible == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 22;
				case 15:
					RemoveEmptyComplexBpmApp(_003C_003Ec__DisplayClass27_2.manifestList, _003C_003Ec__DisplayClass27_2.localDeployLog);
					num = 21;
					break;
				case 21:
					_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_3();
					num = 10;
					break;
				case 16:
					list = Locator.GetServiceNotNull<IModuleDTOManager>().GetInstalledComponentManifests().ToList();
					num2 = 11;
					continue;
				case 4:
					RemoveEmptyComplexBpmApp(_003C_003Ec__DisplayClass27_2.manifestList, _003C_003Ec__DisplayClass27_2.localDeployLog);
					num2 = 6;
					continue;
				case 1:
					_003C_003Ec__DisplayClass27_2 = new _003C_003Ec__DisplayClass27_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					num3 = _003C_003Ec__DisplayClass27_2.manifestList.All.Count();
					num2 = 4;
					continue;
				default:
					_003C_003Ec__DisplayClass27_2.localDeployLog = localDeployLog;
					num2 = 19;
					continue;
				case 19:
					_003C_003Ec__DisplayClass27_2.manifestList = manifestList;
					num2 = 16;
					continue;
				case 20:
					enumerator = _003C_003Ec__DisplayClass27_.componentsToInstall.GetEnumerator();
					num2 = 23;
					continue;
				case 18:
					_003C_003Ec__DisplayClass27_3.incompatible.Distinct().ToList().ForEach(_003C_003Ec__DisplayClass27_2._003CCutTree_003Eb__2);
					num2 = 14;
					continue;
				case 11:
					_003C_003Ec__DisplayClass27_3 = new _003C_003Ec__DisplayClass27_1();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					if (num3 == _003C_003Ec__DisplayClass27_2.manifestList.All.Count())
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 14;
				case 10:
					num8 = _003C_003Ec__DisplayClass27_2.manifestList.All.Count();
					num2 = 17;
					continue;
				case 13:
					(from i in _003C_003Ec__DisplayClass27_2.manifestList.All
						group i by i.Id).ForEach(_003C_003Ec__DisplayClass27_3._003CCutTree_003Eb__1);
					num2 = 18;
					continue;
				case 6:
				{
					int num4;
					do
					{
						num4 = _003C_003Ec__DisplayClass27_2.manifestList.All.Count();
						ManifestValidationHelper.CheckByDependencies(_003C_003Ec__DisplayClass27_2.manifestList.All.Select((ManifestItem i) => (ElmaStoreComponentManifest)_003C_003Ec.IRBpym8NdQqXDcD4ScPp(i)).ToList(), list, out var incompatible2, out var errors2);
						if (incompatible2 != null)
						{
							incompatible2.Distinct().ToList().ForEach(_003C_003Ec__DisplayClass27_2._003CCutTree_003Eb__7);
							l3eGbYEHP1DTHug84kr8(_003C_003Ec__DisplayClass27_2.localDeployLog, string.Join(Environment.NewLine, errors2));
						}
					}
					while (num4 != _003C_003Ec__DisplayClass27_2.manifestList.All.Count());
					num2 = 15;
					continue;
				}
				case 17:
					_003C_003Ec__DisplayClass27_.componentsToInstall = _003C_003Ec__DisplayClass27_2.manifestList.All.Select((ManifestItem i) => (ElmaStoreComponentManifest)_003C_003Ec.IRBpym8NdQqXDcD4ScPp(i)).ToList();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					dictionary = list.Where(_003C_003Ec__DisplayClass27_._003CCutTree_003Eb__9).Distinct().ToDictionary((ElmaStoreComponentManifest c) => c, (ElmaStoreComponentManifest c) => true);
					num = 20;
					break;
				case 22:
					incompatible.Distinct().ToList().ForEach(_003C_003Ec__DisplayClass27_2._003CCutTree_003Eb__12);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 25;
					}
					continue;
				}
				break;
			}
		}
	}

	private List<ManifestList> BuildTree(string autoDeployPath, out ICollection<IDeployResult> moduleDeployResults)
	{
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals0.autoDeployPath = autoDeployPath;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		ITagService serviceNotNull = Locator.GetServiceNotNull<ITagService>();
		moduleDeployResults = new List<IDeployResult>();
		CS_0024_003C_003E8__locals0.autoDeployFilesDict = new Dictionary<AutoDeployFile, string>();
		using (IEnumerator<string> enumerator = AutoDeployMasks.SelectMany((string mask) => Directory.GetFiles(CS_0024_003C_003E8__locals0.autoDeployPath, mask)).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass28_1 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass28_1();
				CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals3.deployFile = enumerator.Current;
				int num = 0;
				while (num++ < 10)
				{
					try
					{
						XmlSerializer<List<AutoDeployFile>>.DeserializeFromFile(CS_0024_003C_003E8__locals3.deployFile)?.ForEach(delegate(AutoDeployFile adFile)
						{
							int num6 = 2;
							int num7 = num6;
							_003C_003Ec__DisplayClass28_2 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_2);
							while (true)
							{
								switch (num7)
								{
								case 2:
									_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_2();
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num7 = 1;
									}
									break;
								case 3:
									return;
								case 4:
									CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals1.autoDeployFilesDict[_003C_003Ec__DisplayClass28_.adFile] = CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals1._003C_003E4__this.GetModulePath(CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals1.autoDeployPath, CS_0024_003C_003E8__locals3.deployFile);
									num7 = 3;
									break;
								case 1:
									_003C_003Ec__DisplayClass28_.adFile = adFile;
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num7 = 0;
									}
									break;
								default:
									if (CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals1.autoDeployFilesDict.Keys.Any(_003C_003Ec__DisplayClass28_._003CBuildTree_003Eb__2))
									{
										return;
									}
									num7 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num7 = 4;
									}
									break;
								}
							}
						});
					}
					catch (IOException ex)
					{
						DeployLog.Warn(ex.Message);
						Thread.Sleep(300);
						continue;
					}
					catch (Exception message)
					{
						DeployLog.Error(message);
					}
					break;
				}
			}
		}
		List<ManifestList> list = new List<ManifestList>();
		_003C_003Ec__DisplayClass28_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass28_3();
		CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
		CS_0024_003C_003E8__locals1.elmaFiles = Directory.GetFiles(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.autoDeployPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112471180)).ToList();
		ElmaStoreComponentFile.SupportedComponentMask.ForEach(delegate(string mask)
		{
			int num4 = 1;
			int num5 = num4;
			while (true)
			{
				switch (num5)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals1.elmaFiles.AddRange(Directory.GetFiles(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.autoDeployPath, mask));
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num5 = 0;
					}
					break;
				}
			}
		});
		foreach (string elmaFile in CS_0024_003C_003E8__locals1.elmaFiles)
		{
			_003C_003Ec__DisplayClass28_4 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass28_4();
			ManifestList manifestList = new ManifestList();
			CS_0024_003C_003E8__locals2.manifestFile = Path.Combine(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.autoDeployPath, Path.ChangeExtension(Path.GetFileName(elmaFile), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103B796F)));
			string value = new string[1] { CS_0024_003C_003E8__locals2.manifestFile }.Union(ElmaStoreComponentFile.SupportedComponentExtension.Select((string ext) => Path.ChangeExtension(CS_0024_003C_003E8__locals2.manifestFile, ext))).FirstOrDefault(File.Exists);
			CS_0024_003C_003E8__locals2.manifest = null;
			if (string.IsNullOrEmpty(value))
			{
				try
				{
					CS_0024_003C_003E8__locals2.manifest = ElmaStoreComponentsBuilder.Read(elmaFile);
					if (CS_0024_003C_003E8__locals2.manifest != null)
					{
						ManifestBuilder.SerializeByXmlToFile<ElmaStoreComponentManifest>(CS_0024_003C_003E8__locals2.manifest, CS_0024_003C_003E8__locals2.manifestFile);
					}
				}
				catch (Exception message2)
				{
					DeployLog.Error(message2);
				}
			}
			else
			{
				try
				{
					string xml = File.ReadAllText(CS_0024_003C_003E8__locals2.manifestFile);
					CS_0024_003C_003E8__locals2.manifest = ManifestBuilder.DeserializeByXml<ElmaStoreComponentManifest>(xml);
				}
				catch (Exception message3)
				{
					DeployLog.Error(message3);
				}
			}
			if (CS_0024_003C_003E8__locals2.manifest == null)
			{
				continue;
			}
			AutoDeployFile autoDeployFile = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.autoDeployFilesDict.Keys.FirstOrDefault(delegate(AutoDeployFile adF)
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						if (!_003C_003Ec__DisplayClass28_4.uPPlVn8p0hvHl6fxwUrB(_003C_003Ec__DisplayClass28_4.euCoxh8p762Walb1jT9k(adF), _003C_003Ec__DisplayClass28_4.wnalgw8pxFRwP5QLFaRT(CS_0024_003C_003E8__locals2.manifest)))
						{
							return false;
						}
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num3 = 0;
						}
						break;
					default:
						return (SemanticVersion)_003C_003Ec__DisplayClass28_4.jJEqJX8pmhbGdlPNdpBY(adF) == CS_0024_003C_003E8__locals2.manifest.SemanticVersion;
					}
				}
			});
			if (autoDeployFile == null || !serviceNotNull.ValidateTags(CS_0024_003C_003E8__locals2.manifest))
			{
				continue;
			}
			string text = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.autoDeployFilesDict[autoDeployFile];
			bool flag = CS_0024_003C_003E8__locals2.manifest.Id != ModuleMetadataItemHeaderManager.WebDesignerPackageName;
			if (flag)
			{
				IDeployResult deployResult = InstallModule(elmaFile, text);
				if (deployResult != null)
				{
					moduleDeployResults.Add(deployResult);
					continue;
				}
			}
			ManifestItem manifestItem = new ManifestItem
			{
				ElmaFile = elmaFile,
				ManifestFile = CS_0024_003C_003E8__locals2.manifestFile,
				Manifest = CS_0024_003C_003E8__locals2.manifest
			};
			manifestList.DeployDirectory = text;
			manifestList.Add(manifestItem, null);
			if (CS_0024_003C_003E8__locals2.manifest.BpmApps != null && CS_0024_003C_003E8__locals2.manifest.BpmApps.Any() && flag)
			{
				ExtractComplexBpmApp(manifestItem, manifestList, 0, DefaultSubmodulesPath(text));
			}
			list.Add(manifestList);
		}
		return list;
	}

	private IDeployResult InstallModule(string componentPath, string deployFileDir)
	{
		//Discarded unreachable code: IL_010a, IL_013c, IL_01a1, IL_01b8, IL_01c7
		int num = 4;
		_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_0);
		IDeployResult result = default(IDeployResult);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass29_.moduleFileDeployService = Locator.GetServiceNotNull<IModuleFileDeployService>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					zTFFxPEHNLZQw4YKiTA8(_003C_003Ec__DisplayClass29_.localDeployLogger);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass29_.componentPath = componentPath;
					num2 = 2;
					continue;
				default:
					return new StandardAutoDeployResult(_003C_003Ec__DisplayClass29_.localDeployLogger.HasErrors, (string)KHq1BEEH3SVlp8VHoye5(_003C_003Ec__DisplayClass29_.localDeployLogger));
				case 6:
					try
					{
						Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser(_003C_003Ec__DisplayClass29_._003CInstallModule_003Eb__0);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (ModuleValidationException)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
								result = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
					catch (Exception exception)
					{
						zTFFxPEHNLZQw4YKiTA8(_003C_003Ec__DisplayClass29_.localDeployLogger);
						result = new ExceptionAutoDeployResult(exception);
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num5 = 0;
						}
						return num5 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					goto case 5;
				case 1:
					break;
				}
				break;
			}
			_003C_003Ec__DisplayClass29_.localDeployLogger = new ManifestDeployLogger(deployFileDir);
			num = 6;
		}
	}

	private void ExtractComplexBpmApp(ManifestItem parent, ManifestList manifests, int level, string submodulesPath)
	{
		//Discarded unreachable code: IL_017d, IL_018c, IL_01f2, IL_0212, IL_04b4, IL_051c, IL_055d, IL_05f8, IL_062a, IL_0677, IL_0686, IL_06d5, IL_0716
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		int num = 10;
		List<ManifestItem> list = default(List<ManifestItem>);
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = default(_003C_003Ec__DisplayClass30_0);
		int level2 = default(int);
		ITagService serviceNotNull = default(ITagService);
		IEnumerator enumerator = default(IEnumerator);
		ZipEntry val2 = default(ZipEntry);
		_003C_003Ec__DisplayClass30_1 _003C_003Ec__DisplayClass30_2 = default(_003C_003Ec__DisplayClass30_1);
		ElmaStoreComponentManifest elmaStoreComponentManifest = default(ElmaStoreComponentManifest);
		string text = default(string);
		ManifestItem item = default(ManifestItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!list.Any())
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 2;
				case 4:
					if (_003C_003Ec__DisplayClass30_.level > 100)
					{
						num2 = 6;
						continue;
					}
					list = new List<ManifestItem>();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass30_.level = level2 + 1;
					num2 = 4;
					continue;
				case 10:
					break;
				case 1:
					_003C_003Ec__DisplayClass30_.submodulesPath = submodulesPath;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 9;
					}
					continue;
				case 6:
					throw new NestingLevelException((ElmaStoreComponentManifest)eEg7RYEHp9enp1ZOpsPr(parent));
				case 3:
					_003C_003Ec__DisplayClass30_.level = level;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass30_._003C_003E4__this = this;
					num2 = 13;
					continue;
				case 12:
					level2 = _003C_003Ec__DisplayClass30_.level;
					num2 = 11;
					continue;
				case 14:
					serviceNotNull = Locator.GetServiceNotNull<ITagService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					return;
				case 2:
					list.ForEach(_003C_003Ec__DisplayClass30_._003CExtractComplexBpmApp_003Eb__0);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					try
					{
						ZipFile val = new ZipFile((FileStream)EgCQnbEHaBLQNeA5O7kD(parent.ElmaFile));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								try
								{
									while (true)
									{
										IL_0302:
										int num4;
										if (!WjTNqFEHmyuN4l9PdKJN(enumerator))
										{
											num4 = 4;
											goto IL_0220;
										}
										goto IL_02e6;
										IL_05bf:
										int num5 = 11;
										goto IL_021c;
										IL_02e6:
										val2 = (ZipEntry)enumerator.Current;
										num5 = 3;
										goto IL_021c;
										IL_021c:
										num4 = num5;
										goto IL_0220;
										IL_0220:
										while (true)
										{
											switch (num4)
											{
											case 6:
												if (dgvyvNEHwRjMh09Anw8G(val2.get_Name(), NOqQvoEHqpypsttIQ10j(-1867198571 ^ -1867489361)))
												{
													num4 = 4;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
													{
														num4 = 15;
													}
													continue;
												}
												goto IL_0302;
											case 12:
												_003C_003Ec__DisplayClass30_2.elmaFile = (string)PKUS72EHKKn6swMQ9jxy(_003C_003Ec__DisplayClass30_.submodulesPath, Path.GetFileName((string)RwWhQgEHtqd4bO8LLo0p(val2)));
												num4 = 5;
												continue;
											default:
												elmaStoreComponentManifest = ElmaStoreComponentsBuilder.Read(_003C_003Ec__DisplayClass30_2.elmaFile);
												num4 = 10;
												continue;
											case 8:
												break;
											case 7:
												goto IL_0302;
											case 14:
												if (pv8nP9EHHR977VViicvI(_003C_003Ec__DisplayClass30_2.elmaFile))
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto IL_0302;
											case 5:
												_003C_003Ec__DisplayClass30_2.buffer = new byte[4096];
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
												{
													num4 = 9;
												}
												continue;
											case 9:
												kQxNmfEH6xGgXBIqWvGO(_003C_003Ec__DisplayClass30_2.elmaFile, new Action(_003C_003Ec__DisplayClass30_2._003CExtractComplexBpmApp_003Eb__1));
												num4 = 14;
												continue;
											case 13:
												try
												{
													int num6;
													if (!serviceNotNull.ValidateTags(elmaStoreComponentManifest))
													{
														num6 = 2;
														goto IL_03ae;
													}
													goto IL_0456;
													IL_03ae:
													while (true)
													{
														switch (num6)
														{
														case 3:
															ManifestBuilder.SerializeByXmlToFile<ElmaStoreComponentManifest>(elmaStoreComponentManifest, text);
															num6 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
															{
																num6 = 7;
															}
															continue;
														case 7:
														{
															ManifestItem manifestItem = new ManifestItem();
															OfJearEHAAdIBdNrOlXl(manifestItem, _003C_003Ec__DisplayClass30_2.elmaFile);
															S5bYQREH7cN23w1tnCca(manifestItem, text);
															gV1OoCEHxmRhFhdytSU3(manifestItem, elmaStoreComponentManifest);
															item = manifestItem;
															num6 = 5;
															continue;
														}
														case 5:
															_003C_003Ec__DisplayClass30_.manifests.Add(item, parent);
															num6 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
															{
																num6 = 0;
															}
															continue;
														case 4:
															break;
														case 1:
															if (elmaStoreComponentManifest.BpmApps.Any())
															{
																num6 = 8;
																continue;
															}
															goto end_IL_03ae;
														case 2:
															goto end_IL_03ae;
														case 8:
														{
															list.Add(item);
															int num7 = 6;
															num6 = num7;
															continue;
														}
														default:
															if (elmaStoreComponentManifest.BpmApps != null)
															{
																num6 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
																{
																	num6 = 1;
																}
																continue;
															}
															goto end_IL_03ae;
														case 6:
															goto end_IL_03ae;
														}
														goto IL_0456;
														continue;
														end_IL_03ae:
														break;
													}
													goto end_IL_0392;
													IL_0456:
													text = Path.ChangeExtension(_003C_003Ec__DisplayClass30_2.elmaFile, (string)NOqQvoEHqpypsttIQ10j(-889460160 ^ -889226662));
													num6 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
													{
														num6 = 2;
													}
													goto IL_03ae;
													end_IL_0392:;
												}
												catch (Exception ex)
												{
													int num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
													{
														num8 = 1;
													}
													while (true)
													{
														switch (num8)
														{
														case 1:
															nMJMoUEH0eDCbhCnTPxp(DeployLog, ex);
															num8 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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
												goto IL_0302;
											case 11:
											case 15:
												_003C_003Ec__DisplayClass30_2.packageStream = (Stream)XXqqjREH4Pd3I6vEX0vH(val, val2);
												num4 = 12;
												continue;
											case 3:
												_003C_003Ec__DisplayClass30_2 = new _003C_003Ec__DisplayClass30_1();
												num4 = 2;
												continue;
											case 10:
												if (elmaStoreComponentManifest != null)
												{
													num4 = 13;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto IL_0302;
											case 1:
												if (RwWhQgEHtqd4bO8LLo0p(val2) != null)
												{
													goto case 6;
												}
												goto IL_05bf;
											case 2:
												if (el39dPEHDAcwTC17mG5u(val2))
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
													{
														num4 = 1;
													}
													continue;
												}
												goto IL_0302;
											case 4:
												goto end_IL_0302;
											}
											break;
										}
										goto IL_02e6;
										continue;
										end_IL_0302:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									int num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
									{
										num9 = 1;
									}
									while (true)
									{
										switch (num9)
										{
										default:
											giHBgjEHyf9EtQfU73UZ(disposable);
											num9 = 2;
											continue;
										case 1:
											if (disposable != null)
											{
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
												{
													num9 = 0;
												}
												continue;
											}
											break;
										case 2:
											break;
										}
										break;
									}
								}
								break;
							default:
								enumerator = val.GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					catch (Exception ex2)
					{
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								nMJMoUEH0eDCbhCnTPxp(DeployLog, ex2);
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num10 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 5;
				case 13:
					_003C_003Ec__DisplayClass30_.manifests = manifests;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return;
				}
				break;
			}
			_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
			num = 9;
		}
	}

	private ConfigImportSettings NewConfigImportSettings()
	{
		return new ConfigImportSettings();
	}

	private void RunImportStep0(ConfigImportSettings importSettings, ModuleManager.StoreComponentConfigurationInfo info, ManifestDeployLogger localDeployLog)
	{
		//Discarded unreachable code: IL_0066, IL_0075
		int num = 2;
		int num2 = num;
		ModuleManager moduleManager = default(ModuleManager);
		while (true)
		{
			switch (num2)
			{
			default:
				oXIRq5EHldEscgOZlows(moduleManager, info, AutoDeployComponentStatus.Step0);
				num2 = 5;
				break;
			case 7:
				if (moduleManager == null)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 1:
				Qj7YjFEH9janHmOe7nDE(importSettings, 0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				JqyCBIEHJGP42TxqAQkb(localDeployLog, (string)NOqQvoEHqpypsttIQ10j(0x76DD48E ^ 0x76944EE) + info.Id + (string)NOqQvoEHqpypsttIQ10j(0x48A7E34A ^ 0x48A7AA68) + (string)xKpfDTEHM189vcR3v33Y(info));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				moduleManager = ((ComponentManager)HRO8ZqEHdwn904xXTMVA()).ModuleManager as ModuleManager;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				return;
			case 5:
			case 6:
				ImportConfiguration(importSettings, info, localDeployLog);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void RunImportStep1(ConfigImportSettings importSettings, ModuleManager.StoreComponentConfigurationInfo info, bool needRestart, ManifestDeployLogger localDeployLog)
	{
		//Discarded unreachable code: IL_018a, IL_0199, IL_01ee, IL_01fd
		int num = 11;
		int num2 = num;
		ModuleManager moduleManager = default(ModuleManager);
		while (true)
		{
			switch (num2)
			{
			case 12:
				mp0bQjEHjeGXgJXn4777(10000);
				num2 = 7;
				continue;
			case 11:
				localDeployLog.Info(n8PorTEHgLB56ynpr3o4(NOqQvoEHqpypsttIQ10j(--1333735954 ^ 0x4F7BA268), E9Lm23EHrhMrUMuVHPw5(info), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFEB148), xKpfDTEHM189vcR3v33Y(info)));
				num2 = 10;
				continue;
			case 6:
				JqyCBIEHJGP42TxqAQkb(localDeployLog, n8PorTEHgLB56ynpr3o4(NOqQvoEHqpypsttIQ10j(-643786247 ^ -643561107), E9Lm23EHrhMrUMuVHPw5(info), NOqQvoEHqpypsttIQ10j(-2138958856 ^ -2138940710), xKpfDTEHM189vcR3v33Y(info)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 2;
				}
				continue;
			case 10:
				importSettings.ImportStep = 1;
				num2 = 9;
				continue;
			case 3:
			case 4:
				if (!needRestart)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 7:
				return;
			default:
				ImportConfiguration(importSettings, info, localDeployLog);
				num2 = 5;
				continue;
			case 5:
				return;
			case 9:
				moduleManager = Kfq8epEH57Y9qFGongHo(ComponentManager.Current) as ModuleManager;
				num2 = 8;
				continue;
			case 2:
				Locator.GetServiceNotNull<WebHostEnvironmentManager>().RestartHost();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 12;
				}
				continue;
			case 8:
				if (moduleManager == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 1:
				break;
			}
			oXIRq5EHldEscgOZlows(moduleManager, info, AutoDeployComponentStatus.Step1);
			num2 = 4;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
			{
				num2 = 4;
			}
		}
	}

	private void RunImportStep2(ConfigImportSettings importSettings, ModuleManager.StoreComponentConfigurationInfo info, bool needRestart, ManifestDeployLogger localDeployLog)
	{
		//Discarded unreachable code: IL_0079, IL_0157
		int num = 7;
		ModuleManager moduleManager = default(ModuleManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					oXIRq5EHldEscgOZlows(moduleManager, info, AutoDeployComponentStatus.Step2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					mp0bQjEHjeGXgJXn4777(10000);
					num2 = 5;
					continue;
				case 5:
					return;
				case 9:
					ImportConfiguration(importSettings, info, localDeployLog);
					num2 = 8;
					continue;
				case 11:
					if (moduleManager == null)
					{
						num2 = 3;
						continue;
					}
					goto case 10;
				case 4:
					J4jttoEHYjjyqvlNEvch(Locator.GetServiceNotNull<WebHostEnvironmentManager>());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					break;
				case 8:
					return;
				case 1:
				case 3:
					if (!needRestart)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 2;
				case 6:
					Qj7YjFEH9janHmOe7nDE(importSettings, 2);
					num2 = 12;
					continue;
				case 2:
					JqyCBIEHJGP42TxqAQkb(localDeployLog, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F34E85A) + (string)E9Lm23EHrhMrUMuVHPw5(info) + (string)NOqQvoEHqpypsttIQ10j(-561074844 ^ -561060794) + info.DeployVersion);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					moduleManager = ((ComponentManager)HRO8ZqEHdwn904xXTMVA()).ModuleManager as ModuleManager;
					num2 = 11;
					continue;
				}
				break;
			}
			JqyCBIEHJGP42TxqAQkb(localDeployLog, (string)NOqQvoEHqpypsttIQ10j(-1765851862 ^ -1766085128) + (string)E9Lm23EHrhMrUMuVHPw5(info) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477158152) + info.DeployVersion);
			num = 6;
		}
	}

	private void ImportConfiguration(ConfigImportSettings importSettings, ModuleManager.StoreComponentConfigurationInfo info, ManifestDeployLogger localDeployLog)
	{
		//Discarded unreachable code: IL_0142, IL_0229, IL_0238, IL_02bc, IL_02cb, IL_0339, IL_03a3
		int num = 22;
		ModuleManager moduleManager = default(ModuleManager);
		ModuleManager moduleManager2 = default(ModuleManager);
		List<DeployLogMessage> importLog = default(List<DeployLogMessage>);
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		IExportImportFileManager serviceNotNull = default(IExportImportFileManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 27:
					if (moduleManager == null)
					{
						num2 = 8;
						continue;
					}
					goto case 33;
				case 0:
					return;
				case 4:
					return;
				case 13:
					mp0bQjEHjeGXgJXn4777(1000);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					continue;
				case 23:
					oXIRq5EHldEscgOZlows(moduleManager2, info, AutoDeployComponentStatus.Complete);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					if (moduleManager2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 23;
				case 1:
				case 32:
					importLog = _003C_003Ec__DisplayClass35_.deployManager.GetImportLog(_003C_003Ec__DisplayClass35_.importUid);
					num2 = 10;
					continue;
				case 5:
					_003C_003Ec__DisplayClass35_.deployManager = Locator.GetServiceNotNull<IDeployManager>();
					num2 = 2;
					continue;
				case 2:
					_003C_003Ec__DisplayClass35_.importUid = Guid.Empty;
					num2 = 19;
					continue;
				case 19:
					EHMLoMEHL8QvEi9cUkIJ(Locator.GetServiceNotNull<ISecurityService>(), new Action(_003C_003Ec__DisplayClass35_._003CImportConfiguration_003Eb__0));
					num2 = 32;
					continue;
				case 18:
					return;
				case 16:
					serviceNotNull.DeleteFiles((string)APmZXaEHUBZXK5EnIhLK(_003C_003Ec__DisplayClass35_.importSettings));
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 13;
					}
					continue;
				case 17:
					return;
				case 14:
				case 15:
					if (M8CoEOEHsiUNqJZ9ePYD(_003C_003Ec__DisplayClass35_.importSettings) == 1)
					{
						num = 6;
						break;
					}
					goto IL_019a;
				case 25:
					serviceNotNull = Locator.GetServiceNotNull<IExportImportFileManager>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 9;
					}
					continue;
				case 31:
					_003C_003Ec__DisplayClass35_.localDeployLog = localDeployLog;
					num = 5;
					break;
				case 8:
					return;
				case 11:
					return;
				case 24:
					l3eGbYEHP1DTHug84kr8(_003C_003Ec__DisplayClass35_.localDeployLog, n8PorTEHgLB56ynpr3o4(NOqQvoEHqpypsttIQ10j(-2138958856 ^ -2138668334), E9Lm23EHrhMrUMuVHPw5(info), NOqQvoEHqpypsttIQ10j(-812025778 ^ -812043924), info.DeployVersion));
					num2 = 20;
					continue;
				case 21:
					_003C_003Ec__DisplayClass35_.importSettings = importSettings;
					num = 31;
					break;
				case 7:
					moduleManager2 = ((ComponentManager)HRO8ZqEHdwn904xXTMVA()).ModuleManager as ModuleManager;
					num2 = 12;
					continue;
				case 33:
					moduleManager.UpdateAutoDeployComponentInfo(info, AutoDeployComponentStatus.Failed);
					num2 = 11;
					continue;
				case 3:
					serviceNotNull.DeleteFiles((string)APmZXaEHUBZXK5EnIhLK(_003C_003Ec__DisplayClass35_.importSettings));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 10;
					}
					continue;
				case 30:
					moduleManager = Kfq8epEH57Y9qFGongHo(HRO8ZqEHdwn904xXTMVA()) as ModuleManager;
					num2 = 27;
					continue;
				case 10:
					if (!importLog.Any((DeployLogMessage m) => _003C_003Ec.TtMQgZ8NlU6v9c1cJDEx(m)))
					{
						num2 = 13;
						continue;
					}
					goto case 25;
				case 9:
					if (!importLog.Any((DeployLogMessage m) => _003C_003Ec.tpHVJE8NrBt81e9BZeGI(m) == DeployLogMessageType.Error))
					{
						if (_003C_003Ec__DisplayClass35_.importSettings.ImportStep != 0)
						{
							num2 = 15;
							continue;
						}
						goto case 26;
					}
					num2 = 24;
					continue;
				case 20:
					importLog.ForEach(_003C_003Ec__DisplayClass35_._003CImportConfiguration_003Eb__7);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 12;
					}
					continue;
				case 26:
					if (!importLog.Any((DeployLogMessage m) => _003C_003Ec.IAQQjB8NgvMgyGb4P8yP(m)))
					{
						num2 = 14;
						continue;
					}
					goto case 29;
				case 29:
					RunImportStep1(_003C_003Ec__DisplayClass35_.importSettings, info, importLog.Any((DeployLogMessage m) => _003C_003Ec.OX8L3H8N5UCFjVeLakX7(m)), _003C_003Ec__DisplayClass35_.localDeployLog);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					if (importLog.Any((DeployLogMessage m) => _003C_003Ec.IAQQjB8NgvMgyGb4P8yP(m)))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto IL_019a;
				case 28:
					{
						RunImportStep2(_003C_003Ec__DisplayClass35_.importSettings, info, importLog.Any((DeployLogMessage m) => _003C_003Ec.OX8L3H8N5UCFjVeLakX7(m)), _003C_003Ec__DisplayClass35_.localDeployLog);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					IL_019a:
					_003C_003Ec__DisplayClass35_.localDeployLog.Info(n8PorTEHgLB56ynpr3o4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858653971), info.Id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BE7A8), info.DeployVersion));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private List<TestImportMessages> TestConfiguration(ConfigImportSettings importSettings)
	{
		_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass36_0();
		CS_0024_003C_003E8__locals0.importSettings = importSettings;
		List<TestImportMessages> list = new List<TestImportMessages>();
		CS_0024_003C_003E8__locals0.deployManager = Locator.GetServiceNotNull<IDeployManager>();
		CS_0024_003C_003E8__locals0.testUid = Guid.Empty;
		Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser(delegate
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
					CS_0024_003C_003E8__locals0.testUid = CS_0024_003C_003E8__locals0.deployManager.TestConfiguration(CS_0024_003C_003E8__locals0.importSettings);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		while (true)
		{
			list.AddRange(CS_0024_003C_003E8__locals0.deployManager.GetTestLog(CS_0024_003C_003E8__locals0.testUid));
			if (list.Any((TestImportMessages m) => m.Type == TestImportMessagesType.Finish))
			{
				break;
			}
			Thread.Sleep(1000);
		}
		return list;
	}

	private void UploadFile(string localFileName, ConfigImportSettings importSettings)
	{
		//Discarded unreachable code: IL_0183, IL_01ae, IL_01bd, IL_01cc, IL_0220, IL_022f, IL_025e, IL_027d, IL_028c, IL_02b9, IL_02c8
		int num = 2;
		int num2 = num;
		IExportImportFileService serviceNotNull = default(IExportImportFileService);
		string text = default(string);
		FileStream fileStream = default(FileStream);
		byte[] array = default(byte[]);
		long num6 = default(long);
		long length = default(long);
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<IExportImportFileService>();
				num2 = 3;
				break;
			case 2:
				text = (string)APmZXaEHUBZXK5EnIhLK(importSettings);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				try
				{
					long num4 = cm5T2iEHz2woyumPFvjq(serviceNotNull);
					int num5 = 14;
					while (true)
					{
						long num7;
						switch (num5)
						{
						case 11:
							return;
						case 12:
							return;
						case 13:
							return;
						case 7:
							VTjvT1EAFSOhAdjWcNH9(fileStream, array, 0, array.Length);
							num5 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num5 = 8;
							}
							continue;
						case 4:
						{
							array = new byte[num6];
							int num8 = 7;
							num5 = num8;
							continue;
						}
						case 8:
							i9UNsOEABK2KFXZgmeYD(serviceNotNull, text, array);
							num5 = 9;
							continue;
						case 2:
							length = fileStream.Length;
							num5 = 5;
							continue;
						case 6:
							if ((num3 + 1) * num4 >= length)
							{
								num5 = 3;
								continue;
							}
							num7 = num4;
							break;
						case 1:
							if (num3 == long.MaxValue)
							{
								num5 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
								{
									num5 = 4;
								}
								continue;
							}
							goto case 6;
						case 3:
							num7 = length - num3 * num4;
							break;
						case 9:
							num3++;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num5 = 0;
							}
							continue;
						case 10:
							if (num6 <= 0)
							{
								num5 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num5 = 7;
								}
								continue;
							}
							goto case 4;
						default:
							if (num6 <= 0)
							{
								num5 = 11;
								continue;
							}
							goto case 1;
						case 14:
							num6 = num4;
							num5 = 2;
							continue;
						}
						num6 = num7;
						num5 = 10;
					}
				}
				finally
				{
					int num9;
					if (fileStream == null)
					{
						num9 = 2;
						goto IL_0262;
					}
					goto IL_0297;
					IL_0262:
					switch (num9)
					{
					default:
						goto end_IL_024d;
					case 2:
						goto end_IL_024d;
					case 1:
						break;
					case 0:
						goto end_IL_024d;
					}
					goto IL_0297;
					IL_0297:
					giHBgjEHyf9EtQfU73UZ(fileStream);
					num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num9 = 0;
					}
					goto IL_0262;
					end_IL_024d:;
				}
			default:
				fileStream = new FileStream(localFileName, FileMode.Open, FileAccess.Read);
				num2 = 6;
				break;
			case 4:
				num3 = 0L;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				GGwyc7EHcrnMRSFMRucG(serviceNotNull, text);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private List<ManifestItem> GetSortedManifestList(IEnumerable<ManifestItem> items)
	{
		_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_0();
		List<string> list = new List<string>();
		HashSet<string> hashSet = new HashSet<string>();
		HashSet<string> other = items.Select((ManifestItem h) => ((ElmaStoreComponentManifest)_003C_003Ec.IRBpym8NdQqXDcD4ScPp(h)).Id).ToHashSet();
		Dictionary<string, ISet<string>> dictionary = new Dictionary<string, ISet<string>>();
		items.Select((ManifestItem i) => (ElmaStoreComponentManifest)_003C_003Ec.IRBpym8NdQqXDcD4ScPp(i)).ToList();
		foreach (ManifestItem item in items)
		{
			string id = item.Manifest.Id;
			if (item.Manifest.Dependencies != null)
			{
				HashSet<string> hashSet2 = item.Manifest.Dependencies.Select((ElmaStoreComponentDependency d) => (string)_003C_003Ec.A3y6UJ8Njx1J1guH1f3H(d)).ToHashSet();
				hashSet2.IntersectWith(other);
				if (hashSet2.Count > 0)
				{
					dictionary.Add(id, hashSet2);
					continue;
				}
			}
			hashSet.Add(id);
			list.Add(id);
		}
		foreach (KeyValuePair<string, ISet<string>> item2 in dictionary)
		{
			Visit(item2.Key, dictionary, hashSet, list);
		}
		CS_0024_003C_003E8__locals0.dic = items.ToDictionary((ManifestItem i) => (string)_003C_003Ec.cObD3i8Nx0qPLVnFK04G(i), (ManifestItem i) => i);
		return list.Select((string uid) => CS_0024_003C_003E8__locals0.dic[uid]).ToList();
	}

	private void Visit(string node, IDictionary<string, ISet<string>> dependencies, ISet<string> visited, ICollection<string> result)
	{
		if (visited.Contains(node))
		{
			return;
		}
		visited.Add(node);
		foreach (string item in dependencies[node])
		{
			Visit(item, dependencies, visited, result);
		}
		result.Add(node);
	}

	public AutoDeployService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tDGONYEAWDCHFufLy5cA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AutoDeployService()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				AllowedAutoDeployExtensions = new string[2]
				{
					(string)NOqQvoEHqpypsttIQ10j(-1638402543 ^ -1638701213),
					(string)NOqQvoEHqpypsttIQ10j(0x638095EB ^ 0x63840465)
				};
				num2 = 4;
				break;
			case 0:
				return;
			case 3:
				DeployLog = Logger.GetLogger((string)NOqQvoEHqpypsttIQ10j(0x4EDCBA32 ^ 0x4ED837D4));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				AutoDeployMasks = AllowedAutoDeployExtensions.Select((string ext) => (string)_003C_003Ec.dA7XpI8NLeNGrgciJdgM(_003C_003Ec.C5mb4P8NYcy0HbRWmvKL(-16752921 ^ -16773961), ext)).ToArray();
				num2 = 3;
				break;
			case 2:
				tDGONYEAWDCHFufLy5cA();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object WV9tFuEHRwCCp4TYNLwd(object P_0)
	{
		return ((PackageService)P_0).LocalRepositoryPath;
	}

	internal static object NOqQvoEHqpypsttIQ10j(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object PKUS72EHKKn6swMQ9jxy(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool NW3HeNEHXbyNJ1Ku4KHP(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object R4eZwKEHTNTlOAWr5Bbj(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static bool FqyNh6EHSPVLus1REA4t()
	{
		return K4cWdEEHVcMEgNoaS6PX == null;
	}

	internal static AutoDeployService ah0h7UEHiajwFF08qnsQ()
	{
		return K4cWdEEHVcMEgNoaS6PX;
	}

	internal static object irB9GcEHkLRx4w9RFEXZ(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static DateTime jNWBr6EHnfuZdCBXT5P1()
	{
		return DateTime.Now;
	}

	internal static object oPEcFbEHOmiXeFTUix9x(object P_0)
	{
		return ((ManifestItem)P_0).Id;
	}

	internal static object I5GCs4EH2NX4MsLi0ifu(object P_0)
	{
		return ((ManifestItem)P_0).Version;
	}

	internal static object wtJZyUEHeZHPAxYcd2jK(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void l3eGbYEHP1DTHug84kr8(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static object aWVUCHEH1JrRmbJ8vw14()
	{
		return Environment.NewLine;
	}

	internal static void zTFFxPEHNLZQw4YKiTA8(object P_0)
	{
		((ManifestDeployLogger)P_0).CompleteDeploy();
	}

	internal static object KHq1BEEH3SVlp8VHoye5(object P_0)
	{
		return ((ManifestDeployLogger)P_0).LogPath;
	}

	internal static object eEg7RYEHp9enp1ZOpsPr(object P_0)
	{
		return ((ManifestItem)P_0).Manifest;
	}

	internal static object EgCQnbEHaBLQNeA5O7kD(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static bool el39dPEHDAcwTC17mG5u(object P_0)
	{
		return ((ZipEntry)P_0).get_IsFile();
	}

	internal static object RwWhQgEHtqd4bO8LLo0p(object P_0)
	{
		return ((ZipEntry)P_0).get_Name();
	}

	internal static bool dgvyvNEHwRjMh09Anw8G(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object XXqqjREH4Pd3I6vEX0vH(object P_0, object P_1)
	{
		return ((ZipFile)P_0).GetInputStream((ZipEntry)P_1);
	}

	internal static void kQxNmfEH6xGgXBIqWvGO(object P_0, object P_1)
	{
		FS.CreateFile((string)P_0, (Action)P_1);
	}

	internal static bool pv8nP9EHHR977VViicvI(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void OfJearEHAAdIBdNrOlXl(object P_0, object P_1)
	{
		((ManifestItem)P_0).ElmaFile = (string)P_1;
	}

	internal static void S5bYQREH7cN23w1tnCca(object P_0, object P_1)
	{
		((ManifestItem)P_0).ManifestFile = (string)P_1;
	}

	internal static void gV1OoCEHxmRhFhdytSU3(object P_0, object P_1)
	{
		((ManifestItem)P_0).Manifest = (ElmaStoreComponentManifest)P_1;
	}

	internal static void nMJMoUEH0eDCbhCnTPxp(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static bool WjTNqFEHmyuN4l9PdKJN(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void giHBgjEHyf9EtQfU73UZ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object xKpfDTEHM189vcR3v33Y(object P_0)
	{
		return ((ModuleManager.StoreComponentConfigurationInfo)P_0).DeployVersion;
	}

	internal static void JqyCBIEHJGP42TxqAQkb(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static void Qj7YjFEH9janHmOe7nDE(object P_0, int value)
	{
		((ConfigImportSettings)P_0).ImportStep = value;
	}

	internal static object HRO8ZqEHdwn904xXTMVA()
	{
		return ComponentManager.Current;
	}

	internal static void oXIRq5EHldEscgOZlows(object P_0, object P_1, AutoDeployComponentStatus status)
	{
		((ModuleManager)P_0).UpdateAutoDeployComponentInfo((ModuleManager.StoreComponentConfigurationInfo)P_1, status);
	}

	internal static object E9Lm23EHrhMrUMuVHPw5(object P_0)
	{
		return ((ModuleManager.StoreComponentConfigurationInfo)P_0).Id;
	}

	internal static object n8PorTEHgLB56ynpr3o4(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object Kfq8epEH57Y9qFGongHo(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static void mp0bQjEHjeGXgJXn4777(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static void J4jttoEHYjjyqvlNEvch(object P_0)
	{
		((WebHostEnvironmentManager)P_0).RestartHost();
	}

	internal static void EHMLoMEHL8QvEi9cUkIJ(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunBySystemUser((Action)P_1);
	}

	internal static object APmZXaEHUBZXK5EnIhLK(object P_0)
	{
		return ((ConfigImportSettings)P_0).FileName;
	}

	internal static int M8CoEOEHsiUNqJZ9ePYD(object P_0)
	{
		return ((ConfigImportSettings)P_0).ImportStep;
	}

	internal static void GGwyc7EHcrnMRSFMRucG(object P_0, object P_1)
	{
		((IExportImportFileService)P_0).DeleteFiles((string)P_1);
	}

	internal static long cm5T2iEHz2woyumPFvjq(object P_0)
	{
		return ((IExportImportFileService)P_0).GetBufferLength();
	}

	internal static int VTjvT1EAFSOhAdjWcNH9(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void i9UNsOEABK2KFXZgmeYD(object P_0, object P_1, object P_2)
	{
		((IExportImportFileService)P_0).AddToFile((string)P_1, (byte[])P_2);
	}

	internal static void tDGONYEAWDCHFufLy5cA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
