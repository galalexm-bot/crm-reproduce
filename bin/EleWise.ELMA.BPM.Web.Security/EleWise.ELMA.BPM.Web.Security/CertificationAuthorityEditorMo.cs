using EleWise.ELMA.Security.Components;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class CertificationAuthorityEditorModel
{
	public int? Index { get; set; }

	public string CallbackFunctionName { get; set; }

	public CertificationAuthorityInfo Info { get; set; }
}
