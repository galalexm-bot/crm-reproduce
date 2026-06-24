using Bridge;

namespace EleWise.ELMA.Helpers.TinyMCE;

[External]
public class Editor
{
	[Name("destroy")]
	public extern void Destroy();

	[Name("setContent")]
	public extern void SetContent(string value);
}
