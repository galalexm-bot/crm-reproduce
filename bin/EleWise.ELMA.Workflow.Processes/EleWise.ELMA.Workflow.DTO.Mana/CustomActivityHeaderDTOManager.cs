using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class CustomActivityHeaderDTOManager : DTOManager, ICustomActivityHeaderDTOManager, IConfigurationService
{
	internal static CustomActivityHeaderDTOManager NNn1DUPE1nrKQ6l8jWD;

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
				case 1:
					_003CCustomActivityHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
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

	public ICustomActivityDTOManager caDTOManager => Locator.GetServiceNotNull<ICustomActivityDTOManager>();

	public virtual CustomActivityHeaderDTO LoadOrNull(long id)
	{
		return Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(CustomActivityHeaderManager.LoadOrNull(id), new CustomActivityHeaderDTO());
	}

	public virtual CustomActivityHeaderDTO LoadOrNull(Guid uid)
	{
		return Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(CustomActivityHeaderManager.LoadOrNull(uid), new CustomActivityHeaderDTO());
	}

	public virtual CustomActivityHeaderDTO Save(CustomActivityHeaderDTO header)
	{
		int num = 2;
		int num2 = num;
		ICustomActivityHeader customActivityHeader = default(ICustomActivityHeader);
		while (true)
		{
			switch (num2)
			{
			case 2:
				customActivityHeader = Mapper.Map<CustomActivityHeaderDTO, ICustomActivityHeader>(header);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				CustomActivityHeaderManager.Save(customActivityHeader);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(customActivityHeader, new CustomActivityHeaderDTO());
			}
		}
	}

	public virtual IEnumerable<CustomActivityHeaderDTO> LoadPublishedCustomActivityHeaders()
	{
		return LoadPublishedCustomActivityHeaders(deletedIncluded: true);
	}

	public virtual IEnumerable<CustomActivityHeaderDTO> LoadPublishedCustomActivityHeaders(bool deletedIncluded)
	{
		ParameterExpression parameterExpression;
		if (!deletedIncluded)
		{
			CustomActivityHeaderManager customActivityHeaderManager = CustomActivityHeaderManager;
			parameterExpression = Expression.Parameter(typeof(ICustomActivityHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-182059571 ^ -182082005));
			return (from h in customActivityHeaderManager.Find(Expression.Lambda<Func<ICustomActivityHeader, bool>>(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Convert(Expression.Constant(true, typeof(bool)), typeof(bool?)))), new ParameterExpression[1] { parameterExpression }))
				select Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(h, new CustomActivityHeaderDTO())).ToList();
		}
		CustomActivityHeaderManager customActivityHeaderManager2 = CustomActivityHeaderManager;
		parameterExpression = Expression.Parameter(typeof(ICustomActivityHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-658644315 ^ -658654909));
		return (from h in customActivityHeaderManager2.Find(Expression.Lambda<Func<ICustomActivityHeader, bool>>(Expression.NotEqual(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(h, new CustomActivityHeaderDTO())).ToList();
	}

	public virtual IEnumerable<CustomActivityHeaderDTO> LoadCustomActivityHeadersByName(string headerName)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.headerName = headerName;
		CustomActivityHeaderManager customActivityHeaderManager = CustomActivityHeaderManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ICustomActivityHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-444713948 ^ -444698686));
		return (from h in customActivityHeaderManager.Find(Expression.Lambda<Func<ICustomActivityHeader, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass11_, typeof(_003C_003Ec__DisplayClass11_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(h, new CustomActivityHeaderDTO())).ToList();
	}

	public virtual void Delete(CustomActivityHeaderDTO header)
	{
		int num = 1;
		int num2 = num;
		ICustomActivityHeader customActivityHeader = default(ICustomActivityHeader);
		while (true)
		{
			switch (num2)
			{
			case 3:
				customActivityHeader = CustomActivityHeaderManager.Load(header.Id);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Mapper.Map<CustomActivityHeaderDTO, ICustomActivityHeader>(header, customActivityHeader);
				num2 = 4;
				break;
			case 4:
				CustomActivityHeaderManager.Save(customActivityHeader);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
				{
					num2 = 5;
				}
				break;
			default:
				RKKXZZP3nibTDjxjfAF(header, 0L);
				num2 = 3;
				break;
			case 5:
				return;
			case 1:
				oa6kZjPoMKvBrTRpPWa(header, true);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual CustomActivityCommonStatistics GetCommonStatistics()
	{
		return (CustomActivityCommonStatistics)UnJdxMPhakKC2E9DBmV(CustomActivityHeaderManager);
	}

	public virtual bool CheckCustomActivityName(long id, string name, out string errorMessage)
	{
		return CustomActivityHeaderManager.CheckCustomActivityName(id, name, out errorMessage);
	}

	public virtual bool CheckCustomActivityClassName(long id, string name, out string errorMessage)
	{
		return CustomActivityHeaderManager.CheckCustomActivityClassName(id, name, out errorMessage);
	}

	public virtual bool CheckCustomActivityTableName(long id, string name, out string errorMessage)
	{
		return CustomActivityHeaderManager.CheckCustomActivityTableName(id, name, out errorMessage);
	}

	public virtual List<CustomActivityHeaderDTO> FindDeleted()
	{
		return (from h in CustomActivityHeaderManager.FindDeleted()
			select Mapper.Map<ICustomActivityHeader, CustomActivityHeaderDTO>(h, new CustomActivityHeaderDTO())).ToList();
	}

	public virtual CustomActivityPublishingException[] Publish(CustomActivityHeaderDTO[] headers)
	{
		//Discarded unreachable code: IL_00a2, IL_00d5, IL_0113, IL_0122, IL_018f, IL_019e
		int num = 9;
		int num2 = num;
		int num3 = default(int);
		CustomActivityHeaderDTO[] array = default(CustomActivityHeaderDTO[]);
		CustomActivityHeaderDTO customActivityHeaderDTO = default(CustomActivityHeaderDTO);
		List<CustomActivityPublishingException> list = default(List<CustomActivityPublishingException>);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				if (num3 >= array.Length)
				{
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 3;
			case 6:
				try
				{
					caDTOManager.Publish(caDTOManager.Load(LBEryXPxgoP1Y9sD6oq(customActivityHeaderDTO)));
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (CustomActivityPublishingException item)
				{
					int num5 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							list.Add(item);
							num5 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
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
				goto case 1;
			case 8:
				if (headers == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 != 0)
					{
						num2 = 0;
					}
					break;
				}
				array = headers;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				return (CustomActivityPublishingException[])kyTlJoPF6qu5CRMQyk0(list);
			case 3:
				customActivityHeaderDTO = array[num3];
				num2 = 6;
				break;
			case 9:
				list = new List<CustomActivityPublishingException>();
				num2 = 8;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				return list.ToArray();
			}
		}
	}

	public CustomActivityHeaderDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GudcrSP88S712XrwomF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool C31ANhPCDvAP4qKIM2Z()
	{
		return NNn1DUPE1nrKQ6l8jWD == null;
	}

	internal static CustomActivityHeaderDTOManager dwTJrYPXhupJ9wRUr9l()
	{
		return NNn1DUPE1nrKQ6l8jWD;
	}

	internal static void oa6kZjPoMKvBrTRpPWa(object P_0, bool value)
	{
		((CustomActivityHeaderDTO)P_0).Deleted = value;
	}

	internal static void RKKXZZP3nibTDjxjfAF(object P_0, long value)
	{
		((CustomActivityHeaderDTO)P_0).FolderId = value;
	}

	internal static object UnJdxMPhakKC2E9DBmV(object P_0)
	{
		return ((CustomActivityHeaderManager)P_0).GetCommonStatistics();
	}

	internal static long LBEryXPxgoP1Y9sD6oq(object P_0)
	{
		return ((CustomActivityHeaderDTO)P_0).DraftId;
	}

	internal static object kyTlJoPF6qu5CRMQyk0(object P_0)
	{
		return ((List<CustomActivityPublishingException>)P_0).ToArray();
	}

	internal static void GudcrSP88S712XrwomF()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
