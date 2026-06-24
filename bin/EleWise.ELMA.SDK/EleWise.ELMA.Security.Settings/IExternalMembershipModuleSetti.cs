using System;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Security.Settings;

public interface IExternalMembershipModuleSettings : IStoreValuesObject
{
	Guid ModuleUid { get; }

	Guid InstanceUid { get; set; }

	string Name { get; }

	bool Deletable { get; set; }
}
