using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.DTO;

[ServiceContract]
public interface IExtendEntityService
{
	IPropertyMetadata[] GetPropertiesToExtend(Entity entity);

	System.Threading.Tasks.Task AnalyzeEntityCompleteness(Entity entityHeader, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties);
}
