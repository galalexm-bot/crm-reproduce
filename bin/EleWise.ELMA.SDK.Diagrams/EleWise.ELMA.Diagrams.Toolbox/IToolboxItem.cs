using System;
using System.Drawing;

namespace EleWise.ELMA.Diagrams.Toolbox;

public interface IToolboxItem
{
	string Name { get; }

	Guid GroupUid { get; }

	Image Image { get; }

	Type ElementType { get; }
}
