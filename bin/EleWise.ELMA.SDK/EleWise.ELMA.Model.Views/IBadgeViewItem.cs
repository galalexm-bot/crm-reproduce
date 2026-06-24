namespace EleWise.ELMA.Model.Views;

internal interface IBadgeViewItem
{
	string BadgeText { get; set; }

	bool Dot { get; set; }

	ButtonStyle BadgeStyle { get; set; }
}
