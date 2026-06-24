using System.Drawing;

namespace EleWise.ELMA.Model.Attributes;

public interface IImageAttribute
{
	int Size { get; }

	bool IsDefault { get; }

	Image CreateImage();
}
