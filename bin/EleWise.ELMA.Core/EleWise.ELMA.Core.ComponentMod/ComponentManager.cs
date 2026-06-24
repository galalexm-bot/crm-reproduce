using System;
using System.Reflection;
using Bridge;
using EleWise.ELMA.ComponentModel.Registration;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Ioc.Resolvers;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.Core.ComponentModel;

public class ComponentManager : IComponentManager
{
	private readonly IContainer container;

	private readonly ILogger logger;

	private readonly TypedMap<System.Type, System.Type[]> registeredTypes = new TypedMap<System.Type, System.Type[]>();

	private readonly TypedMap<System.Type, RegistrationData> registrationDataResult = new TypedMap<System.Type, RegistrationData>();

	private readonly TypedMap<RegistrationData, System.Type> registrationTypeResult = new TypedMap<RegistrationData, System.Type>();

	public ComponentManager(IContainer container, ILogger logger)
	{
		this.container = container;
		this.logger = logger;
	}

	public void Init(Assembly[] assemblies)
	{
		Contract.ArgumentNotNull(assemblies, "assemblies");
		InitApplication(assemblies);
	}

	public System.Type[] GetTypes(System.Type type)
	{
		return registeredTypes.Get(type) ?? new System.Type[0];
	}

	private void InitApplication(Assembly[] assemblies)
	{
		System.Type[] array = new System.Type[0];
		foreach (Assembly val in assemblies)
		{
			RegistrationData[] array2 = ObjectExtensions.As<RegistrationData[]>(((object)val).get_Item("$$typesToRegister"));
			if (array2 == null)
			{
				continue;
			}
			System.Type[] types = val.GetTypes();
			array = Script.Write<System.Type[]>("allTypes.concat(types)", new object[0]);
			foreach (System.Type type in types)
			{
				RegistrationData registrationData = FindRegistrationData(array2, type);
				if (registrationData == null)
				{
					continue;
				}
				switch (registrationData.RegistrationType)
				{
				case RegistrationType.Register:
					Register(type, registrationData.Constructor.Arguments);
					break;
				case RegistrationType.RegisterSingleInstance:
					RegisterSingleInstance(type, registrationData.Constructor.Arguments);
					break;
				case RegistrationType.RegisterInstance:
				{
					object instance = Activator.CreateInstance(type);
					RegisterInstance(type, instance);
					break;
				}
				case RegistrationType.RegisterAsEnumerableResolver:
					RegisterAsEnumerableResolver(type, null);
					break;
				case RegistrationType.RegisterAsServiceContractResolver:
					RegisterAsServiceContractResolver(type);
					break;
				}
				RegistrationData[] registerAs = registrationData.RegisterAs;
				foreach (RegistrationData registrationData2 in registerAs)
				{
					System.Type type2 = FindType(registrationData2, array);
					if (type2 == null)
					{
						ILogger obj = logger;
						string message = SR.T("Не найден тип для регистрации");
						object[] objects = new RegistrationData[1] { registrationData2 };
						obj.Error(message, objects);
						continue;
					}
					switch (registrationData2.RegistrationType)
					{
					case RegistrationType.Register:
						Register(type2, type, registrationData.Constructor.Arguments);
						break;
					case RegistrationType.RegisterSingleInstance:
						RegisterSingleInstance(type2, type, registrationData.Constructor.Arguments);
						break;
					case RegistrationType.RegisterInstance:
					{
						object instance2 = Activator.CreateInstance(type2);
						RegisterInstance(type2, instance2);
						break;
					}
					case RegistrationType.RegisterAsEnumerableResolver:
						RegisterAsEnumerableResolver(type2, type, registrationData2.Order);
						RegisterTypes(type2, type, registrationData2.Order);
						break;
					case RegistrationType.RegisterAsServiceContractResolver:
						RegisterAsServiceContractResolver(type2);
						break;
					}
					if (registrationData.RegistrationType == RegistrationType.RegisterTypes)
					{
						RegisterTypes(type2, type, registrationData2.Order);
					}
				}
			}
		}
		registrationDataResult.Clear();
		registrationTypeResult.Clear();
	}

	private void Register(System.Type type, string[] arguments)
	{
		((IScopeContext)container).get_Registry().Register(type, arguments);
	}

	private void Register(System.Type type, System.Type impl, string[] arguments)
	{
		((IScopeContext)container).get_Registry().Register(type, impl, arguments);
	}

	private void RegisterInstance(System.Type type, object instance)
	{
		((IScopeContext)container).get_Registry().RegisterInstance(type, instance);
	}

	private void RegisterSingleInstance(System.Type type, string[] arguments)
	{
		((IScopeContext)container).get_Registry().RegisterSingleInstance(type, arguments);
	}

	private void RegisterSingleInstance(System.Type type, System.Type impl, string[] arguments)
	{
		((IScopeContext)container).get_Registry().RegisterSingleInstance(type, impl, arguments);
	}

	private void RegisterAsEnumerableResolver(System.Type extType, System.Type impl, int order = 0)
	{
		((IScopeContext)container).get_Registry().RegisterAsEnumerableResolver(extType, impl, order);
	}

	private void RegisterAsServiceContractResolver(System.Type type)
	{
		((IScopeContext)container).get_Registry().Register(type, (IResolver)(object)new ServiceContractResolver(type));
	}

	private void RegisterTypes(System.Type resolveType, System.Type registerType, int order = 0)
	{
		if (registeredTypes.Has(resolveType))
		{
			ArrayExtensions.Push<System.Type>(registeredTypes.Get(resolveType), new System.Type[1] { registerType });
		}
		else
		{
			registeredTypes.Set(resolveType, new System.Type[1] { registerType });
		}
	}

	private RegistrationData FindRegistrationData(RegistrationData[] typesToRegister, System.Type type)
	{
		RegistrationData registrationData = registrationDataResult.Get(type);
		if (registrationData != null)
		{
			return registrationData;
		}
		ObjectExtensions.As<string>(((object)type).get_Item("$$name"));
		registrationData = Script.Write<RegistrationData>(" {0}.find(function (value, index, arr) {\r\n                         return value.TypeName === typeName;\r\n                    });", (object[])typesToRegister);
		registrationDataResult.Set(type, registrationData);
		return registrationData;
	}

	private System.Type FindType(RegistrationData typeToRegister, System.Type[] types)
	{
		System.Type type = registrationTypeResult.Get(typeToRegister);
		if (type != null)
		{
			return type;
		}
		_ = typeToRegister.TypeName;
		type = Script.Write<System.Type>(" {0}.find(function (value, index, arr) {\r\n                         return value.$$name === typeName;\r\n                    });", (object[])types);
		registrationTypeResult.Set(typeToRegister, type);
		return type;
	}
}
