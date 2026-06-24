using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface IClipboardService
{
	void CopyToClipboard(string text);

	System.Threading.Tasks.Task<string> PasteFromClipboard();
}
