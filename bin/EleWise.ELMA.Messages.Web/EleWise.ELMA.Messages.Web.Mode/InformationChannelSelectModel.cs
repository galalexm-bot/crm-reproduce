namespace EleWise.ELMA.Messages.Web.Models;

public class InformationChannelSelectModel
{
	private TypeChannelsEnum typeChannels;

	private InformationChannelTableSetModel channels;

	public TypeChannelsEnum TypeChannels
	{
		get
		{
			return typeChannels;
		}
		set
		{
			typeChannels = value;
			SetTypeChannels();
		}
	}

	public bool CompactView { get; set; }

	public InformationChannelTableSetModel Channels
	{
		get
		{
			return channels;
		}
		set
		{
			channels = value;
			SetTypeChannels();
		}
	}

	private void SetTypeChannels()
	{
		if (channels != null)
		{
			channels.TypeChannels = typeChannels;
		}
	}

	public InformationChannelSelectModel()
	{
		Init(null);
	}

	public InformationChannelSelectModel(InformationChannelTableSetModel channels)
	{
		Init(channels);
	}

	private void Init(InformationChannelTableSetModel channelsTableSetModel)
	{
		if (channelsTableSetModel == null)
		{
			channelsTableSetModel = new InformationChannelTableSetModel();
		}
		CompactView = false;
		Channels = channelsTableSetModel;
		TypeChannels = TypeChannelsEnum.General;
	}
}
