using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ILastObjectProvider
{
	Guid TypeUid { get; }

	string DisplayName { get; }

	void AddInfo(IEntity<long> entity);

	bool CanAdd(IEntity<long> entity);

	void RemoveInfo(IEntity<long> entity);
}
