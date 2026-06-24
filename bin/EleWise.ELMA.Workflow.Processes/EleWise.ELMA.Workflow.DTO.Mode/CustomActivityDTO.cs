using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
public class CustomActivityDTO : EntityDTO<long>, IMetadata, IXsiType
{
	private static CustomActivityDTO qbNJOu9X5liulWYs9bR;

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Guid ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
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
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
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

	[DefaultValue(false)]
	public virtual bool Internal
	{
		[CompilerGenerated]
		get
		{
			return _003CInternal_003Ek__BackingField;
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
					_003CInternal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 != 0)
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

	public ScriptModuleDTO ScriptModule
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptModule_003Ek__BackingField;
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
					_003CScriptModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
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

	public CustomActivityParameters Parameters
	{
		[CompilerGenerated]
		get
		{
			return _003CParameters_003Ek__BackingField;
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
					_003CParameters_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CustomActivityHeaderDTO Header
	{
		[CompilerGenerated]
		get
		{
			return _003CHeader_003Ek__BackingField;
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
					_003CHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationDate_003Ek__BackingField;
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
					_003CCreationDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual UserDTO CreationAuthor
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationAuthor_003Ek__BackingField;
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
					_003CCreationAuthor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual long VersionNumber
	{
		[CompilerGenerated]
		get
		{
			return _003CVersionNumber_003Ek__BackingField;
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
					_003CVersionNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CustomActivityDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Parameters = new CustomActivityParameters();
				num = 2;
				break;
			case 1:
				Header = new CustomActivityHeaderDTO();
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeModuleUid()
	{
		return JZcaqb9xgsvJT9VyBPb(R2Ptdj9hypOyRCPyjtP(this), Guid.Empty);
	}

	public void ResetIdsForPublish()
	{
		//Discarded unreachable code: IL_0088, IL_0097, IL_00a2, IL_012b, IL_0163
		int num = 6;
		int num2 = num;
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				ScriptModule.Id = 0L;
				num2 = 2;
				break;
			default:
				Parameters.Id = 0L;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_51bbd8978ad84af991914149de98c8c6 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				try
				{
					while (true)
					{
						int num3;
						if (!RF37OV9wcWKga5cWXhP(enumerator))
						{
							num3 = 2;
							goto IL_00a6;
						}
						goto IL_00bc;
						IL_00a6:
						switch (num3)
						{
						case 1:
							break;
						default:
							continue;
						case 2:
							goto end_IL_00ef;
						}
						goto IL_00bc;
						IL_00bc:
						EntityPropertyMetadata current = enumerator.Current;
						current.Id = 0L;
						v6yl4U98RcAlWyYWOwP(current, Guid.NewGuid());
						num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
						{
							num3 = 0;
						}
						goto IL_00a6;
						continue;
						end_IL_00ef:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
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
				goto case 8;
			case 9:
				return;
			case 3:
				enumerator = ((IEnumerable<EntityPropertyMetadata>)Parameters.EntityProperties).GetEnumerator();
				num2 = 7;
				break;
			case 6:
				base.Id = 0L;
				num2 = 5;
				break;
			case 4:
				if (Parameters != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 1:
				v6yl4U98RcAlWyYWOwP(Parameters, roFRM39FeelrOjWP4vR());
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				ScriptModule.Uid = Guid.NewGuid();
				num2 = 9;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				Uid = Guid.NewGuid();
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void InitNew()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				Uid = roFRM39FeelrOjWP4vR();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ScriptModuleDTO scriptModuleDTO = new ScriptModuleDTO();
			bVbkU69tLYAc66sLKF5(scriptModuleDTO, Guid.NewGuid());
			scriptModuleDTO.ModuleTypeUid = CustomActivityScriptModuleType.UID;
			LLVsmX9s3eJ804up4Jk(scriptModuleDTO, Uid);
			ScriptModule = scriptModuleDTO;
			num2 = 2;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 == 0)
			{
				num2 = 1;
			}
		}
	}

	public virtual void CopyIdsFrom([CanBeNull] CustomActivityDTO dto)
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 3:
					if (ScriptModule == null)
					{
						return;
					}
					num = 4;
					break;
				case 7:
					VersionNumber = 0L;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (Parameters != null)
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				case 6:
					base.Id = dto?.Id ?? 0;
					num2 = 5;
					continue;
				case 5:
					Uid = dto?.Uid ?? Guid.NewGuid();
					num = 7;
					break;
				case 8:
					CopyParametersIdsFrom(Parameters, (EntityMetadata)((dto != null) ? JIj8j292eVTjqs70XU2(dto) : null));
					num2 = 3;
					continue;
				case 4:
					ScriptModule.Id = ((dto != null && Uixnx19qbs8Um3rXWiH(dto) != null) ? ((EntityDTO<long>)Uixnx19qbs8Um3rXWiH(dto)).Id : 0);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					bVbkU69tLYAc66sLKF5(ScriptModule, (dto != null && Uixnx19qbs8Um3rXWiH(dto) != null) ? ((ScriptModuleDTO)Uixnx19qbs8Um3rXWiH(dto)).Uid : roFRM39FeelrOjWP4vR());
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public static CustomActivityDTO New(long folderId = 0L)
	{
		CustomActivityDTO customActivityDTO = new CustomActivityDTO();
		HU0eMr9QwuKZudt4UGf(customActivityDTO);
		return customActivityDTO;
	}

	private void InitScriptModule()
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
				ScriptModuleDTO scriptModuleDTO = new ScriptModuleDTO();
				bVbkU69tLYAc66sLKF5(scriptModuleDTO, roFRM39FeelrOjWP4vR());
				scriptModuleDTO.ModuleTypeUid = CustomActivityScriptModuleType.UID;
				LLVsmX9s3eJ804up4Jk(scriptModuleDTO, Uid);
				ScriptModule = scriptModuleDTO;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc != 0)
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

	public virtual void AfterLoad()
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				InitScriptModule();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (ScriptModule != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 0:
				return;
			case 3:
				return;
			}
		}
	}

	private void CopyParametersIdsFrom(EntityMetadata target, EntityMetadata source)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_012a, IL_0198, IL_01f6, IL_0209, IL_0219, IL_0228, IL_02c5, IL_035b, IL_036e
		int num = 2;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass44_1 _003C_003Ec__DisplayClass44_2 = default(_003C_003Ec__DisplayClass44_1);
		TablePartMetadata source2 = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				enumerator = target.Properties.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				return;
			case 3:
				enumerator2 = target.TableParts.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				try
				{
					while (true)
					{
						IL_0299:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
							{
								num3 = 0;
							}
							goto IL_0237;
						}
						goto IL_02ca;
						IL_02ca:
						_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
						num3 = 4;
						goto IL_0237;
						IL_0237:
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 5:
								if (source == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								obj = source.Properties.FirstOrDefault(_003C_003Ec__DisplayClass44_._003CCopyParametersIdsFrom_003Eb__0);
								goto IL_02f3;
							case 4:
							{
								_003C_003Ec__DisplayClass44_.p = enumerator.Current;
								int num4 = 5;
								num3 = num4;
								continue;
							}
							case 2:
								goto IL_0299;
							case 1:
								obj = null;
								goto IL_02f3;
							case 6:
								goto IL_02ca;
							case 3:
								_003C_003Ec__DisplayClass44_.p.Id = propertyMetadata?.Id ?? 0;
								num3 = 2;
								continue;
							case 0:
								break;
								IL_02f3:
								propertyMetadata = (PropertyMetadata)obj;
								num3 = 3;
								continue;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 2:
				target.Id = source?.Id ?? 0;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				target.Uid = ((source != null) ? eBFELt9VjYVZhK3FvH6(source) : roFRM39FeelrOjWP4vR());
				num2 = 4;
				continue;
			}
			try
			{
				while (true)
				{
					int num6;
					if (!enumerator2.MoveNext())
					{
						num6 = 8;
						goto IL_00ab;
					}
					goto IL_012f;
					IL_00ab:
					while (true)
					{
						object obj2;
						switch (num6)
						{
						case 8:
							return;
						default:
						{
							_003C_003Ec__DisplayClass44_2.tp = enumerator2.Current;
							int num7 = 5;
							num6 = num7;
							continue;
						}
						case 4:
							break;
						case 6:
							CopyParametersIdsFrom(_003C_003Ec__DisplayClass44_2.tp, source2);
							num6 = 4;
							continue;
						case 2:
							obj2 = null;
							goto IL_01be;
						case 1:
							goto IL_012f;
						case 5:
							eaq2Fs9DFDmWH5WyI8N(_003C_003Ec__DisplayClass44_2.tp.Properties.First(_003C_003Ec__DisplayClass44_2._003CCopyParametersIdsFrom_003Eb__1), eBFELt9VjYVZhK3FvH6(target));
							num6 = 3;
							continue;
						case 3:
							if (source != null)
							{
								num6 = 7;
								continue;
							}
							goto case 2;
						case 7:
							{
								obj2 = source.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass44_2._003CCopyParametersIdsFrom_003Eb__2);
								goto IL_01be;
							}
							IL_01be:
							source2 = (TablePartMetadata)obj2;
							num6 = 6;
							continue;
						}
						break;
					}
					continue;
					IL_012f:
					_003C_003Ec__DisplayClass44_2 = new _003C_003Ec__DisplayClass44_1();
					num6 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
					{
						num6 = 0;
					}
					goto IL_00ab;
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
				int num8 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b != 0)
				{
					num8 = 0;
				}
				switch (num8)
				{
				case 0:
					break;
				}
			}
		}
	}

	internal static bool MyIvcH9oWQ3TRG15UJx()
	{
		return qbNJOu9X5liulWYs9bR == null;
	}

	internal static CustomActivityDTO flLCrS93vyohBcidfyg()
	{
		return qbNJOu9X5liulWYs9bR;
	}

	internal static Guid R2Ptdj9hypOyRCPyjtP(object P_0)
	{
		return ((CustomActivityDTO)P_0).ModuleUid;
	}

	internal static bool JZcaqb9xgsvJT9VyBPb(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid roFRM39FeelrOjWP4vR()
	{
		return Guid.NewGuid();
	}

	internal static void v6yl4U98RcAlWyYWOwP(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static bool RF37OV9wcWKga5cWXhP(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void bVbkU69tLYAc66sLKF5(object P_0, Guid P_1)
	{
		((ScriptModuleDTO)P_0).Uid = P_1;
	}

	internal static void LLVsmX9s3eJ804up4Jk(object P_0, Guid P_1)
	{
		((ScriptModuleDTO)P_0).ObjectUid = P_1;
	}

	internal static object JIj8j292eVTjqs70XU2(object P_0)
	{
		return ((CustomActivityDTO)P_0).Parameters;
	}

	internal static object Uixnx19qbs8Um3rXWiH(object P_0)
	{
		return ((CustomActivityDTO)P_0).ScriptModule;
	}

	internal static void HU0eMr9QwuKZudt4UGf(object P_0)
	{
		((CustomActivityDTO)P_0).InitNew();
	}

	internal static Guid eBFELt9VjYVZhK3FvH6(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void eaq2Fs9DFDmWH5WyI8N(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}
}
