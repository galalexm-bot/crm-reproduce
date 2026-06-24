using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint]
public interface IUpdateMetadataHandler
{
	bool Check(IMetadata metadata);

	System.Threading.Tasks.Task<IUpdateModel> SaveAndUpdate(IUpdateModel updateModel);

	System.Threading.Tasks.Task<IUpdateModel> SaveAndPublish(IUpdateModel updateModel);
}
[ExtensionPoint]
public interface IUpdateMetadataHandler<T> : IUpdateMetadataHandler where T : IMetadata
{
}
