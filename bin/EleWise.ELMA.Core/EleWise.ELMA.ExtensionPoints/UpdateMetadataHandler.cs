using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

public abstract class UpdateMetadataHandler<T> : IUpdateMetadataHandler<T>, IUpdateMetadataHandler where T : IMetadata
{
	public virtual bool Check(IMetadata metadata)
	{
		return metadata is T;
	}

	public abstract System.Threading.Tasks.Task<IUpdateModel> SaveAndUpdate(IUpdateModel updateModel);

	public abstract System.Threading.Tasks.Task<IUpdateModel> SaveAndPublish(IUpdateModel metadata);
}
