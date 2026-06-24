using System.IO;
using Aspose.Email;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging.Email.Properties;

namespace EleWise.ELMA.Messaging.Email.Extensions;

[Component]
internal class LicenseActivationComponent : IInitHandler
{
	public void Init()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		using MemoryStream memoryStream = new MemoryStream(Resources.Aspose_Total);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		new License().SetLicense((Stream)memoryStream);
	}

	public void InitComplete()
	{
	}
}
