using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.DTO.Managers;

public class FormMetadataItemGroupDTOManager : DTOManager, IFormMetadataItemGroupDTOManager, IConfigurationService
{
	private static FormMetadataItemGroupDTOManager Bt06qQ9KfrF3DkwRtRT;

	public FormMetadataItemGroupManager FormMetadataItemGroupManager
	{
		[CompilerGenerated]
		get
		{
			return _003CFormMetadataItemGroupManager_003Ek__BackingField;
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
					_003CFormMetadataItemGroupManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FormMetadataItemHeaderManager FormMetadataItemHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CFormMetadataItemHeaderManager_003Ek__BackingField;
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
					_003CFormMetadataItemHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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

	public ISecurityService SecurityService
	{
		[CompilerGenerated]
		get
		{
			return _003CSecurityService_003Ek__BackingField;
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
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

	public virtual FormMetadataItemGroupDTO LoadRootGroup(Guid metadataType)
	{
		//Discarded unreachable code: IL_004e, IL_005d, IL_0068, IL_010f, IL_014f, IL_015e, IL_016a, IL_01b5, IL_01c4, IL_0224, IL_0317, IL_0354, IL_0384, IL_0393, IL_039f, IL_03b3, IL_03bd, IL_04e2, IL_04f1, IL_054b, IL_056a, IL_0579, IL_05a6
		int num = 1;
		int num2 = num;
		IEnumerator<FormMetadataItemGroupDTO> enumerator = default(IEnumerator<FormMetadataItemGroupDTO>);
		FormMetadataItemGroupDTO current = default(FormMetadataItemGroupDTO);
		Dictionary<long, FormMetadataItemGroupDTO> dictionary = default(Dictionary<long, FormMetadataItemGroupDTO>);
		FormMetadataItemGroupDTO formMetadataItemGroupDTO = default(FormMetadataItemGroupDTO);
		IEnumerable<FormMetadataItemGroupDTO> enumerable = default(IEnumerable<FormMetadataItemGroupDTO>);
		IEnumerator<FormMetadataItemHeaderDTO> enumerator2 = default(IEnumerator<FormMetadataItemHeaderDTO>);
		FormMetadataItemHeaderDTO current3 = default(FormMetadataItemHeaderDTO);
		FormMetadataItemGroupDTO value2 = default(FormMetadataItemGroupDTO);
		long? parentId = default(long?);
		FormMetadataItemGroupDTO value = default(FormMetadataItemGroupDTO);
		FormMetadataItemGroupDTO current2 = default(FormMetadataItemGroupDTO);
		IEnumerable<FormMetadataItemHeaderDTO> enumerable2 = default(IEnumerable<FormMetadataItemHeaderDTO>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				try
				{
					while (true)
					{
						IL_00a9:
						int num3;
						if (!zupr4Y9nIql4F9C1wvo(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num3 = 0;
							}
							goto IL_006c;
						}
						goto IL_0086;
						IL_0086:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num3 = 0;
						}
						goto IL_006c;
						IL_006c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								goto IL_0086;
							case 2:
								goto IL_00a9;
							case 1:
								dictionary[current.Id] = current;
								num3 = 2;
								continue;
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
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num4 = 1;
						}
						goto IL_0113;
					}
					goto IL_0129;
					IL_0129:
					enumerator.Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num4 = 0;
					}
					goto IL_0113;
					IL_0113:
					switch (num4)
					{
					default:
						goto end_IL_00ee;
					case 1:
						break;
					case 2:
						goto end_IL_00ee;
					case 0:
						goto end_IL_00ee;
					}
					goto IL_0129;
					end_IL_00ee:;
				}
				goto case 9;
			case 1:
			{
				FormMetadataItemGroupDTO formMetadataItemGroupDTO2 = new FormMetadataItemGroupDTO();
				s1AneE9kLWDVlq5Cl94(formMetadataItemGroupDTO2, metadataType);
				formMetadataItemGroupDTO = formMetadataItemGroupDTO2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				enumerator = enumerable.GetEnumerator();
				num2 = 7;
				break;
			case 8:
				try
				{
					while (true)
					{
						IL_02ad:
						int num7;
						if (!zupr4Y9nIql4F9C1wvo(enumerator2))
						{
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
							{
								num7 = 1;
							}
							goto IL_01d3;
						}
						goto IL_0267;
						IL_0267:
						current3 = enumerator2.Current;
						num7 = 8;
						goto IL_01d3;
						IL_01d3:
						while (true)
						{
							switch (num7)
							{
							case 9:
								value2 = formMetadataItemGroupDTO;
								num7 = 6;
								continue;
							case 7:
							case 10:
								if (value2 != null)
								{
									num7 = 4;
									continue;
								}
								goto case 9;
							case 11:
							{
								Dictionary<long, FormMetadataItemGroupDTO> dictionary3 = dictionary;
								parentId = current3.GroupId;
								if (!dictionary3.TryGetValue(parentId.Value, out value2))
								{
									num7 = 2;
									continue;
								}
								goto case 7;
							}
							case 12:
								break;
							default:
								if (!parentId.HasValue)
								{
									num7 = 7;
									continue;
								}
								goto case 11;
							case 2:
								value2 = null;
								num7 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num7 = 3;
								}
								continue;
							case 5:
								goto IL_02ad;
							case 4:
							case 6:
							{
								value2.Headers.Add(current3);
								int num8 = 5;
								num7 = num8;
								continue;
							}
							case 3:
								parentId = current3.GroupId;
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
								{
									num7 = 0;
								}
								continue;
							case 8:
								value2 = null;
								num7 = 3;
								continue;
							case 1:
								return formMetadataItemGroupDTO;
							}
							break;
						}
						goto IL_0267;
					}
				}
				finally
				{
					int num9;
					if (enumerator2 == null)
					{
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num9 = 0;
						}
						goto IL_0358;
					}
					goto IL_036e;
					IL_036e:
					Ticvv19OybpNsCu8dMg(enumerator2);
					num9 = 2;
					goto IL_0358;
					IL_0358:
					switch (num9)
					{
					default:
						goto end_IL_0333;
					case 1:
						break;
					case 0:
						goto end_IL_0333;
					case 2:
						goto end_IL_0333;
					}
					goto IL_036e;
					end_IL_0333:;
				}
			case 10:
				try
				{
					while (true)
					{
						IL_051f:
						int num5;
						if (!zupr4Y9nIql4F9C1wvo(enumerator))
						{
							num5 = 11;
							goto IL_03c1;
						}
						goto IL_04fc;
						IL_03c1:
						while (true)
						{
							switch (num5)
							{
							case 4:
								if (!parentId.HasValue)
								{
									num5 = 8;
									continue;
								}
								goto case 9;
							case 1:
								value = null;
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num5 = 0;
								}
								continue;
							default:
								parentId = current2.ParentId;
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
								{
									num5 = 4;
								}
								continue;
							case 6:
								value = formMetadataItemGroupDTO;
								num5 = 5;
								continue;
							case 5:
								value.Groups.Add(current2);
								num5 = 7;
								continue;
							case 10:
								value = null;
								num5 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num5 = 3;
								}
								continue;
							case 3:
							case 8:
								if (value == null)
								{
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
									{
										num5 = 6;
									}
									continue;
								}
								goto case 5;
							case 9:
							{
								Dictionary<long, FormMetadataItemGroupDTO> dictionary2 = dictionary;
								parentId = current2.ParentId;
								if (!dictionary2.TryGetValue(parentId.Value, out value))
								{
									num5 = 10;
									continue;
								}
								goto case 3;
							}
							case 2:
								break;
							case 7:
								goto IL_051f;
							case 11:
								goto end_IL_051f;
							}
							break;
						}
						goto IL_04fc;
						IL_04fc:
						current2 = enumerator.Current;
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num5 = 1;
						}
						goto IL_03c1;
						continue;
						end_IL_051f:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 2;
						goto IL_054f;
					}
					goto IL_0584;
					IL_054f:
					switch (num6)
					{
					default:
						goto end_IL_053a;
					case 2:
						goto end_IL_053a;
					case 1:
						break;
					case 0:
						goto end_IL_053a;
					}
					goto IL_0584;
					IL_0584:
					Ticvv19OybpNsCu8dMg(enumerator);
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num6 = 0;
					}
					goto IL_054f;
					end_IL_053a:;
				}
				goto case 4;
			case 9:
				enumerator = enumerable.GetEnumerator();
				num2 = 10;
				break;
			case 6:
				enumerable2 = FormMetadataItemHeaderManager.LoadHeaderDTOList(metadataType);
				num2 = 5;
				break;
			case 4:
				enumerator2 = enumerable2.GetEnumerator();
				num2 = 8;
				break;
			case 3:
				return formMetadataItemGroupDTO;
			default:
			{
				FormMetadataItemGroupManager formMetadataItemGroupManager = FormMetadataItemGroupManager;
				parentId = null;
				enumerable = formMetadataItemGroupManager.LoadGroupDTOList(metadataType, parentId);
				num2 = 6;
				break;
			}
			case 5:
				dictionary = new Dictionary<long, FormMetadataItemGroupDTO>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<FormMetadataItemGroupDTO> GetChildGroups(Guid metadataType, long? parentGroupId)
	{
		return FormMetadataItemGroupManager.LoadGroupDTOList(metadataType, parentGroupId);
	}

	public virtual IEnumerable<FormMetadataItemGroupDTO> GetNestedChildGroups(Guid metadataType, long? parentGroupId)
	{
		IEnumerable<FormMetadataItemGroupDTO> allGroups = FormMetadataItemGroupManager.LoadGroupDTOList(metadataType, null);
		List<FormMetadataItemGroupDTO> result = new List<FormMetadataItemGroupDTO>();
		GetChilds(parentGroupId, allGroups, result);
		return result;
	}

	public virtual FormMetadataItemGroupDTO Save(FormMetadataItemGroupDTO group)
	{
		//Discarded unreachable code: IL_004a, IL_0059
		int num = 3;
		int num2 = num;
		IFormMetadataItemGroup formMetadataItemGroup = default(IFormMetadataItemGroup);
		while (true)
		{
			switch (num2)
			{
			case 2:
				a4Xq5o92rPAligtoRax(formMetadataItemGroup);
				num2 = 4;
				continue;
			case 1:
			case 5:
				return Mapper.Map<IFormMetadataItemGroup, FormMetadataItemGroupDTO>(formMetadataItemGroup, group);
			case 3:
				formMetadataItemGroup = Mapper.Map<FormMetadataItemGroupDTO, IFormMetadataItemGroup>(group);
				num2 = 2;
				continue;
			case 4:
				if (formMetadataItemGroup.Parent == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			hQXHCw9PfvmN7WX28ab(Tl84Sy9e9Obvw9GQMUg(formMetadataItemGroup));
			num2 = 5;
		}
	}

	public virtual void Delete(long groupId)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				HecnYs917UHvwO50Hia(SecurityService, new Action(_003C_003Ec__DisplayClass16_._003CDelete_003Eb__0));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass16_.groupId = groupId;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			default:
				_003C_003Ec__DisplayClass16_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void GetChilds(long? parentGroupId, IEnumerable<FormMetadataItemGroupDTO> allGroups, List<FormMetadataItemGroupDTO> result)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		CS_0024_003C_003E8__locals0.parentGroupId = parentGroupId;
		foreach (FormMetadataItemGroupDTO item in allGroups.Where(delegate(FormMetadataItemGroupDTO g)
		{
			int num = 2;
			int num2 = num;
			long? parentGroupId2 = default(long?);
			long? parentId = default(long?);
			while (true)
			{
				switch (num2)
				{
				case 2:
					parentGroupId2 = CS_0024_003C_003E8__locals0.parentGroupId;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					parentId = g.ParentId;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return parentGroupId2 == parentId;
				}
			}
		}))
		{
			if (!result.Contains(item))
			{
				result.Add(item);
				GetChilds(item.Id, allGroups, result);
			}
		}
	}

	public FormMetadataItemGroupDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool HbSauD9X0fgoJmxv75g()
	{
		return Bt06qQ9KfrF3DkwRtRT == null;
	}

	internal static FormMetadataItemGroupDTOManager XE5cIq9T7nnXFOtCrch()
	{
		return Bt06qQ9KfrF3DkwRtRT;
	}

	internal static void s1AneE9kLWDVlq5Cl94(object P_0, Guid value)
	{
		((FormMetadataItemGroupDTO)P_0).MetadataType = value;
	}

	internal static bool zupr4Y9nIql4F9C1wvo(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Ticvv19OybpNsCu8dMg(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void a4Xq5o92rPAligtoRax(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object Tl84Sy9e9Obvw9GQMUg(object P_0)
	{
		return ((IFormMetadataItemGroup)P_0).Parent;
	}

	internal static void hQXHCw9PfvmN7WX28ab(object P_0)
	{
		((IEntity)P_0).Refresh();
	}

	internal static void HecnYs917UHvwO50Hia(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}
}
