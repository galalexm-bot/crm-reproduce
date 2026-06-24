using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IReplacementTaskRemapObjectsFilterExtension
{
	ICriterion CreatePropertyCriteria(ClassMetadata rootMetadata, PropertyMetadata property, IReplacementTask replacementTask);

	bool IsPropertyReadOnly(IEntity replacementObject, PropertyMetadata property, IEntity entity);

	IEnumerable<Pair<ClassMetadata, PropertyMetadata>> GetProjections(ClassMetadata rootMetadata, IReplacementTask replacementTask);

	bool ReplaceProperty(IEntity entity, PropertyMetadata property, IUser newUser);

	bool CanUseForReplacementTaskType(IReplacementTask replacementTask);
}
