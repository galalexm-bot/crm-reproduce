using System;

namespace EleWise.ELMA.Messages.Channels;

public static class InternalMailChannelDescriptor
{
	public static readonly Guid UID = new Guid("{2C784060-53C5-4845-A838-4737D70795C6}");

	public static string Name => "InternalMail";

	public static string DisplayName => SR.T("Web-приложение");
}
