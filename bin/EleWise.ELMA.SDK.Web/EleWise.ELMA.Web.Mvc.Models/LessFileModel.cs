using System;

namespace EleWise.ELMA.Web.Mvc.Models;

public class LessFileModel
{
	public string FileName { get; set; }

	public string Location { get; set; }

	public string Content { get; set; }

	public string Path { get; set; }

	public DateTime LastModifyDate { get; set; }
}
