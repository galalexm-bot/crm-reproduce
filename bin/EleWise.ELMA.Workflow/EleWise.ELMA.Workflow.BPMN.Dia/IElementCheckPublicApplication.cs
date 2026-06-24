using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

public interface IElementCheckPublicApplication
{
	bool CanCheckPublicApplicationCompatibility { get; }

	void CheckPublicApplicationCompatibility(EntityMetadata processContext, IEnumerable<IPropertyMetadata> properties, List<IPublicApplicationCompatibilityError> errors);
}
