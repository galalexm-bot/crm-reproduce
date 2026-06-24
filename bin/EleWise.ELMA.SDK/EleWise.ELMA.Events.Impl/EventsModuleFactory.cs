using Autofac;

namespace EleWise.ELMA.Events.Impl;

public static class EventsModuleFactory
{
	public static Module Create()
	{
		return (Module)(object)new EventsModule();
	}
}
