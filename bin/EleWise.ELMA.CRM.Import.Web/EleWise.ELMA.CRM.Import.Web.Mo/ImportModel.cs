using System;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.CRM.Import.Web.Models;

public class ImportModel
{
	public ImportResultModel ImportResultModel { get; set; }

	public BinaryFile ImportFile { get; set; }

	public string ImportFileName { get; set; }

	public Guid EntityTypeUid { get; set; }

	public ImportOptions Options { get; set; }

	public ImportModel()
	{
		Options = new ImportOptions
		{
			KeyFieldName = "Name"
		};
	}
}
