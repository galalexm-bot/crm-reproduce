using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Tasks.Models;

[InterfaceExtension(typeof(ICreateSubtaskActionModel))]
public interface ICreateSimpleSubtaskActionModel : ICreateSubtaskActionModel, IAutoImplement
{
}
