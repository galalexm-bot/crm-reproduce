using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.IntegrationModules.Models;

[FilterFor(typeof(IIntegrationModuleHeader))]
public interface IIntegrationModuleHeaderFilter : IEntityFilter
{
	[Uid("4c526ace-329f-4912-93a6-b592501fc846")]
	Guid? IntegrationModuleTyeUid { get; set; }

	[Uid("46e677b6-8104-4206-8355-a37717d6adcb")]
	bool? IsDeleted { get; set; }

	[Uid("c9a53d2e-dab3-4953-8be1-375c4f70a910")]
	DateTimeRange CreationDate { get; set; }

	[Uid("924d79a8-2b01-4b4f-adee-60efe9f3c869")]
	IUser CreationAuthor { get; set; }

	[Uid("5c86f376-58b1-4aac-b7e3-eb93819596fa")]
	DateTimeRange ChangeDate { get; set; }

	[Uid("ed6ce08e-bb59-4a6c-bf12-a0e77fd206d8")]
	IUser ChangeAuthor { get; set; }

	[Uid("bd50cfda-215e-41d1-94ba-0c574eb64905")]
	bool? IsPublished { get; set; }
}
