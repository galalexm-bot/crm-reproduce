using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IEntityUserTypeSelector
{
	Type EntityType { get; }

	string Prefix { get; }

	string DisplayName { get; }

	IEntity<long> GetEntity(string value);

	List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value);

	string PrefixedValue(IEntity<long> entity);
}
