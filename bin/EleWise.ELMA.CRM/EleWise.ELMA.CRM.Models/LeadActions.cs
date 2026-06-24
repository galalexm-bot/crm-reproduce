using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

public class LeadActions : DefaultEntityActions
{
	[Uid("93414f22-c4ac-42d0-8ad4-051d6ac57374")]
	[DisplayName(typeof(__Resources_LeadActions), "P_AddComment_DisplayName")]
	[Image(typeof(LeadActions), "comment_outline", 16, ImageFormatType.IconPack, false)]
	public const string AddComment = "93414f22-c4ac-42d0-8ad4-051d6ac57374";

	private static Guid _addCommentGuid = new Guid("93414f22-c4ac-42d0-8ad4-051d6ac57374");

	[Uid("932ce7e9-1d01-4d19-b44f-80b015650d70")]
	[DisplayName(typeof(__Resources_LeadActions), "P_InHand_DisplayName")]
	public const string InHand = "932ce7e9-1d01-4d19-b44f-80b015650d70";

	private static Guid _inHandGuid = new Guid("932ce7e9-1d01-4d19-b44f-80b015650d70");

	[Uid("67d829bf-c660-43bf-8fe5-251181c95e0a")]
	[DisplayName(typeof(__Resources_LeadActions), "P_Qualified_DisplayName")]
	public const string Qualified = "67d829bf-c660-43bf-8fe5-251181c95e0a";

	private static Guid _qualifiedGuid = new Guid("67d829bf-c660-43bf-8fe5-251181c95e0a");

	[Uid("69949aae-a844-4920-8e8a-db4cffeebe91")]
	[DisplayName(typeof(__Resources_LeadActions), "P_Unqualified_DisplayName")]
	public const string Unqualified = "69949aae-a844-4920-8e8a-db4cffeebe91";

	private static Guid _unqualifiedGuid = new Guid("69949aae-a844-4920-8e8a-db4cffeebe91");

	[Uid("769ca33f-c027-4659-b9e9-00d0d2098616")]
	[DisplayName(typeof(__Resources_LeadActions), "P_Activated_DisplayName")]
	public const string Activated = "769ca33f-c027-4659-b9e9-00d0d2098616";

	private static Guid _activatedGuid = new Guid("769ca33f-c027-4659-b9e9-00d0d2098616");

	[Uid("e6e05588-fa3b-44fc-b817-a76be2505c87")]
	[DisplayName(typeof(__Resources_LeadActions), "P_Dublicate_DisplayName")]
	[Image(typeof(LeadActions), "users", 16, ImageFormatType.IconPack, false)]
	public const string Dublicate = "e6e05588-fa3b-44fc-b817-a76be2505c87";

	private static Guid _dublicateGuid = new Guid("e6e05588-fa3b-44fc-b817-a76be2505c87");

	public static Guid AddCommentGuid => _addCommentGuid;

	public static Guid InHandGuid => _inHandGuid;

	public static Guid QualifiedGuid => _qualifiedGuid;

	public static Guid UnqualifiedGuid => _unqualifiedGuid;

	public static Guid ActivatedGuid => _activatedGuid;

	public static Guid DublicateGuid => _dublicateGuid;

	protected LeadActions()
	{
	}
}
