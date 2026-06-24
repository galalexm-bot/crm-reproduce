using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

public interface IBaseRangeContext : IBaseContext, IBaseInputs, IInputs, IContext
{
	IPropertyMetadata PropertyFrom { get; set; }

	IPropertyMetadata PropertyTo { get; set; }
}
