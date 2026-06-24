using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[FilterFor(typeof(IChannelMessage))]
public interface IChannelMessageFilter : IBaseMessageFilter, IEntityFilter
{
	ChannelMessageType? MessageType { get; set; }

	IChannelMessage Parent { get; set; }

	[CustomFilterProperty]
	[Uid("4996ab30-178c-4afb-842d-6bccfc7caca7")]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsAnswer")]
	[DisplayName(typeof(__Resources_IChannelMessage), "FP_IsAnswer_DisplayName")]
	[Description(typeof(__Resources_IChannelMessage), "FP_IsAnswer_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? IsAnswer { get; set; }
}
