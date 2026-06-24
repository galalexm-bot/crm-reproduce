using System;
using Bridge;

namespace EleWise.ELMA.Model.Diagrammer;

[ObjectLiteral(/*Could not decode attribute arguments.*/)]
public sealed class DiagrammerModel : IDiagrammerModel, ICloneableObjectLiteral
{
	private string _003CId_003Ek__BackingField;

	private IDiagrammerElement[] _003CItems_003Ek__BackingField;

	public string Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	public IDiagrammerElement[] Items
	{
		get
		{
			return _003CItems_003Ek__BackingField;
		}
		set
		{
			_003CItems_003Ek__BackingField = value;
		}
	}

	public object Clone()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		DiagrammerModel diagrammerModel = new DiagrammerModel();
		Guid val = Guid.NewGuid();
		diagrammerModel.Id = ((object)(Guid)(ref val)).ToString();
		DiagrammerModel diagrammerModel2 = diagrammerModel;
		diagrammerModel2.Items = new IDiagrammerElement[Items.Length];
		for (int i = 0; i < Items.Length; i++)
		{
			diagrammerModel2.Items[i] = Items[i].Clone() as IDiagrammerElement;
		}
		return diagrammerModel2;
	}
}
