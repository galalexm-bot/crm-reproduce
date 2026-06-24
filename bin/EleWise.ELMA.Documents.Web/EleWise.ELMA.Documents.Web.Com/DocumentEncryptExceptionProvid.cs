using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Web.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 100)]
public class DocumentEncryptExceptionProvider : IEncryptException
{
	private static readonly Type[] exceptionTypes = new Type[2]
	{
		typeof(EncryptDocumentException),
		typeof(EncryptDocumentVersionException)
	};

	public IEnumerable<Type> GetExceptions()
	{
		return exceptionTypes;
	}

	public ActionResult OnException(Exception exception, ControllerBase controller)
	{
		if (exception is EncryptDocumentException encryptDocumentException)
		{
			return EncryptDocumentActionResultImpl.EncryptedDocumentResult(encryptDocumentException, controller);
		}
		return EncryptDocumentVersionActionResultImpl.EncryptedDocumentVersionResult((EncryptDocumentVersionException)exception, controller);
	}

	public void RenderExceptionPartial(HtmlHelper html, Exception exception)
	{
		if (exception is EncryptDocumentException encryptDocumentException)
		{
			EncryptDocumentActionResultImpl.RenderEncryptionLogOnFormSimple(html, encryptDocumentException);
		}
		else
		{
			EncryptDocumentVersionActionResultImpl.RenderEncryptionLogOnFormSimple(html, (EncryptDocumentVersionException)exception);
		}
	}
}
