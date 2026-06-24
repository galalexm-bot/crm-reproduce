using System;
using DevComponents.AdvTree;

namespace EleWise.ELMA.Diagrams.Toolbox;

public interface IToolboxNodeGroup
{
	Guid GroupUid { get; }

	Guid ParentGroupUid { get; }

	string Name { get; }

	NodeCollection Nodes { get; }
}
