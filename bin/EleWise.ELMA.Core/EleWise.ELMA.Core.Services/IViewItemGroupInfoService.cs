using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface IViewItemGroupInfoService
{
	System.Threading.Tasks.Task LoadViewItemInfoList(NamedMetadata[] metadataArray);

	System.Collections.Generic.ICollection<VisibleGroupInfo> GetGroups();

	string GetInfoDisplayName(string typeName);
}
