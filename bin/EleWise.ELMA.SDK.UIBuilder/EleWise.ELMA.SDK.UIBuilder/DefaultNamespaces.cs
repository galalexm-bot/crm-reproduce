using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.SDK.UIBuilder;

internal sealed class DefaultNamespaces
{
	public class Core : NamespaceInfo
	{
		public override string Namespace => "EleWise.ELMA.Core";

		public override string DisplayName => string.Empty;
	}

	public class Scripts : NamespaceInfo
	{
		public override string Namespace => "EleWise.ELMA.Core.Scripts";

		public override string DisplayName => string.Empty;
	}
}
