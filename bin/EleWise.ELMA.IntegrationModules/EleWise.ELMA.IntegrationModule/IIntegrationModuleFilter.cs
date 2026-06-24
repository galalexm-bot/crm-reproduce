using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.IntegrationModules.Models;

[FilterFor(typeof(IIntegrationModule))]
public interface IIntegrationModuleFilter : IEntityFilter
{
	[Uid("ffe37ff7-11c2-4035-874a-c7f479e45fc8")]
	IIntegrationModuleActivity Activity { get; set; }

	[Uid("676faa8a-3055-42c9-84cd-20c4a5a66013")]
	string Name { get; set; }

	[Uid("f349b6c2-ac6a-4fb8-9e41-f2da021b00fa")]
	DateTimeRange CreationDate { get; set; }

	[Uid("7029830a-935c-409c-a70a-ef5dc7247ffc")]
	IUser CreationAuthor { get; set; }

	[Uid("8aa99789-d867-436d-a9af-77d15d000483")]
	DateTimeRange ChangeDate { get; set; }

	[Uid("9feb5806-ceab-489d-a9b4-7ca3a66a392d")]
	IUser ChangeAuthor { get; set; }

	[Uid("e9d29532-df81-4dba-9f27-c68b0cfd826f")]
	bool? IsTemplate { get; set; }

	[Uid("d67f8362-27b6-4a86-b4bd-05058f1238f4")]
	IIntegrationModule Template { get; set; }
}
