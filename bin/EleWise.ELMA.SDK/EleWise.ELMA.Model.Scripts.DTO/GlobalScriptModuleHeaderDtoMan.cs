using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager;

public class GlobalScriptModuleHeaderDtoManager : DTOManager, IGlobalScriptModuleHeaderDtoManager, IConfigurationService
{
	internal static GlobalScriptModuleHeaderDtoManager WQgFhIbXb0Ow90IYJbjp;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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

	public virtual GlobalScriptModuleHeaderDto LoadOrNull(long id)
	{
		return Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(GlobalScriptModuleHeaderManager.LoadOrNull(id), new GlobalScriptModuleHeaderDto());
	}

	public virtual GlobalScriptModuleHeaderDto LoadOrNull(Guid uid)
	{
		return Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(GlobalScriptModuleHeaderManager.LoadOrNull(uid), new GlobalScriptModuleHeaderDto());
	}

	public virtual GlobalScriptModuleHeaderDto Save(GlobalScriptModuleHeaderDto header)
	{
		int num = 1;
		int num2 = num;
		IGlobalScriptModuleHeader globalScriptModuleHeader = default(IGlobalScriptModuleHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				GlobalScriptModuleHeaderManager.Save(globalScriptModuleHeader);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(globalScriptModuleHeader, new GlobalScriptModuleHeaderDto());
			case 1:
				globalScriptModuleHeader = Mapper.Map<GlobalScriptModuleHeaderDto, IGlobalScriptModuleHeader>(header);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadGlobalScriptModulesByName(string headerName)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.headerName = headerName;
		GlobalScriptModuleHeaderManager globalScriptModuleHeaderManager = GlobalScriptModuleHeaderManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IGlobalScriptModuleHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDC4DB2));
		return (from h in globalScriptModuleHeaderManager.Find(Expression.Lambda<Func<IGlobalScriptModuleHeader, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass11_, typeof(_003C_003Ec__DisplayClass11_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto())).ToList();
	}

	public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders()
	{
		return LoadPublishedGlobalScriptModuleHeaders(deletedIncluded: true);
	}

	public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders(bool deletedIncluded)
	{
		ParameterExpression parameterExpression;
		if (!deletedIncluded)
		{
			GlobalScriptModuleHeaderManager globalScriptModuleHeaderManager = GlobalScriptModuleHeaderManager;
			parameterExpression = Expression.Parameter(typeof(IGlobalScriptModuleHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A776037));
			return (from h in globalScriptModuleHeaderManager.Find(Expression.Lambda<Func<IGlobalScriptModuleHeader, bool>>(Expression.AndAlso(Expression.NotEqual(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), Expression.NotEqual(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(true, typeof(bool)))), new ParameterExpression[1] { parameterExpression }))
				select Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto())).ToList();
		}
		GlobalScriptModuleHeaderManager globalScriptModuleHeaderManager2 = GlobalScriptModuleHeaderManager;
		parameterExpression = Expression.Parameter(typeof(IGlobalScriptModuleHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108623440));
		return (from h in globalScriptModuleHeaderManager2.Find(Expression.Lambda<Func<IGlobalScriptModuleHeader, bool>>(Expression.NotEqual(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(null, typeof(object))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto())).ToList();
	}

	public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadRuntimeLoadedHeaders()
	{
		return (from h in GlobalScriptModuleHeaderManager.LoadRuntimeLoadedHeaders()
			select Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto())).ToList();
	}

	public virtual void Delete(GlobalScriptModuleHeaderDto header)
	{
		int num = 3;
		int num2 = num;
		IGlobalScriptModuleHeader globalScriptModuleHeader = default(IGlobalScriptModuleHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				globalScriptModuleHeader = GlobalScriptModuleHeaderManager.Load(header.Id);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Mapper.Map<GlobalScriptModuleHeaderDto, IGlobalScriptModuleHeader>(header, globalScriptModuleHeader);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				hmqGb1bXEvFkJYvyRifE(header, true);
				num2 = 2;
				break;
			case 4:
				GlobalScriptModuleHeaderManager.Save(globalScriptModuleHeader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual byte[] GetAssemblyRaw(Guid headerUid)
	{
		return (byte[])KGwE6rbXff7GWT8shcI3(GlobalScriptModuleHeaderManager, headerUid);
	}

	public virtual bool CheckGlobalScriptModuleName(long id, string name, out string errorMessage)
	{
		return GlobalScriptModuleHeaderManager.CheckGlobalScriptModuleName(id, name, out errorMessage);
	}

	public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadAllGlobalScriptModuleHeaders()
	{
		IGlobalScriptModuleHeaderFilter globalScriptModuleHeaderFilter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
		globalScriptModuleHeaderFilter.Deleted = false;
		return (from h in GlobalScriptModuleHeaderManager.Find(globalScriptModuleHeaderFilter, null)
			select Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto())).ToList();
	}

	public virtual bool CheckGlobalScriptModuleClassName(long id, string name, out string errorMessage)
	{
		return GlobalScriptModuleHeaderManager.CheckGlobalScriptModuleClassName(id, name, out errorMessage);
	}

	public virtual bool CheckGlobalScriptModuleTableName(long id, string name, out string errorMessage)
	{
		return GlobalScriptModuleHeaderManager.CheckGlobalScriptModuleTableName(id, name, out errorMessage);
	}

	public GlobalScriptModuleHeaderDtoManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ltGCVHbXh0MrvcNOniD9()
	{
		return WQgFhIbXb0Ow90IYJbjp == null;
	}

	internal static GlobalScriptModuleHeaderDtoManager JLPsX6bXGGgpkXYenRmf()
	{
		return WQgFhIbXb0Ow90IYJbjp;
	}

	internal static void hmqGb1bXEvFkJYvyRifE(object P_0, bool value)
	{
		((GlobalScriptModuleHeaderDto)P_0).Deleted = value;
	}

	internal static object KGwE6rbXff7GWT8shcI3(object P_0, Guid headerUid)
	{
		return ((GlobalScriptModuleHeaderManager)P_0).GetAssemblyRaw(headerUid);
	}
}
