namespace EleWise.ELMA.WebCompiler;

public class FileCompileResult
{
	public CompilingFileInfo FileInfo { get; private set; }

	internal CompiledFileInfo Compiled { get; private set; }

	public FileCompileResult(CompilingFileInfo fileInfo)
	{
		FileInfo = fileInfo;
		Compiled = new CompiledFileInfo
		{
			VirtualPath = fileInfo.VirtualPath,
			HashCode = fileInfo.GetHashCode()
		};
	}
}
