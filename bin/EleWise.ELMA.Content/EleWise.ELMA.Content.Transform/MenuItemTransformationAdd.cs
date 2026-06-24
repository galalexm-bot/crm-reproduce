using System;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Transformations.Struct;

namespace EleWise.ELMA.Content.Transformation;

[Serializable]
public class MenuItemTransformationAdd : TransformationAdd<IMenuItem, MenuItemTransformation, Guid>
{
}
