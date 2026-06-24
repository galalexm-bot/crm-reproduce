using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Exceptions;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager;

public class GlobalScriptModuleDtoManager : DTOManager, IGlobalScriptModuleDtoManager, IConfigurationService
{
	private bool needRestartServer;

	internal static GlobalScriptModuleDtoManager QUskpqbK6Y0i9Tklt0kD;

	public GlobalScriptModuleManager GlobalScriptModuleManager
	{
		[CompilerGenerated]
		get
		{
			return _003CGlobalScriptModuleManager_003Ek__BackingField;
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
					_003CGlobalScriptModuleManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	public GlobalScriptModuleHeaderManager GlobalScriptModuleHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CGlobalScriptModuleHeaderManager_003Ek__BackingField;
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
					_003CGlobalScriptModuleHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual GlobalScriptModuleDto Publish(GlobalScriptModuleDto gsm)
	{
		//Discarded unreachable code: IL_0070, IL_00a2, IL_00db
		int num = 8;
		int num2 = num;
		IGlobalScriptModule globalScriptModule = default(IGlobalScriptModule);
		long id = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					DNUkv6bKyOWesR7GwjF3(GlobalScriptModuleManager, globalScriptModule);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
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
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							pfGsTGbKMVXN6VGRnTh1(globalScriptModule);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
				goto case 4;
			case 8:
				FG8PNDbKxHfmsmOlekhN(gsm, tm3HPKbK7Pf5w5sIaaPD(-1146510045 ^ -1146394777));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				gsm = (GlobalScriptModuleDto)BSHlxObKJERtsmX48WFj(this, id);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				himGnibKmnRchmFxbkHO(globalScriptModule);
				num2 = 2;
				break;
			case 9:
				globalScriptModule = GlobalScriptModuleManager.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				RmUvyLbK0QxGBaBJdCyL(gsm);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Mapper.Map<GlobalScriptModuleDto, IGlobalScriptModule>(gsm, globalScriptModule);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 2;
				}
				break;
			case 10:
				return gsm;
			case 6:
				id = gsm.Id;
				num2 = 3;
				break;
			case 4:
				needRestartServer = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				Save(gsm);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public virtual GlobalScriptModuleDto Validate(GlobalScriptModuleDto gsm)
	{
		int num = 7;
		int num2 = num;
		long id = default(long);
		IGlobalScriptModule globalScriptModule = default(IGlobalScriptModule);
		while (true)
		{
			switch (num2)
			{
			case 1:
				gsm = (GlobalScriptModuleDto)BSHlxObKJERtsmX48WFj(this, id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				GlobalScriptModuleManager.Validate(globalScriptModule);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				id = gsm.Id;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				globalScriptModule = GlobalScriptModuleManager.Create();
				num2 = 4;
				break;
			case 6:
				vE1hNabK92NUIZy8p2EL(this, gsm);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				return gsm;
			case 4:
				Mapper.Map<GlobalScriptModuleDto, IGlobalScriptModule>(gsm, globalScriptModule);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				FG8PNDbKxHfmsmOlekhN(gsm, tm3HPKbK7Pf5w5sIaaPD(-643786247 ^ -643671107));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				RmUvyLbK0QxGBaBJdCyL(gsm);
				num2 = 3;
				break;
			}
		}
	}

	public virtual bool NeedRestartServer()
	{
		return needRestartServer;
	}

	public virtual GlobalScriptModuleDto Save(GlobalScriptModuleDto gsm)
	{
		int num = 6;
		IGlobalScriptModule globalScriptModule2 = default(IGlobalScriptModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IGlobalScriptModule globalScriptModule;
				switch (num2)
				{
				case 1:
					GlobalScriptModuleManager.Save(globalScriptModule2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					Mapper.Map<GlobalScriptModuleDto, IGlobalScriptModule>(gsm, globalScriptModule2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					GlobalScriptModuleHeaderManager.Save((IGlobalScriptModuleHeader)VrUcMbbKl0CXjiLqlHue(globalScriptModule2));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					Contract.ArgumentNotNull(gsm, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882306266));
					num = 5;
					break;
				default:
					return Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(globalScriptModule2, gsm);
				case 4:
					OQZbr6bKdsjVsInX49hi(globalScriptModule2.Header, globalScriptModule2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					globalScriptModule = GlobalScriptModuleManager.LoadOrNull(gsm.Id);
					if (globalScriptModule != null)
					{
						goto IL_013d;
					}
					num = 2;
					break;
				case 2:
					{
						globalScriptModule = GlobalScriptModuleManager.Create();
						goto IL_013d;
					}
					IL_013d:
					globalScriptModule2 = globalScriptModule;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	public virtual GlobalScriptModuleDto LoadOrNull(long id)
	{
		return Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(GlobalScriptModuleManager.LoadOrNull(id), new GlobalScriptModuleDto());
	}

	public virtual GlobalScriptModuleDto LoadOrNull(Guid uid)
	{
		return Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(GlobalScriptModuleManager.LoadOrNull(uid), new GlobalScriptModuleDto());
	}

	public virtual void DeleteDirectory(string directoryPath)
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
				D1pO7ZbKrNlPcjt4gLM5(GlobalScriptModuleManager, directoryPath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual GlobalScriptModuleDto Load(long id)
	{
		return Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(GlobalScriptModuleManager.Load(id), new GlobalScriptModuleDto());
	}

	public virtual ScriptModuleDTO LoadScriptModuleForEdit(long gsmId)
	{
		return Mapper.Map<ScriptModule, ScriptModuleDTO>((ScriptModule)N9rO2qbKgEfJ89gdsqV0(GlobalScriptModuleManager, gsmId), new ScriptModuleDTO());
	}

	public virtual void SaveScriptModule(ScriptModuleDTO scriptModule)
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
				kLdL4FbK5Qv5MlnWb5CZ(Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModule));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool CheckGlobalModuleNamespace(string space)
	{
		int num = 2;
		int num2 = num;
		IGlobalScriptModuleHeaderFilter globalScriptModuleHeaderFilter = default(IGlobalScriptModuleHeaderFilter);
		while (true)
		{
			switch (num2)
			{
			case 3:
				globalScriptModuleHeaderFilter.Deleted = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Mc2tDxbKjERILhSUeppK(globalScriptModuleHeaderFilter, space);
				num2 = 3;
				break;
			default:
				return !GlobalScriptModuleHeaderManager.Find(globalScriptModuleHeaderFilter, null).Any();
			case 2:
				globalScriptModuleHeaderFilter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool CheckGlobalModuleName(string name)
	{
		int num = 2;
		int num2 = num;
		IGlobalScriptModuleHeaderFilter globalScriptModuleHeaderFilter = default(IGlobalScriptModuleHeaderFilter);
		while (true)
		{
			switch (num2)
			{
			case 2:
				globalScriptModuleHeaderFilter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				globalScriptModuleHeaderFilter.Deleted = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				imuud2bKYkqJ983momk3(globalScriptModuleHeaderFilter, name);
				num2 = 3;
				break;
			default:
				return !GlobalScriptModuleHeaderManager.Find(globalScriptModuleHeaderFilter, null).Any();
			}
		}
	}

	public virtual void Compile(IGlobalScriptModule gsm)
	{
		//Discarded unreachable code: IL_00f9, IL_0108
		int num = 4;
		int num2 = num;
		ScriptModule scriptModule = default(ScriptModule);
		ScriptCompileResult scriptCompileResult = default(ScriptCompileResult);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (scriptModule != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 4:
				scriptModule = (ScriptModule)IkpaOZbKLft1tLYfxVch(gsm);
				num2 = 3;
				break;
			case 5:
				throw new GlobalScriptModulePublishingException(gsm.Id, scriptCompileResult);
			case 6:
				if (yn2xV1bKcsvjE93vpb3f(scriptCompileResult))
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				scriptCompileResult = (ScriptCompileResult)XiN2D2bKsyE3AffpnURL(new GlobalScriptModuleCompiler(scriptModule, gsm));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 5;
				}
				break;
			case 0:
				return;
			case 1:
				if (!(L7jIv3bKUFhxrTMixNni(gsm) is ProjectInfo))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual GlobalScriptModuleDto DoNew(GlobalScriptModuleDto oldGsm, string newPrefix = "", bool copy = false)
	{
		//Discarded unreachable code: IL_0049, IL_00ef, IL_0141, IL_0150
		int num = 4;
		int num2 = num;
		IGlobalScriptModule globalScriptModule = default(IGlobalScriptModule);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (copy)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 7:
				if (IdMNldbKzyMdbOB0gf9i(oldGsm) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 4:
				if (oldGsm == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 7;
			case 5:
				globalScriptModule = GlobalScriptModuleManager.LoadOrNull(Mye6ADbXFmcL6YKmkeZX(IdMNldbKzyMdbOB0gf9i(oldGsm)));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				if (oldGsm.ScriptModule != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 9:
				return null;
			default:
			{
				GlobalScriptModuleDto globalScriptModuleDto = ClassSerializationHelper.CloneObject(oldGsm);
				JGxEulbXWZORxQJI8rrQ(globalScriptModuleDto, tOGjrObXBmpS58fg6sSB());
				globalScriptModuleDto.Id = 0L;
				return globalScriptModuleDto;
			}
			case 1:
			case 3:
				return null;
			case 2:
				if (globalScriptModule != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public GlobalScriptModuleDtoManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vlXjk8bXoHnQlwjm3yuE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool aMtmZfbKHrejiidNcNrf()
	{
		return QUskpqbK6Y0i9Tklt0kD == null;
	}

	internal static GlobalScriptModuleDtoManager JK14IIbKA7dhjm7ScNqI()
	{
		return QUskpqbK6Y0i9Tklt0kD;
	}

	internal static object tm3HPKbK7Pf5w5sIaaPD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void FG8PNDbKxHfmsmOlekhN(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void RmUvyLbK0QxGBaBJdCyL(object P_0)
	{
		((GlobalScriptModuleDto)P_0).ResetIdsForPublish();
	}

	internal static void himGnibKmnRchmFxbkHO(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void DNUkv6bKyOWesR7GwjF3(object P_0, object P_1)
	{
		((GlobalScriptModuleManager)P_0).Publish((IGlobalScriptModule)P_1);
	}

	internal static void pfGsTGbKMVXN6VGRnTh1(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object BSHlxObKJERtsmX48WFj(object P_0, long id)
	{
		return ((GlobalScriptModuleDtoManager)P_0).LoadOrNull(id);
	}

	internal static object vE1hNabK92NUIZy8p2EL(object P_0, object P_1)
	{
		return ((GlobalScriptModuleDtoManager)P_0).Save((GlobalScriptModuleDto)P_1);
	}

	internal static void OQZbr6bKdsjVsInX49hi(object P_0, object P_1)
	{
		((IGlobalScriptModuleHeader)P_0).Draft = (IGlobalScriptModule)P_1;
	}

	internal static object VrUcMbbKl0CXjiLqlHue(object P_0)
	{
		return ((IGlobalScriptModule)P_0).Header;
	}

	internal static void D1pO7ZbKrNlPcjt4gLM5(object P_0, object P_1)
	{
		((GlobalScriptModuleManager)P_0).DeleteDirectory((string)P_1);
	}

	internal static object N9rO2qbKgEfJ89gdsqV0(object P_0, long gsmId)
	{
		return ((GlobalScriptModuleManager)P_0).LoadScriptModuleForEdit(gsmId);
	}

	internal static void kLdL4FbK5Qv5MlnWb5CZ(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static void Mc2tDxbKjERILhSUeppK(object P_0, object P_1)
	{
		((IGlobalScriptModuleHeaderFilter)P_0).Namespace = (string)P_1;
	}

	internal static void imuud2bKYkqJ983momk3(object P_0, object P_1)
	{
		((IGlobalScriptModuleHeaderFilter)P_0).Name = (string)P_1;
	}

	internal static object IkpaOZbKLft1tLYfxVch(object P_0)
	{
		return ((IGlobalScriptModule)P_0).ScriptModule;
	}

	internal static object L7jIv3bKUFhxrTMixNni(object P_0)
	{
		return ((IGlobalScriptModule)P_0).Items;
	}

	internal static object XiN2D2bKsyE3AffpnURL(object P_0)
	{
		return ((ScriptCompiler)P_0).Compile();
	}

	internal static bool yn2xV1bKcsvjE93vpb3f(object P_0)
	{
		return ((ScriptCompileResult)P_0).Success;
	}

	internal static object IdMNldbKzyMdbOB0gf9i(object P_0)
	{
		return ((GlobalScriptModuleDto)P_0).Header;
	}

	internal static Guid Mye6ADbXFmcL6YKmkeZX(object P_0)
	{
		return ((GlobalScriptModuleHeaderDto)P_0).Uid;
	}

	internal static Guid tOGjrObXBmpS58fg6sSB()
	{
		return Guid.NewGuid();
	}

	internal static void JGxEulbXWZORxQJI8rrQ(object P_0, Guid value)
	{
		((GlobalScriptModuleDto)P_0).Uid = value;
	}

	internal static void vlXjk8bXoHnQlwjm3yuE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
