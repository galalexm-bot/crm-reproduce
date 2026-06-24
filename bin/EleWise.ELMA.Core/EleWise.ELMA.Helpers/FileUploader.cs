using Bridge;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Helpers;

[External]
public sealed class FileUploader
{
	[Template("new html5upl.FileUploader({options})")]
	public extern FileUploader(Html5UplOptions options);

	[Template("uploadFile({file}, {id})")]
	public extern void UploadFile(object file, long id);
}
