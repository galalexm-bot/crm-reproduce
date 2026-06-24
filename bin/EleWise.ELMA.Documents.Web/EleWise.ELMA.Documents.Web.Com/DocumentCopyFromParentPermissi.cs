using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Components;

namespace EleWise.ELMA.Documents.Web.Components
{
	[Component]
	public class DocumentCopyFromParentPermissionViewItemRenderer : PropertyViewItemRenderer
	{
		public override bool CanRender(ViewItem viewItem)
		{
			return viewItem.GetType() == typeof(DocumentCopyFromParentPermissionViewItem);
		}
	}
}
namespace EleWise.ELMA.Documents.Web.Components.ViewItemContentExtension
{
	internal sealed class DocumentCopyFromParentPermissionViewItemContentExtension : DocumentViewItemContentExtension<DocumentCopyFromParentPermissionViewItem>
	{
	}
}
