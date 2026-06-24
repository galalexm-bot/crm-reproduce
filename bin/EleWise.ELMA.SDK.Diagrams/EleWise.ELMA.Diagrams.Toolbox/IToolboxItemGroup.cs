using System;

namespace EleWise.ELMA.Diagrams.Toolbox;

public interface IToolboxItemGroup
{
	Guid GroupUid { get; }

	Guid ParentGroupUid { get; }

	string Name { get; }
}
