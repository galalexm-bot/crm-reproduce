using System;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

public interface IElementWithFormConstructorView : IElementWithView
{
	Guid FormUid { get; set; }
}
