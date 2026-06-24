using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.Common.Services;

[Service]
internal class EntityHistoryRestrictionService : IEntityHistoryRestrictionService, IEntityModelHistoryRestrictionService
{
	private const string SettingsFileName = "EntityModelHistorySettings.xml";

	private const string AllHistorySettingsFileName = "EntityHistorySettings.xml";

	private const string XmlVersion = "1.0";

	private const string XmlEncoding = "UTF-8";

	private const string EntityModelHistoryRestrictionMetadataName = "EntityModelHistoryRestriction";

	private const string ActionRestrictionsMetadataName = "ActionRestriction";

	private const string ActionRestrictionActionNameFieldName = "ActionName";

	private const string ActionRestrictionEntityNamesFieldName = "EntityNames";

	private const string ActionRestrictionFieldName = "ActionRestrictions";

	private const string ValueNodeName = "Name";

	private EntityHistoryRestriction restrictions;

	private IRuntimeApplication configuration;

	private static FileSystemWatcher watcher;

	private string EntityHistoryRestrictionMetadataName => "EntityHistoryRestriction";

	private string EntityRestrictionsMetadataName => "EntityRestriction";

	private string StopAllModelRestrictionName => "RestrictAllModel";

	private string StopAllActionRestrictionName => "RestrictAllAction";

	private string EntityRestrictionFieldName => "EntityRestrictions";

	private string EntityRestrictionEntityNameFieldName => "EntityName";

	private string EntityRestrictionActionNamesFieldName => "ActionNames";

	private string EntityHistoryTypeFieldName => "HistoryType";

	private string SettingsFileFullName => Path.Combine(Path.GetDirectoryName(configuration.Configuration.Config.FilePath), "EntityHistorySettings.xml");

	private string ModelSettingsFileFullName => Path.Combine(Path.GetDirectoryName(configuration.Configuration.Config.FilePath), "EntityModelHistorySettings.xml");

	private EntityHistoryRestriction EntityHistoryRestrictions
	{
		get
		{
			if (restrictions == null)
			{
				Load();
			}
			return restrictions;
		}
	}

	public EntityHistoryRestrictionService(IRuntimeApplication runtimeConfiguration)
	{
		configuration = runtimeConfiguration;
		watcher = new FileSystemWatcher(Path.GetDirectoryName(configuration.Configuration.Config.FilePath))
		{
			Filter = "EntityHistorySettings.xml",
			IncludeSubdirectories = false,
			EnableRaisingEvents = true,
			NotifyFilter = (NotifyFilters.FileName | NotifyFilters.LastWrite)
		};
		watcher.Created += Watch;
		watcher.Changed += Watch;
		watcher.Deleted += Watch;
	}

	public bool IsSupported(Guid typeUid, Guid? actionUid)
	{
		return IsSupported(typeUid, actionUid, 1);
	}

	public bool IsSupported(Guid typeUid, Guid? actionUid, int entityHistoryType)
	{
		if ((EntityHistoryRestrictions.RestrictAllModel && entityHistoryType == 1) || (EntityHistoryRestrictions.RestrictAllAction && entityHistoryType == 2))
		{
			return false;
		}
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		return IsSupportedInner(entityMetadata, actionUid, entityHistoryType);
	}

	private bool IsSupportedInner(EntityMetadata entityMetadata, Guid? actionUid, int entityHistoryType)
	{
		if (entityMetadata == null || EntityHistoryRestrictions.EntityRestrictions.Count == 0)
		{
			return true;
		}
		EnumValueMetadata enumValueMetadata = MetadataLoader.GetEntityActions(entityMetadata).FirstOrDefault(delegate(EnumValueMetadata a)
		{
			Guid uid = a.Uid;
			Guid? guid = actionUid;
			return uid == guid;
		});
		return !FindInEntityRestrictions((enumValueMetadata != null) ? enumValueMetadata.Name : string.Empty, entityMetadata.Name, entityHistoryType);
	}

	private bool FindInEntityRestrictions(string actionName, string entityName, int entityHistoryType)
	{
		return EntityHistoryRestrictions.EntityRestrictions.Any(delegate(EntityRestriction entityRestriction)
		{
			bool num = (entityRestriction.EntityName.Count == 0 && entityRestriction.ActionNames.Contains(actionName)) || entityRestriction.EntityName.Contains(entityName);
			bool flag = !entityRestriction.HistoryType.HasValue || entityRestriction.HistoryType == EntityHistoryType.All || entityRestriction.HistoryType.Value == (EntityHistoryType)entityHistoryType;
			bool flag2 = (entityRestriction.ActionNames.Count == 0 && entityRestriction.EntityName.Contains(entityName)) || entityRestriction.ActionNames.Contains(actionName);
			return num && flag && flag2;
		});
	}

	private void Watch(object sender, FileSystemEventArgs e)
	{
		Thread.Sleep(TimeSpan.FromSeconds(1.0));
		Load();
	}

	private void Load()
	{
		if (!File.Exists(SettingsFileFullName))
		{
			if (File.Exists(ModelSettingsFileFullName))
			{
				restrictions = ReadSettingsFile(ModelSettingsFileFullName, "EntityModelHistoryRestriction");
				foreach (EntityRestriction entityRestriction in restrictions.EntityRestrictions)
				{
					entityRestriction.HistoryType = EntityHistoryType.Model;
				}
			}
			else
			{
				restrictions = new EntityHistoryRestriction();
				restrictions.EntityRestrictions.Add(new EntityRestriction());
			}
			SaveSettingsFile();
		}
		else
		{
			restrictions = ReadSettingsFile(SettingsFileFullName, EntityHistoryRestrictionMetadataName);
		}
	}

	private EntityHistoryRestriction ReadSettingsFile(string filePath, string startTag)
	{
		EntityHistoryRestriction entityHistoryRestriction = new EntityHistoryRestriction();
		try
		{
			using FileStream inStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(inStream);
			XmlNode xmlNode = xmlDocument.SelectSingleNode(startTag);
			if (xmlNode != null)
			{
				XmlNode xmlNode2 = xmlNode.SelectSingleNode(StopAllModelRestrictionName);
				if (xmlNode2 != null)
				{
					bool result = false;
					if (bool.TryParse(xmlNode2.InnerText, out result))
					{
						entityHistoryRestriction.RestrictAllModel = result;
					}
				}
				XmlNode xmlNode3 = xmlNode.SelectSingleNode(StopAllActionRestrictionName);
				if (xmlNode3 != null)
				{
					bool result2 = false;
					if (bool.TryParse(xmlNode3.InnerText, out result2))
					{
						entityHistoryRestriction.RestrictAllAction = result2;
					}
				}
				XmlNode xmlNode4 = xmlNode.SelectSingleNode(EntityRestrictionFieldName);
				if (xmlNode4 != null)
				{
					xmlNode4.SelectNodes(EntityRestrictionsMetadataName);
					foreach (XmlElement item in xmlNode4)
					{
						EntityRestriction entityRestriction = ReadRestrictionElem(item, EntityRestrictionEntityNameFieldName, EntityRestrictionActionNamesFieldName);
						if (entityRestriction != null && (entityRestriction.EntityName.Any() || entityRestriction.ActionNames.Any()))
						{
							entityHistoryRestriction.EntityRestrictions.Add(entityRestriction);
						}
					}
				}
				XmlNode xmlNode5 = xmlNode.SelectSingleNode("ActionRestrictions");
				if (xmlNode5 != null)
				{
					XmlNodeList xmlNodeList = xmlNode5.SelectNodes("ActionRestriction");
					if (xmlNodeList != null)
					{
						foreach (XmlElement item2 in xmlNodeList)
						{
							EntityRestriction entityRestriction2 = ReadRestrictionElem(item2, "EntityNames", "ActionName");
							if (entityRestriction2 != null && (entityRestriction2.EntityName.Any() || entityRestriction2.ActionNames.Any()))
							{
								entityHistoryRestriction.EntityRestrictions.Add(entityRestriction2);
							}
						}
						return entityHistoryRestriction;
					}
					return entityHistoryRestriction;
				}
				return entityHistoryRestriction;
			}
			return entityHistoryRestriction;
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка считывания настроек исключений записи истории модели"), exception);
			if (restrictions == null)
			{
				restrictions = new EntityHistoryRestriction();
				return entityHistoryRestriction;
			}
			return entityHistoryRestriction;
		}
	}

	private EntityRestriction ReadRestrictionElem(XmlElement node, string entityNodeName, string actionNodeName)
	{
		if (node != null)
		{
			EntityRestriction entityRestriction = new EntityRestriction();
			XmlNode xmlNode = node.SelectSingleNode(entityNodeName);
			if (xmlNode != null)
			{
				foreach (object childNode in xmlNode.ChildNodes)
				{
					if (childNode is XmlElement xmlElement)
					{
						entityRestriction.EntityName.Add(xmlElement.InnerText);
						continue;
					}
					entityRestriction.EntityName.Add(xmlNode.InnerText);
					break;
				}
			}
			XmlNode xmlNode2 = node.SelectSingleNode(actionNodeName);
			if (xmlNode2 != null)
			{
				foreach (object childNode2 in xmlNode2.ChildNodes)
				{
					if (childNode2 is XmlElement xmlElement2)
					{
						entityRestriction.ActionNames.Add(xmlElement2.InnerText);
						continue;
					}
					entityRestriction.ActionNames.Add(xmlNode2.InnerText);
					break;
				}
			}
			entityRestriction.HistoryType = GetHistoryType(node);
			return entityRestriction;
		}
		return null;
	}

	private EntityHistoryType? GetHistoryType(XmlNode node)
	{
		XmlNode xmlNode = node.SelectSingleNode(EntityHistoryTypeFieldName);
		if (xmlNode != null && !string.IsNullOrWhiteSpace(xmlNode.InnerText))
		{
			switch (xmlNode.InnerText)
			{
			case "All":
				return EntityHistoryType.All;
			case "Model":
				return EntityHistoryType.Model;
			case "Action":
				return EntityHistoryType.Action;
			}
		}
		return null;
	}

	private void SaveSettingsFile()
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlDeclaration newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
			xmlDocument.AppendChild(newChild);
			XmlElement xmlElement = xmlDocument.CreateElement(EntityHistoryRestrictionMetadataName);
			xmlElement.AppendChild(CreateValueNode(StopAllModelRestrictionName, restrictions.RestrictAllModel.ToString(), xmlDocument));
			xmlElement.AppendChild(CreateValueNode(StopAllActionRestrictionName, restrictions.RestrictAllModel.ToString(), xmlDocument));
			XmlElement xmlElement2 = xmlDocument.CreateElement(EntityRestrictionFieldName);
			foreach (EntityRestriction entityRestriction in restrictions.EntityRestrictions)
			{
				XmlElement xmlElement3 = xmlDocument.CreateElement(EntityRestrictionsMetadataName);
				XmlElement xmlElement4 = xmlDocument.CreateElement(EntityRestrictionEntityNameFieldName);
				foreach (string item in entityRestriction.EntityName)
				{
					XmlElement newChild2 = CreateValueNode("Name", item, xmlDocument);
					xmlElement4.AppendChild(newChild2);
				}
				xmlElement3.AppendChild(xmlElement4);
				XmlElement xmlElement5 = xmlDocument.CreateElement(EntityRestrictionActionNamesFieldName);
				foreach (string actionName in entityRestriction.ActionNames)
				{
					XmlElement newChild3 = CreateValueNode("Name", actionName, xmlDocument);
					xmlElement5.AppendChild(newChild3);
				}
				xmlElement3.AppendChild(xmlElement5);
				string val = (entityRestriction.HistoryType.HasValue ? entityRestriction.HistoryType.Value.ToString() : string.Empty);
				XmlElement newChild4 = CreateValueNode(EntityHistoryTypeFieldName, val, xmlDocument);
				xmlElement3.AppendChild(newChild4);
				xmlElement2.AppendChild(xmlElement3);
				xmlElement.AppendChild(xmlElement2);
			}
			xmlDocument.AppendChild(xmlElement);
			xmlDocument.Save(SettingsFileFullName);
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка записи настроек исключений истории"), exception);
		}
	}

	private XmlElement CreateValueNode(string elementName, string val, XmlDocument doc)
	{
		XmlElement xmlElement = doc.CreateElement(elementName);
		xmlElement.InnerXml = val;
		return xmlElement;
	}
}
