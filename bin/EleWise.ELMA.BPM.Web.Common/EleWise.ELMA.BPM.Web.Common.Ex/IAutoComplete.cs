using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAutoComplete
{
	IEnumerable<EQLOperator> GetOperators();

	IEnumerable<EQLFunction> GetFunctions(EntityMetadata entityMetadata);

	IEnumerable<EQLField> GetFields(EntityMetadata entityMetadata);

	IEnumerable<EQLSuggestion> GetEntities(Guid Uid, string entityValue);

	IEnumerable<EQLEntity> GetAllEntities();
}
