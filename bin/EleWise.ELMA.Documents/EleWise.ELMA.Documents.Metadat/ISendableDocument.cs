using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Metadata;

public interface ISendableDocument
{
	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendStatus_DisplayName")]
	SendStatus SendStatus { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendDate_DisplayName")]
	DateTime? SendDate { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendUser_DisplayName")]
	IUser SendUser { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendDocumentType_DisplayName")]
	ISendDocumentType SendDocumentType { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendNumber_DisplayName")]
	string SendNumber { get; set; }

	[DisplayName(typeof(__Resources_ISendableDocument), "P_SendScanCopy_DisplayName")]
	BinaryFile SendScanCopy { get; set; }
}
