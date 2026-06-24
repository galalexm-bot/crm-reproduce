using System;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Extensions;

public static class NHRegisterExtensions
{
	public static IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> RegisterNHManager(this ContainerBuilder builder, Type managerType)
	{
		IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> val = RegistrationExtensions.PropertiesAutowired<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(RegistrationExtensions.RegisterType(builder, managerType), (PropertyWiringOptions)1);
		ComponentManager.Current.SetupInterceptors(managerType, val);
		return val;
	}
}
