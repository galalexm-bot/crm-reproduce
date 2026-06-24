using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class CustomActivityDTOManager : DTOManager, ICustomActivityDTOManager, IConfigurationService
{
	internal static CustomActivityDTOManager Wgac2SYuwgYoEPX87em;

	public CustomActivityManager CustomActivityManager
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityManager_003Ek__BackingField;
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
					_003CCustomActivityManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CustomActivityHeaderManager CustomActivityHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityHeaderManager_003Ek__BackingField;
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
					_003CCustomActivityHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 != 0)
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

	public virtual CustomActivityDTO Publish(CustomActivityDTO ca)
	{
		int num = 3;
		int num2 = num;
		ICustomActivity customActivity = default(ICustomActivity);
		long id = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				qsBUeyYJUbudIVS9EAI(ca);
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				PublishCustomActivity(customActivity, ca);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				Mapper.Map<CustomActivityDTO, ICustomActivity>(ca, customActivity);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				customActivity = CustomActivityManager.Create();
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				Contract.ArgumentNotNull(ca, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-402075023 ^ -402081633));
				num2 = 2;
				break;
			case 2:
				id = ca.Id;
				num2 = 5;
				break;
			case 5:
				aUfxSmYLZFf6YYZqoGl(this, ca, true);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				eRqt9TYr9HSXnDdZVbI(customActivity);
				num2 = 4;
				break;
			case 7:
				return LoadOrNull(id);
			}
		}
	}

	public virtual CustomActivityDTO Save(CustomActivityDTO ca, bool isDraft)
	{
		return (CustomActivityDTO)YWKfL1Y7nxTeKp1lvil(this, ca, isDraft, false);
	}

	public virtual List<CustomActivityDTO> LoadHistory(long customActivityHeadId)
	{
		return (from i in CustomActivityManager.LoadHistory(customActivityHeadId)
			select Mapper.Map<ICustomActivity, CustomActivityDTO>(i, new CustomActivityDTO())).ToList();
	}

	public virtual IDictionary<long, IEnumerable<CustomActivityDTO>> LoadHistories(IEnumerable<long> customActivityHeadIds)
	{
		Dictionary<long, IEnumerable<CustomActivityDTO>> dictionary = new Dictionary<long, IEnumerable<CustomActivityDTO>>();
		IDictionary<long, List<ICustomActivity>> dictionary2 = CustomActivityManager.LoadHistories(customActivityHeadIds);
		Func<ICustomActivity, CustomActivityDTO> selector = delegate(ICustomActivity entity)
		{
			CustomActivityDTO obj = new CustomActivityDTO
			{
				Id = entity.Id,
				Uid = _003C_003Ec.ydxvK7OYBjGkZeHO0vR(entity)
			};
			_003C_003Ec.fS746kOPoIR24cRhlZC(obj, _003C_003Ec.lw7sGKOvF3T8udQUt6p(entity));
			return obj;
		};
		foreach (KeyValuePair<long, List<ICustomActivity>> item in dictionary2)
		{
			dictionary.Add(item.Key, item.Value.Select(selector).ToList());
		}
		return dictionary;
	}

	public virtual CustomActivityDTO LoadAsDraft(long id)
	{
		return (CustomActivityDTO)aPcPZkYgkHV5b85Crp2(dX4scSY5mjmp18j32tv(CustomActivityManager, id));
	}

	public virtual CustomActivityDTO Save(CustomActivityDTO ca, bool isDraft, bool generateParametersAssembly)
	{
		//Discarded unreachable code: IL_0168, IL_02ab, IL_02ba
		int num = 17;
		ICustomActivity customActivity2 = default(ICustomActivity);
		CustomActivityDTO customActivityDTO = default(CustomActivityDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				ICustomActivity customActivity;
				switch (num2)
				{
				case 18:
					SortProperties((CustomActivityParameters)BkhEpov80j5y26h7GWR(customActivity2));
					num2 = 14;
					continue;
				case 7:
					onjuFDv3h5JtwiB6hPU(customActivity2, cyfeGWvoodoM55UL4b3(CustomActivityManager, ((EntityDTO<long>)EvK246vXl22ZLSZ3PGO(ca)).Id));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					CustomActivityManager.Save(customActivity2);
					num2 = 6;
					continue;
				case 21:
					awFrdxYZ6AApCoCJJP7(this, customActivity2);
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
					{
						num2 = 12;
					}
					continue;
				case 20:
					if (!isDraft)
					{
						num2 = 7;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 1;
				case 10:
					if (!isDraft || generateParametersAssembly)
					{
						num = 21;
						break;
					}
					goto case 12;
				case 8:
					Mapper.Map<CustomActivityDTO, ICustomActivity>(ca, customActivity2);
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 != 0)
					{
						num2 = 5;
					}
					continue;
				case 19:
					if (customActivityDTO.ScriptModule != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 23;
				case 2:
				case 24:
					CustomActivityHeaderManager.Save((ICustomActivityHeader)q3rCb2vhj11sDX7bQXM(customActivity2));
					num2 = 15;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
					{
						num2 = 18;
					}
					continue;
				case 6:
					if (!isDraft)
					{
						num2 = 15;
						continue;
					}
					goto case 9;
				default:
					((ScriptModuleDTO)pMxro6vwZMVLMUXbpjf(customActivityDTO)).ModuleName = (string)JVPGmMvsg89qPYhAACB(B8YHKOY10PLk8RGedDu(0x5DD795B3 ^ 0x5DD7FF45), M1yhOXvtEFy1aP7MJOc(customActivityDTO).ToString((string)B8YHKOY10PLk8RGedDu(0x747C4140 ^ 0x747C12EE)));
					num2 = 23;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec != 0)
					{
						num2 = 12;
					}
					continue;
				case 3:
					customActivityDTO = Mapper.Map<ICustomActivity, CustomActivityDTO>(customActivity2, ca);
					num2 = 19;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
					{
						num2 = 16;
					}
					continue;
				case 17:
					PL8NVlYICm8u3aT3Z7J(ca, B8YHKOY10PLk8RGedDu(0x467974A9 ^ 0x46791E47));
					num2 = 16;
					continue;
				case 14:
					FixInvalidDefaultParametersValuesIfAny(customActivity2.Parameters);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					heOVFgvCQdICq22xyYS(customActivity2, AuthenticationService.GetCurrentUser<IUser>());
					num2 = 20;
					continue;
				case 13:
				case 15:
					aQ4lKxvF4KTSnsUTDWt(q3rCb2vhj11sDX7bQXM(customActivity2), customActivity2);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 != 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					CustomActivityManager.GenerateCustomActivityParametersAssembly(customActivity2, isDraft);
					num2 = 10;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
					{
						num2 = 7;
					}
					continue;
				case 9:
					uNPjsQvxepfjr4X2nd0(q3rCb2vhj11sDX7bQXM(customActivity2), customActivity2);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
					{
						num2 = 24;
					}
					continue;
				case 12:
					KAb1vOvE2CXL2GJQx8S(customActivity2, atUgIhYzFoCNQTXgBlF());
					num2 = 11;
					continue;
				case 23:
					return customActivityDTO;
				case 5:
					if (generateParametersAssembly)
					{
						num = 22;
						break;
					}
					goto case 10;
				case 16:
					customActivity = CustomActivityManager.LoadOrNull(ca.Id);
					if (customActivity != null)
					{
						goto IL_03c2;
					}
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					{
						customActivity = CustomActivityManager.Create();
						goto IL_03c2;
					}
					IL_03c2:
					customActivity2 = customActivity;
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	public virtual CustomActivityDTO LoadOrNull(Guid id)
	{
		return Mapper.Map<ICustomActivity, CustomActivityDTO>(CustomActivityManager.LoadOrNull(id), new CustomActivityDTO());
	}

	public virtual CustomActivityDTO LoadOrNull(long id)
	{
		return Mapper.Map<ICustomActivity, CustomActivityDTO>(CustomActivityManager.LoadOrNull(id), new CustomActivityDTO());
	}

	public virtual CustomActivityDTO Load(long id)
	{
		return Mapper.Map<ICustomActivity, CustomActivityDTO>(CustomActivityManager.Load(id), new CustomActivityDTO());
	}

	public virtual ScriptModuleDTO LoadScriptModuleForEdit(long caId)
	{
		return Mapper.Map<ScriptModule, ScriptModuleDTO>((ScriptModule)jOPAj1v20EFSp0Sdkad(CustomActivityManager, caId), new ScriptModuleDTO());
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
				ACuS3xvqpi7ukZjbm3y(Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModule));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual CustomActivityDTO DoNew(CustomActivityDTO oldCa, string newPrefix = "", bool copy = false)
	{
		//Discarded unreachable code: IL_01a4, IL_01b3, IL_0273, IL_0286, IL_02bc, IL_03d7, IL_058c, IL_0619, IL_0628, IL_0658, IL_0667
		int num = 51;
		CustomActivityDTO customActivityDTO = default(CustomActivityDTO);
		ScriptModuleDTO scriptModuleDTO = default(ScriptModuleDTO);
		char c = default(char);
		CustomActivityParameters customActivityParameters = default(CustomActivityParameters);
		string text = default(string);
		IEnumerable<ICustomActivityHeader> enumerable = default(IEnumerable<ICustomActivityHeader>);
		ICustomActivityHeader customActivityHeader = default(ICustomActivityHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					customActivityDTO.Header.Id = 0L;
					num2 = 18;
					continue;
				case 39:
					ncaRtXvNJDNhCJPP86O(EvK246vXl22ZLSZ3PGO(customActivityDTO), 0L);
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
					{
						num2 = 5;
					}
					continue;
				case 22:
					SbRsCXv9M2YX8nUGi4Y(customActivityDTO, scriptModuleDTO);
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
					{
						num2 = 0;
					}
					continue;
				case 50:
					if (EvK246vXl22ZLSZ3PGO(oldCa) != null)
					{
						num = 16;
						break;
					}
					goto case 23;
				case 4:
					c = newPrefix[0];
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 != 0)
					{
						num2 = 1;
					}
					continue;
				case 38:
					if (copy)
					{
						num = 25;
						break;
					}
					goto case 11;
				case 43:
					customActivityParameters.Id = 0L;
					num = 40;
					break;
				case 14:
					return null;
				case 25:
				case 44:
					customActivityDTO = ClassSerializationHelper.CloneObject(oldCa);
					num2 = 27;
					continue;
				case 46:
					text = null;
					num2 = 28;
					continue;
				default:
					newPrefix = (string)JVPGmMvsg89qPYhAACB(B8YHKOY10PLk8RGedDu(--286570904 ^ 0x1114E1AA), newPrefix);
					num2 = 30;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
					{
						num2 = 45;
					}
					continue;
				case 30:
					customActivityDTO.ScriptModule.SourceCode = (string)COBtBnvjFVFUyJ8haOM(oHkmKevdnn174slWgMA(pMxro6vwZMVLMUXbpjf(customActivityDTO)), text, a5dSMdvv20AiBelBkLc(IFcVPvva6DkG3vaCeIj(customActivityDTO)));
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 != 0)
					{
						num2 = 0;
					}
					continue;
				case 36:
					scriptModuleDTO = ClassSerializationHelper.CloneObject((ScriptModuleDTO)pMxro6vwZMVLMUXbpjf(oldCa));
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 4;
					}
					continue;
				case 19:
					Cffm35vPcyJKB1CIcFO(customActivityParameters, ((EntityMetadata)IFcVPvva6DkG3vaCeIj(customActivityDTO)).TableName);
					num2 = 31;
					continue;
				case 18:
					if (copy)
					{
						num = 8;
						break;
					}
					goto case 20;
				case 34:
					if (pMxro6vwZMVLMUXbpjf(oldCa) == null)
					{
						num2 = 18;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 32;
				case 40:
					customActivityParameters.Name = (string)a5dSMdvv20AiBelBkLc(IFcVPvva6DkG3vaCeIj(customActivityDTO));
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 != 0)
					{
						num2 = 19;
					}
					continue;
				case 28:
					enumerable = CustomActivityHeaderManager.LoadCustomActivityHeadersByName((string)ot65PQvD9evSNgq0h13(EvK246vXl22ZLSZ3PGO(customActivityDTO)), ignoreCase: true);
					num2 = 35;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
					{
						num2 = 28;
					}
					continue;
				case 6:
					((CustomActivityHeaderDTO)EvK246vXl22ZLSZ3PGO(customActivityDTO)).DraftId = 0L;
					num = 39;
					break;
				case 32:
					customActivityHeader = CustomActivityHeaderManager.LoadOrNull(A46wRTvQsBjit4W1oF3(EvK246vXl22ZLSZ3PGO(oldCa)));
					num2 = 38;
					continue;
				case 41:
					customActivityDTO.Id = 0L;
					num = 46;
					break;
				case 31:
					leD5otv4TLN4lmuQBqc(customActivityDTO, customActivityParameters);
					num2 = 36;
					continue;
				case 33:
				case 49:
					text = ((NamedMetadata)IFcVPvva6DkG3vaCeIj(oldCa)).Name;
					num2 = 31;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c8901ad9999948b380523446821824e3 != 0)
					{
						num2 = 42;
					}
					continue;
				case 13:
					scriptModuleDTO.Uid = rx2O2evMHMxlRoAJ1mQ();
					num2 = 17;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
					{
						num2 = 14;
					}
					continue;
				case 1:
					if (!(c.ToString() != SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3D87FABF ^ 0x3D87A28D)))
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 21:
					if (!aOjMIgvKAltbcYBY9mL(newPrefix))
					{
						num2 = 33;
						continue;
					}
					goto case 26;
				case 17:
					scriptModuleDTO.Id = 0L;
					num2 = 29;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 10;
					}
					continue;
				case 48:
					if (pMxro6vwZMVLMUXbpjf(customActivityDTO) == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 != 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 10;
				case 11:
					if (customActivityHeader == null)
					{
						num2 = 44;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 14;
				case 47:
					xQtLkovcLbCZ3WTdqbZ(EvK246vXl22ZLSZ3PGO(customActivityDTO), 0L);
					num2 = 6;
					continue;
				case 10:
					if (!string.IsNullOrWhiteSpace((string)oHkmKevdnn174slWgMA(customActivityDTO.ScriptModule)))
					{
						num2 = 30;
						continue;
					}
					goto case 9;
				case 15:
					if (enumerable.Count() > 0)
					{
						num2 = 21;
						continue;
					}
					goto case 37;
				case 2:
				case 3:
				case 45:
					customActivityParameters = ClassSerializationHelper.CloneObject((CustomActivityParameters)IFcVPvva6DkG3vaCeIj(oldCa));
					num2 = 7;
					continue;
				case 5:
					if (!aOjMIgvKAltbcYBY9mL(text))
					{
						num2 = 48;
						continue;
					}
					goto case 9;
				case 9:
				case 24:
					return customActivityDTO;
				case 23:
					return null;
				case 8:
					customActivityDTO.Header.Uid = rx2O2evMHMxlRoAJ1mQ();
					num2 = 20;
					continue;
				case 35:
					if (enumerable == null)
					{
						num2 = 37;
						continue;
					}
					goto case 15;
				case 27:
					tpjfmNvVJ1atDiyxitv(customActivityDTO, Guid.NewGuid());
					num2 = 41;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc != 0)
					{
						num2 = 5;
					}
					continue;
				case 29:
					scriptModuleDTO.ClassName = (string)JVPGmMvsg89qPYhAACB(a5dSMdvv20AiBelBkLc(IFcVPvva6DkG3vaCeIj(customActivityDTO)), B8YHKOY10PLk8RGedDu(-1947292726 ^ -1947287350));
					num2 = 22;
					continue;
				case 16:
					if (oldCa.Parameters != null)
					{
						num2 = 34;
						continue;
					}
					goto case 23;
				case 51:
					if (oldCa != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 != 0)
						{
							num2 = 50;
						}
						continue;
					}
					goto case 23;
				case 37:
				case 42:
					if (aOjMIgvKAltbcYBY9mL(newPrefix))
					{
						num2 = 2;
						continue;
					}
					goto case 4;
				case 7:
					M11ZkcvY2cHXTSq5ANj(customActivityParameters, rx2O2evMHMxlRoAJ1mQ());
					num2 = 43;
					continue;
				case 20:
					Ix02S7vTcZG8ZVUQxPy(customActivityDTO.Header, (string)ot65PQvD9evSNgq0h13(EvK246vXl22ZLSZ3PGO(customActivityDTO)) + newPrefix);
					num2 = 47;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
					{
						num2 = 17;
					}
					continue;
				case 26:
					newPrefix = (string)JVPGmMvsg89qPYhAACB(B8YHKOY10PLk8RGedDu(0x7AADECE0 ^ 0x7AADB4D2), rx2O2evMHMxlRoAJ1mQ().ToString((string)B8YHKOY10PLk8RGedDu(0x5A5DBA54 ^ 0x5A5DE9FA)));
					num2 = 49;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
					{
						num2 = 18;
					}
					continue;
				}
				break;
			}
		}
	}

	protected virtual void CompileScripts(ICustomActivity ca)
	{
		//Discarded unreachable code: IL_0046, IL_0078, IL_00a8, IL_00c7, IL_0106, IL_0115, IL_0124
		switch (1)
		{
		case 1:
			try
			{
				nionWAvSyT5EhfHngtL(this, ca);
				int num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (CustomActivityPublishingException)
			{
				int num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					throw;
				}
			}
			catch (Exception innerException)
			{
				int num3 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 != 0)
				{
					num3 = 0;
				}
				long caHeaderId;
				while (true)
				{
					switch (num3)
					{
					default:
						if (q3rCb2vhj11sDX7bQXM(ca) == null)
						{
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 2;
					case 2:
						caHeaderId = ((IEntity<long>)q3rCb2vhj11sDX7bQXM(ca)).Id;
						break;
					case 1:
						caHeaderId = 0L;
						break;
					}
					break;
				}
				throw new CustomActivityPublishingException(caHeaderId, innerException);
			}
		case 0:
			break;
		}
	}

	protected virtual void CompileCustomActivityScripts(ICustomActivity ca)
	{
		//Discarded unreachable code: IL_00a1, IL_00ab, IL_0193, IL_01a2, IL_0225, IL_0238, IL_0252, IL_025c, IL_0319, IL_034d, IL_035c, IL_03cc
		int num = 5;
		int num2 = num;
		ScriptModule scriptModule = default(ScriptModule);
		CustomActivityParameters customActivityParameters = default(CustomActivityParameters);
		List<ScriptCompileMessage>.Enumerator enumerator = default(List<ScriptCompileMessage>.Enumerator);
		ScriptCompileMessage current = default(ScriptCompileMessage);
		ScriptCompileResult scriptCompileResult = default(ScriptCompileResult);
		List<string> errors = default(List<string>);
		while (true)
		{
			long caHeaderId2;
			long caHeaderId;
			switch (num2)
			{
			default:
				return;
			case 1:
				if (scriptModule == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					scriptModule.Uid = rx2O2evMHMxlRoAJ1mQ();
					num2 = 12;
				}
				continue;
			case 5:
				customActivityParameters = (CustomActivityParameters)BkhEpov80j5y26h7GWR(ca);
				num2 = 4;
				continue;
			case 8:
				try
				{
					while (true)
					{
						IL_01d3:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
							{
								num3 = 4;
							}
							goto IL_00af;
						}
						goto IL_016b;
						IL_016b:
						current = enumerator.Current;
						num3 = 5;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
						{
							num3 = 3;
						}
						goto IL_00af;
						IL_00af:
						while (true)
						{
							switch (num3)
							{
							case 1:
								osgmojvG9nxm6IMDMwq(current, COBtBnvjFVFUyJ8haOM(FdC8nkvmmZQok1W2xsj(current), mEqPKsvpW8KToKkSMNG(j6jMUsvA7iW3Tn7G4KE(scriptModule), B8YHKOY10PLk8RGedDu(0x66914DC5 ^ 0x669151F9), scriptModule.ClassName), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-282877824 ^ -282866796)));
								num3 = 6;
								continue;
							case 6:
								osgmojvG9nxm6IMDMwq(current, COBtBnvjFVFUyJ8haOM(FdC8nkvmmZQok1W2xsj(current), customActivityParameters.FullTypeName, B8YHKOY10PLk8RGedDu(0x33BD2188 ^ 0x33BD0D32)));
								num3 = 2;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
								break;
							case 5:
								if (FdC8nkvmmZQok1W2xsj(current) == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 1;
							default:
								goto IL_01d3;
							case 4:
								goto end_IL_01d3;
							}
							break;
						}
						goto IL_016b;
						continue;
						end_IL_01d3:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
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
			case 17:
				caHeaderId2 = ((IEntity<long>)q3rCb2vhj11sDX7bQXM(ca)).Id;
				goto IL_03f9;
			case 9:
				enumerator = scriptCompileResult.Messages.GetEnumerator();
				num2 = 8;
				continue;
			case 15:
				CheckForNeededClass(scriptModule, scriptCompileResult, out errors);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				if (FOQOTkvyipTkW6ovl5s(errors) != 0)
				{
					num2 = 14;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 10;
			case 0:
				return;
			case 18:
				errors = new List<string>();
				num2 = 15;
				continue;
			case 4:
				scriptModule = (ScriptModule)seV0dGvkIxPedbQ88mX(ca);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				if (q3rCb2vhj11sDX7bQXM(ca) == null)
				{
					num2 = 16;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 11;
			case 12:
				SetScriptsAssemblyName(ca);
				num2 = 13;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 == 0)
				{
					num2 = 12;
				}
				continue;
			case 14:
				if (q3rCb2vhj11sDX7bQXM(ca) == null)
				{
					num2 = 6;
					continue;
				}
				goto case 17;
			case 13:
				scriptCompileResult = (ScriptCompileResult)G26oTovUYbSab5Xi6ug(new CustomActivityScriptCompiler(scriptModule, (byte[])XUmyPYvbcoiG4v3vDB9(customActivityParameters)));
				num2 = 9;
				continue;
			case 11:
				caHeaderId = ca.Header.Id;
				break;
			case 3:
				if (!KBWqkBvntAhBOUrnhP6(scriptCompileResult))
				{
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 18;
			case 6:
				caHeaderId2 = 0L;
				goto IL_03f9;
			case 10:
				if (!scriptCompileResult.Success)
				{
					num2 = 7;
					continue;
				}
				return;
			case 16:
				{
					caHeaderId = 0L;
					break;
				}
				IL_03f9:
				throw new CustomActivityPublishingException(caHeaderId2, scriptCompileResult);
			}
			throw new CustomActivityPublishingException(caHeaderId, scriptCompileResult);
		}
	}

	private void SetScriptsAssemblyName(ICustomActivity ca)
	{
		int num = 1;
		Guid guid = default(Guid);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					guid = iV69whvOPi2YggQBECy(seV0dGvkIxPedbQ88mX(ca));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				case 3:
					zkDfJqv65cr3tlMom0w(seV0dGvkIxPedbQ88mX(ca), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--47835757 ^ 0x2D9812D) + text);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			text = guid.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97750002 ^ -97769568));
			num = 3;
		}
	}

	private void CheckForNeededClass(ScriptModule scriptModule, ScriptCompileResult compileResults, out List<string> errors)
	{
		//Discarded unreachable code: IL_0190, IL_01a3, IL_01b2
		int num = 11;
		int num2 = num;
		Type type = default(Type);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!iFuIbNvBTxGmDq0TQmA(type, null))
				{
					num2 = 7;
					continue;
				}
				break;
			case 5:
				AddErrorMessage(text2, compileResults);
				num2 = 6;
				continue;
			case 4:
				errors.Add(text2);
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				type = V0Dbiqv0biPVXRPcr25(GetAssembly(scriptModule), JVPGmMvsg89qPYhAACB(B8YHKOY10PLk8RGedDu(0x3F8E27D0 ^ 0x3F8E4CA0), peoHkFvRu9pod3JHEdg(scriptModule)));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 != 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				errors.Add(text);
				num2 = 8;
				continue;
			case 2:
				return;
			case 7:
				if (!(type.GetMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3F8E27D0 ^ 0x3F8E26BE)) == null))
				{
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 3;
			case 11:
				errors = new List<string>();
				num2 = 10;
				continue;
			case 3:
				text2 = (string)UlTS6mvWJM9MQcT1D9S(B8YHKOY10PLk8RGedDu(-905209456 ^ -905186694), new object[1] { scriptModule.ClassName });
				num2 = 4;
				continue;
			case 8:
				AddErrorMessage(text, compileResults);
				num2 = 2;
				continue;
			case 6:
				return;
			case 12:
				return;
			case 1:
				break;
			}
			text = (string)UlTS6mvWJM9MQcT1D9S(B8YHKOY10PLk8RGedDu(-79921577 ^ -79948291), new object[1] { peoHkFvRu9pod3JHEdg(scriptModule) });
			num2 = 9;
		}
	}

	private Assembly GetAssembly(ScriptModule scriptModule)
	{
		int num = 3;
		int num2 = num;
		Assembly assembly = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			default:
				return assembly;
			case 3:
				if (ki9mOXvHW08gQXH30fq(scriptModule) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa != 0)
					{
						num2 = 2;
					}
					break;
				}
				assembly = ComponentManager.FindLoadedAssembly(scriptModule.AssemblyName, isFullName: true);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				throw new Exception((string)s6dyATveZ1o3rqNOKm7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979431200 ^ -1979438430)));
			case 4:
				assembly = ComponentManager.LoadAssembly((byte[])ki9mOXvHW08gQXH30fq(scriptModule), (byte[])YZR2OqvuuB8C8VYL7F2(scriptModule));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (GJdUyUvieUXBwr6A2k9(assembly, null))
				{
					num2 = 4;
					break;
				}
				goto default;
			}
		}
	}

	private void AddErrorMessage(string message, ScriptCompileResult compileResults)
	{
		int num = 2;
		int num2 = num;
		ScriptCompileMessage item = default(ScriptCompileMessage);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
			{
				ScriptCompileMessage obj = new ScriptCompileMessage
				{
					Column = 0
				};
				eVQl1gvlR3wPy1NNuM4(obj, 0);
				obj.Message = message;
				FKfVFgvfgG7APdGPBq2(obj, ScriptCompileMessageType.Error);
				obj.Index = compileResults.Messages.Count();
				item = obj;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
				compileResults.Messages.Add(item);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private bool IsInt64SettingsValid(EntityPropertyMetadata property)
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_00cb, IL_00d5
		int num = 5;
		int num2 = num;
		Int64Settings int64Settings = default(Int64Settings);
		long? defaultValue = default(long?);
		bool flag = default(bool);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 4:
				if (!RangeForInt64NotSet(int64Settings))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 7:
				defaultValue = int64Settings.DefaultValue;
				num2 = 6;
				continue;
			case 5:
				int64Settings = ODlXYQvLD2GU1Sf7f7J(property) as Int64Settings;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
				{
					num2 = 4;
				}
				continue;
			case 6:
				num3 = ((!defaultValue.HasValue) ? 1 : 0);
				break;
			case 3:
				return !flag;
			case 1:
				return true;
			default:
				if (!jd7nFavJljIjt8pjMHe(property))
				{
					num2 = 2;
					continue;
				}
				goto case 7;
			case 2:
				num3 = 0;
				break;
			}
			defaultValue = int64Settings.DefaultValue;
			int num5;
			if (defaultValue.HasValue)
			{
				defaultValue = int64Settings.DefaultValue;
				long num4 = AAFgKYvrI3vasAax4eD(int64Settings);
				if (!(defaultValue < num4))
				{
					defaultValue = int64Settings.DefaultValue;
					num4 = int64Settings.MaxValue;
					num5 = ((defaultValue > num4) ? 1 : 0);
				}
				else
				{
					num5 = 1;
				}
			}
			else
			{
				num5 = 1;
			}
			flag = (byte)num5 != 0;
			if (num3 != 0)
			{
				break;
			}
			num2 = 3;
		}
		return true;
	}

	private bool RangeForInt64NotSet(Int64Settings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (AAFgKYvrI3vasAax4eD(settings) == long.MinValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return uFGsf4v7RiwJu46wj8e(settings) == long.MaxValue;
			}
		}
	}

	private void FixInt64Settings(EntityPropertyMetadata property)
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
			{
				Int64Settings obj = property.Settings as Int64Settings;
				obj.DefaultValue = AAFgKYvrI3vasAax4eD(obj);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private bool IsDoubleSettingsValid(EntityPropertyMetadata property)
	{
		//Discarded unreachable code: IL_004b, IL_007f, IL_00e4, IL_00f3
		int num = 1;
		int num2 = num;
		double? defaultValue = default(double?);
		DoubleSettings doubleSettings = default(DoubleSettings);
		bool flag = default(bool);
		while (true)
		{
			int num3;
			int num5;
			switch (num2)
			{
			case 6:
				num3 = ((!defaultValue.HasValue) ? 1 : 0);
				goto IL_00ff;
			default:
				if (RangeForDoubleNotSet(doubleSettings))
				{
					num2 = 7;
					break;
				}
				if (!jd7nFavJljIjt8pjMHe(property))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 3:
				defaultValue = doubleSettings.DefaultValue;
				num2 = 6;
				break;
			case 2:
				return !flag;
			case 5:
				return true;
			case 1:
				doubleSettings = property.Settings as DoubleSettings;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return true;
			case 4:
				{
					num3 = 0;
					goto IL_00ff;
				}
				IL_00ff:
				defaultValue = doubleSettings.DefaultValue;
				if (defaultValue.HasValue)
				{
					defaultValue = doubleSettings.DefaultValue;
					double num4 = fk3sbEv5Vq7Mt1gJd7g(doubleSettings);
					if (!(defaultValue < num4))
					{
						defaultValue = doubleSettings.DefaultValue;
						num4 = doubleSettings.MaxValue;
						num5 = ((defaultValue > num4) ? 1 : 0);
					}
					else
					{
						num5 = 1;
					}
				}
				else
				{
					num5 = 1;
				}
				flag = (byte)num5 != 0;
				if (num3 != 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private bool RangeForDoubleNotSet(DoubleSettings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (settings.MinValue == -1E+300)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return settings.MaxValue == 1E+300;
			}
		}
	}

	private void FixDoubleSettings(EntityPropertyMetadata property)
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
			{
				DoubleSettings obj = ODlXYQvLD2GU1Sf7f7J(property) as DoubleSettings;
				obj.DefaultValue = obj.MinValue;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	private void FixInvalidDefaultParametersValuesIfAny(CustomActivityParameters parametersContainer)
	{
		//Discarded unreachable code: IL_005a, IL_0172, IL_0181, IL_01c4, IL_01e3, IL_01f2, IL_020f, IL_021e
		int num = 3;
		int num2 = num;
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				if (parametersContainer != null)
				{
					enumerator = ((IEnumerable<EntityPropertyMetadata>)parametersContainer.EntityProperties).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bfa1473b6a64d0f975c9b2348e2eb28 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce != 0)
					{
						num2 = 0;
					}
				}
				continue;
			case 1:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 4;
						goto IL_0068;
					}
					goto IL_00ed;
					IL_0068:
					while (true)
					{
						switch (num3)
						{
						case 2:
							FixDoubleSettings(current);
							num3 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						case 5:
						case 9:
							if (ODlXYQvLD2GU1Sf7f7J(current) is DoubleSettings)
							{
								num3 = 3;
								continue;
							}
							break;
						case 7:
							goto IL_00ed;
						default:
							if (IsInt64SettingsValid(current))
							{
								num3 = 5;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 8;
						case 6:
							if (current.Settings is Int64Settings)
							{
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 5;
						case 3:
							if (!IsDoubleSettingsValid(current))
							{
								num3 = 2;
								continue;
							}
							break;
						case 8:
							FixInt64Settings(current);
							num3 = 9;
							continue;
						case 4:
							return;
						}
						break;
					}
					continue;
					IL_00ed:
					current = enumerator.Current;
					int num4 = 6;
					num3 = num4;
					goto IL_0068;
				}
			}
			finally
			{
				int num5;
				if (enumerator == null)
				{
					num5 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 == 0)
					{
						num5 = 1;
					}
					goto IL_01c8;
				}
				goto IL_01fd;
				IL_01fd:
				enumerator.Dispose();
				num5 = 2;
				goto IL_01c8;
				IL_01c8:
				switch (num5)
				{
				case 1:
					goto end_IL_01a3;
				case 2:
					goto end_IL_01a3;
				}
				goto IL_01fd;
				end_IL_01a3:;
			}
		}
	}

	private int PropertiesComparision(EntityPropertyMetadata a, EntityPropertyMetadata b)
	{
		return ISotvsvg3GX7woFs0uM(a) - ISotvsvg3GX7woFs0uM(b);
	}

	private void SortProperties(CustomActivityParameters parametersContainer)
	{
		int num = 2;
		int num2 = num;
		List<EntityPropertyMetadata> list = default(List<EntityPropertyMetadata>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				list.Sort(PropertiesComparision);
				num2 = 3;
				break;
			case 1:
				list = ((IEnumerable<EntityPropertyMetadata>)parametersContainer.EntityProperties).ToList();
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 5:
				parametersContainer.EntityProperties.AddAll((ICollection<EntityPropertyMetadata>)list);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (parametersContainer == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				((ICollection<EntityPropertyMetadata>)parametersContainer.EntityProperties).Clear();
				num2 = 5;
				break;
			}
		}
	}

	private void PublishCustomActivity(ICustomActivity entity, CustomActivityDTO ca)
	{
		//Discarded unreachable code: IL_004b, IL_0150, IL_0188, IL_0197
		switch (1)
		{
		case 1:
			try
			{
				v2ojD5v1mMUa7TTRUTv(CustomActivityManager, entity);
				int num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_128870479a48410393b814985ef83c9e == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						aUfxSmYLZFf6YYZqoGl(this, ca, false);
						num = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
						{
							num = 4;
						}
						break;
					case 1:
						if (q3rCb2vhj11sDX7bQXM(entity) != null)
						{
							num = 3;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 == 0)
							{
								num = 0;
							}
							break;
						}
						goto case 2;
					default:
						Mapper.Map<ICustomActivity, CustomActivityDTO>(entity, ca);
						num = 5;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 == 0)
						{
							num = 5;
						}
						break;
					case 3:
						YemovlvZHLLDtcvEwiV(EvK246vXl22ZLSZ3PGO(ca), vmXTQBvIw7JYTCGrggr(q3rCb2vhj11sDX7bQXM(entity)));
						num = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
						{
							num = 2;
						}
						break;
					case 5:
						if (EvK246vXl22ZLSZ3PGO(ca) != null)
						{
							num = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 == 0)
							{
								num = 1;
							}
							break;
						}
						goto case 2;
					case 4:
						return;
					}
				}
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						throw;
					}
					bWilrmvzWCSxQhPXWmK(entity);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
					{
						num2 = 1;
					}
				}
			}
		case 0:
			break;
		}
	}

	public CustomActivityDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool c66BONYlgC2OSUmWIAA()
	{
		return Wgac2SYuwgYoEPX87em == null;
	}

	internal static CustomActivityDTOManager TxJXTSYf5f1dRI9gNwp()
	{
		return Wgac2SYuwgYoEPX87em;
	}

	internal static object aUfxSmYLZFf6YYZqoGl(object P_0, object P_1, bool isDraft)
	{
		return ((CustomActivityDTOManager)P_0).Save((CustomActivityDTO)P_1, isDraft);
	}

	internal static void qsBUeyYJUbudIVS9EAI(object P_0)
	{
		((CustomActivityDTO)P_0).ResetIdsForPublish();
	}

	internal static void eRqt9TYr9HSXnDdZVbI(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object YWKfL1Y7nxTeKp1lvil(object P_0, object P_1, bool isDraft, bool generateParametersAssembly)
	{
		return ((CustomActivityDTOManager)P_0).Save((CustomActivityDTO)P_1, isDraft, generateParametersAssembly);
	}

	internal static object dX4scSY5mjmp18j32tv(object P_0, long id)
	{
		return ((CustomActivityManager)P_0).LoadAsDraft(id);
	}

	internal static object aPcPZkYgkHV5b85Crp2(object P_0)
	{
		return ((ICustomActivity)P_0).CreateDTO();
	}

	internal static object B8YHKOY10PLk8RGedDu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void PL8NVlYICm8u3aT3Z7J(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void awFrdxYZ6AApCoCJJP7(object P_0, object P_1)
	{
		((CustomActivityDTOManager)P_0).CompileScripts((ICustomActivity)P_1);
	}

	internal static DateTime atUgIhYzFoCNQTXgBlF()
	{
		return DateTime.Now;
	}

	internal static void KAb1vOvE2CXL2GJQx8S(object P_0, DateTime value)
	{
		((ICustomActivity)P_0).CreationDate = value;
	}

	internal static void heOVFgvCQdICq22xyYS(object P_0, object P_1)
	{
		((ICustomActivity)P_0).CreationAuthor = (IUser)P_1;
	}

	internal static object EvK246vXl22ZLSZ3PGO(object P_0)
	{
		return ((CustomActivityDTO)P_0).Header;
	}

	internal static long cyfeGWvoodoM55UL4b3(object P_0, long headerId)
	{
		return ((CustomActivityManager)P_0).GetPublishingVersionNumber(headerId);
	}

	internal static void onjuFDv3h5JtwiB6hPU(object P_0, long value)
	{
		((ICustomActivity)P_0).VersionNumber = value;
	}

	internal static object q3rCb2vhj11sDX7bQXM(object P_0)
	{
		return ((ICustomActivity)P_0).Header;
	}

	internal static void uNPjsQvxepfjr4X2nd0(object P_0, object P_1)
	{
		((ICustomActivityHeader)P_0).Draft = (ICustomActivity)P_1;
	}

	internal static void aQ4lKxvF4KTSnsUTDWt(object P_0, object P_1)
	{
		((ICustomActivityHeader)P_0).Published = (ICustomActivity)P_1;
	}

	internal static object BkhEpov80j5y26h7GWR(object P_0)
	{
		return ((ICustomActivity)P_0).Parameters;
	}

	internal static object pMxro6vwZMVLMUXbpjf(object P_0)
	{
		return ((CustomActivityDTO)P_0).ScriptModule;
	}

	internal static Guid M1yhOXvtEFy1aP7MJOc(object P_0)
	{
		return ((CustomActivityDTO)P_0).Uid;
	}

	internal static object JVPGmMvsg89qPYhAACB(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object jOPAj1v20EFSp0Sdkad(object P_0, long caId)
	{
		return ((CustomActivityManager)P_0).LoadScriptModuleForEdit(caId);
	}

	internal static void ACuS3xvqpi7ukZjbm3y(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static Guid A46wRTvQsBjit4W1oF3(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).Uid;
	}

	internal static void tpjfmNvVJ1atDiyxitv(object P_0, Guid value)
	{
		((CustomActivityDTO)P_0).Uid = value;
	}

	internal static object ot65PQvD9evSNgq0h13(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).Name;
	}

	internal static bool aOjMIgvKAltbcYBY9mL(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static Guid rx2O2evMHMxlRoAJ1mQ()
	{
		return Guid.NewGuid();
	}

	internal static object IFcVPvva6DkG3vaCeIj(object P_0)
	{
		return ((CustomActivityDTO)P_0).Parameters;
	}

	internal static void M11ZkcvY2cHXTSq5ANj(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static object a5dSMdvv20AiBelBkLc(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void Cffm35vPcyJKB1CIcFO(object P_0, object P_1)
	{
		((EntityMetadata)P_0).TableName = (string)P_1;
	}

	internal static void leD5otv4TLN4lmuQBqc(object P_0, object P_1)
	{
		((CustomActivityDTO)P_0).Parameters = (CustomActivityParameters)P_1;
	}

	internal static void SbRsCXv9M2YX8nUGi4Y(object P_0, object P_1)
	{
		((CustomActivityDTO)P_0).ScriptModule = (ScriptModuleDTO)P_1;
	}

	internal static void Ix02S7vTcZG8ZVUQxPy(object P_0, object P_1)
	{
		((CustomActivityHeaderDTO)P_0).Name = (string)P_1;
	}

	internal static void xQtLkovcLbCZ3WTdqbZ(object P_0, long value)
	{
		((CustomActivityHeaderDTO)P_0).PublishedId = value;
	}

	internal static void ncaRtXvNJDNhCJPP86O(object P_0, long value)
	{
		((CustomActivityHeaderDTO)P_0).FolderId = value;
	}

	internal static object oHkmKevdnn174slWgMA(object P_0)
	{
		return ((ScriptModuleDTO)P_0).SourceCode;
	}

	internal static object COBtBnvjFVFUyJ8haOM(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void nionWAvSyT5EhfHngtL(object P_0, object P_1)
	{
		((CustomActivityDTOManager)P_0).CompileCustomActivityScripts((ICustomActivity)P_1);
	}

	internal static object seV0dGvkIxPedbQ88mX(object P_0)
	{
		return ((ICustomActivity)P_0).ScriptModule;
	}

	internal static object XUmyPYvbcoiG4v3vDB9(object P_0)
	{
		return ((CustomActivityParameters)P_0).AssemblyRaw;
	}

	internal static object G26oTovUYbSab5Xi6ug(object P_0)
	{
		return ((ScriptCompiler)P_0).Compile();
	}

	internal static object FdC8nkvmmZQok1W2xsj(object P_0)
	{
		return ((ScriptCompileMessage)P_0).Message;
	}

	internal static object j6jMUsvA7iW3Tn7G4KE(object P_0)
	{
		return ((ScriptModule)P_0).Namespace;
	}

	internal static object mEqPKsvpW8KToKkSMNG(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void osgmojvG9nxm6IMDMwq(object P_0, object P_1)
	{
		((ScriptCompileMessage)P_0).Message = (string)P_1;
	}

	internal static bool KBWqkBvntAhBOUrnhP6(object P_0)
	{
		return ((ScriptCompileResult)P_0).Success;
	}

	internal static int FOQOTkvyipTkW6ovl5s(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static Guid iV69whvOPi2YggQBECy(object P_0)
	{
		return ((ScriptModule)P_0).Uid;
	}

	internal static void zkDfJqv65cr3tlMom0w(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyName = (string)P_1;
	}

	internal static object peoHkFvRu9pod3JHEdg(object P_0)
	{
		return ((ScriptModule)P_0).ClassName;
	}

	internal static Type V0Dbiqv0biPVXRPcr25(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool iFuIbNvBTxGmDq0TQmA(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object UlTS6mvWJM9MQcT1D9S(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object ki9mOXvHW08gQXH30fq(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyRaw;
	}

	internal static object s6dyATveZ1o3rqNOKm7(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool GJdUyUvieUXBwr6A2k9(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object YZR2OqvuuB8C8VYL7F2(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static void eVQl1gvlR3wPy1NNuM4(object P_0, int P_1)
	{
		((ScriptCompileMessage)P_0).Line = P_1;
	}

	internal static void FKfVFgvfgG7APdGPBq2(object P_0, ScriptCompileMessageType P_1)
	{
		((ScriptCompileMessage)P_0).Type = P_1;
	}

	internal static object ODlXYQvLD2GU1Sf7f7J(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool jd7nFavJljIjt8pjMHe(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static long AAFgKYvrI3vasAax4eD(object P_0)
	{
		return ((Int64Settings)P_0).MinValue;
	}

	internal static long uFGsf4v7RiwJu46wj8e(object P_0)
	{
		return ((Int64Settings)P_0).MaxValue;
	}

	internal static double fk3sbEv5Vq7Mt1gJd7g(object P_0)
	{
		return ((DoubleSettings)P_0).MinValue;
	}

	internal static int ISotvsvg3GX7woFs0uM(object P_0)
	{
		return ((PropertyMetadata)P_0).Order;
	}

	internal static void v2ojD5v1mMUa7TTRUTv(object P_0, object P_1)
	{
		((CustomActivityManager)P_0).Publish((ICustomActivity)P_1);
	}

	internal static bool vmXTQBvIw7JYTCGrggr(object P_0)
	{
		return ((ICustomActivityHeader)P_0).IsDirtyCustomActivity;
	}

	internal static void YemovlvZHLLDtcvEwiV(object P_0, bool value)
	{
		((CustomActivityHeaderDTO)P_0).IsDirtyCustomActivity = value;
	}

	internal static void bWilrmvzWCSxQhPXWmK(object P_0)
	{
		((IEntity)P_0).Delete();
	}
}
