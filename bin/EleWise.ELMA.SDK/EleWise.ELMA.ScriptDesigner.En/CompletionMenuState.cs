using System;

namespace EleWise.ELMA.ScriptDesigner.Enums;

[Serializable]
public enum CompletionMenuState
{
	None,
	Action,
	InnerProperties,
	DateTime,
	Double,
	Integer,
	Boolean
}
