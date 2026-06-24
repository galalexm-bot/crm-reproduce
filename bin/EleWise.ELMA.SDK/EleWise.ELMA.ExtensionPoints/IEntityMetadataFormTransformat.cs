using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEntityMetadataFormTransformation
{
	void GetTransformations(List<FormViewItemTransformation> formTransformations);
}
