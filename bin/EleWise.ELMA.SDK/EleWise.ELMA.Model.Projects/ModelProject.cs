using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Projects;

public class ModelProject : IDisposable
{
	private string prjDir;

	private string prjName;

	private string prjFileName;

	private Project prj;

	private ProjectItemGroupElement prjGroupRefs;

	private ProjectItemGroupElement prjGroupCompile;

	private ProjectItemGroupElement prjGroupNone;

	private List<ModelProjectItem> items;

	private List<ModelProjectReference> references;

	internal static ModelProject jdKIKTW5NuAwfBSoMrCi;

	public string ProjectFileName
	{
		get
		{
			return prjFileName;
		}
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					case 2:
						break;
					case 1:
						prjFileName = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						prjDir = (string)UFBV7oW5tw7ZRSd0QgPG(prjFileName);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				prjName = (string)w1kZOfW5wrJVW85KHYt4(prjFileName);
				num = 3;
			}
		}
	}

	public string Name => prjName;

	public string CompiledFileName => (string)CcBgoYW5H7xgTiHRCOge(prjDir, Sgf5RiW54HcdlDS046cf(-1998538950 ^ -1998484728), Sgf5RiW54HcdlDS046cf(-35995181 ^ -36110563), BQ9KSXW566GdlpwvJKhP(prjName, Sgf5RiW54HcdlDS046cf(0x6DC147B0 ^ 0x6DC0030A)));

	public List<ModelProjectItem> Items => items;

	public List<ModelProjectReference> References => references;

	internal string ProjectDir => prjDir;

	internal ProjectItemGroupElement ProjectGroupCompile => prjGroupCompile;

	internal ProjectItemGroupElement ProjectGroupNone => prjGroupNone;

	public ModelProject(string projectFileName)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		items = new List<ModelProjectItem>();
		references = new List<ModelProjectReference>();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Load();
				num = 5;
				break;
			case 5:
				return;
			case 3:
				return;
			case 4:
				ev3laVW5aU842l81P4Wd(projectFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1CDDB4));
				num = 2;
				break;
			case 1:
				if (!qRfbg0W5DWlCLDC2o6KW(projectFileName))
				{
					CreateNew();
					num = 3;
					break;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				ProjectFileName = projectFileName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void Load()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				ParseProject();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			default:
				prj = new Project(ProjectFileName);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (!qRfbg0W5DWlCLDC2o6KW(ProjectFileName))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Save()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				CheckProjectFileNameDefined();
				num2 = 2;
				break;
			case 2:
				cLt60KW5ALQZFBTDsjmH(prj, prjFileName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				GenerateTemplates(new Dictionary<string, string> { 
				{
					(string)Sgf5RiW54HcdlDS046cf(0x10E41EDB ^ 0x10E62007),
					(string)Sgf5RiW54HcdlDS046cf(0x61EC0CB8 ^ 0x61EE33AC)
				} });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Build(ILogger buildLogger)
	{
		return prj.Build(buildLogger);
	}

	public ModelProjectItem AddItem(IMetadata metadata)
	{
		return AddItem(metadata, null, null);
	}

	public ModelProjectItem AddItem(IMetadata metadata, Action<string> fileAddedAction = null, Action<string> fileRemovedAction = null)
	{
		using (new MetadataServiceContext(new ExtendedMetadataService(MetadataServiceContext.Service, new IMetadata[1] { metadata })))
		{
			return GetOrCreateProjectItem(metadata, saveMetadata: true, fileAddedAction);
		}
	}

	public ModelProjectReference AddReference(string name, string hintPath = null)
	{
		//Discarded unreachable code: IL_0127
		int num = 7;
		int num2 = num;
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		ModelProjectReference modelProjectReference = default(ModelProjectReference);
		ProjectItemElement item = default(ProjectItemElement);
		while (true)
		{
			switch (num2)
			{
			case 3:
				dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC378FC)] = hintPath;
				num2 = 4;
				break;
			case 7:
				dictionary = new Dictionary<string, string>();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 6;
				}
				break;
			default:
				references.Add(modelProjectReference);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				if (VgIifLW57TZ8EPN1iLPE(hintPath))
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 1:
				modelProjectReference = new ModelProjectReference(this, item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return modelProjectReference;
			case 4:
			case 5:
				item = prjGroupRefs.AddItem((string)Sgf5RiW54HcdlDS046cf(0x5DD55050 ^ 0x5DD4D528), name, dictionary);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IEnumerable<ModelProjectItem> CreateItems(IEnumerable<IMetadata> metadataList)
	{
		List<ModelProjectItem> list = new List<ModelProjectItem>();
		foreach (IMetadata metadata in metadataList)
		{
			list.Add(GetOrCreateProjectItem(metadata, saveMetadata: false));
		}
		return list;
	}

	public static string GenerateAssemblyInfoFile(string projectName)
	{
		return GenerateAssemblyInfoFile();
	}

	public static string GenerateAssemblyInfoFile(Func<string, string> conversions = null)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.conversions = conversions;
		if (CS_0024_003C_003E8__locals0.conversions == null)
		{
			CS_0024_003C_003E8__locals0.conversions = (string str) => str;
		}
		return GenerateTemplateToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3204338), (string str) => (string)_003C_003Ec__DisplayClass20_0.nSjM4nQzlgG8nPwDld77(_003C_003Ec__DisplayClass20_0.nSjM4nQzlgG8nPwDld77(_003C_003Ec__DisplayClass20_0.nSjM4nQzlgG8nPwDld77(CS_0024_003C_003E8__locals0.conversions(str).Replace((string)_003C_003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(-1886646897 ^ -1886806471), "").Replace((string)_003C_003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(0x4EDCBA32 ^ 0x4ED929E8), ""), _003C_003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(0x7C1EE318 ^ 0x7C1B7712), _003C_003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(0x5DD55050 ^ 0x5DD5BA80)), _003C_003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(--1867379187 ^ 0x6F4865C1), _003C_003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(-70037984 ^ -70015760)), _003C_003Ec__DisplayClass20_0.nwojHLQzdFj2TIEtSbdI(0x3630F361 ^ 0x36356705), _003C_003Ec__DisplayClass20_0.H1lcAmQzrTE5v5b3SbP1().Year.ToString()));
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_004a, IL_0059
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (prj == null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 2:
				return;
			case 4:
				prj = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				return;
			}
			pAH4eOW50mbTS8bbXFSG(zTk1mZW5xVHKl4kT4L9J(), prj);
			num2 = 4;
		}
	}

	private void CheckProjectFileNameDefined()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (VgIifLW57TZ8EPN1iLPE(prjFileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new NotInitializedException((string)XNPk4uW5mbxA5i4ZOF7A(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108773040)));
			}
		}
	}

	private void ParseProject()
	{
		//Discarded unreachable code: IL_008b, IL_009a, IL_00a5, IL_014f, IL_0187, IL_0196, IL_01a7, IL_01b6, IL_01c1, IL_0287, IL_0296, IL_02a5, IL_02b5, IL_038b, IL_03f5, IL_042d, IL_04e8, IL_057d, IL_058e, IL_0598, IL_05ec, IL_0658, IL_078f, IL_07c7, IL_07d6, IL_07e7, IL_07f6, IL_097b, IL_098a, IL_09bb, IL_09f3, IL_0a02, IL_0a32
		int num = 2;
		IEnumerator<ProjectItemElement> enumerator = default(IEnumerator<ProjectItemElement>);
		ProjectItemElement current4 = default(ProjectItemElement);
		IEnumerator<ProjectItemGroupElement> enumerator2 = default(IEnumerator<ProjectItemGroupElement>);
		string text = default(string);
		ProjectItemElement projectItemElement = default(ProjectItemElement);
		ProjectItemGroupElement current3 = default(ProjectItemGroupElement);
		Dictionary<string, ModelProjectItem> dictionary = default(Dictionary<string, ModelProjectItem>);
		ProjectItemElement current2 = default(ProjectItemElement);
		ProjectMetadataElement projectMetadataElement = default(ProjectMetadataElement);
		string key = default(string);
		ModelProjectItem value = default(ModelProjectItem);
		ProjectItemElement current = default(ProjectItemElement);
		IMetadata metadata = default(IMetadata);
		ModelProjectItem modelProjectItem = default(ModelProjectItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					mVMmZRW5UjPTdE1UNTpy(references);
					num2 = 9;
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_0103:
							int num10;
							if (!FZnJFXW5dJmoMo8lmGBx(enumerator))
							{
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
								{
									num10 = 1;
								}
								goto IL_00a9;
							}
							goto IL_00c3;
							IL_00c3:
							current4 = enumerator.Current;
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num10 = 0;
							}
							goto IL_00a9;
							IL_00a9:
							while (true)
							{
								switch (num10)
								{
								case 3:
									break;
								default:
									references.Add(new ModelProjectReference(this, current4));
									num10 = 2;
									continue;
								case 2:
									goto IL_0103;
								case 1:
									return;
								}
								break;
							}
							goto IL_00c3;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num11 = 0;
							}
							while (true)
							{
								switch (num11)
								{
								default:
									BlefyFW5Ym23tZnbW4uE(enumerator);
									num11 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
									{
										num11 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 1:
					try
					{
						while (true)
						{
							int num8;
							if (!FZnJFXW5dJmoMo8lmGBx(enumerator2))
							{
								num8 = 3;
								goto IL_01c5;
							}
							goto IL_0341;
							IL_01c5:
							while (true)
							{
								switch (num8)
								{
								case 9:
									if (!Kk6na8W59r1hNkbTy7nM(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C1C303)))
									{
										num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
										{
											num8 = 13;
										}
										continue;
									}
									goto case 2;
								case 15:
									if (!(text == (string)Sgf5RiW54HcdlDS046cf(0x66F566B6 ^ 0x66F4E0D4)))
									{
										num8 = 11;
										continue;
									}
									goto case 4;
								case 6:
									if (projectItemElement != null)
									{
										num8 = 8;
										continue;
									}
									break;
								case 4:
									prjGroupNone = current3;
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
									{
										num8 = 0;
									}
									continue;
								case 8:
									text = (string)FZWsDTW5JDITqFdjbx5l(projectItemElement);
									num8 = 9;
									continue;
								case 13:
									if (text == (string)Sgf5RiW54HcdlDS046cf(-541731959 ^ -541829657))
									{
										num8 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
										{
											num8 = 6;
										}
										continue;
									}
									goto case 15;
								case 10:
									goto IL_0341;
								case 2:
									prjGroupRefs = current3;
									num8 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num8 = 0;
									}
									continue;
								case 12:
									projectItemElement = xUQZxDW5MFj9F7EnKmKk(current3) as ProjectItemElement;
									num8 = 6;
									continue;
								case 7:
								case 14:
									prjGroupCompile = current3;
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num8 = 0;
									}
									continue;
								case 3:
									goto end_IL_02f4;
								}
								break;
							}
							continue;
							IL_0341:
							current3 = enumerator2.Current;
							num8 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num8 = 4;
							}
							goto IL_01c5;
							continue;
							end_IL_02f4:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									enumerator2.Dispose();
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
									{
										num9 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 4;
				case 5:
					prjGroupCompile = (ProjectItemGroupElement)oWDGsaW5lCD76J3tDaPM(j0qTRoW5y3JUDwjqYGDu(prj));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 12;
					}
					continue;
				case 4:
					if (prjGroupRefs != null)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 3;
				case 10:
				case 20:
					dictionary = new Dictionary<string, ModelProjectItem>();
					num2 = 11;
					continue;
				case 17:
				case 18:
					if (prjGroupCompile == null)
					{
						num2 = 5;
						continue;
					}
					goto case 12;
				case 2:
					enumerator2 = ((ProjectRootElement)j0qTRoW5y3JUDwjqYGDu(prj)).ItemGroups.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					return;
				case 9:
					if (prjGroupRefs == null)
					{
						num2 = 15;
						continue;
					}
					break;
				case 3:
					prjGroupRefs = (ProjectItemGroupElement)oWDGsaW5lCD76J3tDaPM(j0qTRoW5y3JUDwjqYGDu(prj));
					num2 = 17;
					continue;
				case 11:
					goto end_IL_0012;
				case 12:
					if (prjGroupNone != null)
					{
						num2 = 20;
						continue;
					}
					goto case 13;
				default:
					enumerator = prjGroupCompile.Items.GetEnumerator();
					num2 = 7;
					continue;
				case 16:
					return;
				case 7:
					try
					{
						while (true)
						{
							IL_0662:
							int num6;
							if (!FZnJFXW5dJmoMo8lmGBx(enumerator))
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num6 = 0;
								}
								goto IL_059c;
							}
							goto IL_0630;
							IL_0630:
							current2 = enumerator.Current;
							num6 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
							{
								num6 = 1;
							}
							goto IL_059c;
							IL_059c:
							while (true)
							{
								switch (num6)
								{
								case 2:
									if (projectMetadataElement == null)
									{
										num6 = 9;
										continue;
									}
									goto case 4;
								case 6:
									if (R0bx4UW5rarv4GmI6LlO(current2) != null)
									{
										num6 = 11;
										continue;
									}
									goto IL_0662;
								case 4:
									key = (string)GZgIlNW556BLD6efVhjX(UFBV7oW5tw7ZRSd0QgPG(R0bx4UW5rarv4GmI6LlO(current2)), lpfCcfW5LdDDJiYKIBcB(projectMetadataElement));
									num6 = 10;
									continue;
								case 5:
									goto IL_0630;
								case 7:
								case 8:
								case 9:
									goto IL_0662;
								case 10:
									if (dictionary.TryGetValue(key, out value))
									{
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
										{
											num6 = 1;
										}
										continue;
									}
									goto IL_0662;
								case 1:
									value.DependentItems.Add(current2);
									num6 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num6 = 3;
									}
									continue;
								case 11:
									projectMetadataElement = current2.Metadata.FirstOrDefault((ProjectMetadataElement m) => _003C_003Ec.KpsgO8QzUZNbUlVA7lCl(_003C_003Ec.sslGwiQzYSsE3iYhcUjj(m), _003C_003Ec.FEcy24QzLF7qrDLWe2ix(-1426094279 ^ -1426194033)));
									num6 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
									{
										num6 = 3;
									}
									continue;
								case 3:
									if (current2.Metadata.Count(delegate(ProjectMetadataElement m)
									{
										//Discarded unreachable code: IL_002d, IL_003c
										int num12 = 1;
										int num13 = num12;
										while (true)
										{
											switch (num13)
											{
											case 2:
												return _003C_003Ec.KpsgO8QzUZNbUlVA7lCl(_003C_003Ec.A6wYBEQzsFTWGCR29sWe(m), _003C_003Ec.FEcy24QzLF7qrDLWe2ix(-234299632 ^ -234268286));
											default:
												return false;
											case 1:
												if (!_003C_003Ec.KpsgO8QzUZNbUlVA7lCl(m.Name, _003C_003Ec.FEcy24QzLF7qrDLWe2ix(0x7459E02 ^ 0x7441882)))
												{
													num13 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
													{
														num13 = 0;
													}
													break;
												}
												goto case 2;
											}
										}
									}) <= 0)
									{
										num6 = 7;
										continue;
									}
									goto case 2;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									BlefyFW5Ym23tZnbW4uE(enumerator);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num7 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 8;
				case 14:
					try
					{
						while (true)
						{
							int num3;
							if (!FZnJFXW5dJmoMo8lmGBx(enumerator))
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 10;
								}
								goto IL_0805;
							}
							goto IL_0963;
							IL_0963:
							current = enumerator.Current;
							num3 = 7;
							goto IL_0805;
							IL_0805:
							while (true)
							{
								switch (num3)
								{
								case 7:
									if (R0bx4UW5rarv4GmI6LlO(current) == null)
									{
										num3 = 6;
										continue;
									}
									goto case 2;
								case 9:
									if (!dictionary.ContainsKey((string)R0bx4UW5rarv4GmI6LlO(current)))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									break;
								default:
								{
									metadata = (IMetadata)ySIFqJW5jVqhZoTlb0Ai(GZgIlNW556BLD6efVhjX(prjDir, current.Include));
									int num4 = 8;
									num3 = num4;
									continue;
								}
								case 1:
								case 6:
									break;
								case 2:
									if (zE2Iv6W5gJYcVkSD6NF1(R0bx4UW5rarv4GmI6LlO(current), Sgf5RiW54HcdlDS046cf(0x1A33FE36 ^ 0x1A333466)))
									{
										num3 = 9;
										continue;
									}
									break;
								case 4:
									dictionary[current.Include] = modelProjectItem;
									num3 = 5;
									continue;
								case 5:
									items.Add(modelProjectItem);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num3 = 1;
									}
									continue;
								case 8:
									modelProjectItem = new ModelProjectItem(this, metadata, current);
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
									{
										num3 = 4;
									}
									continue;
								case 3:
									goto IL_0963;
								case 10:
									goto end_IL_08a5;
								}
								break;
							}
							continue;
							end_IL_08a5:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									BlefyFW5Ym23tZnbW4uE(enumerator);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto default;
				case 13:
					prjGroupNone = (ProjectItemGroupElement)oWDGsaW5lCD76J3tDaPM(j0qTRoW5y3JUDwjqYGDu(prj));
					num2 = 10;
					continue;
				case 19:
					break;
				}
				enumerator = prjGroupRefs.Items.GetEnumerator();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			enumerator = prjGroupNone.Items.GetEnumerator();
			num = 14;
		}
	}

	private string GetMetadataFileName(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0198, IL_022c
		int num = 5;
		int num2 = num;
		ICodeItemMetadata codeItemMetadata = default(ICodeItemMetadata);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 11:
				if (tHcqVqW5cmhqoZX5pocL(RIQ43rW5sykaYBfupoJw(codeItemMetadata), prjName))
				{
					num2 = 10;
					break;
				}
				goto case 8;
			case 2:
				return text2;
			case 3:
				return (string)GZgIlNW556BLD6efVhjX(text, text2);
			case 5:
				ev3laVW5aU842l81P4Wd(metadata, Sgf5RiW54HcdlDS046cf(0x4EDCBA32 ^ 0x4EDCF30C));
				num2 = 4;
				break;
			case 1:
				if (!((string)RIQ43rW5sykaYBfupoJw(codeItemMetadata)).StartsWith(prjName))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 11;
			case 10:
				text = (string)RvhpG6WjFjLQ9dROvpA2(codeItemMetadata.Namespace.Substring(qA0DZkW5zjt4EjJt5xAD(prjName) + 1), Sgf5RiW54HcdlDS046cf(0x92F12D5 ^ 0x92F0811), Sgf5RiW54HcdlDS046cf(-2107978722 ^ -2107976856));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 12;
				}
				break;
			case 9:
				if (!VgIifLW57TZ8EPN1iLPE(RIQ43rW5sykaYBfupoJw(codeItemMetadata)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 6:
				codeItemMetadata = (ICodeItemMetadata)metadata;
				num2 = 9;
				break;
			case 7:
				text = "";
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				Contract.CheckArgument(metadata is ICodeItemMetadata, (string)Sgf5RiW54HcdlDS046cf(0x1ECE530A ^ 0x1ECC6CB4));
				num2 = 7;
				break;
			case 8:
			case 12:
				text2 = (string)BQ9KSXW566GdlpwvJKhP(i21q3wWjBGeTWTp5NHRv(codeItemMetadata), Sgf5RiW54HcdlDS046cf(0x307E9FD1 ^ 0x307E5581));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (text != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private ProjectItemElement GetOrCreateMdItem(string fileName)
	{
		int num = 4;
		ProjectItemElement projectItemElement = default(ProjectItemElement);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = default(_003C_003Ec__DisplayClass46_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 2:
					if (projectItemElement == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 1;
				case 7:
					dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AD65A9)] = (string)Sgf5RiW54HcdlDS046cf(0x68BBB53E ^ 0x68B98AC2);
					num2 = 5;
					continue;
				case 3:
					_003C_003Ec__DisplayClass46_.fileName = fileName;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					projectItemElement = (ProjectItemElement)prjGroupNone.Children.FirstOrDefault(_003C_003Ec__DisplayClass46_._003CGetOrCreateMdItem_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					dictionary = new Dictionary<string, string>();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					return projectItemElement;
				case 6:
					projectItemElement = prjGroupNone.AddItem(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146608831), _003C_003Ec__DisplayClass46_.fileName, dictionary);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
			num = 3;
		}
	}

	private ModelProjectItem GetOrCreateProjectItem(IMetadata metadata, bool saveMetadata, Action<string> fileAddedAction = null, Action<string> fileRemovedAction = null)
	{
		_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
		CS_0024_003C_003E8__locals0.metadata = metadata;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE394B7));
		ModelProjectItem modelProjectItem = items.FirstOrDefault((ModelProjectItem i) => _003C_003Ec__DisplayClass47_0.sdVNykCFfIng8vPokRZ1(_003C_003Ec__DisplayClass47_0.fUwmWkCFE0fjw0rlc5Sv(i.Metadata), _003C_003Ec__DisplayClass47_0.fUwmWkCFE0fjw0rlc5Sv(CS_0024_003C_003E8__locals0.metadata)));
		string metadataFileName = GetMetadataFileName(CS_0024_003C_003E8__locals0.metadata);
		if (modelProjectItem != null)
		{
			modelProjectItem.Metadata = CS_0024_003C_003E8__locals0.metadata;
			modelProjectItem.MdItem.Include = metadataFileName;
		}
		else
		{
			ProjectItemElement orCreateMdItem = GetOrCreateMdItem(metadataFileName);
			modelProjectItem = new ModelProjectItem(this, CS_0024_003C_003E8__locals0.metadata, orCreateMdItem);
			items.Add(modelProjectItem);
		}
		Path.Combine(prjDir, metadataFileName);
		if (saveMetadata)
		{
			modelProjectItem.Save(fileAddedAction, fileRemovedAction);
		}
		return modelProjectItem;
	}

	private void SaveNewProject(IMetadata[] metadataList)
	{
		//Discarded unreachable code: IL_009e, IL_00d8, IL_0110, IL_0169, IL_01a1, IL_01b0, IL_02b1
		int num = 6;
		Stream stream = default(Stream);
		int num3 = default(int);
		IMetadata[] array = default(IMetadata[]);
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 12:
					WNWwu4WjbBQl0oK4LiJ4(prjDir);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					try
					{
						XmlTextReader xmlTextReader = new XmlTextReader(stream);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								prj = new Project(xmlTextReader);
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							finally
							{
								if (xmlTextReader != null)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
									{
										num6 = 1;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											BlefyFW5Ym23tZnbW4uE(xmlTextReader);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
							break;
						}
					}
					finally
					{
						if (stream != null)
						{
							int num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									((IDisposable)stream).Dispose();
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
									{
										num7 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 1;
				case 6:
					stream = (Stream)QjnSbhWjWDCNdxZigCVI(typeof(ModelProject).Assembly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31302118));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 5;
					}
					continue;
				case 11:
					num3 = 0;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					ParseProject();
					num2 = 2;
					continue;
				case 7:
					if (!gUl6yfWjotWkX1vEMuE9(prjDir))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 3:
				case 9:
					if (num3 >= array.Length)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				case 10:
					GetOrCreateProjectItem(metadata, saveMetadata: true);
					num2 = 8;
					continue;
				case 4:
					cLt60KW5ALQZFBTDsjmH(prj, prjFileName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					array = metadataList;
					num2 = 11;
					continue;
				case 8:
					num3++;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 9;
					}
					continue;
				case 13:
					break;
				case 0:
					return;
				}
				metadata = array[num3];
				num2 = 10;
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	private void CreateNew()
	{
		//Discarded unreachable code: IL_008d, IL_00c7, IL_00ff, IL_011e, IL_016b, IL_01a3, IL_01b2
		int num = 1;
		int num2 = num;
		StringReader stringReader = default(StringReader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stringReader = new StringReader(GenerateTemplate((string)Sgf5RiW54HcdlDS046cf(-672123589 ^ -671976155)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					XmlReader xmlReader = XmlReader.Create(stringReader);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							prj = new Project(xmlReader);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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
							if (xmlReader == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num5 = 0;
								}
								goto IL_0103;
							}
							goto IL_0128;
							IL_0128:
							BlefyFW5Ym23tZnbW4uE(xmlReader);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num5 = 1;
							}
							goto IL_0103;
							IL_0103:
							switch (num5)
							{
							default:
								goto end_IL_00de;
							case 0:
								goto end_IL_00de;
							case 2:
								break;
							case 1:
								goto end_IL_00de;
							}
							goto IL_0128;
							end_IL_00de:;
						}
						break;
					}
				}
				finally
				{
					if (stringReader != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								((IDisposable)stringReader).Dispose();
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
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
				break;
			case 3:
				break;
			case 2:
				return;
			}
			ParseProject();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num2 = 2;
			}
		}
	}

	private void GenerateTemplate(string resourceName, string fileName)
	{
		//Discarded unreachable code: IL_0063, IL_0091, IL_00b9, IL_00f9, IL_0108, IL_0114
		int num = 1;
		int num2 = num;
		string directoryName = default(string);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			default:
				if (gUl6yfWjotWkX1vEMuE9(directoryName))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 6:
				try
				{
					GenerateTemplate(resourceName, fileStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
					if (fileStream == null)
					{
						num4 = 2;
						goto IL_00bd;
					}
					goto IL_00d3;
					IL_00bd:
					switch (num4)
					{
					default:
						goto end_IL_00a8;
					case 1:
						break;
					case 2:
						goto end_IL_00a8;
					case 0:
						goto end_IL_00a8;
					}
					goto IL_00d3;
					IL_00d3:
					BlefyFW5Ym23tZnbW4uE(fileStream);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num4 = 0;
					}
					goto IL_00bd;
					end_IL_00a8:;
				}
			case 1:
				directoryName = Path.GetDirectoryName(fileName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				return;
			case 2:
			case 4:
				fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
				num2 = 6;
				continue;
			case 3:
				break;
			}
			WNWwu4WjbBQl0oK4LiJ4(directoryName);
			num2 = 4;
		}
	}

	private void GenerateTemplate(string resourceName, Stream stream)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00a8, IL_00d4, IL_00e3
		int num = 2;
		int num2 = num;
		StreamWriter streamWriter = default(StreamWriter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					streamWriter.Write(GenerateTemplate(resourceName));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
					if (streamWriter == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num4 = 0;
						}
						goto IL_008d;
					}
					goto IL_00b2;
					IL_00b2:
					((IDisposable)streamWriter).Dispose();
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num4 = 1;
					}
					goto IL_008d;
					IL_008d:
					switch (num4)
					{
					default:
						goto end_IL_0068;
					case 0:
						goto end_IL_0068;
					case 2:
						break;
					case 1:
						goto end_IL_0068;
					}
					goto IL_00b2;
					end_IL_0068:;
				}
			case 2:
				streamWriter = new StreamWriter(stream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private string GenerateTemplate(string resourceName)
	{
		return GenerateTemplateToString(resourceName, (string s) => (string)RvhpG6WjFjLQ9dROvpA2(s, Sgf5RiW54HcdlDS046cf(-978351861 ^ -978466413), prjName));
	}

	private static string GenerateTemplateToString(object resourceName, Func<string, string> conversions = null)
	{
		using Stream stream = typeof(ModelProject).Assembly.GetManifestResourceStream(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D725A) + (string)resourceName);
		using StreamReader streamReader = new StreamReader(stream);
		string text = streamReader.ReadToEnd();
		return (conversions != null) ? conversions(text) : text;
	}

	private void GenerateTemplates(Dictionary<string, string> fileNameTemplateMap)
	{
		foreach (KeyValuePair<string, string> item in fileNameTemplateMap)
		{
			string text = Path.Combine(prjDir, item.Key);
			if (!File.Exists(text))
			{
				GenerateTemplate(item.Value, text);
			}
		}
	}

	internal static void ev3laVW5aU842l81P4Wd(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool qRfbg0W5DWlCLDC2o6KW(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static bool v9rcBaW53BxcRcYjaPYQ()
	{
		return jdKIKTW5NuAwfBSoMrCi == null;
	}

	internal static ModelProject EH8mvSW5prY1kKXuhmuW()
	{
		return jdKIKTW5NuAwfBSoMrCi;
	}

	internal static object UFBV7oW5tw7ZRSd0QgPG(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object w1kZOfW5wrJVW85KHYt4(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object Sgf5RiW54HcdlDS046cf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object BQ9KSXW566GdlpwvJKhP(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object CcBgoYW5H7xgTiHRCOge(object P_0, object P_1, object P_2, object P_3)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static void cLt60KW5ALQZFBTDsjmH(object P_0, object P_1)
	{
		((Project)P_0).Save((string)P_1);
	}

	internal static bool VgIifLW57TZ8EPN1iLPE(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object zTk1mZW5xVHKl4kT4L9J()
	{
		return ProjectCollection.GlobalProjectCollection;
	}

	internal static void pAH4eOW50mbTS8bbXFSG(object P_0, object P_1)
	{
		((ProjectCollection)P_0).UnloadProject((Project)P_1);
	}

	internal static object XNPk4uW5mbxA5i4ZOF7A(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object j0qTRoW5y3JUDwjqYGDu(object P_0)
	{
		return ((Project)P_0).Xml;
	}

	internal static object xUQZxDW5MFj9F7EnKmKk(object P_0)
	{
		return ((ProjectElementContainer)P_0).FirstChild;
	}

	internal static object FZWsDTW5JDITqFdjbx5l(object P_0)
	{
		return ((ProjectItemElement)P_0).ItemType;
	}

	internal static bool Kk6na8W59r1hNkbTy7nM(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool FZnJFXW5dJmoMo8lmGBx(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object oWDGsaW5lCD76J3tDaPM(object P_0)
	{
		return ((ProjectRootElement)P_0).AddItemGroup();
	}

	internal static object R0bx4UW5rarv4GmI6LlO(object P_0)
	{
		return ((ProjectItemElement)P_0).Include;
	}

	internal static bool zE2Iv6W5gJYcVkSD6NF1(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static object GZgIlNW556BLD6efVhjX(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object ySIFqJW5jVqhZoTlb0Ai(object P_0)
	{
		return MetadataSerializer.LoadMetadata((string)P_0);
	}

	internal static void BlefyFW5Ym23tZnbW4uE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object lpfCcfW5LdDDJiYKIBcB(object P_0)
	{
		return ((ProjectMetadataElement)P_0).Value;
	}

	internal static void mVMmZRW5UjPTdE1UNTpy(object P_0)
	{
		((List<ModelProjectReference>)P_0).Clear();
	}

	internal static object RIQ43rW5sykaYBfupoJw(object P_0)
	{
		return ((ICodeItemMetadata)P_0).Namespace;
	}

	internal static bool tHcqVqW5cmhqoZX5pocL(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static int qA0DZkW5zjt4EjJt5xAD(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object RvhpG6WjFjLQ9dROvpA2(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object i21q3wWjBGeTWTp5NHRv(object P_0)
	{
		return ((ICodeItemMetadata)P_0).Name;
	}

	internal static object QjnSbhWjWDCNdxZigCVI(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static bool gUl6yfWjotWkX1vEMuE9(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object WNWwu4WjbBQl0oK4LiJ4(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}
}
