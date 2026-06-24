using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy.Actors;

internal interface IImportStartActor : IActorWithGuidKey, IActor
{
	Task<Guid> Import(IImportSettings settings);

	Task<Guid> GetCurrentImportId();

	Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings);

	Task ContinueImport();
}
