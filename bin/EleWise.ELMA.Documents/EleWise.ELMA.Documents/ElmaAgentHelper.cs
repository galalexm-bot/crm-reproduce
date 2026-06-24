using System.Collections.Generic;
using System.Globalization;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Hubs.Services;

namespace EleWise.ELMA.Documents;

internal static class ElmaAgentHelper
{
	private static readonly IAgentHubService agentHubService = Locator.GetServiceNotNull<IAgentHubService>();

	private static readonly ITransformationProvider transform = Locator.GetServiceNotNull<ITransformationProvider>();

	private const string DocumentAccessUsersKey = "EleWise.ELMA.Documents.ElmaAgentHelper.DocumentAccessUsers";

	private const string Separator = "_";

	private const string DocumentPermissionsChangedCommand = "DocumentPermissionsChanged";

	private const string DocumentRefreshCommand = "DocumentRefresh";

	private const string DocumentVersionRefreshCommand = "DocumentVersionRefresh";

	private const string ProcessDocumentKey = "EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocument";

	private const string ProcessDocumentVersionKey = "EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocumentVersion";

	private const string ProcessDocumentPermissionsChangedKey = "EleWise.ELMA.Documents.ElmaAgentHelper.DocumentPermissionsChanged";

	public static void SendRefreshCommand(IDocument document)
	{
		if (document != null && !document.IsNew() && !IsRefreshCommandProcessed(document))
		{
			ProcessRefreshCommand(document);
			agentHubService.SendAll("DocumentRefresh", document.Id.ToString(CultureInfo.InvariantCulture));
		}
	}

	public static void SendRefreshCommand(IDocumentVersion version)
	{
		if (version != null && !version.IsNew() && !IsRefreshCommandProcessed(version))
		{
			string arguments = version.Document.Id.ToString(CultureInfo.InvariantCulture) + "_" + version.Id.ToString(CultureInfo.InvariantCulture);
			agentHubService.SendAll("DocumentVersionRefresh", arguments);
			ProcessRefreshCommand(version);
		}
	}

	public static void SendDocumentPermissionsChangedCommand(IDocument document)
	{
		if (!IsDocumentPermissionsChangedCommandProcessed(document))
		{
			agentHubService.SendAll("DocumentPermissionsChanged", document.Id.ToString(CultureInfo.InvariantCulture));
			ProcessDocumentPermissionsChangedCommand(document);
		}
	}

	public static void ProcessRefreshCommand(IDocument document)
	{
		List<long> orAdd = ContextVars.GetOrAdd("EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocument", () => new List<long>());
		orAdd.Add(document.Id);
		ContextVars.Set("EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocument", orAdd);
	}

	public static bool IsRefreshCommandProcessed(IDocument document)
	{
		return ContextVars.GetOrAdd("EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocument", () => new List<long>()).Contains(document.Id);
	}

	public static void ProcessRefreshCommand(IDocumentVersion documentVer)
	{
		List<long> orAdd = ContextVars.GetOrAdd("EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocumentVersion", () => new List<long>());
		orAdd.Add(documentVer.Id);
		ContextVars.Set("EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocumentVersion", orAdd);
	}

	public static bool IsRefreshCommandProcessed(IDocumentVersion documentVer)
	{
		return ContextVars.GetOrAdd("EleWise.ELMA.Documents.ElmaAgentHelper.ProcessDocumentVersion", () => new List<long>()).Contains(documentVer.Id);
	}

	public static void ProcessDocumentPermissionsChangedCommand(IDocument document)
	{
		List<long> orAdd = ContextVars.GetOrAdd("EleWise.ELMA.Documents.ElmaAgentHelper.DocumentPermissionsChanged", () => new List<long>());
		orAdd.Add(document.Id);
		ContextVars.Set("EleWise.ELMA.Documents.ElmaAgentHelper.DocumentPermissionsChanged", orAdd);
	}

	public static bool IsDocumentPermissionsChangedCommandProcessed(IDocument document)
	{
		return ContextVars.GetOrAdd("EleWise.ELMA.Documents.ElmaAgentHelper.DocumentPermissionsChanged", () => new List<long>()).Contains(document.Id);
	}
}
