using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface IUserDefinedListService
{
	ClassMetadata GetMetadata(ComponentMetadata componentMetadata, UserDefinedListInfo userDefinedListInfo);
}
