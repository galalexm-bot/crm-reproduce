using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.Api.Services.Internal;

[InternalWebService("Entity", "")]
public interface IEntityService
{
	[GlobalFunction("99a68189-1c92-4c1e-b042-fcbe5bb2d4e9")]
	System.Threading.Tasks.Task<EntitySaveResponse> Save(EntitySaveRequest request);

	[GlobalFunction("029bc4c3-b898-4ec1-af93-10d80df94afc")]
	System.Threading.Tasks.Task<System.Collections.Generic.ICollection<EntityMetadata>> GetChildMetadata(string typeUid);

	[GlobalFunction("ed8ecaff-622a-42a1-a95e-83513ba0bb6d")]
	System.Threading.Tasks.Task<CountWithContextEntityResponse> CountWithContextEntity(CountWithContextEntityRequest request);
}
