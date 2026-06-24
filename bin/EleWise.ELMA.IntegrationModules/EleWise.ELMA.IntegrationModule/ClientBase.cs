using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.ExtensionPoint;
using EleWise.ELMA.IntegrationModules.Extensions;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.IntegrationModules.Models.CodeGeneration;

public abstract class ClientBase<TChannel> where TChannel : class
{
	private ChannelFactory<TChannel> channelFactory;

	private TChannel channel;

	public ClientCredentials ClientCredentials => channelFactory.Credentials;

	public TChannel Channel => channel ?? (channel = channelFactory.CreateChannel());

	protected ClientBase()
	{
		System.Configuration.Configuration configuration = OpenConfiguration();
		channelFactory = new ConfigurationChannelFactory<TChannel>("*", configuration, null);
	}

	protected ClientBase(string endpointAddress)
	{
		System.Configuration.Configuration configuration = OpenConfiguration();
		channelFactory = new ConfigurationChannelFactory<TChannel>("*", configuration, new EndpointAddress(endpointAddress));
	}

	protected ClientBase(Binding binding, EndpointAddress endpoint)
	{
		channelFactory = new ChannelFactory<TChannel>(binding, endpoint);
	}

	protected ClientBase(Binding binding, EndpointAddress endpoint, IDictionary<string, string> headers)
	{
		channelFactory = new ChannelFactory<TChannel>(binding, endpoint);
		channelFactory.Endpoint.EndpointBehaviors.Add(new EndpointBehaviour(headers));
	}

	protected ClientBase(Binding binding, EndpointAddress endpoint, IIntegrationModule integrationModule)
	{
		channelFactory = new ChannelFactory<TChannel>(binding, endpoint);
		foreach (IClientCredentialsDataFiller extensionPoint in ComponentManager.Current.GetExtensionPoints<IClientCredentialsDataFiller>())
		{
			IAuthenticationDataFillingResult authenticationDataFillingResult = extensionPoint.FillInAuthenticationData(ClientCredentials, integrationModule);
			if (authenticationDataFillingResult != null && authenticationDataFillingResult.Success)
			{
				break;
			}
		}
	}

	private System.Configuration.Configuration OpenConfiguration()
	{
		Type typeFromHandle = typeof(TChannel);
		return ConfigurationManager.OpenExeConfiguration(GetExeFile(Locator.GetServiceNotNull<ServiceReferenceHelper>().GetAppConfigPath(typeFromHandle)));
	}

	private static string GetExeFile(string fileName)
	{
		string text = Path.GetFileNameWithoutExtension(fileName);
		string directoryName = Path.GetDirectoryName(fileName);
		if (directoryName != null && text != null)
		{
			text = Path.Combine(directoryName, text);
		}
		if (!File.Exists(text))
		{
			File.Create(text).Close();
		}
		return text;
	}
}
