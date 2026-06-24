using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.vCard.Vcard;

namespace EleWise.ELMA.vCard.Web.Components;

public class VCardResult : ActionResult
{
	private readonly EleWise.ELMA.vCard.Vcard.Vcard card;

	private readonly string filename;

	protected VCardResult()
	{
	}

	public VCardResult(EleWise.ELMA.vCard.Vcard.Vcard vCard, string fileName)
	{
		card = vCard;
		filename = fileName;
	}

	public override void ExecuteResult(ControllerContext context)
	{
		HttpResponseBase response = context.get_HttpContext().Response;
		response.Charset = "UTF-8";
		response.ContentType = "application/x-vcard";
		response.AddHeader("Content-Description", "File Transfer");
		response.AddHeader("Content-Disposition", $"attachment; filename={filename}.vcf");
		string s = card.Serialize();
		Encoding @default = Encoding.Default;
		UTF8Encoding dstEncoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
		byte[] bytes = @default.GetBytes(s);
		byte[] array = Encoding.Convert(@default, dstEncoding, bytes);
		response.OutputStream.Write(array, 0, array.Length);
	}
}
