using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

[DynamicPropertyContainer]
internal interface IBadgeViewItem : IViewItem, IReactive
{
	[DynamicProperty(false)]
	string BadgeText { get; set; }

	[DynamicProperty(false)]
	bool Dot { get; set; }

	[DynamicProperty(false)]
	ButtonStyle BadgeStyle { get; set; }
}
