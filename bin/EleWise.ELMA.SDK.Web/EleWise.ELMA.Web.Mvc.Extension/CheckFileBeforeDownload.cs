using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Web.Mvc.Extensions;

[Component(Order = int.MinValue)]
internal class CheckFileBeforeDownload : IPrepareFileToDownload
{
	public bool Check(BinaryFile file)
	{
		return true;
	}

	public BinaryFile Prepare(BinaryFile file)
	{
		file.CheckLoaded(loadFile: true);
		return file;
	}
}
