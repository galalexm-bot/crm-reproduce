using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;

namespace EleWise.ELMA.Api.Services;

[InternalWebService("GridService", "")]
internal interface IGridService
{
	[GlobalFunction("b0a0bc49-08ed-457b-8a5a-19a46c7998d7")]
	System.Threading.Tasks.Task<GridSettings> LoadSettings(GridSettingsRequest gridSettings);

	[GlobalFunction("d64f8baa-caa6-4163-b007-8319bef8ec8b")]
	System.Threading.Tasks.Task SaveSettings(GridSettings gridSettings);
}
