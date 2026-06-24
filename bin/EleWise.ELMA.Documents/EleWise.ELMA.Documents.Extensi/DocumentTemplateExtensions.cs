using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Documents.Extensions;

public static class DocumentTemplateExtensions
{
	public static string GetName(this IDocumentTemplate template)
	{
		try
		{
			if (template.TemplateType == DocumentTemplateType.File)
			{
				return (template.File != null) ? template.File.Name : string.Empty;
			}
			return (template.Document != null) ? template.Document.Name : string.Empty;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return string.Empty;
		}
	}
}
