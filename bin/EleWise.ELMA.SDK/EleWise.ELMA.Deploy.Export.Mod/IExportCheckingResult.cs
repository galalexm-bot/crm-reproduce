using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Export.Enums;

namespace EleWise.ELMA.Deploy.Export.Models;

public interface IExportCheckingResult
{
	IReadOnlyCollection<ExportCheckingMessage> Messages { get; }

	void AddMessage(ExportCheckingMessageType type, string text);

	void AddMessage(ExportCheckingMessageType type, string text, Guid uid);

	void AddMessage(ExportCheckingMessage message);

	void AddMessages(IEnumerable<ExportCheckingMessage> messages);
}
