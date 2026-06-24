using System.Diagnostics;

namespace EleWise.ELMA.Files.Previews;

public interface IPasswordFilePreviewCreatorEx : IFilePreviewCreatorEx, IFilePreviewCreator, IPasswordFilePreviewCreator
{
	Process CreateWithExternalCreator(string filePreviewDir, BinaryFile file, string password);
}
