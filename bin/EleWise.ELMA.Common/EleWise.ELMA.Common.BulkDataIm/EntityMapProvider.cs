using System;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component(Order = 100000)]
internal class EntityMapProvider : ObjectMapProviderBase
{
	protected override string DefaultPropertyKey => "Uid";

	public override bool Can(Type objectType)
	{
		return objectType.GetInterfacesCache().Contains(typeof(IEntity));
	}
}
