using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FileProvider.Distributed.Managers;
using EleWise.ELMA.Runtime.Managers;

namespace EleWise.ELMA.FileProvider.Distributed;

[Component(Type = ComponentType.Server)]
internal class NHMappingRegistrar : INHManagerRegistrar
{
	public void Register(NHManagerRegisterParams parameters)
	{
		parameters.Builder.RegisterNHManager(typeof(DistributedFileOriginManager)).As<DistributedFileOriginManager>().SingleInstance();
		parameters.Add<ContentOriginMap>();
	}
}
