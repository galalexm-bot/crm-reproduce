using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Common.Models.Deploy;

public sealed class TestModel
{
	[DisplayName("SR.M('Файл конфигурации')")]
	public BinaryFile ConfigFile { get; set; }

	public string ActivationKey { get; set; }
}
