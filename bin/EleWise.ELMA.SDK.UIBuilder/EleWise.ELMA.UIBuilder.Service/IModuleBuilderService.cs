using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.Model;

namespace EleWise.ELMA.UIBuilder.Services;

internal interface IModuleBuilderService
{
	ModuleBuildResult Build(Guid itemUid, ModuleInfoMetadata module, string version, bool withoutJsOutput = false);
}
