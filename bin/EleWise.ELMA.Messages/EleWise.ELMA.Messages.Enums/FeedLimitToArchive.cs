using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Messages.Enums;

public enum FeedLimitToArchive
{
	[DisplayName(typeof(__Resources_FeedLimitToArchive), "One")]
	One = 35,
	[DisplayName(typeof(__Resources_FeedLimitToArchive), "Two")]
	Two = 65,
	[DisplayName(typeof(__Resources_FeedLimitToArchive), "Three")]
	Three = 95,
	[DisplayName(typeof(__Resources_FeedLimitToArchive), "Four")]
	Four = 125,
	[DisplayName(typeof(__Resources_FeedLimitToArchive), "Five")]
	Five = 160,
	[DisplayName(typeof(__Resources_FeedLimitToArchive), "Six")]
	Six = 190
}
